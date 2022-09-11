/* file "StationShowIHeartRadioInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class StationShowIHeartRadioInformationNuggetJSON : IHeartRadioInformationNuggetJSON
  {
    private bool flagHasStations;
    private List< RadioStationJSON  > storeStations;
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private bool flagHasUserRequestedLocationRetrievalSuccess;
    private bool storeUserRequestedLocationRetrievalSuccess;
    private bool flagHasSpokenStationIndices;
    private List< BigInteger > storeSpokenStationIndices;
    private bool flagHasUserRequestedSpokenStationIndices;
    private bool storeUserRequestedSpokenStationIndices;
    private bool flagHasUserRequestedQueryInfo;
    private IHeartRadioQueryInfoJSON  storeUserRequestedQueryInfo;
    private bool flagHasIHeartRadioUserIdentificationData;
    private IHeartMediaUserIdentificationDataJSON  storeIHeartRadioUserIdentificationData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraStationsToJSON()
      {
        JSONArrayValue generated_array_1_Stations = new JSONArrayValue();
        for (int num1 = 0; num1 < storeStations.Count; ++num1)
          {
            JSONValueHandler handler_Stations = new JSONValueHandler();
            storeStations[num1].write_as_json(handler_Stations);
            generated_array_1_Stations.appendComponent(handler_Stations.result);
          }
        return generated_array_1_Stations;
      }

    private JSONValue  extraAttributionToJSON()
      {
        JSONValueHandler handler_Attribution = new JSONValueHandler();
        storeAttribution.write_as_json(handler_Attribution);
        return handler_Attribution.result;
      }

    private JSONValue  extraUserRequestedLocationRetrievalSuccessToJSON()
      {
        JSONValue generated_boolean_UserRequestedLocationRetrievalSuccess = (storeUserRequestedLocationRetrievalSuccess ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_UserRequestedLocationRetrievalSuccess;
      }

    private JSONValue  extraSpokenStationIndicesToJSON()
      {
        JSONArrayValue generated_array_2_SpokenStationIndices = new JSONArrayValue();
        for (int num2 = 0; num2 < storeSpokenStationIndices.Count; ++num2)
          {
            JSONIntegerValue generated_integer_SpokenStationIndices = new JSONIntegerValue(storeSpokenStationIndices[num2]);
            generated_array_2_SpokenStationIndices.appendComponent(generated_integer_SpokenStationIndices);
          }
        return generated_array_2_SpokenStationIndices;
      }

    private JSONValue  extraUserRequestedSpokenStationIndicesToJSON()
      {
        JSONValue generated_boolean_UserRequestedSpokenStationIndices = (storeUserRequestedSpokenStationIndices ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_UserRequestedSpokenStationIndices;
      }

    private JSONValue  extraUserRequestedQueryInfoToJSON()
      {
        JSONValueHandler handler_UserRequestedQueryInfo = new JSONValueHandler();
        storeUserRequestedQueryInfo.write_as_json(handler_UserRequestedQueryInfo);
        return handler_UserRequestedQueryInfo.result;
      }

    private JSONValue  extraIHeartRadioUserIdentificationDataToJSON()
      {
        JSONValueHandler handler_IHeartRadioUserIdentificationData = new JSONValueHandler();
        storeIHeartRadioUserIdentificationData.write_as_json(handler_IHeartRadioUserIdentificationData);
        return handler_IHeartRadioUserIdentificationData.result;
      }


    private void  fromJSONStations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Stations of StationShowIHeartRadioInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RadioStationJSON  > vector_Stations1 = new List< RadioStationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RadioStationJSON convert_classy = RadioStationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Stations1.Add(convert_classy);
          }
        initStations();
        for (int num1 = 0; num1 < vector_Stations1.Count; ++num1)
            appendStations(vector_Stations1[num1]);
        for (int num1 = 0; num1 < vector_Stations1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AttributionJSON convert_classy = AttributionJSON.from_json(json_value, ignore_extras, true);
        setAttribution(convert_classy);
      }


    private void  fromJSONUserRequestedLocationRetrievalSuccess(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedLocationRetrievalSuccess of StationShowIHeartRadioInformationNuggetJSON is not true for false.");
              }
          }
        setUserRequestedLocationRetrievalSuccess(the_bool);
      }


    private void  fromJSONSpokenStationIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SpokenStationIndices of StationShowIHeartRadioInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_SpokenStationIndices1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field SpokenStationIndices of StationShowIHeartRadioInformationNuggetJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field SpokenStationIndices of StationShowIHeartRadioInformationNuggetJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_SpokenStationIndices1.Add(extracted_integer);
          }
        initSpokenStationIndices();
        for (int num2 = 0; num2 < vector_SpokenStationIndices1.Count; ++num2)
            appendSpokenStationIndices(vector_SpokenStationIndices1[num2]);
        for (int num1 = 0; num1 < vector_SpokenStationIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONUserRequestedSpokenStationIndices(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserRequestedSpokenStationIndices of StationShowIHeartRadioInformationNuggetJSON is not true for false.");
              }
          }
        setUserRequestedSpokenStationIndices(the_bool);
      }


    private void  fromJSONUserRequestedQueryInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioQueryInfoJSON convert_classy = IHeartRadioQueryInfoJSON.from_json(json_value, ignore_extras, true);
        setUserRequestedQueryInfo(convert_classy);
      }


    private void  fromJSONIHeartRadioUserIdentificationData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartMediaUserIdentificationDataJSON convert_classy = IHeartMediaUserIdentificationDataJSON.from_json(json_value, ignore_extras, true);
        setIHeartRadioUserIdentificationData(convert_classy);
      }


    public StationShowIHeartRadioInformationNuggetJSON()
      {
        flagHasStations = false;
        flagHasAttribution = false;
        flagHasUserRequestedLocationRetrievalSuccess = false;
        flagHasSpokenStationIndices = false;
        flagHasUserRequestedSpokenStationIndices = false;
        flagHasUserRequestedQueryInfo = false;
        flagHasIHeartRadioUserIdentificationData = false;
        storeStations = new List< RadioStationJSON  >();
        storeSpokenStationIndices = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getIHeartRadioInformationNuggetKind()
      {
        return "StationShowIHeartRadioInformationNugget";
      }

    public bool  hasStations()
      {
        return flagHasStations;
      }

    public int  countOfStations()
      {
        Debug.Assert(flagHasStations);
        return storeStations.Count;
      }

    public RadioStationJSON   elementOfStations(int element_num)
      {
        Debug.Assert(flagHasStations);
        return storeStations[element_num];
      }

    public List< RadioStationJSON  >  getStations()
      {
        Debug.Assert(flagHasStations);
        return storeStations;
      }

    public bool  hasAttribution()
      {
        return flagHasAttribution;
      }

    public AttributionJSON   getAttribution()
      {
        Debug.Assert(flagHasAttribution);
        return storeAttribution;
      }

    public bool  hasUserRequestedLocationRetrievalSuccess()
      {
        return flagHasUserRequestedLocationRetrievalSuccess;
      }

    public bool  getUserRequestedLocationRetrievalSuccess()
      {
        Debug.Assert(flagHasUserRequestedLocationRetrievalSuccess);
        return storeUserRequestedLocationRetrievalSuccess;
      }

    public bool  hasSpokenStationIndices()
      {
        return flagHasSpokenStationIndices;
      }

    public int  countOfSpokenStationIndices()
      {
        Debug.Assert(flagHasSpokenStationIndices);
        return storeSpokenStationIndices.Count;
      }

    public BigInteger  elementOfSpokenStationIndices(int element_num)
      {
        Debug.Assert(flagHasSpokenStationIndices);
        return storeSpokenStationIndices[element_num];
      }

    public List< BigInteger >  getSpokenStationIndices()
      {
        Debug.Assert(flagHasSpokenStationIndices);
        return storeSpokenStationIndices;
      }

    public bool  hasUserRequestedSpokenStationIndices()
      {
        return flagHasUserRequestedSpokenStationIndices;
      }

    public bool  getUserRequestedSpokenStationIndices()
      {
        Debug.Assert(flagHasUserRequestedSpokenStationIndices);
        return storeUserRequestedSpokenStationIndices;
      }

    public bool  hasUserRequestedQueryInfo()
      {
        return flagHasUserRequestedQueryInfo;
      }

    public IHeartRadioQueryInfoJSON   getUserRequestedQueryInfo()
      {
        Debug.Assert(flagHasUserRequestedQueryInfo);
        return storeUserRequestedQueryInfo;
      }

    public bool  hasIHeartRadioUserIdentificationData()
      {
        return flagHasIHeartRadioUserIdentificationData;
      }

    public IHeartMediaUserIdentificationDataJSON   getIHeartRadioUserIdentificationData()
      {
        Debug.Assert(flagHasIHeartRadioUserIdentificationData);
        return storeIHeartRadioUserIdentificationData;
      }


    public virtual int extraStationShowIHeartRadioInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStationShowIHeartRadioInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStationShowIHeartRadioInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStationShowIHeartRadioInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraIHeartRadioInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasStations)
            ++result;
        if (flagHasAttribution)
            ++result;
        if (flagHasUserRequestedLocationRetrievalSuccess)
            ++result;
        if (flagHasSpokenStationIndices)
            ++result;
        if (flagHasUserRequestedSpokenStationIndices)
            ++result;
        if (flagHasUserRequestedQueryInfo)
            ++result;
        if (flagHasIHeartRadioUserIdentificationData)
            ++result;
        result += extraStationShowIHeartRadioInformationNuggetComponentCount();
        return result;
      }
    public override string extraIHeartRadioInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasStations)
          {
            if (remainder == 0)
                return "Stations";
            --remainder;
          }
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return "Attribution";
            --remainder;
          }
        if (flagHasUserRequestedLocationRetrievalSuccess)
          {
            if (remainder == 0)
                return "UserRequestedLocationRetrievalSuccess";
            --remainder;
          }
        if (flagHasSpokenStationIndices)
          {
            if (remainder == 0)
                return "SpokenStationIndices";
            --remainder;
          }
        if (flagHasUserRequestedSpokenStationIndices)
          {
            if (remainder == 0)
                return "UserRequestedSpokenStationIndices";
            --remainder;
          }
        if (flagHasUserRequestedQueryInfo)
          {
            if (remainder == 0)
                return "UserRequestedQueryInfo";
            --remainder;
          }
        if (flagHasIHeartRadioUserIdentificationData)
          {
            if (remainder == 0)
                return "IHeartRadioUserIdentificationData";
            --remainder;
          }
        return extraStationShowIHeartRadioInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraIHeartRadioInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasStations)
          {
            if (remainder == 0)
                return extraStationsToJSON();
            --remainder;
          }
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return extraAttributionToJSON();
            --remainder;
          }
        if (flagHasUserRequestedLocationRetrievalSuccess)
          {
            if (remainder == 0)
                return extraUserRequestedLocationRetrievalSuccessToJSON();
            --remainder;
          }
        if (flagHasSpokenStationIndices)
          {
            if (remainder == 0)
                return extraSpokenStationIndicesToJSON();
            --remainder;
          }
        if (flagHasUserRequestedSpokenStationIndices)
          {
            if (remainder == 0)
                return extraUserRequestedSpokenStationIndicesToJSON();
            --remainder;
          }
        if (flagHasUserRequestedQueryInfo)
          {
            if (remainder == 0)
                return extraUserRequestedQueryInfoToJSON();
            --remainder;
          }
        if (flagHasIHeartRadioUserIdentificationData)
          {
            if (remainder == 0)
                return extraIHeartRadioUserIdentificationDataToJSON();
            --remainder;
          }
        return extraStationShowIHeartRadioInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraIHeartRadioInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasAttribution ? extraAttributionToJSON() : null);
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "HeartRadioUserIdentificationData", 0, 32, false) == 0) && (field_name.Length == 33))
                    return (flagHasIHeartRadioUserIdentificationData ? extraIHeartRadioUserIdentificationDataToJSON() : null);
                break;
            case 'S':
                switch (field_name[1])
                  {
                    case 'p':
                        if ((String.Compare(field_name, 2, "okenStationIndices", 0, 18, false) == 0) && (field_name.Length == 20))
                            return (flagHasSpokenStationIndices ? extraSpokenStationIndicesToJSON() : null);
                        break;
                    case 't':
                        if ((String.Compare(field_name, 2, "ations", 0, 6, false) == 0) && (field_name.Length == 8))
                            return (flagHasStations ? extraStationsToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if (String.Compare(field_name, 1, "serRequested", 0, 12, false) == 0)
                  {
                    switch (field_name[13])
                      {
                        case 'L':
                            if ((String.Compare(field_name, 14, "ocationRetrievalSuccess", 0, 23, false) == 0) && (field_name.Length == 37))
                                return (flagHasUserRequestedLocationRetrievalSuccess ? extraUserRequestedLocationRetrievalSuccessToJSON() : null);
                            break;
                        case 'Q':
                            if ((String.Compare(field_name, 14, "ueryInfo", 0, 8, false) == 0) && (field_name.Length == 22))
                                return (flagHasUserRequestedQueryInfo ? extraUserRequestedQueryInfoToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 14, "pokenStationIndices", 0, 19, false) == 0) && (field_name.Length == 33))
                                return (flagHasUserRequestedSpokenStationIndices ? extraUserRequestedSpokenStationIndicesToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraStationShowIHeartRadioInformationNuggetLookup(field_name);
      }

    public void initStations()
      {
        if (flagHasStations)
          {
            for (int num1 = 0; num1 < storeStations.Count; ++num1)
              {
              }
          }
        flagHasStations = true;
        storeStations.Clear();
      }
    public void appendStations(RadioStationJSON  to_append)
      {
        if (!flagHasStations)
          {
            flagHasStations = true;
            storeStations.Clear();
          }
        Debug.Assert(flagHasStations);
        storeStations.Add(to_append);
      }
    public void unsetStations()
      {
        if (flagHasStations)
          {
            for (int num2 = 0; num2 < storeStations.Count; ++num2)
              {
              }
          }
        flagHasStations = false;
        storeStations.Clear();
      }
    public void setAttribution(AttributionJSON  new_value)
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = true;
        storeAttribution = new_value;
      }
    public void unsetAttribution()
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = false;
      }
    public void setUserRequestedLocationRetrievalSuccess(bool new_value)
      {
        flagHasUserRequestedLocationRetrievalSuccess = true;
        storeUserRequestedLocationRetrievalSuccess = new_value;
      }
    public void unsetUserRequestedLocationRetrievalSuccess()
      {
        flagHasUserRequestedLocationRetrievalSuccess = false;
      }
    public void initSpokenStationIndices()
      {
        flagHasSpokenStationIndices = true;
        storeSpokenStationIndices.Clear();
      }
    public void appendSpokenStationIndices(BigInteger to_append)
      {
        if (!flagHasSpokenStationIndices)
          {
            flagHasSpokenStationIndices = true;
            storeSpokenStationIndices.Clear();
          }
        Debug.Assert(flagHasSpokenStationIndices);
        storeSpokenStationIndices.Add(to_append);
      }
    public void unsetSpokenStationIndices()
      {
        flagHasSpokenStationIndices = false;
        storeSpokenStationIndices.Clear();
      }
    public void setUserRequestedSpokenStationIndices(bool new_value)
      {
        flagHasUserRequestedSpokenStationIndices = true;
        storeUserRequestedSpokenStationIndices = new_value;
      }
    public void unsetUserRequestedSpokenStationIndices()
      {
        flagHasUserRequestedSpokenStationIndices = false;
      }
    public void setUserRequestedQueryInfo(IHeartRadioQueryInfoJSON  new_value)
      {
        if (flagHasUserRequestedQueryInfo)
          {
          }
        flagHasUserRequestedQueryInfo = true;
        storeUserRequestedQueryInfo = new_value;
      }
    public void unsetUserRequestedQueryInfo()
      {
        if (flagHasUserRequestedQueryInfo)
          {
          }
        flagHasUserRequestedQueryInfo = false;
      }
    public void setIHeartRadioUserIdentificationData(IHeartMediaUserIdentificationDataJSON  new_value)
      {
        if (flagHasIHeartRadioUserIdentificationData)
          {
          }
        flagHasIHeartRadioUserIdentificationData = true;
        storeIHeartRadioUserIdentificationData = new_value;
      }
    public void unsetIHeartRadioUserIdentificationData()
      {
        if (flagHasIHeartRadioUserIdentificationData)
          {
          }
        flagHasIHeartRadioUserIdentificationData = false;
      }

    public virtual void extraStationShowIHeartRadioInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStationShowIHeartRadioInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStationShowIHeartRadioInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraStationShowIHeartRadioInformationNuggetAppendPair(key, new_component);
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
    public override void extraIHeartRadioInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribution", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAttribution(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "HeartRadioUserIdentificationData", 0, 32, false) == 0) && (key.Length == 33))
                    {
                    fromJSONIHeartRadioUserIdentificationData(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'p':
                        if ((String.Compare(key, 2, "okenStationIndices", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONSpokenStationIndices(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "ations", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONStations(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if (String.Compare(key, 1, "serRequested", 0, 12, false) == 0)
                  {
                    switch (key[13])
                      {
                        case 'L':
                            if ((String.Compare(key, 14, "ocationRetrievalSuccess", 0, 23, false) == 0) && (key.Length == 37))
                                {
                                fromJSONUserRequestedLocationRetrievalSuccess(new_component, false);
                                return;
                                }
                            break;
                        case 'Q':
                            if ((String.Compare(key, 14, "ueryInfo", 0, 8, false) == 0) && (key.Length == 22))
                                {
                                fromJSONUserRequestedQueryInfo(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 14, "pokenStationIndices", 0, 19, false) == 0) && (key.Length == 33))
                                {
                                fromJSONUserRequestedSpokenStationIndices(new_component, false);
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
        extraStationShowIHeartRadioInformationNuggetAppendPair(key, new_component);
      }
    public override void extraIHeartRadioInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ttribution", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAttribution(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "HeartRadioUserIdentificationData", 0, 32, false) == 0) && (key.Length == 33))
                    {
                    fromJSONIHeartRadioUserIdentificationData(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 'p':
                        if ((String.Compare(key, 2, "okenStationIndices", 0, 18, false) == 0) && (key.Length == 20))
                            {
                            fromJSONSpokenStationIndices(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "ations", 0, 6, false) == 0) && (key.Length == 8))
                            {
                            fromJSONStations(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if (String.Compare(key, 1, "serRequested", 0, 12, false) == 0)
                  {
                    switch (key[13])
                      {
                        case 'L':
                            if ((String.Compare(key, 14, "ocationRetrievalSuccess", 0, 23, false) == 0) && (key.Length == 37))
                                {
                                fromJSONUserRequestedLocationRetrievalSuccess(new_component, false);
                                return;
                                }
                            break;
                        case 'Q':
                            if ((String.Compare(key, 14, "ueryInfo", 0, 8, false) == 0) && (key.Length == 22))
                                {
                                fromJSONUserRequestedQueryInfo(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 14, "pokenStationIndices", 0, 19, false) == 0) && (key.Length == 33))
                                {
                                fromJSONUserRequestedSpokenStationIndices(new_component, false);
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
        extraStationShowIHeartRadioInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStations);
        if (flagHasStations)
          {
            handler.start_pair("Stations");
            handler.start_array();
            for (int num1 = 0; num1 < storeStations.Count; ++num1)
              {
                if (partial_allowed)
                    storeStations[num1].write_partial_as_json(handler);
                else
                    storeStations[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (partial_allowed)
                storeAttribution.write_partial_as_json(handler);
            else
                storeAttribution.write_as_json(handler);
          }
        if (flagHasUserRequestedLocationRetrievalSuccess)
          {
            handler.start_pair("UserRequestedLocationRetrievalSuccess");
            handler.boolean_value(storeUserRequestedLocationRetrievalSuccess);
          }
        Debug.Assert(partial_allowed || flagHasSpokenStationIndices);
        if (flagHasSpokenStationIndices)
          {
            handler.start_pair("SpokenStationIndices");
            handler.start_array();
            for (int num2 = 0; num2 < storeSpokenStationIndices.Count; ++num2)
              {
                handler.number_value(storeSpokenStationIndices[num2]);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasUserRequestedSpokenStationIndices);
        if (flagHasUserRequestedSpokenStationIndices)
          {
            handler.start_pair("UserRequestedSpokenStationIndices");
            handler.boolean_value(storeUserRequestedSpokenStationIndices);
          }
        if (flagHasUserRequestedQueryInfo)
          {
            handler.start_pair("UserRequestedQueryInfo");
            if (partial_allowed)
                storeUserRequestedQueryInfo.write_partial_as_json(handler);
            else
                storeUserRequestedQueryInfo.write_as_json(handler);
          }
        if (flagHasIHeartRadioUserIdentificationData)
          {
            handler.start_pair("IHeartRadioUserIdentificationData");
            if (partial_allowed)
                storeIHeartRadioUserIdentificationData.write_partial_as_json(handler);
            else
                storeIHeartRadioUserIdentificationData.write_as_json(handler);
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
        if (!(hasStations()))
          {
            return "When parsing the object for %what%, the \"Stations\" field was missing.";
          }
        if (!(hasSpokenStationIndices()))
          {
            return "When parsing the object for %what%, the \"SpokenStationIndices\" field was missing.";
          }
        if (!(hasUserRequestedSpokenStationIndices()))
          {
            return "When parsing the object for %what%, the \"UserRequestedSpokenStationIndices\" field was missing.";
          }
        return null;
      }

    public static new StationShowIHeartRadioInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StationShowIHeartRadioInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StationShowIHeartRadioInformationNugget", ignore_extras);
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
    public static new StationShowIHeartRadioInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StationShowIHeartRadioInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StationShowIHeartRadioInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StationShowIHeartRadioInformationNugget", ignore_extras);
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
    public static new StationShowIHeartRadioInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StationShowIHeartRadioInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        StationShowIHeartRadioInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StationShowIHeartRadioInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StationShowIHeartRadioInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new StationShowIHeartRadioInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StationShowIHeartRadioInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StationShowIHeartRadioInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : IHeartRadioInformationNuggetJSON.Generator
      {
        private RadioStationJSON.HoldingArrayGenerator fieldGeneratorStations;
        private AttributionJSON.HoldingGenerator fieldGeneratorAttribution;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedLocationRetrievalSuccess;
    private class FieldHoldingGeneratorSpokenStationIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSpokenStationIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSpokenStationIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSpokenStationIndices(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorSpokenStationIndices fieldGeneratorSpokenStationIndices;
        private JSONHoldingBooleanGenerator fieldGeneratorUserRequestedSpokenStationIndices;
        private IHeartRadioQueryInfoJSON.HoldingGenerator fieldGeneratorUserRequestedQueryInfo;
        private IHeartMediaUserIdentificationDataJSON.HoldingGenerator fieldGeneratorIHeartRadioUserIdentificationData;
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
            if (!(getIHeartRadioInformationNuggetJSONKey().Equals("StationShowIHeartRadioInformationNugget")))
                throw new Exception("The key field has a value other than `StationShowIHeartRadioInformationNugget'.");
            StationShowIHeartRadioInformationNuggetJSON result = new StationShowIHeartRadioInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStationShowIHeartRadioInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(IHeartRadioInformationNuggetJSON new_result)
          {
            handle_result((StationShowIHeartRadioInformationNuggetJSON )new_result);
          }
        protected void finish(StationShowIHeartRadioInformationNuggetJSON result)
          {
            if (fieldGeneratorStations.have_value)
              {
                result.initStations();
                int count = fieldGeneratorStations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStations(fieldGeneratorStations.value[num]);
                  }
                fieldGeneratorStations.value.Clear();
                fieldGeneratorStations.have_value = false;
              }
            else if ((!(result.hasStations())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Stations\" field was missing.");
              }
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
              }
            if (fieldGeneratorUserRequestedLocationRetrievalSuccess.have_value)
              {
                result.setUserRequestedLocationRetrievalSuccess(fieldGeneratorUserRequestedLocationRetrievalSuccess.value);
                fieldGeneratorUserRequestedLocationRetrievalSuccess.have_value = false;
              }
            if (fieldGeneratorSpokenStationIndices.have_value)
              {
                result.initSpokenStationIndices();
                int count = fieldGeneratorSpokenStationIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSpokenStationIndices(fieldGeneratorSpokenStationIndices.value[num]);
                  }
                fieldGeneratorSpokenStationIndices.value.Clear();
                fieldGeneratorSpokenStationIndices.have_value = false;
              }
            else if ((!(result.hasSpokenStationIndices())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SpokenStationIndices\" field was missing.");
              }
            if (fieldGeneratorUserRequestedSpokenStationIndices.have_value)
              {
                result.setUserRequestedSpokenStationIndices(fieldGeneratorUserRequestedSpokenStationIndices.value);
                fieldGeneratorUserRequestedSpokenStationIndices.have_value = false;
              }
            else if ((!(result.hasUserRequestedSpokenStationIndices())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UserRequestedSpokenStationIndices\" field was missing.");
              }
            if (fieldGeneratorUserRequestedQueryInfo.have_value)
              {
                result.setUserRequestedQueryInfo(fieldGeneratorUserRequestedQueryInfo.value);
                fieldGeneratorUserRequestedQueryInfo.have_value = false;
              }
            if (fieldGeneratorIHeartRadioUserIdentificationData.have_value)
              {
                result.setIHeartRadioUserIdentificationData(fieldGeneratorIHeartRadioUserIdentificationData.value);
                fieldGeneratorIHeartRadioUserIdentificationData.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(StationShowIHeartRadioInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ttribution", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAttribution;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "HeartRadioUserIdentificationData", 0, 32, false) == 0) && (field_name.Length == 33))
                        return fieldGeneratorIHeartRadioUserIdentificationData;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenStationIndices", 0, 18, false) == 0) && (field_name.Length == 20))
                                return fieldGeneratorSpokenStationIndices;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "ations", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorStations;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "serRequested", 0, 12, false) == 0)
                      {
                        switch (field_name[13])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 14, "ocationRetrievalSuccess", 0, 23, false) == 0) && (field_name.Length == 37))
                                    return fieldGeneratorUserRequestedLocationRetrievalSuccess;
                                break;
                            case 'Q':
                                if ((String.Compare(field_name, 14, "ueryInfo", 0, 8, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorUserRequestedQueryInfo;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 14, "pokenStationIndices", 0, 19, false) == 0) && (field_name.Length == 33))
                                    return fieldGeneratorUserRequestedSpokenStationIndices;
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
            fieldGeneratorStations = new RadioStationJSON.HoldingArrayGenerator("field \"Stations\" of the StationShowIHeartRadioInformationNugget class", ignore_extras);
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the StationShowIHeartRadioInformationNugget class", ignore_extras);
            fieldGeneratorUserRequestedLocationRetrievalSuccess = new JSONHoldingBooleanGenerator("field \"UserRequestedLocationRetrievalSuccess\" of the StationShowIHeartRadioInformationNugget class");
            fieldGeneratorSpokenStationIndices = new FieldHoldingArrayGeneratorSpokenStationIndices("field \"SpokenStationIndices\" of the StationShowIHeartRadioInformationNugget class");
            fieldGeneratorUserRequestedSpokenStationIndices = new JSONHoldingBooleanGenerator("field \"UserRequestedSpokenStationIndices\" of the StationShowIHeartRadioInformationNugget class");
            fieldGeneratorUserRequestedQueryInfo = new IHeartRadioQueryInfoJSON.HoldingGenerator("field \"UserRequestedQueryInfo\" of the StationShowIHeartRadioInformationNugget class", ignore_extras);
            fieldGeneratorIHeartRadioUserIdentificationData = new IHeartMediaUserIdentificationDataJSON.HoldingGenerator("field \"IHeartRadioUserIdentificationData\" of the StationShowIHeartRadioInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StationShowIHeartRadioInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorStations = new RadioStationJSON.HoldingArrayGenerator("field \"Stations\" of the StationShowIHeartRadioInformationNugget class", false);
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the StationShowIHeartRadioInformationNugget class", false);
            fieldGeneratorUserRequestedLocationRetrievalSuccess = new JSONHoldingBooleanGenerator("field \"UserRequestedLocationRetrievalSuccess\" of the StationShowIHeartRadioInformationNugget class");
            fieldGeneratorSpokenStationIndices = new FieldHoldingArrayGeneratorSpokenStationIndices("field \"SpokenStationIndices\" of the StationShowIHeartRadioInformationNugget class");
            fieldGeneratorUserRequestedSpokenStationIndices = new JSONHoldingBooleanGenerator("field \"UserRequestedSpokenStationIndices\" of the StationShowIHeartRadioInformationNugget class");
            fieldGeneratorUserRequestedQueryInfo = new IHeartRadioQueryInfoJSON.HoldingGenerator("field \"UserRequestedQueryInfo\" of the StationShowIHeartRadioInformationNugget class", false);
            fieldGeneratorIHeartRadioUserIdentificationData = new IHeartMediaUserIdentificationDataJSON.HoldingGenerator("field \"IHeartRadioUserIdentificationData\" of the StationShowIHeartRadioInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StationShowIHeartRadioInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorStations.reset();
            fieldGeneratorAttribution.reset();
            fieldGeneratorUserRequestedLocationRetrievalSuccess.reset();
            fieldGeneratorSpokenStationIndices.reset();
            fieldGeneratorUserRequestedSpokenStationIndices.reset();
            fieldGeneratorUserRequestedQueryInfo.reset();
            fieldGeneratorIHeartRadioUserIdentificationData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(StationShowIHeartRadioInformationNuggetJSON  result)
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
        public StationShowIHeartRadioInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StationShowIHeartRadioInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<StationShowIHeartRadioInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StationShowIHeartRadioInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StationShowIHeartRadioInformationNuggetJSON>();
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
    public List<StationShowIHeartRadioInformationNuggetJSON> value;
  };
  };
