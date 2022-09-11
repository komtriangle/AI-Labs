/* file "CarMirrorSelectionEnumJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarMirrorSelectionEnumJSON : JSONBase
  {
    public enum TypeValue
      {
        Value_LeftMirror,
        Value_RightMirror,
        Value_DriverMirror,
        Value_PassengerMirror,
        Value_BothMirrors
      };

    public static TypeValue  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "othMirrors", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeValue.Value_BothMirrors;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "riverMirror", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeValue.Value_DriverMirror;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "eftMirror", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeValue.Value_LeftMirror;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "assengerMirror", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeValue.Value_PassengerMirror;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "ightMirror", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeValue.Value_RightMirror;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Value' is not one of the legal values.");
      }

    public static string  stringFromValue(TypeValue the_enum)
      {
        switch (the_enum)
          {
            case TypeValue.Value_LeftMirror:
                return "LeftMirror";
            case TypeValue.Value_RightMirror:
                return "RightMirror";
            case TypeValue.Value_DriverMirror:
                return "DriverMirror";
            case TypeValue.Value_PassengerMirror:
                return "PassengerMirror";
            case TypeValue.Value_BothMirrors:
                return "BothMirrors";
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
            throw new Exception("The value for field Value of CarMirrorSelectionEnumJSON is not a string.");
        TypeValue the_enum;
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "othMirrors", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeValue.Value_BothMirrors;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "riverMirror", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_enum = TypeValue.Value_DriverMirror;
                        goto enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "eftMirror", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeValue.Value_LeftMirror;
                        goto enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "assengerMirror", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_enum = TypeValue.Value_PassengerMirror;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "ightMirror", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeValue.Value_RightMirror;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Value of CarMirrorSelectionEnumJSON is not one of the legal strings.");
      enum_is_done:;
        setValue(the_enum);
      }


    public CarMirrorSelectionEnumJSON()
      {
        flagHasValue = false;
      }

    public CarMirrorSelectionEnumJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public CarMirrorSelectionEnumJSON(string init_value)
      {
        flagHasValue = true;
        storeValue = stringToValue(init_value);
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
        return stringFromValue(getValue());
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        setValue(stringToValue(chars));
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        switch (storeValue)
          {
            case TypeValue.Value_LeftMirror:
                handler.string_value("LeftMirror");
                break;
            case TypeValue.Value_RightMirror:
                handler.string_value("RightMirror");
                break;
            case TypeValue.Value_DriverMirror:
                handler.string_value("DriverMirror");
                break;
            case TypeValue.Value_PassengerMirror:
                handler.string_value("PassengerMirror");
                break;
            case TypeValue.Value_BothMirrors:
                handler.string_value("BothMirrors");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        switch (storeValue)
          {
            case TypeValue.Value_LeftMirror:
                handler.string_value("LeftMirror");
                break;
            case TypeValue.Value_RightMirror:
                handler.string_value("RightMirror");
                break;
            case TypeValue.Value_DriverMirror:
                handler.string_value("DriverMirror");
                break;
            case TypeValue.Value_PassengerMirror:
                handler.string_value("PassengerMirror");
                break;
            case TypeValue.Value_BothMirrors:
                handler.string_value("BothMirrors");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static CarMirrorSelectionEnumJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarMirrorSelectionEnumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarMirrorSelectionEnum", ignore_extras);
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
    public static CarMirrorSelectionEnumJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarMirrorSelectionEnumJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarMirrorSelectionEnumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarMirrorSelectionEnum", ignore_extras);
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
    public static CarMirrorSelectionEnumJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarMirrorSelectionEnumJSON from_text(string text, bool ignore_extras)
      {
        CarMirrorSelectionEnumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarMirrorSelectionEnum", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarMirrorSelectionEnumJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CarMirrorSelectionEnumJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarMirrorSelectionEnumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarMirrorSelectionEnum", ignore_extras);
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
            handle_result(stringToValue(result));
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
            CarMirrorSelectionEnumJSON result = new CarMirrorSelectionEnumJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(CarMirrorSelectionEnumJSON new_result);
        public Generator(bool ignore_extras) : base("Type CarMirrorSelectionEnum")
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
        protected override void handle_result(CarMirrorSelectionEnumJSON  result)
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
        public CarMirrorSelectionEnumJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarMirrorSelectionEnumJSON  result)
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
    protected virtual void handle_result(List<CarMirrorSelectionEnumJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarMirrorSelectionEnumJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarMirrorSelectionEnumJSON>();
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
    public List<CarMirrorSelectionEnumJSON> value;
  };
  };
