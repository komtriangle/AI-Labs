/* file "TerrierUploadParameterJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


public class TerrierUploadParameterJSON : JSONBase
  {
    public static Regex expressionName = new Regex("^[a-zA-Z_]([a-zA-Z_0-9]*)$");
    private bool flagHasName;
    private string storeName;
    private bool flagHasTypeCode;
    private string storeTypeCode;
    private bool flagHasTypeCodeSource;
    private UploadedCodeSourceJSON  storeTypeCodeSource;
    private bool flagHasDefaultValueCode;
    private string storeDefaultValueCode;
    private bool flagHasDefaultValueCodeSource;
    private UploadedCodeSourceJSON  storeDefaultValueCodeSource;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of TerrierUploadParameterJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONTypeCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TypeCode of TerrierUploadParameterJSON is not a string.");
        setTypeCode(json_string.getData());
      }


    private void  fromJSONTypeCodeSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeSourceJSON convert_classy = UploadedCodeSourceJSON.from_json(json_value, ignore_extras, true);
        setTypeCodeSource(convert_classy);
      }


    private void  fromJSONDefaultValueCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DefaultValueCode of TerrierUploadParameterJSON is not a string.");
        setDefaultValueCode(json_string.getData());
      }


    private void  fromJSONDefaultValueCodeSource(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        UploadedCodeSourceJSON convert_classy = UploadedCodeSourceJSON.from_json(json_value, ignore_extras, true);
        setDefaultValueCodeSource(convert_classy);
      }


    public TerrierUploadParameterJSON()
      {
        flagHasName = false;
        flagHasTypeCode = false;
        flagHasTypeCodeSource = false;
        flagHasDefaultValueCode = false;
        flagHasDefaultValueCodeSource = false;
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

    public bool  hasTypeCode()
      {
        return flagHasTypeCode;
      }

    public string  getTypeCode()
      {
        Debug.Assert(flagHasTypeCode);
        return storeTypeCode;
      }

    public bool  hasTypeCodeSource()
      {
        return flagHasTypeCodeSource;
      }

    public UploadedCodeSourceJSON   getTypeCodeSource()
      {
        Debug.Assert(flagHasTypeCodeSource);
        return storeTypeCodeSource;
      }

    public bool  hasDefaultValueCode()
      {
        return flagHasDefaultValueCode;
      }

    public string  getDefaultValueCode()
      {
        Debug.Assert(flagHasDefaultValueCode);
        return storeDefaultValueCode;
      }

    public bool  hasDefaultValueCodeSource()
      {
        return flagHasDefaultValueCodeSource;
      }

    public UploadedCodeSourceJSON   getDefaultValueCodeSource()
      {
        Debug.Assert(flagHasDefaultValueCodeSource);
        return storeDefaultValueCodeSource;
      }


    public virtual int extraTerrierUploadParameterComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierUploadParameterComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierUploadParameterComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierUploadParameterLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setName(string new_value)
      {
        flagHasName = true;
        if (!expressionName.IsMatch(new_value))
            throw new Exception("The value is not in the regular expression for field Name of TerrierUploadParameterJSON.");
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setTypeCode(string new_value)
      {
        flagHasTypeCode = true;
        storeTypeCode = new_value;
      }
    public void unsetTypeCode()
      {
        flagHasTypeCode = false;
      }
    public void setTypeCodeSource(UploadedCodeSourceJSON  new_value)
      {
        if (flagHasTypeCodeSource)
          {
          }
        flagHasTypeCodeSource = true;
        storeTypeCodeSource = new_value;
      }
    public void unsetTypeCodeSource()
      {
        if (flagHasTypeCodeSource)
          {
          }
        flagHasTypeCodeSource = false;
      }
    public void setDefaultValueCode(string new_value)
      {
        flagHasDefaultValueCode = true;
        storeDefaultValueCode = new_value;
      }
    public void unsetDefaultValueCode()
      {
        flagHasDefaultValueCode = false;
      }
    public void setDefaultValueCodeSource(UploadedCodeSourceJSON  new_value)
      {
        if (flagHasDefaultValueCodeSource)
          {
          }
        flagHasDefaultValueCodeSource = true;
        storeDefaultValueCodeSource = new_value;
      }
    public void unsetDefaultValueCodeSource()
      {
        if (flagHasDefaultValueCodeSource)
          {
          }
        flagHasDefaultValueCodeSource = false;
      }

    public virtual void extraTerrierUploadParameterAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierUploadParameterSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierUploadParameterLookup(key);
        if (old_field == null)
          {
            extraTerrierUploadParameterAppendPair(key, new_component);
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
        if (flagHasTypeCode)
          {
            handler.start_pair("TypeCode");
            handler.string_value(storeTypeCode);
          }
        if (flagHasTypeCodeSource)
          {
            handler.start_pair("TypeCodeSource");
            if (partial_allowed)
                storeTypeCodeSource.write_partial_as_json(handler);
            else
                storeTypeCodeSource.write_as_json(handler);
          }
        if (flagHasDefaultValueCode)
          {
            handler.start_pair("DefaultValueCode");
            handler.string_value(storeDefaultValueCode);
          }
        if (flagHasDefaultValueCodeSource)
          {
            handler.start_pair("DefaultValueCodeSource");
            if (partial_allowed)
                storeDefaultValueCodeSource.write_partial_as_json(handler);
            else
                storeDefaultValueCodeSource.write_as_json(handler);
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

    public static TerrierUploadParameterJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadParameterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadParameter", ignore_extras);
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
    public static TerrierUploadParameterJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadParameterJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadParameterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadParameter", ignore_extras);
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
    public static TerrierUploadParameterJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadParameterJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadParameterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadParameter", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadParameterJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierUploadParameterJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadParameterJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadParameter", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorName : JSONStringGenerator
          {
            private Regex checker;
            protected FieldGeneratorName()  { checker = new Regex("^[a-zA-Z_]([a-zA-Z_0-9]*)$"); }
            protected FieldGeneratorName(string  what) : base(what) { checker = new Regex("^[a-zA-Z_]([a-zA-Z_0-9]*)$"); }
            protected void validate(string result)
              {
                if (!(checker.IsMatch(result)))
                    error("The string for %what% doesn't match the required pattern @^[a-zA-Z_]([a-zA-Z_0-9]*)$@.");
              }
          };
    private class FieldHoldingGeneratorName : FieldGeneratorName
  {
    protected override void handle_result(string result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorName(String what)
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
    public string value;
  };
    private class FieldHoldingArrayGeneratorName : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorName
      {
        private FieldHoldingArrayGeneratorName top;

        protected override void handle_result(string result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorName init_top)
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
    protected virtual void handle_result(List<string> result)
      {
      }

    public FieldHoldingArrayGeneratorName(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorName()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<string>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<string> value;
  };
        private FieldHoldingGeneratorName fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorTypeCode;
        private UploadedCodeSourceJSON.HoldingGenerator fieldGeneratorTypeCodeSource;
        private JSONHoldingStringGenerator fieldGeneratorDefaultValueCode;
        private UploadedCodeSourceJSON.HoldingGenerator fieldGeneratorDefaultValueCodeSource;
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
            TerrierUploadParameterJSON result = new TerrierUploadParameterJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierUploadParameterAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierUploadParameterJSON result)
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
            if (fieldGeneratorTypeCode.have_value)
              {
                result.setTypeCode(fieldGeneratorTypeCode.value);
                fieldGeneratorTypeCode.have_value = false;
              }
            if (fieldGeneratorTypeCodeSource.have_value)
              {
                result.setTypeCodeSource(fieldGeneratorTypeCodeSource.value);
                fieldGeneratorTypeCodeSource.have_value = false;
              }
            if (fieldGeneratorDefaultValueCode.have_value)
              {
                result.setDefaultValueCode(fieldGeneratorDefaultValueCode.value);
                fieldGeneratorDefaultValueCode.have_value = false;
              }
            if (fieldGeneratorDefaultValueCodeSource.have_value)
              {
                result.setDefaultValueCodeSource(fieldGeneratorDefaultValueCodeSource.value);
                fieldGeneratorDefaultValueCodeSource.have_value = false;
              }
          }
        protected abstract void handle_result(TerrierUploadParameterJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "efaultValueCode", 0, 15, false) == 0)
                      {
                        if (field_name.Length == 16)
                          {
                            return fieldGeneratorDefaultValueCode;
                          }
                        switch (field_name[16])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 17, "ource", 0, 5, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorDefaultValueCodeSource;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "ypeCode", 0, 7, false) == 0)
                      {
                        if (field_name.Length == 8)
                          {
                            return fieldGeneratorTypeCode;
                          }
                        switch (field_name[8])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 9, "ource", 0, 5, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorTypeCodeSource;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new FieldHoldingGeneratorName("field \"Name\" of the TerrierUploadParameter class");
            fieldGeneratorTypeCode = new JSONHoldingStringGenerator("field \"TypeCode\" of the TerrierUploadParameter class");
            fieldGeneratorTypeCodeSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"TypeCodeSource\" of the TerrierUploadParameter class", ignore_extras);
            fieldGeneratorDefaultValueCode = new JSONHoldingStringGenerator("field \"DefaultValueCode\" of the TerrierUploadParameter class");
            fieldGeneratorDefaultValueCodeSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"DefaultValueCodeSource\" of the TerrierUploadParameter class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierUploadParameter class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new FieldHoldingGeneratorName("field \"Name\" of the TerrierUploadParameter class");
            fieldGeneratorTypeCode = new JSONHoldingStringGenerator("field \"TypeCode\" of the TerrierUploadParameter class");
            fieldGeneratorTypeCodeSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"TypeCodeSource\" of the TerrierUploadParameter class", false);
            fieldGeneratorDefaultValueCode = new JSONHoldingStringGenerator("field \"DefaultValueCode\" of the TerrierUploadParameter class");
            fieldGeneratorDefaultValueCodeSource = new UploadedCodeSourceJSON.HoldingGenerator("field \"DefaultValueCodeSource\" of the TerrierUploadParameter class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierUploadParameter class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorTypeCode.reset();
            fieldGeneratorTypeCodeSource.reset();
            fieldGeneratorDefaultValueCode.reset();
            fieldGeneratorDefaultValueCodeSource.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTypeCodeSource.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDefaultValueCodeSource.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTypeCodeSource.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDefaultValueCodeSource.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(TerrierUploadParameterJSON  result)
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
        public TerrierUploadParameterJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadParameterJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadParameterJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadParameterJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadParameterJSON>();
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
    public List<TerrierUploadParameterJSON> value;
  };
  };
