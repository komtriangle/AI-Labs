/* file "PersonGroupJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class PersonGroupJSON : JSONBase
  {
    public class TypePersonsJSON : JSONBase
      {
        private bool flagHasContacts;
        private List< OneContactJSON  > storeContacts;
        private bool flagHasToUserWrittenName;
        private string storeToUserWrittenName;
        private bool flagHasToUserSpokenName;
        private string storeToUserSpokenName;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONContacts(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Contacts of TypePersonsJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< OneContactJSON  > vector_Contacts1 = new List< OneContactJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                OneContactJSON convert_classy = OneContactJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Contacts1.Add(convert_classy);
              }
            initContacts();
            for (int num1 = 0; num1 < vector_Contacts1.Count; ++num1)
                appendContacts(vector_Contacts1[num1]);
            for (int num1 = 0; num1 < vector_Contacts1.Count; ++num1)
              {
              }
          }


        private void  fromJSONToUserWrittenName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ToUserWrittenName of TypePersonsJSON is not a string.");
            setToUserWrittenName(json_string.getData());
          }


        private void  fromJSONToUserSpokenName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ToUserSpokenName of TypePersonsJSON is not a string.");
            setToUserSpokenName(json_string.getData());
          }


        public TypePersonsJSON()
          {
            flagHasContacts = false;
            flagHasToUserWrittenName = false;
            flagHasToUserSpokenName = false;
            storeContacts = new List< OneContactJSON  >();
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

        public bool  hasToUserWrittenName()
          {
            return flagHasToUserWrittenName;
          }

        public string  getToUserWrittenName()
          {
            Debug.Assert(flagHasToUserWrittenName);
            return storeToUserWrittenName;
          }

        public bool  hasToUserSpokenName()
          {
            return flagHasToUserSpokenName;
          }

        public string  getToUserSpokenName()
          {
            Debug.Assert(flagHasToUserSpokenName);
            return storeToUserSpokenName;
          }


        public virtual int extraTypePersonsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePersonsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePersonsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePersonsLookup(string field_name)
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
        public void setToUserWrittenName(string new_value)
          {
            flagHasToUserWrittenName = true;
            storeToUserWrittenName = new_value;
          }
        public void unsetToUserWrittenName()
          {
            flagHasToUserWrittenName = false;
          }
        public void setToUserSpokenName(string new_value)
          {
            flagHasToUserSpokenName = true;
            storeToUserSpokenName = new_value;
          }
        public void unsetToUserSpokenName()
          {
            flagHasToUserSpokenName = false;
          }

        public virtual void extraTypePersonsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePersonsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePersonsLookup(key);
            if (old_field == null)
              {
                extraTypePersonsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasToUserWrittenName);
            if (flagHasToUserWrittenName)
              {
                handler.start_pair("ToUserWrittenName");
                handler.string_value(storeToUserWrittenName);
              }
            Debug.Assert(partial_allowed || flagHasToUserSpokenName);
            if (flagHasToUserSpokenName)
              {
                handler.start_pair("ToUserSpokenName");
                handler.string_value(storeToUserSpokenName);
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
            if (!(hasToUserWrittenName()))
              {
                return "When parsing the object for %what%, the \"ToUserWrittenName\" field was missing.";
              }
            if (!(hasToUserSpokenName()))
              {
                return "When parsing the object for %what%, the \"ToUserSpokenName\" field was missing.";
              }
            return null;
          }

        public static TypePersonsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePersonsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePersons", ignore_extras);
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
        public static TypePersonsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePersonsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePersonsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePersons", ignore_extras);
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
        public static TypePersonsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePersonsJSON from_text(string text, bool ignore_extras)
          {
            TypePersonsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePersons", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePersonsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePersonsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePersonsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePersons", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private OneContactJSON.HoldingArrayGenerator fieldGeneratorContacts;
            private JSONHoldingStringGenerator fieldGeneratorToUserWrittenName;
            private JSONHoldingStringGenerator fieldGeneratorToUserSpokenName;
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
                TypePersonsJSON result = new TypePersonsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePersonsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePersonsJSON result)
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
                if (fieldGeneratorToUserWrittenName.have_value)
                  {
                    result.setToUserWrittenName(fieldGeneratorToUserWrittenName.value);
                    fieldGeneratorToUserWrittenName.have_value = false;
                  }
                else if ((!(result.hasToUserWrittenName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ToUserWrittenName\" field was missing.");
                  }
                if (fieldGeneratorToUserSpokenName.have_value)
                  {
                    result.setToUserSpokenName(fieldGeneratorToUserSpokenName.value);
                    fieldGeneratorToUserSpokenName.have_value = false;
                  }
                else if ((!(result.hasToUserSpokenName())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ToUserSpokenName\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypePersonsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "ontacts", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorContacts;
                        break;
                    case 'T':
                        if (String.Compare(field_name, 1, "oUser", 0, 5, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'S':
                                    if ((String.Compare(field_name, 7, "pokenName", 0, 9, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorToUserSpokenName;
                                    break;
                                case 'W':
                                    if ((String.Compare(field_name, 7, "rittenName", 0, 10, false) == 0) && (field_name.Length == 17))
                                        return fieldGeneratorToUserWrittenName;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the TypePersons class", ignore_extras);
                fieldGeneratorToUserWrittenName = new JSONHoldingStringGenerator("field \"ToUserWrittenName\" of the TypePersons class");
                fieldGeneratorToUserSpokenName = new JSONHoldingStringGenerator("field \"ToUserSpokenName\" of the TypePersons class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePersons class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the TypePersons class", false);
                fieldGeneratorToUserWrittenName = new JSONHoldingStringGenerator("field \"ToUserWrittenName\" of the TypePersons class");
                fieldGeneratorToUserSpokenName = new JSONHoldingStringGenerator("field \"ToUserSpokenName\" of the TypePersons class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePersons class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorContacts.reset();
                fieldGeneratorToUserWrittenName.reset();
                fieldGeneratorToUserSpokenName.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorContacts.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorContacts.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypePersonsJSON  result)
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
            public TypePersonsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePersonsJSON  result)
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
        protected virtual void handle_result(List<TypePersonsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePersonsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePersonsJSON>();
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
        public List<TypePersonsJSON> value;
      };
      };
    private bool flagHasPersons;
    private List< TypePersonsJSON  > storePersons;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPersons(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Persons of PersonGroupJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Persons of PersonGroupJSON has too few elements.");
        List< TypePersonsJSON  > vector_Persons1 = new List< TypePersonsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypePersonsJSON convert_classy = TypePersonsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Persons1.Add(convert_classy);
          }
        Debug.Assert(vector_Persons1.Count >= 1);
        initPersons();
        for (int num2 = 0; num2 < vector_Persons1.Count; ++num2)
            appendPersons(vector_Persons1[num2]);
        for (int num1 = 0; num1 < vector_Persons1.Count; ++num1)
          {
          }
      }


    public PersonGroupJSON()
      {
        flagHasPersons = false;
        storePersons = new List< TypePersonsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPersons()
      {
        return flagHasPersons;
      }

    public int  countOfPersons()
      {
        Debug.Assert(flagHasPersons);
        return storePersons.Count;
      }

    public TypePersonsJSON   elementOfPersons(int element_num)
      {
        Debug.Assert(flagHasPersons);
        return storePersons[element_num];
      }

    public List< TypePersonsJSON  >  getPersons()
      {
        Debug.Assert(flagHasPersons);
        return storePersons;
      }


    public virtual int extraPersonGroupComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraPersonGroupComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraPersonGroupComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraPersonGroupLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initPersons()
      {
        if (flagHasPersons)
          {
            for (int num3 = 0; num3 < storePersons.Count; ++num3)
              {
              }
          }
        flagHasPersons = true;
        storePersons.Clear();
      }
    public void appendPersons(TypePersonsJSON  to_append)
      {
        if (!flagHasPersons)
          {
            flagHasPersons = true;
            storePersons.Clear();
          }
        Debug.Assert(flagHasPersons);
        storePersons.Add(to_append);
      }
    public void unsetPersons()
      {
        if (flagHasPersons)
          {
            for (int num4 = 0; num4 < storePersons.Count; ++num4)
              {
              }
          }
        flagHasPersons = false;
        storePersons.Clear();
      }

    public virtual void extraPersonGroupAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraPersonGroupSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraPersonGroupLookup(key);
        if (old_field == null)
          {
            extraPersonGroupAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPersons);
        if (flagHasPersons)
          {
            handler.start_pair("Persons");
            Debug.Assert(storePersons.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storePersons.Count; ++num1)
              {
                if (partial_allowed)
                    storePersons[num1].write_partial_as_json(handler);
                else
                    storePersons[num1].write_as_json(handler);
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
        if (!(hasPersons()))
          {
            return "When parsing the object for %what%, the \"Persons\" field was missing.";
          }
        return null;
      }

    public static PersonGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonGroup", ignore_extras);
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
    public static PersonGroupJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PersonGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        PersonGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonGroup", ignore_extras);
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
    public static PersonGroupJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static PersonGroupJSON from_text(string text, bool ignore_extras)
      {
        PersonGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonGroup", ignore_extras);
            JSONParse.parse_json_value(text, "Text for PersonGroupJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static PersonGroupJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        PersonGroupJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type PersonGroup", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypePersonsJSON.HoldingArrayGenerator fieldGeneratorPersons;
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
            PersonGroupJSON result = new PersonGroupJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraPersonGroupAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(PersonGroupJSON result)
          {
            if (fieldGeneratorPersons.have_value)
              {
                result.initPersons();
                int count = fieldGeneratorPersons.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPersons(fieldGeneratorPersons.value[num]);
                  }
                fieldGeneratorPersons.value.Clear();
                fieldGeneratorPersons.have_value = false;
              }
            else if ((!(result.hasPersons())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Persons\" field was missing.");
              }
          }
        protected abstract void handle_result(PersonGroupJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Persons", 0, 7, false) == 0) && (field_name.Length == 7))
                return fieldGeneratorPersons;
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPersons = new TypePersonsJSON.HoldingArrayGenerator("field \"Persons\" of the PersonGroup class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the PersonGroup class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPersons = new TypePersonsJSON.HoldingArrayGenerator("field \"Persons\" of the PersonGroup class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the PersonGroup class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPersons.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPersons.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPersons.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(PersonGroupJSON  result)
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
        public PersonGroupJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(PersonGroupJSON  result)
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
    protected virtual void handle_result(List<PersonGroupJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<PersonGroupJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<PersonGroupJSON>();
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
    public List<PersonGroupJSON> value;
  };
  };
