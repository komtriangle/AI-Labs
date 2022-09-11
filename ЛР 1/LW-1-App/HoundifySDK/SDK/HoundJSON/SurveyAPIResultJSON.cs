/* file "SurveyAPIResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SurveyAPIResultJSON : CommandResultJSON
  {
    private bool flagHasSurveyRequestKind;
    private BigInteger storeSurveyRequestKind;
    private bool flagHasOperationSucceeded;
    private bool storeOperationSucceeded;
    private bool flagHasErrorMessage;
    private string storeErrorMessage;
    private bool flagHasWarnings;
    private List< string > storeWarnings;
    private bool flagHasSurvey;
    private SurveyJSON  storeSurvey;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSurveyRequestKindToJSON()
      {
        JSONIntegerValue generated_integer_SurveyRequestKind = new JSONIntegerValue(storeSurveyRequestKind);
        return generated_integer_SurveyRequestKind;
      }

    private JSONValue  extraOperationSucceededToJSON()
      {
        JSONValue generated_boolean_OperationSucceeded = (storeOperationSucceeded ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_OperationSucceeded;
      }

    private JSONValue  extraErrorMessageToJSON()
      {
        JSONStringValue generated_string_ErrorMessage = new JSONStringValue(storeErrorMessage);
        return generated_string_ErrorMessage;
      }

    private JSONValue  extraWarningsToJSON()
      {
        JSONArrayValue generated_array_1_Warnings = new JSONArrayValue();
        for (int num1 = 0; num1 < storeWarnings.Count; ++num1)
          {
            JSONStringValue generated_string_Warnings = new JSONStringValue(storeWarnings[num1]);
            generated_array_1_Warnings.appendComponent(generated_string_Warnings);
          }
        return generated_array_1_Warnings;
      }

    private JSONValue  extraSurveyToJSON()
      {
        JSONValueHandler handler_Survey = new JSONValueHandler();
        storeSurvey.write_as_json(handler_Survey);
        return handler_Survey.result;
      }


    private void  fromJSONSurveyRequestKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SurveyRequestKind of SurveyAPIResultJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SurveyRequestKind of SurveyAPIResultJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSurveyRequestKind(extracted_integer);
      }


    private void  fromJSONOperationSucceeded(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OperationSucceeded of SurveyAPIResultJSON is not true for false.");
              }
          }
        setOperationSucceeded(the_bool);
      }


    private void  fromJSONErrorMessage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ErrorMessage of SurveyAPIResultJSON is not a string.");
        setErrorMessage(json_string.getData());
      }


    private void  fromJSONWarnings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Warnings of SurveyAPIResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Warnings1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Warnings of SurveyAPIResultJSON is not a string.");
            vector_Warnings1.Add(json_string.getData());
          }
        initWarnings();
        for (int num1 = 0; num1 < vector_Warnings1.Count; ++num1)
            appendWarnings(vector_Warnings1[num1]);
        for (int num1 = 0; num1 < vector_Warnings1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSurvey(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SurveyJSON convert_classy = SurveyJSON.from_json(json_value, ignore_extras, true);
        setSurvey(convert_classy);
      }


    public SurveyAPIResultJSON()
      {
        flagHasSurveyRequestKind = false;
        flagHasOperationSucceeded = false;
        flagHasErrorMessage = false;
        flagHasWarnings = false;
        flagHasSurvey = false;
        storeWarnings = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getCommandKind()
      {
        return "SurveyAPIResult";
      }

    public bool  hasSurveyRequestKind()
      {
        return flagHasSurveyRequestKind;
      }

    public BigInteger  getSurveyRequestKind()
      {
        Debug.Assert(flagHasSurveyRequestKind);
        return storeSurveyRequestKind;
      }

    public bool  hasOperationSucceeded()
      {
        return flagHasOperationSucceeded;
      }

    public bool  getOperationSucceeded()
      {
        Debug.Assert(flagHasOperationSucceeded);
        return storeOperationSucceeded;
      }

    public bool  hasErrorMessage()
      {
        return flagHasErrorMessage;
      }

    public string  getErrorMessage()
      {
        Debug.Assert(flagHasErrorMessage);
        return storeErrorMessage;
      }

    public bool  hasWarnings()
      {
        return flagHasWarnings;
      }

    public int  countOfWarnings()
      {
        Debug.Assert(flagHasWarnings);
        return storeWarnings.Count;
      }

    public string  elementOfWarnings(int element_num)
      {
        Debug.Assert(flagHasWarnings);
        return storeWarnings[element_num];
      }

    public List< string >  getWarnings()
      {
        Debug.Assert(flagHasWarnings);
        return storeWarnings;
      }

    public bool  hasSurvey()
      {
        return flagHasSurvey;
      }

    public SurveyJSON   getSurvey()
      {
        Debug.Assert(flagHasSurvey);
        return storeSurvey;
      }


    public virtual int extraSurveyAPIResultComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSurveyAPIResultComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSurveyAPIResultComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSurveyAPIResultLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasSurveyRequestKind)
            ++result;
        if (flagHasOperationSucceeded)
            ++result;
        if (flagHasErrorMessage)
            ++result;
        if (flagHasWarnings)
            ++result;
        if (flagHasSurvey)
            ++result;
        result += extraSurveyAPIResultComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSurveyRequestKind)
          {
            if (remainder == 0)
                return "SurveyRequestKind";
            --remainder;
          }
        if (flagHasOperationSucceeded)
          {
            if (remainder == 0)
                return "OperationSucceeded";
            --remainder;
          }
        if (flagHasErrorMessage)
          {
            if (remainder == 0)
                return "ErrorMessage";
            --remainder;
          }
        if (flagHasWarnings)
          {
            if (remainder == 0)
                return "Warnings";
            --remainder;
          }
        if (flagHasSurvey)
          {
            if (remainder == 0)
                return "Survey";
            --remainder;
          }
        return extraSurveyAPIResultComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSurveyRequestKind)
          {
            if (remainder == 0)
                return extraSurveyRequestKindToJSON();
            --remainder;
          }
        if (flagHasOperationSucceeded)
          {
            if (remainder == 0)
                return extraOperationSucceededToJSON();
            --remainder;
          }
        if (flagHasErrorMessage)
          {
            if (remainder == 0)
                return extraErrorMessageToJSON();
            --remainder;
          }
        if (flagHasWarnings)
          {
            if (remainder == 0)
                return extraWarningsToJSON();
            --remainder;
          }
        if (flagHasSurvey)
          {
            if (remainder == 0)
                return extraSurveyToJSON();
            --remainder;
          }
        return extraSurveyAPIResultComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "rrorMessage", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasErrorMessage ? extraErrorMessageToJSON() : null);
                break;
            case 'O':
                if ((String.Compare(field_name, 1, "perationSucceeded", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasOperationSucceeded ? extraOperationSucceededToJSON() : null);
                break;
            case 'S':
                if (String.Compare(field_name, 1, "urvey", 0, 5, false) == 0)
                  {
                    if (field_name.Length == 6)
                      {
                        return (flagHasSurvey ? extraSurveyToJSON() : null);
                      }
                    switch (field_name[6])
                      {
                        case 'R':
                            if ((String.Compare(field_name, 7, "equestKind", 0, 10, false) == 0) && (field_name.Length == 17))
                                return (flagHasSurveyRequestKind ? extraSurveyRequestKindToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if ((String.Compare(field_name, 1, "arnings", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasWarnings ? extraWarningsToJSON() : null);
                break;
            default:
                break;
          }
        return extraSurveyAPIResultLookup(field_name);
      }

    public void setSurveyRequestKind(BigInteger new_value)
      {
        flagHasSurveyRequestKind = true;
        if (new_value < 0)
            throw new Exception("The value for field SurveyRequestKind of SurveyAPIResultJSON is less than the lower bound (0) for that field.");
        storeSurveyRequestKind = new_value;
      }
    public void unsetSurveyRequestKind()
      {
        flagHasSurveyRequestKind = false;
      }
    public void setOperationSucceeded(bool new_value)
      {
        flagHasOperationSucceeded = true;
        storeOperationSucceeded = new_value;
      }
    public void unsetOperationSucceeded()
      {
        flagHasOperationSucceeded = false;
      }
    public void setErrorMessage(string new_value)
      {
        flagHasErrorMessage = true;
        storeErrorMessage = new_value;
      }
    public void unsetErrorMessage()
      {
        flagHasErrorMessage = false;
      }
    public void initWarnings()
      {
        flagHasWarnings = true;
        storeWarnings.Clear();
      }
    public void appendWarnings(string to_append)
      {
        if (!flagHasWarnings)
          {
            flagHasWarnings = true;
            storeWarnings.Clear();
          }
        Debug.Assert(flagHasWarnings);
        storeWarnings.Add(to_append);
      }
    public void unsetWarnings()
      {
        flagHasWarnings = false;
        storeWarnings.Clear();
      }
    public void setSurvey(SurveyJSON  new_value)
      {
        if (flagHasSurvey)
          {
          }
        flagHasSurvey = true;
        storeSurvey = new_value;
      }
    public void unsetSurvey()
      {
        if (flagHasSurvey)
          {
          }
        flagHasSurvey = false;
      }

    public virtual void extraSurveyAPIResultAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSurveyAPIResultSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSurveyAPIResultLookup(key);
        if (old_field == null)
          {
            extraSurveyAPIResultAppendPair(key, new_component);
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
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "rrorMessage", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONErrorMessage(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "perationSucceeded", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONOperationSucceeded(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if (String.Compare(key, 1, "urvey", 0, 5, false) == 0)
                  {
                    if (key.Length == 6)
                      {
                        {
                        fromJSONSurvey(new_component, false);
                        return;
                        }
                      }
                    switch (key[6])
                      {
                        case 'R':
                            if ((String.Compare(key, 7, "equestKind", 0, 10, false) == 0) && (key.Length == 17))
                                {
                                fromJSONSurveyRequestKind(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if ((String.Compare(key, 1, "arnings", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONWarnings(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSurveyAPIResultAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "rrorMessage", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONErrorMessage(new_component, false);
                    return;
                    }
                break;
            case 'O':
                if ((String.Compare(key, 1, "perationSucceeded", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONOperationSucceeded(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if (String.Compare(key, 1, "urvey", 0, 5, false) == 0)
                  {
                    if (key.Length == 6)
                      {
                        {
                        fromJSONSurvey(new_component, false);
                        return;
                        }
                      }
                    switch (key[6])
                      {
                        case 'R':
                            if ((String.Compare(key, 7, "equestKind", 0, 10, false) == 0) && (key.Length == 17))
                                {
                                fromJSONSurveyRequestKind(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if ((String.Compare(key, 1, "arnings", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONWarnings(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSurveyAPIResultSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSurveyRequestKind);
        if (flagHasSurveyRequestKind)
          {
            handler.start_pair("SurveyRequestKind");
            handler.number_value(storeSurveyRequestKind);
          }
        Debug.Assert(partial_allowed || flagHasOperationSucceeded);
        if (flagHasOperationSucceeded)
          {
            handler.start_pair("OperationSucceeded");
            handler.boolean_value(storeOperationSucceeded);
          }
        if (flagHasErrorMessage)
          {
            handler.start_pair("ErrorMessage");
            handler.string_value(storeErrorMessage);
          }
        if (flagHasWarnings)
          {
            handler.start_pair("Warnings");
            handler.start_array();
            for (int num1 = 0; num1 < storeWarnings.Count; ++num1)
              {
                handler.string_value(storeWarnings[num1]);
              }
            handler.finish_array();
          }
        if (flagHasSurvey)
          {
            handler.start_pair("Survey");
            if (partial_allowed)
                storeSurvey.write_partial_as_json(handler);
            else
                storeSurvey.write_as_json(handler);
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
        if (!(hasSurveyRequestKind()))
          {
            return "When parsing the object for %what%, the \"SurveyRequestKind\" field was missing.";
          }
        if (!(hasOperationSucceeded()))
          {
            return "When parsing the object for %what%, the \"OperationSucceeded\" field was missing.";
          }
        return null;
      }

    public static new SurveyAPIResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyAPIResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyAPIResult", ignore_extras);
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
    public static new SurveyAPIResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SurveyAPIResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyAPIResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyAPIResult", ignore_extras);
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
    public static new SurveyAPIResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SurveyAPIResultJSON from_text(string text, bool ignore_extras)
      {
        SurveyAPIResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyAPIResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyAPIResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SurveyAPIResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyAPIResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyAPIResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
    private class FieldHoldingGeneratorSurveyRequestKind : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSurveyRequestKind(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSurveyRequestKind : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSurveyRequestKind(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSurveyRequestKind fieldGeneratorSurveyRequestKind;
        private JSONHoldingBooleanGenerator fieldGeneratorOperationSucceeded;
        private JSONHoldingStringGenerator fieldGeneratorErrorMessage;
        private JSONHoldingStringArrayGenerator fieldGeneratorWarnings;
        private SurveyJSON.HoldingGenerator fieldGeneratorSurvey;
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
            if (!(getCommandResultJSONKey().Equals("SurveyAPIResult")))
                throw new Exception("The key field has a value other than `SurveyAPIResult'.");
            SurveyAPIResultJSON result = new SurveyAPIResultJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyAPIResultAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((SurveyAPIResultJSON )new_result);
          }
        protected void finish(SurveyAPIResultJSON result)
          {
            if (fieldGeneratorSurveyRequestKind.have_value)
              {
                result.setSurveyRequestKind(fieldGeneratorSurveyRequestKind.value);
                fieldGeneratorSurveyRequestKind.have_value = false;
              }
            else if ((!(result.hasSurveyRequestKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SurveyRequestKind\" field was missing.");
              }
            if (fieldGeneratorOperationSucceeded.have_value)
              {
                result.setOperationSucceeded(fieldGeneratorOperationSucceeded.value);
                fieldGeneratorOperationSucceeded.have_value = false;
              }
            else if ((!(result.hasOperationSucceeded())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"OperationSucceeded\" field was missing.");
              }
            if (fieldGeneratorErrorMessage.have_value)
              {
                result.setErrorMessage(fieldGeneratorErrorMessage.value);
                fieldGeneratorErrorMessage.have_value = false;
              }
            if (fieldGeneratorWarnings.have_value)
              {
                result.initWarnings();
                int count = fieldGeneratorWarnings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendWarnings(fieldGeneratorWarnings.value[num]);
                  }
                fieldGeneratorWarnings.value.Clear();
                fieldGeneratorWarnings.have_value = false;
              }
            if (fieldGeneratorSurvey.have_value)
              {
                result.setSurvey(fieldGeneratorSurvey.value);
                fieldGeneratorSurvey.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SurveyAPIResultJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "rrorMessage", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorErrorMessage;
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "perationSucceeded", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorOperationSucceeded;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "urvey", 0, 5, false) == 0)
                      {
                        if (field_name.Length == 6)
                          {
                            return fieldGeneratorSurvey;
                          }
                        switch (field_name[6])
                          {
                            case 'R':
                                if ((String.Compare(field_name, 7, "equestKind", 0, 10, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorSurveyRequestKind;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "arnings", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorWarnings;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSurveyRequestKind = new FieldHoldingGeneratorSurveyRequestKind("field \"SurveyRequestKind\" of the SurveyAPIResult class");
            fieldGeneratorOperationSucceeded = new JSONHoldingBooleanGenerator("field \"OperationSucceeded\" of the SurveyAPIResult class");
            fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the SurveyAPIResult class");
            fieldGeneratorWarnings = new JSONHoldingStringArrayGenerator("field \"Warnings\" of the SurveyAPIResult class");
            fieldGeneratorSurvey = new SurveyJSON.HoldingGenerator("field \"Survey\" of the SurveyAPIResult class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SurveyAPIResult class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSurveyRequestKind = new FieldHoldingGeneratorSurveyRequestKind("field \"SurveyRequestKind\" of the SurveyAPIResult class");
            fieldGeneratorOperationSucceeded = new JSONHoldingBooleanGenerator("field \"OperationSucceeded\" of the SurveyAPIResult class");
            fieldGeneratorErrorMessage = new JSONHoldingStringGenerator("field \"ErrorMessage\" of the SurveyAPIResult class");
            fieldGeneratorWarnings = new JSONHoldingStringArrayGenerator("field \"Warnings\" of the SurveyAPIResult class");
            fieldGeneratorSurvey = new SurveyJSON.HoldingGenerator("field \"Survey\" of the SurveyAPIResult class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SurveyAPIResult class");
          }

        public override void reset()
          {
            fieldGeneratorSurveyRequestKind.reset();
            fieldGeneratorOperationSucceeded.reset();
            fieldGeneratorErrorMessage.reset();
            fieldGeneratorWarnings.reset();
            fieldGeneratorSurvey.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SurveyAPIResultJSON  result)
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
        public SurveyAPIResultJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyAPIResultJSON  result)
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
    protected virtual void handle_result(List<SurveyAPIResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyAPIResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyAPIResultJSON>();
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
    public List<SurveyAPIResultJSON> value;
  };
  };
