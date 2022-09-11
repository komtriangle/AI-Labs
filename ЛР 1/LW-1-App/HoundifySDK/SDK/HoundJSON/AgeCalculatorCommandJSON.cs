/* file "AgeCalculatorCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class AgeCalculatorCommandJSON : CommandResultJSON
  {
    public class TypeAgesJSON : JSONBase
      {
        public enum TypeUnit
          {
            Unit_Years,
            Unit_Months,
            Unit_Weeks,
            Unit_Days,
            Unit_Hours,
            Unit_Minutes,
            Unit_Seconds,
            Unit_Unknown
          };

        public static TypeUnit  stringToUnit(string chars)
          {
            switch (chars[0])
              {
                case 'D':
                    if ((String.Compare(chars, 1, "ays", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeUnit.Unit_Days;
                    break;
                case 'H':
                    if ((String.Compare(chars, 1, "ours", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeUnit.Unit_Hours;
                    break;
                case 'M':
                    switch (chars[1])
                      {
                        case 'i':
                            if ((String.Compare(chars, 2, "nutes", 0, 5, false) == 0) && (chars.Length == 7))
                                return TypeUnit.Unit_Minutes;
                            break;
                        case 'o':
                            if ((String.Compare(chars, 2, "nths", 0, 4, false) == 0) && (chars.Length == 6))
                                return TypeUnit.Unit_Months;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(chars, 1, "econds", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeUnit.Unit_Seconds;
                    break;
                case 'U':
                    if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeUnit.Unit_Unknown;
                    break;
                case 'W':
                    if ((String.Compare(chars, 1, "eeks", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeUnit.Unit_Weeks;
                    break;
                case 'Y':
                    if ((String.Compare(chars, 1, "ears", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeUnit.Unit_Years;
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field `Unit' is not one of the legal values.");
          }

        public static string  stringFromUnit(TypeUnit the_enum)
          {
            switch (the_enum)
              {
                case TypeUnit.Unit_Years:
                    return "Years";
                case TypeUnit.Unit_Months:
                    return "Months";
                case TypeUnit.Unit_Weeks:
                    return "Weeks";
                case TypeUnit.Unit_Days:
                    return "Days";
                case TypeUnit.Unit_Hours:
                    return "Hours";
                case TypeUnit.Unit_Minutes:
                    return "Minutes";
                case TypeUnit.Unit_Seconds:
                    return "Seconds";
                case TypeUnit.Unit_Unknown:
                    return "Unknown";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasUnit;
        private TypeUnit storeUnit;
        private bool flagHasValue;
        private BigInteger storeValue;
        private bool flagHasValueIsInferred;
        private bool storeValueIsInferred;
        private bool flagHasWasRequested;
        private bool storeWasRequested;


        private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Unit of TypeAgesJSON is not a string.");
            TypeUnit the_enum;
            switch (json_string.getData()[0])
              {
                case 'D':
                    if ((String.Compare(json_string.getData(), 1, "ays", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeUnit.Unit_Days;
                            goto enum_is_done;
                          }
                    break;
                case 'H':
                    if ((String.Compare(json_string.getData(), 1, "ours", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeUnit.Unit_Hours;
                            goto enum_is_done;
                          }
                    break;
                case 'M':
                    switch (json_string.getData()[1])
                      {
                        case 'i':
                            if ((String.Compare(json_string.getData(), 2, "nutes", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_enum = TypeUnit.Unit_Minutes;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'o':
                            if ((String.Compare(json_string.getData(), 2, "nths", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_enum = TypeUnit.Unit_Months;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "econds", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_enum = TypeUnit.Unit_Seconds;
                            goto enum_is_done;
                          }
                    break;
                case 'U':
                    if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_enum = TypeUnit.Unit_Unknown;
                            goto enum_is_done;
                          }
                    break;
                case 'W':
                    if ((String.Compare(json_string.getData(), 1, "eeks", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeUnit.Unit_Weeks;
                            goto enum_is_done;
                          }
                    break;
                case 'Y':
                    if ((String.Compare(json_string.getData(), 1, "ears", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeUnit.Unit_Years;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for field Unit of TypeAgesJSON is not one of the legal strings.");
          enum_is_done:;
            setUnit(the_enum);
          }


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Value of TypeAgesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Value of TypeAgesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setValue(extracted_integer);
          }


        private void  fromJSONValueIsInferred(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field ValueIsInferred of TypeAgesJSON is not true for false.");
                  }
              }
            setValueIsInferred(the_bool);
          }


        private void  fromJSONWasRequested(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field WasRequested of TypeAgesJSON is not true for false.");
                  }
              }
            setWasRequested(the_bool);
          }


        public TypeAgesJSON()
          {
            flagHasUnit = false;
            flagHasValue = false;
            flagHasValueIsInferred = false;
            flagHasWasRequested = false;
          }

        public bool  hasUnit()
          {
            return flagHasUnit;
          }

        public TypeUnit  getUnit()
          {
            Debug.Assert(flagHasUnit);
            return storeUnit;
          }

        public string  getUnitAsString()
          {
            return stringFromUnit(getUnit());
          }

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public BigInteger  getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }

        public bool  hasValueIsInferred()
          {
            return flagHasValueIsInferred;
          }

        public bool  getValueIsInferred()
          {
            Debug.Assert(flagHasValueIsInferred);
            return storeValueIsInferred;
          }

        public bool  hasWasRequested()
          {
            return flagHasWasRequested;
          }

        public bool  getWasRequested()
          {
            Debug.Assert(flagHasWasRequested);
            return storeWasRequested;
          }



        public void setUnit(TypeUnit new_value)
          {
            flagHasUnit = true;
            storeUnit = new_value;
          }
        public void setUnit(string chars)
          {
            setUnit(stringToUnit(chars));
          }
        public void unsetUnit()
          {
            flagHasUnit = false;
          }
        public void setValue(BigInteger new_value)
          {
            flagHasValue = true;
            if (new_value < 0)
                throw new Exception("The value for field Value of TypeAgesJSON is less than the lower bound (0) for that field.");
            storeValue = new_value;
          }
        public void unsetValue()
          {
            flagHasValue = false;
          }
        public void setValueIsInferred(bool new_value)
          {
            flagHasValueIsInferred = true;
            storeValueIsInferred = new_value;
          }
        public void unsetValueIsInferred()
          {
            flagHasValueIsInferred = false;
          }
        public void setWasRequested(bool new_value)
          {
            flagHasWasRequested = true;
            storeWasRequested = new_value;
          }
        public void unsetWasRequested()
          {
            flagHasWasRequested = false;
          }


        public override void write_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler);
            handler.finish_object();
          }

        public virtual void write_fields_as_json(JSONHandler handler)
          {
            write_fields_as_json(handler, false);
          }

        public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
          {
            Debug.Assert(partial_allowed || flagHasUnit);
            if (flagHasUnit)
              {
                handler.start_pair("Unit");
                switch (storeUnit)
                  {
                    case TypeUnit.Unit_Years:
                        handler.string_value("Years");
                        break;
                    case TypeUnit.Unit_Months:
                        handler.string_value("Months");
                        break;
                    case TypeUnit.Unit_Weeks:
                        handler.string_value("Weeks");
                        break;
                    case TypeUnit.Unit_Days:
                        handler.string_value("Days");
                        break;
                    case TypeUnit.Unit_Hours:
                        handler.string_value("Hours");
                        break;
                    case TypeUnit.Unit_Minutes:
                        handler.string_value("Minutes");
                        break;
                    case TypeUnit.Unit_Seconds:
                        handler.string_value("Seconds");
                        break;
                    case TypeUnit.Unit_Unknown:
                        handler.string_value("Unknown");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                handler.number_value(storeValue);
              }
            if (flagHasValueIsInferred)
              {
                handler.start_pair("ValueIsInferred");
                handler.boolean_value(storeValueIsInferred);
              }
            if (flagHasWasRequested)
              {
                handler.start_pair("WasRequested");
                handler.boolean_value(storeWasRequested);
              }
          }
        public override void write_partial_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler, true);
            handler.finish_object();
          }
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasUnit()))
              {
                return "When parsing the object for %what%, the \"Unit\" field was missing.";
              }
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypeAgesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAgesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAges", ignore_extras);
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
        public static TypeAgesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAgesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeAgesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAges", ignore_extras);
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
        public static TypeAgesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeAgesJSON from_text(string text, bool ignore_extras)
          {
            TypeAgesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAges", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeAgesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeAgesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeAgesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeAges", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorUnit : JSONStringGenerator
              {
                protected FieldGeneratorUnit(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorUnit()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    handle_result(stringToUnit(result));
                  }
                protected abstract void handle_result(TypeUnit result);
              };
        private class FieldHoldingGeneratorUnit : FieldGeneratorUnit
      {
        protected override void handle_result(TypeUnit result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorUnit(String what)
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
        public TypeUnit value;
      };
        private class FieldHoldingArrayGeneratorUnit : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorUnit
          {
            private FieldHoldingArrayGeneratorUnit top;

            protected override void handle_result(TypeUnit result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorUnit init_top)
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
        protected virtual void handle_result(List<TypeUnit> result)
          {
          }

        public FieldHoldingArrayGeneratorUnit(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeUnit>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorUnit()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeUnit>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeUnit> value;
      };
            private FieldHoldingGeneratorUnit fieldGeneratorUnit;
        private class FieldHoldingGeneratorValue : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorValue(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorValue : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorValue(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorValue fieldGeneratorValue;
            private JSONHoldingBooleanGenerator fieldGeneratorValueIsInferred;
            private JSONHoldingBooleanGenerator fieldGeneratorWasRequested;

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
                string message = "";
                message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
                throw new Exception(message);
              }
            protected override void finish_field(string field_name, JSONHandler field_handler)
              {
              }
            protected override void finish()
              {
                TypeAgesJSON result = new TypeAgesJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeAgesJSON result)
              {
                if (fieldGeneratorUnit.have_value)
                  {
                    result.setUnit(fieldGeneratorUnit.value);
                    fieldGeneratorUnit.have_value = false;
                  }
                else if ((!(result.hasUnit())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Unit\" field was missing.");
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
                if (fieldGeneratorValueIsInferred.have_value)
                  {
                    result.setValueIsInferred(fieldGeneratorValueIsInferred.value);
                    fieldGeneratorValueIsInferred.have_value = false;
                  }
                if (fieldGeneratorWasRequested.have_value)
                  {
                    result.setWasRequested(fieldGeneratorWasRequested.value);
                    fieldGeneratorWasRequested.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeAgesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'U':
                        if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorUnit;
                        break;
                    case 'V':
                        if (String.Compare(field_name, 1, "alue", 0, 4, false) == 0)
                          {
                            if (field_name.Length == 5)
                              {
                                return fieldGeneratorValue;
                              }
                            switch (field_name[5])
                              {
                                case 'I':
                                    if ((String.Compare(field_name, 6, "sInferred", 0, 9, false) == 0) && (field_name.Length == 15))
                                        return fieldGeneratorValueIsInferred;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'W':
                        if ((String.Compare(field_name, 1, "asRequested", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorWasRequested;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeAges class");
                fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the TypeAges class");
                fieldGeneratorValueIsInferred = new JSONHoldingBooleanGenerator("field \"ValueIsInferred\" of the TypeAges class");
                fieldGeneratorWasRequested = new JSONHoldingBooleanGenerator("field \"WasRequested\" of the TypeAges class");
                set_what("the TypeAges class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the TypeAges class");
                fieldGeneratorValue = new FieldHoldingGeneratorValue("field \"Value\" of the TypeAges class");
                fieldGeneratorValueIsInferred = new JSONHoldingBooleanGenerator("field \"ValueIsInferred\" of the TypeAges class");
                fieldGeneratorWasRequested = new JSONHoldingBooleanGenerator("field \"WasRequested\" of the TypeAges class");
                set_what("the TypeAges class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorUnit.reset();
                fieldGeneratorValue.reset();
                fieldGeneratorValueIsInferred.reset();
                fieldGeneratorWasRequested.reset();
                base.reset();
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
            protected override void handle_result(TypeAgesJSON  result)
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
            public TypeAgesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeAgesJSON  result)
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
        protected virtual void handle_result(List<TypeAgesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeAgesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeAgesJSON>();
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
        public List<TypeAgesJSON> value;
      };
      };
    private bool flagHasBornDate;
    private DateAndOrTimeJSON  storeBornDate;
    private bool flagHasDestinationDate;
    private DateAndOrTimeJSON  storeDestinationDate;
    private bool flagHasDestinationIsNow;
    private bool storeDestinationIsNow;
    private bool flagHasDestinationIsToday;
    private bool storeDestinationIsToday;
    private bool flagHasNowDate;
    private DateAndOrTimeJSON  storeNowDate;
    private bool flagHasPerspective;
    private AgeCalculatorPerspectiveJSON  storePerspective;
    private bool flagHasAges;
    private List< TypeAgesJSON  > storeAges;


    private JSONValue  extraBornDateToJSON()
      {
        JSONValueHandler handler_BornDate = new JSONValueHandler();
        storeBornDate.write_as_json(handler_BornDate);
        return handler_BornDate.result;
      }

    private JSONValue  extraDestinationDateToJSON()
      {
        JSONValueHandler handler_DestinationDate = new JSONValueHandler();
        storeDestinationDate.write_as_json(handler_DestinationDate);
        return handler_DestinationDate.result;
      }

    private JSONValue  extraDestinationIsNowToJSON()
      {
        JSONValue generated_boolean_DestinationIsNow = (storeDestinationIsNow ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DestinationIsNow;
      }

    private JSONValue  extraDestinationIsTodayToJSON()
      {
        JSONValue generated_boolean_DestinationIsToday = (storeDestinationIsToday ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DestinationIsToday;
      }

    private JSONValue  extraNowDateToJSON()
      {
        JSONValueHandler handler_NowDate = new JSONValueHandler();
        storeNowDate.write_as_json(handler_NowDate);
        return handler_NowDate.result;
      }

    private JSONValue  extraPerspectiveToJSON()
      {
        JSONValueHandler handler_Perspective = new JSONValueHandler();
        storePerspective.write_as_json(handler_Perspective);
        return handler_Perspective.result;
      }

    private JSONValue  extraAgesToJSON()
      {
        JSONArrayValue generated_array_1_Ages = new JSONArrayValue();
        for (int num1 = 0; num1 < storeAges.Count; ++num1)
          {
            JSONValueHandler handler_Ages = new JSONValueHandler();
            storeAges[num1].write_as_json(handler_Ages);
            generated_array_1_Ages.appendComponent(handler_Ages.result);
          }
        return generated_array_1_Ages;
      }


    private void  fromJSONBornDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setBornDate(convert_classy);
      }


    private void  fromJSONDestinationDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setDestinationDate(convert_classy);
      }


    private void  fromJSONDestinationIsNow(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DestinationIsNow of AgeCalculatorCommandJSON is not true for false.");
              }
          }
        setDestinationIsNow(the_bool);
      }


    private void  fromJSONDestinationIsToday(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DestinationIsToday of AgeCalculatorCommandJSON is not true for false.");
              }
          }
        setDestinationIsToday(the_bool);
      }


    private void  fromJSONNowDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setNowDate(convert_classy);
      }


    private void  fromJSONPerspective(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AgeCalculatorPerspectiveJSON convert_classy = AgeCalculatorPerspectiveJSON.from_json(json_value, ignore_extras, true);
        setPerspective(convert_classy);
      }


    private void  fromJSONAges(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Ages of AgeCalculatorCommandJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeAgesJSON  > vector_Ages1 = new List< TypeAgesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeAgesJSON convert_classy = TypeAgesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Ages1.Add(convert_classy);
          }
        initAges();
        for (int num1 = 0; num1 < vector_Ages1.Count; ++num1)
            appendAges(vector_Ages1[num1]);
        for (int num1 = 0; num1 < vector_Ages1.Count; ++num1)
          {
          }
      }


    public AgeCalculatorCommandJSON()
      {
        flagHasBornDate = false;
        flagHasDestinationDate = false;
        flagHasDestinationIsNow = false;
        flagHasDestinationIsToday = false;
        flagHasNowDate = false;
        flagHasPerspective = false;
        flagHasAges = false;
        storeAges = new List< TypeAgesJSON  >();
      }

    public override string  getCommandKind()
      {
        return "AgeCalculatorCommand";
      }

    public bool  hasBornDate()
      {
        return flagHasBornDate;
      }

    public DateAndOrTimeJSON   getBornDate()
      {
        Debug.Assert(flagHasBornDate);
        return storeBornDate;
      }

    public bool  hasDestinationDate()
      {
        return flagHasDestinationDate;
      }

    public DateAndOrTimeJSON   getDestinationDate()
      {
        Debug.Assert(flagHasDestinationDate);
        return storeDestinationDate;
      }

    public bool  hasDestinationIsNow()
      {
        return flagHasDestinationIsNow;
      }

    public bool  getDestinationIsNow()
      {
        Debug.Assert(flagHasDestinationIsNow);
        return storeDestinationIsNow;
      }

    public bool  hasDestinationIsToday()
      {
        return flagHasDestinationIsToday;
      }

    public bool  getDestinationIsToday()
      {
        Debug.Assert(flagHasDestinationIsToday);
        return storeDestinationIsToday;
      }

    public bool  hasNowDate()
      {
        return flagHasNowDate;
      }

    public DateAndOrTimeJSON   getNowDate()
      {
        Debug.Assert(flagHasNowDate);
        return storeNowDate;
      }

    public bool  hasPerspective()
      {
        return flagHasPerspective;
      }

    public AgeCalculatorPerspectiveJSON   getPerspective()
      {
        Debug.Assert(flagHasPerspective);
        return storePerspective;
      }

    public AgeCalculatorPerspectiveJSON.TypeValue  getPerspectiveValue()
      {
        return getPerspective().getValue();
      }

    public string  getPerspectiveAsString()
      {
        return getPerspective().getValueAsString();
      }

    public bool  hasAges()
      {
        return flagHasAges;
      }

    public int  countOfAges()
      {
        Debug.Assert(flagHasAges);
        return storeAges.Count;
      }

    public TypeAgesJSON   elementOfAges(int element_num)
      {
        Debug.Assert(flagHasAges);
        return storeAges[element_num];
      }

    public List< TypeAgesJSON  >  getAges()
      {
        Debug.Assert(flagHasAges);
        return storeAges;
      }


    public override int extraCommandResultComponentCount()
      {
        int result = 0;
        if (flagHasBornDate)
            ++result;
        if (flagHasDestinationDate)
            ++result;
        if (flagHasDestinationIsNow)
            ++result;
        if (flagHasDestinationIsToday)
            ++result;
        if (flagHasNowDate)
            ++result;
        if (flagHasPerspective)
            ++result;
        if (flagHasAges)
            ++result;
        return result;
      }
    public override string extraCommandResultComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasBornDate)
          {
            if (remainder == 0)
                return "BornDate";
            --remainder;
          }
        if (flagHasDestinationDate)
          {
            if (remainder == 0)
                return "DestinationDate";
            --remainder;
          }
        if (flagHasDestinationIsNow)
          {
            if (remainder == 0)
                return "DestinationIsNow";
            --remainder;
          }
        if (flagHasDestinationIsToday)
          {
            if (remainder == 0)
                return "DestinationIsToday";
            --remainder;
          }
        if (flagHasNowDate)
          {
            if (remainder == 0)
                return "NowDate";
            --remainder;
          }
        if (flagHasPerspective)
          {
            if (remainder == 0)
                return "Perspective";
            --remainder;
          }
        if (flagHasAges)
          {
            if (remainder == 0)
                return "Ages";
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraCommandResultComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasBornDate)
          {
            if (remainder == 0)
                return extraBornDateToJSON();
            --remainder;
          }
        if (flagHasDestinationDate)
          {
            if (remainder == 0)
                return extraDestinationDateToJSON();
            --remainder;
          }
        if (flagHasDestinationIsNow)
          {
            if (remainder == 0)
                return extraDestinationIsNowToJSON();
            --remainder;
          }
        if (flagHasDestinationIsToday)
          {
            if (remainder == 0)
                return extraDestinationIsTodayToJSON();
            --remainder;
          }
        if (flagHasNowDate)
          {
            if (remainder == 0)
                return extraNowDateToJSON();
            --remainder;
          }
        if (flagHasPerspective)
          {
            if (remainder == 0)
                return extraPerspectiveToJSON();
            --remainder;
          }
        if (flagHasAges)
          {
            if (remainder == 0)
                return extraAgesToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraCommandResultLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "ges", 0, 3, false) == 0) && (field_name.Length == 4))
                    return (flagHasAges ? extraAgesToJSON() : null);
                break;
            case 'B':
                if ((String.Compare(field_name, 1, "ornDate", 0, 7, false) == 0) && (field_name.Length == 8))
                    return (flagHasBornDate ? extraBornDateToJSON() : null);
                break;
            case 'D':
                if (String.Compare(field_name, 1, "estination", 0, 10, false) == 0)
                  {
                    switch (field_name[11])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 12, "ate", 0, 3, false) == 0) && (field_name.Length == 15))
                                return (flagHasDestinationDate ? extraDestinationDateToJSON() : null);
                            break;
                        case 'I':
                            if (String.Compare(field_name, 12, "s", 0, 1, false) == 0)
                              {
                                switch (field_name[13])
                                  {
                                    case 'N':
                                        if ((String.Compare(field_name, 14, "ow", 0, 2, false) == 0) && (field_name.Length == 16))
                                            return (flagHasDestinationIsNow ? extraDestinationIsNowToJSON() : null);
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 14, "oday", 0, 4, false) == 0) && (field_name.Length == 18))
                                            return (flagHasDestinationIsToday ? extraDestinationIsTodayToJSON() : null);
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
            case 'N':
                if ((String.Compare(field_name, 1, "owDate", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasNowDate ? extraNowDateToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "erspective", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasPerspective ? extraPerspectiveToJSON() : null);
                break;
            default:
                break;
          }
        return null;
      }

    public void setBornDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasBornDate)
          {
          }
        flagHasBornDate = true;
        storeBornDate = new_value;
      }
    public void unsetBornDate()
      {
        if (flagHasBornDate)
          {
          }
        flagHasBornDate = false;
      }
    public void setDestinationDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasDestinationDate)
          {
          }
        flagHasDestinationDate = true;
        storeDestinationDate = new_value;
      }
    public void unsetDestinationDate()
      {
        if (flagHasDestinationDate)
          {
          }
        flagHasDestinationDate = false;
      }
    public void setDestinationIsNow(bool new_value)
      {
        flagHasDestinationIsNow = true;
        storeDestinationIsNow = new_value;
      }
    public void unsetDestinationIsNow()
      {
        flagHasDestinationIsNow = false;
      }
    public void setDestinationIsToday(bool new_value)
      {
        flagHasDestinationIsToday = true;
        storeDestinationIsToday = new_value;
      }
    public void unsetDestinationIsToday()
      {
        flagHasDestinationIsToday = false;
      }
    public void setNowDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasNowDate)
          {
          }
        flagHasNowDate = true;
        storeNowDate = new_value;
      }
    public void unsetNowDate()
      {
        if (flagHasNowDate)
          {
          }
        flagHasNowDate = false;
      }
    public void setPerspective(AgeCalculatorPerspectiveJSON  new_value)
      {
        if (flagHasPerspective)
          {
          }
        flagHasPerspective = true;
        storePerspective = new_value;
      }
    public void setPerspective(AgeCalculatorPerspectiveJSON.TypeValue new_value)
      {
        setPerspective(new AgeCalculatorPerspectiveJSON(new_value));
      }
    public void setPerspective(string chars)
      {
        setPerspective(new AgeCalculatorPerspectiveJSON(chars));
      }
    public void unsetPerspective()
      {
        if (flagHasPerspective)
          {
          }
        flagHasPerspective = false;
      }
    public void initAges()
      {
        if (flagHasAges)
          {
            for (int num1 = 0; num1 < storeAges.Count; ++num1)
              {
              }
          }
        flagHasAges = true;
        storeAges.Clear();
      }
    public void appendAges(TypeAgesJSON  to_append)
      {
        if (!flagHasAges)
          {
            flagHasAges = true;
            storeAges.Clear();
          }
        Debug.Assert(flagHasAges);
        storeAges.Add(to_append);
      }
    public void unsetAges()
      {
        if (flagHasAges)
          {
            for (int num2 = 0; num2 < storeAges.Count; ++num2)
              {
              }
          }
        flagHasAges = false;
        storeAges.Clear();
      }

    public override void extraCommandResultAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ges", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONAges(new_component, false);
                    return;
                    }
                break;
            case 'B':
                if ((String.Compare(key, 1, "ornDate", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONBornDate(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if (String.Compare(key, 1, "estination", 0, 10, false) == 0)
                  {
                    switch (key[11])
                      {
                        case 'D':
                            if ((String.Compare(key, 12, "ate", 0, 3, false) == 0) && (key.Length == 15))
                                {
                                fromJSONDestinationDate(new_component, false);
                                return;
                                }
                            break;
                        case 'I':
                            if (String.Compare(key, 12, "s", 0, 1, false) == 0)
                              {
                                switch (key[13])
                                  {
                                    case 'N':
                                        if ((String.Compare(key, 14, "ow", 0, 2, false) == 0) && (key.Length == 16))
                                            {
                                            fromJSONDestinationIsNow(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'T':
                                        if ((String.Compare(key, 14, "oday", 0, 4, false) == 0) && (key.Length == 18))
                                            {
                                            fromJSONDestinationIsToday(new_component, false);
                                            return;
                                            }
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
            case 'N':
                if ((String.Compare(key, 1, "owDate", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONNowDate(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "erspective", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONPerspective(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
      }
    public override void extraCommandResultSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "ges", 0, 3, false) == 0) && (key.Length == 4))
                    {
                    fromJSONAges(new_component, false);
                    return;
                    }
                break;
            case 'B':
                if ((String.Compare(key, 1, "ornDate", 0, 7, false) == 0) && (key.Length == 8))
                    {
                    fromJSONBornDate(new_component, false);
                    return;
                    }
                break;
            case 'D':
                if (String.Compare(key, 1, "estination", 0, 10, false) == 0)
                  {
                    switch (key[11])
                      {
                        case 'D':
                            if ((String.Compare(key, 12, "ate", 0, 3, false) == 0) && (key.Length == 15))
                                {
                                fromJSONDestinationDate(new_component, false);
                                return;
                                }
                            break;
                        case 'I':
                            if (String.Compare(key, 12, "s", 0, 1, false) == 0)
                              {
                                switch (key[13])
                                  {
                                    case 'N':
                                        if ((String.Compare(key, 14, "ow", 0, 2, false) == 0) && (key.Length == 16))
                                            {
                                            fromJSONDestinationIsNow(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'T':
                                        if ((String.Compare(key, 14, "oday", 0, 4, false) == 0) && (key.Length == 18))
                                            {
                                            fromJSONDestinationIsToday(new_component, false);
                                            return;
                                            }
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
            case 'N':
                if ((String.Compare(key, 1, "owDate", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONNowDate(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "erspective", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONPerspective(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasBornDate);
        if (flagHasBornDate)
          {
            handler.start_pair("BornDate");
            if (partial_allowed)
                storeBornDate.write_partial_as_json(handler);
            else
                storeBornDate.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDestinationDate);
        if (flagHasDestinationDate)
          {
            handler.start_pair("DestinationDate");
            if (partial_allowed)
                storeDestinationDate.write_partial_as_json(handler);
            else
                storeDestinationDate.write_as_json(handler);
          }
        if (flagHasDestinationIsNow)
          {
            handler.start_pair("DestinationIsNow");
            handler.boolean_value(storeDestinationIsNow);
          }
        if (flagHasDestinationIsToday)
          {
            handler.start_pair("DestinationIsToday");
            handler.boolean_value(storeDestinationIsToday);
          }
        if (flagHasNowDate)
          {
            handler.start_pair("NowDate");
            if (partial_allowed)
                storeNowDate.write_partial_as_json(handler);
            else
                storeNowDate.write_as_json(handler);
          }
        if (flagHasPerspective)
          {
            handler.start_pair("Perspective");
            if (partial_allowed)
                storePerspective.write_partial_as_json(handler);
            else
                storePerspective.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasAges);
        if (flagHasAges)
          {
            handler.start_pair("Ages");
            handler.start_array();
            for (int num1 = 0; num1 < storeAges.Count; ++num1)
              {
                if (partial_allowed)
                    storeAges[num1].write_partial_as_json(handler);
                else
                    storeAges[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasBornDate()))
          {
            return "When parsing the object for %what%, the \"BornDate\" field was missing.";
          }
        if (!(hasDestinationDate()))
          {
            return "When parsing the object for %what%, the \"DestinationDate\" field was missing.";
          }
        if (!(hasAges()))
          {
            return "When parsing the object for %what%, the \"Ages\" field was missing.";
          }
        return null;
      }

    public static new AgeCalculatorCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AgeCalculatorCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AgeCalculatorCommand", ignore_extras);
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
    public static new AgeCalculatorCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AgeCalculatorCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        AgeCalculatorCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AgeCalculatorCommand", ignore_extras);
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
    public static new AgeCalculatorCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new AgeCalculatorCommandJSON from_text(string text, bool ignore_extras)
      {
        AgeCalculatorCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AgeCalculatorCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for AgeCalculatorCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new AgeCalculatorCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        AgeCalculatorCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type AgeCalculatorCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandResultJSON.Generator
      {
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorBornDate;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorDestinationDate;
        private JSONHoldingBooleanGenerator fieldGeneratorDestinationIsNow;
        private JSONHoldingBooleanGenerator fieldGeneratorDestinationIsToday;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNowDate;
        private AgeCalculatorPerspectiveJSON.HoldingGenerator fieldGeneratorPerspective;
        private TypeAgesJSON.HoldingArrayGenerator fieldGeneratorAges;

        protected override void start()
          {
          }
        protected override JSONHandler start_field(string field_name)
          {
            JSONHandler result = start_known_field(field_name);
            if (result != null)
                return result;
            string message = "";
            message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
            throw new Exception(message);
          }
        protected override void finish_field(string field_name, JSONHandler field_handler)
          {
          }
        protected override void finish()
          {
            if (!(getCommandResultJSONKey().Equals("AgeCalculatorCommand")))
                throw new Exception("The key field has a value other than `AgeCalculatorCommand'.");
            AgeCalculatorCommandJSON result = new AgeCalculatorCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(CommandResultJSON new_result)
          {
            handle_result((AgeCalculatorCommandJSON )new_result);
          }
        protected void finish(AgeCalculatorCommandJSON result)
          {
            if (fieldGeneratorBornDate.have_value)
              {
                result.setBornDate(fieldGeneratorBornDate.value);
                fieldGeneratorBornDate.have_value = false;
              }
            else if ((!(result.hasBornDate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"BornDate\" field was missing.");
              }
            if (fieldGeneratorDestinationDate.have_value)
              {
                result.setDestinationDate(fieldGeneratorDestinationDate.value);
                fieldGeneratorDestinationDate.have_value = false;
              }
            else if ((!(result.hasDestinationDate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DestinationDate\" field was missing.");
              }
            if (fieldGeneratorDestinationIsNow.have_value)
              {
                result.setDestinationIsNow(fieldGeneratorDestinationIsNow.value);
                fieldGeneratorDestinationIsNow.have_value = false;
              }
            if (fieldGeneratorDestinationIsToday.have_value)
              {
                result.setDestinationIsToday(fieldGeneratorDestinationIsToday.value);
                fieldGeneratorDestinationIsToday.have_value = false;
              }
            if (fieldGeneratorNowDate.have_value)
              {
                result.setNowDate(fieldGeneratorNowDate.value);
                fieldGeneratorNowDate.have_value = false;
              }
            if (fieldGeneratorPerspective.have_value)
              {
                result.setPerspective(fieldGeneratorPerspective.value);
                fieldGeneratorPerspective.have_value = false;
              }
            if (fieldGeneratorAges.have_value)
              {
                result.initAges();
                int count = fieldGeneratorAges.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAges(fieldGeneratorAges.value[num]);
                  }
                fieldGeneratorAges.value.Clear();
                fieldGeneratorAges.have_value = false;
              }
            else if ((!(result.hasAges())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Ages\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(AgeCalculatorCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ges", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorAges;
                    break;
                case 'B':
                    if ((String.Compare(field_name, 1, "ornDate", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorBornDate;
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "estination", 0, 10, false) == 0)
                      {
                        switch (field_name[11])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 12, "ate", 0, 3, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorDestinationDate;
                                break;
                            case 'I':
                                if (String.Compare(field_name, 12, "s", 0, 1, false) == 0)
                                  {
                                    switch (field_name[13])
                                      {
                                        case 'N':
                                            if ((String.Compare(field_name, 14, "ow", 0, 2, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorDestinationIsNow;
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 14, "oday", 0, 4, false) == 0) && (field_name.Length == 18))
                                                return fieldGeneratorDestinationIsToday;
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
                case 'N':
                    if ((String.Compare(field_name, 1, "owDate", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorNowDate;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "erspective", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorPerspective;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorBornDate = new DateAndOrTimeJSON.HoldingGenerator("field \"BornDate\" of the AgeCalculatorCommand class", ignore_extras);
            fieldGeneratorDestinationDate = new DateAndOrTimeJSON.HoldingGenerator("field \"DestinationDate\" of the AgeCalculatorCommand class", ignore_extras);
            fieldGeneratorDestinationIsNow = new JSONHoldingBooleanGenerator("field \"DestinationIsNow\" of the AgeCalculatorCommand class");
            fieldGeneratorDestinationIsToday = new JSONHoldingBooleanGenerator("field \"DestinationIsToday\" of the AgeCalculatorCommand class");
            fieldGeneratorNowDate = new DateAndOrTimeJSON.HoldingGenerator("field \"NowDate\" of the AgeCalculatorCommand class", ignore_extras);
            fieldGeneratorPerspective = new AgeCalculatorPerspectiveJSON.HoldingGenerator("field \"Perspective\" of the AgeCalculatorCommand class", ignore_extras);
            fieldGeneratorAges = new TypeAgesJSON.HoldingArrayGenerator("field \"Ages\" of the AgeCalculatorCommand class", ignore_extras);
            set_what("the AgeCalculatorCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorBornDate = new DateAndOrTimeJSON.HoldingGenerator("field \"BornDate\" of the AgeCalculatorCommand class", false);
            fieldGeneratorDestinationDate = new DateAndOrTimeJSON.HoldingGenerator("field \"DestinationDate\" of the AgeCalculatorCommand class", false);
            fieldGeneratorDestinationIsNow = new JSONHoldingBooleanGenerator("field \"DestinationIsNow\" of the AgeCalculatorCommand class");
            fieldGeneratorDestinationIsToday = new JSONHoldingBooleanGenerator("field \"DestinationIsToday\" of the AgeCalculatorCommand class");
            fieldGeneratorNowDate = new DateAndOrTimeJSON.HoldingGenerator("field \"NowDate\" of the AgeCalculatorCommand class", false);
            fieldGeneratorPerspective = new AgeCalculatorPerspectiveJSON.HoldingGenerator("field \"Perspective\" of the AgeCalculatorCommand class", false);
            fieldGeneratorAges = new TypeAgesJSON.HoldingArrayGenerator("field \"Ages\" of the AgeCalculatorCommand class", false);
            set_what("the AgeCalculatorCommand class");
          }

        public override void reset()
          {
            fieldGeneratorBornDate.reset();
            fieldGeneratorDestinationDate.reset();
            fieldGeneratorDestinationIsNow.reset();
            fieldGeneratorDestinationIsToday.reset();
            fieldGeneratorNowDate.reset();
            fieldGeneratorPerspective.reset();
            fieldGeneratorAges.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(AgeCalculatorCommandJSON  result)
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
        public AgeCalculatorCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(AgeCalculatorCommandJSON  result)
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
    protected virtual void handle_result(List<AgeCalculatorCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<AgeCalculatorCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<AgeCalculatorCommandJSON>();
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
    public List<AgeCalculatorCommandJSON> value;
  };
  };
