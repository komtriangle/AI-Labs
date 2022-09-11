/* file "CustomStockEntityDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CustomStockEntityDataJSON : StockEntityDataJSON
  {
    private bool flagHasListingRequestType;
    private StockListingRequestTypeJSON  storeListingRequestType;
    private bool flagHasShortSpokenName;
    private string storeShortSpokenName;
    private bool flagHasPossessiveShortSpokenName;
    private string storePossessiveShortSpokenName;
    private bool flagHasLongSpokenName;
    private string storeLongSpokenName;
    private bool flagHasShortDisplayName;
    private string storeShortDisplayName;
    private bool flagHasPossessiveShortDisplayName;
    private string storePossessiveShortDisplayName;
    private bool flagHasMediumDisplayName;
    private string storeMediumDisplayName;
    private bool flagHasLongDisplayName;
    private string storeLongDisplayName;
    private bool flagHasCountryCode;
    private string storeCountryCode;
    private bool flagHasDataSourceName;
    private string storeDataSourceName;
    private bool flagHasStockListings;
    private List< StockListingDataJSON  > storeStockListings;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraListingRequestTypeToJSON()
      {
        JSONValueHandler handler_ListingRequestType = new JSONValueHandler();
        storeListingRequestType.write_as_json(handler_ListingRequestType);
        return handler_ListingRequestType.result;
      }

    private JSONValue  extraShortSpokenNameToJSON()
      {
        JSONStringValue generated_string_ShortSpokenName = new JSONStringValue(storeShortSpokenName);
        return generated_string_ShortSpokenName;
      }

    private JSONValue  extraPossessiveShortSpokenNameToJSON()
      {
        JSONStringValue generated_string_PossessiveShortSpokenName = new JSONStringValue(storePossessiveShortSpokenName);
        return generated_string_PossessiveShortSpokenName;
      }

    private JSONValue  extraLongSpokenNameToJSON()
      {
        JSONStringValue generated_string_LongSpokenName = new JSONStringValue(storeLongSpokenName);
        return generated_string_LongSpokenName;
      }

    private JSONValue  extraShortDisplayNameToJSON()
      {
        JSONStringValue generated_string_ShortDisplayName = new JSONStringValue(storeShortDisplayName);
        return generated_string_ShortDisplayName;
      }

    private JSONValue  extraPossessiveShortDisplayNameToJSON()
      {
        JSONStringValue generated_string_PossessiveShortDisplayName = new JSONStringValue(storePossessiveShortDisplayName);
        return generated_string_PossessiveShortDisplayName;
      }

    private JSONValue  extraMediumDisplayNameToJSON()
      {
        JSONStringValue generated_string_MediumDisplayName = new JSONStringValue(storeMediumDisplayName);
        return generated_string_MediumDisplayName;
      }

    private JSONValue  extraLongDisplayNameToJSON()
      {
        JSONStringValue generated_string_LongDisplayName = new JSONStringValue(storeLongDisplayName);
        return generated_string_LongDisplayName;
      }

    private JSONValue  extraCountryCodeToJSON()
      {
        JSONStringValue generated_string_CountryCode = new JSONStringValue(storeCountryCode);
        return generated_string_CountryCode;
      }

    private JSONValue  extraDataSourceNameToJSON()
      {
        JSONStringValue generated_string_DataSourceName = new JSONStringValue(storeDataSourceName);
        return generated_string_DataSourceName;
      }

    private JSONValue  extraStockListingsToJSON()
      {
        JSONArrayValue generated_array_1_StockListings = new JSONArrayValue();
        for (int num1 = 0; num1 < storeStockListings.Count; ++num1)
          {
            JSONValueHandler handler_StockListings = new JSONValueHandler();
            storeStockListings[num1].write_as_json(handler_StockListings);
            generated_array_1_StockListings.appendComponent(handler_StockListings.result);
          }
        return generated_array_1_StockListings;
      }


    private void  fromJSONListingRequestType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        StockListingRequestTypeJSON convert_classy = StockListingRequestTypeJSON.from_json(json_value, ignore_extras, true);
        setListingRequestType(convert_classy);
      }


    private void  fromJSONShortSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ShortSpokenName of CustomStockEntityDataJSON is not a string.");
        setShortSpokenName(json_string.getData());
      }


    private void  fromJSONPossessiveShortSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PossessiveShortSpokenName of CustomStockEntityDataJSON is not a string.");
        setPossessiveShortSpokenName(json_string.getData());
      }


    private void  fromJSONLongSpokenName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LongSpokenName of CustomStockEntityDataJSON is not a string.");
        setLongSpokenName(json_string.getData());
      }


    private void  fromJSONShortDisplayName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ShortDisplayName of CustomStockEntityDataJSON is not a string.");
        setShortDisplayName(json_string.getData());
      }


    private void  fromJSONPossessiveShortDisplayName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PossessiveShortDisplayName of CustomStockEntityDataJSON is not a string.");
        setPossessiveShortDisplayName(json_string.getData());
      }


    private void  fromJSONMediumDisplayName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MediumDisplayName of CustomStockEntityDataJSON is not a string.");
        setMediumDisplayName(json_string.getData());
      }


    private void  fromJSONLongDisplayName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LongDisplayName of CustomStockEntityDataJSON is not a string.");
        setLongDisplayName(json_string.getData());
      }


    private void  fromJSONCountryCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CountryCode of CustomStockEntityDataJSON is not a string.");
        setCountryCode(json_string.getData());
      }


    private void  fromJSONDataSourceName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DataSourceName of CustomStockEntityDataJSON is not a string.");
        setDataSourceName(json_string.getData());
      }


    private void  fromJSONStockListings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StockListings of CustomStockEntityDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< StockListingDataJSON  > vector_StockListings1 = new List< StockListingDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            StockListingDataJSON convert_classy = StockListingDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_StockListings1.Add(convert_classy);
          }
        initStockListings();
        for (int num1 = 0; num1 < vector_StockListings1.Count; ++num1)
            appendStockListings(vector_StockListings1[num1]);
        for (int num1 = 0; num1 < vector_StockListings1.Count; ++num1)
          {
          }
      }


    public CustomStockEntityDataJSON()
      {
        flagHasListingRequestType = false;
        flagHasShortSpokenName = false;
        flagHasPossessiveShortSpokenName = false;
        flagHasLongSpokenName = false;
        flagHasShortDisplayName = false;
        flagHasPossessiveShortDisplayName = false;
        flagHasMediumDisplayName = false;
        flagHasLongDisplayName = false;
        flagHasCountryCode = false;
        flagHasDataSourceName = false;
        flagHasStockListings = false;
        storeStockListings = new List< StockListingDataJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getStockEntityDataKind()
      {
        return "CustomStockEntityData";
      }

    public bool  hasListingRequestType()
      {
        return flagHasListingRequestType;
      }

    public StockListingRequestTypeJSON   getListingRequestType()
      {
        Debug.Assert(flagHasListingRequestType);
        return storeListingRequestType;
      }

    public StockListingRequestTypeJSON.TypeValue  getListingRequestTypeValue()
      {
        return getListingRequestType().getValue();
      }

    public string  getListingRequestTypeAsString()
      {
        return getListingRequestType().getValueAsString();
      }

    public bool  hasShortSpokenName()
      {
        return flagHasShortSpokenName;
      }

    public string  getShortSpokenName()
      {
        Debug.Assert(flagHasShortSpokenName);
        return storeShortSpokenName;
      }

    public bool  hasPossessiveShortSpokenName()
      {
        return flagHasPossessiveShortSpokenName;
      }

    public string  getPossessiveShortSpokenName()
      {
        Debug.Assert(flagHasPossessiveShortSpokenName);
        return storePossessiveShortSpokenName;
      }

    public bool  hasLongSpokenName()
      {
        return flagHasLongSpokenName;
      }

    public string  getLongSpokenName()
      {
        Debug.Assert(flagHasLongSpokenName);
        return storeLongSpokenName;
      }

    public bool  hasShortDisplayName()
      {
        return flagHasShortDisplayName;
      }

    public string  getShortDisplayName()
      {
        Debug.Assert(flagHasShortDisplayName);
        return storeShortDisplayName;
      }

    public bool  hasPossessiveShortDisplayName()
      {
        return flagHasPossessiveShortDisplayName;
      }

    public string  getPossessiveShortDisplayName()
      {
        Debug.Assert(flagHasPossessiveShortDisplayName);
        return storePossessiveShortDisplayName;
      }

    public bool  hasMediumDisplayName()
      {
        return flagHasMediumDisplayName;
      }

    public string  getMediumDisplayName()
      {
        Debug.Assert(flagHasMediumDisplayName);
        return storeMediumDisplayName;
      }

    public bool  hasLongDisplayName()
      {
        return flagHasLongDisplayName;
      }

    public string  getLongDisplayName()
      {
        Debug.Assert(flagHasLongDisplayName);
        return storeLongDisplayName;
      }

    public bool  hasCountryCode()
      {
        return flagHasCountryCode;
      }

    public string  getCountryCode()
      {
        Debug.Assert(flagHasCountryCode);
        return storeCountryCode;
      }

    public bool  hasDataSourceName()
      {
        return flagHasDataSourceName;
      }

    public string  getDataSourceName()
      {
        Debug.Assert(flagHasDataSourceName);
        return storeDataSourceName;
      }

    public bool  hasStockListings()
      {
        return flagHasStockListings;
      }

    public int  countOfStockListings()
      {
        Debug.Assert(flagHasStockListings);
        return storeStockListings.Count;
      }

    public StockListingDataJSON   elementOfStockListings(int element_num)
      {
        Debug.Assert(flagHasStockListings);
        return storeStockListings[element_num];
      }

    public List< StockListingDataJSON  >  getStockListings()
      {
        Debug.Assert(flagHasStockListings);
        return storeStockListings;
      }


    public virtual int extraCustomStockEntityDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCustomStockEntityDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCustomStockEntityDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCustomStockEntityDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraStockEntityDataComponentCount()
      {
        int result = 0;
        if (flagHasListingRequestType)
            ++result;
        if (flagHasShortSpokenName)
            ++result;
        if (flagHasPossessiveShortSpokenName)
            ++result;
        if (flagHasLongSpokenName)
            ++result;
        if (flagHasShortDisplayName)
            ++result;
        if (flagHasPossessiveShortDisplayName)
            ++result;
        if (flagHasMediumDisplayName)
            ++result;
        if (flagHasLongDisplayName)
            ++result;
        if (flagHasCountryCode)
            ++result;
        if (flagHasDataSourceName)
            ++result;
        if (flagHasStockListings)
            ++result;
        result += extraCustomStockEntityDataComponentCount();
        return result;
      }
    public override string extraStockEntityDataComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasListingRequestType)
          {
            if (remainder == 0)
                return "ListingRequestType";
            --remainder;
          }
        if (flagHasShortSpokenName)
          {
            if (remainder == 0)
                return "ShortSpokenName";
            --remainder;
          }
        if (flagHasPossessiveShortSpokenName)
          {
            if (remainder == 0)
                return "PossessiveShortSpokenName";
            --remainder;
          }
        if (flagHasLongSpokenName)
          {
            if (remainder == 0)
                return "LongSpokenName";
            --remainder;
          }
        if (flagHasShortDisplayName)
          {
            if (remainder == 0)
                return "ShortDisplayName";
            --remainder;
          }
        if (flagHasPossessiveShortDisplayName)
          {
            if (remainder == 0)
                return "PossessiveShortDisplayName";
            --remainder;
          }
        if (flagHasMediumDisplayName)
          {
            if (remainder == 0)
                return "MediumDisplayName";
            --remainder;
          }
        if (flagHasLongDisplayName)
          {
            if (remainder == 0)
                return "LongDisplayName";
            --remainder;
          }
        if (flagHasCountryCode)
          {
            if (remainder == 0)
                return "CountryCode";
            --remainder;
          }
        if (flagHasDataSourceName)
          {
            if (remainder == 0)
                return "DataSourceName";
            --remainder;
          }
        if (flagHasStockListings)
          {
            if (remainder == 0)
                return "StockListings";
            --remainder;
          }
        return extraCustomStockEntityDataComponentKey(remainder);
      }
    public override JSONValue extraStockEntityDataComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasListingRequestType)
          {
            if (remainder == 0)
                return extraListingRequestTypeToJSON();
            --remainder;
          }
        if (flagHasShortSpokenName)
          {
            if (remainder == 0)
                return extraShortSpokenNameToJSON();
            --remainder;
          }
        if (flagHasPossessiveShortSpokenName)
          {
            if (remainder == 0)
                return extraPossessiveShortSpokenNameToJSON();
            --remainder;
          }
        if (flagHasLongSpokenName)
          {
            if (remainder == 0)
                return extraLongSpokenNameToJSON();
            --remainder;
          }
        if (flagHasShortDisplayName)
          {
            if (remainder == 0)
                return extraShortDisplayNameToJSON();
            --remainder;
          }
        if (flagHasPossessiveShortDisplayName)
          {
            if (remainder == 0)
                return extraPossessiveShortDisplayNameToJSON();
            --remainder;
          }
        if (flagHasMediumDisplayName)
          {
            if (remainder == 0)
                return extraMediumDisplayNameToJSON();
            --remainder;
          }
        if (flagHasLongDisplayName)
          {
            if (remainder == 0)
                return extraLongDisplayNameToJSON();
            --remainder;
          }
        if (flagHasCountryCode)
          {
            if (remainder == 0)
                return extraCountryCodeToJSON();
            --remainder;
          }
        if (flagHasDataSourceName)
          {
            if (remainder == 0)
                return extraDataSourceNameToJSON();
            --remainder;
          }
        if (flagHasStockListings)
          {
            if (remainder == 0)
                return extraStockListingsToJSON();
            --remainder;
          }
        return extraCustomStockEntityDataComponentValue(remainder);
      }
    public override JSONValue extraStockEntityDataLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ountryCode", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasCountryCode ? extraCountryCodeToJSON() : null);
                break;
            case 'D':
                if ((String.Compare(field_name, 1, "ataSourceName", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasDataSourceName ? extraDataSourceNameToJSON() : null);
                break;
            case 'L':
                switch (field_name[1])
                  {
                    case 'i':
                        if ((String.Compare(field_name, 2, "stingRequestType", 0, 16, false) == 0) && (field_name.Length == 18))
                            return (flagHasListingRequestType ? extraListingRequestTypeToJSON() : null);
                        break;
                    case 'o':
                        if (String.Compare(field_name, 2, "ng", 0, 2, false) == 0)
                          {
                            switch (field_name[4])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 5, "isplayName", 0, 10, false) == 0) && (field_name.Length == 15))
                                        return (flagHasLongDisplayName ? extraLongDisplayNameToJSON() : null);
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 5, "pokenName", 0, 9, false) == 0) && (field_name.Length == 14))
                                        return (flagHasLongSpokenName ? extraLongSpokenNameToJSON() : null);
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
            case 'M':
                if ((String.Compare(field_name, 1, "ediumDisplayName", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasMediumDisplayName ? extraMediumDisplayNameToJSON() : null);
                break;
            case 'P':
                if (String.Compare(field_name, 1, "ossessiveShort", 0, 14, false) == 0)
                  {
                    switch (field_name[15])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 16, "isplayName", 0, 10, false) == 0) && (field_name.Length == 26))
                                return (flagHasPossessiveShortDisplayName ? extraPossessiveShortDisplayNameToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 16, "pokenName", 0, 9, false) == 0) && (field_name.Length == 25))
                                return (flagHasPossessiveShortSpokenName ? extraPossessiveShortSpokenNameToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (field_name[1])
                  {
                    case 'h':
                        if (String.Compare(field_name, 2, "ort", 0, 3, false) == 0)
                          {
                            switch (field_name[5])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 6, "isplayName", 0, 10, false) == 0) && (field_name.Length == 16))
                                        return (flagHasShortDisplayName ? extraShortDisplayNameToJSON() : null);
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 6, "pokenName", 0, 9, false) == 0) && (field_name.Length == 15))
                                        return (flagHasShortSpokenName ? extraShortSpokenNameToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        if ((String.Compare(field_name, 2, "ockListings", 0, 11, false) == 0) && (field_name.Length == 13))
                            return (flagHasStockListings ? extraStockListingsToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return extraCustomStockEntityDataLookup(field_name);
      }

    public void setListingRequestType(StockListingRequestTypeJSON  new_value)
      {
        if (flagHasListingRequestType)
          {
          }
        flagHasListingRequestType = true;
        storeListingRequestType = new_value;
      }
    public void setListingRequestType(StockListingRequestTypeJSON.TypeValue new_value)
      {
        setListingRequestType(new StockListingRequestTypeJSON(new_value));
      }
    public void setListingRequestType(string chars)
      {
        StockListingRequestTypeJSON.TypeValueKnownValues known = StockListingRequestTypeJSON.stringToValue(chars);
        StockListingRequestTypeJSON.TypeValue new_value = new StockListingRequestTypeJSON.TypeValue();
        if (known == StockListingRequestTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setListingRequestType(new_value);
      }
    public void unsetListingRequestType()
      {
        if (flagHasListingRequestType)
          {
          }
        flagHasListingRequestType = false;
      }
    public void setShortSpokenName(string new_value)
      {
        flagHasShortSpokenName = true;
        storeShortSpokenName = new_value;
      }
    public void unsetShortSpokenName()
      {
        flagHasShortSpokenName = false;
      }
    public void setPossessiveShortSpokenName(string new_value)
      {
        flagHasPossessiveShortSpokenName = true;
        storePossessiveShortSpokenName = new_value;
      }
    public void unsetPossessiveShortSpokenName()
      {
        flagHasPossessiveShortSpokenName = false;
      }
    public void setLongSpokenName(string new_value)
      {
        flagHasLongSpokenName = true;
        storeLongSpokenName = new_value;
      }
    public void unsetLongSpokenName()
      {
        flagHasLongSpokenName = false;
      }
    public void setShortDisplayName(string new_value)
      {
        flagHasShortDisplayName = true;
        storeShortDisplayName = new_value;
      }
    public void unsetShortDisplayName()
      {
        flagHasShortDisplayName = false;
      }
    public void setPossessiveShortDisplayName(string new_value)
      {
        flagHasPossessiveShortDisplayName = true;
        storePossessiveShortDisplayName = new_value;
      }
    public void unsetPossessiveShortDisplayName()
      {
        flagHasPossessiveShortDisplayName = false;
      }
    public void setMediumDisplayName(string new_value)
      {
        flagHasMediumDisplayName = true;
        storeMediumDisplayName = new_value;
      }
    public void unsetMediumDisplayName()
      {
        flagHasMediumDisplayName = false;
      }
    public void setLongDisplayName(string new_value)
      {
        flagHasLongDisplayName = true;
        storeLongDisplayName = new_value;
      }
    public void unsetLongDisplayName()
      {
        flagHasLongDisplayName = false;
      }
    public void setCountryCode(string new_value)
      {
        flagHasCountryCode = true;
        storeCountryCode = new_value;
      }
    public void unsetCountryCode()
      {
        flagHasCountryCode = false;
      }
    public void setDataSourceName(string new_value)
      {
        flagHasDataSourceName = true;
        storeDataSourceName = new_value;
      }
    public void unsetDataSourceName()
      {
        flagHasDataSourceName = false;
      }
    public void initStockListings()
      {
        if (flagHasStockListings)
          {
            for (int num1 = 0; num1 < storeStockListings.Count; ++num1)
              {
              }
          }
        flagHasStockListings = true;
        storeStockListings.Clear();
      }
    public void appendStockListings(StockListingDataJSON  to_append)
      {
        if (!flagHasStockListings)
          {
            flagHasStockListings = true;
            storeStockListings.Clear();
          }
        Debug.Assert(flagHasStockListings);
        storeStockListings.Add(to_append);
      }
    public void unsetStockListings()
      {
        if (flagHasStockListings)
          {
            for (int num2 = 0; num2 < storeStockListings.Count; ++num2)
              {
              }
          }
        flagHasStockListings = false;
        storeStockListings.Clear();
      }

    public virtual void extraCustomStockEntityDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCustomStockEntityDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCustomStockEntityDataLookup(key);
        if (old_field == null)
          {
            extraCustomStockEntityDataAppendPair(key, new_component);
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
    public override void extraStockEntityDataAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ountryCode", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCountryCode(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "ataSourceName", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONDataSourceName(new_component, false);
                    return;
                    }
                break;
            case 'L':
                switch (key[1])
                  {
                    case 'i':
                        if ((String.Compare(key, 2, "stingRequestType", 0, 16, false) == 0) && (key.Length == 18))
                            {
                            fromJSONListingRequestType(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if (String.Compare(key, 2, "ng", 0, 2, false) == 0)
                          {
                            switch (key[4])
                              {
                                case 'D':
                                    if ((String.Compare(key, 5, "isplayName", 0, 10, false) == 0) && (key.Length == 15))
                                        {
                                        fromJSONLongDisplayName(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 5, "pokenName", 0, 9, false) == 0) && (key.Length == 14))
                                        {
                                        fromJSONLongSpokenName(new_component, false);
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
                break;
            case 'M':
                if ((String.Compare(key, 1, "ediumDisplayName", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONMediumDisplayName(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if (String.Compare(key, 1, "ossessiveShort", 0, 14, false) == 0)
                  {
                    switch (key[15])
                      {
                        case 'D':
                            if ((String.Compare(key, 16, "isplayName", 0, 10, false) == 0) && (key.Length == 26))
                                {
                                fromJSONPossessiveShortDisplayName(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 16, "pokenName", 0, 9, false) == 0) && (key.Length == 25))
                                {
                                fromJSONPossessiveShortSpokenName(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'h':
                        if (String.Compare(key, 2, "ort", 0, 3, false) == 0)
                          {
                            switch (key[5])
                              {
                                case 'D':
                                    if ((String.Compare(key, 6, "isplayName", 0, 10, false) == 0) && (key.Length == 16))
                                        {
                                        fromJSONShortDisplayName(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 6, "pokenName", 0, 9, false) == 0) && (key.Length == 15))
                                        {
                                        fromJSONShortSpokenName(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "ockListings", 0, 11, false) == 0) && (key.Length == 13))
                            {
                            fromJSONStockListings(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraCustomStockEntityDataAppendPair(key, new_component);
      }
    public override void extraStockEntityDataSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ountryCode", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCountryCode(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "ataSourceName", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONDataSourceName(new_component, false);
                    return;
                    }
                break;
            case 'L':
                switch (key[1])
                  {
                    case 'i':
                        if ((String.Compare(key, 2, "stingRequestType", 0, 16, false) == 0) && (key.Length == 18))
                            {
                            fromJSONListingRequestType(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if (String.Compare(key, 2, "ng", 0, 2, false) == 0)
                          {
                            switch (key[4])
                              {
                                case 'D':
                                    if ((String.Compare(key, 5, "isplayName", 0, 10, false) == 0) && (key.Length == 15))
                                        {
                                        fromJSONLongDisplayName(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 5, "pokenName", 0, 9, false) == 0) && (key.Length == 14))
                                        {
                                        fromJSONLongSpokenName(new_component, false);
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
                break;
            case 'M':
                if ((String.Compare(key, 1, "ediumDisplayName", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONMediumDisplayName(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if (String.Compare(key, 1, "ossessiveShort", 0, 14, false) == 0)
                  {
                    switch (key[15])
                      {
                        case 'D':
                            if ((String.Compare(key, 16, "isplayName", 0, 10, false) == 0) && (key.Length == 26))
                                {
                                fromJSONPossessiveShortDisplayName(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 16, "pokenName", 0, 9, false) == 0) && (key.Length == 25))
                                {
                                fromJSONPossessiveShortSpokenName(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'h':
                        if (String.Compare(key, 2, "ort", 0, 3, false) == 0)
                          {
                            switch (key[5])
                              {
                                case 'D':
                                    if ((String.Compare(key, 6, "isplayName", 0, 10, false) == 0) && (key.Length == 16))
                                        {
                                        fromJSONShortDisplayName(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'S':
                                    if ((String.Compare(key, 6, "pokenName", 0, 9, false) == 0) && (key.Length == 15))
                                        {
                                        fromJSONShortSpokenName(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "ockListings", 0, 11, false) == 0) && (key.Length == 13))
                            {
                            fromJSONStockListings(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraCustomStockEntityDataSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasListingRequestType);
        if (flagHasListingRequestType)
          {
            handler.start_pair("ListingRequestType");
            if (partial_allowed)
                storeListingRequestType.write_partial_as_json(handler);
            else
                storeListingRequestType.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasShortSpokenName);
        if (flagHasShortSpokenName)
          {
            handler.start_pair("ShortSpokenName");
            handler.string_value(storeShortSpokenName);
          }
        Debug.Assert(partial_allowed || flagHasPossessiveShortSpokenName);
        if (flagHasPossessiveShortSpokenName)
          {
            handler.start_pair("PossessiveShortSpokenName");
            handler.string_value(storePossessiveShortSpokenName);
          }
        Debug.Assert(partial_allowed || flagHasLongSpokenName);
        if (flagHasLongSpokenName)
          {
            handler.start_pair("LongSpokenName");
            handler.string_value(storeLongSpokenName);
          }
        Debug.Assert(partial_allowed || flagHasShortDisplayName);
        if (flagHasShortDisplayName)
          {
            handler.start_pair("ShortDisplayName");
            handler.string_value(storeShortDisplayName);
          }
        Debug.Assert(partial_allowed || flagHasPossessiveShortDisplayName);
        if (flagHasPossessiveShortDisplayName)
          {
            handler.start_pair("PossessiveShortDisplayName");
            handler.string_value(storePossessiveShortDisplayName);
          }
        Debug.Assert(partial_allowed || flagHasMediumDisplayName);
        if (flagHasMediumDisplayName)
          {
            handler.start_pair("MediumDisplayName");
            handler.string_value(storeMediumDisplayName);
          }
        Debug.Assert(partial_allowed || flagHasLongDisplayName);
        if (flagHasLongDisplayName)
          {
            handler.start_pair("LongDisplayName");
            handler.string_value(storeLongDisplayName);
          }
        Debug.Assert(partial_allowed || flagHasCountryCode);
        if (flagHasCountryCode)
          {
            handler.start_pair("CountryCode");
            handler.string_value(storeCountryCode);
          }
        Debug.Assert(partial_allowed || flagHasDataSourceName);
        if (flagHasDataSourceName)
          {
            handler.start_pair("DataSourceName");
            handler.string_value(storeDataSourceName);
          }
        Debug.Assert(partial_allowed || flagHasStockListings);
        if (flagHasStockListings)
          {
            handler.start_pair("StockListings");
            handler.start_array();
            for (int num1 = 0; num1 < storeStockListings.Count; ++num1)
              {
                if (partial_allowed)
                    storeStockListings[num1].write_partial_as_json(handler);
                else
                    storeStockListings[num1].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasListingRequestType()))
          {
            return "When parsing the object for %what%, the \"ListingRequestType\" field was missing.";
          }
        if (!(hasShortSpokenName()))
          {
            return "When parsing the object for %what%, the \"ShortSpokenName\" field was missing.";
          }
        if (!(hasPossessiveShortSpokenName()))
          {
            return "When parsing the object for %what%, the \"PossessiveShortSpokenName\" field was missing.";
          }
        if (!(hasLongSpokenName()))
          {
            return "When parsing the object for %what%, the \"LongSpokenName\" field was missing.";
          }
        if (!(hasShortDisplayName()))
          {
            return "When parsing the object for %what%, the \"ShortDisplayName\" field was missing.";
          }
        if (!(hasPossessiveShortDisplayName()))
          {
            return "When parsing the object for %what%, the \"PossessiveShortDisplayName\" field was missing.";
          }
        if (!(hasMediumDisplayName()))
          {
            return "When parsing the object for %what%, the \"MediumDisplayName\" field was missing.";
          }
        if (!(hasLongDisplayName()))
          {
            return "When parsing the object for %what%, the \"LongDisplayName\" field was missing.";
          }
        if (!(hasCountryCode()))
          {
            return "When parsing the object for %what%, the \"CountryCode\" field was missing.";
          }
        if (!(hasDataSourceName()))
          {
            return "When parsing the object for %what%, the \"DataSourceName\" field was missing.";
          }
        if (!(hasStockListings()))
          {
            return "When parsing the object for %what%, the \"StockListings\" field was missing.";
          }
        return null;
      }

    public static new CustomStockEntityDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CustomStockEntityDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomStockEntityData", ignore_extras);
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
    public static new CustomStockEntityDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CustomStockEntityDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CustomStockEntityDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomStockEntityData", ignore_extras);
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
    public static new CustomStockEntityDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CustomStockEntityDataJSON from_text(string text, bool ignore_extras)
      {
        CustomStockEntityDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomStockEntityData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CustomStockEntityDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CustomStockEntityDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CustomStockEntityDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomStockEntityData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : StockEntityDataJSON.Generator
      {
        private StockListingRequestTypeJSON.HoldingGenerator fieldGeneratorListingRequestType;
        private JSONHoldingStringGenerator fieldGeneratorShortSpokenName;
        private JSONHoldingStringGenerator fieldGeneratorPossessiveShortSpokenName;
        private JSONHoldingStringGenerator fieldGeneratorLongSpokenName;
        private JSONHoldingStringGenerator fieldGeneratorShortDisplayName;
        private JSONHoldingStringGenerator fieldGeneratorPossessiveShortDisplayName;
        private JSONHoldingStringGenerator fieldGeneratorMediumDisplayName;
        private JSONHoldingStringGenerator fieldGeneratorLongDisplayName;
        private JSONHoldingStringGenerator fieldGeneratorCountryCode;
        private JSONHoldingStringGenerator fieldGeneratorDataSourceName;
        private StockListingDataJSON.HoldingArrayGenerator fieldGeneratorStockListings;
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
            if (!(getStockEntityDataJSONKey().Equals("CustomStockEntityData")))
                throw new Exception("The key field has a value other than `CustomStockEntityData'.");
            CustomStockEntityDataJSON result = new CustomStockEntityDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCustomStockEntityDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(StockEntityDataJSON new_result)
          {
            handle_result((CustomStockEntityDataJSON )new_result);
          }
        protected void finish(CustomStockEntityDataJSON result)
          {
            if (fieldGeneratorListingRequestType.have_value)
              {
                result.setListingRequestType(fieldGeneratorListingRequestType.value);
                fieldGeneratorListingRequestType.have_value = false;
              }
            else if ((!(result.hasListingRequestType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ListingRequestType\" field was missing.");
              }
            if (fieldGeneratorShortSpokenName.have_value)
              {
                result.setShortSpokenName(fieldGeneratorShortSpokenName.value);
                fieldGeneratorShortSpokenName.have_value = false;
              }
            else if ((!(result.hasShortSpokenName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ShortSpokenName\" field was missing.");
              }
            if (fieldGeneratorPossessiveShortSpokenName.have_value)
              {
                result.setPossessiveShortSpokenName(fieldGeneratorPossessiveShortSpokenName.value);
                fieldGeneratorPossessiveShortSpokenName.have_value = false;
              }
            else if ((!(result.hasPossessiveShortSpokenName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PossessiveShortSpokenName\" field was missing.");
              }
            if (fieldGeneratorLongSpokenName.have_value)
              {
                result.setLongSpokenName(fieldGeneratorLongSpokenName.value);
                fieldGeneratorLongSpokenName.have_value = false;
              }
            else if ((!(result.hasLongSpokenName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LongSpokenName\" field was missing.");
              }
            if (fieldGeneratorShortDisplayName.have_value)
              {
                result.setShortDisplayName(fieldGeneratorShortDisplayName.value);
                fieldGeneratorShortDisplayName.have_value = false;
              }
            else if ((!(result.hasShortDisplayName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ShortDisplayName\" field was missing.");
              }
            if (fieldGeneratorPossessiveShortDisplayName.have_value)
              {
                result.setPossessiveShortDisplayName(fieldGeneratorPossessiveShortDisplayName.value);
                fieldGeneratorPossessiveShortDisplayName.have_value = false;
              }
            else if ((!(result.hasPossessiveShortDisplayName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PossessiveShortDisplayName\" field was missing.");
              }
            if (fieldGeneratorMediumDisplayName.have_value)
              {
                result.setMediumDisplayName(fieldGeneratorMediumDisplayName.value);
                fieldGeneratorMediumDisplayName.have_value = false;
              }
            else if ((!(result.hasMediumDisplayName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MediumDisplayName\" field was missing.");
              }
            if (fieldGeneratorLongDisplayName.have_value)
              {
                result.setLongDisplayName(fieldGeneratorLongDisplayName.value);
                fieldGeneratorLongDisplayName.have_value = false;
              }
            else if ((!(result.hasLongDisplayName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LongDisplayName\" field was missing.");
              }
            if (fieldGeneratorCountryCode.have_value)
              {
                result.setCountryCode(fieldGeneratorCountryCode.value);
                fieldGeneratorCountryCode.have_value = false;
              }
            else if ((!(result.hasCountryCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CountryCode\" field was missing.");
              }
            if (fieldGeneratorDataSourceName.have_value)
              {
                result.setDataSourceName(fieldGeneratorDataSourceName.value);
                fieldGeneratorDataSourceName.have_value = false;
              }
            else if ((!(result.hasDataSourceName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DataSourceName\" field was missing.");
              }
            if (fieldGeneratorStockListings.have_value)
              {
                result.initStockListings();
                int count = fieldGeneratorStockListings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStockListings(fieldGeneratorStockListings.value[num]);
                  }
                fieldGeneratorStockListings.value.Clear();
                fieldGeneratorStockListings.have_value = false;
              }
            else if ((!(result.hasStockListings())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StockListings\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(CustomStockEntityDataJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ountryCode", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCountryCode;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ataSourceName", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorDataSourceName;
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "stingRequestType", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorListingRequestType;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "ng", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 5, "isplayName", 0, 10, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorLongDisplayName;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 5, "pokenName", 0, 9, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorLongSpokenName;
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
                case 'M':
                    if ((String.Compare(field_name, 1, "ediumDisplayName", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorMediumDisplayName;
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "ossessiveShort", 0, 14, false) == 0)
                      {
                        switch (field_name[15])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 16, "isplayName", 0, 10, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorPossessiveShortDisplayName;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 16, "pokenName", 0, 9, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorPossessiveShortSpokenName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'h':
                            if (String.Compare(field_name, 2, "ort", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 6, "isplayName", 0, 10, false) == 0) && (field_name.Length == 16))
                                            return fieldGeneratorShortDisplayName;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 6, "pokenName", 0, 9, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorShortSpokenName;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "ockListings", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorStockListings;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorListingRequestType = new StockListingRequestTypeJSON.HoldingGenerator("field \"ListingRequestType\" of the CustomStockEntityData class", ignore_extras);
            fieldGeneratorShortSpokenName = new JSONHoldingStringGenerator("field \"ShortSpokenName\" of the CustomStockEntityData class");
            fieldGeneratorPossessiveShortSpokenName = new JSONHoldingStringGenerator("field \"PossessiveShortSpokenName\" of the CustomStockEntityData class");
            fieldGeneratorLongSpokenName = new JSONHoldingStringGenerator("field \"LongSpokenName\" of the CustomStockEntityData class");
            fieldGeneratorShortDisplayName = new JSONHoldingStringGenerator("field \"ShortDisplayName\" of the CustomStockEntityData class");
            fieldGeneratorPossessiveShortDisplayName = new JSONHoldingStringGenerator("field \"PossessiveShortDisplayName\" of the CustomStockEntityData class");
            fieldGeneratorMediumDisplayName = new JSONHoldingStringGenerator("field \"MediumDisplayName\" of the CustomStockEntityData class");
            fieldGeneratorLongDisplayName = new JSONHoldingStringGenerator("field \"LongDisplayName\" of the CustomStockEntityData class");
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the CustomStockEntityData class");
            fieldGeneratorDataSourceName = new JSONHoldingStringGenerator("field \"DataSourceName\" of the CustomStockEntityData class");
            fieldGeneratorStockListings = new StockListingDataJSON.HoldingArrayGenerator("field \"StockListings\" of the CustomStockEntityData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CustomStockEntityData class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorListingRequestType = new StockListingRequestTypeJSON.HoldingGenerator("field \"ListingRequestType\" of the CustomStockEntityData class", false);
            fieldGeneratorShortSpokenName = new JSONHoldingStringGenerator("field \"ShortSpokenName\" of the CustomStockEntityData class");
            fieldGeneratorPossessiveShortSpokenName = new JSONHoldingStringGenerator("field \"PossessiveShortSpokenName\" of the CustomStockEntityData class");
            fieldGeneratorLongSpokenName = new JSONHoldingStringGenerator("field \"LongSpokenName\" of the CustomStockEntityData class");
            fieldGeneratorShortDisplayName = new JSONHoldingStringGenerator("field \"ShortDisplayName\" of the CustomStockEntityData class");
            fieldGeneratorPossessiveShortDisplayName = new JSONHoldingStringGenerator("field \"PossessiveShortDisplayName\" of the CustomStockEntityData class");
            fieldGeneratorMediumDisplayName = new JSONHoldingStringGenerator("field \"MediumDisplayName\" of the CustomStockEntityData class");
            fieldGeneratorLongDisplayName = new JSONHoldingStringGenerator("field \"LongDisplayName\" of the CustomStockEntityData class");
            fieldGeneratorCountryCode = new JSONHoldingStringGenerator("field \"CountryCode\" of the CustomStockEntityData class");
            fieldGeneratorDataSourceName = new JSONHoldingStringGenerator("field \"DataSourceName\" of the CustomStockEntityData class");
            fieldGeneratorStockListings = new StockListingDataJSON.HoldingArrayGenerator("field \"StockListings\" of the CustomStockEntityData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CustomStockEntityData class");
          }

        public override void reset()
          {
            fieldGeneratorListingRequestType.reset();
            fieldGeneratorShortSpokenName.reset();
            fieldGeneratorPossessiveShortSpokenName.reset();
            fieldGeneratorLongSpokenName.reset();
            fieldGeneratorShortDisplayName.reset();
            fieldGeneratorPossessiveShortDisplayName.reset();
            fieldGeneratorMediumDisplayName.reset();
            fieldGeneratorLongDisplayName.reset();
            fieldGeneratorCountryCode.reset();
            fieldGeneratorDataSourceName.reset();
            fieldGeneratorStockListings.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CustomStockEntityDataJSON  result)
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
        public CustomStockEntityDataJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CustomStockEntityDataJSON  result)
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
    protected virtual void handle_result(List<CustomStockEntityDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CustomStockEntityDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CustomStockEntityDataJSON>();
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
    public List<CustomStockEntityDataJSON> value;
  };
  };
