/* file "FlightSegmentSearchCriterionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightSegmentSearchCriterionJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_DepartureLocation,
        Value_DepartureDateTime,
        Value_DestinationLocation,
        Value_ArrivalDateTime,
        Value_FindNextAvailableFlight,
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
                if ((String.Compare(chars, 1, "rrivalDateTime", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeValueKnownValues.Value_ArrivalDateTime;
                break;
            case 'D':
                if (String.Compare(chars, 1, "e", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'p':
                            if (String.Compare(chars, 3, "arture", 0, 6, false) == 0)
                              {
                                switch (chars[9])
                                  {
                                    case 'D':
                                        if ((String.Compare(chars, 10, "ateTime", 0, 7, false) == 0) && (chars.Length == 17))
                                            return TypeValueKnownValues.Value_DepartureDateTime;
                                        break;
                                    case 'L':
                                        if ((String.Compare(chars, 10, "ocation", 0, 7, false) == 0) && (chars.Length == 17))
                                            return TypeValueKnownValues.Value_DepartureLocation;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if ((String.Compare(chars, 3, "tinationLocation", 0, 16, false) == 0) && (chars.Length == 19))
                                return TypeValueKnownValues.Value_DestinationLocation;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(chars, 1, "indNextAvailableFlight", 0, 22, false) == 0) && (chars.Length == 23))
                    return TypeValueKnownValues.Value_FindNextAvailableFlight;
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
            case TypeValueKnownValues.Value_DepartureLocation:
                return "DepartureLocation";
            case TypeValueKnownValues.Value_DepartureDateTime:
                return "DepartureDateTime";
            case TypeValueKnownValues.Value_DestinationLocation:
                return "DestinationLocation";
            case TypeValueKnownValues.Value_ArrivalDateTime:
                return "ArrivalDateTime";
            case TypeValueKnownValues.Value_FindNextAvailableFlight:
                return "FindNextAvailableFlight";
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
            throw new Exception("The value for field Value of FlightSegmentSearchCriterionJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "rrivalDateTime", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_ArrivalDateTime;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if (String.Compare(json_string.getData(), 1, "e", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'p':
                            if (String.Compare(json_string.getData(), 3, "arture", 0, 6, false) == 0)
                              {
                                switch (json_string.getData()[9])
                                  {
                                    case 'D':
                                        if ((String.Compare(json_string.getData(), 10, "ateTime", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_DepartureDateTime;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'L':
                                        if ((String.Compare(json_string.getData(), 10, "ocation", 0, 7, false) == 0) && (json_string.getData().Length == 17))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_DepartureLocation;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if ((String.Compare(json_string.getData(), 3, "tinationLocation", 0, 16, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_DestinationLocation;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "indNextAvailableFlight", 0, 22, false) == 0) && (json_string.getData().Length == 23))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_FindNextAvailableFlight;
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


    public FlightSegmentSearchCriterionJSON()
      {
        flagHasValue = false;
      }

    public FlightSegmentSearchCriterionJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public FlightSegmentSearchCriterionJSON(string init_value)
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

    public FlightSegmentSearchCriterionJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_DepartureLocation:
                    handler.string_value("DepartureLocation");
                    break;
                case TypeValueKnownValues.Value_DepartureDateTime:
                    handler.string_value("DepartureDateTime");
                    break;
                case TypeValueKnownValues.Value_DestinationLocation:
                    handler.string_value("DestinationLocation");
                    break;
                case TypeValueKnownValues.Value_ArrivalDateTime:
                    handler.string_value("ArrivalDateTime");
                    break;
                case TypeValueKnownValues.Value_FindNextAvailableFlight:
                    handler.string_value("FindNextAvailableFlight");
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
                case TypeValueKnownValues.Value_DepartureLocation:
                    handler.string_value("DepartureLocation");
                    break;
                case TypeValueKnownValues.Value_DepartureDateTime:
                    handler.string_value("DepartureDateTime");
                    break;
                case TypeValueKnownValues.Value_DestinationLocation:
                    handler.string_value("DestinationLocation");
                    break;
                case TypeValueKnownValues.Value_ArrivalDateTime:
                    handler.string_value("ArrivalDateTime");
                    break;
                case TypeValueKnownValues.Value_FindNextAvailableFlight:
                    handler.string_value("FindNextAvailableFlight");
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

    public static FlightSegmentSearchCriterionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSegmentSearchCriterionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentSearchCriterion", ignore_extras);
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
    public static FlightSegmentSearchCriterionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSegmentSearchCriterionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSegmentSearchCriterionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentSearchCriterion", ignore_extras);
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
    public static FlightSegmentSearchCriterionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSegmentSearchCriterionJSON from_text(string text, bool ignore_extras)
      {
        FlightSegmentSearchCriterionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentSearchCriterion", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightSegmentSearchCriterionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightSegmentSearchCriterionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightSegmentSearchCriterionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSegmentSearchCriterion", ignore_extras);
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
            FlightSegmentSearchCriterionJSON result = new FlightSegmentSearchCriterionJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(FlightSegmentSearchCriterionJSON new_result);
        public Generator(bool ignore_extras) : base("Type FlightSegmentSearchCriterion")
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
        protected override void handle_result(FlightSegmentSearchCriterionJSON  result)
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
        public FlightSegmentSearchCriterionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightSegmentSearchCriterionJSON  result)
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
    protected virtual void handle_result(List<FlightSegmentSearchCriterionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightSegmentSearchCriterionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightSegmentSearchCriterionJSON>();
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
    public List<FlightSegmentSearchCriterionJSON> value;
  };
  };
