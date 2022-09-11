/* file "RecipeAidInstructionQueryInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RecipeAidInstructionQueryInformationNuggetJSON : RecipeAidInformationNuggetJSON
  {
    private bool flagHasCurrentStep;
    private BigInteger storeCurrentStep;
    private bool flagHasProcessedInstructions;
    private List< RecipeAidInstructionDetailsJSON  > storeProcessedInstructions;
    private bool flagHasTotalStepCount;
    private BigInteger storeTotalStepCount;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraCurrentStepToJSON()
      {
        JSONIntegerValue generated_integer_CurrentStep = new JSONIntegerValue(storeCurrentStep);
        return generated_integer_CurrentStep;
      }

    private JSONValue  extraProcessedInstructionsToJSON()
      {
        JSONArrayValue generated_array_1_ProcessedInstructions = new JSONArrayValue();
        for (int num1 = 0; num1 < storeProcessedInstructions.Count; ++num1)
          {
            JSONValueHandler handler_ProcessedInstructions = new JSONValueHandler();
            storeProcessedInstructions[num1].write_as_json(handler_ProcessedInstructions);
            generated_array_1_ProcessedInstructions.appendComponent(handler_ProcessedInstructions.result);
          }
        return generated_array_1_ProcessedInstructions;
      }

    private JSONValue  extraTotalStepCountToJSON()
      {
        JSONIntegerValue generated_integer_TotalStepCount = new JSONIntegerValue(storeTotalStepCount);
        return generated_integer_TotalStepCount;
      }


    private void  fromJSONCurrentStep(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CurrentStep of RecipeAidInstructionQueryInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CurrentStep of RecipeAidInstructionQueryInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCurrentStep(extracted_integer);
      }


    private void  fromJSONProcessedInstructions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ProcessedInstructions of RecipeAidInstructionQueryInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RecipeAidInstructionDetailsJSON  > vector_ProcessedInstructions1 = new List< RecipeAidInstructionDetailsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RecipeAidInstructionDetailsJSON convert_classy = RecipeAidInstructionDetailsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ProcessedInstructions1.Add(convert_classy);
          }
        initProcessedInstructions();
        for (int num1 = 0; num1 < vector_ProcessedInstructions1.Count; ++num1)
            appendProcessedInstructions(vector_ProcessedInstructions1[num1]);
        for (int num1 = 0; num1 < vector_ProcessedInstructions1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTotalStepCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TotalStepCount of RecipeAidInstructionQueryInformationNuggetJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TotalStepCount of RecipeAidInstructionQueryInformationNuggetJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTotalStepCount(extracted_integer);
      }


    public RecipeAidInstructionQueryInformationNuggetJSON()
      {
        flagHasCurrentStep = false;
        flagHasProcessedInstructions = false;
        flagHasTotalStepCount = false;
        storeProcessedInstructions = new List< RecipeAidInstructionDetailsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getRecipeAidNuggetKind()
      {
        return "InstructionQuery";
      }

    public bool  hasCurrentStep()
      {
        return flagHasCurrentStep;
      }

    public BigInteger  getCurrentStep()
      {
        Debug.Assert(flagHasCurrentStep);
        return storeCurrentStep;
      }

    public bool  hasProcessedInstructions()
      {
        return flagHasProcessedInstructions;
      }

    public int  countOfProcessedInstructions()
      {
        Debug.Assert(flagHasProcessedInstructions);
        return storeProcessedInstructions.Count;
      }

    public RecipeAidInstructionDetailsJSON   elementOfProcessedInstructions(int element_num)
      {
        Debug.Assert(flagHasProcessedInstructions);
        return storeProcessedInstructions[element_num];
      }

    public List< RecipeAidInstructionDetailsJSON  >  getProcessedInstructions()
      {
        Debug.Assert(flagHasProcessedInstructions);
        return storeProcessedInstructions;
      }

    public bool  hasTotalStepCount()
      {
        return flagHasTotalStepCount;
      }

    public BigInteger  getTotalStepCount()
      {
        Debug.Assert(flagHasTotalStepCount);
        return storeTotalStepCount;
      }


    public virtual int extraRecipeAidInstructionQueryInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRecipeAidInstructionQueryInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRecipeAidInstructionQueryInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRecipeAidInstructionQueryInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraRecipeAidInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasCurrentStep)
            ++result;
        if (flagHasProcessedInstructions)
            ++result;
        if (flagHasTotalStepCount)
            ++result;
        result += extraRecipeAidInstructionQueryInformationNuggetComponentCount();
        return result;
      }
    public override string extraRecipeAidInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasCurrentStep)
          {
            if (remainder == 0)
                return "CurrentStep";
            --remainder;
          }
        if (flagHasProcessedInstructions)
          {
            if (remainder == 0)
                return "ProcessedInstructions";
            --remainder;
          }
        if (flagHasTotalStepCount)
          {
            if (remainder == 0)
                return "TotalStepCount";
            --remainder;
          }
        return extraRecipeAidInstructionQueryInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraRecipeAidInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasCurrentStep)
          {
            if (remainder == 0)
                return extraCurrentStepToJSON();
            --remainder;
          }
        if (flagHasProcessedInstructions)
          {
            if (remainder == 0)
                return extraProcessedInstructionsToJSON();
            --remainder;
          }
        if (flagHasTotalStepCount)
          {
            if (remainder == 0)
                return extraTotalStepCountToJSON();
            --remainder;
          }
        return extraRecipeAidInstructionQueryInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraRecipeAidInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "urrentStep", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasCurrentStep ? extraCurrentStepToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "rocessedInstructions", 0, 20, false) == 0) && (field_name.Length == 21))
                    return (flagHasProcessedInstructions ? extraProcessedInstructionsToJSON() : null);
                break;
            case 'T':
                if ((String.Compare(field_name, 1, "otalStepCount", 0, 13, false) == 0) && (field_name.Length == 14))
                    return (flagHasTotalStepCount ? extraTotalStepCountToJSON() : null);
                break;
            default:
                break;
          }
        return extraRecipeAidInstructionQueryInformationNuggetLookup(field_name);
      }

    public void setCurrentStep(BigInteger new_value)
      {
        flagHasCurrentStep = true;
        storeCurrentStep = new_value;
      }
    public void unsetCurrentStep()
      {
        flagHasCurrentStep = false;
      }
    public void initProcessedInstructions()
      {
        if (flagHasProcessedInstructions)
          {
            for (int num1 = 0; num1 < storeProcessedInstructions.Count; ++num1)
              {
              }
          }
        flagHasProcessedInstructions = true;
        storeProcessedInstructions.Clear();
      }
    public void appendProcessedInstructions(RecipeAidInstructionDetailsJSON  to_append)
      {
        if (!flagHasProcessedInstructions)
          {
            flagHasProcessedInstructions = true;
            storeProcessedInstructions.Clear();
          }
        Debug.Assert(flagHasProcessedInstructions);
        storeProcessedInstructions.Add(to_append);
      }
    public void unsetProcessedInstructions()
      {
        if (flagHasProcessedInstructions)
          {
            for (int num2 = 0; num2 < storeProcessedInstructions.Count; ++num2)
              {
              }
          }
        flagHasProcessedInstructions = false;
        storeProcessedInstructions.Clear();
      }
    public void setTotalStepCount(BigInteger new_value)
      {
        flagHasTotalStepCount = true;
        if (new_value < 0)
            throw new Exception("The value for field TotalStepCount of RecipeAidInstructionQueryInformationNuggetJSON is less than the lower bound (0) for that field.");
        storeTotalStepCount = new_value;
      }
    public void unsetTotalStepCount()
      {
        flagHasTotalStepCount = false;
      }

    public virtual void extraRecipeAidInstructionQueryInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRecipeAidInstructionQueryInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRecipeAidInstructionQueryInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraRecipeAidInstructionQueryInformationNuggetAppendPair(key, new_component);
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
    public override void extraRecipeAidInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "urrentStep", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCurrentStep(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "rocessedInstructions", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONProcessedInstructions(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "otalStepCount", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONTotalStepCount(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRecipeAidInstructionQueryInformationNuggetAppendPair(key, new_component);
      }
    public override void extraRecipeAidInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "urrentStep", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONCurrentStep(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "rocessedInstructions", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONProcessedInstructions(new_component, false);
                    return;
                    }
                break;
            case 'T':
                if ((String.Compare(key, 1, "otalStepCount", 0, 13, false) == 0) && (key.Length == 14))
                    {
                    fromJSONTotalStepCount(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraRecipeAidInstructionQueryInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasCurrentStep);
        if (flagHasCurrentStep)
          {
            handler.start_pair("CurrentStep");
            handler.number_value(storeCurrentStep);
          }
        Debug.Assert(partial_allowed || flagHasProcessedInstructions);
        if (flagHasProcessedInstructions)
          {
            handler.start_pair("ProcessedInstructions");
            handler.start_array();
            for (int num1 = 0; num1 < storeProcessedInstructions.Count; ++num1)
              {
                if (partial_allowed)
                    storeProcessedInstructions[num1].write_partial_as_json(handler);
                else
                    storeProcessedInstructions[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasTotalStepCount)
          {
            handler.start_pair("TotalStepCount");
            handler.number_value(storeTotalStepCount);
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
        if (!(hasCurrentStep()))
          {
            return "When parsing the object for %what%, the \"CurrentStep\" field was missing.";
          }
        if (!(hasProcessedInstructions()))
          {
            return "When parsing the object for %what%, the \"ProcessedInstructions\" field was missing.";
          }
        return null;
      }

    public static new RecipeAidInstructionQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAidInstructionQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidInstructionQueryInformationNugget", ignore_extras);
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
    public static new RecipeAidInstructionQueryInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RecipeAidInstructionQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAidInstructionQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidInstructionQueryInformationNugget", ignore_extras);
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
    public static new RecipeAidInstructionQueryInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new RecipeAidInstructionQueryInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        RecipeAidInstructionQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidInstructionQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RecipeAidInstructionQueryInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new RecipeAidInstructionQueryInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RecipeAidInstructionQueryInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidInstructionQueryInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : RecipeAidInformationNuggetJSON.Generator
      {
    private class FieldHoldingGeneratorCurrentStep : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorCurrentStep(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCurrentStep : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCurrentStep(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorCurrentStep fieldGeneratorCurrentStep;
        private RecipeAidInstructionDetailsJSON.HoldingArrayGenerator fieldGeneratorProcessedInstructions;
    private class FieldHoldingGeneratorTotalStepCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTotalStepCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTotalStepCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTotalStepCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTotalStepCount fieldGeneratorTotalStepCount;
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
            if (!(getRecipeAidInformationNuggetJSONKey().Equals("InstructionQuery")))
                throw new Exception("The key field has a value other than `InstructionQuery'.");
            RecipeAidInstructionQueryInformationNuggetJSON result = new RecipeAidInstructionQueryInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRecipeAidInstructionQueryInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(RecipeAidInformationNuggetJSON new_result)
          {
            handle_result((RecipeAidInstructionQueryInformationNuggetJSON )new_result);
          }
        protected void finish(RecipeAidInstructionQueryInformationNuggetJSON result)
          {
            if (fieldGeneratorCurrentStep.have_value)
              {
                result.setCurrentStep(fieldGeneratorCurrentStep.value);
                fieldGeneratorCurrentStep.have_value = false;
              }
            else if ((!(result.hasCurrentStep())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CurrentStep\" field was missing.");
              }
            if (fieldGeneratorProcessedInstructions.have_value)
              {
                result.initProcessedInstructions();
                int count = fieldGeneratorProcessedInstructions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendProcessedInstructions(fieldGeneratorProcessedInstructions.value[num]);
                  }
                fieldGeneratorProcessedInstructions.value.Clear();
                fieldGeneratorProcessedInstructions.have_value = false;
              }
            else if ((!(result.hasProcessedInstructions())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ProcessedInstructions\" field was missing.");
              }
            if (fieldGeneratorTotalStepCount.have_value)
              {
                result.setTotalStepCount(fieldGeneratorTotalStepCount.value);
                fieldGeneratorTotalStepCount.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(RecipeAidInstructionQueryInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "urrentStep", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorCurrentStep;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rocessedInstructions", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorProcessedInstructions;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "otalStepCount", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorTotalStepCount;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorCurrentStep = new FieldHoldingGeneratorCurrentStep("field \"CurrentStep\" of the RecipeAidInstructionQueryInformationNugget class");
            fieldGeneratorProcessedInstructions = new RecipeAidInstructionDetailsJSON.HoldingArrayGenerator("field \"ProcessedInstructions\" of the RecipeAidInstructionQueryInformationNugget class", ignore_extras);
            fieldGeneratorTotalStepCount = new FieldHoldingGeneratorTotalStepCount("field \"TotalStepCount\" of the RecipeAidInstructionQueryInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RecipeAidInstructionQueryInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorCurrentStep = new FieldHoldingGeneratorCurrentStep("field \"CurrentStep\" of the RecipeAidInstructionQueryInformationNugget class");
            fieldGeneratorProcessedInstructions = new RecipeAidInstructionDetailsJSON.HoldingArrayGenerator("field \"ProcessedInstructions\" of the RecipeAidInstructionQueryInformationNugget class", false);
            fieldGeneratorTotalStepCount = new FieldHoldingGeneratorTotalStepCount("field \"TotalStepCount\" of the RecipeAidInstructionQueryInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RecipeAidInstructionQueryInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorCurrentStep.reset();
            fieldGeneratorProcessedInstructions.reset();
            fieldGeneratorTotalStepCount.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(RecipeAidInstructionQueryInformationNuggetJSON  result)
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
        public RecipeAidInstructionQueryInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RecipeAidInstructionQueryInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<RecipeAidInstructionQueryInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RecipeAidInstructionQueryInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RecipeAidInstructionQueryInformationNuggetJSON>();
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
    public List<RecipeAidInstructionQueryInformationNuggetJSON> value;
  };
  };
