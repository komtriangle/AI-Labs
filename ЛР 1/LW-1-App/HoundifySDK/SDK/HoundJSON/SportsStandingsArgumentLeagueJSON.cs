/* file "SportsStandingsArgumentLeagueJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsStandingsArgumentLeagueJSON : SportsStandingsArgumentJSON
  {
    private bool flagHasLeagues;
    private List< SportsLeagueCodeJSON  > storeLeagues;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraLeaguesToJSON()
      {
        JSONArrayValue generated_array_1_Leagues = new JSONArrayValue();
        for (int num1 = 0; num1 < storeLeagues.Count; ++num1)
          {
            JSONValueHandler handler_Leagues = new JSONValueHandler();
            storeLeagues[num1].write_as_json(handler_Leagues);
            generated_array_1_Leagues.appendComponent(handler_Leagues.result);
          }
        return generated_array_1_Leagues;
      }


    private void  fromJSONLeagues(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Leagues of SportsStandingsArgumentLeagueJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Leagues of SportsStandingsArgumentLeagueJSON has too few elements.");
        List< SportsLeagueCodeJSON  > vector_Leagues1 = new List< SportsLeagueCodeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsLeagueCodeJSON convert_classy = SportsLeagueCodeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Leagues1.Add(convert_classy);
          }
        Debug.Assert(vector_Leagues1.Count >= 1);
        initLeagues();
        for (int num1 = 0; num1 < vector_Leagues1.Count; ++num1)
            appendLeagues(vector_Leagues1[num1]);
        for (int num1 = 0; num1 < vector_Leagues1.Count; ++num1)
          {
          }
      }


    public SportsStandingsArgumentLeagueJSON()
      {
        flagHasLeagues = false;
        storeLeagues = new List< SportsLeagueCodeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsStandingsArgumentKind()
      {
        return "League";
      }

    public bool  hasLeagues()
      {
        return flagHasLeagues;
      }

    public int  countOfLeagues()
      {
        Debug.Assert(flagHasLeagues);
        return storeLeagues.Count;
      }

    public SportsLeagueCodeJSON   elementOfLeagues(int element_num)
      {
        Debug.Assert(flagHasLeagues);
        return storeLeagues[element_num];
      }

    public List< SportsLeagueCodeJSON  >  getLeagues()
      {
        Debug.Assert(flagHasLeagues);
        return storeLeagues;
      }


    public virtual int extraSportsStandingsArgumentLeagueComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsStandingsArgumentLeagueComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentLeagueComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsStandingsArgumentLeagueLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsStandingsArgumentComponentCount()
      {
        int result = 0;
        if (flagHasLeagues)
            ++result;
        result += extraSportsStandingsArgumentLeagueComponentCount();
        return result;
      }
    public override string extraSportsStandingsArgumentComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasLeagues)
          {
            if (remainder == 0)
                return "Leagues";
            --remainder;
          }
        return extraSportsStandingsArgumentLeagueComponentKey(remainder);
      }
    public override JSONValue extraSportsStandingsArgumentComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasLeagues)
          {
            if (remainder == 0)
                return extraLeaguesToJSON();
            --remainder;
          }
        return extraSportsStandingsArgumentLeagueComponentValue(remainder);
      }
    public override JSONValue extraSportsStandingsArgumentLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "Leagues", 0, 7, false) == 0) && (field_name.Length == 7))
            return (flagHasLeagues ? extraLeaguesToJSON() : null);
        return extraSportsStandingsArgumentLeagueLookup(field_name);
      }

    public void initLeagues()
      {
        if (flagHasLeagues)
          {
            for (int num1 = 0; num1 < storeLeagues.Count; ++num1)
              {
              }
          }
        flagHasLeagues = true;
        storeLeagues.Clear();
      }
    public void appendLeagues(SportsLeagueCodeJSON  to_append)
      {
        if (!flagHasLeagues)
          {
            flagHasLeagues = true;
            storeLeagues.Clear();
          }
        Debug.Assert(flagHasLeagues);
        storeLeagues.Add(to_append);
      }
    public void appendLeagues(SportsLeagueCodeJSON.TypeValue new_value)
      {
        appendLeagues(new SportsLeagueCodeJSON(new_value));
      }
    public void appendLeagues(string chars)
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
        appendLeagues(new_value);
      }
    public void unsetLeagues()
      {
        if (flagHasLeagues)
          {
            for (int num2 = 0; num2 < storeLeagues.Count; ++num2)
              {
              }
          }
        flagHasLeagues = false;
        storeLeagues.Clear();
      }

    public virtual void extraSportsStandingsArgumentLeagueAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsStandingsArgumentLeagueSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsStandingsArgumentLeagueLookup(key);
        if (old_field == null)
          {
            extraSportsStandingsArgumentLeagueAppendPair(key, new_component);
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
        if ((String.Compare(key, 0, "Leagues", 0, 7, false) == 0) && (key.Length == 7))
            {
            fromJSONLeagues(new_component, false);
            return;
            }
        extraSportsStandingsArgumentLeagueAppendPair(key, new_component);
      }
    public override void extraSportsStandingsArgumentSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "Leagues", 0, 7, false) == 0) && (key.Length == 7))
            {
            fromJSONLeagues(new_component, false);
            return;
            }
        extraSportsStandingsArgumentLeagueSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasLeagues);
        if (flagHasLeagues)
          {
            handler.start_pair("Leagues");
            Debug.Assert(storeLeagues.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeLeagues.Count; ++num1)
              {
                if (partial_allowed)
                    storeLeagues[num1].write_partial_as_json(handler);
                else
                    storeLeagues[num1].write_as_json(handler);
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
        if (!(hasLeagues()))
          {
            return "When parsing the object for %what%, the \"Leagues\" field was missing.";
          }
        return null;
      }

    public static new SportsStandingsArgumentLeagueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentLeagueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentLeague", ignore_extras);
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
    public static new SportsStandingsArgumentLeagueJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsStandingsArgumentLeagueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsStandingsArgumentLeagueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentLeague", ignore_extras);
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
    public static new SportsStandingsArgumentLeagueJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsStandingsArgumentLeagueJSON from_text(string text, bool ignore_extras)
      {
        SportsStandingsArgumentLeagueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentLeague", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsStandingsArgumentLeagueJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsStandingsArgumentLeagueJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsStandingsArgumentLeagueJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsStandingsArgumentLeague", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsStandingsArgumentJSON.Generator
      {
        private SportsLeagueCodeJSON.HoldingArrayGenerator fieldGeneratorLeagues;
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
            if (!(getSportsStandingsArgumentJSONKey().Equals("League")))
                throw new Exception("The key field has a value other than `League'.");
            SportsStandingsArgumentLeagueJSON result = new SportsStandingsArgumentLeagueJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsStandingsArgumentLeagueAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsStandingsArgumentJSON new_result)
          {
            handle_result((SportsStandingsArgumentLeagueJSON )new_result);
          }
        protected void finish(SportsStandingsArgumentLeagueJSON result)
          {
            if (fieldGeneratorLeagues.have_value)
              {
                result.initLeagues();
                int count = fieldGeneratorLeagues.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendLeagues(fieldGeneratorLeagues.value[num]);
                  }
                fieldGeneratorLeagues.value.Clear();
                fieldGeneratorLeagues.have_value = false;
              }
            else if ((!(result.hasLeagues())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Leagues\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsStandingsArgumentLeagueJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "Leagues", 0, 7, false) == 0) && (field_name.Length == 7))
                return fieldGeneratorLeagues;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorLeagues = new SportsLeagueCodeJSON.HoldingArrayGenerator("field \"Leagues\" of the SportsStandingsArgumentLeague class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsStandingsArgumentLeague class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorLeagues = new SportsLeagueCodeJSON.HoldingArrayGenerator("field \"Leagues\" of the SportsStandingsArgumentLeague class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsStandingsArgumentLeague class");
          }

        public override void reset()
          {
            fieldGeneratorLeagues.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsStandingsArgumentLeagueJSON  result)
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
        public SportsStandingsArgumentLeagueJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsStandingsArgumentLeagueJSON  result)
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
    protected virtual void handle_result(List<SportsStandingsArgumentLeagueJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsStandingsArgumentLeagueJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsStandingsArgumentLeagueJSON>();
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
    public List<SportsStandingsArgumentLeagueJSON> value;
  };
  };
