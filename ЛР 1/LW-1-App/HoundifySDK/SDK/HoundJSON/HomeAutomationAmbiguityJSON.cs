/* file "HomeAutomationAmbiguityJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationAmbiguityJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasGroups;
    private HomeAutomationGroupListJSON  storeGroups;
    private bool flagHasGroupAmbiguityFlags;
    private List< HomeAutomationAmbiguityFlagsJSON  > storeGroupAmbiguityFlags;
    private bool flagHasDevices;
    private HomeAutomationDeviceListJSON  storeDevices;
    private bool flagHasDeviceAmbiguityFlags;
    private List< HomeAutomationAmbiguityFlagsJSON  > storeDeviceAmbiguityFlags;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of HomeAutomationAmbiguityJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONGroups(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationGroupListJSON convert_classy = HomeAutomationGroupListJSON.from_json(json_value, ignore_extras, true);
        setGroups(convert_classy);
      }


    private void  fromJSONGroupAmbiguityFlags(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GroupAmbiguityFlags of HomeAutomationAmbiguityJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field GroupAmbiguityFlags of HomeAutomationAmbiguityJSON has too few elements.");
        List< HomeAutomationAmbiguityFlagsJSON  > vector_GroupAmbiguityFlags1 = new List< HomeAutomationAmbiguityFlagsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HomeAutomationAmbiguityFlagsJSON convert_classy = HomeAutomationAmbiguityFlagsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_GroupAmbiguityFlags1.Add(convert_classy);
          }
        Debug.Assert(vector_GroupAmbiguityFlags1.Count >= 1);
        initGroupAmbiguityFlags();
        for (int num1 = 0; num1 < vector_GroupAmbiguityFlags1.Count; ++num1)
            appendGroupAmbiguityFlags(vector_GroupAmbiguityFlags1[num1]);
        for (int num1 = 0; num1 < vector_GroupAmbiguityFlags1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDevices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationDeviceListJSON convert_classy = HomeAutomationDeviceListJSON.from_json(json_value, ignore_extras, true);
        setDevices(convert_classy);
      }


    private void  fromJSONDeviceAmbiguityFlags(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DeviceAmbiguityFlags of HomeAutomationAmbiguityJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field DeviceAmbiguityFlags of HomeAutomationAmbiguityJSON has too few elements.");
        List< HomeAutomationAmbiguityFlagsJSON  > vector_DeviceAmbiguityFlags1 = new List< HomeAutomationAmbiguityFlagsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HomeAutomationAmbiguityFlagsJSON convert_classy = HomeAutomationAmbiguityFlagsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_DeviceAmbiguityFlags1.Add(convert_classy);
          }
        Debug.Assert(vector_DeviceAmbiguityFlags1.Count >= 1);
        initDeviceAmbiguityFlags();
        for (int num2 = 0; num2 < vector_DeviceAmbiguityFlags1.Count; ++num2)
            appendDeviceAmbiguityFlags(vector_DeviceAmbiguityFlags1[num2]);
        for (int num1 = 0; num1 < vector_DeviceAmbiguityFlags1.Count; ++num1)
          {
          }
      }


    public HomeAutomationAmbiguityJSON()
      {
        flagHasName = false;
        flagHasGroups = false;
        flagHasGroupAmbiguityFlags = false;
        flagHasDevices = false;
        flagHasDeviceAmbiguityFlags = false;
        storeGroupAmbiguityFlags = new List< HomeAutomationAmbiguityFlagsJSON  >();
        storeDeviceAmbiguityFlags = new List< HomeAutomationAmbiguityFlagsJSON  >();
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

    public bool  hasGroups()
      {
        return flagHasGroups;
      }

    public HomeAutomationGroupListJSON   getGroups()
      {
        Debug.Assert(flagHasGroups);
        return storeGroups;
      }

    public bool  hasGroupAmbiguityFlags()
      {
        return flagHasGroupAmbiguityFlags;
      }

    public int  countOfGroupAmbiguityFlags()
      {
        Debug.Assert(flagHasGroupAmbiguityFlags);
        return storeGroupAmbiguityFlags.Count;
      }

    public HomeAutomationAmbiguityFlagsJSON   elementOfGroupAmbiguityFlags(int element_num)
      {
        Debug.Assert(flagHasGroupAmbiguityFlags);
        return storeGroupAmbiguityFlags[element_num];
      }

    public List< HomeAutomationAmbiguityFlagsJSON  >  getGroupAmbiguityFlags()
      {
        Debug.Assert(flagHasGroupAmbiguityFlags);
        return storeGroupAmbiguityFlags;
      }

    public bool  hasDevices()
      {
        return flagHasDevices;
      }

    public HomeAutomationDeviceListJSON   getDevices()
      {
        Debug.Assert(flagHasDevices);
        return storeDevices;
      }

    public bool  hasDeviceAmbiguityFlags()
      {
        return flagHasDeviceAmbiguityFlags;
      }

    public int  countOfDeviceAmbiguityFlags()
      {
        Debug.Assert(flagHasDeviceAmbiguityFlags);
        return storeDeviceAmbiguityFlags.Count;
      }

    public HomeAutomationAmbiguityFlagsJSON   elementOfDeviceAmbiguityFlags(int element_num)
      {
        Debug.Assert(flagHasDeviceAmbiguityFlags);
        return storeDeviceAmbiguityFlags[element_num];
      }

    public List< HomeAutomationAmbiguityFlagsJSON  >  getDeviceAmbiguityFlags()
      {
        Debug.Assert(flagHasDeviceAmbiguityFlags);
        return storeDeviceAmbiguityFlags;
      }


    public virtual int extraHomeAutomationAmbiguityComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationAmbiguityComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationAmbiguityComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationAmbiguityLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
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
    public void setGroups(HomeAutomationGroupListJSON  new_value)
      {
        if (flagHasGroups)
          {
          }
        flagHasGroups = true;
        storeGroups = new_value;
      }
    public void unsetGroups()
      {
        if (flagHasGroups)
          {
          }
        flagHasGroups = false;
      }
    public void initGroupAmbiguityFlags()
      {
        if (flagHasGroupAmbiguityFlags)
          {
            for (int num1 = 0; num1 < storeGroupAmbiguityFlags.Count; ++num1)
              {
              }
          }
        flagHasGroupAmbiguityFlags = true;
        storeGroupAmbiguityFlags.Clear();
      }
    public void appendGroupAmbiguityFlags(HomeAutomationAmbiguityFlagsJSON  to_append)
      {
        if (!flagHasGroupAmbiguityFlags)
          {
            flagHasGroupAmbiguityFlags = true;
            storeGroupAmbiguityFlags.Clear();
          }
        Debug.Assert(flagHasGroupAmbiguityFlags);
        storeGroupAmbiguityFlags.Add(to_append);
      }
    public void unsetGroupAmbiguityFlags()
      {
        if (flagHasGroupAmbiguityFlags)
          {
            for (int num2 = 0; num2 < storeGroupAmbiguityFlags.Count; ++num2)
              {
              }
          }
        flagHasGroupAmbiguityFlags = false;
        storeGroupAmbiguityFlags.Clear();
      }
    public void setDevices(HomeAutomationDeviceListJSON  new_value)
      {
        if (flagHasDevices)
          {
          }
        flagHasDevices = true;
        storeDevices = new_value;
      }
    public void unsetDevices()
      {
        if (flagHasDevices)
          {
          }
        flagHasDevices = false;
      }
    public void initDeviceAmbiguityFlags()
      {
        if (flagHasDeviceAmbiguityFlags)
          {
            for (int num3 = 0; num3 < storeDeviceAmbiguityFlags.Count; ++num3)
              {
              }
          }
        flagHasDeviceAmbiguityFlags = true;
        storeDeviceAmbiguityFlags.Clear();
      }
    public void appendDeviceAmbiguityFlags(HomeAutomationAmbiguityFlagsJSON  to_append)
      {
        if (!flagHasDeviceAmbiguityFlags)
          {
            flagHasDeviceAmbiguityFlags = true;
            storeDeviceAmbiguityFlags.Clear();
          }
        Debug.Assert(flagHasDeviceAmbiguityFlags);
        storeDeviceAmbiguityFlags.Add(to_append);
      }
    public void unsetDeviceAmbiguityFlags()
      {
        if (flagHasDeviceAmbiguityFlags)
          {
            for (int num4 = 0; num4 < storeDeviceAmbiguityFlags.Count; ++num4)
              {
              }
          }
        flagHasDeviceAmbiguityFlags = false;
        storeDeviceAmbiguityFlags.Clear();
      }

    public virtual void extraHomeAutomationAmbiguityAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationAmbiguitySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationAmbiguityLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationAmbiguityAppendPair(key, new_component);
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
        if (flagHasGroups)
          {
            handler.start_pair("Groups");
            if (partial_allowed)
                storeGroups.write_partial_as_json(handler);
            else
                storeGroups.write_as_json(handler);
          }
        if (flagHasGroupAmbiguityFlags)
          {
            handler.start_pair("GroupAmbiguityFlags");
            Debug.Assert(storeGroupAmbiguityFlags.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeGroupAmbiguityFlags.Count; ++num1)
              {
                if (partial_allowed)
                    storeGroupAmbiguityFlags[num1].write_partial_as_json(handler);
                else
                    storeGroupAmbiguityFlags[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDevices)
          {
            handler.start_pair("Devices");
            if (partial_allowed)
                storeDevices.write_partial_as_json(handler);
            else
                storeDevices.write_as_json(handler);
          }
        if (flagHasDeviceAmbiguityFlags)
          {
            handler.start_pair("DeviceAmbiguityFlags");
            Debug.Assert(storeDeviceAmbiguityFlags.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeDeviceAmbiguityFlags.Count; ++num2)
              {
                if (partial_allowed)
                    storeDeviceAmbiguityFlags[num2].write_partial_as_json(handler);
                else
                    storeDeviceAmbiguityFlags[num2].write_as_json(handler);
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

    public static HomeAutomationAmbiguityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationAmbiguityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationAmbiguity", ignore_extras);
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
    public static HomeAutomationAmbiguityJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationAmbiguityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationAmbiguityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationAmbiguity", ignore_extras);
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
    public static HomeAutomationAmbiguityJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationAmbiguityJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationAmbiguityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationAmbiguity", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationAmbiguityJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationAmbiguityJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationAmbiguityJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationAmbiguity", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private HomeAutomationGroupListJSON.HoldingGenerator fieldGeneratorGroups;
        private HomeAutomationAmbiguityFlagsJSON.HoldingArrayGenerator fieldGeneratorGroupAmbiguityFlags;
        private HomeAutomationDeviceListJSON.HoldingGenerator fieldGeneratorDevices;
        private HomeAutomationAmbiguityFlagsJSON.HoldingArrayGenerator fieldGeneratorDeviceAmbiguityFlags;
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
            HomeAutomationAmbiguityJSON result = new HomeAutomationAmbiguityJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationAmbiguityAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationAmbiguityJSON result)
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
            if (fieldGeneratorGroups.have_value)
              {
                result.setGroups(fieldGeneratorGroups.value);
                fieldGeneratorGroups.have_value = false;
              }
            if (fieldGeneratorGroupAmbiguityFlags.have_value)
              {
                result.initGroupAmbiguityFlags();
                int count = fieldGeneratorGroupAmbiguityFlags.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGroupAmbiguityFlags(fieldGeneratorGroupAmbiguityFlags.value[num]);
                  }
                fieldGeneratorGroupAmbiguityFlags.value.Clear();
                fieldGeneratorGroupAmbiguityFlags.have_value = false;
              }
            if (fieldGeneratorDevices.have_value)
              {
                result.setDevices(fieldGeneratorDevices.value);
                fieldGeneratorDevices.have_value = false;
              }
            if (fieldGeneratorDeviceAmbiguityFlags.have_value)
              {
                result.initDeviceAmbiguityFlags();
                int count = fieldGeneratorDeviceAmbiguityFlags.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDeviceAmbiguityFlags(fieldGeneratorDeviceAmbiguityFlags.value[num]);
                  }
                fieldGeneratorDeviceAmbiguityFlags.value.Clear();
                fieldGeneratorDeviceAmbiguityFlags.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationAmbiguityJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if (String.Compare(field_name, 1, "evice", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 7, "mbiguityFlags", 0, 13, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorDeviceAmbiguityFlags;
                                break;
                            case 's':
                                if (field_name.Length == 7)
                                    return fieldGeneratorDevices;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'G':
                    if (String.Compare(field_name, 1, "roup", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 6, "mbiguityFlags", 0, 13, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorGroupAmbiguityFlags;
                                break;
                            case 's':
                                if (field_name.Length == 6)
                                    return fieldGeneratorGroups;
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
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the HomeAutomationAmbiguity class");
            fieldGeneratorGroups = new HomeAutomationGroupListJSON.HoldingGenerator("field \"Groups\" of the HomeAutomationAmbiguity class", ignore_extras);
            fieldGeneratorGroupAmbiguityFlags = new HomeAutomationAmbiguityFlagsJSON.HoldingArrayGenerator("field \"GroupAmbiguityFlags\" of the HomeAutomationAmbiguity class", ignore_extras);
            fieldGeneratorDevices = new HomeAutomationDeviceListJSON.HoldingGenerator("field \"Devices\" of the HomeAutomationAmbiguity class", ignore_extras);
            fieldGeneratorDeviceAmbiguityFlags = new HomeAutomationAmbiguityFlagsJSON.HoldingArrayGenerator("field \"DeviceAmbiguityFlags\" of the HomeAutomationAmbiguity class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationAmbiguity class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the HomeAutomationAmbiguity class");
            fieldGeneratorGroups = new HomeAutomationGroupListJSON.HoldingGenerator("field \"Groups\" of the HomeAutomationAmbiguity class", false);
            fieldGeneratorGroupAmbiguityFlags = new HomeAutomationAmbiguityFlagsJSON.HoldingArrayGenerator("field \"GroupAmbiguityFlags\" of the HomeAutomationAmbiguity class", false);
            fieldGeneratorDevices = new HomeAutomationDeviceListJSON.HoldingGenerator("field \"Devices\" of the HomeAutomationAmbiguity class", false);
            fieldGeneratorDeviceAmbiguityFlags = new HomeAutomationAmbiguityFlagsJSON.HoldingArrayGenerator("field \"DeviceAmbiguityFlags\" of the HomeAutomationAmbiguity class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationAmbiguity class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorGroups.reset();
            fieldGeneratorGroupAmbiguityFlags.reset();
            fieldGeneratorDevices.reset();
            fieldGeneratorDeviceAmbiguityFlags.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorGroups.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGroupAmbiguityFlags.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDevices.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDeviceAmbiguityFlags.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorGroups.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGroupAmbiguityFlags.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDevices.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDeviceAmbiguityFlags.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationAmbiguityJSON  result)
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
        public HomeAutomationAmbiguityJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationAmbiguityJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationAmbiguityJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationAmbiguityJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationAmbiguityJSON>();
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
    public List<HomeAutomationAmbiguityJSON> value;
  };
  };
