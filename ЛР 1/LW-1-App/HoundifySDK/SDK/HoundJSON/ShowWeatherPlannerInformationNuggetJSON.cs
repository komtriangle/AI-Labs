/* file "ShowWeatherPlannerInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ShowWeatherPlannerInformationNuggetJSON : WeatherInformationNuggetJSON
  {
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private bool flagHasAlerts;
    private List< AlertJSON  > storeAlerts;
    private bool flagHasRequestedAttribute;
    private WeatherAttributeJSON  storeRequestedAttribute;
    private bool flagHasRequestedStartDateAndTime;
    private DateAndOrTimeJSON  storeRequestedStartDateAndTime;
    private bool flagHasRequestedEndDateAndTime;
    private DateAndOrTimeJSON  storeRequestedEndDateAndTime;
    private bool flagHasRequestedStartDateTimeSpec;
    private DateTimeSpecJSON  storeRequestedStartDateTimeSpec;
    private bool flagHasRequestedEndDateTimeSpec;
    private DateTimeSpecJSON  storeRequestedEndDateTimeSpec;
    private bool flagHasPlanner;
    private PlannerJSON  storePlanner;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraAttributionToJSON()
      {
        JSONValueHandler handler_Attribution = new JSONValueHandler();
        storeAttribution.write_as_json(handler_Attribution);
        return handler_Attribution.result;
      }

    private JSONValue  extraLocationToJSON()
      {
        JSONValueHandler handler_Location = new JSONValueHandler();
        storeLocation.write_as_json(handler_Location);
        return handler_Location.result;
      }

    private JSONValue  extraAlertsToJSON()
      {
        JSONArrayValue generated_array_1_Alerts = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAlerts.Count; ++num1)
          {
            JSONValueHandler handler_Alerts = new JSONValueHandler();
            storeAlerts[num1].write_as_json(handler_Alerts);
            generated_array_1_Alerts.appendComponent(handler_Alerts.result);
          }
        return generated_array_1_Alerts;
      }

    private JSONValue  extraRequestedAttributeToJSON()
      {
        JSONValueHandler handler_RequestedAttribute = new JSONValueHandler();
        storeRequestedAttribute.write_as_json(handler_RequestedAttribute);
        return handler_RequestedAttribute.result;
      }

    private JSONValue  extraRequestedStartDateAndTimeToJSON()
      {
        JSONValueHandler handler_RequestedStartDateAndTime = new JSONValueHandler();
        storeRequestedStartDateAndTime.write_as_json(handler_RequestedStartDateAndTime);
        return handler_RequestedStartDateAndTime.result;
      }

    private JSONValue  extraRequestedEndDateAndTimeToJSON()
      {
        JSONValueHandler handler_RequestedEndDateAndTime = new JSONValueHandler();
        storeRequestedEndDateAndTime.write_as_json(handler_RequestedEndDateAndTime);
        return handler_RequestedEndDateAndTime.result;
      }

    private JSONValue  extraRequestedStartDateTimeSpecToJSON()
      {
        JSONValueHandler handler_RequestedStartDateTimeSpec = new JSONValueHandler();
        storeRequestedStartDateTimeSpec.write_as_json(handler_RequestedStartDateTimeSpec);
        return handler_RequestedStartDateTimeSpec.result;
      }

    private JSONValue  extraRequestedEndDateTimeSpecToJSON()
      {
        JSONValueHandler handler_RequestedEndDateTimeSpec = new JSONValueHandler();
        storeRequestedEndDateTimeSpec.write_as_json(handler_RequestedEndDateTimeSpec);
        return handler_RequestedEndDateTimeSpec.result;
      }

    private JSONValue  extraPlannerToJSON()
      {
        JSONValueHandler handler_Planner = new JSONValueHandler();
        storePlanner.write_as_json(handler_Planner);
        return handler_Planner.result;
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AttributionJSON convert_classy = AttributionJSON.from_json(json_value, ignore_extras, true);
        setAttribution(convert_classy);
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    private void  fromJSONAlerts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Alerts of ShowWeatherPlannerInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AlertJSON  > vector_Alerts1 = new List< AlertJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AlertJSON convert_classy = AlertJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Alerts1.Add(convert_classy);
          }
        initAlerts();
        for (int num1 = 0; num1 < vector_Alerts1.Count; ++num1)
            appendAlerts(vector_Alerts1[num1]);
        for (int num1 = 0; num1 < vector_Alerts1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestedAttribute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherAttributeJSON convert_classy = WeatherAttributeJSON.from_json(json_value, ignore_extras, true);
        setRequestedAttribute(convert_classy);
      }


    private void  fromJSONRequestedStartDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setRequestedStartDateAndTime(convert_classy);
      }


    private void  fromJSONRequestedEndDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setRequestedEndDateAndTime(convert_classy);
      }


    private void  fromJSONRequestedStartDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setRequestedStartDateTimeSpec(convert_classy);
      }


    private void  fromJSONRequestedEndDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setRequestedEndDateTimeSpec(convert_classy);
      }


    private void  fromJSONPlanner(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PlannerJSON convert_classy = PlannerJSON.from_json(json_value, ignore_extras, true);
        setPlanner(convert_classy);
      }


    public ShowWeatherPlannerInformationNuggetJSON()
      {
        flagHasAttribution = false;
        flagHasLocation = false;
        flagHasAlerts = false;
        flagHasRequestedAttribute = false;
        flagHasRequestedStartDateAndTime = false;
        flagHasRequestedEndDateAndTime = false;
        flagHasRequestedStartDateTimeSpec = false;
        flagHasRequestedEndDateTimeSpec = false;
        flagHasPlanner = false;
        storeAlerts = new List< AlertJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getWeatherNuggetKind()
      {
        return "ShowWeatherPlanner";
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

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public MapLocationJSON   getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }

    public bool  hasAlerts()
      {
        return flagHasAlerts;
      }

    public int  countOfAlerts()
      {
        Debug.Assert(flagHasAlerts);
        return storeAlerts.Count;
      }

    public AlertJSON   elementOfAlerts(int element_num)
      {
        Debug.Assert(flagHasAlerts);
        return storeAlerts[element_num];
      }

    public List< AlertJSON  >  getAlerts()
      {
        Debug.Assert(flagHasAlerts);
        return storeAlerts;
      }

    public bool  hasRequestedAttribute()
      {
        return flagHasRequestedAttribute;
      }

    public WeatherAttributeJSON   getRequestedAttribute()
      {
        Debug.Assert(flagHasRequestedAttribute);
        return storeRequestedAttribute;
      }

    public WeatherAttributeJSON.TypeValue  getRequestedAttributeValue()
      {
        return getRequestedAttribute().getValue();
      }

    public string  getRequestedAttributeAsString()
      {
        return getRequestedAttribute().getValueAsString();
      }

    public bool  hasRequestedStartDateAndTime()
      {
        return flagHasRequestedStartDateAndTime;
      }

    public DateAndOrTimeJSON   getRequestedStartDateAndTime()
      {
        Debug.Assert(flagHasRequestedStartDateAndTime);
        return storeRequestedStartDateAndTime;
      }

    public bool  hasRequestedEndDateAndTime()
      {
        return flagHasRequestedEndDateAndTime;
      }

    public DateAndOrTimeJSON   getRequestedEndDateAndTime()
      {
        Debug.Assert(flagHasRequestedEndDateAndTime);
        return storeRequestedEndDateAndTime;
      }

    public bool  hasRequestedStartDateTimeSpec()
      {
        return flagHasRequestedStartDateTimeSpec;
      }

    public DateTimeSpecJSON   getRequestedStartDateTimeSpec()
      {
        Debug.Assert(flagHasRequestedStartDateTimeSpec);
        return storeRequestedStartDateTimeSpec;
      }

    public bool  hasRequestedEndDateTimeSpec()
      {
        return flagHasRequestedEndDateTimeSpec;
      }

    public DateTimeSpecJSON   getRequestedEndDateTimeSpec()
      {
        Debug.Assert(flagHasRequestedEndDateTimeSpec);
        return storeRequestedEndDateTimeSpec;
      }

    public bool  hasPlanner()
      {
        return flagHasPlanner;
      }

    public PlannerJSON   getPlanner()
      {
        Debug.Assert(flagHasPlanner);
        return storePlanner;
      }


    public virtual int extraShowWeatherPlannerInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraShowWeatherPlannerInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraShowWeatherPlannerInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraShowWeatherPlannerInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraWeatherInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasAttribution)
            ++result;
        if (flagHasLocation)
            ++result;
        if (flagHasAlerts)
            ++result;
        if (flagHasRequestedAttribute)
            ++result;
        if (flagHasRequestedStartDateAndTime)
            ++result;
        if (flagHasRequestedEndDateAndTime)
            ++result;
        if (flagHasRequestedStartDateTimeSpec)
            ++result;
        if (flagHasRequestedEndDateTimeSpec)
            ++result;
        if (flagHasPlanner)
            ++result;
        result += extraShowWeatherPlannerInformationNuggetComponentCount();
        return result;
      }
    public override string extraWeatherInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return "Attribution";
            --remainder;
          }
        if (flagHasLocation)
          {
            if (remainder == 0)
                return "Location";
            --remainder;
          }
        if (flagHasAlerts)
          {
            if (remainder == 0)
                return "Alerts";
            --remainder;
          }
        if (flagHasRequestedAttribute)
          {
            if (remainder == 0)
                return "RequestedAttribute";
            --remainder;
          }
        if (flagHasRequestedStartDateAndTime)
          {
            if (remainder == 0)
                return "RequestedStartDateAndTime";
            --remainder;
          }
        if (flagHasRequestedEndDateAndTime)
          {
            if (remainder == 0)
                return "RequestedEndDateAndTime";
            --remainder;
          }
        if (flagHasRequestedStartDateTimeSpec)
          {
            if (remainder == 0)
                return "RequestedStartDateTimeSpec";
            --remainder;
          }
        if (flagHasRequestedEndDateTimeSpec)
          {
            if (remainder == 0)
                return "RequestedEndDateTimeSpec";
            --remainder;
          }
        if (flagHasPlanner)
          {
            if (remainder == 0)
                return "Planner";
            --remainder;
          }
        return extraShowWeatherPlannerInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraWeatherInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasAttribution)
          {
            if (remainder == 0)
                return extraAttributionToJSON();
            --remainder;
          }
        if (flagHasLocation)
          {
            if (remainder == 0)
                return extraLocationToJSON();
            --remainder;
          }
        if (flagHasAlerts)
          {
            if (remainder == 0)
                return extraAlertsToJSON();
            --remainder;
          }
        if (flagHasRequestedAttribute)
          {
            if (remainder == 0)
                return extraRequestedAttributeToJSON();
            --remainder;
          }
        if (flagHasRequestedStartDateAndTime)
          {
            if (remainder == 0)
                return extraRequestedStartDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasRequestedEndDateAndTime)
          {
            if (remainder == 0)
                return extraRequestedEndDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasRequestedStartDateTimeSpec)
          {
            if (remainder == 0)
                return extraRequestedStartDateTimeSpecToJSON();
            --remainder;
          }
        if (flagHasRequestedEndDateTimeSpec)
          {
            if (remainder == 0)
                return extraRequestedEndDateTimeSpecToJSON();
            --remainder;
          }
        if (flagHasPlanner)
          {
            if (remainder == 0)
                return extraPlannerToJSON();
            --remainder;
          }
        return extraShowWeatherPlannerInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraWeatherInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                switch (field_name[1])
                  {
                    case 'l':
                        if ((String.Compare(field_name, 2, "erts", 0, 4, false) == 0) && (field_name.Length == 6))
                            return (flagHasAlerts ? extraAlertsToJSON() : null);
                        break;
                    case 't':
                        if ((String.Compare(field_name, 2, "tribution", 0, 9, false) == 0) && (field_name.Length == 11))
                            return (flagHasAttribution ? extraAttributionToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasLocation ? extraLocationToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "lanner", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasPlanner ? extraPlannerToJSON() : null);
                break;
            case 'R':
                if (String.Compare(field_name, 1, "equested", 0, 8, false) == 0)
                  {
                    switch (field_name[9])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 10, "ttribute", 0, 8, false) == 0) && (field_name.Length == 18))
                                return (flagHasRequestedAttribute ? extraRequestedAttributeToJSON() : null);
                            break;
                        case 'E':
                            if (String.Compare(field_name, 10, "ndDate", 0, 6, false) == 0)
                              {
                                switch (field_name[16])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 17, "ndTime", 0, 6, false) == 0) && (field_name.Length == 23))
                                            return (flagHasRequestedEndDateAndTime ? extraRequestedEndDateAndTimeToJSON() : null);
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 17, "imeSpec", 0, 7, false) == 0) && (field_name.Length == 24))
                                            return (flagHasRequestedEndDateTimeSpec ? extraRequestedEndDateTimeSpecToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if (String.Compare(field_name, 10, "tartDate", 0, 8, false) == 0)
                              {
                                switch (field_name[18])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 19, "ndTime", 0, 6, false) == 0) && (field_name.Length == 25))
                                            return (flagHasRequestedStartDateAndTime ? extraRequestedStartDateAndTimeToJSON() : null);
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 19, "imeSpec", 0, 7, false) == 0) && (field_name.Length == 26))
                                            return (flagHasRequestedStartDateTimeSpec ? extraRequestedStartDateTimeSpecToJSON() : null);
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
            default:
                break;
          }
        return extraShowWeatherPlannerInformationNuggetLookup(field_name);
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
    public void initAlerts()
      {
        if (flagHasAlerts)
          {
            for (int num1 = 0; num1 < storeAlerts.Count; ++num1)
              {
              }
          }
        flagHasAlerts = true;
        storeAlerts.Clear();
      }
    public void appendAlerts(AlertJSON  to_append)
      {
        if (!flagHasAlerts)
          {
            flagHasAlerts = true;
            storeAlerts.Clear();
          }
        Debug.Assert(flagHasAlerts);
        storeAlerts.Add(to_append);
      }
    public void unsetAlerts()
      {
        if (flagHasAlerts)
          {
            for (int num2 = 0; num2 < storeAlerts.Count; ++num2)
              {
              }
          }
        flagHasAlerts = false;
        storeAlerts.Clear();
      }
    public void setRequestedAttribute(WeatherAttributeJSON  new_value)
      {
        if (flagHasRequestedAttribute)
          {
          }
        flagHasRequestedAttribute = true;
        storeRequestedAttribute = new_value;
      }
    public void setRequestedAttribute(WeatherAttributeJSON.TypeValue new_value)
      {
        setRequestedAttribute(new WeatherAttributeJSON(new_value));
      }
    public void setRequestedAttribute(string chars)
      {
        WeatherAttributeJSON.TypeValueKnownValues known = WeatherAttributeJSON.stringToValue(chars);
        WeatherAttributeJSON.TypeValue new_value = new WeatherAttributeJSON.TypeValue();
        if (known == WeatherAttributeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRequestedAttribute(new_value);
      }
    public void unsetRequestedAttribute()
      {
        if (flagHasRequestedAttribute)
          {
          }
        flagHasRequestedAttribute = false;
      }
    public void setRequestedStartDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasRequestedStartDateAndTime)
          {
          }
        flagHasRequestedStartDateAndTime = true;
        storeRequestedStartDateAndTime = new_value;
      }
    public void unsetRequestedStartDateAndTime()
      {
        if (flagHasRequestedStartDateAndTime)
          {
          }
        flagHasRequestedStartDateAndTime = false;
      }
    public void setRequestedEndDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasRequestedEndDateAndTime)
          {
          }
        flagHasRequestedEndDateAndTime = true;
        storeRequestedEndDateAndTime = new_value;
      }
    public void unsetRequestedEndDateAndTime()
      {
        if (flagHasRequestedEndDateAndTime)
          {
          }
        flagHasRequestedEndDateAndTime = false;
      }
    public void setRequestedStartDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasRequestedStartDateTimeSpec)
          {
          }
        flagHasRequestedStartDateTimeSpec = true;
        storeRequestedStartDateTimeSpec = new_value;
      }
    public void unsetRequestedStartDateTimeSpec()
      {
        if (flagHasRequestedStartDateTimeSpec)
          {
          }
        flagHasRequestedStartDateTimeSpec = false;
      }
    public void setRequestedEndDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasRequestedEndDateTimeSpec)
          {
          }
        flagHasRequestedEndDateTimeSpec = true;
        storeRequestedEndDateTimeSpec = new_value;
      }
    public void unsetRequestedEndDateTimeSpec()
      {
        if (flagHasRequestedEndDateTimeSpec)
          {
          }
        flagHasRequestedEndDateTimeSpec = false;
      }
    public void setPlanner(PlannerJSON  new_value)
      {
        if (flagHasPlanner)
          {
          }
        flagHasPlanner = true;
        storePlanner = new_value;
      }
    public void unsetPlanner()
      {
        if (flagHasPlanner)
          {
          }
        flagHasPlanner = false;
      }

    public virtual void extraShowWeatherPlannerInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraShowWeatherPlannerInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraShowWeatherPlannerInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraShowWeatherPlannerInformationNuggetAppendPair(key, new_component);
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
    public override void extraWeatherInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        if ((String.Compare(key, 2, "erts", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONAlerts(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "tribution", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONAttribution(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "lanner", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONPlanner(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if (String.Compare(key, 1, "equested", 0, 8, false) == 0)
                  {
                    switch (key[9])
                      {
                        case 'A':
                            if ((String.Compare(key, 10, "ttribute", 0, 8, false) == 0) && (key.Length == 18))
                                {
                                fromJSONRequestedAttribute(new_component, false);
                                return;
                                }
                            break;
                        case 'E':
                            if (String.Compare(key, 10, "ndDate", 0, 6, false) == 0)
                              {
                                switch (key[16])
                                  {
                                    case 'A':
                                        if ((String.Compare(key, 17, "ndTime", 0, 6, false) == 0) && (key.Length == 23))
                                            {
                                            fromJSONRequestedEndDateAndTime(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'T':
                                        if ((String.Compare(key, 17, "imeSpec", 0, 7, false) == 0) && (key.Length == 24))
                                            {
                                            fromJSONRequestedEndDateTimeSpec(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if (String.Compare(key, 10, "tartDate", 0, 8, false) == 0)
                              {
                                switch (key[18])
                                  {
                                    case 'A':
                                        if ((String.Compare(key, 19, "ndTime", 0, 6, false) == 0) && (key.Length == 25))
                                            {
                                            fromJSONRequestedStartDateAndTime(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'T':
                                        if ((String.Compare(key, 19, "imeSpec", 0, 7, false) == 0) && (key.Length == 26))
                                            {
                                            fromJSONRequestedStartDateTimeSpec(new_component, false);
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
            default:
                break;
          }
        extraShowWeatherPlannerInformationNuggetAppendPair(key, new_component);
      }
    public override void extraWeatherInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        if ((String.Compare(key, 2, "erts", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONAlerts(new_component, false);
                            return;
                            }
                        break;
                    case 't':
                        if ((String.Compare(key, 2, "tribution", 0, 9, false) == 0) && (key.Length == 11))
                            {
                            fromJSONAttribution(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'L':
                if ((String.Compare(key, 1, "ocation", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONLocation(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "lanner", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONPlanner(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if (String.Compare(key, 1, "equested", 0, 8, false) == 0)
                  {
                    switch (key[9])
                      {
                        case 'A':
                            if ((String.Compare(key, 10, "ttribute", 0, 8, false) == 0) && (key.Length == 18))
                                {
                                fromJSONRequestedAttribute(new_component, false);
                                return;
                                }
                            break;
                        case 'E':
                            if (String.Compare(key, 10, "ndDate", 0, 6, false) == 0)
                              {
                                switch (key[16])
                                  {
                                    case 'A':
                                        if ((String.Compare(key, 17, "ndTime", 0, 6, false) == 0) && (key.Length == 23))
                                            {
                                            fromJSONRequestedEndDateAndTime(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'T':
                                        if ((String.Compare(key, 17, "imeSpec", 0, 7, false) == 0) && (key.Length == 24))
                                            {
                                            fromJSONRequestedEndDateTimeSpec(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'S':
                            if (String.Compare(key, 10, "tartDate", 0, 8, false) == 0)
                              {
                                switch (key[18])
                                  {
                                    case 'A':
                                        if ((String.Compare(key, 19, "ndTime", 0, 6, false) == 0) && (key.Length == 25))
                                            {
                                            fromJSONRequestedStartDateAndTime(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'T':
                                        if ((String.Compare(key, 19, "imeSpec", 0, 7, false) == 0) && (key.Length == 26))
                                            {
                                            fromJSONRequestedStartDateTimeSpec(new_component, false);
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
            default:
                break;
          }
        extraShowWeatherPlannerInformationNuggetSetField(key, new_component);
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
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (partial_allowed)
                storeAttribution.write_partial_as_json(handler);
            else
                storeAttribution.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasLocation);
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            if (partial_allowed)
                storeLocation.write_partial_as_json(handler);
            else
                storeLocation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasAlerts);
        if (flagHasAlerts)
          {
            handler.start_pair("Alerts");
            handler.start_array();
            for (int num1 = 0; num1 < storeAlerts.Count; ++num1)
              {
                if (partial_allowed)
                    storeAlerts[num1].write_partial_as_json(handler);
                else
                    storeAlerts[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasRequestedAttribute);
        if (flagHasRequestedAttribute)
          {
            handler.start_pair("RequestedAttribute");
            if (partial_allowed)
                storeRequestedAttribute.write_partial_as_json(handler);
            else
                storeRequestedAttribute.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRequestedStartDateAndTime);
        if (flagHasRequestedStartDateAndTime)
          {
            handler.start_pair("RequestedStartDateAndTime");
            if (partial_allowed)
                storeRequestedStartDateAndTime.write_partial_as_json(handler);
            else
                storeRequestedStartDateAndTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRequestedEndDateAndTime);
        if (flagHasRequestedEndDateAndTime)
          {
            handler.start_pair("RequestedEndDateAndTime");
            if (partial_allowed)
                storeRequestedEndDateAndTime.write_partial_as_json(handler);
            else
                storeRequestedEndDateAndTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRequestedStartDateTimeSpec);
        if (flagHasRequestedStartDateTimeSpec)
          {
            handler.start_pair("RequestedStartDateTimeSpec");
            if (partial_allowed)
                storeRequestedStartDateTimeSpec.write_partial_as_json(handler);
            else
                storeRequestedStartDateTimeSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRequestedEndDateTimeSpec);
        if (flagHasRequestedEndDateTimeSpec)
          {
            handler.start_pair("RequestedEndDateTimeSpec");
            if (partial_allowed)
                storeRequestedEndDateTimeSpec.write_partial_as_json(handler);
            else
                storeRequestedEndDateTimeSpec.write_as_json(handler);
          }
        if (flagHasPlanner)
          {
            handler.start_pair("Planner");
            if (partial_allowed)
                storePlanner.write_partial_as_json(handler);
            else
                storePlanner.write_as_json(handler);
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
        if (!(hasLocation()))
          {
            return "When parsing the object for %what%, the \"Location\" field was missing.";
          }
        if (!(hasAlerts()))
          {
            return "When parsing the object for %what%, the \"Alerts\" field was missing.";
          }
        if (!(hasRequestedAttribute()))
          {
            return "When parsing the object for %what%, the \"RequestedAttribute\" field was missing.";
          }
        if (!(hasRequestedStartDateAndTime()))
          {
            return "When parsing the object for %what%, the \"RequestedStartDateAndTime\" field was missing.";
          }
        if (!(hasRequestedEndDateAndTime()))
          {
            return "When parsing the object for %what%, the \"RequestedEndDateAndTime\" field was missing.";
          }
        if (!(hasRequestedStartDateTimeSpec()))
          {
            return "When parsing the object for %what%, the \"RequestedStartDateTimeSpec\" field was missing.";
          }
        if (!(hasRequestedEndDateTimeSpec()))
          {
            return "When parsing the object for %what%, the \"RequestedEndDateTimeSpec\" field was missing.";
          }
        return null;
      }

    public static new ShowWeatherPlannerInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowWeatherPlannerInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherPlannerInformationNugget", ignore_extras);
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
    public static new ShowWeatherPlannerInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowWeatherPlannerInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowWeatherPlannerInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherPlannerInformationNugget", ignore_extras);
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
    public static new ShowWeatherPlannerInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowWeatherPlannerInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ShowWeatherPlannerInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherPlannerInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ShowWeatherPlannerInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ShowWeatherPlannerInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ShowWeatherPlannerInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowWeatherPlannerInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : WeatherInformationNuggetJSON.Generator
      {
        private AttributionJSON.HoldingGenerator fieldGeneratorAttribution;
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
        private AlertJSON.HoldingArrayGenerator fieldGeneratorAlerts;
        private WeatherAttributeJSON.HoldingGenerator fieldGeneratorRequestedAttribute;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorRequestedStartDateAndTime;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorRequestedEndDateAndTime;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorRequestedStartDateTimeSpec;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorRequestedEndDateTimeSpec;
        private PlannerJSON.HoldingGenerator fieldGeneratorPlanner;
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
            if (!(getWeatherInformationNuggetJSONKey().Equals("ShowWeatherPlanner")))
                throw new Exception("The key field has a value other than `ShowWeatherPlanner'.");
            ShowWeatherPlannerInformationNuggetJSON result = new ShowWeatherPlannerInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraShowWeatherPlannerInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(WeatherInformationNuggetJSON new_result)
          {
            handle_result((ShowWeatherPlannerInformationNuggetJSON )new_result);
          }
        protected void finish(ShowWeatherPlannerInformationNuggetJSON result)
          {
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
            else if ((!(result.hasLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Location\" field was missing.");
              }
            if (fieldGeneratorAlerts.have_value)
              {
                result.initAlerts();
                int count = fieldGeneratorAlerts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlerts(fieldGeneratorAlerts.value[num]);
                  }
                fieldGeneratorAlerts.value.Clear();
                fieldGeneratorAlerts.have_value = false;
              }
            else if ((!(result.hasAlerts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Alerts\" field was missing.");
              }
            if (fieldGeneratorRequestedAttribute.have_value)
              {
                result.setRequestedAttribute(fieldGeneratorRequestedAttribute.value);
                fieldGeneratorRequestedAttribute.have_value = false;
              }
            else if ((!(result.hasRequestedAttribute())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedAttribute\" field was missing.");
              }
            if (fieldGeneratorRequestedStartDateAndTime.have_value)
              {
                result.setRequestedStartDateAndTime(fieldGeneratorRequestedStartDateAndTime.value);
                fieldGeneratorRequestedStartDateAndTime.have_value = false;
              }
            else if ((!(result.hasRequestedStartDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedStartDateAndTime\" field was missing.");
              }
            if (fieldGeneratorRequestedEndDateAndTime.have_value)
              {
                result.setRequestedEndDateAndTime(fieldGeneratorRequestedEndDateAndTime.value);
                fieldGeneratorRequestedEndDateAndTime.have_value = false;
              }
            else if ((!(result.hasRequestedEndDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedEndDateAndTime\" field was missing.");
              }
            if (fieldGeneratorRequestedStartDateTimeSpec.have_value)
              {
                result.setRequestedStartDateTimeSpec(fieldGeneratorRequestedStartDateTimeSpec.value);
                fieldGeneratorRequestedStartDateTimeSpec.have_value = false;
              }
            else if ((!(result.hasRequestedStartDateTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedStartDateTimeSpec\" field was missing.");
              }
            if (fieldGeneratorRequestedEndDateTimeSpec.have_value)
              {
                result.setRequestedEndDateTimeSpec(fieldGeneratorRequestedEndDateTimeSpec.value);
                fieldGeneratorRequestedEndDateTimeSpec.have_value = false;
              }
            else if ((!(result.hasRequestedEndDateTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedEndDateTimeSpec\" field was missing.");
              }
            if (fieldGeneratorPlanner.have_value)
              {
                result.setPlanner(fieldGeneratorPlanner.value);
                fieldGeneratorPlanner.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ShowWeatherPlannerInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "erts", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorAlerts;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "tribution", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorAttribution;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "lanner", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorPlanner;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "equested", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 10, "ttribute", 0, 8, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorRequestedAttribute;
                                break;
                            case 'E':
                                if (String.Compare(field_name, 10, "ndDate", 0, 6, false) == 0)
                                  {
                                    switch (field_name[16])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 17, "ndTime", 0, 6, false) == 0) && (field_name.Length == 23))
                                                return fieldGeneratorRequestedEndDateAndTime;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 17, "imeSpec", 0, 7, false) == 0) && (field_name.Length == 24))
                                                return fieldGeneratorRequestedEndDateTimeSpec;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'S':
                                if (String.Compare(field_name, 10, "tartDate", 0, 8, false) == 0)
                                  {
                                    switch (field_name[18])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 19, "ndTime", 0, 6, false) == 0) && (field_name.Length == 25))
                                                return fieldGeneratorRequestedStartDateAndTime;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 19, "imeSpec", 0, 7, false) == 0) && (field_name.Length == 26))
                                                return fieldGeneratorRequestedStartDateTimeSpec;
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
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the ShowWeatherPlannerInformationNugget class", ignore_extras);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the ShowWeatherPlannerInformationNugget class", ignore_extras);
            fieldGeneratorAlerts = new AlertJSON.HoldingArrayGenerator("field \"Alerts\" of the ShowWeatherPlannerInformationNugget class", ignore_extras);
            fieldGeneratorRequestedAttribute = new WeatherAttributeJSON.HoldingGenerator("field \"RequestedAttribute\" of the ShowWeatherPlannerInformationNugget class", ignore_extras);
            fieldGeneratorRequestedStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"RequestedStartDateAndTime\" of the ShowWeatherPlannerInformationNugget class", ignore_extras);
            fieldGeneratorRequestedEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"RequestedEndDateAndTime\" of the ShowWeatherPlannerInformationNugget class", ignore_extras);
            fieldGeneratorRequestedStartDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"RequestedStartDateTimeSpec\" of the ShowWeatherPlannerInformationNugget class", ignore_extras);
            fieldGeneratorRequestedEndDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"RequestedEndDateTimeSpec\" of the ShowWeatherPlannerInformationNugget class", ignore_extras);
            fieldGeneratorPlanner = new PlannerJSON.HoldingGenerator("field \"Planner\" of the ShowWeatherPlannerInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ShowWeatherPlannerInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the ShowWeatherPlannerInformationNugget class", false);
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the ShowWeatherPlannerInformationNugget class", false);
            fieldGeneratorAlerts = new AlertJSON.HoldingArrayGenerator("field \"Alerts\" of the ShowWeatherPlannerInformationNugget class", false);
            fieldGeneratorRequestedAttribute = new WeatherAttributeJSON.HoldingGenerator("field \"RequestedAttribute\" of the ShowWeatherPlannerInformationNugget class", false);
            fieldGeneratorRequestedStartDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"RequestedStartDateAndTime\" of the ShowWeatherPlannerInformationNugget class", false);
            fieldGeneratorRequestedEndDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"RequestedEndDateAndTime\" of the ShowWeatherPlannerInformationNugget class", false);
            fieldGeneratorRequestedStartDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"RequestedStartDateTimeSpec\" of the ShowWeatherPlannerInformationNugget class", false);
            fieldGeneratorRequestedEndDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"RequestedEndDateTimeSpec\" of the ShowWeatherPlannerInformationNugget class", false);
            fieldGeneratorPlanner = new PlannerJSON.HoldingGenerator("field \"Planner\" of the ShowWeatherPlannerInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ShowWeatherPlannerInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorAttribution.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorAlerts.reset();
            fieldGeneratorRequestedAttribute.reset();
            fieldGeneratorRequestedStartDateAndTime.reset();
            fieldGeneratorRequestedEndDateAndTime.reset();
            fieldGeneratorRequestedStartDateTimeSpec.reset();
            fieldGeneratorRequestedEndDateTimeSpec.reset();
            fieldGeneratorPlanner.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ShowWeatherPlannerInformationNuggetJSON  result)
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
        public ShowWeatherPlannerInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ShowWeatherPlannerInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ShowWeatherPlannerInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ShowWeatherPlannerInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ShowWeatherPlannerInformationNuggetJSON>();
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
    public List<ShowWeatherPlannerInformationNuggetJSON> value;
  };
  };
