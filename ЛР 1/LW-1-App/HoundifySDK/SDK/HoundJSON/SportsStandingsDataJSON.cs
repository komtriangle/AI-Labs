/* file "SportsStandingsDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsStandingsDataJSON : JSONBase
  {
    public class TypeConferenceRecordJSON : JSONBase
      {
        private bool flagHasWins;
        private BigInteger storeWins;
        private bool flagHasLosses;
        private BigInteger storeLosses;
        private bool flagHasWinningPercentage;
        private double storeWinningPercentage;
        private string textStoreWinningPercentage;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONWins(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Wins of TypeConferenceRecordJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Wins of TypeConferenceRecordJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setWins(extracted_integer);
          }


        private void  fromJSONLosses(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Losses of TypeConferenceRecordJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Losses of TypeConferenceRecordJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setLosses(extracted_integer);
          }


        private void  fromJSONWinningPercentage(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field WinningPercentage of TypeConferenceRecordJSON is not a number.");
                  }
              }
            setWinningPercentageText(the_rational_text);
          }


        public TypeConferenceRecordJSON()
          {
            flagHasWins = false;
            flagHasLosses = false;
            flagHasWinningPercentage = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasWins()
          {
            return flagHasWins;
          }

        public BigInteger  getWins()
          {
            Debug.Assert(flagHasWins);
            return storeWins;
          }

        public bool  hasLosses()
          {
            return flagHasLosses;
          }

        public BigInteger  getLosses()
          {
            Debug.Assert(flagHasLosses);
            return storeLosses;
          }

        public bool  hasWinningPercentage()
          {
            return flagHasWinningPercentage;
          }

        public double  getWinningPercentage()
          {
            Debug.Assert(flagHasWinningPercentage);
            if (textStoreWinningPercentage != "")
              {
                return Double.Parse(textStoreWinningPercentage);
              }
            return storeWinningPercentage;
          }

        public string  getWinningPercentageAsText()
          {
            Debug.Assert(flagHasWinningPercentage);
            if (textStoreWinningPercentage == "")
              {
                return Convert.ToString(storeWinningPercentage);
              }
            else
              {
                return (textStoreWinningPercentage);
              }
          }


        public virtual int extraTypeConferenceRecordComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeConferenceRecordComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeConferenceRecordComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeConferenceRecordLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setWins(BigInteger new_value)
          {
            flagHasWins = true;
            if (new_value < 0)
                throw new Exception("The value for field Wins of TypeConferenceRecordJSON is less than the lower bound (0) for that field.");
            storeWins = new_value;
          }
        public void unsetWins()
          {
            flagHasWins = false;
          }
        public void setLosses(BigInteger new_value)
          {
            flagHasLosses = true;
            if (new_value < 0)
                throw new Exception("The value for field Losses of TypeConferenceRecordJSON is less than the lower bound (0) for that field.");
            storeLosses = new_value;
          }
        public void unsetLosses()
          {
            flagHasLosses = false;
          }
        public void setWinningPercentage(double new_value)
          {
            flagHasWinningPercentage = true;
            if (new_value < 0)
                throw new Exception("The value for field WinningPercentage of TypeConferenceRecordJSON is less than the lower bound (0) for that field.");
            if (new_value > 1)
                throw new Exception("The value for field WinningPercentage of TypeConferenceRecordJSON is greater than the upper bound (1) for that field.");
            storeWinningPercentage = new_value;
            textStoreWinningPercentage = "";
          }
        public void setWinningPercentageText(string new_value)
          {
            flagHasWinningPercentage = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field WinningPercentage of TypeConferenceRecordJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field WinningPercentage of TypeConferenceRecordJSON is less than the lower bound (0) for that field.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
                throw new Exception("The value for field WinningPercentage of TypeConferenceRecordJSON is greater than the upper bound (1) for that field.");
            textStoreWinningPercentage = new_value;
          }
        public void unsetWinningPercentage()
          {
            flagHasWinningPercentage = false;
          }

        public virtual void extraTypeConferenceRecordAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeConferenceRecordSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeConferenceRecordLookup(key);
            if (old_field == null)
              {
                extraTypeConferenceRecordAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasWins);
            if (flagHasWins)
              {
                handler.start_pair("Wins");
                handler.number_value(storeWins);
              }
            Debug.Assert(partial_allowed || flagHasLosses);
            if (flagHasLosses)
              {
                handler.start_pair("Losses");
                handler.number_value(storeLosses);
              }
            if (flagHasWinningPercentage)
              {
                handler.start_pair("WinningPercentage");
                if (textStoreWinningPercentage != "")
                    handler.number_value(textStoreWinningPercentage);
                else if (((double)(long)storeWinningPercentage) == storeWinningPercentage)
                    handler.number_value((long)storeWinningPercentage);
                else
                    handler.number_value(storeWinningPercentage);
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
            if (!(hasWins()))
              {
                return "When parsing the object for %what%, the \"Wins\" field was missing.";
              }
            if (!(hasLosses()))
              {
                return "When parsing the object for %what%, the \"Losses\" field was missing.";
              }
            return null;
          }

        public static TypeConferenceRecordJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeConferenceRecordJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeConferenceRecord", ignore_extras);
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
        public static TypeConferenceRecordJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeConferenceRecordJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeConferenceRecordJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeConferenceRecord", ignore_extras);
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
        public static TypeConferenceRecordJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeConferenceRecordJSON from_text(string text, bool ignore_extras)
          {
            TypeConferenceRecordJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeConferenceRecord", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeConferenceRecordJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeConferenceRecordJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeConferenceRecordJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeConferenceRecord", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorWins : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorWins(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorWins : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorWins(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorWins fieldGeneratorWins;
        private class FieldHoldingGeneratorLosses : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorLosses(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorLosses : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorLosses(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorLosses fieldGeneratorLosses;
            private JSONHoldingNumberTextGenerator fieldGeneratorWinningPercentage;
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
                TypeConferenceRecordJSON result = new TypeConferenceRecordJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeConferenceRecordAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeConferenceRecordJSON result)
              {
                if (fieldGeneratorWins.have_value)
                  {
                    result.setWins(fieldGeneratorWins.value);
                    fieldGeneratorWins.have_value = false;
                  }
                else if ((!(result.hasWins())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Wins\" field was missing.");
                  }
                if (fieldGeneratorLosses.have_value)
                  {
                    result.setLosses(fieldGeneratorLosses.value);
                    fieldGeneratorLosses.have_value = false;
                  }
                else if ((!(result.hasLosses())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Losses\" field was missing.");
                  }
                if (fieldGeneratorWinningPercentage.have_value)
                  {
                    result.setWinningPercentageText(fieldGeneratorWinningPercentage.value);
                    fieldGeneratorWinningPercentage.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeConferenceRecordJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "osses", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorLosses;
                        break;
                    case 'W':
                        if (String.Compare(field_name, 1, "in", 0, 2, false) == 0)
                          {
                            switch (field_name[3])
                              {
                                case 'n':
                                    if ((String.Compare(field_name, 4, "ingPercentage", 0, 13, false) == 0) && (field_name.Length == 17))
                                        return fieldGeneratorWinningPercentage;
                                    break;
                                case 's':
                                    if (field_name.Length == 4)
                                        return fieldGeneratorWins;
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
                fieldGeneratorWins = new FieldHoldingGeneratorWins("field \"Wins\" of the TypeConferenceRecord class");
                fieldGeneratorLosses = new FieldHoldingGeneratorLosses("field \"Losses\" of the TypeConferenceRecord class");
                fieldGeneratorWinningPercentage = new JSONHoldingNumberTextGenerator("field \"WinningPercentage\" of the TypeConferenceRecord class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeConferenceRecord class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorWins = new FieldHoldingGeneratorWins("field \"Wins\" of the TypeConferenceRecord class");
                fieldGeneratorLosses = new FieldHoldingGeneratorLosses("field \"Losses\" of the TypeConferenceRecord class");
                fieldGeneratorWinningPercentage = new JSONHoldingNumberTextGenerator("field \"WinningPercentage\" of the TypeConferenceRecord class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeConferenceRecord class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorWins.reset();
                fieldGeneratorLosses.reset();
                fieldGeneratorWinningPercentage.reset();
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
            protected override void handle_result(TypeConferenceRecordJSON  result)
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
            public TypeConferenceRecordJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeConferenceRecordJSON  result)
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
        protected virtual void handle_result(List<TypeConferenceRecordJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeConferenceRecordJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeConferenceRecordJSON>();
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
        public List<TypeConferenceRecordJSON> value;
      };
      };
    public class TypeStreakJSON : JSONBase
      {
        public enum TypeTypeKnownValues
          {
            Type_Wins,
            Type_Losses,
            Type_OvertimeLosses,
            Type_Ties,
            Type__none
          };
        public struct TypeType
          {
            public bool in_known_list;
            public string string_value;
            public TypeTypeKnownValues list_value;
          };

        public static TypeTypeKnownValues  stringToType(string chars)
          {
            switch (chars[0])
              {
                case 'L':
                    if ((String.Compare(chars, 1, "osses", 0, 5, false) == 0) && (chars.Length == 6))
                        return TypeTypeKnownValues.Type_Losses;
                    break;
                case 'O':
                    if ((String.Compare(chars, 1, "vertimeLosses", 0, 13, false) == 0) && (chars.Length == 14))
                        return TypeTypeKnownValues.Type_OvertimeLosses;
                    break;
                case 'T':
                    if ((String.Compare(chars, 1, "ies", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeTypeKnownValues.Type_Ties;
                    break;
                case 'W':
                    if ((String.Compare(chars, 1, "ins", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeTypeKnownValues.Type_Wins;
                    break;
                default:
                    break;
              }
            return TypeTypeKnownValues.Type__none;
          }

        public static string  stringFromType(TypeTypeKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeTypeKnownValues.Type_Wins:
                    return "Wins";
                case TypeTypeKnownValues.Type_Losses:
                    return "Losses";
                case TypeTypeKnownValues.Type_OvertimeLosses:
                    return "OvertimeLosses";
                case TypeTypeKnownValues.Type_Ties:
                    return "Ties";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasType;
        private TypeType storeType;
        private bool flagHasLength;
        private BigInteger storeLength;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Type of TypeStreakJSON is not a string.");
            TypeType the_open_enum = new TypeType();
            switch (json_string.getData()[0])
              {
                case 'L':
                    if ((String.Compare(json_string.getData(), 1, "osses", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeTypeKnownValues.Type_Losses;
                            goto open_enum_is_done;
                          }
                    break;
                case 'O':
                    if ((String.Compare(json_string.getData(), 1, "vertimeLosses", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeTypeKnownValues.Type_OvertimeLosses;
                            goto open_enum_is_done;
                          }
                    break;
                case 'T':
                    if ((String.Compare(json_string.getData(), 1, "ies", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeTypeKnownValues.Type_Ties;
                            goto open_enum_is_done;
                          }
                    break;
                case 'W':
                    if ((String.Compare(json_string.getData(), 1, "ins", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeTypeKnownValues.Type_Wins;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setType(the_open_enum);
          }


        private void  fromJSONLength(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Length of TypeStreakJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Length of TypeStreakJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setLength(extracted_integer);
          }


        public TypeStreakJSON()
          {
            flagHasType = false;
            flagHasLength = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasType()
          {
            return flagHasType;
          }

        public TypeType  getType()
          {
            Debug.Assert(flagHasType);
            return storeType;
          }

        public string  getTypeAsString()
          {
            TypeType result = getType();
            if (result.in_known_list)
                return stringFromType(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasLength()
          {
            return flagHasLength;
          }

        public BigInteger  getLength()
          {
            Debug.Assert(flagHasLength);
            return storeLength;
          }


        public virtual int extraTypeStreakComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeStreakComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeStreakComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeStreakLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setType(TypeType new_value)
          {
            flagHasType = true;
            storeType = new_value;
          }
        public void setType(string chars)
          {
            TypeTypeKnownValues known = stringToType(chars);
            TypeType new_value = new TypeType();
            if (known == TypeTypeKnownValues.Type__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setType(new_value);
          }
        public void setType(TypeTypeKnownValues new_value)
          {
            TypeType new_full_value = new TypeType();
            Debug.Assert(new_value != TypeTypeKnownValues.Type__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setType(new_full_value);
          }
        public void unsetType()
          {
            flagHasType = false;
          }
        public void setLength(BigInteger new_value)
          {
            flagHasLength = true;
            if (new_value < 0)
                throw new Exception("The value for field Length of TypeStreakJSON is less than the lower bound (0) for that field.");
            storeLength = new_value;
          }
        public void unsetLength()
          {
            flagHasLength = false;
          }

        public virtual void extraTypeStreakAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeStreakSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeStreakLookup(key);
            if (old_field == null)
              {
                extraTypeStreakAppendPair(key, new_component);
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
                if (storeType.in_known_list)
                  {
                    switch (storeType.list_value)
                      {
                        case TypeTypeKnownValues.Type_Wins:
                            handler.string_value("Wins");
                            break;
                        case TypeTypeKnownValues.Type_Losses:
                            handler.string_value("Losses");
                            break;
                        case TypeTypeKnownValues.Type_OvertimeLosses:
                            handler.string_value("OvertimeLosses");
                            break;
                        case TypeTypeKnownValues.Type_Ties:
                            handler.string_value("Ties");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeType.string_value);
                  }
              }
            Debug.Assert(partial_allowed || flagHasLength);
            if (flagHasLength)
              {
                handler.start_pair("Length");
                handler.number_value(storeLength);
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
            if (!(hasLength()))
              {
                return "When parsing the object for %what%, the \"Length\" field was missing.";
              }
            return null;
          }

        public static TypeStreakJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStreakJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStreak", ignore_extras);
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
        public static TypeStreakJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStreakJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeStreakJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStreak", ignore_extras);
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
        public static TypeStreakJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeStreakJSON from_text(string text, bool ignore_extras)
          {
            TypeStreakJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStreak", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeStreakJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeStreakJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeStreakJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeStreak", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorType : JSONStringGenerator
              {
                protected FieldGeneratorType(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorType()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeTypeKnownValues known = stringToType(result);
                    TypeType new_value = new TypeType();
                    if (known == TypeTypeKnownValues.Type__none)
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
                protected abstract void handle_result(TypeType result);
              };
        private class FieldHoldingGeneratorType : FieldGeneratorType
      {
        protected override void handle_result(TypeType result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorType(String what)
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
        public TypeType value;
      };
        private class FieldHoldingArrayGeneratorType : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorType
          {
            private FieldHoldingArrayGeneratorType top;

            protected override void handle_result(TypeType result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorType init_top)
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
        protected virtual void handle_result(List<TypeType> result)
          {
          }

        public FieldHoldingArrayGeneratorType(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeType>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorType()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeType>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeType> value;
      };
            private FieldHoldingGeneratorType fieldGeneratorType;
        private class FieldHoldingGeneratorLength : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorLength(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorLength : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorLength(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorLength fieldGeneratorLength;
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
                TypeStreakJSON result = new TypeStreakJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeStreakAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeStreakJSON result)
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
                if (fieldGeneratorLength.have_value)
                  {
                    result.setLength(fieldGeneratorLength.value);
                    fieldGeneratorLength.have_value = false;
                  }
                else if ((!(result.hasLength())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Length\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeStreakJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "ength", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorLength;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorType;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the TypeStreak class");
                fieldGeneratorLength = new FieldHoldingGeneratorLength("field \"Length\" of the TypeStreak class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeStreak class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorType = new FieldHoldingGeneratorType("field \"Type\" of the TypeStreak class");
                fieldGeneratorLength = new FieldHoldingGeneratorLength("field \"Length\" of the TypeStreak class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeStreak class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorType.reset();
                fieldGeneratorLength.reset();
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
            protected override void handle_result(TypeStreakJSON  result)
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
            public TypeStreakJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeStreakJSON  result)
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
        protected virtual void handle_result(List<TypeStreakJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeStreakJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeStreakJSON>();
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
        public List<TypeStreakJSON> value;
      };
      };
    public class TypeLastTenJSON : JSONBase
      {
        private bool flagHasWins;
        private BigInteger storeWins;
        private bool flagHasLosses;
        private BigInteger storeLosses;
        private bool flagHasOvertimeLosses;
        private BigInteger storeOvertimeLosses;
        private bool flagHasTies;
        private BigInteger storeTies;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONWins(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Wins of TypeLastTenJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Wins of TypeLastTenJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setWins(extracted_integer);
          }


        private void  fromJSONLosses(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Losses of TypeLastTenJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Losses of TypeLastTenJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setLosses(extracted_integer);
          }


        private void  fromJSONOvertimeLosses(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field OvertimeLosses of TypeLastTenJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field OvertimeLosses of TypeLastTenJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setOvertimeLosses(extracted_integer);
          }


        private void  fromJSONTies(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Ties of TypeLastTenJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Ties of TypeLastTenJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setTies(extracted_integer);
          }


        public TypeLastTenJSON()
          {
            flagHasWins = false;
            flagHasLosses = false;
            flagHasOvertimeLosses = false;
            flagHasTies = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasWins()
          {
            return flagHasWins;
          }

        public BigInteger  getWins()
          {
            Debug.Assert(flagHasWins);
            return storeWins;
          }

        public bool  hasLosses()
          {
            return flagHasLosses;
          }

        public BigInteger  getLosses()
          {
            Debug.Assert(flagHasLosses);
            return storeLosses;
          }

        public bool  hasOvertimeLosses()
          {
            return flagHasOvertimeLosses;
          }

        public BigInteger  getOvertimeLosses()
          {
            Debug.Assert(flagHasOvertimeLosses);
            return storeOvertimeLosses;
          }

        public bool  hasTies()
          {
            return flagHasTies;
          }

        public BigInteger  getTies()
          {
            Debug.Assert(flagHasTies);
            return storeTies;
          }


        public virtual int extraTypeLastTenComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeLastTenComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeLastTenComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeLastTenLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setWins(BigInteger new_value)
          {
            flagHasWins = true;
            if (new_value < 0)
                throw new Exception("The value for field Wins of TypeLastTenJSON is less than the lower bound (0) for that field.");
            storeWins = new_value;
          }
        public void unsetWins()
          {
            flagHasWins = false;
          }
        public void setLosses(BigInteger new_value)
          {
            flagHasLosses = true;
            if (new_value < 0)
                throw new Exception("The value for field Losses of TypeLastTenJSON is less than the lower bound (0) for that field.");
            storeLosses = new_value;
          }
        public void unsetLosses()
          {
            flagHasLosses = false;
          }
        public void setOvertimeLosses(BigInteger new_value)
          {
            flagHasOvertimeLosses = true;
            if (new_value < 0)
                throw new Exception("The value for field OvertimeLosses of TypeLastTenJSON is less than the lower bound (0) for that field.");
            storeOvertimeLosses = new_value;
          }
        public void unsetOvertimeLosses()
          {
            flagHasOvertimeLosses = false;
          }
        public void setTies(BigInteger new_value)
          {
            flagHasTies = true;
            if (new_value < 0)
                throw new Exception("The value for field Ties of TypeLastTenJSON is less than the lower bound (0) for that field.");
            storeTies = new_value;
          }
        public void unsetTies()
          {
            flagHasTies = false;
          }

        public virtual void extraTypeLastTenAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeLastTenSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeLastTenLookup(key);
            if (old_field == null)
              {
                extraTypeLastTenAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasWins);
            if (flagHasWins)
              {
                handler.start_pair("Wins");
                handler.number_value(storeWins);
              }
            Debug.Assert(partial_allowed || flagHasLosses);
            if (flagHasLosses)
              {
                handler.start_pair("Losses");
                handler.number_value(storeLosses);
              }
            if (flagHasOvertimeLosses)
              {
                handler.start_pair("OvertimeLosses");
                handler.number_value(storeOvertimeLosses);
              }
            if (flagHasTies)
              {
                handler.start_pair("Ties");
                handler.number_value(storeTies);
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
            if (!(hasWins()))
              {
                return "When parsing the object for %what%, the \"Wins\" field was missing.";
              }
            if (!(hasLosses()))
              {
                return "When parsing the object for %what%, the \"Losses\" field was missing.";
              }
            return null;
          }

        public static TypeLastTenJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLastTenJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLastTen", ignore_extras);
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
        public static TypeLastTenJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLastTenJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLastTenJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLastTen", ignore_extras);
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
        public static TypeLastTenJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLastTenJSON from_text(string text, bool ignore_extras)
          {
            TypeLastTenJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLastTen", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeLastTenJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeLastTenJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeLastTenJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLastTen", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorWins : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorWins(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorWins : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorWins(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorWins fieldGeneratorWins;
        private class FieldHoldingGeneratorLosses : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorLosses(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorLosses : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorLosses(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorLosses fieldGeneratorLosses;
        private class FieldHoldingGeneratorOvertimeLosses : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorOvertimeLosses(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorOvertimeLosses : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorOvertimeLosses(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorOvertimeLosses fieldGeneratorOvertimeLosses;
        private class FieldHoldingGeneratorTies : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorTies(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorTies : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorTies(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorTies fieldGeneratorTies;
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
                TypeLastTenJSON result = new TypeLastTenJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeLastTenAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeLastTenJSON result)
              {
                if (fieldGeneratorWins.have_value)
                  {
                    result.setWins(fieldGeneratorWins.value);
                    fieldGeneratorWins.have_value = false;
                  }
                else if ((!(result.hasWins())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Wins\" field was missing.");
                  }
                if (fieldGeneratorLosses.have_value)
                  {
                    result.setLosses(fieldGeneratorLosses.value);
                    fieldGeneratorLosses.have_value = false;
                  }
                else if ((!(result.hasLosses())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Losses\" field was missing.");
                  }
                if (fieldGeneratorOvertimeLosses.have_value)
                  {
                    result.setOvertimeLosses(fieldGeneratorOvertimeLosses.value);
                    fieldGeneratorOvertimeLosses.have_value = false;
                  }
                if (fieldGeneratorTies.have_value)
                  {
                    result.setTies(fieldGeneratorTies.value);
                    fieldGeneratorTies.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeLastTenJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "osses", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorLosses;
                        break;
                    case 'O':
                        if ((String.Compare(field_name, 1, "vertimeLosses", 0, 13, false) == 0) && (field_name.Length == 14))
                            return fieldGeneratorOvertimeLosses;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "ies", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorTies;
                        break;
                    case 'W':
                        if ((String.Compare(field_name, 1, "ins", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorWins;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorWins = new FieldHoldingGeneratorWins("field \"Wins\" of the TypeLastTen class");
                fieldGeneratorLosses = new FieldHoldingGeneratorLosses("field \"Losses\" of the TypeLastTen class");
                fieldGeneratorOvertimeLosses = new FieldHoldingGeneratorOvertimeLosses("field \"OvertimeLosses\" of the TypeLastTen class");
                fieldGeneratorTies = new FieldHoldingGeneratorTies("field \"Ties\" of the TypeLastTen class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeLastTen class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorWins = new FieldHoldingGeneratorWins("field \"Wins\" of the TypeLastTen class");
                fieldGeneratorLosses = new FieldHoldingGeneratorLosses("field \"Losses\" of the TypeLastTen class");
                fieldGeneratorOvertimeLosses = new FieldHoldingGeneratorOvertimeLosses("field \"OvertimeLosses\" of the TypeLastTen class");
                fieldGeneratorTies = new FieldHoldingGeneratorTies("field \"Ties\" of the TypeLastTen class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeLastTen class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorWins.reset();
                fieldGeneratorLosses.reset();
                fieldGeneratorOvertimeLosses.reset();
                fieldGeneratorTies.reset();
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
            protected override void handle_result(TypeLastTenJSON  result)
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
            public TypeLastTenJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeLastTenJSON  result)
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
        protected virtual void handle_result(List<TypeLastTenJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeLastTenJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeLastTenJSON>();
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
        public List<TypeLastTenJSON> value;
      };
      };
    private bool flagHasWins;
    private BigInteger storeWins;
    private bool flagHasLosses;
    private BigInteger storeLosses;
    private bool flagHasOvertimeLosses;
    private BigInteger storeOvertimeLosses;
    private bool flagHasTies;
    private BigInteger storeTies;
    private bool flagHasPoints;
    private double storePoints;
    private string textStorePoints;
    private bool flagHasWinningPercentage;
    private double storeWinningPercentage;
    private string textStoreWinningPercentage;
    private bool flagHasConferenceRecord;
    private TypeConferenceRecordJSON  storeConferenceRecord;
    private bool flagHasStreak;
    private TypeStreakJSON  storeStreak;
    private bool flagHasLastTen;
    private TypeLastTenJSON  storeLastTen;
    private bool flagHasGamesBehind;
    private double storeGamesBehind;
    private string textStoreGamesBehind;
    private bool flagHasGamesBehindWildCard;
    private double storeGamesBehindWildCard;
    private string textStoreGamesBehindWildCard;
    private bool flagHasGamesAheadWildCard;
    private double storeGamesAheadWildCard;
    private string textStoreGamesAheadWildCard;
    private bool flagHasEliminationNumber;
    private BigInteger storeEliminationNumber;
    private bool flagHasRank;
    private BigInteger storeRank;
    private bool flagHasRankTied;
    private bool storeRankTied;
    private bool flagHasDivisionLeader;
    private bool storeDivisionLeader;
    private bool flagHasDivisionLeaderTied;
    private bool storeDivisionLeaderTied;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONWins(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Wins of SportsStandingsDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Wins of SportsStandingsDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setWins(extracted_integer);
      }


    private void  fromJSONLosses(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Losses of SportsStandingsDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Losses of SportsStandingsDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setLosses(extracted_integer);
      }


    private void  fromJSONOvertimeLosses(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field OvertimeLosses of SportsStandingsDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field OvertimeLosses of SportsStandingsDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setOvertimeLosses(extracted_integer);
      }


    private void  fromJSONTies(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Ties of SportsStandingsDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Ties of SportsStandingsDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTies(extracted_integer);
      }


    private void  fromJSONPoints(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Points of SportsStandingsDataJSON is not a number.");
              }
          }
        setPointsText(the_rational_text);
      }


    private void  fromJSONWinningPercentage(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field WinningPercentage of SportsStandingsDataJSON is not a number.");
              }
          }
        setWinningPercentageText(the_rational_text);
      }


    private void  fromJSONConferenceRecord(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeConferenceRecordJSON convert_classy = TypeConferenceRecordJSON.from_json(json_value, ignore_extras, true);
        setConferenceRecord(convert_classy);
      }


    private void  fromJSONStreak(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeStreakJSON convert_classy = TypeStreakJSON.from_json(json_value, ignore_extras, true);
        setStreak(convert_classy);
      }


    private void  fromJSONLastTen(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeLastTenJSON convert_classy = TypeLastTenJSON.from_json(json_value, ignore_extras, true);
        setLastTen(convert_classy);
      }


    private void  fromJSONGamesBehind(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field GamesBehind of SportsStandingsDataJSON is not a number.");
              }
          }
        setGamesBehindText(the_rational_text);
      }


    private void  fromJSONGamesBehindWildCard(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field GamesBehindWildCard of SportsStandingsDataJSON is not a number.");
              }
          }
        setGamesBehindWildCardText(the_rational_text);
      }


    private void  fromJSONGamesAheadWildCard(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field GamesAheadWildCard of SportsStandingsDataJSON is not a number.");
              }
          }
        setGamesAheadWildCardText(the_rational_text);
      }


    private void  fromJSONEliminationNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field EliminationNumber of SportsStandingsDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field EliminationNumber of SportsStandingsDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setEliminationNumber(extracted_integer);
      }


    private void  fromJSONRank(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Rank of SportsStandingsDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Rank of SportsStandingsDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRank(extracted_integer);
      }


    private void  fromJSONRankTied(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RankTied of SportsStandingsDataJSON is not true for false.");
              }
          }
        setRankTied(the_bool);
      }


    private void  fromJSONDivisionLeader(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DivisionLeader of SportsStandingsDataJSON is not true for false.");
              }
          }
        setDivisionLeader(the_bool);
      }


    private void  fromJSONDivisionLeaderTied(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DivisionLeaderTied of SportsStandingsDataJSON is not true for false.");
              }
          }
        setDivisionLeaderTied(the_bool);
      }


    public SportsStandingsDataJSON()
      {
        flagHasWins = false;
        flagHasLosses = false;
        flagHasOvertimeLosses = false;
        flagHasTies = false;
        flagHasPoints = false;
        flagHasWinningPercentage = false;
        flagHasConferenceRecord = false;
        flagHasStreak = false;
        flagHasLastTen = false;
        flagHasGamesBehind = false;
        flagHasGamesBehindWildCard = false;
        flagHasGamesAheadWildCard = false;
        flagHasEliminationNumber = false;
        flagHasRank = false;
        flagHasRankTied = false;
        flagHasDivisionLeader = false;
        flagHasDivisionLeaderTied = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasWins()
      {
        return flagHasWins;
      }

    public BigInteger  getWins()
      {
        Debug.Assert(flagHasWins);
        return storeWins;
      }

    public bool  hasLosses()
      {
        return flagHasLosses;
      }

    public BigInteger  getLosses()
      {
        Debug.Assert(flagHasLosses);
        return storeLosses;
      }

    public bool  hasOvertimeLosses()
      {
        return flagHasOvertimeLosses;
      }

    public BigInteger  getOvertimeLosses()
      {
        Debug.Assert(flagHasOvertimeLosses);
        return storeOvertimeLosses;
      }

    public bool  hasTies()
      {
        return flagHasTies;
      }

    public BigInteger  getTies()
      {
        Debug.Assert(flagHasTies);
        return storeTies;
      }

    public bool  hasPoints()
      {
        return flagHasPoints;
      }

    public double  getPoints()
      {
        Debug.Assert(flagHasPoints);
        if (textStorePoints != "")
          {
            return Double.Parse(textStorePoints);
          }
        return storePoints;
      }

    public string  getPointsAsText()
      {
        Debug.Assert(flagHasPoints);
        if (textStorePoints == "")
          {
            return Convert.ToString(storePoints);
          }
        else
          {
            return (textStorePoints);
          }
      }

    public bool  hasWinningPercentage()
      {
        return flagHasWinningPercentage;
      }

    public double  getWinningPercentage()
      {
        Debug.Assert(flagHasWinningPercentage);
        if (textStoreWinningPercentage != "")
          {
            return Double.Parse(textStoreWinningPercentage);
          }
        return storeWinningPercentage;
      }

    public string  getWinningPercentageAsText()
      {
        Debug.Assert(flagHasWinningPercentage);
        if (textStoreWinningPercentage == "")
          {
            return Convert.ToString(storeWinningPercentage);
          }
        else
          {
            return (textStoreWinningPercentage);
          }
      }

    public bool  hasConferenceRecord()
      {
        return flagHasConferenceRecord;
      }

    public TypeConferenceRecordJSON   getConferenceRecord()
      {
        Debug.Assert(flagHasConferenceRecord);
        return storeConferenceRecord;
      }

    public bool  hasStreak()
      {
        return flagHasStreak;
      }

    public TypeStreakJSON   getStreak()
      {
        Debug.Assert(flagHasStreak);
        return storeStreak;
      }

    public bool  hasLastTen()
      {
        return flagHasLastTen;
      }

    public TypeLastTenJSON   getLastTen()
      {
        Debug.Assert(flagHasLastTen);
        return storeLastTen;
      }

    public bool  hasGamesBehind()
      {
        return flagHasGamesBehind;
      }

    public double  getGamesBehind()
      {
        Debug.Assert(flagHasGamesBehind);
        if (textStoreGamesBehind != "")
          {
            return Double.Parse(textStoreGamesBehind);
          }
        return storeGamesBehind;
      }

    public string  getGamesBehindAsText()
      {
        Debug.Assert(flagHasGamesBehind);
        if (textStoreGamesBehind == "")
          {
            return Convert.ToString(storeGamesBehind);
          }
        else
          {
            return (textStoreGamesBehind);
          }
      }

    public bool  hasGamesBehindWildCard()
      {
        return flagHasGamesBehindWildCard;
      }

    public double  getGamesBehindWildCard()
      {
        Debug.Assert(flagHasGamesBehindWildCard);
        if (textStoreGamesBehindWildCard != "")
          {
            return Double.Parse(textStoreGamesBehindWildCard);
          }
        return storeGamesBehindWildCard;
      }

    public string  getGamesBehindWildCardAsText()
      {
        Debug.Assert(flagHasGamesBehindWildCard);
        if (textStoreGamesBehindWildCard == "")
          {
            return Convert.ToString(storeGamesBehindWildCard);
          }
        else
          {
            return (textStoreGamesBehindWildCard);
          }
      }

    public bool  hasGamesAheadWildCard()
      {
        return flagHasGamesAheadWildCard;
      }

    public double  getGamesAheadWildCard()
      {
        Debug.Assert(flagHasGamesAheadWildCard);
        if (textStoreGamesAheadWildCard != "")
          {
            return Double.Parse(textStoreGamesAheadWildCard);
          }
        return storeGamesAheadWildCard;
      }

    public string  getGamesAheadWildCardAsText()
      {
        Debug.Assert(flagHasGamesAheadWildCard);
        if (textStoreGamesAheadWildCard == "")
          {
            return Convert.ToString(storeGamesAheadWildCard);
          }
        else
          {
            return (textStoreGamesAheadWildCard);
          }
      }

    public bool  hasEliminationNumber()
      {
        return flagHasEliminationNumber;
      }

    public BigInteger  getEliminationNumber()
      {
        Debug.Assert(flagHasEliminationNumber);
        return storeEliminationNumber;
      }

    public bool  hasRank()
      {
        return flagHasRank;
      }

    public BigInteger  getRank()
      {
        Debug.Assert(flagHasRank);
        return storeRank;
      }

    public bool  hasRankTied()
      {
        return flagHasRankTied;
      }

    public bool  getRankTied()
      {
        Debug.Assert(flagHasRankTied);
        return storeRankTied;
      }

    public bool  hasDivisionLeader()
      {
        return flagHasDivisionLeader;
      }

    public bool  getDivisionLeader()
      {
        Debug.Assert(flagHasDivisionLeader);
        return storeDivisionLeader;
      }

    public bool  hasDivisionLeaderTied()
      {
        return flagHasDivisionLeaderTied;
      }

    public bool  getDivisionLeaderTied()
      {
        Debug.Assert(flagHasDivisionLeaderTied);
        return storeDivisionLeaderTied;
      }


    public virtual int extraSportsStandingsDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStandingsDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStandingsDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStandingsDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setWins(BigInteger new_value)
      {
        flagHasWins = true;
        if (new_value < 0)
            throw new Exception("The value for field Wins of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        storeWins = new_value;
      }
    public void unsetWins()
      {
        flagHasWins = false;
      }
    public void setLosses(BigInteger new_value)
      {
        flagHasLosses = true;
        if (new_value < 0)
            throw new Exception("The value for field Losses of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        storeLosses = new_value;
      }
    public void unsetLosses()
      {
        flagHasLosses = false;
      }
    public void setOvertimeLosses(BigInteger new_value)
      {
        flagHasOvertimeLosses = true;
        if (new_value < 0)
            throw new Exception("The value for field OvertimeLosses of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        storeOvertimeLosses = new_value;
      }
    public void unsetOvertimeLosses()
      {
        flagHasOvertimeLosses = false;
      }
    public void setTies(BigInteger new_value)
      {
        flagHasTies = true;
        if (new_value < 0)
            throw new Exception("The value for field Ties of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        storeTies = new_value;
      }
    public void unsetTies()
      {
        flagHasTies = false;
      }
    public void setPoints(double new_value)
      {
        flagHasPoints = true;
        if (new_value < 0)
            throw new Exception("The value for field Points of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        storePoints = new_value;
        textStorePoints = "";
      }
    public void setPointsText(string new_value)
      {
        flagHasPoints = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Points of SportsStandingsDataJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Points of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        textStorePoints = new_value;
      }
    public void unsetPoints()
      {
        flagHasPoints = false;
      }
    public void setWinningPercentage(double new_value)
      {
        flagHasWinningPercentage = true;
        if (new_value < 0)
            throw new Exception("The value for field WinningPercentage of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field WinningPercentage of SportsStandingsDataJSON is greater than the upper bound (1) for that field.");
        storeWinningPercentage = new_value;
        textStoreWinningPercentage = "";
      }
    public void setWinningPercentageText(string new_value)
      {
        flagHasWinningPercentage = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field WinningPercentage of SportsStandingsDataJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field WinningPercentage of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "1", "", false, "1") > 0)
            throw new Exception("The value for field WinningPercentage of SportsStandingsDataJSON is greater than the upper bound (1) for that field.");
        textStoreWinningPercentage = new_value;
      }
    public void unsetWinningPercentage()
      {
        flagHasWinningPercentage = false;
      }
    public void setConferenceRecord(TypeConferenceRecordJSON  new_value)
      {
        if (flagHasConferenceRecord)
          {
          }
        flagHasConferenceRecord = true;
        storeConferenceRecord = new_value;
      }
    public void unsetConferenceRecord()
      {
        if (flagHasConferenceRecord)
          {
          }
        flagHasConferenceRecord = false;
      }
    public void setStreak(TypeStreakJSON  new_value)
      {
        if (flagHasStreak)
          {
          }
        flagHasStreak = true;
        storeStreak = new_value;
      }
    public void unsetStreak()
      {
        if (flagHasStreak)
          {
          }
        flagHasStreak = false;
      }
    public void setLastTen(TypeLastTenJSON  new_value)
      {
        if (flagHasLastTen)
          {
          }
        flagHasLastTen = true;
        storeLastTen = new_value;
      }
    public void unsetLastTen()
      {
        if (flagHasLastTen)
          {
          }
        flagHasLastTen = false;
      }
    public void setGamesBehind(double new_value)
      {
        flagHasGamesBehind = true;
        if (new_value < 0)
            throw new Exception("The value for field GamesBehind of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        storeGamesBehind = new_value;
        textStoreGamesBehind = "";
      }
    public void setGamesBehindText(string new_value)
      {
        flagHasGamesBehind = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field GamesBehind of SportsStandingsDataJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field GamesBehind of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        textStoreGamesBehind = new_value;
      }
    public void unsetGamesBehind()
      {
        flagHasGamesBehind = false;
      }
    public void setGamesBehindWildCard(double new_value)
      {
        flagHasGamesBehindWildCard = true;
        if (new_value < 0)
            throw new Exception("The value for field GamesBehindWildCard of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        storeGamesBehindWildCard = new_value;
        textStoreGamesBehindWildCard = "";
      }
    public void setGamesBehindWildCardText(string new_value)
      {
        flagHasGamesBehindWildCard = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field GamesBehindWildCard of SportsStandingsDataJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field GamesBehindWildCard of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        textStoreGamesBehindWildCard = new_value;
      }
    public void unsetGamesBehindWildCard()
      {
        flagHasGamesBehindWildCard = false;
      }
    public void setGamesAheadWildCard(double new_value)
      {
        flagHasGamesAheadWildCard = true;
        if (new_value < 0)
            throw new Exception("The value for field GamesAheadWildCard of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        storeGamesAheadWildCard = new_value;
        textStoreGamesAheadWildCard = "";
      }
    public void setGamesAheadWildCardText(string new_value)
      {
        flagHasGamesAheadWildCard = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field GamesAheadWildCard of SportsStandingsDataJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field GamesAheadWildCard of SportsStandingsDataJSON is less than the lower bound (0) for that field.");
        textStoreGamesAheadWildCard = new_value;
      }
    public void unsetGamesAheadWildCard()
      {
        flagHasGamesAheadWildCard = false;
      }
    public void setEliminationNumber(BigInteger new_value)
      {
        flagHasEliminationNumber = true;
        storeEliminationNumber = new_value;
      }
    public void unsetEliminationNumber()
      {
        flagHasEliminationNumber = false;
      }
    public void setRank(BigInteger new_value)
      {
        flagHasRank = true;
        if (new_value < 1)
            throw new Exception("The value for field Rank of SportsStandingsDataJSON is less than the lower bound (1) for that field.");
        storeRank = new_value;
      }
    public void unsetRank()
      {
        flagHasRank = false;
      }
    public void setRankTied(bool new_value)
      {
        flagHasRankTied = true;
        storeRankTied = new_value;
      }
    public void unsetRankTied()
      {
        flagHasRankTied = false;
      }
    public void setDivisionLeader(bool new_value)
      {
        flagHasDivisionLeader = true;
        storeDivisionLeader = new_value;
      }
    public void unsetDivisionLeader()
      {
        flagHasDivisionLeader = false;
      }
    public void setDivisionLeaderTied(bool new_value)
      {
        flagHasDivisionLeaderTied = true;
        storeDivisionLeaderTied = new_value;
      }
    public void unsetDivisionLeaderTied()
      {
        flagHasDivisionLeaderTied = false;
      }

    public virtual void extraSportsStandingsDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStandingsDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStandingsDataLookup(key);
        if (old_field == null)
          {
            extraSportsStandingsDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasWins);
        if (flagHasWins)
          {
            handler.start_pair("Wins");
            handler.number_value(storeWins);
          }
        Debug.Assert(partial_allowed || flagHasLosses);
        if (flagHasLosses)
          {
            handler.start_pair("Losses");
            handler.number_value(storeLosses);
          }
        if (flagHasOvertimeLosses)
          {
            handler.start_pair("OvertimeLosses");
            handler.number_value(storeOvertimeLosses);
          }
        if (flagHasTies)
          {
            handler.start_pair("Ties");
            handler.number_value(storeTies);
          }
        if (flagHasPoints)
          {
            handler.start_pair("Points");
            if (textStorePoints != "")
                handler.number_value(textStorePoints);
            else if (((double)(long)storePoints) == storePoints)
                handler.number_value((long)storePoints);
            else
                handler.number_value(storePoints);
          }
        if (flagHasWinningPercentage)
          {
            handler.start_pair("WinningPercentage");
            if (textStoreWinningPercentage != "")
                handler.number_value(textStoreWinningPercentage);
            else if (((double)(long)storeWinningPercentage) == storeWinningPercentage)
                handler.number_value((long)storeWinningPercentage);
            else
                handler.number_value(storeWinningPercentage);
          }
        if (flagHasConferenceRecord)
          {
            handler.start_pair("ConferenceRecord");
            if (partial_allowed)
                storeConferenceRecord.write_partial_as_json(handler);
            else
                storeConferenceRecord.write_as_json(handler);
          }
        if (flagHasStreak)
          {
            handler.start_pair("Streak");
            if (partial_allowed)
                storeStreak.write_partial_as_json(handler);
            else
                storeStreak.write_as_json(handler);
          }
        if (flagHasLastTen)
          {
            handler.start_pair("LastTen");
            if (partial_allowed)
                storeLastTen.write_partial_as_json(handler);
            else
                storeLastTen.write_as_json(handler);
          }
        if (flagHasGamesBehind)
          {
            handler.start_pair("GamesBehind");
            if (textStoreGamesBehind != "")
                handler.number_value(textStoreGamesBehind);
            else if (((double)(long)storeGamesBehind) == storeGamesBehind)
                handler.number_value((long)storeGamesBehind);
            else
                handler.number_value(storeGamesBehind);
          }
        if (flagHasGamesBehindWildCard)
          {
            handler.start_pair("GamesBehindWildCard");
            if (textStoreGamesBehindWildCard != "")
                handler.number_value(textStoreGamesBehindWildCard);
            else if (((double)(long)storeGamesBehindWildCard) == storeGamesBehindWildCard)
                handler.number_value((long)storeGamesBehindWildCard);
            else
                handler.number_value(storeGamesBehindWildCard);
          }
        if (flagHasGamesAheadWildCard)
          {
            handler.start_pair("GamesAheadWildCard");
            if (textStoreGamesAheadWildCard != "")
                handler.number_value(textStoreGamesAheadWildCard);
            else if (((double)(long)storeGamesAheadWildCard) == storeGamesAheadWildCard)
                handler.number_value((long)storeGamesAheadWildCard);
            else
                handler.number_value(storeGamesAheadWildCard);
          }
        if (flagHasEliminationNumber)
          {
            handler.start_pair("EliminationNumber");
            handler.number_value(storeEliminationNumber);
          }
        if (flagHasRank)
          {
            handler.start_pair("Rank");
            handler.number_value(storeRank);
          }
        if (flagHasRankTied)
          {
            handler.start_pair("RankTied");
            handler.boolean_value(storeRankTied);
          }
        if (flagHasDivisionLeader)
          {
            handler.start_pair("DivisionLeader");
            handler.boolean_value(storeDivisionLeader);
          }
        if (flagHasDivisionLeaderTied)
          {
            handler.start_pair("DivisionLeaderTied");
            handler.boolean_value(storeDivisionLeaderTied);
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
        if (!(hasWins()))
          {
            return "When parsing the object for %what%, the \"Wins\" field was missing.";
          }
        if (!(hasLosses()))
          {
            return "When parsing the object for %what%, the \"Losses\" field was missing.";
          }
        return null;
      }

    public static SportsStandingsDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsData", ignore_extras);
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
    public static SportsStandingsDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsData", ignore_extras);
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
    public static SportsStandingsDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsDataJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStandingsDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorWins : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorWins(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorWins : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorWins(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorWins fieldGeneratorWins;
    private class FieldHoldingGeneratorLosses : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorLosses(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorLosses : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorLosses(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorLosses fieldGeneratorLosses;
    private class FieldHoldingGeneratorOvertimeLosses : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorOvertimeLosses(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorOvertimeLosses : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorOvertimeLosses(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorOvertimeLosses fieldGeneratorOvertimeLosses;
    private class FieldHoldingGeneratorTies : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTies(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTies : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTies(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTies fieldGeneratorTies;
        private JSONHoldingNumberTextGenerator fieldGeneratorPoints;
        private JSONHoldingNumberTextGenerator fieldGeneratorWinningPercentage;
        private TypeConferenceRecordJSON.HoldingGenerator fieldGeneratorConferenceRecord;
        private TypeStreakJSON.HoldingGenerator fieldGeneratorStreak;
        private TypeLastTenJSON.HoldingGenerator fieldGeneratorLastTen;
        private JSONHoldingNumberTextGenerator fieldGeneratorGamesBehind;
        private JSONHoldingNumberTextGenerator fieldGeneratorGamesBehindWildCard;
        private JSONHoldingNumberTextGenerator fieldGeneratorGamesAheadWildCard;
    private class FieldHoldingGeneratorEliminationNumber : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorEliminationNumber(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorEliminationNumber : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorEliminationNumber(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorEliminationNumber fieldGeneratorEliminationNumber;
    private class FieldHoldingGeneratorRank : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRank(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRank : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRank(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorRank fieldGeneratorRank;
        private JSONHoldingBooleanGenerator fieldGeneratorRankTied;
        private JSONHoldingBooleanGenerator fieldGeneratorDivisionLeader;
        private JSONHoldingBooleanGenerator fieldGeneratorDivisionLeaderTied;
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
            SportsStandingsDataJSON result = new SportsStandingsDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStandingsDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsStandingsDataJSON result)
          {
            if (fieldGeneratorWins.have_value)
              {
                result.setWins(fieldGeneratorWins.value);
                fieldGeneratorWins.have_value = false;
              }
            else if ((!(result.hasWins())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Wins\" field was missing.");
              }
            if (fieldGeneratorLosses.have_value)
              {
                result.setLosses(fieldGeneratorLosses.value);
                fieldGeneratorLosses.have_value = false;
              }
            else if ((!(result.hasLosses())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Losses\" field was missing.");
              }
            if (fieldGeneratorOvertimeLosses.have_value)
              {
                result.setOvertimeLosses(fieldGeneratorOvertimeLosses.value);
                fieldGeneratorOvertimeLosses.have_value = false;
              }
            if (fieldGeneratorTies.have_value)
              {
                result.setTies(fieldGeneratorTies.value);
                fieldGeneratorTies.have_value = false;
              }
            if (fieldGeneratorPoints.have_value)
              {
                result.setPointsText(fieldGeneratorPoints.value);
                fieldGeneratorPoints.have_value = false;
              }
            if (fieldGeneratorWinningPercentage.have_value)
              {
                result.setWinningPercentageText(fieldGeneratorWinningPercentage.value);
                fieldGeneratorWinningPercentage.have_value = false;
              }
            if (fieldGeneratorConferenceRecord.have_value)
              {
                result.setConferenceRecord(fieldGeneratorConferenceRecord.value);
                fieldGeneratorConferenceRecord.have_value = false;
              }
            if (fieldGeneratorStreak.have_value)
              {
                result.setStreak(fieldGeneratorStreak.value);
                fieldGeneratorStreak.have_value = false;
              }
            if (fieldGeneratorLastTen.have_value)
              {
                result.setLastTen(fieldGeneratorLastTen.value);
                fieldGeneratorLastTen.have_value = false;
              }
            if (fieldGeneratorGamesBehind.have_value)
              {
                result.setGamesBehindText(fieldGeneratorGamesBehind.value);
                fieldGeneratorGamesBehind.have_value = false;
              }
            if (fieldGeneratorGamesBehindWildCard.have_value)
              {
                result.setGamesBehindWildCardText(fieldGeneratorGamesBehindWildCard.value);
                fieldGeneratorGamesBehindWildCard.have_value = false;
              }
            if (fieldGeneratorGamesAheadWildCard.have_value)
              {
                result.setGamesAheadWildCardText(fieldGeneratorGamesAheadWildCard.value);
                fieldGeneratorGamesAheadWildCard.have_value = false;
              }
            if (fieldGeneratorEliminationNumber.have_value)
              {
                result.setEliminationNumber(fieldGeneratorEliminationNumber.value);
                fieldGeneratorEliminationNumber.have_value = false;
              }
            if (fieldGeneratorRank.have_value)
              {
                result.setRank(fieldGeneratorRank.value);
                fieldGeneratorRank.have_value = false;
              }
            if (fieldGeneratorRankTied.have_value)
              {
                result.setRankTied(fieldGeneratorRankTied.value);
                fieldGeneratorRankTied.have_value = false;
              }
            if (fieldGeneratorDivisionLeader.have_value)
              {
                result.setDivisionLeader(fieldGeneratorDivisionLeader.value);
                fieldGeneratorDivisionLeader.have_value = false;
              }
            if (fieldGeneratorDivisionLeaderTied.have_value)
              {
                result.setDivisionLeaderTied(fieldGeneratorDivisionLeaderTied.value);
                fieldGeneratorDivisionLeaderTied.have_value = false;
              }
          }
        protected abstract void handle_result(SportsStandingsDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "onferenceRecord", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorConferenceRecord;
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "ivisionLeader", 0, 13, false) == 0)
                      {
                        if (field_name.Length == 14)
                          {
                            return fieldGeneratorDivisionLeader;
                          }
                        switch (field_name[14])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 15, "ied", 0, 3, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorDivisionLeaderTied;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "liminationNumber", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorEliminationNumber;
                    break;
                case 'G':
                    if (String.Compare(field_name, 1, "ames", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 6, "headWildCard", 0, 12, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorGamesAheadWildCard;
                                break;
                            case 'B':
                                if (String.Compare(field_name, 6, "ehind", 0, 5, false) == 0)
                                  {
                                    if (field_name.Length == 11)
                                      {
                                        return fieldGeneratorGamesBehind;
                                      }
                                    switch (field_name[11])
                                      {
                                        case 'W':
                                            if ((String.Compare(field_name, 12, "ildCard", 0, 7, false) == 0) && (field_name.Length == 19))
                                                return fieldGeneratorGamesBehindWildCard;
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
                case 'L':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "stTen", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorLastTen;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "sses", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorLosses;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "vertimeLosses", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorOvertimeLosses;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "oints", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorPoints;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "ank", 0, 3, false) == 0)
                      {
                        if (field_name.Length == 4)
                          {
                            return fieldGeneratorRank;
                          }
                        switch (field_name[4])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 5, "ied", 0, 3, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorRankTied;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "treak", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorStreak;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ies", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorTies;
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "in", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'n':
                                if ((String.Compare(field_name, 4, "ingPercentage", 0, 13, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorWinningPercentage;
                                break;
                            case 's':
                                if (field_name.Length == 4)
                                    return fieldGeneratorWins;
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
            fieldGeneratorWins = new FieldHoldingGeneratorWins("field \"Wins\" of the SportsStandingsData class");
            fieldGeneratorLosses = new FieldHoldingGeneratorLosses("field \"Losses\" of the SportsStandingsData class");
            fieldGeneratorOvertimeLosses = new FieldHoldingGeneratorOvertimeLosses("field \"OvertimeLosses\" of the SportsStandingsData class");
            fieldGeneratorTies = new FieldHoldingGeneratorTies("field \"Ties\" of the SportsStandingsData class");
            fieldGeneratorPoints = new JSONHoldingNumberTextGenerator("field \"Points\" of the SportsStandingsData class");
            fieldGeneratorWinningPercentage = new JSONHoldingNumberTextGenerator("field \"WinningPercentage\" of the SportsStandingsData class");
            fieldGeneratorConferenceRecord = new TypeConferenceRecordJSON.HoldingGenerator("field \"ConferenceRecord\" of the SportsStandingsData class", ignore_extras);
            fieldGeneratorStreak = new TypeStreakJSON.HoldingGenerator("field \"Streak\" of the SportsStandingsData class", ignore_extras);
            fieldGeneratorLastTen = new TypeLastTenJSON.HoldingGenerator("field \"LastTen\" of the SportsStandingsData class", ignore_extras);
            fieldGeneratorGamesBehind = new JSONHoldingNumberTextGenerator("field \"GamesBehind\" of the SportsStandingsData class");
            fieldGeneratorGamesBehindWildCard = new JSONHoldingNumberTextGenerator("field \"GamesBehindWildCard\" of the SportsStandingsData class");
            fieldGeneratorGamesAheadWildCard = new JSONHoldingNumberTextGenerator("field \"GamesAheadWildCard\" of the SportsStandingsData class");
            fieldGeneratorEliminationNumber = new FieldHoldingGeneratorEliminationNumber("field \"EliminationNumber\" of the SportsStandingsData class");
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsStandingsData class");
            fieldGeneratorRankTied = new JSONHoldingBooleanGenerator("field \"RankTied\" of the SportsStandingsData class");
            fieldGeneratorDivisionLeader = new JSONHoldingBooleanGenerator("field \"DivisionLeader\" of the SportsStandingsData class");
            fieldGeneratorDivisionLeaderTied = new JSONHoldingBooleanGenerator("field \"DivisionLeaderTied\" of the SportsStandingsData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStandingsData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorWins = new FieldHoldingGeneratorWins("field \"Wins\" of the SportsStandingsData class");
            fieldGeneratorLosses = new FieldHoldingGeneratorLosses("field \"Losses\" of the SportsStandingsData class");
            fieldGeneratorOvertimeLosses = new FieldHoldingGeneratorOvertimeLosses("field \"OvertimeLosses\" of the SportsStandingsData class");
            fieldGeneratorTies = new FieldHoldingGeneratorTies("field \"Ties\" of the SportsStandingsData class");
            fieldGeneratorPoints = new JSONHoldingNumberTextGenerator("field \"Points\" of the SportsStandingsData class");
            fieldGeneratorWinningPercentage = new JSONHoldingNumberTextGenerator("field \"WinningPercentage\" of the SportsStandingsData class");
            fieldGeneratorConferenceRecord = new TypeConferenceRecordJSON.HoldingGenerator("field \"ConferenceRecord\" of the SportsStandingsData class", false);
            fieldGeneratorStreak = new TypeStreakJSON.HoldingGenerator("field \"Streak\" of the SportsStandingsData class", false);
            fieldGeneratorLastTen = new TypeLastTenJSON.HoldingGenerator("field \"LastTen\" of the SportsStandingsData class", false);
            fieldGeneratorGamesBehind = new JSONHoldingNumberTextGenerator("field \"GamesBehind\" of the SportsStandingsData class");
            fieldGeneratorGamesBehindWildCard = new JSONHoldingNumberTextGenerator("field \"GamesBehindWildCard\" of the SportsStandingsData class");
            fieldGeneratorGamesAheadWildCard = new JSONHoldingNumberTextGenerator("field \"GamesAheadWildCard\" of the SportsStandingsData class");
            fieldGeneratorEliminationNumber = new FieldHoldingGeneratorEliminationNumber("field \"EliminationNumber\" of the SportsStandingsData class");
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsStandingsData class");
            fieldGeneratorRankTied = new JSONHoldingBooleanGenerator("field \"RankTied\" of the SportsStandingsData class");
            fieldGeneratorDivisionLeader = new JSONHoldingBooleanGenerator("field \"DivisionLeader\" of the SportsStandingsData class");
            fieldGeneratorDivisionLeaderTied = new JSONHoldingBooleanGenerator("field \"DivisionLeaderTied\" of the SportsStandingsData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStandingsData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorWins.reset();
            fieldGeneratorLosses.reset();
            fieldGeneratorOvertimeLosses.reset();
            fieldGeneratorTies.reset();
            fieldGeneratorPoints.reset();
            fieldGeneratorWinningPercentage.reset();
            fieldGeneratorConferenceRecord.reset();
            fieldGeneratorStreak.reset();
            fieldGeneratorLastTen.reset();
            fieldGeneratorGamesBehind.reset();
            fieldGeneratorGamesBehindWildCard.reset();
            fieldGeneratorGamesAheadWildCard.reset();
            fieldGeneratorEliminationNumber.reset();
            fieldGeneratorRank.reset();
            fieldGeneratorRankTied.reset();
            fieldGeneratorDivisionLeader.reset();
            fieldGeneratorDivisionLeaderTied.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorConferenceRecord.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStreak.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLastTen.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorConferenceRecord.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStreak.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLastTen.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStandingsDataJSON  result)
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
        public SportsStandingsDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsDataJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsDataJSON>();
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
    public List<SportsStandingsDataJSON> value;
  };
  };
