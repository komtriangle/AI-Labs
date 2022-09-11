/* file "UploadedTestFileJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UploadedTestFileJSON : JSONBase
  {
    private bool flagHasBlock;
    private string storeBlock;
    private bool flagHasRequiredDomains;
    private List< string > storeRequiredDomains;
    private bool flagHasSetupQueries;
    private UploadedChainedTestCaseJSON  storeSetupQueries;
    private bool flagHasTestCases;
    private List< UploadedChainedTestCaseJSON  > storeTestCases;
    private bool flagHasMetadata;
    private UploadedTestFileMetadataJSON  storeMetadata;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONBlock(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Block of UploadedTestFileJSON is not a string.");
        setBlock(json_string.getData());
      }


    private void  fromJSONRequiredDomains(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RequiredDomains of UploadedTestFileJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field RequiredDomains of UploadedTestFileJSON has too few elements.");
        List< string > vector_RequiredDomains1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field RequiredDomains of UploadedTestFileJSON is not a string.");
            vector_RequiredDomains1.Add(json_string.getData());
          }
        Debug.Assert(vector_RequiredDomains1.Count >= 1);
        initRequiredDomains();
        for (int num1 = 0; num1 < vector_RequiredDomains1.Count; ++num1)
            appendRequiredDomains(vector_RequiredDomains1[num1]);
        for (int num1 = 0; num1 < vector_RequiredDomains1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSetupQueries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedChainedTestCaseJSON convert_classy = UploadedChainedTestCaseJSON.from_json(json_value, ignore_extras, true);
        setSetupQueries(convert_classy);
      }


    private void  fromJSONTestCases(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TestCases of UploadedTestFileJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< UploadedChainedTestCaseJSON  > vector_TestCases1 = new List< UploadedChainedTestCaseJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UploadedChainedTestCaseJSON convert_classy = UploadedChainedTestCaseJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_TestCases1.Add(convert_classy);
          }
        initTestCases();
        for (int num2 = 0; num2 < vector_TestCases1.Count; ++num2)
            appendTestCases(vector_TestCases1[num2]);
        for (int num1 = 0; num1 < vector_TestCases1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMetadata(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedTestFileMetadataJSON convert_classy = UploadedTestFileMetadataJSON.from_json(json_value, ignore_extras, true);
        setMetadata(convert_classy);
      }


    public UploadedTestFileJSON()
      {
        flagHasBlock = false;
        flagHasRequiredDomains = false;
        flagHasSetupQueries = false;
        flagHasTestCases = false;
        flagHasMetadata = false;
        storeRequiredDomains = new List< string >();
        storeTestCases = new List< UploadedChainedTestCaseJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasBlock()
      {
        return flagHasBlock;
      }

    public string  getBlock()
      {
        Debug.Assert(flagHasBlock);
        return storeBlock;
      }

    public bool  hasRequiredDomains()
      {
        return flagHasRequiredDomains;
      }

    public int  countOfRequiredDomains()
      {
        Debug.Assert(flagHasRequiredDomains);
        return storeRequiredDomains.Count;
      }

    public string  elementOfRequiredDomains(int element_num)
      {
        Debug.Assert(flagHasRequiredDomains);
        return storeRequiredDomains[element_num];
      }

    public List< string >  getRequiredDomains()
      {
        Debug.Assert(flagHasRequiredDomains);
        return storeRequiredDomains;
      }

    public bool  hasSetupQueries()
      {
        return flagHasSetupQueries;
      }

    public UploadedChainedTestCaseJSON   getSetupQueries()
      {
        Debug.Assert(flagHasSetupQueries);
        return storeSetupQueries;
      }

    public bool  hasTestCases()
      {
        return flagHasTestCases;
      }

    public int  countOfTestCases()
      {
        Debug.Assert(flagHasTestCases);
        return storeTestCases.Count;
      }

    public UploadedChainedTestCaseJSON   elementOfTestCases(int element_num)
      {
        Debug.Assert(flagHasTestCases);
        return storeTestCases[element_num];
      }

    public List< UploadedChainedTestCaseJSON  >  getTestCases()
      {
        Debug.Assert(flagHasTestCases);
        return storeTestCases;
      }

    public bool  hasMetadata()
      {
        return flagHasMetadata;
      }

    public UploadedTestFileMetadataJSON   getMetadata()
      {
        Debug.Assert(flagHasMetadata);
        return storeMetadata;
      }


    public virtual int extraUploadedTestFileComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUploadedTestFileComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUploadedTestFileComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUploadedTestFileLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setBlock(string new_value)
      {
        flagHasBlock = true;
        storeBlock = new_value;
      }
    public void unsetBlock()
      {
        flagHasBlock = false;
      }
    public void initRequiredDomains()
      {
        flagHasRequiredDomains = true;
        storeRequiredDomains.Clear();
      }
    public void appendRequiredDomains(string to_append)
      {
        if (!flagHasRequiredDomains)
          {
            flagHasRequiredDomains = true;
            storeRequiredDomains.Clear();
          }
        Debug.Assert(flagHasRequiredDomains);
        storeRequiredDomains.Add(to_append);
      }
    public void unsetRequiredDomains()
      {
        flagHasRequiredDomains = false;
        storeRequiredDomains.Clear();
      }
    public void setSetupQueries(UploadedChainedTestCaseJSON  new_value)
      {
        if (flagHasSetupQueries)
          {
          }
        flagHasSetupQueries = true;
        storeSetupQueries = new_value;
      }
    public void unsetSetupQueries()
      {
        if (flagHasSetupQueries)
          {
          }
        flagHasSetupQueries = false;
      }
    public void initTestCases()
      {
        if (flagHasTestCases)
          {
            for (int num1 = 0; num1 < storeTestCases.Count; ++num1)
              {
              }
          }
        flagHasTestCases = true;
        storeTestCases.Clear();
      }
    public void appendTestCases(UploadedChainedTestCaseJSON  to_append)
      {
        if (!flagHasTestCases)
          {
            flagHasTestCases = true;
            storeTestCases.Clear();
          }
        Debug.Assert(flagHasTestCases);
        storeTestCases.Add(to_append);
      }
    public void unsetTestCases()
      {
        if (flagHasTestCases)
          {
            for (int num2 = 0; num2 < storeTestCases.Count; ++num2)
              {
              }
          }
        flagHasTestCases = false;
        storeTestCases.Clear();
      }
    public void setMetadata(UploadedTestFileMetadataJSON  new_value)
      {
        if (flagHasMetadata)
          {
          }
        flagHasMetadata = true;
        storeMetadata = new_value;
      }
    public void unsetMetadata()
      {
        if (flagHasMetadata)
          {
          }
        flagHasMetadata = false;
      }

    public virtual void extraUploadedTestFileAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUploadedTestFileSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUploadedTestFileLookup(key);
        if (old_field == null)
          {
            extraUploadedTestFileAppendPair(key, new_component);
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
        if (flagHasBlock)
          {
            handler.start_pair("Block");
            handler.string_value(storeBlock);
          }
        if (flagHasRequiredDomains)
          {
            handler.start_pair("RequiredDomains");
            Debug.Assert(storeRequiredDomains.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeRequiredDomains.Count; ++num1)
              {
                handler.string_value(storeRequiredDomains[num1]);
              }
            handler.finish_array();
          }
        if (flagHasSetupQueries)
          {
            handler.start_pair("SetupQueries");
            if (partial_allowed)
                storeSetupQueries.write_partial_as_json(handler);
            else
                storeSetupQueries.write_as_json(handler);
          }
        if (flagHasTestCases)
          {
            handler.start_pair("TestCases");
            handler.start_array();
            for (int num2 = 0; num2 < storeTestCases.Count; ++num2)
              {
                if (partial_allowed)
                    storeTestCases[num2].write_partial_as_json(handler);
                else
                    storeTestCases[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasMetadata)
          {
            handler.start_pair("Metadata");
            if (partial_allowed)
                storeMetadata.write_partial_as_json(handler);
            else
                storeMetadata.write_as_json(handler);
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

    public static UploadedTestFileJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedTestFileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestFile", ignore_extras);
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
    public static UploadedTestFileJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedTestFileJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedTestFileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestFile", ignore_extras);
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
    public static UploadedTestFileJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedTestFileJSON from_text(string text, bool ignore_extras)
      {
        UploadedTestFileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestFile", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UploadedTestFileJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UploadedTestFileJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UploadedTestFileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTestFile", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorBlock;
        private JSONHoldingStringArrayGenerator fieldGeneratorRequiredDomains;
        private UploadedChainedTestCaseJSON.HoldingGenerator fieldGeneratorSetupQueries;
        private UploadedChainedTestCaseJSON.HoldingArrayGenerator fieldGeneratorTestCases;
        private UploadedTestFileMetadataJSON.HoldingGenerator fieldGeneratorMetadata;
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
            UploadedTestFileJSON result = new UploadedTestFileJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUploadedTestFileAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UploadedTestFileJSON result)
          {
            if (fieldGeneratorBlock.have_value)
              {
                result.setBlock(fieldGeneratorBlock.value);
                fieldGeneratorBlock.have_value = false;
              }
            if (fieldGeneratorRequiredDomains.have_value)
              {
                result.initRequiredDomains();
                int count = fieldGeneratorRequiredDomains.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRequiredDomains(fieldGeneratorRequiredDomains.value[num]);
                  }
                fieldGeneratorRequiredDomains.value.Clear();
                fieldGeneratorRequiredDomains.have_value = false;
              }
            if (fieldGeneratorSetupQueries.have_value)
              {
                result.setSetupQueries(fieldGeneratorSetupQueries.value);
                fieldGeneratorSetupQueries.have_value = false;
              }
            if (fieldGeneratorTestCases.have_value)
              {
                result.initTestCases();
                int count = fieldGeneratorTestCases.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTestCases(fieldGeneratorTestCases.value[num]);
                  }
                fieldGeneratorTestCases.value.Clear();
                fieldGeneratorTestCases.have_value = false;
              }
            if (fieldGeneratorMetadata.have_value)
              {
                result.setMetadata(fieldGeneratorMetadata.value);
                fieldGeneratorMetadata.have_value = false;
              }
          }
        protected abstract void handle_result(UploadedTestFileJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'B':
                    if ((String.Compare(field_name, 1, "lock", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorBlock;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "etadata", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorMetadata;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equiredDomains", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorRequiredDomains;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "etupQueries", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorSetupQueries;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "estCases", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorTestCases;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorBlock = new JSONHoldingStringGenerator("field \"Block\" of the UploadedTestFile class");
            fieldGeneratorRequiredDomains = new JSONHoldingStringArrayGenerator("field \"RequiredDomains\" of the UploadedTestFile class");
            fieldGeneratorSetupQueries = new UploadedChainedTestCaseJSON.HoldingGenerator("field \"SetupQueries\" of the UploadedTestFile class", ignore_extras);
            fieldGeneratorTestCases = new UploadedChainedTestCaseJSON.HoldingArrayGenerator("field \"TestCases\" of the UploadedTestFile class", ignore_extras);
            fieldGeneratorMetadata = new UploadedTestFileMetadataJSON.HoldingGenerator("field \"Metadata\" of the UploadedTestFile class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UploadedTestFile class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorBlock = new JSONHoldingStringGenerator("field \"Block\" of the UploadedTestFile class");
            fieldGeneratorRequiredDomains = new JSONHoldingStringArrayGenerator("field \"RequiredDomains\" of the UploadedTestFile class");
            fieldGeneratorSetupQueries = new UploadedChainedTestCaseJSON.HoldingGenerator("field \"SetupQueries\" of the UploadedTestFile class", false);
            fieldGeneratorTestCases = new UploadedChainedTestCaseJSON.HoldingArrayGenerator("field \"TestCases\" of the UploadedTestFile class", false);
            fieldGeneratorMetadata = new UploadedTestFileMetadataJSON.HoldingGenerator("field \"Metadata\" of the UploadedTestFile class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UploadedTestFile class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorBlock.reset();
            fieldGeneratorRequiredDomains.reset();
            fieldGeneratorSetupQueries.reset();
            fieldGeneratorTestCases.reset();
            fieldGeneratorMetadata.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSetupQueries.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTestCases.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMetadata.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSetupQueries.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTestCases.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMetadata.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UploadedTestFileJSON  result)
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
        public UploadedTestFileJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UploadedTestFileJSON  result)
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
    protected virtual void handle_result(List<UploadedTestFileJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UploadedTestFileJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UploadedTestFileJSON>();
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
    public List<UploadedTestFileJSON> value;
  };
  };
