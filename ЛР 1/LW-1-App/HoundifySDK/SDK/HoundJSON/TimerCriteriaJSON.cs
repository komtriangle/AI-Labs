/* file "TimerCriteriaJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class TimerCriteriaJSON : JSONBase
  {
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasPosition;
    private BigInteger storePosition;
    private bool flagHasCenturies;
    private BigInteger storeCenturies;
    private bool flagHasDecades;
    private BigInteger storeDecades;
    private bool flagHasYears;
    private BigInteger storeYears;
    private bool flagHasMonths;
    private BigInteger storeMonths;
    private bool flagHasWeeks;
    private BigInteger storeWeeks;
    private bool flagHasDays;
    private BigInteger storeDays;
    private bool flagHasHours;
    private BigInteger storeHours;
    private bool flagHasMinutes;
    private BigInteger storeMinutes;
    private bool flagHasSeconds;
    private BigInteger storeSeconds;
    private bool flagHasDurationInSeconds;
    private BigInteger storeDurationInSeconds;
    private bool flagHasIsCountdown;
    private bool storeIsCountdown;
    private bool flagHasSecondsToAdd;
    private BigInteger storeSecondsToAdd;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of TimerCriteriaJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONPosition(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Position of TimerCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Position of TimerCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPosition(extracted_integer);
      }


    private void  fromJSONCenturies(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Centuries of TimerCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Centuries of TimerCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCenturies(extracted_integer);
      }


    private void  fromJSONDecades(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Decades of TimerCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Decades of TimerCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDecades(extracted_integer);
      }


    private void  fromJSONYears(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Years of TimerCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Years of TimerCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setYears(extracted_integer);
      }


    private void  fromJSONMonths(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Months of TimerCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Months of TimerCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMonths(extracted_integer);
      }


    private void  fromJSONWeeks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Weeks of TimerCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Weeks of TimerCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setWeeks(extracted_integer);
      }


    private void  fromJSONDays(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Days of TimerCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Days of TimerCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDays(extracted_integer);
      }


    private void  fromJSONHours(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Hours of TimerCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Hours of TimerCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setHours(extracted_integer);
      }


    private void  fromJSONMinutes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Minutes of TimerCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Minutes of TimerCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setMinutes(extracted_integer);
      }


    private void  fromJSONSeconds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Seconds of TimerCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Seconds of TimerCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSeconds(extracted_integer);
      }


    private void  fromJSONDurationInSeconds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DurationInSeconds of TimerCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DurationInSeconds of TimerCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDurationInSeconds(extracted_integer);
      }


    private void  fromJSONIsCountdown(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsCountdown of TimerCriteriaJSON is not true for false.");
              }
          }
        setIsCountdown(the_bool);
      }


    private void  fromJSONSecondsToAdd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SecondsToAdd of TimerCriteriaJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SecondsToAdd of TimerCriteriaJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSecondsToAdd(extracted_integer);
      }


    public TimerCriteriaJSON()
      {
        flagHasTitle = false;
        flagHasPosition = false;
        flagHasCenturies = false;
        flagHasDecades = false;
        flagHasYears = false;
        flagHasMonths = false;
        flagHasWeeks = false;
        flagHasDays = false;
        flagHasHours = false;
        flagHasMinutes = false;
        flagHasSeconds = false;
        flagHasDurationInSeconds = false;
        flagHasIsCountdown = false;
        flagHasSecondsToAdd = false;
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

    public bool  hasPosition()
      {
        return flagHasPosition;
      }

    public BigInteger  getPosition()
      {
        Debug.Assert(flagHasPosition);
        return storePosition;
      }

    public bool  hasCenturies()
      {
        return flagHasCenturies;
      }

    public BigInteger  getCenturies()
      {
        Debug.Assert(flagHasCenturies);
        return storeCenturies;
      }

    public bool  hasDecades()
      {
        return flagHasDecades;
      }

    public BigInteger  getDecades()
      {
        Debug.Assert(flagHasDecades);
        return storeDecades;
      }

    public bool  hasYears()
      {
        return flagHasYears;
      }

    public BigInteger  getYears()
      {
        Debug.Assert(flagHasYears);
        return storeYears;
      }

    public bool  hasMonths()
      {
        return flagHasMonths;
      }

    public BigInteger  getMonths()
      {
        Debug.Assert(flagHasMonths);
        return storeMonths;
      }

    public bool  hasWeeks()
      {
        return flagHasWeeks;
      }

    public BigInteger  getWeeks()
      {
        Debug.Assert(flagHasWeeks);
        return storeWeeks;
      }

    public bool  hasDays()
      {
        return flagHasDays;
      }

    public BigInteger  getDays()
      {
        Debug.Assert(flagHasDays);
        return storeDays;
      }

    public bool  hasHours()
      {
        return flagHasHours;
      }

    public BigInteger  getHours()
      {
        Debug.Assert(flagHasHours);
        return storeHours;
      }

    public bool  hasMinutes()
      {
        return flagHasMinutes;
      }

    public BigInteger  getMinutes()
      {
        Debug.Assert(flagHasMinutes);
        return storeMinutes;
      }

    public bool  hasSeconds()
      {
        return flagHasSeconds;
      }

    public BigInteger  getSeconds()
      {
        Debug.Assert(flagHasSeconds);
        return storeSeconds;
      }

    public bool  hasDurationInSeconds()
      {
        return flagHasDurationInSeconds;
      }

    public BigInteger  getDurationInSeconds()
      {
        Debug.Assert(flagHasDurationInSeconds);
        return storeDurationInSeconds;
      }

    public bool  hasIsCountdown()
      {
        return flagHasIsCountdown;
      }

    public bool  getIsCountdown()
      {
        Debug.Assert(flagHasIsCountdown);
        return storeIsCountdown;
      }

    public bool  hasSecondsToAdd()
      {
        return flagHasSecondsToAdd;
      }

    public BigInteger  getSecondsToAdd()
      {
        Debug.Assert(flagHasSecondsToAdd);
        return storeSecondsToAdd;
      }


    public virtual int extraTimerCriteriaComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTimerCriteriaComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTimerCriteriaComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTimerCriteriaLookup(string field_name)
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
    public void setPosition(BigInteger new_value)
      {
        flagHasPosition = true;
        if (new_value < 1)
            throw new Exception("The value for field Position of TimerCriteriaJSON is less than the lower bound (1) for that field.");
        storePosition = new_value;
      }
    public void unsetPosition()
      {
        flagHasPosition = false;
      }
    public void setCenturies(BigInteger new_value)
      {
        flagHasCenturies = true;
        storeCenturies = new_value;
      }
    public void unsetCenturies()
      {
        flagHasCenturies = false;
      }
    public void setDecades(BigInteger new_value)
      {
        flagHasDecades = true;
        storeDecades = new_value;
      }
    public void unsetDecades()
      {
        flagHasDecades = false;
      }
    public void setYears(BigInteger new_value)
      {
        flagHasYears = true;
        storeYears = new_value;
      }
    public void unsetYears()
      {
        flagHasYears = false;
      }
    public void setMonths(BigInteger new_value)
      {
        flagHasMonths = true;
        storeMonths = new_value;
      }
    public void unsetMonths()
      {
        flagHasMonths = false;
      }
    public void setWeeks(BigInteger new_value)
      {
        flagHasWeeks = true;
        storeWeeks = new_value;
      }
    public void unsetWeeks()
      {
        flagHasWeeks = false;
      }
    public void setDays(BigInteger new_value)
      {
        flagHasDays = true;
        storeDays = new_value;
      }
    public void unsetDays()
      {
        flagHasDays = false;
      }
    public void setHours(BigInteger new_value)
      {
        flagHasHours = true;
        storeHours = new_value;
      }
    public void unsetHours()
      {
        flagHasHours = false;
      }
    public void setMinutes(BigInteger new_value)
      {
        flagHasMinutes = true;
        storeMinutes = new_value;
      }
    public void unsetMinutes()
      {
        flagHasMinutes = false;
      }
    public void setSeconds(BigInteger new_value)
      {
        flagHasSeconds = true;
        storeSeconds = new_value;
      }
    public void unsetSeconds()
      {
        flagHasSeconds = false;
      }
    public void setDurationInSeconds(BigInteger new_value)
      {
        flagHasDurationInSeconds = true;
        storeDurationInSeconds = new_value;
      }
    public void unsetDurationInSeconds()
      {
        flagHasDurationInSeconds = false;
      }
    public void setIsCountdown(bool new_value)
      {
        flagHasIsCountdown = true;
        storeIsCountdown = new_value;
      }
    public void unsetIsCountdown()
      {
        flagHasIsCountdown = false;
      }
    public void setSecondsToAdd(BigInteger new_value)
      {
        flagHasSecondsToAdd = true;
        storeSecondsToAdd = new_value;
      }
    public void unsetSecondsToAdd()
      {
        flagHasSecondsToAdd = false;
      }

    public virtual void extraTimerCriteriaAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTimerCriteriaSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTimerCriteriaLookup(key);
        if (old_field == null)
          {
            extraTimerCriteriaAppendPair(key, new_component);
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
        if (flagHasPosition)
          {
            handler.start_pair("Position");
            handler.number_value(storePosition);
          }
        if (flagHasCenturies)
          {
            handler.start_pair("Centuries");
            handler.number_value(storeCenturies);
          }
        if (flagHasDecades)
          {
            handler.start_pair("Decades");
            handler.number_value(storeDecades);
          }
        if (flagHasYears)
          {
            handler.start_pair("Years");
            handler.number_value(storeYears);
          }
        if (flagHasMonths)
          {
            handler.start_pair("Months");
            handler.number_value(storeMonths);
          }
        if (flagHasWeeks)
          {
            handler.start_pair("Weeks");
            handler.number_value(storeWeeks);
          }
        if (flagHasDays)
          {
            handler.start_pair("Days");
            handler.number_value(storeDays);
          }
        if (flagHasHours)
          {
            handler.start_pair("Hours");
            handler.number_value(storeHours);
          }
        if (flagHasMinutes)
          {
            handler.start_pair("Minutes");
            handler.number_value(storeMinutes);
          }
        if (flagHasSeconds)
          {
            handler.start_pair("Seconds");
            handler.number_value(storeSeconds);
          }
        if (flagHasDurationInSeconds)
          {
            handler.start_pair("DurationInSeconds");
            handler.number_value(storeDurationInSeconds);
          }
        if (flagHasIsCountdown)
          {
            handler.start_pair("IsCountdown");
            handler.boolean_value(storeIsCountdown);
          }
        if (flagHasSecondsToAdd)
          {
            handler.start_pair("SecondsToAdd");
            handler.number_value(storeSecondsToAdd);
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

    public static TimerCriteriaJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimerCriteriaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerCriteria", ignore_extras);
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
    public static TimerCriteriaJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimerCriteriaJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TimerCriteriaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerCriteria", ignore_extras);
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
    public static TimerCriteriaJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TimerCriteriaJSON from_text(string text, bool ignore_extras)
      {
        TimerCriteriaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerCriteria", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TimerCriteriaJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TimerCriteriaJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TimerCriteriaJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TimerCriteria", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorTitle;
    private class FieldHoldingGeneratorPosition : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorPosition(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorPosition : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorPosition(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorPosition fieldGeneratorPosition;
    private class FieldHoldingGeneratorCenturies : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorCenturies(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCenturies : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCenturies(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorCenturies fieldGeneratorCenturies;
    private class FieldHoldingGeneratorDecades : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorDecades(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorDecades : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorDecades(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorDecades fieldGeneratorDecades;
    private class FieldHoldingGeneratorYears : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorYears(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorYears : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorYears(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorYears fieldGeneratorYears;
    private class FieldHoldingGeneratorMonths : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorMonths(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorMonths : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorMonths(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorMonths fieldGeneratorMonths;
    private class FieldHoldingGeneratorWeeks : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorWeeks(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorWeeks : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorWeeks(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorWeeks fieldGeneratorWeeks;
    private class FieldHoldingGeneratorDays : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorDays(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorDays : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorDays(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorDays fieldGeneratorDays;
    private class FieldHoldingGeneratorHours : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorHours(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorHours : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorHours(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorHours fieldGeneratorHours;
    private class FieldHoldingGeneratorMinutes : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorMinutes(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorMinutes : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorMinutes(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorMinutes fieldGeneratorMinutes;
    private class FieldHoldingGeneratorSeconds : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorSeconds(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorSeconds : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorSeconds(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorSeconds fieldGeneratorSeconds;
    private class FieldHoldingGeneratorDurationInSeconds : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorDurationInSeconds(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorDurationInSeconds : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorDurationInSeconds(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorDurationInSeconds fieldGeneratorDurationInSeconds;
        private JSONHoldingBooleanGenerator fieldGeneratorIsCountdown;
    private class FieldHoldingGeneratorSecondsToAdd : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorSecondsToAdd(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorSecondsToAdd : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorSecondsToAdd(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorSecondsToAdd fieldGeneratorSecondsToAdd;
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
            TimerCriteriaJSON result = new TimerCriteriaJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTimerCriteriaAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TimerCriteriaJSON result)
          {
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            if (fieldGeneratorPosition.have_value)
              {
                result.setPosition(fieldGeneratorPosition.value);
                fieldGeneratorPosition.have_value = false;
              }
            if (fieldGeneratorCenturies.have_value)
              {
                result.setCenturies(fieldGeneratorCenturies.value);
                fieldGeneratorCenturies.have_value = false;
              }
            if (fieldGeneratorDecades.have_value)
              {
                result.setDecades(fieldGeneratorDecades.value);
                fieldGeneratorDecades.have_value = false;
              }
            if (fieldGeneratorYears.have_value)
              {
                result.setYears(fieldGeneratorYears.value);
                fieldGeneratorYears.have_value = false;
              }
            if (fieldGeneratorMonths.have_value)
              {
                result.setMonths(fieldGeneratorMonths.value);
                fieldGeneratorMonths.have_value = false;
              }
            if (fieldGeneratorWeeks.have_value)
              {
                result.setWeeks(fieldGeneratorWeeks.value);
                fieldGeneratorWeeks.have_value = false;
              }
            if (fieldGeneratorDays.have_value)
              {
                result.setDays(fieldGeneratorDays.value);
                fieldGeneratorDays.have_value = false;
              }
            if (fieldGeneratorHours.have_value)
              {
                result.setHours(fieldGeneratorHours.value);
                fieldGeneratorHours.have_value = false;
              }
            if (fieldGeneratorMinutes.have_value)
              {
                result.setMinutes(fieldGeneratorMinutes.value);
                fieldGeneratorMinutes.have_value = false;
              }
            if (fieldGeneratorSeconds.have_value)
              {
                result.setSeconds(fieldGeneratorSeconds.value);
                fieldGeneratorSeconds.have_value = false;
              }
            if (fieldGeneratorDurationInSeconds.have_value)
              {
                result.setDurationInSeconds(fieldGeneratorDurationInSeconds.value);
                fieldGeneratorDurationInSeconds.have_value = false;
              }
            if (fieldGeneratorIsCountdown.have_value)
              {
                result.setIsCountdown(fieldGeneratorIsCountdown.value);
                fieldGeneratorIsCountdown.have_value = false;
              }
            if (fieldGeneratorSecondsToAdd.have_value)
              {
                result.setSecondsToAdd(fieldGeneratorSecondsToAdd.value);
                fieldGeneratorSecondsToAdd.have_value = false;
              }
          }
        protected abstract void handle_result(TimerCriteriaJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "enturies", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorCenturies;
                    break;
                case 'D':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ys", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorDays;
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "cades", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorDecades;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "rationInSeconds", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorDurationInSeconds;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "ours", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorHours;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sCountdown", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorIsCountdown;
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "nutes", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorMinutes;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "nths", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorMonths;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "osition", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorPosition;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "econds", 0, 6, false) == 0)
                      {
                        if (field_name.Length == 7)
                          {
                            return fieldGeneratorSeconds;
                          }
                        switch (field_name[7])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 8, "oAdd", 0, 4, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorSecondsToAdd;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTitle;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "eeks", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorWeeks;
                    break;
                case 'Y':
                    if ((String.Compare(field_name, 1, "ears", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorYears;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the TimerCriteria class");
            fieldGeneratorPosition = new FieldHoldingGeneratorPosition("field \"Position\" of the TimerCriteria class");
            fieldGeneratorCenturies = new FieldHoldingGeneratorCenturies("field \"Centuries\" of the TimerCriteria class");
            fieldGeneratorDecades = new FieldHoldingGeneratorDecades("field \"Decades\" of the TimerCriteria class");
            fieldGeneratorYears = new FieldHoldingGeneratorYears("field \"Years\" of the TimerCriteria class");
            fieldGeneratorMonths = new FieldHoldingGeneratorMonths("field \"Months\" of the TimerCriteria class");
            fieldGeneratorWeeks = new FieldHoldingGeneratorWeeks("field \"Weeks\" of the TimerCriteria class");
            fieldGeneratorDays = new FieldHoldingGeneratorDays("field \"Days\" of the TimerCriteria class");
            fieldGeneratorHours = new FieldHoldingGeneratorHours("field \"Hours\" of the TimerCriteria class");
            fieldGeneratorMinutes = new FieldHoldingGeneratorMinutes("field \"Minutes\" of the TimerCriteria class");
            fieldGeneratorSeconds = new FieldHoldingGeneratorSeconds("field \"Seconds\" of the TimerCriteria class");
            fieldGeneratorDurationInSeconds = new FieldHoldingGeneratorDurationInSeconds("field \"DurationInSeconds\" of the TimerCriteria class");
            fieldGeneratorIsCountdown = new JSONHoldingBooleanGenerator("field \"IsCountdown\" of the TimerCriteria class");
            fieldGeneratorSecondsToAdd = new FieldHoldingGeneratorSecondsToAdd("field \"SecondsToAdd\" of the TimerCriteria class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TimerCriteria class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the TimerCriteria class");
            fieldGeneratorPosition = new FieldHoldingGeneratorPosition("field \"Position\" of the TimerCriteria class");
            fieldGeneratorCenturies = new FieldHoldingGeneratorCenturies("field \"Centuries\" of the TimerCriteria class");
            fieldGeneratorDecades = new FieldHoldingGeneratorDecades("field \"Decades\" of the TimerCriteria class");
            fieldGeneratorYears = new FieldHoldingGeneratorYears("field \"Years\" of the TimerCriteria class");
            fieldGeneratorMonths = new FieldHoldingGeneratorMonths("field \"Months\" of the TimerCriteria class");
            fieldGeneratorWeeks = new FieldHoldingGeneratorWeeks("field \"Weeks\" of the TimerCriteria class");
            fieldGeneratorDays = new FieldHoldingGeneratorDays("field \"Days\" of the TimerCriteria class");
            fieldGeneratorHours = new FieldHoldingGeneratorHours("field \"Hours\" of the TimerCriteria class");
            fieldGeneratorMinutes = new FieldHoldingGeneratorMinutes("field \"Minutes\" of the TimerCriteria class");
            fieldGeneratorSeconds = new FieldHoldingGeneratorSeconds("field \"Seconds\" of the TimerCriteria class");
            fieldGeneratorDurationInSeconds = new FieldHoldingGeneratorDurationInSeconds("field \"DurationInSeconds\" of the TimerCriteria class");
            fieldGeneratorIsCountdown = new JSONHoldingBooleanGenerator("field \"IsCountdown\" of the TimerCriteria class");
            fieldGeneratorSecondsToAdd = new FieldHoldingGeneratorSecondsToAdd("field \"SecondsToAdd\" of the TimerCriteria class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TimerCriteria class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTitle.reset();
            fieldGeneratorPosition.reset();
            fieldGeneratorCenturies.reset();
            fieldGeneratorDecades.reset();
            fieldGeneratorYears.reset();
            fieldGeneratorMonths.reset();
            fieldGeneratorWeeks.reset();
            fieldGeneratorDays.reset();
            fieldGeneratorHours.reset();
            fieldGeneratorMinutes.reset();
            fieldGeneratorSeconds.reset();
            fieldGeneratorDurationInSeconds.reset();
            fieldGeneratorIsCountdown.reset();
            fieldGeneratorSecondsToAdd.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TimerCriteriaJSON  result)
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
        public TimerCriteriaJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TimerCriteriaJSON  result)
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
    protected virtual void handle_result(List<TimerCriteriaJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TimerCriteriaJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TimerCriteriaJSON>();
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
    public List<TimerCriteriaJSON> value;
  };
  };
