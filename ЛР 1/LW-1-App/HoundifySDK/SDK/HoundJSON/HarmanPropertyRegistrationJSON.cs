/* file "HarmanPropertyRegistrationJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HarmanPropertyRegistrationJSON : JSONBase
  {
    private bool flagHasPropertyID;
    private string storePropertyID;
    private bool flagHasHarmanCallbackEndpoint;
    private HarmanCallbackEndpointJSON  storeHarmanCallbackEndpoint;
    private bool flagHasHomeAutomationDomainSettings;
    private HomeAutomationDomainSettingsJSON  storeHomeAutomationDomainSettings;
    private bool flagHasDebug;
    private bool storeDebug;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONPropertyID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PropertyID of HarmanPropertyRegistrationJSON is not a string.");
        setPropertyID(json_string.getData());
      }


    private void  fromJSONHarmanCallbackEndpoint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HarmanCallbackEndpointJSON convert_classy = HarmanCallbackEndpointJSON.from_json(json_value, ignore_extras, true);
        setHarmanCallbackEndpoint(convert_classy);
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
                throw new Exception("The value for field Debug of HarmanPropertyRegistrationJSON is not true for false.");
              }
          }
        setDebug(the_bool);
      }


    public HarmanPropertyRegistrationJSON()
      {
        flagHasPropertyID = false;
        flagHasHarmanCallbackEndpoint = false;
        flagHasHomeAutomationDomainSettings = false;
        flagHasDebug = false;
        storeDebug = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasPropertyID()
      {
        return flagHasPropertyID;
      }

    public string  getPropertyID()
      {
        Debug.Assert(flagHasPropertyID);
        return storePropertyID;
      }

    public bool  hasHarmanCallbackEndpoint()
      {
        return flagHasHarmanCallbackEndpoint;
      }

    public HarmanCallbackEndpointJSON   getHarmanCallbackEndpoint()
      {
        Debug.Assert(flagHasHarmanCallbackEndpoint);
        return storeHarmanCallbackEndpoint;
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


    public virtual int extraHarmanPropertyRegistrationComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHarmanPropertyRegistrationComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHarmanPropertyRegistrationComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHarmanPropertyRegistrationLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setPropertyID(string new_value)
      {
        flagHasPropertyID = true;
        storePropertyID = new_value;
      }
    public void unsetPropertyID()
      {
        flagHasPropertyID = false;
      }
    public void setHarmanCallbackEndpoint(HarmanCallbackEndpointJSON  new_value)
      {
        if (flagHasHarmanCallbackEndpoint)
          {
          }
        flagHasHarmanCallbackEndpoint = true;
        storeHarmanCallbackEndpoint = new_value;
      }
    public void unsetHarmanCallbackEndpoint()
      {
        if (flagHasHarmanCallbackEndpoint)
          {
          }
        flagHasHarmanCallbackEndpoint = false;
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

    public virtual void extraHarmanPropertyRegistrationAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHarmanPropertyRegistrationSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHarmanPropertyRegistrationLookup(key);
        if (old_field == null)
          {
            extraHarmanPropertyRegistrationAppendPair(key, new_component);
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
        if (flagHasPropertyID)
          {
            handler.start_pair("PropertyID");
            handler.string_value(storePropertyID);
          }
        if (flagHasHarmanCallbackEndpoint)
          {
            handler.start_pair("HarmanCallbackEndpoint");
            if (partial_allowed)
                storeHarmanCallbackEndpoint.write_partial_as_json(handler);
            else
                storeHarmanCallbackEndpoint.write_as_json(handler);
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

    public static HarmanPropertyRegistrationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanPropertyRegistrationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanPropertyRegistration", ignore_extras);
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
    public static HarmanPropertyRegistrationJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanPropertyRegistrationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HarmanPropertyRegistrationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanPropertyRegistration", ignore_extras);
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
    public static HarmanPropertyRegistrationJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HarmanPropertyRegistrationJSON from_text(string text, bool ignore_extras)
      {
        HarmanPropertyRegistrationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanPropertyRegistration", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HarmanPropertyRegistrationJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HarmanPropertyRegistrationJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HarmanPropertyRegistrationJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HarmanPropertyRegistration", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorPropertyID;
        private HarmanCallbackEndpointJSON.HoldingGenerator fieldGeneratorHarmanCallbackEndpoint;
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
            HarmanPropertyRegistrationJSON result = new HarmanPropertyRegistrationJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHarmanPropertyRegistrationAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HarmanPropertyRegistrationJSON result)
          {
            if (fieldGeneratorPropertyID.have_value)
              {
                result.setPropertyID(fieldGeneratorPropertyID.value);
                fieldGeneratorPropertyID.have_value = false;
              }
            if (fieldGeneratorHarmanCallbackEndpoint.have_value)
              {
                result.setHarmanCallbackEndpoint(fieldGeneratorHarmanCallbackEndpoint.value);
                fieldGeneratorHarmanCallbackEndpoint.have_value = false;
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
        protected abstract void handle_result(HarmanPropertyRegistrationJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ebug", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorDebug;
                    break;
                case 'H':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "rmanCallbackEndpoint", 0, 20, false) == 0) && (field_name.Length == 22))
                                return fieldGeneratorHarmanCallbackEndpoint;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "meAutomationDomainSettings", 0, 26, false) == 0) && (field_name.Length == 28))
                                return fieldGeneratorHomeAutomationDomainSettings;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ropertyID", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorPropertyID;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorPropertyID = new JSONHoldingStringGenerator("field \"PropertyID\" of the HarmanPropertyRegistration class");
            fieldGeneratorHarmanCallbackEndpoint = new HarmanCallbackEndpointJSON.HoldingGenerator("field \"HarmanCallbackEndpoint\" of the HarmanPropertyRegistration class", ignore_extras);
            fieldGeneratorHomeAutomationDomainSettings = new HomeAutomationDomainSettingsJSON.HoldingGenerator("field \"HomeAutomationDomainSettings\" of the HarmanPropertyRegistration class", ignore_extras);
            fieldGeneratorDebug = new JSONHoldingBooleanGenerator("field \"Debug\" of the HarmanPropertyRegistration class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HarmanPropertyRegistration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorPropertyID = new JSONHoldingStringGenerator("field \"PropertyID\" of the HarmanPropertyRegistration class");
            fieldGeneratorHarmanCallbackEndpoint = new HarmanCallbackEndpointJSON.HoldingGenerator("field \"HarmanCallbackEndpoint\" of the HarmanPropertyRegistration class", false);
            fieldGeneratorHomeAutomationDomainSettings = new HomeAutomationDomainSettingsJSON.HoldingGenerator("field \"HomeAutomationDomainSettings\" of the HarmanPropertyRegistration class", false);
            fieldGeneratorDebug = new JSONHoldingBooleanGenerator("field \"Debug\" of the HarmanPropertyRegistration class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HarmanPropertyRegistration class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorPropertyID.reset();
            fieldGeneratorHarmanCallbackEndpoint.reset();
            fieldGeneratorHomeAutomationDomainSettings.reset();
            fieldGeneratorDebug.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorHarmanCallbackEndpoint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHomeAutomationDomainSettings.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorHarmanCallbackEndpoint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHomeAutomationDomainSettings.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HarmanPropertyRegistrationJSON  result)
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
        public HarmanPropertyRegistrationJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HarmanPropertyRegistrationJSON  result)
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
    protected virtual void handle_result(List<HarmanPropertyRegistrationJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HarmanPropertyRegistrationJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HarmanPropertyRegistrationJSON>();
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
    public List<HarmanPropertyRegistrationJSON> value;
  };
  };
