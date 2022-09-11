/* file "DailyHoroscopesInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class DailyHoroscopesInformationNuggetJSON : HoroscopesInformationNuggetJSON
  {
    public enum TypeRequestedDayKnownValues
      {
        RequestedDay_Yesterday,
        RequestedDay_Today,
        RequestedDay_Tomorrow,
        RequestedDay__none
      };
    public struct TypeRequestedDay
      {
        public bool in_known_list;
        public string string_value;
        public TypeRequestedDayKnownValues list_value;
      };

    public static TypeRequestedDayKnownValues  stringToRequestedDay(string chars)
      {
        switch (chars[0])
          {
            case 'T':
                if (String.Compare(chars, 1, "o", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'd':
                            if ((String.Compare(chars, 3, "ay", 0, 2, false) == 0) && (chars.Length == 5))
                                return TypeRequestedDayKnownValues.RequestedDay_Today;
                            break;
                        case 'm':
                            if ((String.Compare(chars, 3, "orrow", 0, 5, false) == 0) && (chars.Length == 8))
                                return TypeRequestedDayKnownValues.RequestedDay_Tomorrow;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "esterday", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeRequestedDayKnownValues.RequestedDay_Yesterday;
                break;
            default:
                break;
          }
        return TypeRequestedDayKnownValues.RequestedDay__none;
      }

    public static string  stringFromRequestedDay(TypeRequestedDayKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeRequestedDayKnownValues.RequestedDay_Yesterday:
                return "Yesterday";
            case TypeRequestedDayKnownValues.RequestedDay_Today:
                return "Today";
            case TypeRequestedDayKnownValues.RequestedDay_Tomorrow:
                return "Tomorrow";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasRequestedDay;
    private TypeRequestedDay storeRequestedDay;
    private bool flagHasHoroscopeText;
    private string storeHoroscopeText;


    private JSONValue  extraRequestedDayToJSON()
      {
        JSONStringValue generated_string_RequestedDay;
        if (!(storeRequestedDay.in_known_list))
          {
        generated_string_RequestedDay = new JSONStringValue(storeRequestedDay.string_value);
          }
        else
          {
        switch (storeRequestedDay.list_value)
          {
            case TypeRequestedDayKnownValues.RequestedDay_Yesterday:
                generated_string_RequestedDay = new JSONStringValue("Yesterday");
                break;
            case TypeRequestedDayKnownValues.RequestedDay_Today:
                generated_string_RequestedDay = new JSONStringValue("Today");
                break;
            case TypeRequestedDayKnownValues.RequestedDay_Tomorrow:
                generated_string_RequestedDay = new JSONStringValue("Tomorrow");
                break;
            default:
                Debug.Assert(false);
                generated_string_RequestedDay = null;
                break;
          }
          }
        return generated_string_RequestedDay;
      }

    private JSONValue  extraHoroscopeTextToJSON()
      {
        JSONStringValue generated_string_HoroscopeText = new JSONStringValue(storeHoroscopeText);
        return generated_string_HoroscopeText;
      }


    private void  fromJSONRequestedDay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RequestedDay of DailyHoroscopesInformationNuggetJSON is not a string.");
        TypeRequestedDay the_open_enum = new TypeRequestedDay();
        switch (json_string.getData()[0])
          {
            case 'T':
                if (String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'd':
                            if ((String.Compare(json_string.getData(), 3, "ay", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeRequestedDayKnownValues.RequestedDay_Today;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'm':
                            if ((String.Compare(json_string.getData(), 3, "orrow", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeRequestedDayKnownValues.RequestedDay_Tomorrow;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "esterday", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeRequestedDayKnownValues.RequestedDay_Yesterday;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setRequestedDay(the_open_enum);
      }


    private void  fromJSONHoroscopeText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HoroscopeText of DailyHoroscopesInformationNuggetJSON is not a string.");
        setHoroscopeText(json_string.getData());
      }


    public DailyHoroscopesInformationNuggetJSON()
      {
        flagHasRequestedDay = false;
        flagHasHoroscopeText = false;
      }

    public override string  getHoroscopesInformationNuggetKind()
      {
        return "DailyHoroscopesInformationNugget";
      }

    public abstract string getDailyHoroscopesInformationNuggetKind();
    public bool  hasRequestedDay()
      {
        return flagHasRequestedDay;
      }

    public TypeRequestedDay  getRequestedDay()
      {
        Debug.Assert(flagHasRequestedDay);
        return storeRequestedDay;
      }

    public string  getRequestedDayAsString()
      {
        TypeRequestedDay result = getRequestedDay();
        if (result.in_known_list)
            return stringFromRequestedDay(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasHoroscopeText()
      {
        return flagHasHoroscopeText;
      }

    public string  getHoroscopeText()
      {
        Debug.Assert(flagHasHoroscopeText);
        return storeHoroscopeText;
      }


    public abstract int extraDailyHoroscopesInformationNuggetComponentCount();
    public abstract string extraDailyHoroscopesInformationNuggetComponentKey(int component_num);
    public abstract JSONValue extraDailyHoroscopesInformationNuggetComponentValue(int component_num);
    public abstract JSONValue extraDailyHoroscopesInformationNuggetLookup(string field_name);
    public override int extraHoroscopesInformationNuggetComponentCount()
      {
        int result = 1;
        if (flagHasRequestedDay)
            ++result;
        if (flagHasHoroscopeText)
            ++result;
        result += extraDailyHoroscopesInformationNuggetComponentCount();
        return result;
      }
    public override string extraHoroscopesInformationNuggetComponentKey(int component_num)
      {
        if (component_num == 0)
            return "DailyHoroscopesInformationNuggetKind";
        int remainder = (component_num - 1);
        if (flagHasRequestedDay)
          {
            if (remainder == 0)
                return "RequestedDay";
            --remainder;
          }
        if (flagHasHoroscopeText)
          {
            if (remainder == 0)
                return "HoroscopeText";
            --remainder;
          }
        return extraDailyHoroscopesInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraHoroscopesInformationNuggetComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getDailyHoroscopesInformationNuggetKind());
        int remainder = (component_num - 1);
        if (flagHasRequestedDay)
          {
            if (remainder == 0)
                return extraRequestedDayToJSON();
            --remainder;
          }
        if (flagHasHoroscopeText)
          {
            if (remainder == 0)
                return extraHoroscopeTextToJSON();
            --remainder;
          }
        return extraDailyHoroscopesInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraHoroscopesInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "ailyHoroscopesInformationNuggetKind", 0, 35, false) == 0) && (field_name.Length == 36))
                    return new JSONStringValue(getDailyHoroscopesInformationNuggetKind());
                break;
            case 'H':
                if ((String.Compare(field_name, 1, "oroscopeText", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasHoroscopeText ? extraHoroscopeTextToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "equestedDay", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasRequestedDay ? extraRequestedDayToJSON() : null);
                break;
            default:
                break;
          }
        return extraDailyHoroscopesInformationNuggetLookup(field_name);
      }

    public void setRequestedDay(TypeRequestedDay new_value)
      {
        flagHasRequestedDay = true;
        storeRequestedDay = new_value;
      }
    public void setRequestedDay(string chars)
      {
        TypeRequestedDayKnownValues known = stringToRequestedDay(chars);
        TypeRequestedDay new_value = new TypeRequestedDay();
        if (known == TypeRequestedDayKnownValues.RequestedDay__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRequestedDay(new_value);
      }
    public void setRequestedDay(TypeRequestedDayKnownValues new_value)
      {
        TypeRequestedDay new_full_value = new TypeRequestedDay();
        Debug.Assert(new_value != TypeRequestedDayKnownValues.RequestedDay__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setRequestedDay(new_full_value);
      }
    public void unsetRequestedDay()
      {
        flagHasRequestedDay = false;
      }
    public void setHoroscopeText(string new_value)
      {
        flagHasHoroscopeText = true;
        storeHoroscopeText = new_value;
      }
    public void unsetHoroscopeText()
      {
        flagHasHoroscopeText = false;
      }

    public abstract void extraDailyHoroscopesInformationNuggetAppendPair(string key, JSONValue new_component);
    public abstract void extraDailyHoroscopesInformationNuggetSetField(string key, JSONValue new_component);
    public override void extraHoroscopesInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ailyHoroscopesInformationNuggetKind", 0, 35, false) == 0) && (key.Length == 36))
                    return;
                break;
            case 'H':
                if ((String.Compare(key, 1, "oroscopeText", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONHoroscopeText(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedDay", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONRequestedDay(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDailyHoroscopesInformationNuggetAppendPair(key, new_component);
      }
    public override void extraHoroscopesInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ailyHoroscopesInformationNuggetKind", 0, 35, false) == 0) && (key.Length == 36))
                    return;
                break;
            case 'H':
                if ((String.Compare(key, 1, "oroscopeText", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONHoroscopeText(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedDay", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONRequestedDay(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDailyHoroscopesInformationNuggetSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("DailyHoroscopesInformationNuggetKind", getDailyHoroscopesInformationNuggetKind());
        if (flagHasRequestedDay)
          {
            handler.start_pair("RequestedDay");
            if (storeRequestedDay.in_known_list)
              {
                switch (storeRequestedDay.list_value)
                  {
                    case TypeRequestedDayKnownValues.RequestedDay_Yesterday:
                        handler.string_value("Yesterday");
                        break;
                    case TypeRequestedDayKnownValues.RequestedDay_Today:
                        handler.string_value("Today");
                        break;
                    case TypeRequestedDayKnownValues.RequestedDay_Tomorrow:
                        handler.string_value("Tomorrow");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeRequestedDay.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasHoroscopeText);
        if (flagHasHoroscopeText)
          {
            handler.start_pair("HoroscopeText");
            handler.string_value(storeHoroscopeText);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasHoroscopeText()))
          {
            return "When parsing the object for %what%, the \"HoroscopeText\" field was missing.";
          }
        return null;
      }

    public static new DailyHoroscopesInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DailyHoroscopesInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DailyHoroscopesInformationNugget", ignore_extras);
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
    public static new DailyHoroscopesInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DailyHoroscopesInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DailyHoroscopesInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DailyHoroscopesInformationNugget", ignore_extras);
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
    public static new DailyHoroscopesInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DailyHoroscopesInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        DailyHoroscopesInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DailyHoroscopesInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DailyHoroscopesInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DailyHoroscopesInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DailyHoroscopesInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DailyHoroscopesInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : HoroscopesInformationNuggetJSON.Generator
      {
    private abstract class FieldGeneratorRequestedDay : JSONStringGenerator
          {
            protected FieldGeneratorRequestedDay(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorRequestedDay()
              {
              }
            protected override void handle_result(string result)
              {
                TypeRequestedDayKnownValues known = stringToRequestedDay(result);
                TypeRequestedDay new_value = new TypeRequestedDay();
                if (known == TypeRequestedDayKnownValues.RequestedDay__none)
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
            protected abstract void handle_result(TypeRequestedDay result);
          };
    private class FieldHoldingGeneratorRequestedDay : FieldGeneratorRequestedDay
  {
    protected override void handle_result(TypeRequestedDay result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorRequestedDay(String what)
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
    public TypeRequestedDay value;
  };
    private class FieldHoldingArrayGeneratorRequestedDay : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorRequestedDay
      {
        private FieldHoldingArrayGeneratorRequestedDay top;

        protected override void handle_result(TypeRequestedDay result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorRequestedDay init_top)
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
    protected virtual void handle_result(List<TypeRequestedDay> result)
      {
      }

    public FieldHoldingArrayGeneratorRequestedDay(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRequestedDay>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorRequestedDay()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRequestedDay>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeRequestedDay> value;
  };
        private FieldHoldingGeneratorRequestedDay fieldGeneratorRequestedDay;
        private JSONHoldingStringGenerator fieldGeneratorHoroscopeText;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `DailyHoroscopesInformationNuggetKind' field is missing.");
            if (!(getHoroscopesInformationNuggetJSONKey().Equals("DailyHoroscopesInformationNugget")))
                throw new Exception("The key field has a value other than `DailyHoroscopesInformationNugget'.");
            DailyHoroscopesInformationNuggetJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDailyHoroscopesInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getDailyHoroscopesInformationNuggetJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `DailyHoroscopesInformationNuggetKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(HoroscopesInformationNuggetJSON new_result)
          {
            handle_result((DailyHoroscopesInformationNuggetJSON )new_result);
          }
        protected void finish(DailyHoroscopesInformationNuggetJSON result)
          {
            if (fieldGeneratorRequestedDay.have_value)
              {
                result.setRequestedDay(fieldGeneratorRequestedDay.value);
                fieldGeneratorRequestedDay.have_value = false;
              }
            if (fieldGeneratorHoroscopeText.have_value)
              {
                result.setHoroscopeText(fieldGeneratorHoroscopeText.value);
                fieldGeneratorHoroscopeText.have_value = false;
              }
            else if ((!(result.hasHoroscopeText())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HoroscopeText\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(DailyHoroscopesInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ailyHoroscopesInformationNuggetKind", 0, 35, false) == 0) && (field_name.Length == 36))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "oroscopeText", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorHoroscopeText;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedDay", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorRequestedDay;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRequestedDay = new FieldHoldingGeneratorRequestedDay("field \"RequestedDay\" of the DailyHoroscopesInformationNugget class");
            fieldGeneratorHoroscopeText = new JSONHoldingStringGenerator("field \"HoroscopeText\" of the DailyHoroscopesInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"DailyHoroscopesInformationNuggetKind\" of the DailyHoroscopesInformationNugget class");
            set_what("the DailyHoroscopesInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRequestedDay = new FieldHoldingGeneratorRequestedDay("field \"RequestedDay\" of the DailyHoroscopesInformationNugget class");
            fieldGeneratorHoroscopeText = new JSONHoldingStringGenerator("field \"HoroscopeText\" of the DailyHoroscopesInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"DailyHoroscopesInformationNuggetKind\" of the DailyHoroscopesInformationNugget class");
            set_what("the DailyHoroscopesInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorRequestedDay.reset();
            fieldGeneratorHoroscopeText.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DailyHoroscopesInformationNuggetJSON  result)
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
        public DailyHoroscopesInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DailyHoroscopesInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<DailyHoroscopesInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DailyHoroscopesInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DailyHoroscopesInformationNuggetJSON>();
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
    public List<DailyHoroscopesInformationNuggetJSON> value;
  };
    class GenericDailyHoroscopesInformationNuggetJSON : DailyHoroscopesInformationNuggetJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericDailyHoroscopesInformationNuggetJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getDailyHoroscopesInformationNuggetKind()  { return key; }
        public override int extraDailyHoroscopesInformationNuggetComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraDailyHoroscopesInformationNuggetComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraDailyHoroscopesInformationNuggetComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraDailyHoroscopesInformationNuggetLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraDailyHoroscopesInformationNuggetAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraDailyHoroscopesInformationNuggetSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraDailyHoroscopesInformationNuggetLookup(key);
            if (old_field == null)
              {
                extraDailyHoroscopesInformationNuggetAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static new DailyHoroscopesInformationNuggetJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'C':
            if ((String.Compare(key, 1, "hineseDailyHoroscopesInformationNugget", 0, 38, false) == 0) && (key.Length == 39))
                return new ChineseDailyHoroscopesInformationNuggetJSON();
            break;
        case 'W':
            if ((String.Compare(key, 1, "esternDailyHoroscopesInformationNugget", 0, 38, false) == 0) && (key.Length == 39))
                return new WesternDailyHoroscopesInformationNuggetJSON();
            break;
        default:
            break;
      }

        return new GenericDailyHoroscopesInformationNuggetJSON(key);
      }
  };
