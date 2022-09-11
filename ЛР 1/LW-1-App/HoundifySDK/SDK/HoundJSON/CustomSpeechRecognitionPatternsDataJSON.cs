/* file "CustomSpeechRecognitionPatternsDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class CustomSpeechRecognitionPatternsDataJSON : JSONBase
  {
    public class TypeEntitiesJSON : JSONBase
      {
        public class TypeValuesJSON : JSONBase
          {
            private bool flagHasPhrase;
            private string storePhrase;
            private bool flagHasWeight;
            private BigInteger storeWeight;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONPhrase(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Phrase of TypeValuesJSON is not a string.");
                setPhrase(json_string.getData());
              }


            private void  fromJSONWeight(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_value.rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for field Weight of TypeValuesJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for field Weight of TypeValuesJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                setWeight(extracted_integer);
              }


            public TypeValuesJSON()
              {
                flagHasPhrase = false;
                flagHasWeight = false;
                storeWeight = 1;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasPhrase()
              {
                return flagHasPhrase;
              }

            public string  getPhrase()
              {
                Debug.Assert(flagHasPhrase);
                return storePhrase;
              }

            public bool  hasWeight()
              {
                return flagHasWeight;
              }

            public BigInteger  getWeight()
              {
                return storeWeight;
              }


            public virtual int extraTypeValuesComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeValuesComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeValuesComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeValuesLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setPhrase(string new_value)
              {
                flagHasPhrase = true;
                storePhrase = new_value;
              }
            public void unsetPhrase()
              {
                flagHasPhrase = false;
              }
            public void setWeight(BigInteger new_value)
              {
                flagHasWeight = true;
                if (new_value < 0)
                    throw new Exception("The value for field Weight of TypeValuesJSON is less than the lower bound (0) for that field.");
                storeWeight = new_value;
              }
            public void unsetWeight()
              {
                flagHasWeight = false;
              }

            public virtual void extraTypeValuesAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeValuesSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeValuesLookup(key);
                if (old_field == null)
                  {
                    extraTypeValuesAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasPhrase);
                if (flagHasPhrase)
                  {
                    handler.start_pair("Phrase");
                    handler.string_value(storePhrase);
                  }
                if (flagHasWeight)
                  {
                    handler.start_pair("Weight");
                    handler.number_value(storeWeight);
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
                if (!(hasPhrase()))
                  {
                    return "When parsing the object for %what%, the \"Phrase\" field was missing.";
                  }
                return null;
              }

            public static TypeValuesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeValuesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeValues", ignore_extras);
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
            public static TypeValuesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeValuesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeValuesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeValues", ignore_extras);
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
            public static TypeValuesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeValuesJSON from_text(string text, bool ignore_extras)
              {
                TypeValuesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeValues", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeValuesJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeValuesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeValuesJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeValues", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorPhrase;
            private class FieldHoldingGeneratorWeight : JSONHoldingIntegerLowerBoundOnlyGenerator
                  {
                    public FieldHoldingGeneratorWeight(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
            private class FieldHoldingArrayGeneratorWeight : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
                  {
                    public FieldHoldingArrayGeneratorWeight(String what) : base(what, (BigInteger)(0))
                      {
                      }
                  };
                private FieldHoldingGeneratorWeight fieldGeneratorWeight;
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
                    TypeValuesJSON result = new TypeValuesJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeValuesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeValuesJSON result)
                  {
                    if (fieldGeneratorPhrase.have_value)
                      {
                        result.setPhrase(fieldGeneratorPhrase.value);
                        fieldGeneratorPhrase.have_value = false;
                      }
                    else if ((!(result.hasPhrase())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Phrase\" field was missing.");
                      }
                    if (fieldGeneratorWeight.have_value)
                      {
                        result.setWeight(fieldGeneratorWeight.value);
                        fieldGeneratorWeight.have_value = false;
                      }
                  }
                protected abstract void handle_result(TypeValuesJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'P':
                            if ((String.Compare(field_name, 1, "hrase", 0, 5, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorPhrase;
                            break;
                        case 'W':
                            if ((String.Compare(field_name, 1, "eight", 0, 5, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorWeight;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorPhrase = new JSONHoldingStringGenerator("field \"Phrase\" of the TypeValues class");
                    fieldGeneratorWeight = new FieldHoldingGeneratorWeight("field \"Weight\" of the TypeValues class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeValues class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorPhrase = new JSONHoldingStringGenerator("field \"Phrase\" of the TypeValues class");
                    fieldGeneratorWeight = new FieldHoldingGeneratorWeight("field \"Weight\" of the TypeValues class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeValues class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorPhrase.reset();
                    fieldGeneratorWeight.reset();
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
                protected override void handle_result(TypeValuesJSON  result)
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
                public TypeValuesJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeValuesJSON  result)
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
            protected virtual void handle_result(List<TypeValuesJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeValuesJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeValuesJSON>();
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
            public List<TypeValuesJSON> value;
          };
          };
        private bool flagHasEntity;
        private string storeEntity;
        private bool flagHasValues;
        private List< TypeValuesJSON  > storeValues;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONEntity(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Entity of TypeEntitiesJSON is not a string.");
            setEntity(json_string.getData());
          }


        private void  fromJSONValues(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Values of TypeEntitiesJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeValuesJSON  > vector_Values1 = new List< TypeValuesJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeValuesJSON convert_classy = TypeValuesJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Values1.Add(convert_classy);
              }
            initValues();
            for (int num1 = 0; num1 < vector_Values1.Count; ++num1)
                appendValues(vector_Values1[num1]);
            for (int num1 = 0; num1 < vector_Values1.Count; ++num1)
              {
              }
          }


        public TypeEntitiesJSON()
          {
            flagHasEntity = false;
            flagHasValues = false;
            storeValues = new List< TypeValuesJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasEntity()
          {
            return flagHasEntity;
          }

        public string  getEntity()
          {
            Debug.Assert(flagHasEntity);
            return storeEntity;
          }

        public bool  hasValues()
          {
            return flagHasValues;
          }

        public int  countOfValues()
          {
            Debug.Assert(flagHasValues);
            return storeValues.Count;
          }

        public TypeValuesJSON   elementOfValues(int element_num)
          {
            Debug.Assert(flagHasValues);
            return storeValues[element_num];
          }

        public List< TypeValuesJSON  >  getValues()
          {
            Debug.Assert(flagHasValues);
            return storeValues;
          }


        public virtual int extraTypeEntitiesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeEntitiesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeEntitiesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeEntitiesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setEntity(string new_value)
          {
            flagHasEntity = true;
            storeEntity = new_value;
          }
        public void unsetEntity()
          {
            flagHasEntity = false;
          }
        public void initValues()
          {
            if (flagHasValues)
              {
                for (int num1 = 0; num1 < storeValues.Count; ++num1)
                  {
                  }
              }
            flagHasValues = true;
            storeValues.Clear();
          }
        public void appendValues(TypeValuesJSON  to_append)
          {
            if (!flagHasValues)
              {
                flagHasValues = true;
                storeValues.Clear();
              }
            Debug.Assert(flagHasValues);
            storeValues.Add(to_append);
          }
        public void unsetValues()
          {
            if (flagHasValues)
              {
                for (int num2 = 0; num2 < storeValues.Count; ++num2)
                  {
                  }
              }
            flagHasValues = false;
            storeValues.Clear();
          }

        public virtual void extraTypeEntitiesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeEntitiesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeEntitiesLookup(key);
            if (old_field == null)
              {
                extraTypeEntitiesAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasEntity);
            if (flagHasEntity)
              {
                handler.start_pair("Entity");
                handler.string_value(storeEntity);
              }
            Debug.Assert(partial_allowed || flagHasValues);
            if (flagHasValues)
              {
                handler.start_pair("Values");
                handler.start_array();
                for (int num1 = 0; num1 < storeValues.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeValues[num1].write_partial_as_json(handler);
                    else
                        storeValues[num1].write_as_json(handler);
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
            if (!(hasEntity()))
              {
                return "When parsing the object for %what%, the \"Entity\" field was missing.";
              }
            if (!(hasValues()))
              {
                return "When parsing the object for %what%, the \"Values\" field was missing.";
              }
            return null;
          }

        public static TypeEntitiesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEntitiesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEntities", ignore_extras);
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
        public static TypeEntitiesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEntitiesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeEntitiesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEntities", ignore_extras);
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
        public static TypeEntitiesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeEntitiesJSON from_text(string text, bool ignore_extras)
          {
            TypeEntitiesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEntities", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeEntitiesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeEntitiesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeEntitiesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeEntities", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorEntity;
            private TypeValuesJSON.HoldingArrayGenerator fieldGeneratorValues;
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
                TypeEntitiesJSON result = new TypeEntitiesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeEntitiesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeEntitiesJSON result)
              {
                if (fieldGeneratorEntity.have_value)
                  {
                    result.setEntity(fieldGeneratorEntity.value);
                    fieldGeneratorEntity.have_value = false;
                  }
                else if ((!(result.hasEntity())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Entity\" field was missing.");
                  }
                if (fieldGeneratorValues.have_value)
                  {
                    result.initValues();
                    int count = fieldGeneratorValues.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendValues(fieldGeneratorValues.value[num]);
                      }
                    fieldGeneratorValues.value.Clear();
                    fieldGeneratorValues.have_value = false;
                  }
                else if ((!(result.hasValues())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Values\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeEntitiesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'E':
                        if ((String.Compare(field_name, 1, "ntity", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorEntity;
                        break;
                    case 'V':
                        if ((String.Compare(field_name, 1, "alues", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorValues;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorEntity = new JSONHoldingStringGenerator("field \"Entity\" of the TypeEntities class");
                fieldGeneratorValues = new TypeValuesJSON.HoldingArrayGenerator("field \"Values\" of the TypeEntities class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeEntities class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorEntity = new JSONHoldingStringGenerator("field \"Entity\" of the TypeEntities class");
                fieldGeneratorValues = new TypeValuesJSON.HoldingArrayGenerator("field \"Values\" of the TypeEntities class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeEntities class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorEntity.reset();
                fieldGeneratorValues.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorValues.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorValues.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeEntitiesJSON  result)
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
            public TypeEntitiesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeEntitiesJSON  result)
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
        protected virtual void handle_result(List<TypeEntitiesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeEntitiesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeEntitiesJSON>();
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
        public List<TypeEntitiesJSON> value;
      };
      };
    public class TypePronunciationsJSON : JSONBase
      {
        private bool flagHasWord;
        private string storeWord;
        private bool flagHasXSAMPA;
        private string storeXSAMPA;
        private bool flagHasSoundsLike;
        private string storeSoundsLike;
        private bool flagHasWeight;
        private double storeWeight;
        private string textStoreWeight;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONWord(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Word of TypePronunciationsJSON is not a string.");
            setWord(json_string.getData());
          }


        private void  fromJSONXSAMPA(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field XSAMPA of TypePronunciationsJSON is not a string.");
            setXSAMPA(json_string.getData());
          }


        private void  fromJSONSoundsLike(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SoundsLike of TypePronunciationsJSON is not a string.");
            setSoundsLike(json_string.getData());
          }


        private void  fromJSONWeight(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONRationalValue json_rational = json_value.rational_value();
            string the_rational_text;
            if (json_rational != null)
              {
                the_rational_text = json_rational.getText();
              }
            else
              {
                JSONIntegerValue json_integer = json_value.integer_value();
                if (json_integer != null)
                  {
                    the_rational_text = json_integer.getText();
                  }
                else
                  {
                    throw new Exception("The value for field Weight of TypePronunciationsJSON is not a number.");
                  }
              }
            setWeightText(the_rational_text);
          }


        public TypePronunciationsJSON()
          {
            flagHasWord = false;
            flagHasXSAMPA = false;
            flagHasSoundsLike = false;
            flagHasWeight = false;
            storeWeight = 1;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasWord()
          {
            return flagHasWord;
          }

        public string  getWord()
          {
            Debug.Assert(flagHasWord);
            return storeWord;
          }

        public bool  hasXSAMPA()
          {
            return flagHasXSAMPA;
          }

        public string  getXSAMPA()
          {
            Debug.Assert(flagHasXSAMPA);
            return storeXSAMPA;
          }

        public bool  hasSoundsLike()
          {
            return flagHasSoundsLike;
          }

        public string  getSoundsLike()
          {
            Debug.Assert(flagHasSoundsLike);
            return storeSoundsLike;
          }

        public bool  hasWeight()
          {
            return flagHasWeight;
          }

        public double  getWeight()
          {
            if (textStoreWeight != "")
              {
                return Double.Parse(textStoreWeight);
              }
            return storeWeight;
          }

        public string  getWeightAsText()
          {
            if (textStoreWeight == "")
              {
                return Convert.ToString(storeWeight);
              }
            else
              {
                return (textStoreWeight);
              }
          }


        public virtual int extraTypePronunciationsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePronunciationsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePronunciationsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePronunciationsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setWord(string new_value)
          {
            flagHasWord = true;
            storeWord = new_value;
          }
        public void unsetWord()
          {
            flagHasWord = false;
          }
        public void setXSAMPA(string new_value)
          {
            flagHasXSAMPA = true;
            storeXSAMPA = new_value;
          }
        public void unsetXSAMPA()
          {
            flagHasXSAMPA = false;
          }
        public void setSoundsLike(string new_value)
          {
            flagHasSoundsLike = true;
            storeSoundsLike = new_value;
          }
        public void unsetSoundsLike()
          {
            flagHasSoundsLike = false;
          }
        public void setWeight(double new_value)
          {
            flagHasWeight = true;
            if (new_value < 0)
                throw new Exception("The value for field Weight of TypePronunciationsJSON is less than the lower bound (0) for that field.");
            storeWeight = new_value;
            textStoreWeight = "";
          }
        public void setWeightText(string new_value)
          {
            flagHasWeight = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Weight of TypePronunciationsJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field Weight of TypePronunciationsJSON is less than the lower bound (0) for that field.");
            textStoreWeight = new_value;
          }
        public void unsetWeight()
          {
            flagHasWeight = false;
          }

        public virtual void extraTypePronunciationsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePronunciationsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePronunciationsLookup(key);
            if (old_field == null)
              {
                extraTypePronunciationsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasWord);
            if (flagHasWord)
              {
                handler.start_pair("Word");
                handler.string_value(storeWord);
              }
            if (flagHasXSAMPA)
              {
                handler.start_pair("XSAMPA");
                handler.string_value(storeXSAMPA);
              }
            if (flagHasSoundsLike)
              {
                handler.start_pair("SoundsLike");
                handler.string_value(storeSoundsLike);
              }
            if (flagHasWeight)
              {
                handler.start_pair("Weight");
                if (textStoreWeight != "")
                    handler.number_value(textStoreWeight);
                else if (((double)(long)storeWeight) == storeWeight)
                    handler.number_value((long)storeWeight);
                else
                    handler.number_value(storeWeight);
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
            if (!(hasWord()))
              {
                return "When parsing the object for %what%, the \"Word\" field was missing.";
              }
            return null;
          }

        public static TypePronunciationsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePronunciationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePronunciations", ignore_extras);
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
        public static TypePronunciationsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePronunciationsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePronunciationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePronunciations", ignore_extras);
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
        public static TypePronunciationsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePronunciationsJSON from_text(string text, bool ignore_extras)
          {
            TypePronunciationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePronunciations", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePronunciationsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePronunciationsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePronunciationsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePronunciations", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private JSONHoldingStringGenerator fieldGeneratorWord;
            private JSONHoldingStringGenerator fieldGeneratorXSAMPA;
            private JSONHoldingStringGenerator fieldGeneratorSoundsLike;
            private JSONHoldingNumberTextGenerator fieldGeneratorWeight;
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
                TypePronunciationsJSON result = new TypePronunciationsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePronunciationsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePronunciationsJSON result)
              {
                if (fieldGeneratorWord.have_value)
                  {
                    result.setWord(fieldGeneratorWord.value);
                    fieldGeneratorWord.have_value = false;
                  }
                else if ((!(result.hasWord())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Word\" field was missing.");
                  }
                if (fieldGeneratorXSAMPA.have_value)
                  {
                    result.setXSAMPA(fieldGeneratorXSAMPA.value);
                    fieldGeneratorXSAMPA.have_value = false;
                  }
                if (fieldGeneratorSoundsLike.have_value)
                  {
                    result.setSoundsLike(fieldGeneratorSoundsLike.value);
                    fieldGeneratorSoundsLike.have_value = false;
                  }
                if (fieldGeneratorWeight.have_value)
                  {
                    result.setWeightText(fieldGeneratorWeight.value);
                    fieldGeneratorWeight.have_value = false;
                  }
              }
            protected abstract void handle_result(TypePronunciationsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'S':
                        if ((String.Compare(field_name, 1, "oundsLike", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorSoundsLike;
                        break;
                    case 'W':
                        switch (field_name[1])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 2, "ight", 0, 4, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorWeight;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 2, "rd", 0, 2, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorWord;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'X':
                        if ((String.Compare(field_name, 1, "SAMPA", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorXSAMPA;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorWord = new JSONHoldingStringGenerator("field \"Word\" of the TypePronunciations class");
                fieldGeneratorXSAMPA = new JSONHoldingStringGenerator("field \"XSAMPA\" of the TypePronunciations class");
                fieldGeneratorSoundsLike = new JSONHoldingStringGenerator("field \"SoundsLike\" of the TypePronunciations class");
                fieldGeneratorWeight = new JSONHoldingNumberTextGenerator("field \"Weight\" of the TypePronunciations class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePronunciations class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorWord = new JSONHoldingStringGenerator("field \"Word\" of the TypePronunciations class");
                fieldGeneratorXSAMPA = new JSONHoldingStringGenerator("field \"XSAMPA\" of the TypePronunciations class");
                fieldGeneratorSoundsLike = new JSONHoldingStringGenerator("field \"SoundsLike\" of the TypePronunciations class");
                fieldGeneratorWeight = new JSONHoldingNumberTextGenerator("field \"Weight\" of the TypePronunciations class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePronunciations class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorWord.reset();
                fieldGeneratorXSAMPA.reset();
                fieldGeneratorSoundsLike.reset();
                fieldGeneratorWeight.reset();
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
            protected override void handle_result(TypePronunciationsJSON  result)
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
            public TypePronunciationsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePronunciationsJSON  result)
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
        protected virtual void handle_result(List<TypePronunciationsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePronunciationsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePronunciationsJSON>();
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
        public List<TypePronunciationsJSON> value;
      };
      };
    private bool flagHasPatternGroup;
    private string storePatternGroup;
    private bool flagHasIsGlobal;
    private bool storeIsGlobal;
    private bool flagHasEntities;
    private List< TypeEntitiesJSON  > storeEntities;
    private bool flagHasContexts;
    private List< string > storeContexts;
    private bool flagHasPronunciations;
    private List< TypePronunciationsJSON  > storePronunciations;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPatternGroup(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PatternGroup of CustomSpeechRecognitionPatternsDataJSON is not a string.");
        setPatternGroup(json_string.getData());
      }


    private void  fromJSONIsGlobal(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field IsGlobal of CustomSpeechRecognitionPatternsDataJSON is not true for false.");
              }
          }
        setIsGlobal(the_bool);
      }


    private void  fromJSONEntities(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Entities of CustomSpeechRecognitionPatternsDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeEntitiesJSON  > vector_Entities1 = new List< TypeEntitiesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeEntitiesJSON convert_classy = TypeEntitiesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Entities1.Add(convert_classy);
          }
        initEntities();
        for (int num2 = 0; num2 < vector_Entities1.Count; ++num2)
            appendEntities(vector_Entities1[num2]);
        for (int num1 = 0; num1 < vector_Entities1.Count; ++num1)
          {
          }
      }


    private void  fromJSONContexts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Contexts of CustomSpeechRecognitionPatternsDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Contexts1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Contexts of CustomSpeechRecognitionPatternsDataJSON is not a string.");
            vector_Contexts1.Add(json_string.getData());
          }
        initContexts();
        for (int num3 = 0; num3 < vector_Contexts1.Count; ++num3)
            appendContexts(vector_Contexts1[num3]);
        for (int num1 = 0; num1 < vector_Contexts1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPronunciations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Pronunciations of CustomSpeechRecognitionPatternsDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypePronunciationsJSON  > vector_Pronunciations1 = new List< TypePronunciationsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypePronunciationsJSON convert_classy = TypePronunciationsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Pronunciations1.Add(convert_classy);
          }
        initPronunciations();
        for (int num4 = 0; num4 < vector_Pronunciations1.Count; ++num4)
            appendPronunciations(vector_Pronunciations1[num4]);
        for (int num1 = 0; num1 < vector_Pronunciations1.Count; ++num1)
          {
          }
      }


    public CustomSpeechRecognitionPatternsDataJSON()
      {
        flagHasPatternGroup = false;
        flagHasIsGlobal = false;
        flagHasEntities = false;
        flagHasContexts = false;
        flagHasPronunciations = false;
        storeEntities = new List< TypeEntitiesJSON  >();
        storeContexts = new List< string >();
        storePronunciations = new List< TypePronunciationsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPatternGroup()
      {
        return flagHasPatternGroup;
      }

    public string  getPatternGroup()
      {
        Debug.Assert(flagHasPatternGroup);
        return storePatternGroup;
      }

    public bool  hasIsGlobal()
      {
        return flagHasIsGlobal;
      }

    public bool  getIsGlobal()
      {
        Debug.Assert(flagHasIsGlobal);
        return storeIsGlobal;
      }

    public bool  hasEntities()
      {
        return flagHasEntities;
      }

    public int  countOfEntities()
      {
        Debug.Assert(flagHasEntities);
        return storeEntities.Count;
      }

    public TypeEntitiesJSON   elementOfEntities(int element_num)
      {
        Debug.Assert(flagHasEntities);
        return storeEntities[element_num];
      }

    public List< TypeEntitiesJSON  >  getEntities()
      {
        Debug.Assert(flagHasEntities);
        return storeEntities;
      }

    public bool  hasContexts()
      {
        return flagHasContexts;
      }

    public int  countOfContexts()
      {
        Debug.Assert(flagHasContexts);
        return storeContexts.Count;
      }

    public string  elementOfContexts(int element_num)
      {
        Debug.Assert(flagHasContexts);
        return storeContexts[element_num];
      }

    public List< string >  getContexts()
      {
        Debug.Assert(flagHasContexts);
        return storeContexts;
      }

    public bool  hasPronunciations()
      {
        return flagHasPronunciations;
      }

    public int  countOfPronunciations()
      {
        Debug.Assert(flagHasPronunciations);
        return storePronunciations.Count;
      }

    public TypePronunciationsJSON   elementOfPronunciations(int element_num)
      {
        Debug.Assert(flagHasPronunciations);
        return storePronunciations[element_num];
      }

    public List< TypePronunciationsJSON  >  getPronunciations()
      {
        Debug.Assert(flagHasPronunciations);
        return storePronunciations;
      }


    public virtual int extraCustomSpeechRecognitionPatternsDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCustomSpeechRecognitionPatternsDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCustomSpeechRecognitionPatternsDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCustomSpeechRecognitionPatternsDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPatternGroup(string new_value)
      {
        flagHasPatternGroup = true;
        storePatternGroup = new_value;
      }
    public void unsetPatternGroup()
      {
        flagHasPatternGroup = false;
      }
    public void setIsGlobal(bool new_value)
      {
        flagHasIsGlobal = true;
        storeIsGlobal = new_value;
      }
    public void unsetIsGlobal()
      {
        flagHasIsGlobal = false;
      }
    public void initEntities()
      {
        if (flagHasEntities)
          {
            for (int num3 = 0; num3 < storeEntities.Count; ++num3)
              {
              }
          }
        flagHasEntities = true;
        storeEntities.Clear();
      }
    public void appendEntities(TypeEntitiesJSON  to_append)
      {
        if (!flagHasEntities)
          {
            flagHasEntities = true;
            storeEntities.Clear();
          }
        Debug.Assert(flagHasEntities);
        storeEntities.Add(to_append);
      }
    public void unsetEntities()
      {
        if (flagHasEntities)
          {
            for (int num4 = 0; num4 < storeEntities.Count; ++num4)
              {
              }
          }
        flagHasEntities = false;
        storeEntities.Clear();
      }
    public void initContexts()
      {
        flagHasContexts = true;
        storeContexts.Clear();
      }
    public void appendContexts(string to_append)
      {
        if (!flagHasContexts)
          {
            flagHasContexts = true;
            storeContexts.Clear();
          }
        Debug.Assert(flagHasContexts);
        storeContexts.Add(to_append);
      }
    public void unsetContexts()
      {
        flagHasContexts = false;
        storeContexts.Clear();
      }
    public void initPronunciations()
      {
        if (flagHasPronunciations)
          {
            for (int num5 = 0; num5 < storePronunciations.Count; ++num5)
              {
              }
          }
        flagHasPronunciations = true;
        storePronunciations.Clear();
      }
    public void appendPronunciations(TypePronunciationsJSON  to_append)
      {
        if (!flagHasPronunciations)
          {
            flagHasPronunciations = true;
            storePronunciations.Clear();
          }
        Debug.Assert(flagHasPronunciations);
        storePronunciations.Add(to_append);
      }
    public void unsetPronunciations()
      {
        if (flagHasPronunciations)
          {
            for (int num6 = 0; num6 < storePronunciations.Count; ++num6)
              {
              }
          }
        flagHasPronunciations = false;
        storePronunciations.Clear();
      }

    public virtual void extraCustomSpeechRecognitionPatternsDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCustomSpeechRecognitionPatternsDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCustomSpeechRecognitionPatternsDataLookup(key);
        if (old_field == null)
          {
            extraCustomSpeechRecognitionPatternsDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPatternGroup);
        if (flagHasPatternGroup)
          {
            handler.start_pair("PatternGroup");
            handler.string_value(storePatternGroup);
          }
        Debug.Assert(partial_allowed || flagHasIsGlobal);
        if (flagHasIsGlobal)
          {
            handler.start_pair("IsGlobal");
            handler.boolean_value(storeIsGlobal);
          }
        if (flagHasEntities)
          {
            handler.start_pair("Entities");
            handler.start_array();
            for (int num1 = 0; num1 < storeEntities.Count; ++num1)
              {
                if (partial_allowed)
                    storeEntities[num1].write_partial_as_json(handler);
                else
                    storeEntities[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasContexts)
          {
            handler.start_pair("Contexts");
            handler.start_array();
            for (int num2 = 0; num2 < storeContexts.Count; ++num2)
              {
                handler.string_value(storeContexts[num2]);
              }
            handler.finish_array();
          }
        if (flagHasPronunciations)
          {
            handler.start_pair("Pronunciations");
            handler.start_array();
            for (int num3 = 0; num3 < storePronunciations.Count; ++num3)
              {
                if (partial_allowed)
                    storePronunciations[num3].write_partial_as_json(handler);
                else
                    storePronunciations[num3].write_as_json(handler);
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
        if (!(hasPatternGroup()))
          {
            return "When parsing the object for %what%, the \"PatternGroup\" field was missing.";
          }
        if (!(hasIsGlobal()))
          {
            return "When parsing the object for %what%, the \"IsGlobal\" field was missing.";
          }
        return null;
      }

    public static CustomSpeechRecognitionPatternsDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CustomSpeechRecognitionPatternsDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomSpeechRecognitionPatternsData", ignore_extras);
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
    public static CustomSpeechRecognitionPatternsDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CustomSpeechRecognitionPatternsDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CustomSpeechRecognitionPatternsDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomSpeechRecognitionPatternsData", ignore_extras);
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
    public static CustomSpeechRecognitionPatternsDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CustomSpeechRecognitionPatternsDataJSON from_text(string text, bool ignore_extras)
      {
        CustomSpeechRecognitionPatternsDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomSpeechRecognitionPatternsData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CustomSpeechRecognitionPatternsDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CustomSpeechRecognitionPatternsDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CustomSpeechRecognitionPatternsDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CustomSpeechRecognitionPatternsData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorPatternGroup;
        private JSONHoldingBooleanGenerator fieldGeneratorIsGlobal;
        private TypeEntitiesJSON.HoldingArrayGenerator fieldGeneratorEntities;
        private JSONHoldingStringArrayGenerator fieldGeneratorContexts;
        private TypePronunciationsJSON.HoldingArrayGenerator fieldGeneratorPronunciations;
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
            CustomSpeechRecognitionPatternsDataJSON result = new CustomSpeechRecognitionPatternsDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCustomSpeechRecognitionPatternsDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CustomSpeechRecognitionPatternsDataJSON result)
          {
            if (fieldGeneratorPatternGroup.have_value)
              {
                result.setPatternGroup(fieldGeneratorPatternGroup.value);
                fieldGeneratorPatternGroup.have_value = false;
              }
            else if ((!(result.hasPatternGroup())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PatternGroup\" field was missing.");
              }
            if (fieldGeneratorIsGlobal.have_value)
              {
                result.setIsGlobal(fieldGeneratorIsGlobal.value);
                fieldGeneratorIsGlobal.have_value = false;
              }
            else if ((!(result.hasIsGlobal())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"IsGlobal\" field was missing.");
              }
            if (fieldGeneratorEntities.have_value)
              {
                result.initEntities();
                int count = fieldGeneratorEntities.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEntities(fieldGeneratorEntities.value[num]);
                  }
                fieldGeneratorEntities.value.Clear();
                fieldGeneratorEntities.have_value = false;
              }
            if (fieldGeneratorContexts.have_value)
              {
                result.initContexts();
                int count = fieldGeneratorContexts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendContexts(fieldGeneratorContexts.value[num]);
                  }
                fieldGeneratorContexts.value.Clear();
                fieldGeneratorContexts.have_value = false;
              }
            if (fieldGeneratorPronunciations.have_value)
              {
                result.initPronunciations();
                int count = fieldGeneratorPronunciations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPronunciations(fieldGeneratorPronunciations.value[num]);
                  }
                fieldGeneratorPronunciations.value.Clear();
                fieldGeneratorPronunciations.have_value = false;
              }
          }
        protected abstract void handle_result(CustomSpeechRecognitionPatternsDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ontexts", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorContexts;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "ntities", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorEntities;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sGlobal", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorIsGlobal;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tternGroup", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorPatternGroup;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "onunciations", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorPronunciations;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPatternGroup = new JSONHoldingStringGenerator("field \"PatternGroup\" of the CustomSpeechRecognitionPatternsData class");
            fieldGeneratorIsGlobal = new JSONHoldingBooleanGenerator("field \"IsGlobal\" of the CustomSpeechRecognitionPatternsData class");
            fieldGeneratorEntities = new TypeEntitiesJSON.HoldingArrayGenerator("field \"Entities\" of the CustomSpeechRecognitionPatternsData class", ignore_extras);
            fieldGeneratorContexts = new JSONHoldingStringArrayGenerator("field \"Contexts\" of the CustomSpeechRecognitionPatternsData class");
            fieldGeneratorPronunciations = new TypePronunciationsJSON.HoldingArrayGenerator("field \"Pronunciations\" of the CustomSpeechRecognitionPatternsData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CustomSpeechRecognitionPatternsData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPatternGroup = new JSONHoldingStringGenerator("field \"PatternGroup\" of the CustomSpeechRecognitionPatternsData class");
            fieldGeneratorIsGlobal = new JSONHoldingBooleanGenerator("field \"IsGlobal\" of the CustomSpeechRecognitionPatternsData class");
            fieldGeneratorEntities = new TypeEntitiesJSON.HoldingArrayGenerator("field \"Entities\" of the CustomSpeechRecognitionPatternsData class", false);
            fieldGeneratorContexts = new JSONHoldingStringArrayGenerator("field \"Contexts\" of the CustomSpeechRecognitionPatternsData class");
            fieldGeneratorPronunciations = new TypePronunciationsJSON.HoldingArrayGenerator("field \"Pronunciations\" of the CustomSpeechRecognitionPatternsData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CustomSpeechRecognitionPatternsData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPatternGroup.reset();
            fieldGeneratorIsGlobal.reset();
            fieldGeneratorEntities.reset();
            fieldGeneratorContexts.reset();
            fieldGeneratorPronunciations.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEntities.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPronunciations.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEntities.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPronunciations.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CustomSpeechRecognitionPatternsDataJSON  result)
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
        public CustomSpeechRecognitionPatternsDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CustomSpeechRecognitionPatternsDataJSON  result)
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
    protected virtual void handle_result(List<CustomSpeechRecognitionPatternsDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CustomSpeechRecognitionPatternsDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CustomSpeechRecognitionPatternsDataJSON>();
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
    public List<CustomSpeechRecognitionPatternsDataJSON> value;
  };
  };
