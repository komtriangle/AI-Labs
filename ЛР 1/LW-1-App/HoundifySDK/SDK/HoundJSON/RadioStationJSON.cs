/* file "RadioStationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RadioStationJSON : JSONBase
  {
    public enum TypeBroadcastProviderKnownValues
      {
        BroadcastProvider_IHeartRadio,
        BroadcastProvider_Sirius,
        BroadcastProvider_XM,
        BroadcastProvider_Audacy,
        BroadcastProvider__none
      };
    public struct TypeBroadcastProvider
      {
        public bool in_known_list;
        public string string_value;
        public TypeBroadcastProviderKnownValues list_value;
      };

    public static TypeBroadcastProviderKnownValues  stringToBroadcastProvider(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "udacy", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeBroadcastProviderKnownValues.BroadcastProvider_Audacy;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "HeartRadio", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeBroadcastProviderKnownValues.BroadcastProvider_IHeartRadio;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "irius", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeBroadcastProviderKnownValues.BroadcastProvider_Sirius;
                break;
            case 'X':
                if ((String.Compare(chars, 1, "M", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeBroadcastProviderKnownValues.BroadcastProvider_XM;
                break;
            default:
                break;
          }
        return TypeBroadcastProviderKnownValues.BroadcastProvider__none;
      }

    public static string  stringFromBroadcastProvider(TypeBroadcastProviderKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeBroadcastProviderKnownValues.BroadcastProvider_IHeartRadio:
                return "IHeartRadio";
            case TypeBroadcastProviderKnownValues.BroadcastProvider_Sirius:
                return "Sirius";
            case TypeBroadcastProviderKnownValues.BroadcastProvider_XM:
                return "XM";
            case TypeBroadcastProviderKnownValues.BroadcastProvider_Audacy:
                return "Audacy";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeAttributionKnownValues
      {
        Attribution_IHeartRadio,
        Attribution_Audacy,
        Attribution__none
      };
    public struct TypeAttribution
      {
        public bool in_known_list;
        public string string_value;
        public TypeAttributionKnownValues list_value;
      };

    public static TypeAttributionKnownValues  stringToAttribution(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "udacy", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeAttributionKnownValues.Attribution_Audacy;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "HeartRadio", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeAttributionKnownValues.Attribution_IHeartRadio;
                break;
            default:
                break;
          }
        return TypeAttributionKnownValues.Attribution__none;
      }

    public static string  stringFromAttribution(TypeAttributionKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeAttributionKnownValues.Attribution_IHeartRadio:
                return "IHeartRadio";
            case TypeAttributionKnownValues.Attribution_Audacy:
                return "Audacy";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasStationName;
    private string storeStationName;
    private bool flagHasStationNameSpoken;
    private string storeStationNameSpoken;
    private bool flagHasDescription;
    private string storeDescription;
    private bool flagHasGenres;
    private List< string > storeGenres;
    private bool flagHasAMFrequency;
    private short storeAMFrequency;
    private bool flagHasFMFrequency;
    private double storeFMFrequency;
    private string textStoreFMFrequency;
    private bool flagHasCallSign;
    private string storeCallSign;
    private bool flagHasBroadcastProvider;
    private TypeBroadcastProvider storeBroadcastProvider;
    private bool flagHasLogoImage;
    private string storeLogoImage;
    private bool flagHasStationID;
    private string storeStationID;
    private bool flagHasFulfillments;
    private List< RadioStationFulfillmentJSON  > storeFulfillments;
    private bool flagHasAttribution;
    private TypeAttribution storeAttribution;
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private bool flagHasStationNumber;
    private BigInteger storeStationNumber;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStationName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StationName of RadioStationJSON is not a string.");
        setStationName(json_string.getData());
      }


    private void  fromJSONStationNameSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StationNameSpoken of RadioStationJSON is not a string.");
        setStationNameSpoken(json_string.getData());
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Description of RadioStationJSON is not a string.");
        setDescription(json_string.getData());
      }


    private void  fromJSONGenres(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Genres of RadioStationJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Genres of RadioStationJSON has too few elements.");
        List< string > vector_Genres1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Genres of RadioStationJSON is not a string.");
            vector_Genres1.Add(json_string.getData());
          }
        Debug.Assert(vector_Genres1.Count >= 1);
        initGenres();
        for (int num1 = 0; num1 < vector_Genres1.Count; ++num1)
            appendGenres(vector_Genres1[num1]);
        for (int num1 = 0; num1 < vector_Genres1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAMFrequency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        short extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AMFrequency of RadioStationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AMFrequency of RadioStationJSON is not an integer.");
              }
            extracted_integer = (short)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (short)(json_integer.getLongInt())        ;
          }
        setAMFrequency(extracted_integer);
      }


    private void  fromJSONFMFrequency(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field FMFrequency of RadioStationJSON is not a number.");
              }
          }
        setFMFrequencyText(the_rational_text);
      }


    private void  fromJSONCallSign(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CallSign of RadioStationJSON is not a string.");
        setCallSign(json_string.getData());
      }


    private void  fromJSONBroadcastProvider(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BroadcastProvider of RadioStationJSON is not a string.");
        TypeBroadcastProvider the_open_enum = new TypeBroadcastProvider();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "udacy", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeBroadcastProviderKnownValues.BroadcastProvider_Audacy;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "HeartRadio", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeBroadcastProviderKnownValues.BroadcastProvider_IHeartRadio;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "irius", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeBroadcastProviderKnownValues.BroadcastProvider_Sirius;
                        goto open_enum_is_done;
                      }
                break;
            case 'X':
                if ((String.Compare(json_string.getData(), 1, "M", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeBroadcastProviderKnownValues.BroadcastProvider_XM;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setBroadcastProvider(the_open_enum);
      }


    private void  fromJSONLogoImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LogoImage of RadioStationJSON is not a string.");
        setLogoImage(json_string.getData());
      }


    private void  fromJSONStationID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StationID of RadioStationJSON is not a string.");
        setStationID(json_string.getData());
      }


    private void  fromJSONFulfillments(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Fulfillments of RadioStationJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Fulfillments of RadioStationJSON has too few elements.");
        List< RadioStationFulfillmentJSON  > vector_Fulfillments1 = new List< RadioStationFulfillmentJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RadioStationFulfillmentJSON convert_classy = RadioStationFulfillmentJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Fulfillments1.Add(convert_classy);
          }
        Debug.Assert(vector_Fulfillments1.Count >= 1);
        initFulfillments();
        for (int num2 = 0; num2 < vector_Fulfillments1.Count; ++num2)
            appendFulfillments(vector_Fulfillments1[num2]);
        for (int num1 = 0; num1 < vector_Fulfillments1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Attribution of RadioStationJSON is not a string.");
        TypeAttribution the_open_enum = new TypeAttribution();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "udacy", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeAttributionKnownValues.Attribution_Audacy;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "HeartRadio", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeAttributionKnownValues.Attribution_IHeartRadio;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setAttribution(the_open_enum);
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    private void  fromJSONStationNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StationNumber of RadioStationJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StationNumber of RadioStationJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setStationNumber(extracted_integer);
      }


    public RadioStationJSON()
      {
        flagHasStationName = false;
        flagHasStationNameSpoken = false;
        flagHasDescription = false;
        flagHasGenres = false;
        flagHasAMFrequency = false;
        flagHasFMFrequency = false;
        flagHasCallSign = false;
        flagHasBroadcastProvider = false;
        flagHasLogoImage = false;
        flagHasStationID = false;
        flagHasFulfillments = false;
        flagHasAttribution = false;
        flagHasLocation = false;
        flagHasStationNumber = false;
        storeGenres = new List< string >();
        storeFulfillments = new List< RadioStationFulfillmentJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStationName()
      {
        return flagHasStationName;
      }

    public string  getStationName()
      {
        Debug.Assert(flagHasStationName);
        return storeStationName;
      }

    public bool  hasStationNameSpoken()
      {
        return flagHasStationNameSpoken;
      }

    public string  getStationNameSpoken()
      {
        Debug.Assert(flagHasStationNameSpoken);
        return storeStationNameSpoken;
      }

    public bool  hasDescription()
      {
        return flagHasDescription;
      }

    public string  getDescription()
      {
        Debug.Assert(flagHasDescription);
        return storeDescription;
      }

    public bool  hasGenres()
      {
        return flagHasGenres;
      }

    public int  countOfGenres()
      {
        Debug.Assert(flagHasGenres);
        return storeGenres.Count;
      }

    public string  elementOfGenres(int element_num)
      {
        Debug.Assert(flagHasGenres);
        return storeGenres[element_num];
      }

    public List< string >  getGenres()
      {
        Debug.Assert(flagHasGenres);
        return storeGenres;
      }

    public bool  hasAMFrequency()
      {
        return flagHasAMFrequency;
      }

    public short  getAMFrequency()
      {
        Debug.Assert(flagHasAMFrequency);
        return storeAMFrequency;
      }

    public bool  hasFMFrequency()
      {
        return flagHasFMFrequency;
      }

    public double  getFMFrequency()
      {
        Debug.Assert(flagHasFMFrequency);
        if (textStoreFMFrequency != "")
          {
            return Double.Parse(textStoreFMFrequency);
          }
        return storeFMFrequency;
      }

    public string  getFMFrequencyAsText()
      {
        Debug.Assert(flagHasFMFrequency);
        if (textStoreFMFrequency == "")
          {
            return Convert.ToString(storeFMFrequency);
          }
        else
          {
            return (textStoreFMFrequency);
          }
      }

    public bool  hasCallSign()
      {
        return flagHasCallSign;
      }

    public string  getCallSign()
      {
        Debug.Assert(flagHasCallSign);
        return storeCallSign;
      }

    public bool  hasBroadcastProvider()
      {
        return flagHasBroadcastProvider;
      }

    public TypeBroadcastProvider  getBroadcastProvider()
      {
        Debug.Assert(flagHasBroadcastProvider);
        return storeBroadcastProvider;
      }

    public string  getBroadcastProviderAsString()
      {
        TypeBroadcastProvider result = getBroadcastProvider();
        if (result.in_known_list)
            return stringFromBroadcastProvider(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasLogoImage()
      {
        return flagHasLogoImage;
      }

    public string  getLogoImage()
      {
        Debug.Assert(flagHasLogoImage);
        return storeLogoImage;
      }

    public bool  hasStationID()
      {
        return flagHasStationID;
      }

    public string  getStationID()
      {
        Debug.Assert(flagHasStationID);
        return storeStationID;
      }

    public bool  hasFulfillments()
      {
        return flagHasFulfillments;
      }

    public int  countOfFulfillments()
      {
        Debug.Assert(flagHasFulfillments);
        return storeFulfillments.Count;
      }

    public RadioStationFulfillmentJSON   elementOfFulfillments(int element_num)
      {
        Debug.Assert(flagHasFulfillments);
        return storeFulfillments[element_num];
      }

    public List< RadioStationFulfillmentJSON  >  getFulfillments()
      {
        Debug.Assert(flagHasFulfillments);
        return storeFulfillments;
      }

    public bool  hasAttribution()
      {
        return flagHasAttribution;
      }

    public TypeAttribution  getAttribution()
      {
        Debug.Assert(flagHasAttribution);
        return storeAttribution;
      }

    public string  getAttributionAsString()
      {
        TypeAttribution result = getAttribution();
        if (result.in_known_list)
            return stringFromAttribution(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public MapLocationJSON   getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }

    public bool  hasStationNumber()
      {
        return flagHasStationNumber;
      }

    public BigInteger  getStationNumber()
      {
        Debug.Assert(flagHasStationNumber);
        return storeStationNumber;
      }


    public virtual int extraRadioStationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRadioStationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRadioStationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRadioStationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStationName(string new_value)
      {
        flagHasStationName = true;
        storeStationName = new_value;
      }
    public void unsetStationName()
      {
        flagHasStationName = false;
      }
    public void setStationNameSpoken(string new_value)
      {
        flagHasStationNameSpoken = true;
        storeStationNameSpoken = new_value;
      }
    public void unsetStationNameSpoken()
      {
        flagHasStationNameSpoken = false;
      }
    public void setDescription(string new_value)
      {
        flagHasDescription = true;
        storeDescription = new_value;
      }
    public void unsetDescription()
      {
        flagHasDescription = false;
      }
    public void initGenres()
      {
        flagHasGenres = true;
        storeGenres.Clear();
      }
    public void appendGenres(string to_append)
      {
        if (!flagHasGenres)
          {
            flagHasGenres = true;
            storeGenres.Clear();
          }
        Debug.Assert(flagHasGenres);
        storeGenres.Add(to_append);
      }
    public void unsetGenres()
      {
        flagHasGenres = false;
        storeGenres.Clear();
      }
    public void setAMFrequency(short new_value)
      {
        flagHasAMFrequency = true;
        if (new_value < 300)
            throw new Exception("The value for field AMFrequency of RadioStationJSON is less than the lower bound (300) for that field.");
        if (new_value > 2000)
            throw new Exception("The value for field AMFrequency of RadioStationJSON is greater than the upper bound (2000) for that field.");
        storeAMFrequency = new_value;
      }
    public void unsetAMFrequency()
      {
        flagHasAMFrequency = false;
      }
    public void setFMFrequency(double new_value)
      {
        flagHasFMFrequency = true;
        if (new_value < 65.8)
            throw new Exception("The value for field FMFrequency of RadioStationJSON is less than the lower bound (65.8) for that field.");
        if (new_value > 108)
            throw new Exception("The value for field FMFrequency of RadioStationJSON is greater than the upper bound (108) for that field.");
        storeFMFrequency = new_value;
        textStoreFMFrequency = "";
      }
    public void setFMFrequencyText(string new_value)
      {
        flagHasFMFrequency = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field FMFrequency of RadioStationJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "658", "", false, "2") < 0)
            throw new Exception("The value for field FMFrequency of RadioStationJSON is less than the lower bound (65.8) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "108", "", false, "3") > 0)
            throw new Exception("The value for field FMFrequency of RadioStationJSON is greater than the upper bound (108) for that field.");
        textStoreFMFrequency = new_value;
      }
    public void unsetFMFrequency()
      {
        flagHasFMFrequency = false;
      }
    public void setCallSign(string new_value)
      {
        flagHasCallSign = true;
        storeCallSign = new_value;
      }
    public void unsetCallSign()
      {
        flagHasCallSign = false;
      }
    public void setBroadcastProvider(TypeBroadcastProvider new_value)
      {
        flagHasBroadcastProvider = true;
        storeBroadcastProvider = new_value;
      }
    public void setBroadcastProvider(string chars)
      {
        TypeBroadcastProviderKnownValues known = stringToBroadcastProvider(chars);
        TypeBroadcastProvider new_value = new TypeBroadcastProvider();
        if (known == TypeBroadcastProviderKnownValues.BroadcastProvider__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setBroadcastProvider(new_value);
      }
    public void setBroadcastProvider(TypeBroadcastProviderKnownValues new_value)
      {
        TypeBroadcastProvider new_full_value = new TypeBroadcastProvider();
        Debug.Assert(new_value != TypeBroadcastProviderKnownValues.BroadcastProvider__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setBroadcastProvider(new_full_value);
      }
    public void unsetBroadcastProvider()
      {
        flagHasBroadcastProvider = false;
      }
    public void setLogoImage(string new_value)
      {
        flagHasLogoImage = true;
        storeLogoImage = new_value;
      }
    public void unsetLogoImage()
      {
        flagHasLogoImage = false;
      }
    public void setStationID(string new_value)
      {
        flagHasStationID = true;
        storeStationID = new_value;
      }
    public void unsetStationID()
      {
        flagHasStationID = false;
      }
    public void initFulfillments()
      {
        if (flagHasFulfillments)
          {
            for (int num1 = 0; num1 < storeFulfillments.Count; ++num1)
              {
              }
          }
        flagHasFulfillments = true;
        storeFulfillments.Clear();
      }
    public void appendFulfillments(RadioStationFulfillmentJSON  to_append)
      {
        if (!flagHasFulfillments)
          {
            flagHasFulfillments = true;
            storeFulfillments.Clear();
          }
        Debug.Assert(flagHasFulfillments);
        storeFulfillments.Add(to_append);
      }
    public void unsetFulfillments()
      {
        if (flagHasFulfillments)
          {
            for (int num2 = 0; num2 < storeFulfillments.Count; ++num2)
              {
              }
          }
        flagHasFulfillments = false;
        storeFulfillments.Clear();
      }
    public void setAttribution(TypeAttribution new_value)
      {
        flagHasAttribution = true;
        storeAttribution = new_value;
      }
    public void setAttribution(string chars)
      {
        TypeAttributionKnownValues known = stringToAttribution(chars);
        TypeAttribution new_value = new TypeAttribution();
        if (known == TypeAttributionKnownValues.Attribution__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setAttribution(new_value);
      }
    public void setAttribution(TypeAttributionKnownValues new_value)
      {
        TypeAttribution new_full_value = new TypeAttribution();
        Debug.Assert(new_value != TypeAttributionKnownValues.Attribution__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setAttribution(new_full_value);
      }
    public void unsetAttribution()
      {
        flagHasAttribution = false;
      }
    public void setLocation(MapLocationJSON  new_value)
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = false;
      }
    public void setStationNumber(BigInteger new_value)
      {
        flagHasStationNumber = true;
        if (new_value < 0)
            throw new Exception("The value for field StationNumber of RadioStationJSON is less than the lower bound (0) for that field.");
        storeStationNumber = new_value;
      }
    public void unsetStationNumber()
      {
        flagHasStationNumber = false;
      }

    public virtual void extraRadioStationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRadioStationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRadioStationLookup(key);
        if (old_field == null)
          {
            extraRadioStationAppendPair(key, new_component);
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
        if (flagHasStationName)
          {
            handler.start_pair("StationName");
            handler.string_value(storeStationName);
          }
        if (flagHasStationNameSpoken)
          {
            handler.start_pair("StationNameSpoken");
            handler.string_value(storeStationNameSpoken);
          }
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            handler.string_value(storeDescription);
          }
        if (flagHasGenres)
          {
            handler.start_pair("Genres");
            Debug.Assert(storeGenres.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeGenres.Count; ++num1)
              {
                handler.string_value(storeGenres[num1]);
              }
            handler.finish_array();
          }
        if (flagHasAMFrequency)
          {
            handler.start_pair("AMFrequency");
            handler.number_value(storeAMFrequency);
          }
        if (flagHasFMFrequency)
          {
            handler.start_pair("FMFrequency");
            if (textStoreFMFrequency != "")
                handler.number_value(textStoreFMFrequency);
            else if (((double)(long)storeFMFrequency) == storeFMFrequency)
                handler.number_value((long)storeFMFrequency);
            else
                handler.number_value(storeFMFrequency);
          }
        if (flagHasCallSign)
          {
            handler.start_pair("CallSign");
            handler.string_value(storeCallSign);
          }
        if (flagHasBroadcastProvider)
          {
            handler.start_pair("BroadcastProvider");
            if (storeBroadcastProvider.in_known_list)
              {
                switch (storeBroadcastProvider.list_value)
                  {
                    case TypeBroadcastProviderKnownValues.BroadcastProvider_IHeartRadio:
                        handler.string_value("IHeartRadio");
                        break;
                    case TypeBroadcastProviderKnownValues.BroadcastProvider_Sirius:
                        handler.string_value("Sirius");
                        break;
                    case TypeBroadcastProviderKnownValues.BroadcastProvider_XM:
                        handler.string_value("XM");
                        break;
                    case TypeBroadcastProviderKnownValues.BroadcastProvider_Audacy:
                        handler.string_value("Audacy");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeBroadcastProvider.string_value);
              }
          }
        if (flagHasLogoImage)
          {
            handler.start_pair("LogoImage");
            handler.string_value(storeLogoImage);
          }
        if (flagHasStationID)
          {
            handler.start_pair("StationID");
            handler.string_value(storeStationID);
          }
        if (flagHasFulfillments)
          {
            handler.start_pair("Fulfillments");
            Debug.Assert(storeFulfillments.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeFulfillments.Count; ++num2)
              {
                if (partial_allowed)
                    storeFulfillments[num2].write_partial_as_json(handler);
                else
                    storeFulfillments[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (storeAttribution.in_known_list)
              {
                switch (storeAttribution.list_value)
                  {
                    case TypeAttributionKnownValues.Attribution_IHeartRadio:
                        handler.string_value("IHeartRadio");
                        break;
                    case TypeAttributionKnownValues.Attribution_Audacy:
                        handler.string_value("Audacy");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeAttribution.string_value);
              }
          }
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            if (partial_allowed)
                storeLocation.write_partial_as_json(handler);
            else
                storeLocation.write_as_json(handler);
          }
        if (flagHasStationNumber)
          {
            handler.start_pair("StationNumber");
            handler.number_value(storeStationNumber);
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
        return null;
      }

    public static RadioStationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioStationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioStation", ignore_extras);
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
    public static RadioStationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RadioStationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioStationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioStation", ignore_extras);
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
    public static RadioStationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RadioStationJSON from_text(string text, bool ignore_extras)
      {
        RadioStationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioStation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RadioStationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RadioStationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RadioStationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioStation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorStationName;
        private JSONHoldingStringGenerator fieldGeneratorStationNameSpoken;
        private JSONHoldingStringGenerator fieldGeneratorDescription;
        private JSONHoldingStringArrayGenerator fieldGeneratorGenres;
    private class FieldHoldingGeneratorAMFrequency : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorAMFrequency(String what) : base(what, 300, 2000)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAMFrequency : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAMFrequency(String what) : base(what, 300, 2000)
              {
              }
          };
        private FieldHoldingGeneratorAMFrequency fieldGeneratorAMFrequency;
        private JSONHoldingNumberTextGenerator fieldGeneratorFMFrequency;
        private JSONHoldingStringGenerator fieldGeneratorCallSign;
    private abstract class FieldGeneratorBroadcastProvider : JSONStringGenerator
          {
            protected FieldGeneratorBroadcastProvider(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorBroadcastProvider()
              {
              }
            protected override void handle_result(string result)
              {
                TypeBroadcastProviderKnownValues known = stringToBroadcastProvider(result);
                TypeBroadcastProvider new_value = new TypeBroadcastProvider();
                if (known == TypeBroadcastProviderKnownValues.BroadcastProvider__none)
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
            protected abstract void handle_result(TypeBroadcastProvider result);
          };
    private class FieldHoldingGeneratorBroadcastProvider : FieldGeneratorBroadcastProvider
  {
    protected override void handle_result(TypeBroadcastProvider result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorBroadcastProvider(String what)
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
    public TypeBroadcastProvider value;
  };
    private class FieldHoldingArrayGeneratorBroadcastProvider : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorBroadcastProvider
      {
        private FieldHoldingArrayGeneratorBroadcastProvider top;

        protected override void handle_result(TypeBroadcastProvider result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorBroadcastProvider init_top)
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
    protected virtual void handle_result(List<TypeBroadcastProvider> result)
      {
      }

    public FieldHoldingArrayGeneratorBroadcastProvider(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeBroadcastProvider>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorBroadcastProvider()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeBroadcastProvider>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeBroadcastProvider> value;
  };
        private FieldHoldingGeneratorBroadcastProvider fieldGeneratorBroadcastProvider;
        private JSONHoldingStringGenerator fieldGeneratorLogoImage;
        private JSONHoldingStringGenerator fieldGeneratorStationID;
        private RadioStationFulfillmentJSON.HoldingArrayGenerator fieldGeneratorFulfillments;
    private abstract class FieldGeneratorAttribution : JSONStringGenerator
          {
            protected FieldGeneratorAttribution(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorAttribution()
              {
              }
            protected override void handle_result(string result)
              {
                TypeAttributionKnownValues known = stringToAttribution(result);
                TypeAttribution new_value = new TypeAttribution();
                if (known == TypeAttributionKnownValues.Attribution__none)
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
            protected abstract void handle_result(TypeAttribution result);
          };
    private class FieldHoldingGeneratorAttribution : FieldGeneratorAttribution
  {
    protected override void handle_result(TypeAttribution result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorAttribution(String what)
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
    public TypeAttribution value;
  };
    private class FieldHoldingArrayGeneratorAttribution : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorAttribution
      {
        private FieldHoldingArrayGeneratorAttribution top;

        protected override void handle_result(TypeAttribution result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorAttribution init_top)
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
    protected virtual void handle_result(List<TypeAttribution> result)
      {
      }

    public FieldHoldingArrayGeneratorAttribution(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAttribution>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorAttribution()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAttribution>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeAttribution> value;
  };
        private FieldHoldingGeneratorAttribution fieldGeneratorAttribution;
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
    private class FieldHoldingGeneratorStationNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStationNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStationNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStationNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorStationNumber fieldGeneratorStationNumber;
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
            RadioStationJSON result = new RadioStationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRadioStationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RadioStationJSON result)
          {
            if (fieldGeneratorStationName.have_value)
              {
                result.setStationName(fieldGeneratorStationName.value);
                fieldGeneratorStationName.have_value = false;
              }
            if (fieldGeneratorStationNameSpoken.have_value)
              {
                result.setStationNameSpoken(fieldGeneratorStationNameSpoken.value);
                fieldGeneratorStationNameSpoken.have_value = false;
              }
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            if (fieldGeneratorGenres.have_value)
              {
                result.initGenres();
                int count = fieldGeneratorGenres.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGenres(fieldGeneratorGenres.value[num]);
                  }
                fieldGeneratorGenres.value.Clear();
                fieldGeneratorGenres.have_value = false;
              }
            if (fieldGeneratorAMFrequency.have_value)
              {
                result.setAMFrequency((short)(fieldGeneratorAMFrequency.value));
                fieldGeneratorAMFrequency.have_value = false;
              }
            if (fieldGeneratorFMFrequency.have_value)
              {
                result.setFMFrequencyText(fieldGeneratorFMFrequency.value);
                fieldGeneratorFMFrequency.have_value = false;
              }
            if (fieldGeneratorCallSign.have_value)
              {
                result.setCallSign(fieldGeneratorCallSign.value);
                fieldGeneratorCallSign.have_value = false;
              }
            if (fieldGeneratorBroadcastProvider.have_value)
              {
                result.setBroadcastProvider(fieldGeneratorBroadcastProvider.value);
                fieldGeneratorBroadcastProvider.have_value = false;
              }
            if (fieldGeneratorLogoImage.have_value)
              {
                result.setLogoImage(fieldGeneratorLogoImage.value);
                fieldGeneratorLogoImage.have_value = false;
              }
            if (fieldGeneratorStationID.have_value)
              {
                result.setStationID(fieldGeneratorStationID.value);
                fieldGeneratorStationID.have_value = false;
              }
            if (fieldGeneratorFulfillments.have_value)
              {
                result.initFulfillments();
                int count = fieldGeneratorFulfillments.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFulfillments(fieldGeneratorFulfillments.value[num]);
                  }
                fieldGeneratorFulfillments.value.Clear();
                fieldGeneratorFulfillments.have_value = false;
              }
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
              }
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            if (fieldGeneratorStationNumber.have_value)
              {
                result.setStationNumber(fieldGeneratorStationNumber.value);
                fieldGeneratorStationNumber.have_value = false;
              }
          }
        protected abstract void handle_result(RadioStationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'M':
                            if ((String.Compare(field_name, 2, "Frequency", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorAMFrequency;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "tribution", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorAttribution;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "roadcastProvider", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorBroadcastProvider;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "allSign", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorCallSign;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDescription;
                    break;
                case 'F':
                    switch (field_name[1])
                      {
                        case 'M':
                            if ((String.Compare(field_name, 2, "Frequency", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorFMFrequency;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "lfillments", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorFulfillments;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "enres", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorGenres;
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "o", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'c':
                                if ((String.Compare(field_name, 3, "ation", 0, 5, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorLocation;
                                break;
                            case 'g':
                                if ((String.Compare(field_name, 3, "oImage", 0, 6, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorLogoImage;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "tation", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 8, "D", 0, 1, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorStationID;
                                break;
                            case 'N':
                                switch (field_name[8])
                                  {
                                    case 'a':
                                        if (String.Compare(field_name, 9, "me", 0, 2, false) == 0)
                                          {
                                            if (field_name.Length == 11)
                                              {
                                                return fieldGeneratorStationName;
                                              }
                                            switch (field_name[11])
                                              {
                                                case 'S':
                                                    if ((String.Compare(field_name, 12, "poken", 0, 5, false) == 0) && (field_name.Length == 17))
                                                        return fieldGeneratorStationNameSpoken;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'u':
                                        if ((String.Compare(field_name, 9, "mber", 0, 4, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorStationNumber;
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
            fieldGeneratorStationName = new JSONHoldingStringGenerator("field \"StationName\" of the RadioStation class");
            fieldGeneratorStationNameSpoken = new JSONHoldingStringGenerator("field \"StationNameSpoken\" of the RadioStation class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the RadioStation class");
            fieldGeneratorGenres = new JSONHoldingStringArrayGenerator("field \"Genres\" of the RadioStation class");
            fieldGeneratorAMFrequency = new FieldHoldingGeneratorAMFrequency("field \"AMFrequency\" of the RadioStation class");
            fieldGeneratorFMFrequency = new JSONHoldingNumberTextGenerator("field \"FMFrequency\" of the RadioStation class");
            fieldGeneratorCallSign = new JSONHoldingStringGenerator("field \"CallSign\" of the RadioStation class");
            fieldGeneratorBroadcastProvider = new FieldHoldingGeneratorBroadcastProvider("field \"BroadcastProvider\" of the RadioStation class");
            fieldGeneratorLogoImage = new JSONHoldingStringGenerator("field \"LogoImage\" of the RadioStation class");
            fieldGeneratorStationID = new JSONHoldingStringGenerator("field \"StationID\" of the RadioStation class");
            fieldGeneratorFulfillments = new RadioStationFulfillmentJSON.HoldingArrayGenerator("field \"Fulfillments\" of the RadioStation class", ignore_extras);
            fieldGeneratorAttribution = new FieldHoldingGeneratorAttribution("field \"Attribution\" of the RadioStation class");
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the RadioStation class", ignore_extras);
            fieldGeneratorStationNumber = new FieldHoldingGeneratorStationNumber("field \"StationNumber\" of the RadioStation class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RadioStation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStationName = new JSONHoldingStringGenerator("field \"StationName\" of the RadioStation class");
            fieldGeneratorStationNameSpoken = new JSONHoldingStringGenerator("field \"StationNameSpoken\" of the RadioStation class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the RadioStation class");
            fieldGeneratorGenres = new JSONHoldingStringArrayGenerator("field \"Genres\" of the RadioStation class");
            fieldGeneratorAMFrequency = new FieldHoldingGeneratorAMFrequency("field \"AMFrequency\" of the RadioStation class");
            fieldGeneratorFMFrequency = new JSONHoldingNumberTextGenerator("field \"FMFrequency\" of the RadioStation class");
            fieldGeneratorCallSign = new JSONHoldingStringGenerator("field \"CallSign\" of the RadioStation class");
            fieldGeneratorBroadcastProvider = new FieldHoldingGeneratorBroadcastProvider("field \"BroadcastProvider\" of the RadioStation class");
            fieldGeneratorLogoImage = new JSONHoldingStringGenerator("field \"LogoImage\" of the RadioStation class");
            fieldGeneratorStationID = new JSONHoldingStringGenerator("field \"StationID\" of the RadioStation class");
            fieldGeneratorFulfillments = new RadioStationFulfillmentJSON.HoldingArrayGenerator("field \"Fulfillments\" of the RadioStation class", false);
            fieldGeneratorAttribution = new FieldHoldingGeneratorAttribution("field \"Attribution\" of the RadioStation class");
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the RadioStation class", false);
            fieldGeneratorStationNumber = new FieldHoldingGeneratorStationNumber("field \"StationNumber\" of the RadioStation class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RadioStation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStationName.reset();
            fieldGeneratorStationNameSpoken.reset();
            fieldGeneratorDescription.reset();
            fieldGeneratorGenres.reset();
            fieldGeneratorAMFrequency.reset();
            fieldGeneratorFMFrequency.reset();
            fieldGeneratorCallSign.reset();
            fieldGeneratorBroadcastProvider.reset();
            fieldGeneratorLogoImage.reset();
            fieldGeneratorStationID.reset();
            fieldGeneratorFulfillments.reset();
            fieldGeneratorAttribution.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorStationNumber.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFulfillments.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLocation.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFulfillments.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLocation.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RadioStationJSON  result)
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
        public RadioStationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RadioStationJSON  result)
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
    protected virtual void handle_result(List<RadioStationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RadioStationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RadioStationJSON>();
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
    public List<RadioStationJSON> value;
  };
  };
