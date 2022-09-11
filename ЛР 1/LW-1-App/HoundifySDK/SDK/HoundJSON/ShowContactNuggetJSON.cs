/* file "ShowContactNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ShowContactNuggetJSON : InformationNuggetJSON
  {
    public class TypeRequestedFieldsJSON : JSONBase
      {
        public enum TypeField
          {
            Field_Phone,
            Field_Email,
            Field_Street
          };

        public static TypeField  stringToField(string chars)
          {
            switch (chars[0])
              {
                case 'E':
                    if ((String.Compare(chars, 1, "mail", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeField.Field_Email;
                    break;
                case 'P':
                    if ((String.Compare(chars, 1, "hone", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeField.Field_Phone;
                    break;
                case 'S':
                    if ((String.Compare(chars, 1, "treet", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeField.Field_Street;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `Field' is not one of the legal values.");
          }

        public static string  stringFromField(TypeField the_enum)
          {
            switch (the_enum)
              {
                case TypeField.Field_Phone:
                    return "Phone";
                case TypeField.Field_Email:
                    return "Email";
                case TypeField.Field_Street:
                    return "Street";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasField;
        private TypeField storeField;
        private bool flagHasCategory;
        private string storeCategory;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONField(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Field of TypeRequestedFieldsJSON is not a string.");
            TypeField the_enum;
            switch (json_string.getData()[0])
              {
                case 'E':
                    if ((String.Compare(json_string.getData(), 1, "mail", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeField.Field_Email;
                            goto enum_is_done;
                          }
                    break;
                case 'P':
                    if ((String.Compare(json_string.getData(), 1, "hone", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeField.Field_Phone;
                            goto enum_is_done;
                          }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "treet", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_enum = TypeField.Field_Street;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field Field of TypeRequestedFieldsJSON is not one of the legal strings.");
          enum_is_done:;
            setField(the_enum);
          }


        private void  fromJSONCategory(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Category of TypeRequestedFieldsJSON is not a string.");
            setCategory(json_string.getData());
          }


        public TypeRequestedFieldsJSON()
          {
            flagHasField = false;
            flagHasCategory = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasField()
          {
            return flagHasField;
          }

        public TypeField  getField()
          {
            Debug.Assert(flagHasField);
            return storeField;
          }

        public string  getFieldAsString()
          {
            return stringFromField(getField());
          }

        public bool  hasCategory()
          {
            return flagHasCategory;
          }

        public string  getCategory()
          {
            Debug.Assert(flagHasCategory);
            return storeCategory;
          }


        public virtual int extraTypeRequestedFieldsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeRequestedFieldsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeRequestedFieldsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeRequestedFieldsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setField(TypeField new_value)
          {
            flagHasField = true;
            storeField = new_value;
          }
        public void setField(string chars)
          {
            setField(stringToField(chars));
          }
        public void unsetField()
          {
            flagHasField = false;
          }
        public void setCategory(string new_value)
          {
            flagHasCategory = true;
            storeCategory = new_value;
          }
        public void unsetCategory()
          {
            flagHasCategory = false;
          }

        public virtual void extraTypeRequestedFieldsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeRequestedFieldsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeRequestedFieldsLookup(key);
            if (old_field == null)
              {
                extraTypeRequestedFieldsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasField);
            if (flagHasField)
              {
                handler.start_pair("Field");
                switch (storeField)
                  {
                    case TypeField.Field_Phone:
                        handler.string_value("Phone");
                        break;
                    case TypeField.Field_Email:
                        handler.string_value("Email");
                        break;
                    case TypeField.Field_Street:
                        handler.string_value("Street");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            if (flagHasCategory)
              {
                handler.start_pair("Category");
                handler.string_value(storeCategory);
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
            if (!(hasField()))
              {
                return "When parsing the object for %what%, the \"Field\" field was missing.";
              }
            return null;
          }

        public static TypeRequestedFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeRequestedFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRequestedFields", ignore_extras);
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
        public static TypeRequestedFieldsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeRequestedFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeRequestedFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRequestedFields", ignore_extras);
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
        public static TypeRequestedFieldsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeRequestedFieldsJSON from_text(string text, bool ignore_extras)
          {
            TypeRequestedFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRequestedFields", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeRequestedFieldsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeRequestedFieldsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeRequestedFieldsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeRequestedFields", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorField : JSONStringGenerator
              {
                protected FieldGeneratorField(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorField()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToField(result));
                  }
                protected abstract void handle_result(TypeField result);
              };
        private class FieldHoldingGeneratorField : FieldGeneratorField
      {
        protected override void handle_result(TypeField result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorField(String what)
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
        public TypeField value;
      };
        private class FieldHoldingArrayGeneratorField : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorField
          {
            private FieldHoldingArrayGeneratorField top;

            protected override void handle_result(TypeField result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorField init_top)
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
        protected virtual void handle_result(List<TypeField> result)
          {
          }

        public FieldHoldingArrayGeneratorField(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeField>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorField()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeField>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeField> value;
      };
            private FieldHoldingGeneratorField fieldGeneratorField;
            private JSONHoldingStringGenerator fieldGeneratorCategory;
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
                TypeRequestedFieldsJSON result = new TypeRequestedFieldsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeRequestedFieldsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeRequestedFieldsJSON result)
              {
                if (fieldGeneratorField.have_value)
                  {
                    result.setField(fieldGeneratorField.value);
                    fieldGeneratorField.have_value = false;
                  }
                else if ((!(result.hasField())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Field\" field was missing.");
                  }
                if (fieldGeneratorCategory.have_value)
                  {
                    result.setCategory(fieldGeneratorCategory.value);
                    fieldGeneratorCategory.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeRequestedFieldsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "ategory", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorCategory;
                        break;
                    case 'F':
                        if ((String.Compare(field_name, 1, "ield", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorField;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorField = new FieldHoldingGeneratorField("field \"Field\" of the TypeRequestedFields class");
                fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the TypeRequestedFields class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeRequestedFields class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorField = new FieldHoldingGeneratorField("field \"Field\" of the TypeRequestedFields class");
                fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the TypeRequestedFields class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeRequestedFields class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorField.reset();
                fieldGeneratorCategory.reset();
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
            protected override void handle_result(TypeRequestedFieldsJSON  result)
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
            public TypeRequestedFieldsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeRequestedFieldsJSON  result)
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
        protected virtual void handle_result(List<TypeRequestedFieldsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeRequestedFieldsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeRequestedFieldsJSON>();
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
        public List<TypeRequestedFieldsJSON> value;
      };
      };
    private bool flagHasContacts;
    private List< OneContactJSON  > storeContacts;
    private bool flagHasRequestedFields;
    private List< TypeRequestedFieldsJSON  > storeRequestedFields;
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

    private JSONValue  extraRequestedFieldsToJSON()
      {
        JSONArrayValue generated_array_2_RequestedFields = new JSONArrayValue();
        for (int num2 = 0; num2 < storeRequestedFields.Count; ++num2)
          {
            JSONValueHandler handler_RequestedFields = new JSONValueHandler();
            storeRequestedFields[num2].write_as_json(handler_RequestedFields);
            generated_array_2_RequestedFields.appendComponent(handler_RequestedFields.result);
          }
        return generated_array_2_RequestedFields;
      }


    private void  fromJSONContacts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Contacts of ShowContactNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Contacts of ShowContactNuggetJSON has too few elements.");
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


    private void  fromJSONRequestedFields(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequestedFields of ShowContactNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field RequestedFields of ShowContactNuggetJSON has too few elements.");
        List< TypeRequestedFieldsJSON  > vector_RequestedFields1 = new List< TypeRequestedFieldsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeRequestedFieldsJSON convert_classy = TypeRequestedFieldsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RequestedFields1.Add(convert_classy);
          }
        Debug.Assert(vector_RequestedFields1.Count >= 1);
        initRequestedFields();
        for (int num2 = 0; num2 < vector_RequestedFields1.Count; ++num2)
            appendRequestedFields(vector_RequestedFields1[num2]);
        for (int num1 = 0; num1 < vector_RequestedFields1.Count; ++num1)
          {
          }
      }


    public ShowContactNuggetJSON()
      {
        flagHasContacts = false;
        flagHasRequestedFields = false;
        storeContacts = new List< OneContactJSON  >();
        storeRequestedFields = new List< TypeRequestedFieldsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "ShowContact";
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

    public bool  hasRequestedFields()
      {
        return flagHasRequestedFields;
      }

    public int  countOfRequestedFields()
      {
        Debug.Assert(flagHasRequestedFields);
        return storeRequestedFields.Count;
      }

    public TypeRequestedFieldsJSON   elementOfRequestedFields(int element_num)
      {
        Debug.Assert(flagHasRequestedFields);
        return storeRequestedFields[element_num];
      }

    public List< TypeRequestedFieldsJSON  >  getRequestedFields()
      {
        Debug.Assert(flagHasRequestedFields);
        return storeRequestedFields;
      }


    public virtual int extraShowContactNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraShowContactNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraShowContactNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraShowContactNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasContacts)
            ++result;
        if (flagHasRequestedFields)
            ++result;
        result += extraShowContactNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasContacts)
          {
            if (remainder == 0)
                return "Contacts";
            --remainder;
          }
        if (flagHasRequestedFields)
          {
            if (remainder == 0)
                return "RequestedFields";
            --remainder;
          }
        return extraShowContactNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasContacts)
          {
            if (remainder == 0)
                return extraContactsToJSON();
            --remainder;
          }
        if (flagHasRequestedFields)
          {
            if (remainder == 0)
                return extraRequestedFieldsToJSON();
            --remainder;
          }
        return extraShowContactNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "ontacts", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasContacts ? extraContactsToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "equestedFields", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasRequestedFields ? extraRequestedFieldsToJSON() : null);
                break;
            default:
                break;
          }
        return extraShowContactNuggetLookup(field_name);
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
    public void initRequestedFields()
      {
        if (flagHasRequestedFields)
          {
            for (int num3 = 0; num3 < storeRequestedFields.Count; ++num3)
              {
              }
          }
        flagHasRequestedFields = true;
        storeRequestedFields.Clear();
      }
    public void appendRequestedFields(TypeRequestedFieldsJSON  to_append)
      {
        if (!flagHasRequestedFields)
          {
            flagHasRequestedFields = true;
            storeRequestedFields.Clear();
          }
        Debug.Assert(flagHasRequestedFields);
        storeRequestedFields.Add(to_append);
      }
    public void unsetRequestedFields()
      {
        if (flagHasRequestedFields)
          {
            for (int num4 = 0; num4 < storeRequestedFields.Count; ++num4)
              {
              }
          }
        flagHasRequestedFields = false;
        storeRequestedFields.Clear();
      }

    public virtual void extraShowContactNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraShowContactNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraShowContactNuggetLookup(key);
        if (old_field == null)
          {
            extraShowContactNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
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
            case 'R':
                if ((String.Compare(key, 1, "equestedFields", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONRequestedFields(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraShowContactNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
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
            case 'R':
                if ((String.Compare(key, 1, "equestedFields", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONRequestedFields(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraShowContactNuggetSetField(key, new_component);
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
        if (flagHasRequestedFields)
          {
            handler.start_pair("RequestedFields");
            Debug.Assert(storeRequestedFields.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeRequestedFields.Count; ++num2)
              {
                if (partial_allowed)
                    storeRequestedFields[num2].write_partial_as_json(handler);
                else
                    storeRequestedFields[num2].write_as_json(handler);
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

    public static new ShowContactNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowContactNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowContactNugget", ignore_extras);
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
    public static new ShowContactNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowContactNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowContactNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowContactNugget", ignore_extras);
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
    public static new ShowContactNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowContactNuggetJSON from_text(string text, bool ignore_extras)
      {
        ShowContactNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowContactNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ShowContactNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ShowContactNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ShowContactNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowContactNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
        private OneContactJSON.HoldingArrayGenerator fieldGeneratorContacts;
        private TypeRequestedFieldsJSON.HoldingArrayGenerator fieldGeneratorRequestedFields;
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
            if (!(getInformationNuggetJSONKey().Equals("ShowContact")))
                throw new Exception("The key field has a value other than `ShowContact'.");
            ShowContactNuggetJSON result = new ShowContactNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraShowContactNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((ShowContactNuggetJSON )new_result);
          }
        protected void finish(ShowContactNuggetJSON result)
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
            if (fieldGeneratorRequestedFields.have_value)
              {
                result.initRequestedFields();
                int count = fieldGeneratorRequestedFields.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequestedFields(fieldGeneratorRequestedFields.value[num]);
                  }
                fieldGeneratorRequestedFields.value.Clear();
                fieldGeneratorRequestedFields.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ShowContactNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ontacts", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorContacts;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedFields", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorRequestedFields;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the ShowContactNugget class", ignore_extras);
            fieldGeneratorRequestedFields = new TypeRequestedFieldsJSON.HoldingArrayGenerator("field \"RequestedFields\" of the ShowContactNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ShowContactNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the ShowContactNugget class", false);
            fieldGeneratorRequestedFields = new TypeRequestedFieldsJSON.HoldingArrayGenerator("field \"RequestedFields\" of the ShowContactNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ShowContactNugget class");
          }

        public override void reset()
          {
            fieldGeneratorContacts.reset();
            fieldGeneratorRequestedFields.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ShowContactNuggetJSON  result)
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
        public ShowContactNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ShowContactNuggetJSON  result)
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
    protected virtual void handle_result(List<ShowContactNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ShowContactNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ShowContactNuggetJSON>();
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
    public List<ShowContactNuggetJSON> value;
  };
  };
