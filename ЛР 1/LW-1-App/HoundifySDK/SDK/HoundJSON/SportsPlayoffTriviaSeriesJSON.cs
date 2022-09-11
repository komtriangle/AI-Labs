/* file "SportsPlayoffTriviaSeriesJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsPlayoffTriviaSeriesJSON : JSONBase
  {
    private bool flagHasSeriesGames;
    private List< SportsGameJSON  > storeSeriesGames;
    private bool flagHasSeason;
    private SportsSeasonResolvedJSON  storeSeason;
    private bool flagHasSeriesStatus;
    private SportsSeriesStatusNewJSON  storeSeriesStatus;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSeriesGames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SeriesGames of SportsPlayoffTriviaSeriesJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsGameJSON  > vector_SeriesGames1 = new List< SportsGameJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsGameJSON convert_classy = SportsGameJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_SeriesGames1.Add(convert_classy);
          }
        initSeriesGames();
        for (int num1 = 0; num1 < vector_SeriesGames1.Count; ++num1)
            appendSeriesGames(vector_SeriesGames1[num1]);
        for (int num1 = 0; num1 < vector_SeriesGames1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSeason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSeasonResolvedJSON convert_classy = SportsSeasonResolvedJSON.from_json(json_value, ignore_extras, true);
        setSeason(convert_classy);
      }


    private void  fromJSONSeriesStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsSeriesStatusNewJSON convert_classy = SportsSeriesStatusNewJSON.from_json(json_value, ignore_extras, true);
        setSeriesStatus(convert_classy);
      }


    public SportsPlayoffTriviaSeriesJSON()
      {
        flagHasSeriesGames = false;
        flagHasSeason = false;
        flagHasSeriesStatus = false;
        storeSeriesGames = new List< SportsGameJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSeriesGames()
      {
        return flagHasSeriesGames;
      }

    public int  countOfSeriesGames()
      {
        Debug.Assert(flagHasSeriesGames);
        return storeSeriesGames.Count;
      }

    public SportsGameJSON   elementOfSeriesGames(int element_num)
      {
        Debug.Assert(flagHasSeriesGames);
        return storeSeriesGames[element_num];
      }

    public List< SportsGameJSON  >  getSeriesGames()
      {
        Debug.Assert(flagHasSeriesGames);
        return storeSeriesGames;
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

    public bool  hasSeriesStatus()
      {
        return flagHasSeriesStatus;
      }

    public SportsSeriesStatusNewJSON   getSeriesStatus()
      {
        Debug.Assert(flagHasSeriesStatus);
        return storeSeriesStatus;
      }


    public virtual int extraSportsPlayoffTriviaSeriesComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsPlayoffTriviaSeriesComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsPlayoffTriviaSeriesComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsPlayoffTriviaSeriesLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initSeriesGames()
      {
        if (flagHasSeriesGames)
          {
            for (int num1 = 0; num1 < storeSeriesGames.Count; ++num1)
              {
              }
          }
        flagHasSeriesGames = true;
        storeSeriesGames.Clear();
      }
    public void appendSeriesGames(SportsGameJSON  to_append)
      {
        if (!flagHasSeriesGames)
          {
            flagHasSeriesGames = true;
            storeSeriesGames.Clear();
          }
        Debug.Assert(flagHasSeriesGames);
        storeSeriesGames.Add(to_append);
      }
    public void unsetSeriesGames()
      {
        if (flagHasSeriesGames)
          {
            for (int num2 = 0; num2 < storeSeriesGames.Count; ++num2)
              {
              }
          }
        flagHasSeriesGames = false;
        storeSeriesGames.Clear();
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
    public void setSeriesStatus(SportsSeriesStatusNewJSON  new_value)
      {
        if (flagHasSeriesStatus)
          {
          }
        flagHasSeriesStatus = true;
        storeSeriesStatus = new_value;
      }
    public void unsetSeriesStatus()
      {
        if (flagHasSeriesStatus)
          {
          }
        flagHasSeriesStatus = false;
      }

    public virtual void extraSportsPlayoffTriviaSeriesAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsPlayoffTriviaSeriesSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsPlayoffTriviaSeriesLookup(key);
        if (old_field == null)
          {
            extraSportsPlayoffTriviaSeriesAppendPair(key, new_component);
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
        if (flagHasSeriesGames)
          {
            handler.start_pair("SeriesGames");
            handler.start_array();
            for (int num1 = 0; num1 < storeSeriesGames.Count; ++num1)
              {
                if (partial_allowed)
                    storeSeriesGames[num1].write_partial_as_json(handler);
                else
                    storeSeriesGames[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSeason)
          {
            handler.start_pair("Season");
            if (partial_allowed)
                storeSeason.write_partial_as_json(handler);
            else
                storeSeason.write_as_json(handler);
          }
        if (flagHasSeriesStatus)
          {
            handler.start_pair("SeriesStatus");
            if (partial_allowed)
                storeSeriesStatus.write_partial_as_json(handler);
            else
                storeSeriesStatus.write_as_json(handler);
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

    public static SportsPlayoffTriviaSeriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffTriviaSeriesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaSeries", ignore_extras);
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
    public static SportsPlayoffTriviaSeriesJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayoffTriviaSeriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsPlayoffTriviaSeriesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaSeries", ignore_extras);
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
    public static SportsPlayoffTriviaSeriesJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsPlayoffTriviaSeriesJSON from_text(string text, bool ignore_extras)
      {
        SportsPlayoffTriviaSeriesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaSeries", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsPlayoffTriviaSeriesJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsPlayoffTriviaSeriesJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsPlayoffTriviaSeriesJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsPlayoffTriviaSeries", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsGameJSON.HoldingArrayGenerator fieldGeneratorSeriesGames;
        private SportsSeasonResolvedJSON.HoldingGenerator fieldGeneratorSeason;
        private SportsSeriesStatusNewJSON.HoldingGenerator fieldGeneratorSeriesStatus;
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
            SportsPlayoffTriviaSeriesJSON result = new SportsPlayoffTriviaSeriesJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsPlayoffTriviaSeriesAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsPlayoffTriviaSeriesJSON result)
          {
            if (fieldGeneratorSeriesGames.have_value)
              {
                result.initSeriesGames();
                int count = fieldGeneratorSeriesGames.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSeriesGames(fieldGeneratorSeriesGames.value[num]);
                  }
                fieldGeneratorSeriesGames.value.Clear();
                fieldGeneratorSeriesGames.have_value = false;
              }
            if (fieldGeneratorSeason.have_value)
              {
                result.setSeason(fieldGeneratorSeason.value);
                fieldGeneratorSeason.have_value = false;
              }
            if (fieldGeneratorSeriesStatus.have_value)
              {
                result.setSeriesStatus(fieldGeneratorSeriesStatus.value);
                fieldGeneratorSeriesStatus.have_value = false;
              }
          }
        protected abstract void handle_result(SportsPlayoffTriviaSeriesJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Se", 0, 2, false) == 0)
              {
                switch (field_name[2])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 3, "son", 0, 3, false) == 0) && (field_name.Length == 6))
                            return fieldGeneratorSeason;
                        break;
                    case 'r':
                        if (String.Compare(field_name, 3, "ies", 0, 3, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'G':
                                    if ((String.Compare(field_name, 7, "ames", 0, 4, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorSeriesGames;
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 7, "tatus", 0, 5, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorSeriesStatus;
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
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorSeriesGames = new SportsGameJSON.HoldingArrayGenerator("field \"SeriesGames\" of the SportsPlayoffTriviaSeries class", ignore_extras);
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsPlayoffTriviaSeries class", ignore_extras);
            fieldGeneratorSeriesStatus = new SportsSeriesStatusNewJSON.HoldingGenerator("field \"SeriesStatus\" of the SportsPlayoffTriviaSeries class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsPlayoffTriviaSeries class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSeriesGames = new SportsGameJSON.HoldingArrayGenerator("field \"SeriesGames\" of the SportsPlayoffTriviaSeries class", false);
            fieldGeneratorSeason = new SportsSeasonResolvedJSON.HoldingGenerator("field \"Season\" of the SportsPlayoffTriviaSeries class", false);
            fieldGeneratorSeriesStatus = new SportsSeriesStatusNewJSON.HoldingGenerator("field \"SeriesStatus\" of the SportsPlayoffTriviaSeries class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsPlayoffTriviaSeries class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSeriesGames.reset();
            fieldGeneratorSeason.reset();
            fieldGeneratorSeriesStatus.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSeriesGames.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeason.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSeriesStatus.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSeriesGames.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeason.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSeriesStatus.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsPlayoffTriviaSeriesJSON  result)
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
        public SportsPlayoffTriviaSeriesJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsPlayoffTriviaSeriesJSON  result)
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
    protected virtual void handle_result(List<SportsPlayoffTriviaSeriesJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsPlayoffTriviaSeriesJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsPlayoffTriviaSeriesJSON>();
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
    public List<SportsPlayoffTriviaSeriesJSON> value;
  };
  };
