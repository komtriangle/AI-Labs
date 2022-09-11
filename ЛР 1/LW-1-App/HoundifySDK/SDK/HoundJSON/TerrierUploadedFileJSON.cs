/* file "TerrierUploadedFileJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrierUploadedFileJSON : JSONBase
  {
    private bool flagHasPath;
    private TerrierUploadedFilePathJSON  storePath;
    private bool flagHasContent;
    private string storeContent;
    private bool flagHasCodeLanguage;
    private UploadedCodeFunctionLanguageJSON  storeCodeLanguage;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPath(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TerrierUploadedFilePathJSON convert_classy = TerrierUploadedFilePathJSON.from_json(json_value, ignore_extras, true);
        setPath(convert_classy);
      }


    private void  fromJSONContent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Content of TerrierUploadedFileJSON is not a string.");
        setContent(json_string.getData());
      }


    private void  fromJSONCodeLanguage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeFunctionLanguageJSON convert_classy = UploadedCodeFunctionLanguageJSON.from_json(json_value, ignore_extras, true);
        setCodeLanguage(convert_classy);
      }


    public TerrierUploadedFileJSON()
      {
        flagHasPath = false;
        flagHasContent = false;
        flagHasCodeLanguage = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPath()
      {
        return flagHasPath;
      }

    public TerrierUploadedFilePathJSON   getPath()
      {
        Debug.Assert(flagHasPath);
        return storePath;
      }

    public string  getPathValue()
      {
        return getPath().getValue();
      }

    public bool  hasContent()
      {
        return flagHasContent;
      }

    public string  getContent()
      {
        Debug.Assert(flagHasContent);
        return storeContent;
      }

    public bool  hasCodeLanguage()
      {
        return flagHasCodeLanguage;
      }

    public UploadedCodeFunctionLanguageJSON   getCodeLanguage()
      {
        Debug.Assert(flagHasCodeLanguage);
        return storeCodeLanguage;
      }

    public UploadedCodeFunctionLanguageJSON.TypeValue  getCodeLanguageValue()
      {
        return getCodeLanguage().getValue();
      }

    public string  getCodeLanguageAsString()
      {
        return getCodeLanguage().getValueAsString();
      }


    public virtual int extraTerrierUploadedFileComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierUploadedFileComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierUploadedFileComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierUploadedFileLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPath(TerrierUploadedFilePathJSON  new_value)
      {
        if (flagHasPath)
          {
          }
        flagHasPath = true;
        storePath = new_value;
      }
    public void setPath(string new_value)
      {
        setPath(new TerrierUploadedFilePathJSON(new_value));
      }
    public void unsetPath()
      {
        if (flagHasPath)
          {
          }
        flagHasPath = false;
      }
    public void setContent(string new_value)
      {
        flagHasContent = true;
        storeContent = new_value;
      }
    public void unsetContent()
      {
        flagHasContent = false;
      }
    public void setCodeLanguage(UploadedCodeFunctionLanguageJSON  new_value)
      {
        if (flagHasCodeLanguage)
          {
          }
        flagHasCodeLanguage = true;
        storeCodeLanguage = new_value;
      }
    public void setCodeLanguage(UploadedCodeFunctionLanguageJSON.TypeValue new_value)
      {
        setCodeLanguage(new UploadedCodeFunctionLanguageJSON(new_value));
      }
    public void setCodeLanguage(string chars)
      {
        UploadedCodeFunctionLanguageJSON.TypeValueKnownValues known = UploadedCodeFunctionLanguageJSON.stringToValue(chars);
        UploadedCodeFunctionLanguageJSON.TypeValue new_value = new UploadedCodeFunctionLanguageJSON.TypeValue();
        if (known == UploadedCodeFunctionLanguageJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setCodeLanguage(new_value);
      }
    public void unsetCodeLanguage()
      {
        if (flagHasCodeLanguage)
          {
          }
        flagHasCodeLanguage = false;
      }

    public virtual void extraTerrierUploadedFileAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierUploadedFileSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierUploadedFileLookup(key);
        if (old_field == null)
          {
            extraTerrierUploadedFileAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPath);
        if (flagHasPath)
          {
            handler.start_pair("Path");
            if (partial_allowed)
                storePath.write_partial_as_json(handler);
            else
                storePath.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasContent);
        if (flagHasContent)
          {
            handler.start_pair("Content");
            handler.string_value(storeContent);
          }
        Debug.Assert(partial_allowed || flagHasCodeLanguage);
        if (flagHasCodeLanguage)
          {
            handler.start_pair("CodeLanguage");
            if (partial_allowed)
                storeCodeLanguage.write_partial_as_json(handler);
            else
                storeCodeLanguage.write_as_json(handler);
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
        if (!(hasPath()))
          {
            return "When parsing the object for %what%, the \"Path\" field was missing.";
          }
        if (!(hasContent()))
          {
            return "When parsing the object for %what%, the \"Content\" field was missing.";
          }
        if (!(hasCodeLanguage()))
          {
            return "When parsing the object for %what%, the \"CodeLanguage\" field was missing.";
          }
        return null;
      }

    public static TerrierUploadedFileJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadedFileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadedFile", ignore_extras);
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
    public static TerrierUploadedFileJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadedFileJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadedFileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadedFile", ignore_extras);
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
    public static TerrierUploadedFileJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadedFileJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadedFileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadedFile", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadedFileJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierUploadedFileJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadedFileJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadedFile", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TerrierUploadedFilePathJSON.HoldingGenerator fieldGeneratorPath;
        private JSONHoldingStringGenerator fieldGeneratorContent;
        private UploadedCodeFunctionLanguageJSON.HoldingGenerator fieldGeneratorCodeLanguage;
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
            TerrierUploadedFileJSON result = new TerrierUploadedFileJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierUploadedFileAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierUploadedFileJSON result)
          {
            if (fieldGeneratorPath.have_value)
              {
                result.setPath(fieldGeneratorPath.value);
                fieldGeneratorPath.have_value = false;
              }
            else if ((!(result.hasPath())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Path\" field was missing.");
              }
            if (fieldGeneratorContent.have_value)
              {
                result.setContent(fieldGeneratorContent.value);
                fieldGeneratorContent.have_value = false;
              }
            else if ((!(result.hasContent())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Content\" field was missing.");
              }
            if (fieldGeneratorCodeLanguage.have_value)
              {
                result.setCodeLanguage(fieldGeneratorCodeLanguage.value);
                fieldGeneratorCodeLanguage.have_value = false;
              }
            else if ((!(result.hasCodeLanguage())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CodeLanguage\" field was missing.");
              }
          }
        protected abstract void handle_result(TerrierUploadedFileJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "o", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'd':
                                if ((String.Compare(field_name, 3, "eLanguage", 0, 9, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorCodeLanguage;
                                break;
                            case 'n':
                                if ((String.Compare(field_name, 3, "tent", 0, 4, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorContent;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ath", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorPath;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPath = new TerrierUploadedFilePathJSON.HoldingGenerator("field \"Path\" of the TerrierUploadedFile class", ignore_extras);
            fieldGeneratorContent = new JSONHoldingStringGenerator("field \"Content\" of the TerrierUploadedFile class");
            fieldGeneratorCodeLanguage = new UploadedCodeFunctionLanguageJSON.HoldingGenerator("field \"CodeLanguage\" of the TerrierUploadedFile class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierUploadedFile class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPath = new TerrierUploadedFilePathJSON.HoldingGenerator("field \"Path\" of the TerrierUploadedFile class", false);
            fieldGeneratorContent = new JSONHoldingStringGenerator("field \"Content\" of the TerrierUploadedFile class");
            fieldGeneratorCodeLanguage = new UploadedCodeFunctionLanguageJSON.HoldingGenerator("field \"CodeLanguage\" of the TerrierUploadedFile class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierUploadedFile class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPath.reset();
            fieldGeneratorContent.reset();
            fieldGeneratorCodeLanguage.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPath.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCodeLanguage.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPath.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCodeLanguage.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierUploadedFileJSON  result)
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
        public TerrierUploadedFileJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadedFileJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadedFileJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadedFileJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadedFileJSON>();
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
    public List<TerrierUploadedFileJSON> value;
  };
  };
