/* file "EntityDetectionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class EntityDetectionJSON : JSONBase
  {
    public class TypeValueJSON : JSONBase
      {
        private bool flagHasEntityKind;
        private string storeEntityKind;
        private bool flagHasEntity;
        private string storeEntity;
        private bool flagHasStartToken;
        private BigInteger storeStartToken;
        private bool flagHasEndToken;
        private BigInteger storeEndToken;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONEntityKind(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field EntityKind of TypeValueJSON is not a string.");
            setEntityKind(json_string.getData());
          }


        private void  fromJSONEntity(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Entity of TypeValueJSON is not a string.");
            setEntity(json_string.getData());
          }


        private void  fromJSONStartToken(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field StartToken of TypeValueJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field StartToken of TypeValueJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setStartToken(extracted_integer);
          }


        private void  fromJSONEndToken(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field EndToken of TypeValueJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field EndToken of TypeValueJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setEndToken(extracted_integer);
          }


        public TypeValueJSON()
          {
            flagHasEntityKind = false;
            flagHasEntity = false;
            flagHasStartToken = false;
            flagHasEndToken = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasEntityKind()
          {
            return flagHasEntityKind;
          }

        public string  getEntityKind()
          {
            Debug.Assert(flagHasEntityKind);
            return storeEntityKind;
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

        public bool  hasStartToken()
          {
            return flagHasStartToken;
          }

        public BigInteger  getStartToken()
          {
            Debug.Assert(flagHasStartToken);
            return storeStartToken;
          }

        public bool  hasEndToken()
          {
            return flagHasEndToken;
          }

        public BigInteger  getEndToken()
          {
            Debug.Assert(flagHasEndToken);
            return storeEndToken;
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

        public void setEntityKind(string new_value)
          {
            flagHasEntityKind = true;
            storeEntityKind = new_value;
          }
        public void unsetEntityKind()
          {
            flagHasEntityKind = false;
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
        public void setStartToken(BigInteger new_value)
          {
            flagHasStartToken = true;
            if (new_value < 0)
                throw new Exception("The value for field StartToken of TypeValueJSON is less than the lower bound (0) for that field.");
            storeStartToken = new_value;
          }
        public void unsetStartToken()
          {
            flagHasStartToken = false;
          }
        public void setEndToken(BigInteger new_value)
          {
            flagHasEndToken = true;
            if (new_value < 0)
                throw new Exception("The value for field EndToken of TypeValueJSON is less than the lower bound (0) for that field.");
            storeEndToken = new_value;
          }
        public void unsetEndToken()
          {
            flagHasEndToken = false;
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
            Debug.Assert(partial_allowed || flagHasEntityKind);
            if (flagHasEntityKind)
              {
                handler.start_pair("EntityKind");
                handler.string_value(storeEntityKind);
              }
            Debug.Assert(partial_allowed || flagHasEntity);
            if (flagHasEntity)
              {
                handler.start_pair("Entity");
                handler.string_value(storeEntity);
              }
            if (flagHasStartToken)
              {
                handler.start_pair("StartToken");
                handler.number_value(storeStartToken);
              }
            if (flagHasEndToken)
              {
                handler.start_pair("EndToken");
                handler.number_value(storeEndToken);
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
            if (!(hasEntityKind()))
              {
                return "When parsing the object for %what%, the \"EntityKind\" field was missing.";
              }
            if (!(hasEntity()))
              {
                return "When parsing the object for %what%, the \"Entity\" field was missing.";
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
            private JSONHoldingStringGenerator fieldGeneratorEntityKind;
            private JSONHoldingStringGenerator fieldGeneratorEntity;
        private class FieldHoldingGeneratorStartToken : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorStartToken(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorStartToken : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorStartToken(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorStartToken fieldGeneratorStartToken;
        private class FieldHoldingGeneratorEndToken : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorEndToken(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorEndToken : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorEndToken(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorEndToken fieldGeneratorEndToken;
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
                if (fieldGeneratorEntityKind.have_value)
                  {
                    result.setEntityKind(fieldGeneratorEntityKind.value);
                    fieldGeneratorEntityKind.have_value = false;
                  }
                else if ((!(result.hasEntityKind())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"EntityKind\" field was missing.");
                  }
                if (fieldGeneratorEntity.have_value)
                  {
                    result.setEntity(fieldGeneratorEntity.value);
                    fieldGeneratorEntity.have_value = false;
                  }
                else if ((!(result.hasEntity())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Entity\" field was missing.");
                  }
                if (fieldGeneratorStartToken.have_value)
                  {
                    result.setStartToken(fieldGeneratorStartToken.value);
                    fieldGeneratorStartToken.have_value = false;
                  }
                if (fieldGeneratorEndToken.have_value)
                  {
                    result.setEndToken(fieldGeneratorEndToken.value);
                    fieldGeneratorEndToken.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeValueJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'E':
                        if (String.Compare(field_name, 1, "n", 0, 1, false) == 0)
                          {
                            switch (field_name[2])
                              {
                                case 'd':
                                    if ((String.Compare(field_name, 3, "Token", 0, 5, false) == 0) && (field_name.Length == 8))
                                        return fieldGeneratorEndToken;
                                    break;
                                case 't':
                                    if (String.Compare(field_name, 3, "ity", 0, 3, false) == 0)
                                      {
                                        if (field_name.Length == 6)
                                          {
                                            return fieldGeneratorEntity;
                                          }
                                        switch (field_name[6])
                                          {
                                            case 'K':
                                                if ((String.Compare(field_name, 7, "ind", 0, 3, false) == 0) && (field_name.Length == 10))
                                                    return fieldGeneratorEntityKind;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "tartToken", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorStartToken;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorEntityKind = new JSONHoldingStringGenerator("field \"EntityKind\" of the TypeValue class");
                fieldGeneratorEntity = new JSONHoldingStringGenerator("field \"Entity\" of the TypeValue class");
                fieldGeneratorStartToken = new FieldHoldingGeneratorStartToken("field \"StartToken\" of the TypeValue class");
                fieldGeneratorEndToken = new FieldHoldingGeneratorEndToken("field \"EndToken\" of the TypeValue class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorEntityKind = new JSONHoldingStringGenerator("field \"EntityKind\" of the TypeValue class");
                fieldGeneratorEntity = new JSONHoldingStringGenerator("field \"Entity\" of the TypeValue class");
                fieldGeneratorStartToken = new FieldHoldingGeneratorStartToken("field \"StartToken\" of the TypeValue class");
                fieldGeneratorEndToken = new FieldHoldingGeneratorEndToken("field \"EndToken\" of the TypeValue class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeValue class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorEntityKind.reset();
                fieldGeneratorEntity.reset();
                fieldGeneratorStartToken.reset();
                fieldGeneratorEndToken.reset();
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
            throw new Exception("The value for field Value of EntityDetectionJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeValueJSON  > vector_Value1 = new List< TypeValueJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeValueJSON convert_classy = TypeValueJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Value1.Add(convert_classy);
          }
        initValue();
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
            appendValue(vector_Value1[num1]);
        for (int num1 = 0; num1 < vector_Value1.Count; ++num1)
          {
          }
      }


    public EntityDetectionJSON()
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
            for (int num1 = 0; num1 < storeValue.Count; ++num1)
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
            for (int num2 = 0; num2 < storeValue.Count; ++num2)
              {
              }
          }
        flagHasValue = false;
        storeValue.Clear();
      }


    public override void write_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num1 = 0; num1 < storeValue.Count; ++num1)
          {
            storeValue[num1].write_as_json(handler);
          }
        handler.finish_array();
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_array();
        for (int num2 = 0; num2 < storeValue.Count; ++num2)
          {
            storeValue[num2].write_partial_as_json(handler);
          }
        handler.finish_array();
      }

    public static EntityDetectionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EntityDetectionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EntityDetection", ignore_extras);
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
    public static EntityDetectionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EntityDetectionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        EntityDetectionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EntityDetection", ignore_extras);
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
    public static EntityDetectionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static EntityDetectionJSON from_text(string text, bool ignore_extras)
      {
        EntityDetectionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EntityDetection", ignore_extras);
            JSONParse.parse_json_value(text, "Text for EntityDetectionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static EntityDetectionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        EntityDetectionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type EntityDetection", ignore_extras);
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
            EntityDetectionJSON result = new EntityDetectionJSON();
            result.initValue();
            int count = value.Count;
            for (int num = 0; num < count; ++num)
              {
                result.appendValue(value[num]);
              }
            handle_result(result);
          }
        protected abstract void handle_result(EntityDetectionJSON new_result);
        public Generator(bool ignore_extras) : base("Type EntityDetection", ignore_extras)
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
        protected override void handle_result(EntityDetectionJSON  result)
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
        public EntityDetectionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(EntityDetectionJSON  result)
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
    protected virtual void handle_result(List<EntityDetectionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<EntityDetectionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<EntityDetectionJSON>();
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
    public List<EntityDetectionJSON> value;
  };
  };
