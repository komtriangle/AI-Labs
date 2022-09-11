/* file "SportsLeagueLeadersJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsLeagueLeadersJSON : JSONBase
  {
    public enum TypeTeamsOrPlayersKnownValues
      {
        TeamsOrPlayers_Teams,
        TeamsOrPlayers_Players,
        TeamsOrPlayers__none
      };
    public struct TypeTeamsOrPlayers
      {
        public bool in_known_list;
        public string string_value;
        public TypeTeamsOrPlayersKnownValues list_value;
      };

    public static TypeTeamsOrPlayersKnownValues  stringToTeamsOrPlayers(string chars)
      {
        switch (chars[0])
          {
            case 'P':
                if ((String.Compare(chars, 1, "layers", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeTeamsOrPlayersKnownValues.TeamsOrPlayers_Players;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "eams", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeTeamsOrPlayersKnownValues.TeamsOrPlayers_Teams;
                break;
            default:
                break;
          }
        return TypeTeamsOrPlayersKnownValues.TeamsOrPlayers__none;
      }

    public static string  stringFromTeamsOrPlayers(TypeTeamsOrPlayersKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeTeamsOrPlayersKnownValues.TeamsOrPlayers_Teams:
                return "Teams";
            case TypeTeamsOrPlayersKnownValues.TeamsOrPlayers_Players:
                return "Players";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypeLeadersJSON : JSONBase
      {
        private bool flagHasTeamOrPlayer;
        private SportsTeamOrPlayerJSON  storeTeamOrPlayer;
        private bool flagHasRank;
        private BigInteger storeRank;
        private bool flagHasValue;
        private string storeValue;
        private bool flagHasValueNumeric;
        private double storeValueNumeric;
        private string textStoreValueNumeric;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONTeamOrPlayer(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsTeamOrPlayerJSON convert_classy = SportsTeamOrPlayerJSON.from_json(json_value, ignore_extras, true);
            setTeamOrPlayer(convert_classy);
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
                    throw new Exception("The value for field Rank of TypeLeadersJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Rank of TypeLeadersJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setRank(extracted_integer);
          }


        private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field Value of TypeLeadersJSON is not a string.");
            setValue(json_string.getData());
          }


        private void  fromJSONValueNumeric(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field ValueNumeric of TypeLeadersJSON is not a number.");
                  }
              }
            setValueNumericText(the_rational_text);
          }


        public TypeLeadersJSON()
          {
            flagHasTeamOrPlayer = false;
            flagHasRank = false;
            flagHasValue = false;
            flagHasValueNumeric = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasTeamOrPlayer()
          {
            return flagHasTeamOrPlayer;
          }

        public SportsTeamOrPlayerJSON   getTeamOrPlayer()
          {
            Debug.Assert(flagHasTeamOrPlayer);
            return storeTeamOrPlayer;
          }

        public SportsTeamOrPlayerJSON.TypeValue  getTeamOrPlayerValue()
          {
            return getTeamOrPlayer().getValue();
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

        public bool  hasValue()
          {
            return flagHasValue;
          }

        public string  getValue()
          {
            Debug.Assert(flagHasValue);
            return storeValue;
          }

        public bool  hasValueNumeric()
          {
            return flagHasValueNumeric;
          }

        public double  getValueNumeric()
          {
            Debug.Assert(flagHasValueNumeric);
            if (textStoreValueNumeric != "")
              {
                return Double.Parse(textStoreValueNumeric);
              }
            return storeValueNumeric;
          }

        public string  getValueNumericAsText()
          {
            Debug.Assert(flagHasValueNumeric);
            if (textStoreValueNumeric == "")
              {
                return Convert.ToString(storeValueNumeric);
              }
            else
              {
                return (textStoreValueNumeric);
              }
          }


        public virtual int extraTypeLeadersComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeLeadersComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeLeadersComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeLeadersLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setTeamOrPlayer(SportsTeamOrPlayerJSON  new_value)
          {
            if (flagHasTeamOrPlayer)
              {
              }
            flagHasTeamOrPlayer = true;
            storeTeamOrPlayer = new_value;
          }
        public void setTeamOrPlayer(SportsTeamOrPlayerJSON.TypeValue new_value)
          {
            setTeamOrPlayer(new SportsTeamOrPlayerJSON(new_value));
          }
        public void unsetTeamOrPlayer()
          {
            if (flagHasTeamOrPlayer)
              {
              }
            flagHasTeamOrPlayer = false;
          }
        public void setRank(BigInteger new_value)
          {
            flagHasRank = true;
            if (new_value < 1)
                throw new Exception("The value for field Rank of TypeLeadersJSON is less than the lower bound (1) for that field.");
            storeRank = new_value;
          }
        public void unsetRank()
          {
            flagHasRank = false;
          }
        public void setValue(string new_value)
          {
            flagHasValue = true;
            storeValue = new_value;
          }
        public void unsetValue()
          {
            flagHasValue = false;
          }
        public void setValueNumeric(double new_value)
          {
            flagHasValueNumeric = true;
            storeValueNumeric = new_value;
            textStoreValueNumeric = "";
          }
        public void setValueNumericText(string new_value)
          {
            flagHasValueNumeric = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field ValueNumeric of TypeLeadersJSON is not a valid number.");
            textStoreValueNumeric = new_value;
          }
        public void unsetValueNumeric()
          {
            flagHasValueNumeric = false;
          }

        public virtual void extraTypeLeadersAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeLeadersSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeLeadersLookup(key);
            if (old_field == null)
              {
                extraTypeLeadersAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasTeamOrPlayer);
            if (flagHasTeamOrPlayer)
              {
                handler.start_pair("TeamOrPlayer");
                if (partial_allowed)
                    storeTeamOrPlayer.write_partial_as_json(handler);
                else
                    storeTeamOrPlayer.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasRank);
            if (flagHasRank)
              {
                handler.start_pair("Rank");
                handler.number_value(storeRank);
              }
            Debug.Assert(partial_allowed || flagHasValue);
            if (flagHasValue)
              {
                handler.start_pair("Value");
                handler.string_value(storeValue);
              }
            if (flagHasValueNumeric)
              {
                handler.start_pair("ValueNumeric");
                if (textStoreValueNumeric != "")
                    handler.number_value(textStoreValueNumeric);
                else if (((double)(long)storeValueNumeric) == storeValueNumeric)
                    handler.number_value((long)storeValueNumeric);
                else
                    handler.number_value(storeValueNumeric);
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
            if (!(hasTeamOrPlayer()))
              {
                return "When parsing the object for %what%, the \"TeamOrPlayer\" field was missing.";
              }
            if (!(hasRank()))
              {
                return "When parsing the object for %what%, the \"Rank\" field was missing.";
              }
            if (!(hasValue()))
              {
                return "When parsing the object for %what%, the \"Value\" field was missing.";
              }
            return null;
          }

        public static TypeLeadersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLeadersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLeaders", ignore_extras);
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
        public static TypeLeadersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLeadersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLeadersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLeaders", ignore_extras);
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
        public static TypeLeadersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLeadersJSON from_text(string text, bool ignore_extras)
          {
            TypeLeadersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLeaders", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeLeadersJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeLeadersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeLeadersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLeaders", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private SportsTeamOrPlayerJSON.HoldingGenerator fieldGeneratorTeamOrPlayer;
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
            private JSONHoldingStringGenerator fieldGeneratorValue;
            private JSONHoldingNumberTextGenerator fieldGeneratorValueNumeric;
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
                TypeLeadersJSON result = new TypeLeadersJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeLeadersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeLeadersJSON result)
              {
                if (fieldGeneratorTeamOrPlayer.have_value)
                  {
                    result.setTeamOrPlayer(fieldGeneratorTeamOrPlayer.value);
                    fieldGeneratorTeamOrPlayer.have_value = false;
                  }
                else if ((!(result.hasTeamOrPlayer())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"TeamOrPlayer\" field was missing.");
                  }
                if (fieldGeneratorRank.have_value)
                  {
                    result.setRank(fieldGeneratorRank.value);
                    fieldGeneratorRank.have_value = false;
                  }
                else if ((!(result.hasRank())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Rank\" field was missing.");
                  }
                if (fieldGeneratorValue.have_value)
                  {
                    result.setValue(fieldGeneratorValue.value);
                    fieldGeneratorValue.have_value = false;
                  }
                else if ((!(result.hasValue())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Value\" field was missing.");
                  }
                if (fieldGeneratorValueNumeric.have_value)
                  {
                    result.setValueNumericText(fieldGeneratorValueNumeric.value);
                    fieldGeneratorValueNumeric.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeLeadersJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'R':
                        if ((String.Compare(field_name, 1, "ank", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorRank;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "eamOrPlayer", 0, 11, false) == 0) && (field_name.Length == 12))
                            return fieldGeneratorTeamOrPlayer;
                        break;
                    case 'V':
                        if (String.Compare(field_name, 1, "alue", 0, 4, false) == 0)
                          {
                            if (field_name.Length == 5)
                              {
                                return fieldGeneratorValue;
                              }
                            switch (field_name[5])
                              {
                                case 'N':
                                    if ((String.Compare(field_name, 6, "umeric", 0, 6, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorValueNumeric;
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
                fieldGeneratorTeamOrPlayer = new SportsTeamOrPlayerJSON.HoldingGenerator("field \"TeamOrPlayer\" of the TypeLeaders class", ignore_extras);
                fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the TypeLeaders class");
                fieldGeneratorValue = new JSONHoldingStringGenerator("field \"Value\" of the TypeLeaders class");
                fieldGeneratorValueNumeric = new JSONHoldingNumberTextGenerator("field \"ValueNumeric\" of the TypeLeaders class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeLeaders class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorTeamOrPlayer = new SportsTeamOrPlayerJSON.HoldingGenerator("field \"TeamOrPlayer\" of the TypeLeaders class", false);
                fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the TypeLeaders class");
                fieldGeneratorValue = new JSONHoldingStringGenerator("field \"Value\" of the TypeLeaders class");
                fieldGeneratorValueNumeric = new JSONHoldingNumberTextGenerator("field \"ValueNumeric\" of the TypeLeaders class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeLeaders class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorTeamOrPlayer.reset();
                fieldGeneratorRank.reset();
                fieldGeneratorValue.reset();
                fieldGeneratorValueNumeric.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorTeamOrPlayer.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorTeamOrPlayer.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeLeadersJSON  result)
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
            public TypeLeadersJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeLeadersJSON  result)
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
        protected virtual void handle_result(List<TypeLeadersJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeLeadersJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeLeadersJSON>();
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
        public List<TypeLeadersJSON> value;
      };
      };
    private bool flagHasLeague;
    private SportsLeagueCodeJSON  storeLeague;
    private bool flagHasDivision;
    private SportsLeagueDivisionJSON  storeDivision;
    private bool flagHasStatistic;
    private SportsStatsTypeJSON  storeStatistic;
    private bool flagHasSeason;
    private SportsSeasonResolvedJSON  storeSeason;
    private bool flagHasTeamsOrPlayers;
    private TypeTeamsOrPlayers storeTeamsOrPlayers;
    private bool flagHasLeaders;
    private List< TypeLeadersJSON  > storeLeaders;
    private bool flagHasSportImage;
    private SportsSportImageJSON  storeSportImage;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


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


    private void  fromJSONStatistic(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsStatsTypeJSON convert_classy = SportsStatsTypeJSON.from_json(json_value, ignore_extras, true);
        setStatistic(convert_classy);
      }


    private void  fromJSONSeason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSeasonResolvedJSON convert_classy = SportsSeasonResolvedJSON.from_json(json_value, ignore_extras, true);
        setSeason(convert_classy);
      }


    private void  fromJSONTeamsOrPlayers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TeamsOrPlayers of SportsLeagueLeadersJSON is not a string.");
        TypeTeamsOrPlayers the_open_enum = new TypeTeamsOrPlayers();
        switch (json_string.getData()[0])
          {
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "layers", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTeamsOrPlayersKnownValues.TeamsOrPlayers_Players;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "eams", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeTeamsOrPlayersKnownValues.TeamsOrPlayers_Teams;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setTeamsOrPlayers(the_open_enum);
      }


    private void  fromJSONLeaders(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Leaders of SportsLeagueLeadersJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeLeadersJSON  > vector_Leaders1 = new List< TypeLeadersJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeLeadersJSON convert_classy = TypeLeadersJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Leaders1.Add(convert_classy);
          }
        initLeaders();
        for (int num1 = 0; num1 < vector_Leaders1.Count; ++num1)
            appendLeaders(vector_Leaders1[num1]);
        for (int num1 = 0; num1 < vector_Leaders1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSportImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSportImageJSON convert_classy = SportsSportImageJSON.from_json(json_value, ignore_extras, true);
        setSportImage(convert_classy);
      }


    public SportsLeagueLeadersJSON()
      {
        flagHasLeague = false;
        flagHasDivision = false;
        flagHasStatistic = false;
        flagHasSeason = false;
        flagHasTeamsOrPlayers = false;
        flagHasLeaders = false;
        flagHasSportImage = false;
        storeLeaders = new List< TypeLeadersJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public bool  hasStatistic()
      {
        return flagHasStatistic;
      }

    public SportsStatsTypeJSON   getStatistic()
      {
        Debug.Assert(flagHasStatistic);
        return storeStatistic;
      }

    public SportsStatsTypeJSON.TypeValue  getStatisticValue()
      {
        return getStatistic().getValue();
      }

    public string  getStatisticAsString()
      {
        return getStatistic().getValueAsString();
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

    public bool  hasTeamsOrPlayers()
      {
        return flagHasTeamsOrPlayers;
      }

    public TypeTeamsOrPlayers  getTeamsOrPlayers()
      {
        Debug.Assert(flagHasTeamsOrPlayers);
        return storeTeamsOrPlayers;
      }

    public string  getTeamsOrPlayersAsString()
      {
        TypeTeamsOrPlayers result = getTeamsOrPlayers();
        if (result.in_known_list)
            return stringFromTeamsOrPlayers(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasLeaders()
      {
        return flagHasLeaders;
      }

    public int  countOfLeaders()
      {
        Debug.Assert(flagHasLeaders);
        return storeLeaders.Count;
      }

    public TypeLeadersJSON   elementOfLeaders(int element_num)
      {
        Debug.Assert(flagHasLeaders);
        return storeLeaders[element_num];
      }

    public List< TypeLeadersJSON  >  getLeaders()
      {
        Debug.Assert(flagHasLeaders);
        return storeLeaders;
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


    public virtual int extraSportsLeagueLeadersComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsLeagueLeadersComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsLeagueLeadersComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsLeagueLeadersLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setStatistic(SportsStatsTypeJSON  new_value)
      {
        if (flagHasStatistic)
          {
          }
        flagHasStatistic = true;
        storeStatistic = new_value;
      }
    public void setStatistic(SportsStatsTypeJSON.TypeValue new_value)
      {
        setStatistic(new SportsStatsTypeJSON(new_value));
      }
    public void setStatistic(string chars)
      {
        SportsStatsTypeJSON.TypeValueKnownValues known = SportsStatsTypeJSON.stringToValue(chars);
        SportsStatsTypeJSON.TypeValue new_value = new SportsStatsTypeJSON.TypeValue();
        if (known == SportsStatsTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setStatistic(new_value);
      }
    public void unsetStatistic()
      {
        if (flagHasStatistic)
          {
          }
        flagHasStatistic = false;
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
    public void setTeamsOrPlayers(TypeTeamsOrPlayers new_value)
      {
        flagHasTeamsOrPlayers = true;
        storeTeamsOrPlayers = new_value;
      }
    public void setTeamsOrPlayers(string chars)
      {
        TypeTeamsOrPlayersKnownValues known = stringToTeamsOrPlayers(chars);
        TypeTeamsOrPlayers new_value = new TypeTeamsOrPlayers();
        if (known == TypeTeamsOrPlayersKnownValues.TeamsOrPlayers__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setTeamsOrPlayers(new_value);
      }
    public void setTeamsOrPlayers(TypeTeamsOrPlayersKnownValues new_value)
      {
        TypeTeamsOrPlayers new_full_value = new TypeTeamsOrPlayers();
        Debug.Assert(new_value != TypeTeamsOrPlayersKnownValues.TeamsOrPlayers__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setTeamsOrPlayers(new_full_value);
      }
    public void unsetTeamsOrPlayers()
      {
        flagHasTeamsOrPlayers = false;
      }
    public void initLeaders()
      {
        if (flagHasLeaders)
          {
            for (int num1 = 0; num1 < storeLeaders.Count; ++num1)
              {
              }
          }
        flagHasLeaders = true;
        storeLeaders.Clear();
      }
    public void appendLeaders(TypeLeadersJSON  to_append)
      {
        if (!flagHasLeaders)
          {
            flagHasLeaders = true;
            storeLeaders.Clear();
          }
        Debug.Assert(flagHasLeaders);
        storeLeaders.Add(to_append);
      }
    public void unsetLeaders()
      {
        if (flagHasLeaders)
          {
            for (int num2 = 0; num2 < storeLeaders.Count; ++num2)
              {
              }
          }
        flagHasLeaders = false;
        storeLeaders.Clear();
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

    public virtual void extraSportsLeagueLeadersAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsLeagueLeadersSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsLeagueLeadersLookup(key);
        if (old_field == null)
          {
            extraSportsLeagueLeadersAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasLeague);
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
        Debug.Assert(partial_allowed || flagHasStatistic);
        if (flagHasStatistic)
          {
            handler.start_pair("Statistic");
            if (partial_allowed)
                storeStatistic.write_partial_as_json(handler);
            else
                storeStatistic.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasSeason);
        if (flagHasSeason)
          {
            handler.start_pair("Season");
            if (partial_allowed)
                storeSeason.write_partial_as_json(handler);
            else
                storeSeason.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasTeamsOrPlayers);
        if (flagHasTeamsOrPlayers)
          {
            handler.start_pair("TeamsOrPlayers");
            if (storeTeamsOrPlayers.in_known_list)
              {
                switch (storeTeamsOrPlayers.list_value)
                  {
                    case TypeTeamsOrPlayersKnownValues.TeamsOrPlayers_Teams:
                        handler.string_value("Teams");
                        break;
                    case TypeTeamsOrPlayersKnownValues.TeamsOrPlayers_Players:
                        handler.string_value("Players");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeTeamsOrPlayers.string_value);
              }
          }
        if (flagHasLeaders)
          {
            handler.start_pair("Leaders");
            handler.start_array();
            for (int num1 = 0; num1 < storeLeaders.Count; ++num1)
              {
                if (partial_allowed)
                    storeLeaders[num1].write_partial_as_json(handler);
                else
                    storeLeaders[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSportImage)
          {
            handler.start_pair("SportImage");
            if (partial_allowed)
                storeSportImage.write_partial_as_json(handler);
            else
                storeSportImage.write_as_json(handler);
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
        if (!(hasLeague()))
          {
            return "When parsing the object for %what%, the \"League\" field was missing.";
          }
        if (!(hasStatistic()))
          {
            return "When parsing the object for %what%, the \"Statistic\" field was missing.";
          }
        if (!(hasSeason()))
          {
            return "When parsing the object for %what%, the \"Season\" field was missing.";
          }
        if (!(hasTeamsOrPlayers()))
          {
            return "When parsing the object for %what%, the \"TeamsOrPlayers\" field was missing.";
          }
        return null;
      }

    public static SportsLeagueLeadersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueLeadersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeaders", ignore_extras);
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
    public static SportsLeagueLeadersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueLeadersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueLeadersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeaders", ignore_extras);
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
    public static SportsLeagueLeadersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueLeadersJSON from_text(string text, bool ignore_extras)
      {
        SportsLeagueLeadersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeaders", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsLeagueLeadersJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsLeagueLeadersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsLeagueLeadersJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeaders", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsLeagueCodeJSON.HoldingGenerator fieldGeneratorLeague;
        private SportsLeagueDivisionJSON.HoldingGenerator fieldGeneratorDivision;
        private SportsStatsTypeJSON.HoldingGenerator fieldGeneratorStatistic;
        private SportsSeasonResolvedJSON.HoldingGenerator fieldGeneratorSeason;
    private abstract class FieldGeneratorTeamsOrPlayers : JSONStringGenerator
          {
            protected FieldGeneratorTeamsOrPlayers(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorTeamsOrPlayers()
              {
              }
            protected override void handle_result(string result)
              {
                TypeTeamsOrPlayersKnownValues known = stringToTeamsOrPlayers(result);
                TypeTeamsOrPlayers new_value = new TypeTeamsOrPlayers();
                if (known == TypeTeamsOrPlayersKnownValues.TeamsOrPlayers__none)
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
            protected abstract void handle_result(TypeTeamsOrPlayers result);
          };
    private class FieldHoldingGeneratorTeamsOrPlayers : FieldGeneratorTeamsOrPlayers
  {
    protected override void handle_result(TypeTeamsOrPlayers result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorTeamsOrPlayers(String what)
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
    public TypeTeamsOrPlayers value;
  };
    private class FieldHoldingArrayGeneratorTeamsOrPlayers : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorTeamsOrPlayers
      {
        private FieldHoldingArrayGeneratorTeamsOrPlayers top;

        protected override void handle_result(TypeTeamsOrPlayers result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorTeamsOrPlayers init_top)
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
    protected virtual void handle_result(List<TypeTeamsOrPlayers> result)
      {
      }

    public FieldHoldingArrayGeneratorTeamsOrPlayers(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTeamsOrPlayers>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorTeamsOrPlayers()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeTeamsOrPlayers>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeTeamsOrPlayers> value;
  };
        private FieldHoldingGeneratorTeamsOrPlayers fieldGeneratorTeamsOrPlayers;
        private TypeLeadersJSON.HoldingArrayGenerator fieldGeneratorLeaders;
        private SportsSportImageJSON.HoldingGenerator fieldGeneratorSportImage;
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
            SportsLeagueLeadersJSON result = new SportsLeagueLeadersJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsLeagueLeadersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsLeagueLeadersJSON result)
          {
            if (fieldGeneratorLeague.have_value)
              {
                result.setLeague(fieldGeneratorLeague.value);
                fieldGeneratorLeague.have_value = false;
              }
            else if ((!(result.hasLeague())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"League\" field was missing.");
              }
            if (fieldGeneratorDivision.have_value)
              {
                result.setDivision(fieldGeneratorDivision.value);
                fieldGeneratorDivision.have_value = false;
              }
            if (fieldGeneratorStatistic.have_value)
              {
                result.setStatistic(fieldGeneratorStatistic.value);
                fieldGeneratorStatistic.have_value = false;
              }
            else if ((!(result.hasStatistic())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Statistic\" field was missing.");
              }
            if (fieldGeneratorSeason.have_value)
              {
                result.setSeason(fieldGeneratorSeason.value);
                fieldGeneratorSeason.have_value = false;
              }
            else if ((!(result.hasSeason())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Season\" field was missing.");
              }
            if (fieldGeneratorTeamsOrPlayers.have_value)
              {
                result.setTeamsOrPlayers(fieldGeneratorTeamsOrPlayers.value);
                fieldGeneratorTeamsOrPlayers.have_value = false;
              }
            else if ((!(result.hasTeamsOrPlayers())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TeamsOrPlayers\" field was missing.");
              }
            if (fieldGeneratorLeaders.have_value)
              {
                result.initLeaders();
                int count = fieldGeneratorLeaders.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLeaders(fieldGeneratorLeaders.value[num]);
                  }
                fieldGeneratorLeaders.value.Clear();
                fieldGeneratorLeaders.have_value = false;
              }
            if (fieldGeneratorSportImage.have_value)
              {
                result.setSportImage(fieldGeneratorSportImage.value);
                fieldGeneratorSportImage.have_value = false;
              }
          }
        protected abstract void handle_result(SportsLeagueLeadersJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ivision", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorDivision;
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "ea", 0, 2, false) == 0)
                      {
                        switch (field_name[3])
                          {
                            case 'd':
                                if ((String.Compare(field_name, 4, "ers", 0, 3, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorLeaders;
                                break;
                            case 'g':
                                if ((String.Compare(field_name, 4, "ue", 0, 2, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorLeague;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ason", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorSeason;
                            break;
                        case 'p':
                            if ((String.Compare(field_name, 2, "ortImage", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorSportImage;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "atistic", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorStatistic;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "eamsOrPlayers", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorTeamsOrPlayers;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsLeagueLeaders class", ignore_extras);
            fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the SportsLeagueLeaders class", ignore_extras);
            fieldGeneratorStatistic = new SportsStatsTypeJSON.HoldingGenerator("field \"Statistic\" of the SportsLeagueLeaders class", ignore_extras);
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsLeagueLeaders class", ignore_extras);
            fieldGeneratorTeamsOrPlayers = new FieldHoldingGeneratorTeamsOrPlayers("field \"TeamsOrPlayers\" of the SportsLeagueLeaders class");
            fieldGeneratorLeaders = new TypeLeadersJSON.HoldingArrayGenerator("field \"Leaders\" of the SportsLeagueLeaders class", ignore_extras);
            fieldGeneratorSportImage = new SportsSportImageJSON.HoldingGenerator("field \"SportImage\" of the SportsLeagueLeaders class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsLeagueLeaders class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsLeagueLeaders class", false);
            fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the SportsLeagueLeaders class", false);
            fieldGeneratorStatistic = new SportsStatsTypeJSON.HoldingGenerator("field \"Statistic\" of the SportsLeagueLeaders class", false);
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsLeagueLeaders class", false);
            fieldGeneratorTeamsOrPlayers = new FieldHoldingGeneratorTeamsOrPlayers("field \"TeamsOrPlayers\" of the SportsLeagueLeaders class");
            fieldGeneratorLeaders = new TypeLeadersJSON.HoldingArrayGenerator("field \"Leaders\" of the SportsLeagueLeaders class", false);
            fieldGeneratorSportImage = new SportsSportImageJSON.HoldingGenerator("field \"SportImage\" of the SportsLeagueLeaders class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsLeagueLeaders class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLeague.reset();
            fieldGeneratorDivision.reset();
            fieldGeneratorStatistic.reset();
            fieldGeneratorSeason.reset();
            fieldGeneratorTeamsOrPlayers.reset();
            fieldGeneratorLeaders.reset();
            fieldGeneratorSportImage.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLeague.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDivision.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStatistic.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeason.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLeaders.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSportImage.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLeague.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDivision.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStatistic.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeason.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLeaders.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSportImage.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsLeagueLeadersJSON  result)
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
        public SportsLeagueLeadersJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsLeagueLeadersJSON  result)
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
    protected virtual void handle_result(List<SportsLeagueLeadersJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsLeagueLeadersJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsLeagueLeadersJSON>();
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
    public List<SportsLeagueLeadersJSON> value;
  };
  };
