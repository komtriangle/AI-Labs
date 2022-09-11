/* file "ReminderJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ReminderJSON : JSONBase
  {
    private bool flagHasUUID;
    private string storeUUID;
    private bool flagHasSubject;
    private ReminderSubjectJSON  storeSubject;
    private bool flagHasWhen;
    private ReminderTimeJSON  storeWhen;
    private bool flagHasState;
    private ReminderStateJSON  storeState;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONUUID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UUID of ReminderJSON is not a string.");
        setUUID(json_string.getData());
      }


    private void  fromJSONSubject(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ReminderSubjectJSON convert_classy = ReminderSubjectJSON.from_json(json_value, ignore_extras, true);
        setSubject(convert_classy);
      }


    private void  fromJSONWhen(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ReminderTimeJSON convert_classy = ReminderTimeJSON.from_json(json_value, ignore_extras, true);
        setWhen(convert_classy);
      }


    private void  fromJSONState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ReminderStateJSON convert_classy = ReminderStateJSON.from_json(json_value, ignore_extras, true);
        setState(convert_classy);
      }


    public ReminderJSON()
      {
        flagHasUUID = false;
        flagHasSubject = false;
        flagHasWhen = false;
        flagHasState = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasUUID()
      {
        return flagHasUUID;
      }

    public string  getUUID()
      {
        Debug.Assert(flagHasUUID);
        return storeUUID;
      }

    public bool  hasSubject()
      {
        return flagHasSubject;
      }

    public ReminderSubjectJSON   getSubject()
      {
        Debug.Assert(flagHasSubject);
        return storeSubject;
      }

    public bool  hasWhen()
      {
        return flagHasWhen;
      }

    public ReminderTimeJSON   getWhen()
      {
        Debug.Assert(flagHasWhen);
        return storeWhen;
      }

    public bool  hasState()
      {
        return flagHasState;
      }

    public ReminderStateJSON   getState()
      {
        Debug.Assert(flagHasState);
        return storeState;
      }

    public ReminderStateJSON.TypeValue  getStateValue()
      {
        return getState().getValue();
      }

    public string  getStateAsString()
      {
        return getState().getValueAsString();
      }


    public virtual int extraReminderComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraReminderComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraReminderComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraReminderLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setUUID(string new_value)
      {
        flagHasUUID = true;
        storeUUID = new_value;
      }
    public void unsetUUID()
      {
        flagHasUUID = false;
      }
    public void setSubject(ReminderSubjectJSON  new_value)
      {
        if (flagHasSubject)
          {
          }
        flagHasSubject = true;
        storeSubject = new_value;
      }
    public void unsetSubject()
      {
        if (flagHasSubject)
          {
          }
        flagHasSubject = false;
      }
    public void setWhen(ReminderTimeJSON  new_value)
      {
        if (flagHasWhen)
          {
          }
        flagHasWhen = true;
        storeWhen = new_value;
      }
    public void unsetWhen()
      {
        if (flagHasWhen)
          {
          }
        flagHasWhen = false;
      }
    public void setState(ReminderStateJSON  new_value)
      {
        if (flagHasState)
          {
          }
        flagHasState = true;
        storeState = new_value;
      }
    public void setState(ReminderStateJSON.TypeValue new_value)
      {
        setState(new ReminderStateJSON(new_value));
      }
    public void setState(string chars)
      {
        ReminderStateJSON.TypeValueKnownValues known = ReminderStateJSON.stringToValue(chars);
        ReminderStateJSON.TypeValue new_value = new ReminderStateJSON.TypeValue();
        if (known == ReminderStateJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setState(new_value);
      }
    public void unsetState()
      {
        if (flagHasState)
          {
          }
        flagHasState = false;
      }

    public virtual void extraReminderAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraReminderSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraReminderLookup(key);
        if (old_field == null)
          {
            extraReminderAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasUUID);
        if (flagHasUUID)
          {
            handler.start_pair("UUID");
            handler.string_value(storeUUID);
          }
        Debug.Assert(partial_allowed || flagHasSubject);
        if (flagHasSubject)
          {
            handler.start_pair("Subject");
            if (partial_allowed)
                storeSubject.write_partial_as_json(handler);
            else
                storeSubject.write_as_json(handler);
          }
        if (flagHasWhen)
          {
            handler.start_pair("When");
            if (partial_allowed)
                storeWhen.write_partial_as_json(handler);
            else
                storeWhen.write_as_json(handler);
          }
        if (flagHasState)
          {
            handler.start_pair("State");
            if (partial_allowed)
                storeState.write_partial_as_json(handler);
            else
                storeState.write_as_json(handler);
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
        if (!(hasUUID()))
          {
            return "When parsing the object for %what%, the \"UUID\" field was missing.";
          }
        if (!(hasSubject()))
          {
            return "When parsing the object for %what%, the \"Subject\" field was missing.";
          }
        return null;
      }

    public static ReminderJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ReminderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Reminder", ignore_extras);
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
    public static ReminderJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ReminderJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ReminderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Reminder", ignore_extras);
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
    public static ReminderJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ReminderJSON from_text(string text, bool ignore_extras)
      {
        ReminderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Reminder", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ReminderJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ReminderJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ReminderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Reminder", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorUUID;
        private ReminderSubjectJSON.HoldingGenerator fieldGeneratorSubject;
        private ReminderTimeJSON.HoldingGenerator fieldGeneratorWhen;
        private ReminderStateJSON.HoldingGenerator fieldGeneratorState;
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
            ReminderJSON result = new ReminderJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraReminderAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ReminderJSON result)
          {
            if (fieldGeneratorUUID.have_value)
              {
                result.setUUID(fieldGeneratorUUID.value);
                fieldGeneratorUUID.have_value = false;
              }
            else if ((!(result.hasUUID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UUID\" field was missing.");
              }
            if (fieldGeneratorSubject.have_value)
              {
                result.setSubject(fieldGeneratorSubject.value);
                fieldGeneratorSubject.have_value = false;
              }
            else if ((!(result.hasSubject())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Subject\" field was missing.");
              }
            if (fieldGeneratorWhen.have_value)
              {
                result.setWhen(fieldGeneratorWhen.value);
                fieldGeneratorWhen.have_value = false;
              }
            if (fieldGeneratorState.have_value)
              {
                result.setState(fieldGeneratorState.value);
                fieldGeneratorState.have_value = false;
              }
          }
        protected abstract void handle_result(ReminderJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'S':
                    switch (field_name[1])
                      {
                        case 't':
                            if ((String.Compare(field_name, 2, "ate", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorState;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "bject", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorSubject;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "UID", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorUUID;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "hen", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorWhen;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorUUID = new JSONHoldingStringGenerator("field \"UUID\" of the Reminder class");
            fieldGeneratorSubject = new ReminderSubjectJSON.HoldingGenerator("field \"Subject\" of the Reminder class", ignore_extras);
            fieldGeneratorWhen = new ReminderTimeJSON.HoldingGenerator("field \"When\" of the Reminder class", ignore_extras);
            fieldGeneratorState = new ReminderStateJSON.HoldingGenerator("field \"State\" of the Reminder class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Reminder class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorUUID = new JSONHoldingStringGenerator("field \"UUID\" of the Reminder class");
            fieldGeneratorSubject = new ReminderSubjectJSON.HoldingGenerator("field \"Subject\" of the Reminder class", false);
            fieldGeneratorWhen = new ReminderTimeJSON.HoldingGenerator("field \"When\" of the Reminder class", false);
            fieldGeneratorState = new ReminderStateJSON.HoldingGenerator("field \"State\" of the Reminder class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Reminder class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorUUID.reset();
            fieldGeneratorSubject.reset();
            fieldGeneratorWhen.reset();
            fieldGeneratorState.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSubject.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWhen.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorState.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSubject.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWhen.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorState.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ReminderJSON  result)
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
        public ReminderJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ReminderJSON  result)
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
    protected virtual void handle_result(List<ReminderJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ReminderJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ReminderJSON>();
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
    public List<ReminderJSON> value;
  };
  };
