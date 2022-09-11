/* file "UploadedChainedTestCaseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UploadedChainedTestCaseJSON : JSONBase
  {
    private bool flagHasInput;
    private List< UploadedTestCaseInputJSON  > storeInput;
    private bool flagHasExpected;
    private List< UploadedTestCaseExpectedJSON  > storeExpected;
    private bool flagHasTimedOutOnThisTestCase;
    private bool storeTimedOutOnThisTestCase;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONInput(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Input of UploadedChainedTestCaseJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Input of UploadedChainedTestCaseJSON has too few elements.");
        List< UploadedTestCaseInputJSON  > vector_Input1 = new List< UploadedTestCaseInputJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UploadedTestCaseInputJSON convert_classy = UploadedTestCaseInputJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Input1.Add(convert_classy);
          }
        Debug.Assert(vector_Input1.Count >= 1);
        initInput();
        for (int num1 = 0; num1 < vector_Input1.Count; ++num1)
            appendInput(vector_Input1[num1]);
        for (int num1 = 0; num1 < vector_Input1.Count; ++num1)
          {
          }
      }


    private void  fromJSONExpected(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Expected of UploadedChainedTestCaseJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Expected of UploadedChainedTestCaseJSON has too few elements.");
        List< UploadedTestCaseExpectedJSON  > vector_Expected1 = new List< UploadedTestCaseExpectedJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UploadedTestCaseExpectedJSON convert_classy = UploadedTestCaseExpectedJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Expected1.Add(convert_classy);
          }
        Debug.Assert(vector_Expected1.Count >= 1);
        initExpected();
        for (int num2 = 0; num2 < vector_Expected1.Count; ++num2)
            appendExpected(vector_Expected1[num2]);
        for (int num1 = 0; num1 < vector_Expected1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTimedOutOnThisTestCase(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TimedOutOnThisTestCase of UploadedChainedTestCaseJSON is not true for false.");
              }
          }
        setTimedOutOnThisTestCase(the_bool);
      }


    public UploadedChainedTestCaseJSON()
      {
        flagHasInput = false;
        flagHasExpected = false;
        flagHasTimedOutOnThisTestCase = false;
        storeInput = new List< UploadedTestCaseInputJSON  >();
        storeExpected = new List< UploadedTestCaseExpectedJSON  >();
        storeTimedOutOnThisTestCase = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasInput()
      {
        return flagHasInput;
      }

    public int  countOfInput()
      {
        Debug.Assert(flagHasInput);
        return storeInput.Count;
      }

    public UploadedTestCaseInputJSON   elementOfInput(int element_num)
      {
        Debug.Assert(flagHasInput);
        return storeInput[element_num];
      }

    public List< UploadedTestCaseInputJSON  >  getInput()
      {
        Debug.Assert(flagHasInput);
        return storeInput;
      }

    public bool  hasExpected()
      {
        return flagHasExpected;
      }

    public int  countOfExpected()
      {
        Debug.Assert(flagHasExpected);
        return storeExpected.Count;
      }

    public UploadedTestCaseExpectedJSON   elementOfExpected(int element_num)
      {
        Debug.Assert(flagHasExpected);
        return storeExpected[element_num];
      }

    public List< UploadedTestCaseExpectedJSON  >  getExpected()
      {
        Debug.Assert(flagHasExpected);
        return storeExpected;
      }

    public bool  hasTimedOutOnThisTestCase()
      {
        return flagHasTimedOutOnThisTestCase;
      }

    public bool  getTimedOutOnThisTestCase()
      {
        return storeTimedOutOnThisTestCase;
      }


    public virtual int extraUploadedChainedTestCaseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUploadedChainedTestCaseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUploadedChainedTestCaseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUploadedChainedTestCaseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initInput()
      {
        if (flagHasInput)
          {
            for (int num1 = 0; num1 < storeInput.Count; ++num1)
              {
              }
          }
        flagHasInput = true;
        storeInput.Clear();
      }
    public void appendInput(UploadedTestCaseInputJSON  to_append)
      {
        if (!flagHasInput)
          {
            flagHasInput = true;
            storeInput.Clear();
          }
        Debug.Assert(flagHasInput);
        storeInput.Add(to_append);
      }
    public void unsetInput()
      {
        if (flagHasInput)
          {
            for (int num2 = 0; num2 < storeInput.Count; ++num2)
              {
              }
          }
        flagHasInput = false;
        storeInput.Clear();
      }
    public void initExpected()
      {
        if (flagHasExpected)
          {
            for (int num3 = 0; num3 < storeExpected.Count; ++num3)
              {
              }
          }
        flagHasExpected = true;
        storeExpected.Clear();
      }
    public void appendExpected(UploadedTestCaseExpectedJSON  to_append)
      {
        if (!flagHasExpected)
          {
            flagHasExpected = true;
            storeExpected.Clear();
          }
        Debug.Assert(flagHasExpected);
        storeExpected.Add(to_append);
      }
    public void unsetExpected()
      {
        if (flagHasExpected)
          {
            for (int num4 = 0; num4 < storeExpected.Count; ++num4)
              {
              }
          }
        flagHasExpected = false;
        storeExpected.Clear();
      }
    public void setTimedOutOnThisTestCase(bool new_value)
      {
        flagHasTimedOutOnThisTestCase = true;
        storeTimedOutOnThisTestCase = new_value;
      }
    public void unsetTimedOutOnThisTestCase()
      {
        flagHasTimedOutOnThisTestCase = false;
      }

    public virtual void extraUploadedChainedTestCaseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUploadedChainedTestCaseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUploadedChainedTestCaseLookup(key);
        if (old_field == null)
          {
            extraUploadedChainedTestCaseAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasInput);
        if (flagHasInput)
          {
            handler.start_pair("Input");
            Debug.Assert(storeInput.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeInput.Count; ++num1)
              {
                if (partial_allowed)
                    storeInput[num1].write_partial_as_json(handler);
                else
                    storeInput[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasExpected);
        if (flagHasExpected)
          {
            handler.start_pair("Expected");
            Debug.Assert(storeExpected.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeExpected.Count; ++num2)
              {
                if (partial_allowed)
                    storeExpected[num2].write_partial_as_json(handler);
                else
                    storeExpected[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasTimedOutOnThisTestCase)
          {
            handler.start_pair("TimedOutOnThisTestCase");
            handler.boolean_value(storeTimedOutOnThisTestCase);
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
        if (!(hasInput()))
          {
            return "When parsing the object for %what%, the \"Input\" field was missing.";
          }
        if (!(hasExpected()))
          {
            return "When parsing the object for %what%, the \"Expected\" field was missing.";
          }
        return null;
      }

    public static UploadedChainedTestCaseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedChainedTestCaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedChainedTestCase", ignore_extras);
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
    public static UploadedChainedTestCaseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedChainedTestCaseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedChainedTestCaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedChainedTestCase", ignore_extras);
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
    public static UploadedChainedTestCaseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedChainedTestCaseJSON from_text(string text, bool ignore_extras)
      {
        UploadedChainedTestCaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedChainedTestCase", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UploadedChainedTestCaseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UploadedChainedTestCaseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UploadedChainedTestCaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedChainedTestCase", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UploadedTestCaseInputJSON.HoldingArrayGenerator fieldGeneratorInput;
        private UploadedTestCaseExpectedJSON.HoldingArrayGenerator fieldGeneratorExpected;
        private JSONHoldingBooleanGenerator fieldGeneratorTimedOutOnThisTestCase;
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
            UploadedChainedTestCaseJSON result = new UploadedChainedTestCaseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUploadedChainedTestCaseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UploadedChainedTestCaseJSON result)
          {
            if (fieldGeneratorInput.have_value)
              {
                result.initInput();
                int count = fieldGeneratorInput.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInput(fieldGeneratorInput.value[num]);
                  }
                fieldGeneratorInput.value.Clear();
                fieldGeneratorInput.have_value = false;
              }
            else if ((!(result.hasInput())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Input\" field was missing.");
              }
            if (fieldGeneratorExpected.have_value)
              {
                result.initExpected();
                int count = fieldGeneratorExpected.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendExpected(fieldGeneratorExpected.value[num]);
                  }
                fieldGeneratorExpected.value.Clear();
                fieldGeneratorExpected.have_value = false;
              }
            else if ((!(result.hasExpected())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Expected\" field was missing.");
              }
            if (fieldGeneratorTimedOutOnThisTestCase.have_value)
              {
                result.setTimedOutOnThisTestCase(fieldGeneratorTimedOutOnThisTestCase.value);
                fieldGeneratorTimedOutOnThisTestCase.have_value = false;
              }
          }
        protected abstract void handle_result(UploadedChainedTestCaseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "xpected", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorExpected;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nput", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorInput;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "imedOutOnThisTestCase", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorTimedOutOnThisTestCase;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorInput = new UploadedTestCaseInputJSON.HoldingArrayGenerator("field \"Input\" of the UploadedChainedTestCase class", ignore_extras);
            fieldGeneratorExpected = new UploadedTestCaseExpectedJSON.HoldingArrayGenerator("field \"Expected\" of the UploadedChainedTestCase class", ignore_extras);
            fieldGeneratorTimedOutOnThisTestCase = new JSONHoldingBooleanGenerator("field \"TimedOutOnThisTestCase\" of the UploadedChainedTestCase class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UploadedChainedTestCase class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorInput = new UploadedTestCaseInputJSON.HoldingArrayGenerator("field \"Input\" of the UploadedChainedTestCase class", false);
            fieldGeneratorExpected = new UploadedTestCaseExpectedJSON.HoldingArrayGenerator("field \"Expected\" of the UploadedChainedTestCase class", false);
            fieldGeneratorTimedOutOnThisTestCase = new JSONHoldingBooleanGenerator("field \"TimedOutOnThisTestCase\" of the UploadedChainedTestCase class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UploadedChainedTestCase class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorInput.reset();
            fieldGeneratorExpected.reset();
            fieldGeneratorTimedOutOnThisTestCase.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorInput.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorExpected.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorInput.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorExpected.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UploadedChainedTestCaseJSON  result)
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
        public UploadedChainedTestCaseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UploadedChainedTestCaseJSON  result)
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
    protected virtual void handle_result(List<UploadedChainedTestCaseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UploadedChainedTestCaseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UploadedChainedTestCaseJSON>();
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
    public List<UploadedChainedTestCaseJSON> value;
  };
  };
