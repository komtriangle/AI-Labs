/* file "SportsStandingsQueryDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsStandingsQueryDataJSON : JSONBase
  {
    public enum TypeGroupingKnownValues
      {
        Grouping_Divisional,
        Grouping_Conference,
        Grouping_League,
        Grouping_WildCard,
        Grouping__none
      };
    public struct TypeGrouping
      {
        public bool in_known_list;
        public string string_value;
        public TypeGroupingKnownValues list_value;
      };

    public static TypeGroupingKnownValues  stringToGrouping(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "onference", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeGroupingKnownValues.Grouping_Conference;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "ivisional", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeGroupingKnownValues.Grouping_Divisional;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "eague", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeGroupingKnownValues.Grouping_League;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "ildCard", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeGroupingKnownValues.Grouping_WildCard;
                break;
            default:
                break;
          }
        return TypeGroupingKnownValues.Grouping__none;
      }

    public static string  stringFromGrouping(TypeGroupingKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeGroupingKnownValues.Grouping_Divisional:
                return "Divisional";
            case TypeGroupingKnownValues.Grouping_Conference:
                return "Conference";
            case TypeGroupingKnownValues.Grouping_League:
                return "League";
            case TypeGroupingKnownValues.Grouping_WildCard:
                return "WildCard";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeDivisionTeamIndicesJSON : JSONBase
      {
        private bool flagHasDivisionIndex;
        private BigInteger storeDivisionIndex;
        private bool flagHasTeamIndex;
        private BigInteger storeTeamIndex;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONDivisionIndex(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field DivisionIndex of TypeDivisionTeamIndicesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field DivisionIndex of TypeDivisionTeamIndicesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setDivisionIndex(extracted_integer);
          }


        private void  fromJSONTeamIndex(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field TeamIndex of TypeDivisionTeamIndicesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field TeamIndex of TypeDivisionTeamIndicesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setTeamIndex(extracted_integer);
          }


        public TypeDivisionTeamIndicesJSON()
          {
            flagHasDivisionIndex = false;
            flagHasTeamIndex = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasDivisionIndex()
          {
            return flagHasDivisionIndex;
          }

        public BigInteger  getDivisionIndex()
          {
            Debug.Assert(flagHasDivisionIndex);
            return storeDivisionIndex;
          }

        public bool  hasTeamIndex()
          {
            return flagHasTeamIndex;
          }

        public BigInteger  getTeamIndex()
          {
            Debug.Assert(flagHasTeamIndex);
            return storeTeamIndex;
          }


        public virtual int extraTypeDivisionTeamIndicesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeDivisionTeamIndicesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeDivisionTeamIndicesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeDivisionTeamIndicesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setDivisionIndex(BigInteger new_value)
          {
            flagHasDivisionIndex = true;
            if (new_value < 0)
                throw new Exception("The value for field DivisionIndex of TypeDivisionTeamIndicesJSON is less than the lower bound (0) for that field.");
            storeDivisionIndex = new_value;
          }
        public void unsetDivisionIndex()
          {
            flagHasDivisionIndex = false;
          }
        public void setTeamIndex(BigInteger new_value)
          {
            flagHasTeamIndex = true;
            if (new_value < 0)
                throw new Exception("The value for field TeamIndex of TypeDivisionTeamIndicesJSON is less than the lower bound (0) for that field.");
            storeTeamIndex = new_value;
          }
        public void unsetTeamIndex()
          {
            flagHasTeamIndex = false;
          }

        public virtual void extraTypeDivisionTeamIndicesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeDivisionTeamIndicesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeDivisionTeamIndicesLookup(key);
            if (old_field == null)
              {
                extraTypeDivisionTeamIndicesAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasDivisionIndex);
            if (flagHasDivisionIndex)
              {
                handler.start_pair("DivisionIndex");
                handler.number_value(storeDivisionIndex);
              }
            if (flagHasTeamIndex)
              {
                handler.start_pair("TeamIndex");
                handler.number_value(storeTeamIndex);
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
            if (!(hasDivisionIndex()))
              {
                return "When parsing the object for %what%, the \"DivisionIndex\" field was missing.";
              }
            return null;
          }

        public static TypeDivisionTeamIndicesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDivisionTeamIndicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDivisionTeamIndices", ignore_extras);
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
        public static TypeDivisionTeamIndicesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDivisionTeamIndicesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDivisionTeamIndicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDivisionTeamIndices", ignore_extras);
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
        public static TypeDivisionTeamIndicesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDivisionTeamIndicesJSON from_text(string text, bool ignore_extras)
          {
            TypeDivisionTeamIndicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDivisionTeamIndices", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDivisionTeamIndicesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDivisionTeamIndicesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDivisionTeamIndicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDivisionTeamIndices", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorDivisionIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorDivisionIndex(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorDivisionIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorDivisionIndex(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorDivisionIndex fieldGeneratorDivisionIndex;
        private class FieldHoldingGeneratorTeamIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorTeamIndex(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorTeamIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorTeamIndex(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorTeamIndex fieldGeneratorTeamIndex;
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
                TypeDivisionTeamIndicesJSON result = new TypeDivisionTeamIndicesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeDivisionTeamIndicesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeDivisionTeamIndicesJSON result)
              {
                if (fieldGeneratorDivisionIndex.have_value)
                  {
                    result.setDivisionIndex(fieldGeneratorDivisionIndex.value);
                    fieldGeneratorDivisionIndex.have_value = false;
                  }
                else if ((!(result.hasDivisionIndex())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"DivisionIndex\" field was missing.");
                  }
                if (fieldGeneratorTeamIndex.have_value)
                  {
                    result.setTeamIndex(fieldGeneratorTeamIndex.value);
                    fieldGeneratorTeamIndex.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeDivisionTeamIndicesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "ivisionIndex", 0, 12, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorDivisionIndex;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "eamIndex", 0, 8, false) == 0) && (field_name.Length == 9))
                            return fieldGeneratorTeamIndex;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorDivisionIndex = new FieldHoldingGeneratorDivisionIndex("field \"DivisionIndex\" of the TypeDivisionTeamIndices class");
                fieldGeneratorTeamIndex = new FieldHoldingGeneratorTeamIndex("field \"TeamIndex\" of the TypeDivisionTeamIndices class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeDivisionTeamIndices class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorDivisionIndex = new FieldHoldingGeneratorDivisionIndex("field \"DivisionIndex\" of the TypeDivisionTeamIndices class");
                fieldGeneratorTeamIndex = new FieldHoldingGeneratorTeamIndex("field \"TeamIndex\" of the TypeDivisionTeamIndices class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeDivisionTeamIndices class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorDivisionIndex.reset();
                fieldGeneratorTeamIndex.reset();
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
            protected override void handle_result(TypeDivisionTeamIndicesJSON  result)
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
            public TypeDivisionTeamIndicesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDivisionTeamIndicesJSON  result)
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
        protected virtual void handle_result(List<TypeDivisionTeamIndicesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDivisionTeamIndicesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDivisionTeamIndicesJSON>();
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
        public List<TypeDivisionTeamIndicesJSON> value;
      };
      };
    public enum TypeErrorKnownValues
      {
        Error_DataUnavailable,
        Error__none
      };
    public struct TypeError
      {
        public bool in_known_list;
        public string string_value;
        public TypeErrorKnownValues list_value;
      };

    public static TypeErrorKnownValues  stringToError(string chars)
      {
        if ((String.Compare(chars, 0, "DataUnavailable", 0, 15, false) == 0) && (chars.Length == 15))
            return TypeErrorKnownValues.Error_DataUnavailable;
        return TypeErrorKnownValues.Error__none;
      }

    public static string  stringFromError(TypeErrorKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeErrorKnownValues.Error_DataUnavailable:
                return "DataUnavailable";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasType;
    private SportsStandingsQueryTypeJSON  storeType;
    private bool flagHasLeague;
    private SportsLeagueCodeJSON  storeLeague;
    private bool flagHasDivision;
    private SportsLeagueDivisionJSON  storeDivision;
    private bool flagHasTeam;
    private SportsTeamNewJSON  storeTeam;
    private bool flagHasTeamOther;
    private SportsTeamNewJSON  storeTeamOther;
    private bool flagHasRank;
    private BigInteger storeRank;
    private bool flagHasGrouping;
    private TypeGrouping storeGrouping;
    private bool flagHasSeason;
    private SportsSeasonResolvedJSON  storeSeason;
    private bool flagHasStandingsIndex;
    private BigInteger storeStandingsIndex;
    private bool flagHasTournament;
    private SportsTournamentJSON  storeTournament;
    private bool flagHasDivisionTeamIndices;
    private List< TypeDivisionTeamIndicesJSON  > storeDivisionTeamIndices;
    private bool flagHasGamesBehindOtherTeam;
    private double storeGamesBehindOtherTeam;
    private string textStoreGamesBehindOtherTeam;
    private bool flagHasGamesLeftInSeason;
    private BigInteger storeGamesLeftInSeason;
    private bool flagHasGamesLeftInSeasonLeagueMin;
    private BigInteger storeGamesLeftInSeasonLeagueMin;
    private bool flagHasGamesLeftInSeasonLeagueMax;
    private BigInteger storeGamesLeftInSeasonLeagueMax;
    private bool flagHasError;
    private TypeError storeError;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsStandingsQueryTypeJSON convert_classy = SportsStandingsQueryTypeJSON.from_json(json_value, ignore_extras, true);
        setType(convert_classy);
      }


    private void  fromJSONLeague(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsLeagueCodeJSON convert_classy = SportsLeagueCodeJSON.from_json(json_value, ignore_extras, true);
        setLeague(convert_classy);
      }


    private void  fromJSONDivision(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsLeagueDivisionJSON convert_classy = SportsLeagueDivisionJSON.from_json(json_value, ignore_extras, true);
        setDivision(convert_classy);
      }


    private void  fromJSONTeam(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsTeamNewJSON convert_classy = SportsTeamNewJSON.from_json(json_value, ignore_extras, true);
        setTeam(convert_classy);
      }


    private void  fromJSONTeamOther(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsTeamNewJSON convert_classy = SportsTeamNewJSON.from_json(json_value, ignore_extras, true);
        setTeamOther(convert_classy);
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
                throw new Exception("The value for field Rank of SportsStandingsQueryDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Rank of SportsStandingsQueryDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRank(extracted_integer);
      }


    private void  fromJSONGrouping(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Grouping of SportsStandingsQueryDataJSON is not a string.");
        TypeGrouping the_open_enum = new TypeGrouping();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "onference", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGroupingKnownValues.Grouping_Conference;
                        goto open_enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ivisional", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGroupingKnownValues.Grouping_Divisional;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "eague", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGroupingKnownValues.Grouping_League;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "ildCard", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGroupingKnownValues.Grouping_WildCard;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setGrouping(the_open_enum);
      }


    private void  fromJSONSeason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSeasonResolvedJSON convert_classy = SportsSeasonResolvedJSON.from_json(json_value, ignore_extras, true);
        setSeason(convert_classy);
      }


    private void  fromJSONStandingsIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field StandingsIndex of SportsStandingsQueryDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field StandingsIndex of SportsStandingsQueryDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setStandingsIndex(extracted_integer);
      }


    private void  fromJSONTournament(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsTournamentJSON convert_classy = SportsTournamentJSON.from_json(json_value, ignore_extras, true);
        setTournament(convert_classy);
      }


    private void  fromJSONDivisionTeamIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DivisionTeamIndices of SportsStandingsQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field DivisionTeamIndices of SportsStandingsQueryDataJSON has too few elements.");
        List< TypeDivisionTeamIndicesJSON  > vector_DivisionTeamIndices1 = new List< TypeDivisionTeamIndicesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeDivisionTeamIndicesJSON convert_classy = TypeDivisionTeamIndicesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_DivisionTeamIndices1.Add(convert_classy);
          }
        Debug.Assert(vector_DivisionTeamIndices1.Count >= 1);
        initDivisionTeamIndices();
        for (int num1 = 0; num1 < vector_DivisionTeamIndices1.Count; ++num1)
            appendDivisionTeamIndices(vector_DivisionTeamIndices1[num1]);
        for (int num1 = 0; num1 < vector_DivisionTeamIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGamesBehindOtherTeam(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field GamesBehindOtherTeam of SportsStandingsQueryDataJSON is not a number.");
              }
          }
        setGamesBehindOtherTeamText(the_rational_text);
      }


    private void  fromJSONGamesLeftInSeason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GamesLeftInSeason of SportsStandingsQueryDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GamesLeftInSeason of SportsStandingsQueryDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setGamesLeftInSeason(extracted_integer);
      }


    private void  fromJSONGamesLeftInSeasonLeagueMin(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GamesLeftInSeasonLeagueMin of SportsStandingsQueryDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GamesLeftInSeasonLeagueMin of SportsStandingsQueryDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setGamesLeftInSeasonLeagueMin(extracted_integer);
      }


    private void  fromJSONGamesLeftInSeasonLeagueMax(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GamesLeftInSeasonLeagueMax of SportsStandingsQueryDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GamesLeftInSeasonLeagueMax of SportsStandingsQueryDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setGamesLeftInSeasonLeagueMax(extracted_integer);
      }


    private void  fromJSONError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Error of SportsStandingsQueryDataJSON is not a string.");
        TypeError the_open_enum = new TypeError();
        if ((String.Compare(json_string.getData(), 0, "DataUnavailable", 0, 15, false) == 0) && (json_string.getData().Length == 15))
              {
                the_open_enum.in_known_list = true;
                the_open_enum.list_value = TypeErrorKnownValues.Error_DataUnavailable;
                goto open_enum_is_done;
              }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setError(the_open_enum);
      }


    public SportsStandingsQueryDataJSON()
      {
        flagHasType = false;
        flagHasLeague = false;
        flagHasDivision = false;
        flagHasTeam = false;
        flagHasTeamOther = false;
        flagHasRank = false;
        flagHasGrouping = false;
        flagHasSeason = false;
        flagHasStandingsIndex = false;
        flagHasTournament = false;
        flagHasDivisionTeamIndices = false;
        flagHasGamesBehindOtherTeam = false;
        flagHasGamesLeftInSeason = false;
        flagHasGamesLeftInSeasonLeagueMin = false;
        flagHasGamesLeftInSeasonLeagueMax = false;
        flagHasError = false;
        storeDivisionTeamIndices = new List< TypeDivisionTeamIndicesJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public SportsStandingsQueryTypeJSON   getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public SportsStandingsQueryTypeJSON.TypeValue  getTypeValue()
      {
        return getType().getValue();
      }

    public string  getTypeAsString()
      {
        return getType().getValueAsString();
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

    public bool  hasDivision()
      {
        return flagHasDivision;
      }

    public SportsLeagueDivisionJSON   getDivision()
      {
        Debug.Assert(flagHasDivision);
        return storeDivision;
      }

    public SportsLeagueDivisionJSON.TypeValue  getDivisionValue()
      {
        return getDivision().getValue();
      }

    public string  getDivisionAsString()
      {
        return getDivision().getValueAsString();
      }

    public bool  hasTeam()
      {
        return flagHasTeam;
      }

    public SportsTeamNewJSON   getTeam()
      {
        Debug.Assert(flagHasTeam);
        return storeTeam;
      }

    public bool  hasTeamOther()
      {
        return flagHasTeamOther;
      }

    public SportsTeamNewJSON   getTeamOther()
      {
        Debug.Assert(flagHasTeamOther);
        return storeTeamOther;
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

    public bool  hasGrouping()
      {
        return flagHasGrouping;
      }

    public TypeGrouping  getGrouping()
      {
        Debug.Assert(flagHasGrouping);
        return storeGrouping;
      }

    public string  getGroupingAsString()
      {
        TypeGrouping result = getGrouping();
        if (result.in_known_list)
            return stringFromGrouping(result.list_value);
        else
            return result.string_value;
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

    public bool  hasStandingsIndex()
      {
        return flagHasStandingsIndex;
      }

    public BigInteger  getStandingsIndex()
      {
        Debug.Assert(flagHasStandingsIndex);
        return storeStandingsIndex;
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

    public bool  hasDivisionTeamIndices()
      {
        return flagHasDivisionTeamIndices;
      }

    public int  countOfDivisionTeamIndices()
      {
        Debug.Assert(flagHasDivisionTeamIndices);
        return storeDivisionTeamIndices.Count;
      }

    public TypeDivisionTeamIndicesJSON   elementOfDivisionTeamIndices(int element_num)
      {
        Debug.Assert(flagHasDivisionTeamIndices);
        return storeDivisionTeamIndices[element_num];
      }

    public List< TypeDivisionTeamIndicesJSON  >  getDivisionTeamIndices()
      {
        Debug.Assert(flagHasDivisionTeamIndices);
        return storeDivisionTeamIndices;
      }

    public bool  hasGamesBehindOtherTeam()
      {
        return flagHasGamesBehindOtherTeam;
      }

    public double  getGamesBehindOtherTeam()
      {
        Debug.Assert(flagHasGamesBehindOtherTeam);
        if (textStoreGamesBehindOtherTeam != "")
          {
            return Double.Parse(textStoreGamesBehindOtherTeam);
          }
        return storeGamesBehindOtherTeam;
      }

    public string  getGamesBehindOtherTeamAsText()
      {
        Debug.Assert(flagHasGamesBehindOtherTeam);
        if (textStoreGamesBehindOtherTeam == "")
          {
            return Convert.ToString(storeGamesBehindOtherTeam);
          }
        else
          {
            return (textStoreGamesBehindOtherTeam);
          }
      }

    public bool  hasGamesLeftInSeason()
      {
        return flagHasGamesLeftInSeason;
      }

    public BigInteger  getGamesLeftInSeason()
      {
        Debug.Assert(flagHasGamesLeftInSeason);
        return storeGamesLeftInSeason;
      }

    public bool  hasGamesLeftInSeasonLeagueMin()
      {
        return flagHasGamesLeftInSeasonLeagueMin;
      }

    public BigInteger  getGamesLeftInSeasonLeagueMin()
      {
        Debug.Assert(flagHasGamesLeftInSeasonLeagueMin);
        return storeGamesLeftInSeasonLeagueMin;
      }

    public bool  hasGamesLeftInSeasonLeagueMax()
      {
        return flagHasGamesLeftInSeasonLeagueMax;
      }

    public BigInteger  getGamesLeftInSeasonLeagueMax()
      {
        Debug.Assert(flagHasGamesLeftInSeasonLeagueMax);
        return storeGamesLeftInSeasonLeagueMax;
      }

    public bool  hasError()
      {
        return flagHasError;
      }

    public TypeError  getError()
      {
        Debug.Assert(flagHasError);
        return storeError;
      }

    public string  getErrorAsString()
      {
        TypeError result = getError();
        if (result.in_known_list)
            return stringFromError(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraSportsStandingsQueryDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStandingsQueryDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStandingsQueryDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStandingsQueryDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setType(SportsStandingsQueryTypeJSON  new_value)
      {
        if (flagHasType)
          {
          }
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(SportsStandingsQueryTypeJSON.TypeValue new_value)
      {
        setType(new SportsStandingsQueryTypeJSON(new_value));
      }
    public void setType(string chars)
      {
        SportsStandingsQueryTypeJSON.TypeValueKnownValues known = SportsStandingsQueryTypeJSON.stringToValue(chars);
        SportsStandingsQueryTypeJSON.TypeValue new_value = new SportsStandingsQueryTypeJSON.TypeValue();
        if (known == SportsStandingsQueryTypeJSON.TypeValueKnownValues.Value__none)
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
    public void unsetType()
      {
        if (flagHasType)
          {
          }
        flagHasType = false;
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
    public void setDivision(SportsLeagueDivisionJSON  new_value)
      {
        if (flagHasDivision)
          {
          }
        flagHasDivision = true;
        storeDivision = new_value;
      }
    public void setDivision(SportsLeagueDivisionJSON.TypeValue new_value)
      {
        setDivision(new SportsLeagueDivisionJSON(new_value));
      }
    public void setDivision(string chars)
      {
        SportsLeagueDivisionJSON.TypeValueKnownValues known = SportsLeagueDivisionJSON.stringToValue(chars);
        SportsLeagueDivisionJSON.TypeValue new_value = new SportsLeagueDivisionJSON.TypeValue();
        if (known == SportsLeagueDivisionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setDivision(new_value);
      }
    public void unsetDivision()
      {
        if (flagHasDivision)
          {
          }
        flagHasDivision = false;
      }
    public void setTeam(SportsTeamNewJSON  new_value)
      {
        if (flagHasTeam)
          {
          }
        flagHasTeam = true;
        storeTeam = new_value;
      }
    public void unsetTeam()
      {
        if (flagHasTeam)
          {
          }
        flagHasTeam = false;
      }
    public void setTeamOther(SportsTeamNewJSON  new_value)
      {
        if (flagHasTeamOther)
          {
          }
        flagHasTeamOther = true;
        storeTeamOther = new_value;
      }
    public void unsetTeamOther()
      {
        if (flagHasTeamOther)
          {
          }
        flagHasTeamOther = false;
      }
    public void setRank(BigInteger new_value)
      {
        flagHasRank = true;
        if (new_value < 1)
            throw new Exception("The value for field Rank of SportsStandingsQueryDataJSON is less than the lower bound (1) for that field.");
        storeRank = new_value;
      }
    public void unsetRank()
      {
        flagHasRank = false;
      }
    public void setGrouping(TypeGrouping new_value)
      {
        flagHasGrouping = true;
        storeGrouping = new_value;
      }
    public void setGrouping(string chars)
      {
        TypeGroupingKnownValues known = stringToGrouping(chars);
        TypeGrouping new_value = new TypeGrouping();
        if (known == TypeGroupingKnownValues.Grouping__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setGrouping(new_value);
      }
    public void setGrouping(TypeGroupingKnownValues new_value)
      {
        TypeGrouping new_full_value = new TypeGrouping();
        Debug.Assert(new_value != TypeGroupingKnownValues.Grouping__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setGrouping(new_full_value);
      }
    public void unsetGrouping()
      {
        flagHasGrouping = false;
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
    public void setStandingsIndex(BigInteger new_value)
      {
        flagHasStandingsIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field StandingsIndex of SportsStandingsQueryDataJSON is less than the lower bound (0) for that field.");
        storeStandingsIndex = new_value;
      }
    public void unsetStandingsIndex()
      {
        flagHasStandingsIndex = false;
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
    public void initDivisionTeamIndices()
      {
        if (flagHasDivisionTeamIndices)
          {
            for (int num1 = 0; num1 < storeDivisionTeamIndices.Count; ++num1)
              {
              }
          }
        flagHasDivisionTeamIndices = true;
        storeDivisionTeamIndices.Clear();
      }
    public void appendDivisionTeamIndices(TypeDivisionTeamIndicesJSON  to_append)
      {
        if (!flagHasDivisionTeamIndices)
          {
            flagHasDivisionTeamIndices = true;
            storeDivisionTeamIndices.Clear();
          }
        Debug.Assert(flagHasDivisionTeamIndices);
        storeDivisionTeamIndices.Add(to_append);
      }
    public void unsetDivisionTeamIndices()
      {
        if (flagHasDivisionTeamIndices)
          {
            for (int num2 = 0; num2 < storeDivisionTeamIndices.Count; ++num2)
              {
              }
          }
        flagHasDivisionTeamIndices = false;
        storeDivisionTeamIndices.Clear();
      }
    public void setGamesBehindOtherTeam(double new_value)
      {
        flagHasGamesBehindOtherTeam = true;
        storeGamesBehindOtherTeam = new_value;
        textStoreGamesBehindOtherTeam = "";
      }
    public void setGamesBehindOtherTeamText(string new_value)
      {
        flagHasGamesBehindOtherTeam = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field GamesBehindOtherTeam of SportsStandingsQueryDataJSON is not a valid number.");
        textStoreGamesBehindOtherTeam = new_value;
      }
    public void unsetGamesBehindOtherTeam()
      {
        flagHasGamesBehindOtherTeam = false;
      }
    public void setGamesLeftInSeason(BigInteger new_value)
      {
        flagHasGamesLeftInSeason = true;
        if (new_value < 0)
            throw new Exception("The value for field GamesLeftInSeason of SportsStandingsQueryDataJSON is less than the lower bound (0) for that field.");
        storeGamesLeftInSeason = new_value;
      }
    public void unsetGamesLeftInSeason()
      {
        flagHasGamesLeftInSeason = false;
      }
    public void setGamesLeftInSeasonLeagueMin(BigInteger new_value)
      {
        flagHasGamesLeftInSeasonLeagueMin = true;
        if (new_value < 0)
            throw new Exception("The value for field GamesLeftInSeasonLeagueMin of SportsStandingsQueryDataJSON is less than the lower bound (0) for that field.");
        storeGamesLeftInSeasonLeagueMin = new_value;
      }
    public void unsetGamesLeftInSeasonLeagueMin()
      {
        flagHasGamesLeftInSeasonLeagueMin = false;
      }
    public void setGamesLeftInSeasonLeagueMax(BigInteger new_value)
      {
        flagHasGamesLeftInSeasonLeagueMax = true;
        if (new_value < 0)
            throw new Exception("The value for field GamesLeftInSeasonLeagueMax of SportsStandingsQueryDataJSON is less than the lower bound (0) for that field.");
        storeGamesLeftInSeasonLeagueMax = new_value;
      }
    public void unsetGamesLeftInSeasonLeagueMax()
      {
        flagHasGamesLeftInSeasonLeagueMax = false;
      }
    public void setError(TypeError new_value)
      {
        flagHasError = true;
        storeError = new_value;
      }
    public void setError(string chars)
      {
        TypeErrorKnownValues known = stringToError(chars);
        TypeError new_value = new TypeError();
        if (known == TypeErrorKnownValues.Error__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setError(new_value);
      }
    public void setError(TypeErrorKnownValues new_value)
      {
        TypeError new_full_value = new TypeError();
        Debug.Assert(new_value != TypeErrorKnownValues.Error__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setError(new_full_value);
      }
    public void unsetError()
      {
        flagHasError = false;
      }

    public virtual void extraSportsStandingsQueryDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStandingsQueryDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStandingsQueryDataLookup(key);
        if (old_field == null)
          {
            extraSportsStandingsQueryDataAppendPair(key, new_component);
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
            if (partial_allowed)
                storeType.write_partial_as_json(handler);
            else
                storeType.write_as_json(handler);
          }
        if (flagHasLeague)
          {
            handler.start_pair("League");
            if (partial_allowed)
                storeLeague.write_partial_as_json(handler);
            else
                storeLeague.write_as_json(handler);
          }
        if (flagHasDivision)
          {
            handler.start_pair("Division");
            if (partial_allowed)
                storeDivision.write_partial_as_json(handler);
            else
                storeDivision.write_as_json(handler);
          }
        if (flagHasTeam)
          {
            handler.start_pair("Team");
            if (partial_allowed)
                storeTeam.write_partial_as_json(handler);
            else
                storeTeam.write_as_json(handler);
          }
        if (flagHasTeamOther)
          {
            handler.start_pair("TeamOther");
            if (partial_allowed)
                storeTeamOther.write_partial_as_json(handler);
            else
                storeTeamOther.write_as_json(handler);
          }
        if (flagHasRank)
          {
            handler.start_pair("Rank");
            handler.number_value(storeRank);
          }
        if (flagHasGrouping)
          {
            handler.start_pair("Grouping");
            if (storeGrouping.in_known_list)
              {
                switch (storeGrouping.list_value)
                  {
                    case TypeGroupingKnownValues.Grouping_Divisional:
                        handler.string_value("Divisional");
                        break;
                    case TypeGroupingKnownValues.Grouping_Conference:
                        handler.string_value("Conference");
                        break;
                    case TypeGroupingKnownValues.Grouping_League:
                        handler.string_value("League");
                        break;
                    case TypeGroupingKnownValues.Grouping_WildCard:
                        handler.string_value("WildCard");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeGrouping.string_value);
              }
          }
        if (flagHasSeason)
          {
            handler.start_pair("Season");
            if (partial_allowed)
                storeSeason.write_partial_as_json(handler);
            else
                storeSeason.write_as_json(handler);
          }
        if (flagHasStandingsIndex)
          {
            handler.start_pair("StandingsIndex");
            handler.number_value(storeStandingsIndex);
          }
        if (flagHasTournament)
          {
            handler.start_pair("Tournament");
            if (partial_allowed)
                storeTournament.write_partial_as_json(handler);
            else
                storeTournament.write_as_json(handler);
          }
        if (flagHasDivisionTeamIndices)
          {
            handler.start_pair("DivisionTeamIndices");
            Debug.Assert(storeDivisionTeamIndices.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeDivisionTeamIndices.Count; ++num1)
              {
                if (partial_allowed)
                    storeDivisionTeamIndices[num1].write_partial_as_json(handler);
                else
                    storeDivisionTeamIndices[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasGamesBehindOtherTeam)
          {
            handler.start_pair("GamesBehindOtherTeam");
            if (textStoreGamesBehindOtherTeam != "")
                handler.number_value(textStoreGamesBehindOtherTeam);
            else if (((double)(long)storeGamesBehindOtherTeam) == storeGamesBehindOtherTeam)
                handler.number_value((long)storeGamesBehindOtherTeam);
            else
                handler.number_value(storeGamesBehindOtherTeam);
          }
        if (flagHasGamesLeftInSeason)
          {
            handler.start_pair("GamesLeftInSeason");
            handler.number_value(storeGamesLeftInSeason);
          }
        if (flagHasGamesLeftInSeasonLeagueMin)
          {
            handler.start_pair("GamesLeftInSeasonLeagueMin");
            handler.number_value(storeGamesLeftInSeasonLeagueMin);
          }
        if (flagHasGamesLeftInSeasonLeagueMax)
          {
            handler.start_pair("GamesLeftInSeasonLeagueMax");
            handler.number_value(storeGamesLeftInSeasonLeagueMax);
          }
        if (flagHasError)
          {
            handler.start_pair("Error");
            if (storeError.in_known_list)
              {
                switch (storeError.list_value)
                  {
                    case TypeErrorKnownValues.Error_DataUnavailable:
                        handler.string_value("DataUnavailable");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeError.string_value);
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
        if (!(hasType()))
          {
            return "When parsing the object for %what%, the \"Type\" field was missing.";
          }
        return null;
      }

    public static SportsStandingsQueryDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsQueryData", ignore_extras);
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
    public static SportsStandingsQueryDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsQueryDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsQueryData", ignore_extras);
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
    public static SportsStandingsQueryDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsQueryDataJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsQueryData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsQueryDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStandingsQueryDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsQueryData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsStandingsQueryTypeJSON.HoldingGenerator fieldGeneratorType;
        private SportsLeagueCodeJSON.HoldingGenerator fieldGeneratorLeague;
        private SportsLeagueDivisionJSON.HoldingGenerator fieldGeneratorDivision;
        private SportsTeamNewJSON.HoldingGenerator fieldGeneratorTeam;
        private SportsTeamNewJSON.HoldingGenerator fieldGeneratorTeamOther;
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
    private abstract class FieldGeneratorGrouping : JSONStringGenerator
          {
            protected FieldGeneratorGrouping(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorGrouping()
              {
              }
            protected override void handle_result(string result)
              {
                TypeGroupingKnownValues known = stringToGrouping(result);
                TypeGrouping new_value = new TypeGrouping();
                if (known == TypeGroupingKnownValues.Grouping__none)
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
            protected abstract void handle_result(TypeGrouping result);
          };
    private class FieldHoldingGeneratorGrouping : FieldGeneratorGrouping
  {
    protected override void handle_result(TypeGrouping result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorGrouping(String what)
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
    public TypeGrouping value;
  };
    private class FieldHoldingArrayGeneratorGrouping : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorGrouping
      {
        private FieldHoldingArrayGeneratorGrouping top;

        protected override void handle_result(TypeGrouping result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorGrouping init_top)
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
    protected virtual void handle_result(List<TypeGrouping> result)
      {
      }

    public FieldHoldingArrayGeneratorGrouping(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeGrouping>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorGrouping()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeGrouping>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeGrouping> value;
  };
        private FieldHoldingGeneratorGrouping fieldGeneratorGrouping;
        private SportsSeasonResolvedJSON.HoldingGenerator fieldGeneratorSeason;
    private class FieldHoldingGeneratorStandingsIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorStandingsIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorStandingsIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorStandingsIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorStandingsIndex fieldGeneratorStandingsIndex;
        private SportsTournamentJSON.HoldingGenerator fieldGeneratorTournament;
        private TypeDivisionTeamIndicesJSON.HoldingArrayGenerator fieldGeneratorDivisionTeamIndices;
        private JSONHoldingNumberTextGenerator fieldGeneratorGamesBehindOtherTeam;
    private class FieldHoldingGeneratorGamesLeftInSeason : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGamesLeftInSeason(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGamesLeftInSeason : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGamesLeftInSeason(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorGamesLeftInSeason fieldGeneratorGamesLeftInSeason;
    private class FieldHoldingGeneratorGamesLeftInSeasonLeagueMin : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGamesLeftInSeasonLeagueMin(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGamesLeftInSeasonLeagueMin : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGamesLeftInSeasonLeagueMin(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorGamesLeftInSeasonLeagueMin fieldGeneratorGamesLeftInSeasonLeagueMin;
    private class FieldHoldingGeneratorGamesLeftInSeasonLeagueMax : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGamesLeftInSeasonLeagueMax(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGamesLeftInSeasonLeagueMax : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGamesLeftInSeasonLeagueMax(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorGamesLeftInSeasonLeagueMax fieldGeneratorGamesLeftInSeasonLeagueMax;
    private abstract class FieldGeneratorError : JSONStringGenerator
          {
            protected FieldGeneratorError(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorError()
              {
              }
            protected override void handle_result(string result)
              {
                TypeErrorKnownValues known = stringToError(result);
                TypeError new_value = new TypeError();
                if (known == TypeErrorKnownValues.Error__none)
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
            protected abstract void handle_result(TypeError result);
          };
    private class FieldHoldingGeneratorError : FieldGeneratorError
  {
    protected override void handle_result(TypeError result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorError(String what)
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
    public TypeError value;
  };
    private class FieldHoldingArrayGeneratorError : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorError
      {
        private FieldHoldingArrayGeneratorError top;

        protected override void handle_result(TypeError result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorError init_top)
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
    protected virtual void handle_result(List<TypeError> result)
      {
      }

    public FieldHoldingArrayGeneratorError(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeError>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorError()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeError>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeError> value;
  };
        private FieldHoldingGeneratorError fieldGeneratorError;
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
            SportsStandingsQueryDataJSON result = new SportsStandingsQueryDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStandingsQueryDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsStandingsQueryDataJSON result)
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
            if (fieldGeneratorLeague.have_value)
              {
                result.setLeague(fieldGeneratorLeague.value);
                fieldGeneratorLeague.have_value = false;
              }
            if (fieldGeneratorDivision.have_value)
              {
                result.setDivision(fieldGeneratorDivision.value);
                fieldGeneratorDivision.have_value = false;
              }
            if (fieldGeneratorTeam.have_value)
              {
                result.setTeam(fieldGeneratorTeam.value);
                fieldGeneratorTeam.have_value = false;
              }
            if (fieldGeneratorTeamOther.have_value)
              {
                result.setTeamOther(fieldGeneratorTeamOther.value);
                fieldGeneratorTeamOther.have_value = false;
              }
            if (fieldGeneratorRank.have_value)
              {
                result.setRank(fieldGeneratorRank.value);
                fieldGeneratorRank.have_value = false;
              }
            if (fieldGeneratorGrouping.have_value)
              {
                result.setGrouping(fieldGeneratorGrouping.value);
                fieldGeneratorGrouping.have_value = false;
              }
            if (fieldGeneratorSeason.have_value)
              {
                result.setSeason(fieldGeneratorSeason.value);
                fieldGeneratorSeason.have_value = false;
              }
            if (fieldGeneratorStandingsIndex.have_value)
              {
                result.setStandingsIndex(fieldGeneratorStandingsIndex.value);
                fieldGeneratorStandingsIndex.have_value = false;
              }
            if (fieldGeneratorTournament.have_value)
              {
                result.setTournament(fieldGeneratorTournament.value);
                fieldGeneratorTournament.have_value = false;
              }
            if (fieldGeneratorDivisionTeamIndices.have_value)
              {
                result.initDivisionTeamIndices();
                int count = fieldGeneratorDivisionTeamIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDivisionTeamIndices(fieldGeneratorDivisionTeamIndices.value[num]);
                  }
                fieldGeneratorDivisionTeamIndices.value.Clear();
                fieldGeneratorDivisionTeamIndices.have_value = false;
              }
            if (fieldGeneratorGamesBehindOtherTeam.have_value)
              {
                result.setGamesBehindOtherTeamText(fieldGeneratorGamesBehindOtherTeam.value);
                fieldGeneratorGamesBehindOtherTeam.have_value = false;
              }
            if (fieldGeneratorGamesLeftInSeason.have_value)
              {
                result.setGamesLeftInSeason(fieldGeneratorGamesLeftInSeason.value);
                fieldGeneratorGamesLeftInSeason.have_value = false;
              }
            if (fieldGeneratorGamesLeftInSeasonLeagueMin.have_value)
              {
                result.setGamesLeftInSeasonLeagueMin(fieldGeneratorGamesLeftInSeasonLeagueMin.value);
                fieldGeneratorGamesLeftInSeasonLeagueMin.have_value = false;
              }
            if (fieldGeneratorGamesLeftInSeasonLeagueMax.have_value)
              {
                result.setGamesLeftInSeasonLeagueMax(fieldGeneratorGamesLeftInSeasonLeagueMax.value);
                fieldGeneratorGamesLeftInSeasonLeagueMax.have_value = false;
              }
            if (fieldGeneratorError.have_value)
              {
                result.setError(fieldGeneratorError.value);
                fieldGeneratorError.have_value = false;
              }
          }
        protected abstract void handle_result(SportsStandingsQueryDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "ivision", 0, 7, false) == 0)
                      {
                        if (field_name.Length == 8)
                          {
                            return fieldGeneratorDivision;
                          }
                        switch (field_name[8])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 9, "eamIndices", 0, 10, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorDivisionTeamIndices;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorError;
                    break;
                case 'G':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "mes", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'B':
                                        if ((String.Compare(field_name, 6, "ehindOtherTeam", 0, 14, false) == 0) && (field_name.Length == 20))
                                            return fieldGeneratorGamesBehindOtherTeam;
                                        break;
                                    case 'L':
                                        if (String.Compare(field_name, 6, "eftInSeason", 0, 11, false) == 0)
                                          {
                                            if (field_name.Length == 17)
                                              {
                                                return fieldGeneratorGamesLeftInSeason;
                                              }
                                            switch (field_name[17])
                                              {
                                                case 'L':
                                                    if (String.Compare(field_name, 18, "eagueM", 0, 6, false) == 0)
                                                      {
                                                        switch (field_name[24])
                                                          {
                                                            case 'a':
                                                                if ((String.Compare(field_name, 25, "x", 0, 1, false) == 0) && (field_name.Length == 26))
                                                                    return fieldGeneratorGamesLeftInSeasonLeagueMax;
                                                                break;
                                                            case 'i':
                                                                if ((String.Compare(field_name, 25, "n", 0, 1, false) == 0) && (field_name.Length == 26))
                                                                    return fieldGeneratorGamesLeftInSeasonLeagueMin;
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
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "ouping", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorGrouping;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "eague", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorLeague;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ank", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorRank;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ason", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorSeason;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "andingsIndex", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorStandingsIndex;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'e':
                            if (String.Compare(field_name, 2, "am", 0, 2, false) == 0)
                              {
                                if (field_name.Length == 4)
                                  {
                                    return fieldGeneratorTeam;
                                  }
                                switch (field_name[4])
                                  {
                                    case 'O':
                                        if ((String.Compare(field_name, 5, "ther", 0, 4, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorTeamOther;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "urnament", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorTournament;
                            break;
                        case 'y':
                            if ((String.Compare(field_name, 2, "pe", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorType;
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
            fieldGeneratorType = new SportsStandingsQueryTypeJSON.HoldingGenerator("field \"Type\" of the SportsStandingsQueryData class", ignore_extras);
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsStandingsQueryData class", ignore_extras);
            fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the SportsStandingsQueryData class", ignore_extras);
            fieldGeneratorTeam = new SportsTeamNewJSON.HoldingGenerator("field \"Team\" of the SportsStandingsQueryData class", ignore_extras);
            fieldGeneratorTeamOther = new SportsTeamNewJSON.HoldingGenerator("field \"TeamOther\" of the SportsStandingsQueryData class", ignore_extras);
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsStandingsQueryData class");
            fieldGeneratorGrouping = new FieldHoldingGeneratorGrouping("field \"Grouping\" of the SportsStandingsQueryData class");
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsStandingsQueryData class", ignore_extras);
            fieldGeneratorStandingsIndex = new FieldHoldingGeneratorStandingsIndex("field \"StandingsIndex\" of the SportsStandingsQueryData class");
            fieldGeneratorTournament = new SportsTournamentJSON.HoldingGenerator("field \"Tournament\" of the SportsStandingsQueryData class", ignore_extras);
            fieldGeneratorDivisionTeamIndices = new TypeDivisionTeamIndicesJSON.HoldingArrayGenerator("field \"DivisionTeamIndices\" of the SportsStandingsQueryData class", ignore_extras);
            fieldGeneratorGamesBehindOtherTeam = new JSONHoldingNumberTextGenerator("field \"GamesBehindOtherTeam\" of the SportsStandingsQueryData class");
            fieldGeneratorGamesLeftInSeason = new FieldHoldingGeneratorGamesLeftInSeason("field \"GamesLeftInSeason\" of the SportsStandingsQueryData class");
            fieldGeneratorGamesLeftInSeasonLeagueMin = new FieldHoldingGeneratorGamesLeftInSeasonLeagueMin("field \"GamesLeftInSeasonLeagueMin\" of the SportsStandingsQueryData class");
            fieldGeneratorGamesLeftInSeasonLeagueMax = new FieldHoldingGeneratorGamesLeftInSeasonLeagueMax("field \"GamesLeftInSeasonLeagueMax\" of the SportsStandingsQueryData class");
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsStandingsQueryData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStandingsQueryData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorType = new SportsStandingsQueryTypeJSON.HoldingGenerator("field \"Type\" of the SportsStandingsQueryData class", false);
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsStandingsQueryData class", false);
            fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the SportsStandingsQueryData class", false);
            fieldGeneratorTeam = new SportsTeamNewJSON.HoldingGenerator("field \"Team\" of the SportsStandingsQueryData class", false);
            fieldGeneratorTeamOther = new SportsTeamNewJSON.HoldingGenerator("field \"TeamOther\" of the SportsStandingsQueryData class", false);
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsStandingsQueryData class");
            fieldGeneratorGrouping = new FieldHoldingGeneratorGrouping("field \"Grouping\" of the SportsStandingsQueryData class");
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsStandingsQueryData class", false);
            fieldGeneratorStandingsIndex = new FieldHoldingGeneratorStandingsIndex("field \"StandingsIndex\" of the SportsStandingsQueryData class");
            fieldGeneratorTournament = new SportsTournamentJSON.HoldingGenerator("field \"Tournament\" of the SportsStandingsQueryData class", false);
            fieldGeneratorDivisionTeamIndices = new TypeDivisionTeamIndicesJSON.HoldingArrayGenerator("field \"DivisionTeamIndices\" of the SportsStandingsQueryData class", false);
            fieldGeneratorGamesBehindOtherTeam = new JSONHoldingNumberTextGenerator("field \"GamesBehindOtherTeam\" of the SportsStandingsQueryData class");
            fieldGeneratorGamesLeftInSeason = new FieldHoldingGeneratorGamesLeftInSeason("field \"GamesLeftInSeason\" of the SportsStandingsQueryData class");
            fieldGeneratorGamesLeftInSeasonLeagueMin = new FieldHoldingGeneratorGamesLeftInSeasonLeagueMin("field \"GamesLeftInSeasonLeagueMin\" of the SportsStandingsQueryData class");
            fieldGeneratorGamesLeftInSeasonLeagueMax = new FieldHoldingGeneratorGamesLeftInSeasonLeagueMax("field \"GamesLeftInSeasonLeagueMax\" of the SportsStandingsQueryData class");
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsStandingsQueryData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStandingsQueryData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorType.reset();
            fieldGeneratorLeague.reset();
            fieldGeneratorDivision.reset();
            fieldGeneratorTeam.reset();
            fieldGeneratorTeamOther.reset();
            fieldGeneratorRank.reset();
            fieldGeneratorGrouping.reset();
            fieldGeneratorSeason.reset();
            fieldGeneratorStandingsIndex.reset();
            fieldGeneratorTournament.reset();
            fieldGeneratorDivisionTeamIndices.reset();
            fieldGeneratorGamesBehindOtherTeam.reset();
            fieldGeneratorGamesLeftInSeason.reset();
            fieldGeneratorGamesLeftInSeasonLeagueMin.reset();
            fieldGeneratorGamesLeftInSeasonLeagueMax.reset();
            fieldGeneratorError.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLeague.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDivision.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTeam.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTeamOther.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeason.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTournament.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDivisionTeamIndices.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLeague.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDivision.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTeam.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTeamOther.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeason.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTournament.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDivisionTeamIndices.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStandingsQueryDataJSON  result)
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
        public SportsStandingsQueryDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsQueryDataJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsQueryDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsQueryDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsQueryDataJSON>();
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
    public List<SportsStandingsQueryDataJSON> value;
  };
  };
