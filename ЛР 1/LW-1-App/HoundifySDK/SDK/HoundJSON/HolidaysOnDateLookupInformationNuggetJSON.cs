/* file "HolidaysOnDateLookupInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HolidaysOnDateLookupInformationNuggetJSON : DateAndTimeInformationNuggetJSON
  {
    private bool flagHasDateAndOrTimeSpec;
    private DateAndOrTimeSpecJSON  storeDateAndOrTimeSpec;
    private bool flagHasDateAndOrTimeSpecInFuture;
    private bool storeDateAndOrTimeSpecInFuture;
    private bool flagHasHolidaysData;
    private List< HolidayJSON  > storeHolidaysData;
    private bool flagHasHolidays;
    private List< string > storeHolidays;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraDateAndOrTimeSpecToJSON()
      {
        JSONValueHandler handler_DateAndOrTimeSpec = new JSONValueHandler();
        storeDateAndOrTimeSpec.write_as_json(handler_DateAndOrTimeSpec);
        return handler_DateAndOrTimeSpec.result;
      }

    private JSONValue  extraDateAndOrTimeSpecInFutureToJSON()
      {
        JSONValue generated_boolean_DateAndOrTimeSpecInFuture = (storeDateAndOrTimeSpecInFuture ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DateAndOrTimeSpecInFuture;
      }

    private JSONValue  extraHolidaysDataToJSON()
      {
        JSONArrayValue generated_array_1_HolidaysData = new JSONArrayValue();
        for (int num1 = 0; num1 < storeHolidaysData.Count; ++num1)
          {
            JSONValueHandler handler_HolidaysData = new JSONValueHandler();
            storeHolidaysData[num1].write_as_json(handler_HolidaysData);
            generated_array_1_HolidaysData.appendComponent(handler_HolidaysData.result);
          }
        return generated_array_1_HolidaysData;
      }

    private JSONValue  extraHolidaysToJSON()
      {
        JSONArrayValue generated_array_2_Holidays = new JSONArrayValue();
        for (int num2 = 0; num2 < storeHolidays.Count; ++num2)
          {
            JSONStringValue generated_string_Holidays = new JSONStringValue(storeHolidays[num2]);
            generated_array_2_Holidays.appendComponent(generated_string_Holidays);
          }
        return generated_array_2_Holidays;
      }


    private void  fromJSONDateAndOrTimeSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeSpecJSON convert_classy = DateAndOrTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateAndOrTimeSpec(convert_classy);
      }


    private void  fromJSONDateAndOrTimeSpecInFuture(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DateAndOrTimeSpecInFuture of HolidaysOnDateLookupInformationNuggetJSON is not true for false.");
              }
          }
        setDateAndOrTimeSpecInFuture(the_bool);
      }


    private void  fromJSONHolidaysData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HolidaysData of HolidaysOnDateLookupInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HolidayJSON  > vector_HolidaysData1 = new List< HolidayJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HolidayJSON convert_classy = HolidayJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_HolidaysData1.Add(convert_classy);
          }
        initHolidaysData();
        for (int num1 = 0; num1 < vector_HolidaysData1.Count; ++num1)
            appendHolidaysData(vector_HolidaysData1[num1]);
        for (int num1 = 0; num1 < vector_HolidaysData1.Count; ++num1)
          {
          }
      }


    private void  fromJSONHolidays(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Holidays of HolidaysOnDateLookupInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Holidays1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Holidays of HolidaysOnDateLookupInformationNuggetJSON is not a string.");
            vector_Holidays1.Add(json_string.getData());
          }
        initHolidays();
        for (int num2 = 0; num2 < vector_Holidays1.Count; ++num2)
            appendHolidays(vector_Holidays1[num2]);
        for (int num1 = 0; num1 < vector_Holidays1.Count; ++num1)
          {
          }
      }


    public HolidaysOnDateLookupInformationNuggetJSON()
      {
        flagHasDateAndOrTimeSpec = false;
        flagHasDateAndOrTimeSpecInFuture = false;
        flagHasHolidaysData = false;
        flagHasHolidays = false;
        storeHolidaysData = new List< HolidayJSON  >();
        storeHolidays = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getDateAndTimeNuggetKind()
      {
        return "HolidaysOnDateLookup";
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

    public bool  hasDateAndOrTimeSpecInFuture()
      {
        return flagHasDateAndOrTimeSpecInFuture;
      }

    public bool  getDateAndOrTimeSpecInFuture()
      {
        Debug.Assert(flagHasDateAndOrTimeSpecInFuture);
        return storeDateAndOrTimeSpecInFuture;
      }

    public bool  hasHolidaysData()
      {
        return flagHasHolidaysData;
      }

    public int  countOfHolidaysData()
      {
        Debug.Assert(flagHasHolidaysData);
        return storeHolidaysData.Count;
      }

    public HolidayJSON   elementOfHolidaysData(int element_num)
      {
        Debug.Assert(flagHasHolidaysData);
        return storeHolidaysData[element_num];
      }

    public List< HolidayJSON  >  getHolidaysData()
      {
        Debug.Assert(flagHasHolidaysData);
        return storeHolidaysData;
      }

    public bool  hasHolidays()
      {
        return flagHasHolidays;
      }

    public int  countOfHolidays()
      {
        Debug.Assert(flagHasHolidays);
        return storeHolidays.Count;
      }

    public string  elementOfHolidays(int element_num)
      {
        Debug.Assert(flagHasHolidays);
        return storeHolidays[element_num];
      }

    public List< string >  getHolidays()
      {
        Debug.Assert(flagHasHolidays);
        return storeHolidays;
      }


    public virtual int extraHolidaysOnDateLookupInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHolidaysOnDateLookupInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHolidaysOnDateLookupInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHolidaysOnDateLookupInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDateAndTimeInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasDateAndOrTimeSpec)
            ++result;
        if (flagHasDateAndOrTimeSpecInFuture)
            ++result;
        if (flagHasHolidaysData)
            ++result;
        if (flagHasHolidays)
            ++result;
        result += extraHolidaysOnDateLookupInformationNuggetComponentCount();
        return result;
      }
    public override string extraDateAndTimeInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasDateAndOrTimeSpec)
          {
            if (remainder == 0)
                return "DateAndOrTimeSpec";
            --remainder;
          }
        if (flagHasDateAndOrTimeSpecInFuture)
          {
            if (remainder == 0)
                return "DateAndOrTimeSpecInFuture";
            --remainder;
          }
        if (flagHasHolidaysData)
          {
            if (remainder == 0)
                return "HolidaysData";
            --remainder;
          }
        if (flagHasHolidays)
          {
            if (remainder == 0)
                return "Holidays";
            --remainder;
          }
        return extraHolidaysOnDateLookupInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasDateAndOrTimeSpec)
          {
            if (remainder == 0)
                return extraDateAndOrTimeSpecToJSON();
            --remainder;
          }
        if (flagHasDateAndOrTimeSpecInFuture)
          {
            if (remainder == 0)
                return extraDateAndOrTimeSpecInFutureToJSON();
            --remainder;
          }
        if (flagHasHolidaysData)
          {
            if (remainder == 0)
                return extraHolidaysDataToJSON();
            --remainder;
          }
        if (flagHasHolidays)
          {
            if (remainder == 0)
                return extraHolidaysToJSON();
            --remainder;
          }
        return extraHolidaysOnDateLookupInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraDateAndTimeInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if (String.Compare(field_name, 1, "ateAndOrTimeSpec", 0, 16, false) == 0)
                  {
                    if (field_name.Length == 17)
                      {
                        return (flagHasDateAndOrTimeSpec ? extraDateAndOrTimeSpecToJSON() : null);
                      }
                    switch (field_name[17])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 18, "nFuture", 0, 7, false) == 0) && (field_name.Length == 25))
                                return (flagHasDateAndOrTimeSpecInFuture ? extraDateAndOrTimeSpecInFutureToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if (String.Compare(field_name, 1, "olidays", 0, 7, false) == 0)
                  {
                    if (field_name.Length == 8)
                      {
                        return (flagHasHolidays ? extraHolidaysToJSON() : null);
                      }
                    switch (field_name[8])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 9, "ata", 0, 3, false) == 0) && (field_name.Length == 12))
                                return (flagHasHolidaysData ? extraHolidaysDataToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraHolidaysOnDateLookupInformationNuggetLookup(field_name);
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
    public void setDateAndOrTimeSpecInFuture(bool new_value)
      {
        flagHasDateAndOrTimeSpecInFuture = true;
        storeDateAndOrTimeSpecInFuture = new_value;
      }
    public void unsetDateAndOrTimeSpecInFuture()
      {
        flagHasDateAndOrTimeSpecInFuture = false;
      }
    public void initHolidaysData()
      {
        if (flagHasHolidaysData)
          {
            for (int num1 = 0; num1 < storeHolidaysData.Count; ++num1)
              {
              }
          }
        flagHasHolidaysData = true;
        storeHolidaysData.Clear();
      }
    public void appendHolidaysData(HolidayJSON  to_append)
      {
        if (!flagHasHolidaysData)
          {
            flagHasHolidaysData = true;
            storeHolidaysData.Clear();
          }
        Debug.Assert(flagHasHolidaysData);
        storeHolidaysData.Add(to_append);
      }
    public void appendHolidaysData(HolidayJSON.TypeValue new_value)
      {
        appendHolidaysData(new HolidayJSON(new_value));
      }
    public void appendHolidaysData(string chars)
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
        appendHolidaysData(new_value);
      }
    public void unsetHolidaysData()
      {
        if (flagHasHolidaysData)
          {
            for (int num2 = 0; num2 < storeHolidaysData.Count; ++num2)
              {
              }
          }
        flagHasHolidaysData = false;
        storeHolidaysData.Clear();
      }
    public void initHolidays()
      {
        flagHasHolidays = true;
        storeHolidays.Clear();
      }
    public void appendHolidays(string to_append)
      {
        if (!flagHasHolidays)
          {
            flagHasHolidays = true;
            storeHolidays.Clear();
          }
        Debug.Assert(flagHasHolidays);
        storeHolidays.Add(to_append);
      }
    public void unsetHolidays()
      {
        flagHasHolidays = false;
        storeHolidays.Clear();
      }

    public virtual void extraHolidaysOnDateLookupInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHolidaysOnDateLookupInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHolidaysOnDateLookupInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraHolidaysOnDateLookupInformationNuggetAppendPair(key, new_component);
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
                if (String.Compare(key, 1, "ateAndOrTimeSpec", 0, 16, false) == 0)
                  {
                    if (key.Length == 17)
                      {
                        {
                        fromJSONDateAndOrTimeSpec(new_component, false);
                        return;
                        }
                      }
                    switch (key[17])
                      {
                        case 'I':
                            if ((String.Compare(key, 18, "nFuture", 0, 7, false) == 0) && (key.Length == 25))
                                {
                                fromJSONDateAndOrTimeSpecInFuture(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if (String.Compare(key, 1, "olidays", 0, 7, false) == 0)
                  {
                    if (key.Length == 8)
                      {
                        {
                        fromJSONHolidays(new_component, false);
                        return;
                        }
                      }
                    switch (key[8])
                      {
                        case 'D':
                            if ((String.Compare(key, 9, "ata", 0, 3, false) == 0) && (key.Length == 12))
                                {
                                fromJSONHolidaysData(new_component, false);
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
        extraHolidaysOnDateLookupInformationNuggetAppendPair(key, new_component);
      }
    public override void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if (String.Compare(key, 1, "ateAndOrTimeSpec", 0, 16, false) == 0)
                  {
                    if (key.Length == 17)
                      {
                        {
                        fromJSONDateAndOrTimeSpec(new_component, false);
                        return;
                        }
                      }
                    switch (key[17])
                      {
                        case 'I':
                            if ((String.Compare(key, 18, "nFuture", 0, 7, false) == 0) && (key.Length == 25))
                                {
                                fromJSONDateAndOrTimeSpecInFuture(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'H':
                if (String.Compare(key, 1, "olidays", 0, 7, false) == 0)
                  {
                    if (key.Length == 8)
                      {
                        {
                        fromJSONHolidays(new_component, false);
                        return;
                        }
                      }
                    switch (key[8])
                      {
                        case 'D':
                            if ((String.Compare(key, 9, "ata", 0, 3, false) == 0) && (key.Length == 12))
                                {
                                fromJSONHolidaysData(new_component, false);
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
        extraHolidaysOnDateLookupInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDateAndOrTimeSpec);
        if (flagHasDateAndOrTimeSpec)
          {
            handler.start_pair("DateAndOrTimeSpec");
            if (partial_allowed)
                storeDateAndOrTimeSpec.write_partial_as_json(handler);
            else
                storeDateAndOrTimeSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDateAndOrTimeSpecInFuture);
        if (flagHasDateAndOrTimeSpecInFuture)
          {
            handler.start_pair("DateAndOrTimeSpecInFuture");
            handler.boolean_value(storeDateAndOrTimeSpecInFuture);
          }
        Debug.Assert(partial_allowed || flagHasHolidaysData);
        if (flagHasHolidaysData)
          {
            handler.start_pair("HolidaysData");
            handler.start_array();
            for (int num1 = 0; num1 < storeHolidaysData.Count; ++num1)
              {
                if (partial_allowed)
                    storeHolidaysData[num1].write_partial_as_json(handler);
                else
                    storeHolidaysData[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasHolidays);
        if (flagHasHolidays)
          {
            handler.start_pair("Holidays");
            handler.start_array();
            for (int num2 = 0; num2 < storeHolidays.Count; ++num2)
              {
                handler.string_value(storeHolidays[num2]);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasDateAndOrTimeSpec()))
          {
            return "When parsing the object for %what%, the \"DateAndOrTimeSpec\" field was missing.";
          }
        if (!(hasDateAndOrTimeSpecInFuture()))
          {
            return "When parsing the object for %what%, the \"DateAndOrTimeSpecInFuture\" field was missing.";
          }
        if (!(hasHolidaysData()))
          {
            return "When parsing the object for %what%, the \"HolidaysData\" field was missing.";
          }
        if (!(hasHolidays()))
          {
            return "When parsing the object for %what%, the \"Holidays\" field was missing.";
          }
        return null;
      }

    public static new HolidaysOnDateLookupInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HolidaysOnDateLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HolidaysOnDateLookupInformationNugget", ignore_extras);
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
    public static new HolidaysOnDateLookupInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HolidaysOnDateLookupInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HolidaysOnDateLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HolidaysOnDateLookupInformationNugget", ignore_extras);
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
    public static new HolidaysOnDateLookupInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HolidaysOnDateLookupInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        HolidaysOnDateLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HolidaysOnDateLookupInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HolidaysOnDateLookupInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HolidaysOnDateLookupInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HolidaysOnDateLookupInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HolidaysOnDateLookupInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DateAndTimeInformationNuggetJSON.Generator
      {
        private DateAndOrTimeSpecJSON.HoldingGenerator fieldGeneratorDateAndOrTimeSpec;
        private JSONHoldingBooleanGenerator fieldGeneratorDateAndOrTimeSpecInFuture;
        private HolidayJSON.HoldingArrayGenerator fieldGeneratorHolidaysData;
        private JSONHoldingStringArrayGenerator fieldGeneratorHolidays;
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
            if (!(getDateAndTimeInformationNuggetJSONKey().Equals("HolidaysOnDateLookup")))
                throw new Exception("The key field has a value other than `HolidaysOnDateLookup'.");
            HolidaysOnDateLookupInformationNuggetJSON result = new HolidaysOnDateLookupInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHolidaysOnDateLookupInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DateAndTimeInformationNuggetJSON new_result)
          {
            handle_result((HolidaysOnDateLookupInformationNuggetJSON )new_result);
          }
        protected void finish(HolidaysOnDateLookupInformationNuggetJSON result)
          {
            if (fieldGeneratorDateAndOrTimeSpec.have_value)
              {
                result.setDateAndOrTimeSpec(fieldGeneratorDateAndOrTimeSpec.value);
                fieldGeneratorDateAndOrTimeSpec.have_value = false;
              }
            else if ((!(result.hasDateAndOrTimeSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndOrTimeSpec\" field was missing.");
              }
            if (fieldGeneratorDateAndOrTimeSpecInFuture.have_value)
              {
                result.setDateAndOrTimeSpecInFuture(fieldGeneratorDateAndOrTimeSpecInFuture.value);
                fieldGeneratorDateAndOrTimeSpecInFuture.have_value = false;
              }
            else if ((!(result.hasDateAndOrTimeSpecInFuture())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DateAndOrTimeSpecInFuture\" field was missing.");
              }
            if (fieldGeneratorHolidaysData.have_value)
              {
                result.initHolidaysData();
                int count = fieldGeneratorHolidaysData.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHolidaysData(fieldGeneratorHolidaysData.value[num]);
                  }
                fieldGeneratorHolidaysData.value.Clear();
                fieldGeneratorHolidaysData.have_value = false;
              }
            else if ((!(result.hasHolidaysData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HolidaysData\" field was missing.");
              }
            if (fieldGeneratorHolidays.have_value)
              {
                result.initHolidays();
                int count = fieldGeneratorHolidays.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHolidays(fieldGeneratorHolidays.value[num]);
                  }
                fieldGeneratorHolidays.value.Clear();
                fieldGeneratorHolidays.have_value = false;
              }
            else if ((!(result.hasHolidays())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Holidays\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(HolidaysOnDateLookupInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "ateAndOrTimeSpec", 0, 16, false) == 0)
                      {
                        if (field_name.Length == 17)
                          {
                            return fieldGeneratorDateAndOrTimeSpec;
                          }
                        switch (field_name[17])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 18, "nFuture", 0, 7, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorDateAndOrTimeSpecInFuture;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if (String.Compare(field_name, 1, "olidays", 0, 7, false) == 0)
                      {
                        if (field_name.Length == 8)
                          {
                            return fieldGeneratorHolidays;
                          }
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "ata", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorHolidaysData;
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
            fieldGeneratorDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"DateAndOrTimeSpec\" of the HolidaysOnDateLookupInformationNugget class", ignore_extras);
            fieldGeneratorDateAndOrTimeSpecInFuture = new JSONHoldingBooleanGenerator("field \"DateAndOrTimeSpecInFuture\" of the HolidaysOnDateLookupInformationNugget class");
            fieldGeneratorHolidaysData = new HolidayJSON.HoldingArrayGenerator("field \"HolidaysData\" of the HolidaysOnDateLookupInformationNugget class", ignore_extras);
            fieldGeneratorHolidays = new JSONHoldingStringArrayGenerator("field \"Holidays\" of the HolidaysOnDateLookupInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HolidaysOnDateLookupInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorDateAndOrTimeSpec = new DateAndOrTimeSpecJSON.HoldingGenerator("field \"DateAndOrTimeSpec\" of the HolidaysOnDateLookupInformationNugget class", false);
            fieldGeneratorDateAndOrTimeSpecInFuture = new JSONHoldingBooleanGenerator("field \"DateAndOrTimeSpecInFuture\" of the HolidaysOnDateLookupInformationNugget class");
            fieldGeneratorHolidaysData = new HolidayJSON.HoldingArrayGenerator("field \"HolidaysData\" of the HolidaysOnDateLookupInformationNugget class", false);
            fieldGeneratorHolidays = new JSONHoldingStringArrayGenerator("field \"Holidays\" of the HolidaysOnDateLookupInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HolidaysOnDateLookupInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorDateAndOrTimeSpec.reset();
            fieldGeneratorDateAndOrTimeSpecInFuture.reset();
            fieldGeneratorHolidaysData.reset();
            fieldGeneratorHolidays.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(HolidaysOnDateLookupInformationNuggetJSON  result)
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
        public HolidaysOnDateLookupInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HolidaysOnDateLookupInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<HolidaysOnDateLookupInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HolidaysOnDateLookupInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HolidaysOnDateLookupInformationNuggetJSON>();
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
    public List<HolidaysOnDateLookupInformationNuggetJSON> value;
  };
  };
