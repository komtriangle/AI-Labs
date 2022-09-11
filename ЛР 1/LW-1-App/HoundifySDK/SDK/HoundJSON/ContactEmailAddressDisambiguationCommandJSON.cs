/* file "ContactEmailAddressDisambiguationCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public abstract class ContactEmailAddressDisambiguationCommandJSON : DisambiguateCommandJSON
  {
    private bool flagHasContacts;
    private List< OneContactJSON  > storeContacts;
    private bool flagHasChoices;
    private List< ContactEmailAddressChoiceJSON  > storeChoices;


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

    private JSONValue  extraChoicesToJSON()
      {
        JSONArrayValue generated_array_2_Choices = new JSONArrayValue();
        for (int num2 = 0; num2 < storeChoices.Count; ++num2)
          {
            JSONValueHandler handler_Choices = new JSONValueHandler();
            storeChoices[num2].write_as_json(handler_Choices);
            generated_array_2_Choices.appendComponent(handler_Choices.result);
          }
        return generated_array_2_Choices;
      }


    private void  fromJSONContacts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Contacts of ContactEmailAddressDisambiguationCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Contacts of ContactEmailAddressDisambiguationCommandJSON has too few elements.");
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


    private void  fromJSONChoices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Choices of ContactEmailAddressDisambiguationCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field Choices of ContactEmailAddressDisambiguationCommandJSON has too few elements.");
        List< ContactEmailAddressChoiceJSON  > vector_Choices1 = new List< ContactEmailAddressChoiceJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            ContactEmailAddressChoiceJSON convert_classy = ContactEmailAddressChoiceJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Choices1.Add(convert_classy);
          }
        Debug.Assert(vector_Choices1.Count >= 2);
        initChoices();
        for (int num2 = 0; num2 < vector_Choices1.Count; ++num2)
            appendChoices(vector_Choices1[num2]);
        for (int num1 = 0; num1 < vector_Choices1.Count; ++num1)
          {
          }
      }


    public ContactEmailAddressDisambiguationCommandJSON()
      {
        flagHasContacts = false;
        flagHasChoices = false;
        storeContacts = new List< OneContactJSON  >();
        storeChoices = new List< ContactEmailAddressChoiceJSON  >();
      }

    public override string  getDisambiguateCommandKind()
      {
        return "ContactEmailAddressDisambiguation";
      }

    public abstract string getContactEmailAddressDisambiguationKind();
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

    public bool  hasChoices()
      {
        return flagHasChoices;
      }

    public int  countOfChoices()
      {
        Debug.Assert(flagHasChoices);
        return storeChoices.Count;
      }

    public ContactEmailAddressChoiceJSON   elementOfChoices(int element_num)
      {
        Debug.Assert(flagHasChoices);
        return storeChoices[element_num];
      }

    public List< ContactEmailAddressChoiceJSON  >  getChoices()
      {
        Debug.Assert(flagHasChoices);
        return storeChoices;
      }


    public abstract int extraContactEmailAddressDisambiguationCommandComponentCount();
    public abstract string extraContactEmailAddressDisambiguationCommandComponentKey(int component_num);
    public abstract JSONValue extraContactEmailAddressDisambiguationCommandComponentValue(int component_num);
    public abstract JSONValue extraContactEmailAddressDisambiguationCommandLookup(string field_name);
    public override int extraDisambiguateCommandComponentCount()
      {
        int result = 1;
        if (flagHasContacts)
            ++result;
        if (flagHasChoices)
            ++result;
        result += extraContactEmailAddressDisambiguationCommandComponentCount();
        return result;
      }
    public override string extraDisambiguateCommandComponentKey(int component_num)
      {
        if (component_num == 0)
            return "ContactEmailAddressDisambiguationKind";
        int remainder = (component_num - 1);
        if (flagHasContacts)
          {
            if (remainder == 0)
                return "Contacts";
            --remainder;
          }
        if (flagHasChoices)
          {
            if (remainder == 0)
                return "Choices";
            --remainder;
          }
        return extraContactEmailAddressDisambiguationCommandComponentKey(remainder);
      }
    public override JSONValue extraDisambiguateCommandComponentValue(int component_num)
      {
        if (component_num == 0)
            return new JSONStringValue(getContactEmailAddressDisambiguationKind());
        int remainder = (component_num - 1);
        if (flagHasContacts)
          {
            if (remainder == 0)
                return extraContactsToJSON();
            --remainder;
          }
        if (flagHasChoices)
          {
            if (remainder == 0)
                return extraChoicesToJSON();
            --remainder;
          }
        return extraContactEmailAddressDisambiguationCommandComponentValue(remainder);
      }
    public override JSONValue extraDisambiguateCommandLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "C", 0, 1, false) == 0)
          {
            switch (field_name[1])
              {
                case 'h':
                    if ((String.Compare(field_name, 2, "oices", 0, 5, false) == 0) && (field_name.Length == 7))
                        return (flagHasChoices ? extraChoicesToJSON() : null);
                    break;
                case 'o':
                    if (String.Compare(field_name, 2, "ntact", 0, 5, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 8, "mailAddressDisambiguationKind", 0, 29, false) == 0) && (field_name.Length == 37))
                                    return new JSONStringValue(getContactEmailAddressDisambiguationKind());
                                break;
                            case 's':
                                if (field_name.Length == 8)
                                    return (flagHasContacts ? extraContactsToJSON() : null);
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
          }
        return extraContactEmailAddressDisambiguationCommandLookup(field_name);
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
    public void initChoices()
      {
        if (flagHasChoices)
          {
            for (int num3 = 0; num3 < storeChoices.Count; ++num3)
              {
              }
          }
        flagHasChoices = true;
        storeChoices.Clear();
      }
    public void appendChoices(ContactEmailAddressChoiceJSON  to_append)
      {
        if (!flagHasChoices)
          {
            flagHasChoices = true;
            storeChoices.Clear();
          }
        Debug.Assert(flagHasChoices);
        storeChoices.Add(to_append);
      }
    public void unsetChoices()
      {
        if (flagHasChoices)
          {
            for (int num4 = 0; num4 < storeChoices.Count; ++num4)
              {
              }
          }
        flagHasChoices = false;
        storeChoices.Clear();
      }

    public abstract void extraContactEmailAddressDisambiguationCommandAppendPair(string key, JSONValue new_component);
    public abstract void extraContactEmailAddressDisambiguationCommandSetField(string key, JSONValue new_component);
    public override void extraDisambiguateCommandAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "C", 0, 1, false) == 0)
          {
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
                    if (String.Compare(key, 2, "ntact", 0, 5, false) == 0)
                      {
                        switch (key[7])
                          {
                            case 'E':
                                if ((String.Compare(key, 8, "mailAddressDisambiguationKind", 0, 29, false) == 0) && (key.Length == 37))
                                    return;
                                break;
                            case 's':
                                if (key.Length == 8)
                                    {
                                    fromJSONContacts(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
          }
        extraContactEmailAddressDisambiguationCommandAppendPair(key, new_component);
      }
    public override void extraDisambiguateCommandSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "C", 0, 1, false) == 0)
          {
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
                    if (String.Compare(key, 2, "ntact", 0, 5, false) == 0)
                      {
                        switch (key[7])
                          {
                            case 'E':
                                if ((String.Compare(key, 8, "mailAddressDisambiguationKind", 0, 29, false) == 0) && (key.Length == 37))
                                    return;
                                break;
                            case 's':
                                if (key.Length == 8)
                                    {
                                    fromJSONContacts(new_component, false);
                                    return;
                                    }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
          }
        extraContactEmailAddressDisambiguationCommandSetField(key, new_component);
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
        handler.pair("ContactEmailAddressDisambiguationKind", getContactEmailAddressDisambiguationKind());
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
        Debug.Assert(partial_allowed || flagHasChoices);
        if (flagHasChoices)
          {
            handler.start_pair("Choices");
            Debug.Assert(storeChoices.Count >= 2);
            handler.start_array();
            for (int num2 = 0; num2 < storeChoices.Count; ++num2)
              {
                if (partial_allowed)
                    storeChoices[num2].write_partial_as_json(handler);
                else
                    storeChoices[num2].write_as_json(handler);
              }
            handler.finish_array();
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
        if (!(hasContacts()))
          {
            return "When parsing the object for %what%, the \"Contacts\" field was missing.";
          }
        if (!(hasChoices()))
          {
            return "When parsing the object for %what%, the \"Choices\" field was missing.";
          }
        return null;
      }

    public static new ContactEmailAddressDisambiguationCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactEmailAddressDisambiguationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactEmailAddressDisambiguationCommand", ignore_extras);
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
    public static new ContactEmailAddressDisambiguationCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ContactEmailAddressDisambiguationCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactEmailAddressDisambiguationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactEmailAddressDisambiguationCommand", ignore_extras);
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
    public static new ContactEmailAddressDisambiguationCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ContactEmailAddressDisambiguationCommandJSON from_text(string text, bool ignore_extras)
      {
        ContactEmailAddressDisambiguationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactEmailAddressDisambiguationCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ContactEmailAddressDisambiguationCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ContactEmailAddressDisambiguationCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ContactEmailAddressDisambiguationCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactEmailAddressDisambiguationCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DisambiguateCommandJSON.Generator
      {
        private OneContactJSON.HoldingArrayGenerator fieldGeneratorContacts;
        private ContactEmailAddressChoiceJSON.HoldingArrayGenerator fieldGeneratorChoices;
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
                throw new Exception("The `ContactEmailAddressDisambiguationKind' field is missing.");
            if (!(getDisambiguateCommandJSONKey().Equals("ContactEmailAddressDisambiguation")))
                throw new Exception("The key field has a value other than `ContactEmailAddressDisambiguation'.");
            ContactEmailAddressDisambiguationCommandJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraContactEmailAddressDisambiguationCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
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
        protected string getContactEmailAddressDisambiguationCommandJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `ContactEmailAddressDisambiguationKind' field is missing.");
            return keyGenerator.value;
          }
        protected override void handle_result(DisambiguateCommandJSON new_result)
          {
            handle_result((ContactEmailAddressDisambiguationCommandJSON )new_result);
          }
        protected void finish(ContactEmailAddressDisambiguationCommandJSON result)
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
            if (fieldGeneratorChoices.have_value)
              {
                result.initChoices();
                int count = fieldGeneratorChoices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendChoices(fieldGeneratorChoices.value[num]);
                  }
                fieldGeneratorChoices.value.Clear();
                fieldGeneratorChoices.have_value = false;
              }
            else if ((!(result.hasChoices())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Choices\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(ContactEmailAddressDisambiguationCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "C", 0, 1, false) == 0)
              {
                switch (field_name[1])
                  {
                    case 'h':
                        if ((String.Compare(field_name, 2, "oices", 0, 5, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorChoices;
                        break;
                    case 'o':
                        if (String.Compare(field_name, 2, "ntact", 0, 5, false) == 0)
                          {
                            switch (field_name[7])
                              {
                                case 'E':
                                    if ((String.Compare(field_name, 8, "mailAddressDisambiguationKind", 0, 29, false) == 0) && (field_name.Length == 37))
                                        {
                                        keyGenerator.reset();
                                        return keyGenerator;
                                        }
                                    break;
                                case 's':
                                    if (field_name.Length == 8)
                                        return fieldGeneratorContacts;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the ContactEmailAddressDisambiguationCommand class", ignore_extras);
            fieldGeneratorChoices = new ContactEmailAddressChoiceJSON.HoldingArrayGenerator("field \"Choices\" of the ContactEmailAddressDisambiguationCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ContactEmailAddressDisambiguationKind\" of the ContactEmailAddressDisambiguationCommand class");
            set_what("the ContactEmailAddressDisambiguationCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the ContactEmailAddressDisambiguationCommand class", false);
            fieldGeneratorChoices = new ContactEmailAddressChoiceJSON.HoldingArrayGenerator("field \"Choices\" of the ContactEmailAddressDisambiguationCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"ContactEmailAddressDisambiguationKind\" of the ContactEmailAddressDisambiguationCommand class");
            set_what("the ContactEmailAddressDisambiguationCommand class");
          }

        public override void reset()
          {
            fieldGeneratorContacts.reset();
            fieldGeneratorChoices.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ContactEmailAddressDisambiguationCommandJSON  result)
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
        public ContactEmailAddressDisambiguationCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ContactEmailAddressDisambiguationCommandJSON  result)
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
    protected virtual void handle_result(List<ContactEmailAddressDisambiguationCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ContactEmailAddressDisambiguationCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ContactEmailAddressDisambiguationCommandJSON>();
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
    public List<ContactEmailAddressDisambiguationCommandJSON> value;
  };
    class GenericContactEmailAddressDisambiguationCommandJSON : ContactEmailAddressDisambiguationCommandJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericContactEmailAddressDisambiguationCommandJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getContactEmailAddressDisambiguationKind()  { return key; }
        public override int extraContactEmailAddressDisambiguationCommandComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraContactEmailAddressDisambiguationCommandComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraContactEmailAddressDisambiguationCommandComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraContactEmailAddressDisambiguationCommandLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraContactEmailAddressDisambiguationCommandAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraContactEmailAddressDisambiguationCommandSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraContactEmailAddressDisambiguationCommandLookup(key);
            if (old_field == null)
              {
                extraContactEmailAddressDisambiguationCommandAppendPair(key, new_component);
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
    public static new ContactEmailAddressDisambiguationCommandJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'C':
            if ((String.Compare(key, 1, "alendarContactEmailAddressDisambiguation", 0, 40, false) == 0) && (key.Length == 41))
                return new CalendarContactEmailAddressDisambiguationCommandJSON();
            break;
        case 'S':
            if ((String.Compare(key, 1, "impleContactEmailAddressDisambiguation", 0, 38, false) == 0) && (key.Length == 39))
                return new SimpleContactEmailAddressDisambiguationCommandJSON();
            break;
        default:
            break;
      }

        return new GenericContactEmailAddressDisambiguationCommandJSON(key);
      }
  };
