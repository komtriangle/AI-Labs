/* file "MortgageCalculatorTimePointJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorTimePointJSON : JSONBase
  {
    public enum TypeRelativeSymbolicTimePointKnownValues
      {
        RelativeSymbolicTimePoint_Start,
        RelativeSymbolicTimePoint_End,
        RelativeSymbolicTimePoint__none
      };
    public struct TypeRelativeSymbolicTimePoint
      {
        public bool in_known_list;
        public string string_value;
        public TypeRelativeSymbolicTimePointKnownValues list_value;
      };

    public static TypeRelativeSymbolicTimePointKnownValues  stringToRelativeSymbolicTimePoint(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if ((String.Compare(chars, 1, "nd", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeRelativeSymbolicTimePointKnownValues.RelativeSymbolicTimePoint_End;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "tart", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeRelativeSymbolicTimePointKnownValues.RelativeSymbolicTimePoint_Start;
                break;
            default:
                break;
          }
        return TypeRelativeSymbolicTimePointKnownValues.RelativeSymbolicTimePoint__none;
      }

    public static string  stringFromRelativeSymbolicTimePoint(TypeRelativeSymbolicTimePointKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeRelativeSymbolicTimePointKnownValues.RelativeSymbolicTimePoint_Start:
                return "Start";
            case TypeRelativeSymbolicTimePointKnownValues.RelativeSymbolicTimePoint_End:
                return "End";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeDurationDirectionFromRelativeSymbolicPointKnownValues
      {
        DurationDirectionFromRelativeSymbolicPoint_Forward,
        DurationDirectionFromRelativeSymbolicPoint_Backward,
        DurationDirectionFromRelativeSymbolicPoint__none
      };
    public struct TypeDurationDirectionFromRelativeSymbolicPoint
      {
        public bool in_known_list;
        public string string_value;
        public TypeDurationDirectionFromRelativeSymbolicPointKnownValues list_value;
      };

    public static TypeDurationDirectionFromRelativeSymbolicPointKnownValues  stringToDurationDirectionFromRelativeSymbolicPoint(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "ackward", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeDurationDirectionFromRelativeSymbolicPointKnownValues.DurationDirectionFromRelativeSymbolicPoint_Backward;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "orward", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeDurationDirectionFromRelativeSymbolicPointKnownValues.DurationDirectionFromRelativeSymbolicPoint_Forward;
                break;
            default:
                break;
          }
        return TypeDurationDirectionFromRelativeSymbolicPointKnownValues.DurationDirectionFromRelativeSymbolicPoint__none;
      }

    public static string  stringFromDurationDirectionFromRelativeSymbolicPoint(TypeDurationDirectionFromRelativeSymbolicPointKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeDurationDirectionFromRelativeSymbolicPointKnownValues.DurationDirectionFromRelativeSymbolicPoint_Forward:
                return "Forward";
            case TypeDurationDirectionFromRelativeSymbolicPointKnownValues.DurationDirectionFromRelativeSymbolicPoint_Backward:
                return "Backward";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasRelativeSymbolicTimePoint;
    private TypeRelativeSymbolicTimePoint storeRelativeSymbolicTimePoint;
    private bool flagHasDurationDirectionFromRelativeSymbolicPoint;
    private TypeDurationDirectionFromRelativeSymbolicPoint storeDurationDirectionFromRelativeSymbolicPoint;
    private bool flagHasDuration;
    private AmountJSON  storeDuration;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRelativeSymbolicTimePoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RelativeSymbolicTimePoint of MortgageCalculatorTimePointJSON is not a string.");
        TypeRelativeSymbolicTimePoint the_open_enum = new TypeRelativeSymbolicTimePoint();
        switch (json_string.getData()[0])
          {
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "nd", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeRelativeSymbolicTimePointKnownValues.RelativeSymbolicTimePoint_End;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "tart", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeRelativeSymbolicTimePointKnownValues.RelativeSymbolicTimePoint_Start;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setRelativeSymbolicTimePoint(the_open_enum);
      }


    private void  fromJSONDurationDirectionFromRelativeSymbolicPoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DurationDirectionFromRelativeSymbolicPoint of MortgageCalculatorTimePointJSON is not a string.");
        TypeDurationDirectionFromRelativeSymbolicPoint the_open_enum = new TypeDurationDirectionFromRelativeSymbolicPoint();
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "ackward", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDurationDirectionFromRelativeSymbolicPointKnownValues.DurationDirectionFromRelativeSymbolicPoint_Backward;
                        goto open_enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "orward", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeDurationDirectionFromRelativeSymbolicPointKnownValues.DurationDirectionFromRelativeSymbolicPoint_Forward;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setDurationDirectionFromRelativeSymbolicPoint(the_open_enum);
      }


    private void  fromJSONDuration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AmountJSON convert_classy = AmountJSON.from_json(json_value, ignore_extras, true);
        setDuration(convert_classy);
      }


    public MortgageCalculatorTimePointJSON()
      {
        flagHasRelativeSymbolicTimePoint = false;
        flagHasDurationDirectionFromRelativeSymbolicPoint = false;
        flagHasDuration = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRelativeSymbolicTimePoint()
      {
        return flagHasRelativeSymbolicTimePoint;
      }

    public TypeRelativeSymbolicTimePoint  getRelativeSymbolicTimePoint()
      {
        Debug.Assert(flagHasRelativeSymbolicTimePoint);
        return storeRelativeSymbolicTimePoint;
      }

    public string  getRelativeSymbolicTimePointAsString()
      {
        TypeRelativeSymbolicTimePoint result = getRelativeSymbolicTimePoint();
        if (result.in_known_list)
            return stringFromRelativeSymbolicTimePoint(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasDurationDirectionFromRelativeSymbolicPoint()
      {
        return flagHasDurationDirectionFromRelativeSymbolicPoint;
      }

    public TypeDurationDirectionFromRelativeSymbolicPoint  getDurationDirectionFromRelativeSymbolicPoint()
      {
        Debug.Assert(flagHasDurationDirectionFromRelativeSymbolicPoint);
        return storeDurationDirectionFromRelativeSymbolicPoint;
      }

    public string  getDurationDirectionFromRelativeSymbolicPointAsString()
      {
        TypeDurationDirectionFromRelativeSymbolicPoint result = getDurationDirectionFromRelativeSymbolicPoint();
        if (result.in_known_list)
            return stringFromDurationDirectionFromRelativeSymbolicPoint(result.list_value);
        else
            return result.string_value;
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


    public virtual int extraMortgageCalculatorTimePointComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorTimePointComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorTimePointComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorTimePointLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setRelativeSymbolicTimePoint(TypeRelativeSymbolicTimePoint new_value)
      {
        flagHasRelativeSymbolicTimePoint = true;
        storeRelativeSymbolicTimePoint = new_value;
      }
    public void setRelativeSymbolicTimePoint(string chars)
      {
        TypeRelativeSymbolicTimePointKnownValues known = stringToRelativeSymbolicTimePoint(chars);
        TypeRelativeSymbolicTimePoint new_value = new TypeRelativeSymbolicTimePoint();
        if (known == TypeRelativeSymbolicTimePointKnownValues.RelativeSymbolicTimePoint__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setRelativeSymbolicTimePoint(new_value);
      }
    public void setRelativeSymbolicTimePoint(TypeRelativeSymbolicTimePointKnownValues new_value)
      {
        TypeRelativeSymbolicTimePoint new_full_value = new TypeRelativeSymbolicTimePoint();
        Debug.Assert(new_value != TypeRelativeSymbolicTimePointKnownValues.RelativeSymbolicTimePoint__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setRelativeSymbolicTimePoint(new_full_value);
      }
    public void unsetRelativeSymbolicTimePoint()
      {
        flagHasRelativeSymbolicTimePoint = false;
      }
    public void setDurationDirectionFromRelativeSymbolicPoint(TypeDurationDirectionFromRelativeSymbolicPoint new_value)
      {
        flagHasDurationDirectionFromRelativeSymbolicPoint = true;
        storeDurationDirectionFromRelativeSymbolicPoint = new_value;
      }
    public void setDurationDirectionFromRelativeSymbolicPoint(string chars)
      {
        TypeDurationDirectionFromRelativeSymbolicPointKnownValues known = stringToDurationDirectionFromRelativeSymbolicPoint(chars);
        TypeDurationDirectionFromRelativeSymbolicPoint new_value = new TypeDurationDirectionFromRelativeSymbolicPoint();
        if (known == TypeDurationDirectionFromRelativeSymbolicPointKnownValues.DurationDirectionFromRelativeSymbolicPoint__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setDurationDirectionFromRelativeSymbolicPoint(new_value);
      }
    public void setDurationDirectionFromRelativeSymbolicPoint(TypeDurationDirectionFromRelativeSymbolicPointKnownValues new_value)
      {
        TypeDurationDirectionFromRelativeSymbolicPoint new_full_value = new TypeDurationDirectionFromRelativeSymbolicPoint();
        Debug.Assert(new_value != TypeDurationDirectionFromRelativeSymbolicPointKnownValues.DurationDirectionFromRelativeSymbolicPoint__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setDurationDirectionFromRelativeSymbolicPoint(new_full_value);
      }
    public void unsetDurationDirectionFromRelativeSymbolicPoint()
      {
        flagHasDurationDirectionFromRelativeSymbolicPoint = false;
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

    public virtual void extraMortgageCalculatorTimePointAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorTimePointSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorTimePointLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorTimePointAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasRelativeSymbolicTimePoint);
        if (flagHasRelativeSymbolicTimePoint)
          {
            handler.start_pair("RelativeSymbolicTimePoint");
            if (storeRelativeSymbolicTimePoint.in_known_list)
              {
                switch (storeRelativeSymbolicTimePoint.list_value)
                  {
                    case TypeRelativeSymbolicTimePointKnownValues.RelativeSymbolicTimePoint_Start:
                        handler.string_value("Start");
                        break;
                    case TypeRelativeSymbolicTimePointKnownValues.RelativeSymbolicTimePoint_End:
                        handler.string_value("End");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeRelativeSymbolicTimePoint.string_value);
              }
          }
        if (flagHasDurationDirectionFromRelativeSymbolicPoint)
          {
            handler.start_pair("DurationDirectionFromRelativeSymbolicPoint");
            if (storeDurationDirectionFromRelativeSymbolicPoint.in_known_list)
              {
                switch (storeDurationDirectionFromRelativeSymbolicPoint.list_value)
                  {
                    case TypeDurationDirectionFromRelativeSymbolicPointKnownValues.DurationDirectionFromRelativeSymbolicPoint_Forward:
                        handler.string_value("Forward");
                        break;
                    case TypeDurationDirectionFromRelativeSymbolicPointKnownValues.DurationDirectionFromRelativeSymbolicPoint_Backward:
                        handler.string_value("Backward");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeDurationDirectionFromRelativeSymbolicPoint.string_value);
              }
          }
        if (flagHasDuration)
          {
            handler.start_pair("Duration");
            if (partial_allowed)
                storeDuration.write_partial_as_json(handler);
            else
                storeDuration.write_as_json(handler);
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
        if (!(hasRelativeSymbolicTimePoint()))
          {
            return "When parsing the object for %what%, the \"RelativeSymbolicTimePoint\" field was missing.";
          }
        return null;
      }

    public static MortgageCalculatorTimePointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorTimePointJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorTimePoint", ignore_extras);
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
    public static MortgageCalculatorTimePointJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MortgageCalculatorTimePointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorTimePointJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorTimePoint", ignore_extras);
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
    public static MortgageCalculatorTimePointJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MortgageCalculatorTimePointJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorTimePointJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorTimePoint", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorTimePointJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MortgageCalculatorTimePointJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorTimePointJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorTimePoint", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorRelativeSymbolicTimePoint : JSONStringGenerator
          {
            protected FieldGeneratorRelativeSymbolicTimePoint(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorRelativeSymbolicTimePoint()
              {
              }
            protected override void handle_result(string result)
              {
                TypeRelativeSymbolicTimePointKnownValues known = stringToRelativeSymbolicTimePoint(result);
                TypeRelativeSymbolicTimePoint new_value = new TypeRelativeSymbolicTimePoint();
                if (known == TypeRelativeSymbolicTimePointKnownValues.RelativeSymbolicTimePoint__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeRelativeSymbolicTimePoint result);
          };
    private class FieldHoldingGeneratorRelativeSymbolicTimePoint : FieldGeneratorRelativeSymbolicTimePoint
  {
    protected override void handle_result(TypeRelativeSymbolicTimePoint result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorRelativeSymbolicTimePoint(String what)
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
    public TypeRelativeSymbolicTimePoint value;
  };
    private class FieldHoldingArrayGeneratorRelativeSymbolicTimePoint : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorRelativeSymbolicTimePoint
      {
        private FieldHoldingArrayGeneratorRelativeSymbolicTimePoint top;

        protected override void handle_result(TypeRelativeSymbolicTimePoint result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorRelativeSymbolicTimePoint init_top)
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
    protected virtual void handle_result(List<TypeRelativeSymbolicTimePoint> result)
      {
      }

    public FieldHoldingArrayGeneratorRelativeSymbolicTimePoint(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRelativeSymbolicTimePoint>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorRelativeSymbolicTimePoint()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRelativeSymbolicTimePoint>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeRelativeSymbolicTimePoint> value;
  };
        private FieldHoldingGeneratorRelativeSymbolicTimePoint fieldGeneratorRelativeSymbolicTimePoint;
    private abstract class FieldGeneratorDurationDirectionFromRelativeSymbolicPoint : JSONStringGenerator
          {
            protected FieldGeneratorDurationDirectionFromRelativeSymbolicPoint(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorDurationDirectionFromRelativeSymbolicPoint()
              {
              }
            protected override void handle_result(string result)
              {
                TypeDurationDirectionFromRelativeSymbolicPointKnownValues known = stringToDurationDirectionFromRelativeSymbolicPoint(result);
                TypeDurationDirectionFromRelativeSymbolicPoint new_value = new TypeDurationDirectionFromRelativeSymbolicPoint();
                if (known == TypeDurationDirectionFromRelativeSymbolicPointKnownValues.DurationDirectionFromRelativeSymbolicPoint__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeDurationDirectionFromRelativeSymbolicPoint result);
          };
    private class FieldHoldingGeneratorDurationDirectionFromRelativeSymbolicPoint : FieldGeneratorDurationDirectionFromRelativeSymbolicPoint
  {
    protected override void handle_result(TypeDurationDirectionFromRelativeSymbolicPoint result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorDurationDirectionFromRelativeSymbolicPoint(String what)
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
    public TypeDurationDirectionFromRelativeSymbolicPoint value;
  };
    private class FieldHoldingArrayGeneratorDurationDirectionFromRelativeSymbolicPoint : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDurationDirectionFromRelativeSymbolicPoint
      {
        private FieldHoldingArrayGeneratorDurationDirectionFromRelativeSymbolicPoint top;

        protected override void handle_result(TypeDurationDirectionFromRelativeSymbolicPoint result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDurationDirectionFromRelativeSymbolicPoint init_top)
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
    protected virtual void handle_result(List<TypeDurationDirectionFromRelativeSymbolicPoint> result)
      {
      }

    public FieldHoldingArrayGeneratorDurationDirectionFromRelativeSymbolicPoint(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDurationDirectionFromRelativeSymbolicPoint>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDurationDirectionFromRelativeSymbolicPoint()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeDurationDirectionFromRelativeSymbolicPoint>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDurationDirectionFromRelativeSymbolicPoint> value;
  };
        private FieldHoldingGeneratorDurationDirectionFromRelativeSymbolicPoint fieldGeneratorDurationDirectionFromRelativeSymbolicPoint;
        private AmountJSON.HoldingGenerator fieldGeneratorDuration;
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
            MortgageCalculatorTimePointJSON result = new MortgageCalculatorTimePointJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorTimePointAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MortgageCalculatorTimePointJSON result)
          {
            if (fieldGeneratorRelativeSymbolicTimePoint.have_value)
              {
                result.setRelativeSymbolicTimePoint(fieldGeneratorRelativeSymbolicTimePoint.value);
                fieldGeneratorRelativeSymbolicTimePoint.have_value = false;
              }
            else if ((!(result.hasRelativeSymbolicTimePoint())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RelativeSymbolicTimePoint\" field was missing.");
              }
            if (fieldGeneratorDurationDirectionFromRelativeSymbolicPoint.have_value)
              {
                result.setDurationDirectionFromRelativeSymbolicPoint(fieldGeneratorDurationDirectionFromRelativeSymbolicPoint.value);
                fieldGeneratorDurationDirectionFromRelativeSymbolicPoint.have_value = false;
              }
            if (fieldGeneratorDuration.have_value)
              {
                result.setDuration(fieldGeneratorDuration.value);
                fieldGeneratorDuration.have_value = false;
              }
          }
        protected abstract void handle_result(MortgageCalculatorTimePointJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "uration", 0, 7, false) == 0)
                      {
                        if (field_name.Length == 8)
                          {
                            return fieldGeneratorDuration;
                          }
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "irectionFromRelativeSymbolicPoint", 0, 33, false) == 0) && (field_name.Length == 42))
                                    return fieldGeneratorDurationDirectionFromRelativeSymbolicPoint;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "elativeSymbolicTimePoint", 0, 24, false) == 0) && (field_name.Length == 25))
                        return fieldGeneratorRelativeSymbolicTimePoint;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorRelativeSymbolicTimePoint = new FieldHoldingGeneratorRelativeSymbolicTimePoint("field \"RelativeSymbolicTimePoint\" of the MortgageCalculatorTimePoint class");
            fieldGeneratorDurationDirectionFromRelativeSymbolicPoint = new FieldHoldingGeneratorDurationDirectionFromRelativeSymbolicPoint("field \"DurationDirectionFromRelativeSymbolicPoint\" of the MortgageCalculatorTimePoint class");
            fieldGeneratorDuration = new AmountJSON.HoldingGenerator("field \"Duration\" of the MortgageCalculatorTimePoint class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorTimePoint class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRelativeSymbolicTimePoint = new FieldHoldingGeneratorRelativeSymbolicTimePoint("field \"RelativeSymbolicTimePoint\" of the MortgageCalculatorTimePoint class");
            fieldGeneratorDurationDirectionFromRelativeSymbolicPoint = new FieldHoldingGeneratorDurationDirectionFromRelativeSymbolicPoint("field \"DurationDirectionFromRelativeSymbolicPoint\" of the MortgageCalculatorTimePoint class");
            fieldGeneratorDuration = new AmountJSON.HoldingGenerator("field \"Duration\" of the MortgageCalculatorTimePoint class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorTimePoint class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRelativeSymbolicTimePoint.reset();
            fieldGeneratorDurationDirectionFromRelativeSymbolicPoint.reset();
            fieldGeneratorDuration.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorDuration.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorDuration.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorTimePointJSON  result)
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
        public MortgageCalculatorTimePointJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorTimePointJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorTimePointJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorTimePointJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorTimePointJSON>();
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
    public List<MortgageCalculatorTimePointJSON> value;
  };
  };
