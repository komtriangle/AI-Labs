/* file "RestaurantOrderingMenuDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RestaurantOrderingMenuDataJSON : JSONBase
  {
    private bool flagHasStores;
    private List< RestaurantOrderingMenuDataStoreJSON  > storeStores;
    private bool flagHasMenus;
    private List< RestaurantOrderingMenuDataMenuJSON  > storeMenus;
    private bool flagHasSections;
    private List< RestaurantOrderingMenuDataSectionJSON  > storeSections;
    private bool flagHasItems;
    private List< RestaurantOrderingMenuDataItemJSON  > storeItems;
    private bool flagHasModifierGroups;
    private List< RestaurantOrderingMenuDataModifierGroupJSON  > storeModifierGroups;
    private bool flagHasRestaurantTags;
    private List< RestaurantOrderingMenuDataTagJSON  > storeRestaurantTags;
    private bool flagHasPointOfSaleProviderConfiguration;
    private PointOfSaleProviderConfigurationJSON  storePointOfSaleProviderConfiguration;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStores(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Stores of RestaurantOrderingMenuDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Stores of RestaurantOrderingMenuDataJSON has too few elements.");
        List< RestaurantOrderingMenuDataStoreJSON  > vector_Stores1 = new List< RestaurantOrderingMenuDataStoreJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantOrderingMenuDataStoreJSON convert_classy = RestaurantOrderingMenuDataStoreJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Stores1.Add(convert_classy);
          }
        Debug.Assert(vector_Stores1.Count >= 1);
        initStores();
        for (int num1 = 0; num1 < vector_Stores1.Count; ++num1)
            appendStores(vector_Stores1[num1]);
        for (int num1 = 0; num1 < vector_Stores1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMenus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Menus of RestaurantOrderingMenuDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RestaurantOrderingMenuDataMenuJSON  > vector_Menus1 = new List< RestaurantOrderingMenuDataMenuJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantOrderingMenuDataMenuJSON convert_classy = RestaurantOrderingMenuDataMenuJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Menus1.Add(convert_classy);
          }
        initMenus();
        for (int num2 = 0; num2 < vector_Menus1.Count; ++num2)
            appendMenus(vector_Menus1[num2]);
        for (int num1 = 0; num1 < vector_Menus1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSections(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Sections of RestaurantOrderingMenuDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RestaurantOrderingMenuDataSectionJSON  > vector_Sections1 = new List< RestaurantOrderingMenuDataSectionJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantOrderingMenuDataSectionJSON convert_classy = RestaurantOrderingMenuDataSectionJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Sections1.Add(convert_classy);
          }
        initSections();
        for (int num3 = 0; num3 < vector_Sections1.Count; ++num3)
            appendSections(vector_Sections1[num3]);
        for (int num1 = 0; num1 < vector_Sections1.Count; ++num1)
          {
          }
      }


    private void  fromJSONItems(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Items of RestaurantOrderingMenuDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RestaurantOrderingMenuDataItemJSON  > vector_Items1 = new List< RestaurantOrderingMenuDataItemJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantOrderingMenuDataItemJSON convert_classy = RestaurantOrderingMenuDataItemJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Items1.Add(convert_classy);
          }
        initItems();
        for (int num4 = 0; num4 < vector_Items1.Count; ++num4)
            appendItems(vector_Items1[num4]);
        for (int num1 = 0; num1 < vector_Items1.Count; ++num1)
          {
          }
      }


    private void  fromJSONModifierGroups(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ModifierGroups of RestaurantOrderingMenuDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RestaurantOrderingMenuDataModifierGroupJSON  > vector_ModifierGroups1 = new List< RestaurantOrderingMenuDataModifierGroupJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantOrderingMenuDataModifierGroupJSON convert_classy = RestaurantOrderingMenuDataModifierGroupJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ModifierGroups1.Add(convert_classy);
          }
        initModifierGroups();
        for (int num5 = 0; num5 < vector_ModifierGroups1.Count; ++num5)
            appendModifierGroups(vector_ModifierGroups1[num5]);
        for (int num1 = 0; num1 < vector_ModifierGroups1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRestaurantTags(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field RestaurantTags of RestaurantOrderingMenuDataJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RestaurantOrderingMenuDataTagJSON  > vector_RestaurantTags1 = new List< RestaurantOrderingMenuDataTagJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantOrderingMenuDataTagJSON convert_classy = RestaurantOrderingMenuDataTagJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_RestaurantTags1.Add(convert_classy);
          }
        initRestaurantTags();
        for (int num6 = 0; num6 < vector_RestaurantTags1.Count; ++num6)
            appendRestaurantTags(vector_RestaurantTags1[num6]);
        for (int num1 = 0; num1 < vector_RestaurantTags1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPointOfSaleProviderConfiguration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PointOfSaleProviderConfigurationJSON convert_classy = PointOfSaleProviderConfigurationJSON.from_json(json_value, ignore_extras, true);
        setPointOfSaleProviderConfiguration(convert_classy);
      }


    public RestaurantOrderingMenuDataJSON()
      {
        flagHasStores = false;
        flagHasMenus = false;
        flagHasSections = false;
        flagHasItems = false;
        flagHasModifierGroups = false;
        flagHasRestaurantTags = false;
        flagHasPointOfSaleProviderConfiguration = false;
        storeStores = new List< RestaurantOrderingMenuDataStoreJSON  >();
        storeMenus = new List< RestaurantOrderingMenuDataMenuJSON  >();
        storeSections = new List< RestaurantOrderingMenuDataSectionJSON  >();
        storeItems = new List< RestaurantOrderingMenuDataItemJSON  >();
        storeModifierGroups = new List< RestaurantOrderingMenuDataModifierGroupJSON  >();
        storeRestaurantTags = new List< RestaurantOrderingMenuDataTagJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStores()
      {
        return flagHasStores;
      }

    public int  countOfStores()
      {
        Debug.Assert(flagHasStores);
        return storeStores.Count;
      }

    public RestaurantOrderingMenuDataStoreJSON   elementOfStores(int element_num)
      {
        Debug.Assert(flagHasStores);
        return storeStores[element_num];
      }

    public List< RestaurantOrderingMenuDataStoreJSON  >  getStores()
      {
        Debug.Assert(flagHasStores);
        return storeStores;
      }

    public bool  hasMenus()
      {
        return flagHasMenus;
      }

    public int  countOfMenus()
      {
        Debug.Assert(flagHasMenus);
        return storeMenus.Count;
      }

    public RestaurantOrderingMenuDataMenuJSON   elementOfMenus(int element_num)
      {
        Debug.Assert(flagHasMenus);
        return storeMenus[element_num];
      }

    public List< RestaurantOrderingMenuDataMenuJSON  >  getMenus()
      {
        Debug.Assert(flagHasMenus);
        return storeMenus;
      }

    public bool  hasSections()
      {
        return flagHasSections;
      }

    public int  countOfSections()
      {
        Debug.Assert(flagHasSections);
        return storeSections.Count;
      }

    public RestaurantOrderingMenuDataSectionJSON   elementOfSections(int element_num)
      {
        Debug.Assert(flagHasSections);
        return storeSections[element_num];
      }

    public List< RestaurantOrderingMenuDataSectionJSON  >  getSections()
      {
        Debug.Assert(flagHasSections);
        return storeSections;
      }

    public bool  hasItems()
      {
        return flagHasItems;
      }

    public int  countOfItems()
      {
        Debug.Assert(flagHasItems);
        return storeItems.Count;
      }

    public RestaurantOrderingMenuDataItemJSON   elementOfItems(int element_num)
      {
        Debug.Assert(flagHasItems);
        return storeItems[element_num];
      }

    public List< RestaurantOrderingMenuDataItemJSON  >  getItems()
      {
        Debug.Assert(flagHasItems);
        return storeItems;
      }

    public bool  hasModifierGroups()
      {
        return flagHasModifierGroups;
      }

    public int  countOfModifierGroups()
      {
        Debug.Assert(flagHasModifierGroups);
        return storeModifierGroups.Count;
      }

    public RestaurantOrderingMenuDataModifierGroupJSON   elementOfModifierGroups(int element_num)
      {
        Debug.Assert(flagHasModifierGroups);
        return storeModifierGroups[element_num];
      }

    public List< RestaurantOrderingMenuDataModifierGroupJSON  >  getModifierGroups()
      {
        Debug.Assert(flagHasModifierGroups);
        return storeModifierGroups;
      }

    public bool  hasRestaurantTags()
      {
        return flagHasRestaurantTags;
      }

    public int  countOfRestaurantTags()
      {
        Debug.Assert(flagHasRestaurantTags);
        return storeRestaurantTags.Count;
      }

    public RestaurantOrderingMenuDataTagJSON   elementOfRestaurantTags(int element_num)
      {
        Debug.Assert(flagHasRestaurantTags);
        return storeRestaurantTags[element_num];
      }

    public List< RestaurantOrderingMenuDataTagJSON  >  getRestaurantTags()
      {
        Debug.Assert(flagHasRestaurantTags);
        return storeRestaurantTags;
      }

    public bool  hasPointOfSaleProviderConfiguration()
      {
        return flagHasPointOfSaleProviderConfiguration;
      }

    public PointOfSaleProviderConfigurationJSON   getPointOfSaleProviderConfiguration()
      {
        Debug.Assert(flagHasPointOfSaleProviderConfiguration);
        return storePointOfSaleProviderConfiguration;
      }


    public virtual int extraRestaurantOrderingMenuDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantOrderingMenuDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantOrderingMenuDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initStores()
      {
        if (flagHasStores)
          {
            for (int num1 = 0; num1 < storeStores.Count; ++num1)
              {
              }
          }
        flagHasStores = true;
        storeStores.Clear();
      }
    public void appendStores(RestaurantOrderingMenuDataStoreJSON  to_append)
      {
        if (!flagHasStores)
          {
            flagHasStores = true;
            storeStores.Clear();
          }
        Debug.Assert(flagHasStores);
        storeStores.Add(to_append);
      }
    public void unsetStores()
      {
        if (flagHasStores)
          {
            for (int num2 = 0; num2 < storeStores.Count; ++num2)
              {
              }
          }
        flagHasStores = false;
        storeStores.Clear();
      }
    public void initMenus()
      {
        if (flagHasMenus)
          {
            for (int num3 = 0; num3 < storeMenus.Count; ++num3)
              {
              }
          }
        flagHasMenus = true;
        storeMenus.Clear();
      }
    public void appendMenus(RestaurantOrderingMenuDataMenuJSON  to_append)
      {
        if (!flagHasMenus)
          {
            flagHasMenus = true;
            storeMenus.Clear();
          }
        Debug.Assert(flagHasMenus);
        storeMenus.Add(to_append);
      }
    public void unsetMenus()
      {
        if (flagHasMenus)
          {
            for (int num4 = 0; num4 < storeMenus.Count; ++num4)
              {
              }
          }
        flagHasMenus = false;
        storeMenus.Clear();
      }
    public void initSections()
      {
        if (flagHasSections)
          {
            for (int num5 = 0; num5 < storeSections.Count; ++num5)
              {
              }
          }
        flagHasSections = true;
        storeSections.Clear();
      }
    public void appendSections(RestaurantOrderingMenuDataSectionJSON  to_append)
      {
        if (!flagHasSections)
          {
            flagHasSections = true;
            storeSections.Clear();
          }
        Debug.Assert(flagHasSections);
        storeSections.Add(to_append);
      }
    public void unsetSections()
      {
        if (flagHasSections)
          {
            for (int num6 = 0; num6 < storeSections.Count; ++num6)
              {
              }
          }
        flagHasSections = false;
        storeSections.Clear();
      }
    public void initItems()
      {
        if (flagHasItems)
          {
            for (int num7 = 0; num7 < storeItems.Count; ++num7)
              {
              }
          }
        flagHasItems = true;
        storeItems.Clear();
      }
    public void appendItems(RestaurantOrderingMenuDataItemJSON  to_append)
      {
        if (!flagHasItems)
          {
            flagHasItems = true;
            storeItems.Clear();
          }
        Debug.Assert(flagHasItems);
        storeItems.Add(to_append);
      }
    public void unsetItems()
      {
        if (flagHasItems)
          {
            for (int num8 = 0; num8 < storeItems.Count; ++num8)
              {
              }
          }
        flagHasItems = false;
        storeItems.Clear();
      }
    public void initModifierGroups()
      {
        if (flagHasModifierGroups)
          {
            for (int num9 = 0; num9 < storeModifierGroups.Count; ++num9)
              {
              }
          }
        flagHasModifierGroups = true;
        storeModifierGroups.Clear();
      }
    public void appendModifierGroups(RestaurantOrderingMenuDataModifierGroupJSON  to_append)
      {
        if (!flagHasModifierGroups)
          {
            flagHasModifierGroups = true;
            storeModifierGroups.Clear();
          }
        Debug.Assert(flagHasModifierGroups);
        storeModifierGroups.Add(to_append);
      }
    public void unsetModifierGroups()
      {
        if (flagHasModifierGroups)
          {
            for (int num10 = 0; num10 < storeModifierGroups.Count; ++num10)
              {
              }
          }
        flagHasModifierGroups = false;
        storeModifierGroups.Clear();
      }
    public void initRestaurantTags()
      {
        if (flagHasRestaurantTags)
          {
            for (int num11 = 0; num11 < storeRestaurantTags.Count; ++num11)
              {
              }
          }
        flagHasRestaurantTags = true;
        storeRestaurantTags.Clear();
      }
    public void appendRestaurantTags(RestaurantOrderingMenuDataTagJSON  to_append)
      {
        if (!flagHasRestaurantTags)
          {
            flagHasRestaurantTags = true;
            storeRestaurantTags.Clear();
          }
        Debug.Assert(flagHasRestaurantTags);
        storeRestaurantTags.Add(to_append);
      }
    public void unsetRestaurantTags()
      {
        if (flagHasRestaurantTags)
          {
            for (int num12 = 0; num12 < storeRestaurantTags.Count; ++num12)
              {
              }
          }
        flagHasRestaurantTags = false;
        storeRestaurantTags.Clear();
      }
    public void setPointOfSaleProviderConfiguration(PointOfSaleProviderConfigurationJSON  new_value)
      {
        if (flagHasPointOfSaleProviderConfiguration)
          {
          }
        flagHasPointOfSaleProviderConfiguration = true;
        storePointOfSaleProviderConfiguration = new_value;
      }
    public void unsetPointOfSaleProviderConfiguration()
      {
        if (flagHasPointOfSaleProviderConfiguration)
          {
          }
        flagHasPointOfSaleProviderConfiguration = false;
      }

    public virtual void extraRestaurantOrderingMenuDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantOrderingMenuDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantOrderingMenuDataLookup(key);
        if (old_field == null)
          {
            extraRestaurantOrderingMenuDataAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStores);
        if (flagHasStores)
          {
            handler.start_pair("Stores");
            Debug.Assert(storeStores.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeStores.Count; ++num1)
              {
                if (partial_allowed)
                    storeStores[num1].write_partial_as_json(handler);
                else
                    storeStores[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasMenus)
          {
            handler.start_pair("Menus");
            handler.start_array();
            for (int num2 = 0; num2 < storeMenus.Count; ++num2)
              {
                if (partial_allowed)
                    storeMenus[num2].write_partial_as_json(handler);
                else
                    storeMenus[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSections)
          {
            handler.start_pair("Sections");
            handler.start_array();
            for (int num3 = 0; num3 < storeSections.Count; ++num3)
              {
                if (partial_allowed)
                    storeSections[num3].write_partial_as_json(handler);
                else
                    storeSections[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasItems)
          {
            handler.start_pair("Items");
            handler.start_array();
            for (int num4 = 0; num4 < storeItems.Count; ++num4)
              {
                if (partial_allowed)
                    storeItems[num4].write_partial_as_json(handler);
                else
                    storeItems[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasModifierGroups)
          {
            handler.start_pair("ModifierGroups");
            handler.start_array();
            for (int num5 = 0; num5 < storeModifierGroups.Count; ++num5)
              {
                if (partial_allowed)
                    storeModifierGroups[num5].write_partial_as_json(handler);
                else
                    storeModifierGroups[num5].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRestaurantTags)
          {
            handler.start_pair("RestaurantTags");
            handler.start_array();
            for (int num6 = 0; num6 < storeRestaurantTags.Count; ++num6)
              {
                if (partial_allowed)
                    storeRestaurantTags[num6].write_partial_as_json(handler);
                else
                    storeRestaurantTags[num6].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasPointOfSaleProviderConfiguration)
          {
            handler.start_pair("PointOfSaleProviderConfiguration");
            if (partial_allowed)
                storePointOfSaleProviderConfiguration.write_partial_as_json(handler);
            else
                storePointOfSaleProviderConfiguration.write_as_json(handler);
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
        if (!(hasStores()))
          {
            return "When parsing the object for %what%, the \"Stores\" field was missing.";
          }
        return null;
      }

    public static RestaurantOrderingMenuDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuData", ignore_extras);
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
    public static RestaurantOrderingMenuDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantOrderingMenuDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantOrderingMenuDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuData", ignore_extras);
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
    public static RestaurantOrderingMenuDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantOrderingMenuDataJSON from_text(string text, bool ignore_extras)
      {
        RestaurantOrderingMenuDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantOrderingMenuDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantOrderingMenuDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantOrderingMenuDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantOrderingMenuData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private RestaurantOrderingMenuDataStoreJSON.HoldingArrayGenerator fieldGeneratorStores;
        private RestaurantOrderingMenuDataMenuJSON.HoldingArrayGenerator fieldGeneratorMenus;
        private RestaurantOrderingMenuDataSectionJSON.HoldingArrayGenerator fieldGeneratorSections;
        private RestaurantOrderingMenuDataItemJSON.HoldingArrayGenerator fieldGeneratorItems;
        private RestaurantOrderingMenuDataModifierGroupJSON.HoldingArrayGenerator fieldGeneratorModifierGroups;
        private RestaurantOrderingMenuDataTagJSON.HoldingArrayGenerator fieldGeneratorRestaurantTags;
        private PointOfSaleProviderConfigurationJSON.HoldingGenerator fieldGeneratorPointOfSaleProviderConfiguration;
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
            RestaurantOrderingMenuDataJSON result = new RestaurantOrderingMenuDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantOrderingMenuDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantOrderingMenuDataJSON result)
          {
            if (fieldGeneratorStores.have_value)
              {
                result.initStores();
                int count = fieldGeneratorStores.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStores(fieldGeneratorStores.value[num]);
                  }
                fieldGeneratorStores.value.Clear();
                fieldGeneratorStores.have_value = false;
              }
            else if ((!(result.hasStores())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Stores\" field was missing.");
              }
            if (fieldGeneratorMenus.have_value)
              {
                result.initMenus();
                int count = fieldGeneratorMenus.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMenus(fieldGeneratorMenus.value[num]);
                  }
                fieldGeneratorMenus.value.Clear();
                fieldGeneratorMenus.have_value = false;
              }
            if (fieldGeneratorSections.have_value)
              {
                result.initSections();
                int count = fieldGeneratorSections.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSections(fieldGeneratorSections.value[num]);
                  }
                fieldGeneratorSections.value.Clear();
                fieldGeneratorSections.have_value = false;
              }
            if (fieldGeneratorItems.have_value)
              {
                result.initItems();
                int count = fieldGeneratorItems.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendItems(fieldGeneratorItems.value[num]);
                  }
                fieldGeneratorItems.value.Clear();
                fieldGeneratorItems.have_value = false;
              }
            if (fieldGeneratorModifierGroups.have_value)
              {
                result.initModifierGroups();
                int count = fieldGeneratorModifierGroups.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendModifierGroups(fieldGeneratorModifierGroups.value[num]);
                  }
                fieldGeneratorModifierGroups.value.Clear();
                fieldGeneratorModifierGroups.have_value = false;
              }
            if (fieldGeneratorRestaurantTags.have_value)
              {
                result.initRestaurantTags();
                int count = fieldGeneratorRestaurantTags.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendRestaurantTags(fieldGeneratorRestaurantTags.value[num]);
                  }
                fieldGeneratorRestaurantTags.value.Clear();
                fieldGeneratorRestaurantTags.have_value = false;
              }
            if (fieldGeneratorPointOfSaleProviderConfiguration.have_value)
              {
                result.setPointOfSaleProviderConfiguration(fieldGeneratorPointOfSaleProviderConfiguration.value);
                fieldGeneratorPointOfSaleProviderConfiguration.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantOrderingMenuDataJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'I':
                    if ((String.Compare(field_name, 1, "tems", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratorItems;
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "nus", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorMenus;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "difierGroups", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorModifierGroups;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "ointOfSaleProviderConfiguration", 0, 31, false) == 0) && (field_name.Length == 32))
                        return fieldGeneratorPointOfSaleProviderConfiguration;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "estaurantTags", 0, 13, false) == 0) && (field_name.Length == 14))
                        return fieldGeneratorRestaurantTags;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "ctions", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorSections;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "ores", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorStores;
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStores = new RestaurantOrderingMenuDataStoreJSON.HoldingArrayGenerator("field \"Stores\" of the RestaurantOrderingMenuData class", ignore_extras);
            fieldGeneratorMenus = new RestaurantOrderingMenuDataMenuJSON.HoldingArrayGenerator("field \"Menus\" of the RestaurantOrderingMenuData class", ignore_extras);
            fieldGeneratorSections = new RestaurantOrderingMenuDataSectionJSON.HoldingArrayGenerator("field \"Sections\" of the RestaurantOrderingMenuData class", ignore_extras);
            fieldGeneratorItems = new RestaurantOrderingMenuDataItemJSON.HoldingArrayGenerator("field \"Items\" of the RestaurantOrderingMenuData class", ignore_extras);
            fieldGeneratorModifierGroups = new RestaurantOrderingMenuDataModifierGroupJSON.HoldingArrayGenerator("field \"ModifierGroups\" of the RestaurantOrderingMenuData class", ignore_extras);
            fieldGeneratorRestaurantTags = new RestaurantOrderingMenuDataTagJSON.HoldingArrayGenerator("field \"RestaurantTags\" of the RestaurantOrderingMenuData class", ignore_extras);
            fieldGeneratorPointOfSaleProviderConfiguration = new PointOfSaleProviderConfigurationJSON.HoldingGenerator("field \"PointOfSaleProviderConfiguration\" of the RestaurantOrderingMenuData class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantOrderingMenuData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStores = new RestaurantOrderingMenuDataStoreJSON.HoldingArrayGenerator("field \"Stores\" of the RestaurantOrderingMenuData class", false);
            fieldGeneratorMenus = new RestaurantOrderingMenuDataMenuJSON.HoldingArrayGenerator("field \"Menus\" of the RestaurantOrderingMenuData class", false);
            fieldGeneratorSections = new RestaurantOrderingMenuDataSectionJSON.HoldingArrayGenerator("field \"Sections\" of the RestaurantOrderingMenuData class", false);
            fieldGeneratorItems = new RestaurantOrderingMenuDataItemJSON.HoldingArrayGenerator("field \"Items\" of the RestaurantOrderingMenuData class", false);
            fieldGeneratorModifierGroups = new RestaurantOrderingMenuDataModifierGroupJSON.HoldingArrayGenerator("field \"ModifierGroups\" of the RestaurantOrderingMenuData class", false);
            fieldGeneratorRestaurantTags = new RestaurantOrderingMenuDataTagJSON.HoldingArrayGenerator("field \"RestaurantTags\" of the RestaurantOrderingMenuData class", false);
            fieldGeneratorPointOfSaleProviderConfiguration = new PointOfSaleProviderConfigurationJSON.HoldingGenerator("field \"PointOfSaleProviderConfiguration\" of the RestaurantOrderingMenuData class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantOrderingMenuData class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStores.reset();
            fieldGeneratorMenus.reset();
            fieldGeneratorSections.reset();
            fieldGeneratorItems.reset();
            fieldGeneratorModifierGroups.reset();
            fieldGeneratorRestaurantTags.reset();
            fieldGeneratorPointOfSaleProviderConfiguration.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStores.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMenus.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSections.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorItems.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorModifierGroups.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRestaurantTags.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPointOfSaleProviderConfiguration.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStores.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMenus.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSections.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorItems.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorModifierGroups.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRestaurantTags.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPointOfSaleProviderConfiguration.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantOrderingMenuDataJSON  result)
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
        public RestaurantOrderingMenuDataJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantOrderingMenuDataJSON  result)
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
    protected virtual void handle_result(List<RestaurantOrderingMenuDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantOrderingMenuDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantOrderingMenuDataJSON>();
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
    public List<RestaurantOrderingMenuDataJSON> value;
  };
  };
