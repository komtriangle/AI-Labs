/* file "CarControlCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class CarControlCommandJSON : CommandResultJSON
  {

    public CarControlCommandJSON()
      {
      }

    public override string  getCommandKind()
      {
        return "CarControlCommand";
      }

    public abstract string getCarControlCommandKind();

    public abstract int extraCarControlCommandComponentCount();
    public abstract string extraCarControlCommandComponentKey(int component_num);
    public abstract JSONValue extraCarControlCommandComponentValue(int component_num);
    public abstract JSONValue extraCarControlCommandLookup(string field_name);
    public override int extraCommandResultComponentCount()
      {
        int result = 1;
        result += extraCarControlCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        if (component_num == 0)
            return "CarControlCommandKind";
        return extraCarControlCommandComponentKey((component_num - 1));
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getCarControlCommandKind());
        return extraCarControlCommandComponentValue((component_num - 1));
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "CarControlCommandKind", 0, 21, false) == 0) && (field_name.Length == 21))
            return new JSONStringValue(getCarControlCommandKind());
        return extraCarControlCommandLookup(field_name);
      }


    public abstract void extraCarControlCommandAppendPair(string key, JSONValue new_component);
    public abstract void extraCarControlCommandSetField(string key, JSONValue new_component);
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "CarControlCommandKind", 0, 21, false) == 0) && (key.Length == 21))
            return;
        extraCarControlCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "CarControlCommandKind", 0, 21, false) == 0) && (key.Length == 21))
            return;
        extraCarControlCommandSetField(key, new_component);
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
        handler.pair("CarControlCommandKind", getCarControlCommandKind());
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

    public static new CarControlCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlCommand", ignore_extras);
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
    public static new CarControlCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlCommand", ignore_extras);
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
    public static new CarControlCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CarControlCommandJSON from_text(string text, bool ignore_extras)
      {
        CarControlCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CarControlCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlCommand", ignore_extras);
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
                throw new Exception("The `CarControlCommandKind' field is missing.");
            if (!(getCommandResultJSONKey().Equals("CarControlCommand")))
                throw new Exception("The key field has a value other than `CarControlCommand'.");
            CarControlCommandJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getCarControlCommandJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `CarControlCommandKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((CarControlCommandJSON )new_result);
          }
        protected void finish(CarControlCommandJSON result)
          {
            base.finish(result);
          }
        protected abstract void handle_result(CarControlCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "CarControlCommandKind", 0, 21, false) == 0) && (field_name.Length == 21))
                {
                keyGenerator.reset();
                return keyGenerator;
                }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"CarControlCommandKind\" of the CarControlCommand class");
            set_what("the CarControlCommand class");
          }
        public Generator() : base(false)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"CarControlCommandKind\" of the CarControlCommand class");
            set_what("the CarControlCommand class");
          }

        public override void reset()
          {
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlCommandJSON  result)
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
        public CarControlCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlCommandJSON  result)
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
    protected virtual void handle_result(List<CarControlCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlCommandJSON>();
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
    public List<CarControlCommandJSON> value;
  };
    class GenericCarControlCommandJSON : CarControlCommandJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericCarControlCommandJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getCarControlCommandKind()  { return key; }
        public override int extraCarControlCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraCarControlCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraCarControlCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraCarControlCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraCarControlCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraCarControlCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraCarControlCommandLookup(key);
            if (old_field == null)
              {
                extraCarControlCommandAppendPair(key, new_component);
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
    public static new CarControlCommandJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "CarControl", 0, 10, false) == 0)
      {
        switch (key[10])
          {
            case 'C':
                switch (key[11])
                  {
                    case 'a':
                        if ((String.Compare(key, 12, "meraCommand", 0, 11, false) == 0) && (key.Length == 23))
                            return new CarControlCameraCommandJSON();
                        break;
                    case 'l':
                        if (String.Compare(key, 12, "imate", 0, 5, false) == 0)
                          {
                            switch (key[17])
                              {
                                case 'C':
                                    if ((String.Compare(key, 18, "ommand", 0, 6, false) == 0) && (key.Length == 24))
                                        return new CarControlClimateCommandJSON();
                                    break;
                                case 'I':
                                    if ((String.Compare(key, 18, "ntoModeCommand", 0, 14, false) == 0) && (key.Length == 32))
                                        return new CarControlClimateIntoModeCommandJSON();
                                    break;
                                case 'M':
                                    if (String.Compare(key, 18, "ode", 0, 3, false) == 0)
                                      {
                                        switch (key[21])
                                          {
                                            case 'C':
                                                if ((String.Compare(key, 22, "ancel", 0, 5, false) == 0) && (key.Length == 27))
                                                    return new CarControlClimateModeCancelJSON();
                                                break;
                                            case 'N':
                                                if ((String.Compare(key, 22, "otUnderstood", 0, 12, false) == 0) && (key.Length == 34))
                                                    return new CarControlClimateModeNotUnderstoodJSON();
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'o':
                        if ((String.Compare(key, 12, "nvertibleCommand", 0, 16, false) == 0) && (key.Length == 28))
                            return new CarControlConvertibleCommandJSON();
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                switch (key[11])
                  {
                    case 'o':
                        if ((String.Compare(key, 12, "orCommand", 0, 9, false) == 0) && (key.Length == 21))
                            return new CarControlDoorCommandJSON();
                        break;
                    case 'r':
                        if (String.Compare(key, 12, "iving", 0, 5, false) == 0)
                          {
                            switch (key[17])
                              {
                                case 'C':
                                    if ((String.Compare(key, 18, "ommand", 0, 6, false) == 0) && (key.Length == 24))
                                        return new CarControlDrivingCommandJSON();
                                    break;
                                case 'T':
                                    if ((String.Compare(key, 18, "ooAmbiguous", 0, 11, false) == 0) && (key.Length == 29))
                                        return new CarControlDrivingTooAmbiguousJSON();
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
            case 'L':
                if (String.Compare(key, 11, "ight", 0, 4, false) == 0)
                  {
                    switch (key[15])
                      {
                        case 'C':
                            if ((String.Compare(key, 16, "ommand", 0, 6, false) == 0) && (key.Length == 22))
                                return new CarControlLightsCommandJSON();
                            break;
                        case 's':
                            switch (key[16])
                              {
                                case 'I':
                                    if ((String.Compare(key, 17, "ntoModeCommand", 0, 14, false) == 0) && (key.Length == 31))
                                        return new CarControlLightsIntoModeCommandJSON();
                                    break;
                                case 'M':
                                    if (String.Compare(key, 17, "ode", 0, 3, false) == 0)
                                      {
                                        switch (key[20])
                                          {
                                            case 'C':
                                                if ((String.Compare(key, 21, "ancel", 0, 5, false) == 0) && (key.Length == 26))
                                                    return new CarControlLightsModeCancelJSON();
                                                break;
                                            case 'N':
                                                if ((String.Compare(key, 21, "otUnderstood", 0, 12, false) == 0) && (key.Length == 33))
                                                    return new CarControlLightsModeNotUnderstoodJSON();
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
                        default:
                            break;
                      }
                  }
                break;
            case 'M':
                if (String.Compare(key, 11, "irror", 0, 5, false) == 0)
                  {
                    switch (key[16])
                      {
                        case 'C':
                            if ((String.Compare(key, 17, "ommand", 0, 6, false) == 0) && (key.Length == 23))
                                return new CarControlMirrorCommandJSON();
                            break;
                        case 'D':
                            if ((String.Compare(key, 17, "isambiguationCommand", 0, 20, false) == 0) && (key.Length == 37))
                                return new CarControlMirrorDisambJSON();
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                switch (key[11])
                  {
                    case 'c':
                        if ((String.Compare(key, 12, "reenCommand", 0, 11, false) == 0) && (key.Length == 23))
                            return new CarControlScreenCommandJSON();
                        break;
                    case 'e':
                        if (String.Compare(key, 12, "at", 0, 2, false) == 0)
                          {
                            switch (key[14])
                              {
                                case 'C':
                                    switch (key[15])
                                      {
                                        case 'l':
                                            if ((String.Compare(key, 16, "imateCommand", 0, 12, false) == 0) && (key.Length == 28))
                                                return new CarControlSeatClimateCommandJSON();
                                            break;
                                        case 'o':
                                            if ((String.Compare(key, 16, "mmand", 0, 5, false) == 0) && (key.Length == 21))
                                                return new CarControlSeatCommandJSON();
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'H':
                                    if ((String.Compare(key, 15, "eaterCommand", 0, 12, false) == 0) && (key.Length == 27))
                                        return new CarControlSeatHeaterCommandJSON();
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 't':
                        if ((String.Compare(key, 12, "atusCommand", 0, 11, false) == 0) && (key.Length == 23))
                            return new CarControlStatusCommandJSON();
                        break;
                    default:
                        break;
                  }
                break;
            case 'W':
                if (String.Compare(key, 11, "indow", 0, 5, false) == 0)
                  {
                    switch (key[16])
                      {
                        case 'C':
                            if ((String.Compare(key, 17, "ommand", 0, 6, false) == 0) && (key.Length == 23))
                                return new CarControlWindowCommandJSON();
                            break;
                        case 'I':
                            if ((String.Compare(key, 17, "ntoModeCommand", 0, 14, false) == 0) && (key.Length == 31))
                                return new CarControlWindowIntoModeCommandJSON();
                            break;
                        case 'M':
                            if (String.Compare(key, 17, "ode", 0, 3, false) == 0)
                              {
                                switch (key[20])
                                  {
                                    case 'C':
                                        if ((String.Compare(key, 21, "ancel", 0, 5, false) == 0) && (key.Length == 26))
                                            return new CarControlWindowModeCancelJSON();
                                        break;
                                    case 'N':
                                        if ((String.Compare(key, 21, "otUnderstood", 0, 12, false) == 0) && (key.Length == 33))
                                            return new CarControlWindowModeNotUnderstoodJSON();
                                        break;
                                    default:
                                        break;
                                  }
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
      }

        return new GenericCarControlCommandJSON(key);
      }
  };
