/* file "StartPlusDurationSetOfTimeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class StartPlusDurationSetOfTimeJSON : SetOfTimeJSON
  {
    private bool flagHasStart;
    private PointInTimeJSON  storeStart;
    private bool flagHasDuration;
    private AmountJSON  storeDuration;
    private bool flagHasIncludesStart;
    private bool storeIncludesStart;
    private bool flagHasIncludesEnd;
    private bool storeIncludesEnd;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraStartToJSON()
      {
        JSONValueHandler handler_Start = new JSONValueHandler();
        storeStart.write_as_json(handler_Start);
        return handler_Start.result;
      }

    private JSONValue  extraDurationToJSON()
      {
        JSONValueHandler handler_Duration = new JSONValueHandler();
        storeDuration.write_as_json(handler_Duration);
        return handler_Duration.result;
      }

    private JSONValue  extraIncludesStartToJSON()
      {
        JSONValue generated_boolean_IncludesStart = (storeIncludesStart ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IncludesStart;
      }

    private JSONValue  extraIncludesEndToJSON()
      {
        JSONValue generated_boolean_IncludesEnd = (storeIncludesEnd ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IncludesEnd;
      }


    private void  fromJSONStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PointInTimeJSON convert_classy = PointInTimeJSON.from_json(json_value, ignore_extras, true);
        setStart(convert_classy);
      }


    private void  fromJSONDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setDuration(convert_classy);
      }


    private void  fromJSONIncludesStart(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IncludesStart of StartPlusDurationSetOfTimeJSON is not true for false.");
              }
          }
        setIncludesStart(the_bool);
      }


    private void  fromJSONIncludesEnd(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IncludesEnd of StartPlusDurationSetOfTimeJSON is not true for false.");
              }
          }
        setIncludesEnd(the_bool);
      }


    public StartPlusDurationSetOfTimeJSON()
      {
        flagHasStart = false;
        flagHasDuration = false;
        flagHasIncludesStart = false;
        flagHasIncludesEnd = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSetOfTimeKind()
      {
        return "StartPlusDuration";
      }

    public bool  hasStart()
      {
        return flagHasStart;
      }

    public PointInTimeJSON   getStart()
      {
        Debug.Assert(flagHasStart);
        return storeStart;
      }

    public bool  hasDuration()
      {
        return flagHasDuration;
      }

    public AmountJSON   getDuration()
      {
        Debug.Assert(flagHasDuration);
        return storeDuration;
      }

    public bool  hasIncludesStart()
      {
        return flagHasIncludesStart;
      }

    public bool  getIncludesStart()
      {
        Debug.Assert(flagHasIncludesStart);
        return storeIncludesStart;
      }

    public bool  hasIncludesEnd()
      {
        return flagHasIncludesEnd;
      }

    public bool  getIncludesEnd()
      {
        Debug.Assert(flagHasIncludesEnd);
        return storeIncludesEnd;
      }


    public virtual int extraStartPlusDurationSetOfTimeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraStartPlusDurationSetOfTimeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraStartPlusDurationSetOfTimeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraStartPlusDurationSetOfTimeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSetOfTimeComponentCount()
      {
        int result = 0;
        if (flagHasStart)
            ++result;
        if (flagHasDuration)
            ++result;
        if (flagHasIncludesStart)
            ++result;
        if (flagHasIncludesEnd)
            ++result;
        result += extraStartPlusDurationSetOfTimeComponentCount();
        return result;
      }
    public override string extraSetOfTimeComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasStart)
          {
            if (remainder == 0)
                return "Start";
            --remainder;
          }
        if (flagHasDuration)
          {
            if (remainder == 0)
                return "Duration";
            --remainder;
          }
        if (flagHasIncludesStart)
          {
            if (remainder == 0)
                return "IncludesStart";
            --remainder;
          }
        if (flagHasIncludesEnd)
          {
            if (remainder == 0)
                return "IncludesEnd";
            --remainder;
          }
        return extraStartPlusDurationSetOfTimeComponentKey(remainder);
      }
    public override JSONValue extraSetOfTimeComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasStart)
          {
            if (remainder == 0)
                return extraStartToJSON();
            --remainder;
          }
        if (flagHasDuration)
          {
            if (remainder == 0)
                return extraDurationToJSON();
            --remainder;
          }
        if (flagHasIncludesStart)
          {
            if (remainder == 0)
                return extraIncludesStartToJSON();
            --remainder;
          }
        if (flagHasIncludesEnd)
          {
            if (remainder == 0)
                return extraIncludesEndToJSON();
            --remainder;
          }
        return extraStartPlusDurationSetOfTimeComponentValue(remainder);
      }
    public override JSONValue extraSetOfTimeLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "uration", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasDuration ? extraDurationToJSON() : null);
                break;
            case 'I':
                if (String.Compare(field_name, 1, "ncludes", 0, 7, false) == 0)
                  {
                    switch (field_name[8])
                      {
                        case 'E':
                            if ((String.Compare(field_name, 9, "nd", 0, 2, false) == 0) && (field_name.Length == 11))
                                return (flagHasIncludesEnd ? extraIncludesEndToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 9, "tart", 0, 4, false) == 0) && (field_name.Length == 13))
                                return (flagHasIncludesStart ? extraIncludesStartToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tart", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasStart ? extraStartToJSON() : null);
                break;
            default:
                break;
          }
        return extraStartPlusDurationSetOfTimeLookup(field_name);
      }

    public void setStart(PointInTimeJSON  new_value)
      {
        if (flagHasStart)
          {
          }
        flagHasStart = true;
        storeStart = new_value;
      }
    public void unsetStart()
      {
        if (flagHasStart)
          {
          }
        flagHasStart = false;
      }
    public void setDuration(AmountJSON  new_value)
      {
        if (flagHasDuration)
          {
          }
        flagHasDuration = true;
        storeDuration = new_value;
      }
    public void unsetDuration()
      {
        if (flagHasDuration)
          {
          }
        flagHasDuration = false;
      }
    public void setIncludesStart(bool new_value)
      {
        flagHasIncludesStart = true;
        storeIncludesStart = new_value;
      }
    public void unsetIncludesStart()
      {
        flagHasIncludesStart = false;
      }
    public void setIncludesEnd(bool new_value)
      {
        flagHasIncludesEnd = true;
        storeIncludesEnd = new_value;
      }
    public void unsetIncludesEnd()
      {
        flagHasIncludesEnd = false;
      }

    public virtual void extraStartPlusDurationSetOfTimeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraStartPlusDurationSetOfTimeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraStartPlusDurationSetOfTimeLookup(key);
        if (old_field == null)
          {
            extraStartPlusDurationSetOfTimeAppendPair(key, new_component);
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
    public override void extraSetOfTimeAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "uration", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONDuration(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if (String.Compare(key, 1, "ncludes", 0, 7, false) == 0)
                  {
                    switch (key[8])
                      {
                        case 'E':
                            if ((String.Compare(key, 9, "nd", 0, 2, false) == 0) && (key.Length == 11))
                                {
                                fromJSONIncludesEnd(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 9, "tart", 0, 4, false) == 0) && (key.Length == 13))
                                {
                                fromJSONIncludesStart(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tart", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONStart(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraStartPlusDurationSetOfTimeAppendPair(key, new_component);
      }
    public override void extraSetOfTimeSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "uration", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONDuration(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if (String.Compare(key, 1, "ncludes", 0, 7, false) == 0)
                  {
                    switch (key[8])
                      {
                        case 'E':
                            if ((String.Compare(key, 9, "nd", 0, 2, false) == 0) && (key.Length == 11))
                                {
                                fromJSONIncludesEnd(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 9, "tart", 0, 4, false) == 0) && (key.Length == 13))
                                {
                                fromJSONIncludesStart(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tart", 0, 4, false) == 0) && (key.Length == 5))
                    {
                    fromJSONStart(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraStartPlusDurationSetOfTimeSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStart);
        if (flagHasStart)
          {
            handler.start_pair("Start");
            if (partial_allowed)
                storeStart.write_partial_as_json(handler);
            else
                storeStart.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDuration);
        if (flagHasDuration)
          {
            handler.start_pair("Duration");
            if (partial_allowed)
                storeDuration.write_partial_as_json(handler);
            else
                storeDuration.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasIncludesStart);
        if (flagHasIncludesStart)
          {
            handler.start_pair("IncludesStart");
            handler.boolean_value(storeIncludesStart);
          }
        Debug.Assert(partial_allowed || flagHasIncludesEnd);
        if (flagHasIncludesEnd)
          {
            handler.start_pair("IncludesEnd");
            handler.boolean_value(storeIncludesEnd);
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
        if (!(hasStart()))
          {
            return "When parsing the object for %what%, the \"Start\" field was missing.";
          }
        if (!(hasDuration()))
          {
            return "When parsing the object for %what%, the \"Duration\" field was missing.";
          }
        if (!(hasIncludesStart()))
          {
            return "When parsing the object for %what%, the \"IncludesStart\" field was missing.";
          }
        if (!(hasIncludesEnd()))
          {
            return "When parsing the object for %what%, the \"IncludesEnd\" field was missing.";
          }
        return null;
      }

    public static new StartPlusDurationSetOfTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StartPlusDurationSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StartPlusDurationSetOfTime", ignore_extras);
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
    public static new StartPlusDurationSetOfTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StartPlusDurationSetOfTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        StartPlusDurationSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StartPlusDurationSetOfTime", ignore_extras);
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
    public static new StartPlusDurationSetOfTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new StartPlusDurationSetOfTimeJSON from_text(string text, bool ignore_extras)
      {
        StartPlusDurationSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StartPlusDurationSetOfTime", ignore_extras);
            JSONParse.parse_json_value(text, "Text for StartPlusDurationSetOfTimeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new StartPlusDurationSetOfTimeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        StartPlusDurationSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type StartPlusDurationSetOfTime", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SetOfTimeJSON.Generator
      {
        private PointInTimeJSON.HoldingGenerator fieldGeneratorStart;
        private AmountJSON.HoldingGenerator fieldGeneratorDuration;
        private JSONHoldingBooleanGenerator fieldGeneratorIncludesStart;
        private JSONHoldingBooleanGenerator fieldGeneratorIncludesEnd;
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
            if (!(getSetOfTimeJSONKey().Equals("StartPlusDuration")))
                throw new Exception("The key field has a value other than `StartPlusDuration'.");
            StartPlusDurationSetOfTimeJSON result = new StartPlusDurationSetOfTimeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraStartPlusDurationSetOfTimeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SetOfTimeJSON new_result)
          {
            handle_result((StartPlusDurationSetOfTimeJSON )new_result);
          }
        protected void finish(StartPlusDurationSetOfTimeJSON result)
          {
            if (fieldGeneratorStart.have_value)
              {
                result.setStart(fieldGeneratorStart.value);
                fieldGeneratorStart.have_value = false;
              }
            else if ((!(result.hasStart())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Start\" field was missing.");
              }
            if (fieldGeneratorDuration.have_value)
              {
                result.setDuration(fieldGeneratorDuration.value);
                fieldGeneratorDuration.have_value = false;
              }
            else if ((!(result.hasDuration())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Duration\" field was missing.");
              }
            if (fieldGeneratorIncludesStart.have_value)
              {
                result.setIncludesStart(fieldGeneratorIncludesStart.value);
                fieldGeneratorIncludesStart.have_value = false;
              }
            else if ((!(result.hasIncludesStart())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IncludesStart\" field was missing.");
              }
            if (fieldGeneratorIncludesEnd.have_value)
              {
                result.setIncludesEnd(fieldGeneratorIncludesEnd.value);
                fieldGeneratorIncludesEnd.have_value = false;
              }
            else if ((!(result.hasIncludesEnd())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IncludesEnd\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(StartPlusDurationSetOfTimeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "uration", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorDuration;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "ncludes", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 9, "nd", 0, 2, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorIncludesEnd;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 9, "tart", 0, 4, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorIncludesStart;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tart", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorStart;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorStart = new PointInTimeJSON.HoldingGenerator("field \"Start\" of the StartPlusDurationSetOfTime class", ignore_extras);
            fieldGeneratorDuration = new AmountJSON.HoldingGenerator("field \"Duration\" of the StartPlusDurationSetOfTime class", ignore_extras);
            fieldGeneratorIncludesStart = new JSONHoldingBooleanGenerator("field \"IncludesStart\" of the StartPlusDurationSetOfTime class");
            fieldGeneratorIncludesEnd = new JSONHoldingBooleanGenerator("field \"IncludesEnd\" of the StartPlusDurationSetOfTime class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the StartPlusDurationSetOfTime class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorStart = new PointInTimeJSON.HoldingGenerator("field \"Start\" of the StartPlusDurationSetOfTime class", false);
            fieldGeneratorDuration = new AmountJSON.HoldingGenerator("field \"Duration\" of the StartPlusDurationSetOfTime class", false);
            fieldGeneratorIncludesStart = new JSONHoldingBooleanGenerator("field \"IncludesStart\" of the StartPlusDurationSetOfTime class");
            fieldGeneratorIncludesEnd = new JSONHoldingBooleanGenerator("field \"IncludesEnd\" of the StartPlusDurationSetOfTime class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the StartPlusDurationSetOfTime class");
          }

        public override void reset()
          {
            fieldGeneratorStart.reset();
            fieldGeneratorDuration.reset();
            fieldGeneratorIncludesStart.reset();
            fieldGeneratorIncludesEnd.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(StartPlusDurationSetOfTimeJSON  result)
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
        public StartPlusDurationSetOfTimeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(StartPlusDurationSetOfTimeJSON  result)
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
    protected virtual void handle_result(List<StartPlusDurationSetOfTimeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<StartPlusDurationSetOfTimeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<StartPlusDurationSetOfTimeJSON>();
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
    public List<StartPlusDurationSetOfTimeJSON> value;
  };
  };
