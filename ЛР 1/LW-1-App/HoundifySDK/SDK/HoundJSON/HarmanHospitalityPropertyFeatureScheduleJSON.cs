/* file "HarmanHospitalityPropertyFeatureScheduleJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HarmanHospitalityPropertyFeatureScheduleJSON : JSONBase
  {
    private bool flagHasEffectiveFrom;
    private string storeEffectiveFrom;
    private bool flagHasWeekendDiff;
    private bool storeWeekendDiff;
    private bool flagHasIsAllDay;
    private bool storeIsAllDay;
    private bool flagHasWeekdays;
    private List< HarmanHospitalityPropertyFeatureDailyScheduleJSON  > storeWeekdays;
    private bool flagHasWeekends;
    private List< HarmanHospitalityPropertyFeatureDailyScheduleJSON  > storeWeekends;
    private bool flagHasRangeOfDateTime;
    private ObsoleteRangeOfDateTimeJSON  storeRangeOfDateTime;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONEffectiveFrom(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EffectiveFrom of HarmanHospitalityPropertyFeatureScheduleJSON is not a string.");
        setEffectiveFrom(json_string.getData());
      }


    private void  fromJSONWeekendDiff(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field WeekendDiff of HarmanHospitalityPropertyFeatureScheduleJSON is not true for false.");
              }
          }
        setWeekendDiff(the_bool);
      }


    private void  fromJSONIsAllDay(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsAllDay of HarmanHospitalityPropertyFeatureScheduleJSON is not true for false.");
              }
          }
        setIsAllDay(the_bool);
      }


    private void  fromJSONWeekdays(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Weekdays of HarmanHospitalityPropertyFeatureScheduleJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HarmanHospitalityPropertyFeatureDailyScheduleJSON  > vector_Weekdays1 = new List< HarmanHospitalityPropertyFeatureDailyScheduleJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HarmanHospitalityPropertyFeatureDailyScheduleJSON convert_classy = HarmanHospitalityPropertyFeatureDailyScheduleJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Weekdays1.Add(convert_classy);
          }
        initWeekdays();
        for (int num1 = 0; num1 < vector_Weekdays1.Count; ++num1)
            appendWeekdays(vector_Weekdays1[num1]);
        for (int num1 = 0; num1 < vector_Weekdays1.Count; ++num1)
          {
          }
      }


    private void  fromJSONWeekends(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Weekends of HarmanHospitalityPropertyFeatureScheduleJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HarmanHospitalityPropertyFeatureDailyScheduleJSON  > vector_Weekends1 = new List< HarmanHospitalityPropertyFeatureDailyScheduleJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HarmanHospitalityPropertyFeatureDailyScheduleJSON convert_classy = HarmanHospitalityPropertyFeatureDailyScheduleJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Weekends1.Add(convert_classy);
          }
        initWeekends();
        for (int num2 = 0; num2 < vector_Weekends1.Count; ++num2)
            appendWeekends(vector_Weekends1[num2]);
        for (int num1 = 0; num1 < vector_Weekends1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRangeOfDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ObsoleteRangeOfDateTimeJSON convert_classy = ObsoleteRangeOfDateTimeJSON.from_json(json_value, ignore_extras, true);
        setRangeOfDateTime(convert_classy);
      }


    public HarmanHospitalityPropertyFeatureScheduleJSON()
      {
        flagHasEffectiveFrom = false;
        flagHasWeekendDiff = false;
        flagHasIsAllDay = false;
        flagHasWeekdays = false;
        flagHasWeekends = false;
        flagHasRangeOfDateTime = false;
        storeWeekdays = new List< HarmanHospitalityPropertyFeatureDailyScheduleJSON  >();
        storeWeekends = new List< HarmanHospitalityPropertyFeatureDailyScheduleJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasEffectiveFrom()
      {
        return flagHasEffectiveFrom;
      }

    public string  getEffectiveFrom()
      {
        Debug.Assert(flagHasEffectiveFrom);
        return storeEffectiveFrom;
      }

    public bool  hasWeekendDiff()
      {
        return flagHasWeekendDiff;
      }

    public bool  getWeekendDiff()
      {
        Debug.Assert(flagHasWeekendDiff);
        return storeWeekendDiff;
      }

    public bool  hasIsAllDay()
      {
        return flagHasIsAllDay;
      }

    public bool  getIsAllDay()
      {
        Debug.Assert(flagHasIsAllDay);
        return storeIsAllDay;
      }

    public bool  hasWeekdays()
      {
        return flagHasWeekdays;
      }

    public int  countOfWeekdays()
      {
        Debug.Assert(flagHasWeekdays);
        return storeWeekdays.Count;
      }

    public HarmanHospitalityPropertyFeatureDailyScheduleJSON   elementOfWeekdays(int element_num)
      {
        Debug.Assert(flagHasWeekdays);
        return storeWeekdays[element_num];
      }

    public List< HarmanHospitalityPropertyFeatureDailyScheduleJSON  >  getWeekdays()
      {
        Debug.Assert(flagHasWeekdays);
        return storeWeekdays;
      }

    public bool  hasWeekends()
      {
        return flagHasWeekends;
      }

    public int  countOfWeekends()
      {
        Debug.Assert(flagHasWeekends);
        return storeWeekends.Count;
      }

    public HarmanHospitalityPropertyFeatureDailyScheduleJSON   elementOfWeekends(int element_num)
      {
        Debug.Assert(flagHasWeekends);
        return storeWeekends[element_num];
      }

    public List< HarmanHospitalityPropertyFeatureDailyScheduleJSON  >  getWeekends()
      {
        Debug.Assert(flagHasWeekends);
        return storeWeekends;
      }

    public bool  hasRangeOfDateTime()
      {
        return flagHasRangeOfDateTime;
      }

    public ObsoleteRangeOfDateTimeJSON   getRangeOfDateTime()
      {
        Debug.Assert(flagHasRangeOfDateTime);
        return storeRangeOfDateTime;
      }


    public virtual int extraHarmanHospitalityPropertyFeatureScheduleComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHarmanHospitalityPropertyFeatureScheduleComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHarmanHospitalityPropertyFeatureScheduleComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHarmanHospitalityPropertyFeatureScheduleLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setEffectiveFrom(string new_value)
      {
        flagHasEffectiveFrom = true;
        storeEffectiveFrom = new_value;
      }
    public void unsetEffectiveFrom()
      {
        flagHasEffectiveFrom = false;
      }
    public void setWeekendDiff(bool new_value)
      {
        flagHasWeekendDiff = true;
        storeWeekendDiff = new_value;
      }
    public void unsetWeekendDiff()
      {
        flagHasWeekendDiff = false;
      }
    public void setIsAllDay(bool new_value)
      {
        flagHasIsAllDay = true;
        storeIsAllDay = new_value;
      }
    public void unsetIsAllDay()
      {
        flagHasIsAllDay = false;
      }
    public void initWeekdays()
      {
        if (flagHasWeekdays)
          {
            for (int num1 = 0; num1 < storeWeekdays.Count; ++num1)
              {
              }
          }
        flagHasWeekdays = true;
        storeWeekdays.Clear();
      }
    public void appendWeekdays(HarmanHospitalityPropertyFeatureDailyScheduleJSON  to_append)
      {
        if (!flagHasWeekdays)
          {
            flagHasWeekdays = true;
            storeWeekdays.Clear();
          }
        Debug.Assert(flagHasWeekdays);
        storeWeekdays.Add(to_append);
      }
    public void unsetWeekdays()
      {
        if (flagHasWeekdays)
          {
            for (int num2 = 0; num2 < storeWeekdays.Count; ++num2)
              {
              }
          }
        flagHasWeekdays = false;
        storeWeekdays.Clear();
      }
    public void initWeekends()
      {
        if (flagHasWeekends)
          {
            for (int num3 = 0; num3 < storeWeekends.Count; ++num3)
              {
              }
          }
        flagHasWeekends = true;
        storeWeekends.Clear();
      }
    public void appendWeekends(HarmanHospitalityPropertyFeatureDailyScheduleJSON  to_append)
      {
        if (!flagHasWeekends)
          {
            flagHasWeekends = true;
            storeWeekends.Clear();
          }
        Debug.Assert(flagHasWeekends);
        storeWeekends.Add(to_append);
      }
    public void unsetWeekends()
      {
        if (flagHasWeekends)
          {
            for (int num4 = 0; num4 < storeWeekends.Count; ++num4)
              {
              }
          }
        flagHasWeekends = false;
        storeWeekends.Clear();
      }
    public void setRangeOfDateTime(ObsoleteRangeOfDateTimeJSON  new_value)
      {
        if (flagHasRangeOfDateTime)
          {
          }
        flagHasRangeOfDateTime = true;
        storeRangeOfDateTime = new_value;
      }
    public void unsetRangeOfDateTime()
      {
        if (flagHasRangeOfDateTime)
          {
          }
        flagHasRangeOfDateTime = false;
      }

    public virtual void extraHarmanHospitalityPropertyFeatureScheduleAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHarmanHospitalityPropertyFeatureScheduleSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHarmanHospitalityPropertyFeatureScheduleLookup(key);
        if (old_field == null)
          {
            extraHarmanHospitalityPropertyFeatureScheduleAppendPair(key, new_component);
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
        if (flagHasEffectiveFrom)
          {
            handler.start_pair("EffectiveFrom");
            handler.string_value(storeEffectiveFrom);
          }
        if (flagHasWeekendDiff)
          {
            handler.start_pair("WeekendDiff");
            handler.boolean_value(storeWeekendDiff);
          }
        if (flagHasIsAllDay)
          {
            handler.start_pair("IsAllDay");
            handler.boolean_value(storeIsAllDay);
          }
        if (flagHasWeekdays)
          {
            handler.start_pair("Weekdays");
            handler.start_array();
            for (int num1 = 0; num1 < storeWeekdays.Count; ++num1)
              {
                if (partial_allowed)
                    storeWeekdays[num1].write_partial_as_json(handler);
                else
                    storeWeekdays[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasWeekends)
          {
            handler.start_pair("Weekends");
            handler.start_array();
            for (int num2 = 0; num2 < storeWeekends.Count; ++num2)
              {
                if (partial_allowed)
                    storeWeekends[num2].write_partial_as_json(handler);
                else
                    storeWeekends[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRangeOfDateTime)
          {
            handler.start_pair("RangeOfDateTime");
            if (partial_allowed)
                storeRangeOfDateTime.write_partial_as_json(handler);
            else
                storeRangeOfDateTime.write_as_json(handler);
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

    public static HarmanHospitalityPropertyFeatureScheduleJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanHospitalityPropertyFeatureScheduleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityPropertyFeatureSchedule", ignore_extras);
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
    public static HarmanHospitalityPropertyFeatureScheduleJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanHospitalityPropertyFeatureScheduleJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanHospitalityPropertyFeatureScheduleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityPropertyFeatureSchedule", ignore_extras);
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
    public static HarmanHospitalityPropertyFeatureScheduleJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanHospitalityPropertyFeatureScheduleJSON from_text(string text, bool ignore_extras)
      {
        HarmanHospitalityPropertyFeatureScheduleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityPropertyFeatureSchedule", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HarmanHospitalityPropertyFeatureScheduleJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HarmanHospitalityPropertyFeatureScheduleJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HarmanHospitalityPropertyFeatureScheduleJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityPropertyFeatureSchedule", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorEffectiveFrom;
        private JSONHoldingBooleanGenerator fieldGeneratorWeekendDiff;
        private JSONHoldingBooleanGenerator fieldGeneratorIsAllDay;
        private HarmanHospitalityPropertyFeatureDailyScheduleJSON.HoldingArrayGenerator fieldGeneratorWeekdays;
        private HarmanHospitalityPropertyFeatureDailyScheduleJSON.HoldingArrayGenerator fieldGeneratorWeekends;
        private ObsoleteRangeOfDateTimeJSON.HoldingGenerator fieldGeneratorRangeOfDateTime;
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
            HarmanHospitalityPropertyFeatureScheduleJSON result = new HarmanHospitalityPropertyFeatureScheduleJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHarmanHospitalityPropertyFeatureScheduleAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HarmanHospitalityPropertyFeatureScheduleJSON result)
          {
            if (fieldGeneratorEffectiveFrom.have_value)
              {
                result.setEffectiveFrom(fieldGeneratorEffectiveFrom.value);
                fieldGeneratorEffectiveFrom.have_value = false;
              }
            if (fieldGeneratorWeekendDiff.have_value)
              {
                result.setWeekendDiff(fieldGeneratorWeekendDiff.value);
                fieldGeneratorWeekendDiff.have_value = false;
              }
            if (fieldGeneratorIsAllDay.have_value)
              {
                result.setIsAllDay(fieldGeneratorIsAllDay.value);
                fieldGeneratorIsAllDay.have_value = false;
              }
            if (fieldGeneratorWeekdays.have_value)
              {
                result.initWeekdays();
                int count = fieldGeneratorWeekdays.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendWeekdays(fieldGeneratorWeekdays.value[num]);
                  }
                fieldGeneratorWeekdays.value.Clear();
                fieldGeneratorWeekdays.have_value = false;
              }
            if (fieldGeneratorWeekends.have_value)
              {
                result.initWeekends();
                int count = fieldGeneratorWeekends.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendWeekends(fieldGeneratorWeekends.value[num]);
                  }
                fieldGeneratorWeekends.value.Clear();
                fieldGeneratorWeekends.have_value = false;
              }
            if (fieldGeneratorRangeOfDateTime.have_value)
              {
                result.setRangeOfDateTime(fieldGeneratorRangeOfDateTime.value);
                fieldGeneratorRangeOfDateTime.have_value = false;
              }
          }
        protected abstract void handle_result(HarmanHospitalityPropertyFeatureScheduleJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "ffectiveFrom", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorEffectiveFrom;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sAllDay", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorIsAllDay;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "angeOfDateTime", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorRangeOfDateTime;
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "eek", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'd':
                                if ((String.Compare(field_name, 5, "ays", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorWeekdays;
                                break;
                            case 'e':
                                if (String.Compare(field_name, 5, "nd", 0, 2, false) == 0)
                                  {
                                    switch (field_name[7])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 8, "iff", 0, 3, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorWeekendDiff;
                                            break;
                                        case 's':
                                            if (field_name.Length == 8)
                                                return fieldGeneratorWeekends;
                                            break;
                                        default:
                                            break;
                                      }
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorEffectiveFrom = new JSONHoldingStringGenerator("field \"EffectiveFrom\" of the HarmanHospitalityPropertyFeatureSchedule class");
            fieldGeneratorWeekendDiff = new JSONHoldingBooleanGenerator("field \"WeekendDiff\" of the HarmanHospitalityPropertyFeatureSchedule class");
            fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the HarmanHospitalityPropertyFeatureSchedule class");
            fieldGeneratorWeekdays = new HarmanHospitalityPropertyFeatureDailyScheduleJSON.HoldingArrayGenerator("field \"Weekdays\" of the HarmanHospitalityPropertyFeatureSchedule class", ignore_extras);
            fieldGeneratorWeekends = new HarmanHospitalityPropertyFeatureDailyScheduleJSON.HoldingArrayGenerator("field \"Weekends\" of the HarmanHospitalityPropertyFeatureSchedule class", ignore_extras);
            fieldGeneratorRangeOfDateTime = new ObsoleteRangeOfDateTimeJSON.HoldingGenerator("field \"RangeOfDateTime\" of the HarmanHospitalityPropertyFeatureSchedule class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HarmanHospitalityPropertyFeatureSchedule class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEffectiveFrom = new JSONHoldingStringGenerator("field \"EffectiveFrom\" of the HarmanHospitalityPropertyFeatureSchedule class");
            fieldGeneratorWeekendDiff = new JSONHoldingBooleanGenerator("field \"WeekendDiff\" of the HarmanHospitalityPropertyFeatureSchedule class");
            fieldGeneratorIsAllDay = new JSONHoldingBooleanGenerator("field \"IsAllDay\" of the HarmanHospitalityPropertyFeatureSchedule class");
            fieldGeneratorWeekdays = new HarmanHospitalityPropertyFeatureDailyScheduleJSON.HoldingArrayGenerator("field \"Weekdays\" of the HarmanHospitalityPropertyFeatureSchedule class", false);
            fieldGeneratorWeekends = new HarmanHospitalityPropertyFeatureDailyScheduleJSON.HoldingArrayGenerator("field \"Weekends\" of the HarmanHospitalityPropertyFeatureSchedule class", false);
            fieldGeneratorRangeOfDateTime = new ObsoleteRangeOfDateTimeJSON.HoldingGenerator("field \"RangeOfDateTime\" of the HarmanHospitalityPropertyFeatureSchedule class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HarmanHospitalityPropertyFeatureSchedule class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEffectiveFrom.reset();
            fieldGeneratorWeekendDiff.reset();
            fieldGeneratorIsAllDay.reset();
            fieldGeneratorWeekdays.reset();
            fieldGeneratorWeekends.reset();
            fieldGeneratorRangeOfDateTime.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorWeekdays.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWeekends.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRangeOfDateTime.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorWeekdays.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWeekends.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRangeOfDateTime.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HarmanHospitalityPropertyFeatureScheduleJSON  result)
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
        public HarmanHospitalityPropertyFeatureScheduleJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HarmanHospitalityPropertyFeatureScheduleJSON  result)
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
    protected virtual void handle_result(List<HarmanHospitalityPropertyFeatureScheduleJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HarmanHospitalityPropertyFeatureScheduleJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HarmanHospitalityPropertyFeatureScheduleJSON>();
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
    public List<HarmanHospitalityPropertyFeatureScheduleJSON> value;
  };
  };
