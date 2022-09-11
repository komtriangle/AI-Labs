/* file "WhichContactChoicesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class WhichContactChoicesJSON : JSONBase
  {
    public class TypeChoicesJSON : JSONBase
      {
        private bool flagHasContacts;
        private List< OneContactJSON  > storeContacts;
        private bool flagHasToUserWrittenName;
        private string storeToUserWrittenName;
        private bool flagHasToUserSpokenName;
        private string storeToUserSpokenName;
        private bool flagHasFromUserNames;
        private List< string > storeFromUserNames;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONContacts(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Contacts of TypeChoicesJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field Contacts of TypeChoicesJSON has too few elements.");
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


        private void  fromJSONToUserWrittenName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ToUserWrittenName of TypeChoicesJSON is not a string.");
            setToUserWrittenName(json_string.getData());
          }


        private void  fromJSONToUserSpokenName(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ToUserSpokenName of TypeChoicesJSON is not a string.");
            setToUserSpokenName(json_string.getData());
          }


        private void  fromJSONFromUserNames(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field FromUserNames of TypeChoicesJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< string > vector_FromUserNames1 = new List< string >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                JSONStringValue json_string = json_array1.component(num1).string_value();
                if (json_string == null)
                    throw new Exception("The value for an element of field FromUserNames of TypeChoicesJSON is not a string.");
                vector_FromUserNames1.Add(json_string.getData());
              }
            initFromUserNames();
            for (int num2 = 0; num2 < vector_FromUserNames1.Count; ++num2)
                appendFromUserNames(vector_FromUserNames1[num2]);
            for (int num1 = 0; num1 < vector_FromUserNames1.Count; ++num1)
              {
              }
          }


        public TypeChoicesJSON()
          {
            flagHasContacts = false;
            flagHasToUserWrittenName = false;
            flagHasToUserSpokenName = false;
            flagHasFromUserNames = false;
            storeContacts = new List< OneContactJSON  >();
            storeFromUserNames = new List< string >();
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


        public virtual int extraTypeChoicesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeChoicesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeChoicesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeChoicesLookup(string field_name)
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

        public virtual void extraTypeChoicesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeChoicesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeChoicesLookup(key);
            if (old_field == null)
              {
                extraTypeChoicesAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasFromUserNames);
            if (flagHasFromUserNames)
              {
                handler.start_pair("FromUserNames");
                handler.start_array();
                for (int num2 = 0; num2 < storeFromUserNames.Count; ++num2)
                  {
                    handler.string_value(storeFromUserNames[num2]);
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
            if (!(hasToUserWrittenName()))
              {
                return "When parsing the object for %what%, the \"ToUserWrittenName\" field was missing.";
              }
            if (!(hasToUserSpokenName()))
              {
                return "When parsing the object for %what%, the \"ToUserSpokenName\" field was missing.";
              }
            if (!(hasFromUserNames()))
              {
                return "When parsing the object for %what%, the \"FromUserNames\" field was missing.";
              }
            return null;
          }

        public static TypeChoicesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeChoicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeChoices", ignore_extras);
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
        public static TypeChoicesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeChoicesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeChoicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeChoices", ignore_extras);
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
        public static TypeChoicesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeChoicesJSON from_text(string text, bool ignore_extras)
          {
            TypeChoicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeChoices", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeChoicesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeChoicesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeChoicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeChoices", ignore_extras);
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
            private JSONHoldingStringArrayGenerator fieldGeneratorFromUserNames;
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
                TypeChoicesJSON result = new TypeChoicesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeChoicesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeChoicesJSON result)
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
              }
            protected abstract void handle_result(TypeChoicesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "ontacts", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorContacts;
                        break;
                    case 'F':
                        if ((String.Compare(field_name, 1, "romUserNames", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorFromUserNames;
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
                fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the TypeChoices class", ignore_extras);
                fieldGeneratorToUserWrittenName = new JSONHoldingStringGenerator("field \"ToUserWrittenName\" of the TypeChoices class");
                fieldGeneratorToUserSpokenName = new JSONHoldingStringGenerator("field \"ToUserSpokenName\" of the TypeChoices class");
                fieldGeneratorFromUserNames = new JSONHoldingStringArrayGenerator("field \"FromUserNames\" of the TypeChoices class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeChoices class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorContacts = new OneContactJSON.HoldingArrayGenerator("field \"Contacts\" of the TypeChoices class", false);
                fieldGeneratorToUserWrittenName = new JSONHoldingStringGenerator("field \"ToUserWrittenName\" of the TypeChoices class");
                fieldGeneratorToUserSpokenName = new JSONHoldingStringGenerator("field \"ToUserSpokenName\" of the TypeChoices class");
                fieldGeneratorFromUserNames = new JSONHoldingStringArrayGenerator("field \"FromUserNames\" of the TypeChoices class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeChoices class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorContacts.reset();
                fieldGeneratorToUserWrittenName.reset();
                fieldGeneratorToUserSpokenName.reset();
                fieldGeneratorFromUserNames.reset();
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
            protected override void handle_result(TypeChoicesJSON  result)
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
            public TypeChoicesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeChoicesJSON  result)
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
        protected virtual void handle_result(List<TypeChoicesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeChoicesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeChoicesJSON>();
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
        public List<TypeChoicesJSON> value;
      };
      };
    private bool flagHasChoices;
    private List< TypeChoicesJSON  > storeChoices;
    private bool flagHasContactDisambiguationInfo;
    private ContactDisambiguationInfoBaseJSON  storeContactDisambiguationInfo;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONChoices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Choices of WhichContactChoicesJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field Choices of WhichContactChoicesJSON has too few elements.");
        List< TypeChoicesJSON  > vector_Choices1 = new List< TypeChoicesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeChoicesJSON convert_classy = TypeChoicesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Choices1.Add(convert_classy);
          }
        Debug.Assert(vector_Choices1.Count >= 2);
        initChoices();
        for (int num3 = 0; num3 < vector_Choices1.Count; ++num3)
            appendChoices(vector_Choices1[num3]);
        for (int num1 = 0; num1 < vector_Choices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONContactDisambiguationInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ContactDisambiguationInfoBaseJSON convert_classy = ContactDisambiguationInfoBaseJSON.from_json(json_value, ignore_extras, true);
        setContactDisambiguationInfo(convert_classy);
      }


    public WhichContactChoicesJSON()
      {
        flagHasChoices = false;
        flagHasContactDisambiguationInfo = false;
        storeChoices = new List< TypeChoicesJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public TypeChoicesJSON   elementOfChoices(int element_num)
      {
        Debug.Assert(flagHasChoices);
        return storeChoices[element_num];
      }

    public List< TypeChoicesJSON  >  getChoices()
      {
        Debug.Assert(flagHasChoices);
        return storeChoices;
      }

    public bool  hasContactDisambiguationInfo()
      {
        return flagHasContactDisambiguationInfo;
      }

    public ContactDisambiguationInfoBaseJSON   getContactDisambiguationInfo()
      {
        Debug.Assert(flagHasContactDisambiguationInfo);
        return storeContactDisambiguationInfo;
      }


    public virtual int extraWhichContactChoicesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraWhichContactChoicesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraWhichContactChoicesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraWhichContactChoicesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void appendChoices(TypeChoicesJSON  to_append)
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
    public void setContactDisambiguationInfo(ContactDisambiguationInfoBaseJSON  new_value)
      {
        if (flagHasContactDisambiguationInfo)
          {
          }
        flagHasContactDisambiguationInfo = true;
        storeContactDisambiguationInfo = new_value;
      }
    public void unsetContactDisambiguationInfo()
      {
        if (flagHasContactDisambiguationInfo)
          {
          }
        flagHasContactDisambiguationInfo = false;
      }

    public virtual void extraWhichContactChoicesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraWhichContactChoicesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraWhichContactChoicesLookup(key);
        if (old_field == null)
          {
            extraWhichContactChoicesAppendPair(key, new_component);
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
            Debug.Assert(storeChoices.Count >= 2);
            handler.start_array();
            for (int num1 = 0; num1 < storeChoices.Count; ++num1)
              {
                if (partial_allowed)
                    storeChoices[num1].write_partial_as_json(handler);
                else
                    storeChoices[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasContactDisambiguationInfo)
          {
            handler.start_pair("ContactDisambiguationInfo");
            if (partial_allowed)
                storeContactDisambiguationInfo.write_partial_as_json(handler);
            else
                storeContactDisambiguationInfo.write_as_json(handler);
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
        return null;
      }

    public static WhichContactChoicesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WhichContactChoicesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WhichContactChoices", ignore_extras);
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
    public static WhichContactChoicesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WhichContactChoicesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        WhichContactChoicesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WhichContactChoices", ignore_extras);
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
    public static WhichContactChoicesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static WhichContactChoicesJSON from_text(string text, bool ignore_extras)
      {
        WhichContactChoicesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WhichContactChoices", ignore_extras);
            JSONParse.parse_json_value(text, "Text for WhichContactChoicesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static WhichContactChoicesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        WhichContactChoicesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type WhichContactChoices", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeChoicesJSON.HoldingArrayGenerator fieldGeneratorChoices;
        private ContactDisambiguationInfoBaseJSON.HoldingGenerator fieldGeneratorContactDisambiguationInfo;
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
            WhichContactChoicesJSON result = new WhichContactChoicesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraWhichContactChoicesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(WhichContactChoicesJSON result)
          {
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
            if (fieldGeneratorContactDisambiguationInfo.have_value)
              {
                result.setContactDisambiguationInfo(fieldGeneratorContactDisambiguationInfo.value);
                fieldGeneratorContactDisambiguationInfo.have_value = false;
              }
          }
        protected abstract void handle_result(WhichContactChoicesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
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
                        if ((String.Compare(field_name, 2, "ntactDisambiguationInfo", 0, 23, false) == 0) && (field_name.Length == 25))
                            return fieldGeneratorContactDisambiguationInfo;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorChoices = new TypeChoicesJSON.HoldingArrayGenerator("field \"Choices\" of the WhichContactChoices class", ignore_extras);
            fieldGeneratorContactDisambiguationInfo = new ContactDisambiguationInfoBaseJSON.HoldingGenerator("field \"ContactDisambiguationInfo\" of the WhichContactChoices class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the WhichContactChoices class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorChoices = new TypeChoicesJSON.HoldingArrayGenerator("field \"Choices\" of the WhichContactChoices class", false);
            fieldGeneratorContactDisambiguationInfo = new ContactDisambiguationInfoBaseJSON.HoldingGenerator("field \"ContactDisambiguationInfo\" of the WhichContactChoices class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the WhichContactChoices class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorChoices.reset();
            fieldGeneratorContactDisambiguationInfo.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorChoices.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorContactDisambiguationInfo.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorChoices.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorContactDisambiguationInfo.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(WhichContactChoicesJSON  result)
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
        public WhichContactChoicesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(WhichContactChoicesJSON  result)
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
    protected virtual void handle_result(List<WhichContactChoicesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<WhichContactChoicesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<WhichContactChoicesJSON>();
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
    public List<WhichContactChoicesJSON> value;
  };
  };
