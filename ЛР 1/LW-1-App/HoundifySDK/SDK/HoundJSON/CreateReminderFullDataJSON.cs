/* file "CreateReminderFullDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CreateReminderFullDataJSON : JSONBase
  {
    private bool flagHasReminderSubject;
    private ReminderSubjectJSON  storeReminderSubject;
    private bool flagHasReminderTime;
    private ReminderTimeJSON  storeReminderTime;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONReminderSubject(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ReminderSubjectJSON convert_classy = ReminderSubjectJSON.from_json(json_value, ignore_extras, true);
        setReminderSubject(convert_classy);
      }


    private void  fromJSONReminderTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ReminderTimeJSON convert_classy = ReminderTimeJSON.from_json(json_value, ignore_extras, true);
        setReminderTime(convert_classy);
      }


    public CreateReminderFullDataJSON()
      {
        flagHasReminderSubject = false;
        flagHasReminderTime = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasReminderSubject()
      {
        return flagHasReminderSubject;
      }

    public ReminderSubjectJSON   getReminderSubject()
      {
        Debug.Assert(flagHasReminderSubject);
        return storeReminderSubject;
      }

    public bool  hasReminderTime()
      {
        return flagHasReminderTime;
      }

    public ReminderTimeJSON   getReminderTime()
      {
        Debug.Assert(flagHasReminderTime);
        return storeReminderTime;
      }


    public virtual int extraCreateReminderFullDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCreateReminderFullDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCreateReminderFullDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCreateReminderFullDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setReminderSubject(ReminderSubjectJSON  new_value)
      {
        if (flagHasReminderSubject)
          {
          }
        flagHasReminderSubject = true;
        storeReminderSubject = new_value;
      }
    public void unsetReminderSubject()
      {
        if (flagHasReminderSubject)
          {
          }
        flagHasReminderSubject = false;
      }
    public void setReminderTime(ReminderTimeJSON  new_value)
      {
        if (flagHasReminderTime)
          {
          }
        flagHasReminderTime = true;
        storeReminderTime = new_value;
      }
    public void unsetReminderTime()
      {
        if (flagHasReminderTime)
          {
          }
        flagHasReminderTime = false;
      }

    public virtual void extraCreateReminderFullDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCreateReminderFullDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCreateReminderFullDataLookup(key);
        if (old_field == null)
          {
            extraCreateReminderFullDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasReminderSubject);
        if (flagHasReminderSubject)
          {
            handler.start_pair("ReminderSubject");
            if (partial_allowed)
                storeReminderSubject.write_partial_as_json(handler);
            else
                storeReminderSubject.write_as_json(handler);
          }
        if (flagHasReminderTime)
          {
            handler.start_pair("ReminderTime");
            if (partial_allowed)
                storeReminderTime.write_partial_as_json(handler);
            else
                storeReminderTime.write_as_json(handler);
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
        if (!(hasReminderSubject()))
          {
            return "When parsing the object for %what%, the \"ReminderSubject\" field was missing.";
          }
        return null;
      }

    public static CreateReminderFullDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CreateReminderFullDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CreateReminderFullData", ignore_extras);
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
    public static CreateReminderFullDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CreateReminderFullDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CreateReminderFullDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CreateReminderFullData", ignore_extras);
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
    public static CreateReminderFullDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CreateReminderFullDataJSON from_text(string text, bool ignore_extras)
      {
        CreateReminderFullDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CreateReminderFullData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CreateReminderFullDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CreateReminderFullDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CreateReminderFullDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CreateReminderFullData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private ReminderSubjectJSON.HoldingGenerator fieldGeneratorReminderSubject;
        private ReminderTimeJSON.HoldingGenerator fieldGeneratorReminderTime;
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
            CreateReminderFullDataJSON result = new CreateReminderFullDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCreateReminderFullDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CreateReminderFullDataJSON result)
          {
            if (fieldGeneratorReminderSubject.have_value)
              {
                result.setReminderSubject(fieldGeneratorReminderSubject.value);
                fieldGeneratorReminderSubject.have_value = false;
              }
            else if ((!(result.hasReminderSubject())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ReminderSubject\" field was missing.");
              }
            if (fieldGeneratorReminderTime.have_value)
              {
                result.setReminderTime(fieldGeneratorReminderTime.value);
                fieldGeneratorReminderTime.have_value = false;
              }
          }
        protected abstract void handle_result(CreateReminderFullDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Reminder", 0, 8, false) == 0)
              {
                switch (field_name[8])
                  {
                    case 'S':
                        if ((String.Compare(field_name, 9, "ubject", 0, 6, false) == 0) && (field_name.Length == 15))
                            return fieldGeneratorReminderSubject;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 9, "ime", 0, 3, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorReminderTime;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorReminderSubject = new ReminderSubjectJSON.HoldingGenerator("field \"ReminderSubject\" of the CreateReminderFullData class", ignore_extras);
            fieldGeneratorReminderTime = new ReminderTimeJSON.HoldingGenerator("field \"ReminderTime\" of the CreateReminderFullData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CreateReminderFullData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorReminderSubject = new ReminderSubjectJSON.HoldingGenerator("field \"ReminderSubject\" of the CreateReminderFullData class", false);
            fieldGeneratorReminderTime = new ReminderTimeJSON.HoldingGenerator("field \"ReminderTime\" of the CreateReminderFullData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CreateReminderFullData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorReminderSubject.reset();
            fieldGeneratorReminderTime.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorReminderSubject.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorReminderTime.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorReminderSubject.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorReminderTime.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CreateReminderFullDataJSON  result)
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
        public CreateReminderFullDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CreateReminderFullDataJSON  result)
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
    protected virtual void handle_result(List<CreateReminderFullDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CreateReminderFullDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CreateReminderFullDataJSON>();
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
    public List<CreateReminderFullDataJSON> value;
  };
  };
