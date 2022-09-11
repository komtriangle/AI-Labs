/* file "ContactDisambiguationConversationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ContactDisambiguationConversationJSON : JSONBase
  {
    private bool flagHasChoices;
    private WhichContactChoicesJSON  storeChoices;
    private bool flagHasUserSpecifiedName;
    private string storeUserSpecifiedName;
    private bool flagHasRequestedProperties;
    private List< PropertyJSON  > storeRequestedProperties;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


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
            throw new Exception("The value for field UserSpecifiedName of ContactDisambiguationConversationJSON is not a string.");
        setUserSpecifiedName(json_string.getData());
      }


    private void  fromJSONRequestedProperties(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequestedProperties of ContactDisambiguationConversationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< PropertyJSON  > vector_RequestedProperties1 = new List< PropertyJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            PropertyJSON convert_classy = PropertyJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RequestedProperties1.Add(convert_classy);
          }
        initRequestedProperties();
        for (int num1 = 0; num1 < vector_RequestedProperties1.Count; ++num1)
            appendRequestedProperties(vector_RequestedProperties1[num1]);
        for (int num1 = 0; num1 < vector_RequestedProperties1.Count; ++num1)
          {
          }
      }


    public ContactDisambiguationConversationJSON()
      {
        flagHasChoices = false;
        flagHasUserSpecifiedName = false;
        flagHasRequestedProperties = false;
        storeRequestedProperties = new List< PropertyJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

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


    public virtual int extraContactDisambiguationConversationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraContactDisambiguationConversationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraContactDisambiguationConversationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraContactDisambiguationConversationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void initRequestedProperties()
      {
        if (flagHasRequestedProperties)
          {
            for (int num1 = 0; num1 < storeRequestedProperties.Count; ++num1)
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
            for (int num2 = 0; num2 < storeRequestedProperties.Count; ++num2)
              {
              }
          }
        flagHasRequestedProperties = false;
        storeRequestedProperties.Clear();
      }

    public virtual void extraContactDisambiguationConversationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraContactDisambiguationConversationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraContactDisambiguationConversationLookup(key);
        if (old_field == null)
          {
            extraContactDisambiguationConversationAppendPair(key, new_component);
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
        if (flagHasRequestedProperties)
          {
            handler.start_pair("RequestedProperties");
            handler.start_array();
            for (int num1 = 0; num1 < storeRequestedProperties.Count; ++num1)
              {
                if (partial_allowed)
                    storeRequestedProperties[num1].write_partial_as_json(handler);
                else
                    storeRequestedProperties[num1].write_as_json(handler);
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

    public static ContactDisambiguationConversationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactDisambiguationConversationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactDisambiguationConversation", ignore_extras);
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
    public static ContactDisambiguationConversationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ContactDisambiguationConversationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactDisambiguationConversationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactDisambiguationConversation", ignore_extras);
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
    public static ContactDisambiguationConversationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ContactDisambiguationConversationJSON from_text(string text, bool ignore_extras)
      {
        ContactDisambiguationConversationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactDisambiguationConversation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ContactDisambiguationConversationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ContactDisambiguationConversationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ContactDisambiguationConversationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactDisambiguationConversation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private WhichContactChoicesJSON.HoldingGenerator fieldGeneratorChoices;
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
            ContactDisambiguationConversationJSON result = new ContactDisambiguationConversationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraContactDisambiguationConversationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ContactDisambiguationConversationJSON result)
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
        protected abstract void handle_result(ContactDisambiguationConversationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "hoices", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorChoices;
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
            fieldGeneratorChoices = new WhichContactChoicesJSON.HoldingGenerator("field \"Choices\" of the ContactDisambiguationConversation class", ignore_extras);
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the ContactDisambiguationConversation class");
            fieldGeneratorRequestedProperties = new PropertyJSON.HoldingArrayGenerator("field \"RequestedProperties\" of the ContactDisambiguationConversation class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ContactDisambiguationConversation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorChoices = new WhichContactChoicesJSON.HoldingGenerator("field \"Choices\" of the ContactDisambiguationConversation class", false);
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the ContactDisambiguationConversation class");
            fieldGeneratorRequestedProperties = new PropertyJSON.HoldingArrayGenerator("field \"RequestedProperties\" of the ContactDisambiguationConversation class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ContactDisambiguationConversation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorChoices.reset();
            fieldGeneratorUserSpecifiedName.reset();
            fieldGeneratorRequestedProperties.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorChoices.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedProperties.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorChoices.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedProperties.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ContactDisambiguationConversationJSON  result)
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
        public ContactDisambiguationConversationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ContactDisambiguationConversationJSON  result)
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
    protected virtual void handle_result(List<ContactDisambiguationConversationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ContactDisambiguationConversationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ContactDisambiguationConversationJSON>();
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
    public List<ContactDisambiguationConversationJSON> value;
  };
  };
