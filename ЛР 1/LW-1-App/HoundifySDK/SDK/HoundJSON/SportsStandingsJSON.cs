/* file "SportsStandingsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStandingsJSON : JSONBase
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

    public class TypeDivisionsJSON : JSONBase
      {
        public class TypeTeamsJSON : JSONBase
          {
            private bool flagHasTeam;
            private SportsTeamNewJSON  storeTeam;
            private bool flagHasStandingsData;
            private SportsStandingsDataJSON  storeStandingsData;
            private List<string> extraKeys;
            private List<JSONValue > extraValues;
            private Dictionary<string, JSONValue > extraIndex;


            private void  fromJSONTeam(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                SportsTeamNewJSON convert_classy = SportsTeamNewJSON.from_json(json_value, ignore_extras, true);
                setTeam(convert_classy);
              }


            private void  fromJSONStandingsData(JSONValue json_value, bool ignore_extras)
              {
                Debug.Assert(json_value != null);
                SportsStandingsDataJSON convert_classy = SportsStandingsDataJSON.from_json(json_value, ignore_extras, true);
                setStandingsData(convert_classy);
              }


            public TypeTeamsJSON()
              {
                flagHasTeam = false;
                flagHasStandingsData = false;
                extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
            extraIndex = new Dictionary<string, JSONValue >();
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

            public bool  hasStandingsData()
              {
                return flagHasStandingsData;
              }

            public SportsStandingsDataJSON   getStandingsData()
              {
                Debug.Assert(flagHasStandingsData);
                return storeStandingsData;
              }


            public virtual int extraTypeTeamsComponentCount()
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                return extraKeys.Count;
              }
            public virtual string extraTypeTeamsComponentKey(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraKeys[component_num];
              }
            public virtual JSONValue extraTypeTeamsComponentValue(int component_num)
              {
                Debug.Assert(extraKeys.Count == extraValues.Count);
                Debug.Assert(component_num < extraValues.Count);
                return extraValues[component_num];
              }
            public virtual JSONValue extraTypeTeamsLookup(string field_name)
              {
                JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
                return result;
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
            public void setStandingsData(SportsStandingsDataJSON  new_value)
              {
                if (flagHasStandingsData)
                  {
                  }
                flagHasStandingsData = true;
                storeStandingsData = new_value;
              }
            public void unsetStandingsData()
              {
                if (flagHasStandingsData)
                  {
                  }
                flagHasStandingsData = false;
              }

            public virtual void extraTypeTeamsAppendPair(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                Debug.Assert(extraKeys.Count == extraValues.Count);
                extraKeys.Add(key);
                extraValues.Add(new_component);
                extraIndex.Add(key, new_component);
              }
            public virtual void extraTypeTeamsSetField(string key, JSONValue new_component)
              {
                Debug.Assert(key != null);
                Debug.Assert(new_component != null);

                JSONValue old_field = extraTypeTeamsLookup(key);
                if (old_field == null)
                  {
                    extraTypeTeamsAppendPair(key, new_component);
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
                Debug.Assert(partial_allowed || flagHasTeam);
                if (flagHasTeam)
                  {
                    handler.start_pair("Team");
                    if (partial_allowed)
                        storeTeam.write_partial_as_json(handler);
                    else
                        storeTeam.write_as_json(handler);
                  }
                Debug.Assert(partial_allowed || flagHasStandingsData);
                if (flagHasStandingsData)
                  {
                    handler.start_pair("StandingsData");
                    if (partial_allowed)
                        storeStandingsData.write_partial_as_json(handler);
                    else
                        storeStandingsData.write_as_json(handler);
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
                if (!(hasTeam()))
                  {
                    return "When parsing the object for %what%, the \"Team\" field was missing.";
                  }
                if (!(hasStandingsData()))
                  {
                    return "When parsing the object for %what%, the \"StandingsData\" field was missing.";
                  }
                return null;
              }

            public static TypeTeamsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeTeamsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeTeams", ignore_extras);
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
            public static TypeTeamsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeTeamsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
              {
                TypeTeamsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeTeams", ignore_extras);
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
            public static TypeTeamsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
          {
            return from_json(json_value, ignore_extras, allow_incomplete, false);
          }
            public static TypeTeamsJSON from_text(string text, bool ignore_extras)
              {
                TypeTeamsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeTeams", ignore_extras);
                    JSONParse.parse_json_value(text, "Text for TypeTeamsJSON", generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public static TypeTeamsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
              {
                TypeTeamsJSON result;
                  {
                    HoldingGenerator generator = new HoldingGenerator("Type TypeTeams", ignore_extras);
                    JSONParse.parse_json_value(fp, file_name, generator);
                    Debug.Assert(generator.have_value);
                    result = generator.value;
                  };
                return result;
              }
            public abstract class Generator : JSONObjectGenerator
              {
                private SportsTeamNewJSON.HoldingGenerator fieldGeneratorTeam;
                private SportsStandingsDataJSON.HoldingGenerator fieldGeneratorStandingsData;
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
                    TypeTeamsJSON result = new TypeTeamsJSON();
                    Debug.Assert(result != null);
                    finish(result);
                    int extra_count = unknownFieldGenerator.field_names.Count;
                    Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                    for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                      {
                        result.extraTypeTeamsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                      }
                    unknownFieldGenerator.field_names.Clear();
                    unknownFieldGenerator.field_values.Clear();
                    unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                    handle_result(result);
                  }
                protected void finish(TypeTeamsJSON result)
                  {
                    if (fieldGeneratorTeam.have_value)
                      {
                        result.setTeam(fieldGeneratorTeam.value);
                        fieldGeneratorTeam.have_value = false;
                      }
                    else if ((!(result.hasTeam())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"Team\" field was missing.");
                      }
                    if (fieldGeneratorStandingsData.have_value)
                      {
                        result.setStandingsData(fieldGeneratorStandingsData.value);
                        fieldGeneratorStandingsData.have_value = false;
                      }
                    else if ((!(result.hasStandingsData())) && !allow_incomplete)
                      {
                        error("When parsing the object for %what%, the \"StandingsData\" field was missing.");
                      }
                  }
                protected abstract void handle_result(TypeTeamsJSON new_result);
                protected virtual JSONHandler start_known_field(string field_name)
                  {
                    switch (field_name[0])
                      {
                        case 'S':
                            if ((String.Compare(field_name, 1, "tandingsData", 0, 12, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorStandingsData;
                            break;
                        case 'T':
                            if ((String.Compare(field_name, 1, "eam", 0, 3, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorTeam;
                            break;
                        default:
                            break;
                      }
                    return null;
                  }
                public Generator(bool ignore_extras)
                  {
                    fieldGeneratorTeam = new SportsTeamNewJSON.HoldingGenerator("field \"Team\" of the TypeTeams class", ignore_extras);
                    fieldGeneratorStandingsData = new SportsStandingsDataJSON.HoldingGenerator("field \"StandingsData\" of the TypeTeams class", ignore_extras);
                    unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                    set_what("the TypeTeams class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }
                public Generator()
                  {
                    fieldGeneratorTeam = new SportsTeamNewJSON.HoldingGenerator("field \"Team\" of the TypeTeams class", false);
                    fieldGeneratorStandingsData = new SportsStandingsDataJSON.HoldingGenerator("field \"StandingsData\" of the TypeTeams class", false);
                    unknownFieldGenerator = new UnknownFieldGenerator(false);
                    set_what("the TypeTeams class");
                    allow_incomplete = false;
                    allow_unpolished = false;
                  }

                public override void reset()
                  {
                    fieldGeneratorTeam.reset();
                    fieldGeneratorStandingsData.reset();
                    base.reset();
                    unknownFieldGenerator.reset();
                  }
                public void set_allow_incomplete(bool new_allow_incomplete)
                  {
                    allow_incomplete = new_allow_incomplete;
                    fieldGeneratorTeam.set_allow_incomplete(new_allow_incomplete);
                    fieldGeneratorStandingsData.set_allow_incomplete(new_allow_incomplete);
                  }
                public void set_allow_unpolished(bool new_allow_unpolished)
                  {
                    allow_unpolished = new_allow_unpolished;
                    fieldGeneratorTeam.set_allow_unpolished(new_allow_unpolished);
                    fieldGeneratorStandingsData.set_allow_unpolished(new_allow_unpolished);
                  }
              };
            public class HoldingGenerator : Generator
              {
                protected override void handle_result(TypeTeamsJSON  result)
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
                public TypeTeamsJSON value;
              };
            public class HoldingArrayGenerator : JSONArrayGenerator
          {
            protected class ElementHandler : Generator
              {
                private HoldingArrayGenerator top;

                protected override void handle_result(TypeTeamsJSON  result)
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
            protected virtual void handle_result(List<TypeTeamsJSON> result)

              {
              }

            public HoldingArrayGenerator(string what, bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                have_value = false;
                value = new List<TypeTeamsJSON>();
                base.set_what(what);
              }
            public HoldingArrayGenerator(bool ignore_extras)
              {
                element_handler = new ElementHandler(this, ignore_extras);
                value = new List<TypeTeamsJSON>();
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
            public List<TypeTeamsJSON> value;
          };
          };
        private bool flagHasLeague;
        private SportsLeagueCodeJSON  storeLeague;
        private bool flagHasDivision;
        private SportsLeagueDivisionJSON  storeDivision;
        private bool flagHasTeams;
        private List< TypeTeamsJSON  > storeTeams;
        private bool flagHasReferencedInQuery;
        private bool storeReferencedInQuery;
        private bool flagHasHasDivisionGamePlayed;
        private bool storeHasDivisionGamePlayed;
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


        private void  fromJSONTeams(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field Teams of TypeDivisionsJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< TypeTeamsJSON  > vector_Teams1 = new List< TypeTeamsJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                TypeTeamsJSON convert_classy = TypeTeamsJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_Teams1.Add(convert_classy);
              }
            initTeams();
            for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
                appendTeams(vector_Teams1[num1]);
            for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
              {
              }
          }


        private void  fromJSONReferencedInQuery(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field ReferencedInQuery of TypeDivisionsJSON is not true for false.");
                  }
              }
            setReferencedInQuery(the_bool);
          }


        private void  fromJSONHasDivisionGamePlayed(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field HasDivisionGamePlayed of TypeDivisionsJSON is not true for false.");
                  }
              }
            setHasDivisionGamePlayed(the_bool);
          }


        public TypeDivisionsJSON()
          {
            flagHasLeague = false;
            flagHasDivision = false;
            flagHasTeams = false;
            flagHasReferencedInQuery = false;
            flagHasHasDivisionGamePlayed = false;
            storeTeams = new List< TypeTeamsJSON  >();
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

        public bool  hasTeams()
          {
            return flagHasTeams;
          }

        public int  countOfTeams()
          {
            Debug.Assert(flagHasTeams);
            return storeTeams.Count;
          }

        public TypeTeamsJSON   elementOfTeams(int element_num)
          {
            Debug.Assert(flagHasTeams);
            return storeTeams[element_num];
          }

        public List< TypeTeamsJSON  >  getTeams()
          {
            Debug.Assert(flagHasTeams);
            return storeTeams;
          }

        public bool  hasReferencedInQuery()
          {
            return flagHasReferencedInQuery;
          }

        public bool  getReferencedInQuery()
          {
            Debug.Assert(flagHasReferencedInQuery);
            return storeReferencedInQuery;
          }

        public bool  hasHasDivisionGamePlayed()
          {
            return flagHasHasDivisionGamePlayed;
          }

        public bool  getHasDivisionGamePlayed()
          {
            Debug.Assert(flagHasHasDivisionGamePlayed);
            return storeHasDivisionGamePlayed;
          }


        public virtual int extraTypeDivisionsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeDivisionsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeDivisionsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeDivisionsLookup(string field_name)
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
        public void initTeams()
          {
            if (flagHasTeams)
              {
                for (int num1 = 0; num1 < storeTeams.Count; ++num1)
                  {
                  }
              }
            flagHasTeams = true;
            storeTeams.Clear();
          }
        public void appendTeams(TypeTeamsJSON  to_append)
          {
            if (!flagHasTeams)
              {
                flagHasTeams = true;
                storeTeams.Clear();
              }
            Debug.Assert(flagHasTeams);
            storeTeams.Add(to_append);
          }
        public void unsetTeams()
          {
            if (flagHasTeams)
              {
                for (int num2 = 0; num2 < storeTeams.Count; ++num2)
                  {
                  }
              }
            flagHasTeams = false;
            storeTeams.Clear();
          }
        public void setReferencedInQuery(bool new_value)
          {
            flagHasReferencedInQuery = true;
            storeReferencedInQuery = new_value;
          }
        public void unsetReferencedInQuery()
          {
            flagHasReferencedInQuery = false;
          }
        public void setHasDivisionGamePlayed(bool new_value)
          {
            flagHasHasDivisionGamePlayed = true;
            storeHasDivisionGamePlayed = new_value;
          }
        public void unsetHasDivisionGamePlayed()
          {
            flagHasHasDivisionGamePlayed = false;
          }

        public virtual void extraTypeDivisionsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeDivisionsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeDivisionsLookup(key);
            if (old_field == null)
              {
                extraTypeDivisionsAppendPair(key, new_component);
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
            if (flagHasTeams)
              {
                handler.start_pair("Teams");
                handler.start_array();
                for (int num1 = 0; num1 < storeTeams.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeTeams[num1].write_partial_as_json(handler);
                    else
                        storeTeams[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasReferencedInQuery)
              {
                handler.start_pair("ReferencedInQuery");
                handler.boolean_value(storeReferencedInQuery);
              }
            if (flagHasHasDivisionGamePlayed)
              {
                handler.start_pair("HasDivisionGamePlayed");
                handler.boolean_value(storeHasDivisionGamePlayed);
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

        public static TypeDivisionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDivisionsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDivisions", ignore_extras);
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
        public static TypeDivisionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDivisionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeDivisionsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDivisions", ignore_extras);
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
        public static TypeDivisionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeDivisionsJSON from_text(string text, bool ignore_extras)
          {
            TypeDivisionsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDivisions", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeDivisionsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeDivisionsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeDivisionsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeDivisions", ignore_extras);
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
            private TypeTeamsJSON.HoldingArrayGenerator fieldGeneratorTeams;
            private JSONHoldingBooleanGenerator fieldGeneratorReferencedInQuery;
            private JSONHoldingBooleanGenerator fieldGeneratorHasDivisionGamePlayed;
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
                TypeDivisionsJSON result = new TypeDivisionsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeDivisionsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeDivisionsJSON result)
              {
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
                if (fieldGeneratorTeams.have_value)
                  {
                    result.initTeams();
                    int count = fieldGeneratorTeams.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendTeams(fieldGeneratorTeams.value[num]);
                      }
                    fieldGeneratorTeams.value.Clear();
                    fieldGeneratorTeams.have_value = false;
                  }
                if (fieldGeneratorReferencedInQuery.have_value)
                  {
                    result.setReferencedInQuery(fieldGeneratorReferencedInQuery.value);
                    fieldGeneratorReferencedInQuery.have_value = false;
                  }
                if (fieldGeneratorHasDivisionGamePlayed.have_value)
                  {
                    result.setHasDivisionGamePlayed(fieldGeneratorHasDivisionGamePlayed.value);
                    fieldGeneratorHasDivisionGamePlayed.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeDivisionsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "ivision", 0, 7, false) == 0) && (field_name.Length == 8))
                            return fieldGeneratorDivision;
                        break;
                    case 'H':
                        if ((String.Compare(field_name, 1, "asDivisionGamePlayed", 0, 20, false) == 0) && (field_name.Length == 21))
                            return fieldGeneratorHasDivisionGamePlayed;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "eague", 0, 5, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorLeague;
                        break;
                    case 'R':
                        if ((String.Compare(field_name, 1, "eferencedInQuery", 0, 16, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorReferencedInQuery;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "eams", 0, 4, false) == 0) && (field_name.Length == 5))
                            return fieldGeneratorTeams;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the TypeDivisions class", ignore_extras);
                fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the TypeDivisions class", ignore_extras);
                fieldGeneratorTeams = new TypeTeamsJSON.HoldingArrayGenerator("field \"Teams\" of the TypeDivisions class", ignore_extras);
                fieldGeneratorReferencedInQuery = new JSONHoldingBooleanGenerator("field \"ReferencedInQuery\" of the TypeDivisions class");
                fieldGeneratorHasDivisionGamePlayed = new JSONHoldingBooleanGenerator("field \"HasDivisionGamePlayed\" of the TypeDivisions class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeDivisions class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the TypeDivisions class", false);
                fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the TypeDivisions class", false);
                fieldGeneratorTeams = new TypeTeamsJSON.HoldingArrayGenerator("field \"Teams\" of the TypeDivisions class", false);
                fieldGeneratorReferencedInQuery = new JSONHoldingBooleanGenerator("field \"ReferencedInQuery\" of the TypeDivisions class");
                fieldGeneratorHasDivisionGamePlayed = new JSONHoldingBooleanGenerator("field \"HasDivisionGamePlayed\" of the TypeDivisions class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeDivisions class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorLeague.reset();
                fieldGeneratorDivision.reset();
                fieldGeneratorTeams.reset();
                fieldGeneratorReferencedInQuery.reset();
                fieldGeneratorHasDivisionGamePlayed.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorLeague.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorDivision.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorTeams.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorLeague.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorDivision.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorTeams.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeDivisionsJSON  result)
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
            public TypeDivisionsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeDivisionsJSON  result)
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
        protected virtual void handle_result(List<TypeDivisionsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeDivisionsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeDivisionsJSON>();
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
        public List<TypeDivisionsJSON> value;
      };
      };
    private bool flagHasSport;
    private SportsSportCodeJSON  storeSport;
    private bool flagHasLeague;
    private SportsLeagueCodeJSON  storeLeague;
    private bool flagHasDivision;
    private SportsLeagueDivisionJSON  storeDivision;
    private bool flagHasTournament;
    private SportsTournamentJSON  storeTournament;
    private bool flagHasGrouping;
    private TypeGrouping storeGrouping;
    private bool flagHasSeason;
    private SportsSeasonResolvedJSON  storeSeason;
    private bool flagHasHasLeagueGamePlayed;
    private bool storeHasLeagueGamePlayed;
    private bool flagHasDivisions;
    private List< TypeDivisionsJSON  > storeDivisions;
    private bool flagHasSportImage;
    private SportsSportImageJSON  storeSportImage;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSport(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSportCodeJSON convert_classy = SportsSportCodeJSON.from_json(json_value, ignore_extras, true);
        setSport(convert_classy);
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


    private void  fromJSONTournament(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsTournamentJSON convert_classy = SportsTournamentJSON.from_json(json_value, ignore_extras, true);
        setTournament(convert_classy);
      }


    private void  fromJSONGrouping(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Grouping of SportsStandingsJSON is not a string.");
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


    private void  fromJSONHasLeagueGamePlayed(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HasLeagueGamePlayed of SportsStandingsJSON is not true for false.");
              }
          }
        setHasLeagueGamePlayed(the_bool);
      }


    private void  fromJSONDivisions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Divisions of SportsStandingsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeDivisionsJSON  > vector_Divisions1 = new List< TypeDivisionsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeDivisionsJSON convert_classy = TypeDivisionsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Divisions1.Add(convert_classy);
          }
        initDivisions();
        for (int num2 = 0; num2 < vector_Divisions1.Count; ++num2)
            appendDivisions(vector_Divisions1[num2]);
        for (int num1 = 0; num1 < vector_Divisions1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSportImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSportImageJSON convert_classy = SportsSportImageJSON.from_json(json_value, ignore_extras, true);
        setSportImage(convert_classy);
      }


    public SportsStandingsJSON()
      {
        flagHasSport = false;
        flagHasLeague = false;
        flagHasDivision = false;
        flagHasTournament = false;
        flagHasGrouping = false;
        flagHasSeason = false;
        flagHasHasLeagueGamePlayed = false;
        flagHasDivisions = false;
        flagHasSportImage = false;
        storeDivisions = new List< TypeDivisionsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSport()
      {
        return flagHasSport;
      }

    public SportsSportCodeJSON   getSport()
      {
        Debug.Assert(flagHasSport);
        return storeSport;
      }

    public SportsSportCodeJSON.TypeValue  getSportValue()
      {
        return getSport().getValue();
      }

    public string  getSportAsString()
      {
        return getSport().getValueAsString();
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

    public bool  hasTournament()
      {
        return flagHasTournament;
      }

    public SportsTournamentJSON   getTournament()
      {
        Debug.Assert(flagHasTournament);
        return storeTournament;
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

    public bool  hasHasLeagueGamePlayed()
      {
        return flagHasHasLeagueGamePlayed;
      }

    public bool  getHasLeagueGamePlayed()
      {
        Debug.Assert(flagHasHasLeagueGamePlayed);
        return storeHasLeagueGamePlayed;
      }

    public bool  hasDivisions()
      {
        return flagHasDivisions;
      }

    public int  countOfDivisions()
      {
        Debug.Assert(flagHasDivisions);
        return storeDivisions.Count;
      }

    public TypeDivisionsJSON   elementOfDivisions(int element_num)
      {
        Debug.Assert(flagHasDivisions);
        return storeDivisions[element_num];
      }

    public List< TypeDivisionsJSON  >  getDivisions()
      {
        Debug.Assert(flagHasDivisions);
        return storeDivisions;
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


    public virtual int extraSportsStandingsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStandingsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStandingsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStandingsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSport(SportsSportCodeJSON  new_value)
      {
        if (flagHasSport)
          {
          }
        flagHasSport = true;
        storeSport = new_value;
      }
    public void setSport(SportsSportCodeJSON.TypeValue new_value)
      {
        setSport(new SportsSportCodeJSON(new_value));
      }
    public void setSport(string chars)
      {
        SportsSportCodeJSON.TypeValueKnownValues known = SportsSportCodeJSON.stringToValue(chars);
        SportsSportCodeJSON.TypeValue new_value = new SportsSportCodeJSON.TypeValue();
        if (known == SportsSportCodeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSport(new_value);
      }
    public void unsetSport()
      {
        if (flagHasSport)
          {
          }
        flagHasSport = false;
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
    public void setHasLeagueGamePlayed(bool new_value)
      {
        flagHasHasLeagueGamePlayed = true;
        storeHasLeagueGamePlayed = new_value;
      }
    public void unsetHasLeagueGamePlayed()
      {
        flagHasHasLeagueGamePlayed = false;
      }
    public void initDivisions()
      {
        if (flagHasDivisions)
          {
            for (int num3 = 0; num3 < storeDivisions.Count; ++num3)
              {
              }
          }
        flagHasDivisions = true;
        storeDivisions.Clear();
      }
    public void appendDivisions(TypeDivisionsJSON  to_append)
      {
        if (!flagHasDivisions)
          {
            flagHasDivisions = true;
            storeDivisions.Clear();
          }
        Debug.Assert(flagHasDivisions);
        storeDivisions.Add(to_append);
      }
    public void unsetDivisions()
      {
        if (flagHasDivisions)
          {
            for (int num4 = 0; num4 < storeDivisions.Count; ++num4)
              {
              }
          }
        flagHasDivisions = false;
        storeDivisions.Clear();
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

    public virtual void extraSportsStandingsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStandingsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStandingsLookup(key);
        if (old_field == null)
          {
            extraSportsStandingsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSport);
        if (flagHasSport)
          {
            handler.start_pair("Sport");
            if (partial_allowed)
                storeSport.write_partial_as_json(handler);
            else
                storeSport.write_as_json(handler);
          }
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
        if (flagHasTournament)
          {
            handler.start_pair("Tournament");
            if (partial_allowed)
                storeTournament.write_partial_as_json(handler);
            else
                storeTournament.write_as_json(handler);
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
        Debug.Assert(partial_allowed || flagHasSeason);
        if (flagHasSeason)
          {
            handler.start_pair("Season");
            if (partial_allowed)
                storeSeason.write_partial_as_json(handler);
            else
                storeSeason.write_as_json(handler);
          }
        if (flagHasHasLeagueGamePlayed)
          {
            handler.start_pair("HasLeagueGamePlayed");
            handler.boolean_value(storeHasLeagueGamePlayed);
          }
        if (flagHasDivisions)
          {
            handler.start_pair("Divisions");
            handler.start_array();
            for (int num1 = 0; num1 < storeDivisions.Count; ++num1)
              {
                if (partial_allowed)
                    storeDivisions[num1].write_partial_as_json(handler);
                else
                    storeDivisions[num1].write_as_json(handler);
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
        if (!(hasSport()))
          {
            return "When parsing the object for %what%, the \"Sport\" field was missing.";
          }
        if (!(hasLeague()))
          {
            return "When parsing the object for %what%, the \"League\" field was missing.";
          }
        if (!(hasSeason()))
          {
            return "When parsing the object for %what%, the \"Season\" field was missing.";
          }
        return null;
      }

    public static SportsStandingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandings", ignore_extras);
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
    public static SportsStandingsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandings", ignore_extras);
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
    public static SportsStandingsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandings", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStandingsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandings", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsSportCodeJSON.HoldingGenerator fieldGeneratorSport;
        private SportsLeagueCodeJSON.HoldingGenerator fieldGeneratorLeague;
        private SportsLeagueDivisionJSON.HoldingGenerator fieldGeneratorDivision;
        private SportsTournamentJSON.HoldingGenerator fieldGeneratorTournament;
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
        private JSONHoldingBooleanGenerator fieldGeneratorHasLeagueGamePlayed;
        private TypeDivisionsJSON.HoldingArrayGenerator fieldGeneratorDivisions;
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
            SportsStandingsJSON result = new SportsStandingsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStandingsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsStandingsJSON result)
          {
            if (fieldGeneratorSport.have_value)
              {
                result.setSport(fieldGeneratorSport.value);
                fieldGeneratorSport.have_value = false;
              }
            else if ((!(result.hasSport())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Sport\" field was missing.");
              }
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
            if (fieldGeneratorTournament.have_value)
              {
                result.setTournament(fieldGeneratorTournament.value);
                fieldGeneratorTournament.have_value = false;
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
            else if ((!(result.hasSeason())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Season\" field was missing.");
              }
            if (fieldGeneratorHasLeagueGamePlayed.have_value)
              {
                result.setHasLeagueGamePlayed(fieldGeneratorHasLeagueGamePlayed.value);
                fieldGeneratorHasLeagueGamePlayed.have_value = false;
              }
            if (fieldGeneratorDivisions.have_value)
              {
                result.initDivisions();
                int count = fieldGeneratorDivisions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDivisions(fieldGeneratorDivisions.value[num]);
                  }
                fieldGeneratorDivisions.value.Clear();
                fieldGeneratorDivisions.have_value = false;
              }
            if (fieldGeneratorSportImage.have_value)
              {
                result.setSportImage(fieldGeneratorSportImage.value);
                fieldGeneratorSportImage.have_value = false;
              }
          }
        protected abstract void handle_result(SportsStandingsJSON new_result);
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
                            case 's':
                                if (field_name.Length == 9)
                                    return fieldGeneratorDivisions;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "rouping", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorGrouping;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "asLeagueGamePlayed", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorHasLeagueGamePlayed;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "eague", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorLeague;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ason", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorSeason;
                            break;
                        case 'p':
                            if (String.Compare(field_name, 2, "ort", 0, 3, false) == 0)
                              {
                                if (field_name.Length == 5)
                                  {
                                    return fieldGeneratorSport;
                                  }
                                switch (field_name[5])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 6, "mage", 0, 4, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorSportImage;
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
                case 'T':
                    if ((String.Compare(field_name, 1, "ournament", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorTournament;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSport = new SportsSportCodeJSON.HoldingGenerator("field \"Sport\" of the SportsStandings class", ignore_extras);
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsStandings class", ignore_extras);
            fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the SportsStandings class", ignore_extras);
            fieldGeneratorTournament = new SportsTournamentJSON.HoldingGenerator("field \"Tournament\" of the SportsStandings class", ignore_extras);
            fieldGeneratorGrouping = new FieldHoldingGeneratorGrouping("field \"Grouping\" of the SportsStandings class");
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsStandings class", ignore_extras);
            fieldGeneratorHasLeagueGamePlayed = new JSONHoldingBooleanGenerator("field \"HasLeagueGamePlayed\" of the SportsStandings class");
            fieldGeneratorDivisions = new TypeDivisionsJSON.HoldingArrayGenerator("field \"Divisions\" of the SportsStandings class", ignore_extras);
            fieldGeneratorSportImage = new SportsSportImageJSON.HoldingGenerator("field \"SportImage\" of the SportsStandings class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStandings class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSport = new SportsSportCodeJSON.HoldingGenerator("field \"Sport\" of the SportsStandings class", false);
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsStandings class", false);
            fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the SportsStandings class", false);
            fieldGeneratorTournament = new SportsTournamentJSON.HoldingGenerator("field \"Tournament\" of the SportsStandings class", false);
            fieldGeneratorGrouping = new FieldHoldingGeneratorGrouping("field \"Grouping\" of the SportsStandings class");
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsStandings class", false);
            fieldGeneratorHasLeagueGamePlayed = new JSONHoldingBooleanGenerator("field \"HasLeagueGamePlayed\" of the SportsStandings class");
            fieldGeneratorDivisions = new TypeDivisionsJSON.HoldingArrayGenerator("field \"Divisions\" of the SportsStandings class", false);
            fieldGeneratorSportImage = new SportsSportImageJSON.HoldingGenerator("field \"SportImage\" of the SportsStandings class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStandings class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSport.reset();
            fieldGeneratorLeague.reset();
            fieldGeneratorDivision.reset();
            fieldGeneratorTournament.reset();
            fieldGeneratorGrouping.reset();
            fieldGeneratorSeason.reset();
            fieldGeneratorHasLeagueGamePlayed.reset();
            fieldGeneratorDivisions.reset();
            fieldGeneratorSportImage.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSport.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLeague.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDivision.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTournament.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeason.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDivisions.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSportImage.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSport.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLeague.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDivision.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTournament.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeason.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDivisions.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSportImage.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStandingsJSON  result)
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
        public SportsStandingsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsJSON>();
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
    public List<SportsStandingsJSON> value;
  };
  };
