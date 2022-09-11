/* file "MonthLengthLookupInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MonthLengthLookupInformationNuggetJSON : DateAndTimeInformationNuggetJSON
  {
    private bool flagHasMonthIndex;
    private sbyte storeMonthIndex;
    private bool flagHasMonthName;
    private string storeMonthName;
    private bool flagHasYear;
    private BigInteger storeYear;
    private bool flagHasDaysInMonth;
    private sbyte storeDaysInMonth;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraMonthIndexToJSON()
      {
        JSONIntegerValue generated_integer_MonthIndex = new JSONIntegerValue(storeMonthIndex);
        return generated_integer_MonthIndex;
      }

    private JSONValue  extraMonthNameToJSON()
      {
        JSONStringValue generated_string_MonthName = new JSONStringValue(storeMonthName);
        return generated_string_MonthName;
      }

    private JSONValue  extraYearToJSON()
      {
        JSONIntegerValue generated_integer_Year = new JSONIntegerValue(storeYear);
        return generated_integer_Year;
      }

    private JSONValue  extraDaysInMonthToJSON()
      {
        JSONIntegerValue generated_integer_DaysInMonth = new JSONIntegerValue(storeDaysInMonth);
        return generated_integer_DaysInMonth;
      }


    private void  fromJSONMonthIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field MonthIndex of MonthLengthLookupInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field MonthIndex of MonthLengthLookupInformationNuggetJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setMonthIndex(extracted_integer);
      }


    private void  fromJSONMonthName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MonthName of MonthLengthLookupInformationNuggetJSON is not a string.");
        setMonthName(json_string.getData());
      }


    private void  fromJSONYear(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Year of MonthLengthLookupInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Year of MonthLengthLookupInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setYear(extracted_integer);
      }


    private void  fromJSONDaysInMonth(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DaysInMonth of MonthLengthLookupInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DaysInMonth of MonthLengthLookupInformationNuggetJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setDaysInMonth(extracted_integer);
      }


    public MonthLengthLookupInformationNuggetJSON()
      {
        flagHasMonthIndex = false;
        flagHasMonthName = false;
        flagHasYear = false;
        flagHasDaysInMonth = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDateAndTimeNuggetKind()
      {
        return "MonthLengthLookup";
      }

    public bool  hasMonthIndex()
      {
        return flagHasMonthIndex;
      }

    public sbyte  getMonthIndex()
      {
        Debug.Assert(flagHasMonthIndex);
        return storeMonthIndex;
      }

    public bool  hasMonthName()
      {
        return flagHasMonthName;
      }

    public string  getMonthName()
      {
        Debug.Assert(flagHasMonthName);
        return storeMonthName;
      }

    public bool  hasYear()
      {
        return flagHasYear;
      }

    public BigInteger  getYear()
      {
        Debug.Assert(flagHasYear);
        return storeYear;
      }

    public bool  hasDaysInMonth()
      {
        return flagHasDaysInMonth;
      }

    public sbyte  getDaysInMonth()
      {
        Debug.Assert(flagHasDaysInMonth);
        return storeDaysInMonth;
      }


    public virtual int extraMonthLengthLookupInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMonthLengthLookupInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMonthLengthLookupInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMonthLengthLookupInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDateAndTimeInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasMonthIndex)
            ++result;
        if (flagHasMonthName)
            ++result;
        if (flagHasYear)
            ++result;
        if (flagHasDaysInMonth)
            ++result;
        result += extraMonthLengthLookupInformationNuggetComponentCount();
        return result;
      }
    public override string extraDateAndTimeInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasMonthIndex)
          {
            if (remainder == 0)
                return "MonthIndex";
            --remainder;
          }
        if (flagHasMonthName)
          {
            if (remainder == 0)
                return "MonthName";
            --remainder;
          }
        if (flagHasYear)
          {
            if (remainder == 0)
                return "Year";
            --remainder;
          }
        if (flagHasDaysInMonth)
          {
            if (remainder == 0)
                return "DaysInMonth";
            --remainder;
          }
        return extraMonthLengthLookupInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasMonthIndex)
          {
            if (remainder == 0)
                return extraMonthIndexToJSON();
            --remainder;
          }
        if (flagHasMonthName)
          {
            if (remainder == 0)
                return extraMonthNameToJSON();
            --remainder;
          }
        if (flagHasYear)
          {
            if (remainder == 0)
                return extraYearToJSON();
            --remainder;
          }
        if (flagHasDaysInMonth)
          {
            if (remainder == 0)
                return extraDaysInMonthToJSON();
            --remainder;
          }
        return extraMonthLengthLookupInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "aysInMonth", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasDaysInMonth ? extraDaysInMonthToJSON() : null);
                break;
            case 'M':
                if (String.Compare(field_name, 1, "onth", 0, 4, false) == 0)
                  {
                    switch (field_name[5])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 6, "ndex", 0, 4, false) == 0) && (field_name.Length == 10))
                                return (flagHasMonthIndex ? extraMonthIndexToJSON() : null);
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 6, "ame", 0, 3, false) == 0) && (field_name.Length == 9))
                                return (flagHasMonthName ? extraMonthNameToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Y':
                if ((String.Compare(field_name, 1, "ear", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasYear ? extraYearToJSON() : null);
                break;
            default:
                break;
          }
        return extraMonthLengthLookupInformationNuggetLookup(field_name);
      }

    public void setMonthIndex(sbyte new_value)
      {
        flagHasMonthIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field MonthIndex of MonthLengthLookupInformationNuggetJSON is less than the lower bound (0) for that field.");
        if (new_value > 11)
            throw new Exception("The value for field MonthIndex of MonthLengthLookupInformationNuggetJSON is greater than the upper bound (11) for that field.");
        storeMonthIndex = new_value;
      }
    public void unsetMonthIndex()
      {
        flagHasMonthIndex = false;
      }
    public void setMonthName(string new_value)
      {
        flagHasMonthName = true;
        storeMonthName = new_value;
      }
    public void unsetMonthName()
      {
        flagHasMonthName = false;
      }
    public void setYear(BigInteger new_value)
      {
        flagHasYear = true;
        storeYear = new_value;
      }
    public void unsetYear()
      {
        flagHasYear = false;
      }
    public void setDaysInMonth(sbyte new_value)
      {
        flagHasDaysInMonth = true;
        if (new_value < 28)
            throw new Exception("The value for field DaysInMonth of MonthLengthLookupInformationNuggetJSON is less than the lower bound (28) for that field.");
        if (new_value > 31)
            throw new Exception("The value for field DaysInMonth of MonthLengthLookupInformationNuggetJSON is greater than the upper bound (31) for that field.");
        storeDaysInMonth = new_value;
      }
    public void unsetDaysInMonth()
      {
        flagHasDaysInMonth = false;
      }

    public virtual void extraMonthLengthLookupInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMonthLengthLookupInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMonthLengthLookupInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraMonthLengthLookupInformationNuggetAppendPair(key, new_component);
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
                if ((String.Compare(key, 1, "aysInMonth", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONDaysInMonth(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if (String.Compare(key, 1, "onth", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'I':
                            if ((String.Compare(key, 6, "ndex", 0, 4, false) == 0) && (key.Length == 10))
                                {
                                fromJSONMonthIndex(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 6, "ame", 0, 3, false) == 0) && (key.Length == 9))
                                {
                                fromJSONMonthName(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Y':
                if ((String.Compare(key, 1, "ear", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONYear(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMonthLengthLookupInformationNuggetAppendPair(key, new_component);
      }
    public override void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "aysInMonth", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONDaysInMonth(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if (String.Compare(key, 1, "onth", 0, 4, false) == 0)
                  {
                    switch (key[5])
                      {
                        case 'I':
                            if ((String.Compare(key, 6, "ndex", 0, 4, false) == 0) && (key.Length == 10))
                                {
                                fromJSONMonthIndex(new_component, false);
                                return;
                                }
                            break;
                        case 'N':
                            if ((String.Compare(key, 6, "ame", 0, 3, false) == 0) && (key.Length == 9))
                                {
                                fromJSONMonthName(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'Y':
                if ((String.Compare(key, 1, "ear", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONYear(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMonthLengthLookupInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasMonthIndex);
        if (flagHasMonthIndex)
          {
            handler.start_pair("MonthIndex");
            handler.number_value(storeMonthIndex);
          }
        Debug.Assert(partial_allowed || flagHasMonthName);
        if (flagHasMonthName)
          {
            handler.start_pair("MonthName");
            handler.string_value(storeMonthName);
          }
        if (flagHasYear)
          {
            handler.start_pair("Year");
            handler.number_value(storeYear);
          }
        Debug.Assert(partial_allowed || flagHasDaysInMonth);
        if (flagHasDaysInMonth)
          {
            handler.start_pair("DaysInMonth");
            handler.number_value(storeDaysInMonth);
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
        if (!(hasMonthIndex()))
          {
            return "When parsing the object for %what%, the \"MonthIndex\" field was missing.";
          }
        if (!(hasMonthName()))
          {
            return "When parsing the object for %what%, the \"MonthName\" field was missing.";
          }
        if (!(hasDaysInMonth()))
          {
            return "When parsing the object for %what%, the \"DaysInMonth\" field was missing.";
          }
        return null;
      }

    public static new MonthLengthLookupInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MonthLengthLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonthLengthLookupInformationNugget", ignore_extras);
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
    public static new MonthLengthLookupInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MonthLengthLookupInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MonthLengthLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonthLengthLookupInformationNugget", ignore_extras);
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
    public static new MonthLengthLookupInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MonthLengthLookupInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        MonthLengthLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonthLengthLookupInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MonthLengthLookupInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MonthLengthLookupInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MonthLengthLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MonthLengthLookupInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DateAndTimeInformationNuggetJSON.Generator
      {
    private class FieldHoldingGeneratorMonthIndex : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorMonthIndex(String what) : base(what, 0, 11)
              {
              }
          };
    private class FieldHoldingArrayGeneratorMonthIndex : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorMonthIndex(String what) : base(what, 0, 11)
              {
              }
          };
        private FieldHoldingGeneratorMonthIndex fieldGeneratorMonthIndex;
        private JSONHoldingStringGenerator fieldGeneratorMonthName;
    private class FieldHoldingGeneratorYear : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorYear(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorYear : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorYear(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorYear fieldGeneratorYear;
    private class FieldHoldingGeneratorDaysInMonth : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorDaysInMonth(String what) : base(what, 28, 31)
              {
              }
          };
    private class FieldHoldingArrayGeneratorDaysInMonth : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorDaysInMonth(String what) : base(what, 28, 31)
              {
              }
          };
        private FieldHoldingGeneratorDaysInMonth fieldGeneratorDaysInMonth;
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
            if (!(getDateAndTimeInformationNuggetJSONKey().Equals("MonthLengthLookup")))
                throw new Exception("The key field has a value other than `MonthLengthLookup'.");
            MonthLengthLookupInformationNuggetJSON result = new MonthLengthLookupInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMonthLengthLookupInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DateAndTimeInformationNuggetJSON new_result)
          {
            handle_result((MonthLengthLookupInformationNuggetJSON )new_result);
          }
        protected void finish(MonthLengthLookupInformationNuggetJSON result)
          {
            if (fieldGeneratorMonthIndex.have_value)
              {
                result.setMonthIndex((sbyte)(fieldGeneratorMonthIndex.value));
                fieldGeneratorMonthIndex.have_value = false;
              }
            else if ((!(result.hasMonthIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MonthIndex\" field was missing.");
              }
            if (fieldGeneratorMonthName.have_value)
              {
                result.setMonthName(fieldGeneratorMonthName.value);
                fieldGeneratorMonthName.have_value = false;
              }
            else if ((!(result.hasMonthName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MonthName\" field was missing.");
              }
            if (fieldGeneratorYear.have_value)
              {
                result.setYear(fieldGeneratorYear.value);
                fieldGeneratorYear.have_value = false;
              }
            if (fieldGeneratorDaysInMonth.have_value)
              {
                result.setDaysInMonth((sbyte)(fieldGeneratorDaysInMonth.value));
                fieldGeneratorDaysInMonth.have_value = false;
              }
            else if ((!(result.hasDaysInMonth())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DaysInMonth\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(MonthLengthLookupInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "aysInMonth", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDaysInMonth;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "onth", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 6, "ndex", 0, 4, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorMonthIndex;
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 6, "ame", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorMonthName;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'Y':
                    if ((String.Compare(field_name, 1, "ear", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorYear;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorMonthIndex = new FieldHoldingGeneratorMonthIndex("field \"MonthIndex\" of the MonthLengthLookupInformationNugget class");
            fieldGeneratorMonthName = new JSONHoldingStringGenerator("field \"MonthName\" of the MonthLengthLookupInformationNugget class");
            fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the MonthLengthLookupInformationNugget class");
            fieldGeneratorDaysInMonth = new FieldHoldingGeneratorDaysInMonth("field \"DaysInMonth\" of the MonthLengthLookupInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MonthLengthLookupInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorMonthIndex = new FieldHoldingGeneratorMonthIndex("field \"MonthIndex\" of the MonthLengthLookupInformationNugget class");
            fieldGeneratorMonthName = new JSONHoldingStringGenerator("field \"MonthName\" of the MonthLengthLookupInformationNugget class");
            fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the MonthLengthLookupInformationNugget class");
            fieldGeneratorDaysInMonth = new FieldHoldingGeneratorDaysInMonth("field \"DaysInMonth\" of the MonthLengthLookupInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MonthLengthLookupInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorMonthIndex.reset();
            fieldGeneratorMonthName.reset();
            fieldGeneratorYear.reset();
            fieldGeneratorDaysInMonth.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MonthLengthLookupInformationNuggetJSON  result)
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
        public MonthLengthLookupInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MonthLengthLookupInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<MonthLengthLookupInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MonthLengthLookupInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MonthLengthLookupInformationNuggetJSON>();
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
    public List<MonthLengthLookupInformationNuggetJSON> value;
  };
  };
