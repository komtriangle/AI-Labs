/* file "TimeOfMoonPhaseInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimeOfMoonPhaseInformationNuggetJSON : DateAndTimeInformationNuggetJSON
  {
    private bool flagHasDateAndTime;
    private DateAndOrTimeJSON  storeDateAndTime;
    private bool flagHasMapLocation;
    private MapLocationJSON  storeMapLocation;
    private bool flagHasRequestedMoonPhase;
    private string storeRequestedMoonPhase;
    private bool flagHasRequestedInThePast;
    private bool storeRequestedInThePast;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDateAndTimeToJSON()
      {
        JSONValueHandler handler_DateAndTime = new JSONValueHandler();
        storeDateAndTime.write_as_json(handler_DateAndTime);
        return handler_DateAndTime.result;
      }

    private JSONValue  extraMapLocationToJSON()
      {
        JSONValueHandler handler_MapLocation = new JSONValueHandler();
        storeMapLocation.write_as_json(handler_MapLocation);
        return handler_MapLocation.result;
      }

    private JSONValue  extraRequestedMoonPhaseToJSON()
      {
        JSONStringValue generated_string_RequestedMoonPhase = new JSONStringValue(storeRequestedMoonPhase);
        return generated_string_RequestedMoonPhase;
      }

    private JSONValue  extraRequestedInThePastToJSON()
      {
        JSONValue generated_boolean_RequestedInThePast = (storeRequestedInThePast ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestedInThePast;
      }


    private void  fromJSONDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setDateAndTime(convert_classy);
      }


    private void  fromJSONMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setMapLocation(convert_classy);
      }


    private void  fromJSONRequestedMoonPhase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RequestedMoonPhase of TimeOfMoonPhaseInformationNuggetJSON is not a string.");
        setRequestedMoonPhase(json_string.getData());
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
                throw new Exception("The value for field RequestedInThePast of TimeOfMoonPhaseInformationNuggetJSON is not true for false.");
              }
          }
        setRequestedInThePast(the_bool);
      }


    public TimeOfMoonPhaseInformationNuggetJSON()
      {
        flagHasDateAndTime = false;
        flagHasMapLocation = false;
        flagHasRequestedMoonPhase = false;
        flagHasRequestedInThePast = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDateAndTimeNuggetKind()
      {
        return "TimeOfMoonPhase";
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

    public bool  hasMapLocation()
      {
        return flagHasMapLocation;
      }

    public MapLocationJSON   getMapLocation()
      {
        Debug.Assert(flagHasMapLocation);
        return storeMapLocation;
      }

    public bool  hasRequestedMoonPhase()
      {
        return flagHasRequestedMoonPhase;
      }

    public string  getRequestedMoonPhase()
      {
        Debug.Assert(flagHasRequestedMoonPhase);
        return storeRequestedMoonPhase;
      }

    public bool  hasRequestedInThePast()
      {
        return flagHasRequestedInThePast;
      }

    public bool  getRequestedInThePast()
      {
        Debug.Assert(flagHasRequestedInThePast);
        return storeRequestedInThePast;
      }


    public virtual int extraTimeOfMoonPhaseInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimeOfMoonPhaseInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimeOfMoonPhaseInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimeOfMoonPhaseInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDateAndTimeInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasDateAndTime)
            ++result;
        if (flagHasMapLocation)
            ++result;
        if (flagHasRequestedMoonPhase)
            ++result;
        if (flagHasRequestedInThePast)
            ++result;
        result += extraTimeOfMoonPhaseInformationNuggetComponentCount();
        return result;
      }
    public override string extraDateAndTimeInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDateAndTime)
          {
            if (remainder == 0)
                return "DateAndTime";
            --remainder;
          }
        if (flagHasMapLocation)
          {
            if (remainder == 0)
                return "MapLocation";
            --remainder;
          }
        if (flagHasRequestedMoonPhase)
          {
            if (remainder == 0)
                return "RequestedMoonPhase";
            --remainder;
          }
        if (flagHasRequestedInThePast)
          {
            if (remainder == 0)
                return "RequestedInThePast";
            --remainder;
          }
        return extraTimeOfMoonPhaseInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDateAndTime)
          {
            if (remainder == 0)
                return extraDateAndTimeToJSON();
            --remainder;
          }
        if (flagHasMapLocation)
          {
            if (remainder == 0)
                return extraMapLocationToJSON();
            --remainder;
          }
        if (flagHasRequestedMoonPhase)
          {
            if (remainder == 0)
                return extraRequestedMoonPhaseToJSON();
            --remainder;
          }
        if (flagHasRequestedInThePast)
          {
            if (remainder == 0)
                return extraRequestedInThePastToJSON();
            --remainder;
          }
        return extraTimeOfMoonPhaseInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "ateAndTime", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasDateAndTime ? extraDateAndTimeToJSON() : null);
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
                        case 'M':
                            if ((String.Compare(field_name, 10, "oonPhase", 0, 8, false) == 0) && (field_name.Length == 18))
                                return (flagHasRequestedMoonPhase ? extraRequestedMoonPhaseToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraTimeOfMoonPhaseInformationNuggetLookup(field_name);
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
    public void setRequestedMoonPhase(string new_value)
      {
        flagHasRequestedMoonPhase = true;
        storeRequestedMoonPhase = new_value;
      }
    public void unsetRequestedMoonPhase()
      {
        flagHasRequestedMoonPhase = false;
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

    public virtual void extraTimeOfMoonPhaseInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimeOfMoonPhaseInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimeOfMoonPhaseInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraTimeOfMoonPhaseInformationNuggetAppendPair(key, new_component);
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
                        case 'M':
                            if ((String.Compare(key, 10, "oonPhase", 0, 8, false) == 0) && (key.Length == 18))
                                {
                                fromJSONRequestedMoonPhase(new_component, false);
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
        extraTimeOfMoonPhaseInformationNuggetAppendPair(key, new_component);
      }
    public override void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
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
                        case 'M':
                            if ((String.Compare(key, 10, "oonPhase", 0, 8, false) == 0) && (key.Length == 18))
                                {
                                fromJSONRequestedMoonPhase(new_component, false);
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
        extraTimeOfMoonPhaseInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDateAndTime);
        if (flagHasDateAndTime)
          {
            handler.start_pair("DateAndTime");
            if (partial_allowed)
                storeDateAndTime.write_partial_as_json(handler);
            else
                storeDateAndTime.write_as_json(handler);
          }
        if (flagHasMapLocation)
          {
            handler.start_pair("MapLocation");
            if (partial_allowed)
                storeMapLocation.write_partial_as_json(handler);
            else
                storeMapLocation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasRequestedMoonPhase);
        if (flagHasRequestedMoonPhase)
          {
            handler.start_pair("RequestedMoonPhase");
            handler.string_value(storeRequestedMoonPhase);
          }
        Debug.Assert(partial_allowed || flagHasRequestedInThePast);
        if (flagHasRequestedInThePast)
          {
            handler.start_pair("RequestedInThePast");
            handler.boolean_value(storeRequestedInThePast);
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
        if (!(hasDateAndTime()))
          {
            return "When parsing the object for %what%, the \"DateAndTime\" field was missing.";
          }
        if (!(hasRequestedMoonPhase()))
          {
            return "When parsing the object for %what%, the \"RequestedMoonPhase\" field was missing.";
          }
        if (!(hasRequestedInThePast()))
          {
            return "When parsing the object for %what%, the \"RequestedInThePast\" field was missing.";
          }
        return null;
      }

    public static new TimeOfMoonPhaseInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeOfMoonPhaseInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeOfMoonPhaseInformationNugget", ignore_extras);
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
    public static new TimeOfMoonPhaseInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimeOfMoonPhaseInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeOfMoonPhaseInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeOfMoonPhaseInformationNugget", ignore_extras);
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
    public static new TimeOfMoonPhaseInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimeOfMoonPhaseInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        TimeOfMoonPhaseInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeOfMoonPhaseInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimeOfMoonPhaseInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TimeOfMoonPhaseInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimeOfMoonPhaseInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeOfMoonPhaseInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DateAndTimeInformationNuggetJSON.Generator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorDateAndTime;
        private MapLocationJSON.HoldingGenerator fieldGeneratorMapLocation;
        private JSONHoldingStringGenerator fieldGeneratorRequestedMoonPhase;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestedInThePast;
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
            if (!(getDateAndTimeInformationNuggetJSONKey().Equals("TimeOfMoonPhase")))
                throw new Exception("The key field has a value other than `TimeOfMoonPhase'.");
            TimeOfMoonPhaseInformationNuggetJSON result = new TimeOfMoonPhaseInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimeOfMoonPhaseInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DateAndTimeInformationNuggetJSON new_result)
          {
            handle_result((TimeOfMoonPhaseInformationNuggetJSON )new_result);
          }
        protected void finish(TimeOfMoonPhaseInformationNuggetJSON result)
          {
            if (fieldGeneratorDateAndTime.have_value)
              {
                result.setDateAndTime(fieldGeneratorDateAndTime.value);
                fieldGeneratorDateAndTime.have_value = false;
              }
            else if ((!(result.hasDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndTime\" field was missing.");
              }
            if (fieldGeneratorMapLocation.have_value)
              {
                result.setMapLocation(fieldGeneratorMapLocation.value);
                fieldGeneratorMapLocation.have_value = false;
              }
            if (fieldGeneratorRequestedMoonPhase.have_value)
              {
                result.setRequestedMoonPhase(fieldGeneratorRequestedMoonPhase.value);
                fieldGeneratorRequestedMoonPhase.have_value = false;
              }
            else if ((!(result.hasRequestedMoonPhase())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedMoonPhase\" field was missing.");
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
            base.finish(result);
          }
        protected abstract void handle_result(TimeOfMoonPhaseInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ateAndTime", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDateAndTime;
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
                            case 'M':
                                if ((String.Compare(field_name, 10, "oonPhase", 0, 8, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorRequestedMoonPhase;
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
            fieldGeneratorDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndTime\" of the TimeOfMoonPhaseInformationNugget class", ignore_extras);
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the TimeOfMoonPhaseInformationNugget class", ignore_extras);
            fieldGeneratorRequestedMoonPhase = new JSONHoldingStringGenerator("field \"RequestedMoonPhase\" of the TimeOfMoonPhaseInformationNugget class");
            fieldGeneratorRequestedInThePast = new JSONHoldingBooleanGenerator("field \"RequestedInThePast\" of the TimeOfMoonPhaseInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimeOfMoonPhaseInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndTime\" of the TimeOfMoonPhaseInformationNugget class", false);
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the TimeOfMoonPhaseInformationNugget class", false);
            fieldGeneratorRequestedMoonPhase = new JSONHoldingStringGenerator("field \"RequestedMoonPhase\" of the TimeOfMoonPhaseInformationNugget class");
            fieldGeneratorRequestedInThePast = new JSONHoldingBooleanGenerator("field \"RequestedInThePast\" of the TimeOfMoonPhaseInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimeOfMoonPhaseInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorDateAndTime.reset();
            fieldGeneratorMapLocation.reset();
            fieldGeneratorRequestedMoonPhase.reset();
            fieldGeneratorRequestedInThePast.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TimeOfMoonPhaseInformationNuggetJSON  result)
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
        public TimeOfMoonPhaseInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimeOfMoonPhaseInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<TimeOfMoonPhaseInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimeOfMoonPhaseInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimeOfMoonPhaseInformationNuggetJSON>();
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
    public List<TimeOfMoonPhaseInformationNuggetJSON> value;
  };
  };
