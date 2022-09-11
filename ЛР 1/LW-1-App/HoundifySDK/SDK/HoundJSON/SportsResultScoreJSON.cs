/* file "SportsResultScoreJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public abstract class SportsResultScoreJSON : JSONBase
  {
    public enum TypeGameStatusKnownValues
      {
        GameStatus_Unknown,
        GameStatus_Scheduled,
        GameStatus_InProgress,
        GameStatus_Complete,
        GameStatus_Other,
        GameStatus_Delayed,
        GameStatus_DelayedWeather,
        GameStatus_DelayedFacility,
        GameStatus_Postponed,
        GameStatus_Suspended,
        GameStatus_Canceled,
        GameStatus_Unnecessary,
        GameStatus_ScheduledFlex,
        GameStatus_ScheduledTimeTBD,
        GameStatus__none
      };
    public struct TypeGameStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeGameStatusKnownValues list_value;
      };

    public static TypeGameStatusKnownValues  stringToGameStatus(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "nceled", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeGameStatusKnownValues.GameStatus_Canceled;
                        break;
                    case 'o':
                        if ((String.Compare(chars, 2, "mplete", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeGameStatusKnownValues.GameStatus_Complete;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if (String.Compare(chars, 1, "elayed", 0, 6, false) == 0)
                  {
                    if (chars.Length == 7)
                      {
                        return TypeGameStatusKnownValues.GameStatus_Delayed;
                      }
                    switch (chars[7])
                      {
                        case 'F':
                            if ((String.Compare(chars, 8, "acility", 0, 7, false) == 0) && (chars.Length == 15))
                                return TypeGameStatusKnownValues.GameStatus_DelayedFacility;
                            break;
                        case 'W':
                            if ((String.Compare(chars, 8, "eather", 0, 6, false) == 0) && (chars.Length == 14))
                                return TypeGameStatusKnownValues.GameStatus_DelayedWeather;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nProgress", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeGameStatusKnownValues.GameStatus_InProgress;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "ther", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeGameStatusKnownValues.GameStatus_Other;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "ostponed", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeGameStatusKnownValues.GameStatus_Postponed;
                break;
            case 'S':
                switch (chars[1])
                  {
                    case 'c':
                        if (String.Compare(chars, 2, "heduled", 0, 7, false) == 0)
                          {
                            if (chars.Length == 9)
                              {
                                return TypeGameStatusKnownValues.GameStatus_Scheduled;
                              }
                            switch (chars[9])
                              {
                                case 'F':
                                    if ((String.Compare(chars, 10, "lex", 0, 3, false) == 0) && (chars.Length == 13))
                                        return TypeGameStatusKnownValues.GameStatus_ScheduledFlex;
                                    break;
                                case 'T':
                                    if ((String.Compare(chars, 10, "imeTBD", 0, 6, false) == 0) && (chars.Length == 16))
                                        return TypeGameStatusKnownValues.GameStatus_ScheduledTimeTBD;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "spended", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeGameStatusKnownValues.GameStatus_Suspended;
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if (String.Compare(chars, 1, "n", 0, 1, false) == 0)
                  {
                    switch (chars[2])
                      {
                        case 'k':
                            if ((String.Compare(chars, 3, "nown", 0, 4, false) == 0) && (chars.Length == 7))
                                return TypeGameStatusKnownValues.GameStatus_Unknown;
                            break;
                        case 'n':
                            if ((String.Compare(chars, 3, "ecessary", 0, 8, false) == 0) && (chars.Length == 11))
                                return TypeGameStatusKnownValues.GameStatus_Unnecessary;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return TypeGameStatusKnownValues.GameStatus__none;
      }

    public static string  stringFromGameStatus(TypeGameStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeGameStatusKnownValues.GameStatus_Unknown:
                return "Unknown";
            case TypeGameStatusKnownValues.GameStatus_Scheduled:
                return "Scheduled";
            case TypeGameStatusKnownValues.GameStatus_InProgress:
                return "InProgress";
            case TypeGameStatusKnownValues.GameStatus_Complete:
                return "Complete";
            case TypeGameStatusKnownValues.GameStatus_Other:
                return "Other";
            case TypeGameStatusKnownValues.GameStatus_Delayed:
                return "Delayed";
            case TypeGameStatusKnownValues.GameStatus_DelayedWeather:
                return "DelayedWeather";
            case TypeGameStatusKnownValues.GameStatus_DelayedFacility:
                return "DelayedFacility";
            case TypeGameStatusKnownValues.GameStatus_Postponed:
                return "Postponed";
            case TypeGameStatusKnownValues.GameStatus_Suspended:
                return "Suspended";
            case TypeGameStatusKnownValues.GameStatus_Canceled:
                return "Canceled";
            case TypeGameStatusKnownValues.GameStatus_Unnecessary:
                return "Unnecessary";
            case TypeGameStatusKnownValues.GameStatus_ScheduledFlex:
                return "ScheduledFlex";
            case TypeGameStatusKnownValues.GameStatus_ScheduledTimeTBD:
                return "ScheduledTimeTBD";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeSportsResultTypeKnownValues
      {
        SportsResultType_Primary,
        SportsResultType_Secondary,
        SportsResultType__none
      };
    public struct TypeSportsResultType
      {
        public bool in_known_list;
        public string string_value;
        public TypeSportsResultTypeKnownValues list_value;
      };

    public static TypeSportsResultTypeKnownValues  stringToSportsResultType(string chars)
      {
        switch (chars[0])
          {
            case 'P':
                if ((String.Compare(chars, 1, "rimary", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeSportsResultTypeKnownValues.SportsResultType_Primary;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "econdary", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeSportsResultTypeKnownValues.SportsResultType_Secondary;
                break;
            default:
                break;
          }
        return TypeSportsResultTypeKnownValues.SportsResultType__none;
      }

    public static string  stringFromSportsResultType(TypeSportsResultTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeSportsResultTypeKnownValues.SportsResultType_Primary:
                return "Primary";
            case TypeSportsResultTypeKnownValues.SportsResultType_Secondary:
                return "Secondary";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public class TypePlayersJSON : JSONBase
      {
        private bool flagHasPlayer;
        private SportsPlayerJSON  storePlayer;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONPlayer(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsPlayerJSON convert_classy = SportsPlayerJSON.from_json(json_value, ignore_extras, true);
            setPlayer(convert_classy);
          }


        public TypePlayersJSON()
          {
            flagHasPlayer = false;
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasPlayer()
          {
            return flagHasPlayer;
          }

        public SportsPlayerJSON   getPlayer()
          {
            Debug.Assert(flagHasPlayer);
            return storePlayer;
          }


        public virtual int extraTypePlayersComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypePlayersComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypePlayersComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypePlayersLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setPlayer(SportsPlayerJSON  new_value)
          {
            if (flagHasPlayer)
              {
              }
            flagHasPlayer = true;
            storePlayer = new_value;
          }
        public void unsetPlayer()
          {
            if (flagHasPlayer)
              {
              }
            flagHasPlayer = false;
          }

        public virtual void extraTypePlayersAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypePlayersSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypePlayersLookup(key);
            if (old_field == null)
              {
                extraTypePlayersAppendPair(key, new_component);
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
            Debug.Assert(partial_allowed || flagHasPlayer);
            if (flagHasPlayer)
              {
                handler.start_pair("Player");
                if (partial_allowed)
                    storePlayer.write_partial_as_json(handler);
                else
                    storePlayer.write_as_json(handler);
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
            if (!(hasPlayer()))
              {
                return "When parsing the object for %what%, the \"Player\" field was missing.";
              }
            return null;
          }

        public static TypePlayersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePlayersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
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
        public static TypePlayersJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePlayersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypePlayersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
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
        public static TypePlayersJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypePlayersJSON from_text(string text, bool ignore_extras)
          {
            TypePlayersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypePlayersJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypePlayersJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypePlayersJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypePlayers", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
            private SportsPlayerJSON.HoldingGenerator fieldGeneratorPlayer;
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
                TypePlayersJSON result = new TypePlayersJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypePlayersAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypePlayersJSON result)
              {
                if (fieldGeneratorPlayer.have_value)
                  {
                    result.setPlayer(fieldGeneratorPlayer.value);
                    fieldGeneratorPlayer.have_value = false;
                  }
                else if ((!(result.hasPlayer())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Player\" field was missing.");
                  }
              }
            protected abstract void handle_result(TypePlayersJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                if ((String.Compare(field_name, 0, "Player", 0, 6, false) == 0) && (field_name.Length == 6))
                    return fieldGeneratorPlayer;
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorPlayer = new SportsPlayerJSON.HoldingGenerator("field \"Player\" of the TypePlayers class", ignore_extras);
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypePlayers class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorPlayer = new SportsPlayerJSON.HoldingGenerator("field \"Player\" of the TypePlayers class", false);
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypePlayers class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorPlayer.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorPlayer.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorPlayer.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypePlayersJSON  result)
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
            public TypePlayersJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypePlayersJSON  result)
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
        protected virtual void handle_result(List<TypePlayersJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypePlayersJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypePlayersJSON>();
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
        public List<TypePlayersJSON> value;
      };
      };
    private bool flagHasTeams;
    private List< SportsTeamJSON  > storeTeams;
    private bool flagHasGameStartTime;
    private DateAndOrTimeJSON  storeGameStartTime;
    private bool flagHasGameStatus;
    private TypeGameStatus storeGameStatus;
    private bool flagHasQuarterInningPeriod;
    private BigInteger storeQuarterInningPeriod;
    private bool flagHasQuarterInningPeriodClock;
    private string storeQuarterInningPeriodClock;
    private bool flagHasVenue;
    private SportsVenueJSON  storeVenue;
    private bool flagHasBroadcastNetwork;
    private string storeBroadcastNetwork;
    private bool flagHasSportsResultType;
    private TypeSportsResultType storeSportsResultType;
    private bool flagHasPlayoffs;
    private bool storePlayoffs;
    private bool flagHasPlayoffGame;
    private string storePlayoffGame;
    private bool flagHasPlayoffType;
    private SportsPlayoffSpecialGameJSON  storePlayoffType;
    private bool flagHasTournament;
    private SportsTournamentJSON  storeTournament;
    private bool flagHasPreSeason;
    private bool storePreSeason;
    private bool flagHasGameID;
    private string storeGameID;
    private bool flagHasSportImage;
    private SportsSportImageJSON  storeSportImage;
    private bool flagHasPlayers;
    private List< TypePlayersJSON  > storePlayers;
    private bool flagHasGameStatistics;
    private SportsGameStatisticsJSON  storeGameStatistics;


    private void  fromJSONTeams(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Teams of SportsResultScoreJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field Teams of SportsResultScoreJSON has too few elements.");
        List< SportsTeamJSON  > vector_Teams1 = new List< SportsTeamJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsTeamJSON convert_classy = SportsTeamJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Teams1.Add(convert_classy);
          }
        Debug.Assert(vector_Teams1.Count >= 2);
        initTeams();
        for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
            appendTeams(vector_Teams1[num1]);
        for (int num1 = 0; num1 < vector_Teams1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGameStartTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setGameStartTime(convert_classy);
      }


    private void  fromJSONGameStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field GameStatus of SportsResultScoreJSON is not a string.");
        TypeGameStatus the_open_enum = new TypeGameStatus();
        switch (json_string.getData()[0])
          {
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "nceled", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_Canceled;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'o':
                        if ((String.Compare(json_string.getData(), 2, "mplete", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_Complete;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if (String.Compare(json_string.getData(), 1, "elayed", 0, 6, false) == 0)
                  {
                    if (json_string.getData().Length == 7)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_Delayed;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[7])
                      {
                        case 'F':
                            if ((String.Compare(json_string.getData(), 8, "acility", 0, 7, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_DelayedFacility;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'W':
                            if ((String.Compare(json_string.getData(), 8, "eather", 0, 6, false) == 0) && (json_string.getData().Length == 14))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_DelayedWeather;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nProgress", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_InProgress;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "ther", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_Other;
                        goto open_enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "ostponed", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_Postponed;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                switch (json_string.getData()[1])
                  {
                    case 'c':
                        if (String.Compare(json_string.getData(), 2, "heduled", 0, 7, false) == 0)
                          {
                            if (json_string.getData().Length == 9)
                              {
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_Scheduled;
                                    goto open_enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[9])
                              {
                                case 'F':
                                    if ((String.Compare(json_string.getData(), 10, "lex", 0, 3, false) == 0) && (json_string.getData().Length == 13))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_ScheduledFlex;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'T':
                                    if ((String.Compare(json_string.getData(), 10, "imeTBD", 0, 6, false) == 0) && (json_string.getData().Length == 16))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_ScheduledTimeTBD;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "spended", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_Suspended;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'U':
                if (String.Compare(json_string.getData(), 1, "n", 0, 1, false) == 0)
                  {
                    switch (json_string.getData()[2])
                      {
                        case 'k':
                            if ((String.Compare(json_string.getData(), 3, "nown", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_Unknown;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'n':
                            if ((String.Compare(json_string.getData(), 3, "ecessary", 0, 8, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeGameStatusKnownValues.GameStatus_Unnecessary;
                                    goto open_enum_is_done;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setGameStatus(the_open_enum);
      }


    private void  fromJSONQuarterInningPeriod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field QuarterInningPeriod of SportsResultScoreJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field QuarterInningPeriod of SportsResultScoreJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setQuarterInningPeriod(extracted_integer);
      }


    private void  fromJSONQuarterInningPeriodClock(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QuarterInningPeriodClock of SportsResultScoreJSON is not a string.");
        setQuarterInningPeriodClock(json_string.getData());
      }


    private void  fromJSONVenue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsVenueJSON convert_classy = SportsVenueJSON.from_json(json_value, ignore_extras, true);
        setVenue(convert_classy);
      }


    private void  fromJSONBroadcastNetwork(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BroadcastNetwork of SportsResultScoreJSON is not a string.");
        setBroadcastNetwork(json_string.getData());
      }


    private void  fromJSONSportsResultType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SportsResultType of SportsResultScoreJSON is not a string.");
        TypeSportsResultType the_open_enum = new TypeSportsResultType();
        switch (json_string.getData()[0])
          {
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "rimary", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSportsResultTypeKnownValues.SportsResultType_Primary;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "econdary", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeSportsResultTypeKnownValues.SportsResultType_Secondary;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setSportsResultType(the_open_enum);
      }


    private void  fromJSONPlayoffs(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Playoffs of SportsResultScoreJSON is not true for false.");
              }
          }
        setPlayoffs(the_bool);
      }


    private void  fromJSONPlayoffGame(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PlayoffGame of SportsResultScoreJSON is not a string.");
        setPlayoffGame(json_string.getData());
      }


    private void  fromJSONPlayoffType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsPlayoffSpecialGameJSON convert_classy = SportsPlayoffSpecialGameJSON.from_json(json_value, ignore_extras, true);
        setPlayoffType(convert_classy);
      }


    private void  fromJSONTournament(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsTournamentJSON convert_classy = SportsTournamentJSON.from_json(json_value, ignore_extras, true);
        setTournament(convert_classy);
      }


    private void  fromJSONPreSeason(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PreSeason of SportsResultScoreJSON is not true for false.");
              }
          }
        setPreSeason(the_bool);
      }


    private void  fromJSONGameID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field GameID of SportsResultScoreJSON is not a string.");
        setGameID(json_string.getData());
      }


    private void  fromJSONSportImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSportImageJSON convert_classy = SportsSportImageJSON.from_json(json_value, ignore_extras, true);
        setSportImage(convert_classy);
      }


    private void  fromJSONPlayers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Players of SportsResultScoreJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypePlayersJSON  > vector_Players1 = new List< TypePlayersJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypePlayersJSON convert_classy = TypePlayersJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Players1.Add(convert_classy);
          }
        initPlayers();
        for (int num2 = 0; num2 < vector_Players1.Count; ++num2)
            appendPlayers(vector_Players1[num2]);
        for (int num1 = 0; num1 < vector_Players1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGameStatistics(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsGameStatisticsJSON convert_classy = SportsGameStatisticsJSON.from_json(json_value, ignore_extras, true);
        setGameStatistics(convert_classy);
      }


    public SportsResultScoreJSON()
      {
        flagHasTeams = false;
        flagHasGameStartTime = false;
        flagHasGameStatus = false;
        flagHasQuarterInningPeriod = false;
        flagHasQuarterInningPeriodClock = false;
        flagHasVenue = false;
        flagHasBroadcastNetwork = false;
        flagHasSportsResultType = false;
        flagHasPlayoffs = false;
        flagHasPlayoffGame = false;
        flagHasPlayoffType = false;
        flagHasTournament = false;
        flagHasPreSeason = false;
        flagHasGameID = false;
        flagHasSportImage = false;
        flagHasPlayers = false;
        flagHasGameStatistics = false;
        storeTeams = new List< SportsTeamJSON  >();
        storePlayers = new List< TypePlayersJSON  >();
      }

    public abstract string getSportsResultScoreKind();
    public bool  hasTeams()
      {
        return flagHasTeams;
      }

    public int  countOfTeams()
      {
        Debug.Assert(flagHasTeams);
        return storeTeams.Count;
      }

    public SportsTeamJSON   elementOfTeams(int element_num)
      {
        Debug.Assert(flagHasTeams);
        return storeTeams[element_num];
      }

    public List< SportsTeamJSON  >  getTeams()
      {
        Debug.Assert(flagHasTeams);
        return storeTeams;
      }

    public bool  hasGameStartTime()
      {
        return flagHasGameStartTime;
      }

    public DateAndOrTimeJSON   getGameStartTime()
      {
        Debug.Assert(flagHasGameStartTime);
        return storeGameStartTime;
      }

    public bool  hasGameStatus()
      {
        return flagHasGameStatus;
      }

    public TypeGameStatus  getGameStatus()
      {
        Debug.Assert(flagHasGameStatus);
        return storeGameStatus;
      }

    public string  getGameStatusAsString()
      {
        TypeGameStatus result = getGameStatus();
        if (result.in_known_list)
            return stringFromGameStatus(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasQuarterInningPeriod()
      {
        return flagHasQuarterInningPeriod;
      }

    public BigInteger  getQuarterInningPeriod()
      {
        Debug.Assert(flagHasQuarterInningPeriod);
        return storeQuarterInningPeriod;
      }

    public bool  hasQuarterInningPeriodClock()
      {
        return flagHasQuarterInningPeriodClock;
      }

    public string  getQuarterInningPeriodClock()
      {
        Debug.Assert(flagHasQuarterInningPeriodClock);
        return storeQuarterInningPeriodClock;
      }

    public bool  hasVenue()
      {
        return flagHasVenue;
      }

    public SportsVenueJSON   getVenue()
      {
        Debug.Assert(flagHasVenue);
        return storeVenue;
      }

    public bool  hasBroadcastNetwork()
      {
        return flagHasBroadcastNetwork;
      }

    public string  getBroadcastNetwork()
      {
        Debug.Assert(flagHasBroadcastNetwork);
        return storeBroadcastNetwork;
      }

    public bool  hasSportsResultType()
      {
        return flagHasSportsResultType;
      }

    public TypeSportsResultType  getSportsResultType()
      {
        Debug.Assert(flagHasSportsResultType);
        return storeSportsResultType;
      }

    public string  getSportsResultTypeAsString()
      {
        TypeSportsResultType result = getSportsResultType();
        if (result.in_known_list)
            return stringFromSportsResultType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasPlayoffs()
      {
        return flagHasPlayoffs;
      }

    public bool  getPlayoffs()
      {
        Debug.Assert(flagHasPlayoffs);
        return storePlayoffs;
      }

    public bool  hasPlayoffGame()
      {
        return flagHasPlayoffGame;
      }

    public string  getPlayoffGame()
      {
        Debug.Assert(flagHasPlayoffGame);
        return storePlayoffGame;
      }

    public bool  hasPlayoffType()
      {
        return flagHasPlayoffType;
      }

    public SportsPlayoffSpecialGameJSON   getPlayoffType()
      {
        Debug.Assert(flagHasPlayoffType);
        return storePlayoffType;
      }

    public SportsPlayoffSpecialGameJSON.TypeValue  getPlayoffTypeValue()
      {
        return getPlayoffType().getValue();
      }

    public string  getPlayoffTypeAsString()
      {
        return getPlayoffType().getValueAsString();
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

    public bool  hasPreSeason()
      {
        return flagHasPreSeason;
      }

    public bool  getPreSeason()
      {
        Debug.Assert(flagHasPreSeason);
        return storePreSeason;
      }

    public bool  hasGameID()
      {
        return flagHasGameID;
      }

    public string  getGameID()
      {
        Debug.Assert(flagHasGameID);
        return storeGameID;
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

    public bool  hasPlayers()
      {
        return flagHasPlayers;
      }

    public int  countOfPlayers()
      {
        Debug.Assert(flagHasPlayers);
        return storePlayers.Count;
      }

    public TypePlayersJSON   elementOfPlayers(int element_num)
      {
        Debug.Assert(flagHasPlayers);
        return storePlayers[element_num];
      }

    public List< TypePlayersJSON  >  getPlayers()
      {
        Debug.Assert(flagHasPlayers);
        return storePlayers;
      }

    public bool  hasGameStatistics()
      {
        return flagHasGameStatistics;
      }

    public SportsGameStatisticsJSON   getGameStatistics()
      {
        Debug.Assert(flagHasGameStatistics);
        return storeGameStatistics;
      }


    public abstract int extraSportsResultScoreComponentCount();
    public abstract string extraSportsResultScoreComponentKey(int component_num);
    public abstract JSONValue extraSportsResultScoreComponentValue(int component_num);
    public abstract JSONValue extraSportsResultScoreLookup(string field_name);

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
    public void appendTeams(SportsTeamJSON  to_append)
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
    public void setGameStartTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasGameStartTime)
          {
          }
        flagHasGameStartTime = true;
        storeGameStartTime = new_value;
      }
    public void unsetGameStartTime()
      {
        if (flagHasGameStartTime)
          {
          }
        flagHasGameStartTime = false;
      }
    public void setGameStatus(TypeGameStatus new_value)
      {
        flagHasGameStatus = true;
        storeGameStatus = new_value;
      }
    public void setGameStatus(string chars)
      {
        TypeGameStatusKnownValues known = stringToGameStatus(chars);
        TypeGameStatus new_value = new TypeGameStatus();
        if (known == TypeGameStatusKnownValues.GameStatus__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setGameStatus(new_value);
      }
    public void setGameStatus(TypeGameStatusKnownValues new_value)
      {
        TypeGameStatus new_full_value = new TypeGameStatus();
        Debug.Assert(new_value != TypeGameStatusKnownValues.GameStatus__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setGameStatus(new_full_value);
      }
    public void unsetGameStatus()
      {
        flagHasGameStatus = false;
      }
    public void setQuarterInningPeriod(BigInteger new_value)
      {
        flagHasQuarterInningPeriod = true;
        if (new_value < 0)
            throw new Exception("The value for field QuarterInningPeriod of SportsResultScoreJSON is less than the lower bound (0) for that field.");
        storeQuarterInningPeriod = new_value;
      }
    public void unsetQuarterInningPeriod()
      {
        flagHasQuarterInningPeriod = false;
      }
    public void setQuarterInningPeriodClock(string new_value)
      {
        flagHasQuarterInningPeriodClock = true;
        storeQuarterInningPeriodClock = new_value;
      }
    public void unsetQuarterInningPeriodClock()
      {
        flagHasQuarterInningPeriodClock = false;
      }
    public void setVenue(SportsVenueJSON  new_value)
      {
        if (flagHasVenue)
          {
          }
        flagHasVenue = true;
        storeVenue = new_value;
      }
    public void unsetVenue()
      {
        if (flagHasVenue)
          {
          }
        flagHasVenue = false;
      }
    public void setBroadcastNetwork(string new_value)
      {
        flagHasBroadcastNetwork = true;
        storeBroadcastNetwork = new_value;
      }
    public void unsetBroadcastNetwork()
      {
        flagHasBroadcastNetwork = false;
      }
    public void setSportsResultType(TypeSportsResultType new_value)
      {
        flagHasSportsResultType = true;
        storeSportsResultType = new_value;
      }
    public void setSportsResultType(string chars)
      {
        TypeSportsResultTypeKnownValues known = stringToSportsResultType(chars);
        TypeSportsResultType new_value = new TypeSportsResultType();
        if (known == TypeSportsResultTypeKnownValues.SportsResultType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSportsResultType(new_value);
      }
    public void setSportsResultType(TypeSportsResultTypeKnownValues new_value)
      {
        TypeSportsResultType new_full_value = new TypeSportsResultType();
        Debug.Assert(new_value != TypeSportsResultTypeKnownValues.SportsResultType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setSportsResultType(new_full_value);
      }
    public void unsetSportsResultType()
      {
        flagHasSportsResultType = false;
      }
    public void setPlayoffs(bool new_value)
      {
        flagHasPlayoffs = true;
        storePlayoffs = new_value;
      }
    public void unsetPlayoffs()
      {
        flagHasPlayoffs = false;
      }
    public void setPlayoffGame(string new_value)
      {
        flagHasPlayoffGame = true;
        storePlayoffGame = new_value;
      }
    public void unsetPlayoffGame()
      {
        flagHasPlayoffGame = false;
      }
    public void setPlayoffType(SportsPlayoffSpecialGameJSON  new_value)
      {
        if (flagHasPlayoffType)
          {
          }
        flagHasPlayoffType = true;
        storePlayoffType = new_value;
      }
    public void setPlayoffType(SportsPlayoffSpecialGameJSON.TypeValue new_value)
      {
        setPlayoffType(new SportsPlayoffSpecialGameJSON(new_value));
      }
    public void setPlayoffType(string chars)
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
        setPlayoffType(new_value);
      }
    public void unsetPlayoffType()
      {
        if (flagHasPlayoffType)
          {
          }
        flagHasPlayoffType = false;
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
    public void setPreSeason(bool new_value)
      {
        flagHasPreSeason = true;
        storePreSeason = new_value;
      }
    public void unsetPreSeason()
      {
        flagHasPreSeason = false;
      }
    public void setGameID(string new_value)
      {
        flagHasGameID = true;
        storeGameID = new_value;
      }
    public void unsetGameID()
      {
        flagHasGameID = false;
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
    public void initPlayers()
      {
        if (flagHasPlayers)
          {
            for (int num3 = 0; num3 < storePlayers.Count; ++num3)
              {
              }
          }
        flagHasPlayers = true;
        storePlayers.Clear();
      }
    public void appendPlayers(TypePlayersJSON  to_append)
      {
        if (!flagHasPlayers)
          {
            flagHasPlayers = true;
            storePlayers.Clear();
          }
        Debug.Assert(flagHasPlayers);
        storePlayers.Add(to_append);
      }
    public void unsetPlayers()
      {
        if (flagHasPlayers)
          {
            for (int num4 = 0; num4 < storePlayers.Count; ++num4)
              {
              }
          }
        flagHasPlayers = false;
        storePlayers.Clear();
      }
    public void setGameStatistics(SportsGameStatisticsJSON  new_value)
      {
        if (flagHasGameStatistics)
          {
          }
        flagHasGameStatistics = true;
        storeGameStatistics = new_value;
      }
    public void unsetGameStatistics()
      {
        if (flagHasGameStatistics)
          {
          }
        flagHasGameStatistics = false;
      }

    public abstract void extraSportsResultScoreAppendPair(string key, JSONValue new_component);
    public abstract void extraSportsResultScoreSetField(string key, JSONValue new_component);

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public virtual void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        handler.pair("SportsResultScoreKind", getSportsResultScoreKind());
        if (flagHasTeams)
          {
            handler.start_pair("Teams");
            Debug.Assert(storeTeams.Count >= 2);
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
        if (flagHasGameStartTime)
          {
            handler.start_pair("GameStartTime");
            if (partial_allowed)
                storeGameStartTime.write_partial_as_json(handler);
            else
                storeGameStartTime.write_as_json(handler);
          }
        if (flagHasGameStatus)
          {
            handler.start_pair("GameStatus");
            if (storeGameStatus.in_known_list)
              {
                switch (storeGameStatus.list_value)
                  {
                    case TypeGameStatusKnownValues.GameStatus_Unknown:
                        handler.string_value("Unknown");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_Scheduled:
                        handler.string_value("Scheduled");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_InProgress:
                        handler.string_value("InProgress");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_Complete:
                        handler.string_value("Complete");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_Other:
                        handler.string_value("Other");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_Delayed:
                        handler.string_value("Delayed");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_DelayedWeather:
                        handler.string_value("DelayedWeather");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_DelayedFacility:
                        handler.string_value("DelayedFacility");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_Postponed:
                        handler.string_value("Postponed");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_Suspended:
                        handler.string_value("Suspended");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_Canceled:
                        handler.string_value("Canceled");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_Unnecessary:
                        handler.string_value("Unnecessary");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_ScheduledFlex:
                        handler.string_value("ScheduledFlex");
                        break;
                    case TypeGameStatusKnownValues.GameStatus_ScheduledTimeTBD:
                        handler.string_value("ScheduledTimeTBD");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeGameStatus.string_value);
              }
          }
        if (flagHasQuarterInningPeriod)
          {
            handler.start_pair("QuarterInningPeriod");
            handler.number_value(storeQuarterInningPeriod);
          }
        if (flagHasQuarterInningPeriodClock)
          {
            handler.start_pair("QuarterInningPeriodClock");
            handler.string_value(storeQuarterInningPeriodClock);
          }
        if (flagHasVenue)
          {
            handler.start_pair("Venue");
            if (partial_allowed)
                storeVenue.write_partial_as_json(handler);
            else
                storeVenue.write_as_json(handler);
          }
        if (flagHasBroadcastNetwork)
          {
            handler.start_pair("BroadcastNetwork");
            handler.string_value(storeBroadcastNetwork);
          }
        if (flagHasSportsResultType)
          {
            handler.start_pair("SportsResultType");
            if (storeSportsResultType.in_known_list)
              {
                switch (storeSportsResultType.list_value)
                  {
                    case TypeSportsResultTypeKnownValues.SportsResultType_Primary:
                        handler.string_value("Primary");
                        break;
                    case TypeSportsResultTypeKnownValues.SportsResultType_Secondary:
                        handler.string_value("Secondary");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeSportsResultType.string_value);
              }
          }
        if (flagHasPlayoffs)
          {
            handler.start_pair("Playoffs");
            handler.boolean_value(storePlayoffs);
          }
        if (flagHasPlayoffGame)
          {
            handler.start_pair("PlayoffGame");
            handler.string_value(storePlayoffGame);
          }
        if (flagHasPlayoffType)
          {
            handler.start_pair("PlayoffType");
            if (partial_allowed)
                storePlayoffType.write_partial_as_json(handler);
            else
                storePlayoffType.write_as_json(handler);
          }
        if (flagHasTournament)
          {
            handler.start_pair("Tournament");
            if (partial_allowed)
                storeTournament.write_partial_as_json(handler);
            else
                storeTournament.write_as_json(handler);
          }
        if (flagHasPreSeason)
          {
            handler.start_pair("PreSeason");
            handler.boolean_value(storePreSeason);
          }
        if (flagHasGameID)
          {
            handler.start_pair("GameID");
            handler.string_value(storeGameID);
          }
        if (flagHasSportImage)
          {
            handler.start_pair("SportImage");
            if (partial_allowed)
                storeSportImage.write_partial_as_json(handler);
            else
                storeSportImage.write_as_json(handler);
          }
        if (flagHasPlayers)
          {
            handler.start_pair("Players");
            handler.start_array();
            for (int num2 = 0; num2 < storePlayers.Count; ++num2)
              {
                if (partial_allowed)
                    storePlayers[num2].write_partial_as_json(handler);
                else
                    storePlayers[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasGameStatistics)
          {
            handler.start_pair("GameStatistics");
            if (partial_allowed)
                storeGameStatistics.write_partial_as_json(handler);
            else
                storeGameStatistics.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public virtual string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static SportsResultScoreJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsResultScoreJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsResultScore", ignore_extras);
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
    public static SportsResultScoreJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsResultScoreJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsResultScoreJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsResultScore", ignore_extras);
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
    public static SportsResultScoreJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsResultScoreJSON from_text(string text, bool ignore_extras)
      {
        SportsResultScoreJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsResultScore", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsResultScoreJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsResultScoreJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsResultScoreJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsResultScore", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsTeamJSON.HoldingArrayGenerator fieldGeneratorTeams;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorGameStartTime;
    private abstract class FieldGeneratorGameStatus : JSONStringGenerator
          {
            protected FieldGeneratorGameStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorGameStatus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeGameStatusKnownValues known = stringToGameStatus(result);
                TypeGameStatus new_value = new TypeGameStatus();
                if (known == TypeGameStatusKnownValues.GameStatus__none)
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
            protected abstract void handle_result(TypeGameStatus result);
          };
    private class FieldHoldingGeneratorGameStatus : FieldGeneratorGameStatus
  {
    protected override void handle_result(TypeGameStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorGameStatus(String what)
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
    public TypeGameStatus value;
  };
    private class FieldHoldingArrayGeneratorGameStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorGameStatus
      {
        private FieldHoldingArrayGeneratorGameStatus top;

        protected override void handle_result(TypeGameStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorGameStatus init_top)
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
    protected virtual void handle_result(List<TypeGameStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorGameStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeGameStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorGameStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeGameStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeGameStatus> value;
  };
        private FieldHoldingGeneratorGameStatus fieldGeneratorGameStatus;
    private class FieldHoldingGeneratorQuarterInningPeriod : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorQuarterInningPeriod(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorQuarterInningPeriod : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorQuarterInningPeriod(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorQuarterInningPeriod fieldGeneratorQuarterInningPeriod;
        private JSONHoldingStringGenerator fieldGeneratorQuarterInningPeriodClock;
        private SportsVenueJSON.HoldingGenerator fieldGeneratorVenue;
        private JSONHoldingStringGenerator fieldGeneratorBroadcastNetwork;
    private abstract class FieldGeneratorSportsResultType : JSONStringGenerator
          {
            protected FieldGeneratorSportsResultType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSportsResultType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeSportsResultTypeKnownValues known = stringToSportsResultType(result);
                TypeSportsResultType new_value = new TypeSportsResultType();
                if (known == TypeSportsResultTypeKnownValues.SportsResultType__none)
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
            protected abstract void handle_result(TypeSportsResultType result);
          };
    private class FieldHoldingGeneratorSportsResultType : FieldGeneratorSportsResultType
  {
    protected override void handle_result(TypeSportsResultType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSportsResultType(String what)
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
    public TypeSportsResultType value;
  };
    private class FieldHoldingArrayGeneratorSportsResultType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSportsResultType
      {
        private FieldHoldingArrayGeneratorSportsResultType top;

        protected override void handle_result(TypeSportsResultType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSportsResultType init_top)
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
    protected virtual void handle_result(List<TypeSportsResultType> result)
      {
      }

    public FieldHoldingArrayGeneratorSportsResultType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSportsResultType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSportsResultType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSportsResultType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSportsResultType> value;
  };
        private FieldHoldingGeneratorSportsResultType fieldGeneratorSportsResultType;
        private JSONHoldingBooleanGenerator fieldGeneratorPlayoffs;
        private JSONHoldingStringGenerator fieldGeneratorPlayoffGame;
        private SportsPlayoffSpecialGameJSON.HoldingGenerator fieldGeneratorPlayoffType;
        private SportsTournamentJSON.HoldingGenerator fieldGeneratorTournament;
        private JSONHoldingBooleanGenerator fieldGeneratorPreSeason;
        private JSONHoldingStringGenerator fieldGeneratorGameID;
        private SportsSportImageJSON.HoldingGenerator fieldGeneratorSportImage;
        private TypePlayersJSON.HoldingArrayGenerator fieldGeneratorPlayers;
        private SportsGameStatisticsJSON.HoldingGenerator fieldGeneratorGameStatistics;
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
        private JSONHoldingStringGenerator keyGenerator;

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
            if (!(keyGenerator.have_value))
                throw new Exception("The `SportsResultScoreKind' field is missing.");
            SportsResultScoreJSON result = createForKey(keyGenerator.value, unknownFieldGenerator.index);
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsResultScoreAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            if (!allow_incomplete)
              {
                string missing_field_error = result.missing_field_error(allow_unpolished);
                if (missing_field_error != null)
                    error(missing_field_error);
              }
            handle_result(result);
          }
        protected string getSportsResultScoreJSONKey()
          {
            if (!(keyGenerator.have_value))
                throw new Exception("The `SportsResultScoreKind' field is missing.");
            return keyGenerator.value;
          }
        protected void finish(SportsResultScoreJSON result)
          {
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
            if (fieldGeneratorGameStartTime.have_value)
              {
                result.setGameStartTime(fieldGeneratorGameStartTime.value);
                fieldGeneratorGameStartTime.have_value = false;
              }
            if (fieldGeneratorGameStatus.have_value)
              {
                result.setGameStatus(fieldGeneratorGameStatus.value);
                fieldGeneratorGameStatus.have_value = false;
              }
            if (fieldGeneratorQuarterInningPeriod.have_value)
              {
                result.setQuarterInningPeriod(fieldGeneratorQuarterInningPeriod.value);
                fieldGeneratorQuarterInningPeriod.have_value = false;
              }
            if (fieldGeneratorQuarterInningPeriodClock.have_value)
              {
                result.setQuarterInningPeriodClock(fieldGeneratorQuarterInningPeriodClock.value);
                fieldGeneratorQuarterInningPeriodClock.have_value = false;
              }
            if (fieldGeneratorVenue.have_value)
              {
                result.setVenue(fieldGeneratorVenue.value);
                fieldGeneratorVenue.have_value = false;
              }
            if (fieldGeneratorBroadcastNetwork.have_value)
              {
                result.setBroadcastNetwork(fieldGeneratorBroadcastNetwork.value);
                fieldGeneratorBroadcastNetwork.have_value = false;
              }
            if (fieldGeneratorSportsResultType.have_value)
              {
                result.setSportsResultType(fieldGeneratorSportsResultType.value);
                fieldGeneratorSportsResultType.have_value = false;
              }
            if (fieldGeneratorPlayoffs.have_value)
              {
                result.setPlayoffs(fieldGeneratorPlayoffs.value);
                fieldGeneratorPlayoffs.have_value = false;
              }
            if (fieldGeneratorPlayoffGame.have_value)
              {
                result.setPlayoffGame(fieldGeneratorPlayoffGame.value);
                fieldGeneratorPlayoffGame.have_value = false;
              }
            if (fieldGeneratorPlayoffType.have_value)
              {
                result.setPlayoffType(fieldGeneratorPlayoffType.value);
                fieldGeneratorPlayoffType.have_value = false;
              }
            if (fieldGeneratorTournament.have_value)
              {
                result.setTournament(fieldGeneratorTournament.value);
                fieldGeneratorTournament.have_value = false;
              }
            if (fieldGeneratorPreSeason.have_value)
              {
                result.setPreSeason(fieldGeneratorPreSeason.value);
                fieldGeneratorPreSeason.have_value = false;
              }
            if (fieldGeneratorGameID.have_value)
              {
                result.setGameID(fieldGeneratorGameID.value);
                fieldGeneratorGameID.have_value = false;
              }
            if (fieldGeneratorSportImage.have_value)
              {
                result.setSportImage(fieldGeneratorSportImage.value);
                fieldGeneratorSportImage.have_value = false;
              }
            if (fieldGeneratorPlayers.have_value)
              {
                result.initPlayers();
                int count = fieldGeneratorPlayers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPlayers(fieldGeneratorPlayers.value[num]);
                  }
                fieldGeneratorPlayers.value.Clear();
                fieldGeneratorPlayers.have_value = false;
              }
            if (fieldGeneratorGameStatistics.have_value)
              {
                result.setGameStatistics(fieldGeneratorGameStatistics.value);
                fieldGeneratorGameStatistics.have_value = false;
              }
          }
        protected abstract void handle_result(SportsResultScoreJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "roadcastNetwork", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorBroadcastNetwork;
                    break;
                case 'G':
                    if (String.Compare(field_name, 1, "ame", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 5, "D", 0, 1, false) == 0) && (field_name.Length == 6))
                                    return fieldGeneratorGameID;
                                break;
                            case 'S':
                                if (String.Compare(field_name, 5, "ta", 0, 2, false) == 0)
                                  {
                                    switch (field_name[7])
                                      {
                                        case 'r':
                                            if ((String.Compare(field_name, 8, "tTime", 0, 5, false) == 0) && (field_name.Length == 13))
                                                return fieldGeneratorGameStartTime;
                                            break;
                                        case 't':
                                            switch (field_name[8])
                                              {
                                                case 'i':
                                                    if ((String.Compare(field_name, 9, "stics", 0, 5, false) == 0) && (field_name.Length == 14))
                                                        return fieldGeneratorGameStatistics;
                                                    break;
                                                case 'u':
                                                    if ((String.Compare(field_name, 9, "s", 0, 1, false) == 0) && (field_name.Length == 10))
                                                        return fieldGeneratorGameStatus;
                                                    break;
                                                default:
                                                    break;
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
                case 'P':
                    switch (field_name[1])
                      {
                        case 'l':
                            if (String.Compare(field_name, 2, "ay", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'e':
                                        if ((String.Compare(field_name, 5, "rs", 0, 2, false) == 0) && (field_name.Length == 7))
                                            return fieldGeneratorPlayers;
                                        break;
                                    case 'o':
                                        if (String.Compare(field_name, 5, "ff", 0, 2, false) == 0)
                                          {
                                            switch (field_name[7])
                                              {
                                                case 'G':
                                                    if ((String.Compare(field_name, 8, "ame", 0, 3, false) == 0) && (field_name.Length == 11))
                                                        return fieldGeneratorPlayoffGame;
                                                    break;
                                                case 'T':
                                                    if ((String.Compare(field_name, 8, "ype", 0, 3, false) == 0) && (field_name.Length == 11))
                                                        return fieldGeneratorPlayoffType;
                                                    break;
                                                case 's':
                                                    if (field_name.Length == 8)
                                                        return fieldGeneratorPlayoffs;
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
                            if ((String.Compare(field_name, 2, "eSeason", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorPreSeason;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'Q':
                    if (String.Compare(field_name, 1, "uarterInningPeriod", 0, 18, false) == 0)
                      {
                        if (field_name.Length == 19)
                          {
                            return fieldGeneratorQuarterInningPeriod;
                          }
                        switch (field_name[19])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 20, "lock", 0, 4, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorQuarterInningPeriodClock;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "port", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 6, "mage", 0, 4, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorSportImage;
                                break;
                            case 's':
                                if (String.Compare(field_name, 6, "Result", 0, 6, false) == 0)
                                  {
                                    switch (field_name[12])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 13, "coreKind", 0, 8, false) == 0) && (field_name.Length == 21))
                                                {
                                                keyGenerator.reset();
                                                return keyGenerator;
                                                }
                                            break;
                                        case 'T':
                                            if ((String.Compare(field_name, 13, "ype", 0, 3, false) == 0) && (field_name.Length == 16))
                                                return fieldGeneratorSportsResultType;
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
                case 'T':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ams", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorTeams;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "urnament", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorTournament;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "enue", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorVenue;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTeams = new SportsTeamJSON.HoldingArrayGenerator("field \"Teams\" of the SportsResultScore class", ignore_extras);
            fieldGeneratorGameStartTime = new DateAndOrTimeJSON.HoldingGenerator("field \"GameStartTime\" of the SportsResultScore class", ignore_extras);
            fieldGeneratorGameStatus = new FieldHoldingGeneratorGameStatus("field \"GameStatus\" of the SportsResultScore class");
            fieldGeneratorQuarterInningPeriod = new FieldHoldingGeneratorQuarterInningPeriod("field \"QuarterInningPeriod\" of the SportsResultScore class");
            fieldGeneratorQuarterInningPeriodClock = new JSONHoldingStringGenerator("field \"QuarterInningPeriodClock\" of the SportsResultScore class");
            fieldGeneratorVenue = new SportsVenueJSON.HoldingGenerator("field \"Venue\" of the SportsResultScore class", ignore_extras);
            fieldGeneratorBroadcastNetwork = new JSONHoldingStringGenerator("field \"BroadcastNetwork\" of the SportsResultScore class");
            fieldGeneratorSportsResultType = new FieldHoldingGeneratorSportsResultType("field \"SportsResultType\" of the SportsResultScore class");
            fieldGeneratorPlayoffs = new JSONHoldingBooleanGenerator("field \"Playoffs\" of the SportsResultScore class");
            fieldGeneratorPlayoffGame = new JSONHoldingStringGenerator("field \"PlayoffGame\" of the SportsResultScore class");
            fieldGeneratorPlayoffType = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"PlayoffType\" of the SportsResultScore class", ignore_extras);
            fieldGeneratorTournament = new SportsTournamentJSON.HoldingGenerator("field \"Tournament\" of the SportsResultScore class", ignore_extras);
            fieldGeneratorPreSeason = new JSONHoldingBooleanGenerator("field \"PreSeason\" of the SportsResultScore class");
            fieldGeneratorGameID = new JSONHoldingStringGenerator("field \"GameID\" of the SportsResultScore class");
            fieldGeneratorSportImage = new SportsSportImageJSON.HoldingGenerator("field \"SportImage\" of the SportsResultScore class", ignore_extras);
            fieldGeneratorPlayers = new TypePlayersJSON.HoldingArrayGenerator("field \"Players\" of the SportsResultScore class", ignore_extras);
            fieldGeneratorGameStatistics = new SportsGameStatisticsJSON.HoldingGenerator("field \"GameStatistics\" of the SportsResultScore class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SportsResultScoreKind\" of the SportsResultScore class");
            set_what("the SportsResultScore class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTeams = new SportsTeamJSON.HoldingArrayGenerator("field \"Teams\" of the SportsResultScore class", false);
            fieldGeneratorGameStartTime = new DateAndOrTimeJSON.HoldingGenerator("field \"GameStartTime\" of the SportsResultScore class", false);
            fieldGeneratorGameStatus = new FieldHoldingGeneratorGameStatus("field \"GameStatus\" of the SportsResultScore class");
            fieldGeneratorQuarterInningPeriod = new FieldHoldingGeneratorQuarterInningPeriod("field \"QuarterInningPeriod\" of the SportsResultScore class");
            fieldGeneratorQuarterInningPeriodClock = new JSONHoldingStringGenerator("field \"QuarterInningPeriodClock\" of the SportsResultScore class");
            fieldGeneratorVenue = new SportsVenueJSON.HoldingGenerator("field \"Venue\" of the SportsResultScore class", false);
            fieldGeneratorBroadcastNetwork = new JSONHoldingStringGenerator("field \"BroadcastNetwork\" of the SportsResultScore class");
            fieldGeneratorSportsResultType = new FieldHoldingGeneratorSportsResultType("field \"SportsResultType\" of the SportsResultScore class");
            fieldGeneratorPlayoffs = new JSONHoldingBooleanGenerator("field \"Playoffs\" of the SportsResultScore class");
            fieldGeneratorPlayoffGame = new JSONHoldingStringGenerator("field \"PlayoffGame\" of the SportsResultScore class");
            fieldGeneratorPlayoffType = new SportsPlayoffSpecialGameJSON.HoldingGenerator("field \"PlayoffType\" of the SportsResultScore class", false);
            fieldGeneratorTournament = new SportsTournamentJSON.HoldingGenerator("field \"Tournament\" of the SportsResultScore class", false);
            fieldGeneratorPreSeason = new JSONHoldingBooleanGenerator("field \"PreSeason\" of the SportsResultScore class");
            fieldGeneratorGameID = new JSONHoldingStringGenerator("field \"GameID\" of the SportsResultScore class");
            fieldGeneratorSportImage = new SportsSportImageJSON.HoldingGenerator("field \"SportImage\" of the SportsResultScore class", false);
            fieldGeneratorPlayers = new TypePlayersJSON.HoldingArrayGenerator("field \"Players\" of the SportsResultScore class", false);
            fieldGeneratorGameStatistics = new SportsGameStatisticsJSON.HoldingGenerator("field \"GameStatistics\" of the SportsResultScore class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            keyGenerator = new JSONHoldingStringGenerator("key field \"SportsResultScoreKind\" of the SportsResultScore class");
            set_what("the SportsResultScore class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTeams.reset();
            fieldGeneratorGameStartTime.reset();
            fieldGeneratorGameStatus.reset();
            fieldGeneratorQuarterInningPeriod.reset();
            fieldGeneratorQuarterInningPeriodClock.reset();
            fieldGeneratorVenue.reset();
            fieldGeneratorBroadcastNetwork.reset();
            fieldGeneratorSportsResultType.reset();
            fieldGeneratorPlayoffs.reset();
            fieldGeneratorPlayoffGame.reset();
            fieldGeneratorPlayoffType.reset();
            fieldGeneratorTournament.reset();
            fieldGeneratorPreSeason.reset();
            fieldGeneratorGameID.reset();
            fieldGeneratorSportImage.reset();
            fieldGeneratorPlayers.reset();
            fieldGeneratorGameStatistics.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTeams.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGameStartTime.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorVenue.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPlayoffType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTournament.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSportImage.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPlayers.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGameStatistics.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTeams.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGameStartTime.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorVenue.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPlayoffType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTournament.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSportImage.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPlayers.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGameStatistics.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsResultScoreJSON  result)
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
        public SportsResultScoreJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsResultScoreJSON  result)
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
    protected virtual void handle_result(List<SportsResultScoreJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsResultScoreJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsResultScoreJSON>();
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
    public List<SportsResultScoreJSON> value;
  };
    class GenericSportsResultScoreJSON : SportsResultScoreJSON
      {
        private string key;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;
        public GenericSportsResultScoreJSON(string init_key)
          {
            key = init_key;
            extraKeys = new List<string>();
            extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public override string getSportsResultScoreKind()  { return key; }
        public override int extraSportsResultScoreComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public override string extraSportsResultScoreComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public override JSONValue extraSportsResultScoreComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public override JSONValue extraSportsResultScoreLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }
        public override void extraSportsResultScoreAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public override void extraSportsResultScoreSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraSportsResultScoreLookup(key);
            if (old_field == null)
              {
                extraSportsResultScoreAppendPair(key, new_component);
              }
            else
              {
                int count = extraKeys.Count;
                Debug.Assert(count == extraValues.Count);
                for (int num = 0; num < count; ++num)
                  {
                    if (extraKeys[num].Equals(key))
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
      };
    public static SportsResultScoreJSON createForKey(string key, Dictionary<string, JSONValue > other_field_index)
      {
    switch (key[0])
      {
        case 'C':
            if ((String.Compare(key, 1, "ricket", 0, 6, false) == 0) && (key.Length == 7))
                return new SportsResultScoreCricketJSON();
            break;
        case 'G':
            if ((String.Compare(key, 1, "eneric", 0, 6, false) == 0) && (key.Length == 7))
                return new SportsResultScoreGenericJSON();
            break;
        default:
            break;
      }

        return new GenericSportsResultScoreJSON(key);
      }
  };
