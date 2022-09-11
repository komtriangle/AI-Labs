/* file "HomeAutomationDeviceJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationDeviceJSON : JSONBase
  {
    private bool flagHasHomeAutomationSolution;
    private HomeAutomationSolutionJSON  storeHomeAutomationSolution;
    private bool flagHasName;
    private string storeName;
    private bool flagHasID;
    private string storeID;
    private bool flagHasType;
    private HomeAutomationDeviceTypeJSON  storeType;
    private bool flagHasCapabilities;
    private List< HomeAutomationOperationJSON  > storeCapabilities;
    private bool flagHasProperties;
    private List< HomeAutomationPropertyJSON  > storeProperties;
    private bool flagHasSolutionData;
    private JSONValue  storeSolutionData;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONHomeAutomationSolution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationSolutionJSON convert_classy = HomeAutomationSolutionJSON.from_json(json_value, ignore_extras, true);
        setHomeAutomationSolution(convert_classy);
      }


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of HomeAutomationDeviceJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ID of HomeAutomationDeviceJSON is not a string.");
        setID(json_string.getData());
      }


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationDeviceTypeJSON convert_classy = HomeAutomationDeviceTypeJSON.from_json(json_value, ignore_extras, true);
        setType(convert_classy);
      }


    private void  fromJSONCapabilities(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Capabilities of HomeAutomationDeviceJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HomeAutomationOperationJSON  > vector_Capabilities1 = new List< HomeAutomationOperationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HomeAutomationOperationJSON convert_classy = HomeAutomationOperationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Capabilities1.Add(convert_classy);
          }
        initCapabilities();
        for (int num1 = 0; num1 < vector_Capabilities1.Count; ++num1)
            appendCapabilities(vector_Capabilities1[num1]);
        for (int num1 = 0; num1 < vector_Capabilities1.Count; ++num1)
          {
          }
      }


    private void  fromJSONProperties(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Properties of HomeAutomationDeviceJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< HomeAutomationPropertyJSON  > vector_Properties1 = new List< HomeAutomationPropertyJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HomeAutomationPropertyJSON convert_classy = HomeAutomationPropertyJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Properties1.Add(convert_classy);
          }
        initProperties();
        for (int num2 = 0; num2 < vector_Properties1.Count; ++num2)
            appendProperties(vector_Properties1[num2]);
        for (int num1 = 0; num1 < vector_Properties1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSolutionData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        setSolutionData(json_value);
      }


    public HomeAutomationDeviceJSON()
      {
        flagHasHomeAutomationSolution = false;
        flagHasName = false;
        flagHasID = false;
        flagHasType = false;
        flagHasCapabilities = false;
        flagHasProperties = false;
        flagHasSolutionData = false;
        storeCapabilities = new List< HomeAutomationOperationJSON  >();
        storeProperties = new List< HomeAutomationPropertyJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasHomeAutomationSolution()
      {
        return flagHasHomeAutomationSolution;
      }

    public HomeAutomationSolutionJSON   getHomeAutomationSolution()
      {
        Debug.Assert(flagHasHomeAutomationSolution);
        return storeHomeAutomationSolution;
      }

    public HomeAutomationSolutionJSON.TypeValue  getHomeAutomationSolutionValue()
      {
        return getHomeAutomationSolution().getValue();
      }

    public string  getHomeAutomationSolutionAsString()
      {
        return getHomeAutomationSolution().getValueAsString();
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

    public bool  hasID()
      {
        return flagHasID;
      }

    public string  getID()
      {
        Debug.Assert(flagHasID);
        return storeID;
      }

    public bool  hasType()
      {
        return flagHasType;
      }

    public HomeAutomationDeviceTypeJSON   getType()
      {
        Debug.Assert(flagHasType);
        return storeType;
      }

    public HomeAutomationDeviceTypeJSON.TypeValue  getTypeValue()
      {
        return getType().getValue();
      }

    public string  getTypeAsString()
      {
        return getType().getValueAsString();
      }

    public bool  hasCapabilities()
      {
        return flagHasCapabilities;
      }

    public int  countOfCapabilities()
      {
        Debug.Assert(flagHasCapabilities);
        return storeCapabilities.Count;
      }

    public HomeAutomationOperationJSON   elementOfCapabilities(int element_num)
      {
        Debug.Assert(flagHasCapabilities);
        return storeCapabilities[element_num];
      }

    public List< HomeAutomationOperationJSON  >  getCapabilities()
      {
        Debug.Assert(flagHasCapabilities);
        return storeCapabilities;
      }

    public bool  hasProperties()
      {
        return flagHasProperties;
      }

    public int  countOfProperties()
      {
        Debug.Assert(flagHasProperties);
        return storeProperties.Count;
      }

    public HomeAutomationPropertyJSON   elementOfProperties(int element_num)
      {
        Debug.Assert(flagHasProperties);
        return storeProperties[element_num];
      }

    public List< HomeAutomationPropertyJSON  >  getProperties()
      {
        Debug.Assert(flagHasProperties);
        return storeProperties;
      }

    public bool  hasSolutionData()
      {
        return flagHasSolutionData;
      }

    public JSONValue   getSolutionData()
      {
        Debug.Assert(flagHasSolutionData);
        return storeSolutionData;
      }


    public virtual int extraHomeAutomationDeviceComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationDeviceComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationDeviceComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationDeviceLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setHomeAutomationSolution(HomeAutomationSolutionJSON  new_value)
      {
        if (flagHasHomeAutomationSolution)
          {
          }
        flagHasHomeAutomationSolution = true;
        storeHomeAutomationSolution = new_value;
      }
    public void setHomeAutomationSolution(HomeAutomationSolutionJSON.TypeValue new_value)
      {
        setHomeAutomationSolution(new HomeAutomationSolutionJSON(new_value));
      }
    public void setHomeAutomationSolution(string chars)
      {
        HomeAutomationSolutionJSON.TypeValueKnownValues known = HomeAutomationSolutionJSON.stringToValue(chars);
        HomeAutomationSolutionJSON.TypeValue new_value = new HomeAutomationSolutionJSON.TypeValue();
        if (known == HomeAutomationSolutionJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setHomeAutomationSolution(new_value);
      }
    public void unsetHomeAutomationSolution()
      {
        if (flagHasHomeAutomationSolution)
          {
          }
        flagHasHomeAutomationSolution = false;
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
    public void setID(string new_value)
      {
        flagHasID = true;
        storeID = new_value;
      }
    public void unsetID()
      {
        flagHasID = false;
      }
    public void setType(HomeAutomationDeviceTypeJSON  new_value)
      {
        if (flagHasType)
          {
          }
        flagHasType = true;
        storeType = new_value;
      }
    public void setType(HomeAutomationDeviceTypeJSON.TypeValue new_value)
      {
        setType(new HomeAutomationDeviceTypeJSON(new_value));
      }
    public void setType(string chars)
      {
        HomeAutomationDeviceTypeJSON.TypeValueKnownValues known = HomeAutomationDeviceTypeJSON.stringToValue(chars);
        HomeAutomationDeviceTypeJSON.TypeValue new_value = new HomeAutomationDeviceTypeJSON.TypeValue();
        if (known == HomeAutomationDeviceTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setType(new_value);
      }
    public void unsetType()
      {
        if (flagHasType)
          {
          }
        flagHasType = false;
      }
    public void initCapabilities()
      {
        if (flagHasCapabilities)
          {
            for (int num1 = 0; num1 < storeCapabilities.Count; ++num1)
              {
              }
          }
        flagHasCapabilities = true;
        storeCapabilities.Clear();
      }
    public void appendCapabilities(HomeAutomationOperationJSON  to_append)
      {
        if (!flagHasCapabilities)
          {
            flagHasCapabilities = true;
            storeCapabilities.Clear();
          }
        Debug.Assert(flagHasCapabilities);
        storeCapabilities.Add(to_append);
      }
    public void appendCapabilities(HomeAutomationOperationJSON.TypeValue new_value)
      {
        appendCapabilities(new HomeAutomationOperationJSON(new_value));
      }
    public void appendCapabilities(string chars)
      {
        HomeAutomationOperationJSON.TypeValueKnownValues known = HomeAutomationOperationJSON.stringToValue(chars);
        HomeAutomationOperationJSON.TypeValue new_value = new HomeAutomationOperationJSON.TypeValue();
        if (known == HomeAutomationOperationJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendCapabilities(new_value);
      }
    public void unsetCapabilities()
      {
        if (flagHasCapabilities)
          {
            for (int num2 = 0; num2 < storeCapabilities.Count; ++num2)
              {
              }
          }
        flagHasCapabilities = false;
        storeCapabilities.Clear();
      }
    public void initProperties()
      {
        if (flagHasProperties)
          {
            for (int num3 = 0; num3 < storeProperties.Count; ++num3)
              {
              }
          }
        flagHasProperties = true;
        storeProperties.Clear();
      }
    public void appendProperties(HomeAutomationPropertyJSON  to_append)
      {
        if (!flagHasProperties)
          {
            flagHasProperties = true;
            storeProperties.Clear();
          }
        Debug.Assert(flagHasProperties);
        storeProperties.Add(to_append);
      }
    public void appendProperties(HomeAutomationPropertyJSON.TypeValue new_value)
      {
        appendProperties(new HomeAutomationPropertyJSON(new_value));
      }
    public void appendProperties(string chars)
      {
        HomeAutomationPropertyJSON.TypeValueKnownValues known = HomeAutomationPropertyJSON.stringToValue(chars);
        HomeAutomationPropertyJSON.TypeValue new_value = new HomeAutomationPropertyJSON.TypeValue();
        if (known == HomeAutomationPropertyJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendProperties(new_value);
      }
    public void unsetProperties()
      {
        if (flagHasProperties)
          {
            for (int num4 = 0; num4 < storeProperties.Count; ++num4)
              {
              }
          }
        flagHasProperties = false;
        storeProperties.Clear();
      }
    public void setSolutionData(JSONValue  new_value)
      {
        if (flagHasSolutionData)
          {
          }
        flagHasSolutionData = true;
        storeSolutionData = new_value;
      }
    public void unsetSolutionData()
      {
        if (flagHasSolutionData)
          {
          }
        flagHasSolutionData = false;
      }

    public virtual void extraHomeAutomationDeviceAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationDeviceSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationDeviceLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationDeviceAppendPair(key, new_component);
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
        if (flagHasHomeAutomationSolution)
          {
            handler.start_pair("HomeAutomationSolution");
            if (partial_allowed)
                storeHomeAutomationSolution.write_partial_as_json(handler);
            else
                storeHomeAutomationSolution.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasName);
        if (flagHasName)
          {
            handler.start_pair("Name");
            handler.string_value(storeName);
          }
        Debug.Assert(partial_allowed || flagHasID);
        if (flagHasID)
          {
            handler.start_pair("ID");
            handler.string_value(storeID);
          }
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (partial_allowed)
                storeType.write_partial_as_json(handler);
            else
                storeType.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasCapabilities);
        if (flagHasCapabilities)
          {
            handler.start_pair("Capabilities");
            handler.start_array();
            for (int num1 = 0; num1 < storeCapabilities.Count; ++num1)
              {
                if (partial_allowed)
                    storeCapabilities[num1].write_partial_as_json(handler);
                else
                    storeCapabilities[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasProperties)
          {
            handler.start_pair("Properties");
            handler.start_array();
            for (int num2 = 0; num2 < storeProperties.Count; ++num2)
              {
                if (partial_allowed)
                    storeProperties[num2].write_partial_as_json(handler);
                else
                    storeProperties[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSolutionData)
          {
            handler.start_pair("SolutionData");
            storeSolutionData.write(handler);
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
        if (!(hasID()))
          {
            return "When parsing the object for %what%, the \"ID\" field was missing.";
          }
        if (!(hasCapabilities()))
          {
            return "When parsing the object for %what%, the \"Capabilities\" field was missing.";
          }
        return null;
      }

    public static HomeAutomationDeviceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationDeviceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationDevice", ignore_extras);
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
    public static HomeAutomationDeviceJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationDeviceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationDeviceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationDevice", ignore_extras);
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
    public static HomeAutomationDeviceJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationDeviceJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationDeviceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationDevice", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationDeviceJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationDeviceJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationDeviceJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationDevice", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private HomeAutomationSolutionJSON.HoldingGenerator fieldGeneratorHomeAutomationSolution;
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorID;
        private HomeAutomationDeviceTypeJSON.HoldingGenerator fieldGeneratorType;
        private HomeAutomationOperationJSON.HoldingArrayGenerator fieldGeneratorCapabilities;
        private HomeAutomationPropertyJSON.HoldingArrayGenerator fieldGeneratorProperties;
        private JSONHoldingValueGenerator fieldGeneratorSolutionData;
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
            HomeAutomationDeviceJSON result = new HomeAutomationDeviceJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationDeviceAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationDeviceJSON result)
          {
            if (fieldGeneratorHomeAutomationSolution.have_value)
              {
                result.setHomeAutomationSolution(fieldGeneratorHomeAutomationSolution.value);
                fieldGeneratorHomeAutomationSolution.have_value = false;
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
            if (fieldGeneratorID.have_value)
              {
                result.setID(fieldGeneratorID.value);
                fieldGeneratorID.have_value = false;
              }
            else if ((!(result.hasID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ID\" field was missing.");
              }
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            if (fieldGeneratorCapabilities.have_value)
              {
                result.initCapabilities();
                int count = fieldGeneratorCapabilities.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCapabilities(fieldGeneratorCapabilities.value[num]);
                  }
                fieldGeneratorCapabilities.value.Clear();
                fieldGeneratorCapabilities.have_value = false;
              }
            else if ((!(result.hasCapabilities())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Capabilities\" field was missing.");
              }
            if (fieldGeneratorProperties.have_value)
              {
                result.initProperties();
                int count = fieldGeneratorProperties.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendProperties(fieldGeneratorProperties.value[num]);
                  }
                fieldGeneratorProperties.value.Clear();
                fieldGeneratorProperties.have_value = false;
              }
            if (fieldGeneratorSolutionData.have_value)
              {
                result.setSolutionData(fieldGeneratorSolutionData.value);
                fieldGeneratorSolutionData.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationDeviceJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "apabilities", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorCapabilities;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "omeAutomationSolution", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorHomeAutomationSolution;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "D", 0, 1, false) == 0) && (field_name.Length == 2))
                        return fieldGeneratorID;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ame", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorName;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "roperties", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorProperties;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "olutionData", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorSolutionData;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorHomeAutomationSolution = new HomeAutomationSolutionJSON.HoldingGenerator("field \"HomeAutomationSolution\" of the HomeAutomationDevice class", ignore_extras);
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the HomeAutomationDevice class");
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the HomeAutomationDevice class");
            fieldGeneratorType = new HomeAutomationDeviceTypeJSON.HoldingGenerator("field \"Type\" of the HomeAutomationDevice class", ignore_extras);
            fieldGeneratorCapabilities = new HomeAutomationOperationJSON.HoldingArrayGenerator("field \"Capabilities\" of the HomeAutomationDevice class", ignore_extras);
            fieldGeneratorProperties = new HomeAutomationPropertyJSON.HoldingArrayGenerator("field \"Properties\" of the HomeAutomationDevice class", ignore_extras);
            fieldGeneratorSolutionData = new JSONHoldingValueGenerator("field \"SolutionData\" of the HomeAutomationDevice class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationDevice class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorHomeAutomationSolution = new HomeAutomationSolutionJSON.HoldingGenerator("field \"HomeAutomationSolution\" of the HomeAutomationDevice class", false);
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the HomeAutomationDevice class");
            fieldGeneratorID = new JSONHoldingStringGenerator("field \"ID\" of the HomeAutomationDevice class");
            fieldGeneratorType = new HomeAutomationDeviceTypeJSON.HoldingGenerator("field \"Type\" of the HomeAutomationDevice class", false);
            fieldGeneratorCapabilities = new HomeAutomationOperationJSON.HoldingArrayGenerator("field \"Capabilities\" of the HomeAutomationDevice class", false);
            fieldGeneratorProperties = new HomeAutomationPropertyJSON.HoldingArrayGenerator("field \"Properties\" of the HomeAutomationDevice class", false);
            fieldGeneratorSolutionData = new JSONHoldingValueGenerator("field \"SolutionData\" of the HomeAutomationDevice class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationDevice class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorHomeAutomationSolution.reset();
            fieldGeneratorName.reset();
            fieldGeneratorID.reset();
            fieldGeneratorType.reset();
            fieldGeneratorCapabilities.reset();
            fieldGeneratorProperties.reset();
            fieldGeneratorSolutionData.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorHomeAutomationSolution.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCapabilities.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorProperties.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorHomeAutomationSolution.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCapabilities.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorProperties.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationDeviceJSON  result)
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
        public HomeAutomationDeviceJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationDeviceJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationDeviceJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationDeviceJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationDeviceJSON>();
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
    public List<HomeAutomationDeviceJSON> value;
  };
  };
