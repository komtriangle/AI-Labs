/* file "DishDetailsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class DishDetailsJSON : JSONBase
  {
    private bool flagHasName;
    private string storeName;
    private bool flagHasDescription;
    private string storeDescription;
    private bool flagHasRecipeID;
    private BigInteger storeRecipeID;
    private bool flagHasCuisineType;
    private string storeCuisineType;
    private bool flagHasTotalMinutes;
    private BigInteger storeTotalMinutes;
    private bool flagHasActiveMinutes;
    private BigInteger storeActiveMinutes;
    private bool flagHasNumPeopletoServe;
    private BigInteger storeNumPeopletoServe;
    private bool flagHasYieldNumber;
    private double storeYieldNumber;
    private string textStoreYieldNumber;
    private bool flagHasYieldUnit;
    private string storeYieldUnit;
    private bool flagHasCategory;
    private string storeCategory;
    private bool flagHasPrimaryIngredient;
    private string storePrimaryIngredient;
    private bool flagHasStarRating;
    private double storeStarRating;
    private string textStoreStarRating;
    private bool flagHasWebURL;
    private string storeWebURL;
    private bool flagHasImageURL;
    private string storeImageURL;
    private bool flagHasReviewCount;
    private BigInteger storeReviewCount;
    private bool flagHasCreationDate;
    private string storeCreationDate;
    private bool flagHasLastModified;
    private string storeLastModified;
    private bool flagHasPhotoUrl;
    private string storePhotoUrl;
    private bool flagHasAuthor;
    private RecipeAuthorJSON  storeAuthor;
    private bool flagHasNutritionInfo;
    private RecipeNutritionInfoJSON  storeNutritionInfo;
    private bool flagHasIngredients;
    private List< IngredientInfoJSON  > storeIngredients;
    private bool flagHasInstructions;
    private List< string > storeInstructions;
    private bool flagHasAttribution;
    private AttributionJSON  storeAttribution;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Name of DishDetailsJSON is not a string.");
        setName(json_string.getData());
      }


    private void  fromJSONDescription(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Description of DishDetailsJSON is not a string.");
        setDescription(json_string.getData());
      }


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
                throw new Exception("The value for field RecipeID of DishDetailsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RecipeID of DishDetailsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRecipeID(extracted_integer);
      }


    private void  fromJSONCuisineType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CuisineType of DishDetailsJSON is not a string.");
        setCuisineType(json_string.getData());
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
                throw new Exception("The value for field TotalMinutes of DishDetailsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TotalMinutes of DishDetailsJSON is not an integer.");
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
                throw new Exception("The value for field ActiveMinutes of DishDetailsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ActiveMinutes of DishDetailsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setActiveMinutes(extracted_integer);
      }


    private void  fromJSONNumPeopletoServe(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NumPeopletoServe of DishDetailsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NumPeopletoServe of DishDetailsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNumPeopletoServe(extracted_integer);
      }


    private void  fromJSONYieldNumber(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field YieldNumber of DishDetailsJSON is not a number.");
              }
          }
        setYieldNumberText(the_rational_text);
      }


    private void  fromJSONYieldUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field YieldUnit of DishDetailsJSON is not a string.");
        setYieldUnit(json_string.getData());
      }


    private void  fromJSONCategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Category of DishDetailsJSON is not a string.");
        setCategory(json_string.getData());
      }


    private void  fromJSONPrimaryIngredient(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PrimaryIngredient of DishDetailsJSON is not a string.");
        setPrimaryIngredient(json_string.getData());
      }


    private void  fromJSONStarRating(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StarRating of DishDetailsJSON is not a number.");
              }
          }
        setStarRatingText(the_rational_text);
      }


    private void  fromJSONWebURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WebURL of DishDetailsJSON is not a string.");
        setWebURL(json_string.getData());
      }


    private void  fromJSONImageURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ImageURL of DishDetailsJSON is not a string.");
        setImageURL(json_string.getData());
      }


    private void  fromJSONReviewCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ReviewCount of DishDetailsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ReviewCount of DishDetailsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setReviewCount(extracted_integer);
      }


    private void  fromJSONCreationDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CreationDate of DishDetailsJSON is not a string.");
        setCreationDate(json_string.getData());
      }


    private void  fromJSONLastModified(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastModified of DishDetailsJSON is not a string.");
        setLastModified(json_string.getData());
      }


    private void  fromJSONPhotoUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PhotoUrl of DishDetailsJSON is not a string.");
        setPhotoUrl(json_string.getData());
      }


    private void  fromJSONAuthor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RecipeAuthorJSON convert_classy = RecipeAuthorJSON.from_json(json_value, ignore_extras, true);
        setAuthor(convert_classy);
      }


    private void  fromJSONNutritionInfo(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RecipeNutritionInfoJSON convert_classy = RecipeNutritionInfoJSON.from_json(json_value, ignore_extras, true);
        setNutritionInfo(convert_classy);
      }


    private void  fromJSONIngredients(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Ingredients of DishDetailsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< IngredientInfoJSON  > vector_Ingredients1 = new List< IngredientInfoJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            IngredientInfoJSON convert_classy = IngredientInfoJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Ingredients1.Add(convert_classy);
          }
        initIngredients();
        for (int num1 = 0; num1 < vector_Ingredients1.Count; ++num1)
            appendIngredients(vector_Ingredients1[num1]);
        for (int num1 = 0; num1 < vector_Ingredients1.Count; ++num1)
          {
          }
      }


    private void  fromJSONInstructions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Instructions of DishDetailsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_Instructions1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Instructions of DishDetailsJSON is not a string.");
            vector_Instructions1.Add(json_string.getData());
          }
        initInstructions();
        for (int num2 = 0; num2 < vector_Instructions1.Count; ++num2)
            appendInstructions(vector_Instructions1[num2]);
        for (int num1 = 0; num1 < vector_Instructions1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAttribution(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        AttributionJSON convert_classy = AttributionJSON.from_json(json_value, ignore_extras, true);
        setAttribution(convert_classy);
      }


    public DishDetailsJSON()
      {
        flagHasName = false;
        flagHasDescription = false;
        flagHasRecipeID = false;
        flagHasCuisineType = false;
        flagHasTotalMinutes = false;
        flagHasActiveMinutes = false;
        flagHasNumPeopletoServe = false;
        flagHasYieldNumber = false;
        flagHasYieldUnit = false;
        flagHasCategory = false;
        flagHasPrimaryIngredient = false;
        flagHasStarRating = false;
        flagHasWebURL = false;
        flagHasImageURL = false;
        flagHasReviewCount = false;
        flagHasCreationDate = false;
        flagHasLastModified = false;
        flagHasPhotoUrl = false;
        flagHasAuthor = false;
        flagHasNutritionInfo = false;
        flagHasIngredients = false;
        flagHasInstructions = false;
        flagHasAttribution = false;
        storeIngredients = new List< IngredientInfoJSON  >();
        storeInstructions = new List< string >();
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

    public bool  hasDescription()
      {
        return flagHasDescription;
      }

    public string  getDescription()
      {
        Debug.Assert(flagHasDescription);
        return storeDescription;
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

    public bool  hasCuisineType()
      {
        return flagHasCuisineType;
      }

    public string  getCuisineType()
      {
        Debug.Assert(flagHasCuisineType);
        return storeCuisineType;
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

    public bool  hasNumPeopletoServe()
      {
        return flagHasNumPeopletoServe;
      }

    public BigInteger  getNumPeopletoServe()
      {
        Debug.Assert(flagHasNumPeopletoServe);
        return storeNumPeopletoServe;
      }

    public bool  hasYieldNumber()
      {
        return flagHasYieldNumber;
      }

    public double  getYieldNumber()
      {
        Debug.Assert(flagHasYieldNumber);
        if (textStoreYieldNumber != "")
          {
            return Double.Parse(textStoreYieldNumber);
          }
        return storeYieldNumber;
      }

    public string  getYieldNumberAsText()
      {
        Debug.Assert(flagHasYieldNumber);
        if (textStoreYieldNumber == "")
          {
            return Convert.ToString(storeYieldNumber);
          }
        else
          {
            return (textStoreYieldNumber);
          }
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

    public bool  hasCategory()
      {
        return flagHasCategory;
      }

    public string  getCategory()
      {
        Debug.Assert(flagHasCategory);
        return storeCategory;
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

    public bool  hasStarRating()
      {
        return flagHasStarRating;
      }

    public double  getStarRating()
      {
        Debug.Assert(flagHasStarRating);
        if (textStoreStarRating != "")
          {
            return Double.Parse(textStoreStarRating);
          }
        return storeStarRating;
      }

    public string  getStarRatingAsText()
      {
        Debug.Assert(flagHasStarRating);
        if (textStoreStarRating == "")
          {
            return Convert.ToString(storeStarRating);
          }
        else
          {
            return (textStoreStarRating);
          }
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

    public bool  hasImageURL()
      {
        return flagHasImageURL;
      }

    public string  getImageURL()
      {
        Debug.Assert(flagHasImageURL);
        return storeImageURL;
      }

    public bool  hasReviewCount()
      {
        return flagHasReviewCount;
      }

    public BigInteger  getReviewCount()
      {
        Debug.Assert(flagHasReviewCount);
        return storeReviewCount;
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

    public bool  hasPhotoUrl()
      {
        return flagHasPhotoUrl;
      }

    public string  getPhotoUrl()
      {
        Debug.Assert(flagHasPhotoUrl);
        return storePhotoUrl;
      }

    public bool  hasAuthor()
      {
        return flagHasAuthor;
      }

    public RecipeAuthorJSON   getAuthor()
      {
        Debug.Assert(flagHasAuthor);
        return storeAuthor;
      }

    public bool  hasNutritionInfo()
      {
        return flagHasNutritionInfo;
      }

    public RecipeNutritionInfoJSON   getNutritionInfo()
      {
        Debug.Assert(flagHasNutritionInfo);
        return storeNutritionInfo;
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

    public IngredientInfoJSON   elementOfIngredients(int element_num)
      {
        Debug.Assert(flagHasIngredients);
        return storeIngredients[element_num];
      }

    public List< IngredientInfoJSON  >  getIngredients()
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

    public string  elementOfInstructions(int element_num)
      {
        Debug.Assert(flagHasInstructions);
        return storeInstructions[element_num];
      }

    public List< string >  getInstructions()
      {
        Debug.Assert(flagHasInstructions);
        return storeInstructions;
      }

    public bool  hasAttribution()
      {
        return flagHasAttribution;
      }

    public AttributionJSON   getAttribution()
      {
        Debug.Assert(flagHasAttribution);
        return storeAttribution;
      }


    public virtual int extraDishDetailsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraDishDetailsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraDishDetailsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraDishDetailsLookup(string field_name)
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
    public void setDescription(string new_value)
      {
        flagHasDescription = true;
        storeDescription = new_value;
      }
    public void unsetDescription()
      {
        flagHasDescription = false;
      }
    public void setRecipeID(BigInteger new_value)
      {
        flagHasRecipeID = true;
        if (new_value < 0)
            throw new Exception("The value for field RecipeID of DishDetailsJSON is less than the lower bound (0) for that field.");
        storeRecipeID = new_value;
      }
    public void unsetRecipeID()
      {
        flagHasRecipeID = false;
      }
    public void setCuisineType(string new_value)
      {
        flagHasCuisineType = true;
        storeCuisineType = new_value;
      }
    public void unsetCuisineType()
      {
        flagHasCuisineType = false;
      }
    public void setTotalMinutes(BigInteger new_value)
      {
        flagHasTotalMinutes = true;
        if (new_value < 0)
            throw new Exception("The value for field TotalMinutes of DishDetailsJSON is less than the lower bound (0) for that field.");
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
            throw new Exception("The value for field ActiveMinutes of DishDetailsJSON is less than the lower bound (0) for that field.");
        storeActiveMinutes = new_value;
      }
    public void unsetActiveMinutes()
      {
        flagHasActiveMinutes = false;
      }
    public void setNumPeopletoServe(BigInteger new_value)
      {
        flagHasNumPeopletoServe = true;
        storeNumPeopletoServe = new_value;
      }
    public void unsetNumPeopletoServe()
      {
        flagHasNumPeopletoServe = false;
      }
    public void setYieldNumber(double new_value)
      {
        flagHasYieldNumber = true;
        storeYieldNumber = new_value;
        textStoreYieldNumber = "";
      }
    public void setYieldNumberText(string new_value)
      {
        flagHasYieldNumber = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field YieldNumber of DishDetailsJSON is not a valid number.");
        textStoreYieldNumber = new_value;
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
    public void setCategory(string new_value)
      {
        flagHasCategory = true;
        storeCategory = new_value;
      }
    public void unsetCategory()
      {
        flagHasCategory = false;
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
    public void setStarRating(double new_value)
      {
        flagHasStarRating = true;
        storeStarRating = new_value;
        textStoreStarRating = "";
      }
    public void setStarRatingText(string new_value)
      {
        flagHasStarRating = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field StarRating of DishDetailsJSON is not a valid number.");
        textStoreStarRating = new_value;
      }
    public void unsetStarRating()
      {
        flagHasStarRating = false;
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
    public void setImageURL(string new_value)
      {
        flagHasImageURL = true;
        storeImageURL = new_value;
      }
    public void unsetImageURL()
      {
        flagHasImageURL = false;
      }
    public void setReviewCount(BigInteger new_value)
      {
        flagHasReviewCount = true;
        if (new_value < 0)
            throw new Exception("The value for field ReviewCount of DishDetailsJSON is less than the lower bound (0) for that field.");
        storeReviewCount = new_value;
      }
    public void unsetReviewCount()
      {
        flagHasReviewCount = false;
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
    public void setPhotoUrl(string new_value)
      {
        flagHasPhotoUrl = true;
        storePhotoUrl = new_value;
      }
    public void unsetPhotoUrl()
      {
        flagHasPhotoUrl = false;
      }
    public void setAuthor(RecipeAuthorJSON  new_value)
      {
        if (flagHasAuthor)
          {
          }
        flagHasAuthor = true;
        storeAuthor = new_value;
      }
    public void unsetAuthor()
      {
        if (flagHasAuthor)
          {
          }
        flagHasAuthor = false;
      }
    public void setNutritionInfo(RecipeNutritionInfoJSON  new_value)
      {
        if (flagHasNutritionInfo)
          {
          }
        flagHasNutritionInfo = true;
        storeNutritionInfo = new_value;
      }
    public void unsetNutritionInfo()
      {
        if (flagHasNutritionInfo)
          {
          }
        flagHasNutritionInfo = false;
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
    public void appendIngredients(IngredientInfoJSON  to_append)
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
        flagHasInstructions = true;
        storeInstructions.Clear();
      }
    public void appendInstructions(string to_append)
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
        flagHasInstructions = false;
        storeInstructions.Clear();
      }
    public void setAttribution(AttributionJSON  new_value)
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = true;
        storeAttribution = new_value;
      }
    public void unsetAttribution()
      {
        if (flagHasAttribution)
          {
          }
        flagHasAttribution = false;
      }

    public virtual void extraDishDetailsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraDishDetailsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraDishDetailsLookup(key);
        if (old_field == null)
          {
            extraDishDetailsAppendPair(key, new_component);
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
        if (flagHasDescription)
          {
            handler.start_pair("Description");
            handler.string_value(storeDescription);
          }
        if (flagHasRecipeID)
          {
            handler.start_pair("RecipeID");
            handler.number_value(storeRecipeID);
          }
        if (flagHasCuisineType)
          {
            handler.start_pair("CuisineType");
            handler.string_value(storeCuisineType);
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
        if (flagHasNumPeopletoServe)
          {
            handler.start_pair("NumPeopletoServe");
            handler.number_value(storeNumPeopletoServe);
          }
        if (flagHasYieldNumber)
          {
            handler.start_pair("YieldNumber");
            if (textStoreYieldNumber != "")
                handler.number_value(textStoreYieldNumber);
            else if (((double)(long)storeYieldNumber) == storeYieldNumber)
                handler.number_value((long)storeYieldNumber);
            else
                handler.number_value(storeYieldNumber);
          }
        if (flagHasYieldUnit)
          {
            handler.start_pair("YieldUnit");
            handler.string_value(storeYieldUnit);
          }
        if (flagHasCategory)
          {
            handler.start_pair("Category");
            handler.string_value(storeCategory);
          }
        if (flagHasPrimaryIngredient)
          {
            handler.start_pair("PrimaryIngredient");
            handler.string_value(storePrimaryIngredient);
          }
        if (flagHasStarRating)
          {
            handler.start_pair("StarRating");
            if (textStoreStarRating != "")
                handler.number_value(textStoreStarRating);
            else if (((double)(long)storeStarRating) == storeStarRating)
                handler.number_value((long)storeStarRating);
            else
                handler.number_value(storeStarRating);
          }
        if (flagHasWebURL)
          {
            handler.start_pair("WebURL");
            handler.string_value(storeWebURL);
          }
        if (flagHasImageURL)
          {
            handler.start_pair("ImageURL");
            handler.string_value(storeImageURL);
          }
        if (flagHasReviewCount)
          {
            handler.start_pair("ReviewCount");
            handler.number_value(storeReviewCount);
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
        if (flagHasPhotoUrl)
          {
            handler.start_pair("PhotoUrl");
            handler.string_value(storePhotoUrl);
          }
        if (flagHasAuthor)
          {
            handler.start_pair("Author");
            if (partial_allowed)
                storeAuthor.write_partial_as_json(handler);
            else
                storeAuthor.write_as_json(handler);
          }
        if (flagHasNutritionInfo)
          {
            handler.start_pair("NutritionInfo");
            if (partial_allowed)
                storeNutritionInfo.write_partial_as_json(handler);
            else
                storeNutritionInfo.write_as_json(handler);
          }
        if (flagHasIngredients)
          {
            handler.start_pair("Ingredients");
            handler.start_array();
            for (int num1 = 0; num1 < storeIngredients.Count; ++num1)
              {
                if (partial_allowed)
                    storeIngredients[num1].write_partial_as_json(handler);
                else
                    storeIngredients[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasInstructions)
          {
            handler.start_pair("Instructions");
            handler.start_array();
            for (int num2 = 0; num2 < storeInstructions.Count; ++num2)
              {
                handler.string_value(storeInstructions[num2]);
              }
            handler.finish_array();
          }
        if (flagHasAttribution)
          {
            handler.start_pair("Attribution");
            if (partial_allowed)
                storeAttribution.write_partial_as_json(handler);
            else
                storeAttribution.write_as_json(handler);
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

    public static DishDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DishDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DishDetails", ignore_extras);
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
    public static DishDetailsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DishDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        DishDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DishDetails", ignore_extras);
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
    public static DishDetailsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static DishDetailsJSON from_text(string text, bool ignore_extras)
      {
        DishDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DishDetails", ignore_extras);
            JSONParse.parse_json_value(text, "Text for DishDetailsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static DishDetailsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        DishDetailsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type DishDetails", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorName;
        private JSONHoldingStringGenerator fieldGeneratorDescription;
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
        private JSONHoldingStringGenerator fieldGeneratorCuisineType;
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
    private class FieldHoldingGeneratorNumPeopletoServe : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorNumPeopletoServe(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorNumPeopletoServe : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorNumPeopletoServe(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorNumPeopletoServe fieldGeneratorNumPeopletoServe;
        private JSONHoldingNumberTextGenerator fieldGeneratorYieldNumber;
        private JSONHoldingStringGenerator fieldGeneratorYieldUnit;
        private JSONHoldingStringGenerator fieldGeneratorCategory;
        private JSONHoldingStringGenerator fieldGeneratorPrimaryIngredient;
        private JSONHoldingNumberTextGenerator fieldGeneratorStarRating;
        private JSONHoldingStringGenerator fieldGeneratorWebURL;
        private JSONHoldingStringGenerator fieldGeneratorImageURL;
    private class FieldHoldingGeneratorReviewCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorReviewCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorReviewCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorReviewCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorReviewCount fieldGeneratorReviewCount;
        private JSONHoldingStringGenerator fieldGeneratorCreationDate;
        private JSONHoldingStringGenerator fieldGeneratorLastModified;
        private JSONHoldingStringGenerator fieldGeneratorPhotoUrl;
        private RecipeAuthorJSON.HoldingGenerator fieldGeneratorAuthor;
        private RecipeNutritionInfoJSON.HoldingGenerator fieldGeneratorNutritionInfo;
        private IngredientInfoJSON.HoldingArrayGenerator fieldGeneratorIngredients;
        private JSONHoldingStringArrayGenerator fieldGeneratorInstructions;
        private AttributionJSON.HoldingGenerator fieldGeneratorAttribution;
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
            DishDetailsJSON result = new DishDetailsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraDishDetailsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(DishDetailsJSON result)
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
            if (fieldGeneratorDescription.have_value)
              {
                result.setDescription(fieldGeneratorDescription.value);
                fieldGeneratorDescription.have_value = false;
              }
            if (fieldGeneratorRecipeID.have_value)
              {
                result.setRecipeID(fieldGeneratorRecipeID.value);
                fieldGeneratorRecipeID.have_value = false;
              }
            if (fieldGeneratorCuisineType.have_value)
              {
                result.setCuisineType(fieldGeneratorCuisineType.value);
                fieldGeneratorCuisineType.have_value = false;
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
            if (fieldGeneratorNumPeopletoServe.have_value)
              {
                result.setNumPeopletoServe(fieldGeneratorNumPeopletoServe.value);
                fieldGeneratorNumPeopletoServe.have_value = false;
              }
            if (fieldGeneratorYieldNumber.have_value)
              {
                result.setYieldNumberText(fieldGeneratorYieldNumber.value);
                fieldGeneratorYieldNumber.have_value = false;
              }
            if (fieldGeneratorYieldUnit.have_value)
              {
                result.setYieldUnit(fieldGeneratorYieldUnit.value);
                fieldGeneratorYieldUnit.have_value = false;
              }
            if (fieldGeneratorCategory.have_value)
              {
                result.setCategory(fieldGeneratorCategory.value);
                fieldGeneratorCategory.have_value = false;
              }
            if (fieldGeneratorPrimaryIngredient.have_value)
              {
                result.setPrimaryIngredient(fieldGeneratorPrimaryIngredient.value);
                fieldGeneratorPrimaryIngredient.have_value = false;
              }
            if (fieldGeneratorStarRating.have_value)
              {
                result.setStarRatingText(fieldGeneratorStarRating.value);
                fieldGeneratorStarRating.have_value = false;
              }
            if (fieldGeneratorWebURL.have_value)
              {
                result.setWebURL(fieldGeneratorWebURL.value);
                fieldGeneratorWebURL.have_value = false;
              }
            if (fieldGeneratorImageURL.have_value)
              {
                result.setImageURL(fieldGeneratorImageURL.value);
                fieldGeneratorImageURL.have_value = false;
              }
            if (fieldGeneratorReviewCount.have_value)
              {
                result.setReviewCount(fieldGeneratorReviewCount.value);
                fieldGeneratorReviewCount.have_value = false;
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
            if (fieldGeneratorPhotoUrl.have_value)
              {
                result.setPhotoUrl(fieldGeneratorPhotoUrl.value);
                fieldGeneratorPhotoUrl.have_value = false;
              }
            if (fieldGeneratorAuthor.have_value)
              {
                result.setAuthor(fieldGeneratorAuthor.value);
                fieldGeneratorAuthor.have_value = false;
              }
            if (fieldGeneratorNutritionInfo.have_value)
              {
                result.setNutritionInfo(fieldGeneratorNutritionInfo.value);
                fieldGeneratorNutritionInfo.have_value = false;
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
            if (fieldGeneratorAttribution.have_value)
              {
                result.setAttribution(fieldGeneratorAttribution.value);
                fieldGeneratorAttribution.have_value = false;
              }
          }
        protected abstract void handle_result(DishDetailsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'c':
                            if ((String.Compare(field_name, 2, "tiveMinutes", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorActiveMinutes;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "tribution", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorAttribution;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "thor", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorAuthor;
                            break;
                        default:
                            break;
                      }
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
                            if ((String.Compare(field_name, 2, "isineType", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorCuisineType;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "escription", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDescription;
                    break;
                case 'I':
                    switch (field_name[1])
                      {
                        case 'm':
                            if ((String.Compare(field_name, 2, "ageURL", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorImageURL;
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
                case 'N':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "me", 0, 2, false) == 0) && (field_name.Length == 4))
                                return fieldGeneratorName;
                            break;
                        case 'u':
                            switch (field_name[2])
                              {
                                case 'm':
                                    if ((String.Compare(field_name, 3, "PeopletoServe", 0, 13, false) == 0) && (field_name.Length == 16))
                                        return fieldGeneratorNumPeopletoServe;
                                    break;
                                case 't':
                                    if ((String.Compare(field_name, 3, "ritionInfo", 0, 10, false) == 0) && (field_name.Length == 13))
                                        return fieldGeneratorNutritionInfo;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "otoUrl", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorPhotoUrl;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "imaryIngredient", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorPrimaryIngredient;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'c':
                                if ((String.Compare(field_name, 3, "ipeID", 0, 5, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorRecipeID;
                                break;
                            case 'v':
                                if ((String.Compare(field_name, 3, "iewCount", 0, 8, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorReviewCount;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tarRating", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorStarRating;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "otalMinutes", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorTotalMinutes;
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
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the DishDetails class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the DishDetails class");
            fieldGeneratorRecipeID = new FieldHoldingGeneratorRecipeID("field \"RecipeID\" of the DishDetails class");
            fieldGeneratorCuisineType = new JSONHoldingStringGenerator("field \"CuisineType\" of the DishDetails class");
            fieldGeneratorTotalMinutes = new FieldHoldingGeneratorTotalMinutes("field \"TotalMinutes\" of the DishDetails class");
            fieldGeneratorActiveMinutes = new FieldHoldingGeneratorActiveMinutes("field \"ActiveMinutes\" of the DishDetails class");
            fieldGeneratorNumPeopletoServe = new FieldHoldingGeneratorNumPeopletoServe("field \"NumPeopletoServe\" of the DishDetails class");
            fieldGeneratorYieldNumber = new JSONHoldingNumberTextGenerator("field \"YieldNumber\" of the DishDetails class");
            fieldGeneratorYieldUnit = new JSONHoldingStringGenerator("field \"YieldUnit\" of the DishDetails class");
            fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the DishDetails class");
            fieldGeneratorPrimaryIngredient = new JSONHoldingStringGenerator("field \"PrimaryIngredient\" of the DishDetails class");
            fieldGeneratorStarRating = new JSONHoldingNumberTextGenerator("field \"StarRating\" of the DishDetails class");
            fieldGeneratorWebURL = new JSONHoldingStringGenerator("field \"WebURL\" of the DishDetails class");
            fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the DishDetails class");
            fieldGeneratorReviewCount = new FieldHoldingGeneratorReviewCount("field \"ReviewCount\" of the DishDetails class");
            fieldGeneratorCreationDate = new JSONHoldingStringGenerator("field \"CreationDate\" of the DishDetails class");
            fieldGeneratorLastModified = new JSONHoldingStringGenerator("field \"LastModified\" of the DishDetails class");
            fieldGeneratorPhotoUrl = new JSONHoldingStringGenerator("field \"PhotoUrl\" of the DishDetails class");
            fieldGeneratorAuthor = new RecipeAuthorJSON.HoldingGenerator("field \"Author\" of the DishDetails class", ignore_extras);
            fieldGeneratorNutritionInfo = new RecipeNutritionInfoJSON.HoldingGenerator("field \"NutritionInfo\" of the DishDetails class", ignore_extras);
            fieldGeneratorIngredients = new IngredientInfoJSON.HoldingArrayGenerator("field \"Ingredients\" of the DishDetails class", ignore_extras);
            fieldGeneratorInstructions = new JSONHoldingStringArrayGenerator("field \"Instructions\" of the DishDetails class");
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the DishDetails class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the DishDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorName = new JSONHoldingStringGenerator("field \"Name\" of the DishDetails class");
            fieldGeneratorDescription = new JSONHoldingStringGenerator("field \"Description\" of the DishDetails class");
            fieldGeneratorRecipeID = new FieldHoldingGeneratorRecipeID("field \"RecipeID\" of the DishDetails class");
            fieldGeneratorCuisineType = new JSONHoldingStringGenerator("field \"CuisineType\" of the DishDetails class");
            fieldGeneratorTotalMinutes = new FieldHoldingGeneratorTotalMinutes("field \"TotalMinutes\" of the DishDetails class");
            fieldGeneratorActiveMinutes = new FieldHoldingGeneratorActiveMinutes("field \"ActiveMinutes\" of the DishDetails class");
            fieldGeneratorNumPeopletoServe = new FieldHoldingGeneratorNumPeopletoServe("field \"NumPeopletoServe\" of the DishDetails class");
            fieldGeneratorYieldNumber = new JSONHoldingNumberTextGenerator("field \"YieldNumber\" of the DishDetails class");
            fieldGeneratorYieldUnit = new JSONHoldingStringGenerator("field \"YieldUnit\" of the DishDetails class");
            fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the DishDetails class");
            fieldGeneratorPrimaryIngredient = new JSONHoldingStringGenerator("field \"PrimaryIngredient\" of the DishDetails class");
            fieldGeneratorStarRating = new JSONHoldingNumberTextGenerator("field \"StarRating\" of the DishDetails class");
            fieldGeneratorWebURL = new JSONHoldingStringGenerator("field \"WebURL\" of the DishDetails class");
            fieldGeneratorImageURL = new JSONHoldingStringGenerator("field \"ImageURL\" of the DishDetails class");
            fieldGeneratorReviewCount = new FieldHoldingGeneratorReviewCount("field \"ReviewCount\" of the DishDetails class");
            fieldGeneratorCreationDate = new JSONHoldingStringGenerator("field \"CreationDate\" of the DishDetails class");
            fieldGeneratorLastModified = new JSONHoldingStringGenerator("field \"LastModified\" of the DishDetails class");
            fieldGeneratorPhotoUrl = new JSONHoldingStringGenerator("field \"PhotoUrl\" of the DishDetails class");
            fieldGeneratorAuthor = new RecipeAuthorJSON.HoldingGenerator("field \"Author\" of the DishDetails class", false);
            fieldGeneratorNutritionInfo = new RecipeNutritionInfoJSON.HoldingGenerator("field \"NutritionInfo\" of the DishDetails class", false);
            fieldGeneratorIngredients = new IngredientInfoJSON.HoldingArrayGenerator("field \"Ingredients\" of the DishDetails class", false);
            fieldGeneratorInstructions = new JSONHoldingStringArrayGenerator("field \"Instructions\" of the DishDetails class");
            fieldGeneratorAttribution = new AttributionJSON.HoldingGenerator("field \"Attribution\" of the DishDetails class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the DishDetails class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorName.reset();
            fieldGeneratorDescription.reset();
            fieldGeneratorRecipeID.reset();
            fieldGeneratorCuisineType.reset();
            fieldGeneratorTotalMinutes.reset();
            fieldGeneratorActiveMinutes.reset();
            fieldGeneratorNumPeopletoServe.reset();
            fieldGeneratorYieldNumber.reset();
            fieldGeneratorYieldUnit.reset();
            fieldGeneratorCategory.reset();
            fieldGeneratorPrimaryIngredient.reset();
            fieldGeneratorStarRating.reset();
            fieldGeneratorWebURL.reset();
            fieldGeneratorImageURL.reset();
            fieldGeneratorReviewCount.reset();
            fieldGeneratorCreationDate.reset();
            fieldGeneratorLastModified.reset();
            fieldGeneratorPhotoUrl.reset();
            fieldGeneratorAuthor.reset();
            fieldGeneratorNutritionInfo.reset();
            fieldGeneratorIngredients.reset();
            fieldGeneratorInstructions.reset();
            fieldGeneratorAttribution.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAuthor.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorNutritionInfo.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIngredients.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAttribution.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAuthor.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorNutritionInfo.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIngredients.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAttribution.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(DishDetailsJSON  result)
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
        public DishDetailsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(DishDetailsJSON  result)
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
    protected virtual void handle_result(List<DishDetailsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<DishDetailsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<DishDetailsJSON>();
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
    public List<DishDetailsJSON> value;
  };
  };
