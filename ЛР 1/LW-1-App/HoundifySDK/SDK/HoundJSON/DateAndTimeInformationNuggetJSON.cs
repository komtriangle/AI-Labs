/* file "DateAndTimeInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class DateAndTimeInformationNuggetJSON : InformationNuggetJSON
  {

    public DateAndTimeInformationNuggetJSON()
      {
      }

    public override string  getNuggetKind()
      {
        return "DateAndTime";
      }

    public abstract string getDateAndTimeNuggetKind();

    public abstract int extraDateAndTimeInformationNuggetComponentCount();
    public abstract string extraDateAndTimeInformationNuggetComponentKey(int component_num);
    public abstract JSONValue extraDateAndTimeInformationNuggetComponentValue(int component_num);
    public abstract JSONValue extraDateAndTimeInformationNuggetLookup(string field_name);
    public override int extraInformationNuggetComponentCount()
      {
        int result = 1;
        result += extraDateAndTimeInformationNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        if (component_num == 0)
            return "DateAndTimeNuggetKind";
        return extraDateAndTimeInformationNuggetComponentKey((component_num - 1));
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getDateAndTimeNuggetKind());
        return extraDateAndTimeInformationNuggetComponentValue((component_num - 1));
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "DateAndTimeNuggetKind", 0, 21, false) == 0) && (field_name.Length == 21))
            return new JSONStringValue(getDateAndTimeNuggetKind());
        return extraDateAndTimeInformationNuggetLookup(field_name);
      }


    public abstract void extraDateAndTimeInformationNuggetAppendPair(string key, JSONValue new_component);
    public abstract void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component);
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "DateAndTimeNuggetKind", 0, 21, false) == 0) && (key.Length == 21))
            return;
        extraDateAndTimeInformationNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "DateAndTimeNuggetKind", 0, 21, false) == 0) && (key.Length == 21))
            return;
        extraDateAndTimeInformationNuggetSetField(key, new_component);
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        handler.pair("DateAndTimeNuggetKind", getDateAndTimeNuggetKind());
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new DateAndTimeInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateAndTimeInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndTimeInformationNugget", ignore_extras);
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
    public static new DateAndTimeInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DateAndTimeInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateAndTimeInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndTimeInformationNugget", ignore_extras);
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
    public static new DateAndTimeInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new DateAndTimeInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        DateAndTimeInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndTimeInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DateAndTimeInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new DateAndTimeInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DateAndTimeInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndTimeInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `DateAndTimeNuggetKind' field is missing.");
            if (!(getInformationNuggetJSONKey().Equals("DateAndTime")))
                throw new Exception("The key field has a value other than `DateAndTime'.");
            DateAndTimeInformationNuggetJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDateAndTimeInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getDateAndTimeInformationNuggetJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `DateAndTimeNuggetKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((DateAndTimeInformationNuggetJSON )new_result);
          }
        protected void finish(DateAndTimeInformationNuggetJSON result)
          {
            base.finish(result);
          }
        protected abstract void handle_result(DateAndTimeInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "DateAndTimeNuggetKind", 0, 21, false) == 0) && (field_name.Length == 21))
                {
                keyGenerator.reset();
                return keyGenerator;
                }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"DateAndTimeNuggetKind\" of the DateAndTimeInformationNugget class");
            set_what("the DateAndTimeInformationNugget class");
          }
        public Generator() : base(false)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"DateAndTimeNuggetKind\" of the DateAndTimeInformationNugget class");
            set_what("the DateAndTimeInformationNugget class");
          }

        public override void reset()
          {
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(DateAndTimeInformationNuggetJSON  result)
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
        public DateAndTimeInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DateAndTimeInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<DateAndTimeInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DateAndTimeInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DateAndTimeInformationNuggetJSON>();
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
    public List<DateAndTimeInformationNuggetJSON> value;
  };
    class GenericDateAndTimeInformationNuggetJSON : DateAndTimeInformationNuggetJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericDateAndTimeInformationNuggetJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getDateAndTimeNuggetKind()  { return key; }
        public override int extraDateAndTimeInformationNuggetComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraDateAndTimeInformationNuggetComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraDateAndTimeInformationNuggetComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraDateAndTimeInformationNuggetLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraDateAndTimeInformationNuggetAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraDateAndTimeInformationNuggetSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraDateAndTimeInformationNuggetLookup(key);
            if (old_field == null)
              {
                extraDateAndTimeInformationNuggetAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static new DateAndTimeInformationNuggetJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'D':
            if ((String.Compare(key, 1, "ateAndTimeLookupCommand", 0, 23, false) == 0) && (key.Length == 24))
                return new DateAndTimeLookupInformationNuggetJSON();
            break;
        case 'H':
            if ((String.Compare(key, 1, "olidaysOnDateLookup", 0, 19, false) == 0) && (key.Length == 20))
                return new HolidaysOnDateLookupInformationNuggetJSON();
            break;
        case 'L':
            if ((String.Compare(key, 1, "eapYearLookup", 0, 13, false) == 0) && (key.Length == 14))
                return new LeapYearLookupInformationNuggetJSON();
            break;
        case 'M':
            if (String.Compare(key, 1, "o", 0, 1, false) == 0)
              {
                switch (key[2])
                  {
                    case 'n':
                        if ((String.Compare(key, 3, "thLengthLookup", 0, 14, false) == 0) && (key.Length == 17))
                            return new MonthLengthLookupInformationNuggetJSON();
                        break;
                    case 'o':
                        if ((String.Compare(key, 3, "nPhaseAtTime", 0, 12, false) == 0) && (key.Length == 15))
                            return new MoonPhaseAtTimeInformationNuggetJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'S':
            if ((String.Compare(key, 1, "unriseSunsetTime", 0, 16, false) == 0) && (key.Length == 17))
                return new SunriseSunsetTimeInformationNuggetJSON();
            break;
        case 'T':
            if (String.Compare(key, 1, "ime", 0, 3, false) == 0)
              {
                switch (key[4])
                  {
                    case 'B':
                        if (String.Compare(key, 5, "etween", 0, 6, false) == 0)
                          {
                            switch (key[11])
                              {
                                case 'L':
                                    if ((String.Compare(key, 12, "ocations", 0, 8, false) == 0) && (key.Length == 20))
                                        return new TimeBetweenLocationsInformationNuggetJSON();
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 12, "imes", 0, 4, false) == 0) && (key.Length == 16))
                                        return new TimeBetweenTimesInformationNuggetJSON();
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'I':
                        if ((String.Compare(key, 5, "nLocation", 0, 9, false) == 0) && (key.Length == 14))
                            return new TimeInLocationInformationNuggetJSON();
                        break;
                    case 'O':
                        if ((String.Compare(key, 5, "fMoonPhase", 0, 10, false) == 0) && (key.Length == 15))
                            return new TimeOfMoonPhaseInformationNuggetJSON();
                        break;
                    case 'z':
                        if ((String.Compare(key, 5, "oneLookup", 0, 9, false) == 0) && (key.Length == 14))
                            return new TimezoneLookupInformationNuggetJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        default:
            break;
      }

        return new GenericDateAndTimeInformationNuggetJSON(key);
      }
  };
