/* file "BusinessInformationQueriesHoursIntraQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BusinessInformationQueriesHoursIntraQueryStateJSON : JSONBase
  {
    public enum TypeFocusKnownValues
      {
        Focus_AllHours,
        Focus_OpeningTime,
        Focus_ClosingTime,
        Focus_OpenAtTime,
        Focus_ClosedAtTime,
        Focus__none
      };
    public struct TypeFocus
      {
        public bool in_known_list;
        public string string_value;
        public TypeFocusKnownValues list_value;
      };

    public static TypeFocusKnownValues  stringToFocus(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "llHours", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeFocusKnownValues.Focus_AllHours;
                break;
            case 'C':
                if (String.Compare(chars, 1, "los", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'e':
                            if ((String.Compare(chars, 5, "dAtTime", 0, 7, false) == 0) && (chars.Length == 12))
                                return TypeFocusKnownValues.Focus_ClosedAtTime;
                            break;
                        case 'i':
                            if ((String.Compare(chars, 5, "ngTime", 0, 6, false) == 0) && (chars.Length == 11))
                                return TypeFocusKnownValues.Focus_ClosingTime;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                if (String.Compare(chars, 1, "pen", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'A':
                            if ((String.Compare(chars, 5, "tTime", 0, 5, false) == 0) && (chars.Length == 10))
                                return TypeFocusKnownValues.Focus_OpenAtTime;
                            break;
                        case 'i':
                            if ((String.Compare(chars, 5, "ngTime", 0, 6, false) == 0) && (chars.Length == 11))
                                return TypeFocusKnownValues.Focus_OpeningTime;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeFocusKnownValues.Focus__none;
      }

    public static string  stringFromFocus(TypeFocusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeFocusKnownValues.Focus_AllHours:
                return "AllHours";
            case TypeFocusKnownValues.Focus_OpeningTime:
                return "OpeningTime";
            case TypeFocusKnownValues.Focus_ClosingTime:
                return "ClosingTime";
            case TypeFocusKnownValues.Focus_OpenAtTime:
                return "OpenAtTime";
            case TypeFocusKnownValues.Focus_ClosedAtTime:
                return "ClosedAtTime";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFocus;
    private TypeFocus storeFocus;
    private bool flagHasReferencedDateTime;
    private DateTimeSpecJSON  storeReferencedDateTime;
    private bool flagHasQueriedDaysOfTheWeek;
    private List< DayOfWeekJSON  > storeQueriedDaysOfTheWeek;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFocus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Focus of BusinessInformationQueriesHoursIntraQueryStateJSON is not a string.");
        TypeFocus the_open_enum = new TypeFocus();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "llHours", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFocusKnownValues.Focus_AllHours;
                        goto open_enum_is_done;
                      }
                break;
            case 'C':
                if (String.Compare(json_string.getData(), 1, "los", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'e':
                            if ((String.Compare(json_string.getData(), 5, "dAtTime", 0, 7, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeFocusKnownValues.Focus_ClosedAtTime;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'i':
                            if ((String.Compare(json_string.getData(), 5, "ngTime", 0, 6, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeFocusKnownValues.Focus_ClosingTime;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'O':
                if (String.Compare(json_string.getData(), 1, "pen", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 5, "tTime", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeFocusKnownValues.Focus_OpenAtTime;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'i':
                            if ((String.Compare(json_string.getData(), 5, "ngTime", 0, 6, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeFocusKnownValues.Focus_OpeningTime;
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
        setFocus(the_open_enum);
      }


    private void  fromJSONReferencedDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setReferencedDateTime(convert_classy);
      }


    private void  fromJSONQueriedDaysOfTheWeek(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueriedDaysOfTheWeek of BusinessInformationQueriesHoursIntraQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DayOfWeekJSON  > vector_QueriedDaysOfTheWeek1 = new List< DayOfWeekJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DayOfWeekJSON convert_classy = DayOfWeekJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_QueriedDaysOfTheWeek1.Add(convert_classy);
          }
        initQueriedDaysOfTheWeek();
        for (int num1 = 0; num1 < vector_QueriedDaysOfTheWeek1.Count; ++num1)
            appendQueriedDaysOfTheWeek(vector_QueriedDaysOfTheWeek1[num1]);
        for (int num1 = 0; num1 < vector_QueriedDaysOfTheWeek1.Count; ++num1)
          {
          }
      }


    public BusinessInformationQueriesHoursIntraQueryStateJSON()
      {
        flagHasFocus = false;
        flagHasReferencedDateTime = false;
        flagHasQueriedDaysOfTheWeek = false;
        storeQueriedDaysOfTheWeek = new List< DayOfWeekJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFocus()
      {
        return flagHasFocus;
      }

    public TypeFocus  getFocus()
      {
        Debug.Assert(flagHasFocus);
        return storeFocus;
      }

    public string  getFocusAsString()
      {
        TypeFocus result = getFocus();
        if (result.in_known_list)
            return stringFromFocus(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasReferencedDateTime()
      {
        return flagHasReferencedDateTime;
      }

    public DateTimeSpecJSON   getReferencedDateTime()
      {
        Debug.Assert(flagHasReferencedDateTime);
        return storeReferencedDateTime;
      }

    public bool  hasQueriedDaysOfTheWeek()
      {
        return flagHasQueriedDaysOfTheWeek;
      }

    public int  countOfQueriedDaysOfTheWeek()
      {
        Debug.Assert(flagHasQueriedDaysOfTheWeek);
        return storeQueriedDaysOfTheWeek.Count;
      }

    public DayOfWeekJSON   elementOfQueriedDaysOfTheWeek(int element_num)
      {
        Debug.Assert(flagHasQueriedDaysOfTheWeek);
        return storeQueriedDaysOfTheWeek[element_num];
      }

    public List< DayOfWeekJSON  >  getQueriedDaysOfTheWeek()
      {
        Debug.Assert(flagHasQueriedDaysOfTheWeek);
        return storeQueriedDaysOfTheWeek;
      }


    public virtual int extraBusinessInformationQueriesHoursIntraQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBusinessInformationQueriesHoursIntraQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBusinessInformationQueriesHoursIntraQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBusinessInformationQueriesHoursIntraQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFocus(TypeFocus new_value)
      {
        flagHasFocus = true;
        storeFocus = new_value;
      }
    public void setFocus(string chars)
      {
        TypeFocusKnownValues known = stringToFocus(chars);
        TypeFocus new_value = new TypeFocus();
        if (known == TypeFocusKnownValues.Focus__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setFocus(new_value);
      }
    public void setFocus(TypeFocusKnownValues new_value)
      {
        TypeFocus new_full_value = new TypeFocus();
        Debug.Assert(new_value != TypeFocusKnownValues.Focus__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setFocus(new_full_value);
      }
    public void unsetFocus()
      {
        flagHasFocus = false;
      }
    public void setReferencedDateTime(DateTimeSpecJSON  new_value)
      {
        if (flagHasReferencedDateTime)
          {
          }
        flagHasReferencedDateTime = true;
        storeReferencedDateTime = new_value;
      }
    public void unsetReferencedDateTime()
      {
        if (flagHasReferencedDateTime)
          {
          }
        flagHasReferencedDateTime = false;
      }
    public void initQueriedDaysOfTheWeek()
      {
        if (flagHasQueriedDaysOfTheWeek)
          {
            for (int num1 = 0; num1 < storeQueriedDaysOfTheWeek.Count; ++num1)
              {
              }
          }
        flagHasQueriedDaysOfTheWeek = true;
        storeQueriedDaysOfTheWeek.Clear();
      }
    public void appendQueriedDaysOfTheWeek(DayOfWeekJSON  to_append)
      {
        if (!flagHasQueriedDaysOfTheWeek)
          {
            flagHasQueriedDaysOfTheWeek = true;
            storeQueriedDaysOfTheWeek.Clear();
          }
        Debug.Assert(flagHasQueriedDaysOfTheWeek);
        storeQueriedDaysOfTheWeek.Add(to_append);
      }
    public void appendQueriedDaysOfTheWeek(DayOfWeekJSON.TypeValue new_value)
      {
        appendQueriedDaysOfTheWeek(new DayOfWeekJSON(new_value));
      }
    public void appendQueriedDaysOfTheWeek(string chars)
      {
        appendQueriedDaysOfTheWeek(new DayOfWeekJSON(chars));
      }
    public void unsetQueriedDaysOfTheWeek()
      {
        if (flagHasQueriedDaysOfTheWeek)
          {
            for (int num2 = 0; num2 < storeQueriedDaysOfTheWeek.Count; ++num2)
              {
              }
          }
        flagHasQueriedDaysOfTheWeek = false;
        storeQueriedDaysOfTheWeek.Clear();
      }

    public virtual void extraBusinessInformationQueriesHoursIntraQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBusinessInformationQueriesHoursIntraQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBusinessInformationQueriesHoursIntraQueryStateLookup(key);
        if (old_field == null)
          {
            extraBusinessInformationQueriesHoursIntraQueryStateAppendPair(key, new_component);
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
        if (flagHasFocus)
          {
            handler.start_pair("Focus");
            if (storeFocus.in_known_list)
              {
                switch (storeFocus.list_value)
                  {
                    case TypeFocusKnownValues.Focus_AllHours:
                        handler.string_value("AllHours");
                        break;
                    case TypeFocusKnownValues.Focus_OpeningTime:
                        handler.string_value("OpeningTime");
                        break;
                    case TypeFocusKnownValues.Focus_ClosingTime:
                        handler.string_value("ClosingTime");
                        break;
                    case TypeFocusKnownValues.Focus_OpenAtTime:
                        handler.string_value("OpenAtTime");
                        break;
                    case TypeFocusKnownValues.Focus_ClosedAtTime:
                        handler.string_value("ClosedAtTime");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeFocus.string_value);
              }
          }
        if (flagHasReferencedDateTime)
          {
            handler.start_pair("ReferencedDateTime");
            if (partial_allowed)
                storeReferencedDateTime.write_partial_as_json(handler);
            else
                storeReferencedDateTime.write_as_json(handler);
          }
        if (flagHasQueriedDaysOfTheWeek)
          {
            handler.start_pair("QueriedDaysOfTheWeek");
            handler.start_array();
            for (int num1 = 0; num1 < storeQueriedDaysOfTheWeek.Count; ++num1)
              {
                if (partial_allowed)
                    storeQueriedDaysOfTheWeek[num1].write_partial_as_json(handler);
                else
                    storeQueriedDaysOfTheWeek[num1].write_as_json(handler);
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

    public static BusinessInformationQueriesHoursIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BusinessInformationQueriesHoursIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationQueriesHoursIntraQueryState", ignore_extras);
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
    public static BusinessInformationQueriesHoursIntraQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BusinessInformationQueriesHoursIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BusinessInformationQueriesHoursIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationQueriesHoursIntraQueryState", ignore_extras);
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
    public static BusinessInformationQueriesHoursIntraQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BusinessInformationQueriesHoursIntraQueryStateJSON from_text(string text, bool ignore_extras)
      {
        BusinessInformationQueriesHoursIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationQueriesHoursIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BusinessInformationQueriesHoursIntraQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BusinessInformationQueriesHoursIntraQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BusinessInformationQueriesHoursIntraQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationQueriesHoursIntraQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorFocus : JSONStringGenerator
          {
            protected FieldGeneratorFocus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFocus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeFocusKnownValues known = stringToFocus(result);
                TypeFocus new_value = new TypeFocus();
                if (known == TypeFocusKnownValues.Focus__none)
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
            protected abstract void handle_result(TypeFocus result);
          };
    private class FieldHoldingGeneratorFocus : FieldGeneratorFocus
  {
    protected override void handle_result(TypeFocus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFocus(String what)
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
    public TypeFocus value;
  };
    private class FieldHoldingArrayGeneratorFocus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFocus
      {
        private FieldHoldingArrayGeneratorFocus top;

        protected override void handle_result(TypeFocus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFocus init_top)
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
    protected virtual void handle_result(List<TypeFocus> result)
      {
      }

    public FieldHoldingArrayGeneratorFocus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFocus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFocus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFocus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFocus> value;
  };
        private FieldHoldingGeneratorFocus fieldGeneratorFocus;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorReferencedDateTime;
        private DayOfWeekJSON.HoldingArrayGenerator fieldGeneratorQueriedDaysOfTheWeek;
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
            BusinessInformationQueriesHoursIntraQueryStateJSON result = new BusinessInformationQueriesHoursIntraQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBusinessInformationQueriesHoursIntraQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BusinessInformationQueriesHoursIntraQueryStateJSON result)
          {
            if (fieldGeneratorFocus.have_value)
              {
                result.setFocus(fieldGeneratorFocus.value);
                fieldGeneratorFocus.have_value = false;
              }
            if (fieldGeneratorReferencedDateTime.have_value)
              {
                result.setReferencedDateTime(fieldGeneratorReferencedDateTime.value);
                fieldGeneratorReferencedDateTime.have_value = false;
              }
            if (fieldGeneratorQueriedDaysOfTheWeek.have_value)
              {
                result.initQueriedDaysOfTheWeek();
                int count = fieldGeneratorQueriedDaysOfTheWeek.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQueriedDaysOfTheWeek(fieldGeneratorQueriedDaysOfTheWeek.value[num]);
                  }
                fieldGeneratorQueriedDaysOfTheWeek.value.Clear();
                fieldGeneratorQueriedDaysOfTheWeek.have_value = false;
              }
          }
        protected abstract void handle_result(BusinessInformationQueriesHoursIntraQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "ocus", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorFocus;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueriedDaysOfTheWeek", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorQueriedDaysOfTheWeek;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "eferencedDateTime", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorReferencedDateTime;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFocus = new FieldHoldingGeneratorFocus("field \"Focus\" of the BusinessInformationQueriesHoursIntraQueryState class");
            fieldGeneratorReferencedDateTime = new DateTimeSpecJSON.HoldingGenerator("field \"ReferencedDateTime\" of the BusinessInformationQueriesHoursIntraQueryState class", ignore_extras);
            fieldGeneratorQueriedDaysOfTheWeek = new DayOfWeekJSON.HoldingArrayGenerator("field \"QueriedDaysOfTheWeek\" of the BusinessInformationQueriesHoursIntraQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BusinessInformationQueriesHoursIntraQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFocus = new FieldHoldingGeneratorFocus("field \"Focus\" of the BusinessInformationQueriesHoursIntraQueryState class");
            fieldGeneratorReferencedDateTime = new DateTimeSpecJSON.HoldingGenerator("field \"ReferencedDateTime\" of the BusinessInformationQueriesHoursIntraQueryState class", false);
            fieldGeneratorQueriedDaysOfTheWeek = new DayOfWeekJSON.HoldingArrayGenerator("field \"QueriedDaysOfTheWeek\" of the BusinessInformationQueriesHoursIntraQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BusinessInformationQueriesHoursIntraQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFocus.reset();
            fieldGeneratorReferencedDateTime.reset();
            fieldGeneratorQueriedDaysOfTheWeek.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorReferencedDateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorQueriedDaysOfTheWeek.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorReferencedDateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorQueriedDaysOfTheWeek.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(BusinessInformationQueriesHoursIntraQueryStateJSON  result)
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
        public BusinessInformationQueriesHoursIntraQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BusinessInformationQueriesHoursIntraQueryStateJSON  result)
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
    protected virtual void handle_result(List<BusinessInformationQueriesHoursIntraQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BusinessInformationQueriesHoursIntraQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BusinessInformationQueriesHoursIntraQueryStateJSON>();
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
    public List<BusinessInformationQueriesHoursIntraQueryStateJSON> value;
  };
  };
