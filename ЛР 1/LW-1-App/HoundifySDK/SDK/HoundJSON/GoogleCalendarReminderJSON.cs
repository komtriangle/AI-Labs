/* file "GoogleCalendarReminderJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class GoogleCalendarReminderJSON : JSONBase
  {
    public enum Typemethod
      {
        method_email,
        method_popup
      };

    public static Typemethod  stringTomethod(string chars)
      {
        switch (chars[0])
          {
            case 'e':
                if ((String.Compare(chars, 1, "mail", 0, 4, false) == 0) && (chars.Length == 5))
                    return Typemethod.method_email;
                break;
            case 'p':
                if ((String.Compare(chars, 1, "opup", 0, 4, false) == 0) && (chars.Length == 5))
                    return Typemethod.method_popup;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `method' is not one of the legal values.");
      }

    public static string  stringFrommethod(Typemethod the_enum)
      {
        switch (the_enum)
          {
            case Typemethod.method_email:
                return "email";
            case Typemethod.method_popup:
                return "popup";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasmethod;
    private Typemethod storemethod;
    private bool flagHasminutes;
    private BigInteger storeminutes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONmethod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field method of GoogleCalendarReminderJSON is not a string.");
        Typemethod the_enum;
        switch (json_string.getData()[0])
          {
            case 'e':
                if ((String.Compare(json_string.getData(), 1, "mail", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = Typemethod.method_email;
                        goto enum_is_done;
                      }
                break;
            case 'p':
                if ((String.Compare(json_string.getData(), 1, "opup", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = Typemethod.method_popup;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field method of GoogleCalendarReminderJSON is not one of the legal strings.");
      enum_is_done:;
        setmethod(the_enum);
      }


    private void  fromJSONminutes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field minutes of GoogleCalendarReminderJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field minutes of GoogleCalendarReminderJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setminutes(extracted_integer);
      }


    public GoogleCalendarReminderJSON()
      {
        flagHasmethod = false;
        flagHasminutes = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasmethod()
      {
        return flagHasmethod;
      }

    public Typemethod  getmethod()
      {
        Debug.Assert(flagHasmethod);
        return storemethod;
      }

    public string  getmethodAsString()
      {
        return stringFrommethod(getmethod());
      }

    public bool  hasminutes()
      {
        return flagHasminutes;
      }

    public BigInteger  getminutes()
      {
        Debug.Assert(flagHasminutes);
        return storeminutes;
      }


    public virtual int extraGoogleCalendarReminderComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGoogleCalendarReminderComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGoogleCalendarReminderComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGoogleCalendarReminderLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setmethod(Typemethod new_value)
      {
        flagHasmethod = true;
        storemethod = new_value;
      }
    public void setmethod(string chars)
      {
        setmethod(stringTomethod(chars));
      }
    public void unsetmethod()
      {
        flagHasmethod = false;
      }
    public void setminutes(BigInteger new_value)
      {
        flagHasminutes = true;
        storeminutes = new_value;
      }
    public void unsetminutes()
      {
        flagHasminutes = false;
      }

    public virtual void extraGoogleCalendarReminderAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGoogleCalendarReminderSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGoogleCalendarReminderLookup(key);
        if (old_field == null)
          {
            extraGoogleCalendarReminderAppendPair(key, new_component);
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
        if (flagHasmethod)
          {
            handler.start_pair("method");
            switch (storemethod)
              {
                case Typemethod.method_email:
                    handler.string_value("email");
                    break;
                case Typemethod.method_popup:
                    handler.string_value("popup");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasminutes)
          {
            handler.start_pair("minutes");
            handler.number_value(storeminutes);
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

    public static GoogleCalendarReminderJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GoogleCalendarReminderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GoogleCalendarReminder", ignore_extras);
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
    public static GoogleCalendarReminderJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GoogleCalendarReminderJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GoogleCalendarReminderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GoogleCalendarReminder", ignore_extras);
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
    public static GoogleCalendarReminderJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GoogleCalendarReminderJSON from_text(string text, bool ignore_extras)
      {
        GoogleCalendarReminderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GoogleCalendarReminder", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GoogleCalendarReminderJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static GoogleCalendarReminderJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GoogleCalendarReminderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GoogleCalendarReminder", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratormethod : JSONStringGenerator
          {
            protected FieldGeneratormethod(string what)
              {
                set_what(what);
              }
            protected FieldGeneratormethod()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringTomethod(result));
              }
            protected abstract void handle_result(Typemethod result);
          };
    private class FieldHoldingGeneratormethod : FieldGeneratormethod
  {
    protected override void handle_result(Typemethod result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratormethod(String what)
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
    public Typemethod value;
  };
    private class FieldHoldingArrayGeneratormethod : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratormethod
      {
        private FieldHoldingArrayGeneratormethod top;

        protected override void handle_result(Typemethod result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratormethod init_top)
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
    protected virtual void handle_result(List<Typemethod> result)
      {
      }

    public FieldHoldingArrayGeneratormethod(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<Typemethod>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratormethod()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<Typemethod>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<Typemethod> value;
  };
        private FieldHoldingGeneratormethod fieldGeneratormethod;
    private class FieldHoldingGeneratorminutes : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorminutes(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorminutes : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorminutes(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorminutes fieldGeneratorminutes;
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
            GoogleCalendarReminderJSON result = new GoogleCalendarReminderJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGoogleCalendarReminderAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(GoogleCalendarReminderJSON result)
          {
            if (fieldGeneratormethod.have_value)
              {
                result.setmethod(fieldGeneratormethod.value);
                fieldGeneratormethod.have_value = false;
              }
            if (fieldGeneratorminutes.have_value)
              {
                result.setminutes(fieldGeneratorminutes.value);
                fieldGeneratorminutes.have_value = false;
              }
          }
        protected abstract void handle_result(GoogleCalendarReminderJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "m", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'e':
                        if ((String.Compare(field_name, 2, "thod", 0, 4, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratormethod;
                        break;
                    case 'i':
                        if ((String.Compare(field_name, 2, "nutes", 0, 5, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorminutes;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratormethod = new FieldHoldingGeneratormethod("field \"method\" of the GoogleCalendarReminder class");
            fieldGeneratorminutes = new FieldHoldingGeneratorminutes("field \"minutes\" of the GoogleCalendarReminder class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GoogleCalendarReminder class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratormethod = new FieldHoldingGeneratormethod("field \"method\" of the GoogleCalendarReminder class");
            fieldGeneratorminutes = new FieldHoldingGeneratorminutes("field \"minutes\" of the GoogleCalendarReminder class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GoogleCalendarReminder class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratormethod.reset();
            fieldGeneratorminutes.reset();
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
        protected override void handle_result(GoogleCalendarReminderJSON  result)
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
        public GoogleCalendarReminderJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GoogleCalendarReminderJSON  result)
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
    protected virtual void handle_result(List<GoogleCalendarReminderJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GoogleCalendarReminderJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GoogleCalendarReminderJSON>();
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
    public List<GoogleCalendarReminderJSON> value;
  };
  };
