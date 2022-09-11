/* file "DateTimeSpecRangeSetOfTimeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DateTimeSpecRangeSetOfTimeJSON : SetOfTimeJSON
  {
    private bool flagHasStart;
    private DateTimeSpecJSON  storeStart;
    private bool flagHasEnd;
    private DateTimeSpecJSON  storeEnd;
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


    private JSONValue  extraStartToJSON()
      {
        JSONValueHandler handler_Start = new JSONValueHandler();
        storeStart.write_as_json(handler_Start);
        return handler_Start.result;
      }

    private JSONValue  extraEndToJSON()
      {
        JSONValueHandler handler_End = new JSONValueHandler();
        storeEnd.write_as_json(handler_End);
        return handler_End.result;
      }

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


    private void  fromJSONStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setStart(convert_classy);
      }


    private void  fromJSONEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeSpecJSON convert_classy = DateTimeSpecJSON.from_json(json_value, ignore_extras, true);
        setEnd(convert_classy);
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
                throw new Exception("The value for field StartDateTimeInferred of DateTimeSpecRangeSetOfTimeJSON is not true for false.");
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
                throw new Exception("The value for field EndDateTimeInferred of DateTimeSpecRangeSetOfTimeJSON is not true for false.");
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
                throw new Exception("The value for field RangeIsExplicit of DateTimeSpecRangeSetOfTimeJSON is not true for false.");
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
                throw new Exception("The value for field ExpressedAsDuration of DateTimeSpecRangeSetOfTimeJSON is not true for false.");
              }
          }
        setExpressedAsDuration(the_bool);
      }


    public DateTimeSpecRangeSetOfTimeJSON()
      {
        flagHasStart = false;
        flagHasEnd = false;
        flagHasStartDateTimeInferred = false;
        flagHasEndDateTimeInferred = false;
        flagHasRangeIsExplicit = false;
        flagHasExpressedAsDuration = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSetOfTimeKind()
      {
        return "DateTimeSpecRange";
      }

    public bool  hasStart()
      {
        return flagHasStart;
      }

    public DateTimeSpecJSON   getStart()
      {
        Debug.Assert(flagHasStart);
        return storeStart;
      }

    public bool  hasEnd()
      {
        return flagHasEnd;
      }

    public DateTimeSpecJSON   getEnd()
      {
        Debug.Assert(flagHasEnd);
        return storeEnd;
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


    public virtual int extraDateTimeSpecRangeSetOfTimeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDateTimeSpecRangeSetOfTimeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDateTimeSpecRangeSetOfTimeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDateTimeSpecRangeSetOfTimeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSetOfTimeComponentCount()
      {
        int result = 0;
        if (flagHasStart)
            ++result;
        if (flagHasEnd)
            ++result;
        if (flagHasStartDateTimeInferred)
            ++result;
        if (flagHasEndDateTimeInferred)
            ++result;
        if (flagHasRangeIsExplicit)
            ++result;
        if (flagHasExpressedAsDuration)
            ++result;
        result += extraDateTimeSpecRangeSetOfTimeComponentCount();
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
        if (flagHasEnd)
          {
            if (remainder == 0)
                return "End";
            --remainder;
          }
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
        return extraDateTimeSpecRangeSetOfTimeComponentKey(remainder);
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
        if (flagHasEnd)
          {
            if (remainder == 0)
                return extraEndToJSON();
            --remainder;
          }
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
        return extraDateTimeSpecRangeSetOfTimeComponentValue(remainder);
      }
    public override JSONValue extraSetOfTimeLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                switch (field_name[1])
                  {
                    case 'n':
                        if (String.Compare(field_name, 2, "d", 0, 1, false) == 0)
                          {
                            if (field_name.Length == 3)
                              {
                                return (flagHasEnd ? extraEndToJSON() : null);
                              }
                            switch (field_name[3])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 4, "ateTimeInferred", 0, 15, false) == 0) && (field_name.Length == 19))
                                        return (flagHasEndDateTimeInferred ? extraEndDateTimeInferredToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
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
                if (String.Compare(field_name, 1, "tart", 0, 4, false) == 0)
                  {
                    if (field_name.Length == 5)
                      {
                        return (flagHasStart ? extraStartToJSON() : null);
                      }
                    switch (field_name[5])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 6, "ateTimeInferred", 0, 15, false) == 0) && (field_name.Length == 21))
                                return (flagHasStartDateTimeInferred ? extraStartDateTimeInferredToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraDateTimeSpecRangeSetOfTimeLookup(field_name);
      }

    public void setStart(DateTimeSpecJSON  new_value)
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
    public void setEnd(DateTimeSpecJSON  new_value)
      {
        if (flagHasEnd)
          {
          }
        flagHasEnd = true;
        storeEnd = new_value;
      }
    public void unsetEnd()
      {
        if (flagHasEnd)
          {
          }
        flagHasEnd = false;
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

    public virtual void extraDateTimeSpecRangeSetOfTimeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDateTimeSpecRangeSetOfTimeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDateTimeSpecRangeSetOfTimeLookup(key);
        if (old_field == null)
          {
            extraDateTimeSpecRangeSetOfTimeAppendPair(key, new_component);
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
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if (String.Compare(key, 2, "d", 0, 1, false) == 0)
                          {
                            if (key.Length == 3)
                              {
                                {
                                fromJSONEnd(new_component, false);
                                return;
                                }
                              }
                            switch (key[3])
                              {
                                case 'D':
                                    if ((String.Compare(key, 4, "ateTimeInferred", 0, 15, false) == 0) && (key.Length == 19))
                                        {
                                        fromJSONEndDateTimeInferred(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
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
                if (String.Compare(key, 1, "tart", 0, 4, false) == 0)
                  {
                    if (key.Length == 5)
                      {
                        {
                        fromJSONStart(new_component, false);
                        return;
                        }
                      }
                    switch (key[5])
                      {
                        case 'D':
                            if ((String.Compare(key, 6, "ateTimeInferred", 0, 15, false) == 0) && (key.Length == 21))
                                {
                                fromJSONStartDateTimeInferred(new_component, false);
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
        extraDateTimeSpecRangeSetOfTimeAppendPair(key, new_component);
      }
    public override void extraSetOfTimeSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                switch (key[1])
                  {
                    case 'n':
                        if (String.Compare(key, 2, "d", 0, 1, false) == 0)
                          {
                            if (key.Length == 3)
                              {
                                {
                                fromJSONEnd(new_component, false);
                                return;
                                }
                              }
                            switch (key[3])
                              {
                                case 'D':
                                    if ((String.Compare(key, 4, "ateTimeInferred", 0, 15, false) == 0) && (key.Length == 19))
                                        {
                                        fromJSONEndDateTimeInferred(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
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
                if (String.Compare(key, 1, "tart", 0, 4, false) == 0)
                  {
                    if (key.Length == 5)
                      {
                        {
                        fromJSONStart(new_component, false);
                        return;
                        }
                      }
                    switch (key[5])
                      {
                        case 'D':
                            if ((String.Compare(key, 6, "ateTimeInferred", 0, 15, false) == 0) && (key.Length == 21))
                                {
                                fromJSONStartDateTimeInferred(new_component, false);
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
        extraDateTimeSpecRangeSetOfTimeSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasEnd);
        if (flagHasEnd)
          {
            handler.start_pair("End");
            if (partial_allowed)
                storeEnd.write_partial_as_json(handler);
            else
                storeEnd.write_as_json(handler);
          }
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
        if (!(hasStart()))
          {
            return "When parsing the object for %what%, the \"Start\" field was missing.";
          }
        if (!(hasEnd()))
          {
            return "When parsing the object for %what%, the \"End\" field was missing.";
          }
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

    public static new DateTimeSpecRangeSetOfTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateTimeSpecRangeSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateTimeSpecRangeSetOfTime", ignore_extras);
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
    public static new DateTimeSpecRangeSetOfTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DateTimeSpecRangeSetOfTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateTimeSpecRangeSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateTimeSpecRangeSetOfTime", ignore_extras);
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
    public static new DateTimeSpecRangeSetOfTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DateTimeSpecRangeSetOfTimeJSON from_text(string text, bool ignore_extras)
      {
        DateTimeSpecRangeSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateTimeSpecRangeSetOfTime", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DateTimeSpecRangeSetOfTimeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DateTimeSpecRangeSetOfTimeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DateTimeSpecRangeSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateTimeSpecRangeSetOfTime", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SetOfTimeJSON.Generator
      {
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorStart;
        private DateTimeSpecJSON.HoldingGenerator fieldGeneratorEnd;
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
            if (!(getSetOfTimeJSONKey().Equals("DateTimeSpecRange")))
                throw new Exception("The key field has a value other than `DateTimeSpecRange'.");
            DateTimeSpecRangeSetOfTimeJSON result = new DateTimeSpecRangeSetOfTimeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDateTimeSpecRangeSetOfTimeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SetOfTimeJSON new_result)
          {
            handle_result((DateTimeSpecRangeSetOfTimeJSON )new_result);
          }
        protected void finish(DateTimeSpecRangeSetOfTimeJSON result)
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
            if (fieldGeneratorEnd.have_value)
              {
                result.setEnd(fieldGeneratorEnd.value);
                fieldGeneratorEnd.have_value = false;
              }
            else if ((!(result.hasEnd())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"End\" field was missing.");
              }
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
        protected abstract void handle_result(DateTimeSpecRangeSetOfTimeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    switch (field_name[1])
                      {
                        case 'n':
                            if (String.Compare(field_name, 2, "d", 0, 1, false) == 0)
                              {
                                if (field_name.Length == 3)
                                  {
                                    return fieldGeneratorEnd;
                                  }
                                switch (field_name[3])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 4, "ateTimeInferred", 0, 15, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorEndDateTimeInferred;
                                        break;
                                    default:
                                        break;
                                  }
                              }
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
                    if (String.Compare(field_name, 1, "tart", 0, 4, false) == 0)
                      {
                        if (field_name.Length == 5)
                          {
                            return fieldGeneratorStart;
                          }
                        switch (field_name[5])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 6, "ateTimeInferred", 0, 15, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorStartDateTimeInferred;
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
            fieldGeneratorStart = new DateTimeSpecJSON.HoldingGenerator("field \"Start\" of the DateTimeSpecRangeSetOfTime class", ignore_extras);
            fieldGeneratorEnd = new DateTimeSpecJSON.HoldingGenerator("field \"End\" of the DateTimeSpecRangeSetOfTime class", ignore_extras);
            fieldGeneratorStartDateTimeInferred = new JSONHoldingBooleanGenerator("field \"StartDateTimeInferred\" of the DateTimeSpecRangeSetOfTime class");
            fieldGeneratorEndDateTimeInferred = new JSONHoldingBooleanGenerator("field \"EndDateTimeInferred\" of the DateTimeSpecRangeSetOfTime class");
            fieldGeneratorRangeIsExplicit = new JSONHoldingBooleanGenerator("field \"RangeIsExplicit\" of the DateTimeSpecRangeSetOfTime class");
            fieldGeneratorExpressedAsDuration = new JSONHoldingBooleanGenerator("field \"ExpressedAsDuration\" of the DateTimeSpecRangeSetOfTime class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DateTimeSpecRangeSetOfTime class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorStart = new DateTimeSpecJSON.HoldingGenerator("field \"Start\" of the DateTimeSpecRangeSetOfTime class", false);
            fieldGeneratorEnd = new DateTimeSpecJSON.HoldingGenerator("field \"End\" of the DateTimeSpecRangeSetOfTime class", false);
            fieldGeneratorStartDateTimeInferred = new JSONHoldingBooleanGenerator("field \"StartDateTimeInferred\" of the DateTimeSpecRangeSetOfTime class");
            fieldGeneratorEndDateTimeInferred = new JSONHoldingBooleanGenerator("field \"EndDateTimeInferred\" of the DateTimeSpecRangeSetOfTime class");
            fieldGeneratorRangeIsExplicit = new JSONHoldingBooleanGenerator("field \"RangeIsExplicit\" of the DateTimeSpecRangeSetOfTime class");
            fieldGeneratorExpressedAsDuration = new JSONHoldingBooleanGenerator("field \"ExpressedAsDuration\" of the DateTimeSpecRangeSetOfTime class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DateTimeSpecRangeSetOfTime class");
          }

        public override void reset()
          {
            fieldGeneratorStart.reset();
            fieldGeneratorEnd.reset();
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
        protected override void handle_result(DateTimeSpecRangeSetOfTimeJSON  result)
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
        public DateTimeSpecRangeSetOfTimeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DateTimeSpecRangeSetOfTimeJSON  result)
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
    protected virtual void handle_result(List<DateTimeSpecRangeSetOfTimeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DateTimeSpecRangeSetOfTimeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DateTimeSpecRangeSetOfTimeJSON>();
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
    public List<DateTimeSpecRangeSetOfTimeJSON> value;
  };
  };
