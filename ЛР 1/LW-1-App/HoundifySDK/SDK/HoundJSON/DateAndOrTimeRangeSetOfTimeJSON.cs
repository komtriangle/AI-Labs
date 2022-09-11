/* file "DateAndOrTimeRangeSetOfTimeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class DateAndOrTimeRangeSetOfTimeJSON : SetOfTimeJSON
  {
    private bool flagHasStart;
    private DateAndOrTimeJSON  storeStart;
    private bool flagHasEnd;
    private DateAndOrTimeJSON  storeEnd;
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


    private void  fromJSONStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStart(convert_classy);
      }


    private void  fromJSONEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEnd(convert_classy);
      }


    public DateAndOrTimeRangeSetOfTimeJSON()
      {
        flagHasStart = false;
        flagHasEnd = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSetOfTimeKind()
      {
        return "DateAndOrTimeRange";
      }

    public bool  hasStart()
      {
        return flagHasStart;
      }

    public DateAndOrTimeJSON   getStart()
      {
        Debug.Assert(flagHasStart);
        return storeStart;
      }

    public bool  hasEnd()
      {
        return flagHasEnd;
      }

    public DateAndOrTimeJSON   getEnd()
      {
        Debug.Assert(flagHasEnd);
        return storeEnd;
      }


    public virtual int extraDateAndOrTimeRangeSetOfTimeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDateAndOrTimeRangeSetOfTimeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDateAndOrTimeRangeSetOfTimeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDateAndOrTimeRangeSetOfTimeLookup(string field_name)
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
        result += extraDateAndOrTimeRangeSetOfTimeComponentCount();
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
        return extraDateAndOrTimeRangeSetOfTimeComponentKey(remainder);
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
        return extraDateAndOrTimeRangeSetOfTimeComponentValue(remainder);
      }
    public override JSONValue extraSetOfTimeLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "nd", 0, 2, false) == 0) && (field_name.Length == 3))
                    return (flagHasEnd ? extraEndToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tart", 0, 4, false) == 0) && (field_name.Length == 5))
                    return (flagHasStart ? extraStartToJSON() : null);
                break;
            default:
                break;
          }
        return extraDateAndOrTimeRangeSetOfTimeLookup(field_name);
      }

    public void setStart(DateAndOrTimeJSON  new_value)
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
    public void setEnd(DateAndOrTimeJSON  new_value)
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

    public virtual void extraDateAndOrTimeRangeSetOfTimeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDateAndOrTimeRangeSetOfTimeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDateAndOrTimeRangeSetOfTimeLookup(key);
        if (old_field == null)
          {
            extraDateAndOrTimeRangeSetOfTimeAppendPair(key, new_component);
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
                if ((String.Compare(key, 1, "nd", 0, 2, false) == 0) && (key.Length == 3))
                    {
                    fromJSONEnd(new_component, false);
                    return;
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
        extraDateAndOrTimeRangeSetOfTimeAppendPair(key, new_component);
      }
    public override void extraSetOfTimeSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "nd", 0, 2, false) == 0) && (key.Length == 3))
                    {
                    fromJSONEnd(new_component, false);
                    return;
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
        extraDateAndOrTimeRangeSetOfTimeSetField(key, new_component);
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
        return null;
      }

    public static new DateAndOrTimeRangeSetOfTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateAndOrTimeRangeSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndOrTimeRangeSetOfTime", ignore_extras);
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
    public static new DateAndOrTimeRangeSetOfTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DateAndOrTimeRangeSetOfTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateAndOrTimeRangeSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndOrTimeRangeSetOfTime", ignore_extras);
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
    public static new DateAndOrTimeRangeSetOfTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DateAndOrTimeRangeSetOfTimeJSON from_text(string text, bool ignore_extras)
      {
        DateAndOrTimeRangeSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndOrTimeRangeSetOfTime", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DateAndOrTimeRangeSetOfTimeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DateAndOrTimeRangeSetOfTimeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DateAndOrTimeRangeSetOfTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndOrTimeRangeSetOfTime", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SetOfTimeJSON.Generator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStart;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEnd;
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
            if (!(getSetOfTimeJSONKey().Equals("DateAndOrTimeRange")))
                throw new Exception("The key field has a value other than `DateAndOrTimeRange'.");
            DateAndOrTimeRangeSetOfTimeJSON result = new DateAndOrTimeRangeSetOfTimeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDateAndOrTimeRangeSetOfTimeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SetOfTimeJSON new_result)
          {
            handle_result((DateAndOrTimeRangeSetOfTimeJSON )new_result);
          }
        protected void finish(DateAndOrTimeRangeSetOfTimeJSON result)
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
            base.finish(result);
          }
        protected abstract void handle_result(DateAndOrTimeRangeSetOfTimeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "nd", 0, 2, false) == 0) && (field_name.Length == 3))
                        return fieldGeneratorEnd;
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
            fieldGeneratorStart = new DateAndOrTimeJSON.HoldingGenerator("field \"Start\" of the DateAndOrTimeRangeSetOfTime class", ignore_extras);
            fieldGeneratorEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"End\" of the DateAndOrTimeRangeSetOfTime class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DateAndOrTimeRangeSetOfTime class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorStart = new DateAndOrTimeJSON.HoldingGenerator("field \"Start\" of the DateAndOrTimeRangeSetOfTime class", false);
            fieldGeneratorEnd = new DateAndOrTimeJSON.HoldingGenerator("field \"End\" of the DateAndOrTimeRangeSetOfTime class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DateAndOrTimeRangeSetOfTime class");
          }

        public override void reset()
          {
            fieldGeneratorStart.reset();
            fieldGeneratorEnd.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DateAndOrTimeRangeSetOfTimeJSON  result)
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
        public DateAndOrTimeRangeSetOfTimeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DateAndOrTimeRangeSetOfTimeJSON  result)
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
    protected virtual void handle_result(List<DateAndOrTimeRangeSetOfTimeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DateAndOrTimeRangeSetOfTimeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DateAndOrTimeRangeSetOfTimeJSON>();
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
    public List<DateAndOrTimeRangeSetOfTimeJSON> value;
  };
  };
