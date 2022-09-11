/* file "IHeartRadioCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class IHeartRadioCommandJSON : CommandResultJSON
  {

    public IHeartRadioCommandJSON()
      {
      }

    public override string  getCommandKind()
      {
        return "IHeartRadioCommand";
      }

    public abstract string getIHeartRadioCommandKind();

    public abstract int extraIHeartRadioCommandComponentCount();
    public abstract string extraIHeartRadioCommandComponentKey(int component_num);
    public abstract JSONValue extraIHeartRadioCommandComponentValue(int component_num);
    public abstract JSONValue extraIHeartRadioCommandLookup(string field_name);
    public override int extraCommandResultComponentCount()
      {
        int result = 1;
        result += extraIHeartRadioCommandComponentCount();
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        if (component_num == 0)
            return "IHeartRadioCommandKind";
        return extraIHeartRadioCommandComponentKey((component_num - 1));
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getIHeartRadioCommandKind());
        return extraIHeartRadioCommandComponentValue((component_num - 1));
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "IHeartRadioCommandKind", 0, 22, false) == 0) && (field_name.Length == 22))
            return new JSONStringValue(getIHeartRadioCommandKind());
        return extraIHeartRadioCommandLookup(field_name);
      }


    public abstract void extraIHeartRadioCommandAppendPair(string key, JSONValue new_component);
    public abstract void extraIHeartRadioCommandSetField(string key, JSONValue new_component);
    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "IHeartRadioCommandKind", 0, 22, false) == 0) && (key.Length == 22))
            return;
        extraIHeartRadioCommandAppendPair(key, new_component);
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "IHeartRadioCommandKind", 0, 22, false) == 0) && (key.Length == 22))
            return;
        extraIHeartRadioCommandSetField(key, new_component);
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
        handler.pair("IHeartRadioCommandKind", getIHeartRadioCommandKind());
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

    public static new IHeartRadioCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioCommand", ignore_extras);
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
    public static new IHeartRadioCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new IHeartRadioCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioCommand", ignore_extras);
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
    public static new IHeartRadioCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new IHeartRadioCommandJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new IHeartRadioCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioCommand", ignore_extras);
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
                throw new Exception("The `IHeartRadioCommandKind' field is missing.");
            if (!(getCommandResultJSONKey().Equals("IHeartRadioCommand")))
                throw new Exception("The key field has a value other than `IHeartRadioCommand'.");
            IHeartRadioCommandJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getIHeartRadioCommandJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `IHeartRadioCommandKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((IHeartRadioCommandJSON )new_result);
          }
        protected void finish(IHeartRadioCommandJSON result)
          {
            base.finish(result);
          }
        protected abstract void handle_result(IHeartRadioCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "IHeartRadioCommandKind", 0, 22, false) == 0) && (field_name.Length == 22))
                {
                keyGenerator.reset();
                return keyGenerator;
                }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"IHeartRadioCommandKind\" of the IHeartRadioCommand class");
            set_what("the IHeartRadioCommand class");
          }
        public Generator() : base(false)
          {
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"IHeartRadioCommandKind\" of the IHeartRadioCommand class");
            set_what("the IHeartRadioCommand class");
          }

        public override void reset()
          {
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioCommandJSON  result)
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
        public IHeartRadioCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioCommandJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioCommandJSON>();
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
    public List<IHeartRadioCommandJSON> value;
  };
    class GenericIHeartRadioCommandJSON : IHeartRadioCommandJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericIHeartRadioCommandJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getIHeartRadioCommandKind()  { return key; }
        public override int extraIHeartRadioCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraIHeartRadioCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraIHeartRadioCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraIHeartRadioCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraIHeartRadioCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraIHeartRadioCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraIHeartRadioCommandLookup(key);
            if (old_field == null)
              {
                extraIHeartRadioCommandAppendPair(key, new_component);
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
    public static new IHeartRadioCommandJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if ((String.Compare(key, 0, "StationPlayIHeartRadioCommand", 0, 29, false) == 0) && (key.Length == 29))
        return new StationPlayIHeartRadioCommandJSON();

        return new GenericIHeartRadioCommandJSON(key);
      }
  };
