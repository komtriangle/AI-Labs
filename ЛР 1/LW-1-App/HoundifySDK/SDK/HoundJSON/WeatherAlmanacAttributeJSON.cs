/* file "WeatherAlmanacAttributeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WeatherAlmanacAttributeJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_unknown,
        Value_record_high_temperature,
        Value_record_low_temperature,
        Value_record_temperatures,
        Value_normal_high_temperature,
        Value_normal_low_temperature,
        Value_normal_temperatures,
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
            case 'n':
                if (String.Compare(chars, 1, "ormal_", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'h':
                            if ((String.Compare(chars, 8, "igh_temperature", 0, 15, false) == 0) && (chars.Length == 23))
                                return TypeValueKnownValues.Value_normal_high_temperature;
                            break;
                        case 'l':
                            if ((String.Compare(chars, 8, "ow_temperature", 0, 14, false) == 0) && (chars.Length == 22))
                                return TypeValueKnownValues.Value_normal_low_temperature;
                            break;
                        case 't':
                            if ((String.Compare(chars, 8, "emperatures", 0, 11, false) == 0) && (chars.Length == 19))
                                return TypeValueKnownValues.Value_normal_temperatures;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'r':
                if (String.Compare(chars, 1, "ecord_", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'h':
                            if ((String.Compare(chars, 8, "igh_temperature", 0, 15, false) == 0) && (chars.Length == 23))
                                return TypeValueKnownValues.Value_record_high_temperature;
                            break;
                        case 'l':
                            if ((String.Compare(chars, 8, "ow_temperature", 0, 14, false) == 0) && (chars.Length == 22))
                                return TypeValueKnownValues.Value_record_low_temperature;
                            break;
                        case 't':
                            if ((String.Compare(chars, 8, "emperatures", 0, 11, false) == 0) && (chars.Length == 19))
                                return TypeValueKnownValues.Value_record_temperatures;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'u':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValueKnownValues.Value_unknown;
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
            case TypeValueKnownValues.Value_unknown:
                return "unknown";
            case TypeValueKnownValues.Value_record_high_temperature:
                return "record_high_temperature";
            case TypeValueKnownValues.Value_record_low_temperature:
                return "record_low_temperature";
            case TypeValueKnownValues.Value_record_temperatures:
                return "record_temperatures";
            case TypeValueKnownValues.Value_normal_high_temperature:
                return "normal_high_temperature";
            case TypeValueKnownValues.Value_normal_low_temperature:
                return "normal_low_temperature";
            case TypeValueKnownValues.Value_normal_temperatures:
                return "normal_temperatures";
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
            throw new Exception("The value for field Value of WeatherAlmanacAttributeJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'n':
                if (String.Compare(json_string.getData(), 1, "ormal_", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'h':
                            if ((String.Compare(json_string.getData(), 8, "igh_temperature", 0, 15, false) == 0) && (json_string.getData().Length == 23))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_normal_high_temperature;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'l':
                            if ((String.Compare(json_string.getData(), 8, "ow_temperature", 0, 14, false) == 0) && (json_string.getData().Length == 22))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_normal_low_temperature;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 't':
                            if ((String.Compare(json_string.getData(), 8, "emperatures", 0, 11, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_normal_temperatures;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'r':
                if (String.Compare(json_string.getData(), 1, "ecord_", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'h':
                            if ((String.Compare(json_string.getData(), 8, "igh_temperature", 0, 15, false) == 0) && (json_string.getData().Length == 23))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_record_high_temperature;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'l':
                            if ((String.Compare(json_string.getData(), 8, "ow_temperature", 0, 14, false) == 0) && (json_string.getData().Length == 22))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_record_low_temperature;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 't':
                            if ((String.Compare(json_string.getData(), 8, "emperatures", 0, 11, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_record_temperatures;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'u':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_unknown;
                        goto open_enum_is_done;
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


    public WeatherAlmanacAttributeJSON()
      {
        flagHasValue = false;
      }

    public WeatherAlmanacAttributeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public WeatherAlmanacAttributeJSON(string init_value)
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

    public WeatherAlmanacAttributeJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_unknown:
                    handler.string_value("unknown");
                    break;
                case TypeValueKnownValues.Value_record_high_temperature:
                    handler.string_value("record_high_temperature");
                    break;
                case TypeValueKnownValues.Value_record_low_temperature:
                    handler.string_value("record_low_temperature");
                    break;
                case TypeValueKnownValues.Value_record_temperatures:
                    handler.string_value("record_temperatures");
                    break;
                case TypeValueKnownValues.Value_normal_high_temperature:
                    handler.string_value("normal_high_temperature");
                    break;
                case TypeValueKnownValues.Value_normal_low_temperature:
                    handler.string_value("normal_low_temperature");
                    break;
                case TypeValueKnownValues.Value_normal_temperatures:
                    handler.string_value("normal_temperatures");
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
                case TypeValueKnownValues.Value_unknown:
                    handler.string_value("unknown");
                    break;
                case TypeValueKnownValues.Value_record_high_temperature:
                    handler.string_value("record_high_temperature");
                    break;
                case TypeValueKnownValues.Value_record_low_temperature:
                    handler.string_value("record_low_temperature");
                    break;
                case TypeValueKnownValues.Value_record_temperatures:
                    handler.string_value("record_temperatures");
                    break;
                case TypeValueKnownValues.Value_normal_high_temperature:
                    handler.string_value("normal_high_temperature");
                    break;
                case TypeValueKnownValues.Value_normal_low_temperature:
                    handler.string_value("normal_low_temperature");
                    break;
                case TypeValueKnownValues.Value_normal_temperatures:
                    handler.string_value("normal_temperatures");
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

    public static WeatherAlmanacAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WeatherAlmanacAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeatherAlmanacAttribute", ignore_extras);
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
    public static WeatherAlmanacAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WeatherAlmanacAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WeatherAlmanacAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeatherAlmanacAttribute", ignore_extras);
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
    public static WeatherAlmanacAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WeatherAlmanacAttributeJSON from_text(string text, bool ignore_extras)
      {
        WeatherAlmanacAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeatherAlmanacAttribute", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WeatherAlmanacAttributeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WeatherAlmanacAttributeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WeatherAlmanacAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeatherAlmanacAttribute", ignore_extras);
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
            WeatherAlmanacAttributeJSON result = new WeatherAlmanacAttributeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(WeatherAlmanacAttributeJSON new_result);
        public Generator(bool ignore_extras) : base("Type WeatherAlmanacAttribute")
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
        protected override void handle_result(WeatherAlmanacAttributeJSON  result)
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
        public WeatherAlmanacAttributeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WeatherAlmanacAttributeJSON  result)
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
    protected virtual void handle_result(List<WeatherAlmanacAttributeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WeatherAlmanacAttributeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WeatherAlmanacAttributeJSON>();
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
    public List<WeatherAlmanacAttributeJSON> value;
  };
  };
