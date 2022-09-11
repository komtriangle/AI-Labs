/* file "FiniteIntegerPlusFractionBuildingNumberJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FiniteIntegerPlusFractionBuildingNumberJSON : BuildingNumberJSON
  {
    private bool flagHasPrimaryNumber;
    private BigInteger storePrimaryNumber;
    private bool flagHasPrimaryDigitCount;
    private BigInteger storePrimaryDigitCount;
    private bool flagHasFractionNumerator;
    private BigInteger storeFractionNumerator;
    private bool flagHasFractionDenominator;
    private BigInteger storeFractionDenominator;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraPrimaryNumberToJSON()
      {
        JSONIntegerValue generated_integer_PrimaryNumber = new JSONIntegerValue(storePrimaryNumber);
        return generated_integer_PrimaryNumber;
      }

    private JSONValue  extraPrimaryDigitCountToJSON()
      {
        JSONIntegerValue generated_integer_PrimaryDigitCount = new JSONIntegerValue(storePrimaryDigitCount);
        return generated_integer_PrimaryDigitCount;
      }

    private JSONValue  extraFractionNumeratorToJSON()
      {
        JSONIntegerValue generated_integer_FractionNumerator = new JSONIntegerValue(storeFractionNumerator);
        return generated_integer_FractionNumerator;
      }

    private JSONValue  extraFractionDenominatorToJSON()
      {
        JSONIntegerValue generated_integer_FractionDenominator = new JSONIntegerValue(storeFractionDenominator);
        return generated_integer_FractionDenominator;
      }


    private void  fromJSONPrimaryNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PrimaryNumber of FiniteIntegerPlusFractionBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PrimaryNumber of FiniteIntegerPlusFractionBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPrimaryNumber(extracted_integer);
      }


    private void  fromJSONPrimaryDigitCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PrimaryDigitCount of FiniteIntegerPlusFractionBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PrimaryDigitCount of FiniteIntegerPlusFractionBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPrimaryDigitCount(extracted_integer);
      }


    private void  fromJSONFractionNumerator(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FractionNumerator of FiniteIntegerPlusFractionBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FractionNumerator of FiniteIntegerPlusFractionBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFractionNumerator(extracted_integer);
      }


    private void  fromJSONFractionDenominator(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FractionDenominator of FiniteIntegerPlusFractionBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FractionDenominator of FiniteIntegerPlusFractionBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFractionDenominator(extracted_integer);
      }


    public FiniteIntegerPlusFractionBuildingNumberJSON()
      {
        flagHasPrimaryNumber = false;
        flagHasPrimaryDigitCount = false;
        flagHasFractionNumerator = false;
        flagHasFractionDenominator = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getKind()
      {
        return "FiniteIntegerPlusFraction";
      }

    public bool  hasPrimaryNumber()
      {
        return flagHasPrimaryNumber;
      }

    public BigInteger  getPrimaryNumber()
      {
        Debug.Assert(flagHasPrimaryNumber);
        return storePrimaryNumber;
      }

    public bool  hasPrimaryDigitCount()
      {
        return flagHasPrimaryDigitCount;
      }

    public BigInteger  getPrimaryDigitCount()
      {
        Debug.Assert(flagHasPrimaryDigitCount);
        return storePrimaryDigitCount;
      }

    public bool  hasFractionNumerator()
      {
        return flagHasFractionNumerator;
      }

    public BigInteger  getFractionNumerator()
      {
        Debug.Assert(flagHasFractionNumerator);
        return storeFractionNumerator;
      }

    public bool  hasFractionDenominator()
      {
        return flagHasFractionDenominator;
      }

    public BigInteger  getFractionDenominator()
      {
        Debug.Assert(flagHasFractionDenominator);
        return storeFractionDenominator;
      }


    public virtual int extraFiniteIntegerPlusFractionBuildingNumberComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFiniteIntegerPlusFractionBuildingNumberComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFiniteIntegerPlusFractionBuildingNumberComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFiniteIntegerPlusFractionBuildingNumberLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraBuildingNumberComponentCount()
      {
        int result = 0;
        if (flagHasPrimaryNumber)
            ++result;
        if (flagHasPrimaryDigitCount)
            ++result;
        if (flagHasFractionNumerator)
            ++result;
        if (flagHasFractionDenominator)
            ++result;
        result += extraFiniteIntegerPlusFractionBuildingNumberComponentCount();
        return result;
      }
    public override string extraBuildingNumberComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasPrimaryNumber)
          {
            if (remainder == 0)
                return "PrimaryNumber";
            --remainder;
          }
        if (flagHasPrimaryDigitCount)
          {
            if (remainder == 0)
                return "PrimaryDigitCount";
            --remainder;
          }
        if (flagHasFractionNumerator)
          {
            if (remainder == 0)
                return "FractionNumerator";
            --remainder;
          }
        if (flagHasFractionDenominator)
          {
            if (remainder == 0)
                return "FractionDenominator";
            --remainder;
          }
        return extraFiniteIntegerPlusFractionBuildingNumberComponentKey(remainder);
      }
    public override JSONValue extraBuildingNumberComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasPrimaryNumber)
          {
            if (remainder == 0)
                return extraPrimaryNumberToJSON();
            --remainder;
          }
        if (flagHasPrimaryDigitCount)
          {
            if (remainder == 0)
                return extraPrimaryDigitCountToJSON();
            --remainder;
          }
        if (flagHasFractionNumerator)
          {
            if (remainder == 0)
                return extraFractionNumeratorToJSON();
            --remainder;
          }
        if (flagHasFractionDenominator)
          {
            if (remainder == 0)
                return extraFractionDenominatorToJSON();
            --remainder;
          }
        return extraFiniteIntegerPlusFractionBuildingNumberComponentValue(remainder);
      }
    public override JSONValue extraBuildingNumberLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'F':
                if (String.Compare(field_name, 1, "raction", 0, 7, false) == 0)
                  {
                    switch (field_name[8])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 9, "enominator", 0, 10, false) == 0) && (field_name.Length == 19))
                                return (flagHasFractionDenominator ? extraFractionDenominatorToJSON() : null);
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 9, "umerator", 0, 8, false) == 0) && (field_name.Length == 17))
                                return (flagHasFractionNumerator ? extraFractionNumeratorToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(field_name, 1, "rimary", 0, 6, false) == 0)
                  {
                    switch (field_name[7])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 8, "igitCount", 0, 9, false) == 0) && (field_name.Length == 17))
                                return (flagHasPrimaryDigitCount ? extraPrimaryDigitCountToJSON() : null);
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 8, "umber", 0, 5, false) == 0) && (field_name.Length == 13))
                                return (flagHasPrimaryNumber ? extraPrimaryNumberToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraFiniteIntegerPlusFractionBuildingNumberLookup(field_name);
      }

    public void setPrimaryNumber(BigInteger new_value)
      {
        flagHasPrimaryNumber = true;
        storePrimaryNumber = new_value;
      }
    public void unsetPrimaryNumber()
      {
        flagHasPrimaryNumber = false;
      }
    public void setPrimaryDigitCount(BigInteger new_value)
      {
        flagHasPrimaryDigitCount = true;
        if (new_value < 1)
            throw new Exception("The value for field PrimaryDigitCount of FiniteIntegerPlusFractionBuildingNumberJSON is less than the lower bound (1) for that field.");
        storePrimaryDigitCount = new_value;
      }
    public void unsetPrimaryDigitCount()
      {
        flagHasPrimaryDigitCount = false;
      }
    public void setFractionNumerator(BigInteger new_value)
      {
        flagHasFractionNumerator = true;
        storeFractionNumerator = new_value;
      }
    public void unsetFractionNumerator()
      {
        flagHasFractionNumerator = false;
      }
    public void setFractionDenominator(BigInteger new_value)
      {
        flagHasFractionDenominator = true;
        if (new_value < 1)
            throw new Exception("The value for field FractionDenominator of FiniteIntegerPlusFractionBuildingNumberJSON is less than the lower bound (1) for that field.");
        storeFractionDenominator = new_value;
      }
    public void unsetFractionDenominator()
      {
        flagHasFractionDenominator = false;
      }

    public virtual void extraFiniteIntegerPlusFractionBuildingNumberAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFiniteIntegerPlusFractionBuildingNumberSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFiniteIntegerPlusFractionBuildingNumberLookup(key);
        if (old_field == null)
          {
            extraFiniteIntegerPlusFractionBuildingNumberAppendPair(key, new_component);
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
    public override void extraBuildingNumberAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'F':
                if (String.Compare(key, 1, "raction", 0, 7, false) == 0)
                  {
                    switch (key[8])
                      {
                        case 'D':
                            if ((String.Compare(key, 9, "enominator", 0, 10, false) == 0) && (key.Length == 19))
                                {
                                fromJSONFractionDenominator(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 9, "umerator", 0, 8, false) == 0) && (key.Length == 17))
                                {
                                fromJSONFractionNumerator(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(key, 1, "rimary", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'D':
                            if ((String.Compare(key, 8, "igitCount", 0, 9, false) == 0) && (key.Length == 17))
                                {
                                fromJSONPrimaryDigitCount(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 8, "umber", 0, 5, false) == 0) && (key.Length == 13))
                                {
                                fromJSONPrimaryNumber(new_component, false);
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
        extraFiniteIntegerPlusFractionBuildingNumberAppendPair(key, new_component);
      }
    public override void extraBuildingNumberSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'F':
                if (String.Compare(key, 1, "raction", 0, 7, false) == 0)
                  {
                    switch (key[8])
                      {
                        case 'D':
                            if ((String.Compare(key, 9, "enominator", 0, 10, false) == 0) && (key.Length == 19))
                                {
                                fromJSONFractionDenominator(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 9, "umerator", 0, 8, false) == 0) && (key.Length == 17))
                                {
                                fromJSONFractionNumerator(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                if (String.Compare(key, 1, "rimary", 0, 6, false) == 0)
                  {
                    switch (key[7])
                      {
                        case 'D':
                            if ((String.Compare(key, 8, "igitCount", 0, 9, false) == 0) && (key.Length == 17))
                                {
                                fromJSONPrimaryDigitCount(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 8, "umber", 0, 5, false) == 0) && (key.Length == 13))
                                {
                                fromJSONPrimaryNumber(new_component, false);
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
        extraFiniteIntegerPlusFractionBuildingNumberSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPrimaryNumber);
        if (flagHasPrimaryNumber)
          {
            handler.start_pair("PrimaryNumber");
            handler.number_value(storePrimaryNumber);
          }
        if (flagHasPrimaryDigitCount)
          {
            handler.start_pair("PrimaryDigitCount");
            handler.number_value(storePrimaryDigitCount);
          }
        Debug.Assert(partial_allowed || flagHasFractionNumerator);
        if (flagHasFractionNumerator)
          {
            handler.start_pair("FractionNumerator");
            handler.number_value(storeFractionNumerator);
          }
        Debug.Assert(partial_allowed || flagHasFractionDenominator);
        if (flagHasFractionDenominator)
          {
            handler.start_pair("FractionDenominator");
            handler.number_value(storeFractionDenominator);
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
        if (!(hasPrimaryNumber()))
          {
            return "When parsing the object for %what%, the \"PrimaryNumber\" field was missing.";
          }
        if (!(hasFractionNumerator()))
          {
            return "When parsing the object for %what%, the \"FractionNumerator\" field was missing.";
          }
        if (!(hasFractionDenominator()))
          {
            return "When parsing the object for %what%, the \"FractionDenominator\" field was missing.";
          }
        return null;
      }

    public static new FiniteIntegerPlusFractionBuildingNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FiniteIntegerPlusFractionBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteIntegerPlusFractionBuildingNumber", ignore_extras);
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
    public static new FiniteIntegerPlusFractionBuildingNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FiniteIntegerPlusFractionBuildingNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FiniteIntegerPlusFractionBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteIntegerPlusFractionBuildingNumber", ignore_extras);
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
    public static new FiniteIntegerPlusFractionBuildingNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FiniteIntegerPlusFractionBuildingNumberJSON from_text(string text, bool ignore_extras)
      {
        FiniteIntegerPlusFractionBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteIntegerPlusFractionBuildingNumber", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FiniteIntegerPlusFractionBuildingNumberJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new FiniteIntegerPlusFractionBuildingNumberJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FiniteIntegerPlusFractionBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteIntegerPlusFractionBuildingNumber", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : BuildingNumberJSON.Generator
      {
    private class FieldHoldingGeneratorPrimaryNumber : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorPrimaryNumber(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPrimaryNumber : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPrimaryNumber(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorPrimaryNumber fieldGeneratorPrimaryNumber;
    private class FieldHoldingGeneratorPrimaryDigitCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorPrimaryDigitCount(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorPrimaryDigitCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorPrimaryDigitCount(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorPrimaryDigitCount fieldGeneratorPrimaryDigitCount;
    private class FieldHoldingGeneratorFractionNumerator : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorFractionNumerator(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorFractionNumerator : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorFractionNumerator(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorFractionNumerator fieldGeneratorFractionNumerator;
    private class FieldHoldingGeneratorFractionDenominator : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorFractionDenominator(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorFractionDenominator : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorFractionDenominator(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorFractionDenominator fieldGeneratorFractionDenominator;
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
            if (!(getBuildingNumberJSONKey().Equals("FiniteIntegerPlusFraction")))
                throw new Exception("The key field has a value other than `FiniteIntegerPlusFraction'.");
            FiniteIntegerPlusFractionBuildingNumberJSON result = new FiniteIntegerPlusFractionBuildingNumberJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFiniteIntegerPlusFractionBuildingNumberAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(BuildingNumberJSON new_result)
          {
            handle_result((FiniteIntegerPlusFractionBuildingNumberJSON )new_result);
          }
        protected void finish(FiniteIntegerPlusFractionBuildingNumberJSON result)
          {
            if (fieldGeneratorPrimaryNumber.have_value)
              {
                result.setPrimaryNumber(fieldGeneratorPrimaryNumber.value);
                fieldGeneratorPrimaryNumber.have_value = false;
              }
            else if ((!(result.hasPrimaryNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PrimaryNumber\" field was missing.");
              }
            if (fieldGeneratorPrimaryDigitCount.have_value)
              {
                result.setPrimaryDigitCount(fieldGeneratorPrimaryDigitCount.value);
                fieldGeneratorPrimaryDigitCount.have_value = false;
              }
            if (fieldGeneratorFractionNumerator.have_value)
              {
                result.setFractionNumerator(fieldGeneratorFractionNumerator.value);
                fieldGeneratorFractionNumerator.have_value = false;
              }
            else if ((!(result.hasFractionNumerator())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FractionNumerator\" field was missing.");
              }
            if (fieldGeneratorFractionDenominator.have_value)
              {
                result.setFractionDenominator(fieldGeneratorFractionDenominator.value);
                fieldGeneratorFractionDenominator.have_value = false;
              }
            else if ((!(result.hasFractionDenominator())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FractionDenominator\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(FiniteIntegerPlusFractionBuildingNumberJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if (String.Compare(field_name, 1, "raction", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "enominator", 0, 10, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorFractionDenominator;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 9, "umerator", 0, 8, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorFractionNumerator;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if (String.Compare(field_name, 1, "rimary", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 8, "igitCount", 0, 9, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorPrimaryDigitCount;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 8, "umber", 0, 5, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorPrimaryNumber;
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
            fieldGeneratorPrimaryNumber = new FieldHoldingGeneratorPrimaryNumber("field \"PrimaryNumber\" of the FiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorPrimaryDigitCount = new FieldHoldingGeneratorPrimaryDigitCount("field \"PrimaryDigitCount\" of the FiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorFractionNumerator = new FieldHoldingGeneratorFractionNumerator("field \"FractionNumerator\" of the FiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorFractionDenominator = new FieldHoldingGeneratorFractionDenominator("field \"FractionDenominator\" of the FiniteIntegerPlusFractionBuildingNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FiniteIntegerPlusFractionBuildingNumber class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorPrimaryNumber = new FieldHoldingGeneratorPrimaryNumber("field \"PrimaryNumber\" of the FiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorPrimaryDigitCount = new FieldHoldingGeneratorPrimaryDigitCount("field \"PrimaryDigitCount\" of the FiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorFractionNumerator = new FieldHoldingGeneratorFractionNumerator("field \"FractionNumerator\" of the FiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorFractionDenominator = new FieldHoldingGeneratorFractionDenominator("field \"FractionDenominator\" of the FiniteIntegerPlusFractionBuildingNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FiniteIntegerPlusFractionBuildingNumber class");
          }

        public override void reset()
          {
            fieldGeneratorPrimaryNumber.reset();
            fieldGeneratorPrimaryDigitCount.reset();
            fieldGeneratorFractionNumerator.reset();
            fieldGeneratorFractionDenominator.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(FiniteIntegerPlusFractionBuildingNumberJSON  result)
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
        public FiniteIntegerPlusFractionBuildingNumberJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FiniteIntegerPlusFractionBuildingNumberJSON  result)
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
    protected virtual void handle_result(List<FiniteIntegerPlusFractionBuildingNumberJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FiniteIntegerPlusFractionBuildingNumberJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FiniteIntegerPlusFractionBuildingNumberJSON>();
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
    public List<FiniteIntegerPlusFractionBuildingNumberJSON> value;
  };
  };
