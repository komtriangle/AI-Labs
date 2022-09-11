/* file "BusinessInformationUploadedDataStoreJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class BusinessInformationUploadedDataStoreJSON : JSONBase
  {
    private bool flagHasStoreId;
    private string storeStoreId;
    private bool flagHasLocation;
    private MapLocationJSON  storeLocation;
    private bool flagHasIntersection;
    private MapLocationJSON  storeIntersection;
    private bool flagHasStoreHours;
    private WeeklyOperatingHoursJSON  storeStoreHours;
    private bool flagHasPhoneEntries;
    private List< BusinessInformationDataPhoneNumberJSON  > storePhoneEntries;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStoreId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field StoreId of BusinessInformationUploadedDataStoreJSON is not a string.");
        setStoreId(json_string.getData());
      }


    private void  fromJSONLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setLocation(convert_classy);
      }


    private void  fromJSONIntersection(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setIntersection(convert_classy);
      }


    private void  fromJSONStoreHours(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        WeeklyOperatingHoursJSON convert_classy = WeeklyOperatingHoursJSON.from_json(json_value, ignore_extras, true);
        setStoreHours(convert_classy);
      }


    private void  fromJSONPhoneEntries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PhoneEntries of BusinessInformationUploadedDataStoreJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BusinessInformationDataPhoneNumberJSON  > vector_PhoneEntries1 = new List< BusinessInformationDataPhoneNumberJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BusinessInformationDataPhoneNumberJSON convert_classy = BusinessInformationDataPhoneNumberJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_PhoneEntries1.Add(convert_classy);
          }
        initPhoneEntries();
        for (int num1 = 0; num1 < vector_PhoneEntries1.Count; ++num1)
            appendPhoneEntries(vector_PhoneEntries1[num1]);
        for (int num1 = 0; num1 < vector_PhoneEntries1.Count; ++num1)
          {
          }
      }


    public BusinessInformationUploadedDataStoreJSON()
      {
        flagHasStoreId = false;
        flagHasLocation = false;
        flagHasIntersection = false;
        flagHasStoreHours = false;
        flagHasPhoneEntries = false;
        storePhoneEntries = new List< BusinessInformationDataPhoneNumberJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStoreId()
      {
        return flagHasStoreId;
      }

    public string  getStoreId()
      {
        Debug.Assert(flagHasStoreId);
        return storeStoreId;
      }

    public bool  hasLocation()
      {
        return flagHasLocation;
      }

    public MapLocationJSON   getLocation()
      {
        Debug.Assert(flagHasLocation);
        return storeLocation;
      }

    public bool  hasIntersection()
      {
        return flagHasIntersection;
      }

    public MapLocationJSON   getIntersection()
      {
        Debug.Assert(flagHasIntersection);
        return storeIntersection;
      }

    public bool  hasStoreHours()
      {
        return flagHasStoreHours;
      }

    public WeeklyOperatingHoursJSON   getStoreHours()
      {
        Debug.Assert(flagHasStoreHours);
        return storeStoreHours;
      }

    public bool  hasPhoneEntries()
      {
        return flagHasPhoneEntries;
      }

    public int  countOfPhoneEntries()
      {
        Debug.Assert(flagHasPhoneEntries);
        return storePhoneEntries.Count;
      }

    public BusinessInformationDataPhoneNumberJSON   elementOfPhoneEntries(int element_num)
      {
        Debug.Assert(flagHasPhoneEntries);
        return storePhoneEntries[element_num];
      }

    public List< BusinessInformationDataPhoneNumberJSON  >  getPhoneEntries()
      {
        Debug.Assert(flagHasPhoneEntries);
        return storePhoneEntries;
      }


    public virtual int extraBusinessInformationUploadedDataStoreComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBusinessInformationUploadedDataStoreComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBusinessInformationUploadedDataStoreComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBusinessInformationUploadedDataStoreLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStoreId(string new_value)
      {
        flagHasStoreId = true;
        storeStoreId = new_value;
      }
    public void unsetStoreId()
      {
        flagHasStoreId = false;
      }
    public void setLocation(MapLocationJSON  new_value)
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = true;
        storeLocation = new_value;
      }
    public void unsetLocation()
      {
        if (flagHasLocation)
          {
          }
        flagHasLocation = false;
      }
    public void setIntersection(MapLocationJSON  new_value)
      {
        if (flagHasIntersection)
          {
          }
        flagHasIntersection = true;
        storeIntersection = new_value;
      }
    public void unsetIntersection()
      {
        if (flagHasIntersection)
          {
          }
        flagHasIntersection = false;
      }
    public void setStoreHours(WeeklyOperatingHoursJSON  new_value)
      {
        if (flagHasStoreHours)
          {
          }
        flagHasStoreHours = true;
        storeStoreHours = new_value;
      }
    public void unsetStoreHours()
      {
        if (flagHasStoreHours)
          {
          }
        flagHasStoreHours = false;
      }
    public void initPhoneEntries()
      {
        if (flagHasPhoneEntries)
          {
            for (int num1 = 0; num1 < storePhoneEntries.Count; ++num1)
              {
              }
          }
        flagHasPhoneEntries = true;
        storePhoneEntries.Clear();
      }
    public void appendPhoneEntries(BusinessInformationDataPhoneNumberJSON  to_append)
      {
        if (!flagHasPhoneEntries)
          {
            flagHasPhoneEntries = true;
            storePhoneEntries.Clear();
          }
        Debug.Assert(flagHasPhoneEntries);
        storePhoneEntries.Add(to_append);
      }
    public void unsetPhoneEntries()
      {
        if (flagHasPhoneEntries)
          {
            for (int num2 = 0; num2 < storePhoneEntries.Count; ++num2)
              {
              }
          }
        flagHasPhoneEntries = false;
        storePhoneEntries.Clear();
      }

    public virtual void extraBusinessInformationUploadedDataStoreAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBusinessInformationUploadedDataStoreSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBusinessInformationUploadedDataStoreLookup(key);
        if (old_field == null)
          {
            extraBusinessInformationUploadedDataStoreAppendPair(key, new_component);
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
        if (flagHasStoreId)
          {
            handler.start_pair("StoreId");
            handler.string_value(storeStoreId);
          }
        if (flagHasLocation)
          {
            handler.start_pair("Location");
            if (partial_allowed)
                storeLocation.write_partial_as_json(handler);
            else
                storeLocation.write_as_json(handler);
          }
        if (flagHasIntersection)
          {
            handler.start_pair("Intersection");
            if (partial_allowed)
                storeIntersection.write_partial_as_json(handler);
            else
                storeIntersection.write_as_json(handler);
          }
        if (flagHasStoreHours)
          {
            handler.start_pair("StoreHours");
            if (partial_allowed)
                storeStoreHours.write_partial_as_json(handler);
            else
                storeStoreHours.write_as_json(handler);
          }
        if (flagHasPhoneEntries)
          {
            handler.start_pair("PhoneEntries");
            handler.start_array();
            for (int num1 = 0; num1 < storePhoneEntries.Count; ++num1)
              {
                if (partial_allowed)
                    storePhoneEntries[num1].write_partial_as_json(handler);
                else
                    storePhoneEntries[num1].write_as_json(handler);
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

    public static BusinessInformationUploadedDataStoreJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BusinessInformationUploadedDataStoreJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationUploadedDataStore", ignore_extras);
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
    public static BusinessInformationUploadedDataStoreJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BusinessInformationUploadedDataStoreJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BusinessInformationUploadedDataStoreJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationUploadedDataStore", ignore_extras);
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
    public static BusinessInformationUploadedDataStoreJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BusinessInformationUploadedDataStoreJSON from_text(string text, bool ignore_extras)
      {
        BusinessInformationUploadedDataStoreJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationUploadedDataStore", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BusinessInformationUploadedDataStoreJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BusinessInformationUploadedDataStoreJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BusinessInformationUploadedDataStoreJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BusinessInformationUploadedDataStore", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorStoreId;
        private MapLocationJSON.HoldingGenerator fieldGeneratorLocation;
        private MapLocationJSON.HoldingGenerator fieldGeneratorIntersection;
        private WeeklyOperatingHoursJSON.HoldingGenerator fieldGeneratorStoreHours;
        private BusinessInformationDataPhoneNumberJSON.HoldingArrayGenerator fieldGeneratorPhoneEntries;
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
            BusinessInformationUploadedDataStoreJSON result = new BusinessInformationUploadedDataStoreJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBusinessInformationUploadedDataStoreAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BusinessInformationUploadedDataStoreJSON result)
          {
            if (fieldGeneratorStoreId.have_value)
              {
                result.setStoreId(fieldGeneratorStoreId.value);
                fieldGeneratorStoreId.have_value = false;
              }
            if (fieldGeneratorLocation.have_value)
              {
                result.setLocation(fieldGeneratorLocation.value);
                fieldGeneratorLocation.have_value = false;
              }
            if (fieldGeneratorIntersection.have_value)
              {
                result.setIntersection(fieldGeneratorIntersection.value);
                fieldGeneratorIntersection.have_value = false;
              }
            if (fieldGeneratorStoreHours.have_value)
              {
                result.setStoreHours(fieldGeneratorStoreHours.value);
                fieldGeneratorStoreHours.have_value = false;
              }
            if (fieldGeneratorPhoneEntries.have_value)
              {
                result.initPhoneEntries();
                int count = fieldGeneratorPhoneEntries.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPhoneEntries(fieldGeneratorPhoneEntries.value[num]);
                  }
                fieldGeneratorPhoneEntries.value.Clear();
                fieldGeneratorPhoneEntries.have_value = false;
              }
          }
        protected abstract void handle_result(BusinessInformationUploadedDataStoreJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "ntersection", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorIntersection;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocation", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorLocation;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "honeEntries", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorPhoneEntries;
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "tore", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'H':
                                if ((String.Compare(field_name, 6, "ours", 0, 4, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorStoreHours;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 6, "d", 0, 1, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorStoreId;
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
            fieldGeneratorStoreId = new JSONHoldingStringGenerator("field \"StoreId\" of the BusinessInformationUploadedDataStore class");
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the BusinessInformationUploadedDataStore class", ignore_extras);
            fieldGeneratorIntersection = new MapLocationJSON.HoldingGenerator("field \"Intersection\" of the BusinessInformationUploadedDataStore class", ignore_extras);
            fieldGeneratorStoreHours = new WeeklyOperatingHoursJSON.HoldingGenerator("field \"StoreHours\" of the BusinessInformationUploadedDataStore class", ignore_extras);
            fieldGeneratorPhoneEntries = new BusinessInformationDataPhoneNumberJSON.HoldingArrayGenerator("field \"PhoneEntries\" of the BusinessInformationUploadedDataStore class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BusinessInformationUploadedDataStore class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStoreId = new JSONHoldingStringGenerator("field \"StoreId\" of the BusinessInformationUploadedDataStore class");
            fieldGeneratorLocation = new MapLocationJSON.HoldingGenerator("field \"Location\" of the BusinessInformationUploadedDataStore class", false);
            fieldGeneratorIntersection = new MapLocationJSON.HoldingGenerator("field \"Intersection\" of the BusinessInformationUploadedDataStore class", false);
            fieldGeneratorStoreHours = new WeeklyOperatingHoursJSON.HoldingGenerator("field \"StoreHours\" of the BusinessInformationUploadedDataStore class", false);
            fieldGeneratorPhoneEntries = new BusinessInformationDataPhoneNumberJSON.HoldingArrayGenerator("field \"PhoneEntries\" of the BusinessInformationUploadedDataStore class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BusinessInformationUploadedDataStore class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStoreId.reset();
            fieldGeneratorLocation.reset();
            fieldGeneratorIntersection.reset();
            fieldGeneratorStoreHours.reset();
            fieldGeneratorPhoneEntries.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIntersection.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStoreHours.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPhoneEntries.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIntersection.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStoreHours.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPhoneEntries.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(BusinessInformationUploadedDataStoreJSON  result)
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
        public BusinessInformationUploadedDataStoreJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BusinessInformationUploadedDataStoreJSON  result)
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
    protected virtual void handle_result(List<BusinessInformationUploadedDataStoreJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BusinessInformationUploadedDataStoreJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BusinessInformationUploadedDataStoreJSON>();
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
    public List<BusinessInformationUploadedDataStoreJSON> value;
  };
  };
