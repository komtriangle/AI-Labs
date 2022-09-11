/* file "SurveyJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class SurveyJSON : JSONBase
  {
    private bool flagHasId;
    private BigInteger storeId;
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasDescription;
    private string storeDescription;
    private bool flagHasMedia;
    private SurveyMediaJSON  storeMedia;
    private bool flagHasProvider;
    private string storeProvider;
    private bool flagHasMetaInformation;
    private SurveyMetaInfoJSON  storeMetaInformation;
    private bool flagHasCurrentQuestion;
    private BigInteger storeCurrentQuestion;
    private bool flagHasQuestions;
    private List< SurveyQuestionJSON  > storeQuestions;
    private bool flagHasAnsweredQuestionIds;
    private List< BigInteger > storeAnsweredQuestionIds;
    private bool flagHasFlowGraph;
    private SurveyFlowGraphJSON  storeFlowGraph;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Id of SurveyJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Id of SurveyJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setId(extracted_integer);
      }


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of SurveyJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Description of SurveyJSON is not a string.");
        setDescription(json_string.getData());
      }


    private void  fromJSONMedia(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SurveyMediaJSON convert_classy = SurveyMediaJSON.from_json(json_value, ignore_extras, true);
        setMedia(convert_classy);
      }


    private void  fromJSONProvider(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Provider of SurveyJSON is not a string.");
        setProvider(json_string.getData());
      }


    private void  fromJSONMetaInformation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SurveyMetaInfoJSON convert_classy = SurveyMetaInfoJSON.from_json(json_value, ignore_extras, true);
        setMetaInformation(convert_classy);
      }


    private void  fromJSONCurrentQuestion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CurrentQuestion of SurveyJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CurrentQuestion of SurveyJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCurrentQuestion(extracted_integer);
      }


    private void  fromJSONQuestions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Questions of SurveyJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< SurveyQuestionJSON  > vector_Questions1 = new List< SurveyQuestionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            SurveyQuestionJSON convert_classy = SurveyQuestionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Questions1.Add(convert_classy);
          }
        initQuestions();
        for (int num1 = 0; num1 < vector_Questions1.Count; ++num1)
            appendQuestions(vector_Questions1[num1]);
        for (int num1 = 0; num1 < vector_Questions1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAnsweredQuestionIds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AnsweredQuestionIds of SurveyJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_AnsweredQuestionIds1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field AnsweredQuestionIds of SurveyJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field AnsweredQuestionIds of SurveyJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_AnsweredQuestionIds1.Add(extracted_integer);
          }
        initAnsweredQuestionIds();
        for (int num2 = 0; num2 < vector_AnsweredQuestionIds1.Count; ++num2)
            appendAnsweredQuestionIds(vector_AnsweredQuestionIds1[num2]);
        for (int num1 = 0; num1 < vector_AnsweredQuestionIds1.Count; ++num1)
          {
          }
      }


    private void  fromJSONFlowGraph(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SurveyFlowGraphJSON convert_classy = SurveyFlowGraphJSON.from_json(json_value, ignore_extras, true);
        setFlowGraph(convert_classy);
      }


    public SurveyJSON()
      {
        flagHasId = false;
        flagHasTitle = false;
        flagHasDescription = false;
        flagHasMedia = false;
        flagHasProvider = false;
        flagHasMetaInformation = false;
        flagHasCurrentQuestion = false;
        flagHasQuestions = false;
        flagHasAnsweredQuestionIds = false;
        flagHasFlowGraph = false;
        storeQuestions = new List< SurveyQuestionJSON  >();
        storeAnsweredQuestionIds = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasId()
      {
        return flagHasId;
      }

    public BigInteger  getId()
      {
        Debug.Assert(flagHasId);
        return storeId;
      }

    public bool  hasTitle()
      {
        return flagHasTitle;
      }

    public string  getTitle()
      {
        Debug.Assert(flagHasTitle);
        return storeTitle;
      }

    public bool  hasDescription()
      {
        return flagHasDescription;
      }

    public string  getDescription()
      {
        Debug.Assert(flagHasDescription);
        return storeDescription;
      }

    public bool  hasMedia()
      {
        return flagHasMedia;
      }

    public SurveyMediaJSON   getMedia()
      {
        Debug.Assert(flagHasMedia);
        return storeMedia;
      }

    public bool  hasProvider()
      {
        return flagHasProvider;
      }

    public string  getProvider()
      {
        Debug.Assert(flagHasProvider);
        return storeProvider;
      }

    public bool  hasMetaInformation()
      {
        return flagHasMetaInformation;
      }

    public SurveyMetaInfoJSON   getMetaInformation()
      {
        Debug.Assert(flagHasMetaInformation);
        return storeMetaInformation;
      }

    public bool  hasCurrentQuestion()
      {
        return flagHasCurrentQuestion;
      }

    public BigInteger  getCurrentQuestion()
      {
        Debug.Assert(flagHasCurrentQuestion);
        return storeCurrentQuestion;
      }

    public bool  hasQuestions()
      {
        return flagHasQuestions;
      }

    public int  countOfQuestions()
      {
        Debug.Assert(flagHasQuestions);
        return storeQuestions.Count;
      }

    public SurveyQuestionJSON   elementOfQuestions(int element_num)
      {
        Debug.Assert(flagHasQuestions);
        return storeQuestions[element_num];
      }

    public List< SurveyQuestionJSON  >  getQuestions()
      {
        Debug.Assert(flagHasQuestions);
        return storeQuestions;
      }

    public bool  hasAnsweredQuestionIds()
      {
        return flagHasAnsweredQuestionIds;
      }

    public int  countOfAnsweredQuestionIds()
      {
        Debug.Assert(flagHasAnsweredQuestionIds);
        return storeAnsweredQuestionIds.Count;
      }

    public BigInteger  elementOfAnsweredQuestionIds(int element_num)
      {
        Debug.Assert(flagHasAnsweredQuestionIds);
        return storeAnsweredQuestionIds[element_num];
      }

    public List< BigInteger >  getAnsweredQuestionIds()
      {
        Debug.Assert(flagHasAnsweredQuestionIds);
        return storeAnsweredQuestionIds;
      }

    public bool  hasFlowGraph()
      {
        return flagHasFlowGraph;
      }

    public SurveyFlowGraphJSON   getFlowGraph()
      {
        Debug.Assert(flagHasFlowGraph);
        return storeFlowGraph;
      }


    public virtual int extraSurveyComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraSurveyComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraSurveyComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraSurveyLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setId(BigInteger new_value)
      {
        flagHasId = true;
        if (new_value < 0)
            throw new Exception("The value for field Id of SurveyJSON is less than the lower bound (0) for that field.");
        storeId = new_value;
      }
    public void unsetId()
      {
        flagHasId = false;
      }
    public void setTitle(string new_value)
      {
        flagHasTitle = true;
        storeTitle = new_value;
      }
    public void unsetTitle()
      {
        flagHasTitle = false;
      }
    public void setDescription(string new_value)
      {
        flagHasDescription = true;
        storeDescription = new_value;
      }
    public void unsetDescription()
      {
        flagHasDescription = false;
      }
    public void setMedia(SurveyMediaJSON  new_value)
      {
        if (flagHasMedia)
          {
          }
        flagHasMedia = true;
        storeMedia = new_value;
      }
    public void unsetMedia()
      {
        if (flagHasMedia)
          {
          }
        flagHasMedia = false;
      }
    public void setProvider(string new_value)
      {
        flagHasProvider = true;
        storeProvider = new_value;
      }
    public void unsetProvider()
      {
        flagHasProvider = false;
      }
    public void setMetaInformation(SurveyMetaInfoJSON  new_value)
      {
        if (flagHasMetaInformation)
          {
          }
        flagHasMetaInformation = true;
        storeMetaInformation = new_value;
      }
    public void unsetMetaInformation()
      {
        if (flagHasMetaInformation)
          {
          }
        flagHasMetaInformation = false;
      }
    public void setCurrentQuestion(BigInteger new_value)
      {
        flagHasCurrentQuestion = true;
        if (new_value < 0)
            throw new Exception("The value for field CurrentQuestion of SurveyJSON is less than the lower bound (0) for that field.");
        storeCurrentQuestion = new_value;
      }
    public void unsetCurrentQuestion()
      {
        flagHasCurrentQuestion = false;
      }
    public void initQuestions()
      {
        if (flagHasQuestions)
          {
            for (int num1 = 0; num1 < storeQuestions.Count; ++num1)
              {
              }
          }
        flagHasQuestions = true;
        storeQuestions.Clear();
      }
    public void appendQuestions(SurveyQuestionJSON  to_append)
      {
        if (!flagHasQuestions)
          {
            flagHasQuestions = true;
            storeQuestions.Clear();
          }
        Debug.Assert(flagHasQuestions);
        storeQuestions.Add(to_append);
      }
    public void unsetQuestions()
      {
        if (flagHasQuestions)
          {
            for (int num2 = 0; num2 < storeQuestions.Count; ++num2)
              {
              }
          }
        flagHasQuestions = false;
        storeQuestions.Clear();
      }
    public void initAnsweredQuestionIds()
      {
        flagHasAnsweredQuestionIds = true;
        storeAnsweredQuestionIds.Clear();
      }
    public void appendAnsweredQuestionIds(BigInteger to_append)
      {
        if (!flagHasAnsweredQuestionIds)
          {
            flagHasAnsweredQuestionIds = true;
            storeAnsweredQuestionIds.Clear();
          }
        Debug.Assert(flagHasAnsweredQuestionIds);
        storeAnsweredQuestionIds.Add(to_append);
      }
    public void unsetAnsweredQuestionIds()
      {
        flagHasAnsweredQuestionIds = false;
        storeAnsweredQuestionIds.Clear();
      }
    public void setFlowGraph(SurveyFlowGraphJSON  new_value)
      {
        if (flagHasFlowGraph)
          {
          }
        flagHasFlowGraph = true;
        storeFlowGraph = new_value;
      }
    public void unsetFlowGraph()
      {
        if (flagHasFlowGraph)
          {
          }
        flagHasFlowGraph = false;
      }

    public virtual void extraSurveyAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraSurveySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraSurveyLookup(key);
        if (old_field == null)
          {
            extraSurveyAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasId);
        if (flagHasId)
          {
            handler.start_pair("Id");
            handler.number_value(storeId);
          }
        Debug.Assert(partial_allowed || flagHasTitle);
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            handler.string_value(storeDescription);
          }
        if (flagHasMedia)
          {
            handler.start_pair("Media");
            if (partial_allowed)
                storeMedia.write_partial_as_json(handler);
            else
                storeMedia.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasProvider);
        if (flagHasProvider)
          {
            handler.start_pair("Provider");
            handler.string_value(storeProvider);
          }
        if (flagHasMetaInformation)
          {
            handler.start_pair("MetaInformation");
            if (partial_allowed)
                storeMetaInformation.write_partial_as_json(handler);
            else
                storeMetaInformation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasCurrentQuestion);
        if (flagHasCurrentQuestion)
          {
            handler.start_pair("CurrentQuestion");
            handler.number_value(storeCurrentQuestion);
          }
        Debug.Assert(partial_allowed || flagHasQuestions);
        if (flagHasQuestions)
          {
            handler.start_pair("Questions");
            handler.start_array();
            for (int num1 = 0; num1 < storeQuestions.Count; ++num1)
              {
                if (partial_allowed)
                    storeQuestions[num1].write_partial_as_json(handler);
                else
                    storeQuestions[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAnsweredQuestionIds)
          {
            handler.start_pair("AnsweredQuestionIds");
            handler.start_array();
            for (int num2 = 0; num2 < storeAnsweredQuestionIds.Count; ++num2)
              {
                handler.number_value(storeAnsweredQuestionIds[num2]);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasFlowGraph);
        if (flagHasFlowGraph)
          {
            handler.start_pair("FlowGraph");
            if (partial_allowed)
                storeFlowGraph.write_partial_as_json(handler);
            else
                storeFlowGraph.write_as_json(handler);
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
        if (!(hasId()))
          {
            return "When parsing the object for %what%, the \"Id\" field was missing.";
          }
        if (!(hasTitle()))
          {
            return "When parsing the object for %what%, the \"Title\" field was missing.";
          }
        if (!(hasProvider()))
          {
            return "When parsing the object for %what%, the \"Provider\" field was missing.";
          }
        if (!(hasCurrentQuestion()))
          {
            return "When parsing the object for %what%, the \"CurrentQuestion\" field was missing.";
          }
        if (!(hasQuestions()))
          {
            return "When parsing the object for %what%, the \"Questions\" field was missing.";
          }
        if (!(hasFlowGraph()))
          {
            return "When parsing the object for %what%, the \"FlowGraph\" field was missing.";
          }
        return null;
      }

    public static SurveyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Survey", ignore_extras);
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
    public static SurveyJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SurveyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Survey", ignore_extras);
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
    public static SurveyJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static SurveyJSON from_text(string text, bool ignore_extras)
      {
        SurveyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Survey", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SurveyJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static SurveyJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SurveyJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type Survey", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorId : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorId : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorId fieldGeneratorId;
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorDescription;
        private SurveyMediaJSON.HoldingGenerator fieldGeneratorMedia;
        private JSONHoldingStringGenerator fieldGeneratorProvider;
        private SurveyMetaInfoJSON.HoldingGenerator fieldGeneratorMetaInformation;
    private class FieldHoldingGeneratorCurrentQuestion : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorCurrentQuestion(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorCurrentQuestion : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorCurrentQuestion(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorCurrentQuestion fieldGeneratorCurrentQuestion;
        private SurveyQuestionJSON.HoldingArrayGenerator fieldGeneratorQuestions;
    private class FieldHoldingGeneratorAnsweredQuestionIds : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorAnsweredQuestionIds(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorAnsweredQuestionIds : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorAnsweredQuestionIds(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingArrayGeneratorAnsweredQuestionIds fieldGeneratorAnsweredQuestionIds;
        private SurveyFlowGraphJSON.HoldingGenerator fieldGeneratorFlowGraph;
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
            SurveyJSON result = new SurveyJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraSurveyAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(SurveyJSON result)
          {
            if (fieldGeneratorId.have_value)
              {
                result.setId(fieldGeneratorId.value);
                fieldGeneratorId.have_value = false;
              }
            else if ((!(result.hasId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Id\" field was missing.");
              }
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            else if ((!(result.hasTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Title\" field was missing.");
              }
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            if (fieldGeneratorMedia.have_value)
              {
                result.setMedia(fieldGeneratorMedia.value);
                fieldGeneratorMedia.have_value = false;
              }
            if (fieldGeneratorProvider.have_value)
              {
                result.setProvider(fieldGeneratorProvider.value);
                fieldGeneratorProvider.have_value = false;
              }
            else if ((!(result.hasProvider())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Provider\" field was missing.");
              }
            if (fieldGeneratorMetaInformation.have_value)
              {
                result.setMetaInformation(fieldGeneratorMetaInformation.value);
                fieldGeneratorMetaInformation.have_value = false;
              }
            if (fieldGeneratorCurrentQuestion.have_value)
              {
                result.setCurrentQuestion(fieldGeneratorCurrentQuestion.value);
                fieldGeneratorCurrentQuestion.have_value = false;
              }
            else if ((!(result.hasCurrentQuestion())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CurrentQuestion\" field was missing.");
              }
            if (fieldGeneratorQuestions.have_value)
              {
                result.initQuestions();
                int count = fieldGeneratorQuestions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQuestions(fieldGeneratorQuestions.value[num]);
                  }
                fieldGeneratorQuestions.value.Clear();
                fieldGeneratorQuestions.have_value = false;
              }
            else if ((!(result.hasQuestions())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Questions\" field was missing.");
              }
            if (fieldGeneratorAnsweredQuestionIds.have_value)
              {
                result.initAnsweredQuestionIds();
                int count = fieldGeneratorAnsweredQuestionIds.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAnsweredQuestionIds(fieldGeneratorAnsweredQuestionIds.value[num]);
                  }
                fieldGeneratorAnsweredQuestionIds.value.Clear();
                fieldGeneratorAnsweredQuestionIds.have_value = false;
              }
            if (fieldGeneratorFlowGraph.have_value)
              {
                result.setFlowGraph(fieldGeneratorFlowGraph.value);
                fieldGeneratorFlowGraph.have_value = false;
              }
            else if ((!(result.hasFlowGraph())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlowGraph\" field was missing.");
              }
          }
        protected abstract void handle_result(SurveyJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "nsweredQuestionIds", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorAnsweredQuestionIds;
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "urrentQuestion", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorCurrentQuestion;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDescription;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "lowGraph", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorFlowGraph;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorId;
                    break;
                case 'M':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'd':
                                if ((String.Compare(field_name, 3, "ia", 0, 2, false) == 0) && (field_name.Length == 5))
                                    return fieldGeneratorMedia;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 3, "aInformation", 0, 12, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorMetaInformation;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rovider", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorProvider;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uestions", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQuestions;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorTitle;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorId = new FieldHoldingGeneratorId("field \"Id\" of the Survey class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the Survey class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the Survey class");
            fieldGeneratorMedia = new SurveyMediaJSON.HoldingGenerator("field \"Media\" of the Survey class", ignore_extras);
            fieldGeneratorProvider = new JSONHoldingStringGenerator("field \"Provider\" of the Survey class");
            fieldGeneratorMetaInformation = new SurveyMetaInfoJSON.HoldingGenerator("field \"MetaInformation\" of the Survey class", ignore_extras);
            fieldGeneratorCurrentQuestion = new FieldHoldingGeneratorCurrentQuestion("field \"CurrentQuestion\" of the Survey class");
            fieldGeneratorQuestions = new SurveyQuestionJSON.HoldingArrayGenerator("field \"Questions\" of the Survey class", ignore_extras);
            fieldGeneratorAnsweredQuestionIds = new FieldHoldingArrayGeneratorAnsweredQuestionIds("field \"AnsweredQuestionIds\" of the Survey class");
            fieldGeneratorFlowGraph = new SurveyFlowGraphJSON.HoldingGenerator("field \"FlowGraph\" of the Survey class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the Survey class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorId = new FieldHoldingGeneratorId("field \"Id\" of the Survey class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the Survey class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the Survey class");
            fieldGeneratorMedia = new SurveyMediaJSON.HoldingGenerator("field \"Media\" of the Survey class", false);
            fieldGeneratorProvider = new JSONHoldingStringGenerator("field \"Provider\" of the Survey class");
            fieldGeneratorMetaInformation = new SurveyMetaInfoJSON.HoldingGenerator("field \"MetaInformation\" of the Survey class", false);
            fieldGeneratorCurrentQuestion = new FieldHoldingGeneratorCurrentQuestion("field \"CurrentQuestion\" of the Survey class");
            fieldGeneratorQuestions = new SurveyQuestionJSON.HoldingArrayGenerator("field \"Questions\" of the Survey class", false);
            fieldGeneratorAnsweredQuestionIds = new FieldHoldingArrayGeneratorAnsweredQuestionIds("field \"AnsweredQuestionIds\" of the Survey class");
            fieldGeneratorFlowGraph = new SurveyFlowGraphJSON.HoldingGenerator("field \"FlowGraph\" of the Survey class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the Survey class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorId.reset();
            fieldGeneratorTitle.reset();
            fieldGeneratorDescription.reset();
            fieldGeneratorMedia.reset();
            fieldGeneratorProvider.reset();
            fieldGeneratorMetaInformation.reset();
            fieldGeneratorCurrentQuestion.reset();
            fieldGeneratorQuestions.reset();
            fieldGeneratorAnsweredQuestionIds.reset();
            fieldGeneratorFlowGraph.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorMedia.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMetaInformation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorQuestions.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorFlowGraph.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMedia.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMetaInformation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorQuestions.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorFlowGraph.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(SurveyJSON  result)
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
        public SurveyJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SurveyJSON  result)
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
    protected virtual void handle_result(List<SurveyJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SurveyJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SurveyJSON>();
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
    public List<SurveyJSON> value;
  };
  };
