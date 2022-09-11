/* file "SportsOlympicsMedalStandingsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsOlympicsMedalStandingsJSON : JSONBase
  {
    private bool flagHasGames;
    private SportsOlympicsGamesJSON  storeGames;
    private bool flagHasStandings;
    private List< SportsOlympicsMedalStandingsOrganizationMedalCountJSON  > storeStandings;
    private bool flagHasSortMethod;
    private SportsOlympicsMedalStandingsSortMethodJSON  storeSortMethod;
    private bool flagHasIsAbridged;
    private bool storeIsAbridged;
    private bool flagHasAbridgedMaximumRank;
    private BigInteger storeAbridgedMaximumRank;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONGames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsGamesJSON convert_classy = SportsOlympicsGamesJSON.from_json(json_value, ignore_extras, true);
        setGames(convert_classy);
      }


    private void  fromJSONStandings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Standings of SportsOlympicsMedalStandingsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsOlympicsMedalStandingsOrganizationMedalCountJSON  > vector_Standings1 = new List< SportsOlympicsMedalStandingsOrganizationMedalCountJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsMedalStandingsOrganizationMedalCountJSON convert_classy = SportsOlympicsMedalStandingsOrganizationMedalCountJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Standings1.Add(convert_classy);
          }
        initStandings();
        for (int num1 = 0; num1 < vector_Standings1.Count; ++num1)
            appendStandings(vector_Standings1[num1]);
        for (int num1 = 0; num1 < vector_Standings1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSortMethod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsMedalStandingsSortMethodJSON convert_classy = SportsOlympicsMedalStandingsSortMethodJSON.from_json(json_value, ignore_extras, true);
        setSortMethod(convert_classy);
      }


    private void  fromJSONIsAbridged(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsAbridged of SportsOlympicsMedalStandingsJSON is not true for false.");
              }
          }
        setIsAbridged(the_bool);
      }


    private void  fromJSONAbridgedMaximumRank(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AbridgedMaximumRank of SportsOlympicsMedalStandingsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AbridgedMaximumRank of SportsOlympicsMedalStandingsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAbridgedMaximumRank(extracted_integer);
      }


    public SportsOlympicsMedalStandingsJSON()
      {
        flagHasGames = false;
        flagHasStandings = false;
        flagHasSortMethod = false;
        flagHasIsAbridged = false;
        flagHasAbridgedMaximumRank = false;
        storeStandings = new List< SportsOlympicsMedalStandingsOrganizationMedalCountJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasGames()
      {
        return flagHasGames;
      }

    public SportsOlympicsGamesJSON   getGames()
      {
        Debug.Assert(flagHasGames);
        return storeGames;
      }

    public bool  hasStandings()
      {
        return flagHasStandings;
      }

    public int  countOfStandings()
      {
        Debug.Assert(flagHasStandings);
        return storeStandings.Count;
      }

    public SportsOlympicsMedalStandingsOrganizationMedalCountJSON   elementOfStandings(int element_num)
      {
        Debug.Assert(flagHasStandings);
        return storeStandings[element_num];
      }

    public List< SportsOlympicsMedalStandingsOrganizationMedalCountJSON  >  getStandings()
      {
        Debug.Assert(flagHasStandings);
        return storeStandings;
      }

    public bool  hasSortMethod()
      {
        return flagHasSortMethod;
      }

    public SportsOlympicsMedalStandingsSortMethodJSON   getSortMethod()
      {
        Debug.Assert(flagHasSortMethod);
        return storeSortMethod;
      }

    public SportsOlympicsMedalStandingsSortMethodJSON.TypeValue  getSortMethodValue()
      {
        return getSortMethod().getValue();
      }

    public string  getSortMethodAsString()
      {
        return getSortMethod().getValueAsString();
      }

    public bool  hasIsAbridged()
      {
        return flagHasIsAbridged;
      }

    public bool  getIsAbridged()
      {
        Debug.Assert(flagHasIsAbridged);
        return storeIsAbridged;
      }

    public bool  hasAbridgedMaximumRank()
      {
        return flagHasAbridgedMaximumRank;
      }

    public BigInteger  getAbridgedMaximumRank()
      {
        Debug.Assert(flagHasAbridgedMaximumRank);
        return storeAbridgedMaximumRank;
      }


    public virtual int extraSportsOlympicsMedalStandingsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsMedalStandingsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setGames(SportsOlympicsGamesJSON  new_value)
      {
        if (flagHasGames)
          {
          }
        flagHasGames = true;
        storeGames = new_value;
      }
    public void unsetGames()
      {
        if (flagHasGames)
          {
          }
        flagHasGames = false;
      }
    public void initStandings()
      {
        if (flagHasStandings)
          {
            for (int num1 = 0; num1 < storeStandings.Count; ++num1)
              {
              }
          }
        flagHasStandings = true;
        storeStandings.Clear();
      }
    public void appendStandings(SportsOlympicsMedalStandingsOrganizationMedalCountJSON  to_append)
      {
        if (!flagHasStandings)
          {
            flagHasStandings = true;
            storeStandings.Clear();
          }
        Debug.Assert(flagHasStandings);
        storeStandings.Add(to_append);
      }
    public void unsetStandings()
      {
        if (flagHasStandings)
          {
            for (int num2 = 0; num2 < storeStandings.Count; ++num2)
              {
              }
          }
        flagHasStandings = false;
        storeStandings.Clear();
      }
    public void setSortMethod(SportsOlympicsMedalStandingsSortMethodJSON  new_value)
      {
        if (flagHasSortMethod)
          {
          }
        flagHasSortMethod = true;
        storeSortMethod = new_value;
      }
    public void setSortMethod(SportsOlympicsMedalStandingsSortMethodJSON.TypeValue new_value)
      {
        setSortMethod(new SportsOlympicsMedalStandingsSortMethodJSON(new_value));
      }
    public void setSortMethod(string chars)
      {
        SportsOlympicsMedalStandingsSortMethodJSON.TypeValueKnownValues known = SportsOlympicsMedalStandingsSortMethodJSON.stringToValue(chars);
        SportsOlympicsMedalStandingsSortMethodJSON.TypeValue new_value = new SportsOlympicsMedalStandingsSortMethodJSON.TypeValue();
        if (known == SportsOlympicsMedalStandingsSortMethodJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSortMethod(new_value);
      }
    public void unsetSortMethod()
      {
        if (flagHasSortMethod)
          {
          }
        flagHasSortMethod = false;
      }
    public void setIsAbridged(bool new_value)
      {
        flagHasIsAbridged = true;
        storeIsAbridged = new_value;
      }
    public void unsetIsAbridged()
      {
        flagHasIsAbridged = false;
      }
    public void setAbridgedMaximumRank(BigInteger new_value)
      {
        flagHasAbridgedMaximumRank = true;
        if (new_value < 1)
            throw new Exception("The value for field AbridgedMaximumRank of SportsOlympicsMedalStandingsJSON is less than the lower bound (1) for that field.");
        storeAbridgedMaximumRank = new_value;
      }
    public void unsetAbridgedMaximumRank()
      {
        flagHasAbridgedMaximumRank = false;
      }

    public virtual void extraSportsOlympicsMedalStandingsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsMedalStandingsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsMedalStandingsLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsMedalStandingsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasGames);
        if (flagHasGames)
          {
            handler.start_pair("Games");
            if (partial_allowed)
                storeGames.write_partial_as_json(handler);
            else
                storeGames.write_as_json(handler);
          }
        if (flagHasStandings)
          {
            handler.start_pair("Standings");
            handler.start_array();
            for (int num1 = 0; num1 < storeStandings.Count; ++num1)
              {
                if (partial_allowed)
                    storeStandings[num1].write_partial_as_json(handler);
                else
                    storeStandings[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSortMethod)
          {
            handler.start_pair("SortMethod");
            if (partial_allowed)
                storeSortMethod.write_partial_as_json(handler);
            else
                storeSortMethod.write_as_json(handler);
          }
        if (flagHasIsAbridged)
          {
            handler.start_pair("IsAbridged");
            handler.boolean_value(storeIsAbridged);
          }
        if (flagHasAbridgedMaximumRank)
          {
            handler.start_pair("AbridgedMaximumRank");
            handler.number_value(storeAbridgedMaximumRank);
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
        if (!(hasGames()))
          {
            return "When parsing the object for %what%, the \"Games\" field was missing.";
          }
        return null;
      }

    public static SportsOlympicsMedalStandingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandings", ignore_extras);
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
    public static SportsOlympicsMedalStandingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsMedalStandingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandings", ignore_extras);
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
    public static SportsOlympicsMedalStandingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsMedalStandingsJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandings", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsMedalStandingsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsMedalStandingsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandings", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsOlympicsGamesJSON.HoldingGenerator fieldGeneratorGames;
        private SportsOlympicsMedalStandingsOrganizationMedalCountJSON.HoldingArrayGenerator fieldGeneratorStandings;
        private SportsOlympicsMedalStandingsSortMethodJSON.HoldingGenerator fieldGeneratorSortMethod;
        private JSONHoldingBooleanGenerator fieldGeneratorIsAbridged;
    private class FieldHoldingGeneratorAbridgedMaximumRank : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorAbridgedMaximumRank(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorAbridgedMaximumRank : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorAbridgedMaximumRank(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorAbridgedMaximumRank fieldGeneratorAbridgedMaximumRank;
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
            SportsOlympicsMedalStandingsJSON result = new SportsOlympicsMedalStandingsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsMedalStandingsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsMedalStandingsJSON result)
          {
            if (fieldGeneratorGames.have_value)
              {
                result.setGames(fieldGeneratorGames.value);
                fieldGeneratorGames.have_value = false;
              }
            else if ((!(result.hasGames())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Games\" field was missing.");
              }
            if (fieldGeneratorStandings.have_value)
              {
                result.initStandings();
                int count = fieldGeneratorStandings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStandings(fieldGeneratorStandings.value[num]);
                  }
                fieldGeneratorStandings.value.Clear();
                fieldGeneratorStandings.have_value = false;
              }
            if (fieldGeneratorSortMethod.have_value)
              {
                result.setSortMethod(fieldGeneratorSortMethod.value);
                fieldGeneratorSortMethod.have_value = false;
              }
            if (fieldGeneratorIsAbridged.have_value)
              {
                result.setIsAbridged(fieldGeneratorIsAbridged.value);
                fieldGeneratorIsAbridged.have_value = false;
              }
            if (fieldGeneratorAbridgedMaximumRank.have_value)
              {
                result.setAbridgedMaximumRank(fieldGeneratorAbridgedMaximumRank.value);
                fieldGeneratorAbridgedMaximumRank.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsMedalStandingsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "bridgedMaximumRank", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorAbridgedMaximumRank;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "ames", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorGames;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "sAbridged", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorIsAbridged;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'o':
                            if ((String.Compare(field_name, 2, "rtMethod", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSortMethod;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "andings", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorStandings;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorGames = new SportsOlympicsGamesJSON.HoldingGenerator("field \"Games\" of the SportsOlympicsMedalStandings class", ignore_extras);
            fieldGeneratorStandings = new SportsOlympicsMedalStandingsOrganizationMedalCountJSON.HoldingArrayGenerator("field \"Standings\" of the SportsOlympicsMedalStandings class", ignore_extras);
            fieldGeneratorSortMethod = new SportsOlympicsMedalStandingsSortMethodJSON.HoldingGenerator("field \"SortMethod\" of the SportsOlympicsMedalStandings class", ignore_extras);
            fieldGeneratorIsAbridged = new JSONHoldingBooleanGenerator("field \"IsAbridged\" of the SportsOlympicsMedalStandings class");
            fieldGeneratorAbridgedMaximumRank = new FieldHoldingGeneratorAbridgedMaximumRank("field \"AbridgedMaximumRank\" of the SportsOlympicsMedalStandings class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsMedalStandings class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorGames = new SportsOlympicsGamesJSON.HoldingGenerator("field \"Games\" of the SportsOlympicsMedalStandings class", false);
            fieldGeneratorStandings = new SportsOlympicsMedalStandingsOrganizationMedalCountJSON.HoldingArrayGenerator("field \"Standings\" of the SportsOlympicsMedalStandings class", false);
            fieldGeneratorSortMethod = new SportsOlympicsMedalStandingsSortMethodJSON.HoldingGenerator("field \"SortMethod\" of the SportsOlympicsMedalStandings class", false);
            fieldGeneratorIsAbridged = new JSONHoldingBooleanGenerator("field \"IsAbridged\" of the SportsOlympicsMedalStandings class");
            fieldGeneratorAbridgedMaximumRank = new FieldHoldingGeneratorAbridgedMaximumRank("field \"AbridgedMaximumRank\" of the SportsOlympicsMedalStandings class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsMedalStandings class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorGames.reset();
            fieldGeneratorStandings.reset();
            fieldGeneratorSortMethod.reset();
            fieldGeneratorIsAbridged.reset();
            fieldGeneratorAbridgedMaximumRank.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorGames.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStandings.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSortMethod.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorGames.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStandings.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSortMethod.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsMedalStandingsJSON  result)
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
        public SportsOlympicsMedalStandingsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsMedalStandingsJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsMedalStandingsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsMedalStandingsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsMedalStandingsJSON>();
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
    public List<SportsOlympicsMedalStandingsJSON> value;
  };
  };
