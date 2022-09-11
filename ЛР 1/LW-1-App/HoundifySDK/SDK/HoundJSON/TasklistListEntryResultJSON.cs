/* file "TasklistListEntryResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TasklistListEntryResultJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_AppendSuccess,
        Value_AppendAlreadyOn,
        Value_AppendAskCreate,
        Value_AppendAskCreateDidCancel,
        Value_LookupFound,
        Value_LookupNotFound,
        Value_LookupListNotFound,
        Value_RemoveSuccess,
        Value_RemoveEntryNotFound,
        Value_RemoveListNotFound,
        Value_CreateAppendSuccess,
        Value_CreateAppendAlreadyOn,
        Value_CreateAppendExistsAskJustAppend,
        Value_CreateAppendExistsAskJustAppendCancel,
        Value_Error,
        Value__none
      };
    public struct TypeValue
      {
        public bool in_known_list;
        public string string_value;
        public TypeValueKnownValues list_value;
      };

    public static TypeValueKnownValues  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if (String.Compare(chars, 1, "ppend", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'A':
                            switch (chars[7])
                              {
                                case 'l':
                                    if ((String.Compare(chars, 8, "readyOn", 0, 7, false) == 0) && (chars.Length == 15))
                                        return TypeValueKnownValues.Value_AppendAlreadyOn;
                                    break;
                                case 's':
                                    if (String.Compare(chars, 8, "kCreate", 0, 7, false) == 0)
                                      {
                                        if (chars.Length == 15)
                                          {
                                            return TypeValueKnownValues.Value_AppendAskCreate;
                                          }
                                        switch (chars[15])
                                          {
                                            case 'D':
                                                if ((String.Compare(chars, 16, "idCancel", 0, 8, false) == 0) && (chars.Length == 24))
                                                    return TypeValueKnownValues.Value_AppendAskCreateDidCancel;
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
                        case 'S':
                            if ((String.Compare(chars, 7, "uccess", 0, 6, false) == 0) && (chars.Length == 13))
                                return TypeValueKnownValues.Value_AppendSuccess;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                if (String.Compare(chars, 1, "reateAppend", 0, 11, false) == 0)
                  {
                    switch (chars[12])
                      {
                        case 'A':
                            if ((String.Compare(chars, 13, "lreadyOn", 0, 8, false) == 0) && (chars.Length == 21))
                                return TypeValueKnownValues.Value_CreateAppendAlreadyOn;
                            break;
                        case 'E':
                            if (String.Compare(chars, 13, "xistsAskJustAppend", 0, 18, false) == 0)
                              {
                                if (chars.Length == 31)
                                  {
                                    return TypeValueKnownValues.Value_CreateAppendExistsAskJustAppend;
                                  }
                                switch (chars[31])
                                  {
                                    case 'C':
                                        if ((String.Compare(chars, 32, "ancel", 0, 5, false) == 0) && (chars.Length == 37))
                                            return TypeValueKnownValues.Value_CreateAppendExistsAskJustAppendCancel;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if ((String.Compare(chars, 13, "uccess", 0, 6, false) == 0) && (chars.Length == 19))
                                return TypeValueKnownValues.Value_CreateAppendSuccess;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(chars, 1, "rror", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeValueKnownValues.Value_Error;
                break;
            case 'L':
                if (String.Compare(chars, 1, "ookup", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'F':
                            if ((String.Compare(chars, 7, "ound", 0, 4, false) == 0) && (chars.Length == 11))
                                return TypeValueKnownValues.Value_LookupFound;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 7, "istNotFound", 0, 11, false) == 0) && (chars.Length == 18))
                                return TypeValueKnownValues.Value_LookupListNotFound;
                            break;
                        case 'N':
                            if ((String.Compare(chars, 7, "otFound", 0, 7, false) == 0) && (chars.Length == 14))
                                return TypeValueKnownValues.Value_LookupNotFound;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(chars, 1, "emove", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'E':
                            if ((String.Compare(chars, 7, "ntryNotFound", 0, 12, false) == 0) && (chars.Length == 19))
                                return TypeValueKnownValues.Value_RemoveEntryNotFound;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 7, "istNotFound", 0, 11, false) == 0) && (chars.Length == 18))
                                return TypeValueKnownValues.Value_RemoveListNotFound;
                            break;
                        case 'S':
                            if ((String.Compare(chars, 7, "uccess", 0, 6, false) == 0) && (chars.Length == 13))
                                return TypeValueKnownValues.Value_RemoveSuccess;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeValueKnownValues.Value__none;
      }

    public static string  stringFromValue(TypeValueKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeValueKnownValues.Value_AppendSuccess:
                return "AppendSuccess";
            case TypeValueKnownValues.Value_AppendAlreadyOn:
                return "AppendAlreadyOn";
            case TypeValueKnownValues.Value_AppendAskCreate:
                return "AppendAskCreate";
            case TypeValueKnownValues.Value_AppendAskCreateDidCancel:
                return "AppendAskCreateDidCancel";
            case TypeValueKnownValues.Value_LookupFound:
                return "LookupFound";
            case TypeValueKnownValues.Value_LookupNotFound:
                return "LookupNotFound";
            case TypeValueKnownValues.Value_LookupListNotFound:
                return "LookupListNotFound";
            case TypeValueKnownValues.Value_RemoveSuccess:
                return "RemoveSuccess";
            case TypeValueKnownValues.Value_RemoveEntryNotFound:
                return "RemoveEntryNotFound";
            case TypeValueKnownValues.Value_RemoveListNotFound:
                return "RemoveListNotFound";
            case TypeValueKnownValues.Value_CreateAppendSuccess:
                return "CreateAppendSuccess";
            case TypeValueKnownValues.Value_CreateAppendAlreadyOn:
                return "CreateAppendAlreadyOn";
            case TypeValueKnownValues.Value_CreateAppendExistsAskJustAppend:
                return "CreateAppendExistsAskJustAppend";
            case TypeValueKnownValues.Value_CreateAppendExistsAskJustAppendCancel:
                return "CreateAppendExistsAskJustAppendCancel";
            case TypeValueKnownValues.Value_Error:
                return "Error";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private TypeValue storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of TasklistListEntryResultJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                if (String.Compare(json_string.getData(), 1, "ppend", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'A':
                            switch (json_string.getData()[7])
                              {
                                case 'l':
                                    if ((String.Compare(json_string.getData(), 8, "readyOn", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_AppendAlreadyOn;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 's':
                                    if (String.Compare(json_string.getData(), 8, "kCreate", 0, 7, false) == 0)
                                      {
                                        if (json_string.getData().Length == 15)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_AppendAskCreate;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[15])
                                          {
                                            case 'D':
                                                if ((String.Compare(json_string.getData(), 16, "idCancel", 0, 8, false) == 0) && (json_string.getData().Length == 24))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeValueKnownValues.Value_AppendAskCreateDidCancel;
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
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 7, "uccess", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_AppendSuccess;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                if (String.Compare(json_string.getData(), 1, "reateAppend", 0, 11, false) == 0)
                  {
                    switch (json_string.getData()[12])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 13, "lreadyOn", 0, 8, false) == 0) && (json_string.getData().Length == 21))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_CreateAppendAlreadyOn;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'E':
                            if (String.Compare(json_string.getData(), 13, "xistsAskJustAppend", 0, 18, false) == 0)
                              {
                                if (json_string.getData().Length == 31)
                                  {
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_CreateAppendExistsAskJustAppend;
                                        goto open_enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[31])
                                  {
                                    case 'C':
                                        if ((String.Compare(json_string.getData(), 32, "ancel", 0, 5, false) == 0) && (json_string.getData().Length == 37))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_CreateAppendExistsAskJustAppendCancel;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 13, "uccess", 0, 6, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_CreateAppendSuccess;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "rror", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Error;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if (String.Compare(json_string.getData(), 1, "ookup", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'F':
                            if ((String.Compare(json_string.getData(), 7, "ound", 0, 4, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_LookupFound;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 7, "istNotFound", 0, 11, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_LookupListNotFound;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'N':
                            if ((String.Compare(json_string.getData(), 7, "otFound", 0, 7, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_LookupNotFound;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if (String.Compare(json_string.getData(), 1, "emove", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'E':
                            if ((String.Compare(json_string.getData(), 7, "ntryNotFound", 0, 12, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_RemoveEntryNotFound;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 7, "istNotFound", 0, 11, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_RemoveListNotFound;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 7, "uccess", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_RemoveSuccess;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public TasklistListEntryResultJSON()
      {
        flagHasValue = false;
      }

    public TasklistListEntryResultJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public TasklistListEntryResultJSON(string init_value)
      {
        flagHasValue = true;
        TypeValueKnownValues known = stringToValue(init_value);
        if (known == TypeValueKnownValues.Value__none)
          {
            storeValue.in_known_list = false;
            storeValue.string_value = init_value;
          }
        else
          {
            storeValue.in_known_list = true;
            storeValue.list_value = known;
          }
      }

    public TasklistListEntryResultJSON(TypeValueKnownValues init_value)
      {
        flagHasValue = true;
        Debug.Assert(init_value != TypeValueKnownValues.Value__none);
        storeValue.in_known_list = true;
        storeValue.list_value = init_value;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public TypeValue  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public string  getValueAsString()
      {
        TypeValue result = getValue();
        if (result.in_known_list)
            return stringFromValue(result.list_value);
        else
            return result.string_value;
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        TypeValueKnownValues known = stringToValue(chars);
        TypeValue new_value = new TypeValue();
        if (known == TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setValue(new_value);
      }
    public void setValue(TypeValueKnownValues new_value)
      {
        TypeValue new_full_value = new TypeValue();
        Debug.Assert(new_value != TypeValueKnownValues.Value__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setValue(new_full_value);
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_AppendSuccess:
                    handler.string_value("AppendSuccess");
                    break;
                case TypeValueKnownValues.Value_AppendAlreadyOn:
                    handler.string_value("AppendAlreadyOn");
                    break;
                case TypeValueKnownValues.Value_AppendAskCreate:
                    handler.string_value("AppendAskCreate");
                    break;
                case TypeValueKnownValues.Value_AppendAskCreateDidCancel:
                    handler.string_value("AppendAskCreateDidCancel");
                    break;
                case TypeValueKnownValues.Value_LookupFound:
                    handler.string_value("LookupFound");
                    break;
                case TypeValueKnownValues.Value_LookupNotFound:
                    handler.string_value("LookupNotFound");
                    break;
                case TypeValueKnownValues.Value_LookupListNotFound:
                    handler.string_value("LookupListNotFound");
                    break;
                case TypeValueKnownValues.Value_RemoveSuccess:
                    handler.string_value("RemoveSuccess");
                    break;
                case TypeValueKnownValues.Value_RemoveEntryNotFound:
                    handler.string_value("RemoveEntryNotFound");
                    break;
                case TypeValueKnownValues.Value_RemoveListNotFound:
                    handler.string_value("RemoveListNotFound");
                    break;
                case TypeValueKnownValues.Value_CreateAppendSuccess:
                    handler.string_value("CreateAppendSuccess");
                    break;
                case TypeValueKnownValues.Value_CreateAppendAlreadyOn:
                    handler.string_value("CreateAppendAlreadyOn");
                    break;
                case TypeValueKnownValues.Value_CreateAppendExistsAskJustAppend:
                    handler.string_value("CreateAppendExistsAskJustAppend");
                    break;
                case TypeValueKnownValues.Value_CreateAppendExistsAskJustAppendCancel:
                    handler.string_value("CreateAppendExistsAskJustAppendCancel");
                    break;
                case TypeValueKnownValues.Value_Error:
                    handler.string_value("Error");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_AppendSuccess:
                    handler.string_value("AppendSuccess");
                    break;
                case TypeValueKnownValues.Value_AppendAlreadyOn:
                    handler.string_value("AppendAlreadyOn");
                    break;
                case TypeValueKnownValues.Value_AppendAskCreate:
                    handler.string_value("AppendAskCreate");
                    break;
                case TypeValueKnownValues.Value_AppendAskCreateDidCancel:
                    handler.string_value("AppendAskCreateDidCancel");
                    break;
                case TypeValueKnownValues.Value_LookupFound:
                    handler.string_value("LookupFound");
                    break;
                case TypeValueKnownValues.Value_LookupNotFound:
                    handler.string_value("LookupNotFound");
                    break;
                case TypeValueKnownValues.Value_LookupListNotFound:
                    handler.string_value("LookupListNotFound");
                    break;
                case TypeValueKnownValues.Value_RemoveSuccess:
                    handler.string_value("RemoveSuccess");
                    break;
                case TypeValueKnownValues.Value_RemoveEntryNotFound:
                    handler.string_value("RemoveEntryNotFound");
                    break;
                case TypeValueKnownValues.Value_RemoveListNotFound:
                    handler.string_value("RemoveListNotFound");
                    break;
                case TypeValueKnownValues.Value_CreateAppendSuccess:
                    handler.string_value("CreateAppendSuccess");
                    break;
                case TypeValueKnownValues.Value_CreateAppendAlreadyOn:
                    handler.string_value("CreateAppendAlreadyOn");
                    break;
                case TypeValueKnownValues.Value_CreateAppendExistsAskJustAppend:
                    handler.string_value("CreateAppendExistsAskJustAppend");
                    break;
                case TypeValueKnownValues.Value_CreateAppendExistsAskJustAppendCancel:
                    handler.string_value("CreateAppendExistsAskJustAppendCancel");
                    break;
                case TypeValueKnownValues.Value_Error:
                    handler.string_value("Error");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }

    public static TasklistListEntryResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TasklistListEntryResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistListEntryResult", ignore_extras);
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
    public static TasklistListEntryResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TasklistListEntryResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TasklistListEntryResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistListEntryResult", ignore_extras);
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
    public static TasklistListEntryResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TasklistListEntryResultJSON from_text(string text, bool ignore_extras)
      {
        TasklistListEntryResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistListEntryResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TasklistListEntryResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TasklistListEntryResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TasklistListEntryResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistListEntryResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONStringGenerator
      {
        protected FieldGeneratorValue(string what)
          {
            set_what(what);
          }
        protected FieldGeneratorValue()
          {
          }
        protected override void handle_result(string result)
          {
            TypeValueKnownValues known = stringToValue(result);
            TypeValue new_value = new TypeValue();
            if (known == TypeValueKnownValues.Value__none)
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
        protected abstract void handle_result(TypeValue result);
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
  {
    protected override void handle_result(TypeValue result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorValue(String what)
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
    public TypeValue value;
  };
    public class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValue
      {
        private FieldHoldingArrayGeneratorValue top;

        protected override void handle_result(TypeValue result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top)
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
    protected virtual void handle_result(List<TypeValue> result)
      {
      }

    public FieldHoldingArrayGeneratorValue(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValue> value;
  };
    public abstract class Generator : FieldGeneratorValue
      {
        protected override void handle_result(TypeValue new_value)
          {
            TasklistListEntryResultJSON result = new TasklistListEntryResultJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(TasklistListEntryResultJSON new_result);
        public Generator(bool ignore_extras) : base("Type TasklistListEntryResult")
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TasklistListEntryResultJSON  result)
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
        public TasklistListEntryResultJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TasklistListEntryResultJSON  result)
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
    protected virtual void handle_result(List<TasklistListEntryResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TasklistListEntryResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TasklistListEntryResultJSON>();
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
    public List<TasklistListEntryResultJSON> value;
  };
  };
