/* file "RandomNumberGeneratorCoinFlipRequestResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RandomNumberGeneratorCoinFlipRequestResultJSON : RandomNumberGeneratorRequestResultJSON
  {
    public enum TypeValues
      {
        Values_Heads,
        Values_Tails
      };

    public static TypeValues  stringToValues(string chars)
      {
        switch (chars[0])
          {
            case 'H':
                if ((String.Compare(chars, 1, "eads", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeValues.Values_Heads;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "ails", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeValues.Values_Tails;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Values' is not one of the legal values.");
      }

    public static string  stringFromValues(TypeValues the_enum)
      {
        switch (the_enum)
          {
            case TypeValues.Values_Heads:
                return "Heads";
            case TypeValues.Values_Tails:
                return "Tails";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeValuesSummaryJSON : JSONBase
      {
        private bool flagHasNumHeads;
        private BigInteger storeNumHeads;
        private bool flagHasNumTails;
        private BigInteger storeNumTails;


        private void  fromJSONNumHeads(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field NumHeads of TypeValuesSummaryJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field NumHeads of TypeValuesSummaryJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setNumHeads(extracted_integer);
          }


        private void  fromJSONNumTails(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field NumTails of TypeValuesSummaryJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field NumTails of TypeValuesSummaryJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setNumTails(extracted_integer);
          }


        public TypeValuesSummaryJSON()
          {
            flagHasNumHeads = false;
            flagHasNumTails = false;
          }

        public bool  hasNumHeads()
          {
            return flagHasNumHeads;
          }

        public BigInteger  getNumHeads()
          {
            Debug.Assert(flagHasNumHeads);
            return storeNumHeads;
          }

        public bool  hasNumTails()
          {
            return flagHasNumTails;
          }

        public BigInteger  getNumTails()
          {
            Debug.Assert(flagHasNumTails);
            return storeNumTails;
          }



        public void setNumHeads(BigInteger new_value)
          {
            flagHasNumHeads = true;
            if (new_value < 1)
                throw new Exception("The value for field NumHeads of TypeValuesSummaryJSON is less than the lower bound (1) for that field.");
            storeNumHeads = new_value;
          }
        public void unsetNumHeads()
          {
            flagHasNumHeads = false;
          }
        public void setNumTails(BigInteger new_value)
          {
            flagHasNumTails = true;
            if (new_value < 1)
                throw new Exception("The value for field NumTails of TypeValuesSummaryJSON is less than the lower bound (1) for that field.");
            storeNumTails = new_value;
          }
        public void unsetNumTails()
          {
            flagHasNumTails = false;
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
            Debug.Assert(partial_allowed || flagHasNumHeads);
            if (flagHasNumHeads)
              {
                handler.start_pair("NumHeads");
                handler.number_value(storeNumHeads);
              }
            Debug.Assert(partial_allowed || flagHasNumTails);
            if (flagHasNumTails)
              {
                handler.start_pair("NumTails");
                handler.number_value(storeNumTails);
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
            if (!(hasNumHeads()))
              {
                return "When parsing the object for %what%, the \"NumHeads\" field was missing.";
              }
            if (!(hasNumTails()))
              {
                return "When parsing the object for %what%, the \"NumTails\" field was missing.";
              }
            return null;
          }

        public static TypeValuesSummaryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeValuesSummaryJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValuesSummary", ignore_extras);
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
        public static TypeValuesSummaryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeValuesSummaryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeValuesSummaryJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValuesSummary", ignore_extras);
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
        public static TypeValuesSummaryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeValuesSummaryJSON from_text(string text, bool ignore_extras)
          {
            TypeValuesSummaryJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValuesSummary", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeValuesSummaryJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeValuesSummaryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeValuesSummaryJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValuesSummary", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorNumHeads : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorNumHeads(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorNumHeads : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorNumHeads(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
            private FieldHoldingGeneratorNumHeads fieldGeneratorNumHeads;
        private class FieldHoldingGeneratorNumTails : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorNumTails(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorNumTails : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorNumTails(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
            private FieldHoldingGeneratorNumTails fieldGeneratorNumTails;

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
                TypeValuesSummaryJSON result = new TypeValuesSummaryJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeValuesSummaryJSON result)
              {
                if (fieldGeneratorNumHeads.have_value)
                  {
                    result.setNumHeads(fieldGeneratorNumHeads.value);
                    fieldGeneratorNumHeads.have_value = false;
                  }
                else if ((!(result.hasNumHeads())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NumHeads\" field was missing.");
                  }
                if (fieldGeneratorNumTails.have_value)
                  {
                    result.setNumTails(fieldGeneratorNumTails.value);
                    fieldGeneratorNumTails.have_value = false;
                  }
                else if ((!(result.hasNumTails())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NumTails\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeValuesSummaryJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "Num", 0, 3, false) == 0)
                  {
                    switch (field_name[3])
                      {
                        case 'H':
                            if ((String.Compare(field_name, 4, "eads", 0, 4, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorNumHeads;
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 4, "ails", 0, 4, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorNumTails;
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorNumHeads = new FieldHoldingGeneratorNumHeads("field \"NumHeads\" of the TypeValuesSummary class");
                fieldGeneratorNumTails = new FieldHoldingGeneratorNumTails("field \"NumTails\" of the TypeValuesSummary class");
                set_what("the TypeValuesSummary class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorNumHeads = new FieldHoldingGeneratorNumHeads("field \"NumHeads\" of the TypeValuesSummary class");
                fieldGeneratorNumTails = new FieldHoldingGeneratorNumTails("field \"NumTails\" of the TypeValuesSummary class");
                set_what("the TypeValuesSummary class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorNumHeads.reset();
                fieldGeneratorNumTails.reset();
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
            protected override void handle_result(TypeValuesSummaryJSON  result)
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
            public TypeValuesSummaryJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeValuesSummaryJSON  result)
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
        protected virtual void handle_result(List<TypeValuesSummaryJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeValuesSummaryJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeValuesSummaryJSON>();
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
        public List<TypeValuesSummaryJSON> value;
      };
      };
    private bool flagHasValues;
    private List< TypeValues > storeValues;
    private bool flagHasFromDiceOrNumbers;
    private bool storeFromDiceOrNumbers;
    private bool flagHasValuesSummary;
    private TypeValuesSummaryJSON  storeValuesSummary;


    private JSONValue  extraValuesToJSON()
      {
        JSONArrayValue generated_array_1_Values = new JSONArrayValue();
        for (int num1 = 0; num1 < storeValues.Count; ++num1)
          {
            JSONStringValue generated_string_Values;
            switch (storeValues[num1])
              {
                case TypeValues.Values_Heads:
                    generated_string_Values = new JSONStringValue("Heads");
                    break;
                case TypeValues.Values_Tails:
                    generated_string_Values = new JSONStringValue("Tails");
                    break;
                default:
                    Debug.Assert(false);
                    generated_string_Values = null;
                    break;
              }
            generated_array_1_Values.appendComponent(generated_string_Values);
          }
        return generated_array_1_Values;
      }

    private JSONValue  extraFromDiceOrNumbersToJSON()
      {
        JSONValue generated_boolean_FromDiceOrNumbers = (storeFromDiceOrNumbers ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_FromDiceOrNumbers;
      }

    private JSONValue  extraValuesSummaryToJSON()
      {
        JSONValueHandler handler_ValuesSummary = new JSONValueHandler();
        storeValuesSummary.write_as_json(handler_ValuesSummary);
        return handler_ValuesSummary.result;
      }


    private void  fromJSONValues(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Values of RandomNumberGeneratorCoinFlipRequestResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Values of RandomNumberGeneratorCoinFlipRequestResultJSON has too few elements.");
        List< TypeValues > vector_Values1 = new List< TypeValues >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Values of RandomNumberGeneratorCoinFlipRequestResultJSON is not a string.");
            TypeValues the_enum;
            switch (json_string.getData()[0])
              {
                case 'H':
                    if ((String.Compare(json_string.getData(), 1, "eads", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeValues.Values_Heads;
                            goto enum_is_done;
                          }
                    break;
                case 'T':
                    if ((String.Compare(json_string.getData(), 1, "ails", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeValues.Values_Tails;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for an element of field Values of RandomNumberGeneratorCoinFlipRequestResultJSON is not one of the legal strings.");
          enum_is_done:;
            vector_Values1.Add(the_enum);
          }
        Debug.Assert(vector_Values1.Count >= 1);
        initValues();
        for (int num1 = 0; num1 < vector_Values1.Count; ++num1)
            appendValues(vector_Values1[num1]);
        for (int num1 = 0; num1 < vector_Values1.Count; ++num1)
          {
          }
      }


    private void  fromJSONFromDiceOrNumbers(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field FromDiceOrNumbers of RandomNumberGeneratorCoinFlipRequestResultJSON is not true for false.");
              }
          }
        setFromDiceOrNumbers(the_bool);
      }


    private void  fromJSONValuesSummary(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeValuesSummaryJSON convert_classy = TypeValuesSummaryJSON.from_json(json_value, ignore_extras, true);
        setValuesSummary(convert_classy);
      }


    public RandomNumberGeneratorCoinFlipRequestResultJSON()
      {
        flagHasValues = false;
        flagHasFromDiceOrNumbers = false;
        flagHasValuesSummary = false;
        storeValues = new List< TypeValues >();
      }

    public override string  getRandomNumberRequestKind()
      {
        return "CoinFlipRequest";
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

    public TypeValues  elementOfValues(int element_num)
      {
        Debug.Assert(flagHasValues);
        return storeValues[element_num];
      }

    public List< TypeValues >  getValues()
      {
        Debug.Assert(flagHasValues);
        return storeValues;
      }

    public bool  hasFromDiceOrNumbers()
      {
        return flagHasFromDiceOrNumbers;
      }

    public bool  getFromDiceOrNumbers()
      {
        Debug.Assert(flagHasFromDiceOrNumbers);
        return storeFromDiceOrNumbers;
      }

    public bool  hasValuesSummary()
      {
        return flagHasValuesSummary;
      }

    public TypeValuesSummaryJSON   getValuesSummary()
      {
        Debug.Assert(flagHasValuesSummary);
        return storeValuesSummary;
      }


    public override int extraRandomNumberGeneratorRequestResultComponentCount()
      {
        int result = 0;
        if (flagHasValues)
            ++result;
        if (flagHasFromDiceOrNumbers)
            ++result;
        if (flagHasValuesSummary)
            ++result;
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
        if (flagHasFromDiceOrNumbers)
          {
            if (remainder == 0)
                return "FromDiceOrNumbers";
            --remainder;
          }
        if (flagHasValuesSummary)
          {
            if (remainder == 0)
                return "ValuesSummary";
            --remainder;
          }
        Debug.Assert(false);
        return null;
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
        if (flagHasFromDiceOrNumbers)
          {
            if (remainder == 0)
                return extraFromDiceOrNumbersToJSON();
            --remainder;
          }
        if (flagHasValuesSummary)
          {
            if (remainder == 0)
                return extraValuesSummaryToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraRandomNumberGeneratorRequestResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'F':
                if ((String.Compare(field_name, 1, "romDiceOrNumbers", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasFromDiceOrNumbers ? extraFromDiceOrNumbersToJSON() : null);
                break;
            case 'V':
                if (String.Compare(field_name, 1, "alues", 0, 5, false) == 0)
                  {
                    if (field_name.Length == 6)
                      {
                        return (flagHasValues ? extraValuesToJSON() : null);
                      }
                    switch (field_name[6])
                      {
                        case 'S':
                            if ((String.Compare(field_name, 7, "ummary", 0, 6, false) == 0) && (field_name.Length == 13))
                                return (flagHasValuesSummary ? extraValuesSummaryToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return null;
      }

    public void initValues()
      {
        flagHasValues = true;
        storeValues.Clear();
      }
    public void appendValues(TypeValues to_append)
      {
        if (!flagHasValues)
          {
            flagHasValues = true;
            storeValues.Clear();
          }
        Debug.Assert(flagHasValues);
        storeValues.Add(to_append);
      }
    public void appendValues(string chars)
      {
        appendValues(stringToValues(chars));
      }
    public void unsetValues()
      {
        flagHasValues = false;
        storeValues.Clear();
      }
    public void setFromDiceOrNumbers(bool new_value)
      {
        flagHasFromDiceOrNumbers = true;
        storeFromDiceOrNumbers = new_value;
      }
    public void unsetFromDiceOrNumbers()
      {
        flagHasFromDiceOrNumbers = false;
      }
    public void setValuesSummary(TypeValuesSummaryJSON  new_value)
      {
        if (flagHasValuesSummary)
          {
          }
        flagHasValuesSummary = true;
        storeValuesSummary = new_value;
      }
    public void unsetValuesSummary()
      {
        if (flagHasValuesSummary)
          {
          }
        flagHasValuesSummary = false;
      }

    public override void extraRandomNumberGeneratorRequestResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'F':
                if ((String.Compare(key, 1, "romDiceOrNumbers", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONFromDiceOrNumbers(new_component, false);
                    return;
                    }
                break;
            case 'V':
                if (String.Compare(key, 1, "alues", 0, 5, false) == 0)
                  {
                    if (key.Length == 6)
                      {
                        {
                        fromJSONValues(new_component, false);
                        return;
                        }
                      }
                    switch (key[6])
                      {
                        case 'S':
                            if ((String.Compare(key, 7, "ummary", 0, 6, false) == 0) && (key.Length == 13))
                                {
                                fromJSONValuesSummary(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
      }
    public override void extraRandomNumberGeneratorRequestResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'F':
                if ((String.Compare(key, 1, "romDiceOrNumbers", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONFromDiceOrNumbers(new_component, false);
                    return;
                    }
                break;
            case 'V':
                if (String.Compare(key, 1, "alues", 0, 5, false) == 0)
                  {
                    if (key.Length == 6)
                      {
                        {
                        fromJSONValues(new_component, false);
                        return;
                        }
                      }
                    switch (key[6])
                      {
                        case 'S':
                            if ((String.Compare(key, 7, "ummary", 0, 6, false) == 0) && (key.Length == 13))
                                {
                                fromJSONValuesSummary(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
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
                switch (storeValues[num1])
                  {
                    case TypeValues.Values_Heads:
                        handler.string_value("Heads");
                        break;
                    case TypeValues.Values_Tails:
                        handler.string_value("Tails");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            handler.finish_array();
          }
        if (flagHasFromDiceOrNumbers)
          {
            handler.start_pair("FromDiceOrNumbers");
            handler.boolean_value(storeFromDiceOrNumbers);
          }
        if (flagHasValuesSummary)
          {
            handler.start_pair("ValuesSummary");
            if (partial_allowed)
                storeValuesSummary.write_partial_as_json(handler);
            else
                storeValuesSummary.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new RandomNumberGeneratorCoinFlipRequestResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RandomNumberGeneratorCoinFlipRequestResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorCoinFlipRequestResult", ignore_extras);
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
    public static new RandomNumberGeneratorCoinFlipRequestResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RandomNumberGeneratorCoinFlipRequestResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RandomNumberGeneratorCoinFlipRequestResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorCoinFlipRequestResult", ignore_extras);
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
    public static new RandomNumberGeneratorCoinFlipRequestResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RandomNumberGeneratorCoinFlipRequestResultJSON from_text(string text, bool ignore_extras)
      {
        RandomNumberGeneratorCoinFlipRequestResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorCoinFlipRequestResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RandomNumberGeneratorCoinFlipRequestResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RandomNumberGeneratorCoinFlipRequestResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RandomNumberGeneratorCoinFlipRequestResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorCoinFlipRequestResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RandomNumberGeneratorRequestResultJSON.Generator
      {
    private abstract class FieldGeneratorValues : JSONStringGenerator
          {
            protected FieldGeneratorValues(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorValues()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToValues(result));
              }
            protected abstract void handle_result(TypeValues result);
          };
    private class FieldHoldingGeneratorValues : FieldGeneratorValues
  {
    protected override void handle_result(TypeValues result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorValues(String what)
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
    public TypeValues value;
  };
    private class FieldHoldingArrayGeneratorValues : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValues
      {
        private FieldHoldingArrayGeneratorValues top;

        protected override void handle_result(TypeValues result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValues init_top)
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
    protected virtual void handle_result(List<TypeValues> result)
      {
      }

    public FieldHoldingArrayGeneratorValues(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValues>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValues()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValues>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValues> value;
  };
        private FieldHoldingArrayGeneratorValues fieldGeneratorValues;
        private JSONHoldingBooleanGenerator fieldGeneratorFromDiceOrNumbers;
        private TypeValuesSummaryJSON.HoldingGenerator fieldGeneratorValuesSummary;

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
            if (!(getRandomNumberGeneratorRequestResultJSONKey().Equals("CoinFlipRequest")))
                throw new Exception("The key field has a value other than `CoinFlipRequest'.");
            RandomNumberGeneratorCoinFlipRequestResultJSON result = new RandomNumberGeneratorCoinFlipRequestResultJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(RandomNumberGeneratorRequestResultJSON new_result)
          {
            handle_result((RandomNumberGeneratorCoinFlipRequestResultJSON )new_result);
          }
        protected void finish(RandomNumberGeneratorCoinFlipRequestResultJSON result)
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
            if (fieldGeneratorFromDiceOrNumbers.have_value)
              {
                result.setFromDiceOrNumbers(fieldGeneratorFromDiceOrNumbers.value);
                fieldGeneratorFromDiceOrNumbers.have_value = false;
              }
            if (fieldGeneratorValuesSummary.have_value)
              {
                result.setValuesSummary(fieldGeneratorValuesSummary.value);
                fieldGeneratorValuesSummary.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(RandomNumberGeneratorCoinFlipRequestResultJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "romDiceOrNumbers", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorFromDiceOrNumbers;
                    break;
                case 'V':
                    if (String.Compare(field_name, 1, "alues", 0, 5, false) == 0)
                      {
                        if (field_name.Length == 6)
                          {
                            return fieldGeneratorValues;
                          }
                        switch (field_name[6])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 7, "ummary", 0, 6, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorValuesSummary;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorValues = new FieldHoldingArrayGeneratorValues("field \"Values\" of the RandomNumberGeneratorCoinFlipRequestResult class");
            fieldGeneratorFromDiceOrNumbers = new JSONHoldingBooleanGenerator("field \"FromDiceOrNumbers\" of the RandomNumberGeneratorCoinFlipRequestResult class");
            fieldGeneratorValuesSummary = new TypeValuesSummaryJSON.HoldingGenerator("field \"ValuesSummary\" of the RandomNumberGeneratorCoinFlipRequestResult class", ignore_extras);
            set_what("the RandomNumberGeneratorCoinFlipRequestResult class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorValues = new FieldHoldingArrayGeneratorValues("field \"Values\" of the RandomNumberGeneratorCoinFlipRequestResult class");
            fieldGeneratorFromDiceOrNumbers = new JSONHoldingBooleanGenerator("field \"FromDiceOrNumbers\" of the RandomNumberGeneratorCoinFlipRequestResult class");
            fieldGeneratorValuesSummary = new TypeValuesSummaryJSON.HoldingGenerator("field \"ValuesSummary\" of the RandomNumberGeneratorCoinFlipRequestResult class", false);
            set_what("the RandomNumberGeneratorCoinFlipRequestResult class");
          }

        public override void reset()
          {
            fieldGeneratorValues.reset();
            fieldGeneratorFromDiceOrNumbers.reset();
            fieldGeneratorValuesSummary.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RandomNumberGeneratorCoinFlipRequestResultJSON  result)
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
        public RandomNumberGeneratorCoinFlipRequestResultJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RandomNumberGeneratorCoinFlipRequestResultJSON  result)
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
    protected virtual void handle_result(List<RandomNumberGeneratorCoinFlipRequestResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RandomNumberGeneratorCoinFlipRequestResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RandomNumberGeneratorCoinFlipRequestResultJSON>();
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
    public List<RandomNumberGeneratorCoinFlipRequestResultJSON> value;
  };
  };
