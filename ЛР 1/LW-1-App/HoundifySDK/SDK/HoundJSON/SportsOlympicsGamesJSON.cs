/* file "SportsOlympicsGamesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsOlympicsGamesJSON : JSONBase
  {
    public enum TypeStatusKnownValues
      {
        Status_Completed,
        Status_Ongoing,
        Status_Upcoming,
        Status__none
      };
    public struct TypeStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeStatusKnownValues list_value;
      };

    public static TypeStatusKnownValues  stringToStatus(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "ompleted", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeStatusKnownValues.Status_Completed;
                break;
            case 'O':
                if ((String.Compare(chars, 1, "ngoing", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeStatusKnownValues.Status_Ongoing;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "pcoming", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeStatusKnownValues.Status_Upcoming;
                break;
            default:
                break;
          }
        return TypeStatusKnownValues.Status__none;
      }

    public static string  stringFromStatus(TypeStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeStatusKnownValues.Status_Completed:
                return "Completed";
            case TypeStatusKnownValues.Status_Ongoing:
                return "Ongoing";
            case TypeStatusKnownValues.Status_Upcoming:
                return "Upcoming";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCode;
    private SportsOlympicsGamesCodeJSON  storeCode;
    private bool flagHasYear;
    private BigInteger storeYear;
    private bool flagHasHostCity;
    private string storeHostCity;
    private bool flagHasHostCountry;
    private string storeHostCountry;
    private bool flagHasSeason;
    private SportsOlympicsSeasonJSON  storeSeason;
    private bool flagHasOpeningCeremonyDate;
    private DateAndOrTimeJSON  storeOpeningCeremonyDate;
    private bool flagHasClosingCeremonyDate;
    private DateAndOrTimeJSON  storeClosingCeremonyDate;
    private bool flagHasStatus;
    private TypeStatus storeStatus;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsGamesCodeJSON convert_classy = SportsOlympicsGamesCodeJSON.from_json(json_value, ignore_extras, true);
        setCode(convert_classy);
      }


    private void  fromJSONYear(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Year of SportsOlympicsGamesJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Year of SportsOlympicsGamesJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setYear(extracted_integer);
      }


    private void  fromJSONHostCity(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HostCity of SportsOlympicsGamesJSON is not a string.");
        setHostCity(json_string.getData());
      }


    private void  fromJSONHostCountry(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field HostCountry of SportsOlympicsGamesJSON is not a string.");
        setHostCountry(json_string.getData());
      }


    private void  fromJSONSeason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsSeasonJSON convert_classy = SportsOlympicsSeasonJSON.from_json(json_value, ignore_extras, true);
        setSeason(convert_classy);
      }


    private void  fromJSONOpeningCeremonyDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setOpeningCeremonyDate(convert_classy);
      }


    private void  fromJSONClosingCeremonyDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setClosingCeremonyDate(convert_classy);
      }


    private void  fromJSONStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Status of SportsOlympicsGamesJSON is not a string.");
        TypeStatus the_open_enum = new TypeStatus();
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "ompleted", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_Completed;
                        goto open_enum_is_done;
                      }
                break;
            case 'O':
                if ((String.Compare(json_string.getData(), 1, "ngoing", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_Ongoing;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "pcoming", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeStatusKnownValues.Status_Upcoming;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setStatus(the_open_enum);
      }


    public SportsOlympicsGamesJSON()
      {
        flagHasCode = false;
        flagHasYear = false;
        flagHasHostCity = false;
        flagHasHostCountry = false;
        flagHasSeason = false;
        flagHasOpeningCeremonyDate = false;
        flagHasClosingCeremonyDate = false;
        flagHasStatus = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCode()
      {
        return flagHasCode;
      }

    public SportsOlympicsGamesCodeJSON   getCode()
      {
        Debug.Assert(flagHasCode);
        return storeCode;
      }

    public SportsOlympicsGamesCodeJSON.TypeValue  getCodeValue()
      {
        return getCode().getValue();
      }

    public string  getCodeAsString()
      {
        return getCode().getValueAsString();
      }

    public bool  hasYear()
      {
        return flagHasYear;
      }

    public BigInteger  getYear()
      {
        Debug.Assert(flagHasYear);
        return storeYear;
      }

    public bool  hasHostCity()
      {
        return flagHasHostCity;
      }

    public string  getHostCity()
      {
        Debug.Assert(flagHasHostCity);
        return storeHostCity;
      }

    public bool  hasHostCountry()
      {
        return flagHasHostCountry;
      }

    public string  getHostCountry()
      {
        Debug.Assert(flagHasHostCountry);
        return storeHostCountry;
      }

    public bool  hasSeason()
      {
        return flagHasSeason;
      }

    public SportsOlympicsSeasonJSON   getSeason()
      {
        Debug.Assert(flagHasSeason);
        return storeSeason;
      }

    public SportsOlympicsSeasonJSON.TypeValue  getSeasonValue()
      {
        return getSeason().getValue();
      }

    public string  getSeasonAsString()
      {
        return getSeason().getValueAsString();
      }

    public bool  hasOpeningCeremonyDate()
      {
        return flagHasOpeningCeremonyDate;
      }

    public DateAndOrTimeJSON   getOpeningCeremonyDate()
      {
        Debug.Assert(flagHasOpeningCeremonyDate);
        return storeOpeningCeremonyDate;
      }

    public bool  hasClosingCeremonyDate()
      {
        return flagHasClosingCeremonyDate;
      }

    public DateAndOrTimeJSON   getClosingCeremonyDate()
      {
        Debug.Assert(flagHasClosingCeremonyDate);
        return storeClosingCeremonyDate;
      }

    public bool  hasStatus()
      {
        return flagHasStatus;
      }

    public TypeStatus  getStatus()
      {
        Debug.Assert(flagHasStatus);
        return storeStatus;
      }

    public string  getStatusAsString()
      {
        TypeStatus result = getStatus();
        if (result.in_known_list)
            return stringFromStatus(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraSportsOlympicsGamesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsGamesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsGamesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsGamesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCode(SportsOlympicsGamesCodeJSON  new_value)
      {
        if (flagHasCode)
          {
          }
        flagHasCode = true;
        storeCode = new_value;
      }
    public void setCode(SportsOlympicsGamesCodeJSON.TypeValue new_value)
      {
        setCode(new SportsOlympicsGamesCodeJSON(new_value));
      }
    public void setCode(string chars)
      {
        SportsOlympicsGamesCodeJSON.TypeValueKnownValues known = SportsOlympicsGamesCodeJSON.stringToValue(chars);
        SportsOlympicsGamesCodeJSON.TypeValue new_value = new SportsOlympicsGamesCodeJSON.TypeValue();
        if (known == SportsOlympicsGamesCodeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setCode(new_value);
      }
    public void unsetCode()
      {
        if (flagHasCode)
          {
          }
        flagHasCode = false;
      }
    public void setYear(BigInteger new_value)
      {
        flagHasYear = true;
        if (new_value < 0)
            throw new Exception("The value for field Year of SportsOlympicsGamesJSON is less than the lower bound (0) for that field.");
        storeYear = new_value;
      }
    public void unsetYear()
      {
        flagHasYear = false;
      }
    public void setHostCity(string new_value)
      {
        flagHasHostCity = true;
        storeHostCity = new_value;
      }
    public void unsetHostCity()
      {
        flagHasHostCity = false;
      }
    public void setHostCountry(string new_value)
      {
        flagHasHostCountry = true;
        storeHostCountry = new_value;
      }
    public void unsetHostCountry()
      {
        flagHasHostCountry = false;
      }
    public void setSeason(SportsOlympicsSeasonJSON  new_value)
      {
        if (flagHasSeason)
          {
          }
        flagHasSeason = true;
        storeSeason = new_value;
      }
    public void setSeason(SportsOlympicsSeasonJSON.TypeValue new_value)
      {
        setSeason(new SportsOlympicsSeasonJSON(new_value));
      }
    public void setSeason(string chars)
      {
        SportsOlympicsSeasonJSON.TypeValueKnownValues known = SportsOlympicsSeasonJSON.stringToValue(chars);
        SportsOlympicsSeasonJSON.TypeValue new_value = new SportsOlympicsSeasonJSON.TypeValue();
        if (known == SportsOlympicsSeasonJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSeason(new_value);
      }
    public void unsetSeason()
      {
        if (flagHasSeason)
          {
          }
        flagHasSeason = false;
      }
    public void setOpeningCeremonyDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasOpeningCeremonyDate)
          {
          }
        flagHasOpeningCeremonyDate = true;
        storeOpeningCeremonyDate = new_value;
      }
    public void unsetOpeningCeremonyDate()
      {
        if (flagHasOpeningCeremonyDate)
          {
          }
        flagHasOpeningCeremonyDate = false;
      }
    public void setClosingCeremonyDate(DateAndOrTimeJSON  new_value)
      {
        if (flagHasClosingCeremonyDate)
          {
          }
        flagHasClosingCeremonyDate = true;
        storeClosingCeremonyDate = new_value;
      }
    public void unsetClosingCeremonyDate()
      {
        if (flagHasClosingCeremonyDate)
          {
          }
        flagHasClosingCeremonyDate = false;
      }
    public void setStatus(TypeStatus new_value)
      {
        flagHasStatus = true;
        storeStatus = new_value;
      }
    public void setStatus(string chars)
      {
        TypeStatusKnownValues known = stringToStatus(chars);
        TypeStatus new_value = new TypeStatus();
        if (known == TypeStatusKnownValues.Status__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setStatus(new_value);
      }
    public void setStatus(TypeStatusKnownValues new_value)
      {
        TypeStatus new_full_value = new TypeStatus();
        Debug.Assert(new_value != TypeStatusKnownValues.Status__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setStatus(new_full_value);
      }
    public void unsetStatus()
      {
        flagHasStatus = false;
      }

    public virtual void extraSportsOlympicsGamesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsGamesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsGamesLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsGamesAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCode);
        if (flagHasCode)
          {
            handler.start_pair("Code");
            if (partial_allowed)
                storeCode.write_partial_as_json(handler);
            else
                storeCode.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasYear);
        if (flagHasYear)
          {
            handler.start_pair("Year");
            handler.number_value(storeYear);
          }
        if (flagHasHostCity)
          {
            handler.start_pair("HostCity");
            handler.string_value(storeHostCity);
          }
        if (flagHasHostCountry)
          {
            handler.start_pair("HostCountry");
            handler.string_value(storeHostCountry);
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
        if (flagHasOpeningCeremonyDate)
          {
            handler.start_pair("OpeningCeremonyDate");
            if (partial_allowed)
                storeOpeningCeremonyDate.write_partial_as_json(handler);
            else
                storeOpeningCeremonyDate.write_as_json(handler);
          }
        if (flagHasClosingCeremonyDate)
          {
            handler.start_pair("ClosingCeremonyDate");
            if (partial_allowed)
                storeClosingCeremonyDate.write_partial_as_json(handler);
            else
                storeClosingCeremonyDate.write_as_json(handler);
          }
        if (flagHasStatus)
          {
            handler.start_pair("Status");
            if (storeStatus.in_known_list)
              {
                switch (storeStatus.list_value)
                  {
                    case TypeStatusKnownValues.Status_Completed:
                        handler.string_value("Completed");
                        break;
                    case TypeStatusKnownValues.Status_Ongoing:
                        handler.string_value("Ongoing");
                        break;
                    case TypeStatusKnownValues.Status_Upcoming:
                        handler.string_value("Upcoming");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeStatus.string_value);
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
        if (!(hasCode()))
          {
            return "When parsing the object for %what%, the \"Code\" field was missing.";
          }
        if (!(hasYear()))
          {
            return "When parsing the object for %what%, the \"Year\" field was missing.";
          }
        if (!(hasSeason()))
          {
            return "When parsing the object for %what%, the \"Season\" field was missing.";
          }
        return null;
      }

    public static SportsOlympicsGamesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsGamesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsGames", ignore_extras);
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
    public static SportsOlympicsGamesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsGamesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsGamesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsGames", ignore_extras);
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
    public static SportsOlympicsGamesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsGamesJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsGamesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsGames", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsGamesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsGamesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsGamesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsGames", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsOlympicsGamesCodeJSON.HoldingGenerator fieldGeneratorCode;
    private class FieldHoldingGeneratorYear : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorYear(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorYear : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorYear(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorYear fieldGeneratorYear;
        private JSONHoldingStringGenerator fieldGeneratorHostCity;
        private JSONHoldingStringGenerator fieldGeneratorHostCountry;
        private SportsOlympicsSeasonJSON.HoldingGenerator fieldGeneratorSeason;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorOpeningCeremonyDate;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorClosingCeremonyDate;
    private abstract class FieldGeneratorStatus : JSONStringGenerator
          {
            protected FieldGeneratorStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorStatus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeStatusKnownValues known = stringToStatus(result);
                TypeStatus new_value = new TypeStatus();
                if (known == TypeStatusKnownValues.Status__none)
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
            protected abstract void handle_result(TypeStatus result);
          };
    private class FieldHoldingGeneratorStatus : FieldGeneratorStatus
  {
    protected override void handle_result(TypeStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorStatus(String what)
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
    public TypeStatus value;
  };
    private class FieldHoldingArrayGeneratorStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorStatus
      {
        private FieldHoldingArrayGeneratorStatus top;

        protected override void handle_result(TypeStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorStatus init_top)
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
    protected virtual void handle_result(List<TypeStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeStatus> value;
  };
        private FieldHoldingGeneratorStatus fieldGeneratorStatus;
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
            SportsOlympicsGamesJSON result = new SportsOlympicsGamesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsGamesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsGamesJSON result)
          {
            if (fieldGeneratorCode.have_value)
              {
                result.setCode(fieldGeneratorCode.value);
                fieldGeneratorCode.have_value = false;
              }
            else if ((!(result.hasCode())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Code\" field was missing.");
              }
            if (fieldGeneratorYear.have_value)
              {
                result.setYear(fieldGeneratorYear.value);
                fieldGeneratorYear.have_value = false;
              }
            else if ((!(result.hasYear())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Year\" field was missing.");
              }
            if (fieldGeneratorHostCity.have_value)
              {
                result.setHostCity(fieldGeneratorHostCity.value);
                fieldGeneratorHostCity.have_value = false;
              }
            if (fieldGeneratorHostCountry.have_value)
              {
                result.setHostCountry(fieldGeneratorHostCountry.value);
                fieldGeneratorHostCountry.have_value = false;
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
            if (fieldGeneratorOpeningCeremonyDate.have_value)
              {
                result.setOpeningCeremonyDate(fieldGeneratorOpeningCeremonyDate.value);
                fieldGeneratorOpeningCeremonyDate.have_value = false;
              }
            if (fieldGeneratorClosingCeremonyDate.have_value)
              {
                result.setClosingCeremonyDate(fieldGeneratorClosingCeremonyDate.value);
                fieldGeneratorClosingCeremonyDate.have_value = false;
              }
            if (fieldGeneratorStatus.have_value)
              {
                result.setStatus(fieldGeneratorStatus.value);
                fieldGeneratorStatus.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsGamesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "osingCeremonyDate", 0, 17, false) == 0) && (field_name.Length == 19))
                                return fieldGeneratorClosingCeremonyDate;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "de", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorCode;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'H':
                    if (String.Compare(field_name, 1, "ostC", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'i':
                                if ((String.Compare(field_name, 6, "ty", 0, 2, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorHostCity;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 6, "untry", 0, 5, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorHostCountry;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "peningCeremonyDate", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorOpeningCeremonyDate;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ason", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorSeason;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "atus", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorStatus;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'Y':
                    if ((String.Compare(field_name, 1, "ear", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorYear;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCode = new SportsOlympicsGamesCodeJSON.HoldingGenerator("field \"Code\" of the SportsOlympicsGames class", ignore_extras);
            fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the SportsOlympicsGames class");
            fieldGeneratorHostCity = new JSONHoldingStringGenerator("field \"HostCity\" of the SportsOlympicsGames class");
            fieldGeneratorHostCountry = new JSONHoldingStringGenerator("field \"HostCountry\" of the SportsOlympicsGames class");
            fieldGeneratorSeason = new SportsOlympicsSeasonJSON.HoldingGenerator("field \"Season\" of the SportsOlympicsGames class", ignore_extras);
            fieldGeneratorOpeningCeremonyDate = new DateAndOrTimeJSON.HoldingGenerator("field \"OpeningCeremonyDate\" of the SportsOlympicsGames class", ignore_extras);
            fieldGeneratorClosingCeremonyDate = new DateAndOrTimeJSON.HoldingGenerator("field \"ClosingCeremonyDate\" of the SportsOlympicsGames class", ignore_extras);
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the SportsOlympicsGames class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsGames class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCode = new SportsOlympicsGamesCodeJSON.HoldingGenerator("field \"Code\" of the SportsOlympicsGames class", false);
            fieldGeneratorYear = new FieldHoldingGeneratorYear("field \"Year\" of the SportsOlympicsGames class");
            fieldGeneratorHostCity = new JSONHoldingStringGenerator("field \"HostCity\" of the SportsOlympicsGames class");
            fieldGeneratorHostCountry = new JSONHoldingStringGenerator("field \"HostCountry\" of the SportsOlympicsGames class");
            fieldGeneratorSeason = new SportsOlympicsSeasonJSON.HoldingGenerator("field \"Season\" of the SportsOlympicsGames class", false);
            fieldGeneratorOpeningCeremonyDate = new DateAndOrTimeJSON.HoldingGenerator("field \"OpeningCeremonyDate\" of the SportsOlympicsGames class", false);
            fieldGeneratorClosingCeremonyDate = new DateAndOrTimeJSON.HoldingGenerator("field \"ClosingCeremonyDate\" of the SportsOlympicsGames class", false);
            fieldGeneratorStatus = new FieldHoldingGeneratorStatus("field \"Status\" of the SportsOlympicsGames class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsGames class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCode.reset();
            fieldGeneratorYear.reset();
            fieldGeneratorHostCity.reset();
            fieldGeneratorHostCountry.reset();
            fieldGeneratorSeason.reset();
            fieldGeneratorOpeningCeremonyDate.reset();
            fieldGeneratorClosingCeremonyDate.reset();
            fieldGeneratorStatus.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCode.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeason.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOpeningCeremonyDate.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorClosingCeremonyDate.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCode.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeason.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOpeningCeremonyDate.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorClosingCeremonyDate.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsGamesJSON  result)
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
        public SportsOlympicsGamesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsGamesJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsGamesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsGamesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsGamesJSON>();
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
    public List<SportsOlympicsGamesJSON> value;
  };
  };
