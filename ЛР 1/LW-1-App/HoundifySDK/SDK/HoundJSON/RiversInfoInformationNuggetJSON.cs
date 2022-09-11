/* file "RiversInfoInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RiversInfoInformationNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasRivers;
    private List< RiverJSON  > storeRivers;
    private bool flagHasRequestLength;
    private bool storeRequestLength;
    private bool flagHasRequestDischarge;
    private bool storeRequestDischarge;
    private bool flagHasRequestDischargeIfPresent;
    private bool storeRequestDischargeIfPresent;
    private bool flagHasRequestCities;
    private bool storeRequestCities;
    private bool flagHasRequestCitiesIfPresent;
    private bool storeRequestCitiesIfPresent;
    private bool flagHasRequestUsStates;
    private bool storeRequestUsStates;
    private bool flagHasRequestUsStatesIfPresent;
    private bool storeRequestUsStatesIfPresent;
    private bool flagHasRequestCountries;
    private bool storeRequestCountries;
    private bool flagHasRequestContinents;
    private bool storeRequestContinents;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraRiversToJSON()
      {
        JSONArrayValue generated_array_1_Rivers = new JSONArrayValue();
        for (int num1 = 0; num1 < storeRivers.Count; ++num1)
          {
            JSONValueHandler handler_Rivers = new JSONValueHandler();
            storeRivers[num1].write_as_json(handler_Rivers);
            generated_array_1_Rivers.appendComponent(handler_Rivers.result);
          }
        return generated_array_1_Rivers;
      }

    private JSONValue  extraRequestLengthToJSON()
      {
        JSONValue generated_boolean_RequestLength = (storeRequestLength ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestLength;
      }

    private JSONValue  extraRequestDischargeToJSON()
      {
        JSONValue generated_boolean_RequestDischarge = (storeRequestDischarge ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestDischarge;
      }

    private JSONValue  extraRequestDischargeIfPresentToJSON()
      {
        JSONValue generated_boolean_RequestDischargeIfPresent = (storeRequestDischargeIfPresent ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestDischargeIfPresent;
      }

    private JSONValue  extraRequestCitiesToJSON()
      {
        JSONValue generated_boolean_RequestCities = (storeRequestCities ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestCities;
      }

    private JSONValue  extraRequestCitiesIfPresentToJSON()
      {
        JSONValue generated_boolean_RequestCitiesIfPresent = (storeRequestCitiesIfPresent ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestCitiesIfPresent;
      }

    private JSONValue  extraRequestUsStatesToJSON()
      {
        JSONValue generated_boolean_RequestUsStates = (storeRequestUsStates ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestUsStates;
      }

    private JSONValue  extraRequestUsStatesIfPresentToJSON()
      {
        JSONValue generated_boolean_RequestUsStatesIfPresent = (storeRequestUsStatesIfPresent ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestUsStatesIfPresent;
      }

    private JSONValue  extraRequestCountriesToJSON()
      {
        JSONValue generated_boolean_RequestCountries = (storeRequestCountries ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestCountries;
      }

    private JSONValue  extraRequestContinentsToJSON()
      {
        JSONValue generated_boolean_RequestContinents = (storeRequestContinents ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestContinents;
      }


    private void  fromJSONRivers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Rivers of RiversInfoInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Rivers of RiversInfoInformationNuggetJSON has too few elements.");
        List< RiverJSON  > vector_Rivers1 = new List< RiverJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RiverJSON convert_classy = RiverJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Rivers1.Add(convert_classy);
          }
        Debug.Assert(vector_Rivers1.Count >= 1);
        initRivers();
        for (int num1 = 0; num1 < vector_Rivers1.Count; ++num1)
            appendRivers(vector_Rivers1[num1]);
        for (int num1 = 0; num1 < vector_Rivers1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestLength(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestLength of RiversInfoInformationNuggetJSON is not true for false.");
              }
          }
        setRequestLength(the_bool);
      }


    private void  fromJSONRequestDischarge(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestDischarge of RiversInfoInformationNuggetJSON is not true for false.");
              }
          }
        setRequestDischarge(the_bool);
      }


    private void  fromJSONRequestDischargeIfPresent(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestDischargeIfPresent of RiversInfoInformationNuggetJSON is not true for false.");
              }
          }
        setRequestDischargeIfPresent(the_bool);
      }


    private void  fromJSONRequestCities(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestCities of RiversInfoInformationNuggetJSON is not true for false.");
              }
          }
        setRequestCities(the_bool);
      }


    private void  fromJSONRequestCitiesIfPresent(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestCitiesIfPresent of RiversInfoInformationNuggetJSON is not true for false.");
              }
          }
        setRequestCitiesIfPresent(the_bool);
      }


    private void  fromJSONRequestUsStates(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestUsStates of RiversInfoInformationNuggetJSON is not true for false.");
              }
          }
        setRequestUsStates(the_bool);
      }


    private void  fromJSONRequestUsStatesIfPresent(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestUsStatesIfPresent of RiversInfoInformationNuggetJSON is not true for false.");
              }
          }
        setRequestUsStatesIfPresent(the_bool);
      }


    private void  fromJSONRequestCountries(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestCountries of RiversInfoInformationNuggetJSON is not true for false.");
              }
          }
        setRequestCountries(the_bool);
      }


    private void  fromJSONRequestContinents(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestContinents of RiversInfoInformationNuggetJSON is not true for false.");
              }
          }
        setRequestContinents(the_bool);
      }


    public RiversInfoInformationNuggetJSON()
      {
        flagHasRivers = false;
        flagHasRequestLength = false;
        flagHasRequestDischarge = false;
        flagHasRequestDischargeIfPresent = false;
        flagHasRequestCities = false;
        flagHasRequestCitiesIfPresent = false;
        flagHasRequestUsStates = false;
        flagHasRequestUsStatesIfPresent = false;
        flagHasRequestCountries = false;
        flagHasRequestContinents = false;
        storeRivers = new List< RiverJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "RiversInfoInformationNugget";
      }

    public bool  hasRivers()
      {
        return flagHasRivers;
      }

    public int  countOfRivers()
      {
        Debug.Assert(flagHasRivers);
        return storeRivers.Count;
      }

    public RiverJSON   elementOfRivers(int element_num)
      {
        Debug.Assert(flagHasRivers);
        return storeRivers[element_num];
      }

    public List< RiverJSON  >  getRivers()
      {
        Debug.Assert(flagHasRivers);
        return storeRivers;
      }

    public bool  hasRequestLength()
      {
        return flagHasRequestLength;
      }

    public bool  getRequestLength()
      {
        Debug.Assert(flagHasRequestLength);
        return storeRequestLength;
      }

    public bool  hasRequestDischarge()
      {
        return flagHasRequestDischarge;
      }

    public bool  getRequestDischarge()
      {
        Debug.Assert(flagHasRequestDischarge);
        return storeRequestDischarge;
      }

    public bool  hasRequestDischargeIfPresent()
      {
        return flagHasRequestDischargeIfPresent;
      }

    public bool  getRequestDischargeIfPresent()
      {
        Debug.Assert(flagHasRequestDischargeIfPresent);
        return storeRequestDischargeIfPresent;
      }

    public bool  hasRequestCities()
      {
        return flagHasRequestCities;
      }

    public bool  getRequestCities()
      {
        Debug.Assert(flagHasRequestCities);
        return storeRequestCities;
      }

    public bool  hasRequestCitiesIfPresent()
      {
        return flagHasRequestCitiesIfPresent;
      }

    public bool  getRequestCitiesIfPresent()
      {
        Debug.Assert(flagHasRequestCitiesIfPresent);
        return storeRequestCitiesIfPresent;
      }

    public bool  hasRequestUsStates()
      {
        return flagHasRequestUsStates;
      }

    public bool  getRequestUsStates()
      {
        Debug.Assert(flagHasRequestUsStates);
        return storeRequestUsStates;
      }

    public bool  hasRequestUsStatesIfPresent()
      {
        return flagHasRequestUsStatesIfPresent;
      }

    public bool  getRequestUsStatesIfPresent()
      {
        Debug.Assert(flagHasRequestUsStatesIfPresent);
        return storeRequestUsStatesIfPresent;
      }

    public bool  hasRequestCountries()
      {
        return flagHasRequestCountries;
      }

    public bool  getRequestCountries()
      {
        Debug.Assert(flagHasRequestCountries);
        return storeRequestCountries;
      }

    public bool  hasRequestContinents()
      {
        return flagHasRequestContinents;
      }

    public bool  getRequestContinents()
      {
        Debug.Assert(flagHasRequestContinents);
        return storeRequestContinents;
      }


    public virtual int extraRiversInfoInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRiversInfoInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRiversInfoInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRiversInfoInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasRivers)
            ++result;
        if (flagHasRequestLength)
            ++result;
        if (flagHasRequestDischarge)
            ++result;
        if (flagHasRequestDischargeIfPresent)
            ++result;
        if (flagHasRequestCities)
            ++result;
        if (flagHasRequestCitiesIfPresent)
            ++result;
        if (flagHasRequestUsStates)
            ++result;
        if (flagHasRequestUsStatesIfPresent)
            ++result;
        if (flagHasRequestCountries)
            ++result;
        if (flagHasRequestContinents)
            ++result;
        result += extraRiversInfoInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRivers)
          {
            if (remainder == 0)
                return "Rivers";
            --remainder;
          }
        if (flagHasRequestLength)
          {
            if (remainder == 0)
                return "RequestLength";
            --remainder;
          }
        if (flagHasRequestDischarge)
          {
            if (remainder == 0)
                return "RequestDischarge";
            --remainder;
          }
        if (flagHasRequestDischargeIfPresent)
          {
            if (remainder == 0)
                return "RequestDischargeIfPresent";
            --remainder;
          }
        if (flagHasRequestCities)
          {
            if (remainder == 0)
                return "RequestCities";
            --remainder;
          }
        if (flagHasRequestCitiesIfPresent)
          {
            if (remainder == 0)
                return "RequestCitiesIfPresent";
            --remainder;
          }
        if (flagHasRequestUsStates)
          {
            if (remainder == 0)
                return "RequestUsStates";
            --remainder;
          }
        if (flagHasRequestUsStatesIfPresent)
          {
            if (remainder == 0)
                return "RequestUsStatesIfPresent";
            --remainder;
          }
        if (flagHasRequestCountries)
          {
            if (remainder == 0)
                return "RequestCountries";
            --remainder;
          }
        if (flagHasRequestContinents)
          {
            if (remainder == 0)
                return "RequestContinents";
            --remainder;
          }
        return extraRiversInfoInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRivers)
          {
            if (remainder == 0)
                return extraRiversToJSON();
            --remainder;
          }
        if (flagHasRequestLength)
          {
            if (remainder == 0)
                return extraRequestLengthToJSON();
            --remainder;
          }
        if (flagHasRequestDischarge)
          {
            if (remainder == 0)
                return extraRequestDischargeToJSON();
            --remainder;
          }
        if (flagHasRequestDischargeIfPresent)
          {
            if (remainder == 0)
                return extraRequestDischargeIfPresentToJSON();
            --remainder;
          }
        if (flagHasRequestCities)
          {
            if (remainder == 0)
                return extraRequestCitiesToJSON();
            --remainder;
          }
        if (flagHasRequestCitiesIfPresent)
          {
            if (remainder == 0)
                return extraRequestCitiesIfPresentToJSON();
            --remainder;
          }
        if (flagHasRequestUsStates)
          {
            if (remainder == 0)
                return extraRequestUsStatesToJSON();
            --remainder;
          }
        if (flagHasRequestUsStatesIfPresent)
          {
            if (remainder == 0)
                return extraRequestUsStatesIfPresentToJSON();
            --remainder;
          }
        if (flagHasRequestCountries)
          {
            if (remainder == 0)
                return extraRequestCountriesToJSON();
            --remainder;
          }
        if (flagHasRequestContinents)
          {
            if (remainder == 0)
                return extraRequestContinentsToJSON();
            --remainder;
          }
        return extraRiversInfoInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "R", 0, 1, false) == 0)
          {
            switch (field_name[1])
              {
                case 'e':
                    if (String.Compare(field_name, 2, "quest", 0, 5, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'C':
                                switch (field_name[8])
                                  {
                                    case 'i':
                                        if (String.Compare(field_name, 9, "ties", 0, 4, false) == 0)
                                          {
                                            if (field_name.Length == 13)
                                              {
                                                return (flagHasRequestCities ? extraRequestCitiesToJSON() : null);
                                              }
                                            switch (field_name[13])
                                              {
                                                case 'I':
                                                    if ((String.Compare(field_name, 14, "fPresent", 0, 8, false) == 0) && (field_name.Length == 22))
                                                        return (flagHasRequestCitiesIfPresent ? extraRequestCitiesIfPresentToJSON() : null);
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'o':
                                        switch (field_name[9])
                                          {
                                            case 'n':
                                                if ((String.Compare(field_name, 10, "tinents", 0, 7, false) == 0) && (field_name.Length == 17))
                                                    return (flagHasRequestContinents ? extraRequestContinentsToJSON() : null);
                                                break;
                                            case 'u':
                                                if ((String.Compare(field_name, 10, "ntries", 0, 6, false) == 0) && (field_name.Length == 16))
                                                    return (flagHasRequestCountries ? extraRequestCountriesToJSON() : null);
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'D':
                                if (String.Compare(field_name, 8, "ischarge", 0, 8, false) == 0)
                                  {
                                    if (field_name.Length == 16)
                                      {
                                        return (flagHasRequestDischarge ? extraRequestDischargeToJSON() : null);
                                      }
                                    switch (field_name[16])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 17, "fPresent", 0, 8, false) == 0) && (field_name.Length == 25))
                                                return (flagHasRequestDischargeIfPresent ? extraRequestDischargeIfPresentToJSON() : null);
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'L':
                                if ((String.Compare(field_name, 8, "ength", 0, 5, false) == 0) && (field_name.Length == 13))
                                    return (flagHasRequestLength ? extraRequestLengthToJSON() : null);
                                break;
                            case 'U':
                                if (String.Compare(field_name, 8, "sStates", 0, 7, false) == 0)
                                  {
                                    if (field_name.Length == 15)
                                      {
                                        return (flagHasRequestUsStates ? extraRequestUsStatesToJSON() : null);
                                      }
                                    switch (field_name[15])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 16, "fPresent", 0, 8, false) == 0) && (field_name.Length == 24))
                                                return (flagHasRequestUsStatesIfPresent ? extraRequestUsStatesIfPresentToJSON() : null);
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
                case 'i':
                    if ((String.Compare(field_name, 2, "vers", 0, 4, false) == 0) && (field_name.Length == 6))
                        return (flagHasRivers ? extraRiversToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraRiversInfoInformationNuggetLookup(field_name);
      }

    public void initRivers()
      {
        if (flagHasRivers)
          {
            for (int num1 = 0; num1 < storeRivers.Count; ++num1)
              {
              }
          }
        flagHasRivers = true;
        storeRivers.Clear();
      }
    public void appendRivers(RiverJSON  to_append)
      {
        if (!flagHasRivers)
          {
            flagHasRivers = true;
            storeRivers.Clear();
          }
        Debug.Assert(flagHasRivers);
        storeRivers.Add(to_append);
      }
    public void unsetRivers()
      {
        if (flagHasRivers)
          {
            for (int num2 = 0; num2 < storeRivers.Count; ++num2)
              {
              }
          }
        flagHasRivers = false;
        storeRivers.Clear();
      }
    public void setRequestLength(bool new_value)
      {
        flagHasRequestLength = true;
        storeRequestLength = new_value;
      }
    public void unsetRequestLength()
      {
        flagHasRequestLength = false;
      }
    public void setRequestDischarge(bool new_value)
      {
        flagHasRequestDischarge = true;
        storeRequestDischarge = new_value;
      }
    public void unsetRequestDischarge()
      {
        flagHasRequestDischarge = false;
      }
    public void setRequestDischargeIfPresent(bool new_value)
      {
        flagHasRequestDischargeIfPresent = true;
        storeRequestDischargeIfPresent = new_value;
      }
    public void unsetRequestDischargeIfPresent()
      {
        flagHasRequestDischargeIfPresent = false;
      }
    public void setRequestCities(bool new_value)
      {
        flagHasRequestCities = true;
        storeRequestCities = new_value;
      }
    public void unsetRequestCities()
      {
        flagHasRequestCities = false;
      }
    public void setRequestCitiesIfPresent(bool new_value)
      {
        flagHasRequestCitiesIfPresent = true;
        storeRequestCitiesIfPresent = new_value;
      }
    public void unsetRequestCitiesIfPresent()
      {
        flagHasRequestCitiesIfPresent = false;
      }
    public void setRequestUsStates(bool new_value)
      {
        flagHasRequestUsStates = true;
        storeRequestUsStates = new_value;
      }
    public void unsetRequestUsStates()
      {
        flagHasRequestUsStates = false;
      }
    public void setRequestUsStatesIfPresent(bool new_value)
      {
        flagHasRequestUsStatesIfPresent = true;
        storeRequestUsStatesIfPresent = new_value;
      }
    public void unsetRequestUsStatesIfPresent()
      {
        flagHasRequestUsStatesIfPresent = false;
      }
    public void setRequestCountries(bool new_value)
      {
        flagHasRequestCountries = true;
        storeRequestCountries = new_value;
      }
    public void unsetRequestCountries()
      {
        flagHasRequestCountries = false;
      }
    public void setRequestContinents(bool new_value)
      {
        flagHasRequestContinents = true;
        storeRequestContinents = new_value;
      }
    public void unsetRequestContinents()
      {
        flagHasRequestContinents = false;
      }

    public virtual void extraRiversInfoInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRiversInfoInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRiversInfoInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraRiversInfoInformationNuggetAppendPair(key, new_component);
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
        if (String.Compare(key, 0, "R", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'e':
                    if (String.Compare(key, 2, "quest", 0, 5, false) == 0)
                      {
                        switch (key[7])
                          {
                            case 'C':
                                switch (key[8])
                                  {
                                    case 'i':
                                        if (String.Compare(key, 9, "ties", 0, 4, false) == 0)
                                          {
                                            if (key.Length == 13)
                                              {
                                                {
                                                fromJSONRequestCities(new_component, false);
                                                return;
                                                }
                                              }
                                            switch (key[13])
                                              {
                                                case 'I':
                                                    if ((String.Compare(key, 14, "fPresent", 0, 8, false) == 0) && (key.Length == 22))
                                                        {
                                                        fromJSONRequestCitiesIfPresent(new_component, false);
                                                        return;
                                                        }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'o':
                                        switch (key[9])
                                          {
                                            case 'n':
                                                if ((String.Compare(key, 10, "tinents", 0, 7, false) == 0) && (key.Length == 17))
                                                    {
                                                    fromJSONRequestContinents(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'u':
                                                if ((String.Compare(key, 10, "ntries", 0, 6, false) == 0) && (key.Length == 16))
                                                    {
                                                    fromJSONRequestCountries(new_component, false);
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
                                break;
                            case 'D':
                                if (String.Compare(key, 8, "ischarge", 0, 8, false) == 0)
                                  {
                                    if (key.Length == 16)
                                      {
                                        {
                                        fromJSONRequestDischarge(new_component, false);
                                        return;
                                        }
                                      }
                                    switch (key[16])
                                      {
                                        case 'I':
                                            if ((String.Compare(key, 17, "fPresent", 0, 8, false) == 0) && (key.Length == 25))
                                                {
                                                fromJSONRequestDischargeIfPresent(new_component, false);
                                                return;
                                                }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'L':
                                if ((String.Compare(key, 8, "ength", 0, 5, false) == 0) && (key.Length == 13))
                                    {
                                    fromJSONRequestLength(new_component, false);
                                    return;
                                    }
                                break;
                            case 'U':
                                if (String.Compare(key, 8, "sStates", 0, 7, false) == 0)
                                  {
                                    if (key.Length == 15)
                                      {
                                        {
                                        fromJSONRequestUsStates(new_component, false);
                                        return;
                                        }
                                      }
                                    switch (key[15])
                                      {
                                        case 'I':
                                            if ((String.Compare(key, 16, "fPresent", 0, 8, false) == 0) && (key.Length == 24))
                                                {
                                                fromJSONRequestUsStatesIfPresent(new_component, false);
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
                case 'i':
                    if ((String.Compare(key, 2, "vers", 0, 4, false) == 0) && (key.Length == 6))
                        {
                        fromJSONRivers(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraRiversInfoInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "R", 0, 1, false) == 0)
          {
            switch (key[1])
              {
                case 'e':
                    if (String.Compare(key, 2, "quest", 0, 5, false) == 0)
                      {
                        switch (key[7])
                          {
                            case 'C':
                                switch (key[8])
                                  {
                                    case 'i':
                                        if (String.Compare(key, 9, "ties", 0, 4, false) == 0)
                                          {
                                            if (key.Length == 13)
                                              {
                                                {
                                                fromJSONRequestCities(new_component, false);
                                                return;
                                                }
                                              }
                                            switch (key[13])
                                              {
                                                case 'I':
                                                    if ((String.Compare(key, 14, "fPresent", 0, 8, false) == 0) && (key.Length == 22))
                                                        {
                                                        fromJSONRequestCitiesIfPresent(new_component, false);
                                                        return;
                                                        }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'o':
                                        switch (key[9])
                                          {
                                            case 'n':
                                                if ((String.Compare(key, 10, "tinents", 0, 7, false) == 0) && (key.Length == 17))
                                                    {
                                                    fromJSONRequestContinents(new_component, false);
                                                    return;
                                                    }
                                                break;
                                            case 'u':
                                                if ((String.Compare(key, 10, "ntries", 0, 6, false) == 0) && (key.Length == 16))
                                                    {
                                                    fromJSONRequestCountries(new_component, false);
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
                                break;
                            case 'D':
                                if (String.Compare(key, 8, "ischarge", 0, 8, false) == 0)
                                  {
                                    if (key.Length == 16)
                                      {
                                        {
                                        fromJSONRequestDischarge(new_component, false);
                                        return;
                                        }
                                      }
                                    switch (key[16])
                                      {
                                        case 'I':
                                            if ((String.Compare(key, 17, "fPresent", 0, 8, false) == 0) && (key.Length == 25))
                                                {
                                                fromJSONRequestDischargeIfPresent(new_component, false);
                                                return;
                                                }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'L':
                                if ((String.Compare(key, 8, "ength", 0, 5, false) == 0) && (key.Length == 13))
                                    {
                                    fromJSONRequestLength(new_component, false);
                                    return;
                                    }
                                break;
                            case 'U':
                                if (String.Compare(key, 8, "sStates", 0, 7, false) == 0)
                                  {
                                    if (key.Length == 15)
                                      {
                                        {
                                        fromJSONRequestUsStates(new_component, false);
                                        return;
                                        }
                                      }
                                    switch (key[15])
                                      {
                                        case 'I':
                                            if ((String.Compare(key, 16, "fPresent", 0, 8, false) == 0) && (key.Length == 24))
                                                {
                                                fromJSONRequestUsStatesIfPresent(new_component, false);
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
                case 'i':
                    if ((String.Compare(key, 2, "vers", 0, 4, false) == 0) && (key.Length == 6))
                        {
                        fromJSONRivers(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraRiversInfoInformationNuggetSetField(key, new_component);
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
        if (flagHasRivers)
          {
            handler.start_pair("Rivers");
            Debug.Assert(storeRivers.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeRivers.Count; ++num1)
              {
                if (partial_allowed)
                    storeRivers[num1].write_partial_as_json(handler);
                else
                    storeRivers[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasRequestLength);
        if (flagHasRequestLength)
          {
            handler.start_pair("RequestLength");
            handler.boolean_value(storeRequestLength);
          }
        Debug.Assert(partial_allowed || flagHasRequestDischarge);
        if (flagHasRequestDischarge)
          {
            handler.start_pair("RequestDischarge");
            handler.boolean_value(storeRequestDischarge);
          }
        Debug.Assert(partial_allowed || flagHasRequestDischargeIfPresent);
        if (flagHasRequestDischargeIfPresent)
          {
            handler.start_pair("RequestDischargeIfPresent");
            handler.boolean_value(storeRequestDischargeIfPresent);
          }
        Debug.Assert(partial_allowed || flagHasRequestCities);
        if (flagHasRequestCities)
          {
            handler.start_pair("RequestCities");
            handler.boolean_value(storeRequestCities);
          }
        Debug.Assert(partial_allowed || flagHasRequestCitiesIfPresent);
        if (flagHasRequestCitiesIfPresent)
          {
            handler.start_pair("RequestCitiesIfPresent");
            handler.boolean_value(storeRequestCitiesIfPresent);
          }
        Debug.Assert(partial_allowed || flagHasRequestUsStates);
        if (flagHasRequestUsStates)
          {
            handler.start_pair("RequestUsStates");
            handler.boolean_value(storeRequestUsStates);
          }
        Debug.Assert(partial_allowed || flagHasRequestUsStatesIfPresent);
        if (flagHasRequestUsStatesIfPresent)
          {
            handler.start_pair("RequestUsStatesIfPresent");
            handler.boolean_value(storeRequestUsStatesIfPresent);
          }
        Debug.Assert(partial_allowed || flagHasRequestCountries);
        if (flagHasRequestCountries)
          {
            handler.start_pair("RequestCountries");
            handler.boolean_value(storeRequestCountries);
          }
        Debug.Assert(partial_allowed || flagHasRequestContinents);
        if (flagHasRequestContinents)
          {
            handler.start_pair("RequestContinents");
            handler.boolean_value(storeRequestContinents);
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
        if (!(hasRequestLength()))
          {
            return "When parsing the object for %what%, the \"RequestLength\" field was missing.";
          }
        if (!(hasRequestDischarge()))
          {
            return "When parsing the object for %what%, the \"RequestDischarge\" field was missing.";
          }
        if (!(hasRequestDischargeIfPresent()))
          {
            return "When parsing the object for %what%, the \"RequestDischargeIfPresent\" field was missing.";
          }
        if (!(hasRequestCities()))
          {
            return "When parsing the object for %what%, the \"RequestCities\" field was missing.";
          }
        if (!(hasRequestCitiesIfPresent()))
          {
            return "When parsing the object for %what%, the \"RequestCitiesIfPresent\" field was missing.";
          }
        if (!(hasRequestUsStates()))
          {
            return "When parsing the object for %what%, the \"RequestUsStates\" field was missing.";
          }
        if (!(hasRequestUsStatesIfPresent()))
          {
            return "When parsing the object for %what%, the \"RequestUsStatesIfPresent\" field was missing.";
          }
        if (!(hasRequestCountries()))
          {
            return "When parsing the object for %what%, the \"RequestCountries\" field was missing.";
          }
        if (!(hasRequestContinents()))
          {
            return "When parsing the object for %what%, the \"RequestContinents\" field was missing.";
          }
        return null;
      }

    public static new RiversInfoInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RiversInfoInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversInfoInformationNugget", ignore_extras);
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
    public static new RiversInfoInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RiversInfoInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RiversInfoInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversInfoInformationNugget", ignore_extras);
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
    public static new RiversInfoInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RiversInfoInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        RiversInfoInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversInfoInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RiversInfoInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RiversInfoInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RiversInfoInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RiversInfoInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private RiverJSON.HoldingArrayGenerator fieldGeneratorRivers;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestLength;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestDischarge;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestDischargeIfPresent;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestCities;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestCitiesIfPresent;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestUsStates;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestUsStatesIfPresent;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestCountries;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestContinents;
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
            if (!(getInformationNuggetJSONKey().Equals("RiversInfoInformationNugget")))
                throw new Exception("The key field has a value other than `RiversInfoInformationNugget'.");
            RiversInfoInformationNuggetJSON result = new RiversInfoInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRiversInfoInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((RiversInfoInformationNuggetJSON )new_result);
          }
        protected void finish(RiversInfoInformationNuggetJSON result)
          {
            if (fieldGeneratorRivers.have_value)
              {
                result.initRivers();
                int count = fieldGeneratorRivers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRivers(fieldGeneratorRivers.value[num]);
                  }
                fieldGeneratorRivers.value.Clear();
                fieldGeneratorRivers.have_value = false;
              }
            if (fieldGeneratorRequestLength.have_value)
              {
                result.setRequestLength(fieldGeneratorRequestLength.value);
                fieldGeneratorRequestLength.have_value = false;
              }
            else if ((!(result.hasRequestLength())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestLength\" field was missing.");
              }
            if (fieldGeneratorRequestDischarge.have_value)
              {
                result.setRequestDischarge(fieldGeneratorRequestDischarge.value);
                fieldGeneratorRequestDischarge.have_value = false;
              }
            else if ((!(result.hasRequestDischarge())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestDischarge\" field was missing.");
              }
            if (fieldGeneratorRequestDischargeIfPresent.have_value)
              {
                result.setRequestDischargeIfPresent(fieldGeneratorRequestDischargeIfPresent.value);
                fieldGeneratorRequestDischargeIfPresent.have_value = false;
              }
            else if ((!(result.hasRequestDischargeIfPresent())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestDischargeIfPresent\" field was missing.");
              }
            if (fieldGeneratorRequestCities.have_value)
              {
                result.setRequestCities(fieldGeneratorRequestCities.value);
                fieldGeneratorRequestCities.have_value = false;
              }
            else if ((!(result.hasRequestCities())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestCities\" field was missing.");
              }
            if (fieldGeneratorRequestCitiesIfPresent.have_value)
              {
                result.setRequestCitiesIfPresent(fieldGeneratorRequestCitiesIfPresent.value);
                fieldGeneratorRequestCitiesIfPresent.have_value = false;
              }
            else if ((!(result.hasRequestCitiesIfPresent())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestCitiesIfPresent\" field was missing.");
              }
            if (fieldGeneratorRequestUsStates.have_value)
              {
                result.setRequestUsStates(fieldGeneratorRequestUsStates.value);
                fieldGeneratorRequestUsStates.have_value = false;
              }
            else if ((!(result.hasRequestUsStates())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestUsStates\" field was missing.");
              }
            if (fieldGeneratorRequestUsStatesIfPresent.have_value)
              {
                result.setRequestUsStatesIfPresent(fieldGeneratorRequestUsStatesIfPresent.value);
                fieldGeneratorRequestUsStatesIfPresent.have_value = false;
              }
            else if ((!(result.hasRequestUsStatesIfPresent())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestUsStatesIfPresent\" field was missing.");
              }
            if (fieldGeneratorRequestCountries.have_value)
              {
                result.setRequestCountries(fieldGeneratorRequestCountries.value);
                fieldGeneratorRequestCountries.have_value = false;
              }
            else if ((!(result.hasRequestCountries())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestCountries\" field was missing.");
              }
            if (fieldGeneratorRequestContinents.have_value)
              {
                result.setRequestContinents(fieldGeneratorRequestContinents.value);
                fieldGeneratorRequestContinents.have_value = false;
              }
            else if ((!(result.hasRequestContinents())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestContinents\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RiversInfoInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "R", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'e':
                        if (String.Compare(field_name, 2, "quest", 0, 5, false) == 0)
                          {
                            switch (field_name[7])
                              {
                                case 'C':
                                    switch (field_name[8])
                                      {
                                        case 'i':
                                            if (String.Compare(field_name, 9, "ties", 0, 4, false) == 0)
                                              {
                                                if (field_name.Length == 13)
                                                  {
                                                    return fieldGeneratorRequestCities;
                                                  }
                                                switch (field_name[13])
                                                  {
                                                    case 'I':
                                                        if ((String.Compare(field_name, 14, "fPresent", 0, 8, false) == 0) && (field_name.Length == 22))
                                                            return fieldGeneratorRequestCitiesIfPresent;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 'o':
                                            switch (field_name[9])
                                              {
                                                case 'n':
                                                    if ((String.Compare(field_name, 10, "tinents", 0, 7, false) == 0) && (field_name.Length == 17))
                                                        return fieldGeneratorRequestContinents;
                                                    break;
                                                case 'u':
                                                    if ((String.Compare(field_name, 10, "ntries", 0, 6, false) == 0) && (field_name.Length == 16))
                                                        return fieldGeneratorRequestCountries;
                                                    break;
                                                default:
                                                    break;
                                              }
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'D':
                                    if (String.Compare(field_name, 8, "ischarge", 0, 8, false) == 0)
                                      {
                                        if (field_name.Length == 16)
                                          {
                                            return fieldGeneratorRequestDischarge;
                                          }
                                        switch (field_name[16])
                                          {
                                            case 'I':
                                                if ((String.Compare(field_name, 17, "fPresent", 0, 8, false) == 0) && (field_name.Length == 25))
                                                    return fieldGeneratorRequestDischargeIfPresent;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'L':
                                    if ((String.Compare(field_name, 8, "ength", 0, 5, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorRequestLength;
                                    break;
                                case 'U':
                                    if (String.Compare(field_name, 8, "sStates", 0, 7, false) == 0)
                                      {
                                        if (field_name.Length == 15)
                                          {
                                            return fieldGeneratorRequestUsStates;
                                          }
                                        switch (field_name[15])
                                          {
                                            case 'I':
                                                if ((String.Compare(field_name, 16, "fPresent", 0, 8, false) == 0) && (field_name.Length == 24))
                                                    return fieldGeneratorRequestUsStatesIfPresent;
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
                    case 'i':
                        if ((String.Compare(field_name, 2, "vers", 0, 4, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorRivers;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRivers = new RiverJSON.HoldingArrayGenerator("field \"Rivers\" of the RiversInfoInformationNugget class", ignore_extras);
            fieldGeneratorRequestLength = new JSONHoldingBooleanGenerator("field \"RequestLength\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestDischarge = new JSONHoldingBooleanGenerator("field \"RequestDischarge\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestDischargeIfPresent = new JSONHoldingBooleanGenerator("field \"RequestDischargeIfPresent\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestCities = new JSONHoldingBooleanGenerator("field \"RequestCities\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestCitiesIfPresent = new JSONHoldingBooleanGenerator("field \"RequestCitiesIfPresent\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestUsStates = new JSONHoldingBooleanGenerator("field \"RequestUsStates\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestUsStatesIfPresent = new JSONHoldingBooleanGenerator("field \"RequestUsStatesIfPresent\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestCountries = new JSONHoldingBooleanGenerator("field \"RequestCountries\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestContinents = new JSONHoldingBooleanGenerator("field \"RequestContinents\" of the RiversInfoInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RiversInfoInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRivers = new RiverJSON.HoldingArrayGenerator("field \"Rivers\" of the RiversInfoInformationNugget class", false);
            fieldGeneratorRequestLength = new JSONHoldingBooleanGenerator("field \"RequestLength\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestDischarge = new JSONHoldingBooleanGenerator("field \"RequestDischarge\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestDischargeIfPresent = new JSONHoldingBooleanGenerator("field \"RequestDischargeIfPresent\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestCities = new JSONHoldingBooleanGenerator("field \"RequestCities\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestCitiesIfPresent = new JSONHoldingBooleanGenerator("field \"RequestCitiesIfPresent\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestUsStates = new JSONHoldingBooleanGenerator("field \"RequestUsStates\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestUsStatesIfPresent = new JSONHoldingBooleanGenerator("field \"RequestUsStatesIfPresent\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestCountries = new JSONHoldingBooleanGenerator("field \"RequestCountries\" of the RiversInfoInformationNugget class");
            fieldGeneratorRequestContinents = new JSONHoldingBooleanGenerator("field \"RequestContinents\" of the RiversInfoInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RiversInfoInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorRivers.reset();
            fieldGeneratorRequestLength.reset();
            fieldGeneratorRequestDischarge.reset();
            fieldGeneratorRequestDischargeIfPresent.reset();
            fieldGeneratorRequestCities.reset();
            fieldGeneratorRequestCitiesIfPresent.reset();
            fieldGeneratorRequestUsStates.reset();
            fieldGeneratorRequestUsStatesIfPresent.reset();
            fieldGeneratorRequestCountries.reset();
            fieldGeneratorRequestContinents.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RiversInfoInformationNuggetJSON  result)
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
        public RiversInfoInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RiversInfoInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<RiversInfoInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RiversInfoInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RiversInfoInformationNuggetJSON>();
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
    public List<RiversInfoInformationNuggetJSON> value;
  };
  };
