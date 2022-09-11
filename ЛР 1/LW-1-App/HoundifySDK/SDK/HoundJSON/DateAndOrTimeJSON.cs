/* file "DateAndOrTimeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class DateAndOrTimeJSON : JSONBase
  {
    public class TypeDate_0JSON : JSONBase
      {
        private bool flagHasYear;
        private BigInteger storeYear;
        private bool flagHasMonth;
        private sbyte storeMonth;
        private bool flagHasDayOfMonth;
        private sbyte storeDayOfMonth;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONYear(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Year of TypeDate_0JSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Year of TypeDate_0JSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setYear(extracted_integer);
          }


        private void  fromJSONMonth(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Month of TypeDate_0JSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Month of TypeDate_0JSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setMonth(extracted_integer);
          }


        private void  fromJSONDayOfMonth(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field DayOfMonth of TypeDate_0JSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field DayOfMonth of TypeDate_0JSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setDayOfMonth(extracted_integer);
          }


        public TypeDate_0JSON()
          {
            flagHasYear = false;
            flagHasMonth = false;
            flagHasDayOfMonth = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasYear()
          {
            return flagHasYear;
          }

        public BigInteger  getYear()
          {
            Debug.Assert(flagHasYear);
            return storeYear;
          }

        public bool  hasMonth()
          {
            return flagHasMonth;
          }

        public sbyte  getMonth()
          {
            Debug.Assert(flagHasMonth);
            return storeMonth;
          }

        public bool  hasDayOfMonth()
          {
            return flagHasDayOfMonth;
          }

        public sbyte  getDayOfMonth()
          {
            Debug.Assert(flagHasDayOfMonth);
            return storeDayOfMonth;
          }


        public virtual int extraTypeDate_0ComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeDate_0ComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeDate_0ComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeDate_0Lookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setYear(BigInteger new_value)
          {
            flagHasYear = true;
            storeYear = new_value;
          }
        public void unsetYear()
          {
            flagHasYear = false;
          }
        public void setMonth(sbyte new_value)
          {
            flagHasMonth = true;
            if (new_value < 1)
                throw new Exception("The value for field Month of TypeDate_0JSON is less than the lower bound (1) for that field.");
            if (new_value > 12)
                throw new Exception("The value for field Month of TypeDate_0JSON is greater than the upper bound (12) for that field.");
            storeMonth = new_value;
          }
        public void unsetMonth()
          {
            flagHasMonth = false;
          }
        public void setDayOfMonth(sbyte new_value)
          {
            flagHasDayOfMonth = true;
            if (new_value < 1)
                throw new Exception("The value for field DayOfMonth of TypeDate_0JSON is less than the lower bound (1) for that field.");
            if (new_value > 31)
                throw new Exception("The value for field DayOfMonth of TypeDate_0JSON is greater than the upper bound (31) for that field.");
            storeDayOfMonth = new_value;
          }
        public void unsetDayOfMonth()
          {
            flagHasDayOfMonth = false;
          }

        public virtual void extraTypeDate_0AppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeDate_0SetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeDate_0Lookup(key);
            if (old_field == null)
              {
                extraTypeDate_0AppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasYear);
            if (flagHasYear)
              {
                handler.start_pair("Year");
                handler.number_value(storeYear);
              }
            Debug.Assert(partial_allowed || flagHasMonth);
            if (flagHasMonth)
              {
                handler.start_pair("Month");
                handler.number_value(storeMonth);
              }
            Debug.Assert(partial_allowed || flagHasDayOfMonth);
            if (flagHasDayOfMonth)
              {
                handler.start_pair("DayOfMonth");
                handler.number_value(storeDayOfMonth);
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
            if (!(hasYear()))
              {
                return "When parsing the object for %what%, the \"Year\" field was missing.";
              }
            if (!(hasMonth()))
              {
                return "When parsing the object for %what%, the \"Month\" field was missing.";
              }
            if (!(hasDayOfMonth()))
              {
                return "When parsing the object for %what%, the \"DayOfMonth\" field was missing.";
              }
            return null;
          }

        public static TypeDate_0JSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDate_0JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDate_0", ignore_extras);
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
        public static TypeDate_0JSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDate_0JSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDate_0JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDate_0", ignore_extras);
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
        public static TypeDate_0JSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDate_0JSON from_text(string text, bool ignore_extras)
          {
            TypeDate_0JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDate_0", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDate_0JSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDate_0JSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDate_0JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDate_0", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorYear : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorYear(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorYear : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorYear(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorYear fieldGeneratorYear;
        private class FieldHoldingGeneratorMonth : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorMonth(String what) : base(what, 1, 12)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMonth : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorMonth(String what) : base(what, 1, 12)
                  {
                  }
              };
            private FieldHoldingGeneratorMonth fieldGeneratorMonth;
        private class FieldHoldingGeneratorDayOfMonth : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorDayOfMonth(String what) : base(what, 1, 31)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorDayOfMonth : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorDayOfMonth(String what) : base(what, 1, 31)
                  {
                  }
              };
            private FieldHoldingGeneratorDayOfMonth fieldGeneratorDayOfMonth;
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
                TypeDate_0JSON result = new TypeDate_0JSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeDate_0AppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeDate_0JSON result)
              {
                if (fieldGeneratorYear.have_value)
                  {
                    result.setYear(fieldGeneratorYear.value);
                    fieldGeneratorYear.have_value = false;
                  }
                else if ((!(result.hasYear())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Year\" field was missing.");
                  }
                if (fieldGeneratorMonth.have_value)
                  {
                    result.setMonth((sbyte)(fieldGeneratorMonth.value));
                    fieldGeneratorMonth.have_value = false;
                  }
                else if ((!(result.hasMonth())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Month\" field was missing.");
                  }
                if (fieldGeneratorDayOfMonth.have_value)
                  {
                    result.setDayOfMonth((sbyte)(fieldGeneratorDayOfMonth.value));
                    fieldGeneratorDayOfMonth.have_value = false;
                  }
                else if ((!(result.hasDayOfMonth())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"DayOfMonth\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeDate_0JSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "ayOfMonth", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorDayOfMonth;
                        break;
                    case 'M':
                        if ((String.Compare(field_name, 1, "onth", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorMonth;
                        break;
                    case 'Y':
                        if ((String.Compare(field_name, 1, "ear", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorYear;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeDate_0 class");
                fieldGeneratorMonth = new FieldHoldingGeneratorMonth("field \"Month\" of the TypeDate_0 class");
                fieldGeneratorDayOfMonth = new FieldHoldingGeneratorDayOfMonth("field \"DayOfMonth\" of the TypeDate_0 class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeDate_0 class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeDate_0 class");
                fieldGeneratorMonth = new FieldHoldingGeneratorMonth("field \"Month\" of the TypeDate_0 class");
                fieldGeneratorDayOfMonth = new FieldHoldingGeneratorDayOfMonth("field \"DayOfMonth\" of the TypeDate_0 class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeDate_0 class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorYear.reset();
                fieldGeneratorMonth.reset();
                fieldGeneratorDayOfMonth.reset();
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
            protected override void handle_result(TypeDate_0JSON  result)
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
            public TypeDate_0JSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDate_0JSON  result)
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
        protected virtual void handle_result(List<TypeDate_0JSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDate_0JSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDate_0JSON>();
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
        public List<TypeDate_0JSON> value;
      };
      };
    public class TypeDate_1JSON : JSONBase
      {
        public enum TypeSymbolic
          {
            Symbolic_unknown
          };

        public static TypeSymbolic  stringToSymbolic(string chars)
          {
            if ((String.Compare(chars, 0, "unknown", 0, 7, false) == 0) && (chars.Length == 7))
                return TypeSymbolic.Symbolic_unknown;
            throw new Exception("The value for field `Symbolic' is not one of the legal values.");
          }

        public static string  stringFromSymbolic(TypeSymbolic the_enum)
          {
            switch (the_enum)
              {
                case TypeSymbolic.Symbolic_unknown:
                    return "unknown";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasSymbolic;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONSymbolic(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Symbolic of TypeDate_1JSON is not a string.");
            if (!(json_string.getData().Equals("unknown")))
                throw new Exception("The value for field Symbolic of TypeDate_1JSON is not `unknown'.");
            setSymbolic();
          }


        public TypeDate_1JSON()
          {
            flagHasSymbolic = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasSymbolic()
          {
            return flagHasSymbolic;
          }

        public TypeSymbolic  getSymbolic()
          {
            Debug.Assert(flagHasSymbolic);
            return TypeSymbolic.Symbolic_unknown;
          }

        public string  getSymbolicAsString()
          {
            return stringFromSymbolic(getSymbolic());
          }


        public virtual int extraTypeDate_1ComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeDate_1ComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeDate_1ComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeDate_1Lookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setSymbolic()
          {
            flagHasSymbolic = true;
          }
        public void setSymbolic(TypeSymbolic new_value)
          {
            setSymbolic();
          }
        public void setSymbolic(string chars)
          {
            setSymbolic(stringToSymbolic(chars));
          }
        public void unsetSymbolic()
          {
            flagHasSymbolic = false;
          }

        public virtual void extraTypeDate_1AppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeDate_1SetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeDate_1Lookup(key);
            if (old_field == null)
              {
                extraTypeDate_1AppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasSymbolic);
            if (flagHasSymbolic)
              {
                handler.start_pair("Symbolic");
                handler.string_value("unknown");
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
            if (!(hasSymbolic()))
              {
                return "When parsing the object for %what%, the \"Symbolic\" field was missing.";
              }
            return null;
          }

        public static TypeDate_1JSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDate_1JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDate_1", ignore_extras);
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
        public static TypeDate_1JSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDate_1JSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDate_1JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDate_1", ignore_extras);
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
        public static TypeDate_1JSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDate_1JSON from_text(string text, bool ignore_extras)
          {
            TypeDate_1JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDate_1", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDate_1JSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDate_1JSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDate_1JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDate_1", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorSymbolic : JSONStringGenerator
              {
                protected FieldGeneratorSymbolic(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorSymbolic()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToSymbolic(result));
                  }
                protected abstract void handle_result(TypeSymbolic result);
              };
        private class FieldHoldingGeneratorSymbolic : FieldGeneratorSymbolic
      {
        protected override void handle_result(TypeSymbolic result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorSymbolic(String what)
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
        public TypeSymbolic value;
      };
        private class FieldHoldingArrayGeneratorSymbolic : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorSymbolic
          {
            private FieldHoldingArrayGeneratorSymbolic top;

            protected override void handle_result(TypeSymbolic result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorSymbolic init_top)
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
        protected virtual void handle_result(List<TypeSymbolic> result)
          {
          }

        public FieldHoldingArrayGeneratorSymbolic(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeSymbolic>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorSymbolic()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeSymbolic>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeSymbolic> value;
      };
            private FieldHoldingGeneratorSymbolic fieldGeneratorSymbolic;
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
                TypeDate_1JSON result = new TypeDate_1JSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeDate_1AppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeDate_1JSON result)
              {
                if (fieldGeneratorSymbolic.have_value)
                  {
                    result.setSymbolic();
                    fieldGeneratorSymbolic.have_value = false;
                  }
                else if ((!(result.hasSymbolic())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Symbolic\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeDate_1JSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Symbolic", 0, 8, false) == 0) && (field_name.Length == 8))
                    return fieldGeneratorSymbolic;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorSymbolic = new FieldHoldingGeneratorSymbolic("field \"Symbolic\" of the TypeDate_1 class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeDate_1 class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorSymbolic = new FieldHoldingGeneratorSymbolic("field \"Symbolic\" of the TypeDate_1 class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeDate_1 class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorSymbolic.reset();
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
            protected override void handle_result(TypeDate_1JSON  result)
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
            public TypeDate_1JSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDate_1JSON  result)
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
        protected virtual void handle_result(List<TypeDate_1JSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDate_1JSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDate_1JSON>();
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
        public List<TypeDate_1JSON> value;
      };
      };
    public struct TypeDate
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public TypeDate_0JSON  choice0;
            [FieldOffset(0)]
            public TypeDate_1JSON  choice1;
          };
        public Utype u;
      };
    public class TypeTime_0JSON : JSONBase
      {
        private bool flagHasHour;
        private sbyte storeHour;
        private bool flagHasAmPmUnknown;
        private bool storeAmPmUnknown;
        private bool flagHasMinute;
        private sbyte storeMinute;
        private bool flagHasSecond;
        private double storeSecond;
        private string textStoreSecond;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONHour(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Hour of TypeTime_0JSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Hour of TypeTime_0JSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setHour(extracted_integer);
          }


        private void  fromJSONAmPmUnknown(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field AmPmUnknown of TypeTime_0JSON is not true for false.");
                  }
              }
            setAmPmUnknown(the_bool);
          }


        private void  fromJSONMinute(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Minute of TypeTime_0JSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Minute of TypeTime_0JSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setMinute(extracted_integer);
          }


        private void  fromJSONSecond(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Second of TypeTime_0JSON is not a number.");
                  }
              }
            setSecondText(the_rational_text);
          }


        public TypeTime_0JSON()
          {
            flagHasHour = false;
            flagHasAmPmUnknown = false;
            flagHasMinute = false;
            flagHasSecond = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasHour()
          {
            return flagHasHour;
          }

        public sbyte  getHour()
          {
            Debug.Assert(flagHasHour);
            return storeHour;
          }

        public bool  hasAmPmUnknown()
          {
            return flagHasAmPmUnknown;
          }

        public bool  getAmPmUnknown()
          {
            Debug.Assert(flagHasAmPmUnknown);
            return storeAmPmUnknown;
          }

        public bool  hasMinute()
          {
            return flagHasMinute;
          }

        public sbyte  getMinute()
          {
            Debug.Assert(flagHasMinute);
            return storeMinute;
          }

        public bool  hasSecond()
          {
            return flagHasSecond;
          }

        public double  getSecond()
          {
            Debug.Assert(flagHasSecond);
            if (textStoreSecond != "")
              {
                return Double.Parse(textStoreSecond);
              }
            return storeSecond;
          }

        public string  getSecondAsText()
          {
            Debug.Assert(flagHasSecond);
            if (textStoreSecond == "")
              {
                return Convert.ToString(storeSecond);
              }
            else
              {
                return (textStoreSecond);
              }
          }


        public virtual int extraTypeTime_0ComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeTime_0ComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeTime_0ComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeTime_0Lookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setHour(sbyte new_value)
          {
            flagHasHour = true;
            if (new_value < 0)
                throw new Exception("The value for field Hour of TypeTime_0JSON is less than the lower bound (0) for that field.");
            if (new_value > 23)
                throw new Exception("The value for field Hour of TypeTime_0JSON is greater than the upper bound (23) for that field.");
            storeHour = new_value;
          }
        public void unsetHour()
          {
            flagHasHour = false;
          }
        public void setAmPmUnknown(bool new_value)
          {
            flagHasAmPmUnknown = true;
            storeAmPmUnknown = new_value;
          }
        public void unsetAmPmUnknown()
          {
            flagHasAmPmUnknown = false;
          }
        public void setMinute(sbyte new_value)
          {
            flagHasMinute = true;
            if (new_value < 0)
                throw new Exception("The value for field Minute of TypeTime_0JSON is less than the lower bound (0) for that field.");
            if (new_value > 59)
                throw new Exception("The value for field Minute of TypeTime_0JSON is greater than the upper bound (59) for that field.");
            storeMinute = new_value;
          }
        public void unsetMinute()
          {
            flagHasMinute = false;
          }
        public void setSecond(double new_value)
          {
            flagHasSecond = true;
            if (new_value < 0)
                throw new Exception("The value for field Second of TypeTime_0JSON is less than the lower bound (0) for that field.");
            if (new_value > 61)
                throw new Exception("The value for field Second of TypeTime_0JSON is greater than the upper bound (61) for that field.");
            storeSecond = new_value;
            textStoreSecond = "";
          }
        public void setSecondText(string new_value)
          {
            flagHasSecond = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Second of TypeTime_0JSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field Second of TypeTime_0JSON is less than the lower bound (0) for that field.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "61", "", false, "2") > 0)
                throw new Exception("The value for field Second of TypeTime_0JSON is greater than the upper bound (61) for that field.");
            textStoreSecond = new_value;
          }
        public void unsetSecond()
          {
            flagHasSecond = false;
          }

        public virtual void extraTypeTime_0AppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeTime_0SetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeTime_0Lookup(key);
            if (old_field == null)
              {
                extraTypeTime_0AppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasHour);
            if (flagHasHour)
              {
                handler.start_pair("Hour");
                handler.number_value(storeHour);
              }
            Debug.Assert(partial_allowed || flagHasAmPmUnknown);
            if (flagHasAmPmUnknown)
              {
                handler.start_pair("AmPmUnknown");
                handler.boolean_value(storeAmPmUnknown);
              }
            Debug.Assert(partial_allowed || flagHasMinute);
            if (flagHasMinute)
              {
                handler.start_pair("Minute");
                handler.number_value(storeMinute);
              }
            Debug.Assert(partial_allowed || flagHasSecond);
            if (flagHasSecond)
              {
                handler.start_pair("Second");
                if (textStoreSecond != "")
                    handler.number_value(textStoreSecond);
                else if (((double)(long)storeSecond) == storeSecond)
                    handler.number_value((long)storeSecond);
                else
                    handler.number_value(storeSecond);
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
            if (!(hasHour()))
              {
                return "When parsing the object for %what%, the \"Hour\" field was missing.";
              }
            if (!(hasAmPmUnknown()))
              {
                return "When parsing the object for %what%, the \"AmPmUnknown\" field was missing.";
              }
            if (!(hasMinute()))
              {
                return "When parsing the object for %what%, the \"Minute\" field was missing.";
              }
            if (!(hasSecond()))
              {
                return "When parsing the object for %what%, the \"Second\" field was missing.";
              }
            return null;
          }

        public static TypeTime_0JSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTime_0JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTime_0", ignore_extras);
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
        public static TypeTime_0JSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTime_0JSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTime_0JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTime_0", ignore_extras);
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
        public static TypeTime_0JSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTime_0JSON from_text(string text, bool ignore_extras)
          {
            TypeTime_0JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTime_0", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeTime_0JSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeTime_0JSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeTime_0JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTime_0", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorHour : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorHour(String what) : base(what, 0, 23)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorHour : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorHour(String what) : base(what, 0, 23)
                  {
                  }
              };
            private FieldHoldingGeneratorHour fieldGeneratorHour;
            private JSONHoldingBooleanGenerator fieldGeneratorAmPmUnknown;
        private class FieldHoldingGeneratorMinute : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorMinute(String what) : base(what, 0, 59)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMinute : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorMinute(String what) : base(what, 0, 59)
                  {
                  }
              };
            private FieldHoldingGeneratorMinute fieldGeneratorMinute;
            private JSONHoldingNumberTextGenerator fieldGeneratorSecond;
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
                TypeTime_0JSON result = new TypeTime_0JSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeTime_0AppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeTime_0JSON result)
              {
                if (fieldGeneratorHour.have_value)
                  {
                    result.setHour((sbyte)(fieldGeneratorHour.value));
                    fieldGeneratorHour.have_value = false;
                  }
                else if ((!(result.hasHour())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Hour\" field was missing.");
                  }
                if (fieldGeneratorAmPmUnknown.have_value)
                  {
                    result.setAmPmUnknown(fieldGeneratorAmPmUnknown.value);
                    fieldGeneratorAmPmUnknown.have_value = false;
                  }
                else if ((!(result.hasAmPmUnknown())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"AmPmUnknown\" field was missing.");
                  }
                if (fieldGeneratorMinute.have_value)
                  {
                    result.setMinute((sbyte)(fieldGeneratorMinute.value));
                    fieldGeneratorMinute.have_value = false;
                  }
                else if ((!(result.hasMinute())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Minute\" field was missing.");
                  }
                if (fieldGeneratorSecond.have_value)
                  {
                    result.setSecondText(fieldGeneratorSecond.value);
                    fieldGeneratorSecond.have_value = false;
                  }
                else if ((!(result.hasSecond())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Second\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeTime_0JSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "mPmUnknown", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorAmPmUnknown;
                        break;
                    case 'H':
                        if ((String.Compare(field_name, 1, "our", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorHour;
                        break;
                    case 'M':
                        if ((String.Compare(field_name, 1, "inute", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorMinute;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "econd", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorSecond;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorHour = new FieldHoldingGeneratorHour("field \"Hour\" of the TypeTime_0 class");
                fieldGeneratorAmPmUnknown = new JSONHoldingBooleanGenerator("field \"AmPmUnknown\" of the TypeTime_0 class");
                fieldGeneratorMinute = new FieldHoldingGeneratorMinute("field \"Minute\" of the TypeTime_0 class");
                fieldGeneratorSecond = new JSONHoldingNumberTextGenerator("field \"Second\" of the TypeTime_0 class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeTime_0 class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorHour = new FieldHoldingGeneratorHour("field \"Hour\" of the TypeTime_0 class");
                fieldGeneratorAmPmUnknown = new JSONHoldingBooleanGenerator("field \"AmPmUnknown\" of the TypeTime_0 class");
                fieldGeneratorMinute = new FieldHoldingGeneratorMinute("field \"Minute\" of the TypeTime_0 class");
                fieldGeneratorSecond = new JSONHoldingNumberTextGenerator("field \"Second\" of the TypeTime_0 class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeTime_0 class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorHour.reset();
                fieldGeneratorAmPmUnknown.reset();
                fieldGeneratorMinute.reset();
                fieldGeneratorSecond.reset();
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
            protected override void handle_result(TypeTime_0JSON  result)
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
            public TypeTime_0JSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeTime_0JSON  result)
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
        protected virtual void handle_result(List<TypeTime_0JSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeTime_0JSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeTime_0JSON>();
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
        public List<TypeTime_0JSON> value;
      };
      };
    public class TypeTime_1JSON : JSONBase
      {
        public enum TypeSymbolic
          {
            Symbolic_start_of_day,
            Symbolic_end_of_day,
            Symbolic_unknown
          };

        public static TypeSymbolic  stringToSymbolic(string chars)
          {
            switch (chars[0])
              {
                case 'e':
                    if ((String.Compare(chars, 1, "nd-of-day", 0, 9, false) == 0) && (chars.Length == 10))
                        return TypeSymbolic.Symbolic_end_of_day;
                    break;
                case 's':
                    if ((String.Compare(chars, 1, "tart-of-day", 0, 11, false) == 0) && (chars.Length == 12))
                        return TypeSymbolic.Symbolic_start_of_day;
                    break;
                case 'u':
                    if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeSymbolic.Symbolic_unknown;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `Symbolic' is not one of the legal values.");
          }

        public static string  stringFromSymbolic(TypeSymbolic the_enum)
          {
            switch (the_enum)
              {
                case TypeSymbolic.Symbolic_start_of_day:
                    return "start-of-day";
                case TypeSymbolic.Symbolic_end_of_day:
                    return "end-of-day";
                case TypeSymbolic.Symbolic_unknown:
                    return "unknown";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasSymbolic;
        private TypeSymbolic storeSymbolic;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONSymbolic(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Symbolic of TypeTime_1JSON is not a string.");
            TypeSymbolic the_enum;
            switch (json_string.getData()[0])
              {
                case 'e':
                    if ((String.Compare(json_string.getData(), 1, "nd-of-day", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                          {
                            the_enum = TypeSymbolic.Symbolic_end_of_day;
                            goto enum_is_done;
                          }
                    break;
                case 's':
                    if ((String.Compare(json_string.getData(), 1, "tart-of-day", 0, 11, false) == 0) && (json_string.getData().Length == 12))
                          {
                            the_enum = TypeSymbolic.Symbolic_start_of_day;
                            goto enum_is_done;
                          }
                    break;
                case 'u':
                    if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_enum = TypeSymbolic.Symbolic_unknown;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field Symbolic of TypeTime_1JSON is not one of the legal strings.");
          enum_is_done:;
            setSymbolic(the_enum);
          }


        public TypeTime_1JSON()
          {
            flagHasSymbolic = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasSymbolic()
          {
            return flagHasSymbolic;
          }

        public TypeSymbolic  getSymbolic()
          {
            Debug.Assert(flagHasSymbolic);
            return storeSymbolic;
          }

        public string  getSymbolicAsString()
          {
            return stringFromSymbolic(getSymbolic());
          }


        public virtual int extraTypeTime_1ComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeTime_1ComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeTime_1ComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeTime_1Lookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setSymbolic(TypeSymbolic new_value)
          {
            flagHasSymbolic = true;
            storeSymbolic = new_value;
          }
        public void setSymbolic(string chars)
          {
            setSymbolic(stringToSymbolic(chars));
          }
        public void unsetSymbolic()
          {
            flagHasSymbolic = false;
          }

        public virtual void extraTypeTime_1AppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeTime_1SetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeTime_1Lookup(key);
            if (old_field == null)
              {
                extraTypeTime_1AppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasSymbolic);
            if (flagHasSymbolic)
              {
                handler.start_pair("Symbolic");
                switch (storeSymbolic)
                  {
                    case TypeSymbolic.Symbolic_start_of_day:
                        handler.string_value("start-of-day");
                        break;
                    case TypeSymbolic.Symbolic_end_of_day:
                        handler.string_value("end-of-day");
                        break;
                    case TypeSymbolic.Symbolic_unknown:
                        handler.string_value("unknown");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
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
            if (!(hasSymbolic()))
              {
                return "When parsing the object for %what%, the \"Symbolic\" field was missing.";
              }
            return null;
          }

        public static TypeTime_1JSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTime_1JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTime_1", ignore_extras);
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
        public static TypeTime_1JSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTime_1JSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeTime_1JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTime_1", ignore_extras);
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
        public static TypeTime_1JSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeTime_1JSON from_text(string text, bool ignore_extras)
          {
            TypeTime_1JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTime_1", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeTime_1JSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeTime_1JSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeTime_1JSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeTime_1", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorSymbolic : JSONStringGenerator
              {
                protected FieldGeneratorSymbolic(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorSymbolic()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToSymbolic(result));
                  }
                protected abstract void handle_result(TypeSymbolic result);
              };
        private class FieldHoldingGeneratorSymbolic : FieldGeneratorSymbolic
      {
        protected override void handle_result(TypeSymbolic result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorSymbolic(String what)
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
        public TypeSymbolic value;
      };
        private class FieldHoldingArrayGeneratorSymbolic : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorSymbolic
          {
            private FieldHoldingArrayGeneratorSymbolic top;

            protected override void handle_result(TypeSymbolic result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorSymbolic init_top)
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
        protected virtual void handle_result(List<TypeSymbolic> result)
          {
          }

        public FieldHoldingArrayGeneratorSymbolic(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeSymbolic>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorSymbolic()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeSymbolic>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeSymbolic> value;
      };
            private FieldHoldingGeneratorSymbolic fieldGeneratorSymbolic;
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
                TypeTime_1JSON result = new TypeTime_1JSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeTime_1AppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeTime_1JSON result)
              {
                if (fieldGeneratorSymbolic.have_value)
                  {
                    result.setSymbolic(fieldGeneratorSymbolic.value);
                    fieldGeneratorSymbolic.have_value = false;
                  }
                else if ((!(result.hasSymbolic())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Symbolic\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeTime_1JSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Symbolic", 0, 8, false) == 0) && (field_name.Length == 8))
                    return fieldGeneratorSymbolic;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorSymbolic = new FieldHoldingGeneratorSymbolic("field \"Symbolic\" of the TypeTime_1 class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeTime_1 class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorSymbolic = new FieldHoldingGeneratorSymbolic("field \"Symbolic\" of the TypeTime_1 class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeTime_1 class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorSymbolic.reset();
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
            protected override void handle_result(TypeTime_1JSON  result)
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
            public TypeTime_1JSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeTime_1JSON  result)
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
        protected virtual void handle_result(List<TypeTime_1JSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeTime_1JSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeTime_1JSON>();
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
        public List<TypeTime_1JSON> value;
      };
      };
    public struct TypeTime
      {
        public int key;
        [StructLayout(LayoutKind.Explicit)]
        public struct Utype
          {
            [FieldOffset(0)]
            public TypeTime_0JSON  choice0;
            [FieldOffset(0)]
            public TypeTime_1JSON  choice1;
          };
        public Utype u;
      };
    private bool flagHasDate;
    private TypeDate storeDate;
    private bool flagHasTime;
    private TypeTime storeTime;
    private bool flagHasTimeZone;
    private string storeTimeZone;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeDate or_result = new TypeDate();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                TypeDate_0JSON convert_classy = TypeDate_0JSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice0 = convert_classy;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                TypeDate_1JSON convert_classy = TypeDate_1JSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice1 = convert_classy;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Date of DateAndOrTimeJSON is not one of the allowed values.");
        setDate(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeTime or_result = new TypeTime();
        bool or_done = false;
        if (!or_done)
          {
            try
              {
                TypeTime_0JSON convert_classy = TypeTime_0JSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice0 = convert_classy;
                or_result.key = 0;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
          {
            try
              {
                TypeTime_1JSON convert_classy = TypeTime_1JSON.from_json(json_value, ignore_extras, true);
                or_result.u.choice1 = convert_classy;
                or_result.key = 1;
                or_done = true;
              }
            catch (Exception )
              {
              }
          }
        if (!or_done)
            throw new Exception("The value for field Time of DateAndOrTimeJSON is not one of the allowed values.");
        setTime(or_result);
        switch (or_result.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
      }


    private void  fromJSONTimeZone(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TimeZone of DateAndOrTimeJSON is not a string.");
        setTimeZone(json_string.getData());
      }


    public DateAndOrTimeJSON()
      {
        flagHasDate = false;
        flagHasTime = false;
        flagHasTimeZone = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasDate()
      {
        return flagHasDate;
      }

    public TypeDate  getDate()
      {
        Debug.Assert(flagHasDate);
        return storeDate;
      }

    public bool  hasTime()
      {
        return flagHasTime;
      }

    public TypeTime  getTime()
      {
        Debug.Assert(flagHasTime);
        return storeTime;
      }

    public bool  hasTimeZone()
      {
        return flagHasTimeZone;
      }

    public string  getTimeZone()
      {
        Debug.Assert(flagHasTimeZone);
        return storeTimeZone;
      }


    public virtual int extraDateAndOrTimeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDateAndOrTimeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDateAndOrTimeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDateAndOrTimeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setDate(TypeDate new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHasDate)
          {
            switch (storeDate.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasDate = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeDate = new_value;
      }
    public void unsetDate()
      {
        if (flagHasDate)
          {
            switch (storeDate.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasDate = false;
      }
    public void setTime(TypeTime new_value)
      {
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        if (flagHasTime)
          {
            switch (storeTime.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasTime = true;
        switch (new_value.key)
          {
            case 0:
                break;
            case 1:
                break;
            default:
                Debug.Assert(false);
                break;
          }
        storeTime = new_value;
      }
    public void unsetTime()
      {
        if (flagHasTime)
          {
            switch (storeTime.key)
              {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        flagHasTime = false;
      }
    public void setTimeZone(string new_value)
      {
        flagHasTimeZone = true;
        storeTimeZone = new_value;
      }
    public void unsetTimeZone()
      {
        flagHasTimeZone = false;
      }

    public virtual void extraDateAndOrTimeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDateAndOrTimeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDateAndOrTimeLookup(key);
        if (old_field == null)
          {
            extraDateAndOrTimeAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasDate);
        if (flagHasDate)
          {
            handler.start_pair("Date");
            switch (storeDate.key)
              {
                case 0:
                    if (partial_allowed)
                        storeDate.u.choice0.write_partial_as_json(handler);
                    else
                        storeDate.u.choice0.write_as_json(handler);
                    break;
                case 1:
                    if (partial_allowed)
                        storeDate.u.choice1.write_partial_as_json(handler);
                    else
                        storeDate.u.choice1.write_as_json(handler);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasTime);
        if (flagHasTime)
          {
            handler.start_pair("Time");
            switch (storeTime.key)
              {
                case 0:
                    if (partial_allowed)
                        storeTime.u.choice0.write_partial_as_json(handler);
                    else
                        storeTime.u.choice0.write_as_json(handler);
                    break;
                case 1:
                    if (partial_allowed)
                        storeTime.u.choice1.write_partial_as_json(handler);
                    else
                        storeTime.u.choice1.write_as_json(handler);
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasTimeZone)
          {
            handler.start_pair("TimeZone");
            handler.string_value(storeTimeZone);
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
        if (!(hasDate()))
          {
            return "When parsing the object for %what%, the \"Date\" field was missing.";
          }
        if (!(hasTime()))
          {
            return "When parsing the object for %what%, the \"Time\" field was missing.";
          }
        return null;
      }

    public static DateAndOrTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateAndOrTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndOrTime", ignore_extras);
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
    public static DateAndOrTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DateAndOrTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DateAndOrTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndOrTime", ignore_extras);
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
    public static DateAndOrTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DateAndOrTimeJSON from_text(string text, bool ignore_extras)
      {
        DateAndOrTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndOrTime", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DateAndOrTimeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DateAndOrTimeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DateAndOrTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DateAndOrTime", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorDate : JSONParallelGenerator
          {
            private TypeDate_0JSON.HoldingGenerator field0;
            private TypeDate_1JSON.HoldingGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeDate result = new TypeDate();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeDate result);
            public FieldGeneratorDate(bool ignore_extras)
              {
                    field0 = new TypeDate_0JSON.HoldingGenerator("option 0 of field \"Date\"", ignore_extras);
                    field1 = new TypeDate_1JSON.HoldingGenerator("option 1 of field \"Date\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorDate(string what, bool ignore_extras)
              {
                    field0 = new TypeDate_0JSON.HoldingGenerator("option 0 of field \"Date\"", ignore_extras);
                    field1 = new TypeDate_1JSON.HoldingGenerator("option 1 of field \"Date\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderDate
          {
            private bool have_data;
            private TypeDate data;
            public HolderDate()  { have_data = false; }
            public HolderDate(TypeDate init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderDate(HolderDate other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeDate referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorDate : FieldGeneratorDate
          {
            protected override void handle_result(TypeDate result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderDate(result);
              }

            public FieldHoldingGeneratorDate(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderDate value;
          };
    private class FieldHoldingArrayGeneratorDate : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorDate
      {
        private FieldHoldingArrayGeneratorDate top;

        protected override void handle_result(TypeDate result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorDate init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeDate> result)
      {
      }

    public FieldHoldingArrayGeneratorDate(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDate>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorDate(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeDate>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeDate> value;
  };
        private FieldHoldingGeneratorDate fieldGeneratorDate;
    private abstract class FieldGeneratorTime : JSONParallelGenerator
          {
            private TypeTime_0JSON.HoldingGenerator field0;
            private TypeTime_1JSON.HoldingGenerator field1;
            private JSONHandler [] all_handlers = new JSONHandler [2];
            protected override JSONHandler[] start()
              {
                return all_handlers;
              }
            protected override void finish(int winning_index)
              {
                TypeTime result = new TypeTime();
                result.key = winning_index;
                switch (winning_index)
                  {
                    case 0:
                      {
                        Debug.Assert(field0.have_value);
                        result.u.choice0 = field0.value;
                        break;
                      }
                    case 1:
                      {
                        Debug.Assert(field1.have_value);
                        result.u.choice1 = field1.value;
                        break;
                      }
                    default:
                      {
                        Debug.Assert(false);
                        break;
                      }
                  }
                handle_result(result);
              }
            protected abstract void handle_result(TypeTime result);
            public FieldGeneratorTime(bool ignore_extras)
              {
                    field0 = new TypeTime_0JSON.HoldingGenerator("option 0 of field \"Time\"", ignore_extras);
                    field1 = new TypeTime_1JSON.HoldingGenerator("option 1 of field \"Time\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }
            public FieldGeneratorTime(string what, bool ignore_extras)
              {
                    field0 = new TypeTime_0JSON.HoldingGenerator("option 0 of field \"Time\"", ignore_extras);
                    field1 = new TypeTime_1JSON.HoldingGenerator("option 1 of field \"Time\"", ignore_extras);
                all_handlers[0] = field0;
                all_handlers[1] = field1;
              }

            public override void reset()
              {
                field0.reset();
                field1.reset();
                base.reset();
              }
          };
        private class HolderTime
          {
            private bool have_data;
            private TypeTime data;
            public HolderTime()  { have_data = false; }
            public HolderTime(TypeTime init_data)
              {
                have_data = true;
                data = init_data;
                if (have_data)
                  {
                  }
              }
            public HolderTime(HolderTime other)
              {
                have_data = other.haveData();
                data = other.referenced();
                if (have_data)
                  {
                  }
              }

            public bool haveData()
              {
                return have_data;
              }
            public TypeTime referenced()
              {
                return data;
              }
          };
    private class FieldHoldingGeneratorTime : FieldGeneratorTime
          {
            protected override void handle_result(TypeTime result)
              {
        //@@@        Debug.Assert(!have_value);
                have_value = true;
                value = new HolderTime(result);
              }

            public FieldHoldingGeneratorTime(String what, bool ignore_extras) : base(ignore_extras)
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
            public HolderTime value;
          };
    private class FieldHoldingArrayGeneratorTime : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorTime
      {
        private FieldHoldingArrayGeneratorTime top;

        protected override void handle_result(TypeTime result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorTime init_top, bool ignore_extras) : base(ignore_extras)
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
    protected virtual void handle_result(List<TypeTime> result)
      {
      }

    public FieldHoldingArrayGeneratorTime(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeTime>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorTime(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TypeTime>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeTime> value;
  };
        private FieldHoldingGeneratorTime fieldGeneratorTime;
        private JSONHoldingStringGenerator fieldGeneratorTimeZone;
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
            DateAndOrTimeJSON result = new DateAndOrTimeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDateAndOrTimeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DateAndOrTimeJSON result)
          {
            if (fieldGeneratorDate.have_value)
              {
                result.setDate(fieldGeneratorDate.value.referenced());
                fieldGeneratorDate.have_value = false;
              }
            else if ((!(result.hasDate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Date\" field was missing.");
              }
            if (fieldGeneratorTime.have_value)
              {
                result.setTime(fieldGeneratorTime.value.referenced());
                fieldGeneratorTime.have_value = false;
              }
            else if ((!(result.hasTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Time\" field was missing.");
              }
            if (fieldGeneratorTimeZone.have_value)
              {
                result.setTimeZone(fieldGeneratorTimeZone.value);
                fieldGeneratorTimeZone.have_value = false;
              }
          }
        protected abstract void handle_result(DateAndOrTimeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ate", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorDate;
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "ime", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorTime;
                          }
                        switch (field_name[4])
                          {
                            case 'Z':
                                if ((String.Compare(field_name, 5, "one", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorTimeZone;
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
            fieldGeneratorDate = new FieldHoldingGeneratorDate("field \"Date\" of the DateAndOrTime class", ignore_extras);
            fieldGeneratorTime = new FieldHoldingGeneratorTime("field \"Time\" of the DateAndOrTime class", ignore_extras);
            fieldGeneratorTimeZone = new JSONHoldingStringGenerator("field \"TimeZone\" of the DateAndOrTime class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DateAndOrTime class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorDate = new FieldHoldingGeneratorDate("field \"Date\" of the DateAndOrTime class", false);
            fieldGeneratorTime = new FieldHoldingGeneratorTime("field \"Time\" of the DateAndOrTime class", false);
            fieldGeneratorTimeZone = new JSONHoldingStringGenerator("field \"TimeZone\" of the DateAndOrTime class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DateAndOrTime class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorDate.reset();
            fieldGeneratorTime.reset();
            fieldGeneratorTimeZone.reset();
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
        protected override void handle_result(DateAndOrTimeJSON  result)
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
        public DateAndOrTimeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DateAndOrTimeJSON  result)
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
    protected virtual void handle_result(List<DateAndOrTimeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DateAndOrTimeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DateAndOrTimeJSON>();
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
    public List<DateAndOrTimeJSON> value;
  };
  };
