/* file "CalendarCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class CalendarCommandJSON : CommandResultJSON
  {

    public CalendarCommandJSON()
      {
      }

    public override string  getCommandKind()
      {
        return "CalendarCommand";
      }

    public abstract string getCalendarCommandKind();

    public abstract int extraCalendarCommandComponentCount();
    public abstract string extraCalendarCommandComponentKey(int component_num);
    public abstract JSONValue extraCalendarCommandComponentValue(int component_num);
    public abstract JSONValue extraCalendarCommandLookup(string field_name);
    public override int extraCommandResultComponentCount()
      {
        int result = 1;
        result += extraCalendarCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        if (component_num == 0)
            return "CalendarCommandKind";
        return extraCalendarCommandComponentKey((component_num - 1));
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getCalendarCommandKind());
        return extraCalendarCommandComponentValue((component_num - 1));
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "CalendarCommandKind", 0, 19, false) == 0) && (field_name.Length == 19))
            return new JSONStringValue(getCalendarCommandKind());
        return extraCalendarCommandLookup(field_name);
      }


    public abstract void extraCalendarCommandAppendPair(string key, JSONValue new_component);
    public abstract void extraCalendarCommandSetField(string key, JSONValue new_component);
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "CalendarCommandKind", 0, 19, false) == 0) && (key.Length == 19))
            return;
        extraCalendarCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "CalendarCommandKind", 0, 19, false) == 0) && (key.Length == 19))
            return;
        extraCalendarCommandSetField(key, new_component);
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
        handler.pair("CalendarCommandKind", getCalendarCommandKind());
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

    public static new CalendarCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarCommand", ignore_extras);
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
    public static new CalendarCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CalendarCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CalendarCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarCommand", ignore_extras);
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
    public static new CalendarCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CalendarCommandJSON from_text(string text, bool ignore_extras)
      {
        CalendarCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CalendarCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CalendarCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CalendarCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CalendarCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
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
                throw new Exception("The `CalendarCommandKind' field is missing.");
            if (!(getCommandResultJSONKey().Equals("CalendarCommand")))
                throw new Exception("The key field has a value other than `CalendarCommand'.");
            CalendarCommandJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCalendarCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getCalendarCommandJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `CalendarCommandKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((CalendarCommandJSON )new_result);
          }
        protected void finish(CalendarCommandJSON result)
          {
            base.finish(result);
          }
        protected abstract void handle_result(CalendarCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "CalendarCommandKind", 0, 19, false) == 0) && (field_name.Length == 19))
                {
                keyGenerator.reset();
                return keyGenerator;
                }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"CalendarCommandKind\" of the CalendarCommand class");
            set_what("the CalendarCommand class");
          }
        public Generator() : base(false)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"CalendarCommandKind\" of the CalendarCommand class");
            set_what("the CalendarCommand class");
          }

        public override void reset()
          {
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CalendarCommandJSON  result)
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
        public CalendarCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CalendarCommandJSON  result)
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
    protected virtual void handle_result(List<CalendarCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CalendarCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CalendarCommandJSON>();
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
    public List<CalendarCommandJSON> value;
  };
    class GenericCalendarCommandJSON : CalendarCommandJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericCalendarCommandJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getCalendarCommandKind()  { return key; }
        public override int extraCalendarCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraCalendarCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraCalendarCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraCalendarCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraCalendarCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraCalendarCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraCalendarCommandLookup(key);
            if (old_field == null)
              {
                extraCalendarCommandAppendPair(key, new_component);
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
    public static new CalendarCommandJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'C':
            switch (key[1])
              {
                case 'a':
                    if (String.Compare(key, 2, "ncelItem", 0, 8, false) == 0)
                      {
                        if (key.Length == 10)
                          {
                            return new CancelCalendarItemCommandJSON();
                          }
                        switch (key[10])
                          {
                            case 's':
                                if (key.Length == 11)
                                    return new CancelCalendarItemsCommandJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'r':
                    if (String.Compare(key, 2, "eate", 0, 4, false) == 0)
                      {
                        switch (key[6])
                          {
                            case 'C':
                                if (String.Compare(key, 7, "alendar", 0, 7, false) == 0)
                                  {
                                    switch (key[14])
                                      {
                                        case 'C':
                                            if ((String.Compare(key, 15, "ancelCommand", 0, 12, false) == 0) && (key.Length == 27))
                                                return new CreateCalendarCancelCommandJSON();
                                            break;
                                        case 'R':
                                            if ((String.Compare(key, 15, "equestInformationCommand", 0, 24, false) == 0) && (key.Length == 39))
                                                return new CreateCalendarRequestInformationCommandJSON();
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'I':
                                if ((String.Compare(key, 7, "tem", 0, 3, false) == 0) && (key.Length == 10))
                                    return new CalendarCreateCalendarItemCommandJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            break;
        case 'D':
            if (String.Compare(key, 1, "isplayItem", 0, 10, false) == 0)
              {
                if (key.Length == 11)
                  {
                    return new DisplayCalendarItemCommandJSON();
                  }
                switch (key[11])
                  {
                    case 's':
                        if (key.Length == 12)
                            return new DisplayCalendarItemsCommandJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'M':
            if (String.Compare(key, 1, "odifyItem", 0, 9, false) == 0)
              {
                if (key.Length == 10)
                  {
                    return new ModifyCalendarItemCommandJSON();
                  }
                switch (key[10])
                  {
                    case 's':
                        if (key.Length == 11)
                            return new ModifyCalendarItemsCommandJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        default:
            break;
      }

        return new GenericCalendarCommandJSON(key);
      }
  };
