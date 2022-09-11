/* file "FlightStatusJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FlightStatusJSON : JSONBase
  {
    public enum TypeFlightTravelState
      {
        FlightTravelState_Scheduled,
        FlightTravelState_Canceled,
        FlightTravelState_Diverted,
        FlightTravelState_Enroute,
        FlightTravelState_Arrived,
        FlightTravelState_Unknown
      };

    public static TypeFlightTravelState  stringToFlightTravelState(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "rrived", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeFlightTravelState.FlightTravelState_Arrived;
                break;
            case 'C':
                if ((String.Compare(chars, 1, "anceled", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeFlightTravelState.FlightTravelState_Canceled;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "iverted", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeFlightTravelState.FlightTravelState_Diverted;
                break;
            case 'E':
                if ((String.Compare(chars, 1, "nroute", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeFlightTravelState.FlightTravelState_Enroute;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "cheduled", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeFlightTravelState.FlightTravelState_Scheduled;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeFlightTravelState.FlightTravelState_Unknown;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `FlightTravelState' is not one of the legal values.");
      }

    public static string  stringFromFlightTravelState(TypeFlightTravelState the_enum)
      {
        switch (the_enum)
          {
            case TypeFlightTravelState.FlightTravelState_Scheduled:
                return "Scheduled";
            case TypeFlightTravelState.FlightTravelState_Canceled:
                return "Canceled";
            case TypeFlightTravelState.FlightTravelState_Diverted:
                return "Diverted";
            case TypeFlightTravelState.FlightTravelState_Enroute:
                return "Enroute";
            case TypeFlightTravelState.FlightTravelState_Arrived:
                return "Arrived";
            case TypeFlightTravelState.FlightTravelState_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFlightId;
    private string storeFlightId;
    private bool flagHasLabel;
    private string storeLabel;
    private bool flagHasSpokenLabel;
    private string storeSpokenLabel;
    private bool flagHasAirlineFlightNumber;
    private AirlineFlightNumberJSON  storeAirlineFlightNumber;
    private bool flagHasCodeshares;
    private List< FlightCodeshareJSON  > storeCodeshares;
    private bool flagHasMatchingCodeshareIndex;
    private BigInteger storeMatchingCodeshareIndex;
    private bool flagHasFlightTravelState;
    private TypeFlightTravelState storeFlightTravelState;
    private bool flagHasStatusSummary;
    private string storeStatusSummary;
    private bool flagHasStatusSummaryShort;
    private string storeStatusSummaryShort;
    private bool flagHasDepartureArrivalText;
    private string storeDepartureArrivalText;
    private bool flagHasTailNumber;
    private string storeTailNumber;
    private bool flagHasAircraft;
    private AircraftJSON  storeAircraft;
    private bool flagHasBoarding;
    private FlightStatusBoardingInfoJSON  storeBoarding;
    private bool flagHasDeparture;
    private DepartureArrivalInfoJSON  storeDeparture;
    private bool flagHasArrival;
    private DepartureArrivalInfoJSON  storeArrival;
    private bool flagHasScheduledFlightDuration;
    private TimeDifferenceJSON  storeScheduledFlightDuration;
    private bool flagHasOperationalFlightDuration;
    private TimeDifferenceJSON  storeOperationalFlightDuration;
    private bool flagHasDeviationInFlightDurationFromScheduled;
    private TimeDifferenceJSON  storeDeviationInFlightDurationFromScheduled;
    private bool flagHasWrittenHints;
    private List< string > storeWrittenHints;
    private bool flagHasSpokenHints;
    private List< string > storeSpokenHints;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFlightId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FlightId of FlightStatusJSON is not a string.");
        setFlightId(json_string.getData());
      }


    private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Label of FlightStatusJSON is not a string.");
        setLabel(json_string.getData());
      }


    private void  fromJSONSpokenLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenLabel of FlightStatusJSON is not a string.");
        setSpokenLabel(json_string.getData());
      }


    private void  fromJSONAirlineFlightNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AirlineFlightNumberJSON convert_classy = AirlineFlightNumberJSON.from_json(json_value, ignore_extras, true);
        setAirlineFlightNumber(convert_classy);
      }


    private void  fromJSONCodeshares(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Codeshares of FlightStatusJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< FlightCodeshareJSON  > vector_Codeshares1 = new List< FlightCodeshareJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightCodeshareJSON convert_classy = FlightCodeshareJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Codeshares1.Add(convert_classy);
          }
        initCodeshares();
        for (int num1 = 0; num1 < vector_Codeshares1.Count; ++num1)
            appendCodeshares(vector_Codeshares1[num1]);
        for (int num1 = 0; num1 < vector_Codeshares1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMatchingCodeshareIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MatchingCodeshareIndex of FlightStatusJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MatchingCodeshareIndex of FlightStatusJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMatchingCodeshareIndex(extracted_integer);
      }


    private void  fromJSONFlightTravelState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FlightTravelState of FlightStatusJSON is not a string.");
        TypeFlightTravelState the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "rrived", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeFlightTravelState.FlightTravelState_Arrived;
                        goto enum_is_done;
                      }
                break;
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "anceled", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeFlightTravelState.FlightTravelState_Canceled;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "iverted", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeFlightTravelState.FlightTravelState_Diverted;
                        goto enum_is_done;
                      }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "nroute", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeFlightTravelState.FlightTravelState_Enroute;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "cheduled", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeFlightTravelState.FlightTravelState_Scheduled;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeFlightTravelState.FlightTravelState_Unknown;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field FlightTravelState of FlightStatusJSON is not one of the legal strings.");
      enum_is_done:;
        setFlightTravelState(the_enum);
      }


    private void  fromJSONStatusSummary(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StatusSummary of FlightStatusJSON is not a string.");
        setStatusSummary(json_string.getData());
      }


    private void  fromJSONStatusSummaryShort(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StatusSummaryShort of FlightStatusJSON is not a string.");
        setStatusSummaryShort(json_string.getData());
      }


    private void  fromJSONDepartureArrivalText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DepartureArrivalText of FlightStatusJSON is not a string.");
        setDepartureArrivalText(json_string.getData());
      }


    private void  fromJSONTailNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TailNumber of FlightStatusJSON is not a string.");
        setTailNumber(json_string.getData());
      }


    private void  fromJSONAircraft(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AircraftJSON convert_classy = AircraftJSON.from_json(json_value, ignore_extras, true);
        setAircraft(convert_classy);
      }


    private void  fromJSONBoarding(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatusBoardingInfoJSON convert_classy = FlightStatusBoardingInfoJSON.from_json(json_value, ignore_extras, true);
        setBoarding(convert_classy);
      }


    private void  fromJSONDeparture(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DepartureArrivalInfoJSON convert_classy = DepartureArrivalInfoJSON.from_json(json_value, ignore_extras, true);
        setDeparture(convert_classy);
      }


    private void  fromJSONArrival(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DepartureArrivalInfoJSON convert_classy = DepartureArrivalInfoJSON.from_json(json_value, ignore_extras, true);
        setArrival(convert_classy);
      }


    private void  fromJSONScheduledFlightDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeDifferenceJSON convert_classy = TimeDifferenceJSON.from_json(json_value, ignore_extras, true);
        setScheduledFlightDuration(convert_classy);
      }


    private void  fromJSONOperationalFlightDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeDifferenceJSON convert_classy = TimeDifferenceJSON.from_json(json_value, ignore_extras, true);
        setOperationalFlightDuration(convert_classy);
      }


    private void  fromJSONDeviationInFlightDurationFromScheduled(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeDifferenceJSON convert_classy = TimeDifferenceJSON.from_json(json_value, ignore_extras, true);
        setDeviationInFlightDurationFromScheduled(convert_classy);
      }


    private void  fromJSONWrittenHints(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field WrittenHints of FlightStatusJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_WrittenHints1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field WrittenHints of FlightStatusJSON is not a string.");
            vector_WrittenHints1.Add(json_string.getData());
          }
        initWrittenHints();
        for (int num2 = 0; num2 < vector_WrittenHints1.Count; ++num2)
            appendWrittenHints(vector_WrittenHints1[num2]);
        for (int num1 = 0; num1 < vector_WrittenHints1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpokenHints(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SpokenHints of FlightStatusJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_SpokenHints1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SpokenHints of FlightStatusJSON is not a string.");
            vector_SpokenHints1.Add(json_string.getData());
          }
        initSpokenHints();
        for (int num3 = 0; num3 < vector_SpokenHints1.Count; ++num3)
            appendSpokenHints(vector_SpokenHints1[num3]);
        for (int num1 = 0; num1 < vector_SpokenHints1.Count; ++num1)
          {
          }
      }


    public FlightStatusJSON()
      {
        flagHasFlightId = false;
        flagHasLabel = false;
        flagHasSpokenLabel = false;
        flagHasAirlineFlightNumber = false;
        flagHasCodeshares = false;
        flagHasMatchingCodeshareIndex = false;
        flagHasFlightTravelState = false;
        flagHasStatusSummary = false;
        flagHasStatusSummaryShort = false;
        flagHasDepartureArrivalText = false;
        flagHasTailNumber = false;
        flagHasAircraft = false;
        flagHasBoarding = false;
        flagHasDeparture = false;
        flagHasArrival = false;
        flagHasScheduledFlightDuration = false;
        flagHasOperationalFlightDuration = false;
        flagHasDeviationInFlightDurationFromScheduled = false;
        flagHasWrittenHints = false;
        flagHasSpokenHints = false;
        storeCodeshares = new List< FlightCodeshareJSON  >();
        storeWrittenHints = new List< string >();
        storeSpokenHints = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFlightId()
      {
        return flagHasFlightId;
      }

    public string  getFlightId()
      {
        Debug.Assert(flagHasFlightId);
        return storeFlightId;
      }

    public bool  hasLabel()
      {
        return flagHasLabel;
      }

    public string  getLabel()
      {
        Debug.Assert(flagHasLabel);
        return storeLabel;
      }

    public bool  hasSpokenLabel()
      {
        return flagHasSpokenLabel;
      }

    public string  getSpokenLabel()
      {
        Debug.Assert(flagHasSpokenLabel);
        return storeSpokenLabel;
      }

    public bool  hasAirlineFlightNumber()
      {
        return flagHasAirlineFlightNumber;
      }

    public AirlineFlightNumberJSON   getAirlineFlightNumber()
      {
        Debug.Assert(flagHasAirlineFlightNumber);
        return storeAirlineFlightNumber;
      }

    public bool  hasCodeshares()
      {
        return flagHasCodeshares;
      }

    public int  countOfCodeshares()
      {
        Debug.Assert(flagHasCodeshares);
        return storeCodeshares.Count;
      }

    public FlightCodeshareJSON   elementOfCodeshares(int element_num)
      {
        Debug.Assert(flagHasCodeshares);
        return storeCodeshares[element_num];
      }

    public List< FlightCodeshareJSON  >  getCodeshares()
      {
        Debug.Assert(flagHasCodeshares);
        return storeCodeshares;
      }

    public bool  hasMatchingCodeshareIndex()
      {
        return flagHasMatchingCodeshareIndex;
      }

    public BigInteger  getMatchingCodeshareIndex()
      {
        Debug.Assert(flagHasMatchingCodeshareIndex);
        return storeMatchingCodeshareIndex;
      }

    public bool  hasFlightTravelState()
      {
        return flagHasFlightTravelState;
      }

    public TypeFlightTravelState  getFlightTravelState()
      {
        Debug.Assert(flagHasFlightTravelState);
        return storeFlightTravelState;
      }

    public string  getFlightTravelStateAsString()
      {
        return stringFromFlightTravelState(getFlightTravelState());
      }

    public bool  hasStatusSummary()
      {
        return flagHasStatusSummary;
      }

    public string  getStatusSummary()
      {
        Debug.Assert(flagHasStatusSummary);
        return storeStatusSummary;
      }

    public bool  hasStatusSummaryShort()
      {
        return flagHasStatusSummaryShort;
      }

    public string  getStatusSummaryShort()
      {
        Debug.Assert(flagHasStatusSummaryShort);
        return storeStatusSummaryShort;
      }

    public bool  hasDepartureArrivalText()
      {
        return flagHasDepartureArrivalText;
      }

    public string  getDepartureArrivalText()
      {
        Debug.Assert(flagHasDepartureArrivalText);
        return storeDepartureArrivalText;
      }

    public bool  hasTailNumber()
      {
        return flagHasTailNumber;
      }

    public string  getTailNumber()
      {
        Debug.Assert(flagHasTailNumber);
        return storeTailNumber;
      }

    public bool  hasAircraft()
      {
        return flagHasAircraft;
      }

    public AircraftJSON   getAircraft()
      {
        Debug.Assert(flagHasAircraft);
        return storeAircraft;
      }

    public bool  hasBoarding()
      {
        return flagHasBoarding;
      }

    public FlightStatusBoardingInfoJSON   getBoarding()
      {
        Debug.Assert(flagHasBoarding);
        return storeBoarding;
      }

    public bool  hasDeparture()
      {
        return flagHasDeparture;
      }

    public DepartureArrivalInfoJSON   getDeparture()
      {
        Debug.Assert(flagHasDeparture);
        return storeDeparture;
      }

    public bool  hasArrival()
      {
        return flagHasArrival;
      }

    public DepartureArrivalInfoJSON   getArrival()
      {
        Debug.Assert(flagHasArrival);
        return storeArrival;
      }

    public bool  hasScheduledFlightDuration()
      {
        return flagHasScheduledFlightDuration;
      }

    public TimeDifferenceJSON   getScheduledFlightDuration()
      {
        Debug.Assert(flagHasScheduledFlightDuration);
        return storeScheduledFlightDuration;
      }

    public bool  hasOperationalFlightDuration()
      {
        return flagHasOperationalFlightDuration;
      }

    public TimeDifferenceJSON   getOperationalFlightDuration()
      {
        Debug.Assert(flagHasOperationalFlightDuration);
        return storeOperationalFlightDuration;
      }

    public bool  hasDeviationInFlightDurationFromScheduled()
      {
        return flagHasDeviationInFlightDurationFromScheduled;
      }

    public TimeDifferenceJSON   getDeviationInFlightDurationFromScheduled()
      {
        Debug.Assert(flagHasDeviationInFlightDurationFromScheduled);
        return storeDeviationInFlightDurationFromScheduled;
      }

    public bool  hasWrittenHints()
      {
        return flagHasWrittenHints;
      }

    public int  countOfWrittenHints()
      {
        Debug.Assert(flagHasWrittenHints);
        return storeWrittenHints.Count;
      }

    public string  elementOfWrittenHints(int element_num)
      {
        Debug.Assert(flagHasWrittenHints);
        return storeWrittenHints[element_num];
      }

    public List< string >  getWrittenHints()
      {
        Debug.Assert(flagHasWrittenHints);
        return storeWrittenHints;
      }

    public bool  hasSpokenHints()
      {
        return flagHasSpokenHints;
      }

    public int  countOfSpokenHints()
      {
        Debug.Assert(flagHasSpokenHints);
        return storeSpokenHints.Count;
      }

    public string  elementOfSpokenHints(int element_num)
      {
        Debug.Assert(flagHasSpokenHints);
        return storeSpokenHints[element_num];
      }

    public List< string >  getSpokenHints()
      {
        Debug.Assert(flagHasSpokenHints);
        return storeSpokenHints;
      }


    public virtual int extraFlightStatusComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatusComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatusComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatusLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFlightId(string new_value)
      {
        flagHasFlightId = true;
        storeFlightId = new_value;
      }
    public void unsetFlightId()
      {
        flagHasFlightId = false;
      }
    public void setLabel(string new_value)
      {
        flagHasLabel = true;
        storeLabel = new_value;
      }
    public void unsetLabel()
      {
        flagHasLabel = false;
      }
    public void setSpokenLabel(string new_value)
      {
        flagHasSpokenLabel = true;
        storeSpokenLabel = new_value;
      }
    public void unsetSpokenLabel()
      {
        flagHasSpokenLabel = false;
      }
    public void setAirlineFlightNumber(AirlineFlightNumberJSON  new_value)
      {
        if (flagHasAirlineFlightNumber)
          {
          }
        flagHasAirlineFlightNumber = true;
        storeAirlineFlightNumber = new_value;
      }
    public void unsetAirlineFlightNumber()
      {
        if (flagHasAirlineFlightNumber)
          {
          }
        flagHasAirlineFlightNumber = false;
      }
    public void initCodeshares()
      {
        if (flagHasCodeshares)
          {
            for (int num1 = 0; num1 < storeCodeshares.Count; ++num1)
              {
              }
          }
        flagHasCodeshares = true;
        storeCodeshares.Clear();
      }
    public void appendCodeshares(FlightCodeshareJSON  to_append)
      {
        if (!flagHasCodeshares)
          {
            flagHasCodeshares = true;
            storeCodeshares.Clear();
          }
        Debug.Assert(flagHasCodeshares);
        storeCodeshares.Add(to_append);
      }
    public void unsetCodeshares()
      {
        if (flagHasCodeshares)
          {
            for (int num2 = 0; num2 < storeCodeshares.Count; ++num2)
              {
              }
          }
        flagHasCodeshares = false;
        storeCodeshares.Clear();
      }
    public void setMatchingCodeshareIndex(BigInteger new_value)
      {
        flagHasMatchingCodeshareIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field MatchingCodeshareIndex of FlightStatusJSON is less than the lower bound (0) for that field.");
        storeMatchingCodeshareIndex = new_value;
      }
    public void unsetMatchingCodeshareIndex()
      {
        flagHasMatchingCodeshareIndex = false;
      }
    public void setFlightTravelState(TypeFlightTravelState new_value)
      {
        flagHasFlightTravelState = true;
        storeFlightTravelState = new_value;
      }
    public void setFlightTravelState(string chars)
      {
        setFlightTravelState(stringToFlightTravelState(chars));
      }
    public void unsetFlightTravelState()
      {
        flagHasFlightTravelState = false;
      }
    public void setStatusSummary(string new_value)
      {
        flagHasStatusSummary = true;
        storeStatusSummary = new_value;
      }
    public void unsetStatusSummary()
      {
        flagHasStatusSummary = false;
      }
    public void setStatusSummaryShort(string new_value)
      {
        flagHasStatusSummaryShort = true;
        storeStatusSummaryShort = new_value;
      }
    public void unsetStatusSummaryShort()
      {
        flagHasStatusSummaryShort = false;
      }
    public void setDepartureArrivalText(string new_value)
      {
        flagHasDepartureArrivalText = true;
        storeDepartureArrivalText = new_value;
      }
    public void unsetDepartureArrivalText()
      {
        flagHasDepartureArrivalText = false;
      }
    public void setTailNumber(string new_value)
      {
        flagHasTailNumber = true;
        storeTailNumber = new_value;
      }
    public void unsetTailNumber()
      {
        flagHasTailNumber = false;
      }
    public void setAircraft(AircraftJSON  new_value)
      {
        if (flagHasAircraft)
          {
          }
        flagHasAircraft = true;
        storeAircraft = new_value;
      }
    public void unsetAircraft()
      {
        if (flagHasAircraft)
          {
          }
        flagHasAircraft = false;
      }
    public void setBoarding(FlightStatusBoardingInfoJSON  new_value)
      {
        if (flagHasBoarding)
          {
          }
        flagHasBoarding = true;
        storeBoarding = new_value;
      }
    public void unsetBoarding()
      {
        if (flagHasBoarding)
          {
          }
        flagHasBoarding = false;
      }
    public void setDeparture(DepartureArrivalInfoJSON  new_value)
      {
        if (flagHasDeparture)
          {
          }
        flagHasDeparture = true;
        storeDeparture = new_value;
      }
    public void unsetDeparture()
      {
        if (flagHasDeparture)
          {
          }
        flagHasDeparture = false;
      }
    public void setArrival(DepartureArrivalInfoJSON  new_value)
      {
        if (flagHasArrival)
          {
          }
        flagHasArrival = true;
        storeArrival = new_value;
      }
    public void unsetArrival()
      {
        if (flagHasArrival)
          {
          }
        flagHasArrival = false;
      }
    public void setScheduledFlightDuration(TimeDifferenceJSON  new_value)
      {
        if (flagHasScheduledFlightDuration)
          {
          }
        flagHasScheduledFlightDuration = true;
        storeScheduledFlightDuration = new_value;
      }
    public void unsetScheduledFlightDuration()
      {
        if (flagHasScheduledFlightDuration)
          {
          }
        flagHasScheduledFlightDuration = false;
      }
    public void setOperationalFlightDuration(TimeDifferenceJSON  new_value)
      {
        if (flagHasOperationalFlightDuration)
          {
          }
        flagHasOperationalFlightDuration = true;
        storeOperationalFlightDuration = new_value;
      }
    public void unsetOperationalFlightDuration()
      {
        if (flagHasOperationalFlightDuration)
          {
          }
        flagHasOperationalFlightDuration = false;
      }
    public void setDeviationInFlightDurationFromScheduled(TimeDifferenceJSON  new_value)
      {
        if (flagHasDeviationInFlightDurationFromScheduled)
          {
          }
        flagHasDeviationInFlightDurationFromScheduled = true;
        storeDeviationInFlightDurationFromScheduled = new_value;
      }
    public void unsetDeviationInFlightDurationFromScheduled()
      {
        if (flagHasDeviationInFlightDurationFromScheduled)
          {
          }
        flagHasDeviationInFlightDurationFromScheduled = false;
      }
    public void initWrittenHints()
      {
        flagHasWrittenHints = true;
        storeWrittenHints.Clear();
      }
    public void appendWrittenHints(string to_append)
      {
        if (!flagHasWrittenHints)
          {
            flagHasWrittenHints = true;
            storeWrittenHints.Clear();
          }
        Debug.Assert(flagHasWrittenHints);
        storeWrittenHints.Add(to_append);
      }
    public void unsetWrittenHints()
      {
        flagHasWrittenHints = false;
        storeWrittenHints.Clear();
      }
    public void initSpokenHints()
      {
        flagHasSpokenHints = true;
        storeSpokenHints.Clear();
      }
    public void appendSpokenHints(string to_append)
      {
        if (!flagHasSpokenHints)
          {
            flagHasSpokenHints = true;
            storeSpokenHints.Clear();
          }
        Debug.Assert(flagHasSpokenHints);
        storeSpokenHints.Add(to_append);
      }
    public void unsetSpokenHints()
      {
        flagHasSpokenHints = false;
        storeSpokenHints.Clear();
      }

    public virtual void extraFlightStatusAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatusSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatusLookup(key);
        if (old_field == null)
          {
            extraFlightStatusAppendPair(key, new_component);
          }
        else
          {
            int count = extraKeys.Count;
            Debug.Assert(count == extraValues.Count);
            for (int num = 0; num < count; ++num)
              {
                if (extraKeys[num].Equals( key))
                  {
                    extraValues[num] = new_component;
                    break;
                  }
              }
            extraIndex.Add(key, new_component);
          }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        int extra_count = extraKeys.Count;
        Debug.Assert(extra_count == extraValues.Count);
        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
          {
            handler.start_pair(extraKeys[extra_num]);
            extraValues[extra_num].write(handler);
          }
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasFlightId);
        if (flagHasFlightId)
          {
            handler.start_pair("FlightId");
            handler.string_value(storeFlightId);
          }
        Debug.Assert(partial_allowed || flagHasLabel);
        if (flagHasLabel)
          {
            handler.start_pair("Label");
            handler.string_value(storeLabel);
          }
        Debug.Assert(partial_allowed || flagHasSpokenLabel);
        if (flagHasSpokenLabel)
          {
            handler.start_pair("SpokenLabel");
            handler.string_value(storeSpokenLabel);
          }
        Debug.Assert(partial_allowed || flagHasAirlineFlightNumber);
        if (flagHasAirlineFlightNumber)
          {
            handler.start_pair("AirlineFlightNumber");
            if (partial_allowed)
                storeAirlineFlightNumber.write_partial_as_json(handler);
            else
                storeAirlineFlightNumber.write_as_json(handler);
          }
        if (flagHasCodeshares)
          {
            handler.start_pair("Codeshares");
            handler.start_array();
            for (int num1 = 0; num1 < storeCodeshares.Count; ++num1)
              {
                if (partial_allowed)
                    storeCodeshares[num1].write_partial_as_json(handler);
                else
                    storeCodeshares[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasMatchingCodeshareIndex)
          {
            handler.start_pair("MatchingCodeshareIndex");
            handler.number_value(storeMatchingCodeshareIndex);
          }
        Debug.Assert(partial_allowed || flagHasFlightTravelState);
        if (flagHasFlightTravelState)
          {
            handler.start_pair("FlightTravelState");
            switch (storeFlightTravelState)
              {
                case TypeFlightTravelState.FlightTravelState_Scheduled:
                    handler.string_value("Scheduled");
                    break;
                case TypeFlightTravelState.FlightTravelState_Canceled:
                    handler.string_value("Canceled");
                    break;
                case TypeFlightTravelState.FlightTravelState_Diverted:
                    handler.string_value("Diverted");
                    break;
                case TypeFlightTravelState.FlightTravelState_Enroute:
                    handler.string_value("Enroute");
                    break;
                case TypeFlightTravelState.FlightTravelState_Arrived:
                    handler.string_value("Arrived");
                    break;
                case TypeFlightTravelState.FlightTravelState_Unknown:
                    handler.string_value("Unknown");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasStatusSummary);
        if (flagHasStatusSummary)
          {
            handler.start_pair("StatusSummary");
            handler.string_value(storeStatusSummary);
          }
        Debug.Assert(partial_allowed || flagHasStatusSummaryShort);
        if (flagHasStatusSummaryShort)
          {
            handler.start_pair("StatusSummaryShort");
            handler.string_value(storeStatusSummaryShort);
          }
        Debug.Assert(partial_allowed || flagHasDepartureArrivalText);
        if (flagHasDepartureArrivalText)
          {
            handler.start_pair("DepartureArrivalText");
            handler.string_value(storeDepartureArrivalText);
          }
        if (flagHasTailNumber)
          {
            handler.start_pair("TailNumber");
            handler.string_value(storeTailNumber);
          }
        if (flagHasAircraft)
          {
            handler.start_pair("Aircraft");
            if (partial_allowed)
                storeAircraft.write_partial_as_json(handler);
            else
                storeAircraft.write_as_json(handler);
          }
        if (flagHasBoarding)
          {
            handler.start_pair("Boarding");
            if (partial_allowed)
                storeBoarding.write_partial_as_json(handler);
            else
                storeBoarding.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDeparture);
        if (flagHasDeparture)
          {
            handler.start_pair("Departure");
            if (partial_allowed)
                storeDeparture.write_partial_as_json(handler);
            else
                storeDeparture.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasArrival);
        if (flagHasArrival)
          {
            handler.start_pair("Arrival");
            if (partial_allowed)
                storeArrival.write_partial_as_json(handler);
            else
                storeArrival.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasScheduledFlightDuration);
        if (flagHasScheduledFlightDuration)
          {
            handler.start_pair("ScheduledFlightDuration");
            if (partial_allowed)
                storeScheduledFlightDuration.write_partial_as_json(handler);
            else
                storeScheduledFlightDuration.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasOperationalFlightDuration);
        if (flagHasOperationalFlightDuration)
          {
            handler.start_pair("OperationalFlightDuration");
            if (partial_allowed)
                storeOperationalFlightDuration.write_partial_as_json(handler);
            else
                storeOperationalFlightDuration.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDeviationInFlightDurationFromScheduled);
        if (flagHasDeviationInFlightDurationFromScheduled)
          {
            handler.start_pair("DeviationInFlightDurationFromScheduled");
            if (partial_allowed)
                storeDeviationInFlightDurationFromScheduled.write_partial_as_json(handler);
            else
                storeDeviationInFlightDurationFromScheduled.write_as_json(handler);
          }
        if (flagHasWrittenHints)
          {
            handler.start_pair("WrittenHints");
            handler.start_array();
            for (int num2 = 0; num2 < storeWrittenHints.Count; ++num2)
              {
                handler.string_value(storeWrittenHints[num2]);
              }
            handler.finish_array();
          }
        if (flagHasSpokenHints)
          {
            handler.start_pair("SpokenHints");
            handler.start_array();
            for (int num3 = 0; num3 < storeSpokenHints.Count; ++num3)
              {
                handler.string_value(storeSpokenHints[num3]);
              }
            handler.finish_array();
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        int extra_count = extraKeys.Count;
        Debug.Assert(extra_count == extraValues.Count);
        for (int extra_num = 0; extra_num < extra_count; ++extra_num)
          {
            handler.start_pair(extraKeys[extra_num]);
            extraValues[extra_num].write(handler);
          }
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasFlightId()))
          {
            return "When parsing the object for %what%, the \"FlightId\" field was missing.";
          }
        if (!(hasLabel()))
          {
            return "When parsing the object for %what%, the \"Label\" field was missing.";
          }
        if (!(hasSpokenLabel()))
          {
            return "When parsing the object for %what%, the \"SpokenLabel\" field was missing.";
          }
        if (!(hasAirlineFlightNumber()))
          {
            return "When parsing the object for %what%, the \"AirlineFlightNumber\" field was missing.";
          }
        if (!(hasFlightTravelState()))
          {
            return "When parsing the object for %what%, the \"FlightTravelState\" field was missing.";
          }
        if (!(hasStatusSummary()))
          {
            return "When parsing the object for %what%, the \"StatusSummary\" field was missing.";
          }
        if (!(hasStatusSummaryShort()))
          {
            return "When parsing the object for %what%, the \"StatusSummaryShort\" field was missing.";
          }
        if (!(hasDepartureArrivalText()))
          {
            return "When parsing the object for %what%, the \"DepartureArrivalText\" field was missing.";
          }
        if (!(hasDeparture()))
          {
            return "When parsing the object for %what%, the \"Departure\" field was missing.";
          }
        if (!(hasArrival()))
          {
            return "When parsing the object for %what%, the \"Arrival\" field was missing.";
          }
        if (!(hasScheduledFlightDuration()))
          {
            return "When parsing the object for %what%, the \"ScheduledFlightDuration\" field was missing.";
          }
        if (!(hasOperationalFlightDuration()))
          {
            return "When parsing the object for %what%, the \"OperationalFlightDuration\" field was missing.";
          }
        if (!(hasDeviationInFlightDurationFromScheduled()))
          {
            return "When parsing the object for %what%, the \"DeviationInFlightDurationFromScheduled\" field was missing.";
          }
        return null;
      }

    public static FlightStatusJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatus", ignore_extras);
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
    public static FlightStatusJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatusJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatus", ignore_extras);
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
    public static FlightStatusJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatusJSON from_text(string text, bool ignore_extras)
      {
        FlightStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatus", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatusJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightStatusJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatus", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorFlightId;
        private JSONHoldingStringGenerator fieldGeneratorLabel;
        private JSONHoldingStringGenerator fieldGeneratorSpokenLabel;
        private AirlineFlightNumberJSON.HoldingGenerator fieldGeneratorAirlineFlightNumber;
        private FlightCodeshareJSON.HoldingArrayGenerator fieldGeneratorCodeshares;
    private class FieldHoldingGeneratorMatchingCodeshareIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorMatchingCodeshareIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorMatchingCodeshareIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorMatchingCodeshareIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorMatchingCodeshareIndex fieldGeneratorMatchingCodeshareIndex;
    private abstract class FieldGeneratorFlightTravelState : JSONStringGenerator
          {
            protected FieldGeneratorFlightTravelState(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFlightTravelState()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToFlightTravelState(result));
              }
            protected abstract void handle_result(TypeFlightTravelState result);
          };
    private class FieldHoldingGeneratorFlightTravelState : FieldGeneratorFlightTravelState
  {
    protected override void handle_result(TypeFlightTravelState result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFlightTravelState(String what)
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
    public TypeFlightTravelState value;
  };
    private class FieldHoldingArrayGeneratorFlightTravelState : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFlightTravelState
      {
        private FieldHoldingArrayGeneratorFlightTravelState top;

        protected override void handle_result(TypeFlightTravelState result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFlightTravelState init_top)
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
    protected virtual void handle_result(List<TypeFlightTravelState> result)
      {
      }

    public FieldHoldingArrayGeneratorFlightTravelState(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFlightTravelState>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFlightTravelState()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFlightTravelState>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFlightTravelState> value;
  };
        private FieldHoldingGeneratorFlightTravelState fieldGeneratorFlightTravelState;
        private JSONHoldingStringGenerator fieldGeneratorStatusSummary;
        private JSONHoldingStringGenerator fieldGeneratorStatusSummaryShort;
        private JSONHoldingStringGenerator fieldGeneratorDepartureArrivalText;
        private JSONHoldingStringGenerator fieldGeneratorTailNumber;
        private AircraftJSON.HoldingGenerator fieldGeneratorAircraft;
        private FlightStatusBoardingInfoJSON.HoldingGenerator fieldGeneratorBoarding;
        private DepartureArrivalInfoJSON.HoldingGenerator fieldGeneratorDeparture;
        private DepartureArrivalInfoJSON.HoldingGenerator fieldGeneratorArrival;
        private TimeDifferenceJSON.HoldingGenerator fieldGeneratorScheduledFlightDuration;
        private TimeDifferenceJSON.HoldingGenerator fieldGeneratorOperationalFlightDuration;
        private TimeDifferenceJSON.HoldingGenerator fieldGeneratorDeviationInFlightDurationFromScheduled;
        private JSONHoldingStringArrayGenerator fieldGeneratorWrittenHints;
        private JSONHoldingStringArrayGenerator fieldGeneratorSpokenHints;
        private class UnknownFieldGenerator : JSONValueHandler
          {
            public bool ignore;
            public List<string> field_names;
            public List<JSONValue > field_values;
            public Dictionary<string, JSONValue > index;
            public UnknownFieldGenerator(bool init_ignore)
              {
                ignore = init_ignore;
                field_names = new List<string>();
                field_values = new List<JSONValue >();
            index = new Dictionary<string, JSONValue >();
              }

            protected override void new_value(JSONValue item)
              {
                if (ignore)
                    return;
                Debug.Assert(field_names.Count == (field_values.Count + 1));
                index.Add(field_names[field_values.Count], item);
                field_values.Add(item);
              }
            public override void reset()
              {
                field_names.Clear();
                field_values.Clear();
            index = new Dictionary<string, JSONValue >();
              }
          };
        private UnknownFieldGenerator unknownFieldGenerator;

        protected bool allow_incomplete;

        protected bool allow_unpolished;

        protected override void start()
          {
          }
        protected override JSONHandler start_field(string field_name)
          {
            JSONHandler result = start_known_field(field_name);
            if (result != null)
                return result;
            Debug.Assert(unknownFieldGenerator.field_names.Count ==
                   unknownFieldGenerator.field_values.Count);
            if (unknownFieldGenerator.ignore)
              {
                Debug.Assert(unknownFieldGenerator.field_names.Count == 0);
              }
            else
              {
                unknownFieldGenerator.field_names.Add(field_name);
              }
            return unknownFieldGenerator;
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            FlightStatusJSON result = new FlightStatusJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatusAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightStatusJSON result)
          {
            if (fieldGeneratorFlightId.have_value)
              {
                result.setFlightId(fieldGeneratorFlightId.value);
                fieldGeneratorFlightId.have_value = false;
              }
            else if ((!(result.hasFlightId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightId\" field was missing.");
              }
            if (fieldGeneratorLabel.have_value)
              {
                result.setLabel(fieldGeneratorLabel.value);
                fieldGeneratorLabel.have_value = false;
              }
            else if ((!(result.hasLabel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Label\" field was missing.");
              }
            if (fieldGeneratorSpokenLabel.have_value)
              {
                result.setSpokenLabel(fieldGeneratorSpokenLabel.value);
                fieldGeneratorSpokenLabel.have_value = false;
              }
            else if ((!(result.hasSpokenLabel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenLabel\" field was missing.");
              }
            if (fieldGeneratorAirlineFlightNumber.have_value)
              {
                result.setAirlineFlightNumber(fieldGeneratorAirlineFlightNumber.value);
                fieldGeneratorAirlineFlightNumber.have_value = false;
              }
            else if ((!(result.hasAirlineFlightNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AirlineFlightNumber\" field was missing.");
              }
            if (fieldGeneratorCodeshares.have_value)
              {
                result.initCodeshares();
                int count = fieldGeneratorCodeshares.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCodeshares(fieldGeneratorCodeshares.value[num]);
                  }
                fieldGeneratorCodeshares.value.Clear();
                fieldGeneratorCodeshares.have_value = false;
              }
            if (fieldGeneratorMatchingCodeshareIndex.have_value)
              {
                result.setMatchingCodeshareIndex(fieldGeneratorMatchingCodeshareIndex.value);
                fieldGeneratorMatchingCodeshareIndex.have_value = false;
              }
            if (fieldGeneratorFlightTravelState.have_value)
              {
                result.setFlightTravelState(fieldGeneratorFlightTravelState.value);
                fieldGeneratorFlightTravelState.have_value = false;
              }
            else if ((!(result.hasFlightTravelState())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightTravelState\" field was missing.");
              }
            if (fieldGeneratorStatusSummary.have_value)
              {
                result.setStatusSummary(fieldGeneratorStatusSummary.value);
                fieldGeneratorStatusSummary.have_value = false;
              }
            else if ((!(result.hasStatusSummary())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StatusSummary\" field was missing.");
              }
            if (fieldGeneratorStatusSummaryShort.have_value)
              {
                result.setStatusSummaryShort(fieldGeneratorStatusSummaryShort.value);
                fieldGeneratorStatusSummaryShort.have_value = false;
              }
            else if ((!(result.hasStatusSummaryShort())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StatusSummaryShort\" field was missing.");
              }
            if (fieldGeneratorDepartureArrivalText.have_value)
              {
                result.setDepartureArrivalText(fieldGeneratorDepartureArrivalText.value);
                fieldGeneratorDepartureArrivalText.have_value = false;
              }
            else if ((!(result.hasDepartureArrivalText())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DepartureArrivalText\" field was missing.");
              }
            if (fieldGeneratorTailNumber.have_value)
              {
                result.setTailNumber(fieldGeneratorTailNumber.value);
                fieldGeneratorTailNumber.have_value = false;
              }
            if (fieldGeneratorAircraft.have_value)
              {
                result.setAircraft(fieldGeneratorAircraft.value);
                fieldGeneratorAircraft.have_value = false;
              }
            if (fieldGeneratorBoarding.have_value)
              {
                result.setBoarding(fieldGeneratorBoarding.value);
                fieldGeneratorBoarding.have_value = false;
              }
            if (fieldGeneratorDeparture.have_value)
              {
                result.setDeparture(fieldGeneratorDeparture.value);
                fieldGeneratorDeparture.have_value = false;
              }
            else if ((!(result.hasDeparture())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Departure\" field was missing.");
              }
            if (fieldGeneratorArrival.have_value)
              {
                result.setArrival(fieldGeneratorArrival.value);
                fieldGeneratorArrival.have_value = false;
              }
            else if ((!(result.hasArrival())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Arrival\" field was missing.");
              }
            if (fieldGeneratorScheduledFlightDuration.have_value)
              {
                result.setScheduledFlightDuration(fieldGeneratorScheduledFlightDuration.value);
                fieldGeneratorScheduledFlightDuration.have_value = false;
              }
            else if ((!(result.hasScheduledFlightDuration())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ScheduledFlightDuration\" field was missing.");
              }
            if (fieldGeneratorOperationalFlightDuration.have_value)
              {
                result.setOperationalFlightDuration(fieldGeneratorOperationalFlightDuration.value);
                fieldGeneratorOperationalFlightDuration.have_value = false;
              }
            else if ((!(result.hasOperationalFlightDuration())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OperationalFlightDuration\" field was missing.");
              }
            if (fieldGeneratorDeviationInFlightDurationFromScheduled.have_value)
              {
                result.setDeviationInFlightDurationFromScheduled(fieldGeneratorDeviationInFlightDurationFromScheduled.value);
                fieldGeneratorDeviationInFlightDurationFromScheduled.have_value = false;
              }
            else if ((!(result.hasDeviationInFlightDurationFromScheduled())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DeviationInFlightDurationFromScheduled\" field was missing.");
              }
            if (fieldGeneratorWrittenHints.have_value)
              {
                result.initWrittenHints();
                int count = fieldGeneratorWrittenHints.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendWrittenHints(fieldGeneratorWrittenHints.value[num]);
                  }
                fieldGeneratorWrittenHints.value.Clear();
                fieldGeneratorWrittenHints.have_value = false;
              }
            if (fieldGeneratorSpokenHints.have_value)
              {
                result.initSpokenHints();
                int count = fieldGeneratorSpokenHints.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSpokenHints(fieldGeneratorSpokenHints.value[num]);
                  }
                fieldGeneratorSpokenHints.value.Clear();
                fieldGeneratorSpokenHints.have_value = false;
              }
          }
        protected abstract void handle_result(FlightStatusJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'i':
                            if (String.Compare(field_name, 2, "r", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'c':
                                        if ((String.Compare(field_name, 4, "raft", 0, 4, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorAircraft;
                                        break;
                                    case 'l':
                                        if ((String.Compare(field_name, 4, "ineFlightNumber", 0, 15, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorAirlineFlightNumber;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "rival", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorArrival;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "oarding", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorBoarding;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "odeshares", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorCodeshares;
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'p':
                                if (String.Compare(field_name, 3, "arture", 0, 6, false) == 0)
                                  {
                                    if (field_name.Length == 9)
                                      {
                                        return fieldGeneratorDeparture;
                                      }
                                    switch (field_name[9])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 10, "rrivalText", 0, 10, false) == 0) && (field_name.Length == 20))
                                                return fieldGeneratorDepartureArrivalText;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'v':
                                if ((String.Compare(field_name, 3, "iationInFlightDurationFromScheduled", 0, 35, false) == 0) && (field_name.Length == 38))
                                    return fieldGeneratorDeviationInFlightDurationFromScheduled;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "light", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 7, "d", 0, 1, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorFlightId;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 7, "ravelState", 0, 10, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorFlightTravelState;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorLabel;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "atchingCodeshareIndex", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorMatchingCodeshareIndex;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "perationalFlightDuration", 0, 24, false) == 0) && (field_name.Length == 25))
                        return fieldGeneratorOperationalFlightDuration;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "heduledFlightDuration", 0, 21, false) == 0) && (field_name.Length == 23))
                                return fieldGeneratorScheduledFlightDuration;
                            break;
                        case 'p':
                            if (String.Compare(field_name, 2, "oken", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'H':
                                        if ((String.Compare(field_name, 7, "ints", 0, 4, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorSpokenHints;
                                        break;
                                    case 'L':
                                        if ((String.Compare(field_name, 7, "abel", 0, 4, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorSpokenLabel;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "atusSummary", 0, 11, false) == 0)
                              {
                                if (field_name.Length == 13)
                                  {
                                    return fieldGeneratorStatusSummary;
                                  }
                                switch (field_name[13])
                                  {
                                    case 'S':
                                        if ((String.Compare(field_name, 14, "hort", 0, 4, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorStatusSummaryShort;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ailNumber", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorTailNumber;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenHints", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorWrittenHints;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFlightId = new JSONHoldingStringGenerator("field \"FlightId\" of the FlightStatus class");
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the FlightStatus class");
            fieldGeneratorSpokenLabel = new JSONHoldingStringGenerator("field \"SpokenLabel\" of the FlightStatus class");
            fieldGeneratorAirlineFlightNumber = new AirlineFlightNumberJSON.HoldingGenerator("field \"AirlineFlightNumber\" of the FlightStatus class", ignore_extras);
            fieldGeneratorCodeshares = new FlightCodeshareJSON.HoldingArrayGenerator("field \"Codeshares\" of the FlightStatus class", ignore_extras);
            fieldGeneratorMatchingCodeshareIndex = new FieldHoldingGeneratorMatchingCodeshareIndex("field \"MatchingCodeshareIndex\" of the FlightStatus class");
            fieldGeneratorFlightTravelState = new FieldHoldingGeneratorFlightTravelState("field \"FlightTravelState\" of the FlightStatus class");
            fieldGeneratorStatusSummary = new JSONHoldingStringGenerator("field \"StatusSummary\" of the FlightStatus class");
            fieldGeneratorStatusSummaryShort = new JSONHoldingStringGenerator("field \"StatusSummaryShort\" of the FlightStatus class");
            fieldGeneratorDepartureArrivalText = new JSONHoldingStringGenerator("field \"DepartureArrivalText\" of the FlightStatus class");
            fieldGeneratorTailNumber = new JSONHoldingStringGenerator("field \"TailNumber\" of the FlightStatus class");
            fieldGeneratorAircraft = new AircraftJSON.HoldingGenerator("field \"Aircraft\" of the FlightStatus class", ignore_extras);
            fieldGeneratorBoarding = new FlightStatusBoardingInfoJSON.HoldingGenerator("field \"Boarding\" of the FlightStatus class", ignore_extras);
            fieldGeneratorDeparture = new DepartureArrivalInfoJSON.HoldingGenerator("field \"Departure\" of the FlightStatus class", ignore_extras);
            fieldGeneratorArrival = new DepartureArrivalInfoJSON.HoldingGenerator("field \"Arrival\" of the FlightStatus class", ignore_extras);
            fieldGeneratorScheduledFlightDuration = new TimeDifferenceJSON.HoldingGenerator("field \"ScheduledFlightDuration\" of the FlightStatus class", ignore_extras);
            fieldGeneratorOperationalFlightDuration = new TimeDifferenceJSON.HoldingGenerator("field \"OperationalFlightDuration\" of the FlightStatus class", ignore_extras);
            fieldGeneratorDeviationInFlightDurationFromScheduled = new TimeDifferenceJSON.HoldingGenerator("field \"DeviationInFlightDurationFromScheduled\" of the FlightStatus class", ignore_extras);
            fieldGeneratorWrittenHints = new JSONHoldingStringArrayGenerator("field \"WrittenHints\" of the FlightStatus class");
            fieldGeneratorSpokenHints = new JSONHoldingStringArrayGenerator("field \"SpokenHints\" of the FlightStatus class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatus class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFlightId = new JSONHoldingStringGenerator("field \"FlightId\" of the FlightStatus class");
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the FlightStatus class");
            fieldGeneratorSpokenLabel = new JSONHoldingStringGenerator("field \"SpokenLabel\" of the FlightStatus class");
            fieldGeneratorAirlineFlightNumber = new AirlineFlightNumberJSON.HoldingGenerator("field \"AirlineFlightNumber\" of the FlightStatus class", false);
            fieldGeneratorCodeshares = new FlightCodeshareJSON.HoldingArrayGenerator("field \"Codeshares\" of the FlightStatus class", false);
            fieldGeneratorMatchingCodeshareIndex = new FieldHoldingGeneratorMatchingCodeshareIndex("field \"MatchingCodeshareIndex\" of the FlightStatus class");
            fieldGeneratorFlightTravelState = new FieldHoldingGeneratorFlightTravelState("field \"FlightTravelState\" of the FlightStatus class");
            fieldGeneratorStatusSummary = new JSONHoldingStringGenerator("field \"StatusSummary\" of the FlightStatus class");
            fieldGeneratorStatusSummaryShort = new JSONHoldingStringGenerator("field \"StatusSummaryShort\" of the FlightStatus class");
            fieldGeneratorDepartureArrivalText = new JSONHoldingStringGenerator("field \"DepartureArrivalText\" of the FlightStatus class");
            fieldGeneratorTailNumber = new JSONHoldingStringGenerator("field \"TailNumber\" of the FlightStatus class");
            fieldGeneratorAircraft = new AircraftJSON.HoldingGenerator("field \"Aircraft\" of the FlightStatus class", false);
            fieldGeneratorBoarding = new FlightStatusBoardingInfoJSON.HoldingGenerator("field \"Boarding\" of the FlightStatus class", false);
            fieldGeneratorDeparture = new DepartureArrivalInfoJSON.HoldingGenerator("field \"Departure\" of the FlightStatus class", false);
            fieldGeneratorArrival = new DepartureArrivalInfoJSON.HoldingGenerator("field \"Arrival\" of the FlightStatus class", false);
            fieldGeneratorScheduledFlightDuration = new TimeDifferenceJSON.HoldingGenerator("field \"ScheduledFlightDuration\" of the FlightStatus class", false);
            fieldGeneratorOperationalFlightDuration = new TimeDifferenceJSON.HoldingGenerator("field \"OperationalFlightDuration\" of the FlightStatus class", false);
            fieldGeneratorDeviationInFlightDurationFromScheduled = new TimeDifferenceJSON.HoldingGenerator("field \"DeviationInFlightDurationFromScheduled\" of the FlightStatus class", false);
            fieldGeneratorWrittenHints = new JSONHoldingStringArrayGenerator("field \"WrittenHints\" of the FlightStatus class");
            fieldGeneratorSpokenHints = new JSONHoldingStringArrayGenerator("field \"SpokenHints\" of the FlightStatus class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatus class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFlightId.reset();
            fieldGeneratorLabel.reset();
            fieldGeneratorSpokenLabel.reset();
            fieldGeneratorAirlineFlightNumber.reset();
            fieldGeneratorCodeshares.reset();
            fieldGeneratorMatchingCodeshareIndex.reset();
            fieldGeneratorFlightTravelState.reset();
            fieldGeneratorStatusSummary.reset();
            fieldGeneratorStatusSummaryShort.reset();
            fieldGeneratorDepartureArrivalText.reset();
            fieldGeneratorTailNumber.reset();
            fieldGeneratorAircraft.reset();
            fieldGeneratorBoarding.reset();
            fieldGeneratorDeparture.reset();
            fieldGeneratorArrival.reset();
            fieldGeneratorScheduledFlightDuration.reset();
            fieldGeneratorOperationalFlightDuration.reset();
            fieldGeneratorDeviationInFlightDurationFromScheduled.reset();
            fieldGeneratorWrittenHints.reset();
            fieldGeneratorSpokenHints.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAirlineFlightNumber.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCodeshares.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAircraft.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBoarding.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDeparture.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorArrival.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorScheduledFlightDuration.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOperationalFlightDuration.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDeviationInFlightDurationFromScheduled.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAirlineFlightNumber.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCodeshares.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAircraft.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBoarding.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDeparture.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorArrival.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorScheduledFlightDuration.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOperationalFlightDuration.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDeviationInFlightDurationFromScheduled.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightStatusJSON  result)
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
        public FlightStatusJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatusJSON  result)
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
    protected virtual void handle_result(List<FlightStatusJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatusJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatusJSON>();
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
    public List<FlightStatusJSON> value;
  };
  };
