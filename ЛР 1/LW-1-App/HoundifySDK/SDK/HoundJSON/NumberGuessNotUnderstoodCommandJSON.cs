/* file "NumberGuessNotUnderstoodCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class NumberGuessNotUnderstoodCommandJSON : NumberGuessCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        public enum TypeDifficultyKnownValues
          {
            Difficulty_Easy,
            Difficulty_Hard,
            Difficulty__none
          };
        public struct TypeDifficulty
          {
            public bool in_known_list;
            public string string_value;
            public TypeDifficultyKnownValues list_value;
          };

        public static TypeDifficultyKnownValues  stringToDifficulty(string chars)
          {
            switch (chars[0])
              {
                case 'E':
                    if ((String.Compare(chars, 1, "asy", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeDifficultyKnownValues.Difficulty_Easy;
                    break;
                case 'H':
                    if ((String.Compare(chars, 1, "ard", 0, 3, false) == 0) && (chars.Length == 4))
                        return TypeDifficultyKnownValues.Difficulty_Hard;
                    break;
                default:
                    break;
              }
            return TypeDifficultyKnownValues.Difficulty__none;
          }

        public static string  stringFromDifficulty(TypeDifficultyKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeDifficultyKnownValues.Difficulty_Easy:
                    return "Easy";
                case TypeDifficultyKnownValues.Difficulty_Hard:
                    return "Hard";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasDifficulty;
        private TypeDifficulty storeDifficulty;
        private bool flagHasMinimumPossibleValue;
        private BigInteger storeMinimumPossibleValue;
        private bool flagHasMaximumPossibleValue;
        private BigInteger storeMaximumPossibleValue;
        private bool flagHasLowerRangeHint;
        private BigInteger storeLowerRangeHint;
        private bool flagHasHigherRangeHint;
        private BigInteger storeHigherRangeHint;
        private bool flagHasGameState;
        private string storeGameState;
        private bool flagHasGuessesMade;
        private BigInteger storeGuessesMade;
        private bool flagHasLastGuess;
        private BigInteger storeLastGuess;
        private bool flagHasGuessToSolutionComparison;
        private sbyte storeGuessToSolutionComparison;
        private bool flagHasRoundOver;
        private bool storeRoundOver;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONDifficulty(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Difficulty of TypeNativeDataJSON is not a string.");
            TypeDifficulty the_open_enum = new TypeDifficulty();
            switch (json_string.getData()[0])
              {
                case 'E':
                    if ((String.Compare(json_string.getData(), 1, "asy", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDifficultyKnownValues.Difficulty_Easy;
                            goto open_enum_is_done;
                          }
                    break;
                case 'H':
                    if ((String.Compare(json_string.getData(), 1, "ard", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDifficultyKnownValues.Difficulty_Hard;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setDifficulty(the_open_enum);
          }


        private void  fromJSONMinimumPossibleValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field MinimumPossibleValue of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field MinimumPossibleValue of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setMinimumPossibleValue(extracted_integer);
          }


        private void  fromJSONMaximumPossibleValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field MaximumPossibleValue of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field MaximumPossibleValue of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setMaximumPossibleValue(extracted_integer);
          }


        private void  fromJSONLowerRangeHint(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field LowerRangeHint of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field LowerRangeHint of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setLowerRangeHint(extracted_integer);
          }


        private void  fromJSONHigherRangeHint(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field HigherRangeHint of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field HigherRangeHint of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setHigherRangeHint(extracted_integer);
          }


        private void  fromJSONGameState(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field GameState of TypeNativeDataJSON is not a string.");
            setGameState(json_string.getData());
          }


        private void  fromJSONGuessesMade(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field GuessesMade of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field GuessesMade of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setGuessesMade(extracted_integer);
          }


        private void  fromJSONLastGuess(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field LastGuess of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field LastGuess of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setLastGuess(extracted_integer);
          }


        private void  fromJSONGuessToSolutionComparison(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            sbyte extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field GuessToSolutionComparison of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field GuessToSolutionComparison of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = (sbyte)(json_rational.getLongInt())            ;
              }
            else
              {
                extracted_integer = (sbyte)(json_integer.getLongInt())            ;
              }
            setGuessToSolutionComparison(extracted_integer);
          }


        private void  fromJSONRoundOver(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field RoundOver of TypeNativeDataJSON is not true for false.");
                  }
              }
            setRoundOver(the_bool);
          }


        public TypeNativeDataJSON()
          {
            flagHasDifficulty = false;
            flagHasMinimumPossibleValue = false;
            flagHasMaximumPossibleValue = false;
            flagHasLowerRangeHint = false;
            flagHasHigherRangeHint = false;
            flagHasGameState = false;
            flagHasGuessesMade = false;
            flagHasLastGuess = false;
            flagHasGuessToSolutionComparison = false;
            flagHasRoundOver = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasDifficulty()
          {
            return flagHasDifficulty;
          }

        public TypeDifficulty  getDifficulty()
          {
            Debug.Assert(flagHasDifficulty);
            return storeDifficulty;
          }

        public string  getDifficultyAsString()
          {
            TypeDifficulty result = getDifficulty();
            if (result.in_known_list)
                return stringFromDifficulty(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasMinimumPossibleValue()
          {
            return flagHasMinimumPossibleValue;
          }

        public BigInteger  getMinimumPossibleValue()
          {
            Debug.Assert(flagHasMinimumPossibleValue);
            return storeMinimumPossibleValue;
          }

        public bool  hasMaximumPossibleValue()
          {
            return flagHasMaximumPossibleValue;
          }

        public BigInteger  getMaximumPossibleValue()
          {
            Debug.Assert(flagHasMaximumPossibleValue);
            return storeMaximumPossibleValue;
          }

        public bool  hasLowerRangeHint()
          {
            return flagHasLowerRangeHint;
          }

        public BigInteger  getLowerRangeHint()
          {
            Debug.Assert(flagHasLowerRangeHint);
            return storeLowerRangeHint;
          }

        public bool  hasHigherRangeHint()
          {
            return flagHasHigherRangeHint;
          }

        public BigInteger  getHigherRangeHint()
          {
            Debug.Assert(flagHasHigherRangeHint);
            return storeHigherRangeHint;
          }

        public bool  hasGameState()
          {
            return flagHasGameState;
          }

        public string  getGameState()
          {
            Debug.Assert(flagHasGameState);
            return storeGameState;
          }

        public bool  hasGuessesMade()
          {
            return flagHasGuessesMade;
          }

        public BigInteger  getGuessesMade()
          {
            Debug.Assert(flagHasGuessesMade);
            return storeGuessesMade;
          }

        public bool  hasLastGuess()
          {
            return flagHasLastGuess;
          }

        public BigInteger  getLastGuess()
          {
            Debug.Assert(flagHasLastGuess);
            return storeLastGuess;
          }

        public bool  hasGuessToSolutionComparison()
          {
            return flagHasGuessToSolutionComparison;
          }

        public sbyte  getGuessToSolutionComparison()
          {
            Debug.Assert(flagHasGuessToSolutionComparison);
            return storeGuessToSolutionComparison;
          }

        public bool  hasRoundOver()
          {
            return flagHasRoundOver;
          }

        public bool  getRoundOver()
          {
            Debug.Assert(flagHasRoundOver);
            return storeRoundOver;
          }


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setDifficulty(TypeDifficulty new_value)
          {
            flagHasDifficulty = true;
            storeDifficulty = new_value;
          }
        public void setDifficulty(string chars)
          {
            TypeDifficultyKnownValues known = stringToDifficulty(chars);
            TypeDifficulty new_value = new TypeDifficulty();
            if (known == TypeDifficultyKnownValues.Difficulty__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setDifficulty(new_value);
          }
        public void setDifficulty(TypeDifficultyKnownValues new_value)
          {
            TypeDifficulty new_full_value = new TypeDifficulty();
            Debug.Assert(new_value != TypeDifficultyKnownValues.Difficulty__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setDifficulty(new_full_value);
          }
        public void unsetDifficulty()
          {
            flagHasDifficulty = false;
          }
        public void setMinimumPossibleValue(BigInteger new_value)
          {
            flagHasMinimumPossibleValue = true;
            storeMinimumPossibleValue = new_value;
          }
        public void unsetMinimumPossibleValue()
          {
            flagHasMinimumPossibleValue = false;
          }
        public void setMaximumPossibleValue(BigInteger new_value)
          {
            flagHasMaximumPossibleValue = true;
            storeMaximumPossibleValue = new_value;
          }
        public void unsetMaximumPossibleValue()
          {
            flagHasMaximumPossibleValue = false;
          }
        public void setLowerRangeHint(BigInteger new_value)
          {
            flagHasLowerRangeHint = true;
            storeLowerRangeHint = new_value;
          }
        public void unsetLowerRangeHint()
          {
            flagHasLowerRangeHint = false;
          }
        public void setHigherRangeHint(BigInteger new_value)
          {
            flagHasHigherRangeHint = true;
            storeHigherRangeHint = new_value;
          }
        public void unsetHigherRangeHint()
          {
            flagHasHigherRangeHint = false;
          }
        public void setGameState(string new_value)
          {
            flagHasGameState = true;
            storeGameState = new_value;
          }
        public void unsetGameState()
          {
            flagHasGameState = false;
          }
        public void setGuessesMade(BigInteger new_value)
          {
            flagHasGuessesMade = true;
            if (new_value < 0)
                throw new Exception("The value for field GuessesMade of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeGuessesMade = new_value;
          }
        public void unsetGuessesMade()
          {
            flagHasGuessesMade = false;
          }
        public void setLastGuess(BigInteger new_value)
          {
            flagHasLastGuess = true;
            storeLastGuess = new_value;
          }
        public void unsetLastGuess()
          {
            flagHasLastGuess = false;
          }
        public void setGuessToSolutionComparison(sbyte new_value)
          {
            flagHasGuessToSolutionComparison = true;
            if (new_value < -1)
                throw new Exception("The value for field GuessToSolutionComparison of TypeNativeDataJSON is less than the lower bound (-1) for that field.");
            if (new_value > 1)
                throw new Exception("The value for field GuessToSolutionComparison of TypeNativeDataJSON is greater than the upper bound (1) for that field.");
            storeGuessToSolutionComparison = new_value;
          }
        public void unsetGuessToSolutionComparison()
          {
            flagHasGuessToSolutionComparison = false;
          }
        public void setRoundOver(bool new_value)
          {
            flagHasRoundOver = true;
            storeRoundOver = new_value;
          }
        public void unsetRoundOver()
          {
            flagHasRoundOver = false;
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
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
            if (flagHasDifficulty)
              {
                handler.start_pair("Difficulty");
                if (storeDifficulty.in_known_list)
                  {
                    switch (storeDifficulty.list_value)
                      {
                        case TypeDifficultyKnownValues.Difficulty_Easy:
                            handler.string_value("Easy");
                            break;
                        case TypeDifficultyKnownValues.Difficulty_Hard:
                            handler.string_value("Hard");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeDifficulty.string_value);
                  }
              }
            if (flagHasMinimumPossibleValue)
              {
                handler.start_pair("MinimumPossibleValue");
                handler.number_value(storeMinimumPossibleValue);
              }
            if (flagHasMaximumPossibleValue)
              {
                handler.start_pair("MaximumPossibleValue");
                handler.number_value(storeMaximumPossibleValue);
              }
            if (flagHasLowerRangeHint)
              {
                handler.start_pair("LowerRangeHint");
                handler.number_value(storeLowerRangeHint);
              }
            if (flagHasHigherRangeHint)
              {
                handler.start_pair("HigherRangeHint");
                handler.number_value(storeHigherRangeHint);
              }
            Debug.Assert(partial_allowed || flagHasGameState);
            if (flagHasGameState)
              {
                handler.start_pair("GameState");
                handler.string_value(storeGameState);
              }
            if (flagHasGuessesMade)
              {
                handler.start_pair("GuessesMade");
                handler.number_value(storeGuessesMade);
              }
            if (flagHasLastGuess)
              {
                handler.start_pair("LastGuess");
                handler.number_value(storeLastGuess);
              }
            if (flagHasGuessToSolutionComparison)
              {
                handler.start_pair("GuessToSolutionComparison");
                handler.number_value(storeGuessToSolutionComparison);
              }
            if (flagHasRoundOver)
              {
                handler.start_pair("RoundOver");
                handler.boolean_value(storeRoundOver);
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
            if (!(hasGameState()))
              {
                return "When parsing the object for %what%, the \"GameState\" field was missing.";
              }
            return null;
          }

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorDifficulty : JSONStringGenerator
              {
                protected FieldGeneratorDifficulty(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorDifficulty()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeDifficultyKnownValues known = stringToDifficulty(result);
                    TypeDifficulty new_value = new TypeDifficulty();
                    if (known == TypeDifficultyKnownValues.Difficulty__none)
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
                protected abstract void handle_result(TypeDifficulty result);
              };
        private class FieldHoldingGeneratorDifficulty : FieldGeneratorDifficulty
      {
        protected override void handle_result(TypeDifficulty result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorDifficulty(String what)
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
        public TypeDifficulty value;
      };
        private class FieldHoldingArrayGeneratorDifficulty : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorDifficulty
          {
            private FieldHoldingArrayGeneratorDifficulty top;

            protected override void handle_result(TypeDifficulty result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorDifficulty init_top)
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
        protected virtual void handle_result(List<TypeDifficulty> result)
          {
          }

        public FieldHoldingArrayGeneratorDifficulty(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeDifficulty>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorDifficulty()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeDifficulty>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeDifficulty> value;
      };
            private FieldHoldingGeneratorDifficulty fieldGeneratorDifficulty;
        private class FieldHoldingGeneratorMinimumPossibleValue : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorMinimumPossibleValue(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMinimumPossibleValue : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorMinimumPossibleValue(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorMinimumPossibleValue fieldGeneratorMinimumPossibleValue;
        private class FieldHoldingGeneratorMaximumPossibleValue : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorMaximumPossibleValue(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorMaximumPossibleValue : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorMaximumPossibleValue(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorMaximumPossibleValue fieldGeneratorMaximumPossibleValue;
        private class FieldHoldingGeneratorLowerRangeHint : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorLowerRangeHint(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorLowerRangeHint : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorLowerRangeHint(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorLowerRangeHint fieldGeneratorLowerRangeHint;
        private class FieldHoldingGeneratorHigherRangeHint : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorHigherRangeHint(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorHigherRangeHint : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorHigherRangeHint(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorHigherRangeHint fieldGeneratorHigherRangeHint;
            private JSONHoldingStringGenerator fieldGeneratorGameState;
        private class FieldHoldingGeneratorGuessesMade : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorGuessesMade(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorGuessesMade : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorGuessesMade(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorGuessesMade fieldGeneratorGuessesMade;
        private class FieldHoldingGeneratorLastGuess : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorLastGuess(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorLastGuess : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorLastGuess(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorLastGuess fieldGeneratorLastGuess;
        private class FieldHoldingGeneratorGuessToSolutionComparison : JSONHoldingIntegerRangeGenerator
              {
                public FieldHoldingGeneratorGuessToSolutionComparison(String what) : base(what, -1, 1)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorGuessToSolutionComparison : JSONHoldingIntegerRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorGuessToSolutionComparison(String what) : base(what, -1, 1)
                  {
                  }
              };
            private FieldHoldingGeneratorGuessToSolutionComparison fieldGeneratorGuessToSolutionComparison;
            private JSONHoldingBooleanGenerator fieldGeneratorRoundOver;
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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorDifficulty.have_value)
                  {
                    result.setDifficulty(fieldGeneratorDifficulty.value);
                    fieldGeneratorDifficulty.have_value = false;
                  }
                if (fieldGeneratorMinimumPossibleValue.have_value)
                  {
                    result.setMinimumPossibleValue(fieldGeneratorMinimumPossibleValue.value);
                    fieldGeneratorMinimumPossibleValue.have_value = false;
                  }
                if (fieldGeneratorMaximumPossibleValue.have_value)
                  {
                    result.setMaximumPossibleValue(fieldGeneratorMaximumPossibleValue.value);
                    fieldGeneratorMaximumPossibleValue.have_value = false;
                  }
                if (fieldGeneratorLowerRangeHint.have_value)
                  {
                    result.setLowerRangeHint(fieldGeneratorLowerRangeHint.value);
                    fieldGeneratorLowerRangeHint.have_value = false;
                  }
                if (fieldGeneratorHigherRangeHint.have_value)
                  {
                    result.setHigherRangeHint(fieldGeneratorHigherRangeHint.value);
                    fieldGeneratorHigherRangeHint.have_value = false;
                  }
                if (fieldGeneratorGameState.have_value)
                  {
                    result.setGameState(fieldGeneratorGameState.value);
                    fieldGeneratorGameState.have_value = false;
                  }
                else if ((!(result.hasGameState())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"GameState\" field was missing.");
                  }
                if (fieldGeneratorGuessesMade.have_value)
                  {
                    result.setGuessesMade(fieldGeneratorGuessesMade.value);
                    fieldGeneratorGuessesMade.have_value = false;
                  }
                if (fieldGeneratorLastGuess.have_value)
                  {
                    result.setLastGuess(fieldGeneratorLastGuess.value);
                    fieldGeneratorLastGuess.have_value = false;
                  }
                if (fieldGeneratorGuessToSolutionComparison.have_value)
                  {
                    result.setGuessToSolutionComparison((sbyte)(fieldGeneratorGuessToSolutionComparison.value));
                    fieldGeneratorGuessToSolutionComparison.have_value = false;
                  }
                if (fieldGeneratorRoundOver.have_value)
                  {
                    result.setRoundOver(fieldGeneratorRoundOver.value);
                    fieldGeneratorRoundOver.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "ifficulty", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorDifficulty;
                        break;
                    case 'G':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "meState", 0, 7, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorGameState;
                                break;
                            case 'u':
                                if (String.Compare(field_name, 2, "ess", 0, 3, false) == 0)
                                  {
                                    switch (field_name[5])
                                      {
                                        case 'T':
                                            if ((String.Compare(field_name, 6, "oSolutionComparison", 0, 19, false) == 0) && (field_name.Length == 25))
                                                return fieldGeneratorGuessToSolutionComparison;
                                            break;
                                        case 'e':
                                            if ((String.Compare(field_name, 6, "sMade", 0, 5, false) == 0) && (field_name.Length == 11))
                                                return fieldGeneratorGuessesMade;
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
                    case 'H':
                        if ((String.Compare(field_name, 1, "igherRangeHint", 0, 14, false) == 0) && (field_name.Length == 15))
                            return fieldGeneratorHigherRangeHint;
                        break;
                    case 'L':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "stGuess", 0, 7, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorLastGuess;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 2, "werRangeHint", 0, 12, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorLowerRangeHint;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'M':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "ximumPossibleValue", 0, 18, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorMaximumPossibleValue;
                                break;
                            case 'i':
                                if ((String.Compare(field_name, 2, "nimumPossibleValue", 0, 18, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorMinimumPossibleValue;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "oundOver", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorRoundOver;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorDifficulty = new FieldHoldingGeneratorDifficulty("field \"Difficulty\" of the TypeNativeData class");
                fieldGeneratorMinimumPossibleValue = new FieldHoldingGeneratorMinimumPossibleValue("field \"MinimumPossibleValue\" of the TypeNativeData class");
                fieldGeneratorMaximumPossibleValue = new FieldHoldingGeneratorMaximumPossibleValue("field \"MaximumPossibleValue\" of the TypeNativeData class");
                fieldGeneratorLowerRangeHint = new FieldHoldingGeneratorLowerRangeHint("field \"LowerRangeHint\" of the TypeNativeData class");
                fieldGeneratorHigherRangeHint = new FieldHoldingGeneratorHigherRangeHint("field \"HigherRangeHint\" of the TypeNativeData class");
                fieldGeneratorGameState = new JSONHoldingStringGenerator("field \"GameState\" of the TypeNativeData class");
                fieldGeneratorGuessesMade = new FieldHoldingGeneratorGuessesMade("field \"GuessesMade\" of the TypeNativeData class");
                fieldGeneratorLastGuess = new FieldHoldingGeneratorLastGuess("field \"LastGuess\" of the TypeNativeData class");
                fieldGeneratorGuessToSolutionComparison = new FieldHoldingGeneratorGuessToSolutionComparison("field \"GuessToSolutionComparison\" of the TypeNativeData class");
                fieldGeneratorRoundOver = new JSONHoldingBooleanGenerator("field \"RoundOver\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorDifficulty = new FieldHoldingGeneratorDifficulty("field \"Difficulty\" of the TypeNativeData class");
                fieldGeneratorMinimumPossibleValue = new FieldHoldingGeneratorMinimumPossibleValue("field \"MinimumPossibleValue\" of the TypeNativeData class");
                fieldGeneratorMaximumPossibleValue = new FieldHoldingGeneratorMaximumPossibleValue("field \"MaximumPossibleValue\" of the TypeNativeData class");
                fieldGeneratorLowerRangeHint = new FieldHoldingGeneratorLowerRangeHint("field \"LowerRangeHint\" of the TypeNativeData class");
                fieldGeneratorHigherRangeHint = new FieldHoldingGeneratorHigherRangeHint("field \"HigherRangeHint\" of the TypeNativeData class");
                fieldGeneratorGameState = new JSONHoldingStringGenerator("field \"GameState\" of the TypeNativeData class");
                fieldGeneratorGuessesMade = new FieldHoldingGeneratorGuessesMade("field \"GuessesMade\" of the TypeNativeData class");
                fieldGeneratorLastGuess = new FieldHoldingGeneratorLastGuess("field \"LastGuess\" of the TypeNativeData class");
                fieldGeneratorGuessToSolutionComparison = new FieldHoldingGeneratorGuessToSolutionComparison("field \"GuessToSolutionComparison\" of the TypeNativeData class");
                fieldGeneratorRoundOver = new JSONHoldingBooleanGenerator("field \"RoundOver\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorDifficulty.reset();
                fieldGeneratorMinimumPossibleValue.reset();
                fieldGeneratorMaximumPossibleValue.reset();
                fieldGeneratorLowerRangeHint.reset();
                fieldGeneratorHigherRangeHint.reset();
                fieldGeneratorGameState.reset();
                fieldGeneratorGuessesMade.reset();
                fieldGeneratorLastGuess.reset();
                fieldGeneratorGuessToSolutionComparison.reset();
                fieldGeneratorRoundOver.reset();
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
            protected override void handle_result(TypeNativeDataJSON  result)
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
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
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
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
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
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public NumberGuessNotUnderstoodCommandJSON()
      {
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNumberGuessCommandKind()
      {
        return "NumberGuessNotUnderstoodCommand";
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }


    public virtual int extraNumberGuessNotUnderstoodCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraNumberGuessNotUnderstoodCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraNumberGuessNotUnderstoodCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraNumberGuessNotUnderstoodCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraNumberGuessCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        result += extraNumberGuessNotUnderstoodCommandComponentCount();
        return result;
      }
    public override string extraNumberGuessCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraNumberGuessNotUnderstoodCommandComponentKey(remainder);
      }
    public override JSONValue extraNumberGuessCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraNumberGuessNotUnderstoodCommandComponentValue(remainder);
      }
    public override JSONValue extraNumberGuessCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return extraNumberGuessNotUnderstoodCommandLookup(field_name);
      }

    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }

    public virtual void extraNumberGuessNotUnderstoodCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraNumberGuessNotUnderstoodCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraNumberGuessNotUnderstoodCommandLookup(key);
        if (old_field == null)
          {
            extraNumberGuessNotUnderstoodCommandAppendPair(key, new_component);
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
    public override void extraNumberGuessCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraNumberGuessNotUnderstoodCommandAppendPair(key, new_component);
      }
    public override void extraNumberGuessCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraNumberGuessNotUnderstoodCommandSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
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
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new NumberGuessNotUnderstoodCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NumberGuessNotUnderstoodCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberGuessNotUnderstoodCommand", ignore_extras);
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
    public static new NumberGuessNotUnderstoodCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new NumberGuessNotUnderstoodCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        NumberGuessNotUnderstoodCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberGuessNotUnderstoodCommand", ignore_extras);
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
    public static new NumberGuessNotUnderstoodCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new NumberGuessNotUnderstoodCommandJSON from_text(string text, bool ignore_extras)
      {
        NumberGuessNotUnderstoodCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberGuessNotUnderstoodCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for NumberGuessNotUnderstoodCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new NumberGuessNotUnderstoodCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        NumberGuessNotUnderstoodCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type NumberGuessNotUnderstoodCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : NumberGuessCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
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
            if (!(getNumberGuessCommandJSONKey().Equals("NumberGuessNotUnderstoodCommand")))
                throw new Exception("The key field has a value other than `NumberGuessNotUnderstoodCommand'.");
            NumberGuessNotUnderstoodCommandJSON result = new NumberGuessNotUnderstoodCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraNumberGuessNotUnderstoodCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(NumberGuessCommandJSON new_result)
          {
            handle_result((NumberGuessNotUnderstoodCommandJSON )new_result);
          }
        protected void finish(NumberGuessNotUnderstoodCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(NumberGuessNotUnderstoodCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the NumberGuessNotUnderstoodCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the NumberGuessNotUnderstoodCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the NumberGuessNotUnderstoodCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the NumberGuessNotUnderstoodCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(NumberGuessNotUnderstoodCommandJSON  result)
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
        public NumberGuessNotUnderstoodCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(NumberGuessNotUnderstoodCommandJSON  result)
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
    protected virtual void handle_result(List<NumberGuessNotUnderstoodCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<NumberGuessNotUnderstoodCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<NumberGuessNotUnderstoodCommandJSON>();
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
    public List<NumberGuessNotUnderstoodCommandJSON> value;
  };
  };
