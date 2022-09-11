/* file "HarmanHospitalityPropertyInformationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HarmanHospitalityPropertyInformationJSON : JSONBase
  {
    private bool flagHasPropertyId;
    private string storePropertyId;
    private bool flagHasFeatures;
    private List< HarmanHospitalityPropertyFeatureJSON  > storeFeatures;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPropertyId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PropertyId of HarmanHospitalityPropertyInformationJSON is not a string.");
        setPropertyId(json_string.getData());
      }


    private void  fromJSONFeatures(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Features of HarmanHospitalityPropertyInformationJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HarmanHospitalityPropertyFeatureJSON  > vector_Features1 = new List< HarmanHospitalityPropertyFeatureJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HarmanHospitalityPropertyFeatureJSON convert_classy = HarmanHospitalityPropertyFeatureJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Features1.Add(convert_classy);
          }
        initFeatures();
        for (int num1 = 0; num1 < vector_Features1.Count; ++num1)
            appendFeatures(vector_Features1[num1]);
        for (int num1 = 0; num1 < vector_Features1.Count; ++num1)
          {
          }
      }


    public HarmanHospitalityPropertyInformationJSON()
      {
        flagHasPropertyId = false;
        flagHasFeatures = false;
        storeFeatures = new List< HarmanHospitalityPropertyFeatureJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPropertyId()
      {
        return flagHasPropertyId;
      }

    public string  getPropertyId()
      {
        Debug.Assert(flagHasPropertyId);
        return storePropertyId;
      }

    public bool  hasFeatures()
      {
        return flagHasFeatures;
      }

    public int  countOfFeatures()
      {
        Debug.Assert(flagHasFeatures);
        return storeFeatures.Count;
      }

    public HarmanHospitalityPropertyFeatureJSON   elementOfFeatures(int element_num)
      {
        Debug.Assert(flagHasFeatures);
        return storeFeatures[element_num];
      }

    public List< HarmanHospitalityPropertyFeatureJSON  >  getFeatures()
      {
        Debug.Assert(flagHasFeatures);
        return storeFeatures;
      }


    public virtual int extraHarmanHospitalityPropertyInformationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHarmanHospitalityPropertyInformationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHarmanHospitalityPropertyInformationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHarmanHospitalityPropertyInformationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPropertyId(string new_value)
      {
        flagHasPropertyId = true;
        storePropertyId = new_value;
      }
    public void unsetPropertyId()
      {
        flagHasPropertyId = false;
      }
    public void initFeatures()
      {
        if (flagHasFeatures)
          {
            for (int num1 = 0; num1 < storeFeatures.Count; ++num1)
              {
              }
          }
        flagHasFeatures = true;
        storeFeatures.Clear();
      }
    public void appendFeatures(HarmanHospitalityPropertyFeatureJSON  to_append)
      {
        if (!flagHasFeatures)
          {
            flagHasFeatures = true;
            storeFeatures.Clear();
          }
        Debug.Assert(flagHasFeatures);
        storeFeatures.Add(to_append);
      }
    public void unsetFeatures()
      {
        if (flagHasFeatures)
          {
            for (int num2 = 0; num2 < storeFeatures.Count; ++num2)
              {
              }
          }
        flagHasFeatures = false;
        storeFeatures.Clear();
      }

    public virtual void extraHarmanHospitalityPropertyInformationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHarmanHospitalityPropertyInformationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHarmanHospitalityPropertyInformationLookup(key);
        if (old_field == null)
          {
            extraHarmanHospitalityPropertyInformationAppendPair(key, new_component);
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
        if (flagHasPropertyId)
          {
            handler.start_pair("PropertyId");
            handler.string_value(storePropertyId);
          }
        if (flagHasFeatures)
          {
            handler.start_pair("Features");
            handler.start_array();
            for (int num1 = 0; num1 < storeFeatures.Count; ++num1)
              {
                if (partial_allowed)
                    storeFeatures[num1].write_partial_as_json(handler);
                else
                    storeFeatures[num1].write_as_json(handler);
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

    public static HarmanHospitalityPropertyInformationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanHospitalityPropertyInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityPropertyInformation", ignore_extras);
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
    public static HarmanHospitalityPropertyInformationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanHospitalityPropertyInformationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanHospitalityPropertyInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityPropertyInformation", ignore_extras);
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
    public static HarmanHospitalityPropertyInformationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanHospitalityPropertyInformationJSON from_text(string text, bool ignore_extras)
      {
        HarmanHospitalityPropertyInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityPropertyInformation", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HarmanHospitalityPropertyInformationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HarmanHospitalityPropertyInformationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HarmanHospitalityPropertyInformationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityPropertyInformation", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorPropertyId;
        private HarmanHospitalityPropertyFeatureJSON.HoldingArrayGenerator fieldGeneratorFeatures;
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
            HarmanHospitalityPropertyInformationJSON result = new HarmanHospitalityPropertyInformationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHarmanHospitalityPropertyInformationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HarmanHospitalityPropertyInformationJSON result)
          {
            if (fieldGeneratorPropertyId.have_value)
              {
                result.setPropertyId(fieldGeneratorPropertyId.value);
                fieldGeneratorPropertyId.have_value = false;
              }
            if (fieldGeneratorFeatures.have_value)
              {
                result.initFeatures();
                int count = fieldGeneratorFeatures.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFeatures(fieldGeneratorFeatures.value[num]);
                  }
                fieldGeneratorFeatures.value.Clear();
                fieldGeneratorFeatures.have_value = false;
              }
          }
        protected abstract void handle_result(HarmanHospitalityPropertyInformationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    if ((String.Compare(field_name, 1, "eatures", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorFeatures;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ropertyId", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorPropertyId;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPropertyId = new JSONHoldingStringGenerator("field \"PropertyId\" of the HarmanHospitalityPropertyInformation class");
            fieldGeneratorFeatures = new HarmanHospitalityPropertyFeatureJSON.HoldingArrayGenerator("field \"Features\" of the HarmanHospitalityPropertyInformation class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HarmanHospitalityPropertyInformation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPropertyId = new JSONHoldingStringGenerator("field \"PropertyId\" of the HarmanHospitalityPropertyInformation class");
            fieldGeneratorFeatures = new HarmanHospitalityPropertyFeatureJSON.HoldingArrayGenerator("field \"Features\" of the HarmanHospitalityPropertyInformation class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HarmanHospitalityPropertyInformation class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPropertyId.reset();
            fieldGeneratorFeatures.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFeatures.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFeatures.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HarmanHospitalityPropertyInformationJSON  result)
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
        public HarmanHospitalityPropertyInformationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HarmanHospitalityPropertyInformationJSON  result)
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
    protected virtual void handle_result(List<HarmanHospitalityPropertyInformationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HarmanHospitalityPropertyInformationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HarmanHospitalityPropertyInformationJSON>();
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
    public List<HarmanHospitalityPropertyInformationJSON> value;
  };
  };
