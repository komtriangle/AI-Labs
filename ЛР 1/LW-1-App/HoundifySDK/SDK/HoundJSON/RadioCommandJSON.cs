/* file "RadioCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class RadioCommandJSON : CommandResultJSON
  {

    public RadioCommandJSON()
      {
      }

    public override string  getCommandKind()
      {
        return "RadioCommand";
      }

    public abstract string getRadioCommandKind();

    public abstract int extraRadioCommandComponentCount();
    public abstract string extraRadioCommandComponentKey(int component_num);
    public abstract JSONValue extraRadioCommandComponentValue(int component_num);
    public abstract JSONValue extraRadioCommandLookup(string field_name);
    public override int extraCommandResultComponentCount()
      {
        int result = 1;
        result += extraRadioCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        if (component_num == 0)
            return "RadioCommandKind";
        return extraRadioCommandComponentKey((component_num - 1));
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getRadioCommandKind());
        return extraRadioCommandComponentValue((component_num - 1));
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "RadioCommandKind", 0, 16, false) == 0) && (field_name.Length == 16))
            return new JSONStringValue(getRadioCommandKind());
        return extraRadioCommandLookup(field_name);
      }


    public abstract void extraRadioCommandAppendPair(string key, JSONValue new_component);
    public abstract void extraRadioCommandSetField(string key, JSONValue new_component);
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "RadioCommandKind", 0, 16, false) == 0) && (key.Length == 16))
            return;
        extraRadioCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "RadioCommandKind", 0, 16, false) == 0) && (key.Length == 16))
            return;
        extraRadioCommandSetField(key, new_component);
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
        handler.pair("RadioCommandKind", getRadioCommandKind());
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

    public static new RadioCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioCommand", ignore_extras);
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
    public static new RadioCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RadioCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RadioCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioCommand", ignore_extras);
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
    public static new RadioCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RadioCommandJSON from_text(string text, bool ignore_extras)
      {
        RadioCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RadioCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RadioCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RadioCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RadioCommand", ignore_extras);
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
                throw new Exception("The `RadioCommandKind' field is missing.");
            if (!(getCommandResultJSONKey().Equals("RadioCommand")))
                throw new Exception("The key field has a value other than `RadioCommand'.");
            RadioCommandJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRadioCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getRadioCommandJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `RadioCommandKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((RadioCommandJSON )new_result);
          }
        protected void finish(RadioCommandJSON result)
          {
            base.finish(result);
          }
        protected abstract void handle_result(RadioCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "RadioCommandKind", 0, 16, false) == 0) && (field_name.Length == 16))
                {
                keyGenerator.reset();
                return keyGenerator;
                }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"RadioCommandKind\" of the RadioCommand class");
            set_what("the RadioCommand class");
          }
        public Generator() : base(false)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"RadioCommandKind\" of the RadioCommand class");
            set_what("the RadioCommand class");
          }

        public override void reset()
          {
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RadioCommandJSON  result)
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
        public RadioCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RadioCommandJSON  result)
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
    protected virtual void handle_result(List<RadioCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RadioCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RadioCommandJSON>();
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
    public List<RadioCommandJSON> value;
  };
    class GenericRadioCommandJSON : RadioCommandJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericRadioCommandJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getRadioCommandKind()  { return key; }
        public override int extraRadioCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraRadioCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraRadioCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraRadioCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraRadioCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraRadioCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraRadioCommandLookup(key);
            if (old_field == null)
              {
                extraRadioCommandAppendPair(key, new_component);
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
    public static new RadioCommandJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'A':
            if ((String.Compare(key, 1, "MChannel", 0, 8, false) == 0) && (key.Length == 9))
                return new AMChannelCommandJSON();
            break;
        case 'F':
            if ((String.Compare(key, 1, "MChannel", 0, 8, false) == 0) && (key.Length == 9))
                return new FMChannelCommandJSON();
            break;
        case 'N':
            if (String.Compare(key, 1, "ext", 0, 3, false) == 0)
              {
                switch (key[4])
                  {
                    case 'C':
                        if ((String.Compare(key, 5, "hannel", 0, 6, false) == 0) && (key.Length == 11))
                            return new NextChannelCommandJSON();
                        break;
                    case 'P':
                        if ((String.Compare(key, 5, "resetOrChannel", 0, 14, false) == 0) && (key.Length == 19))
                            return new NextPresetOrChannelCommandJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'P':
            if (String.Compare(key, 1, "revious", 0, 7, false) == 0)
              {
                switch (key[8])
                  {
                    case 'C':
                        if ((String.Compare(key, 9, "hannel", 0, 6, false) == 0) && (key.Length == 15))
                            return new PreviousChannelCommandJSON();
                        break;
                    case 'P':
                        if ((String.Compare(key, 9, "resetOrChannel", 0, 14, false) == 0) && (key.Length == 23))
                            return new PreviousPresetOrChannelCommandJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'R':
            if (String.Compare(key, 1, "adio", 0, 4, false) == 0)
              {
                switch (key[5])
                  {
                    case 'O':
                        switch (key[6])
                          {
                            case 'f':
                                if ((String.Compare(key, 7, "f", 0, 1, false) == 0) && (key.Length == 8))
                                    return new RadioOffCommandJSON();
                                break;
                            case 'n':
                                if (key.Length == 7)
                                    return new RadioOnCommandJSON();
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'P':
                        if ((String.Compare(key, 6, "reset", 0, 5, false) == 0) && (key.Length == 11))
                            return new RadioPresetCommandJSON();
                        break;
                    case 'T':
                        if (String.Compare(key, 6, "o", 0, 1, false) == 0)
                          {
                            switch (key[7])
                              {
                                case 'A':
                                    if ((String.Compare(key, 8, "M", 0, 1, false) == 0) && (key.Length == 9))
                                        return new RadioToAMCommandJSON();
                                    break;
                                case 'C':
                                    if ((String.Compare(key, 8, "ustom", 0, 5, false) == 0) && (key.Length == 13))
                                        return new RadioToCustomCommandJSON();
                                    break;
                                case 'F':
                                    if ((String.Compare(key, 8, "M", 0, 1, false) == 0) && (key.Length == 9))
                                        return new RadioToFMCommandJSON();
                                    break;
                                case 'S':
                                    switch (key[8])
                                      {
                                        case 'i':
                                            if ((String.Compare(key, 9, "rius", 0, 4, false) == 0) && (key.Length == 13))
                                                return new RadioToSiriusCommandJSON();
                                            break;
                                        case 'p':
                                            if ((String.Compare(key, 9, "otify", 0, 5, false) == 0) && (key.Length == 14))
                                                return new RadioToSpotifyCommandJSON();
                                            break;
                                        default:
                                            break;
                                      }
                                    break;
                                case 'U':
                                    if ((String.Compare(key, 8, "SB", 0, 2, false) == 0) && (key.Length == 10))
                                        return new RadioToUSBCommandJSON();
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
        case 'S':
            switch (key[1])
              {
                case 'c':
                    if ((String.Compare(key, 2, "anRadio", 0, 7, false) == 0) && (key.Length == 9))
                        return new ScanRadioCommandJSON();
                    break;
                case 'i':
                    if ((String.Compare(key, 2, "riusChannel", 0, 11, false) == 0) && (key.Length == 13))
                        return new SiriusChannelCommandJSON();
                    break;
                default:
                    break;
              }
            break;
        case 'T':
            if ((String.Compare(key, 1, "uneToStationUID", 0, 15, false) == 0) && (key.Length == 16))
                return new TuneToStationUIDCommandJSON();
            break;
        default:
            break;
      }

        return new GenericRadioCommandJSON(key);
      }
  };
