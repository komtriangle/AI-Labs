/* file "FlightStatsDateOutOfRangeErrorJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class FlightStatsDateOutOfRangeErrorJSON : CommandErrorJSON
  {
    private bool flagHasSpecifiedDate;
    private DateAndOrTimeJSON  storeSpecifiedDate;
    private bool flagHasEarliestSupportedDate;
    private DateAndOrTimeJSON  storeEarliestSupportedDate;
    private bool flagHasLatestSupportedDate;
    private DateAndOrTimeJSON  storeLatestSupportedDate;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSpecifiedDateToJSON()
      {
        JSONValueHandler handler_SpecifiedDate = new JSONValueHandler();
        storeSpecifiedDate.write_as_json(handler_SpecifiedDate);
        return handler_SpecifiedDate.result;
      }

    private JSONValue  extraEarliestSupportedDateToJSON()
      {
        JSONValueHandler handler_EarliestSupportedDate = new JSONValueHandler();
        storeEarliestSupportedDate.write_as_json(handler_EarliestSupportedDate);
        return handler_EarliestSupportedDate.result;
      }

    private JSONValue  extraLatestSupportedDateToJSON()
      {
        JSONValueHandler handler_LatestSupportedDate = new JSONValueHandler();
        storeLatestSupportedDate.write_as_json(handler_LatestSupportedDate);
        return handler_LatestSupportedDate.result;
      }


    private void  fromJSONSpecifiedDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setSpecifiedDate(convert_classy);
      }


    private void  fromJSONEarliestSupportedDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setEarliestSupportedDate(convert_classy);
      }


    private void  fromJSONLatestSupportedDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setLatestSupportedDate(convert_classy);
      }


    public FlightStatsDateOutOfRangeErrorJSON()
      {
        flagHasSpecifiedDate = false;
        flagHasEarliestSupportedDate = false;
        flagHasLatestSupportedDate = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getErrorType()
      {
        return "DateOutOfRange";
      }

    public bool  hasSpecifiedDate()
      {
        return flagHasSpecifiedDate;
      }

    public DateAndOrTimeJSON   getSpecifiedDate()
      {
        Debug.Assert(flagHasSpecifiedDate);
        return storeSpecifiedDate;
      }

    public bool  hasEarliestSupportedDate()
      {
        return flagHasEarliestSupportedDate;
      }

    public DateAndOrTimeJSON   getEarliestSupportedDate()
      {
        Debug.Assert(flagHasEarliestSupportedDate);
        return storeEarliestSupportedDate;
      }

    public bool  hasLatestSupportedDate()
      {
        return flagHasLatestSupportedDate;
      }

    public DateAndOrTimeJSON   getLatestSupportedDate()
      {
        Debug.Assert(flagHasLatestSupportedDate);
        return storeLatestSupportedDate;
      }


    public virtual int extraFlightStatsDateOutOfRangeErrorComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatsDateOutOfRangeErrorComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatsDateOutOfRangeErrorComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatsDateOutOfRangeErrorLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandErrorComponentCount()
      {
        int result = 0;
        if (flagHasSpecifiedDate)
            ++result;
        if (flagHasEarliestSupportedDate)
            ++result;
        if (flagHasLatestSupportedDate)
            ++result;
        result += extraFlightStatsDateOutOfRangeErrorComponentCount();
        return result;
      }
    public override string extraCommandErrorComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSpecifiedDate)
          {
            if (remainder == 0)
                return "SpecifiedDate";
            --remainder;
          }
        if (flagHasEarliestSupportedDate)
          {
            if (remainder == 0)
                return "EarliestSupportedDate";
            --remainder;
          }
        if (flagHasLatestSupportedDate)
          {
            if (remainder == 0)
                return "LatestSupportedDate";
            --remainder;
          }
        return extraFlightStatsDateOutOfRangeErrorComponentKey(remainder);
      }
    public override JSONValue extraCommandErrorComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSpecifiedDate)
          {
            if (remainder == 0)
                return extraSpecifiedDateToJSON();
            --remainder;
          }
        if (flagHasEarliestSupportedDate)
          {
            if (remainder == 0)
                return extraEarliestSupportedDateToJSON();
            --remainder;
          }
        if (flagHasLatestSupportedDate)
          {
            if (remainder == 0)
                return extraLatestSupportedDateToJSON();
            --remainder;
          }
        return extraFlightStatsDateOutOfRangeErrorComponentValue(remainder);
      }
    public override JSONValue extraCommandErrorLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "arliestSupportedDate", 0, 20, false) == 0) && (field_name.Length == 21))
                    return (flagHasEarliestSupportedDate ? extraEarliestSupportedDateToJSON() : null);
                break;
            case 'L':
                if ((String.Compare(field_name, 1, "atestSupportedDate", 0, 18, false) == 0) && (field_name.Length == 19))
                    return (flagHasLatestSupportedDate ? extraLatestSupportedDateToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "pecifiedDate", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasSpecifiedDate ? extraSpecifiedDateToJSON() : null);
                break;
            default:
                break;
          }
        return extraFlightStatsDateOutOfRangeErrorLookup(field_name);
      }

    public void setSpecifiedDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasSpecifiedDate)
          {
          }
        flagHasSpecifiedDate = true;
        storeSpecifiedDate = new_value;
      }
    public void unsetSpecifiedDate()
      {
        if (flagHasSpecifiedDate)
          {
          }
        flagHasSpecifiedDate = false;
      }
    public void setEarliestSupportedDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasEarliestSupportedDate)
          {
          }
        flagHasEarliestSupportedDate = true;
        storeEarliestSupportedDate = new_value;
      }
    public void unsetEarliestSupportedDate()
      {
        if (flagHasEarliestSupportedDate)
          {
          }
        flagHasEarliestSupportedDate = false;
      }
    public void setLatestSupportedDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasLatestSupportedDate)
          {
          }
        flagHasLatestSupportedDate = true;
        storeLatestSupportedDate = new_value;
      }
    public void unsetLatestSupportedDate()
      {
        if (flagHasLatestSupportedDate)
          {
          }
        flagHasLatestSupportedDate = false;
      }

    public virtual void extraFlightStatsDateOutOfRangeErrorAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatsDateOutOfRangeErrorSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatsDateOutOfRangeErrorLookup(key);
        if (old_field == null)
          {
            extraFlightStatsDateOutOfRangeErrorAppendPair(key, new_component);
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
    public override void extraCommandErrorAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "arliestSupportedDate", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONEarliestSupportedDate(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "atestSupportedDate", 0, 18, false) == 0) && (key.Length == 19))
                    {
                    fromJSONLatestSupportedDate(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "pecifiedDate", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONSpecifiedDate(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFlightStatsDateOutOfRangeErrorAppendPair(key, new_component);
      }
    public override void extraCommandErrorSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "arliestSupportedDate", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONEarliestSupportedDate(new_component, false);
                    return;
                    }
                break;
            case 'L':
                if ((String.Compare(key, 1, "atestSupportedDate", 0, 18, false) == 0) && (key.Length == 19))
                    {
                    fromJSONLatestSupportedDate(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "pecifiedDate", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONSpecifiedDate(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraFlightStatsDateOutOfRangeErrorSetField(key, new_component);
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
        if (flagHasSpecifiedDate)
          {
            handler.start_pair("SpecifiedDate");
            if (partial_allowed)
                storeSpecifiedDate.write_partial_as_json(handler);
            else
                storeSpecifiedDate.write_as_json(handler);
          }
        if (flagHasEarliestSupportedDate)
          {
            handler.start_pair("EarliestSupportedDate");
            if (partial_allowed)
                storeEarliestSupportedDate.write_partial_as_json(handler);
            else
                storeEarliestSupportedDate.write_as_json(handler);
          }
        if (flagHasLatestSupportedDate)
          {
            handler.start_pair("LatestSupportedDate");
            if (partial_allowed)
                storeLatestSupportedDate.write_partial_as_json(handler);
            else
                storeLatestSupportedDate.write_as_json(handler);
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
        return null;
      }

    public static new FlightStatsDateOutOfRangeErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsDateOutOfRangeErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsDateOutOfRangeError", ignore_extras);
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
    public static new FlightStatsDateOutOfRangeErrorJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FlightStatsDateOutOfRangeErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatsDateOutOfRangeErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsDateOutOfRangeError", ignore_extras);
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
    public static new FlightStatsDateOutOfRangeErrorJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FlightStatsDateOutOfRangeErrorJSON from_text(string text, bool ignore_extras)
      {
        FlightStatsDateOutOfRangeErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsDateOutOfRangeError", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatsDateOutOfRangeErrorJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new FlightStatsDateOutOfRangeErrorJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatsDateOutOfRangeErrorJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatsDateOutOfRangeError", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandErrorJSON.Generator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorSpecifiedDate;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorEarliestSupportedDate;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorLatestSupportedDate;
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
            if (!(getCommandErrorJSONKey().Equals("DateOutOfRange")))
                throw new Exception("The key field has a value other than `DateOutOfRange'.");
            FlightStatsDateOutOfRangeErrorJSON result = new FlightStatsDateOutOfRangeErrorJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatsDateOutOfRangeErrorAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandErrorJSON new_result)
          {
            handle_result((FlightStatsDateOutOfRangeErrorJSON )new_result);
          }
        protected void finish(FlightStatsDateOutOfRangeErrorJSON result)
          {
            if (fieldGeneratorSpecifiedDate.have_value)
              {
                result.setSpecifiedDate(fieldGeneratorSpecifiedDate.value);
                fieldGeneratorSpecifiedDate.have_value = false;
              }
            if (fieldGeneratorEarliestSupportedDate.have_value)
              {
                result.setEarliestSupportedDate(fieldGeneratorEarliestSupportedDate.value);
                fieldGeneratorEarliestSupportedDate.have_value = false;
              }
            if (fieldGeneratorLatestSupportedDate.have_value)
              {
                result.setLatestSupportedDate(fieldGeneratorLatestSupportedDate.value);
                fieldGeneratorLatestSupportedDate.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(FlightStatsDateOutOfRangeErrorJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "arliestSupportedDate", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorEarliestSupportedDate;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "atestSupportedDate", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorLatestSupportedDate;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pecifiedDate", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorSpecifiedDate;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSpecifiedDate = new DateAndOrTimeJSON.HoldingGenerator("field \"SpecifiedDate\" of the FlightStatsDateOutOfRangeError class", ignore_extras);
            fieldGeneratorEarliestSupportedDate = new DateAndOrTimeJSON.HoldingGenerator("field \"EarliestSupportedDate\" of the FlightStatsDateOutOfRangeError class", ignore_extras);
            fieldGeneratorLatestSupportedDate = new DateAndOrTimeJSON.HoldingGenerator("field \"LatestSupportedDate\" of the FlightStatsDateOutOfRangeError class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatsDateOutOfRangeError class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSpecifiedDate = new DateAndOrTimeJSON.HoldingGenerator("field \"SpecifiedDate\" of the FlightStatsDateOutOfRangeError class", false);
            fieldGeneratorEarliestSupportedDate = new DateAndOrTimeJSON.HoldingGenerator("field \"EarliestSupportedDate\" of the FlightStatsDateOutOfRangeError class", false);
            fieldGeneratorLatestSupportedDate = new DateAndOrTimeJSON.HoldingGenerator("field \"LatestSupportedDate\" of the FlightStatsDateOutOfRangeError class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatsDateOutOfRangeError class");
          }

        public override void reset()
          {
            fieldGeneratorSpecifiedDate.reset();
            fieldGeneratorEarliestSupportedDate.reset();
            fieldGeneratorLatestSupportedDate.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightStatsDateOutOfRangeErrorJSON  result)
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
        public FlightStatsDateOutOfRangeErrorJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatsDateOutOfRangeErrorJSON  result)
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
    protected virtual void handle_result(List<FlightStatsDateOutOfRangeErrorJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatsDateOutOfRangeErrorJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatsDateOutOfRangeErrorJSON>();
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
    public List<FlightStatsDateOutOfRangeErrorJSON> value;
  };
  };
