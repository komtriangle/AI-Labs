/* file "WeatherAttributeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WeatherAttributeJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_unknown,
        Value_generic,
        Value_dewpoint,
        Value_visibility,
        Value_pressure,
        Value_wind,
        Value_temperature,
        Value_rain,
        Value_snow,
        Value_humidity,
        Value_skycover,
        Value_uv,
        Value_high_temperature,
        Value_low_temperature,
        Value_pollen,
        Value_air_quality,
        Value_windchill,
        Value_feels_like_temperature,
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
            case 'a':
                if ((String.Compare(chars, 1, "ir_quality", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeValueKnownValues.Value_air_quality;
                break;
            case 'd':
                if ((String.Compare(chars, 1, "ewpoint", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeValueKnownValues.Value_dewpoint;
                break;
            case 'f':
                if ((String.Compare(chars, 1, "eels_like_temperature", 0, 21, false) == 0) && (chars.Length == 22))
                    return TypeValueKnownValues.Value_feels_like_temperature;
                break;
            case 'g':
                if ((String.Compare(chars, 1, "eneric", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValueKnownValues.Value_generic;
                break;
            case 'h':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "gh_temperature", 0, 14, false) == 0) && (chars.Length == 16))
                            return TypeValueKnownValues.Value_high_temperature;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "midity", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_humidity;
                        break;
                    default:
                        break;
                  }
                break;
            case 'l':
                if ((String.Compare(chars, 1, "ow_temperature", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeValueKnownValues.Value_low_temperature;
                break;
            case 'p':
                switch (chars[1])
                  {
                    case 'o':
                        if ((String.Compare(chars, 2, "llen", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_pollen;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "essure", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_pressure;
                        break;
                    default:
                        break;
                  }
                break;
            case 'r':
                if ((String.Compare(chars, 1, "ain", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeValueKnownValues.Value_rain;
                break;
            case 's':
                switch (chars[1])
                  {
                    case 'k':
                        if ((String.Compare(chars, 2, "ycover", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeValueKnownValues.Value_skycover;
                        break;
                    case 'n':
                        if ((String.Compare(chars, 2, "ow", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_snow;
                        break;
                    default:
                        break;
                  }
                break;
            case 't':
                if ((String.Compare(chars, 1, "emperature", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeValueKnownValues.Value_temperature;
                break;
            case 'u':
                switch (chars[1])
                  {
                    case 'n':
                        if ((String.Compare(chars, 2, "known", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_unknown;
                        break;
                    case 'v':
                        if (chars.Length == 2)
                            return TypeValueKnownValues.Value_uv;
                        break;
                    default:
                        break;
                  }
                break;
            case 'v':
                if ((String.Compare(chars, 1, "isibility", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeValueKnownValues.Value_visibility;
                break;
            case 'w':
                if (String.Compare(chars, 1, "ind", 0, 3, false) == 0)
                  {
                    if (chars.Length == 4)
                      {
                        return TypeValueKnownValues.Value_wind;
                      }
                    switch (chars[4])
                      {
                        case 'c':
                            if ((String.Compare(chars, 5, "hill", 0, 4, false) == 0) && (chars.Length == 9))
                                return TypeValueKnownValues.Value_windchill;
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
            case TypeValueKnownValues.Value_unknown:
                return "unknown";
            case TypeValueKnownValues.Value_generic:
                return "generic";
            case TypeValueKnownValues.Value_dewpoint:
                return "dewpoint";
            case TypeValueKnownValues.Value_visibility:
                return "visibility";
            case TypeValueKnownValues.Value_pressure:
                return "pressure";
            case TypeValueKnownValues.Value_wind:
                return "wind";
            case TypeValueKnownValues.Value_temperature:
                return "temperature";
            case TypeValueKnownValues.Value_rain:
                return "rain";
            case TypeValueKnownValues.Value_snow:
                return "snow";
            case TypeValueKnownValues.Value_humidity:
                return "humidity";
            case TypeValueKnownValues.Value_skycover:
                return "skycover";
            case TypeValueKnownValues.Value_uv:
                return "uv";
            case TypeValueKnownValues.Value_high_temperature:
                return "high_temperature";
            case TypeValueKnownValues.Value_low_temperature:
                return "low_temperature";
            case TypeValueKnownValues.Value_pollen:
                return "pollen";
            case TypeValueKnownValues.Value_air_quality:
                return "air_quality";
            case TypeValueKnownValues.Value_windchill:
                return "windchill";
            case TypeValueKnownValues.Value_feels_like_temperature:
                return "feels_like_temperature";
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
            throw new Exception("The value for field Value of WeatherAttributeJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'a':
                if ((String.Compare(json_string.getData(), 1, "ir_quality", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_air_quality;
                        goto open_enum_is_done;
                      }
                break;
            case 'd':
                if ((String.Compare(json_string.getData(), 1, "ewpoint", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_dewpoint;
                        goto open_enum_is_done;
                      }
                break;
            case 'f':
                if ((String.Compare(json_string.getData(), 1, "eels_like_temperature", 0, 21, false) == 0) && (json_string.getData().Length == 22))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_feels_like_temperature;
                        goto open_enum_is_done;
                      }
                break;
            case 'g':
                if ((String.Compare(json_string.getData(), 1, "eneric", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_generic;
                        goto open_enum_is_done;
                      }
                break;
            case 'h':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "gh_temperature", 0, 14, false) == 0) && (json_string.getData().Length == 16))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_high_temperature;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "midity", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_humidity;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'l':
                if ((String.Compare(json_string.getData(), 1, "ow_temperature", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_low_temperature;
                        goto open_enum_is_done;
                      }
                break;
            case 'p':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "llen", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_pollen;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "essure", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_pressure;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'r':
                if ((String.Compare(json_string.getData(), 1, "ain", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_rain;
                        goto open_enum_is_done;
                      }
                break;
            case 's':
                switch (json_string.getData()[1])
                  {
                    case 'k':
                        if ((String.Compare(json_string.getData(), 2, "ycover", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_skycover;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "ow", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_snow;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 't':
                if ((String.Compare(json_string.getData(), 1, "emperature", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_temperature;
                        goto open_enum_is_done;
                      }
                break;
            case 'u':
                switch (json_string.getData()[1])
                  {
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "known", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_unknown;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'v':
                        if (json_string.getData().Length == 2)
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_uv;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'v':
                if ((String.Compare(json_string.getData(), 1, "isibility", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_visibility;
                        goto open_enum_is_done;
                      }
                break;
            case 'w':
                if (String.Compare(json_string.getData(), 1, "ind", 0, 3, false) == 0)
                  {
                    if (json_string.getData().Length == 4)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeValueKnownValues.Value_wind;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[4])
                      {
                        case 'c':
                            if ((String.Compare(json_string.getData(), 5, "hill", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_windchill;
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


    public WeatherAttributeJSON()
      {
        flagHasValue = false;
      }

    public WeatherAttributeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public WeatherAttributeJSON(string init_value)
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

    public WeatherAttributeJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_generic:
                    handler.string_value("generic");
                    break;
                case TypeValueKnownValues.Value_dewpoint:
                    handler.string_value("dewpoint");
                    break;
                case TypeValueKnownValues.Value_visibility:
                    handler.string_value("visibility");
                    break;
                case TypeValueKnownValues.Value_pressure:
                    handler.string_value("pressure");
                    break;
                case TypeValueKnownValues.Value_wind:
                    handler.string_value("wind");
                    break;
                case TypeValueKnownValues.Value_temperature:
                    handler.string_value("temperature");
                    break;
                case TypeValueKnownValues.Value_rain:
                    handler.string_value("rain");
                    break;
                case TypeValueKnownValues.Value_snow:
                    handler.string_value("snow");
                    break;
                case TypeValueKnownValues.Value_humidity:
                    handler.string_value("humidity");
                    break;
                case TypeValueKnownValues.Value_skycover:
                    handler.string_value("skycover");
                    break;
                case TypeValueKnownValues.Value_uv:
                    handler.string_value("uv");
                    break;
                case TypeValueKnownValues.Value_high_temperature:
                    handler.string_value("high_temperature");
                    break;
                case TypeValueKnownValues.Value_low_temperature:
                    handler.string_value("low_temperature");
                    break;
                case TypeValueKnownValues.Value_pollen:
                    handler.string_value("pollen");
                    break;
                case TypeValueKnownValues.Value_air_quality:
                    handler.string_value("air_quality");
                    break;
                case TypeValueKnownValues.Value_windchill:
                    handler.string_value("windchill");
                    break;
                case TypeValueKnownValues.Value_feels_like_temperature:
                    handler.string_value("feels_like_temperature");
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
                case TypeValueKnownValues.Value_generic:
                    handler.string_value("generic");
                    break;
                case TypeValueKnownValues.Value_dewpoint:
                    handler.string_value("dewpoint");
                    break;
                case TypeValueKnownValues.Value_visibility:
                    handler.string_value("visibility");
                    break;
                case TypeValueKnownValues.Value_pressure:
                    handler.string_value("pressure");
                    break;
                case TypeValueKnownValues.Value_wind:
                    handler.string_value("wind");
                    break;
                case TypeValueKnownValues.Value_temperature:
                    handler.string_value("temperature");
                    break;
                case TypeValueKnownValues.Value_rain:
                    handler.string_value("rain");
                    break;
                case TypeValueKnownValues.Value_snow:
                    handler.string_value("snow");
                    break;
                case TypeValueKnownValues.Value_humidity:
                    handler.string_value("humidity");
                    break;
                case TypeValueKnownValues.Value_skycover:
                    handler.string_value("skycover");
                    break;
                case TypeValueKnownValues.Value_uv:
                    handler.string_value("uv");
                    break;
                case TypeValueKnownValues.Value_high_temperature:
                    handler.string_value("high_temperature");
                    break;
                case TypeValueKnownValues.Value_low_temperature:
                    handler.string_value("low_temperature");
                    break;
                case TypeValueKnownValues.Value_pollen:
                    handler.string_value("pollen");
                    break;
                case TypeValueKnownValues.Value_air_quality:
                    handler.string_value("air_quality");
                    break;
                case TypeValueKnownValues.Value_windchill:
                    handler.string_value("windchill");
                    break;
                case TypeValueKnownValues.Value_feels_like_temperature:
                    handler.string_value("feels_like_temperature");
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

    public static WeatherAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WeatherAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeatherAttribute", ignore_extras);
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
    public static WeatherAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WeatherAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WeatherAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeatherAttribute", ignore_extras);
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
    public static WeatherAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WeatherAttributeJSON from_text(string text, bool ignore_extras)
      {
        WeatherAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeatherAttribute", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WeatherAttributeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WeatherAttributeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WeatherAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeatherAttribute", ignore_extras);
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
            WeatherAttributeJSON result = new WeatherAttributeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(WeatherAttributeJSON new_result);
        public Generator(bool ignore_extras) : base("Type WeatherAttribute")
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
        protected override void handle_result(WeatherAttributeJSON  result)
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
        public WeatherAttributeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WeatherAttributeJSON  result)
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
    protected virtual void handle_result(List<WeatherAttributeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WeatherAttributeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WeatherAttributeJSON>();
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
    public List<WeatherAttributeJSON> value;
  };
  };
