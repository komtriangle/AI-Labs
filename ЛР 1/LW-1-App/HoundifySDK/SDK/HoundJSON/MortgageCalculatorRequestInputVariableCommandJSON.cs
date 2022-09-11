/* file "MortgageCalculatorRequestInputVariableCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MortgageCalculatorRequestInputVariableCommandJSON : MortgageCalculatorCommandJSON
  {
    public enum TypeVariableRequestedKnownValues
      {
        VariableRequested_Principal,
        VariableRequested_InterestRate,
        VariableRequested_AmortizationPeriod,
        VariableRequested_HomeValue,
        VariableRequested_DownPayment,
        VariableRequested_Payment,
        VariableRequested_TimeRange,
        VariableRequested_TimePoint,
        VariableRequested_DisambiguatePrincipalOrHomeValue,
        VariableRequested__none
      };
    public struct TypeVariableRequested
      {
        public bool in_known_list;
        public string string_value;
        public TypeVariableRequestedKnownValues list_value;
      };

    public static TypeVariableRequestedKnownValues  stringToVariableRequested(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "mortizationPeriod", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeVariableRequestedKnownValues.VariableRequested_AmortizationPeriod;
                break;
            case 'D':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "sambiguatePrincipalOrHomeValue", 0, 30, false) == 0) && (chars.Length == 32))
                            return TypeVariableRequestedKnownValues.VariableRequested_DisambiguatePrincipalOrHomeValue;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "wnPayment", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeVariableRequestedKnownValues.VariableRequested_DownPayment;
                        break;
                    default:
                        break;
                  }
                break;
            case 'H':
                if ((String.Compare(chars, 1, "omeValue", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeVariableRequestedKnownValues.VariableRequested_HomeValue;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nterestRate", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeVariableRequestedKnownValues.VariableRequested_InterestRate;
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "yment", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeVariableRequestedKnownValues.VariableRequested_Payment;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "incipal", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeVariableRequestedKnownValues.VariableRequested_Principal;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if (String.Compare(chars, 1, "ime", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'P':
                            if ((String.Compare(chars, 5, "oint", 0, 4, false) == 0) && (chars.Length == 9))
                                return TypeVariableRequestedKnownValues.VariableRequested_TimePoint;
                            break;
                        case 'R':
                            if ((String.Compare(chars, 5, "ange", 0, 4, false) == 0) && (chars.Length == 9))
                                return TypeVariableRequestedKnownValues.VariableRequested_TimeRange;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeVariableRequestedKnownValues.VariableRequested__none;
      }

    public static string  stringFromVariableRequested(TypeVariableRequestedKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeVariableRequestedKnownValues.VariableRequested_Principal:
                return "Principal";
            case TypeVariableRequestedKnownValues.VariableRequested_InterestRate:
                return "InterestRate";
            case TypeVariableRequestedKnownValues.VariableRequested_AmortizationPeriod:
                return "AmortizationPeriod";
            case TypeVariableRequestedKnownValues.VariableRequested_HomeValue:
                return "HomeValue";
            case TypeVariableRequestedKnownValues.VariableRequested_DownPayment:
                return "DownPayment";
            case TypeVariableRequestedKnownValues.VariableRequested_Payment:
                return "Payment";
            case TypeVariableRequestedKnownValues.VariableRequested_TimeRange:
                return "TimeRange";
            case TypeVariableRequestedKnownValues.VariableRequested_TimePoint:
                return "TimePoint";
            case TypeVariableRequestedKnownValues.VariableRequested_DisambiguatePrincipalOrHomeValue:
                return "DisambiguatePrincipalOrHomeValue";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasInputVariableSets;
    private List< MortgageCalculatorInputVariableSetJSON  > storeInputVariableSets;
    private bool flagHasVariableRequested;
    private TypeVariableRequested storeVariableRequested;
    private bool flagHasApplicableInputVariableSets;
    private List< BigInteger > storeApplicableInputVariableSets;
    private bool flagHasStartMortgageCalculator;
    private bool storeStartMortgageCalculator;
    private bool flagHasUserDoesNotKnowLastVariableRequested;
    private bool storeUserDoesNotKnowLastVariableRequested;
    private bool flagHasUserDesiresLastVariableRequested;
    private bool storeUserDesiresLastVariableRequested;
    private bool flagHasUserIsConfused;
    private bool storeUserIsConfused;
    private bool flagHasLastResponseNotUnderstood;
    private bool storeLastResponseNotUnderstood;
    private bool flagHasConversationStateUsed;
    private bool storeConversationStateUsed;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraInputVariableSetsToJSON()
      {
        JSONArrayValue generated_array_1_InputVariableSets = new JSONArrayValue();
        for (int num1 = 0; num1 < storeInputVariableSets.Count; ++num1)
          {
            JSONValueHandler handler_InputVariableSets = new JSONValueHandler();
            storeInputVariableSets[num1].write_as_json(handler_InputVariableSets);
            generated_array_1_InputVariableSets.appendComponent(handler_InputVariableSets.result);
          }
        return generated_array_1_InputVariableSets;
      }

    private JSONValue  extraVariableRequestedToJSON()
      {
        JSONStringValue generated_string_VariableRequested;
        if (!(storeVariableRequested.in_known_list))
          {
        generated_string_VariableRequested = new JSONStringValue(storeVariableRequested.string_value);
          }
        else
          {
        switch (storeVariableRequested.list_value)
          {
            case TypeVariableRequestedKnownValues.VariableRequested_Principal:
                generated_string_VariableRequested = new JSONStringValue("Principal");
                break;
            case TypeVariableRequestedKnownValues.VariableRequested_InterestRate:
                generated_string_VariableRequested = new JSONStringValue("InterestRate");
                break;
            case TypeVariableRequestedKnownValues.VariableRequested_AmortizationPeriod:
                generated_string_VariableRequested = new JSONStringValue("AmortizationPeriod");
                break;
            case TypeVariableRequestedKnownValues.VariableRequested_HomeValue:
                generated_string_VariableRequested = new JSONStringValue("HomeValue");
                break;
            case TypeVariableRequestedKnownValues.VariableRequested_DownPayment:
                generated_string_VariableRequested = new JSONStringValue("DownPayment");
                break;
            case TypeVariableRequestedKnownValues.VariableRequested_Payment:
                generated_string_VariableRequested = new JSONStringValue("Payment");
                break;
            case TypeVariableRequestedKnownValues.VariableRequested_TimeRange:
                generated_string_VariableRequested = new JSONStringValue("TimeRange");
                break;
            case TypeVariableRequestedKnownValues.VariableRequested_TimePoint:
                generated_string_VariableRequested = new JSONStringValue("TimePoint");
                break;
            case TypeVariableRequestedKnownValues.VariableRequested_DisambiguatePrincipalOrHomeValue:
                generated_string_VariableRequested = new JSONStringValue("DisambiguatePrincipalOrHomeValue");
                break;
            default:
                Debug.Assert(false);
                generated_string_VariableRequested = null;
                break;
          }
          }
        return generated_string_VariableRequested;
      }

    private JSONValue  extraApplicableInputVariableSetsToJSON()
      {
        JSONArrayValue generated_array_2_ApplicableInputVariableSets = new JSONArrayValue();
        for (int num2 = 0; num2 < storeApplicableInputVariableSets.Count; ++num2)
          {
            JSONIntegerValue generated_integer_ApplicableInputVariableSets = new JSONIntegerValue(storeApplicableInputVariableSets[num2]);
            generated_array_2_ApplicableInputVariableSets.appendComponent(generated_integer_ApplicableInputVariableSets);
          }
        return generated_array_2_ApplicableInputVariableSets;
      }

    private JSONValue  extraStartMortgageCalculatorToJSON()
      {
        JSONValue generated_boolean_StartMortgageCalculator = (storeStartMortgageCalculator ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_StartMortgageCalculator;
      }

    private JSONValue  extraUserDoesNotKnowLastVariableRequestedToJSON()
      {
        JSONValue generated_boolean_UserDoesNotKnowLastVariableRequested = (storeUserDoesNotKnowLastVariableRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_UserDoesNotKnowLastVariableRequested;
      }

    private JSONValue  extraUserDesiresLastVariableRequestedToJSON()
      {
        JSONValue generated_boolean_UserDesiresLastVariableRequested = (storeUserDesiresLastVariableRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_UserDesiresLastVariableRequested;
      }

    private JSONValue  extraUserIsConfusedToJSON()
      {
        JSONValue generated_boolean_UserIsConfused = (storeUserIsConfused ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_UserIsConfused;
      }

    private JSONValue  extraLastResponseNotUnderstoodToJSON()
      {
        JSONValue generated_boolean_LastResponseNotUnderstood = (storeLastResponseNotUnderstood ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_LastResponseNotUnderstood;
      }

    private JSONValue  extraConversationStateUsedToJSON()
      {
        JSONValue generated_boolean_ConversationStateUsed = (storeConversationStateUsed ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ConversationStateUsed;
      }


    private void  fromJSONInputVariableSets(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InputVariableSets of MortgageCalculatorRequestInputVariableCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MortgageCalculatorInputVariableSetJSON  > vector_InputVariableSets1 = new List< MortgageCalculatorInputVariableSetJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MortgageCalculatorInputVariableSetJSON convert_classy = MortgageCalculatorInputVariableSetJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InputVariableSets1.Add(convert_classy);
          }
        initInputVariableSets();
        for (int num1 = 0; num1 < vector_InputVariableSets1.Count; ++num1)
            appendInputVariableSets(vector_InputVariableSets1[num1]);
        for (int num1 = 0; num1 < vector_InputVariableSets1.Count; ++num1)
          {
          }
      }


    private void  fromJSONVariableRequested(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field VariableRequested of MortgageCalculatorRequestInputVariableCommandJSON is not a string.");
        TypeVariableRequested the_open_enum = new TypeVariableRequested();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "mortizationPeriod", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_AmortizationPeriod;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "sambiguatePrincipalOrHomeValue", 0, 30, false) == 0) && (json_string.getData().Length == 32))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_DisambiguatePrincipalOrHomeValue;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "wnPayment", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_DownPayment;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "omeValue", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_HomeValue;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nterestRate", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_InterestRate;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "yment", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_Payment;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "incipal", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_Principal;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                if (String.Compare(json_string.getData(), 1, "ime", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'P':
                            if ((String.Compare(json_string.getData(), 5, "oint", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_TimePoint;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'R':
                            if ((String.Compare(json_string.getData(), 5, "ange", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeVariableRequestedKnownValues.VariableRequested_TimeRange;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setVariableRequested(the_open_enum);
      }


    private void  fromJSONApplicableInputVariableSets(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ApplicableInputVariableSets of MortgageCalculatorRequestInputVariableCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_ApplicableInputVariableSets1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field ApplicableInputVariableSets of MortgageCalculatorRequestInputVariableCommandJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field ApplicableInputVariableSets of MortgageCalculatorRequestInputVariableCommandJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_ApplicableInputVariableSets1.Add(extracted_integer);
          }
        initApplicableInputVariableSets();
        for (int num2 = 0; num2 < vector_ApplicableInputVariableSets1.Count; ++num2)
            appendApplicableInputVariableSets(vector_ApplicableInputVariableSets1[num2]);
        for (int num1 = 0; num1 < vector_ApplicableInputVariableSets1.Count; ++num1)
          {
          }
      }


    private void  fromJSONStartMortgageCalculator(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StartMortgageCalculator of MortgageCalculatorRequestInputVariableCommandJSON is not true for false.");
              }
          }
        setStartMortgageCalculator(the_bool);
      }


    private void  fromJSONUserDoesNotKnowLastVariableRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserDoesNotKnowLastVariableRequested of MortgageCalculatorRequestInputVariableCommandJSON is not true for false.");
              }
          }
        setUserDoesNotKnowLastVariableRequested(the_bool);
      }


    private void  fromJSONUserDesiresLastVariableRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserDesiresLastVariableRequested of MortgageCalculatorRequestInputVariableCommandJSON is not true for false.");
              }
          }
        setUserDesiresLastVariableRequested(the_bool);
      }


    private void  fromJSONUserIsConfused(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field UserIsConfused of MortgageCalculatorRequestInputVariableCommandJSON is not true for false.");
              }
          }
        setUserIsConfused(the_bool);
      }


    private void  fromJSONLastResponseNotUnderstood(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field LastResponseNotUnderstood of MortgageCalculatorRequestInputVariableCommandJSON is not true for false.");
              }
          }
        setLastResponseNotUnderstood(the_bool);
      }


    private void  fromJSONConversationStateUsed(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ConversationStateUsed of MortgageCalculatorRequestInputVariableCommandJSON is not true for false.");
              }
          }
        setConversationStateUsed(the_bool);
      }


    public MortgageCalculatorRequestInputVariableCommandJSON()
      {
        flagHasInputVariableSets = false;
        flagHasVariableRequested = false;
        flagHasApplicableInputVariableSets = false;
        flagHasStartMortgageCalculator = false;
        flagHasUserDoesNotKnowLastVariableRequested = false;
        flagHasUserDesiresLastVariableRequested = false;
        flagHasUserIsConfused = false;
        flagHasLastResponseNotUnderstood = false;
        flagHasConversationStateUsed = false;
        storeInputVariableSets = new List< MortgageCalculatorInputVariableSetJSON  >();
        storeApplicableInputVariableSets = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getMortgageCalculatorCommandKind()
      {
        return "MortgageCalculatorRequestInputVariable";
      }

    public bool  hasInputVariableSets()
      {
        return flagHasInputVariableSets;
      }

    public int  countOfInputVariableSets()
      {
        Debug.Assert(flagHasInputVariableSets);
        return storeInputVariableSets.Count;
      }

    public MortgageCalculatorInputVariableSetJSON   elementOfInputVariableSets(int element_num)
      {
        Debug.Assert(flagHasInputVariableSets);
        return storeInputVariableSets[element_num];
      }

    public List< MortgageCalculatorInputVariableSetJSON  >  getInputVariableSets()
      {
        Debug.Assert(flagHasInputVariableSets);
        return storeInputVariableSets;
      }

    public bool  hasVariableRequested()
      {
        return flagHasVariableRequested;
      }

    public TypeVariableRequested  getVariableRequested()
      {
        Debug.Assert(flagHasVariableRequested);
        return storeVariableRequested;
      }

    public string  getVariableRequestedAsString()
      {
        TypeVariableRequested result = getVariableRequested();
        if (result.in_known_list)
            return stringFromVariableRequested(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasApplicableInputVariableSets()
      {
        return flagHasApplicableInputVariableSets;
      }

    public int  countOfApplicableInputVariableSets()
      {
        Debug.Assert(flagHasApplicableInputVariableSets);
        return storeApplicableInputVariableSets.Count;
      }

    public BigInteger  elementOfApplicableInputVariableSets(int element_num)
      {
        Debug.Assert(flagHasApplicableInputVariableSets);
        return storeApplicableInputVariableSets[element_num];
      }

    public List< BigInteger >  getApplicableInputVariableSets()
      {
        Debug.Assert(flagHasApplicableInputVariableSets);
        return storeApplicableInputVariableSets;
      }

    public bool  hasStartMortgageCalculator()
      {
        return flagHasStartMortgageCalculator;
      }

    public bool  getStartMortgageCalculator()
      {
        Debug.Assert(flagHasStartMortgageCalculator);
        return storeStartMortgageCalculator;
      }

    public bool  hasUserDoesNotKnowLastVariableRequested()
      {
        return flagHasUserDoesNotKnowLastVariableRequested;
      }

    public bool  getUserDoesNotKnowLastVariableRequested()
      {
        Debug.Assert(flagHasUserDoesNotKnowLastVariableRequested);
        return storeUserDoesNotKnowLastVariableRequested;
      }

    public bool  hasUserDesiresLastVariableRequested()
      {
        return flagHasUserDesiresLastVariableRequested;
      }

    public bool  getUserDesiresLastVariableRequested()
      {
        Debug.Assert(flagHasUserDesiresLastVariableRequested);
        return storeUserDesiresLastVariableRequested;
      }

    public bool  hasUserIsConfused()
      {
        return flagHasUserIsConfused;
      }

    public bool  getUserIsConfused()
      {
        Debug.Assert(flagHasUserIsConfused);
        return storeUserIsConfused;
      }

    public bool  hasLastResponseNotUnderstood()
      {
        return flagHasLastResponseNotUnderstood;
      }

    public bool  getLastResponseNotUnderstood()
      {
        Debug.Assert(flagHasLastResponseNotUnderstood);
        return storeLastResponseNotUnderstood;
      }

    public bool  hasConversationStateUsed()
      {
        return flagHasConversationStateUsed;
      }

    public bool  getConversationStateUsed()
      {
        Debug.Assert(flagHasConversationStateUsed);
        return storeConversationStateUsed;
      }


    public virtual int extraMortgageCalculatorRequestInputVariableCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorRequestInputVariableCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorRequestInputVariableCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorRequestInputVariableCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMortgageCalculatorCommandComponentCount()
      {
        int result = 0;
        if (flagHasInputVariableSets)
            ++result;
        if (flagHasVariableRequested)
            ++result;
        if (flagHasApplicableInputVariableSets)
            ++result;
        if (flagHasStartMortgageCalculator)
            ++result;
        if (flagHasUserDoesNotKnowLastVariableRequested)
            ++result;
        if (flagHasUserDesiresLastVariableRequested)
            ++result;
        if (flagHasUserIsConfused)
            ++result;
        if (flagHasLastResponseNotUnderstood)
            ++result;
        if (flagHasConversationStateUsed)
            ++result;
        result += extraMortgageCalculatorRequestInputVariableCommandComponentCount();
        return result;
      }
    public override string extraMortgageCalculatorCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasInputVariableSets)
          {
            if (remainder == 0)
                return "InputVariableSets";
            --remainder;
          }
        if (flagHasVariableRequested)
          {
            if (remainder == 0)
                return "VariableRequested";
            --remainder;
          }
        if (flagHasApplicableInputVariableSets)
          {
            if (remainder == 0)
                return "ApplicableInputVariableSets";
            --remainder;
          }
        if (flagHasStartMortgageCalculator)
          {
            if (remainder == 0)
                return "StartMortgageCalculator";
            --remainder;
          }
        if (flagHasUserDoesNotKnowLastVariableRequested)
          {
            if (remainder == 0)
                return "UserDoesNotKnowLastVariableRequested";
            --remainder;
          }
        if (flagHasUserDesiresLastVariableRequested)
          {
            if (remainder == 0)
                return "UserDesiresLastVariableRequested";
            --remainder;
          }
        if (flagHasUserIsConfused)
          {
            if (remainder == 0)
                return "UserIsConfused";
            --remainder;
          }
        if (flagHasLastResponseNotUnderstood)
          {
            if (remainder == 0)
                return "LastResponseNotUnderstood";
            --remainder;
          }
        if (flagHasConversationStateUsed)
          {
            if (remainder == 0)
                return "ConversationStateUsed";
            --remainder;
          }
        return extraMortgageCalculatorRequestInputVariableCommandComponentKey(remainder);
      }
    public override JSONValue extraMortgageCalculatorCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasInputVariableSets)
          {
            if (remainder == 0)
                return extraInputVariableSetsToJSON();
            --remainder;
          }
        if (flagHasVariableRequested)
          {
            if (remainder == 0)
                return extraVariableRequestedToJSON();
            --remainder;
          }
        if (flagHasApplicableInputVariableSets)
          {
            if (remainder == 0)
                return extraApplicableInputVariableSetsToJSON();
            --remainder;
          }
        if (flagHasStartMortgageCalculator)
          {
            if (remainder == 0)
                return extraStartMortgageCalculatorToJSON();
            --remainder;
          }
        if (flagHasUserDoesNotKnowLastVariableRequested)
          {
            if (remainder == 0)
                return extraUserDoesNotKnowLastVariableRequestedToJSON();
            --remainder;
          }
        if (flagHasUserDesiresLastVariableRequested)
          {
            if (remainder == 0)
                return extraUserDesiresLastVariableRequestedToJSON();
            --remainder;
          }
        if (flagHasUserIsConfused)
          {
            if (remainder == 0)
                return extraUserIsConfusedToJSON();
            --remainder;
          }
        if (flagHasLastResponseNotUnderstood)
          {
            if (remainder == 0)
                return extraLastResponseNotUnderstoodToJSON();
            --remainder;
          }
        if (flagHasConversationStateUsed)
          {
            if (remainder == 0)
                return extraConversationStateUsedToJSON();
            --remainder;
          }
        return extraMortgageCalculatorRequestInputVariableCommandComponentValue(remainder);
      }
    public override JSONValue extraMortgageCalculatorCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "pplicableInputVariableSets", 0, 26, false) == 0) && (field_name.Length == 27))
                    return (flagHasApplicableInputVariableSets ? extraApplicableInputVariableSetsToJSON() : null);
                break;
            case 'C':
                if ((String.Compare(field_name, 1, "onversationStateUsed", 0, 20, false) == 0) && (field_name.Length == 21))
                    return (flagHasConversationStateUsed ? extraConversationStateUsedToJSON() : null);
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "nputVariableSets", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasInputVariableSets ? extraInputVariableSetsToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "astResponseNotUnderstood", 0, 24, false) == 0) && (field_name.Length == 25))
                    return (flagHasLastResponseNotUnderstood ? extraLastResponseNotUnderstoodToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tartMortgageCalculator", 0, 22, false) == 0) && (field_name.Length == 23))
                    return (flagHasStartMortgageCalculator ? extraStartMortgageCalculatorToJSON() : null);
                break;
            case 'U':
                if (String.Compare(field_name, 1, "ser", 0, 3, false) == 0)
                  {
                    switch (field_name[4])
                      {
                        case 'D':
                            switch (field_name[5])
                              {
                                case 'e':
                                    if ((String.Compare(field_name, 6, "siresLastVariableRequested", 0, 26, false) == 0) && (field_name.Length == 32))
                                        return (flagHasUserDesiresLastVariableRequested ? extraUserDesiresLastVariableRequestedToJSON() : null);
                                    break;
                                case 'o':
                                    if ((String.Compare(field_name, 6, "esNotKnowLastVariableRequested", 0, 30, false) == 0) && (field_name.Length == 36))
                                        return (flagHasUserDoesNotKnowLastVariableRequested ? extraUserDoesNotKnowLastVariableRequestedToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'I':
                            if ((String.Compare(field_name, 5, "sConfused", 0, 9, false) == 0) && (field_name.Length == 14))
                                return (flagHasUserIsConfused ? extraUserIsConfusedToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(field_name, 1, "ariableRequested", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasVariableRequested ? extraVariableRequestedToJSON() : null);
                break;
            default:
                break;
          }
        return extraMortgageCalculatorRequestInputVariableCommandLookup(field_name);
      }

    public void initInputVariableSets()
      {
        if (flagHasInputVariableSets)
          {
            for (int num1 = 0; num1 < storeInputVariableSets.Count; ++num1)
              {
              }
          }
        flagHasInputVariableSets = true;
        storeInputVariableSets.Clear();
      }
    public void appendInputVariableSets(MortgageCalculatorInputVariableSetJSON  to_append)
      {
        if (!flagHasInputVariableSets)
          {
            flagHasInputVariableSets = true;
            storeInputVariableSets.Clear();
          }
        Debug.Assert(flagHasInputVariableSets);
        storeInputVariableSets.Add(to_append);
      }
    public void unsetInputVariableSets()
      {
        if (flagHasInputVariableSets)
          {
            for (int num2 = 0; num2 < storeInputVariableSets.Count; ++num2)
              {
              }
          }
        flagHasInputVariableSets = false;
        storeInputVariableSets.Clear();
      }
    public void setVariableRequested(TypeVariableRequested new_value)
      {
        flagHasVariableRequested = true;
        storeVariableRequested = new_value;
      }
    public void setVariableRequested(string chars)
      {
        TypeVariableRequestedKnownValues known = stringToVariableRequested(chars);
        TypeVariableRequested new_value = new TypeVariableRequested();
        if (known == TypeVariableRequestedKnownValues.VariableRequested__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setVariableRequested(new_value);
      }
    public void setVariableRequested(TypeVariableRequestedKnownValues new_value)
      {
        TypeVariableRequested new_full_value = new TypeVariableRequested();
        Debug.Assert(new_value != TypeVariableRequestedKnownValues.VariableRequested__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setVariableRequested(new_full_value);
      }
    public void unsetVariableRequested()
      {
        flagHasVariableRequested = false;
      }
    public void initApplicableInputVariableSets()
      {
        flagHasApplicableInputVariableSets = true;
        storeApplicableInputVariableSets.Clear();
      }
    public void appendApplicableInputVariableSets(BigInteger to_append)
      {
        if (!flagHasApplicableInputVariableSets)
          {
            flagHasApplicableInputVariableSets = true;
            storeApplicableInputVariableSets.Clear();
          }
        Debug.Assert(flagHasApplicableInputVariableSets);
        storeApplicableInputVariableSets.Add(to_append);
      }
    public void unsetApplicableInputVariableSets()
      {
        flagHasApplicableInputVariableSets = false;
        storeApplicableInputVariableSets.Clear();
      }
    public void setStartMortgageCalculator(bool new_value)
      {
        flagHasStartMortgageCalculator = true;
        storeStartMortgageCalculator = new_value;
      }
    public void unsetStartMortgageCalculator()
      {
        flagHasStartMortgageCalculator = false;
      }
    public void setUserDoesNotKnowLastVariableRequested(bool new_value)
      {
        flagHasUserDoesNotKnowLastVariableRequested = true;
        storeUserDoesNotKnowLastVariableRequested = new_value;
      }
    public void unsetUserDoesNotKnowLastVariableRequested()
      {
        flagHasUserDoesNotKnowLastVariableRequested = false;
      }
    public void setUserDesiresLastVariableRequested(bool new_value)
      {
        flagHasUserDesiresLastVariableRequested = true;
        storeUserDesiresLastVariableRequested = new_value;
      }
    public void unsetUserDesiresLastVariableRequested()
      {
        flagHasUserDesiresLastVariableRequested = false;
      }
    public void setUserIsConfused(bool new_value)
      {
        flagHasUserIsConfused = true;
        storeUserIsConfused = new_value;
      }
    public void unsetUserIsConfused()
      {
        flagHasUserIsConfused = false;
      }
    public void setLastResponseNotUnderstood(bool new_value)
      {
        flagHasLastResponseNotUnderstood = true;
        storeLastResponseNotUnderstood = new_value;
      }
    public void unsetLastResponseNotUnderstood()
      {
        flagHasLastResponseNotUnderstood = false;
      }
    public void setConversationStateUsed(bool new_value)
      {
        flagHasConversationStateUsed = true;
        storeConversationStateUsed = new_value;
      }
    public void unsetConversationStateUsed()
      {
        flagHasConversationStateUsed = false;
      }

    public virtual void extraMortgageCalculatorRequestInputVariableCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorRequestInputVariableCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorRequestInputVariableCommandLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorRequestInputVariableCommandAppendPair(key, new_component);
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
    public override void extraMortgageCalculatorCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "pplicableInputVariableSets", 0, 26, false) == 0) && (key.Length == 27))
                    {
                    fromJSONApplicableInputVariableSets(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "onversationStateUsed", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONConversationStateUsed(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "nputVariableSets", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONInputVariableSets(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "astResponseNotUnderstood", 0, 24, false) == 0) && (key.Length == 25))
                    {
                    fromJSONLastResponseNotUnderstood(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartMortgageCalculator", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONStartMortgageCalculator(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if (String.Compare(key, 1, "ser", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'D':
                            switch (key[5])
                              {
                                case 'e':
                                    if ((String.Compare(key, 6, "siresLastVariableRequested", 0, 26, false) == 0) && (key.Length == 32))
                                        {
                                        fromJSONUserDesiresLastVariableRequested(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'o':
                                    if ((String.Compare(key, 6, "esNotKnowLastVariableRequested", 0, 30, false) == 0) && (key.Length == 36))
                                        {
                                        fromJSONUserDoesNotKnowLastVariableRequested(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'I':
                            if ((String.Compare(key, 5, "sConfused", 0, 9, false) == 0) && (key.Length == 14))
                                {
                                fromJSONUserIsConfused(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(key, 1, "ariableRequested", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONVariableRequested(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMortgageCalculatorRequestInputVariableCommandAppendPair(key, new_component);
      }
    public override void extraMortgageCalculatorCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "pplicableInputVariableSets", 0, 26, false) == 0) && (key.Length == 27))
                    {
                    fromJSONApplicableInputVariableSets(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if ((String.Compare(key, 1, "onversationStateUsed", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONConversationStateUsed(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "nputVariableSets", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONInputVariableSets(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "astResponseNotUnderstood", 0, 24, false) == 0) && (key.Length == 25))
                    {
                    fromJSONLastResponseNotUnderstood(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartMortgageCalculator", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONStartMortgageCalculator(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if (String.Compare(key, 1, "ser", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'D':
                            switch (key[5])
                              {
                                case 'e':
                                    if ((String.Compare(key, 6, "siresLastVariableRequested", 0, 26, false) == 0) && (key.Length == 32))
                                        {
                                        fromJSONUserDesiresLastVariableRequested(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'o':
                                    if ((String.Compare(key, 6, "esNotKnowLastVariableRequested", 0, 30, false) == 0) && (key.Length == 36))
                                        {
                                        fromJSONUserDoesNotKnowLastVariableRequested(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'I':
                            if ((String.Compare(key, 5, "sConfused", 0, 9, false) == 0) && (key.Length == 14))
                                {
                                fromJSONUserIsConfused(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'V':
                if ((String.Compare(key, 1, "ariableRequested", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONVariableRequested(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMortgageCalculatorRequestInputVariableCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasInputVariableSets);
        if (flagHasInputVariableSets)
          {
            handler.start_pair("InputVariableSets");
            handler.start_array();
            for (int num1 = 0; num1 < storeInputVariableSets.Count; ++num1)
              {
                if (partial_allowed)
                    storeInputVariableSets[num1].write_partial_as_json(handler);
                else
                    storeInputVariableSets[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasVariableRequested);
        if (flagHasVariableRequested)
          {
            handler.start_pair("VariableRequested");
            if (storeVariableRequested.in_known_list)
              {
                switch (storeVariableRequested.list_value)
                  {
                    case TypeVariableRequestedKnownValues.VariableRequested_Principal:
                        handler.string_value("Principal");
                        break;
                    case TypeVariableRequestedKnownValues.VariableRequested_InterestRate:
                        handler.string_value("InterestRate");
                        break;
                    case TypeVariableRequestedKnownValues.VariableRequested_AmortizationPeriod:
                        handler.string_value("AmortizationPeriod");
                        break;
                    case TypeVariableRequestedKnownValues.VariableRequested_HomeValue:
                        handler.string_value("HomeValue");
                        break;
                    case TypeVariableRequestedKnownValues.VariableRequested_DownPayment:
                        handler.string_value("DownPayment");
                        break;
                    case TypeVariableRequestedKnownValues.VariableRequested_Payment:
                        handler.string_value("Payment");
                        break;
                    case TypeVariableRequestedKnownValues.VariableRequested_TimeRange:
                        handler.string_value("TimeRange");
                        break;
                    case TypeVariableRequestedKnownValues.VariableRequested_TimePoint:
                        handler.string_value("TimePoint");
                        break;
                    case TypeVariableRequestedKnownValues.VariableRequested_DisambiguatePrincipalOrHomeValue:
                        handler.string_value("DisambiguatePrincipalOrHomeValue");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeVariableRequested.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasApplicableInputVariableSets);
        if (flagHasApplicableInputVariableSets)
          {
            handler.start_pair("ApplicableInputVariableSets");
            handler.start_array();
            for (int num2 = 0; num2 < storeApplicableInputVariableSets.Count; ++num2)
              {
                handler.number_value(storeApplicableInputVariableSets[num2]);
              }
            handler.finish_array();
          }
        if (flagHasStartMortgageCalculator)
          {
            handler.start_pair("StartMortgageCalculator");
            handler.boolean_value(storeStartMortgageCalculator);
          }
        if (flagHasUserDoesNotKnowLastVariableRequested)
          {
            handler.start_pair("UserDoesNotKnowLastVariableRequested");
            handler.boolean_value(storeUserDoesNotKnowLastVariableRequested);
          }
        if (flagHasUserDesiresLastVariableRequested)
          {
            handler.start_pair("UserDesiresLastVariableRequested");
            handler.boolean_value(storeUserDesiresLastVariableRequested);
          }
        if (flagHasUserIsConfused)
          {
            handler.start_pair("UserIsConfused");
            handler.boolean_value(storeUserIsConfused);
          }
        if (flagHasLastResponseNotUnderstood)
          {
            handler.start_pair("LastResponseNotUnderstood");
            handler.boolean_value(storeLastResponseNotUnderstood);
          }
        if (flagHasConversationStateUsed)
          {
            handler.start_pair("ConversationStateUsed");
            handler.boolean_value(storeConversationStateUsed);
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
        if (!(hasInputVariableSets()))
          {
            return "When parsing the object for %what%, the \"InputVariableSets\" field was missing.";
          }
        if (!(hasVariableRequested()))
          {
            return "When parsing the object for %what%, the \"VariableRequested\" field was missing.";
          }
        if (!(hasApplicableInputVariableSets()))
          {
            return "When parsing the object for %what%, the \"ApplicableInputVariableSets\" field was missing.";
          }
        return null;
      }

    public static new MortgageCalculatorRequestInputVariableCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorRequestInputVariableCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorRequestInputVariableCommand", ignore_extras);
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
    public static new MortgageCalculatorRequestInputVariableCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorRequestInputVariableCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorRequestInputVariableCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorRequestInputVariableCommand", ignore_extras);
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
    public static new MortgageCalculatorRequestInputVariableCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorRequestInputVariableCommandJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorRequestInputVariableCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorRequestInputVariableCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorRequestInputVariableCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MortgageCalculatorRequestInputVariableCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorRequestInputVariableCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorRequestInputVariableCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MortgageCalculatorCommandJSON.Generator
      {
        private MortgageCalculatorInputVariableSetJSON.HoldingArrayGenerator fieldGeneratorInputVariableSets;
    private abstract class FieldGeneratorVariableRequested : JSONStringGenerator
          {
            protected FieldGeneratorVariableRequested(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorVariableRequested()
              {
              }
            protected override void handle_result(string result)
              {
                TypeVariableRequestedKnownValues known = stringToVariableRequested(result);
                TypeVariableRequested new_value = new TypeVariableRequested();
                if (known == TypeVariableRequestedKnownValues.VariableRequested__none)
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
            protected abstract void handle_result(TypeVariableRequested result);
          };
    private class FieldHoldingGeneratorVariableRequested : FieldGeneratorVariableRequested
  {
    protected override void handle_result(TypeVariableRequested result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorVariableRequested(String what)
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
    public TypeVariableRequested value;
  };
    private class FieldHoldingArrayGeneratorVariableRequested : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorVariableRequested
      {
        private FieldHoldingArrayGeneratorVariableRequested top;

        protected override void handle_result(TypeVariableRequested result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorVariableRequested init_top)
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
    protected virtual void handle_result(List<TypeVariableRequested> result)
      {
      }

    public FieldHoldingArrayGeneratorVariableRequested(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeVariableRequested>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorVariableRequested()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeVariableRequested>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeVariableRequested> value;
  };
        private FieldHoldingGeneratorVariableRequested fieldGeneratorVariableRequested;
    private class FieldHoldingGeneratorApplicableInputVariableSets : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorApplicableInputVariableSets(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorApplicableInputVariableSets : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorApplicableInputVariableSets(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorApplicableInputVariableSets fieldGeneratorApplicableInputVariableSets;
        private JSONHoldingBooleanGenerator fieldGeneratorStartMortgageCalculator;
        private JSONHoldingBooleanGenerator fieldGeneratorUserDoesNotKnowLastVariableRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorUserDesiresLastVariableRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorUserIsConfused;
        private JSONHoldingBooleanGenerator fieldGeneratorLastResponseNotUnderstood;
        private JSONHoldingBooleanGenerator fieldGeneratorConversationStateUsed;
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
            if (!(getMortgageCalculatorCommandJSONKey().Equals("MortgageCalculatorRequestInputVariable")))
                throw new Exception("The key field has a value other than `MortgageCalculatorRequestInputVariable'.");
            MortgageCalculatorRequestInputVariableCommandJSON result = new MortgageCalculatorRequestInputVariableCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorRequestInputVariableCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MortgageCalculatorCommandJSON new_result)
          {
            handle_result((MortgageCalculatorRequestInputVariableCommandJSON )new_result);
          }
        protected void finish(MortgageCalculatorRequestInputVariableCommandJSON result)
          {
            if (fieldGeneratorInputVariableSets.have_value)
              {
                result.initInputVariableSets();
                int count = fieldGeneratorInputVariableSets.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInputVariableSets(fieldGeneratorInputVariableSets.value[num]);
                  }
                fieldGeneratorInputVariableSets.value.Clear();
                fieldGeneratorInputVariableSets.have_value = false;
              }
            else if ((!(result.hasInputVariableSets())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InputVariableSets\" field was missing.");
              }
            if (fieldGeneratorVariableRequested.have_value)
              {
                result.setVariableRequested(fieldGeneratorVariableRequested.value);
                fieldGeneratorVariableRequested.have_value = false;
              }
            else if ((!(result.hasVariableRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"VariableRequested\" field was missing.");
              }
            if (fieldGeneratorApplicableInputVariableSets.have_value)
              {
                result.initApplicableInputVariableSets();
                int count = fieldGeneratorApplicableInputVariableSets.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendApplicableInputVariableSets(fieldGeneratorApplicableInputVariableSets.value[num]);
                  }
                fieldGeneratorApplicableInputVariableSets.value.Clear();
                fieldGeneratorApplicableInputVariableSets.have_value = false;
              }
            else if ((!(result.hasApplicableInputVariableSets())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ApplicableInputVariableSets\" field was missing.");
              }
            if (fieldGeneratorStartMortgageCalculator.have_value)
              {
                result.setStartMortgageCalculator(fieldGeneratorStartMortgageCalculator.value);
                fieldGeneratorStartMortgageCalculator.have_value = false;
              }
            if (fieldGeneratorUserDoesNotKnowLastVariableRequested.have_value)
              {
                result.setUserDoesNotKnowLastVariableRequested(fieldGeneratorUserDoesNotKnowLastVariableRequested.value);
                fieldGeneratorUserDoesNotKnowLastVariableRequested.have_value = false;
              }
            if (fieldGeneratorUserDesiresLastVariableRequested.have_value)
              {
                result.setUserDesiresLastVariableRequested(fieldGeneratorUserDesiresLastVariableRequested.value);
                fieldGeneratorUserDesiresLastVariableRequested.have_value = false;
              }
            if (fieldGeneratorUserIsConfused.have_value)
              {
                result.setUserIsConfused(fieldGeneratorUserIsConfused.value);
                fieldGeneratorUserIsConfused.have_value = false;
              }
            if (fieldGeneratorLastResponseNotUnderstood.have_value)
              {
                result.setLastResponseNotUnderstood(fieldGeneratorLastResponseNotUnderstood.value);
                fieldGeneratorLastResponseNotUnderstood.have_value = false;
              }
            if (fieldGeneratorConversationStateUsed.have_value)
              {
                result.setConversationStateUsed(fieldGeneratorConversationStateUsed.value);
                fieldGeneratorConversationStateUsed.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MortgageCalculatorRequestInputVariableCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "pplicableInputVariableSets", 0, 26, false) == 0) && (field_name.Length == 27))
                        return fieldGeneratorApplicableInputVariableSets;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "onversationStateUsed", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorConversationStateUsed;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nputVariableSets", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorInputVariableSets;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astResponseNotUnderstood", 0, 24, false) == 0) && (field_name.Length == 25))
                        return fieldGeneratorLastResponseNotUnderstood;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tartMortgageCalculator", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorStartMortgageCalculator;
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "ser", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'D':
                                switch (field_name[5])
                                  {
                                    case 'e':
                                        if ((String.Compare(field_name, 6, "siresLastVariableRequested", 0, 26, false) == 0) && (field_name.Length == 32))
                                            return fieldGeneratorUserDesiresLastVariableRequested;
                                        break;
                                    case 'o':
                                        if ((String.Compare(field_name, 6, "esNotKnowLastVariableRequested", 0, 30, false) == 0) && (field_name.Length == 36))
                                            return fieldGeneratorUserDoesNotKnowLastVariableRequested;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 5, "sConfused", 0, 9, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorUserIsConfused;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ariableRequested", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorVariableRequested;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorInputVariableSets = new MortgageCalculatorInputVariableSetJSON.HoldingArrayGenerator("field \"InputVariableSets\" of the MortgageCalculatorRequestInputVariableCommand class", ignore_extras);
            fieldGeneratorVariableRequested = new FieldHoldingGeneratorVariableRequested("field \"VariableRequested\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorApplicableInputVariableSets = new FieldHoldingArrayGeneratorApplicableInputVariableSets("field \"ApplicableInputVariableSets\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorStartMortgageCalculator = new JSONHoldingBooleanGenerator("field \"StartMortgageCalculator\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorUserDoesNotKnowLastVariableRequested = new JSONHoldingBooleanGenerator("field \"UserDoesNotKnowLastVariableRequested\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorUserDesiresLastVariableRequested = new JSONHoldingBooleanGenerator("field \"UserDesiresLastVariableRequested\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorUserIsConfused = new JSONHoldingBooleanGenerator("field \"UserIsConfused\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorLastResponseNotUnderstood = new JSONHoldingBooleanGenerator("field \"LastResponseNotUnderstood\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorConversationStateUsed = new JSONHoldingBooleanGenerator("field \"ConversationStateUsed\" of the MortgageCalculatorRequestInputVariableCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorRequestInputVariableCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorInputVariableSets = new MortgageCalculatorInputVariableSetJSON.HoldingArrayGenerator("field \"InputVariableSets\" of the MortgageCalculatorRequestInputVariableCommand class", false);
            fieldGeneratorVariableRequested = new FieldHoldingGeneratorVariableRequested("field \"VariableRequested\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorApplicableInputVariableSets = new FieldHoldingArrayGeneratorApplicableInputVariableSets("field \"ApplicableInputVariableSets\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorStartMortgageCalculator = new JSONHoldingBooleanGenerator("field \"StartMortgageCalculator\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorUserDoesNotKnowLastVariableRequested = new JSONHoldingBooleanGenerator("field \"UserDoesNotKnowLastVariableRequested\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorUserDesiresLastVariableRequested = new JSONHoldingBooleanGenerator("field \"UserDesiresLastVariableRequested\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorUserIsConfused = new JSONHoldingBooleanGenerator("field \"UserIsConfused\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorLastResponseNotUnderstood = new JSONHoldingBooleanGenerator("field \"LastResponseNotUnderstood\" of the MortgageCalculatorRequestInputVariableCommand class");
            fieldGeneratorConversationStateUsed = new JSONHoldingBooleanGenerator("field \"ConversationStateUsed\" of the MortgageCalculatorRequestInputVariableCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorRequestInputVariableCommand class");
          }

        public override void reset()
          {
            fieldGeneratorInputVariableSets.reset();
            fieldGeneratorVariableRequested.reset();
            fieldGeneratorApplicableInputVariableSets.reset();
            fieldGeneratorStartMortgageCalculator.reset();
            fieldGeneratorUserDoesNotKnowLastVariableRequested.reset();
            fieldGeneratorUserDesiresLastVariableRequested.reset();
            fieldGeneratorUserIsConfused.reset();
            fieldGeneratorLastResponseNotUnderstood.reset();
            fieldGeneratorConversationStateUsed.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorRequestInputVariableCommandJSON  result)
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
        public MortgageCalculatorRequestInputVariableCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorRequestInputVariableCommandJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorRequestInputVariableCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorRequestInputVariableCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorRequestInputVariableCommandJSON>();
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
    public List<MortgageCalculatorRequestInputVariableCommandJSON> value;
  };
  };
