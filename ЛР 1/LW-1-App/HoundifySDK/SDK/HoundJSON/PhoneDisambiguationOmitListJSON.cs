/* file "PhoneDisambiguationOmitListJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class PhoneDisambiguationOmitListJSON : JSONBase
  {
    private bool flagHasValue;
    private List< BigInteger > storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Value of PhoneDisambiguationOmitListJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_Value1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field Value of PhoneDisambiguationOmitListJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field Value of PhoneDisambiguationOmitListJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_Value1.Add(extracted_integer);
          }
        initValue();
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
            appendValue(vector_Value1[num1]);
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
          {
          }
      }


    public PhoneDisambiguationOmitListJSON()
      {
        flagHasValue = false;
        storeValue = new List< BigInteger >();
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public int  countOfValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue.Count;
      }

    public BigInteger  elementOfValue(int element_num)
      {
        Debug.Assert(flagHasValue);
        return storeValue[element_num];
      }

    public List< BigInteger >  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }



    public void initValue()
      {
        flagHasValue = true;
        storeValue.Clear();
      }
    public void appendValue(BigInteger to_append)
      {
        if (!flagHasValue)
          {
            flagHasValue = true;
            storeValue.Clear();
          }
        Debug.Assert(flagHasValue);
        storeValue.Add(to_append);
      }
    public void unsetValue()
      {
        flagHasValue = false;
        storeValue.Clear();
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num1 = 0; num1 < storeValue.Count; ++num1)
          {
            handler.number_value(storeValue[num1]);
          }
        handler.finish_array();
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num2 = 0; num2 < storeValue.Count; ++num2)
          {
            handler.number_value(storeValue[num2]);
          }
        handler.finish_array();
      }

    public static PhoneDisambiguationOmitListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PhoneDisambiguationOmitListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PhoneDisambiguationOmitList", ignore_extras);
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
    public static PhoneDisambiguationOmitListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PhoneDisambiguationOmitListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PhoneDisambiguationOmitListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PhoneDisambiguationOmitList", ignore_extras);
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
    public static PhoneDisambiguationOmitListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PhoneDisambiguationOmitListJSON from_text(string text, bool ignore_extras)
      {
        PhoneDisambiguationOmitListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PhoneDisambiguationOmitList", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PhoneDisambiguationOmitListJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PhoneDisambiguationOmitListJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PhoneDisambiguationOmitListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PhoneDisambiguationOmitList", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public class FieldHoldingGeneratorValue : JSONHoldingIntegerLowerBoundOnlyGenerator
      {
        public FieldHoldingGeneratorValue(String what) : base(what, (BigInteger)(0))
          {
          }
      };
    public class FieldHoldingArrayGeneratorValue : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
      {
        public FieldHoldingArrayGeneratorValue(String what) : base(what, (BigInteger)(0))
          {
          }
      };
    public abstract class Generator : FieldHoldingArrayGeneratorValue
      {
        protected void finish()
          {
            Debug.Assert(have_value);
            PhoneDisambiguationOmitListJSON result = new PhoneDisambiguationOmitListJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(PhoneDisambiguationOmitListJSON new_result);
        public Generator(bool ignore_extras) : base("Type PhoneDisambiguationOmitList")
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
        protected override void handle_result(PhoneDisambiguationOmitListJSON  result)
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
        public PhoneDisambiguationOmitListJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PhoneDisambiguationOmitListJSON  result)
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
    protected virtual void handle_result(List<PhoneDisambiguationOmitListJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PhoneDisambiguationOmitListJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PhoneDisambiguationOmitListJSON>();
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
    public List<PhoneDisambiguationOmitListJSON> value;
  };
  };
