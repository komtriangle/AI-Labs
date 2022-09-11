/* file "TerrierTableUploadReadDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrierTableUploadReadDataJSON : JSONBase
  {
    private bool flagHasReadTableList;
    private bool storeReadTableList;
    private bool flagHasTablesToRead;
    private List< string > storeTablesToRead;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONReadTableList(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ReadTableList of TerrierTableUploadReadDataJSON is not true for false.");
              }
          }
        setReadTableList(the_bool);
      }


    private void  fromJSONTablesToRead(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TablesToRead of TerrierTableUploadReadDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_TablesToRead1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field TablesToRead of TerrierTableUploadReadDataJSON is not a string.");
            vector_TablesToRead1.Add(json_string.getData());
          }
        initTablesToRead();
        for (int num1 = 0; num1 < vector_TablesToRead1.Count; ++num1)
            appendTablesToRead(vector_TablesToRead1[num1]);
        for (int num1 = 0; num1 < vector_TablesToRead1.Count; ++num1)
          {
          }
      }


    public TerrierTableUploadReadDataJSON()
      {
        flagHasReadTableList = false;
        flagHasTablesToRead = false;
        storeTablesToRead = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasReadTableList()
      {
        return flagHasReadTableList;
      }

    public bool  getReadTableList()
      {
        Debug.Assert(flagHasReadTableList);
        return storeReadTableList;
      }

    public bool  hasTablesToRead()
      {
        return flagHasTablesToRead;
      }

    public int  countOfTablesToRead()
      {
        Debug.Assert(flagHasTablesToRead);
        return storeTablesToRead.Count;
      }

    public string  elementOfTablesToRead(int element_num)
      {
        Debug.Assert(flagHasTablesToRead);
        return storeTablesToRead[element_num];
      }

    public List< string >  getTablesToRead()
      {
        Debug.Assert(flagHasTablesToRead);
        return storeTablesToRead;
      }


    public virtual int extraTerrierTableUploadReadDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierTableUploadReadDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierTableUploadReadDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierTableUploadReadDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setReadTableList(bool new_value)
      {
        flagHasReadTableList = true;
        storeReadTableList = new_value;
      }
    public void unsetReadTableList()
      {
        flagHasReadTableList = false;
      }
    public void initTablesToRead()
      {
        flagHasTablesToRead = true;
        storeTablesToRead.Clear();
      }
    public void appendTablesToRead(string to_append)
      {
        if (!flagHasTablesToRead)
          {
            flagHasTablesToRead = true;
            storeTablesToRead.Clear();
          }
        Debug.Assert(flagHasTablesToRead);
        storeTablesToRead.Add(to_append);
      }
    public void unsetTablesToRead()
      {
        flagHasTablesToRead = false;
        storeTablesToRead.Clear();
      }

    public virtual void extraTerrierTableUploadReadDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierTableUploadReadDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierTableUploadReadDataLookup(key);
        if (old_field == null)
          {
            extraTerrierTableUploadReadDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasReadTableList);
        if (flagHasReadTableList)
          {
            handler.start_pair("ReadTableList");
            handler.boolean_value(storeReadTableList);
          }
        Debug.Assert(partial_allowed || flagHasTablesToRead);
        if (flagHasTablesToRead)
          {
            handler.start_pair("TablesToRead");
            handler.start_array();
            for (int num1 = 0; num1 < storeTablesToRead.Count; ++num1)
              {
                handler.string_value(storeTablesToRead[num1]);
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
        if (!(hasReadTableList()))
          {
            return "When parsing the object for %what%, the \"ReadTableList\" field was missing.";
          }
        if (!(hasTablesToRead()))
          {
            return "When parsing the object for %what%, the \"TablesToRead\" field was missing.";
          }
        return null;
      }

    public static TerrierTableUploadReadDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierTableUploadReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierTableUploadReadData", ignore_extras);
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
    public static TerrierTableUploadReadDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierTableUploadReadDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierTableUploadReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierTableUploadReadData", ignore_extras);
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
    public static TerrierTableUploadReadDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierTableUploadReadDataJSON from_text(string text, bool ignore_extras)
      {
        TerrierTableUploadReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierTableUploadReadData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierTableUploadReadDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierTableUploadReadDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierTableUploadReadDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierTableUploadReadData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorReadTableList;
        private JSONHoldingStringArrayGenerator fieldGeneratorTablesToRead;
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
            TerrierTableUploadReadDataJSON result = new TerrierTableUploadReadDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierTableUploadReadDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierTableUploadReadDataJSON result)
          {
            if (fieldGeneratorReadTableList.have_value)
              {
                result.setReadTableList(fieldGeneratorReadTableList.value);
                fieldGeneratorReadTableList.have_value = false;
              }
            else if ((!(result.hasReadTableList())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ReadTableList\" field was missing.");
              }
            if (fieldGeneratorTablesToRead.have_value)
              {
                result.initTablesToRead();
                int count = fieldGeneratorTablesToRead.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTablesToRead(fieldGeneratorTablesToRead.value[num]);
                  }
                fieldGeneratorTablesToRead.value.Clear();
                fieldGeneratorTablesToRead.have_value = false;
              }
            else if ((!(result.hasTablesToRead())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TablesToRead\" field was missing.");
              }
          }
        protected abstract void handle_result(TerrierTableUploadReadDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'R':
                    if ((String.Compare(field_name, 1, "eadTableList", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorReadTableList;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ablesToRead", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorTablesToRead;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorReadTableList = new JSONHoldingBooleanGenerator("field \"ReadTableList\" of the TerrierTableUploadReadData class");
            fieldGeneratorTablesToRead = new JSONHoldingStringArrayGenerator("field \"TablesToRead\" of the TerrierTableUploadReadData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierTableUploadReadData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorReadTableList = new JSONHoldingBooleanGenerator("field \"ReadTableList\" of the TerrierTableUploadReadData class");
            fieldGeneratorTablesToRead = new JSONHoldingStringArrayGenerator("field \"TablesToRead\" of the TerrierTableUploadReadData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierTableUploadReadData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorReadTableList.reset();
            fieldGeneratorTablesToRead.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierTableUploadReadDataJSON  result)
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
        public TerrierTableUploadReadDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierTableUploadReadDataJSON  result)
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
    protected virtual void handle_result(List<TerrierTableUploadReadDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierTableUploadReadDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierTableUploadReadDataJSON>();
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
    public List<TerrierTableUploadReadDataJSON> value;
  };
  };
