/* file "RobotCommandIntentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class RobotCommandIntentJSON : CommandIntentJSON
  {

    public RobotCommandIntentJSON()
      {
      }

    public override string  getCommandIntentKind()
      {
        return "Robot";
      }

    public abstract string getRobotIntentKind();

    public abstract int extraRobotCommandIntentComponentCount();
    public abstract string extraRobotCommandIntentComponentKey(int component_num);
    public abstract JSONValue extraRobotCommandIntentComponentValue(int component_num);
    public abstract JSONValue extraRobotCommandIntentLookup(string field_name);
    public override int extraCommandIntentComponentCount()
      {
        int result = 1;
        result += extraRobotCommandIntentComponentCount();
        return result;
      }
    public override string extraCommandIntentComponentKey(int component_num)
      {
        if (component_num == 0)
            return "RobotIntentKind";
        return extraRobotCommandIntentComponentKey((component_num - 1));
      }
    public override JSONValue extraCommandIntentComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getRobotIntentKind());
        return extraRobotCommandIntentComponentValue((component_num - 1));
      }
    public override JSONValue extraCommandIntentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "RobotIntentKind", 0, 15, false) == 0) && (field_name.Length == 15))
            return new JSONStringValue(getRobotIntentKind());
        return extraRobotCommandIntentLookup(field_name);
      }


    public abstract void extraRobotCommandIntentAppendPair(string key, JSONValue new_component);
    public abstract void extraRobotCommandIntentSetField(string key, JSONValue new_component);
    public override void extraCommandIntentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "RobotIntentKind", 0, 15, false) == 0) && (key.Length == 15))
            return;
        extraRobotCommandIntentAppendPair(key, new_component);
      }
    public override void extraCommandIntentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "RobotIntentKind", 0, 15, false) == 0) && (key.Length == 15))
            return;
        extraRobotCommandIntentSetField(key, new_component);
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
        handler.pair("RobotIntentKind", getRobotIntentKind());
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

    public static new RobotCommandIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RobotCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotCommandIntent", ignore_extras);
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
    public static new RobotCommandIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RobotCommandIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RobotCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotCommandIntent", ignore_extras);
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
    public static new RobotCommandIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RobotCommandIntentJSON from_text(string text, bool ignore_extras)
      {
        RobotCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotCommandIntent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RobotCommandIntentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RobotCommandIntentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RobotCommandIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RobotCommandIntent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandIntentJSON.Generator
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
                throw new Exception("The `RobotIntentKind' field is missing.");
            if (!(getCommandIntentJSONKey().Equals("Robot")))
                throw new Exception("The key field has a value other than `Robot'.");
            RobotCommandIntentJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRobotCommandIntentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getRobotCommandIntentJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `RobotIntentKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandIntentJSON new_result)
          {
            handle_result((RobotCommandIntentJSON )new_result);
          }
        protected void finish(RobotCommandIntentJSON result)
          {
            base.finish(result);
          }
        protected abstract void handle_result(RobotCommandIntentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "RobotIntentKind", 0, 15, false) == 0) && (field_name.Length == 15))
                {
                keyGenerator.reset();
                return keyGenerator;
                }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"RobotIntentKind\" of the RobotCommandIntent class");
            set_what("the RobotCommandIntent class");
          }
        public Generator() : base(false)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"RobotIntentKind\" of the RobotCommandIntent class");
            set_what("the RobotCommandIntent class");
          }

        public override void reset()
          {
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RobotCommandIntentJSON  result)
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
        public RobotCommandIntentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RobotCommandIntentJSON  result)
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
    protected virtual void handle_result(List<RobotCommandIntentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RobotCommandIntentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RobotCommandIntentJSON>();
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
    public List<RobotCommandIntentJSON> value;
  };
    class GenericRobotCommandIntentJSON : RobotCommandIntentJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericRobotCommandIntentJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getRobotIntentKind()  { return key; }
        public override int extraRobotCommandIntentComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraRobotCommandIntentComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraRobotCommandIntentComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraRobotCommandIntentLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraRobotCommandIntentAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraRobotCommandIntentSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraRobotCommandIntentLookup(key);
            if (old_field == null)
              {
                extraRobotCommandIntentAppendPair(key, new_component);
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
    public static new RobotCommandIntentJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'L':
            if (String.Compare(key, 1, "ist", 0, 3, false) == 0)
              {
                switch (key[4])
                  {
                    case 'C':
                        if ((String.Compare(key, 5, "apabilitiesCommand", 0, 18, false) == 0) && (key.Length == 23))
                            return new RobotListCapabilitiesCommandIntentJSON();
                        break;
                    case 'K':
                        if ((String.Compare(key, 5, "nownRoomsCommand", 0, 16, false) == 0) && (key.Length == 21))
                            return new RobotListKnownRoomsCommandIntentJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'M':
            if ((String.Compare(key, 1, "oveCommand", 0, 10, false) == 0) && (key.Length == 11))
                return new RobotMoveCommandIntentJSON();
            break;
        case 'R':
            if ((String.Compare(key, 1, "obotSetKnownRoomsCommand", 0, 24, false) == 0) && (key.Length == 25))
                return new RobotSetKnownRoomsCommandIntentJSON();
            break;
        case 'S':
            if (String.Compare(key, 1, "top", 0, 3, false) == 0)
              {
                switch (key[4])
                  {
                    case 'C':
                        if ((String.Compare(key, 5, "ommand", 0, 6, false) == 0) && (key.Length == 11))
                            return new RobotStopCommandIntentJSON();
                        break;
                    case 'R':
                        if ((String.Compare(key, 5, "ecordingVideoCommand", 0, 20, false) == 0) && (key.Length == 25))
                            return new RobotStopRecordingVideoCommandIntentJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'T':
            switch (key[1])
              {
                case 'a':
                    if (String.Compare(key, 2, "ke", 0, 2, false) == 0)
                      {
                        switch (key[4])
                          {
                            case 'P':
                                if ((String.Compare(key, 5, "ictureCommand", 0, 13, false) == 0) && (key.Length == 18))
                                    return new RobotTakePictureCommandIntentJSON();
                                break;
                            case 'V':
                                if ((String.Compare(key, 5, "ideoCommand", 0, 11, false) == 0) && (key.Length == 16))
                                    return new RobotTakeVideoCommandIntentJSON();
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'u':
                    if ((String.Compare(key, 2, "rnCommand", 0, 9, false) == 0) && (key.Length == 11))
                        return new RobotTurnCommandIntentJSON();
                    break;
                default:
                    break;
              }
            break;
        default:
            break;
      }

        return new GenericRobotCommandIntentJSON(key);
      }
  };
