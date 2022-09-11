/* file "SportsPlayoffTriviaRanksJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsPlayoffTriviaRanksJSON : JSONBase
  {
    private bool flagHasOutcome;
    private SportsPlayoffTriviaOutcomeJSON  storeOutcome;
    private bool flagHasSpecialGameType;
    private SportsPlayoffSpecialGameJSON  storeSpecialGameType;
    private bool flagHasSortOrderReversed;
    private bool storeSortOrderReversed;
    private bool flagHasTeamsAndRanks;
    private List< SportsTeamAndRankJSON  > storeTeamsAndRanks;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONOutcome(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsPlayoffTriviaOutcomeJSON convert_classy = SportsPlayoffTriviaOutcomeJSON.from_json(json_value, ignore_extras, true);
        setOutcome(convert_classy);
      }


    private void  fromJSONSpecialGameType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsPlayoffSpecialGameJSON convert_classy = SportsPlayoffSpecialGameJSON.from_json(json_value, ignore_extras, true);
        setSpecialGameType(convert_classy);
      }


    private void  fromJSONSortOrderReversed(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SortOrderReversed of SportsPlayoffTriviaRanksJSON is not true for false.");
              }
          }
        setSortOrderReversed(the_bool);
      }


    private void  fromJSONTeamsAndRanks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TeamsAndRanks of SportsPlayoffTriviaRanksJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsTeamAndRankJSON  > vector_TeamsAndRanks1 = new List< SportsTeamAndRankJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsTeamAndRankJSON convert_classy = SportsTeamAndRankJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_TeamsAndRanks1.Add(convert_classy);
          }
        initTeamsAndRanks();
        for (int num1 = 0; num1 < vector_TeamsAndRanks1.Count; ++num1)
            appendTeamsAndRanks(vector_TeamsAndRanks1[num1]);
        for (int num1 = 0; num1 < vector_TeamsAndRanks1.Count; ++num1)
          {
          }
      }


    public SportsPlayoffTriviaRanksJSON()
      {
        flagHasOutcome = false;
        flagHasSpecialGameType = false;
        flagHasSortOrderReversed = false;
        flagHasTeamsAndRanks = false;
        storeTeamsAndRanks = new List< SportsTeamAndRankJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasOutcome()
      {
        return flagHasOutcome;
      }

    public SportsPlayoffTriviaOutcomeJSON   getOutcome()
      {
        Debug.Assert(flagHasOutcome);
        return storeOutcome;
      }

    public SportsPlayoffTriviaOutcomeJSON.TypeValue  getOutcomeValue()
      {
        return getOutcome().getValue();
      }

    public string  getOutcomeAsString()
      {
        return getOutcome().getValueAsString();
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

    public bool  hasSortOrderReversed()
      {
        return flagHasSortOrderReversed;
      }

    public bool  getSortOrderReversed()
      {
        Debug.Assert(flagHasSortOrderReversed);
        return storeSortOrderReversed;
      }

    public bool  hasTeamsAndRanks()
      {
        return flagHasTeamsAndRanks;
      }

    public int  countOfTeamsAndRanks()
      {
        Debug.Assert(flagHasTeamsAndRanks);
        return storeTeamsAndRanks.Count;
      }

    public SportsTeamAndRankJSON   elementOfTeamsAndRanks(int element_num)
      {
        Debug.Assert(flagHasTeamsAndRanks);
        return storeTeamsAndRanks[element_num];
      }

    public List< SportsTeamAndRankJSON  >  getTeamsAndRanks()
      {
        Debug.Assert(flagHasTeamsAndRanks);
        return storeTeamsAndRanks;
      }


    public virtual int extraSportsPlayoffTriviaRanksComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsPlayoffTriviaRanksComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsPlayoffTriviaRanksComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsPlayoffTriviaRanksLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setOutcome(SportsPlayoffTriviaOutcomeJSON  new_value)
      {
        if (flagHasOutcome)
          {
          }
        flagHasOutcome = true;
        storeOutcome = new_value;
      }
    public void setOutcome(SportsPlayoffTriviaOutcomeJSON.TypeValue new_value)
      {
        setOutcome(new SportsPlayoffTriviaOutcomeJSON(new_value));
      }
    public void setOutcome(string chars)
      {
        SportsPlayoffTriviaOutcomeJSON.TypeValueKnownValues known = SportsPlayoffTriviaOutcomeJSON.stringToValue(chars);
        SportsPlayoffTriviaOutcomeJSON.TypeValue new_value = new SportsPlayoffTriviaOutcomeJSON.TypeValue();
        if (known == SportsPlayoffTriviaOutcomeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setOutcome(new_value);
      }
    public void unsetOutcome()
      {
        if (flagHasOutcome)
          {
          }
        flagHasOutcome = false;
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
    public void setSortOrderReversed(bool new_value)
      {
        flagHasSortOrderReversed = true;
        storeSortOrderReversed = new_value;
      }
    public void unsetSortOrderReversed()
      {
        flagHasSortOrderReversed = false;
      }
    public void initTeamsAndRanks()
      {
        if (flagHasTeamsAndRanks)
          {
            for (int num1 = 0; num1 < storeTeamsAndRanks.Count; ++num1)
              {
              }
          }
        flagHasTeamsAndRanks = true;
        storeTeamsAndRanks.Clear();
      }
    public void appendTeamsAndRanks(SportsTeamAndRankJSON  to_append)
      {
        if (!flagHasTeamsAndRanks)
          {
            flagHasTeamsAndRanks = true;
            storeTeamsAndRanks.Clear();
          }
        Debug.Assert(flagHasTeamsAndRanks);
        storeTeamsAndRanks.Add(to_append);
      }
    public void unsetTeamsAndRanks()
      {
        if (flagHasTeamsAndRanks)
          {
            for (int num2 = 0; num2 < storeTeamsAndRanks.Count; ++num2)
              {
              }
          }
        flagHasTeamsAndRanks = false;
        storeTeamsAndRanks.Clear();
      }

    public virtual void extraSportsPlayoffTriviaRanksAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsPlayoffTriviaRanksSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsPlayoffTriviaRanksLookup(key);
        if (old_field == null)
          {
            extraSportsPlayoffTriviaRanksAppendPair(key, new_component);
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
        if (flagHasOutcome)
          {
            handler.start_pair("Outcome");
            if (partial_allowed)
                storeOutcome.write_partial_as_json(handler);
            else
                storeOutcome.write_as_json(handler);
          }
        if (flagHasSpecialGameType)
          {
            handler.start_pair("SpecialGameType");
            if (partial_allowed)
                storeSpecialGameType.write_partial_as_json(handler);
            else
                storeSpecialGameType.write_as_json(handler);
          }
        if (flagHasSortOrderReversed)
          {
            handler.start_pair("SortOrderReversed");
            handler.boolean_value(storeSortOrderReversed);
          }
        if (flagHasTeamsAndRanks)
          {
            handler.start_pair("TeamsAndRanks");
            handler.start_array();
            for (int num1 = 0; num1 < storeTeamsAndRanks.Count; ++num1)
              {
                if (partial_allowed)
                    storeTeamsAndRanks[num1].write_partial_as_json(handler);
                else
                    storeTeamsAndRanks[num1].write_as_json(handler);
              }
            handler.finish_array();
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

    public static SportsPlayoffTriviaRanksJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffTriviaRanksJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaRanks", ignore_extras);
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
    public static SportsPlayoffTriviaRanksJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayoffTriviaRanksJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffTriviaRanksJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaRanks", ignore_extras);
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
    public static SportsPlayoffTriviaRanksJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayoffTriviaRanksJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayoffTriviaRanksJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaRanks", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayoffTriviaRanksJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsPlayoffTriviaRanksJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayoffTriviaRanksJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaRanks", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsPlayoffTriviaOutcomeJSON.HoldingGenerator fieldGeneratorOutcome;
        private SportsPlayoffSpecialGameJSON.HoldingGenerator fieldGeneratorSpecialGameType;
        private JSONHoldingBooleanGenerator fieldGeneratorSortOrderReversed;
        private SportsTeamAndRankJSON.HoldingArrayGenerator fieldGeneratorTeamsAndRanks;
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
            SportsPlayoffTriviaRanksJSON result = new SportsPlayoffTriviaRanksJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsPlayoffTriviaRanksAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsPlayoffTriviaRanksJSON result)
          {
            if (fieldGeneratorOutcome.have_value)
              {
                result.setOutcome(fieldGeneratorOutcome.value);
                fieldGeneratorOutcome.have_value = false;
              }
            if (fieldGeneratorSpecialGameType.have_value)
              {
                result.setSpecialGameType(fieldGeneratorSpecialGameType.value);
                fieldGeneratorSpecialGameType.have_value = false;
              }
            if (fieldGeneratorSortOrderReversed.have_value)
              {
                result.setSortOrderReversed(fieldGeneratorSortOrderReversed.value);
                fieldGeneratorSortOrderReversed.have_value = false;
              }
            if (fieldGeneratorTeamsAndRanks.have_value)
              {
                result.initTeamsAndRanks();
                int count = fieldGeneratorTeamsAndRanks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTeamsAndRanks(fieldGeneratorTeamsAndRanks.value[num]);
                  }
                fieldGeneratorTeamsAndRanks.value.Clear();
                fieldGeneratorTeamsAndRanks.have_value = false;
              }
          }
        protected abstract void handle_result(SportsPlayoffTriviaRanksJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'O':
                    if ((String.Compare(field_name, 1, "utcome", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorOutcome;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'o':
                            if ((String.Compare(field_name, 2, "rtOrderReversed", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorSortOrderReversed;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "ecialGameType", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorSpecialGameType;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "eamsAndRanks", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorTeamsAndRanks;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorOutcome = new SportsPlayoffTriviaOutcomeJSON.HoldingGenerator("field \"Outcome\" of the SportsPlayoffTriviaRanks class", ignore_extras);
            fieldGeneratorSpecialGameType = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"SpecialGameType\" of the SportsPlayoffTriviaRanks class", ignore_extras);
            fieldGeneratorSortOrderReversed = new JSONHoldingBooleanGenerator("field \"SortOrderReversed\" of the SportsPlayoffTriviaRanks class");
            fieldGeneratorTeamsAndRanks = new SportsTeamAndRankJSON.HoldingArrayGenerator("field \"TeamsAndRanks\" of the SportsPlayoffTriviaRanks class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsPlayoffTriviaRanks class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorOutcome = new SportsPlayoffTriviaOutcomeJSON.HoldingGenerator("field \"Outcome\" of the SportsPlayoffTriviaRanks class", false);
            fieldGeneratorSpecialGameType = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"SpecialGameType\" of the SportsPlayoffTriviaRanks class", false);
            fieldGeneratorSortOrderReversed = new JSONHoldingBooleanGenerator("field \"SortOrderReversed\" of the SportsPlayoffTriviaRanks class");
            fieldGeneratorTeamsAndRanks = new SportsTeamAndRankJSON.HoldingArrayGenerator("field \"TeamsAndRanks\" of the SportsPlayoffTriviaRanks class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsPlayoffTriviaRanks class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorOutcome.reset();
            fieldGeneratorSpecialGameType.reset();
            fieldGeneratorSortOrderReversed.reset();
            fieldGeneratorTeamsAndRanks.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorOutcome.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSpecialGameType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTeamsAndRanks.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorOutcome.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSpecialGameType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTeamsAndRanks.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsPlayoffTriviaRanksJSON  result)
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
        public SportsPlayoffTriviaRanksJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayoffTriviaRanksJSON  result)
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
    protected virtual void handle_result(List<SportsPlayoffTriviaRanksJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayoffTriviaRanksJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayoffTriviaRanksJSON>();
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
    public List<SportsPlayoffTriviaRanksJSON> value;
  };
  };
