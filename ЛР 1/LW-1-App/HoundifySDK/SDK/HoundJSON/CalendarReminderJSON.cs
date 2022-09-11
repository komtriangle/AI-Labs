/* file "CalendarReminderJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class CalendarReminderJSON : JSONBase
  {
    public enum TypeMethod
      {
        Method_Default,
        Method_Alert,
        Method_Email,
        Method_SMS
      };

    public static TypeMethod  stringToMethod(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "lert", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeMethod.Method_Alert;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "efault", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeMethod.Method_Default;
                break;
            case 'E':
                if ((String.Compare(chars, 1, "mail", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeMethod.Method_Email;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "MS", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeMethod.Method_SMS;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Method' is not one of the legal values.");
      }

    public static string  stringFromMethod(TypeMethod the_enum)
      {
        switch (the_enum)
          {
            case TypeMethod.Method_Default:
                return "Default";
            case TypeMethod.Method_Alert:
                return "Alert";
            case TypeMethod.Method_Email:
                return "Email";
            case TypeMethod.Method_SMS:
                return "SMS";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasMethod;
    private TypeMethod storeMethod;
    private bool flagHasSecondsBeforeStartOfEvent;
    private BigInteger storeSecondsBeforeStartOfEvent;


    private void  fromJSONMethod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Method of CalendarReminderJSON is not a string.");
        TypeMethod the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "lert", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeMethod.Method_Alert;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "efault", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeMethod.Method_Default;
                        goto enum_is_done;
                      }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "mail", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeMethod.Method_Email;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "MS", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_enum = TypeMethod.Method_SMS;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Method of CalendarReminderJSON is not one of the legal strings.");
      enum_is_done:;
        setMethod(the_enum);
      }


    private void  fromJSONSecondsBeforeStartOfEvent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SecondsBeforeStartOfEvent of CalendarReminderJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SecondsBeforeStartOfEvent of CalendarReminderJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSecondsBeforeStartOfEvent(extracted_integer);
      }


    public CalendarReminderJSON()
      {
        flagHasMethod = false;
        flagHasSecondsBeforeStartOfEvent = false;
      }

    public bool  hasMethod()
      {
        return flagHasMethod;
      }

    public TypeMethod  getMethod()
      {
        Debug.Assert(flagHasMethod);
        return storeMethod;
      }

    public string  getMethodAsString()
      {
        return stringFromMethod(getMethod());
      }

    public bool  hasSecondsBeforeStartOfEvent()
      {
        return flagHasSecondsBeforeStartOfEvent;
      }

    public BigInteger  getSecondsBeforeStartOfEvent()
      {
        Debug.Assert(flagHasSecondsBeforeStartOfEvent);
        return storeSecondsBeforeStartOfEvent;
      }



    public void setMethod(TypeMethod new_value)
      {
        flagHasMethod = true;
        storeMethod = new_value;
      }
    public void setMethod(string chars)
      {
        setMethod(stringToMethod(chars));
      }
    public void unsetMethod()
      {
        flagHasMethod = false;
      }
    public void setSecondsBeforeStartOfEvent(BigInteger new_value)
      {
        flagHasSecondsBeforeStartOfEvent = true;
        if (new_value < 0)
            throw new Exception("The value for field SecondsBeforeStartOfEvent of CalendarReminderJSON is less than the lower bound (0) for that field.");
        storeSecondsBeforeStartOfEvent = new_value;
      }
    public void unsetSecondsBeforeStartOfEvent()
      {
        flagHasSecondsBeforeStartOfEvent = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        if (flagHasMethod)
          {
            handler.start_pair("Method");
            switch (storeMethod)
              {
                case TypeMethod.Method_Default:
                    handler.string_value("Default");
                    break;
                case TypeMethod.Method_Alert:
                    handler.string_value("Alert");
                    break;
                case TypeMethod.Method_Email:
                    handler.string_value("Email");
                    break;
                case TypeMethod.Method_SMS:
                    handler.string_value("SMS");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasSecondsBeforeStartOfEvent);
        if (flagHasSecondsBeforeStartOfEvent)
          {
            handler.start_pair("SecondsBeforeStartOfEvent");
            handler.number_value(storeSecondsBeforeStartOfEvent);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasSecondsBeforeStartOfEvent()))
          {
            return "When parsing the object for %what%, the \"SecondsBeforeStartOfEvent\" field was missing.";
          }
        return null;
      }

    public static CalendarReminderJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarReminderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarReminder", ignore_extras);
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
    public static CalendarReminderJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarReminderJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarReminderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarReminder", ignore_extras);
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
    public static CalendarReminderJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CalendarReminderJSON from_text(string text, bool ignore_extras)
      {
        CalendarReminderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarReminder", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarReminderJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CalendarReminderJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarReminderJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarReminder", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorMethod : JSONStringGenerator
          {
            protected FieldGeneratorMethod(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorMethod()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToMethod(result));
              }
            protected abstract void handle_result(TypeMethod result);
          };
    private class FieldHoldingGeneratorMethod : FieldGeneratorMethod
  {
    protected override void handle_result(TypeMethod result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorMethod(String what)
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
    public TypeMethod value;
  };
    private class FieldHoldingArrayGeneratorMethod : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMethod
      {
        private FieldHoldingArrayGeneratorMethod top;

        protected override void handle_result(TypeMethod result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMethod init_top)
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
    protected virtual void handle_result(List<TypeMethod> result)
      {
      }

    public FieldHoldingArrayGeneratorMethod(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMethod>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMethod()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMethod>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMethod> value;
  };
        private FieldHoldingGeneratorMethod fieldGeneratorMethod;
    private class FieldHoldingGeneratorSecondsBeforeStartOfEvent : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSecondsBeforeStartOfEvent(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSecondsBeforeStartOfEvent : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSecondsBeforeStartOfEvent(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSecondsBeforeStartOfEvent fieldGeneratorSecondsBeforeStartOfEvent;

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
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            CalendarReminderJSON result = new CalendarReminderJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(CalendarReminderJSON result)
          {
            if (fieldGeneratorMethod.have_value)
              {
                result.setMethod(fieldGeneratorMethod.value);
                fieldGeneratorMethod.have_value = false;
              }
            if (fieldGeneratorSecondsBeforeStartOfEvent.have_value)
              {
                result.setSecondsBeforeStartOfEvent(fieldGeneratorSecondsBeforeStartOfEvent.value);
                fieldGeneratorSecondsBeforeStartOfEvent.have_value = false;
              }
            else if ((!(result.hasSecondsBeforeStartOfEvent())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SecondsBeforeStartOfEvent\" field was missing.");
              }
          }
        protected abstract void handle_result(CalendarReminderJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'M':
                    if ((String.Compare(field_name, 1, "ethod", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorMethod;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "econdsBeforeStartOfEvent", 0, 24, false) == 0) && (field_name.Length == 25))
                        return fieldGeneratorSecondsBeforeStartOfEvent;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMethod = new FieldHoldingGeneratorMethod("field \"Method\" of the CalendarReminder class");
            fieldGeneratorSecondsBeforeStartOfEvent = new FieldHoldingGeneratorSecondsBeforeStartOfEvent("field \"SecondsBeforeStartOfEvent\" of the CalendarReminder class");
            set_what("the CalendarReminder class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMethod = new FieldHoldingGeneratorMethod("field \"Method\" of the CalendarReminder class");
            fieldGeneratorSecondsBeforeStartOfEvent = new FieldHoldingGeneratorSecondsBeforeStartOfEvent("field \"SecondsBeforeStartOfEvent\" of the CalendarReminder class");
            set_what("the CalendarReminder class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMethod.reset();
            fieldGeneratorSecondsBeforeStartOfEvent.reset();
            base.reset();
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
        protected override void handle_result(CalendarReminderJSON  result)
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
        public CalendarReminderJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarReminderJSON  result)
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
    protected virtual void handle_result(List<CalendarReminderJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarReminderJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarReminderJSON>();
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
    public List<CalendarReminderJSON> value;
  };
  };
