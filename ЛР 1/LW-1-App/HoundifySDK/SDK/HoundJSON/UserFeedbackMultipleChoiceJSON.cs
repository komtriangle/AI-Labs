/* file "UserFeedbackMultipleChoiceJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UserFeedbackMultipleChoiceJSON : UserFeedbackItemJSON
  {
    private bool flagHasChoices;
    private List< string > storeChoices;
    private bool flagHasChoiceLabels;
    private List< string > storeChoiceLabels;
    private bool flagHasAnswers;
    private List< BigInteger > storeAnswers;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraChoicesToJSON()
      {
        JSONArrayValue generated_array_1_Choices = new JSONArrayValue();
        for (int num1 = 0; num1 < storeChoices.Count; ++num1)
          {
            JSONStringValue generated_string_Choices = new JSONStringValue(storeChoices[num1]);
            generated_array_1_Choices.appendComponent(generated_string_Choices);
          }
        return generated_array_1_Choices;
      }

    private JSONValue  extraChoiceLabelsToJSON()
      {
        JSONArrayValue generated_array_2_ChoiceLabels = new JSONArrayValue();
        for (int num2 = 0; num2 < storeChoiceLabels.Count; ++num2)
          {
            JSONStringValue generated_string_ChoiceLabels = new JSONStringValue(storeChoiceLabels[num2]);
            generated_array_2_ChoiceLabels.appendComponent(generated_string_ChoiceLabels);
          }
        return generated_array_2_ChoiceLabels;
      }

    private JSONValue  extraAnswersToJSON()
      {
        JSONArrayValue generated_array_3_Answers = new JSONArrayValue();
        for (int num3 = 0; num3 < storeAnswers.Count; ++num3)
          {
            JSONIntegerValue generated_integer_Answers = new JSONIntegerValue(storeAnswers[num3]);
            generated_array_3_Answers.appendComponent(generated_integer_Answers);
          }
        return generated_array_3_Answers;
      }


    private void  fromJSONChoices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Choices of UserFeedbackMultipleChoiceJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field Choices of UserFeedbackMultipleChoiceJSON has too few elements.");
        List< string > vector_Choices1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Choices of UserFeedbackMultipleChoiceJSON is not a string.");
            vector_Choices1.Add(json_string.getData());
          }
        Debug.Assert(vector_Choices1.Count >= 2);
        initChoices();
        for (int num1 = 0; num1 < vector_Choices1.Count; ++num1)
            appendChoices(vector_Choices1[num1]);
        for (int num1 = 0; num1 < vector_Choices1.Count; ++num1)
          {
          }
      }


    private void  fromJSONChoiceLabels(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ChoiceLabels of UserFeedbackMultipleChoiceJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field ChoiceLabels of UserFeedbackMultipleChoiceJSON has too few elements.");
        List< string > vector_ChoiceLabels1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ChoiceLabels of UserFeedbackMultipleChoiceJSON is not a string.");
            vector_ChoiceLabels1.Add(json_string.getData());
          }
        Debug.Assert(vector_ChoiceLabels1.Count >= 2);
        initChoiceLabels();
        for (int num2 = 0; num2 < vector_ChoiceLabels1.Count; ++num2)
            appendChoiceLabels(vector_ChoiceLabels1[num2]);
        for (int num1 = 0; num1 < vector_ChoiceLabels1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAnswers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Answers of UserFeedbackMultipleChoiceJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_Answers1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field Answers of UserFeedbackMultipleChoiceJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field Answers of UserFeedbackMultipleChoiceJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_Answers1.Add(extracted_integer);
          }
        initAnswers();
        for (int num3 = 0; num3 < vector_Answers1.Count; ++num3)
            appendAnswers(vector_Answers1[num3]);
        for (int num1 = 0; num1 < vector_Answers1.Count; ++num1)
          {
          }
      }


    public UserFeedbackMultipleChoiceJSON()
      {
        flagHasChoices = false;
        flagHasChoiceLabels = false;
        flagHasAnswers = false;
        storeChoices = new List< string >();
        storeChoiceLabels = new List< string >();
        storeAnswers = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getFeedbackKind()
      {
        return "MultipleChoice";
      }

    public bool  hasChoices()
      {
        return flagHasChoices;
      }

    public int  countOfChoices()
      {
        Debug.Assert(flagHasChoices);
        return storeChoices.Count;
      }

    public string  elementOfChoices(int element_num)
      {
        Debug.Assert(flagHasChoices);
        return storeChoices[element_num];
      }

    public List< string >  getChoices()
      {
        Debug.Assert(flagHasChoices);
        return storeChoices;
      }

    public bool  hasChoiceLabels()
      {
        return flagHasChoiceLabels;
      }

    public int  countOfChoiceLabels()
      {
        Debug.Assert(flagHasChoiceLabels);
        return storeChoiceLabels.Count;
      }

    public string  elementOfChoiceLabels(int element_num)
      {
        Debug.Assert(flagHasChoiceLabels);
        return storeChoiceLabels[element_num];
      }

    public List< string >  getChoiceLabels()
      {
        Debug.Assert(flagHasChoiceLabels);
        return storeChoiceLabels;
      }

    public bool  hasAnswers()
      {
        return flagHasAnswers;
      }

    public int  countOfAnswers()
      {
        Debug.Assert(flagHasAnswers);
        return storeAnswers.Count;
      }

    public BigInteger  elementOfAnswers(int element_num)
      {
        Debug.Assert(flagHasAnswers);
        return storeAnswers[element_num];
      }

    public List< BigInteger >  getAnswers()
      {
        Debug.Assert(flagHasAnswers);
        return storeAnswers;
      }


    public virtual int extraUserFeedbackMultipleChoiceComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUserFeedbackMultipleChoiceComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUserFeedbackMultipleChoiceComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUserFeedbackMultipleChoiceLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUserFeedbackItemComponentCount()
      {
        int result = 0;
        if (flagHasChoices)
            ++result;
        if (flagHasChoiceLabels)
            ++result;
        if (flagHasAnswers)
            ++result;
        result += extraUserFeedbackMultipleChoiceComponentCount();
        return result;
      }
    public override string extraUserFeedbackItemComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasChoices)
          {
            if (remainder == 0)
                return "Choices";
            --remainder;
          }
        if (flagHasChoiceLabels)
          {
            if (remainder == 0)
                return "ChoiceLabels";
            --remainder;
          }
        if (flagHasAnswers)
          {
            if (remainder == 0)
                return "Answers";
            --remainder;
          }
        return extraUserFeedbackMultipleChoiceComponentKey(remainder);
      }
    public override JSONValue extraUserFeedbackItemComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasChoices)
          {
            if (remainder == 0)
                return extraChoicesToJSON();
            --remainder;
          }
        if (flagHasChoiceLabels)
          {
            if (remainder == 0)
                return extraChoiceLabelsToJSON();
            --remainder;
          }
        if (flagHasAnswers)
          {
            if (remainder == 0)
                return extraAnswersToJSON();
            --remainder;
          }
        return extraUserFeedbackMultipleChoiceComponentValue(remainder);
      }
    public override JSONValue extraUserFeedbackItemLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                if ((String.Compare(field_name, 1, "nswers", 0, 6, false) == 0) && (field_name.Length == 7))
                    return (flagHasAnswers ? extraAnswersToJSON() : null);
                break;
            case 'C':
                if (String.Compare(field_name, 1, "hoice", 0, 5, false) == 0)
                  {
                    switch (field_name[6])
                      {
                        case 'L':
                            if ((String.Compare(field_name, 7, "abels", 0, 5, false) == 0) && (field_name.Length == 12))
                                return (flagHasChoiceLabels ? extraChoiceLabelsToJSON() : null);
                            break;
                        case 's':
                            if (field_name.Length == 7)
                                return (flagHasChoices ? extraChoicesToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraUserFeedbackMultipleChoiceLookup(field_name);
      }

    public void initChoices()
      {
        flagHasChoices = true;
        storeChoices.Clear();
      }
    public void appendChoices(string to_append)
      {
        if (!flagHasChoices)
          {
            flagHasChoices = true;
            storeChoices.Clear();
          }
        Debug.Assert(flagHasChoices);
        storeChoices.Add(to_append);
      }
    public void unsetChoices()
      {
        flagHasChoices = false;
        storeChoices.Clear();
      }
    public void initChoiceLabels()
      {
        flagHasChoiceLabels = true;
        storeChoiceLabels.Clear();
      }
    public void appendChoiceLabels(string to_append)
      {
        if (!flagHasChoiceLabels)
          {
            flagHasChoiceLabels = true;
            storeChoiceLabels.Clear();
          }
        Debug.Assert(flagHasChoiceLabels);
        storeChoiceLabels.Add(to_append);
      }
    public void unsetChoiceLabels()
      {
        flagHasChoiceLabels = false;
        storeChoiceLabels.Clear();
      }
    public void initAnswers()
      {
        flagHasAnswers = true;
        storeAnswers.Clear();
      }
    public void appendAnswers(BigInteger to_append)
      {
        if (!flagHasAnswers)
          {
            flagHasAnswers = true;
            storeAnswers.Clear();
          }
        Debug.Assert(flagHasAnswers);
        storeAnswers.Add(to_append);
      }
    public void unsetAnswers()
      {
        flagHasAnswers = false;
        storeAnswers.Clear();
      }

    public virtual void extraUserFeedbackMultipleChoiceAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUserFeedbackMultipleChoiceSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUserFeedbackMultipleChoiceLookup(key);
        if (old_field == null)
          {
            extraUserFeedbackMultipleChoiceAppendPair(key, new_component);
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
    public override void extraUserFeedbackItemAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "nswers", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONAnswers(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if (String.Compare(key, 1, "hoice", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'L':
                            if ((String.Compare(key, 7, "abels", 0, 5, false) == 0) && (key.Length == 12))
                                {
                                fromJSONChoiceLabels(new_component, false);
                                return;
                                }
                            break;
                        case 's':
                            if (key.Length == 7)
                                {
                                fromJSONChoices(new_component, false);
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
        extraUserFeedbackMultipleChoiceAppendPair(key, new_component);
      }
    public override void extraUserFeedbackItemSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                if ((String.Compare(key, 1, "nswers", 0, 6, false) == 0) && (key.Length == 7))
                    {
                    fromJSONAnswers(new_component, false);
                    return;
                    }
                break;
            case 'C':
                if (String.Compare(key, 1, "hoice", 0, 5, false) == 0)
                  {
                    switch (key[6])
                      {
                        case 'L':
                            if ((String.Compare(key, 7, "abels", 0, 5, false) == 0) && (key.Length == 12))
                                {
                                fromJSONChoiceLabels(new_component, false);
                                return;
                                }
                            break;
                        case 's':
                            if (key.Length == 7)
                                {
                                fromJSONChoices(new_component, false);
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
        extraUserFeedbackMultipleChoiceSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasChoices);
        if (flagHasChoices)
          {
            handler.start_pair("Choices");
            Debug.Assert(storeChoices.Count >= 2);
            handler.start_array();
            for (int num1 = 0; num1 < storeChoices.Count; ++num1)
              {
                handler.string_value(storeChoices[num1]);
              }
            handler.finish_array();
          }
        if (flagHasChoiceLabels)
          {
            handler.start_pair("ChoiceLabels");
            Debug.Assert(storeChoiceLabels.Count >= 2);
            handler.start_array();
            for (int num2 = 0; num2 < storeChoiceLabels.Count; ++num2)
              {
                handler.string_value(storeChoiceLabels[num2]);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasAnswers);
        if (flagHasAnswers)
          {
            handler.start_pair("Answers");
            handler.start_array();
            for (int num3 = 0; num3 < storeAnswers.Count; ++num3)
              {
                handler.number_value(storeAnswers[num3]);
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
        if (!(hasChoices()))
          {
            return "When parsing the object for %what%, the \"Choices\" field was missing.";
          }
        if (!(hasAnswers()))
          {
            return "When parsing the object for %what%, the \"Answers\" field was missing.";
          }
        return null;
      }

    public static new UserFeedbackMultipleChoiceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserFeedbackMultipleChoiceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserFeedbackMultipleChoice", ignore_extras);
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
    public static new UserFeedbackMultipleChoiceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UserFeedbackMultipleChoiceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UserFeedbackMultipleChoiceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserFeedbackMultipleChoice", ignore_extras);
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
    public static new UserFeedbackMultipleChoiceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UserFeedbackMultipleChoiceJSON from_text(string text, bool ignore_extras)
      {
        UserFeedbackMultipleChoiceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserFeedbackMultipleChoice", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UserFeedbackMultipleChoiceJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UserFeedbackMultipleChoiceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UserFeedbackMultipleChoiceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UserFeedbackMultipleChoice", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UserFeedbackItemJSON.Generator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorChoices;
        private JSONHoldingStringArrayGenerator fieldGeneratorChoiceLabels;
    private class FieldHoldingGeneratorAnswers : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorAnswers(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorAnswers : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorAnswers(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorAnswers fieldGeneratorAnswers;
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
            if (!(getUserFeedbackItemJSONKey().Equals("MultipleChoice")))
                throw new Exception("The key field has a value other than `MultipleChoice'.");
            UserFeedbackMultipleChoiceJSON result = new UserFeedbackMultipleChoiceJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUserFeedbackMultipleChoiceAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UserFeedbackItemJSON new_result)
          {
            handle_result((UserFeedbackMultipleChoiceJSON )new_result);
          }
        protected void finish(UserFeedbackMultipleChoiceJSON result)
          {
            if (fieldGeneratorChoices.have_value)
              {
                result.initChoices();
                int count = fieldGeneratorChoices.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendChoices(fieldGeneratorChoices.value[num]);
                  }
                fieldGeneratorChoices.value.Clear();
                fieldGeneratorChoices.have_value = false;
              }
            else if ((!(result.hasChoices())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Choices\" field was missing.");
              }
            if (fieldGeneratorChoiceLabels.have_value)
              {
                result.initChoiceLabels();
                int count = fieldGeneratorChoiceLabels.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendChoiceLabels(fieldGeneratorChoiceLabels.value[num]);
                  }
                fieldGeneratorChoiceLabels.value.Clear();
                fieldGeneratorChoiceLabels.have_value = false;
              }
            if (fieldGeneratorAnswers.have_value)
              {
                result.initAnswers();
                int count = fieldGeneratorAnswers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAnswers(fieldGeneratorAnswers.value[num]);
                  }
                fieldGeneratorAnswers.value.Clear();
                fieldGeneratorAnswers.have_value = false;
              }
            else if ((!(result.hasAnswers())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Answers\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(UserFeedbackMultipleChoiceJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "nswers", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorAnswers;
                    break;
                case 'C':
                    if (String.Compare(field_name, 1, "hoice", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 7, "abels", 0, 5, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorChoiceLabels;
                                break;
                            case 's':
                                if (field_name.Length == 7)
                                    return fieldGeneratorChoices;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorChoices = new JSONHoldingStringArrayGenerator("field \"Choices\" of the UserFeedbackMultipleChoice class");
            fieldGeneratorChoiceLabels = new JSONHoldingStringArrayGenerator("field \"ChoiceLabels\" of the UserFeedbackMultipleChoice class");
            fieldGeneratorAnswers = new FieldHoldingArrayGeneratorAnswers("field \"Answers\" of the UserFeedbackMultipleChoice class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UserFeedbackMultipleChoice class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorChoices = new JSONHoldingStringArrayGenerator("field \"Choices\" of the UserFeedbackMultipleChoice class");
            fieldGeneratorChoiceLabels = new JSONHoldingStringArrayGenerator("field \"ChoiceLabels\" of the UserFeedbackMultipleChoice class");
            fieldGeneratorAnswers = new FieldHoldingArrayGeneratorAnswers("field \"Answers\" of the UserFeedbackMultipleChoice class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UserFeedbackMultipleChoice class");
          }

        public override void reset()
          {
            fieldGeneratorChoices.reset();
            fieldGeneratorChoiceLabels.reset();
            fieldGeneratorAnswers.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UserFeedbackMultipleChoiceJSON  result)
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
        public UserFeedbackMultipleChoiceJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UserFeedbackMultipleChoiceJSON  result)
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
    protected virtual void handle_result(List<UserFeedbackMultipleChoiceJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UserFeedbackMultipleChoiceJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UserFeedbackMultipleChoiceJSON>();
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
    public List<UserFeedbackMultipleChoiceJSON> value;
  };
  };
