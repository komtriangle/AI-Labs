/* file "TerrierUploadWriteProjectOptionsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class TerrierUploadWriteProjectOptionsJSON : JSONBase
  {
    private bool flagHasOutputSummary;
    private bool storeOutputSummary;
    private bool flagHasOutputDetailedInformation;
    private bool storeOutputDetailedInformation;
    private bool flagHasDryRun;
    private bool storeDryRun;
    private bool flagHasDisallowDuplicateFileNames;
    private bool storeDisallowDuplicateFileNames;
    private bool flagHasOutputBlockMetadata;
    private bool storeOutputBlockMetadata;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONOutputSummary(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OutputSummary of TerrierUploadWriteProjectOptionsJSON is not true for false.");
              }
          }
        setOutputSummary(the_bool);
      }


    private void  fromJSONOutputDetailedInformation(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OutputDetailedInformation of TerrierUploadWriteProjectOptionsJSON is not true for false.");
              }
          }
        setOutputDetailedInformation(the_bool);
      }


    private void  fromJSONDryRun(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DryRun of TerrierUploadWriteProjectOptionsJSON is not true for false.");
              }
          }
        setDryRun(the_bool);
      }


    private void  fromJSONDisallowDuplicateFileNames(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DisallowDuplicateFileNames of TerrierUploadWriteProjectOptionsJSON is not true for false.");
              }
          }
        setDisallowDuplicateFileNames(the_bool);
      }


    private void  fromJSONOutputBlockMetadata(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OutputBlockMetadata of TerrierUploadWriteProjectOptionsJSON is not true for false.");
              }
          }
        setOutputBlockMetadata(the_bool);
      }


    public TerrierUploadWriteProjectOptionsJSON()
      {
        flagHasOutputSummary = false;
        flagHasOutputDetailedInformation = false;
        flagHasDryRun = false;
        flagHasDisallowDuplicateFileNames = false;
        flagHasOutputBlockMetadata = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasOutputSummary()
      {
        return flagHasOutputSummary;
      }

    public bool  getOutputSummary()
      {
        Debug.Assert(flagHasOutputSummary);
        return storeOutputSummary;
      }

    public bool  hasOutputDetailedInformation()
      {
        return flagHasOutputDetailedInformation;
      }

    public bool  getOutputDetailedInformation()
      {
        Debug.Assert(flagHasOutputDetailedInformation);
        return storeOutputDetailedInformation;
      }

    public bool  hasDryRun()
      {
        return flagHasDryRun;
      }

    public bool  getDryRun()
      {
        Debug.Assert(flagHasDryRun);
        return storeDryRun;
      }

    public bool  hasDisallowDuplicateFileNames()
      {
        return flagHasDisallowDuplicateFileNames;
      }

    public bool  getDisallowDuplicateFileNames()
      {
        Debug.Assert(flagHasDisallowDuplicateFileNames);
        return storeDisallowDuplicateFileNames;
      }

    public bool  hasOutputBlockMetadata()
      {
        return flagHasOutputBlockMetadata;
      }

    public bool  getOutputBlockMetadata()
      {
        Debug.Assert(flagHasOutputBlockMetadata);
        return storeOutputBlockMetadata;
      }


    public virtual int extraTerrierUploadWriteProjectOptionsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraTerrierUploadWriteProjectOptionsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraTerrierUploadWriteProjectOptionsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraTerrierUploadWriteProjectOptionsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setOutputSummary(bool new_value)
      {
        flagHasOutputSummary = true;
        storeOutputSummary = new_value;
      }
    public void unsetOutputSummary()
      {
        flagHasOutputSummary = false;
      }
    public void setOutputDetailedInformation(bool new_value)
      {
        flagHasOutputDetailedInformation = true;
        storeOutputDetailedInformation = new_value;
      }
    public void unsetOutputDetailedInformation()
      {
        flagHasOutputDetailedInformation = false;
      }
    public void setDryRun(bool new_value)
      {
        flagHasDryRun = true;
        storeDryRun = new_value;
      }
    public void unsetDryRun()
      {
        flagHasDryRun = false;
      }
    public void setDisallowDuplicateFileNames(bool new_value)
      {
        flagHasDisallowDuplicateFileNames = true;
        storeDisallowDuplicateFileNames = new_value;
      }
    public void unsetDisallowDuplicateFileNames()
      {
        flagHasDisallowDuplicateFileNames = false;
      }
    public void setOutputBlockMetadata(bool new_value)
      {
        flagHasOutputBlockMetadata = true;
        storeOutputBlockMetadata = new_value;
      }
    public void unsetOutputBlockMetadata()
      {
        flagHasOutputBlockMetadata = false;
      }

    public virtual void extraTerrierUploadWriteProjectOptionsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraTerrierUploadWriteProjectOptionsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraTerrierUploadWriteProjectOptionsLookup(key);
        if (old_field == null)
          {
            extraTerrierUploadWriteProjectOptionsAppendPair(key, new_component);
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
        if (flagHasOutputSummary)
          {
            handler.start_pair("OutputSummary");
            handler.boolean_value(storeOutputSummary);
          }
        if (flagHasOutputDetailedInformation)
          {
            handler.start_pair("OutputDetailedInformation");
            handler.boolean_value(storeOutputDetailedInformation);
          }
        if (flagHasDryRun)
          {
            handler.start_pair("DryRun");
            handler.boolean_value(storeDryRun);
          }
        if (flagHasDisallowDuplicateFileNames)
          {
            handler.start_pair("DisallowDuplicateFileNames");
            handler.boolean_value(storeDisallowDuplicateFileNames);
          }
        if (flagHasOutputBlockMetadata)
          {
            handler.start_pair("OutputBlockMetadata");
            handler.boolean_value(storeOutputBlockMetadata);
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

    public static TerrierUploadWriteProjectOptionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadWriteProjectOptionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadWriteProjectOptions", ignore_extras);
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
    public static TerrierUploadWriteProjectOptionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadWriteProjectOptionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        TerrierUploadWriteProjectOptionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadWriteProjectOptions", ignore_extras);
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
    public static TerrierUploadWriteProjectOptionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static TerrierUploadWriteProjectOptionsJSON from_text(string text, bool ignore_extras)
      {
        TerrierUploadWriteProjectOptionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadWriteProjectOptions", ignore_extras);
            JSONParse.parse_json_value(text, "Text for TerrierUploadWriteProjectOptionsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static TerrierUploadWriteProjectOptionsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        TerrierUploadWriteProjectOptionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type TerrierUploadWriteProjectOptions", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorOutputSummary;
        private JSONHoldingBooleanGenerator fieldGeneratorOutputDetailedInformation;
        private JSONHoldingBooleanGenerator fieldGeneratorDryRun;
        private JSONHoldingBooleanGenerator fieldGeneratorDisallowDuplicateFileNames;
        private JSONHoldingBooleanGenerator fieldGeneratorOutputBlockMetadata;
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
            TerrierUploadWriteProjectOptionsJSON result = new TerrierUploadWriteProjectOptionsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraTerrierUploadWriteProjectOptionsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(TerrierUploadWriteProjectOptionsJSON result)
          {
            if (fieldGeneratorOutputSummary.have_value)
              {
                result.setOutputSummary(fieldGeneratorOutputSummary.value);
                fieldGeneratorOutputSummary.have_value = false;
              }
            if (fieldGeneratorOutputDetailedInformation.have_value)
              {
                result.setOutputDetailedInformation(fieldGeneratorOutputDetailedInformation.value);
                fieldGeneratorOutputDetailedInformation.have_value = false;
              }
            if (fieldGeneratorDryRun.have_value)
              {
                result.setDryRun(fieldGeneratorDryRun.value);
                fieldGeneratorDryRun.have_value = false;
              }
            if (fieldGeneratorDisallowDuplicateFileNames.have_value)
              {
                result.setDisallowDuplicateFileNames(fieldGeneratorDisallowDuplicateFileNames.value);
                fieldGeneratorDisallowDuplicateFileNames.have_value = false;
              }
            if (fieldGeneratorOutputBlockMetadata.have_value)
              {
                result.setOutputBlockMetadata(fieldGeneratorOutputBlockMetadata.value);
                fieldGeneratorOutputBlockMetadata.have_value = false;
              }
          }
        protected abstract void handle_result(TerrierUploadWriteProjectOptionsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "sallowDuplicateFileNames", 0, 24, false) == 0) && (field_name.Length == 26))
                                return fieldGeneratorDisallowDuplicateFileNames;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "yRun", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorDryRun;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'O':
                    if (String.Compare(field_name, 1, "utput", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 7, "lockMetadata", 0, 12, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorOutputBlockMetadata;
                                break;
                            case 'D':
                                if ((String.Compare(field_name, 7, "etailedInformation", 0, 18, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorOutputDetailedInformation;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 7, "ummary", 0, 6, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorOutputSummary;
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
            fieldGeneratorOutputSummary = new JSONHoldingBooleanGenerator("field \"OutputSummary\" of the TerrierUploadWriteProjectOptions class");
            fieldGeneratorOutputDetailedInformation = new JSONHoldingBooleanGenerator("field \"OutputDetailedInformation\" of the TerrierUploadWriteProjectOptions class");
            fieldGeneratorDryRun = new JSONHoldingBooleanGenerator("field \"DryRun\" of the TerrierUploadWriteProjectOptions class");
            fieldGeneratorDisallowDuplicateFileNames = new JSONHoldingBooleanGenerator("field \"DisallowDuplicateFileNames\" of the TerrierUploadWriteProjectOptions class");
            fieldGeneratorOutputBlockMetadata = new JSONHoldingBooleanGenerator("field \"OutputBlockMetadata\" of the TerrierUploadWriteProjectOptions class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the TerrierUploadWriteProjectOptions class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorOutputSummary = new JSONHoldingBooleanGenerator("field \"OutputSummary\" of the TerrierUploadWriteProjectOptions class");
            fieldGeneratorOutputDetailedInformation = new JSONHoldingBooleanGenerator("field \"OutputDetailedInformation\" of the TerrierUploadWriteProjectOptions class");
            fieldGeneratorDryRun = new JSONHoldingBooleanGenerator("field \"DryRun\" of the TerrierUploadWriteProjectOptions class");
            fieldGeneratorDisallowDuplicateFileNames = new JSONHoldingBooleanGenerator("field \"DisallowDuplicateFileNames\" of the TerrierUploadWriteProjectOptions class");
            fieldGeneratorOutputBlockMetadata = new JSONHoldingBooleanGenerator("field \"OutputBlockMetadata\" of the TerrierUploadWriteProjectOptions class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the TerrierUploadWriteProjectOptions class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorOutputSummary.reset();
            fieldGeneratorOutputDetailedInformation.reset();
            fieldGeneratorDryRun.reset();
            fieldGeneratorDisallowDuplicateFileNames.reset();
            fieldGeneratorOutputBlockMetadata.reset();
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
        protected override void handle_result(TerrierUploadWriteProjectOptionsJSON  result)
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
        public TerrierUploadWriteProjectOptionsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(TerrierUploadWriteProjectOptionsJSON  result)
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
    protected virtual void handle_result(List<TerrierUploadWriteProjectOptionsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<TerrierUploadWriteProjectOptionsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<TerrierUploadWriteProjectOptionsJSON>();
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
    public List<TerrierUploadWriteProjectOptionsJSON> value;
  };
  };
