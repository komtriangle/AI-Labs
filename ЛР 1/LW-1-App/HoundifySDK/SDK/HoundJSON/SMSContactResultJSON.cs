/* file "SMSContactResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SMSContactResultJSON : ContactResultJSON
  {
    public enum TypeFieldType
      {
        FieldType_To,
        FieldType_Unknown
      };

    public static TypeFieldType  stringToFieldType(string chars)
      {
        switch (chars[0])
          {
            case 'T':
                if ((String.Compare(chars, 1, "o", 0, 1, false) == 0) && (chars.Length == 2))
                    return TypeFieldType.FieldType_To;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeFieldType.FieldType_Unknown;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `FieldType' is not one of the legal values.");
      }

    public static string  stringFromFieldType(TypeFieldType the_enum)
      {
        switch (the_enum)
          {
            case TypeFieldType.FieldType_To:
                return "To";
            case TypeFieldType.FieldType_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFieldType;
    private TypeFieldType storeFieldType;
    private bool flagHasContacts;
    private List< SMSContactJSON  > storeContacts;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraFieldTypeToJSON()
      {
        JSONStringValue generated_string_FieldType;
        switch (storeFieldType)
          {
            case TypeFieldType.FieldType_To:
                generated_string_FieldType = new JSONStringValue("To");
                break;
            case TypeFieldType.FieldType_Unknown:
                generated_string_FieldType = new JSONStringValue("Unknown");
                break;
            default:
                Debug.Assert(false);
                generated_string_FieldType = null;
                break;
          }
        return generated_string_FieldType;
      }

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


    private void  fromJSONFieldType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FieldType of SMSContactResultJSON is not a string.");
        TypeFieldType the_enum;
        switch (json_string.getData()[0])
          {
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0) && (json_string.getData().Length == 2))
                      {
                        the_enum = TypeFieldType.FieldType_To;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeFieldType.FieldType_Unknown;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field FieldType of SMSContactResultJSON is not one of the legal strings.");
      enum_is_done:;
        setFieldType(the_enum);
      }


    private void  fromJSONContacts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Contacts of SMSContactResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SMSContactJSON  > vector_Contacts1 = new List< SMSContactJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SMSContactJSON convert_classy = SMSContactJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Contacts1.Add(convert_classy);
          }
        initContacts();
        for (int num1 = 0; num1 < vector_Contacts1.Count; ++num1)
            appendContacts(vector_Contacts1[num1]);
        for (int num1 = 0; num1 < vector_Contacts1.Count; ++num1)
          {
          }
      }


    public SMSContactResultJSON()
      {
        flagHasFieldType = false;
        flagHasContacts = false;
        storeContacts = new List< SMSContactJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFieldType()
      {
        return flagHasFieldType;
      }

    public TypeFieldType  getFieldType()
      {
        Debug.Assert(flagHasFieldType);
        return storeFieldType;
      }

    public string  getFieldTypeAsString()
      {
        return stringFromFieldType(getFieldType());
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

    public SMSContactJSON   elementOfContacts(int element_num)
      {
        Debug.Assert(flagHasContacts);
        return storeContacts[element_num];
      }

    public List< SMSContactJSON  >  getContacts()
      {
        Debug.Assert(flagHasContacts);
        return storeContacts;
      }


    public virtual int extraSMSContactResultComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSMSContactResultComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSMSContactResultComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSMSContactResultLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraContactResultComponentCount()
      {
        int result = 0;
        if (flagHasFieldType)
            ++result;
        if (flagHasContacts)
            ++result;
        result += extraSMSContactResultComponentCount();
        return result;
      }
    public override string extraContactResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasFieldType)
          {
            if (remainder == 0)
                return "FieldType";
            --remainder;
          }
        if (flagHasContacts)
          {
            if (remainder == 0)
                return "Contacts";
            --remainder;
          }
        return extraSMSContactResultComponentKey(remainder);
      }
    public override JSONValue extraContactResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasFieldType)
          {
            if (remainder == 0)
                return extraFieldTypeToJSON();
            --remainder;
          }
        if (flagHasContacts)
          {
            if (remainder == 0)
                return extraContactsToJSON();
            --remainder;
          }
        return extraSMSContactResultComponentValue(remainder);
      }
    public override JSONValue extraContactResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ontacts", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasContacts ? extraContactsToJSON() : null);
                break;
            case 'F':
                if ((String.Compare(field_name, 1, "ieldType", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasFieldType ? extraFieldTypeToJSON() : null);
                break;
            default:
                break;
          }
        return extraSMSContactResultLookup(field_name);
      }

    public void setFieldType(TypeFieldType new_value)
      {
        flagHasFieldType = true;
        storeFieldType = new_value;
      }
    public void setFieldType(string chars)
      {
        setFieldType(stringToFieldType(chars));
      }
    public void unsetFieldType()
      {
        flagHasFieldType = false;
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
    public void appendContacts(SMSContactJSON  to_append)
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

    public virtual void extraSMSContactResultAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSMSContactResultSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSMSContactResultLookup(key);
        if (old_field == null)
          {
            extraSMSContactResultAppendPair(key, new_component);
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
    public override void extraContactResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ontacts", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONContacts(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ieldType", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONFieldType(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSMSContactResultAppendPair(key, new_component);
      }
    public override void extraContactResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "ontacts", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONContacts(new_component, false);
                    return;
                    }
                break;
            case 'F':
                if ((String.Compare(key, 1, "ieldType", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONFieldType(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSMSContactResultSetField(key, new_component);
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
        if (flagHasFieldType)
          {
            handler.start_pair("FieldType");
            switch (storeFieldType)
              {
                case TypeFieldType.FieldType_To:
                    handler.string_value("To");
                    break;
                case TypeFieldType.FieldType_Unknown:
                    handler.string_value("Unknown");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasContacts)
          {
            handler.start_pair("Contacts");
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
        return null;
      }

    public static new SMSContactResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSContactResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSContactResult", ignore_extras);
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
    public static new SMSContactResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SMSContactResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SMSContactResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSContactResult", ignore_extras);
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
    public static new SMSContactResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SMSContactResultJSON from_text(string text, bool ignore_extras)
      {
        SMSContactResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSContactResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SMSContactResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SMSContactResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SMSContactResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SMSContactResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ContactResultJSON.Generator
      {
    private abstract class FieldGeneratorFieldType : JSONStringGenerator
          {
            protected FieldGeneratorFieldType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorFieldType()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToFieldType(result));
              }
            protected abstract void handle_result(TypeFieldType result);
          };
    private class FieldHoldingGeneratorFieldType : FieldGeneratorFieldType
  {
    protected override void handle_result(TypeFieldType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorFieldType(String what)
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
    public TypeFieldType value;
  };
    private class FieldHoldingArrayGeneratorFieldType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorFieldType
      {
        private FieldHoldingArrayGeneratorFieldType top;

        protected override void handle_result(TypeFieldType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorFieldType init_top)
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
    protected virtual void handle_result(List<TypeFieldType> result)
      {
      }

    public FieldHoldingArrayGeneratorFieldType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFieldType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorFieldType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeFieldType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeFieldType> value;
  };
        private FieldHoldingGeneratorFieldType fieldGeneratorFieldType;
        private SMSContactJSON.HoldingArrayGenerator fieldGeneratorContacts;
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
            SMSContactResultJSON result = new SMSContactResultJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSMSContactResultAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ContactResultJSON new_result)
          {
            handle_result((SMSContactResultJSON )new_result);
          }
        protected void finish(SMSContactResultJSON result)
          {
            if (fieldGeneratorFieldType.have_value)
              {
                result.setFieldType(fieldGeneratorFieldType.value);
                fieldGeneratorFieldType.have_value = false;
              }
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
            base.finish(result);
          }
        protected abstract void handle_result(SMSContactResultJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ontacts", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorContacts;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "ieldType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorFieldType;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorFieldType = new FieldHoldingGeneratorFieldType("field \"FieldType\" of the SMSContactResult class");
            fieldGeneratorContacts = new SMSContactJSON.HoldingArrayGenerator("field \"Contacts\" of the SMSContactResult class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SMSContactResult class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorFieldType = new FieldHoldingGeneratorFieldType("field \"FieldType\" of the SMSContactResult class");
            fieldGeneratorContacts = new SMSContactJSON.HoldingArrayGenerator("field \"Contacts\" of the SMSContactResult class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SMSContactResult class");
          }

        public override void reset()
          {
            fieldGeneratorFieldType.reset();
            fieldGeneratorContacts.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SMSContactResultJSON  result)
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
        public SMSContactResultJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SMSContactResultJSON  result)
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
    protected virtual void handle_result(List<SMSContactResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SMSContactResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SMSContactResultJSON>();
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
    public List<SMSContactResultJSON> value;
  };
    public static SMSContactResultJSON from_ContactResultJSON_json(ContactResultJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        SMSContactResultJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type SMSContactResult", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
