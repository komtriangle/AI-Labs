/* file "UserContactsAddRequestJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UserContactsAddRequestJSON : UserContactsRequestJSON
  {
    private bool flagHasNewContacts;
    private List< OneContactJSON  > storeNewContacts;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNewContactsToJSON()
      {
        JSONArrayValue generated_array_1_NewContacts = new JSONArrayValue();
        for (int num1 = 0; num1 < storeNewContacts.Count; ++num1)
          {
            JSONValueHandler handler_NewContacts = new JSONValueHandler();
            storeNewContacts[num1].write_as_json(handler_NewContacts);
            generated_array_1_NewContacts.appendComponent(handler_NewContacts.result);
          }
        return generated_array_1_NewContacts;
      }


    private void  fromJSONNewContacts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NewContacts of UserContactsAddRequestJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field NewContacts of UserContactsAddRequestJSON has too few elements.");
        List< OneContactJSON  > vector_NewContacts1 = new List< OneContactJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            OneContactJSON convert_classy = OneContactJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_NewContacts1.Add(convert_classy);
          }
        Debug.Assert(vector_NewContacts1.Count >= 1);
        initNewContacts();
        for (int num1 = 0; num1 < vector_NewContacts1.Count; ++num1)
            appendNewContacts(vector_NewContacts1[num1]);
        for (int num1 = 0; num1 < vector_NewContacts1.Count; ++num1)
          {
          }
      }


    public UserContactsAddRequestJSON()
      {
        flagHasNewContacts = false;
        storeNewContacts = new List< OneContactJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRequestKind()
      {
        return "Add";
      }

    public bool  hasNewContacts()
      {
        return flagHasNewContacts;
      }

    public int  countOfNewContacts()
      {
        Debug.Assert(flagHasNewContacts);
        return storeNewContacts.Count;
      }

    public OneContactJSON   elementOfNewContacts(int element_num)
      {
        Debug.Assert(flagHasNewContacts);
        return storeNewContacts[element_num];
      }

    public List< OneContactJSON  >  getNewContacts()
      {
        Debug.Assert(flagHasNewContacts);
        return storeNewContacts;
      }


    public virtual int extraUserContactsAddRequestComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserContactsAddRequestComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserContactsAddRequestComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserContactsAddRequestLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUserContactsRequestComponentCount()
      {
        int result = 0;
        if (flagHasNewContacts)
            ++result;
        result += extraUserContactsAddRequestComponentCount();
        return result;
      }
    public override string extraUserContactsRequestComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNewContacts)
          {
            if (remainder == 0)
                return "NewContacts";
            --remainder;
          }
        return extraUserContactsAddRequestComponentKey(remainder);
      }
    public override JSONValue extraUserContactsRequestComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNewContacts)
          {
            if (remainder == 0)
                return extraNewContactsToJSON();
            --remainder;
          }
        return extraUserContactsAddRequestComponentValue(remainder);
      }
    public override JSONValue extraUserContactsRequestLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NewContacts", 0, 11, false) == 0) && (field_name.Length == 11))
            return (flagHasNewContacts ? extraNewContactsToJSON() : null);
        return extraUserContactsAddRequestLookup(field_name);
      }

    public void initNewContacts()
      {
        if (flagHasNewContacts)
          {
            for (int num1 = 0; num1 < storeNewContacts.Count; ++num1)
              {
              }
          }
        flagHasNewContacts = true;
        storeNewContacts.Clear();
      }
    public void appendNewContacts(OneContactJSON  to_append)
      {
        if (!flagHasNewContacts)
          {
            flagHasNewContacts = true;
            storeNewContacts.Clear();
          }
        Debug.Assert(flagHasNewContacts);
        storeNewContacts.Add(to_append);
      }
    public void unsetNewContacts()
      {
        if (flagHasNewContacts)
          {
            for (int num2 = 0; num2 < storeNewContacts.Count; ++num2)
              {
              }
          }
        flagHasNewContacts = false;
        storeNewContacts.Clear();
      }

    public virtual void extraUserContactsAddRequestAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserContactsAddRequestSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserContactsAddRequestLookup(key);
        if (old_field == null)
          {
            extraUserContactsAddRequestAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "NewContacts", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONNewContacts(new_component, false);
            return;
            }
        extraUserContactsAddRequestAppendPair(key, new_component);
      }
    public override void extraUserContactsRequestSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NewContacts", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONNewContacts(new_component, false);
            return;
            }
        extraUserContactsAddRequestSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNewContacts);
        if (flagHasNewContacts)
          {
            handler.start_pair("NewContacts");
            Debug.Assert(storeNewContacts.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeNewContacts.Count; ++num1)
              {
                if (partial_allowed)
                    storeNewContacts[num1].write_partial_as_json(handler);
                else
                    storeNewContacts[num1].write_as_json(handler);
              }
            handler.finish_array();
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
        if (!(hasNewContacts()))
          {
            return "When parsing the object for %what%, the \"NewContacts\" field was missing.";
          }
        return null;
      }

    public static new UserContactsAddRequestJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserContactsAddRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserContactsAddRequest", ignore_extras);
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
    public static new UserContactsAddRequestJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UserContactsAddRequestJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserContactsAddRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserContactsAddRequest", ignore_extras);
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
    public static new UserContactsAddRequestJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UserContactsAddRequestJSON from_text(string text, bool ignore_extras)
      {
        UserContactsAddRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserContactsAddRequest", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserContactsAddRequestJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UserContactsAddRequestJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserContactsAddRequestJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserContactsAddRequest", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UserContactsRequestJSON.Generator
      {
        private OneContactJSON.HoldingArrayGenerator fieldGeneratorNewContacts;
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
            if (!(getUserContactsRequestJSONKey().Equals("Add")))
                throw new Exception("The key field has a value other than `Add'.");
            UserContactsAddRequestJSON result = new UserContactsAddRequestJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserContactsAddRequestAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UserContactsRequestJSON new_result)
          {
            handle_result((UserContactsAddRequestJSON )new_result);
          }
        protected void finish(UserContactsAddRequestJSON result)
          {
            if (fieldGeneratorNewContacts.have_value)
              {
                result.initNewContacts();
                int count = fieldGeneratorNewContacts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNewContacts(fieldGeneratorNewContacts.value[num]);
                  }
                fieldGeneratorNewContacts.value.Clear();
                fieldGeneratorNewContacts.have_value = false;
              }
            else if ((!(result.hasNewContacts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewContacts\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(UserContactsAddRequestJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NewContacts", 0, 11, false) == 0) && (field_name.Length == 11))
                return fieldGeneratorNewContacts;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNewContacts = new OneContactJSON.HoldingArrayGenerator("field \"NewContacts\" of the UserContactsAddRequest class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserContactsAddRequest class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNewContacts = new OneContactJSON.HoldingArrayGenerator("field \"NewContacts\" of the UserContactsAddRequest class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserContactsAddRequest class");
          }

        public override void reset()
          {
            fieldGeneratorNewContacts.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UserContactsAddRequestJSON  result)
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
        public UserContactsAddRequestJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserContactsAddRequestJSON  result)
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
    protected virtual void handle_result(List<UserContactsAddRequestJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserContactsAddRequestJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserContactsAddRequestJSON>();
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
    public List<UserContactsAddRequestJSON> value;
  };
  };
