/* file "FlightProductJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FlightProductJSON : JSONBase
  {
    private bool flagHasLabel;
    private string storeLabel;
    private bool flagHasDataProvider;
    private string storeDataProvider;
    private bool flagHasProductID;
    private string storeProductID;
    private bool flagHasTotalPrice;
    private MoneyJSON  storeTotalPrice;
    private bool flagHasFareBreakdownForEachPassengerType;
    private List< FlightFareBreakdownForPassengerTypeJSON  > storeFareBreakdownForEachPassengerType;
    private bool flagHasTotalTaxesAndFees;
    private MoneyJSON  storeTotalTaxesAndFees;
    private bool flagHasTotalBookingFees;
    private MoneyJSON  storeTotalBookingFees;
    private bool flagHasTotalTravelDuration;
    private double storeTotalTravelDuration;
    private string textStoreTotalTravelDuration;
    private bool flagHasTotalFlightDuration;
    private double storeTotalFlightDuration;
    private string textStoreTotalFlightDuration;
    private bool flagHasTotalLayoverDuration;
    private double storeTotalLayoverDuration;
    private string textStoreTotalLayoverDuration;
    private bool flagHasTotalNumberOfStops;
    private BigInteger storeTotalNumberOfStops;
    private bool flagHasNumberOfSeatsAvailable;
    private BigInteger storeNumberOfSeatsAvailable;
    private bool flagHasFlightSegmentGroups;
    private List< FlightSegmentGroupJSON  > storeFlightSegmentGroups;
    private bool flagHasDetailsUrl;
    private string storeDetailsUrl;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Label of FlightProductJSON is not a string.");
        setLabel(json_string.getData());
      }


    private void  fromJSONDataProvider(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DataProvider of FlightProductJSON is not a string.");
        setDataProvider(json_string.getData());
      }


    private void  fromJSONProductID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ProductID of FlightProductJSON is not a string.");
        setProductID(json_string.getData());
      }


    private void  fromJSONTotalPrice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setTotalPrice(convert_classy);
      }


    private void  fromJSONFareBreakdownForEachPassengerType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FareBreakdownForEachPassengerType of FlightProductJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field FareBreakdownForEachPassengerType of FlightProductJSON has too few elements.");
        List< FlightFareBreakdownForPassengerTypeJSON  > vector_FareBreakdownForEachPassengerType1 = new List< FlightFareBreakdownForPassengerTypeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightFareBreakdownForPassengerTypeJSON convert_classy = FlightFareBreakdownForPassengerTypeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FareBreakdownForEachPassengerType1.Add(convert_classy);
          }
        Debug.Assert(vector_FareBreakdownForEachPassengerType1.Count >= 1);
        initFareBreakdownForEachPassengerType();
        for (int num1 = 0; num1 < vector_FareBreakdownForEachPassengerType1.Count; ++num1)
            appendFareBreakdownForEachPassengerType(vector_FareBreakdownForEachPassengerType1[num1]);
        for (int num1 = 0; num1 < vector_FareBreakdownForEachPassengerType1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTotalTaxesAndFees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setTotalTaxesAndFees(convert_classy);
      }


    private void  fromJSONTotalBookingFees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MoneyJSON convert_classy = MoneyJSON.from_json(json_value, ignore_extras, true);
        setTotalBookingFees(convert_classy);
      }


    private void  fromJSONTotalTravelDuration(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TotalTravelDuration of FlightProductJSON is not a number.");
              }
          }
        setTotalTravelDurationText(the_rational_text);
      }


    private void  fromJSONTotalFlightDuration(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TotalFlightDuration of FlightProductJSON is not a number.");
              }
          }
        setTotalFlightDurationText(the_rational_text);
      }


    private void  fromJSONTotalLayoverDuration(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TotalLayoverDuration of FlightProductJSON is not a number.");
              }
          }
        setTotalLayoverDurationText(the_rational_text);
      }


    private void  fromJSONTotalNumberOfStops(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TotalNumberOfStops of FlightProductJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TotalNumberOfStops of FlightProductJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTotalNumberOfStops(extracted_integer);
      }


    private void  fromJSONNumberOfSeatsAvailable(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NumberOfSeatsAvailable of FlightProductJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumberOfSeatsAvailable of FlightProductJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumberOfSeatsAvailable(extracted_integer);
      }


    private void  fromJSONFlightSegmentGroups(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlightSegmentGroups of FlightProductJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field FlightSegmentGroups of FlightProductJSON has too few elements.");
        List< FlightSegmentGroupJSON  > vector_FlightSegmentGroups1 = new List< FlightSegmentGroupJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightSegmentGroupJSON convert_classy = FlightSegmentGroupJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlightSegmentGroups1.Add(convert_classy);
          }
        Debug.Assert(vector_FlightSegmentGroups1.Count >= 1);
        initFlightSegmentGroups();
        for (int num2 = 0; num2 < vector_FlightSegmentGroups1.Count; ++num2)
            appendFlightSegmentGroups(vector_FlightSegmentGroups1[num2]);
        for (int num1 = 0; num1 < vector_FlightSegmentGroups1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDetailsUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DetailsUrl of FlightProductJSON is not a string.");
        setDetailsUrl(json_string.getData());
      }


    public FlightProductJSON()
      {
        flagHasLabel = false;
        flagHasDataProvider = false;
        flagHasProductID = false;
        flagHasTotalPrice = false;
        flagHasFareBreakdownForEachPassengerType = false;
        flagHasTotalTaxesAndFees = false;
        flagHasTotalBookingFees = false;
        flagHasTotalTravelDuration = false;
        flagHasTotalFlightDuration = false;
        flagHasTotalLayoverDuration = false;
        flagHasTotalNumberOfStops = false;
        flagHasNumberOfSeatsAvailable = false;
        flagHasFlightSegmentGroups = false;
        flagHasDetailsUrl = false;
        storeFareBreakdownForEachPassengerType = new List< FlightFareBreakdownForPassengerTypeJSON  >();
        storeFlightSegmentGroups = new List< FlightSegmentGroupJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasDataProvider()
      {
        return flagHasDataProvider;
      }

    public string  getDataProvider()
      {
        Debug.Assert(flagHasDataProvider);
        return storeDataProvider;
      }

    public bool  hasProductID()
      {
        return flagHasProductID;
      }

    public string  getProductID()
      {
        Debug.Assert(flagHasProductID);
        return storeProductID;
      }

    public bool  hasTotalPrice()
      {
        return flagHasTotalPrice;
      }

    public MoneyJSON   getTotalPrice()
      {
        Debug.Assert(flagHasTotalPrice);
        return storeTotalPrice;
      }

    public bool  hasFareBreakdownForEachPassengerType()
      {
        return flagHasFareBreakdownForEachPassengerType;
      }

    public int  countOfFareBreakdownForEachPassengerType()
      {
        Debug.Assert(flagHasFareBreakdownForEachPassengerType);
        return storeFareBreakdownForEachPassengerType.Count;
      }

    public FlightFareBreakdownForPassengerTypeJSON   elementOfFareBreakdownForEachPassengerType(int element_num)
      {
        Debug.Assert(flagHasFareBreakdownForEachPassengerType);
        return storeFareBreakdownForEachPassengerType[element_num];
      }

    public List< FlightFareBreakdownForPassengerTypeJSON  >  getFareBreakdownForEachPassengerType()
      {
        Debug.Assert(flagHasFareBreakdownForEachPassengerType);
        return storeFareBreakdownForEachPassengerType;
      }

    public bool  hasTotalTaxesAndFees()
      {
        return flagHasTotalTaxesAndFees;
      }

    public MoneyJSON   getTotalTaxesAndFees()
      {
        Debug.Assert(flagHasTotalTaxesAndFees);
        return storeTotalTaxesAndFees;
      }

    public bool  hasTotalBookingFees()
      {
        return flagHasTotalBookingFees;
      }

    public MoneyJSON   getTotalBookingFees()
      {
        Debug.Assert(flagHasTotalBookingFees);
        return storeTotalBookingFees;
      }

    public bool  hasTotalTravelDuration()
      {
        return flagHasTotalTravelDuration;
      }

    public double  getTotalTravelDuration()
      {
        Debug.Assert(flagHasTotalTravelDuration);
        if (textStoreTotalTravelDuration != "")
          {
            return Double.Parse(textStoreTotalTravelDuration);
          }
        return storeTotalTravelDuration;
      }

    public string  getTotalTravelDurationAsText()
      {
        Debug.Assert(flagHasTotalTravelDuration);
        if (textStoreTotalTravelDuration == "")
          {
            return Convert.ToString(storeTotalTravelDuration);
          }
        else
          {
            return (textStoreTotalTravelDuration);
          }
      }

    public bool  hasTotalFlightDuration()
      {
        return flagHasTotalFlightDuration;
      }

    public double  getTotalFlightDuration()
      {
        Debug.Assert(flagHasTotalFlightDuration);
        if (textStoreTotalFlightDuration != "")
          {
            return Double.Parse(textStoreTotalFlightDuration);
          }
        return storeTotalFlightDuration;
      }

    public string  getTotalFlightDurationAsText()
      {
        Debug.Assert(flagHasTotalFlightDuration);
        if (textStoreTotalFlightDuration == "")
          {
            return Convert.ToString(storeTotalFlightDuration);
          }
        else
          {
            return (textStoreTotalFlightDuration);
          }
      }

    public bool  hasTotalLayoverDuration()
      {
        return flagHasTotalLayoverDuration;
      }

    public double  getTotalLayoverDuration()
      {
        Debug.Assert(flagHasTotalLayoverDuration);
        if (textStoreTotalLayoverDuration != "")
          {
            return Double.Parse(textStoreTotalLayoverDuration);
          }
        return storeTotalLayoverDuration;
      }

    public string  getTotalLayoverDurationAsText()
      {
        Debug.Assert(flagHasTotalLayoverDuration);
        if (textStoreTotalLayoverDuration == "")
          {
            return Convert.ToString(storeTotalLayoverDuration);
          }
        else
          {
            return (textStoreTotalLayoverDuration);
          }
      }

    public bool  hasTotalNumberOfStops()
      {
        return flagHasTotalNumberOfStops;
      }

    public BigInteger  getTotalNumberOfStops()
      {
        Debug.Assert(flagHasTotalNumberOfStops);
        return storeTotalNumberOfStops;
      }

    public bool  hasNumberOfSeatsAvailable()
      {
        return flagHasNumberOfSeatsAvailable;
      }

    public BigInteger  getNumberOfSeatsAvailable()
      {
        Debug.Assert(flagHasNumberOfSeatsAvailable);
        return storeNumberOfSeatsAvailable;
      }

    public bool  hasFlightSegmentGroups()
      {
        return flagHasFlightSegmentGroups;
      }

    public int  countOfFlightSegmentGroups()
      {
        Debug.Assert(flagHasFlightSegmentGroups);
        return storeFlightSegmentGroups.Count;
      }

    public FlightSegmentGroupJSON   elementOfFlightSegmentGroups(int element_num)
      {
        Debug.Assert(flagHasFlightSegmentGroups);
        return storeFlightSegmentGroups[element_num];
      }

    public List< FlightSegmentGroupJSON  >  getFlightSegmentGroups()
      {
        Debug.Assert(flagHasFlightSegmentGroups);
        return storeFlightSegmentGroups;
      }

    public bool  hasDetailsUrl()
      {
        return flagHasDetailsUrl;
      }

    public string  getDetailsUrl()
      {
        Debug.Assert(flagHasDetailsUrl);
        return storeDetailsUrl;
      }


    public virtual int extraFlightProductComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightProductComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightProductComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightProductLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setDataProvider(string new_value)
      {
        flagHasDataProvider = true;
        storeDataProvider = new_value;
      }
    public void unsetDataProvider()
      {
        flagHasDataProvider = false;
      }
    public void setProductID(string new_value)
      {
        flagHasProductID = true;
        storeProductID = new_value;
      }
    public void unsetProductID()
      {
        flagHasProductID = false;
      }
    public void setTotalPrice(MoneyJSON  new_value)
      {
        if (flagHasTotalPrice)
          {
          }
        flagHasTotalPrice = true;
        storeTotalPrice = new_value;
      }
    public void unsetTotalPrice()
      {
        if (flagHasTotalPrice)
          {
          }
        flagHasTotalPrice = false;
      }
    public void initFareBreakdownForEachPassengerType()
      {
        if (flagHasFareBreakdownForEachPassengerType)
          {
            for (int num1 = 0; num1 < storeFareBreakdownForEachPassengerType.Count; ++num1)
              {
              }
          }
        flagHasFareBreakdownForEachPassengerType = true;
        storeFareBreakdownForEachPassengerType.Clear();
      }
    public void appendFareBreakdownForEachPassengerType(FlightFareBreakdownForPassengerTypeJSON  to_append)
      {
        if (!flagHasFareBreakdownForEachPassengerType)
          {
            flagHasFareBreakdownForEachPassengerType = true;
            storeFareBreakdownForEachPassengerType.Clear();
          }
        Debug.Assert(flagHasFareBreakdownForEachPassengerType);
        storeFareBreakdownForEachPassengerType.Add(to_append);
      }
    public void unsetFareBreakdownForEachPassengerType()
      {
        if (flagHasFareBreakdownForEachPassengerType)
          {
            for (int num2 = 0; num2 < storeFareBreakdownForEachPassengerType.Count; ++num2)
              {
              }
          }
        flagHasFareBreakdownForEachPassengerType = false;
        storeFareBreakdownForEachPassengerType.Clear();
      }
    public void setTotalTaxesAndFees(MoneyJSON  new_value)
      {
        if (flagHasTotalTaxesAndFees)
          {
          }
        flagHasTotalTaxesAndFees = true;
        storeTotalTaxesAndFees = new_value;
      }
    public void unsetTotalTaxesAndFees()
      {
        if (flagHasTotalTaxesAndFees)
          {
          }
        flagHasTotalTaxesAndFees = false;
      }
    public void setTotalBookingFees(MoneyJSON  new_value)
      {
        if (flagHasTotalBookingFees)
          {
          }
        flagHasTotalBookingFees = true;
        storeTotalBookingFees = new_value;
      }
    public void unsetTotalBookingFees()
      {
        if (flagHasTotalBookingFees)
          {
          }
        flagHasTotalBookingFees = false;
      }
    public void setTotalTravelDuration(double new_value)
      {
        flagHasTotalTravelDuration = true;
        storeTotalTravelDuration = new_value;
        textStoreTotalTravelDuration = "";
      }
    public void setTotalTravelDurationText(string new_value)
      {
        flagHasTotalTravelDuration = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TotalTravelDuration of FlightProductJSON is not a valid number.");
        textStoreTotalTravelDuration = new_value;
      }
    public void unsetTotalTravelDuration()
      {
        flagHasTotalTravelDuration = false;
      }
    public void setTotalFlightDuration(double new_value)
      {
        flagHasTotalFlightDuration = true;
        storeTotalFlightDuration = new_value;
        textStoreTotalFlightDuration = "";
      }
    public void setTotalFlightDurationText(string new_value)
      {
        flagHasTotalFlightDuration = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TotalFlightDuration of FlightProductJSON is not a valid number.");
        textStoreTotalFlightDuration = new_value;
      }
    public void unsetTotalFlightDuration()
      {
        flagHasTotalFlightDuration = false;
      }
    public void setTotalLayoverDuration(double new_value)
      {
        flagHasTotalLayoverDuration = true;
        storeTotalLayoverDuration = new_value;
        textStoreTotalLayoverDuration = "";
      }
    public void setTotalLayoverDurationText(string new_value)
      {
        flagHasTotalLayoverDuration = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TotalLayoverDuration of FlightProductJSON is not a valid number.");
        textStoreTotalLayoverDuration = new_value;
      }
    public void unsetTotalLayoverDuration()
      {
        flagHasTotalLayoverDuration = false;
      }
    public void setTotalNumberOfStops(BigInteger new_value)
      {
        flagHasTotalNumberOfStops = true;
        if (new_value < 0)
            throw new Exception("The value for field TotalNumberOfStops of FlightProductJSON is less than the lower bound (0) for that field.");
        storeTotalNumberOfStops = new_value;
      }
    public void unsetTotalNumberOfStops()
      {
        flagHasTotalNumberOfStops = false;
      }
    public void setNumberOfSeatsAvailable(BigInteger new_value)
      {
        flagHasNumberOfSeatsAvailable = true;
        if (new_value < 0)
            throw new Exception("The value for field NumberOfSeatsAvailable of FlightProductJSON is less than the lower bound (0) for that field.");
        storeNumberOfSeatsAvailable = new_value;
      }
    public void unsetNumberOfSeatsAvailable()
      {
        flagHasNumberOfSeatsAvailable = false;
      }
    public void initFlightSegmentGroups()
      {
        if (flagHasFlightSegmentGroups)
          {
            for (int num3 = 0; num3 < storeFlightSegmentGroups.Count; ++num3)
              {
              }
          }
        flagHasFlightSegmentGroups = true;
        storeFlightSegmentGroups.Clear();
      }
    public void appendFlightSegmentGroups(FlightSegmentGroupJSON  to_append)
      {
        if (!flagHasFlightSegmentGroups)
          {
            flagHasFlightSegmentGroups = true;
            storeFlightSegmentGroups.Clear();
          }
        Debug.Assert(flagHasFlightSegmentGroups);
        storeFlightSegmentGroups.Add(to_append);
      }
    public void unsetFlightSegmentGroups()
      {
        if (flagHasFlightSegmentGroups)
          {
            for (int num4 = 0; num4 < storeFlightSegmentGroups.Count; ++num4)
              {
              }
          }
        flagHasFlightSegmentGroups = false;
        storeFlightSegmentGroups.Clear();
      }
    public void setDetailsUrl(string new_value)
      {
        flagHasDetailsUrl = true;
        storeDetailsUrl = new_value;
      }
    public void unsetDetailsUrl()
      {
        flagHasDetailsUrl = false;
      }

    public virtual void extraFlightProductAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightProductSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightProductLookup(key);
        if (old_field == null)
          {
            extraFlightProductAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasLabel);
        if (flagHasLabel)
          {
            handler.start_pair("Label");
            handler.string_value(storeLabel);
          }
        Debug.Assert(partial_allowed || flagHasDataProvider);
        if (flagHasDataProvider)
          {
            handler.start_pair("DataProvider");
            handler.string_value(storeDataProvider);
          }
        Debug.Assert(partial_allowed || flagHasProductID);
        if (flagHasProductID)
          {
            handler.start_pair("ProductID");
            handler.string_value(storeProductID);
          }
        Debug.Assert(partial_allowed || flagHasTotalPrice);
        if (flagHasTotalPrice)
          {
            handler.start_pair("TotalPrice");
            if (partial_allowed)
                storeTotalPrice.write_partial_as_json(handler);
            else
                storeTotalPrice.write_as_json(handler);
          }
        if (flagHasFareBreakdownForEachPassengerType)
          {
            handler.start_pair("FareBreakdownForEachPassengerType");
            Debug.Assert(storeFareBreakdownForEachPassengerType.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeFareBreakdownForEachPassengerType.Count; ++num1)
              {
                if (partial_allowed)
                    storeFareBreakdownForEachPassengerType[num1].write_partial_as_json(handler);
                else
                    storeFareBreakdownForEachPassengerType[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasTotalTaxesAndFees);
        if (flagHasTotalTaxesAndFees)
          {
            handler.start_pair("TotalTaxesAndFees");
            if (partial_allowed)
                storeTotalTaxesAndFees.write_partial_as_json(handler);
            else
                storeTotalTaxesAndFees.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasTotalBookingFees);
        if (flagHasTotalBookingFees)
          {
            handler.start_pair("TotalBookingFees");
            if (partial_allowed)
                storeTotalBookingFees.write_partial_as_json(handler);
            else
                storeTotalBookingFees.write_as_json(handler);
          }
        if (flagHasTotalTravelDuration)
          {
            handler.start_pair("TotalTravelDuration");
            if (textStoreTotalTravelDuration != "")
                handler.number_value(textStoreTotalTravelDuration);
            else if (((double)(long)storeTotalTravelDuration) == storeTotalTravelDuration)
                handler.number_value((long)storeTotalTravelDuration);
            else
                handler.number_value(storeTotalTravelDuration);
          }
        if (flagHasTotalFlightDuration)
          {
            handler.start_pair("TotalFlightDuration");
            if (textStoreTotalFlightDuration != "")
                handler.number_value(textStoreTotalFlightDuration);
            else if (((double)(long)storeTotalFlightDuration) == storeTotalFlightDuration)
                handler.number_value((long)storeTotalFlightDuration);
            else
                handler.number_value(storeTotalFlightDuration);
          }
        if (flagHasTotalLayoverDuration)
          {
            handler.start_pair("TotalLayoverDuration");
            if (textStoreTotalLayoverDuration != "")
                handler.number_value(textStoreTotalLayoverDuration);
            else if (((double)(long)storeTotalLayoverDuration) == storeTotalLayoverDuration)
                handler.number_value((long)storeTotalLayoverDuration);
            else
                handler.number_value(storeTotalLayoverDuration);
          }
        Debug.Assert(partial_allowed || flagHasTotalNumberOfStops);
        if (flagHasTotalNumberOfStops)
          {
            handler.start_pair("TotalNumberOfStops");
            handler.number_value(storeTotalNumberOfStops);
          }
        Debug.Assert(partial_allowed || flagHasNumberOfSeatsAvailable);
        if (flagHasNumberOfSeatsAvailable)
          {
            handler.start_pair("NumberOfSeatsAvailable");
            handler.number_value(storeNumberOfSeatsAvailable);
          }
        Debug.Assert(partial_allowed || flagHasFlightSegmentGroups);
        if (flagHasFlightSegmentGroups)
          {
            handler.start_pair("FlightSegmentGroups");
            Debug.Assert(storeFlightSegmentGroups.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeFlightSegmentGroups.Count; ++num2)
              {
                if (partial_allowed)
                    storeFlightSegmentGroups[num2].write_partial_as_json(handler);
                else
                    storeFlightSegmentGroups[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasDetailsUrl);
        if (flagHasDetailsUrl)
          {
            handler.start_pair("DetailsUrl");
            handler.string_value(storeDetailsUrl);
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
        if (!(hasLabel()))
          {
            return "When parsing the object for %what%, the \"Label\" field was missing.";
          }
        if (!(hasDataProvider()))
          {
            return "When parsing the object for %what%, the \"DataProvider\" field was missing.";
          }
        if (!(hasProductID()))
          {
            return "When parsing the object for %what%, the \"ProductID\" field was missing.";
          }
        if (!(hasTotalPrice()))
          {
            return "When parsing the object for %what%, the \"TotalPrice\" field was missing.";
          }
        if (!(hasTotalTaxesAndFees()))
          {
            return "When parsing the object for %what%, the \"TotalTaxesAndFees\" field was missing.";
          }
        if (!(hasTotalBookingFees()))
          {
            return "When parsing the object for %what%, the \"TotalBookingFees\" field was missing.";
          }
        if (!(hasTotalNumberOfStops()))
          {
            return "When parsing the object for %what%, the \"TotalNumberOfStops\" field was missing.";
          }
        if (!(hasNumberOfSeatsAvailable()))
          {
            return "When parsing the object for %what%, the \"NumberOfSeatsAvailable\" field was missing.";
          }
        if (!(hasFlightSegmentGroups()))
          {
            return "When parsing the object for %what%, the \"FlightSegmentGroups\" field was missing.";
          }
        if (!(hasDetailsUrl()))
          {
            return "When parsing the object for %what%, the \"DetailsUrl\" field was missing.";
          }
        return null;
      }

    public static FlightProductJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightProductJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightProduct", ignore_extras);
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
    public static FlightProductJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightProductJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightProductJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightProduct", ignore_extras);
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
    public static FlightProductJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightProductJSON from_text(string text, bool ignore_extras)
      {
        FlightProductJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightProduct", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightProductJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightProductJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightProductJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightProduct", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorLabel;
        private JSONHoldingStringGenerator fieldGeneratorDataProvider;
        private JSONHoldingStringGenerator fieldGeneratorProductID;
        private MoneyJSON.HoldingGenerator fieldGeneratorTotalPrice;
        private FlightFareBreakdownForPassengerTypeJSON.HoldingArrayGenerator fieldGeneratorFareBreakdownForEachPassengerType;
        private MoneyJSON.HoldingGenerator fieldGeneratorTotalTaxesAndFees;
        private MoneyJSON.HoldingGenerator fieldGeneratorTotalBookingFees;
        private JSONHoldingNumberTextGenerator fieldGeneratorTotalTravelDuration;
        private JSONHoldingNumberTextGenerator fieldGeneratorTotalFlightDuration;
        private JSONHoldingNumberTextGenerator fieldGeneratorTotalLayoverDuration;
    private class FieldHoldingGeneratorTotalNumberOfStops : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTotalNumberOfStops(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTotalNumberOfStops : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTotalNumberOfStops(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTotalNumberOfStops fieldGeneratorTotalNumberOfStops;
    private class FieldHoldingGeneratorNumberOfSeatsAvailable : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNumberOfSeatsAvailable(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumberOfSeatsAvailable : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumberOfSeatsAvailable(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorNumberOfSeatsAvailable fieldGeneratorNumberOfSeatsAvailable;
        private FlightSegmentGroupJSON.HoldingArrayGenerator fieldGeneratorFlightSegmentGroups;
        private JSONHoldingStringGenerator fieldGeneratorDetailsUrl;
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
            FlightProductJSON result = new FlightProductJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightProductAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightProductJSON result)
          {
            if (fieldGeneratorLabel.have_value)
              {
                result.setLabel(fieldGeneratorLabel.value);
                fieldGeneratorLabel.have_value = false;
              }
            else if ((!(result.hasLabel())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Label\" field was missing.");
              }
            if (fieldGeneratorDataProvider.have_value)
              {
                result.setDataProvider(fieldGeneratorDataProvider.value);
                fieldGeneratorDataProvider.have_value = false;
              }
            else if ((!(result.hasDataProvider())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DataProvider\" field was missing.");
              }
            if (fieldGeneratorProductID.have_value)
              {
                result.setProductID(fieldGeneratorProductID.value);
                fieldGeneratorProductID.have_value = false;
              }
            else if ((!(result.hasProductID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ProductID\" field was missing.");
              }
            if (fieldGeneratorTotalPrice.have_value)
              {
                result.setTotalPrice(fieldGeneratorTotalPrice.value);
                fieldGeneratorTotalPrice.have_value = false;
              }
            else if ((!(result.hasTotalPrice())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TotalPrice\" field was missing.");
              }
            if (fieldGeneratorFareBreakdownForEachPassengerType.have_value)
              {
                result.initFareBreakdownForEachPassengerType();
                int count = fieldGeneratorFareBreakdownForEachPassengerType.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFareBreakdownForEachPassengerType(fieldGeneratorFareBreakdownForEachPassengerType.value[num]);
                  }
                fieldGeneratorFareBreakdownForEachPassengerType.value.Clear();
                fieldGeneratorFareBreakdownForEachPassengerType.have_value = false;
              }
            if (fieldGeneratorTotalTaxesAndFees.have_value)
              {
                result.setTotalTaxesAndFees(fieldGeneratorTotalTaxesAndFees.value);
                fieldGeneratorTotalTaxesAndFees.have_value = false;
              }
            else if ((!(result.hasTotalTaxesAndFees())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TotalTaxesAndFees\" field was missing.");
              }
            if (fieldGeneratorTotalBookingFees.have_value)
              {
                result.setTotalBookingFees(fieldGeneratorTotalBookingFees.value);
                fieldGeneratorTotalBookingFees.have_value = false;
              }
            else if ((!(result.hasTotalBookingFees())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TotalBookingFees\" field was missing.");
              }
            if (fieldGeneratorTotalTravelDuration.have_value)
              {
                result.setTotalTravelDurationText(fieldGeneratorTotalTravelDuration.value);
                fieldGeneratorTotalTravelDuration.have_value = false;
              }
            if (fieldGeneratorTotalFlightDuration.have_value)
              {
                result.setTotalFlightDurationText(fieldGeneratorTotalFlightDuration.value);
                fieldGeneratorTotalFlightDuration.have_value = false;
              }
            if (fieldGeneratorTotalLayoverDuration.have_value)
              {
                result.setTotalLayoverDurationText(fieldGeneratorTotalLayoverDuration.value);
                fieldGeneratorTotalLayoverDuration.have_value = false;
              }
            if (fieldGeneratorTotalNumberOfStops.have_value)
              {
                result.setTotalNumberOfStops(fieldGeneratorTotalNumberOfStops.value);
                fieldGeneratorTotalNumberOfStops.have_value = false;
              }
            else if ((!(result.hasTotalNumberOfStops())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TotalNumberOfStops\" field was missing.");
              }
            if (fieldGeneratorNumberOfSeatsAvailable.have_value)
              {
                result.setNumberOfSeatsAvailable(fieldGeneratorNumberOfSeatsAvailable.value);
                fieldGeneratorNumberOfSeatsAvailable.have_value = false;
              }
            else if ((!(result.hasNumberOfSeatsAvailable())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NumberOfSeatsAvailable\" field was missing.");
              }
            if (fieldGeneratorFlightSegmentGroups.have_value)
              {
                result.initFlightSegmentGroups();
                int count = fieldGeneratorFlightSegmentGroups.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFlightSegmentGroups(fieldGeneratorFlightSegmentGroups.value[num]);
                  }
                fieldGeneratorFlightSegmentGroups.value.Clear();
                fieldGeneratorFlightSegmentGroups.have_value = false;
              }
            else if ((!(result.hasFlightSegmentGroups())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightSegmentGroups\" field was missing.");
              }
            if (fieldGeneratorDetailsUrl.have_value)
              {
                result.setDetailsUrl(fieldGeneratorDetailsUrl.value);
                fieldGeneratorDetailsUrl.have_value = false;
              }
            else if ((!(result.hasDetailsUrl())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DetailsUrl\" field was missing.");
              }
          }
        protected abstract void handle_result(FlightProductJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "taProvider", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorDataProvider;
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "tailsUrl", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorDetailsUrl;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "reBreakdownForEachPassengerType", 0, 31, false) == 0) && (field_name.Length == 33))
                                return fieldGeneratorFareBreakdownForEachPassengerType;
                            break;
                        case 'l':
                            if ((String.Compare(field_name, 2, "ightSegmentGroups", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorFlightSegmentGroups;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorLabel;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umberOfSeatsAvailable", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorNumberOfSeatsAvailable;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "roductID", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorProductID;
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "otal", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 6, "ookingFees", 0, 10, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorTotalBookingFees;
                                break;
                            case 'F':
                                if ((String.Compare(field_name, 6, "lightDuration", 0, 13, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorTotalFlightDuration;
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 6, "ayoverDuration", 0, 14, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorTotalLayoverDuration;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 6, "umberOfStops", 0, 12, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorTotalNumberOfStops;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 6, "rice", 0, 4, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorTotalPrice;
                                break;
                            case 'T':
                                switch (field_name[6])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 7, "xesAndFees", 0, 10, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorTotalTaxesAndFees;
                                        break;
                                    case 'r':
                                        if ((String.Compare(field_name, 7, "avelDuration", 0, 12, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorTotalTravelDuration;
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
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the FlightProduct class");
            fieldGeneratorDataProvider = new JSONHoldingStringGenerator("field \"DataProvider\" of the FlightProduct class");
            fieldGeneratorProductID = new JSONHoldingStringGenerator("field \"ProductID\" of the FlightProduct class");
            fieldGeneratorTotalPrice = new MoneyJSON.HoldingGenerator("field \"TotalPrice\" of the FlightProduct class", ignore_extras);
            fieldGeneratorFareBreakdownForEachPassengerType = new FlightFareBreakdownForPassengerTypeJSON.HoldingArrayGenerator("field \"FareBreakdownForEachPassengerType\" of the FlightProduct class", ignore_extras);
            fieldGeneratorTotalTaxesAndFees = new MoneyJSON.HoldingGenerator("field \"TotalTaxesAndFees\" of the FlightProduct class", ignore_extras);
            fieldGeneratorTotalBookingFees = new MoneyJSON.HoldingGenerator("field \"TotalBookingFees\" of the FlightProduct class", ignore_extras);
            fieldGeneratorTotalTravelDuration = new JSONHoldingNumberTextGenerator("field \"TotalTravelDuration\" of the FlightProduct class");
            fieldGeneratorTotalFlightDuration = new JSONHoldingNumberTextGenerator("field \"TotalFlightDuration\" of the FlightProduct class");
            fieldGeneratorTotalLayoverDuration = new JSONHoldingNumberTextGenerator("field \"TotalLayoverDuration\" of the FlightProduct class");
            fieldGeneratorTotalNumberOfStops = new FieldHoldingGeneratorTotalNumberOfStops("field \"TotalNumberOfStops\" of the FlightProduct class");
            fieldGeneratorNumberOfSeatsAvailable = new FieldHoldingGeneratorNumberOfSeatsAvailable("field \"NumberOfSeatsAvailable\" of the FlightProduct class");
            fieldGeneratorFlightSegmentGroups = new FlightSegmentGroupJSON.HoldingArrayGenerator("field \"FlightSegmentGroups\" of the FlightProduct class", ignore_extras);
            fieldGeneratorDetailsUrl = new JSONHoldingStringGenerator("field \"DetailsUrl\" of the FlightProduct class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightProduct class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the FlightProduct class");
            fieldGeneratorDataProvider = new JSONHoldingStringGenerator("field \"DataProvider\" of the FlightProduct class");
            fieldGeneratorProductID = new JSONHoldingStringGenerator("field \"ProductID\" of the FlightProduct class");
            fieldGeneratorTotalPrice = new MoneyJSON.HoldingGenerator("field \"TotalPrice\" of the FlightProduct class", false);
            fieldGeneratorFareBreakdownForEachPassengerType = new FlightFareBreakdownForPassengerTypeJSON.HoldingArrayGenerator("field \"FareBreakdownForEachPassengerType\" of the FlightProduct class", false);
            fieldGeneratorTotalTaxesAndFees = new MoneyJSON.HoldingGenerator("field \"TotalTaxesAndFees\" of the FlightProduct class", false);
            fieldGeneratorTotalBookingFees = new MoneyJSON.HoldingGenerator("field \"TotalBookingFees\" of the FlightProduct class", false);
            fieldGeneratorTotalTravelDuration = new JSONHoldingNumberTextGenerator("field \"TotalTravelDuration\" of the FlightProduct class");
            fieldGeneratorTotalFlightDuration = new JSONHoldingNumberTextGenerator("field \"TotalFlightDuration\" of the FlightProduct class");
            fieldGeneratorTotalLayoverDuration = new JSONHoldingNumberTextGenerator("field \"TotalLayoverDuration\" of the FlightProduct class");
            fieldGeneratorTotalNumberOfStops = new FieldHoldingGeneratorTotalNumberOfStops("field \"TotalNumberOfStops\" of the FlightProduct class");
            fieldGeneratorNumberOfSeatsAvailable = new FieldHoldingGeneratorNumberOfSeatsAvailable("field \"NumberOfSeatsAvailable\" of the FlightProduct class");
            fieldGeneratorFlightSegmentGroups = new FlightSegmentGroupJSON.HoldingArrayGenerator("field \"FlightSegmentGroups\" of the FlightProduct class", false);
            fieldGeneratorDetailsUrl = new JSONHoldingStringGenerator("field \"DetailsUrl\" of the FlightProduct class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightProduct class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLabel.reset();
            fieldGeneratorDataProvider.reset();
            fieldGeneratorProductID.reset();
            fieldGeneratorTotalPrice.reset();
            fieldGeneratorFareBreakdownForEachPassengerType.reset();
            fieldGeneratorTotalTaxesAndFees.reset();
            fieldGeneratorTotalBookingFees.reset();
            fieldGeneratorTotalTravelDuration.reset();
            fieldGeneratorTotalFlightDuration.reset();
            fieldGeneratorTotalLayoverDuration.reset();
            fieldGeneratorTotalNumberOfStops.reset();
            fieldGeneratorNumberOfSeatsAvailable.reset();
            fieldGeneratorFlightSegmentGroups.reset();
            fieldGeneratorDetailsUrl.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTotalPrice.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFareBreakdownForEachPassengerType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTotalTaxesAndFees.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTotalBookingFees.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFlightSegmentGroups.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTotalPrice.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFareBreakdownForEachPassengerType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTotalTaxesAndFees.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTotalBookingFees.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFlightSegmentGroups.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightProductJSON  result)
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
        public FlightProductJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightProductJSON  result)
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
    protected virtual void handle_result(List<FlightProductJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightProductJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightProductJSON>();
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
    public List<FlightProductJSON> value;
  };
  };
