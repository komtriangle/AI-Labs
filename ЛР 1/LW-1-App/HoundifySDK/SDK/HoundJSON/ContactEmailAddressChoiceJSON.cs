/* file "ContactEmailAddressChoiceJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ContactEmailAddressChoiceJSON : JSONBase
  {
    private bool flagHasEmailAddress;
    private string storeEmailAddress;
    private bool flagHasFromUserNames;
    private List< string > storeFromUserNames;
    private bool flagHasDefiningCategory;
    private string storeDefiningCategory;
    private bool flagHasCategories;
    private List< string > storeCategories;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONEmailAddress(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EmailAddress of ContactEmailAddressChoiceJSON is not a string.");
        setEmailAddress(json_string.getData());
      }


    private void  fromJSONFromUserNames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FromUserNames of ContactEmailAddressChoiceJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_FromUserNames1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field FromUserNames of ContactEmailAddressChoiceJSON is not a string.");
            vector_FromUserNames1.Add(json_string.getData());
          }
        initFromUserNames();
        for (int num1 = 0; num1 < vector_FromUserNames1.Count; ++num1)
            appendFromUserNames(vector_FromUserNames1[num1]);
        for (int num1 = 0; num1 < vector_FromUserNames1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDefiningCategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DefiningCategory of ContactEmailAddressChoiceJSON is not a string.");
        setDefiningCategory(json_string.getData());
      }


    private void  fromJSONCategories(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Categories of ContactEmailAddressChoiceJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Categories1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Categories of ContactEmailAddressChoiceJSON is not a string.");
            vector_Categories1.Add(json_string.getData());
          }
        initCategories();
        for (int num2 = 0; num2 < vector_Categories1.Count; ++num2)
            appendCategories(vector_Categories1[num2]);
        for (int num1 = 0; num1 < vector_Categories1.Count; ++num1)
          {
          }
      }


    public ContactEmailAddressChoiceJSON()
      {
        flagHasEmailAddress = false;
        flagHasFromUserNames = false;
        flagHasDefiningCategory = false;
        flagHasCategories = false;
        storeFromUserNames = new List< string >();
        storeCategories = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasEmailAddress()
      {
        return flagHasEmailAddress;
      }

    public string  getEmailAddress()
      {
        Debug.Assert(flagHasEmailAddress);
        return storeEmailAddress;
      }

    public bool  hasFromUserNames()
      {
        return flagHasFromUserNames;
      }

    public int  countOfFromUserNames()
      {
        Debug.Assert(flagHasFromUserNames);
        return storeFromUserNames.Count;
      }

    public string  elementOfFromUserNames(int element_num)
      {
        Debug.Assert(flagHasFromUserNames);
        return storeFromUserNames[element_num];
      }

    public List< string >  getFromUserNames()
      {
        Debug.Assert(flagHasFromUserNames);
        return storeFromUserNames;
      }

    public bool  hasDefiningCategory()
      {
        return flagHasDefiningCategory;
      }

    public string  getDefiningCategory()
      {
        Debug.Assert(flagHasDefiningCategory);
        return storeDefiningCategory;
      }

    public bool  hasCategories()
      {
        return flagHasCategories;
      }

    public int  countOfCategories()
      {
        Debug.Assert(flagHasCategories);
        return storeCategories.Count;
      }

    public string  elementOfCategories(int element_num)
      {
        Debug.Assert(flagHasCategories);
        return storeCategories[element_num];
      }

    public List< string >  getCategories()
      {
        Debug.Assert(flagHasCategories);
        return storeCategories;
      }


    public virtual int extraContactEmailAddressChoiceComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraContactEmailAddressChoiceComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraContactEmailAddressChoiceComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraContactEmailAddressChoiceLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setEmailAddress(string new_value)
      {
        flagHasEmailAddress = true;
        storeEmailAddress = new_value;
      }
    public void unsetEmailAddress()
      {
        flagHasEmailAddress = false;
      }
    public void initFromUserNames()
      {
        flagHasFromUserNames = true;
        storeFromUserNames.Clear();
      }
    public void appendFromUserNames(string to_append)
      {
        if (!flagHasFromUserNames)
          {
            flagHasFromUserNames = true;
            storeFromUserNames.Clear();
          }
        Debug.Assert(flagHasFromUserNames);
        storeFromUserNames.Add(to_append);
      }
    public void unsetFromUserNames()
      {
        flagHasFromUserNames = false;
        storeFromUserNames.Clear();
      }
    public void setDefiningCategory(string new_value)
      {
        flagHasDefiningCategory = true;
        storeDefiningCategory = new_value;
      }
    public void unsetDefiningCategory()
      {
        flagHasDefiningCategory = false;
      }
    public void initCategories()
      {
        flagHasCategories = true;
        storeCategories.Clear();
      }
    public void appendCategories(string to_append)
      {
        if (!flagHasCategories)
          {
            flagHasCategories = true;
            storeCategories.Clear();
          }
        Debug.Assert(flagHasCategories);
        storeCategories.Add(to_append);
      }
    public void unsetCategories()
      {
        flagHasCategories = false;
        storeCategories.Clear();
      }

    public virtual void extraContactEmailAddressChoiceAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraContactEmailAddressChoiceSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraContactEmailAddressChoiceLookup(key);
        if (old_field == null)
          {
            extraContactEmailAddressChoiceAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasEmailAddress);
        if (flagHasEmailAddress)
          {
            handler.start_pair("EmailAddress");
            handler.string_value(storeEmailAddress);
          }
        Debug.Assert(partial_allowed || flagHasFromUserNames);
        if (flagHasFromUserNames)
          {
            handler.start_pair("FromUserNames");
            handler.start_array();
            for (int num1 = 0; num1 < storeFromUserNames.Count; ++num1)
              {
                handler.string_value(storeFromUserNames[num1]);
              }
            handler.finish_array();
          }
        if (flagHasDefiningCategory)
          {
            handler.start_pair("DefiningCategory");
            handler.string_value(storeDefiningCategory);
          }
        Debug.Assert(partial_allowed || flagHasCategories);
        if (flagHasCategories)
          {
            handler.start_pair("Categories");
            handler.start_array();
            for (int num2 = 0; num2 < storeCategories.Count; ++num2)
              {
                handler.string_value(storeCategories[num2]);
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
        if (!(hasEmailAddress()))
          {
            return "When parsing the object for %what%, the \"EmailAddress\" field was missing.";
          }
        if (!(hasFromUserNames()))
          {
            return "When parsing the object for %what%, the \"FromUserNames\" field was missing.";
          }
        if (!(hasCategories()))
          {
            return "When parsing the object for %what%, the \"Categories\" field was missing.";
          }
        return null;
      }

    public static ContactEmailAddressChoiceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactEmailAddressChoiceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactEmailAddressChoice", ignore_extras);
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
    public static ContactEmailAddressChoiceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ContactEmailAddressChoiceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ContactEmailAddressChoiceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactEmailAddressChoice", ignore_extras);
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
    public static ContactEmailAddressChoiceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ContactEmailAddressChoiceJSON from_text(string text, bool ignore_extras)
      {
        ContactEmailAddressChoiceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactEmailAddressChoice", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ContactEmailAddressChoiceJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ContactEmailAddressChoiceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ContactEmailAddressChoiceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ContactEmailAddressChoice", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorEmailAddress;
        private JSONHoldingStringArrayGenerator fieldGeneratorFromUserNames;
        private JSONHoldingStringGenerator fieldGeneratorDefiningCategory;
        private JSONHoldingStringArrayGenerator fieldGeneratorCategories;
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
            ContactEmailAddressChoiceJSON result = new ContactEmailAddressChoiceJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraContactEmailAddressChoiceAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ContactEmailAddressChoiceJSON result)
          {
            if (fieldGeneratorEmailAddress.have_value)
              {
                result.setEmailAddress(fieldGeneratorEmailAddress.value);
                fieldGeneratorEmailAddress.have_value = false;
              }
            else if ((!(result.hasEmailAddress())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EmailAddress\" field was missing.");
              }
            if (fieldGeneratorFromUserNames.have_value)
              {
                result.initFromUserNames();
                int count = fieldGeneratorFromUserNames.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFromUserNames(fieldGeneratorFromUserNames.value[num]);
                  }
                fieldGeneratorFromUserNames.value.Clear();
                fieldGeneratorFromUserNames.have_value = false;
              }
            else if ((!(result.hasFromUserNames())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FromUserNames\" field was missing.");
              }
            if (fieldGeneratorDefiningCategory.have_value)
              {
                result.setDefiningCategory(fieldGeneratorDefiningCategory.value);
                fieldGeneratorDefiningCategory.have_value = false;
              }
            if (fieldGeneratorCategories.have_value)
              {
                result.initCategories();
                int count = fieldGeneratorCategories.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCategories(fieldGeneratorCategories.value[num]);
                  }
                fieldGeneratorCategories.value.Clear();
                fieldGeneratorCategories.have_value = false;
              }
            else if ((!(result.hasCategories())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Categories\" field was missing.");
              }
          }
        protected abstract void handle_result(ContactEmailAddressChoiceJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ategories", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorCategories;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "efiningCategory", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorDefiningCategory;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "mailAddress", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorEmailAddress;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "romUserNames", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorFromUserNames;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorEmailAddress = new JSONHoldingStringGenerator("field \"EmailAddress\" of the ContactEmailAddressChoice class");
            fieldGeneratorFromUserNames = new JSONHoldingStringArrayGenerator("field \"FromUserNames\" of the ContactEmailAddressChoice class");
            fieldGeneratorDefiningCategory = new JSONHoldingStringGenerator("field \"DefiningCategory\" of the ContactEmailAddressChoice class");
            fieldGeneratorCategories = new JSONHoldingStringArrayGenerator("field \"Categories\" of the ContactEmailAddressChoice class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ContactEmailAddressChoice class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorEmailAddress = new JSONHoldingStringGenerator("field \"EmailAddress\" of the ContactEmailAddressChoice class");
            fieldGeneratorFromUserNames = new JSONHoldingStringArrayGenerator("field \"FromUserNames\" of the ContactEmailAddressChoice class");
            fieldGeneratorDefiningCategory = new JSONHoldingStringGenerator("field \"DefiningCategory\" of the ContactEmailAddressChoice class");
            fieldGeneratorCategories = new JSONHoldingStringArrayGenerator("field \"Categories\" of the ContactEmailAddressChoice class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ContactEmailAddressChoice class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorEmailAddress.reset();
            fieldGeneratorFromUserNames.reset();
            fieldGeneratorDefiningCategory.reset();
            fieldGeneratorCategories.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ContactEmailAddressChoiceJSON  result)
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
        public ContactEmailAddressChoiceJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ContactEmailAddressChoiceJSON  result)
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
    protected virtual void handle_result(List<ContactEmailAddressChoiceJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ContactEmailAddressChoiceJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ContactEmailAddressChoiceJSON>();
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
    public List<ContactEmailAddressChoiceJSON> value;
  };
  };
