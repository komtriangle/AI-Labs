/* file "TerrierTableUploadTableJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrierTableUploadTableJSON : JSONBase
  {
    private bool flagHasName;
    private TerrierUploadBlockNameJSON  storeName;
    private bool flagHasRows;
    private List< TerrierTableUploadRowJSON  > storeRows;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TerrierUploadBlockNameJSON convert_classy = TerrierUploadBlockNameJSON.from_json(json_value, ignore_extras, true);
        setName(convert_classy);
      }


    private void  fromJSONRows(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Rows of TerrierTableUploadTableJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TerrierTableUploadRowJSON  > vector_Rows1 = new List< TerrierTableUploadRowJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TerrierTableUploadRowJSON convert_classy = TerrierTableUploadRowJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Rows1.Add(convert_classy);
          }
        initRows();
        for (int num1 = 0; num1 < vector_Rows1.Count; ++num1)
            appendRows(vector_Rows1[num1]);
        for (int num1 = 0; num1 < vector_Rows1.Count; ++num1)
          {
          }
      }


    public TerrierTableUploadTableJSON()
      {
        flagHasName = false;
        flagHasRows = false;
        storeRows = new List< TerrierTableUploadRowJSON  >();
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

    public bool  hasRows()
      {
        return flagHasRows;
      }

    public int  countOfRows()
      {
        Debug.Assert(flagHasRows);
        return storeRows.Count;
      }

    public TerrierTableUploadRowJSON   elementOfRows(int element_num)
      {
        Debug.Assert(flagHasRows);
        return storeRows[element_num];
      }

    public List< TerrierTableUploadRowJSON  >  getRows()
      {
        Debug.Assert(flagHasRows);
        return storeRows;
      }


    public virtual int extraTerrierTableUploadTableComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierTableUploadTableComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierTableUploadTableComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierTableUploadTableLookup(string field_name)
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
    public void initRows()
      {
        if (flagHasRows)
          {
            for (int num1 = 0; num1 < storeRows.Count; ++num1)
              {
              }
          }
        flagHasRows = true;
        storeRows.Clear();
      }
    public void appendRows(TerrierTableUploadRowJSON  to_append)
      {
        if (!flagHasRows)
          {
            flagHasRows = true;
            storeRows.Clear();
          }
        Debug.Assert(flagHasRows);
        storeRows.Add(to_append);
      }
    public void unsetRows()
      {
        if (flagHasRows)
          {
            for (int num2 = 0; num2 < storeRows.Count; ++num2)
              {
              }
          }
        flagHasRows = false;
        storeRows.Clear();
      }

    public virtual void extraTerrierTableUploadTableAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierTableUploadTableSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierTableUploadTableLookup(key);
        if (old_field == null)
          {
            extraTerrierTableUploadTableAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasRows);
        if (flagHasRows)
          {
            handler.start_pair("Rows");
            handler.start_array();
            for (int num1 = 0; num1 < storeRows.Count; ++num1)
              {
                if (partial_allowed)
                    storeRows[num1].write_partial_as_json(handler);
                else
                    storeRows[num1].write_as_json(handler);
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
        if (!(hasRows()))
          {
            return "When parsing the object for %what%, the \"Rows\" field was missing.";
          }
        return null;
      }

    public static TerrierTableUploadTableJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierTableUploadTableJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierTableUploadTable", ignore_extras);
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
    public static TerrierTableUploadTableJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierTableUploadTableJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierTableUploadTableJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierTableUploadTable", ignore_extras);
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
    public static TerrierTableUploadTableJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierTableUploadTableJSON from_text(string text, bool ignore_extras)
      {
        TerrierTableUploadTableJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierTableUploadTable", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierTableUploadTableJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierTableUploadTableJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierTableUploadTableJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierTableUploadTable", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TerrierUploadBlockNameJSON.HoldingGenerator fieldGeneratorName;
        private TerrierTableUploadRowJSON.HoldingArrayGenerator fieldGeneratorRows;
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
            TerrierTableUploadTableJSON result = new TerrierTableUploadTableJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierTableUploadTableAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierTableUploadTableJSON result)
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
            if (fieldGeneratorRows.have_value)
              {
                result.initRows();
                int count = fieldGeneratorRows.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRows(fieldGeneratorRows.value[num]);
                  }
                fieldGeneratorRows.value.Clear();
                fieldGeneratorRows.have_value = false;
              }
            else if ((!(result.hasRows())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Rows\" field was missing.");
              }
          }
        protected abstract void handle_result(TerrierTableUploadTableJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "ows", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorRows;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new TerrierUploadBlockNameJSON.HoldingGenerator("field \"Name\" of the TerrierTableUploadTable class", ignore_extras);
            fieldGeneratorRows = new TerrierTableUploadRowJSON.HoldingArrayGenerator("field \"Rows\" of the TerrierTableUploadTable class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierTableUploadTable class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new TerrierUploadBlockNameJSON.HoldingGenerator("field \"Name\" of the TerrierTableUploadTable class", false);
            fieldGeneratorRows = new TerrierTableUploadRowJSON.HoldingArrayGenerator("field \"Rows\" of the TerrierTableUploadTable class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierTableUploadTable class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorRows.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorName.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRows.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorName.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRows.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierTableUploadTableJSON  result)
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
        public TerrierTableUploadTableJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierTableUploadTableJSON  result)
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
    protected virtual void handle_result(List<TerrierTableUploadTableJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierTableUploadTableJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierTableUploadTableJSON>();
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
    public List<TerrierTableUploadTableJSON> value;
  };
  };
