/* file "DateAndTimeLookupInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DateAndTimeLookupInformationNuggetJSON : DateAndTimeInformationNuggetJSON
  {
    private bool flagHasDateAndOrTimeSpec;
    private DateAndOrTimeSpecJSON  storeDateAndOrTimeSpec;
    private bool flagHasDestinationMapLocation;
    private MapLocationJSON  storeDestinationMapLocation;
    private bool flagHasDayOfWeekRequested;
    private bool storeDayOfWeekRequested;
    private bool flagHasDateAndOrTimeSpecInFuture;
    private bool storeDateAndOrTimeSpecInFuture;
    private bool flagHasComparisonRequested;
    private bool storeComparisonRequested;
    private bool flagHasIncludeTime;
    private bool storeIncludeTime;
    private bool flagHasComparisonDateAndOrTimeSpec;
    private DateAndOrTimeSpecJSON  storeComparisonDateAndOrTimeSpec;
    private bool flagHasComparisonDateAndOrTimeSpecEnd;
    private DateAndOrTimeSpecJSON  storeComparisonDateAndOrTimeSpecEnd;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDateAndOrTimeSpecToJSON()
      {
        JSONValueHandler handler_DateAndOrTimeSpec = new JSONValueHandler();
        storeDateAndOrTimeSpec.write_as_json(handler_DateAndOrTimeSpec);
        return handler_DateAndOrTimeSpec.result;
      }

    private JSONValue  extraDestinationMapLocationToJSON()
      {
        JSONValueHandler handler_DestinationMapLocation = new JSONValueHandler();
        storeDestinationMapLocation.write_as_json(handler_DestinationMapLocation);
        return handler_DestinationMapLocation.result;
      }

    private JSONValue  extraDayOfWeekRequestedToJSON()
      {
        JSONValue generated_boolean_DayOfWeekRequested = (storeDayOfWeekRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DayOfWeekRequested;
      }

    private JSONValue  extraDateAndOrTimeSpecInFutureToJSON()
      {
        JSONValue generated_boolean_DateAndOrTimeSpecInFuture = (storeDateAndOrTimeSpecInFuture ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DateAndOrTimeSpecInFuture;
      }

    private JSONValue  extraComparisonRequestedToJSON()
      {
        JSONValue generated_boolean_ComparisonRequested = (storeComparisonRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ComparisonRequested;
      }

    private JSONValue  extraIncludeTimeToJSON()
      {
        JSONValue generated_boolean_IncludeTime = (storeIncludeTime ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IncludeTime;
      }

    private JSONValue  extraComparisonDateAndOrTimeSpecToJSON()
      {
        JSONValueHandler handler_ComparisonDateAndOrTimeSpec = new JSONValueHandler();
        storeComparisonDateAndOrTimeSpec.write_as_json(handler_ComparisonDateAndOrTimeSpec);
        return handler_ComparisonDateAndOrTimeSpec.result;
      }

    private JSONValue  extraComparisonDateAndOrTimeSpecEndToJSON()
      {
        JSONValueHandler handler_ComparisonDateAndOrTimeSpecEnd = new JSONValueHandler();
        storeComparisonDateAndOrTimeSpecEnd.write_as_json(handler_ComparisonDateAndOrTimeSpecEnd);
        return handler_ComparisonDateAndOrTimeSpecEnd.result;
      }


    private void  fromJSONDateAndOrTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeSpecJSON convert_classy = DateAndOrTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateAndOrTimeSpec(convert_classy);
      }


    private void  fromJSONDestinationMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setDestinationMapLocation(convert_classy);
      }


    private void  fromJSONDayOfWeekRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DayOfWeekRequested of DateAndTimeLookupInformationNuggetJSON is not true for false.");
              }
          }
        setDayOfWeekRequested(the_bool);
      }


    private void  fromJSONDateAndOrTimeSpecInFuture(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DateAndOrTimeSpecInFuture of DateAndTimeLookupInformationNuggetJSON is not true for false.");
              }
          }
        setDateAndOrTimeSpecInFuture(the_bool);
      }


    private void  fromJSONComparisonRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ComparisonRequested of DateAndTimeLookupInformationNuggetJSON is not true for false.");
              }
          }
        setComparisonRequested(the_bool);
      }


    private void  fromJSONIncludeTime(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IncludeTime of DateAndTimeLookupInformationNuggetJSON is not true for false.");
              }
          }
        setIncludeTime(the_bool);
      }


    private void  fromJSONComparisonDateAndOrTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeSpecJSON convert_classy = DateAndOrTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setComparisonDateAndOrTimeSpec(convert_classy);
      }


    private void  fromJSONComparisonDateAndOrTimeSpecEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeSpecJSON convert_classy = DateAndOrTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setComparisonDateAndOrTimeSpecEnd(convert_classy);
      }


    public DateAndTimeLookupInformationNuggetJSON()
      {
        flagHasDateAndOrTimeSpec = false;
        flagHasDestinationMapLocation = false;
        flagHasDayOfWeekRequested = false;
        flagHasDateAndOrTimeSpecInFuture = false;
        flagHasComparisonRequested = false;
        flagHasIncludeTime = false;
        flagHasComparisonDateAndOrTimeSpec = false;
        flagHasComparisonDateAndOrTimeSpecEnd = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDateAndTimeNuggetKind()
      {
        return "DateAndTimeLookupCommand";
      }

    public bool  hasDateAndOrTimeSpec()
      {
        return flagHasDateAndOrTimeSpec;
      }

    public DateAndOrTimeSpecJSON   getDateAndOrTimeSpec()
      {
        Debug.Assert(flagHasDateAndOrTimeSpec);
        return storeDateAndOrTimeSpec;
      }

    public bool  hasDestinationMapLocation()
      {
        return flagHasDestinationMapLocation;
      }

    public MapLocationJSON   getDestinationMapLocation()
      {
        Debug.Assert(flagHasDestinationMapLocation);
        return storeDestinationMapLocation;
      }

    public bool  hasDayOfWeekRequested()
      {
        return flagHasDayOfWeekRequested;
      }

    public bool  getDayOfWeekRequested()
      {
        Debug.Assert(flagHasDayOfWeekRequested);
        return storeDayOfWeekRequested;
      }

    public bool  hasDateAndOrTimeSpecInFuture()
      {
        return flagHasDateAndOrTimeSpecInFuture;
      }

    public bool  getDateAndOrTimeSpecInFuture()
      {
        Debug.Assert(flagHasDateAndOrTimeSpecInFuture);
        return storeDateAndOrTimeSpecInFuture;
      }

    public bool  hasComparisonRequested()
      {
        return flagHasComparisonRequested;
      }

    public bool  getComparisonRequested()
      {
        Debug.Assert(flagHasComparisonRequested);
        return storeComparisonRequested;
      }

    public bool  hasIncludeTime()
      {
        return flagHasIncludeTime;
      }

    public bool  getIncludeTime()
      {
        Debug.Assert(flagHasIncludeTime);
        return storeIncludeTime;
      }

    public bool  hasComparisonDateAndOrTimeSpec()
      {
        return flagHasComparisonDateAndOrTimeSpec;
      }

    public DateAndOrTimeSpecJSON   getComparisonDateAndOrTimeSpec()
      {
        Debug.Assert(flagHasComparisonDateAndOrTimeSpec);
        return storeComparisonDateAndOrTimeSpec;
      }

    public bool  hasComparisonDateAndOrTimeSpecEnd()
      {
        return flagHasComparisonDateAndOrTimeSpecEnd;
      }

    public DateAndOrTimeSpecJSON   getComparisonDateAndOrTimeSpecEnd()
      {
        Debug.Assert(flagHasComparisonDateAndOrTimeSpecEnd);
        return storeComparisonDateAndOrTimeSpecEnd;
      }


    public virtual int extraDateAndTimeLookupInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDateAndTimeLookupInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDateAndTimeLookupInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDateAndTimeLookupInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDateAndTimeInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasDateAndOrTimeSpec)
            ++result;
        if (flagHasDestinationMapLocation)
            ++result;
        if (flagHasDayOfWeekRequested)
            ++result;
        if (flagHasDateAndOrTimeSpecInFuture)
            ++result;
        if (flagHasComparisonRequested)
            ++result;
        if (flagHasIncludeTime)
            ++result;
        if (flagHasComparisonDateAndOrTimeSpec)
            ++result;
        if (flagHasComparisonDateAndOrTimeSpecEnd)
            ++result;
        result += extraDateAndTimeLookupInformationNuggetComponentCount();
        return result;
      }
    public override string extraDateAndTimeInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDateAndOrTimeSpec)
          {
            if (remainder == 0)
                return "DateAndOrTimeSpec";
            --remainder;
          }
        if (flagHasDestinationMapLocation)
          {
            if (remainder == 0)
                return "DestinationMapLocation";
            --remainder;
          }
        if (flagHasDayOfWeekRequested)
          {
            if (remainder == 0)
                return "DayOfWeekRequested";
            --remainder;
          }
        if (flagHasDateAndOrTimeSpecInFuture)
          {
            if (remainder == 0)
                return "DateAndOrTimeSpecInFuture";
            --remainder;
          }
        if (flagHasComparisonRequested)
          {
            if (remainder == 0)
                return "ComparisonRequested";
            --remainder;
          }
        if (flagHasIncludeTime)
          {
            if (remainder == 0)
                return "IncludeTime";
            --remainder;
          }
        if (flagHasComparisonDateAndOrTimeSpec)
          {
            if (remainder == 0)
                return "ComparisonDateAndOrTimeSpec";
            --remainder;
          }
        if (flagHasComparisonDateAndOrTimeSpecEnd)
          {
            if (remainder == 0)
                return "ComparisonDateAndOrTimeSpecEnd";
            --remainder;
          }
        return extraDateAndTimeLookupInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDateAndOrTimeSpec)
          {
            if (remainder == 0)
                return extraDateAndOrTimeSpecToJSON();
            --remainder;
          }
        if (flagHasDestinationMapLocation)
          {
            if (remainder == 0)
                return extraDestinationMapLocationToJSON();
            --remainder;
          }
        if (flagHasDayOfWeekRequested)
          {
            if (remainder == 0)
                return extraDayOfWeekRequestedToJSON();
            --remainder;
          }
        if (flagHasDateAndOrTimeSpecInFuture)
          {
            if (remainder == 0)
                return extraDateAndOrTimeSpecInFutureToJSON();
            --remainder;
          }
        if (flagHasComparisonRequested)
          {
            if (remainder == 0)
                return extraComparisonRequestedToJSON();
            --remainder;
          }
        if (flagHasIncludeTime)
          {
            if (remainder == 0)
                return extraIncludeTimeToJSON();
            --remainder;
          }
        if (flagHasComparisonDateAndOrTimeSpec)
          {
            if (remainder == 0)
                return extraComparisonDateAndOrTimeSpecToJSON();
            --remainder;
          }
        if (flagHasComparisonDateAndOrTimeSpecEnd)
          {
            if (remainder == 0)
                return extraComparisonDateAndOrTimeSpecEndToJSON();
            --remainder;
          }
        return extraDateAndTimeLookupInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if (String.Compare(field_name, 1, "omparison", 0, 9, false) == 0)
                  {
                    switch (field_name[10])
                      {
                        case 'D':
                            if (String.Compare(field_name, 11, "ateAndOrTimeSpec", 0, 16, false) == 0)
                              {
                                if (field_name.Length == 27)
                                  {
                                    return (flagHasComparisonDateAndOrTimeSpec ? extraComparisonDateAndOrTimeSpecToJSON() : null);
                                  }
                                switch (field_name[27])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 28, "nd", 0, 2, false) == 0) && (field_name.Length == 30))
                                            return (flagHasComparisonDateAndOrTimeSpecEnd ? extraComparisonDateAndOrTimeSpecEndToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if ((String.Compare(field_name, 11, "equested", 0, 8, false) == 0) && (field_name.Length == 19))
                                return (flagHasComparisonRequested ? extraComparisonRequestedToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                switch (field_name[1])
                  {
                    case 'a':
                        switch (field_name[2])
                          {
                            case 't':
                                if (String.Compare(field_name, 3, "eAndOrTimeSpec", 0, 14, false) == 0)
                                  {
                                    if (field_name.Length == 17)
                                      {
                                        return (flagHasDateAndOrTimeSpec ? extraDateAndOrTimeSpecToJSON() : null);
                                      }
                                    switch (field_name[17])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 18, "nFuture", 0, 7, false) == 0) && (field_name.Length == 25))
                                                return (flagHasDateAndOrTimeSpecInFuture ? extraDateAndOrTimeSpecInFutureToJSON() : null);
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'y':
                                if ((String.Compare(field_name, 3, "OfWeekRequested", 0, 15, false) == 0) && (field_name.Length == 18))
                                    return (flagHasDayOfWeekRequested ? extraDayOfWeekRequestedToJSON() : null);
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if ((String.Compare(field_name, 2, "stinationMapLocation", 0, 20, false) == 0) && (field_name.Length == 22))
                            return (flagHasDestinationMapLocation ? extraDestinationMapLocationToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "ncludeTime", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasIncludeTime ? extraIncludeTimeToJSON() : null);
                break;
            default:
                break;
          }
        return extraDateAndTimeLookupInformationNuggetLookup(field_name);
      }

    public void setDateAndOrTimeSpec(DateAndOrTimeSpecJSON  new_value)
      {
        if (flagHasDateAndOrTimeSpec)
          {
          }
        flagHasDateAndOrTimeSpec = true;
        storeDateAndOrTimeSpec = new_value;
      }
    public void unsetDateAndOrTimeSpec()
      {
        if (flagHasDateAndOrTimeSpec)
          {
          }
        flagHasDateAndOrTimeSpec = false;
      }
    public void setDestinationMapLocation(MapLocationJSON  new_value)
      {
        if (flagHasDestinationMapLocation)
          {
          }
        flagHasDestinationMapLocation = true;
        storeDestinationMapLocation = new_value;
      }
    public void unsetDestinationMapLocation()
      {
        if (flagHasDestinationMapLocation)
          {
          }
        flagHasDestinationMapLocation = false;
      }
    public void setDayOfWeekRequested(bool new_value)
      {
        flagHasDayOfWeekRequested = true;
        storeDayOfWeekRequested = new_value;
      }
    public void unsetDayOfWeekRequested()
      {
        flagHasDayOfWeekRequested = false;
      }
    public void setDateAndOrTimeSpecInFuture(bool new_value)
      {
        flagHasDateAndOrTimeSpecInFuture = true;
        storeDateAndOrTimeSpecInFuture = new_value;
      }
    public void unsetDateAndOrTimeSpecInFuture()
      {
        flagHasDateAndOrTimeSpecInFuture = false;
      }
    public void setComparisonRequested(bool new_value)
      {
        flagHasComparisonRequested = true;
        storeComparisonRequested = new_value;
      }
    public void unsetComparisonRequested()
      {
        flagHasComparisonRequested = false;
      }
    public void setIncludeTime(bool new_value)
      {
        flagHasIncludeTime = true;
        storeIncludeTime = new_value;
      }
    public void unsetIncludeTime()
      {
        flagHasIncludeTime = false;
      }
    public void setComparisonDateAndOrTimeSpec(DateAndOrTimeSpecJSON  new_value)
      {
        if (flagHasComparisonDateAndOrTimeSpec)
          {
          }
        flagHasComparisonDateAndOrTimeSpec = true;
        storeComparisonDateAndOrTimeSpec = new_value;
      }
    public void unsetComparisonDateAndOrTimeSpec()
      {
        if (flagHasComparisonDateAndOrTimeSpec)
          {
          }
        flagHasComparisonDateAndOrTimeSpec = false;
      }
    public void setComparisonDateAndOrTimeSpecEnd(DateAndOrTimeSpecJSON  new_value)
      {
        if (flagHasComparisonDateAndOrTimeSpecEnd)
          {
          }
        flagHasComparisonDateAndOrTimeSpecEnd = true;
        storeComparisonDateAndOrTimeSpecEnd = new_value;
      }
    public void unsetComparisonDateAndOrTimeSpecEnd()
      {
        if (flagHasComparisonDateAndOrTimeSpecEnd)
          {
          }
        flagHasComparisonDateAndOrTimeSpecEnd = false;
      }

    public virtual void extraDateAndTimeLookupInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDateAndTimeLookupInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDateAndTimeLookupInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraDateAndTimeLookupInformationNuggetAppendPair(key, new_component);
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
    public override void extraDateAndTimeInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if (String.Compare(key, 1, "omparison", 0, 9, false) == 0)
                  {
                    switch (key[10])
                      {
                        case 'D':
                            if (String.Compare(key, 11, "ateAndOrTimeSpec", 0, 16, false) == 0)
                              {
                                if (key.Length == 27)
                                  {
                                    {
                                    fromJSONComparisonDateAndOrTimeSpec(new_component, false);
                                    return;
                                    }
                                  }
                                switch (key[27])
                                  {
                                    case 'E':
                                        if ((String.Compare(key, 28, "nd", 0, 2, false) == 0) && (key.Length == 30))
                                            {
                                            fromJSONComparisonDateAndOrTimeSpecEnd(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if ((String.Compare(key, 11, "equested", 0, 8, false) == 0) && (key.Length == 19))
                                {
                                fromJSONComparisonRequested(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                switch (key[1])
                  {
                    case 'a':
                        switch (key[2])
                          {
                            case 't':
                                if (String.Compare(key, 3, "eAndOrTimeSpec", 0, 14, false) == 0)
                                  {
                                    if (key.Length == 17)
                                      {
                                        {
                                        fromJSONDateAndOrTimeSpec(new_component, false);
                                        return;
                                        }
                                      }
                                    switch (key[17])
                                      {
                                        case 'I':
                                            if ((String.Compare(key, 18, "nFuture", 0, 7, false) == 0) && (key.Length == 25))
                                                {
                                                fromJSONDateAndOrTimeSpecInFuture(new_component, false);
                                                return;
                                                }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'y':
                                if ((String.Compare(key, 3, "OfWeekRequested", 0, 15, false) == 0) && (key.Length == 18))
                                    {
                                    fromJSONDayOfWeekRequested(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if ((String.Compare(key, 2, "stinationMapLocation", 0, 20, false) == 0) && (key.Length == 22))
                            {
                            fromJSONDestinationMapLocation(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if ((String.Compare(key, 1, "ncludeTime", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONIncludeTime(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDateAndTimeLookupInformationNuggetAppendPair(key, new_component);
      }
    public override void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if (String.Compare(key, 1, "omparison", 0, 9, false) == 0)
                  {
                    switch (key[10])
                      {
                        case 'D':
                            if (String.Compare(key, 11, "ateAndOrTimeSpec", 0, 16, false) == 0)
                              {
                                if (key.Length == 27)
                                  {
                                    {
                                    fromJSONComparisonDateAndOrTimeSpec(new_component, false);
                                    return;
                                    }
                                  }
                                switch (key[27])
                                  {
                                    case 'E':
                                        if ((String.Compare(key, 28, "nd", 0, 2, false) == 0) && (key.Length == 30))
                                            {
                                            fromJSONComparisonDateAndOrTimeSpecEnd(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if ((String.Compare(key, 11, "equested", 0, 8, false) == 0) && (key.Length == 19))
                                {
                                fromJSONComparisonRequested(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'D':
                switch (key[1])
                  {
                    case 'a':
                        switch (key[2])
                          {
                            case 't':
                                if (String.Compare(key, 3, "eAndOrTimeSpec", 0, 14, false) == 0)
                                  {
                                    if (key.Length == 17)
                                      {
                                        {
                                        fromJSONDateAndOrTimeSpec(new_component, false);
                                        return;
                                        }
                                      }
                                    switch (key[17])
                                      {
                                        case 'I':
                                            if ((String.Compare(key, 18, "nFuture", 0, 7, false) == 0) && (key.Length == 25))
                                                {
                                                fromJSONDateAndOrTimeSpecInFuture(new_component, false);
                                                return;
                                                }
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'y':
                                if ((String.Compare(key, 3, "OfWeekRequested", 0, 15, false) == 0) && (key.Length == 18))
                                    {
                                    fromJSONDayOfWeekRequested(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'e':
                        if ((String.Compare(key, 2, "stinationMapLocation", 0, 20, false) == 0) && (key.Length == 22))
                            {
                            fromJSONDestinationMapLocation(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if ((String.Compare(key, 1, "ncludeTime", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONIncludeTime(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDateAndTimeLookupInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDateAndOrTimeSpec);
        if (flagHasDateAndOrTimeSpec)
          {
            handler.start_pair("DateAndOrTimeSpec");
            if (partial_allowed)
                storeDateAndOrTimeSpec.write_partial_as_json(handler);
            else
                storeDateAndOrTimeSpec.write_as_json(handler);
          }
        if (flagHasDestinationMapLocation)
          {
            handler.start_pair("DestinationMapLocation");
            if (partial_allowed)
                storeDestinationMapLocation.write_partial_as_json(handler);
            else
                storeDestinationMapLocation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDayOfWeekRequested);
        if (flagHasDayOfWeekRequested)
          {
            handler.start_pair("DayOfWeekRequested");
            handler.boolean_value(storeDayOfWeekRequested);
          }
        Debug.Assert(partial_allowed || flagHasDateAndOrTimeSpecInFuture);
        if (flagHasDateAndOrTimeSpecInFuture)
          {
            handler.start_pair("DateAndOrTimeSpecInFuture");
            handler.boolean_value(storeDateAndOrTimeSpecInFuture);
          }
        Debug.Assert(partial_allowed || flagHasComparisonRequested);
        if (flagHasComparisonRequested)
          {
            handler.start_pair("ComparisonRequested");
            handler.boolean_value(storeComparisonRequested);
          }
        Debug.Assert(partial_allowed || flagHasIncludeTime);
        if (flagHasIncludeTime)
          {
            handler.start_pair("IncludeTime");
            handler.boolean_value(storeIncludeTime);
          }
        if (flagHasComparisonDateAndOrTimeSpec)
          {
            handler.start_pair("ComparisonDateAndOrTimeSpec");
            if (partial_allowed)
                storeComparisonDateAndOrTimeSpec.write_partial_as_json(handler);
            else
                storeComparisonDateAndOrTimeSpec.write_as_json(handler);
          }
        if (flagHasComparisonDateAndOrTimeSpecEnd)
          {
            handler.start_pair("ComparisonDateAndOrTimeSpecEnd");
            if (partial_allowed)
                storeComparisonDateAndOrTimeSpecEnd.write_partial_as_json(handler);
            else
                storeComparisonDateAndOrTimeSpecEnd.write_as_json(handler);
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
        if (!(hasDateAndOrTimeSpec()))
          {
            return "When parsing the object for %what%, the \"DateAndOrTimeSpec\" field was missing.";
          }
        if (!(hasDayOfWeekRequested()))
          {
            return "When parsing the object for %what%, the \"DayOfWeekRequested\" field was missing.";
          }
        if (!(hasDateAndOrTimeSpecInFuture()))
          {
            return "When parsing the object for %what%, the \"DateAndOrTimeSpecInFuture\" field was missing.";
          }
        if (!(hasComparisonRequested()))
          {
            return "When parsing the object for %what%, the \"ComparisonRequested\" field was missing.";
          }
        if (!(hasIncludeTime()))
          {
            return "When parsing the object for %what%, the \"IncludeTime\" field was missing.";
          }
        return null;
      }

    public static new DateAndTimeLookupInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateAndTimeLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndTimeLookupInformationNugget", ignore_extras);
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
    public static new DateAndTimeLookupInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DateAndTimeLookupInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateAndTimeLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndTimeLookupInformationNugget", ignore_extras);
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
    public static new DateAndTimeLookupInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DateAndTimeLookupInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        DateAndTimeLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndTimeLookupInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DateAndTimeLookupInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DateAndTimeLookupInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DateAndTimeLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndTimeLookupInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DateAndTimeInformationNuggetJSON.Generator
      {
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorDateAndOrTimeSpec;
        private MapLocationJSON.HoldingGenerator fieldGeneratorDestinationMapLocation;
        private JSONHoldingBooleanGenerator fieldGeneratorDayOfWeekRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorDateAndOrTimeSpecInFuture;
        private JSONHoldingBooleanGenerator fieldGeneratorComparisonRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorIncludeTime;
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorComparisonDateAndOrTimeSpec;
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorComparisonDateAndOrTimeSpecEnd;
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
            if (!(getDateAndTimeInformationNuggetJSONKey().Equals("DateAndTimeLookupCommand")))
                throw new Exception("The key field has a value other than `DateAndTimeLookupCommand'.");
            DateAndTimeLookupInformationNuggetJSON result = new DateAndTimeLookupInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDateAndTimeLookupInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DateAndTimeInformationNuggetJSON new_result)
          {
            handle_result((DateAndTimeLookupInformationNuggetJSON )new_result);
          }
        protected void finish(DateAndTimeLookupInformationNuggetJSON result)
          {
            if (fieldGeneratorDateAndOrTimeSpec.have_value)
              {
                result.setDateAndOrTimeSpec(fieldGeneratorDateAndOrTimeSpec.value);
                fieldGeneratorDateAndOrTimeSpec.have_value = false;
              }
            else if ((!(result.hasDateAndOrTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndOrTimeSpec\" field was missing.");
              }
            if (fieldGeneratorDestinationMapLocation.have_value)
              {
                result.setDestinationMapLocation(fieldGeneratorDestinationMapLocation.value);
                fieldGeneratorDestinationMapLocation.have_value = false;
              }
            if (fieldGeneratorDayOfWeekRequested.have_value)
              {
                result.setDayOfWeekRequested(fieldGeneratorDayOfWeekRequested.value);
                fieldGeneratorDayOfWeekRequested.have_value = false;
              }
            else if ((!(result.hasDayOfWeekRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DayOfWeekRequested\" field was missing.");
              }
            if (fieldGeneratorDateAndOrTimeSpecInFuture.have_value)
              {
                result.setDateAndOrTimeSpecInFuture(fieldGeneratorDateAndOrTimeSpecInFuture.value);
                fieldGeneratorDateAndOrTimeSpecInFuture.have_value = false;
              }
            else if ((!(result.hasDateAndOrTimeSpecInFuture())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndOrTimeSpecInFuture\" field was missing.");
              }
            if (fieldGeneratorComparisonRequested.have_value)
              {
                result.setComparisonRequested(fieldGeneratorComparisonRequested.value);
                fieldGeneratorComparisonRequested.have_value = false;
              }
            else if ((!(result.hasComparisonRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ComparisonRequested\" field was missing.");
              }
            if (fieldGeneratorIncludeTime.have_value)
              {
                result.setIncludeTime(fieldGeneratorIncludeTime.value);
                fieldGeneratorIncludeTime.have_value = false;
              }
            else if ((!(result.hasIncludeTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IncludeTime\" field was missing.");
              }
            if (fieldGeneratorComparisonDateAndOrTimeSpec.have_value)
              {
                result.setComparisonDateAndOrTimeSpec(fieldGeneratorComparisonDateAndOrTimeSpec.value);
                fieldGeneratorComparisonDateAndOrTimeSpec.have_value = false;
              }
            if (fieldGeneratorComparisonDateAndOrTimeSpecEnd.have_value)
              {
                result.setComparisonDateAndOrTimeSpecEnd(fieldGeneratorComparisonDateAndOrTimeSpecEnd.value);
                fieldGeneratorComparisonDateAndOrTimeSpecEnd.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(DateAndTimeLookupInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "omparison", 0, 9, false) == 0)
                      {
                        switch (field_name[10])
                          {
                            case 'D':
                                if (String.Compare(field_name, 11, "ateAndOrTimeSpec", 0, 16, false) == 0)
                                  {
                                    if (field_name.Length == 27)
                                      {
                                        return fieldGeneratorComparisonDateAndOrTimeSpec;
                                      }
                                    switch (field_name[27])
                                      {
                                        case 'E':
                                            if ((String.Compare(field_name, 28, "nd", 0, 2, false) == 0) && (field_name.Length == 30))
                                                return fieldGeneratorComparisonDateAndOrTimeSpecEnd;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 11, "equested", 0, 8, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorComparisonRequested;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            switch (field_name[2])
                              {
                                case 't':
                                    if (String.Compare(field_name, 3, "eAndOrTimeSpec", 0, 14, false) == 0)
                                      {
                                        if (field_name.Length == 17)
                                          {
                                            return fieldGeneratorDateAndOrTimeSpec;
                                          }
                                        switch (field_name[17])
                                          {
                                            case 'I':
                                                if ((String.Compare(field_name, 18, "nFuture", 0, 7, false) == 0) && (field_name.Length == 25))
                                                    return fieldGeneratorDateAndOrTimeSpecInFuture;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'y':
                                    if ((String.Compare(field_name, 3, "OfWeekRequested", 0, 15, false) == 0) && (field_name.Length == 18))
                                        return fieldGeneratorDayOfWeekRequested;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "stinationMapLocation", 0, 20, false) == 0) && (field_name.Length == 22))
                                return fieldGeneratorDestinationMapLocation;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "ncludeTime", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorIncludeTime;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"DateAndOrTimeSpec\" of the DateAndTimeLookupInformationNugget class", ignore_extras);
            fieldGeneratorDestinationMapLocation = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocation\" of the DateAndTimeLookupInformationNugget class", ignore_extras);
            fieldGeneratorDayOfWeekRequested = new JSONHoldingBooleanGenerator("field \"DayOfWeekRequested\" of the DateAndTimeLookupInformationNugget class");
            fieldGeneratorDateAndOrTimeSpecInFuture = new JSONHoldingBooleanGenerator("field \"DateAndOrTimeSpecInFuture\" of the DateAndTimeLookupInformationNugget class");
            fieldGeneratorComparisonRequested = new JSONHoldingBooleanGenerator("field \"ComparisonRequested\" of the DateAndTimeLookupInformationNugget class");
            fieldGeneratorIncludeTime = new JSONHoldingBooleanGenerator("field \"IncludeTime\" of the DateAndTimeLookupInformationNugget class");
            fieldGeneratorComparisonDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"ComparisonDateAndOrTimeSpec\" of the DateAndTimeLookupInformationNugget class", ignore_extras);
            fieldGeneratorComparisonDateAndOrTimeSpecEnd = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"ComparisonDateAndOrTimeSpecEnd\" of the DateAndTimeLookupInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DateAndTimeLookupInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"DateAndOrTimeSpec\" of the DateAndTimeLookupInformationNugget class", false);
            fieldGeneratorDestinationMapLocation = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocation\" of the DateAndTimeLookupInformationNugget class", false);
            fieldGeneratorDayOfWeekRequested = new JSONHoldingBooleanGenerator("field \"DayOfWeekRequested\" of the DateAndTimeLookupInformationNugget class");
            fieldGeneratorDateAndOrTimeSpecInFuture = new JSONHoldingBooleanGenerator("field \"DateAndOrTimeSpecInFuture\" of the DateAndTimeLookupInformationNugget class");
            fieldGeneratorComparisonRequested = new JSONHoldingBooleanGenerator("field \"ComparisonRequested\" of the DateAndTimeLookupInformationNugget class");
            fieldGeneratorIncludeTime = new JSONHoldingBooleanGenerator("field \"IncludeTime\" of the DateAndTimeLookupInformationNugget class");
            fieldGeneratorComparisonDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"ComparisonDateAndOrTimeSpec\" of the DateAndTimeLookupInformationNugget class", false);
            fieldGeneratorComparisonDateAndOrTimeSpecEnd = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"ComparisonDateAndOrTimeSpecEnd\" of the DateAndTimeLookupInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DateAndTimeLookupInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorDateAndOrTimeSpec.reset();
            fieldGeneratorDestinationMapLocation.reset();
            fieldGeneratorDayOfWeekRequested.reset();
            fieldGeneratorDateAndOrTimeSpecInFuture.reset();
            fieldGeneratorComparisonRequested.reset();
            fieldGeneratorIncludeTime.reset();
            fieldGeneratorComparisonDateAndOrTimeSpec.reset();
            fieldGeneratorComparisonDateAndOrTimeSpecEnd.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DateAndTimeLookupInformationNuggetJSON  result)
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
        public DateAndTimeLookupInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DateAndTimeLookupInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<DateAndTimeLookupInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DateAndTimeLookupInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DateAndTimeLookupInformationNuggetJSON>();
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
    public List<DateAndTimeLookupInformationNuggetJSON> value;
  };
  };
