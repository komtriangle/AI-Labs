/* file "SurveyChoiceQuestionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SurveyChoiceQuestionJSON : SurveyQuestionJSON
  {
    private bool flagHasMultipleAnswersPossible;
    private bool storeMultipleAnswersPossible;
    private bool flagHasSelectedAnswers;
    private List< BigInteger > storeSelectedAnswers;
    private bool flagHasPossibleAnswers;
    private List< SurveyQuestionPossibleAnswerJSON  > storePossibleAnswers;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraMultipleAnswersPossibleToJSON()
      {
        JSONValue generated_boolean_MultipleAnswersPossible = (storeMultipleAnswersPossible ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_MultipleAnswersPossible;
      }

    private JSONValue  extraSelectedAnswersToJSON()
      {
        JSONArrayValue generated_array_1_SelectedAnswers = new JSONArrayValue();
        for (int num1 = 0; num1 < storeSelectedAnswers.Count; ++num1)
          {
            JSONIntegerValue generated_integer_SelectedAnswers = new JSONIntegerValue(storeSelectedAnswers[num1]);
            generated_array_1_SelectedAnswers.appendComponent(generated_integer_SelectedAnswers);
          }
        return generated_array_1_SelectedAnswers;
      }

    private JSONValue  extraPossibleAnswersToJSON()
      {
        JSONArrayValue generated_array_2_PossibleAnswers = new JSONArrayValue();
        for (int num2 = 0; num2 < storePossibleAnswers.Count; ++num2)
          {
            JSONValueHandler handler_PossibleAnswers = new JSONValueHandler();
            storePossibleAnswers[num2].write_as_json(handler_PossibleAnswers);
            generated_array_2_PossibleAnswers.appendComponent(handler_PossibleAnswers.result);
          }
        return generated_array_2_PossibleAnswers;
      }


    private void  fromJSONMultipleAnswersPossible(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MultipleAnswersPossible of SurveyChoiceQuestionJSON is not true for false.");
              }
          }
        setMultipleAnswersPossible(the_bool);
      }


    private void  fromJSONSelectedAnswers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SelectedAnswers of SurveyChoiceQuestionJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_SelectedAnswers1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field SelectedAnswers of SurveyChoiceQuestionJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field SelectedAnswers of SurveyChoiceQuestionJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_SelectedAnswers1.Add(extracted_integer);
          }
        initSelectedAnswers();
        for (int num1 = 0; num1 < vector_SelectedAnswers1.Count; ++num1)
            appendSelectedAnswers(vector_SelectedAnswers1[num1]);
        for (int num1 = 0; num1 < vector_SelectedAnswers1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPossibleAnswers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PossibleAnswers of SurveyChoiceQuestionJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SurveyQuestionPossibleAnswerJSON  > vector_PossibleAnswers1 = new List< SurveyQuestionPossibleAnswerJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SurveyQuestionPossibleAnswerJSON convert_classy = SurveyQuestionPossibleAnswerJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_PossibleAnswers1.Add(convert_classy);
          }
        initPossibleAnswers();
        for (int num2 = 0; num2 < vector_PossibleAnswers1.Count; ++num2)
            appendPossibleAnswers(vector_PossibleAnswers1[num2]);
        for (int num1 = 0; num1 < vector_PossibleAnswers1.Count; ++num1)
          {
          }
      }


    public SurveyChoiceQuestionJSON()
      {
        flagHasMultipleAnswersPossible = false;
        flagHasSelectedAnswers = false;
        flagHasPossibleAnswers = false;
        storeSelectedAnswers = new List< BigInteger >();
        storePossibleAnswers = new List< SurveyQuestionPossibleAnswerJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getAnswerKind()
      {
        return "SurveyChoice";
      }

    public bool  hasMultipleAnswersPossible()
      {
        return flagHasMultipleAnswersPossible;
      }

    public bool  getMultipleAnswersPossible()
      {
        Debug.Assert(flagHasMultipleAnswersPossible);
        return storeMultipleAnswersPossible;
      }

    public bool  hasSelectedAnswers()
      {
        return flagHasSelectedAnswers;
      }

    public int  countOfSelectedAnswers()
      {
        Debug.Assert(flagHasSelectedAnswers);
        return storeSelectedAnswers.Count;
      }

    public BigInteger  elementOfSelectedAnswers(int element_num)
      {
        Debug.Assert(flagHasSelectedAnswers);
        return storeSelectedAnswers[element_num];
      }

    public List< BigInteger >  getSelectedAnswers()
      {
        Debug.Assert(flagHasSelectedAnswers);
        return storeSelectedAnswers;
      }

    public bool  hasPossibleAnswers()
      {
        return flagHasPossibleAnswers;
      }

    public int  countOfPossibleAnswers()
      {
        Debug.Assert(flagHasPossibleAnswers);
        return storePossibleAnswers.Count;
      }

    public SurveyQuestionPossibleAnswerJSON   elementOfPossibleAnswers(int element_num)
      {
        Debug.Assert(flagHasPossibleAnswers);
        return storePossibleAnswers[element_num];
      }

    public List< SurveyQuestionPossibleAnswerJSON  >  getPossibleAnswers()
      {
        Debug.Assert(flagHasPossibleAnswers);
        return storePossibleAnswers;
      }


    public virtual int extraSurveyChoiceQuestionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSurveyChoiceQuestionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSurveyChoiceQuestionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSurveyChoiceQuestionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraSurveyQuestionComponentCount()
      {
        int result = 0;
        if (flagHasMultipleAnswersPossible)
            ++result;
        if (flagHasSelectedAnswers)
            ++result;
        if (flagHasPossibleAnswers)
            ++result;
        result += extraSurveyChoiceQuestionComponentCount();
        return result;
      }
    public override string extraSurveyQuestionComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasMultipleAnswersPossible)
          {
            if (remainder == 0)
                return "MultipleAnswersPossible";
            --remainder;
          }
        if (flagHasSelectedAnswers)
          {
            if (remainder == 0)
                return "SelectedAnswers";
            --remainder;
          }
        if (flagHasPossibleAnswers)
          {
            if (remainder == 0)
                return "PossibleAnswers";
            --remainder;
          }
        return extraSurveyChoiceQuestionComponentKey(remainder);
      }
    public override JSONValue extraSurveyQuestionComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasMultipleAnswersPossible)
          {
            if (remainder == 0)
                return extraMultipleAnswersPossibleToJSON();
            --remainder;
          }
        if (flagHasSelectedAnswers)
          {
            if (remainder == 0)
                return extraSelectedAnswersToJSON();
            --remainder;
          }
        if (flagHasPossibleAnswers)
          {
            if (remainder == 0)
                return extraPossibleAnswersToJSON();
            --remainder;
          }
        return extraSurveyChoiceQuestionComponentValue(remainder);
      }
    public override JSONValue extraSurveyQuestionLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'M':
                if ((String.Compare(field_name, 1, "ultipleAnswersPossible", 0, 22, false) == 0) && (field_name.Length == 23))
                    return (flagHasMultipleAnswersPossible ? extraMultipleAnswersPossibleToJSON() : null);
                break;
            case 'P':
                if ((String.Compare(field_name, 1, "ossibleAnswers", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasPossibleAnswers ? extraPossibleAnswersToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "electedAnswers", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasSelectedAnswers ? extraSelectedAnswersToJSON() : null);
                break;
            default:
                break;
          }
        return extraSurveyChoiceQuestionLookup(field_name);
      }

    public void setMultipleAnswersPossible(bool new_value)
      {
        flagHasMultipleAnswersPossible = true;
        storeMultipleAnswersPossible = new_value;
      }
    public void unsetMultipleAnswersPossible()
      {
        flagHasMultipleAnswersPossible = false;
      }
    public void initSelectedAnswers()
      {
        flagHasSelectedAnswers = true;
        storeSelectedAnswers.Clear();
      }
    public void appendSelectedAnswers(BigInteger to_append)
      {
        if (!flagHasSelectedAnswers)
          {
            flagHasSelectedAnswers = true;
            storeSelectedAnswers.Clear();
          }
        Debug.Assert(flagHasSelectedAnswers);
        storeSelectedAnswers.Add(to_append);
      }
    public void unsetSelectedAnswers()
      {
        flagHasSelectedAnswers = false;
        storeSelectedAnswers.Clear();
      }
    public void initPossibleAnswers()
      {
        if (flagHasPossibleAnswers)
          {
            for (int num1 = 0; num1 < storePossibleAnswers.Count; ++num1)
              {
              }
          }
        flagHasPossibleAnswers = true;
        storePossibleAnswers.Clear();
      }
    public void appendPossibleAnswers(SurveyQuestionPossibleAnswerJSON  to_append)
      {
        if (!flagHasPossibleAnswers)
          {
            flagHasPossibleAnswers = true;
            storePossibleAnswers.Clear();
          }
        Debug.Assert(flagHasPossibleAnswers);
        storePossibleAnswers.Add(to_append);
      }
    public void unsetPossibleAnswers()
      {
        if (flagHasPossibleAnswers)
          {
            for (int num2 = 0; num2 < storePossibleAnswers.Count; ++num2)
              {
              }
          }
        flagHasPossibleAnswers = false;
        storePossibleAnswers.Clear();
      }

    public virtual void extraSurveyChoiceQuestionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSurveyChoiceQuestionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSurveyChoiceQuestionLookup(key);
        if (old_field == null)
          {
            extraSurveyChoiceQuestionAppendPair(key, new_component);
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
    public override void extraSurveyQuestionAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                if ((String.Compare(key, 1, "ultipleAnswersPossible", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONMultipleAnswersPossible(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "ossibleAnswers", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONPossibleAnswers(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "electedAnswers", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONSelectedAnswers(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSurveyChoiceQuestionAppendPair(key, new_component);
      }
    public override void extraSurveyQuestionSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'M':
                if ((String.Compare(key, 1, "ultipleAnswersPossible", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONMultipleAnswersPossible(new_component, false);
                    return;
                    }
                break;
            case 'P':
                if ((String.Compare(key, 1, "ossibleAnswers", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONPossibleAnswers(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "electedAnswers", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONSelectedAnswers(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraSurveyChoiceQuestionSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasMultipleAnswersPossible);
        if (flagHasMultipleAnswersPossible)
          {
            handler.start_pair("MultipleAnswersPossible");
            handler.boolean_value(storeMultipleAnswersPossible);
          }
        if (flagHasSelectedAnswers)
          {
            handler.start_pair("SelectedAnswers");
            handler.start_array();
            for (int num1 = 0; num1 < storeSelectedAnswers.Count; ++num1)
              {
                handler.number_value(storeSelectedAnswers[num1]);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasPossibleAnswers);
        if (flagHasPossibleAnswers)
          {
            handler.start_pair("PossibleAnswers");
            handler.start_array();
            for (int num2 = 0; num2 < storePossibleAnswers.Count; ++num2)
              {
                if (partial_allowed)
                    storePossibleAnswers[num2].write_partial_as_json(handler);
                else
                    storePossibleAnswers[num2].write_as_json(handler);
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
        if (!(hasMultipleAnswersPossible()))
          {
            return "When parsing the object for %what%, the \"MultipleAnswersPossible\" field was missing.";
          }
        if (!(hasPossibleAnswers()))
          {
            return "When parsing the object for %what%, the \"PossibleAnswers\" field was missing.";
          }
        return null;
      }

    public static new SurveyChoiceQuestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyChoiceQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyChoiceQuestion", ignore_extras);
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
    public static new SurveyChoiceQuestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SurveyChoiceQuestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyChoiceQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyChoiceQuestion", ignore_extras);
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
    public static new SurveyChoiceQuestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SurveyChoiceQuestionJSON from_text(string text, bool ignore_extras)
      {
        SurveyChoiceQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyChoiceQuestion", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyChoiceQuestionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SurveyChoiceQuestionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyChoiceQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SurveyChoiceQuestion", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SurveyQuestionJSON.Generator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorMultipleAnswersPossible;
    private class FieldHoldingGeneratorSelectedAnswers : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSelectedAnswers(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSelectedAnswers : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSelectedAnswers(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorSelectedAnswers fieldGeneratorSelectedAnswers;
        private SurveyQuestionPossibleAnswerJSON.HoldingArrayGenerator fieldGeneratorPossibleAnswers;
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
            if (!(getSurveyQuestionJSONKey().Equals("SurveyChoice")))
                throw new Exception("The key field has a value other than `SurveyChoice'.");
            SurveyChoiceQuestionJSON result = new SurveyChoiceQuestionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyChoiceQuestionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(SurveyQuestionJSON new_result)
          {
            handle_result((SurveyChoiceQuestionJSON )new_result);
          }
        protected void finish(SurveyChoiceQuestionJSON result)
          {
            if (fieldGeneratorMultipleAnswersPossible.have_value)
              {
                result.setMultipleAnswersPossible(fieldGeneratorMultipleAnswersPossible.value);
                fieldGeneratorMultipleAnswersPossible.have_value = false;
              }
            else if ((!(result.hasMultipleAnswersPossible())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"MultipleAnswersPossible\" field was missing.");
              }
            if (fieldGeneratorSelectedAnswers.have_value)
              {
                result.initSelectedAnswers();
                int count = fieldGeneratorSelectedAnswers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSelectedAnswers(fieldGeneratorSelectedAnswers.value[num]);
                  }
                fieldGeneratorSelectedAnswers.value.Clear();
                fieldGeneratorSelectedAnswers.have_value = false;
              }
            if (fieldGeneratorPossibleAnswers.have_value)
              {
                result.initPossibleAnswers();
                int count = fieldGeneratorPossibleAnswers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPossibleAnswers(fieldGeneratorPossibleAnswers.value[num]);
                  }
                fieldGeneratorPossibleAnswers.value.Clear();
                fieldGeneratorPossibleAnswers.have_value = false;
              }
            else if ((!(result.hasPossibleAnswers())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PossibleAnswers\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(SurveyChoiceQuestionJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'M':
                    if ((String.Compare(field_name, 1, "ultipleAnswersPossible", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorMultipleAnswersPossible;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ossibleAnswers", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorPossibleAnswers;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "electedAnswers", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorSelectedAnswers;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorMultipleAnswersPossible = new JSONHoldingBooleanGenerator("field \"MultipleAnswersPossible\" of the SurveyChoiceQuestion class");
            fieldGeneratorSelectedAnswers = new FieldHoldingArrayGeneratorSelectedAnswers("field \"SelectedAnswers\" of the SurveyChoiceQuestion class");
            fieldGeneratorPossibleAnswers = new SurveyQuestionPossibleAnswerJSON.HoldingArrayGenerator("field \"PossibleAnswers\" of the SurveyChoiceQuestion class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the SurveyChoiceQuestion class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorMultipleAnswersPossible = new JSONHoldingBooleanGenerator("field \"MultipleAnswersPossible\" of the SurveyChoiceQuestion class");
            fieldGeneratorSelectedAnswers = new FieldHoldingArrayGeneratorSelectedAnswers("field \"SelectedAnswers\" of the SurveyChoiceQuestion class");
            fieldGeneratorPossibleAnswers = new SurveyQuestionPossibleAnswerJSON.HoldingArrayGenerator("field \"PossibleAnswers\" of the SurveyChoiceQuestion class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the SurveyChoiceQuestion class");
          }

        public override void reset()
          {
            fieldGeneratorMultipleAnswersPossible.reset();
            fieldGeneratorSelectedAnswers.reset();
            fieldGeneratorPossibleAnswers.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SurveyChoiceQuestionJSON  result)
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
        public SurveyChoiceQuestionJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyChoiceQuestionJSON  result)
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
    protected virtual void handle_result(List<SurveyChoiceQuestionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyChoiceQuestionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyChoiceQuestionJSON>();
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
    public List<SurveyChoiceQuestionJSON> value;
  };
  };
