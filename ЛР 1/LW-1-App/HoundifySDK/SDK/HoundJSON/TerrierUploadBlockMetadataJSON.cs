/* file "TerrierUploadBlockMetadataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrierUploadBlockMetadataJSON : JSONBase
  {
    private bool flagHasName;
    private TerrierUploadBlockNameJSON  storeName;
    private bool flagHasSummary;
    private string storeSummary;
    private bool flagHasDescription;
    private string storeDescription;
    private bool flagHasAuthors;
    private List< string > storeAuthors;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TerrierUploadBlockNameJSON convert_classy = TerrierUploadBlockNameJSON.from_json(json_value, ignore_extras, true);
        setName(convert_classy);
      }


    private void  fromJSONSummary(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Summary of TerrierUploadBlockMetadataJSON is not a string.");
        setSummary(json_string.getData());
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Description of TerrierUploadBlockMetadataJSON is not a string.");
        setDescription(json_string.getData());
      }


    private void  fromJSONAuthors(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Authors of TerrierUploadBlockMetadataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Authors1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Authors of TerrierUploadBlockMetadataJSON is not a string.");
            vector_Authors1.Add(json_string.getData());
          }
        initAuthors();
        for (int num1 = 0; num1 < vector_Authors1.Count; ++num1)
            appendAuthors(vector_Authors1[num1]);
        for (int num1 = 0; num1 < vector_Authors1.Count; ++num1)
          {
          }
      }


    public TerrierUploadBlockMetadataJSON()
      {
        flagHasName = false;
        flagHasSummary = false;
        flagHasDescription = false;
        flagHasAuthors = false;
        storeAuthors = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasName()
      {
        return flagHasName;
      }

    public TerrierUploadBlockNameJSON   getName()
      {
        Debug.Assert(flagHasName);
        return storeName;
      }

    public string  getNameValue()
      {
        return getName().getValue();
      }

    public bool  hasSummary()
      {
        return flagHasSummary;
      }

    public string  getSummary()
      {
        Debug.Assert(flagHasSummary);
        return storeSummary;
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

    public bool  hasAuthors()
      {
        return flagHasAuthors;
      }

    public int  countOfAuthors()
      {
        Debug.Assert(flagHasAuthors);
        return storeAuthors.Count;
      }

    public string  elementOfAuthors(int element_num)
      {
        Debug.Assert(flagHasAuthors);
        return storeAuthors[element_num];
      }

    public List< string >  getAuthors()
      {
        Debug.Assert(flagHasAuthors);
        return storeAuthors;
      }


    public virtual int extraTerrierUploadBlockMetadataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierUploadBlockMetadataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierUploadBlockMetadataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierUploadBlockMetadataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setName(TerrierUploadBlockNameJSON  new_value)
      {
        if (flagHasName)
          {
          }
        flagHasName = true;
        storeName = new_value;
      }
    public void setName(string new_value)
      {
        setName(new TerrierUploadBlockNameJSON(new_value));
      }
    public void unsetName()
      {
        if (flagHasName)
          {
          }
        flagHasName = false;
      }
    public void setSummary(string new_value)
      {
        flagHasSummary = true;
        storeSummary = new_value;
      }
    public void unsetSummary()
      {
        flagHasSummary = false;
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
    public void initAuthors()
      {
        flagHasAuthors = true;
        storeAuthors.Clear();
      }
    public void appendAuthors(string to_append)
      {
        if (!flagHasAuthors)
          {
            flagHasAuthors = true;
            storeAuthors.Clear();
          }
        Debug.Assert(flagHasAuthors);
        storeAuthors.Add(to_append);
      }
    public void unsetAuthors()
      {
        flagHasAuthors = false;
        storeAuthors.Clear();
      }

    public virtual void extraTerrierUploadBlockMetadataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierUploadBlockMetadataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierUploadBlockMetadataLookup(key);
        if (old_field == null)
          {
            extraTerrierUploadBlockMetadataAppendPair(key, new_component);
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
            if (partial_allowed)
                storeName.write_partial_as_json(handler);
            else
                storeName.write_as_json(handler);
          }
        if (flagHasSummary)
          {
            handler.start_pair("Summary");
            handler.string_value(storeSummary);
          }
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            handler.string_value(storeDescription);
          }
        if (flagHasAuthors)
          {
            handler.start_pair("Authors");
            handler.start_array();
            for (int num1 = 0; num1 < storeAuthors.Count; ++num1)
              {
                handler.string_value(storeAuthors[num1]);
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
        return null;
      }

    public static TerrierUploadBlockMetadataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadBlockMetadataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlockMetadata", ignore_extras);
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
    public static TerrierUploadBlockMetadataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadBlockMetadataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadBlockMetadataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlockMetadata", ignore_extras);
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
    public static TerrierUploadBlockMetadataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadBlockMetadataJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadBlockMetadataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlockMetadata", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadBlockMetadataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierUploadBlockMetadataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadBlockMetadataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadBlockMetadata", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TerrierUploadBlockNameJSON.HoldingGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorSummary;
        private JSONHoldingStringGenerator fieldGeneratorDescription;
        private JSONHoldingStringArrayGenerator fieldGeneratorAuthors;
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
            TerrierUploadBlockMetadataJSON result = new TerrierUploadBlockMetadataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierUploadBlockMetadataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierUploadBlockMetadataJSON result)
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
            if (fieldGeneratorSummary.have_value)
              {
                result.setSummary(fieldGeneratorSummary.value);
                fieldGeneratorSummary.have_value = false;
              }
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            if (fieldGeneratorAuthors.have_value)
              {
                result.initAuthors();
                int count = fieldGeneratorAuthors.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAuthors(fieldGeneratorAuthors.value[num]);
                  }
                fieldGeneratorAuthors.value.Clear();
                fieldGeneratorAuthors.have_value = false;
              }
          }
        protected abstract void handle_result(TerrierUploadBlockMetadataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "uthors", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorAuthors;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDescription;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ummary", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorSummary;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new TerrierUploadBlockNameJSON.HoldingGenerator("field \"Name\" of the TerrierUploadBlockMetadata class", ignore_extras);
            fieldGeneratorSummary = new JSONHoldingStringGenerator("field \"Summary\" of the TerrierUploadBlockMetadata class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the TerrierUploadBlockMetadata class");
            fieldGeneratorAuthors = new JSONHoldingStringArrayGenerator("field \"Authors\" of the TerrierUploadBlockMetadata class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierUploadBlockMetadata class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new TerrierUploadBlockNameJSON.HoldingGenerator("field \"Name\" of the TerrierUploadBlockMetadata class", false);
            fieldGeneratorSummary = new JSONHoldingStringGenerator("field \"Summary\" of the TerrierUploadBlockMetadata class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the TerrierUploadBlockMetadata class");
            fieldGeneratorAuthors = new JSONHoldingStringArrayGenerator("field \"Authors\" of the TerrierUploadBlockMetadata class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierUploadBlockMetadata class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorSummary.reset();
            fieldGeneratorDescription.reset();
            fieldGeneratorAuthors.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorName.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorName.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierUploadBlockMetadataJSON  result)
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
        public TerrierUploadBlockMetadataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadBlockMetadataJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadBlockMetadataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadBlockMetadataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadBlockMetadataJSON>();
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
    public List<TerrierUploadBlockMetadataJSON> value;
  };
  };
