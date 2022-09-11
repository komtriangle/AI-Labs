/* file "RandomNumberGeneratorDiceRollRequestResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RandomNumberGeneratorDiceRollRequestResultJSON : RandomNumberGeneratorRequestResultJSON
  {
    private bool flagHasValues;
    private List< BigInteger > storeValues;
    private bool flagHasNumFaces;
    private BigInteger storeNumFaces;
    private bool flagHasIsDnDStyle;
    private bool storeIsDnDStyle;
    private bool flagHasTotal;
    private BigInteger storeTotal;
    private bool flagHasModifier;
    private BigInteger storeModifier;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraValuesToJSON()
      {
        JSONArrayValue generated_array_1_Values = new JSONArrayValue();
        for (int num1 = 0; num1 < storeValues.Count; ++num1)
          {
            JSONIntegerValue generated_integer_Values = new JSONIntegerValue(storeValues[num1]);
            generated_array_1_Values.appendComponent(generated_integer_Values);
          }
        return generated_array_1_Values;
      }

    private JSONValue  extraNumFacesToJSON()
      {
        JSONIntegerValue generated_integer_NumFaces = new JSONIntegerValue(storeNumFaces);
        return generated_integer_NumFaces;
      }

    private JSONValue  extraIsDnDStyleToJSON()
      {
        JSONValue generated_boolean_IsDnDStyle = (storeIsDnDStyle ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsDnDStyle;
      }

    private JSONValue  extraTotalToJSON()
      {
        JSONIntegerValue generated_integer_Total = new JSONIntegerValue(storeTotal);
        return generated_integer_Total;
      }

    private JSONValue  extraModifierToJSON()
      {
        JSONIntegerValue generated_integer_Modifier = new JSONIntegerValue(storeModifier);
        return generated_integer_Modifier;
      }


    private void  fromJSONValues(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Values of RandomNumberGeneratorDiceRollRequestResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Values of RandomNumberGeneratorDiceRollRequestResultJSON has too few elements.");
        List< BigInteger > vector_Values1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field Values of RandomNumberGeneratorDiceRollRequestResultJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field Values of RandomNumberGeneratorDiceRollRequestResultJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_Values1.Add(extracted_integer);
          }
        Debug.Assert(vector_Values1.Count >= 1);
        initValues();
        for (int num1 = 0; num1 < vector_Values1.Count; ++num1)
            appendValues(vector_Values1[num1]);
        for (int num1 = 0; num1 < vector_Values1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNumFaces(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NumFaces of RandomNumberGeneratorDiceRollRequestResultJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumFaces of RandomNumberGeneratorDiceRollRequestResultJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumFaces(extracted_integer);
      }


    private void  fromJSONIsDnDStyle(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsDnDStyle of RandomNumberGeneratorDiceRollRequestResultJSON is not true for false.");
              }
          }
        setIsDnDStyle(the_bool);
      }


    private void  fromJSONTotal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Total of RandomNumberGeneratorDiceRollRequestResultJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Total of RandomNumberGeneratorDiceRollRequestResultJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTotal(extracted_integer);
      }


    private void  fromJSONModifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Modifier of RandomNumberGeneratorDiceRollRequestResultJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Modifier of RandomNumberGeneratorDiceRollRequestResultJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setModifier(extracted_integer);
      }


    public RandomNumberGeneratorDiceRollRequestResultJSON()
      {
        flagHasValues = false;
        flagHasNumFaces = false;
        flagHasIsDnDStyle = false;
        flagHasTotal = false;
        flagHasModifier = false;
        storeValues = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRandomNumberRequestKind()
      {
        return "DiceRollRequest";
      }

    public bool  hasValues()
      {
        return flagHasValues;
      }

    public int  countOfValues()
      {
        Debug.Assert(flagHasValues);
        return storeValues.Count;
      }

    public BigInteger  elementOfValues(int element_num)
      {
        Debug.Assert(flagHasValues);
        return storeValues[element_num];
      }

    public List< BigInteger >  getValues()
      {
        Debug.Assert(flagHasValues);
        return storeValues;
      }

    public bool  hasNumFaces()
      {
        return flagHasNumFaces;
      }

    public BigInteger  getNumFaces()
      {
        Debug.Assert(flagHasNumFaces);
        return storeNumFaces;
      }

    public bool  hasIsDnDStyle()
      {
        return flagHasIsDnDStyle;
      }

    public bool  getIsDnDStyle()
      {
        Debug.Assert(flagHasIsDnDStyle);
        return storeIsDnDStyle;
      }

    public bool  hasTotal()
      {
        return flagHasTotal;
      }

    public BigInteger  getTotal()
      {
        Debug.Assert(flagHasTotal);
        return storeTotal;
      }

    public bool  hasModifier()
      {
        return flagHasModifier;
      }

    public BigInteger  getModifier()
      {
        Debug.Assert(flagHasModifier);
        return storeModifier;
      }


    public virtual int extraRandomNumberGeneratorDiceRollRequestResultComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRandomNumberGeneratorDiceRollRequestResultComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRandomNumberGeneratorDiceRollRequestResultComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRandomNumberGeneratorDiceRollRequestResultLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRandomNumberGeneratorRequestResultComponentCount()
      {
        int result = 0;
        if (flagHasValues)
            ++result;
        if (flagHasNumFaces)
            ++result;
        if (flagHasIsDnDStyle)
            ++result;
        if (flagHasTotal)
            ++result;
        if (flagHasModifier)
            ++result;
        result += extraRandomNumberGeneratorDiceRollRequestResultComponentCount();
        return result;
      }
    public override string extraRandomNumberGeneratorRequestResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasValues)
          {
            if (remainder == 0)
                return "Values";
            --remainder;
          }
        if (flagHasNumFaces)
          {
            if (remainder == 0)
                return "NumFaces";
            --remainder;
          }
        if (flagHasIsDnDStyle)
          {
            if (remainder == 0)
                return "IsDnDStyle";
            --remainder;
          }
        if (flagHasTotal)
          {
            if (remainder == 0)
                return "Total";
            --remainder;
          }
        if (flagHasModifier)
          {
            if (remainder == 0)
                return "Modifier";
            --remainder;
          }
        return extraRandomNumberGeneratorDiceRollRequestResultComponentKey(remainder);
      }
    public override JSONValue extraRandomNumberGeneratorRequestResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasValues)
          {
            if (remainder == 0)
                return extraValuesToJSON();
            --remainder;
          }
        if (flagHasNumFaces)
          {
            if (remainder == 0)
                return extraNumFacesToJSON();
            --remainder;
          }
        if (flagHasIsDnDStyle)
          {
            if (remainder == 0)
                return extraIsDnDStyleToJSON();
            --remainder;
          }
        if (flagHasTotal)
          {
            if (remainder == 0)
                return extraTotalToJSON();
            --remainder;
          }
        if (flagHasModifier)
          {
            if (remainder == 0)
                return extraModifierToJSON();
            --remainder;
          }
        return extraRandomNumberGeneratorDiceRollRequestResultComponentValue(remainder);
      }
    public override JSONValue extraRandomNumberGeneratorRequestResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'I':
                if ((String.Compare(field_name, 1, "sDnDStyle", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasIsDnDStyle ? extraIsDnDStyleToJSON() : null);
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "odifier", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasModifier ? extraModifierToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "umFaces", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasNumFaces ? extraNumFacesToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "otal", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasTotal ? extraTotalToJSON() : null);
                break;
            case 'V':
                if ((String.Compare(field_name, 1, "alues", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasValues ? extraValuesToJSON() : null);
                break;
            default:
                break;
          }
        return extraRandomNumberGeneratorDiceRollRequestResultLookup(field_name);
      }

    public void initValues()
      {
        flagHasValues = true;
        storeValues.Clear();
      }
    public void appendValues(BigInteger to_append)
      {
        if (!flagHasValues)
          {
            flagHasValues = true;
            storeValues.Clear();
          }
        Debug.Assert(flagHasValues);
        storeValues.Add(to_append);
      }
    public void unsetValues()
      {
        flagHasValues = false;
        storeValues.Clear();
      }
    public void setNumFaces(BigInteger new_value)
      {
        flagHasNumFaces = true;
        if (new_value < 2)
            throw new Exception("The value for field NumFaces of RandomNumberGeneratorDiceRollRequestResultJSON is less than the lower bound (2) for that field.");
        storeNumFaces = new_value;
      }
    public void unsetNumFaces()
      {
        flagHasNumFaces = false;
      }
    public void setIsDnDStyle(bool new_value)
      {
        flagHasIsDnDStyle = true;
        storeIsDnDStyle = new_value;
      }
    public void unsetIsDnDStyle()
      {
        flagHasIsDnDStyle = false;
      }
    public void setTotal(BigInteger new_value)
      {
        flagHasTotal = true;
        storeTotal = new_value;
      }
    public void unsetTotal()
      {
        flagHasTotal = false;
      }
    public void setModifier(BigInteger new_value)
      {
        flagHasModifier = true;
        storeModifier = new_value;
      }
    public void unsetModifier()
      {
        flagHasModifier = false;
      }

    public virtual void extraRandomNumberGeneratorDiceRollRequestResultAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRandomNumberGeneratorDiceRollRequestResultSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRandomNumberGeneratorDiceRollRequestResultLookup(key);
        if (old_field == null)
          {
            extraRandomNumberGeneratorDiceRollRequestResultAppendPair(key, new_component);
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
    public override void extraRandomNumberGeneratorRequestResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "sDnDStyle", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONIsDnDStyle(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "odifier", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONModifier(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "umFaces", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONNumFaces(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "otal", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONTotal(new_component, false);
                    return;
                    }
                break;
            case 'V':
                if ((String.Compare(key, 1, "alues", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONValues(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRandomNumberGeneratorDiceRollRequestResultAppendPair(key, new_component);
      }
    public override void extraRandomNumberGeneratorRequestResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'I':
                if ((String.Compare(key, 1, "sDnDStyle", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONIsDnDStyle(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "odifier", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONModifier(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "umFaces", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONNumFaces(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "otal", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONTotal(new_component, false);
                    return;
                    }
                break;
            case 'V':
                if ((String.Compare(key, 1, "alues", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONValues(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRandomNumberGeneratorDiceRollRequestResultSetField(key, new_component);
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
        if (flagHasValues)
          {
            handler.start_pair("Values");
            Debug.Assert(storeValues.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeValues.Count; ++num1)
              {
                handler.number_value(storeValues[num1]);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasNumFaces);
        if (flagHasNumFaces)
          {
            handler.start_pair("NumFaces");
            handler.number_value(storeNumFaces);
          }
        Debug.Assert(partial_allowed || flagHasIsDnDStyle);
        if (flagHasIsDnDStyle)
          {
            handler.start_pair("IsDnDStyle");
            handler.boolean_value(storeIsDnDStyle);
          }
        if (flagHasTotal)
          {
            handler.start_pair("Total");
            handler.number_value(storeTotal);
          }
        if (flagHasModifier)
          {
            handler.start_pair("Modifier");
            handler.number_value(storeModifier);
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
        if (!(hasNumFaces()))
          {
            return "When parsing the object for %what%, the \"NumFaces\" field was missing.";
          }
        if (!(hasIsDnDStyle()))
          {
            return "When parsing the object for %what%, the \"IsDnDStyle\" field was missing.";
          }
        return null;
      }

    public static new RandomNumberGeneratorDiceRollRequestResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RandomNumberGeneratorDiceRollRequestResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorDiceRollRequestResult", ignore_extras);
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
    public static new RandomNumberGeneratorDiceRollRequestResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RandomNumberGeneratorDiceRollRequestResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RandomNumberGeneratorDiceRollRequestResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorDiceRollRequestResult", ignore_extras);
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
    public static new RandomNumberGeneratorDiceRollRequestResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RandomNumberGeneratorDiceRollRequestResultJSON from_text(string text, bool ignore_extras)
      {
        RandomNumberGeneratorDiceRollRequestResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorDiceRollRequestResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RandomNumberGeneratorDiceRollRequestResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RandomNumberGeneratorDiceRollRequestResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RandomNumberGeneratorDiceRollRequestResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorDiceRollRequestResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RandomNumberGeneratorRequestResultJSON.Generator
      {
    private class FieldHoldingGeneratorValues : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorValues(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorValues : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorValues(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingArrayGeneratorValues fieldGeneratorValues;
    private class FieldHoldingGeneratorNumFaces : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNumFaces(String what) : base(what, (BigInteger)(2))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumFaces : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumFaces(String what) : base(what, (BigInteger)(2))
              {
              }
          };
        private FieldHoldingGeneratorNumFaces fieldGeneratorNumFaces;
        private JSONHoldingBooleanGenerator fieldGeneratorIsDnDStyle;
    private class FieldHoldingGeneratorTotal : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorTotal(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorTotal : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorTotal(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorTotal fieldGeneratorTotal;
    private class FieldHoldingGeneratorModifier : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorModifier(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorModifier : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorModifier(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorModifier fieldGeneratorModifier;
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
            if (!(getRandomNumberGeneratorRequestResultJSONKey().Equals("DiceRollRequest")))
                throw new Exception("The key field has a value other than `DiceRollRequest'.");
            RandomNumberGeneratorDiceRollRequestResultJSON result = new RandomNumberGeneratorDiceRollRequestResultJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRandomNumberGeneratorDiceRollRequestResultAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RandomNumberGeneratorRequestResultJSON new_result)
          {
            handle_result((RandomNumberGeneratorDiceRollRequestResultJSON )new_result);
          }
        protected void finish(RandomNumberGeneratorDiceRollRequestResultJSON result)
          {
            if (fieldGeneratorValues.have_value)
              {
                result.initValues();
                int count = fieldGeneratorValues.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendValues(fieldGeneratorValues.value[num]);
                  }
                fieldGeneratorValues.value.Clear();
                fieldGeneratorValues.have_value = false;
              }
            if (fieldGeneratorNumFaces.have_value)
              {
                result.setNumFaces(fieldGeneratorNumFaces.value);
                fieldGeneratorNumFaces.have_value = false;
              }
            else if ((!(result.hasNumFaces())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NumFaces\" field was missing.");
              }
            if (fieldGeneratorIsDnDStyle.have_value)
              {
                result.setIsDnDStyle(fieldGeneratorIsDnDStyle.value);
                fieldGeneratorIsDnDStyle.have_value = false;
              }
            else if ((!(result.hasIsDnDStyle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsDnDStyle\" field was missing.");
              }
            if (fieldGeneratorTotal.have_value)
              {
                result.setTotal(fieldGeneratorTotal.value);
                fieldGeneratorTotal.have_value = false;
              }
            if (fieldGeneratorModifier.have_value)
              {
                result.setModifier(fieldGeneratorModifier.value);
                fieldGeneratorModifier.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(RandomNumberGeneratorDiceRollRequestResultJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "sDnDStyle", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorIsDnDStyle;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "odifier", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorModifier;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umFaces", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorNumFaces;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "otal", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTotal;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "alues", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorValues;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorValues = new FieldHoldingArrayGeneratorValues("field \"Values\" of the RandomNumberGeneratorDiceRollRequestResult class");
            fieldGeneratorNumFaces = new FieldHoldingGeneratorNumFaces("field \"NumFaces\" of the RandomNumberGeneratorDiceRollRequestResult class");
            fieldGeneratorIsDnDStyle = new JSONHoldingBooleanGenerator("field \"IsDnDStyle\" of the RandomNumberGeneratorDiceRollRequestResult class");
            fieldGeneratorTotal = new FieldHoldingGeneratorTotal("field \"Total\" of the RandomNumberGeneratorDiceRollRequestResult class");
            fieldGeneratorModifier = new FieldHoldingGeneratorModifier("field \"Modifier\" of the RandomNumberGeneratorDiceRollRequestResult class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RandomNumberGeneratorDiceRollRequestResult class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorValues = new FieldHoldingArrayGeneratorValues("field \"Values\" of the RandomNumberGeneratorDiceRollRequestResult class");
            fieldGeneratorNumFaces = new FieldHoldingGeneratorNumFaces("field \"NumFaces\" of the RandomNumberGeneratorDiceRollRequestResult class");
            fieldGeneratorIsDnDStyle = new JSONHoldingBooleanGenerator("field \"IsDnDStyle\" of the RandomNumberGeneratorDiceRollRequestResult class");
            fieldGeneratorTotal = new FieldHoldingGeneratorTotal("field \"Total\" of the RandomNumberGeneratorDiceRollRequestResult class");
            fieldGeneratorModifier = new FieldHoldingGeneratorModifier("field \"Modifier\" of the RandomNumberGeneratorDiceRollRequestResult class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RandomNumberGeneratorDiceRollRequestResult class");
          }

        public override void reset()
          {
            fieldGeneratorValues.reset();
            fieldGeneratorNumFaces.reset();
            fieldGeneratorIsDnDStyle.reset();
            fieldGeneratorTotal.reset();
            fieldGeneratorModifier.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RandomNumberGeneratorDiceRollRequestResultJSON  result)
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
        public RandomNumberGeneratorDiceRollRequestResultJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RandomNumberGeneratorDiceRollRequestResultJSON  result)
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
    protected virtual void handle_result(List<RandomNumberGeneratorDiceRollRequestResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RandomNumberGeneratorDiceRollRequestResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RandomNumberGeneratorDiceRollRequestResultJSON>();
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
    public List<RandomNumberGeneratorDiceRollRequestResultJSON> value;
  };
  };
