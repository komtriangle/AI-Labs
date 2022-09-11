/* file "SportsGameJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public abstract class SportsGameJSON : JSONBase
  {
    public enum TypeStatusKnownValues
      {
        Status_Scheduled,
        Status_InProgress,
        Status_Complete,
        Status_Delayed,
        Status_DelayedWeather,
        Status_DelayedFacility,
        Status_Postponed,
        Status_Suspended,
        Status_Canceled,
        Status_Unnecessary,
        Status_ScheduledFlex,
        Status_ScheduledTimeTBD,
        Status_Unknown,
        Status__none
      };
    public struct TypeStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeStatusKnownValues list_value;
      };

    public static TypeStatusKnownValues  stringToStatus(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "nceled", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeStatusKnownValues.Status_Canceled;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "mplete", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeStatusKnownValues.Status_Complete;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if (String.Compare(chars, 1, "elayed", 0, 6, false) == 0)
                  {
                    if (chars.Length == 7)
                      {
                        return TypeStatusKnownValues.Status_Delayed;
                      }
                    switch (chars[7])
                      {
                        case 'F':
                            if ((String.Compare(chars, 8, "acility", 0, 7, false) == 0) && (chars.Length == 15))
                                return TypeStatusKnownValues.Status_DelayedFacility;
                            break;
                        case 'W':
                            if ((String.Compare(chars, 8, "eather", 0, 6, false) == 0) && (chars.Length == 14))
                                return TypeStatusKnownValues.Status_DelayedWeather;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nProgress", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeStatusKnownValues.Status_InProgress;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "ostponed", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeStatusKnownValues.Status_Postponed;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'c':
                        if (String.Compare(chars, 2, "heduled", 0, 7, false) == 0)
                          {
                            if (chars.Length == 9)
                              {
                                return TypeStatusKnownValues.Status_Scheduled;
                              }
                            switch (chars[9])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 10, "lex", 0, 3, false) == 0) && (chars.Length == 13))
                                        return TypeStatusKnownValues.Status_ScheduledFlex;
                                    break;
                                case 'T':
                                    if ((String.Compare(chars, 10, "imeTBD", 0, 6, false) == 0) && (chars.Length == 16))
                                        return TypeStatusKnownValues.Status_ScheduledTimeTBD;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "spended", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeStatusKnownValues.Status_Suspended;
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if (String.Compare(chars, 1, "n", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'k':
                            if ((String.Compare(chars, 3, "nown", 0, 4, false) == 0) && (chars.Length == 7))
                                return TypeStatusKnownValues.Status_Unknown;
                            break;
                        case 'n':
                            if ((String.Compare(chars, 3, "ecessary", 0, 8, false) == 0) && (chars.Length == 11))
                                return TypeStatusKnownValues.Status_Unnecessary;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeStatusKnownValues.Status__none;
      }

    public static string  stringFromStatus(TypeStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeStatusKnownValues.Status_Scheduled:
                return "Scheduled";
            case TypeStatusKnownValues.Status_InProgress:
                return "InProgress";
            case TypeStatusKnownValues.Status_Complete:
                return "Complete";
            case TypeStatusKnownValues.Status_Delayed:
                return "Delayed";
            case TypeStatusKnownValues.Status_DelayedWeather:
                return "DelayedWeather";
            case TypeStatusKnownValues.Status_DelayedFacility:
                return "DelayedFacility";
            case TypeStatusKnownValues.Status_Postponed:
                return "Postponed";
            case TypeStatusKnownValues.Status_Suspended:
                return "Suspended";
            case TypeStatusKnownValues.Status_Canceled:
                return "Canceled";
            case TypeStatusKnownValues.Status_Unnecessary:
                return "Unnecessary";
            case TypeStatusKnownValues.Status_ScheduledFlex:
                return "ScheduledFlex";
            case TypeStatusKnownValues.Status_ScheduledTimeTBD:
                return "ScheduledTimeTBD";
            case TypeStatusKnownValues.Status_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeClockJSON : JSONBase
      {
        public enum TypeCountDirectionKnownValues
          {
            CountDirection_CountDown,
            CountDirection_CountUp,
            CountDirection__none
          };
        public struct TypeCountDirection
          {
            public bool in_known_list;
            public string string_value;
            public TypeCountDirectionKnownValues list_value;
          };

        public static TypeCountDirectionKnownValues  stringToCountDirection(string chars)
          {
            if (String.Compare(chars, 0, "Count", 0, 5, false) == 0)
              {
                switch (chars[5])
                  {
                    case 'D':
                        if ((String.Compare(chars, 6, "own", 0, 3, false) == 0) && (chars.Length == 9))
                            return TypeCountDirectionKnownValues.CountDirection_CountDown;
                        break;
                    case 'U':
                        if ((String.Compare(chars, 6, "p", 0, 1, false) == 0) && (chars.Length == 7))
                            return TypeCountDirectionKnownValues.CountDirection_CountUp;
                        break;
                    default:
                        break;
                  }
              }
            return TypeCountDirectionKnownValues.CountDirection__none;
          }

        public static string  stringFromCountDirection(TypeCountDirectionKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeCountDirectionKnownValues.CountDirection_CountDown:
                    return "CountDown";
                case TypeCountDirectionKnownValues.CountDirection_CountUp:
                    return "CountUp";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasMinutes;
        private BigInteger storeMinutes;
        private bool flagHasSeconds;
        private sbyte storeSeconds;
        private bool flagHasCountDirection;
        private TypeCountDirection storeCountDirection;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONMinutes(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Minutes of TypeClockJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Minutes of TypeClockJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setMinutes(extracted_integer);
          }


        private void  fromJSONSeconds(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Seconds of TypeClockJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Seconds of TypeClockJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setSeconds(extracted_integer);
          }


        private void  fromJSONCountDirection(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field CountDirection of TypeClockJSON is not a string.");
            TypeCountDirection the_open_enum = new TypeCountDirection();
            if (String.Compare(json_string.getData(), 0, "Count", 0, 5, false) == 0)
              {
                switch (json_string.getData()[5])
                  {
                    case 'D':
                        if ((String.Compare(json_string.getData(), 6, "own", 0, 3, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCountDirectionKnownValues.CountDirection_CountDown;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'U':
                        if ((String.Compare(json_string.getData(), 6, "p", 0, 1, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeCountDirectionKnownValues.CountDirection_CountUp;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setCountDirection(the_open_enum);
          }


        public TypeClockJSON()
          {
            flagHasMinutes = false;
            flagHasSeconds = false;
            flagHasCountDirection = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasMinutes()
          {
            return flagHasMinutes;
          }

        public BigInteger  getMinutes()
          {
            Debug.Assert(flagHasMinutes);
            return storeMinutes;
          }

        public bool  hasSeconds()
          {
            return flagHasSeconds;
          }

        public sbyte  getSeconds()
          {
            Debug.Assert(flagHasSeconds);
            return storeSeconds;
          }

        public bool  hasCountDirection()
          {
            return flagHasCountDirection;
          }

        public TypeCountDirection  getCountDirection()
          {
            Debug.Assert(flagHasCountDirection);
            return storeCountDirection;
          }

        public string  getCountDirectionAsString()
          {
            TypeCountDirection result = getCountDirection();
            if (result.in_known_list)
                return stringFromCountDirection(result.list_value);
            else
                return result.string_value;
          }


        public virtual int extraTypeClockComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeClockComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeClockComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeClockLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setMinutes(BigInteger new_value)
          {
            flagHasMinutes = true;
            if (new_value < 0)
                throw new Exception("The value for field Minutes of TypeClockJSON is less than the lower bound (0) for that field.");
            storeMinutes = new_value;
          }
        public void unsetMinutes()
          {
            flagHasMinutes = false;
          }
        public void setSeconds(sbyte new_value)
          {
            flagHasSeconds = true;
            if (new_value < 0)
                throw new Exception("The value for field Seconds of TypeClockJSON is less than the lower bound (0) for that field.");
            if (new_value > 59)
                throw new Exception("The value for field Seconds of TypeClockJSON is greater than the upper bound (59) for that field.");
            storeSeconds = new_value;
          }
        public void unsetSeconds()
          {
            flagHasSeconds = false;
          }
        public void setCountDirection(TypeCountDirection new_value)
          {
            flagHasCountDirection = true;
            storeCountDirection = new_value;
          }
        public void setCountDirection(string chars)
          {
            TypeCountDirectionKnownValues known = stringToCountDirection(chars);
            TypeCountDirection new_value = new TypeCountDirection();
            if (known == TypeCountDirectionKnownValues.CountDirection__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setCountDirection(new_value);
          }
        public void setCountDirection(TypeCountDirectionKnownValues new_value)
          {
            TypeCountDirection new_full_value = new TypeCountDirection();
            Debug.Assert(new_value != TypeCountDirectionKnownValues.CountDirection__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setCountDirection(new_full_value);
          }
        public void unsetCountDirection()
          {
            flagHasCountDirection = false;
          }

        public virtual void extraTypeClockAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeClockSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeClockLookup(key);
            if (old_field == null)
              {
                extraTypeClockAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasMinutes);
            if (flagHasMinutes)
              {
                handler.start_pair("Minutes");
                handler.number_value(storeMinutes);
              }
            Debug.Assert(partial_allowed || flagHasSeconds);
            if (flagHasSeconds)
              {
                handler.start_pair("Seconds");
                handler.number_value(storeSeconds);
              }
            if (flagHasCountDirection)
              {
                handler.start_pair("CountDirection");
                if (storeCountDirection.in_known_list)
                  {
                    switch (storeCountDirection.list_value)
                      {
                        case TypeCountDirectionKnownValues.CountDirection_CountDown:
                            handler.string_value("CountDown");
                            break;
                        case TypeCountDirectionKnownValues.CountDirection_CountUp:
                            handler.string_value("CountUp");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeCountDirection.string_value);
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
            if (!(hasMinutes()))
              {
                return "When parsing the object for %what%, the \"Minutes\" field was missing.";
              }
            if (!(hasSeconds()))
              {
                return "When parsing the object for %what%, the \"Seconds\" field was missing.";
              }
            return null;
          }

        public static TypeClockJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeClockJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeClock", ignore_extras);
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
        public static TypeClockJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeClockJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeClockJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeClock", ignore_extras);
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
        public static TypeClockJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeClockJSON from_text(string text, bool ignore_extras)
          {
            TypeClockJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeClock", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeClockJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeClockJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeClockJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeClock", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorMinutes : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorMinutes(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMinutes : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorMinutes(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorMinutes fieldGeneratorMinutes;
        private class FieldHoldingGeneratorSeconds : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorSeconds(String what) : base(what, 0, 59)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorSeconds : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorSeconds(String what) : base(what, 0, 59)
                  {
                  }
              };
            private FieldHoldingGeneratorSeconds fieldGeneratorSeconds;
        private abstract class FieldGeneratorCountDirection : JSONStringGenerator
              {
                protected FieldGeneratorCountDirection(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorCountDirection()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeCountDirectionKnownValues known = stringToCountDirection(result);
                    TypeCountDirection new_value = new TypeCountDirection();
                    if (known == TypeCountDirectionKnownValues.CountDirection__none)
                      {
                        new_value.in_known_list = false;
                        new_value.string_value = result;
                      }
                    else
                      {
                        new_value.in_known_list = true;
                        new_value.list_value = known;
                      }
                    handle_result(new_value);
                  }
                protected abstract void handle_result(TypeCountDirection result);
              };
        private class FieldHoldingGeneratorCountDirection : FieldGeneratorCountDirection
      {
        protected override void handle_result(TypeCountDirection result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorCountDirection(String what)
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
        public TypeCountDirection value;
      };
        private class FieldHoldingArrayGeneratorCountDirection : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorCountDirection
          {
            private FieldHoldingArrayGeneratorCountDirection top;

            protected override void handle_result(TypeCountDirection result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorCountDirection init_top)
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
        protected virtual void handle_result(List<TypeCountDirection> result)
          {
          }

        public FieldHoldingArrayGeneratorCountDirection(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeCountDirection>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorCountDirection()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeCountDirection>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeCountDirection> value;
      };
            private FieldHoldingGeneratorCountDirection fieldGeneratorCountDirection;
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
                TypeClockJSON result = new TypeClockJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeClockAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeClockJSON result)
              {
                if (fieldGeneratorMinutes.have_value)
                  {
                    result.setMinutes(fieldGeneratorMinutes.value);
                    fieldGeneratorMinutes.have_value = false;
                  }
                else if ((!(result.hasMinutes())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Minutes\" field was missing.");
                  }
                if (fieldGeneratorSeconds.have_value)
                  {
                    result.setSeconds((sbyte)(fieldGeneratorSeconds.value));
                    fieldGeneratorSeconds.have_value = false;
                  }
                else if ((!(result.hasSeconds())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Seconds\" field was missing.");
                  }
                if (fieldGeneratorCountDirection.have_value)
                  {
                    result.setCountDirection(fieldGeneratorCountDirection.value);
                    fieldGeneratorCountDirection.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeClockJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "ountDirection", 0, 13, false) == 0) && (field_name.Length == 14))
                            return fieldGeneratorCountDirection;
                        break;
                    case 'M':
                        if ((String.Compare(field_name, 1, "inutes", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorMinutes;
                        break;
                    case 'S':
                        if ((String.Compare(field_name, 1, "econds", 0, 6, false) == 0) && (field_name.Length == 7))
                            return fieldGeneratorSeconds;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorMinutes = new FieldHoldingGeneratorMinutes("field \"Minutes\" of the TypeClock class");
                fieldGeneratorSeconds = new FieldHoldingGeneratorSeconds("field \"Seconds\" of the TypeClock class");
                fieldGeneratorCountDirection = new FieldHoldingGeneratorCountDirection("field \"CountDirection\" of the TypeClock class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeClock class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorMinutes = new FieldHoldingGeneratorMinutes("field \"Minutes\" of the TypeClock class");
                fieldGeneratorSeconds = new FieldHoldingGeneratorSeconds("field \"Seconds\" of the TypeClock class");
                fieldGeneratorCountDirection = new FieldHoldingGeneratorCountDirection("field \"CountDirection\" of the TypeClock class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeClock class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorMinutes.reset();
                fieldGeneratorSeconds.reset();
                fieldGeneratorCountDirection.reset();
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
            protected override void handle_result(TypeClockJSON  result)
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
            public TypeClockJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeClockJSON  result)
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
        protected virtual void handle_result(List<TypeClockJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeClockJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeClockJSON>();
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
        public List<TypeClockJSON> value;
      };
      };
    public enum TypeBaseballInningHalfKnownValues
      {
        BaseballInningHalf_Top,
        BaseballInningHalf_Middle,
        BaseballInningHalf_Bottom,
        BaseballInningHalf__none
      };
    public struct TypeBaseballInningHalf
      {
        public bool in_known_list;
        public string string_value;
        public TypeBaseballInningHalfKnownValues list_value;
      };

    public static TypeBaseballInningHalfKnownValues  stringToBaseballInningHalf(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "ottom", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeBaseballInningHalfKnownValues.BaseballInningHalf_Bottom;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "iddle", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeBaseballInningHalfKnownValues.BaseballInningHalf_Middle;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "op", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeBaseballInningHalfKnownValues.BaseballInningHalf_Top;
                break;
            default:
                break;
          }
        return TypeBaseballInningHalfKnownValues.BaseballInningHalf__none;
      }

    public static string  stringFromBaseballInningHalf(TypeBaseballInningHalfKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeBaseballInningHalfKnownValues.BaseballInningHalf_Top:
                return "Top";
            case TypeBaseballInningHalfKnownValues.BaseballInningHalf_Middle:
                return "Middle";
            case TypeBaseballInningHalfKnownValues.BaseballInningHalf_Bottom:
                return "Bottom";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypePlayersJSON : JSONBase
      {
        private bool flagHasPlayer;
        private SportsPlayerJSON  storePlayer;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONPlayer(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsPlayerJSON convert_classy = SportsPlayerJSON.from_json(json_value, ignore_extras, true);
            setPlayer(convert_classy);
          }


        public TypePlayersJSON()
          {
            flagHasPlayer = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasPlayer()
          {
            return flagHasPlayer;
          }

        public SportsPlayerJSON   getPlayer()
          {
            Debug.Assert(flagHasPlayer);
            return storePlayer;
          }


        public virtual int extraTypePlayersComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePlayersComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePlayersComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePlayersLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setPlayer(SportsPlayerJSON  new_value)
          {
            if (flagHasPlayer)
              {
              }
            flagHasPlayer = true;
            storePlayer = new_value;
          }
        public void unsetPlayer()
          {
            if (flagHasPlayer)
              {
              }
            flagHasPlayer = false;
          }

        public virtual void extraTypePlayersAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePlayersSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePlayersLookup(key);
            if (old_field == null)
              {
                extraTypePlayersAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasPlayer);
            if (flagHasPlayer)
              {
                handler.start_pair("Player");
                if (partial_allowed)
                    storePlayer.write_partial_as_json(handler);
                else
                    storePlayer.write_as_json(handler);
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
            if (!(hasPlayer()))
              {
                return "When parsing the object for %what%, the \"Player\" field was missing.";
              }
            return null;
          }

        public static TypePlayersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePlayersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
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
        public static TypePlayersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePlayersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePlayersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
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
        public static TypePlayersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePlayersJSON from_text(string text, bool ignore_extras)
          {
            TypePlayersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePlayersJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePlayersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePlayersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private SportsPlayerJSON.HoldingGenerator fieldGeneratorPlayer;
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
                TypePlayersJSON result = new TypePlayersJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePlayersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePlayersJSON result)
              {
                if (fieldGeneratorPlayer.have_value)
                  {
                    result.setPlayer(fieldGeneratorPlayer.value);
                    fieldGeneratorPlayer.have_value = false;
                  }
                else if ((!(result.hasPlayer())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Player\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypePlayersJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Player", 0, 6, false) == 0) && (field_name.Length == 6))
                    return fieldGeneratorPlayer;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorPlayer = new SportsPlayerJSON.HoldingGenerator("field \"Player\" of the TypePlayers class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePlayers class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorPlayer = new SportsPlayerJSON.HoldingGenerator("field \"Player\" of the TypePlayers class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePlayers class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorPlayer.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorPlayer.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorPlayer.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypePlayersJSON  result)
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
            public TypePlayersJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePlayersJSON  result)
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
        protected virtual void handle_result(List<TypePlayersJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePlayersJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePlayersJSON>();
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
        public List<TypePlayersJSON> value;
      };
      };
    private bool flagHasTeams;
    private List< SportsTeamNewJSON  > storeTeams;
    private bool flagHasLeague;
    private SportsLeagueCodeJSON  storeLeague;
    private bool flagHasScores;
    private List< BigInteger > storeScores;
    private bool flagHasHomeAway;
    private List< SportsHomeAwayJSON  > storeHomeAway;
    private bool flagHasStartTime;
    private DateAndOrTimeJSON  storeStartTime;
    private bool flagHasStatus;
    private TypeStatus storeStatus;
    private bool flagHasPlayingPeriod;
    private BigInteger storePlayingPeriod;
    private bool flagHasClock;
    private TypeClockJSON  storeClock;
    private bool flagHasBaseballInningHalf;
    private TypeBaseballInningHalf storeBaseballInningHalf;
    private bool flagHasVenue;
    private SportsVenueNewJSON  storeVenue;
    private bool flagHasBroadcastNetworks;
    private List< string > storeBroadcastNetworks;
    private bool flagHasSeason;
    private SportsSeasonResolvedJSON  storeSeason;
    private bool flagHasSpecialGameType;
    private SportsPlayoffSpecialGameJSON  storeSpecialGameType;
    private bool flagHasTournament;
    private SportsTournamentJSON  storeTournament;
    private bool flagHasSeriesGameNumber;
    private BigInteger storeSeriesGameNumber;
    private bool flagHasID;
    private string storeID;
    private bool flagHasSportImage;
    private SportsSportImageJSON  storeSportImage;
    private bool flagHasPeriodType;
    private SportsGamePlayingPeriodTypeJSON  storePeriodType;
    private bool flagHasPlayers;
    private List< TypePlayersJSON  > storePlayers;
    private bool flagHasGameStatistics;
    private SportsGameStatisticsJSON  storeGameStatistics;


    private void  fromJSONTeams(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Teams of SportsGameJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field Teams of SportsGameJSON has too few elements.");
        List< SportsTeamNewJSON  > vector_Teams1 = new List< SportsTeamNewJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsTeamNewJSON convert_classy = SportsTeamNewJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Teams1.Add(convert_classy);
          }
        Debug.Assert(vector_Teams1.Count >= 2);
        initTeams();
        for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
            appendTeams(vector_Teams1[num1]);
        for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
          {
          }
      }


    private void  fromJSONLeague(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsLeagueCodeJSON convert_classy = SportsLeagueCodeJSON.from_json(json_value, ignore_extras, true);
        setLeague(convert_classy);
      }


    private void  fromJSONScores(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Scores of SportsGameJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field Scores of SportsGameJSON has too few elements.");
        List< BigInteger > vector_Scores1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field Scores of SportsGameJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field Scores of SportsGameJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_Scores1.Add(extracted_integer);
          }
        Debug.Assert(vector_Scores1.Count >= 2);
        initScores();
        for (int num2 = 0; num2 < vector_Scores1.Count; ++num2)
            appendScores(vector_Scores1[num2]);
        for (int num1 = 0; num1 < vector_Scores1.Count; ++num1)
          {
          }
      }


    private void  fromJSONHomeAway(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field HomeAway of SportsGameJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field HomeAway of SportsGameJSON has too few elements.");
        List< SportsHomeAwayJSON  > vector_HomeAway1 = new List< SportsHomeAwayJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsHomeAwayJSON convert_classy = SportsHomeAwayJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_HomeAway1.Add(convert_classy);
          }
        Debug.Assert(vector_HomeAway1.Count >= 2);
        initHomeAway();
        for (int num3 = 0; num3 < vector_HomeAway1.Count; ++num3)
            appendHomeAway(vector_HomeAway1[num3]);
        for (int num1 = 0; num1 < vector_HomeAway1.Count; ++num1)
          {
          }
      }


    private void  fromJSONStartTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setStartTime(convert_classy);
      }


    private void  fromJSONStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Status of SportsGameJSON is not a string.");
        TypeStatus the_open_enum = new TypeStatus();
        switch (json_string.getData()[0])
          {
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "nceled", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeStatusKnownValues.Status_Canceled;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "mplete", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeStatusKnownValues.Status_Complete;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if (String.Compare(json_string.getData(), 1, "elayed", 0, 6, false) == 0)
                  {
                    if (json_string.getData().Length == 7)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeStatusKnownValues.Status_Delayed;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[7])
                      {
                        case 'F':
                            if ((String.Compare(json_string.getData(), 8, "acility", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeStatusKnownValues.Status_DelayedFacility;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'W':
                            if ((String.Compare(json_string.getData(), 8, "eather", 0, 6, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeStatusKnownValues.Status_DelayedWeather;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nProgress", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_InProgress;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "ostponed", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_Postponed;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'c':
                        if (String.Compare(json_string.getData(), 2, "heduled", 0, 7, false) == 0)
                          {
                            if (json_string.getData().Length == 9)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeStatusKnownValues.Status_Scheduled;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[9])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 10, "lex", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeStatusKnownValues.Status_ScheduledFlex;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'T':
                                    if ((String.Compare(json_string.getData(), 10, "imeTBD", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeStatusKnownValues.Status_ScheduledTimeTBD;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "spended", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeStatusKnownValues.Status_Suspended;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if (String.Compare(json_string.getData(), 1, "n", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'k':
                            if ((String.Compare(json_string.getData(), 3, "nown", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeStatusKnownValues.Status_Unknown;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'n':
                            if ((String.Compare(json_string.getData(), 3, "ecessary", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeStatusKnownValues.Status_Unnecessary;
                                    goto open_enum_is_done;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setStatus(the_open_enum);
      }


    private void  fromJSONPlayingPeriod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PlayingPeriod of SportsGameJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PlayingPeriod of SportsGameJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPlayingPeriod(extracted_integer);
      }


    private void  fromJSONClock(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeClockJSON convert_classy = TypeClockJSON.from_json(json_value, ignore_extras, true);
        setClock(convert_classy);
      }


    private void  fromJSONBaseballInningHalf(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BaseballInningHalf of SportsGameJSON is not a string.");
        TypeBaseballInningHalf the_open_enum = new TypeBaseballInningHalf();
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "ottom", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeBaseballInningHalfKnownValues.BaseballInningHalf_Bottom;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "iddle", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeBaseballInningHalfKnownValues.BaseballInningHalf_Middle;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "op", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeBaseballInningHalfKnownValues.BaseballInningHalf_Top;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setBaseballInningHalf(the_open_enum);
      }


    private void  fromJSONVenue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsVenueNewJSON convert_classy = SportsVenueNewJSON.from_json(json_value, ignore_extras, true);
        setVenue(convert_classy);
      }


    private void  fromJSONBroadcastNetworks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field BroadcastNetworks of SportsGameJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field BroadcastNetworks of SportsGameJSON has too few elements.");
        List< string > vector_BroadcastNetworks1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field BroadcastNetworks of SportsGameJSON is not a string.");
            vector_BroadcastNetworks1.Add(json_string.getData());
          }
        Debug.Assert(vector_BroadcastNetworks1.Count >= 1);
        initBroadcastNetworks();
        for (int num4 = 0; num4 < vector_BroadcastNetworks1.Count; ++num4)
            appendBroadcastNetworks(vector_BroadcastNetworks1[num4]);
        for (int num1 = 0; num1 < vector_BroadcastNetworks1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSeason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSeasonResolvedJSON convert_classy = SportsSeasonResolvedJSON.from_json(json_value, ignore_extras, true);
        setSeason(convert_classy);
      }


    private void  fromJSONSpecialGameType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsPlayoffSpecialGameJSON convert_classy = SportsPlayoffSpecialGameJSON.from_json(json_value, ignore_extras, true);
        setSpecialGameType(convert_classy);
      }


    private void  fromJSONTournament(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsTournamentJSON convert_classy = SportsTournamentJSON.from_json(json_value, ignore_extras, true);
        setTournament(convert_classy);
      }


    private void  fromJSONSeriesGameNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SeriesGameNumber of SportsGameJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SeriesGameNumber of SportsGameJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSeriesGameNumber(extracted_integer);
      }


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ID of SportsGameJSON is not a string.");
        setID(json_string.getData());
      }


    private void  fromJSONSportImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSportImageJSON convert_classy = SportsSportImageJSON.from_json(json_value, ignore_extras, true);
        setSportImage(convert_classy);
      }


    private void  fromJSONPeriodType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsGamePlayingPeriodTypeJSON convert_classy = SportsGamePlayingPeriodTypeJSON.from_json(json_value, ignore_extras, true);
        setPeriodType(convert_classy);
      }


    private void  fromJSONPlayers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Players of SportsGameJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypePlayersJSON  > vector_Players1 = new List< TypePlayersJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypePlayersJSON convert_classy = TypePlayersJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Players1.Add(convert_classy);
          }
        initPlayers();
        for (int num5 = 0; num5 < vector_Players1.Count; ++num5)
            appendPlayers(vector_Players1[num5]);
        for (int num1 = 0; num1 < vector_Players1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGameStatistics(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsGameStatisticsJSON convert_classy = SportsGameStatisticsJSON.from_json(json_value, ignore_extras, true);
        setGameStatistics(convert_classy);
      }


    public SportsGameJSON()
      {
        flagHasTeams = false;
        flagHasLeague = false;
        flagHasScores = false;
        flagHasHomeAway = false;
        flagHasStartTime = false;
        flagHasStatus = false;
        flagHasPlayingPeriod = false;
        flagHasClock = false;
        flagHasBaseballInningHalf = false;
        flagHasVenue = false;
        flagHasBroadcastNetworks = false;
        flagHasSeason = false;
        flagHasSpecialGameType = false;
        flagHasTournament = false;
        flagHasSeriesGameNumber = false;
        flagHasID = false;
        flagHasSportImage = false;
        flagHasPeriodType = false;
        flagHasPlayers = false;
        flagHasGameStatistics = false;
        storeTeams = new List< SportsTeamNewJSON  >();
        storeScores = new List< BigInteger >();
        storeHomeAway = new List< SportsHomeAwayJSON  >();
        storeBroadcastNetworks = new List< string >();
        storePlayers = new List< TypePlayersJSON  >();
      }

    public abstract string getSportsGameKind();
    public bool  hasTeams()
      {
        return flagHasTeams;
      }

    public int  countOfTeams()
      {
        Debug.Assert(flagHasTeams);
        return storeTeams.Count;
      }

    public SportsTeamNewJSON   elementOfTeams(int element_num)
      {
        Debug.Assert(flagHasTeams);
        return storeTeams[element_num];
      }

    public List< SportsTeamNewJSON  >  getTeams()
      {
        Debug.Assert(flagHasTeams);
        return storeTeams;
      }

    public bool  hasLeague()
      {
        return flagHasLeague;
      }

    public SportsLeagueCodeJSON   getLeague()
      {
        Debug.Assert(flagHasLeague);
        return storeLeague;
      }

    public SportsLeagueCodeJSON.TypeValue  getLeagueValue()
      {
        return getLeague().getValue();
      }

    public string  getLeagueAsString()
      {
        return getLeague().getValueAsString();
      }

    public bool  hasScores()
      {
        return flagHasScores;
      }

    public int  countOfScores()
      {
        Debug.Assert(flagHasScores);
        return storeScores.Count;
      }

    public BigInteger  elementOfScores(int element_num)
      {
        Debug.Assert(flagHasScores);
        return storeScores[element_num];
      }

    public List< BigInteger >  getScores()
      {
        Debug.Assert(flagHasScores);
        return storeScores;
      }

    public bool  hasHomeAway()
      {
        return flagHasHomeAway;
      }

    public int  countOfHomeAway()
      {
        Debug.Assert(flagHasHomeAway);
        return storeHomeAway.Count;
      }

    public SportsHomeAwayJSON   elementOfHomeAway(int element_num)
      {
        Debug.Assert(flagHasHomeAway);
        return storeHomeAway[element_num];
      }

    public List< SportsHomeAwayJSON  >  getHomeAway()
      {
        Debug.Assert(flagHasHomeAway);
        return storeHomeAway;
      }

    public bool  hasStartTime()
      {
        return flagHasStartTime;
      }

    public DateAndOrTimeJSON   getStartTime()
      {
        Debug.Assert(flagHasStartTime);
        return storeStartTime;
      }

    public bool  hasStatus()
      {
        return flagHasStatus;
      }

    public TypeStatus  getStatus()
      {
        Debug.Assert(flagHasStatus);
        return storeStatus;
      }

    public string  getStatusAsString()
      {
        TypeStatus result = getStatus();
        if (result.in_known_list)
            return stringFromStatus(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasPlayingPeriod()
      {
        return flagHasPlayingPeriod;
      }

    public BigInteger  getPlayingPeriod()
      {
        Debug.Assert(flagHasPlayingPeriod);
        return storePlayingPeriod;
      }

    public bool  hasClock()
      {
        return flagHasClock;
      }

    public TypeClockJSON   getClock()
      {
        Debug.Assert(flagHasClock);
        return storeClock;
      }

    public bool  hasBaseballInningHalf()
      {
        return flagHasBaseballInningHalf;
      }

    public TypeBaseballInningHalf  getBaseballInningHalf()
      {
        Debug.Assert(flagHasBaseballInningHalf);
        return storeBaseballInningHalf;
      }

    public string  getBaseballInningHalfAsString()
      {
        TypeBaseballInningHalf result = getBaseballInningHalf();
        if (result.in_known_list)
            return stringFromBaseballInningHalf(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasVenue()
      {
        return flagHasVenue;
      }

    public SportsVenueNewJSON   getVenue()
      {
        Debug.Assert(flagHasVenue);
        return storeVenue;
      }

    public bool  hasBroadcastNetworks()
      {
        return flagHasBroadcastNetworks;
      }

    public int  countOfBroadcastNetworks()
      {
        Debug.Assert(flagHasBroadcastNetworks);
        return storeBroadcastNetworks.Count;
      }

    public string  elementOfBroadcastNetworks(int element_num)
      {
        Debug.Assert(flagHasBroadcastNetworks);
        return storeBroadcastNetworks[element_num];
      }

    public List< string >  getBroadcastNetworks()
      {
        Debug.Assert(flagHasBroadcastNetworks);
        return storeBroadcastNetworks;
      }

    public bool  hasSeason()
      {
        return flagHasSeason;
      }

    public SportsSeasonResolvedJSON   getSeason()
      {
        Debug.Assert(flagHasSeason);
        return storeSeason;
      }

    public bool  hasSpecialGameType()
      {
        return flagHasSpecialGameType;
      }

    public SportsPlayoffSpecialGameJSON   getSpecialGameType()
      {
        Debug.Assert(flagHasSpecialGameType);
        return storeSpecialGameType;
      }

    public SportsPlayoffSpecialGameJSON.TypeValue  getSpecialGameTypeValue()
      {
        return getSpecialGameType().getValue();
      }

    public string  getSpecialGameTypeAsString()
      {
        return getSpecialGameType().getValueAsString();
      }

    public bool  hasTournament()
      {
        return flagHasTournament;
      }

    public SportsTournamentJSON   getTournament()
      {
        Debug.Assert(flagHasTournament);
        return storeTournament;
      }

    public bool  hasSeriesGameNumber()
      {
        return flagHasSeriesGameNumber;
      }

    public BigInteger  getSeriesGameNumber()
      {
        Debug.Assert(flagHasSeriesGameNumber);
        return storeSeriesGameNumber;
      }

    public bool  hasID()
      {
        return flagHasID;
      }

    public string  getID()
      {
        Debug.Assert(flagHasID);
        return storeID;
      }

    public bool  hasSportImage()
      {
        return flagHasSportImage;
      }

    public SportsSportImageJSON   getSportImage()
      {
        Debug.Assert(flagHasSportImage);
        return storeSportImage;
      }

    public bool  hasPeriodType()
      {
        return flagHasPeriodType;
      }

    public SportsGamePlayingPeriodTypeJSON   getPeriodType()
      {
        Debug.Assert(flagHasPeriodType);
        return storePeriodType;
      }

    public SportsGamePlayingPeriodTypeJSON.TypeValue  getPeriodTypeValue()
      {
        return getPeriodType().getValue();
      }

    public string  getPeriodTypeAsString()
      {
        return getPeriodType().getValueAsString();
      }

    public bool  hasPlayers()
      {
        return flagHasPlayers;
      }

    public int  countOfPlayers()
      {
        Debug.Assert(flagHasPlayers);
        return storePlayers.Count;
      }

    public TypePlayersJSON   elementOfPlayers(int element_num)
      {
        Debug.Assert(flagHasPlayers);
        return storePlayers[element_num];
      }

    public List< TypePlayersJSON  >  getPlayers()
      {
        Debug.Assert(flagHasPlayers);
        return storePlayers;
      }

    public bool  hasGameStatistics()
      {
        return flagHasGameStatistics;
      }

    public SportsGameStatisticsJSON   getGameStatistics()
      {
        Debug.Assert(flagHasGameStatistics);
        return storeGameStatistics;
      }


    public abstract int extraSportsGameComponentCount();
    public abstract string extraSportsGameComponentKey(int component_num);
    public abstract JSONValue extraSportsGameComponentValue(int component_num);
    public abstract JSONValue extraSportsGameLookup(string field_name);

    public void initTeams()
      {
        if (flagHasTeams)
          {
            for (int num1 = 0; num1 < storeTeams.Count; ++num1)
              {
              }
          }
        flagHasTeams = true;
        storeTeams.Clear();
      }
    public void appendTeams(SportsTeamNewJSON  to_append)
      {
        if (!flagHasTeams)
          {
            flagHasTeams = true;
            storeTeams.Clear();
          }
        Debug.Assert(flagHasTeams);
        storeTeams.Add(to_append);
      }
    public void unsetTeams()
      {
        if (flagHasTeams)
          {
            for (int num2 = 0; num2 < storeTeams.Count; ++num2)
              {
              }
          }
        flagHasTeams = false;
        storeTeams.Clear();
      }
    public void setLeague(SportsLeagueCodeJSON  new_value)
      {
        if (flagHasLeague)
          {
          }
        flagHasLeague = true;
        storeLeague = new_value;
      }
    public void setLeague(SportsLeagueCodeJSON.TypeValue new_value)
      {
        setLeague(new SportsLeagueCodeJSON(new_value));
      }
    public void setLeague(string chars)
      {
        SportsLeagueCodeJSON.TypeValueKnownValues known = SportsLeagueCodeJSON.stringToValue(chars);
        SportsLeagueCodeJSON.TypeValue new_value = new SportsLeagueCodeJSON.TypeValue();
        if (known == SportsLeagueCodeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setLeague(new_value);
      }
    public void unsetLeague()
      {
        if (flagHasLeague)
          {
          }
        flagHasLeague = false;
      }
    public void initScores()
      {
        flagHasScores = true;
        storeScores.Clear();
      }
    public void appendScores(BigInteger to_append)
      {
        if (!flagHasScores)
          {
            flagHasScores = true;
            storeScores.Clear();
          }
        Debug.Assert(flagHasScores);
        storeScores.Add(to_append);
      }
    public void unsetScores()
      {
        flagHasScores = false;
        storeScores.Clear();
      }
    public void initHomeAway()
      {
        if (flagHasHomeAway)
          {
            for (int num3 = 0; num3 < storeHomeAway.Count; ++num3)
              {
              }
          }
        flagHasHomeAway = true;
        storeHomeAway.Clear();
      }
    public void appendHomeAway(SportsHomeAwayJSON  to_append)
      {
        if (!flagHasHomeAway)
          {
            flagHasHomeAway = true;
            storeHomeAway.Clear();
          }
        Debug.Assert(flagHasHomeAway);
        storeHomeAway.Add(to_append);
      }
    public void appendHomeAway(SportsHomeAwayJSON.TypeValue new_value)
      {
        appendHomeAway(new SportsHomeAwayJSON(new_value));
      }
    public void appendHomeAway(string chars)
      {
        SportsHomeAwayJSON.TypeValueKnownValues known = SportsHomeAwayJSON.stringToValue(chars);
        SportsHomeAwayJSON.TypeValue new_value = new SportsHomeAwayJSON.TypeValue();
        if (known == SportsHomeAwayJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendHomeAway(new_value);
      }
    public void unsetHomeAway()
      {
        if (flagHasHomeAway)
          {
            for (int num4 = 0; num4 < storeHomeAway.Count; ++num4)
              {
              }
          }
        flagHasHomeAway = false;
        storeHomeAway.Clear();
      }
    public void setStartTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasStartTime)
          {
          }
        flagHasStartTime = true;
        storeStartTime = new_value;
      }
    public void unsetStartTime()
      {
        if (flagHasStartTime)
          {
          }
        flagHasStartTime = false;
      }
    public void setStatus(TypeStatus new_value)
      {
        flagHasStatus = true;
        storeStatus = new_value;
      }
    public void setStatus(string chars)
      {
        TypeStatusKnownValues known = stringToStatus(chars);
        TypeStatus new_value = new TypeStatus();
        if (known == TypeStatusKnownValues.Status__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setStatus(new_value);
      }
    public void setStatus(TypeStatusKnownValues new_value)
      {
        TypeStatus new_full_value = new TypeStatus();
        Debug.Assert(new_value != TypeStatusKnownValues.Status__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setStatus(new_full_value);
      }
    public void unsetStatus()
      {
        flagHasStatus = false;
      }
    public void setPlayingPeriod(BigInteger new_value)
      {
        flagHasPlayingPeriod = true;
        if (new_value < 0)
            throw new Exception("The value for field PlayingPeriod of SportsGameJSON is less than the lower bound (0) for that field.");
        storePlayingPeriod = new_value;
      }
    public void unsetPlayingPeriod()
      {
        flagHasPlayingPeriod = false;
      }
    public void setClock(TypeClockJSON  new_value)
      {
        if (flagHasClock)
          {
          }
        flagHasClock = true;
        storeClock = new_value;
      }
    public void unsetClock()
      {
        if (flagHasClock)
          {
          }
        flagHasClock = false;
      }
    public void setBaseballInningHalf(TypeBaseballInningHalf new_value)
      {
        flagHasBaseballInningHalf = true;
        storeBaseballInningHalf = new_value;
      }
    public void setBaseballInningHalf(string chars)
      {
        TypeBaseballInningHalfKnownValues known = stringToBaseballInningHalf(chars);
        TypeBaseballInningHalf new_value = new TypeBaseballInningHalf();
        if (known == TypeBaseballInningHalfKnownValues.BaseballInningHalf__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setBaseballInningHalf(new_value);
      }
    public void setBaseballInningHalf(TypeBaseballInningHalfKnownValues new_value)
      {
        TypeBaseballInningHalf new_full_value = new TypeBaseballInningHalf();
        Debug.Assert(new_value != TypeBaseballInningHalfKnownValues.BaseballInningHalf__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setBaseballInningHalf(new_full_value);
      }
    public void unsetBaseballInningHalf()
      {
        flagHasBaseballInningHalf = false;
      }
    public void setVenue(SportsVenueNewJSON  new_value)
      {
        if (flagHasVenue)
          {
          }
        flagHasVenue = true;
        storeVenue = new_value;
      }
    public void unsetVenue()
      {
        if (flagHasVenue)
          {
          }
        flagHasVenue = false;
      }
    public void initBroadcastNetworks()
      {
        flagHasBroadcastNetworks = true;
        storeBroadcastNetworks.Clear();
      }
    public void appendBroadcastNetworks(string to_append)
      {
        if (!flagHasBroadcastNetworks)
          {
            flagHasBroadcastNetworks = true;
            storeBroadcastNetworks.Clear();
          }
        Debug.Assert(flagHasBroadcastNetworks);
        storeBroadcastNetworks.Add(to_append);
      }
    public void unsetBroadcastNetworks()
      {
        flagHasBroadcastNetworks = false;
        storeBroadcastNetworks.Clear();
      }
    public void setSeason(SportsSeasonResolvedJSON  new_value)
      {
        if (flagHasSeason)
          {
          }
        flagHasSeason = true;
        storeSeason = new_value;
      }
    public void unsetSeason()
      {
        if (flagHasSeason)
          {
          }
        flagHasSeason = false;
      }
    public void setSpecialGameType(SportsPlayoffSpecialGameJSON  new_value)
      {
        if (flagHasSpecialGameType)
          {
          }
        flagHasSpecialGameType = true;
        storeSpecialGameType = new_value;
      }
    public void setSpecialGameType(SportsPlayoffSpecialGameJSON.TypeValue new_value)
      {
        setSpecialGameType(new SportsPlayoffSpecialGameJSON(new_value));
      }
    public void setSpecialGameType(string chars)
      {
        SportsPlayoffSpecialGameJSON.TypeValueKnownValues known = SportsPlayoffSpecialGameJSON.stringToValue(chars);
        SportsPlayoffSpecialGameJSON.TypeValue new_value = new SportsPlayoffSpecialGameJSON.TypeValue();
        if (known == SportsPlayoffSpecialGameJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSpecialGameType(new_value);
      }
    public void unsetSpecialGameType()
      {
        if (flagHasSpecialGameType)
          {
          }
        flagHasSpecialGameType = false;
      }
    public void setTournament(SportsTournamentJSON  new_value)
      {
        if (flagHasTournament)
          {
          }
        flagHasTournament = true;
        storeTournament = new_value;
      }
    public void unsetTournament()
      {
        if (flagHasTournament)
          {
          }
        flagHasTournament = false;
      }
    public void setSeriesGameNumber(BigInteger new_value)
      {
        flagHasSeriesGameNumber = true;
        if (new_value < 1)
            throw new Exception("The value for field SeriesGameNumber of SportsGameJSON is less than the lower bound (1) for that field.");
        storeSeriesGameNumber = new_value;
      }
    public void unsetSeriesGameNumber()
      {
        flagHasSeriesGameNumber = false;
      }
    public void setID(string new_value)
      {
        flagHasID = true;
        storeID = new_value;
      }
    public void unsetID()
      {
        flagHasID = false;
      }
    public void setSportImage(SportsSportImageJSON  new_value)
      {
        if (flagHasSportImage)
          {
          }
        flagHasSportImage = true;
        storeSportImage = new_value;
      }
    public void unsetSportImage()
      {
        if (flagHasSportImage)
          {
          }
        flagHasSportImage = false;
      }
    public void setPeriodType(SportsGamePlayingPeriodTypeJSON  new_value)
      {
        if (flagHasPeriodType)
          {
          }
        flagHasPeriodType = true;
        storePeriodType = new_value;
      }
    public void setPeriodType(SportsGamePlayingPeriodTypeJSON.TypeValue new_value)
      {
        setPeriodType(new SportsGamePlayingPeriodTypeJSON(new_value));
      }
    public void setPeriodType(string chars)
      {
        SportsGamePlayingPeriodTypeJSON.TypeValueKnownValues known = SportsGamePlayingPeriodTypeJSON.stringToValue(chars);
        SportsGamePlayingPeriodTypeJSON.TypeValue new_value = new SportsGamePlayingPeriodTypeJSON.TypeValue();
        if (known == SportsGamePlayingPeriodTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setPeriodType(new_value);
      }
    public void unsetPeriodType()
      {
        if (flagHasPeriodType)
          {
          }
        flagHasPeriodType = false;
      }
    public void initPlayers()
      {
        if (flagHasPlayers)
          {
            for (int num5 = 0; num5 < storePlayers.Count; ++num5)
              {
              }
          }
        flagHasPlayers = true;
        storePlayers.Clear();
      }
    public void appendPlayers(TypePlayersJSON  to_append)
      {
        if (!flagHasPlayers)
          {
            flagHasPlayers = true;
            storePlayers.Clear();
          }
        Debug.Assert(flagHasPlayers);
        storePlayers.Add(to_append);
      }
    public void unsetPlayers()
      {
        if (flagHasPlayers)
          {
            for (int num6 = 0; num6 < storePlayers.Count; ++num6)
              {
              }
          }
        flagHasPlayers = false;
        storePlayers.Clear();
      }
    public void setGameStatistics(SportsGameStatisticsJSON  new_value)
      {
        if (flagHasGameStatistics)
          {
          }
        flagHasGameStatistics = true;
        storeGameStatistics = new_value;
      }
    public void unsetGameStatistics()
      {
        if (flagHasGameStatistics)
          {
          }
        flagHasGameStatistics = false;
      }

    public abstract void extraSportsGameAppendPair(string key, JSONValue new_component);
    public abstract void extraSportsGameSetField(string key, JSONValue new_component);

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
        handler.pair("SportsGameKind", getSportsGameKind());
        Debug.Assert(partial_allowed || flagHasTeams);
        if (flagHasTeams)
          {
            handler.start_pair("Teams");
            Debug.Assert(storeTeams.Count >= 2);
            handler.start_array();
            for (int num1 = 0; num1 < storeTeams.Count; ++num1)
              {
                if (partial_allowed)
                    storeTeams[num1].write_partial_as_json(handler);
                else
                    storeTeams[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasLeague)
          {
            handler.start_pair("League");
            if (partial_allowed)
                storeLeague.write_partial_as_json(handler);
            else
                storeLeague.write_as_json(handler);
          }
        if (flagHasScores)
          {
            handler.start_pair("Scores");
            Debug.Assert(storeScores.Count >= 2);
            handler.start_array();
            for (int num2 = 0; num2 < storeScores.Count; ++num2)
              {
                handler.number_value(storeScores[num2]);
              }
            handler.finish_array();
          }
        if (flagHasHomeAway)
          {
            handler.start_pair("HomeAway");
            Debug.Assert(storeHomeAway.Count >= 2);
            handler.start_array();
            for (int num3 = 0; num3 < storeHomeAway.Count; ++num3)
              {
                if (partial_allowed)
                    storeHomeAway[num3].write_partial_as_json(handler);
                else
                    storeHomeAway[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasStartTime)
          {
            handler.start_pair("StartTime");
            if (partial_allowed)
                storeStartTime.write_partial_as_json(handler);
            else
                storeStartTime.write_as_json(handler);
          }
        if (flagHasStatus)
          {
            handler.start_pair("Status");
            if (storeStatus.in_known_list)
              {
                switch (storeStatus.list_value)
                  {
                    case TypeStatusKnownValues.Status_Scheduled:
                        handler.string_value("Scheduled");
                        break;
                    case TypeStatusKnownValues.Status_InProgress:
                        handler.string_value("InProgress");
                        break;
                    case TypeStatusKnownValues.Status_Complete:
                        handler.string_value("Complete");
                        break;
                    case TypeStatusKnownValues.Status_Delayed:
                        handler.string_value("Delayed");
                        break;
                    case TypeStatusKnownValues.Status_DelayedWeather:
                        handler.string_value("DelayedWeather");
                        break;
                    case TypeStatusKnownValues.Status_DelayedFacility:
                        handler.string_value("DelayedFacility");
                        break;
                    case TypeStatusKnownValues.Status_Postponed:
                        handler.string_value("Postponed");
                        break;
                    case TypeStatusKnownValues.Status_Suspended:
                        handler.string_value("Suspended");
                        break;
                    case TypeStatusKnownValues.Status_Canceled:
                        handler.string_value("Canceled");
                        break;
                    case TypeStatusKnownValues.Status_Unnecessary:
                        handler.string_value("Unnecessary");
                        break;
                    case TypeStatusKnownValues.Status_ScheduledFlex:
                        handler.string_value("ScheduledFlex");
                        break;
                    case TypeStatusKnownValues.Status_ScheduledTimeTBD:
                        handler.string_value("ScheduledTimeTBD");
                        break;
                    case TypeStatusKnownValues.Status_Unknown:
                        handler.string_value("Unknown");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeStatus.string_value);
              }
          }
        if (flagHasPlayingPeriod)
          {
            handler.start_pair("PlayingPeriod");
            handler.number_value(storePlayingPeriod);
          }
        if (flagHasClock)
          {
            handler.start_pair("Clock");
            if (partial_allowed)
                storeClock.write_partial_as_json(handler);
            else
                storeClock.write_as_json(handler);
          }
        if (flagHasBaseballInningHalf)
          {
            handler.start_pair("BaseballInningHalf");
            if (storeBaseballInningHalf.in_known_list)
              {
                switch (storeBaseballInningHalf.list_value)
                  {
                    case TypeBaseballInningHalfKnownValues.BaseballInningHalf_Top:
                        handler.string_value("Top");
                        break;
                    case TypeBaseballInningHalfKnownValues.BaseballInningHalf_Middle:
                        handler.string_value("Middle");
                        break;
                    case TypeBaseballInningHalfKnownValues.BaseballInningHalf_Bottom:
                        handler.string_value("Bottom");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeBaseballInningHalf.string_value);
              }
          }
        if (flagHasVenue)
          {
            handler.start_pair("Venue");
            if (partial_allowed)
                storeVenue.write_partial_as_json(handler);
            else
                storeVenue.write_as_json(handler);
          }
        if (flagHasBroadcastNetworks)
          {
            handler.start_pair("BroadcastNetworks");
            Debug.Assert(storeBroadcastNetworks.Count >= 1);
            handler.start_array();
            for (int num4 = 0; num4 < storeBroadcastNetworks.Count; ++num4)
              {
                handler.string_value(storeBroadcastNetworks[num4]);
              }
            handler.finish_array();
          }
        if (flagHasSeason)
          {
            handler.start_pair("Season");
            if (partial_allowed)
                storeSeason.write_partial_as_json(handler);
            else
                storeSeason.write_as_json(handler);
          }
        if (flagHasSpecialGameType)
          {
            handler.start_pair("SpecialGameType");
            if (partial_allowed)
                storeSpecialGameType.write_partial_as_json(handler);
            else
                storeSpecialGameType.write_as_json(handler);
          }
        if (flagHasTournament)
          {
            handler.start_pair("Tournament");
            if (partial_allowed)
                storeTournament.write_partial_as_json(handler);
            else
                storeTournament.write_as_json(handler);
          }
        if (flagHasSeriesGameNumber)
          {
            handler.start_pair("SeriesGameNumber");
            handler.number_value(storeSeriesGameNumber);
          }
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.string_value(storeID);
          }
        if (flagHasSportImage)
          {
            handler.start_pair("SportImage");
            if (partial_allowed)
                storeSportImage.write_partial_as_json(handler);
            else
                storeSportImage.write_as_json(handler);
          }
        if (flagHasPeriodType)
          {
            handler.start_pair("PeriodType");
            if (partial_allowed)
                storePeriodType.write_partial_as_json(handler);
            else
                storePeriodType.write_as_json(handler);
          }
        if (flagHasPlayers)
          {
            handler.start_pair("Players");
            handler.start_array();
            for (int num5 = 0; num5 < storePlayers.Count; ++num5)
              {
                if (partial_allowed)
                    storePlayers[num5].write_partial_as_json(handler);
                else
                    storePlayers[num5].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasGameStatistics)
          {
            handler.start_pair("GameStatistics");
            if (partial_allowed)
                storeGameStatistics.write_partial_as_json(handler);
            else
                storeGameStatistics.write_as_json(handler);
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
        if (!(hasTeams()))
          {
            return "When parsing the object for %what%, the \"Teams\" field was missing.";
          }
        return null;
      }

    public static SportsGameJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsGameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGame", ignore_extras);
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
    public static SportsGameJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsGameJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsGameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGame", ignore_extras);
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
    public static SportsGameJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsGameJSON from_text(string text, bool ignore_extras)
      {
        SportsGameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGame", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsGameJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsGameJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsGameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsGame", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsTeamNewJSON.HoldingArrayGenerator fieldGeneratorTeams;
        private SportsLeagueCodeJSON.HoldingGenerator fieldGeneratorLeague;
    private class FieldHoldingGeneratorScores : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorScores(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorScores : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorScores(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorScores fieldGeneratorScores;
        private SportsHomeAwayJSON.HoldingArrayGenerator fieldGeneratorHomeAway;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorStartTime;
    private abstract class FieldGeneratorStatus : JSONStringGenerator
          {
            protected FieldGeneratorStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorStatus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeStatusKnownValues known = stringToStatus(result);
                TypeStatus new_value = new TypeStatus();
                if (known == TypeStatusKnownValues.Status__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeStatus result);
          };
    private class FieldHoldingGeneratorStatus : FieldGeneratorStatus
  {
    protected override void handle_result(TypeStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorStatus(String what)
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
    public TypeStatus value;
  };
    private class FieldHoldingArrayGeneratorStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStatus
      {
        private FieldHoldingArrayGeneratorStatus top;

        protected override void handle_result(TypeStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStatus init_top)
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
    protected virtual void handle_result(List<TypeStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeStatus> value;
  };
        private FieldHoldingGeneratorStatus fieldGeneratorStatus;
    private class FieldHoldingGeneratorPlayingPeriod : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorPlayingPeriod(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorPlayingPeriod : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorPlayingPeriod(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorPlayingPeriod fieldGeneratorPlayingPeriod;
        private TypeClockJSON.HoldingGenerator fieldGeneratorClock;
    private abstract class FieldGeneratorBaseballInningHalf : JSONStringGenerator
          {
            protected FieldGeneratorBaseballInningHalf(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorBaseballInningHalf()
              {
              }
            protected override void handle_result(string result)
              {
                TypeBaseballInningHalfKnownValues known = stringToBaseballInningHalf(result);
                TypeBaseballInningHalf new_value = new TypeBaseballInningHalf();
                if (known == TypeBaseballInningHalfKnownValues.BaseballInningHalf__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeBaseballInningHalf result);
          };
    private class FieldHoldingGeneratorBaseballInningHalf : FieldGeneratorBaseballInningHalf
  {
    protected override void handle_result(TypeBaseballInningHalf result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorBaseballInningHalf(String what)
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
    public TypeBaseballInningHalf value;
  };
    private class FieldHoldingArrayGeneratorBaseballInningHalf : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorBaseballInningHalf
      {
        private FieldHoldingArrayGeneratorBaseballInningHalf top;

        protected override void handle_result(TypeBaseballInningHalf result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorBaseballInningHalf init_top)
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
    protected virtual void handle_result(List<TypeBaseballInningHalf> result)
      {
      }

    public FieldHoldingArrayGeneratorBaseballInningHalf(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeBaseballInningHalf>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorBaseballInningHalf()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeBaseballInningHalf>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeBaseballInningHalf> value;
  };
        private FieldHoldingGeneratorBaseballInningHalf fieldGeneratorBaseballInningHalf;
        private SportsVenueNewJSON.HoldingGenerator fieldGeneratorVenue;
        private JSONHoldingStringArrayGenerator fieldGeneratorBroadcastNetworks;
        private SportsSeasonResolvedJSON.HoldingGenerator fieldGeneratorSeason;
        private SportsPlayoffSpecialGameJSON.HoldingGenerator fieldGeneratorSpecialGameType;
        private SportsTournamentJSON.HoldingGenerator fieldGeneratorTournament;
    private class FieldHoldingGeneratorSeriesGameNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSeriesGameNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSeriesGameNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSeriesGameNumber(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorSeriesGameNumber fieldGeneratorSeriesGameNumber;
        private JSONHoldingStringGenerator fieldGeneratorID;
        private SportsSportImageJSON.HoldingGenerator fieldGeneratorSportImage;
        private SportsGamePlayingPeriodTypeJSON.HoldingGenerator fieldGeneratorPeriodType;
        private TypePlayersJSON.HoldingArrayGenerator fieldGeneratorPlayers;
        private SportsGameStatisticsJSON.HoldingGenerator fieldGeneratorGameStatistics;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `SportsGameKind' field is missing.");
            SportsGameJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsGameAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getSportsGameJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `SportsGameKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(SportsGameJSON result)
          {
            if (fieldGeneratorTeams.have_value)
              {
                result.initTeams();
                int count = fieldGeneratorTeams.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTeams(fieldGeneratorTeams.value[num]);
                  }
                fieldGeneratorTeams.value.Clear();
                fieldGeneratorTeams.have_value = false;
              }
            else if ((!(result.hasTeams())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Teams\" field was missing.");
              }
            if (fieldGeneratorLeague.have_value)
              {
                result.setLeague(fieldGeneratorLeague.value);
                fieldGeneratorLeague.have_value = false;
              }
            if (fieldGeneratorScores.have_value)
              {
                result.initScores();
                int count = fieldGeneratorScores.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendScores(fieldGeneratorScores.value[num]);
                  }
                fieldGeneratorScores.value.Clear();
                fieldGeneratorScores.have_value = false;
              }
            if (fieldGeneratorHomeAway.have_value)
              {
                result.initHomeAway();
                int count = fieldGeneratorHomeAway.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendHomeAway(fieldGeneratorHomeAway.value[num]);
                  }
                fieldGeneratorHomeAway.value.Clear();
                fieldGeneratorHomeAway.have_value = false;
              }
            if (fieldGeneratorStartTime.have_value)
              {
                result.setStartTime(fieldGeneratorStartTime.value);
                fieldGeneratorStartTime.have_value = false;
              }
            if (fieldGeneratorStatus.have_value)
              {
                result.setStatus(fieldGeneratorStatus.value);
                fieldGeneratorStatus.have_value = false;
              }
            if (fieldGeneratorPlayingPeriod.have_value)
              {
                result.setPlayingPeriod(fieldGeneratorPlayingPeriod.value);
                fieldGeneratorPlayingPeriod.have_value = false;
              }
            if (fieldGeneratorClock.have_value)
              {
                result.setClock(fieldGeneratorClock.value);
                fieldGeneratorClock.have_value = false;
              }
            if (fieldGeneratorBaseballInningHalf.have_value)
              {
                result.setBaseballInningHalf(fieldGeneratorBaseballInningHalf.value);
                fieldGeneratorBaseballInningHalf.have_value = false;
              }
            if (fieldGeneratorVenue.have_value)
              {
                result.setVenue(fieldGeneratorVenue.value);
                fieldGeneratorVenue.have_value = false;
              }
            if (fieldGeneratorBroadcastNetworks.have_value)
              {
                result.initBroadcastNetworks();
                int count = fieldGeneratorBroadcastNetworks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendBroadcastNetworks(fieldGeneratorBroadcastNetworks.value[num]);
                  }
                fieldGeneratorBroadcastNetworks.value.Clear();
                fieldGeneratorBroadcastNetworks.have_value = false;
              }
            if (fieldGeneratorSeason.have_value)
              {
                result.setSeason(fieldGeneratorSeason.value);
                fieldGeneratorSeason.have_value = false;
              }
            if (fieldGeneratorSpecialGameType.have_value)
              {
                result.setSpecialGameType(fieldGeneratorSpecialGameType.value);
                fieldGeneratorSpecialGameType.have_value = false;
              }
            if (fieldGeneratorTournament.have_value)
              {
                result.setTournament(fieldGeneratorTournament.value);
                fieldGeneratorTournament.have_value = false;
              }
            if (fieldGeneratorSeriesGameNumber.have_value)
              {
                result.setSeriesGameNumber(fieldGeneratorSeriesGameNumber.value);
                fieldGeneratorSeriesGameNumber.have_value = false;
              }
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
            if (fieldGeneratorSportImage.have_value)
              {
                result.setSportImage(fieldGeneratorSportImage.value);
                fieldGeneratorSportImage.have_value = false;
              }
            if (fieldGeneratorPeriodType.have_value)
              {
                result.setPeriodType(fieldGeneratorPeriodType.value);
                fieldGeneratorPeriodType.have_value = false;
              }
            if (fieldGeneratorPlayers.have_value)
              {
                result.initPlayers();
                int count = fieldGeneratorPlayers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPlayers(fieldGeneratorPlayers.value[num]);
                  }
                fieldGeneratorPlayers.value.Clear();
                fieldGeneratorPlayers.have_value = false;
              }
            if (fieldGeneratorGameStatistics.have_value)
              {
                result.setGameStatistics(fieldGeneratorGameStatistics.value);
                fieldGeneratorGameStatistics.have_value = false;
              }
          }
        protected abstract void handle_result(SportsGameJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "seballInningHalf", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorBaseballInningHalf;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "oadcastNetworks", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorBroadcastNetworks;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "lock", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorClock;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "ameStatistics", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorGameStatistics;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "omeAway", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorHomeAway;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorID;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "eague", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorLeague;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "riodType", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorPeriodType;
                            break;
                        case 'l':
                            if (String.Compare(field_name, 2, "ay", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'e':
                                        if ((String.Compare(field_name, 5, "rs", 0, 2, false) == 0) && (field_name.Length == 7))
                                            return fieldGeneratorPlayers;
                                        break;
                                    case 'i':
                                        if ((String.Compare(field_name, 5, "ngPeriod", 0, 8, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorPlayingPeriod;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "ores", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorScores;
                            break;
                        case 'e':
                            switch (field_name[2])
                              {
                                case 'a':
                                    if ((String.Compare(field_name, 3, "son", 0, 3, false) == 0) && (field_name.Length == 6))
                                        return fieldGeneratorSeason;
                                    break;
                                case 'r':
                                    if ((String.Compare(field_name, 3, "iesGameNumber", 0, 13, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorSeriesGameNumber;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'p':
                            switch (field_name[2])
                              {
                                case 'e':
                                    if ((String.Compare(field_name, 3, "cialGameType", 0, 12, false) == 0) && (field_name.Length == 15))
                                        return fieldGeneratorSpecialGameType;
                                    break;
                                case 'o':
                                    if (String.Compare(field_name, 3, "rt", 0, 2, false) == 0)
                                      {
                                        switch (field_name[5])
                                          {
                                            case 'I':
                                                if ((String.Compare(field_name, 6, "mage", 0, 4, false) == 0) && (field_name.Length == 10))
                                                    return fieldGeneratorSportImage;
                                                break;
                                            case 's':
                                                if ((String.Compare(field_name, 6, "GameKind", 0, 8, false) == 0) && (field_name.Length == 14))
                                                    {
                                                    keyGenerator.reset();
                                                    return keyGenerator;
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
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "a", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'r':
                                        if ((String.Compare(field_name, 4, "tTime", 0, 5, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorStartTime;
                                        break;
                                    case 't':
                                        if ((String.Compare(field_name, 4, "us", 0, 2, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorStatus;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ams", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorTeams;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "urnament", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorTournament;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "enue", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorVenue;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTeams = new SportsTeamNewJSON.HoldingArrayGenerator("field \"Teams\" of the SportsGame class", ignore_extras);
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsGame class", ignore_extras);
            fieldGeneratorScores = new FieldHoldingArrayGeneratorScores("field \"Scores\" of the SportsGame class");
            fieldGeneratorHomeAway = new SportsHomeAwayJSON.HoldingArrayGenerator("field \"HomeAway\" of the SportsGame class", ignore_extras);
            fieldGeneratorStartTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartTime\" of the SportsGame class", ignore_extras);
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the SportsGame class");
            fieldGeneratorPlayingPeriod = new FieldHoldingGeneratorPlayingPeriod("field \"PlayingPeriod\" of the SportsGame class");
            fieldGeneratorClock = new TypeClockJSON.HoldingGenerator("field \"Clock\" of the SportsGame class", ignore_extras);
            fieldGeneratorBaseballInningHalf = new FieldHoldingGeneratorBaseballInningHalf("field \"BaseballInningHalf\" of the SportsGame class");
            fieldGeneratorVenue = new SportsVenueNewJSON.HoldingGenerator("field \"Venue\" of the SportsGame class", ignore_extras);
            fieldGeneratorBroadcastNetworks = new JSONHoldingStringArrayGenerator("field \"BroadcastNetworks\" of the SportsGame class");
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsGame class", ignore_extras);
            fieldGeneratorSpecialGameType = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"SpecialGameType\" of the SportsGame class", ignore_extras);
            fieldGeneratorTournament = new SportsTournamentJSON.HoldingGenerator("field \"Tournament\" of the SportsGame class", ignore_extras);
            fieldGeneratorSeriesGameNumber = new FieldHoldingGeneratorSeriesGameNumber("field \"SeriesGameNumber\" of the SportsGame class");
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the SportsGame class");
            fieldGeneratorSportImage = new SportsSportImageJSON.HoldingGenerator("field \"SportImage\" of the SportsGame class", ignore_extras);
            fieldGeneratorPeriodType = new SportsGamePlayingPeriodTypeJSON.HoldingGenerator("field \"PeriodType\" of the SportsGame class", ignore_extras);
            fieldGeneratorPlayers = new TypePlayersJSON.HoldingArrayGenerator("field \"Players\" of the SportsGame class", ignore_extras);
            fieldGeneratorGameStatistics = new SportsGameStatisticsJSON.HoldingGenerator("field \"GameStatistics\" of the SportsGame class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SportsGameKind\" of the SportsGame class");
            set_what("the SportsGame class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTeams = new SportsTeamNewJSON.HoldingArrayGenerator("field \"Teams\" of the SportsGame class", false);
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsGame class", false);
            fieldGeneratorScores = new FieldHoldingArrayGeneratorScores("field \"Scores\" of the SportsGame class");
            fieldGeneratorHomeAway = new SportsHomeAwayJSON.HoldingArrayGenerator("field \"HomeAway\" of the SportsGame class", false);
            fieldGeneratorStartTime = new DateAndOrTimeJSON.HoldingGenerator("field \"StartTime\" of the SportsGame class", false);
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the SportsGame class");
            fieldGeneratorPlayingPeriod = new FieldHoldingGeneratorPlayingPeriod("field \"PlayingPeriod\" of the SportsGame class");
            fieldGeneratorClock = new TypeClockJSON.HoldingGenerator("field \"Clock\" of the SportsGame class", false);
            fieldGeneratorBaseballInningHalf = new FieldHoldingGeneratorBaseballInningHalf("field \"BaseballInningHalf\" of the SportsGame class");
            fieldGeneratorVenue = new SportsVenueNewJSON.HoldingGenerator("field \"Venue\" of the SportsGame class", false);
            fieldGeneratorBroadcastNetworks = new JSONHoldingStringArrayGenerator("field \"BroadcastNetworks\" of the SportsGame class");
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsGame class", false);
            fieldGeneratorSpecialGameType = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"SpecialGameType\" of the SportsGame class", false);
            fieldGeneratorTournament = new SportsTournamentJSON.HoldingGenerator("field \"Tournament\" of the SportsGame class", false);
            fieldGeneratorSeriesGameNumber = new FieldHoldingGeneratorSeriesGameNumber("field \"SeriesGameNumber\" of the SportsGame class");
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the SportsGame class");
            fieldGeneratorSportImage = new SportsSportImageJSON.HoldingGenerator("field \"SportImage\" of the SportsGame class", false);
            fieldGeneratorPeriodType = new SportsGamePlayingPeriodTypeJSON.HoldingGenerator("field \"PeriodType\" of the SportsGame class", false);
            fieldGeneratorPlayers = new TypePlayersJSON.HoldingArrayGenerator("field \"Players\" of the SportsGame class", false);
            fieldGeneratorGameStatistics = new SportsGameStatisticsJSON.HoldingGenerator("field \"GameStatistics\" of the SportsGame class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SportsGameKind\" of the SportsGame class");
            set_what("the SportsGame class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTeams.reset();
            fieldGeneratorLeague.reset();
            fieldGeneratorScores.reset();
            fieldGeneratorHomeAway.reset();
            fieldGeneratorStartTime.reset();
            fieldGeneratorStatus.reset();
            fieldGeneratorPlayingPeriod.reset();
            fieldGeneratorClock.reset();
            fieldGeneratorBaseballInningHalf.reset();
            fieldGeneratorVenue.reset();
            fieldGeneratorBroadcastNetworks.reset();
            fieldGeneratorSeason.reset();
            fieldGeneratorSpecialGameType.reset();
            fieldGeneratorTournament.reset();
            fieldGeneratorSeriesGameNumber.reset();
            fieldGeneratorID.reset();
            fieldGeneratorSportImage.reset();
            fieldGeneratorPeriodType.reset();
            fieldGeneratorPlayers.reset();
            fieldGeneratorGameStatistics.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTeams.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLeague.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHomeAway.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStartTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorClock.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorVenue.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeason.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSpecialGameType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTournament.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSportImage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPeriodType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPlayers.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGameStatistics.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTeams.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLeague.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHomeAway.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStartTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorClock.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorVenue.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeason.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSpecialGameType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTournament.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSportImage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPeriodType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPlayers.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGameStatistics.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsGameJSON  result)
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
        public SportsGameJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsGameJSON  result)
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
    protected virtual void handle_result(List<SportsGameJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsGameJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsGameJSON>();
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
    public List<SportsGameJSON> value;
  };
    class GenericSportsGameJSON : SportsGameJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericSportsGameJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getSportsGameKind()  { return key; }
        public override int extraSportsGameComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraSportsGameComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraSportsGameComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraSportsGameLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraSportsGameAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraSportsGameSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraSportsGameLookup(key);
            if (old_field == null)
              {
                extraSportsGameAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static SportsGameJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'B':
            if (String.Compare(key, 1, "as", 0, 2, false) == 0)
              {
                switch (key[3])
                  {
                    case 'e':
                        if ((String.Compare(key, 4, "ball", 0, 4, false) == 0) && (key.Length == 8))
                            return new SportsGameBaseballJSON();
                        break;
                    case 'k':
                        if ((String.Compare(key, 4, "etball", 0, 6, false) == 0) && (key.Length == 10))
                            return new SportsGameBasketballJSON();
                        break;
                    default:
                        break;
                  }
              }
            break;
        case 'C':
            if ((String.Compare(key, 1, "ricket", 0, 6, false) == 0) && (key.Length == 7))
                return new SportsGameCricketJSON();
            break;
        case 'F':
            if ((String.Compare(key, 1, "ootball", 0, 7, false) == 0) && (key.Length == 8))
                return new SportsGameFootballJSON();
            break;
        case 'G':
            if ((String.Compare(key, 1, "eneric", 0, 6, false) == 0) && (key.Length == 7))
                return new SportsGameGenericJSON();
            break;
        case 'H':
            if ((String.Compare(key, 1, "ockey", 0, 5, false) == 0) && (key.Length == 6))
                return new SportsGameHockeyJSON();
            break;
        case 'S':
            if ((String.Compare(key, 1, "occer", 0, 5, false) == 0) && (key.Length == 6))
                return new SportsGameSoccerJSON();
            break;
        default:
            break;
      }

        return new GenericSportsGameJSON(key);
      }
  };
