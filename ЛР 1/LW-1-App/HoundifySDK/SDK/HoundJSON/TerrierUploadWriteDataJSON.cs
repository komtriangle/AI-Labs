/* file "TerrierUploadWriteDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrierUploadWriteDataJSON : JSONBase
  {
    private bool flagHasBlocksToDelete;
    private List< string > storeBlocksToDelete;
    private bool flagHasBlocksToWrite;
    private List< TerrierUploadBlockJSON  > storeBlocksToWrite;
    private bool flagHasBlockMetadataToWrite;
    private List< TerrierUploadBlockMetadataJSON  > storeBlockMetadataToWrite;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONBlocksToDelete(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field BlocksToDelete of TerrierUploadWriteDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_BlocksToDelete1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field BlocksToDelete of TerrierUploadWriteDataJSON is not a string.");
            vector_BlocksToDelete1.Add(json_string.getData());
          }
        initBlocksToDelete();
        for (int num1 = 0; num1 < vector_BlocksToDelete1.Count; ++num1)
            appendBlocksToDelete(vector_BlocksToDelete1[num1]);
        for (int num1 = 0; num1 < vector_BlocksToDelete1.Count; ++num1)
          {
          }
      }


    private void  fromJSONBlocksToWrite(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field BlocksToWrite of TerrierUploadWriteDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TerrierUploadBlockJSON  > vector_BlocksToWrite1 = new List< TerrierUploadBlockJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TerrierUploadBlockJSON convert_classy = TerrierUploadBlockJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_BlocksToWrite1.Add(convert_classy);
          }
        initBlocksToWrite();
        for (int num2 = 0; num2 < vector_BlocksToWrite1.Count; ++num2)
            appendBlocksToWrite(vector_BlocksToWrite1[num2]);
        for (int num1 = 0; num1 < vector_BlocksToWrite1.Count; ++num1)
          {
          }
      }


    private void  fromJSONBlockMetadataToWrite(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field BlockMetadataToWrite of TerrierUploadWriteDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TerrierUploadBlockMetadataJSON  > vector_BlockMetadataToWrite1 = new List< TerrierUploadBlockMetadataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TerrierUploadBlockMetadataJSON convert_classy = TerrierUploadBlockMetadataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_BlockMetadataToWrite1.Add(convert_classy);
          }
        initBlockMetadataToWrite();
        for (int num3 = 0; num3 < vector_BlockMetadataToWrite1.Count; ++num3)
            appendBlockMetadataToWrite(vector_BlockMetadataToWrite1[num3]);
        for (int num1 = 0; num1 < vector_BlockMetadataToWrite1.Count; ++num1)
          {
          }
      }


    public TerrierUploadWriteDataJSON()
      {
        flagHasBlocksToDelete = false;
        flagHasBlocksToWrite = false;
        flagHasBlockMetadataToWrite = false;
        storeBlocksToDelete = new List< string >();
        storeBlocksToWrite = new List< TerrierUploadBlockJSON  >();
        storeBlockMetadataToWrite = new List< TerrierUploadBlockMetadataJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasBlocksToDelete()
      {
        return flagHasBlocksToDelete;
      }

    public int  countOfBlocksToDelete()
      {
        Debug.Assert(flagHasBlocksToDelete);
        return storeBlocksToDelete.Count;
      }

    public string  elementOfBlocksToDelete(int element_num)
      {
        Debug.Assert(flagHasBlocksToDelete);
        return storeBlocksToDelete[element_num];
      }

    public List< string >  getBlocksToDelete()
      {
        Debug.Assert(flagHasBlocksToDelete);
        return storeBlocksToDelete;
      }

    public bool  hasBlocksToWrite()
      {
        return flagHasBlocksToWrite;
      }

    public int  countOfBlocksToWrite()
      {
        Debug.Assert(flagHasBlocksToWrite);
        return storeBlocksToWrite.Count;
      }

    public TerrierUploadBlockJSON   elementOfBlocksToWrite(int element_num)
      {
        Debug.Assert(flagHasBlocksToWrite);
        return storeBlocksToWrite[element_num];
      }

    public List< TerrierUploadBlockJSON  >  getBlocksToWrite()
      {
        Debug.Assert(flagHasBlocksToWrite);
        return storeBlocksToWrite;
      }

    public bool  hasBlockMetadataToWrite()
      {
        return flagHasBlockMetadataToWrite;
      }

    public int  countOfBlockMetadataToWrite()
      {
        Debug.Assert(flagHasBlockMetadataToWrite);
        return storeBlockMetadataToWrite.Count;
      }

    public TerrierUploadBlockMetadataJSON   elementOfBlockMetadataToWrite(int element_num)
      {
        Debug.Assert(flagHasBlockMetadataToWrite);
        return storeBlockMetadataToWrite[element_num];
      }

    public List< TerrierUploadBlockMetadataJSON  >  getBlockMetadataToWrite()
      {
        Debug.Assert(flagHasBlockMetadataToWrite);
        return storeBlockMetadataToWrite;
      }


    public virtual int extraTerrierUploadWriteDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierUploadWriteDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierUploadWriteDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierUploadWriteDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initBlocksToDelete()
      {
        flagHasBlocksToDelete = true;
        storeBlocksToDelete.Clear();
      }
    public void appendBlocksToDelete(string to_append)
      {
        if (!flagHasBlocksToDelete)
          {
            flagHasBlocksToDelete = true;
            storeBlocksToDelete.Clear();
          }
        Debug.Assert(flagHasBlocksToDelete);
        storeBlocksToDelete.Add(to_append);
      }
    public void unsetBlocksToDelete()
      {
        flagHasBlocksToDelete = false;
        storeBlocksToDelete.Clear();
      }
    public void initBlocksToWrite()
      {
        if (flagHasBlocksToWrite)
          {
            for (int num1 = 0; num1 < storeBlocksToWrite.Count; ++num1)
              {
              }
          }
        flagHasBlocksToWrite = true;
        storeBlocksToWrite.Clear();
      }
    public void appendBlocksToWrite(TerrierUploadBlockJSON  to_append)
      {
        if (!flagHasBlocksToWrite)
          {
            flagHasBlocksToWrite = true;
            storeBlocksToWrite.Clear();
          }
        Debug.Assert(flagHasBlocksToWrite);
        storeBlocksToWrite.Add(to_append);
      }
    public void unsetBlocksToWrite()
      {
        if (flagHasBlocksToWrite)
          {
            for (int num2 = 0; num2 < storeBlocksToWrite.Count; ++num2)
              {
              }
          }
        flagHasBlocksToWrite = false;
        storeBlocksToWrite.Clear();
      }
    public void initBlockMetadataToWrite()
      {
        if (flagHasBlockMetadataToWrite)
          {
            for (int num3 = 0; num3 < storeBlockMetadataToWrite.Count; ++num3)
              {
              }
          }
        flagHasBlockMetadataToWrite = true;
        storeBlockMetadataToWrite.Clear();
      }
    public void appendBlockMetadataToWrite(TerrierUploadBlockMetadataJSON  to_append)
      {
        if (!flagHasBlockMetadataToWrite)
          {
            flagHasBlockMetadataToWrite = true;
            storeBlockMetadataToWrite.Clear();
          }
        Debug.Assert(flagHasBlockMetadataToWrite);
        storeBlockMetadataToWrite.Add(to_append);
      }
    public void unsetBlockMetadataToWrite()
      {
        if (flagHasBlockMetadataToWrite)
          {
            for (int num4 = 0; num4 < storeBlockMetadataToWrite.Count; ++num4)
              {
              }
          }
        flagHasBlockMetadataToWrite = false;
        storeBlockMetadataToWrite.Clear();
      }

    public virtual void extraTerrierUploadWriteDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierUploadWriteDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierUploadWriteDataLookup(key);
        if (old_field == null)
          {
            extraTerrierUploadWriteDataAppendPair(key, new_component);
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
        if (flagHasBlocksToDelete)
          {
            handler.start_pair("BlocksToDelete");
            handler.start_array();
            for (int num1 = 0; num1 < storeBlocksToDelete.Count; ++num1)
              {
                handler.string_value(storeBlocksToDelete[num1]);
              }
            handler.finish_array();
          }
        if (flagHasBlocksToWrite)
          {
            handler.start_pair("BlocksToWrite");
            handler.start_array();
            for (int num2 = 0; num2 < storeBlocksToWrite.Count; ++num2)
              {
                if (partial_allowed)
                    storeBlocksToWrite[num2].write_partial_as_json(handler);
                else
                    storeBlocksToWrite[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasBlockMetadataToWrite)
          {
            handler.start_pair("BlockMetadataToWrite");
            handler.start_array();
            for (int num3 = 0; num3 < storeBlockMetadataToWrite.Count; ++num3)
              {
                if (partial_allowed)
                    storeBlockMetadataToWrite[num3].write_partial_as_json(handler);
                else
                    storeBlockMetadataToWrite[num3].write_as_json(handler);
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

    public static TerrierUploadWriteDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadWriteDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadWriteData", ignore_extras);
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
    public static TerrierUploadWriteDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadWriteDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadWriteDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadWriteData", ignore_extras);
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
    public static TerrierUploadWriteDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadWriteDataJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadWriteDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadWriteData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadWriteDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierUploadWriteDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadWriteDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadWriteData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringArrayGenerator fieldGeneratorBlocksToDelete;
        private TerrierUploadBlockJSON.HoldingArrayGenerator fieldGeneratorBlocksToWrite;
        private TerrierUploadBlockMetadataJSON.HoldingArrayGenerator fieldGeneratorBlockMetadataToWrite;
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
            TerrierUploadWriteDataJSON result = new TerrierUploadWriteDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierUploadWriteDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierUploadWriteDataJSON result)
          {
            if (fieldGeneratorBlocksToDelete.have_value)
              {
                result.initBlocksToDelete();
                int count = fieldGeneratorBlocksToDelete.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendBlocksToDelete(fieldGeneratorBlocksToDelete.value[num]);
                  }
                fieldGeneratorBlocksToDelete.value.Clear();
                fieldGeneratorBlocksToDelete.have_value = false;
              }
            if (fieldGeneratorBlocksToWrite.have_value)
              {
                result.initBlocksToWrite();
                int count = fieldGeneratorBlocksToWrite.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendBlocksToWrite(fieldGeneratorBlocksToWrite.value[num]);
                  }
                fieldGeneratorBlocksToWrite.value.Clear();
                fieldGeneratorBlocksToWrite.have_value = false;
              }
            if (fieldGeneratorBlockMetadataToWrite.have_value)
              {
                result.initBlockMetadataToWrite();
                int count = fieldGeneratorBlockMetadataToWrite.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendBlockMetadataToWrite(fieldGeneratorBlockMetadataToWrite.value[num]);
                  }
                fieldGeneratorBlockMetadataToWrite.value.Clear();
                fieldGeneratorBlockMetadataToWrite.have_value = false;
              }
          }
        protected abstract void handle_result(TerrierUploadWriteDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            if (String.Compare(field_name, 0, "Block", 0, 5, false) == 0)
              {
                switch (field_name[5])
                  {
                    case 'M':
                        if ((String.Compare(field_name, 6, "etadataToWrite", 0, 14, false) == 0) && (field_name.Length == 20))
                            return fieldGeneratorBlockMetadataToWrite;
                        break;
                    case 's':
                        if (String.Compare(field_name, 6, "To", 0, 2, false) == 0)
                          {
                            switch (field_name[8])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 9, "elete", 0, 5, false) == 0) && (field_name.Length == 14))
                                        return fieldGeneratorBlocksToDelete;
                                    break;
                                case 'W':
                                    if ((String.Compare(field_name, 9, "rite", 0, 4, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorBlocksToWrite;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    default:
                        break;
                  }
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorBlocksToDelete = new JSONHoldingStringArrayGenerator("field \"BlocksToDelete\" of the TerrierUploadWriteData class");
            fieldGeneratorBlocksToWrite = new TerrierUploadBlockJSON.HoldingArrayGenerator("field \"BlocksToWrite\" of the TerrierUploadWriteData class", ignore_extras);
            fieldGeneratorBlockMetadataToWrite = new TerrierUploadBlockMetadataJSON.HoldingArrayGenerator("field \"BlockMetadataToWrite\" of the TerrierUploadWriteData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierUploadWriteData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorBlocksToDelete = new JSONHoldingStringArrayGenerator("field \"BlocksToDelete\" of the TerrierUploadWriteData class");
            fieldGeneratorBlocksToWrite = new TerrierUploadBlockJSON.HoldingArrayGenerator("field \"BlocksToWrite\" of the TerrierUploadWriteData class", false);
            fieldGeneratorBlockMetadataToWrite = new TerrierUploadBlockMetadataJSON.HoldingArrayGenerator("field \"BlockMetadataToWrite\" of the TerrierUploadWriteData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierUploadWriteData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorBlocksToDelete.reset();
            fieldGeneratorBlocksToWrite.reset();
            fieldGeneratorBlockMetadataToWrite.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorBlocksToWrite.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBlockMetadataToWrite.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorBlocksToWrite.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBlockMetadataToWrite.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierUploadWriteDataJSON  result)
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
        public TerrierUploadWriteDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadWriteDataJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadWriteDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadWriteDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadWriteDataJSON>();
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
    public List<TerrierUploadWriteDataJSON> value;
  };
  };
