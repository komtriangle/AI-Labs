/* file "SportsOlympicsEventSchedulesAndResultsQueryComponentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsOlympicsEventSchedulesAndResultsQueryComponentJSON : JSONBase
  {
    private bool flagHasQueryType;
    private SportsOlympicsEventSchedulesAndResultsQueryTypeJSON  storeQueryType;
    private bool flagHasEvents;
    private List< SportsOlympicsEventJSON  > storeEvents;
    private bool flagHasGames;
    private SportsOlympicsGamesJSON  storeGames;
    private bool flagHasRank;
    private BigInteger storeRank;
    private bool flagHasDateTimeRange;
    private DateTimeRangeSpecJSON  storeDateTimeRange;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsEventSchedulesAndResultsQueryTypeJSON convert_classy = SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.from_json(json_value, ignore_extras, true);
        setQueryType(convert_classy);
      }


    private void  fromJSONEvents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Events of SportsOlympicsEventSchedulesAndResultsQueryComponentJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Events of SportsOlympicsEventSchedulesAndResultsQueryComponentJSON has too few elements.");
        List< SportsOlympicsEventJSON  > vector_Events1 = new List< SportsOlympicsEventJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsEventJSON convert_classy = SportsOlympicsEventJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Events1.Add(convert_classy);
          }
        Debug.Assert(vector_Events1.Count >= 1);
        initEvents();
        for (int num1 = 0; num1 < vector_Events1.Count; ++num1)
            appendEvents(vector_Events1[num1]);
        for (int num1 = 0; num1 < vector_Events1.Count; ++num1)
          {
          }
      }


    private void  fromJSONGames(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsGamesJSON convert_classy = SportsOlympicsGamesJSON.from_json(json_value, ignore_extras, true);
        setGames(convert_classy);
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
                throw new Exception("The value for field Rank of SportsOlympicsEventSchedulesAndResultsQueryComponentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Rank of SportsOlympicsEventSchedulesAndResultsQueryComponentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRank(extracted_integer);
      }


    private void  fromJSONDateTimeRange(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateTimeRangeSpecJSON convert_classy = DateTimeRangeSpecJSON.from_json(json_value, ignore_extras, true);
        setDateTimeRange(convert_classy);
      }


    public SportsOlympicsEventSchedulesAndResultsQueryComponentJSON()
      {
        flagHasQueryType = false;
        flagHasEvents = false;
        flagHasGames = false;
        flagHasRank = false;
        flagHasDateTimeRange = false;
        storeEvents = new List< SportsOlympicsEventJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQueryType()
      {
        return flagHasQueryType;
      }

    public SportsOlympicsEventSchedulesAndResultsQueryTypeJSON   getQueryType()
      {
        Debug.Assert(flagHasQueryType);
        return storeQueryType;
      }

    public SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.TypeValue  getQueryTypeValue()
      {
        return getQueryType().getValue();
      }

    public string  getQueryTypeAsString()
      {
        return getQueryType().getValueAsString();
      }

    public bool  hasEvents()
      {
        return flagHasEvents;
      }

    public int  countOfEvents()
      {
        Debug.Assert(flagHasEvents);
        return storeEvents.Count;
      }

    public SportsOlympicsEventJSON   elementOfEvents(int element_num)
      {
        Debug.Assert(flagHasEvents);
        return storeEvents[element_num];
      }

    public List< SportsOlympicsEventJSON  >  getEvents()
      {
        Debug.Assert(flagHasEvents);
        return storeEvents;
      }

    public bool  hasGames()
      {
        return flagHasGames;
      }

    public SportsOlympicsGamesJSON   getGames()
      {
        Debug.Assert(flagHasGames);
        return storeGames;
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

    public bool  hasDateTimeRange()
      {
        return flagHasDateTimeRange;
      }

    public DateTimeRangeSpecJSON   getDateTimeRange()
      {
        Debug.Assert(flagHasDateTimeRange);
        return storeDateTimeRange;
      }


    public virtual int extraSportsOlympicsEventSchedulesAndResultsQueryComponentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsEventSchedulesAndResultsQueryComponentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsQueryComponentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsQueryComponentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setQueryType(SportsOlympicsEventSchedulesAndResultsQueryTypeJSON  new_value)
      {
        if (flagHasQueryType)
          {
          }
        flagHasQueryType = true;
        storeQueryType = new_value;
      }
    public void setQueryType(SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.TypeValue new_value)
      {
        setQueryType(new SportsOlympicsEventSchedulesAndResultsQueryTypeJSON(new_value));
      }
    public void setQueryType(string chars)
      {
        SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.TypeValueKnownValues known = SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.stringToValue(chars);
        SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.TypeValue new_value = new SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.TypeValue();
        if (known == SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setQueryType(new_value);
      }
    public void unsetQueryType()
      {
        if (flagHasQueryType)
          {
          }
        flagHasQueryType = false;
      }
    public void initEvents()
      {
        if (flagHasEvents)
          {
            for (int num1 = 0; num1 < storeEvents.Count; ++num1)
              {
              }
          }
        flagHasEvents = true;
        storeEvents.Clear();
      }
    public void appendEvents(SportsOlympicsEventJSON  to_append)
      {
        if (!flagHasEvents)
          {
            flagHasEvents = true;
            storeEvents.Clear();
          }
        Debug.Assert(flagHasEvents);
        storeEvents.Add(to_append);
      }
    public void appendEvents(SportsOlympicsEventJSON.TypeValue new_value)
      {
        appendEvents(new SportsOlympicsEventJSON(new_value));
      }
    public void appendEvents(string chars)
      {
        SportsOlympicsEventJSON.TypeValueKnownValues known = SportsOlympicsEventJSON.stringToValue(chars);
        SportsOlympicsEventJSON.TypeValue new_value = new SportsOlympicsEventJSON.TypeValue();
        if (known == SportsOlympicsEventJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendEvents(new_value);
      }
    public void unsetEvents()
      {
        if (flagHasEvents)
          {
            for (int num2 = 0; num2 < storeEvents.Count; ++num2)
              {
              }
          }
        flagHasEvents = false;
        storeEvents.Clear();
      }
    public void setGames(SportsOlympicsGamesJSON  new_value)
      {
        if (flagHasGames)
          {
          }
        flagHasGames = true;
        storeGames = new_value;
      }
    public void unsetGames()
      {
        if (flagHasGames)
          {
          }
        flagHasGames = false;
      }
    public void setRank(BigInteger new_value)
      {
        flagHasRank = true;
        if (new_value < 1)
            throw new Exception("The value for field Rank of SportsOlympicsEventSchedulesAndResultsQueryComponentJSON is less than the lower bound (1) for that field.");
        storeRank = new_value;
      }
    public void unsetRank()
      {
        flagHasRank = false;
      }
    public void setDateTimeRange(DateTimeRangeSpecJSON  new_value)
      {
        if (flagHasDateTimeRange)
          {
          }
        flagHasDateTimeRange = true;
        storeDateTimeRange = new_value;
      }
    public void unsetDateTimeRange()
      {
        if (flagHasDateTimeRange)
          {
          }
        flagHasDateTimeRange = false;
      }

    public virtual void extraSportsOlympicsEventSchedulesAndResultsQueryComponentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsEventSchedulesAndResultsQueryComponentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsEventSchedulesAndResultsQueryComponentLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsEventSchedulesAndResultsQueryComponentAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryType);
        if (flagHasQueryType)
          {
            handler.start_pair("QueryType");
            if (partial_allowed)
                storeQueryType.write_partial_as_json(handler);
            else
                storeQueryType.write_as_json(handler);
          }
        if (flagHasEvents)
          {
            handler.start_pair("Events");
            Debug.Assert(storeEvents.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeEvents.Count; ++num1)
              {
                if (partial_allowed)
                    storeEvents[num1].write_partial_as_json(handler);
                else
                    storeEvents[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasGames);
        if (flagHasGames)
          {
            handler.start_pair("Games");
            if (partial_allowed)
                storeGames.write_partial_as_json(handler);
            else
                storeGames.write_as_json(handler);
          }
        if (flagHasRank)
          {
            handler.start_pair("Rank");
            handler.number_value(storeRank);
          }
        if (flagHasDateTimeRange)
          {
            handler.start_pair("DateTimeRange");
            if (partial_allowed)
                storeDateTimeRange.write_partial_as_json(handler);
            else
                storeDateTimeRange.write_as_json(handler);
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
        if (!(hasQueryType()))
          {
            return "When parsing the object for %what%, the \"QueryType\" field was missing.";
          }
        if (!(hasGames()))
          {
            return "When parsing the object for %what%, the \"Games\" field was missing.";
          }
        return null;
      }

    public static SportsOlympicsEventSchedulesAndResultsQueryComponentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsQueryComponentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsQueryComponent", ignore_extras);
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
    public static SportsOlympicsEventSchedulesAndResultsQueryComponentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventSchedulesAndResultsQueryComponentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsQueryComponentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsQueryComponent", ignore_extras);
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
    public static SportsOlympicsEventSchedulesAndResultsQueryComponentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventSchedulesAndResultsQueryComponentJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsQueryComponentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsQueryComponent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsEventSchedulesAndResultsQueryComponentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsEventSchedulesAndResultsQueryComponentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsQueryComponentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsQueryComponent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.HoldingGenerator fieldGeneratorQueryType;
        private SportsOlympicsEventJSON.HoldingArrayGenerator fieldGeneratorEvents;
        private SportsOlympicsGamesJSON.HoldingGenerator fieldGeneratorGames;
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
        private DateTimeRangeSpecJSON.HoldingGenerator fieldGeneratorDateTimeRange;
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
            SportsOlympicsEventSchedulesAndResultsQueryComponentJSON result = new SportsOlympicsEventSchedulesAndResultsQueryComponentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsEventSchedulesAndResultsQueryComponentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsEventSchedulesAndResultsQueryComponentJSON result)
          {
            if (fieldGeneratorQueryType.have_value)
              {
                result.setQueryType(fieldGeneratorQueryType.value);
                fieldGeneratorQueryType.have_value = false;
              }
            else if ((!(result.hasQueryType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryType\" field was missing.");
              }
            if (fieldGeneratorEvents.have_value)
              {
                result.initEvents();
                int count = fieldGeneratorEvents.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEvents(fieldGeneratorEvents.value[num]);
                  }
                fieldGeneratorEvents.value.Clear();
                fieldGeneratorEvents.have_value = false;
              }
            if (fieldGeneratorGames.have_value)
              {
                result.setGames(fieldGeneratorGames.value);
                fieldGeneratorGames.have_value = false;
              }
            else if ((!(result.hasGames())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Games\" field was missing.");
              }
            if (fieldGeneratorRank.have_value)
              {
                result.setRank(fieldGeneratorRank.value);
                fieldGeneratorRank.have_value = false;
              }
            if (fieldGeneratorDateTimeRange.have_value)
              {
                result.setDateTimeRange(fieldGeneratorDateTimeRange.value);
                fieldGeneratorDateTimeRange.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsEventSchedulesAndResultsQueryComponentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ateTimeRange", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorDateTimeRange;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "vents", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorEvents;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "ames", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorGames;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQueryType;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ank", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorRank;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQueryType = new SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.HoldingGenerator("field \"QueryType\" of the SportsOlympicsEventSchedulesAndResultsQueryComponent class", ignore_extras);
            fieldGeneratorEvents = new SportsOlympicsEventJSON.HoldingArrayGenerator("field \"Events\" of the SportsOlympicsEventSchedulesAndResultsQueryComponent class", ignore_extras);
            fieldGeneratorGames = new SportsOlympicsGamesJSON.HoldingGenerator("field \"Games\" of the SportsOlympicsEventSchedulesAndResultsQueryComponent class", ignore_extras);
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsOlympicsEventSchedulesAndResultsQueryComponent class");
            fieldGeneratorDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRange\" of the SportsOlympicsEventSchedulesAndResultsQueryComponent class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsEventSchedulesAndResultsQueryComponent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQueryType = new SportsOlympicsEventSchedulesAndResultsQueryTypeJSON.HoldingGenerator("field \"QueryType\" of the SportsOlympicsEventSchedulesAndResultsQueryComponent class", false);
            fieldGeneratorEvents = new SportsOlympicsEventJSON.HoldingArrayGenerator("field \"Events\" of the SportsOlympicsEventSchedulesAndResultsQueryComponent class", false);
            fieldGeneratorGames = new SportsOlympicsGamesJSON.HoldingGenerator("field \"Games\" of the SportsOlympicsEventSchedulesAndResultsQueryComponent class", false);
            fieldGeneratorRank = new FieldHoldingGeneratorRank("field \"Rank\" of the SportsOlympicsEventSchedulesAndResultsQueryComponent class");
            fieldGeneratorDateTimeRange = new DateTimeRangeSpecJSON.HoldingGenerator("field \"DateTimeRange\" of the SportsOlympicsEventSchedulesAndResultsQueryComponent class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsEventSchedulesAndResultsQueryComponent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQueryType.reset();
            fieldGeneratorEvents.reset();
            fieldGeneratorGames.reset();
            fieldGeneratorRank.reset();
            fieldGeneratorDateTimeRange.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorQueryType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEvents.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGames.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDateTimeRange.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorQueryType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEvents.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGames.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDateTimeRange.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsQueryComponentJSON  result)
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
        public SportsOlympicsEventSchedulesAndResultsQueryComponentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsQueryComponentJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsEventSchedulesAndResultsQueryComponentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsEventSchedulesAndResultsQueryComponentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsEventSchedulesAndResultsQueryComponentJSON>();
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
    public List<SportsOlympicsEventSchedulesAndResultsQueryComponentJSON> value;
  };
  };
