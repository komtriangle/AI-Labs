/* file "TimeInLocationInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimeInLocationInformationNuggetJSON : DateAndTimeInformationNuggetJSON
  {
    private bool flagHasSourceMapLocation;
    private MapLocationJSON  storeSourceMapLocation;
    private bool flagHasSourceTimeZone;
    private TimeZoneJSON  storeSourceTimeZone;
    private bool flagHasSourceDateTimeSpec;
    private DateTimeSpecJSON  storeSourceDateTimeSpec;
    private bool flagHasDestinationMapLocation;
    private MapLocationJSON  storeDestinationMapLocation;
    private bool flagHasDestinationLocationsAndTimes;
    private List< LocationAndTimeJSON  > storeDestinationLocationsAndTimes;
    private bool flagHasDestinationTimeZone;
    private TimeZoneJSON  storeDestinationTimeZone;
    private bool flagHasDestinationDateTimeSpec;
    private DateTimeSpecJSON  storeDestinationDateTimeSpec;
    private bool flagHasIsDateRequested;
    private bool storeIsDateRequested;
    private bool flagHasIsTimeInFuture;
    private bool storeIsTimeInFuture;
    private bool flagHasIsTimeInPast;
    private bool storeIsTimeInPast;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSourceMapLocationToJSON()
      {
        JSONValueHandler handler_SourceMapLocation = new JSONValueHandler();
        storeSourceMapLocation.write_as_json(handler_SourceMapLocation);
        return handler_SourceMapLocation.result;
      }

    private JSONValue  extraSourceTimeZoneToJSON()
      {
        JSONValueHandler handler_SourceTimeZone = new JSONValueHandler();
        storeSourceTimeZone.write_as_json(handler_SourceTimeZone);
        return handler_SourceTimeZone.result;
      }

    private JSONValue  extraSourceDateTimeSpecToJSON()
      {
        JSONValueHandler handler_SourceDateTimeSpec = new JSONValueHandler();
        storeSourceDateTimeSpec.write_as_json(handler_SourceDateTimeSpec);
        return handler_SourceDateTimeSpec.result;
      }

    private JSONValue  extraDestinationMapLocationToJSON()
      {
        JSONValueHandler handler_DestinationMapLocation = new JSONValueHandler();
        storeDestinationMapLocation.write_as_json(handler_DestinationMapLocation);
        return handler_DestinationMapLocation.result;
      }

    private JSONValue  extraDestinationLocationsAndTimesToJSON()
      {
        JSONArrayValue generated_array_1_DestinationLocationsAndTimes = new JSONArrayValue();
        for (int num1 = 0; num1 < storeDestinationLocationsAndTimes.Count; ++num1)
          {
            JSONValueHandler handler_DestinationLocationsAndTimes = new JSONValueHandler();
            storeDestinationLocationsAndTimes[num1].write_as_json(handler_DestinationLocationsAndTimes);
            generated_array_1_DestinationLocationsAndTimes.appendComponent(handler_DestinationLocationsAndTimes.result);
          }
        return generated_array_1_DestinationLocationsAndTimes;
      }

    private JSONValue  extraDestinationTimeZoneToJSON()
      {
        JSONValueHandler handler_DestinationTimeZone = new JSONValueHandler();
        storeDestinationTimeZone.write_as_json(handler_DestinationTimeZone);
        return handler_DestinationTimeZone.result;
      }

    private JSONValue  extraDestinationDateTimeSpecToJSON()
      {
        JSONValueHandler handler_DestinationDateTimeSpec = new JSONValueHandler();
        storeDestinationDateTimeSpec.write_as_json(handler_DestinationDateTimeSpec);
        return handler_DestinationDateTimeSpec.result;
      }

    private JSONValue  extraIsDateRequestedToJSON()
      {
        JSONValue generated_boolean_IsDateRequested = (storeIsDateRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsDateRequested;
      }

    private JSONValue  extraIsTimeInFutureToJSON()
      {
        JSONValue generated_boolean_IsTimeInFuture = (storeIsTimeInFuture ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsTimeInFuture;
      }

    private JSONValue  extraIsTimeInPastToJSON()
      {
        JSONValue generated_boolean_IsTimeInPast = (storeIsTimeInPast ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsTimeInPast;
      }


    private void  fromJSONSourceMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setSourceMapLocation(convert_classy);
      }


    private void  fromJSONSourceTimeZone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeZoneJSON convert_classy = TimeZoneJSON.from_json(json_value, ignore_extras, true);
        setSourceTimeZone(convert_classy);
      }


    private void  fromJSONSourceDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setSourceDateTimeSpec(convert_classy);
      }


    private void  fromJSONDestinationMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setDestinationMapLocation(convert_classy);
      }


    private void  fromJSONDestinationLocationsAndTimes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DestinationLocationsAndTimes of TimeInLocationInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field DestinationLocationsAndTimes of TimeInLocationInformationNuggetJSON has too few elements.");
        List< LocationAndTimeJSON  > vector_DestinationLocationsAndTimes1 = new List< LocationAndTimeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            LocationAndTimeJSON convert_classy = LocationAndTimeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_DestinationLocationsAndTimes1.Add(convert_classy);
          }
        Debug.Assert(vector_DestinationLocationsAndTimes1.Count >= 1);
        initDestinationLocationsAndTimes();
        for (int num1 = 0; num1 < vector_DestinationLocationsAndTimes1.Count; ++num1)
            appendDestinationLocationsAndTimes(vector_DestinationLocationsAndTimes1[num1]);
        for (int num1 = 0; num1 < vector_DestinationLocationsAndTimes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDestinationTimeZone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeZoneJSON convert_classy = TimeZoneJSON.from_json(json_value, ignore_extras, true);
        setDestinationTimeZone(convert_classy);
      }


    private void  fromJSONDestinationDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setDestinationDateTimeSpec(convert_classy);
      }


    private void  fromJSONIsDateRequested(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field IsDateRequested of TimeInLocationInformationNuggetJSON is not true for false.");
              }
          }
        setIsDateRequested(the_bool);
      }


    private void  fromJSONIsTimeInFuture(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field IsTimeInFuture of TimeInLocationInformationNuggetJSON is not true for false.");
              }
          }
        setIsTimeInFuture(the_bool);
      }


    private void  fromJSONIsTimeInPast(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field IsTimeInPast of TimeInLocationInformationNuggetJSON is not true for false.");
              }
          }
        setIsTimeInPast(the_bool);
      }


    public TimeInLocationInformationNuggetJSON()
      {
        flagHasSourceMapLocation = false;
        flagHasSourceTimeZone = false;
        flagHasSourceDateTimeSpec = false;
        flagHasDestinationMapLocation = false;
        flagHasDestinationLocationsAndTimes = false;
        flagHasDestinationTimeZone = false;
        flagHasDestinationDateTimeSpec = false;
        flagHasIsDateRequested = false;
        flagHasIsTimeInFuture = false;
        flagHasIsTimeInPast = false;
        storeDestinationLocationsAndTimes = new List< LocationAndTimeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDateAndTimeNuggetKind()
      {
        return "TimeInLocation";
      }

    public bool  hasSourceMapLocation()
      {
        return flagHasSourceMapLocation;
      }

    public MapLocationJSON   getSourceMapLocation()
      {
        Debug.Assert(flagHasSourceMapLocation);
        return storeSourceMapLocation;
      }

    public bool  hasSourceTimeZone()
      {
        return flagHasSourceTimeZone;
      }

    public TimeZoneJSON   getSourceTimeZone()
      {
        Debug.Assert(flagHasSourceTimeZone);
        return storeSourceTimeZone;
      }

    public bool  hasSourceDateTimeSpec()
      {
        return flagHasSourceDateTimeSpec;
      }

    public DateTimeSpecJSON   getSourceDateTimeSpec()
      {
        Debug.Assert(flagHasSourceDateTimeSpec);
        return storeSourceDateTimeSpec;
      }

    public bool  hasDestinationMapLocation()
      {
        return flagHasDestinationMapLocation;
      }

    public MapLocationJSON   getDestinationMapLocation()
      {
        Debug.Assert(flagHasDestinationMapLocation);
        return storeDestinationMapLocation;
      }

    public bool  hasDestinationLocationsAndTimes()
      {
        return flagHasDestinationLocationsAndTimes;
      }

    public int  countOfDestinationLocationsAndTimes()
      {
        Debug.Assert(flagHasDestinationLocationsAndTimes);
        return storeDestinationLocationsAndTimes.Count;
      }

    public LocationAndTimeJSON   elementOfDestinationLocationsAndTimes(int element_num)
      {
        Debug.Assert(flagHasDestinationLocationsAndTimes);
        return storeDestinationLocationsAndTimes[element_num];
      }

    public List< LocationAndTimeJSON  >  getDestinationLocationsAndTimes()
      {
        Debug.Assert(flagHasDestinationLocationsAndTimes);
        return storeDestinationLocationsAndTimes;
      }

    public bool  hasDestinationTimeZone()
      {
        return flagHasDestinationTimeZone;
      }

    public TimeZoneJSON   getDestinationTimeZone()
      {
        Debug.Assert(flagHasDestinationTimeZone);
        return storeDestinationTimeZone;
      }

    public bool  hasDestinationDateTimeSpec()
      {
        return flagHasDestinationDateTimeSpec;
      }

    public DateTimeSpecJSON   getDestinationDateTimeSpec()
      {
        Debug.Assert(flagHasDestinationDateTimeSpec);
        return storeDestinationDateTimeSpec;
      }

    public bool  hasIsDateRequested()
      {
        return flagHasIsDateRequested;
      }

    public bool  getIsDateRequested()
      {
        Debug.Assert(flagHasIsDateRequested);
        return storeIsDateRequested;
      }

    public bool  hasIsTimeInFuture()
      {
        return flagHasIsTimeInFuture;
      }

    public bool  getIsTimeInFuture()
      {
        Debug.Assert(flagHasIsTimeInFuture);
        return storeIsTimeInFuture;
      }

    public bool  hasIsTimeInPast()
      {
        return flagHasIsTimeInPast;
      }

    public bool  getIsTimeInPast()
      {
        Debug.Assert(flagHasIsTimeInPast);
        return storeIsTimeInPast;
      }


    public virtual int extraTimeInLocationInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimeInLocationInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimeInLocationInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimeInLocationInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDateAndTimeInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasSourceMapLocation)
            ++result;
        if (flagHasSourceTimeZone)
            ++result;
        if (flagHasSourceDateTimeSpec)
            ++result;
        if (flagHasDestinationMapLocation)
            ++result;
        if (flagHasDestinationLocationsAndTimes)
            ++result;
        if (flagHasDestinationTimeZone)
            ++result;
        if (flagHasDestinationDateTimeSpec)
            ++result;
        if (flagHasIsDateRequested)
            ++result;
        if (flagHasIsTimeInFuture)
            ++result;
        if (flagHasIsTimeInPast)
            ++result;
        result += extraTimeInLocationInformationNuggetComponentCount();
        return result;
      }
    public override string extraDateAndTimeInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSourceMapLocation)
          {
            if (remainder == 0)
                return "SourceMapLocation";
            --remainder;
          }
        if (flagHasSourceTimeZone)
          {
            if (remainder == 0)
                return "SourceTimeZone";
            --remainder;
          }
        if (flagHasSourceDateTimeSpec)
          {
            if (remainder == 0)
                return "SourceDateTimeSpec";
            --remainder;
          }
        if (flagHasDestinationMapLocation)
          {
            if (remainder == 0)
                return "DestinationMapLocation";
            --remainder;
          }
        if (flagHasDestinationLocationsAndTimes)
          {
            if (remainder == 0)
                return "DestinationLocationsAndTimes";
            --remainder;
          }
        if (flagHasDestinationTimeZone)
          {
            if (remainder == 0)
                return "DestinationTimeZone";
            --remainder;
          }
        if (flagHasDestinationDateTimeSpec)
          {
            if (remainder == 0)
                return "DestinationDateTimeSpec";
            --remainder;
          }
        if (flagHasIsDateRequested)
          {
            if (remainder == 0)
                return "IsDateRequested";
            --remainder;
          }
        if (flagHasIsTimeInFuture)
          {
            if (remainder == 0)
                return "IsTimeInFuture";
            --remainder;
          }
        if (flagHasIsTimeInPast)
          {
            if (remainder == 0)
                return "IsTimeInPast";
            --remainder;
          }
        return extraTimeInLocationInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSourceMapLocation)
          {
            if (remainder == 0)
                return extraSourceMapLocationToJSON();
            --remainder;
          }
        if (flagHasSourceTimeZone)
          {
            if (remainder == 0)
                return extraSourceTimeZoneToJSON();
            --remainder;
          }
        if (flagHasSourceDateTimeSpec)
          {
            if (remainder == 0)
                return extraSourceDateTimeSpecToJSON();
            --remainder;
          }
        if (flagHasDestinationMapLocation)
          {
            if (remainder == 0)
                return extraDestinationMapLocationToJSON();
            --remainder;
          }
        if (flagHasDestinationLocationsAndTimes)
          {
            if (remainder == 0)
                return extraDestinationLocationsAndTimesToJSON();
            --remainder;
          }
        if (flagHasDestinationTimeZone)
          {
            if (remainder == 0)
                return extraDestinationTimeZoneToJSON();
            --remainder;
          }
        if (flagHasDestinationDateTimeSpec)
          {
            if (remainder == 0)
                return extraDestinationDateTimeSpecToJSON();
            --remainder;
          }
        if (flagHasIsDateRequested)
          {
            if (remainder == 0)
                return extraIsDateRequestedToJSON();
            --remainder;
          }
        if (flagHasIsTimeInFuture)
          {
            if (remainder == 0)
                return extraIsTimeInFutureToJSON();
            --remainder;
          }
        if (flagHasIsTimeInPast)
          {
            if (remainder == 0)
                return extraIsTimeInPastToJSON();
            --remainder;
          }
        return extraTimeInLocationInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if (String.Compare(field_name, 1, "estination", 0, 10, false) == 0)
                  {
                    switch (field_name[11])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 12, "ateTimeSpec", 0, 11, false) == 0) && (field_name.Length == 23))
                                return (flagHasDestinationDateTimeSpec ? extraDestinationDateTimeSpecToJSON() : null);
                            break;
                        case 'L':
                            if ((String.Compare(field_name, 12, "ocationsAndTimes", 0, 16, false) == 0) && (field_name.Length == 28))
                                return (flagHasDestinationLocationsAndTimes ? extraDestinationLocationsAndTimesToJSON() : null);
                            break;
                        case 'M':
                            if ((String.Compare(field_name, 12, "apLocation", 0, 10, false) == 0) && (field_name.Length == 22))
                                return (flagHasDestinationMapLocation ? extraDestinationMapLocationToJSON() : null);
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 12, "imeZone", 0, 7, false) == 0) && (field_name.Length == 19))
                                return (flagHasDestinationTimeZone ? extraDestinationTimeZoneToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                  {
                    switch (field_name[2])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 3, "ateRequested", 0, 12, false) == 0) && (field_name.Length == 15))
                                return (flagHasIsDateRequested ? extraIsDateRequestedToJSON() : null);
                            break;
                        case 'T':
                            if (String.Compare(field_name, 3, "imeIn", 0, 5, false) == 0)
                              {
                                switch (field_name[8])
                                  {
                                    case 'F':
                                        if ((String.Compare(field_name, 9, "uture", 0, 5, false) == 0) && (field_name.Length == 14))
                                            return (flagHasIsTimeInFuture ? extraIsTimeInFutureToJSON() : null);
                                        break;
                                    case 'P':
                                        if ((String.Compare(field_name, 9, "ast", 0, 3, false) == 0) && (field_name.Length == 12))
                                            return (flagHasIsTimeInPast ? extraIsTimeInPastToJSON() : null);
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
            case 'S':
                if (String.Compare(field_name, 1, "ource", 0, 5, false) == 0)
                  {
                    switch (field_name[6])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 7, "ateTimeSpec", 0, 11, false) == 0) && (field_name.Length == 18))
                                return (flagHasSourceDateTimeSpec ? extraSourceDateTimeSpecToJSON() : null);
                            break;
                        case 'M':
                            if ((String.Compare(field_name, 7, "apLocation", 0, 10, false) == 0) && (field_name.Length == 17))
                                return (flagHasSourceMapLocation ? extraSourceMapLocationToJSON() : null);
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 7, "imeZone", 0, 7, false) == 0) && (field_name.Length == 14))
                                return (flagHasSourceTimeZone ? extraSourceTimeZoneToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraTimeInLocationInformationNuggetLookup(field_name);
      }

    public void setSourceMapLocation(MapLocationJSON  new_value)
      {
        if (flagHasSourceMapLocation)
          {
          }
        flagHasSourceMapLocation = true;
        storeSourceMapLocation = new_value;
      }
    public void unsetSourceMapLocation()
      {
        if (flagHasSourceMapLocation)
          {
          }
        flagHasSourceMapLocation = false;
      }
    public void setSourceTimeZone(TimeZoneJSON  new_value)
      {
        if (flagHasSourceTimeZone)
          {
          }
        flagHasSourceTimeZone = true;
        storeSourceTimeZone = new_value;
      }
    public void unsetSourceTimeZone()
      {
        if (flagHasSourceTimeZone)
          {
          }
        flagHasSourceTimeZone = false;
      }
    public void setSourceDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasSourceDateTimeSpec)
          {
          }
        flagHasSourceDateTimeSpec = true;
        storeSourceDateTimeSpec = new_value;
      }
    public void unsetSourceDateTimeSpec()
      {
        if (flagHasSourceDateTimeSpec)
          {
          }
        flagHasSourceDateTimeSpec = false;
      }
    public void setDestinationMapLocation(MapLocationJSON  new_value)
      {
        if (flagHasDestinationMapLocation)
          {
          }
        flagHasDestinationMapLocation = true;
        storeDestinationMapLocation = new_value;
      }
    public void unsetDestinationMapLocation()
      {
        if (flagHasDestinationMapLocation)
          {
          }
        flagHasDestinationMapLocation = false;
      }
    public void initDestinationLocationsAndTimes()
      {
        if (flagHasDestinationLocationsAndTimes)
          {
            for (int num1 = 0; num1 < storeDestinationLocationsAndTimes.Count; ++num1)
              {
              }
          }
        flagHasDestinationLocationsAndTimes = true;
        storeDestinationLocationsAndTimes.Clear();
      }
    public void appendDestinationLocationsAndTimes(LocationAndTimeJSON  to_append)
      {
        if (!flagHasDestinationLocationsAndTimes)
          {
            flagHasDestinationLocationsAndTimes = true;
            storeDestinationLocationsAndTimes.Clear();
          }
        Debug.Assert(flagHasDestinationLocationsAndTimes);
        storeDestinationLocationsAndTimes.Add(to_append);
      }
    public void unsetDestinationLocationsAndTimes()
      {
        if (flagHasDestinationLocationsAndTimes)
          {
            for (int num2 = 0; num2 < storeDestinationLocationsAndTimes.Count; ++num2)
              {
              }
          }
        flagHasDestinationLocationsAndTimes = false;
        storeDestinationLocationsAndTimes.Clear();
      }
    public void setDestinationTimeZone(TimeZoneJSON  new_value)
      {
        if (flagHasDestinationTimeZone)
          {
          }
        flagHasDestinationTimeZone = true;
        storeDestinationTimeZone = new_value;
      }
    public void unsetDestinationTimeZone()
      {
        if (flagHasDestinationTimeZone)
          {
          }
        flagHasDestinationTimeZone = false;
      }
    public void setDestinationDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasDestinationDateTimeSpec)
          {
          }
        flagHasDestinationDateTimeSpec = true;
        storeDestinationDateTimeSpec = new_value;
      }
    public void unsetDestinationDateTimeSpec()
      {
        if (flagHasDestinationDateTimeSpec)
          {
          }
        flagHasDestinationDateTimeSpec = false;
      }
    public void setIsDateRequested(bool new_value)
      {
        flagHasIsDateRequested = true;
        storeIsDateRequested = new_value;
      }
    public void unsetIsDateRequested()
      {
        flagHasIsDateRequested = false;
      }
    public void setIsTimeInFuture(bool new_value)
      {
        flagHasIsTimeInFuture = true;
        storeIsTimeInFuture = new_value;
      }
    public void unsetIsTimeInFuture()
      {
        flagHasIsTimeInFuture = false;
      }
    public void setIsTimeInPast(bool new_value)
      {
        flagHasIsTimeInPast = true;
        storeIsTimeInPast = new_value;
      }
    public void unsetIsTimeInPast()
      {
        flagHasIsTimeInPast = false;
      }

    public virtual void extraTimeInLocationInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimeInLocationInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimeInLocationInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraTimeInLocationInformationNuggetAppendPair(key, new_component);
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
    public override void extraDateAndTimeInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if (String.Compare(key, 1, "estination", 0, 10, false) == 0)
                  {
                    switch (key[11])
                      {
                        case 'D':
                            if ((String.Compare(key, 12, "ateTimeSpec", 0, 11, false) == 0) && (key.Length == 23))
                                {
                                fromJSONDestinationDateTimeSpec(new_component, false);
                                return;
                                }
                            break;
                        case 'L':
                            if ((String.Compare(key, 12, "ocationsAndTimes", 0, 16, false) == 0) && (key.Length == 28))
                                {
                                fromJSONDestinationLocationsAndTimes(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 12, "apLocation", 0, 10, false) == 0) && (key.Length == 22))
                                {
                                fromJSONDestinationMapLocation(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 12, "imeZone", 0, 7, false) == 0) && (key.Length == 19))
                                {
                                fromJSONDestinationTimeZone(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if (String.Compare(key, 1, "s", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'D':
                            if ((String.Compare(key, 3, "ateRequested", 0, 12, false) == 0) && (key.Length == 15))
                                {
                                fromJSONIsDateRequested(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if (String.Compare(key, 3, "imeIn", 0, 5, false) == 0)
                              {
                                switch (key[8])
                                  {
                                    case 'F':
                                        if ((String.Compare(key, 9, "uture", 0, 5, false) == 0) && (key.Length == 14))
                                            {
                                            fromJSONIsTimeInFuture(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'P':
                                        if ((String.Compare(key, 9, "ast", 0, 3, false) == 0) && (key.Length == 12))
                                            {
                                            fromJSONIsTimeInPast(new_component, false);
                                            return;
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
            case 'S':
                if (String.Compare(key, 1, "ource", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'D':
                            if ((String.Compare(key, 7, "ateTimeSpec", 0, 11, false) == 0) && (key.Length == 18))
                                {
                                fromJSONSourceDateTimeSpec(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 7, "apLocation", 0, 10, false) == 0) && (key.Length == 17))
                                {
                                fromJSONSourceMapLocation(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 7, "imeZone", 0, 7, false) == 0) && (key.Length == 14))
                                {
                                fromJSONSourceTimeZone(new_component, false);
                                return;
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
        extraTimeInLocationInformationNuggetAppendPair(key, new_component);
      }
    public override void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if (String.Compare(key, 1, "estination", 0, 10, false) == 0)
                  {
                    switch (key[11])
                      {
                        case 'D':
                            if ((String.Compare(key, 12, "ateTimeSpec", 0, 11, false) == 0) && (key.Length == 23))
                                {
                                fromJSONDestinationDateTimeSpec(new_component, false);
                                return;
                                }
                            break;
                        case 'L':
                            if ((String.Compare(key, 12, "ocationsAndTimes", 0, 16, false) == 0) && (key.Length == 28))
                                {
                                fromJSONDestinationLocationsAndTimes(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 12, "apLocation", 0, 10, false) == 0) && (key.Length == 22))
                                {
                                fromJSONDestinationMapLocation(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 12, "imeZone", 0, 7, false) == 0) && (key.Length == 19))
                                {
                                fromJSONDestinationTimeZone(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if (String.Compare(key, 1, "s", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'D':
                            if ((String.Compare(key, 3, "ateRequested", 0, 12, false) == 0) && (key.Length == 15))
                                {
                                fromJSONIsDateRequested(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if (String.Compare(key, 3, "imeIn", 0, 5, false) == 0)
                              {
                                switch (key[8])
                                  {
                                    case 'F':
                                        if ((String.Compare(key, 9, "uture", 0, 5, false) == 0) && (key.Length == 14))
                                            {
                                            fromJSONIsTimeInFuture(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'P':
                                        if ((String.Compare(key, 9, "ast", 0, 3, false) == 0) && (key.Length == 12))
                                            {
                                            fromJSONIsTimeInPast(new_component, false);
                                            return;
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
            case 'S':
                if (String.Compare(key, 1, "ource", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'D':
                            if ((String.Compare(key, 7, "ateTimeSpec", 0, 11, false) == 0) && (key.Length == 18))
                                {
                                fromJSONSourceDateTimeSpec(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 7, "apLocation", 0, 10, false) == 0) && (key.Length == 17))
                                {
                                fromJSONSourceMapLocation(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 7, "imeZone", 0, 7, false) == 0) && (key.Length == 14))
                                {
                                fromJSONSourceTimeZone(new_component, false);
                                return;
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
        extraTimeInLocationInformationNuggetSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        if (flagHasSourceMapLocation)
          {
            handler.start_pair("SourceMapLocation");
            if (partial_allowed)
                storeSourceMapLocation.write_partial_as_json(handler);
            else
                storeSourceMapLocation.write_as_json(handler);
          }
        if (flagHasSourceTimeZone)
          {
            handler.start_pair("SourceTimeZone");
            if (partial_allowed)
                storeSourceTimeZone.write_partial_as_json(handler);
            else
                storeSourceTimeZone.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasSourceDateTimeSpec);
        if (flagHasSourceDateTimeSpec)
          {
            handler.start_pair("SourceDateTimeSpec");
            if (partial_allowed)
                storeSourceDateTimeSpec.write_partial_as_json(handler);
            else
                storeSourceDateTimeSpec.write_as_json(handler);
          }
        if (flagHasDestinationMapLocation)
          {
            handler.start_pair("DestinationMapLocation");
            if (partial_allowed)
                storeDestinationMapLocation.write_partial_as_json(handler);
            else
                storeDestinationMapLocation.write_as_json(handler);
          }
        if (flagHasDestinationLocationsAndTimes)
          {
            handler.start_pair("DestinationLocationsAndTimes");
            Debug.Assert(storeDestinationLocationsAndTimes.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeDestinationLocationsAndTimes.Count; ++num1)
              {
                if (partial_allowed)
                    storeDestinationLocationsAndTimes[num1].write_partial_as_json(handler);
                else
                    storeDestinationLocationsAndTimes[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDestinationTimeZone)
          {
            handler.start_pair("DestinationTimeZone");
            if (partial_allowed)
                storeDestinationTimeZone.write_partial_as_json(handler);
            else
                storeDestinationTimeZone.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDestinationDateTimeSpec);
        if (flagHasDestinationDateTimeSpec)
          {
            handler.start_pair("DestinationDateTimeSpec");
            if (partial_allowed)
                storeDestinationDateTimeSpec.write_partial_as_json(handler);
            else
                storeDestinationDateTimeSpec.write_as_json(handler);
          }
        if (flagHasIsDateRequested)
          {
            handler.start_pair("IsDateRequested");
            handler.boolean_value(storeIsDateRequested);
          }
        if (flagHasIsTimeInFuture)
          {
            handler.start_pair("IsTimeInFuture");
            handler.boolean_value(storeIsTimeInFuture);
          }
        if (flagHasIsTimeInPast)
          {
            handler.start_pair("IsTimeInPast");
            handler.boolean_value(storeIsTimeInPast);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasSourceDateTimeSpec()))
          {
            return "When parsing the object for %what%, the \"SourceDateTimeSpec\" field was missing.";
          }
        if (!(hasDestinationDateTimeSpec()))
          {
            return "When parsing the object for %what%, the \"DestinationDateTimeSpec\" field was missing.";
          }
        return null;
      }

    public static new TimeInLocationInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeInLocationInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeInLocationInformationNugget", ignore_extras);
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
    public static new TimeInLocationInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimeInLocationInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeInLocationInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeInLocationInformationNugget", ignore_extras);
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
    public static new TimeInLocationInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimeInLocationInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        TimeInLocationInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeInLocationInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimeInLocationInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TimeInLocationInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimeInLocationInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeInLocationInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DateAndTimeInformationNuggetJSON.Generator
      {
        private MapLocationJSON.HoldingGenerator fieldGeneratorSourceMapLocation;
        private TimeZoneJSON.HoldingGenerator fieldGeneratorSourceTimeZone;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorSourceDateTimeSpec;
        private MapLocationJSON.HoldingGenerator fieldGeneratorDestinationMapLocation;
        private LocationAndTimeJSON.HoldingArrayGenerator fieldGeneratorDestinationLocationsAndTimes;
        private TimeZoneJSON.HoldingGenerator fieldGeneratorDestinationTimeZone;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorDestinationDateTimeSpec;
        private JSONHoldingBooleanGenerator fieldGeneratorIsDateRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorIsTimeInFuture;
        private JSONHoldingBooleanGenerator fieldGeneratorIsTimeInPast;
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
            if (!(getDateAndTimeInformationNuggetJSONKey().Equals("TimeInLocation")))
                throw new Exception("The key field has a value other than `TimeInLocation'.");
            TimeInLocationInformationNuggetJSON result = new TimeInLocationInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimeInLocationInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DateAndTimeInformationNuggetJSON new_result)
          {
            handle_result((TimeInLocationInformationNuggetJSON )new_result);
          }
        protected void finish(TimeInLocationInformationNuggetJSON result)
          {
            if (fieldGeneratorSourceMapLocation.have_value)
              {
                result.setSourceMapLocation(fieldGeneratorSourceMapLocation.value);
                fieldGeneratorSourceMapLocation.have_value = false;
              }
            if (fieldGeneratorSourceTimeZone.have_value)
              {
                result.setSourceTimeZone(fieldGeneratorSourceTimeZone.value);
                fieldGeneratorSourceTimeZone.have_value = false;
              }
            if (fieldGeneratorSourceDateTimeSpec.have_value)
              {
                result.setSourceDateTimeSpec(fieldGeneratorSourceDateTimeSpec.value);
                fieldGeneratorSourceDateTimeSpec.have_value = false;
              }
            else if ((!(result.hasSourceDateTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SourceDateTimeSpec\" field was missing.");
              }
            if (fieldGeneratorDestinationMapLocation.have_value)
              {
                result.setDestinationMapLocation(fieldGeneratorDestinationMapLocation.value);
                fieldGeneratorDestinationMapLocation.have_value = false;
              }
            if (fieldGeneratorDestinationLocationsAndTimes.have_value)
              {
                result.initDestinationLocationsAndTimes();
                int count = fieldGeneratorDestinationLocationsAndTimes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDestinationLocationsAndTimes(fieldGeneratorDestinationLocationsAndTimes.value[num]);
                  }
                fieldGeneratorDestinationLocationsAndTimes.value.Clear();
                fieldGeneratorDestinationLocationsAndTimes.have_value = false;
              }
            if (fieldGeneratorDestinationTimeZone.have_value)
              {
                result.setDestinationTimeZone(fieldGeneratorDestinationTimeZone.value);
                fieldGeneratorDestinationTimeZone.have_value = false;
              }
            if (fieldGeneratorDestinationDateTimeSpec.have_value)
              {
                result.setDestinationDateTimeSpec(fieldGeneratorDestinationDateTimeSpec.value);
                fieldGeneratorDestinationDateTimeSpec.have_value = false;
              }
            else if ((!(result.hasDestinationDateTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DestinationDateTimeSpec\" field was missing.");
              }
            if (fieldGeneratorIsDateRequested.have_value)
              {
                result.setIsDateRequested(fieldGeneratorIsDateRequested.value);
                fieldGeneratorIsDateRequested.have_value = false;
              }
            if (fieldGeneratorIsTimeInFuture.have_value)
              {
                result.setIsTimeInFuture(fieldGeneratorIsTimeInFuture.value);
                fieldGeneratorIsTimeInFuture.have_value = false;
              }
            if (fieldGeneratorIsTimeInPast.have_value)
              {
                result.setIsTimeInPast(fieldGeneratorIsTimeInPast.value);
                fieldGeneratorIsTimeInPast.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(TimeInLocationInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "estination", 0, 10, false) == 0)
                      {
                        switch (field_name[11])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 12, "ateTimeSpec", 0, 11, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorDestinationDateTimeSpec;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 12, "ocationsAndTimes", 0, 16, false) == 0) && (field_name.Length == 28))
                                    return fieldGeneratorDestinationLocationsAndTimes;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 12, "apLocation", 0, 10, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorDestinationMapLocation;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 12, "imeZone", 0, 7, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorDestinationTimeZone;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 3, "ateRequested", 0, 12, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorIsDateRequested;
                                break;
                            case 'T':
                                if (String.Compare(field_name, 3, "imeIn", 0, 5, false) == 0)
                                  {
                                    switch (field_name[8])
                                      {
                                        case 'F':
                                            if ((String.Compare(field_name, 9, "uture", 0, 5, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorIsTimeInFuture;
                                            break;
                                        case 'P':
                                            if ((String.Compare(field_name, 9, "ast", 0, 3, false) == 0) && (field_name.Length == 12))
                                                return fieldGeneratorIsTimeInPast;
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
                case 'S':
                    if (String.Compare(field_name, 1, "ource", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 7, "ateTimeSpec", 0, 11, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorSourceDateTimeSpec;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 7, "apLocation", 0, 10, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorSourceMapLocation;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 7, "imeZone", 0, 7, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorSourceTimeZone;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSourceMapLocation = new MapLocationJSON.HoldingGenerator("field \"SourceMapLocation\" of the TimeInLocationInformationNugget class", ignore_extras);
            fieldGeneratorSourceTimeZone = new TimeZoneJSON.HoldingGenerator("field \"SourceTimeZone\" of the TimeInLocationInformationNugget class", ignore_extras);
            fieldGeneratorSourceDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"SourceDateTimeSpec\" of the TimeInLocationInformationNugget class", ignore_extras);
            fieldGeneratorDestinationMapLocation = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocation\" of the TimeInLocationInformationNugget class", ignore_extras);
            fieldGeneratorDestinationLocationsAndTimes = new LocationAndTimeJSON.HoldingArrayGenerator("field \"DestinationLocationsAndTimes\" of the TimeInLocationInformationNugget class", ignore_extras);
            fieldGeneratorDestinationTimeZone = new TimeZoneJSON.HoldingGenerator("field \"DestinationTimeZone\" of the TimeInLocationInformationNugget class", ignore_extras);
            fieldGeneratorDestinationDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"DestinationDateTimeSpec\" of the TimeInLocationInformationNugget class", ignore_extras);
            fieldGeneratorIsDateRequested = new JSONHoldingBooleanGenerator("field \"IsDateRequested\" of the TimeInLocationInformationNugget class");
            fieldGeneratorIsTimeInFuture = new JSONHoldingBooleanGenerator("field \"IsTimeInFuture\" of the TimeInLocationInformationNugget class");
            fieldGeneratorIsTimeInPast = new JSONHoldingBooleanGenerator("field \"IsTimeInPast\" of the TimeInLocationInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimeInLocationInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSourceMapLocation = new MapLocationJSON.HoldingGenerator("field \"SourceMapLocation\" of the TimeInLocationInformationNugget class", false);
            fieldGeneratorSourceTimeZone = new TimeZoneJSON.HoldingGenerator("field \"SourceTimeZone\" of the TimeInLocationInformationNugget class", false);
            fieldGeneratorSourceDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"SourceDateTimeSpec\" of the TimeInLocationInformationNugget class", false);
            fieldGeneratorDestinationMapLocation = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocation\" of the TimeInLocationInformationNugget class", false);
            fieldGeneratorDestinationLocationsAndTimes = new LocationAndTimeJSON.HoldingArrayGenerator("field \"DestinationLocationsAndTimes\" of the TimeInLocationInformationNugget class", false);
            fieldGeneratorDestinationTimeZone = new TimeZoneJSON.HoldingGenerator("field \"DestinationTimeZone\" of the TimeInLocationInformationNugget class", false);
            fieldGeneratorDestinationDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"DestinationDateTimeSpec\" of the TimeInLocationInformationNugget class", false);
            fieldGeneratorIsDateRequested = new JSONHoldingBooleanGenerator("field \"IsDateRequested\" of the TimeInLocationInformationNugget class");
            fieldGeneratorIsTimeInFuture = new JSONHoldingBooleanGenerator("field \"IsTimeInFuture\" of the TimeInLocationInformationNugget class");
            fieldGeneratorIsTimeInPast = new JSONHoldingBooleanGenerator("field \"IsTimeInPast\" of the TimeInLocationInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimeInLocationInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorSourceMapLocation.reset();
            fieldGeneratorSourceTimeZone.reset();
            fieldGeneratorSourceDateTimeSpec.reset();
            fieldGeneratorDestinationMapLocation.reset();
            fieldGeneratorDestinationLocationsAndTimes.reset();
            fieldGeneratorDestinationTimeZone.reset();
            fieldGeneratorDestinationDateTimeSpec.reset();
            fieldGeneratorIsDateRequested.reset();
            fieldGeneratorIsTimeInFuture.reset();
            fieldGeneratorIsTimeInPast.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TimeInLocationInformationNuggetJSON  result)
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
        public TimeInLocationInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimeInLocationInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<TimeInLocationInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimeInLocationInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimeInLocationInformationNuggetJSON>();
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
    public List<TimeInLocationInformationNuggetJSON> value;
  };
  };
