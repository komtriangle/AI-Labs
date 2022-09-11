/* file "DepartureArrivalInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DepartureArrivalInfoJSON : JSONBase
  {
    public enum TypeOperationalDateTimeType
      {
        OperationalDateTimeType_Scheduled,
        OperationalDateTimeType_Estimated,
        OperationalDateTimeType_Actual
      };

    public static TypeOperationalDateTimeType  stringToOperationalDateTimeType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ctual", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeOperationalDateTimeType.OperationalDateTimeType_Actual;
                break;
            case 'E':
                if ((String.Compare(chars, 1, "stimated", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeOperationalDateTimeType.OperationalDateTimeType_Estimated;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "cheduled", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeOperationalDateTimeType.OperationalDateTimeType_Scheduled;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `OperationalDateTimeType' is not one of the legal values.");
      }

    public static string  stringFromOperationalDateTimeType(TypeOperationalDateTimeType the_enum)
      {
        switch (the_enum)
          {
            case TypeOperationalDateTimeType.OperationalDateTimeType_Scheduled:
                return "Scheduled";
            case TypeOperationalDateTimeType.OperationalDateTimeType_Estimated:
                return "Estimated";
            case TypeOperationalDateTimeType.OperationalDateTimeType_Actual:
                return "Actual";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeStateInTimeline
      {
        StateInTimeline_Upcoming,
        StateInTimeline_Defunct,
        StateInTimeline_InPast
      };

    public static TypeStateInTimeline  stringToStateInTimeline(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                if ((String.Compare(chars, 1, "efunct", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeStateInTimeline.StateInTimeline_Defunct;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nPast", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeStateInTimeline.StateInTimeline_InPast;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "pcoming", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeStateInTimeline.StateInTimeline_Upcoming;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `StateInTimeline' is not one of the legal values.");
      }

    public static string  stringFromStateInTimeline(TypeStateInTimeline the_enum)
      {
        switch (the_enum)
          {
            case TypeStateInTimeline.StateInTimeline_Upcoming:
                return "Upcoming";
            case TypeStateInTimeline.StateInTimeline_Defunct:
                return "Defunct";
            case TypeStateInTimeline.StateInTimeline_InPast:
                return "InPast";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasSummary;
    private string storeSummary;
    private bool flagHasAirport;
    private FlightStatusAirportJSON  storeAirport;
    private bool flagHasDivertedToAirport;
    private FlightStatusAirportJSON  storeDivertedToAirport;
    private bool flagHasTerminal;
    private string storeTerminal;
    private bool flagHasGate;
    private string storeGate;
    private bool flagHasBaggageClaim;
    private string storeBaggageClaim;
    private bool flagHasActualGateTime;
    private FlightTimesJSON  storeActualGateTime;
    private bool flagHasEstimatedGateTime;
    private FlightTimesJSON  storeEstimatedGateTime;
    private bool flagHasScheduledGateTime;
    private FlightTimesJSON  storeScheduledGateTime;
    private bool flagHasActualRunwayTime;
    private FlightTimesJSON  storeActualRunwayTime;
    private bool flagHasEstimatedRunwayTime;
    private FlightTimesJSON  storeEstimatedRunwayTime;
    private bool flagHasOperationalDateTime;
    private FlightTimesJSON  storeOperationalDateTime;
    private bool flagHasOperationalDateTimeType;
    private TypeOperationalDateTimeType storeOperationalDateTimeType;
    private bool flagHasScheduledDateTime;
    private FlightTimesJSON  storeScheduledDateTime;
    private bool flagHasDeviationFromScheduled;
    private TimeDifferenceJSON  storeDeviationFromScheduled;
    private bool flagHasStateInTimeline;
    private TypeStateInTimeline storeStateInTimeline;
    private bool flagHasWaitingPeriod;
    private TimeDifferenceJSON  storeWaitingPeriod;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSummary(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Summary of DepartureArrivalInfoJSON is not a string.");
        setSummary(json_string.getData());
      }


    private void  fromJSONAirport(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatusAirportJSON convert_classy = FlightStatusAirportJSON.from_json(json_value, ignore_extras, true);
        setAirport(convert_classy);
      }


    private void  fromJSONDivertedToAirport(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatusAirportJSON convert_classy = FlightStatusAirportJSON.from_json(json_value, ignore_extras, true);
        setDivertedToAirport(convert_classy);
      }


    private void  fromJSONTerminal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Terminal of DepartureArrivalInfoJSON is not a string.");
        setTerminal(json_string.getData());
      }


    private void  fromJSONGate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Gate of DepartureArrivalInfoJSON is not a string.");
        setGate(json_string.getData());
      }


    private void  fromJSONBaggageClaim(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BaggageClaim of DepartureArrivalInfoJSON is not a string.");
        setBaggageClaim(json_string.getData());
      }


    private void  fromJSONActualGateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setActualGateTime(convert_classy);
      }


    private void  fromJSONEstimatedGateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setEstimatedGateTime(convert_classy);
      }


    private void  fromJSONScheduledGateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setScheduledGateTime(convert_classy);
      }


    private void  fromJSONActualRunwayTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setActualRunwayTime(convert_classy);
      }


    private void  fromJSONEstimatedRunwayTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setEstimatedRunwayTime(convert_classy);
      }


    private void  fromJSONOperationalDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setOperationalDateTime(convert_classy);
      }


    private void  fromJSONOperationalDateTimeType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OperationalDateTimeType of DepartureArrivalInfoJSON is not a string.");
        TypeOperationalDateTimeType the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ctual", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeOperationalDateTimeType.OperationalDateTimeType_Actual;
                        goto enum_is_done;
                      }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "stimated", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeOperationalDateTimeType.OperationalDateTimeType_Estimated;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "cheduled", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeOperationalDateTimeType.OperationalDateTimeType_Scheduled;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field OperationalDateTimeType of DepartureArrivalInfoJSON is not one of the legal strings.");
      enum_is_done:;
        setOperationalDateTimeType(the_enum);
      }


    private void  fromJSONScheduledDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setScheduledDateTime(convert_classy);
      }


    private void  fromJSONDeviationFromScheduled(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeDifferenceJSON convert_classy = TimeDifferenceJSON.from_json(json_value, ignore_extras, true);
        setDeviationFromScheduled(convert_classy);
      }


    private void  fromJSONStateInTimeline(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StateInTimeline of DepartureArrivalInfoJSON is not a string.");
        TypeStateInTimeline the_enum;
        switch (json_string.getData()[0])
          {
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "efunct", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeStateInTimeline.StateInTimeline_Defunct;
                        goto enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nPast", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeStateInTimeline.StateInTimeline_InPast;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "pcoming", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeStateInTimeline.StateInTimeline_Upcoming;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field StateInTimeline of DepartureArrivalInfoJSON is not one of the legal strings.");
      enum_is_done:;
        setStateInTimeline(the_enum);
      }


    private void  fromJSONWaitingPeriod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeDifferenceJSON convert_classy = TimeDifferenceJSON.from_json(json_value, ignore_extras, true);
        setWaitingPeriod(convert_classy);
      }


    public DepartureArrivalInfoJSON()
      {
        flagHasSummary = false;
        flagHasAirport = false;
        flagHasDivertedToAirport = false;
        flagHasTerminal = false;
        flagHasGate = false;
        flagHasBaggageClaim = false;
        flagHasActualGateTime = false;
        flagHasEstimatedGateTime = false;
        flagHasScheduledGateTime = false;
        flagHasActualRunwayTime = false;
        flagHasEstimatedRunwayTime = false;
        flagHasOperationalDateTime = false;
        flagHasOperationalDateTimeType = false;
        flagHasScheduledDateTime = false;
        flagHasDeviationFromScheduled = false;
        flagHasStateInTimeline = false;
        flagHasWaitingPeriod = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSummary()
      {
        return flagHasSummary;
      }

    public string  getSummary()
      {
        Debug.Assert(flagHasSummary);
        return storeSummary;
      }

    public bool  hasAirport()
      {
        return flagHasAirport;
      }

    public FlightStatusAirportJSON   getAirport()
      {
        Debug.Assert(flagHasAirport);
        return storeAirport;
      }

    public bool  hasDivertedToAirport()
      {
        return flagHasDivertedToAirport;
      }

    public FlightStatusAirportJSON   getDivertedToAirport()
      {
        Debug.Assert(flagHasDivertedToAirport);
        return storeDivertedToAirport;
      }

    public bool  hasTerminal()
      {
        return flagHasTerminal;
      }

    public string  getTerminal()
      {
        Debug.Assert(flagHasTerminal);
        return storeTerminal;
      }

    public bool  hasGate()
      {
        return flagHasGate;
      }

    public string  getGate()
      {
        Debug.Assert(flagHasGate);
        return storeGate;
      }

    public bool  hasBaggageClaim()
      {
        return flagHasBaggageClaim;
      }

    public string  getBaggageClaim()
      {
        Debug.Assert(flagHasBaggageClaim);
        return storeBaggageClaim;
      }

    public bool  hasActualGateTime()
      {
        return flagHasActualGateTime;
      }

    public FlightTimesJSON   getActualGateTime()
      {
        Debug.Assert(flagHasActualGateTime);
        return storeActualGateTime;
      }

    public bool  hasEstimatedGateTime()
      {
        return flagHasEstimatedGateTime;
      }

    public FlightTimesJSON   getEstimatedGateTime()
      {
        Debug.Assert(flagHasEstimatedGateTime);
        return storeEstimatedGateTime;
      }

    public bool  hasScheduledGateTime()
      {
        return flagHasScheduledGateTime;
      }

    public FlightTimesJSON   getScheduledGateTime()
      {
        Debug.Assert(flagHasScheduledGateTime);
        return storeScheduledGateTime;
      }

    public bool  hasActualRunwayTime()
      {
        return flagHasActualRunwayTime;
      }

    public FlightTimesJSON   getActualRunwayTime()
      {
        Debug.Assert(flagHasActualRunwayTime);
        return storeActualRunwayTime;
      }

    public bool  hasEstimatedRunwayTime()
      {
        return flagHasEstimatedRunwayTime;
      }

    public FlightTimesJSON   getEstimatedRunwayTime()
      {
        Debug.Assert(flagHasEstimatedRunwayTime);
        return storeEstimatedRunwayTime;
      }

    public bool  hasOperationalDateTime()
      {
        return flagHasOperationalDateTime;
      }

    public FlightTimesJSON   getOperationalDateTime()
      {
        Debug.Assert(flagHasOperationalDateTime);
        return storeOperationalDateTime;
      }

    public bool  hasOperationalDateTimeType()
      {
        return flagHasOperationalDateTimeType;
      }

    public TypeOperationalDateTimeType  getOperationalDateTimeType()
      {
        Debug.Assert(flagHasOperationalDateTimeType);
        return storeOperationalDateTimeType;
      }

    public string  getOperationalDateTimeTypeAsString()
      {
        return stringFromOperationalDateTimeType(getOperationalDateTimeType());
      }

    public bool  hasScheduledDateTime()
      {
        return flagHasScheduledDateTime;
      }

    public FlightTimesJSON   getScheduledDateTime()
      {
        Debug.Assert(flagHasScheduledDateTime);
        return storeScheduledDateTime;
      }

    public bool  hasDeviationFromScheduled()
      {
        return flagHasDeviationFromScheduled;
      }

    public TimeDifferenceJSON   getDeviationFromScheduled()
      {
        Debug.Assert(flagHasDeviationFromScheduled);
        return storeDeviationFromScheduled;
      }

    public bool  hasStateInTimeline()
      {
        return flagHasStateInTimeline;
      }

    public TypeStateInTimeline  getStateInTimeline()
      {
        Debug.Assert(flagHasStateInTimeline);
        return storeStateInTimeline;
      }

    public string  getStateInTimelineAsString()
      {
        return stringFromStateInTimeline(getStateInTimeline());
      }

    public bool  hasWaitingPeriod()
      {
        return flagHasWaitingPeriod;
      }

    public TimeDifferenceJSON   getWaitingPeriod()
      {
        Debug.Assert(flagHasWaitingPeriod);
        return storeWaitingPeriod;
      }


    public virtual int extraDepartureArrivalInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDepartureArrivalInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDepartureArrivalInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDepartureArrivalInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSummary(string new_value)
      {
        flagHasSummary = true;
        storeSummary = new_value;
      }
    public void unsetSummary()
      {
        flagHasSummary = false;
      }
    public void setAirport(FlightStatusAirportJSON  new_value)
      {
        if (flagHasAirport)
          {
          }
        flagHasAirport = true;
        storeAirport = new_value;
      }
    public void unsetAirport()
      {
        if (flagHasAirport)
          {
          }
        flagHasAirport = false;
      }
    public void setDivertedToAirport(FlightStatusAirportJSON  new_value)
      {
        if (flagHasDivertedToAirport)
          {
          }
        flagHasDivertedToAirport = true;
        storeDivertedToAirport = new_value;
      }
    public void unsetDivertedToAirport()
      {
        if (flagHasDivertedToAirport)
          {
          }
        flagHasDivertedToAirport = false;
      }
    public void setTerminal(string new_value)
      {
        flagHasTerminal = true;
        storeTerminal = new_value;
      }
    public void unsetTerminal()
      {
        flagHasTerminal = false;
      }
    public void setGate(string new_value)
      {
        flagHasGate = true;
        storeGate = new_value;
      }
    public void unsetGate()
      {
        flagHasGate = false;
      }
    public void setBaggageClaim(string new_value)
      {
        flagHasBaggageClaim = true;
        storeBaggageClaim = new_value;
      }
    public void unsetBaggageClaim()
      {
        flagHasBaggageClaim = false;
      }
    public void setActualGateTime(FlightTimesJSON  new_value)
      {
        if (flagHasActualGateTime)
          {
          }
        flagHasActualGateTime = true;
        storeActualGateTime = new_value;
      }
    public void unsetActualGateTime()
      {
        if (flagHasActualGateTime)
          {
          }
        flagHasActualGateTime = false;
      }
    public void setEstimatedGateTime(FlightTimesJSON  new_value)
      {
        if (flagHasEstimatedGateTime)
          {
          }
        flagHasEstimatedGateTime = true;
        storeEstimatedGateTime = new_value;
      }
    public void unsetEstimatedGateTime()
      {
        if (flagHasEstimatedGateTime)
          {
          }
        flagHasEstimatedGateTime = false;
      }
    public void setScheduledGateTime(FlightTimesJSON  new_value)
      {
        if (flagHasScheduledGateTime)
          {
          }
        flagHasScheduledGateTime = true;
        storeScheduledGateTime = new_value;
      }
    public void unsetScheduledGateTime()
      {
        if (flagHasScheduledGateTime)
          {
          }
        flagHasScheduledGateTime = false;
      }
    public void setActualRunwayTime(FlightTimesJSON  new_value)
      {
        if (flagHasActualRunwayTime)
          {
          }
        flagHasActualRunwayTime = true;
        storeActualRunwayTime = new_value;
      }
    public void unsetActualRunwayTime()
      {
        if (flagHasActualRunwayTime)
          {
          }
        flagHasActualRunwayTime = false;
      }
    public void setEstimatedRunwayTime(FlightTimesJSON  new_value)
      {
        if (flagHasEstimatedRunwayTime)
          {
          }
        flagHasEstimatedRunwayTime = true;
        storeEstimatedRunwayTime = new_value;
      }
    public void unsetEstimatedRunwayTime()
      {
        if (flagHasEstimatedRunwayTime)
          {
          }
        flagHasEstimatedRunwayTime = false;
      }
    public void setOperationalDateTime(FlightTimesJSON  new_value)
      {
        if (flagHasOperationalDateTime)
          {
          }
        flagHasOperationalDateTime = true;
        storeOperationalDateTime = new_value;
      }
    public void unsetOperationalDateTime()
      {
        if (flagHasOperationalDateTime)
          {
          }
        flagHasOperationalDateTime = false;
      }
    public void setOperationalDateTimeType(TypeOperationalDateTimeType new_value)
      {
        flagHasOperationalDateTimeType = true;
        storeOperationalDateTimeType = new_value;
      }
    public void setOperationalDateTimeType(string chars)
      {
        setOperationalDateTimeType(stringToOperationalDateTimeType(chars));
      }
    public void unsetOperationalDateTimeType()
      {
        flagHasOperationalDateTimeType = false;
      }
    public void setScheduledDateTime(FlightTimesJSON  new_value)
      {
        if (flagHasScheduledDateTime)
          {
          }
        flagHasScheduledDateTime = true;
        storeScheduledDateTime = new_value;
      }
    public void unsetScheduledDateTime()
      {
        if (flagHasScheduledDateTime)
          {
          }
        flagHasScheduledDateTime = false;
      }
    public void setDeviationFromScheduled(TimeDifferenceJSON  new_value)
      {
        if (flagHasDeviationFromScheduled)
          {
          }
        flagHasDeviationFromScheduled = true;
        storeDeviationFromScheduled = new_value;
      }
    public void unsetDeviationFromScheduled()
      {
        if (flagHasDeviationFromScheduled)
          {
          }
        flagHasDeviationFromScheduled = false;
      }
    public void setStateInTimeline(TypeStateInTimeline new_value)
      {
        flagHasStateInTimeline = true;
        storeStateInTimeline = new_value;
      }
    public void setStateInTimeline(string chars)
      {
        setStateInTimeline(stringToStateInTimeline(chars));
      }
    public void unsetStateInTimeline()
      {
        flagHasStateInTimeline = false;
      }
    public void setWaitingPeriod(TimeDifferenceJSON  new_value)
      {
        if (flagHasWaitingPeriod)
          {
          }
        flagHasWaitingPeriod = true;
        storeWaitingPeriod = new_value;
      }
    public void unsetWaitingPeriod()
      {
        if (flagHasWaitingPeriod)
          {
          }
        flagHasWaitingPeriod = false;
      }

    public virtual void extraDepartureArrivalInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDepartureArrivalInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDepartureArrivalInfoLookup(key);
        if (old_field == null)
          {
            extraDepartureArrivalInfoAppendPair(key, new_component);
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
        if (flagHasSummary)
          {
            handler.start_pair("Summary");
            handler.string_value(storeSummary);
          }
        if (flagHasAirport)
          {
            handler.start_pair("Airport");
            if (partial_allowed)
                storeAirport.write_partial_as_json(handler);
            else
                storeAirport.write_as_json(handler);
          }
        if (flagHasDivertedToAirport)
          {
            handler.start_pair("DivertedToAirport");
            if (partial_allowed)
                storeDivertedToAirport.write_partial_as_json(handler);
            else
                storeDivertedToAirport.write_as_json(handler);
          }
        if (flagHasTerminal)
          {
            handler.start_pair("Terminal");
            handler.string_value(storeTerminal);
          }
        if (flagHasGate)
          {
            handler.start_pair("Gate");
            handler.string_value(storeGate);
          }
        if (flagHasBaggageClaim)
          {
            handler.start_pair("BaggageClaim");
            handler.string_value(storeBaggageClaim);
          }
        if (flagHasActualGateTime)
          {
            handler.start_pair("ActualGateTime");
            if (partial_allowed)
                storeActualGateTime.write_partial_as_json(handler);
            else
                storeActualGateTime.write_as_json(handler);
          }
        if (flagHasEstimatedGateTime)
          {
            handler.start_pair("EstimatedGateTime");
            if (partial_allowed)
                storeEstimatedGateTime.write_partial_as_json(handler);
            else
                storeEstimatedGateTime.write_as_json(handler);
          }
        if (flagHasScheduledGateTime)
          {
            handler.start_pair("ScheduledGateTime");
            if (partial_allowed)
                storeScheduledGateTime.write_partial_as_json(handler);
            else
                storeScheduledGateTime.write_as_json(handler);
          }
        if (flagHasActualRunwayTime)
          {
            handler.start_pair("ActualRunwayTime");
            if (partial_allowed)
                storeActualRunwayTime.write_partial_as_json(handler);
            else
                storeActualRunwayTime.write_as_json(handler);
          }
        if (flagHasEstimatedRunwayTime)
          {
            handler.start_pair("EstimatedRunwayTime");
            if (partial_allowed)
                storeEstimatedRunwayTime.write_partial_as_json(handler);
            else
                storeEstimatedRunwayTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasOperationalDateTime);
        if (flagHasOperationalDateTime)
          {
            handler.start_pair("OperationalDateTime");
            if (partial_allowed)
                storeOperationalDateTime.write_partial_as_json(handler);
            else
                storeOperationalDateTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasOperationalDateTimeType);
        if (flagHasOperationalDateTimeType)
          {
            handler.start_pair("OperationalDateTimeType");
            switch (storeOperationalDateTimeType)
              {
                case TypeOperationalDateTimeType.OperationalDateTimeType_Scheduled:
                    handler.string_value("Scheduled");
                    break;
                case TypeOperationalDateTimeType.OperationalDateTimeType_Estimated:
                    handler.string_value("Estimated");
                    break;
                case TypeOperationalDateTimeType.OperationalDateTimeType_Actual:
                    handler.string_value("Actual");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasScheduledDateTime);
        if (flagHasScheduledDateTime)
          {
            handler.start_pair("ScheduledDateTime");
            if (partial_allowed)
                storeScheduledDateTime.write_partial_as_json(handler);
            else
                storeScheduledDateTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDeviationFromScheduled);
        if (flagHasDeviationFromScheduled)
          {
            handler.start_pair("DeviationFromScheduled");
            if (partial_allowed)
                storeDeviationFromScheduled.write_partial_as_json(handler);
            else
                storeDeviationFromScheduled.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasStateInTimeline);
        if (flagHasStateInTimeline)
          {
            handler.start_pair("StateInTimeline");
            switch (storeStateInTimeline)
              {
                case TypeStateInTimeline.StateInTimeline_Upcoming:
                    handler.string_value("Upcoming");
                    break;
                case TypeStateInTimeline.StateInTimeline_Defunct:
                    handler.string_value("Defunct");
                    break;
                case TypeStateInTimeline.StateInTimeline_InPast:
                    handler.string_value("InPast");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasWaitingPeriod);
        if (flagHasWaitingPeriod)
          {
            handler.start_pair("WaitingPeriod");
            if (partial_allowed)
                storeWaitingPeriod.write_partial_as_json(handler);
            else
                storeWaitingPeriod.write_as_json(handler);
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
        if (!(hasOperationalDateTime()))
          {
            return "When parsing the object for %what%, the \"OperationalDateTime\" field was missing.";
          }
        if (!(hasOperationalDateTimeType()))
          {
            return "When parsing the object for %what%, the \"OperationalDateTimeType\" field was missing.";
          }
        if (!(hasScheduledDateTime()))
          {
            return "When parsing the object for %what%, the \"ScheduledDateTime\" field was missing.";
          }
        if (!(hasDeviationFromScheduled()))
          {
            return "When parsing the object for %what%, the \"DeviationFromScheduled\" field was missing.";
          }
        if (!(hasStateInTimeline()))
          {
            return "When parsing the object for %what%, the \"StateInTimeline\" field was missing.";
          }
        if (!(hasWaitingPeriod()))
          {
            return "When parsing the object for %what%, the \"WaitingPeriod\" field was missing.";
          }
        return null;
      }

    public static DepartureArrivalInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DepartureArrivalInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DepartureArrivalInfo", ignore_extras);
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
    public static DepartureArrivalInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DepartureArrivalInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DepartureArrivalInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DepartureArrivalInfo", ignore_extras);
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
    public static DepartureArrivalInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DepartureArrivalInfoJSON from_text(string text, bool ignore_extras)
      {
        DepartureArrivalInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DepartureArrivalInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DepartureArrivalInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DepartureArrivalInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DepartureArrivalInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DepartureArrivalInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSummary;
        private FlightStatusAirportJSON.HoldingGenerator fieldGeneratorAirport;
        private FlightStatusAirportJSON.HoldingGenerator fieldGeneratorDivertedToAirport;
        private JSONHoldingStringGenerator fieldGeneratorTerminal;
        private JSONHoldingStringGenerator fieldGeneratorGate;
        private JSONHoldingStringGenerator fieldGeneratorBaggageClaim;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorActualGateTime;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorEstimatedGateTime;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorScheduledGateTime;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorActualRunwayTime;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorEstimatedRunwayTime;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorOperationalDateTime;
    private abstract class FieldGeneratorOperationalDateTimeType : JSONStringGenerator
          {
            protected FieldGeneratorOperationalDateTimeType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorOperationalDateTimeType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToOperationalDateTimeType(result));
              }
            protected abstract void handle_result(TypeOperationalDateTimeType result);
          };
    private class FieldHoldingGeneratorOperationalDateTimeType : FieldGeneratorOperationalDateTimeType
  {
    protected override void handle_result(TypeOperationalDateTimeType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorOperationalDateTimeType(String what)
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
    public TypeOperationalDateTimeType value;
  };
    private class FieldHoldingArrayGeneratorOperationalDateTimeType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorOperationalDateTimeType
      {
        private FieldHoldingArrayGeneratorOperationalDateTimeType top;

        protected override void handle_result(TypeOperationalDateTimeType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorOperationalDateTimeType init_top)
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
    protected virtual void handle_result(List<TypeOperationalDateTimeType> result)
      {
      }

    public FieldHoldingArrayGeneratorOperationalDateTimeType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeOperationalDateTimeType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorOperationalDateTimeType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeOperationalDateTimeType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeOperationalDateTimeType> value;
  };
        private FieldHoldingGeneratorOperationalDateTimeType fieldGeneratorOperationalDateTimeType;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorScheduledDateTime;
        private TimeDifferenceJSON.HoldingGenerator fieldGeneratorDeviationFromScheduled;
    private abstract class FieldGeneratorStateInTimeline : JSONStringGenerator
          {
            protected FieldGeneratorStateInTimeline(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorStateInTimeline()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToStateInTimeline(result));
              }
            protected abstract void handle_result(TypeStateInTimeline result);
          };
    private class FieldHoldingGeneratorStateInTimeline : FieldGeneratorStateInTimeline
  {
    protected override void handle_result(TypeStateInTimeline result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorStateInTimeline(String what)
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
    public TypeStateInTimeline value;
  };
    private class FieldHoldingArrayGeneratorStateInTimeline : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStateInTimeline
      {
        private FieldHoldingArrayGeneratorStateInTimeline top;

        protected override void handle_result(TypeStateInTimeline result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStateInTimeline init_top)
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
    protected virtual void handle_result(List<TypeStateInTimeline> result)
      {
      }

    public FieldHoldingArrayGeneratorStateInTimeline(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStateInTimeline>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStateInTimeline()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStateInTimeline>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeStateInTimeline> value;
  };
        private FieldHoldingGeneratorStateInTimeline fieldGeneratorStateInTimeline;
        private TimeDifferenceJSON.HoldingGenerator fieldGeneratorWaitingPeriod;
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
            DepartureArrivalInfoJSON result = new DepartureArrivalInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDepartureArrivalInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DepartureArrivalInfoJSON result)
          {
            if (fieldGeneratorSummary.have_value)
              {
                result.setSummary(fieldGeneratorSummary.value);
                fieldGeneratorSummary.have_value = false;
              }
            if (fieldGeneratorAirport.have_value)
              {
                result.setAirport(fieldGeneratorAirport.value);
                fieldGeneratorAirport.have_value = false;
              }
            if (fieldGeneratorDivertedToAirport.have_value)
              {
                result.setDivertedToAirport(fieldGeneratorDivertedToAirport.value);
                fieldGeneratorDivertedToAirport.have_value = false;
              }
            if (fieldGeneratorTerminal.have_value)
              {
                result.setTerminal(fieldGeneratorTerminal.value);
                fieldGeneratorTerminal.have_value = false;
              }
            if (fieldGeneratorGate.have_value)
              {
                result.setGate(fieldGeneratorGate.value);
                fieldGeneratorGate.have_value = false;
              }
            if (fieldGeneratorBaggageClaim.have_value)
              {
                result.setBaggageClaim(fieldGeneratorBaggageClaim.value);
                fieldGeneratorBaggageClaim.have_value = false;
              }
            if (fieldGeneratorActualGateTime.have_value)
              {
                result.setActualGateTime(fieldGeneratorActualGateTime.value);
                fieldGeneratorActualGateTime.have_value = false;
              }
            if (fieldGeneratorEstimatedGateTime.have_value)
              {
                result.setEstimatedGateTime(fieldGeneratorEstimatedGateTime.value);
                fieldGeneratorEstimatedGateTime.have_value = false;
              }
            if (fieldGeneratorScheduledGateTime.have_value)
              {
                result.setScheduledGateTime(fieldGeneratorScheduledGateTime.value);
                fieldGeneratorScheduledGateTime.have_value = false;
              }
            if (fieldGeneratorActualRunwayTime.have_value)
              {
                result.setActualRunwayTime(fieldGeneratorActualRunwayTime.value);
                fieldGeneratorActualRunwayTime.have_value = false;
              }
            if (fieldGeneratorEstimatedRunwayTime.have_value)
              {
                result.setEstimatedRunwayTime(fieldGeneratorEstimatedRunwayTime.value);
                fieldGeneratorEstimatedRunwayTime.have_value = false;
              }
            if (fieldGeneratorOperationalDateTime.have_value)
              {
                result.setOperationalDateTime(fieldGeneratorOperationalDateTime.value);
                fieldGeneratorOperationalDateTime.have_value = false;
              }
            else if ((!(result.hasOperationalDateTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OperationalDateTime\" field was missing.");
              }
            if (fieldGeneratorOperationalDateTimeType.have_value)
              {
                result.setOperationalDateTimeType(fieldGeneratorOperationalDateTimeType.value);
                fieldGeneratorOperationalDateTimeType.have_value = false;
              }
            else if ((!(result.hasOperationalDateTimeType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OperationalDateTimeType\" field was missing.");
              }
            if (fieldGeneratorScheduledDateTime.have_value)
              {
                result.setScheduledDateTime(fieldGeneratorScheduledDateTime.value);
                fieldGeneratorScheduledDateTime.have_value = false;
              }
            else if ((!(result.hasScheduledDateTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ScheduledDateTime\" field was missing.");
              }
            if (fieldGeneratorDeviationFromScheduled.have_value)
              {
                result.setDeviationFromScheduled(fieldGeneratorDeviationFromScheduled.value);
                fieldGeneratorDeviationFromScheduled.have_value = false;
              }
            else if ((!(result.hasDeviationFromScheduled())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DeviationFromScheduled\" field was missing.");
              }
            if (fieldGeneratorStateInTimeline.have_value)
              {
                result.setStateInTimeline(fieldGeneratorStateInTimeline.value);
                fieldGeneratorStateInTimeline.have_value = false;
              }
            else if ((!(result.hasStateInTimeline())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StateInTimeline\" field was missing.");
              }
            if (fieldGeneratorWaitingPeriod.have_value)
              {
                result.setWaitingPeriod(fieldGeneratorWaitingPeriod.value);
                fieldGeneratorWaitingPeriod.have_value = false;
              }
            else if ((!(result.hasWaitingPeriod())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WaitingPeriod\" field was missing.");
              }
          }
        protected abstract void handle_result(DepartureArrivalInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'c':
                            if (String.Compare(field_name, 2, "tual", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'G':
                                        if ((String.Compare(field_name, 7, "ateTime", 0, 7, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorActualGateTime;
                                        break;
                                    case 'R':
                                        if ((String.Compare(field_name, 7, "unwayTime", 0, 9, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorActualRunwayTime;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "rport", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorAirport;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "aggageClaim", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorBaggageClaim;
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "viationFromScheduled", 0, 20, false) == 0) && (field_name.Length == 22))
                                return fieldGeneratorDeviationFromScheduled;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "vertedToAirport", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorDivertedToAirport;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'E':
                    if (String.Compare(field_name, 1, "stimated", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'G':
                                if ((String.Compare(field_name, 10, "ateTime", 0, 7, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorEstimatedGateTime;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 10, "unwayTime", 0, 9, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorEstimatedRunwayTime;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "ate", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorGate;
                    break;
                case 'O':
                    if (String.Compare(field_name, 1, "perationalDateTime", 0, 18, false) == 0)
                      {
                        if (field_name.Length == 19)
                          {
                            return fieldGeneratorOperationalDateTime;
                          }
                        switch (field_name[19])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 20, "ype", 0, 3, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorOperationalDateTimeType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'c':
                            if (String.Compare(field_name, 2, "heduled", 0, 7, false) == 0)
                              {
                                switch (field_name[9])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 10, "ateTime", 0, 7, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorScheduledDateTime;
                                        break;
                                    case 'G':
                                        if ((String.Compare(field_name, 10, "ateTime", 0, 7, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorScheduledGateTime;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "ateInTimeline", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorStateInTimeline;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "mmary", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorSummary;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "erminal", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorTerminal;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "aitingPeriod", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorWaitingPeriod;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSummary = new JSONHoldingStringGenerator("field \"Summary\" of the DepartureArrivalInfo class");
            fieldGeneratorAirport = new FlightStatusAirportJSON.HoldingGenerator("field \"Airport\" of the DepartureArrivalInfo class", ignore_extras);
            fieldGeneratorDivertedToAirport = new FlightStatusAirportJSON.HoldingGenerator("field \"DivertedToAirport\" of the DepartureArrivalInfo class", ignore_extras);
            fieldGeneratorTerminal = new JSONHoldingStringGenerator("field \"Terminal\" of the DepartureArrivalInfo class");
            fieldGeneratorGate = new JSONHoldingStringGenerator("field \"Gate\" of the DepartureArrivalInfo class");
            fieldGeneratorBaggageClaim = new JSONHoldingStringGenerator("field \"BaggageClaim\" of the DepartureArrivalInfo class");
            fieldGeneratorActualGateTime = new FlightTimesJSON.HoldingGenerator("field \"ActualGateTime\" of the DepartureArrivalInfo class", ignore_extras);
            fieldGeneratorEstimatedGateTime = new FlightTimesJSON.HoldingGenerator("field \"EstimatedGateTime\" of the DepartureArrivalInfo class", ignore_extras);
            fieldGeneratorScheduledGateTime = new FlightTimesJSON.HoldingGenerator("field \"ScheduledGateTime\" of the DepartureArrivalInfo class", ignore_extras);
            fieldGeneratorActualRunwayTime = new FlightTimesJSON.HoldingGenerator("field \"ActualRunwayTime\" of the DepartureArrivalInfo class", ignore_extras);
            fieldGeneratorEstimatedRunwayTime = new FlightTimesJSON.HoldingGenerator("field \"EstimatedRunwayTime\" of the DepartureArrivalInfo class", ignore_extras);
            fieldGeneratorOperationalDateTime = new FlightTimesJSON.HoldingGenerator("field \"OperationalDateTime\" of the DepartureArrivalInfo class", ignore_extras);
            fieldGeneratorOperationalDateTimeType = new FieldHoldingGeneratorOperationalDateTimeType("field \"OperationalDateTimeType\" of the DepartureArrivalInfo class");
            fieldGeneratorScheduledDateTime = new FlightTimesJSON.HoldingGenerator("field \"ScheduledDateTime\" of the DepartureArrivalInfo class", ignore_extras);
            fieldGeneratorDeviationFromScheduled = new TimeDifferenceJSON.HoldingGenerator("field \"DeviationFromScheduled\" of the DepartureArrivalInfo class", ignore_extras);
            fieldGeneratorStateInTimeline = new FieldHoldingGeneratorStateInTimeline("field \"StateInTimeline\" of the DepartureArrivalInfo class");
            fieldGeneratorWaitingPeriod = new TimeDifferenceJSON.HoldingGenerator("field \"WaitingPeriod\" of the DepartureArrivalInfo class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DepartureArrivalInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSummary = new JSONHoldingStringGenerator("field \"Summary\" of the DepartureArrivalInfo class");
            fieldGeneratorAirport = new FlightStatusAirportJSON.HoldingGenerator("field \"Airport\" of the DepartureArrivalInfo class", false);
            fieldGeneratorDivertedToAirport = new FlightStatusAirportJSON.HoldingGenerator("field \"DivertedToAirport\" of the DepartureArrivalInfo class", false);
            fieldGeneratorTerminal = new JSONHoldingStringGenerator("field \"Terminal\" of the DepartureArrivalInfo class");
            fieldGeneratorGate = new JSONHoldingStringGenerator("field \"Gate\" of the DepartureArrivalInfo class");
            fieldGeneratorBaggageClaim = new JSONHoldingStringGenerator("field \"BaggageClaim\" of the DepartureArrivalInfo class");
            fieldGeneratorActualGateTime = new FlightTimesJSON.HoldingGenerator("field \"ActualGateTime\" of the DepartureArrivalInfo class", false);
            fieldGeneratorEstimatedGateTime = new FlightTimesJSON.HoldingGenerator("field \"EstimatedGateTime\" of the DepartureArrivalInfo class", false);
            fieldGeneratorScheduledGateTime = new FlightTimesJSON.HoldingGenerator("field \"ScheduledGateTime\" of the DepartureArrivalInfo class", false);
            fieldGeneratorActualRunwayTime = new FlightTimesJSON.HoldingGenerator("field \"ActualRunwayTime\" of the DepartureArrivalInfo class", false);
            fieldGeneratorEstimatedRunwayTime = new FlightTimesJSON.HoldingGenerator("field \"EstimatedRunwayTime\" of the DepartureArrivalInfo class", false);
            fieldGeneratorOperationalDateTime = new FlightTimesJSON.HoldingGenerator("field \"OperationalDateTime\" of the DepartureArrivalInfo class", false);
            fieldGeneratorOperationalDateTimeType = new FieldHoldingGeneratorOperationalDateTimeType("field \"OperationalDateTimeType\" of the DepartureArrivalInfo class");
            fieldGeneratorScheduledDateTime = new FlightTimesJSON.HoldingGenerator("field \"ScheduledDateTime\" of the DepartureArrivalInfo class", false);
            fieldGeneratorDeviationFromScheduled = new TimeDifferenceJSON.HoldingGenerator("field \"DeviationFromScheduled\" of the DepartureArrivalInfo class", false);
            fieldGeneratorStateInTimeline = new FieldHoldingGeneratorStateInTimeline("field \"StateInTimeline\" of the DepartureArrivalInfo class");
            fieldGeneratorWaitingPeriod = new TimeDifferenceJSON.HoldingGenerator("field \"WaitingPeriod\" of the DepartureArrivalInfo class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DepartureArrivalInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSummary.reset();
            fieldGeneratorAirport.reset();
            fieldGeneratorDivertedToAirport.reset();
            fieldGeneratorTerminal.reset();
            fieldGeneratorGate.reset();
            fieldGeneratorBaggageClaim.reset();
            fieldGeneratorActualGateTime.reset();
            fieldGeneratorEstimatedGateTime.reset();
            fieldGeneratorScheduledGateTime.reset();
            fieldGeneratorActualRunwayTime.reset();
            fieldGeneratorEstimatedRunwayTime.reset();
            fieldGeneratorOperationalDateTime.reset();
            fieldGeneratorOperationalDateTimeType.reset();
            fieldGeneratorScheduledDateTime.reset();
            fieldGeneratorDeviationFromScheduled.reset();
            fieldGeneratorStateInTimeline.reset();
            fieldGeneratorWaitingPeriod.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAirport.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDivertedToAirport.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorActualGateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEstimatedGateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorScheduledGateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorActualRunwayTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEstimatedRunwayTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOperationalDateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorScheduledDateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDeviationFromScheduled.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWaitingPeriod.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAirport.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDivertedToAirport.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorActualGateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEstimatedGateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorScheduledGateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorActualRunwayTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEstimatedRunwayTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOperationalDateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorScheduledDateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDeviationFromScheduled.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWaitingPeriod.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DepartureArrivalInfoJSON  result)
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
        public DepartureArrivalInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DepartureArrivalInfoJSON  result)
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
    protected virtual void handle_result(List<DepartureArrivalInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DepartureArrivalInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DepartureArrivalInfoJSON>();
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
    public List<DepartureArrivalInfoJSON> value;
  };
  };
