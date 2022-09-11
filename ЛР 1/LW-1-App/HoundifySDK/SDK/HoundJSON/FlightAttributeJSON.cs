/* file "FlightAttributeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightAttributeJSON : JSONBase
  {
    public enum TypeValue
      {
        Value_Status,
        Value_DepartureInformation,
        Value_DepartureTime,
        Value_HasDeparted,
        Value_DepartureLocation,
        Value_DepartureAirport,
        Value_DepartureTerminal,
        Value_DepartureGate,
        Value_ArrivalInformation,
        Value_ArrivalTime,
        Value_HasArrived,
        Value_ArrivalLocation,
        Value_ArrivalAirport,
        Value_ArrivalTerminal,
        Value_ArrivalGate,
        Value_FlightDuration
      };

    public static TypeValue  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if (String.Compare(chars, 1, "rrival", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'A':
                            if ((String.Compare(chars, 8, "irport", 0, 6, false) == 0) && (chars.Length == 14))
                                return TypeValue.Value_ArrivalAirport;
                            break;
                        case 'G':
                            if ((String.Compare(chars, 8, "ate", 0, 3, false) == 0) && (chars.Length == 11))
                                return TypeValue.Value_ArrivalGate;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 8, "nformation", 0, 10, false) == 0) && (chars.Length == 18))
                                return TypeValue.Value_ArrivalInformation;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 8, "ocation", 0, 7, false) == 0) && (chars.Length == 15))
                                return TypeValue.Value_ArrivalLocation;
                            break;
                        case 'T':
                            switch (chars[8])
                              {
                                case 'e':
                                    if ((String.Compare(chars, 9, "rminal", 0, 6, false) == 0) && (chars.Length == 15))
                                        return TypeValue.Value_ArrivalTerminal;
                                    break;
                                case 'i':
                                    if ((String.Compare(chars, 9, "me", 0, 2, false) == 0) && (chars.Length == 11))
                                        return TypeValue.Value_ArrivalTime;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                if (String.Compare(chars, 1, "eparture", 0, 8, false) == 0)
                  {
                    switch (chars[9])
                      {
                        case 'A':
                            if ((String.Compare(chars, 10, "irport", 0, 6, false) == 0) && (chars.Length == 16))
                                return TypeValue.Value_DepartureAirport;
                            break;
                        case 'G':
                            if ((String.Compare(chars, 10, "ate", 0, 3, false) == 0) && (chars.Length == 13))
                                return TypeValue.Value_DepartureGate;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 10, "nformation", 0, 10, false) == 0) && (chars.Length == 20))
                                return TypeValue.Value_DepartureInformation;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 10, "ocation", 0, 7, false) == 0) && (chars.Length == 17))
                                return TypeValue.Value_DepartureLocation;
                            break;
                        case 'T':
                            switch (chars[10])
                              {
                                case 'e':
                                    if ((String.Compare(chars, 11, "rminal", 0, 6, false) == 0) && (chars.Length == 17))
                                        return TypeValue.Value_DepartureTerminal;
                                    break;
                                case 'i':
                                    if ((String.Compare(chars, 11, "me", 0, 2, false) == 0) && (chars.Length == 13))
                                        return TypeValue.Value_DepartureTime;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(chars, 1, "lightDuration", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeValue.Value_FlightDuration;
                break;
            case 'H':
                if (String.Compare(chars, 1, "as", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'A':
                            if ((String.Compare(chars, 4, "rrived", 0, 6, false) == 0) && (chars.Length == 10))
                                return TypeValue.Value_HasArrived;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 4, "eparted", 0, 7, false) == 0) && (chars.Length == 11))
                                return TypeValue.Value_HasDeparted;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "tatus", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeValue.Value_Status;
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
            case TypeValue.Value_Status:
                return "Status";
            case TypeValue.Value_DepartureInformation:
                return "DepartureInformation";
            case TypeValue.Value_DepartureTime:
                return "DepartureTime";
            case TypeValue.Value_HasDeparted:
                return "HasDeparted";
            case TypeValue.Value_DepartureLocation:
                return "DepartureLocation";
            case TypeValue.Value_DepartureAirport:
                return "DepartureAirport";
            case TypeValue.Value_DepartureTerminal:
                return "DepartureTerminal";
            case TypeValue.Value_DepartureGate:
                return "DepartureGate";
            case TypeValue.Value_ArrivalInformation:
                return "ArrivalInformation";
            case TypeValue.Value_ArrivalTime:
                return "ArrivalTime";
            case TypeValue.Value_HasArrived:
                return "HasArrived";
            case TypeValue.Value_ArrivalLocation:
                return "ArrivalLocation";
            case TypeValue.Value_ArrivalAirport:
                return "ArrivalAirport";
            case TypeValue.Value_ArrivalTerminal:
                return "ArrivalTerminal";
            case TypeValue.Value_ArrivalGate:
                return "ArrivalGate";
            case TypeValue.Value_FlightDuration:
                return "FlightDuration";
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
            throw new Exception("The value for field Value of FlightAttributeJSON is not a string.");
        TypeValue the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if (String.Compare(json_string.getData(), 1, "rrival", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 8, "irport", 0, 6, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_enum = TypeValue.Value_ArrivalAirport;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'G':
                            if ((String.Compare(json_string.getData(), 8, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_enum = TypeValue.Value_ArrivalGate;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 8, "nformation", 0, 10, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_enum = TypeValue.Value_ArrivalInformation;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 8, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_enum = TypeValue.Value_ArrivalLocation;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'T':
                            switch (json_string.getData()[8])
                              {
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 9, "rminal", 0, 6, false) == 0) && (json_string.getData().Length == 15))
                                          {
                                            the_enum = TypeValue.Value_ArrivalTerminal;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'i':
                                    if ((String.Compare(json_string.getData(), 9, "me", 0, 2, false) == 0) && (json_string.getData().Length == 11))
                                          {
                                            the_enum = TypeValue.Value_ArrivalTime;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                if (String.Compare(json_string.getData(), 1, "eparture", 0, 8, false) == 0)
                  {
                    switch (json_string.getData()[9])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 10, "irport", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_enum = TypeValue.Value_DepartureAirport;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'G':
                            if ((String.Compare(json_string.getData(), 10, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_enum = TypeValue.Value_DepartureGate;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 10, "nformation", 0, 10, false) == 0) && (json_string.getData().Length == 20))
                                  {
                                    the_enum = TypeValue.Value_DepartureInformation;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 10, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                  {
                                    the_enum = TypeValue.Value_DepartureLocation;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'T':
                            switch (json_string.getData()[10])
                              {
                                case 'e':
                                    if ((String.Compare(json_string.getData(), 11, "rminal", 0, 6, false) == 0) && (json_string.getData().Length == 17))
                                          {
                                            the_enum = TypeValue.Value_DepartureTerminal;
                                            goto enum_is_done;
                                          }
                                    break;
                                case 'i':
                                    if ((String.Compare(json_string.getData(), 11, "me", 0, 2, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_enum = TypeValue.Value_DepartureTime;
                                            goto enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "lightDuration", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_enum = TypeValue.Value_FlightDuration;
                        goto enum_is_done;
                      }
                break;
            case 'H':
                if (String.Compare(json_string.getData(), 1, "as", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 4, "rrived", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_enum = TypeValue.Value_HasArrived;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 4, "eparted", 0, 7, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_enum = TypeValue.Value_HasDeparted;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "tatus", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeValue.Value_Status;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Value of FlightAttributeJSON is not one of the legal strings.");
      enum_is_done:;
        setValue(the_enum);
      }


    public FlightAttributeJSON()
      {
        flagHasValue = false;
      }

    public FlightAttributeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public FlightAttributeJSON(string init_value)
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
            case TypeValue.Value_Status:
                handler.string_value("Status");
                break;
            case TypeValue.Value_DepartureInformation:
                handler.string_value("DepartureInformation");
                break;
            case TypeValue.Value_DepartureTime:
                handler.string_value("DepartureTime");
                break;
            case TypeValue.Value_HasDeparted:
                handler.string_value("HasDeparted");
                break;
            case TypeValue.Value_DepartureLocation:
                handler.string_value("DepartureLocation");
                break;
            case TypeValue.Value_DepartureAirport:
                handler.string_value("DepartureAirport");
                break;
            case TypeValue.Value_DepartureTerminal:
                handler.string_value("DepartureTerminal");
                break;
            case TypeValue.Value_DepartureGate:
                handler.string_value("DepartureGate");
                break;
            case TypeValue.Value_ArrivalInformation:
                handler.string_value("ArrivalInformation");
                break;
            case TypeValue.Value_ArrivalTime:
                handler.string_value("ArrivalTime");
                break;
            case TypeValue.Value_HasArrived:
                handler.string_value("HasArrived");
                break;
            case TypeValue.Value_ArrivalLocation:
                handler.string_value("ArrivalLocation");
                break;
            case TypeValue.Value_ArrivalAirport:
                handler.string_value("ArrivalAirport");
                break;
            case TypeValue.Value_ArrivalTerminal:
                handler.string_value("ArrivalTerminal");
                break;
            case TypeValue.Value_ArrivalGate:
                handler.string_value("ArrivalGate");
                break;
            case TypeValue.Value_FlightDuration:
                handler.string_value("FlightDuration");
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
            case TypeValue.Value_Status:
                handler.string_value("Status");
                break;
            case TypeValue.Value_DepartureInformation:
                handler.string_value("DepartureInformation");
                break;
            case TypeValue.Value_DepartureTime:
                handler.string_value("DepartureTime");
                break;
            case TypeValue.Value_HasDeparted:
                handler.string_value("HasDeparted");
                break;
            case TypeValue.Value_DepartureLocation:
                handler.string_value("DepartureLocation");
                break;
            case TypeValue.Value_DepartureAirport:
                handler.string_value("DepartureAirport");
                break;
            case TypeValue.Value_DepartureTerminal:
                handler.string_value("DepartureTerminal");
                break;
            case TypeValue.Value_DepartureGate:
                handler.string_value("DepartureGate");
                break;
            case TypeValue.Value_ArrivalInformation:
                handler.string_value("ArrivalInformation");
                break;
            case TypeValue.Value_ArrivalTime:
                handler.string_value("ArrivalTime");
                break;
            case TypeValue.Value_HasArrived:
                handler.string_value("HasArrived");
                break;
            case TypeValue.Value_ArrivalLocation:
                handler.string_value("ArrivalLocation");
                break;
            case TypeValue.Value_ArrivalAirport:
                handler.string_value("ArrivalAirport");
                break;
            case TypeValue.Value_ArrivalTerminal:
                handler.string_value("ArrivalTerminal");
                break;
            case TypeValue.Value_ArrivalGate:
                handler.string_value("ArrivalGate");
                break;
            case TypeValue.Value_FlightDuration:
                handler.string_value("FlightDuration");
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }

    public static FlightAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightAttribute", ignore_extras);
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
    public static FlightAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightAttribute", ignore_extras);
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
    public static FlightAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightAttributeJSON from_text(string text, bool ignore_extras)
      {
        FlightAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightAttribute", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightAttributeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightAttributeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightAttribute", ignore_extras);
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
            FlightAttributeJSON result = new FlightAttributeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(FlightAttributeJSON new_result);
        public Generator(bool ignore_extras) : base("Type FlightAttribute")
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
        protected override void handle_result(FlightAttributeJSON  result)
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
        public FlightAttributeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightAttributeJSON  result)
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
    protected virtual void handle_result(List<FlightAttributeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightAttributeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightAttributeJSON>();
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
    public List<FlightAttributeJSON> value;
  };
  };
