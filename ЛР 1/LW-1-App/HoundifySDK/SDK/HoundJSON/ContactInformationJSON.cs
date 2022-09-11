/* file "ContactInformationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ContactInformationJSON : GeneralizedThingInformationNuggetJSON
  {
    private bool flagHasRequestedProperties;
    private List< PropertyJSON  > storeRequestedProperties;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraRequestedPropertiesToJSON()
      {
        JSONArrayValue generated_array_1_RequestedProperties = new JSONArrayValue();
        for (int num1 = 0; num1 < storeRequestedProperties.Count; ++num1)
          {
            JSONValueHandler handler_RequestedProperties = new JSONValueHandler();
            storeRequestedProperties[num1].write_as_json(handler_RequestedProperties);
            generated_array_1_RequestedProperties.appendComponent(handler_RequestedProperties.result);
          }
        return generated_array_1_RequestedProperties;
      }


    private void  fromJSONRequestedProperties(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequestedProperties of ContactInformationJSON is not an array.");
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


    public ContactInformationJSON()
      {
        flagHasRequestedProperties = false;
        storeRequestedProperties = new List< PropertyJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getGeneralizedThingNuggetKind()
      {
        return "Contact";
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


    public virtual int extraContactInformationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraContactInformationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraContactInformationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraContactInformationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraGeneralizedThingInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasRequestedProperties)
            ++result;
        result += extraContactInformationComponentCount();
        return result;
      }
    public override string extraGeneralizedThingInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasRequestedProperties)
          {
            if (remainder == 0)
                return "RequestedProperties";
            --remainder;
          }
        return extraContactInformationComponentKey(remainder);
      }
    public override JSONValue extraGeneralizedThingInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasRequestedProperties)
          {
            if (remainder == 0)
                return extraRequestedPropertiesToJSON();
            --remainder;
          }
        return extraContactInformationComponentValue(remainder);
      }
    public override JSONValue extraGeneralizedThingInformationNuggetLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "RequestedProperties", 0, 19, false) == 0) && (field_name.Length == 19))
            return (flagHasRequestedProperties ? extraRequestedPropertiesToJSON() : null);
        return extraContactInformationLookup(field_name);
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

    public virtual void extraContactInformationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraContactInformationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraContactInformationLookup(key);
        if (old_field == null)
          {
            extraContactInformationAppendPair(key, new_component);
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
    public override void extraGeneralizedThingInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "RequestedProperties", 0, 19, false) == 0) && (key.Length == 19))
            {
            fromJSONRequestedProperties(new_component, false);
            return;
            }
        extraContactInformationAppendPair(key, new_component);
      }
    public override void extraGeneralizedThingInformationNuggetSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "RequestedProperties", 0, 19, false) == 0) && (key.Length == 19))
            {
            fromJSONRequestedProperties(new_component, false);
            return;
            }
        extraContactInformationSetField(key, new_component);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new ContactInformationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactInformation", ignore_extras);
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
    public static new ContactInformationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ContactInformationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactInformation", ignore_extras);
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
    public static new ContactInformationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ContactInformationJSON from_text(string text, bool ignore_extras)
      {
        ContactInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactInformation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ContactInformationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ContactInformationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ContactInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactInformation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : GeneralizedThingInformationNuggetJSON.Generator
      {
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
            if (!(getGeneralizedThingInformationNuggetJSONKey().Equals("Contact")))
                throw new Exception("The key field has a value other than `Contact'.");
            ContactInformationJSON result = new ContactInformationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraContactInformationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(GeneralizedThingInformationNuggetJSON new_result)
          {
            handle_result((ContactInformationJSON )new_result);
          }
        protected void finish(ContactInformationJSON result)
          {
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
            base.finish(result);
          }
        protected abstract void handle_result(ContactInformationJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "RequestedProperties", 0, 19, false) == 0) && (field_name.Length == 19))
                return fieldGeneratorRequestedProperties;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorRequestedProperties = new PropertyJSON.HoldingArrayGenerator("field \"RequestedProperties\" of the ContactInformation class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ContactInformation class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorRequestedProperties = new PropertyJSON.HoldingArrayGenerator("field \"RequestedProperties\" of the ContactInformation class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ContactInformation class");
          }

        public override void reset()
          {
            fieldGeneratorRequestedProperties.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ContactInformationJSON  result)
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
        public ContactInformationJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ContactInformationJSON  result)
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
    protected virtual void handle_result(List<ContactInformationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ContactInformationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ContactInformationJSON>();
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
    public List<ContactInformationJSON> value;
  };
  };
