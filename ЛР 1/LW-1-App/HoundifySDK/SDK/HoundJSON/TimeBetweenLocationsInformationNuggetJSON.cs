/* file "TimeBetweenLocationsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimeBetweenLocationsInformationNuggetJSON : DateAndTimeInformationNuggetJSON
  {
    private bool flagHasSourceMapLocation;
    private MapLocationJSON  storeSourceMapLocation;
    private bool flagHasDestinationMapLocation;
    private MapLocationJSON  storeDestinationMapLocation;
    private bool flagHasOffset;
    private double storeOffset;
    private string textStoreOffset;
    private bool flagHasUnits;
    private string storeUnits;
    private bool flagHasDateTimeRangeSpec;
    private DateTimeRangeSpecJSON  storeDateTimeRangeSpec;
    private bool flagHasSourceDateAndTime;
    private DateAndOrTimeJSON  storeSourceDateAndTime;
    private bool flagHasDestinationDateAndTime;
    private DateAndOrTimeJSON  storeDestinationDateAndTime;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSourceMapLocationToJSON()
      {
        JSONValueHandler handler_SourceMapLocation = new JSONValueHandler();
        storeSourceMapLocation.write_as_json(handler_SourceMapLocation);
        return handler_SourceMapLocation.result;
      }

    private JSONValue  extraDestinationMapLocationToJSON()
      {
        JSONValueHandler handler_DestinationMapLocation = new JSONValueHandler();
        storeDestinationMapLocation.write_as_json(handler_DestinationMapLocation);
        return handler_DestinationMapLocation.result;
      }

    private JSONValue  extraOffsetToJSON()
      {
        JSONValue generated_rational_Offset;
        if (textStoreOffset != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreOffset);
            generated_rational_Offset = handler.result;
          }
        else if (((double)(long)storeOffset) == storeOffset)
            generated_rational_Offset = new JSONIntegerValue((long)(storeOffset));
        else
            generated_rational_Offset = new JSONRationalValue(storeOffset, 15);
        return generated_rational_Offset;
      }

    private JSONValue  extraUnitsToJSON()
      {
        JSONStringValue generated_string_Units = new JSONStringValue(storeUnits);
        return generated_string_Units;
      }

    private JSONValue  extraDateTimeRangeSpecToJSON()
      {
        JSONValueHandler handler_DateTimeRangeSpec = new JSONValueHandler();
        storeDateTimeRangeSpec.write_as_json(handler_DateTimeRangeSpec);
        return handler_DateTimeRangeSpec.result;
      }

    private JSONValue  extraSourceDateAndTimeToJSON()
      {
        JSONValueHandler handler_SourceDateAndTime = new JSONValueHandler();
        storeSourceDateAndTime.write_as_json(handler_SourceDateAndTime);
        return handler_SourceDateAndTime.result;
      }

    private JSONValue  extraDestinationDateAndTimeToJSON()
      {
        JSONValueHandler handler_DestinationDateAndTime = new JSONValueHandler();
        storeDestinationDateAndTime.write_as_json(handler_DestinationDateAndTime);
        return handler_DestinationDateAndTime.result;
      }


    private void  fromJSONSourceMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setSourceMapLocation(convert_classy);
      }


    private void  fromJSONDestinationMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setDestinationMapLocation(convert_classy);
      }


    private void  fromJSONOffset(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Offset of TimeBetweenLocationsInformationNuggetJSON is not a number.");
              }
          }
        setOffsetText(the_rational_text);
      }


    private void  fromJSONUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Units of TimeBetweenLocationsInformationNuggetJSON is not a string.");
        setUnits(json_string.getData());
      }


    private void  fromJSONDateTimeRangeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateTimeRangeSpec(convert_classy);
      }


    private void  fromJSONSourceDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setSourceDateAndTime(convert_classy);
      }


    private void  fromJSONDestinationDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setDestinationDateAndTime(convert_classy);
      }


    public TimeBetweenLocationsInformationNuggetJSON()
      {
        flagHasSourceMapLocation = false;
        flagHasDestinationMapLocation = false;
        flagHasOffset = false;
        flagHasUnits = false;
        flagHasDateTimeRangeSpec = false;
        flagHasSourceDateAndTime = false;
        flagHasDestinationDateAndTime = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDateAndTimeNuggetKind()
      {
        return "TimeBetweenLocations";
      }

    public bool  hasSourceMapLocation()
      {
        return flagHasSourceMapLocation;
      }

    public MapLocationJSON   getSourceMapLocation()
      {
        Debug.Assert(flagHasSourceMapLocation);
        return storeSourceMapLocation;
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

    public bool  hasOffset()
      {
        return flagHasOffset;
      }

    public double  getOffset()
      {
        Debug.Assert(flagHasOffset);
        if (textStoreOffset != "")
          {
            return Double.Parse(textStoreOffset);
          }
        return storeOffset;
      }

    public string  getOffsetAsText()
      {
        Debug.Assert(flagHasOffset);
        if (textStoreOffset == "")
          {
            return Convert.ToString(storeOffset);
          }
        else
          {
            return (textStoreOffset);
          }
      }

    public bool  hasUnits()
      {
        return flagHasUnits;
      }

    public string  getUnits()
      {
        Debug.Assert(flagHasUnits);
        return storeUnits;
      }

    public bool  hasDateTimeRangeSpec()
      {
        return flagHasDateTimeRangeSpec;
      }

    public DateTimeRangeSpecJSON   getDateTimeRangeSpec()
      {
        Debug.Assert(flagHasDateTimeRangeSpec);
        return storeDateTimeRangeSpec;
      }

    public bool  hasSourceDateAndTime()
      {
        return flagHasSourceDateAndTime;
      }

    public DateAndOrTimeJSON   getSourceDateAndTime()
      {
        Debug.Assert(flagHasSourceDateAndTime);
        return storeSourceDateAndTime;
      }

    public bool  hasDestinationDateAndTime()
      {
        return flagHasDestinationDateAndTime;
      }

    public DateAndOrTimeJSON   getDestinationDateAndTime()
      {
        Debug.Assert(flagHasDestinationDateAndTime);
        return storeDestinationDateAndTime;
      }


    public virtual int extraTimeBetweenLocationsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimeBetweenLocationsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimeBetweenLocationsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimeBetweenLocationsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDateAndTimeInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasSourceMapLocation)
            ++result;
        if (flagHasDestinationMapLocation)
            ++result;
        if (flagHasOffset)
            ++result;
        if (flagHasUnits)
            ++result;
        if (flagHasDateTimeRangeSpec)
            ++result;
        if (flagHasSourceDateAndTime)
            ++result;
        if (flagHasDestinationDateAndTime)
            ++result;
        result += extraTimeBetweenLocationsInformationNuggetComponentCount();
        return result;
      }
    public override string extraDateAndTimeInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSourceMapLocation)
          {
            if (remainder == 0)
                return "SourceMapLocation";
            --remainder;
          }
        if (flagHasDestinationMapLocation)
          {
            if (remainder == 0)
                return "DestinationMapLocation";
            --remainder;
          }
        if (flagHasOffset)
          {
            if (remainder == 0)
                return "Offset";
            --remainder;
          }
        if (flagHasUnits)
          {
            if (remainder == 0)
                return "Units";
            --remainder;
          }
        if (flagHasDateTimeRangeSpec)
          {
            if (remainder == 0)
                return "DateTimeRangeSpec";
            --remainder;
          }
        if (flagHasSourceDateAndTime)
          {
            if (remainder == 0)
                return "SourceDateAndTime";
            --remainder;
          }
        if (flagHasDestinationDateAndTime)
          {
            if (remainder == 0)
                return "DestinationDateAndTime";
            --remainder;
          }
        return extraTimeBetweenLocationsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSourceMapLocation)
          {
            if (remainder == 0)
                return extraSourceMapLocationToJSON();
            --remainder;
          }
        if (flagHasDestinationMapLocation)
          {
            if (remainder == 0)
                return extraDestinationMapLocationToJSON();
            --remainder;
          }
        if (flagHasOffset)
          {
            if (remainder == 0)
                return extraOffsetToJSON();
            --remainder;
          }
        if (flagHasUnits)
          {
            if (remainder == 0)
                return extraUnitsToJSON();
            --remainder;
          }
        if (flagHasDateTimeRangeSpec)
          {
            if (remainder == 0)
                return extraDateTimeRangeSpecToJSON();
            --remainder;
          }
        if (flagHasSourceDateAndTime)
          {
            if (remainder == 0)
                return extraSourceDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasDestinationDateAndTime)
          {
            if (remainder == 0)
                return extraDestinationDateAndTimeToJSON();
            --remainder;
          }
        return extraTimeBetweenLocationsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "teTimeRangeSpec", 0, 15, false) == 0) && (field_name.Length == 17))
                            return (flagHasDateTimeRangeSpec ? extraDateTimeRangeSpecToJSON() : null);
                        break;
                    case 'e':
                        if (String.Compare(field_name, 2, "stination", 0, 9, false) == 0)
                          {
                            switch (field_name[11])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 12, "ateAndTime", 0, 10, false) == 0) && (field_name.Length == 22))
                                        return (flagHasDestinationDateAndTime ? extraDestinationDateAndTimeToJSON() : null);
                                    break;
                                case 'M':
                                    if ((String.Compare(field_name, 12, "apLocation", 0, 10, false) == 0) && (field_name.Length == 22))
                                        return (flagHasDestinationMapLocation ? extraDestinationMapLocationToJSON() : null);
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
            case 'O':
                if ((String.Compare(field_name, 1, "ffset", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasOffset ? extraOffsetToJSON() : null);
                break;
            case 'S':
                if (String.Compare(field_name, 1, "ource", 0, 5, false) == 0)
                  {
                    switch (field_name[6])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 7, "ateAndTime", 0, 10, false) == 0) && (field_name.Length == 17))
                                return (flagHasSourceDateAndTime ? extraSourceDateAndTimeToJSON() : null);
                            break;
                        case 'M':
                            if ((String.Compare(field_name, 7, "apLocation", 0, 10, false) == 0) && (field_name.Length == 17))
                                return (flagHasSourceMapLocation ? extraSourceMapLocationToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "nits", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasUnits ? extraUnitsToJSON() : null);
                break;
            default:
                break;
          }
        return extraTimeBetweenLocationsInformationNuggetLookup(field_name);
      }

    public void setSourceMapLocation(MapLocationJSON  new_value)
      {
        if (flagHasSourceMapLocation)
          {
          }
        flagHasSourceMapLocation = true;
        storeSourceMapLocation = new_value;
      }
    public void unsetSourceMapLocation()
      {
        if (flagHasSourceMapLocation)
          {
          }
        flagHasSourceMapLocation = false;
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
    public void setOffset(double new_value)
      {
        flagHasOffset = true;
        storeOffset = new_value;
        textStoreOffset = "";
      }
    public void setOffsetText(string new_value)
      {
        flagHasOffset = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Offset of TimeBetweenLocationsInformationNuggetJSON is not a valid number.");
        textStoreOffset = new_value;
      }
    public void unsetOffset()
      {
        flagHasOffset = false;
      }
    public void setUnits(string new_value)
      {
        flagHasUnits = true;
        storeUnits = new_value;
      }
    public void unsetUnits()
      {
        flagHasUnits = false;
      }
    public void setDateTimeRangeSpec(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasDateTimeRangeSpec)
          {
          }
        flagHasDateTimeRangeSpec = true;
        storeDateTimeRangeSpec = new_value;
      }
    public void unsetDateTimeRangeSpec()
      {
        if (flagHasDateTimeRangeSpec)
          {
          }
        flagHasDateTimeRangeSpec = false;
      }
    public void setSourceDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasSourceDateAndTime)
          {
          }
        flagHasSourceDateAndTime = true;
        storeSourceDateAndTime = new_value;
      }
    public void unsetSourceDateAndTime()
      {
        if (flagHasSourceDateAndTime)
          {
          }
        flagHasSourceDateAndTime = false;
      }
    public void setDestinationDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasDestinationDateAndTime)
          {
          }
        flagHasDestinationDateAndTime = true;
        storeDestinationDateAndTime = new_value;
      }
    public void unsetDestinationDateAndTime()
      {
        if (flagHasDestinationDateAndTime)
          {
          }
        flagHasDestinationDateAndTime = false;
      }

    public virtual void extraTimeBetweenLocationsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimeBetweenLocationsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimeBetweenLocationsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraTimeBetweenLocationsInformationNuggetAppendPair(key, new_component);
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
            case 'D':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "teTimeRangeSpec", 0, 15, false) == 0) && (key.Length == 17))
                            {
                            fromJSONDateTimeRangeSpec(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if (String.Compare(key, 2, "stination", 0, 9, false) == 0)
                          {
                            switch (key[11])
                              {
                                case 'D':
                                    if ((String.Compare(key, 12, "ateAndTime", 0, 10, false) == 0) && (key.Length == 22))
                                        {
                                        fromJSONDestinationDateAndTime(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'M':
                                    if ((String.Compare(key, 12, "apLocation", 0, 10, false) == 0) && (key.Length == 22))
                                        {
                                        fromJSONDestinationMapLocation(new_component, false);
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
            case 'O':
                if ((String.Compare(key, 1, "ffset", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONOffset(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if (String.Compare(key, 1, "ource", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'D':
                            if ((String.Compare(key, 7, "ateAndTime", 0, 10, false) == 0) && (key.Length == 17))
                                {
                                fromJSONSourceDateAndTime(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 7, "apLocation", 0, 10, false) == 0) && (key.Length == 17))
                                {
                                fromJSONSourceMapLocation(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if ((String.Compare(key, 1, "nits", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONUnits(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraTimeBetweenLocationsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "teTimeRangeSpec", 0, 15, false) == 0) && (key.Length == 17))
                            {
                            fromJSONDateTimeRangeSpec(new_component, false);
                            return;
                            }
                        break;
                    case 'e':
                        if (String.Compare(key, 2, "stination", 0, 9, false) == 0)
                          {
                            switch (key[11])
                              {
                                case 'D':
                                    if ((String.Compare(key, 12, "ateAndTime", 0, 10, false) == 0) && (key.Length == 22))
                                        {
                                        fromJSONDestinationDateAndTime(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'M':
                                    if ((String.Compare(key, 12, "apLocation", 0, 10, false) == 0) && (key.Length == 22))
                                        {
                                        fromJSONDestinationMapLocation(new_component, false);
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
            case 'O':
                if ((String.Compare(key, 1, "ffset", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONOffset(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if (String.Compare(key, 1, "ource", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'D':
                            if ((String.Compare(key, 7, "ateAndTime", 0, 10, false) == 0) && (key.Length == 17))
                                {
                                fromJSONSourceDateAndTime(new_component, false);
                                return;
                                }
                            break;
                        case 'M':
                            if ((String.Compare(key, 7, "apLocation", 0, 10, false) == 0) && (key.Length == 17))
                                {
                                fromJSONSourceMapLocation(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if ((String.Compare(key, 1, "nits", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONUnits(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraTimeBetweenLocationsInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSourceMapLocation);
        if (flagHasSourceMapLocation)
          {
            handler.start_pair("SourceMapLocation");
            if (partial_allowed)
                storeSourceMapLocation.write_partial_as_json(handler);
            else
                storeSourceMapLocation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDestinationMapLocation);
        if (flagHasDestinationMapLocation)
          {
            handler.start_pair("DestinationMapLocation");
            if (partial_allowed)
                storeDestinationMapLocation.write_partial_as_json(handler);
            else
                storeDestinationMapLocation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasOffset);
        if (flagHasOffset)
          {
            handler.start_pair("Offset");
            if (textStoreOffset != "")
                handler.number_value(textStoreOffset);
            else if (((double)(long)storeOffset) == storeOffset)
                handler.number_value((long)storeOffset);
            else
                handler.number_value(storeOffset);
          }
        Debug.Assert(partial_allowed || flagHasUnits);
        if (flagHasUnits)
          {
            handler.start_pair("Units");
            handler.string_value(storeUnits);
          }
        Debug.Assert(partial_allowed || flagHasDateTimeRangeSpec);
        if (flagHasDateTimeRangeSpec)
          {
            handler.start_pair("DateTimeRangeSpec");
            if (partial_allowed)
                storeDateTimeRangeSpec.write_partial_as_json(handler);
            else
                storeDateTimeRangeSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasSourceDateAndTime);
        if (flagHasSourceDateAndTime)
          {
            handler.start_pair("SourceDateAndTime");
            if (partial_allowed)
                storeSourceDateAndTime.write_partial_as_json(handler);
            else
                storeSourceDateAndTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDestinationDateAndTime);
        if (flagHasDestinationDateAndTime)
          {
            handler.start_pair("DestinationDateAndTime");
            if (partial_allowed)
                storeDestinationDateAndTime.write_partial_as_json(handler);
            else
                storeDestinationDateAndTime.write_as_json(handler);
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
        if (!(hasSourceMapLocation()))
          {
            return "When parsing the object for %what%, the \"SourceMapLocation\" field was missing.";
          }
        if (!(hasDestinationMapLocation()))
          {
            return "When parsing the object for %what%, the \"DestinationMapLocation\" field was missing.";
          }
        if (!(hasOffset()))
          {
            return "When parsing the object for %what%, the \"Offset\" field was missing.";
          }
        if (!(hasUnits()))
          {
            return "When parsing the object for %what%, the \"Units\" field was missing.";
          }
        if (!(hasDateTimeRangeSpec()))
          {
            return "When parsing the object for %what%, the \"DateTimeRangeSpec\" field was missing.";
          }
        if (!(hasSourceDateAndTime()))
          {
            return "When parsing the object for %what%, the \"SourceDateAndTime\" field was missing.";
          }
        if (!(hasDestinationDateAndTime()))
          {
            return "When parsing the object for %what%, the \"DestinationDateAndTime\" field was missing.";
          }
        return null;
      }

    public static new TimeBetweenLocationsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeBetweenLocationsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenLocationsInformationNugget", ignore_extras);
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
    public static new TimeBetweenLocationsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimeBetweenLocationsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeBetweenLocationsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenLocationsInformationNugget", ignore_extras);
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
    public static new TimeBetweenLocationsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimeBetweenLocationsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        TimeBetweenLocationsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenLocationsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimeBetweenLocationsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TimeBetweenLocationsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimeBetweenLocationsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenLocationsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DateAndTimeInformationNuggetJSON.Generator
      {
        private MapLocationJSON.HoldingGenerator fieldGeneratorSourceMapLocation;
        private MapLocationJSON.HoldingGenerator fieldGeneratorDestinationMapLocation;
        private JSONHoldingNumberTextGenerator fieldGeneratorOffset;
        private JSONHoldingStringGenerator fieldGeneratorUnits;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateTimeRangeSpec;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorSourceDateAndTime;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorDestinationDateAndTime;
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
            if (!(getDateAndTimeInformationNuggetJSONKey().Equals("TimeBetweenLocations")))
                throw new Exception("The key field has a value other than `TimeBetweenLocations'.");
            TimeBetweenLocationsInformationNuggetJSON result = new TimeBetweenLocationsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimeBetweenLocationsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DateAndTimeInformationNuggetJSON new_result)
          {
            handle_result((TimeBetweenLocationsInformationNuggetJSON )new_result);
          }
        protected void finish(TimeBetweenLocationsInformationNuggetJSON result)
          {
            if (fieldGeneratorSourceMapLocation.have_value)
              {
                result.setSourceMapLocation(fieldGeneratorSourceMapLocation.value);
                fieldGeneratorSourceMapLocation.have_value = false;
              }
            else if ((!(result.hasSourceMapLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SourceMapLocation\" field was missing.");
              }
            if (fieldGeneratorDestinationMapLocation.have_value)
              {
                result.setDestinationMapLocation(fieldGeneratorDestinationMapLocation.value);
                fieldGeneratorDestinationMapLocation.have_value = false;
              }
            else if ((!(result.hasDestinationMapLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DestinationMapLocation\" field was missing.");
              }
            if (fieldGeneratorOffset.have_value)
              {
                result.setOffsetText(fieldGeneratorOffset.value);
                fieldGeneratorOffset.have_value = false;
              }
            else if ((!(result.hasOffset())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Offset\" field was missing.");
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
            if (fieldGeneratorDateTimeRangeSpec.have_value)
              {
                result.setDateTimeRangeSpec(fieldGeneratorDateTimeRangeSpec.value);
                fieldGeneratorDateTimeRangeSpec.have_value = false;
              }
            else if ((!(result.hasDateTimeRangeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateTimeRangeSpec\" field was missing.");
              }
            if (fieldGeneratorSourceDateAndTime.have_value)
              {
                result.setSourceDateAndTime(fieldGeneratorSourceDateAndTime.value);
                fieldGeneratorSourceDateAndTime.have_value = false;
              }
            else if ((!(result.hasSourceDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SourceDateAndTime\" field was missing.");
              }
            if (fieldGeneratorDestinationDateAndTime.have_value)
              {
                result.setDestinationDateAndTime(fieldGeneratorDestinationDateAndTime.value);
                fieldGeneratorDestinationDateAndTime.have_value = false;
              }
            else if ((!(result.hasDestinationDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DestinationDateAndTime\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(TimeBetweenLocationsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "teTimeRangeSpec", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorDateTimeRangeSpec;
                            break;
                        case 'e':
                            if (String.Compare(field_name, 2, "stination", 0, 9, false) == 0)
                              {
                                switch (field_name[11])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 12, "ateAndTime", 0, 10, false) == 0) && (field_name.Length == 22))
                                            return fieldGeneratorDestinationDateAndTime;
                                        break;
                                    case 'M':
                                        if ((String.Compare(field_name, 12, "apLocation", 0, 10, false) == 0) && (field_name.Length == 22))
                                            return fieldGeneratorDestinationMapLocation;
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
                case 'O':
                    if ((String.Compare(field_name, 1, "ffset", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorOffset;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "ource", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 7, "ateAndTime", 0, 10, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorSourceDateAndTime;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 7, "apLocation", 0, 10, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorSourceMapLocation;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nits", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorUnits;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSourceMapLocation = new MapLocationJSON.HoldingGenerator("field \"SourceMapLocation\" of the TimeBetweenLocationsInformationNugget class", ignore_extras);
            fieldGeneratorDestinationMapLocation = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocation\" of the TimeBetweenLocationsInformationNugget class", ignore_extras);
            fieldGeneratorOffset = new JSONHoldingNumberTextGenerator("field \"Offset\" of the TimeBetweenLocationsInformationNugget class");
            fieldGeneratorUnits = new JSONHoldingStringGenerator("field \"Units\" of the TimeBetweenLocationsInformationNugget class");
            fieldGeneratorDateTimeRangeSpec = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRangeSpec\" of the TimeBetweenLocationsInformationNugget class", ignore_extras);
            fieldGeneratorSourceDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"SourceDateAndTime\" of the TimeBetweenLocationsInformationNugget class", ignore_extras);
            fieldGeneratorDestinationDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DestinationDateAndTime\" of the TimeBetweenLocationsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimeBetweenLocationsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSourceMapLocation = new MapLocationJSON.HoldingGenerator("field \"SourceMapLocation\" of the TimeBetweenLocationsInformationNugget class", false);
            fieldGeneratorDestinationMapLocation = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocation\" of the TimeBetweenLocationsInformationNugget class", false);
            fieldGeneratorOffset = new JSONHoldingNumberTextGenerator("field \"Offset\" of the TimeBetweenLocationsInformationNugget class");
            fieldGeneratorUnits = new JSONHoldingStringGenerator("field \"Units\" of the TimeBetweenLocationsInformationNugget class");
            fieldGeneratorDateTimeRangeSpec = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRangeSpec\" of the TimeBetweenLocationsInformationNugget class", false);
            fieldGeneratorSourceDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"SourceDateAndTime\" of the TimeBetweenLocationsInformationNugget class", false);
            fieldGeneratorDestinationDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DestinationDateAndTime\" of the TimeBetweenLocationsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimeBetweenLocationsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorSourceMapLocation.reset();
            fieldGeneratorDestinationMapLocation.reset();
            fieldGeneratorOffset.reset();
            fieldGeneratorUnits.reset();
            fieldGeneratorDateTimeRangeSpec.reset();
            fieldGeneratorSourceDateAndTime.reset();
            fieldGeneratorDestinationDateAndTime.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TimeBetweenLocationsInformationNuggetJSON  result)
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
        public TimeBetweenLocationsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimeBetweenLocationsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<TimeBetweenLocationsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimeBetweenLocationsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimeBetweenLocationsInformationNuggetJSON>();
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
    public List<TimeBetweenLocationsInformationNuggetJSON> value;
  };
  };
