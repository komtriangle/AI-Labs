/* file "NumberOfVolumeLevelsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class NumberOfVolumeLevelsJSON : JSONBase
  {
    private bool flagHasValue;
    private BigInteger storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Value of NumberOfVolumeLevelsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Value of NumberOfVolumeLevelsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setValue(extracted_integer);
      }


    public NumberOfVolumeLevelsJSON()
      {
        flagHasValue = false;
      }

    public NumberOfVolumeLevelsJSON(BigInteger init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public BigInteger  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }



    public void setValue(BigInteger new_value)
      {
        flagHasValue = true;
        if (new_value < 1)
            throw new Exception("The value for field Value of NumberOfVolumeLevelsJSON is less than the lower bound (1) for that field.");
        storeValue = new_value;
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.number_value(storeValue);
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.number_value(storeValue);
      }

    public static NumberOfVolumeLevelsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NumberOfVolumeLevelsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberOfVolumeLevels", ignore_extras);
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
    public static NumberOfVolumeLevelsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NumberOfVolumeLevelsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NumberOfVolumeLevelsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberOfVolumeLevels", ignore_extras);
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
    public static NumberOfVolumeLevelsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static NumberOfVolumeLevelsJSON from_text(string text, bool ignore_extras)
      {
        NumberOfVolumeLevelsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberOfVolumeLevels", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NumberOfVolumeLevelsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static NumberOfVolumeLevelsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NumberOfVolumeLevelsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberOfVolumeLevels", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public class FieldHoldingGeneratorValue : JSONHoldingIntegerLowerBoundOnlyGenerator
      {
        public FieldHoldingGeneratorValue(String what) : base(what, (BigInteger)(1))
          {
          }
      };
    public class FieldHoldingArrayGeneratorValue : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
      {
        public FieldHoldingArrayGeneratorValue(String what) : base(what, (BigInteger)(1))
          {
          }
      };
    public abstract class Generator : FieldHoldingGeneratorValue
      {
        protected override void handle_result(BigInteger new_value)
          {
            NumberOfVolumeLevelsJSON result = new NumberOfVolumeLevelsJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(NumberOfVolumeLevelsJSON new_result);
        public Generator(bool ignore_extras) : base("Type NumberOfVolumeLevels")
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(NumberOfVolumeLevelsJSON  result)
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
        public NumberOfVolumeLevelsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NumberOfVolumeLevelsJSON  result)
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
    protected virtual void handle_result(List<NumberOfVolumeLevelsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NumberOfVolumeLevelsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NumberOfVolumeLevelsJSON>();
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
    public List<NumberOfVolumeLevelsJSON> value;
  };
  };
