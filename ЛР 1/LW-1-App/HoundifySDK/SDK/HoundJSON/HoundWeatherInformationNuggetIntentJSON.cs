/* file "HoundWeatherInformationNuggetIntentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HoundWeatherInformationNuggetIntentJSON : InformationNuggetIntentJSON
  {
    private bool flagHasWeatherIntentKind;
    private string storeWeatherIntentKind;
    private bool flagHasWeatherQueryType;
    private string storeWeatherQueryType;
    private bool flagHasRequestedAttribute;
    private WeatherAttributeJSON  storeRequestedAttribute;
    private bool flagHasRequestedAttributeAction;
    private WeatherAttributeActionJSON  storeRequestedAttributeAction;
    private bool flagHasIsSearchQuery;
    private bool storeIsSearchQuery;
    private bool flagHasMapLocation;
    private MapLocationJSON  storeMapLocation;
    private bool flagHasDateTimeRange;
    private DateTimeRangeSpecJSON  storeDateTimeRange;
    private bool flagHasUnits;
    private WeatherUnitsFormatJSON  storeUnits;
    private bool flagHasIsYesNoQuery;
    private bool storeIsYesNoQuery;
    private bool flagHasDailyForecastExplicitlyRequested;
    private bool storeDailyForecastExplicitlyRequested;
    private bool flagHasHourlyForecastExplicitlyRequested;
    private bool storeHourlyForecastExplicitlyRequested;
    private bool flagHasDisplayDaily;
    private bool storeDisplayDaily;
    private bool flagHasDisplayHourly;
    private bool storeDisplayHourly;
    private bool flagHasSetOfTime;
    private SetOfTimeJSON  storeSetOfTime;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraWeatherIntentKindToJSON()
      {
        JSONStringValue generated_string_WeatherIntentKind = new JSONStringValue(storeWeatherIntentKind);
        return generated_string_WeatherIntentKind;
      }

    private JSONValue  extraWeatherQueryTypeToJSON()
      {
        JSONStringValue generated_string_WeatherQueryType = new JSONStringValue(storeWeatherQueryType);
        return generated_string_WeatherQueryType;
      }

    private JSONValue  extraRequestedAttributeToJSON()
      {
        JSONValueHandler handler_RequestedAttribute = new JSONValueHandler();
        storeRequestedAttribute.write_as_json(handler_RequestedAttribute);
        return handler_RequestedAttribute.result;
      }

    private JSONValue  extraRequestedAttributeActionToJSON()
      {
        JSONValueHandler handler_RequestedAttributeAction = new JSONValueHandler();
        storeRequestedAttributeAction.write_as_json(handler_RequestedAttributeAction);
        return handler_RequestedAttributeAction.result;
      }

    private JSONValue  extraIsSearchQueryToJSON()
      {
        JSONValue generated_boolean_IsSearchQuery = (storeIsSearchQuery ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsSearchQuery;
      }

    private JSONValue  extraMapLocationToJSON()
      {
        JSONValueHandler handler_MapLocation = new JSONValueHandler();
        storeMapLocation.write_as_json(handler_MapLocation);
        return handler_MapLocation.result;
      }

    private JSONValue  extraDateTimeRangeToJSON()
      {
        JSONValueHandler handler_DateTimeRange = new JSONValueHandler();
        storeDateTimeRange.write_as_json(handler_DateTimeRange);
        return handler_DateTimeRange.result;
      }

    private JSONValue  extraUnitsToJSON()
      {
        JSONValueHandler handler_Units = new JSONValueHandler();
        storeUnits.write_as_json(handler_Units);
        return handler_Units.result;
      }

    private JSONValue  extraIsYesNoQueryToJSON()
      {
        JSONValue generated_boolean_IsYesNoQuery = (storeIsYesNoQuery ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsYesNoQuery;
      }

    private JSONValue  extraDailyForecastExplicitlyRequestedToJSON()
      {
        JSONValue generated_boolean_DailyForecastExplicitlyRequested = (storeDailyForecastExplicitlyRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DailyForecastExplicitlyRequested;
      }

    private JSONValue  extraHourlyForecastExplicitlyRequestedToJSON()
      {
        JSONValue generated_boolean_HourlyForecastExplicitlyRequested = (storeHourlyForecastExplicitlyRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_HourlyForecastExplicitlyRequested;
      }

    private JSONValue  extraDisplayDailyToJSON()
      {
        JSONValue generated_boolean_DisplayDaily = (storeDisplayDaily ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DisplayDaily;
      }

    private JSONValue  extraDisplayHourlyToJSON()
      {
        JSONValue generated_boolean_DisplayHourly = (storeDisplayHourly ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DisplayHourly;
      }

    private JSONValue  extraSetOfTimeToJSON()
      {
        JSONValueHandler handler_SetOfTime = new JSONValueHandler();
        storeSetOfTime.write_as_json(handler_SetOfTime);
        return handler_SetOfTime.result;
      }


    private void  fromJSONWeatherIntentKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WeatherIntentKind of HoundWeatherInformationNuggetIntentJSON is not a string.");
        setWeatherIntentKind(json_string.getData());
      }


    private void  fromJSONWeatherQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WeatherQueryType of HoundWeatherInformationNuggetIntentJSON is not a string.");
        setWeatherQueryType(json_string.getData());
      }


    private void  fromJSONRequestedAttribute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherAttributeJSON convert_classy = WeatherAttributeJSON.from_json(json_value, ignore_extras, true);
        setRequestedAttribute(convert_classy);
      }


    private void  fromJSONRequestedAttributeAction(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherAttributeActionJSON convert_classy = WeatherAttributeActionJSON.from_json(json_value, ignore_extras, true);
        setRequestedAttributeAction(convert_classy);
      }


    private void  fromJSONIsSearchQuery(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsSearchQuery of HoundWeatherInformationNuggetIntentJSON is not true for false.");
              }
          }
        setIsSearchQuery(the_bool);
      }


    private void  fromJSONMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setMapLocation(convert_classy);
      }


    private void  fromJSONDateTimeRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateTimeRange(convert_classy);
      }


    private void  fromJSONUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherUnitsFormatJSON convert_classy = WeatherUnitsFormatJSON.from_json(json_value, ignore_extras, true);
        setUnits(convert_classy);
      }


    private void  fromJSONIsYesNoQuery(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsYesNoQuery of HoundWeatherInformationNuggetIntentJSON is not true for false.");
              }
          }
        setIsYesNoQuery(the_bool);
      }


    private void  fromJSONDailyForecastExplicitlyRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DailyForecastExplicitlyRequested of HoundWeatherInformationNuggetIntentJSON is not true for false.");
              }
          }
        setDailyForecastExplicitlyRequested(the_bool);
      }


    private void  fromJSONHourlyForecastExplicitlyRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HourlyForecastExplicitlyRequested of HoundWeatherInformationNuggetIntentJSON is not true for false.");
              }
          }
        setHourlyForecastExplicitlyRequested(the_bool);
      }


    private void  fromJSONDisplayDaily(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DisplayDaily of HoundWeatherInformationNuggetIntentJSON is not true for false.");
              }
          }
        setDisplayDaily(the_bool);
      }


    private void  fromJSONDisplayHourly(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DisplayHourly of HoundWeatherInformationNuggetIntentJSON is not true for false.");
              }
          }
        setDisplayHourly(the_bool);
      }


    private void  fromJSONSetOfTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SetOfTimeJSON convert_classy = SetOfTimeJSON.from_json(json_value, ignore_extras, true);
        setSetOfTime(convert_classy);
      }


    public HoundWeatherInformationNuggetIntentJSON()
      {
        flagHasWeatherIntentKind = false;
        flagHasWeatherQueryType = false;
        flagHasRequestedAttribute = false;
        flagHasRequestedAttributeAction = false;
        flagHasIsSearchQuery = false;
        flagHasMapLocation = false;
        flagHasDateTimeRange = false;
        flagHasUnits = false;
        flagHasIsYesNoQuery = false;
        flagHasDailyForecastExplicitlyRequested = false;
        flagHasHourlyForecastExplicitlyRequested = false;
        flagHasDisplayDaily = false;
        flagHasDisplayHourly = false;
        flagHasSetOfTime = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetIntentKind()
      {
        return "HoundWeather";
      }

    public bool  hasWeatherIntentKind()
      {
        return flagHasWeatherIntentKind;
      }

    public string  getWeatherIntentKind()
      {
        Debug.Assert(flagHasWeatherIntentKind);
        return storeWeatherIntentKind;
      }

    public bool  hasWeatherQueryType()
      {
        return flagHasWeatherQueryType;
      }

    public string  getWeatherQueryType()
      {
        Debug.Assert(flagHasWeatherQueryType);
        return storeWeatherQueryType;
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

    public bool  hasRequestedAttributeAction()
      {
        return flagHasRequestedAttributeAction;
      }

    public WeatherAttributeActionJSON   getRequestedAttributeAction()
      {
        Debug.Assert(flagHasRequestedAttributeAction);
        return storeRequestedAttributeAction;
      }

    public WeatherAttributeActionJSON.TypeValue  getRequestedAttributeActionValue()
      {
        return getRequestedAttributeAction().getValue();
      }

    public string  getRequestedAttributeActionAsString()
      {
        return getRequestedAttributeAction().getValueAsString();
      }

    public bool  hasIsSearchQuery()
      {
        return flagHasIsSearchQuery;
      }

    public bool  getIsSearchQuery()
      {
        Debug.Assert(flagHasIsSearchQuery);
        return storeIsSearchQuery;
      }

    public bool  hasMapLocation()
      {
        return flagHasMapLocation;
      }

    public MapLocationJSON   getMapLocation()
      {
        Debug.Assert(flagHasMapLocation);
        return storeMapLocation;
      }

    public bool  hasDateTimeRange()
      {
        return flagHasDateTimeRange;
      }

    public DateTimeRangeSpecJSON   getDateTimeRange()
      {
        Debug.Assert(flagHasDateTimeRange);
        return storeDateTimeRange;
      }

    public bool  hasUnits()
      {
        return flagHasUnits;
      }

    public WeatherUnitsFormatJSON   getUnits()
      {
        Debug.Assert(flagHasUnits);
        return storeUnits;
      }

    public WeatherUnitsFormatJSON.TypeValue  getUnitsValue()
      {
        return getUnits().getValue();
      }

    public string  getUnitsAsString()
      {
        return getUnits().getValueAsString();
      }

    public bool  hasIsYesNoQuery()
      {
        return flagHasIsYesNoQuery;
      }

    public bool  getIsYesNoQuery()
      {
        Debug.Assert(flagHasIsYesNoQuery);
        return storeIsYesNoQuery;
      }

    public bool  hasDailyForecastExplicitlyRequested()
      {
        return flagHasDailyForecastExplicitlyRequested;
      }

    public bool  getDailyForecastExplicitlyRequested()
      {
        Debug.Assert(flagHasDailyForecastExplicitlyRequested);
        return storeDailyForecastExplicitlyRequested;
      }

    public bool  hasHourlyForecastExplicitlyRequested()
      {
        return flagHasHourlyForecastExplicitlyRequested;
      }

    public bool  getHourlyForecastExplicitlyRequested()
      {
        Debug.Assert(flagHasHourlyForecastExplicitlyRequested);
        return storeHourlyForecastExplicitlyRequested;
      }

    public bool  hasDisplayDaily()
      {
        return flagHasDisplayDaily;
      }

    public bool  getDisplayDaily()
      {
        Debug.Assert(flagHasDisplayDaily);
        return storeDisplayDaily;
      }

    public bool  hasDisplayHourly()
      {
        return flagHasDisplayHourly;
      }

    public bool  getDisplayHourly()
      {
        Debug.Assert(flagHasDisplayHourly);
        return storeDisplayHourly;
      }

    public bool  hasSetOfTime()
      {
        return flagHasSetOfTime;
      }

    public SetOfTimeJSON   getSetOfTime()
      {
        Debug.Assert(flagHasSetOfTime);
        return storeSetOfTime;
      }


    public virtual int extraHoundWeatherInformationNuggetIntentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHoundWeatherInformationNuggetIntentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHoundWeatherInformationNuggetIntentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHoundWeatherInformationNuggetIntentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetIntentComponentCount()
      {
        int result = 0;
        if (flagHasWeatherIntentKind)
            ++result;
        if (flagHasWeatherQueryType)
            ++result;
        if (flagHasRequestedAttribute)
            ++result;
        if (flagHasRequestedAttributeAction)
            ++result;
        if (flagHasIsSearchQuery)
            ++result;
        if (flagHasMapLocation)
            ++result;
        if (flagHasDateTimeRange)
            ++result;
        if (flagHasUnits)
            ++result;
        if (flagHasIsYesNoQuery)
            ++result;
        if (flagHasDailyForecastExplicitlyRequested)
            ++result;
        if (flagHasHourlyForecastExplicitlyRequested)
            ++result;
        if (flagHasDisplayDaily)
            ++result;
        if (flagHasDisplayHourly)
            ++result;
        if (flagHasSetOfTime)
            ++result;
        result += extraHoundWeatherInformationNuggetIntentComponentCount();
        return result;
      }
    public override string extraInformationNuggetIntentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasWeatherIntentKind)
          {
            if (remainder == 0)
                return "WeatherIntentKind";
            --remainder;
          }
        if (flagHasWeatherQueryType)
          {
            if (remainder == 0)
                return "WeatherQueryType";
            --remainder;
          }
        if (flagHasRequestedAttribute)
          {
            if (remainder == 0)
                return "RequestedAttribute";
            --remainder;
          }
        if (flagHasRequestedAttributeAction)
          {
            if (remainder == 0)
                return "RequestedAttributeAction";
            --remainder;
          }
        if (flagHasIsSearchQuery)
          {
            if (remainder == 0)
                return "IsSearchQuery";
            --remainder;
          }
        if (flagHasMapLocation)
          {
            if (remainder == 0)
                return "MapLocation";
            --remainder;
          }
        if (flagHasDateTimeRange)
          {
            if (remainder == 0)
                return "DateTimeRange";
            --remainder;
          }
        if (flagHasUnits)
          {
            if (remainder == 0)
                return "Units";
            --remainder;
          }
        if (flagHasIsYesNoQuery)
          {
            if (remainder == 0)
                return "IsYesNoQuery";
            --remainder;
          }
        if (flagHasDailyForecastExplicitlyRequested)
          {
            if (remainder == 0)
                return "DailyForecastExplicitlyRequested";
            --remainder;
          }
        if (flagHasHourlyForecastExplicitlyRequested)
          {
            if (remainder == 0)
                return "HourlyForecastExplicitlyRequested";
            --remainder;
          }
        if (flagHasDisplayDaily)
          {
            if (remainder == 0)
                return "DisplayDaily";
            --remainder;
          }
        if (flagHasDisplayHourly)
          {
            if (remainder == 0)
                return "DisplayHourly";
            --remainder;
          }
        if (flagHasSetOfTime)
          {
            if (remainder == 0)
                return "SetOfTime";
            --remainder;
          }
        return extraHoundWeatherInformationNuggetIntentComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetIntentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasWeatherIntentKind)
          {
            if (remainder == 0)
                return extraWeatherIntentKindToJSON();
            --remainder;
          }
        if (flagHasWeatherQueryType)
          {
            if (remainder == 0)
                return extraWeatherQueryTypeToJSON();
            --remainder;
          }
        if (flagHasRequestedAttribute)
          {
            if (remainder == 0)
                return extraRequestedAttributeToJSON();
            --remainder;
          }
        if (flagHasRequestedAttributeAction)
          {
            if (remainder == 0)
                return extraRequestedAttributeActionToJSON();
            --remainder;
          }
        if (flagHasIsSearchQuery)
          {
            if (remainder == 0)
                return extraIsSearchQueryToJSON();
            --remainder;
          }
        if (flagHasMapLocation)
          {
            if (remainder == 0)
                return extraMapLocationToJSON();
            --remainder;
          }
        if (flagHasDateTimeRange)
          {
            if (remainder == 0)
                return extraDateTimeRangeToJSON();
            --remainder;
          }
        if (flagHasUnits)
          {
            if (remainder == 0)
                return extraUnitsToJSON();
            --remainder;
          }
        if (flagHasIsYesNoQuery)
          {
            if (remainder == 0)
                return extraIsYesNoQueryToJSON();
            --remainder;
          }
        if (flagHasDailyForecastExplicitlyRequested)
          {
            if (remainder == 0)
                return extraDailyForecastExplicitlyRequestedToJSON();
            --remainder;
          }
        if (flagHasHourlyForecastExplicitlyRequested)
          {
            if (remainder == 0)
                return extraHourlyForecastExplicitlyRequestedToJSON();
            --remainder;
          }
        if (flagHasDisplayDaily)
          {
            if (remainder == 0)
                return extraDisplayDailyToJSON();
            --remainder;
          }
        if (flagHasDisplayHourly)
          {
            if (remainder == 0)
                return extraDisplayHourlyToJSON();
            --remainder;
          }
        if (flagHasSetOfTime)
          {
            if (remainder == 0)
                return extraSetOfTimeToJSON();
            --remainder;
          }
        return extraHoundWeatherInformationNuggetIntentComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetIntentLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                switch (field_name[1])
                  {
                    case 'a':
                        switch (field_name[2])
                          {
                            case 'i':
                                if ((String.Compare(field_name, 3, "lyForecastExplicitlyRequested", 0, 29, false) == 0) && (field_name.Length == 32))
                                    return (flagHasDailyForecastExplicitlyRequested ? extraDailyForecastExplicitlyRequestedToJSON() : null);
                                break;
                            case 't':
                                if ((String.Compare(field_name, 3, "eTimeRange", 0, 10, false) == 0) && (field_name.Length == 13))
                                    return (flagHasDateTimeRange ? extraDateTimeRangeToJSON() : null);
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'i':
                        if (String.Compare(field_name, 2, "splay", 0, 5, false) == 0)
                          {
                            switch (field_name[7])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 8, "aily", 0, 4, false) == 0) && (field_name.Length == 12))
                                        return (flagHasDisplayDaily ? extraDisplayDailyToJSON() : null);
                                    break;
                                case 'H':
                                    if ((String.Compare(field_name, 8, "ourly", 0, 5, false) == 0) && (field_name.Length == 13))
                                        return (flagHasDisplayHourly ? extraDisplayHourlyToJSON() : null);
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
            case 'H':
                if ((String.Compare(field_name, 1, "ourlyForecastExplicitlyRequested", 0, 32, false) == 0) && (field_name.Length == 33))
                    return (flagHasHourlyForecastExplicitlyRequested ? extraHourlyForecastExplicitlyRequestedToJSON() : null);
                break;
            case 'I':
                if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                  {
                    switch (field_name[2])
                      {
                        case 'S':
                            if ((String.Compare(field_name, 3, "earchQuery", 0, 10, false) == 0) && (field_name.Length == 13))
                                return (flagHasIsSearchQuery ? extraIsSearchQueryToJSON() : null);
                            break;
                        case 'Y':
                            if ((String.Compare(field_name, 3, "esNoQuery", 0, 9, false) == 0) && (field_name.Length == 12))
                                return (flagHasIsYesNoQuery ? extraIsYesNoQueryToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasMapLocation ? extraMapLocationToJSON() : null);
                break;
            case 'R':
                if (String.Compare(field_name, 1, "equestedAttribute", 0, 17, false) == 0)
                  {
                    if (field_name.Length == 18)
                      {
                        return (flagHasRequestedAttribute ? extraRequestedAttributeToJSON() : null);
                      }
                    switch (field_name[18])
                      {
                        case 'A':
                            if ((String.Compare(field_name, 19, "ction", 0, 5, false) == 0) && (field_name.Length == 24))
                                return (flagHasRequestedAttributeAction ? extraRequestedAttributeActionToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "etOfTime", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasSetOfTime ? extraSetOfTimeToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "nits", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasUnits ? extraUnitsToJSON() : null);
                break;
            case 'W':
                if (String.Compare(field_name, 1, "eather", 0, 6, false) == 0)
                  {
                    switch (field_name[7])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 8, "ntentKind", 0, 9, false) == 0) && (field_name.Length == 17))
                                return (flagHasWeatherIntentKind ? extraWeatherIntentKindToJSON() : null);
                            break;
                        case 'Q':
                            if ((String.Compare(field_name, 8, "ueryType", 0, 8, false) == 0) && (field_name.Length == 16))
                                return (flagHasWeatherQueryType ? extraWeatherQueryTypeToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraHoundWeatherInformationNuggetIntentLookup(field_name);
      }

    public void setWeatherIntentKind(string new_value)
      {
        flagHasWeatherIntentKind = true;
        storeWeatherIntentKind = new_value;
      }
    public void unsetWeatherIntentKind()
      {
        flagHasWeatherIntentKind = false;
      }
    public void setWeatherQueryType(string new_value)
      {
        flagHasWeatherQueryType = true;
        storeWeatherQueryType = new_value;
      }
    public void unsetWeatherQueryType()
      {
        flagHasWeatherQueryType = false;
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
    public void setRequestedAttributeAction(WeatherAttributeActionJSON  new_value)
      {
        if (flagHasRequestedAttributeAction)
          {
          }
        flagHasRequestedAttributeAction = true;
        storeRequestedAttributeAction = new_value;
      }
    public void setRequestedAttributeAction(WeatherAttributeActionJSON.TypeValue new_value)
      {
        setRequestedAttributeAction(new WeatherAttributeActionJSON(new_value));
      }
    public void setRequestedAttributeAction(string chars)
      {
        WeatherAttributeActionJSON.TypeValueKnownValues known = WeatherAttributeActionJSON.stringToValue(chars);
        WeatherAttributeActionJSON.TypeValue new_value = new WeatherAttributeActionJSON.TypeValue();
        if (known == WeatherAttributeActionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRequestedAttributeAction(new_value);
      }
    public void unsetRequestedAttributeAction()
      {
        if (flagHasRequestedAttributeAction)
          {
          }
        flagHasRequestedAttributeAction = false;
      }
    public void setIsSearchQuery(bool new_value)
      {
        flagHasIsSearchQuery = true;
        storeIsSearchQuery = new_value;
      }
    public void unsetIsSearchQuery()
      {
        flagHasIsSearchQuery = false;
      }
    public void setMapLocation(MapLocationJSON  new_value)
      {
        if (flagHasMapLocation)
          {
          }
        flagHasMapLocation = true;
        storeMapLocation = new_value;
      }
    public void unsetMapLocation()
      {
        if (flagHasMapLocation)
          {
          }
        flagHasMapLocation = false;
      }
    public void setDateTimeRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasDateTimeRange)
          {
          }
        flagHasDateTimeRange = true;
        storeDateTimeRange = new_value;
      }
    public void unsetDateTimeRange()
      {
        if (flagHasDateTimeRange)
          {
          }
        flagHasDateTimeRange = false;
      }
    public void setUnits(WeatherUnitsFormatJSON  new_value)
      {
        if (flagHasUnits)
          {
          }
        flagHasUnits = true;
        storeUnits = new_value;
      }
    public void setUnits(WeatherUnitsFormatJSON.TypeValue new_value)
      {
        setUnits(new WeatherUnitsFormatJSON(new_value));
      }
    public void setUnits(string chars)
      {
        WeatherUnitsFormatJSON.TypeValueKnownValues known = WeatherUnitsFormatJSON.stringToValue(chars);
        WeatherUnitsFormatJSON.TypeValue new_value = new WeatherUnitsFormatJSON.TypeValue();
        if (known == WeatherUnitsFormatJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setUnits(new_value);
      }
    public void unsetUnits()
      {
        if (flagHasUnits)
          {
          }
        flagHasUnits = false;
      }
    public void setIsYesNoQuery(bool new_value)
      {
        flagHasIsYesNoQuery = true;
        storeIsYesNoQuery = new_value;
      }
    public void unsetIsYesNoQuery()
      {
        flagHasIsYesNoQuery = false;
      }
    public void setDailyForecastExplicitlyRequested(bool new_value)
      {
        flagHasDailyForecastExplicitlyRequested = true;
        storeDailyForecastExplicitlyRequested = new_value;
      }
    public void unsetDailyForecastExplicitlyRequested()
      {
        flagHasDailyForecastExplicitlyRequested = false;
      }
    public void setHourlyForecastExplicitlyRequested(bool new_value)
      {
        flagHasHourlyForecastExplicitlyRequested = true;
        storeHourlyForecastExplicitlyRequested = new_value;
      }
    public void unsetHourlyForecastExplicitlyRequested()
      {
        flagHasHourlyForecastExplicitlyRequested = false;
      }
    public void setDisplayDaily(bool new_value)
      {
        flagHasDisplayDaily = true;
        storeDisplayDaily = new_value;
      }
    public void unsetDisplayDaily()
      {
        flagHasDisplayDaily = false;
      }
    public void setDisplayHourly(bool new_value)
      {
        flagHasDisplayHourly = true;
        storeDisplayHourly = new_value;
      }
    public void unsetDisplayHourly()
      {
        flagHasDisplayHourly = false;
      }
    public void setSetOfTime(SetOfTimeJSON  new_value)
      {
        if (flagHasSetOfTime)
          {
          }
        flagHasSetOfTime = true;
        storeSetOfTime = new_value;
      }
    public void unsetSetOfTime()
      {
        if (flagHasSetOfTime)
          {
          }
        flagHasSetOfTime = false;
      }

    public virtual void extraHoundWeatherInformationNuggetIntentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHoundWeatherInformationNuggetIntentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHoundWeatherInformationNuggetIntentLookup(key);
        if (old_field == null)
          {
            extraHoundWeatherInformationNuggetIntentAppendPair(key, new_component);
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
    public override void extraInformationNuggetIntentAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                switch (key[1])
                  {
                    case 'a':
                        switch (key[2])
                          {
                            case 'i':
                                if ((String.Compare(key, 3, "lyForecastExplicitlyRequested", 0, 29, false) == 0) && (key.Length == 32))
                                    {
                                    fromJSONDailyForecastExplicitlyRequested(new_component, false);
                                    return;
                                    }
                                break;
                            case 't':
                                if ((String.Compare(key, 3, "eTimeRange", 0, 10, false) == 0) && (key.Length == 13))
                                    {
                                    fromJSONDateTimeRange(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'i':
                        if (String.Compare(key, 2, "splay", 0, 5, false) == 0)
                          {
                            switch (key[7])
                              {
                                case 'D':
                                    if ((String.Compare(key, 8, "aily", 0, 4, false) == 0) && (key.Length == 12))
                                        {
                                        fromJSONDisplayDaily(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'H':
                                    if ((String.Compare(key, 8, "ourly", 0, 5, false) == 0) && (key.Length == 13))
                                        {
                                        fromJSONDisplayHourly(new_component, false);
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
            case 'H':
                if ((String.Compare(key, 1, "ourlyForecastExplicitlyRequested", 0, 32, false) == 0) && (key.Length == 33))
                    {
                    fromJSONHourlyForecastExplicitlyRequested(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if (String.Compare(key, 1, "s", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'S':
                            if ((String.Compare(key, 3, "earchQuery", 0, 10, false) == 0) && (key.Length == 13))
                                {
                                fromJSONIsSearchQuery(new_component, false);
                                return;
                                }
                            break;
                        case 'Y':
                            if ((String.Compare(key, 3, "esNoQuery", 0, 9, false) == 0) && (key.Length == 12))
                                {
                                fromJSONIsYesNoQuery(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(key, 1, "apLocation", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONMapLocation(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if (String.Compare(key, 1, "equestedAttribute", 0, 17, false) == 0)
                  {
                    if (key.Length == 18)
                      {
                        {
                        fromJSONRequestedAttribute(new_component, false);
                        return;
                        }
                      }
                    switch (key[18])
                      {
                        case 'A':
                            if ((String.Compare(key, 19, "ction", 0, 5, false) == 0) && (key.Length == 24))
                                {
                                fromJSONRequestedAttributeAction(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(key, 1, "etOfTime", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONSetOfTime(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "nits", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONUnits(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if (String.Compare(key, 1, "eather", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'I':
                            if ((String.Compare(key, 8, "ntentKind", 0, 9, false) == 0) && (key.Length == 17))
                                {
                                fromJSONWeatherIntentKind(new_component, false);
                                return;
                                }
                            break;
                        case 'Q':
                            if ((String.Compare(key, 8, "ueryType", 0, 8, false) == 0) && (key.Length == 16))
                                {
                                fromJSONWeatherQueryType(new_component, false);
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
        extraHoundWeatherInformationNuggetIntentAppendPair(key, new_component);
      }
    public override void extraInformationNuggetIntentSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                switch (key[1])
                  {
                    case 'a':
                        switch (key[2])
                          {
                            case 'i':
                                if ((String.Compare(key, 3, "lyForecastExplicitlyRequested", 0, 29, false) == 0) && (key.Length == 32))
                                    {
                                    fromJSONDailyForecastExplicitlyRequested(new_component, false);
                                    return;
                                    }
                                break;
                            case 't':
                                if ((String.Compare(key, 3, "eTimeRange", 0, 10, false) == 0) && (key.Length == 13))
                                    {
                                    fromJSONDateTimeRange(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'i':
                        if (String.Compare(key, 2, "splay", 0, 5, false) == 0)
                          {
                            switch (key[7])
                              {
                                case 'D':
                                    if ((String.Compare(key, 8, "aily", 0, 4, false) == 0) && (key.Length == 12))
                                        {
                                        fromJSONDisplayDaily(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'H':
                                    if ((String.Compare(key, 8, "ourly", 0, 5, false) == 0) && (key.Length == 13))
                                        {
                                        fromJSONDisplayHourly(new_component, false);
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
            case 'H':
                if ((String.Compare(key, 1, "ourlyForecastExplicitlyRequested", 0, 32, false) == 0) && (key.Length == 33))
                    {
                    fromJSONHourlyForecastExplicitlyRequested(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if (String.Compare(key, 1, "s", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'S':
                            if ((String.Compare(key, 3, "earchQuery", 0, 10, false) == 0) && (key.Length == 13))
                                {
                                fromJSONIsSearchQuery(new_component, false);
                                return;
                                }
                            break;
                        case 'Y':
                            if ((String.Compare(key, 3, "esNoQuery", 0, 9, false) == 0) && (key.Length == 12))
                                {
                                fromJSONIsYesNoQuery(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if ((String.Compare(key, 1, "apLocation", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONMapLocation(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if (String.Compare(key, 1, "equestedAttribute", 0, 17, false) == 0)
                  {
                    if (key.Length == 18)
                      {
                        {
                        fromJSONRequestedAttribute(new_component, false);
                        return;
                        }
                      }
                    switch (key[18])
                      {
                        case 'A':
                            if ((String.Compare(key, 19, "ction", 0, 5, false) == 0) && (key.Length == 24))
                                {
                                fromJSONRequestedAttributeAction(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(key, 1, "etOfTime", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONSetOfTime(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "nits", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONUnits(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if (String.Compare(key, 1, "eather", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'I':
                            if ((String.Compare(key, 8, "ntentKind", 0, 9, false) == 0) && (key.Length == 17))
                                {
                                fromJSONWeatherIntentKind(new_component, false);
                                return;
                                }
                            break;
                        case 'Q':
                            if ((String.Compare(key, 8, "ueryType", 0, 8, false) == 0) && (key.Length == 16))
                                {
                                fromJSONWeatherQueryType(new_component, false);
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
        extraHoundWeatherInformationNuggetIntentSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasWeatherIntentKind);
        if (flagHasWeatherIntentKind)
          {
            handler.start_pair("WeatherIntentKind");
            handler.string_value(storeWeatherIntentKind);
          }
        Debug.Assert(partial_allowed || flagHasWeatherQueryType);
        if (flagHasWeatherQueryType)
          {
            handler.start_pair("WeatherQueryType");
            handler.string_value(storeWeatherQueryType);
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
        if (flagHasRequestedAttributeAction)
          {
            handler.start_pair("RequestedAttributeAction");
            if (partial_allowed)
                storeRequestedAttributeAction.write_partial_as_json(handler);
            else
                storeRequestedAttributeAction.write_as_json(handler);
          }
        if (flagHasIsSearchQuery)
          {
            handler.start_pair("IsSearchQuery");
            handler.boolean_value(storeIsSearchQuery);
          }
        if (flagHasMapLocation)
          {
            handler.start_pair("MapLocation");
            if (partial_allowed)
                storeMapLocation.write_partial_as_json(handler);
            else
                storeMapLocation.write_as_json(handler);
          }
        if (flagHasDateTimeRange)
          {
            handler.start_pair("DateTimeRange");
            if (partial_allowed)
                storeDateTimeRange.write_partial_as_json(handler);
            else
                storeDateTimeRange.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasUnits);
        if (flagHasUnits)
          {
            handler.start_pair("Units");
            if (partial_allowed)
                storeUnits.write_partial_as_json(handler);
            else
                storeUnits.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasIsYesNoQuery);
        if (flagHasIsYesNoQuery)
          {
            handler.start_pair("IsYesNoQuery");
            handler.boolean_value(storeIsYesNoQuery);
          }
        if (flagHasDailyForecastExplicitlyRequested)
          {
            handler.start_pair("DailyForecastExplicitlyRequested");
            handler.boolean_value(storeDailyForecastExplicitlyRequested);
          }
        if (flagHasHourlyForecastExplicitlyRequested)
          {
            handler.start_pair("HourlyForecastExplicitlyRequested");
            handler.boolean_value(storeHourlyForecastExplicitlyRequested);
          }
        if (flagHasDisplayDaily)
          {
            handler.start_pair("DisplayDaily");
            handler.boolean_value(storeDisplayDaily);
          }
        if (flagHasDisplayHourly)
          {
            handler.start_pair("DisplayHourly");
            handler.boolean_value(storeDisplayHourly);
          }
        if (flagHasSetOfTime)
          {
            handler.start_pair("SetOfTime");
            if (partial_allowed)
                storeSetOfTime.write_partial_as_json(handler);
            else
                storeSetOfTime.write_as_json(handler);
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
        if (!(hasWeatherIntentKind()))
          {
            return "When parsing the object for %what%, the \"WeatherIntentKind\" field was missing.";
          }
        if (!(hasWeatherQueryType()))
          {
            return "When parsing the object for %what%, the \"WeatherQueryType\" field was missing.";
          }
        if (!(hasRequestedAttribute()))
          {
            return "When parsing the object for %what%, the \"RequestedAttribute\" field was missing.";
          }
        if (!(hasUnits()))
          {
            return "When parsing the object for %what%, the \"Units\" field was missing.";
          }
        if (!(hasIsYesNoQuery()))
          {
            return "When parsing the object for %what%, the \"IsYesNoQuery\" field was missing.";
          }
        return null;
      }

    public static new HoundWeatherInformationNuggetIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundWeatherInformationNuggetIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundWeatherInformationNuggetIntent", ignore_extras);
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
    public static new HoundWeatherInformationNuggetIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HoundWeatherInformationNuggetIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundWeatherInformationNuggetIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundWeatherInformationNuggetIntent", ignore_extras);
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
    public static new HoundWeatherInformationNuggetIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HoundWeatherInformationNuggetIntentJSON from_text(string text, bool ignore_extras)
      {
        HoundWeatherInformationNuggetIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundWeatherInformationNuggetIntent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HoundWeatherInformationNuggetIntentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HoundWeatherInformationNuggetIntentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HoundWeatherInformationNuggetIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundWeatherInformationNuggetIntent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetIntentJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorWeatherIntentKind;
        private JSONHoldingStringGenerator fieldGeneratorWeatherQueryType;
        private WeatherAttributeJSON.HoldingGenerator fieldGeneratorRequestedAttribute;
        private WeatherAttributeActionJSON.HoldingGenerator fieldGeneratorRequestedAttributeAction;
        private JSONHoldingBooleanGenerator fieldGeneratorIsSearchQuery;
        private MapLocationJSON.HoldingGenerator fieldGeneratorMapLocation;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateTimeRange;
        private WeatherUnitsFormatJSON.HoldingGenerator fieldGeneratorUnits;
        private JSONHoldingBooleanGenerator fieldGeneratorIsYesNoQuery;
        private JSONHoldingBooleanGenerator fieldGeneratorDailyForecastExplicitlyRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorHourlyForecastExplicitlyRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorDisplayDaily;
        private JSONHoldingBooleanGenerator fieldGeneratorDisplayHourly;
        private SetOfTimeJSON.HoldingGenerator fieldGeneratorSetOfTime;
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
            if (!(getInformationNuggetIntentJSONKey().Equals("HoundWeather")))
                throw new Exception("The key field has a value other than `HoundWeather'.");
            HoundWeatherInformationNuggetIntentJSON result = new HoundWeatherInformationNuggetIntentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHoundWeatherInformationNuggetIntentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetIntentJSON new_result)
          {
            handle_result((HoundWeatherInformationNuggetIntentJSON )new_result);
          }
        protected void finish(HoundWeatherInformationNuggetIntentJSON result)
          {
            if (fieldGeneratorWeatherIntentKind.have_value)
              {
                result.setWeatherIntentKind(fieldGeneratorWeatherIntentKind.value);
                fieldGeneratorWeatherIntentKind.have_value = false;
              }
            else if ((!(result.hasWeatherIntentKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WeatherIntentKind\" field was missing.");
              }
            if (fieldGeneratorWeatherQueryType.have_value)
              {
                result.setWeatherQueryType(fieldGeneratorWeatherQueryType.value);
                fieldGeneratorWeatherQueryType.have_value = false;
              }
            else if ((!(result.hasWeatherQueryType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"WeatherQueryType\" field was missing.");
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
            if (fieldGeneratorRequestedAttributeAction.have_value)
              {
                result.setRequestedAttributeAction(fieldGeneratorRequestedAttributeAction.value);
                fieldGeneratorRequestedAttributeAction.have_value = false;
              }
            if (fieldGeneratorIsSearchQuery.have_value)
              {
                result.setIsSearchQuery(fieldGeneratorIsSearchQuery.value);
                fieldGeneratorIsSearchQuery.have_value = false;
              }
            if (fieldGeneratorMapLocation.have_value)
              {
                result.setMapLocation(fieldGeneratorMapLocation.value);
                fieldGeneratorMapLocation.have_value = false;
              }
            if (fieldGeneratorDateTimeRange.have_value)
              {
                result.setDateTimeRange(fieldGeneratorDateTimeRange.value);
                fieldGeneratorDateTimeRange.have_value = false;
              }
            if (fieldGeneratorUnits.have_value)
              {
                result.setUnits(fieldGeneratorUnits.value);
                fieldGeneratorUnits.have_value = false;
              }
            else if ((!(result.hasUnits())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Units\" field was missing.");
              }
            if (fieldGeneratorIsYesNoQuery.have_value)
              {
                result.setIsYesNoQuery(fieldGeneratorIsYesNoQuery.value);
                fieldGeneratorIsYesNoQuery.have_value = false;
              }
            else if ((!(result.hasIsYesNoQuery())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsYesNoQuery\" field was missing.");
              }
            if (fieldGeneratorDailyForecastExplicitlyRequested.have_value)
              {
                result.setDailyForecastExplicitlyRequested(fieldGeneratorDailyForecastExplicitlyRequested.value);
                fieldGeneratorDailyForecastExplicitlyRequested.have_value = false;
              }
            if (fieldGeneratorHourlyForecastExplicitlyRequested.have_value)
              {
                result.setHourlyForecastExplicitlyRequested(fieldGeneratorHourlyForecastExplicitlyRequested.value);
                fieldGeneratorHourlyForecastExplicitlyRequested.have_value = false;
              }
            if (fieldGeneratorDisplayDaily.have_value)
              {
                result.setDisplayDaily(fieldGeneratorDisplayDaily.value);
                fieldGeneratorDisplayDaily.have_value = false;
              }
            if (fieldGeneratorDisplayHourly.have_value)
              {
                result.setDisplayHourly(fieldGeneratorDisplayHourly.value);
                fieldGeneratorDisplayHourly.have_value = false;
              }
            if (fieldGeneratorSetOfTime.have_value)
              {
                result.setSetOfTime(fieldGeneratorSetOfTime.value);
                fieldGeneratorSetOfTime.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(HoundWeatherInformationNuggetIntentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            switch (field_name[2])
                              {
                                case 'i':
                                    if ((String.Compare(field_name, 3, "lyForecastExplicitlyRequested", 0, 29, false) == 0) && (field_name.Length == 32))
                                        return fieldGeneratorDailyForecastExplicitlyRequested;
                                    break;
                                case 't':
                                    if ((String.Compare(field_name, 3, "eTimeRange", 0, 10, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorDateTimeRange;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'i':
                            if (String.Compare(field_name, 2, "splay", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 8, "aily", 0, 4, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorDisplayDaily;
                                        break;
                                    case 'H':
                                        if ((String.Compare(field_name, 8, "ourly", 0, 5, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorDisplayHourly;
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
                case 'H':
                    if ((String.Compare(field_name, 1, "ourlyForecastExplicitlyRequested", 0, 32, false) == 0) && (field_name.Length == 33))
                        return fieldGeneratorHourlyForecastExplicitlyRequested;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 3, "earchQuery", 0, 10, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorIsSearchQuery;
                                break;
                            case 'Y':
                                if ((String.Compare(field_name, 3, "esNoQuery", 0, 9, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorIsYesNoQuery;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMapLocation;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "equestedAttribute", 0, 17, false) == 0)
                      {
                        if (field_name.Length == 18)
                          {
                            return fieldGeneratorRequestedAttribute;
                          }
                        switch (field_name[18])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 19, "ction", 0, 5, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorRequestedAttributeAction;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "etOfTime", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorSetOfTime;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nits", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorUnits;
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "eather", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 8, "ntentKind", 0, 9, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorWeatherIntentKind;
                                break;
                            case 'Q':
                                if ((String.Compare(field_name, 8, "ueryType", 0, 8, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorWeatherQueryType;
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
            fieldGeneratorWeatherIntentKind = new JSONHoldingStringGenerator("field \"WeatherIntentKind\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorWeatherQueryType = new JSONHoldingStringGenerator("field \"WeatherQueryType\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorRequestedAttribute = new WeatherAttributeJSON.HoldingGenerator("field \"RequestedAttribute\" of the HoundWeatherInformationNuggetIntent class", ignore_extras);
            fieldGeneratorRequestedAttributeAction = new WeatherAttributeActionJSON.HoldingGenerator("field \"RequestedAttributeAction\" of the HoundWeatherInformationNuggetIntent class", ignore_extras);
            fieldGeneratorIsSearchQuery = new JSONHoldingBooleanGenerator("field \"IsSearchQuery\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the HoundWeatherInformationNuggetIntent class", ignore_extras);
            fieldGeneratorDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRange\" of the HoundWeatherInformationNuggetIntent class", ignore_extras);
            fieldGeneratorUnits = new WeatherUnitsFormatJSON.HoldingGenerator("field \"Units\" of the HoundWeatherInformationNuggetIntent class", ignore_extras);
            fieldGeneratorIsYesNoQuery = new JSONHoldingBooleanGenerator("field \"IsYesNoQuery\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorDailyForecastExplicitlyRequested = new JSONHoldingBooleanGenerator("field \"DailyForecastExplicitlyRequested\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorHourlyForecastExplicitlyRequested = new JSONHoldingBooleanGenerator("field \"HourlyForecastExplicitlyRequested\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorDisplayDaily = new JSONHoldingBooleanGenerator("field \"DisplayDaily\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorDisplayHourly = new JSONHoldingBooleanGenerator("field \"DisplayHourly\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorSetOfTime = new SetOfTimeJSON.HoldingGenerator("field \"SetOfTime\" of the HoundWeatherInformationNuggetIntent class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HoundWeatherInformationNuggetIntent class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorWeatherIntentKind = new JSONHoldingStringGenerator("field \"WeatherIntentKind\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorWeatherQueryType = new JSONHoldingStringGenerator("field \"WeatherQueryType\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorRequestedAttribute = new WeatherAttributeJSON.HoldingGenerator("field \"RequestedAttribute\" of the HoundWeatherInformationNuggetIntent class", false);
            fieldGeneratorRequestedAttributeAction = new WeatherAttributeActionJSON.HoldingGenerator("field \"RequestedAttributeAction\" of the HoundWeatherInformationNuggetIntent class", false);
            fieldGeneratorIsSearchQuery = new JSONHoldingBooleanGenerator("field \"IsSearchQuery\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the HoundWeatherInformationNuggetIntent class", false);
            fieldGeneratorDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRange\" of the HoundWeatherInformationNuggetIntent class", false);
            fieldGeneratorUnits = new WeatherUnitsFormatJSON.HoldingGenerator("field \"Units\" of the HoundWeatherInformationNuggetIntent class", false);
            fieldGeneratorIsYesNoQuery = new JSONHoldingBooleanGenerator("field \"IsYesNoQuery\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorDailyForecastExplicitlyRequested = new JSONHoldingBooleanGenerator("field \"DailyForecastExplicitlyRequested\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorHourlyForecastExplicitlyRequested = new JSONHoldingBooleanGenerator("field \"HourlyForecastExplicitlyRequested\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorDisplayDaily = new JSONHoldingBooleanGenerator("field \"DisplayDaily\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorDisplayHourly = new JSONHoldingBooleanGenerator("field \"DisplayHourly\" of the HoundWeatherInformationNuggetIntent class");
            fieldGeneratorSetOfTime = new SetOfTimeJSON.HoldingGenerator("field \"SetOfTime\" of the HoundWeatherInformationNuggetIntent class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HoundWeatherInformationNuggetIntent class");
          }

        public override void reset()
          {
            fieldGeneratorWeatherIntentKind.reset();
            fieldGeneratorWeatherQueryType.reset();
            fieldGeneratorRequestedAttribute.reset();
            fieldGeneratorRequestedAttributeAction.reset();
            fieldGeneratorIsSearchQuery.reset();
            fieldGeneratorMapLocation.reset();
            fieldGeneratorDateTimeRange.reset();
            fieldGeneratorUnits.reset();
            fieldGeneratorIsYesNoQuery.reset();
            fieldGeneratorDailyForecastExplicitlyRequested.reset();
            fieldGeneratorHourlyForecastExplicitlyRequested.reset();
            fieldGeneratorDisplayDaily.reset();
            fieldGeneratorDisplayHourly.reset();
            fieldGeneratorSetOfTime.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HoundWeatherInformationNuggetIntentJSON  result)
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
        public HoundWeatherInformationNuggetIntentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HoundWeatherInformationNuggetIntentJSON  result)
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
    protected virtual void handle_result(List<HoundWeatherInformationNuggetIntentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HoundWeatherInformationNuggetIntentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HoundWeatherInformationNuggetIntentJSON>();
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
    public List<HoundWeatherInformationNuggetIntentJSON> value;
  };
  };
