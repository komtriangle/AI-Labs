/* file "OpenCloseEventJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class OpenCloseEventJSON : JSONBase
  {
    public enum TypeEventType
      {
        EventType_Open,
        EventType_Close
      };

    public static TypeEventType  stringToEventType(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "lose", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeEventType.EventType_Close;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "pen", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeEventType.EventType_Open;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `EventType' is not one of the legal values.");
      }

    public static string  stringFromEventType(TypeEventType the_enum)
      {
        switch (the_enum)
          {
            case TypeEventType.EventType_Open:
                return "Open";
            case TypeEventType.EventType_Close:
                return "Close";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTimeOfDay;
    private TimeOfDayJSON  storeTimeOfDay;
    private bool flagHasEventType;
    private TypeEventType storeEventType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTimeOfDay(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeOfDayJSON convert_classy = TimeOfDayJSON.from_json(json_value, ignore_extras, true);
        setTimeOfDay(convert_classy);
      }


    private void  fromJSONEventType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EventType of OpenCloseEventJSON is not a string.");
        TypeEventType the_enum;
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "lose", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeEventType.EventType_Close;
                        goto enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "pen", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeEventType.EventType_Open;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field EventType of OpenCloseEventJSON is not one of the legal strings.");
      enum_is_done:;
        setEventType(the_enum);
      }


    public OpenCloseEventJSON()
      {
        flagHasTimeOfDay = false;
        flagHasEventType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTimeOfDay()
      {
        return flagHasTimeOfDay;
      }

    public TimeOfDayJSON   getTimeOfDay()
      {
        Debug.Assert(flagHasTimeOfDay);
        return storeTimeOfDay;
      }

    public bool  hasEventType()
      {
        return flagHasEventType;
      }

    public TypeEventType  getEventType()
      {
        Debug.Assert(flagHasEventType);
        return storeEventType;
      }

    public string  getEventTypeAsString()
      {
        return stringFromEventType(getEventType());
      }


    public virtual int extraOpenCloseEventComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOpenCloseEventComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOpenCloseEventComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOpenCloseEventLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTimeOfDay(TimeOfDayJSON  new_value)
      {
        if (flagHasTimeOfDay)
          {
          }
        flagHasTimeOfDay = true;
        storeTimeOfDay = new_value;
      }
    public void unsetTimeOfDay()
      {
        if (flagHasTimeOfDay)
          {
          }
        flagHasTimeOfDay = false;
      }
    public void setEventType(TypeEventType new_value)
      {
        flagHasEventType = true;
        storeEventType = new_value;
      }
    public void setEventType(string chars)
      {
        setEventType(stringToEventType(chars));
      }
    public void unsetEventType()
      {
        flagHasEventType = false;
      }

    public virtual void extraOpenCloseEventAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOpenCloseEventSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOpenCloseEventLookup(key);
        if (old_field == null)
          {
            extraOpenCloseEventAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasTimeOfDay);
        if (flagHasTimeOfDay)
          {
            handler.start_pair("TimeOfDay");
            if (partial_allowed)
                storeTimeOfDay.write_partial_as_json(handler);
            else
                storeTimeOfDay.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasEventType);
        if (flagHasEventType)
          {
            handler.start_pair("EventType");
            switch (storeEventType)
              {
                case TypeEventType.EventType_Open:
                    handler.string_value("Open");
                    break;
                case TypeEventType.EventType_Close:
                    handler.string_value("Close");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        if (!(hasTimeOfDay()))
          {
            return "When parsing the object for %what%, the \"TimeOfDay\" field was missing.";
          }
        if (!(hasEventType()))
          {
            return "When parsing the object for %what%, the \"EventType\" field was missing.";
          }
        return null;
      }

    public static OpenCloseEventJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OpenCloseEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OpenCloseEvent", ignore_extras);
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
    public static OpenCloseEventJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OpenCloseEventJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OpenCloseEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OpenCloseEvent", ignore_extras);
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
    public static OpenCloseEventJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OpenCloseEventJSON from_text(string text, bool ignore_extras)
      {
        OpenCloseEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OpenCloseEvent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OpenCloseEventJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OpenCloseEventJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OpenCloseEventJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OpenCloseEvent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TimeOfDayJSON.HoldingGenerator fieldGeneratorTimeOfDay;
    private abstract class FieldGeneratorEventType : JSONStringGenerator
          {
            protected FieldGeneratorEventType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorEventType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToEventType(result));
              }
            protected abstract void handle_result(TypeEventType result);
          };
    private class FieldHoldingGeneratorEventType : FieldGeneratorEventType
  {
    protected override void handle_result(TypeEventType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorEventType(String what)
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
    public TypeEventType value;
  };
    private class FieldHoldingArrayGeneratorEventType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorEventType
      {
        private FieldHoldingArrayGeneratorEventType top;

        protected override void handle_result(TypeEventType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorEventType init_top)
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
    protected virtual void handle_result(List<TypeEventType> result)
      {
      }

    public FieldHoldingArrayGeneratorEventType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEventType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorEventType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEventType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeEventType> value;
  };
        private FieldHoldingGeneratorEventType fieldGeneratorEventType;
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
            OpenCloseEventJSON result = new OpenCloseEventJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOpenCloseEventAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OpenCloseEventJSON result)
          {
            if (fieldGeneratorTimeOfDay.have_value)
              {
                result.setTimeOfDay(fieldGeneratorTimeOfDay.value);
                fieldGeneratorTimeOfDay.have_value = false;
              }
            else if ((!(result.hasTimeOfDay())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TimeOfDay\" field was missing.");
              }
            if (fieldGeneratorEventType.have_value)
              {
                result.setEventType(fieldGeneratorEventType.value);
                fieldGeneratorEventType.have_value = false;
              }
            else if ((!(result.hasEventType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EventType\" field was missing.");
              }
          }
        protected abstract void handle_result(OpenCloseEventJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "ventType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorEventType;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "imeOfDay", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorTimeOfDay;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTimeOfDay = new TimeOfDayJSON.HoldingGenerator("field \"TimeOfDay\" of the OpenCloseEvent class", ignore_extras);
            fieldGeneratorEventType = new FieldHoldingGeneratorEventType("field \"EventType\" of the OpenCloseEvent class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OpenCloseEvent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTimeOfDay = new TimeOfDayJSON.HoldingGenerator("field \"TimeOfDay\" of the OpenCloseEvent class", false);
            fieldGeneratorEventType = new FieldHoldingGeneratorEventType("field \"EventType\" of the OpenCloseEvent class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OpenCloseEvent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTimeOfDay.reset();
            fieldGeneratorEventType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTimeOfDay.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTimeOfDay.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(OpenCloseEventJSON  result)
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
        public OpenCloseEventJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OpenCloseEventJSON  result)
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
    protected virtual void handle_result(List<OpenCloseEventJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OpenCloseEventJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OpenCloseEventJSON>();
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
    public List<OpenCloseEventJSON> value;
  };
  };
