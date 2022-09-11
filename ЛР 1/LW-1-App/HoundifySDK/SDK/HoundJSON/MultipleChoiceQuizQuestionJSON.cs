/* file "MultipleChoiceQuizQuestionJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MultipleChoiceQuizQuestionJSON : JSONBase
  {
    private bool flagHasQuestion;
    private string storeQuestion;
    private bool flagHasCorrectAnswerIndex;
    private BigInteger storeCorrectAnswerIndex;
    private bool flagHasPossibleAnswers;
    private List< MultipleChoiceQuizPossibleAnswerJSON  > storePossibleAnswers;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQuestion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Question of MultipleChoiceQuizQuestionJSON is not a string.");
        setQuestion(json_string.getData());
      }


    private void  fromJSONCorrectAnswerIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CorrectAnswerIndex of MultipleChoiceQuizQuestionJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CorrectAnswerIndex of MultipleChoiceQuizQuestionJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCorrectAnswerIndex(extracted_integer);
      }


    private void  fromJSONPossibleAnswers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PossibleAnswers of MultipleChoiceQuizQuestionJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 2)
            throw new Exception("The value for field PossibleAnswers of MultipleChoiceQuizQuestionJSON has too few elements.");
        List< MultipleChoiceQuizPossibleAnswerJSON  > vector_PossibleAnswers1 = new List< MultipleChoiceQuizPossibleAnswerJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MultipleChoiceQuizPossibleAnswerJSON convert_classy = MultipleChoiceQuizPossibleAnswerJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_PossibleAnswers1.Add(convert_classy);
          }
        Debug.Assert(vector_PossibleAnswers1.Count >= 2);
        initPossibleAnswers();
        for (int num1 = 0; num1 < vector_PossibleAnswers1.Count; ++num1)
            appendPossibleAnswers(vector_PossibleAnswers1[num1]);
        for (int num1 = 0; num1 < vector_PossibleAnswers1.Count; ++num1)
          {
          }
      }


    public MultipleChoiceQuizQuestionJSON()
      {
        flagHasQuestion = false;
        flagHasCorrectAnswerIndex = false;
        flagHasPossibleAnswers = false;
        storePossibleAnswers = new List< MultipleChoiceQuizPossibleAnswerJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQuestion()
      {
        return flagHasQuestion;
      }

    public string  getQuestion()
      {
        Debug.Assert(flagHasQuestion);
        return storeQuestion;
      }

    public bool  hasCorrectAnswerIndex()
      {
        return flagHasCorrectAnswerIndex;
      }

    public BigInteger  getCorrectAnswerIndex()
      {
        Debug.Assert(flagHasCorrectAnswerIndex);
        return storeCorrectAnswerIndex;
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

    public MultipleChoiceQuizPossibleAnswerJSON   elementOfPossibleAnswers(int element_num)
      {
        Debug.Assert(flagHasPossibleAnswers);
        return storePossibleAnswers[element_num];
      }

    public List< MultipleChoiceQuizPossibleAnswerJSON  >  getPossibleAnswers()
      {
        Debug.Assert(flagHasPossibleAnswers);
        return storePossibleAnswers;
      }


    public virtual int extraMultipleChoiceQuizQuestionComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMultipleChoiceQuizQuestionComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizQuestionComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizQuestionLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setQuestion(string new_value)
      {
        flagHasQuestion = true;
        storeQuestion = new_value;
      }
    public void unsetQuestion()
      {
        flagHasQuestion = false;
      }
    public void setCorrectAnswerIndex(BigInteger new_value)
      {
        flagHasCorrectAnswerIndex = true;
        storeCorrectAnswerIndex = new_value;
      }
    public void unsetCorrectAnswerIndex()
      {
        flagHasCorrectAnswerIndex = false;
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
    public void appendPossibleAnswers(MultipleChoiceQuizPossibleAnswerJSON  to_append)
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

    public virtual void extraMultipleChoiceQuizQuestionAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMultipleChoiceQuizQuestionSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMultipleChoiceQuizQuestionLookup(key);
        if (old_field == null)
          {
            extraMultipleChoiceQuizQuestionAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQuestion);
        if (flagHasQuestion)
          {
            handler.start_pair("Question");
            handler.string_value(storeQuestion);
          }
        Debug.Assert(partial_allowed || flagHasCorrectAnswerIndex);
        if (flagHasCorrectAnswerIndex)
          {
            handler.start_pair("CorrectAnswerIndex");
            handler.number_value(storeCorrectAnswerIndex);
          }
        Debug.Assert(partial_allowed || flagHasPossibleAnswers);
        if (flagHasPossibleAnswers)
          {
            handler.start_pair("PossibleAnswers");
            Debug.Assert(storePossibleAnswers.Count >= 2);
            handler.start_array();
            for (int num1 = 0; num1 < storePossibleAnswers.Count; ++num1)
              {
                if (partial_allowed)
                    storePossibleAnswers[num1].write_partial_as_json(handler);
                else
                    storePossibleAnswers[num1].write_as_json(handler);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasQuestion()))
          {
            return "When parsing the object for %what%, the \"Question\" field was missing.";
          }
        if (!(hasCorrectAnswerIndex()))
          {
            return "When parsing the object for %what%, the \"CorrectAnswerIndex\" field was missing.";
          }
        if (!(hasPossibleAnswers()))
          {
            return "When parsing the object for %what%, the \"PossibleAnswers\" field was missing.";
          }
        return null;
      }

    public static MultipleChoiceQuizQuestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizQuestion", ignore_extras);
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
    public static MultipleChoiceQuizQuestionJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MultipleChoiceQuizQuestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizQuestion", ignore_extras);
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
    public static MultipleChoiceQuizQuestionJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MultipleChoiceQuizQuestionJSON from_text(string text, bool ignore_extras)
      {
        MultipleChoiceQuizQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizQuestion", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MultipleChoiceQuizQuestionJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MultipleChoiceQuizQuestionJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MultipleChoiceQuizQuestionJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizQuestion", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorQuestion;
    private class FieldHoldingGeneratorCorrectAnswerIndex : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorCorrectAnswerIndex(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCorrectAnswerIndex : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCorrectAnswerIndex(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorCorrectAnswerIndex fieldGeneratorCorrectAnswerIndex;
        private MultipleChoiceQuizPossibleAnswerJSON.HoldingArrayGenerator fieldGeneratorPossibleAnswers;
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
            MultipleChoiceQuizQuestionJSON result = new MultipleChoiceQuizQuestionJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMultipleChoiceQuizQuestionAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MultipleChoiceQuizQuestionJSON result)
          {
            if (fieldGeneratorQuestion.have_value)
              {
                result.setQuestion(fieldGeneratorQuestion.value);
                fieldGeneratorQuestion.have_value = false;
              }
            else if ((!(result.hasQuestion())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Question\" field was missing.");
              }
            if (fieldGeneratorCorrectAnswerIndex.have_value)
              {
                result.setCorrectAnswerIndex(fieldGeneratorCorrectAnswerIndex.value);
                fieldGeneratorCorrectAnswerIndex.have_value = false;
              }
            else if ((!(result.hasCorrectAnswerIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CorrectAnswerIndex\" field was missing.");
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
          }
        protected abstract void handle_result(MultipleChoiceQuizQuestionJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "orrectAnswerIndex", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorCorrectAnswerIndex;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ossibleAnswers", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorPossibleAnswers;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uestion", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorQuestion;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQuestion = new JSONHoldingStringGenerator("field \"Question\" of the MultipleChoiceQuizQuestion class");
            fieldGeneratorCorrectAnswerIndex = new FieldHoldingGeneratorCorrectAnswerIndex("field \"CorrectAnswerIndex\" of the MultipleChoiceQuizQuestion class");
            fieldGeneratorPossibleAnswers = new MultipleChoiceQuizPossibleAnswerJSON.HoldingArrayGenerator("field \"PossibleAnswers\" of the MultipleChoiceQuizQuestion class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MultipleChoiceQuizQuestion class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQuestion = new JSONHoldingStringGenerator("field \"Question\" of the MultipleChoiceQuizQuestion class");
            fieldGeneratorCorrectAnswerIndex = new FieldHoldingGeneratorCorrectAnswerIndex("field \"CorrectAnswerIndex\" of the MultipleChoiceQuizQuestion class");
            fieldGeneratorPossibleAnswers = new MultipleChoiceQuizPossibleAnswerJSON.HoldingArrayGenerator("field \"PossibleAnswers\" of the MultipleChoiceQuizQuestion class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MultipleChoiceQuizQuestion class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQuestion.reset();
            fieldGeneratorCorrectAnswerIndex.reset();
            fieldGeneratorPossibleAnswers.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPossibleAnswers.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPossibleAnswers.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MultipleChoiceQuizQuestionJSON  result)
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
        public MultipleChoiceQuizQuestionJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MultipleChoiceQuizQuestionJSON  result)
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
    protected virtual void handle_result(List<MultipleChoiceQuizQuestionJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MultipleChoiceQuizQuestionJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MultipleChoiceQuizQuestionJSON>();
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
    public List<MultipleChoiceQuizQuestionJSON> value;
  };
  };
