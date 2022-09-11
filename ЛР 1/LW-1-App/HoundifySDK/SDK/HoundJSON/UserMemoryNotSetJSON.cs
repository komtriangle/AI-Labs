/* file "UserMemoryNotSetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UserMemoryNotSetJSON : CommandErrorJSON
  {
    private bool flagHasUserMemoryLabel;
    private string storeUserMemoryLabel;
    private bool flagHasUserMemorySpecialLocation;
    private UserMemorySpecialLocationJSON  storeUserMemorySpecialLocation;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraUserMemoryLabelToJSON()
      {
        JSONStringValue generated_string_UserMemoryLabel = new JSONStringValue(storeUserMemoryLabel);
        return generated_string_UserMemoryLabel;
      }

    private JSONValue  extraUserMemorySpecialLocationToJSON()
      {
        JSONValueHandler handler_UserMemorySpecialLocation = new JSONValueHandler();
        storeUserMemorySpecialLocation.write_as_json(handler_UserMemorySpecialLocation);
        return handler_UserMemorySpecialLocation.result;
      }


    private void  fromJSONUserMemoryLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserMemoryLabel of UserMemoryNotSetJSON is not a string.");
        setUserMemoryLabel(json_string.getData());
      }


    private void  fromJSONUserMemorySpecialLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UserMemorySpecialLocationJSON convert_classy = UserMemorySpecialLocationJSON.from_json(json_value, ignore_extras, true);
        setUserMemorySpecialLocation(convert_classy);
      }


    public UserMemoryNotSetJSON()
      {
        flagHasUserMemoryLabel = false;
        flagHasUserMemorySpecialLocation = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getErrorType()
      {
        return "UserMemoryNotSet";
      }

    public bool  hasUserMemoryLabel()
      {
        return flagHasUserMemoryLabel;
      }

    public string  getUserMemoryLabel()
      {
        Debug.Assert(flagHasUserMemoryLabel);
        return storeUserMemoryLabel;
      }

    public bool  hasUserMemorySpecialLocation()
      {
        return flagHasUserMemorySpecialLocation;
      }

    public UserMemorySpecialLocationJSON   getUserMemorySpecialLocation()
      {
        Debug.Assert(flagHasUserMemorySpecialLocation);
        return storeUserMemorySpecialLocation;
      }

    public UserMemorySpecialLocationJSON.TypeValue  getUserMemorySpecialLocationValue()
      {
        return getUserMemorySpecialLocation().getValue();
      }

    public string  getUserMemorySpecialLocationAsString()
      {
        return getUserMemorySpecialLocation().getValueAsString();
      }


    public virtual int extraUserMemoryNotSetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserMemoryNotSetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserMemoryNotSetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserMemoryNotSetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandErrorComponentCount()
      {
        int result = 0;
        if (flagHasUserMemoryLabel)
            ++result;
        if (flagHasUserMemorySpecialLocation)
            ++result;
        result += extraUserMemoryNotSetComponentCount();
        return result;
      }
    public override string extraCommandErrorComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasUserMemoryLabel)
          {
            if (remainder == 0)
                return "UserMemoryLabel";
            --remainder;
          }
        if (flagHasUserMemorySpecialLocation)
          {
            if (remainder == 0)
                return "UserMemorySpecialLocation";
            --remainder;
          }
        return extraUserMemoryNotSetComponentKey(remainder);
      }
    public override JSONValue extraCommandErrorComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasUserMemoryLabel)
          {
            if (remainder == 0)
                return extraUserMemoryLabelToJSON();
            --remainder;
          }
        if (flagHasUserMemorySpecialLocation)
          {
            if (remainder == 0)
                return extraUserMemorySpecialLocationToJSON();
            --remainder;
          }
        return extraUserMemoryNotSetComponentValue(remainder);
      }
    public override JSONValue extraCommandErrorLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "UserMemory", 0, 10, false) == 0)
          {
            switch (field_name[10])
              {
                case 'L':
                    if ((String.Compare(field_name, 11, "abel", 0, 4, false) == 0) && (field_name.Length == 15))
                        return (flagHasUserMemoryLabel ? extraUserMemoryLabelToJSON() : null);
                    break;
                case 'S':
                    if ((String.Compare(field_name, 11, "pecialLocation", 0, 14, false) == 0) && (field_name.Length == 25))
                        return (flagHasUserMemorySpecialLocation ? extraUserMemorySpecialLocationToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraUserMemoryNotSetLookup(field_name);
      }

    public void setUserMemoryLabel(string new_value)
      {
        flagHasUserMemoryLabel = true;
        storeUserMemoryLabel = new_value;
      }
    public void unsetUserMemoryLabel()
      {
        flagHasUserMemoryLabel = false;
      }
    public void setUserMemorySpecialLocation(UserMemorySpecialLocationJSON  new_value)
      {
        if (flagHasUserMemorySpecialLocation)
          {
          }
        flagHasUserMemorySpecialLocation = true;
        storeUserMemorySpecialLocation = new_value;
      }
    public void setUserMemorySpecialLocation(UserMemorySpecialLocationJSON.TypeValue new_value)
      {
        setUserMemorySpecialLocation(new UserMemorySpecialLocationJSON(new_value));
      }
    public void setUserMemorySpecialLocation(string chars)
      {
        UserMemorySpecialLocationJSON.TypeValueKnownValues known = UserMemorySpecialLocationJSON.stringToValue(chars);
        UserMemorySpecialLocationJSON.TypeValue new_value = new UserMemorySpecialLocationJSON.TypeValue();
        if (known == UserMemorySpecialLocationJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setUserMemorySpecialLocation(new_value);
      }
    public void unsetUserMemorySpecialLocation()
      {
        if (flagHasUserMemorySpecialLocation)
          {
          }
        flagHasUserMemorySpecialLocation = false;
      }

    public virtual void extraUserMemoryNotSetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserMemoryNotSetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserMemoryNotSetLookup(key);
        if (old_field == null)
          {
            extraUserMemoryNotSetAppendPair(key, new_component);
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
    public override void extraCommandErrorAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "UserMemory", 0, 10, false) == 0)
          {
            switch (key[10])
              {
                case 'L':
                    if ((String.Compare(key, 11, "abel", 0, 4, false) == 0) && (key.Length == 15))
                        {
                        fromJSONUserMemoryLabel(new_component, false);
                        return;
                        }
                    break;
                case 'S':
                    if ((String.Compare(key, 11, "pecialLocation", 0, 14, false) == 0) && (key.Length == 25))
                        {
                        fromJSONUserMemorySpecialLocation(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraUserMemoryNotSetAppendPair(key, new_component);
      }
    public override void extraCommandErrorSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "UserMemory", 0, 10, false) == 0)
          {
            switch (key[10])
              {
                case 'L':
                    if ((String.Compare(key, 11, "abel", 0, 4, false) == 0) && (key.Length == 15))
                        {
                        fromJSONUserMemoryLabel(new_component, false);
                        return;
                        }
                    break;
                case 'S':
                    if ((String.Compare(key, 11, "pecialLocation", 0, 14, false) == 0) && (key.Length == 25))
                        {
                        fromJSONUserMemorySpecialLocation(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraUserMemoryNotSetSetField(key, new_component);
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
        if (flagHasUserMemoryLabel)
          {
            handler.start_pair("UserMemoryLabel");
            handler.string_value(storeUserMemoryLabel);
          }
        if (flagHasUserMemorySpecialLocation)
          {
            handler.start_pair("UserMemorySpecialLocation");
            if (partial_allowed)
                storeUserMemorySpecialLocation.write_partial_as_json(handler);
            else
                storeUserMemorySpecialLocation.write_as_json(handler);
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

    public static new UserMemoryNotSetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserMemoryNotSetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMemoryNotSet", ignore_extras);
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
    public static new UserMemoryNotSetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UserMemoryNotSetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserMemoryNotSetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMemoryNotSet", ignore_extras);
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
    public static new UserMemoryNotSetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UserMemoryNotSetJSON from_text(string text, bool ignore_extras)
      {
        UserMemoryNotSetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMemoryNotSet", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserMemoryNotSetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UserMemoryNotSetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserMemoryNotSetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserMemoryNotSet", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandErrorJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorUserMemoryLabel;
        private UserMemorySpecialLocationJSON.HoldingGenerator fieldGeneratorUserMemorySpecialLocation;
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
            if (!(getCommandErrorJSONKey().Equals("UserMemoryNotSet")))
                throw new Exception("The key field has a value other than `UserMemoryNotSet'.");
            UserMemoryNotSetJSON result = new UserMemoryNotSetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserMemoryNotSetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandErrorJSON new_result)
          {
            handle_result((UserMemoryNotSetJSON )new_result);
          }
        protected void finish(UserMemoryNotSetJSON result)
          {
            if (fieldGeneratorUserMemoryLabel.have_value)
              {
                result.setUserMemoryLabel(fieldGeneratorUserMemoryLabel.value);
                fieldGeneratorUserMemoryLabel.have_value = false;
              }
            if (fieldGeneratorUserMemorySpecialLocation.have_value)
              {
                result.setUserMemorySpecialLocation(fieldGeneratorUserMemorySpecialLocation.value);
                fieldGeneratorUserMemorySpecialLocation.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(UserMemoryNotSetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "UserMemory", 0, 10, false) == 0)
              {
                switch (field_name[10])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 11, "abel", 0, 4, false) == 0) && (field_name.Length == 15))
                            return fieldGeneratorUserMemoryLabel;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 11, "pecialLocation", 0, 14, false) == 0) && (field_name.Length == 25))
                            return fieldGeneratorUserMemorySpecialLocation;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUserMemoryLabel = new JSONHoldingStringGenerator("field \"UserMemoryLabel\" of the UserMemoryNotSet class");
            fieldGeneratorUserMemorySpecialLocation = new UserMemorySpecialLocationJSON.HoldingGenerator("field \"UserMemorySpecialLocation\" of the UserMemoryNotSet class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserMemoryNotSet class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUserMemoryLabel = new JSONHoldingStringGenerator("field \"UserMemoryLabel\" of the UserMemoryNotSet class");
            fieldGeneratorUserMemorySpecialLocation = new UserMemorySpecialLocationJSON.HoldingGenerator("field \"UserMemorySpecialLocation\" of the UserMemoryNotSet class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserMemoryNotSet class");
          }

        public override void reset()
          {
            fieldGeneratorUserMemoryLabel.reset();
            fieldGeneratorUserMemorySpecialLocation.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UserMemoryNotSetJSON  result)
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
        public UserMemoryNotSetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserMemoryNotSetJSON  result)
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
    protected virtual void handle_result(List<UserMemoryNotSetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserMemoryNotSetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserMemoryNotSetJSON>();
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
    public List<UserMemoryNotSetJSON> value;
  };
  };
