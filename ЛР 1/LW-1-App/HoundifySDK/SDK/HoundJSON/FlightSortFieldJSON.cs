/* file "FlightSortFieldJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightSortFieldJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_Price,
        Value_TravelDuration,
        Value_TotalLayoverDuration,
        Value_OutboundDepartureDate,
        Value_OutboundDepartureTime,
        Value_OutboundArrivalDate,
        Value_OutboundArrivalTime,
        Value_OutboundDepartureAirport,
        Value_OutboundDestinationAirport,
        Value_ReturnDepartureDate,
        Value_ReturnDepartureTime,
        Value_ReturnArrivalDate,
        Value_ReturnArrivalTime,
        Value_ReturnDepartureAirport,
        Value_ReturnDestinationAirport,
        Value_CabinClass,
        Value_Airline,
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
                if ((String.Compare(chars, 1, "irline", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeValueKnownValues.Value_Airline;
                break;
            case 'C':
                if ((String.Compare(chars, 1, "abinClass", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeValueKnownValues.Value_CabinClass;
                break;
            case 'O':
                if (String.Compare(chars, 1, "utbound", 0, 7, false) == 0)
                  {
                    switch (chars[8])
                      {
                        case 'A':
                            if (String.Compare(chars, 9, "rrival", 0, 6, false) == 0)
                              {
                                switch (chars[15])
                                  {
                                    case 'D':
                                        if ((String.Compare(chars, 16, "ate", 0, 3, false) == 0) && (chars.Length == 19))
                                            return TypeValueKnownValues.Value_OutboundArrivalDate;
                                        break;
                                    case 'T':
                                        if ((String.Compare(chars, 16, "ime", 0, 3, false) == 0) && (chars.Length == 19))
                                            return TypeValueKnownValues.Value_OutboundArrivalTime;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'D':
                            if (String.Compare(chars, 9, "e", 0, 1, false) == 0)
                              {
                                switch (chars[10])
                                  {
                                    case 'p':
                                        if (String.Compare(chars, 11, "arture", 0, 6, false) == 0)
                                          {
                                            switch (chars[17])
                                              {
                                                case 'A':
                                                    if ((String.Compare(chars, 18, "irport", 0, 6, false) == 0) && (chars.Length == 24))
                                                        return TypeValueKnownValues.Value_OutboundDepartureAirport;
                                                    break;
                                                case 'D':
                                                    if ((String.Compare(chars, 18, "ate", 0, 3, false) == 0) && (chars.Length == 21))
                                                        return TypeValueKnownValues.Value_OutboundDepartureDate;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(chars, 18, "ime", 0, 3, false) == 0) && (chars.Length == 21))
                                                        return TypeValueKnownValues.Value_OutboundDepartureTime;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 's':
                                        if ((String.Compare(chars, 11, "tinationAirport", 0, 15, false) == 0) && (chars.Length == 26))
                                            return TypeValueKnownValues.Value_OutboundDestinationAirport;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if ((String.Compare(chars, 1, "rice", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeValueKnownValues.Value_Price;
                break;
            case 'R':
                if (String.Compare(chars, 1, "eturn", 0, 5, false) == 0)
                  {
                    switch (chars[6])
                      {
                        case 'A':
                            if (String.Compare(chars, 7, "rrival", 0, 6, false) == 0)
                              {
                                switch (chars[13])
                                  {
                                    case 'D':
                                        if ((String.Compare(chars, 14, "ate", 0, 3, false) == 0) && (chars.Length == 17))
                                            return TypeValueKnownValues.Value_ReturnArrivalDate;
                                        break;
                                    case 'T':
                                        if ((String.Compare(chars, 14, "ime", 0, 3, false) == 0) && (chars.Length == 17))
                                            return TypeValueKnownValues.Value_ReturnArrivalTime;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'D':
                            if (String.Compare(chars, 7, "e", 0, 1, false) == 0)
                              {
                                switch (chars[8])
                                  {
                                    case 'p':
                                        if (String.Compare(chars, 9, "arture", 0, 6, false) == 0)
                                          {
                                            switch (chars[15])
                                              {
                                                case 'A':
                                                    if ((String.Compare(chars, 16, "irport", 0, 6, false) == 0) && (chars.Length == 22))
                                                        return TypeValueKnownValues.Value_ReturnDepartureAirport;
                                                    break;
                                                case 'D':
                                                    if ((String.Compare(chars, 16, "ate", 0, 3, false) == 0) && (chars.Length == 19))
                                                        return TypeValueKnownValues.Value_ReturnDepartureDate;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(chars, 16, "ime", 0, 3, false) == 0) && (chars.Length == 19))
                                                        return TypeValueKnownValues.Value_ReturnDepartureTime;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 's':
                                        if ((String.Compare(chars, 9, "tinationAirport", 0, 15, false) == 0) && (chars.Length == 24))
                                            return TypeValueKnownValues.Value_ReturnDestinationAirport;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'T':
                switch (chars[1])
                  {
                    case 'o':
                        if ((String.Compare(chars, 2, "talLayoverDuration", 0, 18, false) == 0) && (chars.Length == 20))
                            return TypeValueKnownValues.Value_TotalLayoverDuration;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "avelDuration", 0, 12, false) == 0) && (chars.Length == 14))
                            return TypeValueKnownValues.Value_TravelDuration;
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
            case TypeValueKnownValues.Value_Price:
                return "Price";
            case TypeValueKnownValues.Value_TravelDuration:
                return "TravelDuration";
            case TypeValueKnownValues.Value_TotalLayoverDuration:
                return "TotalLayoverDuration";
            case TypeValueKnownValues.Value_OutboundDepartureDate:
                return "OutboundDepartureDate";
            case TypeValueKnownValues.Value_OutboundDepartureTime:
                return "OutboundDepartureTime";
            case TypeValueKnownValues.Value_OutboundArrivalDate:
                return "OutboundArrivalDate";
            case TypeValueKnownValues.Value_OutboundArrivalTime:
                return "OutboundArrivalTime";
            case TypeValueKnownValues.Value_OutboundDepartureAirport:
                return "OutboundDepartureAirport";
            case TypeValueKnownValues.Value_OutboundDestinationAirport:
                return "OutboundDestinationAirport";
            case TypeValueKnownValues.Value_ReturnDepartureDate:
                return "ReturnDepartureDate";
            case TypeValueKnownValues.Value_ReturnDepartureTime:
                return "ReturnDepartureTime";
            case TypeValueKnownValues.Value_ReturnArrivalDate:
                return "ReturnArrivalDate";
            case TypeValueKnownValues.Value_ReturnArrivalTime:
                return "ReturnArrivalTime";
            case TypeValueKnownValues.Value_ReturnDepartureAirport:
                return "ReturnDepartureAirport";
            case TypeValueKnownValues.Value_ReturnDestinationAirport:
                return "ReturnDestinationAirport";
            case TypeValueKnownValues.Value_CabinClass:
                return "CabinClass";
            case TypeValueKnownValues.Value_Airline:
                return "Airline";
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
            throw new Exception("The value for field Value of FlightSortFieldJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "irline", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Airline;
                        goto open_enum_is_done;
                      }
                break;
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "abinClass", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_CabinClass;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if (String.Compare(json_string.getData(), 1, "utbound", 0, 7, false) == 0)
                  {
                    switch (json_string.getData()[8])
                      {
                        case 'A':
                            if (String.Compare(json_string.getData(), 9, "rrival", 0, 6, false) == 0)
                              {
                                switch (json_string.getData()[15])
                                  {
                                    case 'D':
                                        if ((String.Compare(json_string.getData(), 16, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 19))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_OutboundArrivalDate;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'T':
                                        if ((String.Compare(json_string.getData(), 16, "ime", 0, 3, false) == 0) && (json_string.getData().Length == 19))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_OutboundArrivalTime;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'D':
                            if (String.Compare(json_string.getData(), 9, "e", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[10])
                                  {
                                    case 'p':
                                        if (String.Compare(json_string.getData(), 11, "arture", 0, 6, false) == 0)
                                          {
                                            switch (json_string.getData()[17])
                                              {
                                                case 'A':
                                                    if ((String.Compare(json_string.getData(), 18, "irport", 0, 6, false) == 0) && (json_string.getData().Length == 24))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_OutboundDepartureAirport;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'D':
                                                    if ((String.Compare(json_string.getData(), 18, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 21))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_OutboundDepartureDate;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(json_string.getData(), 18, "ime", 0, 3, false) == 0) && (json_string.getData().Length == 21))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_OutboundDepartureTime;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 's':
                                        if ((String.Compare(json_string.getData(), 11, "tinationAirport", 0, 15, false) == 0) && (json_string.getData().Length == 26))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_OutboundDestinationAirport;
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
                  }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "rice", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_Price;
                        goto open_enum_is_done;
                      }
                break;
            case 'R':
                if (String.Compare(json_string.getData(), 1, "eturn", 0, 5, false) == 0)
                  {
                    switch (json_string.getData()[6])
                      {
                        case 'A':
                            if (String.Compare(json_string.getData(), 7, "rrival", 0, 6, false) == 0)
                              {
                                switch (json_string.getData()[13])
                                  {
                                    case 'D':
                                        if ((String.Compare(json_string.getData(), 14, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 17))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_ReturnArrivalDate;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'T':
                                        if ((String.Compare(json_string.getData(), 14, "ime", 0, 3, false) == 0) && (json_string.getData().Length == 17))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_ReturnArrivalTime;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'D':
                            if (String.Compare(json_string.getData(), 7, "e", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[8])
                                  {
                                    case 'p':
                                        if (String.Compare(json_string.getData(), 9, "arture", 0, 6, false) == 0)
                                          {
                                            switch (json_string.getData()[15])
                                              {
                                                case 'A':
                                                    if ((String.Compare(json_string.getData(), 16, "irport", 0, 6, false) == 0) && (json_string.getData().Length == 22))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_ReturnDepartureAirport;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'D':
                                                    if ((String.Compare(json_string.getData(), 16, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 19))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_ReturnDepartureDate;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(json_string.getData(), 16, "ime", 0, 3, false) == 0) && (json_string.getData().Length == 19))
                                                          {
                                                            the_open_enum.in_known_list = true;
                                                            the_open_enum.list_value = TypeValueKnownValues.Value_ReturnDepartureTime;
                                                            goto open_enum_is_done;
                                                          }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 's':
                                        if ((String.Compare(json_string.getData(), 9, "tinationAirport", 0, 15, false) == 0) && (json_string.getData().Length == 24))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_ReturnDestinationAirport;
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
                  }
                break;
            case 'T':
                switch (json_string.getData()[1])
                  {
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "talLayoverDuration", 0, 18, false) == 0) && (json_string.getData().Length == 20))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_TotalLayoverDuration;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "avelDuration", 0, 12, false) == 0) && (json_string.getData().Length == 14))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeValueKnownValues.Value_TravelDuration;
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


    public FlightSortFieldJSON()
      {
        flagHasValue = false;
      }

    public FlightSortFieldJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public FlightSortFieldJSON(string init_value)
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

    public FlightSortFieldJSON(TypeValueKnownValues init_value)
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
                case TypeValueKnownValues.Value_Price:
                    handler.string_value("Price");
                    break;
                case TypeValueKnownValues.Value_TravelDuration:
                    handler.string_value("TravelDuration");
                    break;
                case TypeValueKnownValues.Value_TotalLayoverDuration:
                    handler.string_value("TotalLayoverDuration");
                    break;
                case TypeValueKnownValues.Value_OutboundDepartureDate:
                    handler.string_value("OutboundDepartureDate");
                    break;
                case TypeValueKnownValues.Value_OutboundDepartureTime:
                    handler.string_value("OutboundDepartureTime");
                    break;
                case TypeValueKnownValues.Value_OutboundArrivalDate:
                    handler.string_value("OutboundArrivalDate");
                    break;
                case TypeValueKnownValues.Value_OutboundArrivalTime:
                    handler.string_value("OutboundArrivalTime");
                    break;
                case TypeValueKnownValues.Value_OutboundDepartureAirport:
                    handler.string_value("OutboundDepartureAirport");
                    break;
                case TypeValueKnownValues.Value_OutboundDestinationAirport:
                    handler.string_value("OutboundDestinationAirport");
                    break;
                case TypeValueKnownValues.Value_ReturnDepartureDate:
                    handler.string_value("ReturnDepartureDate");
                    break;
                case TypeValueKnownValues.Value_ReturnDepartureTime:
                    handler.string_value("ReturnDepartureTime");
                    break;
                case TypeValueKnownValues.Value_ReturnArrivalDate:
                    handler.string_value("ReturnArrivalDate");
                    break;
                case TypeValueKnownValues.Value_ReturnArrivalTime:
                    handler.string_value("ReturnArrivalTime");
                    break;
                case TypeValueKnownValues.Value_ReturnDepartureAirport:
                    handler.string_value("ReturnDepartureAirport");
                    break;
                case TypeValueKnownValues.Value_ReturnDestinationAirport:
                    handler.string_value("ReturnDestinationAirport");
                    break;
                case TypeValueKnownValues.Value_CabinClass:
                    handler.string_value("CabinClass");
                    break;
                case TypeValueKnownValues.Value_Airline:
                    handler.string_value("Airline");
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
                case TypeValueKnownValues.Value_Price:
                    handler.string_value("Price");
                    break;
                case TypeValueKnownValues.Value_TravelDuration:
                    handler.string_value("TravelDuration");
                    break;
                case TypeValueKnownValues.Value_TotalLayoverDuration:
                    handler.string_value("TotalLayoverDuration");
                    break;
                case TypeValueKnownValues.Value_OutboundDepartureDate:
                    handler.string_value("OutboundDepartureDate");
                    break;
                case TypeValueKnownValues.Value_OutboundDepartureTime:
                    handler.string_value("OutboundDepartureTime");
                    break;
                case TypeValueKnownValues.Value_OutboundArrivalDate:
                    handler.string_value("OutboundArrivalDate");
                    break;
                case TypeValueKnownValues.Value_OutboundArrivalTime:
                    handler.string_value("OutboundArrivalTime");
                    break;
                case TypeValueKnownValues.Value_OutboundDepartureAirport:
                    handler.string_value("OutboundDepartureAirport");
                    break;
                case TypeValueKnownValues.Value_OutboundDestinationAirport:
                    handler.string_value("OutboundDestinationAirport");
                    break;
                case TypeValueKnownValues.Value_ReturnDepartureDate:
                    handler.string_value("ReturnDepartureDate");
                    break;
                case TypeValueKnownValues.Value_ReturnDepartureTime:
                    handler.string_value("ReturnDepartureTime");
                    break;
                case TypeValueKnownValues.Value_ReturnArrivalDate:
                    handler.string_value("ReturnArrivalDate");
                    break;
                case TypeValueKnownValues.Value_ReturnArrivalTime:
                    handler.string_value("ReturnArrivalTime");
                    break;
                case TypeValueKnownValues.Value_ReturnDepartureAirport:
                    handler.string_value("ReturnDepartureAirport");
                    break;
                case TypeValueKnownValues.Value_ReturnDestinationAirport:
                    handler.string_value("ReturnDestinationAirport");
                    break;
                case TypeValueKnownValues.Value_CabinClass:
                    handler.string_value("CabinClass");
                    break;
                case TypeValueKnownValues.Value_Airline:
                    handler.string_value("Airline");
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

    public static FlightSortFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSortFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSortField", ignore_extras);
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
    public static FlightSortFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSortFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSortFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSortField", ignore_extras);
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
    public static FlightSortFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSortFieldJSON from_text(string text, bool ignore_extras)
      {
        FlightSortFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSortField", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightSortFieldJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightSortFieldJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightSortFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSortField", ignore_extras);
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
            FlightSortFieldJSON result = new FlightSortFieldJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(FlightSortFieldJSON new_result);
        public Generator(bool ignore_extras) : base("Type FlightSortField")
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
        protected override void handle_result(FlightSortFieldJSON  result)
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
        public FlightSortFieldJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightSortFieldJSON  result)
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
    protected virtual void handle_result(List<FlightSortFieldJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightSortFieldJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightSortFieldJSON>();
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
    public List<FlightSortFieldJSON> value;
  };
  };
