/* file "SunriseSunsetTimeInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SunriseSunsetTimeInformationNuggetJSON : DateAndTimeInformationNuggetJSON
  {
    private bool flagHasMapLocation;
    private MapLocationJSON  storeMapLocation;
    private bool flagHasRequestedType;
    private string storeRequestedType;
    private bool flagHasDateTimeRangeSpec;
    private DateTimeRangeSpecJSON  storeDateTimeRangeSpec;
    private bool flagHasRequestedInThePast;
    private bool storeRequestedInThePast;
    private bool flagHasCalculatedDateAndTimes;
    private List< DateAndOrTimeJSON  > storeCalculatedDateAndTimes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraMapLocationToJSON()
      {
        JSONValueHandler handler_MapLocation = new JSONValueHandler();
        storeMapLocation.write_as_json(handler_MapLocation);
        return handler_MapLocation.result;
      }

    private JSONValue  extraRequestedTypeToJSON()
      {
        JSONStringValue generated_string_RequestedType = new JSONStringValue(storeRequestedType);
        return generated_string_RequestedType;
      }

    private JSONValue  extraDateTimeRangeSpecToJSON()
      {
        JSONValueHandler handler_DateTimeRangeSpec = new JSONValueHandler();
        storeDateTimeRangeSpec.write_as_json(handler_DateTimeRangeSpec);
        return handler_DateTimeRangeSpec.result;
      }

    private JSONValue  extraRequestedInThePastToJSON()
      {
        JSONValue generated_boolean_RequestedInThePast = (storeRequestedInThePast ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestedInThePast;
      }

    private JSONValue  extraCalculatedDateAndTimesToJSON()
      {
        JSONArrayValue generated_array_1_CalculatedDateAndTimes = new JSONArrayValue();
        for (int num1 = 0; num1 < storeCalculatedDateAndTimes.Count; ++num1)
          {
            JSONValueHandler handler_CalculatedDateAndTimes = new JSONValueHandler();
            storeCalculatedDateAndTimes[num1].write_as_json(handler_CalculatedDateAndTimes);
            generated_array_1_CalculatedDateAndTimes.appendComponent(handler_CalculatedDateAndTimes.result);
          }
        return generated_array_1_CalculatedDateAndTimes;
      }


    private void  fromJSONMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setMapLocation(convert_classy);
      }


    private void  fromJSONRequestedType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RequestedType of SunriseSunsetTimeInformationNuggetJSON is not a string.");
        setRequestedType(json_string.getData());
      }


    private void  fromJSONDateTimeRangeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateTimeRangeSpec(convert_classy);
      }


    private void  fromJSONRequestedInThePast(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestedInThePast of SunriseSunsetTimeInformationNuggetJSON is not true for false.");
              }
          }
        setRequestedInThePast(the_bool);
      }


    private void  fromJSONCalculatedDateAndTimes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CalculatedDateAndTimes of SunriseSunsetTimeInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DateAndOrTimeJSON  > vector_CalculatedDateAndTimes1 = new List< DateAndOrTimeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_CalculatedDateAndTimes1.Add(convert_classy);
          }
        initCalculatedDateAndTimes();
        for (int num1 = 0; num1 < vector_CalculatedDateAndTimes1.Count; ++num1)
            appendCalculatedDateAndTimes(vector_CalculatedDateAndTimes1[num1]);
        for (int num1 = 0; num1 < vector_CalculatedDateAndTimes1.Count; ++num1)
          {
          }
      }


    public SunriseSunsetTimeInformationNuggetJSON()
      {
        flagHasMapLocation = false;
        flagHasRequestedType = false;
        flagHasDateTimeRangeSpec = false;
        flagHasRequestedInThePast = false;
        flagHasCalculatedDateAndTimes = false;
        storeRequestedInThePast = false;
        storeCalculatedDateAndTimes = new List< DateAndOrTimeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDateAndTimeNuggetKind()
      {
        return "SunriseSunsetTime";
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

    public bool  hasRequestedType()
      {
        return flagHasRequestedType;
      }

    public string  getRequestedType()
      {
        Debug.Assert(flagHasRequestedType);
        return storeRequestedType;
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

    public bool  hasRequestedInThePast()
      {
        return flagHasRequestedInThePast;
      }

    public bool  getRequestedInThePast()
      {
        return storeRequestedInThePast;
      }

    public bool  hasCalculatedDateAndTimes()
      {
        return flagHasCalculatedDateAndTimes;
      }

    public int  countOfCalculatedDateAndTimes()
      {
        Debug.Assert(flagHasCalculatedDateAndTimes);
        return storeCalculatedDateAndTimes.Count;
      }

    public DateAndOrTimeJSON   elementOfCalculatedDateAndTimes(int element_num)
      {
        Debug.Assert(flagHasCalculatedDateAndTimes);
        return storeCalculatedDateAndTimes[element_num];
      }

    public List< DateAndOrTimeJSON  >  getCalculatedDateAndTimes()
      {
        Debug.Assert(flagHasCalculatedDateAndTimes);
        return storeCalculatedDateAndTimes;
      }


    public virtual int extraSunriseSunsetTimeInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSunriseSunsetTimeInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSunriseSunsetTimeInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSunriseSunsetTimeInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDateAndTimeInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasMapLocation)
            ++result;
        if (flagHasRequestedType)
            ++result;
        if (flagHasDateTimeRangeSpec)
            ++result;
        if (flagHasRequestedInThePast)
            ++result;
        if (flagHasCalculatedDateAndTimes)
            ++result;
        result += extraSunriseSunsetTimeInformationNuggetComponentCount();
        return result;
      }
    public override string extraDateAndTimeInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasMapLocation)
          {
            if (remainder == 0)
                return "MapLocation";
            --remainder;
          }
        if (flagHasRequestedType)
          {
            if (remainder == 0)
                return "RequestedType";
            --remainder;
          }
        if (flagHasDateTimeRangeSpec)
          {
            if (remainder == 0)
                return "DateTimeRangeSpec";
            --remainder;
          }
        if (flagHasRequestedInThePast)
          {
            if (remainder == 0)
                return "RequestedInThePast";
            --remainder;
          }
        if (flagHasCalculatedDateAndTimes)
          {
            if (remainder == 0)
                return "CalculatedDateAndTimes";
            --remainder;
          }
        return extraSunriseSunsetTimeInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasMapLocation)
          {
            if (remainder == 0)
                return extraMapLocationToJSON();
            --remainder;
          }
        if (flagHasRequestedType)
          {
            if (remainder == 0)
                return extraRequestedTypeToJSON();
            --remainder;
          }
        if (flagHasDateTimeRangeSpec)
          {
            if (remainder == 0)
                return extraDateTimeRangeSpecToJSON();
            --remainder;
          }
        if (flagHasRequestedInThePast)
          {
            if (remainder == 0)
                return extraRequestedInThePastToJSON();
            --remainder;
          }
        if (flagHasCalculatedDateAndTimes)
          {
            if (remainder == 0)
                return extraCalculatedDateAndTimesToJSON();
            --remainder;
          }
        return extraSunriseSunsetTimeInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "alculatedDateAndTimes", 0, 21, false) == 0) && (field_name.Length == 22))
                    return (flagHasCalculatedDateAndTimes ? extraCalculatedDateAndTimesToJSON() : null);
                break;
            case 'D':
                if ((String.Compare(field_name, 1, "ateTimeRangeSpec", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasDateTimeRangeSpec ? extraDateTimeRangeSpecToJSON() : null);
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasMapLocation ? extraMapLocationToJSON() : null);
                break;
            case 'R':
                if (String.Compare(field_name, 1, "equested", 0, 8, false) == 0)
                  {
                    switch (field_name[9])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 10, "nThePast", 0, 8, false) == 0) && (field_name.Length == 18))
                                return (flagHasRequestedInThePast ? extraRequestedInThePastToJSON() : null);
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 10, "ype", 0, 3, false) == 0) && (field_name.Length == 13))
                                return (flagHasRequestedType ? extraRequestedTypeToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraSunriseSunsetTimeInformationNuggetLookup(field_name);
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
    public void setRequestedType(string new_value)
      {
        flagHasRequestedType = true;
        storeRequestedType = new_value;
      }
    public void unsetRequestedType()
      {
        flagHasRequestedType = false;
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
    public void setRequestedInThePast(bool new_value)
      {
        flagHasRequestedInThePast = true;
        storeRequestedInThePast = new_value;
      }
    public void unsetRequestedInThePast()
      {
        flagHasRequestedInThePast = false;
      }
    public void initCalculatedDateAndTimes()
      {
        if (flagHasCalculatedDateAndTimes)
          {
            for (int num1 = 0; num1 < storeCalculatedDateAndTimes.Count; ++num1)
              {
              }
          }
        flagHasCalculatedDateAndTimes = true;
        storeCalculatedDateAndTimes.Clear();
      }
    public void appendCalculatedDateAndTimes(DateAndOrTimeJSON  to_append)
      {
        if (!flagHasCalculatedDateAndTimes)
          {
            flagHasCalculatedDateAndTimes = true;
            storeCalculatedDateAndTimes.Clear();
          }
        Debug.Assert(flagHasCalculatedDateAndTimes);
        storeCalculatedDateAndTimes.Add(to_append);
      }
    public void unsetCalculatedDateAndTimes()
      {
        if (flagHasCalculatedDateAndTimes)
          {
            for (int num2 = 0; num2 < storeCalculatedDateAndTimes.Count; ++num2)
              {
              }
          }
        flagHasCalculatedDateAndTimes = false;
        storeCalculatedDateAndTimes.Clear();
      }

    public virtual void extraSunriseSunsetTimeInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSunriseSunsetTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSunriseSunsetTimeInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraSunriseSunsetTimeInformationNuggetAppendPair(key, new_component);
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
                if ((String.Compare(key, 1, "alculatedDateAndTimes", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONCalculatedDateAndTimes(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "ateTimeRangeSpec", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONDateTimeRangeSpec(new_component, false);
                    return;
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
                if (String.Compare(key, 1, "equested", 0, 8, false) == 0)
                  {
                    switch (key[9])
                      {
                        case 'I':
                            if ((String.Compare(key, 10, "nThePast", 0, 8, false) == 0) && (key.Length == 18))
                                {
                                fromJSONRequestedInThePast(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 10, "ype", 0, 3, false) == 0) && (key.Length == 13))
                                {
                                fromJSONRequestedType(new_component, false);
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
        extraSunriseSunsetTimeInformationNuggetAppendPair(key, new_component);
      }
    public override void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "alculatedDateAndTimes", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONCalculatedDateAndTimes(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "ateTimeRangeSpec", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONDateTimeRangeSpec(new_component, false);
                    return;
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
                if (String.Compare(key, 1, "equested", 0, 8, false) == 0)
                  {
                    switch (key[9])
                      {
                        case 'I':
                            if ((String.Compare(key, 10, "nThePast", 0, 8, false) == 0) && (key.Length == 18))
                                {
                                fromJSONRequestedInThePast(new_component, false);
                                return;
                                }
                            break;
                        case 'T':
                            if ((String.Compare(key, 10, "ype", 0, 3, false) == 0) && (key.Length == 13))
                                {
                                fromJSONRequestedType(new_component, false);
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
        extraSunriseSunsetTimeInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasMapLocation);
        if (flagHasMapLocation)
          {
            handler.start_pair("MapLocation");
            if (partial_allowed)
                storeMapLocation.write_partial_as_json(handler);
            else
                storeMapLocation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRequestedType);
        if (flagHasRequestedType)
          {
            handler.start_pair("RequestedType");
            handler.string_value(storeRequestedType);
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
        Debug.Assert(partial_allowed || flagHasRequestedInThePast);
        if (flagHasRequestedInThePast)
          {
            handler.start_pair("RequestedInThePast");
            handler.boolean_value(storeRequestedInThePast);
          }
        Debug.Assert(partial_allowed || flagHasCalculatedDateAndTimes);
        if (flagHasCalculatedDateAndTimes)
          {
            handler.start_pair("CalculatedDateAndTimes");
            handler.start_array();
            for (int num1 = 0; num1 < storeCalculatedDateAndTimes.Count; ++num1)
              {
                if (partial_allowed)
                    storeCalculatedDateAndTimes[num1].write_partial_as_json(handler);
                else
                    storeCalculatedDateAndTimes[num1].write_as_json(handler);
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
        if (!(hasMapLocation()))
          {
            return "When parsing the object for %what%, the \"MapLocation\" field was missing.";
          }
        if (!(hasRequestedType()))
          {
            return "When parsing the object for %what%, the \"RequestedType\" field was missing.";
          }
        if (!(hasDateTimeRangeSpec()))
          {
            return "When parsing the object for %what%, the \"DateTimeRangeSpec\" field was missing.";
          }
        if (!(hasRequestedInThePast()))
          {
            return "When parsing the object for %what%, the \"RequestedInThePast\" field was missing.";
          }
        if (!(hasCalculatedDateAndTimes()))
          {
            return "When parsing the object for %what%, the \"CalculatedDateAndTimes\" field was missing.";
          }
        return null;
      }

    public static new SunriseSunsetTimeInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SunriseSunsetTimeInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SunriseSunsetTimeInformationNugget", ignore_extras);
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
    public static new SunriseSunsetTimeInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SunriseSunsetTimeInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SunriseSunsetTimeInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SunriseSunsetTimeInformationNugget", ignore_extras);
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
    public static new SunriseSunsetTimeInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SunriseSunsetTimeInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        SunriseSunsetTimeInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SunriseSunsetTimeInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SunriseSunsetTimeInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SunriseSunsetTimeInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SunriseSunsetTimeInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SunriseSunsetTimeInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DateAndTimeInformationNuggetJSON.Generator
      {
        private MapLocationJSON.HoldingGenerator fieldGeneratorMapLocation;
        private JSONHoldingStringGenerator fieldGeneratorRequestedType;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateTimeRangeSpec;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestedInThePast;
        private DateAndOrTimeJSON.HoldingArrayGenerator fieldGeneratorCalculatedDateAndTimes;
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
            if (!(getDateAndTimeInformationNuggetJSONKey().Equals("SunriseSunsetTime")))
                throw new Exception("The key field has a value other than `SunriseSunsetTime'.");
            SunriseSunsetTimeInformationNuggetJSON result = new SunriseSunsetTimeInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSunriseSunsetTimeInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DateAndTimeInformationNuggetJSON new_result)
          {
            handle_result((SunriseSunsetTimeInformationNuggetJSON )new_result);
          }
        protected void finish(SunriseSunsetTimeInformationNuggetJSON result)
          {
            if (fieldGeneratorMapLocation.have_value)
              {
                result.setMapLocation(fieldGeneratorMapLocation.value);
                fieldGeneratorMapLocation.have_value = false;
              }
            else if ((!(result.hasMapLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MapLocation\" field was missing.");
              }
            if (fieldGeneratorRequestedType.have_value)
              {
                result.setRequestedType(fieldGeneratorRequestedType.value);
                fieldGeneratorRequestedType.have_value = false;
              }
            else if ((!(result.hasRequestedType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedType\" field was missing.");
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
            if (fieldGeneratorRequestedInThePast.have_value)
              {
                result.setRequestedInThePast(fieldGeneratorRequestedInThePast.value);
                fieldGeneratorRequestedInThePast.have_value = false;
              }
            else if ((!(result.hasRequestedInThePast())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedInThePast\" field was missing.");
              }
            if (fieldGeneratorCalculatedDateAndTimes.have_value)
              {
                result.initCalculatedDateAndTimes();
                int count = fieldGeneratorCalculatedDateAndTimes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCalculatedDateAndTimes(fieldGeneratorCalculatedDateAndTimes.value[num]);
                  }
                fieldGeneratorCalculatedDateAndTimes.value.Clear();
                fieldGeneratorCalculatedDateAndTimes.have_value = false;
              }
            else if ((!(result.hasCalculatedDateAndTimes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CalculatedDateAndTimes\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SunriseSunsetTimeInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "alculatedDateAndTimes", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorCalculatedDateAndTimes;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ateTimeRangeSpec", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorDateTimeRangeSpec;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMapLocation;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "equested", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 10, "nThePast", 0, 8, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorRequestedInThePast;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 10, "ype", 0, 3, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorRequestedType;
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
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the SunriseSunsetTimeInformationNugget class", ignore_extras);
            fieldGeneratorRequestedType = new JSONHoldingStringGenerator("field \"RequestedType\" of the SunriseSunsetTimeInformationNugget class");
            fieldGeneratorDateTimeRangeSpec = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRangeSpec\" of the SunriseSunsetTimeInformationNugget class", ignore_extras);
            fieldGeneratorRequestedInThePast = new JSONHoldingBooleanGenerator("field \"RequestedInThePast\" of the SunriseSunsetTimeInformationNugget class");
            fieldGeneratorCalculatedDateAndTimes = new DateAndOrTimeJSON.HoldingArrayGenerator("field \"CalculatedDateAndTimes\" of the SunriseSunsetTimeInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SunriseSunsetTimeInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the SunriseSunsetTimeInformationNugget class", false);
            fieldGeneratorRequestedType = new JSONHoldingStringGenerator("field \"RequestedType\" of the SunriseSunsetTimeInformationNugget class");
            fieldGeneratorDateTimeRangeSpec = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRangeSpec\" of the SunriseSunsetTimeInformationNugget class", false);
            fieldGeneratorRequestedInThePast = new JSONHoldingBooleanGenerator("field \"RequestedInThePast\" of the SunriseSunsetTimeInformationNugget class");
            fieldGeneratorCalculatedDateAndTimes = new DateAndOrTimeJSON.HoldingArrayGenerator("field \"CalculatedDateAndTimes\" of the SunriseSunsetTimeInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SunriseSunsetTimeInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorMapLocation.reset();
            fieldGeneratorRequestedType.reset();
            fieldGeneratorDateTimeRangeSpec.reset();
            fieldGeneratorRequestedInThePast.reset();
            fieldGeneratorCalculatedDateAndTimes.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SunriseSunsetTimeInformationNuggetJSON  result)
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
        public SunriseSunsetTimeInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SunriseSunsetTimeInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<SunriseSunsetTimeInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SunriseSunsetTimeInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SunriseSunsetTimeInformationNuggetJSON>();
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
    public List<SunriseSunsetTimeInformationNuggetJSON> value;
  };
  };
