/* file "UintStringPairJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UintStringPairJSON : JSONBase
  {
    private bool flagHasFirst;
    private BigInteger storeFirst;
    private bool flagHasSecond;
    private string storeSecond;


    private void  fromJSONFirst(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field First of UintStringPairJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field First of UintStringPairJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFirst(extracted_integer);
      }


    private void  fromJSONSecond(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Second of UintStringPairJSON is not a string.");
        setSecond(json_string.getData());
      }


    public UintStringPairJSON()
      {
        flagHasFirst = false;
        flagHasSecond = false;
      }

    public bool  hasFirst()
      {
        return flagHasFirst;
      }

    public BigInteger  getFirst()
      {
        Debug.Assert(flagHasFirst);
        return storeFirst;
      }

    public bool  hasSecond()
      {
        return flagHasSecond;
      }

    public string  getSecond()
      {
        Debug.Assert(flagHasSecond);
        return storeSecond;
      }



    public void setFirst(BigInteger new_value)
      {
        flagHasFirst = true;
        if (new_value < 0)
            throw new Exception("The value for field First of UintStringPairJSON is less than the lower bound (0) for that field.");
        storeFirst = new_value;
      }
    public void unsetFirst()
      {
        flagHasFirst = false;
      }
    public void setSecond(string new_value)
      {
        flagHasSecond = true;
        storeSecond = new_value;
      }
    public void unsetSecond()
      {
        flagHasSecond = false;
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
        Debug.Assert(partial_allowed || flagHasFirst);
        if (flagHasFirst)
          {
            handler.start_pair("First");
            handler.number_value(storeFirst);
          }
        Debug.Assert(partial_allowed || flagHasSecond);
        if (flagHasSecond)
          {
            handler.start_pair("Second");
            handler.string_value(storeSecond);
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
        if (!(hasFirst()))
          {
            return "When parsing the object for %what%, the \"First\" field was missing.";
          }
        if (!(hasSecond()))
          {
            return "When parsing the object for %what%, the \"Second\" field was missing.";
          }
        return null;
      }

    public static UintStringPairJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UintStringPairJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UintStringPair", ignore_extras);
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
    public static UintStringPairJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UintStringPairJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UintStringPairJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UintStringPair", ignore_extras);
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
    public static UintStringPairJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UintStringPairJSON from_text(string text, bool ignore_extras)
      {
        UintStringPairJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UintStringPair", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UintStringPairJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UintStringPairJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UintStringPairJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UintStringPair", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorFirst : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorFirst(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorFirst : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorFirst(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorFirst fieldGeneratorFirst;
        private JSONHoldingStringGenerator fieldGeneratorSecond;

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
            UintStringPairJSON result = new UintStringPairJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(UintStringPairJSON result)
          {
            if (fieldGeneratorFirst.have_value)
              {
                result.setFirst(fieldGeneratorFirst.value);
                fieldGeneratorFirst.have_value = false;
              }
            else if ((!(result.hasFirst())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"First\" field was missing.");
              }
            if (fieldGeneratorSecond.have_value)
              {
                result.setSecond(fieldGeneratorSecond.value);
                fieldGeneratorSecond.have_value = false;
              }
            else if ((!(result.hasSecond())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Second\" field was missing.");
              }
          }
        protected abstract void handle_result(UintStringPairJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "irst", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorFirst;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "econd", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorSecond;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFirst = new FieldHoldingGeneratorFirst("field \"First\" of the UintStringPair class");
            fieldGeneratorSecond = new JSONHoldingStringGenerator("field \"Second\" of the UintStringPair class");
            set_what("the UintStringPair class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFirst = new FieldHoldingGeneratorFirst("field \"First\" of the UintStringPair class");
            fieldGeneratorSecond = new JSONHoldingStringGenerator("field \"Second\" of the UintStringPair class");
            set_what("the UintStringPair class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFirst.reset();
            fieldGeneratorSecond.reset();
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
        protected override void handle_result(UintStringPairJSON  result)
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
        public UintStringPairJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UintStringPairJSON  result)
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
    protected virtual void handle_result(List<UintStringPairJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UintStringPairJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UintStringPairJSON>();
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
    public List<UintStringPairJSON> value;
  };
  };
