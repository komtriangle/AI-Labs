/* file "RestaurantOrderingMenuDataSelectionRulesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RestaurantOrderingMenuDataSelectionRulesJSON : JSONBase
  {
    public class TypeNumberOfDifferentOptionsSelectedJSON : JSONBase
      {
        private bool flagHasMinimum;
        private BigInteger storeMinimum;
        private bool flagHasMaximum;
        private BigInteger storeMaximum;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONMinimum(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Minimum of TypeNumberOfDifferentOptionsSelectedJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Minimum of TypeNumberOfDifferentOptionsSelectedJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setMinimum(extracted_integer);
          }


        private void  fromJSONMaximum(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Maximum of TypeNumberOfDifferentOptionsSelectedJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Maximum of TypeNumberOfDifferentOptionsSelectedJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setMaximum(extracted_integer);
          }


        public TypeNumberOfDifferentOptionsSelectedJSON()
          {
            flagHasMinimum = false;
            flagHasMaximum = false;
            storeMinimum = 0;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasMinimum()
          {
            return flagHasMinimum;
          }

        public BigInteger  getMinimum()
          {
            return storeMinimum;
          }

        public bool  hasMaximum()
          {
            return flagHasMaximum;
          }

        public BigInteger  getMaximum()
          {
            Debug.Assert(flagHasMaximum);
            return storeMaximum;
          }


        public virtual int extraTypeNumberOfDifferentOptionsSelectedComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNumberOfDifferentOptionsSelectedComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNumberOfDifferentOptionsSelectedComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNumberOfDifferentOptionsSelectedLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setMinimum(BigInteger new_value)
          {
            flagHasMinimum = true;
            if (new_value < 0)
                throw new Exception("The value for field Minimum of TypeNumberOfDifferentOptionsSelectedJSON is less than the lower bound (0) for that field.");
            storeMinimum = new_value;
          }
        public void unsetMinimum()
          {
            flagHasMinimum = false;
          }
        public void setMaximum(BigInteger new_value)
          {
            flagHasMaximum = true;
            if (new_value < 1)
                throw new Exception("The value for field Maximum of TypeNumberOfDifferentOptionsSelectedJSON is less than the lower bound (1) for that field.");
            storeMaximum = new_value;
          }
        public void unsetMaximum()
          {
            flagHasMaximum = false;
          }

        public virtual void extraTypeNumberOfDifferentOptionsSelectedAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNumberOfDifferentOptionsSelectedSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNumberOfDifferentOptionsSelectedLookup(key);
            if (old_field == null)
              {
                extraTypeNumberOfDifferentOptionsSelectedAppendPair(key, new_component);
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
            if (flagHasMinimum)
              {
                handler.start_pair("Minimum");
                handler.number_value(storeMinimum);
              }
            if (flagHasMaximum)
              {
                handler.start_pair("Maximum");
                handler.number_value(storeMaximum);
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
            return null;
          }

        public static TypeNumberOfDifferentOptionsSelectedJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNumberOfDifferentOptionsSelectedJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumberOfDifferentOptionsSelected", ignore_extras);
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
        public static TypeNumberOfDifferentOptionsSelectedJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNumberOfDifferentOptionsSelectedJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNumberOfDifferentOptionsSelectedJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumberOfDifferentOptionsSelected", ignore_extras);
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
        public static TypeNumberOfDifferentOptionsSelectedJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNumberOfDifferentOptionsSelectedJSON from_text(string text, bool ignore_extras)
          {
            TypeNumberOfDifferentOptionsSelectedJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumberOfDifferentOptionsSelected", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNumberOfDifferentOptionsSelectedJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNumberOfDifferentOptionsSelectedJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNumberOfDifferentOptionsSelectedJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumberOfDifferentOptionsSelected", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorMinimum : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorMinimum(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMinimum : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorMinimum(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorMinimum fieldGeneratorMinimum;
        private class FieldHoldingGeneratorMaximum : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorMaximum(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMaximum : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorMaximum(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
            private FieldHoldingGeneratorMaximum fieldGeneratorMaximum;
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
                TypeNumberOfDifferentOptionsSelectedJSON result = new TypeNumberOfDifferentOptionsSelectedJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNumberOfDifferentOptionsSelectedAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNumberOfDifferentOptionsSelectedJSON result)
              {
                if (fieldGeneratorMinimum.have_value)
                  {
                    result.setMinimum(fieldGeneratorMinimum.value);
                    fieldGeneratorMinimum.have_value = false;
                  }
                if (fieldGeneratorMaximum.have_value)
                  {
                    result.setMaximum(fieldGeneratorMaximum.value);
                    fieldGeneratorMaximum.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNumberOfDifferentOptionsSelectedJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "M", 0, 1, false) == 0)
                  {
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ximum", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorMaximum;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "nimum", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorMinimum;
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorMinimum = new FieldHoldingGeneratorMinimum("field \"Minimum\" of the TypeNumberOfDifferentOptionsSelected class");
                fieldGeneratorMaximum = new FieldHoldingGeneratorMaximum("field \"Maximum\" of the TypeNumberOfDifferentOptionsSelected class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNumberOfDifferentOptionsSelected class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorMinimum = new FieldHoldingGeneratorMinimum("field \"Minimum\" of the TypeNumberOfDifferentOptionsSelected class");
                fieldGeneratorMaximum = new FieldHoldingGeneratorMaximum("field \"Maximum\" of the TypeNumberOfDifferentOptionsSelected class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNumberOfDifferentOptionsSelected class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorMinimum.reset();
                fieldGeneratorMaximum.reset();
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
            protected override void handle_result(TypeNumberOfDifferentOptionsSelectedJSON  result)
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
            public TypeNumberOfDifferentOptionsSelectedJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNumberOfDifferentOptionsSelectedJSON  result)
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
        protected virtual void handle_result(List<TypeNumberOfDifferentOptionsSelectedJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNumberOfDifferentOptionsSelectedJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNumberOfDifferentOptionsSelectedJSON>();
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
        public List<TypeNumberOfDifferentOptionsSelectedJSON> value;
      };
      };
    public class TypeNumberPerSelectedOptionJSON : JSONBase
      {
        private bool flagHasMinimum;
        private sbyte storeMinimum;
        private bool flagHasMaximum;
        private BigInteger storeMaximum;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONMinimum(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Minimum of TypeNumberPerSelectedOptionJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Minimum of TypeNumberPerSelectedOptionJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setMinimum(extracted_integer);
          }


        private void  fromJSONMaximum(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Maximum of TypeNumberPerSelectedOptionJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Maximum of TypeNumberPerSelectedOptionJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setMaximum(extracted_integer);
          }


        public TypeNumberPerSelectedOptionJSON()
          {
            flagHasMinimum = false;
            flagHasMaximum = false;
            storeMinimum = 1;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasMinimum()
          {
            return flagHasMinimum;
          }

        public sbyte  getMinimum()
          {
            return storeMinimum;
          }

        public bool  hasMaximum()
          {
            return flagHasMaximum;
          }

        public BigInteger  getMaximum()
          {
            Debug.Assert(flagHasMaximum);
            return storeMaximum;
          }


        public virtual int extraTypeNumberPerSelectedOptionComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNumberPerSelectedOptionComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNumberPerSelectedOptionComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNumberPerSelectedOptionLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setMinimum(sbyte new_value)
          {
            flagHasMinimum = true;
            if (new_value < 1)
                throw new Exception("The value for field Minimum of TypeNumberPerSelectedOptionJSON is less than the lower bound (1) for that field.");
            if (new_value > 1)
                throw new Exception("The value for field Minimum of TypeNumberPerSelectedOptionJSON is greater than the upper bound (1) for that field.");
            storeMinimum = new_value;
          }
        public void unsetMinimum()
          {
            flagHasMinimum = false;
          }
        public void setMaximum(BigInteger new_value)
          {
            flagHasMaximum = true;
            if (new_value < 1)
                throw new Exception("The value for field Maximum of TypeNumberPerSelectedOptionJSON is less than the lower bound (1) for that field.");
            storeMaximum = new_value;
          }
        public void unsetMaximum()
          {
            flagHasMaximum = false;
          }

        public virtual void extraTypeNumberPerSelectedOptionAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNumberPerSelectedOptionSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNumberPerSelectedOptionLookup(key);
            if (old_field == null)
              {
                extraTypeNumberPerSelectedOptionAppendPair(key, new_component);
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
            if (flagHasMinimum)
              {
                handler.start_pair("Minimum");
                handler.number_value(storeMinimum);
              }
            if (flagHasMaximum)
              {
                handler.start_pair("Maximum");
                handler.number_value(storeMaximum);
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
            return null;
          }

        public static TypeNumberPerSelectedOptionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNumberPerSelectedOptionJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumberPerSelectedOption", ignore_extras);
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
        public static TypeNumberPerSelectedOptionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNumberPerSelectedOptionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNumberPerSelectedOptionJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumberPerSelectedOption", ignore_extras);
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
        public static TypeNumberPerSelectedOptionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNumberPerSelectedOptionJSON from_text(string text, bool ignore_extras)
          {
            TypeNumberPerSelectedOptionJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumberPerSelectedOption", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNumberPerSelectedOptionJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNumberPerSelectedOptionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNumberPerSelectedOptionJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumberPerSelectedOption", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorMinimum : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorMinimum(String what) : base(what, 1, 1)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMinimum : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorMinimum(String what) : base(what, 1, 1)
                  {
                  }
              };
            private FieldHoldingGeneratorMinimum fieldGeneratorMinimum;
        private class FieldHoldingGeneratorMaximum : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorMaximum(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMaximum : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorMaximum(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
            private FieldHoldingGeneratorMaximum fieldGeneratorMaximum;
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
                TypeNumberPerSelectedOptionJSON result = new TypeNumberPerSelectedOptionJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNumberPerSelectedOptionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNumberPerSelectedOptionJSON result)
              {
                if (fieldGeneratorMinimum.have_value)
                  {
                    result.setMinimum((sbyte)(fieldGeneratorMinimum.value));
                    fieldGeneratorMinimum.have_value = false;
                  }
                if (fieldGeneratorMaximum.have_value)
                  {
                    result.setMaximum(fieldGeneratorMaximum.value);
                    fieldGeneratorMaximum.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNumberPerSelectedOptionJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "M", 0, 1, false) == 0)
                  {
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ximum", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorMaximum;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "nimum", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorMinimum;
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorMinimum = new FieldHoldingGeneratorMinimum("field \"Minimum\" of the TypeNumberPerSelectedOption class");
                fieldGeneratorMaximum = new FieldHoldingGeneratorMaximum("field \"Maximum\" of the TypeNumberPerSelectedOption class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNumberPerSelectedOption class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorMinimum = new FieldHoldingGeneratorMinimum("field \"Minimum\" of the TypeNumberPerSelectedOption class");
                fieldGeneratorMaximum = new FieldHoldingGeneratorMaximum("field \"Maximum\" of the TypeNumberPerSelectedOption class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNumberPerSelectedOption class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorMinimum.reset();
                fieldGeneratorMaximum.reset();
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
            protected override void handle_result(TypeNumberPerSelectedOptionJSON  result)
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
            public TypeNumberPerSelectedOptionJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNumberPerSelectedOptionJSON  result)
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
        protected virtual void handle_result(List<TypeNumberPerSelectedOptionJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNumberPerSelectedOptionJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNumberPerSelectedOptionJSON>();
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
        public List<TypeNumberPerSelectedOptionJSON> value;
      };
      };
    public class TypeNumberOfTotalChoicesJSON : JSONBase
      {
        private bool flagHasMinimum;
        private BigInteger storeMinimum;
        private bool flagHasMaximum;
        private BigInteger storeMaximum;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONMinimum(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Minimum of TypeNumberOfTotalChoicesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Minimum of TypeNumberOfTotalChoicesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setMinimum(extracted_integer);
          }


        private void  fromJSONMaximum(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Maximum of TypeNumberOfTotalChoicesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Maximum of TypeNumberOfTotalChoicesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setMaximum(extracted_integer);
          }


        public TypeNumberOfTotalChoicesJSON()
          {
            flagHasMinimum = false;
            flagHasMaximum = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasMinimum()
          {
            return flagHasMinimum;
          }

        public BigInteger  getMinimum()
          {
            Debug.Assert(flagHasMinimum);
            return storeMinimum;
          }

        public bool  hasMaximum()
          {
            return flagHasMaximum;
          }

        public BigInteger  getMaximum()
          {
            Debug.Assert(flagHasMaximum);
            return storeMaximum;
          }


        public virtual int extraTypeNumberOfTotalChoicesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNumberOfTotalChoicesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNumberOfTotalChoicesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNumberOfTotalChoicesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setMinimum(BigInteger new_value)
          {
            flagHasMinimum = true;
            if (new_value < 0)
                throw new Exception("The value for field Minimum of TypeNumberOfTotalChoicesJSON is less than the lower bound (0) for that field.");
            storeMinimum = new_value;
          }
        public void unsetMinimum()
          {
            flagHasMinimum = false;
          }
        public void setMaximum(BigInteger new_value)
          {
            flagHasMaximum = true;
            if (new_value < 1)
                throw new Exception("The value for field Maximum of TypeNumberOfTotalChoicesJSON is less than the lower bound (1) for that field.");
            storeMaximum = new_value;
          }
        public void unsetMaximum()
          {
            flagHasMaximum = false;
          }

        public virtual void extraTypeNumberOfTotalChoicesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNumberOfTotalChoicesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNumberOfTotalChoicesLookup(key);
            if (old_field == null)
              {
                extraTypeNumberOfTotalChoicesAppendPair(key, new_component);
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
            if (flagHasMinimum)
              {
                handler.start_pair("Minimum");
                handler.number_value(storeMinimum);
              }
            if (flagHasMaximum)
              {
                handler.start_pair("Maximum");
                handler.number_value(storeMaximum);
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
            return null;
          }

        public static TypeNumberOfTotalChoicesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNumberOfTotalChoicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumberOfTotalChoices", ignore_extras);
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
        public static TypeNumberOfTotalChoicesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNumberOfTotalChoicesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNumberOfTotalChoicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumberOfTotalChoices", ignore_extras);
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
        public static TypeNumberOfTotalChoicesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNumberOfTotalChoicesJSON from_text(string text, bool ignore_extras)
          {
            TypeNumberOfTotalChoicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumberOfTotalChoices", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNumberOfTotalChoicesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNumberOfTotalChoicesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNumberOfTotalChoicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNumberOfTotalChoices", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorMinimum : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorMinimum(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMinimum : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorMinimum(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorMinimum fieldGeneratorMinimum;
        private class FieldHoldingGeneratorMaximum : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorMaximum(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMaximum : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorMaximum(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
            private FieldHoldingGeneratorMaximum fieldGeneratorMaximum;
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
                TypeNumberOfTotalChoicesJSON result = new TypeNumberOfTotalChoicesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNumberOfTotalChoicesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNumberOfTotalChoicesJSON result)
              {
                if (fieldGeneratorMinimum.have_value)
                  {
                    result.setMinimum(fieldGeneratorMinimum.value);
                    fieldGeneratorMinimum.have_value = false;
                  }
                if (fieldGeneratorMaximum.have_value)
                  {
                    result.setMaximum(fieldGeneratorMaximum.value);
                    fieldGeneratorMaximum.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNumberOfTotalChoicesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if (String.Compare(field_name, 0, "M", 0, 1, false) == 0)
                  {
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ximum", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorMaximum;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "nimum", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorMinimum;
                            break;
                        default:
                            break;
                      }
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorMinimum = new FieldHoldingGeneratorMinimum("field \"Minimum\" of the TypeNumberOfTotalChoices class");
                fieldGeneratorMaximum = new FieldHoldingGeneratorMaximum("field \"Maximum\" of the TypeNumberOfTotalChoices class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNumberOfTotalChoices class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorMinimum = new FieldHoldingGeneratorMinimum("field \"Minimum\" of the TypeNumberOfTotalChoices class");
                fieldGeneratorMaximum = new FieldHoldingGeneratorMaximum("field \"Maximum\" of the TypeNumberOfTotalChoices class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNumberOfTotalChoices class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorMinimum.reset();
                fieldGeneratorMaximum.reset();
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
            protected override void handle_result(TypeNumberOfTotalChoicesJSON  result)
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
            public TypeNumberOfTotalChoicesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNumberOfTotalChoicesJSON  result)
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
        protected virtual void handle_result(List<TypeNumberOfTotalChoicesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNumberOfTotalChoicesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNumberOfTotalChoicesJSON>();
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
        public List<TypeNumberOfTotalChoicesJSON> value;
      };
      };
    private bool flagHasNumberOfDifferentOptionsSelected;
    private TypeNumberOfDifferentOptionsSelectedJSON  storeNumberOfDifferentOptionsSelected;
    private bool flagHasNumberPerSelectedOption;
    private TypeNumberPerSelectedOptionJSON  storeNumberPerSelectedOption;
    private bool flagHasNumberOfTotalChoices;
    private TypeNumberOfTotalChoicesJSON  storeNumberOfTotalChoices;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONNumberOfDifferentOptionsSelected(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNumberOfDifferentOptionsSelectedJSON convert_classy = TypeNumberOfDifferentOptionsSelectedJSON.from_json(json_value, ignore_extras, true);
        setNumberOfDifferentOptionsSelected(convert_classy);
      }


    private void  fromJSONNumberPerSelectedOption(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNumberPerSelectedOptionJSON convert_classy = TypeNumberPerSelectedOptionJSON.from_json(json_value, ignore_extras, true);
        setNumberPerSelectedOption(convert_classy);
      }


    private void  fromJSONNumberOfTotalChoices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNumberOfTotalChoicesJSON convert_classy = TypeNumberOfTotalChoicesJSON.from_json(json_value, ignore_extras, true);
        setNumberOfTotalChoices(convert_classy);
      }


    public RestaurantOrderingMenuDataSelectionRulesJSON()
      {
        flagHasNumberOfDifferentOptionsSelected = false;
        flagHasNumberPerSelectedOption = false;
        flagHasNumberOfTotalChoices = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasNumberOfDifferentOptionsSelected()
      {
        return flagHasNumberOfDifferentOptionsSelected;
      }

    public TypeNumberOfDifferentOptionsSelectedJSON   getNumberOfDifferentOptionsSelected()
      {
        Debug.Assert(flagHasNumberOfDifferentOptionsSelected);
        return storeNumberOfDifferentOptionsSelected;
      }

    public bool  hasNumberPerSelectedOption()
      {
        return flagHasNumberPerSelectedOption;
      }

    public TypeNumberPerSelectedOptionJSON   getNumberPerSelectedOption()
      {
        Debug.Assert(flagHasNumberPerSelectedOption);
        return storeNumberPerSelectedOption;
      }

    public bool  hasNumberOfTotalChoices()
      {
        return flagHasNumberOfTotalChoices;
      }

    public TypeNumberOfTotalChoicesJSON   getNumberOfTotalChoices()
      {
        Debug.Assert(flagHasNumberOfTotalChoices);
        return storeNumberOfTotalChoices;
      }


    public virtual int extraRestaurantOrderingMenuDataSelectionRulesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantOrderingMenuDataSelectionRulesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataSelectionRulesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataSelectionRulesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setNumberOfDifferentOptionsSelected(TypeNumberOfDifferentOptionsSelectedJSON  new_value)
      {
        if (flagHasNumberOfDifferentOptionsSelected)
          {
          }
        flagHasNumberOfDifferentOptionsSelected = true;
        storeNumberOfDifferentOptionsSelected = new_value;
      }
    public void unsetNumberOfDifferentOptionsSelected()
      {
        if (flagHasNumberOfDifferentOptionsSelected)
          {
          }
        flagHasNumberOfDifferentOptionsSelected = false;
      }
    public void setNumberPerSelectedOption(TypeNumberPerSelectedOptionJSON  new_value)
      {
        if (flagHasNumberPerSelectedOption)
          {
          }
        flagHasNumberPerSelectedOption = true;
        storeNumberPerSelectedOption = new_value;
      }
    public void unsetNumberPerSelectedOption()
      {
        if (flagHasNumberPerSelectedOption)
          {
          }
        flagHasNumberPerSelectedOption = false;
      }
    public void setNumberOfTotalChoices(TypeNumberOfTotalChoicesJSON  new_value)
      {
        if (flagHasNumberOfTotalChoices)
          {
          }
        flagHasNumberOfTotalChoices = true;
        storeNumberOfTotalChoices = new_value;
      }
    public void unsetNumberOfTotalChoices()
      {
        if (flagHasNumberOfTotalChoices)
          {
          }
        flagHasNumberOfTotalChoices = false;
      }

    public virtual void extraRestaurantOrderingMenuDataSelectionRulesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantOrderingMenuDataSelectionRulesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantOrderingMenuDataSelectionRulesLookup(key);
        if (old_field == null)
          {
            extraRestaurantOrderingMenuDataSelectionRulesAppendPair(key, new_component);
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
        if (flagHasNumberOfDifferentOptionsSelected)
          {
            handler.start_pair("NumberOfDifferentOptionsSelected");
            if (partial_allowed)
                storeNumberOfDifferentOptionsSelected.write_partial_as_json(handler);
            else
                storeNumberOfDifferentOptionsSelected.write_as_json(handler);
          }
        if (flagHasNumberPerSelectedOption)
          {
            handler.start_pair("NumberPerSelectedOption");
            if (partial_allowed)
                storeNumberPerSelectedOption.write_partial_as_json(handler);
            else
                storeNumberPerSelectedOption.write_as_json(handler);
          }
        if (flagHasNumberOfTotalChoices)
          {
            handler.start_pair("NumberOfTotalChoices");
            if (partial_allowed)
                storeNumberOfTotalChoices.write_partial_as_json(handler);
            else
                storeNumberOfTotalChoices.write_as_json(handler);
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
        return null;
      }

    public static RestaurantOrderingMenuDataSelectionRulesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataSelectionRulesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataSelectionRules", ignore_extras);
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
    public static RestaurantOrderingMenuDataSelectionRulesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantOrderingMenuDataSelectionRulesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataSelectionRulesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataSelectionRules", ignore_extras);
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
    public static RestaurantOrderingMenuDataSelectionRulesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantOrderingMenuDataSelectionRulesJSON from_text(string text, bool ignore_extras)
      {
        RestaurantOrderingMenuDataSelectionRulesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataSelectionRules", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantOrderingMenuDataSelectionRulesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantOrderingMenuDataSelectionRulesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantOrderingMenuDataSelectionRulesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuDataSelectionRules", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TypeNumberOfDifferentOptionsSelectedJSON.HoldingGenerator fieldGeneratorNumberOfDifferentOptionsSelected;
        private TypeNumberPerSelectedOptionJSON.HoldingGenerator fieldGeneratorNumberPerSelectedOption;
        private TypeNumberOfTotalChoicesJSON.HoldingGenerator fieldGeneratorNumberOfTotalChoices;
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
            RestaurantOrderingMenuDataSelectionRulesJSON result = new RestaurantOrderingMenuDataSelectionRulesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantOrderingMenuDataSelectionRulesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantOrderingMenuDataSelectionRulesJSON result)
          {
            if (fieldGeneratorNumberOfDifferentOptionsSelected.have_value)
              {
                result.setNumberOfDifferentOptionsSelected(fieldGeneratorNumberOfDifferentOptionsSelected.value);
                fieldGeneratorNumberOfDifferentOptionsSelected.have_value = false;
              }
            if (fieldGeneratorNumberPerSelectedOption.have_value)
              {
                result.setNumberPerSelectedOption(fieldGeneratorNumberPerSelectedOption.value);
                fieldGeneratorNumberPerSelectedOption.have_value = false;
              }
            if (fieldGeneratorNumberOfTotalChoices.have_value)
              {
                result.setNumberOfTotalChoices(fieldGeneratorNumberOfTotalChoices.value);
                fieldGeneratorNumberOfTotalChoices.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantOrderingMenuDataSelectionRulesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Number", 0, 6, false) == 0)
              {
                switch (field_name[6])
                  {
                    case 'O':
                        if (String.Compare(field_name, 7, "f", 0, 1, false) == 0)
                          {
                            switch (field_name[8])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 9, "ifferentOptionsSelected", 0, 23, false) == 0) && (field_name.Length == 32))
                                        return fieldGeneratorNumberOfDifferentOptionsSelected;
                                    break;
                                case 'T':
                                    if ((String.Compare(field_name, 9, "otalChoices", 0, 11, false) == 0) && (field_name.Length == 20))
                                        return fieldGeneratorNumberOfTotalChoices;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 7, "erSelectedOption", 0, 16, false) == 0) && (field_name.Length == 23))
                            return fieldGeneratorNumberPerSelectedOption;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorNumberOfDifferentOptionsSelected = new TypeNumberOfDifferentOptionsSelectedJSON.HoldingGenerator("field \"NumberOfDifferentOptionsSelected\" of the RestaurantOrderingMenuDataSelectionRules class", ignore_extras);
            fieldGeneratorNumberPerSelectedOption = new TypeNumberPerSelectedOptionJSON.HoldingGenerator("field \"NumberPerSelectedOption\" of the RestaurantOrderingMenuDataSelectionRules class", ignore_extras);
            fieldGeneratorNumberOfTotalChoices = new TypeNumberOfTotalChoicesJSON.HoldingGenerator("field \"NumberOfTotalChoices\" of the RestaurantOrderingMenuDataSelectionRules class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantOrderingMenuDataSelectionRules class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorNumberOfDifferentOptionsSelected = new TypeNumberOfDifferentOptionsSelectedJSON.HoldingGenerator("field \"NumberOfDifferentOptionsSelected\" of the RestaurantOrderingMenuDataSelectionRules class", false);
            fieldGeneratorNumberPerSelectedOption = new TypeNumberPerSelectedOptionJSON.HoldingGenerator("field \"NumberPerSelectedOption\" of the RestaurantOrderingMenuDataSelectionRules class", false);
            fieldGeneratorNumberOfTotalChoices = new TypeNumberOfTotalChoicesJSON.HoldingGenerator("field \"NumberOfTotalChoices\" of the RestaurantOrderingMenuDataSelectionRules class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantOrderingMenuDataSelectionRules class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorNumberOfDifferentOptionsSelected.reset();
            fieldGeneratorNumberPerSelectedOption.reset();
            fieldGeneratorNumberOfTotalChoices.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorNumberOfDifferentOptionsSelected.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNumberPerSelectedOption.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNumberOfTotalChoices.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorNumberOfDifferentOptionsSelected.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNumberPerSelectedOption.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNumberOfTotalChoices.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantOrderingMenuDataSelectionRulesJSON  result)
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
        public RestaurantOrderingMenuDataSelectionRulesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantOrderingMenuDataSelectionRulesJSON  result)
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
    protected virtual void handle_result(List<RestaurantOrderingMenuDataSelectionRulesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantOrderingMenuDataSelectionRulesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantOrderingMenuDataSelectionRulesJSON>();
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
    public List<RestaurantOrderingMenuDataSelectionRulesJSON> value;
  };
  };
