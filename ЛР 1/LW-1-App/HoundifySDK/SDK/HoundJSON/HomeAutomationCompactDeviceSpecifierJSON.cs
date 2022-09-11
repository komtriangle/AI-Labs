/* file "HomeAutomationCompactDeviceSpecifierJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class HomeAutomationCompactDeviceSpecifierJSON : JSONBase
  {
    private bool flagHasSpecifier;
    private HomeAutomationSpecifierJSON  storeSpecifier;
    private bool flagHasGroupItems;
    private List< HomeAutomationGroupParsingItemJSON  > storeGroupItems;
    private bool flagHasDeviceItems;
    private List< HomeAutomationDeviceParsingItemJSON  > storeDeviceItems;
    private bool flagHasExcludedGroupItems;
    private List< HomeAutomationGroupParsingItemJSON  > storeExcludedGroupItems;
    private bool flagHasExcludedDeviceItems;
    private List< HomeAutomationDeviceParsingItemJSON  > storeExcludedDeviceItems;
    private bool flagHasType;
    private HomeAutomationDeviceTypeJSON  storeType;
    private bool flagHasHint;
    private HomeAutomationQueryHintJSON  storeHint;
    private bool flagHasUnambiguousGroups;
    private HomeAutomationGroupListJSON  storeUnambiguousGroups;
    private bool flagHasUnambiguousDevices;
    private HomeAutomationDeviceListJSON  storeUnambiguousDevices;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSpecifier(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationSpecifierJSON convert_classy = HomeAutomationSpecifierJSON.from_json(json_value, ignore_extras, true);
        setSpecifier(convert_classy);
      }


    private void  fromJSONGroupItems(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GroupItems of HomeAutomationCompactDeviceSpecifierJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field GroupItems of HomeAutomationCompactDeviceSpecifierJSON has too few elements.");
        List< HomeAutomationGroupParsingItemJSON  > vector_GroupItems1 = new List< HomeAutomationGroupParsingItemJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HomeAutomationGroupParsingItemJSON convert_classy = HomeAutomationGroupParsingItemJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_GroupItems1.Add(convert_classy);
          }
        Debug.Assert(vector_GroupItems1.Count >= 1);
        initGroupItems();
        for (int num1 = 0; num1 < vector_GroupItems1.Count; ++num1)
            appendGroupItems(vector_GroupItems1[num1]);
        for (int num1 = 0; num1 < vector_GroupItems1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDeviceItems(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DeviceItems of HomeAutomationCompactDeviceSpecifierJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field DeviceItems of HomeAutomationCompactDeviceSpecifierJSON has too few elements.");
        List< HomeAutomationDeviceParsingItemJSON  > vector_DeviceItems1 = new List< HomeAutomationDeviceParsingItemJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HomeAutomationDeviceParsingItemJSON convert_classy = HomeAutomationDeviceParsingItemJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_DeviceItems1.Add(convert_classy);
          }
        Debug.Assert(vector_DeviceItems1.Count >= 1);
        initDeviceItems();
        for (int num2 = 0; num2 < vector_DeviceItems1.Count; ++num2)
            appendDeviceItems(vector_DeviceItems1[num2]);
        for (int num1 = 0; num1 < vector_DeviceItems1.Count; ++num1)
          {
          }
      }


    private void  fromJSONExcludedGroupItems(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ExcludedGroupItems of HomeAutomationCompactDeviceSpecifierJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ExcludedGroupItems of HomeAutomationCompactDeviceSpecifierJSON has too few elements.");
        List< HomeAutomationGroupParsingItemJSON  > vector_ExcludedGroupItems1 = new List< HomeAutomationGroupParsingItemJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HomeAutomationGroupParsingItemJSON convert_classy = HomeAutomationGroupParsingItemJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ExcludedGroupItems1.Add(convert_classy);
          }
        Debug.Assert(vector_ExcludedGroupItems1.Count >= 1);
        initExcludedGroupItems();
        for (int num3 = 0; num3 < vector_ExcludedGroupItems1.Count; ++num3)
            appendExcludedGroupItems(vector_ExcludedGroupItems1[num3]);
        for (int num1 = 0; num1 < vector_ExcludedGroupItems1.Count; ++num1)
          {
          }
      }


    private void  fromJSONExcludedDeviceItems(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ExcludedDeviceItems of HomeAutomationCompactDeviceSpecifierJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ExcludedDeviceItems of HomeAutomationCompactDeviceSpecifierJSON has too few elements.");
        List< HomeAutomationDeviceParsingItemJSON  > vector_ExcludedDeviceItems1 = new List< HomeAutomationDeviceParsingItemJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            HomeAutomationDeviceParsingItemJSON convert_classy = HomeAutomationDeviceParsingItemJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ExcludedDeviceItems1.Add(convert_classy);
          }
        Debug.Assert(vector_ExcludedDeviceItems1.Count >= 1);
        initExcludedDeviceItems();
        for (int num4 = 0; num4 < vector_ExcludedDeviceItems1.Count; ++num4)
            appendExcludedDeviceItems(vector_ExcludedDeviceItems1[num4]);
        for (int num1 = 0; num1 < vector_ExcludedDeviceItems1.Count; ++num1)
          {
          }
      }


    private void  fromJSONType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationDeviceTypeJSON convert_classy = HomeAutomationDeviceTypeJSON.from_json(json_value, ignore_extras, true);
        setType(convert_classy);
      }


    private void  fromJSONHint(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationQueryHintJSON convert_classy = HomeAutomationQueryHintJSON.from_json(json_value, ignore_extras, true);
        setHint(convert_classy);
      }


    private void  fromJSONUnambiguousGroups(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationGroupListJSON convert_classy = HomeAutomationGroupListJSON.from_json(json_value, ignore_extras, true);
        setUnambiguousGroups(convert_classy);
      }


    private void  fromJSONUnambiguousDevices(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        HomeAutomationDeviceListJSON convert_classy = HomeAutomationDeviceListJSON.from_json(json_value, ignore_extras, true);
        setUnambiguousDevices(convert_classy);
      }


    public HomeAutomationCompactDeviceSpecifierJSON()
      {
        flagHasSpecifier = false;
        flagHasGroupItems = false;
        flagHasDeviceItems = false;
        flagHasExcludedGroupItems = false;
        flagHasExcludedDeviceItems = false;
        flagHasType = false;
        flagHasHint = false;
        flagHasUnambiguousGroups = false;
        flagHasUnambiguousDevices = false;
        storeGroupItems = new List< HomeAutomationGroupParsingItemJSON  >();
        storeDeviceItems = new List< HomeAutomationDeviceParsingItemJSON  >();
        storeExcludedGroupItems = new List< HomeAutomationGroupParsingItemJSON  >();
        storeExcludedDeviceItems = new List< HomeAutomationDeviceParsingItemJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSpecifier()
      {
        return flagHasSpecifier;
      }

    public HomeAutomationSpecifierJSON   getSpecifier()
      {
        Debug.Assert(flagHasSpecifier);
        return storeSpecifier;
      }

    public HomeAutomationSpecifierJSON.TypeValue  getSpecifierValue()
      {
        return getSpecifier().getValue();
      }

    public string  getSpecifierAsString()
      {
        return getSpecifier().getValueAsString();
      }

    public bool  hasGroupItems()
      {
        return flagHasGroupItems;
      }

    public int  countOfGroupItems()
      {
        Debug.Assert(flagHasGroupItems);
        return storeGroupItems.Count;
      }

    public HomeAutomationGroupParsingItemJSON   elementOfGroupItems(int element_num)
      {
        Debug.Assert(flagHasGroupItems);
        return storeGroupItems[element_num];
      }

    public List< HomeAutomationGroupParsingItemJSON  >  getGroupItems()
      {
        Debug.Assert(flagHasGroupItems);
        return storeGroupItems;
      }

    public bool  hasDeviceItems()
      {
        return flagHasDeviceItems;
      }

    public int  countOfDeviceItems()
      {
        Debug.Assert(flagHasDeviceItems);
        return storeDeviceItems.Count;
      }

    public HomeAutomationDeviceParsingItemJSON   elementOfDeviceItems(int element_num)
      {
        Debug.Assert(flagHasDeviceItems);
        return storeDeviceItems[element_num];
      }

    public List< HomeAutomationDeviceParsingItemJSON  >  getDeviceItems()
      {
        Debug.Assert(flagHasDeviceItems);
        return storeDeviceItems;
      }

    public bool  hasExcludedGroupItems()
      {
        return flagHasExcludedGroupItems;
      }

    public int  countOfExcludedGroupItems()
      {
        Debug.Assert(flagHasExcludedGroupItems);
        return storeExcludedGroupItems.Count;
      }

    public HomeAutomationGroupParsingItemJSON   elementOfExcludedGroupItems(int element_num)
      {
        Debug.Assert(flagHasExcludedGroupItems);
        return storeExcludedGroupItems[element_num];
      }

    public List< HomeAutomationGroupParsingItemJSON  >  getExcludedGroupItems()
      {
        Debug.Assert(flagHasExcludedGroupItems);
        return storeExcludedGroupItems;
      }

    public bool  hasExcludedDeviceItems()
      {
        return flagHasExcludedDeviceItems;
      }

    public int  countOfExcludedDeviceItems()
      {
        Debug.Assert(flagHasExcludedDeviceItems);
        return storeExcludedDeviceItems.Count;
      }

    public HomeAutomationDeviceParsingItemJSON   elementOfExcludedDeviceItems(int element_num)
      {
        Debug.Assert(flagHasExcludedDeviceItems);
        return storeExcludedDeviceItems[element_num];
      }

    public List< HomeAutomationDeviceParsingItemJSON  >  getExcludedDeviceItems()
      {
        Debug.Assert(flagHasExcludedDeviceItems);
        return storeExcludedDeviceItems;
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

    public bool  hasHint()
      {
        return flagHasHint;
      }

    public HomeAutomationQueryHintJSON   getHint()
      {
        Debug.Assert(flagHasHint);
        return storeHint;
      }

    public bool  hasUnambiguousGroups()
      {
        return flagHasUnambiguousGroups;
      }

    public HomeAutomationGroupListJSON   getUnambiguousGroups()
      {
        Debug.Assert(flagHasUnambiguousGroups);
        return storeUnambiguousGroups;
      }

    public bool  hasUnambiguousDevices()
      {
        return flagHasUnambiguousDevices;
      }

    public HomeAutomationDeviceListJSON   getUnambiguousDevices()
      {
        Debug.Assert(flagHasUnambiguousDevices);
        return storeUnambiguousDevices;
      }


    public virtual int extraHomeAutomationCompactDeviceSpecifierComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraHomeAutomationCompactDeviceSpecifierComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraHomeAutomationCompactDeviceSpecifierComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraHomeAutomationCompactDeviceSpecifierLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSpecifier(HomeAutomationSpecifierJSON  new_value)
      {
        if (flagHasSpecifier)
          {
          }
        flagHasSpecifier = true;
        storeSpecifier = new_value;
      }
    public void setSpecifier(HomeAutomationSpecifierJSON.TypeValue new_value)
      {
        setSpecifier(new HomeAutomationSpecifierJSON(new_value));
      }
    public void setSpecifier(string chars)
      {
        HomeAutomationSpecifierJSON.TypeValueKnownValues known = HomeAutomationSpecifierJSON.stringToValue(chars);
        HomeAutomationSpecifierJSON.TypeValue new_value = new HomeAutomationSpecifierJSON.TypeValue();
        if (known == HomeAutomationSpecifierJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setSpecifier(new_value);
      }
    public void unsetSpecifier()
      {
        if (flagHasSpecifier)
          {
          }
        flagHasSpecifier = false;
      }
    public void initGroupItems()
      {
        if (flagHasGroupItems)
          {
            for (int num1 = 0; num1 < storeGroupItems.Count; ++num1)
              {
              }
          }
        flagHasGroupItems = true;
        storeGroupItems.Clear();
      }
    public void appendGroupItems(HomeAutomationGroupParsingItemJSON  to_append)
      {
        if (!flagHasGroupItems)
          {
            flagHasGroupItems = true;
            storeGroupItems.Clear();
          }
        Debug.Assert(flagHasGroupItems);
        storeGroupItems.Add(to_append);
      }
    public void unsetGroupItems()
      {
        if (flagHasGroupItems)
          {
            for (int num2 = 0; num2 < storeGroupItems.Count; ++num2)
              {
              }
          }
        flagHasGroupItems = false;
        storeGroupItems.Clear();
      }
    public void initDeviceItems()
      {
        if (flagHasDeviceItems)
          {
            for (int num3 = 0; num3 < storeDeviceItems.Count; ++num3)
              {
              }
          }
        flagHasDeviceItems = true;
        storeDeviceItems.Clear();
      }
    public void appendDeviceItems(HomeAutomationDeviceParsingItemJSON  to_append)
      {
        if (!flagHasDeviceItems)
          {
            flagHasDeviceItems = true;
            storeDeviceItems.Clear();
          }
        Debug.Assert(flagHasDeviceItems);
        storeDeviceItems.Add(to_append);
      }
    public void unsetDeviceItems()
      {
        if (flagHasDeviceItems)
          {
            for (int num4 = 0; num4 < storeDeviceItems.Count; ++num4)
              {
              }
          }
        flagHasDeviceItems = false;
        storeDeviceItems.Clear();
      }
    public void initExcludedGroupItems()
      {
        if (flagHasExcludedGroupItems)
          {
            for (int num5 = 0; num5 < storeExcludedGroupItems.Count; ++num5)
              {
              }
          }
        flagHasExcludedGroupItems = true;
        storeExcludedGroupItems.Clear();
      }
    public void appendExcludedGroupItems(HomeAutomationGroupParsingItemJSON  to_append)
      {
        if (!flagHasExcludedGroupItems)
          {
            flagHasExcludedGroupItems = true;
            storeExcludedGroupItems.Clear();
          }
        Debug.Assert(flagHasExcludedGroupItems);
        storeExcludedGroupItems.Add(to_append);
      }
    public void unsetExcludedGroupItems()
      {
        if (flagHasExcludedGroupItems)
          {
            for (int num6 = 0; num6 < storeExcludedGroupItems.Count; ++num6)
              {
              }
          }
        flagHasExcludedGroupItems = false;
        storeExcludedGroupItems.Clear();
      }
    public void initExcludedDeviceItems()
      {
        if (flagHasExcludedDeviceItems)
          {
            for (int num7 = 0; num7 < storeExcludedDeviceItems.Count; ++num7)
              {
              }
          }
        flagHasExcludedDeviceItems = true;
        storeExcludedDeviceItems.Clear();
      }
    public void appendExcludedDeviceItems(HomeAutomationDeviceParsingItemJSON  to_append)
      {
        if (!flagHasExcludedDeviceItems)
          {
            flagHasExcludedDeviceItems = true;
            storeExcludedDeviceItems.Clear();
          }
        Debug.Assert(flagHasExcludedDeviceItems);
        storeExcludedDeviceItems.Add(to_append);
      }
    public void unsetExcludedDeviceItems()
      {
        if (flagHasExcludedDeviceItems)
          {
            for (int num8 = 0; num8 < storeExcludedDeviceItems.Count; ++num8)
              {
              }
          }
        flagHasExcludedDeviceItems = false;
        storeExcludedDeviceItems.Clear();
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
    public void setHint(HomeAutomationQueryHintJSON  new_value)
      {
        if (flagHasHint)
          {
          }
        flagHasHint = true;
        storeHint = new_value;
      }
    public void unsetHint()
      {
        if (flagHasHint)
          {
          }
        flagHasHint = false;
      }
    public void setUnambiguousGroups(HomeAutomationGroupListJSON  new_value)
      {
        if (flagHasUnambiguousGroups)
          {
          }
        flagHasUnambiguousGroups = true;
        storeUnambiguousGroups = new_value;
      }
    public void unsetUnambiguousGroups()
      {
        if (flagHasUnambiguousGroups)
          {
          }
        flagHasUnambiguousGroups = false;
      }
    public void setUnambiguousDevices(HomeAutomationDeviceListJSON  new_value)
      {
        if (flagHasUnambiguousDevices)
          {
          }
        flagHasUnambiguousDevices = true;
        storeUnambiguousDevices = new_value;
      }
    public void unsetUnambiguousDevices()
      {
        if (flagHasUnambiguousDevices)
          {
          }
        flagHasUnambiguousDevices = false;
      }

    public virtual void extraHomeAutomationCompactDeviceSpecifierAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraHomeAutomationCompactDeviceSpecifierSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraHomeAutomationCompactDeviceSpecifierLookup(key);
        if (old_field == null)
          {
            extraHomeAutomationCompactDeviceSpecifierAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasSpecifier);
        if (flagHasSpecifier)
          {
            handler.start_pair("Specifier");
            if (partial_allowed)
                storeSpecifier.write_partial_as_json(handler);
            else
                storeSpecifier.write_as_json(handler);
          }
        if (flagHasGroupItems)
          {
            handler.start_pair("GroupItems");
            Debug.Assert(storeGroupItems.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeGroupItems.Count; ++num1)
              {
                if (partial_allowed)
                    storeGroupItems[num1].write_partial_as_json(handler);
                else
                    storeGroupItems[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasDeviceItems)
          {
            handler.start_pair("DeviceItems");
            Debug.Assert(storeDeviceItems.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeDeviceItems.Count; ++num2)
              {
                if (partial_allowed)
                    storeDeviceItems[num2].write_partial_as_json(handler);
                else
                    storeDeviceItems[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasExcludedGroupItems)
          {
            handler.start_pair("ExcludedGroupItems");
            Debug.Assert(storeExcludedGroupItems.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeExcludedGroupItems.Count; ++num3)
              {
                if (partial_allowed)
                    storeExcludedGroupItems[num3].write_partial_as_json(handler);
                else
                    storeExcludedGroupItems[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasExcludedDeviceItems)
          {
            handler.start_pair("ExcludedDeviceItems");
            Debug.Assert(storeExcludedDeviceItems.Count >= 1);
            handler.start_array();
            for (int num4 = 0; num4 < storeExcludedDeviceItems.Count; ++num4)
              {
                if (partial_allowed)
                    storeExcludedDeviceItems[num4].write_partial_as_json(handler);
                else
                    storeExcludedDeviceItems[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasType)
          {
            handler.start_pair("Type");
            if (partial_allowed)
                storeType.write_partial_as_json(handler);
            else
                storeType.write_as_json(handler);
          }
        if (flagHasHint)
          {
            handler.start_pair("Hint");
            if (partial_allowed)
                storeHint.write_partial_as_json(handler);
            else
                storeHint.write_as_json(handler);
          }
        if (flagHasUnambiguousGroups)
          {
            handler.start_pair("UnambiguousGroups");
            if (partial_allowed)
                storeUnambiguousGroups.write_partial_as_json(handler);
            else
                storeUnambiguousGroups.write_as_json(handler);
          }
        if (flagHasUnambiguousDevices)
          {
            handler.start_pair("UnambiguousDevices");
            if (partial_allowed)
                storeUnambiguousDevices.write_partial_as_json(handler);
            else
                storeUnambiguousDevices.write_as_json(handler);
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
        if (!(hasSpecifier()))
          {
            return "When parsing the object for %what%, the \"Specifier\" field was missing.";
          }
        return null;
      }

    public static HomeAutomationCompactDeviceSpecifierJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationCompactDeviceSpecifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationCompactDeviceSpecifier", ignore_extras);
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
    public static HomeAutomationCompactDeviceSpecifierJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationCompactDeviceSpecifierJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        HomeAutomationCompactDeviceSpecifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationCompactDeviceSpecifier", ignore_extras);
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
    public static HomeAutomationCompactDeviceSpecifierJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static HomeAutomationCompactDeviceSpecifierJSON from_text(string text, bool ignore_extras)
      {
        HomeAutomationCompactDeviceSpecifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationCompactDeviceSpecifier", ignore_extras);
            JSONParse.parse_json_value(text, "Text for HomeAutomationCompactDeviceSpecifierJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static HomeAutomationCompactDeviceSpecifierJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        HomeAutomationCompactDeviceSpecifierJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type HomeAutomationCompactDeviceSpecifier", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private HomeAutomationSpecifierJSON.HoldingGenerator fieldGeneratorSpecifier;
        private HomeAutomationGroupParsingItemJSON.HoldingArrayGenerator fieldGeneratorGroupItems;
        private HomeAutomationDeviceParsingItemJSON.HoldingArrayGenerator fieldGeneratorDeviceItems;
        private HomeAutomationGroupParsingItemJSON.HoldingArrayGenerator fieldGeneratorExcludedGroupItems;
        private HomeAutomationDeviceParsingItemJSON.HoldingArrayGenerator fieldGeneratorExcludedDeviceItems;
        private HomeAutomationDeviceTypeJSON.HoldingGenerator fieldGeneratorType;
        private HomeAutomationQueryHintJSON.HoldingGenerator fieldGeneratorHint;
        private HomeAutomationGroupListJSON.HoldingGenerator fieldGeneratorUnambiguousGroups;
        private HomeAutomationDeviceListJSON.HoldingGenerator fieldGeneratorUnambiguousDevices;
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
            HomeAutomationCompactDeviceSpecifierJSON result = new HomeAutomationCompactDeviceSpecifierJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraHomeAutomationCompactDeviceSpecifierAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(HomeAutomationCompactDeviceSpecifierJSON result)
          {
            if (fieldGeneratorSpecifier.have_value)
              {
                result.setSpecifier(fieldGeneratorSpecifier.value);
                fieldGeneratorSpecifier.have_value = false;
              }
            else if ((!(result.hasSpecifier())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Specifier\" field was missing.");
              }
            if (fieldGeneratorGroupItems.have_value)
              {
                result.initGroupItems();
                int count = fieldGeneratorGroupItems.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGroupItems(fieldGeneratorGroupItems.value[num]);
                  }
                fieldGeneratorGroupItems.value.Clear();
                fieldGeneratorGroupItems.have_value = false;
              }
            if (fieldGeneratorDeviceItems.have_value)
              {
                result.initDeviceItems();
                int count = fieldGeneratorDeviceItems.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDeviceItems(fieldGeneratorDeviceItems.value[num]);
                  }
                fieldGeneratorDeviceItems.value.Clear();
                fieldGeneratorDeviceItems.have_value = false;
              }
            if (fieldGeneratorExcludedGroupItems.have_value)
              {
                result.initExcludedGroupItems();
                int count = fieldGeneratorExcludedGroupItems.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendExcludedGroupItems(fieldGeneratorExcludedGroupItems.value[num]);
                  }
                fieldGeneratorExcludedGroupItems.value.Clear();
                fieldGeneratorExcludedGroupItems.have_value = false;
              }
            if (fieldGeneratorExcludedDeviceItems.have_value)
              {
                result.initExcludedDeviceItems();
                int count = fieldGeneratorExcludedDeviceItems.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendExcludedDeviceItems(fieldGeneratorExcludedDeviceItems.value[num]);
                  }
                fieldGeneratorExcludedDeviceItems.value.Clear();
                fieldGeneratorExcludedDeviceItems.have_value = false;
              }
            if (fieldGeneratorType.have_value)
              {
                result.setType(fieldGeneratorType.value);
                fieldGeneratorType.have_value = false;
              }
            if (fieldGeneratorHint.have_value)
              {
                result.setHint(fieldGeneratorHint.value);
                fieldGeneratorHint.have_value = false;
              }
            if (fieldGeneratorUnambiguousGroups.have_value)
              {
                result.setUnambiguousGroups(fieldGeneratorUnambiguousGroups.value);
                fieldGeneratorUnambiguousGroups.have_value = false;
              }
            if (fieldGeneratorUnambiguousDevices.have_value)
              {
                result.setUnambiguousDevices(fieldGeneratorUnambiguousDevices.value);
                fieldGeneratorUnambiguousDevices.have_value = false;
              }
          }
        protected abstract void handle_result(HomeAutomationCompactDeviceSpecifierJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "eviceItems", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDeviceItems;
                    break;
                case 'E':
                    if (String.Compare(field_name, 1, "xcluded", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 9, "eviceItems", 0, 10, false) == 0) && (field_name.Length == 19))
                                    return fieldGeneratorExcludedDeviceItems;
                                break;
                            case 'G':
                                if ((String.Compare(field_name, 9, "roupItems", 0, 9, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorExcludedGroupItems;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "roupItems", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorGroupItems;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "int", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorHint;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pecifier", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorSpecifier;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorType;
                    break;
                case 'U':
                    if (String.Compare(field_name, 1, "nambiguous", 0, 10, false) == 0)
                      {
                        switch (field_name[11])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 12, "evices", 0, 6, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorUnambiguousDevices;
                                break;
                            case 'G':
                                if ((String.Compare(field_name, 12, "roups", 0, 5, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorUnambiguousGroups;
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
            fieldGeneratorSpecifier = new HomeAutomationSpecifierJSON.HoldingGenerator("field \"Specifier\" of the HomeAutomationCompactDeviceSpecifier class", ignore_extras);
            fieldGeneratorGroupItems = new HomeAutomationGroupParsingItemJSON.HoldingArrayGenerator("field \"GroupItems\" of the HomeAutomationCompactDeviceSpecifier class", ignore_extras);
            fieldGeneratorDeviceItems = new HomeAutomationDeviceParsingItemJSON.HoldingArrayGenerator("field \"DeviceItems\" of the HomeAutomationCompactDeviceSpecifier class", ignore_extras);
            fieldGeneratorExcludedGroupItems = new HomeAutomationGroupParsingItemJSON.HoldingArrayGenerator("field \"ExcludedGroupItems\" of the HomeAutomationCompactDeviceSpecifier class", ignore_extras);
            fieldGeneratorExcludedDeviceItems = new HomeAutomationDeviceParsingItemJSON.HoldingArrayGenerator("field \"ExcludedDeviceItems\" of the HomeAutomationCompactDeviceSpecifier class", ignore_extras);
            fieldGeneratorType = new HomeAutomationDeviceTypeJSON.HoldingGenerator("field \"Type\" of the HomeAutomationCompactDeviceSpecifier class", ignore_extras);
            fieldGeneratorHint = new HomeAutomationQueryHintJSON.HoldingGenerator("field \"Hint\" of the HomeAutomationCompactDeviceSpecifier class", ignore_extras);
            fieldGeneratorUnambiguousGroups = new HomeAutomationGroupListJSON.HoldingGenerator("field \"UnambiguousGroups\" of the HomeAutomationCompactDeviceSpecifier class", ignore_extras);
            fieldGeneratorUnambiguousDevices = new HomeAutomationDeviceListJSON.HoldingGenerator("field \"UnambiguousDevices\" of the HomeAutomationCompactDeviceSpecifier class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the HomeAutomationCompactDeviceSpecifier class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSpecifier = new HomeAutomationSpecifierJSON.HoldingGenerator("field \"Specifier\" of the HomeAutomationCompactDeviceSpecifier class", false);
            fieldGeneratorGroupItems = new HomeAutomationGroupParsingItemJSON.HoldingArrayGenerator("field \"GroupItems\" of the HomeAutomationCompactDeviceSpecifier class", false);
            fieldGeneratorDeviceItems = new HomeAutomationDeviceParsingItemJSON.HoldingArrayGenerator("field \"DeviceItems\" of the HomeAutomationCompactDeviceSpecifier class", false);
            fieldGeneratorExcludedGroupItems = new HomeAutomationGroupParsingItemJSON.HoldingArrayGenerator("field \"ExcludedGroupItems\" of the HomeAutomationCompactDeviceSpecifier class", false);
            fieldGeneratorExcludedDeviceItems = new HomeAutomationDeviceParsingItemJSON.HoldingArrayGenerator("field \"ExcludedDeviceItems\" of the HomeAutomationCompactDeviceSpecifier class", false);
            fieldGeneratorType = new HomeAutomationDeviceTypeJSON.HoldingGenerator("field \"Type\" of the HomeAutomationCompactDeviceSpecifier class", false);
            fieldGeneratorHint = new HomeAutomationQueryHintJSON.HoldingGenerator("field \"Hint\" of the HomeAutomationCompactDeviceSpecifier class", false);
            fieldGeneratorUnambiguousGroups = new HomeAutomationGroupListJSON.HoldingGenerator("field \"UnambiguousGroups\" of the HomeAutomationCompactDeviceSpecifier class", false);
            fieldGeneratorUnambiguousDevices = new HomeAutomationDeviceListJSON.HoldingGenerator("field \"UnambiguousDevices\" of the HomeAutomationCompactDeviceSpecifier class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the HomeAutomationCompactDeviceSpecifier class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSpecifier.reset();
            fieldGeneratorGroupItems.reset();
            fieldGeneratorDeviceItems.reset();
            fieldGeneratorExcludedGroupItems.reset();
            fieldGeneratorExcludedDeviceItems.reset();
            fieldGeneratorType.reset();
            fieldGeneratorHint.reset();
            fieldGeneratorUnambiguousGroups.reset();
            fieldGeneratorUnambiguousDevices.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSpecifier.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorGroupItems.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDeviceItems.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorExcludedGroupItems.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorExcludedDeviceItems.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorType.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHint.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUnambiguousGroups.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorUnambiguousDevices.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSpecifier.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorGroupItems.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDeviceItems.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorExcludedGroupItems.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorExcludedDeviceItems.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorType.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHint.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUnambiguousGroups.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorUnambiguousDevices.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(HomeAutomationCompactDeviceSpecifierJSON  result)
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
        public HomeAutomationCompactDeviceSpecifierJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(HomeAutomationCompactDeviceSpecifierJSON  result)
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
    protected virtual void handle_result(List<HomeAutomationCompactDeviceSpecifierJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<HomeAutomationCompactDeviceSpecifierJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<HomeAutomationCompactDeviceSpecifierJSON>();
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
    public List<HomeAutomationCompactDeviceSpecifierJSON> value;
  };
  };
