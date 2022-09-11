/* file "SportsStandingsQueryTypeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStandingsQueryTypeJSON : JSONBase
  {
    public enum TypeValueKnownValues
      {
        Value_ShowStandings,
        Value_TeamRank,
        Value_TeamGamesBehind,
        Value_LeadingTeam,
        Value_TeamWinsLosses,
        Value_TeamWinningPercentage,
        Value_TeamStreak,
        Value_TeamLastTen,
        Value_TeamClinchStatus,
        Value_TeamDivision,
        Value_DivisionTeams,
        Value_GamesLeftInRegularSeason,
        Value_TeamDivisionTeams,
        Value__none
      };
    public struct TypeValue
      {
        public bool in_known_list;
        public string string_value;
        public TypeValueKnownValues list_value;
      };

    public static TypeValueKnownValues  stringToValue(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                if ((String.Compare(chars, 1, "ivisionTeams", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeValueKnownValues.Value_DivisionTeams;
                break;
            case 'G':
                if ((String.Compare(chars, 1, "amesLeftInRegularSeason", 0, 23, false) == 0) && (chars.Length == 24))
                    return TypeValueKnownValues.Value_GamesLeftInRegularSeason;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "eadingTeam", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeValueKnownValues.Value_LeadingTeam;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "howStandings", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeValueKnownValues.Value_ShowStandings;
                break;
            case 'T':
                if (String.Compare(chars, 1, "eam", 0, 3, false) == 0)
                  {
                    switch (chars[4])
                      {
                        case 'C':
                            if ((String.Compare(chars, 5, "linchStatus", 0, 11, false) == 0) && (chars.Length == 16))
                                return TypeValueKnownValues.Value_TeamClinchStatus;
                            break;
                        case 'D':
                            if (String.Compare(chars, 5, "ivision", 0, 7, false) == 0)
                              {
                                if (chars.Length == 12)
                                  {
                                    return TypeValueKnownValues.Value_TeamDivision;
                                  }
                                switch (chars[12])
                                  {
                                    case 'T':
                                        if ((String.Compare(chars, 13, "eams", 0, 4, false) == 0) && (chars.Length == 17))
                                            return TypeValueKnownValues.Value_TeamDivisionTeams;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'G':
                            if ((String.Compare(chars, 5, "amesBehind", 0, 10, false) == 0) && (chars.Length == 15))
                                return TypeValueKnownValues.Value_TeamGamesBehind;
                            break;
                        case 'L':
                            if ((String.Compare(chars, 5, "astTen", 0, 6, false) == 0) && (chars.Length == 11))
                                return TypeValueKnownValues.Value_TeamLastTen;
                            break;
                        case 'R':
                            if ((String.Compare(chars, 5, "ank", 0, 3, false) == 0) && (chars.Length == 8))
                                return TypeValueKnownValues.Value_TeamRank;
                            break;
                        case 'S':
                            if ((String.Compare(chars, 5, "treak", 0, 5, false) == 0) && (chars.Length == 10))
                                return TypeValueKnownValues.Value_TeamStreak;
                            break;
                        case 'W':
                            if (String.Compare(chars, 5, "in", 0, 2, false) == 0)
                              {
                                switch (chars[7])
                                  {
                                    case 'n':
                                        if ((String.Compare(chars, 8, "ingPercentage", 0, 13, false) == 0) && (chars.Length == 21))
                                            return TypeValueKnownValues.Value_TeamWinningPercentage;
                                        break;
                                    case 's':
                                        if ((String.Compare(chars, 8, "Losses", 0, 6, false) == 0) && (chars.Length == 14))
                                            return TypeValueKnownValues.Value_TeamWinsLosses;
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
        return TypeValueKnownValues.Value__none;
      }

    public static string  stringFromValue(TypeValueKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeValueKnownValues.Value_ShowStandings:
                return "ShowStandings";
            case TypeValueKnownValues.Value_TeamRank:
                return "TeamRank";
            case TypeValueKnownValues.Value_TeamGamesBehind:
                return "TeamGamesBehind";
            case TypeValueKnownValues.Value_LeadingTeam:
                return "LeadingTeam";
            case TypeValueKnownValues.Value_TeamWinsLosses:
                return "TeamWinsLosses";
            case TypeValueKnownValues.Value_TeamWinningPercentage:
                return "TeamWinningPercentage";
            case TypeValueKnownValues.Value_TeamStreak:
                return "TeamStreak";
            case TypeValueKnownValues.Value_TeamLastTen:
                return "TeamLastTen";
            case TypeValueKnownValues.Value_TeamClinchStatus:
                return "TeamClinchStatus";
            case TypeValueKnownValues.Value_TeamDivision:
                return "TeamDivision";
            case TypeValueKnownValues.Value_DivisionTeams:
                return "DivisionTeams";
            case TypeValueKnownValues.Value_GamesLeftInRegularSeason:
                return "GamesLeftInRegularSeason";
            case TypeValueKnownValues.Value_TeamDivisionTeams:
                return "TeamDivisionTeams";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasValue;
    private TypeValue storeValue;


    private void  fromJSONValue(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Value of SportsStandingsQueryTypeJSON is not a string.");
        TypeValue the_open_enum = new TypeValue();
        switch (json_string.getData()[0])
          {
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "ivisionTeams", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_DivisionTeams;
                        goto open_enum_is_done;
                      }
                break;
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "amesLeftInRegularSeason", 0, 23, false) == 0) && (json_string.getData().Length == 24))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_GamesLeftInRegularSeason;
                        goto open_enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "eadingTeam", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_LeadingTeam;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "howStandings", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeValueKnownValues.Value_ShowStandings;
                        goto open_enum_is_done;
                      }
                break;
            case 'T':
                if (String.Compare(json_string.getData(), 1, "eam", 0, 3, false) == 0)
                  {
                    switch (json_string.getData()[4])
                      {
                        case 'C':
                            if ((String.Compare(json_string.getData(), 5, "linchStatus", 0, 11, false) == 0) && (json_string.getData().Length == 16))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_TeamClinchStatus;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'D':
                            if (String.Compare(json_string.getData(), 5, "ivision", 0, 7, false) == 0)
                              {
                                if (json_string.getData().Length == 12)
                                  {
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeValueKnownValues.Value_TeamDivision;
                                        goto open_enum_is_done;
                                      }
                                  }
                                switch (json_string.getData()[12])
                                  {
                                    case 'T':
                                        if ((String.Compare(json_string.getData(), 13, "eams", 0, 4, false) == 0) && (json_string.getData().Length == 17))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_TeamDivisionTeams;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'G':
                            if ((String.Compare(json_string.getData(), 5, "amesBehind", 0, 10, false) == 0) && (json_string.getData().Length == 15))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_TeamGamesBehind;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'L':
                            if ((String.Compare(json_string.getData(), 5, "astTen", 0, 6, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_TeamLastTen;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'R':
                            if ((String.Compare(json_string.getData(), 5, "ank", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_TeamRank;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'S':
                            if ((String.Compare(json_string.getData(), 5, "treak", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeValueKnownValues.Value_TeamStreak;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'W':
                            if (String.Compare(json_string.getData(), 5, "in", 0, 2, false) == 0)
                              {
                                switch (json_string.getData()[7])
                                  {
                                    case 'n':
                                        if ((String.Compare(json_string.getData(), 8, "ingPercentage", 0, 13, false) == 0) && (json_string.getData().Length == 21))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_TeamWinningPercentage;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 's':
                                        if ((String.Compare(json_string.getData(), 8, "Losses", 0, 6, false) == 0) && (json_string.getData().Length == 14))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeValueKnownValues.Value_TeamWinsLosses;
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
                  }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setValue(the_open_enum);
      }


    public SportsStandingsQueryTypeJSON()
      {
        flagHasValue = false;
      }

    public SportsStandingsQueryTypeJSON(TypeValue init_value)
      {
        flagHasValue = true;
        storeValue = init_value;
      }

    public SportsStandingsQueryTypeJSON(string init_value)
      {
        flagHasValue = true;
        TypeValueKnownValues known = stringToValue(init_value);
        if (known == TypeValueKnownValues.Value__none)
          {
            storeValue.in_known_list = false;
            storeValue.string_value = init_value;
          }
        else
          {
            storeValue.in_known_list = true;
            storeValue.list_value = known;
          }
      }

    public SportsStandingsQueryTypeJSON(TypeValueKnownValues init_value)
      {
        flagHasValue = true;
        Debug.Assert(init_value != TypeValueKnownValues.Value__none);
        storeValue.in_known_list = true;
        storeValue.list_value = init_value;
      }

    public bool  hasValue()
      {
        return flagHasValue;
      }

    public TypeValue  getValue()
      {
        Debug.Assert(flagHasValue);
        return storeValue;
      }

    public string  getValueAsString()
      {
        TypeValue result = getValue();
        if (result.in_known_list)
            return stringFromValue(result.list_value);
        else
            return result.string_value;
      }



    public void setValue(TypeValue new_value)
      {
        flagHasValue = true;
        storeValue = new_value;
      }
    public void setValue(string chars)
      {
        TypeValueKnownValues known = stringToValue(chars);
        TypeValue new_value = new TypeValue();
        if (known == TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setValue(new_value);
      }
    public void setValue(TypeValueKnownValues new_value)
      {
        TypeValue new_full_value = new TypeValue();
        Debug.Assert(new_value != TypeValueKnownValues.Value__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setValue(new_full_value);
      }
    public void unsetValue()
      {
        flagHasValue = false;
      }


    public override void write_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_ShowStandings:
                    handler.string_value("ShowStandings");
                    break;
                case TypeValueKnownValues.Value_TeamRank:
                    handler.string_value("TeamRank");
                    break;
                case TypeValueKnownValues.Value_TeamGamesBehind:
                    handler.string_value("TeamGamesBehind");
                    break;
                case TypeValueKnownValues.Value_LeadingTeam:
                    handler.string_value("LeadingTeam");
                    break;
                case TypeValueKnownValues.Value_TeamWinsLosses:
                    handler.string_value("TeamWinsLosses");
                    break;
                case TypeValueKnownValues.Value_TeamWinningPercentage:
                    handler.string_value("TeamWinningPercentage");
                    break;
                case TypeValueKnownValues.Value_TeamStreak:
                    handler.string_value("TeamStreak");
                    break;
                case TypeValueKnownValues.Value_TeamLastTen:
                    handler.string_value("TeamLastTen");
                    break;
                case TypeValueKnownValues.Value_TeamClinchStatus:
                    handler.string_value("TeamClinchStatus");
                    break;
                case TypeValueKnownValues.Value_TeamDivision:
                    handler.string_value("TeamDivision");
                    break;
                case TypeValueKnownValues.Value_DivisionTeams:
                    handler.string_value("DivisionTeams");
                    break;
                case TypeValueKnownValues.Value_GamesLeftInRegularSeason:
                    handler.string_value("GamesLeftInRegularSeason");
                    break;
                case TypeValueKnownValues.Value_TeamDivisionTeams:
                    handler.string_value("TeamDivisionTeams");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        if (storeValue.in_known_list)
          {
            switch (storeValue.list_value)
              {
                case TypeValueKnownValues.Value_ShowStandings:
                    handler.string_value("ShowStandings");
                    break;
                case TypeValueKnownValues.Value_TeamRank:
                    handler.string_value("TeamRank");
                    break;
                case TypeValueKnownValues.Value_TeamGamesBehind:
                    handler.string_value("TeamGamesBehind");
                    break;
                case TypeValueKnownValues.Value_LeadingTeam:
                    handler.string_value("LeadingTeam");
                    break;
                case TypeValueKnownValues.Value_TeamWinsLosses:
                    handler.string_value("TeamWinsLosses");
                    break;
                case TypeValueKnownValues.Value_TeamWinningPercentage:
                    handler.string_value("TeamWinningPercentage");
                    break;
                case TypeValueKnownValues.Value_TeamStreak:
                    handler.string_value("TeamStreak");
                    break;
                case TypeValueKnownValues.Value_TeamLastTen:
                    handler.string_value("TeamLastTen");
                    break;
                case TypeValueKnownValues.Value_TeamClinchStatus:
                    handler.string_value("TeamClinchStatus");
                    break;
                case TypeValueKnownValues.Value_TeamDivision:
                    handler.string_value("TeamDivision");
                    break;
                case TypeValueKnownValues.Value_DivisionTeams:
                    handler.string_value("DivisionTeams");
                    break;
                case TypeValueKnownValues.Value_GamesLeftInRegularSeason:
                    handler.string_value("GamesLeftInRegularSeason");
                    break;
                case TypeValueKnownValues.Value_TeamDivisionTeams:
                    handler.string_value("TeamDivisionTeams");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        else
          {
                    handler.string_value(storeValue.string_value);
          }
      }

    public static SportsStandingsQueryTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsQueryTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsQueryType", ignore_extras);
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
    public static SportsStandingsQueryTypeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsQueryTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsQueryTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsQueryType", ignore_extras);
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
    public static SportsStandingsQueryTypeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsStandingsQueryTypeJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsQueryTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsQueryType", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsQueryTypeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsStandingsQueryTypeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsQueryTypeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsQueryType", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class FieldGeneratorValue : JSONStringGenerator
      {
        protected FieldGeneratorValue(string what)
          {
            set_what(what);
          }
        protected FieldGeneratorValue()
          {
          }
        protected override void handle_result(string result)
          {
            TypeValueKnownValues known = stringToValue(result);
            TypeValue new_value = new TypeValue();
            if (known == TypeValueKnownValues.Value__none)
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
        protected abstract void handle_result(TypeValue result);
      };
    public class FieldHoldingGeneratorValue : FieldGeneratorValue
  {
    protected override void handle_result(TypeValue result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorValue(String what)
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
    public TypeValue value;
  };
    public class FieldHoldingArrayGeneratorValue : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorValue
      {
        private FieldHoldingArrayGeneratorValue top;

        protected override void handle_result(TypeValue result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorValue init_top)
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
    protected virtual void handle_result(List<TypeValue> result)
      {
      }

    public FieldHoldingArrayGeneratorValue(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorValue()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeValue>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeValue> value;
  };
    public abstract class Generator : FieldGeneratorValue
      {
        protected override void handle_result(TypeValue new_value)
          {
            SportsStandingsQueryTypeJSON result = new SportsStandingsQueryTypeJSON();
            result.setValue(new_value);
            handle_result(result);
          }
        protected abstract void handle_result(SportsStandingsQueryTypeJSON new_result);
        public Generator(bool ignore_extras) : base("Type SportsStandingsQueryType")
          {
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStandingsQueryTypeJSON  result)
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
        public SportsStandingsQueryTypeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsQueryTypeJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsQueryTypeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsQueryTypeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsQueryTypeJSON>();
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
    public List<SportsStandingsQueryTypeJSON> value;
  };
  };
