/* file "HomeAutomationDeviceTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationDeviceTypeJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Switch,
        Value_Light,
        Value_Thermostat,
        Value_AirPurifier,
        Value_Vacuum,
        Value_ClothesWasher,
        Value_Lock,
        Value_Door,
        Value_Alarm,
        Value_Sensor,
        Value_Camera,
        Value_MusicPlayer,
        Value_MediaPlayer,
        Value_Drapes,
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
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "rPurifier", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeValueKnownValues.Value_AirPurifier;
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "arm", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_Alarm;
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "mera", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Camera;
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "othesWasher", 0, 11, false) == 0) && (chars.Length == 13))
                            return TypeValueKnownValues.Value_ClothesWasher;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (chars[1])
                  {
                    case 'o':
                        if ((String.Compare(chars, 2, "or", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Door;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "apes", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Drapes;
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "ght", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeValueKnownValues.Value_Light;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "ck", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeValueKnownValues.Value_Lock;
                        break;
                    default:
                        break;
                  }
                break;
            case 'M':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "diaPlayer", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeValueKnownValues.Value_MediaPlayer;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "sicPlayer", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeValueKnownValues.Value_MusicPlayer;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "nsor", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Sensor;
                        break;
                    case 'w':
                        if ((String.Compare(chars, 2, "itch", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Switch;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(chars, 1, "hermostat", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeValueKnownValues.Value_Thermostat;
                break;
            case 'V':
                if ((String.Compare(chars, 1, "acuum", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeValueKnownValues.Value_Vacuum;
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
            case TypeValueKnownValues.Value_Switch:
                return "Switch";
            case TypeValueKnownValues.Value_Light:
                return "Light";
            case TypeValueKnownValues.Value_Thermostat:
                return "Thermostat";
            case TypeValueKnownValues.Value_AirPurifier:
                return "AirPurifier";
            case TypeValueKnownValues.Value_Vacuum:
                return "Vacuum";
            case TypeValueKnownValues.Value_ClothesWasher:
                return "ClothesWasher";
            case TypeValueKnownValues.Value_Lock:
                return "Lock";
            case TypeValueKnownValues.Value_Door:
                return "Door";
            case TypeValueKnownValues.Value_Alarm:
                return "Alarm";
            case TypeValueKnownValues.Value_Sensor:
                return "Sensor";
            case TypeValueKnownValues.Value_Camera:
                return "Camera";
            case TypeValueKnownValues.Value_MusicPlayer:
                return "MusicPlayer";
            case TypeValueKnownValues.Value_MediaPlayer:
                return "MediaPlayer";
            case TypeValueKnownValues.Value_Drapes:
                return "Drapes";
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
            throw new Exception("The value for field Value of HomeAutomationDeviceTypeJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "rPurifier", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_AirPurifier;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "arm", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Alarm;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "mera", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Camera;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "othesWasher", 0, 11, false) == 0) && (json_string.getData().Length == 13))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_ClothesWasher;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "or", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Door;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "apes", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Drapes;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "ght", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Light;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "ck", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Lock;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "diaPlayer", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_MediaPlayer;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "sicPlayer", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_MusicPlayer;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "nsor", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Sensor;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'w':
                        if ((String.Compare(json_string.getData(), 2, "itch", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Switch;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "hermostat", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Thermostat;
                        goto open_enum_is_done;
                      }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "acuum", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Vacuum;
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


    public HomeAutomationDeviceTypeJSON()
      {
        flagHasValue = false;
      }

    public HomeAutomationDeviceTypeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public HomeAutomationDeviceTypeJSON(string init_value)
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

    public HomeAutomationDeviceTypeJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_Switch:
                    handler.string_value("Switch");
                    break;
                case TypeValueKnownValues.Value_Light:
                    handler.string_value("Light");
                    break;
                case TypeValueKnownValues.Value_Thermostat:
                    handler.string_value("Thermostat");
                    break;
                case TypeValueKnownValues.Value_AirPurifier:
                    handler.string_value("AirPurifier");
                    break;
                case TypeValueKnownValues.Value_Vacuum:
                    handler.string_value("Vacuum");
                    break;
                case TypeValueKnownValues.Value_ClothesWasher:
                    handler.string_value("ClothesWasher");
                    break;
                case TypeValueKnownValues.Value_Lock:
                    handler.string_value("Lock");
                    break;
                case TypeValueKnownValues.Value_Door:
                    handler.string_value("Door");
                    break;
                case TypeValueKnownValues.Value_Alarm:
                    handler.string_value("Alarm");
                    break;
                case TypeValueKnownValues.Value_Sensor:
                    handler.string_value("Sensor");
                    break;
                case TypeValueKnownValues.Value_Camera:
                    handler.string_value("Camera");
                    break;
                case TypeValueKnownValues.Value_MusicPlayer:
                    handler.string_value("MusicPlayer");
                    break;
                case TypeValueKnownValues.Value_MediaPlayer:
                    handler.string_value("MediaPlayer");
                    break;
                case TypeValueKnownValues.Value_Drapes:
                    handler.string_value("Drapes");
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
                case TypeValueKnownValues.Value_Switch:
                    handler.string_value("Switch");
                    break;
                case TypeValueKnownValues.Value_Light:
                    handler.string_value("Light");
                    break;
                case TypeValueKnownValues.Value_Thermostat:
                    handler.string_value("Thermostat");
                    break;
                case TypeValueKnownValues.Value_AirPurifier:
                    handler.string_value("AirPurifier");
                    break;
                case TypeValueKnownValues.Value_Vacuum:
                    handler.string_value("Vacuum");
                    break;
                case TypeValueKnownValues.Value_ClothesWasher:
                    handler.string_value("ClothesWasher");
                    break;
                case TypeValueKnownValues.Value_Lock:
                    handler.string_value("Lock");
                    break;
                case TypeValueKnownValues.Value_Door:
                    handler.string_value("Door");
                    break;
                case TypeValueKnownValues.Value_Alarm:
                    handler.string_value("Alarm");
                    break;
                case TypeValueKnownValues.Value_Sensor:
                    handler.string_value("Sensor");
                    break;
                case TypeValueKnownValues.Value_Camera:
                    handler.string_value("Camera");
                    break;
                case TypeValueKnownValues.Value_MusicPlayer:
                    handler.string_value("MusicPlayer");
                    break;
                case TypeValueKnownValues.Value_MediaPlayer:
                    handler.string_value("MediaPlayer");
                    break;
                case TypeValueKnownValues.Value_Drapes:
                    handler.string_value("Drapes");
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

    public static HomeAutomationDeviceTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationDeviceTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationDeviceType", ignore_extras);
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
    public static HomeAutomationDeviceTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationDeviceTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationDeviceTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationDeviceType", ignore_extras);
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
    public static HomeAutomationDeviceTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationDeviceTypeJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationDeviceTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationDeviceType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationDeviceTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationDeviceTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationDeviceTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationDeviceType", ignore_extras);
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
            HomeAutomationDeviceTypeJSON result = new HomeAutomationDeviceTypeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(HomeAutomationDeviceTypeJSON new_result);
        public Generator(bool ignore_extras) : base("Type HomeAutomationDeviceType")
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
        protected override void handle_result(HomeAutomationDeviceTypeJSON  result)
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
        public HomeAutomationDeviceTypeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationDeviceTypeJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationDeviceTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationDeviceTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationDeviceTypeJSON>();
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
    public List<HomeAutomationDeviceTypeJSON> value;
  };
  };
