/* file "RestaurantMenuCategoryJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RestaurantMenuCategoryJSON : JSONBase
  {
    private bool flagHasProductsInCategory;
    private List< BigInteger > storeProductsInCategory;
    private bool flagHasCategoriesInCategory;
    private List< BigInteger > storeCategoriesInCategory;
    private bool flagHasSynonyms;
    private List< string > storeSynonyms;
    private bool flagHasTerrierExpression;
    private string storeTerrierExpression;
    private bool flagHasFlexibleExpressionData;
    private List< RestaurantMenuFlexibleExpressionDataJSON  > storeFlexibleExpressionData;
    private bool flagHasCategoryId;
    private BigInteger storeCategoryId;
    private bool flagHasCategoryName;
    private string storeCategoryName;
    private bool flagHasCategoryNameSpoken;
    private string storeCategoryNameSpoken;
    private bool flagHasCategoryComponentsType;
    private string storeCategoryComponentsType;
    private bool flagHasCategoryComponentsTypeSpoken;
    private string storeCategoryComponentsTypeSpoken;
    private bool flagHasCategoryRestaurantId;
    private BigInteger storeCategoryRestaurantId;
    private bool flagHasCategoryComponents;
    private List< RestaurantMenuCategoryComponentsJSON  > storeCategoryComponents;
    private bool flagHasCategoryComponentsPrompt;
    private string storeCategoryComponentsPrompt;
    private bool flagHasCategoryComponentsPromptSpoken;
    private string storeCategoryComponentsPromptSpoken;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONProductsInCategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ProductsInCategory of RestaurantMenuCategoryJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_ProductsInCategory1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field ProductsInCategory of RestaurantMenuCategoryJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field ProductsInCategory of RestaurantMenuCategoryJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_ProductsInCategory1.Add(extracted_integer);
          }
        initProductsInCategory();
        for (int num1 = 0; num1 < vector_ProductsInCategory1.Count; ++num1)
            appendProductsInCategory(vector_ProductsInCategory1[num1]);
        for (int num1 = 0; num1 < vector_ProductsInCategory1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCategoriesInCategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CategoriesInCategory of RestaurantMenuCategoryJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_CategoriesInCategory1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field CategoriesInCategory of RestaurantMenuCategoryJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field CategoriesInCategory of RestaurantMenuCategoryJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_CategoriesInCategory1.Add(extracted_integer);
          }
        initCategoriesInCategory();
        for (int num2 = 0; num2 < vector_CategoriesInCategory1.Count; ++num2)
            appendCategoriesInCategory(vector_CategoriesInCategory1[num2]);
        for (int num1 = 0; num1 < vector_CategoriesInCategory1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSynonyms(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Synonyms of RestaurantMenuCategoryJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Synonyms of RestaurantMenuCategoryJSON has too few elements.");
        List< string > vector_Synonyms1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Synonyms of RestaurantMenuCategoryJSON is not a string.");
            vector_Synonyms1.Add(json_string.getData());
          }
        Debug.Assert(vector_Synonyms1.Count >= 1);
        initSynonyms();
        for (int num3 = 0; num3 < vector_Synonyms1.Count; ++num3)
            appendSynonyms(vector_Synonyms1[num3]);
        for (int num1 = 0; num1 < vector_Synonyms1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTerrierExpression(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TerrierExpression of RestaurantMenuCategoryJSON is not a string.");
        setTerrierExpression(json_string.getData());
      }


    private void  fromJSONFlexibleExpressionData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlexibleExpressionData of RestaurantMenuCategoryJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field FlexibleExpressionData of RestaurantMenuCategoryJSON has too few elements.");
        List< RestaurantMenuFlexibleExpressionDataJSON  > vector_FlexibleExpressionData1 = new List< RestaurantMenuFlexibleExpressionDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantMenuFlexibleExpressionDataJSON convert_classy = RestaurantMenuFlexibleExpressionDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlexibleExpressionData1.Add(convert_classy);
          }
        Debug.Assert(vector_FlexibleExpressionData1.Count >= 1);
        initFlexibleExpressionData();
        for (int num4 = 0; num4 < vector_FlexibleExpressionData1.Count; ++num4)
            appendFlexibleExpressionData(vector_FlexibleExpressionData1[num4]);
        for (int num1 = 0; num1 < vector_FlexibleExpressionData1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCategoryId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CategoryId of RestaurantMenuCategoryJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CategoryId of RestaurantMenuCategoryJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCategoryId(extracted_integer);
      }


    private void  fromJSONCategoryName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CategoryName of RestaurantMenuCategoryJSON is not a string.");
        setCategoryName(json_string.getData());
      }


    private void  fromJSONCategoryNameSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CategoryNameSpoken of RestaurantMenuCategoryJSON is not a string.");
        setCategoryNameSpoken(json_string.getData());
      }


    private void  fromJSONCategoryComponentsType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CategoryComponentsType of RestaurantMenuCategoryJSON is not a string.");
        setCategoryComponentsType(json_string.getData());
      }


    private void  fromJSONCategoryComponentsTypeSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CategoryComponentsTypeSpoken of RestaurantMenuCategoryJSON is not a string.");
        setCategoryComponentsTypeSpoken(json_string.getData());
      }


    private void  fromJSONCategoryRestaurantId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CategoryRestaurantId of RestaurantMenuCategoryJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CategoryRestaurantId of RestaurantMenuCategoryJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCategoryRestaurantId(extracted_integer);
      }


    private void  fromJSONCategoryComponents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CategoryComponents of RestaurantMenuCategoryJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field CategoryComponents of RestaurantMenuCategoryJSON has too few elements.");
        List< RestaurantMenuCategoryComponentsJSON  > vector_CategoryComponents1 = new List< RestaurantMenuCategoryComponentsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantMenuCategoryComponentsJSON convert_classy = RestaurantMenuCategoryComponentsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_CategoryComponents1.Add(convert_classy);
          }
        Debug.Assert(vector_CategoryComponents1.Count >= 1);
        initCategoryComponents();
        for (int num5 = 0; num5 < vector_CategoryComponents1.Count; ++num5)
            appendCategoryComponents(vector_CategoryComponents1[num5]);
        for (int num1 = 0; num1 < vector_CategoryComponents1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCategoryComponentsPrompt(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CategoryComponentsPrompt of RestaurantMenuCategoryJSON is not a string.");
        setCategoryComponentsPrompt(json_string.getData());
      }


    private void  fromJSONCategoryComponentsPromptSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CategoryComponentsPromptSpoken of RestaurantMenuCategoryJSON is not a string.");
        setCategoryComponentsPromptSpoken(json_string.getData());
      }


    public RestaurantMenuCategoryJSON()
      {
        flagHasProductsInCategory = false;
        flagHasCategoriesInCategory = false;
        flagHasSynonyms = false;
        flagHasTerrierExpression = false;
        flagHasFlexibleExpressionData = false;
        flagHasCategoryId = false;
        flagHasCategoryName = false;
        flagHasCategoryNameSpoken = false;
        flagHasCategoryComponentsType = false;
        flagHasCategoryComponentsTypeSpoken = false;
        flagHasCategoryRestaurantId = false;
        flagHasCategoryComponents = false;
        flagHasCategoryComponentsPrompt = false;
        flagHasCategoryComponentsPromptSpoken = false;
        storeProductsInCategory = new List< BigInteger >();
        storeCategoriesInCategory = new List< BigInteger >();
        storeSynonyms = new List< string >();
        storeFlexibleExpressionData = new List< RestaurantMenuFlexibleExpressionDataJSON  >();
        storeCategoryComponents = new List< RestaurantMenuCategoryComponentsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasProductsInCategory()
      {
        return flagHasProductsInCategory;
      }

    public int  countOfProductsInCategory()
      {
        Debug.Assert(flagHasProductsInCategory);
        return storeProductsInCategory.Count;
      }

    public BigInteger  elementOfProductsInCategory(int element_num)
      {
        Debug.Assert(flagHasProductsInCategory);
        return storeProductsInCategory[element_num];
      }

    public List< BigInteger >  getProductsInCategory()
      {
        Debug.Assert(flagHasProductsInCategory);
        return storeProductsInCategory;
      }

    public bool  hasCategoriesInCategory()
      {
        return flagHasCategoriesInCategory;
      }

    public int  countOfCategoriesInCategory()
      {
        Debug.Assert(flagHasCategoriesInCategory);
        return storeCategoriesInCategory.Count;
      }

    public BigInteger  elementOfCategoriesInCategory(int element_num)
      {
        Debug.Assert(flagHasCategoriesInCategory);
        return storeCategoriesInCategory[element_num];
      }

    public List< BigInteger >  getCategoriesInCategory()
      {
        Debug.Assert(flagHasCategoriesInCategory);
        return storeCategoriesInCategory;
      }

    public bool  hasSynonyms()
      {
        return flagHasSynonyms;
      }

    public int  countOfSynonyms()
      {
        Debug.Assert(flagHasSynonyms);
        return storeSynonyms.Count;
      }

    public string  elementOfSynonyms(int element_num)
      {
        Debug.Assert(flagHasSynonyms);
        return storeSynonyms[element_num];
      }

    public List< string >  getSynonyms()
      {
        Debug.Assert(flagHasSynonyms);
        return storeSynonyms;
      }

    public bool  hasTerrierExpression()
      {
        return flagHasTerrierExpression;
      }

    public string  getTerrierExpression()
      {
        Debug.Assert(flagHasTerrierExpression);
        return storeTerrierExpression;
      }

    public bool  hasFlexibleExpressionData()
      {
        return flagHasFlexibleExpressionData;
      }

    public int  countOfFlexibleExpressionData()
      {
        Debug.Assert(flagHasFlexibleExpressionData);
        return storeFlexibleExpressionData.Count;
      }

    public RestaurantMenuFlexibleExpressionDataJSON   elementOfFlexibleExpressionData(int element_num)
      {
        Debug.Assert(flagHasFlexibleExpressionData);
        return storeFlexibleExpressionData[element_num];
      }

    public List< RestaurantMenuFlexibleExpressionDataJSON  >  getFlexibleExpressionData()
      {
        Debug.Assert(flagHasFlexibleExpressionData);
        return storeFlexibleExpressionData;
      }

    public bool  hasCategoryId()
      {
        return flagHasCategoryId;
      }

    public BigInteger  getCategoryId()
      {
        Debug.Assert(flagHasCategoryId);
        return storeCategoryId;
      }

    public bool  hasCategoryName()
      {
        return flagHasCategoryName;
      }

    public string  getCategoryName()
      {
        Debug.Assert(flagHasCategoryName);
        return storeCategoryName;
      }

    public bool  hasCategoryNameSpoken()
      {
        return flagHasCategoryNameSpoken;
      }

    public string  getCategoryNameSpoken()
      {
        Debug.Assert(flagHasCategoryNameSpoken);
        return storeCategoryNameSpoken;
      }

    public bool  hasCategoryComponentsType()
      {
        return flagHasCategoryComponentsType;
      }

    public string  getCategoryComponentsType()
      {
        Debug.Assert(flagHasCategoryComponentsType);
        return storeCategoryComponentsType;
      }

    public bool  hasCategoryComponentsTypeSpoken()
      {
        return flagHasCategoryComponentsTypeSpoken;
      }

    public string  getCategoryComponentsTypeSpoken()
      {
        Debug.Assert(flagHasCategoryComponentsTypeSpoken);
        return storeCategoryComponentsTypeSpoken;
      }

    public bool  hasCategoryRestaurantId()
      {
        return flagHasCategoryRestaurantId;
      }

    public BigInteger  getCategoryRestaurantId()
      {
        Debug.Assert(flagHasCategoryRestaurantId);
        return storeCategoryRestaurantId;
      }

    public bool  hasCategoryComponents()
      {
        return flagHasCategoryComponents;
      }

    public int  countOfCategoryComponents()
      {
        Debug.Assert(flagHasCategoryComponents);
        return storeCategoryComponents.Count;
      }

    public RestaurantMenuCategoryComponentsJSON   elementOfCategoryComponents(int element_num)
      {
        Debug.Assert(flagHasCategoryComponents);
        return storeCategoryComponents[element_num];
      }

    public List< RestaurantMenuCategoryComponentsJSON  >  getCategoryComponents()
      {
        Debug.Assert(flagHasCategoryComponents);
        return storeCategoryComponents;
      }

    public bool  hasCategoryComponentsPrompt()
      {
        return flagHasCategoryComponentsPrompt;
      }

    public string  getCategoryComponentsPrompt()
      {
        Debug.Assert(flagHasCategoryComponentsPrompt);
        return storeCategoryComponentsPrompt;
      }

    public bool  hasCategoryComponentsPromptSpoken()
      {
        return flagHasCategoryComponentsPromptSpoken;
      }

    public string  getCategoryComponentsPromptSpoken()
      {
        Debug.Assert(flagHasCategoryComponentsPromptSpoken);
        return storeCategoryComponentsPromptSpoken;
      }


    public virtual int extraRestaurantMenuCategoryComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantMenuCategoryComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantMenuCategoryComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantMenuCategoryLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initProductsInCategory()
      {
        flagHasProductsInCategory = true;
        storeProductsInCategory.Clear();
      }
    public void appendProductsInCategory(BigInteger to_append)
      {
        if (!flagHasProductsInCategory)
          {
            flagHasProductsInCategory = true;
            storeProductsInCategory.Clear();
          }
        Debug.Assert(flagHasProductsInCategory);
        storeProductsInCategory.Add(to_append);
      }
    public void unsetProductsInCategory()
      {
        flagHasProductsInCategory = false;
        storeProductsInCategory.Clear();
      }
    public void initCategoriesInCategory()
      {
        flagHasCategoriesInCategory = true;
        storeCategoriesInCategory.Clear();
      }
    public void appendCategoriesInCategory(BigInteger to_append)
      {
        if (!flagHasCategoriesInCategory)
          {
            flagHasCategoriesInCategory = true;
            storeCategoriesInCategory.Clear();
          }
        Debug.Assert(flagHasCategoriesInCategory);
        storeCategoriesInCategory.Add(to_append);
      }
    public void unsetCategoriesInCategory()
      {
        flagHasCategoriesInCategory = false;
        storeCategoriesInCategory.Clear();
      }
    public void initSynonyms()
      {
        flagHasSynonyms = true;
        storeSynonyms.Clear();
      }
    public void appendSynonyms(string to_append)
      {
        if (!flagHasSynonyms)
          {
            flagHasSynonyms = true;
            storeSynonyms.Clear();
          }
        Debug.Assert(flagHasSynonyms);
        storeSynonyms.Add(to_append);
      }
    public void unsetSynonyms()
      {
        flagHasSynonyms = false;
        storeSynonyms.Clear();
      }
    public void setTerrierExpression(string new_value)
      {
        flagHasTerrierExpression = true;
        storeTerrierExpression = new_value;
      }
    public void unsetTerrierExpression()
      {
        flagHasTerrierExpression = false;
      }
    public void initFlexibleExpressionData()
      {
        if (flagHasFlexibleExpressionData)
          {
            for (int num1 = 0; num1 < storeFlexibleExpressionData.Count; ++num1)
              {
              }
          }
        flagHasFlexibleExpressionData = true;
        storeFlexibleExpressionData.Clear();
      }
    public void appendFlexibleExpressionData(RestaurantMenuFlexibleExpressionDataJSON  to_append)
      {
        if (!flagHasFlexibleExpressionData)
          {
            flagHasFlexibleExpressionData = true;
            storeFlexibleExpressionData.Clear();
          }
        Debug.Assert(flagHasFlexibleExpressionData);
        storeFlexibleExpressionData.Add(to_append);
      }
    public void unsetFlexibleExpressionData()
      {
        if (flagHasFlexibleExpressionData)
          {
            for (int num2 = 0; num2 < storeFlexibleExpressionData.Count; ++num2)
              {
              }
          }
        flagHasFlexibleExpressionData = false;
        storeFlexibleExpressionData.Clear();
      }
    public void setCategoryId(BigInteger new_value)
      {
        flagHasCategoryId = true;
        storeCategoryId = new_value;
      }
    public void unsetCategoryId()
      {
        flagHasCategoryId = false;
      }
    public void setCategoryName(string new_value)
      {
        flagHasCategoryName = true;
        storeCategoryName = new_value;
      }
    public void unsetCategoryName()
      {
        flagHasCategoryName = false;
      }
    public void setCategoryNameSpoken(string new_value)
      {
        flagHasCategoryNameSpoken = true;
        storeCategoryNameSpoken = new_value;
      }
    public void unsetCategoryNameSpoken()
      {
        flagHasCategoryNameSpoken = false;
      }
    public void setCategoryComponentsType(string new_value)
      {
        flagHasCategoryComponentsType = true;
        storeCategoryComponentsType = new_value;
      }
    public void unsetCategoryComponentsType()
      {
        flagHasCategoryComponentsType = false;
      }
    public void setCategoryComponentsTypeSpoken(string new_value)
      {
        flagHasCategoryComponentsTypeSpoken = true;
        storeCategoryComponentsTypeSpoken = new_value;
      }
    public void unsetCategoryComponentsTypeSpoken()
      {
        flagHasCategoryComponentsTypeSpoken = false;
      }
    public void setCategoryRestaurantId(BigInteger new_value)
      {
        flagHasCategoryRestaurantId = true;
        storeCategoryRestaurantId = new_value;
      }
    public void unsetCategoryRestaurantId()
      {
        flagHasCategoryRestaurantId = false;
      }
    public void initCategoryComponents()
      {
        if (flagHasCategoryComponents)
          {
            for (int num3 = 0; num3 < storeCategoryComponents.Count; ++num3)
              {
              }
          }
        flagHasCategoryComponents = true;
        storeCategoryComponents.Clear();
      }
    public void appendCategoryComponents(RestaurantMenuCategoryComponentsJSON  to_append)
      {
        if (!flagHasCategoryComponents)
          {
            flagHasCategoryComponents = true;
            storeCategoryComponents.Clear();
          }
        Debug.Assert(flagHasCategoryComponents);
        storeCategoryComponents.Add(to_append);
      }
    public void unsetCategoryComponents()
      {
        if (flagHasCategoryComponents)
          {
            for (int num4 = 0; num4 < storeCategoryComponents.Count; ++num4)
              {
              }
          }
        flagHasCategoryComponents = false;
        storeCategoryComponents.Clear();
      }
    public void setCategoryComponentsPrompt(string new_value)
      {
        flagHasCategoryComponentsPrompt = true;
        storeCategoryComponentsPrompt = new_value;
      }
    public void unsetCategoryComponentsPrompt()
      {
        flagHasCategoryComponentsPrompt = false;
      }
    public void setCategoryComponentsPromptSpoken(string new_value)
      {
        flagHasCategoryComponentsPromptSpoken = true;
        storeCategoryComponentsPromptSpoken = new_value;
      }
    public void unsetCategoryComponentsPromptSpoken()
      {
        flagHasCategoryComponentsPromptSpoken = false;
      }

    public virtual void extraRestaurantMenuCategoryAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantMenuCategorySetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantMenuCategoryLookup(key);
        if (old_field == null)
          {
            extraRestaurantMenuCategoryAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasProductsInCategory);
        if (flagHasProductsInCategory)
          {
            handler.start_pair("ProductsInCategory");
            handler.start_array();
            for (int num1 = 0; num1 < storeProductsInCategory.Count; ++num1)
              {
                handler.number_value(storeProductsInCategory[num1]);
              }
            handler.finish_array();
          }
        if (flagHasCategoriesInCategory)
          {
            handler.start_pair("CategoriesInCategory");
            handler.start_array();
            for (int num2 = 0; num2 < storeCategoriesInCategory.Count; ++num2)
              {
                handler.number_value(storeCategoriesInCategory[num2]);
              }
            handler.finish_array();
          }
        if (flagHasSynonyms)
          {
            handler.start_pair("Synonyms");
            Debug.Assert(storeSynonyms.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeSynonyms.Count; ++num3)
              {
                handler.string_value(storeSynonyms[num3]);
              }
            handler.finish_array();
          }
        if (flagHasTerrierExpression)
          {
            handler.start_pair("TerrierExpression");
            handler.string_value(storeTerrierExpression);
          }
        if (flagHasFlexibleExpressionData)
          {
            handler.start_pair("FlexibleExpressionData");
            Debug.Assert(storeFlexibleExpressionData.Count >= 1);
            handler.start_array();
            for (int num4 = 0; num4 < storeFlexibleExpressionData.Count; ++num4)
              {
                if (partial_allowed)
                    storeFlexibleExpressionData[num4].write_partial_as_json(handler);
                else
                    storeFlexibleExpressionData[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasCategoryId);
        if (flagHasCategoryId)
          {
            handler.start_pair("CategoryId");
            handler.number_value(storeCategoryId);
          }
        Debug.Assert(partial_allowed || flagHasCategoryName);
        if (flagHasCategoryName)
          {
            handler.start_pair("CategoryName");
            handler.string_value(storeCategoryName);
          }
        if (flagHasCategoryNameSpoken)
          {
            handler.start_pair("CategoryNameSpoken");
            handler.string_value(storeCategoryNameSpoken);
          }
        if (flagHasCategoryComponentsType)
          {
            handler.start_pair("CategoryComponentsType");
            handler.string_value(storeCategoryComponentsType);
          }
        if (flagHasCategoryComponentsTypeSpoken)
          {
            handler.start_pair("CategoryComponentsTypeSpoken");
            handler.string_value(storeCategoryComponentsTypeSpoken);
          }
        if (flagHasCategoryRestaurantId)
          {
            handler.start_pair("CategoryRestaurantId");
            handler.number_value(storeCategoryRestaurantId);
          }
        if (flagHasCategoryComponents)
          {
            handler.start_pair("CategoryComponents");
            Debug.Assert(storeCategoryComponents.Count >= 1);
            handler.start_array();
            for (int num5 = 0; num5 < storeCategoryComponents.Count; ++num5)
              {
                if (partial_allowed)
                    storeCategoryComponents[num5].write_partial_as_json(handler);
                else
                    storeCategoryComponents[num5].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasCategoryComponentsPrompt)
          {
            handler.start_pair("CategoryComponentsPrompt");
            handler.string_value(storeCategoryComponentsPrompt);
          }
        if (flagHasCategoryComponentsPromptSpoken)
          {
            handler.start_pair("CategoryComponentsPromptSpoken");
            handler.string_value(storeCategoryComponentsPromptSpoken);
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
        if (!(hasProductsInCategory()))
          {
            return "When parsing the object for %what%, the \"ProductsInCategory\" field was missing.";
          }
        if (!(hasCategoryId()))
          {
            return "When parsing the object for %what%, the \"CategoryId\" field was missing.";
          }
        if (!(hasCategoryName()))
          {
            return "When parsing the object for %what%, the \"CategoryName\" field was missing.";
          }
        return null;
      }

    public static RestaurantMenuCategoryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuCategoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuCategory", ignore_extras);
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
    public static RestaurantMenuCategoryJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuCategoryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuCategoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuCategory", ignore_extras);
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
    public static RestaurantMenuCategoryJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuCategoryJSON from_text(string text, bool ignore_extras)
      {
        RestaurantMenuCategoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuCategory", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantMenuCategoryJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantMenuCategoryJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantMenuCategoryJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuCategory", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorProductsInCategory : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorProductsInCategory(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorProductsInCategory : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorProductsInCategory(String what) : base(what)
              {
              }
          };
        private FieldHoldingArrayGeneratorProductsInCategory fieldGeneratorProductsInCategory;
    private class FieldHoldingGeneratorCategoriesInCategory : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorCategoriesInCategory(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCategoriesInCategory : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCategoriesInCategory(String what) : base(what)
              {
              }
          };
        private FieldHoldingArrayGeneratorCategoriesInCategory fieldGeneratorCategoriesInCategory;
        private JSONHoldingStringArrayGenerator fieldGeneratorSynonyms;
        private JSONHoldingStringGenerator fieldGeneratorTerrierExpression;
        private RestaurantMenuFlexibleExpressionDataJSON.HoldingArrayGenerator fieldGeneratorFlexibleExpressionData;
    private class FieldHoldingGeneratorCategoryId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorCategoryId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCategoryId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCategoryId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorCategoryId fieldGeneratorCategoryId;
        private JSONHoldingStringGenerator fieldGeneratorCategoryName;
        private JSONHoldingStringGenerator fieldGeneratorCategoryNameSpoken;
        private JSONHoldingStringGenerator fieldGeneratorCategoryComponentsType;
        private JSONHoldingStringGenerator fieldGeneratorCategoryComponentsTypeSpoken;
    private class FieldHoldingGeneratorCategoryRestaurantId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorCategoryRestaurantId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCategoryRestaurantId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCategoryRestaurantId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorCategoryRestaurantId fieldGeneratorCategoryRestaurantId;
        private RestaurantMenuCategoryComponentsJSON.HoldingArrayGenerator fieldGeneratorCategoryComponents;
        private JSONHoldingStringGenerator fieldGeneratorCategoryComponentsPrompt;
        private JSONHoldingStringGenerator fieldGeneratorCategoryComponentsPromptSpoken;
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
            RestaurantMenuCategoryJSON result = new RestaurantMenuCategoryJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantMenuCategoryAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantMenuCategoryJSON result)
          {
            if (fieldGeneratorProductsInCategory.have_value)
              {
                result.initProductsInCategory();
                int count = fieldGeneratorProductsInCategory.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendProductsInCategory(fieldGeneratorProductsInCategory.value[num]);
                  }
                fieldGeneratorProductsInCategory.value.Clear();
                fieldGeneratorProductsInCategory.have_value = false;
              }
            else if ((!(result.hasProductsInCategory())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ProductsInCategory\" field was missing.");
              }
            if (fieldGeneratorCategoriesInCategory.have_value)
              {
                result.initCategoriesInCategory();
                int count = fieldGeneratorCategoriesInCategory.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCategoriesInCategory(fieldGeneratorCategoriesInCategory.value[num]);
                  }
                fieldGeneratorCategoriesInCategory.value.Clear();
                fieldGeneratorCategoriesInCategory.have_value = false;
              }
            if (fieldGeneratorSynonyms.have_value)
              {
                result.initSynonyms();
                int count = fieldGeneratorSynonyms.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSynonyms(fieldGeneratorSynonyms.value[num]);
                  }
                fieldGeneratorSynonyms.value.Clear();
                fieldGeneratorSynonyms.have_value = false;
              }
            if (fieldGeneratorTerrierExpression.have_value)
              {
                result.setTerrierExpression(fieldGeneratorTerrierExpression.value);
                fieldGeneratorTerrierExpression.have_value = false;
              }
            if (fieldGeneratorFlexibleExpressionData.have_value)
              {
                result.initFlexibleExpressionData();
                int count = fieldGeneratorFlexibleExpressionData.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendFlexibleExpressionData(fieldGeneratorFlexibleExpressionData.value[num]);
                  }
                fieldGeneratorFlexibleExpressionData.value.Clear();
                fieldGeneratorFlexibleExpressionData.have_value = false;
              }
            if (fieldGeneratorCategoryId.have_value)
              {
                result.setCategoryId(fieldGeneratorCategoryId.value);
                fieldGeneratorCategoryId.have_value = false;
              }
            else if ((!(result.hasCategoryId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CategoryId\" field was missing.");
              }
            if (fieldGeneratorCategoryName.have_value)
              {
                result.setCategoryName(fieldGeneratorCategoryName.value);
                fieldGeneratorCategoryName.have_value = false;
              }
            else if ((!(result.hasCategoryName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"CategoryName\" field was missing.");
              }
            if (fieldGeneratorCategoryNameSpoken.have_value)
              {
                result.setCategoryNameSpoken(fieldGeneratorCategoryNameSpoken.value);
                fieldGeneratorCategoryNameSpoken.have_value = false;
              }
            if (fieldGeneratorCategoryComponentsType.have_value)
              {
                result.setCategoryComponentsType(fieldGeneratorCategoryComponentsType.value);
                fieldGeneratorCategoryComponentsType.have_value = false;
              }
            if (fieldGeneratorCategoryComponentsTypeSpoken.have_value)
              {
                result.setCategoryComponentsTypeSpoken(fieldGeneratorCategoryComponentsTypeSpoken.value);
                fieldGeneratorCategoryComponentsTypeSpoken.have_value = false;
              }
            if (fieldGeneratorCategoryRestaurantId.have_value)
              {
                result.setCategoryRestaurantId(fieldGeneratorCategoryRestaurantId.value);
                fieldGeneratorCategoryRestaurantId.have_value = false;
              }
            if (fieldGeneratorCategoryComponents.have_value)
              {
                result.initCategoryComponents();
                int count = fieldGeneratorCategoryComponents.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCategoryComponents(fieldGeneratorCategoryComponents.value[num]);
                  }
                fieldGeneratorCategoryComponents.value.Clear();
                fieldGeneratorCategoryComponents.have_value = false;
              }
            if (fieldGeneratorCategoryComponentsPrompt.have_value)
              {
                result.setCategoryComponentsPrompt(fieldGeneratorCategoryComponentsPrompt.value);
                fieldGeneratorCategoryComponentsPrompt.have_value = false;
              }
            if (fieldGeneratorCategoryComponentsPromptSpoken.have_value)
              {
                result.setCategoryComponentsPromptSpoken(fieldGeneratorCategoryComponentsPromptSpoken.value);
                fieldGeneratorCategoryComponentsPromptSpoken.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantMenuCategoryJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "ategor", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'i':
                                if ((String.Compare(field_name, 8, "esInCategory", 0, 12, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorCategoriesInCategory;
                                break;
                            case 'y':
                                switch (field_name[8])
                                  {
                                    case 'C':
                                        if (String.Compare(field_name, 9, "omponents", 0, 9, false) == 0)
                                          {
                                            if (field_name.Length == 18)
                                              {
                                                return fieldGeneratorCategoryComponents;
                                              }
                                            switch (field_name[18])
                                              {
                                                case 'P':
                                                    if (String.Compare(field_name, 19, "rompt", 0, 5, false) == 0)
                                                      {
                                                        if (field_name.Length == 24)
                                                          {
                                                            return fieldGeneratorCategoryComponentsPrompt;
                                                          }
                                                        switch (field_name[24])
                                                          {
                                                            case 'S':
                                                                if ((String.Compare(field_name, 25, "poken", 0, 5, false) == 0) && (field_name.Length == 30))
                                                                    return fieldGeneratorCategoryComponentsPromptSpoken;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                case 'T':
                                                    if (String.Compare(field_name, 19, "ype", 0, 3, false) == 0)
                                                      {
                                                        if (field_name.Length == 22)
                                                          {
                                                            return fieldGeneratorCategoryComponentsType;
                                                          }
                                                        switch (field_name[22])
                                                          {
                                                            case 'S':
                                                                if ((String.Compare(field_name, 23, "poken", 0, 5, false) == 0) && (field_name.Length == 28))
                                                                    return fieldGeneratorCategoryComponentsTypeSpoken;
                                                                break;
                                                            default:
                                                                break;
                                                          }
                                                      }
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 9, "d", 0, 1, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorCategoryId;
                                        break;
                                    case 'N':
                                        if (String.Compare(field_name, 9, "ame", 0, 3, false) == 0)
                                          {
                                            if (field_name.Length == 12)
                                              {
                                                return fieldGeneratorCategoryName;
                                              }
                                            switch (field_name[12])
                                              {
                                                case 'S':
                                                    if ((String.Compare(field_name, 13, "poken", 0, 5, false) == 0) && (field_name.Length == 18))
                                                        return fieldGeneratorCategoryNameSpoken;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'R':
                                        if ((String.Compare(field_name, 9, "estaurantId", 0, 11, false) == 0) && (field_name.Length == 20))
                                            return fieldGeneratorCategoryRestaurantId;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "lexibleExpressionData", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorFlexibleExpressionData;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "roductsInCategory", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorProductsInCategory;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ynonyms", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorSynonyms;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "errierExpression", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorTerrierExpression;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorProductsInCategory = new FieldHoldingArrayGeneratorProductsInCategory("field \"ProductsInCategory\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoriesInCategory = new FieldHoldingArrayGeneratorCategoriesInCategory("field \"CategoriesInCategory\" of the RestaurantMenuCategory class");
            fieldGeneratorSynonyms = new JSONHoldingStringArrayGenerator("field \"Synonyms\" of the RestaurantMenuCategory class");
            fieldGeneratorTerrierExpression = new JSONHoldingStringGenerator("field \"TerrierExpression\" of the RestaurantMenuCategory class");
            fieldGeneratorFlexibleExpressionData = new RestaurantMenuFlexibleExpressionDataJSON.HoldingArrayGenerator("field \"FlexibleExpressionData\" of the RestaurantMenuCategory class", ignore_extras);
            fieldGeneratorCategoryId = new FieldHoldingGeneratorCategoryId("field \"CategoryId\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryName = new JSONHoldingStringGenerator("field \"CategoryName\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryNameSpoken = new JSONHoldingStringGenerator("field \"CategoryNameSpoken\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryComponentsType = new JSONHoldingStringGenerator("field \"CategoryComponentsType\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryComponentsTypeSpoken = new JSONHoldingStringGenerator("field \"CategoryComponentsTypeSpoken\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryRestaurantId = new FieldHoldingGeneratorCategoryRestaurantId("field \"CategoryRestaurantId\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryComponents = new RestaurantMenuCategoryComponentsJSON.HoldingArrayGenerator("field \"CategoryComponents\" of the RestaurantMenuCategory class", ignore_extras);
            fieldGeneratorCategoryComponentsPrompt = new JSONHoldingStringGenerator("field \"CategoryComponentsPrompt\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryComponentsPromptSpoken = new JSONHoldingStringGenerator("field \"CategoryComponentsPromptSpoken\" of the RestaurantMenuCategory class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantMenuCategory class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorProductsInCategory = new FieldHoldingArrayGeneratorProductsInCategory("field \"ProductsInCategory\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoriesInCategory = new FieldHoldingArrayGeneratorCategoriesInCategory("field \"CategoriesInCategory\" of the RestaurantMenuCategory class");
            fieldGeneratorSynonyms = new JSONHoldingStringArrayGenerator("field \"Synonyms\" of the RestaurantMenuCategory class");
            fieldGeneratorTerrierExpression = new JSONHoldingStringGenerator("field \"TerrierExpression\" of the RestaurantMenuCategory class");
            fieldGeneratorFlexibleExpressionData = new RestaurantMenuFlexibleExpressionDataJSON.HoldingArrayGenerator("field \"FlexibleExpressionData\" of the RestaurantMenuCategory class", false);
            fieldGeneratorCategoryId = new FieldHoldingGeneratorCategoryId("field \"CategoryId\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryName = new JSONHoldingStringGenerator("field \"CategoryName\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryNameSpoken = new JSONHoldingStringGenerator("field \"CategoryNameSpoken\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryComponentsType = new JSONHoldingStringGenerator("field \"CategoryComponentsType\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryComponentsTypeSpoken = new JSONHoldingStringGenerator("field \"CategoryComponentsTypeSpoken\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryRestaurantId = new FieldHoldingGeneratorCategoryRestaurantId("field \"CategoryRestaurantId\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryComponents = new RestaurantMenuCategoryComponentsJSON.HoldingArrayGenerator("field \"CategoryComponents\" of the RestaurantMenuCategory class", false);
            fieldGeneratorCategoryComponentsPrompt = new JSONHoldingStringGenerator("field \"CategoryComponentsPrompt\" of the RestaurantMenuCategory class");
            fieldGeneratorCategoryComponentsPromptSpoken = new JSONHoldingStringGenerator("field \"CategoryComponentsPromptSpoken\" of the RestaurantMenuCategory class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantMenuCategory class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorProductsInCategory.reset();
            fieldGeneratorCategoriesInCategory.reset();
            fieldGeneratorSynonyms.reset();
            fieldGeneratorTerrierExpression.reset();
            fieldGeneratorFlexibleExpressionData.reset();
            fieldGeneratorCategoryId.reset();
            fieldGeneratorCategoryName.reset();
            fieldGeneratorCategoryNameSpoken.reset();
            fieldGeneratorCategoryComponentsType.reset();
            fieldGeneratorCategoryComponentsTypeSpoken.reset();
            fieldGeneratorCategoryRestaurantId.reset();
            fieldGeneratorCategoryComponents.reset();
            fieldGeneratorCategoryComponentsPrompt.reset();
            fieldGeneratorCategoryComponentsPromptSpoken.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFlexibleExpressionData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCategoryComponents.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFlexibleExpressionData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCategoryComponents.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantMenuCategoryJSON  result)
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
        public RestaurantMenuCategoryJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantMenuCategoryJSON  result)
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
    protected virtual void handle_result(List<RestaurantMenuCategoryJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantMenuCategoryJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantMenuCategoryJSON>();
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
    public List<RestaurantMenuCategoryJSON> value;
  };
  };
