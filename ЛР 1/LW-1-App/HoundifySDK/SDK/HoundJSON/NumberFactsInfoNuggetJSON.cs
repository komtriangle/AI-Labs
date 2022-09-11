/* file "NumberFactsInfoNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class NumberFactsInfoNuggetJSON : InformationNuggetJSON
  {
    public enum TypeErrorCode
      {
        ErrorCode_UNINITIALIZED_RESPONSE,
        ErrorCode_BAD_RESPONSE,
        ErrorCode_GOOD_RESPONSE
      };

    public static TypeErrorCode  stringToErrorCode(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "AD_RESPONSE", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeErrorCode.ErrorCode_BAD_RESPONSE;
                break;
            case 'G':
                if ((String.Compare(chars, 1, "OOD_RESPONSE", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeErrorCode.ErrorCode_GOOD_RESPONSE;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "NINITIALIZED_RESPONSE", 0, 21, false) == 0) && (chars.Length == 22))
                    return TypeErrorCode.ErrorCode_UNINITIALIZED_RESPONSE;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `ErrorCode' is not one of the legal values.");
      }

    public static string  stringFromErrorCode(TypeErrorCode the_enum)
      {
        switch (the_enum)
          {
            case TypeErrorCode.ErrorCode_UNINITIALIZED_RESPONSE:
                return "UNINITIALIZED_RESPONSE";
            case TypeErrorCode.ErrorCode_BAD_RESPONSE:
                return "BAD_RESPONSE";
            case TypeErrorCode.ErrorCode_GOOD_RESPONSE:
                return "GOOD_RESPONSE";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasNumber;
    private BigInteger storeNumber;
    private bool flagHasFact;
    private string storeFact;
    private bool flagHasRandom;
    private bool storeRandom;
    private bool flagHasErrorCode;
    private TypeErrorCode storeErrorCode;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNumberToJSON()
      {
        JSONIntegerValue generated_integer_Number = new JSONIntegerValue(storeNumber);
        return generated_integer_Number;
      }

    private JSONValue  extraFactToJSON()
      {
        JSONStringValue generated_string_Fact = new JSONStringValue(storeFact);
        return generated_string_Fact;
      }

    private JSONValue  extraRandomToJSON()
      {
        JSONValue generated_boolean_Random = (storeRandom ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_Random;
      }

    private JSONValue  extraErrorCodeToJSON()
      {
        JSONStringValue generated_string_ErrorCode;
        switch (storeErrorCode)
          {
            case TypeErrorCode.ErrorCode_UNINITIALIZED_RESPONSE:
                generated_string_ErrorCode = new JSONStringValue("UNINITIALIZED_RESPONSE");
                break;
            case TypeErrorCode.ErrorCode_BAD_RESPONSE:
                generated_string_ErrorCode = new JSONStringValue("BAD_RESPONSE");
                break;
            case TypeErrorCode.ErrorCode_GOOD_RESPONSE:
                generated_string_ErrorCode = new JSONStringValue("GOOD_RESPONSE");
                break;
            default:
                Debug.Assert(false);
                generated_string_ErrorCode = null;
                break;
          }
        return generated_string_ErrorCode;
      }


    private void  fromJSONNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Number of NumberFactsInfoNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Number of NumberFactsInfoNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumber(extracted_integer);
      }


    private void  fromJSONFact(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Fact of NumberFactsInfoNuggetJSON is not a string.");
        setFact(json_string.getData());
      }


    private void  fromJSONRandom(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Random of NumberFactsInfoNuggetJSON is not true for false.");
              }
          }
        setRandom(the_bool);
      }


    private void  fromJSONErrorCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorCode of NumberFactsInfoNuggetJSON is not a string.");
        TypeErrorCode the_enum;
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "AD_RESPONSE", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_enum = TypeErrorCode.ErrorCode_BAD_RESPONSE;
                        goto enum_is_done;
                      }
                break;
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "OOD_RESPONSE", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_enum = TypeErrorCode.ErrorCode_GOOD_RESPONSE;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "NINITIALIZED_RESPONSE", 0, 21, false) == 0) && (json_string.getData().Length == 22))
                      {
                        the_enum = TypeErrorCode.ErrorCode_UNINITIALIZED_RESPONSE;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field ErrorCode of NumberFactsInfoNuggetJSON is not one of the legal strings.");
      enum_is_done:;
        setErrorCode(the_enum);
      }


    public NumberFactsInfoNuggetJSON()
      {
        flagHasNumber = false;
        flagHasFact = false;
        flagHasRandom = false;
        flagHasErrorCode = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "NumberFactsInformationNuggets";
      }

    public bool  hasNumber()
      {
        return flagHasNumber;
      }

    public BigInteger  getNumber()
      {
        Debug.Assert(flagHasNumber);
        return storeNumber;
      }

    public bool  hasFact()
      {
        return flagHasFact;
      }

    public string  getFact()
      {
        Debug.Assert(flagHasFact);
        return storeFact;
      }

    public bool  hasRandom()
      {
        return flagHasRandom;
      }

    public bool  getRandom()
      {
        Debug.Assert(flagHasRandom);
        return storeRandom;
      }

    public bool  hasErrorCode()
      {
        return flagHasErrorCode;
      }

    public TypeErrorCode  getErrorCode()
      {
        Debug.Assert(flagHasErrorCode);
        return storeErrorCode;
      }

    public string  getErrorCodeAsString()
      {
        return stringFromErrorCode(getErrorCode());
      }


    public virtual int extraNumberFactsInfoNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraNumberFactsInfoNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraNumberFactsInfoNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraNumberFactsInfoNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasNumber)
            ++result;
        if (flagHasFact)
            ++result;
        if (flagHasRandom)
            ++result;
        if (flagHasErrorCode)
            ++result;
        result += extraNumberFactsInfoNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNumber)
          {
            if (remainder == 0)
                return "Number";
            --remainder;
          }
        if (flagHasFact)
          {
            if (remainder == 0)
                return "Fact";
            --remainder;
          }
        if (flagHasRandom)
          {
            if (remainder == 0)
                return "Random";
            --remainder;
          }
        if (flagHasErrorCode)
          {
            if (remainder == 0)
                return "ErrorCode";
            --remainder;
          }
        return extraNumberFactsInfoNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNumber)
          {
            if (remainder == 0)
                return extraNumberToJSON();
            --remainder;
          }
        if (flagHasFact)
          {
            if (remainder == 0)
                return extraFactToJSON();
            --remainder;
          }
        if (flagHasRandom)
          {
            if (remainder == 0)
                return extraRandomToJSON();
            --remainder;
          }
        if (flagHasErrorCode)
          {
            if (remainder == 0)
                return extraErrorCodeToJSON();
            --remainder;
          }
        return extraNumberFactsInfoNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "rrorCode", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasErrorCode ? extraErrorCodeToJSON() : null);
                break;
            case 'F':
                if ((String.Compare(field_name, 1, "act", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasFact ? extraFactToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "umber", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasNumber ? extraNumberToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "andom", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasRandom ? extraRandomToJSON() : null);
                break;
            default:
                break;
          }
        return extraNumberFactsInfoNuggetLookup(field_name);
      }

    public void setNumber(BigInteger new_value)
      {
        flagHasNumber = true;
        if (new_value < 0)
            throw new Exception("The value for field Number of NumberFactsInfoNuggetJSON is less than the lower bound (0) for that field.");
        storeNumber = new_value;
      }
    public void unsetNumber()
      {
        flagHasNumber = false;
      }
    public void setFact(string new_value)
      {
        flagHasFact = true;
        storeFact = new_value;
      }
    public void unsetFact()
      {
        flagHasFact = false;
      }
    public void setRandom(bool new_value)
      {
        flagHasRandom = true;
        storeRandom = new_value;
      }
    public void unsetRandom()
      {
        flagHasRandom = false;
      }
    public void setErrorCode(TypeErrorCode new_value)
      {
        flagHasErrorCode = true;
        storeErrorCode = new_value;
      }
    public void setErrorCode(string chars)
      {
        setErrorCode(stringToErrorCode(chars));
      }
    public void unsetErrorCode()
      {
        flagHasErrorCode = false;
      }

    public virtual void extraNumberFactsInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraNumberFactsInfoNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraNumberFactsInfoNuggetLookup(key);
        if (old_field == null)
          {
            extraNumberFactsInfoNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "rrorCode", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONErrorCode(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "act", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONFact(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "umber", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONNumber(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "andom", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONRandom(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraNumberFactsInfoNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "rrorCode", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONErrorCode(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "act", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONFact(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "umber", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONNumber(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "andom", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONRandom(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraNumberFactsInfoNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNumber);
        if (flagHasNumber)
          {
            handler.start_pair("Number");
            handler.number_value(storeNumber);
          }
        Debug.Assert(partial_allowed || flagHasFact);
        if (flagHasFact)
          {
            handler.start_pair("Fact");
            handler.string_value(storeFact);
          }
        Debug.Assert(partial_allowed || flagHasRandom);
        if (flagHasRandom)
          {
            handler.start_pair("Random");
            handler.boolean_value(storeRandom);
          }
        Debug.Assert(partial_allowed || flagHasErrorCode);
        if (flagHasErrorCode)
          {
            handler.start_pair("ErrorCode");
            switch (storeErrorCode)
              {
                case TypeErrorCode.ErrorCode_UNINITIALIZED_RESPONSE:
                    handler.string_value("UNINITIALIZED_RESPONSE");
                    break;
                case TypeErrorCode.ErrorCode_BAD_RESPONSE:
                    handler.string_value("BAD_RESPONSE");
                    break;
                case TypeErrorCode.ErrorCode_GOOD_RESPONSE:
                    handler.string_value("GOOD_RESPONSE");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        if (!(hasNumber()))
          {
            return "When parsing the object for %what%, the \"Number\" field was missing.";
          }
        if (!(hasFact()))
          {
            return "When parsing the object for %what%, the \"Fact\" field was missing.";
          }
        if (!(hasRandom()))
          {
            return "When parsing the object for %what%, the \"Random\" field was missing.";
          }
        if (!(hasErrorCode()))
          {
            return "When parsing the object for %what%, the \"ErrorCode\" field was missing.";
          }
        return null;
      }

    public static new NumberFactsInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NumberFactsInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberFactsInfoNugget", ignore_extras);
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
    public static new NumberFactsInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new NumberFactsInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NumberFactsInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberFactsInfoNugget", ignore_extras);
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
    public static new NumberFactsInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new NumberFactsInfoNuggetJSON from_text(string text, bool ignore_extras)
      {
        NumberFactsInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberFactsInfoNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NumberFactsInfoNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new NumberFactsInfoNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NumberFactsInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberFactsInfoNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
    private class FieldHoldingGeneratorNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorNumber fieldGeneratorNumber;
        private JSONHoldingStringGenerator fieldGeneratorFact;
        private JSONHoldingBooleanGenerator fieldGeneratorRandom;
    private abstract class FieldGeneratorErrorCode : JSONStringGenerator
          {
            protected FieldGeneratorErrorCode(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorErrorCode()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToErrorCode(result));
              }
            protected abstract void handle_result(TypeErrorCode result);
          };
    private class FieldHoldingGeneratorErrorCode : FieldGeneratorErrorCode
  {
    protected override void handle_result(TypeErrorCode result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorErrorCode(String what)
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
    public TypeErrorCode value;
  };
    private class FieldHoldingArrayGeneratorErrorCode : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorErrorCode
      {
        private FieldHoldingArrayGeneratorErrorCode top;

        protected override void handle_result(TypeErrorCode result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorErrorCode init_top)
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
    protected virtual void handle_result(List<TypeErrorCode> result)
      {
      }

    public FieldHoldingArrayGeneratorErrorCode(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeErrorCode>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorErrorCode()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeErrorCode>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeErrorCode> value;
  };
        private FieldHoldingGeneratorErrorCode fieldGeneratorErrorCode;
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
            if (!(getInformationNuggetJSONKey().Equals("NumberFactsInformationNuggets")))
                throw new Exception("The key field has a value other than `NumberFactsInformationNuggets'.");
            NumberFactsInfoNuggetJSON result = new NumberFactsInfoNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraNumberFactsInfoNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((NumberFactsInfoNuggetJSON )new_result);
          }
        protected void finish(NumberFactsInfoNuggetJSON result)
          {
            if (fieldGeneratorNumber.have_value)
              {
                result.setNumber(fieldGeneratorNumber.value);
                fieldGeneratorNumber.have_value = false;
              }
            else if ((!(result.hasNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Number\" field was missing.");
              }
            if (fieldGeneratorFact.have_value)
              {
                result.setFact(fieldGeneratorFact.value);
                fieldGeneratorFact.have_value = false;
              }
            else if ((!(result.hasFact())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Fact\" field was missing.");
              }
            if (fieldGeneratorRandom.have_value)
              {
                result.setRandom(fieldGeneratorRandom.value);
                fieldGeneratorRandom.have_value = false;
              }
            else if ((!(result.hasRandom())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Random\" field was missing.");
              }
            if (fieldGeneratorErrorCode.have_value)
              {
                result.setErrorCode(fieldGeneratorErrorCode.value);
                fieldGeneratorErrorCode.have_value = false;
              }
            else if ((!(result.hasErrorCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ErrorCode\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(NumberFactsInfoNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "rrorCode", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorErrorCode;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "act", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorFact;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umber", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorNumber;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "andom", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorRandom;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNumber = new FieldHoldingGeneratorNumber("field \"Number\" of the NumberFactsInfoNugget class");
            fieldGeneratorFact = new JSONHoldingStringGenerator("field \"Fact\" of the NumberFactsInfoNugget class");
            fieldGeneratorRandom = new JSONHoldingBooleanGenerator("field \"Random\" of the NumberFactsInfoNugget class");
            fieldGeneratorErrorCode = new FieldHoldingGeneratorErrorCode("field \"ErrorCode\" of the NumberFactsInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the NumberFactsInfoNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNumber = new FieldHoldingGeneratorNumber("field \"Number\" of the NumberFactsInfoNugget class");
            fieldGeneratorFact = new JSONHoldingStringGenerator("field \"Fact\" of the NumberFactsInfoNugget class");
            fieldGeneratorRandom = new JSONHoldingBooleanGenerator("field \"Random\" of the NumberFactsInfoNugget class");
            fieldGeneratorErrorCode = new FieldHoldingGeneratorErrorCode("field \"ErrorCode\" of the NumberFactsInfoNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the NumberFactsInfoNugget class");
          }

        public override void reset()
          {
            fieldGeneratorNumber.reset();
            fieldGeneratorFact.reset();
            fieldGeneratorRandom.reset();
            fieldGeneratorErrorCode.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(NumberFactsInfoNuggetJSON  result)
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
        public NumberFactsInfoNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NumberFactsInfoNuggetJSON  result)
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
    protected virtual void handle_result(List<NumberFactsInfoNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NumberFactsInfoNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NumberFactsInfoNuggetJSON>();
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
    public List<NumberFactsInfoNuggetJSON> value;
  };
  };
