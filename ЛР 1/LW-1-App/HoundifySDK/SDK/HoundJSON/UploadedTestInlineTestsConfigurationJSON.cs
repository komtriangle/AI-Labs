/* file "UploadedTestInlineTestsConfigurationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class UploadedTestInlineTestsConfigurationJSON : JSONBase
  {
    public enum TypeModeKnownValues
      {
        Mode_Speech,
        Mode_Text,
        Mode__none
      };
    public struct TypeMode
      {
        public bool in_known_list;
        public string string_value;
        public TypeModeKnownValues list_value;
      };

    public static TypeModeKnownValues  stringToMode(string chars)
      {
        switch (chars[0])
          {
            case 'S':
                if ((String.Compare(chars, 1, "peech", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeModeKnownValues.Mode_Speech;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "ext", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeModeKnownValues.Mode_Text;
                break;
            default:
                break;
          }
        return TypeModeKnownValues.Mode__none;
      }

    public static string  stringFromMode(TypeModeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeModeKnownValues.Mode_Speech:
                return "Speech";
            case TypeModeKnownValues.Mode_Text:
                return "Text";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasMode;
    private TypeMode storeMode;


    private void  fromJSONMode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Mode of UploadedTestInlineTestsConfigurationJSON is not a string.");
        TypeMode the_open_enum = new TypeMode();
        switch (json_string.getData()[0])
          {
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "peech", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeModeKnownValues.Mode_Speech;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "ext", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeModeKnownValues.Mode_Text;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setMode(the_open_enum);
      }


    public UploadedTestInlineTestsConfigurationJSON()
      {
        flagHasMode = false;
        storeMode.in_known_list = true;
        storeMode.list_value = TypeModeKnownValues.Mode_Speech;
      }

    public abstract string getRun();
    public bool  hasMode()
      {
        return flagHasMode;
      }

    public TypeMode  getMode()
      {
        return storeMode;
      }

    public string  getModeAsString()
      {
        TypeMode result = getMode();
        if (result.in_known_list)
            return stringFromMode(result.list_value);
        else
            return result.string_value;
      }


    public abstract int extraUploadedTestInlineTestsConfigurationComponentCount();
    public abstract string extraUploadedTestInlineTestsConfigurationComponentKey(int component_num);
    public abstract JSONValue extraUploadedTestInlineTestsConfigurationComponentValue(int component_num);
    public abstract JSONValue extraUploadedTestInlineTestsConfigurationLookup(string field_name);

    public void setMode(TypeMode new_value)
      {
        flagHasMode = true;
        storeMode = new_value;
      }
    public void setMode(string chars)
      {
        TypeModeKnownValues known = stringToMode(chars);
        TypeMode new_value = new TypeMode();
        if (known == TypeModeKnownValues.Mode__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setMode(new_value);
      }
    public void setMode(TypeModeKnownValues new_value)
      {
        TypeMode new_full_value = new TypeMode();
        Debug.Assert(new_value != TypeModeKnownValues.Mode__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setMode(new_full_value);
      }
    public void unsetMode()
      {
        flagHasMode = false;
      }

    public abstract void extraUploadedTestInlineTestsConfigurationAppendPair(string key, JSONValue new_component);
    public abstract void extraUploadedTestInlineTestsConfigurationSetField(string key, JSONValue new_component);

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        handler.pair("Run", getRun());
        if (flagHasMode)
          {
            handler.start_pair("Mode");
            if (storeMode.in_known_list)
              {
                switch (storeMode.list_value)
                  {
                    case TypeModeKnownValues.Mode_Speech:
                        handler.string_value("Speech");
                        break;
                    case TypeModeKnownValues.Mode_Text:
                        handler.string_value("Text");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeMode.string_value);
              }
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static UploadedTestInlineTestsConfigurationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedTestInlineTestsConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestInlineTestsConfiguration", ignore_extras);
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
    public static UploadedTestInlineTestsConfigurationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedTestInlineTestsConfigurationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedTestInlineTestsConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestInlineTestsConfiguration", ignore_extras);
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
    public static UploadedTestInlineTestsConfigurationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedTestInlineTestsConfigurationJSON from_text(string text, bool ignore_extras)
      {
        UploadedTestInlineTestsConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestInlineTestsConfiguration", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UploadedTestInlineTestsConfigurationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UploadedTestInlineTestsConfigurationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UploadedTestInlineTestsConfigurationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestInlineTestsConfiguration", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorMode : JSONStringGenerator
          {
            protected FieldGeneratorMode(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorMode()
              {
              }
            protected override void handle_result(string result)
              {
                TypeModeKnownValues known = stringToMode(result);
                TypeMode new_value = new TypeMode();
                if (known == TypeModeKnownValues.Mode__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeMode result);
          };
    private class FieldHoldingGeneratorMode : FieldGeneratorMode
  {
    protected override void handle_result(TypeMode result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorMode(String what)
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
    public TypeMode value;
  };
    private class FieldHoldingArrayGeneratorMode : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMode
      {
        private FieldHoldingArrayGeneratorMode top;

        protected override void handle_result(TypeMode result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMode init_top)
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
    protected virtual void handle_result(List<TypeMode> result)
      {
      }

    public FieldHoldingArrayGeneratorMode(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMode>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMode()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMode>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMode> value;
  };
        private FieldHoldingGeneratorMode fieldGeneratorMode;
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

        protected bool allow_incomplete;

        protected bool allow_unpolished;

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
                throw new Exception("The `Run' field is missing.");
            UploadedTestInlineTestsConfigurationJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUploadedTestInlineTestsConfigurationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getUploadedTestInlineTestsConfigurationJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `Run' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(UploadedTestInlineTestsConfigurationJSON result)
          {
            if (fieldGeneratorMode.have_value)
              {
                result.setMode(fieldGeneratorMode.value);
                fieldGeneratorMode.have_value = false;
              }
          }
        protected abstract void handle_result(UploadedTestInlineTestsConfigurationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'M':
                    if ((String.Compare(field_name, 1, "ode", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorMode;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "un", 0, 2, false) == 0) && (field_name.Length == 3))
                        {
                        keyGenerator.reset();
                        return keyGenerator;
                        }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorMode = new FieldHoldingGeneratorMode("field \"Mode\" of the UploadedTestInlineTestsConfiguration class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"Run\" of the UploadedTestInlineTestsConfiguration class");
            set_what("the UploadedTestInlineTestsConfiguration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorMode = new FieldHoldingGeneratorMode("field \"Mode\" of the UploadedTestInlineTestsConfiguration class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"Run\" of the UploadedTestInlineTestsConfiguration class");
            set_what("the UploadedTestInlineTestsConfiguration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorMode.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UploadedTestInlineTestsConfigurationJSON  result)
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
        public UploadedTestInlineTestsConfigurationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UploadedTestInlineTestsConfigurationJSON  result)
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
    protected virtual void handle_result(List<UploadedTestInlineTestsConfigurationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UploadedTestInlineTestsConfigurationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UploadedTestInlineTestsConfigurationJSON>();
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
    public List<UploadedTestInlineTestsConfigurationJSON> value;
  };
    class GenericUploadedTestInlineTestsConfigurationJSON : UploadedTestInlineTestsConfigurationJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericUploadedTestInlineTestsConfigurationJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getRun()  { return key; }
        public override int extraUploadedTestInlineTestsConfigurationComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraUploadedTestInlineTestsConfigurationComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraUploadedTestInlineTestsConfigurationComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraUploadedTestInlineTestsConfigurationLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraUploadedTestInlineTestsConfigurationAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraUploadedTestInlineTestsConfigurationSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraUploadedTestInlineTestsConfigurationLookup(key);
            if (old_field == null)
              {
                extraUploadedTestInlineTestsConfigurationAppendPair(key, new_component);
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
    public static UploadedTestInlineTestsConfigurationJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {

        return new GenericUploadedTestInlineTestsConfigurationJSON(key);
      }
  };
