/* file "TimeBetweenTimesConversationStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TimeBetweenTimesConversationStateJSON : JSONBase
  {
    public enum TypeDateAndTimeKind
      {
        DateAndTimeKind_TimeBetweenTimes
      };

    public static TypeDateAndTimeKind  stringToDateAndTimeKind(string chars)
      {
        if ((String.Compare(chars, 0, "TimeBetweenTimes", 0, 16, false) == 0) && (chars.Length == 16))
            return TypeDateAndTimeKind.DateAndTimeKind_TimeBetweenTimes;
        throw new Exception("The value for field `DateAndTimeKind' is not one of the legal values.");
      }

    public static string  stringFromDateAndTimeKind(TypeDateAndTimeKind the_enum)
      {
        switch (the_enum)
          {
            case TypeDateAndTimeKind.DateAndTimeKind_TimeBetweenTimes:
                return "TimeBetweenTimes";
            default:
                Debug.Assert(false);
                return null;
          }
      }

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

    private bool flagHasDateAndTimeKind;
    private bool flagHasSourceDateAndOrTimeSpec;
    private DateAndOrTimeSpecJSON  storeSourceDateAndOrTimeSpec;
    private bool flagHasDestinationDateAndOrTimeSpec;
    private DateAndOrTimeSpecJSON  storeDestinationDateAndOrTimeSpec;
    private bool flagHasDateAndOrTimeSpec;
    private DateAndOrTimeSpecJSON  storeDateAndOrTimeSpec;
    private bool flagHasUnitOfMeasureAmount;
    private UnitOfMeasureAmountJSON  storeUnitOfMeasureAmount;
    private bool flagHasTimeDifference;
    private double storeTimeDifference;
    private string textStoreTimeDifference;
    private bool flagHasUnits;
    private TypeUnits storeUnits;
    private bool flagHasRequestedInThePast;
    private bool storeRequestedInThePast;
    private bool flagHasIsBetweenTwoDateTimes;
    private bool storeIsBetweenTwoDateTimes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDateAndTimeKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DateAndTimeKind of TimeBetweenTimesConversationStateJSON is not a string.");
        if (!(json_string.getData().Equals("TimeBetweenTimes")))
            throw new Exception("The value for field DateAndTimeKind of TimeBetweenTimesConversationStateJSON is not `TimeBetweenTimes'.");
        setDateAndTimeKind();
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


    private void  fromJSONDateAndOrTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeSpecJSON convert_classy = DateAndOrTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateAndOrTimeSpec(convert_classy);
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
                throw new Exception("The value for field TimeDifference of TimeBetweenTimesConversationStateJSON is not a number.");
              }
          }
        setTimeDifferenceText(the_rational_text);
      }


    private void  fromJSONUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Units of TimeBetweenTimesConversationStateJSON is not a string.");
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
                throw new Exception("The value for field RequestedInThePast of TimeBetweenTimesConversationStateJSON is not true for false.");
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
                throw new Exception("The value for field IsBetweenTwoDateTimes of TimeBetweenTimesConversationStateJSON is not true for false.");
              }
          }
        setIsBetweenTwoDateTimes(the_bool);
      }


    public TimeBetweenTimesConversationStateJSON()
      {
        flagHasDateAndTimeKind = false;
        flagHasSourceDateAndOrTimeSpec = false;
        flagHasDestinationDateAndOrTimeSpec = false;
        flagHasDateAndOrTimeSpec = false;
        flagHasUnitOfMeasureAmount = false;
        flagHasTimeDifference = false;
        flagHasUnits = false;
        flagHasRequestedInThePast = false;
        flagHasIsBetweenTwoDateTimes = false;
        storeRequestedInThePast = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDateAndTimeKind()
      {
        return flagHasDateAndTimeKind;
      }

    public TypeDateAndTimeKind  getDateAndTimeKind()
      {
        Debug.Assert(flagHasDateAndTimeKind);
        return TypeDateAndTimeKind.DateAndTimeKind_TimeBetweenTimes;
      }

    public string  getDateAndTimeKindAsString()
      {
        return stringFromDateAndTimeKind(getDateAndTimeKind());
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

    public bool  hasDateAndOrTimeSpec()
      {
        return flagHasDateAndOrTimeSpec;
      }

    public DateAndOrTimeSpecJSON   getDateAndOrTimeSpec()
      {
        Debug.Assert(flagHasDateAndOrTimeSpec);
        return storeDateAndOrTimeSpec;
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


    public virtual int extraTimeBetweenTimesConversationStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimeBetweenTimesConversationStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimeBetweenTimesConversationStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimeBetweenTimesConversationStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setDateAndTimeKind()
      {
        flagHasDateAndTimeKind = true;
      }
    public void setDateAndTimeKind(TypeDateAndTimeKind new_value)
      {
        setDateAndTimeKind();
      }
    public void setDateAndTimeKind(string chars)
      {
        setDateAndTimeKind(stringToDateAndTimeKind(chars));
      }
    public void unsetDateAndTimeKind()
      {
        flagHasDateAndTimeKind = false;
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
    public void setDateAndOrTimeSpec(DateAndOrTimeSpecJSON  new_value)
      {
        if (flagHasDateAndOrTimeSpec)
          {
          }
        flagHasDateAndOrTimeSpec = true;
        storeDateAndOrTimeSpec = new_value;
      }
    public void unsetDateAndOrTimeSpec()
      {
        if (flagHasDateAndOrTimeSpec)
          {
          }
        flagHasDateAndOrTimeSpec = false;
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
            throw new Exception("The text value for field TimeDifference of TimeBetweenTimesConversationStateJSON is not a valid number.");
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

    public virtual void extraTimeBetweenTimesConversationStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimeBetweenTimesConversationStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimeBetweenTimesConversationStateLookup(key);
        if (old_field == null)
          {
            extraTimeBetweenTimesConversationStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDateAndTimeKind);
        if (flagHasDateAndTimeKind)
          {
            handler.start_pair("DateAndTimeKind");
            handler.string_value("TimeBetweenTimes");
          }
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
        Debug.Assert(partial_allowed || flagHasDateAndOrTimeSpec);
        if (flagHasDateAndOrTimeSpec)
          {
            handler.start_pair("DateAndOrTimeSpec");
            if (partial_allowed)
                storeDateAndOrTimeSpec.write_partial_as_json(handler);
            else
                storeDateAndOrTimeSpec.write_as_json(handler);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasDateAndTimeKind()))
          {
            return "When parsing the object for %what%, the \"DateAndTimeKind\" field was missing.";
          }
        if (!(hasSourceDateAndOrTimeSpec()))
          {
            return "When parsing the object for %what%, the \"SourceDateAndOrTimeSpec\" field was missing.";
          }
        if (!(hasDestinationDateAndOrTimeSpec()))
          {
            return "When parsing the object for %what%, the \"DestinationDateAndOrTimeSpec\" field was missing.";
          }
        if (!(hasDateAndOrTimeSpec()))
          {
            return "When parsing the object for %what%, the \"DateAndOrTimeSpec\" field was missing.";
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

    public static TimeBetweenTimesConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeBetweenTimesConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenTimesConversationState", ignore_extras);
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
    public static TimeBetweenTimesConversationStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimeBetweenTimesConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimeBetweenTimesConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenTimesConversationState", ignore_extras);
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
    public static TimeBetweenTimesConversationStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimeBetweenTimesConversationStateJSON from_text(string text, bool ignore_extras)
      {
        TimeBetweenTimesConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenTimesConversationState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimeBetweenTimesConversationStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TimeBetweenTimesConversationStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimeBetweenTimesConversationStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimeBetweenTimesConversationState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorDateAndTimeKind : JSONStringGenerator
          {
            protected FieldGeneratorDateAndTimeKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDateAndTimeKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToDateAndTimeKind(result));
              }
            protected abstract void handle_result(TypeDateAndTimeKind result);
          };
    private class FieldHoldingGeneratorDateAndTimeKind : FieldGeneratorDateAndTimeKind
  {
    protected override void handle_result(TypeDateAndTimeKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDateAndTimeKind(String what)
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
    public TypeDateAndTimeKind value;
  };
    private class FieldHoldingArrayGeneratorDateAndTimeKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDateAndTimeKind
      {
        private FieldHoldingArrayGeneratorDateAndTimeKind top;

        protected override void handle_result(TypeDateAndTimeKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDateAndTimeKind init_top)
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
    protected virtual void handle_result(List<TypeDateAndTimeKind> result)
      {
      }

    public FieldHoldingArrayGeneratorDateAndTimeKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDateAndTimeKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDateAndTimeKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDateAndTimeKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDateAndTimeKind> value;
  };
        private FieldHoldingGeneratorDateAndTimeKind fieldGeneratorDateAndTimeKind;
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorSourceDateAndOrTimeSpec;
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorDestinationDateAndOrTimeSpec;
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorDateAndOrTimeSpec;
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
            TimeBetweenTimesConversationStateJSON result = new TimeBetweenTimesConversationStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimeBetweenTimesConversationStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TimeBetweenTimesConversationStateJSON result)
          {
            if (fieldGeneratorDateAndTimeKind.have_value)
              {
                result.setDateAndTimeKind();
                fieldGeneratorDateAndTimeKind.have_value = false;
              }
            else if ((!(result.hasDateAndTimeKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndTimeKind\" field was missing.");
              }
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
            if (fieldGeneratorDateAndOrTimeSpec.have_value)
              {
                result.setDateAndOrTimeSpec(fieldGeneratorDateAndOrTimeSpec.value);
                fieldGeneratorDateAndOrTimeSpec.have_value = false;
              }
            else if ((!(result.hasDateAndOrTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndOrTimeSpec\" field was missing.");
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
          }
        protected abstract void handle_result(TimeBetweenTimesConversationStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "teAnd", 0, 5, false) == 0)
                              {
                                switch (field_name[7])
                                  {
                                    case 'O':
                                        if ((String.Compare(field_name, 8, "rTimeSpec", 0, 9, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorDateAndOrTimeSpec;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 8, "imeKind", 0, 7, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorDateAndTimeKind;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "stinationDateAndOrTimeSpec", 0, 26, false) == 0) && (field_name.Length == 28))
                                return fieldGeneratorDestinationDateAndOrTimeSpec;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sBetweenTwoDateTimes", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorIsBetweenTwoDateTimes;
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the TimeBetweenTimesConversationState class");
            fieldGeneratorSourceDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"SourceDateAndOrTimeSpec\" of the TimeBetweenTimesConversationState class", ignore_extras);
            fieldGeneratorDestinationDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"DestinationDateAndOrTimeSpec\" of the TimeBetweenTimesConversationState class", ignore_extras);
            fieldGeneratorDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"DateAndOrTimeSpec\" of the TimeBetweenTimesConversationState class", ignore_extras);
            fieldGeneratorUnitOfMeasureAmount = new UnitOfMeasureAmountJSON.HoldingGenerator("field \"UnitOfMeasureAmount\" of the TimeBetweenTimesConversationState class", ignore_extras);
            fieldGeneratorTimeDifference = new JSONHoldingNumberTextGenerator("field \"TimeDifference\" of the TimeBetweenTimesConversationState class");
            fieldGeneratorUnits = new FieldHoldingGeneratorUnits("field \"Units\" of the TimeBetweenTimesConversationState class");
            fieldGeneratorRequestedInThePast = new JSONHoldingBooleanGenerator("field \"RequestedInThePast\" of the TimeBetweenTimesConversationState class");
            fieldGeneratorIsBetweenTwoDateTimes = new JSONHoldingBooleanGenerator("field \"IsBetweenTwoDateTimes\" of the TimeBetweenTimesConversationState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimeBetweenTimesConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDateAndTimeKind = new FieldHoldingGeneratorDateAndTimeKind("field \"DateAndTimeKind\" of the TimeBetweenTimesConversationState class");
            fieldGeneratorSourceDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"SourceDateAndOrTimeSpec\" of the TimeBetweenTimesConversationState class", false);
            fieldGeneratorDestinationDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"DestinationDateAndOrTimeSpec\" of the TimeBetweenTimesConversationState class", false);
            fieldGeneratorDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"DateAndOrTimeSpec\" of the TimeBetweenTimesConversationState class", false);
            fieldGeneratorUnitOfMeasureAmount = new UnitOfMeasureAmountJSON.HoldingGenerator("field \"UnitOfMeasureAmount\" of the TimeBetweenTimesConversationState class", false);
            fieldGeneratorTimeDifference = new JSONHoldingNumberTextGenerator("field \"TimeDifference\" of the TimeBetweenTimesConversationState class");
            fieldGeneratorUnits = new FieldHoldingGeneratorUnits("field \"Units\" of the TimeBetweenTimesConversationState class");
            fieldGeneratorRequestedInThePast = new JSONHoldingBooleanGenerator("field \"RequestedInThePast\" of the TimeBetweenTimesConversationState class");
            fieldGeneratorIsBetweenTwoDateTimes = new JSONHoldingBooleanGenerator("field \"IsBetweenTwoDateTimes\" of the TimeBetweenTimesConversationState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimeBetweenTimesConversationState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDateAndTimeKind.reset();
            fieldGeneratorSourceDateAndOrTimeSpec.reset();
            fieldGeneratorDestinationDateAndOrTimeSpec.reset();
            fieldGeneratorDateAndOrTimeSpec.reset();
            fieldGeneratorUnitOfMeasureAmount.reset();
            fieldGeneratorTimeDifference.reset();
            fieldGeneratorUnits.reset();
            fieldGeneratorRequestedInThePast.reset();
            fieldGeneratorIsBetweenTwoDateTimes.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSourceDateAndOrTimeSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDestinationDateAndOrTimeSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDateAndOrTimeSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUnitOfMeasureAmount.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSourceDateAndOrTimeSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDestinationDateAndOrTimeSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDateAndOrTimeSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUnitOfMeasureAmount.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TimeBetweenTimesConversationStateJSON  result)
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
        public TimeBetweenTimesConversationStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimeBetweenTimesConversationStateJSON  result)
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
    protected virtual void handle_result(List<TimeBetweenTimesConversationStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimeBetweenTimesConversationStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimeBetweenTimesConversationStateJSON>();
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
    public List<TimeBetweenTimesConversationStateJSON> value;
  };
  };
