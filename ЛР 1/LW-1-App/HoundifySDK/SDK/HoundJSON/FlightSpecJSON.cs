/* file "FlightSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightSpecJSON : JSONBase
  {
    private bool flagHasNextFlight;
    private bool storeNextFlight;
    private bool flagHasAirline;
    private AirlineJSON  storeAirline;
    private bool flagHasAdditionalAirlineMatches;
    private List< AirlineJSON  > storeAdditionalAirlineMatches;
    private bool flagHasFlightNumber;
    private short storeFlightNumber;
    private bool flagHasDepartureLocation;
    private FlightTravelLocationJSON  storeDepartureLocation;
    private bool flagHasDestinationLocation;
    private FlightTravelLocationJSON  storeDestinationLocation;
    private bool flagHasTypeOfLastLocationFilter;
    private DepartureOrArrivalJSON  storeTypeOfLastLocationFilter;
    private bool flagHasDepartureDateTimeRange;
    private DateTimeRangeSpecJSON  storeDepartureDateTimeRange;
    private bool flagHasArrivalDateTimeRange;
    private DateTimeRangeSpecJSON  storeArrivalDateTimeRange;
    private bool flagHasEitherDepartureOrArrivalDateTimeRange;
    private DateTimeRangeSpecJSON  storeEitherDepartureOrArrivalDateTimeRange;
    private bool flagHasTypeOfLastDateTimeRangeFilter;
    private DepartureOrArrivalJSON  storeTypeOfLastDateTimeRangeFilter;
    private bool flagHasRequestedFlightAttributes;
    private List< FlightAttributeJSON  > storeRequestedFlightAttributes;
    private bool flagHasRequestedFlightAttributesOpen;
    private List< FlightAttributeOpenJSON  > storeRequestedFlightAttributesOpen;
    private bool flagHasDepartureTimeFormat;
    private FlightTimeFormatJSON  storeDepartureTimeFormat;
    private bool flagHasBoardingTimeFormat;
    private FlightTimeFormatJSON  storeBoardingTimeFormat;
    private bool flagHasArrivalTimeFormat;
    private FlightTimeFormatJSON  storeArrivalTimeFormat;
    private bool flagHasSpoken;
    private string storeSpoken;
    private bool flagHasWritten;
    private string storeWritten;
    private bool flagHasModeInteractionDisabled;
    private bool storeModeInteractionDisabled;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONNextFlight(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NextFlight of FlightSpecJSON is not true for false.");
              }
          }
        setNextFlight(the_bool);
      }


    private void  fromJSONAirline(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AirlineJSON convert_classy = AirlineJSON.from_json(json_value, ignore_extras, true);
        setAirline(convert_classy);
      }


    private void  fromJSONAdditionalAirlineMatches(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AdditionalAirlineMatches of FlightSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AirlineJSON  > vector_AdditionalAirlineMatches1 = new List< AirlineJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AirlineJSON convert_classy = AirlineJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AdditionalAirlineMatches1.Add(convert_classy);
          }
        initAdditionalAirlineMatches();
        for (int num1 = 0; num1 < vector_AdditionalAirlineMatches1.Count; ++num1)
            appendAdditionalAirlineMatches(vector_AdditionalAirlineMatches1[num1]);
        for (int num1 = 0; num1 < vector_AdditionalAirlineMatches1.Count; ++num1)
          {
          }
      }


    private void  fromJSONFlightNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        short extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FlightNumber of FlightSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FlightNumber of FlightSpecJSON is not an integer.");
              }
            extracted_integer = (short)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (short)(json_integer.getLongInt())        ;
          }
        setFlightNumber(extracted_integer);
      }


    private void  fromJSONDepartureLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTravelLocationJSON convert_classy = FlightTravelLocationJSON.from_json(json_value, ignore_extras, true);
        setDepartureLocation(convert_classy);
      }


    private void  fromJSONDestinationLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTravelLocationJSON convert_classy = FlightTravelLocationJSON.from_json(json_value, ignore_extras, true);
        setDestinationLocation(convert_classy);
      }


    private void  fromJSONTypeOfLastLocationFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DepartureOrArrivalJSON convert_classy = DepartureOrArrivalJSON.from_json(json_value, ignore_extras, true);
        setTypeOfLastLocationFilter(convert_classy);
      }


    private void  fromJSONDepartureDateTimeRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDepartureDateTimeRange(convert_classy);
      }


    private void  fromJSONArrivalDateTimeRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setArrivalDateTimeRange(convert_classy);
      }


    private void  fromJSONEitherDepartureOrArrivalDateTimeRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setEitherDepartureOrArrivalDateTimeRange(convert_classy);
      }


    private void  fromJSONTypeOfLastDateTimeRangeFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DepartureOrArrivalJSON convert_classy = DepartureOrArrivalJSON.from_json(json_value, ignore_extras, true);
        setTypeOfLastDateTimeRangeFilter(convert_classy);
      }


    private void  fromJSONRequestedFlightAttributes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequestedFlightAttributes of FlightSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field RequestedFlightAttributes of FlightSpecJSON has too few elements.");
        List< FlightAttributeJSON  > vector_RequestedFlightAttributes1 = new List< FlightAttributeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightAttributeJSON convert_classy = FlightAttributeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RequestedFlightAttributes1.Add(convert_classy);
          }
        Debug.Assert(vector_RequestedFlightAttributes1.Count >= 1);
        initRequestedFlightAttributes();
        for (int num2 = 0; num2 < vector_RequestedFlightAttributes1.Count; ++num2)
            appendRequestedFlightAttributes(vector_RequestedFlightAttributes1[num2]);
        for (int num1 = 0; num1 < vector_RequestedFlightAttributes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestedFlightAttributesOpen(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequestedFlightAttributesOpen of FlightSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field RequestedFlightAttributesOpen of FlightSpecJSON has too few elements.");
        List< FlightAttributeOpenJSON  > vector_RequestedFlightAttributesOpen1 = new List< FlightAttributeOpenJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightAttributeOpenJSON convert_classy = FlightAttributeOpenJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RequestedFlightAttributesOpen1.Add(convert_classy);
          }
        Debug.Assert(vector_RequestedFlightAttributesOpen1.Count >= 1);
        initRequestedFlightAttributesOpen();
        for (int num3 = 0; num3 < vector_RequestedFlightAttributesOpen1.Count; ++num3)
            appendRequestedFlightAttributesOpen(vector_RequestedFlightAttributesOpen1[num3]);
        for (int num1 = 0; num1 < vector_RequestedFlightAttributesOpen1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDepartureTimeFormat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimeFormatJSON convert_classy = FlightTimeFormatJSON.from_json(json_value, ignore_extras, true);
        setDepartureTimeFormat(convert_classy);
      }


    private void  fromJSONBoardingTimeFormat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimeFormatJSON convert_classy = FlightTimeFormatJSON.from_json(json_value, ignore_extras, true);
        setBoardingTimeFormat(convert_classy);
      }


    private void  fromJSONArrivalTimeFormat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimeFormatJSON convert_classy = FlightTimeFormatJSON.from_json(json_value, ignore_extras, true);
        setArrivalTimeFormat(convert_classy);
      }


    private void  fromJSONSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Spoken of FlightSpecJSON is not a string.");
        setSpoken(json_string.getData());
      }


    private void  fromJSONWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Written of FlightSpecJSON is not a string.");
        setWritten(json_string.getData());
      }


    private void  fromJSONModeInteractionDisabled(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ModeInteractionDisabled of FlightSpecJSON is not true for false.");
              }
          }
        setModeInteractionDisabled(the_bool);
      }


    public FlightSpecJSON()
      {
        flagHasNextFlight = false;
        flagHasAirline = false;
        flagHasAdditionalAirlineMatches = false;
        flagHasFlightNumber = false;
        flagHasDepartureLocation = false;
        flagHasDestinationLocation = false;
        flagHasTypeOfLastLocationFilter = false;
        flagHasDepartureDateTimeRange = false;
        flagHasArrivalDateTimeRange = false;
        flagHasEitherDepartureOrArrivalDateTimeRange = false;
        flagHasTypeOfLastDateTimeRangeFilter = false;
        flagHasRequestedFlightAttributes = false;
        flagHasRequestedFlightAttributesOpen = false;
        flagHasDepartureTimeFormat = false;
        flagHasBoardingTimeFormat = false;
        flagHasArrivalTimeFormat = false;
        flagHasSpoken = false;
        flagHasWritten = false;
        flagHasModeInteractionDisabled = false;
        storeAdditionalAirlineMatches = new List< AirlineJSON  >();
        storeRequestedFlightAttributes = new List< FlightAttributeJSON  >();
        storeRequestedFlightAttributesOpen = new List< FlightAttributeOpenJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasNextFlight()
      {
        return flagHasNextFlight;
      }

    public bool  getNextFlight()
      {
        Debug.Assert(flagHasNextFlight);
        return storeNextFlight;
      }

    public bool  hasAirline()
      {
        return flagHasAirline;
      }

    public AirlineJSON   getAirline()
      {
        Debug.Assert(flagHasAirline);
        return storeAirline;
      }

    public bool  hasAdditionalAirlineMatches()
      {
        return flagHasAdditionalAirlineMatches;
      }

    public int  countOfAdditionalAirlineMatches()
      {
        Debug.Assert(flagHasAdditionalAirlineMatches);
        return storeAdditionalAirlineMatches.Count;
      }

    public AirlineJSON   elementOfAdditionalAirlineMatches(int element_num)
      {
        Debug.Assert(flagHasAdditionalAirlineMatches);
        return storeAdditionalAirlineMatches[element_num];
      }

    public List< AirlineJSON  >  getAdditionalAirlineMatches()
      {
        Debug.Assert(flagHasAdditionalAirlineMatches);
        return storeAdditionalAirlineMatches;
      }

    public bool  hasFlightNumber()
      {
        return flagHasFlightNumber;
      }

    public short  getFlightNumber()
      {
        Debug.Assert(flagHasFlightNumber);
        return storeFlightNumber;
      }

    public bool  hasDepartureLocation()
      {
        return flagHasDepartureLocation;
      }

    public FlightTravelLocationJSON   getDepartureLocation()
      {
        Debug.Assert(flagHasDepartureLocation);
        return storeDepartureLocation;
      }

    public bool  hasDestinationLocation()
      {
        return flagHasDestinationLocation;
      }

    public FlightTravelLocationJSON   getDestinationLocation()
      {
        Debug.Assert(flagHasDestinationLocation);
        return storeDestinationLocation;
      }

    public bool  hasTypeOfLastLocationFilter()
      {
        return flagHasTypeOfLastLocationFilter;
      }

    public DepartureOrArrivalJSON   getTypeOfLastLocationFilter()
      {
        Debug.Assert(flagHasTypeOfLastLocationFilter);
        return storeTypeOfLastLocationFilter;
      }

    public DepartureOrArrivalJSON.TypeValue  getTypeOfLastLocationFilterValue()
      {
        return getTypeOfLastLocationFilter().getValue();
      }

    public string  getTypeOfLastLocationFilterAsString()
      {
        return getTypeOfLastLocationFilter().getValueAsString();
      }

    public bool  hasDepartureDateTimeRange()
      {
        return flagHasDepartureDateTimeRange;
      }

    public DateTimeRangeSpecJSON   getDepartureDateTimeRange()
      {
        Debug.Assert(flagHasDepartureDateTimeRange);
        return storeDepartureDateTimeRange;
      }

    public bool  hasArrivalDateTimeRange()
      {
        return flagHasArrivalDateTimeRange;
      }

    public DateTimeRangeSpecJSON   getArrivalDateTimeRange()
      {
        Debug.Assert(flagHasArrivalDateTimeRange);
        return storeArrivalDateTimeRange;
      }

    public bool  hasEitherDepartureOrArrivalDateTimeRange()
      {
        return flagHasEitherDepartureOrArrivalDateTimeRange;
      }

    public DateTimeRangeSpecJSON   getEitherDepartureOrArrivalDateTimeRange()
      {
        Debug.Assert(flagHasEitherDepartureOrArrivalDateTimeRange);
        return storeEitherDepartureOrArrivalDateTimeRange;
      }

    public bool  hasTypeOfLastDateTimeRangeFilter()
      {
        return flagHasTypeOfLastDateTimeRangeFilter;
      }

    public DepartureOrArrivalJSON   getTypeOfLastDateTimeRangeFilter()
      {
        Debug.Assert(flagHasTypeOfLastDateTimeRangeFilter);
        return storeTypeOfLastDateTimeRangeFilter;
      }

    public DepartureOrArrivalJSON.TypeValue  getTypeOfLastDateTimeRangeFilterValue()
      {
        return getTypeOfLastDateTimeRangeFilter().getValue();
      }

    public string  getTypeOfLastDateTimeRangeFilterAsString()
      {
        return getTypeOfLastDateTimeRangeFilter().getValueAsString();
      }

    public bool  hasRequestedFlightAttributes()
      {
        return flagHasRequestedFlightAttributes;
      }

    public int  countOfRequestedFlightAttributes()
      {
        Debug.Assert(flagHasRequestedFlightAttributes);
        return storeRequestedFlightAttributes.Count;
      }

    public FlightAttributeJSON   elementOfRequestedFlightAttributes(int element_num)
      {
        Debug.Assert(flagHasRequestedFlightAttributes);
        return storeRequestedFlightAttributes[element_num];
      }

    public List< FlightAttributeJSON  >  getRequestedFlightAttributes()
      {
        Debug.Assert(flagHasRequestedFlightAttributes);
        return storeRequestedFlightAttributes;
      }

    public bool  hasRequestedFlightAttributesOpen()
      {
        return flagHasRequestedFlightAttributesOpen;
      }

    public int  countOfRequestedFlightAttributesOpen()
      {
        Debug.Assert(flagHasRequestedFlightAttributesOpen);
        return storeRequestedFlightAttributesOpen.Count;
      }

    public FlightAttributeOpenJSON   elementOfRequestedFlightAttributesOpen(int element_num)
      {
        Debug.Assert(flagHasRequestedFlightAttributesOpen);
        return storeRequestedFlightAttributesOpen[element_num];
      }

    public List< FlightAttributeOpenJSON  >  getRequestedFlightAttributesOpen()
      {
        Debug.Assert(flagHasRequestedFlightAttributesOpen);
        return storeRequestedFlightAttributesOpen;
      }

    public bool  hasDepartureTimeFormat()
      {
        return flagHasDepartureTimeFormat;
      }

    public FlightTimeFormatJSON   getDepartureTimeFormat()
      {
        Debug.Assert(flagHasDepartureTimeFormat);
        return storeDepartureTimeFormat;
      }

    public bool  hasBoardingTimeFormat()
      {
        return flagHasBoardingTimeFormat;
      }

    public FlightTimeFormatJSON   getBoardingTimeFormat()
      {
        Debug.Assert(flagHasBoardingTimeFormat);
        return storeBoardingTimeFormat;
      }

    public bool  hasArrivalTimeFormat()
      {
        return flagHasArrivalTimeFormat;
      }

    public FlightTimeFormatJSON   getArrivalTimeFormat()
      {
        Debug.Assert(flagHasArrivalTimeFormat);
        return storeArrivalTimeFormat;
      }

    public bool  hasSpoken()
      {
        return flagHasSpoken;
      }

    public string  getSpoken()
      {
        Debug.Assert(flagHasSpoken);
        return storeSpoken;
      }

    public bool  hasWritten()
      {
        return flagHasWritten;
      }

    public string  getWritten()
      {
        Debug.Assert(flagHasWritten);
        return storeWritten;
      }

    public bool  hasModeInteractionDisabled()
      {
        return flagHasModeInteractionDisabled;
      }

    public bool  getModeInteractionDisabled()
      {
        Debug.Assert(flagHasModeInteractionDisabled);
        return storeModeInteractionDisabled;
      }


    public virtual int extraFlightSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setNextFlight(bool new_value)
      {
        flagHasNextFlight = true;
        storeNextFlight = new_value;
      }
    public void unsetNextFlight()
      {
        flagHasNextFlight = false;
      }
    public void setAirline(AirlineJSON  new_value)
      {
        if (flagHasAirline)
          {
          }
        flagHasAirline = true;
        storeAirline = new_value;
      }
    public void unsetAirline()
      {
        if (flagHasAirline)
          {
          }
        flagHasAirline = false;
      }
    public void initAdditionalAirlineMatches()
      {
        if (flagHasAdditionalAirlineMatches)
          {
            for (int num1 = 0; num1 < storeAdditionalAirlineMatches.Count; ++num1)
              {
              }
          }
        flagHasAdditionalAirlineMatches = true;
        storeAdditionalAirlineMatches.Clear();
      }
    public void appendAdditionalAirlineMatches(AirlineJSON  to_append)
      {
        if (!flagHasAdditionalAirlineMatches)
          {
            flagHasAdditionalAirlineMatches = true;
            storeAdditionalAirlineMatches.Clear();
          }
        Debug.Assert(flagHasAdditionalAirlineMatches);
        storeAdditionalAirlineMatches.Add(to_append);
      }
    public void unsetAdditionalAirlineMatches()
      {
        if (flagHasAdditionalAirlineMatches)
          {
            for (int num2 = 0; num2 < storeAdditionalAirlineMatches.Count; ++num2)
              {
              }
          }
        flagHasAdditionalAirlineMatches = false;
        storeAdditionalAirlineMatches.Clear();
      }
    public void setFlightNumber(short new_value)
      {
        flagHasFlightNumber = true;
        if (new_value < 0)
            throw new Exception("The value for field FlightNumber of FlightSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 9999)
            throw new Exception("The value for field FlightNumber of FlightSpecJSON is greater than the upper bound (9999) for that field.");
        storeFlightNumber = new_value;
      }
    public void unsetFlightNumber()
      {
        flagHasFlightNumber = false;
      }
    public void setDepartureLocation(FlightTravelLocationJSON  new_value)
      {
        if (flagHasDepartureLocation)
          {
          }
        flagHasDepartureLocation = true;
        storeDepartureLocation = new_value;
      }
    public void unsetDepartureLocation()
      {
        if (flagHasDepartureLocation)
          {
          }
        flagHasDepartureLocation = false;
      }
    public void setDestinationLocation(FlightTravelLocationJSON  new_value)
      {
        if (flagHasDestinationLocation)
          {
          }
        flagHasDestinationLocation = true;
        storeDestinationLocation = new_value;
      }
    public void unsetDestinationLocation()
      {
        if (flagHasDestinationLocation)
          {
          }
        flagHasDestinationLocation = false;
      }
    public void setTypeOfLastLocationFilter(DepartureOrArrivalJSON  new_value)
      {
        if (flagHasTypeOfLastLocationFilter)
          {
          }
        flagHasTypeOfLastLocationFilter = true;
        storeTypeOfLastLocationFilter = new_value;
      }
    public void setTypeOfLastLocationFilter(DepartureOrArrivalJSON.TypeValue new_value)
      {
        setTypeOfLastLocationFilter(new DepartureOrArrivalJSON(new_value));
      }
    public void setTypeOfLastLocationFilter(string chars)
      {
        setTypeOfLastLocationFilter(new DepartureOrArrivalJSON(chars));
      }
    public void unsetTypeOfLastLocationFilter()
      {
        if (flagHasTypeOfLastLocationFilter)
          {
          }
        flagHasTypeOfLastLocationFilter = false;
      }
    public void setDepartureDateTimeRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasDepartureDateTimeRange)
          {
          }
        flagHasDepartureDateTimeRange = true;
        storeDepartureDateTimeRange = new_value;
      }
    public void unsetDepartureDateTimeRange()
      {
        if (flagHasDepartureDateTimeRange)
          {
          }
        flagHasDepartureDateTimeRange = false;
      }
    public void setArrivalDateTimeRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasArrivalDateTimeRange)
          {
          }
        flagHasArrivalDateTimeRange = true;
        storeArrivalDateTimeRange = new_value;
      }
    public void unsetArrivalDateTimeRange()
      {
        if (flagHasArrivalDateTimeRange)
          {
          }
        flagHasArrivalDateTimeRange = false;
      }
    public void setEitherDepartureOrArrivalDateTimeRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasEitherDepartureOrArrivalDateTimeRange)
          {
          }
        flagHasEitherDepartureOrArrivalDateTimeRange = true;
        storeEitherDepartureOrArrivalDateTimeRange = new_value;
      }
    public void unsetEitherDepartureOrArrivalDateTimeRange()
      {
        if (flagHasEitherDepartureOrArrivalDateTimeRange)
          {
          }
        flagHasEitherDepartureOrArrivalDateTimeRange = false;
      }
    public void setTypeOfLastDateTimeRangeFilter(DepartureOrArrivalJSON  new_value)
      {
        if (flagHasTypeOfLastDateTimeRangeFilter)
          {
          }
        flagHasTypeOfLastDateTimeRangeFilter = true;
        storeTypeOfLastDateTimeRangeFilter = new_value;
      }
    public void setTypeOfLastDateTimeRangeFilter(DepartureOrArrivalJSON.TypeValue new_value)
      {
        setTypeOfLastDateTimeRangeFilter(new DepartureOrArrivalJSON(new_value));
      }
    public void setTypeOfLastDateTimeRangeFilter(string chars)
      {
        setTypeOfLastDateTimeRangeFilter(new DepartureOrArrivalJSON(chars));
      }
    public void unsetTypeOfLastDateTimeRangeFilter()
      {
        if (flagHasTypeOfLastDateTimeRangeFilter)
          {
          }
        flagHasTypeOfLastDateTimeRangeFilter = false;
      }
    public void initRequestedFlightAttributes()
      {
        if (flagHasRequestedFlightAttributes)
          {
            for (int num3 = 0; num3 < storeRequestedFlightAttributes.Count; ++num3)
              {
              }
          }
        flagHasRequestedFlightAttributes = true;
        storeRequestedFlightAttributes.Clear();
      }
    public void appendRequestedFlightAttributes(FlightAttributeJSON  to_append)
      {
        if (!flagHasRequestedFlightAttributes)
          {
            flagHasRequestedFlightAttributes = true;
            storeRequestedFlightAttributes.Clear();
          }
        Debug.Assert(flagHasRequestedFlightAttributes);
        storeRequestedFlightAttributes.Add(to_append);
      }
    public void appendRequestedFlightAttributes(FlightAttributeJSON.TypeValue new_value)
      {
        appendRequestedFlightAttributes(new FlightAttributeJSON(new_value));
      }
    public void appendRequestedFlightAttributes(string chars)
      {
        appendRequestedFlightAttributes(new FlightAttributeJSON(chars));
      }
    public void unsetRequestedFlightAttributes()
      {
        if (flagHasRequestedFlightAttributes)
          {
            for (int num4 = 0; num4 < storeRequestedFlightAttributes.Count; ++num4)
              {
              }
          }
        flagHasRequestedFlightAttributes = false;
        storeRequestedFlightAttributes.Clear();
      }
    public void initRequestedFlightAttributesOpen()
      {
        if (flagHasRequestedFlightAttributesOpen)
          {
            for (int num5 = 0; num5 < storeRequestedFlightAttributesOpen.Count; ++num5)
              {
              }
          }
        flagHasRequestedFlightAttributesOpen = true;
        storeRequestedFlightAttributesOpen.Clear();
      }
    public void appendRequestedFlightAttributesOpen(FlightAttributeOpenJSON  to_append)
      {
        if (!flagHasRequestedFlightAttributesOpen)
          {
            flagHasRequestedFlightAttributesOpen = true;
            storeRequestedFlightAttributesOpen.Clear();
          }
        Debug.Assert(flagHasRequestedFlightAttributesOpen);
        storeRequestedFlightAttributesOpen.Add(to_append);
      }
    public void appendRequestedFlightAttributesOpen(FlightAttributeOpenJSON.TypeValue new_value)
      {
        appendRequestedFlightAttributesOpen(new FlightAttributeOpenJSON(new_value));
      }
    public void appendRequestedFlightAttributesOpen(string chars)
      {
        FlightAttributeOpenJSON.TypeValueKnownValues known = FlightAttributeOpenJSON.stringToValue(chars);
        FlightAttributeOpenJSON.TypeValue new_value = new FlightAttributeOpenJSON.TypeValue();
        if (known == FlightAttributeOpenJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendRequestedFlightAttributesOpen(new_value);
      }
    public void unsetRequestedFlightAttributesOpen()
      {
        if (flagHasRequestedFlightAttributesOpen)
          {
            for (int num6 = 0; num6 < storeRequestedFlightAttributesOpen.Count; ++num6)
              {
              }
          }
        flagHasRequestedFlightAttributesOpen = false;
        storeRequestedFlightAttributesOpen.Clear();
      }
    public void setDepartureTimeFormat(FlightTimeFormatJSON  new_value)
      {
        if (flagHasDepartureTimeFormat)
          {
          }
        flagHasDepartureTimeFormat = true;
        storeDepartureTimeFormat = new_value;
      }
    public void unsetDepartureTimeFormat()
      {
        if (flagHasDepartureTimeFormat)
          {
          }
        flagHasDepartureTimeFormat = false;
      }
    public void setBoardingTimeFormat(FlightTimeFormatJSON  new_value)
      {
        if (flagHasBoardingTimeFormat)
          {
          }
        flagHasBoardingTimeFormat = true;
        storeBoardingTimeFormat = new_value;
      }
    public void unsetBoardingTimeFormat()
      {
        if (flagHasBoardingTimeFormat)
          {
          }
        flagHasBoardingTimeFormat = false;
      }
    public void setArrivalTimeFormat(FlightTimeFormatJSON  new_value)
      {
        if (flagHasArrivalTimeFormat)
          {
          }
        flagHasArrivalTimeFormat = true;
        storeArrivalTimeFormat = new_value;
      }
    public void unsetArrivalTimeFormat()
      {
        if (flagHasArrivalTimeFormat)
          {
          }
        flagHasArrivalTimeFormat = false;
      }
    public void setSpoken(string new_value)
      {
        flagHasSpoken = true;
        storeSpoken = new_value;
      }
    public void unsetSpoken()
      {
        flagHasSpoken = false;
      }
    public void setWritten(string new_value)
      {
        flagHasWritten = true;
        storeWritten = new_value;
      }
    public void unsetWritten()
      {
        flagHasWritten = false;
      }
    public void setModeInteractionDisabled(bool new_value)
      {
        flagHasModeInteractionDisabled = true;
        storeModeInteractionDisabled = new_value;
      }
    public void unsetModeInteractionDisabled()
      {
        flagHasModeInteractionDisabled = false;
      }

    public virtual void extraFlightSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightSpecLookup(key);
        if (old_field == null)
          {
            extraFlightSpecAppendPair(key, new_component);
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
        if (flagHasNextFlight)
          {
            handler.start_pair("NextFlight");
            handler.boolean_value(storeNextFlight);
          }
        if (flagHasAirline)
          {
            handler.start_pair("Airline");
            if (partial_allowed)
                storeAirline.write_partial_as_json(handler);
            else
                storeAirline.write_as_json(handler);
          }
        if (flagHasAdditionalAirlineMatches)
          {
            handler.start_pair("AdditionalAirlineMatches");
            handler.start_array();
            for (int num1 = 0; num1 < storeAdditionalAirlineMatches.Count; ++num1)
              {
                if (partial_allowed)
                    storeAdditionalAirlineMatches[num1].write_partial_as_json(handler);
                else
                    storeAdditionalAirlineMatches[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasFlightNumber)
          {
            handler.start_pair("FlightNumber");
            handler.number_value(storeFlightNumber);
          }
        if (flagHasDepartureLocation)
          {
            handler.start_pair("DepartureLocation");
            if (partial_allowed)
                storeDepartureLocation.write_partial_as_json(handler);
            else
                storeDepartureLocation.write_as_json(handler);
          }
        if (flagHasDestinationLocation)
          {
            handler.start_pair("DestinationLocation");
            if (partial_allowed)
                storeDestinationLocation.write_partial_as_json(handler);
            else
                storeDestinationLocation.write_as_json(handler);
          }
        if (flagHasTypeOfLastLocationFilter)
          {
            handler.start_pair("TypeOfLastLocationFilter");
            if (partial_allowed)
                storeTypeOfLastLocationFilter.write_partial_as_json(handler);
            else
                storeTypeOfLastLocationFilter.write_as_json(handler);
          }
        if (flagHasDepartureDateTimeRange)
          {
            handler.start_pair("DepartureDateTimeRange");
            if (partial_allowed)
                storeDepartureDateTimeRange.write_partial_as_json(handler);
            else
                storeDepartureDateTimeRange.write_as_json(handler);
          }
        if (flagHasArrivalDateTimeRange)
          {
            handler.start_pair("ArrivalDateTimeRange");
            if (partial_allowed)
                storeArrivalDateTimeRange.write_partial_as_json(handler);
            else
                storeArrivalDateTimeRange.write_as_json(handler);
          }
        if (flagHasEitherDepartureOrArrivalDateTimeRange)
          {
            handler.start_pair("EitherDepartureOrArrivalDateTimeRange");
            if (partial_allowed)
                storeEitherDepartureOrArrivalDateTimeRange.write_partial_as_json(handler);
            else
                storeEitherDepartureOrArrivalDateTimeRange.write_as_json(handler);
          }
        if (flagHasTypeOfLastDateTimeRangeFilter)
          {
            handler.start_pair("TypeOfLastDateTimeRangeFilter");
            if (partial_allowed)
                storeTypeOfLastDateTimeRangeFilter.write_partial_as_json(handler);
            else
                storeTypeOfLastDateTimeRangeFilter.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRequestedFlightAttributes);
        if (flagHasRequestedFlightAttributes)
          {
            handler.start_pair("RequestedFlightAttributes");
            Debug.Assert(storeRequestedFlightAttributes.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeRequestedFlightAttributes.Count; ++num2)
              {
                if (partial_allowed)
                    storeRequestedFlightAttributes[num2].write_partial_as_json(handler);
                else
                    storeRequestedFlightAttributes[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRequestedFlightAttributesOpen)
          {
            handler.start_pair("RequestedFlightAttributesOpen");
            Debug.Assert(storeRequestedFlightAttributesOpen.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeRequestedFlightAttributesOpen.Count; ++num3)
              {
                if (partial_allowed)
                    storeRequestedFlightAttributesOpen[num3].write_partial_as_json(handler);
                else
                    storeRequestedFlightAttributesOpen[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDepartureTimeFormat)
          {
            handler.start_pair("DepartureTimeFormat");
            if (partial_allowed)
                storeDepartureTimeFormat.write_partial_as_json(handler);
            else
                storeDepartureTimeFormat.write_as_json(handler);
          }
        if (flagHasBoardingTimeFormat)
          {
            handler.start_pair("BoardingTimeFormat");
            if (partial_allowed)
                storeBoardingTimeFormat.write_partial_as_json(handler);
            else
                storeBoardingTimeFormat.write_as_json(handler);
          }
        if (flagHasArrivalTimeFormat)
          {
            handler.start_pair("ArrivalTimeFormat");
            if (partial_allowed)
                storeArrivalTimeFormat.write_partial_as_json(handler);
            else
                storeArrivalTimeFormat.write_as_json(handler);
          }
        if (flagHasSpoken)
          {
            handler.start_pair("Spoken");
            handler.string_value(storeSpoken);
          }
        if (flagHasWritten)
          {
            handler.start_pair("Written");
            handler.string_value(storeWritten);
          }
        if (flagHasModeInteractionDisabled)
          {
            handler.start_pair("ModeInteractionDisabled");
            handler.boolean_value(storeModeInteractionDisabled);
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
        if (!(hasRequestedFlightAttributes()))
          {
            return "When parsing the object for %what%, the \"RequestedFlightAttributes\" field was missing.";
          }
        return null;
      }

    public static FlightSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSpec", ignore_extras);
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
    public static FlightSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSpec", ignore_extras);
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
    public static FlightSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightSpecJSON from_text(string text, bool ignore_extras)
      {
        FlightSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorNextFlight;
        private AirlineJSON.HoldingGenerator fieldGeneratorAirline;
        private AirlineJSON.HoldingArrayGenerator fieldGeneratorAdditionalAirlineMatches;
    private class FieldHoldingGeneratorFlightNumber : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorFlightNumber(String what) : base(what, 0, 9999)
              {
              }
          };
    private class FieldHoldingArrayGeneratorFlightNumber : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorFlightNumber(String what) : base(what, 0, 9999)
              {
              }
          };
        private FieldHoldingGeneratorFlightNumber fieldGeneratorFlightNumber;
        private FlightTravelLocationJSON.HoldingGenerator fieldGeneratorDepartureLocation;
        private FlightTravelLocationJSON.HoldingGenerator fieldGeneratorDestinationLocation;
        private DepartureOrArrivalJSON.HoldingGenerator fieldGeneratorTypeOfLastLocationFilter;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDepartureDateTimeRange;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorArrivalDateTimeRange;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorEitherDepartureOrArrivalDateTimeRange;
        private DepartureOrArrivalJSON.HoldingGenerator fieldGeneratorTypeOfLastDateTimeRangeFilter;
        private FlightAttributeJSON.HoldingArrayGenerator fieldGeneratorRequestedFlightAttributes;
        private FlightAttributeOpenJSON.HoldingArrayGenerator fieldGeneratorRequestedFlightAttributesOpen;
        private FlightTimeFormatJSON.HoldingGenerator fieldGeneratorDepartureTimeFormat;
        private FlightTimeFormatJSON.HoldingGenerator fieldGeneratorBoardingTimeFormat;
        private FlightTimeFormatJSON.HoldingGenerator fieldGeneratorArrivalTimeFormat;
        private JSONHoldingStringGenerator fieldGeneratorSpoken;
        private JSONHoldingStringGenerator fieldGeneratorWritten;
        private JSONHoldingBooleanGenerator fieldGeneratorModeInteractionDisabled;
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
            FlightSpecJSON result = new FlightSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightSpecJSON result)
          {
            if (fieldGeneratorNextFlight.have_value)
              {
                result.setNextFlight(fieldGeneratorNextFlight.value);
                fieldGeneratorNextFlight.have_value = false;
              }
            if (fieldGeneratorAirline.have_value)
              {
                result.setAirline(fieldGeneratorAirline.value);
                fieldGeneratorAirline.have_value = false;
              }
            if (fieldGeneratorAdditionalAirlineMatches.have_value)
              {
                result.initAdditionalAirlineMatches();
                int count = fieldGeneratorAdditionalAirlineMatches.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAdditionalAirlineMatches(fieldGeneratorAdditionalAirlineMatches.value[num]);
                  }
                fieldGeneratorAdditionalAirlineMatches.value.Clear();
                fieldGeneratorAdditionalAirlineMatches.have_value = false;
              }
            if (fieldGeneratorFlightNumber.have_value)
              {
                result.setFlightNumber((short)(fieldGeneratorFlightNumber.value));
                fieldGeneratorFlightNumber.have_value = false;
              }
            if (fieldGeneratorDepartureLocation.have_value)
              {
                result.setDepartureLocation(fieldGeneratorDepartureLocation.value);
                fieldGeneratorDepartureLocation.have_value = false;
              }
            if (fieldGeneratorDestinationLocation.have_value)
              {
                result.setDestinationLocation(fieldGeneratorDestinationLocation.value);
                fieldGeneratorDestinationLocation.have_value = false;
              }
            if (fieldGeneratorTypeOfLastLocationFilter.have_value)
              {
                result.setTypeOfLastLocationFilter(fieldGeneratorTypeOfLastLocationFilter.value);
                fieldGeneratorTypeOfLastLocationFilter.have_value = false;
              }
            if (fieldGeneratorDepartureDateTimeRange.have_value)
              {
                result.setDepartureDateTimeRange(fieldGeneratorDepartureDateTimeRange.value);
                fieldGeneratorDepartureDateTimeRange.have_value = false;
              }
            if (fieldGeneratorArrivalDateTimeRange.have_value)
              {
                result.setArrivalDateTimeRange(fieldGeneratorArrivalDateTimeRange.value);
                fieldGeneratorArrivalDateTimeRange.have_value = false;
              }
            if (fieldGeneratorEitherDepartureOrArrivalDateTimeRange.have_value)
              {
                result.setEitherDepartureOrArrivalDateTimeRange(fieldGeneratorEitherDepartureOrArrivalDateTimeRange.value);
                fieldGeneratorEitherDepartureOrArrivalDateTimeRange.have_value = false;
              }
            if (fieldGeneratorTypeOfLastDateTimeRangeFilter.have_value)
              {
                result.setTypeOfLastDateTimeRangeFilter(fieldGeneratorTypeOfLastDateTimeRangeFilter.value);
                fieldGeneratorTypeOfLastDateTimeRangeFilter.have_value = false;
              }
            if (fieldGeneratorRequestedFlightAttributes.have_value)
              {
                result.initRequestedFlightAttributes();
                int count = fieldGeneratorRequestedFlightAttributes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequestedFlightAttributes(fieldGeneratorRequestedFlightAttributes.value[num]);
                  }
                fieldGeneratorRequestedFlightAttributes.value.Clear();
                fieldGeneratorRequestedFlightAttributes.have_value = false;
              }
            else if ((!(result.hasRequestedFlightAttributes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedFlightAttributes\" field was missing.");
              }
            if (fieldGeneratorRequestedFlightAttributesOpen.have_value)
              {
                result.initRequestedFlightAttributesOpen();
                int count = fieldGeneratorRequestedFlightAttributesOpen.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequestedFlightAttributesOpen(fieldGeneratorRequestedFlightAttributesOpen.value[num]);
                  }
                fieldGeneratorRequestedFlightAttributesOpen.value.Clear();
                fieldGeneratorRequestedFlightAttributesOpen.have_value = false;
              }
            if (fieldGeneratorDepartureTimeFormat.have_value)
              {
                result.setDepartureTimeFormat(fieldGeneratorDepartureTimeFormat.value);
                fieldGeneratorDepartureTimeFormat.have_value = false;
              }
            if (fieldGeneratorBoardingTimeFormat.have_value)
              {
                result.setBoardingTimeFormat(fieldGeneratorBoardingTimeFormat.value);
                fieldGeneratorBoardingTimeFormat.have_value = false;
              }
            if (fieldGeneratorArrivalTimeFormat.have_value)
              {
                result.setArrivalTimeFormat(fieldGeneratorArrivalTimeFormat.value);
                fieldGeneratorArrivalTimeFormat.have_value = false;
              }
            if (fieldGeneratorSpoken.have_value)
              {
                result.setSpoken(fieldGeneratorSpoken.value);
                fieldGeneratorSpoken.have_value = false;
              }
            if (fieldGeneratorWritten.have_value)
              {
                result.setWritten(fieldGeneratorWritten.value);
                fieldGeneratorWritten.have_value = false;
              }
            if (fieldGeneratorModeInteractionDisabled.have_value)
              {
                result.setModeInteractionDisabled(fieldGeneratorModeInteractionDisabled.value);
                fieldGeneratorModeInteractionDisabled.have_value = false;
              }
          }
        protected abstract void handle_result(FlightSpecJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'd':
                            if ((String.Compare(field_name, 2, "ditionalAirlineMatches", 0, 22, false) == 0) && (field_name.Length == 24))
                                return fieldGeneratorAdditionalAirlineMatches;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "rline", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorAirline;
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "rival", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 8, "ateTimeRange", 0, 12, false) == 0) && (field_name.Length == 20))
                                            return fieldGeneratorArrivalDateTimeRange;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 8, "imeFormat", 0, 9, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorArrivalTimeFormat;
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
                case 'B':
                    if ((String.Compare(field_name, 1, "oardingTimeFormat", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorBoardingTimeFormat;
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'p':
                                if (String.Compare(field_name, 3, "arture", 0, 6, false) == 0)
                                  {
                                    switch (field_name[9])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 10, "ateTimeRange", 0, 12, false) == 0) && (field_name.Length == 22))
                                                return fieldGeneratorDepartureDateTimeRange;
                                            break;
                                        case 'L':
                                            if ((String.Compare(field_name, 10, "ocation", 0, 7, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorDepartureLocation;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 10, "imeFormat", 0, 9, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratorDepartureTimeFormat;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 's':
                                if ((String.Compare(field_name, 3, "tinationLocation", 0, 16, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorDestinationLocation;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "itherDepartureOrArrivalDateTimeRange", 0, 36, false) == 0) && (field_name.Length == 37))
                        return fieldGeneratorEitherDepartureOrArrivalDateTimeRange;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "lightNumber", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorFlightNumber;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "odeInteractionDisabled", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorModeInteractionDisabled;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "extFlight", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNextFlight;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "equestedFlightAttributes", 0, 24, false) == 0)
                      {
                        if (field_name.Length == 25)
                          {
                            return fieldGeneratorRequestedFlightAttributes;
                          }
                        switch (field_name[25])
                          {
                            case 'O':
                                if ((String.Compare(field_name, 26, "pen", 0, 3, false) == 0) && (field_name.Length == 29))
                                    return fieldGeneratorRequestedFlightAttributesOpen;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "poken", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorSpoken;
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "ypeOfLast", 0, 9, false) == 0)
                      {
                        switch (field_name[10])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 11, "ateTimeRangeFilter", 0, 18, false) == 0) && (field_name.Length == 29))
                                    return fieldGeneratorTypeOfLastDateTimeRangeFilter;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 11, "ocationFilter", 0, 13, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorTypeOfLastLocationFilter;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "ritten", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorWritten;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorNextFlight = new JSONHoldingBooleanGenerator("field \"NextFlight\" of the FlightSpec class");
            fieldGeneratorAirline = new AirlineJSON.HoldingGenerator("field \"Airline\" of the FlightSpec class", ignore_extras);
            fieldGeneratorAdditionalAirlineMatches = new AirlineJSON.HoldingArrayGenerator("field \"AdditionalAirlineMatches\" of the FlightSpec class", ignore_extras);
            fieldGeneratorFlightNumber = new FieldHoldingGeneratorFlightNumber("field \"FlightNumber\" of the FlightSpec class");
            fieldGeneratorDepartureLocation = new FlightTravelLocationJSON.HoldingGenerator("field \"DepartureLocation\" of the FlightSpec class", ignore_extras);
            fieldGeneratorDestinationLocation = new FlightTravelLocationJSON.HoldingGenerator("field \"DestinationLocation\" of the FlightSpec class", ignore_extras);
            fieldGeneratorTypeOfLastLocationFilter = new DepartureOrArrivalJSON.HoldingGenerator("field \"TypeOfLastLocationFilter\" of the FlightSpec class", ignore_extras);
            fieldGeneratorDepartureDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DepartureDateTimeRange\" of the FlightSpec class", ignore_extras);
            fieldGeneratorArrivalDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"ArrivalDateTimeRange\" of the FlightSpec class", ignore_extras);
            fieldGeneratorEitherDepartureOrArrivalDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"EitherDepartureOrArrivalDateTimeRange\" of the FlightSpec class", ignore_extras);
            fieldGeneratorTypeOfLastDateTimeRangeFilter = new DepartureOrArrivalJSON.HoldingGenerator("field \"TypeOfLastDateTimeRangeFilter\" of the FlightSpec class", ignore_extras);
            fieldGeneratorRequestedFlightAttributes = new FlightAttributeJSON.HoldingArrayGenerator("field \"RequestedFlightAttributes\" of the FlightSpec class", ignore_extras);
            fieldGeneratorRequestedFlightAttributesOpen = new FlightAttributeOpenJSON.HoldingArrayGenerator("field \"RequestedFlightAttributesOpen\" of the FlightSpec class", ignore_extras);
            fieldGeneratorDepartureTimeFormat = new FlightTimeFormatJSON.HoldingGenerator("field \"DepartureTimeFormat\" of the FlightSpec class", ignore_extras);
            fieldGeneratorBoardingTimeFormat = new FlightTimeFormatJSON.HoldingGenerator("field \"BoardingTimeFormat\" of the FlightSpec class", ignore_extras);
            fieldGeneratorArrivalTimeFormat = new FlightTimeFormatJSON.HoldingGenerator("field \"ArrivalTimeFormat\" of the FlightSpec class", ignore_extras);
            fieldGeneratorSpoken = new JSONHoldingStringGenerator("field \"Spoken\" of the FlightSpec class");
            fieldGeneratorWritten = new JSONHoldingStringGenerator("field \"Written\" of the FlightSpec class");
            fieldGeneratorModeInteractionDisabled = new JSONHoldingBooleanGenerator("field \"ModeInteractionDisabled\" of the FlightSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorNextFlight = new JSONHoldingBooleanGenerator("field \"NextFlight\" of the FlightSpec class");
            fieldGeneratorAirline = new AirlineJSON.HoldingGenerator("field \"Airline\" of the FlightSpec class", false);
            fieldGeneratorAdditionalAirlineMatches = new AirlineJSON.HoldingArrayGenerator("field \"AdditionalAirlineMatches\" of the FlightSpec class", false);
            fieldGeneratorFlightNumber = new FieldHoldingGeneratorFlightNumber("field \"FlightNumber\" of the FlightSpec class");
            fieldGeneratorDepartureLocation = new FlightTravelLocationJSON.HoldingGenerator("field \"DepartureLocation\" of the FlightSpec class", false);
            fieldGeneratorDestinationLocation = new FlightTravelLocationJSON.HoldingGenerator("field \"DestinationLocation\" of the FlightSpec class", false);
            fieldGeneratorTypeOfLastLocationFilter = new DepartureOrArrivalJSON.HoldingGenerator("field \"TypeOfLastLocationFilter\" of the FlightSpec class", false);
            fieldGeneratorDepartureDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DepartureDateTimeRange\" of the FlightSpec class", false);
            fieldGeneratorArrivalDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"ArrivalDateTimeRange\" of the FlightSpec class", false);
            fieldGeneratorEitherDepartureOrArrivalDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"EitherDepartureOrArrivalDateTimeRange\" of the FlightSpec class", false);
            fieldGeneratorTypeOfLastDateTimeRangeFilter = new DepartureOrArrivalJSON.HoldingGenerator("field \"TypeOfLastDateTimeRangeFilter\" of the FlightSpec class", false);
            fieldGeneratorRequestedFlightAttributes = new FlightAttributeJSON.HoldingArrayGenerator("field \"RequestedFlightAttributes\" of the FlightSpec class", false);
            fieldGeneratorRequestedFlightAttributesOpen = new FlightAttributeOpenJSON.HoldingArrayGenerator("field \"RequestedFlightAttributesOpen\" of the FlightSpec class", false);
            fieldGeneratorDepartureTimeFormat = new FlightTimeFormatJSON.HoldingGenerator("field \"DepartureTimeFormat\" of the FlightSpec class", false);
            fieldGeneratorBoardingTimeFormat = new FlightTimeFormatJSON.HoldingGenerator("field \"BoardingTimeFormat\" of the FlightSpec class", false);
            fieldGeneratorArrivalTimeFormat = new FlightTimeFormatJSON.HoldingGenerator("field \"ArrivalTimeFormat\" of the FlightSpec class", false);
            fieldGeneratorSpoken = new JSONHoldingStringGenerator("field \"Spoken\" of the FlightSpec class");
            fieldGeneratorWritten = new JSONHoldingStringGenerator("field \"Written\" of the FlightSpec class");
            fieldGeneratorModeInteractionDisabled = new JSONHoldingBooleanGenerator("field \"ModeInteractionDisabled\" of the FlightSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorNextFlight.reset();
            fieldGeneratorAirline.reset();
            fieldGeneratorAdditionalAirlineMatches.reset();
            fieldGeneratorFlightNumber.reset();
            fieldGeneratorDepartureLocation.reset();
            fieldGeneratorDestinationLocation.reset();
            fieldGeneratorTypeOfLastLocationFilter.reset();
            fieldGeneratorDepartureDateTimeRange.reset();
            fieldGeneratorArrivalDateTimeRange.reset();
            fieldGeneratorEitherDepartureOrArrivalDateTimeRange.reset();
            fieldGeneratorTypeOfLastDateTimeRangeFilter.reset();
            fieldGeneratorRequestedFlightAttributes.reset();
            fieldGeneratorRequestedFlightAttributesOpen.reset();
            fieldGeneratorDepartureTimeFormat.reset();
            fieldGeneratorBoardingTimeFormat.reset();
            fieldGeneratorArrivalTimeFormat.reset();
            fieldGeneratorSpoken.reset();
            fieldGeneratorWritten.reset();
            fieldGeneratorModeInteractionDisabled.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAirline.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAdditionalAirlineMatches.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDepartureLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDestinationLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTypeOfLastLocationFilter.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDepartureDateTimeRange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorArrivalDateTimeRange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEitherDepartureOrArrivalDateTimeRange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTypeOfLastDateTimeRangeFilter.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedFlightAttributes.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedFlightAttributesOpen.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDepartureTimeFormat.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBoardingTimeFormat.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorArrivalTimeFormat.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAirline.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAdditionalAirlineMatches.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDepartureLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDestinationLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTypeOfLastLocationFilter.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDepartureDateTimeRange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorArrivalDateTimeRange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEitherDepartureOrArrivalDateTimeRange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTypeOfLastDateTimeRangeFilter.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedFlightAttributes.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedFlightAttributesOpen.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDepartureTimeFormat.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBoardingTimeFormat.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorArrivalTimeFormat.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightSpecJSON  result)
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
        public FlightSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightSpecJSON  result)
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
    protected virtual void handle_result(List<FlightSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightSpecJSON>();
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
    public List<FlightSpecJSON> value;
  };
  };
