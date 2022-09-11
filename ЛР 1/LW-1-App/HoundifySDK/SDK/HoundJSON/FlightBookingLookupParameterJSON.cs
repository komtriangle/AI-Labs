/* file "FlightBookingLookupParameterJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightBookingLookupParameterJSON : JSONBase
  {
    public enum TypeValue
      {
        Value_DepartureDate,
        Value_Destination,
        Value_TripType,
        Value_ReturnDate,
        Value_Nothing
      };

    public static TypeValue  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                if (String.Compare(chars, 1, "e", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'p':
                            if ((String.Compare(chars, 3, "artureDate", 0, 10, false) == 0) && (chars.Length == 13))
                                return TypeValue.Value_DepartureDate;
                            break;
                        case 's':
                            if ((String.Compare(chars, 3, "tination", 0, 8, false) == 0) && (chars.Length == 11))
                                return TypeValue.Value_Destination;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(chars, 1, "othing", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValue.Value_Nothing;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "eturnDate", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeValue.Value_ReturnDate;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "ripType", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeValue.Value_TripType;
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
            case TypeValue.Value_DepartureDate:
                return "DepartureDate";
            case TypeValue.Value_Destination:
                return "Destination";
            case TypeValue.Value_TripType:
                return "TripType";
            case TypeValue.Value_ReturnDate:
                return "ReturnDate";
            case TypeValue.Value_Nothing:
                return "Nothing";
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
            throw new Exception("The value for field Value of FlightBookingLookupParameterJSON is not a string.");
        TypeValue the_enum;
        switch (json_string.getData()[0])
          {
            case 'D':
                if (String.Compare(json_string.getData(), 1, "e", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'p':
                            if ((String.Compare(json_string.getData(), 3, "artureDate", 0, 10, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_enum = TypeValue.Value_DepartureDate;
                                    goto enum_is_done;
                                  }
                            break;
                        case 's':
                            if ((String.Compare(json_string.getData(), 3, "tination", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_enum = TypeValue.Value_Destination;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "othing", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeValue.Value_Nothing;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "eturnDate", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeValue.Value_ReturnDate;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "ripType", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeValue.Value_TripType;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Value of FlightBookingLookupParameterJSON is not one of the legal strings.");
      enum_is_done:;
        setValue(the_enum);
      }


    public FlightBookingLookupParameterJSON()
      {
        flagHasValue = false;
      }

    public FlightBookingLookupParameterJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public FlightBookingLookupParameterJSON(string init_value)
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
            case TypeValue.Value_DepartureDate:
                handler.string_value("DepartureDate");
                break;
            case TypeValue.Value_Destination:
                handler.string_value("Destination");
                break;
            case TypeValue.Value_TripType:
                handler.string_value("TripType");
                break;
            case TypeValue.Value_ReturnDate:
                handler.string_value("ReturnDate");
                break;
            case TypeValue.Value_Nothing:
                handler.string_value("Nothing");
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
            case TypeValue.Value_DepartureDate:
                handler.string_value("DepartureDate");
                break;
            case TypeValue.Value_Destination:
                handler.string_value("Destination");
                break;
            case TypeValue.Value_TripType:
                handler.string_value("TripType");
                break;
            case TypeValue.Value_ReturnDate:
                handler.string_value("ReturnDate");
                break;
            case TypeValue.Value_Nothing:
                handler.string_value("Nothing");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static FlightBookingLookupParameterJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightBookingLookupParameterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingLookupParameter", ignore_extras);
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
    public static FlightBookingLookupParameterJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightBookingLookupParameterJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightBookingLookupParameterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingLookupParameter", ignore_extras);
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
    public static FlightBookingLookupParameterJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightBookingLookupParameterJSON from_text(string text, bool ignore_extras)
      {
        FlightBookingLookupParameterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingLookupParameter", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightBookingLookupParameterJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightBookingLookupParameterJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightBookingLookupParameterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingLookupParameter", ignore_extras);
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
            FlightBookingLookupParameterJSON result = new FlightBookingLookupParameterJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(FlightBookingLookupParameterJSON new_result);
        public Generator(bool ignore_extras) : base("Type FlightBookingLookupParameter")
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
        protected override void handle_result(FlightBookingLookupParameterJSON  result)
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
        public FlightBookingLookupParameterJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightBookingLookupParameterJSON  result)
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
    protected virtual void handle_result(List<FlightBookingLookupParameterJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightBookingLookupParameterJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightBookingLookupParameterJSON>();
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
    public List<FlightBookingLookupParameterJSON> value;
  };
  };
