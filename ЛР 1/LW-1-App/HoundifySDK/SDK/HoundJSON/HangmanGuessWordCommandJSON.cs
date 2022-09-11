/* file "HangmanGuessWordCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class HangmanGuessWordCommandJSON : HangmanCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        private bool flagHasBoard;
        private string storeBoard;
        private bool flagHasSolutionLength;
        private BigInteger storeSolutionLength;
        private bool flagHasScoreImageURL;
        private string storeScoreImageURL;
        private bool flagHasTimeElapsedSeconds;
        private BigInteger storeTimeElapsedSeconds;
        private bool flagHasPreviousGuesses;
        private string storePreviousGuesses;
        private bool flagHasNumberIncorrectGuessesMade;
        private BigInteger storeNumberIncorrectGuessesMade;
        private bool flagHasNumberRemainingGuesses;
        private BigInteger storeNumberRemainingGuesses;
        private bool flagHasLastWordGuess;
        private string storeLastWordGuess;
        private bool flagHasCorrectWordGuessed;
        private bool storeCorrectWordGuessed;
        private bool flagHasIsGameOver;
        private bool storeIsGameOver;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONBoard(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Board of TypeNativeDataJSON is not a string.");
            setBoard(json_string.getData());
          }


        private void  fromJSONSolutionLength(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field SolutionLength of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field SolutionLength of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setSolutionLength(extracted_integer);
          }


        private void  fromJSONScoreImageURL(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ScoreImageURL of TypeNativeDataJSON is not a string.");
            setScoreImageURL(json_string.getData());
          }


        private void  fromJSONTimeElapsedSeconds(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field TimeElapsedSeconds of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field TimeElapsedSeconds of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setTimeElapsedSeconds(extracted_integer);
          }


        private void  fromJSONPreviousGuesses(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field PreviousGuesses of TypeNativeDataJSON is not a string.");
            setPreviousGuesses(json_string.getData());
          }


        private void  fromJSONNumberIncorrectGuessesMade(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field NumberIncorrectGuessesMade of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field NumberIncorrectGuessesMade of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setNumberIncorrectGuessesMade(extracted_integer);
          }


        private void  fromJSONNumberRemainingGuesses(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field NumberRemainingGuesses of TypeNativeDataJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field NumberRemainingGuesses of TypeNativeDataJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setNumberRemainingGuesses(extracted_integer);
          }


        private void  fromJSONLastWordGuess(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field LastWordGuess of TypeNativeDataJSON is not a string.");
            setLastWordGuess(json_string.getData());
          }


        private void  fromJSONCorrectWordGuessed(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field CorrectWordGuessed of TypeNativeDataJSON is not true for false.");
                  }
              }
            setCorrectWordGuessed(the_bool);
          }


        private void  fromJSONIsGameOver(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field IsGameOver of TypeNativeDataJSON is not true for false.");
                  }
              }
            setIsGameOver(the_bool);
          }


        public TypeNativeDataJSON()
          {
            flagHasBoard = false;
            flagHasSolutionLength = false;
            flagHasScoreImageURL = false;
            flagHasTimeElapsedSeconds = false;
            flagHasPreviousGuesses = false;
            flagHasNumberIncorrectGuessesMade = false;
            flagHasNumberRemainingGuesses = false;
            flagHasLastWordGuess = false;
            flagHasCorrectWordGuessed = false;
            flagHasIsGameOver = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasBoard()
          {
            return flagHasBoard;
          }

        public string  getBoard()
          {
            Debug.Assert(flagHasBoard);
            return storeBoard;
          }

        public bool  hasSolutionLength()
          {
            return flagHasSolutionLength;
          }

        public BigInteger  getSolutionLength()
          {
            Debug.Assert(flagHasSolutionLength);
            return storeSolutionLength;
          }

        public bool  hasScoreImageURL()
          {
            return flagHasScoreImageURL;
          }

        public string  getScoreImageURL()
          {
            Debug.Assert(flagHasScoreImageURL);
            return storeScoreImageURL;
          }

        public bool  hasTimeElapsedSeconds()
          {
            return flagHasTimeElapsedSeconds;
          }

        public BigInteger  getTimeElapsedSeconds()
          {
            Debug.Assert(flagHasTimeElapsedSeconds);
            return storeTimeElapsedSeconds;
          }

        public bool  hasPreviousGuesses()
          {
            return flagHasPreviousGuesses;
          }

        public string  getPreviousGuesses()
          {
            Debug.Assert(flagHasPreviousGuesses);
            return storePreviousGuesses;
          }

        public bool  hasNumberIncorrectGuessesMade()
          {
            return flagHasNumberIncorrectGuessesMade;
          }

        public BigInteger  getNumberIncorrectGuessesMade()
          {
            Debug.Assert(flagHasNumberIncorrectGuessesMade);
            return storeNumberIncorrectGuessesMade;
          }

        public bool  hasNumberRemainingGuesses()
          {
            return flagHasNumberRemainingGuesses;
          }

        public BigInteger  getNumberRemainingGuesses()
          {
            Debug.Assert(flagHasNumberRemainingGuesses);
            return storeNumberRemainingGuesses;
          }

        public bool  hasLastWordGuess()
          {
            return flagHasLastWordGuess;
          }

        public string  getLastWordGuess()
          {
            Debug.Assert(flagHasLastWordGuess);
            return storeLastWordGuess;
          }

        public bool  hasCorrectWordGuessed()
          {
            return flagHasCorrectWordGuessed;
          }

        public bool  getCorrectWordGuessed()
          {
            Debug.Assert(flagHasCorrectWordGuessed);
            return storeCorrectWordGuessed;
          }

        public bool  hasIsGameOver()
          {
            return flagHasIsGameOver;
          }

        public bool  getIsGameOver()
          {
            Debug.Assert(flagHasIsGameOver);
            return storeIsGameOver;
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

        public void setBoard(string new_value)
          {
            flagHasBoard = true;
            storeBoard = new_value;
          }
        public void unsetBoard()
          {
            flagHasBoard = false;
          }
        public void setSolutionLength(BigInteger new_value)
          {
            flagHasSolutionLength = true;
            if (new_value < 1)
                throw new Exception("The value for field SolutionLength of TypeNativeDataJSON is less than the lower bound (1) for that field.");
            storeSolutionLength = new_value;
          }
        public void unsetSolutionLength()
          {
            flagHasSolutionLength = false;
          }
        public void setScoreImageURL(string new_value)
          {
            flagHasScoreImageURL = true;
            storeScoreImageURL = new_value;
          }
        public void unsetScoreImageURL()
          {
            flagHasScoreImageURL = false;
          }
        public void setTimeElapsedSeconds(BigInteger new_value)
          {
            flagHasTimeElapsedSeconds = true;
            if (new_value < 0)
                throw new Exception("The value for field TimeElapsedSeconds of TypeNativeDataJSON is less than the lower bound (0) for that field.");
            storeTimeElapsedSeconds = new_value;
          }
        public void unsetTimeElapsedSeconds()
          {
            flagHasTimeElapsedSeconds = false;
          }
        public void setPreviousGuesses(string new_value)
          {
            flagHasPreviousGuesses = true;
            storePreviousGuesses = new_value;
          }
        public void unsetPreviousGuesses()
          {
            flagHasPreviousGuesses = false;
          }
        public void setNumberIncorrectGuessesMade(BigInteger new_value)
          {
            flagHasNumberIncorrectGuessesMade = true;
            storeNumberIncorrectGuessesMade = new_value;
          }
        public void unsetNumberIncorrectGuessesMade()
          {
            flagHasNumberIncorrectGuessesMade = false;
          }
        public void setNumberRemainingGuesses(BigInteger new_value)
          {
            flagHasNumberRemainingGuesses = true;
            storeNumberRemainingGuesses = new_value;
          }
        public void unsetNumberRemainingGuesses()
          {
            flagHasNumberRemainingGuesses = false;
          }
        public void setLastWordGuess(string new_value)
          {
            flagHasLastWordGuess = true;
            storeLastWordGuess = new_value;
          }
        public void unsetLastWordGuess()
          {
            flagHasLastWordGuess = false;
          }
        public void setCorrectWordGuessed(bool new_value)
          {
            flagHasCorrectWordGuessed = true;
            storeCorrectWordGuessed = new_value;
          }
        public void unsetCorrectWordGuessed()
          {
            flagHasCorrectWordGuessed = false;
          }
        public void setIsGameOver(bool new_value)
          {
            flagHasIsGameOver = true;
            storeIsGameOver = new_value;
          }
        public void unsetIsGameOver()
          {
            flagHasIsGameOver = false;
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
            Debug.Assert(partial_allowed || flagHasBoard);
            if (flagHasBoard)
              {
                handler.start_pair("Board");
                handler.string_value(storeBoard);
              }
            Debug.Assert(partial_allowed || flagHasSolutionLength);
            if (flagHasSolutionLength)
              {
                handler.start_pair("SolutionLength");
                handler.number_value(storeSolutionLength);
              }
            Debug.Assert(partial_allowed || flagHasScoreImageURL);
            if (flagHasScoreImageURL)
              {
                handler.start_pair("ScoreImageURL");
                handler.string_value(storeScoreImageURL);
              }
            Debug.Assert(partial_allowed || flagHasTimeElapsedSeconds);
            if (flagHasTimeElapsedSeconds)
              {
                handler.start_pair("TimeElapsedSeconds");
                handler.number_value(storeTimeElapsedSeconds);
              }
            Debug.Assert(partial_allowed || flagHasPreviousGuesses);
            if (flagHasPreviousGuesses)
              {
                handler.start_pair("PreviousGuesses");
                handler.string_value(storePreviousGuesses);
              }
            Debug.Assert(partial_allowed || flagHasNumberIncorrectGuessesMade);
            if (flagHasNumberIncorrectGuessesMade)
              {
                handler.start_pair("NumberIncorrectGuessesMade");
                handler.number_value(storeNumberIncorrectGuessesMade);
              }
            Debug.Assert(partial_allowed || flagHasNumberRemainingGuesses);
            if (flagHasNumberRemainingGuesses)
              {
                handler.start_pair("NumberRemainingGuesses");
                handler.number_value(storeNumberRemainingGuesses);
              }
            Debug.Assert(partial_allowed || flagHasLastWordGuess);
            if (flagHasLastWordGuess)
              {
                handler.start_pair("LastWordGuess");
                handler.string_value(storeLastWordGuess);
              }
            Debug.Assert(partial_allowed || flagHasCorrectWordGuessed);
            if (flagHasCorrectWordGuessed)
              {
                handler.start_pair("CorrectWordGuessed");
                handler.boolean_value(storeCorrectWordGuessed);
              }
            Debug.Assert(partial_allowed || flagHasIsGameOver);
            if (flagHasIsGameOver)
              {
                handler.start_pair("IsGameOver");
                handler.boolean_value(storeIsGameOver);
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
            if (!(hasBoard()))
              {
                return "When parsing the object for %what%, the \"Board\" field was missing.";
              }
            if (!(hasSolutionLength()))
              {
                return "When parsing the object for %what%, the \"SolutionLength\" field was missing.";
              }
            if (!(hasScoreImageURL()))
              {
                return "When parsing the object for %what%, the \"ScoreImageURL\" field was missing.";
              }
            if (!(hasTimeElapsedSeconds()))
              {
                return "When parsing the object for %what%, the \"TimeElapsedSeconds\" field was missing.";
              }
            if (!(hasPreviousGuesses()))
              {
                return "When parsing the object for %what%, the \"PreviousGuesses\" field was missing.";
              }
            if (!(hasNumberIncorrectGuessesMade()))
              {
                return "When parsing the object for %what%, the \"NumberIncorrectGuessesMade\" field was missing.";
              }
            if (!(hasNumberRemainingGuesses()))
              {
                return "When parsing the object for %what%, the \"NumberRemainingGuesses\" field was missing.";
              }
            if (!(hasLastWordGuess()))
              {
                return "When parsing the object for %what%, the \"LastWordGuess\" field was missing.";
              }
            if (!(hasCorrectWordGuessed()))
              {
                return "When parsing the object for %what%, the \"CorrectWordGuessed\" field was missing.";
              }
            if (!(hasIsGameOver()))
              {
                return "When parsing the object for %what%, the \"IsGameOver\" field was missing.";
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
            private JSONHoldingStringGenerator fieldGeneratorBoard;
        private class FieldHoldingGeneratorSolutionLength : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorSolutionLength(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorSolutionLength : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorSolutionLength(String what) : base(what, (BigInteger)(1))
                  {
                  }
              };
            private FieldHoldingGeneratorSolutionLength fieldGeneratorSolutionLength;
            private JSONHoldingStringGenerator fieldGeneratorScoreImageURL;
        private class FieldHoldingGeneratorTimeElapsedSeconds : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorTimeElapsedSeconds(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorTimeElapsedSeconds : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorTimeElapsedSeconds(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorTimeElapsedSeconds fieldGeneratorTimeElapsedSeconds;
            private JSONHoldingStringGenerator fieldGeneratorPreviousGuesses;
        private class FieldHoldingGeneratorNumberIncorrectGuessesMade : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorNumberIncorrectGuessesMade(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorNumberIncorrectGuessesMade : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorNumberIncorrectGuessesMade(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorNumberIncorrectGuessesMade fieldGeneratorNumberIncorrectGuessesMade;
        private class FieldHoldingGeneratorNumberRemainingGuesses : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorNumberRemainingGuesses(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorNumberRemainingGuesses : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorNumberRemainingGuesses(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorNumberRemainingGuesses fieldGeneratorNumberRemainingGuesses;
            private JSONHoldingStringGenerator fieldGeneratorLastWordGuess;
            private JSONHoldingBooleanGenerator fieldGeneratorCorrectWordGuessed;
            private JSONHoldingBooleanGenerator fieldGeneratorIsGameOver;
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
                if (fieldGeneratorBoard.have_value)
                  {
                    result.setBoard(fieldGeneratorBoard.value);
                    fieldGeneratorBoard.have_value = false;
                  }
                else if ((!(result.hasBoard())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Board\" field was missing.");
                  }
                if (fieldGeneratorSolutionLength.have_value)
                  {
                    result.setSolutionLength(fieldGeneratorSolutionLength.value);
                    fieldGeneratorSolutionLength.have_value = false;
                  }
                else if ((!(result.hasSolutionLength())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SolutionLength\" field was missing.");
                  }
                if (fieldGeneratorScoreImageURL.have_value)
                  {
                    result.setScoreImageURL(fieldGeneratorScoreImageURL.value);
                    fieldGeneratorScoreImageURL.have_value = false;
                  }
                else if ((!(result.hasScoreImageURL())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ScoreImageURL\" field was missing.");
                  }
                if (fieldGeneratorTimeElapsedSeconds.have_value)
                  {
                    result.setTimeElapsedSeconds(fieldGeneratorTimeElapsedSeconds.value);
                    fieldGeneratorTimeElapsedSeconds.have_value = false;
                  }
                else if ((!(result.hasTimeElapsedSeconds())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"TimeElapsedSeconds\" field was missing.");
                  }
                if (fieldGeneratorPreviousGuesses.have_value)
                  {
                    result.setPreviousGuesses(fieldGeneratorPreviousGuesses.value);
                    fieldGeneratorPreviousGuesses.have_value = false;
                  }
                else if ((!(result.hasPreviousGuesses())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"PreviousGuesses\" field was missing.");
                  }
                if (fieldGeneratorNumberIncorrectGuessesMade.have_value)
                  {
                    result.setNumberIncorrectGuessesMade(fieldGeneratorNumberIncorrectGuessesMade.value);
                    fieldGeneratorNumberIncorrectGuessesMade.have_value = false;
                  }
                else if ((!(result.hasNumberIncorrectGuessesMade())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NumberIncorrectGuessesMade\" field was missing.");
                  }
                if (fieldGeneratorNumberRemainingGuesses.have_value)
                  {
                    result.setNumberRemainingGuesses(fieldGeneratorNumberRemainingGuesses.value);
                    fieldGeneratorNumberRemainingGuesses.have_value = false;
                  }
                else if ((!(result.hasNumberRemainingGuesses())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"NumberRemainingGuesses\" field was missing.");
                  }
                if (fieldGeneratorLastWordGuess.have_value)
                  {
                    result.setLastWordGuess(fieldGeneratorLastWordGuess.value);
                    fieldGeneratorLastWordGuess.have_value = false;
                  }
                else if ((!(result.hasLastWordGuess())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"LastWordGuess\" field was missing.");
                  }
                if (fieldGeneratorCorrectWordGuessed.have_value)
                  {
                    result.setCorrectWordGuessed(fieldGeneratorCorrectWordGuessed.value);
                    fieldGeneratorCorrectWordGuessed.have_value = false;
                  }
                else if ((!(result.hasCorrectWordGuessed())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"CorrectWordGuessed\" field was missing.");
                  }
                if (fieldGeneratorIsGameOver.have_value)
                  {
                    result.setIsGameOver(fieldGeneratorIsGameOver.value);
                    fieldGeneratorIsGameOver.have_value = false;
                  }
                else if ((!(result.hasIsGameOver())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"IsGameOver\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'B':
                        if ((String.Compare(field_name, 1, "oard", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorBoard;
                        break;
                    case 'C':
                        if ((String.Compare(field_name, 1, "orrectWordGuessed", 0, 17, false) == 0) && (field_name.Length == 18))
                            return fieldGeneratorCorrectWordGuessed;
                        break;
                    case 'I':
                        if ((String.Compare(field_name, 1, "sGameOver", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorIsGameOver;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "astWordGuess", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorLastWordGuess;
                        break;
                    case 'N':
                        if (String.Compare(field_name, 1, "umber", 0, 5, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'I':
                                    if ((String.Compare(field_name, 7, "ncorrectGuessesMade", 0, 19, false) == 0) && (field_name.Length == 26))
                                        return fieldGeneratorNumberIncorrectGuessesMade;
                                    break;
                                case 'R':
                                    if ((String.Compare(field_name, 7, "emainingGuesses", 0, 15, false) == 0) && (field_name.Length == 22))
                                        return fieldGeneratorNumberRemainingGuesses;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "reviousGuesses", 0, 14, false) == 0) && (field_name.Length == 15))
                            return fieldGeneratorPreviousGuesses;
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'c':
                                if ((String.Compare(field_name, 2, "oreImageURL", 0, 11, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorScoreImageURL;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 2, "lutionLength", 0, 12, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorSolutionLength;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "imeElapsedSeconds", 0, 17, false) == 0) && (field_name.Length == 18))
                            return fieldGeneratorTimeElapsedSeconds;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorBoard = new JSONHoldingStringGenerator("field \"Board\" of the TypeNativeData class");
                fieldGeneratorSolutionLength = new FieldHoldingGeneratorSolutionLength("field \"SolutionLength\" of the TypeNativeData class");
                fieldGeneratorScoreImageURL = new JSONHoldingStringGenerator("field \"ScoreImageURL\" of the TypeNativeData class");
                fieldGeneratorTimeElapsedSeconds = new FieldHoldingGeneratorTimeElapsedSeconds("field \"TimeElapsedSeconds\" of the TypeNativeData class");
                fieldGeneratorPreviousGuesses = new JSONHoldingStringGenerator("field \"PreviousGuesses\" of the TypeNativeData class");
                fieldGeneratorNumberIncorrectGuessesMade = new FieldHoldingGeneratorNumberIncorrectGuessesMade("field \"NumberIncorrectGuessesMade\" of the TypeNativeData class");
                fieldGeneratorNumberRemainingGuesses = new FieldHoldingGeneratorNumberRemainingGuesses("field \"NumberRemainingGuesses\" of the TypeNativeData class");
                fieldGeneratorLastWordGuess = new JSONHoldingStringGenerator("field \"LastWordGuess\" of the TypeNativeData class");
                fieldGeneratorCorrectWordGuessed = new JSONHoldingBooleanGenerator("field \"CorrectWordGuessed\" of the TypeNativeData class");
                fieldGeneratorIsGameOver = new JSONHoldingBooleanGenerator("field \"IsGameOver\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorBoard = new JSONHoldingStringGenerator("field \"Board\" of the TypeNativeData class");
                fieldGeneratorSolutionLength = new FieldHoldingGeneratorSolutionLength("field \"SolutionLength\" of the TypeNativeData class");
                fieldGeneratorScoreImageURL = new JSONHoldingStringGenerator("field \"ScoreImageURL\" of the TypeNativeData class");
                fieldGeneratorTimeElapsedSeconds = new FieldHoldingGeneratorTimeElapsedSeconds("field \"TimeElapsedSeconds\" of the TypeNativeData class");
                fieldGeneratorPreviousGuesses = new JSONHoldingStringGenerator("field \"PreviousGuesses\" of the TypeNativeData class");
                fieldGeneratorNumberIncorrectGuessesMade = new FieldHoldingGeneratorNumberIncorrectGuessesMade("field \"NumberIncorrectGuessesMade\" of the TypeNativeData class");
                fieldGeneratorNumberRemainingGuesses = new FieldHoldingGeneratorNumberRemainingGuesses("field \"NumberRemainingGuesses\" of the TypeNativeData class");
                fieldGeneratorLastWordGuess = new JSONHoldingStringGenerator("field \"LastWordGuess\" of the TypeNativeData class");
                fieldGeneratorCorrectWordGuessed = new JSONHoldingBooleanGenerator("field \"CorrectWordGuessed\" of the TypeNativeData class");
                fieldGeneratorIsGameOver = new JSONHoldingBooleanGenerator("field \"IsGameOver\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorBoard.reset();
                fieldGeneratorSolutionLength.reset();
                fieldGeneratorScoreImageURL.reset();
                fieldGeneratorTimeElapsedSeconds.reset();
                fieldGeneratorPreviousGuesses.reset();
                fieldGeneratorNumberIncorrectGuessesMade.reset();
                fieldGeneratorNumberRemainingGuesses.reset();
                fieldGeneratorLastWordGuess.reset();
                fieldGeneratorCorrectWordGuessed.reset();
                fieldGeneratorIsGameOver.reset();
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


    public HangmanGuessWordCommandJSON()
      {
        flagHasNativeData = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getHangmanCommandKind()
      {
        return "HangmanGuessWordCommand";
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


    public virtual int extraHangmanGuessWordCommandComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHangmanGuessWordCommandComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHangmanGuessWordCommandComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHangmanGuessWordCommandLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraHangmanCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        result += extraHangmanGuessWordCommandComponentCount();
        return result;
      }
    public override string extraHangmanCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        return extraHangmanGuessWordCommandComponentKey(remainder);
      }
    public override JSONValue extraHangmanCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        return extraHangmanGuessWordCommandComponentValue(remainder);
      }
    public override JSONValue extraHangmanCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return extraHangmanGuessWordCommandLookup(field_name);
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

    public virtual void extraHangmanGuessWordCommandAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHangmanGuessWordCommandSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHangmanGuessWordCommandLookup(key);
        if (old_field == null)
          {
            extraHangmanGuessWordCommandAppendPair(key, new_component);
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
    public override void extraHangmanCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraHangmanGuessWordCommandAppendPair(key, new_component);
      }
    public override void extraHangmanCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
        extraHangmanGuessWordCommandSetField(key, new_component);
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

    public static new HangmanGuessWordCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HangmanGuessWordCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HangmanGuessWordCommand", ignore_extras);
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
    public static new HangmanGuessWordCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HangmanGuessWordCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HangmanGuessWordCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HangmanGuessWordCommand", ignore_extras);
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
    public static new HangmanGuessWordCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new HangmanGuessWordCommandJSON from_text(string text, bool ignore_extras)
      {
        HangmanGuessWordCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HangmanGuessWordCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HangmanGuessWordCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new HangmanGuessWordCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HangmanGuessWordCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HangmanGuessWordCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : HangmanCommandJSON.Generator
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
            if (!(getHangmanCommandJSONKey().Equals("HangmanGuessWordCommand")))
                throw new Exception("The key field has a value other than `HangmanGuessWordCommand'.");
            HangmanGuessWordCommandJSON result = new HangmanGuessWordCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHangmanGuessWordCommandAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(HangmanCommandJSON new_result)
          {
            handle_result((HangmanGuessWordCommandJSON )new_result);
          }
        protected void finish(HangmanGuessWordCommandJSON result)
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
        protected abstract void handle_result(HangmanGuessWordCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the HangmanGuessWordCommand class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HangmanGuessWordCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the HangmanGuessWordCommand class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HangmanGuessWordCommand class");
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
        protected override void handle_result(HangmanGuessWordCommandJSON  result)
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
        public HangmanGuessWordCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HangmanGuessWordCommandJSON  result)
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
    protected virtual void handle_result(List<HangmanGuessWordCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HangmanGuessWordCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HangmanGuessWordCommandJSON>();
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
    public List<HangmanGuessWordCommandJSON> value;
  };
  };
