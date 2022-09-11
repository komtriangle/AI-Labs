/* file "RecipeSearchResultInfoNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RecipeSearchResultInfoNuggetJSON : InformationNuggetJSON
  {
    private bool flagHasResultCount;
    private BigInteger storeResultCount;
    private bool flagHasResults;
    private List< DishDetailsJSON  > storeResults;
    private bool flagHasRecipeSearchSpecifications;
    private RecipeSearchSpecJSON  storeRecipeSearchSpecifications;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraResultCountToJSON()
      {
        JSONIntegerValue generated_integer_ResultCount = new JSONIntegerValue(storeResultCount);
        return generated_integer_ResultCount;
      }

    private JSONValue  extraResultsToJSON()
      {
        JSONArrayValue generated_array_1_Results = new JSONArrayValue();
        for (int num1 = 0; num1 < storeResults.Count; ++num1)
          {
            JSONValueHandler handler_Results = new JSONValueHandler();
            storeResults[num1].write_as_json(handler_Results);
            generated_array_1_Results.appendComponent(handler_Results.result);
          }
        return generated_array_1_Results;
      }

    private JSONValue  extraRecipeSearchSpecificationsToJSON()
      {
        JSONValueHandler handler_RecipeSearchSpecifications = new JSONValueHandler();
        storeRecipeSearchSpecifications.write_as_json(handler_RecipeSearchSpecifications);
        return handler_RecipeSearchSpecifications.result;
      }


    private void  fromJSONResultCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ResultCount of RecipeSearchResultInfoNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ResultCount of RecipeSearchResultInfoNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setResultCount(extracted_integer);
      }


    private void  fromJSONResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Results of RecipeSearchResultInfoNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< DishDetailsJSON  > vector_Results1 = new List< DishDetailsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            DishDetailsJSON convert_classy = DishDetailsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Results1.Add(convert_classy);
          }
        initResults();
        for (int num1 = 0; num1 < vector_Results1.Count; ++num1)
            appendResults(vector_Results1[num1]);
        for (int num1 = 0; num1 < vector_Results1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRecipeSearchSpecifications(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RecipeSearchSpecJSON convert_classy = RecipeSearchSpecJSON.from_json(json_value, ignore_extras, true);
        setRecipeSearchSpecifications(convert_classy);
      }


    public RecipeSearchResultInfoNuggetJSON()
      {
        flagHasResultCount = false;
        flagHasResults = false;
        flagHasRecipeSearchSpecifications = false;
        storeResults = new List< DishDetailsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getNuggetKind()
      {
        return "RecipeSearchResultInfoNugget";
      }

    public bool  hasResultCount()
      {
        return flagHasResultCount;
      }

    public BigInteger  getResultCount()
      {
        Debug.Assert(flagHasResultCount);
        return storeResultCount;
      }

    public bool  hasResults()
      {
        return flagHasResults;
      }

    public int  countOfResults()
      {
        Debug.Assert(flagHasResults);
        return storeResults.Count;
      }

    public DishDetailsJSON   elementOfResults(int element_num)
      {
        Debug.Assert(flagHasResults);
        return storeResults[element_num];
      }

    public List< DishDetailsJSON  >  getResults()
      {
        Debug.Assert(flagHasResults);
        return storeResults;
      }

    public bool  hasRecipeSearchSpecifications()
      {
        return flagHasRecipeSearchSpecifications;
      }

    public RecipeSearchSpecJSON   getRecipeSearchSpecifications()
      {
        Debug.Assert(flagHasRecipeSearchSpecifications);
        return storeRecipeSearchSpecifications;
      }


    public virtual int extraRecipeSearchResultInfoNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRecipeSearchResultInfoNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRecipeSearchResultInfoNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRecipeSearchResultInfoNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasResultCount)
            ++result;
        if (flagHasResults)
            ++result;
        if (flagHasRecipeSearchSpecifications)
            ++result;
        result += extraRecipeSearchResultInfoNuggetComponentCount();
        return result;
      }
    public override string extraInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasResultCount)
          {
            if (remainder == 0)
                return "ResultCount";
            --remainder;
          }
        if (flagHasResults)
          {
            if (remainder == 0)
                return "Results";
            --remainder;
          }
        if (flagHasRecipeSearchSpecifications)
          {
            if (remainder == 0)
                return "RecipeSearchSpecifications";
            --remainder;
          }
        return extraRecipeSearchResultInfoNuggetComponentKey(remainder);
      }
    public override JSONValue extraInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasResultCount)
          {
            if (remainder == 0)
                return extraResultCountToJSON();
            --remainder;
          }
        if (flagHasResults)
          {
            if (remainder == 0)
                return extraResultsToJSON();
            --remainder;
          }
        if (flagHasRecipeSearchSpecifications)
          {
            if (remainder == 0)
                return extraRecipeSearchSpecificationsToJSON();
            --remainder;
          }
        return extraRecipeSearchResultInfoNuggetComponentValue(remainder);
      }
    public override JSONValue extraInformationNuggetLookup(string field_name)
      {
        if (String.Compare(field_name, 0, "Re", 0, 2, false) == 0)
          {
            switch (field_name[2])
              {
                case 'c':
                    if ((String.Compare(field_name, 3, "ipeSearchSpecifications", 0, 23, false) == 0) && (field_name.Length == 26))
                        return (flagHasRecipeSearchSpecifications ? extraRecipeSearchSpecificationsToJSON() : null);
                    break;
                case 's':
                    if (String.Compare(field_name, 3, "ult", 0, 3, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 7, "ount", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return (flagHasResultCount ? extraResultCountToJSON() : null);
                                break;
                            case 's':
                                if (field_name.Length == 7)
                                    return (flagHasResults ? extraResultsToJSON() : null);
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
        return extraRecipeSearchResultInfoNuggetLookup(field_name);
      }

    public void setResultCount(BigInteger new_value)
      {
        flagHasResultCount = true;
        if (new_value < 0)
            throw new Exception("The value for field ResultCount of RecipeSearchResultInfoNuggetJSON is less than the lower bound (0) for that field.");
        storeResultCount = new_value;
      }
    public void unsetResultCount()
      {
        flagHasResultCount = false;
      }
    public void initResults()
      {
        if (flagHasResults)
          {
            for (int num1 = 0; num1 < storeResults.Count; ++num1)
              {
              }
          }
        flagHasResults = true;
        storeResults.Clear();
      }
    public void appendResults(DishDetailsJSON  to_append)
      {
        if (!flagHasResults)
          {
            flagHasResults = true;
            storeResults.Clear();
          }
        Debug.Assert(flagHasResults);
        storeResults.Add(to_append);
      }
    public void unsetResults()
      {
        if (flagHasResults)
          {
            for (int num2 = 0; num2 < storeResults.Count; ++num2)
              {
              }
          }
        flagHasResults = false;
        storeResults.Clear();
      }
    public void setRecipeSearchSpecifications(RecipeSearchSpecJSON  new_value)
      {
        if (flagHasRecipeSearchSpecifications)
          {
          }
        flagHasRecipeSearchSpecifications = true;
        storeRecipeSearchSpecifications = new_value;
      }
    public void unsetRecipeSearchSpecifications()
      {
        if (flagHasRecipeSearchSpecifications)
          {
          }
        flagHasRecipeSearchSpecifications = false;
      }

    public virtual void extraRecipeSearchResultInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRecipeSearchResultInfoNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRecipeSearchResultInfoNuggetLookup(key);
        if (old_field == null)
          {
            extraRecipeSearchResultInfoNuggetAppendPair(key, new_component);
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
    public override void extraInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Re", 0, 2, false) == 0)
          {
            switch (key[2])
              {
                case 'c':
                    if ((String.Compare(key, 3, "ipeSearchSpecifications", 0, 23, false) == 0) && (key.Length == 26))
                        {
                        fromJSONRecipeSearchSpecifications(new_component, false);
                        return;
                        }
                    break;
                case 's':
                    if (String.Compare(key, 3, "ult", 0, 3, false) == 0)
                      {
                        switch (key[6])
                          {
                            case 'C':
                                if ((String.Compare(key, 7, "ount", 0, 4, false) == 0) && (key.Length == 11))
                                    {
                                    fromJSONResultCount(new_component, false);
                                    return;
                                    }
                                break;
                            case 's':
                                if (key.Length == 7)
                                    {
                                    fromJSONResults(new_component, false);
                                    return;
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
        extraRecipeSearchResultInfoNuggetAppendPair(key, new_component);
      }
    public override void extraInformationNuggetSetField(string key, JSONValue new_component)
      {
        if (String.Compare(key, 0, "Re", 0, 2, false) == 0)
          {
            switch (key[2])
              {
                case 'c':
                    if ((String.Compare(key, 3, "ipeSearchSpecifications", 0, 23, false) == 0) && (key.Length == 26))
                        {
                        fromJSONRecipeSearchSpecifications(new_component, false);
                        return;
                        }
                    break;
                case 's':
                    if (String.Compare(key, 3, "ult", 0, 3, false) == 0)
                      {
                        switch (key[6])
                          {
                            case 'C':
                                if ((String.Compare(key, 7, "ount", 0, 4, false) == 0) && (key.Length == 11))
                                    {
                                    fromJSONResultCount(new_component, false);
                                    return;
                                    }
                                break;
                            case 's':
                                if (key.Length == 7)
                                    {
                                    fromJSONResults(new_component, false);
                                    return;
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
        extraRecipeSearchResultInfoNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasResultCount);
        if (flagHasResultCount)
          {
            handler.start_pair("ResultCount");
            handler.number_value(storeResultCount);
          }
        Debug.Assert(partial_allowed || flagHasResults);
        if (flagHasResults)
          {
            handler.start_pair("Results");
            handler.start_array();
            for (int num1 = 0; num1 < storeResults.Count; ++num1)
              {
                if (partial_allowed)
                    storeResults[num1].write_partial_as_json(handler);
                else
                    storeResults[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRecipeSearchSpecifications)
          {
            handler.start_pair("RecipeSearchSpecifications");
            if (partial_allowed)
                storeRecipeSearchSpecifications.write_partial_as_json(handler);
            else
                storeRecipeSearchSpecifications.write_as_json(handler);
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
        if (!(hasResultCount()))
          {
            return "When parsing the object for %what%, the \"ResultCount\" field was missing.";
          }
        if (!(hasResults()))
          {
            return "When parsing the object for %what%, the \"Results\" field was missing.";
          }
        return null;
      }

    public static new RecipeSearchResultInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeSearchResultInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeSearchResultInfoNugget", ignore_extras);
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
    public static new RecipeSearchResultInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RecipeSearchResultInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeSearchResultInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeSearchResultInfoNugget", ignore_extras);
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
    public static new RecipeSearchResultInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RecipeSearchResultInfoNuggetJSON from_text(string text, bool ignore_extras)
      {
        RecipeSearchResultInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeSearchResultInfoNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RecipeSearchResultInfoNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RecipeSearchResultInfoNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RecipeSearchResultInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeSearchResultInfoNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : InformationNuggetJSON.Generator
      {
    private class FieldHoldingGeneratorResultCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorResultCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorResultCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorResultCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorResultCount fieldGeneratorResultCount;
        private DishDetailsJSON.HoldingArrayGenerator fieldGeneratorResults;
        private RecipeSearchSpecJSON.HoldingGenerator fieldGeneratorRecipeSearchSpecifications;
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
            if (!(getInformationNuggetJSONKey().Equals("RecipeSearchResultInfoNugget")))
                throw new Exception("The key field has a value other than `RecipeSearchResultInfoNugget'.");
            RecipeSearchResultInfoNuggetJSON result = new RecipeSearchResultInfoNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRecipeSearchResultInfoNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(InformationNuggetJSON new_result)
          {
            handle_result((RecipeSearchResultInfoNuggetJSON )new_result);
          }
        protected void finish(RecipeSearchResultInfoNuggetJSON result)
          {
            if (fieldGeneratorResultCount.have_value)
              {
                result.setResultCount(fieldGeneratorResultCount.value);
                fieldGeneratorResultCount.have_value = false;
              }
            else if ((!(result.hasResultCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ResultCount\" field was missing.");
              }
            if (fieldGeneratorResults.have_value)
              {
                result.initResults();
                int count = fieldGeneratorResults.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendResults(fieldGeneratorResults.value[num]);
                  }
                fieldGeneratorResults.value.Clear();
                fieldGeneratorResults.have_value = false;
              }
            else if ((!(result.hasResults())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Results\" field was missing.");
              }
            if (fieldGeneratorRecipeSearchSpecifications.have_value)
              {
                result.setRecipeSearchSpecifications(fieldGeneratorRecipeSearchSpecifications.value);
                fieldGeneratorRecipeSearchSpecifications.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(RecipeSearchResultInfoNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Re", 0, 2, false) == 0)
              {
                switch (field_name[2])
                  {
                    case 'c':
                        if ((String.Compare(field_name, 3, "ipeSearchSpecifications", 0, 23, false) == 0) && (field_name.Length == 26))
                            return fieldGeneratorRecipeSearchSpecifications;
                        break;
                    case 's':
                        if (String.Compare(field_name, 3, "ult", 0, 3, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'C':
                                    if ((String.Compare(field_name, 7, "ount", 0, 4, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorResultCount;
                                    break;
                                case 's':
                                    if (field_name.Length == 7)
                                        return fieldGeneratorResults;
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
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorResultCount = new FieldHoldingGeneratorResultCount("field \"ResultCount\" of the RecipeSearchResultInfoNugget class");
            fieldGeneratorResults = new DishDetailsJSON.HoldingArrayGenerator("field \"Results\" of the RecipeSearchResultInfoNugget class", ignore_extras);
            fieldGeneratorRecipeSearchSpecifications = new RecipeSearchSpecJSON.HoldingGenerator("field \"RecipeSearchSpecifications\" of the RecipeSearchResultInfoNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RecipeSearchResultInfoNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorResultCount = new FieldHoldingGeneratorResultCount("field \"ResultCount\" of the RecipeSearchResultInfoNugget class");
            fieldGeneratorResults = new DishDetailsJSON.HoldingArrayGenerator("field \"Results\" of the RecipeSearchResultInfoNugget class", false);
            fieldGeneratorRecipeSearchSpecifications = new RecipeSearchSpecJSON.HoldingGenerator("field \"RecipeSearchSpecifications\" of the RecipeSearchResultInfoNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RecipeSearchResultInfoNugget class");
          }

        public override void reset()
          {
            fieldGeneratorResultCount.reset();
            fieldGeneratorResults.reset();
            fieldGeneratorRecipeSearchSpecifications.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RecipeSearchResultInfoNuggetJSON  result)
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
        public RecipeSearchResultInfoNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RecipeSearchResultInfoNuggetJSON  result)
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
    protected virtual void handle_result(List<RecipeSearchResultInfoNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RecipeSearchResultInfoNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RecipeSearchResultInfoNuggetJSON>();
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
    public List<RecipeSearchResultInfoNuggetJSON> value;
  };
  };
