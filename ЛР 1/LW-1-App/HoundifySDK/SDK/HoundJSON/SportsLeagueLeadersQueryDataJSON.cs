/* file "SportsLeagueLeadersQueryDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsLeagueLeadersQueryDataJSON : JSONBase
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

    public class TypeLeagueLeadersIndicesJSON : JSONBase
      {
        private bool flagHasLeagueLeadersIndex;
        private BigInteger storeLeagueLeadersIndex;
        private bool flagHasTeamOrPlayerIndices;
        private List< BigInteger > storeTeamOrPlayerIndices;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONLeagueLeadersIndex(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field LeagueLeadersIndex of TypeLeagueLeadersIndicesJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field LeagueLeadersIndex of TypeLeagueLeadersIndicesJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setLeagueLeadersIndex(extracted_integer);
          }


        private void  fromJSONTeamOrPlayerIndices(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field TeamOrPlayerIndices of TypeLeagueLeadersIndicesJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field TeamOrPlayerIndices of TypeLeagueLeadersIndicesJSON has too few elements.");
            List< BigInteger > vector_TeamOrPlayerIndices1 = new List< BigInteger >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for an element of field TeamOrPlayerIndices of TypeLeagueLeadersIndicesJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for an element of field TeamOrPlayerIndices of TypeLeagueLeadersIndicesJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                vector_TeamOrPlayerIndices1.Add(extracted_integer);
              }
            Debug.Assert(vector_TeamOrPlayerIndices1.Count >= 1);
            initTeamOrPlayerIndices();
            for (int num1 = 0; num1 < vector_TeamOrPlayerIndices1.Count; ++num1)
                appendTeamOrPlayerIndices(vector_TeamOrPlayerIndices1[num1]);
            for (int num1 = 0; num1 < vector_TeamOrPlayerIndices1.Count; ++num1)
              {
              }
          }


        public TypeLeagueLeadersIndicesJSON()
          {
            flagHasLeagueLeadersIndex = false;
            flagHasTeamOrPlayerIndices = false;
            storeTeamOrPlayerIndices = new List< BigInteger >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasLeagueLeadersIndex()
          {
            return flagHasLeagueLeadersIndex;
          }

        public BigInteger  getLeagueLeadersIndex()
          {
            Debug.Assert(flagHasLeagueLeadersIndex);
            return storeLeagueLeadersIndex;
          }

        public bool  hasTeamOrPlayerIndices()
          {
            return flagHasTeamOrPlayerIndices;
          }

        public int  countOfTeamOrPlayerIndices()
          {
            Debug.Assert(flagHasTeamOrPlayerIndices);
            return storeTeamOrPlayerIndices.Count;
          }

        public BigInteger  elementOfTeamOrPlayerIndices(int element_num)
          {
            Debug.Assert(flagHasTeamOrPlayerIndices);
            return storeTeamOrPlayerIndices[element_num];
          }

        public List< BigInteger >  getTeamOrPlayerIndices()
          {
            Debug.Assert(flagHasTeamOrPlayerIndices);
            return storeTeamOrPlayerIndices;
          }


        public virtual int extraTypeLeagueLeadersIndicesComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeLeagueLeadersIndicesComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeLeagueLeadersIndicesComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeLeagueLeadersIndicesLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setLeagueLeadersIndex(BigInteger new_value)
          {
            flagHasLeagueLeadersIndex = true;
            if (new_value < 0)
                throw new Exception("The value for field LeagueLeadersIndex of TypeLeagueLeadersIndicesJSON is less than the lower bound (0) for that field.");
            storeLeagueLeadersIndex = new_value;
          }
        public void unsetLeagueLeadersIndex()
          {
            flagHasLeagueLeadersIndex = false;
          }
        public void initTeamOrPlayerIndices()
          {
            flagHasTeamOrPlayerIndices = true;
            storeTeamOrPlayerIndices.Clear();
          }
        public void appendTeamOrPlayerIndices(BigInteger to_append)
          {
            if (!flagHasTeamOrPlayerIndices)
              {
                flagHasTeamOrPlayerIndices = true;
                storeTeamOrPlayerIndices.Clear();
              }
            Debug.Assert(flagHasTeamOrPlayerIndices);
            storeTeamOrPlayerIndices.Add(to_append);
          }
        public void unsetTeamOrPlayerIndices()
          {
            flagHasTeamOrPlayerIndices = false;
            storeTeamOrPlayerIndices.Clear();
          }

        public virtual void extraTypeLeagueLeadersIndicesAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeLeagueLeadersIndicesSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeLeagueLeadersIndicesLookup(key);
            if (old_field == null)
              {
                extraTypeLeagueLeadersIndicesAppendPair(key, new_component);
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
            if (flagHasLeagueLeadersIndex)
              {
                handler.start_pair("LeagueLeadersIndex");
                handler.number_value(storeLeagueLeadersIndex);
              }
            if (flagHasTeamOrPlayerIndices)
              {
                handler.start_pair("TeamOrPlayerIndices");
                Debug.Assert(storeTeamOrPlayerIndices.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeTeamOrPlayerIndices.Count; ++num1)
                  {
                    handler.number_value(storeTeamOrPlayerIndices[num1]);
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

        public static TypeLeagueLeadersIndicesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLeagueLeadersIndicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLeagueLeadersIndices", ignore_extras);
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
        public static TypeLeagueLeadersIndicesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLeagueLeadersIndicesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeLeagueLeadersIndicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLeagueLeadersIndices", ignore_extras);
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
        public static TypeLeagueLeadersIndicesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeLeagueLeadersIndicesJSON from_text(string text, bool ignore_extras)
          {
            TypeLeagueLeadersIndicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLeagueLeadersIndices", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeLeagueLeadersIndicesJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeLeagueLeadersIndicesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeLeagueLeadersIndicesJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeLeagueLeadersIndices", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private class FieldHoldingGeneratorLeagueLeadersIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorLeagueLeadersIndex(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorLeagueLeadersIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorLeagueLeadersIndex(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingGeneratorLeagueLeadersIndex fieldGeneratorLeagueLeadersIndex;
        private class FieldHoldingGeneratorTeamOrPlayerIndices : JSONHoldingIntegerLowerBoundOnlyGenerator
              {
                public FieldHoldingGeneratorTeamOrPlayerIndices(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorTeamOrPlayerIndices : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
              {
                public FieldHoldingArrayGeneratorTeamOrPlayerIndices(String what) : base(what, (BigInteger)(0))
                  {
                  }
              };
            private FieldHoldingArrayGeneratorTeamOrPlayerIndices fieldGeneratorTeamOrPlayerIndices;
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
                TypeLeagueLeadersIndicesJSON result = new TypeLeagueLeadersIndicesJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeLeagueLeadersIndicesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeLeagueLeadersIndicesJSON result)
              {
                if (fieldGeneratorLeagueLeadersIndex.have_value)
                  {
                    result.setLeagueLeadersIndex(fieldGeneratorLeagueLeadersIndex.value);
                    fieldGeneratorLeagueLeadersIndex.have_value = false;
                  }
                if (fieldGeneratorTeamOrPlayerIndices.have_value)
                  {
                    result.initTeamOrPlayerIndices();
                    int count = fieldGeneratorTeamOrPlayerIndices.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendTeamOrPlayerIndices(fieldGeneratorTeamOrPlayerIndices.value[num]);
                      }
                    fieldGeneratorTeamOrPlayerIndices.value.Clear();
                    fieldGeneratorTeamOrPlayerIndices.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeLeagueLeadersIndicesJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'L':
                        if ((String.Compare(field_name, 1, "eagueLeadersIndex", 0, 17, false) == 0) && (field_name.Length == 18))
                            return fieldGeneratorLeagueLeadersIndex;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "eamOrPlayerIndices", 0, 18, false) == 0) && (field_name.Length == 19))
                            return fieldGeneratorTeamOrPlayerIndices;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorLeagueLeadersIndex = new FieldHoldingGeneratorLeagueLeadersIndex("field \"LeagueLeadersIndex\" of the TypeLeagueLeadersIndices class");
                fieldGeneratorTeamOrPlayerIndices = new FieldHoldingArrayGeneratorTeamOrPlayerIndices("field \"TeamOrPlayerIndices\" of the TypeLeagueLeadersIndices class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeLeagueLeadersIndices class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorLeagueLeadersIndex = new FieldHoldingGeneratorLeagueLeadersIndex("field \"LeagueLeadersIndex\" of the TypeLeagueLeadersIndices class");
                fieldGeneratorTeamOrPlayerIndices = new FieldHoldingArrayGeneratorTeamOrPlayerIndices("field \"TeamOrPlayerIndices\" of the TypeLeagueLeadersIndices class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeLeagueLeadersIndices class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorLeagueLeadersIndex.reset();
                fieldGeneratorTeamOrPlayerIndices.reset();
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
            protected override void handle_result(TypeLeagueLeadersIndicesJSON  result)
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
            public TypeLeagueLeadersIndicesJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeLeagueLeadersIndicesJSON  result)
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
        protected virtual void handle_result(List<TypeLeagueLeadersIndicesJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeLeagueLeadersIndicesJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeLeagueLeadersIndicesJSON>();
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
        public List<TypeLeagueLeadersIndicesJSON> value;
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

    private bool flagHasLeague;
    private SportsLeagueCodeJSON  storeLeague;
    private bool flagHasDivision;
    private SportsLeagueDivisionJSON  storeDivision;
    private bool flagHasTeamsOrPlayers;
    private TypeTeamsOrPlayers storeTeamsOrPlayers;
    private bool flagHasStatistics;
    private List< SportsStatsTypeJSON  > storeStatistics;
    private bool flagHasRank;
    private BigInteger storeRank;
    private bool flagHasSeason;
    private SportsSeasonResolvedJSON  storeSeason;
    private bool flagHasLeagueLeadersIndices;
    private List< TypeLeagueLeadersIndicesJSON  > storeLeagueLeadersIndices;
    private bool flagHasError;
    private TypeError storeError;
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


    private void  fromJSONTeamsOrPlayers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TeamsOrPlayers of SportsLeagueLeadersQueryDataJSON is not a string.");
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


    private void  fromJSONStatistics(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Statistics of SportsLeagueLeadersQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Statistics of SportsLeagueLeadersQueryDataJSON has too few elements.");
        List< SportsStatsTypeJSON  > vector_Statistics1 = new List< SportsStatsTypeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsStatsTypeJSON convert_classy = SportsStatsTypeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Statistics1.Add(convert_classy);
          }
        Debug.Assert(vector_Statistics1.Count >= 1);
        initStatistics();
        for (int num2 = 0; num2 < vector_Statistics1.Count; ++num2)
            appendStatistics(vector_Statistics1[num2]);
        for (int num1 = 0; num1 < vector_Statistics1.Count; ++num1)
          {
          }
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
                throw new Exception("The value for field Rank of SportsLeagueLeadersQueryDataJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Rank of SportsLeagueLeadersQueryDataJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRank(extracted_integer);
      }


    private void  fromJSONSeason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSeasonResolvedJSON convert_classy = SportsSeasonResolvedJSON.from_json(json_value, ignore_extras, true);
        setSeason(convert_classy);
      }


    private void  fromJSONLeagueLeadersIndices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field LeagueLeadersIndices of SportsLeagueLeadersQueryDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field LeagueLeadersIndices of SportsLeagueLeadersQueryDataJSON has too few elements.");
        List< TypeLeagueLeadersIndicesJSON  > vector_LeagueLeadersIndices1 = new List< TypeLeagueLeadersIndicesJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeLeagueLeadersIndicesJSON convert_classy = TypeLeagueLeadersIndicesJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_LeagueLeadersIndices1.Add(convert_classy);
          }
        Debug.Assert(vector_LeagueLeadersIndices1.Count >= 1);
        initLeagueLeadersIndices();
        for (int num3 = 0; num3 < vector_LeagueLeadersIndices1.Count; ++num3)
            appendLeagueLeadersIndices(vector_LeagueLeadersIndices1[num3]);
        for (int num1 = 0; num1 < vector_LeagueLeadersIndices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Error of SportsLeagueLeadersQueryDataJSON is not a string.");
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


    public SportsLeagueLeadersQueryDataJSON()
      {
        flagHasLeague = false;
        flagHasDivision = false;
        flagHasTeamsOrPlayers = false;
        flagHasStatistics = false;
        flagHasRank = false;
        flagHasSeason = false;
        flagHasLeagueLeadersIndices = false;
        flagHasError = false;
        storeStatistics = new List< SportsStatsTypeJSON  >();
        storeLeagueLeadersIndices = new List< TypeLeagueLeadersIndicesJSON  >();
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

    public bool  hasStatistics()
      {
        return flagHasStatistics;
      }

    public int  countOfStatistics()
      {
        Debug.Assert(flagHasStatistics);
        return storeStatistics.Count;
      }

    public SportsStatsTypeJSON   elementOfStatistics(int element_num)
      {
        Debug.Assert(flagHasStatistics);
        return storeStatistics[element_num];
      }

    public List< SportsStatsTypeJSON  >  getStatistics()
      {
        Debug.Assert(flagHasStatistics);
        return storeStatistics;
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

    public bool  hasSeason()
      {
        return flagHasSeason;
      }

    public SportsSeasonResolvedJSON   getSeason()
      {
        Debug.Assert(flagHasSeason);
        return storeSeason;
      }

    public bool  hasLeagueLeadersIndices()
      {
        return flagHasLeagueLeadersIndices;
      }

    public int  countOfLeagueLeadersIndices()
      {
        Debug.Assert(flagHasLeagueLeadersIndices);
        return storeLeagueLeadersIndices.Count;
      }

    public TypeLeagueLeadersIndicesJSON   elementOfLeagueLeadersIndices(int element_num)
      {
        Debug.Assert(flagHasLeagueLeadersIndices);
        return storeLeagueLeadersIndices[element_num];
      }

    public List< TypeLeagueLeadersIndicesJSON  >  getLeagueLeadersIndices()
      {
        Debug.Assert(flagHasLeagueLeadersIndices);
        return storeLeagueLeadersIndices;
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


    public virtual int extraSportsLeagueLeadersQueryDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsLeagueLeadersQueryDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsLeagueLeadersQueryDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsLeagueLeadersQueryDataLookup(string field_name)
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
    public void initStatistics()
      {
        if (flagHasStatistics)
          {
            for (int num1 = 0; num1 < storeStatistics.Count; ++num1)
              {
              }
          }
        flagHasStatistics = true;
        storeStatistics.Clear();
      }
    public void appendStatistics(SportsStatsTypeJSON  to_append)
      {
        if (!flagHasStatistics)
          {
            flagHasStatistics = true;
            storeStatistics.Clear();
          }
        Debug.Assert(flagHasStatistics);
        storeStatistics.Add(to_append);
      }
    public void appendStatistics(SportsStatsTypeJSON.TypeValue new_value)
      {
        appendStatistics(new SportsStatsTypeJSON(new_value));
      }
    public void appendStatistics(string chars)
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
        appendStatistics(new_value);
      }
    public void unsetStatistics()
      {
        if (flagHasStatistics)
          {
            for (int num2 = 0; num2 < storeStatistics.Count; ++num2)
              {
              }
          }
        flagHasStatistics = false;
        storeStatistics.Clear();
      }
    public void setRank(BigInteger new_value)
      {
        flagHasRank = true;
        if (new_value < 1)
            throw new Exception("The value for field Rank of SportsLeagueLeadersQueryDataJSON is less than the lower bound (1) for that field.");
        storeRank = new_value;
      }
    public void unsetRank()
      {
        flagHasRank = false;
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
    public void initLeagueLeadersIndices()
      {
        if (flagHasLeagueLeadersIndices)
          {
            for (int num3 = 0; num3 < storeLeagueLeadersIndices.Count; ++num3)
              {
              }
          }
        flagHasLeagueLeadersIndices = true;
        storeLeagueLeadersIndices.Clear();
      }
    public void appendLeagueLeadersIndices(TypeLeagueLeadersIndicesJSON  to_append)
      {
        if (!flagHasLeagueLeadersIndices)
          {
            flagHasLeagueLeadersIndices = true;
            storeLeagueLeadersIndices.Clear();
          }
        Debug.Assert(flagHasLeagueLeadersIndices);
        storeLeagueLeadersIndices.Add(to_append);
      }
    public void unsetLeagueLeadersIndices()
      {
        if (flagHasLeagueLeadersIndices)
          {
            for (int num4 = 0; num4 < storeLeagueLeadersIndices.Count; ++num4)
              {
              }
          }
        flagHasLeagueLeadersIndices = false;
        storeLeagueLeadersIndices.Clear();
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

    public virtual void extraSportsLeagueLeadersQueryDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsLeagueLeadersQueryDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsLeagueLeadersQueryDataLookup(key);
        if (old_field == null)
          {
            extraSportsLeagueLeadersQueryDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStatistics);
        if (flagHasStatistics)
          {
            handler.start_pair("Statistics");
            Debug.Assert(storeStatistics.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeStatistics.Count; ++num1)
              {
                if (partial_allowed)
                    storeStatistics[num1].write_partial_as_json(handler);
                else
                    storeStatistics[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRank)
          {
            handler.start_pair("Rank");
            handler.number_value(storeRank);
          }
        if (flagHasSeason)
          {
            handler.start_pair("Season");
            if (partial_allowed)
                storeSeason.write_partial_as_json(handler);
            else
                storeSeason.write_as_json(handler);
          }
        if (flagHasLeagueLeadersIndices)
          {
            handler.start_pair("LeagueLeadersIndices");
            Debug.Assert(storeLeagueLeadersIndices.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeLeagueLeadersIndices.Count; ++num2)
              {
                if (partial_allowed)
                    storeLeagueLeadersIndices[num2].write_partial_as_json(handler);
                else
                    storeLeagueLeadersIndices[num2].write_as_json(handler);
              }
            handler.finish_array();
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
        if (!(hasLeague()))
          {
            return "When parsing the object for %what%, the \"League\" field was missing.";
          }
        if (!(hasTeamsOrPlayers()))
          {
            return "When parsing the object for %what%, the \"TeamsOrPlayers\" field was missing.";
          }
        if (!(hasStatistics()))
          {
            return "When parsing the object for %what%, the \"Statistics\" field was missing.";
          }
        return null;
      }

    public static SportsLeagueLeadersQueryDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueLeadersQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeadersQueryData", ignore_extras);
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
    public static SportsLeagueLeadersQueryDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueLeadersQueryDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsLeagueLeadersQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeadersQueryData", ignore_extras);
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
    public static SportsLeagueLeadersQueryDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsLeagueLeadersQueryDataJSON from_text(string text, bool ignore_extras)
      {
        SportsLeagueLeadersQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeadersQueryData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsLeagueLeadersQueryDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsLeagueLeadersQueryDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsLeagueLeadersQueryDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsLeagueLeadersQueryData", ignore_extras);
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
        private SportsStatsTypeJSON.HoldingArrayGenerator fieldGeneratorStatistics;
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
        private SportsSeasonResolvedJSON.HoldingGenerator fieldGeneratorSeason;
        private TypeLeagueLeadersIndicesJSON.HoldingArrayGenerator fieldGeneratorLeagueLeadersIndices;
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
            SportsLeagueLeadersQueryDataJSON result = new SportsLeagueLeadersQueryDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsLeagueLeadersQueryDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsLeagueLeadersQueryDataJSON result)
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
            if (fieldGeneratorTeamsOrPlayers.have_value)
              {
                result.setTeamsOrPlayers(fieldGeneratorTeamsOrPlayers.value);
                fieldGeneratorTeamsOrPlayers.have_value = false;
              }
            else if ((!(result.hasTeamsOrPlayers())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TeamsOrPlayers\" field was missing.");
              }
            if (fieldGeneratorStatistics.have_value)
              {
                result.initStatistics();
                int count = fieldGeneratorStatistics.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStatistics(fieldGeneratorStatistics.value[num]);
                  }
                fieldGeneratorStatistics.value.Clear();
                fieldGeneratorStatistics.have_value = false;
              }
            else if ((!(result.hasStatistics())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Statistics\" field was missing.");
              }
            if (fieldGeneratorRank.have_value)
              {
                result.setRank(fieldGeneratorRank.value);
                fieldGeneratorRank.have_value = false;
              }
            if (fieldGeneratorSeason.have_value)
              {
                result.setSeason(fieldGeneratorSeason.value);
                fieldGeneratorSeason.have_value = false;
              }
            if (fieldGeneratorLeagueLeadersIndices.have_value)
              {
                result.initLeagueLeadersIndices();
                int count = fieldGeneratorLeagueLeadersIndices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLeagueLeadersIndices(fieldGeneratorLeagueLeadersIndices.value[num]);
                  }
                fieldGeneratorLeagueLeadersIndices.value.Clear();
                fieldGeneratorLeagueLeadersIndices.have_value = false;
              }
            if (fieldGeneratorError.have_value)
              {
                result.setError(fieldGeneratorError.value);
                fieldGeneratorError.have_value = false;
              }
          }
        protected abstract void handle_result(SportsLeagueLeadersQueryDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ivision", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorDivision;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "rror", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorError;
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "eague", 0, 5, false) == 0)
                      {
                        if (field_name.Length == 6)
                          {
                            return fieldGeneratorLeague;
                          }
                        switch (field_name[6])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 7, "eadersIndices", 0, 13, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorLeagueLeadersIndices;
                                break;
                            default:
                                break;
                          }
                      }
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
                            if ((String.Compare(field_name, 2, "atistics", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorStatistics;
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
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsLeagueLeadersQueryData class", ignore_extras);
            fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the SportsLeagueLeadersQueryData class", ignore_extras);
            fieldGeneratorTeamsOrPlayers = new FieldHoldingGeneratorTeamsOrPlayers("field \"TeamsOrPlayers\" of the SportsLeagueLeadersQueryData class");
            fieldGeneratorStatistics = new SportsStatsTypeJSON.HoldingArrayGenerator("field \"Statistics\" of the SportsLeagueLeadersQueryData class", ignore_extras);
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsLeagueLeadersQueryData class");
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsLeagueLeadersQueryData class", ignore_extras);
            fieldGeneratorLeagueLeadersIndices = new TypeLeagueLeadersIndicesJSON.HoldingArrayGenerator("field \"LeagueLeadersIndices\" of the SportsLeagueLeadersQueryData class", ignore_extras);
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsLeagueLeadersQueryData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsLeagueLeadersQueryData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLeague = new SportsLeagueCodeJSON.HoldingGenerator("field \"League\" of the SportsLeagueLeadersQueryData class", false);
            fieldGeneratorDivision = new SportsLeagueDivisionJSON.HoldingGenerator("field \"Division\" of the SportsLeagueLeadersQueryData class", false);
            fieldGeneratorTeamsOrPlayers = new FieldHoldingGeneratorTeamsOrPlayers("field \"TeamsOrPlayers\" of the SportsLeagueLeadersQueryData class");
            fieldGeneratorStatistics = new SportsStatsTypeJSON.HoldingArrayGenerator("field \"Statistics\" of the SportsLeagueLeadersQueryData class", false);
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsLeagueLeadersQueryData class");
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsLeagueLeadersQueryData class", false);
            fieldGeneratorLeagueLeadersIndices = new TypeLeagueLeadersIndicesJSON.HoldingArrayGenerator("field \"LeagueLeadersIndices\" of the SportsLeagueLeadersQueryData class", false);
            fieldGeneratorError = new FieldHoldingGeneratorError("field \"Error\" of the SportsLeagueLeadersQueryData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsLeagueLeadersQueryData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLeague.reset();
            fieldGeneratorDivision.reset();
            fieldGeneratorTeamsOrPlayers.reset();
            fieldGeneratorStatistics.reset();
            fieldGeneratorRank.reset();
            fieldGeneratorSeason.reset();
            fieldGeneratorLeagueLeadersIndices.reset();
            fieldGeneratorError.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLeague.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDivision.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStatistics.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeason.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLeagueLeadersIndices.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLeague.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDivision.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStatistics.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeason.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLeagueLeadersIndices.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsLeagueLeadersQueryDataJSON  result)
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
        public SportsLeagueLeadersQueryDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsLeagueLeadersQueryDataJSON  result)
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
    protected virtual void handle_result(List<SportsLeagueLeadersQueryDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsLeagueLeadersQueryDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsLeagueLeadersQueryDataJSON>();
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
    public List<SportsLeagueLeadersQueryDataJSON> value;
  };
  };
