/* file "GuessThatLyricConversationStateElementJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class GuessThatLyricConversationStateElementJSON : MusicConversationStateElementJSON
  {
    public enum TypeCommandKind
      {
        CommandKind_GuessThatLyricCommand
      };

    public static TypeCommandKind  stringToCommandKind(string chars)
      {
        if ((String.Compare(chars, 0, "GuessThatLyricCommand", 0, 21, false) == 0) && (chars.Length == 21))
            return TypeCommandKind.CommandKind_GuessThatLyricCommand;
        throw new Exception("The value for field `CommandKind' is not one of the legal values.");
      }

    public static string  stringFromCommandKind(TypeCommandKind the_enum)
      {
        switch (the_enum)
          {
            case TypeCommandKind.CommandKind_GuessThatLyricCommand:
                return "GuessThatLyricCommand";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCommandKind;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCommandKindToJSON()
      {
        JSONStringValue generated_string_CommandKind;
        generated_string_CommandKind = new JSONStringValue("GuessThatLyricCommand");
        return generated_string_CommandKind;
      }


    private void  fromJSONCommandKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CommandKind of GuessThatLyricConversationStateElementJSON is not a string.");
        if (!(json_string.getData().Equals("GuessThatLyricCommand")))
            throw new Exception("The value for field CommandKind of GuessThatLyricConversationStateElementJSON is not `GuessThatLyricCommand'.");
        setCommandKind();
      }


    public GuessThatLyricConversationStateElementJSON()
      {
        flagHasCommandKind = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getMusicConversationStateElementKind()
      {
        return "GuessThatLyricConversationStateElement";
      }

    public bool  hasCommandKind()
      {
        return flagHasCommandKind;
      }

    public TypeCommandKind  getCommandKind()
      {
        Debug.Assert(flagHasCommandKind);
        return TypeCommandKind.CommandKind_GuessThatLyricCommand;
      }

    public string  getCommandKindAsString()
      {
        return stringFromCommandKind(getCommandKind());
      }


    public virtual int extraGuessThatLyricConversationStateElementComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGuessThatLyricConversationStateElementComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGuessThatLyricConversationStateElementComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGuessThatLyricConversationStateElementLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMusicConversationStateElementComponentCount()
      {
        int result = 0;
        if (flagHasCommandKind)
            ++result;
        result += extraGuessThatLyricConversationStateElementComponentCount();
        return result;
      }
    public override string extraMusicConversationStateElementComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandKind)
          {
            if (remainder == 0)
                return "CommandKind";
            --remainder;
          }
        return extraGuessThatLyricConversationStateElementComponentKey(remainder);
      }
    public override JSONValue extraMusicConversationStateElementComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCommandKind)
          {
            if (remainder == 0)
                return extraCommandKindToJSON();
            --remainder;
          }
        return extraGuessThatLyricConversationStateElementComponentValue(remainder);
      }
    public override JSONValue extraMusicConversationStateElementLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "CommandKind", 0, 11, false) == 0) && (field_name.Length == 11))
            return (flagHasCommandKind ? extraCommandKindToJSON() : null);
        return extraGuessThatLyricConversationStateElementLookup(field_name);
      }

    public void setCommandKind()
      {
        flagHasCommandKind = true;
      }
    public void setCommandKind(TypeCommandKind new_value)
      {
        setCommandKind();
      }
    public void setCommandKind(string chars)
      {
        setCommandKind(stringToCommandKind(chars));
      }
    public void unsetCommandKind()
      {
        flagHasCommandKind = false;
      }

    public virtual void extraGuessThatLyricConversationStateElementAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGuessThatLyricConversationStateElementSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGuessThatLyricConversationStateElementLookup(key);
        if (old_field == null)
          {
            extraGuessThatLyricConversationStateElementAppendPair(key, new_component);
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
    public override void extraMusicConversationStateElementAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "CommandKind", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONCommandKind(new_component, false);
            return;
            }
        extraGuessThatLyricConversationStateElementAppendPair(key, new_component);
      }
    public override void extraMusicConversationStateElementSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "CommandKind", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONCommandKind(new_component, false);
            return;
            }
        extraGuessThatLyricConversationStateElementSetField(key, new_component);
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
        if (flagHasCommandKind)
          {
            handler.start_pair("CommandKind");
            handler.string_value("GuessThatLyricCommand");
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

    public static new GuessThatLyricConversationStateElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GuessThatLyricConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GuessThatLyricConversationStateElement", ignore_extras);
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
    public static new GuessThatLyricConversationStateElementJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GuessThatLyricConversationStateElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GuessThatLyricConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GuessThatLyricConversationStateElement", ignore_extras);
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
    public static new GuessThatLyricConversationStateElementJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GuessThatLyricConversationStateElementJSON from_text(string text, bool ignore_extras)
      {
        GuessThatLyricConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GuessThatLyricConversationStateElement", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GuessThatLyricConversationStateElementJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new GuessThatLyricConversationStateElementJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GuessThatLyricConversationStateElementJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GuessThatLyricConversationStateElement", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MusicConversationStateElementJSON.Generator
      {
    private abstract class FieldGeneratorCommandKind : JSONStringGenerator
          {
            protected FieldGeneratorCommandKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCommandKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCommandKind(result));
              }
            protected abstract void handle_result(TypeCommandKind result);
          };
    private class FieldHoldingGeneratorCommandKind : FieldGeneratorCommandKind
  {
    protected override void handle_result(TypeCommandKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCommandKind(String what)
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
    public TypeCommandKind value;
  };
    private class FieldHoldingArrayGeneratorCommandKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCommandKind
      {
        private FieldHoldingArrayGeneratorCommandKind top;

        protected override void handle_result(TypeCommandKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCommandKind init_top)
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
    protected virtual void handle_result(List<TypeCommandKind> result)
      {
      }

    public FieldHoldingArrayGeneratorCommandKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCommandKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCommandKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCommandKind> value;
  };
        private FieldHoldingGeneratorCommandKind fieldGeneratorCommandKind;
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
            if (!(getMusicConversationStateElementJSONKey().Equals("GuessThatLyricConversationStateElement")))
                throw new Exception("The key field has a value other than `GuessThatLyricConversationStateElement'.");
            GuessThatLyricConversationStateElementJSON result = new GuessThatLyricConversationStateElementJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGuessThatLyricConversationStateElementAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MusicConversationStateElementJSON new_result)
          {
            handle_result((GuessThatLyricConversationStateElementJSON )new_result);
          }
        protected void finish(GuessThatLyricConversationStateElementJSON result)
          {
            if (fieldGeneratorCommandKind.have_value)
              {
                result.setCommandKind();
                fieldGeneratorCommandKind.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(GuessThatLyricConversationStateElementJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "CommandKind", 0, 11, false) == 0) && (field_name.Length == 11))
                return fieldGeneratorCommandKind;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the GuessThatLyricConversationStateElement class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GuessThatLyricConversationStateElement class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCommandKind = new FieldHoldingGeneratorCommandKind("field \"CommandKind\" of the GuessThatLyricConversationStateElement class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GuessThatLyricConversationStateElement class");
          }

        public override void reset()
          {
            fieldGeneratorCommandKind.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(GuessThatLyricConversationStateElementJSON  result)
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
        public GuessThatLyricConversationStateElementJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GuessThatLyricConversationStateElementJSON  result)
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
    protected virtual void handle_result(List<GuessThatLyricConversationStateElementJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GuessThatLyricConversationStateElementJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GuessThatLyricConversationStateElementJSON>();
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
    public List<GuessThatLyricConversationStateElementJSON> value;
  };
  };
