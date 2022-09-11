/* file "HarmanDeviceRegistrationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HarmanDeviceRegistrationJSON : JSONBase
  {
    private bool flagHasControllerID;
    private string storeControllerID;
    private bool flagHasEquipment;
    private HomeAutomationDeviceListJSON  storeEquipment;
    private bool flagHasGroups;
    private HomeAutomationGroupListJSON  storeGroups;
    private bool flagHasHomeAutomationDomainSettings;
    private HomeAutomationDomainSettingsJSON  storeHomeAutomationDomainSettings;
    private bool flagHasDebug;
    private bool storeDebug;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONControllerID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ControllerID of HarmanDeviceRegistrationJSON is not a string.");
        setControllerID(json_string.getData());
      }


    private void  fromJSONEquipment(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationDeviceListJSON convert_classy = HomeAutomationDeviceListJSON.from_json(json_value, ignore_extras, true);
        setEquipment(convert_classy);
      }


    private void  fromJSONGroups(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationGroupListJSON convert_classy = HomeAutomationGroupListJSON.from_json(json_value, ignore_extras, true);
        setGroups(convert_classy);
      }


    private void  fromJSONHomeAutomationDomainSettings(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationDomainSettingsJSON convert_classy = HomeAutomationDomainSettingsJSON.from_json(json_value, ignore_extras, true);
        setHomeAutomationDomainSettings(convert_classy);
      }


    private void  fromJSONDebug(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Debug of HarmanDeviceRegistrationJSON is not true for false.");
              }
          }
        setDebug(the_bool);
      }


    public HarmanDeviceRegistrationJSON()
      {
        flagHasControllerID = false;
        flagHasEquipment = false;
        flagHasGroups = false;
        flagHasHomeAutomationDomainSettings = false;
        flagHasDebug = false;
        storeDebug = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasControllerID()
      {
        return flagHasControllerID;
      }

    public string  getControllerID()
      {
        Debug.Assert(flagHasControllerID);
        return storeControllerID;
      }

    public bool  hasEquipment()
      {
        return flagHasEquipment;
      }

    public HomeAutomationDeviceListJSON   getEquipment()
      {
        Debug.Assert(flagHasEquipment);
        return storeEquipment;
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

    public bool  hasHomeAutomationDomainSettings()
      {
        return flagHasHomeAutomationDomainSettings;
      }

    public HomeAutomationDomainSettingsJSON   getHomeAutomationDomainSettings()
      {
        Debug.Assert(flagHasHomeAutomationDomainSettings);
        return storeHomeAutomationDomainSettings;
      }

    public bool  hasDebug()
      {
        return flagHasDebug;
      }

    public bool  getDebug()
      {
        return storeDebug;
      }


    public virtual int extraHarmanDeviceRegistrationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHarmanDeviceRegistrationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHarmanDeviceRegistrationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHarmanDeviceRegistrationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setControllerID(string new_value)
      {
        flagHasControllerID = true;
        storeControllerID = new_value;
      }
    public void unsetControllerID()
      {
        flagHasControllerID = false;
      }
    public void setEquipment(HomeAutomationDeviceListJSON  new_value)
      {
        if (flagHasEquipment)
          {
          }
        flagHasEquipment = true;
        storeEquipment = new_value;
      }
    public void unsetEquipment()
      {
        if (flagHasEquipment)
          {
          }
        flagHasEquipment = false;
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
    public void setHomeAutomationDomainSettings(HomeAutomationDomainSettingsJSON  new_value)
      {
        if (flagHasHomeAutomationDomainSettings)
          {
          }
        flagHasHomeAutomationDomainSettings = true;
        storeHomeAutomationDomainSettings = new_value;
      }
    public void unsetHomeAutomationDomainSettings()
      {
        if (flagHasHomeAutomationDomainSettings)
          {
          }
        flagHasHomeAutomationDomainSettings = false;
      }
    public void setDebug(bool new_value)
      {
        flagHasDebug = true;
        storeDebug = new_value;
      }
    public void unsetDebug()
      {
        flagHasDebug = false;
      }

    public virtual void extraHarmanDeviceRegistrationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHarmanDeviceRegistrationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHarmanDeviceRegistrationLookup(key);
        if (old_field == null)
          {
            extraHarmanDeviceRegistrationAppendPair(key, new_component);
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
        if (flagHasControllerID)
          {
            handler.start_pair("ControllerID");
            handler.string_value(storeControllerID);
          }
        if (flagHasEquipment)
          {
            handler.start_pair("Equipment");
            if (partial_allowed)
                storeEquipment.write_partial_as_json(handler);
            else
                storeEquipment.write_as_json(handler);
          }
        if (flagHasGroups)
          {
            handler.start_pair("Groups");
            if (partial_allowed)
                storeGroups.write_partial_as_json(handler);
            else
                storeGroups.write_as_json(handler);
          }
        if (flagHasHomeAutomationDomainSettings)
          {
            handler.start_pair("HomeAutomationDomainSettings");
            if (partial_allowed)
                storeHomeAutomationDomainSettings.write_partial_as_json(handler);
            else
                storeHomeAutomationDomainSettings.write_as_json(handler);
          }
        if (flagHasDebug)
          {
            handler.start_pair("Debug");
            handler.boolean_value(storeDebug);
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

    public static HarmanDeviceRegistrationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanDeviceRegistrationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanDeviceRegistration", ignore_extras);
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
    public static HarmanDeviceRegistrationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanDeviceRegistrationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanDeviceRegistrationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanDeviceRegistration", ignore_extras);
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
    public static HarmanDeviceRegistrationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanDeviceRegistrationJSON from_text(string text, bool ignore_extras)
      {
        HarmanDeviceRegistrationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanDeviceRegistration", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HarmanDeviceRegistrationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HarmanDeviceRegistrationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HarmanDeviceRegistrationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanDeviceRegistration", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorControllerID;
        private HomeAutomationDeviceListJSON.HoldingGenerator fieldGeneratorEquipment;
        private HomeAutomationGroupListJSON.HoldingGenerator fieldGeneratorGroups;
        private HomeAutomationDomainSettingsJSON.HoldingGenerator fieldGeneratorHomeAutomationDomainSettings;
        private JSONHoldingBooleanGenerator fieldGeneratorDebug;
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
            HarmanDeviceRegistrationJSON result = new HarmanDeviceRegistrationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHarmanDeviceRegistrationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HarmanDeviceRegistrationJSON result)
          {
            if (fieldGeneratorControllerID.have_value)
              {
                result.setControllerID(fieldGeneratorControllerID.value);
                fieldGeneratorControllerID.have_value = false;
              }
            if (fieldGeneratorEquipment.have_value)
              {
                result.setEquipment(fieldGeneratorEquipment.value);
                fieldGeneratorEquipment.have_value = false;
              }
            if (fieldGeneratorGroups.have_value)
              {
                result.setGroups(fieldGeneratorGroups.value);
                fieldGeneratorGroups.have_value = false;
              }
            if (fieldGeneratorHomeAutomationDomainSettings.have_value)
              {
                result.setHomeAutomationDomainSettings(fieldGeneratorHomeAutomationDomainSettings.value);
                fieldGeneratorHomeAutomationDomainSettings.have_value = false;
              }
            if (fieldGeneratorDebug.have_value)
              {
                result.setDebug(fieldGeneratorDebug.value);
                fieldGeneratorDebug.have_value = false;
              }
          }
        protected abstract void handle_result(HarmanDeviceRegistrationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "ontrollerID", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorControllerID;
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ebug", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorDebug;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "quipment", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorEquipment;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "roups", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorGroups;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "omeAutomationDomainSettings", 0, 27, false) == 0) && (field_name.Length == 28))
                        return fieldGeneratorHomeAutomationDomainSettings;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorControllerID = new JSONHoldingStringGenerator("field \"ControllerID\" of the HarmanDeviceRegistration class");
            fieldGeneratorEquipment = new HomeAutomationDeviceListJSON.HoldingGenerator("field \"Equipment\" of the HarmanDeviceRegistration class", ignore_extras);
            fieldGeneratorGroups = new HomeAutomationGroupListJSON.HoldingGenerator("field \"Groups\" of the HarmanDeviceRegistration class", ignore_extras);
            fieldGeneratorHomeAutomationDomainSettings = new HomeAutomationDomainSettingsJSON.HoldingGenerator("field \"HomeAutomationDomainSettings\" of the HarmanDeviceRegistration class", ignore_extras);
            fieldGeneratorDebug = new JSONHoldingBooleanGenerator("field \"Debug\" of the HarmanDeviceRegistration class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HarmanDeviceRegistration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorControllerID = new JSONHoldingStringGenerator("field \"ControllerID\" of the HarmanDeviceRegistration class");
            fieldGeneratorEquipment = new HomeAutomationDeviceListJSON.HoldingGenerator("field \"Equipment\" of the HarmanDeviceRegistration class", false);
            fieldGeneratorGroups = new HomeAutomationGroupListJSON.HoldingGenerator("field \"Groups\" of the HarmanDeviceRegistration class", false);
            fieldGeneratorHomeAutomationDomainSettings = new HomeAutomationDomainSettingsJSON.HoldingGenerator("field \"HomeAutomationDomainSettings\" of the HarmanDeviceRegistration class", false);
            fieldGeneratorDebug = new JSONHoldingBooleanGenerator("field \"Debug\" of the HarmanDeviceRegistration class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HarmanDeviceRegistration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorControllerID.reset();
            fieldGeneratorEquipment.reset();
            fieldGeneratorGroups.reset();
            fieldGeneratorHomeAutomationDomainSettings.reset();
            fieldGeneratorDebug.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorEquipment.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGroups.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHomeAutomationDomainSettings.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorEquipment.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGroups.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHomeAutomationDomainSettings.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HarmanDeviceRegistrationJSON  result)
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
        public HarmanDeviceRegistrationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HarmanDeviceRegistrationJSON  result)
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
    protected virtual void handle_result(List<HarmanDeviceRegistrationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HarmanDeviceRegistrationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HarmanDeviceRegistrationJSON>();
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
    public List<HarmanDeviceRegistrationJSON> value;
  };
  };
