/* file "TimeInLocationConversationStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimeInLocationConversationStateJSON : JSONBase
  {
    public enum TypeDateAndTimeKind
      {
        DateAndTimeKind_TimeInLocation
      };

    public static TypeDateAndTimeKind  stringToDateAndTimeKind(string chars)
      {
        if ((String.Compare(chars, 0, "TimeInLocation", 0, 14, false) == 0) && (chars.Length == 14))
            return TypeDateAndTimeKind.DateAndTimeKind_TimeInLocation;
        throw new Exception("The value for field `DateAndTimeKind' is not one of the legal values.");
      }

    public static string  stringFromDateAndTimeKind(TypeDateAndTimeKind the_enum)
      {
        switch (the_enum)
          {
            case TypeDateAndTimeKind.DateAndTimeKind_TimeInLocation:
                return "TimeInLocation";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasDateAndTimeKind;
    private bool flagHasSourceMapLocation;
    private MapLocationJSON  storeSourceMapLocation;
    private bool flagHasSourceTimeZone;
    private TimeZoneJSON  storeSourceTimeZone;
    private bool flagHasSourceDateTimeSpec;
    private DateTimeSpecJSON  storeSourceDateTimeSpec;
    private bool flagHasDestinationMapLocation;
    private MapLocationJSON  storeDestinationMapLocation;
    private bool flagHasDestinationTimeZone;
    private TimeZoneJSON  storeDestinationTimeZone;
    private bool flagHasDestinationDateTimeSpec;
    private DateTimeSpecJSON  storeDestinationDateTimeSpec;
    private bool flagHasMapLocation;
    private MapLocationJSON  storeMapLocation;
    private bool flagHasTimeZone;
    private TimeZoneJSON  storeTimeZone;
    private bool flagHasDateTimeSpec;
    private DateTimeSpecJSON  storeDateTimeSpec;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDateAndTimeKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DateAndTimeKind of TimeInLocationConversationStateJSON is not a string.");
        if (!(json_string.getData().Equals("TimeInLocation")))
            throw new Exception("The value for field DateAndTimeKind of TimeInLocationConversationStateJSON is not `TimeInLocation'.");
        setDateAndTimeKind();
      }


    private void  fromJSONSourceMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setSourceMapLocation(convert_classy);
      }


    private void  fromJSONSourceTimeZone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeZoneJSON convert_classy = TimeZoneJSON.from_json(json_value, ignore_extras, true);
        setSourceTimeZone(convert_classy);
      }


    private void  fromJSONSourceDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setSourceDateTimeSpec(convert_classy);
      }


    private void  fromJSONDestinationMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setDestinationMapLocation(convert_classy);
      }


    private void  fromJSONDestinationTimeZone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeZoneJSON convert_classy = TimeZoneJSON.from_json(json_value, ignore_extras, true);
        setDestinationTimeZone(convert_classy);
      }


    private void  fromJSONDestinationDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setDestinationDateTimeSpec(convert_classy);
      }


    private void  fromJSONMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setMapLocation(convert_classy);
      }


    private void  fromJSONTimeZone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeZoneJSON convert_classy = TimeZoneJSON.from_json(json_value, ignore_extras, true);
        setTimeZone(convert_classy);
      }


    private void  fromJSONDateTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateTimeSpec(convert_classy);
      }


    public TimeInLocationConversationStateJSON()
      {
        flagHasDateAndTimeKind = false;
        flagHasSourceMapLocation = false;
        flagHasSourceTimeZone = false;
        flagHasSourceDateTimeSpec = false;
        flagHasDestinationMapLocation = false;
        flagHasDestinationTimeZone = false;
        flagHasDestinationDateTimeSpec = false;
        flagHasMapLocation = false;
        flagHasTimeZone = false;
        flagHasDateTimeSpec = false;
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
        return TypeDateAndTimeKind.DateAndTimeKind_TimeInLocation;
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

    public bool  hasSourceTimeZone()
      {
        return flagHasSourceTimeZone;
      }

    public TimeZoneJSON   getSourceTimeZone()
      {
        Debug.Assert(flagHasSourceTimeZone);
        return storeSourceTimeZone;
      }

    public bool  hasSourceDateTimeSpec()
      {
        return flagHasSourceDateTimeSpec;
      }

    public DateTimeSpecJSON   getSourceDateTimeSpec()
      {
        Debug.Assert(flagHasSourceDateTimeSpec);
        return storeSourceDateTimeSpec;
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

    public bool  hasDestinationTimeZone()
      {
        return flagHasDestinationTimeZone;
      }

    public TimeZoneJSON   getDestinationTimeZone()
      {
        Debug.Assert(flagHasDestinationTimeZone);
        return storeDestinationTimeZone;
      }

    public bool  hasDestinationDateTimeSpec()
      {
        return flagHasDestinationDateTimeSpec;
      }

    public DateTimeSpecJSON   getDestinationDateTimeSpec()
      {
        Debug.Assert(flagHasDestinationDateTimeSpec);
        return storeDestinationDateTimeSpec;
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

    public bool  hasTimeZone()
      {
        return flagHasTimeZone;
      }

    public TimeZoneJSON   getTimeZone()
      {
        Debug.Assert(flagHasTimeZone);
        return storeTimeZone;
      }

    public bool  hasDateTimeSpec()
      {
        return flagHasDateTimeSpec;
      }

    public DateTimeSpecJSON   getDateTimeSpec()
      {
        Debug.Assert(flagHasDateTimeSpec);
        return storeDateTimeSpec;
      }


    public virtual int extraTimeInLocationConversationStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimeInLocationConversationStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimeInLocationConversationStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimeInLocationConversationStateLookup(string field_name)
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
    public void setSourceTimeZone(TimeZoneJSON  new_value)
      {
        if (flagHasSourceTimeZone)
          {
          }
        flagHasSourceTimeZone = true;
        storeSourceTimeZone = new_value;
      }
    public void unsetSourceTimeZone()
      {
        if (flagHasSourceTimeZone)
          {
          }
        flagHasSourceTimeZone = false;
      }
    public void setSourceDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasSourceDateTimeSpec)
          {
          }
        flagHasSourceDateTimeSpec = true;
        storeSourceDateTimeSpec = new_value;
      }
    public void unsetSourceDateTimeSpec()
      {
        if (flagHasSourceDateTimeSpec)
          {
          }
        flagHasSourceDateTimeSpec = false;
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
    public void setDestinationTimeZone(TimeZoneJSON  new_value)
      {
        if (flagHasDestinationTimeZone)
          {
          }
        flagHasDestinationTimeZone = true;
        storeDestinationTimeZone = new_value;
      }
    public void unsetDestinationTimeZone()
      {
        if (flagHasDestinationTimeZone)
          {
          }
        flagHasDestinationTimeZone = false;
      }
    public void setDestinationDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasDestinationDateTimeSpec)
          {
          }
        flagHasDestinationDateTimeSpec = true;
        storeDestinationDateTimeSpec = new_value;
      }
    public void unsetDestinationDateTimeSpec()
      {
        if (flagHasDestinationDateTimeSpec)
          {
          }
        flagHasDestinationDateTimeSpec = false;
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
    public void setTimeZone(TimeZoneJSON  new_value)
      {
        if (flagHasTimeZone)
          {
          }
        flagHasTimeZone = true;
        storeTimeZone = new_value;
      }
    public void unsetTimeZone()
      {
        if (flagHasTimeZone)
          {
          }
        flagHasTimeZone = false;
      }
    public void setDateTimeSpec(DateTimeSpecJSON  new_value)
      {
        if (flagHasDateTimeSpec)
          {
          }
        flagHasDateTimeSpec = true;
        storeDateTimeSpec = new_value;
      }
    public void unsetDateTimeSpec()
      {
        if (flagHasDateTimeSpec)
          {
          }
        flagHasDateTimeSpec = false;
      }

    public virtual void extraTimeInLocationConversationStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimeInLocationConversationStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimeInLocationConversationStateLookup(key);
        if (old_field == null)
          {
            extraTimeInLocationConversationStateAppendPair(key, new_component);
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
            handler.string_value("TimeInLocation");
          }
        if (flagHasSourceMapLocation)
          {
            handler.start_pair("SourceMapLocation");
            if (partial_allowed)
                storeSourceMapLocation.write_partial_as_json(handler);
            else
                storeSourceMapLocation.write_as_json(handler);
          }
        if (flagHasSourceTimeZone)
          {
            handler.start_pair("SourceTimeZone");
            if (partial_allowed)
                storeSourceTimeZone.write_partial_as_json(handler);
            else
                storeSourceTimeZone.write_as_json(handler);
          }
        if (flagHasSourceDateTimeSpec)
          {
            handler.start_pair("SourceDateTimeSpec");
            if (partial_allowed)
                storeSourceDateTimeSpec.write_partial_as_json(handler);
            else
                storeSourceDateTimeSpec.write_as_json(handler);
          }
        if (flagHasDestinationMapLocation)
          {
            handler.start_pair("DestinationMapLocation");
            if (partial_allowed)
                storeDestinationMapLocation.write_partial_as_json(handler);
            else
                storeDestinationMapLocation.write_as_json(handler);
          }
        if (flagHasDestinationTimeZone)
          {
            handler.start_pair("DestinationTimeZone");
            if (partial_allowed)
                storeDestinationTimeZone.write_partial_as_json(handler);
            else
                storeDestinationTimeZone.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDestinationDateTimeSpec);
        if (flagHasDestinationDateTimeSpec)
          {
            handler.start_pair("DestinationDateTimeSpec");
            if (partial_allowed)
                storeDestinationDateTimeSpec.write_partial_as_json(handler);
            else
                storeDestinationDateTimeSpec.write_as_json(handler);
          }
        if (flagHasMapLocation)
          {
            handler.start_pair("MapLocation");
            if (partial_allowed)
                storeMapLocation.write_partial_as_json(handler);
            else
                storeMapLocation.write_as_json(handler);
          }
        if (flagHasTimeZone)
          {
            handler.start_pair("TimeZone");
            if (partial_allowed)
                storeTimeZone.write_partial_as_json(handler);
            else
                storeTimeZone.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDateTimeSpec);
        if (flagHasDateTimeSpec)
          {
            handler.start_pair("DateTimeSpec");
            if (partial_allowed)
                storeDateTimeSpec.write_partial_as_json(handler);
            else
                storeDateTimeSpec.write_as_json(handler);
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
        if (!(hasDestinationDateTimeSpec()))
          {
            return "When parsing the object for %what%, the \"DestinationDateTimeSpec\" field was missing.";
          }
        if (!(hasDateTimeSpec()))
          {
            return "When parsing the object for %what%, the \"DateTimeSpec\" field was missing.";
          }
        return null;
      }

    public static TimeInLocationConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeInLocationConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeInLocationConversationState", ignore_extras);
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
    public static TimeInLocationConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimeInLocationConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeInLocationConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeInLocationConversationState", ignore_extras);
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
    public static TimeInLocationConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimeInLocationConversationStateJSON from_text(string text, bool ignore_extras)
      {
        TimeInLocationConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeInLocationConversationState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimeInLocationConversationStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TimeInLocationConversationStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimeInLocationConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeInLocationConversationState", ignore_extras);
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
        private TimeZoneJSON.HoldingGenerator fieldGeneratorSourceTimeZone;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorSourceDateTimeSpec;
        private MapLocationJSON.HoldingGenerator fieldGeneratorDestinationMapLocation;
        private TimeZoneJSON.HoldingGenerator fieldGeneratorDestinationTimeZone;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorDestinationDateTimeSpec;
        private MapLocationJSON.HoldingGenerator fieldGeneratorMapLocation;
        private TimeZoneJSON.HoldingGenerator fieldGeneratorTimeZone;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorDateTimeSpec;
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
            TimeInLocationConversationStateJSON result = new TimeInLocationConversationStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimeInLocationConversationStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TimeInLocationConversationStateJSON result)
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
            if (fieldGeneratorSourceTimeZone.have_value)
              {
                result.setSourceTimeZone(fieldGeneratorSourceTimeZone.value);
                fieldGeneratorSourceTimeZone.have_value = false;
              }
            if (fieldGeneratorSourceDateTimeSpec.have_value)
              {
                result.setSourceDateTimeSpec(fieldGeneratorSourceDateTimeSpec.value);
                fieldGeneratorSourceDateTimeSpec.have_value = false;
              }
            if (fieldGeneratorDestinationMapLocation.have_value)
              {
                result.setDestinationMapLocation(fieldGeneratorDestinationMapLocation.value);
                fieldGeneratorDestinationMapLocation.have_value = false;
              }
            if (fieldGeneratorDestinationTimeZone.have_value)
              {
                result.setDestinationTimeZone(fieldGeneratorDestinationTimeZone.value);
                fieldGeneratorDestinationTimeZone.have_value = false;
              }
            if (fieldGeneratorDestinationDateTimeSpec.have_value)
              {
                result.setDestinationDateTimeSpec(fieldGeneratorDestinationDateTimeSpec.value);
                fieldGeneratorDestinationDateTimeSpec.have_value = false;
              }
            else if ((!(result.hasDestinationDateTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DestinationDateTimeSpec\" field was missing.");
              }
            if (fieldGeneratorMapLocation.have_value)
              {
                result.setMapLocation(fieldGeneratorMapLocation.value);
                fieldGeneratorMapLocation.have_value = false;
              }
            if (fieldGeneratorTimeZone.have_value)
              {
                result.setTimeZone(fieldGeneratorTimeZone.value);
                fieldGeneratorTimeZone.have_value = false;
              }
            if (fieldGeneratorDateTimeSpec.have_value)
              {
                result.setDateTimeSpec(fieldGeneratorDateTimeSpec.value);
                fieldGeneratorDateTimeSpec.have_value = false;
              }
            else if ((!(result.hasDateTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateTimeSpec\" field was missing.");
              }
          }
        protected abstract void handle_result(TimeInLocationConversationStateJSON new_result);
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
                                        if ((String.Compare(field_name, 5, "imeSpec", 0, 7, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorDateTimeSpec;
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
                                        if ((String.Compare(field_name, 12, "ateTimeSpec", 0, 11, false) == 0) && (field_name.Length == 23))
                                            return fieldGeneratorDestinationDateTimeSpec;
                                        break;
                                    case 'M':
                                        if ((String.Compare(field_name, 12, "apLocation", 0, 10, false) == 0) && (field_name.Length == 22))
                                            return fieldGeneratorDestinationMapLocation;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 12, "imeZone", 0, 7, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorDestinationTimeZone;
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
                case 'S':
                    if (String.Compare(field_name, 1, "ource", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 7, "ateTimeSpec", 0, 11, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorSourceDateTimeSpec;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 7, "apLocation", 0, 10, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorSourceMapLocation;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 7, "imeZone", 0, 7, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorSourceTimeZone;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "imeZone", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorTimeZone;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the TimeInLocationConversationState class");
            fieldGeneratorSourceMapLocation = new MapLocationJSON.HoldingGenerator("field \"SourceMapLocation\" of the TimeInLocationConversationState class", ignore_extras);
            fieldGeneratorSourceTimeZone = new TimeZoneJSON.HoldingGenerator("field \"SourceTimeZone\" of the TimeInLocationConversationState class", ignore_extras);
            fieldGeneratorSourceDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"SourceDateTimeSpec\" of the TimeInLocationConversationState class", ignore_extras);
            fieldGeneratorDestinationMapLocation = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocation\" of the TimeInLocationConversationState class", ignore_extras);
            fieldGeneratorDestinationTimeZone = new TimeZoneJSON.HoldingGenerator("field \"DestinationTimeZone\" of the TimeInLocationConversationState class", ignore_extras);
            fieldGeneratorDestinationDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"DestinationDateTimeSpec\" of the TimeInLocationConversationState class", ignore_extras);
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the TimeInLocationConversationState class", ignore_extras);
            fieldGeneratorTimeZone = new TimeZoneJSON.HoldingGenerator("field \"TimeZone\" of the TimeInLocationConversationState class", ignore_extras);
            fieldGeneratorDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"DateTimeSpec\" of the TimeInLocationConversationState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimeInLocationConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the TimeInLocationConversationState class");
            fieldGeneratorSourceMapLocation = new MapLocationJSON.HoldingGenerator("field \"SourceMapLocation\" of the TimeInLocationConversationState class", false);
            fieldGeneratorSourceTimeZone = new TimeZoneJSON.HoldingGenerator("field \"SourceTimeZone\" of the TimeInLocationConversationState class", false);
            fieldGeneratorSourceDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"SourceDateTimeSpec\" of the TimeInLocationConversationState class", false);
            fieldGeneratorDestinationMapLocation = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocation\" of the TimeInLocationConversationState class", false);
            fieldGeneratorDestinationTimeZone = new TimeZoneJSON.HoldingGenerator("field \"DestinationTimeZone\" of the TimeInLocationConversationState class", false);
            fieldGeneratorDestinationDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"DestinationDateTimeSpec\" of the TimeInLocationConversationState class", false);
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the TimeInLocationConversationState class", false);
            fieldGeneratorTimeZone = new TimeZoneJSON.HoldingGenerator("field \"TimeZone\" of the TimeInLocationConversationState class", false);
            fieldGeneratorDateTimeSpec = new DateTimeSpecJSON.HoldingGenerator("field \"DateTimeSpec\" of the TimeInLocationConversationState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimeInLocationConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDateAndTimeKind.reset();
            fieldGeneratorSourceMapLocation.reset();
            fieldGeneratorSourceTimeZone.reset();
            fieldGeneratorSourceDateTimeSpec.reset();
            fieldGeneratorDestinationMapLocation.reset();
            fieldGeneratorDestinationTimeZone.reset();
            fieldGeneratorDestinationDateTimeSpec.reset();
            fieldGeneratorMapLocation.reset();
            fieldGeneratorTimeZone.reset();
            fieldGeneratorDateTimeSpec.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSourceMapLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSourceTimeZone.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSourceDateTimeSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDestinationMapLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDestinationTimeZone.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDestinationDateTimeSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMapLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTimeZone.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDateTimeSpec.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSourceMapLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSourceTimeZone.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSourceDateTimeSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDestinationMapLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDestinationTimeZone.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDestinationDateTimeSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMapLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTimeZone.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDateTimeSpec.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TimeInLocationConversationStateJSON  result)
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
        public TimeInLocationConversationStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimeInLocationConversationStateJSON  result)
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
    protected virtual void handle_result(List<TimeInLocationConversationStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimeInLocationConversationStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimeInLocationConversationStateJSON>();
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
    public List<TimeInLocationConversationStateJSON> value;
  };
  };
