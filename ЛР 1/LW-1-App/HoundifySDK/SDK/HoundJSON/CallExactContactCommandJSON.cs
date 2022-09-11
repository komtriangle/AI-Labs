/* file "CallExactContactCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CallExactContactCommandJSON : PhoneCommandJSON
  {
    private bool flagHasNumber;
    private string storeNumber;
    private bool flagHasContacts;
    private List< OneContactJSON  > storeContacts;
    private bool flagHasUserSpecifiedName;
    private string storeUserSpecifiedName;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNumberToJSON()
      {
        JSONStringValue generated_string_Number = new JSONStringValue(storeNumber);
        return generated_string_Number;
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

    private JSONValue  extraUserSpecifiedNameToJSON()
      {
        JSONStringValue generated_string_UserSpecifiedName = new JSONStringValue(storeUserSpecifiedName);
        return generated_string_UserSpecifiedName;
      }


    private void  fromJSONNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Number of CallExactContactCommandJSON is not a string.");
        setNumber(json_string.getData());
      }


    private void  fromJSONContacts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Contacts of CallExactContactCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Contacts of CallExactContactCommandJSON has too few elements.");
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


    private void  fromJSONUserSpecifiedName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UserSpecifiedName of CallExactContactCommandJSON is not a string.");
        setUserSpecifiedName(json_string.getData());
      }


    public CallExactContactCommandJSON()
      {
        flagHasNumber = false;
        flagHasContacts = false;
        flagHasUserSpecifiedName = false;
        storeContacts = new List< OneContactJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getPhoneCommandKind()
      {
        return "CallExactContact";
      }

    public bool  hasNumber()
      {
        return flagHasNumber;
      }

    public string  getNumber()
      {
        Debug.Assert(flagHasNumber);
        return storeNumber;
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

    public bool  hasUserSpecifiedName()
      {
        return flagHasUserSpecifiedName;
      }

    public string  getUserSpecifiedName()
      {
        Debug.Assert(flagHasUserSpecifiedName);
        return storeUserSpecifiedName;
      }


    public virtual int extraCallExactContactCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCallExactContactCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCallExactContactCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCallExactContactCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraPhoneCommandComponentCount()
      {
        int result = 0;
        if (flagHasNumber)
            ++result;
        if (flagHasContacts)
            ++result;
        if (flagHasUserSpecifiedName)
            ++result;
        result += extraCallExactContactCommandComponentCount();
        return result;
      }
    public override string extraPhoneCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNumber)
          {
            if (remainder == 0)
                return "Number";
            --remainder;
          }
        if (flagHasContacts)
          {
            if (remainder == 0)
                return "Contacts";
            --remainder;
          }
        if (flagHasUserSpecifiedName)
          {
            if (remainder == 0)
                return "UserSpecifiedName";
            --remainder;
          }
        return extraCallExactContactCommandComponentKey(remainder);
      }
    public override JSONValue extraPhoneCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNumber)
          {
            if (remainder == 0)
                return extraNumberToJSON();
            --remainder;
          }
        if (flagHasContacts)
          {
            if (remainder == 0)
                return extraContactsToJSON();
            --remainder;
          }
        if (flagHasUserSpecifiedName)
          {
            if (remainder == 0)
                return extraUserSpecifiedNameToJSON();
            --remainder;
          }
        return extraCallExactContactCommandComponentValue(remainder);
      }
    public override JSONValue extraPhoneCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ontacts", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasContacts ? extraContactsToJSON() : null);
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "umber", 0, 5, false) == 0) && (field_name.Length == 6))
                    return (flagHasNumber ? extraNumberToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "serSpecifiedName", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasUserSpecifiedName ? extraUserSpecifiedNameToJSON() : null);
                break;
            default:
                break;
          }
        return extraCallExactContactCommandLookup(field_name);
      }

    public void setNumber(string new_value)
      {
        flagHasNumber = true;
        storeNumber = new_value;
      }
    public void unsetNumber()
      {
        flagHasNumber = false;
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
    public void setUserSpecifiedName(string new_value)
      {
        flagHasUserSpecifiedName = true;
        storeUserSpecifiedName = new_value;
      }
    public void unsetUserSpecifiedName()
      {
        flagHasUserSpecifiedName = false;
      }

    public virtual void extraCallExactContactCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCallExactContactCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCallExactContactCommandLookup(key);
        if (old_field == null)
          {
            extraCallExactContactCommandAppendPair(key, new_component);
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
    public override void extraPhoneCommandAppendPair(string key, JSONValue new_component)
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
            case 'N':
                if ((String.Compare(key, 1, "umber", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONNumber(new_component, false);
                    return;
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
        extraCallExactContactCommandAppendPair(key, new_component);
      }
    public override void extraPhoneCommandSetField(string key, JSONValue new_component)
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
            case 'N':
                if ((String.Compare(key, 1, "umber", 0, 5, false) == 0) && (key.Length == 6))
                    {
                    fromJSONNumber(new_component, false);
                    return;
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
        extraCallExactContactCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNumber);
        if (flagHasNumber)
          {
            handler.start_pair("Number");
            handler.string_value(storeNumber);
          }
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
        if (!(hasNumber()))
          {
            return "When parsing the object for %what%, the \"Number\" field was missing.";
          }
        if (!(hasContacts()))
          {
            return "When parsing the object for %what%, the \"Contacts\" field was missing.";
          }
        return null;
      }

    public static new CallExactContactCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CallExactContactCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CallExactContactCommand", ignore_extras);
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
    public static new CallExactContactCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CallExactContactCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CallExactContactCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CallExactContactCommand", ignore_extras);
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
    public static new CallExactContactCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new CallExactContactCommandJSON from_text(string text, bool ignore_extras)
      {
        CallExactContactCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CallExactContactCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CallExactContactCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new CallExactContactCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CallExactContactCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CallExactContactCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : PhoneCommandJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorNumber;
        private OneContactJSON.HoldingArrayGenerator fieldGeneratorContacts;
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
            if (!(getPhoneCommandJSONKey().Equals("CallExactContact")))
                throw new Exception("The key field has a value other than `CallExactContact'.");
            CallExactContactCommandJSON result = new CallExactContactCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCallExactContactCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(PhoneCommandJSON new_result)
          {
            handle_result((CallExactContactCommandJSON )new_result);
          }
        protected void finish(CallExactContactCommandJSON result)
          {
            if (fieldGeneratorNumber.have_value)
              {
                result.setNumber(fieldGeneratorNumber.value);
                fieldGeneratorNumber.have_value = false;
              }
            else if ((!(result.hasNumber())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Number\" field was missing.");
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
            else if ((!(result.hasContacts())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Contacts\" field was missing.");
              }
            if (fieldGeneratorUserSpecifiedName.have_value)
              {
                result.setUserSpecifiedName(fieldGeneratorUserSpecifiedName.value);
                fieldGeneratorUserSpecifiedName.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(CallExactContactCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ontacts", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorContacts;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "umber", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorNumber;
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
            fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the CallExactContactCommand class");
            fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the CallExactContactCommand class", ignore_extras);
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the CallExactContactCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CallExactContactCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNumber = new JSONHoldingStringGenerator("field \"Number\" of the CallExactContactCommand class");
            fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the CallExactContactCommand class", false);
            fieldGeneratorUserSpecifiedName = new JSONHoldingStringGenerator("field \"UserSpecifiedName\" of the CallExactContactCommand class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CallExactContactCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNumber.reset();
            fieldGeneratorContacts.reset();
            fieldGeneratorUserSpecifiedName.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(CallExactContactCommandJSON  result)
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
        public CallExactContactCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CallExactContactCommandJSON  result)
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
    protected virtual void handle_result(List<CallExactContactCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CallExactContactCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CallExactContactCommandJSON>();
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
    public List<CallExactContactCommandJSON> value;
  };
  };
