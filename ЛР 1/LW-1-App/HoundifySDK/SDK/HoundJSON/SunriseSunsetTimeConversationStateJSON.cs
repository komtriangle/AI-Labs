/* file "SunriseSunsetTimeConversationStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SunriseSunsetTimeConversationStateJSON : JSONBase
  {
    public enum TypeDateAndTimeKind
      {
        DateAndTimeKind_SunriseSunsetTime
      };

    public static TypeDateAndTimeKind  stringToDateAndTimeKind(string chars)
      {
        if ((String.Compare(chars, 0, "SunriseSunsetTime", 0, 17, false) == 0) && (chars.Length == 17))
            return TypeDateAndTimeKind.DateAndTimeKind_SunriseSunsetTime;
        throw new Exception("The value for field `DateAndTimeKind' is not one of the legal values.");
      }

    public static string  stringFromDateAndTimeKind(TypeDateAndTimeKind the_enum)
      {
        switch (the_enum)
          {
            case TypeDateAndTimeKind.DateAndTimeKind_SunriseSunsetTime:
                return "SunriseSunsetTime";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasDateAndTimeKind;
    private bool flagHasMapLocation;
    private MapLocationJSON  storeMapLocation;
    private bool flagHasRequestedType;
    private string storeRequestedType;
    private bool flagHasDateTimeRangeSpec;
    private DateTimeRangeSpecJSON  storeDateTimeRangeSpec;
    private bool flagHasIsDateTimeRequested;
    private bool storeIsDateTimeRequested;
    private bool flagHasFutureRequested;
    private bool storeFutureRequested;
    private bool flagHasPastRequested;
    private bool storePastRequested;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDateAndTimeKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DateAndTimeKind of SunriseSunsetTimeConversationStateJSON is not a string.");
        if (!(json_string.getData().Equals("SunriseSunsetTime")))
            throw new Exception("The value for field DateAndTimeKind of SunriseSunsetTimeConversationStateJSON is not `SunriseSunsetTime'.");
        setDateAndTimeKind();
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
            throw new Exception("The value for field RequestedType of SunriseSunsetTimeConversationStateJSON is not a string.");
        setRequestedType(json_string.getData());
      }


    private void  fromJSONDateTimeRangeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateTimeRangeSpec(convert_classy);
      }


    private void  fromJSONIsDateTimeRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsDateTimeRequested of SunriseSunsetTimeConversationStateJSON is not true for false.");
              }
          }
        setIsDateTimeRequested(the_bool);
      }


    private void  fromJSONFutureRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field FutureRequested of SunriseSunsetTimeConversationStateJSON is not true for false.");
              }
          }
        setFutureRequested(the_bool);
      }


    private void  fromJSONPastRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PastRequested of SunriseSunsetTimeConversationStateJSON is not true for false.");
              }
          }
        setPastRequested(the_bool);
      }


    public SunriseSunsetTimeConversationStateJSON()
      {
        flagHasDateAndTimeKind = false;
        flagHasMapLocation = false;
        flagHasRequestedType = false;
        flagHasDateTimeRangeSpec = false;
        flagHasIsDateTimeRequested = false;
        flagHasFutureRequested = false;
        flagHasPastRequested = false;
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
        return TypeDateAndTimeKind.DateAndTimeKind_SunriseSunsetTime;
      }

    public string  getDateAndTimeKindAsString()
      {
        return stringFromDateAndTimeKind(getDateAndTimeKind());
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

    public bool  hasIsDateTimeRequested()
      {
        return flagHasIsDateTimeRequested;
      }

    public bool  getIsDateTimeRequested()
      {
        Debug.Assert(flagHasIsDateTimeRequested);
        return storeIsDateTimeRequested;
      }

    public bool  hasFutureRequested()
      {
        return flagHasFutureRequested;
      }

    public bool  getFutureRequested()
      {
        Debug.Assert(flagHasFutureRequested);
        return storeFutureRequested;
      }

    public bool  hasPastRequested()
      {
        return flagHasPastRequested;
      }

    public bool  getPastRequested()
      {
        Debug.Assert(flagHasPastRequested);
        return storePastRequested;
      }


    public virtual int extraSunriseSunsetTimeConversationStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSunriseSunsetTimeConversationStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSunriseSunsetTimeConversationStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSunriseSunsetTimeConversationStateLookup(string field_name)
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
    public void setIsDateTimeRequested(bool new_value)
      {
        flagHasIsDateTimeRequested = true;
        storeIsDateTimeRequested = new_value;
      }
    public void unsetIsDateTimeRequested()
      {
        flagHasIsDateTimeRequested = false;
      }
    public void setFutureRequested(bool new_value)
      {
        flagHasFutureRequested = true;
        storeFutureRequested = new_value;
      }
    public void unsetFutureRequested()
      {
        flagHasFutureRequested = false;
      }
    public void setPastRequested(bool new_value)
      {
        flagHasPastRequested = true;
        storePastRequested = new_value;
      }
    public void unsetPastRequested()
      {
        flagHasPastRequested = false;
      }

    public virtual void extraSunriseSunsetTimeConversationStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSunriseSunsetTimeConversationStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSunriseSunsetTimeConversationStateLookup(key);
        if (old_field == null)
          {
            extraSunriseSunsetTimeConversationStateAppendPair(key, new_component);
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
            handler.string_value("SunriseSunsetTime");
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
        Debug.Assert(partial_allowed || flagHasIsDateTimeRequested);
        if (flagHasIsDateTimeRequested)
          {
            handler.start_pair("IsDateTimeRequested");
            handler.boolean_value(storeIsDateTimeRequested);
          }
        Debug.Assert(partial_allowed || flagHasFutureRequested);
        if (flagHasFutureRequested)
          {
            handler.start_pair("FutureRequested");
            handler.boolean_value(storeFutureRequested);
          }
        Debug.Assert(partial_allowed || flagHasPastRequested);
        if (flagHasPastRequested)
          {
            handler.start_pair("PastRequested");
            handler.boolean_value(storePastRequested);
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
        if (!(hasIsDateTimeRequested()))
          {
            return "When parsing the object for %what%, the \"IsDateTimeRequested\" field was missing.";
          }
        if (!(hasFutureRequested()))
          {
            return "When parsing the object for %what%, the \"FutureRequested\" field was missing.";
          }
        if (!(hasPastRequested()))
          {
            return "When parsing the object for %what%, the \"PastRequested\" field was missing.";
          }
        return null;
      }

    public static SunriseSunsetTimeConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SunriseSunsetTimeConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SunriseSunsetTimeConversationState", ignore_extras);
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
    public static SunriseSunsetTimeConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SunriseSunsetTimeConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SunriseSunsetTimeConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SunriseSunsetTimeConversationState", ignore_extras);
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
    public static SunriseSunsetTimeConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SunriseSunsetTimeConversationStateJSON from_text(string text, bool ignore_extras)
      {
        SunriseSunsetTimeConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SunriseSunsetTimeConversationState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SunriseSunsetTimeConversationStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SunriseSunsetTimeConversationStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SunriseSunsetTimeConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SunriseSunsetTimeConversationState", ignore_extras);
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
        private MapLocationJSON.HoldingGenerator fieldGeneratorMapLocation;
        private JSONHoldingStringGenerator fieldGeneratorRequestedType;
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateTimeRangeSpec;
        private JSONHoldingBooleanGenerator fieldGeneratorIsDateTimeRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorFutureRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorPastRequested;
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
            SunriseSunsetTimeConversationStateJSON result = new SunriseSunsetTimeConversationStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSunriseSunsetTimeConversationStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SunriseSunsetTimeConversationStateJSON result)
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
            if (fieldGeneratorIsDateTimeRequested.have_value)
              {
                result.setIsDateTimeRequested(fieldGeneratorIsDateTimeRequested.value);
                fieldGeneratorIsDateTimeRequested.have_value = false;
              }
            else if ((!(result.hasIsDateTimeRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsDateTimeRequested\" field was missing.");
              }
            if (fieldGeneratorFutureRequested.have_value)
              {
                result.setFutureRequested(fieldGeneratorFutureRequested.value);
                fieldGeneratorFutureRequested.have_value = false;
              }
            else if ((!(result.hasFutureRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FutureRequested\" field was missing.");
              }
            if (fieldGeneratorPastRequested.have_value)
              {
                result.setPastRequested(fieldGeneratorPastRequested.value);
                fieldGeneratorPastRequested.have_value = false;
              }
            else if ((!(result.hasPastRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PastRequested\" field was missing.");
              }
          }
        protected abstract void handle_result(SunriseSunsetTimeConversationStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "ate", 0, 3, false) == 0)
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
                case 'F':
                    if ((String.Compare(field_name, 1, "utureRequested", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorFutureRequested;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sDateTimeRequested", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorIsDateTimeRequested;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMapLocation;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "astRequested", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorPastRequested;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedType", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorRequestedType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the SunriseSunsetTimeConversationState class");
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the SunriseSunsetTimeConversationState class", ignore_extras);
            fieldGeneratorRequestedType = new JSONHoldingStringGenerator("field \"RequestedType\" of the SunriseSunsetTimeConversationState class");
            fieldGeneratorDateTimeRangeSpec = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRangeSpec\" of the SunriseSunsetTimeConversationState class", ignore_extras);
            fieldGeneratorIsDateTimeRequested = new JSONHoldingBooleanGenerator("field \"IsDateTimeRequested\" of the SunriseSunsetTimeConversationState class");
            fieldGeneratorFutureRequested = new JSONHoldingBooleanGenerator("field \"FutureRequested\" of the SunriseSunsetTimeConversationState class");
            fieldGeneratorPastRequested = new JSONHoldingBooleanGenerator("field \"PastRequested\" of the SunriseSunsetTimeConversationState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SunriseSunsetTimeConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the SunriseSunsetTimeConversationState class");
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the SunriseSunsetTimeConversationState class", false);
            fieldGeneratorRequestedType = new JSONHoldingStringGenerator("field \"RequestedType\" of the SunriseSunsetTimeConversationState class");
            fieldGeneratorDateTimeRangeSpec = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRangeSpec\" of the SunriseSunsetTimeConversationState class", false);
            fieldGeneratorIsDateTimeRequested = new JSONHoldingBooleanGenerator("field \"IsDateTimeRequested\" of the SunriseSunsetTimeConversationState class");
            fieldGeneratorFutureRequested = new JSONHoldingBooleanGenerator("field \"FutureRequested\" of the SunriseSunsetTimeConversationState class");
            fieldGeneratorPastRequested = new JSONHoldingBooleanGenerator("field \"PastRequested\" of the SunriseSunsetTimeConversationState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SunriseSunsetTimeConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDateAndTimeKind.reset();
            fieldGeneratorMapLocation.reset();
            fieldGeneratorRequestedType.reset();
            fieldGeneratorDateTimeRangeSpec.reset();
            fieldGeneratorIsDateTimeRequested.reset();
            fieldGeneratorFutureRequested.reset();
            fieldGeneratorPastRequested.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMapLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDateTimeRangeSpec.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMapLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDateTimeRangeSpec.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SunriseSunsetTimeConversationStateJSON  result)
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
        public SunriseSunsetTimeConversationStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SunriseSunsetTimeConversationStateJSON  result)
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
    protected virtual void handle_result(List<SunriseSunsetTimeConversationStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SunriseSunsetTimeConversationStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SunriseSunsetTimeConversationStateJSON>();
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
    public List<SunriseSunsetTimeConversationStateJSON> value;
  };
  };
