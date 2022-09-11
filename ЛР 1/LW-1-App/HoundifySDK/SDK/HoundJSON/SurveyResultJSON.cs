/* file "SurveyResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public abstract class SurveyResultJSON : CommandResultJSON
  {
    public enum TypeStatusCodeKnownValues
      {
        StatusCode_SUCCESS,
        StatusCode_END,
        StatusCode_NO_FORM_ID,
        StatusCode_INVALID_FORM_ID,
        StatusCode_NO_DATA,
        StatusCode_INVALID_QUESTION,
        StatusCode_INVALID_ANSWER,
        StatusCode_INCOMPLETE_FORM,
        StatusCode_NO_ANSWER,
        StatusCode_ANSWER_NOT_UNDERSTOOD,
        StatusCode__none
      };
    public struct TypeStatusCode
      {
        public bool in_known_list;
        public string string_value;
        public TypeStatusCodeKnownValues list_value;
      };

    public static TypeStatusCodeKnownValues  stringToStatusCode(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "NSWER_NOT_UNDERSTOOD", 0, 20, false) == 0) && (chars.Length == 21))
                    return TypeStatusCodeKnownValues.StatusCode_ANSWER_NOT_UNDERSTOOD;
                break;
            case 'E':
                if ((String.Compare(chars, 1, "ND", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeStatusCodeKnownValues.StatusCode_END;
                break;
            case 'I':
                if (String.Compare(chars, 1, "N", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'C':
                            if ((String.Compare(chars, 3, "OMPLETE_FORM", 0, 12, false) == 0) && (chars.Length == 15))
                                return TypeStatusCodeKnownValues.StatusCode_INCOMPLETE_FORM;
                            break;
                        case 'V':
                            if (String.Compare(chars, 3, "ALID_", 0, 5, false) == 0)
                              {
                                switch (chars[8])
                                  {
                                    case 'A':
                                        if ((String.Compare(chars, 9, "NSWER", 0, 5, false) == 0) && (chars.Length == 14))
                                            return TypeStatusCodeKnownValues.StatusCode_INVALID_ANSWER;
                                        break;
                                    case 'F':
                                        if ((String.Compare(chars, 9, "ORM_ID", 0, 6, false) == 0) && (chars.Length == 15))
                                            return TypeStatusCodeKnownValues.StatusCode_INVALID_FORM_ID;
                                        break;
                                    case 'Q':
                                        if ((String.Compare(chars, 9, "UESTION", 0, 7, false) == 0) && (chars.Length == 16))
                                            return TypeStatusCodeKnownValues.StatusCode_INVALID_QUESTION;
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
                break;
            case 'N':
                if (String.Compare(chars, 1, "O_", 0, 2, false) == 0)
                  {
                    switch (chars[3])
                      {
                        case 'A':
                            if ((String.Compare(chars, 4, "NSWER", 0, 5, false) == 0) && (chars.Length == 9))
                                return TypeStatusCodeKnownValues.StatusCode_NO_ANSWER;
                            break;
                        case 'D':
                            if ((String.Compare(chars, 4, "ATA", 0, 3, false) == 0) && (chars.Length == 7))
                                return TypeStatusCodeKnownValues.StatusCode_NO_DATA;
                            break;
                        case 'F':
                            if ((String.Compare(chars, 4, "ORM_ID", 0, 6, false) == 0) && (chars.Length == 10))
                                return TypeStatusCodeKnownValues.StatusCode_NO_FORM_ID;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "UCCESS", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeStatusCodeKnownValues.StatusCode_SUCCESS;
                break;
            default:
                break;
          }
        return TypeStatusCodeKnownValues.StatusCode__none;
      }

    public static string  stringFromStatusCode(TypeStatusCodeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeStatusCodeKnownValues.StatusCode_SUCCESS:
                return "SUCCESS";
            case TypeStatusCodeKnownValues.StatusCode_END:
                return "END";
            case TypeStatusCodeKnownValues.StatusCode_NO_FORM_ID:
                return "NO_FORM_ID";
            case TypeStatusCodeKnownValues.StatusCode_INVALID_FORM_ID:
                return "INVALID_FORM_ID";
            case TypeStatusCodeKnownValues.StatusCode_NO_DATA:
                return "NO_DATA";
            case TypeStatusCodeKnownValues.StatusCode_INVALID_QUESTION:
                return "INVALID_QUESTION";
            case TypeStatusCodeKnownValues.StatusCode_INVALID_ANSWER:
                return "INVALID_ANSWER";
            case TypeStatusCodeKnownValues.StatusCode_INCOMPLETE_FORM:
                return "INCOMPLETE_FORM";
            case TypeStatusCodeKnownValues.StatusCode_NO_ANSWER:
                return "NO_ANSWER";
            case TypeStatusCodeKnownValues.StatusCode_ANSWER_NOT_UNDERSTOOD:
                return "ANSWER_NOT_UNDERSTOOD";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCmdKind;
    private BigInteger storeCmdKind;
    private bool flagHasStatusCode;
    private TypeStatusCode storeStatusCode;
    private bool flagHasSurveyList;
    private List< UintStringPairJSON  > storeSurveyList;
    private bool flagHasSurveyId;
    private BigInteger storeSurveyId;
    private bool flagHasSurveyTitle;
    private string storeSurveyTitle;
    private bool flagHasSurveyCurrentQuestion;
    private BigInteger storeSurveyCurrentQuestion;
    private bool flagHasSurveyQuestionCount;
    private BigInteger storeSurveyQuestionCount;
    private bool flagHasSurveyAnsweredQuestionIds;
    private List< BigInteger > storeSurveyAnsweredQuestionIds;


    private JSONValue  extraCmdKindToJSON()
      {
        JSONIntegerValue generated_integer_CmdKind = new JSONIntegerValue(storeCmdKind);
        return generated_integer_CmdKind;
      }

    private JSONValue  extraStatusCodeToJSON()
      {
        JSONStringValue generated_string_StatusCode;
        if (!(storeStatusCode.in_known_list))
          {
        generated_string_StatusCode = new JSONStringValue(storeStatusCode.string_value);
          }
        else
          {
        switch (storeStatusCode.list_value)
          {
            case TypeStatusCodeKnownValues.StatusCode_SUCCESS:
                generated_string_StatusCode = new JSONStringValue("SUCCESS");
                break;
            case TypeStatusCodeKnownValues.StatusCode_END:
                generated_string_StatusCode = new JSONStringValue("END");
                break;
            case TypeStatusCodeKnownValues.StatusCode_NO_FORM_ID:
                generated_string_StatusCode = new JSONStringValue("NO_FORM_ID");
                break;
            case TypeStatusCodeKnownValues.StatusCode_INVALID_FORM_ID:
                generated_string_StatusCode = new JSONStringValue("INVALID_FORM_ID");
                break;
            case TypeStatusCodeKnownValues.StatusCode_NO_DATA:
                generated_string_StatusCode = new JSONStringValue("NO_DATA");
                break;
            case TypeStatusCodeKnownValues.StatusCode_INVALID_QUESTION:
                generated_string_StatusCode = new JSONStringValue("INVALID_QUESTION");
                break;
            case TypeStatusCodeKnownValues.StatusCode_INVALID_ANSWER:
                generated_string_StatusCode = new JSONStringValue("INVALID_ANSWER");
                break;
            case TypeStatusCodeKnownValues.StatusCode_INCOMPLETE_FORM:
                generated_string_StatusCode = new JSONStringValue("INCOMPLETE_FORM");
                break;
            case TypeStatusCodeKnownValues.StatusCode_NO_ANSWER:
                generated_string_StatusCode = new JSONStringValue("NO_ANSWER");
                break;
            case TypeStatusCodeKnownValues.StatusCode_ANSWER_NOT_UNDERSTOOD:
                generated_string_StatusCode = new JSONStringValue("ANSWER_NOT_UNDERSTOOD");
                break;
            default:
                Debug.Assert(false);
                generated_string_StatusCode = null;
                break;
          }
          }
        return generated_string_StatusCode;
      }

    private JSONValue  extraSurveyListToJSON()
      {
        JSONArrayValue generated_array_1_SurveyList = new JSONArrayValue();
        for (int num1 = 0; num1 < storeSurveyList.Count; ++num1)
          {
            JSONValueHandler handler_SurveyList = new JSONValueHandler();
            storeSurveyList[num1].write_as_json(handler_SurveyList);
            generated_array_1_SurveyList.appendComponent(handler_SurveyList.result);
          }
        return generated_array_1_SurveyList;
      }

    private JSONValue  extraSurveyIdToJSON()
      {
        JSONIntegerValue generated_integer_SurveyId = new JSONIntegerValue(storeSurveyId);
        return generated_integer_SurveyId;
      }

    private JSONValue  extraSurveyTitleToJSON()
      {
        JSONStringValue generated_string_SurveyTitle = new JSONStringValue(storeSurveyTitle);
        return generated_string_SurveyTitle;
      }

    private JSONValue  extraSurveyCurrentQuestionToJSON()
      {
        JSONIntegerValue generated_integer_SurveyCurrentQuestion = new JSONIntegerValue(storeSurveyCurrentQuestion);
        return generated_integer_SurveyCurrentQuestion;
      }

    private JSONValue  extraSurveyQuestionCountToJSON()
      {
        JSONIntegerValue generated_integer_SurveyQuestionCount = new JSONIntegerValue(storeSurveyQuestionCount);
        return generated_integer_SurveyQuestionCount;
      }

    private JSONValue  extraSurveyAnsweredQuestionIdsToJSON()
      {
        JSONArrayValue generated_array_2_SurveyAnsweredQuestionIds = new JSONArrayValue();
        for (int num2 = 0; num2 < storeSurveyAnsweredQuestionIds.Count; ++num2)
          {
            JSONIntegerValue generated_integer_SurveyAnsweredQuestionIds = new JSONIntegerValue(storeSurveyAnsweredQuestionIds[num2]);
            generated_array_2_SurveyAnsweredQuestionIds.appendComponent(generated_integer_SurveyAnsweredQuestionIds);
          }
        return generated_array_2_SurveyAnsweredQuestionIds;
      }


    private void  fromJSONCmdKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CmdKind of SurveyResultJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CmdKind of SurveyResultJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCmdKind(extracted_integer);
      }


    private void  fromJSONStatusCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StatusCode of SurveyResultJSON is not a string.");
        TypeStatusCode the_open_enum = new TypeStatusCode();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "NSWER_NOT_UNDERSTOOD", 0, 20, false) == 0) && (json_string.getData().Length == 21))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusCodeKnownValues.StatusCode_ANSWER_NOT_UNDERSTOOD;
                        goto open_enum_is_done;
                      }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "ND", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusCodeKnownValues.StatusCode_END;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if (String.Compare(json_string.getData(), 1, "N", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'C':
                            if ((String.Compare(json_string.getData(), 3, "OMPLETE_FORM", 0, 12, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeStatusCodeKnownValues.StatusCode_INCOMPLETE_FORM;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'V':
                            if (String.Compare(json_string.getData(), 3, "ALID_", 0, 5, false) == 0)
                              {
                                switch (json_string.getData()[8])
                                  {
                                    case 'A':
                                        if ((String.Compare(json_string.getData(), 9, "NSWER", 0, 5, false) == 0) && (json_string.getData().Length == 14))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeStatusCodeKnownValues.StatusCode_INVALID_ANSWER;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'F':
                                        if ((String.Compare(json_string.getData(), 9, "ORM_ID", 0, 6, false) == 0) && (json_string.getData().Length == 15))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeStatusCodeKnownValues.StatusCode_INVALID_FORM_ID;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'Q':
                                        if ((String.Compare(json_string.getData(), 9, "UESTION", 0, 7, false) == 0) && (json_string.getData().Length == 16))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeStatusCodeKnownValues.StatusCode_INVALID_QUESTION;
                                                goto open_enum_is_done;
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
                break;
            case 'N':
                if (String.Compare(json_string.getData(), 1, "O_", 0, 2, false) == 0)
                  {
                    switch (json_string.getData()[3])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 4, "NSWER", 0, 5, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeStatusCodeKnownValues.StatusCode_NO_ANSWER;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'D':
                            if ((String.Compare(json_string.getData(), 4, "ATA", 0, 3, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeStatusCodeKnownValues.StatusCode_NO_DATA;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'F':
                            if ((String.Compare(json_string.getData(), 4, "ORM_ID", 0, 6, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeStatusCodeKnownValues.StatusCode_NO_FORM_ID;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "UCCESS", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusCodeKnownValues.StatusCode_SUCCESS;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setStatusCode(the_open_enum);
      }


    private void  fromJSONSurveyList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SurveyList of SurveyResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UintStringPairJSON  > vector_SurveyList1 = new List< UintStringPairJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UintStringPairJSON convert_classy = UintStringPairJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_SurveyList1.Add(convert_classy);
          }
        initSurveyList();
        for (int num1 = 0; num1 < vector_SurveyList1.Count; ++num1)
            appendSurveyList(vector_SurveyList1[num1]);
        for (int num1 = 0; num1 < vector_SurveyList1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSurveyId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SurveyId of SurveyResultJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SurveyId of SurveyResultJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSurveyId(extracted_integer);
      }


    private void  fromJSONSurveyTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SurveyTitle of SurveyResultJSON is not a string.");
        setSurveyTitle(json_string.getData());
      }


    private void  fromJSONSurveyCurrentQuestion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SurveyCurrentQuestion of SurveyResultJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SurveyCurrentQuestion of SurveyResultJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSurveyCurrentQuestion(extracted_integer);
      }


    private void  fromJSONSurveyQuestionCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SurveyQuestionCount of SurveyResultJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SurveyQuestionCount of SurveyResultJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSurveyQuestionCount(extracted_integer);
      }


    private void  fromJSONSurveyAnsweredQuestionIds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SurveyAnsweredQuestionIds of SurveyResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_SurveyAnsweredQuestionIds1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field SurveyAnsweredQuestionIds of SurveyResultJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field SurveyAnsweredQuestionIds of SurveyResultJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_SurveyAnsweredQuestionIds1.Add(extracted_integer);
          }
        initSurveyAnsweredQuestionIds();
        for (int num2 = 0; num2 < vector_SurveyAnsweredQuestionIds1.Count; ++num2)
            appendSurveyAnsweredQuestionIds(vector_SurveyAnsweredQuestionIds1[num2]);
        for (int num1 = 0; num1 < vector_SurveyAnsweredQuestionIds1.Count; ++num1)
          {
          }
      }


    public SurveyResultJSON()
      {
        flagHasCmdKind = false;
        flagHasStatusCode = false;
        flagHasSurveyList = false;
        flagHasSurveyId = false;
        flagHasSurveyTitle = false;
        flagHasSurveyCurrentQuestion = false;
        flagHasSurveyQuestionCount = false;
        flagHasSurveyAnsweredQuestionIds = false;
        storeSurveyList = new List< UintStringPairJSON  >();
        storeSurveyAnsweredQuestionIds = new List< BigInteger >();
      }

    public override string  getCommandKind()
      {
        return "SurveyResult";
      }

    public abstract string getSurveyResultType();
    public bool  hasCmdKind()
      {
        return flagHasCmdKind;
      }

    public BigInteger  getCmdKind()
      {
        Debug.Assert(flagHasCmdKind);
        return storeCmdKind;
      }

    public bool  hasStatusCode()
      {
        return flagHasStatusCode;
      }

    public TypeStatusCode  getStatusCode()
      {
        Debug.Assert(flagHasStatusCode);
        return storeStatusCode;
      }

    public string  getStatusCodeAsString()
      {
        TypeStatusCode result = getStatusCode();
        if (result.in_known_list)
            return stringFromStatusCode(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasSurveyList()
      {
        return flagHasSurveyList;
      }

    public int  countOfSurveyList()
      {
        Debug.Assert(flagHasSurveyList);
        return storeSurveyList.Count;
      }

    public UintStringPairJSON   elementOfSurveyList(int element_num)
      {
        Debug.Assert(flagHasSurveyList);
        return storeSurveyList[element_num];
      }

    public List< UintStringPairJSON  >  getSurveyList()
      {
        Debug.Assert(flagHasSurveyList);
        return storeSurveyList;
      }

    public bool  hasSurveyId()
      {
        return flagHasSurveyId;
      }

    public BigInteger  getSurveyId()
      {
        Debug.Assert(flagHasSurveyId);
        return storeSurveyId;
      }

    public bool  hasSurveyTitle()
      {
        return flagHasSurveyTitle;
      }

    public string  getSurveyTitle()
      {
        Debug.Assert(flagHasSurveyTitle);
        return storeSurveyTitle;
      }

    public bool  hasSurveyCurrentQuestion()
      {
        return flagHasSurveyCurrentQuestion;
      }

    public BigInteger  getSurveyCurrentQuestion()
      {
        Debug.Assert(flagHasSurveyCurrentQuestion);
        return storeSurveyCurrentQuestion;
      }

    public bool  hasSurveyQuestionCount()
      {
        return flagHasSurveyQuestionCount;
      }

    public BigInteger  getSurveyQuestionCount()
      {
        Debug.Assert(flagHasSurveyQuestionCount);
        return storeSurveyQuestionCount;
      }

    public bool  hasSurveyAnsweredQuestionIds()
      {
        return flagHasSurveyAnsweredQuestionIds;
      }

    public int  countOfSurveyAnsweredQuestionIds()
      {
        Debug.Assert(flagHasSurveyAnsweredQuestionIds);
        return storeSurveyAnsweredQuestionIds.Count;
      }

    public BigInteger  elementOfSurveyAnsweredQuestionIds(int element_num)
      {
        Debug.Assert(flagHasSurveyAnsweredQuestionIds);
        return storeSurveyAnsweredQuestionIds[element_num];
      }

    public List< BigInteger >  getSurveyAnsweredQuestionIds()
      {
        Debug.Assert(flagHasSurveyAnsweredQuestionIds);
        return storeSurveyAnsweredQuestionIds;
      }


    public abstract int extraSurveyResultComponentCount();
    public abstract string extraSurveyResultComponentKey(int component_num);
    public abstract JSONValue extraSurveyResultComponentValue(int component_num);
    public abstract JSONValue extraSurveyResultLookup(string field_name);
    public override int extraCommandResultComponentCount()
      {
        int result = 1;
        if (flagHasCmdKind)
            ++result;
        if (flagHasStatusCode)
            ++result;
        if (flagHasSurveyList)
            ++result;
        if (flagHasSurveyId)
            ++result;
        if (flagHasSurveyTitle)
            ++result;
        if (flagHasSurveyCurrentQuestion)
            ++result;
        if (flagHasSurveyQuestionCount)
            ++result;
        if (flagHasSurveyAnsweredQuestionIds)
            ++result;
        result += extraSurveyResultComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        if (component_num == 0)
            return "SurveyResultType";
        int remainder = (component_num - 1);
        if (flagHasCmdKind)
          {
            if (remainder == 0)
                return "CmdKind";
            --remainder;
          }
        if (flagHasStatusCode)
          {
            if (remainder == 0)
                return "StatusCode";
            --remainder;
          }
        if (flagHasSurveyList)
          {
            if (remainder == 0)
                return "SurveyList";
            --remainder;
          }
        if (flagHasSurveyId)
          {
            if (remainder == 0)
                return "SurveyId";
            --remainder;
          }
        if (flagHasSurveyTitle)
          {
            if (remainder == 0)
                return "SurveyTitle";
            --remainder;
          }
        if (flagHasSurveyCurrentQuestion)
          {
            if (remainder == 0)
                return "SurveyCurrentQuestion";
            --remainder;
          }
        if (flagHasSurveyQuestionCount)
          {
            if (remainder == 0)
                return "SurveyQuestionCount";
            --remainder;
          }
        if (flagHasSurveyAnsweredQuestionIds)
          {
            if (remainder == 0)
                return "SurveyAnsweredQuestionIds";
            --remainder;
          }
        return extraSurveyResultComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getSurveyResultType());
        int remainder = (component_num - 1);
        if (flagHasCmdKind)
          {
            if (remainder == 0)
                return extraCmdKindToJSON();
            --remainder;
          }
        if (flagHasStatusCode)
          {
            if (remainder == 0)
                return extraStatusCodeToJSON();
            --remainder;
          }
        if (flagHasSurveyList)
          {
            if (remainder == 0)
                return extraSurveyListToJSON();
            --remainder;
          }
        if (flagHasSurveyId)
          {
            if (remainder == 0)
                return extraSurveyIdToJSON();
            --remainder;
          }
        if (flagHasSurveyTitle)
          {
            if (remainder == 0)
                return extraSurveyTitleToJSON();
            --remainder;
          }
        if (flagHasSurveyCurrentQuestion)
          {
            if (remainder == 0)
                return extraSurveyCurrentQuestionToJSON();
            --remainder;
          }
        if (flagHasSurveyQuestionCount)
          {
            if (remainder == 0)
                return extraSurveyQuestionCountToJSON();
            --remainder;
          }
        if (flagHasSurveyAnsweredQuestionIds)
          {
            if (remainder == 0)
                return extraSurveyAnsweredQuestionIdsToJSON();
            --remainder;
          }
        return extraSurveyResultComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "mdKind", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasCmdKind ? extraCmdKindToJSON() : null);
                break;
            case 'S':
                switch (field_name[1])
                  {
                    case 't':
                        if ((String.Compare(field_name, 2, "atusCode", 0, 8, false) == 0) && (field_name.Length == 10))
                            return (flagHasStatusCode ? extraStatusCodeToJSON() : null);
                        break;
                    case 'u':
                        if (String.Compare(field_name, 2, "rvey", 0, 4, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'A':
                                    if ((String.Compare(field_name, 7, "nsweredQuestionIds", 0, 18, false) == 0) && (field_name.Length == 25))
                                        return (flagHasSurveyAnsweredQuestionIds ? extraSurveyAnsweredQuestionIdsToJSON() : null);
                                    break;
                                case 'C':
                                    if ((String.Compare(field_name, 7, "urrentQuestion", 0, 14, false) == 0) && (field_name.Length == 21))
                                        return (flagHasSurveyCurrentQuestion ? extraSurveyCurrentQuestionToJSON() : null);
                                    break;
                                case 'I':
                                    if ((String.Compare(field_name, 7, "d", 0, 1, false) == 0) && (field_name.Length == 8))
                                        return (flagHasSurveyId ? extraSurveyIdToJSON() : null);
                                    break;
                                case 'L':
                                    if ((String.Compare(field_name, 7, "ist", 0, 3, false) == 0) && (field_name.Length == 10))
                                        return (flagHasSurveyList ? extraSurveyListToJSON() : null);
                                    break;
                                case 'Q':
                                    if ((String.Compare(field_name, 7, "uestionCount", 0, 12, false) == 0) && (field_name.Length == 19))
                                        return (flagHasSurveyQuestionCount ? extraSurveyQuestionCountToJSON() : null);
                                    break;
                                case 'R':
                                    if ((String.Compare(field_name, 7, "esultType", 0, 9, false) == 0) && (field_name.Length == 16))
                                        return new JSONStringValue(getSurveyResultType());
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 7, "itle", 0, 4, false) == 0) && (field_name.Length == 11))
                                        return (flagHasSurveyTitle ? extraSurveyTitleToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return extraSurveyResultLookup(field_name);
      }

    public void setCmdKind(BigInteger new_value)
      {
        flagHasCmdKind = true;
        if (new_value < 0)
            throw new Exception("The value for field CmdKind of SurveyResultJSON is less than the lower bound (0) for that field.");
        storeCmdKind = new_value;
      }
    public void unsetCmdKind()
      {
        flagHasCmdKind = false;
      }
    public void setStatusCode(TypeStatusCode new_value)
      {
        flagHasStatusCode = true;
        storeStatusCode = new_value;
      }
    public void setStatusCode(string chars)
      {
        TypeStatusCodeKnownValues known = stringToStatusCode(chars);
        TypeStatusCode new_value = new TypeStatusCode();
        if (known == TypeStatusCodeKnownValues.StatusCode__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setStatusCode(new_value);
      }
    public void setStatusCode(TypeStatusCodeKnownValues new_value)
      {
        TypeStatusCode new_full_value = new TypeStatusCode();
        Debug.Assert(new_value != TypeStatusCodeKnownValues.StatusCode__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setStatusCode(new_full_value);
      }
    public void unsetStatusCode()
      {
        flagHasStatusCode = false;
      }
    public void initSurveyList()
      {
        if (flagHasSurveyList)
          {
            for (int num1 = 0; num1 < storeSurveyList.Count; ++num1)
              {
              }
          }
        flagHasSurveyList = true;
        storeSurveyList.Clear();
      }
    public void appendSurveyList(UintStringPairJSON  to_append)
      {
        if (!flagHasSurveyList)
          {
            flagHasSurveyList = true;
            storeSurveyList.Clear();
          }
        Debug.Assert(flagHasSurveyList);
        storeSurveyList.Add(to_append);
      }
    public void unsetSurveyList()
      {
        if (flagHasSurveyList)
          {
            for (int num2 = 0; num2 < storeSurveyList.Count; ++num2)
              {
              }
          }
        flagHasSurveyList = false;
        storeSurveyList.Clear();
      }
    public void setSurveyId(BigInteger new_value)
      {
        flagHasSurveyId = true;
        if (new_value < 0)
            throw new Exception("The value for field SurveyId of SurveyResultJSON is less than the lower bound (0) for that field.");
        storeSurveyId = new_value;
      }
    public void unsetSurveyId()
      {
        flagHasSurveyId = false;
      }
    public void setSurveyTitle(string new_value)
      {
        flagHasSurveyTitle = true;
        storeSurveyTitle = new_value;
      }
    public void unsetSurveyTitle()
      {
        flagHasSurveyTitle = false;
      }
    public void setSurveyCurrentQuestion(BigInteger new_value)
      {
        flagHasSurveyCurrentQuestion = true;
        if (new_value < 0)
            throw new Exception("The value for field SurveyCurrentQuestion of SurveyResultJSON is less than the lower bound (0) for that field.");
        storeSurveyCurrentQuestion = new_value;
      }
    public void unsetSurveyCurrentQuestion()
      {
        flagHasSurveyCurrentQuestion = false;
      }
    public void setSurveyQuestionCount(BigInteger new_value)
      {
        flagHasSurveyQuestionCount = true;
        if (new_value < 0)
            throw new Exception("The value for field SurveyQuestionCount of SurveyResultJSON is less than the lower bound (0) for that field.");
        storeSurveyQuestionCount = new_value;
      }
    public void unsetSurveyQuestionCount()
      {
        flagHasSurveyQuestionCount = false;
      }
    public void initSurveyAnsweredQuestionIds()
      {
        flagHasSurveyAnsweredQuestionIds = true;
        storeSurveyAnsweredQuestionIds.Clear();
      }
    public void appendSurveyAnsweredQuestionIds(BigInteger to_append)
      {
        if (!flagHasSurveyAnsweredQuestionIds)
          {
            flagHasSurveyAnsweredQuestionIds = true;
            storeSurveyAnsweredQuestionIds.Clear();
          }
        Debug.Assert(flagHasSurveyAnsweredQuestionIds);
        storeSurveyAnsweredQuestionIds.Add(to_append);
      }
    public void unsetSurveyAnsweredQuestionIds()
      {
        flagHasSurveyAnsweredQuestionIds = false;
        storeSurveyAnsweredQuestionIds.Clear();
      }

    public abstract void extraSurveyResultAppendPair(string key, JSONValue new_component);
    public abstract void extraSurveyResultSetField(string key, JSONValue new_component);
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "mdKind", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONCmdKind(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 't':
                        if ((String.Compare(key, 2, "atusCode", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONStatusCode(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if (String.Compare(key, 2, "rvey", 0, 4, false) == 0)
                          {
                            switch (key[6])
                              {
                                case 'A':
                                    if ((String.Compare(key, 7, "nsweredQuestionIds", 0, 18, false) == 0) && (key.Length == 25))
                                        {
                                        fromJSONSurveyAnsweredQuestionIds(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'C':
                                    if ((String.Compare(key, 7, "urrentQuestion", 0, 14, false) == 0) && (key.Length == 21))
                                        {
                                        fromJSONSurveyCurrentQuestion(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'I':
                                    if ((String.Compare(key, 7, "d", 0, 1, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONSurveyId(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'L':
                                    if ((String.Compare(key, 7, "ist", 0, 3, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONSurveyList(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'Q':
                                    if ((String.Compare(key, 7, "uestionCount", 0, 12, false) == 0) && (key.Length == 19))
                                        {
                                        fromJSONSurveyQuestionCount(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'R':
                                    if ((String.Compare(key, 7, "esultType", 0, 9, false) == 0) && (key.Length == 16))
                                        return;
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 7, "itle", 0, 4, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONSurveyTitle(new_component, false);
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
                break;
            default:
                break;
          }
        extraSurveyResultAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "mdKind", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONCmdKind(new_component, false);
                    return;
                    }
                break;
            case 'S':
                switch (key[1])
                  {
                    case 't':
                        if ((String.Compare(key, 2, "atusCode", 0, 8, false) == 0) && (key.Length == 10))
                            {
                            fromJSONStatusCode(new_component, false);
                            return;
                            }
                        break;
                    case 'u':
                        if (String.Compare(key, 2, "rvey", 0, 4, false) == 0)
                          {
                            switch (key[6])
                              {
                                case 'A':
                                    if ((String.Compare(key, 7, "nsweredQuestionIds", 0, 18, false) == 0) && (key.Length == 25))
                                        {
                                        fromJSONSurveyAnsweredQuestionIds(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'C':
                                    if ((String.Compare(key, 7, "urrentQuestion", 0, 14, false) == 0) && (key.Length == 21))
                                        {
                                        fromJSONSurveyCurrentQuestion(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'I':
                                    if ((String.Compare(key, 7, "d", 0, 1, false) == 0) && (key.Length == 8))
                                        {
                                        fromJSONSurveyId(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'L':
                                    if ((String.Compare(key, 7, "ist", 0, 3, false) == 0) && (key.Length == 10))
                                        {
                                        fromJSONSurveyList(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'Q':
                                    if ((String.Compare(key, 7, "uestionCount", 0, 12, false) == 0) && (key.Length == 19))
                                        {
                                        fromJSONSurveyQuestionCount(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'R':
                                    if ((String.Compare(key, 7, "esultType", 0, 9, false) == 0) && (key.Length == 16))
                                        return;
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 7, "itle", 0, 4, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONSurveyTitle(new_component, false);
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
                break;
            default:
                break;
          }
        extraSurveyResultSetField(key, new_component);
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
        handler.pair("SurveyResultType", getSurveyResultType());
        Debug.Assert(partial_allowed || flagHasCmdKind);
        if (flagHasCmdKind)
          {
            handler.start_pair("CmdKind");
            handler.number_value(storeCmdKind);
          }
        Debug.Assert(partial_allowed || flagHasStatusCode);
        if (flagHasStatusCode)
          {
            handler.start_pair("StatusCode");
            if (storeStatusCode.in_known_list)
              {
                switch (storeStatusCode.list_value)
                  {
                    case TypeStatusCodeKnownValues.StatusCode_SUCCESS:
                        handler.string_value("SUCCESS");
                        break;
                    case TypeStatusCodeKnownValues.StatusCode_END:
                        handler.string_value("END");
                        break;
                    case TypeStatusCodeKnownValues.StatusCode_NO_FORM_ID:
                        handler.string_value("NO_FORM_ID");
                        break;
                    case TypeStatusCodeKnownValues.StatusCode_INVALID_FORM_ID:
                        handler.string_value("INVALID_FORM_ID");
                        break;
                    case TypeStatusCodeKnownValues.StatusCode_NO_DATA:
                        handler.string_value("NO_DATA");
                        break;
                    case TypeStatusCodeKnownValues.StatusCode_INVALID_QUESTION:
                        handler.string_value("INVALID_QUESTION");
                        break;
                    case TypeStatusCodeKnownValues.StatusCode_INVALID_ANSWER:
                        handler.string_value("INVALID_ANSWER");
                        break;
                    case TypeStatusCodeKnownValues.StatusCode_INCOMPLETE_FORM:
                        handler.string_value("INCOMPLETE_FORM");
                        break;
                    case TypeStatusCodeKnownValues.StatusCode_NO_ANSWER:
                        handler.string_value("NO_ANSWER");
                        break;
                    case TypeStatusCodeKnownValues.StatusCode_ANSWER_NOT_UNDERSTOOD:
                        handler.string_value("ANSWER_NOT_UNDERSTOOD");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeStatusCode.string_value);
              }
          }
        if (flagHasSurveyList)
          {
            handler.start_pair("SurveyList");
            handler.start_array();
            for (int num1 = 0; num1 < storeSurveyList.Count; ++num1)
              {
                if (partial_allowed)
                    storeSurveyList[num1].write_partial_as_json(handler);
                else
                    storeSurveyList[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSurveyId)
          {
            handler.start_pair("SurveyId");
            handler.number_value(storeSurveyId);
          }
        if (flagHasSurveyTitle)
          {
            handler.start_pair("SurveyTitle");
            handler.string_value(storeSurveyTitle);
          }
        if (flagHasSurveyCurrentQuestion)
          {
            handler.start_pair("SurveyCurrentQuestion");
            handler.number_value(storeSurveyCurrentQuestion);
          }
        if (flagHasSurveyQuestionCount)
          {
            handler.start_pair("SurveyQuestionCount");
            handler.number_value(storeSurveyQuestionCount);
          }
        if (flagHasSurveyAnsweredQuestionIds)
          {
            handler.start_pair("SurveyAnsweredQuestionIds");
            handler.start_array();
            for (int num2 = 0; num2 < storeSurveyAnsweredQuestionIds.Count; ++num2)
              {
                handler.number_value(storeSurveyAnsweredQuestionIds[num2]);
              }
            handler.finish_array();
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
        if (!(hasCmdKind()))
          {
            return "When parsing the object for %what%, the \"CmdKind\" field was missing.";
          }
        if (!(hasStatusCode()))
          {
            return "When parsing the object for %what%, the \"StatusCode\" field was missing.";
          }
        return null;
      }

    public static new SurveyResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyResult", ignore_extras);
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
    public static new SurveyResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SurveyResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyResult", ignore_extras);
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
    public static new SurveyResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SurveyResultJSON from_text(string text, bool ignore_extras)
      {
        SurveyResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SurveyResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
    private class FieldHoldingGeneratorCmdKind : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorCmdKind(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorCmdKind : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorCmdKind(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorCmdKind fieldGeneratorCmdKind;
    private abstract class FieldGeneratorStatusCode : JSONStringGenerator
          {
            protected FieldGeneratorStatusCode(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorStatusCode()
              {
              }
            protected override void handle_result(string result)
              {
                TypeStatusCodeKnownValues known = stringToStatusCode(result);
                TypeStatusCode new_value = new TypeStatusCode();
                if (known == TypeStatusCodeKnownValues.StatusCode__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeStatusCode result);
          };
    private class FieldHoldingGeneratorStatusCode : FieldGeneratorStatusCode
  {
    protected override void handle_result(TypeStatusCode result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorStatusCode(String what)
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
    public TypeStatusCode value;
  };
    private class FieldHoldingArrayGeneratorStatusCode : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStatusCode
      {
        private FieldHoldingArrayGeneratorStatusCode top;

        protected override void handle_result(TypeStatusCode result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStatusCode init_top)
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
    protected virtual void handle_result(List<TypeStatusCode> result)
      {
      }

    public FieldHoldingArrayGeneratorStatusCode(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatusCode>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStatusCode()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatusCode>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeStatusCode> value;
  };
        private FieldHoldingGeneratorStatusCode fieldGeneratorStatusCode;
        private UintStringPairJSON.HoldingArrayGenerator fieldGeneratorSurveyList;
    private class FieldHoldingGeneratorSurveyId : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSurveyId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSurveyId : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSurveyId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSurveyId fieldGeneratorSurveyId;
        private JSONHoldingStringGenerator fieldGeneratorSurveyTitle;
    private class FieldHoldingGeneratorSurveyCurrentQuestion : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSurveyCurrentQuestion(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSurveyCurrentQuestion : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSurveyCurrentQuestion(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSurveyCurrentQuestion fieldGeneratorSurveyCurrentQuestion;
    private class FieldHoldingGeneratorSurveyQuestionCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSurveyQuestionCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSurveyQuestionCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSurveyQuestionCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorSurveyQuestionCount fieldGeneratorSurveyQuestionCount;
    private class FieldHoldingGeneratorSurveyAnsweredQuestionIds : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSurveyAnsweredQuestionIds(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSurveyAnsweredQuestionIds : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSurveyAnsweredQuestionIds(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingArrayGeneratorSurveyAnsweredQuestionIds fieldGeneratorSurveyAnsweredQuestionIds;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `SurveyResultType' field is missing.");
            if (!(getCommandResultJSONKey().Equals("SurveyResult")))
                throw new Exception("The key field has a value other than `SurveyResult'.");
            SurveyResultJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyResultAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getSurveyResultJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `SurveyResultType' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((SurveyResultJSON )new_result);
          }
        protected void finish(SurveyResultJSON result)
          {
            if (fieldGeneratorCmdKind.have_value)
              {
                result.setCmdKind(fieldGeneratorCmdKind.value);
                fieldGeneratorCmdKind.have_value = false;
              }
            else if ((!(result.hasCmdKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CmdKind\" field was missing.");
              }
            if (fieldGeneratorStatusCode.have_value)
              {
                result.setStatusCode(fieldGeneratorStatusCode.value);
                fieldGeneratorStatusCode.have_value = false;
              }
            else if ((!(result.hasStatusCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StatusCode\" field was missing.");
              }
            if (fieldGeneratorSurveyList.have_value)
              {
                result.initSurveyList();
                int count = fieldGeneratorSurveyList.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSurveyList(fieldGeneratorSurveyList.value[num]);
                  }
                fieldGeneratorSurveyList.value.Clear();
                fieldGeneratorSurveyList.have_value = false;
              }
            if (fieldGeneratorSurveyId.have_value)
              {
                result.setSurveyId(fieldGeneratorSurveyId.value);
                fieldGeneratorSurveyId.have_value = false;
              }
            if (fieldGeneratorSurveyTitle.have_value)
              {
                result.setSurveyTitle(fieldGeneratorSurveyTitle.value);
                fieldGeneratorSurveyTitle.have_value = false;
              }
            if (fieldGeneratorSurveyCurrentQuestion.have_value)
              {
                result.setSurveyCurrentQuestion(fieldGeneratorSurveyCurrentQuestion.value);
                fieldGeneratorSurveyCurrentQuestion.have_value = false;
              }
            if (fieldGeneratorSurveyQuestionCount.have_value)
              {
                result.setSurveyQuestionCount(fieldGeneratorSurveyQuestionCount.value);
                fieldGeneratorSurveyQuestionCount.have_value = false;
              }
            if (fieldGeneratorSurveyAnsweredQuestionIds.have_value)
              {
                result.initSurveyAnsweredQuestionIds();
                int count = fieldGeneratorSurveyAnsweredQuestionIds.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSurveyAnsweredQuestionIds(fieldGeneratorSurveyAnsweredQuestionIds.value[num]);
                  }
                fieldGeneratorSurveyAnsweredQuestionIds.value.Clear();
                fieldGeneratorSurveyAnsweredQuestionIds.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SurveyResultJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "mdKind", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorCmdKind;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 't':
                            if ((String.Compare(field_name, 2, "atusCode", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorStatusCode;
                            break;
                        case 'u':
                            if (String.Compare(field_name, 2, "rvey", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 7, "nsweredQuestionIds", 0, 18, false) == 0) && (field_name.Length == 25))
                                            return fieldGeneratorSurveyAnsweredQuestionIds;
                                        break;
                                    case 'C':
                                        if ((String.Compare(field_name, 7, "urrentQuestion", 0, 14, false) == 0) && (field_name.Length == 21))
                                            return fieldGeneratorSurveyCurrentQuestion;
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 7, "d", 0, 1, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorSurveyId;
                                        break;
                                    case 'L':
                                        if ((String.Compare(field_name, 7, "ist", 0, 3, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorSurveyList;
                                        break;
                                    case 'Q':
                                        if ((String.Compare(field_name, 7, "uestionCount", 0, 12, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorSurveyQuestionCount;
                                        break;
                                    case 'R':
                                        if ((String.Compare(field_name, 7, "esultType", 0, 9, false) == 0) && (field_name.Length == 16))
                                            {
                                            keyGenerator.reset();
                                            return keyGenerator;
                                            }
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 7, "itle", 0, 4, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorSurveyTitle;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCmdKind = new FieldHoldingGeneratorCmdKind("field \"CmdKind\" of the SurveyResult class");
            fieldGeneratorStatusCode = new FieldHoldingGeneratorStatusCode("field \"StatusCode\" of the SurveyResult class");
            fieldGeneratorSurveyList = new UintStringPairJSON.HoldingArrayGenerator("field \"SurveyList\" of the SurveyResult class", ignore_extras);
            fieldGeneratorSurveyId = new FieldHoldingGeneratorSurveyId("field \"SurveyId\" of the SurveyResult class");
            fieldGeneratorSurveyTitle = new JSONHoldingStringGenerator("field \"SurveyTitle\" of the SurveyResult class");
            fieldGeneratorSurveyCurrentQuestion = new FieldHoldingGeneratorSurveyCurrentQuestion("field \"SurveyCurrentQuestion\" of the SurveyResult class");
            fieldGeneratorSurveyQuestionCount = new FieldHoldingGeneratorSurveyQuestionCount("field \"SurveyQuestionCount\" of the SurveyResult class");
            fieldGeneratorSurveyAnsweredQuestionIds = new FieldHoldingArrayGeneratorSurveyAnsweredQuestionIds("field \"SurveyAnsweredQuestionIds\" of the SurveyResult class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SurveyResultType\" of the SurveyResult class");
            set_what("the SurveyResult class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCmdKind = new FieldHoldingGeneratorCmdKind("field \"CmdKind\" of the SurveyResult class");
            fieldGeneratorStatusCode = new FieldHoldingGeneratorStatusCode("field \"StatusCode\" of the SurveyResult class");
            fieldGeneratorSurveyList = new UintStringPairJSON.HoldingArrayGenerator("field \"SurveyList\" of the SurveyResult class", false);
            fieldGeneratorSurveyId = new FieldHoldingGeneratorSurveyId("field \"SurveyId\" of the SurveyResult class");
            fieldGeneratorSurveyTitle = new JSONHoldingStringGenerator("field \"SurveyTitle\" of the SurveyResult class");
            fieldGeneratorSurveyCurrentQuestion = new FieldHoldingGeneratorSurveyCurrentQuestion("field \"SurveyCurrentQuestion\" of the SurveyResult class");
            fieldGeneratorSurveyQuestionCount = new FieldHoldingGeneratorSurveyQuestionCount("field \"SurveyQuestionCount\" of the SurveyResult class");
            fieldGeneratorSurveyAnsweredQuestionIds = new FieldHoldingArrayGeneratorSurveyAnsweredQuestionIds("field \"SurveyAnsweredQuestionIds\" of the SurveyResult class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SurveyResultType\" of the SurveyResult class");
            set_what("the SurveyResult class");
          }

        public override void reset()
          {
            fieldGeneratorCmdKind.reset();
            fieldGeneratorStatusCode.reset();
            fieldGeneratorSurveyList.reset();
            fieldGeneratorSurveyId.reset();
            fieldGeneratorSurveyTitle.reset();
            fieldGeneratorSurveyCurrentQuestion.reset();
            fieldGeneratorSurveyQuestionCount.reset();
            fieldGeneratorSurveyAnsweredQuestionIds.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SurveyResultJSON  result)
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
        public SurveyResultJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyResultJSON  result)
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
    protected virtual void handle_result(List<SurveyResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyResultJSON>();
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
    public List<SurveyResultJSON> value;
  };
    class GenericSurveyResultJSON : SurveyResultJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericSurveyResultJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getSurveyResultType()  { return key; }
        public override int extraSurveyResultComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraSurveyResultComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraSurveyResultComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraSurveyResultLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraSurveyResultAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraSurveyResultSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraSurveyResultLookup(key);
            if (old_field == null)
              {
                extraSurveyResultAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
                      {
                        extraValues[num] = new_component;
                        break;
                      }
                  }
                extraIndex.Add(key, new_component);
              }
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
      };
    public static new SurveyResultJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "Survey", 0, 6, false) == 0)
      {
        switch (key[6])
          {
            case 'A':
                if ((String.Compare(key, 7, "ctionResult", 0, 11, false) == 0) && (key.Length == 18))
                    return new SurveyActionResultJSON();
                break;
            case 'I':
                if ((String.Compare(key, 7, "nfoResult", 0, 9, false) == 0) && (key.Length == 16))
                    return new SurveyInfoResultJSON();
                break;
            case 'M':
                if ((String.Compare(key, 7, "odeErrorResult", 0, 14, false) == 0) && (key.Length == 21))
                    return new SurveyModeErrorResultJSON();
                break;
            case 'Q':
                if ((String.Compare(key, 7, "uestionResult", 0, 13, false) == 0) && (key.Length == 20))
                    return new SurveyQuestionResultJSON();
                break;
            default:
                break;
          }
      }

        return new GenericSurveyResultJSON(key);
      }
  };
