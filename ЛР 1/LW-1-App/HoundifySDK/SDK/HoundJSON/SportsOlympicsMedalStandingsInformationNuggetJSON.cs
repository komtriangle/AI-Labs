/* file "SportsOlympicsMedalStandingsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsOlympicsMedalStandingsInformationNuggetJSON : SportsOlympicsInformationNuggetJSON
  {
    private bool flagHasQueryComponents;
    private List< SportsOlympicsMedalStandingsQueryComponentJSON  > storeQueryComponents;
    private bool flagHasMedalStandings;
    private List< SportsOlympicsMedalStandingsJSON  > storeMedalStandings;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraQueryComponentsToJSON()
      {
        JSONArrayValue generated_array_1_QueryComponents = new JSONArrayValue();
        for (int num1 = 0; num1 < storeQueryComponents.Count; ++num1)
          {
            JSONValueHandler handler_QueryComponents = new JSONValueHandler();
            storeQueryComponents[num1].write_as_json(handler_QueryComponents);
            generated_array_1_QueryComponents.appendComponent(handler_QueryComponents.result);
          }
        return generated_array_1_QueryComponents;
      }

    private JSONValue  extraMedalStandingsToJSON()
      {
        JSONArrayValue generated_array_2_MedalStandings = new JSONArrayValue();
        for (int num2 = 0; num2 < storeMedalStandings.Count; ++num2)
          {
            JSONValueHandler handler_MedalStandings = new JSONValueHandler();
            storeMedalStandings[num2].write_as_json(handler_MedalStandings);
            generated_array_2_MedalStandings.appendComponent(handler_MedalStandings.result);
          }
        return generated_array_2_MedalStandings;
      }


    private void  fromJSONQueryComponents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QueryComponents of SportsOlympicsMedalStandingsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsOlympicsMedalStandingsQueryComponentJSON  > vector_QueryComponents1 = new List< SportsOlympicsMedalStandingsQueryComponentJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsMedalStandingsQueryComponentJSON convert_classy = SportsOlympicsMedalStandingsQueryComponentJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_QueryComponents1.Add(convert_classy);
          }
        initQueryComponents();
        for (int num1 = 0; num1 < vector_QueryComponents1.Count; ++num1)
            appendQueryComponents(vector_QueryComponents1[num1]);
        for (int num1 = 0; num1 < vector_QueryComponents1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMedalStandings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MedalStandings of SportsOlympicsMedalStandingsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsOlympicsMedalStandingsJSON  > vector_MedalStandings1 = new List< SportsOlympicsMedalStandingsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsMedalStandingsJSON convert_classy = SportsOlympicsMedalStandingsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_MedalStandings1.Add(convert_classy);
          }
        initMedalStandings();
        for (int num2 = 0; num2 < vector_MedalStandings1.Count; ++num2)
            appendMedalStandings(vector_MedalStandings1[num2]);
        for (int num1 = 0; num1 < vector_MedalStandings1.Count; ++num1)
          {
          }
      }


    public SportsOlympicsMedalStandingsInformationNuggetJSON()
      {
        flagHasQueryComponents = false;
        flagHasMedalStandings = false;
        storeQueryComponents = new List< SportsOlympicsMedalStandingsQueryComponentJSON  >();
        storeMedalStandings = new List< SportsOlympicsMedalStandingsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getSportsOlympicsInformationNuggetKind()
      {
        return "SportsOlympicsMedalStandingsInformationNugget";
      }

    public bool  hasQueryComponents()
      {
        return flagHasQueryComponents;
      }

    public int  countOfQueryComponents()
      {
        Debug.Assert(flagHasQueryComponents);
        return storeQueryComponents.Count;
      }

    public SportsOlympicsMedalStandingsQueryComponentJSON   elementOfQueryComponents(int element_num)
      {
        Debug.Assert(flagHasQueryComponents);
        return storeQueryComponents[element_num];
      }

    public List< SportsOlympicsMedalStandingsQueryComponentJSON  >  getQueryComponents()
      {
        Debug.Assert(flagHasQueryComponents);
        return storeQueryComponents;
      }

    public bool  hasMedalStandings()
      {
        return flagHasMedalStandings;
      }

    public int  countOfMedalStandings()
      {
        Debug.Assert(flagHasMedalStandings);
        return storeMedalStandings.Count;
      }

    public SportsOlympicsMedalStandingsJSON   elementOfMedalStandings(int element_num)
      {
        Debug.Assert(flagHasMedalStandings);
        return storeMedalStandings[element_num];
      }

    public List< SportsOlympicsMedalStandingsJSON  >  getMedalStandings()
      {
        Debug.Assert(flagHasMedalStandings);
        return storeMedalStandings;
      }


    public virtual int extraSportsOlympicsMedalStandingsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsMedalStandingsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsMedalStandingsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSportsOlympicsInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasQueryComponents)
            ++result;
        if (flagHasMedalStandings)
            ++result;
        result += extraSportsOlympicsMedalStandingsInformationNuggetComponentCount();
        return result;
      }
    public override string extraSportsOlympicsInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryComponents)
          {
            if (remainder == 0)
                return "QueryComponents";
            --remainder;
          }
        if (flagHasMedalStandings)
          {
            if (remainder == 0)
                return "MedalStandings";
            --remainder;
          }
        return extraSportsOlympicsMedalStandingsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraSportsOlympicsInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryComponents)
          {
            if (remainder == 0)
                return extraQueryComponentsToJSON();
            --remainder;
          }
        if (flagHasMedalStandings)
          {
            if (remainder == 0)
                return extraMedalStandingsToJSON();
            --remainder;
          }
        return extraSportsOlympicsMedalStandingsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraSportsOlympicsInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'M':
                if ((String.Compare(field_name, 1, "edalStandings", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasMedalStandings ? extraMedalStandingsToJSON() : null);
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "ueryComponents", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasQueryComponents ? extraQueryComponentsToJSON() : null);
                break;
            default:
                break;
          }
        return extraSportsOlympicsMedalStandingsInformationNuggetLookup(field_name);
      }

    public void initQueryComponents()
      {
        if (flagHasQueryComponents)
          {
            for (int num1 = 0; num1 < storeQueryComponents.Count; ++num1)
              {
              }
          }
        flagHasQueryComponents = true;
        storeQueryComponents.Clear();
      }
    public void appendQueryComponents(SportsOlympicsMedalStandingsQueryComponentJSON  to_append)
      {
        if (!flagHasQueryComponents)
          {
            flagHasQueryComponents = true;
            storeQueryComponents.Clear();
          }
        Debug.Assert(flagHasQueryComponents);
        storeQueryComponents.Add(to_append);
      }
    public void unsetQueryComponents()
      {
        if (flagHasQueryComponents)
          {
            for (int num2 = 0; num2 < storeQueryComponents.Count; ++num2)
              {
              }
          }
        flagHasQueryComponents = false;
        storeQueryComponents.Clear();
      }
    public void initMedalStandings()
      {
        if (flagHasMedalStandings)
          {
            for (int num3 = 0; num3 < storeMedalStandings.Count; ++num3)
              {
              }
          }
        flagHasMedalStandings = true;
        storeMedalStandings.Clear();
      }
    public void appendMedalStandings(SportsOlympicsMedalStandingsJSON  to_append)
      {
        if (!flagHasMedalStandings)
          {
            flagHasMedalStandings = true;
            storeMedalStandings.Clear();
          }
        Debug.Assert(flagHasMedalStandings);
        storeMedalStandings.Add(to_append);
      }
    public void unsetMedalStandings()
      {
        if (flagHasMedalStandings)
          {
            for (int num4 = 0; num4 < storeMedalStandings.Count; ++num4)
              {
              }
          }
        flagHasMedalStandings = false;
        storeMedalStandings.Clear();
      }

    public virtual void extraSportsOlympicsMedalStandingsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsMedalStandingsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsMedalStandingsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsMedalStandingsInformationNuggetAppendPair(key, new_component);
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
    public override void extraSportsOlympicsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                if ((String.Compare(key, 1, "edalStandings", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONMedalStandings(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryComponents", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONQueryComponents(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSportsOlympicsMedalStandingsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraSportsOlympicsInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                if ((String.Compare(key, 1, "edalStandings", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONMedalStandings(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryComponents", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONQueryComponents(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSportsOlympicsMedalStandingsInformationNuggetSetField(key, new_component);
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
        if (flagHasQueryComponents)
          {
            handler.start_pair("QueryComponents");
            handler.start_array();
            for (int num1 = 0; num1 < storeQueryComponents.Count; ++num1)
              {
                if (partial_allowed)
                    storeQueryComponents[num1].write_partial_as_json(handler);
                else
                    storeQueryComponents[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasMedalStandings)
          {
            handler.start_pair("MedalStandings");
            handler.start_array();
            for (int num2 = 0; num2 < storeMedalStandings.Count; ++num2)
              {
                if (partial_allowed)
                    storeMedalStandings[num2].write_partial_as_json(handler);
                else
                    storeMedalStandings[num2].write_as_json(handler);
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
        return null;
      }

    public static new SportsOlympicsMedalStandingsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsInformationNugget", ignore_extras);
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
    public static new SportsOlympicsMedalStandingsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsMedalStandingsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsMedalStandingsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsInformationNugget", ignore_extras);
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
    public static new SportsOlympicsMedalStandingsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsOlympicsMedalStandingsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsMedalStandingsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsOlympicsMedalStandingsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsMedalStandingsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsMedalStandingsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsOlympicsInformationNuggetJSON.Generator
      {
        private SportsOlympicsMedalStandingsQueryComponentJSON.HoldingArrayGenerator fieldGeneratorQueryComponents;
        private SportsOlympicsMedalStandingsJSON.HoldingArrayGenerator fieldGeneratorMedalStandings;
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
            if (!(getSportsOlympicsInformationNuggetJSONKey().Equals("SportsOlympicsMedalStandingsInformationNugget")))
                throw new Exception("The key field has a value other than `SportsOlympicsMedalStandingsInformationNugget'.");
            SportsOlympicsMedalStandingsInformationNuggetJSON result = new SportsOlympicsMedalStandingsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsMedalStandingsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SportsOlympicsInformationNuggetJSON new_result)
          {
            handle_result((SportsOlympicsMedalStandingsInformationNuggetJSON )new_result);
          }
        protected void finish(SportsOlympicsMedalStandingsInformationNuggetJSON result)
          {
            if (fieldGeneratorQueryComponents.have_value)
              {
                result.initQueryComponents();
                int count = fieldGeneratorQueryComponents.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQueryComponents(fieldGeneratorQueryComponents.value[num]);
                  }
                fieldGeneratorQueryComponents.value.Clear();
                fieldGeneratorQueryComponents.have_value = false;
              }
            if (fieldGeneratorMedalStandings.have_value)
              {
                result.initMedalStandings();
                int count = fieldGeneratorMedalStandings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMedalStandings(fieldGeneratorMedalStandings.value[num]);
                  }
                fieldGeneratorMedalStandings.value.Clear();
                fieldGeneratorMedalStandings.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsOlympicsMedalStandingsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'M':
                    if ((String.Compare(field_name, 1, "edalStandings", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorMedalStandings;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryComponents", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorQueryComponents;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorQueryComponents = new SportsOlympicsMedalStandingsQueryComponentJSON.HoldingArrayGenerator("field \"QueryComponents\" of the SportsOlympicsMedalStandingsInformationNugget class", ignore_extras);
            fieldGeneratorMedalStandings = new SportsOlympicsMedalStandingsJSON.HoldingArrayGenerator("field \"MedalStandings\" of the SportsOlympicsMedalStandingsInformationNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsMedalStandingsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQueryComponents = new SportsOlympicsMedalStandingsQueryComponentJSON.HoldingArrayGenerator("field \"QueryComponents\" of the SportsOlympicsMedalStandingsInformationNugget class", false);
            fieldGeneratorMedalStandings = new SportsOlympicsMedalStandingsJSON.HoldingArrayGenerator("field \"MedalStandings\" of the SportsOlympicsMedalStandingsInformationNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsMedalStandingsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorQueryComponents.reset();
            fieldGeneratorMedalStandings.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsMedalStandingsInformationNuggetJSON  result)
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
        public SportsOlympicsMedalStandingsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsMedalStandingsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsMedalStandingsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsMedalStandingsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsMedalStandingsInformationNuggetJSON>();
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
    public List<SportsOlympicsMedalStandingsInformationNuggetJSON> value;
  };
  };
