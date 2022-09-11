/* file "ArithInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ArithInformationNuggetJSON : InformationNuggetJSON
  {
    public enum TypeArithCommandKind
      {
        ArithCommandKind_ArithCommand
      };

    public static TypeArithCommandKind  stringToArithCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "ArithCommand", 0, 12, false) == 0) && (chars.Length == 12))
            return TypeArithCommandKind.ArithCommandKind_ArithCommand;
        throw new Exception("The value for field `ArithCommandKind' is not one of the legal values.");
      }

    public static string  stringFromArithCommandKind(TypeArithCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeArithCommandKind.ArithCommandKind_ArithCommand:
                return "ArithCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasArithCommandKind;
    private bool flagHasFormula;
    private string storeFormula;
    private bool flagHasResult;
    private string storeResult;
    private bool flagHasTextResponse;
    private string storeTextResponse;
    private bool flagHasNumericResult;
    private double storeNumericResult;
    private string textStoreNumericResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraArithCommandKindToJSON()
      {
        JSONStringValue generated_string_ArithCommandKind;
        generated_string_ArithCommandKind = new JSONStringValue("ArithCommand");
        return generated_string_ArithCommandKind;
      }

    private JSONValue  extraFormulaToJSON()
      {
        JSONStringValue generated_string_Formula = new JSONStringValue(storeFormula);
        return generated_string_Formula;
      }

    private JSONValue  extraResultToJSON()
      {
        JSONStringValue generated_string_Result = new JSONStringValue(storeResult);
        return generated_string_Result;
      }

    private JSONValue  extraTextResponseToJSON()
      {
        JSONStringValue generated_string_TextResponse = new JSONStringValue(storeTextResponse);
        return generated_string_TextResponse;
      }

    private JSONValue  extraNumericResultToJSON()
      {
        JSONValue generated_rational_NumericResult;
        if (textStoreNumericResult != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreNumericResult);
            generated_rational_NumericResult = handler.result;
          }
        else if (((double)(long)storeNumericResult) == storeNumericResult)
            generated_rational_NumericResult = new JSONIntegerValue((long)(storeNumericResult));
        else
            generated_rational_NumericResult = new JSONRationalValue(storeNumericResult, 15);
        return generated_rational_NumericResult;
      }


    private void  fromJSONArithCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ArithCommandKind of ArithInformationNuggetJSON is not a string.");
        if (!(json_string.getData().Equals("ArithCommand")))
            throw new Exception("The value for field ArithCommandKind of ArithInformationNuggetJSON is not `ArithCommand'.");
        setArithCommandKind();
      }


    private void  fromJSONFormula(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Formula of ArithInformationNuggetJSON is not a string.");
        setFormula(json_string.getData());
      }


    private void  fromJSONResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Result of ArithInformationNuggetJSON is not a string.");
        setResult(json_string.getData());
      }


    private void  fromJSONTextResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TextResponse of ArithInformationNuggetJSON is not a string.");
        setTextResponse(json_string.getData());
      }


    private void  fromJSONNumericResult(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NumericResult of ArithInformationNuggetJSON is not a number.");
              }
          }
        setNumericResultText(the_rational_text);
      }


    public ArithInformationNuggetJSON()
      {
        flagHasArithCommandKind = false;
        flagHasFormula = false;
        flagHasResult = false;
        flagHasTextResponse = false;
        flagHasNumericResult = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "Arith";
      }

    public bool  hasArithCommandKind()
      {
        return flagHasArithCommandKind;
      }

    public TypeArithCommandKind  getArithCommandKind()
      {
        Debug.Assert(flagHasArithCommandKind);
        return TypeArithCommandKind.ArithCommandKind_ArithCommand;
      }

    public string  getArithCommandKindAsString()
      {
        return stringFromArithCommandKind(getArithCommandKind());
      }

    public bool  hasFormula()
      {
        return flagHasFormula;
      }

    public string  getFormula()
      {
        Debug.Assert(flagHasFormula);
        return storeFormula;
      }

    public bool  hasResult()
      {
        return flagHasResult;
      }

    public string  getResult()
      {
        Debug.Assert(flagHasResult);
        return storeResult;
      }

    public bool  hasTextResponse()
      {
        return flagHasTextResponse;
      }

    public string  getTextResponse()
      {
        Debug.Assert(flagHasTextResponse);
        return storeTextResponse;
      }

    public bool  hasNumericResult()
      {
        return flagHasNumericResult;
      }

    public double  getNumericResult()
      {
        Debug.Assert(flagHasNumericResult);
        if (textStoreNumericResult != "")
          {
            return Double.Parse(textStoreNumericResult);
          }
        return storeNumericResult;
      }

    public string  getNumericResultAsText()
      {
        Debug.Assert(flagHasNumericResult);
        if (textStoreNumericResult == "")
          {
            return Convert.ToString(storeNumericResult);
          }
        else
          {
            return (textStoreNumericResult);
          }
      }


    public virtual int extraArithInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraArithInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraArithInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraArithInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasArithCommandKind)
            ++result;
        if (flagHasFormula)
            ++result;
        if (flagHasResult)
            ++result;
        if (flagHasTextResponse)
            ++result;
        if (flagHasNumericResult)
            ++result;
        result += extraArithInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasArithCommandKind)
          {
            if (remainder == 0)
                return "ArithCommandKind";
            --remainder;
          }
        if (flagHasFormula)
          {
            if (remainder == 0)
                return "Formula";
            --remainder;
          }
        if (flagHasResult)
          {
            if (remainder == 0)
                return "Result";
            --remainder;
          }
        if (flagHasTextResponse)
          {
            if (remainder == 0)
                return "TextResponse";
            --remainder;
          }
        if (flagHasNumericResult)
          {
            if (remainder == 0)
                return "NumericResult";
            --remainder;
          }
        return extraArithInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasArithCommandKind)
          {
            if (remainder == 0)
                return extraArithCommandKindToJSON();
            --remainder;
          }
        if (flagHasFormula)
          {
            if (remainder == 0)
                return extraFormulaToJSON();
            --remainder;
          }
        if (flagHasResult)
          {
            if (remainder == 0)
                return extraResultToJSON();
            --remainder;
          }
        if (flagHasTextResponse)
          {
            if (remainder == 0)
                return extraTextResponseToJSON();
            --remainder;
          }
        if (flagHasNumericResult)
          {
            if (remainder == 0)
                return extraNumericResultToJSON();
            --remainder;
          }
        return extraArithInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "rithCommandKind", 0, 15, false) == 0) && (field_name.Length == 16))
                    return (flagHasArithCommandKind ? extraArithCommandKindToJSON() : null);
                break;
            case 'F':
                if ((String.Compare(field_name, 1, "ormula", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasFormula ? extraFormulaToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "umericResult", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasNumericResult ? extraNumericResultToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "esult", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasResult ? extraResultToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "extResponse", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasTextResponse ? extraTextResponseToJSON() : null);
                break;
            default:
                break;
          }
        return extraArithInformationNuggetLookup(field_name);
      }

    public void setArithCommandKind()
      {
        flagHasArithCommandKind = true;
      }
    public void setArithCommandKind(TypeArithCommandKind new_value)
      {
        setArithCommandKind();
      }
    public void setArithCommandKind(string chars)
      {
        setArithCommandKind(stringToArithCommandKind(chars));
      }
    public void unsetArithCommandKind()
      {
        flagHasArithCommandKind = false;
      }
    public void setFormula(string new_value)
      {
        flagHasFormula = true;
        storeFormula = new_value;
      }
    public void unsetFormula()
      {
        flagHasFormula = false;
      }
    public void setResult(string new_value)
      {
        flagHasResult = true;
        storeResult = new_value;
      }
    public void unsetResult()
      {
        flagHasResult = false;
      }
    public void setTextResponse(string new_value)
      {
        flagHasTextResponse = true;
        storeTextResponse = new_value;
      }
    public void unsetTextResponse()
      {
        flagHasTextResponse = false;
      }
    public void setNumericResult(double new_value)
      {
        flagHasNumericResult = true;
        storeNumericResult = new_value;
        textStoreNumericResult = "";
      }
    public void setNumericResultText(string new_value)
      {
        flagHasNumericResult = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field NumericResult of ArithInformationNuggetJSON is not a valid number.");
        textStoreNumericResult = new_value;
      }
    public void unsetNumericResult()
      {
        flagHasNumericResult = false;
      }

    public virtual void extraArithInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraArithInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraArithInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraArithInformationNuggetAppendPair(key, new_component);
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
            case 'A':
                if ((String.Compare(key, 1, "rithCommandKind", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONArithCommandKind(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ormula", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONFormula(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "umericResult", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONNumericResult(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esult", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONResult(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "extResponse", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONTextResponse(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraArithInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "rithCommandKind", 0, 15, false) == 0) && (key.Length == 16))
                    {
                    fromJSONArithCommandKind(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ormula", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONFormula(new_component, false);
                    return;
                    }
                break;
            case 'N':
                if ((String.Compare(key, 1, "umericResult", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONNumericResult(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esult", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONResult(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "extResponse", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONTextResponse(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraArithInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasArithCommandKind);
        if (flagHasArithCommandKind)
          {
            handler.start_pair("ArithCommandKind");
            handler.string_value("ArithCommand");
          }
        Debug.Assert(partial_allowed || flagHasFormula);
        if (flagHasFormula)
          {
            handler.start_pair("Formula");
            handler.string_value(storeFormula);
          }
        Debug.Assert(partial_allowed || flagHasResult);
        if (flagHasResult)
          {
            handler.start_pair("Result");
            handler.string_value(storeResult);
          }
        Debug.Assert(partial_allowed || flagHasTextResponse);
        if (flagHasTextResponse)
          {
            handler.start_pair("TextResponse");
            handler.string_value(storeTextResponse);
          }
        if (flagHasNumericResult)
          {
            handler.start_pair("NumericResult");
            if (textStoreNumericResult != "")
                handler.number_value(textStoreNumericResult);
            else if (((double)(long)storeNumericResult) == storeNumericResult)
                handler.number_value((long)storeNumericResult);
            else
                handler.number_value(storeNumericResult);
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
        if (!(hasArithCommandKind()))
          {
            return "When parsing the object for %what%, the \"ArithCommandKind\" field was missing.";
          }
        if (!(hasFormula()))
          {
            return "When parsing the object for %what%, the \"Formula\" field was missing.";
          }
        if (!(hasResult()))
          {
            return "When parsing the object for %what%, the \"Result\" field was missing.";
          }
        if (!(hasTextResponse()))
          {
            return "When parsing the object for %what%, the \"TextResponse\" field was missing.";
          }
        return null;
      }

    public static new ArithInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ArithInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ArithInformationNugget", ignore_extras);
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
    public static new ArithInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ArithInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ArithInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ArithInformationNugget", ignore_extras);
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
    public static new ArithInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ArithInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        ArithInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ArithInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ArithInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ArithInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ArithInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ArithInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
    private abstract class FieldGeneratorArithCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorArithCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorArithCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToArithCommandKind(result));
              }
            protected abstract void handle_result(TypeArithCommandKind result);
          };
    private class FieldHoldingGeneratorArithCommandKind : FieldGeneratorArithCommandKind
  {
    protected override void handle_result(TypeArithCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorArithCommandKind(String what)
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
    public TypeArithCommandKind value;
  };
    private class FieldHoldingArrayGeneratorArithCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorArithCommandKind
      {
        private FieldHoldingArrayGeneratorArithCommandKind top;

        protected override void handle_result(TypeArithCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorArithCommandKind init_top)
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
    protected virtual void handle_result(List<TypeArithCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorArithCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeArithCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorArithCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeArithCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeArithCommandKind> value;
  };
        private FieldHoldingGeneratorArithCommandKind fieldGeneratorArithCommandKind;
        private JSONHoldingStringGenerator fieldGeneratorFormula;
        private JSONHoldingStringGenerator fieldGeneratorResult;
        private JSONHoldingStringGenerator fieldGeneratorTextResponse;
        private JSONHoldingNumberTextGenerator fieldGeneratorNumericResult;
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
            if (!(getInformationNuggetJSONKey().Equals("Arith")))
                throw new Exception("The key field has a value other than `Arith'.");
            ArithInformationNuggetJSON result = new ArithInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraArithInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((ArithInformationNuggetJSON )new_result);
          }
        protected void finish(ArithInformationNuggetJSON result)
          {
            if (fieldGeneratorArithCommandKind.have_value)
              {
                result.setArithCommandKind();
                fieldGeneratorArithCommandKind.have_value = false;
              }
            else if ((!(result.hasArithCommandKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ArithCommandKind\" field was missing.");
              }
            if (fieldGeneratorFormula.have_value)
              {
                result.setFormula(fieldGeneratorFormula.value);
                fieldGeneratorFormula.have_value = false;
              }
            else if ((!(result.hasFormula())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Formula\" field was missing.");
              }
            if (fieldGeneratorResult.have_value)
              {
                result.setResult(fieldGeneratorResult.value);
                fieldGeneratorResult.have_value = false;
              }
            else if ((!(result.hasResult())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Result\" field was missing.");
              }
            if (fieldGeneratorTextResponse.have_value)
              {
                result.setTextResponse(fieldGeneratorTextResponse.value);
                fieldGeneratorTextResponse.have_value = false;
              }
            else if ((!(result.hasTextResponse())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TextResponse\" field was missing.");
              }
            if (fieldGeneratorNumericResult.have_value)
              {
                result.setNumericResultText(fieldGeneratorNumericResult.value);
                fieldGeneratorNumericResult.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ArithInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "rithCommandKind", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorArithCommandKind;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "ormula", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorFormula;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umericResult", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorNumericResult;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esult", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorResult;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "extResponse", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorTextResponse;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorArithCommandKind = new FieldHoldingGeneratorArithCommandKind("field \"ArithCommandKind\" of the ArithInformationNugget class");
            fieldGeneratorFormula = new JSONHoldingStringGenerator("field \"Formula\" of the ArithInformationNugget class");
            fieldGeneratorResult = new JSONHoldingStringGenerator("field \"Result\" of the ArithInformationNugget class");
            fieldGeneratorTextResponse = new JSONHoldingStringGenerator("field \"TextResponse\" of the ArithInformationNugget class");
            fieldGeneratorNumericResult = new JSONHoldingNumberTextGenerator("field \"NumericResult\" of the ArithInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ArithInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorArithCommandKind = new FieldHoldingGeneratorArithCommandKind("field \"ArithCommandKind\" of the ArithInformationNugget class");
            fieldGeneratorFormula = new JSONHoldingStringGenerator("field \"Formula\" of the ArithInformationNugget class");
            fieldGeneratorResult = new JSONHoldingStringGenerator("field \"Result\" of the ArithInformationNugget class");
            fieldGeneratorTextResponse = new JSONHoldingStringGenerator("field \"TextResponse\" of the ArithInformationNugget class");
            fieldGeneratorNumericResult = new JSONHoldingNumberTextGenerator("field \"NumericResult\" of the ArithInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ArithInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorArithCommandKind.reset();
            fieldGeneratorFormula.reset();
            fieldGeneratorResult.reset();
            fieldGeneratorTextResponse.reset();
            fieldGeneratorNumericResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ArithInformationNuggetJSON  result)
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
        public ArithInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ArithInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<ArithInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ArithInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ArithInformationNuggetJSON>();
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
    public List<ArithInformationNuggetJSON> value;
  };
  };
