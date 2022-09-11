/* file "WeatherConversationStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WeatherConversationStateJSON : JSONBase
  {
    private bool flagHasWeatherKind;
    private string storeWeatherKind;
    private bool flagHasWeatherQueryType;
    private string storeWeatherQueryType;
    private bool flagHasRequestedAttribute;
    private WeatherAttributeJSON  storeRequestedAttribute;
    private bool flagHasRequestedAlmanacAttribute;
    private WeatherAlmanacAttributeJSON  storeRequestedAlmanacAttribute;
    private bool flagHasMapLocation;
    private MapLocationJSON  storeMapLocation;
    private bool flagHasDateTimeRange;
    private DateTimeRangeSpecJSON  storeDateTimeRange;
    private bool flagHasUnits;
    private WeatherUnitsFormatJSON  storeUnits;
    private bool flagHasIsSearchQuery;
    private bool storeIsSearchQuery;
    private bool flagHasDailyForecastExplicitlyRequested;
    private bool storeDailyForecastExplicitlyRequested;
    private bool flagHasHourlyForecastExplicitlyRequested;
    private bool storeHourlyForecastExplicitlyRequested;
    private bool flagHasSentenceType;
    private string storeSentenceType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONWeatherKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WeatherKind of WeatherConversationStateJSON is not a string.");
        setWeatherKind(json_string.getData());
      }


    private void  fromJSONWeatherQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WeatherQueryType of WeatherConversationStateJSON is not a string.");
        setWeatherQueryType(json_string.getData());
      }


    private void  fromJSONRequestedAttribute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherAttributeJSON convert_classy = WeatherAttributeJSON.from_json(json_value, ignore_extras, true);
        setRequestedAttribute(convert_classy);
      }


    private void  fromJSONRequestedAlmanacAttribute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeatherAlmanacAttributeJSON convert_classy = WeatherAlmanacAttributeJSON.from_json(json_value, ignore_extras, true);
        setRequestedAlmanacAttribute(convert_classy);
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
                throw new Exception("The value for field IsSearchQuery of WeatherConversationStateJSON is not true for false.");
              }
          }
        setIsSearchQuery(the_bool);
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
                throw new Exception("The value for field DailyForecastExplicitlyRequested of WeatherConversationStateJSON is not true for false.");
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
                throw new Exception("The value for field HourlyForecastExplicitlyRequested of WeatherConversationStateJSON is not true for false.");
              }
          }
        setHourlyForecastExplicitlyRequested(the_bool);
      }


    private void  fromJSONSentenceType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SentenceType of WeatherConversationStateJSON is not a string.");
        setSentenceType(json_string.getData());
      }


    public WeatherConversationStateJSON()
      {
        flagHasWeatherKind = false;
        flagHasWeatherQueryType = false;
        flagHasRequestedAttribute = false;
        flagHasRequestedAlmanacAttribute = false;
        flagHasMapLocation = false;
        flagHasDateTimeRange = false;
        flagHasUnits = false;
        flagHasIsSearchQuery = false;
        flagHasDailyForecastExplicitlyRequested = false;
        flagHasHourlyForecastExplicitlyRequested = false;
        flagHasSentenceType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasWeatherKind()
      {
        return flagHasWeatherKind;
      }

    public string  getWeatherKind()
      {
        Debug.Assert(flagHasWeatherKind);
        return storeWeatherKind;
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

    public bool  hasRequestedAlmanacAttribute()
      {
        return flagHasRequestedAlmanacAttribute;
      }

    public WeatherAlmanacAttributeJSON   getRequestedAlmanacAttribute()
      {
        Debug.Assert(flagHasRequestedAlmanacAttribute);
        return storeRequestedAlmanacAttribute;
      }

    public WeatherAlmanacAttributeJSON.TypeValue  getRequestedAlmanacAttributeValue()
      {
        return getRequestedAlmanacAttribute().getValue();
      }

    public string  getRequestedAlmanacAttributeAsString()
      {
        return getRequestedAlmanacAttribute().getValueAsString();
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

    public bool  hasIsSearchQuery()
      {
        return flagHasIsSearchQuery;
      }

    public bool  getIsSearchQuery()
      {
        Debug.Assert(flagHasIsSearchQuery);
        return storeIsSearchQuery;
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

    public bool  hasSentenceType()
      {
        return flagHasSentenceType;
      }

    public string  getSentenceType()
      {
        Debug.Assert(flagHasSentenceType);
        return storeSentenceType;
      }


    public virtual int extraWeatherConversationStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWeatherConversationStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWeatherConversationStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWeatherConversationStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setWeatherKind(string new_value)
      {
        flagHasWeatherKind = true;
        storeWeatherKind = new_value;
      }
    public void unsetWeatherKind()
      {
        flagHasWeatherKind = false;
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
    public void setRequestedAlmanacAttribute(WeatherAlmanacAttributeJSON  new_value)
      {
        if (flagHasRequestedAlmanacAttribute)
          {
          }
        flagHasRequestedAlmanacAttribute = true;
        storeRequestedAlmanacAttribute = new_value;
      }
    public void setRequestedAlmanacAttribute(WeatherAlmanacAttributeJSON.TypeValue new_value)
      {
        setRequestedAlmanacAttribute(new WeatherAlmanacAttributeJSON(new_value));
      }
    public void setRequestedAlmanacAttribute(string chars)
      {
        WeatherAlmanacAttributeJSON.TypeValueKnownValues known = WeatherAlmanacAttributeJSON.stringToValue(chars);
        WeatherAlmanacAttributeJSON.TypeValue new_value = new WeatherAlmanacAttributeJSON.TypeValue();
        if (known == WeatherAlmanacAttributeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRequestedAlmanacAttribute(new_value);
      }
    public void unsetRequestedAlmanacAttribute()
      {
        if (flagHasRequestedAlmanacAttribute)
          {
          }
        flagHasRequestedAlmanacAttribute = false;
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
    public void setIsSearchQuery(bool new_value)
      {
        flagHasIsSearchQuery = true;
        storeIsSearchQuery = new_value;
      }
    public void unsetIsSearchQuery()
      {
        flagHasIsSearchQuery = false;
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
    public void setSentenceType(string new_value)
      {
        flagHasSentenceType = true;
        storeSentenceType = new_value;
      }
    public void unsetSentenceType()
      {
        flagHasSentenceType = false;
      }

    public virtual void extraWeatherConversationStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWeatherConversationStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWeatherConversationStateLookup(key);
        if (old_field == null)
          {
            extraWeatherConversationStateAppendPair(key, new_component);
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
        if (flagHasWeatherKind)
          {
            handler.start_pair("WeatherKind");
            handler.string_value(storeWeatherKind);
          }
        if (flagHasWeatherQueryType)
          {
            handler.start_pair("WeatherQueryType");
            handler.string_value(storeWeatherQueryType);
          }
        if (flagHasRequestedAttribute)
          {
            handler.start_pair("RequestedAttribute");
            if (partial_allowed)
                storeRequestedAttribute.write_partial_as_json(handler);
            else
                storeRequestedAttribute.write_as_json(handler);
          }
        if (flagHasRequestedAlmanacAttribute)
          {
            handler.start_pair("RequestedAlmanacAttribute");
            if (partial_allowed)
                storeRequestedAlmanacAttribute.write_partial_as_json(handler);
            else
                storeRequestedAlmanacAttribute.write_as_json(handler);
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
        if (flagHasUnits)
          {
            handler.start_pair("Units");
            if (partial_allowed)
                storeUnits.write_partial_as_json(handler);
            else
                storeUnits.write_as_json(handler);
          }
        if (flagHasIsSearchQuery)
          {
            handler.start_pair("IsSearchQuery");
            handler.boolean_value(storeIsSearchQuery);
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
        if (flagHasSentenceType)
          {
            handler.start_pair("SentenceType");
            handler.string_value(storeSentenceType);
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
        return null;
      }

    public static WeatherConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WeatherConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeatherConversationState", ignore_extras);
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
    public static WeatherConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WeatherConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WeatherConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeatherConversationState", ignore_extras);
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
    public static WeatherConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WeatherConversationStateJSON from_text(string text, bool ignore_extras)
      {
        WeatherConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeatherConversationState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WeatherConversationStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WeatherConversationStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WeatherConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WeatherConversationState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorWeatherKind;
        private JSONHoldingStringGenerator fieldGeneratorWeatherQueryType;
        private WeatherAttributeJSON.HoldingGenerator fieldGeneratorRequestedAttribute;
        private WeatherAlmanacAttributeJSON.HoldingGenerator fieldGeneratorRequestedAlmanacAttribute;
        private MapLocationJSON.HoldingGenerator fieldGeneratorMapLocation;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateTimeRange;
        private WeatherUnitsFormatJSON.HoldingGenerator fieldGeneratorUnits;
        private JSONHoldingBooleanGenerator fieldGeneratorIsSearchQuery;
        private JSONHoldingBooleanGenerator fieldGeneratorDailyForecastExplicitlyRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorHourlyForecastExplicitlyRequested;
        private JSONHoldingStringGenerator fieldGeneratorSentenceType;
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
            WeatherConversationStateJSON result = new WeatherConversationStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWeatherConversationStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(WeatherConversationStateJSON result)
          {
            if (fieldGeneratorWeatherKind.have_value)
              {
                result.setWeatherKind(fieldGeneratorWeatherKind.value);
                fieldGeneratorWeatherKind.have_value = false;
              }
            if (fieldGeneratorWeatherQueryType.have_value)
              {
                result.setWeatherQueryType(fieldGeneratorWeatherQueryType.value);
                fieldGeneratorWeatherQueryType.have_value = false;
              }
            if (fieldGeneratorRequestedAttribute.have_value)
              {
                result.setRequestedAttribute(fieldGeneratorRequestedAttribute.value);
                fieldGeneratorRequestedAttribute.have_value = false;
              }
            if (fieldGeneratorRequestedAlmanacAttribute.have_value)
              {
                result.setRequestedAlmanacAttribute(fieldGeneratorRequestedAlmanacAttribute.value);
                fieldGeneratorRequestedAlmanacAttribute.have_value = false;
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
            if (fieldGeneratorIsSearchQuery.have_value)
              {
                result.setIsSearchQuery(fieldGeneratorIsSearchQuery.value);
                fieldGeneratorIsSearchQuery.have_value = false;
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
            if (fieldGeneratorSentenceType.have_value)
              {
                result.setSentenceType(fieldGeneratorSentenceType.value);
                fieldGeneratorSentenceType.have_value = false;
              }
          }
        protected abstract void handle_result(WeatherConversationStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "a", 0, 1, false) == 0)
                      {
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
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "ourlyForecastExplicitlyRequested", 0, 32, false) == 0) && (field_name.Length == 33))
                        return fieldGeneratorHourlyForecastExplicitlyRequested;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sSearchQuery", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorIsSearchQuery;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMapLocation;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "equestedA", 0, 9, false) == 0)
                      {
                        switch (field_name[10])
                          {
                            case 'l':
                                if ((String.Compare(field_name, 11, "manacAttribute", 0, 14, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorRequestedAlmanacAttribute;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 11, "tribute", 0, 7, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorRequestedAttribute;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "entenceType", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorSentenceType;
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
                            case 'K':
                                if ((String.Compare(field_name, 8, "ind", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorWeatherKind;
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorWeatherKind = new JSONHoldingStringGenerator("field \"WeatherKind\" of the WeatherConversationState class");
            fieldGeneratorWeatherQueryType = new JSONHoldingStringGenerator("field \"WeatherQueryType\" of the WeatherConversationState class");
            fieldGeneratorRequestedAttribute = new WeatherAttributeJSON.HoldingGenerator("field \"RequestedAttribute\" of the WeatherConversationState class", ignore_extras);
            fieldGeneratorRequestedAlmanacAttribute = new WeatherAlmanacAttributeJSON.HoldingGenerator("field \"RequestedAlmanacAttribute\" of the WeatherConversationState class", ignore_extras);
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the WeatherConversationState class", ignore_extras);
            fieldGeneratorDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRange\" of the WeatherConversationState class", ignore_extras);
            fieldGeneratorUnits = new WeatherUnitsFormatJSON.HoldingGenerator("field \"Units\" of the WeatherConversationState class", ignore_extras);
            fieldGeneratorIsSearchQuery = new JSONHoldingBooleanGenerator("field \"IsSearchQuery\" of the WeatherConversationState class");
            fieldGeneratorDailyForecastExplicitlyRequested = new JSONHoldingBooleanGenerator("field \"DailyForecastExplicitlyRequested\" of the WeatherConversationState class");
            fieldGeneratorHourlyForecastExplicitlyRequested = new JSONHoldingBooleanGenerator("field \"HourlyForecastExplicitlyRequested\" of the WeatherConversationState class");
            fieldGeneratorSentenceType = new JSONHoldingStringGenerator("field \"SentenceType\" of the WeatherConversationState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WeatherConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorWeatherKind = new JSONHoldingStringGenerator("field \"WeatherKind\" of the WeatherConversationState class");
            fieldGeneratorWeatherQueryType = new JSONHoldingStringGenerator("field \"WeatherQueryType\" of the WeatherConversationState class");
            fieldGeneratorRequestedAttribute = new WeatherAttributeJSON.HoldingGenerator("field \"RequestedAttribute\" of the WeatherConversationState class", false);
            fieldGeneratorRequestedAlmanacAttribute = new WeatherAlmanacAttributeJSON.HoldingGenerator("field \"RequestedAlmanacAttribute\" of the WeatherConversationState class", false);
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the WeatherConversationState class", false);
            fieldGeneratorDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRange\" of the WeatherConversationState class", false);
            fieldGeneratorUnits = new WeatherUnitsFormatJSON.HoldingGenerator("field \"Units\" of the WeatherConversationState class", false);
            fieldGeneratorIsSearchQuery = new JSONHoldingBooleanGenerator("field \"IsSearchQuery\" of the WeatherConversationState class");
            fieldGeneratorDailyForecastExplicitlyRequested = new JSONHoldingBooleanGenerator("field \"DailyForecastExplicitlyRequested\" of the WeatherConversationState class");
            fieldGeneratorHourlyForecastExplicitlyRequested = new JSONHoldingBooleanGenerator("field \"HourlyForecastExplicitlyRequested\" of the WeatherConversationState class");
            fieldGeneratorSentenceType = new JSONHoldingStringGenerator("field \"SentenceType\" of the WeatherConversationState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WeatherConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorWeatherKind.reset();
            fieldGeneratorWeatherQueryType.reset();
            fieldGeneratorRequestedAttribute.reset();
            fieldGeneratorRequestedAlmanacAttribute.reset();
            fieldGeneratorMapLocation.reset();
            fieldGeneratorDateTimeRange.reset();
            fieldGeneratorUnits.reset();
            fieldGeneratorIsSearchQuery.reset();
            fieldGeneratorDailyForecastExplicitlyRequested.reset();
            fieldGeneratorHourlyForecastExplicitlyRequested.reset();
            fieldGeneratorSentenceType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorRequestedAttribute.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedAlmanacAttribute.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMapLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDateTimeRange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUnits.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorRequestedAttribute.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedAlmanacAttribute.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMapLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDateTimeRange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUnits.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(WeatherConversationStateJSON  result)
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
        public WeatherConversationStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WeatherConversationStateJSON  result)
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
    protected virtual void handle_result(List<WeatherConversationStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WeatherConversationStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WeatherConversationStateJSON>();
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
    public List<WeatherConversationStateJSON> value;
  };
  };
