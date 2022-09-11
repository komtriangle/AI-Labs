/* file "RandomNumberGeneratorNumberRequestResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RandomNumberGeneratorNumberRequestResultJSON : RandomNumberGeneratorRequestResultJSON
  {
    public enum TypeNumberType
      {
        NumberType_Integer,
        NumberType_Rational
      };

    public static TypeNumberType  stringToNumberType(string chars)
      {
        switch (chars[0])
          {
            case 'I':
                if ((String.Compare(chars, 1, "nteger", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeNumberType.NumberType_Integer;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "ational", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeNumberType.NumberType_Rational;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `NumberType' is not one of the legal values.");
      }

    public static string  stringFromNumberType(TypeNumberType the_enum)
      {
        switch (the_enum)
          {
            case TypeNumberType.NumberType_Integer:
                return "Integer";
            case TypeNumberType.NumberType_Rational:
                return "Rational";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValues;
    private List< Double > storeValues;
    private bool flagHasNumberType;
    private TypeNumberType storeNumberType;
    private bool flagHasUpperBound;
    private double storeUpperBound;
    private string textStoreUpperBound;
    private bool flagHasLowerBound;
    private double storeLowerBound;
    private string textStoreLowerBound;


    private JSONValue  extraValuesToJSON()
      {
        JSONArrayValue generated_array_1_Values = new JSONArrayValue();
        for (int num1 = 0; num1 < storeValues.Count; ++num1)
          {
            JSONValue generated_rational_Values;
            if (((double)(long)storeValues[num1]) == storeValues[num1])
                generated_rational_Values = new JSONIntegerValue((long)(storeValues[num1]));
            else
                generated_rational_Values = new JSONRationalValue(storeValues[num1], 15);
            generated_array_1_Values.appendComponent(generated_rational_Values);
          }
        return generated_array_1_Values;
      }

    private JSONValue  extraNumberTypeToJSON()
      {
        JSONStringValue generated_string_NumberType;
        switch (storeNumberType)
          {
            case TypeNumberType.NumberType_Integer:
                generated_string_NumberType = new JSONStringValue("Integer");
                break;
            case TypeNumberType.NumberType_Rational:
                generated_string_NumberType = new JSONStringValue("Rational");
                break;
            default:
                Debug.Assert(false);
                generated_string_NumberType = null;
                break;
          }
        return generated_string_NumberType;
      }

    private JSONValue  extraUpperBoundToJSON()
      {
        JSONValue generated_rational_UpperBound;
        if (textStoreUpperBound != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreUpperBound);
            generated_rational_UpperBound = handler.result;
          }
        else if (((double)(long)storeUpperBound) == storeUpperBound)
            generated_rational_UpperBound = new JSONIntegerValue((long)(storeUpperBound));
        else
            generated_rational_UpperBound = new JSONRationalValue(storeUpperBound, 15);
        return generated_rational_UpperBound;
      }

    private JSONValue  extraLowerBoundToJSON()
      {
        JSONValue generated_rational_LowerBound;
        if (textStoreLowerBound != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreLowerBound);
            generated_rational_LowerBound = handler.result;
          }
        else if (((double)(long)storeLowerBound) == storeLowerBound)
            generated_rational_LowerBound = new JSONIntegerValue((long)(storeLowerBound));
        else
            generated_rational_LowerBound = new JSONRationalValue(storeLowerBound, 15);
        return generated_rational_LowerBound;
      }


    private void  fromJSONValues(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Values of RandomNumberGeneratorNumberRequestResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Values of RandomNumberGeneratorNumberRequestResultJSON has too few elements.");
        List< Double > vector_Values1 = new List< Double >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONRationalValue json_rational = json_array1.component(num1).rational_value();
            double the_double;
            if (json_rational != null)
              {
                the_double = json_rational.getDouble();
              }
            else
              {
                JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                if (json_integer != null)
                  {
                    the_double = json_integer.getLongInt();
                  }
                else
                  {
                    throw new Exception("The value for an element of field Values of RandomNumberGeneratorNumberRequestResultJSON is not a number.");
                  }
              }
            vector_Values1.Add(the_double);
          }
        Debug.Assert(vector_Values1.Count >= 1);
        initValues();
        for (int num1 = 0; num1 < vector_Values1.Count; ++num1)
            appendValues(vector_Values1[num1]);
        for (int num1 = 0; num1 < vector_Values1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNumberType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NumberType of RandomNumberGeneratorNumberRequestResultJSON is not a string.");
        TypeNumberType the_enum;
        switch (json_string.getData()[0])
          {
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nteger", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeNumberType.NumberType_Integer;
                        goto enum_is_done;
                      }
                break;
            case 'R':
                if ((String.Compare(json_string.getData(), 1, "ational", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_enum = TypeNumberType.NumberType_Rational;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field NumberType of RandomNumberGeneratorNumberRequestResultJSON is not one of the legal strings.");
      enum_is_done:;
        setNumberType(the_enum);
      }


    private void  fromJSONUpperBound(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field UpperBound of RandomNumberGeneratorNumberRequestResultJSON is not a number.");
              }
          }
        setUpperBoundText(the_rational_text);
      }


    private void  fromJSONLowerBound(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field LowerBound of RandomNumberGeneratorNumberRequestResultJSON is not a number.");
              }
          }
        setLowerBoundText(the_rational_text);
      }


    public RandomNumberGeneratorNumberRequestResultJSON()
      {
        flagHasValues = false;
        flagHasNumberType = false;
        flagHasUpperBound = false;
        flagHasLowerBound = false;
        storeValues = new List< Double >();
      }

    public override string  getRandomNumberRequestKind()
      {
        return "NumberRequest";
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

    public double  elementOfValues(int element_num)
      {
        Debug.Assert(flagHasValues);
        return storeValues[element_num];
      }

    public List< Double >  getValues()
      {
        Debug.Assert(flagHasValues);
        return storeValues;
      }

    public bool  hasNumberType()
      {
        return flagHasNumberType;
      }

    public TypeNumberType  getNumberType()
      {
        Debug.Assert(flagHasNumberType);
        return storeNumberType;
      }

    public string  getNumberTypeAsString()
      {
        return stringFromNumberType(getNumberType());
      }

    public bool  hasUpperBound()
      {
        return flagHasUpperBound;
      }

    public double  getUpperBound()
      {
        Debug.Assert(flagHasUpperBound);
        if (textStoreUpperBound != "")
          {
            return Double.Parse(textStoreUpperBound);
          }
        return storeUpperBound;
      }

    public string  getUpperBoundAsText()
      {
        Debug.Assert(flagHasUpperBound);
        if (textStoreUpperBound == "")
          {
            return Convert.ToString(storeUpperBound);
          }
        else
          {
            return (textStoreUpperBound);
          }
      }

    public bool  hasLowerBound()
      {
        return flagHasLowerBound;
      }

    public double  getLowerBound()
      {
        Debug.Assert(flagHasLowerBound);
        if (textStoreLowerBound != "")
          {
            return Double.Parse(textStoreLowerBound);
          }
        return storeLowerBound;
      }

    public string  getLowerBoundAsText()
      {
        Debug.Assert(flagHasLowerBound);
        if (textStoreLowerBound == "")
          {
            return Convert.ToString(storeLowerBound);
          }
        else
          {
            return (textStoreLowerBound);
          }
      }


    public override int extraRandomNumberGeneratorRequestResultComponentCount()
      {
        int result = 0;
        if (flagHasValues)
            ++result;
        if (flagHasNumberType)
            ++result;
        if (flagHasUpperBound)
            ++result;
        if (flagHasLowerBound)
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
        if (flagHasNumberType)
          {
            if (remainder == 0)
                return "NumberType";
            --remainder;
          }
        if (flagHasUpperBound)
          {
            if (remainder == 0)
                return "UpperBound";
            --remainder;
          }
        if (flagHasLowerBound)
          {
            if (remainder == 0)
                return "LowerBound";
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
        if (flagHasNumberType)
          {
            if (remainder == 0)
                return extraNumberTypeToJSON();
            --remainder;
          }
        if (flagHasUpperBound)
          {
            if (remainder == 0)
                return extraUpperBoundToJSON();
            --remainder;
          }
        if (flagHasLowerBound)
          {
            if (remainder == 0)
                return extraLowerBoundToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraRandomNumberGeneratorRequestResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'L':
                if ((String.Compare(field_name, 1, "owerBound", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasLowerBound ? extraLowerBoundToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "umberType", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasNumberType ? extraNumberTypeToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "pperBound", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasUpperBound ? extraUpperBoundToJSON() : null);
                break;
            case 'V':
                if ((String.Compare(field_name, 1, "alues", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasValues ? extraValuesToJSON() : null);
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
    public void appendValues(double to_append)
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
    public void setNumberType(TypeNumberType new_value)
      {
        flagHasNumberType = true;
        storeNumberType = new_value;
      }
    public void setNumberType(string chars)
      {
        setNumberType(stringToNumberType(chars));
      }
    public void unsetNumberType()
      {
        flagHasNumberType = false;
      }
    public void setUpperBound(double new_value)
      {
        flagHasUpperBound = true;
        storeUpperBound = new_value;
        textStoreUpperBound = "";
      }
    public void setUpperBoundText(string new_value)
      {
        flagHasUpperBound = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field UpperBound of RandomNumberGeneratorNumberRequestResultJSON is not a valid number.");
        textStoreUpperBound = new_value;
      }
    public void unsetUpperBound()
      {
        flagHasUpperBound = false;
      }
    public void setLowerBound(double new_value)
      {
        flagHasLowerBound = true;
        storeLowerBound = new_value;
        textStoreLowerBound = "";
      }
    public void setLowerBoundText(string new_value)
      {
        flagHasLowerBound = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field LowerBound of RandomNumberGeneratorNumberRequestResultJSON is not a valid number.");
        textStoreLowerBound = new_value;
      }
    public void unsetLowerBound()
      {
        flagHasLowerBound = false;
      }

    public override void extraRandomNumberGeneratorRequestResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'L':
                if ((String.Compare(key, 1, "owerBound", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONLowerBound(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "umberType", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNumberType(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "pperBound", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONUpperBound(new_component, false);
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
      }
    public override void extraRandomNumberGeneratorRequestResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'L':
                if ((String.Compare(key, 1, "owerBound", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONLowerBound(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "umberType", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNumberType(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "pperBound", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONUpperBound(new_component, false);
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
                if (((double)(long)storeValues[num1]) == storeValues[num1])
                    handler.number_value((long)storeValues[num1]);
                else
                    handler.number_value(storeValues[num1]);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasNumberType);
        if (flagHasNumberType)
          {
            handler.start_pair("NumberType");
            switch (storeNumberType)
              {
                case TypeNumberType.NumberType_Integer:
                    handler.string_value("Integer");
                    break;
                case TypeNumberType.NumberType_Rational:
                    handler.string_value("Rational");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasUpperBound);
        if (flagHasUpperBound)
          {
            handler.start_pair("UpperBound");
            if (textStoreUpperBound != "")
                handler.number_value(textStoreUpperBound);
            else if (((double)(long)storeUpperBound) == storeUpperBound)
                handler.number_value((long)storeUpperBound);
            else
                handler.number_value(storeUpperBound);
          }
        Debug.Assert(partial_allowed || flagHasLowerBound);
        if (flagHasLowerBound)
          {
            handler.start_pair("LowerBound");
            if (textStoreLowerBound != "")
                handler.number_value(textStoreLowerBound);
            else if (((double)(long)storeLowerBound) == storeLowerBound)
                handler.number_value((long)storeLowerBound);
            else
                handler.number_value(storeLowerBound);
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
        if (!(hasNumberType()))
          {
            return "When parsing the object for %what%, the \"NumberType\" field was missing.";
          }
        if (!(hasUpperBound()))
          {
            return "When parsing the object for %what%, the \"UpperBound\" field was missing.";
          }
        if (!(hasLowerBound()))
          {
            return "When parsing the object for %what%, the \"LowerBound\" field was missing.";
          }
        return null;
      }

    public static new RandomNumberGeneratorNumberRequestResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RandomNumberGeneratorNumberRequestResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorNumberRequestResult", ignore_extras);
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
    public static new RandomNumberGeneratorNumberRequestResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RandomNumberGeneratorNumberRequestResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RandomNumberGeneratorNumberRequestResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorNumberRequestResult", ignore_extras);
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
    public static new RandomNumberGeneratorNumberRequestResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RandomNumberGeneratorNumberRequestResultJSON from_text(string text, bool ignore_extras)
      {
        RandomNumberGeneratorNumberRequestResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorNumberRequestResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RandomNumberGeneratorNumberRequestResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RandomNumberGeneratorNumberRequestResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RandomNumberGeneratorNumberRequestResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RandomNumberGeneratorNumberRequestResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RandomNumberGeneratorRequestResultJSON.Generator
      {
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorValues;
    private abstract class FieldGeneratorNumberType : JSONStringGenerator
          {
            protected FieldGeneratorNumberType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNumberType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToNumberType(result));
              }
            protected abstract void handle_result(TypeNumberType result);
          };
    private class FieldHoldingGeneratorNumberType : FieldGeneratorNumberType
  {
    protected override void handle_result(TypeNumberType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNumberType(String what)
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
    public TypeNumberType value;
  };
    private class FieldHoldingArrayGeneratorNumberType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNumberType
      {
        private FieldHoldingArrayGeneratorNumberType top;

        protected override void handle_result(TypeNumberType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNumberType init_top)
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
    protected virtual void handle_result(List<TypeNumberType> result)
      {
      }

    public FieldHoldingArrayGeneratorNumberType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNumberType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNumberType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNumberType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNumberType> value;
  };
        private FieldHoldingGeneratorNumberType fieldGeneratorNumberType;
        private JSONHoldingNumberTextGenerator fieldGeneratorUpperBound;
        private JSONHoldingNumberTextGenerator fieldGeneratorLowerBound;

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
            if (!(getRandomNumberGeneratorRequestResultJSONKey().Equals("NumberRequest")))
                throw new Exception("The key field has a value other than `NumberRequest'.");
            RandomNumberGeneratorNumberRequestResultJSON result = new RandomNumberGeneratorNumberRequestResultJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(RandomNumberGeneratorRequestResultJSON new_result)
          {
            handle_result((RandomNumberGeneratorNumberRequestResultJSON )new_result);
          }
        protected void finish(RandomNumberGeneratorNumberRequestResultJSON result)
          {
            if (fieldGeneratorValues.have_value)
              {
                result.initValues();
                int count = fieldGeneratorValues.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendValues(Double.Parse(fieldGeneratorValues.value[num]));
                  }
                fieldGeneratorValues.value.Clear();
                fieldGeneratorValues.have_value = false;
              }
            if (fieldGeneratorNumberType.have_value)
              {
                result.setNumberType(fieldGeneratorNumberType.value);
                fieldGeneratorNumberType.have_value = false;
              }
            else if ((!(result.hasNumberType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NumberType\" field was missing.");
              }
            if (fieldGeneratorUpperBound.have_value)
              {
                result.setUpperBoundText(fieldGeneratorUpperBound.value);
                fieldGeneratorUpperBound.have_value = false;
              }
            else if ((!(result.hasUpperBound())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UpperBound\" field was missing.");
              }
            if (fieldGeneratorLowerBound.have_value)
              {
                result.setLowerBoundText(fieldGeneratorLowerBound.value);
                fieldGeneratorLowerBound.have_value = false;
              }
            else if ((!(result.hasLowerBound())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LowerBound\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(RandomNumberGeneratorNumberRequestResultJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'L':
                    if ((String.Compare(field_name, 1, "owerBound", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorLowerBound;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umberType", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNumberType;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "pperBound", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorUpperBound;
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
            fieldGeneratorValues = new JSONHoldingNumberTextArrayGenerator("field \"Values\" of the RandomNumberGeneratorNumberRequestResult class");
            fieldGeneratorNumberType = new FieldHoldingGeneratorNumberType("field \"NumberType\" of the RandomNumberGeneratorNumberRequestResult class");
            fieldGeneratorUpperBound = new JSONHoldingNumberTextGenerator("field \"UpperBound\" of the RandomNumberGeneratorNumberRequestResult class");
            fieldGeneratorLowerBound = new JSONHoldingNumberTextGenerator("field \"LowerBound\" of the RandomNumberGeneratorNumberRequestResult class");
            set_what("the RandomNumberGeneratorNumberRequestResult class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorValues = new JSONHoldingNumberTextArrayGenerator("field \"Values\" of the RandomNumberGeneratorNumberRequestResult class");
            fieldGeneratorNumberType = new FieldHoldingGeneratorNumberType("field \"NumberType\" of the RandomNumberGeneratorNumberRequestResult class");
            fieldGeneratorUpperBound = new JSONHoldingNumberTextGenerator("field \"UpperBound\" of the RandomNumberGeneratorNumberRequestResult class");
            fieldGeneratorLowerBound = new JSONHoldingNumberTextGenerator("field \"LowerBound\" of the RandomNumberGeneratorNumberRequestResult class");
            set_what("the RandomNumberGeneratorNumberRequestResult class");
          }

        public override void reset()
          {
            fieldGeneratorValues.reset();
            fieldGeneratorNumberType.reset();
            fieldGeneratorUpperBound.reset();
            fieldGeneratorLowerBound.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RandomNumberGeneratorNumberRequestResultJSON  result)
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
        public RandomNumberGeneratorNumberRequestResultJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RandomNumberGeneratorNumberRequestResultJSON  result)
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
    protected virtual void handle_result(List<RandomNumberGeneratorNumberRequestResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RandomNumberGeneratorNumberRequestResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RandomNumberGeneratorNumberRequestResultJSON>();
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
    public List<RandomNumberGeneratorNumberRequestResultJSON> value;
  };
  };
