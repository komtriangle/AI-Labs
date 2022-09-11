/* file "TimeBetweenLocationsConversationStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimeBetweenLocationsConversationStateJSON : JSONBase
  {
    public enum TypeDateAndTimeKind
      {
        DateAndTimeKind_TimeBetweenLocations
      };

    public static TypeDateAndTimeKind  stringToDateAndTimeKind(string chars)
      {
        if ((String.Compare(chars, 0, "TimeBetweenLocations", 0, 20, false) == 0) && (chars.Length == 20))
            return TypeDateAndTimeKind.DateAndTimeKind_TimeBetweenLocations;
        throw new Exception("The value for field `DateAndTimeKind' is not one of the legal values.");
      }

    public static string  stringFromDateAndTimeKind(TypeDateAndTimeKind the_enum)
      {
        switch (the_enum)
          {
            case TypeDateAndTimeKind.DateAndTimeKind_TimeBetweenLocations:
                return "TimeBetweenLocations";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasDateAndTimeKind;
    private bool flagHasSourceMapLocation;
    private MapLocationJSON  storeSourceMapLocation;
    private bool flagHasDestinationMapLocation;
    private MapLocationJSON  storeDestinationMapLocation;
    private bool flagHasMapLocation;
    private MapLocationJSON  storeMapLocation;
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


    private void  fromJSONDateAndTimeKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DateAndTimeKind of TimeBetweenLocationsConversationStateJSON is not a string.");
        if (!(json_string.getData().Equals("TimeBetweenLocations")))
            throw new Exception("The value for field DateAndTimeKind of TimeBetweenLocationsConversationStateJSON is not `TimeBetweenLocations'.");
        setDateAndTimeKind();
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


    private void  fromJSONMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setMapLocation(convert_classy);
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
                throw new Exception("The value for field Offset of TimeBetweenLocationsConversationStateJSON is not a number.");
              }
          }
        setOffsetText(the_rational_text);
      }


    private void  fromJSONUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Units of TimeBetweenLocationsConversationStateJSON is not a string.");
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


    public TimeBetweenLocationsConversationStateJSON()
      {
        flagHasDateAndTimeKind = false;
        flagHasSourceMapLocation = false;
        flagHasDestinationMapLocation = false;
        flagHasMapLocation = false;
        flagHasOffset = false;
        flagHasUnits = false;
        flagHasDateTimeRangeSpec = false;
        flagHasSourceDateAndTime = false;
        flagHasDestinationDateAndTime = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDateAndTimeKind()
      {
        return flagHasDateAndTimeKind;
      }

    public TypeDateAndTimeKind  getDateAndTimeKind()
      {
        Debug.Assert(flagHasDateAndTimeKind);
        return TypeDateAndTimeKind.DateAndTimeKind_TimeBetweenLocations;
      }

    public string  getDateAndTimeKindAsString()
      {
        return stringFromDateAndTimeKind(getDateAndTimeKind());
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

    public bool  hasMapLocation()
      {
        return flagHasMapLocation;
      }

    public MapLocationJSON   getMapLocation()
      {
        Debug.Assert(flagHasMapLocation);
        return storeMapLocation;
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


    public virtual int extraTimeBetweenLocationsConversationStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimeBetweenLocationsConversationStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimeBetweenLocationsConversationStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimeBetweenLocationsConversationStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setDateAndTimeKind()
      {
        flagHasDateAndTimeKind = true;
      }
    public void setDateAndTimeKind(TypeDateAndTimeKind new_value)
      {
        setDateAndTimeKind();
      }
    public void setDateAndTimeKind(string chars)
      {
        setDateAndTimeKind(stringToDateAndTimeKind(chars));
      }
    public void unsetDateAndTimeKind()
      {
        flagHasDateAndTimeKind = false;
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
            throw new Exception("The text value for field Offset of TimeBetweenLocationsConversationStateJSON is not a valid number.");
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

    public virtual void extraTimeBetweenLocationsConversationStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimeBetweenLocationsConversationStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimeBetweenLocationsConversationStateLookup(key);
        if (old_field == null)
          {
            extraTimeBetweenLocationsConversationStateAppendPair(key, new_component);
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

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        Debug.Assert(partial_allowed || flagHasDateAndTimeKind);
        if (flagHasDateAndTimeKind)
          {
            handler.start_pair("DateAndTimeKind");
            handler.string_value("TimeBetweenLocations");
          }
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
        Debug.Assert(partial_allowed || flagHasMapLocation);
        if (flagHasMapLocation)
          {
            handler.start_pair("MapLocation");
            if (partial_allowed)
                storeMapLocation.write_partial_as_json(handler);
            else
                storeMapLocation.write_as_json(handler);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasDateAndTimeKind()))
          {
            return "When parsing the object for %what%, the \"DateAndTimeKind\" field was missing.";
          }
        if (!(hasDestinationMapLocation()))
          {
            return "When parsing the object for %what%, the \"DestinationMapLocation\" field was missing.";
          }
        if (!(hasMapLocation()))
          {
            return "When parsing the object for %what%, the \"MapLocation\" field was missing.";
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

    public static TimeBetweenLocationsConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeBetweenLocationsConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenLocationsConversationState", ignore_extras);
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
    public static TimeBetweenLocationsConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimeBetweenLocationsConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeBetweenLocationsConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenLocationsConversationState", ignore_extras);
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
    public static TimeBetweenLocationsConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimeBetweenLocationsConversationStateJSON from_text(string text, bool ignore_extras)
      {
        TimeBetweenLocationsConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenLocationsConversationState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimeBetweenLocationsConversationStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TimeBetweenLocationsConversationStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimeBetweenLocationsConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenLocationsConversationState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorDateAndTimeKind : JSONStringGenerator
          {
            protected FieldGeneratorDateAndTimeKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDateAndTimeKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToDateAndTimeKind(result));
              }
            protected abstract void handle_result(TypeDateAndTimeKind result);
          };
    private class FieldHoldingGeneratorDateAndTimeKind : FieldGeneratorDateAndTimeKind
  {
    protected override void handle_result(TypeDateAndTimeKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDateAndTimeKind(String what)
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
    public TypeDateAndTimeKind value;
  };
    private class FieldHoldingArrayGeneratorDateAndTimeKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDateAndTimeKind
      {
        private FieldHoldingArrayGeneratorDateAndTimeKind top;

        protected override void handle_result(TypeDateAndTimeKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDateAndTimeKind init_top)
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
    protected virtual void handle_result(List<TypeDateAndTimeKind> result)
      {
      }

    public FieldHoldingArrayGeneratorDateAndTimeKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDateAndTimeKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDateAndTimeKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDateAndTimeKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDateAndTimeKind> value;
  };
        private FieldHoldingGeneratorDateAndTimeKind fieldGeneratorDateAndTimeKind;
        private MapLocationJSON.HoldingGenerator fieldGeneratorSourceMapLocation;
        private MapLocationJSON.HoldingGenerator fieldGeneratorDestinationMapLocation;
        private MapLocationJSON.HoldingGenerator fieldGeneratorMapLocation;
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

        protected bool allow_incomplete;

        protected bool allow_unpolished;

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
            TimeBetweenLocationsConversationStateJSON result = new TimeBetweenLocationsConversationStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimeBetweenLocationsConversationStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TimeBetweenLocationsConversationStateJSON result)
          {
            if (fieldGeneratorDateAndTimeKind.have_value)
              {
                result.setDateAndTimeKind();
                fieldGeneratorDateAndTimeKind.have_value = false;
              }
            else if ((!(result.hasDateAndTimeKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndTimeKind\" field was missing.");
              }
            if (fieldGeneratorSourceMapLocation.have_value)
              {
                result.setSourceMapLocation(fieldGeneratorSourceMapLocation.value);
                fieldGeneratorSourceMapLocation.have_value = false;
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
            if (fieldGeneratorMapLocation.have_value)
              {
                result.setMapLocation(fieldGeneratorMapLocation.value);
                fieldGeneratorMapLocation.have_value = false;
              }
            else if ((!(result.hasMapLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MapLocation\" field was missing.");
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
          }
        protected abstract void handle_result(TimeBetweenLocationsConversationStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "te", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 5, "ndTimeKind", 0, 10, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorDateAndTimeKind;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 5, "imeRangeSpec", 0, 12, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorDateTimeRangeSpec;
                                        break;
                                    default:
                                        break;
                                  }
                              }
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
                case 'M':
                    if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMapLocation;
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the TimeBetweenLocationsConversationState class");
            fieldGeneratorSourceMapLocation = new MapLocationJSON.HoldingGenerator("field \"SourceMapLocation\" of the TimeBetweenLocationsConversationState class", ignore_extras);
            fieldGeneratorDestinationMapLocation = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocation\" of the TimeBetweenLocationsConversationState class", ignore_extras);
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the TimeBetweenLocationsConversationState class", ignore_extras);
            fieldGeneratorOffset = new JSONHoldingNumberTextGenerator("field \"Offset\" of the TimeBetweenLocationsConversationState class");
            fieldGeneratorUnits = new JSONHoldingStringGenerator("field \"Units\" of the TimeBetweenLocationsConversationState class");
            fieldGeneratorDateTimeRangeSpec = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRangeSpec\" of the TimeBetweenLocationsConversationState class", ignore_extras);
            fieldGeneratorSourceDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"SourceDateAndTime\" of the TimeBetweenLocationsConversationState class", ignore_extras);
            fieldGeneratorDestinationDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DestinationDateAndTime\" of the TimeBetweenLocationsConversationState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimeBetweenLocationsConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the TimeBetweenLocationsConversationState class");
            fieldGeneratorSourceMapLocation = new MapLocationJSON.HoldingGenerator("field \"SourceMapLocation\" of the TimeBetweenLocationsConversationState class", false);
            fieldGeneratorDestinationMapLocation = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocation\" of the TimeBetweenLocationsConversationState class", false);
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the TimeBetweenLocationsConversationState class", false);
            fieldGeneratorOffset = new JSONHoldingNumberTextGenerator("field \"Offset\" of the TimeBetweenLocationsConversationState class");
            fieldGeneratorUnits = new JSONHoldingStringGenerator("field \"Units\" of the TimeBetweenLocationsConversationState class");
            fieldGeneratorDateTimeRangeSpec = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRangeSpec\" of the TimeBetweenLocationsConversationState class", false);
            fieldGeneratorSourceDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"SourceDateAndTime\" of the TimeBetweenLocationsConversationState class", false);
            fieldGeneratorDestinationDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DestinationDateAndTime\" of the TimeBetweenLocationsConversationState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimeBetweenLocationsConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDateAndTimeKind.reset();
            fieldGeneratorSourceMapLocation.reset();
            fieldGeneratorDestinationMapLocation.reset();
            fieldGeneratorMapLocation.reset();
            fieldGeneratorOffset.reset();
            fieldGeneratorUnits.reset();
            fieldGeneratorDateTimeRangeSpec.reset();
            fieldGeneratorSourceDateAndTime.reset();
            fieldGeneratorDestinationDateAndTime.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSourceMapLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDestinationMapLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMapLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDateTimeRangeSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSourceDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDestinationDateAndTime.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSourceMapLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDestinationMapLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMapLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDateTimeRangeSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSourceDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDestinationDateAndTime.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TimeBetweenLocationsConversationStateJSON  result)
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
        public TimeBetweenLocationsConversationStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimeBetweenLocationsConversationStateJSON  result)
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
    protected virtual void handle_result(List<TimeBetweenLocationsConversationStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimeBetweenLocationsConversationStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimeBetweenLocationsConversationStateJSON>();
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
    public List<TimeBetweenLocationsConversationStateJSON> value;
  };
  };
