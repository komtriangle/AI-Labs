/* file "ContactDisambiguationCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class ContactDisambiguationCommandJSON : DisambiguateCommandJSON
  {
    private bool flagHasChoices;
    private WhichContactChoicesJSON  storeChoices;
    private bool flagHasUserSpecifiedName;
    private string storeUserSpecifiedName;


    private JSONValue  extraChoicesToJSON()
      {
        JSONValueHandler handler_Choices = new JSONValueHandler();
        storeChoices.write_as_json(handler_Choices);
        return handler_Choices.result;
      }

    private JSONValue  extraUserSpecifiedNameToJSON()
      {
        JSONStringValue generated_string_UserSpecifiedName = new JSONStringValue(storeUserSpecifiedName);
        return generated_string_UserSpecifiedName;
      }


    private void  fromJSONChoices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WhichContactChoicesJSON convert_classy = WhichContactChoicesJSON.from_json(json_value, ignore_extras, true);
        setChoices(convert_classy);
      }


    private void  fromJSONUserSpecifiedName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserSpecifiedName of ContactDisambiguationCommandJSON is not a string.");
        setUserSpecifiedName(json_string.getData());
      }


    public ContactDisambiguationCommandJSON()
      {
        flagHasChoices = false;
        flagHasUserSpecifiedName = false;
      }

    public override string  getDisambiguateCommandKind()
      {
        return "ContactDisambiguation";
      }

    public abstract string getContactDisambiguationKind();
    public bool  hasChoices()
      {
        return flagHasChoices;
      }

    public WhichContactChoicesJSON   getChoices()
      {
        Debug.Assert(flagHasChoices);
        return storeChoices;
      }

    public bool  hasUserSpecifiedName()
      {
        return flagHasUserSpecifiedName;
      }

    public string  getUserSpecifiedName()
      {
        Debug.Assert(flagHasUserSpecifiedName);
        return storeUserSpecifiedName;
      }


    public abstract int extraContactDisambiguationCommandComponentCount();
    public abstract string extraContactDisambiguationCommandComponentKey(int component_num);
    public abstract JSONValue extraContactDisambiguationCommandComponentValue(int component_num);
    public abstract JSONValue extraContactDisambiguationCommandLookup(string field_name);
    public override int extraDisambiguateCommandComponentCount()
      {
        int result = 1;
        if (flagHasChoices)
            ++result;
        if (flagHasUserSpecifiedName)
            ++result;
        result += extraContactDisambiguationCommandComponentCount();
        return result;
      }
    public override string extraDisambiguateCommandComponentKey(int component_num)
      {
        if (component_num == 0)
            return "ContactDisambiguationKind";
        int remainder = (component_num - 1);
        if (flagHasChoices)
          {
            if (remainder == 0)
                return "Choices";
            --remainder;
          }
        if (flagHasUserSpecifiedName)
          {
            if (remainder == 0)
                return "UserSpecifiedName";
            --remainder;
          }
        return extraContactDisambiguationCommandComponentKey(remainder);
      }
    public override JSONValue extraDisambiguateCommandComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getContactDisambiguationKind());
        int remainder = (component_num - 1);
        if (flagHasChoices)
          {
            if (remainder == 0)
                return extraChoicesToJSON();
            --remainder;
          }
        if (flagHasUserSpecifiedName)
          {
            if (remainder == 0)
                return extraUserSpecifiedNameToJSON();
            --remainder;
          }
        return extraContactDisambiguationCommandComponentValue(remainder);
      }
    public override JSONValue extraDisambiguateCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                switch (field_name[1])
                  {
                    case 'h':
                        if ((String.Compare(field_name, 2, "oices", 0, 5, false) == 0) && (field_name.Length == 7))
                            return (flagHasChoices ? extraChoicesToJSON() : null);
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "ntactDisambiguationKind", 0, 23, false) == 0) && (field_name.Length == 25))
                            return new JSONStringValue(getContactDisambiguationKind());
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "serSpecifiedName", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasUserSpecifiedName ? extraUserSpecifiedNameToJSON() : null);
                break;
            default:
                break;
          }
        return extraContactDisambiguationCommandLookup(field_name);
      }

    public void setChoices(WhichContactChoicesJSON  new_value)
      {
        if (flagHasChoices)
          {
          }
        flagHasChoices = true;
        storeChoices = new_value;
      }
    public void unsetChoices()
      {
        if (flagHasChoices)
          {
          }
        flagHasChoices = false;
      }
    public void setUserSpecifiedName(string new_value)
      {
        flagHasUserSpecifiedName = true;
        storeUserSpecifiedName = new_value;
      }
    public void unsetUserSpecifiedName()
      {
        flagHasUserSpecifiedName = false;
      }

    public abstract void extraContactDisambiguationCommandAppendPair(string key, JSONValue new_component);
    public abstract void extraContactDisambiguationCommandSetField(string key, JSONValue new_component);
    public override void extraDisambiguateCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                switch (key[1])
                  {
                    case 'h':
                        if ((String.Compare(key, 2, "oices", 0, 5, false) == 0) && (key.Length == 7))
                            {
                            fromJSONChoices(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "ntactDisambiguationKind", 0, 23, false) == 0) && (key.Length == 25))
                            return;
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serSpecifiedName", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONUserSpecifiedName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraContactDisambiguationCommandAppendPair(key, new_component);
      }
    public override void extraDisambiguateCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                switch (key[1])
                  {
                    case 'h':
                        if ((String.Compare(key, 2, "oices", 0, 5, false) == 0) && (key.Length == 7))
                            {
                            fromJSONChoices(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "ntactDisambiguationKind", 0, 23, false) == 0) && (key.Length == 25))
                            return;
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if ((String.Compare(key, 1, "serSpecifiedName", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONUserSpecifiedName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraContactDisambiguationCommandSetField(key, new_component);
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
        handler.pair("ContactDisambiguationKind", getContactDisambiguationKind());
        Debug.Assert(partial_allowed || flagHasChoices);
        if (flagHasChoices)
          {
            handler.start_pair("Choices");
            if (partial_allowed)
                storeChoices.write_partial_as_json(handler);
            else
                storeChoices.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasUserSpecifiedName);
        if (flagHasUserSpecifiedName)
          {
            handler.start_pair("UserSpecifiedName");
            handler.string_value(storeUserSpecifiedName);
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
        if (!(hasChoices()))
          {
            return "When parsing the object for %what%, the \"Choices\" field was missing.";
          }
        if (!(hasUserSpecifiedName()))
          {
            return "When parsing the object for %what%, the \"UserSpecifiedName\" field was missing.";
          }
        return null;
      }

    public static new ContactDisambiguationCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactDisambiguationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactDisambiguationCommand", ignore_extras);
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
    public static new ContactDisambiguationCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ContactDisambiguationCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactDisambiguationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactDisambiguationCommand", ignore_extras);
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
    public static new ContactDisambiguationCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ContactDisambiguationCommandJSON from_text(string text, bool ignore_extras)
      {
        ContactDisambiguationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactDisambiguationCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ContactDisambiguationCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ContactDisambiguationCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ContactDisambiguationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactDisambiguationCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DisambiguateCommandJSON.Generator
      {
        private WhichContactChoicesJSON.HoldingGenerator fieldGeneratorChoices;
        private JSONHoldingStringGenerator fieldGeneratorUserSpecifiedName;
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
                throw new Exception("The `ContactDisambiguationKind' field is missing.");
            if (!(getDisambiguateCommandJSONKey().Equals("ContactDisambiguation")))
                throw new Exception("The key field has a value other than `ContactDisambiguation'.");
            ContactDisambiguationCommandJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraContactDisambiguationCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getContactDisambiguationCommandJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `ContactDisambiguationKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(DisambiguateCommandJSON new_result)
          {
            handle_result((ContactDisambiguationCommandJSON )new_result);
          }
        protected void finish(ContactDisambiguationCommandJSON result)
          {
            if (fieldGeneratorChoices.have_value)
              {
                result.setChoices(fieldGeneratorChoices.value);
                fieldGeneratorChoices.have_value = false;
              }
            else if ((!(result.hasChoices())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Choices\" field was missing.");
              }
            if (fieldGeneratorUserSpecifiedName.have_value)
              {
                result.setUserSpecifiedName(fieldGeneratorUserSpecifiedName.value);
                fieldGeneratorUserSpecifiedName.have_value = false;
              }
            else if ((!(result.hasUserSpecifiedName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UserSpecifiedName\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ContactDisambiguationCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "oices", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorChoices;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ntactDisambiguationKind", 0, 23, false) == 0) && (field_name.Length == 25))
                                {
                                keyGenerator.reset();
                                return keyGenerator;
                                }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serSpecifiedName", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorUserSpecifiedName;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorChoices = new WhichContactChoicesJSON.HoldingGenerator("field \"Choices\" of the ContactDisambiguationCommand class", ignore_extras);
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the ContactDisambiguationCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ContactDisambiguationKind\" of the ContactDisambiguationCommand class");
            set_what("the ContactDisambiguationCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorChoices = new WhichContactChoicesJSON.HoldingGenerator("field \"Choices\" of the ContactDisambiguationCommand class", false);
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the ContactDisambiguationCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ContactDisambiguationKind\" of the ContactDisambiguationCommand class");
            set_what("the ContactDisambiguationCommand class");
          }

        public override void reset()
          {
            fieldGeneratorChoices.reset();
            fieldGeneratorUserSpecifiedName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ContactDisambiguationCommandJSON  result)
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
        public ContactDisambiguationCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ContactDisambiguationCommandJSON  result)
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
    protected virtual void handle_result(List<ContactDisambiguationCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ContactDisambiguationCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ContactDisambiguationCommandJSON>();
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
    public List<ContactDisambiguationCommandJSON> value;
  };
    class GenericContactDisambiguationCommandJSON : ContactDisambiguationCommandJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericContactDisambiguationCommandJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getContactDisambiguationKind()  { return key; }
        public override int extraContactDisambiguationCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraContactDisambiguationCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraContactDisambiguationCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraContactDisambiguationCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraContactDisambiguationCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraContactDisambiguationCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraContactDisambiguationCommandLookup(key);
            if (old_field == null)
              {
                extraContactDisambiguationCommandAppendPair(key, new_component);
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
    public static new ContactDisambiguationCommandJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    if (String.Compare(key, 0, "C", 0, 1, false) == 0)
      {
        switch (key[1])
          {
            case 'a':
                if ((String.Compare(key, 2, "lendarContactNameDisambiguation", 0, 31, false) == 0) && (key.Length == 33))
                    return new CalendarContactNameDisambiguationCommandJSON();
                break;
            case 'o':
                if ((String.Compare(key, 2, "ntactAccessContactNameDisambiguation", 0, 36, false) == 0) && (key.Length == 38))
                    return new ContactAccessContactNameDisambiguationCommandJSON();
                break;
            default:
                break;
          }
      }

        return new GenericContactDisambiguationCommandJSON(key);
      }
  };
