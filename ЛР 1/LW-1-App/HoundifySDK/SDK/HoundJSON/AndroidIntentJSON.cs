/* file "AndroidIntentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class AndroidIntentJSON : JSONBase
  {
    public class TypeValueJSON : JSONBase
      {
        public class TypeExtrasJSON : JSONBase
          {
            private bool flagHasType;
            private string storeType;
            private bool flagHasKey;
            private string storeKey;
            private bool flagHasValue;
            private string storeValue;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONType(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Type of TypeExtrasJSON is not a string.");
                setType(json_string.getData());
              }


            private void  fromJSONKey(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Key of TypeExtrasJSON is not a string.");
                setKey(json_string.getData());
              }


            private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                JSONStringValue json_string = json_value.string_value();
                if (json_string == null)
                    throw new Exception("The value for field Value of TypeExtrasJSON is not a string.");
                setValue(json_string.getData());
              }


            public TypeExtrasJSON()
              {
                flagHasType = false;
                flagHasKey = false;
                flagHasValue = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
              }

            public bool  hasType()
              {
                return flagHasType;
              }

            public string  getType()
              {
                Debug.Assert(flagHasType);
                return storeType;
              }

            public bool  hasKey()
              {
                return flagHasKey;
              }

            public string  getKey()
              {
                Debug.Assert(flagHasKey);
                return storeKey;
              }

            public bool  hasValue()
              {
                return flagHasValue;
              }

            public string  getValue()
              {
                Debug.Assert(flagHasValue);
                return storeValue;
              }


            public virtual int extraTypeExtrasComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeExtrasComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeExtrasComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeExtrasLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
              }

            public void setType(string new_value)
              {
                flagHasType = true;
                storeType = new_value;
              }
            public void unsetType()
              {
                flagHasType = false;
              }
            public void setKey(string new_value)
              {
                flagHasKey = true;
                storeKey = new_value;
              }
            public void unsetKey()
              {
                flagHasKey = false;
              }
            public void setValue(string new_value)
              {
                flagHasValue = true;
                storeValue = new_value;
              }
            public void unsetValue()
              {
                flagHasValue = false;
              }

            public virtual void extraTypeExtrasAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeExtrasSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeExtrasLookup(key);
                if (old_field == null)
                  {
                    extraTypeExtrasAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasType);
                if (flagHasType)
                  {
                    handler.start_pair("Type");
                    handler.string_value(storeType);
                  }
                Debug.Assert(partial_allowed || flagHasKey);
                if (flagHasKey)
                  {
                    handler.start_pair("Key");
                    handler.string_value(storeKey);
                  }
                Debug.Assert(partial_allowed || flagHasValue);
                if (flagHasValue)
                  {
                    handler.start_pair("Value");
                    handler.string_value(storeValue);
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
                if (!(hasType()))
                  {
                    return "When parsing the object for %what%, the \"Type\" field was missing.";
                  }
                if (!(hasKey()))
                  {
                    return "When parsing the object for %what%, the \"Key\" field was missing.";
                  }
                if (!(hasValue()))
                  {
                    return "When parsing the object for %what%, the \"Value\" field was missing.";
                  }
                return null;
              }

            public static TypeExtrasJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeExtrasJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeExtras", ignore_extras);
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
            public static TypeExtrasJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeExtrasJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeExtrasJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeExtras", ignore_extras);
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
            public static TypeExtrasJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeExtrasJSON from_text(string text, bool ignore_extras)
              {
                TypeExtrasJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeExtras", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeExtrasJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeExtrasJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeExtrasJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeExtras", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private JSONHoldingStringGenerator fieldGeneratorType;
                private JSONHoldingStringGenerator fieldGeneratorKey;
                private JSONHoldingStringGenerator fieldGeneratorValue;
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
                    TypeExtrasJSON result = new TypeExtrasJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeExtrasAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeExtrasJSON result)
                  {
                    if (fieldGeneratorType.have_value)
                      {
                        result.setType(fieldGeneratorType.value);
                        fieldGeneratorType.have_value = false;
                      }
                    else if ((!(result.hasType())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Type\" field was missing.");
                      }
                    if (fieldGeneratorKey.have_value)
                      {
                        result.setKey(fieldGeneratorKey.value);
                        fieldGeneratorKey.have_value = false;
                      }
                    else if ((!(result.hasKey())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Key\" field was missing.");
                      }
                    if (fieldGeneratorValue.have_value)
                      {
                        result.setValue(fieldGeneratorValue.value);
                        fieldGeneratorValue.have_value = false;
                      }
                    else if ((!(result.hasValue())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Value\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeExtrasJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'K':
                            if ((String.Compare(field_name, 1, "ey", 0, 2, false) == 0) && (field_name.Length == 3))
                                return fieldGeneratorKey;
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorType;
                            break;
                        case 'V':
                            if ((String.Compare(field_name, 1, "alue", 0, 4, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorValue;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorType = new JSONHoldingStringGenerator("field \"Type\" of the TypeExtras class");
                    fieldGeneratorKey = new JSONHoldingStringGenerator("field \"Key\" of the TypeExtras class");
                    fieldGeneratorValue = new JSONHoldingStringGenerator("field \"Value\" of the TypeExtras class");
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeExtras class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorType = new JSONHoldingStringGenerator("field \"Type\" of the TypeExtras class");
                    fieldGeneratorKey = new JSONHoldingStringGenerator("field \"Key\" of the TypeExtras class");
                    fieldGeneratorValue = new JSONHoldingStringGenerator("field \"Value\" of the TypeExtras class");
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeExtras class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorType.reset();
                    fieldGeneratorKey.reset();
                    fieldGeneratorValue.reset();
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
                protected override void handle_result(TypeExtrasJSON  result)
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
                public TypeExtrasJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeExtrasJSON  result)
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
            protected virtual void handle_result(List<TypeExtrasJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeExtrasJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeExtrasJSON>();
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
            public List<TypeExtrasJSON> value;
          };
          };
        private bool flagHasLaunchMode;
        private string storeLaunchMode;
        private bool flagHasAction;
        private string storeAction;
        private bool flagHasExtras;
        private List< TypeExtrasJSON  > storeExtras;
        private bool flagHasURI;
        private string storeURI;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONLaunchMode(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field LaunchMode of TypeValueJSON is not a string.");
            setLaunchMode(json_string.getData());
          }


        private void  fromJSONAction(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Action of TypeValueJSON is not a string.");
            setAction(json_string.getData());
          }


        private void  fromJSONExtras(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Extras of TypeValueJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeExtrasJSON  > vector_Extras1 = new List< TypeExtrasJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeExtrasJSON convert_classy = TypeExtrasJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Extras1.Add(convert_classy);
              }
            initExtras();
            for (int num1 = 0; num1 < vector_Extras1.Count; ++num1)
                appendExtras(vector_Extras1[num1]);
            for (int num1 = 0; num1 < vector_Extras1.Count; ++num1)
              {
              }
          }


        private void  fromJSONURI(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field URI of TypeValueJSON is not a string.");
            setURI(json_string.getData());
          }


        public TypeValueJSON()
          {
            flagHasLaunchMode = false;
            flagHasAction = false;
            flagHasExtras = false;
            flagHasURI = false;
            storeExtras = new List< TypeExtrasJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasLaunchMode()
          {
            return flagHasLaunchMode;
          }

        public string  getLaunchMode()
          {
            Debug.Assert(flagHasLaunchMode);
            return storeLaunchMode;
          }

        public bool  hasAction()
          {
            return flagHasAction;
          }

        public string  getAction()
          {
            Debug.Assert(flagHasAction);
            return storeAction;
          }

        public bool  hasExtras()
          {
            return flagHasExtras;
          }

        public int  countOfExtras()
          {
            return storeExtras.Count;
          }

        public TypeExtrasJSON   elementOfExtras(int element_num)
          {
            return storeExtras[element_num];
          }

        public List< TypeExtrasJSON  >  getExtras()
          {
            return storeExtras;
          }

        public bool  hasURI()
          {
            return flagHasURI;
          }

        public string  getURI()
          {
            Debug.Assert(flagHasURI);
            return storeURI;
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

        public void setLaunchMode(string new_value)
          {
            flagHasLaunchMode = true;
            storeLaunchMode = new_value;
          }
        public void unsetLaunchMode()
          {
            flagHasLaunchMode = false;
          }
        public void setAction(string new_value)
          {
            flagHasAction = true;
            storeAction = new_value;
          }
        public void unsetAction()
          {
            flagHasAction = false;
          }
        public void initExtras()
          {
            if (flagHasExtras)
              {
                for (int num1 = 0; num1 < storeExtras.Count; ++num1)
                  {
                  }
              }
            flagHasExtras = true;
            storeExtras.Clear();
          }
        public void appendExtras(TypeExtrasJSON  to_append)
          {
            if (!flagHasExtras)
              {
                flagHasExtras = true;
                storeExtras.Clear();
              }
            Debug.Assert(flagHasExtras);
            storeExtras.Add(to_append);
          }
        public void unsetExtras()
          {
            if (flagHasExtras)
              {
                for (int num2 = 0; num2 < storeExtras.Count; ++num2)
                  {
                  }
              }
            flagHasExtras = false;
            storeExtras.Clear();
          }
        public void setURI(string new_value)
          {
            flagHasURI = true;
            storeURI = new_value;
          }
        public void unsetURI()
          {
            flagHasURI = false;
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
            Debug.Assert(partial_allowed || flagHasLaunchMode);
            if (flagHasLaunchMode)
              {
                handler.start_pair("LaunchMode");
                handler.string_value(storeLaunchMode);
              }
            Debug.Assert(partial_allowed || flagHasAction);
            if (flagHasAction)
              {
                handler.start_pair("Action");
                handler.string_value(storeAction);
              }
            if (flagHasExtras)
              {
                handler.start_pair("Extras");
                handler.start_array();
                for (int num1 = 0; num1 < storeExtras.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeExtras[num1].write_partial_as_json(handler);
                    else
                        storeExtras[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasURI)
              {
                handler.start_pair("URI");
                handler.string_value(storeURI);
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
            if (!(hasLaunchMode()))
              {
                return "When parsing the object for %what%, the \"LaunchMode\" field was missing.";
              }
            if (!(hasAction()))
              {
                return "When parsing the object for %what%, the \"Action\" field was missing.";
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
            private JSONHoldingStringGenerator fieldGeneratorLaunchMode;
            private JSONHoldingStringGenerator fieldGeneratorAction;
            private TypeExtrasJSON.HoldingArrayGenerator fieldGeneratorExtras;
            private JSONHoldingStringGenerator fieldGeneratorURI;
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
                if (fieldGeneratorLaunchMode.have_value)
                  {
                    result.setLaunchMode(fieldGeneratorLaunchMode.value);
                    fieldGeneratorLaunchMode.have_value = false;
                  }
                else if ((!(result.hasLaunchMode())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"LaunchMode\" field was missing.");
                  }
                if (fieldGeneratorAction.have_value)
                  {
                    result.setAction(fieldGeneratorAction.value);
                    fieldGeneratorAction.have_value = false;
                  }
                else if ((!(result.hasAction())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Action\" field was missing.");
                  }
                if (fieldGeneratorExtras.have_value)
                  {
                    result.initExtras();
                    int count = fieldGeneratorExtras.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendExtras(fieldGeneratorExtras.value[num]);
                      }
                    fieldGeneratorExtras.value.Clear();
                    fieldGeneratorExtras.have_value = false;
                  }
                if (fieldGeneratorURI.have_value)
                  {
                    result.setURI(fieldGeneratorURI.value);
                    fieldGeneratorURI.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeValueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "ction", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorAction;
                        break;
                    case 'E':
                        if ((String.Compare(field_name, 1, "xtras", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorExtras;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "aunchMode", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorLaunchMode;
                        break;
                    case 'U':
                        if ((String.Compare(field_name, 1, "RI", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorURI;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorLaunchMode = new JSONHoldingStringGenerator("field \"LaunchMode\" of the TypeValue class");
                fieldGeneratorAction = new JSONHoldingStringGenerator("field \"Action\" of the TypeValue class");
                fieldGeneratorExtras = new TypeExtrasJSON.HoldingArrayGenerator("field \"Extras\" of the TypeValue class", ignore_extras);
                fieldGeneratorURI = new JSONHoldingStringGenerator("field \"URI\" of the TypeValue class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorLaunchMode = new JSONHoldingStringGenerator("field \"LaunchMode\" of the TypeValue class");
                fieldGeneratorAction = new JSONHoldingStringGenerator("field \"Action\" of the TypeValue class");
                fieldGeneratorExtras = new TypeExtrasJSON.HoldingArrayGenerator("field \"Extras\" of the TypeValue class", false);
                fieldGeneratorURI = new JSONHoldingStringGenerator("field \"URI\" of the TypeValue class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorLaunchMode.reset();
                fieldGeneratorAction.reset();
                fieldGeneratorExtras.reset();
                fieldGeneratorURI.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorExtras.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorExtras.set_allow_unpolished(new_allow_unpolished);
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
            throw new Exception("The value for field Value of AndroidIntentJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Value of AndroidIntentJSON has too few elements.");
        List< TypeValueJSON  > vector_Value1 = new List< TypeValueJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeValueJSON convert_classy = TypeValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Value1.Add(convert_classy);
          }
        Debug.Assert(vector_Value1.Count >= 1);
        initValue();
        for (int num2 = 0; num2 < vector_Value1.Count; ++num2)
            appendValue(vector_Value1[num2]);
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
          {
          }
      }


    public AndroidIntentJSON()
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

    public static AndroidIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AndroidIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AndroidIntent", ignore_extras);
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
    public static AndroidIntentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AndroidIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AndroidIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AndroidIntent", ignore_extras);
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
    public static AndroidIntentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static AndroidIntentJSON from_text(string text, bool ignore_extras)
      {
        AndroidIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AndroidIntent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AndroidIntentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static AndroidIntentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AndroidIntentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AndroidIntent", ignore_extras);
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
            AndroidIntentJSON result = new AndroidIntentJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(AndroidIntentJSON new_result);
        public Generator(bool ignore_extras) : base("Type AndroidIntent", ignore_extras)
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
        protected override void handle_result(AndroidIntentJSON  result)
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
        public AndroidIntentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AndroidIntentJSON  result)
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
    protected virtual void handle_result(List<AndroidIntentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AndroidIntentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AndroidIntentJSON>();
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
    public List<AndroidIntentJSON> value;
  };
  };
