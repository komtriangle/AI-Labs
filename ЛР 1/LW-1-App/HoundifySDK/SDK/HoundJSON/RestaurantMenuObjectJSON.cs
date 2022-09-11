/* file "RestaurantMenuObjectJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RestaurantMenuObjectJSON : JSONBase
  {
    private bool flagHasFoodObjects;
    private List< RestaurantMenuMenuItemJSON  > storeFoodObjects;
    private bool flagHasModifications;
    private List< RestaurantMenuItemModifierJSON  > storeModifications;
    private bool flagHasCondiments;
    private List< RestaurantMenuCondimentJSON  > storeCondiments;
    private bool flagHasCategories;
    private List< RestaurantMenuCategoryJSON  > storeCategories;
    private bool flagHasConfig;
    private RestaurantMenuConfigJSON  storeConfig;
    private bool flagHasMetadata;
    private RestaurantMenuMetadataJSON  storeMetadata;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFoodObjects(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FoodObjects of RestaurantMenuObjectJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RestaurantMenuMenuItemJSON  > vector_FoodObjects1 = new List< RestaurantMenuMenuItemJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantMenuMenuItemJSON convert_classy = RestaurantMenuMenuItemJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FoodObjects1.Add(convert_classy);
          }
        initFoodObjects();
        for (int num1 = 0; num1 < vector_FoodObjects1.Count; ++num1)
            appendFoodObjects(vector_FoodObjects1[num1]);
        for (int num1 = 0; num1 < vector_FoodObjects1.Count; ++num1)
          {
          }
      }


    private void  fromJSONModifications(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Modifications of RestaurantMenuObjectJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RestaurantMenuItemModifierJSON  > vector_Modifications1 = new List< RestaurantMenuItemModifierJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantMenuItemModifierJSON convert_classy = RestaurantMenuItemModifierJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Modifications1.Add(convert_classy);
          }
        initModifications();
        for (int num2 = 0; num2 < vector_Modifications1.Count; ++num2)
            appendModifications(vector_Modifications1[num2]);
        for (int num1 = 0; num1 < vector_Modifications1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCondiments(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Condiments of RestaurantMenuObjectJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RestaurantMenuCondimentJSON  > vector_Condiments1 = new List< RestaurantMenuCondimentJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantMenuCondimentJSON convert_classy = RestaurantMenuCondimentJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Condiments1.Add(convert_classy);
          }
        initCondiments();
        for (int num3 = 0; num3 < vector_Condiments1.Count; ++num3)
            appendCondiments(vector_Condiments1[num3]);
        for (int num1 = 0; num1 < vector_Condiments1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCategories(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Categories of RestaurantMenuObjectJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RestaurantMenuCategoryJSON  > vector_Categories1 = new List< RestaurantMenuCategoryJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantMenuCategoryJSON convert_classy = RestaurantMenuCategoryJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Categories1.Add(convert_classy);
          }
        initCategories();
        for (int num4 = 0; num4 < vector_Categories1.Count; ++num4)
            appendCategories(vector_Categories1[num4]);
        for (int num1 = 0; num1 < vector_Categories1.Count; ++num1)
          {
          }
      }


    private void  fromJSONConfig(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RestaurantMenuConfigJSON convert_classy = RestaurantMenuConfigJSON.from_json(json_value, ignore_extras, true);
        setConfig(convert_classy);
      }


    private void  fromJSONMetadata(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RestaurantMenuMetadataJSON convert_classy = RestaurantMenuMetadataJSON.from_json(json_value, ignore_extras, true);
        setMetadata(convert_classy);
      }


    public RestaurantMenuObjectJSON()
      {
        flagHasFoodObjects = false;
        flagHasModifications = false;
        flagHasCondiments = false;
        flagHasCategories = false;
        flagHasConfig = false;
        flagHasMetadata = false;
        storeFoodObjects = new List< RestaurantMenuMenuItemJSON  >();
        storeModifications = new List< RestaurantMenuItemModifierJSON  >();
        storeCondiments = new List< RestaurantMenuCondimentJSON  >();
        storeCategories = new List< RestaurantMenuCategoryJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFoodObjects()
      {
        return flagHasFoodObjects;
      }

    public int  countOfFoodObjects()
      {
        Debug.Assert(flagHasFoodObjects);
        return storeFoodObjects.Count;
      }

    public RestaurantMenuMenuItemJSON   elementOfFoodObjects(int element_num)
      {
        Debug.Assert(flagHasFoodObjects);
        return storeFoodObjects[element_num];
      }

    public List< RestaurantMenuMenuItemJSON  >  getFoodObjects()
      {
        Debug.Assert(flagHasFoodObjects);
        return storeFoodObjects;
      }

    public bool  hasModifications()
      {
        return flagHasModifications;
      }

    public int  countOfModifications()
      {
        Debug.Assert(flagHasModifications);
        return storeModifications.Count;
      }

    public RestaurantMenuItemModifierJSON   elementOfModifications(int element_num)
      {
        Debug.Assert(flagHasModifications);
        return storeModifications[element_num];
      }

    public List< RestaurantMenuItemModifierJSON  >  getModifications()
      {
        Debug.Assert(flagHasModifications);
        return storeModifications;
      }

    public bool  hasCondiments()
      {
        return flagHasCondiments;
      }

    public int  countOfCondiments()
      {
        Debug.Assert(flagHasCondiments);
        return storeCondiments.Count;
      }

    public RestaurantMenuCondimentJSON   elementOfCondiments(int element_num)
      {
        Debug.Assert(flagHasCondiments);
        return storeCondiments[element_num];
      }

    public List< RestaurantMenuCondimentJSON  >  getCondiments()
      {
        Debug.Assert(flagHasCondiments);
        return storeCondiments;
      }

    public bool  hasCategories()
      {
        return flagHasCategories;
      }

    public int  countOfCategories()
      {
        Debug.Assert(flagHasCategories);
        return storeCategories.Count;
      }

    public RestaurantMenuCategoryJSON   elementOfCategories(int element_num)
      {
        Debug.Assert(flagHasCategories);
        return storeCategories[element_num];
      }

    public List< RestaurantMenuCategoryJSON  >  getCategories()
      {
        Debug.Assert(flagHasCategories);
        return storeCategories;
      }

    public bool  hasConfig()
      {
        return flagHasConfig;
      }

    public RestaurantMenuConfigJSON   getConfig()
      {
        Debug.Assert(flagHasConfig);
        return storeConfig;
      }

    public bool  hasMetadata()
      {
        return flagHasMetadata;
      }

    public RestaurantMenuMetadataJSON   getMetadata()
      {
        Debug.Assert(flagHasMetadata);
        return storeMetadata;
      }


    public virtual int extraRestaurantMenuObjectComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantMenuObjectComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantMenuObjectComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantMenuObjectLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initFoodObjects()
      {
        if (flagHasFoodObjects)
          {
            for (int num1 = 0; num1 < storeFoodObjects.Count; ++num1)
              {
              }
          }
        flagHasFoodObjects = true;
        storeFoodObjects.Clear();
      }
    public void appendFoodObjects(RestaurantMenuMenuItemJSON  to_append)
      {
        if (!flagHasFoodObjects)
          {
            flagHasFoodObjects = true;
            storeFoodObjects.Clear();
          }
        Debug.Assert(flagHasFoodObjects);
        storeFoodObjects.Add(to_append);
      }
    public void unsetFoodObjects()
      {
        if (flagHasFoodObjects)
          {
            for (int num2 = 0; num2 < storeFoodObjects.Count; ++num2)
              {
              }
          }
        flagHasFoodObjects = false;
        storeFoodObjects.Clear();
      }
    public void initModifications()
      {
        if (flagHasModifications)
          {
            for (int num3 = 0; num3 < storeModifications.Count; ++num3)
              {
              }
          }
        flagHasModifications = true;
        storeModifications.Clear();
      }
    public void appendModifications(RestaurantMenuItemModifierJSON  to_append)
      {
        if (!flagHasModifications)
          {
            flagHasModifications = true;
            storeModifications.Clear();
          }
        Debug.Assert(flagHasModifications);
        storeModifications.Add(to_append);
      }
    public void unsetModifications()
      {
        if (flagHasModifications)
          {
            for (int num4 = 0; num4 < storeModifications.Count; ++num4)
              {
              }
          }
        flagHasModifications = false;
        storeModifications.Clear();
      }
    public void initCondiments()
      {
        if (flagHasCondiments)
          {
            for (int num5 = 0; num5 < storeCondiments.Count; ++num5)
              {
              }
          }
        flagHasCondiments = true;
        storeCondiments.Clear();
      }
    public void appendCondiments(RestaurantMenuCondimentJSON  to_append)
      {
        if (!flagHasCondiments)
          {
            flagHasCondiments = true;
            storeCondiments.Clear();
          }
        Debug.Assert(flagHasCondiments);
        storeCondiments.Add(to_append);
      }
    public void unsetCondiments()
      {
        if (flagHasCondiments)
          {
            for (int num6 = 0; num6 < storeCondiments.Count; ++num6)
              {
              }
          }
        flagHasCondiments = false;
        storeCondiments.Clear();
      }
    public void initCategories()
      {
        if (flagHasCategories)
          {
            for (int num7 = 0; num7 < storeCategories.Count; ++num7)
              {
              }
          }
        flagHasCategories = true;
        storeCategories.Clear();
      }
    public void appendCategories(RestaurantMenuCategoryJSON  to_append)
      {
        if (!flagHasCategories)
          {
            flagHasCategories = true;
            storeCategories.Clear();
          }
        Debug.Assert(flagHasCategories);
        storeCategories.Add(to_append);
      }
    public void unsetCategories()
      {
        if (flagHasCategories)
          {
            for (int num8 = 0; num8 < storeCategories.Count; ++num8)
              {
              }
          }
        flagHasCategories = false;
        storeCategories.Clear();
      }
    public void setConfig(RestaurantMenuConfigJSON  new_value)
      {
        if (flagHasConfig)
          {
          }
        flagHasConfig = true;
        storeConfig = new_value;
      }
    public void unsetConfig()
      {
        if (flagHasConfig)
          {
          }
        flagHasConfig = false;
      }
    public void setMetadata(RestaurantMenuMetadataJSON  new_value)
      {
        if (flagHasMetadata)
          {
          }
        flagHasMetadata = true;
        storeMetadata = new_value;
      }
    public void unsetMetadata()
      {
        if (flagHasMetadata)
          {
          }
        flagHasMetadata = false;
      }

    public virtual void extraRestaurantMenuObjectAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantMenuObjectSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantMenuObjectLookup(key);
        if (old_field == null)
          {
            extraRestaurantMenuObjectAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFoodObjects);
        if (flagHasFoodObjects)
          {
            handler.start_pair("FoodObjects");
            handler.start_array();
            for (int num1 = 0; num1 < storeFoodObjects.Count; ++num1)
              {
                if (partial_allowed)
                    storeFoodObjects[num1].write_partial_as_json(handler);
                else
                    storeFoodObjects[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasModifications)
          {
            handler.start_pair("Modifications");
            handler.start_array();
            for (int num2 = 0; num2 < storeModifications.Count; ++num2)
              {
                if (partial_allowed)
                    storeModifications[num2].write_partial_as_json(handler);
                else
                    storeModifications[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasCondiments)
          {
            handler.start_pair("Condiments");
            handler.start_array();
            for (int num3 = 0; num3 < storeCondiments.Count; ++num3)
              {
                if (partial_allowed)
                    storeCondiments[num3].write_partial_as_json(handler);
                else
                    storeCondiments[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasCategories)
          {
            handler.start_pair("Categories");
            handler.start_array();
            for (int num4 = 0; num4 < storeCategories.Count; ++num4)
              {
                if (partial_allowed)
                    storeCategories[num4].write_partial_as_json(handler);
                else
                    storeCategories[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasConfig)
          {
            handler.start_pair("Config");
            if (partial_allowed)
                storeConfig.write_partial_as_json(handler);
            else
                storeConfig.write_as_json(handler);
          }
        if (flagHasMetadata)
          {
            handler.start_pair("Metadata");
            if (partial_allowed)
                storeMetadata.write_partial_as_json(handler);
            else
                storeMetadata.write_as_json(handler);
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
        if (!(hasFoodObjects()))
          {
            return "When parsing the object for %what%, the \"FoodObjects\" field was missing.";
          }
        return null;
      }

    public static RestaurantMenuObjectJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuObjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuObject", ignore_extras);
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
    public static RestaurantMenuObjectJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuObjectJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuObjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuObject", ignore_extras);
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
    public static RestaurantMenuObjectJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuObjectJSON from_text(string text, bool ignore_extras)
      {
        RestaurantMenuObjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuObject", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantMenuObjectJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantMenuObjectJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantMenuObjectJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuObject", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private RestaurantMenuMenuItemJSON.HoldingArrayGenerator fieldGeneratorFoodObjects;
        private RestaurantMenuItemModifierJSON.HoldingArrayGenerator fieldGeneratorModifications;
        private RestaurantMenuCondimentJSON.HoldingArrayGenerator fieldGeneratorCondiments;
        private RestaurantMenuCategoryJSON.HoldingArrayGenerator fieldGeneratorCategories;
        private RestaurantMenuConfigJSON.HoldingGenerator fieldGeneratorConfig;
        private RestaurantMenuMetadataJSON.HoldingGenerator fieldGeneratorMetadata;
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
            RestaurantMenuObjectJSON result = new RestaurantMenuObjectJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantMenuObjectAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantMenuObjectJSON result)
          {
            if (fieldGeneratorFoodObjects.have_value)
              {
                result.initFoodObjects();
                int count = fieldGeneratorFoodObjects.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFoodObjects(fieldGeneratorFoodObjects.value[num]);
                  }
                fieldGeneratorFoodObjects.value.Clear();
                fieldGeneratorFoodObjects.have_value = false;
              }
            else if ((!(result.hasFoodObjects())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FoodObjects\" field was missing.");
              }
            if (fieldGeneratorModifications.have_value)
              {
                result.initModifications();
                int count = fieldGeneratorModifications.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendModifications(fieldGeneratorModifications.value[num]);
                  }
                fieldGeneratorModifications.value.Clear();
                fieldGeneratorModifications.have_value = false;
              }
            if (fieldGeneratorCondiments.have_value)
              {
                result.initCondiments();
                int count = fieldGeneratorCondiments.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCondiments(fieldGeneratorCondiments.value[num]);
                  }
                fieldGeneratorCondiments.value.Clear();
                fieldGeneratorCondiments.have_value = false;
              }
            if (fieldGeneratorCategories.have_value)
              {
                result.initCategories();
                int count = fieldGeneratorCategories.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCategories(fieldGeneratorCategories.value[num]);
                  }
                fieldGeneratorCategories.value.Clear();
                fieldGeneratorCategories.have_value = false;
              }
            if (fieldGeneratorConfig.have_value)
              {
                result.setConfig(fieldGeneratorConfig.value);
                fieldGeneratorConfig.have_value = false;
              }
            if (fieldGeneratorMetadata.have_value)
              {
                result.setMetadata(fieldGeneratorMetadata.value);
                fieldGeneratorMetadata.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantMenuObjectJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tegories", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorCategories;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "n", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'd':
                                        if ((String.Compare(field_name, 4, "iments", 0, 6, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorCondiments;
                                        break;
                                    case 'f':
                                        if ((String.Compare(field_name, 4, "ig", 0, 2, false) == 0) && (field_name.Length == 6))
                                            return fieldGeneratorConfig;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "oodObjects", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorFoodObjects;
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "tadata", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorMetadata;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "difications", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorModifications;
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
            fieldGeneratorFoodObjects = new RestaurantMenuMenuItemJSON.HoldingArrayGenerator("field \"FoodObjects\" of the RestaurantMenuObject class", ignore_extras);
            fieldGeneratorModifications = new RestaurantMenuItemModifierJSON.HoldingArrayGenerator("field \"Modifications\" of the RestaurantMenuObject class", ignore_extras);
            fieldGeneratorCondiments = new RestaurantMenuCondimentJSON.HoldingArrayGenerator("field \"Condiments\" of the RestaurantMenuObject class", ignore_extras);
            fieldGeneratorCategories = new RestaurantMenuCategoryJSON.HoldingArrayGenerator("field \"Categories\" of the RestaurantMenuObject class", ignore_extras);
            fieldGeneratorConfig = new RestaurantMenuConfigJSON.HoldingGenerator("field \"Config\" of the RestaurantMenuObject class", ignore_extras);
            fieldGeneratorMetadata = new RestaurantMenuMetadataJSON.HoldingGenerator("field \"Metadata\" of the RestaurantMenuObject class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantMenuObject class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFoodObjects = new RestaurantMenuMenuItemJSON.HoldingArrayGenerator("field \"FoodObjects\" of the RestaurantMenuObject class", false);
            fieldGeneratorModifications = new RestaurantMenuItemModifierJSON.HoldingArrayGenerator("field \"Modifications\" of the RestaurantMenuObject class", false);
            fieldGeneratorCondiments = new RestaurantMenuCondimentJSON.HoldingArrayGenerator("field \"Condiments\" of the RestaurantMenuObject class", false);
            fieldGeneratorCategories = new RestaurantMenuCategoryJSON.HoldingArrayGenerator("field \"Categories\" of the RestaurantMenuObject class", false);
            fieldGeneratorConfig = new RestaurantMenuConfigJSON.HoldingGenerator("field \"Config\" of the RestaurantMenuObject class", false);
            fieldGeneratorMetadata = new RestaurantMenuMetadataJSON.HoldingGenerator("field \"Metadata\" of the RestaurantMenuObject class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantMenuObject class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFoodObjects.reset();
            fieldGeneratorModifications.reset();
            fieldGeneratorCondiments.reset();
            fieldGeneratorCategories.reset();
            fieldGeneratorConfig.reset();
            fieldGeneratorMetadata.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFoodObjects.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorModifications.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCondiments.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCategories.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorConfig.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMetadata.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFoodObjects.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorModifications.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCondiments.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCategories.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorConfig.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMetadata.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantMenuObjectJSON  result)
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
        public RestaurantMenuObjectJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantMenuObjectJSON  result)
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
    protected virtual void handle_result(List<RestaurantMenuObjectJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantMenuObjectJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantMenuObjectJSON>();
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
    public List<RestaurantMenuObjectJSON> value;
  };
  };
