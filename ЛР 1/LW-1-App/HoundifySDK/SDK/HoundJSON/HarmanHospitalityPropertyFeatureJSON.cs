/* file "HarmanHospitalityPropertyFeatureJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HarmanHospitalityPropertyFeatureJSON : JSONBase
  {
    private bool flagHasId;
    private string storeId;
    private bool flagHasName;
    private string storeName;
    private bool flagHasFeatureType;
    private string storeFeatureType;
    private bool flagHasLocation;
    private string storeLocation;
    private bool flagHasContact;
    private string storeContact;
    private bool flagHasSchedules;
    private List< HarmanHospitalityPropertyFeatureScheduleJSON  > storeSchedules;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Id of HarmanHospitalityPropertyFeatureJSON is not a string.");
        setId(json_string.getData());
      }


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of HarmanHospitalityPropertyFeatureJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONFeatureType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field FeatureType of HarmanHospitalityPropertyFeatureJSON is not a string.");
        setFeatureType(json_string.getData());
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Location of HarmanHospitalityPropertyFeatureJSON is not a string.");
        setLocation(json_string.getData());
      }


    private void  fromJSONContact(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Contact of HarmanHospitalityPropertyFeatureJSON is not a string.");
        setContact(json_string.getData());
      }


    private void  fromJSONSchedules(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Schedules of HarmanHospitalityPropertyFeatureJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HarmanHospitalityPropertyFeatureScheduleJSON  > vector_Schedules1 = new List< HarmanHospitalityPropertyFeatureScheduleJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HarmanHospitalityPropertyFeatureScheduleJSON convert_classy = HarmanHospitalityPropertyFeatureScheduleJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Schedules1.Add(convert_classy);
          }
        initSchedules();
        for (int num1 = 0; num1 < vector_Schedules1.Count; ++num1)
            appendSchedules(vector_Schedules1[num1]);
        for (int num1 = 0; num1 < vector_Schedules1.Count; ++num1)
          {
          }
      }


    public HarmanHospitalityPropertyFeatureJSON()
      {
        flagHasId = false;
        flagHasName = false;
        flagHasFeatureType = false;
        flagHasLocation = false;
        flagHasContact = false;
        flagHasSchedules = false;
        storeSchedules = new List< HarmanHospitalityPropertyFeatureScheduleJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasId()
      {
        return flagHasId;
      }

    public string  getId()
      {
        Debug.Assert(flagHasId);
        return storeId;
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

    public bool  hasFeatureType()
      {
        return flagHasFeatureType;
      }

    public string  getFeatureType()
      {
        Debug.Assert(flagHasFeatureType);
        return storeFeatureType;
      }

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public string  getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }

    public bool  hasContact()
      {
        return flagHasContact;
      }

    public string  getContact()
      {
        Debug.Assert(flagHasContact);
        return storeContact;
      }

    public bool  hasSchedules()
      {
        return flagHasSchedules;
      }

    public int  countOfSchedules()
      {
        Debug.Assert(flagHasSchedules);
        return storeSchedules.Count;
      }

    public HarmanHospitalityPropertyFeatureScheduleJSON   elementOfSchedules(int element_num)
      {
        Debug.Assert(flagHasSchedules);
        return storeSchedules[element_num];
      }

    public List< HarmanHospitalityPropertyFeatureScheduleJSON  >  getSchedules()
      {
        Debug.Assert(flagHasSchedules);
        return storeSchedules;
      }


    public virtual int extraHarmanHospitalityPropertyFeatureComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHarmanHospitalityPropertyFeatureComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHarmanHospitalityPropertyFeatureComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHarmanHospitalityPropertyFeatureLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setId(string new_value)
      {
        flagHasId = true;
        storeId = new_value;
      }
    public void unsetId()
      {
        flagHasId = false;
      }
    public void setName(string new_value)
      {
        flagHasName = true;
        storeName = new_value;
      }
    public void unsetName()
      {
        flagHasName = false;
      }
    public void setFeatureType(string new_value)
      {
        flagHasFeatureType = true;
        storeFeatureType = new_value;
      }
    public void unsetFeatureType()
      {
        flagHasFeatureType = false;
      }
    public void setLocation(string new_value)
      {
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        flagHasLocation = false;
      }
    public void setContact(string new_value)
      {
        flagHasContact = true;
        storeContact = new_value;
      }
    public void unsetContact()
      {
        flagHasContact = false;
      }
    public void initSchedules()
      {
        if (flagHasSchedules)
          {
            for (int num1 = 0; num1 < storeSchedules.Count; ++num1)
              {
              }
          }
        flagHasSchedules = true;
        storeSchedules.Clear();
      }
    public void appendSchedules(HarmanHospitalityPropertyFeatureScheduleJSON  to_append)
      {
        if (!flagHasSchedules)
          {
            flagHasSchedules = true;
            storeSchedules.Clear();
          }
        Debug.Assert(flagHasSchedules);
        storeSchedules.Add(to_append);
      }
    public void unsetSchedules()
      {
        if (flagHasSchedules)
          {
            for (int num2 = 0; num2 < storeSchedules.Count; ++num2)
              {
              }
          }
        flagHasSchedules = false;
        storeSchedules.Clear();
      }

    public virtual void extraHarmanHospitalityPropertyFeatureAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHarmanHospitalityPropertyFeatureSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHarmanHospitalityPropertyFeatureLookup(key);
        if (old_field == null)
          {
            extraHarmanHospitalityPropertyFeatureAppendPair(key, new_component);
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
        if (flagHasId)
          {
            handler.start_pair("Id");
            handler.string_value(storeId);
          }
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        if (flagHasFeatureType)
          {
            handler.start_pair("FeatureType");
            handler.string_value(storeFeatureType);
          }
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            handler.string_value(storeLocation);
          }
        if (flagHasContact)
          {
            handler.start_pair("Contact");
            handler.string_value(storeContact);
          }
        if (flagHasSchedules)
          {
            handler.start_pair("Schedules");
            handler.start_array();
            for (int num1 = 0; num1 < storeSchedules.Count; ++num1)
              {
                if (partial_allowed)
                    storeSchedules[num1].write_partial_as_json(handler);
                else
                    storeSchedules[num1].write_as_json(handler);
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

    public static HarmanHospitalityPropertyFeatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanHospitalityPropertyFeatureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityPropertyFeature", ignore_extras);
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
    public static HarmanHospitalityPropertyFeatureJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanHospitalityPropertyFeatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanHospitalityPropertyFeatureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityPropertyFeature", ignore_extras);
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
    public static HarmanHospitalityPropertyFeatureJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanHospitalityPropertyFeatureJSON from_text(string text, bool ignore_extras)
      {
        HarmanHospitalityPropertyFeatureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityPropertyFeature", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HarmanHospitalityPropertyFeatureJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HarmanHospitalityPropertyFeatureJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HarmanHospitalityPropertyFeatureJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanHospitalityPropertyFeature", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorId;
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorFeatureType;
        private JSONHoldingStringGenerator fieldGeneratorLocation;
        private JSONHoldingStringGenerator fieldGeneratorContact;
        private HarmanHospitalityPropertyFeatureScheduleJSON.HoldingArrayGenerator fieldGeneratorSchedules;
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
            HarmanHospitalityPropertyFeatureJSON result = new HarmanHospitalityPropertyFeatureJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHarmanHospitalityPropertyFeatureAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HarmanHospitalityPropertyFeatureJSON result)
          {
            if (fieldGeneratorId.have_value)
              {
                result.setId(fieldGeneratorId.value);
                fieldGeneratorId.have_value = false;
              }
            if (fieldGeneratorName.have_value)
              {
                result.setName(fieldGeneratorName.value);
                fieldGeneratorName.have_value = false;
              }
            else if ((!(result.hasName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Name\" field was missing.");
              }
            if (fieldGeneratorFeatureType.have_value)
              {
                result.setFeatureType(fieldGeneratorFeatureType.value);
                fieldGeneratorFeatureType.have_value = false;
              }
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            if (fieldGeneratorContact.have_value)
              {
                result.setContact(fieldGeneratorContact.value);
                fieldGeneratorContact.have_value = false;
              }
            if (fieldGeneratorSchedules.have_value)
              {
                result.initSchedules();
                int count = fieldGeneratorSchedules.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSchedules(fieldGeneratorSchedules.value[num]);
                  }
                fieldGeneratorSchedules.value.Clear();
                fieldGeneratorSchedules.have_value = false;
              }
          }
        protected abstract void handle_result(HarmanHospitalityPropertyFeatureJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ontact", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorContact;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "eatureType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorFeatureType;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "d", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorId;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "chedules", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorSchedules;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorId = new JSONHoldingStringGenerator("field \"Id\" of the HarmanHospitalityPropertyFeature class");
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the HarmanHospitalityPropertyFeature class");
            fieldGeneratorFeatureType = new JSONHoldingStringGenerator("field \"FeatureType\" of the HarmanHospitalityPropertyFeature class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the HarmanHospitalityPropertyFeature class");
            fieldGeneratorContact = new JSONHoldingStringGenerator("field \"Contact\" of the HarmanHospitalityPropertyFeature class");
            fieldGeneratorSchedules = new HarmanHospitalityPropertyFeatureScheduleJSON.HoldingArrayGenerator("field \"Schedules\" of the HarmanHospitalityPropertyFeature class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HarmanHospitalityPropertyFeature class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorId = new JSONHoldingStringGenerator("field \"Id\" of the HarmanHospitalityPropertyFeature class");
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the HarmanHospitalityPropertyFeature class");
            fieldGeneratorFeatureType = new JSONHoldingStringGenerator("field \"FeatureType\" of the HarmanHospitalityPropertyFeature class");
            fieldGeneratorLocation = new JSONHoldingStringGenerator("field \"Location\" of the HarmanHospitalityPropertyFeature class");
            fieldGeneratorContact = new JSONHoldingStringGenerator("field \"Contact\" of the HarmanHospitalityPropertyFeature class");
            fieldGeneratorSchedules = new HarmanHospitalityPropertyFeatureScheduleJSON.HoldingArrayGenerator("field \"Schedules\" of the HarmanHospitalityPropertyFeature class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HarmanHospitalityPropertyFeature class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorId.reset();
            fieldGeneratorName.reset();
            fieldGeneratorFeatureType.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorContact.reset();
            fieldGeneratorSchedules.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSchedules.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSchedules.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HarmanHospitalityPropertyFeatureJSON  result)
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
        public HarmanHospitalityPropertyFeatureJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HarmanHospitalityPropertyFeatureJSON  result)
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
    protected virtual void handle_result(List<HarmanHospitalityPropertyFeatureJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HarmanHospitalityPropertyFeatureJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HarmanHospitalityPropertyFeatureJSON>();
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
    public List<HarmanHospitalityPropertyFeatureJSON> value;
  };
  };
