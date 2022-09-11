/* file "DateTimeSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DateTimeSpecJSON : JSONBase
  {
    public enum TypeDayPhaseKnownValues
      {
        DayPhase_Unknown,
        DayPhase_All_x20_day,
        DayPhase_Midnight,
        DayPhase_Dawn,
        DayPhase_Morning,
        DayPhase_Noon,
        DayPhase_Afternoon,
        DayPhase_Dusk,
        DayPhase_Evening,
        DayPhase_Night,
        DayPhase__none
      };
    public struct TypeDayPhase
      {
        public bool in_known_list;
        public string string_value;
        public TypeDayPhaseKnownValues list_value;
      };

    public static TypeDayPhaseKnownValues  stringToDayPhase(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'f':
                        if ((String.Compare(chars, 2, "ternoon", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeDayPhaseKnownValues.DayPhase_Afternoon;
                        break;
                    case 'l':
                        if ((String.Compare(chars, 2, "l day", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeDayPhaseKnownValues.DayPhase_All_x20_day;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "wn", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeDayPhaseKnownValues.DayPhase_Dawn;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "sk", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeDayPhaseKnownValues.DayPhase_Dusk;
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                if ((String.Compare(chars, 1, "vening", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeDayPhaseKnownValues.DayPhase_Evening;
                break;
            case 'M':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "dnight", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeDayPhaseKnownValues.DayPhase_Midnight;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "rning", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeDayPhaseKnownValues.DayPhase_Morning;
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "ght", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeDayPhaseKnownValues.DayPhase_Night;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "on", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeDayPhaseKnownValues.DayPhase_Noon;
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeDayPhaseKnownValues.DayPhase_Unknown;
                break;
            default:
                break;
          }
        return TypeDayPhaseKnownValues.DayPhase__none;
      }

    public static string  stringFromDayPhase(TypeDayPhaseKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeDayPhaseKnownValues.DayPhase_Unknown:
                return "Unknown";
            case TypeDayPhaseKnownValues.DayPhase_All_x20_day:
                return "All day";
            case TypeDayPhaseKnownValues.DayPhase_Midnight:
                return "Midnight";
            case TypeDayPhaseKnownValues.DayPhase_Dawn:
                return "Dawn";
            case TypeDayPhaseKnownValues.DayPhase_Morning:
                return "Morning";
            case TypeDayPhaseKnownValues.DayPhase_Noon:
                return "Noon";
            case TypeDayPhaseKnownValues.DayPhase_Afternoon:
                return "Afternoon";
            case TypeDayPhaseKnownValues.DayPhase_Dusk:
                return "Dusk";
            case TypeDayPhaseKnownValues.DayPhase_Evening:
                return "Evening";
            case TypeDayPhaseKnownValues.DayPhase_Night:
                return "Night";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasDateAndTime;
    private DateAndOrTimeJSON  storeDateAndTime;
    private bool flagHasScheduledEventSpec;
    private ScheduledEventSpecJSON  storeScheduledEventSpec;
    private bool flagHasLabel;
    private string storeLabel;
    private bool flagHasSpokenLabel;
    private string storeSpokenLabel;
    private bool flagHasPrepositionText;
    private string storePrepositionText;
    private bool flagHasHolidayData;
    private HolidayJSON  storeHolidayData;
    private bool flagHasHoliday;
    private string storeHoliday;
    private bool flagHasDayPhase;
    private TypeDayPhase storeDayPhase;
    private bool flagHasYearMentioned;
    private bool storeYearMentioned;
    private bool flagHasMonthMentioned;
    private bool storeMonthMentioned;
    private bool flagHasDayOfMonthMentioned;
    private bool storeDayOfMonthMentioned;
    private bool flagHasDayOfWeekMentioned;
    private bool storeDayOfWeekMentioned;
    private bool flagHasDayArticleMentioned;
    private bool storeDayArticleMentioned;
    private bool flagHasDateMentioned;
    private bool storeDateMentioned;
    private bool flagHasTimeMentioned;
    private bool storeTimeMentioned;
    private bool flagHasTimeMentionedBeforeDate;
    private bool storeTimeMentionedBeforeDate;
    private bool flagHasTodayRequested;
    private bool storeTodayRequested;
    private bool flagHasNowRequested;
    private bool storeNowRequested;
    private bool flagHasRelativeToNow;
    private bool storeRelativeToNow;
    private bool flagHasRelativeToConversationDateTime;
    private bool storeRelativeToConversationDateTime;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDateAndTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setDateAndTime(convert_classy);
      }


    private void  fromJSONScheduledEventSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ScheduledEventSpecJSON convert_classy = ScheduledEventSpecJSON.from_json(json_value, ignore_extras, true);
        setScheduledEventSpec(convert_classy);
      }


    private void  fromJSONLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Label of DateTimeSpecJSON is not a string.");
        setLabel(json_string.getData());
      }


    private void  fromJSONSpokenLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SpokenLabel of DateTimeSpecJSON is not a string.");
        setSpokenLabel(json_string.getData());
      }


    private void  fromJSONPrepositionText(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PrepositionText of DateTimeSpecJSON is not a string.");
        setPrepositionText(json_string.getData());
      }


    private void  fromJSONHolidayData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HolidayJSON convert_classy = HolidayJSON.from_json(json_value, ignore_extras, true);
        setHolidayData(convert_classy);
      }


    private void  fromJSONHoliday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Holiday of DateTimeSpecJSON is not a string.");
        setHoliday(json_string.getData());
      }


    private void  fromJSONDayPhase(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DayPhase of DateTimeSpecJSON is not a string.");
        TypeDayPhase the_open_enum = new TypeDayPhase();
        switch (json_string.getData()[0])
          {
            case 'A':
                switch (json_string.getData()[1])
                  {
                    case 'f':
                        if ((String.Compare(json_string.getData(), 2, "ternoon", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDayPhaseKnownValues.DayPhase_Afternoon;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'l':
                        if ((String.Compare(json_string.getData(), 2, "l day", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDayPhaseKnownValues.DayPhase_All_x20_day;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "wn", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDayPhaseKnownValues.DayPhase_Dawn;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "sk", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDayPhaseKnownValues.DayPhase_Dusk;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "vening", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDayPhaseKnownValues.DayPhase_Evening;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "dnight", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDayPhaseKnownValues.DayPhase_Midnight;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "rning", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDayPhaseKnownValues.DayPhase_Morning;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'N':
                switch (json_string.getData()[1])
                  {
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "ght", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDayPhaseKnownValues.DayPhase_Night;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "on", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeDayPhaseKnownValues.DayPhase_Noon;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDayPhaseKnownValues.DayPhase_Unknown;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setDayPhase(the_open_enum);
      }


    private void  fromJSONYearMentioned(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field YearMentioned of DateTimeSpecJSON is not true for false.");
              }
          }
        setYearMentioned(the_bool);
      }


    private void  fromJSONMonthMentioned(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MonthMentioned of DateTimeSpecJSON is not true for false.");
              }
          }
        setMonthMentioned(the_bool);
      }


    private void  fromJSONDayOfMonthMentioned(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DayOfMonthMentioned of DateTimeSpecJSON is not true for false.");
              }
          }
        setDayOfMonthMentioned(the_bool);
      }


    private void  fromJSONDayOfWeekMentioned(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DayOfWeekMentioned of DateTimeSpecJSON is not true for false.");
              }
          }
        setDayOfWeekMentioned(the_bool);
      }


    private void  fromJSONDayArticleMentioned(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DayArticleMentioned of DateTimeSpecJSON is not true for false.");
              }
          }
        setDayArticleMentioned(the_bool);
      }


    private void  fromJSONDateMentioned(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DateMentioned of DateTimeSpecJSON is not true for false.");
              }
          }
        setDateMentioned(the_bool);
      }


    private void  fromJSONTimeMentioned(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TimeMentioned of DateTimeSpecJSON is not true for false.");
              }
          }
        setTimeMentioned(the_bool);
      }


    private void  fromJSONTimeMentionedBeforeDate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TimeMentionedBeforeDate of DateTimeSpecJSON is not true for false.");
              }
          }
        setTimeMentionedBeforeDate(the_bool);
      }


    private void  fromJSONTodayRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TodayRequested of DateTimeSpecJSON is not true for false.");
              }
          }
        setTodayRequested(the_bool);
      }


    private void  fromJSONNowRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NowRequested of DateTimeSpecJSON is not true for false.");
              }
          }
        setNowRequested(the_bool);
      }


    private void  fromJSONRelativeToNow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RelativeToNow of DateTimeSpecJSON is not true for false.");
              }
          }
        setRelativeToNow(the_bool);
      }


    private void  fromJSONRelativeToConversationDateTime(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RelativeToConversationDateTime of DateTimeSpecJSON is not true for false.");
              }
          }
        setRelativeToConversationDateTime(the_bool);
      }


    public DateTimeSpecJSON()
      {
        flagHasDateAndTime = false;
        flagHasScheduledEventSpec = false;
        flagHasLabel = false;
        flagHasSpokenLabel = false;
        flagHasPrepositionText = false;
        flagHasHolidayData = false;
        flagHasHoliday = false;
        flagHasDayPhase = false;
        flagHasYearMentioned = false;
        flagHasMonthMentioned = false;
        flagHasDayOfMonthMentioned = false;
        flagHasDayOfWeekMentioned = false;
        flagHasDayArticleMentioned = false;
        flagHasDateMentioned = false;
        flagHasTimeMentioned = false;
        flagHasTimeMentionedBeforeDate = false;
        flagHasTodayRequested = false;
        flagHasNowRequested = false;
        flagHasRelativeToNow = false;
        flagHasRelativeToConversationDateTime = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDateAndTime()
      {
        return flagHasDateAndTime;
      }

    public DateAndOrTimeJSON   getDateAndTime()
      {
        Debug.Assert(flagHasDateAndTime);
        return storeDateAndTime;
      }

    public bool  hasScheduledEventSpec()
      {
        return flagHasScheduledEventSpec;
      }

    public ScheduledEventSpecJSON   getScheduledEventSpec()
      {
        Debug.Assert(flagHasScheduledEventSpec);
        return storeScheduledEventSpec;
      }

    public bool  hasLabel()
      {
        return flagHasLabel;
      }

    public string  getLabel()
      {
        Debug.Assert(flagHasLabel);
        return storeLabel;
      }

    public bool  hasSpokenLabel()
      {
        return flagHasSpokenLabel;
      }

    public string  getSpokenLabel()
      {
        Debug.Assert(flagHasSpokenLabel);
        return storeSpokenLabel;
      }

    public bool  hasPrepositionText()
      {
        return flagHasPrepositionText;
      }

    public string  getPrepositionText()
      {
        Debug.Assert(flagHasPrepositionText);
        return storePrepositionText;
      }

    public bool  hasHolidayData()
      {
        return flagHasHolidayData;
      }

    public HolidayJSON   getHolidayData()
      {
        Debug.Assert(flagHasHolidayData);
        return storeHolidayData;
      }

    public HolidayJSON.TypeValue  getHolidayDataValue()
      {
        return getHolidayData().getValue();
      }

    public string  getHolidayDataAsString()
      {
        return getHolidayData().getValueAsString();
      }

    public bool  hasHoliday()
      {
        return flagHasHoliday;
      }

    public string  getHoliday()
      {
        Debug.Assert(flagHasHoliday);
        return storeHoliday;
      }

    public bool  hasDayPhase()
      {
        return flagHasDayPhase;
      }

    public TypeDayPhase  getDayPhase()
      {
        Debug.Assert(flagHasDayPhase);
        return storeDayPhase;
      }

    public string  getDayPhaseAsString()
      {
        TypeDayPhase result = getDayPhase();
        if (result.in_known_list)
            return stringFromDayPhase(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasYearMentioned()
      {
        return flagHasYearMentioned;
      }

    public bool  getYearMentioned()
      {
        Debug.Assert(flagHasYearMentioned);
        return storeYearMentioned;
      }

    public bool  hasMonthMentioned()
      {
        return flagHasMonthMentioned;
      }

    public bool  getMonthMentioned()
      {
        Debug.Assert(flagHasMonthMentioned);
        return storeMonthMentioned;
      }

    public bool  hasDayOfMonthMentioned()
      {
        return flagHasDayOfMonthMentioned;
      }

    public bool  getDayOfMonthMentioned()
      {
        Debug.Assert(flagHasDayOfMonthMentioned);
        return storeDayOfMonthMentioned;
      }

    public bool  hasDayOfWeekMentioned()
      {
        return flagHasDayOfWeekMentioned;
      }

    public bool  getDayOfWeekMentioned()
      {
        Debug.Assert(flagHasDayOfWeekMentioned);
        return storeDayOfWeekMentioned;
      }

    public bool  hasDayArticleMentioned()
      {
        return flagHasDayArticleMentioned;
      }

    public bool  getDayArticleMentioned()
      {
        Debug.Assert(flagHasDayArticleMentioned);
        return storeDayArticleMentioned;
      }

    public bool  hasDateMentioned()
      {
        return flagHasDateMentioned;
      }

    public bool  getDateMentioned()
      {
        Debug.Assert(flagHasDateMentioned);
        return storeDateMentioned;
      }

    public bool  hasTimeMentioned()
      {
        return flagHasTimeMentioned;
      }

    public bool  getTimeMentioned()
      {
        Debug.Assert(flagHasTimeMentioned);
        return storeTimeMentioned;
      }

    public bool  hasTimeMentionedBeforeDate()
      {
        return flagHasTimeMentionedBeforeDate;
      }

    public bool  getTimeMentionedBeforeDate()
      {
        Debug.Assert(flagHasTimeMentionedBeforeDate);
        return storeTimeMentionedBeforeDate;
      }

    public bool  hasTodayRequested()
      {
        return flagHasTodayRequested;
      }

    public bool  getTodayRequested()
      {
        Debug.Assert(flagHasTodayRequested);
        return storeTodayRequested;
      }

    public bool  hasNowRequested()
      {
        return flagHasNowRequested;
      }

    public bool  getNowRequested()
      {
        Debug.Assert(flagHasNowRequested);
        return storeNowRequested;
      }

    public bool  hasRelativeToNow()
      {
        return flagHasRelativeToNow;
      }

    public bool  getRelativeToNow()
      {
        Debug.Assert(flagHasRelativeToNow);
        return storeRelativeToNow;
      }

    public bool  hasRelativeToConversationDateTime()
      {
        return flagHasRelativeToConversationDateTime;
      }

    public bool  getRelativeToConversationDateTime()
      {
        Debug.Assert(flagHasRelativeToConversationDateTime);
        return storeRelativeToConversationDateTime;
      }


    public virtual int extraDateTimeSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDateTimeSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDateTimeSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDateTimeSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setDateAndTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasDateAndTime)
          {
          }
        flagHasDateAndTime = true;
        storeDateAndTime = new_value;
      }
    public void unsetDateAndTime()
      {
        if (flagHasDateAndTime)
          {
          }
        flagHasDateAndTime = false;
      }
    public void setScheduledEventSpec(ScheduledEventSpecJSON  new_value)
      {
        if (flagHasScheduledEventSpec)
          {
          }
        flagHasScheduledEventSpec = true;
        storeScheduledEventSpec = new_value;
      }
    public void unsetScheduledEventSpec()
      {
        if (flagHasScheduledEventSpec)
          {
          }
        flagHasScheduledEventSpec = false;
      }
    public void setLabel(string new_value)
      {
        flagHasLabel = true;
        storeLabel = new_value;
      }
    public void unsetLabel()
      {
        flagHasLabel = false;
      }
    public void setSpokenLabel(string new_value)
      {
        flagHasSpokenLabel = true;
        storeSpokenLabel = new_value;
      }
    public void unsetSpokenLabel()
      {
        flagHasSpokenLabel = false;
      }
    public void setPrepositionText(string new_value)
      {
        flagHasPrepositionText = true;
        storePrepositionText = new_value;
      }
    public void unsetPrepositionText()
      {
        flagHasPrepositionText = false;
      }
    public void setHolidayData(HolidayJSON  new_value)
      {
        if (flagHasHolidayData)
          {
          }
        flagHasHolidayData = true;
        storeHolidayData = new_value;
      }
    public void setHolidayData(HolidayJSON.TypeValue new_value)
      {
        setHolidayData(new HolidayJSON(new_value));
      }
    public void setHolidayData(string chars)
      {
        HolidayJSON.TypeValueKnownValues known = HolidayJSON.stringToValue(chars);
        HolidayJSON.TypeValue new_value = new HolidayJSON.TypeValue();
        if (known == HolidayJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setHolidayData(new_value);
      }
    public void unsetHolidayData()
      {
        if (flagHasHolidayData)
          {
          }
        flagHasHolidayData = false;
      }
    public void setHoliday(string new_value)
      {
        flagHasHoliday = true;
        storeHoliday = new_value;
      }
    public void unsetHoliday()
      {
        flagHasHoliday = false;
      }
    public void setDayPhase(TypeDayPhase new_value)
      {
        flagHasDayPhase = true;
        storeDayPhase = new_value;
      }
    public void setDayPhase(string chars)
      {
        TypeDayPhaseKnownValues known = stringToDayPhase(chars);
        TypeDayPhase new_value = new TypeDayPhase();
        if (known == TypeDayPhaseKnownValues.DayPhase__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setDayPhase(new_value);
      }
    public void setDayPhase(TypeDayPhaseKnownValues new_value)
      {
        TypeDayPhase new_full_value = new TypeDayPhase();
        Debug.Assert(new_value != TypeDayPhaseKnownValues.DayPhase__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setDayPhase(new_full_value);
      }
    public void unsetDayPhase()
      {
        flagHasDayPhase = false;
      }
    public void setYearMentioned(bool new_value)
      {
        flagHasYearMentioned = true;
        storeYearMentioned = new_value;
      }
    public void unsetYearMentioned()
      {
        flagHasYearMentioned = false;
      }
    public void setMonthMentioned(bool new_value)
      {
        flagHasMonthMentioned = true;
        storeMonthMentioned = new_value;
      }
    public void unsetMonthMentioned()
      {
        flagHasMonthMentioned = false;
      }
    public void setDayOfMonthMentioned(bool new_value)
      {
        flagHasDayOfMonthMentioned = true;
        storeDayOfMonthMentioned = new_value;
      }
    public void unsetDayOfMonthMentioned()
      {
        flagHasDayOfMonthMentioned = false;
      }
    public void setDayOfWeekMentioned(bool new_value)
      {
        flagHasDayOfWeekMentioned = true;
        storeDayOfWeekMentioned = new_value;
      }
    public void unsetDayOfWeekMentioned()
      {
        flagHasDayOfWeekMentioned = false;
      }
    public void setDayArticleMentioned(bool new_value)
      {
        flagHasDayArticleMentioned = true;
        storeDayArticleMentioned = new_value;
      }
    public void unsetDayArticleMentioned()
      {
        flagHasDayArticleMentioned = false;
      }
    public void setDateMentioned(bool new_value)
      {
        flagHasDateMentioned = true;
        storeDateMentioned = new_value;
      }
    public void unsetDateMentioned()
      {
        flagHasDateMentioned = false;
      }
    public void setTimeMentioned(bool new_value)
      {
        flagHasTimeMentioned = true;
        storeTimeMentioned = new_value;
      }
    public void unsetTimeMentioned()
      {
        flagHasTimeMentioned = false;
      }
    public void setTimeMentionedBeforeDate(bool new_value)
      {
        flagHasTimeMentionedBeforeDate = true;
        storeTimeMentionedBeforeDate = new_value;
      }
    public void unsetTimeMentionedBeforeDate()
      {
        flagHasTimeMentionedBeforeDate = false;
      }
    public void setTodayRequested(bool new_value)
      {
        flagHasTodayRequested = true;
        storeTodayRequested = new_value;
      }
    public void unsetTodayRequested()
      {
        flagHasTodayRequested = false;
      }
    public void setNowRequested(bool new_value)
      {
        flagHasNowRequested = true;
        storeNowRequested = new_value;
      }
    public void unsetNowRequested()
      {
        flagHasNowRequested = false;
      }
    public void setRelativeToNow(bool new_value)
      {
        flagHasRelativeToNow = true;
        storeRelativeToNow = new_value;
      }
    public void unsetRelativeToNow()
      {
        flagHasRelativeToNow = false;
      }
    public void setRelativeToConversationDateTime(bool new_value)
      {
        flagHasRelativeToConversationDateTime = true;
        storeRelativeToConversationDateTime = new_value;
      }
    public void unsetRelativeToConversationDateTime()
      {
        flagHasRelativeToConversationDateTime = false;
      }

    public virtual void extraDateTimeSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDateTimeSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDateTimeSpecLookup(key);
        if (old_field == null)
          {
            extraDateTimeSpecAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDateAndTime);
        if (flagHasDateAndTime)
          {
            handler.start_pair("DateAndTime");
            if (partial_allowed)
                storeDateAndTime.write_partial_as_json(handler);
            else
                storeDateAndTime.write_as_json(handler);
          }
        if (flagHasScheduledEventSpec)
          {
            handler.start_pair("ScheduledEventSpec");
            if (partial_allowed)
                storeScheduledEventSpec.write_partial_as_json(handler);
            else
                storeScheduledEventSpec.write_as_json(handler);
          }
        if (flagHasLabel)
          {
            handler.start_pair("Label");
            handler.string_value(storeLabel);
          }
        if (flagHasSpokenLabel)
          {
            handler.start_pair("SpokenLabel");
            handler.string_value(storeSpokenLabel);
          }
        if (flagHasPrepositionText)
          {
            handler.start_pair("PrepositionText");
            handler.string_value(storePrepositionText);
          }
        if (flagHasHolidayData)
          {
            handler.start_pair("HolidayData");
            if (partial_allowed)
                storeHolidayData.write_partial_as_json(handler);
            else
                storeHolidayData.write_as_json(handler);
          }
        if (flagHasHoliday)
          {
            handler.start_pair("Holiday");
            handler.string_value(storeHoliday);
          }
        Debug.Assert(partial_allowed || flagHasDayPhase);
        if (flagHasDayPhase)
          {
            handler.start_pair("DayPhase");
            if (storeDayPhase.in_known_list)
              {
                switch (storeDayPhase.list_value)
                  {
                    case TypeDayPhaseKnownValues.DayPhase_Unknown:
                        handler.string_value("Unknown");
                        break;
                    case TypeDayPhaseKnownValues.DayPhase_All_x20_day:
                        handler.string_value("All day");
                        break;
                    case TypeDayPhaseKnownValues.DayPhase_Midnight:
                        handler.string_value("Midnight");
                        break;
                    case TypeDayPhaseKnownValues.DayPhase_Dawn:
                        handler.string_value("Dawn");
                        break;
                    case TypeDayPhaseKnownValues.DayPhase_Morning:
                        handler.string_value("Morning");
                        break;
                    case TypeDayPhaseKnownValues.DayPhase_Noon:
                        handler.string_value("Noon");
                        break;
                    case TypeDayPhaseKnownValues.DayPhase_Afternoon:
                        handler.string_value("Afternoon");
                        break;
                    case TypeDayPhaseKnownValues.DayPhase_Dusk:
                        handler.string_value("Dusk");
                        break;
                    case TypeDayPhaseKnownValues.DayPhase_Evening:
                        handler.string_value("Evening");
                        break;
                    case TypeDayPhaseKnownValues.DayPhase_Night:
                        handler.string_value("Night");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeDayPhase.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasYearMentioned);
        if (flagHasYearMentioned)
          {
            handler.start_pair("YearMentioned");
            handler.boolean_value(storeYearMentioned);
          }
        Debug.Assert(partial_allowed || flagHasMonthMentioned);
        if (flagHasMonthMentioned)
          {
            handler.start_pair("MonthMentioned");
            handler.boolean_value(storeMonthMentioned);
          }
        Debug.Assert(partial_allowed || flagHasDayOfMonthMentioned);
        if (flagHasDayOfMonthMentioned)
          {
            handler.start_pair("DayOfMonthMentioned");
            handler.boolean_value(storeDayOfMonthMentioned);
          }
        Debug.Assert(partial_allowed || flagHasDayOfWeekMentioned);
        if (flagHasDayOfWeekMentioned)
          {
            handler.start_pair("DayOfWeekMentioned");
            handler.boolean_value(storeDayOfWeekMentioned);
          }
        Debug.Assert(partial_allowed || flagHasDayArticleMentioned);
        if (flagHasDayArticleMentioned)
          {
            handler.start_pair("DayArticleMentioned");
            handler.boolean_value(storeDayArticleMentioned);
          }
        Debug.Assert(partial_allowed || flagHasDateMentioned);
        if (flagHasDateMentioned)
          {
            handler.start_pair("DateMentioned");
            handler.boolean_value(storeDateMentioned);
          }
        Debug.Assert(partial_allowed || flagHasTimeMentioned);
        if (flagHasTimeMentioned)
          {
            handler.start_pair("TimeMentioned");
            handler.boolean_value(storeTimeMentioned);
          }
        Debug.Assert(partial_allowed || flagHasTimeMentionedBeforeDate);
        if (flagHasTimeMentionedBeforeDate)
          {
            handler.start_pair("TimeMentionedBeforeDate");
            handler.boolean_value(storeTimeMentionedBeforeDate);
          }
        Debug.Assert(partial_allowed || flagHasTodayRequested);
        if (flagHasTodayRequested)
          {
            handler.start_pair("TodayRequested");
            handler.boolean_value(storeTodayRequested);
          }
        Debug.Assert(partial_allowed || flagHasNowRequested);
        if (flagHasNowRequested)
          {
            handler.start_pair("NowRequested");
            handler.boolean_value(storeNowRequested);
          }
        Debug.Assert(partial_allowed || flagHasRelativeToNow);
        if (flagHasRelativeToNow)
          {
            handler.start_pair("RelativeToNow");
            handler.boolean_value(storeRelativeToNow);
          }
        Debug.Assert(partial_allowed || flagHasRelativeToConversationDateTime);
        if (flagHasRelativeToConversationDateTime)
          {
            handler.start_pair("RelativeToConversationDateTime");
            handler.boolean_value(storeRelativeToConversationDateTime);
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
        if (!(hasDateAndTime()))
          {
            return "When parsing the object for %what%, the \"DateAndTime\" field was missing.";
          }
        if (!(hasDayPhase()))
          {
            return "When parsing the object for %what%, the \"DayPhase\" field was missing.";
          }
        if (!(hasYearMentioned()))
          {
            return "When parsing the object for %what%, the \"YearMentioned\" field was missing.";
          }
        if (!(hasMonthMentioned()))
          {
            return "When parsing the object for %what%, the \"MonthMentioned\" field was missing.";
          }
        if (!(hasDayOfMonthMentioned()))
          {
            return "When parsing the object for %what%, the \"DayOfMonthMentioned\" field was missing.";
          }
        if (!(hasDayOfWeekMentioned()))
          {
            return "When parsing the object for %what%, the \"DayOfWeekMentioned\" field was missing.";
          }
        if (!(hasDayArticleMentioned()))
          {
            return "When parsing the object for %what%, the \"DayArticleMentioned\" field was missing.";
          }
        if (!(hasDateMentioned()))
          {
            return "When parsing the object for %what%, the \"DateMentioned\" field was missing.";
          }
        if (!(hasTimeMentioned()))
          {
            return "When parsing the object for %what%, the \"TimeMentioned\" field was missing.";
          }
        if (!(hasTimeMentionedBeforeDate()))
          {
            return "When parsing the object for %what%, the \"TimeMentionedBeforeDate\" field was missing.";
          }
        if (!(hasTodayRequested()))
          {
            return "When parsing the object for %what%, the \"TodayRequested\" field was missing.";
          }
        if (!(hasNowRequested()))
          {
            return "When parsing the object for %what%, the \"NowRequested\" field was missing.";
          }
        if (!(hasRelativeToNow()))
          {
            return "When parsing the object for %what%, the \"RelativeToNow\" field was missing.";
          }
        if (!(hasRelativeToConversationDateTime()))
          {
            return "When parsing the object for %what%, the \"RelativeToConversationDateTime\" field was missing.";
          }
        return null;
      }

    public static DateTimeSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateTimeSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateTimeSpec", ignore_extras);
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
    public static DateTimeSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DateTimeSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateTimeSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateTimeSpec", ignore_extras);
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
    public static DateTimeSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DateTimeSpecJSON from_text(string text, bool ignore_extras)
      {
        DateTimeSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateTimeSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DateTimeSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DateTimeSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DateTimeSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateTimeSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorDateAndTime;
        private ScheduledEventSpecJSON.HoldingGenerator fieldGeneratorScheduledEventSpec;
        private JSONHoldingStringGenerator fieldGeneratorLabel;
        private JSONHoldingStringGenerator fieldGeneratorSpokenLabel;
        private JSONHoldingStringGenerator fieldGeneratorPrepositionText;
        private HolidayJSON.HoldingGenerator fieldGeneratorHolidayData;
        private JSONHoldingStringGenerator fieldGeneratorHoliday;
    private abstract class FieldGeneratorDayPhase : JSONStringGenerator
          {
            protected FieldGeneratorDayPhase(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDayPhase()
              {
              }
            protected override void handle_result(string result)
              {
                TypeDayPhaseKnownValues known = stringToDayPhase(result);
                TypeDayPhase new_value = new TypeDayPhase();
                if (known == TypeDayPhaseKnownValues.DayPhase__none)
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
            protected abstract void handle_result(TypeDayPhase result);
          };
    private class FieldHoldingGeneratorDayPhase : FieldGeneratorDayPhase
  {
    protected override void handle_result(TypeDayPhase result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDayPhase(String what)
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
    public TypeDayPhase value;
  };
    private class FieldHoldingArrayGeneratorDayPhase : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDayPhase
      {
        private FieldHoldingArrayGeneratorDayPhase top;

        protected override void handle_result(TypeDayPhase result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDayPhase init_top)
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
    protected virtual void handle_result(List<TypeDayPhase> result)
      {
      }

    public FieldHoldingArrayGeneratorDayPhase(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDayPhase>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDayPhase()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDayPhase>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDayPhase> value;
  };
        private FieldHoldingGeneratorDayPhase fieldGeneratorDayPhase;
        private JSONHoldingBooleanGenerator fieldGeneratorYearMentioned;
        private JSONHoldingBooleanGenerator fieldGeneratorMonthMentioned;
        private JSONHoldingBooleanGenerator fieldGeneratorDayOfMonthMentioned;
        private JSONHoldingBooleanGenerator fieldGeneratorDayOfWeekMentioned;
        private JSONHoldingBooleanGenerator fieldGeneratorDayArticleMentioned;
        private JSONHoldingBooleanGenerator fieldGeneratorDateMentioned;
        private JSONHoldingBooleanGenerator fieldGeneratorTimeMentioned;
        private JSONHoldingBooleanGenerator fieldGeneratorTimeMentionedBeforeDate;
        private JSONHoldingBooleanGenerator fieldGeneratorTodayRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorNowRequested;
        private JSONHoldingBooleanGenerator fieldGeneratorRelativeToNow;
        private JSONHoldingBooleanGenerator fieldGeneratorRelativeToConversationDateTime;
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
            DateTimeSpecJSON result = new DateTimeSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDateTimeSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DateTimeSpecJSON result)
          {
            if (fieldGeneratorDateAndTime.have_value)
              {
                result.setDateAndTime(fieldGeneratorDateAndTime.value);
                fieldGeneratorDateAndTime.have_value = false;
              }
            else if ((!(result.hasDateAndTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndTime\" field was missing.");
              }
            if (fieldGeneratorScheduledEventSpec.have_value)
              {
                result.setScheduledEventSpec(fieldGeneratorScheduledEventSpec.value);
                fieldGeneratorScheduledEventSpec.have_value = false;
              }
            if (fieldGeneratorLabel.have_value)
              {
                result.setLabel(fieldGeneratorLabel.value);
                fieldGeneratorLabel.have_value = false;
              }
            if (fieldGeneratorSpokenLabel.have_value)
              {
                result.setSpokenLabel(fieldGeneratorSpokenLabel.value);
                fieldGeneratorSpokenLabel.have_value = false;
              }
            if (fieldGeneratorPrepositionText.have_value)
              {
                result.setPrepositionText(fieldGeneratorPrepositionText.value);
                fieldGeneratorPrepositionText.have_value = false;
              }
            if (fieldGeneratorHolidayData.have_value)
              {
                result.setHolidayData(fieldGeneratorHolidayData.value);
                fieldGeneratorHolidayData.have_value = false;
              }
            if (fieldGeneratorHoliday.have_value)
              {
                result.setHoliday(fieldGeneratorHoliday.value);
                fieldGeneratorHoliday.have_value = false;
              }
            if (fieldGeneratorDayPhase.have_value)
              {
                result.setDayPhase(fieldGeneratorDayPhase.value);
                fieldGeneratorDayPhase.have_value = false;
              }
            else if ((!(result.hasDayPhase())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DayPhase\" field was missing.");
              }
            if (fieldGeneratorYearMentioned.have_value)
              {
                result.setYearMentioned(fieldGeneratorYearMentioned.value);
                fieldGeneratorYearMentioned.have_value = false;
              }
            else if ((!(result.hasYearMentioned())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"YearMentioned\" field was missing.");
              }
            if (fieldGeneratorMonthMentioned.have_value)
              {
                result.setMonthMentioned(fieldGeneratorMonthMentioned.value);
                fieldGeneratorMonthMentioned.have_value = false;
              }
            else if ((!(result.hasMonthMentioned())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MonthMentioned\" field was missing.");
              }
            if (fieldGeneratorDayOfMonthMentioned.have_value)
              {
                result.setDayOfMonthMentioned(fieldGeneratorDayOfMonthMentioned.value);
                fieldGeneratorDayOfMonthMentioned.have_value = false;
              }
            else if ((!(result.hasDayOfMonthMentioned())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DayOfMonthMentioned\" field was missing.");
              }
            if (fieldGeneratorDayOfWeekMentioned.have_value)
              {
                result.setDayOfWeekMentioned(fieldGeneratorDayOfWeekMentioned.value);
                fieldGeneratorDayOfWeekMentioned.have_value = false;
              }
            else if ((!(result.hasDayOfWeekMentioned())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DayOfWeekMentioned\" field was missing.");
              }
            if (fieldGeneratorDayArticleMentioned.have_value)
              {
                result.setDayArticleMentioned(fieldGeneratorDayArticleMentioned.value);
                fieldGeneratorDayArticleMentioned.have_value = false;
              }
            else if ((!(result.hasDayArticleMentioned())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DayArticleMentioned\" field was missing.");
              }
            if (fieldGeneratorDateMentioned.have_value)
              {
                result.setDateMentioned(fieldGeneratorDateMentioned.value);
                fieldGeneratorDateMentioned.have_value = false;
              }
            else if ((!(result.hasDateMentioned())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateMentioned\" field was missing.");
              }
            if (fieldGeneratorTimeMentioned.have_value)
              {
                result.setTimeMentioned(fieldGeneratorTimeMentioned.value);
                fieldGeneratorTimeMentioned.have_value = false;
              }
            else if ((!(result.hasTimeMentioned())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TimeMentioned\" field was missing.");
              }
            if (fieldGeneratorTimeMentionedBeforeDate.have_value)
              {
                result.setTimeMentionedBeforeDate(fieldGeneratorTimeMentionedBeforeDate.value);
                fieldGeneratorTimeMentionedBeforeDate.have_value = false;
              }
            else if ((!(result.hasTimeMentionedBeforeDate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TimeMentionedBeforeDate\" field was missing.");
              }
            if (fieldGeneratorTodayRequested.have_value)
              {
                result.setTodayRequested(fieldGeneratorTodayRequested.value);
                fieldGeneratorTodayRequested.have_value = false;
              }
            else if ((!(result.hasTodayRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TodayRequested\" field was missing.");
              }
            if (fieldGeneratorNowRequested.have_value)
              {
                result.setNowRequested(fieldGeneratorNowRequested.value);
                fieldGeneratorNowRequested.have_value = false;
              }
            else if ((!(result.hasNowRequested())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NowRequested\" field was missing.");
              }
            if (fieldGeneratorRelativeToNow.have_value)
              {
                result.setRelativeToNow(fieldGeneratorRelativeToNow.value);
                fieldGeneratorRelativeToNow.have_value = false;
              }
            else if ((!(result.hasRelativeToNow())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RelativeToNow\" field was missing.");
              }
            if (fieldGeneratorRelativeToConversationDateTime.have_value)
              {
                result.setRelativeToConversationDateTime(fieldGeneratorRelativeToConversationDateTime.value);
                fieldGeneratorRelativeToConversationDateTime.have_value = false;
              }
            else if ((!(result.hasRelativeToConversationDateTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RelativeToConversationDateTime\" field was missing.");
              }
          }
        protected abstract void handle_result(DateTimeSpecJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "a", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 't':
                                if (String.Compare(field_name, 3, "e", 0, 1, false) == 0)
                                  {
                                    switch (field_name[4])
                                      {
                                        case 'A':
                                            if ((String.Compare(field_name, 5, "ndTime", 0, 6, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorDateAndTime;
                                            break;
                                        case 'M':
                                            if ((String.Compare(field_name, 5, "entioned", 0, 8, false) == 0) && (field_name.Length == 13))
                                                return fieldGeneratorDateMentioned;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'y':
                                switch (field_name[3])
                                  {
                                    case 'A':
                                        if ((String.Compare(field_name, 4, "rticleMentioned", 0, 15, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorDayArticleMentioned;
                                        break;
                                    case 'O':
                                        if (String.Compare(field_name, 4, "f", 0, 1, false) == 0)
                                          {
                                            switch (field_name[5])
                                              {
                                                case 'M':
                                                    if ((String.Compare(field_name, 6, "onthMentioned", 0, 13, false) == 0) && (field_name.Length == 19))
                                                        return fieldGeneratorDayOfMonthMentioned;
                                                    break;
                                                case 'W':
                                                    if ((String.Compare(field_name, 6, "eekMentioned", 0, 12, false) == 0) && (field_name.Length == 18))
                                                        return fieldGeneratorDayOfWeekMentioned;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'P':
                                        if ((String.Compare(field_name, 4, "hase", 0, 4, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorDayPhase;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if (String.Compare(field_name, 1, "oliday", 0, 6, false) == 0)
                      {
                        if (field_name.Length == 7)
                          {
                            return fieldGeneratorHoliday;
                          }
                        switch (field_name[7])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 8, "ata", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorHolidayData;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "abel", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorLabel;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "onthMentioned", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorMonthMentioned;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "owRequested", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorNowRequested;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "repositionText", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorPrepositionText;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "elativeTo", 0, 9, false) == 0)
                      {
                        switch (field_name[10])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 11, "onversationDateTime", 0, 19, false) == 0) && (field_name.Length == 30))
                                    return fieldGeneratorRelativeToConversationDateTime;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 11, "ow", 0, 2, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorRelativeToNow;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "heduledEventSpec", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorScheduledEventSpec;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "okenLabel", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorSpokenLabel;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'i':
                            if (String.Compare(field_name, 2, "meMentioned", 0, 11, false) == 0)
                              {
                                if (field_name.Length == 13)
                                  {
                                    return fieldGeneratorTimeMentioned;
                                  }
                                switch (field_name[13])
                                  {
                                    case 'B':
                                        if ((String.Compare(field_name, 14, "eforeDate", 0, 9, false) == 0) && (field_name.Length == 23))
                                            return fieldGeneratorTimeMentionedBeforeDate;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "dayRequested", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorTodayRequested;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'Y':
                    if ((String.Compare(field_name, 1, "earMentioned", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorYearMentioned;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndTime\" of the DateTimeSpec class", ignore_extras);
            fieldGeneratorScheduledEventSpec = new ScheduledEventSpecJSON.HoldingGenerator("field \"ScheduledEventSpec\" of the DateTimeSpec class", ignore_extras);
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the DateTimeSpec class");
            fieldGeneratorSpokenLabel = new JSONHoldingStringGenerator("field \"SpokenLabel\" of the DateTimeSpec class");
            fieldGeneratorPrepositionText = new JSONHoldingStringGenerator("field \"PrepositionText\" of the DateTimeSpec class");
            fieldGeneratorHolidayData = new HolidayJSON.HoldingGenerator("field \"HolidayData\" of the DateTimeSpec class", ignore_extras);
            fieldGeneratorHoliday = new JSONHoldingStringGenerator("field \"Holiday\" of the DateTimeSpec class");
            fieldGeneratorDayPhase = new FieldHoldingGeneratorDayPhase("field \"DayPhase\" of the DateTimeSpec class");
            fieldGeneratorYearMentioned = new JSONHoldingBooleanGenerator("field \"YearMentioned\" of the DateTimeSpec class");
            fieldGeneratorMonthMentioned = new JSONHoldingBooleanGenerator("field \"MonthMentioned\" of the DateTimeSpec class");
            fieldGeneratorDayOfMonthMentioned = new JSONHoldingBooleanGenerator("field \"DayOfMonthMentioned\" of the DateTimeSpec class");
            fieldGeneratorDayOfWeekMentioned = new JSONHoldingBooleanGenerator("field \"DayOfWeekMentioned\" of the DateTimeSpec class");
            fieldGeneratorDayArticleMentioned = new JSONHoldingBooleanGenerator("field \"DayArticleMentioned\" of the DateTimeSpec class");
            fieldGeneratorDateMentioned = new JSONHoldingBooleanGenerator("field \"DateMentioned\" of the DateTimeSpec class");
            fieldGeneratorTimeMentioned = new JSONHoldingBooleanGenerator("field \"TimeMentioned\" of the DateTimeSpec class");
            fieldGeneratorTimeMentionedBeforeDate = new JSONHoldingBooleanGenerator("field \"TimeMentionedBeforeDate\" of the DateTimeSpec class");
            fieldGeneratorTodayRequested = new JSONHoldingBooleanGenerator("field \"TodayRequested\" of the DateTimeSpec class");
            fieldGeneratorNowRequested = new JSONHoldingBooleanGenerator("field \"NowRequested\" of the DateTimeSpec class");
            fieldGeneratorRelativeToNow = new JSONHoldingBooleanGenerator("field \"RelativeToNow\" of the DateTimeSpec class");
            fieldGeneratorRelativeToConversationDateTime = new JSONHoldingBooleanGenerator("field \"RelativeToConversationDateTime\" of the DateTimeSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DateTimeSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDateAndTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndTime\" of the DateTimeSpec class", false);
            fieldGeneratorScheduledEventSpec = new ScheduledEventSpecJSON.HoldingGenerator("field \"ScheduledEventSpec\" of the DateTimeSpec class", false);
            fieldGeneratorLabel = new JSONHoldingStringGenerator("field \"Label\" of the DateTimeSpec class");
            fieldGeneratorSpokenLabel = new JSONHoldingStringGenerator("field \"SpokenLabel\" of the DateTimeSpec class");
            fieldGeneratorPrepositionText = new JSONHoldingStringGenerator("field \"PrepositionText\" of the DateTimeSpec class");
            fieldGeneratorHolidayData = new HolidayJSON.HoldingGenerator("field \"HolidayData\" of the DateTimeSpec class", false);
            fieldGeneratorHoliday = new JSONHoldingStringGenerator("field \"Holiday\" of the DateTimeSpec class");
            fieldGeneratorDayPhase = new FieldHoldingGeneratorDayPhase("field \"DayPhase\" of the DateTimeSpec class");
            fieldGeneratorYearMentioned = new JSONHoldingBooleanGenerator("field \"YearMentioned\" of the DateTimeSpec class");
            fieldGeneratorMonthMentioned = new JSONHoldingBooleanGenerator("field \"MonthMentioned\" of the DateTimeSpec class");
            fieldGeneratorDayOfMonthMentioned = new JSONHoldingBooleanGenerator("field \"DayOfMonthMentioned\" of the DateTimeSpec class");
            fieldGeneratorDayOfWeekMentioned = new JSONHoldingBooleanGenerator("field \"DayOfWeekMentioned\" of the DateTimeSpec class");
            fieldGeneratorDayArticleMentioned = new JSONHoldingBooleanGenerator("field \"DayArticleMentioned\" of the DateTimeSpec class");
            fieldGeneratorDateMentioned = new JSONHoldingBooleanGenerator("field \"DateMentioned\" of the DateTimeSpec class");
            fieldGeneratorTimeMentioned = new JSONHoldingBooleanGenerator("field \"TimeMentioned\" of the DateTimeSpec class");
            fieldGeneratorTimeMentionedBeforeDate = new JSONHoldingBooleanGenerator("field \"TimeMentionedBeforeDate\" of the DateTimeSpec class");
            fieldGeneratorTodayRequested = new JSONHoldingBooleanGenerator("field \"TodayRequested\" of the DateTimeSpec class");
            fieldGeneratorNowRequested = new JSONHoldingBooleanGenerator("field \"NowRequested\" of the DateTimeSpec class");
            fieldGeneratorRelativeToNow = new JSONHoldingBooleanGenerator("field \"RelativeToNow\" of the DateTimeSpec class");
            fieldGeneratorRelativeToConversationDateTime = new JSONHoldingBooleanGenerator("field \"RelativeToConversationDateTime\" of the DateTimeSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DateTimeSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDateAndTime.reset();
            fieldGeneratorScheduledEventSpec.reset();
            fieldGeneratorLabel.reset();
            fieldGeneratorSpokenLabel.reset();
            fieldGeneratorPrepositionText.reset();
            fieldGeneratorHolidayData.reset();
            fieldGeneratorHoliday.reset();
            fieldGeneratorDayPhase.reset();
            fieldGeneratorYearMentioned.reset();
            fieldGeneratorMonthMentioned.reset();
            fieldGeneratorDayOfMonthMentioned.reset();
            fieldGeneratorDayOfWeekMentioned.reset();
            fieldGeneratorDayArticleMentioned.reset();
            fieldGeneratorDateMentioned.reset();
            fieldGeneratorTimeMentioned.reset();
            fieldGeneratorTimeMentionedBeforeDate.reset();
            fieldGeneratorTodayRequested.reset();
            fieldGeneratorNowRequested.reset();
            fieldGeneratorRelativeToNow.reset();
            fieldGeneratorRelativeToConversationDateTime.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDateAndTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorScheduledEventSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHolidayData.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDateAndTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorScheduledEventSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHolidayData.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DateTimeSpecJSON  result)
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
        public DateTimeSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DateTimeSpecJSON  result)
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
    protected virtual void handle_result(List<DateTimeSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DateTimeSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DateTimeSpecJSON>();
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
    public List<DateTimeSpecJSON> value;
  };
  };
