/* file "UserContactsDeleteRequestJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UserContactsDeleteRequestJSON : UserContactsRequestJSON
  {
    private bool flagHasKeyFieldName;
    private string storeKeyFieldName;
    private bool flagHasMatchValue;
    private JSONValue  storeMatchValue;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraKeyFieldNameToJSON()
      {
        JSONStringValue generated_string_KeyFieldName = new JSONStringValue(storeKeyFieldName);
        return generated_string_KeyFieldName;
      }

    private JSONValue  extraMatchValueToJSON()
      {
        return storeMatchValue;
      }


    private void  fromJSONKeyFieldName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field KeyFieldName of UserContactsDeleteRequestJSON is not a string.");
        setKeyFieldName(json_string.getData());
      }


    private void  fromJSONMatchValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        setMatchValue(json_value);
      }


    public UserContactsDeleteRequestJSON()
      {
        flagHasKeyFieldName = false;
        flagHasMatchValue = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRequestKind()
      {
        return "Delete";
      }

    public bool  hasKeyFieldName()
      {
        return flagHasKeyFieldName;
      }

    public string  getKeyFieldName()
      {
        Debug.Assert(flagHasKeyFieldName);
        return storeKeyFieldName;
      }

    public bool  hasMatchValue()
      {
        return flagHasMatchValue;
      }

    public JSONValue   getMatchValue()
      {
        Debug.Assert(flagHasMatchValue);
        return storeMatchValue;
      }


    public virtual int extraUserContactsDeleteRequestComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserContactsDeleteRequestComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserContactsDeleteRequestComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserContactsDeleteRequestLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUserContactsRequestComponentCount()
      {
        int result = 0;
        if (flagHasKeyFieldName)
            ++result;
        if (flagHasMatchValue)
            ++result;
        result += extraUserContactsDeleteRequestComponentCount();
        return result;
      }
    public override string extraUserContactsRequestComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasKeyFieldName)
          {
            if (remainder == 0)
                return "KeyFieldName";
            --remainder;
          }
        if (flagHasMatchValue)
          {
            if (remainder == 0)
                return "MatchValue";
            --remainder;
          }
        return extraUserContactsDeleteRequestComponentKey(remainder);
      }
    public override JSONValue extraUserContactsRequestComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasKeyFieldName)
          {
            if (remainder == 0)
                return extraKeyFieldNameToJSON();
            --remainder;
          }
        if (flagHasMatchValue)
          {
            if (remainder == 0)
                return extraMatchValueToJSON();
            --remainder;
          }
        return extraUserContactsDeleteRequestComponentValue(remainder);
      }
    public override JSONValue extraUserContactsRequestLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'K':
                if ((String.Compare(field_name, 1, "eyFieldName", 0, 11, false) == 0) && (field_name.Length == 12))
                    return (flagHasKeyFieldName ? extraKeyFieldNameToJSON() : null);
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "atchValue", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasMatchValue ? extraMatchValueToJSON() : null);
                break;
            default:
                break;
          }
        return extraUserContactsDeleteRequestLookup(field_name);
      }

    public void setKeyFieldName(string new_value)
      {
        flagHasKeyFieldName = true;
        storeKeyFieldName = new_value;
      }
    public void unsetKeyFieldName()
      {
        flagHasKeyFieldName = false;
      }
    public void setMatchValue(JSONValue  new_value)
      {
        if (flagHasMatchValue)
          {
          }
        flagHasMatchValue = true;
        storeMatchValue = new_value;
      }
    public void unsetMatchValue()
      {
        if (flagHasMatchValue)
          {
          }
        flagHasMatchValue = false;
      }

    public virtual void extraUserContactsDeleteRequestAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserContactsDeleteRequestSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserContactsDeleteRequestLookup(key);
        if (old_field == null)
          {
            extraUserContactsDeleteRequestAppendPair(key, new_component);
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
    public override void extraUserContactsRequestAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'K':
                if ((String.Compare(key, 1, "eyFieldName", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONKeyFieldName(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "atchValue", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONMatchValue(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraUserContactsDeleteRequestAppendPair(key, new_component);
      }
    public override void extraUserContactsRequestSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'K':
                if ((String.Compare(key, 1, "eyFieldName", 0, 11, false) == 0) && (key.Length == 12))
                    {
                    fromJSONKeyFieldName(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "atchValue", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONMatchValue(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraUserContactsDeleteRequestSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasKeyFieldName);
        if (flagHasKeyFieldName)
          {
            handler.start_pair("KeyFieldName");
            handler.string_value(storeKeyFieldName);
          }
        Debug.Assert(partial_allowed || flagHasMatchValue);
        if (flagHasMatchValue)
          {
            handler.start_pair("MatchValue");
            storeMatchValue.write(handler);
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
        if (!(hasKeyFieldName()))
          {
            return "When parsing the object for %what%, the \"KeyFieldName\" field was missing.";
          }
        if (!(hasMatchValue()))
          {
            return "When parsing the object for %what%, the \"MatchValue\" field was missing.";
          }
        return null;
      }

    public static new UserContactsDeleteRequestJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserContactsDeleteRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserContactsDeleteRequest", ignore_extras);
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
    public static new UserContactsDeleteRequestJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UserContactsDeleteRequestJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserContactsDeleteRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserContactsDeleteRequest", ignore_extras);
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
    public static new UserContactsDeleteRequestJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UserContactsDeleteRequestJSON from_text(string text, bool ignore_extras)
      {
        UserContactsDeleteRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserContactsDeleteRequest", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserContactsDeleteRequestJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UserContactsDeleteRequestJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserContactsDeleteRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserContactsDeleteRequest", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UserContactsRequestJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorKeyFieldName;
        private JSONHoldingValueGenerator fieldGeneratorMatchValue;
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
            if (!(getUserContactsRequestJSONKey().Equals("Delete")))
                throw new Exception("The key field has a value other than `Delete'.");
            UserContactsDeleteRequestJSON result = new UserContactsDeleteRequestJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserContactsDeleteRequestAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UserContactsRequestJSON new_result)
          {
            handle_result((UserContactsDeleteRequestJSON )new_result);
          }
        protected void finish(UserContactsDeleteRequestJSON result)
          {
            if (fieldGeneratorKeyFieldName.have_value)
              {
                result.setKeyFieldName(fieldGeneratorKeyFieldName.value);
                fieldGeneratorKeyFieldName.have_value = false;
              }
            else if ((!(result.hasKeyFieldName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"KeyFieldName\" field was missing.");
              }
            if (fieldGeneratorMatchValue.have_value)
              {
                result.setMatchValue(fieldGeneratorMatchValue.value);
                fieldGeneratorMatchValue.have_value = false;
              }
            else if ((!(result.hasMatchValue())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MatchValue\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(UserContactsDeleteRequestJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'K':
                    if ((String.Compare(field_name, 1, "eyFieldName", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorKeyFieldName;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "atchValue", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorMatchValue;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorKeyFieldName = new JSONHoldingStringGenerator("field \"KeyFieldName\" of the UserContactsDeleteRequest class");
            fieldGeneratorMatchValue = new JSONHoldingValueGenerator("field \"MatchValue\" of the UserContactsDeleteRequest class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserContactsDeleteRequest class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorKeyFieldName = new JSONHoldingStringGenerator("field \"KeyFieldName\" of the UserContactsDeleteRequest class");
            fieldGeneratorMatchValue = new JSONHoldingValueGenerator("field \"MatchValue\" of the UserContactsDeleteRequest class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserContactsDeleteRequest class");
          }

        public override void reset()
          {
            fieldGeneratorKeyFieldName.reset();
            fieldGeneratorMatchValue.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UserContactsDeleteRequestJSON  result)
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
        public UserContactsDeleteRequestJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserContactsDeleteRequestJSON  result)
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
    protected virtual void handle_result(List<UserContactsDeleteRequestJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserContactsDeleteRequestJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserContactsDeleteRequestJSON>();
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
    public List<UserContactsDeleteRequestJSON> value;
  };
  };
