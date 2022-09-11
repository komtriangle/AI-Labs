/* file "UserMusicControlsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UserMusicControlsJSON : JSONBase
  {
    public enum TypeConditionerChoiceKnownValues
      {
        ConditionerChoice_V1,
        ConditionerChoice_V2,
        ConditionerChoice__none
      };
    public struct TypeConditionerChoice
      {
        public bool in_known_list;
        public string string_value;
        public TypeConditionerChoiceKnownValues list_value;
      };

    public static TypeConditionerChoiceKnownValues  stringToConditionerChoice(string chars)
      {
        if (String.Compare(chars, 0, "V", 0, 1, false) == 0)
          {
            switch (chars[1])
              {
                case '1':
                    if (chars.Length == 2)
                        return TypeConditionerChoiceKnownValues.ConditionerChoice_V1;
                    break;
                case '2':
                    if (chars.Length == 2)
                        return TypeConditionerChoiceKnownValues.ConditionerChoice_V2;
                    break;
                default:
                    break;
              }
          }
        return TypeConditionerChoiceKnownValues.ConditionerChoice__none;
      }

    public static string  stringFromConditionerChoice(TypeConditionerChoiceKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeConditionerChoiceKnownValues.ConditionerChoice_V1:
                return "V1";
            case TypeConditionerChoiceKnownValues.ConditionerChoice_V2:
                return "V2";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasConditionerChoice;
    private TypeConditionerChoice storeConditionerChoice;
    private bool flagHasDumpConditioning;
    private bool storeDumpConditioning;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONConditionerChoice(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ConditionerChoice of UserMusicControlsJSON is not a string.");
        TypeConditionerChoice the_open_enum = new TypeConditionerChoice();
        if (String.Compare(json_string.getData(), 0, "V", 0, 1, false) == 0)
          {
            switch (json_string.getData()[1])
              {
                case '1':
                    if (json_string.getData().Length == 2)
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeConditionerChoiceKnownValues.ConditionerChoice_V1;
                            goto open_enum_is_done;
                          }
                    break;
                case '2':
                    if (json_string.getData().Length == 2)
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeConditionerChoiceKnownValues.ConditionerChoice_V2;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setConditionerChoice(the_open_enum);
      }


    private void  fromJSONDumpConditioning(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field DumpConditioning of UserMusicControlsJSON is not true for false.");
              }
          }
        setDumpConditioning(the_bool);
      }


    public UserMusicControlsJSON()
      {
        flagHasConditionerChoice = false;
        flagHasDumpConditioning = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasConditionerChoice()
      {
        return flagHasConditionerChoice;
      }

    public TypeConditionerChoice  getConditionerChoice()
      {
        Debug.Assert(flagHasConditionerChoice);
        return storeConditionerChoice;
      }

    public string  getConditionerChoiceAsString()
      {
        TypeConditionerChoice result = getConditionerChoice();
        if (result.in_known_list)
            return stringFromConditionerChoice(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasDumpConditioning()
      {
        return flagHasDumpConditioning;
      }

    public bool  getDumpConditioning()
      {
        Debug.Assert(flagHasDumpConditioning);
        return storeDumpConditioning;
      }


    public virtual int extraUserMusicControlsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserMusicControlsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserMusicControlsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserMusicControlsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setConditionerChoice(TypeConditionerChoice new_value)
      {
        flagHasConditionerChoice = true;
        storeConditionerChoice = new_value;
      }
    public void setConditionerChoice(string chars)
      {
        TypeConditionerChoiceKnownValues known = stringToConditionerChoice(chars);
        TypeConditionerChoice new_value = new TypeConditionerChoice();
        if (known == TypeConditionerChoiceKnownValues.ConditionerChoice__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setConditionerChoice(new_value);
      }
    public void setConditionerChoice(TypeConditionerChoiceKnownValues new_value)
      {
        TypeConditionerChoice new_full_value = new TypeConditionerChoice();
        Debug.Assert(new_value != TypeConditionerChoiceKnownValues.ConditionerChoice__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setConditionerChoice(new_full_value);
      }
    public void unsetConditionerChoice()
      {
        flagHasConditionerChoice = false;
      }
    public void setDumpConditioning(bool new_value)
      {
        flagHasDumpConditioning = true;
        storeDumpConditioning = new_value;
      }
    public void unsetDumpConditioning()
      {
        flagHasDumpConditioning = false;
      }

    public virtual void extraUserMusicControlsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserMusicControlsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserMusicControlsLookup(key);
        if (old_field == null)
          {
            extraUserMusicControlsAppendPair(key, new_component);
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

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        if (flagHasConditionerChoice)
          {
            handler.start_pair("ConditionerChoice");
            if (storeConditionerChoice.in_known_list)
              {
                switch (storeConditionerChoice.list_value)
                  {
                    case TypeConditionerChoiceKnownValues.ConditionerChoice_V1:
                        handler.string_value("V1");
                        break;
                    case TypeConditionerChoiceKnownValues.ConditionerChoice_V2:
                        handler.string_value("V2");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeConditionerChoice.string_value);
              }
          }
        if (flagHasDumpConditioning)
          {
            handler.start_pair("DumpConditioning");
            handler.boolean_value(storeDumpConditioning);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static UserMusicControlsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserMusicControlsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMusicControls", ignore_extras);
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
    public static UserMusicControlsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserMusicControlsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserMusicControlsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMusicControls", ignore_extras);
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
    public static UserMusicControlsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserMusicControlsJSON from_text(string text, bool ignore_extras)
      {
        UserMusicControlsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMusicControls", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserMusicControlsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UserMusicControlsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserMusicControlsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMusicControls", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorConditionerChoice : JSONStringGenerator
          {
            protected FieldGeneratorConditionerChoice(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorConditionerChoice()
              {
              }
            protected override void handle_result(string result)
              {
                TypeConditionerChoiceKnownValues known = stringToConditionerChoice(result);
                TypeConditionerChoice new_value = new TypeConditionerChoice();
                if (known == TypeConditionerChoiceKnownValues.ConditionerChoice__none)
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
            protected abstract void handle_result(TypeConditionerChoice result);
          };
    private class FieldHoldingGeneratorConditionerChoice : FieldGeneratorConditionerChoice
  {
    protected override void handle_result(TypeConditionerChoice result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorConditionerChoice(String what)
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
    public TypeConditionerChoice value;
  };
    private class FieldHoldingArrayGeneratorConditionerChoice : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorConditionerChoice
      {
        private FieldHoldingArrayGeneratorConditionerChoice top;

        protected override void handle_result(TypeConditionerChoice result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorConditionerChoice init_top)
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
    protected virtual void handle_result(List<TypeConditionerChoice> result)
      {
      }

    public FieldHoldingArrayGeneratorConditionerChoice(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeConditionerChoice>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorConditionerChoice()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeConditionerChoice>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeConditionerChoice> value;
  };
        private FieldHoldingGeneratorConditionerChoice fieldGeneratorConditionerChoice;
        private JSONHoldingBooleanGenerator fieldGeneratorDumpConditioning;
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
            UserMusicControlsJSON result = new UserMusicControlsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserMusicControlsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UserMusicControlsJSON result)
          {
            if (fieldGeneratorConditionerChoice.have_value)
              {
                result.setConditionerChoice(fieldGeneratorConditionerChoice.value);
                fieldGeneratorConditionerChoice.have_value = false;
              }
            if (fieldGeneratorDumpConditioning.have_value)
              {
                result.setDumpConditioning(fieldGeneratorDumpConditioning.value);
                fieldGeneratorDumpConditioning.have_value = false;
              }
          }
        protected abstract void handle_result(UserMusicControlsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "onditionerChoice", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorConditionerChoice;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "umpConditioning", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorDumpConditioning;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorConditionerChoice = new FieldHoldingGeneratorConditionerChoice("field \"ConditionerChoice\" of the UserMusicControls class");
            fieldGeneratorDumpConditioning = new JSONHoldingBooleanGenerator("field \"DumpConditioning\" of the UserMusicControls class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserMusicControls class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorConditionerChoice = new FieldHoldingGeneratorConditionerChoice("field \"ConditionerChoice\" of the UserMusicControls class");
            fieldGeneratorDumpConditioning = new JSONHoldingBooleanGenerator("field \"DumpConditioning\" of the UserMusicControls class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserMusicControls class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorConditionerChoice.reset();
            fieldGeneratorDumpConditioning.reset();
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
        protected override void handle_result(UserMusicControlsJSON  result)
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
        public UserMusicControlsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserMusicControlsJSON  result)
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
    protected virtual void handle_result(List<UserMusicControlsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserMusicControlsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserMusicControlsJSON>();
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
    public List<UserMusicControlsJSON> value;
  };
  };
