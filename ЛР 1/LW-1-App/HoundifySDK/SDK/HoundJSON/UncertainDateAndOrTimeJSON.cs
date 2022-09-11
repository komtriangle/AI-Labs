/* file "UncertainDateAndOrTimeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UncertainDateAndOrTimeJSON : DateAndOrTimeJSON
  {
    public class TypeUncertainDateJSON : JSONBase
      {
        private bool flagHasCentury;
        private BigInteger storeCentury;
        private bool flagHasColloquialDecade;
        private BigInteger storeColloquialDecade;
        private bool flagHasYear;
        private BigInteger storeYear;
        private bool flagHasMonth;
        private sbyte storeMonth;
        private bool flagHasDayOfMonth;
        private sbyte storeDayOfMonth;
        private bool flagHasIsCirca;
        private bool storeIsCirca;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONCentury(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Century of TypeUncertainDateJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Century of TypeUncertainDateJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setCentury(extracted_integer);
          }


        private void  fromJSONColloquialDecade(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field ColloquialDecade of TypeUncertainDateJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field ColloquialDecade of TypeUncertainDateJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setColloquialDecade(extracted_integer);
          }


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
                    throw new Exception("The value for field Year of TypeUncertainDateJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Year of TypeUncertainDateJSON is not an integer.");
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
                    throw new Exception("The value for field Month of TypeUncertainDateJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Month of TypeUncertainDateJSON is not an integer.");
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
                    throw new Exception("The value for field DayOfMonth of TypeUncertainDateJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field DayOfMonth of TypeUncertainDateJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setDayOfMonth(extracted_integer);
          }


        private void  fromJSONIsCirca(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field IsCirca of TypeUncertainDateJSON is not true for false.");
                  }
              }
            setIsCirca(the_bool);
          }


        public TypeUncertainDateJSON()
          {
            flagHasCentury = false;
            flagHasColloquialDecade = false;
            flagHasYear = false;
            flagHasMonth = false;
            flagHasDayOfMonth = false;
            flagHasIsCirca = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasCentury()
          {
            return flagHasCentury;
          }

        public BigInteger  getCentury()
          {
            Debug.Assert(flagHasCentury);
            return storeCentury;
          }

        public bool  hasColloquialDecade()
          {
            return flagHasColloquialDecade;
          }

        public BigInteger  getColloquialDecade()
          {
            Debug.Assert(flagHasColloquialDecade);
            return storeColloquialDecade;
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

        public bool  hasIsCirca()
          {
            return flagHasIsCirca;
          }

        public bool  getIsCirca()
          {
            Debug.Assert(flagHasIsCirca);
            return storeIsCirca;
          }


        public virtual int extraTypeUncertainDateComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeUncertainDateComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeUncertainDateComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeUncertainDateLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setCentury(BigInteger new_value)
          {
            flagHasCentury = true;
            storeCentury = new_value;
          }
        public void unsetCentury()
          {
            flagHasCentury = false;
          }
        public void setColloquialDecade(BigInteger new_value)
          {
            flagHasColloquialDecade = true;
            storeColloquialDecade = new_value;
          }
        public void unsetColloquialDecade()
          {
            flagHasColloquialDecade = false;
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
                throw new Exception("The value for field Month of TypeUncertainDateJSON is less than the lower bound (1) for that field.");
            if (new_value > 12)
                throw new Exception("The value for field Month of TypeUncertainDateJSON is greater than the upper bound (12) for that field.");
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
                throw new Exception("The value for field DayOfMonth of TypeUncertainDateJSON is less than the lower bound (1) for that field.");
            if (new_value > 31)
                throw new Exception("The value for field DayOfMonth of TypeUncertainDateJSON is greater than the upper bound (31) for that field.");
            storeDayOfMonth = new_value;
          }
        public void unsetDayOfMonth()
          {
            flagHasDayOfMonth = false;
          }
        public void setIsCirca(bool new_value)
          {
            flagHasIsCirca = true;
            storeIsCirca = new_value;
          }
        public void unsetIsCirca()
          {
            flagHasIsCirca = false;
          }

        public virtual void extraTypeUncertainDateAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeUncertainDateSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeUncertainDateLookup(key);
            if (old_field == null)
              {
                extraTypeUncertainDateAppendPair(key, new_component);
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
            if (flagHasCentury)
              {
                handler.start_pair("Century");
                handler.number_value(storeCentury);
              }
            if (flagHasColloquialDecade)
              {
                handler.start_pair("ColloquialDecade");
                handler.number_value(storeColloquialDecade);
              }
            if (flagHasYear)
              {
                handler.start_pair("Year");
                handler.number_value(storeYear);
              }
            if (flagHasMonth)
              {
                handler.start_pair("Month");
                handler.number_value(storeMonth);
              }
            if (flagHasDayOfMonth)
              {
                handler.start_pair("DayOfMonth");
                handler.number_value(storeDayOfMonth);
              }
            if (flagHasIsCirca)
              {
                handler.start_pair("IsCirca");
                handler.boolean_value(storeIsCirca);
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

        public static TypeUncertainDateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeUncertainDateJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUncertainDate", ignore_extras);
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
        public static TypeUncertainDateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeUncertainDateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeUncertainDateJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUncertainDate", ignore_extras);
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
        public static TypeUncertainDateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeUncertainDateJSON from_text(string text, bool ignore_extras)
          {
            TypeUncertainDateJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUncertainDate", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeUncertainDateJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeUncertainDateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeUncertainDateJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUncertainDate", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorCentury : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorCentury(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorCentury : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorCentury(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorCentury fieldGeneratorCentury;
        private class FieldHoldingGeneratorColloquialDecade : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorColloquialDecade(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorColloquialDecade : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorColloquialDecade(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorColloquialDecade fieldGeneratorColloquialDecade;
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
            private JSONHoldingBooleanGenerator fieldGeneratorIsCirca;
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
                TypeUncertainDateJSON result = new TypeUncertainDateJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeUncertainDateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeUncertainDateJSON result)
              {
                if (fieldGeneratorCentury.have_value)
                  {
                    result.setCentury(fieldGeneratorCentury.value);
                    fieldGeneratorCentury.have_value = false;
                  }
                if (fieldGeneratorColloquialDecade.have_value)
                  {
                    result.setColloquialDecade(fieldGeneratorColloquialDecade.value);
                    fieldGeneratorColloquialDecade.have_value = false;
                  }
                if (fieldGeneratorYear.have_value)
                  {
                    result.setYear(fieldGeneratorYear.value);
                    fieldGeneratorYear.have_value = false;
                  }
                if (fieldGeneratorMonth.have_value)
                  {
                    result.setMonth((sbyte)(fieldGeneratorMonth.value));
                    fieldGeneratorMonth.have_value = false;
                  }
                if (fieldGeneratorDayOfMonth.have_value)
                  {
                    result.setDayOfMonth((sbyte)(fieldGeneratorDayOfMonth.value));
                    fieldGeneratorDayOfMonth.have_value = false;
                  }
                if (fieldGeneratorIsCirca.have_value)
                  {
                    result.setIsCirca(fieldGeneratorIsCirca.value);
                    fieldGeneratorIsCirca.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeUncertainDateJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        switch (field_name[1])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 2, "ntury", 0, 5, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorCentury;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 2, "lloquialDecade", 0, 14, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorColloquialDecade;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'D':
                        if ((String.Compare(field_name, 1, "ayOfMonth", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorDayOfMonth;
                        break;
                    case 'I':
                        if ((String.Compare(field_name, 1, "sCirca", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorIsCirca;
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
                fieldGeneratorCentury = new FieldHoldingGeneratorCentury("field \"Century\" of the TypeUncertainDate class");
                fieldGeneratorColloquialDecade = new FieldHoldingGeneratorColloquialDecade("field \"ColloquialDecade\" of the TypeUncertainDate class");
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeUncertainDate class");
                fieldGeneratorMonth = new FieldHoldingGeneratorMonth("field \"Month\" of the TypeUncertainDate class");
                fieldGeneratorDayOfMonth = new FieldHoldingGeneratorDayOfMonth("field \"DayOfMonth\" of the TypeUncertainDate class");
                fieldGeneratorIsCirca = new JSONHoldingBooleanGenerator("field \"IsCirca\" of the TypeUncertainDate class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeUncertainDate class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorCentury = new FieldHoldingGeneratorCentury("field \"Century\" of the TypeUncertainDate class");
                fieldGeneratorColloquialDecade = new FieldHoldingGeneratorColloquialDecade("field \"ColloquialDecade\" of the TypeUncertainDate class");
                fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the TypeUncertainDate class");
                fieldGeneratorMonth = new FieldHoldingGeneratorMonth("field \"Month\" of the TypeUncertainDate class");
                fieldGeneratorDayOfMonth = new FieldHoldingGeneratorDayOfMonth("field \"DayOfMonth\" of the TypeUncertainDate class");
                fieldGeneratorIsCirca = new JSONHoldingBooleanGenerator("field \"IsCirca\" of the TypeUncertainDate class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeUncertainDate class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorCentury.reset();
                fieldGeneratorColloquialDecade.reset();
                fieldGeneratorYear.reset();
                fieldGeneratorMonth.reset();
                fieldGeneratorDayOfMonth.reset();
                fieldGeneratorIsCirca.reset();
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
            protected override void handle_result(TypeUncertainDateJSON  result)
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
            public TypeUncertainDateJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeUncertainDateJSON  result)
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
        protected virtual void handle_result(List<TypeUncertainDateJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeUncertainDateJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeUncertainDateJSON>();
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
        public List<TypeUncertainDateJSON> value;
      };
      };
    public class TypeUncertainTimeJSON : JSONBase
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
                    throw new Exception("The value for field Hour of TypeUncertainTimeJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Hour of TypeUncertainTimeJSON is not an integer.");
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
                    throw new Exception("The value for field AmPmUnknown of TypeUncertainTimeJSON is not true for false.");
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
                    throw new Exception("The value for field Minute of TypeUncertainTimeJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Minute of TypeUncertainTimeJSON is not an integer.");
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
                    throw new Exception("The value for field Second of TypeUncertainTimeJSON is not a number.");
                  }
              }
            setSecondText(the_rational_text);
          }


        public TypeUncertainTimeJSON()
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


        public virtual int extraTypeUncertainTimeComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeUncertainTimeComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeUncertainTimeComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeUncertainTimeLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setHour(sbyte new_value)
          {
            flagHasHour = true;
            if (new_value < 0)
                throw new Exception("The value for field Hour of TypeUncertainTimeJSON is less than the lower bound (0) for that field.");
            if (new_value > 23)
                throw new Exception("The value for field Hour of TypeUncertainTimeJSON is greater than the upper bound (23) for that field.");
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
                throw new Exception("The value for field Minute of TypeUncertainTimeJSON is less than the lower bound (0) for that field.");
            if (new_value > 59)
                throw new Exception("The value for field Minute of TypeUncertainTimeJSON is greater than the upper bound (59) for that field.");
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
                throw new Exception("The value for field Second of TypeUncertainTimeJSON is less than the lower bound (0) for that field.");
            if (new_value > 61)
                throw new Exception("The value for field Second of TypeUncertainTimeJSON is greater than the upper bound (61) for that field.");
            storeSecond = new_value;
            textStoreSecond = "";
          }
        public void setSecondText(string new_value)
          {
            flagHasSecond = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Second of TypeUncertainTimeJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field Second of TypeUncertainTimeJSON is less than the lower bound (0) for that field.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "61", "", false, "2") > 0)
                throw new Exception("The value for field Second of TypeUncertainTimeJSON is greater than the upper bound (61) for that field.");
            textStoreSecond = new_value;
          }
        public void unsetSecond()
          {
            flagHasSecond = false;
          }

        public virtual void extraTypeUncertainTimeAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeUncertainTimeSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeUncertainTimeLookup(key);
            if (old_field == null)
              {
                extraTypeUncertainTimeAppendPair(key, new_component);
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
            if (flagHasMinute)
              {
                handler.start_pair("Minute");
                handler.number_value(storeMinute);
              }
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
            return null;
          }

        public static TypeUncertainTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeUncertainTimeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUncertainTime", ignore_extras);
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
        public static TypeUncertainTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeUncertainTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeUncertainTimeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUncertainTime", ignore_extras);
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
        public static TypeUncertainTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeUncertainTimeJSON from_text(string text, bool ignore_extras)
          {
            TypeUncertainTimeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUncertainTime", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeUncertainTimeJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeUncertainTimeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeUncertainTimeJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeUncertainTime", ignore_extras);
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
                TypeUncertainTimeJSON result = new TypeUncertainTimeJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeUncertainTimeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeUncertainTimeJSON result)
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
                if (fieldGeneratorSecond.have_value)
                  {
                    result.setSecondText(fieldGeneratorSecond.value);
                    fieldGeneratorSecond.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeUncertainTimeJSON new_result);
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
                fieldGeneratorHour = new FieldHoldingGeneratorHour("field \"Hour\" of the TypeUncertainTime class");
                fieldGeneratorAmPmUnknown = new JSONHoldingBooleanGenerator("field \"AmPmUnknown\" of the TypeUncertainTime class");
                fieldGeneratorMinute = new FieldHoldingGeneratorMinute("field \"Minute\" of the TypeUncertainTime class");
                fieldGeneratorSecond = new JSONHoldingNumberTextGenerator("field \"Second\" of the TypeUncertainTime class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeUncertainTime class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorHour = new FieldHoldingGeneratorHour("field \"Hour\" of the TypeUncertainTime class");
                fieldGeneratorAmPmUnknown = new JSONHoldingBooleanGenerator("field \"AmPmUnknown\" of the TypeUncertainTime class");
                fieldGeneratorMinute = new FieldHoldingGeneratorMinute("field \"Minute\" of the TypeUncertainTime class");
                fieldGeneratorSecond = new JSONHoldingNumberTextGenerator("field \"Second\" of the TypeUncertainTime class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeUncertainTime class");
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
            protected override void handle_result(TypeUncertainTimeJSON  result)
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
            public TypeUncertainTimeJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeUncertainTimeJSON  result)
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
        protected virtual void handle_result(List<TypeUncertainTimeJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeUncertainTimeJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeUncertainTimeJSON>();
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
        public List<TypeUncertainTimeJSON> value;
      };
      };
    private bool flagHasUncertainDate;
    private TypeUncertainDateJSON  storeUncertainDate;
    private bool flagHasUncertainTime;
    private TypeUncertainTimeJSON  storeUncertainTime;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraUncertainDateToJSON()
      {
        JSONValueHandler handler_UncertainDate = new JSONValueHandler();
        storeUncertainDate.write_as_json(handler_UncertainDate);
        return handler_UncertainDate.result;
      }

    private JSONValue  extraUncertainTimeToJSON()
      {
        JSONValueHandler handler_UncertainTime = new JSONValueHandler();
        storeUncertainTime.write_as_json(handler_UncertainTime);
        return handler_UncertainTime.result;
      }


    private void  fromJSONUncertainDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeUncertainDateJSON convert_classy = TypeUncertainDateJSON.from_json(json_value, ignore_extras, true);
        setUncertainDate(convert_classy);
      }


    private void  fromJSONUncertainTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeUncertainTimeJSON convert_classy = TypeUncertainTimeJSON.from_json(json_value, ignore_extras, true);
        setUncertainTime(convert_classy);
      }


    public UncertainDateAndOrTimeJSON()
      {
        flagHasUncertainDate = false;
        flagHasUncertainTime = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasUncertainDate()
      {
        return flagHasUncertainDate;
      }

    public TypeUncertainDateJSON   getUncertainDate()
      {
        Debug.Assert(flagHasUncertainDate);
        return storeUncertainDate;
      }

    public bool  hasUncertainTime()
      {
        return flagHasUncertainTime;
      }

    public TypeUncertainTimeJSON   getUncertainTime()
      {
        Debug.Assert(flagHasUncertainTime);
        return storeUncertainTime;
      }


    public virtual int extraUncertainDateAndOrTimeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUncertainDateAndOrTimeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUncertainDateAndOrTimeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUncertainDateAndOrTimeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraDateAndOrTimeComponentCount()
      {
        int result = 0;
        if (flagHasUncertainDate)
            ++result;
        if (flagHasUncertainTime)
            ++result;
        result += extraUncertainDateAndOrTimeComponentCount();
        return result;
      }
    public override string extraDateAndOrTimeComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasUncertainDate)
          {
            if (remainder == 0)
                return "UncertainDate";
            --remainder;
          }
        if (flagHasUncertainTime)
          {
            if (remainder == 0)
                return "UncertainTime";
            --remainder;
          }
        return extraUncertainDateAndOrTimeComponentKey(remainder);
      }
    public override JSONValue extraDateAndOrTimeComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasUncertainDate)
          {
            if (remainder == 0)
                return extraUncertainDateToJSON();
            --remainder;
          }
        if (flagHasUncertainTime)
          {
            if (remainder == 0)
                return extraUncertainTimeToJSON();
            --remainder;
          }
        return extraUncertainDateAndOrTimeComponentValue(remainder);
      }
    public override JSONValue extraDateAndOrTimeLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "Uncertain", 0, 9, false) == 0)
          {
            switch (field_name[9])
              {
                case 'D':
                    if ((String.Compare(field_name, 10, "ate", 0, 3, false) == 0) && (field_name.Length == 13))
                        return (flagHasUncertainDate ? extraUncertainDateToJSON() : null);
                    break;
                case 'T':
                    if ((String.Compare(field_name, 10, "ime", 0, 3, false) == 0) && (field_name.Length == 13))
                        return (flagHasUncertainTime ? extraUncertainTimeToJSON() : null);
                    break;
                default:
                    break;
              }
          }
        return extraUncertainDateAndOrTimeLookup(field_name);
      }

    public void setUncertainDate(TypeUncertainDateJSON  new_value)
      {
        if (flagHasUncertainDate)
          {
          }
        flagHasUncertainDate = true;
        storeUncertainDate = new_value;
      }
    public void unsetUncertainDate()
      {
        if (flagHasUncertainDate)
          {
          }
        flagHasUncertainDate = false;
      }
    public void setUncertainTime(TypeUncertainTimeJSON  new_value)
      {
        if (flagHasUncertainTime)
          {
          }
        flagHasUncertainTime = true;
        storeUncertainTime = new_value;
      }
    public void unsetUncertainTime()
      {
        if (flagHasUncertainTime)
          {
          }
        flagHasUncertainTime = false;
      }

    public virtual void extraUncertainDateAndOrTimeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUncertainDateAndOrTimeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUncertainDateAndOrTimeLookup(key);
        if (old_field == null)
          {
            extraUncertainDateAndOrTimeAppendPair(key, new_component);
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
    public override void extraDateAndOrTimeAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Uncertain", 0, 9, false) == 0)
          {
            switch (key[9])
              {
                case 'D':
                    if ((String.Compare(key, 10, "ate", 0, 3, false) == 0) && (key.Length == 13))
                        {
                        fromJSONUncertainDate(new_component, false);
                        return;
                        }
                    break;
                case 'T':
                    if ((String.Compare(key, 10, "ime", 0, 3, false) == 0) && (key.Length == 13))
                        {
                        fromJSONUncertainTime(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraUncertainDateAndOrTimeAppendPair(key, new_component);
      }
    public override void extraDateAndOrTimeSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Uncertain", 0, 9, false) == 0)
          {
            switch (key[9])
              {
                case 'D':
                    if ((String.Compare(key, 10, "ate", 0, 3, false) == 0) && (key.Length == 13))
                        {
                        fromJSONUncertainDate(new_component, false);
                        return;
                        }
                    break;
                case 'T':
                    if ((String.Compare(key, 10, "ime", 0, 3, false) == 0) && (key.Length == 13))
                        {
                        fromJSONUncertainTime(new_component, false);
                        return;
                        }
                    break;
                default:
                    break;
              }
          }
        extraUncertainDateAndOrTimeSetField(key, new_component);
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
        if (flagHasUncertainDate)
          {
            handler.start_pair("UncertainDate");
            if (partial_allowed)
                storeUncertainDate.write_partial_as_json(handler);
            else
                storeUncertainDate.write_as_json(handler);
          }
        if (flagHasUncertainTime)
          {
            handler.start_pair("UncertainTime");
            if (partial_allowed)
                storeUncertainTime.write_partial_as_json(handler);
            else
                storeUncertainTime.write_as_json(handler);
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
        return null;
      }

    public static new UncertainDateAndOrTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UncertainDateAndOrTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UncertainDateAndOrTime", ignore_extras);
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
    public static new UncertainDateAndOrTimeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UncertainDateAndOrTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UncertainDateAndOrTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UncertainDateAndOrTime", ignore_extras);
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
    public static new UncertainDateAndOrTimeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UncertainDateAndOrTimeJSON from_text(string text, bool ignore_extras)
      {
        UncertainDateAndOrTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UncertainDateAndOrTime", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UncertainDateAndOrTimeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UncertainDateAndOrTimeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UncertainDateAndOrTimeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UncertainDateAndOrTime", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : DateAndOrTimeJSON.Generator
      {
        private TypeUncertainDateJSON.HoldingGenerator fieldGeneratorUncertainDate;
        private TypeUncertainTimeJSON.HoldingGenerator fieldGeneratorUncertainTime;
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
            UncertainDateAndOrTimeJSON result = new UncertainDateAndOrTimeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUncertainDateAndOrTimeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(DateAndOrTimeJSON new_result)
          {
            handle_result((UncertainDateAndOrTimeJSON )new_result);
          }
        protected void finish(UncertainDateAndOrTimeJSON result)
          {
            if (fieldGeneratorUncertainDate.have_value)
              {
                result.setUncertainDate(fieldGeneratorUncertainDate.value);
                fieldGeneratorUncertainDate.have_value = false;
              }
            if (fieldGeneratorUncertainTime.have_value)
              {
                result.setUncertainTime(fieldGeneratorUncertainTime.value);
                fieldGeneratorUncertainTime.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(UncertainDateAndOrTimeJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Uncertain", 0, 9, false) == 0)
              {
                switch (field_name[9])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 10, "ate", 0, 3, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorUncertainDate;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 10, "ime", 0, 3, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorUncertainTime;
                        break;
                    default:
                        break;
                  }
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorUncertainDate = new TypeUncertainDateJSON.HoldingGenerator("field \"UncertainDate\" of the UncertainDateAndOrTime class", ignore_extras);
            fieldGeneratorUncertainTime = new TypeUncertainTimeJSON.HoldingGenerator("field \"UncertainTime\" of the UncertainDateAndOrTime class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UncertainDateAndOrTime class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorUncertainDate = new TypeUncertainDateJSON.HoldingGenerator("field \"UncertainDate\" of the UncertainDateAndOrTime class", false);
            fieldGeneratorUncertainTime = new TypeUncertainTimeJSON.HoldingGenerator("field \"UncertainTime\" of the UncertainDateAndOrTime class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UncertainDateAndOrTime class");
          }

        public override void reset()
          {
            fieldGeneratorUncertainDate.reset();
            fieldGeneratorUncertainTime.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UncertainDateAndOrTimeJSON  result)
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
        public UncertainDateAndOrTimeJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UncertainDateAndOrTimeJSON  result)
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
    protected virtual void handle_result(List<UncertainDateAndOrTimeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UncertainDateAndOrTimeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UncertainDateAndOrTimeJSON>();
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
    public List<UncertainDateAndOrTimeJSON> value;
  };
    public static UncertainDateAndOrTimeJSON from_DateAndOrTimeJSON_json(DateAndOrTimeJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        UncertainDateAndOrTimeJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type UncertainDateAndOrTime", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
