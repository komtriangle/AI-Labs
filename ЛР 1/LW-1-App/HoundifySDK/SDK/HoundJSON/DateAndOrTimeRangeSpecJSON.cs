/* file "DateAndOrTimeRangeSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DateAndOrTimeRangeSpecJSON : WhenJSON
  {
    private bool flagHasStartDateTimeInferred;
    private bool storeStartDateTimeInferred;
    private bool flagHasEndDateTimeInferred;
    private bool storeEndDateTimeInferred;
    private bool flagHasRangeIsExplicit;
    private bool storeRangeIsExplicit;
    private bool flagHasExpressedAsDuration;
    private bool storeExpressedAsDuration;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraStartDateTimeInferredToJSON()
      {
        JSONValue generated_boolean_StartDateTimeInferred = (storeStartDateTimeInferred ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_StartDateTimeInferred;
      }

    private JSONValue  extraEndDateTimeInferredToJSON()
      {
        JSONValue generated_boolean_EndDateTimeInferred = (storeEndDateTimeInferred ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_EndDateTimeInferred;
      }

    private JSONValue  extraRangeIsExplicitToJSON()
      {
        JSONValue generated_boolean_RangeIsExplicit = (storeRangeIsExplicit ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_RangeIsExplicit;
      }

    private JSONValue  extraExpressedAsDurationToJSON()
      {
        JSONValue generated_boolean_ExpressedAsDuration = (storeExpressedAsDuration ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ExpressedAsDuration;
      }


    private void  fromJSONStartDateTimeInferred(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StartDateTimeInferred of DateAndOrTimeRangeSpecJSON is not true for false.");
              }
          }
        setStartDateTimeInferred(the_bool);
      }


    private void  fromJSONEndDateTimeInferred(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field EndDateTimeInferred of DateAndOrTimeRangeSpecJSON is not true for false.");
              }
          }
        setEndDateTimeInferred(the_bool);
      }


    private void  fromJSONRangeIsExplicit(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RangeIsExplicit of DateAndOrTimeRangeSpecJSON is not true for false.");
              }
          }
        setRangeIsExplicit(the_bool);
      }


    private void  fromJSONExpressedAsDuration(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ExpressedAsDuration of DateAndOrTimeRangeSpecJSON is not true for false.");
              }
          }
        setExpressedAsDuration(the_bool);
      }


    public DateAndOrTimeRangeSpecJSON()
      {
        flagHasStartDateTimeInferred = false;
        flagHasEndDateTimeInferred = false;
        flagHasRangeIsExplicit = false;
        flagHasExpressedAsDuration = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStartDateTimeInferred()
      {
        return flagHasStartDateTimeInferred;
      }

    public bool  getStartDateTimeInferred()
      {
        Debug.Assert(flagHasStartDateTimeInferred);
        return storeStartDateTimeInferred;
      }

    public bool  hasEndDateTimeInferred()
      {
        return flagHasEndDateTimeInferred;
      }

    public bool  getEndDateTimeInferred()
      {
        Debug.Assert(flagHasEndDateTimeInferred);
        return storeEndDateTimeInferred;
      }

    public bool  hasRangeIsExplicit()
      {
        return flagHasRangeIsExplicit;
      }

    public bool  getRangeIsExplicit()
      {
        Debug.Assert(flagHasRangeIsExplicit);
        return storeRangeIsExplicit;
      }

    public bool  hasExpressedAsDuration()
      {
        return flagHasExpressedAsDuration;
      }

    public bool  getExpressedAsDuration()
      {
        Debug.Assert(flagHasExpressedAsDuration);
        return storeExpressedAsDuration;
      }


    public virtual int extraDateAndOrTimeRangeSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDateAndOrTimeRangeSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDateAndOrTimeRangeSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDateAndOrTimeRangeSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraWhenComponentCount()
      {
        int result = 0;
        if (flagHasStartDateTimeInferred)
            ++result;
        if (flagHasEndDateTimeInferred)
            ++result;
        if (flagHasRangeIsExplicit)
            ++result;
        if (flagHasExpressedAsDuration)
            ++result;
        result += extraDateAndOrTimeRangeSpecComponentCount();
        return result;
      }
    public override string extraWhenComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasStartDateTimeInferred)
          {
            if (remainder == 0)
                return "StartDateTimeInferred";
            --remainder;
          }
        if (flagHasEndDateTimeInferred)
          {
            if (remainder == 0)
                return "EndDateTimeInferred";
            --remainder;
          }
        if (flagHasRangeIsExplicit)
          {
            if (remainder == 0)
                return "RangeIsExplicit";
            --remainder;
          }
        if (flagHasExpressedAsDuration)
          {
            if (remainder == 0)
                return "ExpressedAsDuration";
            --remainder;
          }
        return extraDateAndOrTimeRangeSpecComponentKey(remainder);
      }
    public override JSONValue extraWhenComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasStartDateTimeInferred)
          {
            if (remainder == 0)
                return extraStartDateTimeInferredToJSON();
            --remainder;
          }
        if (flagHasEndDateTimeInferred)
          {
            if (remainder == 0)
                return extraEndDateTimeInferredToJSON();
            --remainder;
          }
        if (flagHasRangeIsExplicit)
          {
            if (remainder == 0)
                return extraRangeIsExplicitToJSON();
            --remainder;
          }
        if (flagHasExpressedAsDuration)
          {
            if (remainder == 0)
                return extraExpressedAsDurationToJSON();
            --remainder;
          }
        return extraDateAndOrTimeRangeSpecComponentValue(remainder);
      }
    public override JSONValue extraWhenLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                switch (field_name[1])
                  {
                    case 'n':
                        if ((String.Compare(field_name, 2, "dDateTimeInferred", 0, 17, false) == 0) && (field_name.Length == 19))
                            return (flagHasEndDateTimeInferred ? extraEndDateTimeInferredToJSON() : null);
                        break;
                    case 'x':
                        if ((String.Compare(field_name, 2, "pressedAsDuration", 0, 17, false) == 0) && (field_name.Length == 19))
                            return (flagHasExpressedAsDuration ? extraExpressedAsDurationToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "angeIsExplicit", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasRangeIsExplicit ? extraRangeIsExplicitToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tartDateTimeInferred", 0, 20, false) == 0) && (field_name.Length == 21))
                    return (flagHasStartDateTimeInferred ? extraStartDateTimeInferredToJSON() : null);
                break;
            default:
                break;
          }
        return extraDateAndOrTimeRangeSpecLookup(field_name);
      }

    public void setStartDateTimeInferred(bool new_value)
      {
        flagHasStartDateTimeInferred = true;
        storeStartDateTimeInferred = new_value;
      }
    public void unsetStartDateTimeInferred()
      {
        flagHasStartDateTimeInferred = false;
      }
    public void setEndDateTimeInferred(bool new_value)
      {
        flagHasEndDateTimeInferred = true;
        storeEndDateTimeInferred = new_value;
      }
    public void unsetEndDateTimeInferred()
      {
        flagHasEndDateTimeInferred = false;
      }
    public void setRangeIsExplicit(bool new_value)
      {
        flagHasRangeIsExplicit = true;
        storeRangeIsExplicit = new_value;
      }
    public void unsetRangeIsExplicit()
      {
        flagHasRangeIsExplicit = false;
      }
    public void setExpressedAsDuration(bool new_value)
      {
        flagHasExpressedAsDuration = true;
        storeExpressedAsDuration = new_value;
      }
    public void unsetExpressedAsDuration()
      {
        flagHasExpressedAsDuration = false;
      }

    public virtual void extraDateAndOrTimeRangeSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDateAndOrTimeRangeSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDateAndOrTimeRangeSpecLookup(key);
        if (old_field == null)
          {
            extraDateAndOrTimeRangeSpecAppendPair(key, new_component);
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
    public override void extraWhenAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if ((String.Compare(key, 2, "dDateTimeInferred", 0, 17, false) == 0) && (key.Length == 19))
                            {
                            fromJSONEndDateTimeInferred(new_component, false);
                            return;
                            }
                        break;
                    case 'x':
                        if ((String.Compare(key, 2, "pressedAsDuration", 0, 17, false) == 0) && (key.Length == 19))
                            {
                            fromJSONExpressedAsDuration(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "angeIsExplicit", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONRangeIsExplicit(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartDateTimeInferred", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONStartDateTimeInferred(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDateAndOrTimeRangeSpecAppendPair(key, new_component);
      }
    public override void extraWhenSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if ((String.Compare(key, 2, "dDateTimeInferred", 0, 17, false) == 0) && (key.Length == 19))
                            {
                            fromJSONEndDateTimeInferred(new_component, false);
                            return;
                            }
                        break;
                    case 'x':
                        if ((String.Compare(key, 2, "pressedAsDuration", 0, 17, false) == 0) && (key.Length == 19))
                            {
                            fromJSONExpressedAsDuration(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                if ((String.Compare(key, 1, "angeIsExplicit", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONRangeIsExplicit(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartDateTimeInferred", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONStartDateTimeInferred(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraDateAndOrTimeRangeSpecSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStartDateTimeInferred);
        if (flagHasStartDateTimeInferred)
          {
            handler.start_pair("StartDateTimeInferred");
            handler.boolean_value(storeStartDateTimeInferred);
          }
        Debug.Assert(partial_allowed || flagHasEndDateTimeInferred);
        if (flagHasEndDateTimeInferred)
          {
            handler.start_pair("EndDateTimeInferred");
            handler.boolean_value(storeEndDateTimeInferred);
          }
        Debug.Assert(partial_allowed || flagHasRangeIsExplicit);
        if (flagHasRangeIsExplicit)
          {
            handler.start_pair("RangeIsExplicit");
            handler.boolean_value(storeRangeIsExplicit);
          }
        Debug.Assert(partial_allowed || flagHasExpressedAsDuration);
        if (flagHasExpressedAsDuration)
          {
            handler.start_pair("ExpressedAsDuration");
            handler.boolean_value(storeExpressedAsDuration);
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
        if (!(hasStartDateTimeInferred()))
          {
            return "When parsing the object for %what%, the \"StartDateTimeInferred\" field was missing.";
          }
        if (!(hasEndDateTimeInferred()))
          {
            return "When parsing the object for %what%, the \"EndDateTimeInferred\" field was missing.";
          }
        if (!(hasRangeIsExplicit()))
          {
            return "When parsing the object for %what%, the \"RangeIsExplicit\" field was missing.";
          }
        if (!(hasExpressedAsDuration()))
          {
            return "When parsing the object for %what%, the \"ExpressedAsDuration\" field was missing.";
          }
        return null;
      }

    public static new DateAndOrTimeRangeSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateAndOrTimeRangeSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndOrTimeRangeSpec", ignore_extras);
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
    public static new DateAndOrTimeRangeSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DateAndOrTimeRangeSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateAndOrTimeRangeSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndOrTimeRangeSpec", ignore_extras);
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
    public static new DateAndOrTimeRangeSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DateAndOrTimeRangeSpecJSON from_text(string text, bool ignore_extras)
      {
        DateAndOrTimeRangeSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndOrTimeRangeSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DateAndOrTimeRangeSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DateAndOrTimeRangeSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DateAndOrTimeRangeSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndOrTimeRangeSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : WhenJSON.Generator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorStartDateTimeInferred;
        private JSONHoldingBooleanGenerator fieldGeneratorEndDateTimeInferred;
        private JSONHoldingBooleanGenerator fieldGeneratorRangeIsExplicit;
        private JSONHoldingBooleanGenerator fieldGeneratorExpressedAsDuration;
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
            DateAndOrTimeRangeSpecJSON result = new DateAndOrTimeRangeSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDateAndOrTimeRangeSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(WhenJSON new_result)
          {
            handle_result((DateAndOrTimeRangeSpecJSON )new_result);
          }
        protected void finish(DateAndOrTimeRangeSpecJSON result)
          {
            if (fieldGeneratorStartDateTimeInferred.have_value)
              {
                result.setStartDateTimeInferred(fieldGeneratorStartDateTimeInferred.value);
                fieldGeneratorStartDateTimeInferred.have_value = false;
              }
            else if ((!(result.hasStartDateTimeInferred())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartDateTimeInferred\" field was missing.");
              }
            if (fieldGeneratorEndDateTimeInferred.have_value)
              {
                result.setEndDateTimeInferred(fieldGeneratorEndDateTimeInferred.value);
                fieldGeneratorEndDateTimeInferred.have_value = false;
              }
            else if ((!(result.hasEndDateTimeInferred())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EndDateTimeInferred\" field was missing.");
              }
            if (fieldGeneratorRangeIsExplicit.have_value)
              {
                result.setRangeIsExplicit(fieldGeneratorRangeIsExplicit.value);
                fieldGeneratorRangeIsExplicit.have_value = false;
              }
            else if ((!(result.hasRangeIsExplicit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RangeIsExplicit\" field was missing.");
              }
            if (fieldGeneratorExpressedAsDuration.have_value)
              {
                result.setExpressedAsDuration(fieldGeneratorExpressedAsDuration.value);
                fieldGeneratorExpressedAsDuration.have_value = false;
              }
            else if ((!(result.hasExpressedAsDuration())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ExpressedAsDuration\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(DateAndOrTimeRangeSpecJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    switch (field_name[1])
                      {
                        case 'n':
                            if ((String.Compare(field_name, 2, "dDateTimeInferred", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorEndDateTimeInferred;
                            break;
                        case 'x':
                            if ((String.Compare(field_name, 2, "pressedAsDuration", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorExpressedAsDuration;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "angeIsExplicit", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorRangeIsExplicit;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tartDateTimeInferred", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorStartDateTimeInferred;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorStartDateTimeInferred = new JSONHoldingBooleanGenerator("field \"StartDateTimeInferred\" of the DateAndOrTimeRangeSpec class");
            fieldGeneratorEndDateTimeInferred = new JSONHoldingBooleanGenerator("field \"EndDateTimeInferred\" of the DateAndOrTimeRangeSpec class");
            fieldGeneratorRangeIsExplicit = new JSONHoldingBooleanGenerator("field \"RangeIsExplicit\" of the DateAndOrTimeRangeSpec class");
            fieldGeneratorExpressedAsDuration = new JSONHoldingBooleanGenerator("field \"ExpressedAsDuration\" of the DateAndOrTimeRangeSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DateAndOrTimeRangeSpec class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorStartDateTimeInferred = new JSONHoldingBooleanGenerator("field \"StartDateTimeInferred\" of the DateAndOrTimeRangeSpec class");
            fieldGeneratorEndDateTimeInferred = new JSONHoldingBooleanGenerator("field \"EndDateTimeInferred\" of the DateAndOrTimeRangeSpec class");
            fieldGeneratorRangeIsExplicit = new JSONHoldingBooleanGenerator("field \"RangeIsExplicit\" of the DateAndOrTimeRangeSpec class");
            fieldGeneratorExpressedAsDuration = new JSONHoldingBooleanGenerator("field \"ExpressedAsDuration\" of the DateAndOrTimeRangeSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DateAndOrTimeRangeSpec class");
          }

        public override void reset()
          {
            fieldGeneratorStartDateTimeInferred.reset();
            fieldGeneratorEndDateTimeInferred.reset();
            fieldGeneratorRangeIsExplicit.reset();
            fieldGeneratorExpressedAsDuration.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DateAndOrTimeRangeSpecJSON  result)
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
        public DateAndOrTimeRangeSpecJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DateAndOrTimeRangeSpecJSON  result)
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
    protected virtual void handle_result(List<DateAndOrTimeRangeSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DateAndOrTimeRangeSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DateAndOrTimeRangeSpecJSON>();
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
    public List<DateAndOrTimeRangeSpecJSON> value;
  };
    public static DateAndOrTimeRangeSpecJSON from_WhenJSON_json(WhenJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        DateAndOrTimeRangeSpecJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type DateAndOrTimeRangeSpec", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
