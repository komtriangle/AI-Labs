/* file "FlightSearchCriterionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightSearchCriterionJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_NumberOfStops,
        Value_PriceRange,
        Value_SeatPreferences,
        Value_RangeOfLayoverDuration,
        Value_RangeOfTotalLayoverDuration,
        Value_RangeOfTravelDuration,
        Value_RangeOfTotalTravelDuration,
        Value_SameDayOrOvernight,
        Value_Airlines,
        Value_FlightSegments,
        Value_ReturnFlightSegment,
        Value_LastTripDuration,
        Value_PassengerTypeCounts,
        Value_CabinClasses,
        Value_Airports,
        Value_SortCriteria,
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
                if (String.Compare(chars, 1, "ir", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'l':
                            if ((String.Compare(chars, 4, "ines", 0, 4, false) == 0) && (chars.Length == 8))
                                return TypeValueKnownValues.Value_Airlines;
                            break;
                        case 'p':
                            if ((String.Compare(chars, 4, "orts", 0, 4, false) == 0) && (chars.Length == 8))
                                return TypeValueKnownValues.Value_Airports;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                if ((String.Compare(chars, 1, "abinClasses", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeValueKnownValues.Value_CabinClasses;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "lightSegments", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeValueKnownValues.Value_FlightSegments;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "astTripDuration", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeValueKnownValues.Value_LastTripDuration;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "umberOfStops", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeValueKnownValues.Value_NumberOfStops;
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "ssengerTypeCounts", 0, 17, false) == 0) && (chars.Length == 19))
                            return TypeValueKnownValues.Value_PassengerTypeCounts;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "iceRange", 0, 8, false) == 0) && (chars.Length == 10))
                            return TypeValueKnownValues.Value_PriceRange;
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                switch (chars[1])
                  {
                    case 'a':
                        if (String.Compare(chars, 2, "ngeOf", 0, 5, false) == 0)
                          {
                            switch (chars[7])
                              {
                                case 'L':
                                    if ((String.Compare(chars, 8, "ayoverDuration", 0, 14, false) == 0) && (chars.Length == 22))
                                        return TypeValueKnownValues.Value_RangeOfLayoverDuration;
                                    break;
                                case 'T':
                                    switch (chars[8])
                                      {
                                        case 'o':
                                            if (String.Compare(chars, 9, "tal", 0, 3, false) == 0)
                                              {
                                                switch (chars[12])
                                                  {
                                                    case 'L':
                                                        if ((String.Compare(chars, 13, "ayoverDuration", 0, 14, false) == 0) && (chars.Length == 27))
                                                            return TypeValueKnownValues.Value_RangeOfTotalLayoverDuration;
                                                        break;
                                                    case 'T':
                                                        if ((String.Compare(chars, 13, "ravelDuration", 0, 13, false) == 0) && (chars.Length == 26))
                                                            return TypeValueKnownValues.Value_RangeOfTotalTravelDuration;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'r':
                                            if ((String.Compare(chars, 9, "avelDuration", 0, 12, false) == 0) && (chars.Length == 21))
                                                return TypeValueKnownValues.Value_RangeOfTravelDuration;
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
                    case 'e':
                        if ((String.Compare(chars, 2, "turnFlightSegment", 0, 17, false) == 0) && (chars.Length == 19))
                            return TypeValueKnownValues.Value_ReturnFlightSegment;
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "meDayOrOvernight", 0, 16, false) == 0) && (chars.Length == 18))
                            return TypeValueKnownValues.Value_SameDayOrOvernight;
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "atPreferences", 0, 13, false) == 0) && (chars.Length == 15))
                            return TypeValueKnownValues.Value_SeatPreferences;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "rtCriteria", 0, 10, false) == 0) && (chars.Length == 12))
                            return TypeValueKnownValues.Value_SortCriteria;
                        break;
                    default:
                        break;
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
            case TypeValueKnownValues.Value_NumberOfStops:
                return "NumberOfStops";
            case TypeValueKnownValues.Value_PriceRange:
                return "PriceRange";
            case TypeValueKnownValues.Value_SeatPreferences:
                return "SeatPreferences";
            case TypeValueKnownValues.Value_RangeOfLayoverDuration:
                return "RangeOfLayoverDuration";
            case TypeValueKnownValues.Value_RangeOfTotalLayoverDuration:
                return "RangeOfTotalLayoverDuration";
            case TypeValueKnownValues.Value_RangeOfTravelDuration:
                return "RangeOfTravelDuration";
            case TypeValueKnownValues.Value_RangeOfTotalTravelDuration:
                return "RangeOfTotalTravelDuration";
            case TypeValueKnownValues.Value_SameDayOrOvernight:
                return "SameDayOrOvernight";
            case TypeValueKnownValues.Value_Airlines:
                return "Airlines";
            case TypeValueKnownValues.Value_FlightSegments:
                return "FlightSegments";
            case TypeValueKnownValues.Value_ReturnFlightSegment:
                return "ReturnFlightSegment";
            case TypeValueKnownValues.Value_LastTripDuration:
                return "LastTripDuration";
            case TypeValueKnownValues.Value_PassengerTypeCounts:
                return "PassengerTypeCounts";
            case TypeValueKnownValues.Value_CabinClasses:
                return "CabinClasses";
            case TypeValueKnownValues.Value_Airports:
                return "Airports";
            case TypeValueKnownValues.Value_SortCriteria:
                return "SortCriteria";
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
            throw new Exception("The value for field Value of FlightSearchCriterionJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                if (String.Compare(json_string.getData(), 1, "ir", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'l':
                            if ((String.Compare(json_string.getData(), 4, "ines", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_Airlines;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'p':
                            if ((String.Compare(json_string.getData(), 4, "orts", 0, 4, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_Airports;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "abinClasses", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_CabinClasses;
                        goto open_enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "lightSegments", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_FlightSegments;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "astTripDuration", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_LastTripDuration;
                        goto open_enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "umberOfStops", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_NumberOfStops;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "ssengerTypeCounts", 0, 17, false) == 0) && (json_string.getData().Length == 19))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_PassengerTypeCounts;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "iceRange", 0, 8, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_PriceRange;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if (String.Compare(json_string.getData(), 2, "ngeOf", 0, 5, false) == 0)
                          {
                            switch (json_string.getData()[7])
                              {
                                case 'L':
                                    if ((String.Compare(json_string.getData(), 8, "ayoverDuration", 0, 14, false) == 0) && (json_string.getData().Length == 22))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeValueKnownValues.Value_RangeOfLayoverDuration;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'T':
                                    switch (json_string.getData()[8])
                                      {
                                        case 'o':
                                            if (String.Compare(json_string.getData(), 9, "tal", 0, 3, false) == 0)
                                              {
                                                switch (json_string.getData()[12])
                                                  {
                                                    case 'L':
                                                        if ((String.Compare(json_string.getData(), 13, "ayoverDuration", 0, 14, false) == 0) && (json_string.getData().Length == 27))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_RangeOfTotalLayoverDuration;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    case 'T':
                                                        if ((String.Compare(json_string.getData(), 13, "ravelDuration", 0, 13, false) == 0) && (json_string.getData().Length == 26))
                                                              {
                                                                the_open_enum.in_known_list = true;
                                                                the_open_enum.list_value = TypeValueKnownValues.Value_RangeOfTotalTravelDuration;
                                                                goto open_enum_is_done;
                                                              }
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'r':
                                            if ((String.Compare(json_string.getData(), 9, "avelDuration", 0, 12, false) == 0) && (json_string.getData().Length == 21))
                                                  {
                                                    the_open_enum.in_known_list = true;
                                                    the_open_enum.list_value = TypeValueKnownValues.Value_RangeOfTravelDuration;
                                                    goto open_enum_is_done;
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
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "turnFlightSegment", 0, 17, false) == 0) && (json_string.getData().Length == 19))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_ReturnFlightSegment;
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
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "meDayOrOvernight", 0, 16, false) == 0) && (json_string.getData().Length == 18))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_SameDayOrOvernight;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "atPreferences", 0, 13, false) == 0) && (json_string.getData().Length == 15))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_SeatPreferences;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "rtCriteria", 0, 10, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_SortCriteria;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
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


    public FlightSearchCriterionJSON()
      {
        flagHasValue = false;
      }

    public FlightSearchCriterionJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public FlightSearchCriterionJSON(string init_value)
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

    public FlightSearchCriterionJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_NumberOfStops:
                    handler.string_value("NumberOfStops");
                    break;
                case TypeValueKnownValues.Value_PriceRange:
                    handler.string_value("PriceRange");
                    break;
                case TypeValueKnownValues.Value_SeatPreferences:
                    handler.string_value("SeatPreferences");
                    break;
                case TypeValueKnownValues.Value_RangeOfLayoverDuration:
                    handler.string_value("RangeOfLayoverDuration");
                    break;
                case TypeValueKnownValues.Value_RangeOfTotalLayoverDuration:
                    handler.string_value("RangeOfTotalLayoverDuration");
                    break;
                case TypeValueKnownValues.Value_RangeOfTravelDuration:
                    handler.string_value("RangeOfTravelDuration");
                    break;
                case TypeValueKnownValues.Value_RangeOfTotalTravelDuration:
                    handler.string_value("RangeOfTotalTravelDuration");
                    break;
                case TypeValueKnownValues.Value_SameDayOrOvernight:
                    handler.string_value("SameDayOrOvernight");
                    break;
                case TypeValueKnownValues.Value_Airlines:
                    handler.string_value("Airlines");
                    break;
                case TypeValueKnownValues.Value_FlightSegments:
                    handler.string_value("FlightSegments");
                    break;
                case TypeValueKnownValues.Value_ReturnFlightSegment:
                    handler.string_value("ReturnFlightSegment");
                    break;
                case TypeValueKnownValues.Value_LastTripDuration:
                    handler.string_value("LastTripDuration");
                    break;
                case TypeValueKnownValues.Value_PassengerTypeCounts:
                    handler.string_value("PassengerTypeCounts");
                    break;
                case TypeValueKnownValues.Value_CabinClasses:
                    handler.string_value("CabinClasses");
                    break;
                case TypeValueKnownValues.Value_Airports:
                    handler.string_value("Airports");
                    break;
                case TypeValueKnownValues.Value_SortCriteria:
                    handler.string_value("SortCriteria");
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
                case TypeValueKnownValues.Value_NumberOfStops:
                    handler.string_value("NumberOfStops");
                    break;
                case TypeValueKnownValues.Value_PriceRange:
                    handler.string_value("PriceRange");
                    break;
                case TypeValueKnownValues.Value_SeatPreferences:
                    handler.string_value("SeatPreferences");
                    break;
                case TypeValueKnownValues.Value_RangeOfLayoverDuration:
                    handler.string_value("RangeOfLayoverDuration");
                    break;
                case TypeValueKnownValues.Value_RangeOfTotalLayoverDuration:
                    handler.string_value("RangeOfTotalLayoverDuration");
                    break;
                case TypeValueKnownValues.Value_RangeOfTravelDuration:
                    handler.string_value("RangeOfTravelDuration");
                    break;
                case TypeValueKnownValues.Value_RangeOfTotalTravelDuration:
                    handler.string_value("RangeOfTotalTravelDuration");
                    break;
                case TypeValueKnownValues.Value_SameDayOrOvernight:
                    handler.string_value("SameDayOrOvernight");
                    break;
                case TypeValueKnownValues.Value_Airlines:
                    handler.string_value("Airlines");
                    break;
                case TypeValueKnownValues.Value_FlightSegments:
                    handler.string_value("FlightSegments");
                    break;
                case TypeValueKnownValues.Value_ReturnFlightSegment:
                    handler.string_value("ReturnFlightSegment");
                    break;
                case TypeValueKnownValues.Value_LastTripDuration:
                    handler.string_value("LastTripDuration");
                    break;
                case TypeValueKnownValues.Value_PassengerTypeCounts:
                    handler.string_value("PassengerTypeCounts");
                    break;
                case TypeValueKnownValues.Value_CabinClasses:
                    handler.string_value("CabinClasses");
                    break;
                case TypeValueKnownValues.Value_Airports:
                    handler.string_value("Airports");
                    break;
                case TypeValueKnownValues.Value_SortCriteria:
                    handler.string_value("SortCriteria");
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

    public static FlightSearchCriterionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSearchCriterionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSearchCriterion", ignore_extras);
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
    public static FlightSearchCriterionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSearchCriterionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSearchCriterionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSearchCriterion", ignore_extras);
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
    public static FlightSearchCriterionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSearchCriterionJSON from_text(string text, bool ignore_extras)
      {
        FlightSearchCriterionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSearchCriterion", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightSearchCriterionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightSearchCriterionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightSearchCriterionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSearchCriterion", ignore_extras);
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
            FlightSearchCriterionJSON result = new FlightSearchCriterionJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(FlightSearchCriterionJSON new_result);
        public Generator(bool ignore_extras) : base("Type FlightSearchCriterion")
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
        protected override void handle_result(FlightSearchCriterionJSON  result)
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
        public FlightSearchCriterionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightSearchCriterionJSON  result)
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
    protected virtual void handle_result(List<FlightSearchCriterionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightSearchCriterionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightSearchCriterionJSON>();
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
    public List<FlightSearchCriterionJSON> value;
  };
  };
