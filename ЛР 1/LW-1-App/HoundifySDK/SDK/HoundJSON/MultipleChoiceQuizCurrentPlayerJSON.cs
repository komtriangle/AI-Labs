/* file "MultipleChoiceQuizCurrentPlayerJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MultipleChoiceQuizCurrentPlayerJSON : InformationNuggetJSON
  {
    private bool flagHasCurrentPlayer;
    private BigInteger storeCurrentPlayer;
    private bool flagHasPlayerCount;
    private BigInteger storePlayerCount;
    private bool flagHasRound;
    private BigInteger storeRound;
    private bool flagHasRemainingQuestions;
    private BigInteger storeRemainingQuestions;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCurrentPlayerToJSON()
      {
        JSONIntegerValue generated_integer_CurrentPlayer = new JSONIntegerValue(storeCurrentPlayer);
        return generated_integer_CurrentPlayer;
      }

    private JSONValue  extraPlayerCountToJSON()
      {
        JSONIntegerValue generated_integer_PlayerCount = new JSONIntegerValue(storePlayerCount);
        return generated_integer_PlayerCount;
      }

    private JSONValue  extraRoundToJSON()
      {
        JSONIntegerValue generated_integer_Round = new JSONIntegerValue(storeRound);
        return generated_integer_Round;
      }

    private JSONValue  extraRemainingQuestionsToJSON()
      {
        JSONIntegerValue generated_integer_RemainingQuestions = new JSONIntegerValue(storeRemainingQuestions);
        return generated_integer_RemainingQuestions;
      }


    private void  fromJSONCurrentPlayer(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CurrentPlayer of MultipleChoiceQuizCurrentPlayerJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CurrentPlayer of MultipleChoiceQuizCurrentPlayerJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCurrentPlayer(extracted_integer);
      }


    private void  fromJSONPlayerCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PlayerCount of MultipleChoiceQuizCurrentPlayerJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PlayerCount of MultipleChoiceQuizCurrentPlayerJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPlayerCount(extracted_integer);
      }


    private void  fromJSONRound(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Round of MultipleChoiceQuizCurrentPlayerJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Round of MultipleChoiceQuizCurrentPlayerJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRound(extracted_integer);
      }


    private void  fromJSONRemainingQuestions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RemainingQuestions of MultipleChoiceQuizCurrentPlayerJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RemainingQuestions of MultipleChoiceQuizCurrentPlayerJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRemainingQuestions(extracted_integer);
      }


    public MultipleChoiceQuizCurrentPlayerJSON()
      {
        flagHasCurrentPlayer = false;
        flagHasPlayerCount = false;
        flagHasRound = false;
        flagHasRemainingQuestions = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "MultipleChoiceQuizCurrentPlayer";
      }

    public bool  hasCurrentPlayer()
      {
        return flagHasCurrentPlayer;
      }

    public BigInteger  getCurrentPlayer()
      {
        Debug.Assert(flagHasCurrentPlayer);
        return storeCurrentPlayer;
      }

    public bool  hasPlayerCount()
      {
        return flagHasPlayerCount;
      }

    public BigInteger  getPlayerCount()
      {
        Debug.Assert(flagHasPlayerCount);
        return storePlayerCount;
      }

    public bool  hasRound()
      {
        return flagHasRound;
      }

    public BigInteger  getRound()
      {
        Debug.Assert(flagHasRound);
        return storeRound;
      }

    public bool  hasRemainingQuestions()
      {
        return flagHasRemainingQuestions;
      }

    public BigInteger  getRemainingQuestions()
      {
        Debug.Assert(flagHasRemainingQuestions);
        return storeRemainingQuestions;
      }


    public virtual int extraMultipleChoiceQuizCurrentPlayerComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMultipleChoiceQuizCurrentPlayerComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizCurrentPlayerComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizCurrentPlayerLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasCurrentPlayer)
            ++result;
        if (flagHasPlayerCount)
            ++result;
        if (flagHasRound)
            ++result;
        if (flagHasRemainingQuestions)
            ++result;
        result += extraMultipleChoiceQuizCurrentPlayerComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCurrentPlayer)
          {
            if (remainder == 0)
                return "CurrentPlayer";
            --remainder;
          }
        if (flagHasPlayerCount)
          {
            if (remainder == 0)
                return "PlayerCount";
            --remainder;
          }
        if (flagHasRound)
          {
            if (remainder == 0)
                return "Round";
            --remainder;
          }
        if (flagHasRemainingQuestions)
          {
            if (remainder == 0)
                return "RemainingQuestions";
            --remainder;
          }
        return extraMultipleChoiceQuizCurrentPlayerComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCurrentPlayer)
          {
            if (remainder == 0)
                return extraCurrentPlayerToJSON();
            --remainder;
          }
        if (flagHasPlayerCount)
          {
            if (remainder == 0)
                return extraPlayerCountToJSON();
            --remainder;
          }
        if (flagHasRound)
          {
            if (remainder == 0)
                return extraRoundToJSON();
            --remainder;
          }
        if (flagHasRemainingQuestions)
          {
            if (remainder == 0)
                return extraRemainingQuestionsToJSON();
            --remainder;
          }
        return extraMultipleChoiceQuizCurrentPlayerComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "urrentPlayer", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasCurrentPlayer ? extraCurrentPlayerToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "layerCount", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasPlayerCount ? extraPlayerCountToJSON() : null);
                break;
            case 'R':
                switch (field_name[1])
                  {
                    case 'e':
                        if ((String.Compare(field_name, 2, "mainingQuestions", 0, 16, false) == 0) && (field_name.Length == 18))
                            return (flagHasRemainingQuestions ? extraRemainingQuestionsToJSON() : null);
                        break;
                    case 'o':
                        if ((String.Compare(field_name, 2, "und", 0, 3, false) == 0) && (field_name.Length == 5))
                            return (flagHasRound ? extraRoundToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return extraMultipleChoiceQuizCurrentPlayerLookup(field_name);
      }

    public void setCurrentPlayer(BigInteger new_value)
      {
        flagHasCurrentPlayer = true;
        storeCurrentPlayer = new_value;
      }
    public void unsetCurrentPlayer()
      {
        flagHasCurrentPlayer = false;
      }
    public void setPlayerCount(BigInteger new_value)
      {
        flagHasPlayerCount = true;
        storePlayerCount = new_value;
      }
    public void unsetPlayerCount()
      {
        flagHasPlayerCount = false;
      }
    public void setRound(BigInteger new_value)
      {
        flagHasRound = true;
        storeRound = new_value;
      }
    public void unsetRound()
      {
        flagHasRound = false;
      }
    public void setRemainingQuestions(BigInteger new_value)
      {
        flagHasRemainingQuestions = true;
        storeRemainingQuestions = new_value;
      }
    public void unsetRemainingQuestions()
      {
        flagHasRemainingQuestions = false;
      }

    public virtual void extraMultipleChoiceQuizCurrentPlayerAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMultipleChoiceQuizCurrentPlayerSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMultipleChoiceQuizCurrentPlayerLookup(key);
        if (old_field == null)
          {
            extraMultipleChoiceQuizCurrentPlayerAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "urrentPlayer", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONCurrentPlayer(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "layerCount", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONPlayerCount(new_component, false);
                    return;
                    }
                break;
            case 'R':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "mainingQuestions", 0, 16, false) == 0) && (key.Length == 18))
                            {
                            fromJSONRemainingQuestions(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "und", 0, 3, false) == 0) && (key.Length == 5))
                            {
                            fromJSONRound(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraMultipleChoiceQuizCurrentPlayerAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "urrentPlayer", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONCurrentPlayer(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "layerCount", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONPlayerCount(new_component, false);
                    return;
                    }
                break;
            case 'R':
                switch (key[1])
                  {
                    case 'e':
                        if ((String.Compare(key, 2, "mainingQuestions", 0, 16, false) == 0) && (key.Length == 18))
                            {
                            fromJSONRemainingQuestions(new_component, false);
                            return;
                            }
                        break;
                    case 'o':
                        if ((String.Compare(key, 2, "und", 0, 3, false) == 0) && (key.Length == 5))
                            {
                            fromJSONRound(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        extraMultipleChoiceQuizCurrentPlayerSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCurrentPlayer);
        if (flagHasCurrentPlayer)
          {
            handler.start_pair("CurrentPlayer");
            handler.number_value(storeCurrentPlayer);
          }
        Debug.Assert(partial_allowed || flagHasPlayerCount);
        if (flagHasPlayerCount)
          {
            handler.start_pair("PlayerCount");
            handler.number_value(storePlayerCount);
          }
        if (flagHasRound)
          {
            handler.start_pair("Round");
            handler.number_value(storeRound);
          }
        if (flagHasRemainingQuestions)
          {
            handler.start_pair("RemainingQuestions");
            handler.number_value(storeRemainingQuestions);
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
        if (!(hasCurrentPlayer()))
          {
            return "When parsing the object for %what%, the \"CurrentPlayer\" field was missing.";
          }
        if (!(hasPlayerCount()))
          {
            return "When parsing the object for %what%, the \"PlayerCount\" field was missing.";
          }
        return null;
      }

    public static new MultipleChoiceQuizCurrentPlayerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizCurrentPlayerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizCurrentPlayer", ignore_extras);
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
    public static new MultipleChoiceQuizCurrentPlayerJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MultipleChoiceQuizCurrentPlayerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizCurrentPlayerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizCurrentPlayer", ignore_extras);
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
    public static new MultipleChoiceQuizCurrentPlayerJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MultipleChoiceQuizCurrentPlayerJSON from_text(string text, bool ignore_extras)
      {
        MultipleChoiceQuizCurrentPlayerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizCurrentPlayer", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MultipleChoiceQuizCurrentPlayerJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MultipleChoiceQuizCurrentPlayerJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MultipleChoiceQuizCurrentPlayerJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizCurrentPlayer", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
    private class FieldHoldingGeneratorCurrentPlayer : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorCurrentPlayer(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCurrentPlayer : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCurrentPlayer(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorCurrentPlayer fieldGeneratorCurrentPlayer;
    private class FieldHoldingGeneratorPlayerCount : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorPlayerCount(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPlayerCount : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPlayerCount(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorPlayerCount fieldGeneratorPlayerCount;
    private class FieldHoldingGeneratorRound : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorRound(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorRound : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorRound(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorRound fieldGeneratorRound;
    private class FieldHoldingGeneratorRemainingQuestions : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorRemainingQuestions(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorRemainingQuestions : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorRemainingQuestions(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorRemainingQuestions fieldGeneratorRemainingQuestions;
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
            if (!(getInformationNuggetJSONKey().Equals("MultipleChoiceQuizCurrentPlayer")))
                throw new Exception("The key field has a value other than `MultipleChoiceQuizCurrentPlayer'.");
            MultipleChoiceQuizCurrentPlayerJSON result = new MultipleChoiceQuizCurrentPlayerJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMultipleChoiceQuizCurrentPlayerAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((MultipleChoiceQuizCurrentPlayerJSON )new_result);
          }
        protected void finish(MultipleChoiceQuizCurrentPlayerJSON result)
          {
            if (fieldGeneratorCurrentPlayer.have_value)
              {
                result.setCurrentPlayer(fieldGeneratorCurrentPlayer.value);
                fieldGeneratorCurrentPlayer.have_value = false;
              }
            else if ((!(result.hasCurrentPlayer())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CurrentPlayer\" field was missing.");
              }
            if (fieldGeneratorPlayerCount.have_value)
              {
                result.setPlayerCount(fieldGeneratorPlayerCount.value);
                fieldGeneratorPlayerCount.have_value = false;
              }
            else if ((!(result.hasPlayerCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PlayerCount\" field was missing.");
              }
            if (fieldGeneratorRound.have_value)
              {
                result.setRound(fieldGeneratorRound.value);
                fieldGeneratorRound.have_value = false;
              }
            if (fieldGeneratorRemainingQuestions.have_value)
              {
                result.setRemainingQuestions(fieldGeneratorRemainingQuestions.value);
                fieldGeneratorRemainingQuestions.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MultipleChoiceQuizCurrentPlayerJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "urrentPlayer", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorCurrentPlayer;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "layerCount", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorPlayerCount;
                    break;
                case 'R':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "mainingQuestions", 0, 16, false) == 0) && (field_name.Length == 18))
                                return fieldGeneratorRemainingQuestions;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "und", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorRound;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCurrentPlayer = new FieldHoldingGeneratorCurrentPlayer("field \"CurrentPlayer\" of the MultipleChoiceQuizCurrentPlayer class");
            fieldGeneratorPlayerCount = new FieldHoldingGeneratorPlayerCount("field \"PlayerCount\" of the MultipleChoiceQuizCurrentPlayer class");
            fieldGeneratorRound = new FieldHoldingGeneratorRound("field \"Round\" of the MultipleChoiceQuizCurrentPlayer class");
            fieldGeneratorRemainingQuestions = new FieldHoldingGeneratorRemainingQuestions("field \"RemainingQuestions\" of the MultipleChoiceQuizCurrentPlayer class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MultipleChoiceQuizCurrentPlayer class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCurrentPlayer = new FieldHoldingGeneratorCurrentPlayer("field \"CurrentPlayer\" of the MultipleChoiceQuizCurrentPlayer class");
            fieldGeneratorPlayerCount = new FieldHoldingGeneratorPlayerCount("field \"PlayerCount\" of the MultipleChoiceQuizCurrentPlayer class");
            fieldGeneratorRound = new FieldHoldingGeneratorRound("field \"Round\" of the MultipleChoiceQuizCurrentPlayer class");
            fieldGeneratorRemainingQuestions = new FieldHoldingGeneratorRemainingQuestions("field \"RemainingQuestions\" of the MultipleChoiceQuizCurrentPlayer class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MultipleChoiceQuizCurrentPlayer class");
          }

        public override void reset()
          {
            fieldGeneratorCurrentPlayer.reset();
            fieldGeneratorPlayerCount.reset();
            fieldGeneratorRound.reset();
            fieldGeneratorRemainingQuestions.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MultipleChoiceQuizCurrentPlayerJSON  result)
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
        public MultipleChoiceQuizCurrentPlayerJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MultipleChoiceQuizCurrentPlayerJSON  result)
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
    protected virtual void handle_result(List<MultipleChoiceQuizCurrentPlayerJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MultipleChoiceQuizCurrentPlayerJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MultipleChoiceQuizCurrentPlayerJSON>();
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
    public List<MultipleChoiceQuizCurrentPlayerJSON> value;
  };
  };
