/* file "LocalResultBusinessHoursJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class LocalResultBusinessHoursJSON : JSONBase
  {
    private bool flagHasStartTime;
    private int storeStartTime;
    private bool flagHasEndTime;
    private int storeEndTime;


    private void  fromJSONStartTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        int extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StartTime of LocalResultBusinessHoursJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StartTime of LocalResultBusinessHoursJSON is not an integer.");
              }
            extracted_integer = (int)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (int)(json_integer.getLongInt())        ;
          }
        setStartTime(extracted_integer);
      }


    private void  fromJSONEndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        int extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field EndTime of LocalResultBusinessHoursJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field EndTime of LocalResultBusinessHoursJSON is not an integer.");
              }
            extracted_integer = (int)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (int)(json_integer.getLongInt())        ;
          }
        setEndTime(extracted_integer);
      }


    public LocalResultBusinessHoursJSON()
      {
        flagHasStartTime = false;
        flagHasEndTime = false;
      }

    public bool  hasStartTime()
      {
        return flagHasStartTime;
      }

    public int  getStartTime()
      {
        Debug.Assert(flagHasStartTime);
        return storeStartTime;
      }

    public bool  hasEndTime()
      {
        return flagHasEndTime;
      }

    public int  getEndTime()
      {
        Debug.Assert(flagHasEndTime);
        return storeEndTime;
      }



    public void setStartTime(int new_value)
      {
        flagHasStartTime = true;
        if (new_value < 0)
            throw new Exception("The value for field StartTime of LocalResultBusinessHoursJSON is less than the lower bound (0) for that field.");
        if (new_value > 86400)
            throw new Exception("The value for field StartTime of LocalResultBusinessHoursJSON is greater than the upper bound (86400) for that field.");
        storeStartTime = new_value;
      }
    public void unsetStartTime()
      {
        flagHasStartTime = false;
      }
    public void setEndTime(int new_value)
      {
        flagHasEndTime = true;
        if (new_value < 0)
            throw new Exception("The value for field EndTime of LocalResultBusinessHoursJSON is less than the lower bound (0) for that field.");
        if (new_value > 86400)
            throw new Exception("The value for field EndTime of LocalResultBusinessHoursJSON is greater than the upper bound (86400) for that field.");
        storeEndTime = new_value;
      }
    public void unsetEndTime()
      {
        flagHasEndTime = false;
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
        if (flagHasStartTime)
          {
            handler.start_pair("StartTime");
            handler.number_value(storeStartTime);
          }
        if (flagHasEndTime)
          {
            handler.start_pair("EndTime");
            handler.number_value(storeEndTime);
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
        return null;
      }

    public static LocalResultBusinessHoursJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalResultBusinessHoursJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalResultBusinessHours", ignore_extras);
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
    public static LocalResultBusinessHoursJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocalResultBusinessHoursJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalResultBusinessHoursJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalResultBusinessHours", ignore_extras);
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
    public static LocalResultBusinessHoursJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocalResultBusinessHoursJSON from_text(string text, bool ignore_extras)
      {
        LocalResultBusinessHoursJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalResultBusinessHours", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LocalResultBusinessHoursJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static LocalResultBusinessHoursJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LocalResultBusinessHoursJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalResultBusinessHours", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorStartTime : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorStartTime(String what) : base(what, 0, 86400)
              {
              }
          };
    private class FieldHoldingArrayGeneratorStartTime : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorStartTime(String what) : base(what, 0, 86400)
              {
              }
          };
        private FieldHoldingGeneratorStartTime fieldGeneratorStartTime;
    private class FieldHoldingGeneratorEndTime : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorEndTime(String what) : base(what, 0, 86400)
              {
              }
          };
    private class FieldHoldingArrayGeneratorEndTime : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorEndTime(String what) : base(what, 0, 86400)
              {
              }
          };
        private FieldHoldingGeneratorEndTime fieldGeneratorEndTime;

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
            LocalResultBusinessHoursJSON result = new LocalResultBusinessHoursJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(LocalResultBusinessHoursJSON result)
          {
            if (fieldGeneratorStartTime.have_value)
              {
                result.setStartTime((int)(fieldGeneratorStartTime.value));
                fieldGeneratorStartTime.have_value = false;
              }
            if (fieldGeneratorEndTime.have_value)
              {
                result.setEndTime((int)(fieldGeneratorEndTime.value));
                fieldGeneratorEndTime.have_value = false;
              }
          }
        protected abstract void handle_result(LocalResultBusinessHoursJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "ndTime", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorEndTime;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tartTime", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorStartTime;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStartTime = new FieldHoldingGeneratorStartTime("field \"StartTime\" of the LocalResultBusinessHours class");
            fieldGeneratorEndTime = new FieldHoldingGeneratorEndTime("field \"EndTime\" of the LocalResultBusinessHours class");
            set_what("the LocalResultBusinessHours class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStartTime = new FieldHoldingGeneratorStartTime("field \"StartTime\" of the LocalResultBusinessHours class");
            fieldGeneratorEndTime = new FieldHoldingGeneratorEndTime("field \"EndTime\" of the LocalResultBusinessHours class");
            set_what("the LocalResultBusinessHours class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStartTime.reset();
            fieldGeneratorEndTime.reset();
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
        protected override void handle_result(LocalResultBusinessHoursJSON  result)
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
        public LocalResultBusinessHoursJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LocalResultBusinessHoursJSON  result)
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
    protected virtual void handle_result(List<LocalResultBusinessHoursJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LocalResultBusinessHoursJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LocalResultBusinessHoursJSON>();
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
    public List<LocalResultBusinessHoursJSON> value;
  };
  };
