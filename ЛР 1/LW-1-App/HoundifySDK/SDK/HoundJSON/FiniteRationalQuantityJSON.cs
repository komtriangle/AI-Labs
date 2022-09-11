/* file "FiniteRationalQuantityJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FiniteRationalQuantityJSON : QuantityJSON
  {
    private bool flagHasNumerator;
    private BigInteger storeNumerator;
    private bool flagHasDenominator;
    private BigInteger storeDenominator;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNumeratorToJSON()
      {
        JSONIntegerValue generated_integer_Numerator = new JSONIntegerValue(storeNumerator);
        return generated_integer_Numerator;
      }

    private JSONValue  extraDenominatorToJSON()
      {
        JSONIntegerValue generated_integer_Denominator = new JSONIntegerValue(storeDenominator);
        return generated_integer_Denominator;
      }


    private void  fromJSONNumerator(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Numerator of FiniteRationalQuantityJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Numerator of FiniteRationalQuantityJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumerator(extracted_integer);
      }


    private void  fromJSONDenominator(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Denominator of FiniteRationalQuantityJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Denominator of FiniteRationalQuantityJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDenominator(extracted_integer);
      }


    public FiniteRationalQuantityJSON()
      {
        flagHasNumerator = false;
        flagHasDenominator = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getQuantityKind()
      {
        return "FiniteRational";
      }

    public bool  hasNumerator()
      {
        return flagHasNumerator;
      }

    public BigInteger  getNumerator()
      {
        Debug.Assert(flagHasNumerator);
        return storeNumerator;
      }

    public bool  hasDenominator()
      {
        return flagHasDenominator;
      }

    public BigInteger  getDenominator()
      {
        Debug.Assert(flagHasDenominator);
        return storeDenominator;
      }


    public virtual int extraFiniteRationalQuantityComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFiniteRationalQuantityComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFiniteRationalQuantityComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFiniteRationalQuantityLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraQuantityComponentCount()
      {
        int result = 0;
        if (flagHasNumerator)
            ++result;
        if (flagHasDenominator)
            ++result;
        result += extraFiniteRationalQuantityComponentCount();
        return result;
      }
    public override string extraQuantityComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNumerator)
          {
            if (remainder == 0)
                return "Numerator";
            --remainder;
          }
        if (flagHasDenominator)
          {
            if (remainder == 0)
                return "Denominator";
            --remainder;
          }
        return extraFiniteRationalQuantityComponentKey(remainder);
      }
    public override JSONValue extraQuantityComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNumerator)
          {
            if (remainder == 0)
                return extraNumeratorToJSON();
            --remainder;
          }
        if (flagHasDenominator)
          {
            if (remainder == 0)
                return extraDenominatorToJSON();
            --remainder;
          }
        return extraFiniteRationalQuantityComponentValue(remainder);
      }
    public override JSONValue extraQuantityLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "enominator", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasDenominator ? extraDenominatorToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "umerator", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasNumerator ? extraNumeratorToJSON() : null);
                break;
            default:
                break;
          }
        return extraFiniteRationalQuantityLookup(field_name);
      }

    public void setNumerator(BigInteger new_value)
      {
        flagHasNumerator = true;
        storeNumerator = new_value;
      }
    public void unsetNumerator()
      {
        flagHasNumerator = false;
      }
    public void setDenominator(BigInteger new_value)
      {
        flagHasDenominator = true;
        if (new_value < 1)
            throw new Exception("The value for field Denominator of FiniteRationalQuantityJSON is less than the lower bound (1) for that field.");
        storeDenominator = new_value;
      }
    public void unsetDenominator()
      {
        flagHasDenominator = false;
      }

    public virtual void extraFiniteRationalQuantityAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFiniteRationalQuantitySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFiniteRationalQuantityLookup(key);
        if (old_field == null)
          {
            extraFiniteRationalQuantityAppendPair(key, new_component);
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
    public override void extraQuantityAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "enominator", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONDenominator(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "umerator", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONNumerator(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFiniteRationalQuantityAppendPair(key, new_component);
      }
    public override void extraQuantitySetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "enominator", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONDenominator(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "umerator", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONNumerator(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFiniteRationalQuantitySetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasNumerator);
        if (flagHasNumerator)
          {
            handler.start_pair("Numerator");
            handler.number_value(storeNumerator);
          }
        Debug.Assert(partial_allowed || flagHasDenominator);
        if (flagHasDenominator)
          {
            handler.start_pair("Denominator");
            handler.number_value(storeDenominator);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasNumerator()))
          {
            return "When parsing the object for %what%, the \"Numerator\" field was missing.";
          }
        if (!(hasDenominator()))
          {
            return "When parsing the object for %what%, the \"Denominator\" field was missing.";
          }
        return null;
      }

    public static new FiniteRationalQuantityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FiniteRationalQuantityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteRationalQuantity", ignore_extras);
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
    public static new FiniteRationalQuantityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FiniteRationalQuantityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FiniteRationalQuantityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteRationalQuantity", ignore_extras);
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
    public static new FiniteRationalQuantityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FiniteRationalQuantityJSON from_text(string text, bool ignore_extras)
      {
        FiniteRationalQuantityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteRationalQuantity", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FiniteRationalQuantityJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new FiniteRationalQuantityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FiniteRationalQuantityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteRationalQuantity", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : QuantityJSON.Generator
      {
    private class FieldHoldingGeneratorNumerator : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorNumerator(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumerator : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumerator(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorNumerator fieldGeneratorNumerator;
    private class FieldHoldingGeneratorDenominator : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorDenominator(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorDenominator : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorDenominator(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorDenominator fieldGeneratorDenominator;
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
            if (!(getQuantityJSONKey().Equals("FiniteRational")))
                throw new Exception("The key field has a value other than `FiniteRational'.");
            FiniteRationalQuantityJSON result = new FiniteRationalQuantityJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFiniteRationalQuantityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(QuantityJSON new_result)
          {
            handle_result((FiniteRationalQuantityJSON )new_result);
          }
        protected void finish(FiniteRationalQuantityJSON result)
          {
            if (fieldGeneratorNumerator.have_value)
              {
                result.setNumerator(fieldGeneratorNumerator.value);
                fieldGeneratorNumerator.have_value = false;
              }
            else if ((!(result.hasNumerator())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Numerator\" field was missing.");
              }
            if (fieldGeneratorDenominator.have_value)
              {
                result.setDenominator(fieldGeneratorDenominator.value);
                fieldGeneratorDenominator.have_value = false;
              }
            else if ((!(result.hasDenominator())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Denominator\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(FiniteRationalQuantityJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "enominator", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDenominator;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umerator", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorNumerator;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNumerator = new FieldHoldingGeneratorNumerator("field \"Numerator\" of the FiniteRationalQuantity class");
            fieldGeneratorDenominator = new FieldHoldingGeneratorDenominator("field \"Denominator\" of the FiniteRationalQuantity class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FiniteRationalQuantity class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNumerator = new FieldHoldingGeneratorNumerator("field \"Numerator\" of the FiniteRationalQuantity class");
            fieldGeneratorDenominator = new FieldHoldingGeneratorDenominator("field \"Denominator\" of the FiniteRationalQuantity class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FiniteRationalQuantity class");
          }

        public override void reset()
          {
            fieldGeneratorNumerator.reset();
            fieldGeneratorDenominator.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(FiniteRationalQuantityJSON  result)
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
        public FiniteRationalQuantityJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FiniteRationalQuantityJSON  result)
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
    protected virtual void handle_result(List<FiniteRationalQuantityJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FiniteRationalQuantityJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FiniteRationalQuantityJSON>();
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
    public List<FiniteRationalQuantityJSON> value;
  };
  };
