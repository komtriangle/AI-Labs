/* file "BattleshipCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class BattleshipCommandJSON : CommandResultJSON
  {
    private bool flagHasGameName;
    private string storeGameName;


    private JSONValue  extraGameNameToJSON()
      {
        JSONStringValue generated_string_GameName = new JSONStringValue(storeGameName);
        return generated_string_GameName;
      }


    private void  fromJSONGameName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field GameName of BattleshipCommandJSON is not a string.");
        setGameName(json_string.getData());
      }


    public BattleshipCommandJSON()
      {
        flagHasGameName = false;
      }

    public override string  getCommandKind()
      {
        return "BattleshipCommand";
      }

    public abstract string getBattleshipCommandKind();
    public bool  hasGameName()
      {
        return flagHasGameName;
      }

    public string  getGameName()
      {
        Debug.Assert(flagHasGameName);
        return storeGameName;
      }


    public abstract int extraBattleshipCommandComponentCount();
    public abstract string extraBattleshipCommandComponentKey(int component_num);
    public abstract JSONValue extraBattleshipCommandComponentValue(int component_num);
    public abstract JSONValue extraBattleshipCommandLookup(string field_name);
    public override int extraCommandResultComponentCount()
      {
        int result = 1;
        if (flagHasGameName)
            ++result;
        result += extraBattleshipCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        if (component_num == 0)
            return "BattleshipCommandKind";
        int remainder = (component_num - 1);
        if (flagHasGameName)
          {
            if (remainder == 0)
                return "GameName";
            --remainder;
          }
        return extraBattleshipCommandComponentKey(remainder);
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getBattleshipCommandKind());
        int remainder = (component_num - 1);
        if (flagHasGameName)
          {
            if (remainder == 0)
                return extraGameNameToJSON();
            --remainder;
          }
        return extraBattleshipCommandComponentValue(remainder);
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'B':
                if ((String.Compare(field_name, 1, "attleshipCommandKind", 0, 20, false) == 0) && (field_name.Length == 21))
                    return new JSONStringValue(getBattleshipCommandKind());
                break;
            case 'G':
                if ((String.Compare(field_name, 1, "ameName", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasGameName ? extraGameNameToJSON() : null);
                break;
            default:
                break;
          }
        return extraBattleshipCommandLookup(field_name);
      }

    public void setGameName(string new_value)
      {
        flagHasGameName = true;
        storeGameName = new_value;
      }
    public void unsetGameName()
      {
        flagHasGameName = false;
      }

    public abstract void extraBattleshipCommandAppendPair(string key, JSONValue new_component);
    public abstract void extraBattleshipCommandSetField(string key, JSONValue new_component);
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "attleshipCommandKind", 0, 20, false) == 0) && (key.Length == 21))
                    return;
                break;
            case 'G':
                if ((String.Compare(key, 1, "ameName", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONGameName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBattleshipCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'B':
                if ((String.Compare(key, 1, "attleshipCommandKind", 0, 20, false) == 0) && (key.Length == 21))
                    return;
                break;
            case 'G':
                if ((String.Compare(key, 1, "ameName", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONGameName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraBattleshipCommandSetField(key, new_component);
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
        handler.pair("BattleshipCommandKind", getBattleshipCommandKind());
        if (flagHasGameName)
          {
            handler.start_pair("GameName");
            handler.string_value(storeGameName);
          }
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

    public static new BattleshipCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BattleshipCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipCommand", ignore_extras);
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
    public static new BattleshipCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BattleshipCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BattleshipCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipCommand", ignore_extras);
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
    public static new BattleshipCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new BattleshipCommandJSON from_text(string text, bool ignore_extras)
      {
        BattleshipCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BattleshipCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new BattleshipCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BattleshipCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BattleshipCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorGameName;
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
                throw new Exception("The `BattleshipCommandKind' field is missing.");
            if (!(getCommandResultJSONKey().Equals("BattleshipCommand")))
                throw new Exception("The key field has a value other than `BattleshipCommand'.");
            BattleshipCommandJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBattleshipCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getBattleshipCommandJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `BattleshipCommandKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((BattleshipCommandJSON )new_result);
          }
        protected void finish(BattleshipCommandJSON result)
          {
            if (fieldGeneratorGameName.have_value)
              {
                result.setGameName(fieldGeneratorGameName.value);
                fieldGeneratorGameName.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(BattleshipCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "attleshipCommandKind", 0, 20, false) == 0) && (field_name.Length == 21))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "ameName", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorGameName;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorGameName = new JSONHoldingStringGenerator("field \"GameName\" of the BattleshipCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"BattleshipCommandKind\" of the BattleshipCommand class");
            set_what("the BattleshipCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorGameName = new JSONHoldingStringGenerator("field \"GameName\" of the BattleshipCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"BattleshipCommandKind\" of the BattleshipCommand class");
            set_what("the BattleshipCommand class");
          }

        public override void reset()
          {
            fieldGeneratorGameName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(BattleshipCommandJSON  result)
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
        public BattleshipCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BattleshipCommandJSON  result)
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
    protected virtual void handle_result(List<BattleshipCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BattleshipCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BattleshipCommandJSON>();
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
    public List<BattleshipCommandJSON> value;
  };
    class GenericBattleshipCommandJSON : BattleshipCommandJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericBattleshipCommandJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getBattleshipCommandKind()  { return key; }
        public override int extraBattleshipCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraBattleshipCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraBattleshipCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraBattleshipCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraBattleshipCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraBattleshipCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraBattleshipCommandLookup(key);
            if (old_field == null)
              {
                extraBattleshipCommandAppendPair(key, new_component);
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
    public static new BattleshipCommandJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "Battleship", 0, 10, false) == 0)
      {
        switch (key[10])
          {
            case 'D':
                if ((String.Compare(key, 11, "ictateCoordinatesCommand", 0, 24, false) == 0) && (key.Length == 35))
                    return new BattleshipDictateCoordinatesCommandJSON();
                break;
            case 'I':
                if ((String.Compare(key, 11, "nvalidCoordinatesCommand", 0, 24, false) == 0) && (key.Length == 35))
                    return new BattleshipInvalidCoordinatesCommandJSON();
                break;
            case 'N':
                if ((String.Compare(key, 11, "otUnderstoodCommand", 0, 19, false) == 0) && (key.Length == 30))
                    return new BattleshipNotUnderstoodCommandJSON();
                break;
            case 'P':
                if ((String.Compare(key, 11, "layCommand", 0, 10, false) == 0) && (key.Length == 21))
                    return new BattleshipPlayCommandJSON();
                break;
            default:
                break;
          }
      }

        return new GenericBattleshipCommandJSON(key);
      }
  };
