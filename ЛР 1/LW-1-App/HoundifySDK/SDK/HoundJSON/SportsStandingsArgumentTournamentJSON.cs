/* file "SportsStandingsArgumentTournamentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStandingsArgumentTournamentJSON : SportsStandingsArgumentJSON
  {
    private bool flagHasTournaments;
    private List< SportsTournamentCodeJSON  > storeTournaments;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraTournamentsToJSON()
      {
        JSONArrayValue generated_array_1_Tournaments = new JSONArrayValue();
        for (int num1 = 0; num1 < storeTournaments.Count; ++num1)
          {
            JSONValueHandler handler_Tournaments = new JSONValueHandler();
            storeTournaments[num1].write_as_json(handler_Tournaments);
            generated_array_1_Tournaments.appendComponent(handler_Tournaments.result);
          }
        return generated_array_1_Tournaments;
      }


    private void  fromJSONTournaments(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Tournaments of SportsStandingsArgumentTournamentJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Tournaments of SportsStandingsArgumentTournamentJSON has too few elements.");
        List< SportsTournamentCodeJSON  > vector_Tournaments1 = new List< SportsTournamentCodeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsTournamentCodeJSON convert_classy = SportsTournamentCodeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Tournaments1.Add(convert_classy);
          }
        Debug.Assert(vector_Tournaments1.Count >= 1);
        initTournaments();
        for (int num1 = 0; num1 < vector_Tournaments1.Count; ++num1)
            appendTournaments(vector_Tournaments1[num1]);
        for (int num1 = 0; num1 < vector_Tournaments1.Count; ++num1)
          {
          }
      }


    public SportsStandingsArgumentTournamentJSON()
      {
        flagHasTournaments = false;
        storeTournaments = new List< SportsTournamentCodeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsStandingsArgumentKind()
      {
        return "Tournament";
      }

    public bool  hasTournaments()
      {
        return flagHasTournaments;
      }

    public int  countOfTournaments()
      {
        Debug.Assert(flagHasTournaments);
        return storeTournaments.Count;
      }

    public SportsTournamentCodeJSON   elementOfTournaments(int element_num)
      {
        Debug.Assert(flagHasTournaments);
        return storeTournaments[element_num];
      }

    public List< SportsTournamentCodeJSON  >  getTournaments()
      {
        Debug.Assert(flagHasTournaments);
        return storeTournaments;
      }


    public virtual int extraSportsStandingsArgumentTournamentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStandingsArgumentTournamentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentTournamentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentTournamentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsStandingsArgumentComponentCount()
      {
        int result = 0;
        if (flagHasTournaments)
            ++result;
        result += extraSportsStandingsArgumentTournamentComponentCount();
        return result;
      }
    public override string extraSportsStandingsArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasTournaments)
          {
            if (remainder == 0)
                return "Tournaments";
            --remainder;
          }
        return extraSportsStandingsArgumentTournamentComponentKey(remainder);
      }
    public override JSONValue extraSportsStandingsArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasTournaments)
          {
            if (remainder == 0)
                return extraTournamentsToJSON();
            --remainder;
          }
        return extraSportsStandingsArgumentTournamentComponentValue(remainder);
      }
    public override JSONValue extraSportsStandingsArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Tournaments", 0, 11, false) == 0) && (field_name.Length == 11))
            return (flagHasTournaments ? extraTournamentsToJSON() : null);
        return extraSportsStandingsArgumentTournamentLookup(field_name);
      }

    public void initTournaments()
      {
        if (flagHasTournaments)
          {
            for (int num1 = 0; num1 < storeTournaments.Count; ++num1)
              {
              }
          }
        flagHasTournaments = true;
        storeTournaments.Clear();
      }
    public void appendTournaments(SportsTournamentCodeJSON  to_append)
      {
        if (!flagHasTournaments)
          {
            flagHasTournaments = true;
            storeTournaments.Clear();
          }
        Debug.Assert(flagHasTournaments);
        storeTournaments.Add(to_append);
      }
    public void appendTournaments(SportsTournamentCodeJSON.TypeValue new_value)
      {
        appendTournaments(new SportsTournamentCodeJSON(new_value));
      }
    public void appendTournaments(string chars)
      {
        SportsTournamentCodeJSON.TypeValueKnownValues known = SportsTournamentCodeJSON.stringToValue(chars);
        SportsTournamentCodeJSON.TypeValue new_value = new SportsTournamentCodeJSON.TypeValue();
        if (known == SportsTournamentCodeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendTournaments(new_value);
      }
    public void unsetTournaments()
      {
        if (flagHasTournaments)
          {
            for (int num2 = 0; num2 < storeTournaments.Count; ++num2)
              {
              }
          }
        flagHasTournaments = false;
        storeTournaments.Clear();
      }

    public virtual void extraSportsStandingsArgumentTournamentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStandingsArgumentTournamentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStandingsArgumentTournamentLookup(key);
        if (old_field == null)
          {
            extraSportsStandingsArgumentTournamentAppendPair(key, new_component);
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
    public override void extraSportsStandingsArgumentAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Tournaments", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONTournaments(new_component, false);
            return;
            }
        extraSportsStandingsArgumentTournamentAppendPair(key, new_component);
      }
    public override void extraSportsStandingsArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Tournaments", 0, 11, false) == 0) && (key.Length == 11))
            {
            fromJSONTournaments(new_component, false);
            return;
            }
        extraSportsStandingsArgumentTournamentSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        Debug.Assert(partial_allowed || flagHasTournaments);
        if (flagHasTournaments)
          {
            handler.start_pair("Tournaments");
            Debug.Assert(storeTournaments.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeTournaments.Count; ++num1)
              {
                if (partial_allowed)
                    storeTournaments[num1].write_partial_as_json(handler);
                else
                    storeTournaments[num1].write_as_json(handler);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasTournaments()))
          {
            return "When parsing the object for %what%, the \"Tournaments\" field was missing.";
          }
        return null;
      }

    public static new SportsStandingsArgumentTournamentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentTournamentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentTournament", ignore_extras);
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
    public static new SportsStandingsArgumentTournamentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsStandingsArgumentTournamentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentTournamentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentTournament", ignore_extras);
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
    public static new SportsStandingsArgumentTournamentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsStandingsArgumentTournamentJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsArgumentTournamentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentTournament", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsArgumentTournamentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsStandingsArgumentTournamentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsArgumentTournamentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentTournament", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsStandingsArgumentJSON.Generator
      {
        private SportsTournamentCodeJSON.HoldingArrayGenerator fieldGeneratorTournaments;
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
            if (!(getSportsStandingsArgumentJSONKey().Equals("Tournament")))
                throw new Exception("The key field has a value other than `Tournament'.");
            SportsStandingsArgumentTournamentJSON result = new SportsStandingsArgumentTournamentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStandingsArgumentTournamentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsStandingsArgumentJSON new_result)
          {
            handle_result((SportsStandingsArgumentTournamentJSON )new_result);
          }
        protected void finish(SportsStandingsArgumentTournamentJSON result)
          {
            if (fieldGeneratorTournaments.have_value)
              {
                result.initTournaments();
                int count = fieldGeneratorTournaments.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTournaments(fieldGeneratorTournaments.value[num]);
                  }
                fieldGeneratorTournaments.value.Clear();
                fieldGeneratorTournaments.have_value = false;
              }
            else if ((!(result.hasTournaments())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Tournaments\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsStandingsArgumentTournamentJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Tournaments", 0, 11, false) == 0) && (field_name.Length == 11))
                return fieldGeneratorTournaments;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorTournaments = new SportsTournamentCodeJSON.HoldingArrayGenerator("field \"Tournaments\" of the SportsStandingsArgumentTournament class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStandingsArgumentTournament class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorTournaments = new SportsTournamentCodeJSON.HoldingArrayGenerator("field \"Tournaments\" of the SportsStandingsArgumentTournament class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStandingsArgumentTournament class");
          }

        public override void reset()
          {
            fieldGeneratorTournaments.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStandingsArgumentTournamentJSON  result)
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
        public SportsStandingsArgumentTournamentJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsArgumentTournamentJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsArgumentTournamentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsArgumentTournamentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsArgumentTournamentJSON>();
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
    public List<SportsStandingsArgumentTournamentJSON> value;
  };
  };
