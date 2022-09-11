/* file "MortgageCalculatorInputVariableSetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorInputVariableSetJSON : JSONBase
  {
    public enum TypeCalculationTypeKnownValues
      {
        CalculationType_Payment,
        CalculationType_Principal,
        CalculationType_DownPayment,
        CalculationType_HomeValue,
        CalculationType_AmortizationPeriod,
        CalculationType_InterestRate,
        CalculationType_InterestPaid,
        CalculationType_TotalPaid,
        CalculationType_PrincipalPaid,
        CalculationType_PrincipalOwing,
        CalculationType__none
      };
    public struct TypeCalculationType
      {
        public bool in_known_list;
        public string string_value;
        public TypeCalculationTypeKnownValues list_value;
      };

    public static TypeCalculationTypeKnownValues  stringToCalculationType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "mortizationPeriod", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeCalculationTypeKnownValues.CalculationType_AmortizationPeriod;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ownPayment", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeCalculationTypeKnownValues.CalculationType_DownPayment;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "omeValue", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeCalculationTypeKnownValues.CalculationType_HomeValue;
                break;
            case 'I':
                if (String.Compare(chars, 1, "nterest", 0, 7, false) == 0)
                  {
                    switch (chars[8])
                      {
                        case 'P':
                            if ((String.Compare(chars, 9, "aid", 0, 3, false) == 0) && (chars.Length == 12))
                                return TypeCalculationTypeKnownValues.CalculationType_InterestPaid;
                            break;
                        case 'R':
                            if ((String.Compare(chars, 9, "ate", 0, 3, false) == 0) && (chars.Length == 12))
                                return TypeCalculationTypeKnownValues.CalculationType_InterestRate;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "yment", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeCalculationTypeKnownValues.CalculationType_Payment;
                        break;
                    case 'r':
                        if (String.Compare(chars, 2, "incipal", 0, 7, false) == 0)
                          {
                            if (chars.Length == 9)
                              {
                                return TypeCalculationTypeKnownValues.CalculationType_Principal;
                              }
                            switch (chars[9])
                              {
                                case 'O':
                                    if ((String.Compare(chars, 10, "wing", 0, 4, false) == 0) && (chars.Length == 14))
                                        return TypeCalculationTypeKnownValues.CalculationType_PrincipalOwing;
                                    break;
                                case 'P':
                                    if ((String.Compare(chars, 10, "aid", 0, 3, false) == 0) && (chars.Length == 13))
                                        return TypeCalculationTypeKnownValues.CalculationType_PrincipalPaid;
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
            case 'T':
                if ((String.Compare(chars, 1, "otalPaid", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeCalculationTypeKnownValues.CalculationType_TotalPaid;
                break;
            default:
                break;
          }
        return TypeCalculationTypeKnownValues.CalculationType__none;
      }

    public static string  stringFromCalculationType(TypeCalculationTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeCalculationTypeKnownValues.CalculationType_Payment:
                return "Payment";
            case TypeCalculationTypeKnownValues.CalculationType_Principal:
                return "Principal";
            case TypeCalculationTypeKnownValues.CalculationType_DownPayment:
                return "DownPayment";
            case TypeCalculationTypeKnownValues.CalculationType_HomeValue:
                return "HomeValue";
            case TypeCalculationTypeKnownValues.CalculationType_AmortizationPeriod:
                return "AmortizationPeriod";
            case TypeCalculationTypeKnownValues.CalculationType_InterestRate:
                return "InterestRate";
            case TypeCalculationTypeKnownValues.CalculationType_InterestPaid:
                return "InterestPaid";
            case TypeCalculationTypeKnownValues.CalculationType_TotalPaid:
                return "TotalPaid";
            case TypeCalculationTypeKnownValues.CalculationType_PrincipalPaid:
                return "PrincipalPaid";
            case TypeCalculationTypeKnownValues.CalculationType_PrincipalOwing:
                return "PrincipalOwing";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeIntermediateCalculationTypeKnownValues
      {
        IntermediateCalculationType_Payment,
        IntermediateCalculationType_Principal,
        IntermediateCalculationType_DownPayment,
        IntermediateCalculationType_HomeValue,
        IntermediateCalculationType_AmortizationPeriod,
        IntermediateCalculationType_InterestRate,
        IntermediateCalculationType__none
      };
    public struct TypeIntermediateCalculationType
      {
        public bool in_known_list;
        public string string_value;
        public TypeIntermediateCalculationTypeKnownValues list_value;
      };

    public static TypeIntermediateCalculationTypeKnownValues  stringToIntermediateCalculationType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "mortizationPeriod", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_AmortizationPeriod;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ownPayment", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_DownPayment;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "omeValue", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_HomeValue;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nterestRate", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_InterestRate;
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "yment", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Payment;
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "incipal", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Principal;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType__none;
      }

    public static string  stringFromIntermediateCalculationType(TypeIntermediateCalculationTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Payment:
                return "Payment";
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Principal:
                return "Principal";
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_DownPayment:
                return "DownPayment";
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_HomeValue:
                return "HomeValue";
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_AmortizationPeriod:
                return "AmortizationPeriod";
            case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_InterestRate:
                return "InterestRate";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public struct TypeDownPayment
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public AmountJSON  choice0;
            [FieldOffset(0)]
            public double choice1;
          };
        public Utype u;
      };
    public enum TypeNewInputVariablesKnownValues
      {
        NewInputVariables_CalculationType,
        NewInputVariables_Principal,
        NewInputVariables_HomeValue,
        NewInputVariables_InterestRate,
        NewInputVariables_DownPayment,
        NewInputVariables_AmortizationPeriod,
        NewInputVariables_Payment,
        NewInputVariables_PaymentFrequency,
        NewInputVariables_TimePoint,
        NewInputVariables_TimeRange,
        NewInputVariables__none
      };
    public struct TypeNewInputVariables
      {
        public bool in_known_list;
        public string string_value;
        public TypeNewInputVariablesKnownValues list_value;
      };

    public static TypeNewInputVariablesKnownValues  stringToNewInputVariables(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "mortizationPeriod", 0, 17, false) == 0) && (chars.Length == 18))
                    return TypeNewInputVariablesKnownValues.NewInputVariables_AmortizationPeriod;
                break;
            case 'C':
                if ((String.Compare(chars, 1, "alculationType", 0, 14, false) == 0) && (chars.Length == 15))
                    return TypeNewInputVariablesKnownValues.NewInputVariables_CalculationType;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ownPayment", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeNewInputVariablesKnownValues.NewInputVariables_DownPayment;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "omeValue", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeNewInputVariablesKnownValues.NewInputVariables_HomeValue;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nterestRate", 0, 11, false) == 0) && (chars.Length == 12))
                    return TypeNewInputVariablesKnownValues.NewInputVariables_InterestRate;
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'a':
                        if (String.Compare(chars, 2, "yment", 0, 5, false) == 0)
                          {
                            if (chars.Length == 7)
                              {
                                return TypeNewInputVariablesKnownValues.NewInputVariables_Payment;
                              }
                            switch (chars[7])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 8, "requency", 0, 8, false) == 0) && (chars.Length == 16))
                                        return TypeNewInputVariablesKnownValues.NewInputVariables_PaymentFrequency;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if ((String.Compare(chars, 2, "incipal", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeNewInputVariablesKnownValues.NewInputVariables_Principal;
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
                                return TypeNewInputVariablesKnownValues.NewInputVariables_TimePoint;
                            break;
                        case 'R':
                            if ((String.Compare(chars, 5, "ange", 0, 4, false) == 0) && (chars.Length == 9))
                                return TypeNewInputVariablesKnownValues.NewInputVariables_TimeRange;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeNewInputVariablesKnownValues.NewInputVariables__none;
      }

    public static string  stringFromNewInputVariables(TypeNewInputVariablesKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeNewInputVariablesKnownValues.NewInputVariables_CalculationType:
                return "CalculationType";
            case TypeNewInputVariablesKnownValues.NewInputVariables_Principal:
                return "Principal";
            case TypeNewInputVariablesKnownValues.NewInputVariables_HomeValue:
                return "HomeValue";
            case TypeNewInputVariablesKnownValues.NewInputVariables_InterestRate:
                return "InterestRate";
            case TypeNewInputVariablesKnownValues.NewInputVariables_DownPayment:
                return "DownPayment";
            case TypeNewInputVariablesKnownValues.NewInputVariables_AmortizationPeriod:
                return "AmortizationPeriod";
            case TypeNewInputVariablesKnownValues.NewInputVariables_Payment:
                return "Payment";
            case TypeNewInputVariablesKnownValues.NewInputVariables_PaymentFrequency:
                return "PaymentFrequency";
            case TypeNewInputVariablesKnownValues.NewInputVariables_TimePoint:
                return "TimePoint";
            case TypeNewInputVariablesKnownValues.NewInputVariables_TimeRange:
                return "TimeRange";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCalculationType;
    private TypeCalculationType storeCalculationType;
    private bool flagHasIntermediateCalculationType;
    private TypeIntermediateCalculationType storeIntermediateCalculationType;
    private bool flagHasPrincipal;
    private AmountJSON  storePrincipal;
    private bool flagHasPrincipalAmbiguityWithHomeValue;
    private bool storePrincipalAmbiguityWithHomeValue;
    private bool flagHasHomeValue;
    private AmountJSON  storeHomeValue;
    private bool flagHasInterestRate;
    private double storeInterestRate;
    private string textStoreInterestRate;
    private bool flagHasDownPayment;
    private TypeDownPayment storeDownPayment;
    private bool flagHasAmortizationPeriod;
    private MortgageCalculatorAmortizationPeriodJSON  storeAmortizationPeriod;
    private bool flagHasPayment;
    private AmountJSON  storePayment;
    private bool flagHasTimePoint;
    private MortgageCalculatorTimePointJSON  storeTimePoint;
    private bool flagHasTimeRange;
    private MortgageCalculatorTimeRangeJSON  storeTimeRange;
    private bool flagHasNewInputVariables;
    private List< TypeNewInputVariables > storeNewInputVariables;
    private bool flagHasDefaultCurrency;
    private MonetaryAmountUnitJSON  storeDefaultCurrency;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCalculationType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CalculationType of MortgageCalculatorInputVariableSetJSON is not a string.");
        TypeCalculationType the_open_enum = new TypeCalculationType();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "mortizationPeriod", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_AmortizationPeriod;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ownPayment", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_DownPayment;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "omeValue", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_HomeValue;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if (String.Compare(json_string.getData(), 1, "nterest", 0, 7, false) == 0)
                  {
                    switch (json_string.getData()[8])
                      {
                        case 'P':
                            if ((String.Compare(json_string.getData(), 9, "aid", 0, 3, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_InterestPaid;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'R':
                            if ((String.Compare(json_string.getData(), 9, "ate", 0, 3, false) == 0) && (json_string.getData().Length == 12))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_InterestRate;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'P':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "yment", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_Payment;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if (String.Compare(json_string.getData(), 2, "incipal", 0, 7, false) == 0)
                          {
                            if (json_string.getData().Length == 9)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_Principal;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[9])
                              {
                                case 'O':
                                    if ((String.Compare(json_string.getData(), 10, "wing", 0, 4, false) == 0) && (json_string.getData().Length == 14))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_PrincipalOwing;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'P':
                                    if ((String.Compare(json_string.getData(), 10, "aid", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_PrincipalPaid;
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
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "otalPaid", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeCalculationTypeKnownValues.CalculationType_TotalPaid;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setCalculationType(the_open_enum);
      }


    private void  fromJSONIntermediateCalculationType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field IntermediateCalculationType of MortgageCalculatorInputVariableSetJSON is not a string.");
        TypeIntermediateCalculationType the_open_enum = new TypeIntermediateCalculationType();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "mortizationPeriod", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_AmortizationPeriod;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ownPayment", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_DownPayment;
                        goto open_enum_is_done;
                      }
                break;
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "omeValue", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_HomeValue;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nterestRate", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_InterestRate;
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
                                the_open_enum.list_value = TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Payment;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'r':
                        if ((String.Compare(json_string.getData(), 2, "incipal", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Principal;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setIntermediateCalculationType(the_open_enum);
      }


    private void  fromJSONPrincipal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setPrincipal(convert_classy);
      }


    private void  fromJSONPrincipalAmbiguityWithHomeValue(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PrincipalAmbiguityWithHomeValue of MortgageCalculatorInputVariableSetJSON is not true for false.");
              }
          }
        setPrincipalAmbiguityWithHomeValue(the_bool);
      }


    private void  fromJSONHomeValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setHomeValue(convert_classy);
      }


    private void  fromJSONInterestRate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field InterestRate of MortgageCalculatorInputVariableSetJSON is not a number.");
              }
          }
        setInterestRateText(the_rational_text);
      }


    private void  fromJSONDownPayment(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDownPayment or_result = new TypeDownPayment();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice0 = convert_classy;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                JSONRationalValue json_rational = json_value.rational_value();
                double the_double;
                if (json_rational != null)
                  {
                    the_double = json_rational.getDouble();
                  }
                else
                  {
                    JSONIntegerValue json_integer = json_value.integer_value();
                    if (json_integer != null)
                      {
                        the_double = json_integer.getLongInt();
                      }
                    else
                      {
                        throw new Exception("The value for ??? is not a number.");
                      }
                  }
                or_result.u.choice1 = the_double;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field DownPayment of MortgageCalculatorInputVariableSetJSON is not one of the allowed values.");
        setDownPayment(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONAmortizationPeriod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MortgageCalculatorAmortizationPeriodJSON convert_classy = MortgageCalculatorAmortizationPeriodJSON.from_json(json_value, ignore_extras, true);
        setAmortizationPeriod(convert_classy);
      }


    private void  fromJSONPayment(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setPayment(convert_classy);
      }


    private void  fromJSONTimePoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MortgageCalculatorTimePointJSON convert_classy = MortgageCalculatorTimePointJSON.from_json(json_value, ignore_extras, true);
        setTimePoint(convert_classy);
      }


    private void  fromJSONTimeRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MortgageCalculatorTimeRangeJSON convert_classy = MortgageCalculatorTimeRangeJSON.from_json(json_value, ignore_extras, true);
        setTimeRange(convert_classy);
      }


    private void  fromJSONNewInputVariables(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NewInputVariables of MortgageCalculatorInputVariableSetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeNewInputVariables > vector_NewInputVariables1 = new List< TypeNewInputVariables >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field NewInputVariables of MortgageCalculatorInputVariableSetJSON is not a string.");
            TypeNewInputVariables the_open_enum = new TypeNewInputVariables();
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "mortizationPeriod", 0, 17, false) == 0) && (json_string.getData().Length == 18))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeNewInputVariablesKnownValues.NewInputVariables_AmortizationPeriod;
                            goto open_enum_is_done;
                          }
                    break;
                case 'C':
                    if ((String.Compare(json_string.getData(), 1, "alculationType", 0, 14, false) == 0) && (json_string.getData().Length == 15))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeNewInputVariablesKnownValues.NewInputVariables_CalculationType;
                            goto open_enum_is_done;
                          }
                    break;
                case 'D':
                    if ((String.Compare(json_string.getData(), 1, "ownPayment", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeNewInputVariablesKnownValues.NewInputVariables_DownPayment;
                            goto open_enum_is_done;
                          }
                    break;
                case 'H':
                    if ((String.Compare(json_string.getData(), 1, "omeValue", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeNewInputVariablesKnownValues.NewInputVariables_HomeValue;
                            goto open_enum_is_done;
                          }
                    break;
                case 'I':
                    if ((String.Compare(json_string.getData(), 1, "nterestRate", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeNewInputVariablesKnownValues.NewInputVariables_InterestRate;
                            goto open_enum_is_done;
                          }
                    break;
                case 'P':
                    switch (json_string.getData()[1])
                      {
                        case 'a':
                            if (String.Compare(json_string.getData(), 2, "yment", 0, 5, false) == 0)
                              {
                                if (json_string.getData().Length == 7)
                                  {
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNewInputVariablesKnownValues.NewInputVariables_Payment;
                                        goto open_enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[7])
                                  {
                                    case 'F':
                                        if ((String.Compare(json_string.getData(), 8, "requency", 0, 8, false) == 0) && (json_string.getData().Length == 16))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeNewInputVariablesKnownValues.NewInputVariables_PaymentFrequency;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if ((String.Compare(json_string.getData(), 2, "incipal", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeNewInputVariablesKnownValues.NewInputVariables_Principal;
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
                                        the_open_enum.list_value = TypeNewInputVariablesKnownValues.NewInputVariables_TimePoint;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 'R':
                                if ((String.Compare(json_string.getData(), 5, "ange", 0, 4, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeNewInputVariablesKnownValues.NewInputVariables_TimeRange;
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
            vector_NewInputVariables1.Add(the_open_enum);
          }
        initNewInputVariables();
        for (int num1 = 0; num1 < vector_NewInputVariables1.Count; ++num1)
            appendNewInputVariables(vector_NewInputVariables1[num1]);
        for (int num1 = 0; num1 < vector_NewInputVariables1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDefaultCurrency(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MonetaryAmountUnitJSON convert_classy = MonetaryAmountUnitJSON.from_json(json_value, ignore_extras, true);
        setDefaultCurrency(convert_classy);
      }


    public MortgageCalculatorInputVariableSetJSON()
      {
        flagHasCalculationType = false;
        flagHasIntermediateCalculationType = false;
        flagHasPrincipal = false;
        flagHasPrincipalAmbiguityWithHomeValue = false;
        flagHasHomeValue = false;
        flagHasInterestRate = false;
        flagHasDownPayment = false;
        flagHasAmortizationPeriod = false;
        flagHasPayment = false;
        flagHasTimePoint = false;
        flagHasTimeRange = false;
        flagHasNewInputVariables = false;
        flagHasDefaultCurrency = false;
        storeNewInputVariables = new List< TypeNewInputVariables >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCalculationType()
      {
        return flagHasCalculationType;
      }

    public TypeCalculationType  getCalculationType()
      {
        Debug.Assert(flagHasCalculationType);
        return storeCalculationType;
      }

    public string  getCalculationTypeAsString()
      {
        TypeCalculationType result = getCalculationType();
        if (result.in_known_list)
            return stringFromCalculationType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasIntermediateCalculationType()
      {
        return flagHasIntermediateCalculationType;
      }

    public TypeIntermediateCalculationType  getIntermediateCalculationType()
      {
        Debug.Assert(flagHasIntermediateCalculationType);
        return storeIntermediateCalculationType;
      }

    public string  getIntermediateCalculationTypeAsString()
      {
        TypeIntermediateCalculationType result = getIntermediateCalculationType();
        if (result.in_known_list)
            return stringFromIntermediateCalculationType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasPrincipal()
      {
        return flagHasPrincipal;
      }

    public AmountJSON   getPrincipal()
      {
        Debug.Assert(flagHasPrincipal);
        return storePrincipal;
      }

    public bool  hasPrincipalAmbiguityWithHomeValue()
      {
        return flagHasPrincipalAmbiguityWithHomeValue;
      }

    public bool  getPrincipalAmbiguityWithHomeValue()
      {
        Debug.Assert(flagHasPrincipalAmbiguityWithHomeValue);
        return storePrincipalAmbiguityWithHomeValue;
      }

    public bool  hasHomeValue()
      {
        return flagHasHomeValue;
      }

    public AmountJSON   getHomeValue()
      {
        Debug.Assert(flagHasHomeValue);
        return storeHomeValue;
      }

    public bool  hasInterestRate()
      {
        return flagHasInterestRate;
      }

    public double  getInterestRate()
      {
        Debug.Assert(flagHasInterestRate);
        if (textStoreInterestRate != "")
          {
            return Double.Parse(textStoreInterestRate);
          }
        return storeInterestRate;
      }

    public string  getInterestRateAsText()
      {
        Debug.Assert(flagHasInterestRate);
        if (textStoreInterestRate == "")
          {
            return Convert.ToString(storeInterestRate);
          }
        else
          {
            return (textStoreInterestRate);
          }
      }

    public bool  hasDownPayment()
      {
        return flagHasDownPayment;
      }

    public TypeDownPayment  getDownPayment()
      {
        Debug.Assert(flagHasDownPayment);
        return storeDownPayment;
      }

    public bool  hasAmortizationPeriod()
      {
        return flagHasAmortizationPeriod;
      }

    public MortgageCalculatorAmortizationPeriodJSON   getAmortizationPeriod()
      {
        Debug.Assert(flagHasAmortizationPeriod);
        return storeAmortizationPeriod;
      }

    public bool  hasPayment()
      {
        return flagHasPayment;
      }

    public AmountJSON   getPayment()
      {
        Debug.Assert(flagHasPayment);
        return storePayment;
      }

    public bool  hasTimePoint()
      {
        return flagHasTimePoint;
      }

    public MortgageCalculatorTimePointJSON   getTimePoint()
      {
        Debug.Assert(flagHasTimePoint);
        return storeTimePoint;
      }

    public bool  hasTimeRange()
      {
        return flagHasTimeRange;
      }

    public MortgageCalculatorTimeRangeJSON   getTimeRange()
      {
        Debug.Assert(flagHasTimeRange);
        return storeTimeRange;
      }

    public bool  hasNewInputVariables()
      {
        return flagHasNewInputVariables;
      }

    public int  countOfNewInputVariables()
      {
        Debug.Assert(flagHasNewInputVariables);
        return storeNewInputVariables.Count;
      }

    public TypeNewInputVariables  elementOfNewInputVariables(int element_num)
      {
        Debug.Assert(flagHasNewInputVariables);
        return storeNewInputVariables[element_num];
      }

    public List< TypeNewInputVariables >  getNewInputVariables()
      {
        Debug.Assert(flagHasNewInputVariables);
        return storeNewInputVariables;
      }

    public bool  hasDefaultCurrency()
      {
        return flagHasDefaultCurrency;
      }

    public MonetaryAmountUnitJSON   getDefaultCurrency()
      {
        Debug.Assert(flagHasDefaultCurrency);
        return storeDefaultCurrency;
      }


    public virtual int extraMortgageCalculatorInputVariableSetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorInputVariableSetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableSetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorInputVariableSetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCalculationType(TypeCalculationType new_value)
      {
        flagHasCalculationType = true;
        storeCalculationType = new_value;
      }
    public void setCalculationType(string chars)
      {
        TypeCalculationTypeKnownValues known = stringToCalculationType(chars);
        TypeCalculationType new_value = new TypeCalculationType();
        if (known == TypeCalculationTypeKnownValues.CalculationType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setCalculationType(new_value);
      }
    public void setCalculationType(TypeCalculationTypeKnownValues new_value)
      {
        TypeCalculationType new_full_value = new TypeCalculationType();
        Debug.Assert(new_value != TypeCalculationTypeKnownValues.CalculationType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setCalculationType(new_full_value);
      }
    public void unsetCalculationType()
      {
        flagHasCalculationType = false;
      }
    public void setIntermediateCalculationType(TypeIntermediateCalculationType new_value)
      {
        flagHasIntermediateCalculationType = true;
        storeIntermediateCalculationType = new_value;
      }
    public void setIntermediateCalculationType(string chars)
      {
        TypeIntermediateCalculationTypeKnownValues known = stringToIntermediateCalculationType(chars);
        TypeIntermediateCalculationType new_value = new TypeIntermediateCalculationType();
        if (known == TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setIntermediateCalculationType(new_value);
      }
    public void setIntermediateCalculationType(TypeIntermediateCalculationTypeKnownValues new_value)
      {
        TypeIntermediateCalculationType new_full_value = new TypeIntermediateCalculationType();
        Debug.Assert(new_value != TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setIntermediateCalculationType(new_full_value);
      }
    public void unsetIntermediateCalculationType()
      {
        flagHasIntermediateCalculationType = false;
      }
    public void setPrincipal(AmountJSON  new_value)
      {
        if (flagHasPrincipal)
          {
          }
        flagHasPrincipal = true;
        storePrincipal = new_value;
      }
    public void unsetPrincipal()
      {
        if (flagHasPrincipal)
          {
          }
        flagHasPrincipal = false;
      }
    public void setPrincipalAmbiguityWithHomeValue(bool new_value)
      {
        flagHasPrincipalAmbiguityWithHomeValue = true;
        storePrincipalAmbiguityWithHomeValue = new_value;
      }
    public void unsetPrincipalAmbiguityWithHomeValue()
      {
        flagHasPrincipalAmbiguityWithHomeValue = false;
      }
    public void setHomeValue(AmountJSON  new_value)
      {
        if (flagHasHomeValue)
          {
          }
        flagHasHomeValue = true;
        storeHomeValue = new_value;
      }
    public void unsetHomeValue()
      {
        if (flagHasHomeValue)
          {
          }
        flagHasHomeValue = false;
      }
    public void setInterestRate(double new_value)
      {
        flagHasInterestRate = true;
        storeInterestRate = new_value;
        textStoreInterestRate = "";
      }
    public void setInterestRateText(string new_value)
      {
        flagHasInterestRate = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field InterestRate of MortgageCalculatorInputVariableSetJSON is not a valid number.");
        textStoreInterestRate = new_value;
      }
    public void unsetInterestRate()
      {
        flagHasInterestRate = false;
      }
    public void setDownPayment(TypeDownPayment new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHasDownPayment)
          {
            switch (storeDownPayment.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasDownPayment = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeDownPayment = new_value;
      }
    public void unsetDownPayment()
      {
        if (flagHasDownPayment)
          {
            switch (storeDownPayment.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasDownPayment = false;
      }
    public void setAmortizationPeriod(MortgageCalculatorAmortizationPeriodJSON  new_value)
      {
        if (flagHasAmortizationPeriod)
          {
          }
        flagHasAmortizationPeriod = true;
        storeAmortizationPeriod = new_value;
      }
    public void unsetAmortizationPeriod()
      {
        if (flagHasAmortizationPeriod)
          {
          }
        flagHasAmortizationPeriod = false;
      }
    public void setPayment(AmountJSON  new_value)
      {
        if (flagHasPayment)
          {
          }
        flagHasPayment = true;
        storePayment = new_value;
      }
    public void unsetPayment()
      {
        if (flagHasPayment)
          {
          }
        flagHasPayment = false;
      }
    public void setTimePoint(MortgageCalculatorTimePointJSON  new_value)
      {
        if (flagHasTimePoint)
          {
          }
        flagHasTimePoint = true;
        storeTimePoint = new_value;
      }
    public void unsetTimePoint()
      {
        if (flagHasTimePoint)
          {
          }
        flagHasTimePoint = false;
      }
    public void setTimeRange(MortgageCalculatorTimeRangeJSON  new_value)
      {
        if (flagHasTimeRange)
          {
          }
        flagHasTimeRange = true;
        storeTimeRange = new_value;
      }
    public void unsetTimeRange()
      {
        if (flagHasTimeRange)
          {
          }
        flagHasTimeRange = false;
      }
    public void initNewInputVariables()
      {
        flagHasNewInputVariables = true;
        storeNewInputVariables.Clear();
      }
    public void appendNewInputVariables(TypeNewInputVariables to_append)
      {
        if (!flagHasNewInputVariables)
          {
            flagHasNewInputVariables = true;
            storeNewInputVariables.Clear();
          }
        Debug.Assert(flagHasNewInputVariables);
        storeNewInputVariables.Add(to_append);
      }
    public void appendNewInputVariables(string chars)
      {
        TypeNewInputVariablesKnownValues known = stringToNewInputVariables(chars);
        TypeNewInputVariables new_value = new TypeNewInputVariables();
        if (known == TypeNewInputVariablesKnownValues.NewInputVariables__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendNewInputVariables(new_value);
      }
    public void appendNewInputVariables(TypeNewInputVariablesKnownValues new_value)
      {
        TypeNewInputVariables new_full_value = new TypeNewInputVariables();
        Debug.Assert(new_value != TypeNewInputVariablesKnownValues.NewInputVariables__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        appendNewInputVariables(new_full_value);
      }
    public void unsetNewInputVariables()
      {
        flagHasNewInputVariables = false;
        storeNewInputVariables.Clear();
      }
    public void setDefaultCurrency(MonetaryAmountUnitJSON  new_value)
      {
        if (flagHasDefaultCurrency)
          {
          }
        flagHasDefaultCurrency = true;
        storeDefaultCurrency = new_value;
      }
    public void unsetDefaultCurrency()
      {
        if (flagHasDefaultCurrency)
          {
          }
        flagHasDefaultCurrency = false;
      }

    public virtual void extraMortgageCalculatorInputVariableSetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorInputVariableSetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorInputVariableSetLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorInputVariableSetAppendPair(key, new_component);
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

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        if (flagHasCalculationType)
          {
            handler.start_pair("CalculationType");
            if (storeCalculationType.in_known_list)
              {
                switch (storeCalculationType.list_value)
                  {
                    case TypeCalculationTypeKnownValues.CalculationType_Payment:
                        handler.string_value("Payment");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_Principal:
                        handler.string_value("Principal");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_DownPayment:
                        handler.string_value("DownPayment");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_HomeValue:
                        handler.string_value("HomeValue");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_AmortizationPeriod:
                        handler.string_value("AmortizationPeriod");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_InterestRate:
                        handler.string_value("InterestRate");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_InterestPaid:
                        handler.string_value("InterestPaid");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_TotalPaid:
                        handler.string_value("TotalPaid");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_PrincipalPaid:
                        handler.string_value("PrincipalPaid");
                        break;
                    case TypeCalculationTypeKnownValues.CalculationType_PrincipalOwing:
                        handler.string_value("PrincipalOwing");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeCalculationType.string_value);
              }
          }
        if (flagHasIntermediateCalculationType)
          {
            handler.start_pair("IntermediateCalculationType");
            if (storeIntermediateCalculationType.in_known_list)
              {
                switch (storeIntermediateCalculationType.list_value)
                  {
                    case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Payment:
                        handler.string_value("Payment");
                        break;
                    case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_Principal:
                        handler.string_value("Principal");
                        break;
                    case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_DownPayment:
                        handler.string_value("DownPayment");
                        break;
                    case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_HomeValue:
                        handler.string_value("HomeValue");
                        break;
                    case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_AmortizationPeriod:
                        handler.string_value("AmortizationPeriod");
                        break;
                    case TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType_InterestRate:
                        handler.string_value("InterestRate");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeIntermediateCalculationType.string_value);
              }
          }
        if (flagHasPrincipal)
          {
            handler.start_pair("Principal");
            if (partial_allowed)
                storePrincipal.write_partial_as_json(handler);
            else
                storePrincipal.write_as_json(handler);
          }
        if (flagHasPrincipalAmbiguityWithHomeValue)
          {
            handler.start_pair("PrincipalAmbiguityWithHomeValue");
            handler.boolean_value(storePrincipalAmbiguityWithHomeValue);
          }
        if (flagHasHomeValue)
          {
            handler.start_pair("HomeValue");
            if (partial_allowed)
                storeHomeValue.write_partial_as_json(handler);
            else
                storeHomeValue.write_as_json(handler);
          }
        if (flagHasInterestRate)
          {
            handler.start_pair("InterestRate");
            if (textStoreInterestRate != "")
                handler.number_value(textStoreInterestRate);
            else if (((double)(long)storeInterestRate) == storeInterestRate)
                handler.number_value((long)storeInterestRate);
            else
                handler.number_value(storeInterestRate);
          }
        if (flagHasDownPayment)
          {
            handler.start_pair("DownPayment");
            switch (storeDownPayment.key)
              {
                case 0:
                    if (partial_allowed)
                        storeDownPayment.u.choice0.write_partial_as_json(handler);
                    else
                        storeDownPayment.u.choice0.write_as_json(handler);
                    break;
                case 1:
                    if (((double)(long)storeDownPayment.u.choice1) == storeDownPayment.u.choice1)
                        handler.number_value((long)storeDownPayment.u.choice1);
                    else
                        handler.number_value(storeDownPayment.u.choice1);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasAmortizationPeriod)
          {
            handler.start_pair("AmortizationPeriod");
            if (partial_allowed)
                storeAmortizationPeriod.write_partial_as_json(handler);
            else
                storeAmortizationPeriod.write_as_json(handler);
          }
        if (flagHasPayment)
          {
            handler.start_pair("Payment");
            if (partial_allowed)
                storePayment.write_partial_as_json(handler);
            else
                storePayment.write_as_json(handler);
          }
        if (flagHasTimePoint)
          {
            handler.start_pair("TimePoint");
            if (partial_allowed)
                storeTimePoint.write_partial_as_json(handler);
            else
                storeTimePoint.write_as_json(handler);
          }
        if (flagHasTimeRange)
          {
            handler.start_pair("TimeRange");
            if (partial_allowed)
                storeTimeRange.write_partial_as_json(handler);
            else
                storeTimeRange.write_as_json(handler);
          }
        if (flagHasNewInputVariables)
          {
            handler.start_pair("NewInputVariables");
            handler.start_array();
            for (int num1 = 0; num1 < storeNewInputVariables.Count; ++num1)
              {
                if (storeNewInputVariables[num1].in_known_list)
                  {
                    switch (storeNewInputVariables[num1].list_value)
                      {
                        case TypeNewInputVariablesKnownValues.NewInputVariables_CalculationType:
                            handler.string_value("CalculationType");
                            break;
                        case TypeNewInputVariablesKnownValues.NewInputVariables_Principal:
                            handler.string_value("Principal");
                            break;
                        case TypeNewInputVariablesKnownValues.NewInputVariables_HomeValue:
                            handler.string_value("HomeValue");
                            break;
                        case TypeNewInputVariablesKnownValues.NewInputVariables_InterestRate:
                            handler.string_value("InterestRate");
                            break;
                        case TypeNewInputVariablesKnownValues.NewInputVariables_DownPayment:
                            handler.string_value("DownPayment");
                            break;
                        case TypeNewInputVariablesKnownValues.NewInputVariables_AmortizationPeriod:
                            handler.string_value("AmortizationPeriod");
                            break;
                        case TypeNewInputVariablesKnownValues.NewInputVariables_Payment:
                            handler.string_value("Payment");
                            break;
                        case TypeNewInputVariablesKnownValues.NewInputVariables_PaymentFrequency:
                            handler.string_value("PaymentFrequency");
                            break;
                        case TypeNewInputVariablesKnownValues.NewInputVariables_TimePoint:
                            handler.string_value("TimePoint");
                            break;
                        case TypeNewInputVariablesKnownValues.NewInputVariables_TimeRange:
                            handler.string_value("TimeRange");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeNewInputVariables[num1].string_value);
                  }
              }
            handler.finish_array();
          }
        if (flagHasDefaultCurrency)
          {
            handler.start_pair("DefaultCurrency");
            if (partial_allowed)
                storeDefaultCurrency.write_partial_as_json(handler);
            else
                storeDefaultCurrency.write_as_json(handler);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static MortgageCalculatorInputVariableSetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableSetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableSet", ignore_extras);
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
    public static MortgageCalculatorInputVariableSetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MortgageCalculatorInputVariableSetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorInputVariableSetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableSet", ignore_extras);
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
    public static MortgageCalculatorInputVariableSetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MortgageCalculatorInputVariableSetJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorInputVariableSetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableSet", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorInputVariableSetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MortgageCalculatorInputVariableSetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorInputVariableSetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorInputVariableSet", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorCalculationType : JSONStringGenerator
          {
            protected FieldGeneratorCalculationType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCalculationType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeCalculationTypeKnownValues known = stringToCalculationType(result);
                TypeCalculationType new_value = new TypeCalculationType();
                if (known == TypeCalculationTypeKnownValues.CalculationType__none)
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
            protected abstract void handle_result(TypeCalculationType result);
          };
    private class FieldHoldingGeneratorCalculationType : FieldGeneratorCalculationType
  {
    protected override void handle_result(TypeCalculationType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCalculationType(String what)
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
    public TypeCalculationType value;
  };
    private class FieldHoldingArrayGeneratorCalculationType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCalculationType
      {
        private FieldHoldingArrayGeneratorCalculationType top;

        protected override void handle_result(TypeCalculationType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCalculationType init_top)
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
    protected virtual void handle_result(List<TypeCalculationType> result)
      {
      }

    public FieldHoldingArrayGeneratorCalculationType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCalculationType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCalculationType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCalculationType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCalculationType> value;
  };
        private FieldHoldingGeneratorCalculationType fieldGeneratorCalculationType;
    private abstract class FieldGeneratorIntermediateCalculationType : JSONStringGenerator
          {
            protected FieldGeneratorIntermediateCalculationType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorIntermediateCalculationType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeIntermediateCalculationTypeKnownValues known = stringToIntermediateCalculationType(result);
                TypeIntermediateCalculationType new_value = new TypeIntermediateCalculationType();
                if (known == TypeIntermediateCalculationTypeKnownValues.IntermediateCalculationType__none)
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
            protected abstract void handle_result(TypeIntermediateCalculationType result);
          };
    private class FieldHoldingGeneratorIntermediateCalculationType : FieldGeneratorIntermediateCalculationType
  {
    protected override void handle_result(TypeIntermediateCalculationType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorIntermediateCalculationType(String what)
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
    public TypeIntermediateCalculationType value;
  };
    private class FieldHoldingArrayGeneratorIntermediateCalculationType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorIntermediateCalculationType
      {
        private FieldHoldingArrayGeneratorIntermediateCalculationType top;

        protected override void handle_result(TypeIntermediateCalculationType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorIntermediateCalculationType init_top)
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
    protected virtual void handle_result(List<TypeIntermediateCalculationType> result)
      {
      }

    public FieldHoldingArrayGeneratorIntermediateCalculationType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeIntermediateCalculationType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorIntermediateCalculationType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeIntermediateCalculationType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeIntermediateCalculationType> value;
  };
        private FieldHoldingGeneratorIntermediateCalculationType fieldGeneratorIntermediateCalculationType;
        private AmountJSON.HoldingGenerator fieldGeneratorPrincipal;
        private JSONHoldingBooleanGenerator fieldGeneratorPrincipalAmbiguityWithHomeValue;
        private AmountJSON.HoldingGenerator fieldGeneratorHomeValue;
        private JSONHoldingNumberTextGenerator fieldGeneratorInterestRate;
    private abstract class FieldGeneratorDownPayment : JSONParallelGenerator
          {
            private AmountJSON.HoldingGenerator field0;
            private JSONHoldingNumberTextGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeDownPayment result = new TypeDownPayment();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = Double.Parse(field1.value);
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeDownPayment result);
            public FieldGeneratorDownPayment(bool ignore_extras)
              {
                    field0 = new AmountJSON.HoldingGenerator("option 0 of field \"DownPayment\"", ignore_extras);
                    field1 = new JSONHoldingNumberTextGenerator("option 1 of field \"DownPayment\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorDownPayment(string what, bool ignore_extras)
              {
                    field0 = new AmountJSON.HoldingGenerator("option 0 of field \"DownPayment\"", ignore_extras);
                    field1 = new JSONHoldingNumberTextGenerator("option 1 of field \"DownPayment\"");
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderDownPayment
          {
            private bool have_data;
            private TypeDownPayment data;
            public HolderDownPayment()  { have_data = false; }
            public HolderDownPayment(TypeDownPayment init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderDownPayment(HolderDownPayment other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeDownPayment referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorDownPayment : FieldGeneratorDownPayment
          {
            protected override void handle_result(TypeDownPayment result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderDownPayment(result);
              }

            public FieldHoldingGeneratorDownPayment(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderDownPayment value;
          };
    private class FieldHoldingArrayGeneratorDownPayment : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDownPayment
      {
        private FieldHoldingArrayGeneratorDownPayment top;

        protected override void handle_result(TypeDownPayment result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDownPayment init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeDownPayment> result)
      {
      }

    public FieldHoldingArrayGeneratorDownPayment(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDownPayment>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDownPayment(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDownPayment>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDownPayment> value;
  };
        private FieldHoldingGeneratorDownPayment fieldGeneratorDownPayment;
        private MortgageCalculatorAmortizationPeriodJSON.HoldingGenerator fieldGeneratorAmortizationPeriod;
        private AmountJSON.HoldingGenerator fieldGeneratorPayment;
        private MortgageCalculatorTimePointJSON.HoldingGenerator fieldGeneratorTimePoint;
        private MortgageCalculatorTimeRangeJSON.HoldingGenerator fieldGeneratorTimeRange;
    private abstract class FieldGeneratorNewInputVariables : JSONStringGenerator
          {
            protected FieldGeneratorNewInputVariables(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNewInputVariables()
              {
              }
            protected override void handle_result(string result)
              {
                TypeNewInputVariablesKnownValues known = stringToNewInputVariables(result);
                TypeNewInputVariables new_value = new TypeNewInputVariables();
                if (known == TypeNewInputVariablesKnownValues.NewInputVariables__none)
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
            protected abstract void handle_result(TypeNewInputVariables result);
          };
    private class FieldHoldingGeneratorNewInputVariables : FieldGeneratorNewInputVariables
  {
    protected override void handle_result(TypeNewInputVariables result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNewInputVariables(String what)
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
    public TypeNewInputVariables value;
  };
    private class FieldHoldingArrayGeneratorNewInputVariables : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNewInputVariables
      {
        private FieldHoldingArrayGeneratorNewInputVariables top;

        protected override void handle_result(TypeNewInputVariables result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNewInputVariables init_top)
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
    protected virtual void handle_result(List<TypeNewInputVariables> result)
      {
      }

    public FieldHoldingArrayGeneratorNewInputVariables(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNewInputVariables>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNewInputVariables()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNewInputVariables>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNewInputVariables> value;
  };
        private FieldHoldingArrayGeneratorNewInputVariables fieldGeneratorNewInputVariables;
        private MonetaryAmountUnitJSON.HoldingGenerator fieldGeneratorDefaultCurrency;
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
            MortgageCalculatorInputVariableSetJSON result = new MortgageCalculatorInputVariableSetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorInputVariableSetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MortgageCalculatorInputVariableSetJSON result)
          {
            if (fieldGeneratorCalculationType.have_value)
              {
                result.setCalculationType(fieldGeneratorCalculationType.value);
                fieldGeneratorCalculationType.have_value = false;
              }
            if (fieldGeneratorIntermediateCalculationType.have_value)
              {
                result.setIntermediateCalculationType(fieldGeneratorIntermediateCalculationType.value);
                fieldGeneratorIntermediateCalculationType.have_value = false;
              }
            if (fieldGeneratorPrincipal.have_value)
              {
                result.setPrincipal(fieldGeneratorPrincipal.value);
                fieldGeneratorPrincipal.have_value = false;
              }
            if (fieldGeneratorPrincipalAmbiguityWithHomeValue.have_value)
              {
                result.setPrincipalAmbiguityWithHomeValue(fieldGeneratorPrincipalAmbiguityWithHomeValue.value);
                fieldGeneratorPrincipalAmbiguityWithHomeValue.have_value = false;
              }
            if (fieldGeneratorHomeValue.have_value)
              {
                result.setHomeValue(fieldGeneratorHomeValue.value);
                fieldGeneratorHomeValue.have_value = false;
              }
            if (fieldGeneratorInterestRate.have_value)
              {
                result.setInterestRateText(fieldGeneratorInterestRate.value);
                fieldGeneratorInterestRate.have_value = false;
              }
            if (fieldGeneratorDownPayment.have_value)
              {
                result.setDownPayment(fieldGeneratorDownPayment.value.referenced());
                fieldGeneratorDownPayment.have_value = false;
              }
            if (fieldGeneratorAmortizationPeriod.have_value)
              {
                result.setAmortizationPeriod(fieldGeneratorAmortizationPeriod.value);
                fieldGeneratorAmortizationPeriod.have_value = false;
              }
            if (fieldGeneratorPayment.have_value)
              {
                result.setPayment(fieldGeneratorPayment.value);
                fieldGeneratorPayment.have_value = false;
              }
            if (fieldGeneratorTimePoint.have_value)
              {
                result.setTimePoint(fieldGeneratorTimePoint.value);
                fieldGeneratorTimePoint.have_value = false;
              }
            if (fieldGeneratorTimeRange.have_value)
              {
                result.setTimeRange(fieldGeneratorTimeRange.value);
                fieldGeneratorTimeRange.have_value = false;
              }
            if (fieldGeneratorNewInputVariables.have_value)
              {
                result.initNewInputVariables();
                int count = fieldGeneratorNewInputVariables.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNewInputVariables(fieldGeneratorNewInputVariables.value[num]);
                  }
                fieldGeneratorNewInputVariables.value.Clear();
                fieldGeneratorNewInputVariables.have_value = false;
              }
            if (fieldGeneratorDefaultCurrency.have_value)
              {
                result.setDefaultCurrency(fieldGeneratorDefaultCurrency.value);
                fieldGeneratorDefaultCurrency.have_value = false;
              }
          }
        protected abstract void handle_result(MortgageCalculatorInputVariableSetJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "mortizationPeriod", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorAmortizationPeriod;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "alculationType", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorCalculationType;
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "faultCurrency", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorDefaultCurrency;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "wnPayment", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorDownPayment;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "omeValue", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorHomeValue;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "nter", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 6, "stRate", 0, 6, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorInterestRate;
                                break;
                            case 'm':
                                if ((String.Compare(field_name, 6, "ediateCalculationType", 0, 21, false) == 0) && (field_name.Length == 27))
                                    return fieldGeneratorIntermediateCalculationType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ewInputVariables", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorNewInputVariables;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "yment", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorPayment;
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "incipal", 0, 7, false) == 0)
                              {
                                if (field_name.Length == 9)
                                  {
                                    return fieldGeneratorPrincipal;
                                  }
                                switch (field_name[9])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 10, "mbiguityWithHomeValue", 0, 21, false) == 0) && (field_name.Length == 31))
                                            return fieldGeneratorPrincipalAmbiguityWithHomeValue;
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
                case 'T':
                    if (String.Compare(field_name, 1, "ime", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 5, "oint", 0, 4, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorTimePoint;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 5, "ange", 0, 4, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorTimeRange;
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
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCalculationType = new FieldHoldingGeneratorCalculationType("field \"CalculationType\" of the MortgageCalculatorInputVariableSet class");
            fieldGeneratorIntermediateCalculationType = new FieldHoldingGeneratorIntermediateCalculationType("field \"IntermediateCalculationType\" of the MortgageCalculatorInputVariableSet class");
            fieldGeneratorPrincipal = new AmountJSON.HoldingGenerator("field \"Principal\" of the MortgageCalculatorInputVariableSet class", ignore_extras);
            fieldGeneratorPrincipalAmbiguityWithHomeValue = new JSONHoldingBooleanGenerator("field \"PrincipalAmbiguityWithHomeValue\" of the MortgageCalculatorInputVariableSet class");
            fieldGeneratorHomeValue = new AmountJSON.HoldingGenerator("field \"HomeValue\" of the MortgageCalculatorInputVariableSet class", ignore_extras);
            fieldGeneratorInterestRate = new JSONHoldingNumberTextGenerator("field \"InterestRate\" of the MortgageCalculatorInputVariableSet class");
            fieldGeneratorDownPayment = new FieldHoldingGeneratorDownPayment("field \"DownPayment\" of the MortgageCalculatorInputVariableSet class", ignore_extras);
            fieldGeneratorAmortizationPeriod = new MortgageCalculatorAmortizationPeriodJSON.HoldingGenerator("field \"AmortizationPeriod\" of the MortgageCalculatorInputVariableSet class", ignore_extras);
            fieldGeneratorPayment = new AmountJSON.HoldingGenerator("field \"Payment\" of the MortgageCalculatorInputVariableSet class", ignore_extras);
            fieldGeneratorTimePoint = new MortgageCalculatorTimePointJSON.HoldingGenerator("field \"TimePoint\" of the MortgageCalculatorInputVariableSet class", ignore_extras);
            fieldGeneratorTimeRange = new MortgageCalculatorTimeRangeJSON.HoldingGenerator("field \"TimeRange\" of the MortgageCalculatorInputVariableSet class", ignore_extras);
            fieldGeneratorNewInputVariables = new FieldHoldingArrayGeneratorNewInputVariables("field \"NewInputVariables\" of the MortgageCalculatorInputVariableSet class");
            fieldGeneratorDefaultCurrency = new MonetaryAmountUnitJSON.HoldingGenerator("field \"DefaultCurrency\" of the MortgageCalculatorInputVariableSet class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorInputVariableSet class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCalculationType = new FieldHoldingGeneratorCalculationType("field \"CalculationType\" of the MortgageCalculatorInputVariableSet class");
            fieldGeneratorIntermediateCalculationType = new FieldHoldingGeneratorIntermediateCalculationType("field \"IntermediateCalculationType\" of the MortgageCalculatorInputVariableSet class");
            fieldGeneratorPrincipal = new AmountJSON.HoldingGenerator("field \"Principal\" of the MortgageCalculatorInputVariableSet class", false);
            fieldGeneratorPrincipalAmbiguityWithHomeValue = new JSONHoldingBooleanGenerator("field \"PrincipalAmbiguityWithHomeValue\" of the MortgageCalculatorInputVariableSet class");
            fieldGeneratorHomeValue = new AmountJSON.HoldingGenerator("field \"HomeValue\" of the MortgageCalculatorInputVariableSet class", false);
            fieldGeneratorInterestRate = new JSONHoldingNumberTextGenerator("field \"InterestRate\" of the MortgageCalculatorInputVariableSet class");
            fieldGeneratorDownPayment = new FieldHoldingGeneratorDownPayment("field \"DownPayment\" of the MortgageCalculatorInputVariableSet class", false);
            fieldGeneratorAmortizationPeriod = new MortgageCalculatorAmortizationPeriodJSON.HoldingGenerator("field \"AmortizationPeriod\" of the MortgageCalculatorInputVariableSet class", false);
            fieldGeneratorPayment = new AmountJSON.HoldingGenerator("field \"Payment\" of the MortgageCalculatorInputVariableSet class", false);
            fieldGeneratorTimePoint = new MortgageCalculatorTimePointJSON.HoldingGenerator("field \"TimePoint\" of the MortgageCalculatorInputVariableSet class", false);
            fieldGeneratorTimeRange = new MortgageCalculatorTimeRangeJSON.HoldingGenerator("field \"TimeRange\" of the MortgageCalculatorInputVariableSet class", false);
            fieldGeneratorNewInputVariables = new FieldHoldingArrayGeneratorNewInputVariables("field \"NewInputVariables\" of the MortgageCalculatorInputVariableSet class");
            fieldGeneratorDefaultCurrency = new MonetaryAmountUnitJSON.HoldingGenerator("field \"DefaultCurrency\" of the MortgageCalculatorInputVariableSet class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorInputVariableSet class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCalculationType.reset();
            fieldGeneratorIntermediateCalculationType.reset();
            fieldGeneratorPrincipal.reset();
            fieldGeneratorPrincipalAmbiguityWithHomeValue.reset();
            fieldGeneratorHomeValue.reset();
            fieldGeneratorInterestRate.reset();
            fieldGeneratorDownPayment.reset();
            fieldGeneratorAmortizationPeriod.reset();
            fieldGeneratorPayment.reset();
            fieldGeneratorTimePoint.reset();
            fieldGeneratorTimeRange.reset();
            fieldGeneratorNewInputVariables.reset();
            fieldGeneratorDefaultCurrency.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPrincipal.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHomeValue.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmortizationPeriod.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPayment.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTimePoint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTimeRange.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDefaultCurrency.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPrincipal.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHomeValue.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmortizationPeriod.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPayment.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTimePoint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTimeRange.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDefaultCurrency.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorInputVariableSetJSON  result)
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
        public MortgageCalculatorInputVariableSetJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorInputVariableSetJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorInputVariableSetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorInputVariableSetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorInputVariableSetJSON>();
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
    public List<MortgageCalculatorInputVariableSetJSON> value;
  };
  };
