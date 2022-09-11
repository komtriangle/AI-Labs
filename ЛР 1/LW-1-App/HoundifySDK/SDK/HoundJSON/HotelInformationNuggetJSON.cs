/* file "HotelInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HotelInformationNuggetJSON : InformationNuggetJSON
  {
    public enum TypeHotelCommandKind
      {
        HotelCommandKind_ShowList
      };

    public static TypeHotelCommandKind  stringToHotelCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "ShowList", 0, 8, false) == 0) && (chars.Length == 8))
            return TypeHotelCommandKind.HotelCommandKind_ShowList;
        throw new Exception("The value for field `HotelCommandKind' is not one of the legal values.");
      }

    public static string  stringFromHotelCommandKind(TypeHotelCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeHotelCommandKind.HotelCommandKind_ShowList:
                return "ShowList";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasHotelCommandKind;
    private bool flagHasHotelSearchCriteria;
    private HotelFilterSpecJSON  storeHotelSearchCriteria;
    private bool flagHasHotelSearchCriteriaIncremental;
    private HotelFilterSpecJSON  storeHotelSearchCriteriaIncremental;
    private bool flagHasTotalResultsFound;
    private BigInteger storeTotalResultsFound;
    private bool flagHasCheckInDateAndTime;
    private DateAndOrTimeJSON  storeCheckInDateAndTime;
    private bool flagHasCheckOutDateAndTime;
    private DateAndOrTimeJSON  storeCheckOutDateAndTime;
    private bool flagHasHotels;
    private List< HotelJSON  > storeHotels;
    private bool flagHasResultIndexReferenced;
    private BigInteger storeResultIndexReferenced;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraHotelCommandKindToJSON()
      {
        JSONStringValue generated_string_HotelCommandKind;
        generated_string_HotelCommandKind = new JSONStringValue("ShowList");
        return generated_string_HotelCommandKind;
      }

    private JSONValue  extraHotelSearchCriteriaToJSON()
      {
        JSONValueHandler handler_HotelSearchCriteria = new JSONValueHandler();
        storeHotelSearchCriteria.write_as_json(handler_HotelSearchCriteria);
        return handler_HotelSearchCriteria.result;
      }

    private JSONValue  extraHotelSearchCriteriaIncrementalToJSON()
      {
        JSONValueHandler handler_HotelSearchCriteriaIncremental = new JSONValueHandler();
        storeHotelSearchCriteriaIncremental.write_as_json(handler_HotelSearchCriteriaIncremental);
        return handler_HotelSearchCriteriaIncremental.result;
      }

    private JSONValue  extraTotalResultsFoundToJSON()
      {
        JSONIntegerValue generated_integer_TotalResultsFound = new JSONIntegerValue(storeTotalResultsFound);
        return generated_integer_TotalResultsFound;
      }

    private JSONValue  extraCheckInDateAndTimeToJSON()
      {
        JSONValueHandler handler_CheckInDateAndTime = new JSONValueHandler();
        storeCheckInDateAndTime.write_as_json(handler_CheckInDateAndTime);
        return handler_CheckInDateAndTime.result;
      }

    private JSONValue  extraCheckOutDateAndTimeToJSON()
      {
        JSONValueHandler handler_CheckOutDateAndTime = new JSONValueHandler();
        storeCheckOutDateAndTime.write_as_json(handler_CheckOutDateAndTime);
        return handler_CheckOutDateAndTime.result;
      }

    private JSONValue  extraHotelsToJSON()
      {
        JSONArrayValue generated_array_1_Hotels = new JSONArrayValue();
        for (int num1 = 0; num1 < storeHotels.Count; ++num1)
          {
            JSONValueHandler handler_Hotels = new JSONValueHandler();
            storeHotels[num1].write_as_json(handler_Hotels);
            generated_array_1_Hotels.appendComponent(handler_Hotels.result);
          }
        return generated_array_1_Hotels;
      }

    private JSONValue  extraResultIndexReferencedToJSON()
      {
        JSONIntegerValue generated_integer_ResultIndexReferenced = new JSONIntegerValue(storeResultIndexReferenced);
        return generated_integer_ResultIndexReferenced;
      }


    private void  fromJSONHotelCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HotelCommandKind of HotelInformationNuggetJSON is not a string.");
        if (!(json_string.getData().Equals("ShowList")))
            throw new Exception("The value for field HotelCommandKind of HotelInformationNuggetJSON is not `ShowList'.");
        setHotelCommandKind();
      }


    private void  fromJSONHotelSearchCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HotelFilterSpecJSON convert_classy = HotelFilterSpecJSON.from_json(json_value, ignore_extras, true);
        setHotelSearchCriteria(convert_classy);
      }


    private void  fromJSONHotelSearchCriteriaIncremental(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HotelFilterSpecJSON convert_classy = HotelFilterSpecJSON.from_json(json_value, ignore_extras, true);
        setHotelSearchCriteriaIncremental(convert_classy);
      }


    private void  fromJSONTotalResultsFound(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TotalResultsFound of HotelInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TotalResultsFound of HotelInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTotalResultsFound(extracted_integer);
      }


    private void  fromJSONCheckInDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setCheckInDateAndTime(convert_classy);
      }


    private void  fromJSONCheckOutDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setCheckOutDateAndTime(convert_classy);
      }


    private void  fromJSONHotels(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Hotels of HotelInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HotelJSON  > vector_Hotels1 = new List< HotelJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HotelJSON convert_classy = HotelJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Hotels1.Add(convert_classy);
          }
        initHotels();
        for (int num1 = 0; num1 < vector_Hotels1.Count; ++num1)
            appendHotels(vector_Hotels1[num1]);
        for (int num1 = 0; num1 < vector_Hotels1.Count; ++num1)
          {
          }
      }


    private void  fromJSONResultIndexReferenced(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ResultIndexReferenced of HotelInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ResultIndexReferenced of HotelInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setResultIndexReferenced(extracted_integer);
      }


    public HotelInformationNuggetJSON()
      {
        flagHasHotelCommandKind = false;
        flagHasHotelSearchCriteria = false;
        flagHasHotelSearchCriteriaIncremental = false;
        flagHasTotalResultsFound = false;
        flagHasCheckInDateAndTime = false;
        flagHasCheckOutDateAndTime = false;
        flagHasHotels = false;
        flagHasResultIndexReferenced = false;
        storeHotels = new List< HotelJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "Hotel";
      }

    public bool  hasHotelCommandKind()
      {
        return flagHasHotelCommandKind;
      }

    public TypeHotelCommandKind  getHotelCommandKind()
      {
        Debug.Assert(flagHasHotelCommandKind);
        return TypeHotelCommandKind.HotelCommandKind_ShowList;
      }

    public string  getHotelCommandKindAsString()
      {
        return stringFromHotelCommandKind(getHotelCommandKind());
      }

    public bool  hasHotelSearchCriteria()
      {
        return flagHasHotelSearchCriteria;
      }

    public HotelFilterSpecJSON   getHotelSearchCriteria()
      {
        Debug.Assert(flagHasHotelSearchCriteria);
        return storeHotelSearchCriteria;
      }

    public bool  hasHotelSearchCriteriaIncremental()
      {
        return flagHasHotelSearchCriteriaIncremental;
      }

    public HotelFilterSpecJSON   getHotelSearchCriteriaIncremental()
      {
        Debug.Assert(flagHasHotelSearchCriteriaIncremental);
        return storeHotelSearchCriteriaIncremental;
      }

    public bool  hasTotalResultsFound()
      {
        return flagHasTotalResultsFound;
      }

    public BigInteger  getTotalResultsFound()
      {
        Debug.Assert(flagHasTotalResultsFound);
        return storeTotalResultsFound;
      }

    public bool  hasCheckInDateAndTime()
      {
        return flagHasCheckInDateAndTime;
      }

    public DateAndOrTimeJSON   getCheckInDateAndTime()
      {
        Debug.Assert(flagHasCheckInDateAndTime);
        return storeCheckInDateAndTime;
      }

    public bool  hasCheckOutDateAndTime()
      {
        return flagHasCheckOutDateAndTime;
      }

    public DateAndOrTimeJSON   getCheckOutDateAndTime()
      {
        Debug.Assert(flagHasCheckOutDateAndTime);
        return storeCheckOutDateAndTime;
      }

    public bool  hasHotels()
      {
        return flagHasHotels;
      }

    public int  countOfHotels()
      {
        Debug.Assert(flagHasHotels);
        return storeHotels.Count;
      }

    public HotelJSON   elementOfHotels(int element_num)
      {
        Debug.Assert(flagHasHotels);
        return storeHotels[element_num];
      }

    public List< HotelJSON  >  getHotels()
      {
        Debug.Assert(flagHasHotels);
        return storeHotels;
      }

    public bool  hasResultIndexReferenced()
      {
        return flagHasResultIndexReferenced;
      }

    public BigInteger  getResultIndexReferenced()
      {
        Debug.Assert(flagHasResultIndexReferenced);
        return storeResultIndexReferenced;
      }


    public virtual int extraHotelInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHotelInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHotelInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHotelInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasHotelCommandKind)
            ++result;
        if (flagHasHotelSearchCriteria)
            ++result;
        if (flagHasHotelSearchCriteriaIncremental)
            ++result;
        if (flagHasTotalResultsFound)
            ++result;
        if (flagHasCheckInDateAndTime)
            ++result;
        if (flagHasCheckOutDateAndTime)
            ++result;
        if (flagHasHotels)
            ++result;
        if (flagHasResultIndexReferenced)
            ++result;
        result += extraHotelInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasHotelCommandKind)
          {
            if (remainder == 0)
                return "HotelCommandKind";
            --remainder;
          }
        if (flagHasHotelSearchCriteria)
          {
            if (remainder == 0)
                return "HotelSearchCriteria";
            --remainder;
          }
        if (flagHasHotelSearchCriteriaIncremental)
          {
            if (remainder == 0)
                return "HotelSearchCriteriaIncremental";
            --remainder;
          }
        if (flagHasTotalResultsFound)
          {
            if (remainder == 0)
                return "TotalResultsFound";
            --remainder;
          }
        if (flagHasCheckInDateAndTime)
          {
            if (remainder == 0)
                return "CheckInDateAndTime";
            --remainder;
          }
        if (flagHasCheckOutDateAndTime)
          {
            if (remainder == 0)
                return "CheckOutDateAndTime";
            --remainder;
          }
        if (flagHasHotels)
          {
            if (remainder == 0)
                return "Hotels";
            --remainder;
          }
        if (flagHasResultIndexReferenced)
          {
            if (remainder == 0)
                return "ResultIndexReferenced";
            --remainder;
          }
        return extraHotelInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasHotelCommandKind)
          {
            if (remainder == 0)
                return extraHotelCommandKindToJSON();
            --remainder;
          }
        if (flagHasHotelSearchCriteria)
          {
            if (remainder == 0)
                return extraHotelSearchCriteriaToJSON();
            --remainder;
          }
        if (flagHasHotelSearchCriteriaIncremental)
          {
            if (remainder == 0)
                return extraHotelSearchCriteriaIncrementalToJSON();
            --remainder;
          }
        if (flagHasTotalResultsFound)
          {
            if (remainder == 0)
                return extraTotalResultsFoundToJSON();
            --remainder;
          }
        if (flagHasCheckInDateAndTime)
          {
            if (remainder == 0)
                return extraCheckInDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasCheckOutDateAndTime)
          {
            if (remainder == 0)
                return extraCheckOutDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasHotels)
          {
            if (remainder == 0)
                return extraHotelsToJSON();
            --remainder;
          }
        if (flagHasResultIndexReferenced)
          {
            if (remainder == 0)
                return extraResultIndexReferencedToJSON();
            --remainder;
          }
        return extraHotelInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if (String.Compare(field_name, 1, "heck", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 6, "nDateAndTime", 0, 12, false) == 0) && (field_name.Length == 18))
                                return (flagHasCheckInDateAndTime ? extraCheckInDateAndTimeToJSON() : null);
                            break;
                        case 'O':
                            if ((String.Compare(field_name, 6, "utDateAndTime", 0, 13, false) == 0) && (field_name.Length == 19))
                                return (flagHasCheckOutDateAndTime ? extraCheckOutDateAndTimeToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if (String.Compare(field_name, 1, "otel", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'C':
                            if ((String.Compare(field_name, 6, "ommandKind", 0, 10, false) == 0) && (field_name.Length == 16))
                                return (flagHasHotelCommandKind ? extraHotelCommandKindToJSON() : null);
                            break;
                        case 'S':
                            if (String.Compare(field_name, 6, "earchCriteria", 0, 13, false) == 0)
                              {
                                if (field_name.Length == 19)
                                  {
                                    return (flagHasHotelSearchCriteria ? extraHotelSearchCriteriaToJSON() : null);
                                  }
                                switch (field_name[19])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 20, "ncremental", 0, 10, false) == 0) && (field_name.Length == 30))
                                            return (flagHasHotelSearchCriteriaIncremental ? extraHotelSearchCriteriaIncrementalToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if (field_name.Length == 6)
                                return (flagHasHotels ? extraHotelsToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "esultIndexReferenced", 0, 20, false) == 0) && (field_name.Length == 21))
                    return (flagHasResultIndexReferenced ? extraResultIndexReferencedToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "otalResultsFound", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasTotalResultsFound ? extraTotalResultsFoundToJSON() : null);
                break;
            default:
                break;
          }
        return extraHotelInformationNuggetLookup(field_name);
      }

    public void setHotelCommandKind()
      {
        flagHasHotelCommandKind = true;
      }
    public void setHotelCommandKind(TypeHotelCommandKind new_value)
      {
        setHotelCommandKind();
      }
    public void setHotelCommandKind(string chars)
      {
        setHotelCommandKind(stringToHotelCommandKind(chars));
      }
    public void unsetHotelCommandKind()
      {
        flagHasHotelCommandKind = false;
      }
    public void setHotelSearchCriteria(HotelFilterSpecJSON  new_value)
      {
        if (flagHasHotelSearchCriteria)
          {
          }
        flagHasHotelSearchCriteria = true;
        storeHotelSearchCriteria = new_value;
      }
    public void unsetHotelSearchCriteria()
      {
        if (flagHasHotelSearchCriteria)
          {
          }
        flagHasHotelSearchCriteria = false;
      }
    public void setHotelSearchCriteriaIncremental(HotelFilterSpecJSON  new_value)
      {
        if (flagHasHotelSearchCriteriaIncremental)
          {
          }
        flagHasHotelSearchCriteriaIncremental = true;
        storeHotelSearchCriteriaIncremental = new_value;
      }
    public void unsetHotelSearchCriteriaIncremental()
      {
        if (flagHasHotelSearchCriteriaIncremental)
          {
          }
        flagHasHotelSearchCriteriaIncremental = false;
      }
    public void setTotalResultsFound(BigInteger new_value)
      {
        flagHasTotalResultsFound = true;
        if (new_value < 0)
            throw new Exception("The value for field TotalResultsFound of HotelInformationNuggetJSON is less than the lower bound (0) for that field.");
        storeTotalResultsFound = new_value;
      }
    public void unsetTotalResultsFound()
      {
        flagHasTotalResultsFound = false;
      }
    public void setCheckInDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasCheckInDateAndTime)
          {
          }
        flagHasCheckInDateAndTime = true;
        storeCheckInDateAndTime = new_value;
      }
    public void unsetCheckInDateAndTime()
      {
        if (flagHasCheckInDateAndTime)
          {
          }
        flagHasCheckInDateAndTime = false;
      }
    public void setCheckOutDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasCheckOutDateAndTime)
          {
          }
        flagHasCheckOutDateAndTime = true;
        storeCheckOutDateAndTime = new_value;
      }
    public void unsetCheckOutDateAndTime()
      {
        if (flagHasCheckOutDateAndTime)
          {
          }
        flagHasCheckOutDateAndTime = false;
      }
    public void initHotels()
      {
        if (flagHasHotels)
          {
            for (int num1 = 0; num1 < storeHotels.Count; ++num1)
              {
              }
          }
        flagHasHotels = true;
        storeHotels.Clear();
      }
    public void appendHotels(HotelJSON  to_append)
      {
        if (!flagHasHotels)
          {
            flagHasHotels = true;
            storeHotels.Clear();
          }
        Debug.Assert(flagHasHotels);
        storeHotels.Add(to_append);
      }
    public void unsetHotels()
      {
        if (flagHasHotels)
          {
            for (int num2 = 0; num2 < storeHotels.Count; ++num2)
              {
              }
          }
        flagHasHotels = false;
        storeHotels.Clear();
      }
    public void setResultIndexReferenced(BigInteger new_value)
      {
        flagHasResultIndexReferenced = true;
        if (new_value < 0)
            throw new Exception("The value for field ResultIndexReferenced of HotelInformationNuggetJSON is less than the lower bound (0) for that field.");
        storeResultIndexReferenced = new_value;
      }
    public void unsetResultIndexReferenced()
      {
        flagHasResultIndexReferenced = false;
      }

    public virtual void extraHotelInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHotelInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHotelInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraHotelInformationNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if (String.Compare(key, 1, "heck", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'I':
                            if ((String.Compare(key, 6, "nDateAndTime", 0, 12, false) == 0) && (key.Length == 18))
                                {
                                fromJSONCheckInDateAndTime(new_component, false);
                                return;
                                }
                            break;
                        case 'O':
                            if ((String.Compare(key, 6, "utDateAndTime", 0, 13, false) == 0) && (key.Length == 19))
                                {
                                fromJSONCheckOutDateAndTime(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if (String.Compare(key, 1, "otel", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'C':
                            if ((String.Compare(key, 6, "ommandKind", 0, 10, false) == 0) && (key.Length == 16))
                                {
                                fromJSONHotelCommandKind(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if (String.Compare(key, 6, "earchCriteria", 0, 13, false) == 0)
                              {
                                if (key.Length == 19)
                                  {
                                    {
                                    fromJSONHotelSearchCriteria(new_component, false);
                                    return;
                                    }
                                  }
                                switch (key[19])
                                  {
                                    case 'I':
                                        if ((String.Compare(key, 20, "ncremental", 0, 10, false) == 0) && (key.Length == 30))
                                            {
                                            fromJSONHotelSearchCriteriaIncremental(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if (key.Length == 6)
                                {
                                fromJSONHotels(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esultIndexReferenced", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONResultIndexReferenced(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "otalResultsFound", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONTotalResultsFound(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraHotelInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if (String.Compare(key, 1, "heck", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'I':
                            if ((String.Compare(key, 6, "nDateAndTime", 0, 12, false) == 0) && (key.Length == 18))
                                {
                                fromJSONCheckInDateAndTime(new_component, false);
                                return;
                                }
                            break;
                        case 'O':
                            if ((String.Compare(key, 6, "utDateAndTime", 0, 13, false) == 0) && (key.Length == 19))
                                {
                                fromJSONCheckOutDateAndTime(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if (String.Compare(key, 1, "otel", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'C':
                            if ((String.Compare(key, 6, "ommandKind", 0, 10, false) == 0) && (key.Length == 16))
                                {
                                fromJSONHotelCommandKind(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if (String.Compare(key, 6, "earchCriteria", 0, 13, false) == 0)
                              {
                                if (key.Length == 19)
                                  {
                                    {
                                    fromJSONHotelSearchCriteria(new_component, false);
                                    return;
                                    }
                                  }
                                switch (key[19])
                                  {
                                    case 'I':
                                        if ((String.Compare(key, 20, "ncremental", 0, 10, false) == 0) && (key.Length == 30))
                                            {
                                            fromJSONHotelSearchCriteriaIncremental(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 's':
                            if (key.Length == 6)
                                {
                                fromJSONHotels(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esultIndexReferenced", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONResultIndexReferenced(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "otalResultsFound", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONTotalResultsFound(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraHotelInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasHotelCommandKind);
        if (flagHasHotelCommandKind)
          {
            handler.start_pair("HotelCommandKind");
            handler.string_value("ShowList");
          }
        if (flagHasHotelSearchCriteria)
          {
            handler.start_pair("HotelSearchCriteria");
            if (partial_allowed)
                storeHotelSearchCriteria.write_partial_as_json(handler);
            else
                storeHotelSearchCriteria.write_as_json(handler);
          }
        if (flagHasHotelSearchCriteriaIncremental)
          {
            handler.start_pair("HotelSearchCriteriaIncremental");
            if (partial_allowed)
                storeHotelSearchCriteriaIncremental.write_partial_as_json(handler);
            else
                storeHotelSearchCriteriaIncremental.write_as_json(handler);
          }
        if (flagHasTotalResultsFound)
          {
            handler.start_pair("TotalResultsFound");
            handler.number_value(storeTotalResultsFound);
          }
        if (flagHasCheckInDateAndTime)
          {
            handler.start_pair("CheckInDateAndTime");
            if (partial_allowed)
                storeCheckInDateAndTime.write_partial_as_json(handler);
            else
                storeCheckInDateAndTime.write_as_json(handler);
          }
        if (flagHasCheckOutDateAndTime)
          {
            handler.start_pair("CheckOutDateAndTime");
            if (partial_allowed)
                storeCheckOutDateAndTime.write_partial_as_json(handler);
            else
                storeCheckOutDateAndTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasHotels);
        if (flagHasHotels)
          {
            handler.start_pair("Hotels");
            handler.start_array();
            for (int num1 = 0; num1 < storeHotels.Count; ++num1)
              {
                if (partial_allowed)
                    storeHotels[num1].write_partial_as_json(handler);
                else
                    storeHotels[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasResultIndexReferenced)
          {
            handler.start_pair("ResultIndexReferenced");
            handler.number_value(storeResultIndexReferenced);
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
        if (!(hasHotelCommandKind()))
          {
            return "When parsing the object for %what%, the \"HotelCommandKind\" field was missing.";
          }
        if (!(hasHotels()))
          {
            return "When parsing the object for %what%, the \"Hotels\" field was missing.";
          }
        return null;
      }

    public static new HotelInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HotelInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelInformationNugget", ignore_extras);
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
    public static new HotelInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HotelInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HotelInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelInformationNugget", ignore_extras);
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
    public static new HotelInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HotelInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        HotelInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HotelInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HotelInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HotelInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HotelInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
    private abstract class FieldGeneratorHotelCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorHotelCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorHotelCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToHotelCommandKind(result));
              }
            protected abstract void handle_result(TypeHotelCommandKind result);
          };
    private class FieldHoldingGeneratorHotelCommandKind : FieldGeneratorHotelCommandKind
  {
    protected override void handle_result(TypeHotelCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorHotelCommandKind(String what)
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
    public TypeHotelCommandKind value;
  };
    private class FieldHoldingArrayGeneratorHotelCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorHotelCommandKind
      {
        private FieldHoldingArrayGeneratorHotelCommandKind top;

        protected override void handle_result(TypeHotelCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorHotelCommandKind init_top)
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
    protected virtual void handle_result(List<TypeHotelCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorHotelCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHotelCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorHotelCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeHotelCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeHotelCommandKind> value;
  };
        private FieldHoldingGeneratorHotelCommandKind fieldGeneratorHotelCommandKind;
        private HotelFilterSpecJSON.HoldingGenerator fieldGeneratorHotelSearchCriteria;
        private HotelFilterSpecJSON.HoldingGenerator fieldGeneratorHotelSearchCriteriaIncremental;
    private class FieldHoldingGeneratorTotalResultsFound : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTotalResultsFound(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTotalResultsFound : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTotalResultsFound(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTotalResultsFound fieldGeneratorTotalResultsFound;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorCheckInDateAndTime;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorCheckOutDateAndTime;
        private HotelJSON.HoldingArrayGenerator fieldGeneratorHotels;
    private class FieldHoldingGeneratorResultIndexReferenced : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorResultIndexReferenced(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorResultIndexReferenced : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorResultIndexReferenced(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorResultIndexReferenced fieldGeneratorResultIndexReferenced;
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
            if (!(getInformationNuggetJSONKey().Equals("Hotel")))
                throw new Exception("The key field has a value other than `Hotel'.");
            HotelInformationNuggetJSON result = new HotelInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHotelInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((HotelInformationNuggetJSON )new_result);
          }
        protected void finish(HotelInformationNuggetJSON result)
          {
            if (fieldGeneratorHotelCommandKind.have_value)
              {
                result.setHotelCommandKind();
                fieldGeneratorHotelCommandKind.have_value = false;
              }
            else if ((!(result.hasHotelCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HotelCommandKind\" field was missing.");
              }
            if (fieldGeneratorHotelSearchCriteria.have_value)
              {
                result.setHotelSearchCriteria(fieldGeneratorHotelSearchCriteria.value);
                fieldGeneratorHotelSearchCriteria.have_value = false;
              }
            if (fieldGeneratorHotelSearchCriteriaIncremental.have_value)
              {
                result.setHotelSearchCriteriaIncremental(fieldGeneratorHotelSearchCriteriaIncremental.value);
                fieldGeneratorHotelSearchCriteriaIncremental.have_value = false;
              }
            if (fieldGeneratorTotalResultsFound.have_value)
              {
                result.setTotalResultsFound(fieldGeneratorTotalResultsFound.value);
                fieldGeneratorTotalResultsFound.have_value = false;
              }
            if (fieldGeneratorCheckInDateAndTime.have_value)
              {
                result.setCheckInDateAndTime(fieldGeneratorCheckInDateAndTime.value);
                fieldGeneratorCheckInDateAndTime.have_value = false;
              }
            if (fieldGeneratorCheckOutDateAndTime.have_value)
              {
                result.setCheckOutDateAndTime(fieldGeneratorCheckOutDateAndTime.value);
                fieldGeneratorCheckOutDateAndTime.have_value = false;
              }
            if (fieldGeneratorHotels.have_value)
              {
                result.initHotels();
                int count = fieldGeneratorHotels.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHotels(fieldGeneratorHotels.value[num]);
                  }
                fieldGeneratorHotels.value.Clear();
                fieldGeneratorHotels.have_value = false;
              }
            else if ((!(result.hasHotels())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Hotels\" field was missing.");
              }
            if (fieldGeneratorResultIndexReferenced.have_value)
              {
                result.setResultIndexReferenced(fieldGeneratorResultIndexReferenced.value);
                fieldGeneratorResultIndexReferenced.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(HotelInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "heck", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 6, "nDateAndTime", 0, 12, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorCheckInDateAndTime;
                                break;
                            case 'O':
                                if ((String.Compare(field_name, 6, "utDateAndTime", 0, 13, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorCheckOutDateAndTime;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if (String.Compare(field_name, 1, "otel", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 6, "ommandKind", 0, 10, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorHotelCommandKind;
                                break;
                            case 'S':
                                if (String.Compare(field_name, 6, "earchCriteria", 0, 13, false) == 0)
                                  {
                                    if (field_name.Length == 19)
                                      {
                                        return fieldGeneratorHotelSearchCriteria;
                                      }
                                    switch (field_name[19])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 20, "ncremental", 0, 10, false) == 0) && (field_name.Length == 30))
                                                return fieldGeneratorHotelSearchCriteriaIncremental;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 's':
                                if (field_name.Length == 6)
                                    return fieldGeneratorHotels;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esultIndexReferenced", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorResultIndexReferenced;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "otalResultsFound", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorTotalResultsFound;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorHotelCommandKind = new FieldHoldingGeneratorHotelCommandKind("field \"HotelCommandKind\" of the HotelInformationNugget class");
            fieldGeneratorHotelSearchCriteria = new HotelFilterSpecJSON.HoldingGenerator("field \"HotelSearchCriteria\" of the HotelInformationNugget class", ignore_extras);
            fieldGeneratorHotelSearchCriteriaIncremental = new HotelFilterSpecJSON.HoldingGenerator("field \"HotelSearchCriteriaIncremental\" of the HotelInformationNugget class", ignore_extras);
            fieldGeneratorTotalResultsFound = new FieldHoldingGeneratorTotalResultsFound("field \"TotalResultsFound\" of the HotelInformationNugget class");
            fieldGeneratorCheckInDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"CheckInDateAndTime\" of the HotelInformationNugget class", ignore_extras);
            fieldGeneratorCheckOutDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"CheckOutDateAndTime\" of the HotelInformationNugget class", ignore_extras);
            fieldGeneratorHotels = new HotelJSON.HoldingArrayGenerator("field \"Hotels\" of the HotelInformationNugget class", ignore_extras);
            fieldGeneratorResultIndexReferenced = new FieldHoldingGeneratorResultIndexReferenced("field \"ResultIndexReferenced\" of the HotelInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HotelInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorHotelCommandKind = new FieldHoldingGeneratorHotelCommandKind("field \"HotelCommandKind\" of the HotelInformationNugget class");
            fieldGeneratorHotelSearchCriteria = new HotelFilterSpecJSON.HoldingGenerator("field \"HotelSearchCriteria\" of the HotelInformationNugget class", false);
            fieldGeneratorHotelSearchCriteriaIncremental = new HotelFilterSpecJSON.HoldingGenerator("field \"HotelSearchCriteriaIncremental\" of the HotelInformationNugget class", false);
            fieldGeneratorTotalResultsFound = new FieldHoldingGeneratorTotalResultsFound("field \"TotalResultsFound\" of the HotelInformationNugget class");
            fieldGeneratorCheckInDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"CheckInDateAndTime\" of the HotelInformationNugget class", false);
            fieldGeneratorCheckOutDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"CheckOutDateAndTime\" of the HotelInformationNugget class", false);
            fieldGeneratorHotels = new HotelJSON.HoldingArrayGenerator("field \"Hotels\" of the HotelInformationNugget class", false);
            fieldGeneratorResultIndexReferenced = new FieldHoldingGeneratorResultIndexReferenced("field \"ResultIndexReferenced\" of the HotelInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HotelInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorHotelCommandKind.reset();
            fieldGeneratorHotelSearchCriteria.reset();
            fieldGeneratorHotelSearchCriteriaIncremental.reset();
            fieldGeneratorTotalResultsFound.reset();
            fieldGeneratorCheckInDateAndTime.reset();
            fieldGeneratorCheckOutDateAndTime.reset();
            fieldGeneratorHotels.reset();
            fieldGeneratorResultIndexReferenced.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HotelInformationNuggetJSON  result)
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
        public HotelInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HotelInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<HotelInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HotelInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HotelInformationNuggetJSON>();
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
    public List<HotelInformationNuggetJSON> value;
  };
  };
