/* file "ClockTimeOfDayJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ClockTimeOfDayJSON : TimeOfDayJSON
  {
    private bool flagHasHour;
    private sbyte storeHour;
    private bool flagHasMinute;
    private sbyte storeMinute;
    private bool flagHasSecond;
    private double storeSecond;
    private string textStoreSecond;
    private bool flagHasAmPmUnknown;
    private bool storeAmPmUnknown;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraHourToJSON()
      {
        JSONIntegerValue generated_integer_Hour = new JSONIntegerValue(storeHour);
        return generated_integer_Hour;
      }

    private JSONValue  extraMinuteToJSON()
      {
        JSONIntegerValue generated_integer_Minute = new JSONIntegerValue(storeMinute);
        return generated_integer_Minute;
      }

    private JSONValue  extraSecondToJSON()
      {
        JSONValue generated_rational_Second;
        if (textStoreSecond != "")
          {
            JSONValueHandler handler = new JSONValueHandler();
            handler.number_value(textStoreSecond);
            generated_rational_Second = handler.result;
          }
        else if (((double)(long)storeSecond) == storeSecond)
            generated_rational_Second = new JSONIntegerValue((long)(storeSecond));
        else
            generated_rational_Second = new JSONRationalValue(storeSecond, 15);
        return generated_rational_Second;
      }

    private JSONValue  extraAmPmUnknownToJSON()
      {
        JSONValue generated_boolean_AmPmUnknown = (storeAmPmUnknown ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_AmPmUnknown;
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
                throw new Exception("The value for field Hour of ClockTimeOfDayJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Hour of ClockTimeOfDayJSON is not an integer.");
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
                throw new Exception("The value for field Minute of ClockTimeOfDayJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Minute of ClockTimeOfDayJSON is not an integer.");
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
                throw new Exception("The value for field Second of ClockTimeOfDayJSON is not a number.");
              }
          }
        setSecondText(the_rational_text);
      }


    private void  fromJSONAmPmUnknown(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AmPmUnknown of ClockTimeOfDayJSON is not true for false.");
              }
          }
        setAmPmUnknown(the_bool);
      }


    public ClockTimeOfDayJSON()
      {
        flagHasHour = false;
        flagHasMinute = false;
        flagHasSecond = false;
        flagHasAmPmUnknown = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getTimeOfDayKind()
      {
        return "ClockTimeOfDay";
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

    public double  getSecond()
      {
        Debug.Assert(flagHasSecond);
        if (textStoreSecond != "")
          {
            return Double.Parse(textStoreSecond);
          }
        return storeSecond;
      }

    public string  getSecondAsText()
      {
        Debug.Assert(flagHasSecond);
        if (textStoreSecond == "")
          {
            return Convert.ToString(storeSecond);
          }
        else
          {
            return (textStoreSecond);
          }
      }

    public bool  hasAmPmUnknown()
      {
        return flagHasAmPmUnknown;
      }

    public bool  getAmPmUnknown()
      {
        Debug.Assert(flagHasAmPmUnknown);
        return storeAmPmUnknown;
      }


    public virtual int extraClockTimeOfDayComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraClockTimeOfDayComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraClockTimeOfDayComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraClockTimeOfDayLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraTimeOfDayComponentCount()
      {
        int result = 0;
        if (flagHasHour)
            ++result;
        if (flagHasMinute)
            ++result;
        if (flagHasSecond)
            ++result;
        if (flagHasAmPmUnknown)
            ++result;
        result += extraClockTimeOfDayComponentCount();
        return result;
      }
    public override string extraTimeOfDayComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasHour)
          {
            if (remainder == 0)
                return "Hour";
            --remainder;
          }
        if (flagHasMinute)
          {
            if (remainder == 0)
                return "Minute";
            --remainder;
          }
        if (flagHasSecond)
          {
            if (remainder == 0)
                return "Second";
            --remainder;
          }
        if (flagHasAmPmUnknown)
          {
            if (remainder == 0)
                return "AmPmUnknown";
            --remainder;
          }
        return extraClockTimeOfDayComponentKey(remainder);
      }
    public override JSONValue extraTimeOfDayComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasHour)
          {
            if (remainder == 0)
                return extraHourToJSON();
            --remainder;
          }
        if (flagHasMinute)
          {
            if (remainder == 0)
                return extraMinuteToJSON();
            --remainder;
          }
        if (flagHasSecond)
          {
            if (remainder == 0)
                return extraSecondToJSON();
            --remainder;
          }
        if (flagHasAmPmUnknown)
          {
            if (remainder == 0)
                return extraAmPmUnknownToJSON();
            --remainder;
          }
        return extraClockTimeOfDayComponentValue(remainder);
      }
    public override JSONValue extraTimeOfDayLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "mPmUnknown", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasAmPmUnknown ? extraAmPmUnknownToJSON() : null);
                break;
            case 'H':
                if ((String.Compare(field_name, 1, "our", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasHour ? extraHourToJSON() : null);
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "inute", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasMinute ? extraMinuteToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "econd", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasSecond ? extraSecondToJSON() : null);
                break;
            default:
                break;
          }
        return extraClockTimeOfDayLookup(field_name);
      }

    public void setHour(sbyte new_value)
      {
        flagHasHour = true;
        if (new_value < 0)
            throw new Exception("The value for field Hour of ClockTimeOfDayJSON is less than the lower bound (0) for that field.");
        if (new_value > 23)
            throw new Exception("The value for field Hour of ClockTimeOfDayJSON is greater than the upper bound (23) for that field.");
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
            throw new Exception("The value for field Minute of ClockTimeOfDayJSON is less than the lower bound (0) for that field.");
        if (new_value > 59)
            throw new Exception("The value for field Minute of ClockTimeOfDayJSON is greater than the upper bound (59) for that field.");
        storeMinute = new_value;
      }
    public void unsetMinute()
      {
        flagHasMinute = false;
      }
    public void setSecond(double new_value)
      {
        flagHasSecond = true;
        if (new_value < 0)
            throw new Exception("The value for field Second of ClockTimeOfDayJSON is less than the lower bound (0) for that field.");
        if (new_value > 61)
            throw new Exception("The value for field Second of ClockTimeOfDayJSON is greater than the upper bound (61) for that field.");
        storeSecond = new_value;
        textStoreSecond = "";
      }
    public void setSecondText(string new_value)
      {
        flagHasSecond = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Second of ClockTimeOfDayJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Second of ClockTimeOfDayJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "61", "", false, "2") > 0)
            throw new Exception("The value for field Second of ClockTimeOfDayJSON is greater than the upper bound (61) for that field.");
        textStoreSecond = new_value;
      }
    public void unsetSecond()
      {
        flagHasSecond = false;
      }
    public void setAmPmUnknown(bool new_value)
      {
        flagHasAmPmUnknown = true;
        storeAmPmUnknown = new_value;
      }
    public void unsetAmPmUnknown()
      {
        flagHasAmPmUnknown = false;
      }

    public virtual void extraClockTimeOfDayAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraClockTimeOfDaySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraClockTimeOfDayLookup(key);
        if (old_field == null)
          {
            extraClockTimeOfDayAppendPair(key, new_component);
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
    public override void extraTimeOfDayAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "mPmUnknown", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAmPmUnknown(new_component, false);
                    return;
                    }
                break;
            case 'H':
                if ((String.Compare(key, 1, "our", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONHour(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "inute", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONMinute(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "econd", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONSecond(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraClockTimeOfDayAppendPair(key, new_component);
      }
    public override void extraTimeOfDaySetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "mPmUnknown", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONAmPmUnknown(new_component, false);
                    return;
                    }
                break;
            case 'H':
                if ((String.Compare(key, 1, "our", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONHour(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "inute", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONMinute(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "econd", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONSecond(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraClockTimeOfDaySetField(key, new_component);
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
            if (textStoreSecond != "")
                handler.number_value(textStoreSecond);
            else if (((double)(long)storeSecond) == storeSecond)
                handler.number_value((long)storeSecond);
            else
                handler.number_value(storeSecond);
          }
        Debug.Assert(partial_allowed || flagHasAmPmUnknown);
        if (flagHasAmPmUnknown)
          {
            handler.start_pair("AmPmUnknown");
            handler.boolean_value(storeAmPmUnknown);
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
        if (!(hasAmPmUnknown()))
          {
            return "When parsing the object for %what%, the \"AmPmUnknown\" field was missing.";
          }
        return null;
      }

    public static new ClockTimeOfDayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ClockTimeOfDayJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClockTimeOfDay", ignore_extras);
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
    public static new ClockTimeOfDayJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ClockTimeOfDayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ClockTimeOfDayJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClockTimeOfDay", ignore_extras);
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
    public static new ClockTimeOfDayJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ClockTimeOfDayJSON from_text(string text, bool ignore_extras)
      {
        ClockTimeOfDayJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClockTimeOfDay", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ClockTimeOfDayJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ClockTimeOfDayJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ClockTimeOfDayJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ClockTimeOfDay", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : TimeOfDayJSON.Generator
      {
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
        private JSONHoldingNumberTextGenerator fieldGeneratorSecond;
        private JSONHoldingBooleanGenerator fieldGeneratorAmPmUnknown;
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
            if (!(getTimeOfDayJSONKey().Equals("ClockTimeOfDay")))
                throw new Exception("The key field has a value other than `ClockTimeOfDay'.");
            ClockTimeOfDayJSON result = new ClockTimeOfDayJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraClockTimeOfDayAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(TimeOfDayJSON new_result)
          {
            handle_result((ClockTimeOfDayJSON )new_result);
          }
        protected void finish(ClockTimeOfDayJSON result)
          {
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
                result.setSecondText(fieldGeneratorSecond.value);
                fieldGeneratorSecond.have_value = false;
              }
            else if ((!(result.hasSecond())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Second\" field was missing.");
              }
            if (fieldGeneratorAmPmUnknown.have_value)
              {
                result.setAmPmUnknown(fieldGeneratorAmPmUnknown.value);
                fieldGeneratorAmPmUnknown.have_value = false;
              }
            else if ((!(result.hasAmPmUnknown())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AmPmUnknown\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ClockTimeOfDayJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "mPmUnknown", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorAmPmUnknown;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "our", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorHour;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "inute", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorMinute;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "econd", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorSecond;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorHour = new FieldHoldingGeneratorHour("field \"Hour\" of the ClockTimeOfDay class");
            fieldGeneratorMinute = new FieldHoldingGeneratorMinute("field \"Minute\" of the ClockTimeOfDay class");
            fieldGeneratorSecond = new JSONHoldingNumberTextGenerator("field \"Second\" of the ClockTimeOfDay class");
            fieldGeneratorAmPmUnknown = new JSONHoldingBooleanGenerator("field \"AmPmUnknown\" of the ClockTimeOfDay class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ClockTimeOfDay class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorHour = new FieldHoldingGeneratorHour("field \"Hour\" of the ClockTimeOfDay class");
            fieldGeneratorMinute = new FieldHoldingGeneratorMinute("field \"Minute\" of the ClockTimeOfDay class");
            fieldGeneratorSecond = new JSONHoldingNumberTextGenerator("field \"Second\" of the ClockTimeOfDay class");
            fieldGeneratorAmPmUnknown = new JSONHoldingBooleanGenerator("field \"AmPmUnknown\" of the ClockTimeOfDay class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ClockTimeOfDay class");
          }

        public override void reset()
          {
            fieldGeneratorHour.reset();
            fieldGeneratorMinute.reset();
            fieldGeneratorSecond.reset();
            fieldGeneratorAmPmUnknown.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ClockTimeOfDayJSON  result)
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
        public ClockTimeOfDayJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ClockTimeOfDayJSON  result)
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
    protected virtual void handle_result(List<ClockTimeOfDayJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ClockTimeOfDayJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ClockTimeOfDayJSON>();
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
    public List<ClockTimeOfDayJSON> value;
  };
  };
