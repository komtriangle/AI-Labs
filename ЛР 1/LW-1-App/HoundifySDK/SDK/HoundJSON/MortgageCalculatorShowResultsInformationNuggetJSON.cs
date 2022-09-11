/* file "MortgageCalculatorShowResultsInformationNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MortgageCalculatorShowResultsInformationNuggetJSON : MortgageCalculatorInformationNuggetJSON
  {
    private bool flagHasInputVariableSets;
    private List< MortgageCalculatorInputVariableSetJSON  > storeInputVariableSets;
    private bool flagHasResults;
    private List< MortgageCalculatorShowResultsDataJSON  > storeResults;
    private bool flagHasConversationStateUsed;
    private bool storeConversationStateUsed;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraInputVariableSetsToJSON()
      {
        JSONArrayValue generated_array_1_InputVariableSets = new JSONArrayValue();
        for (int num1 = 0; num1 < storeInputVariableSets.Count; ++num1)
          {
            JSONValueHandler handler_InputVariableSets = new JSONValueHandler();
            storeInputVariableSets[num1].write_as_json(handler_InputVariableSets);
            generated_array_1_InputVariableSets.appendComponent(handler_InputVariableSets.result);
          }
        return generated_array_1_InputVariableSets;
      }

    private JSONValue  extraResultsToJSON()
      {
        JSONArrayValue generated_array_2_Results = new JSONArrayValue();
        for (int num2 = 0; num2 < storeResults.Count; ++num2)
          {
            JSONValueHandler handler_Results = new JSONValueHandler();
            storeResults[num2].write_as_json(handler_Results);
            generated_array_2_Results.appendComponent(handler_Results.result);
          }
        return generated_array_2_Results;
      }

    private JSONValue  extraConversationStateUsedToJSON()
      {
        JSONValue generated_boolean_ConversationStateUsed = (storeConversationStateUsed ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_ConversationStateUsed;
      }


    private void  fromJSONInputVariableSets(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field InputVariableSets of MortgageCalculatorShowResultsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MortgageCalculatorInputVariableSetJSON  > vector_InputVariableSets1 = new List< MortgageCalculatorInputVariableSetJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MortgageCalculatorInputVariableSetJSON convert_classy = MortgageCalculatorInputVariableSetJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_InputVariableSets1.Add(convert_classy);
          }
        initInputVariableSets();
        for (int num1 = 0; num1 < vector_InputVariableSets1.Count; ++num1)
            appendInputVariableSets(vector_InputVariableSets1[num1]);
        for (int num1 = 0; num1 < vector_InputVariableSets1.Count; ++num1)
          {
          }
      }


    private void  fromJSONResults(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Results of MortgageCalculatorShowResultsInformationNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< MortgageCalculatorShowResultsDataJSON  > vector_Results1 = new List< MortgageCalculatorShowResultsDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MortgageCalculatorShowResultsDataJSON convert_classy = MortgageCalculatorShowResultsDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Results1.Add(convert_classy);
          }
        initResults();
        for (int num2 = 0; num2 < vector_Results1.Count; ++num2)
            appendResults(vector_Results1[num2]);
        for (int num1 = 0; num1 < vector_Results1.Count; ++num1)
          {
          }
      }


    private void  fromJSONConversationStateUsed(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONTrueValue json_true = json_value.true_value();
        bool the_bool;
        if (json_true != null)
          {
            the_bool = true;
          }
        else
          {
            JSONFalseValue json_false = json_value.false_value();
            if (json_false != null)
              {
                the_bool = false;
              }
            else
              {
                throw new Exception("The value for field ConversationStateUsed of MortgageCalculatorShowResultsInformationNuggetJSON is not true for false.");
              }
          }
        setConversationStateUsed(the_bool);
      }


    public MortgageCalculatorShowResultsInformationNuggetJSON()
      {
        flagHasInputVariableSets = false;
        flagHasResults = false;
        flagHasConversationStateUsed = false;
        storeInputVariableSets = new List< MortgageCalculatorInputVariableSetJSON  >();
        storeResults = new List< MortgageCalculatorShowResultsDataJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getMortgageCalculatorNuggetKind()
      {
        return "MortgageCalculatorShowResults";
      }

    public bool  hasInputVariableSets()
      {
        return flagHasInputVariableSets;
      }

    public int  countOfInputVariableSets()
      {
        Debug.Assert(flagHasInputVariableSets);
        return storeInputVariableSets.Count;
      }

    public MortgageCalculatorInputVariableSetJSON   elementOfInputVariableSets(int element_num)
      {
        Debug.Assert(flagHasInputVariableSets);
        return storeInputVariableSets[element_num];
      }

    public List< MortgageCalculatorInputVariableSetJSON  >  getInputVariableSets()
      {
        Debug.Assert(flagHasInputVariableSets);
        return storeInputVariableSets;
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

    public MortgageCalculatorShowResultsDataJSON   elementOfResults(int element_num)
      {
        Debug.Assert(flagHasResults);
        return storeResults[element_num];
      }

    public List< MortgageCalculatorShowResultsDataJSON  >  getResults()
      {
        Debug.Assert(flagHasResults);
        return storeResults;
      }

    public bool  hasConversationStateUsed()
      {
        return flagHasConversationStateUsed;
      }

    public bool  getConversationStateUsed()
      {
        Debug.Assert(flagHasConversationStateUsed);
        return storeConversationStateUsed;
      }


    public virtual int extraMortgageCalculatorShowResultsInformationNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMortgageCalculatorShowResultsInformationNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorShowResultsInformationNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMortgageCalculatorShowResultsInformationNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMortgageCalculatorInformationNuggetComponentCount()
      {
        int result = 0;
        if (flagHasInputVariableSets)
            ++result;
        if (flagHasResults)
            ++result;
        if (flagHasConversationStateUsed)
            ++result;
        result += extraMortgageCalculatorShowResultsInformationNuggetComponentCount();
        return result;
      }
    public override string extraMortgageCalculatorInformationNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasInputVariableSets)
          {
            if (remainder == 0)
                return "InputVariableSets";
            --remainder;
          }
        if (flagHasResults)
          {
            if (remainder == 0)
                return "Results";
            --remainder;
          }
        if (flagHasConversationStateUsed)
          {
            if (remainder == 0)
                return "ConversationStateUsed";
            --remainder;
          }
        return extraMortgageCalculatorShowResultsInformationNuggetComponentKey(remainder);
      }
    public override JSONValue extraMortgageCalculatorInformationNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasInputVariableSets)
          {
            if (remainder == 0)
                return extraInputVariableSetsToJSON();
            --remainder;
          }
        if (flagHasResults)
          {
            if (remainder == 0)
                return extraResultsToJSON();
            --remainder;
          }
        if (flagHasConversationStateUsed)
          {
            if (remainder == 0)
                return extraConversationStateUsedToJSON();
            --remainder;
          }
        return extraMortgageCalculatorShowResultsInformationNuggetComponentValue(remainder);
      }
    public override JSONValue extraMortgageCalculatorInformationNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'C':
                if ((String.Compare(field_name, 1, "onversationStateUsed", 0, 20, false) == 0) && (field_name.Length == 21))
                    return (flagHasConversationStateUsed ? extraConversationStateUsedToJSON() : null);
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "nputVariableSets", 0, 16, false) == 0) && (field_name.Length == 17))
                    return (flagHasInputVariableSets ? extraInputVariableSetsToJSON() : null);
                break;
            case 'R':
                if ((String.Compare(field_name, 1, "esults", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasResults ? extraResultsToJSON() : null);
                break;
            default:
                break;
          }
        return extraMortgageCalculatorShowResultsInformationNuggetLookup(field_name);
      }

    public void initInputVariableSets()
      {
        if (flagHasInputVariableSets)
          {
            for (int num1 = 0; num1 < storeInputVariableSets.Count; ++num1)
              {
              }
          }
        flagHasInputVariableSets = true;
        storeInputVariableSets.Clear();
      }
    public void appendInputVariableSets(MortgageCalculatorInputVariableSetJSON  to_append)
      {
        if (!flagHasInputVariableSets)
          {
            flagHasInputVariableSets = true;
            storeInputVariableSets.Clear();
          }
        Debug.Assert(flagHasInputVariableSets);
        storeInputVariableSets.Add(to_append);
      }
    public void unsetInputVariableSets()
      {
        if (flagHasInputVariableSets)
          {
            for (int num2 = 0; num2 < storeInputVariableSets.Count; ++num2)
              {
              }
          }
        flagHasInputVariableSets = false;
        storeInputVariableSets.Clear();
      }
    public void initResults()
      {
        if (flagHasResults)
          {
            for (int num3 = 0; num3 < storeResults.Count; ++num3)
              {
              }
          }
        flagHasResults = true;
        storeResults.Clear();
      }
    public void appendResults(MortgageCalculatorShowResultsDataJSON  to_append)
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
            for (int num4 = 0; num4 < storeResults.Count; ++num4)
              {
              }
          }
        flagHasResults = false;
        storeResults.Clear();
      }
    public void setConversationStateUsed(bool new_value)
      {
        flagHasConversationStateUsed = true;
        storeConversationStateUsed = new_value;
      }
    public void unsetConversationStateUsed()
      {
        flagHasConversationStateUsed = false;
      }

    public virtual void extraMortgageCalculatorShowResultsInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMortgageCalculatorShowResultsInformationNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMortgageCalculatorShowResultsInformationNuggetLookup(key);
        if (old_field == null)
          {
            extraMortgageCalculatorShowResultsInformationNuggetAppendPair(key, new_component);
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
    public override void extraMortgageCalculatorInformationNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "onversationStateUsed", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONConversationStateUsed(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "nputVariableSets", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONInputVariableSets(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esults", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONResults(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMortgageCalculatorShowResultsInformationNuggetAppendPair(key, new_component);
      }
    public override void extraMortgageCalculatorInformationNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'C':
                if ((String.Compare(key, 1, "onversationStateUsed", 0, 20, false) == 0) && (key.Length == 21))
                    {
                    fromJSONConversationStateUsed(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "nputVariableSets", 0, 16, false) == 0) && (key.Length == 17))
                    {
                    fromJSONInputVariableSets(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if ((String.Compare(key, 1, "esults", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONResults(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraMortgageCalculatorShowResultsInformationNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasInputVariableSets);
        if (flagHasInputVariableSets)
          {
            handler.start_pair("InputVariableSets");
            handler.start_array();
            for (int num1 = 0; num1 < storeInputVariableSets.Count; ++num1)
              {
                if (partial_allowed)
                    storeInputVariableSets[num1].write_partial_as_json(handler);
                else
                    storeInputVariableSets[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasResults);
        if (flagHasResults)
          {
            handler.start_pair("Results");
            handler.start_array();
            for (int num2 = 0; num2 < storeResults.Count; ++num2)
              {
                if (partial_allowed)
                    storeResults[num2].write_partial_as_json(handler);
                else
                    storeResults[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasConversationStateUsed)
          {
            handler.start_pair("ConversationStateUsed");
            handler.boolean_value(storeConversationStateUsed);
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
        if (!(hasInputVariableSets()))
          {
            return "When parsing the object for %what%, the \"InputVariableSets\" field was missing.";
          }
        if (!(hasResults()))
          {
            return "When parsing the object for %what%, the \"Results\" field was missing.";
          }
        return null;
      }

    public static new MortgageCalculatorShowResultsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorShowResultsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorShowResultsInformationNugget", ignore_extras);
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
    public static new MortgageCalculatorShowResultsInformationNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorShowResultsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MortgageCalculatorShowResultsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorShowResultsInformationNugget", ignore_extras);
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
    public static new MortgageCalculatorShowResultsInformationNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MortgageCalculatorShowResultsInformationNuggetJSON from_text(string text, bool ignore_extras)
      {
        MortgageCalculatorShowResultsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorShowResultsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MortgageCalculatorShowResultsInformationNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MortgageCalculatorShowResultsInformationNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MortgageCalculatorShowResultsInformationNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MortgageCalculatorShowResultsInformationNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MortgageCalculatorInformationNuggetJSON.Generator
      {
        private MortgageCalculatorInputVariableSetJSON.HoldingArrayGenerator fieldGeneratorInputVariableSets;
        private MortgageCalculatorShowResultsDataJSON.HoldingArrayGenerator fieldGeneratorResults;
        private JSONHoldingBooleanGenerator fieldGeneratorConversationStateUsed;
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
            if (!(getMortgageCalculatorInformationNuggetJSONKey().Equals("MortgageCalculatorShowResults")))
                throw new Exception("The key field has a value other than `MortgageCalculatorShowResults'.");
            MortgageCalculatorShowResultsInformationNuggetJSON result = new MortgageCalculatorShowResultsInformationNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMortgageCalculatorShowResultsInformationNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MortgageCalculatorInformationNuggetJSON new_result)
          {
            handle_result((MortgageCalculatorShowResultsInformationNuggetJSON )new_result);
          }
        protected void finish(MortgageCalculatorShowResultsInformationNuggetJSON result)
          {
            if (fieldGeneratorInputVariableSets.have_value)
              {
                result.initInputVariableSets();
                int count = fieldGeneratorInputVariableSets.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInputVariableSets(fieldGeneratorInputVariableSets.value[num]);
                  }
                fieldGeneratorInputVariableSets.value.Clear();
                fieldGeneratorInputVariableSets.have_value = false;
              }
            else if ((!(result.hasInputVariableSets())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"InputVariableSets\" field was missing.");
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
            if (fieldGeneratorConversationStateUsed.have_value)
              {
                result.setConversationStateUsed(fieldGeneratorConversationStateUsed.value);
                fieldGeneratorConversationStateUsed.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MortgageCalculatorShowResultsInformationNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "onversationStateUsed", 0, 20, false) == 0) && (field_name.Length == 21))
                        return fieldGeneratorConversationStateUsed;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nputVariableSets", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorInputVariableSets;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "esults", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorResults;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorInputVariableSets = new MortgageCalculatorInputVariableSetJSON.HoldingArrayGenerator("field \"InputVariableSets\" of the MortgageCalculatorShowResultsInformationNugget class", ignore_extras);
            fieldGeneratorResults = new MortgageCalculatorShowResultsDataJSON.HoldingArrayGenerator("field \"Results\" of the MortgageCalculatorShowResultsInformationNugget class", ignore_extras);
            fieldGeneratorConversationStateUsed = new JSONHoldingBooleanGenerator("field \"ConversationStateUsed\" of the MortgageCalculatorShowResultsInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MortgageCalculatorShowResultsInformationNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorInputVariableSets = new MortgageCalculatorInputVariableSetJSON.HoldingArrayGenerator("field \"InputVariableSets\" of the MortgageCalculatorShowResultsInformationNugget class", false);
            fieldGeneratorResults = new MortgageCalculatorShowResultsDataJSON.HoldingArrayGenerator("field \"Results\" of the MortgageCalculatorShowResultsInformationNugget class", false);
            fieldGeneratorConversationStateUsed = new JSONHoldingBooleanGenerator("field \"ConversationStateUsed\" of the MortgageCalculatorShowResultsInformationNugget class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MortgageCalculatorShowResultsInformationNugget class");
          }

        public override void reset()
          {
            fieldGeneratorInputVariableSets.reset();
            fieldGeneratorResults.reset();
            fieldGeneratorConversationStateUsed.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MortgageCalculatorShowResultsInformationNuggetJSON  result)
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
        public MortgageCalculatorShowResultsInformationNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MortgageCalculatorShowResultsInformationNuggetJSON  result)
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
    protected virtual void handle_result(List<MortgageCalculatorShowResultsInformationNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MortgageCalculatorShowResultsInformationNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MortgageCalculatorShowResultsInformationNuggetJSON>();
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
    public List<MortgageCalculatorShowResultsInformationNuggetJSON> value;
  };
  };
