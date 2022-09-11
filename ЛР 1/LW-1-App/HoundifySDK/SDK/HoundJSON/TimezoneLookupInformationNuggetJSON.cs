/* file "TimezoneLookupInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimezoneLookupInformationNuggetJSON : DateAndTimeInformationNuggetJSON
  {
    private bool flagHasMapLocation;
    private MapLocationJSON  storeMapLocation;
    private bool flagHasDateAndTime;
    private DateAndOrTimeJSON  storeDateAndTime;
    private bool flagHasOlsonCode;
    private string storeOlsonCode;
    private bool flagHasAbbreviatedCurrentRule;
    private string storeAbbreviatedCurrentRule;
    private bool flagHasOffset;
    private double storeOffset;
    private string textStoreOffset;
    private bool flagHasUnits;
    private string storeUnits;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraMapLocationToJSON()
      {
        JSONValueHandler handler_MapLocation = new JSONValueHandler();
        storeMapLocation.write_as_json(handler_MapLocation);
        return handler_MapLocation.result;
      }

    private JSONValue  extraDateAndTimeToJSON()
      {
        JSONValueHandler handler_DateAndTime = new JSONValueHandler();
        storeDateAndTime.write_as_json(handler_DateAndTime);
        return handler_DateAndTime.result;
      }

    private JSONValue  extraOlsonCodeToJSON()
      {
        JSONStringValue generated_string_OlsonCode = new JSONStringValue(storeOlsonCode);
        return generated_string_OlsonCode;
      }

    private JSONValue  extraAbbreviatedCurrentRuleToJSON()
      {
        JSONStringValue generated_string_AbbreviatedCurrentRule = new JSONStringValue(storeAbbreviatedCurrentRule);
        return generated_string_AbbreviatedCurrentRule;
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


    private void  fromJSONMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setMapLocation(convert_classy);
      }


    private void  fromJSONDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setDateAndTime(convert_classy);
      }


    private void  fromJSONOlsonCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OlsonCode of TimezoneLookupInformationNuggetJSON is not a string.");
        setOlsonCode(json_string.getData());
      }


    private void  fromJSONAbbreviatedCurrentRule(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AbbreviatedCurrentRule of TimezoneLookupInformationNuggetJSON is not a string.");
        setAbbreviatedCurrentRule(json_string.getData());
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
                throw new Exception("The value for field Offset of TimezoneLookupInformationNuggetJSON is not a number.");
              }
          }
        setOffsetText(the_rational_text);
      }


    private void  fromJSONUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Units of TimezoneLookupInformationNuggetJSON is not a string.");
        setUnits(json_string.getData());
      }


    public TimezoneLookupInformationNuggetJSON()
      {
        flagHasMapLocation = false;
        flagHasDateAndTime = false;
        flagHasOlsonCode = false;
        flagHasAbbreviatedCurrentRule = false;
        flagHasOffset = false;
        flagHasUnits = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDateAndTimeNuggetKind()
      {
        return "TimezoneLookup";
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

    public bool  hasDateAndTime()
      {
        return flagHasDateAndTime;
      }

    public DateAndOrTimeJSON   getDateAndTime()
      {
        Debug.Assert(flagHasDateAndTime);
        return storeDateAndTime;
      }

    public bool  hasOlsonCode()
      {
        return flagHasOlsonCode;
      }

    public string  getOlsonCode()
      {
        Debug.Assert(flagHasOlsonCode);
        return storeOlsonCode;
      }

    public bool  hasAbbreviatedCurrentRule()
      {
        return flagHasAbbreviatedCurrentRule;
      }

    public string  getAbbreviatedCurrentRule()
      {
        Debug.Assert(flagHasAbbreviatedCurrentRule);
        return storeAbbreviatedCurrentRule;
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


    public virtual int extraTimezoneLookupInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimezoneLookupInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimezoneLookupInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimezoneLookupInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDateAndTimeInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasMapLocation)
            ++result;
        if (flagHasDateAndTime)
            ++result;
        if (flagHasOlsonCode)
            ++result;
        if (flagHasAbbreviatedCurrentRule)
            ++result;
        if (flagHasOffset)
            ++result;
        if (flagHasUnits)
            ++result;
        result += extraTimezoneLookupInformationNuggetComponentCount();
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
        if (flagHasDateAndTime)
          {
            if (remainder == 0)
                return "DateAndTime";
            --remainder;
          }
        if (flagHasOlsonCode)
          {
            if (remainder == 0)
                return "OlsonCode";
            --remainder;
          }
        if (flagHasAbbreviatedCurrentRule)
          {
            if (remainder == 0)
                return "AbbreviatedCurrentRule";
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
        return extraTimezoneLookupInformationNuggetComponentKey(remainder);
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
        if (flagHasDateAndTime)
          {
            if (remainder == 0)
                return extraDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasOlsonCode)
          {
            if (remainder == 0)
                return extraOlsonCodeToJSON();
            --remainder;
          }
        if (flagHasAbbreviatedCurrentRule)
          {
            if (remainder == 0)
                return extraAbbreviatedCurrentRuleToJSON();
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
        return extraTimezoneLookupInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "bbreviatedCurrentRule", 0, 21, false) == 0) && (field_name.Length == 22))
                    return (flagHasAbbreviatedCurrentRule ? extraAbbreviatedCurrentRuleToJSON() : null);
                break;
            case 'D':
                if ((String.Compare(field_name, 1, "ateAndTime", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasDateAndTime ? extraDateAndTimeToJSON() : null);
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasMapLocation ? extraMapLocationToJSON() : null);
                break;
            case 'O':
                switch (field_name[1])
                  {
                    case 'f':
                        if ((String.Compare(field_name, 2, "fset", 0, 4, false) == 0) && (field_name.Length == 6))
                            return (flagHasOffset ? extraOffsetToJSON() : null);
                        break;
                    case 'l':
                        if ((String.Compare(field_name, 2, "sonCode", 0, 7, false) == 0) && (field_name.Length == 9))
                            return (flagHasOlsonCode ? extraOlsonCodeToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "nits", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasUnits ? extraUnitsToJSON() : null);
                break;
            default:
                break;
          }
        return extraTimezoneLookupInformationNuggetLookup(field_name);
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
    public void setDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasDateAndTime)
          {
          }
        flagHasDateAndTime = true;
        storeDateAndTime = new_value;
      }
    public void unsetDateAndTime()
      {
        if (flagHasDateAndTime)
          {
          }
        flagHasDateAndTime = false;
      }
    public void setOlsonCode(string new_value)
      {
        flagHasOlsonCode = true;
        storeOlsonCode = new_value;
      }
    public void unsetOlsonCode()
      {
        flagHasOlsonCode = false;
      }
    public void setAbbreviatedCurrentRule(string new_value)
      {
        flagHasAbbreviatedCurrentRule = true;
        storeAbbreviatedCurrentRule = new_value;
      }
    public void unsetAbbreviatedCurrentRule()
      {
        flagHasAbbreviatedCurrentRule = false;
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
            throw new Exception("The text value for field Offset of TimezoneLookupInformationNuggetJSON is not a valid number.");
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

    public virtual void extraTimezoneLookupInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimezoneLookupInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimezoneLookupInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraTimezoneLookupInformationNuggetAppendPair(key, new_component);
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
            case 'A':
                if ((String.Compare(key, 1, "bbreviatedCurrentRule", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONAbbreviatedCurrentRule(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "ateAndTime", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONDateAndTime(new_component, false);
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
            case 'O':
                switch (key[1])
                  {
                    case 'f':
                        if ((String.Compare(key, 2, "fset", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONOffset(new_component, false);
                            return;
                            }
                        break;
                    case 'l':
                        if ((String.Compare(key, 2, "sonCode", 0, 7, false) == 0) && (key.Length == 9))
                            {
                            fromJSONOlsonCode(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
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
        extraTimezoneLookupInformationNuggetAppendPair(key, new_component);
      }
    public override void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "bbreviatedCurrentRule", 0, 21, false) == 0) && (key.Length == 22))
                    {
                    fromJSONAbbreviatedCurrentRule(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if ((String.Compare(key, 1, "ateAndTime", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONDateAndTime(new_component, false);
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
            case 'O':
                switch (key[1])
                  {
                    case 'f':
                        if ((String.Compare(key, 2, "fset", 0, 4, false) == 0) && (key.Length == 6))
                            {
                            fromJSONOffset(new_component, false);
                            return;
                            }
                        break;
                    case 'l':
                        if ((String.Compare(key, 2, "sonCode", 0, 7, false) == 0) && (key.Length == 9))
                            {
                            fromJSONOlsonCode(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
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
        extraTimezoneLookupInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDateAndTime);
        if (flagHasDateAndTime)
          {
            handler.start_pair("DateAndTime");
            if (partial_allowed)
                storeDateAndTime.write_partial_as_json(handler);
            else
                storeDateAndTime.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasOlsonCode);
        if (flagHasOlsonCode)
          {
            handler.start_pair("OlsonCode");
            handler.string_value(storeOlsonCode);
          }
        Debug.Assert(partial_allowed || flagHasAbbreviatedCurrentRule);
        if (flagHasAbbreviatedCurrentRule)
          {
            handler.start_pair("AbbreviatedCurrentRule");
            handler.string_value(storeAbbreviatedCurrentRule);
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
        if (!(hasDateAndTime()))
          {
            return "When parsing the object for %what%, the \"DateAndTime\" field was missing.";
          }
        if (!(hasOlsonCode()))
          {
            return "When parsing the object for %what%, the \"OlsonCode\" field was missing.";
          }
        if (!(hasAbbreviatedCurrentRule()))
          {
            return "When parsing the object for %what%, the \"AbbreviatedCurrentRule\" field was missing.";
          }
        if (!(hasOffset()))
          {
            return "When parsing the object for %what%, the \"Offset\" field was missing.";
          }
        if (!(hasUnits()))
          {
            return "When parsing the object for %what%, the \"Units\" field was missing.";
          }
        return null;
      }

    public static new TimezoneLookupInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimezoneLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimezoneLookupInformationNugget", ignore_extras);
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
    public static new TimezoneLookupInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimezoneLookupInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimezoneLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimezoneLookupInformationNugget", ignore_extras);
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
    public static new TimezoneLookupInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimezoneLookupInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        TimezoneLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimezoneLookupInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimezoneLookupInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TimezoneLookupInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimezoneLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimezoneLookupInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DateAndTimeInformationNuggetJSON.Generator
      {
        private MapLocationJSON.HoldingGenerator fieldGeneratorMapLocation;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorDateAndTime;
        private JSONHoldingStringGenerator fieldGeneratorOlsonCode;
        private JSONHoldingStringGenerator fieldGeneratorAbbreviatedCurrentRule;
        private JSONHoldingNumberTextGenerator fieldGeneratorOffset;
        private JSONHoldingStringGenerator fieldGeneratorUnits;
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
            if (!(getDateAndTimeInformationNuggetJSONKey().Equals("TimezoneLookup")))
                throw new Exception("The key field has a value other than `TimezoneLookup'.");
            TimezoneLookupInformationNuggetJSON result = new TimezoneLookupInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimezoneLookupInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DateAndTimeInformationNuggetJSON new_result)
          {
            handle_result((TimezoneLookupInformationNuggetJSON )new_result);
          }
        protected void finish(TimezoneLookupInformationNuggetJSON result)
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
            if (fieldGeneratorDateAndTime.have_value)
              {
                result.setDateAndTime(fieldGeneratorDateAndTime.value);
                fieldGeneratorDateAndTime.have_value = false;
              }
            else if ((!(result.hasDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndTime\" field was missing.");
              }
            if (fieldGeneratorOlsonCode.have_value)
              {
                result.setOlsonCode(fieldGeneratorOlsonCode.value);
                fieldGeneratorOlsonCode.have_value = false;
              }
            else if ((!(result.hasOlsonCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OlsonCode\" field was missing.");
              }
            if (fieldGeneratorAbbreviatedCurrentRule.have_value)
              {
                result.setAbbreviatedCurrentRule(fieldGeneratorAbbreviatedCurrentRule.value);
                fieldGeneratorAbbreviatedCurrentRule.have_value = false;
              }
            else if ((!(result.hasAbbreviatedCurrentRule())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AbbreviatedCurrentRule\" field was missing.");
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
            base.finish(result);
          }
        protected abstract void handle_result(TimezoneLookupInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "bbreviatedCurrentRule", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorAbbreviatedCurrentRule;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ateAndTime", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDateAndTime;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMapLocation;
                    break;
                case 'O':
                    switch (field_name[1])
                      {
                        case 'f':
                            if ((String.Compare(field_name, 2, "fset", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorOffset;
                            break;
                        case 'l':
                            if ((String.Compare(field_name, 2, "sonCode", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorOlsonCode;
                            break;
                        default:
                            break;
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
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the TimezoneLookupInformationNugget class", ignore_extras);
            fieldGeneratorDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndTime\" of the TimezoneLookupInformationNugget class", ignore_extras);
            fieldGeneratorOlsonCode = new JSONHoldingStringGenerator("field \"OlsonCode\" of the TimezoneLookupInformationNugget class");
            fieldGeneratorAbbreviatedCurrentRule = new JSONHoldingStringGenerator("field \"AbbreviatedCurrentRule\" of the TimezoneLookupInformationNugget class");
            fieldGeneratorOffset = new JSONHoldingNumberTextGenerator("field \"Offset\" of the TimezoneLookupInformationNugget class");
            fieldGeneratorUnits = new JSONHoldingStringGenerator("field \"Units\" of the TimezoneLookupInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimezoneLookupInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the TimezoneLookupInformationNugget class", false);
            fieldGeneratorDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndTime\" of the TimezoneLookupInformationNugget class", false);
            fieldGeneratorOlsonCode = new JSONHoldingStringGenerator("field \"OlsonCode\" of the TimezoneLookupInformationNugget class");
            fieldGeneratorAbbreviatedCurrentRule = new JSONHoldingStringGenerator("field \"AbbreviatedCurrentRule\" of the TimezoneLookupInformationNugget class");
            fieldGeneratorOffset = new JSONHoldingNumberTextGenerator("field \"Offset\" of the TimezoneLookupInformationNugget class");
            fieldGeneratorUnits = new JSONHoldingStringGenerator("field \"Units\" of the TimezoneLookupInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimezoneLookupInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorMapLocation.reset();
            fieldGeneratorDateAndTime.reset();
            fieldGeneratorOlsonCode.reset();
            fieldGeneratorAbbreviatedCurrentRule.reset();
            fieldGeneratorOffset.reset();
            fieldGeneratorUnits.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TimezoneLookupInformationNuggetJSON  result)
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
        public TimezoneLookupInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimezoneLookupInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<TimezoneLookupInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimezoneLookupInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimezoneLookupInformationNuggetJSON>();
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
    public List<TimezoneLookupInformationNuggetJSON> value;
  };
  };
