/* file "UserPreferencesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UserPreferencesJSON : JSONBase
  {
    public struct TypeYelpUserPreferences
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public bool choice0;
            [FieldOffset(0)]
            public YelpUserPreferencesJSON  choice1;
          };
        public Utype u;
      };
    private bool flagHasYelpUserPreferences;
    private TypeYelpUserPreferences storeYelpUserPreferences;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONYelpUserPreferences(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeYelpUserPreferences or_result = new TypeYelpUserPreferences();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                YelpUserPreferencesJSON convert_classy = YelpUserPreferencesJSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice1 = convert_classy;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field YelpUserPreferences of UserPreferencesJSON is not one of the allowed values.");
        setYelpUserPreferences(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    public UserPreferencesJSON()
      {
        flagHasYelpUserPreferences = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasYelpUserPreferences()
      {
        return flagHasYelpUserPreferences;
      }

    public TypeYelpUserPreferences  getYelpUserPreferences()
      {
        Debug.Assert(flagHasYelpUserPreferences);
        return storeYelpUserPreferences;
      }


    public virtual int extraUserPreferencesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserPreferencesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserPreferencesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserPreferencesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setYelpUserPreferences(TypeYelpUserPreferences new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHasYelpUserPreferences)
          {
            switch (storeYelpUserPreferences.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasYelpUserPreferences = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeYelpUserPreferences = new_value;
      }
    public void unsetYelpUserPreferences()
      {
        if (flagHasYelpUserPreferences)
          {
            switch (storeYelpUserPreferences.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasYelpUserPreferences = false;
      }

    public virtual void extraUserPreferencesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserPreferencesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserPreferencesLookup(key);
        if (old_field == null)
          {
            extraUserPreferencesAppendPair(key, new_component);
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
        if (flagHasYelpUserPreferences)
          {
            handler.start_pair("YelpUserPreferences");
            switch (storeYelpUserPreferences.key)
              {
                case 0:
                    handler.null_value();
                    break;
                case 1:
                    if (partial_allowed)
                        storeYelpUserPreferences.u.choice1.write_partial_as_json(handler);
                    else
                        storeYelpUserPreferences.u.choice1.write_as_json(handler);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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

    public static UserPreferencesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserPreferencesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserPreferences", ignore_extras);
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
    public static UserPreferencesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserPreferencesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserPreferencesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserPreferences", ignore_extras);
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
    public static UserPreferencesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UserPreferencesJSON from_text(string text, bool ignore_extras)
      {
        UserPreferencesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserPreferences", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserPreferencesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UserPreferencesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserPreferencesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserPreferences", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorYelpUserPreferences : JSONParallelGenerator
          {
            private JSONHoldingNullGenerator field0;
            private YelpUserPreferencesJSON.HoldingGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeYelpUserPreferences result = new TypeYelpUserPreferences();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeYelpUserPreferences result);
            public FieldGeneratorYelpUserPreferences(bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"YelpUserPreferences\"");
                    field1 = new YelpUserPreferencesJSON.HoldingGenerator("option 1 of field \"YelpUserPreferences\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorYelpUserPreferences(string what, bool ignore_extras)
              {
                    field0 = new JSONHoldingNullGenerator("option 0 of field \"YelpUserPreferences\"");
                    field1 = new YelpUserPreferencesJSON.HoldingGenerator("option 1 of field \"YelpUserPreferences\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderYelpUserPreferences
          {
            private bool have_data;
            private TypeYelpUserPreferences data;
            public HolderYelpUserPreferences()  { have_data = false; }
            public HolderYelpUserPreferences(TypeYelpUserPreferences init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderYelpUserPreferences(HolderYelpUserPreferences other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeYelpUserPreferences referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorYelpUserPreferences : FieldGeneratorYelpUserPreferences
          {
            protected override void handle_result(TypeYelpUserPreferences result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderYelpUserPreferences(result);
              }

            public FieldHoldingGeneratorYelpUserPreferences(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderYelpUserPreferences value;
          };
    private class FieldHoldingArrayGeneratorYelpUserPreferences : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorYelpUserPreferences
      {
        private FieldHoldingArrayGeneratorYelpUserPreferences top;

        protected override void handle_result(TypeYelpUserPreferences result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorYelpUserPreferences init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeYelpUserPreferences> result)
      {
      }

    public FieldHoldingArrayGeneratorYelpUserPreferences(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeYelpUserPreferences>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorYelpUserPreferences(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeYelpUserPreferences>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeYelpUserPreferences> value;
  };
        private FieldHoldingGeneratorYelpUserPreferences fieldGeneratorYelpUserPreferences;
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
            UserPreferencesJSON result = new UserPreferencesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserPreferencesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UserPreferencesJSON result)
          {
            if (fieldGeneratorYelpUserPreferences.have_value)
              {
                result.setYelpUserPreferences(fieldGeneratorYelpUserPreferences.value.referenced());
                fieldGeneratorYelpUserPreferences.have_value = false;
              }
          }
        protected abstract void handle_result(UserPreferencesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "YelpUserPreferences", 0, 19, false) == 0) && (field_name.Length == 19))
                return fieldGeneratorYelpUserPreferences;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorYelpUserPreferences = new FieldHoldingGeneratorYelpUserPreferences("field \"YelpUserPreferences\" of the UserPreferences class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserPreferences class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorYelpUserPreferences = new FieldHoldingGeneratorYelpUserPreferences("field \"YelpUserPreferences\" of the UserPreferences class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserPreferences class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorYelpUserPreferences.reset();
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
        protected override void handle_result(UserPreferencesJSON  result)
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
        public UserPreferencesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserPreferencesJSON  result)
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
    protected virtual void handle_result(List<UserPreferencesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserPreferencesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserPreferencesJSON>();
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
    public List<UserPreferencesJSON> value;
  };
  };
