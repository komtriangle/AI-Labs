/* file "UploadedTestsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class UploadedTestsJSON : JSONBase
  {
    private bool flagHasTestFiles;
    private List< UploadedTestFileJSON  > storeTestFiles;
    private bool flagHasInlineTests;
    private UploadedTestInlineTestsConfigurationJSON  storeInlineTests;
    private bool flagHasUploadedTestProject;
    private TerrierUploadedProjectJSON  storeUploadedTestProject;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTestFiles(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TestFiles of UploadedTestsJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field TestFiles of UploadedTestsJSON has too few elements.");
        List< UploadedTestFileJSON  > vector_TestFiles1 = new List< UploadedTestFileJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            UploadedTestFileJSON convert_classy = UploadedTestFileJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_TestFiles1.Add(convert_classy);
          }
        Debug.Assert(vector_TestFiles1.Count >= 1);
        initTestFiles();
        for (int num1 = 0; num1 < vector_TestFiles1.Count; ++num1)
            appendTestFiles(vector_TestFiles1[num1]);
        for (int num1 = 0; num1 < vector_TestFiles1.Count; ++num1)
          {
          }
      }


    private void  fromJSONInlineTests(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedTestInlineTestsConfigurationJSON convert_classy = UploadedTestInlineTestsConfigurationJSON.from_json(json_value, ignore_extras, true);
        setInlineTests(convert_classy);
      }


    private void  fromJSONUploadedTestProject(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TerrierUploadedProjectJSON convert_classy = TerrierUploadedProjectJSON.from_json(json_value, ignore_extras, true);
        setUploadedTestProject(convert_classy);
      }


    public UploadedTestsJSON()
      {
        flagHasTestFiles = false;
        flagHasInlineTests = false;
        flagHasUploadedTestProject = false;
        storeTestFiles = new List< UploadedTestFileJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTestFiles()
      {
        return flagHasTestFiles;
      }

    public int  countOfTestFiles()
      {
        Debug.Assert(flagHasTestFiles);
        return storeTestFiles.Count;
      }

    public UploadedTestFileJSON   elementOfTestFiles(int element_num)
      {
        Debug.Assert(flagHasTestFiles);
        return storeTestFiles[element_num];
      }

    public List< UploadedTestFileJSON  >  getTestFiles()
      {
        Debug.Assert(flagHasTestFiles);
        return storeTestFiles;
      }

    public bool  hasInlineTests()
      {
        return flagHasInlineTests;
      }

    public UploadedTestInlineTestsConfigurationJSON   getInlineTests()
      {
        Debug.Assert(flagHasInlineTests);
        return storeInlineTests;
      }

    public bool  hasUploadedTestProject()
      {
        return flagHasUploadedTestProject;
      }

    public TerrierUploadedProjectJSON   getUploadedTestProject()
      {
        Debug.Assert(flagHasUploadedTestProject);
        return storeUploadedTestProject;
      }


    public virtual int extraUploadedTestsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUploadedTestsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUploadedTestsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUploadedTestsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initTestFiles()
      {
        if (flagHasTestFiles)
          {
            for (int num1 = 0; num1 < storeTestFiles.Count; ++num1)
              {
              }
          }
        flagHasTestFiles = true;
        storeTestFiles.Clear();
      }
    public void appendTestFiles(UploadedTestFileJSON  to_append)
      {
        if (!flagHasTestFiles)
          {
            flagHasTestFiles = true;
            storeTestFiles.Clear();
          }
        Debug.Assert(flagHasTestFiles);
        storeTestFiles.Add(to_append);
      }
    public void unsetTestFiles()
      {
        if (flagHasTestFiles)
          {
            for (int num2 = 0; num2 < storeTestFiles.Count; ++num2)
              {
              }
          }
        flagHasTestFiles = false;
        storeTestFiles.Clear();
      }
    public void setInlineTests(UploadedTestInlineTestsConfigurationJSON  new_value)
      {
        if (flagHasInlineTests)
          {
          }
        flagHasInlineTests = true;
        storeInlineTests = new_value;
      }
    public void unsetInlineTests()
      {
        if (flagHasInlineTests)
          {
          }
        flagHasInlineTests = false;
      }
    public void setUploadedTestProject(TerrierUploadedProjectJSON  new_value)
      {
        if (flagHasUploadedTestProject)
          {
          }
        flagHasUploadedTestProject = true;
        storeUploadedTestProject = new_value;
      }
    public void unsetUploadedTestProject()
      {
        if (flagHasUploadedTestProject)
          {
          }
        flagHasUploadedTestProject = false;
      }

    public virtual void extraUploadedTestsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUploadedTestsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUploadedTestsLookup(key);
        if (old_field == null)
          {
            extraUploadedTestsAppendPair(key, new_component);
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
        if (flagHasTestFiles)
          {
            handler.start_pair("TestFiles");
            Debug.Assert(storeTestFiles.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeTestFiles.Count; ++num1)
              {
                if (partial_allowed)
                    storeTestFiles[num1].write_partial_as_json(handler);
                else
                    storeTestFiles[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasInlineTests)
          {
            handler.start_pair("InlineTests");
            if (partial_allowed)
                storeInlineTests.write_partial_as_json(handler);
            else
                storeInlineTests.write_as_json(handler);
          }
        if (flagHasUploadedTestProject)
          {
            handler.start_pair("UploadedTestProject");
            if (partial_allowed)
                storeUploadedTestProject.write_partial_as_json(handler);
            else
                storeUploadedTestProject.write_as_json(handler);
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

    public static UploadedTestsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedTestsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTests", ignore_extras);
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
    public static UploadedTestsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedTestsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UploadedTestsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTests", ignore_extras);
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
    public static UploadedTestsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static UploadedTestsJSON from_text(string text, bool ignore_extras)
      {
        UploadedTestsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTests", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UploadedTestsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static UploadedTestsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UploadedTestsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UploadedTests", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private UploadedTestFileJSON.HoldingArrayGenerator fieldGeneratorTestFiles;
        private UploadedTestInlineTestsConfigurationJSON.HoldingGenerator fieldGeneratorInlineTests;
        private TerrierUploadedProjectJSON.HoldingGenerator fieldGeneratorUploadedTestProject;
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
            UploadedTestsJSON result = new UploadedTestsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUploadedTestsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(UploadedTestsJSON result)
          {
            if (fieldGeneratorTestFiles.have_value)
              {
                result.initTestFiles();
                int count = fieldGeneratorTestFiles.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTestFiles(fieldGeneratorTestFiles.value[num]);
                  }
                fieldGeneratorTestFiles.value.Clear();
                fieldGeneratorTestFiles.have_value = false;
              }
            if (fieldGeneratorInlineTests.have_value)
              {
                result.setInlineTests(fieldGeneratorInlineTests.value);
                fieldGeneratorInlineTests.have_value = false;
              }
            if (fieldGeneratorUploadedTestProject.have_value)
              {
                result.setUploadedTestProject(fieldGeneratorUploadedTestProject.value);
                fieldGeneratorUploadedTestProject.have_value = false;
              }
          }
        protected abstract void handle_result(UploadedTestsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "nlineTests", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorInlineTests;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "estFiles", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorTestFiles;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "ploadedTestProject", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorUploadedTestProject;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTestFiles = new UploadedTestFileJSON.HoldingArrayGenerator("field \"TestFiles\" of the UploadedTests class", ignore_extras);
            fieldGeneratorInlineTests = new UploadedTestInlineTestsConfigurationJSON.HoldingGenerator("field \"InlineTests\" of the UploadedTests class", ignore_extras);
            fieldGeneratorUploadedTestProject = new TerrierUploadedProjectJSON.HoldingGenerator("field \"UploadedTestProject\" of the UploadedTests class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UploadedTests class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTestFiles = new UploadedTestFileJSON.HoldingArrayGenerator("field \"TestFiles\" of the UploadedTests class", false);
            fieldGeneratorInlineTests = new UploadedTestInlineTestsConfigurationJSON.HoldingGenerator("field \"InlineTests\" of the UploadedTests class", false);
            fieldGeneratorUploadedTestProject = new TerrierUploadedProjectJSON.HoldingGenerator("field \"UploadedTestProject\" of the UploadedTests class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UploadedTests class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTestFiles.reset();
            fieldGeneratorInlineTests.reset();
            fieldGeneratorUploadedTestProject.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTestFiles.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorInlineTests.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUploadedTestProject.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTestFiles.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorInlineTests.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUploadedTestProject.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(UploadedTestsJSON  result)
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
        public UploadedTestsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UploadedTestsJSON  result)
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
    protected virtual void handle_result(List<UploadedTestsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UploadedTestsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UploadedTestsJSON>();
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
    public List<UploadedTestsJSON> value;
  };
  };
