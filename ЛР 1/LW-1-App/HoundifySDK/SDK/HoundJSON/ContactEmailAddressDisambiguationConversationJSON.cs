/* file "ContactEmailAddressDisambiguationConversationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ContactEmailAddressDisambiguationConversationJSON : JSONBase
  {
    private bool flagHasContacts;
    private List< OneContactJSON  > storeContacts;
    private bool flagHasChoices;
    private List< ContactEmailAddressChoiceJSON  > storeChoices;
    private bool flagHasUserSpecifiedName;
    private string storeUserSpecifiedName;
    private bool flagHasRequestedProperties;
    private List< PropertyJSON  > storeRequestedProperties;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONContacts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Contacts of ContactEmailAddressDisambiguationConversationJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Contacts of ContactEmailAddressDisambiguationConversationJSON has too few elements.");
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
            throw new Exception("The value for field Choices of ContactEmailAddressDisambiguationConversationJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field Choices of ContactEmailAddressDisambiguationConversationJSON has too few elements.");
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


    private void  fromJSONUserSpecifiedName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserSpecifiedName of ContactEmailAddressDisambiguationConversationJSON is not a string.");
        setUserSpecifiedName(json_string.getData());
      }


    private void  fromJSONRequestedProperties(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequestedProperties of ContactEmailAddressDisambiguationConversationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< PropertyJSON  > vector_RequestedProperties1 = new List< PropertyJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            PropertyJSON convert_classy = PropertyJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RequestedProperties1.Add(convert_classy);
          }
        initRequestedProperties();
        for (int num3 = 0; num3 < vector_RequestedProperties1.Count; ++num3)
            appendRequestedProperties(vector_RequestedProperties1[num3]);
        for (int num1 = 0; num1 < vector_RequestedProperties1.Count; ++num1)
          {
          }
      }


    public ContactEmailAddressDisambiguationConversationJSON()
      {
        flagHasContacts = false;
        flagHasChoices = false;
        flagHasUserSpecifiedName = false;
        flagHasRequestedProperties = false;
        storeContacts = new List< OneContactJSON  >();
        storeChoices = new List< ContactEmailAddressChoiceJSON  >();
        storeRequestedProperties = new List< PropertyJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasUserSpecifiedName()
      {
        return flagHasUserSpecifiedName;
      }

    public string  getUserSpecifiedName()
      {
        Debug.Assert(flagHasUserSpecifiedName);
        return storeUserSpecifiedName;
      }

    public bool  hasRequestedProperties()
      {
        return flagHasRequestedProperties;
      }

    public int  countOfRequestedProperties()
      {
        Debug.Assert(flagHasRequestedProperties);
        return storeRequestedProperties.Count;
      }

    public PropertyJSON   elementOfRequestedProperties(int element_num)
      {
        Debug.Assert(flagHasRequestedProperties);
        return storeRequestedProperties[element_num];
      }

    public List< PropertyJSON  >  getRequestedProperties()
      {
        Debug.Assert(flagHasRequestedProperties);
        return storeRequestedProperties;
      }


    public virtual int extraContactEmailAddressDisambiguationConversationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraContactEmailAddressDisambiguationConversationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraContactEmailAddressDisambiguationConversationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraContactEmailAddressDisambiguationConversationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setUserSpecifiedName(string new_value)
      {
        flagHasUserSpecifiedName = true;
        storeUserSpecifiedName = new_value;
      }
    public void unsetUserSpecifiedName()
      {
        flagHasUserSpecifiedName = false;
      }
    public void initRequestedProperties()
      {
        if (flagHasRequestedProperties)
          {
            for (int num5 = 0; num5 < storeRequestedProperties.Count; ++num5)
              {
              }
          }
        flagHasRequestedProperties = true;
        storeRequestedProperties.Clear();
      }
    public void appendRequestedProperties(PropertyJSON  to_append)
      {
        if (!flagHasRequestedProperties)
          {
            flagHasRequestedProperties = true;
            storeRequestedProperties.Clear();
          }
        Debug.Assert(flagHasRequestedProperties);
        storeRequestedProperties.Add(to_append);
      }
    public void unsetRequestedProperties()
      {
        if (flagHasRequestedProperties)
          {
            for (int num6 = 0; num6 < storeRequestedProperties.Count; ++num6)
              {
              }
          }
        flagHasRequestedProperties = false;
        storeRequestedProperties.Clear();
      }

    public virtual void extraContactEmailAddressDisambiguationConversationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraContactEmailAddressDisambiguationConversationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraContactEmailAddressDisambiguationConversationLookup(key);
        if (old_field == null)
          {
            extraContactEmailAddressDisambiguationConversationAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasUserSpecifiedName);
        if (flagHasUserSpecifiedName)
          {
            handler.start_pair("UserSpecifiedName");
            handler.string_value(storeUserSpecifiedName);
          }
        if (flagHasRequestedProperties)
          {
            handler.start_pair("RequestedProperties");
            handler.start_array();
            for (int num3 = 0; num3 < storeRequestedProperties.Count; ++num3)
              {
                if (partial_allowed)
                    storeRequestedProperties[num3].write_partial_as_json(handler);
                else
                    storeRequestedProperties[num3].write_as_json(handler);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasContacts()))
          {
            return "When parsing the object for %what%, the \"Contacts\" field was missing.";
          }
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

    public static ContactEmailAddressDisambiguationConversationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactEmailAddressDisambiguationConversationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactEmailAddressDisambiguationConversation", ignore_extras);
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
    public static ContactEmailAddressDisambiguationConversationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ContactEmailAddressDisambiguationConversationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactEmailAddressDisambiguationConversationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactEmailAddressDisambiguationConversation", ignore_extras);
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
    public static ContactEmailAddressDisambiguationConversationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ContactEmailAddressDisambiguationConversationJSON from_text(string text, bool ignore_extras)
      {
        ContactEmailAddressDisambiguationConversationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactEmailAddressDisambiguationConversation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ContactEmailAddressDisambiguationConversationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ContactEmailAddressDisambiguationConversationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ContactEmailAddressDisambiguationConversationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactEmailAddressDisambiguationConversation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private OneContactJSON.HoldingArrayGenerator fieldGeneratorContacts;
        private ContactEmailAddressChoiceJSON.HoldingArrayGenerator fieldGeneratorChoices;
        private JSONHoldingStringGenerator fieldGeneratorUserSpecifiedName;
        private PropertyJSON.HoldingArrayGenerator fieldGeneratorRequestedProperties;
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
            ContactEmailAddressDisambiguationConversationJSON result = new ContactEmailAddressDisambiguationConversationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraContactEmailAddressDisambiguationConversationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ContactEmailAddressDisambiguationConversationJSON result)
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
            if (fieldGeneratorUserSpecifiedName.have_value)
              {
                result.setUserSpecifiedName(fieldGeneratorUserSpecifiedName.value);
                fieldGeneratorUserSpecifiedName.have_value = false;
              }
            else if ((!(result.hasUserSpecifiedName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"UserSpecifiedName\" field was missing.");
              }
            if (fieldGeneratorRequestedProperties.have_value)
              {
                result.initRequestedProperties();
                int count = fieldGeneratorRequestedProperties.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequestedProperties(fieldGeneratorRequestedProperties.value[num]);
                  }
                fieldGeneratorRequestedProperties.value.Clear();
                fieldGeneratorRequestedProperties.have_value = false;
              }
          }
        protected abstract void handle_result(ContactEmailAddressDisambiguationConversationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
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
                            if ((String.Compare(field_name, 2, "ntacts", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorContacts;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedProperties", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorRequestedProperties;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "serSpecifiedName", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorUserSpecifiedName;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the ContactEmailAddressDisambiguationConversation class", ignore_extras);
            fieldGeneratorChoices = new ContactEmailAddressChoiceJSON.HoldingArrayGenerator("field \"Choices\" of the ContactEmailAddressDisambiguationConversation class", ignore_extras);
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the ContactEmailAddressDisambiguationConversation class");
            fieldGeneratorRequestedProperties = new PropertyJSON.HoldingArrayGenerator("field \"RequestedProperties\" of the ContactEmailAddressDisambiguationConversation class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ContactEmailAddressDisambiguationConversation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the ContactEmailAddressDisambiguationConversation class", false);
            fieldGeneratorChoices = new ContactEmailAddressChoiceJSON.HoldingArrayGenerator("field \"Choices\" of the ContactEmailAddressDisambiguationConversation class", false);
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the ContactEmailAddressDisambiguationConversation class");
            fieldGeneratorRequestedProperties = new PropertyJSON.HoldingArrayGenerator("field \"RequestedProperties\" of the ContactEmailAddressDisambiguationConversation class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ContactEmailAddressDisambiguationConversation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorContacts.reset();
            fieldGeneratorChoices.reset();
            fieldGeneratorUserSpecifiedName.reset();
            fieldGeneratorRequestedProperties.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorContacts.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorChoices.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedProperties.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorContacts.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorChoices.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedProperties.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ContactEmailAddressDisambiguationConversationJSON  result)
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
        public ContactEmailAddressDisambiguationConversationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ContactEmailAddressDisambiguationConversationJSON  result)
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
    protected virtual void handle_result(List<ContactEmailAddressDisambiguationConversationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ContactEmailAddressDisambiguationConversationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ContactEmailAddressDisambiguationConversationJSON>();
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
    public List<ContactEmailAddressDisambiguationConversationJSON> value;
  };
  };
