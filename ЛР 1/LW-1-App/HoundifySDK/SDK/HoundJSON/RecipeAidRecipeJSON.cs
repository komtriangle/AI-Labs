/* file "RecipeAidRecipeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RecipeAidRecipeJSON : JSONBase
  {
    private bool flagHasRecipeID;
    private BigInteger storeRecipeID;
    private bool flagHasTitle;
    private string storeTitle;
    private bool flagHasCuisine;
    private string storeCuisine;
    private bool flagHasCategory;
    private string storeCategory;
    private bool flagHasSubcategory;
    private string storeSubcategory;
    private bool flagHasPrimaryIngredient;
    private string storePrimaryIngredient;
    private bool flagHasWebURL;
    private string storeWebURL;
    private bool flagHasImageURLs;
    private List< string > storeImageURLs;
    private bool flagHasRating;
    private double storeRating;
    private string textStoreRating;
    private bool flagHasFavoriteCount;
    private BigInteger storeFavoriteCount;
    private bool flagHasTotalTries;
    private BigInteger storeTotalTries;
    private bool flagHasIngredients;
    private List< RecipeAidIngredientJSON  > storeIngredients;
    private bool flagHasInstructions;
    private List< RecipeAidInstructionDetailsJSON  > storeInstructions;
    private bool flagHasYieldNumber;
    private BigInteger storeYieldNumber;
    private bool flagHasYieldUnit;
    private string storeYieldUnit;
    private bool flagHasTotalMinutes;
    private BigInteger storeTotalMinutes;
    private bool flagHasActiveMinutes;
    private BigInteger storeActiveMinutes;
    private bool flagHasCreationDate;
    private string storeCreationDate;
    private bool flagHasLastModified;
    private string storeLastModified;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRecipeID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RecipeID of RecipeAidRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RecipeID of RecipeAidRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRecipeID(extracted_integer);
      }


    private void  fromJSONTitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Title of RecipeAidRecipeJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONCuisine(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Cuisine of RecipeAidRecipeJSON is not a string.");
        setCuisine(json_string.getData());
      }


    private void  fromJSONCategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Category of RecipeAidRecipeJSON is not a string.");
        setCategory(json_string.getData());
      }


    private void  fromJSONSubcategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Subcategory of RecipeAidRecipeJSON is not a string.");
        setSubcategory(json_string.getData());
      }


    private void  fromJSONPrimaryIngredient(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PrimaryIngredient of RecipeAidRecipeJSON is not a string.");
        setPrimaryIngredient(json_string.getData());
      }


    private void  fromJSONWebURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WebURL of RecipeAidRecipeJSON is not a string.");
        setWebURL(json_string.getData());
      }


    private void  fromJSONImageURLs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ImageURLs of RecipeAidRecipeJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ImageURLs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ImageURLs of RecipeAidRecipeJSON is not a string.");
            vector_ImageURLs1.Add(json_string.getData());
          }
        initImageURLs();
        for (int num1 = 0; num1 < vector_ImageURLs1.Count; ++num1)
            appendImageURLs(vector_ImageURLs1[num1]);
        for (int num1 = 0; num1 < vector_ImageURLs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRating(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONRationalValue json_rational = json_value.rational_value();
        string the_rational_text;
        if (json_rational != null)
          {
            the_rational_text = json_rational.getText();
          }
        else
          {
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer != null)
              {
                the_rational_text = json_integer.getText();
              }
            else
              {
                throw new Exception("The value for field Rating of RecipeAidRecipeJSON is not a number.");
              }
          }
        setRatingText(the_rational_text);
      }


    private void  fromJSONFavoriteCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FavoriteCount of RecipeAidRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FavoriteCount of RecipeAidRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFavoriteCount(extracted_integer);
      }


    private void  fromJSONTotalTries(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TotalTries of RecipeAidRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TotalTries of RecipeAidRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTotalTries(extracted_integer);
      }


    private void  fromJSONIngredients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Ingredients of RecipeAidRecipeJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RecipeAidIngredientJSON  > vector_Ingredients1 = new List< RecipeAidIngredientJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RecipeAidIngredientJSON convert_classy = RecipeAidIngredientJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Ingredients1.Add(convert_classy);
          }
        initIngredients();
        for (int num2 = 0; num2 < vector_Ingredients1.Count; ++num2)
            appendIngredients(vector_Ingredients1[num2]);
        for (int num1 = 0; num1 < vector_Ingredients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONInstructions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Instructions of RecipeAidRecipeJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RecipeAidInstructionDetailsJSON  > vector_Instructions1 = new List< RecipeAidInstructionDetailsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RecipeAidInstructionDetailsJSON convert_classy = RecipeAidInstructionDetailsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Instructions1.Add(convert_classy);
          }
        initInstructions();
        for (int num3 = 0; num3 < vector_Instructions1.Count; ++num3)
            appendInstructions(vector_Instructions1[num3]);
        for (int num1 = 0; num1 < vector_Instructions1.Count; ++num1)
          {
          }
      }


    private void  fromJSONYieldNumber(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field YieldNumber of RecipeAidRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field YieldNumber of RecipeAidRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setYieldNumber(extracted_integer);
      }


    private void  fromJSONYieldUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field YieldUnit of RecipeAidRecipeJSON is not a string.");
        setYieldUnit(json_string.getData());
      }


    private void  fromJSONTotalMinutes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TotalMinutes of RecipeAidRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TotalMinutes of RecipeAidRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTotalMinutes(extracted_integer);
      }


    private void  fromJSONActiveMinutes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ActiveMinutes of RecipeAidRecipeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ActiveMinutes of RecipeAidRecipeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setActiveMinutes(extracted_integer);
      }


    private void  fromJSONCreationDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CreationDate of RecipeAidRecipeJSON is not a string.");
        setCreationDate(json_string.getData());
      }


    private void  fromJSONLastModified(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastModified of RecipeAidRecipeJSON is not a string.");
        setLastModified(json_string.getData());
      }


    public RecipeAidRecipeJSON()
      {
        flagHasRecipeID = false;
        flagHasTitle = false;
        flagHasCuisine = false;
        flagHasCategory = false;
        flagHasSubcategory = false;
        flagHasPrimaryIngredient = false;
        flagHasWebURL = false;
        flagHasImageURLs = false;
        flagHasRating = false;
        flagHasFavoriteCount = false;
        flagHasTotalTries = false;
        flagHasIngredients = false;
        flagHasInstructions = false;
        flagHasYieldNumber = false;
        flagHasYieldUnit = false;
        flagHasTotalMinutes = false;
        flagHasActiveMinutes = false;
        flagHasCreationDate = false;
        flagHasLastModified = false;
        storeImageURLs = new List< string >();
        storeIngredients = new List< RecipeAidIngredientJSON  >();
        storeInstructions = new List< RecipeAidInstructionDetailsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRecipeID()
      {
        return flagHasRecipeID;
      }

    public BigInteger  getRecipeID()
      {
        Debug.Assert(flagHasRecipeID);
        return storeRecipeID;
      }

    public bool  hasTitle()
      {
        return flagHasTitle;
      }

    public string  getTitle()
      {
        Debug.Assert(flagHasTitle);
        return storeTitle;
      }

    public bool  hasCuisine()
      {
        return flagHasCuisine;
      }

    public string  getCuisine()
      {
        Debug.Assert(flagHasCuisine);
        return storeCuisine;
      }

    public bool  hasCategory()
      {
        return flagHasCategory;
      }

    public string  getCategory()
      {
        Debug.Assert(flagHasCategory);
        return storeCategory;
      }

    public bool  hasSubcategory()
      {
        return flagHasSubcategory;
      }

    public string  getSubcategory()
      {
        Debug.Assert(flagHasSubcategory);
        return storeSubcategory;
      }

    public bool  hasPrimaryIngredient()
      {
        return flagHasPrimaryIngredient;
      }

    public string  getPrimaryIngredient()
      {
        Debug.Assert(flagHasPrimaryIngredient);
        return storePrimaryIngredient;
      }

    public bool  hasWebURL()
      {
        return flagHasWebURL;
      }

    public string  getWebURL()
      {
        Debug.Assert(flagHasWebURL);
        return storeWebURL;
      }

    public bool  hasImageURLs()
      {
        return flagHasImageURLs;
      }

    public int  countOfImageURLs()
      {
        Debug.Assert(flagHasImageURLs);
        return storeImageURLs.Count;
      }

    public string  elementOfImageURLs(int element_num)
      {
        Debug.Assert(flagHasImageURLs);
        return storeImageURLs[element_num];
      }

    public List< string >  getImageURLs()
      {
        Debug.Assert(flagHasImageURLs);
        return storeImageURLs;
      }

    public bool  hasRating()
      {
        return flagHasRating;
      }

    public double  getRating()
      {
        Debug.Assert(flagHasRating);
        if (textStoreRating != "")
          {
            return Double.Parse(textStoreRating);
          }
        return storeRating;
      }

    public string  getRatingAsText()
      {
        Debug.Assert(flagHasRating);
        if (textStoreRating == "")
          {
            return Convert.ToString(storeRating);
          }
        else
          {
            return (textStoreRating);
          }
      }

    public bool  hasFavoriteCount()
      {
        return flagHasFavoriteCount;
      }

    public BigInteger  getFavoriteCount()
      {
        Debug.Assert(flagHasFavoriteCount);
        return storeFavoriteCount;
      }

    public bool  hasTotalTries()
      {
        return flagHasTotalTries;
      }

    public BigInteger  getTotalTries()
      {
        Debug.Assert(flagHasTotalTries);
        return storeTotalTries;
      }

    public bool  hasIngredients()
      {
        return flagHasIngredients;
      }

    public int  countOfIngredients()
      {
        Debug.Assert(flagHasIngredients);
        return storeIngredients.Count;
      }

    public RecipeAidIngredientJSON   elementOfIngredients(int element_num)
      {
        Debug.Assert(flagHasIngredients);
        return storeIngredients[element_num];
      }

    public List< RecipeAidIngredientJSON  >  getIngredients()
      {
        Debug.Assert(flagHasIngredients);
        return storeIngredients;
      }

    public bool  hasInstructions()
      {
        return flagHasInstructions;
      }

    public int  countOfInstructions()
      {
        Debug.Assert(flagHasInstructions);
        return storeInstructions.Count;
      }

    public RecipeAidInstructionDetailsJSON   elementOfInstructions(int element_num)
      {
        Debug.Assert(flagHasInstructions);
        return storeInstructions[element_num];
      }

    public List< RecipeAidInstructionDetailsJSON  >  getInstructions()
      {
        Debug.Assert(flagHasInstructions);
        return storeInstructions;
      }

    public bool  hasYieldNumber()
      {
        return flagHasYieldNumber;
      }

    public BigInteger  getYieldNumber()
      {
        Debug.Assert(flagHasYieldNumber);
        return storeYieldNumber;
      }

    public bool  hasYieldUnit()
      {
        return flagHasYieldUnit;
      }

    public string  getYieldUnit()
      {
        Debug.Assert(flagHasYieldUnit);
        return storeYieldUnit;
      }

    public bool  hasTotalMinutes()
      {
        return flagHasTotalMinutes;
      }

    public BigInteger  getTotalMinutes()
      {
        Debug.Assert(flagHasTotalMinutes);
        return storeTotalMinutes;
      }

    public bool  hasActiveMinutes()
      {
        return flagHasActiveMinutes;
      }

    public BigInteger  getActiveMinutes()
      {
        Debug.Assert(flagHasActiveMinutes);
        return storeActiveMinutes;
      }

    public bool  hasCreationDate()
      {
        return flagHasCreationDate;
      }

    public string  getCreationDate()
      {
        Debug.Assert(flagHasCreationDate);
        return storeCreationDate;
      }

    public bool  hasLastModified()
      {
        return flagHasLastModified;
      }

    public string  getLastModified()
      {
        Debug.Assert(flagHasLastModified);
        return storeLastModified;
      }


    public virtual int extraRecipeAidRecipeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRecipeAidRecipeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRecipeAidRecipeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRecipeAidRecipeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setRecipeID(BigInteger new_value)
      {
        flagHasRecipeID = true;
        if (new_value < 0)
            throw new Exception("The value for field RecipeID of RecipeAidRecipeJSON is less than the lower bound (0) for that field.");
        storeRecipeID = new_value;
      }
    public void unsetRecipeID()
      {
        flagHasRecipeID = false;
      }
    public void setTitle(string new_value)
      {
        flagHasTitle = true;
        storeTitle = new_value;
      }
    public void unsetTitle()
      {
        flagHasTitle = false;
      }
    public void setCuisine(string new_value)
      {
        flagHasCuisine = true;
        storeCuisine = new_value;
      }
    public void unsetCuisine()
      {
        flagHasCuisine = false;
      }
    public void setCategory(string new_value)
      {
        flagHasCategory = true;
        storeCategory = new_value;
      }
    public void unsetCategory()
      {
        flagHasCategory = false;
      }
    public void setSubcategory(string new_value)
      {
        flagHasSubcategory = true;
        storeSubcategory = new_value;
      }
    public void unsetSubcategory()
      {
        flagHasSubcategory = false;
      }
    public void setPrimaryIngredient(string new_value)
      {
        flagHasPrimaryIngredient = true;
        storePrimaryIngredient = new_value;
      }
    public void unsetPrimaryIngredient()
      {
        flagHasPrimaryIngredient = false;
      }
    public void setWebURL(string new_value)
      {
        flagHasWebURL = true;
        storeWebURL = new_value;
      }
    public void unsetWebURL()
      {
        flagHasWebURL = false;
      }
    public void initImageURLs()
      {
        flagHasImageURLs = true;
        storeImageURLs.Clear();
      }
    public void appendImageURLs(string to_append)
      {
        if (!flagHasImageURLs)
          {
            flagHasImageURLs = true;
            storeImageURLs.Clear();
          }
        Debug.Assert(flagHasImageURLs);
        storeImageURLs.Add(to_append);
      }
    public void unsetImageURLs()
      {
        flagHasImageURLs = false;
        storeImageURLs.Clear();
      }
    public void setRating(double new_value)
      {
        flagHasRating = true;
        if (new_value < 0)
            throw new Exception("The value for field Rating of RecipeAidRecipeJSON is less than the lower bound (0) for that field.");
        if (new_value > 5)
            throw new Exception("The value for field Rating of RecipeAidRecipeJSON is greater than the upper bound (5) for that field.");
        storeRating = new_value;
        textStoreRating = "";
      }
    public void setRatingText(string new_value)
      {
        flagHasRating = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Rating of RecipeAidRecipeJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Rating of RecipeAidRecipeJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "5", "", false, "1") > 0)
            throw new Exception("The value for field Rating of RecipeAidRecipeJSON is greater than the upper bound (5) for that field.");
        textStoreRating = new_value;
      }
    public void unsetRating()
      {
        flagHasRating = false;
      }
    public void setFavoriteCount(BigInteger new_value)
      {
        flagHasFavoriteCount = true;
        if (new_value < 0)
            throw new Exception("The value for field FavoriteCount of RecipeAidRecipeJSON is less than the lower bound (0) for that field.");
        storeFavoriteCount = new_value;
      }
    public void unsetFavoriteCount()
      {
        flagHasFavoriteCount = false;
      }
    public void setTotalTries(BigInteger new_value)
      {
        flagHasTotalTries = true;
        if (new_value < 0)
            throw new Exception("The value for field TotalTries of RecipeAidRecipeJSON is less than the lower bound (0) for that field.");
        storeTotalTries = new_value;
      }
    public void unsetTotalTries()
      {
        flagHasTotalTries = false;
      }
    public void initIngredients()
      {
        if (flagHasIngredients)
          {
            for (int num1 = 0; num1 < storeIngredients.Count; ++num1)
              {
              }
          }
        flagHasIngredients = true;
        storeIngredients.Clear();
      }
    public void appendIngredients(RecipeAidIngredientJSON  to_append)
      {
        if (!flagHasIngredients)
          {
            flagHasIngredients = true;
            storeIngredients.Clear();
          }
        Debug.Assert(flagHasIngredients);
        storeIngredients.Add(to_append);
      }
    public void unsetIngredients()
      {
        if (flagHasIngredients)
          {
            for (int num2 = 0; num2 < storeIngredients.Count; ++num2)
              {
              }
          }
        flagHasIngredients = false;
        storeIngredients.Clear();
      }
    public void initInstructions()
      {
        if (flagHasInstructions)
          {
            for (int num3 = 0; num3 < storeInstructions.Count; ++num3)
              {
              }
          }
        flagHasInstructions = true;
        storeInstructions.Clear();
      }
    public void appendInstructions(RecipeAidInstructionDetailsJSON  to_append)
      {
        if (!flagHasInstructions)
          {
            flagHasInstructions = true;
            storeInstructions.Clear();
          }
        Debug.Assert(flagHasInstructions);
        storeInstructions.Add(to_append);
      }
    public void unsetInstructions()
      {
        if (flagHasInstructions)
          {
            for (int num4 = 0; num4 < storeInstructions.Count; ++num4)
              {
              }
          }
        flagHasInstructions = false;
        storeInstructions.Clear();
      }
    public void setYieldNumber(BigInteger new_value)
      {
        flagHasYieldNumber = true;
        if (new_value < 0)
            throw new Exception("The value for field YieldNumber of RecipeAidRecipeJSON is less than the lower bound (0) for that field.");
        storeYieldNumber = new_value;
      }
    public void unsetYieldNumber()
      {
        flagHasYieldNumber = false;
      }
    public void setYieldUnit(string new_value)
      {
        flagHasYieldUnit = true;
        storeYieldUnit = new_value;
      }
    public void unsetYieldUnit()
      {
        flagHasYieldUnit = false;
      }
    public void setTotalMinutes(BigInteger new_value)
      {
        flagHasTotalMinutes = true;
        if (new_value < 0)
            throw new Exception("The value for field TotalMinutes of RecipeAidRecipeJSON is less than the lower bound (0) for that field.");
        storeTotalMinutes = new_value;
      }
    public void unsetTotalMinutes()
      {
        flagHasTotalMinutes = false;
      }
    public void setActiveMinutes(BigInteger new_value)
      {
        flagHasActiveMinutes = true;
        if (new_value < 0)
            throw new Exception("The value for field ActiveMinutes of RecipeAidRecipeJSON is less than the lower bound (0) for that field.");
        storeActiveMinutes = new_value;
      }
    public void unsetActiveMinutes()
      {
        flagHasActiveMinutes = false;
      }
    public void setCreationDate(string new_value)
      {
        flagHasCreationDate = true;
        storeCreationDate = new_value;
      }
    public void unsetCreationDate()
      {
        flagHasCreationDate = false;
      }
    public void setLastModified(string new_value)
      {
        flagHasLastModified = true;
        storeLastModified = new_value;
      }
    public void unsetLastModified()
      {
        flagHasLastModified = false;
      }

    public virtual void extraRecipeAidRecipeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRecipeAidRecipeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRecipeAidRecipeLookup(key);
        if (old_field == null)
          {
            extraRecipeAidRecipeAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasRecipeID);
        if (flagHasRecipeID)
          {
            handler.start_pair("RecipeID");
            handler.number_value(storeRecipeID);
          }
        Debug.Assert(partial_allowed || flagHasTitle);
        if (flagHasTitle)
          {
            handler.start_pair("Title");
            handler.string_value(storeTitle);
          }
        if (flagHasCuisine)
          {
            handler.start_pair("Cuisine");
            handler.string_value(storeCuisine);
          }
        if (flagHasCategory)
          {
            handler.start_pair("Category");
            handler.string_value(storeCategory);
          }
        if (flagHasSubcategory)
          {
            handler.start_pair("Subcategory");
            handler.string_value(storeSubcategory);
          }
        if (flagHasPrimaryIngredient)
          {
            handler.start_pair("PrimaryIngredient");
            handler.string_value(storePrimaryIngredient);
          }
        if (flagHasWebURL)
          {
            handler.start_pair("WebURL");
            handler.string_value(storeWebURL);
          }
        if (flagHasImageURLs)
          {
            handler.start_pair("ImageURLs");
            handler.start_array();
            for (int num1 = 0; num1 < storeImageURLs.Count; ++num1)
              {
                handler.string_value(storeImageURLs[num1]);
              }
            handler.finish_array();
          }
        if (flagHasRating)
          {
            handler.start_pair("Rating");
            if (textStoreRating != "")
                handler.number_value(textStoreRating);
            else if (((double)(long)storeRating) == storeRating)
                handler.number_value((long)storeRating);
            else
                handler.number_value(storeRating);
          }
        if (flagHasFavoriteCount)
          {
            handler.start_pair("FavoriteCount");
            handler.number_value(storeFavoriteCount);
          }
        if (flagHasTotalTries)
          {
            handler.start_pair("TotalTries");
            handler.number_value(storeTotalTries);
          }
        if (flagHasIngredients)
          {
            handler.start_pair("Ingredients");
            handler.start_array();
            for (int num2 = 0; num2 < storeIngredients.Count; ++num2)
              {
                if (partial_allowed)
                    storeIngredients[num2].write_partial_as_json(handler);
                else
                    storeIngredients[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasInstructions)
          {
            handler.start_pair("Instructions");
            handler.start_array();
            for (int num3 = 0; num3 < storeInstructions.Count; ++num3)
              {
                if (partial_allowed)
                    storeInstructions[num3].write_partial_as_json(handler);
                else
                    storeInstructions[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasYieldNumber)
          {
            handler.start_pair("YieldNumber");
            handler.number_value(storeYieldNumber);
          }
        if (flagHasYieldUnit)
          {
            handler.start_pair("YieldUnit");
            handler.string_value(storeYieldUnit);
          }
        if (flagHasTotalMinutes)
          {
            handler.start_pair("TotalMinutes");
            handler.number_value(storeTotalMinutes);
          }
        if (flagHasActiveMinutes)
          {
            handler.start_pair("ActiveMinutes");
            handler.number_value(storeActiveMinutes);
          }
        if (flagHasCreationDate)
          {
            handler.start_pair("CreationDate");
            handler.string_value(storeCreationDate);
          }
        if (flagHasLastModified)
          {
            handler.start_pair("LastModified");
            handler.string_value(storeLastModified);
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
        if (!(hasRecipeID()))
          {
            return "When parsing the object for %what%, the \"RecipeID\" field was missing.";
          }
        if (!(hasTitle()))
          {
            return "When parsing the object for %what%, the \"Title\" field was missing.";
          }
        return null;
      }

    public static RecipeAidRecipeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAidRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidRecipe", ignore_extras);
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
    public static RecipeAidRecipeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RecipeAidRecipeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeAidRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidRecipe", ignore_extras);
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
    public static RecipeAidRecipeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RecipeAidRecipeJSON from_text(string text, bool ignore_extras)
      {
        RecipeAidRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidRecipe", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RecipeAidRecipeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RecipeAidRecipeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RecipeAidRecipeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeAidRecipe", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorRecipeID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorRecipeID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorRecipeID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorRecipeID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorRecipeID fieldGeneratorRecipeID;
        private JSONHoldingStringGenerator fieldGeneratorTitle;
        private JSONHoldingStringGenerator fieldGeneratorCuisine;
        private JSONHoldingStringGenerator fieldGeneratorCategory;
        private JSONHoldingStringGenerator fieldGeneratorSubcategory;
        private JSONHoldingStringGenerator fieldGeneratorPrimaryIngredient;
        private JSONHoldingStringGenerator fieldGeneratorWebURL;
        private JSONHoldingStringArrayGenerator fieldGeneratorImageURLs;
        private JSONHoldingNumberTextGenerator fieldGeneratorRating;
    private class FieldHoldingGeneratorFavoriteCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorFavoriteCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorFavoriteCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorFavoriteCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorFavoriteCount fieldGeneratorFavoriteCount;
    private class FieldHoldingGeneratorTotalTries : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTotalTries(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTotalTries : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTotalTries(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTotalTries fieldGeneratorTotalTries;
        private RecipeAidIngredientJSON.HoldingArrayGenerator fieldGeneratorIngredients;
        private RecipeAidInstructionDetailsJSON.HoldingArrayGenerator fieldGeneratorInstructions;
    private class FieldHoldingGeneratorYieldNumber : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorYieldNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorYieldNumber : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorYieldNumber(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorYieldNumber fieldGeneratorYieldNumber;
        private JSONHoldingStringGenerator fieldGeneratorYieldUnit;
    private class FieldHoldingGeneratorTotalMinutes : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTotalMinutes(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTotalMinutes : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTotalMinutes(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTotalMinutes fieldGeneratorTotalMinutes;
    private class FieldHoldingGeneratorActiveMinutes : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorActiveMinutes(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorActiveMinutes : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorActiveMinutes(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorActiveMinutes fieldGeneratorActiveMinutes;
        private JSONHoldingStringGenerator fieldGeneratorCreationDate;
        private JSONHoldingStringGenerator fieldGeneratorLastModified;
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
            RecipeAidRecipeJSON result = new RecipeAidRecipeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRecipeAidRecipeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RecipeAidRecipeJSON result)
          {
            if (fieldGeneratorRecipeID.have_value)
              {
                result.setRecipeID(fieldGeneratorRecipeID.value);
                fieldGeneratorRecipeID.have_value = false;
              }
            else if ((!(result.hasRecipeID())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RecipeID\" field was missing.");
              }
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
              }
            else if ((!(result.hasTitle())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Title\" field was missing.");
              }
            if (fieldGeneratorCuisine.have_value)
              {
                result.setCuisine(fieldGeneratorCuisine.value);
                fieldGeneratorCuisine.have_value = false;
              }
            if (fieldGeneratorCategory.have_value)
              {
                result.setCategory(fieldGeneratorCategory.value);
                fieldGeneratorCategory.have_value = false;
              }
            if (fieldGeneratorSubcategory.have_value)
              {
                result.setSubcategory(fieldGeneratorSubcategory.value);
                fieldGeneratorSubcategory.have_value = false;
              }
            if (fieldGeneratorPrimaryIngredient.have_value)
              {
                result.setPrimaryIngredient(fieldGeneratorPrimaryIngredient.value);
                fieldGeneratorPrimaryIngredient.have_value = false;
              }
            if (fieldGeneratorWebURL.have_value)
              {
                result.setWebURL(fieldGeneratorWebURL.value);
                fieldGeneratorWebURL.have_value = false;
              }
            if (fieldGeneratorImageURLs.have_value)
              {
                result.initImageURLs();
                int count = fieldGeneratorImageURLs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendImageURLs(fieldGeneratorImageURLs.value[num]);
                  }
                fieldGeneratorImageURLs.value.Clear();
                fieldGeneratorImageURLs.have_value = false;
              }
            if (fieldGeneratorRating.have_value)
              {
                result.setRatingText(fieldGeneratorRating.value);
                fieldGeneratorRating.have_value = false;
              }
            if (fieldGeneratorFavoriteCount.have_value)
              {
                result.setFavoriteCount(fieldGeneratorFavoriteCount.value);
                fieldGeneratorFavoriteCount.have_value = false;
              }
            if (fieldGeneratorTotalTries.have_value)
              {
                result.setTotalTries(fieldGeneratorTotalTries.value);
                fieldGeneratorTotalTries.have_value = false;
              }
            if (fieldGeneratorIngredients.have_value)
              {
                result.initIngredients();
                int count = fieldGeneratorIngredients.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendIngredients(fieldGeneratorIngredients.value[num]);
                  }
                fieldGeneratorIngredients.value.Clear();
                fieldGeneratorIngredients.have_value = false;
              }
            if (fieldGeneratorInstructions.have_value)
              {
                result.initInstructions();
                int count = fieldGeneratorInstructions.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendInstructions(fieldGeneratorInstructions.value[num]);
                  }
                fieldGeneratorInstructions.value.Clear();
                fieldGeneratorInstructions.have_value = false;
              }
            if (fieldGeneratorYieldNumber.have_value)
              {
                result.setYieldNumber(fieldGeneratorYieldNumber.value);
                fieldGeneratorYieldNumber.have_value = false;
              }
            if (fieldGeneratorYieldUnit.have_value)
              {
                result.setYieldUnit(fieldGeneratorYieldUnit.value);
                fieldGeneratorYieldUnit.have_value = false;
              }
            if (fieldGeneratorTotalMinutes.have_value)
              {
                result.setTotalMinutes(fieldGeneratorTotalMinutes.value);
                fieldGeneratorTotalMinutes.have_value = false;
              }
            if (fieldGeneratorActiveMinutes.have_value)
              {
                result.setActiveMinutes(fieldGeneratorActiveMinutes.value);
                fieldGeneratorActiveMinutes.have_value = false;
              }
            if (fieldGeneratorCreationDate.have_value)
              {
                result.setCreationDate(fieldGeneratorCreationDate.value);
                fieldGeneratorCreationDate.have_value = false;
              }
            if (fieldGeneratorLastModified.have_value)
              {
                result.setLastModified(fieldGeneratorLastModified.value);
                fieldGeneratorLastModified.have_value = false;
              }
          }
        protected abstract void handle_result(RecipeAidRecipeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "ctiveMinutes", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorActiveMinutes;
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "tegory", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorCategory;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "eationDate", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorCreationDate;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "isine", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorCuisine;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "avoriteCount", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorFavoriteCount;
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'm':
                            if ((String.Compare(field_name, 2, "ageURLs", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorImageURLs;
                            break;
                        case 'n':
                            switch (field_name[2])
                              {
                                case 'g':
                                    if ((String.Compare(field_name, 3, "redients", 0, 8, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorIngredients;
                                    break;
                                case 's':
                                    if ((String.Compare(field_name, 3, "tructions", 0, 9, false) == 0) && (field_name.Length == 12))
                                        return fieldGeneratorInstructions;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astModified", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorLastModified;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "rimaryIngredient", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorPrimaryIngredient;
                    break;
                case 'R':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ting", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorRating;
                            break;
                        case 'e':
                            if ((String.Compare(field_name, 2, "cipeID", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorRecipeID;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "ubcategory", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorSubcategory;
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "tle", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorTitle;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "tal", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'M':
                                        if ((String.Compare(field_name, 6, "inutes", 0, 6, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorTotalMinutes;
                                        break;
                                    case 'T':
                                        if ((String.Compare(field_name, 6, "ries", 0, 4, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorTotalTries;
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
                case 'W':
                    if ((String.Compare(field_name, 1, "ebURL", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorWebURL;
                    break;
                case 'Y':
                    if (String.Compare(field_name, 1, "ield", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'N':
                                if ((String.Compare(field_name, 6, "umber", 0, 5, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorYieldNumber;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 6, "nit", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorYieldUnit;
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
            fieldGeneratorRecipeID = new FieldHoldingGeneratorRecipeID("field \"RecipeID\" of the RecipeAidRecipe class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the RecipeAidRecipe class");
            fieldGeneratorCuisine = new JSONHoldingStringGenerator("field \"Cuisine\" of the RecipeAidRecipe class");
            fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the RecipeAidRecipe class");
            fieldGeneratorSubcategory = new JSONHoldingStringGenerator("field \"Subcategory\" of the RecipeAidRecipe class");
            fieldGeneratorPrimaryIngredient = new JSONHoldingStringGenerator("field \"PrimaryIngredient\" of the RecipeAidRecipe class");
            fieldGeneratorWebURL = new JSONHoldingStringGenerator("field \"WebURL\" of the RecipeAidRecipe class");
            fieldGeneratorImageURLs = new JSONHoldingStringArrayGenerator("field \"ImageURLs\" of the RecipeAidRecipe class");
            fieldGeneratorRating = new JSONHoldingNumberTextGenerator("field \"Rating\" of the RecipeAidRecipe class");
            fieldGeneratorFavoriteCount = new FieldHoldingGeneratorFavoriteCount("field \"FavoriteCount\" of the RecipeAidRecipe class");
            fieldGeneratorTotalTries = new FieldHoldingGeneratorTotalTries("field \"TotalTries\" of the RecipeAidRecipe class");
            fieldGeneratorIngredients = new RecipeAidIngredientJSON.HoldingArrayGenerator("field \"Ingredients\" of the RecipeAidRecipe class", ignore_extras);
            fieldGeneratorInstructions = new RecipeAidInstructionDetailsJSON.HoldingArrayGenerator("field \"Instructions\" of the RecipeAidRecipe class", ignore_extras);
            fieldGeneratorYieldNumber = new FieldHoldingGeneratorYieldNumber("field \"YieldNumber\" of the RecipeAidRecipe class");
            fieldGeneratorYieldUnit = new JSONHoldingStringGenerator("field \"YieldUnit\" of the RecipeAidRecipe class");
            fieldGeneratorTotalMinutes = new FieldHoldingGeneratorTotalMinutes("field \"TotalMinutes\" of the RecipeAidRecipe class");
            fieldGeneratorActiveMinutes = new FieldHoldingGeneratorActiveMinutes("field \"ActiveMinutes\" of the RecipeAidRecipe class");
            fieldGeneratorCreationDate = new JSONHoldingStringGenerator("field \"CreationDate\" of the RecipeAidRecipe class");
            fieldGeneratorLastModified = new JSONHoldingStringGenerator("field \"LastModified\" of the RecipeAidRecipe class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RecipeAidRecipe class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRecipeID = new FieldHoldingGeneratorRecipeID("field \"RecipeID\" of the RecipeAidRecipe class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the RecipeAidRecipe class");
            fieldGeneratorCuisine = new JSONHoldingStringGenerator("field \"Cuisine\" of the RecipeAidRecipe class");
            fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the RecipeAidRecipe class");
            fieldGeneratorSubcategory = new JSONHoldingStringGenerator("field \"Subcategory\" of the RecipeAidRecipe class");
            fieldGeneratorPrimaryIngredient = new JSONHoldingStringGenerator("field \"PrimaryIngredient\" of the RecipeAidRecipe class");
            fieldGeneratorWebURL = new JSONHoldingStringGenerator("field \"WebURL\" of the RecipeAidRecipe class");
            fieldGeneratorImageURLs = new JSONHoldingStringArrayGenerator("field \"ImageURLs\" of the RecipeAidRecipe class");
            fieldGeneratorRating = new JSONHoldingNumberTextGenerator("field \"Rating\" of the RecipeAidRecipe class");
            fieldGeneratorFavoriteCount = new FieldHoldingGeneratorFavoriteCount("field \"FavoriteCount\" of the RecipeAidRecipe class");
            fieldGeneratorTotalTries = new FieldHoldingGeneratorTotalTries("field \"TotalTries\" of the RecipeAidRecipe class");
            fieldGeneratorIngredients = new RecipeAidIngredientJSON.HoldingArrayGenerator("field \"Ingredients\" of the RecipeAidRecipe class", false);
            fieldGeneratorInstructions = new RecipeAidInstructionDetailsJSON.HoldingArrayGenerator("field \"Instructions\" of the RecipeAidRecipe class", false);
            fieldGeneratorYieldNumber = new FieldHoldingGeneratorYieldNumber("field \"YieldNumber\" of the RecipeAidRecipe class");
            fieldGeneratorYieldUnit = new JSONHoldingStringGenerator("field \"YieldUnit\" of the RecipeAidRecipe class");
            fieldGeneratorTotalMinutes = new FieldHoldingGeneratorTotalMinutes("field \"TotalMinutes\" of the RecipeAidRecipe class");
            fieldGeneratorActiveMinutes = new FieldHoldingGeneratorActiveMinutes("field \"ActiveMinutes\" of the RecipeAidRecipe class");
            fieldGeneratorCreationDate = new JSONHoldingStringGenerator("field \"CreationDate\" of the RecipeAidRecipe class");
            fieldGeneratorLastModified = new JSONHoldingStringGenerator("field \"LastModified\" of the RecipeAidRecipe class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RecipeAidRecipe class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRecipeID.reset();
            fieldGeneratorTitle.reset();
            fieldGeneratorCuisine.reset();
            fieldGeneratorCategory.reset();
            fieldGeneratorSubcategory.reset();
            fieldGeneratorPrimaryIngredient.reset();
            fieldGeneratorWebURL.reset();
            fieldGeneratorImageURLs.reset();
            fieldGeneratorRating.reset();
            fieldGeneratorFavoriteCount.reset();
            fieldGeneratorTotalTries.reset();
            fieldGeneratorIngredients.reset();
            fieldGeneratorInstructions.reset();
            fieldGeneratorYieldNumber.reset();
            fieldGeneratorYieldUnit.reset();
            fieldGeneratorTotalMinutes.reset();
            fieldGeneratorActiveMinutes.reset();
            fieldGeneratorCreationDate.reset();
            fieldGeneratorLastModified.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorIngredients.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorInstructions.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorIngredients.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorInstructions.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RecipeAidRecipeJSON  result)
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
        public RecipeAidRecipeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RecipeAidRecipeJSON  result)
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
    protected virtual void handle_result(List<RecipeAidRecipeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RecipeAidRecipeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RecipeAidRecipeJSON>();
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
    public List<RecipeAidRecipeJSON> value;
  };
  };
