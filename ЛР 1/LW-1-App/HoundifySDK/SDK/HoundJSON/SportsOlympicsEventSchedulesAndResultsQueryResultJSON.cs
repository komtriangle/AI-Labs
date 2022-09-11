/* file "SportsOlympicsEventSchedulesAndResultsQueryResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SportsOlympicsEventSchedulesAndResultsQueryResultJSON : JSONBase
  {
    private bool flagHasRankResult;
    private BigInteger storeRankResult;
    private bool flagHasEventInstancesMappings;
    private List< SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON  > storeEventInstancesMappings;
    private bool flagHasError;
    private SportsOlympicsEventSchedulesAndResultsErrorJSON  storeError;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRankResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RankResult of SportsOlympicsEventSchedulesAndResultsQueryResultJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RankResult of SportsOlympicsEventSchedulesAndResultsQueryResultJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRankResult(extracted_integer);
      }


    private void  fromJSONEventInstancesMappings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field EventInstancesMappings of SportsOlympicsEventSchedulesAndResultsQueryResultJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON  > vector_EventInstancesMappings1 = new List< SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON convert_classy = SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_EventInstancesMappings1.Add(convert_classy);
          }
        initEventInstancesMappings();
        for (int num1 = 0; num1 < vector_EventInstancesMappings1.Count; ++num1)
            appendEventInstancesMappings(vector_EventInstancesMappings1[num1]);
        for (int num1 = 0; num1 < vector_EventInstancesMappings1.Count; ++num1)
          {
          }
      }


    private void  fromJSONError(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SportsOlympicsEventSchedulesAndResultsErrorJSON convert_classy = SportsOlympicsEventSchedulesAndResultsErrorJSON.from_json(json_value, ignore_extras, true);
        setError(convert_classy);
      }


    public SportsOlympicsEventSchedulesAndResultsQueryResultJSON()
      {
        flagHasRankResult = false;
        flagHasEventInstancesMappings = false;
        flagHasError = false;
        storeEventInstancesMappings = new List< SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRankResult()
      {
        return flagHasRankResult;
      }

    public BigInteger  getRankResult()
      {
        Debug.Assert(flagHasRankResult);
        return storeRankResult;
      }

    public bool  hasEventInstancesMappings()
      {
        return flagHasEventInstancesMappings;
      }

    public int  countOfEventInstancesMappings()
      {
        Debug.Assert(flagHasEventInstancesMappings);
        return storeEventInstancesMappings.Count;
      }

    public SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON   elementOfEventInstancesMappings(int element_num)
      {
        Debug.Assert(flagHasEventInstancesMappings);
        return storeEventInstancesMappings[element_num];
      }

    public List< SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON  >  getEventInstancesMappings()
      {
        Debug.Assert(flagHasEventInstancesMappings);
        return storeEventInstancesMappings;
      }

    public bool  hasError()
      {
        return flagHasError;
      }

    public SportsOlympicsEventSchedulesAndResultsErrorJSON   getError()
      {
        Debug.Assert(flagHasError);
        return storeError;
      }

    public SportsOlympicsEventSchedulesAndResultsErrorJSON.TypeValue  getErrorValue()
      {
        return getError().getValue();
      }

    public string  getErrorAsString()
      {
        return getError().getValueAsString();
      }


    public virtual int extraSportsOlympicsEventSchedulesAndResultsQueryResultComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSportsOlympicsEventSchedulesAndResultsQueryResultComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsQueryResultComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSportsOlympicsEventSchedulesAndResultsQueryResultLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setRankResult(BigInteger new_value)
      {
        flagHasRankResult = true;
        if (new_value < 1)
            throw new Exception("The value for field RankResult of SportsOlympicsEventSchedulesAndResultsQueryResultJSON is less than the lower bound (1) for that field.");
        storeRankResult = new_value;
      }
    public void unsetRankResult()
      {
        flagHasRankResult = false;
      }
    public void initEventInstancesMappings()
      {
        if (flagHasEventInstancesMappings)
          {
            for (int num1 = 0; num1 < storeEventInstancesMappings.Count; ++num1)
              {
              }
          }
        flagHasEventInstancesMappings = true;
        storeEventInstancesMappings.Clear();
      }
    public void appendEventInstancesMappings(SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON  to_append)
      {
        if (!flagHasEventInstancesMappings)
          {
            flagHasEventInstancesMappings = true;
            storeEventInstancesMappings.Clear();
          }
        Debug.Assert(flagHasEventInstancesMappings);
        storeEventInstancesMappings.Add(to_append);
      }
    public void unsetEventInstancesMappings()
      {
        if (flagHasEventInstancesMappings)
          {
            for (int num2 = 0; num2 < storeEventInstancesMappings.Count; ++num2)
              {
              }
          }
        flagHasEventInstancesMappings = false;
        storeEventInstancesMappings.Clear();
      }
    public void setError(SportsOlympicsEventSchedulesAndResultsErrorJSON  new_value)
      {
        if (flagHasError)
          {
          }
        flagHasError = true;
        storeError = new_value;
      }
    public void setError(SportsOlympicsEventSchedulesAndResultsErrorJSON.TypeValue new_value)
      {
        setError(new SportsOlympicsEventSchedulesAndResultsErrorJSON(new_value));
      }
    public void setError(string chars)
      {
        SportsOlympicsEventSchedulesAndResultsErrorJSON.TypeValueKnownValues known = SportsOlympicsEventSchedulesAndResultsErrorJSON.stringToValue(chars);
        SportsOlympicsEventSchedulesAndResultsErrorJSON.TypeValue new_value = new SportsOlympicsEventSchedulesAndResultsErrorJSON.TypeValue();
        if (known == SportsOlympicsEventSchedulesAndResultsErrorJSON.TypeValueKnownValues.Value__none)
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
    public void unsetError()
      {
        if (flagHasError)
          {
          }
        flagHasError = false;
      }

    public virtual void extraSportsOlympicsEventSchedulesAndResultsQueryResultAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSportsOlympicsEventSchedulesAndResultsQueryResultSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSportsOlympicsEventSchedulesAndResultsQueryResultLookup(key);
        if (old_field == null)
          {
            extraSportsOlympicsEventSchedulesAndResultsQueryResultAppendPair(key, new_component);
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
        if (flagHasRankResult)
          {
            handler.start_pair("RankResult");
            handler.number_value(storeRankResult);
          }
        if (flagHasEventInstancesMappings)
          {
            handler.start_pair("EventInstancesMappings");
            handler.start_array();
            for (int num1 = 0; num1 < storeEventInstancesMappings.Count; ++num1)
              {
                if (partial_allowed)
                    storeEventInstancesMappings[num1].write_partial_as_json(handler);
                else
                    storeEventInstancesMappings[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasError)
          {
            handler.start_pair("Error");
            if (partial_allowed)
                storeError.write_partial_as_json(handler);
            else
                storeError.write_as_json(handler);
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

    public static SportsOlympicsEventSchedulesAndResultsQueryResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsQueryResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsQueryResult", ignore_extras);
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
    public static SportsOlympicsEventSchedulesAndResultsQueryResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventSchedulesAndResultsQueryResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsOlympicsEventSchedulesAndResultsQueryResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsQueryResult", ignore_extras);
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
    public static SportsOlympicsEventSchedulesAndResultsQueryResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SportsOlympicsEventSchedulesAndResultsQueryResultJSON from_text(string text, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsQueryResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsQueryResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsOlympicsEventSchedulesAndResultsQueryResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SportsOlympicsEventSchedulesAndResultsQueryResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsOlympicsEventSchedulesAndResultsQueryResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsOlympicsEventSchedulesAndResultsQueryResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorRankResult : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRankResult(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRankResult : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRankResult(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorRankResult fieldGeneratorRankResult;
        private SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON.HoldingArrayGenerator fieldGeneratorEventInstancesMappings;
        private SportsOlympicsEventSchedulesAndResultsErrorJSON.HoldingGenerator fieldGeneratorError;
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
            SportsOlympicsEventSchedulesAndResultsQueryResultJSON result = new SportsOlympicsEventSchedulesAndResultsQueryResultJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSportsOlympicsEventSchedulesAndResultsQueryResultAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SportsOlympicsEventSchedulesAndResultsQueryResultJSON result)
          {
            if (fieldGeneratorRankResult.have_value)
              {
                result.setRankResult(fieldGeneratorRankResult.value);
                fieldGeneratorRankResult.have_value = false;
              }
            if (fieldGeneratorEventInstancesMappings.have_value)
              {
                result.initEventInstancesMappings();
                int count = fieldGeneratorEventInstancesMappings.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEventInstancesMappings(fieldGeneratorEventInstancesMappings.value[num]);
                  }
                fieldGeneratorEventInstancesMappings.value.Clear();
                fieldGeneratorEventInstancesMappings.have_value = false;
              }
            if (fieldGeneratorError.have_value)
              {
                result.setError(fieldGeneratorError.value);
                fieldGeneratorError.have_value = false;
              }
          }
        protected abstract void handle_result(SportsOlympicsEventSchedulesAndResultsQueryResultJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    switch (field_name[1])
                      {
                        case 'r':
                            if ((String.Compare(field_name, 2, "ror", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorError;
                            break;
                        case 'v':
                            if ((String.Compare(field_name, 2, "entInstancesMappings", 0, 20, false) == 0) && (field_name.Length == 22))
                                return fieldGeneratorEventInstancesMappings;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ankResult", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorRankResult;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorRankResult = new FieldHoldingGeneratorRankResult("field \"RankResult\" of the SportsOlympicsEventSchedulesAndResultsQueryResult class");
            fieldGeneratorEventInstancesMappings = new SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON.HoldingArrayGenerator("field \"EventInstancesMappings\" of the SportsOlympicsEventSchedulesAndResultsQueryResult class", ignore_extras);
            fieldGeneratorError = new SportsOlympicsEventSchedulesAndResultsErrorJSON.HoldingGenerator("field \"Error\" of the SportsOlympicsEventSchedulesAndResultsQueryResult class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SportsOlympicsEventSchedulesAndResultsQueryResult class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRankResult = new FieldHoldingGeneratorRankResult("field \"RankResult\" of the SportsOlympicsEventSchedulesAndResultsQueryResult class");
            fieldGeneratorEventInstancesMappings = new SportsOlympicsEventSchedulesAndResultsEventInstanceMappingJSON.HoldingArrayGenerator("field \"EventInstancesMappings\" of the SportsOlympicsEventSchedulesAndResultsQueryResult class", false);
            fieldGeneratorError = new SportsOlympicsEventSchedulesAndResultsErrorJSON.HoldingGenerator("field \"Error\" of the SportsOlympicsEventSchedulesAndResultsQueryResult class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SportsOlympicsEventSchedulesAndResultsQueryResult class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRankResult.reset();
            fieldGeneratorEventInstancesMappings.reset();
            fieldGeneratorError.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEventInstancesMappings.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorError.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEventInstancesMappings.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorError.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsQueryResultJSON  result)
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
        public SportsOlympicsEventSchedulesAndResultsQueryResultJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsOlympicsEventSchedulesAndResultsQueryResultJSON  result)
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
    protected virtual void handle_result(List<SportsOlympicsEventSchedulesAndResultsQueryResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsOlympicsEventSchedulesAndResultsQueryResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsOlympicsEventSchedulesAndResultsQueryResultJSON>();
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
    public List<SportsOlympicsEventSchedulesAndResultsQueryResultJSON> value;
  };
  };
