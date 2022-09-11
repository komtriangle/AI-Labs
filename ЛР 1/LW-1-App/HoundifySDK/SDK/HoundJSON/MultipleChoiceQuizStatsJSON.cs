/* file "MultipleChoiceQuizStatsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MultipleChoiceQuizStatsJSON : JSONBase
  {
    private bool flagHasPlayerCount;
    private BigInteger storePlayerCount;
    private bool flagHasQuestionCount;
    private BigInteger storeQuestionCount;
    private bool flagHasCorrectAnswersGiven;
    private List< BigInteger > storeCorrectAnswersGiven;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPlayerCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PlayerCount of MultipleChoiceQuizStatsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PlayerCount of MultipleChoiceQuizStatsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPlayerCount(extracted_integer);
      }


    private void  fromJSONQuestionCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field QuestionCount of MultipleChoiceQuizStatsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field QuestionCount of MultipleChoiceQuizStatsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setQuestionCount(extracted_integer);
      }


    private void  fromJSONCorrectAnswersGiven(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CorrectAnswersGiven of MultipleChoiceQuizStatsJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field CorrectAnswersGiven of MultipleChoiceQuizStatsJSON has too few elements.");
        List< BigInteger > vector_CorrectAnswersGiven1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field CorrectAnswersGiven of MultipleChoiceQuizStatsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field CorrectAnswersGiven of MultipleChoiceQuizStatsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_CorrectAnswersGiven1.Add(extracted_integer);
          }
        Debug.Assert(vector_CorrectAnswersGiven1.Count >= 1);
        initCorrectAnswersGiven();
        for (int num1 = 0; num1 < vector_CorrectAnswersGiven1.Count; ++num1)
            appendCorrectAnswersGiven(vector_CorrectAnswersGiven1[num1]);
        for (int num1 = 0; num1 < vector_CorrectAnswersGiven1.Count; ++num1)
          {
          }
      }


    public MultipleChoiceQuizStatsJSON()
      {
        flagHasPlayerCount = false;
        flagHasQuestionCount = false;
        flagHasCorrectAnswersGiven = false;
        storeCorrectAnswersGiven = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPlayerCount()
      {
        return flagHasPlayerCount;
      }

    public BigInteger  getPlayerCount()
      {
        Debug.Assert(flagHasPlayerCount);
        return storePlayerCount;
      }

    public bool  hasQuestionCount()
      {
        return flagHasQuestionCount;
      }

    public BigInteger  getQuestionCount()
      {
        Debug.Assert(flagHasQuestionCount);
        return storeQuestionCount;
      }

    public bool  hasCorrectAnswersGiven()
      {
        return flagHasCorrectAnswersGiven;
      }

    public int  countOfCorrectAnswersGiven()
      {
        Debug.Assert(flagHasCorrectAnswersGiven);
        return storeCorrectAnswersGiven.Count;
      }

    public BigInteger  elementOfCorrectAnswersGiven(int element_num)
      {
        Debug.Assert(flagHasCorrectAnswersGiven);
        return storeCorrectAnswersGiven[element_num];
      }

    public List< BigInteger >  getCorrectAnswersGiven()
      {
        Debug.Assert(flagHasCorrectAnswersGiven);
        return storeCorrectAnswersGiven;
      }


    public virtual int extraMultipleChoiceQuizStatsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMultipleChoiceQuizStatsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizStatsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMultipleChoiceQuizStatsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPlayerCount(BigInteger new_value)
      {
        flagHasPlayerCount = true;
        storePlayerCount = new_value;
      }
    public void unsetPlayerCount()
      {
        flagHasPlayerCount = false;
      }
    public void setQuestionCount(BigInteger new_value)
      {
        flagHasQuestionCount = true;
        storeQuestionCount = new_value;
      }
    public void unsetQuestionCount()
      {
        flagHasQuestionCount = false;
      }
    public void initCorrectAnswersGiven()
      {
        flagHasCorrectAnswersGiven = true;
        storeCorrectAnswersGiven.Clear();
      }
    public void appendCorrectAnswersGiven(BigInteger to_append)
      {
        if (!flagHasCorrectAnswersGiven)
          {
            flagHasCorrectAnswersGiven = true;
            storeCorrectAnswersGiven.Clear();
          }
        Debug.Assert(flagHasCorrectAnswersGiven);
        storeCorrectAnswersGiven.Add(to_append);
      }
    public void unsetCorrectAnswersGiven()
      {
        flagHasCorrectAnswersGiven = false;
        storeCorrectAnswersGiven.Clear();
      }

    public virtual void extraMultipleChoiceQuizStatsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMultipleChoiceQuizStatsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMultipleChoiceQuizStatsLookup(key);
        if (old_field == null)
          {
            extraMultipleChoiceQuizStatsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPlayerCount);
        if (flagHasPlayerCount)
          {
            handler.start_pair("PlayerCount");
            handler.number_value(storePlayerCount);
          }
        Debug.Assert(partial_allowed || flagHasQuestionCount);
        if (flagHasQuestionCount)
          {
            handler.start_pair("QuestionCount");
            handler.number_value(storeQuestionCount);
          }
        Debug.Assert(partial_allowed || flagHasCorrectAnswersGiven);
        if (flagHasCorrectAnswersGiven)
          {
            handler.start_pair("CorrectAnswersGiven");
            Debug.Assert(storeCorrectAnswersGiven.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeCorrectAnswersGiven.Count; ++num1)
              {
                handler.number_value(storeCorrectAnswersGiven[num1]);
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
        if (!(hasPlayerCount()))
          {
            return "When parsing the object for %what%, the \"PlayerCount\" field was missing.";
          }
        if (!(hasQuestionCount()))
          {
            return "When parsing the object for %what%, the \"QuestionCount\" field was missing.";
          }
        if (!(hasCorrectAnswersGiven()))
          {
            return "When parsing the object for %what%, the \"CorrectAnswersGiven\" field was missing.";
          }
        return null;
      }

    public static MultipleChoiceQuizStatsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizStatsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizStats", ignore_extras);
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
    public static MultipleChoiceQuizStatsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MultipleChoiceQuizStatsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MultipleChoiceQuizStatsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizStats", ignore_extras);
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
    public static MultipleChoiceQuizStatsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MultipleChoiceQuizStatsJSON from_text(string text, bool ignore_extras)
      {
        MultipleChoiceQuizStatsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizStats", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MultipleChoiceQuizStatsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MultipleChoiceQuizStatsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MultipleChoiceQuizStatsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MultipleChoiceQuizStats", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorPlayerCount : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorPlayerCount(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPlayerCount : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPlayerCount(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorPlayerCount fieldGeneratorPlayerCount;
    private class FieldHoldingGeneratorQuestionCount : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorQuestionCount(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorQuestionCount : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorQuestionCount(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorQuestionCount fieldGeneratorQuestionCount;
    private class FieldHoldingGeneratorCorrectAnswersGiven : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorCorrectAnswersGiven(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCorrectAnswersGiven : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCorrectAnswersGiven(String what) : base(what)
              {
              }
          };
        private FieldHoldingArrayGeneratorCorrectAnswersGiven fieldGeneratorCorrectAnswersGiven;
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
            MultipleChoiceQuizStatsJSON result = new MultipleChoiceQuizStatsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMultipleChoiceQuizStatsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MultipleChoiceQuizStatsJSON result)
          {
            if (fieldGeneratorPlayerCount.have_value)
              {
                result.setPlayerCount(fieldGeneratorPlayerCount.value);
                fieldGeneratorPlayerCount.have_value = false;
              }
            else if ((!(result.hasPlayerCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PlayerCount\" field was missing.");
              }
            if (fieldGeneratorQuestionCount.have_value)
              {
                result.setQuestionCount(fieldGeneratorQuestionCount.value);
                fieldGeneratorQuestionCount.have_value = false;
              }
            else if ((!(result.hasQuestionCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QuestionCount\" field was missing.");
              }
            if (fieldGeneratorCorrectAnswersGiven.have_value)
              {
                result.initCorrectAnswersGiven();
                int count = fieldGeneratorCorrectAnswersGiven.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCorrectAnswersGiven(fieldGeneratorCorrectAnswersGiven.value[num]);
                  }
                fieldGeneratorCorrectAnswersGiven.value.Clear();
                fieldGeneratorCorrectAnswersGiven.have_value = false;
              }
            else if ((!(result.hasCorrectAnswersGiven())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CorrectAnswersGiven\" field was missing.");
              }
          }
        protected abstract void handle_result(MultipleChoiceQuizStatsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "orrectAnswersGiven", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorCorrectAnswersGiven;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "layerCount", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorPlayerCount;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uestionCount", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorQuestionCount;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPlayerCount = new FieldHoldingGeneratorPlayerCount("field \"PlayerCount\" of the MultipleChoiceQuizStats class");
            fieldGeneratorQuestionCount = new FieldHoldingGeneratorQuestionCount("field \"QuestionCount\" of the MultipleChoiceQuizStats class");
            fieldGeneratorCorrectAnswersGiven = new FieldHoldingArrayGeneratorCorrectAnswersGiven("field \"CorrectAnswersGiven\" of the MultipleChoiceQuizStats class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MultipleChoiceQuizStats class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPlayerCount = new FieldHoldingGeneratorPlayerCount("field \"PlayerCount\" of the MultipleChoiceQuizStats class");
            fieldGeneratorQuestionCount = new FieldHoldingGeneratorQuestionCount("field \"QuestionCount\" of the MultipleChoiceQuizStats class");
            fieldGeneratorCorrectAnswersGiven = new FieldHoldingArrayGeneratorCorrectAnswersGiven("field \"CorrectAnswersGiven\" of the MultipleChoiceQuizStats class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MultipleChoiceQuizStats class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPlayerCount.reset();
            fieldGeneratorQuestionCount.reset();
            fieldGeneratorCorrectAnswersGiven.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MultipleChoiceQuizStatsJSON  result)
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
        public MultipleChoiceQuizStatsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MultipleChoiceQuizStatsJSON  result)
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
    protected virtual void handle_result(List<MultipleChoiceQuizStatsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MultipleChoiceQuizStatsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MultipleChoiceQuizStatsJSON>();
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
    public List<MultipleChoiceQuizStatsJSON> value;
  };
  };
