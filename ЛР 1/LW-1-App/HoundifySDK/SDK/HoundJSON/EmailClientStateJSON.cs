/* file "EmailClientStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class EmailClientStateJSON : ClientVerticalStateJSON
  {
    public enum TypeCompositionStep
      {
        CompositionStep_Disambiguating,
        CompositionStep_Composing
      };

    public static TypeCompositionStep  stringToCompositionStep(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "omposing", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeCompositionStep.CompositionStep_Composing;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "isambiguating", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeCompositionStep.CompositionStep_Disambiguating;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `CompositionStep' is not one of the legal values.");
      }

    public static string  stringFromCompositionStep(TypeCompositionStep the_enum)
      {
        switch (the_enum)
          {
            case TypeCompositionStep.CompositionStep_Disambiguating:
                return "Disambiguating";
            case TypeCompositionStep.CompositionStep_Composing:
                return "Composing";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCompositionStep;
    private TypeCompositionStep storeCompositionStep;
    private bool flagHasDisambiguationOrderedList;
    private List< string > storeDisambiguationOrderedList;
    private bool flagHasDisambiguateChoiceIds;
    private List< string > storeDisambiguateChoiceIds;
    private bool flagHasEmail;
    private EmailJSON  storeEmail;
    private bool flagHasLastEditedTextFieldType;
    private EmailFieldTypeJSON  storeLastEditedTextFieldType;


    private JSONValue  extraCompositionStepToJSON()
      {
        JSONStringValue generated_string_CompositionStep;
        switch (storeCompositionStep)
          {
            case TypeCompositionStep.CompositionStep_Disambiguating:
                generated_string_CompositionStep = new JSONStringValue("Disambiguating");
                break;
            case TypeCompositionStep.CompositionStep_Composing:
                generated_string_CompositionStep = new JSONStringValue("Composing");
                break;
            default:
                Debug.Assert(false);
                generated_string_CompositionStep = null;
                break;
          }
        return generated_string_CompositionStep;
      }

    private JSONValue  extraDisambiguationOrderedListToJSON()
      {
        JSONArrayValue generated_array_1_DisambiguationOrderedList = new JSONArrayValue();
        for (int num1 = 0; num1 < storeDisambiguationOrderedList.Count; ++num1)
          {
            JSONStringValue generated_string_DisambiguationOrderedList = new JSONStringValue(storeDisambiguationOrderedList[num1]);
            generated_array_1_DisambiguationOrderedList.appendComponent(generated_string_DisambiguationOrderedList);
          }
        return generated_array_1_DisambiguationOrderedList;
      }

    private JSONValue  extraDisambiguateChoiceIdsToJSON()
      {
        JSONArrayValue generated_array_2_DisambiguateChoiceIds = new JSONArrayValue();
        for (int num2 = 0; num2 < storeDisambiguateChoiceIds.Count; ++num2)
          {
            JSONStringValue generated_string_DisambiguateChoiceIds = new JSONStringValue(storeDisambiguateChoiceIds[num2]);
            generated_array_2_DisambiguateChoiceIds.appendComponent(generated_string_DisambiguateChoiceIds);
          }
        return generated_array_2_DisambiguateChoiceIds;
      }

    private JSONValue  extraEmailToJSON()
      {
        JSONValueHandler handler_Email = new JSONValueHandler();
        storeEmail.write_as_json(handler_Email);
        return handler_Email.result;
      }

    private JSONValue  extraLastEditedTextFieldTypeToJSON()
      {
        JSONValueHandler handler_LastEditedTextFieldType = new JSONValueHandler();
        storeLastEditedTextFieldType.write_as_json(handler_LastEditedTextFieldType);
        return handler_LastEditedTextFieldType.result;
      }


    private void  fromJSONCompositionStep(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CompositionStep of EmailClientStateJSON is not a string.");
        TypeCompositionStep the_enum;
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "omposing", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeCompositionStep.CompositionStep_Composing;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "isambiguating", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_enum = TypeCompositionStep.CompositionStep_Disambiguating;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field CompositionStep of EmailClientStateJSON is not one of the legal strings.");
      enum_is_done:;
        setCompositionStep(the_enum);
      }


    private void  fromJSONDisambiguationOrderedList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DisambiguationOrderedList of EmailClientStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_DisambiguationOrderedList1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field DisambiguationOrderedList of EmailClientStateJSON is not a string.");
            vector_DisambiguationOrderedList1.Add(json_string.getData());
          }
        initDisambiguationOrderedList();
        for (int num1 = 0; num1 < vector_DisambiguationOrderedList1.Count; ++num1)
            appendDisambiguationOrderedList(vector_DisambiguationOrderedList1[num1]);
        for (int num1 = 0; num1 < vector_DisambiguationOrderedList1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDisambiguateChoiceIds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DisambiguateChoiceIds of EmailClientStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_DisambiguateChoiceIds1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field DisambiguateChoiceIds of EmailClientStateJSON is not a string.");
            vector_DisambiguateChoiceIds1.Add(json_string.getData());
          }
        initDisambiguateChoiceIds();
        for (int num2 = 0; num2 < vector_DisambiguateChoiceIds1.Count; ++num2)
            appendDisambiguateChoiceIds(vector_DisambiguateChoiceIds1[num2]);
        for (int num1 = 0; num1 < vector_DisambiguateChoiceIds1.Count; ++num1)
          {
          }
      }


    private void  fromJSONEmail(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmailJSON convert_classy = EmailJSON.from_json(json_value, ignore_extras, true);
        setEmail(convert_classy);
      }


    private void  fromJSONLastEditedTextFieldType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        EmailFieldTypeJSON convert_classy = EmailFieldTypeJSON.from_json(json_value, ignore_extras, true);
        setLastEditedTextFieldType(convert_classy);
      }


    public EmailClientStateJSON()
      {
        flagHasCompositionStep = false;
        flagHasDisambiguationOrderedList = false;
        flagHasDisambiguateChoiceIds = false;
        flagHasEmail = false;
        flagHasLastEditedTextFieldType = false;
        storeDisambiguationOrderedList = new List< string >();
        storeDisambiguateChoiceIds = new List< string >();
      }

    public override string  getClientVerticalStateKind()
      {
        return "EmailClientState";
      }

    public bool  hasCompositionStep()
      {
        return flagHasCompositionStep;
      }

    public TypeCompositionStep  getCompositionStep()
      {
        Debug.Assert(flagHasCompositionStep);
        return storeCompositionStep;
      }

    public string  getCompositionStepAsString()
      {
        return stringFromCompositionStep(getCompositionStep());
      }

    public bool  hasDisambiguationOrderedList()
      {
        return flagHasDisambiguationOrderedList;
      }

    public int  countOfDisambiguationOrderedList()
      {
        Debug.Assert(flagHasDisambiguationOrderedList);
        return storeDisambiguationOrderedList.Count;
      }

    public string  elementOfDisambiguationOrderedList(int element_num)
      {
        Debug.Assert(flagHasDisambiguationOrderedList);
        return storeDisambiguationOrderedList[element_num];
      }

    public List< string >  getDisambiguationOrderedList()
      {
        Debug.Assert(flagHasDisambiguationOrderedList);
        return storeDisambiguationOrderedList;
      }

    public bool  hasDisambiguateChoiceIds()
      {
        return flagHasDisambiguateChoiceIds;
      }

    public int  countOfDisambiguateChoiceIds()
      {
        Debug.Assert(flagHasDisambiguateChoiceIds);
        return storeDisambiguateChoiceIds.Count;
      }

    public string  elementOfDisambiguateChoiceIds(int element_num)
      {
        Debug.Assert(flagHasDisambiguateChoiceIds);
        return storeDisambiguateChoiceIds[element_num];
      }

    public List< string >  getDisambiguateChoiceIds()
      {
        Debug.Assert(flagHasDisambiguateChoiceIds);
        return storeDisambiguateChoiceIds;
      }

    public bool  hasEmail()
      {
        return flagHasEmail;
      }

    public EmailJSON   getEmail()
      {
        Debug.Assert(flagHasEmail);
        return storeEmail;
      }

    public bool  hasLastEditedTextFieldType()
      {
        return flagHasLastEditedTextFieldType;
      }

    public EmailFieldTypeJSON   getLastEditedTextFieldType()
      {
        Debug.Assert(flagHasLastEditedTextFieldType);
        return storeLastEditedTextFieldType;
      }

    public EmailFieldTypeJSON.TypeValue  getLastEditedTextFieldTypeValue()
      {
        return getLastEditedTextFieldType().getValue();
      }

    public string  getLastEditedTextFieldTypeAsString()
      {
        return getLastEditedTextFieldType().getValueAsString();
      }


    public override int extraClientVerticalStateComponentCount()
      {
        int result = 0;
        if (flagHasCompositionStep)
            ++result;
        if (flagHasDisambiguationOrderedList)
            ++result;
        if (flagHasDisambiguateChoiceIds)
            ++result;
        if (flagHasEmail)
            ++result;
        if (flagHasLastEditedTextFieldType)
            ++result;
        return result;
      }
    public override string extraClientVerticalStateComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCompositionStep)
          {
            if (remainder == 0)
                return "CompositionStep";
            --remainder;
          }
        if (flagHasDisambiguationOrderedList)
          {
            if (remainder == 0)
                return "DisambiguationOrderedList";
            --remainder;
          }
        if (flagHasDisambiguateChoiceIds)
          {
            if (remainder == 0)
                return "DisambiguateChoiceIds";
            --remainder;
          }
        if (flagHasEmail)
          {
            if (remainder == 0)
                return "Email";
            --remainder;
          }
        if (flagHasLastEditedTextFieldType)
          {
            if (remainder == 0)
                return "LastEditedTextFieldType";
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraClientVerticalStateComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCompositionStep)
          {
            if (remainder == 0)
                return extraCompositionStepToJSON();
            --remainder;
          }
        if (flagHasDisambiguationOrderedList)
          {
            if (remainder == 0)
                return extraDisambiguationOrderedListToJSON();
            --remainder;
          }
        if (flagHasDisambiguateChoiceIds)
          {
            if (remainder == 0)
                return extraDisambiguateChoiceIdsToJSON();
            --remainder;
          }
        if (flagHasEmail)
          {
            if (remainder == 0)
                return extraEmailToJSON();
            --remainder;
          }
        if (flagHasLastEditedTextFieldType)
          {
            if (remainder == 0)
                return extraLastEditedTextFieldTypeToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraClientVerticalStateLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ompositionStep", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasCompositionStep ? extraCompositionStepToJSON() : null);
                break;
            case 'D':
                if (String.Compare(field_name, 1, "isambiguat", 0, 10, false) == 0)
                  {
                    switch (field_name[11])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 12, "ChoiceIds", 0, 9, false) == 0) && (field_name.Length == 21))
                                return (flagHasDisambiguateChoiceIds ? extraDisambiguateChoiceIdsToJSON() : null);
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 12, "onOrderedList", 0, 13, false) == 0) && (field_name.Length == 25))
                                return (flagHasDisambiguationOrderedList ? extraDisambiguationOrderedListToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "mail", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasEmail ? extraEmailToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "astEditedTextFieldType", 0, 22, false) == 0) && (field_name.Length == 23))
                    return (flagHasLastEditedTextFieldType ? extraLastEditedTextFieldTypeToJSON() : null);
                break;
            default:
                break;
          }
        return null;
      }

    public void setCompositionStep(TypeCompositionStep new_value)
      {
        flagHasCompositionStep = true;
        storeCompositionStep = new_value;
      }
    public void setCompositionStep(string chars)
      {
        setCompositionStep(stringToCompositionStep(chars));
      }
    public void unsetCompositionStep()
      {
        flagHasCompositionStep = false;
      }
    public void initDisambiguationOrderedList()
      {
        flagHasDisambiguationOrderedList = true;
        storeDisambiguationOrderedList.Clear();
      }
    public void appendDisambiguationOrderedList(string to_append)
      {
        if (!flagHasDisambiguationOrderedList)
          {
            flagHasDisambiguationOrderedList = true;
            storeDisambiguationOrderedList.Clear();
          }
        Debug.Assert(flagHasDisambiguationOrderedList);
        storeDisambiguationOrderedList.Add(to_append);
      }
    public void unsetDisambiguationOrderedList()
      {
        flagHasDisambiguationOrderedList = false;
        storeDisambiguationOrderedList.Clear();
      }
    public void initDisambiguateChoiceIds()
      {
        flagHasDisambiguateChoiceIds = true;
        storeDisambiguateChoiceIds.Clear();
      }
    public void appendDisambiguateChoiceIds(string to_append)
      {
        if (!flagHasDisambiguateChoiceIds)
          {
            flagHasDisambiguateChoiceIds = true;
            storeDisambiguateChoiceIds.Clear();
          }
        Debug.Assert(flagHasDisambiguateChoiceIds);
        storeDisambiguateChoiceIds.Add(to_append);
      }
    public void unsetDisambiguateChoiceIds()
      {
        flagHasDisambiguateChoiceIds = false;
        storeDisambiguateChoiceIds.Clear();
      }
    public void setEmail(EmailJSON  new_value)
      {
        if (flagHasEmail)
          {
          }
        flagHasEmail = true;
        storeEmail = new_value;
      }
    public void unsetEmail()
      {
        if (flagHasEmail)
          {
          }
        flagHasEmail = false;
      }
    public void setLastEditedTextFieldType(EmailFieldTypeJSON  new_value)
      {
        if (flagHasLastEditedTextFieldType)
          {
          }
        flagHasLastEditedTextFieldType = true;
        storeLastEditedTextFieldType = new_value;
      }
    public void setLastEditedTextFieldType(EmailFieldTypeJSON.TypeValue new_value)
      {
        setLastEditedTextFieldType(new EmailFieldTypeJSON(new_value));
      }
    public void setLastEditedTextFieldType(string chars)
      {
        setLastEditedTextFieldType(new EmailFieldTypeJSON(chars));
      }
    public void unsetLastEditedTextFieldType()
      {
        if (flagHasLastEditedTextFieldType)
          {
          }
        flagHasLastEditedTextFieldType = false;
      }

    public override void extraClientVerticalStateAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ompositionStep", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONCompositionStep(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if (String.Compare(key, 1, "isambiguat", 0, 10, false) == 0)
                  {
                    switch (key[11])
                      {
                        case 'e':
                            if ((String.Compare(key, 12, "ChoiceIds", 0, 9, false) == 0) && (key.Length == 21))
                                {
                                fromJSONDisambiguateChoiceIds(new_component, false);
                                return;
                                }
                            break;
                        case 'i':
                            if ((String.Compare(key, 12, "onOrderedList", 0, 13, false) == 0) && (key.Length == 25))
                                {
                                fromJSONDisambiguationOrderedList(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(key, 1, "mail", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONEmail(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "astEditedTextFieldType", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONLastEditedTextFieldType(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
      }
    public override void extraClientVerticalStateSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ompositionStep", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONCompositionStep(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if (String.Compare(key, 1, "isambiguat", 0, 10, false) == 0)
                  {
                    switch (key[11])
                      {
                        case 'e':
                            if ((String.Compare(key, 12, "ChoiceIds", 0, 9, false) == 0) && (key.Length == 21))
                                {
                                fromJSONDisambiguateChoiceIds(new_component, false);
                                return;
                                }
                            break;
                        case 'i':
                            if ((String.Compare(key, 12, "onOrderedList", 0, 13, false) == 0) && (key.Length == 25))
                                {
                                fromJSONDisambiguationOrderedList(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'E':
                if ((String.Compare(key, 1, "mail", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONEmail(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "astEditedTextFieldType", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONLastEditedTextFieldType(new_component, false);
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
        Debug.Assert(partial_allowed || flagHasCompositionStep);
        if (flagHasCompositionStep)
          {
            handler.start_pair("CompositionStep");
            switch (storeCompositionStep)
              {
                case TypeCompositionStep.CompositionStep_Disambiguating:
                    handler.string_value("Disambiguating");
                    break;
                case TypeCompositionStep.CompositionStep_Composing:
                    handler.string_value("Composing");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasDisambiguationOrderedList)
          {
            handler.start_pair("DisambiguationOrderedList");
            handler.start_array();
            for (int num1 = 0; num1 < storeDisambiguationOrderedList.Count; ++num1)
              {
                handler.string_value(storeDisambiguationOrderedList[num1]);
              }
            handler.finish_array();
          }
        if (flagHasDisambiguateChoiceIds)
          {
            handler.start_pair("DisambiguateChoiceIds");
            handler.start_array();
            for (int num2 = 0; num2 < storeDisambiguateChoiceIds.Count; ++num2)
              {
                handler.string_value(storeDisambiguateChoiceIds[num2]);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasEmail);
        if (flagHasEmail)
          {
            handler.start_pair("Email");
            if (partial_allowed)
                storeEmail.write_partial_as_json(handler);
            else
                storeEmail.write_as_json(handler);
          }
        if (flagHasLastEditedTextFieldType)
          {
            handler.start_pair("LastEditedTextFieldType");
            if (partial_allowed)
                storeLastEditedTextFieldType.write_partial_as_json(handler);
            else
                storeLastEditedTextFieldType.write_as_json(handler);
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
        if (!(hasCompositionStep()))
          {
            return "When parsing the object for %what%, the \"CompositionStep\" field was missing.";
          }
        if (!(hasEmail()))
          {
            return "When parsing the object for %what%, the \"Email\" field was missing.";
          }
        return null;
      }

    public static new EmailClientStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailClientState", ignore_extras);
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
    public static new EmailClientStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new EmailClientStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EmailClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailClientState", ignore_extras);
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
    public static new EmailClientStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new EmailClientStateJSON from_text(string text, bool ignore_extras)
      {
        EmailClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailClientState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EmailClientStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new EmailClientStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EmailClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EmailClientState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ClientVerticalStateJSON.Generator
      {
    private abstract class FieldGeneratorCompositionStep : JSONStringGenerator
          {
            protected FieldGeneratorCompositionStep(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCompositionStep()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCompositionStep(result));
              }
            protected abstract void handle_result(TypeCompositionStep result);
          };
    private class FieldHoldingGeneratorCompositionStep : FieldGeneratorCompositionStep
  {
    protected override void handle_result(TypeCompositionStep result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCompositionStep(String what)
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
    public TypeCompositionStep value;
  };
    private class FieldHoldingArrayGeneratorCompositionStep : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCompositionStep
      {
        private FieldHoldingArrayGeneratorCompositionStep top;

        protected override void handle_result(TypeCompositionStep result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCompositionStep init_top)
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
    protected virtual void handle_result(List<TypeCompositionStep> result)
      {
      }

    public FieldHoldingArrayGeneratorCompositionStep(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCompositionStep>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCompositionStep()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCompositionStep>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCompositionStep> value;
  };
        private FieldHoldingGeneratorCompositionStep fieldGeneratorCompositionStep;
        private JSONHoldingStringArrayGenerator fieldGeneratorDisambiguationOrderedList;
        private JSONHoldingStringArrayGenerator fieldGeneratorDisambiguateChoiceIds;
        private EmailJSON.HoldingGenerator fieldGeneratorEmail;
        private EmailFieldTypeJSON.HoldingGenerator fieldGeneratorLastEditedTextFieldType;

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
            if (!(getClientVerticalStateJSONKey().Equals("EmailClientState")))
                throw new Exception("The key field has a value other than `EmailClientState'.");
            EmailClientStateJSON result = new EmailClientStateJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(ClientVerticalStateJSON new_result)
          {
            handle_result((EmailClientStateJSON )new_result);
          }
        protected void finish(EmailClientStateJSON result)
          {
            if (fieldGeneratorCompositionStep.have_value)
              {
                result.setCompositionStep(fieldGeneratorCompositionStep.value);
                fieldGeneratorCompositionStep.have_value = false;
              }
            else if ((!(result.hasCompositionStep())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CompositionStep\" field was missing.");
              }
            if (fieldGeneratorDisambiguationOrderedList.have_value)
              {
                result.initDisambiguationOrderedList();
                int count = fieldGeneratorDisambiguationOrderedList.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDisambiguationOrderedList(fieldGeneratorDisambiguationOrderedList.value[num]);
                  }
                fieldGeneratorDisambiguationOrderedList.value.Clear();
                fieldGeneratorDisambiguationOrderedList.have_value = false;
              }
            if (fieldGeneratorDisambiguateChoiceIds.have_value)
              {
                result.initDisambiguateChoiceIds();
                int count = fieldGeneratorDisambiguateChoiceIds.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDisambiguateChoiceIds(fieldGeneratorDisambiguateChoiceIds.value[num]);
                  }
                fieldGeneratorDisambiguateChoiceIds.value.Clear();
                fieldGeneratorDisambiguateChoiceIds.have_value = false;
              }
            if (fieldGeneratorEmail.have_value)
              {
                result.setEmail(fieldGeneratorEmail.value);
                fieldGeneratorEmail.have_value = false;
              }
            else if ((!(result.hasEmail())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Email\" field was missing.");
              }
            if (fieldGeneratorLastEditedTextFieldType.have_value)
              {
                result.setLastEditedTextFieldType(fieldGeneratorLastEditedTextFieldType.value);
                fieldGeneratorLastEditedTextFieldType.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(EmailClientStateJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ompositionStep", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorCompositionStep;
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "isambiguat", 0, 10, false) == 0)
                      {
                        switch (field_name[11])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 12, "ChoiceIds", 0, 9, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorDisambiguateChoiceIds;
                                break;
                            case 'i':
                                if ((String.Compare(field_name, 12, "onOrderedList", 0, 13, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorDisambiguationOrderedList;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "mail", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorEmail;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astEditedTextFieldType", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorLastEditedTextFieldType;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCompositionStep = new FieldHoldingGeneratorCompositionStep("field \"CompositionStep\" of the EmailClientState class");
            fieldGeneratorDisambiguationOrderedList = new JSONHoldingStringArrayGenerator("field \"DisambiguationOrderedList\" of the EmailClientState class");
            fieldGeneratorDisambiguateChoiceIds = new JSONHoldingStringArrayGenerator("field \"DisambiguateChoiceIds\" of the EmailClientState class");
            fieldGeneratorEmail = new EmailJSON.HoldingGenerator("field \"Email\" of the EmailClientState class", ignore_extras);
            fieldGeneratorLastEditedTextFieldType = new EmailFieldTypeJSON.HoldingGenerator("field \"LastEditedTextFieldType\" of the EmailClientState class", ignore_extras);
            set_what("the EmailClientState class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCompositionStep = new FieldHoldingGeneratorCompositionStep("field \"CompositionStep\" of the EmailClientState class");
            fieldGeneratorDisambiguationOrderedList = new JSONHoldingStringArrayGenerator("field \"DisambiguationOrderedList\" of the EmailClientState class");
            fieldGeneratorDisambiguateChoiceIds = new JSONHoldingStringArrayGenerator("field \"DisambiguateChoiceIds\" of the EmailClientState class");
            fieldGeneratorEmail = new EmailJSON.HoldingGenerator("field \"Email\" of the EmailClientState class", false);
            fieldGeneratorLastEditedTextFieldType = new EmailFieldTypeJSON.HoldingGenerator("field \"LastEditedTextFieldType\" of the EmailClientState class", false);
            set_what("the EmailClientState class");
          }

        public override void reset()
          {
            fieldGeneratorCompositionStep.reset();
            fieldGeneratorDisambiguationOrderedList.reset();
            fieldGeneratorDisambiguateChoiceIds.reset();
            fieldGeneratorEmail.reset();
            fieldGeneratorLastEditedTextFieldType.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(EmailClientStateJSON  result)
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
        public EmailClientStateJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EmailClientStateJSON  result)
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
    protected virtual void handle_result(List<EmailClientStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EmailClientStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EmailClientStateJSON>();
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
    public List<EmailClientStateJSON> value;
  };
  };
