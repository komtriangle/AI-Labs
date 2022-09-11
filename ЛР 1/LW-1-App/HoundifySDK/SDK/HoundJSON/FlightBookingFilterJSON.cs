/* file "FlightBookingFilterJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FlightBookingFilterJSON : JSONBase
  {
    private bool flagHasFlightSegmentFilters;
    private List< FlightSegmentFilterJSON  > storeFlightSegmentFilters;
    private bool flagHasIndexOfLastUpdatedFlightSegmentFilter;
    private BigInteger storeIndexOfLastUpdatedFlightSegmentFilter;
    private bool flagHasFlightTripType;
    private FlightTripTypeJSON  storeFlightTripType;
    private bool flagHasSameDayOrOvernight;
    private SameDayOrOvernightJSON  storeSameDayOrOvernight;
    private bool flagHasReturnFlightSegmentFilter;
    private FlightSegmentFilterJSON  storeReturnFlightSegmentFilter;
    private bool flagHasLastTripDuration;
    private double storeLastTripDuration;
    private string textStoreLastTripDuration;
    private bool flagHasNumberOfStops;
    private IntegerIntervalJSON  storeNumberOfStops;
    private bool flagHasPriceRange;
    private PriceRangeJSON  storePriceRange;
    private bool flagHasRangeOfLayoverDuration;
    private RangeOfDurationJSON  storeRangeOfLayoverDuration;
    private bool flagHasRangeOfTotalLayoverDuration;
    private RangeOfDurationJSON  storeRangeOfTotalLayoverDuration;
    private bool flagHasRangeOfTravelDuration;
    private RangeOfDurationJSON  storeRangeOfTravelDuration;
    private bool flagHasRangeOfTotalTravelDuration;
    private RangeOfDurationJSON  storeRangeOfTotalTravelDuration;
    private bool flagHasAvoidChangePenalties;
    private bool storeAvoidChangePenalties;
    private bool flagHasAirlineFilter;
    private AirlineFilterJSON  storeAirlineFilter;
    private bool flagHasSeatPreferences;
    private FlightSeatPreferencesJSON  storeSeatPreferences;
    private bool flagHasCabinClassFilter;
    private CabinClassFilterJSON  storeCabinClassFilter;
    private bool flagHasAirportFilter;
    private FlightTravelLocationFilterJSON  storeAirportFilter;
    private bool flagHasPassengerTypesWithCount;
    private List< FlightPassengerTypeCountJSON  > storePassengerTypesWithCount;
    private bool flagHasNumberOfSeatsOrTicketsRequested;
    private BigInteger storeNumberOfSeatsOrTicketsRequested;
    private bool flagHasFlightListSortCriteria;
    private List< FlightListSortCriterionJSON  > storeFlightListSortCriteria;
    private bool flagHasUpdatedSearchCriteria;
    private List< FlightSearchCriterionJSON  > storeUpdatedSearchCriteria;
    private bool flagHasSearchCriteria;
    private List< FlightSearchCriterionJSON  > storeSearchCriteria;
    private bool flagHasSpokenLabel;
    private string storeSpokenLabel;
    private bool flagHasLabel;
    private string storeLabel;
    private bool flagHasSpokenUpdateLabel;
    private string storeSpokenUpdateLabel;
    private bool flagHasUpdateLabel;
    private string storeUpdateLabel;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFlightSegmentFilters(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlightSegmentFilters of FlightBookingFilterJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< FlightSegmentFilterJSON  > vector_FlightSegmentFilters1 = new List< FlightSegmentFilterJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightSegmentFilterJSON convert_classy = FlightSegmentFilterJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlightSegmentFilters1.Add(convert_classy);
          }
        initFlightSegmentFilters();
        for (int num1 = 0; num1 < vector_FlightSegmentFilters1.Count; ++num1)
            appendFlightSegmentFilters(vector_FlightSegmentFilters1[num1]);
        for (int num1 = 0; num1 < vector_FlightSegmentFilters1.Count; ++num1)
          {
          }
      }


    private void  fromJSONIndexOfLastUpdatedFlightSegmentFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field IndexOfLastUpdatedFlightSegmentFilter of FlightBookingFilterJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field IndexOfLastUpdatedFlightSegmentFilter of FlightBookingFilterJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setIndexOfLastUpdatedFlightSegmentFilter(extracted_integer);
      }


    private void  fromJSONFlightTripType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTripTypeJSON convert_classy = FlightTripTypeJSON.from_json(json_value, ignore_extras, true);
        setFlightTripType(convert_classy);
      }


    private void  fromJSONSameDayOrOvernight(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SameDayOrOvernightJSON convert_classy = SameDayOrOvernightJSON.from_json(json_value, ignore_extras, true);
        setSameDayOrOvernight(convert_classy);
      }


    private void  fromJSONReturnFlightSegmentFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightSegmentFilterJSON convert_classy = FlightSegmentFilterJSON.from_json(json_value, ignore_extras, true);
        setReturnFlightSegmentFilter(convert_classy);
      }


    private void  fromJSONLastTripDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field LastTripDuration of FlightBookingFilterJSON is not a number.");
              }
          }
        setLastTripDurationText(the_rational_text);
      }


    private void  fromJSONNumberOfStops(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IntegerIntervalJSON convert_classy = IntegerIntervalJSON.from_json(json_value, ignore_extras, true);
        setNumberOfStops(convert_classy);
      }


    private void  fromJSONPriceRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PriceRangeJSON convert_classy = PriceRangeJSON.from_json(json_value, ignore_extras, true);
        setPriceRange(convert_classy);
      }


    private void  fromJSONRangeOfLayoverDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RangeOfDurationJSON convert_classy = RangeOfDurationJSON.from_json(json_value, ignore_extras, true);
        setRangeOfLayoverDuration(convert_classy);
      }


    private void  fromJSONRangeOfTotalLayoverDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RangeOfDurationJSON convert_classy = RangeOfDurationJSON.from_json(json_value, ignore_extras, true);
        setRangeOfTotalLayoverDuration(convert_classy);
      }


    private void  fromJSONRangeOfTravelDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RangeOfDurationJSON convert_classy = RangeOfDurationJSON.from_json(json_value, ignore_extras, true);
        setRangeOfTravelDuration(convert_classy);
      }


    private void  fromJSONRangeOfTotalTravelDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RangeOfDurationJSON convert_classy = RangeOfDurationJSON.from_json(json_value, ignore_extras, true);
        setRangeOfTotalTravelDuration(convert_classy);
      }


    private void  fromJSONAvoidChangePenalties(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AvoidChangePenalties of FlightBookingFilterJSON is not true for false.");
              }
          }
        setAvoidChangePenalties(the_bool);
      }


    private void  fromJSONAirlineFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AirlineFilterJSON convert_classy = AirlineFilterJSON.from_json(json_value, ignore_extras, true);
        setAirlineFilter(convert_classy);
      }


    private void  fromJSONSeatPreferences(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightSeatPreferencesJSON convert_classy = FlightSeatPreferencesJSON.from_json(json_value, ignore_extras, true);
        setSeatPreferences(convert_classy);
      }


    private void  fromJSONCabinClassFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CabinClassFilterJSON convert_classy = CabinClassFilterJSON.from_json(json_value, ignore_extras, true);
        setCabinClassFilter(convert_classy);
      }


    private void  fromJSONAirportFilter(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTravelLocationFilterJSON convert_classy = FlightTravelLocationFilterJSON.from_json(json_value, ignore_extras, true);
        setAirportFilter(convert_classy);
      }


    private void  fromJSONPassengerTypesWithCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PassengerTypesWithCount of FlightBookingFilterJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field PassengerTypesWithCount of FlightBookingFilterJSON has too few elements.");
        List< FlightPassengerTypeCountJSON  > vector_PassengerTypesWithCount1 = new List< FlightPassengerTypeCountJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightPassengerTypeCountJSON convert_classy = FlightPassengerTypeCountJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_PassengerTypesWithCount1.Add(convert_classy);
          }
        Debug.Assert(vector_PassengerTypesWithCount1.Count >= 1);
        initPassengerTypesWithCount();
        for (int num2 = 0; num2 < vector_PassengerTypesWithCount1.Count; ++num2)
            appendPassengerTypesWithCount(vector_PassengerTypesWithCount1[num2]);
        for (int num1 = 0; num1 < vector_PassengerTypesWithCount1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNumberOfSeatsOrTicketsRequested(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NumberOfSeatsOrTicketsRequested of FlightBookingFilterJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumberOfSeatsOrTicketsRequested of FlightBookingFilterJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumberOfSeatsOrTicketsRequested(extracted_integer);
      }


    private void  fromJSONFlightListSortCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlightListSortCriteria of FlightBookingFilterJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< FlightListSortCriterionJSON  > vector_FlightListSortCriteria1 = new List< FlightListSortCriterionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightListSortCriterionJSON convert_classy = FlightListSortCriterionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlightListSortCriteria1.Add(convert_classy);
          }
        initFlightListSortCriteria();
        for (int num3 = 0; num3 < vector_FlightListSortCriteria1.Count; ++num3)
            appendFlightListSortCriteria(vector_FlightListSortCriteria1[num3]);
        for (int num1 = 0; num1 < vector_FlightListSortCriteria1.Count; ++num1)
          {
          }
      }


    private void  fromJSONUpdatedSearchCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field UpdatedSearchCriteria of FlightBookingFilterJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field UpdatedSearchCriteria of FlightBookingFilterJSON has too few elements.");
        List< FlightSearchCriterionJSON  > vector_UpdatedSearchCriteria1 = new List< FlightSearchCriterionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightSearchCriterionJSON convert_classy = FlightSearchCriterionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_UpdatedSearchCriteria1.Add(convert_classy);
          }
        Debug.Assert(vector_UpdatedSearchCriteria1.Count >= 1);
        initUpdatedSearchCriteria();
        for (int num4 = 0; num4 < vector_UpdatedSearchCriteria1.Count; ++num4)
            appendUpdatedSearchCriteria(vector_UpdatedSearchCriteria1[num4]);
        for (int num1 = 0; num1 < vector_UpdatedSearchCriteria1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSearchCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SearchCriteria of FlightBookingFilterJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field SearchCriteria of FlightBookingFilterJSON has too few elements.");
        List< FlightSearchCriterionJSON  > vector_SearchCriteria1 = new List< FlightSearchCriterionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightSearchCriterionJSON convert_classy = FlightSearchCriterionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_SearchCriteria1.Add(convert_classy);
          }
        Debug.Assert(vector_SearchCriteria1.Count >= 1);
        initSearchCriteria();
        for (int num5 = 0; num5 < vector_SearchCriteria1.Count; ++num5)
            appendSearchCriteria(vector_SearchCriteria1[num5]);
        for (int num1 = 0; num1 < vector_SearchCriteria1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpokenLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenLabel of FlightBookingFilterJSON is not a string.");
        setSpokenLabel(json_string.getData());
      }


    private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Label of FlightBookingFilterJSON is not a string.");
        setLabel(json_string.getData());
      }


    private void  fromJSONSpokenUpdateLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenUpdateLabel of FlightBookingFilterJSON is not a string.");
        setSpokenUpdateLabel(json_string.getData());
      }


    private void  fromJSONUpdateLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UpdateLabel of FlightBookingFilterJSON is not a string.");
        setUpdateLabel(json_string.getData());
      }


    public FlightBookingFilterJSON()
      {
        flagHasFlightSegmentFilters = false;
        flagHasIndexOfLastUpdatedFlightSegmentFilter = false;
        flagHasFlightTripType = false;
        flagHasSameDayOrOvernight = false;
        flagHasReturnFlightSegmentFilter = false;
        flagHasLastTripDuration = false;
        flagHasNumberOfStops = false;
        flagHasPriceRange = false;
        flagHasRangeOfLayoverDuration = false;
        flagHasRangeOfTotalLayoverDuration = false;
        flagHasRangeOfTravelDuration = false;
        flagHasRangeOfTotalTravelDuration = false;
        flagHasAvoidChangePenalties = false;
        flagHasAirlineFilter = false;
        flagHasSeatPreferences = false;
        flagHasCabinClassFilter = false;
        flagHasAirportFilter = false;
        flagHasPassengerTypesWithCount = false;
        flagHasNumberOfSeatsOrTicketsRequested = false;
        flagHasFlightListSortCriteria = false;
        flagHasUpdatedSearchCriteria = false;
        flagHasSearchCriteria = false;
        flagHasSpokenLabel = false;
        flagHasLabel = false;
        flagHasSpokenUpdateLabel = false;
        flagHasUpdateLabel = false;
        storeFlightSegmentFilters = new List< FlightSegmentFilterJSON  >();
        storePassengerTypesWithCount = new List< FlightPassengerTypeCountJSON  >();
        storeFlightListSortCriteria = new List< FlightListSortCriterionJSON  >();
        storeUpdatedSearchCriteria = new List< FlightSearchCriterionJSON  >();
        storeSearchCriteria = new List< FlightSearchCriterionJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFlightSegmentFilters()
      {
        return flagHasFlightSegmentFilters;
      }

    public int  countOfFlightSegmentFilters()
      {
        Debug.Assert(flagHasFlightSegmentFilters);
        return storeFlightSegmentFilters.Count;
      }

    public FlightSegmentFilterJSON   elementOfFlightSegmentFilters(int element_num)
      {
        Debug.Assert(flagHasFlightSegmentFilters);
        return storeFlightSegmentFilters[element_num];
      }

    public List< FlightSegmentFilterJSON  >  getFlightSegmentFilters()
      {
        Debug.Assert(flagHasFlightSegmentFilters);
        return storeFlightSegmentFilters;
      }

    public bool  hasIndexOfLastUpdatedFlightSegmentFilter()
      {
        return flagHasIndexOfLastUpdatedFlightSegmentFilter;
      }

    public BigInteger  getIndexOfLastUpdatedFlightSegmentFilter()
      {
        Debug.Assert(flagHasIndexOfLastUpdatedFlightSegmentFilter);
        return storeIndexOfLastUpdatedFlightSegmentFilter;
      }

    public bool  hasFlightTripType()
      {
        return flagHasFlightTripType;
      }

    public FlightTripTypeJSON   getFlightTripType()
      {
        Debug.Assert(flagHasFlightTripType);
        return storeFlightTripType;
      }

    public FlightTripTypeJSON.TypeValue  getFlightTripTypeValue()
      {
        return getFlightTripType().getValue();
      }

    public string  getFlightTripTypeAsString()
      {
        return getFlightTripType().getValueAsString();
      }

    public bool  hasSameDayOrOvernight()
      {
        return flagHasSameDayOrOvernight;
      }

    public SameDayOrOvernightJSON   getSameDayOrOvernight()
      {
        Debug.Assert(flagHasSameDayOrOvernight);
        return storeSameDayOrOvernight;
      }

    public SameDayOrOvernightJSON.TypeValue  getSameDayOrOvernightValue()
      {
        return getSameDayOrOvernight().getValue();
      }

    public string  getSameDayOrOvernightAsString()
      {
        return getSameDayOrOvernight().getValueAsString();
      }

    public bool  hasReturnFlightSegmentFilter()
      {
        return flagHasReturnFlightSegmentFilter;
      }

    public FlightSegmentFilterJSON   getReturnFlightSegmentFilter()
      {
        Debug.Assert(flagHasReturnFlightSegmentFilter);
        return storeReturnFlightSegmentFilter;
      }

    public bool  hasLastTripDuration()
      {
        return flagHasLastTripDuration;
      }

    public double  getLastTripDuration()
      {
        Debug.Assert(flagHasLastTripDuration);
        if (textStoreLastTripDuration != "")
          {
            return Double.Parse(textStoreLastTripDuration);
          }
        return storeLastTripDuration;
      }

    public string  getLastTripDurationAsText()
      {
        Debug.Assert(flagHasLastTripDuration);
        if (textStoreLastTripDuration == "")
          {
            return Convert.ToString(storeLastTripDuration);
          }
        else
          {
            return (textStoreLastTripDuration);
          }
      }

    public bool  hasNumberOfStops()
      {
        return flagHasNumberOfStops;
      }

    public IntegerIntervalJSON   getNumberOfStops()
      {
        Debug.Assert(flagHasNumberOfStops);
        return storeNumberOfStops;
      }

    public bool  hasPriceRange()
      {
        return flagHasPriceRange;
      }

    public PriceRangeJSON   getPriceRange()
      {
        Debug.Assert(flagHasPriceRange);
        return storePriceRange;
      }

    public bool  hasRangeOfLayoverDuration()
      {
        return flagHasRangeOfLayoverDuration;
      }

    public RangeOfDurationJSON   getRangeOfLayoverDuration()
      {
        Debug.Assert(flagHasRangeOfLayoverDuration);
        return storeRangeOfLayoverDuration;
      }

    public bool  hasRangeOfTotalLayoverDuration()
      {
        return flagHasRangeOfTotalLayoverDuration;
      }

    public RangeOfDurationJSON   getRangeOfTotalLayoverDuration()
      {
        Debug.Assert(flagHasRangeOfTotalLayoverDuration);
        return storeRangeOfTotalLayoverDuration;
      }

    public bool  hasRangeOfTravelDuration()
      {
        return flagHasRangeOfTravelDuration;
      }

    public RangeOfDurationJSON   getRangeOfTravelDuration()
      {
        Debug.Assert(flagHasRangeOfTravelDuration);
        return storeRangeOfTravelDuration;
      }

    public bool  hasRangeOfTotalTravelDuration()
      {
        return flagHasRangeOfTotalTravelDuration;
      }

    public RangeOfDurationJSON   getRangeOfTotalTravelDuration()
      {
        Debug.Assert(flagHasRangeOfTotalTravelDuration);
        return storeRangeOfTotalTravelDuration;
      }

    public bool  hasAvoidChangePenalties()
      {
        return flagHasAvoidChangePenalties;
      }

    public bool  getAvoidChangePenalties()
      {
        Debug.Assert(flagHasAvoidChangePenalties);
        return storeAvoidChangePenalties;
      }

    public bool  hasAirlineFilter()
      {
        return flagHasAirlineFilter;
      }

    public AirlineFilterJSON   getAirlineFilter()
      {
        Debug.Assert(flagHasAirlineFilter);
        return storeAirlineFilter;
      }

    public bool  hasSeatPreferences()
      {
        return flagHasSeatPreferences;
      }

    public FlightSeatPreferencesJSON   getSeatPreferences()
      {
        Debug.Assert(flagHasSeatPreferences);
        return storeSeatPreferences;
      }

    public bool  hasCabinClassFilter()
      {
        return flagHasCabinClassFilter;
      }

    public CabinClassFilterJSON   getCabinClassFilter()
      {
        Debug.Assert(flagHasCabinClassFilter);
        return storeCabinClassFilter;
      }

    public bool  hasAirportFilter()
      {
        return flagHasAirportFilter;
      }

    public FlightTravelLocationFilterJSON   getAirportFilter()
      {
        Debug.Assert(flagHasAirportFilter);
        return storeAirportFilter;
      }

    public bool  hasPassengerTypesWithCount()
      {
        return flagHasPassengerTypesWithCount;
      }

    public int  countOfPassengerTypesWithCount()
      {
        Debug.Assert(flagHasPassengerTypesWithCount);
        return storePassengerTypesWithCount.Count;
      }

    public FlightPassengerTypeCountJSON   elementOfPassengerTypesWithCount(int element_num)
      {
        Debug.Assert(flagHasPassengerTypesWithCount);
        return storePassengerTypesWithCount[element_num];
      }

    public List< FlightPassengerTypeCountJSON  >  getPassengerTypesWithCount()
      {
        Debug.Assert(flagHasPassengerTypesWithCount);
        return storePassengerTypesWithCount;
      }

    public bool  hasNumberOfSeatsOrTicketsRequested()
      {
        return flagHasNumberOfSeatsOrTicketsRequested;
      }

    public BigInteger  getNumberOfSeatsOrTicketsRequested()
      {
        Debug.Assert(flagHasNumberOfSeatsOrTicketsRequested);
        return storeNumberOfSeatsOrTicketsRequested;
      }

    public bool  hasFlightListSortCriteria()
      {
        return flagHasFlightListSortCriteria;
      }

    public int  countOfFlightListSortCriteria()
      {
        Debug.Assert(flagHasFlightListSortCriteria);
        return storeFlightListSortCriteria.Count;
      }

    public FlightListSortCriterionJSON   elementOfFlightListSortCriteria(int element_num)
      {
        Debug.Assert(flagHasFlightListSortCriteria);
        return storeFlightListSortCriteria[element_num];
      }

    public List< FlightListSortCriterionJSON  >  getFlightListSortCriteria()
      {
        Debug.Assert(flagHasFlightListSortCriteria);
        return storeFlightListSortCriteria;
      }

    public bool  hasUpdatedSearchCriteria()
      {
        return flagHasUpdatedSearchCriteria;
      }

    public int  countOfUpdatedSearchCriteria()
      {
        Debug.Assert(flagHasUpdatedSearchCriteria);
        return storeUpdatedSearchCriteria.Count;
      }

    public FlightSearchCriterionJSON   elementOfUpdatedSearchCriteria(int element_num)
      {
        Debug.Assert(flagHasUpdatedSearchCriteria);
        return storeUpdatedSearchCriteria[element_num];
      }

    public List< FlightSearchCriterionJSON  >  getUpdatedSearchCriteria()
      {
        Debug.Assert(flagHasUpdatedSearchCriteria);
        return storeUpdatedSearchCriteria;
      }

    public bool  hasSearchCriteria()
      {
        return flagHasSearchCriteria;
      }

    public int  countOfSearchCriteria()
      {
        Debug.Assert(flagHasSearchCriteria);
        return storeSearchCriteria.Count;
      }

    public FlightSearchCriterionJSON   elementOfSearchCriteria(int element_num)
      {
        Debug.Assert(flagHasSearchCriteria);
        return storeSearchCriteria[element_num];
      }

    public List< FlightSearchCriterionJSON  >  getSearchCriteria()
      {
        Debug.Assert(flagHasSearchCriteria);
        return storeSearchCriteria;
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

    public bool  hasLabel()
      {
        return flagHasLabel;
      }

    public string  getLabel()
      {
        Debug.Assert(flagHasLabel);
        return storeLabel;
      }

    public bool  hasSpokenUpdateLabel()
      {
        return flagHasSpokenUpdateLabel;
      }

    public string  getSpokenUpdateLabel()
      {
        Debug.Assert(flagHasSpokenUpdateLabel);
        return storeSpokenUpdateLabel;
      }

    public bool  hasUpdateLabel()
      {
        return flagHasUpdateLabel;
      }

    public string  getUpdateLabel()
      {
        Debug.Assert(flagHasUpdateLabel);
        return storeUpdateLabel;
      }


    public virtual int extraFlightBookingFilterComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightBookingFilterComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightBookingFilterComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightBookingFilterLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initFlightSegmentFilters()
      {
        if (flagHasFlightSegmentFilters)
          {
            for (int num1 = 0; num1 < storeFlightSegmentFilters.Count; ++num1)
              {
              }
          }
        flagHasFlightSegmentFilters = true;
        storeFlightSegmentFilters.Clear();
      }
    public void appendFlightSegmentFilters(FlightSegmentFilterJSON  to_append)
      {
        if (!flagHasFlightSegmentFilters)
          {
            flagHasFlightSegmentFilters = true;
            storeFlightSegmentFilters.Clear();
          }
        Debug.Assert(flagHasFlightSegmentFilters);
        storeFlightSegmentFilters.Add(to_append);
      }
    public void unsetFlightSegmentFilters()
      {
        if (flagHasFlightSegmentFilters)
          {
            for (int num2 = 0; num2 < storeFlightSegmentFilters.Count; ++num2)
              {
              }
          }
        flagHasFlightSegmentFilters = false;
        storeFlightSegmentFilters.Clear();
      }
    public void setIndexOfLastUpdatedFlightSegmentFilter(BigInteger new_value)
      {
        flagHasIndexOfLastUpdatedFlightSegmentFilter = true;
        if (new_value < 0)
            throw new Exception("The value for field IndexOfLastUpdatedFlightSegmentFilter of FlightBookingFilterJSON is less than the lower bound (0) for that field.");
        storeIndexOfLastUpdatedFlightSegmentFilter = new_value;
      }
    public void unsetIndexOfLastUpdatedFlightSegmentFilter()
      {
        flagHasIndexOfLastUpdatedFlightSegmentFilter = false;
      }
    public void setFlightTripType(FlightTripTypeJSON  new_value)
      {
        if (flagHasFlightTripType)
          {
          }
        flagHasFlightTripType = true;
        storeFlightTripType = new_value;
      }
    public void setFlightTripType(FlightTripTypeJSON.TypeValue new_value)
      {
        setFlightTripType(new FlightTripTypeJSON(new_value));
      }
    public void setFlightTripType(string chars)
      {
        setFlightTripType(new FlightTripTypeJSON(chars));
      }
    public void unsetFlightTripType()
      {
        if (flagHasFlightTripType)
          {
          }
        flagHasFlightTripType = false;
      }
    public void setSameDayOrOvernight(SameDayOrOvernightJSON  new_value)
      {
        if (flagHasSameDayOrOvernight)
          {
          }
        flagHasSameDayOrOvernight = true;
        storeSameDayOrOvernight = new_value;
      }
    public void setSameDayOrOvernight(SameDayOrOvernightJSON.TypeValue new_value)
      {
        setSameDayOrOvernight(new SameDayOrOvernightJSON(new_value));
      }
    public void setSameDayOrOvernight(string chars)
      {
        SameDayOrOvernightJSON.TypeValueKnownValues known = SameDayOrOvernightJSON.stringToValue(chars);
        SameDayOrOvernightJSON.TypeValue new_value = new SameDayOrOvernightJSON.TypeValue();
        if (known == SameDayOrOvernightJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSameDayOrOvernight(new_value);
      }
    public void unsetSameDayOrOvernight()
      {
        if (flagHasSameDayOrOvernight)
          {
          }
        flagHasSameDayOrOvernight = false;
      }
    public void setReturnFlightSegmentFilter(FlightSegmentFilterJSON  new_value)
      {
        if (flagHasReturnFlightSegmentFilter)
          {
          }
        flagHasReturnFlightSegmentFilter = true;
        storeReturnFlightSegmentFilter = new_value;
      }
    public void unsetReturnFlightSegmentFilter()
      {
        if (flagHasReturnFlightSegmentFilter)
          {
          }
        flagHasReturnFlightSegmentFilter = false;
      }
    public void setLastTripDuration(double new_value)
      {
        flagHasLastTripDuration = true;
        storeLastTripDuration = new_value;
        textStoreLastTripDuration = "";
      }
    public void setLastTripDurationText(string new_value)
      {
        flagHasLastTripDuration = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field LastTripDuration of FlightBookingFilterJSON is not a valid number.");
        textStoreLastTripDuration = new_value;
      }
    public void unsetLastTripDuration()
      {
        flagHasLastTripDuration = false;
      }
    public void setNumberOfStops(IntegerIntervalJSON  new_value)
      {
        if (flagHasNumberOfStops)
          {
          }
        flagHasNumberOfStops = true;
        storeNumberOfStops = new_value;
      }
    public void unsetNumberOfStops()
      {
        if (flagHasNumberOfStops)
          {
          }
        flagHasNumberOfStops = false;
      }
    public void setPriceRange(PriceRangeJSON  new_value)
      {
        if (flagHasPriceRange)
          {
          }
        flagHasPriceRange = true;
        storePriceRange = new_value;
      }
    public void unsetPriceRange()
      {
        if (flagHasPriceRange)
          {
          }
        flagHasPriceRange = false;
      }
    public void setRangeOfLayoverDuration(RangeOfDurationJSON  new_value)
      {
        if (flagHasRangeOfLayoverDuration)
          {
          }
        flagHasRangeOfLayoverDuration = true;
        storeRangeOfLayoverDuration = new_value;
      }
    public void unsetRangeOfLayoverDuration()
      {
        if (flagHasRangeOfLayoverDuration)
          {
          }
        flagHasRangeOfLayoverDuration = false;
      }
    public void setRangeOfTotalLayoverDuration(RangeOfDurationJSON  new_value)
      {
        if (flagHasRangeOfTotalLayoverDuration)
          {
          }
        flagHasRangeOfTotalLayoverDuration = true;
        storeRangeOfTotalLayoverDuration = new_value;
      }
    public void unsetRangeOfTotalLayoverDuration()
      {
        if (flagHasRangeOfTotalLayoverDuration)
          {
          }
        flagHasRangeOfTotalLayoverDuration = false;
      }
    public void setRangeOfTravelDuration(RangeOfDurationJSON  new_value)
      {
        if (flagHasRangeOfTravelDuration)
          {
          }
        flagHasRangeOfTravelDuration = true;
        storeRangeOfTravelDuration = new_value;
      }
    public void unsetRangeOfTravelDuration()
      {
        if (flagHasRangeOfTravelDuration)
          {
          }
        flagHasRangeOfTravelDuration = false;
      }
    public void setRangeOfTotalTravelDuration(RangeOfDurationJSON  new_value)
      {
        if (flagHasRangeOfTotalTravelDuration)
          {
          }
        flagHasRangeOfTotalTravelDuration = true;
        storeRangeOfTotalTravelDuration = new_value;
      }
    public void unsetRangeOfTotalTravelDuration()
      {
        if (flagHasRangeOfTotalTravelDuration)
          {
          }
        flagHasRangeOfTotalTravelDuration = false;
      }
    public void setAvoidChangePenalties(bool new_value)
      {
        flagHasAvoidChangePenalties = true;
        storeAvoidChangePenalties = new_value;
      }
    public void unsetAvoidChangePenalties()
      {
        flagHasAvoidChangePenalties = false;
      }
    public void setAirlineFilter(AirlineFilterJSON  new_value)
      {
        if (flagHasAirlineFilter)
          {
          }
        flagHasAirlineFilter = true;
        storeAirlineFilter = new_value;
      }
    public void unsetAirlineFilter()
      {
        if (flagHasAirlineFilter)
          {
          }
        flagHasAirlineFilter = false;
      }
    public void setSeatPreferences(FlightSeatPreferencesJSON  new_value)
      {
        if (flagHasSeatPreferences)
          {
          }
        flagHasSeatPreferences = true;
        storeSeatPreferences = new_value;
      }
    public void unsetSeatPreferences()
      {
        if (flagHasSeatPreferences)
          {
          }
        flagHasSeatPreferences = false;
      }
    public void setCabinClassFilter(CabinClassFilterJSON  new_value)
      {
        if (flagHasCabinClassFilter)
          {
          }
        flagHasCabinClassFilter = true;
        storeCabinClassFilter = new_value;
      }
    public void unsetCabinClassFilter()
      {
        if (flagHasCabinClassFilter)
          {
          }
        flagHasCabinClassFilter = false;
      }
    public void setAirportFilter(FlightTravelLocationFilterJSON  new_value)
      {
        if (flagHasAirportFilter)
          {
          }
        flagHasAirportFilter = true;
        storeAirportFilter = new_value;
      }
    public void unsetAirportFilter()
      {
        if (flagHasAirportFilter)
          {
          }
        flagHasAirportFilter = false;
      }
    public void initPassengerTypesWithCount()
      {
        if (flagHasPassengerTypesWithCount)
          {
            for (int num3 = 0; num3 < storePassengerTypesWithCount.Count; ++num3)
              {
              }
          }
        flagHasPassengerTypesWithCount = true;
        storePassengerTypesWithCount.Clear();
      }
    public void appendPassengerTypesWithCount(FlightPassengerTypeCountJSON  to_append)
      {
        if (!flagHasPassengerTypesWithCount)
          {
            flagHasPassengerTypesWithCount = true;
            storePassengerTypesWithCount.Clear();
          }
        Debug.Assert(flagHasPassengerTypesWithCount);
        storePassengerTypesWithCount.Add(to_append);
      }
    public void unsetPassengerTypesWithCount()
      {
        if (flagHasPassengerTypesWithCount)
          {
            for (int num4 = 0; num4 < storePassengerTypesWithCount.Count; ++num4)
              {
              }
          }
        flagHasPassengerTypesWithCount = false;
        storePassengerTypesWithCount.Clear();
      }
    public void setNumberOfSeatsOrTicketsRequested(BigInteger new_value)
      {
        flagHasNumberOfSeatsOrTicketsRequested = true;
        if (new_value < 1)
            throw new Exception("The value for field NumberOfSeatsOrTicketsRequested of FlightBookingFilterJSON is less than the lower bound (1) for that field.");
        storeNumberOfSeatsOrTicketsRequested = new_value;
      }
    public void unsetNumberOfSeatsOrTicketsRequested()
      {
        flagHasNumberOfSeatsOrTicketsRequested = false;
      }
    public void initFlightListSortCriteria()
      {
        if (flagHasFlightListSortCriteria)
          {
            for (int num5 = 0; num5 < storeFlightListSortCriteria.Count; ++num5)
              {
              }
          }
        flagHasFlightListSortCriteria = true;
        storeFlightListSortCriteria.Clear();
      }
    public void appendFlightListSortCriteria(FlightListSortCriterionJSON  to_append)
      {
        if (!flagHasFlightListSortCriteria)
          {
            flagHasFlightListSortCriteria = true;
            storeFlightListSortCriteria.Clear();
          }
        Debug.Assert(flagHasFlightListSortCriteria);
        storeFlightListSortCriteria.Add(to_append);
      }
    public void unsetFlightListSortCriteria()
      {
        if (flagHasFlightListSortCriteria)
          {
            for (int num6 = 0; num6 < storeFlightListSortCriteria.Count; ++num6)
              {
              }
          }
        flagHasFlightListSortCriteria = false;
        storeFlightListSortCriteria.Clear();
      }
    public void initUpdatedSearchCriteria()
      {
        if (flagHasUpdatedSearchCriteria)
          {
            for (int num7 = 0; num7 < storeUpdatedSearchCriteria.Count; ++num7)
              {
              }
          }
        flagHasUpdatedSearchCriteria = true;
        storeUpdatedSearchCriteria.Clear();
      }
    public void appendUpdatedSearchCriteria(FlightSearchCriterionJSON  to_append)
      {
        if (!flagHasUpdatedSearchCriteria)
          {
            flagHasUpdatedSearchCriteria = true;
            storeUpdatedSearchCriteria.Clear();
          }
        Debug.Assert(flagHasUpdatedSearchCriteria);
        storeUpdatedSearchCriteria.Add(to_append);
      }
    public void appendUpdatedSearchCriteria(FlightSearchCriterionJSON.TypeValue new_value)
      {
        appendUpdatedSearchCriteria(new FlightSearchCriterionJSON(new_value));
      }
    public void appendUpdatedSearchCriteria(string chars)
      {
        FlightSearchCriterionJSON.TypeValueKnownValues known = FlightSearchCriterionJSON.stringToValue(chars);
        FlightSearchCriterionJSON.TypeValue new_value = new FlightSearchCriterionJSON.TypeValue();
        if (known == FlightSearchCriterionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendUpdatedSearchCriteria(new_value);
      }
    public void unsetUpdatedSearchCriteria()
      {
        if (flagHasUpdatedSearchCriteria)
          {
            for (int num8 = 0; num8 < storeUpdatedSearchCriteria.Count; ++num8)
              {
              }
          }
        flagHasUpdatedSearchCriteria = false;
        storeUpdatedSearchCriteria.Clear();
      }
    public void initSearchCriteria()
      {
        if (flagHasSearchCriteria)
          {
            for (int num9 = 0; num9 < storeSearchCriteria.Count; ++num9)
              {
              }
          }
        flagHasSearchCriteria = true;
        storeSearchCriteria.Clear();
      }
    public void appendSearchCriteria(FlightSearchCriterionJSON  to_append)
      {
        if (!flagHasSearchCriteria)
          {
            flagHasSearchCriteria = true;
            storeSearchCriteria.Clear();
          }
        Debug.Assert(flagHasSearchCriteria);
        storeSearchCriteria.Add(to_append);
      }
    public void appendSearchCriteria(FlightSearchCriterionJSON.TypeValue new_value)
      {
        appendSearchCriteria(new FlightSearchCriterionJSON(new_value));
      }
    public void appendSearchCriteria(string chars)
      {
        FlightSearchCriterionJSON.TypeValueKnownValues known = FlightSearchCriterionJSON.stringToValue(chars);
        FlightSearchCriterionJSON.TypeValue new_value = new FlightSearchCriterionJSON.TypeValue();
        if (known == FlightSearchCriterionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendSearchCriteria(new_value);
      }
    public void unsetSearchCriteria()
      {
        if (flagHasSearchCriteria)
          {
            for (int num10 = 0; num10 < storeSearchCriteria.Count; ++num10)
              {
              }
          }
        flagHasSearchCriteria = false;
        storeSearchCriteria.Clear();
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
    public void setLabel(string new_value)
      {
        flagHasLabel = true;
        storeLabel = new_value;
      }
    public void unsetLabel()
      {
        flagHasLabel = false;
      }
    public void setSpokenUpdateLabel(string new_value)
      {
        flagHasSpokenUpdateLabel = true;
        storeSpokenUpdateLabel = new_value;
      }
    public void unsetSpokenUpdateLabel()
      {
        flagHasSpokenUpdateLabel = false;
      }
    public void setUpdateLabel(string new_value)
      {
        flagHasUpdateLabel = true;
        storeUpdateLabel = new_value;
      }
    public void unsetUpdateLabel()
      {
        flagHasUpdateLabel = false;
      }

    public virtual void extraFlightBookingFilterAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightBookingFilterSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightBookingFilterLookup(key);
        if (old_field == null)
          {
            extraFlightBookingFilterAppendPair(key, new_component);
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
        if (flagHasFlightSegmentFilters)
          {
            handler.start_pair("FlightSegmentFilters");
            handler.start_array();
            for (int num1 = 0; num1 < storeFlightSegmentFilters.Count; ++num1)
              {
                if (partial_allowed)
                    storeFlightSegmentFilters[num1].write_partial_as_json(handler);
                else
                    storeFlightSegmentFilters[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasIndexOfLastUpdatedFlightSegmentFilter)
          {
            handler.start_pair("IndexOfLastUpdatedFlightSegmentFilter");
            handler.number_value(storeIndexOfLastUpdatedFlightSegmentFilter);
          }
        if (flagHasFlightTripType)
          {
            handler.start_pair("FlightTripType");
            if (partial_allowed)
                storeFlightTripType.write_partial_as_json(handler);
            else
                storeFlightTripType.write_as_json(handler);
          }
        if (flagHasSameDayOrOvernight)
          {
            handler.start_pair("SameDayOrOvernight");
            if (partial_allowed)
                storeSameDayOrOvernight.write_partial_as_json(handler);
            else
                storeSameDayOrOvernight.write_as_json(handler);
          }
        if (flagHasReturnFlightSegmentFilter)
          {
            handler.start_pair("ReturnFlightSegmentFilter");
            if (partial_allowed)
                storeReturnFlightSegmentFilter.write_partial_as_json(handler);
            else
                storeReturnFlightSegmentFilter.write_as_json(handler);
          }
        if (flagHasLastTripDuration)
          {
            handler.start_pair("LastTripDuration");
            if (textStoreLastTripDuration != "")
                handler.number_value(textStoreLastTripDuration);
            else if (((double)(long)storeLastTripDuration) == storeLastTripDuration)
                handler.number_value((long)storeLastTripDuration);
            else
                handler.number_value(storeLastTripDuration);
          }
        if (flagHasNumberOfStops)
          {
            handler.start_pair("NumberOfStops");
            if (partial_allowed)
                storeNumberOfStops.write_partial_as_json(handler);
            else
                storeNumberOfStops.write_as_json(handler);
          }
        if (flagHasPriceRange)
          {
            handler.start_pair("PriceRange");
            if (partial_allowed)
                storePriceRange.write_partial_as_json(handler);
            else
                storePriceRange.write_as_json(handler);
          }
        if (flagHasRangeOfLayoverDuration)
          {
            handler.start_pair("RangeOfLayoverDuration");
            if (partial_allowed)
                storeRangeOfLayoverDuration.write_partial_as_json(handler);
            else
                storeRangeOfLayoverDuration.write_as_json(handler);
          }
        if (flagHasRangeOfTotalLayoverDuration)
          {
            handler.start_pair("RangeOfTotalLayoverDuration");
            if (partial_allowed)
                storeRangeOfTotalLayoverDuration.write_partial_as_json(handler);
            else
                storeRangeOfTotalLayoverDuration.write_as_json(handler);
          }
        if (flagHasRangeOfTravelDuration)
          {
            handler.start_pair("RangeOfTravelDuration");
            if (partial_allowed)
                storeRangeOfTravelDuration.write_partial_as_json(handler);
            else
                storeRangeOfTravelDuration.write_as_json(handler);
          }
        if (flagHasRangeOfTotalTravelDuration)
          {
            handler.start_pair("RangeOfTotalTravelDuration");
            if (partial_allowed)
                storeRangeOfTotalTravelDuration.write_partial_as_json(handler);
            else
                storeRangeOfTotalTravelDuration.write_as_json(handler);
          }
        if (flagHasAvoidChangePenalties)
          {
            handler.start_pair("AvoidChangePenalties");
            handler.boolean_value(storeAvoidChangePenalties);
          }
        if (flagHasAirlineFilter)
          {
            handler.start_pair("AirlineFilter");
            if (partial_allowed)
                storeAirlineFilter.write_partial_as_json(handler);
            else
                storeAirlineFilter.write_as_json(handler);
          }
        if (flagHasSeatPreferences)
          {
            handler.start_pair("SeatPreferences");
            if (partial_allowed)
                storeSeatPreferences.write_partial_as_json(handler);
            else
                storeSeatPreferences.write_as_json(handler);
          }
        if (flagHasCabinClassFilter)
          {
            handler.start_pair("CabinClassFilter");
            if (partial_allowed)
                storeCabinClassFilter.write_partial_as_json(handler);
            else
                storeCabinClassFilter.write_as_json(handler);
          }
        if (flagHasAirportFilter)
          {
            handler.start_pair("AirportFilter");
            if (partial_allowed)
                storeAirportFilter.write_partial_as_json(handler);
            else
                storeAirportFilter.write_as_json(handler);
          }
        if (flagHasPassengerTypesWithCount)
          {
            handler.start_pair("PassengerTypesWithCount");
            Debug.Assert(storePassengerTypesWithCount.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storePassengerTypesWithCount.Count; ++num2)
              {
                if (partial_allowed)
                    storePassengerTypesWithCount[num2].write_partial_as_json(handler);
                else
                    storePassengerTypesWithCount[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasNumberOfSeatsOrTicketsRequested)
          {
            handler.start_pair("NumberOfSeatsOrTicketsRequested");
            handler.number_value(storeNumberOfSeatsOrTicketsRequested);
          }
        Debug.Assert(partial_allowed || flagHasFlightListSortCriteria);
        if (flagHasFlightListSortCriteria)
          {
            handler.start_pair("FlightListSortCriteria");
            handler.start_array();
            for (int num3 = 0; num3 < storeFlightListSortCriteria.Count; ++num3)
              {
                if (partial_allowed)
                    storeFlightListSortCriteria[num3].write_partial_as_json(handler);
                else
                    storeFlightListSortCriteria[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasUpdatedSearchCriteria)
          {
            handler.start_pair("UpdatedSearchCriteria");
            Debug.Assert(storeUpdatedSearchCriteria.Count >= 1);
            handler.start_array();
            for (int num4 = 0; num4 < storeUpdatedSearchCriteria.Count; ++num4)
              {
                if (partial_allowed)
                    storeUpdatedSearchCriteria[num4].write_partial_as_json(handler);
                else
                    storeUpdatedSearchCriteria[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSearchCriteria)
          {
            handler.start_pair("SearchCriteria");
            Debug.Assert(storeSearchCriteria.Count >= 1);
            handler.start_array();
            for (int num5 = 0; num5 < storeSearchCriteria.Count; ++num5)
              {
                if (partial_allowed)
                    storeSearchCriteria[num5].write_partial_as_json(handler);
                else
                    storeSearchCriteria[num5].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSpokenLabel)
          {
            handler.start_pair("SpokenLabel");
            handler.string_value(storeSpokenLabel);
          }
        if (flagHasLabel)
          {
            handler.start_pair("Label");
            handler.string_value(storeLabel);
          }
        if (flagHasSpokenUpdateLabel)
          {
            handler.start_pair("SpokenUpdateLabel");
            handler.string_value(storeSpokenUpdateLabel);
          }
        if (flagHasUpdateLabel)
          {
            handler.start_pair("UpdateLabel");
            handler.string_value(storeUpdateLabel);
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
        if (!(hasFlightListSortCriteria()))
          {
            return "When parsing the object for %what%, the \"FlightListSortCriteria\" field was missing.";
          }
        return null;
      }

    public static FlightBookingFilterJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightBookingFilterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingFilter", ignore_extras);
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
    public static FlightBookingFilterJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightBookingFilterJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightBookingFilterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingFilter", ignore_extras);
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
    public static FlightBookingFilterJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightBookingFilterJSON from_text(string text, bool ignore_extras)
      {
        FlightBookingFilterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingFilter", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightBookingFilterJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightBookingFilterJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightBookingFilterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightBookingFilter", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private FlightSegmentFilterJSON.HoldingArrayGenerator fieldGeneratorFlightSegmentFilters;
    private class FieldHoldingGeneratorIndexOfLastUpdatedFlightSegmentFilter : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorIndexOfLastUpdatedFlightSegmentFilter(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorIndexOfLastUpdatedFlightSegmentFilter : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorIndexOfLastUpdatedFlightSegmentFilter(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorIndexOfLastUpdatedFlightSegmentFilter fieldGeneratorIndexOfLastUpdatedFlightSegmentFilter;
        private FlightTripTypeJSON.HoldingGenerator fieldGeneratorFlightTripType;
        private SameDayOrOvernightJSON.HoldingGenerator fieldGeneratorSameDayOrOvernight;
        private FlightSegmentFilterJSON.HoldingGenerator fieldGeneratorReturnFlightSegmentFilter;
        private JSONHoldingNumberTextGenerator fieldGeneratorLastTripDuration;
        private IntegerIntervalJSON.HoldingGenerator fieldGeneratorNumberOfStops;
        private PriceRangeJSON.HoldingGenerator fieldGeneratorPriceRange;
        private RangeOfDurationJSON.HoldingGenerator fieldGeneratorRangeOfLayoverDuration;
        private RangeOfDurationJSON.HoldingGenerator fieldGeneratorRangeOfTotalLayoverDuration;
        private RangeOfDurationJSON.HoldingGenerator fieldGeneratorRangeOfTravelDuration;
        private RangeOfDurationJSON.HoldingGenerator fieldGeneratorRangeOfTotalTravelDuration;
        private JSONHoldingBooleanGenerator fieldGeneratorAvoidChangePenalties;
        private AirlineFilterJSON.HoldingGenerator fieldGeneratorAirlineFilter;
        private FlightSeatPreferencesJSON.HoldingGenerator fieldGeneratorSeatPreferences;
        private CabinClassFilterJSON.HoldingGenerator fieldGeneratorCabinClassFilter;
        private FlightTravelLocationFilterJSON.HoldingGenerator fieldGeneratorAirportFilter;
        private FlightPassengerTypeCountJSON.HoldingArrayGenerator fieldGeneratorPassengerTypesWithCount;
    private class FieldHoldingGeneratorNumberOfSeatsOrTicketsRequested : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNumberOfSeatsOrTicketsRequested(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumberOfSeatsOrTicketsRequested : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumberOfSeatsOrTicketsRequested(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorNumberOfSeatsOrTicketsRequested fieldGeneratorNumberOfSeatsOrTicketsRequested;
        private FlightListSortCriterionJSON.HoldingArrayGenerator fieldGeneratorFlightListSortCriteria;
        private FlightSearchCriterionJSON.HoldingArrayGenerator fieldGeneratorUpdatedSearchCriteria;
        private FlightSearchCriterionJSON.HoldingArrayGenerator fieldGeneratorSearchCriteria;
        private JSONHoldingStringGenerator fieldGeneratorSpokenLabel;
        private JSONHoldingStringGenerator fieldGeneratorLabel;
        private JSONHoldingStringGenerator fieldGeneratorSpokenUpdateLabel;
        private JSONHoldingStringGenerator fieldGeneratorUpdateLabel;
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
            FlightBookingFilterJSON result = new FlightBookingFilterJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightBookingFilterAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightBookingFilterJSON result)
          {
            if (fieldGeneratorFlightSegmentFilters.have_value)
              {
                result.initFlightSegmentFilters();
                int count = fieldGeneratorFlightSegmentFilters.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFlightSegmentFilters(fieldGeneratorFlightSegmentFilters.value[num]);
                  }
                fieldGeneratorFlightSegmentFilters.value.Clear();
                fieldGeneratorFlightSegmentFilters.have_value = false;
              }
            if (fieldGeneratorIndexOfLastUpdatedFlightSegmentFilter.have_value)
              {
                result.setIndexOfLastUpdatedFlightSegmentFilter(fieldGeneratorIndexOfLastUpdatedFlightSegmentFilter.value);
                fieldGeneratorIndexOfLastUpdatedFlightSegmentFilter.have_value = false;
              }
            if (fieldGeneratorFlightTripType.have_value)
              {
                result.setFlightTripType(fieldGeneratorFlightTripType.value);
                fieldGeneratorFlightTripType.have_value = false;
              }
            if (fieldGeneratorSameDayOrOvernight.have_value)
              {
                result.setSameDayOrOvernight(fieldGeneratorSameDayOrOvernight.value);
                fieldGeneratorSameDayOrOvernight.have_value = false;
              }
            if (fieldGeneratorReturnFlightSegmentFilter.have_value)
              {
                result.setReturnFlightSegmentFilter(fieldGeneratorReturnFlightSegmentFilter.value);
                fieldGeneratorReturnFlightSegmentFilter.have_value = false;
              }
            if (fieldGeneratorLastTripDuration.have_value)
              {
                result.setLastTripDurationText(fieldGeneratorLastTripDuration.value);
                fieldGeneratorLastTripDuration.have_value = false;
              }
            if (fieldGeneratorNumberOfStops.have_value)
              {
                result.setNumberOfStops(fieldGeneratorNumberOfStops.value);
                fieldGeneratorNumberOfStops.have_value = false;
              }
            if (fieldGeneratorPriceRange.have_value)
              {
                result.setPriceRange(fieldGeneratorPriceRange.value);
                fieldGeneratorPriceRange.have_value = false;
              }
            if (fieldGeneratorRangeOfLayoverDuration.have_value)
              {
                result.setRangeOfLayoverDuration(fieldGeneratorRangeOfLayoverDuration.value);
                fieldGeneratorRangeOfLayoverDuration.have_value = false;
              }
            if (fieldGeneratorRangeOfTotalLayoverDuration.have_value)
              {
                result.setRangeOfTotalLayoverDuration(fieldGeneratorRangeOfTotalLayoverDuration.value);
                fieldGeneratorRangeOfTotalLayoverDuration.have_value = false;
              }
            if (fieldGeneratorRangeOfTravelDuration.have_value)
              {
                result.setRangeOfTravelDuration(fieldGeneratorRangeOfTravelDuration.value);
                fieldGeneratorRangeOfTravelDuration.have_value = false;
              }
            if (fieldGeneratorRangeOfTotalTravelDuration.have_value)
              {
                result.setRangeOfTotalTravelDuration(fieldGeneratorRangeOfTotalTravelDuration.value);
                fieldGeneratorRangeOfTotalTravelDuration.have_value = false;
              }
            if (fieldGeneratorAvoidChangePenalties.have_value)
              {
                result.setAvoidChangePenalties(fieldGeneratorAvoidChangePenalties.value);
                fieldGeneratorAvoidChangePenalties.have_value = false;
              }
            if (fieldGeneratorAirlineFilter.have_value)
              {
                result.setAirlineFilter(fieldGeneratorAirlineFilter.value);
                fieldGeneratorAirlineFilter.have_value = false;
              }
            if (fieldGeneratorSeatPreferences.have_value)
              {
                result.setSeatPreferences(fieldGeneratorSeatPreferences.value);
                fieldGeneratorSeatPreferences.have_value = false;
              }
            if (fieldGeneratorCabinClassFilter.have_value)
              {
                result.setCabinClassFilter(fieldGeneratorCabinClassFilter.value);
                fieldGeneratorCabinClassFilter.have_value = false;
              }
            if (fieldGeneratorAirportFilter.have_value)
              {
                result.setAirportFilter(fieldGeneratorAirportFilter.value);
                fieldGeneratorAirportFilter.have_value = false;
              }
            if (fieldGeneratorPassengerTypesWithCount.have_value)
              {
                result.initPassengerTypesWithCount();
                int count = fieldGeneratorPassengerTypesWithCount.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPassengerTypesWithCount(fieldGeneratorPassengerTypesWithCount.value[num]);
                  }
                fieldGeneratorPassengerTypesWithCount.value.Clear();
                fieldGeneratorPassengerTypesWithCount.have_value = false;
              }
            if (fieldGeneratorNumberOfSeatsOrTicketsRequested.have_value)
              {
                result.setNumberOfSeatsOrTicketsRequested(fieldGeneratorNumberOfSeatsOrTicketsRequested.value);
                fieldGeneratorNumberOfSeatsOrTicketsRequested.have_value = false;
              }
            if (fieldGeneratorFlightListSortCriteria.have_value)
              {
                result.initFlightListSortCriteria();
                int count = fieldGeneratorFlightListSortCriteria.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFlightListSortCriteria(fieldGeneratorFlightListSortCriteria.value[num]);
                  }
                fieldGeneratorFlightListSortCriteria.value.Clear();
                fieldGeneratorFlightListSortCriteria.have_value = false;
              }
            else if ((!(result.hasFlightListSortCriteria())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightListSortCriteria\" field was missing.");
              }
            if (fieldGeneratorUpdatedSearchCriteria.have_value)
              {
                result.initUpdatedSearchCriteria();
                int count = fieldGeneratorUpdatedSearchCriteria.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendUpdatedSearchCriteria(fieldGeneratorUpdatedSearchCriteria.value[num]);
                  }
                fieldGeneratorUpdatedSearchCriteria.value.Clear();
                fieldGeneratorUpdatedSearchCriteria.have_value = false;
              }
            if (fieldGeneratorSearchCriteria.have_value)
              {
                result.initSearchCriteria();
                int count = fieldGeneratorSearchCriteria.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSearchCriteria(fieldGeneratorSearchCriteria.value[num]);
                  }
                fieldGeneratorSearchCriteria.value.Clear();
                fieldGeneratorSearchCriteria.have_value = false;
              }
            if (fieldGeneratorSpokenLabel.have_value)
              {
                result.setSpokenLabel(fieldGeneratorSpokenLabel.value);
                fieldGeneratorSpokenLabel.have_value = false;
              }
            if (fieldGeneratorLabel.have_value)
              {
                result.setLabel(fieldGeneratorLabel.value);
                fieldGeneratorLabel.have_value = false;
              }
            if (fieldGeneratorSpokenUpdateLabel.have_value)
              {
                result.setSpokenUpdateLabel(fieldGeneratorSpokenUpdateLabel.value);
                fieldGeneratorSpokenUpdateLabel.have_value = false;
              }
            if (fieldGeneratorUpdateLabel.have_value)
              {
                result.setUpdateLabel(fieldGeneratorUpdateLabel.value);
                fieldGeneratorUpdateLabel.have_value = false;
              }
          }
        protected abstract void handle_result(FlightBookingFilterJSON new_result);
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
                                    case 'l':
                                        if ((String.Compare(field_name, 4, "ineFilter", 0, 9, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorAirlineFilter;
                                        break;
                                    case 'p':
                                        if ((String.Compare(field_name, 4, "ortFilter", 0, 9, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorAirportFilter;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'v':
                            if ((String.Compare(field_name, 2, "oidChangePenalties", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorAvoidChangePenalties;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "abinClassFilter", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorCabinClassFilter;
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "light", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 7, "istSortCriteria", 0, 15, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorFlightListSortCriteria;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 7, "egmentFilters", 0, 13, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorFlightSegmentFilters;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 7, "ripType", 0, 7, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorFlightTripType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "ndexOfLastUpdatedFlightSegmentFilter", 0, 36, false) == 0) && (field_name.Length == 37))
                        return fieldGeneratorIndexOfLastUpdatedFlightSegmentFilter;
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "a", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'b':
                                if ((String.Compare(field_name, 3, "el", 0, 2, false) == 0) && (field_name.Length == 5))
                                    return fieldGeneratorLabel;
                                break;
                            case 's':
                                if ((String.Compare(field_name, 3, "tTripDuration", 0, 13, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorLastTripDuration;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "umberOfS", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 10, "atsOrTicketsRequested", 0, 21, false) == 0) && (field_name.Length == 31))
                                    return fieldGeneratorNumberOfSeatsOrTicketsRequested;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 10, "ops", 0, 3, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorNumberOfStops;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ssengerTypesWithCount", 0, 21, false) == 0) && (field_name.Length == 23))
                                return fieldGeneratorPassengerTypesWithCount;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "iceRange", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorPriceRange;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "ngeOf", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'L':
                                        if ((String.Compare(field_name, 8, "ayoverDuration", 0, 14, false) == 0) && (field_name.Length == 22))
                                            return fieldGeneratorRangeOfLayoverDuration;
                                        break;
                                    case 'T':
                                        switch (field_name[8])
                                          {
                                            case 'o':
                                                if (String.Compare(field_name, 9, "tal", 0, 3, false) == 0)
                                                  {
                                                    switch (field_name[12])
                                                      {
                                                        case 'L':
                                                            if ((String.Compare(field_name, 13, "ayoverDuration", 0, 14, false) == 0) && (field_name.Length == 27))
                                                                return fieldGeneratorRangeOfTotalLayoverDuration;
                                                            break;
                                                        case 'T':
                                                            if ((String.Compare(field_name, 13, "ravelDuration", 0, 13, false) == 0) && (field_name.Length == 26))
                                                                return fieldGeneratorRangeOfTotalTravelDuration;
                                                            break;
                                                        default:
                                                            break;
                                                      }
                                                  }
                                                break;
                                            case 'r':
                                                if ((String.Compare(field_name, 9, "avelDuration", 0, 12, false) == 0) && (field_name.Length == 21))
                                                    return fieldGeneratorRangeOfTravelDuration;
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
                            if ((String.Compare(field_name, 2, "turnFlightSegmentFilter", 0, 23, false) == 0) && (field_name.Length == 25))
                                return fieldGeneratorReturnFlightSegmentFilter;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "meDayOrOvernight", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorSameDayOrOvernight;
                            break;
                        case 'e':
                            if (String.Compare(field_name, 2, "a", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'r':
                                        if ((String.Compare(field_name, 4, "chCriteria", 0, 10, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorSearchCriteria;
                                        break;
                                    case 't':
                                        if ((String.Compare(field_name, 4, "Preferences", 0, 11, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorSeatPreferences;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'p':
                            if (String.Compare(field_name, 2, "oken", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'L':
                                        if ((String.Compare(field_name, 7, "abel", 0, 4, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorSpokenLabel;
                                        break;
                                    case 'U':
                                        if ((String.Compare(field_name, 7, "pdateLabel", 0, 10, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorSpokenUpdateLabel;
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
                case 'U':
                    if (String.Compare(field_name, 1, "pdate", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 7, "abel", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorUpdateLabel;
                                break;
                            case 'd':
                                if ((String.Compare(field_name, 7, "SearchCriteria", 0, 14, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorUpdatedSearchCriteria;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFlightSegmentFilters = new FlightSegmentFilterJSON.HoldingArrayGenerator("field \"FlightSegmentFilters\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorIndexOfLastUpdatedFlightSegmentFilter = new FieldHoldingGeneratorIndexOfLastUpdatedFlightSegmentFilter("field \"IndexOfLastUpdatedFlightSegmentFilter\" of the FlightBookingFilter class");
            fieldGeneratorFlightTripType = new FlightTripTypeJSON.HoldingGenerator("field \"FlightTripType\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorSameDayOrOvernight = new SameDayOrOvernightJSON.HoldingGenerator("field \"SameDayOrOvernight\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorReturnFlightSegmentFilter = new FlightSegmentFilterJSON.HoldingGenerator("field \"ReturnFlightSegmentFilter\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorLastTripDuration = new JSONHoldingNumberTextGenerator("field \"LastTripDuration\" of the FlightBookingFilter class");
            fieldGeneratorNumberOfStops = new IntegerIntervalJSON.HoldingGenerator("field \"NumberOfStops\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorPriceRange = new PriceRangeJSON.HoldingGenerator("field \"PriceRange\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorRangeOfLayoverDuration = new RangeOfDurationJSON.HoldingGenerator("field \"RangeOfLayoverDuration\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorRangeOfTotalLayoverDuration = new RangeOfDurationJSON.HoldingGenerator("field \"RangeOfTotalLayoverDuration\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorRangeOfTravelDuration = new RangeOfDurationJSON.HoldingGenerator("field \"RangeOfTravelDuration\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorRangeOfTotalTravelDuration = new RangeOfDurationJSON.HoldingGenerator("field \"RangeOfTotalTravelDuration\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorAvoidChangePenalties = new JSONHoldingBooleanGenerator("field \"AvoidChangePenalties\" of the FlightBookingFilter class");
            fieldGeneratorAirlineFilter = new AirlineFilterJSON.HoldingGenerator("field \"AirlineFilter\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorSeatPreferences = new FlightSeatPreferencesJSON.HoldingGenerator("field \"SeatPreferences\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorCabinClassFilter = new CabinClassFilterJSON.HoldingGenerator("field \"CabinClassFilter\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorAirportFilter = new FlightTravelLocationFilterJSON.HoldingGenerator("field \"AirportFilter\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorPassengerTypesWithCount = new FlightPassengerTypeCountJSON.HoldingArrayGenerator("field \"PassengerTypesWithCount\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorNumberOfSeatsOrTicketsRequested = new FieldHoldingGeneratorNumberOfSeatsOrTicketsRequested("field \"NumberOfSeatsOrTicketsRequested\" of the FlightBookingFilter class");
            fieldGeneratorFlightListSortCriteria = new FlightListSortCriterionJSON.HoldingArrayGenerator("field \"FlightListSortCriteria\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorUpdatedSearchCriteria = new FlightSearchCriterionJSON.HoldingArrayGenerator("field \"UpdatedSearchCriteria\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorSearchCriteria = new FlightSearchCriterionJSON.HoldingArrayGenerator("field \"SearchCriteria\" of the FlightBookingFilter class", ignore_extras);
            fieldGeneratorSpokenLabel = new JSONHoldingStringGenerator("field \"SpokenLabel\" of the FlightBookingFilter class");
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the FlightBookingFilter class");
            fieldGeneratorSpokenUpdateLabel = new JSONHoldingStringGenerator("field \"SpokenUpdateLabel\" of the FlightBookingFilter class");
            fieldGeneratorUpdateLabel = new JSONHoldingStringGenerator("field \"UpdateLabel\" of the FlightBookingFilter class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightBookingFilter class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFlightSegmentFilters = new FlightSegmentFilterJSON.HoldingArrayGenerator("field \"FlightSegmentFilters\" of the FlightBookingFilter class", false);
            fieldGeneratorIndexOfLastUpdatedFlightSegmentFilter = new FieldHoldingGeneratorIndexOfLastUpdatedFlightSegmentFilter("field \"IndexOfLastUpdatedFlightSegmentFilter\" of the FlightBookingFilter class");
            fieldGeneratorFlightTripType = new FlightTripTypeJSON.HoldingGenerator("field \"FlightTripType\" of the FlightBookingFilter class", false);
            fieldGeneratorSameDayOrOvernight = new SameDayOrOvernightJSON.HoldingGenerator("field \"SameDayOrOvernight\" of the FlightBookingFilter class", false);
            fieldGeneratorReturnFlightSegmentFilter = new FlightSegmentFilterJSON.HoldingGenerator("field \"ReturnFlightSegmentFilter\" of the FlightBookingFilter class", false);
            fieldGeneratorLastTripDuration = new JSONHoldingNumberTextGenerator("field \"LastTripDuration\" of the FlightBookingFilter class");
            fieldGeneratorNumberOfStops = new IntegerIntervalJSON.HoldingGenerator("field \"NumberOfStops\" of the FlightBookingFilter class", false);
            fieldGeneratorPriceRange = new PriceRangeJSON.HoldingGenerator("field \"PriceRange\" of the FlightBookingFilter class", false);
            fieldGeneratorRangeOfLayoverDuration = new RangeOfDurationJSON.HoldingGenerator("field \"RangeOfLayoverDuration\" of the FlightBookingFilter class", false);
            fieldGeneratorRangeOfTotalLayoverDuration = new RangeOfDurationJSON.HoldingGenerator("field \"RangeOfTotalLayoverDuration\" of the FlightBookingFilter class", false);
            fieldGeneratorRangeOfTravelDuration = new RangeOfDurationJSON.HoldingGenerator("field \"RangeOfTravelDuration\" of the FlightBookingFilter class", false);
            fieldGeneratorRangeOfTotalTravelDuration = new RangeOfDurationJSON.HoldingGenerator("field \"RangeOfTotalTravelDuration\" of the FlightBookingFilter class", false);
            fieldGeneratorAvoidChangePenalties = new JSONHoldingBooleanGenerator("field \"AvoidChangePenalties\" of the FlightBookingFilter class");
            fieldGeneratorAirlineFilter = new AirlineFilterJSON.HoldingGenerator("field \"AirlineFilter\" of the FlightBookingFilter class", false);
            fieldGeneratorSeatPreferences = new FlightSeatPreferencesJSON.HoldingGenerator("field \"SeatPreferences\" of the FlightBookingFilter class", false);
            fieldGeneratorCabinClassFilter = new CabinClassFilterJSON.HoldingGenerator("field \"CabinClassFilter\" of the FlightBookingFilter class", false);
            fieldGeneratorAirportFilter = new FlightTravelLocationFilterJSON.HoldingGenerator("field \"AirportFilter\" of the FlightBookingFilter class", false);
            fieldGeneratorPassengerTypesWithCount = new FlightPassengerTypeCountJSON.HoldingArrayGenerator("field \"PassengerTypesWithCount\" of the FlightBookingFilter class", false);
            fieldGeneratorNumberOfSeatsOrTicketsRequested = new FieldHoldingGeneratorNumberOfSeatsOrTicketsRequested("field \"NumberOfSeatsOrTicketsRequested\" of the FlightBookingFilter class");
            fieldGeneratorFlightListSortCriteria = new FlightListSortCriterionJSON.HoldingArrayGenerator("field \"FlightListSortCriteria\" of the FlightBookingFilter class", false);
            fieldGeneratorUpdatedSearchCriteria = new FlightSearchCriterionJSON.HoldingArrayGenerator("field \"UpdatedSearchCriteria\" of the FlightBookingFilter class", false);
            fieldGeneratorSearchCriteria = new FlightSearchCriterionJSON.HoldingArrayGenerator("field \"SearchCriteria\" of the FlightBookingFilter class", false);
            fieldGeneratorSpokenLabel = new JSONHoldingStringGenerator("field \"SpokenLabel\" of the FlightBookingFilter class");
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the FlightBookingFilter class");
            fieldGeneratorSpokenUpdateLabel = new JSONHoldingStringGenerator("field \"SpokenUpdateLabel\" of the FlightBookingFilter class");
            fieldGeneratorUpdateLabel = new JSONHoldingStringGenerator("field \"UpdateLabel\" of the FlightBookingFilter class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightBookingFilter class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFlightSegmentFilters.reset();
            fieldGeneratorIndexOfLastUpdatedFlightSegmentFilter.reset();
            fieldGeneratorFlightTripType.reset();
            fieldGeneratorSameDayOrOvernight.reset();
            fieldGeneratorReturnFlightSegmentFilter.reset();
            fieldGeneratorLastTripDuration.reset();
            fieldGeneratorNumberOfStops.reset();
            fieldGeneratorPriceRange.reset();
            fieldGeneratorRangeOfLayoverDuration.reset();
            fieldGeneratorRangeOfTotalLayoverDuration.reset();
            fieldGeneratorRangeOfTravelDuration.reset();
            fieldGeneratorRangeOfTotalTravelDuration.reset();
            fieldGeneratorAvoidChangePenalties.reset();
            fieldGeneratorAirlineFilter.reset();
            fieldGeneratorSeatPreferences.reset();
            fieldGeneratorCabinClassFilter.reset();
            fieldGeneratorAirportFilter.reset();
            fieldGeneratorPassengerTypesWithCount.reset();
            fieldGeneratorNumberOfSeatsOrTicketsRequested.reset();
            fieldGeneratorFlightListSortCriteria.reset();
            fieldGeneratorUpdatedSearchCriteria.reset();
            fieldGeneratorSearchCriteria.reset();
            fieldGeneratorSpokenLabel.reset();
            fieldGeneratorLabel.reset();
            fieldGeneratorSpokenUpdateLabel.reset();
            fieldGeneratorUpdateLabel.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFlightSegmentFilters.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFlightTripType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSameDayOrOvernight.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorReturnFlightSegmentFilter.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNumberOfStops.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPriceRange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRangeOfLayoverDuration.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRangeOfTotalLayoverDuration.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRangeOfTravelDuration.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRangeOfTotalTravelDuration.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAirlineFilter.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeatPreferences.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCabinClassFilter.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAirportFilter.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPassengerTypesWithCount.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFlightListSortCriteria.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUpdatedSearchCriteria.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSearchCriteria.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFlightSegmentFilters.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFlightTripType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSameDayOrOvernight.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorReturnFlightSegmentFilter.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNumberOfStops.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPriceRange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRangeOfLayoverDuration.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRangeOfTotalLayoverDuration.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRangeOfTravelDuration.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRangeOfTotalTravelDuration.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAirlineFilter.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeatPreferences.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCabinClassFilter.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAirportFilter.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPassengerTypesWithCount.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFlightListSortCriteria.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUpdatedSearchCriteria.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSearchCriteria.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightBookingFilterJSON  result)
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
        public FlightBookingFilterJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightBookingFilterJSON  result)
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
    protected virtual void handle_result(List<FlightBookingFilterJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightBookingFilterJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightBookingFilterJSON>();
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
    public List<FlightBookingFilterJSON> value;
  };
  };
