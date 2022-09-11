/* file "TerrierTableUploadWriteDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrierTableUploadWriteDataJSON : JSONBase
  {
    private bool flagHasTablesToDelete;
    private List< string > storeTablesToDelete;
    private bool flagHasTablesToWrite;
    private List< TerrierTableUploadTableJSON  > storeTablesToWrite;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTablesToDelete(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TablesToDelete of TerrierTableUploadWriteDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_TablesToDelete1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field TablesToDelete of TerrierTableUploadWriteDataJSON is not a string.");
            vector_TablesToDelete1.Add(json_string.getData());
          }
        initTablesToDelete();
        for (int num1 = 0; num1 < vector_TablesToDelete1.Count; ++num1)
            appendTablesToDelete(vector_TablesToDelete1[num1]);
        for (int num1 = 0; num1 < vector_TablesToDelete1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTablesToWrite(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TablesToWrite of TerrierTableUploadWriteDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TerrierTableUploadTableJSON  > vector_TablesToWrite1 = new List< TerrierTableUploadTableJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TerrierTableUploadTableJSON convert_classy = TerrierTableUploadTableJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_TablesToWrite1.Add(convert_classy);
          }
        initTablesToWrite();
        for (int num2 = 0; num2 < vector_TablesToWrite1.Count; ++num2)
            appendTablesToWrite(vector_TablesToWrite1[num2]);
        for (int num1 = 0; num1 < vector_TablesToWrite1.Count; ++num1)
          {
          }
      }


    public TerrierTableUploadWriteDataJSON()
      {
        flagHasTablesToDelete = false;
        flagHasTablesToWrite = false;
        storeTablesToDelete = new List< string >();
        storeTablesToWrite = new List< TerrierTableUploadTableJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasTablesToDelete()
      {
        return flagHasTablesToDelete;
      }

    public int  countOfTablesToDelete()
      {
        Debug.Assert(flagHasTablesToDelete);
        return storeTablesToDelete.Count;
      }

    public string  elementOfTablesToDelete(int element_num)
      {
        Debug.Assert(flagHasTablesToDelete);
        return storeTablesToDelete[element_num];
      }

    public List< string >  getTablesToDelete()
      {
        Debug.Assert(flagHasTablesToDelete);
        return storeTablesToDelete;
      }

    public bool  hasTablesToWrite()
      {
        return flagHasTablesToWrite;
      }

    public int  countOfTablesToWrite()
      {
        Debug.Assert(flagHasTablesToWrite);
        return storeTablesToWrite.Count;
      }

    public TerrierTableUploadTableJSON   elementOfTablesToWrite(int element_num)
      {
        Debug.Assert(flagHasTablesToWrite);
        return storeTablesToWrite[element_num];
      }

    public List< TerrierTableUploadTableJSON  >  getTablesToWrite()
      {
        Debug.Assert(flagHasTablesToWrite);
        return storeTablesToWrite;
      }


    public virtual int extraTerrierTableUploadWriteDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierTableUploadWriteDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierTableUploadWriteDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierTableUploadWriteDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initTablesToDelete()
      {
        flagHasTablesToDelete = true;
        storeTablesToDelete.Clear();
      }
    public void appendTablesToDelete(string to_append)
      {
        if (!flagHasTablesToDelete)
          {
            flagHasTablesToDelete = true;
            storeTablesToDelete.Clear();
          }
        Debug.Assert(flagHasTablesToDelete);
        storeTablesToDelete.Add(to_append);
      }
    public void unsetTablesToDelete()
      {
        flagHasTablesToDelete = false;
        storeTablesToDelete.Clear();
      }
    public void initTablesToWrite()
      {
        if (flagHasTablesToWrite)
          {
            for (int num1 = 0; num1 < storeTablesToWrite.Count; ++num1)
              {
              }
          }
        flagHasTablesToWrite = true;
        storeTablesToWrite.Clear();
      }
    public void appendTablesToWrite(TerrierTableUploadTableJSON  to_append)
      {
        if (!flagHasTablesToWrite)
          {
            flagHasTablesToWrite = true;
            storeTablesToWrite.Clear();
          }
        Debug.Assert(flagHasTablesToWrite);
        storeTablesToWrite.Add(to_append);
      }
    public void unsetTablesToWrite()
      {
        if (flagHasTablesToWrite)
          {
            for (int num2 = 0; num2 < storeTablesToWrite.Count; ++num2)
              {
              }
          }
        flagHasTablesToWrite = false;
        storeTablesToWrite.Clear();
      }

    public virtual void extraTerrierTableUploadWriteDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierTableUploadWriteDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierTableUploadWriteDataLookup(key);
        if (old_field == null)
          {
            extraTerrierTableUploadWriteDataAppendPair(key, new_component);
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
        if (flagHasTablesToDelete)
          {
            handler.start_pair("TablesToDelete");
            handler.start_array();
            for (int num1 = 0; num1 < storeTablesToDelete.Count; ++num1)
              {
                handler.string_value(storeTablesToDelete[num1]);
              }
            handler.finish_array();
          }
        if (flagHasTablesToWrite)
          {
            handler.start_pair("TablesToWrite");
            handler.start_array();
            for (int num2 = 0; num2 < storeTablesToWrite.Count; ++num2)
              {
                if (partial_allowed)
                    storeTablesToWrite[num2].write_partial_as_json(handler);
                else
                    storeTablesToWrite[num2].write_as_json(handler);
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
        return null;
      }

    public static TerrierTableUploadWriteDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierTableUploadWriteDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierTableUploadWriteData", ignore_extras);
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
    public static TerrierTableUploadWriteDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierTableUploadWriteDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierTableUploadWriteDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierTableUploadWriteData", ignore_extras);
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
    public static TerrierTableUploadWriteDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierTableUploadWriteDataJSON from_text(string text, bool ignore_extras)
      {
        TerrierTableUploadWriteDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierTableUploadWriteData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierTableUploadWriteDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierTableUploadWriteDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierTableUploadWriteDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierTableUploadWriteData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorTablesToDelete;
        private TerrierTableUploadTableJSON.HoldingArrayGenerator fieldGeneratorTablesToWrite;
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
            TerrierTableUploadWriteDataJSON result = new TerrierTableUploadWriteDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierTableUploadWriteDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierTableUploadWriteDataJSON result)
          {
            if (fieldGeneratorTablesToDelete.have_value)
              {
                result.initTablesToDelete();
                int count = fieldGeneratorTablesToDelete.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTablesToDelete(fieldGeneratorTablesToDelete.value[num]);
                  }
                fieldGeneratorTablesToDelete.value.Clear();
                fieldGeneratorTablesToDelete.have_value = false;
              }
            if (fieldGeneratorTablesToWrite.have_value)
              {
                result.initTablesToWrite();
                int count = fieldGeneratorTablesToWrite.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTablesToWrite(fieldGeneratorTablesToWrite.value[num]);
                  }
                fieldGeneratorTablesToWrite.value.Clear();
                fieldGeneratorTablesToWrite.have_value = false;
              }
          }
        protected abstract void handle_result(TerrierTableUploadWriteDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "TablesTo", 0, 8, false) == 0)
              {
                switch (field_name[8])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 9, "elete", 0, 5, false) == 0) && (field_name.Length == 14))
                            return fieldGeneratorTablesToDelete;
                        break;
                    case 'W':
                        if ((String.Compare(field_name, 9, "rite", 0, 4, false) == 0) && (field_name.Length == 13))
                            return fieldGeneratorTablesToWrite;
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTablesToDelete = new JSONHoldingStringArrayGenerator("field \"TablesToDelete\" of the TerrierTableUploadWriteData class");
            fieldGeneratorTablesToWrite = new TerrierTableUploadTableJSON.HoldingArrayGenerator("field \"TablesToWrite\" of the TerrierTableUploadWriteData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierTableUploadWriteData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTablesToDelete = new JSONHoldingStringArrayGenerator("field \"TablesToDelete\" of the TerrierTableUploadWriteData class");
            fieldGeneratorTablesToWrite = new TerrierTableUploadTableJSON.HoldingArrayGenerator("field \"TablesToWrite\" of the TerrierTableUploadWriteData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierTableUploadWriteData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTablesToDelete.reset();
            fieldGeneratorTablesToWrite.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTablesToWrite.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTablesToWrite.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierTableUploadWriteDataJSON  result)
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
        public TerrierTableUploadWriteDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierTableUploadWriteDataJSON  result)
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
    protected virtual void handle_result(List<TerrierTableUploadWriteDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierTableUploadWriteDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierTableUploadWriteDataJSON>();
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
    public List<TerrierTableUploadWriteDataJSON> value;
  };
  };
