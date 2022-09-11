/* file "FlightStatusBoardingInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightStatusBoardingInfoJSON : JSONBase
  {
    private bool flagHasActualDateTime;
    private FlightTimesJSON  storeActualDateTime;
    private bool flagHasEstimatedDateTime;
    private FlightTimesJSON  storeEstimatedDateTime;
    private bool flagHasScheduledDateTime;
    private FlightTimesJSON  storeScheduledDateTime;
    private bool flagHasOperationalDateTime;
    private FlightTimesJSON  storeOperationalDateTime;
    private bool flagHasOperationalDateTimeType;
    private FlightStatusOperationalDateTimeTypeJSON  storeOperationalDateTimeType;
    private bool flagHasDeviationFromScheduled;
    private TimeDifferenceJSON  storeDeviationFromScheduled;
    private bool flagHasStateInTimeline;
    private FlightStatusEventStateInTimelineJSON  storeStateInTimeline;
    private bool flagHasWaitingPeriod;
    private TimeDifferenceJSON  storeWaitingPeriod;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONActualDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setActualDateTime(convert_classy);
      }


    private void  fromJSONEstimatedDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setEstimatedDateTime(convert_classy);
      }


    private void  fromJSONScheduledDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setScheduledDateTime(convert_classy);
      }


    private void  fromJSONOperationalDateTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightTimesJSON convert_classy = FlightTimesJSON.from_json(json_value, ignore_extras, true);
        setOperationalDateTime(convert_classy);
      }


    private void  fromJSONOperationalDateTimeType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatusOperationalDateTimeTypeJSON convert_classy = FlightStatusOperationalDateTimeTypeJSON.from_json(json_value, ignore_extras, true);
        setOperationalDateTimeType(convert_classy);
      }


    private void  fromJSONDeviationFromScheduled(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeDifferenceJSON convert_classy = TimeDifferenceJSON.from_json(json_value, ignore_extras, true);
        setDeviationFromScheduled(convert_classy);
      }


    private void  fromJSONStateInTimeline(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatusEventStateInTimelineJSON convert_classy = FlightStatusEventStateInTimelineJSON.from_json(json_value, ignore_extras, true);
        setStateInTimeline(convert_classy);
      }


    private void  fromJSONWaitingPeriod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TimeDifferenceJSON convert_classy = TimeDifferenceJSON.from_json(json_value, ignore_extras, true);
        setWaitingPeriod(convert_classy);
      }


    public FlightStatusBoardingInfoJSON()
      {
        flagHasActualDateTime = false;
        flagHasEstimatedDateTime = false;
        flagHasScheduledDateTime = false;
        flagHasOperationalDateTime = false;
        flagHasOperationalDateTimeType = false;
        flagHasDeviationFromScheduled = false;
        flagHasStateInTimeline = false;
        flagHasWaitingPeriod = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasActualDateTime()
      {
        return flagHasActualDateTime;
      }

    public FlightTimesJSON   getActualDateTime()
      {
        Debug.Assert(flagHasActualDateTime);
        return storeActualDateTime;
      }

    public bool  hasEstimatedDateTime()
      {
        return flagHasEstimatedDateTime;
      }

    public FlightTimesJSON   getEstimatedDateTime()
      {
        Debug.Assert(flagHasEstimatedDateTime);
        return storeEstimatedDateTime;
      }

    public bool  hasScheduledDateTime()
      {
        return flagHasScheduledDateTime;
      }

    public FlightTimesJSON   getScheduledDateTime()
      {
        Debug.Assert(flagHasScheduledDateTime);
        return storeScheduledDateTime;
      }

    public bool  hasOperationalDateTime()
      {
        return flagHasOperationalDateTime;
      }

    public FlightTimesJSON   getOperationalDateTime()
      {
        Debug.Assert(flagHasOperationalDateTime);
        return storeOperationalDateTime;
      }

    public bool  hasOperationalDateTimeType()
      {
        return flagHasOperationalDateTimeType;
      }

    public FlightStatusOperationalDateTimeTypeJSON   getOperationalDateTimeType()
      {
        Debug.Assert(flagHasOperationalDateTimeType);
        return storeOperationalDateTimeType;
      }

    public FlightStatusOperationalDateTimeTypeJSON.TypeValue  getOperationalDateTimeTypeValue()
      {
        return getOperationalDateTimeType().getValue();
      }

    public string  getOperationalDateTimeTypeAsString()
      {
        return getOperationalDateTimeType().getValueAsString();
      }

    public bool  hasDeviationFromScheduled()
      {
        return flagHasDeviationFromScheduled;
      }

    public TimeDifferenceJSON   getDeviationFromScheduled()
      {
        Debug.Assert(flagHasDeviationFromScheduled);
        return storeDeviationFromScheduled;
      }

    public bool  hasStateInTimeline()
      {
        return flagHasStateInTimeline;
      }

    public FlightStatusEventStateInTimelineJSON   getStateInTimeline()
      {
        Debug.Assert(flagHasStateInTimeline);
        return storeStateInTimeline;
      }

    public FlightStatusEventStateInTimelineJSON.TypeValue  getStateInTimelineValue()
      {
        return getStateInTimeline().getValue();
      }

    public string  getStateInTimelineAsString()
      {
        return getStateInTimeline().getValueAsString();
      }

    public bool  hasWaitingPeriod()
      {
        return flagHasWaitingPeriod;
      }

    public TimeDifferenceJSON   getWaitingPeriod()
      {
        Debug.Assert(flagHasWaitingPeriod);
        return storeWaitingPeriod;
      }


    public virtual int extraFlightStatusBoardingInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatusBoardingInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatusBoardingInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatusBoardingInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setActualDateTime(FlightTimesJSON  new_value)
      {
        if (flagHasActualDateTime)
          {
          }
        flagHasActualDateTime = true;
        storeActualDateTime = new_value;
      }
    public void unsetActualDateTime()
      {
        if (flagHasActualDateTime)
          {
          }
        flagHasActualDateTime = false;
      }
    public void setEstimatedDateTime(FlightTimesJSON  new_value)
      {
        if (flagHasEstimatedDateTime)
          {
          }
        flagHasEstimatedDateTime = true;
        storeEstimatedDateTime = new_value;
      }
    public void unsetEstimatedDateTime()
      {
        if (flagHasEstimatedDateTime)
          {
          }
        flagHasEstimatedDateTime = false;
      }
    public void setScheduledDateTime(FlightTimesJSON  new_value)
      {
        if (flagHasScheduledDateTime)
          {
          }
        flagHasScheduledDateTime = true;
        storeScheduledDateTime = new_value;
      }
    public void unsetScheduledDateTime()
      {
        if (flagHasScheduledDateTime)
          {
          }
        flagHasScheduledDateTime = false;
      }
    public void setOperationalDateTime(FlightTimesJSON  new_value)
      {
        if (flagHasOperationalDateTime)
          {
          }
        flagHasOperationalDateTime = true;
        storeOperationalDateTime = new_value;
      }
    public void unsetOperationalDateTime()
      {
        if (flagHasOperationalDateTime)
          {
          }
        flagHasOperationalDateTime = false;
      }
    public void setOperationalDateTimeType(FlightStatusOperationalDateTimeTypeJSON  new_value)
      {
        if (flagHasOperationalDateTimeType)
          {
          }
        flagHasOperationalDateTimeType = true;
        storeOperationalDateTimeType = new_value;
      }
    public void setOperationalDateTimeType(FlightStatusOperationalDateTimeTypeJSON.TypeValue new_value)
      {
        setOperationalDateTimeType(new FlightStatusOperationalDateTimeTypeJSON(new_value));
      }
    public void setOperationalDateTimeType(string chars)
      {
        setOperationalDateTimeType(new FlightStatusOperationalDateTimeTypeJSON(chars));
      }
    public void unsetOperationalDateTimeType()
      {
        if (flagHasOperationalDateTimeType)
          {
          }
        flagHasOperationalDateTimeType = false;
      }
    public void setDeviationFromScheduled(TimeDifferenceJSON  new_value)
      {
        if (flagHasDeviationFromScheduled)
          {
          }
        flagHasDeviationFromScheduled = true;
        storeDeviationFromScheduled = new_value;
      }
    public void unsetDeviationFromScheduled()
      {
        if (flagHasDeviationFromScheduled)
          {
          }
        flagHasDeviationFromScheduled = false;
      }
    public void setStateInTimeline(FlightStatusEventStateInTimelineJSON  new_value)
      {
        if (flagHasStateInTimeline)
          {
          }
        flagHasStateInTimeline = true;
        storeStateInTimeline = new_value;
      }
    public void setStateInTimeline(FlightStatusEventStateInTimelineJSON.TypeValue new_value)
      {
        setStateInTimeline(new FlightStatusEventStateInTimelineJSON(new_value));
      }
    public void setStateInTimeline(string chars)
      {
        setStateInTimeline(new FlightStatusEventStateInTimelineJSON(chars));
      }
    public void unsetStateInTimeline()
      {
        if (flagHasStateInTimeline)
          {
          }
        flagHasStateInTimeline = false;
      }
    public void setWaitingPeriod(TimeDifferenceJSON  new_value)
      {
        if (flagHasWaitingPeriod)
          {
          }
        flagHasWaitingPeriod = true;
        storeWaitingPeriod = new_value;
      }
    public void unsetWaitingPeriod()
      {
        if (flagHasWaitingPeriod)
          {
          }
        flagHasWaitingPeriod = false;
      }

    public virtual void extraFlightStatusBoardingInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatusBoardingInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatusBoardingInfoLookup(key);
        if (old_field == null)
          {
            extraFlightStatusBoardingInfoAppendPair(key, new_component);
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
        if (flagHasActualDateTime)
          {
            handler.start_pair("ActualDateTime");
            if (partial_allowed)
                storeActualDateTime.write_partial_as_json(handler);
            else
                storeActualDateTime.write_as_json(handler);
          }
        if (flagHasEstimatedDateTime)
          {
            handler.start_pair("EstimatedDateTime");
            if (partial_allowed)
                storeEstimatedDateTime.write_partial_as_json(handler);
            else
                storeEstimatedDateTime.write_as_json(handler);
          }
        if (flagHasScheduledDateTime)
          {
            handler.start_pair("ScheduledDateTime");
            if (partial_allowed)
                storeScheduledDateTime.write_partial_as_json(handler);
            else
                storeScheduledDateTime.write_as_json(handler);
          }
        if (flagHasOperationalDateTime)
          {
            handler.start_pair("OperationalDateTime");
            if (partial_allowed)
                storeOperationalDateTime.write_partial_as_json(handler);
            else
                storeOperationalDateTime.write_as_json(handler);
          }
        if (flagHasOperationalDateTimeType)
          {
            handler.start_pair("OperationalDateTimeType");
            if (partial_allowed)
                storeOperationalDateTimeType.write_partial_as_json(handler);
            else
                storeOperationalDateTimeType.write_as_json(handler);
          }
        if (flagHasDeviationFromScheduled)
          {
            handler.start_pair("DeviationFromScheduled");
            if (partial_allowed)
                storeDeviationFromScheduled.write_partial_as_json(handler);
            else
                storeDeviationFromScheduled.write_as_json(handler);
          }
        if (flagHasStateInTimeline)
          {
            handler.start_pair("StateInTimeline");
            if (partial_allowed)
                storeStateInTimeline.write_partial_as_json(handler);
            else
                storeStateInTimeline.write_as_json(handler);
          }
        if (flagHasWaitingPeriod)
          {
            handler.start_pair("WaitingPeriod");
            if (partial_allowed)
                storeWaitingPeriod.write_partial_as_json(handler);
            else
                storeWaitingPeriod.write_as_json(handler);
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

    public static FlightStatusBoardingInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusBoardingInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusBoardingInfo", ignore_extras);
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
    public static FlightStatusBoardingInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatusBoardingInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusBoardingInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusBoardingInfo", ignore_extras);
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
    public static FlightStatusBoardingInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatusBoardingInfoJSON from_text(string text, bool ignore_extras)
      {
        FlightStatusBoardingInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusBoardingInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatusBoardingInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightStatusBoardingInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatusBoardingInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusBoardingInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private FlightTimesJSON.HoldingGenerator fieldGeneratorActualDateTime;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorEstimatedDateTime;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorScheduledDateTime;
        private FlightTimesJSON.HoldingGenerator fieldGeneratorOperationalDateTime;
        private FlightStatusOperationalDateTimeTypeJSON.HoldingGenerator fieldGeneratorOperationalDateTimeType;
        private TimeDifferenceJSON.HoldingGenerator fieldGeneratorDeviationFromScheduled;
        private FlightStatusEventStateInTimelineJSON.HoldingGenerator fieldGeneratorStateInTimeline;
        private TimeDifferenceJSON.HoldingGenerator fieldGeneratorWaitingPeriod;
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
            FlightStatusBoardingInfoJSON result = new FlightStatusBoardingInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatusBoardingInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightStatusBoardingInfoJSON result)
          {
            if (fieldGeneratorActualDateTime.have_value)
              {
                result.setActualDateTime(fieldGeneratorActualDateTime.value);
                fieldGeneratorActualDateTime.have_value = false;
              }
            if (fieldGeneratorEstimatedDateTime.have_value)
              {
                result.setEstimatedDateTime(fieldGeneratorEstimatedDateTime.value);
                fieldGeneratorEstimatedDateTime.have_value = false;
              }
            if (fieldGeneratorScheduledDateTime.have_value)
              {
                result.setScheduledDateTime(fieldGeneratorScheduledDateTime.value);
                fieldGeneratorScheduledDateTime.have_value = false;
              }
            if (fieldGeneratorOperationalDateTime.have_value)
              {
                result.setOperationalDateTime(fieldGeneratorOperationalDateTime.value);
                fieldGeneratorOperationalDateTime.have_value = false;
              }
            if (fieldGeneratorOperationalDateTimeType.have_value)
              {
                result.setOperationalDateTimeType(fieldGeneratorOperationalDateTimeType.value);
                fieldGeneratorOperationalDateTimeType.have_value = false;
              }
            if (fieldGeneratorDeviationFromScheduled.have_value)
              {
                result.setDeviationFromScheduled(fieldGeneratorDeviationFromScheduled.value);
                fieldGeneratorDeviationFromScheduled.have_value = false;
              }
            if (fieldGeneratorStateInTimeline.have_value)
              {
                result.setStateInTimeline(fieldGeneratorStateInTimeline.value);
                fieldGeneratorStateInTimeline.have_value = false;
              }
            if (fieldGeneratorWaitingPeriod.have_value)
              {
                result.setWaitingPeriod(fieldGeneratorWaitingPeriod.value);
                fieldGeneratorWaitingPeriod.have_value = false;
              }
          }
        protected abstract void handle_result(FlightStatusBoardingInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ctualDateTime", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorActualDateTime;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "eviationFromScheduled", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorDeviationFromScheduled;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "stimatedDateTime", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorEstimatedDateTime;
                    break;
                case 'O':
                    if (String.Compare(field_name, 1, "perationalDateTime", 0, 18, false) == 0)
                      {
                        if (field_name.Length == 19)
                          {
                            return fieldGeneratorOperationalDateTime;
                          }
                        switch (field_name[19])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 20, "ype", 0, 3, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorOperationalDateTimeType;
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
                            if ((String.Compare(field_name, 2, "heduledDateTime", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorScheduledDateTime;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "ateInTimeline", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorStateInTimeline;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "aitingPeriod", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorWaitingPeriod;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorActualDateTime = new FlightTimesJSON.HoldingGenerator("field \"ActualDateTime\" of the FlightStatusBoardingInfo class", ignore_extras);
            fieldGeneratorEstimatedDateTime = new FlightTimesJSON.HoldingGenerator("field \"EstimatedDateTime\" of the FlightStatusBoardingInfo class", ignore_extras);
            fieldGeneratorScheduledDateTime = new FlightTimesJSON.HoldingGenerator("field \"ScheduledDateTime\" of the FlightStatusBoardingInfo class", ignore_extras);
            fieldGeneratorOperationalDateTime = new FlightTimesJSON.HoldingGenerator("field \"OperationalDateTime\" of the FlightStatusBoardingInfo class", ignore_extras);
            fieldGeneratorOperationalDateTimeType = new FlightStatusOperationalDateTimeTypeJSON.HoldingGenerator("field \"OperationalDateTimeType\" of the FlightStatusBoardingInfo class", ignore_extras);
            fieldGeneratorDeviationFromScheduled = new TimeDifferenceJSON.HoldingGenerator("field \"DeviationFromScheduled\" of the FlightStatusBoardingInfo class", ignore_extras);
            fieldGeneratorStateInTimeline = new FlightStatusEventStateInTimelineJSON.HoldingGenerator("field \"StateInTimeline\" of the FlightStatusBoardingInfo class", ignore_extras);
            fieldGeneratorWaitingPeriod = new TimeDifferenceJSON.HoldingGenerator("field \"WaitingPeriod\" of the FlightStatusBoardingInfo class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatusBoardingInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorActualDateTime = new FlightTimesJSON.HoldingGenerator("field \"ActualDateTime\" of the FlightStatusBoardingInfo class", false);
            fieldGeneratorEstimatedDateTime = new FlightTimesJSON.HoldingGenerator("field \"EstimatedDateTime\" of the FlightStatusBoardingInfo class", false);
            fieldGeneratorScheduledDateTime = new FlightTimesJSON.HoldingGenerator("field \"ScheduledDateTime\" of the FlightStatusBoardingInfo class", false);
            fieldGeneratorOperationalDateTime = new FlightTimesJSON.HoldingGenerator("field \"OperationalDateTime\" of the FlightStatusBoardingInfo class", false);
            fieldGeneratorOperationalDateTimeType = new FlightStatusOperationalDateTimeTypeJSON.HoldingGenerator("field \"OperationalDateTimeType\" of the FlightStatusBoardingInfo class", false);
            fieldGeneratorDeviationFromScheduled = new TimeDifferenceJSON.HoldingGenerator("field \"DeviationFromScheduled\" of the FlightStatusBoardingInfo class", false);
            fieldGeneratorStateInTimeline = new FlightStatusEventStateInTimelineJSON.HoldingGenerator("field \"StateInTimeline\" of the FlightStatusBoardingInfo class", false);
            fieldGeneratorWaitingPeriod = new TimeDifferenceJSON.HoldingGenerator("field \"WaitingPeriod\" of the FlightStatusBoardingInfo class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatusBoardingInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorActualDateTime.reset();
            fieldGeneratorEstimatedDateTime.reset();
            fieldGeneratorScheduledDateTime.reset();
            fieldGeneratorOperationalDateTime.reset();
            fieldGeneratorOperationalDateTimeType.reset();
            fieldGeneratorDeviationFromScheduled.reset();
            fieldGeneratorStateInTimeline.reset();
            fieldGeneratorWaitingPeriod.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorActualDateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEstimatedDateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorScheduledDateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOperationalDateTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOperationalDateTimeType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDeviationFromScheduled.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStateInTimeline.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorWaitingPeriod.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorActualDateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEstimatedDateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorScheduledDateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOperationalDateTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOperationalDateTimeType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDeviationFromScheduled.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStateInTimeline.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorWaitingPeriod.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightStatusBoardingInfoJSON  result)
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
        public FlightStatusBoardingInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatusBoardingInfoJSON  result)
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
    protected virtual void handle_result(List<FlightStatusBoardingInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatusBoardingInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatusBoardingInfoJSON>();
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
    public List<FlightStatusBoardingInfoJSON> value;
  };
  };
