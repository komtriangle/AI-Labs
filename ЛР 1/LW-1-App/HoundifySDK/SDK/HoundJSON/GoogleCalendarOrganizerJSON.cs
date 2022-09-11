/* file "GoogleCalendarOrganizerJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class GoogleCalendarOrganizerJSON : JSONBase
  {
    private bool flagHasid;
    private string storeid;
    private bool flagHasemail;
    private string storeemail;
    private bool flagHasdisplayName;
    private string storedisplayName;
    private bool flagHasself;
    private bool storeself;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field id of GoogleCalendarOrganizerJSON is not a string.");
        setid(json_string.getData());
      }


    private void  fromJSONemail(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field email of GoogleCalendarOrganizerJSON is not a string.");
        setemail(json_string.getData());
      }


    private void  fromJSONdisplayName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field displayName of GoogleCalendarOrganizerJSON is not a string.");
        setdisplayName(json_string.getData());
      }


    private void  fromJSONself(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field self of GoogleCalendarOrganizerJSON is not true for false.");
              }
          }
        setself(the_bool);
      }


    public GoogleCalendarOrganizerJSON()
      {
        flagHasid = false;
        flagHasemail = false;
        flagHasdisplayName = false;
        flagHasself = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasid()
      {
        return flagHasid;
      }

    public string  getid()
      {
        Debug.Assert(flagHasid);
        return storeid;
      }

    public bool  hasemail()
      {
        return flagHasemail;
      }

    public string  getemail()
      {
        Debug.Assert(flagHasemail);
        return storeemail;
      }

    public bool  hasdisplayName()
      {
        return flagHasdisplayName;
      }

    public string  getdisplayName()
      {
        Debug.Assert(flagHasdisplayName);
        return storedisplayName;
      }

    public bool  hasself()
      {
        return flagHasself;
      }

    public bool  getself()
      {
        Debug.Assert(flagHasself);
        return storeself;
      }


    public virtual int extraGoogleCalendarOrganizerComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGoogleCalendarOrganizerComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGoogleCalendarOrganizerComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGoogleCalendarOrganizerLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setid(string new_value)
      {
        flagHasid = true;
        storeid = new_value;
      }
    public void unsetid()
      {
        flagHasid = false;
      }
    public void setemail(string new_value)
      {
        flagHasemail = true;
        storeemail = new_value;
      }
    public void unsetemail()
      {
        flagHasemail = false;
      }
    public void setdisplayName(string new_value)
      {
        flagHasdisplayName = true;
        storedisplayName = new_value;
      }
    public void unsetdisplayName()
      {
        flagHasdisplayName = false;
      }
    public void setself(bool new_value)
      {
        flagHasself = true;
        storeself = new_value;
      }
    public void unsetself()
      {
        flagHasself = false;
      }

    public virtual void extraGoogleCalendarOrganizerAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGoogleCalendarOrganizerSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGoogleCalendarOrganizerLookup(key);
        if (old_field == null)
          {
            extraGoogleCalendarOrganizerAppendPair(key, new_component);
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
        if (flagHasid)
          {
            handler.start_pair("id");
            handler.string_value(storeid);
          }
        if (flagHasemail)
          {
            handler.start_pair("email");
            handler.string_value(storeemail);
          }
        if (flagHasdisplayName)
          {
            handler.start_pair("displayName");
            handler.string_value(storedisplayName);
          }
        if (flagHasself)
          {
            handler.start_pair("self");
            handler.boolean_value(storeself);
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

    public static GoogleCalendarOrganizerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GoogleCalendarOrganizerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GoogleCalendarOrganizer", ignore_extras);
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
    public static GoogleCalendarOrganizerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GoogleCalendarOrganizerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GoogleCalendarOrganizerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GoogleCalendarOrganizer", ignore_extras);
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
    public static GoogleCalendarOrganizerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GoogleCalendarOrganizerJSON from_text(string text, bool ignore_extras)
      {
        GoogleCalendarOrganizerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GoogleCalendarOrganizer", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GoogleCalendarOrganizerJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static GoogleCalendarOrganizerJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GoogleCalendarOrganizerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GoogleCalendarOrganizer", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorid;
        private JSONHoldingStringGenerator fieldGeneratoremail;
        private JSONHoldingStringGenerator fieldGeneratordisplayName;
        private JSONHoldingBooleanGenerator fieldGeneratorself;
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
            GoogleCalendarOrganizerJSON result = new GoogleCalendarOrganizerJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGoogleCalendarOrganizerAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(GoogleCalendarOrganizerJSON result)
          {
            if (fieldGeneratorid.have_value)
              {
                result.setid(fieldGeneratorid.value);
                fieldGeneratorid.have_value = false;
              }
            if (fieldGeneratoremail.have_value)
              {
                result.setemail(fieldGeneratoremail.value);
                fieldGeneratoremail.have_value = false;
              }
            if (fieldGeneratordisplayName.have_value)
              {
                result.setdisplayName(fieldGeneratordisplayName.value);
                fieldGeneratordisplayName.have_value = false;
              }
            if (fieldGeneratorself.have_value)
              {
                result.setself(fieldGeneratorself.value);
                fieldGeneratorself.have_value = false;
              }
          }
        protected abstract void handle_result(GoogleCalendarOrganizerJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'd':
                    if ((String.Compare(field_name, 1, "isplayName", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratordisplayName;
                    break;
                case 'e':
                    if ((String.Compare(field_name, 1, "mail", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratoremail;
                    break;
                case 'i':
                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorid;
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "elf", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorself;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the GoogleCalendarOrganizer class");
            fieldGeneratoremail = new JSONHoldingStringGenerator("field \"email\" of the GoogleCalendarOrganizer class");
            fieldGeneratordisplayName = new JSONHoldingStringGenerator("field \"displayName\" of the GoogleCalendarOrganizer class");
            fieldGeneratorself = new JSONHoldingBooleanGenerator("field \"self\" of the GoogleCalendarOrganizer class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GoogleCalendarOrganizer class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorid = new JSONHoldingStringGenerator("field \"id\" of the GoogleCalendarOrganizer class");
            fieldGeneratoremail = new JSONHoldingStringGenerator("field \"email\" of the GoogleCalendarOrganizer class");
            fieldGeneratordisplayName = new JSONHoldingStringGenerator("field \"displayName\" of the GoogleCalendarOrganizer class");
            fieldGeneratorself = new JSONHoldingBooleanGenerator("field \"self\" of the GoogleCalendarOrganizer class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GoogleCalendarOrganizer class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorid.reset();
            fieldGeneratoremail.reset();
            fieldGeneratordisplayName.reset();
            fieldGeneratorself.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(GoogleCalendarOrganizerJSON  result)
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
        public GoogleCalendarOrganizerJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GoogleCalendarOrganizerJSON  result)
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
    protected virtual void handle_result(List<GoogleCalendarOrganizerJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GoogleCalendarOrganizerJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GoogleCalendarOrganizerJSON>();
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
    public List<GoogleCalendarOrganizerJSON> value;
  };
  };
