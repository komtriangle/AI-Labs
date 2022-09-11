/* file "UniversalTranslatorSubstitutionListJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UniversalTranslatorSubstitutionListJSON : JSONBase
  {
    public class TypeValueJSON : JSONBase
      {
        public class TypeSubstitutionsJSON : JSONBase
          {
            private bool flagHasReplacementWord;
            private string storeReplacementWord;
            private bool flagHasTargets;
            private List< string > storeTargets;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONReplacementWord(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field ReplacementWord of TypeSubstitutionsJSON is not a string.");
                setReplacementWord(json_string.getData());
              }


            private void  fromJSONTargets(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONArrayValue json_array1 = json_value.array_value();
                if (json_array1 == null)
                    throw new Exception("The value for field Targets of TypeSubstitutionsJSON is not an array.");
                int count1 = json_array1.componentCount();
                List< string > vector_Targets1 = new List< string >(count1);
                for (int num1 = 0; num1 < count1; ++num1)
                  {
                    JSONStringValue json_string = json_array1.component(num1).string_value();
                    if (json_string == null)
                        throw new Exception("The value for an element of field Targets of TypeSubstitutionsJSON is not a string.");
                    vector_Targets1.Add(json_string.getData());
                  }
                initTargets();
                for (int num1 = 0; num1 < vector_Targets1.Count; ++num1)
                    appendTargets(vector_Targets1[num1]);
                for (int num1 = 0; num1 < vector_Targets1.Count; ++num1)
                  {
                  }
              }


            public TypeSubstitutionsJSON()
              {
                flagHasReplacementWord = false;
                flagHasTargets = false;
                storeTargets = new List< string >();
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasReplacementWord()
              {
                return flagHasReplacementWord;
              }

            public string  getReplacementWord()
              {
                Debug.Assert(flagHasReplacementWord);
                return storeReplacementWord;
              }

            public bool  hasTargets()
              {
                return flagHasTargets;
              }

            public int  countOfTargets()
              {
                Debug.Assert(flagHasTargets);
                return storeTargets.Count;
              }

            public string  elementOfTargets(int element_num)
              {
                Debug.Assert(flagHasTargets);
                return storeTargets[element_num];
              }

            public List< string >  getTargets()
              {
                Debug.Assert(flagHasTargets);
                return storeTargets;
              }


            public virtual int extraTypeSubstitutionsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeSubstitutionsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeSubstitutionsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeSubstitutionsLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setReplacementWord(string new_value)
              {
                flagHasReplacementWord = true;
                storeReplacementWord = new_value;
              }
            public void unsetReplacementWord()
              {
                flagHasReplacementWord = false;
              }
            public void initTargets()
              {
                flagHasTargets = true;
                storeTargets.Clear();
              }
            public void appendTargets(string to_append)
              {
                if (!flagHasTargets)
                  {
                    flagHasTargets = true;
                    storeTargets.Clear();
                  }
                Debug.Assert(flagHasTargets);
                storeTargets.Add(to_append);
              }
            public void unsetTargets()
              {
                flagHasTargets = false;
                storeTargets.Clear();
              }

            public virtual void extraTypeSubstitutionsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeSubstitutionsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeSubstitutionsLookup(key);
                if (old_field == null)
                  {
                    extraTypeSubstitutionsAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasReplacementWord);
                if (flagHasReplacementWord)
                  {
                    handler.start_pair("ReplacementWord");
                    handler.string_value(storeReplacementWord);
                  }
                Debug.Assert(partial_allowed || flagHasTargets);
                if (flagHasTargets)
                  {
                    handler.start_pair("Targets");
                    handler.start_array();
                    for (int num1 = 0; num1 < storeTargets.Count; ++num1)
                      {
                        handler.string_value(storeTargets[num1]);
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
                if (!(hasReplacementWord()))
                  {
                    return "When parsing the object for %what%, the \"ReplacementWord\" field was missing.";
                  }
                if (!(hasTargets()))
                  {
                    return "When parsing the object for %what%, the \"Targets\" field was missing.";
                  }
                return null;
              }

            public static TypeSubstitutionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeSubstitutionsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSubstitutions", ignore_extras);
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
            public static TypeSubstitutionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeSubstitutionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeSubstitutionsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSubstitutions", ignore_extras);
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
            public static TypeSubstitutionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeSubstitutionsJSON from_text(string text, bool ignore_extras)
              {
                TypeSubstitutionsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSubstitutions", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeSubstitutionsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeSubstitutionsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeSubstitutionsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeSubstitutions", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorReplacementWord;
                private JSONHoldingStringArrayGenerator fieldGeneratorTargets;
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
                    TypeSubstitutionsJSON result = new TypeSubstitutionsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeSubstitutionsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeSubstitutionsJSON result)
                  {
                    if (fieldGeneratorReplacementWord.have_value)
                      {
                        result.setReplacementWord(fieldGeneratorReplacementWord.value);
                        fieldGeneratorReplacementWord.have_value = false;
                      }
                    else if ((!(result.hasReplacementWord())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"ReplacementWord\" field was missing.");
                      }
                    if (fieldGeneratorTargets.have_value)
                      {
                        result.initTargets();
                        int count = fieldGeneratorTargets.value.Count;
                        for (int num = 0; num < count; ++num)
                          {
                            result.appendTargets(fieldGeneratorTargets.value[num]);
                          }
                        fieldGeneratorTargets.value.Clear();
                        fieldGeneratorTargets.have_value = false;
                      }
                    else if ((!(result.hasTargets())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Targets\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeSubstitutionsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'R':
                            if ((String.Compare(field_name, 1, "eplacementWord", 0, 14, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorReplacementWord;
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 1, "argets", 0, 6, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorTargets;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorReplacementWord = new JSONHoldingStringGenerator("field \"ReplacementWord\" of the TypeSubstitutions class");
                    fieldGeneratorTargets = new JSONHoldingStringArrayGenerator("field \"Targets\" of the TypeSubstitutions class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeSubstitutions class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorReplacementWord = new JSONHoldingStringGenerator("field \"ReplacementWord\" of the TypeSubstitutions class");
                    fieldGeneratorTargets = new JSONHoldingStringArrayGenerator("field \"Targets\" of the TypeSubstitutions class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeSubstitutions class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorReplacementWord.reset();
                    fieldGeneratorTargets.reset();
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
                protected override void handle_result(TypeSubstitutionsJSON  result)
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
                public TypeSubstitutionsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeSubstitutionsJSON  result)
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
            protected virtual void handle_result(List<TypeSubstitutionsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeSubstitutionsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeSubstitutionsJSON>();
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
            public List<TypeSubstitutionsJSON> value;
          };
          };
        private bool flagHasLanguageIETF;
        private string storeLanguageIETF;
        private bool flagHasSubstitutions;
        private List< TypeSubstitutionsJSON  > storeSubstitutions;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONLanguageIETF(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field LanguageIETF of TypeValueJSON is not a string.");
            setLanguageIETF(json_string.getData());
          }


        private void  fromJSONSubstitutions(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Substitutions of TypeValueJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeSubstitutionsJSON  > vector_Substitutions1 = new List< TypeSubstitutionsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeSubstitutionsJSON convert_classy = TypeSubstitutionsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Substitutions1.Add(convert_classy);
              }
            initSubstitutions();
            for (int num2 = 0; num2 < vector_Substitutions1.Count; ++num2)
                appendSubstitutions(vector_Substitutions1[num2]);
            for (int num1 = 0; num1 < vector_Substitutions1.Count; ++num1)
              {
              }
          }


        public TypeValueJSON()
          {
            flagHasLanguageIETF = false;
            flagHasSubstitutions = false;
            storeSubstitutions = new List< TypeSubstitutionsJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasLanguageIETF()
          {
            return flagHasLanguageIETF;
          }

        public string  getLanguageIETF()
          {
            Debug.Assert(flagHasLanguageIETF);
            return storeLanguageIETF;
          }

        public bool  hasSubstitutions()
          {
            return flagHasSubstitutions;
          }

        public int  countOfSubstitutions()
          {
            Debug.Assert(flagHasSubstitutions);
            return storeSubstitutions.Count;
          }

        public TypeSubstitutionsJSON   elementOfSubstitutions(int element_num)
          {
            Debug.Assert(flagHasSubstitutions);
            return storeSubstitutions[element_num];
          }

        public List< TypeSubstitutionsJSON  >  getSubstitutions()
          {
            Debug.Assert(flagHasSubstitutions);
            return storeSubstitutions;
          }


        public virtual int extraTypeValueComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeValueComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeValueComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeValueLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setLanguageIETF(string new_value)
          {
            flagHasLanguageIETF = true;
            storeLanguageIETF = new_value;
          }
        public void unsetLanguageIETF()
          {
            flagHasLanguageIETF = false;
          }
        public void initSubstitutions()
          {
            if (flagHasSubstitutions)
              {
                for (int num1 = 0; num1 < storeSubstitutions.Count; ++num1)
                  {
                  }
              }
            flagHasSubstitutions = true;
            storeSubstitutions.Clear();
          }
        public void appendSubstitutions(TypeSubstitutionsJSON  to_append)
          {
            if (!flagHasSubstitutions)
              {
                flagHasSubstitutions = true;
                storeSubstitutions.Clear();
              }
            Debug.Assert(flagHasSubstitutions);
            storeSubstitutions.Add(to_append);
          }
        public void unsetSubstitutions()
          {
            if (flagHasSubstitutions)
              {
                for (int num2 = 0; num2 < storeSubstitutions.Count; ++num2)
                  {
                  }
              }
            flagHasSubstitutions = false;
            storeSubstitutions.Clear();
          }

        public virtual void extraTypeValueAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeValueSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeValueLookup(key);
            if (old_field == null)
              {
                extraTypeValueAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasLanguageIETF);
            if (flagHasLanguageIETF)
              {
                handler.start_pair("LanguageIETF");
                handler.string_value(storeLanguageIETF);
              }
            Debug.Assert(partial_allowed || flagHasSubstitutions);
            if (flagHasSubstitutions)
              {
                handler.start_pair("Substitutions");
                handler.start_array();
                for (int num1 = 0; num1 < storeSubstitutions.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeSubstitutions[num1].write_partial_as_json(handler);
                    else
                        storeSubstitutions[num1].write_as_json(handler);
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
            if (!(hasLanguageIETF()))
              {
                return "When parsing the object for %what%, the \"LanguageIETF\" field was missing.";
              }
            if (!(hasSubstitutions()))
              {
                return "When parsing the object for %what%, the \"Substitutions\" field was missing.";
              }
            return null;
          }

        public static TypeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
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
        public static TypeValueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
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
        public static TypeValueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeValueJSON from_text(string text, bool ignore_extras)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeValueJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeValueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeValueJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeValue", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorLanguageIETF;
            private TypeSubstitutionsJSON.HoldingArrayGenerator fieldGeneratorSubstitutions;
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
                TypeValueJSON result = new TypeValueJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeValueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeValueJSON result)
              {
                if (fieldGeneratorLanguageIETF.have_value)
                  {
                    result.setLanguageIETF(fieldGeneratorLanguageIETF.value);
                    fieldGeneratorLanguageIETF.have_value = false;
                  }
                else if ((!(result.hasLanguageIETF())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"LanguageIETF\" field was missing.");
                  }
                if (fieldGeneratorSubstitutions.have_value)
                  {
                    result.initSubstitutions();
                    int count = fieldGeneratorSubstitutions.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendSubstitutions(fieldGeneratorSubstitutions.value[num]);
                      }
                    fieldGeneratorSubstitutions.value.Clear();
                    fieldGeneratorSubstitutions.have_value = false;
                  }
                else if ((!(result.hasSubstitutions())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Substitutions\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeValueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "anguageIETF", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorLanguageIETF;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "ubstitutions", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorSubstitutions;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorLanguageIETF = new JSONHoldingStringGenerator("field \"LanguageIETF\" of the TypeValue class");
                fieldGeneratorSubstitutions = new TypeSubstitutionsJSON.HoldingArrayGenerator("field \"Substitutions\" of the TypeValue class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorLanguageIETF = new JSONHoldingStringGenerator("field \"LanguageIETF\" of the TypeValue class");
                fieldGeneratorSubstitutions = new TypeSubstitutionsJSON.HoldingArrayGenerator("field \"Substitutions\" of the TypeValue class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorLanguageIETF.reset();
                fieldGeneratorSubstitutions.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorSubstitutions.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorSubstitutions.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeValueJSON  result)
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
            public TypeValueJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeValueJSON  result)
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
        protected virtual void handle_result(List<TypeValueJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeValueJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeValueJSON>();
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
        public List<TypeValueJSON> value;
      };
      };
    private bool flagHasValue;
    private List< TypeValueJSON  > storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Value of UniversalTranslatorSubstitutionListJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Value of UniversalTranslatorSubstitutionListJSON has too few elements.");
        List< TypeValueJSON  > vector_Value1 = new List< TypeValueJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeValueJSON convert_classy = TypeValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Value1.Add(convert_classy);
          }
        Debug.Assert(vector_Value1.Count >= 1);
        initValue();
        for (int num3 = 0; num3 < vector_Value1.Count; ++num3)
            appendValue(vector_Value1[num3]);
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
          {
          }
      }


    public UniversalTranslatorSubstitutionListJSON()
      {
        flagHasValue = false;
        storeValue = new List< TypeValueJSON  >();
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public int  countOfValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue.Count;
      }

    public TypeValueJSON   elementOfValue(int element_num)
      {
        Debug.Assert(flagHasValue);
        return storeValue[element_num];
      }

    public List< TypeValueJSON  >  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }



    public void initValue()
      {
        if (flagHasValue)
          {
            for (int num3 = 0; num3 < storeValue.Count; ++num3)
              {
              }
          }
        flagHasValue = true;
        storeValue.Clear();
      }
    public void appendValue(TypeValueJSON  to_append)
      {
        if (!flagHasValue)
          {
            flagHasValue = true;
            storeValue.Clear();
          }
        Debug.Assert(flagHasValue);
        storeValue.Add(to_append);
      }
    public void unsetValue()
      {
        if (flagHasValue)
          {
            for (int num4 = 0; num4 < storeValue.Count; ++num4)
              {
              }
          }
        flagHasValue = false;
        storeValue.Clear();
      }


    public override void write_as_json(JSONHandler handler)
      {
        Debug.Assert(storeValue.Count >= 1);
        handler.start_array();
        for (int num1 = 0; num1 < storeValue.Count; ++num1)
          {
            storeValue[num1].write_as_json(handler);
          }
        handler.finish_array();
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        Debug.Assert(storeValue.Count >= 1);
        handler.start_array();
        for (int num2 = 0; num2 < storeValue.Count; ++num2)
          {
            storeValue[num2].write_partial_as_json(handler);
          }
        handler.finish_array();
      }

    public static UniversalTranslatorSubstitutionListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UniversalTranslatorSubstitutionListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UniversalTranslatorSubstitutionList", ignore_extras);
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
    public static UniversalTranslatorSubstitutionListJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UniversalTranslatorSubstitutionListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UniversalTranslatorSubstitutionListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UniversalTranslatorSubstitutionList", ignore_extras);
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
    public static UniversalTranslatorSubstitutionListJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UniversalTranslatorSubstitutionListJSON from_text(string text, bool ignore_extras)
      {
        UniversalTranslatorSubstitutionListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UniversalTranslatorSubstitutionList", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UniversalTranslatorSubstitutionListJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UniversalTranslatorSubstitutionListJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UniversalTranslatorSubstitutionListJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UniversalTranslatorSubstitutionList", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : TypeValueJSON.HoldingArrayGenerator
      {
        protected void finish()
          {
            Debug.Assert(have_value);
            UniversalTranslatorSubstitutionListJSON result = new UniversalTranslatorSubstitutionListJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(UniversalTranslatorSubstitutionListJSON new_result);
        public Generator(bool ignore_extras) : base("Type UniversalTranslatorSubstitutionList", ignore_extras)
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UniversalTranslatorSubstitutionListJSON  result)
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
        public UniversalTranslatorSubstitutionListJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UniversalTranslatorSubstitutionListJSON  result)
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
    protected virtual void handle_result(List<UniversalTranslatorSubstitutionListJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UniversalTranslatorSubstitutionListJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UniversalTranslatorSubstitutionListJSON>();
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
    public List<UniversalTranslatorSubstitutionListJSON> value;
  };
  };
