/* file "TimeBetweenTimesInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimeBetweenTimesInformationNuggetJSON : DateAndTimeInformationNuggetJSON
  {
    public enum TypeUnitsKnownValues
      {
        Units_unknown,
        Units_days,
        Units_weeks,
        Units_months,
        Units_years,
        Units_decades,
        Units_centuries,
        Units_seconds,
        Units_minutes,
        Units_hours,
        Units__none
      };
    public struct TypeUnits
      {
        public bool in_known_list;
        public string string_value;
        public TypeUnitsKnownValues list_value;
      };

    public static TypeUnitsKnownValues  stringToUnits(string chars)
      {
        switch (chars[0])
          {
            case 'c':
                if ((String.Compare(chars, 1, "enturies", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeUnitsKnownValues.Units_centuries;
                break;
            case 'd':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "ys", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeUnitsKnownValues.Units_days;
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "cades", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeUnitsKnownValues.Units_decades;
                        break;
                    default:
                        break;
                  }
                break;
            case 'h':
                if ((String.Compare(chars, 1, "ours", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeUnitsKnownValues.Units_hours;
                break;
            case 'm':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "nutes", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeUnitsKnownValues.Units_minutes;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "nths", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeUnitsKnownValues.Units_months;
                        break;
                    default:
                        break;
                  }
                break;
            case 's':
                if ((String.Compare(chars, 1, "econds", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeUnitsKnownValues.Units_seconds;
                break;
            case 'u':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeUnitsKnownValues.Units_unknown;
                break;
            case 'w':
                if ((String.Compare(chars, 1, "eeks", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeUnitsKnownValues.Units_weeks;
                break;
            case 'y':
                if ((String.Compare(chars, 1, "ears", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeUnitsKnownValues.Units_years;
                break;
            default:
                break;
          }
        return TypeUnitsKnownValues.Units__none;
      }

    public static string  stringFromUnits(TypeUnitsKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeUnitsKnownValues.Units_unknown:
                return "unknown";
            case TypeUnitsKnownValues.Units_days:
                return "days";
            case TypeUnitsKnownValues.Units_weeks:
                return "weeks";
            case TypeUnitsKnownValues.Units_months:
                return "months";
            case TypeUnitsKnownValues.Units_years:
                return "years";
            case TypeUnitsKnownValues.Units_decades:
                return "decades";
            case TypeUnitsKnownValues.Units_centuries:
                return "centuries";
            case TypeUnitsKnownValues.Units_seconds:
                return "seconds";
            case TypeUnitsKnownValues.Units_minutes:
                return "minutes";
            case TypeUnitsKnownValues.Units_hours:
                return "hours";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasSourceDateAndOrTimeSpec;
    private DateAndOrTimeSpecJSON  storeSourceDateAndOrTimeSpec;
    private bool flagHasDestinationDateAndOrTimeSpec;
    private DateAndOrTimeSpecJSON  storeDestinationDateAndOrTimeSpec;
    private bool flagHasUnitOfMeasureAmount;
    private UnitOfMeasureAmountJSON  storeUnitOfMeasureAmount;
    private bool flagHasTimeDifference;
    private double storeTimeDifference;
    private string textStoreTimeDifference;
    private bool flagHasUnits;
    private TypeUnits storeUnits;
    private bool flagHasMultipleUnitTimeDifference;
    private List< AmountJSON  > storeMultipleUnitTimeDifference;
    private bool flagHasMultipleUnitTimeDifferenceWritten;
    private string storeMultipleUnitTimeDifferenceWritten;
    private bool flagHasMultipleUnitTimeDifferenceSpoken;
    private string storeMultipleUnitTimeDifferenceSpoken;
    private bool flagHasRequestedInThePast;
    private bool storeRequestedInThePast;
    private bool flagHasIsBetweenTwoDateTimes;
    private bool storeIsBetweenTwoDateTimes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSourceDateAndOrTimeSpecToJSON()
      {
        JSONValueHandler handler_SourceDateAndOrTimeSpec = new JSONValueHandler();
        storeSourceDateAndOrTimeSpec.write_as_json(handler_SourceDateAndOrTimeSpec);
        return handler_SourceDateAndOrTimeSpec.result;
      }

    private JSONValue  extraDestinationDateAndOrTimeSpecToJSON()
      {
        JSONValueHandler handler_DestinationDateAndOrTimeSpec = new JSONValueHandler();
        storeDestinationDateAndOrTimeSpec.write_as_json(handler_DestinationDateAndOrTimeSpec);
        return handler_DestinationDateAndOrTimeSpec.result;
      }

    private JSONValue  extraUnitOfMeasureAmountToJSON()
      {
        JSONValueHandler handler_UnitOfMeasureAmount = new JSONValueHandler();
        storeUnitOfMeasureAmount.write_as_json(handler_UnitOfMeasureAmount);
        return handler_UnitOfMeasureAmount.result;
      }

    private JSONValue  extraTimeDifferenceToJSON()
      {
        JSONValue generated_rational_TimeDifference;
        if (textStoreTimeDifference != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreTimeDifference);
            generated_rational_TimeDifference = handler.result;
          }
        else if (((double)(long)storeTimeDifference) == storeTimeDifference)
            generated_rational_TimeDifference = new JSONIntegerValue((long)(storeTimeDifference));
        else
            generated_rational_TimeDifference = new JSONRationalValue(storeTimeDifference, 15);
        return generated_rational_TimeDifference;
      }

    private JSONValue  extraUnitsToJSON()
      {
        JSONStringValue generated_string_Units;
        if (!(storeUnits.in_known_list))
          {
        generated_string_Units = new JSONStringValue(storeUnits.string_value);
          }
        else
          {
        switch (storeUnits.list_value)
          {
            case TypeUnitsKnownValues.Units_unknown:
                generated_string_Units = new JSONStringValue("unknown");
                break;
            case TypeUnitsKnownValues.Units_days:
                generated_string_Units = new JSONStringValue("days");
                break;
            case TypeUnitsKnownValues.Units_weeks:
                generated_string_Units = new JSONStringValue("weeks");
                break;
            case TypeUnitsKnownValues.Units_months:
                generated_string_Units = new JSONStringValue("months");
                break;
            case TypeUnitsKnownValues.Units_years:
                generated_string_Units = new JSONStringValue("years");
                break;
            case TypeUnitsKnownValues.Units_decades:
                generated_string_Units = new JSONStringValue("decades");
                break;
            case TypeUnitsKnownValues.Units_centuries:
                generated_string_Units = new JSONStringValue("centuries");
                break;
            case TypeUnitsKnownValues.Units_seconds:
                generated_string_Units = new JSONStringValue("seconds");
                break;
            case TypeUnitsKnownValues.Units_minutes:
                generated_string_Units = new JSONStringValue("minutes");
                break;
            case TypeUnitsKnownValues.Units_hours:
                generated_string_Units = new JSONStringValue("hours");
                break;
            default:
                Debug.Assert(false);
                generated_string_Units = null;
                break;
          }
          }
        return generated_string_Units;
      }

    private JSONValue  extraMultipleUnitTimeDifferenceToJSON()
      {
        JSONArrayValue generated_array_1_MultipleUnitTimeDifference = new JSONArrayValue();
        for (int num1 = 0; num1 < storeMultipleUnitTimeDifference.Count; ++num1)
          {
            JSONValueHandler handler_MultipleUnitTimeDifference = new JSONValueHandler();
            storeMultipleUnitTimeDifference[num1].write_as_json(handler_MultipleUnitTimeDifference);
            generated_array_1_MultipleUnitTimeDifference.appendComponent(handler_MultipleUnitTimeDifference.result);
          }
        return generated_array_1_MultipleUnitTimeDifference;
      }

    private JSONValue  extraMultipleUnitTimeDifferenceWrittenToJSON()
      {
        JSONStringValue generated_string_MultipleUnitTimeDifferenceWritten = new JSONStringValue(storeMultipleUnitTimeDifferenceWritten);
        return generated_string_MultipleUnitTimeDifferenceWritten;
      }

    private JSONValue  extraMultipleUnitTimeDifferenceSpokenToJSON()
      {
        JSONStringValue generated_string_MultipleUnitTimeDifferenceSpoken = new JSONStringValue(storeMultipleUnitTimeDifferenceSpoken);
        return generated_string_MultipleUnitTimeDifferenceSpoken;
      }

    private JSONValue  extraRequestedInThePastToJSON()
      {
        JSONValue generated_boolean_RequestedInThePast = (storeRequestedInThePast ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RequestedInThePast;
      }

    private JSONValue  extraIsBetweenTwoDateTimesToJSON()
      {
        JSONValue generated_boolean_IsBetweenTwoDateTimes = (storeIsBetweenTwoDateTimes ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsBetweenTwoDateTimes;
      }


    private void  fromJSONSourceDateAndOrTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeSpecJSON convert_classy = DateAndOrTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setSourceDateAndOrTimeSpec(convert_classy);
      }


    private void  fromJSONDestinationDateAndOrTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeSpecJSON convert_classy = DateAndOrTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setDestinationDateAndOrTimeSpec(convert_classy);
      }


    private void  fromJSONUnitOfMeasureAmount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UnitOfMeasureAmountJSON convert_classy = UnitOfMeasureAmountJSON.from_json(json_value, ignore_extras, true);
        setUnitOfMeasureAmount(convert_classy);
      }


    private void  fromJSONTimeDifference(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TimeDifference of TimeBetweenTimesInformationNuggetJSON is not a number.");
              }
          }
        setTimeDifferenceText(the_rational_text);
      }


    private void  fromJSONUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Units of TimeBetweenTimesInformationNuggetJSON is not a string.");
        TypeUnits the_open_enum = new TypeUnits();
        switch (json_string.getData()[0])
          {
            case 'c':
                if ((String.Compare(json_string.getData(), 1, "enturies", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeUnitsKnownValues.Units_centuries;
                        goto open_enum_is_done;
                      }
                break;
            case 'd':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "ys", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeUnitsKnownValues.Units_days;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "cades", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeUnitsKnownValues.Units_decades;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'h':
                if ((String.Compare(json_string.getData(), 1, "ours", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeUnitsKnownValues.Units_hours;
                        goto open_enum_is_done;
                      }
                break;
            case 'm':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "nutes", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeUnitsKnownValues.Units_minutes;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "nths", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeUnitsKnownValues.Units_months;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 's':
                if ((String.Compare(json_string.getData(), 1, "econds", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeUnitsKnownValues.Units_seconds;
                        goto open_enum_is_done;
                      }
                break;
            case 'u':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeUnitsKnownValues.Units_unknown;
                        goto open_enum_is_done;
                      }
                break;
            case 'w':
                if ((String.Compare(json_string.getData(), 1, "eeks", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeUnitsKnownValues.Units_weeks;
                        goto open_enum_is_done;
                      }
                break;
            case 'y':
                if ((String.Compare(json_string.getData(), 1, "ears", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeUnitsKnownValues.Units_years;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setUnits(the_open_enum);
      }


    private void  fromJSONMultipleUnitTimeDifference(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MultipleUnitTimeDifference of TimeBetweenTimesInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field MultipleUnitTimeDifference of TimeBetweenTimesInformationNuggetJSON has too few elements.");
        List< AmountJSON  > vector_MultipleUnitTimeDifference1 = new List< AmountJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AmountJSON convert_classy = AmountJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_MultipleUnitTimeDifference1.Add(convert_classy);
          }
        Debug.Assert(vector_MultipleUnitTimeDifference1.Count >= 1);
        initMultipleUnitTimeDifference();
        for (int num1 = 0; num1 < vector_MultipleUnitTimeDifference1.Count; ++num1)
            appendMultipleUnitTimeDifference(vector_MultipleUnitTimeDifference1[num1]);
        for (int num1 = 0; num1 < vector_MultipleUnitTimeDifference1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMultipleUnitTimeDifferenceWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MultipleUnitTimeDifferenceWritten of TimeBetweenTimesInformationNuggetJSON is not a string.");
        setMultipleUnitTimeDifferenceWritten(json_string.getData());
      }


    private void  fromJSONMultipleUnitTimeDifferenceSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MultipleUnitTimeDifferenceSpoken of TimeBetweenTimesInformationNuggetJSON is not a string.");
        setMultipleUnitTimeDifferenceSpoken(json_string.getData());
      }


    private void  fromJSONRequestedInThePast(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RequestedInThePast of TimeBetweenTimesInformationNuggetJSON is not true for false.");
              }
          }
        setRequestedInThePast(the_bool);
      }


    private void  fromJSONIsBetweenTwoDateTimes(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsBetweenTwoDateTimes of TimeBetweenTimesInformationNuggetJSON is not true for false.");
              }
          }
        setIsBetweenTwoDateTimes(the_bool);
      }


    public TimeBetweenTimesInformationNuggetJSON()
      {
        flagHasSourceDateAndOrTimeSpec = false;
        flagHasDestinationDateAndOrTimeSpec = false;
        flagHasUnitOfMeasureAmount = false;
        flagHasTimeDifference = false;
        flagHasUnits = false;
        flagHasMultipleUnitTimeDifference = false;
        flagHasMultipleUnitTimeDifferenceWritten = false;
        flagHasMultipleUnitTimeDifferenceSpoken = false;
        flagHasRequestedInThePast = false;
        flagHasIsBetweenTwoDateTimes = false;
        storeMultipleUnitTimeDifference = new List< AmountJSON  >();
        storeRequestedInThePast = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDateAndTimeNuggetKind()
      {
        return "TimeBetweenTimes";
      }

    public bool  hasSourceDateAndOrTimeSpec()
      {
        return flagHasSourceDateAndOrTimeSpec;
      }

    public DateAndOrTimeSpecJSON   getSourceDateAndOrTimeSpec()
      {
        Debug.Assert(flagHasSourceDateAndOrTimeSpec);
        return storeSourceDateAndOrTimeSpec;
      }

    public bool  hasDestinationDateAndOrTimeSpec()
      {
        return flagHasDestinationDateAndOrTimeSpec;
      }

    public DateAndOrTimeSpecJSON   getDestinationDateAndOrTimeSpec()
      {
        Debug.Assert(flagHasDestinationDateAndOrTimeSpec);
        return storeDestinationDateAndOrTimeSpec;
      }

    public bool  hasUnitOfMeasureAmount()
      {
        return flagHasUnitOfMeasureAmount;
      }

    public UnitOfMeasureAmountJSON   getUnitOfMeasureAmount()
      {
        Debug.Assert(flagHasUnitOfMeasureAmount);
        return storeUnitOfMeasureAmount;
      }

    public bool  hasTimeDifference()
      {
        return flagHasTimeDifference;
      }

    public double  getTimeDifference()
      {
        Debug.Assert(flagHasTimeDifference);
        if (textStoreTimeDifference != "")
          {
            return Double.Parse(textStoreTimeDifference);
          }
        return storeTimeDifference;
      }

    public string  getTimeDifferenceAsText()
      {
        Debug.Assert(flagHasTimeDifference);
        if (textStoreTimeDifference == "")
          {
            return Convert.ToString(storeTimeDifference);
          }
        else
          {
            return (textStoreTimeDifference);
          }
      }

    public bool  hasUnits()
      {
        return flagHasUnits;
      }

    public TypeUnits  getUnits()
      {
        Debug.Assert(flagHasUnits);
        return storeUnits;
      }

    public string  getUnitsAsString()
      {
        TypeUnits result = getUnits();
        if (result.in_known_list)
            return stringFromUnits(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasMultipleUnitTimeDifference()
      {
        return flagHasMultipleUnitTimeDifference;
      }

    public int  countOfMultipleUnitTimeDifference()
      {
        Debug.Assert(flagHasMultipleUnitTimeDifference);
        return storeMultipleUnitTimeDifference.Count;
      }

    public AmountJSON   elementOfMultipleUnitTimeDifference(int element_num)
      {
        Debug.Assert(flagHasMultipleUnitTimeDifference);
        return storeMultipleUnitTimeDifference[element_num];
      }

    public List< AmountJSON  >  getMultipleUnitTimeDifference()
      {
        Debug.Assert(flagHasMultipleUnitTimeDifference);
        return storeMultipleUnitTimeDifference;
      }

    public bool  hasMultipleUnitTimeDifferenceWritten()
      {
        return flagHasMultipleUnitTimeDifferenceWritten;
      }

    public string  getMultipleUnitTimeDifferenceWritten()
      {
        Debug.Assert(flagHasMultipleUnitTimeDifferenceWritten);
        return storeMultipleUnitTimeDifferenceWritten;
      }

    public bool  hasMultipleUnitTimeDifferenceSpoken()
      {
        return flagHasMultipleUnitTimeDifferenceSpoken;
      }

    public string  getMultipleUnitTimeDifferenceSpoken()
      {
        Debug.Assert(flagHasMultipleUnitTimeDifferenceSpoken);
        return storeMultipleUnitTimeDifferenceSpoken;
      }

    public bool  hasRequestedInThePast()
      {
        return flagHasRequestedInThePast;
      }

    public bool  getRequestedInThePast()
      {
        return storeRequestedInThePast;
      }

    public bool  hasIsBetweenTwoDateTimes()
      {
        return flagHasIsBetweenTwoDateTimes;
      }

    public bool  getIsBetweenTwoDateTimes()
      {
        Debug.Assert(flagHasIsBetweenTwoDateTimes);
        return storeIsBetweenTwoDateTimes;
      }


    public virtual int extraTimeBetweenTimesInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimeBetweenTimesInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimeBetweenTimesInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimeBetweenTimesInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDateAndTimeInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasSourceDateAndOrTimeSpec)
            ++result;
        if (flagHasDestinationDateAndOrTimeSpec)
            ++result;
        if (flagHasUnitOfMeasureAmount)
            ++result;
        if (flagHasTimeDifference)
            ++result;
        if (flagHasUnits)
            ++result;
        if (flagHasMultipleUnitTimeDifference)
            ++result;
        if (flagHasMultipleUnitTimeDifferenceWritten)
            ++result;
        if (flagHasMultipleUnitTimeDifferenceSpoken)
            ++result;
        if (flagHasRequestedInThePast)
            ++result;
        if (flagHasIsBetweenTwoDateTimes)
            ++result;
        result += extraTimeBetweenTimesInformationNuggetComponentCount();
        return result;
      }
    public override string extraDateAndTimeInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSourceDateAndOrTimeSpec)
          {
            if (remainder == 0)
                return "SourceDateAndOrTimeSpec";
            --remainder;
          }
        if (flagHasDestinationDateAndOrTimeSpec)
          {
            if (remainder == 0)
                return "DestinationDateAndOrTimeSpec";
            --remainder;
          }
        if (flagHasUnitOfMeasureAmount)
          {
            if (remainder == 0)
                return "UnitOfMeasureAmount";
            --remainder;
          }
        if (flagHasTimeDifference)
          {
            if (remainder == 0)
                return "TimeDifference";
            --remainder;
          }
        if (flagHasUnits)
          {
            if (remainder == 0)
                return "Units";
            --remainder;
          }
        if (flagHasMultipleUnitTimeDifference)
          {
            if (remainder == 0)
                return "MultipleUnitTimeDifference";
            --remainder;
          }
        if (flagHasMultipleUnitTimeDifferenceWritten)
          {
            if (remainder == 0)
                return "MultipleUnitTimeDifferenceWritten";
            --remainder;
          }
        if (flagHasMultipleUnitTimeDifferenceSpoken)
          {
            if (remainder == 0)
                return "MultipleUnitTimeDifferenceSpoken";
            --remainder;
          }
        if (flagHasRequestedInThePast)
          {
            if (remainder == 0)
                return "RequestedInThePast";
            --remainder;
          }
        if (flagHasIsBetweenTwoDateTimes)
          {
            if (remainder == 0)
                return "IsBetweenTwoDateTimes";
            --remainder;
          }
        return extraTimeBetweenTimesInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSourceDateAndOrTimeSpec)
          {
            if (remainder == 0)
                return extraSourceDateAndOrTimeSpecToJSON();
            --remainder;
          }
        if (flagHasDestinationDateAndOrTimeSpec)
          {
            if (remainder == 0)
                return extraDestinationDateAndOrTimeSpecToJSON();
            --remainder;
          }
        if (flagHasUnitOfMeasureAmount)
          {
            if (remainder == 0)
                return extraUnitOfMeasureAmountToJSON();
            --remainder;
          }
        if (flagHasTimeDifference)
          {
            if (remainder == 0)
                return extraTimeDifferenceToJSON();
            --remainder;
          }
        if (flagHasUnits)
          {
            if (remainder == 0)
                return extraUnitsToJSON();
            --remainder;
          }
        if (flagHasMultipleUnitTimeDifference)
          {
            if (remainder == 0)
                return extraMultipleUnitTimeDifferenceToJSON();
            --remainder;
          }
        if (flagHasMultipleUnitTimeDifferenceWritten)
          {
            if (remainder == 0)
                return extraMultipleUnitTimeDifferenceWrittenToJSON();
            --remainder;
          }
        if (flagHasMultipleUnitTimeDifferenceSpoken)
          {
            if (remainder == 0)
                return extraMultipleUnitTimeDifferenceSpokenToJSON();
            --remainder;
          }
        if (flagHasRequestedInThePast)
          {
            if (remainder == 0)
                return extraRequestedInThePastToJSON();
            --remainder;
          }
        if (flagHasIsBetweenTwoDateTimes)
          {
            if (remainder == 0)
                return extraIsBetweenTwoDateTimesToJSON();
            --remainder;
          }
        return extraTimeBetweenTimesInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "estinationDateAndOrTimeSpec", 0, 27, false) == 0) && (field_name.Length == 28))
                    return (flagHasDestinationDateAndOrTimeSpec ? extraDestinationDateAndOrTimeSpecToJSON() : null);
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "sBetweenTwoDateTimes", 0, 20, false) == 0) && (field_name.Length == 21))
                    return (flagHasIsBetweenTwoDateTimes ? extraIsBetweenTwoDateTimesToJSON() : null);
                break;
            case 'M':
                if (String.Compare(field_name, 1, "ultipleUnitTimeDifference", 0, 25, false) == 0)
                  {
                    if (field_name.Length == 26)
                      {
                        return (flagHasMultipleUnitTimeDifference ? extraMultipleUnitTimeDifferenceToJSON() : null);
                      }
                    switch (field_name[26])
                      {
                        case 'S':
                            if ((String.Compare(field_name, 27, "poken", 0, 5, false) == 0) && (field_name.Length == 32))
                                return (flagHasMultipleUnitTimeDifferenceSpoken ? extraMultipleUnitTimeDifferenceSpokenToJSON() : null);
                            break;
                        case 'W':
                            if ((String.Compare(field_name, 27, "ritten", 0, 6, false) == 0) && (field_name.Length == 33))
                                return (flagHasMultipleUnitTimeDifferenceWritten ? extraMultipleUnitTimeDifferenceWrittenToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "equestedInThePast", 0, 17, false) == 0) && (field_name.Length == 18))
                    return (flagHasRequestedInThePast ? extraRequestedInThePastToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "ourceDateAndOrTimeSpec", 0, 22, false) == 0) && (field_name.Length == 23))
                    return (flagHasSourceDateAndOrTimeSpec ? extraSourceDateAndOrTimeSpecToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "imeDifference", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasTimeDifference ? extraTimeDifferenceToJSON() : null);
                break;
            case 'U':
                if (String.Compare(field_name, 1, "nit", 0, 3, false) == 0)
                  {
                    switch (field_name[4])
                      {
                        case 'O':
                            if ((String.Compare(field_name, 5, "fMeasureAmount", 0, 14, false) == 0) && (field_name.Length == 19))
                                return (flagHasUnitOfMeasureAmount ? extraUnitOfMeasureAmountToJSON() : null);
                            break;
                        case 's':
                            if (field_name.Length == 5)
                                return (flagHasUnits ? extraUnitsToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraTimeBetweenTimesInformationNuggetLookup(field_name);
      }

    public void setSourceDateAndOrTimeSpec(DateAndOrTimeSpecJSON  new_value)
      {
        if (flagHasSourceDateAndOrTimeSpec)
          {
          }
        flagHasSourceDateAndOrTimeSpec = true;
        storeSourceDateAndOrTimeSpec = new_value;
      }
    public void unsetSourceDateAndOrTimeSpec()
      {
        if (flagHasSourceDateAndOrTimeSpec)
          {
          }
        flagHasSourceDateAndOrTimeSpec = false;
      }
    public void setDestinationDateAndOrTimeSpec(DateAndOrTimeSpecJSON  new_value)
      {
        if (flagHasDestinationDateAndOrTimeSpec)
          {
          }
        flagHasDestinationDateAndOrTimeSpec = true;
        storeDestinationDateAndOrTimeSpec = new_value;
      }
    public void unsetDestinationDateAndOrTimeSpec()
      {
        if (flagHasDestinationDateAndOrTimeSpec)
          {
          }
        flagHasDestinationDateAndOrTimeSpec = false;
      }
    public void setUnitOfMeasureAmount(UnitOfMeasureAmountJSON  new_value)
      {
        if (flagHasUnitOfMeasureAmount)
          {
          }
        flagHasUnitOfMeasureAmount = true;
        storeUnitOfMeasureAmount = new_value;
      }
    public void unsetUnitOfMeasureAmount()
      {
        if (flagHasUnitOfMeasureAmount)
          {
          }
        flagHasUnitOfMeasureAmount = false;
      }
    public void setTimeDifference(double new_value)
      {
        flagHasTimeDifference = true;
        storeTimeDifference = new_value;
        textStoreTimeDifference = "";
      }
    public void setTimeDifferenceText(string new_value)
      {
        flagHasTimeDifference = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TimeDifference of TimeBetweenTimesInformationNuggetJSON is not a valid number.");
        textStoreTimeDifference = new_value;
      }
    public void unsetTimeDifference()
      {
        flagHasTimeDifference = false;
      }
    public void setUnits(TypeUnits new_value)
      {
        flagHasUnits = true;
        storeUnits = new_value;
      }
    public void setUnits(string chars)
      {
        TypeUnitsKnownValues known = stringToUnits(chars);
        TypeUnits new_value = new TypeUnits();
        if (known == TypeUnitsKnownValues.Units__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setUnits(new_value);
      }
    public void setUnits(TypeUnitsKnownValues new_value)
      {
        TypeUnits new_full_value = new TypeUnits();
        Debug.Assert(new_value != TypeUnitsKnownValues.Units__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setUnits(new_full_value);
      }
    public void unsetUnits()
      {
        flagHasUnits = false;
      }
    public void initMultipleUnitTimeDifference()
      {
        if (flagHasMultipleUnitTimeDifference)
          {
            for (int num1 = 0; num1 < storeMultipleUnitTimeDifference.Count; ++num1)
              {
              }
          }
        flagHasMultipleUnitTimeDifference = true;
        storeMultipleUnitTimeDifference.Clear();
      }
    public void appendMultipleUnitTimeDifference(AmountJSON  to_append)
      {
        if (!flagHasMultipleUnitTimeDifference)
          {
            flagHasMultipleUnitTimeDifference = true;
            storeMultipleUnitTimeDifference.Clear();
          }
        Debug.Assert(flagHasMultipleUnitTimeDifference);
        storeMultipleUnitTimeDifference.Add(to_append);
      }
    public void unsetMultipleUnitTimeDifference()
      {
        if (flagHasMultipleUnitTimeDifference)
          {
            for (int num2 = 0; num2 < storeMultipleUnitTimeDifference.Count; ++num2)
              {
              }
          }
        flagHasMultipleUnitTimeDifference = false;
        storeMultipleUnitTimeDifference.Clear();
      }
    public void setMultipleUnitTimeDifferenceWritten(string new_value)
      {
        flagHasMultipleUnitTimeDifferenceWritten = true;
        storeMultipleUnitTimeDifferenceWritten = new_value;
      }
    public void unsetMultipleUnitTimeDifferenceWritten()
      {
        flagHasMultipleUnitTimeDifferenceWritten = false;
      }
    public void setMultipleUnitTimeDifferenceSpoken(string new_value)
      {
        flagHasMultipleUnitTimeDifferenceSpoken = true;
        storeMultipleUnitTimeDifferenceSpoken = new_value;
      }
    public void unsetMultipleUnitTimeDifferenceSpoken()
      {
        flagHasMultipleUnitTimeDifferenceSpoken = false;
      }
    public void setRequestedInThePast(bool new_value)
      {
        flagHasRequestedInThePast = true;
        storeRequestedInThePast = new_value;
      }
    public void unsetRequestedInThePast()
      {
        flagHasRequestedInThePast = false;
      }
    public void setIsBetweenTwoDateTimes(bool new_value)
      {
        flagHasIsBetweenTwoDateTimes = true;
        storeIsBetweenTwoDateTimes = new_value;
      }
    public void unsetIsBetweenTwoDateTimes()
      {
        flagHasIsBetweenTwoDateTimes = false;
      }

    public virtual void extraTimeBetweenTimesInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimeBetweenTimesInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimeBetweenTimesInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraTimeBetweenTimesInformationNuggetAppendPair(key, new_component);
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
    public override void extraDateAndTimeInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "estinationDateAndOrTimeSpec", 0, 27, false) == 0) && (key.Length == 28))
                    {
                    fromJSONDestinationDateAndOrTimeSpec(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "sBetweenTwoDateTimes", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONIsBetweenTwoDateTimes(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if (String.Compare(key, 1, "ultipleUnitTimeDifference", 0, 25, false) == 0)
                  {
                    if (key.Length == 26)
                      {
                        {
                        fromJSONMultipleUnitTimeDifference(new_component, false);
                        return;
                        }
                      }
                    switch (key[26])
                      {
                        case 'S':
                            if ((String.Compare(key, 27, "poken", 0, 5, false) == 0) && (key.Length == 32))
                                {
                                fromJSONMultipleUnitTimeDifferenceSpoken(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 27, "ritten", 0, 6, false) == 0) && (key.Length == 33))
                                {
                                fromJSONMultipleUnitTimeDifferenceWritten(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedInThePast", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONRequestedInThePast(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "ourceDateAndOrTimeSpec", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONSourceDateAndOrTimeSpec(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "imeDifference", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONTimeDifference(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if (String.Compare(key, 1, "nit", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'O':
                            if ((String.Compare(key, 5, "fMeasureAmount", 0, 14, false) == 0) && (key.Length == 19))
                                {
                                fromJSONUnitOfMeasureAmount(new_component, false);
                                return;
                                }
                            break;
                        case 's':
                            if (key.Length == 5)
                                {
                                fromJSONUnits(new_component, false);
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
        extraTimeBetweenTimesInformationNuggetAppendPair(key, new_component);
      }
    public override void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "estinationDateAndOrTimeSpec", 0, 27, false) == 0) && (key.Length == 28))
                    {
                    fromJSONDestinationDateAndOrTimeSpec(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "sBetweenTwoDateTimes", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONIsBetweenTwoDateTimes(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if (String.Compare(key, 1, "ultipleUnitTimeDifference", 0, 25, false) == 0)
                  {
                    if (key.Length == 26)
                      {
                        {
                        fromJSONMultipleUnitTimeDifference(new_component, false);
                        return;
                        }
                      }
                    switch (key[26])
                      {
                        case 'S':
                            if ((String.Compare(key, 27, "poken", 0, 5, false) == 0) && (key.Length == 32))
                                {
                                fromJSONMultipleUnitTimeDifferenceSpoken(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 27, "ritten", 0, 6, false) == 0) && (key.Length == 33))
                                {
                                fromJSONMultipleUnitTimeDifferenceWritten(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "equestedInThePast", 0, 17, false) == 0) && (key.Length == 18))
                    {
                    fromJSONRequestedInThePast(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "ourceDateAndOrTimeSpec", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONSourceDateAndOrTimeSpec(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "imeDifference", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONTimeDifference(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if (String.Compare(key, 1, "nit", 0, 3, false) == 0)
                  {
                    switch (key[4])
                      {
                        case 'O':
                            if ((String.Compare(key, 5, "fMeasureAmount", 0, 14, false) == 0) && (key.Length == 19))
                                {
                                fromJSONUnitOfMeasureAmount(new_component, false);
                                return;
                                }
                            break;
                        case 's':
                            if (key.Length == 5)
                                {
                                fromJSONUnits(new_component, false);
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
        extraTimeBetweenTimesInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSourceDateAndOrTimeSpec);
        if (flagHasSourceDateAndOrTimeSpec)
          {
            handler.start_pair("SourceDateAndOrTimeSpec");
            if (partial_allowed)
                storeSourceDateAndOrTimeSpec.write_partial_as_json(handler);
            else
                storeSourceDateAndOrTimeSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDestinationDateAndOrTimeSpec);
        if (flagHasDestinationDateAndOrTimeSpec)
          {
            handler.start_pair("DestinationDateAndOrTimeSpec");
            if (partial_allowed)
                storeDestinationDateAndOrTimeSpec.write_partial_as_json(handler);
            else
                storeDestinationDateAndOrTimeSpec.write_as_json(handler);
          }
        if (flagHasUnitOfMeasureAmount)
          {
            handler.start_pair("UnitOfMeasureAmount");
            if (partial_allowed)
                storeUnitOfMeasureAmount.write_partial_as_json(handler);
            else
                storeUnitOfMeasureAmount.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasTimeDifference);
        if (flagHasTimeDifference)
          {
            handler.start_pair("TimeDifference");
            if (textStoreTimeDifference != "")
                handler.number_value(textStoreTimeDifference);
            else if (((double)(long)storeTimeDifference) == storeTimeDifference)
                handler.number_value((long)storeTimeDifference);
            else
                handler.number_value(storeTimeDifference);
          }
        if (flagHasUnits)
          {
            handler.start_pair("Units");
            if (storeUnits.in_known_list)
              {
                switch (storeUnits.list_value)
                  {
                    case TypeUnitsKnownValues.Units_unknown:
                        handler.string_value("unknown");
                        break;
                    case TypeUnitsKnownValues.Units_days:
                        handler.string_value("days");
                        break;
                    case TypeUnitsKnownValues.Units_weeks:
                        handler.string_value("weeks");
                        break;
                    case TypeUnitsKnownValues.Units_months:
                        handler.string_value("months");
                        break;
                    case TypeUnitsKnownValues.Units_years:
                        handler.string_value("years");
                        break;
                    case TypeUnitsKnownValues.Units_decades:
                        handler.string_value("decades");
                        break;
                    case TypeUnitsKnownValues.Units_centuries:
                        handler.string_value("centuries");
                        break;
                    case TypeUnitsKnownValues.Units_seconds:
                        handler.string_value("seconds");
                        break;
                    case TypeUnitsKnownValues.Units_minutes:
                        handler.string_value("minutes");
                        break;
                    case TypeUnitsKnownValues.Units_hours:
                        handler.string_value("hours");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeUnits.string_value);
              }
          }
        if (flagHasMultipleUnitTimeDifference)
          {
            handler.start_pair("MultipleUnitTimeDifference");
            Debug.Assert(storeMultipleUnitTimeDifference.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeMultipleUnitTimeDifference.Count; ++num1)
              {
                if (partial_allowed)
                    storeMultipleUnitTimeDifference[num1].write_partial_as_json(handler);
                else
                    storeMultipleUnitTimeDifference[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasMultipleUnitTimeDifferenceWritten)
          {
            handler.start_pair("MultipleUnitTimeDifferenceWritten");
            handler.string_value(storeMultipleUnitTimeDifferenceWritten);
          }
        if (flagHasMultipleUnitTimeDifferenceSpoken)
          {
            handler.start_pair("MultipleUnitTimeDifferenceSpoken");
            handler.string_value(storeMultipleUnitTimeDifferenceSpoken);
          }
        Debug.Assert(partial_allowed || flagHasRequestedInThePast);
        if (flagHasRequestedInThePast)
          {
            handler.start_pair("RequestedInThePast");
            handler.boolean_value(storeRequestedInThePast);
          }
        Debug.Assert(partial_allowed || flagHasIsBetweenTwoDateTimes);
        if (flagHasIsBetweenTwoDateTimes)
          {
            handler.start_pair("IsBetweenTwoDateTimes");
            handler.boolean_value(storeIsBetweenTwoDateTimes);
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
        if (!(hasSourceDateAndOrTimeSpec()))
          {
            return "When parsing the object for %what%, the \"SourceDateAndOrTimeSpec\" field was missing.";
          }
        if (!(hasDestinationDateAndOrTimeSpec()))
          {
            return "When parsing the object for %what%, the \"DestinationDateAndOrTimeSpec\" field was missing.";
          }
        if (!(hasTimeDifference()))
          {
            return "When parsing the object for %what%, the \"TimeDifference\" field was missing.";
          }
        if (!(hasRequestedInThePast()))
          {
            return "When parsing the object for %what%, the \"RequestedInThePast\" field was missing.";
          }
        if (!(hasIsBetweenTwoDateTimes()))
          {
            return "When parsing the object for %what%, the \"IsBetweenTwoDateTimes\" field was missing.";
          }
        return null;
      }

    public static new TimeBetweenTimesInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeBetweenTimesInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenTimesInformationNugget", ignore_extras);
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
    public static new TimeBetweenTimesInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimeBetweenTimesInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeBetweenTimesInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenTimesInformationNugget", ignore_extras);
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
    public static new TimeBetweenTimesInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new TimeBetweenTimesInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        TimeBetweenTimesInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenTimesInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimeBetweenTimesInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new TimeBetweenTimesInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimeBetweenTimesInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenTimesInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DateAndTimeInformationNuggetJSON.Generator
      {
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorSourceDateAndOrTimeSpec;
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorDestinationDateAndOrTimeSpec;
        private UnitOfMeasureAmountJSON.HoldingGenerator fieldGeneratorUnitOfMeasureAmount;
        private JSONHoldingNumberTextGenerator fieldGeneratorTimeDifference;
    private abstract class FieldGeneratorUnits : JSONStringGenerator
          {
            protected FieldGeneratorUnits(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorUnits()
              {
              }
            protected override void handle_result(string result)
              {
                TypeUnitsKnownValues known = stringToUnits(result);
                TypeUnits new_value = new TypeUnits();
                if (known == TypeUnitsKnownValues.Units__none)
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
            protected abstract void handle_result(TypeUnits result);
          };
    private class FieldHoldingGeneratorUnits : FieldGeneratorUnits
  {
    protected override void handle_result(TypeUnits result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorUnits(String what)
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
    public TypeUnits value;
  };
    private class FieldHoldingArrayGeneratorUnits : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorUnits
      {
        private FieldHoldingArrayGeneratorUnits top;

        protected override void handle_result(TypeUnits result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorUnits init_top)
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
    protected virtual void handle_result(List<TypeUnits> result)
      {
      }

    public FieldHoldingArrayGeneratorUnits(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnits>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorUnits()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnits>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeUnits> value;
  };
        private FieldHoldingGeneratorUnits fieldGeneratorUnits;
        private AmountJSON.HoldingArrayGenerator fieldGeneratorMultipleUnitTimeDifference;
        private JSONHoldingStringGenerator fieldGeneratorMultipleUnitTimeDifferenceWritten;
        private JSONHoldingStringGenerator fieldGeneratorMultipleUnitTimeDifferenceSpoken;
        private JSONHoldingBooleanGenerator fieldGeneratorRequestedInThePast;
        private JSONHoldingBooleanGenerator fieldGeneratorIsBetweenTwoDateTimes;
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
            if (!(getDateAndTimeInformationNuggetJSONKey().Equals("TimeBetweenTimes")))
                throw new Exception("The key field has a value other than `TimeBetweenTimes'.");
            TimeBetweenTimesInformationNuggetJSON result = new TimeBetweenTimesInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimeBetweenTimesInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DateAndTimeInformationNuggetJSON new_result)
          {
            handle_result((TimeBetweenTimesInformationNuggetJSON )new_result);
          }
        protected void finish(TimeBetweenTimesInformationNuggetJSON result)
          {
            if (fieldGeneratorSourceDateAndOrTimeSpec.have_value)
              {
                result.setSourceDateAndOrTimeSpec(fieldGeneratorSourceDateAndOrTimeSpec.value);
                fieldGeneratorSourceDateAndOrTimeSpec.have_value = false;
              }
            else if ((!(result.hasSourceDateAndOrTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SourceDateAndOrTimeSpec\" field was missing.");
              }
            if (fieldGeneratorDestinationDateAndOrTimeSpec.have_value)
              {
                result.setDestinationDateAndOrTimeSpec(fieldGeneratorDestinationDateAndOrTimeSpec.value);
                fieldGeneratorDestinationDateAndOrTimeSpec.have_value = false;
              }
            else if ((!(result.hasDestinationDateAndOrTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DestinationDateAndOrTimeSpec\" field was missing.");
              }
            if (fieldGeneratorUnitOfMeasureAmount.have_value)
              {
                result.setUnitOfMeasureAmount(fieldGeneratorUnitOfMeasureAmount.value);
                fieldGeneratorUnitOfMeasureAmount.have_value = false;
              }
            if (fieldGeneratorTimeDifference.have_value)
              {
                result.setTimeDifferenceText(fieldGeneratorTimeDifference.value);
                fieldGeneratorTimeDifference.have_value = false;
              }
            else if ((!(result.hasTimeDifference())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TimeDifference\" field was missing.");
              }
            if (fieldGeneratorUnits.have_value)
              {
                result.setUnits(fieldGeneratorUnits.value);
                fieldGeneratorUnits.have_value = false;
              }
            if (fieldGeneratorMultipleUnitTimeDifference.have_value)
              {
                result.initMultipleUnitTimeDifference();
                int count = fieldGeneratorMultipleUnitTimeDifference.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMultipleUnitTimeDifference(fieldGeneratorMultipleUnitTimeDifference.value[num]);
                  }
                fieldGeneratorMultipleUnitTimeDifference.value.Clear();
                fieldGeneratorMultipleUnitTimeDifference.have_value = false;
              }
            if (fieldGeneratorMultipleUnitTimeDifferenceWritten.have_value)
              {
                result.setMultipleUnitTimeDifferenceWritten(fieldGeneratorMultipleUnitTimeDifferenceWritten.value);
                fieldGeneratorMultipleUnitTimeDifferenceWritten.have_value = false;
              }
            if (fieldGeneratorMultipleUnitTimeDifferenceSpoken.have_value)
              {
                result.setMultipleUnitTimeDifferenceSpoken(fieldGeneratorMultipleUnitTimeDifferenceSpoken.value);
                fieldGeneratorMultipleUnitTimeDifferenceSpoken.have_value = false;
              }
            if (fieldGeneratorRequestedInThePast.have_value)
              {
                result.setRequestedInThePast(fieldGeneratorRequestedInThePast.value);
                fieldGeneratorRequestedInThePast.have_value = false;
              }
            else if ((!(result.hasRequestedInThePast())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RequestedInThePast\" field was missing.");
              }
            if (fieldGeneratorIsBetweenTwoDateTimes.have_value)
              {
                result.setIsBetweenTwoDateTimes(fieldGeneratorIsBetweenTwoDateTimes.value);
                fieldGeneratorIsBetweenTwoDateTimes.have_value = false;
              }
            else if ((!(result.hasIsBetweenTwoDateTimes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsBetweenTwoDateTimes\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(TimeBetweenTimesInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "estinationDateAndOrTimeSpec", 0, 27, false) == 0) && (field_name.Length == 28))
                        return fieldGeneratorDestinationDateAndOrTimeSpec;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sBetweenTwoDateTimes", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorIsBetweenTwoDateTimes;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "ultipleUnitTimeDifference", 0, 25, false) == 0)
                      {
                        if (field_name.Length == 26)
                          {
                            return fieldGeneratorMultipleUnitTimeDifference;
                          }
                        switch (field_name[26])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 27, "poken", 0, 5, false) == 0) && (field_name.Length == 32))
                                    return fieldGeneratorMultipleUnitTimeDifferenceSpoken;
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 27, "ritten", 0, 6, false) == 0) && (field_name.Length == 33))
                                    return fieldGeneratorMultipleUnitTimeDifferenceWritten;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedInThePast", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorRequestedInThePast;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ourceDateAndOrTimeSpec", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorSourceDateAndOrTimeSpec;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "imeDifference", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorTimeDifference;
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "nit", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'O':
                                if ((String.Compare(field_name, 5, "fMeasureAmount", 0, 14, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorUnitOfMeasureAmount;
                                break;
                            case 's':
                                if (field_name.Length == 5)
                                    return fieldGeneratorUnits;
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
            fieldGeneratorSourceDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"SourceDateAndOrTimeSpec\" of the TimeBetweenTimesInformationNugget class", ignore_extras);
            fieldGeneratorDestinationDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"DestinationDateAndOrTimeSpec\" of the TimeBetweenTimesInformationNugget class", ignore_extras);
            fieldGeneratorUnitOfMeasureAmount = new UnitOfMeasureAmountJSON.HoldingGenerator("field \"UnitOfMeasureAmount\" of the TimeBetweenTimesInformationNugget class", ignore_extras);
            fieldGeneratorTimeDifference = new JSONHoldingNumberTextGenerator("field \"TimeDifference\" of the TimeBetweenTimesInformationNugget class");
            fieldGeneratorUnits = new FieldHoldingGeneratorUnits("field \"Units\" of the TimeBetweenTimesInformationNugget class");
            fieldGeneratorMultipleUnitTimeDifference = new AmountJSON.HoldingArrayGenerator("field \"MultipleUnitTimeDifference\" of the TimeBetweenTimesInformationNugget class", ignore_extras);
            fieldGeneratorMultipleUnitTimeDifferenceWritten = new JSONHoldingStringGenerator("field \"MultipleUnitTimeDifferenceWritten\" of the TimeBetweenTimesInformationNugget class");
            fieldGeneratorMultipleUnitTimeDifferenceSpoken = new JSONHoldingStringGenerator("field \"MultipleUnitTimeDifferenceSpoken\" of the TimeBetweenTimesInformationNugget class");
            fieldGeneratorRequestedInThePast = new JSONHoldingBooleanGenerator("field \"RequestedInThePast\" of the TimeBetweenTimesInformationNugget class");
            fieldGeneratorIsBetweenTwoDateTimes = new JSONHoldingBooleanGenerator("field \"IsBetweenTwoDateTimes\" of the TimeBetweenTimesInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimeBetweenTimesInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSourceDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"SourceDateAndOrTimeSpec\" of the TimeBetweenTimesInformationNugget class", false);
            fieldGeneratorDestinationDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"DestinationDateAndOrTimeSpec\" of the TimeBetweenTimesInformationNugget class", false);
            fieldGeneratorUnitOfMeasureAmount = new UnitOfMeasureAmountJSON.HoldingGenerator("field \"UnitOfMeasureAmount\" of the TimeBetweenTimesInformationNugget class", false);
            fieldGeneratorTimeDifference = new JSONHoldingNumberTextGenerator("field \"TimeDifference\" of the TimeBetweenTimesInformationNugget class");
            fieldGeneratorUnits = new FieldHoldingGeneratorUnits("field \"Units\" of the TimeBetweenTimesInformationNugget class");
            fieldGeneratorMultipleUnitTimeDifference = new AmountJSON.HoldingArrayGenerator("field \"MultipleUnitTimeDifference\" of the TimeBetweenTimesInformationNugget class", false);
            fieldGeneratorMultipleUnitTimeDifferenceWritten = new JSONHoldingStringGenerator("field \"MultipleUnitTimeDifferenceWritten\" of the TimeBetweenTimesInformationNugget class");
            fieldGeneratorMultipleUnitTimeDifferenceSpoken = new JSONHoldingStringGenerator("field \"MultipleUnitTimeDifferenceSpoken\" of the TimeBetweenTimesInformationNugget class");
            fieldGeneratorRequestedInThePast = new JSONHoldingBooleanGenerator("field \"RequestedInThePast\" of the TimeBetweenTimesInformationNugget class");
            fieldGeneratorIsBetweenTwoDateTimes = new JSONHoldingBooleanGenerator("field \"IsBetweenTwoDateTimes\" of the TimeBetweenTimesInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimeBetweenTimesInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorSourceDateAndOrTimeSpec.reset();
            fieldGeneratorDestinationDateAndOrTimeSpec.reset();
            fieldGeneratorUnitOfMeasureAmount.reset();
            fieldGeneratorTimeDifference.reset();
            fieldGeneratorUnits.reset();
            fieldGeneratorMultipleUnitTimeDifference.reset();
            fieldGeneratorMultipleUnitTimeDifferenceWritten.reset();
            fieldGeneratorMultipleUnitTimeDifferenceSpoken.reset();
            fieldGeneratorRequestedInThePast.reset();
            fieldGeneratorIsBetweenTwoDateTimes.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(TimeBetweenTimesInformationNuggetJSON  result)
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
        public TimeBetweenTimesInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimeBetweenTimesInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<TimeBetweenTimesInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimeBetweenTimesInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimeBetweenTimesInformationNuggetJSON>();
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
    public List<TimeBetweenTimesInformationNuggetJSON> value;
  };
  };
