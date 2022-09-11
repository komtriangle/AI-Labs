/* file "ContactGeneralizedThingJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ContactGeneralizedThingJSON : ContactGeneralizedThingBaseJSON
  {
    private bool flagHasContacts;
    private List< OneContactJSON  > storeContacts;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraContactsToJSON()
      {
        JSONArrayValue generated_array_1_Contacts = new JSONArrayValue();
        for (int num1 = 0; num1 < storeContacts.Count; ++num1)
          {
            JSONValueHandler handler_Contacts = new JSONValueHandler();
            storeContacts[num1].write_as_json(handler_Contacts);
            generated_array_1_Contacts.appendComponent(handler_Contacts.result);
          }
        return generated_array_1_Contacts;
      }


    private void  fromJSONContacts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Contacts of ContactGeneralizedThingJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Contacts of ContactGeneralizedThingJSON has too few elements.");
        List< OneContactJSON  > vector_Contacts1 = new List< OneContactJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            OneContactJSON convert_classy = OneContactJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Contacts1.Add(convert_classy);
          }
        Debug.Assert(vector_Contacts1.Count >= 1);
        initContacts();
        for (int num1 = 0; num1 < vector_Contacts1.Count; ++num1)
            appendContacts(vector_Contacts1[num1]);
        for (int num1 = 0; num1 < vector_Contacts1.Count; ++num1)
          {
          }
      }


    public ContactGeneralizedThingJSON()
      {
        flagHasContacts = false;
        storeContacts = new List< OneContactJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getContactInformationKind()
      {
        return "ContactAccessContact";
      }

    public bool  hasContacts()
      {
        return flagHasContacts;
      }

    public int  countOfContacts()
      {
        Debug.Assert(flagHasContacts);
        return storeContacts.Count;
      }

    public OneContactJSON   elementOfContacts(int element_num)
      {
        Debug.Assert(flagHasContacts);
        return storeContacts[element_num];
      }

    public List< OneContactJSON  >  getContacts()
      {
        Debug.Assert(flagHasContacts);
        return storeContacts;
      }


    public virtual int extraContactGeneralizedThingComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraContactGeneralizedThingComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraContactGeneralizedThingComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraContactGeneralizedThingLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraContactGeneralizedThingBaseComponentCount()
      {
        int result = 0;
        if (flagHasContacts)
            ++result;
        result += extraContactGeneralizedThingComponentCount();
        return result;
      }
    public override string extraContactGeneralizedThingBaseComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasContacts)
          {
            if (remainder == 0)
                return "Contacts";
            --remainder;
          }
        return extraContactGeneralizedThingComponentKey(remainder);
      }
    public override JSONValue extraContactGeneralizedThingBaseComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasContacts)
          {
            if (remainder == 0)
                return extraContactsToJSON();
            --remainder;
          }
        return extraContactGeneralizedThingComponentValue(remainder);
      }
    public override JSONValue extraContactGeneralizedThingBaseLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Contacts", 0, 8, false) == 0) && (field_name.Length == 8))
            return (flagHasContacts ? extraContactsToJSON() : null);
        return extraContactGeneralizedThingLookup(field_name);
      }

    public void initContacts()
      {
        if (flagHasContacts)
          {
            for (int num1 = 0; num1 < storeContacts.Count; ++num1)
              {
              }
          }
        flagHasContacts = true;
        storeContacts.Clear();
      }
    public void appendContacts(OneContactJSON  to_append)
      {
        if (!flagHasContacts)
          {
            flagHasContacts = true;
            storeContacts.Clear();
          }
        Debug.Assert(flagHasContacts);
        storeContacts.Add(to_append);
      }
    public void unsetContacts()
      {
        if (flagHasContacts)
          {
            for (int num2 = 0; num2 < storeContacts.Count; ++num2)
              {
              }
          }
        flagHasContacts = false;
        storeContacts.Clear();
      }

    public virtual void extraContactGeneralizedThingAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraContactGeneralizedThingSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraContactGeneralizedThingLookup(key);
        if (old_field == null)
          {
            extraContactGeneralizedThingAppendPair(key, new_component);
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
    public override void extraContactGeneralizedThingBaseAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Contacts", 0, 8, false) == 0) && (key.Length == 8))
            {
            fromJSONContacts(new_component, false);
            return;
            }
        extraContactGeneralizedThingAppendPair(key, new_component);
      }
    public override void extraContactGeneralizedThingBaseSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Contacts", 0, 8, false) == 0) && (key.Length == 8))
            {
            fromJSONContacts(new_component, false);
            return;
            }
        extraContactGeneralizedThingSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasContacts);
        if (flagHasContacts)
          {
            handler.start_pair("Contacts");
            Debug.Assert(storeContacts.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeContacts.Count; ++num1)
              {
                if (partial_allowed)
                    storeContacts[num1].write_partial_as_json(handler);
                else
                    storeContacts[num1].write_as_json(handler);
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
        if (!(hasContacts()))
          {
            return "When parsing the object for %what%, the \"Contacts\" field was missing.";
          }
        return null;
      }

    public static new ContactGeneralizedThingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactGeneralizedThingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactGeneralizedThing", ignore_extras);
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
    public static new ContactGeneralizedThingJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ContactGeneralizedThingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactGeneralizedThingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactGeneralizedThing", ignore_extras);
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
    public static new ContactGeneralizedThingJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ContactGeneralizedThingJSON from_text(string text, bool ignore_extras)
      {
        ContactGeneralizedThingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactGeneralizedThing", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ContactGeneralizedThingJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ContactGeneralizedThingJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ContactGeneralizedThingJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactGeneralizedThing", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ContactGeneralizedThingBaseJSON.Generator
      {
        private OneContactJSON.HoldingArrayGenerator fieldGeneratorContacts;
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
            if (!(getContactGeneralizedThingBaseJSONKey().Equals("ContactAccessContact")))
                throw new Exception("The key field has a value other than `ContactAccessContact'.");
            ContactGeneralizedThingJSON result = new ContactGeneralizedThingJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraContactGeneralizedThingAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ContactGeneralizedThingBaseJSON new_result)
          {
            handle_result((ContactGeneralizedThingJSON )new_result);
          }
        protected void finish(ContactGeneralizedThingJSON result)
          {
            if (fieldGeneratorContacts.have_value)
              {
                result.initContacts();
                int count = fieldGeneratorContacts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendContacts(fieldGeneratorContacts.value[num]);
                  }
                fieldGeneratorContacts.value.Clear();
                fieldGeneratorContacts.have_value = false;
              }
            else if ((!(result.hasContacts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Contacts\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ContactGeneralizedThingJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Contacts", 0, 8, false) == 0) && (field_name.Length == 8))
                return fieldGeneratorContacts;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the ContactGeneralizedThing class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ContactGeneralizedThing class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the ContactGeneralizedThing class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ContactGeneralizedThing class");
          }

        public override void reset()
          {
            fieldGeneratorContacts.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ContactGeneralizedThingJSON  result)
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
        public ContactGeneralizedThingJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ContactGeneralizedThingJSON  result)
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
    protected virtual void handle_result(List<ContactGeneralizedThingJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ContactGeneralizedThingJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ContactGeneralizedThingJSON>();
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
    public List<ContactGeneralizedThingJSON> value;
  };
  };
