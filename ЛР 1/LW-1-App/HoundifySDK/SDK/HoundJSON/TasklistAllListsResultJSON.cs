/* file "TasklistAllListsResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TasklistAllListsResultJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_EnumerateSuccess,
        Value_EnumerateNoneExists,
        Value_ClearSuccess,
        Value_ClearNoListExists,
        Value_ClearNoItemExists,
        Value_ClearAskConfirm,
        Value_ClearDidCancel,
        Value_DeleteSuccess,
        Value_DeleteNoneExists,
        Value_DeleteAskConfirm,
        Value_DeleteDidCancel,
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
            case 'C':
                if (String.Compare(chars, 1, "lear", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'A':
                            if ((String.Compare(chars, 6, "skConfirm", 0, 9, false) == 0) && (chars.Length == 15))
                                return TypeValueKnownValues.Value_ClearAskConfirm;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 6, "idCancel", 0, 8, false) == 0) && (chars.Length == 14))
                                return TypeValueKnownValues.Value_ClearDidCancel;
                            break;
                        case 'N':
                            if (String.Compare(chars, 6, "o", 0, 1, false) == 0)
                              {
                                switch (chars[7])
                                  {
                                    case 'I':
                                        if ((String.Compare(chars, 8, "temExists", 0, 9, false) == 0) && (chars.Length == 17))
                                            return TypeValueKnownValues.Value_ClearNoItemExists;
                                        break;
                                    case 'L':
                                        if ((String.Compare(chars, 8, "istExists", 0, 9, false) == 0) && (chars.Length == 17))
                                            return TypeValueKnownValues.Value_ClearNoListExists;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if ((String.Compare(chars, 6, "uccess", 0, 6, false) == 0) && (chars.Length == 12))
                                return TypeValueKnownValues.Value_ClearSuccess;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                if (String.Compare(chars, 1, "elete", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'A':
                            if ((String.Compare(chars, 7, "skConfirm", 0, 9, false) == 0) && (chars.Length == 16))
                                return TypeValueKnownValues.Value_DeleteAskConfirm;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 7, "idCancel", 0, 8, false) == 0) && (chars.Length == 15))
                                return TypeValueKnownValues.Value_DeleteDidCancel;
                            break;
                        case 'N':
                            if ((String.Compare(chars, 7, "oneExists", 0, 9, false) == 0) && (chars.Length == 16))
                                return TypeValueKnownValues.Value_DeleteNoneExists;
                            break;
                        case 'S':
                            if ((String.Compare(chars, 7, "uccess", 0, 6, false) == 0) && (chars.Length == 13))
                                return TypeValueKnownValues.Value_DeleteSuccess;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                switch (chars[1])
                  {
                    case 'n':
                        if (String.Compare(chars, 2, "umerate", 0, 7, false) == 0)
                          {
                            switch (chars[9])
                              {
                                case 'N':
                                    if ((String.Compare(chars, 10, "oneExists", 0, 9, false) == 0) && (chars.Length == 19))
                                        return TypeValueKnownValues.Value_EnumerateNoneExists;
                                    break;
                                case 'S':
                                    if ((String.Compare(chars, 10, "uccess", 0, 6, false) == 0) && (chars.Length == 16))
                                        return TypeValueKnownValues.Value_EnumerateSuccess;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "ror", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_Error;
                        break;
                    default:
                        break;
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
            case TypeValueKnownValues.Value_EnumerateSuccess:
                return "EnumerateSuccess";
            case TypeValueKnownValues.Value_EnumerateNoneExists:
                return "EnumerateNoneExists";
            case TypeValueKnownValues.Value_ClearSuccess:
                return "ClearSuccess";
            case TypeValueKnownValues.Value_ClearNoListExists:
                return "ClearNoListExists";
            case TypeValueKnownValues.Value_ClearNoItemExists:
                return "ClearNoItemExists";
            case TypeValueKnownValues.Value_ClearAskConfirm:
                return "ClearAskConfirm";
            case TypeValueKnownValues.Value_ClearDidCancel:
                return "ClearDidCancel";
            case TypeValueKnownValues.Value_DeleteSuccess:
                return "DeleteSuccess";
            case TypeValueKnownValues.Value_DeleteNoneExists:
                return "DeleteNoneExists";
            case TypeValueKnownValues.Value_DeleteAskConfirm:
                return "DeleteAskConfirm";
            case TypeValueKnownValues.Value_DeleteDidCancel:
                return "DeleteDidCancel";
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
            throw new Exception("The value for field Value of TasklistAllListsResultJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'C':
                if (String.Compare(json_string.getData(), 1, "lear", 0, 4, false) == 0)
                  {
                    switch (json_string.getData()[5])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 6, "skConfirm", 0, 9, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_ClearAskConfirm;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 6, "idCancel", 0, 8, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_ClearDidCancel;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'N':
                            if (String.Compare(json_string.getData(), 6, "o", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[7])
                                  {
                                    case 'I':
                                        if ((String.Compare(json_string.getData(), 8, "temExists", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_ClearNoItemExists;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'L':
                                        if ((String.Compare(json_string.getData(), 8, "istExists", 0, 9, false) == 0) && (json_string.getData().Length == 17))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_ClearNoListExists;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 6, "uccess", 0, 6, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_ClearSuccess;
                                    goto open_enum_is_done;
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
                    switch (json_string.getData()[6])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 7, "skConfirm", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_DeleteAskConfirm;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 7, "idCancel", 0, 8, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_DeleteDidCancel;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'N':
                            if ((String.Compare(json_string.getData(), 7, "oneExists", 0, 9, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_DeleteNoneExists;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 7, "uccess", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_DeleteSuccess;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                switch (json_string.getData()[1])
                  {
                    case 'n':
                        if (String.Compare(json_string.getData(), 2, "umerate", 0, 7, false) == 0)
                          {
                            switch (json_string.getData()[9])
                              {
                                case 'N':
                                    if ((String.Compare(json_string.getData(), 10, "oneExists", 0, 9, false) == 0) && (json_string.getData().Length == 19))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_EnumerateNoneExists;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'S':
                                    if ((String.Compare(json_string.getData(), 10, "uccess", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_EnumerateSuccess;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "ror", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Error;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public TasklistAllListsResultJSON()
      {
        flagHasValue = false;
      }

    public TasklistAllListsResultJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public TasklistAllListsResultJSON(string init_value)
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

    public TasklistAllListsResultJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_EnumerateSuccess:
                    handler.string_value("EnumerateSuccess");
                    break;
                case TypeValueKnownValues.Value_EnumerateNoneExists:
                    handler.string_value("EnumerateNoneExists");
                    break;
                case TypeValueKnownValues.Value_ClearSuccess:
                    handler.string_value("ClearSuccess");
                    break;
                case TypeValueKnownValues.Value_ClearNoListExists:
                    handler.string_value("ClearNoListExists");
                    break;
                case TypeValueKnownValues.Value_ClearNoItemExists:
                    handler.string_value("ClearNoItemExists");
                    break;
                case TypeValueKnownValues.Value_ClearAskConfirm:
                    handler.string_value("ClearAskConfirm");
                    break;
                case TypeValueKnownValues.Value_ClearDidCancel:
                    handler.string_value("ClearDidCancel");
                    break;
                case TypeValueKnownValues.Value_DeleteSuccess:
                    handler.string_value("DeleteSuccess");
                    break;
                case TypeValueKnownValues.Value_DeleteNoneExists:
                    handler.string_value("DeleteNoneExists");
                    break;
                case TypeValueKnownValues.Value_DeleteAskConfirm:
                    handler.string_value("DeleteAskConfirm");
                    break;
                case TypeValueKnownValues.Value_DeleteDidCancel:
                    handler.string_value("DeleteDidCancel");
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
                case TypeValueKnownValues.Value_EnumerateSuccess:
                    handler.string_value("EnumerateSuccess");
                    break;
                case TypeValueKnownValues.Value_EnumerateNoneExists:
                    handler.string_value("EnumerateNoneExists");
                    break;
                case TypeValueKnownValues.Value_ClearSuccess:
                    handler.string_value("ClearSuccess");
                    break;
                case TypeValueKnownValues.Value_ClearNoListExists:
                    handler.string_value("ClearNoListExists");
                    break;
                case TypeValueKnownValues.Value_ClearNoItemExists:
                    handler.string_value("ClearNoItemExists");
                    break;
                case TypeValueKnownValues.Value_ClearAskConfirm:
                    handler.string_value("ClearAskConfirm");
                    break;
                case TypeValueKnownValues.Value_ClearDidCancel:
                    handler.string_value("ClearDidCancel");
                    break;
                case TypeValueKnownValues.Value_DeleteSuccess:
                    handler.string_value("DeleteSuccess");
                    break;
                case TypeValueKnownValues.Value_DeleteNoneExists:
                    handler.string_value("DeleteNoneExists");
                    break;
                case TypeValueKnownValues.Value_DeleteAskConfirm:
                    handler.string_value("DeleteAskConfirm");
                    break;
                case TypeValueKnownValues.Value_DeleteDidCancel:
                    handler.string_value("DeleteDidCancel");
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

    public static TasklistAllListsResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TasklistAllListsResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistAllListsResult", ignore_extras);
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
    public static TasklistAllListsResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TasklistAllListsResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TasklistAllListsResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistAllListsResult", ignore_extras);
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
    public static TasklistAllListsResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TasklistAllListsResultJSON from_text(string text, bool ignore_extras)
      {
        TasklistAllListsResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistAllListsResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TasklistAllListsResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TasklistAllListsResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TasklistAllListsResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TasklistAllListsResult", ignore_extras);
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
            TasklistAllListsResultJSON result = new TasklistAllListsResultJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(TasklistAllListsResultJSON new_result);
        public Generator(bool ignore_extras) : base("Type TasklistAllListsResult")
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
        protected override void handle_result(TasklistAllListsResultJSON  result)
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
        public TasklistAllListsResultJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TasklistAllListsResultJSON  result)
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
    protected virtual void handle_result(List<TasklistAllListsResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TasklistAllListsResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TasklistAllListsResultJSON>();
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
    public List<TasklistAllListsResultJSON> value;
  };
  };
