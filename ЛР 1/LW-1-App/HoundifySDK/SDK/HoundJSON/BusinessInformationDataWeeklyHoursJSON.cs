/* file "BusinessInformationDataWeeklyHoursJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BusinessInformationDataWeeklyHoursJSON : JSONBase
  {
    private bool flagHasMonday;
    private BusinessInformationDataDailyHoursJSON  storeMonday;
    private bool flagHasTuesday;
    private BusinessInformationDataDailyHoursJSON  storeTuesday;
    private bool flagHasWednesday;
    private BusinessInformationDataDailyHoursJSON  storeWednesday;
    private bool flagHasThursday;
    private BusinessInformationDataDailyHoursJSON  storeThursday;
    private bool flagHasFriday;
    private BusinessInformationDataDailyHoursJSON  storeFriday;
    private bool flagHasSaturday;
    private BusinessInformationDataDailyHoursJSON  storeSaturday;
    private bool flagHasSunday;
    private BusinessInformationDataDailyHoursJSON  storeSunday;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONMonday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BusinessInformationDataDailyHoursJSON convert_classy = BusinessInformationDataDailyHoursJSON.from_json(json_value, ignore_extras, true);
        setMonday(convert_classy);
      }


    private void  fromJSONTuesday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BusinessInformationDataDailyHoursJSON convert_classy = BusinessInformationDataDailyHoursJSON.from_json(json_value, ignore_extras, true);
        setTuesday(convert_classy);
      }


    private void  fromJSONWednesday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BusinessInformationDataDailyHoursJSON convert_classy = BusinessInformationDataDailyHoursJSON.from_json(json_value, ignore_extras, true);
        setWednesday(convert_classy);
      }


    private void  fromJSONThursday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BusinessInformationDataDailyHoursJSON convert_classy = BusinessInformationDataDailyHoursJSON.from_json(json_value, ignore_extras, true);
        setThursday(convert_classy);
      }


    private void  fromJSONFriday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BusinessInformationDataDailyHoursJSON convert_classy = BusinessInformationDataDailyHoursJSON.from_json(json_value, ignore_extras, true);
        setFriday(convert_classy);
      }


    private void  fromJSONSaturday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BusinessInformationDataDailyHoursJSON convert_classy = BusinessInformationDataDailyHoursJSON.from_json(json_value, ignore_extras, true);
        setSaturday(convert_classy);
      }


    private void  fromJSONSunday(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BusinessInformationDataDailyHoursJSON convert_classy = BusinessInformationDataDailyHoursJSON.from_json(json_value, ignore_extras, true);
        setSunday(convert_classy);
      }


    public BusinessInformationDataWeeklyHoursJSON()
      {
        flagHasMonday = false;
        flagHasTuesday = false;
        flagHasWednesday = false;
        flagHasThursday = false;
        flagHasFriday = false;
        flagHasSaturday = false;
        flagHasSunday = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasMonday()
      {
        return flagHasMonday;
      }

    public BusinessInformationDataDailyHoursJSON   getMonday()
      {
        Debug.Assert(flagHasMonday);
        return storeMonday;
      }

    public bool  hasTuesday()
      {
        return flagHasTuesday;
      }

    public BusinessInformationDataDailyHoursJSON   getTuesday()
      {
        Debug.Assert(flagHasTuesday);
        return storeTuesday;
      }

    public bool  hasWednesday()
      {
        return flagHasWednesday;
      }

    public BusinessInformationDataDailyHoursJSON   getWednesday()
      {
        Debug.Assert(flagHasWednesday);
        return storeWednesday;
      }

    public bool  hasThursday()
      {
        return flagHasThursday;
      }

    public BusinessInformationDataDailyHoursJSON   getThursday()
      {
        Debug.Assert(flagHasThursday);
        return storeThursday;
      }

    public bool  hasFriday()
      {
        return flagHasFriday;
      }

    public BusinessInformationDataDailyHoursJSON   getFriday()
      {
        Debug.Assert(flagHasFriday);
        return storeFriday;
      }

    public bool  hasSaturday()
      {
        return flagHasSaturday;
      }

    public BusinessInformationDataDailyHoursJSON   getSaturday()
      {
        Debug.Assert(flagHasSaturday);
        return storeSaturday;
      }

    public bool  hasSunday()
      {
        return flagHasSunday;
      }

    public BusinessInformationDataDailyHoursJSON   getSunday()
      {
        Debug.Assert(flagHasSunday);
        return storeSunday;
      }


    public virtual int extraBusinessInformationDataWeeklyHoursComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBusinessInformationDataWeeklyHoursComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBusinessInformationDataWeeklyHoursComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBusinessInformationDataWeeklyHoursLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setMonday(BusinessInformationDataDailyHoursJSON  new_value)
      {
        if (flagHasMonday)
          {
          }
        flagHasMonday = true;
        storeMonday = new_value;
      }
    public void unsetMonday()
      {
        if (flagHasMonday)
          {
          }
        flagHasMonday = false;
      }
    public void setTuesday(BusinessInformationDataDailyHoursJSON  new_value)
      {
        if (flagHasTuesday)
          {
          }
        flagHasTuesday = true;
        storeTuesday = new_value;
      }
    public void unsetTuesday()
      {
        if (flagHasTuesday)
          {
          }
        flagHasTuesday = false;
      }
    public void setWednesday(BusinessInformationDataDailyHoursJSON  new_value)
      {
        if (flagHasWednesday)
          {
          }
        flagHasWednesday = true;
        storeWednesday = new_value;
      }
    public void unsetWednesday()
      {
        if (flagHasWednesday)
          {
          }
        flagHasWednesday = false;
      }
    public void setThursday(BusinessInformationDataDailyHoursJSON  new_value)
      {
        if (flagHasThursday)
          {
          }
        flagHasThursday = true;
        storeThursday = new_value;
      }
    public void unsetThursday()
      {
        if (flagHasThursday)
          {
          }
        flagHasThursday = false;
      }
    public void setFriday(BusinessInformationDataDailyHoursJSON  new_value)
      {
        if (flagHasFriday)
          {
          }
        flagHasFriday = true;
        storeFriday = new_value;
      }
    public void unsetFriday()
      {
        if (flagHasFriday)
          {
          }
        flagHasFriday = false;
      }
    public void setSaturday(BusinessInformationDataDailyHoursJSON  new_value)
      {
        if (flagHasSaturday)
          {
          }
        flagHasSaturday = true;
        storeSaturday = new_value;
      }
    public void unsetSaturday()
      {
        if (flagHasSaturday)
          {
          }
        flagHasSaturday = false;
      }
    public void setSunday(BusinessInformationDataDailyHoursJSON  new_value)
      {
        if (flagHasSunday)
          {
          }
        flagHasSunday = true;
        storeSunday = new_value;
      }
    public void unsetSunday()
      {
        if (flagHasSunday)
          {
          }
        flagHasSunday = false;
      }

    public virtual void extraBusinessInformationDataWeeklyHoursAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBusinessInformationDataWeeklyHoursSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBusinessInformationDataWeeklyHoursLookup(key);
        if (old_field == null)
          {
            extraBusinessInformationDataWeeklyHoursAppendPair(key, new_component);
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
        if (flagHasMonday)
          {
            handler.start_pair("Monday");
            if (partial_allowed)
                storeMonday.write_partial_as_json(handler);
            else
                storeMonday.write_as_json(handler);
          }
        if (flagHasTuesday)
          {
            handler.start_pair("Tuesday");
            if (partial_allowed)
                storeTuesday.write_partial_as_json(handler);
            else
                storeTuesday.write_as_json(handler);
          }
        if (flagHasWednesday)
          {
            handler.start_pair("Wednesday");
            if (partial_allowed)
                storeWednesday.write_partial_as_json(handler);
            else
                storeWednesday.write_as_json(handler);
          }
        if (flagHasThursday)
          {
            handler.start_pair("Thursday");
            if (partial_allowed)
                storeThursday.write_partial_as_json(handler);
            else
                storeThursday.write_as_json(handler);
          }
        if (flagHasFriday)
          {
            handler.start_pair("Friday");
            if (partial_allowed)
                storeFriday.write_partial_as_json(handler);
            else
                storeFriday.write_as_json(handler);
          }
        if (flagHasSaturday)
          {
            handler.start_pair("Saturday");
            if (partial_allowed)
                storeSaturday.write_partial_as_json(handler);
            else
                storeSaturday.write_as_json(handler);
          }
        if (flagHasSunday)
          {
            handler.start_pair("Sunday");
            if (partial_allowed)
                storeSunday.write_partial_as_json(handler);
            else
                storeSunday.write_as_json(handler);
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

    public static BusinessInformationDataWeeklyHoursJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BusinessInformationDataWeeklyHoursJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationDataWeeklyHours", ignore_extras);
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
    public static BusinessInformationDataWeeklyHoursJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BusinessInformationDataWeeklyHoursJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BusinessInformationDataWeeklyHoursJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationDataWeeklyHours", ignore_extras);
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
    public static BusinessInformationDataWeeklyHoursJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BusinessInformationDataWeeklyHoursJSON from_text(string text, bool ignore_extras)
      {
        BusinessInformationDataWeeklyHoursJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationDataWeeklyHours", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BusinessInformationDataWeeklyHoursJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BusinessInformationDataWeeklyHoursJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BusinessInformationDataWeeklyHoursJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationDataWeeklyHours", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private BusinessInformationDataDailyHoursJSON.HoldingGenerator fieldGeneratorMonday;
        private BusinessInformationDataDailyHoursJSON.HoldingGenerator fieldGeneratorTuesday;
        private BusinessInformationDataDailyHoursJSON.HoldingGenerator fieldGeneratorWednesday;
        private BusinessInformationDataDailyHoursJSON.HoldingGenerator fieldGeneratorThursday;
        private BusinessInformationDataDailyHoursJSON.HoldingGenerator fieldGeneratorFriday;
        private BusinessInformationDataDailyHoursJSON.HoldingGenerator fieldGeneratorSaturday;
        private BusinessInformationDataDailyHoursJSON.HoldingGenerator fieldGeneratorSunday;
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
            BusinessInformationDataWeeklyHoursJSON result = new BusinessInformationDataWeeklyHoursJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBusinessInformationDataWeeklyHoursAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BusinessInformationDataWeeklyHoursJSON result)
          {
            if (fieldGeneratorMonday.have_value)
              {
                result.setMonday(fieldGeneratorMonday.value);
                fieldGeneratorMonday.have_value = false;
              }
            if (fieldGeneratorTuesday.have_value)
              {
                result.setTuesday(fieldGeneratorTuesday.value);
                fieldGeneratorTuesday.have_value = false;
              }
            if (fieldGeneratorWednesday.have_value)
              {
                result.setWednesday(fieldGeneratorWednesday.value);
                fieldGeneratorWednesday.have_value = false;
              }
            if (fieldGeneratorThursday.have_value)
              {
                result.setThursday(fieldGeneratorThursday.value);
                fieldGeneratorThursday.have_value = false;
              }
            if (fieldGeneratorFriday.have_value)
              {
                result.setFriday(fieldGeneratorFriday.value);
                fieldGeneratorFriday.have_value = false;
              }
            if (fieldGeneratorSaturday.have_value)
              {
                result.setSaturday(fieldGeneratorSaturday.value);
                fieldGeneratorSaturday.have_value = false;
              }
            if (fieldGeneratorSunday.have_value)
              {
                result.setSunday(fieldGeneratorSunday.value);
                fieldGeneratorSunday.have_value = false;
              }
          }
        protected abstract void handle_result(BusinessInformationDataWeeklyHoursJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "riday", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorFriday;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "onday", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorMonday;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "turday", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorSaturday;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "nday", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorSunday;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "ursday", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorThursday;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "esday", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorTuesday;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "ednesday", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorWednesday;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMonday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Monday\" of the BusinessInformationDataWeeklyHours class", ignore_extras);
            fieldGeneratorTuesday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Tuesday\" of the BusinessInformationDataWeeklyHours class", ignore_extras);
            fieldGeneratorWednesday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Wednesday\" of the BusinessInformationDataWeeklyHours class", ignore_extras);
            fieldGeneratorThursday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Thursday\" of the BusinessInformationDataWeeklyHours class", ignore_extras);
            fieldGeneratorFriday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Friday\" of the BusinessInformationDataWeeklyHours class", ignore_extras);
            fieldGeneratorSaturday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Saturday\" of the BusinessInformationDataWeeklyHours class", ignore_extras);
            fieldGeneratorSunday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Sunday\" of the BusinessInformationDataWeeklyHours class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BusinessInformationDataWeeklyHours class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMonday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Monday\" of the BusinessInformationDataWeeklyHours class", false);
            fieldGeneratorTuesday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Tuesday\" of the BusinessInformationDataWeeklyHours class", false);
            fieldGeneratorWednesday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Wednesday\" of the BusinessInformationDataWeeklyHours class", false);
            fieldGeneratorThursday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Thursday\" of the BusinessInformationDataWeeklyHours class", false);
            fieldGeneratorFriday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Friday\" of the BusinessInformationDataWeeklyHours class", false);
            fieldGeneratorSaturday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Saturday\" of the BusinessInformationDataWeeklyHours class", false);
            fieldGeneratorSunday = new BusinessInformationDataDailyHoursJSON.HoldingGenerator("field \"Sunday\" of the BusinessInformationDataWeeklyHours class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BusinessInformationDataWeeklyHours class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMonday.reset();
            fieldGeneratorTuesday.reset();
            fieldGeneratorWednesday.reset();
            fieldGeneratorThursday.reset();
            fieldGeneratorFriday.reset();
            fieldGeneratorSaturday.reset();
            fieldGeneratorSunday.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMonday.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTuesday.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWednesday.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorThursday.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFriday.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSaturday.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSunday.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMonday.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTuesday.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWednesday.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorThursday.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFriday.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSaturday.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSunday.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(BusinessInformationDataWeeklyHoursJSON  result)
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
        public BusinessInformationDataWeeklyHoursJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BusinessInformationDataWeeklyHoursJSON  result)
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
    protected virtual void handle_result(List<BusinessInformationDataWeeklyHoursJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BusinessInformationDataWeeklyHoursJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BusinessInformationDataWeeklyHoursJSON>();
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
    public List<BusinessInformationDataWeeklyHoursJSON> value;
  };
  };
