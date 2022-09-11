/* file "AlarmJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AlarmJSON : JSONBase
  {
    public enum TypeDaysOfWeekKnownValues
      {
        DaysOfWeek_Sunday,
        DaysOfWeek_Monday,
        DaysOfWeek_Tuesday,
        DaysOfWeek_Wednesday,
        DaysOfWeek_Thursday,
        DaysOfWeek_Friday,
        DaysOfWeek_Saturday,
        DaysOfWeek__none
      };
    public struct TypeDaysOfWeek
      {
        public bool in_known_list;
        public string string_value;
        public TypeDaysOfWeekKnownValues list_value;
      };

    public static TypeDaysOfWeekKnownValues  stringToDaysOfWeek(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "riday", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeDaysOfWeekKnownValues.DaysOfWeek_Friday;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "onday", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeDaysOfWeekKnownValues.DaysOfWeek_Monday;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "turday", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeDaysOfWeekKnownValues.DaysOfWeek_Saturday;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "nday", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeDaysOfWeekKnownValues.DaysOfWeek_Sunday;
                        break;
                    default:
                        break;
                  }
                break;
            case 'T':
                switch (chars[1])
                  {
                    case 'h':
                        if ((String.Compare(chars, 2, "ursday", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeDaysOfWeekKnownValues.DaysOfWeek_Thursday;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "esday", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeDaysOfWeekKnownValues.DaysOfWeek_Tuesday;
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if ((String.Compare(chars, 1, "ednesday", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeDaysOfWeekKnownValues.DaysOfWeek_Wednesday;
                break;
            default:
                break;
          }
        return TypeDaysOfWeekKnownValues.DaysOfWeek__none;
      }

    public static string  stringFromDaysOfWeek(TypeDaysOfWeekKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeDaysOfWeekKnownValues.DaysOfWeek_Sunday:
                return "Sunday";
            case TypeDaysOfWeekKnownValues.DaysOfWeek_Monday:
                return "Monday";
            case TypeDaysOfWeekKnownValues.DaysOfWeek_Tuesday:
                return "Tuesday";
            case TypeDaysOfWeekKnownValues.DaysOfWeek_Wednesday:
                return "Wednesday";
            case TypeDaysOfWeekKnownValues.DaysOfWeek_Thursday:
                return "Thursday";
            case TypeDaysOfWeekKnownValues.DaysOfWeek_Friday:
                return "Friday";
            case TypeDaysOfWeekKnownValues.DaysOfWeek_Saturday:
                return "Saturday";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasIsWake;
    private bool storeIsWake;
    private bool flagHasIsRecurring;
    private bool storeIsRecurring;
    private bool flagHasHour;
    private sbyte storeHour;
    private bool flagHasMinute;
    private sbyte storeMinute;
    private bool flagHasSecond;
    private sbyte storeSecond;
    private bool flagHasDaysOfWeek;
    private List< TypeDaysOfWeek > storeDaysOfWeek;
    private bool flagHasInvalidDates;
    private List< DateAndOrTimeJSON  > storeInvalidDates;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of AlarmJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONIsWake(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsWake of AlarmJSON is not true for false.");
              }
          }
        setIsWake(the_bool);
      }


    private void  fromJSONIsRecurring(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsRecurring of AlarmJSON is not true for false.");
              }
          }
        setIsRecurring(the_bool);
      }


    private void  fromJSONHour(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Hour of AlarmJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Hour of AlarmJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setHour(extracted_integer);
      }


    private void  fromJSONMinute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Minute of AlarmJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Minute of AlarmJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setMinute(extracted_integer);
      }


    private void  fromJSONSecond(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Second of AlarmJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Second of AlarmJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setSecond(extracted_integer);
      }


    private void  fromJSONDaysOfWeek(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DaysOfWeek of AlarmJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeDaysOfWeek > vector_DaysOfWeek1 = new List< TypeDaysOfWeek >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field DaysOfWeek of AlarmJSON is not a string.");
            TypeDaysOfWeek the_open_enum = new TypeDaysOfWeek();
            switch (json_string.getData()[0])
              {
                case 'F':
                    if ((String.Compare(json_string.getData(), 1, "riday", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Friday;
                            goto open_enum_is_done;
                          }
                    break;
                case 'M':
                    if ((String.Compare(json_string.getData(), 1, "onday", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Monday;
                            goto open_enum_is_done;
                          }
                    break;
                case 'S':
                    switch (json_string.getData()[1])
                      {
                        case 'a':
                            if ((String.Compare(json_string.getData(), 2, "turday", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Saturday;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'u':
                            if ((String.Compare(json_string.getData(), 2, "nday", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Sunday;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (json_string.getData()[1])
                      {
                        case 'h':
                            if ((String.Compare(json_string.getData(), 2, "ursday", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Thursday;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'u':
                            if ((String.Compare(json_string.getData(), 2, "esday", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Tuesday;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'W':
                    if ((String.Compare(json_string.getData(), 1, "ednesday", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDaysOfWeekKnownValues.DaysOfWeek_Wednesday;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            vector_DaysOfWeek1.Add(the_open_enum);
          }
        initDaysOfWeek();
        for (int num1 = 0; num1 < vector_DaysOfWeek1.Count; ++num1)
            appendDaysOfWeek(vector_DaysOfWeek1[num1]);
        for (int num1 = 0; num1 < vector_DaysOfWeek1.Count; ++num1)
          {
          }
      }


    private void  fromJSONInvalidDates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InvalidDates of AlarmJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DateAndOrTimeJSON  > vector_InvalidDates1 = new List< DateAndOrTimeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InvalidDates1.Add(convert_classy);
          }
        initInvalidDates();
        for (int num2 = 0; num2 < vector_InvalidDates1.Count; ++num2)
            appendInvalidDates(vector_InvalidDates1[num2]);
        for (int num1 = 0; num1 < vector_InvalidDates1.Count; ++num1)
          {
          }
      }


    public AlarmJSON()
      {
        flagHasTitle = false;
        flagHasIsWake = false;
        flagHasIsRecurring = false;
        flagHasHour = false;
        flagHasMinute = false;
        flagHasSecond = false;
        flagHasDaysOfWeek = false;
        flagHasInvalidDates = false;
        storeIsWake = false;
        storeIsRecurring = false;
        storeDaysOfWeek = new List< TypeDaysOfWeek >();
        storeInvalidDates = new List< DateAndOrTimeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTitle()
      {
        return flagHasTitle;
      }

    public string  getTitle()
      {
        Debug.Assert(flagHasTitle);
        return storeTitle;
      }

    public bool  hasIsWake()
      {
        return flagHasIsWake;
      }

    public bool  getIsWake()
      {
        return storeIsWake;
      }

    public bool  hasIsRecurring()
      {
        return flagHasIsRecurring;
      }

    public bool  getIsRecurring()
      {
        return storeIsRecurring;
      }

    public bool  hasHour()
      {
        return flagHasHour;
      }

    public sbyte  getHour()
      {
        Debug.Assert(flagHasHour);
        return storeHour;
      }

    public bool  hasMinute()
      {
        return flagHasMinute;
      }

    public sbyte  getMinute()
      {
        Debug.Assert(flagHasMinute);
        return storeMinute;
      }

    public bool  hasSecond()
      {
        return flagHasSecond;
      }

    public sbyte  getSecond()
      {
        Debug.Assert(flagHasSecond);
        return storeSecond;
      }

    public bool  hasDaysOfWeek()
      {
        return flagHasDaysOfWeek;
      }

    public int  countOfDaysOfWeek()
      {
        Debug.Assert(flagHasDaysOfWeek);
        return storeDaysOfWeek.Count;
      }

    public TypeDaysOfWeek  elementOfDaysOfWeek(int element_num)
      {
        Debug.Assert(flagHasDaysOfWeek);
        return storeDaysOfWeek[element_num];
      }

    public List< TypeDaysOfWeek >  getDaysOfWeek()
      {
        Debug.Assert(flagHasDaysOfWeek);
        return storeDaysOfWeek;
      }

    public bool  hasInvalidDates()
      {
        return flagHasInvalidDates;
      }

    public int  countOfInvalidDates()
      {
        Debug.Assert(flagHasInvalidDates);
        return storeInvalidDates.Count;
      }

    public DateAndOrTimeJSON   elementOfInvalidDates(int element_num)
      {
        Debug.Assert(flagHasInvalidDates);
        return storeInvalidDates[element_num];
      }

    public List< DateAndOrTimeJSON  >  getInvalidDates()
      {
        Debug.Assert(flagHasInvalidDates);
        return storeInvalidDates;
      }


    public virtual int extraAlarmComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraAlarmComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraAlarmComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraAlarmLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setTitle(string new_value)
      {
        flagHasTitle = true;
        storeTitle = new_value;
      }
    public void unsetTitle()
      {
        flagHasTitle = false;
      }
    public void setIsWake(bool new_value)
      {
        flagHasIsWake = true;
        storeIsWake = new_value;
      }
    public void unsetIsWake()
      {
        flagHasIsWake = false;
      }
    public void setIsRecurring(bool new_value)
      {
        flagHasIsRecurring = true;
        storeIsRecurring = new_value;
      }
    public void unsetIsRecurring()
      {
        flagHasIsRecurring = false;
      }
    public void setHour(sbyte new_value)
      {
        flagHasHour = true;
        if (new_value < 0)
            throw new Exception("The value for field Hour of AlarmJSON is less than the lower bound (0) for that field.");
        if (new_value > 23)
            throw new Exception("The value for field Hour of AlarmJSON is greater than the upper bound (23) for that field.");
        storeHour = new_value;
      }
    public void unsetHour()
      {
        flagHasHour = false;
      }
    public void setMinute(sbyte new_value)
      {
        flagHasMinute = true;
        if (new_value < 0)
            throw new Exception("The value for field Minute of AlarmJSON is less than the lower bound (0) for that field.");
        if (new_value > 59)
            throw new Exception("The value for field Minute of AlarmJSON is greater than the upper bound (59) for that field.");
        storeMinute = new_value;
      }
    public void unsetMinute()
      {
        flagHasMinute = false;
      }
    public void setSecond(sbyte new_value)
      {
        flagHasSecond = true;
        if (new_value < 0)
            throw new Exception("The value for field Second of AlarmJSON is less than the lower bound (0) for that field.");
        if (new_value > 60)
            throw new Exception("The value for field Second of AlarmJSON is greater than the upper bound (60) for that field.");
        storeSecond = new_value;
      }
    public void unsetSecond()
      {
        flagHasSecond = false;
      }
    public void initDaysOfWeek()
      {
        flagHasDaysOfWeek = true;
        storeDaysOfWeek.Clear();
      }
    public void appendDaysOfWeek(TypeDaysOfWeek to_append)
      {
        if (!flagHasDaysOfWeek)
          {
            flagHasDaysOfWeek = true;
            storeDaysOfWeek.Clear();
          }
        Debug.Assert(flagHasDaysOfWeek);
        storeDaysOfWeek.Add(to_append);
      }
    public void appendDaysOfWeek(string chars)
      {
        TypeDaysOfWeekKnownValues known = stringToDaysOfWeek(chars);
        TypeDaysOfWeek new_value = new TypeDaysOfWeek();
        if (known == TypeDaysOfWeekKnownValues.DaysOfWeek__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendDaysOfWeek(new_value);
      }
    public void appendDaysOfWeek(TypeDaysOfWeekKnownValues new_value)
      {
        TypeDaysOfWeek new_full_value = new TypeDaysOfWeek();
        Debug.Assert(new_value != TypeDaysOfWeekKnownValues.DaysOfWeek__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        appendDaysOfWeek(new_full_value);
      }
    public void unsetDaysOfWeek()
      {
        flagHasDaysOfWeek = false;
        storeDaysOfWeek.Clear();
      }
    public void initInvalidDates()
      {
        if (flagHasInvalidDates)
          {
            for (int num1 = 0; num1 < storeInvalidDates.Count; ++num1)
              {
              }
          }
        flagHasInvalidDates = true;
        storeInvalidDates.Clear();
      }
    public void appendInvalidDates(DateAndOrTimeJSON  to_append)
      {
        if (!flagHasInvalidDates)
          {
            flagHasInvalidDates = true;
            storeInvalidDates.Clear();
          }
        Debug.Assert(flagHasInvalidDates);
        storeInvalidDates.Add(to_append);
      }
    public void unsetInvalidDates()
      {
        if (flagHasInvalidDates)
          {
            for (int num2 = 0; num2 < storeInvalidDates.Count; ++num2)
              {
              }
          }
        flagHasInvalidDates = false;
        storeInvalidDates.Clear();
      }

    public virtual void extraAlarmAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraAlarmSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraAlarmLookup(key);
        if (old_field == null)
          {
            extraAlarmAppendPair(key, new_component);
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
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasIsWake)
          {
            handler.start_pair("IsWake");
            handler.boolean_value(storeIsWake);
          }
        Debug.Assert(partial_allowed || flagHasIsRecurring);
        if (flagHasIsRecurring)
          {
            handler.start_pair("IsRecurring");
            handler.boolean_value(storeIsRecurring);
          }
        Debug.Assert(partial_allowed || flagHasHour);
        if (flagHasHour)
          {
            handler.start_pair("Hour");
            handler.number_value(storeHour);
          }
        Debug.Assert(partial_allowed || flagHasMinute);
        if (flagHasMinute)
          {
            handler.start_pair("Minute");
            handler.number_value(storeMinute);
          }
        Debug.Assert(partial_allowed || flagHasSecond);
        if (flagHasSecond)
          {
            handler.start_pair("Second");
            handler.number_value(storeSecond);
          }
        Debug.Assert(partial_allowed || flagHasDaysOfWeek);
        if (flagHasDaysOfWeek)
          {
            handler.start_pair("DaysOfWeek");
            handler.start_array();
            for (int num1 = 0; num1 < storeDaysOfWeek.Count; ++num1)
              {
                if (storeDaysOfWeek[num1].in_known_list)
                  {
                    switch (storeDaysOfWeek[num1].list_value)
                      {
                        case TypeDaysOfWeekKnownValues.DaysOfWeek_Sunday:
                            handler.string_value("Sunday");
                            break;
                        case TypeDaysOfWeekKnownValues.DaysOfWeek_Monday:
                            handler.string_value("Monday");
                            break;
                        case TypeDaysOfWeekKnownValues.DaysOfWeek_Tuesday:
                            handler.string_value("Tuesday");
                            break;
                        case TypeDaysOfWeekKnownValues.DaysOfWeek_Wednesday:
                            handler.string_value("Wednesday");
                            break;
                        case TypeDaysOfWeekKnownValues.DaysOfWeek_Thursday:
                            handler.string_value("Thursday");
                            break;
                        case TypeDaysOfWeekKnownValues.DaysOfWeek_Friday:
                            handler.string_value("Friday");
                            break;
                        case TypeDaysOfWeekKnownValues.DaysOfWeek_Saturday:
                            handler.string_value("Saturday");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeDaysOfWeek[num1].string_value);
                  }
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasInvalidDates);
        if (flagHasInvalidDates)
          {
            handler.start_pair("InvalidDates");
            handler.start_array();
            for (int num2 = 0; num2 < storeInvalidDates.Count; ++num2)
              {
                if (partial_allowed)
                    storeInvalidDates[num2].write_partial_as_json(handler);
                else
                    storeInvalidDates[num2].write_as_json(handler);
              }
            handler.finish_array();
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
        if (!(hasIsRecurring()))
          {
            return "When parsing the object for %what%, the \"IsRecurring\" field was missing.";
          }
        if (!(hasHour()))
          {
            return "When parsing the object for %what%, the \"Hour\" field was missing.";
          }
        if (!(hasMinute()))
          {
            return "When parsing the object for %what%, the \"Minute\" field was missing.";
          }
        if (!(hasSecond()))
          {
            return "When parsing the object for %what%, the \"Second\" field was missing.";
          }
        if (!(hasDaysOfWeek()))
          {
            return "When parsing the object for %what%, the \"DaysOfWeek\" field was missing.";
          }
        if (!(hasInvalidDates()))
          {
            return "When parsing the object for %what%, the \"InvalidDates\" field was missing.";
          }
        return null;
      }

    public static AlarmJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AlarmJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Alarm", ignore_extras);
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
    public static AlarmJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AlarmJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AlarmJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Alarm", ignore_extras);
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
    public static AlarmJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AlarmJSON from_text(string text, bool ignore_extras)
      {
        AlarmJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Alarm", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AlarmJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AlarmJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AlarmJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Alarm", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingBooleanGenerator fieldGeneratorIsWake;
        private JSONHoldingBooleanGenerator fieldGeneratorIsRecurring;
    private class FieldHoldingGeneratorHour : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorHour(String what) : base(what, 0, 23)
              {
              }
          };
    private class FieldHoldingArrayGeneratorHour : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorHour(String what) : base(what, 0, 23)
              {
              }
          };
        private FieldHoldingGeneratorHour fieldGeneratorHour;
    private class FieldHoldingGeneratorMinute : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorMinute(String what) : base(what, 0, 59)
              {
              }
          };
    private class FieldHoldingArrayGeneratorMinute : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorMinute(String what) : base(what, 0, 59)
              {
              }
          };
        private FieldHoldingGeneratorMinute fieldGeneratorMinute;
    private class FieldHoldingGeneratorSecond : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorSecond(String what) : base(what, 0, 60)
              {
              }
          };
    private class FieldHoldingArrayGeneratorSecond : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorSecond(String what) : base(what, 0, 60)
              {
              }
          };
        private FieldHoldingGeneratorSecond fieldGeneratorSecond;
    private abstract class FieldGeneratorDaysOfWeek : JSONStringGenerator
          {
            protected FieldGeneratorDaysOfWeek(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDaysOfWeek()
              {
              }
            protected override void handle_result(string result)
              {
                TypeDaysOfWeekKnownValues known = stringToDaysOfWeek(result);
                TypeDaysOfWeek new_value = new TypeDaysOfWeek();
                if (known == TypeDaysOfWeekKnownValues.DaysOfWeek__none)
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
            protected abstract void handle_result(TypeDaysOfWeek result);
          };
    private class FieldHoldingGeneratorDaysOfWeek : FieldGeneratorDaysOfWeek
  {
    protected override void handle_result(TypeDaysOfWeek result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDaysOfWeek(String what)
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
    public TypeDaysOfWeek value;
  };
    private class FieldHoldingArrayGeneratorDaysOfWeek : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDaysOfWeek
      {
        private FieldHoldingArrayGeneratorDaysOfWeek top;

        protected override void handle_result(TypeDaysOfWeek result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDaysOfWeek init_top)
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
    protected virtual void handle_result(List<TypeDaysOfWeek> result)
      {
      }

    public FieldHoldingArrayGeneratorDaysOfWeek(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDaysOfWeek>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDaysOfWeek()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDaysOfWeek>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDaysOfWeek> value;
  };
        private FieldHoldingArrayGeneratorDaysOfWeek fieldGeneratorDaysOfWeek;
        private DateAndOrTimeJSON.HoldingArrayGenerator fieldGeneratorInvalidDates;
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
            AlarmJSON result = new AlarmJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraAlarmAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(AlarmJSON result)
          {
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            if (fieldGeneratorIsWake.have_value)
              {
                result.setIsWake(fieldGeneratorIsWake.value);
                fieldGeneratorIsWake.have_value = false;
              }
            if (fieldGeneratorIsRecurring.have_value)
              {
                result.setIsRecurring(fieldGeneratorIsRecurring.value);
                fieldGeneratorIsRecurring.have_value = false;
              }
            else if ((!(result.hasIsRecurring())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsRecurring\" field was missing.");
              }
            if (fieldGeneratorHour.have_value)
              {
                result.setHour((sbyte)(fieldGeneratorHour.value));
                fieldGeneratorHour.have_value = false;
              }
            else if ((!(result.hasHour())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Hour\" field was missing.");
              }
            if (fieldGeneratorMinute.have_value)
              {
                result.setMinute((sbyte)(fieldGeneratorMinute.value));
                fieldGeneratorMinute.have_value = false;
              }
            else if ((!(result.hasMinute())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Minute\" field was missing.");
              }
            if (fieldGeneratorSecond.have_value)
              {
                result.setSecond((sbyte)(fieldGeneratorSecond.value));
                fieldGeneratorSecond.have_value = false;
              }
            else if ((!(result.hasSecond())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Second\" field was missing.");
              }
            if (fieldGeneratorDaysOfWeek.have_value)
              {
                result.initDaysOfWeek();
                int count = fieldGeneratorDaysOfWeek.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDaysOfWeek(fieldGeneratorDaysOfWeek.value[num]);
                  }
                fieldGeneratorDaysOfWeek.value.Clear();
                fieldGeneratorDaysOfWeek.have_value = false;
              }
            else if ((!(result.hasDaysOfWeek())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DaysOfWeek\" field was missing.");
              }
            if (fieldGeneratorInvalidDates.have_value)
              {
                result.initInvalidDates();
                int count = fieldGeneratorInvalidDates.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInvalidDates(fieldGeneratorInvalidDates.value[num]);
                  }
                fieldGeneratorInvalidDates.value.Clear();
                fieldGeneratorInvalidDates.have_value = false;
              }
            else if ((!(result.hasInvalidDates())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InvalidDates\" field was missing.");
              }
          }
        protected abstract void handle_result(AlarmJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "aysOfWeek", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorDaysOfWeek;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "our", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorHour;
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'n':
                            if ((String.Compare(field_name, 2, "validDates", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorInvalidDates;
                            break;
                        case 's':
                            switch (field_name[2])
                              {
                                case 'R':
                                    if ((String.Compare(field_name, 3, "ecurring", 0, 8, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorIsRecurring;
                                    break;
                                case 'W':
                                    if ((String.Compare(field_name, 3, "ake", 0, 3, false) == 0) && (field_name.Length == 6))
                                        return fieldGeneratorIsWake;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "inute", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorMinute;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "econd", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorSecond;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTitle;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the Alarm class");
            fieldGeneratorIsWake = new JSONHoldingBooleanGenerator("field \"IsWake\" of the Alarm class");
            fieldGeneratorIsRecurring = new JSONHoldingBooleanGenerator("field \"IsRecurring\" of the Alarm class");
            fieldGeneratorHour = new FieldHoldingGeneratorHour("field \"Hour\" of the Alarm class");
            fieldGeneratorMinute = new FieldHoldingGeneratorMinute("field \"Minute\" of the Alarm class");
            fieldGeneratorSecond = new FieldHoldingGeneratorSecond("field \"Second\" of the Alarm class");
            fieldGeneratorDaysOfWeek = new FieldHoldingArrayGeneratorDaysOfWeek("field \"DaysOfWeek\" of the Alarm class");
            fieldGeneratorInvalidDates = new DateAndOrTimeJSON.HoldingArrayGenerator("field \"InvalidDates\" of the Alarm class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Alarm class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the Alarm class");
            fieldGeneratorIsWake = new JSONHoldingBooleanGenerator("field \"IsWake\" of the Alarm class");
            fieldGeneratorIsRecurring = new JSONHoldingBooleanGenerator("field \"IsRecurring\" of the Alarm class");
            fieldGeneratorHour = new FieldHoldingGeneratorHour("field \"Hour\" of the Alarm class");
            fieldGeneratorMinute = new FieldHoldingGeneratorMinute("field \"Minute\" of the Alarm class");
            fieldGeneratorSecond = new FieldHoldingGeneratorSecond("field \"Second\" of the Alarm class");
            fieldGeneratorDaysOfWeek = new FieldHoldingArrayGeneratorDaysOfWeek("field \"DaysOfWeek\" of the Alarm class");
            fieldGeneratorInvalidDates = new DateAndOrTimeJSON.HoldingArrayGenerator("field \"InvalidDates\" of the Alarm class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Alarm class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTitle.reset();
            fieldGeneratorIsWake.reset();
            fieldGeneratorIsRecurring.reset();
            fieldGeneratorHour.reset();
            fieldGeneratorMinute.reset();
            fieldGeneratorSecond.reset();
            fieldGeneratorDaysOfWeek.reset();
            fieldGeneratorInvalidDates.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorInvalidDates.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorInvalidDates.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(AlarmJSON  result)
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
        public AlarmJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AlarmJSON  result)
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
    protected virtual void handle_result(List<AlarmJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AlarmJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AlarmJSON>();
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
    public List<AlarmJSON> value;
  };
  };
