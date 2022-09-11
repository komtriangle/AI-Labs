/* file "FlightPassengerTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightPassengerTypeJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Adult,
        Value_Senior,
        Value_Student,
        Value_Child,
        Value_InfantInSeat,
        Value_InfantInLap,
        Value_Youth,
        Value_Kid,
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
                if ((String.Compare(chars, 1, "dult", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeValueKnownValues.Value_Adult;
                break;
            case 'C':
                if ((String.Compare(chars, 1, "hild", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeValueKnownValues.Value_Child;
                break;
            case 'I':
                if (String.Compare(chars, 1, "nfantIn", 0, 7, false) == 0)
                  {
                    switch (chars[8])
                      {
                        case 'L':
                            if ((String.Compare(chars, 9, "ap", 0, 2, false) == 0) && (chars.Length == 11))
                                return TypeValueKnownValues.Value_InfantInLap;
                            break;
                        case 'S':
                            if ((String.Compare(chars, 9, "eat", 0, 3, false) == 0) && (chars.Length == 12))
                                return TypeValueKnownValues.Value_InfantInSeat;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'K':
                if ((String.Compare(chars, 1, "id", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeValueKnownValues.Value_Kid;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'e':
                        if ((String.Compare(chars, 2, "nior", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeValueKnownValues.Value_Senior;
                        break;
                    case 't':
                        if ((String.Compare(chars, 2, "udent", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeValueKnownValues.Value_Student;
                        break;
                    default:
                        break;
                  }
                break;
            case 'Y':
                if ((String.Compare(chars, 1, "outh", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeValueKnownValues.Value_Youth;
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
            case TypeValueKnownValues.Value_Adult:
                return "Adult";
            case TypeValueKnownValues.Value_Senior:
                return "Senior";
            case TypeValueKnownValues.Value_Student:
                return "Student";
            case TypeValueKnownValues.Value_Child:
                return "Child";
            case TypeValueKnownValues.Value_InfantInSeat:
                return "InfantInSeat";
            case TypeValueKnownValues.Value_InfantInLap:
                return "InfantInLap";
            case TypeValueKnownValues.Value_Youth:
                return "Youth";
            case TypeValueKnownValues.Value_Kid:
                return "Kid";
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
            throw new Exception("The value for field Value of FlightPassengerTypeJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "dult", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Adult;
                        goto open_enum_is_done;
                      }
                break;
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "hild", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Child;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if (String.Compare(json_string.getData(), 1, "nfantIn", 0, 7, false) == 0)
                  {
                    switch (json_string.getData()[8])
                      {
                        case 'L':
                            if ((String.Compare(json_string.getData(), 9, "ap", 0, 2, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_InfantInLap;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 9, "eat", 0, 3, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_InfantInSeat;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'K':
                if ((String.Compare(json_string.getData(), 1, "id", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Kid;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "nior", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Senior;
                                goto open_enum_is_done;
                              }
                        break;
                    case 't':
                        if ((String.Compare(json_string.getData(), 2, "udent", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_Student;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'Y':
                if ((String.Compare(json_string.getData(), 1, "outh", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Youth;
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


    public FlightPassengerTypeJSON()
      {
        flagHasValue = false;
      }

    public FlightPassengerTypeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public FlightPassengerTypeJSON(string init_value)
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

    public FlightPassengerTypeJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_Adult:
                    handler.string_value("Adult");
                    break;
                case TypeValueKnownValues.Value_Senior:
                    handler.string_value("Senior");
                    break;
                case TypeValueKnownValues.Value_Student:
                    handler.string_value("Student");
                    break;
                case TypeValueKnownValues.Value_Child:
                    handler.string_value("Child");
                    break;
                case TypeValueKnownValues.Value_InfantInSeat:
                    handler.string_value("InfantInSeat");
                    break;
                case TypeValueKnownValues.Value_InfantInLap:
                    handler.string_value("InfantInLap");
                    break;
                case TypeValueKnownValues.Value_Youth:
                    handler.string_value("Youth");
                    break;
                case TypeValueKnownValues.Value_Kid:
                    handler.string_value("Kid");
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
                case TypeValueKnownValues.Value_Adult:
                    handler.string_value("Adult");
                    break;
                case TypeValueKnownValues.Value_Senior:
                    handler.string_value("Senior");
                    break;
                case TypeValueKnownValues.Value_Student:
                    handler.string_value("Student");
                    break;
                case TypeValueKnownValues.Value_Child:
                    handler.string_value("Child");
                    break;
                case TypeValueKnownValues.Value_InfantInSeat:
                    handler.string_value("InfantInSeat");
                    break;
                case TypeValueKnownValues.Value_InfantInLap:
                    handler.string_value("InfantInLap");
                    break;
                case TypeValueKnownValues.Value_Youth:
                    handler.string_value("Youth");
                    break;
                case TypeValueKnownValues.Value_Kid:
                    handler.string_value("Kid");
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

    public static FlightPassengerTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightPassengerTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightPassengerType", ignore_extras);
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
    public static FlightPassengerTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightPassengerTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightPassengerTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightPassengerType", ignore_extras);
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
    public static FlightPassengerTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightPassengerTypeJSON from_text(string text, bool ignore_extras)
      {
        FlightPassengerTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightPassengerType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightPassengerTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightPassengerTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightPassengerTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightPassengerType", ignore_extras);
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
            FlightPassengerTypeJSON result = new FlightPassengerTypeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(FlightPassengerTypeJSON new_result);
        public Generator(bool ignore_extras) : base("Type FlightPassengerType")
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
        protected override void handle_result(FlightPassengerTypeJSON  result)
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
        public FlightPassengerTypeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightPassengerTypeJSON  result)
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
    protected virtual void handle_result(List<FlightPassengerTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightPassengerTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightPassengerTypeJSON>();
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
    public List<FlightPassengerTypeJSON> value;
  };
  };
