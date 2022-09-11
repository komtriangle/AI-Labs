/* file "UberCompositeProductJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UberCompositeProductJSON : JSONBase
  {
    public enum TypeFareTypeKnownValues
      {
        FareType_rated,
        FareType_metered,
        FareType_upfront,
        FareType__none
      };
    public struct TypeFareType
      {
        public bool in_known_list;
        public string string_value;
        public TypeFareTypeKnownValues list_value;
      };

    public static TypeFareTypeKnownValues  stringToFareType(string chars)
      {
        switch (chars[0])
          {
            case 'm':
                if ((String.Compare(chars, 1, "etered", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeFareTypeKnownValues.FareType_metered;
                break;
            case 'r':
                if ((String.Compare(chars, 1, "ated", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeFareTypeKnownValues.FareType_rated;
                break;
            case 'u':
                if ((String.Compare(chars, 1, "pfront", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeFareTypeKnownValues.FareType_upfront;
                break;
            default:
                break;
          }
        return TypeFareTypeKnownValues.FareType__none;
      }

    public static string  stringFromFareType(TypeFareTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeFareTypeKnownValues.FareType_rated:
                return "rated";
            case TypeFareTypeKnownValues.FareType_metered:
                return "metered";
            case TypeFareTypeKnownValues.FareType_upfront:
                return "upfront";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasDisplayName;
    private string storeDisplayName;
    private bool flagHasProductId;
    private string storeProductId;
    private bool flagHasDescription;
    private string storeDescription;
    private bool flagHasImage;
    private string storeImage;
    private bool flagHasCapacity;
    private BigInteger storeCapacity;
    private bool flagHasSurgeMultiplier;
    private double storeSurgeMultiplier;
    private string textStoreSurgeMultiplier;
    private bool flagHasIsSelected;
    private bool storeIsSelected;
    private bool flagHasIsShared;
    private bool storeIsShared;
    private bool flagHasCount;
    private BigInteger storeCount;
    private bool flagHasPickUpEstimateInSeconds;
    private double storePickUpEstimateInSeconds;
    private string textStorePickUpEstimateInSeconds;
    private bool flagHasFareType;
    private TypeFareType storeFareType;
    private bool flagHasFare;
    private UberFareJSON  storeFare;
    private bool flagHasTripEstimates;
    private UberTripEstimatesJSON  storeTripEstimates;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDisplayName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DisplayName of UberCompositeProductJSON is not a string.");
        setDisplayName(json_string.getData());
      }


    private void  fromJSONProductId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ProductId of UberCompositeProductJSON is not a string.");
        setProductId(json_string.getData());
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Description of UberCompositeProductJSON is not a string.");
        setDescription(json_string.getData());
      }


    private void  fromJSONImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Image of UberCompositeProductJSON is not a string.");
        setImage(json_string.getData());
      }


    private void  fromJSONCapacity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Capacity of UberCompositeProductJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Capacity of UberCompositeProductJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCapacity(extracted_integer);
      }


    private void  fromJSONSurgeMultiplier(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SurgeMultiplier of UberCompositeProductJSON is not a number.");
              }
          }
        setSurgeMultiplierText(the_rational_text);
      }


    private void  fromJSONIsSelected(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsSelected of UberCompositeProductJSON is not true for false.");
              }
          }
        setIsSelected(the_bool);
      }


    private void  fromJSONIsShared(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsShared of UberCompositeProductJSON is not true for false.");
              }
          }
        setIsShared(the_bool);
      }


    private void  fromJSONCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Count of UberCompositeProductJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Count of UberCompositeProductJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCount(extracted_integer);
      }


    private void  fromJSONPickUpEstimateInSeconds(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PickUpEstimateInSeconds of UberCompositeProductJSON is not a number.");
              }
          }
        setPickUpEstimateInSecondsText(the_rational_text);
      }


    private void  fromJSONFareType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FareType of UberCompositeProductJSON is not a string.");
        TypeFareType the_open_enum = new TypeFareType();
        switch (json_string.getData()[0])
          {
            case 'm':
                if ((String.Compare(json_string.getData(), 1, "etered", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFareTypeKnownValues.FareType_metered;
                        goto open_enum_is_done;
                      }
                break;
            case 'r':
                if ((String.Compare(json_string.getData(), 1, "ated", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFareTypeKnownValues.FareType_rated;
                        goto open_enum_is_done;
                      }
                break;
            case 'u':
                if ((String.Compare(json_string.getData(), 1, "pfront", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeFareTypeKnownValues.FareType_upfront;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setFareType(the_open_enum);
      }


    private void  fromJSONFare(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberFareJSON convert_classy = UberFareJSON.from_json(json_value, ignore_extras, true);
        setFare(convert_classy);
      }


    private void  fromJSONTripEstimates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UberTripEstimatesJSON convert_classy = UberTripEstimatesJSON.from_json(json_value, ignore_extras, true);
        setTripEstimates(convert_classy);
      }


    public UberCompositeProductJSON()
      {
        flagHasDisplayName = false;
        flagHasProductId = false;
        flagHasDescription = false;
        flagHasImage = false;
        flagHasCapacity = false;
        flagHasSurgeMultiplier = false;
        flagHasIsSelected = false;
        flagHasIsShared = false;
        flagHasCount = false;
        flagHasPickUpEstimateInSeconds = false;
        flagHasFareType = false;
        flagHasFare = false;
        flagHasTripEstimates = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDisplayName()
      {
        return flagHasDisplayName;
      }

    public string  getDisplayName()
      {
        Debug.Assert(flagHasDisplayName);
        return storeDisplayName;
      }

    public bool  hasProductId()
      {
        return flagHasProductId;
      }

    public string  getProductId()
      {
        Debug.Assert(flagHasProductId);
        return storeProductId;
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

    public bool  hasImage()
      {
        return flagHasImage;
      }

    public string  getImage()
      {
        Debug.Assert(flagHasImage);
        return storeImage;
      }

    public bool  hasCapacity()
      {
        return flagHasCapacity;
      }

    public BigInteger  getCapacity()
      {
        Debug.Assert(flagHasCapacity);
        return storeCapacity;
      }

    public bool  hasSurgeMultiplier()
      {
        return flagHasSurgeMultiplier;
      }

    public double  getSurgeMultiplier()
      {
        Debug.Assert(flagHasSurgeMultiplier);
        if (textStoreSurgeMultiplier != "")
          {
            return Double.Parse(textStoreSurgeMultiplier);
          }
        return storeSurgeMultiplier;
      }

    public string  getSurgeMultiplierAsText()
      {
        Debug.Assert(flagHasSurgeMultiplier);
        if (textStoreSurgeMultiplier == "")
          {
            return Convert.ToString(storeSurgeMultiplier);
          }
        else
          {
            return (textStoreSurgeMultiplier);
          }
      }

    public bool  hasIsSelected()
      {
        return flagHasIsSelected;
      }

    public bool  getIsSelected()
      {
        Debug.Assert(flagHasIsSelected);
        return storeIsSelected;
      }

    public bool  hasIsShared()
      {
        return flagHasIsShared;
      }

    public bool  getIsShared()
      {
        Debug.Assert(flagHasIsShared);
        return storeIsShared;
      }

    public bool  hasCount()
      {
        return flagHasCount;
      }

    public BigInteger  getCount()
      {
        Debug.Assert(flagHasCount);
        return storeCount;
      }

    public bool  hasPickUpEstimateInSeconds()
      {
        return flagHasPickUpEstimateInSeconds;
      }

    public double  getPickUpEstimateInSeconds()
      {
        Debug.Assert(flagHasPickUpEstimateInSeconds);
        if (textStorePickUpEstimateInSeconds != "")
          {
            return Double.Parse(textStorePickUpEstimateInSeconds);
          }
        return storePickUpEstimateInSeconds;
      }

    public string  getPickUpEstimateInSecondsAsText()
      {
        Debug.Assert(flagHasPickUpEstimateInSeconds);
        if (textStorePickUpEstimateInSeconds == "")
          {
            return Convert.ToString(storePickUpEstimateInSeconds);
          }
        else
          {
            return (textStorePickUpEstimateInSeconds);
          }
      }

    public bool  hasFareType()
      {
        return flagHasFareType;
      }

    public TypeFareType  getFareType()
      {
        Debug.Assert(flagHasFareType);
        return storeFareType;
      }

    public string  getFareTypeAsString()
      {
        TypeFareType result = getFareType();
        if (result.in_known_list)
            return stringFromFareType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasFare()
      {
        return flagHasFare;
      }

    public UberFareJSON   getFare()
      {
        Debug.Assert(flagHasFare);
        return storeFare;
      }

    public bool  hasTripEstimates()
      {
        return flagHasTripEstimates;
      }

    public UberTripEstimatesJSON   getTripEstimates()
      {
        Debug.Assert(flagHasTripEstimates);
        return storeTripEstimates;
      }


    public virtual int extraUberCompositeProductComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberCompositeProductComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberCompositeProductComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberCompositeProductLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setDisplayName(string new_value)
      {
        flagHasDisplayName = true;
        storeDisplayName = new_value;
      }
    public void unsetDisplayName()
      {
        flagHasDisplayName = false;
      }
    public void setProductId(string new_value)
      {
        flagHasProductId = true;
        storeProductId = new_value;
      }
    public void unsetProductId()
      {
        flagHasProductId = false;
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
    public void setImage(string new_value)
      {
        flagHasImage = true;
        storeImage = new_value;
      }
    public void unsetImage()
      {
        flagHasImage = false;
      }
    public void setCapacity(BigInteger new_value)
      {
        flagHasCapacity = true;
        if (new_value < 0)
            throw new Exception("The value for field Capacity of UberCompositeProductJSON is less than the lower bound (0) for that field.");
        storeCapacity = new_value;
      }
    public void unsetCapacity()
      {
        flagHasCapacity = false;
      }
    public void setSurgeMultiplier(double new_value)
      {
        flagHasSurgeMultiplier = true;
        storeSurgeMultiplier = new_value;
        textStoreSurgeMultiplier = "";
      }
    public void setSurgeMultiplierText(string new_value)
      {
        flagHasSurgeMultiplier = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field SurgeMultiplier of UberCompositeProductJSON is not a valid number.");
        textStoreSurgeMultiplier = new_value;
      }
    public void unsetSurgeMultiplier()
      {
        flagHasSurgeMultiplier = false;
      }
    public void setIsSelected(bool new_value)
      {
        flagHasIsSelected = true;
        storeIsSelected = new_value;
      }
    public void unsetIsSelected()
      {
        flagHasIsSelected = false;
      }
    public void setIsShared(bool new_value)
      {
        flagHasIsShared = true;
        storeIsShared = new_value;
      }
    public void unsetIsShared()
      {
        flagHasIsShared = false;
      }
    public void setCount(BigInteger new_value)
      {
        flagHasCount = true;
        if (new_value < 0)
            throw new Exception("The value for field Count of UberCompositeProductJSON is less than the lower bound (0) for that field.");
        storeCount = new_value;
      }
    public void unsetCount()
      {
        flagHasCount = false;
      }
    public void setPickUpEstimateInSeconds(double new_value)
      {
        flagHasPickUpEstimateInSeconds = true;
        storePickUpEstimateInSeconds = new_value;
        textStorePickUpEstimateInSeconds = "";
      }
    public void setPickUpEstimateInSecondsText(string new_value)
      {
        flagHasPickUpEstimateInSeconds = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field PickUpEstimateInSeconds of UberCompositeProductJSON is not a valid number.");
        textStorePickUpEstimateInSeconds = new_value;
      }
    public void unsetPickUpEstimateInSeconds()
      {
        flagHasPickUpEstimateInSeconds = false;
      }
    public void setFareType(TypeFareType new_value)
      {
        flagHasFareType = true;
        storeFareType = new_value;
      }
    public void setFareType(string chars)
      {
        TypeFareTypeKnownValues known = stringToFareType(chars);
        TypeFareType new_value = new TypeFareType();
        if (known == TypeFareTypeKnownValues.FareType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setFareType(new_value);
      }
    public void setFareType(TypeFareTypeKnownValues new_value)
      {
        TypeFareType new_full_value = new TypeFareType();
        Debug.Assert(new_value != TypeFareTypeKnownValues.FareType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setFareType(new_full_value);
      }
    public void unsetFareType()
      {
        flagHasFareType = false;
      }
    public void setFare(UberFareJSON  new_value)
      {
        if (flagHasFare)
          {
          }
        flagHasFare = true;
        storeFare = new_value;
      }
    public void unsetFare()
      {
        if (flagHasFare)
          {
          }
        flagHasFare = false;
      }
    public void setTripEstimates(UberTripEstimatesJSON  new_value)
      {
        if (flagHasTripEstimates)
          {
          }
        flagHasTripEstimates = true;
        storeTripEstimates = new_value;
      }
    public void unsetTripEstimates()
      {
        if (flagHasTripEstimates)
          {
          }
        flagHasTripEstimates = false;
      }

    public virtual void extraUberCompositeProductAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberCompositeProductSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberCompositeProductLookup(key);
        if (old_field == null)
          {
            extraUberCompositeProductAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDisplayName);
        if (flagHasDisplayName)
          {
            handler.start_pair("DisplayName");
            handler.string_value(storeDisplayName);
          }
        Debug.Assert(partial_allowed || flagHasProductId);
        if (flagHasProductId)
          {
            handler.start_pair("ProductId");
            handler.string_value(storeProductId);
          }
        Debug.Assert(partial_allowed || flagHasDescription);
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            handler.string_value(storeDescription);
          }
        Debug.Assert(partial_allowed || flagHasImage);
        if (flagHasImage)
          {
            handler.start_pair("Image");
            handler.string_value(storeImage);
          }
        Debug.Assert(partial_allowed || flagHasCapacity);
        if (flagHasCapacity)
          {
            handler.start_pair("Capacity");
            handler.number_value(storeCapacity);
          }
        Debug.Assert(partial_allowed || flagHasSurgeMultiplier);
        if (flagHasSurgeMultiplier)
          {
            handler.start_pair("SurgeMultiplier");
            if (textStoreSurgeMultiplier != "")
                handler.number_value(textStoreSurgeMultiplier);
            else if (((double)(long)storeSurgeMultiplier) == storeSurgeMultiplier)
                handler.number_value((long)storeSurgeMultiplier);
            else
                handler.number_value(storeSurgeMultiplier);
          }
        if (flagHasIsSelected)
          {
            handler.start_pair("IsSelected");
            handler.boolean_value(storeIsSelected);
          }
        if (flagHasIsShared)
          {
            handler.start_pair("IsShared");
            handler.boolean_value(storeIsShared);
          }
        if (flagHasCount)
          {
            handler.start_pair("Count");
            handler.number_value(storeCount);
          }
        if (flagHasPickUpEstimateInSeconds)
          {
            handler.start_pair("PickUpEstimateInSeconds");
            if (textStorePickUpEstimateInSeconds != "")
                handler.number_value(textStorePickUpEstimateInSeconds);
            else if (((double)(long)storePickUpEstimateInSeconds) == storePickUpEstimateInSeconds)
                handler.number_value((long)storePickUpEstimateInSeconds);
            else
                handler.number_value(storePickUpEstimateInSeconds);
          }
        Debug.Assert(partial_allowed || flagHasFareType);
        if (flagHasFareType)
          {
            handler.start_pair("FareType");
            if (storeFareType.in_known_list)
              {
                switch (storeFareType.list_value)
                  {
                    case TypeFareTypeKnownValues.FareType_rated:
                        handler.string_value("rated");
                        break;
                    case TypeFareTypeKnownValues.FareType_metered:
                        handler.string_value("metered");
                        break;
                    case TypeFareTypeKnownValues.FareType_upfront:
                        handler.string_value("upfront");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeFareType.string_value);
              }
          }
        if (flagHasFare)
          {
            handler.start_pair("Fare");
            if (partial_allowed)
                storeFare.write_partial_as_json(handler);
            else
                storeFare.write_as_json(handler);
          }
        if (flagHasTripEstimates)
          {
            handler.start_pair("TripEstimates");
            if (partial_allowed)
                storeTripEstimates.write_partial_as_json(handler);
            else
                storeTripEstimates.write_as_json(handler);
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
        if (!(hasDisplayName()))
          {
            return "When parsing the object for %what%, the \"DisplayName\" field was missing.";
          }
        if (!(hasProductId()))
          {
            return "When parsing the object for %what%, the \"ProductId\" field was missing.";
          }
        if (!(hasDescription()))
          {
            return "When parsing the object for %what%, the \"Description\" field was missing.";
          }
        if (!(hasImage()))
          {
            return "When parsing the object for %what%, the \"Image\" field was missing.";
          }
        if (!(hasCapacity()))
          {
            return "When parsing the object for %what%, the \"Capacity\" field was missing.";
          }
        if (!(hasSurgeMultiplier()))
          {
            return "When parsing the object for %what%, the \"SurgeMultiplier\" field was missing.";
          }
        if (!(hasFareType()))
          {
            return "When parsing the object for %what%, the \"FareType\" field was missing.";
          }
        return null;
      }

    public static UberCompositeProductJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberCompositeProductJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberCompositeProduct", ignore_extras);
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
    public static UberCompositeProductJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberCompositeProductJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberCompositeProductJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberCompositeProduct", ignore_extras);
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
    public static UberCompositeProductJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UberCompositeProductJSON from_text(string text, bool ignore_extras)
      {
        UberCompositeProductJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberCompositeProduct", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberCompositeProductJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UberCompositeProductJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberCompositeProductJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberCompositeProduct", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorDisplayName;
        private JSONHoldingStringGenerator fieldGeneratorProductId;
        private JSONHoldingStringGenerator fieldGeneratorDescription;
        private JSONHoldingStringGenerator fieldGeneratorImage;
    private class FieldHoldingGeneratorCapacity : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorCapacity(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorCapacity : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorCapacity(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorCapacity fieldGeneratorCapacity;
        private JSONHoldingNumberTextGenerator fieldGeneratorSurgeMultiplier;
        private JSONHoldingBooleanGenerator fieldGeneratorIsSelected;
        private JSONHoldingBooleanGenerator fieldGeneratorIsShared;
    private class FieldHoldingGeneratorCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorCount fieldGeneratorCount;
        private JSONHoldingNumberTextGenerator fieldGeneratorPickUpEstimateInSeconds;
    private abstract class FieldGeneratorFareType : JSONStringGenerator
          {
            protected FieldGeneratorFareType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFareType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeFareTypeKnownValues known = stringToFareType(result);
                TypeFareType new_value = new TypeFareType();
                if (known == TypeFareTypeKnownValues.FareType__none)
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
            protected abstract void handle_result(TypeFareType result);
          };
    private class FieldHoldingGeneratorFareType : FieldGeneratorFareType
  {
    protected override void handle_result(TypeFareType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFareType(String what)
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
    public TypeFareType value;
  };
    private class FieldHoldingArrayGeneratorFareType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFareType
      {
        private FieldHoldingArrayGeneratorFareType top;

        protected override void handle_result(TypeFareType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFareType init_top)
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
    protected virtual void handle_result(List<TypeFareType> result)
      {
      }

    public FieldHoldingArrayGeneratorFareType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFareType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFareType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFareType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFareType> value;
  };
        private FieldHoldingGeneratorFareType fieldGeneratorFareType;
        private UberFareJSON.HoldingGenerator fieldGeneratorFare;
        private UberTripEstimatesJSON.HoldingGenerator fieldGeneratorTripEstimates;
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
            UberCompositeProductJSON result = new UberCompositeProductJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberCompositeProductAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UberCompositeProductJSON result)
          {
            if (fieldGeneratorDisplayName.have_value)
              {
                result.setDisplayName(fieldGeneratorDisplayName.value);
                fieldGeneratorDisplayName.have_value = false;
              }
            else if ((!(result.hasDisplayName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DisplayName\" field was missing.");
              }
            if (fieldGeneratorProductId.have_value)
              {
                result.setProductId(fieldGeneratorProductId.value);
                fieldGeneratorProductId.have_value = false;
              }
            else if ((!(result.hasProductId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ProductId\" field was missing.");
              }
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            else if ((!(result.hasDescription())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Description\" field was missing.");
              }
            if (fieldGeneratorImage.have_value)
              {
                result.setImage(fieldGeneratorImage.value);
                fieldGeneratorImage.have_value = false;
              }
            else if ((!(result.hasImage())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Image\" field was missing.");
              }
            if (fieldGeneratorCapacity.have_value)
              {
                result.setCapacity(fieldGeneratorCapacity.value);
                fieldGeneratorCapacity.have_value = false;
              }
            else if ((!(result.hasCapacity())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Capacity\" field was missing.");
              }
            if (fieldGeneratorSurgeMultiplier.have_value)
              {
                result.setSurgeMultiplierText(fieldGeneratorSurgeMultiplier.value);
                fieldGeneratorSurgeMultiplier.have_value = false;
              }
            else if ((!(result.hasSurgeMultiplier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SurgeMultiplier\" field was missing.");
              }
            if (fieldGeneratorIsSelected.have_value)
              {
                result.setIsSelected(fieldGeneratorIsSelected.value);
                fieldGeneratorIsSelected.have_value = false;
              }
            if (fieldGeneratorIsShared.have_value)
              {
                result.setIsShared(fieldGeneratorIsShared.value);
                fieldGeneratorIsShared.have_value = false;
              }
            if (fieldGeneratorCount.have_value)
              {
                result.setCount(fieldGeneratorCount.value);
                fieldGeneratorCount.have_value = false;
              }
            if (fieldGeneratorPickUpEstimateInSeconds.have_value)
              {
                result.setPickUpEstimateInSecondsText(fieldGeneratorPickUpEstimateInSeconds.value);
                fieldGeneratorPickUpEstimateInSeconds.have_value = false;
              }
            if (fieldGeneratorFareType.have_value)
              {
                result.setFareType(fieldGeneratorFareType.value);
                fieldGeneratorFareType.have_value = false;
              }
            else if ((!(result.hasFareType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FareType\" field was missing.");
              }
            if (fieldGeneratorFare.have_value)
              {
                result.setFare(fieldGeneratorFare.value);
                fieldGeneratorFare.have_value = false;
              }
            if (fieldGeneratorTripEstimates.have_value)
              {
                result.setTripEstimates(fieldGeneratorTripEstimates.value);
                fieldGeneratorTripEstimates.have_value = false;
              }
          }
        protected abstract void handle_result(UberCompositeProductJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "pacity", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorCapacity;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "unt", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorCount;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "scription", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorDescription;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "splayName", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorDisplayName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if (String.Compare(field_name, 1, "are", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorFare;
                          }
                        switch (field_name[4])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 5, "ype", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorFareType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'm':
                            if ((String.Compare(field_name, 2, "age", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorImage;
                            break;
                        case 's':
                            if (String.Compare(field_name, 2, "S", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'e':
                                        if ((String.Compare(field_name, 4, "lected", 0, 6, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorIsSelected;
                                        break;
                                    case 'h':
                                        if ((String.Compare(field_name, 4, "ared", 0, 4, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorIsShared;
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
                case 'P':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "ckUpEstimateInSeconds", 0, 21, false) == 0) && (field_name.Length == 23))
                                return fieldGeneratorPickUpEstimateInSeconds;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "oductId", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorProductId;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "urgeMultiplier", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorSurgeMultiplier;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ripEstimates", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorTripEstimates;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDisplayName = new JSONHoldingStringGenerator("field \"DisplayName\" of the UberCompositeProduct class");
            fieldGeneratorProductId = new JSONHoldingStringGenerator("field \"ProductId\" of the UberCompositeProduct class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the UberCompositeProduct class");
            fieldGeneratorImage = new JSONHoldingStringGenerator("field \"Image\" of the UberCompositeProduct class");
            fieldGeneratorCapacity = new FieldHoldingGeneratorCapacity("field \"Capacity\" of the UberCompositeProduct class");
            fieldGeneratorSurgeMultiplier = new JSONHoldingNumberTextGenerator("field \"SurgeMultiplier\" of the UberCompositeProduct class");
            fieldGeneratorIsSelected = new JSONHoldingBooleanGenerator("field \"IsSelected\" of the UberCompositeProduct class");
            fieldGeneratorIsShared = new JSONHoldingBooleanGenerator("field \"IsShared\" of the UberCompositeProduct class");
            fieldGeneratorCount = new FieldHoldingGeneratorCount("field \"Count\" of the UberCompositeProduct class");
            fieldGeneratorPickUpEstimateInSeconds = new JSONHoldingNumberTextGenerator("field \"PickUpEstimateInSeconds\" of the UberCompositeProduct class");
            fieldGeneratorFareType = new FieldHoldingGeneratorFareType("field \"FareType\" of the UberCompositeProduct class");
            fieldGeneratorFare = new UberFareJSON.HoldingGenerator("field \"Fare\" of the UberCompositeProduct class", ignore_extras);
            fieldGeneratorTripEstimates = new UberTripEstimatesJSON.HoldingGenerator("field \"TripEstimates\" of the UberCompositeProduct class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberCompositeProduct class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDisplayName = new JSONHoldingStringGenerator("field \"DisplayName\" of the UberCompositeProduct class");
            fieldGeneratorProductId = new JSONHoldingStringGenerator("field \"ProductId\" of the UberCompositeProduct class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the UberCompositeProduct class");
            fieldGeneratorImage = new JSONHoldingStringGenerator("field \"Image\" of the UberCompositeProduct class");
            fieldGeneratorCapacity = new FieldHoldingGeneratorCapacity("field \"Capacity\" of the UberCompositeProduct class");
            fieldGeneratorSurgeMultiplier = new JSONHoldingNumberTextGenerator("field \"SurgeMultiplier\" of the UberCompositeProduct class");
            fieldGeneratorIsSelected = new JSONHoldingBooleanGenerator("field \"IsSelected\" of the UberCompositeProduct class");
            fieldGeneratorIsShared = new JSONHoldingBooleanGenerator("field \"IsShared\" of the UberCompositeProduct class");
            fieldGeneratorCount = new FieldHoldingGeneratorCount("field \"Count\" of the UberCompositeProduct class");
            fieldGeneratorPickUpEstimateInSeconds = new JSONHoldingNumberTextGenerator("field \"PickUpEstimateInSeconds\" of the UberCompositeProduct class");
            fieldGeneratorFareType = new FieldHoldingGeneratorFareType("field \"FareType\" of the UberCompositeProduct class");
            fieldGeneratorFare = new UberFareJSON.HoldingGenerator("field \"Fare\" of the UberCompositeProduct class", false);
            fieldGeneratorTripEstimates = new UberTripEstimatesJSON.HoldingGenerator("field \"TripEstimates\" of the UberCompositeProduct class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberCompositeProduct class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDisplayName.reset();
            fieldGeneratorProductId.reset();
            fieldGeneratorDescription.reset();
            fieldGeneratorImage.reset();
            fieldGeneratorCapacity.reset();
            fieldGeneratorSurgeMultiplier.reset();
            fieldGeneratorIsSelected.reset();
            fieldGeneratorIsShared.reset();
            fieldGeneratorCount.reset();
            fieldGeneratorPickUpEstimateInSeconds.reset();
            fieldGeneratorFareType.reset();
            fieldGeneratorFare.reset();
            fieldGeneratorTripEstimates.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFare.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTripEstimates.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFare.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTripEstimates.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UberCompositeProductJSON  result)
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
        public UberCompositeProductJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberCompositeProductJSON  result)
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
    protected virtual void handle_result(List<UberCompositeProductJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberCompositeProductJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberCompositeProductJSON>();
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
    public List<UberCompositeProductJSON> value;
  };
  };
