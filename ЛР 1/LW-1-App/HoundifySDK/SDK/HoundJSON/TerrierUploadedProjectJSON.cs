/* file "TerrierUploadedProjectJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrierUploadedProjectJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasVersion;
    private JSONValue  storeVersion;
    private bool flagHasFiles;
    private List< TerrierUploadedFileJSON  > storeFiles;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of TerrierUploadedProjectJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONVersion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        setVersion(json_value);
      }


    private void  fromJSONFiles(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Files of TerrierUploadedProjectJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TerrierUploadedFileJSON  > vector_Files1 = new List< TerrierUploadedFileJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TerrierUploadedFileJSON convert_classy = TerrierUploadedFileJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Files1.Add(convert_classy);
          }
        initFiles();
        for (int num1 = 0; num1 < vector_Files1.Count; ++num1)
            appendFiles(vector_Files1[num1]);
        for (int num1 = 0; num1 < vector_Files1.Count; ++num1)
          {
          }
      }


    public TerrierUploadedProjectJSON()
      {
        flagHasName = false;
        flagHasVersion = false;
        flagHasFiles = false;
        storeFiles = new List< TerrierUploadedFileJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public string  getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public bool  hasVersion()
      {
        return flagHasVersion;
      }

    public JSONValue   getVersion()
      {
        Debug.Assert(flagHasVersion);
        return storeVersion;
      }

    public bool  hasFiles()
      {
        return flagHasFiles;
      }

    public int  countOfFiles()
      {
        Debug.Assert(flagHasFiles);
        return storeFiles.Count;
      }

    public TerrierUploadedFileJSON   elementOfFiles(int element_num)
      {
        Debug.Assert(flagHasFiles);
        return storeFiles[element_num];
      }

    public List< TerrierUploadedFileJSON  >  getFiles()
      {
        Debug.Assert(flagHasFiles);
        return storeFiles;
      }


    public virtual int extraTerrierUploadedProjectComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierUploadedProjectComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierUploadedProjectComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierUploadedProjectLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setVersion(JSONValue  new_value)
      {
        if (flagHasVersion)
          {
          }
        flagHasVersion = true;
        storeVersion = new_value;
      }
    public void unsetVersion()
      {
        if (flagHasVersion)
          {
          }
        flagHasVersion = false;
      }
    public void initFiles()
      {
        if (flagHasFiles)
          {
            for (int num1 = 0; num1 < storeFiles.Count; ++num1)
              {
              }
          }
        flagHasFiles = true;
        storeFiles.Clear();
      }
    public void appendFiles(TerrierUploadedFileJSON  to_append)
      {
        if (!flagHasFiles)
          {
            flagHasFiles = true;
            storeFiles.Clear();
          }
        Debug.Assert(flagHasFiles);
        storeFiles.Add(to_append);
      }
    public void unsetFiles()
      {
        if (flagHasFiles)
          {
            for (int num2 = 0; num2 < storeFiles.Count; ++num2)
              {
              }
          }
        flagHasFiles = false;
        storeFiles.Clear();
      }

    public virtual void extraTerrierUploadedProjectAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierUploadedProjectSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierUploadedProjectLookup(key);
        if (old_field == null)
          {
            extraTerrierUploadedProjectAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasVersion)
          {
            handler.start_pair("Version");
            storeVersion.write(handler);
          }
        Debug.Assert(partial_allowed || flagHasFiles);
        if (flagHasFiles)
          {
            handler.start_pair("Files");
            handler.start_array();
            for (int num1 = 0; num1 < storeFiles.Count; ++num1)
              {
                if (partial_allowed)
                    storeFiles[num1].write_partial_as_json(handler);
                else
                    storeFiles[num1].write_as_json(handler);
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
        if (!(hasName()))
          {
            return "When parsing the object for %what%, the \"Name\" field was missing.";
          }
        if (!(hasFiles()))
          {
            return "When parsing the object for %what%, the \"Files\" field was missing.";
          }
        return null;
      }

    public static TerrierUploadedProjectJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadedProjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadedProject", ignore_extras);
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
    public static TerrierUploadedProjectJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadedProjectJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadedProjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadedProject", ignore_extras);
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
    public static TerrierUploadedProjectJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadedProjectJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadedProjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadedProject", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadedProjectJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierUploadedProjectJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadedProjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadedProject", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingValueGenerator fieldGeneratorVersion;
        private TerrierUploadedFileJSON.HoldingArrayGenerator fieldGeneratorFiles;
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
            TerrierUploadedProjectJSON result = new TerrierUploadedProjectJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierUploadedProjectAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierUploadedProjectJSON result)
          {
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            if (fieldGeneratorVersion.have_value)
              {
                result.setVersion(fieldGeneratorVersion.value);
                fieldGeneratorVersion.have_value = false;
              }
            if (fieldGeneratorFiles.have_value)
              {
                result.initFiles();
                int count = fieldGeneratorFiles.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFiles(fieldGeneratorFiles.value[num]);
                  }
                fieldGeneratorFiles.value.Clear();
                fieldGeneratorFiles.have_value = false;
              }
            else if ((!(result.hasFiles())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Files\" field was missing.");
              }
          }
        protected abstract void handle_result(TerrierUploadedProjectJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "iles", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorFiles;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'V':
                    if ((String.Compare(field_name, 1, "ersion", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorVersion;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TerrierUploadedProject class");
            fieldGeneratorVersion = new JSONHoldingValueGenerator("field \"Version\" of the TerrierUploadedProject class");
            fieldGeneratorFiles = new TerrierUploadedFileJSON.HoldingArrayGenerator("field \"Files\" of the TerrierUploadedProject class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierUploadedProject class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the TerrierUploadedProject class");
            fieldGeneratorVersion = new JSONHoldingValueGenerator("field \"Version\" of the TerrierUploadedProject class");
            fieldGeneratorFiles = new TerrierUploadedFileJSON.HoldingArrayGenerator("field \"Files\" of the TerrierUploadedProject class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierUploadedProject class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorVersion.reset();
            fieldGeneratorFiles.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFiles.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFiles.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierUploadedProjectJSON  result)
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
        public TerrierUploadedProjectJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadedProjectJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadedProjectJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadedProjectJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadedProjectJSON>();
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
    public List<TerrierUploadedProjectJSON> value;
  };
  };
