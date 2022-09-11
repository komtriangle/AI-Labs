/* file "MultipleChoiceQuizGameJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MultipleChoiceQuizGameJSON : JSONBase
  {
    private bool flagHasCurrentPlayer;
    private BigInteger storeCurrentPlayer;
    private bool flagHasRound;
    private BigInteger storeRound;
    private bool flagHasHasEnded;
    private bool storeHasEnded;
    private bool flagHasStats;
    private MultipleChoiceQuizStatsJSON  storeStats;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


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
                throw new Exception("The value for field CurrentPlayer of MultipleChoiceQuizGameJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CurrentPlayer of MultipleChoiceQuizGameJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCurrentPlayer(extracted_integer);
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
                throw new Exception("The value for field Round of MultipleChoiceQuizGameJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Round of MultipleChoiceQuizGameJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRound(extracted_integer);
      }


    private void  fromJSONHasEnded(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HasEnded of MultipleChoiceQuizGameJSON is not true for false.");
              }
          }
        setHasEnded(the_bool);
      }


    private void  fromJSONStats(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MultipleChoiceQuizStatsJSON convert_classy = MultipleChoiceQuizStatsJSON.from_json(json_value, ignore_extras, true);
        setStats(convert_classy);
      }


    public MultipleChoiceQuizGameJSON()
      {
        flagHasCurrentPlayer = false;
        flagHasRound = false;
        flagHasHasEnded = false;
        flagHasStats = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasRound()
      {
        return flagHasRound;
      }

    public BigInteger  getRound()
      {
        Debug.Assert(flagHasRound);
        return storeRound;
      }

    public bool  hasHasEnded()
      {
        return flagHasHasEnded;
      }

    public bool  getHasEnded()
      {
        Debug.Assert(flagHasHasEnded);
        return storeHasEnded;
      }

    public bool  hasStats()
      {
        return flagHasStats;
      }

    public MultipleChoiceQuizStatsJSON   getStats()
      {
        Debug.Assert(flagHasStats);
        return storeStats;
      }


    public virtual int extraMultipleChoiceQuizGameComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMultipleChoiceQuizGameComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizGameComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizGameLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setRound(BigInteger new_value)
      {
        flagHasRound = true;
        storeRound = new_value;
      }
    public void unsetRound()
      {
        flagHasRound = false;
      }
    public void setHasEnded(bool new_value)
      {
        flagHasHasEnded = true;
        storeHasEnded = new_value;
      }
    public void unsetHasEnded()
      {
        flagHasHasEnded = false;
      }
    public void setStats(MultipleChoiceQuizStatsJSON  new_value)
      {
        if (flagHasStats)
          {
          }
        flagHasStats = true;
        storeStats = new_value;
      }
    public void unsetStats()
      {
        if (flagHasStats)
          {
          }
        flagHasStats = false;
      }

    public virtual void extraMultipleChoiceQuizGameAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMultipleChoiceQuizGameSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMultipleChoiceQuizGameLookup(key);
        if (old_field == null)
          {
            extraMultipleChoiceQuizGameAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCurrentPlayer);
        if (flagHasCurrentPlayer)
          {
            handler.start_pair("CurrentPlayer");
            handler.number_value(storeCurrentPlayer);
          }
        Debug.Assert(partial_allowed || flagHasRound);
        if (flagHasRound)
          {
            handler.start_pair("Round");
            handler.number_value(storeRound);
          }
        Debug.Assert(partial_allowed || flagHasHasEnded);
        if (flagHasHasEnded)
          {
            handler.start_pair("HasEnded");
            handler.boolean_value(storeHasEnded);
          }
        Debug.Assert(partial_allowed || flagHasStats);
        if (flagHasStats)
          {
            handler.start_pair("Stats");
            if (partial_allowed)
                storeStats.write_partial_as_json(handler);
            else
                storeStats.write_as_json(handler);
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
        if (!(hasCurrentPlayer()))
          {
            return "When parsing the object for %what%, the \"CurrentPlayer\" field was missing.";
          }
        if (!(hasRound()))
          {
            return "When parsing the object for %what%, the \"Round\" field was missing.";
          }
        if (!(hasHasEnded()))
          {
            return "When parsing the object for %what%, the \"HasEnded\" field was missing.";
          }
        if (!(hasStats()))
          {
            return "When parsing the object for %what%, the \"Stats\" field was missing.";
          }
        return null;
      }

    public static MultipleChoiceQuizGameJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizGameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizGame", ignore_extras);
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
    public static MultipleChoiceQuizGameJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MultipleChoiceQuizGameJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizGameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizGame", ignore_extras);
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
    public static MultipleChoiceQuizGameJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MultipleChoiceQuizGameJSON from_text(string text, bool ignore_extras)
      {
        MultipleChoiceQuizGameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizGame", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MultipleChoiceQuizGameJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MultipleChoiceQuizGameJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MultipleChoiceQuizGameJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizGame", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
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
        private JSONHoldingBooleanGenerator fieldGeneratorHasEnded;
        private MultipleChoiceQuizStatsJSON.HoldingGenerator fieldGeneratorStats;
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
            MultipleChoiceQuizGameJSON result = new MultipleChoiceQuizGameJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMultipleChoiceQuizGameAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MultipleChoiceQuizGameJSON result)
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
            if (fieldGeneratorRound.have_value)
              {
                result.setRound(fieldGeneratorRound.value);
                fieldGeneratorRound.have_value = false;
              }
            else if ((!(result.hasRound())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Round\" field was missing.");
              }
            if (fieldGeneratorHasEnded.have_value)
              {
                result.setHasEnded(fieldGeneratorHasEnded.value);
                fieldGeneratorHasEnded.have_value = false;
              }
            else if ((!(result.hasHasEnded())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HasEnded\" field was missing.");
              }
            if (fieldGeneratorStats.have_value)
              {
                result.setStats(fieldGeneratorStats.value);
                fieldGeneratorStats.have_value = false;
              }
            else if ((!(result.hasStats())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Stats\" field was missing.");
              }
          }
        protected abstract void handle_result(MultipleChoiceQuizGameJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "urrentPlayer", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorCurrentPlayer;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "asEnded", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorHasEnded;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ound", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorRound;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tats", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorStats;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCurrentPlayer = new FieldHoldingGeneratorCurrentPlayer("field \"CurrentPlayer\" of the MultipleChoiceQuizGame class");
            fieldGeneratorRound = new FieldHoldingGeneratorRound("field \"Round\" of the MultipleChoiceQuizGame class");
            fieldGeneratorHasEnded = new JSONHoldingBooleanGenerator("field \"HasEnded\" of the MultipleChoiceQuizGame class");
            fieldGeneratorStats = new MultipleChoiceQuizStatsJSON.HoldingGenerator("field \"Stats\" of the MultipleChoiceQuizGame class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MultipleChoiceQuizGame class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCurrentPlayer = new FieldHoldingGeneratorCurrentPlayer("field \"CurrentPlayer\" of the MultipleChoiceQuizGame class");
            fieldGeneratorRound = new FieldHoldingGeneratorRound("field \"Round\" of the MultipleChoiceQuizGame class");
            fieldGeneratorHasEnded = new JSONHoldingBooleanGenerator("field \"HasEnded\" of the MultipleChoiceQuizGame class");
            fieldGeneratorStats = new MultipleChoiceQuizStatsJSON.HoldingGenerator("field \"Stats\" of the MultipleChoiceQuizGame class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MultipleChoiceQuizGame class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCurrentPlayer.reset();
            fieldGeneratorRound.reset();
            fieldGeneratorHasEnded.reset();
            fieldGeneratorStats.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStats.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStats.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MultipleChoiceQuizGameJSON  result)
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
        public MultipleChoiceQuizGameJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MultipleChoiceQuizGameJSON  result)
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
    protected virtual void handle_result(List<MultipleChoiceQuizGameJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MultipleChoiceQuizGameJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MultipleChoiceQuizGameJSON>();
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
    public List<MultipleChoiceQuizGameJSON> value;
  };
  };
