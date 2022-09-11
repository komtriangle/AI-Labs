/* file "SportsResultScoreCricketJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsResultScoreCricketJSON : SportsResultScoreJSON
  {
    public enum TypeSportsGameKind
      {
        SportsGameKind_Cricket
      };

    public static TypeSportsGameKind  stringToSportsGameKind(string chars)
      {
        if ((String.Compare(chars, 0, "Cricket", 0, 7, false) == 0) && (chars.Length == 7))
            return TypeSportsGameKind.SportsGameKind_Cricket;
        throw new Exception("The value for field `SportsGameKind' is not one of the legal values.");
      }

    public static string  stringFromSportsGameKind(TypeSportsGameKind the_enum)
      {
        switch (the_enum)
          {
            case TypeSportsGameKind.SportsGameKind_Cricket:
                return "Cricket";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeMatchFormatKnownValues
      {
        MatchFormat_ODI,
        MatchFormat_T20,
        MatchFormat_T20I,
        MatchFormat_Test,
        MatchFormat_ListA,
        MatchFormat_FirstClass,
        MatchFormat__none
      };
    public struct TypeMatchFormat
      {
        public bool in_known_list;
        public string string_value;
        public TypeMatchFormatKnownValues list_value;
      };

    public static TypeMatchFormatKnownValues  stringToMatchFormat(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "irstClass", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeMatchFormatKnownValues.MatchFormat_FirstClass;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "istA", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeMatchFormatKnownValues.MatchFormat_ListA;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "DI", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeMatchFormatKnownValues.MatchFormat_ODI;
                break;
            case 'T':
                switch (chars[1])
                  {
                    case '2':
                        if (String.Compare(chars, 2, "0", 0, 1, false) == 0)
                          {
                            if (chars.Length == 3)
                              {
                                return TypeMatchFormatKnownValues.MatchFormat_T20;
                              }
                            switch (chars[3])
                              {
                                case 'I':
                                    if (chars.Length == 4)
                                        return TypeMatchFormatKnownValues.MatchFormat_T20I;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "st", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeMatchFormatKnownValues.MatchFormat_Test;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return TypeMatchFormatKnownValues.MatchFormat__none;
      }

    public static string  stringFromMatchFormat(TypeMatchFormatKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeMatchFormatKnownValues.MatchFormat_ODI:
                return "ODI";
            case TypeMatchFormatKnownValues.MatchFormat_T20:
                return "T20";
            case TypeMatchFormatKnownValues.MatchFormat_T20I:
                return "T20I";
            case TypeMatchFormatKnownValues.MatchFormat_Test:
                return "Test";
            case TypeMatchFormatKnownValues.MatchFormat_ListA:
                return "ListA";
            case TypeMatchFormatKnownValues.MatchFormat_FirstClass:
                return "FirstClass";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeInningsJSON : JSONBase
      {
        private bool flagHasTeamIndex;
        private sbyte storeTeamIndex;
        private bool flagHasRuns;
        private BigInteger storeRuns;
        private bool flagHasWicketsLost;
        private sbyte storeWicketsLost;
        private bool flagHasOvers;
        private double storeOvers;
        private string textStoreOvers;
        private bool flagHasAllottedOvers;
        private double storeAllottedOvers;
        private string textStoreAllottedOvers;
        private bool flagHasDeclared;
        private bool storeDeclared;
        private bool flagHasFollowedOn;
        private bool storeFollowedOn;
        private bool flagHasTarget;
        private BigInteger storeTarget;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTeamIndex(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field TeamIndex of TypeInningsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field TeamIndex of TypeInningsJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setTeamIndex(extracted_integer);
          }


        private void  fromJSONRuns(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Runs of TypeInningsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Runs of TypeInningsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setRuns(extracted_integer);
          }


        private void  fromJSONWicketsLost(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field WicketsLost of TypeInningsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field WicketsLost of TypeInningsJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setWicketsLost(extracted_integer);
          }


        private void  fromJSONOvers(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Overs of TypeInningsJSON is not a number.");
                  }
              }
            setOversText(the_rational_text);
          }


        private void  fromJSONAllottedOvers(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field AllottedOvers of TypeInningsJSON is not a number.");
                  }
              }
            setAllottedOversText(the_rational_text);
          }


        private void  fromJSONDeclared(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Declared of TypeInningsJSON is not true for false.");
                  }
              }
            setDeclared(the_bool);
          }


        private void  fromJSONFollowedOn(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field FollowedOn of TypeInningsJSON is not true for false.");
                  }
              }
            setFollowedOn(the_bool);
          }


        private void  fromJSONTarget(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Target of TypeInningsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Target of TypeInningsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setTarget(extracted_integer);
          }


        public TypeInningsJSON()
          {
            flagHasTeamIndex = false;
            flagHasRuns = false;
            flagHasWicketsLost = false;
            flagHasOvers = false;
            flagHasAllottedOvers = false;
            flagHasDeclared = false;
            flagHasFollowedOn = false;
            flagHasTarget = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTeamIndex()
          {
            return flagHasTeamIndex;
          }

        public sbyte  getTeamIndex()
          {
            Debug.Assert(flagHasTeamIndex);
            return storeTeamIndex;
          }

        public bool  hasRuns()
          {
            return flagHasRuns;
          }

        public BigInteger  getRuns()
          {
            Debug.Assert(flagHasRuns);
            return storeRuns;
          }

        public bool  hasWicketsLost()
          {
            return flagHasWicketsLost;
          }

        public sbyte  getWicketsLost()
          {
            Debug.Assert(flagHasWicketsLost);
            return storeWicketsLost;
          }

        public bool  hasOvers()
          {
            return flagHasOvers;
          }

        public double  getOvers()
          {
            Debug.Assert(flagHasOvers);
            if (textStoreOvers != "")
              {
                return Double.Parse(textStoreOvers);
              }
            return storeOvers;
          }

        public string  getOversAsText()
          {
            Debug.Assert(flagHasOvers);
            if (textStoreOvers == "")
              {
                return Convert.ToString(storeOvers);
              }
            else
              {
                return (textStoreOvers);
              }
          }

        public bool  hasAllottedOvers()
          {
            return flagHasAllottedOvers;
          }

        public double  getAllottedOvers()
          {
            Debug.Assert(flagHasAllottedOvers);
            if (textStoreAllottedOvers != "")
              {
                return Double.Parse(textStoreAllottedOvers);
              }
            return storeAllottedOvers;
          }

        public string  getAllottedOversAsText()
          {
            Debug.Assert(flagHasAllottedOvers);
            if (textStoreAllottedOvers == "")
              {
                return Convert.ToString(storeAllottedOvers);
              }
            else
              {
                return (textStoreAllottedOvers);
              }
          }

        public bool  hasDeclared()
          {
            return flagHasDeclared;
          }

        public bool  getDeclared()
          {
            Debug.Assert(flagHasDeclared);
            return storeDeclared;
          }

        public bool  hasFollowedOn()
          {
            return flagHasFollowedOn;
          }

        public bool  getFollowedOn()
          {
            Debug.Assert(flagHasFollowedOn);
            return storeFollowedOn;
          }

        public bool  hasTarget()
          {
            return flagHasTarget;
          }

        public BigInteger  getTarget()
          {
            Debug.Assert(flagHasTarget);
            return storeTarget;
          }


        public virtual int extraTypeInningsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeInningsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeInningsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeInningsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setTeamIndex(sbyte new_value)
          {
            flagHasTeamIndex = true;
            if (new_value < 0)
                throw new Exception("The value for field TeamIndex of TypeInningsJSON is less than the lower bound (0) for that field.");
            if (new_value > 1)
                throw new Exception("The value for field TeamIndex of TypeInningsJSON is greater than the upper bound (1) for that field.");
            storeTeamIndex = new_value;
          }
        public void unsetTeamIndex()
          {
            flagHasTeamIndex = false;
          }
        public void setRuns(BigInteger new_value)
          {
            flagHasRuns = true;
            if (new_value < 0)
                throw new Exception("The value for field Runs of TypeInningsJSON is less than the lower bound (0) for that field.");
            storeRuns = new_value;
          }
        public void unsetRuns()
          {
            flagHasRuns = false;
          }
        public void setWicketsLost(sbyte new_value)
          {
            flagHasWicketsLost = true;
            if (new_value < 0)
                throw new Exception("The value for field WicketsLost of TypeInningsJSON is less than the lower bound (0) for that field.");
            if (new_value > 10)
                throw new Exception("The value for field WicketsLost of TypeInningsJSON is greater than the upper bound (10) for that field.");
            storeWicketsLost = new_value;
          }
        public void unsetWicketsLost()
          {
            flagHasWicketsLost = false;
          }
        public void setOvers(double new_value)
          {
            flagHasOvers = true;
            if (new_value < 0)
                throw new Exception("The value for field Overs of TypeInningsJSON is less than the lower bound (0) for that field.");
            storeOvers = new_value;
            textStoreOvers = "";
          }
        public void setOversText(string new_value)
          {
            flagHasOvers = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Overs of TypeInningsJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field Overs of TypeInningsJSON is less than the lower bound (0) for that field.");
            textStoreOvers = new_value;
          }
        public void unsetOvers()
          {
            flagHasOvers = false;
          }
        public void setAllottedOvers(double new_value)
          {
            flagHasAllottedOvers = true;
            if (new_value < 0)
                throw new Exception("The value for field AllottedOvers of TypeInningsJSON is less than the lower bound (0) for that field.");
            storeAllottedOvers = new_value;
            textStoreAllottedOvers = "";
          }
        public void setAllottedOversText(string new_value)
          {
            flagHasAllottedOvers = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field AllottedOvers of TypeInningsJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
                throw new Exception("The value for field AllottedOvers of TypeInningsJSON is less than the lower bound (0) for that field.");
            textStoreAllottedOvers = new_value;
          }
        public void unsetAllottedOvers()
          {
            flagHasAllottedOvers = false;
          }
        public void setDeclared(bool new_value)
          {
            flagHasDeclared = true;
            storeDeclared = new_value;
          }
        public void unsetDeclared()
          {
            flagHasDeclared = false;
          }
        public void setFollowedOn(bool new_value)
          {
            flagHasFollowedOn = true;
            storeFollowedOn = new_value;
          }
        public void unsetFollowedOn()
          {
            flagHasFollowedOn = false;
          }
        public void setTarget(BigInteger new_value)
          {
            flagHasTarget = true;
            if (new_value < 0)
                throw new Exception("The value for field Target of TypeInningsJSON is less than the lower bound (0) for that field.");
            storeTarget = new_value;
          }
        public void unsetTarget()
          {
            flagHasTarget = false;
          }

        public virtual void extraTypeInningsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeInningsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeInningsLookup(key);
            if (old_field == null)
              {
                extraTypeInningsAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasTeamIndex);
            if (flagHasTeamIndex)
              {
                handler.start_pair("TeamIndex");
                handler.number_value(storeTeamIndex);
              }
            if (flagHasRuns)
              {
                handler.start_pair("Runs");
                handler.number_value(storeRuns);
              }
            if (flagHasWicketsLost)
              {
                handler.start_pair("WicketsLost");
                handler.number_value(storeWicketsLost);
              }
            if (flagHasOvers)
              {
                handler.start_pair("Overs");
                if (textStoreOvers != "")
                    handler.number_value(textStoreOvers);
                else if (((double)(long)storeOvers) == storeOvers)
                    handler.number_value((long)storeOvers);
                else
                    handler.number_value(storeOvers);
              }
            if (flagHasAllottedOvers)
              {
                handler.start_pair("AllottedOvers");
                if (textStoreAllottedOvers != "")
                    handler.number_value(textStoreAllottedOvers);
                else if (((double)(long)storeAllottedOvers) == storeAllottedOvers)
                    handler.number_value((long)storeAllottedOvers);
                else
                    handler.number_value(storeAllottedOvers);
              }
            if (flagHasDeclared)
              {
                handler.start_pair("Declared");
                handler.boolean_value(storeDeclared);
              }
            if (flagHasFollowedOn)
              {
                handler.start_pair("FollowedOn");
                handler.boolean_value(storeFollowedOn);
              }
            if (flagHasTarget)
              {
                handler.start_pair("Target");
                handler.number_value(storeTarget);
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
            if (!(hasTeamIndex()))
              {
                return "When parsing the object for %what%, the \"TeamIndex\" field was missing.";
              }
            return null;
          }

        public static TypeInningsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeInningsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeInnings", ignore_extras);
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
        public static TypeInningsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeInningsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeInningsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeInnings", ignore_extras);
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
        public static TypeInningsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeInningsJSON from_text(string text, bool ignore_extras)
          {
            TypeInningsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeInnings", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeInningsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeInningsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeInningsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeInnings", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorTeamIndex : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorTeamIndex(String what) : base(what, 0, 1)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorTeamIndex : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorTeamIndex(String what) : base(what, 0, 1)
                  {
                  }
              };
            private FieldHoldingGeneratorTeamIndex fieldGeneratorTeamIndex;
        private class FieldHoldingGeneratorRuns : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorRuns(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorRuns : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorRuns(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorRuns fieldGeneratorRuns;
        private class FieldHoldingGeneratorWicketsLost : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorWicketsLost(String what) : base(what, 0, 10)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorWicketsLost : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorWicketsLost(String what) : base(what, 0, 10)
                  {
                  }
              };
            private FieldHoldingGeneratorWicketsLost fieldGeneratorWicketsLost;
            private JSONHoldingNumberTextGenerator fieldGeneratorOvers;
            private JSONHoldingNumberTextGenerator fieldGeneratorAllottedOvers;
            private JSONHoldingBooleanGenerator fieldGeneratorDeclared;
            private JSONHoldingBooleanGenerator fieldGeneratorFollowedOn;
        private class FieldHoldingGeneratorTarget : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorTarget(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorTarget : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorTarget(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorTarget fieldGeneratorTarget;
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
                TypeInningsJSON result = new TypeInningsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeInningsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeInningsJSON result)
              {
                if (fieldGeneratorTeamIndex.have_value)
                  {
                    result.setTeamIndex((sbyte)(fieldGeneratorTeamIndex.value));
                    fieldGeneratorTeamIndex.have_value = false;
                  }
                else if ((!(result.hasTeamIndex())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"TeamIndex\" field was missing.");
                  }
                if (fieldGeneratorRuns.have_value)
                  {
                    result.setRuns(fieldGeneratorRuns.value);
                    fieldGeneratorRuns.have_value = false;
                  }
                if (fieldGeneratorWicketsLost.have_value)
                  {
                    result.setWicketsLost((sbyte)(fieldGeneratorWicketsLost.value));
                    fieldGeneratorWicketsLost.have_value = false;
                  }
                if (fieldGeneratorOvers.have_value)
                  {
                    result.setOversText(fieldGeneratorOvers.value);
                    fieldGeneratorOvers.have_value = false;
                  }
                if (fieldGeneratorAllottedOvers.have_value)
                  {
                    result.setAllottedOversText(fieldGeneratorAllottedOvers.value);
                    fieldGeneratorAllottedOvers.have_value = false;
                  }
                if (fieldGeneratorDeclared.have_value)
                  {
                    result.setDeclared(fieldGeneratorDeclared.value);
                    fieldGeneratorDeclared.have_value = false;
                  }
                if (fieldGeneratorFollowedOn.have_value)
                  {
                    result.setFollowedOn(fieldGeneratorFollowedOn.value);
                    fieldGeneratorFollowedOn.have_value = false;
                  }
                if (fieldGeneratorTarget.have_value)
                  {
                    result.setTarget(fieldGeneratorTarget.value);
                    fieldGeneratorTarget.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeInningsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'A':
                        if ((String.Compare(field_name, 1, "llottedOvers", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorAllottedOvers;
                        break;
                    case 'D':
                        if ((String.Compare(field_name, 1, "eclared", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorDeclared;
                        break;
                    case 'F':
                        if ((String.Compare(field_name, 1, "ollowedOn", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorFollowedOn;
                        break;
                    case 'O':
                        if ((String.Compare(field_name, 1, "vers", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorOvers;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "uns", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorRuns;
                        break;
                    case 'T':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "rget", 0, 4, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorTarget;
                                break;
                            case 'e':
                                if ((String.Compare(field_name, 2, "amIndex", 0, 7, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorTeamIndex;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'W':
                        if ((String.Compare(field_name, 1, "icketsLost", 0, 10, false) == 0) && (field_name.Length == 11))
                            return fieldGeneratorWicketsLost;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorTeamIndex = new FieldHoldingGeneratorTeamIndex("field \"TeamIndex\" of the TypeInnings class");
                fieldGeneratorRuns = new FieldHoldingGeneratorRuns("field \"Runs\" of the TypeInnings class");
                fieldGeneratorWicketsLost = new FieldHoldingGeneratorWicketsLost("field \"WicketsLost\" of the TypeInnings class");
                fieldGeneratorOvers = new JSONHoldingNumberTextGenerator("field \"Overs\" of the TypeInnings class");
                fieldGeneratorAllottedOvers = new JSONHoldingNumberTextGenerator("field \"AllottedOvers\" of the TypeInnings class");
                fieldGeneratorDeclared = new JSONHoldingBooleanGenerator("field \"Declared\" of the TypeInnings class");
                fieldGeneratorFollowedOn = new JSONHoldingBooleanGenerator("field \"FollowedOn\" of the TypeInnings class");
                fieldGeneratorTarget = new FieldHoldingGeneratorTarget("field \"Target\" of the TypeInnings class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeInnings class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTeamIndex = new FieldHoldingGeneratorTeamIndex("field \"TeamIndex\" of the TypeInnings class");
                fieldGeneratorRuns = new FieldHoldingGeneratorRuns("field \"Runs\" of the TypeInnings class");
                fieldGeneratorWicketsLost = new FieldHoldingGeneratorWicketsLost("field \"WicketsLost\" of the TypeInnings class");
                fieldGeneratorOvers = new JSONHoldingNumberTextGenerator("field \"Overs\" of the TypeInnings class");
                fieldGeneratorAllottedOvers = new JSONHoldingNumberTextGenerator("field \"AllottedOvers\" of the TypeInnings class");
                fieldGeneratorDeclared = new JSONHoldingBooleanGenerator("field \"Declared\" of the TypeInnings class");
                fieldGeneratorFollowedOn = new JSONHoldingBooleanGenerator("field \"FollowedOn\" of the TypeInnings class");
                fieldGeneratorTarget = new FieldHoldingGeneratorTarget("field \"Target\" of the TypeInnings class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeInnings class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTeamIndex.reset();
                fieldGeneratorRuns.reset();
                fieldGeneratorWicketsLost.reset();
                fieldGeneratorOvers.reset();
                fieldGeneratorAllottedOvers.reset();
                fieldGeneratorDeclared.reset();
                fieldGeneratorFollowedOn.reset();
                fieldGeneratorTarget.reset();
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
            protected override void handle_result(TypeInningsJSON  result)
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
            public TypeInningsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeInningsJSON  result)
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
        protected virtual void handle_result(List<TypeInningsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeInningsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeInningsJSON>();
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
        public List<TypeInningsJSON> value;
      };
      };
    private bool flagHasSportsGameKind;
    private bool flagHasMatchFormat;
    private TypeMatchFormat storeMatchFormat;
    private bool flagHasInnings;
    private List< TypeInningsJSON  > storeInnings;
    private bool flagHasWinningTeamIndex;
    private sbyte storeWinningTeamIndex;
    private bool flagHasWinningTeamRunDifference;
    private BigInteger storeWinningTeamRunDifference;
    private bool flagHasWinningTeamWicketDifference;
    private sbyte storeWinningTeamWicketDifference;
    private bool flagHasDraw;
    private bool storeDraw;
    private bool flagHasTie;
    private bool storeTie;
    private bool flagHasTieBreakingMethodUsed;
    private SportsCricketTieBreakingMethodJSON  storeTieBreakingMethodUsed;
    private bool flagHasDLSMethod;
    private bool storeDLSMethod;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraSportsGameKindToJSON()
      {
        JSONStringValue generated_string_SportsGameKind;
        generated_string_SportsGameKind = new JSONStringValue("Cricket");
        return generated_string_SportsGameKind;
      }

    private JSONValue  extraMatchFormatToJSON()
      {
        JSONStringValue generated_string_MatchFormat;
        if (!(storeMatchFormat.in_known_list))
          {
        generated_string_MatchFormat = new JSONStringValue(storeMatchFormat.string_value);
          }
        else
          {
        switch (storeMatchFormat.list_value)
          {
            case TypeMatchFormatKnownValues.MatchFormat_ODI:
                generated_string_MatchFormat = new JSONStringValue("ODI");
                break;
            case TypeMatchFormatKnownValues.MatchFormat_T20:
                generated_string_MatchFormat = new JSONStringValue("T20");
                break;
            case TypeMatchFormatKnownValues.MatchFormat_T20I:
                generated_string_MatchFormat = new JSONStringValue("T20I");
                break;
            case TypeMatchFormatKnownValues.MatchFormat_Test:
                generated_string_MatchFormat = new JSONStringValue("Test");
                break;
            case TypeMatchFormatKnownValues.MatchFormat_ListA:
                generated_string_MatchFormat = new JSONStringValue("ListA");
                break;
            case TypeMatchFormatKnownValues.MatchFormat_FirstClass:
                generated_string_MatchFormat = new JSONStringValue("FirstClass");
                break;
            default:
                Debug.Assert(false);
                generated_string_MatchFormat = null;
                break;
          }
          }
        return generated_string_MatchFormat;
      }

    private JSONValue  extraInningsToJSON()
      {
        JSONArrayValue generated_array_1_Innings = new JSONArrayValue();
        for (int num1 = 0; num1 < storeInnings.Count; ++num1)
          {
            JSONValueHandler handler_Innings = new JSONValueHandler();
            storeInnings[num1].write_as_json(handler_Innings);
            generated_array_1_Innings.appendComponent(handler_Innings.result);
          }
        return generated_array_1_Innings;
      }

    private JSONValue  extraWinningTeamIndexToJSON()
      {
        JSONIntegerValue generated_integer_WinningTeamIndex = new JSONIntegerValue(storeWinningTeamIndex);
        return generated_integer_WinningTeamIndex;
      }

    private JSONValue  extraWinningTeamRunDifferenceToJSON()
      {
        JSONIntegerValue generated_integer_WinningTeamRunDifference = new JSONIntegerValue(storeWinningTeamRunDifference);
        return generated_integer_WinningTeamRunDifference;
      }

    private JSONValue  extraWinningTeamWicketDifferenceToJSON()
      {
        JSONIntegerValue generated_integer_WinningTeamWicketDifference = new JSONIntegerValue(storeWinningTeamWicketDifference);
        return generated_integer_WinningTeamWicketDifference;
      }

    private JSONValue  extraDrawToJSON()
      {
        JSONValue generated_boolean_Draw = (storeDraw ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_Draw;
      }

    private JSONValue  extraTieToJSON()
      {
        JSONValue generated_boolean_Tie = (storeTie ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_Tie;
      }

    private JSONValue  extraTieBreakingMethodUsedToJSON()
      {
        JSONValueHandler handler_TieBreakingMethodUsed = new JSONValueHandler();
        storeTieBreakingMethodUsed.write_as_json(handler_TieBreakingMethodUsed);
        return handler_TieBreakingMethodUsed.result;
      }

    private JSONValue  extraDLSMethodToJSON()
      {
        JSONValue generated_boolean_DLSMethod = (storeDLSMethod ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_DLSMethod;
      }


    private void  fromJSONSportsGameKind(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SportsGameKind of SportsResultScoreCricketJSON is not a string.");
        if (!(json_string.getData().Equals("Cricket")))
            throw new Exception("The value for field SportsGameKind of SportsResultScoreCricketJSON is not `Cricket'.");
        setSportsGameKind();
      }


    private void  fromJSONMatchFormat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field MatchFormat of SportsResultScoreCricketJSON is not a string.");
        TypeMatchFormat the_open_enum = new TypeMatchFormat();
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "irstClass", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMatchFormatKnownValues.MatchFormat_FirstClass;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "istA", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMatchFormatKnownValues.MatchFormat_ListA;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "DI", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeMatchFormatKnownValues.MatchFormat_ODI;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                switch (json_string.getData()[1])
                  {
                    case '2':
                        if (String.Compare(json_string.getData(), 2, "0", 0, 1, false) == 0)
                          {
                            if (json_string.getData().Length == 3)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeMatchFormatKnownValues.MatchFormat_T20;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[3])
                              {
                                case 'I':
                                    if (json_string.getData().Length == 4)
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeMatchFormatKnownValues.MatchFormat_T20I;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'e':
                        if ((String.Compare(json_string.getData(), 2, "st", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeMatchFormatKnownValues.MatchFormat_Test;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setMatchFormat(the_open_enum);
      }


    private void  fromJSONInnings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Innings of SportsResultScoreCricketJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Innings of SportsResultScoreCricketJSON has too few elements.");
        List< TypeInningsJSON  > vector_Innings1 = new List< TypeInningsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeInningsJSON convert_classy = TypeInningsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Innings1.Add(convert_classy);
          }
        Debug.Assert(vector_Innings1.Count >= 1);
        initInnings();
        for (int num1 = 0; num1 < vector_Innings1.Count; ++num1)
            appendInnings(vector_Innings1[num1]);
        for (int num1 = 0; num1 < vector_Innings1.Count; ++num1)
          {
          }
      }


    private void  fromJSONWinningTeamIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field WinningTeamIndex of SportsResultScoreCricketJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field WinningTeamIndex of SportsResultScoreCricketJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setWinningTeamIndex(extracted_integer);
      }


    private void  fromJSONWinningTeamRunDifference(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field WinningTeamRunDifference of SportsResultScoreCricketJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field WinningTeamRunDifference of SportsResultScoreCricketJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setWinningTeamRunDifference(extracted_integer);
      }


    private void  fromJSONWinningTeamWicketDifference(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field WinningTeamWicketDifference of SportsResultScoreCricketJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field WinningTeamWicketDifference of SportsResultScoreCricketJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setWinningTeamWicketDifference(extracted_integer);
      }


    private void  fromJSONDraw(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Draw of SportsResultScoreCricketJSON is not true for false.");
              }
          }
        setDraw(the_bool);
      }


    private void  fromJSONTie(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Tie of SportsResultScoreCricketJSON is not true for false.");
              }
          }
        setTie(the_bool);
      }


    private void  fromJSONTieBreakingMethodUsed(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsCricketTieBreakingMethodJSON convert_classy = SportsCricketTieBreakingMethodJSON.from_json(json_value, ignore_extras, true);
        setTieBreakingMethodUsed(convert_classy);
      }


    private void  fromJSONDLSMethod(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DLSMethod of SportsResultScoreCricketJSON is not true for false.");
              }
          }
        setDLSMethod(the_bool);
      }


    public SportsResultScoreCricketJSON()
      {
        flagHasSportsGameKind = false;
        flagHasMatchFormat = false;
        flagHasInnings = false;
        flagHasWinningTeamIndex = false;
        flagHasWinningTeamRunDifference = false;
        flagHasWinningTeamWicketDifference = false;
        flagHasDraw = false;
        flagHasTie = false;
        flagHasTieBreakingMethodUsed = false;
        flagHasDLSMethod = false;
        storeInnings = new List< TypeInningsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsResultScoreKind()
      {
        return "Cricket";
      }

    public bool  hasSportsGameKind()
      {
        return flagHasSportsGameKind;
      }

    public TypeSportsGameKind  getSportsGameKind()
      {
        Debug.Assert(flagHasSportsGameKind);
        return TypeSportsGameKind.SportsGameKind_Cricket;
      }

    public string  getSportsGameKindAsString()
      {
        return stringFromSportsGameKind(getSportsGameKind());
      }

    public bool  hasMatchFormat()
      {
        return flagHasMatchFormat;
      }

    public TypeMatchFormat  getMatchFormat()
      {
        Debug.Assert(flagHasMatchFormat);
        return storeMatchFormat;
      }

    public string  getMatchFormatAsString()
      {
        TypeMatchFormat result = getMatchFormat();
        if (result.in_known_list)
            return stringFromMatchFormat(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasInnings()
      {
        return flagHasInnings;
      }

    public int  countOfInnings()
      {
        Debug.Assert(flagHasInnings);
        return storeInnings.Count;
      }

    public TypeInningsJSON   elementOfInnings(int element_num)
      {
        Debug.Assert(flagHasInnings);
        return storeInnings[element_num];
      }

    public List< TypeInningsJSON  >  getInnings()
      {
        Debug.Assert(flagHasInnings);
        return storeInnings;
      }

    public bool  hasWinningTeamIndex()
      {
        return flagHasWinningTeamIndex;
      }

    public sbyte  getWinningTeamIndex()
      {
        Debug.Assert(flagHasWinningTeamIndex);
        return storeWinningTeamIndex;
      }

    public bool  hasWinningTeamRunDifference()
      {
        return flagHasWinningTeamRunDifference;
      }

    public BigInteger  getWinningTeamRunDifference()
      {
        Debug.Assert(flagHasWinningTeamRunDifference);
        return storeWinningTeamRunDifference;
      }

    public bool  hasWinningTeamWicketDifference()
      {
        return flagHasWinningTeamWicketDifference;
      }

    public sbyte  getWinningTeamWicketDifference()
      {
        Debug.Assert(flagHasWinningTeamWicketDifference);
        return storeWinningTeamWicketDifference;
      }

    public bool  hasDraw()
      {
        return flagHasDraw;
      }

    public bool  getDraw()
      {
        Debug.Assert(flagHasDraw);
        return storeDraw;
      }

    public bool  hasTie()
      {
        return flagHasTie;
      }

    public bool  getTie()
      {
        Debug.Assert(flagHasTie);
        return storeTie;
      }

    public bool  hasTieBreakingMethodUsed()
      {
        return flagHasTieBreakingMethodUsed;
      }

    public SportsCricketTieBreakingMethodJSON   getTieBreakingMethodUsed()
      {
        Debug.Assert(flagHasTieBreakingMethodUsed);
        return storeTieBreakingMethodUsed;
      }

    public SportsCricketTieBreakingMethodJSON.TypeValue  getTieBreakingMethodUsedValue()
      {
        return getTieBreakingMethodUsed().getValue();
      }

    public string  getTieBreakingMethodUsedAsString()
      {
        return getTieBreakingMethodUsed().getValueAsString();
      }

    public bool  hasDLSMethod()
      {
        return flagHasDLSMethod;
      }

    public bool  getDLSMethod()
      {
        Debug.Assert(flagHasDLSMethod);
        return storeDLSMethod;
      }


    public virtual int extraSportsResultScoreCricketComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsResultScoreCricketComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsResultScoreCricketComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsResultScoreCricketLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsResultScoreComponentCount()
      {
        int result = 0;
        if (flagHasSportsGameKind)
            ++result;
        if (flagHasMatchFormat)
            ++result;
        if (flagHasInnings)
            ++result;
        if (flagHasWinningTeamIndex)
            ++result;
        if (flagHasWinningTeamRunDifference)
            ++result;
        if (flagHasWinningTeamWicketDifference)
            ++result;
        if (flagHasDraw)
            ++result;
        if (flagHasTie)
            ++result;
        if (flagHasTieBreakingMethodUsed)
            ++result;
        if (flagHasDLSMethod)
            ++result;
        result += extraSportsResultScoreCricketComponentCount();
        return result;
      }
    public override string extraSportsResultScoreComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasSportsGameKind)
          {
            if (remainder == 0)
                return "SportsGameKind";
            --remainder;
          }
        if (flagHasMatchFormat)
          {
            if (remainder == 0)
                return "MatchFormat";
            --remainder;
          }
        if (flagHasInnings)
          {
            if (remainder == 0)
                return "Innings";
            --remainder;
          }
        if (flagHasWinningTeamIndex)
          {
            if (remainder == 0)
                return "WinningTeamIndex";
            --remainder;
          }
        if (flagHasWinningTeamRunDifference)
          {
            if (remainder == 0)
                return "WinningTeamRunDifference";
            --remainder;
          }
        if (flagHasWinningTeamWicketDifference)
          {
            if (remainder == 0)
                return "WinningTeamWicketDifference";
            --remainder;
          }
        if (flagHasDraw)
          {
            if (remainder == 0)
                return "Draw";
            --remainder;
          }
        if (flagHasTie)
          {
            if (remainder == 0)
                return "Tie";
            --remainder;
          }
        if (flagHasTieBreakingMethodUsed)
          {
            if (remainder == 0)
                return "TieBreakingMethodUsed";
            --remainder;
          }
        if (flagHasDLSMethod)
          {
            if (remainder == 0)
                return "DLSMethod";
            --remainder;
          }
        return extraSportsResultScoreCricketComponentKey(remainder);
      }
    public override JSONValue extraSportsResultScoreComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasSportsGameKind)
          {
            if (remainder == 0)
                return extraSportsGameKindToJSON();
            --remainder;
          }
        if (flagHasMatchFormat)
          {
            if (remainder == 0)
                return extraMatchFormatToJSON();
            --remainder;
          }
        if (flagHasInnings)
          {
            if (remainder == 0)
                return extraInningsToJSON();
            --remainder;
          }
        if (flagHasWinningTeamIndex)
          {
            if (remainder == 0)
                return extraWinningTeamIndexToJSON();
            --remainder;
          }
        if (flagHasWinningTeamRunDifference)
          {
            if (remainder == 0)
                return extraWinningTeamRunDifferenceToJSON();
            --remainder;
          }
        if (flagHasWinningTeamWicketDifference)
          {
            if (remainder == 0)
                return extraWinningTeamWicketDifferenceToJSON();
            --remainder;
          }
        if (flagHasDraw)
          {
            if (remainder == 0)
                return extraDrawToJSON();
            --remainder;
          }
        if (flagHasTie)
          {
            if (remainder == 0)
                return extraTieToJSON();
            --remainder;
          }
        if (flagHasTieBreakingMethodUsed)
          {
            if (remainder == 0)
                return extraTieBreakingMethodUsedToJSON();
            --remainder;
          }
        if (flagHasDLSMethod)
          {
            if (remainder == 0)
                return extraDLSMethodToJSON();
            --remainder;
          }
        return extraSportsResultScoreCricketComponentValue(remainder);
      }
    public override JSONValue extraSportsResultScoreLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                switch (field_name[1])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 2, "SMethod", 0, 7, false) == 0) && (field_name.Length == 9))
                            return (flagHasDLSMethod ? extraDLSMethodToJSON() : null);
                        break;
                    case 'r':
                        if ((String.Compare(field_name, 2, "aw", 0, 2, false) == 0) && (field_name.Length == 4))
                            return (flagHasDraw ? extraDrawToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "nnings", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasInnings ? extraInningsToJSON() : null);
                break;
            case 'M':
                if ((String.Compare(field_name, 1, "atchFormat", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasMatchFormat ? extraMatchFormatToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "portsGameKind", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasSportsGameKind ? extraSportsGameKindToJSON() : null);
                break;
            case 'T':
                if (String.Compare(field_name, 1, "ie", 0, 2, false) == 0)
                  {
                    if (field_name.Length == 3)
                      {
                        return (flagHasTie ? extraTieToJSON() : null);
                      }
                    switch (field_name[3])
                      {
                        case 'B':
                            if ((String.Compare(field_name, 4, "reakingMethodUsed", 0, 17, false) == 0) && (field_name.Length == 21))
                                return (flagHasTieBreakingMethodUsed ? extraTieBreakingMethodUsedToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if (String.Compare(field_name, 1, "inningTeam", 0, 10, false) == 0)
                  {
                    switch (field_name[11])
                      {
                        case 'I':
                            if ((String.Compare(field_name, 12, "ndex", 0, 4, false) == 0) && (field_name.Length == 16))
                                return (flagHasWinningTeamIndex ? extraWinningTeamIndexToJSON() : null);
                            break;
                        case 'R':
                            if ((String.Compare(field_name, 12, "unDifference", 0, 12, false) == 0) && (field_name.Length == 24))
                                return (flagHasWinningTeamRunDifference ? extraWinningTeamRunDifferenceToJSON() : null);
                            break;
                        case 'W':
                            if ((String.Compare(field_name, 12, "icketDifference", 0, 15, false) == 0) && (field_name.Length == 27))
                                return (flagHasWinningTeamWicketDifference ? extraWinningTeamWicketDifferenceToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraSportsResultScoreCricketLookup(field_name);
      }

    public void setSportsGameKind()
      {
        flagHasSportsGameKind = true;
      }
    public void setSportsGameKind(TypeSportsGameKind new_value)
      {
        setSportsGameKind();
      }
    public void setSportsGameKind(string chars)
      {
        setSportsGameKind(stringToSportsGameKind(chars));
      }
    public void unsetSportsGameKind()
      {
        flagHasSportsGameKind = false;
      }
    public void setMatchFormat(TypeMatchFormat new_value)
      {
        flagHasMatchFormat = true;
        storeMatchFormat = new_value;
      }
    public void setMatchFormat(string chars)
      {
        TypeMatchFormatKnownValues known = stringToMatchFormat(chars);
        TypeMatchFormat new_value = new TypeMatchFormat();
        if (known == TypeMatchFormatKnownValues.MatchFormat__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setMatchFormat(new_value);
      }
    public void setMatchFormat(TypeMatchFormatKnownValues new_value)
      {
        TypeMatchFormat new_full_value = new TypeMatchFormat();
        Debug.Assert(new_value != TypeMatchFormatKnownValues.MatchFormat__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setMatchFormat(new_full_value);
      }
    public void unsetMatchFormat()
      {
        flagHasMatchFormat = false;
      }
    public void initInnings()
      {
        if (flagHasInnings)
          {
            for (int num1 = 0; num1 < storeInnings.Count; ++num1)
              {
              }
          }
        flagHasInnings = true;
        storeInnings.Clear();
      }
    public void appendInnings(TypeInningsJSON  to_append)
      {
        if (!flagHasInnings)
          {
            flagHasInnings = true;
            storeInnings.Clear();
          }
        Debug.Assert(flagHasInnings);
        storeInnings.Add(to_append);
      }
    public void unsetInnings()
      {
        if (flagHasInnings)
          {
            for (int num2 = 0; num2 < storeInnings.Count; ++num2)
              {
              }
          }
        flagHasInnings = false;
        storeInnings.Clear();
      }
    public void setWinningTeamIndex(sbyte new_value)
      {
        flagHasWinningTeamIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field WinningTeamIndex of SportsResultScoreCricketJSON is less than the lower bound (0) for that field.");
        if (new_value > 1)
            throw new Exception("The value for field WinningTeamIndex of SportsResultScoreCricketJSON is greater than the upper bound (1) for that field.");
        storeWinningTeamIndex = new_value;
      }
    public void unsetWinningTeamIndex()
      {
        flagHasWinningTeamIndex = false;
      }
    public void setWinningTeamRunDifference(BigInteger new_value)
      {
        flagHasWinningTeamRunDifference = true;
        if (new_value < 1)
            throw new Exception("The value for field WinningTeamRunDifference of SportsResultScoreCricketJSON is less than the lower bound (1) for that field.");
        storeWinningTeamRunDifference = new_value;
      }
    public void unsetWinningTeamRunDifference()
      {
        flagHasWinningTeamRunDifference = false;
      }
    public void setWinningTeamWicketDifference(sbyte new_value)
      {
        flagHasWinningTeamWicketDifference = true;
        if (new_value < 1)
            throw new Exception("The value for field WinningTeamWicketDifference of SportsResultScoreCricketJSON is less than the lower bound (1) for that field.");
        if (new_value > 10)
            throw new Exception("The value for field WinningTeamWicketDifference of SportsResultScoreCricketJSON is greater than the upper bound (10) for that field.");
        storeWinningTeamWicketDifference = new_value;
      }
    public void unsetWinningTeamWicketDifference()
      {
        flagHasWinningTeamWicketDifference = false;
      }
    public void setDraw(bool new_value)
      {
        flagHasDraw = true;
        storeDraw = new_value;
      }
    public void unsetDraw()
      {
        flagHasDraw = false;
      }
    public void setTie(bool new_value)
      {
        flagHasTie = true;
        storeTie = new_value;
      }
    public void unsetTie()
      {
        flagHasTie = false;
      }
    public void setTieBreakingMethodUsed(SportsCricketTieBreakingMethodJSON  new_value)
      {
        if (flagHasTieBreakingMethodUsed)
          {
          }
        flagHasTieBreakingMethodUsed = true;
        storeTieBreakingMethodUsed = new_value;
      }
    public void setTieBreakingMethodUsed(SportsCricketTieBreakingMethodJSON.TypeValue new_value)
      {
        setTieBreakingMethodUsed(new SportsCricketTieBreakingMethodJSON(new_value));
      }
    public void setTieBreakingMethodUsed(string chars)
      {
        SportsCricketTieBreakingMethodJSON.TypeValueKnownValues known = SportsCricketTieBreakingMethodJSON.stringToValue(chars);
        SportsCricketTieBreakingMethodJSON.TypeValue new_value = new SportsCricketTieBreakingMethodJSON.TypeValue();
        if (known == SportsCricketTieBreakingMethodJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setTieBreakingMethodUsed(new_value);
      }
    public void unsetTieBreakingMethodUsed()
      {
        if (flagHasTieBreakingMethodUsed)
          {
          }
        flagHasTieBreakingMethodUsed = false;
      }
    public void setDLSMethod(bool new_value)
      {
        flagHasDLSMethod = true;
        storeDLSMethod = new_value;
      }
    public void unsetDLSMethod()
      {
        flagHasDLSMethod = false;
      }

    public virtual void extraSportsResultScoreCricketAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsResultScoreCricketSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsResultScoreCricketLookup(key);
        if (old_field == null)
          {
            extraSportsResultScoreCricketAppendPair(key, new_component);
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
    public override void extraSportsResultScoreAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                switch (key[1])
                  {
                    case 'L':
                        if ((String.Compare(key, 2, "SMethod", 0, 7, false) == 0) && (key.Length == 9))
                            {
                            fromJSONDLSMethod(new_component, false);
                            return;
                            }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "aw", 0, 2, false) == 0) && (key.Length == 4))
                            {
                            fromJSONDraw(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if ((String.Compare(key, 1, "nnings", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONInnings(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "atchFormat", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONMatchFormat(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "portsGameKind", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONSportsGameKind(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if (String.Compare(key, 1, "ie", 0, 2, false) == 0)
                  {
                    if (key.Length == 3)
                      {
                        {
                        fromJSONTie(new_component, false);
                        return;
                        }
                      }
                    switch (key[3])
                      {
                        case 'B':
                            if ((String.Compare(key, 4, "reakingMethodUsed", 0, 17, false) == 0) && (key.Length == 21))
                                {
                                fromJSONTieBreakingMethodUsed(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if (String.Compare(key, 1, "inningTeam", 0, 10, false) == 0)
                  {
                    switch (key[11])
                      {
                        case 'I':
                            if ((String.Compare(key, 12, "ndex", 0, 4, false) == 0) && (key.Length == 16))
                                {
                                fromJSONWinningTeamIndex(new_component, false);
                                return;
                                }
                            break;
                        case 'R':
                            if ((String.Compare(key, 12, "unDifference", 0, 12, false) == 0) && (key.Length == 24))
                                {
                                fromJSONWinningTeamRunDifference(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 12, "icketDifference", 0, 15, false) == 0) && (key.Length == 27))
                                {
                                fromJSONWinningTeamWicketDifference(new_component, false);
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
        extraSportsResultScoreCricketAppendPair(key, new_component);
      }
    public override void extraSportsResultScoreSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                switch (key[1])
                  {
                    case 'L':
                        if ((String.Compare(key, 2, "SMethod", 0, 7, false) == 0) && (key.Length == 9))
                            {
                            fromJSONDLSMethod(new_component, false);
                            return;
                            }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "aw", 0, 2, false) == 0) && (key.Length == 4))
                            {
                            fromJSONDraw(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'I':
                if ((String.Compare(key, 1, "nnings", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONInnings(new_component, false);
                    return;
                    }
                break;
            case 'M':
                if ((String.Compare(key, 1, "atchFormat", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONMatchFormat(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "portsGameKind", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONSportsGameKind(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if (String.Compare(key, 1, "ie", 0, 2, false) == 0)
                  {
                    if (key.Length == 3)
                      {
                        {
                        fromJSONTie(new_component, false);
                        return;
                        }
                      }
                    switch (key[3])
                      {
                        case 'B':
                            if ((String.Compare(key, 4, "reakingMethodUsed", 0, 17, false) == 0) && (key.Length == 21))
                                {
                                fromJSONTieBreakingMethodUsed(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'W':
                if (String.Compare(key, 1, "inningTeam", 0, 10, false) == 0)
                  {
                    switch (key[11])
                      {
                        case 'I':
                            if ((String.Compare(key, 12, "ndex", 0, 4, false) == 0) && (key.Length == 16))
                                {
                                fromJSONWinningTeamIndex(new_component, false);
                                return;
                                }
                            break;
                        case 'R':
                            if ((String.Compare(key, 12, "unDifference", 0, 12, false) == 0) && (key.Length == 24))
                                {
                                fromJSONWinningTeamRunDifference(new_component, false);
                                return;
                                }
                            break;
                        case 'W':
                            if ((String.Compare(key, 12, "icketDifference", 0, 15, false) == 0) && (key.Length == 27))
                                {
                                fromJSONWinningTeamWicketDifference(new_component, false);
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
        extraSportsResultScoreCricketSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSportsGameKind);
        if (flagHasSportsGameKind)
          {
            handler.start_pair("SportsGameKind");
            handler.string_value("Cricket");
          }
        if (flagHasMatchFormat)
          {
            handler.start_pair("MatchFormat");
            if (storeMatchFormat.in_known_list)
              {
                switch (storeMatchFormat.list_value)
                  {
                    case TypeMatchFormatKnownValues.MatchFormat_ODI:
                        handler.string_value("ODI");
                        break;
                    case TypeMatchFormatKnownValues.MatchFormat_T20:
                        handler.string_value("T20");
                        break;
                    case TypeMatchFormatKnownValues.MatchFormat_T20I:
                        handler.string_value("T20I");
                        break;
                    case TypeMatchFormatKnownValues.MatchFormat_Test:
                        handler.string_value("Test");
                        break;
                    case TypeMatchFormatKnownValues.MatchFormat_ListA:
                        handler.string_value("ListA");
                        break;
                    case TypeMatchFormatKnownValues.MatchFormat_FirstClass:
                        handler.string_value("FirstClass");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeMatchFormat.string_value);
              }
          }
        if (flagHasInnings)
          {
            handler.start_pair("Innings");
            Debug.Assert(storeInnings.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeInnings.Count; ++num1)
              {
                if (partial_allowed)
                    storeInnings[num1].write_partial_as_json(handler);
                else
                    storeInnings[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasWinningTeamIndex)
          {
            handler.start_pair("WinningTeamIndex");
            handler.number_value(storeWinningTeamIndex);
          }
        if (flagHasWinningTeamRunDifference)
          {
            handler.start_pair("WinningTeamRunDifference");
            handler.number_value(storeWinningTeamRunDifference);
          }
        if (flagHasWinningTeamWicketDifference)
          {
            handler.start_pair("WinningTeamWicketDifference");
            handler.number_value(storeWinningTeamWicketDifference);
          }
        if (flagHasDraw)
          {
            handler.start_pair("Draw");
            handler.boolean_value(storeDraw);
          }
        if (flagHasTie)
          {
            handler.start_pair("Tie");
            handler.boolean_value(storeTie);
          }
        if (flagHasTieBreakingMethodUsed)
          {
            handler.start_pair("TieBreakingMethodUsed");
            if (partial_allowed)
                storeTieBreakingMethodUsed.write_partial_as_json(handler);
            else
                storeTieBreakingMethodUsed.write_as_json(handler);
          }
        if (flagHasDLSMethod)
          {
            handler.start_pair("DLSMethod");
            handler.boolean_value(storeDLSMethod);
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
        if (!(hasSportsGameKind()))
          {
            return "When parsing the object for %what%, the \"SportsGameKind\" field was missing.";
          }
        return null;
      }

    public static new SportsResultScoreCricketJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsResultScoreCricketJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsResultScoreCricket", ignore_extras);
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
    public static new SportsResultScoreCricketJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsResultScoreCricketJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsResultScoreCricketJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsResultScoreCricket", ignore_extras);
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
    public static new SportsResultScoreCricketJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsResultScoreCricketJSON from_text(string text, bool ignore_extras)
      {
        SportsResultScoreCricketJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsResultScoreCricket", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsResultScoreCricketJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsResultScoreCricketJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsResultScoreCricketJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsResultScoreCricket", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsResultScoreJSON.Generator
      {
    private abstract class FieldGeneratorSportsGameKind : JSONStringGenerator
          {
            protected FieldGeneratorSportsGameKind(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSportsGameKind()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSportsGameKind(result));
              }
            protected abstract void handle_result(TypeSportsGameKind result);
          };
    private class FieldHoldingGeneratorSportsGameKind : FieldGeneratorSportsGameKind
  {
    protected override void handle_result(TypeSportsGameKind result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSportsGameKind(String what)
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
    public TypeSportsGameKind value;
  };
    private class FieldHoldingArrayGeneratorSportsGameKind : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSportsGameKind
      {
        private FieldHoldingArrayGeneratorSportsGameKind top;

        protected override void handle_result(TypeSportsGameKind result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSportsGameKind init_top)
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
    protected virtual void handle_result(List<TypeSportsGameKind> result)
      {
      }

    public FieldHoldingArrayGeneratorSportsGameKind(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSportsGameKind>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSportsGameKind()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSportsGameKind>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSportsGameKind> value;
  };
        private FieldHoldingGeneratorSportsGameKind fieldGeneratorSportsGameKind;
    private abstract class FieldGeneratorMatchFormat : JSONStringGenerator
          {
            protected FieldGeneratorMatchFormat(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorMatchFormat()
              {
              }
            protected override void handle_result(string result)
              {
                TypeMatchFormatKnownValues known = stringToMatchFormat(result);
                TypeMatchFormat new_value = new TypeMatchFormat();
                if (known == TypeMatchFormatKnownValues.MatchFormat__none)
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
            protected abstract void handle_result(TypeMatchFormat result);
          };
    private class FieldHoldingGeneratorMatchFormat : FieldGeneratorMatchFormat
  {
    protected override void handle_result(TypeMatchFormat result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorMatchFormat(String what)
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
    public TypeMatchFormat value;
  };
    private class FieldHoldingArrayGeneratorMatchFormat : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorMatchFormat
      {
        private FieldHoldingArrayGeneratorMatchFormat top;

        protected override void handle_result(TypeMatchFormat result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorMatchFormat init_top)
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
    protected virtual void handle_result(List<TypeMatchFormat> result)
      {
      }

    public FieldHoldingArrayGeneratorMatchFormat(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMatchFormat>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorMatchFormat()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeMatchFormat>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeMatchFormat> value;
  };
        private FieldHoldingGeneratorMatchFormat fieldGeneratorMatchFormat;
        private TypeInningsJSON.HoldingArrayGenerator fieldGeneratorInnings;
    private class FieldHoldingGeneratorWinningTeamIndex : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorWinningTeamIndex(String what) : base(what, 0, 1)
              {
              }
          };
    private class FieldHoldingArrayGeneratorWinningTeamIndex : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorWinningTeamIndex(String what) : base(what, 0, 1)
              {
              }
          };
        private FieldHoldingGeneratorWinningTeamIndex fieldGeneratorWinningTeamIndex;
    private class FieldHoldingGeneratorWinningTeamRunDifference : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorWinningTeamRunDifference(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorWinningTeamRunDifference : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorWinningTeamRunDifference(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorWinningTeamRunDifference fieldGeneratorWinningTeamRunDifference;
    private class FieldHoldingGeneratorWinningTeamWicketDifference : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorWinningTeamWicketDifference(String what) : base(what, 1, 10)
              {
              }
          };
    private class FieldHoldingArrayGeneratorWinningTeamWicketDifference : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorWinningTeamWicketDifference(String what) : base(what, 1, 10)
              {
              }
          };
        private FieldHoldingGeneratorWinningTeamWicketDifference fieldGeneratorWinningTeamWicketDifference;
        private JSONHoldingBooleanGenerator fieldGeneratorDraw;
        private JSONHoldingBooleanGenerator fieldGeneratorTie;
        private SportsCricketTieBreakingMethodJSON.HoldingGenerator fieldGeneratorTieBreakingMethodUsed;
        private JSONHoldingBooleanGenerator fieldGeneratorDLSMethod;
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
            if (!(getSportsResultScoreJSONKey().Equals("Cricket")))
                throw new Exception("The key field has a value other than `Cricket'.");
            SportsResultScoreCricketJSON result = new SportsResultScoreCricketJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsResultScoreCricketAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsResultScoreJSON new_result)
          {
            handle_result((SportsResultScoreCricketJSON )new_result);
          }
        protected void finish(SportsResultScoreCricketJSON result)
          {
            if (fieldGeneratorSportsGameKind.have_value)
              {
                result.setSportsGameKind();
                fieldGeneratorSportsGameKind.have_value = false;
              }
            else if ((!(result.hasSportsGameKind())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SportsGameKind\" field was missing.");
              }
            if (fieldGeneratorMatchFormat.have_value)
              {
                result.setMatchFormat(fieldGeneratorMatchFormat.value);
                fieldGeneratorMatchFormat.have_value = false;
              }
            if (fieldGeneratorInnings.have_value)
              {
                result.initInnings();
                int count = fieldGeneratorInnings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInnings(fieldGeneratorInnings.value[num]);
                  }
                fieldGeneratorInnings.value.Clear();
                fieldGeneratorInnings.have_value = false;
              }
            if (fieldGeneratorWinningTeamIndex.have_value)
              {
                result.setWinningTeamIndex((sbyte)(fieldGeneratorWinningTeamIndex.value));
                fieldGeneratorWinningTeamIndex.have_value = false;
              }
            if (fieldGeneratorWinningTeamRunDifference.have_value)
              {
                result.setWinningTeamRunDifference(fieldGeneratorWinningTeamRunDifference.value);
                fieldGeneratorWinningTeamRunDifference.have_value = false;
              }
            if (fieldGeneratorWinningTeamWicketDifference.have_value)
              {
                result.setWinningTeamWicketDifference((sbyte)(fieldGeneratorWinningTeamWicketDifference.value));
                fieldGeneratorWinningTeamWicketDifference.have_value = false;
              }
            if (fieldGeneratorDraw.have_value)
              {
                result.setDraw(fieldGeneratorDraw.value);
                fieldGeneratorDraw.have_value = false;
              }
            if (fieldGeneratorTie.have_value)
              {
                result.setTie(fieldGeneratorTie.value);
                fieldGeneratorTie.have_value = false;
              }
            if (fieldGeneratorTieBreakingMethodUsed.have_value)
              {
                result.setTieBreakingMethodUsed(fieldGeneratorTieBreakingMethodUsed.value);
                fieldGeneratorTieBreakingMethodUsed.have_value = false;
              }
            if (fieldGeneratorDLSMethod.have_value)
              {
                result.setDLSMethod(fieldGeneratorDLSMethod.value);
                fieldGeneratorDLSMethod.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsResultScoreCricketJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    switch (field_name[1])
                      {
                        case 'L':
                            if ((String.Compare(field_name, 2, "SMethod", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorDLSMethod;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "aw", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorDraw;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nnings", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorInnings;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "atchFormat", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMatchFormat;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "portsGameKind", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorSportsGameKind;
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "ie", 0, 2, false) == 0)
                      {
                        if (field_name.Length == 3)
                          {
                            return fieldGeneratorTie;
                          }
                        switch (field_name[3])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 4, "reakingMethodUsed", 0, 17, false) == 0) && (field_name.Length == 21))
                                    return fieldGeneratorTieBreakingMethodUsed;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'W':
                    if (String.Compare(field_name, 1, "inningTeam", 0, 10, false) == 0)
                      {
                        switch (field_name[11])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 12, "ndex", 0, 4, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorWinningTeamIndex;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 12, "unDifference", 0, 12, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorWinningTeamRunDifference;
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 12, "icketDifference", 0, 15, false) == 0) && (field_name.Length == 27))
                                    return fieldGeneratorWinningTeamWicketDifference;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorSportsGameKind = new FieldHoldingGeneratorSportsGameKind("field \"SportsGameKind\" of the SportsResultScoreCricket class");
            fieldGeneratorMatchFormat = new FieldHoldingGeneratorMatchFormat("field \"MatchFormat\" of the SportsResultScoreCricket class");
            fieldGeneratorInnings = new TypeInningsJSON.HoldingArrayGenerator("field \"Innings\" of the SportsResultScoreCricket class", ignore_extras);
            fieldGeneratorWinningTeamIndex = new FieldHoldingGeneratorWinningTeamIndex("field \"WinningTeamIndex\" of the SportsResultScoreCricket class");
            fieldGeneratorWinningTeamRunDifference = new FieldHoldingGeneratorWinningTeamRunDifference("field \"WinningTeamRunDifference\" of the SportsResultScoreCricket class");
            fieldGeneratorWinningTeamWicketDifference = new FieldHoldingGeneratorWinningTeamWicketDifference("field \"WinningTeamWicketDifference\" of the SportsResultScoreCricket class");
            fieldGeneratorDraw = new JSONHoldingBooleanGenerator("field \"Draw\" of the SportsResultScoreCricket class");
            fieldGeneratorTie = new JSONHoldingBooleanGenerator("field \"Tie\" of the SportsResultScoreCricket class");
            fieldGeneratorTieBreakingMethodUsed = new SportsCricketTieBreakingMethodJSON.HoldingGenerator("field \"TieBreakingMethodUsed\" of the SportsResultScoreCricket class", ignore_extras);
            fieldGeneratorDLSMethod = new JSONHoldingBooleanGenerator("field \"DLSMethod\" of the SportsResultScoreCricket class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsResultScoreCricket class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorSportsGameKind = new FieldHoldingGeneratorSportsGameKind("field \"SportsGameKind\" of the SportsResultScoreCricket class");
            fieldGeneratorMatchFormat = new FieldHoldingGeneratorMatchFormat("field \"MatchFormat\" of the SportsResultScoreCricket class");
            fieldGeneratorInnings = new TypeInningsJSON.HoldingArrayGenerator("field \"Innings\" of the SportsResultScoreCricket class", false);
            fieldGeneratorWinningTeamIndex = new FieldHoldingGeneratorWinningTeamIndex("field \"WinningTeamIndex\" of the SportsResultScoreCricket class");
            fieldGeneratorWinningTeamRunDifference = new FieldHoldingGeneratorWinningTeamRunDifference("field \"WinningTeamRunDifference\" of the SportsResultScoreCricket class");
            fieldGeneratorWinningTeamWicketDifference = new FieldHoldingGeneratorWinningTeamWicketDifference("field \"WinningTeamWicketDifference\" of the SportsResultScoreCricket class");
            fieldGeneratorDraw = new JSONHoldingBooleanGenerator("field \"Draw\" of the SportsResultScoreCricket class");
            fieldGeneratorTie = new JSONHoldingBooleanGenerator("field \"Tie\" of the SportsResultScoreCricket class");
            fieldGeneratorTieBreakingMethodUsed = new SportsCricketTieBreakingMethodJSON.HoldingGenerator("field \"TieBreakingMethodUsed\" of the SportsResultScoreCricket class", false);
            fieldGeneratorDLSMethod = new JSONHoldingBooleanGenerator("field \"DLSMethod\" of the SportsResultScoreCricket class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsResultScoreCricket class");
          }

        public override void reset()
          {
            fieldGeneratorSportsGameKind.reset();
            fieldGeneratorMatchFormat.reset();
            fieldGeneratorInnings.reset();
            fieldGeneratorWinningTeamIndex.reset();
            fieldGeneratorWinningTeamRunDifference.reset();
            fieldGeneratorWinningTeamWicketDifference.reset();
            fieldGeneratorDraw.reset();
            fieldGeneratorTie.reset();
            fieldGeneratorTieBreakingMethodUsed.reset();
            fieldGeneratorDLSMethod.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsResultScoreCricketJSON  result)
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
        public SportsResultScoreCricketJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsResultScoreCricketJSON  result)
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
    protected virtual void handle_result(List<SportsResultScoreCricketJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsResultScoreCricketJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsResultScoreCricketJSON>();
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
    public List<SportsResultScoreCricketJSON> value;
  };
  };
