/* file "HoundifyExplorerConfigJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HoundifyExplorerConfigJSON : JSONBase
  {
    private bool flagHasProfiles;
    private List< HoundifyExplorerProfileJSON  > storeProfiles;
    private bool flagHasDefaultProfile;
    private string storeDefaultProfile;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONProfiles(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Profiles of HoundifyExplorerConfigJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Profiles of HoundifyExplorerConfigJSON has too few elements.");
        List< HoundifyExplorerProfileJSON  > vector_Profiles1 = new List< HoundifyExplorerProfileJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HoundifyExplorerProfileJSON convert_classy = HoundifyExplorerProfileJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Profiles1.Add(convert_classy);
          }
        Debug.Assert(vector_Profiles1.Count >= 1);
        initProfiles();
        for (int num1 = 0; num1 < vector_Profiles1.Count; ++num1)
            appendProfiles(vector_Profiles1[num1]);
        for (int num1 = 0; num1 < vector_Profiles1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDefaultProfile(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DefaultProfile of HoundifyExplorerConfigJSON is not a string.");
        setDefaultProfile(json_string.getData());
      }


    public HoundifyExplorerConfigJSON()
      {
        flagHasProfiles = false;
        flagHasDefaultProfile = false;
        storeProfiles = new List< HoundifyExplorerProfileJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasProfiles()
      {
        return flagHasProfiles;
      }

    public int  countOfProfiles()
      {
        Debug.Assert(flagHasProfiles);
        return storeProfiles.Count;
      }

    public HoundifyExplorerProfileJSON   elementOfProfiles(int element_num)
      {
        Debug.Assert(flagHasProfiles);
        return storeProfiles[element_num];
      }

    public List< HoundifyExplorerProfileJSON  >  getProfiles()
      {
        Debug.Assert(flagHasProfiles);
        return storeProfiles;
      }

    public bool  hasDefaultProfile()
      {
        return flagHasDefaultProfile;
      }

    public string  getDefaultProfile()
      {
        Debug.Assert(flagHasDefaultProfile);
        return storeDefaultProfile;
      }


    public virtual int extraHoundifyExplorerConfigComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHoundifyExplorerConfigComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHoundifyExplorerConfigComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHoundifyExplorerConfigLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initProfiles()
      {
        if (flagHasProfiles)
          {
            for (int num1 = 0; num1 < storeProfiles.Count; ++num1)
              {
              }
          }
        flagHasProfiles = true;
        storeProfiles.Clear();
      }
    public void appendProfiles(HoundifyExplorerProfileJSON  to_append)
      {
        if (!flagHasProfiles)
          {
            flagHasProfiles = true;
            storeProfiles.Clear();
          }
        Debug.Assert(flagHasProfiles);
        storeProfiles.Add(to_append);
      }
    public void unsetProfiles()
      {
        if (flagHasProfiles)
          {
            for (int num2 = 0; num2 < storeProfiles.Count; ++num2)
              {
              }
          }
        flagHasProfiles = false;
        storeProfiles.Clear();
      }
    public void setDefaultProfile(string new_value)
      {
        flagHasDefaultProfile = true;
        storeDefaultProfile = new_value;
      }
    public void unsetDefaultProfile()
      {
        flagHasDefaultProfile = false;
      }

    public virtual void extraHoundifyExplorerConfigAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHoundifyExplorerConfigSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHoundifyExplorerConfigLookup(key);
        if (old_field == null)
          {
            extraHoundifyExplorerConfigAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasProfiles);
        if (flagHasProfiles)
          {
            handler.start_pair("Profiles");
            Debug.Assert(storeProfiles.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeProfiles.Count; ++num1)
              {
                if (partial_allowed)
                    storeProfiles[num1].write_partial_as_json(handler);
                else
                    storeProfiles[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasDefaultProfile);
        if (flagHasDefaultProfile)
          {
            handler.start_pair("DefaultProfile");
            handler.string_value(storeDefaultProfile);
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
        if (!(hasProfiles()))
          {
            return "When parsing the object for %what%, the \"Profiles\" field was missing.";
          }
        if (!(hasDefaultProfile()))
          {
            return "When parsing the object for %what%, the \"DefaultProfile\" field was missing.";
          }
        return null;
      }

    public static HoundifyExplorerConfigJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundifyExplorerConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundifyExplorerConfig", ignore_extras);
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
    public static HoundifyExplorerConfigJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundifyExplorerConfigJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HoundifyExplorerConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundifyExplorerConfig", ignore_extras);
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
    public static HoundifyExplorerConfigJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HoundifyExplorerConfigJSON from_text(string text, bool ignore_extras)
      {
        HoundifyExplorerConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundifyExplorerConfig", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HoundifyExplorerConfigJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HoundifyExplorerConfigJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HoundifyExplorerConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HoundifyExplorerConfig", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private HoundifyExplorerProfileJSON.HoldingArrayGenerator fieldGeneratorProfiles;
        private JSONHoldingStringGenerator fieldGeneratorDefaultProfile;
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
            HoundifyExplorerConfigJSON result = new HoundifyExplorerConfigJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHoundifyExplorerConfigAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HoundifyExplorerConfigJSON result)
          {
            if (fieldGeneratorProfiles.have_value)
              {
                result.initProfiles();
                int count = fieldGeneratorProfiles.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendProfiles(fieldGeneratorProfiles.value[num]);
                  }
                fieldGeneratorProfiles.value.Clear();
                fieldGeneratorProfiles.have_value = false;
              }
            else if ((!(result.hasProfiles())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Profiles\" field was missing.");
              }
            if (fieldGeneratorDefaultProfile.have_value)
              {
                result.setDefaultProfile(fieldGeneratorDefaultProfile.value);
                fieldGeneratorDefaultProfile.have_value = false;
              }
            else if ((!(result.hasDefaultProfile())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DefaultProfile\" field was missing.");
              }
          }
        protected abstract void handle_result(HoundifyExplorerConfigJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "efaultProfile", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorDefaultProfile;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rofiles", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorProfiles;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorProfiles = new HoundifyExplorerProfileJSON.HoldingArrayGenerator("field \"Profiles\" of the HoundifyExplorerConfig class", ignore_extras);
            fieldGeneratorDefaultProfile = new JSONHoldingStringGenerator("field \"DefaultProfile\" of the HoundifyExplorerConfig class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HoundifyExplorerConfig class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorProfiles = new HoundifyExplorerProfileJSON.HoldingArrayGenerator("field \"Profiles\" of the HoundifyExplorerConfig class", false);
            fieldGeneratorDefaultProfile = new JSONHoldingStringGenerator("field \"DefaultProfile\" of the HoundifyExplorerConfig class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HoundifyExplorerConfig class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorProfiles.reset();
            fieldGeneratorDefaultProfile.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorProfiles.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorProfiles.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HoundifyExplorerConfigJSON  result)
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
        public HoundifyExplorerConfigJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HoundifyExplorerConfigJSON  result)
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
    protected virtual void handle_result(List<HoundifyExplorerConfigJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HoundifyExplorerConfigJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HoundifyExplorerConfigJSON>();
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
    public List<HoundifyExplorerConfigJSON> value;
  };
  };
