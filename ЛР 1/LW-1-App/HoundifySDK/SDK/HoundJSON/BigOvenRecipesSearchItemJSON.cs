/* file "BigOvenRecipesSearchItemJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class BigOvenRecipesSearchItemJSON : JSONBase
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
    private bool flagHasMicrocategory;
    private string storeMicrocategory;
    private bool flagHasStarRating;
    private double storeStarRating;
    private string textStoreStarRating;
    private bool flagHasWebURL;
    private string storeWebURL;
    private bool flagHasReviewCount;
    private BigInteger storeReviewCount;
    private bool flagHasPoster;
    private BigOvenRecipesPosterJSON  storePoster;
    private bool flagHasIsPrivate;
    private bool storeIsPrivate;
    private bool flagHasServings;
    private double storeServings;
    private string textStoreServings;
    private bool flagHasCreationDate;
    private string storeCreationDate;
    private bool flagHasIsRecipeScan;
    private bool storeIsRecipeScan;
    private bool flagHasIsBookmark;
    private bool storeIsBookmark;
    private bool flagHasTotalTries;
    private BigInteger storeTotalTries;
    private bool flagHasPhotoUrl;
    private string storePhotoUrl;
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
                throw new Exception("The value for field RecipeID of BigOvenRecipesSearchItemJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RecipeID of BigOvenRecipesSearchItemJSON is not an integer.");
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
            throw new Exception("The value for field Title of BigOvenRecipesSearchItemJSON is not a string.");
        setTitle(json_string.getData());
      }


    private void  fromJSONCuisine(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Cuisine of BigOvenRecipesSearchItemJSON is not a string.");
        setCuisine(json_string.getData());
      }


    private void  fromJSONCategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Category of BigOvenRecipesSearchItemJSON is not a string.");
        setCategory(json_string.getData());
      }


    private void  fromJSONSubcategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Subcategory of BigOvenRecipesSearchItemJSON is not a string.");
        setSubcategory(json_string.getData());
      }


    private void  fromJSONMicrocategory(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Microcategory of BigOvenRecipesSearchItemJSON is not a string.");
        setMicrocategory(json_string.getData());
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
                throw new Exception("The value for field StarRating of BigOvenRecipesSearchItemJSON is not a number.");
              }
          }
        setStarRatingText(the_rational_text);
      }


    private void  fromJSONWebURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WebURL of BigOvenRecipesSearchItemJSON is not a string.");
        setWebURL(json_string.getData());
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
                throw new Exception("The value for field ReviewCount of BigOvenRecipesSearchItemJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ReviewCount of BigOvenRecipesSearchItemJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setReviewCount(extracted_integer);
      }


    private void  fromJSONPoster(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigOvenRecipesPosterJSON convert_classy = BigOvenRecipesPosterJSON.from_json(json_value, ignore_extras, true);
        setPoster(convert_classy);
      }


    private void  fromJSONIsPrivate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsPrivate of BigOvenRecipesSearchItemJSON is not true for false.");
              }
          }
        setIsPrivate(the_bool);
      }


    private void  fromJSONServings(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Servings of BigOvenRecipesSearchItemJSON is not a number.");
              }
          }
        setServingsText(the_rational_text);
      }


    private void  fromJSONCreationDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CreationDate of BigOvenRecipesSearchItemJSON is not a string.");
        setCreationDate(json_string.getData());
      }


    private void  fromJSONIsRecipeScan(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsRecipeScan of BigOvenRecipesSearchItemJSON is not true for false.");
              }
          }
        setIsRecipeScan(the_bool);
      }


    private void  fromJSONIsBookmark(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsBookmark of BigOvenRecipesSearchItemJSON is not true for false.");
              }
          }
        setIsBookmark(the_bool);
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
                throw new Exception("The value for field TotalTries of BigOvenRecipesSearchItemJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TotalTries of BigOvenRecipesSearchItemJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTotalTries(extracted_integer);
      }


    private void  fromJSONPhotoUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PhotoUrl of BigOvenRecipesSearchItemJSON is not a string.");
        setPhotoUrl(json_string.getData());
      }


    public BigOvenRecipesSearchItemJSON()
      {
        flagHasRecipeID = false;
        flagHasTitle = false;
        flagHasCuisine = false;
        flagHasCategory = false;
        flagHasSubcategory = false;
        flagHasMicrocategory = false;
        flagHasStarRating = false;
        flagHasWebURL = false;
        flagHasReviewCount = false;
        flagHasPoster = false;
        flagHasIsPrivate = false;
        flagHasServings = false;
        flagHasCreationDate = false;
        flagHasIsRecipeScan = false;
        flagHasIsBookmark = false;
        flagHasTotalTries = false;
        flagHasPhotoUrl = false;
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

    public bool  hasMicrocategory()
      {
        return flagHasMicrocategory;
      }

    public string  getMicrocategory()
      {
        Debug.Assert(flagHasMicrocategory);
        return storeMicrocategory;
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

    public bool  hasReviewCount()
      {
        return flagHasReviewCount;
      }

    public BigInteger  getReviewCount()
      {
        Debug.Assert(flagHasReviewCount);
        return storeReviewCount;
      }

    public bool  hasPoster()
      {
        return flagHasPoster;
      }

    public BigOvenRecipesPosterJSON   getPoster()
      {
        Debug.Assert(flagHasPoster);
        return storePoster;
      }

    public bool  hasIsPrivate()
      {
        return flagHasIsPrivate;
      }

    public bool  getIsPrivate()
      {
        Debug.Assert(flagHasIsPrivate);
        return storeIsPrivate;
      }

    public bool  hasServings()
      {
        return flagHasServings;
      }

    public double  getServings()
      {
        Debug.Assert(flagHasServings);
        if (textStoreServings != "")
          {
            return Double.Parse(textStoreServings);
          }
        return storeServings;
      }

    public string  getServingsAsText()
      {
        Debug.Assert(flagHasServings);
        if (textStoreServings == "")
          {
            return Convert.ToString(storeServings);
          }
        else
          {
            return (textStoreServings);
          }
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

    public bool  hasIsRecipeScan()
      {
        return flagHasIsRecipeScan;
      }

    public bool  getIsRecipeScan()
      {
        Debug.Assert(flagHasIsRecipeScan);
        return storeIsRecipeScan;
      }

    public bool  hasIsBookmark()
      {
        return flagHasIsBookmark;
      }

    public bool  getIsBookmark()
      {
        Debug.Assert(flagHasIsBookmark);
        return storeIsBookmark;
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

    public bool  hasPhotoUrl()
      {
        return flagHasPhotoUrl;
      }

    public string  getPhotoUrl()
      {
        Debug.Assert(flagHasPhotoUrl);
        return storePhotoUrl;
      }


    public virtual int extraBigOvenRecipesSearchItemComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraBigOvenRecipesSearchItemComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraBigOvenRecipesSearchItemComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraBigOvenRecipesSearchItemLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setRecipeID(BigInteger new_value)
      {
        flagHasRecipeID = true;
        if (new_value < 0)
            throw new Exception("The value for field RecipeID of BigOvenRecipesSearchItemJSON is less than the lower bound (0) for that field.");
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
    public void setMicrocategory(string new_value)
      {
        flagHasMicrocategory = true;
        storeMicrocategory = new_value;
      }
    public void unsetMicrocategory()
      {
        flagHasMicrocategory = false;
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
            throw new Exception("The text value for field StarRating of BigOvenRecipesSearchItemJSON is not a valid number.");
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
    public void setReviewCount(BigInteger new_value)
      {
        flagHasReviewCount = true;
        if (new_value < 0)
            throw new Exception("The value for field ReviewCount of BigOvenRecipesSearchItemJSON is less than the lower bound (0) for that field.");
        storeReviewCount = new_value;
      }
    public void unsetReviewCount()
      {
        flagHasReviewCount = false;
      }
    public void setPoster(BigOvenRecipesPosterJSON  new_value)
      {
        if (flagHasPoster)
          {
          }
        flagHasPoster = true;
        storePoster = new_value;
      }
    public void unsetPoster()
      {
        if (flagHasPoster)
          {
          }
        flagHasPoster = false;
      }
    public void setIsPrivate(bool new_value)
      {
        flagHasIsPrivate = true;
        storeIsPrivate = new_value;
      }
    public void unsetIsPrivate()
      {
        flagHasIsPrivate = false;
      }
    public void setServings(double new_value)
      {
        flagHasServings = true;
        storeServings = new_value;
        textStoreServings = "";
      }
    public void setServingsText(string new_value)
      {
        flagHasServings = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Servings of BigOvenRecipesSearchItemJSON is not a valid number.");
        textStoreServings = new_value;
      }
    public void unsetServings()
      {
        flagHasServings = false;
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
    public void setIsRecipeScan(bool new_value)
      {
        flagHasIsRecipeScan = true;
        storeIsRecipeScan = new_value;
      }
    public void unsetIsRecipeScan()
      {
        flagHasIsRecipeScan = false;
      }
    public void setIsBookmark(bool new_value)
      {
        flagHasIsBookmark = true;
        storeIsBookmark = new_value;
      }
    public void unsetIsBookmark()
      {
        flagHasIsBookmark = false;
      }
    public void setTotalTries(BigInteger new_value)
      {
        flagHasTotalTries = true;
        if (new_value < 0)
            throw new Exception("The value for field TotalTries of BigOvenRecipesSearchItemJSON is less than the lower bound (0) for that field.");
        storeTotalTries = new_value;
      }
    public void unsetTotalTries()
      {
        flagHasTotalTries = false;
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

    public virtual void extraBigOvenRecipesSearchItemAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraBigOvenRecipesSearchItemSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraBigOvenRecipesSearchItemLookup(key);
        if (old_field == null)
          {
            extraBigOvenRecipesSearchItemAppendPair(key, new_component);
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
        if (flagHasRecipeID)
          {
            handler.start_pair("RecipeID");
            handler.number_value(storeRecipeID);
          }
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
        if (flagHasMicrocategory)
          {
            handler.start_pair("Microcategory");
            handler.string_value(storeMicrocategory);
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
        if (flagHasReviewCount)
          {
            handler.start_pair("ReviewCount");
            handler.number_value(storeReviewCount);
          }
        if (flagHasPoster)
          {
            handler.start_pair("Poster");
            if (partial_allowed)
                storePoster.write_partial_as_json(handler);
            else
                storePoster.write_as_json(handler);
          }
        if (flagHasIsPrivate)
          {
            handler.start_pair("IsPrivate");
            handler.boolean_value(storeIsPrivate);
          }
        if (flagHasServings)
          {
            handler.start_pair("Servings");
            if (textStoreServings != "")
                handler.number_value(textStoreServings);
            else if (((double)(long)storeServings) == storeServings)
                handler.number_value((long)storeServings);
            else
                handler.number_value(storeServings);
          }
        if (flagHasCreationDate)
          {
            handler.start_pair("CreationDate");
            handler.string_value(storeCreationDate);
          }
        if (flagHasIsRecipeScan)
          {
            handler.start_pair("IsRecipeScan");
            handler.boolean_value(storeIsRecipeScan);
          }
        if (flagHasIsBookmark)
          {
            handler.start_pair("IsBookmark");
            handler.boolean_value(storeIsBookmark);
          }
        if (flagHasTotalTries)
          {
            handler.start_pair("TotalTries");
            handler.number_value(storeTotalTries);
          }
        if (flagHasPhotoUrl)
          {
            handler.start_pair("PhotoUrl");
            handler.string_value(storePhotoUrl);
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

    public static BigOvenRecipesSearchItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BigOvenRecipesSearchItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesSearchItem", ignore_extras);
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
    public static BigOvenRecipesSearchItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BigOvenRecipesSearchItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        BigOvenRecipesSearchItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesSearchItem", ignore_extras);
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
    public static BigOvenRecipesSearchItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static BigOvenRecipesSearchItemJSON from_text(string text, bool ignore_extras)
      {
        BigOvenRecipesSearchItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesSearchItem", ignore_extras);
            JSONParse.parse_json_value(text, "Text for BigOvenRecipesSearchItemJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static BigOvenRecipesSearchItemJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        BigOvenRecipesSearchItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type BigOvenRecipesSearchItem", ignore_extras);
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
        private JSONHoldingStringGenerator fieldGeneratorMicrocategory;
        private JSONHoldingNumberTextGenerator fieldGeneratorStarRating;
        private JSONHoldingStringGenerator fieldGeneratorWebURL;
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
        private BigOvenRecipesPosterJSON.HoldingGenerator fieldGeneratorPoster;
        private JSONHoldingBooleanGenerator fieldGeneratorIsPrivate;
        private JSONHoldingNumberTextGenerator fieldGeneratorServings;
        private JSONHoldingStringGenerator fieldGeneratorCreationDate;
        private JSONHoldingBooleanGenerator fieldGeneratorIsRecipeScan;
        private JSONHoldingBooleanGenerator fieldGeneratorIsBookmark;
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
        private JSONHoldingStringGenerator fieldGeneratorPhotoUrl;
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
            BigOvenRecipesSearchItemJSON result = new BigOvenRecipesSearchItemJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraBigOvenRecipesSearchItemAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(BigOvenRecipesSearchItemJSON result)
          {
            if (fieldGeneratorRecipeID.have_value)
              {
                result.setRecipeID(fieldGeneratorRecipeID.value);
                fieldGeneratorRecipeID.have_value = false;
              }
            if (fieldGeneratorTitle.have_value)
              {
                result.setTitle(fieldGeneratorTitle.value);
                fieldGeneratorTitle.have_value = false;
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
            if (fieldGeneratorMicrocategory.have_value)
              {
                result.setMicrocategory(fieldGeneratorMicrocategory.value);
                fieldGeneratorMicrocategory.have_value = false;
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
            if (fieldGeneratorReviewCount.have_value)
              {
                result.setReviewCount(fieldGeneratorReviewCount.value);
                fieldGeneratorReviewCount.have_value = false;
              }
            if (fieldGeneratorPoster.have_value)
              {
                result.setPoster(fieldGeneratorPoster.value);
                fieldGeneratorPoster.have_value = false;
              }
            if (fieldGeneratorIsPrivate.have_value)
              {
                result.setIsPrivate(fieldGeneratorIsPrivate.value);
                fieldGeneratorIsPrivate.have_value = false;
              }
            if (fieldGeneratorServings.have_value)
              {
                result.setServingsText(fieldGeneratorServings.value);
                fieldGeneratorServings.have_value = false;
              }
            if (fieldGeneratorCreationDate.have_value)
              {
                result.setCreationDate(fieldGeneratorCreationDate.value);
                fieldGeneratorCreationDate.have_value = false;
              }
            if (fieldGeneratorIsRecipeScan.have_value)
              {
                result.setIsRecipeScan(fieldGeneratorIsRecipeScan.value);
                fieldGeneratorIsRecipeScan.have_value = false;
              }
            if (fieldGeneratorIsBookmark.have_value)
              {
                result.setIsBookmark(fieldGeneratorIsBookmark.value);
                fieldGeneratorIsBookmark.have_value = false;
              }
            if (fieldGeneratorTotalTries.have_value)
              {
                result.setTotalTries(fieldGeneratorTotalTries.value);
                fieldGeneratorTotalTries.have_value = false;
              }
            if (fieldGeneratorPhotoUrl.have_value)
              {
                result.setPhotoUrl(fieldGeneratorPhotoUrl.value);
                fieldGeneratorPhotoUrl.have_value = false;
              }
          }
        protected abstract void handle_result(BigOvenRecipesSearchItemJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
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
                case 'I':
                    if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'B':
                                if ((String.Compare(field_name, 3, "ookmark", 0, 7, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorIsBookmark;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 3, "rivate", 0, 6, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorIsPrivate;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 3, "ecipeScan", 0, 9, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorIsRecipeScan;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "icrocategory", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorMicrocategory;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'h':
                            if ((String.Compare(field_name, 2, "otoUrl", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorPhotoUrl;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ster", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorPoster;
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
                    switch (field_name[1])
                      {
                        case 'e':
                            if ((String.Compare(field_name, 2, "rvings", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorServings;
                            break;
                        case 't':
                            if ((String.Compare(field_name, 2, "arRating", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorStarRating;
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "bcategory", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorSubcategory;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "tle", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorTitle;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "talTries", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorTotalTries;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "ebURL", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorWebURL;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorRecipeID = new FieldHoldingGeneratorRecipeID("field \"RecipeID\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorCuisine = new JSONHoldingStringGenerator("field \"Cuisine\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorSubcategory = new JSONHoldingStringGenerator("field \"Subcategory\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorMicrocategory = new JSONHoldingStringGenerator("field \"Microcategory\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorStarRating = new JSONHoldingNumberTextGenerator("field \"StarRating\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorWebURL = new JSONHoldingStringGenerator("field \"WebURL\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorReviewCount = new FieldHoldingGeneratorReviewCount("field \"ReviewCount\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorPoster = new BigOvenRecipesPosterJSON.HoldingGenerator("field \"Poster\" of the BigOvenRecipesSearchItem class", ignore_extras);
            fieldGeneratorIsPrivate = new JSONHoldingBooleanGenerator("field \"IsPrivate\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorServings = new JSONHoldingNumberTextGenerator("field \"Servings\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorCreationDate = new JSONHoldingStringGenerator("field \"CreationDate\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorIsRecipeScan = new JSONHoldingBooleanGenerator("field \"IsRecipeScan\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorIsBookmark = new JSONHoldingBooleanGenerator("field \"IsBookmark\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorTotalTries = new FieldHoldingGeneratorTotalTries("field \"TotalTries\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorPhotoUrl = new JSONHoldingStringGenerator("field \"PhotoUrl\" of the BigOvenRecipesSearchItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the BigOvenRecipesSearchItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRecipeID = new FieldHoldingGeneratorRecipeID("field \"RecipeID\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorTitle = new JSONHoldingStringGenerator("field \"Title\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorCuisine = new JSONHoldingStringGenerator("field \"Cuisine\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorCategory = new JSONHoldingStringGenerator("field \"Category\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorSubcategory = new JSONHoldingStringGenerator("field \"Subcategory\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorMicrocategory = new JSONHoldingStringGenerator("field \"Microcategory\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorStarRating = new JSONHoldingNumberTextGenerator("field \"StarRating\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorWebURL = new JSONHoldingStringGenerator("field \"WebURL\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorReviewCount = new FieldHoldingGeneratorReviewCount("field \"ReviewCount\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorPoster = new BigOvenRecipesPosterJSON.HoldingGenerator("field \"Poster\" of the BigOvenRecipesSearchItem class", false);
            fieldGeneratorIsPrivate = new JSONHoldingBooleanGenerator("field \"IsPrivate\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorServings = new JSONHoldingNumberTextGenerator("field \"Servings\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorCreationDate = new JSONHoldingStringGenerator("field \"CreationDate\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorIsRecipeScan = new JSONHoldingBooleanGenerator("field \"IsRecipeScan\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorIsBookmark = new JSONHoldingBooleanGenerator("field \"IsBookmark\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorTotalTries = new FieldHoldingGeneratorTotalTries("field \"TotalTries\" of the BigOvenRecipesSearchItem class");
            fieldGeneratorPhotoUrl = new JSONHoldingStringGenerator("field \"PhotoUrl\" of the BigOvenRecipesSearchItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the BigOvenRecipesSearchItem class");
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
            fieldGeneratorMicrocategory.reset();
            fieldGeneratorStarRating.reset();
            fieldGeneratorWebURL.reset();
            fieldGeneratorReviewCount.reset();
            fieldGeneratorPoster.reset();
            fieldGeneratorIsPrivate.reset();
            fieldGeneratorServings.reset();
            fieldGeneratorCreationDate.reset();
            fieldGeneratorIsRecipeScan.reset();
            fieldGeneratorIsBookmark.reset();
            fieldGeneratorTotalTries.reset();
            fieldGeneratorPhotoUrl.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorPoster.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorPoster.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(BigOvenRecipesSearchItemJSON  result)
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
        public BigOvenRecipesSearchItemJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(BigOvenRecipesSearchItemJSON  result)
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
    protected virtual void handle_result(List<BigOvenRecipesSearchItemJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<BigOvenRecipesSearchItemJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<BigOvenRecipesSearchItemJSON>();
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
    public List<BigOvenRecipesSearchItemJSON> value;
  };
  };
