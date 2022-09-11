/* file "TimeOfMoonPhaseConversationStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimeOfMoonPhaseConversationStateJSON : JSONBase
  {
    public enum TypeDateAndTimeKind
      {
        DateAndTimeKind_TimeOfMoonPhase
      };

    public static TypeDateAndTimeKind  stringToDateAndTimeKind(string chars)
      {
        if ((String.Compare(chars, 0, "TimeOfMoonPhase", 0, 15, false) == 0) && (chars.Length == 15))
            return TypeDateAndTimeKind.DateAndTimeKind_TimeOfMoonPhase;
        throw new Exception("The value for field `DateAndTimeKind' is not one of the legal values.");
      }

    public static string  stringFromDateAndTimeKind(TypeDateAndTimeKind the_enum)
      {
        switch (the_enum)
          {
            case TypeDateAndTimeKind.DateAndTimeKind_TimeOfMoonPhase:
                return "TimeOfMoonPhase";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasDateAndTimeKind;
    private bool flagHasDateAndTime;
    private DateAndOrTimeJSON  storeDateAndTime;
    private bool flagHasMapLocation;
    private MapLocationJSON  storeMapLocation;
    private bool flagHasRequestedMoonPhase;
    private string storeRequestedMoonPhase;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDateAndTimeKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DateAndTimeKind of TimeOfMoonPhaseConversationStateJSON is not a string.");
        if (!(json_string.getData().Equals("TimeOfMoonPhase")))
            throw new Exception("The value for field DateAndTimeKind of TimeOfMoonPhaseConversationStateJSON is not `TimeOfMoonPhase'.");
        setDateAndTimeKind();
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
            throw new Exception("The value for field RequestedMoonPhase of TimeOfMoonPhaseConversationStateJSON is not a string.");
        setRequestedMoonPhase(json_string.getData());
      }


    public TimeOfMoonPhaseConversationStateJSON()
      {
        flagHasDateAndTimeKind = false;
        flagHasDateAndTime = false;
        flagHasMapLocation = false;
        flagHasRequestedMoonPhase = false;
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
        return TypeDateAndTimeKind.DateAndTimeKind_TimeOfMoonPhase;
      }

    public string  getDateAndTimeKindAsString()
      {
        return stringFromDateAndTimeKind(getDateAndTimeKind());
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


    public virtual int extraTimeOfMoonPhaseConversationStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimeOfMoonPhaseConversationStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimeOfMoonPhaseConversationStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimeOfMoonPhaseConversationStateLookup(string field_name)
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

    public virtual void extraTimeOfMoonPhaseConversationStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimeOfMoonPhaseConversationStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimeOfMoonPhaseConversationStateLookup(key);
        if (old_field == null)
          {
            extraTimeOfMoonPhaseConversationStateAppendPair(key, new_component);
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
            handler.string_value("TimeOfMoonPhase");
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
        if (!(hasDateAndTime()))
          {
            return "When parsing the object for %what%, the \"DateAndTime\" field was missing.";
          }
        if (!(hasRequestedMoonPhase()))
          {
            return "When parsing the object for %what%, the \"RequestedMoonPhase\" field was missing.";
          }
        return null;
      }

    public static TimeOfMoonPhaseConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeOfMoonPhaseConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeOfMoonPhaseConversationState", ignore_extras);
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
    public static TimeOfMoonPhaseConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimeOfMoonPhaseConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeOfMoonPhaseConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeOfMoonPhaseConversationState", ignore_extras);
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
    public static TimeOfMoonPhaseConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimeOfMoonPhaseConversationStateJSON from_text(string text, bool ignore_extras)
      {
        TimeOfMoonPhaseConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeOfMoonPhaseConversationState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimeOfMoonPhaseConversationStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TimeOfMoonPhaseConversationStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimeOfMoonPhaseConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeOfMoonPhaseConversationState", ignore_extras);
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
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorDateAndTime;
        private MapLocationJSON.HoldingGenerator fieldGeneratorMapLocation;
        private JSONHoldingStringGenerator fieldGeneratorRequestedMoonPhase;
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
            TimeOfMoonPhaseConversationStateJSON result = new TimeOfMoonPhaseConversationStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimeOfMoonPhaseConversationStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TimeOfMoonPhaseConversationStateJSON result)
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
          }
        protected abstract void handle_result(TimeOfMoonPhaseConversationStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "ateAndTime", 0, 10, false) == 0)
                      {
                        if (field_name.Length == 11)
                          {
                            return fieldGeneratorDateAndTime;
                          }
                        switch (field_name[11])
                          {
                            case 'K':
                                if ((String.Compare(field_name, 12, "ind", 0, 3, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorDateAndTimeKind;
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
                    if ((String.Compare(field_name, 1, "equestedMoonPhase", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorRequestedMoonPhase;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the TimeOfMoonPhaseConversationState class");
            fieldGeneratorDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndTime\" of the TimeOfMoonPhaseConversationState class", ignore_extras);
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the TimeOfMoonPhaseConversationState class", ignore_extras);
            fieldGeneratorRequestedMoonPhase = new JSONHoldingStringGenerator("field \"RequestedMoonPhase\" of the TimeOfMoonPhaseConversationState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimeOfMoonPhaseConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the TimeOfMoonPhaseConversationState class");
            fieldGeneratorDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndTime\" of the TimeOfMoonPhaseConversationState class", false);
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the TimeOfMoonPhaseConversationState class", false);
            fieldGeneratorRequestedMoonPhase = new JSONHoldingStringGenerator("field \"RequestedMoonPhase\" of the TimeOfMoonPhaseConversationState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimeOfMoonPhaseConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDateAndTimeKind.reset();
            fieldGeneratorDateAndTime.reset();
            fieldGeneratorMapLocation.reset();
            fieldGeneratorRequestedMoonPhase.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMapLocation.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMapLocation.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TimeOfMoonPhaseConversationStateJSON  result)
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
        public TimeOfMoonPhaseConversationStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimeOfMoonPhaseConversationStateJSON  result)
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
    protected virtual void handle_result(List<TimeOfMoonPhaseConversationStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimeOfMoonPhaseConversationStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimeOfMoonPhaseConversationStateJSON>();
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
    public List<TimeOfMoonPhaseConversationStateJSON> value;
  };
  };
