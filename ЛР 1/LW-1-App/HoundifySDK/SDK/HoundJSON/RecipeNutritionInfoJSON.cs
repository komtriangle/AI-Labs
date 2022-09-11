/* file "RecipeNutritionInfoJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RecipeNutritionInfoJSON : JSONBase
  {
    private bool flagHasSingularYieldUnit;
    private string storeSingularYieldUnit;
    private bool flagHasTotalCalories;
    private BigInteger storeTotalCalories;
    private bool flagHasTotalFat;
    private double storeTotalFat;
    private string textStoreTotalFat;
    private bool flagHasCaloriesFromFat;
    private BigInteger storeCaloriesFromFat;
    private bool flagHasTotalFatPct;
    private double storeTotalFatPct;
    private string textStoreTotalFatPct;
    private bool flagHasSatFat;
    private double storeSatFat;
    private string textStoreSatFat;
    private bool flagHasSatFatPct;
    private double storeSatFatPct;
    private string textStoreSatFatPct;
    private bool flagHasMonoFat;
    private double storeMonoFat;
    private string textStoreMonoFat;
    private bool flagHasPolyFat;
    private double storePolyFat;
    private string textStorePolyFat;
    private bool flagHasTransFat;
    private double storeTransFat;
    private string textStoreTransFat;
    private bool flagHasCholesterol;
    private double storeCholesterol;
    private string textStoreCholesterol;
    private bool flagHasCholesterolPct;
    private double storeCholesterolPct;
    private string textStoreCholesterolPct;
    private bool flagHasSodium;
    private double storeSodium;
    private string textStoreSodium;
    private bool flagHasSodiumPct;
    private double storeSodiumPct;
    private string textStoreSodiumPct;
    private bool flagHasPotassium;
    private double storePotassium;
    private string textStorePotassium;
    private bool flagHasPotassiumPct;
    private double storePotassiumPct;
    private string textStorePotassiumPct;
    private bool flagHasTotalCarbs;
    private double storeTotalCarbs;
    private string textStoreTotalCarbs;
    private bool flagHasTotalCarbsPct;
    private double storeTotalCarbsPct;
    private string textStoreTotalCarbsPct;
    private bool flagHasDietaryFiber;
    private double storeDietaryFiber;
    private string textStoreDietaryFiber;
    private bool flagHasDietaryFiberPct;
    private double storeDietaryFiberPct;
    private string textStoreDietaryFiberPct;
    private bool flagHasSugar;
    private double storeSugar;
    private string textStoreSugar;
    private bool flagHasProtein;
    private double storeProtein;
    private string textStoreProtein;
    private bool flagHasProteinPct;
    private double storeProteinPct;
    private string textStoreProteinPct;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSingularYieldUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SingularYieldUnit of RecipeNutritionInfoJSON is not a string.");
        setSingularYieldUnit(json_string.getData());
      }


    private void  fromJSONTotalCalories(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TotalCalories of RecipeNutritionInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TotalCalories of RecipeNutritionInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTotalCalories(extracted_integer);
      }


    private void  fromJSONTotalFat(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TotalFat of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setTotalFatText(the_rational_text);
      }


    private void  fromJSONCaloriesFromFat(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field CaloriesFromFat of RecipeNutritionInfoJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field CaloriesFromFat of RecipeNutritionInfoJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setCaloriesFromFat(extracted_integer);
      }


    private void  fromJSONTotalFatPct(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TotalFatPct of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setTotalFatPctText(the_rational_text);
      }


    private void  fromJSONSatFat(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SatFat of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setSatFatText(the_rational_text);
      }


    private void  fromJSONSatFatPct(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SatFatPct of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setSatFatPctText(the_rational_text);
      }


    private void  fromJSONMonoFat(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MonoFat of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setMonoFatText(the_rational_text);
      }


    private void  fromJSONPolyFat(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PolyFat of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setPolyFatText(the_rational_text);
      }


    private void  fromJSONTransFat(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TransFat of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setTransFatText(the_rational_text);
      }


    private void  fromJSONCholesterol(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Cholesterol of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setCholesterolText(the_rational_text);
      }


    private void  fromJSONCholesterolPct(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CholesterolPct of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setCholesterolPctText(the_rational_text);
      }


    private void  fromJSONSodium(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Sodium of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setSodiumText(the_rational_text);
      }


    private void  fromJSONSodiumPct(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field SodiumPct of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setSodiumPctText(the_rational_text);
      }


    private void  fromJSONPotassium(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Potassium of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setPotassiumText(the_rational_text);
      }


    private void  fromJSONPotassiumPct(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field PotassiumPct of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setPotassiumPctText(the_rational_text);
      }


    private void  fromJSONTotalCarbs(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TotalCarbs of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setTotalCarbsText(the_rational_text);
      }


    private void  fromJSONTotalCarbsPct(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field TotalCarbsPct of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setTotalCarbsPctText(the_rational_text);
      }


    private void  fromJSONDietaryFiber(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DietaryFiber of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setDietaryFiberText(the_rational_text);
      }


    private void  fromJSONDietaryFiberPct(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DietaryFiberPct of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setDietaryFiberPctText(the_rational_text);
      }


    private void  fromJSONSugar(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Sugar of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setSugarText(the_rational_text);
      }


    private void  fromJSONProtein(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Protein of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setProteinText(the_rational_text);
      }


    private void  fromJSONProteinPct(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ProteinPct of RecipeNutritionInfoJSON is not a number.");
              }
          }
        setProteinPctText(the_rational_text);
      }


    public RecipeNutritionInfoJSON()
      {
        flagHasSingularYieldUnit = false;
        flagHasTotalCalories = false;
        flagHasTotalFat = false;
        flagHasCaloriesFromFat = false;
        flagHasTotalFatPct = false;
        flagHasSatFat = false;
        flagHasSatFatPct = false;
        flagHasMonoFat = false;
        flagHasPolyFat = false;
        flagHasTransFat = false;
        flagHasCholesterol = false;
        flagHasCholesterolPct = false;
        flagHasSodium = false;
        flagHasSodiumPct = false;
        flagHasPotassium = false;
        flagHasPotassiumPct = false;
        flagHasTotalCarbs = false;
        flagHasTotalCarbsPct = false;
        flagHasDietaryFiber = false;
        flagHasDietaryFiberPct = false;
        flagHasSugar = false;
        flagHasProtein = false;
        flagHasProteinPct = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSingularYieldUnit()
      {
        return flagHasSingularYieldUnit;
      }

    public string  getSingularYieldUnit()
      {
        Debug.Assert(flagHasSingularYieldUnit);
        return storeSingularYieldUnit;
      }

    public bool  hasTotalCalories()
      {
        return flagHasTotalCalories;
      }

    public BigInteger  getTotalCalories()
      {
        Debug.Assert(flagHasTotalCalories);
        return storeTotalCalories;
      }

    public bool  hasTotalFat()
      {
        return flagHasTotalFat;
      }

    public double  getTotalFat()
      {
        Debug.Assert(flagHasTotalFat);
        if (textStoreTotalFat != "")
          {
            return Double.Parse(textStoreTotalFat);
          }
        return storeTotalFat;
      }

    public string  getTotalFatAsText()
      {
        Debug.Assert(flagHasTotalFat);
        if (textStoreTotalFat == "")
          {
            return Convert.ToString(storeTotalFat);
          }
        else
          {
            return (textStoreTotalFat);
          }
      }

    public bool  hasCaloriesFromFat()
      {
        return flagHasCaloriesFromFat;
      }

    public BigInteger  getCaloriesFromFat()
      {
        Debug.Assert(flagHasCaloriesFromFat);
        return storeCaloriesFromFat;
      }

    public bool  hasTotalFatPct()
      {
        return flagHasTotalFatPct;
      }

    public double  getTotalFatPct()
      {
        Debug.Assert(flagHasTotalFatPct);
        if (textStoreTotalFatPct != "")
          {
            return Double.Parse(textStoreTotalFatPct);
          }
        return storeTotalFatPct;
      }

    public string  getTotalFatPctAsText()
      {
        Debug.Assert(flagHasTotalFatPct);
        if (textStoreTotalFatPct == "")
          {
            return Convert.ToString(storeTotalFatPct);
          }
        else
          {
            return (textStoreTotalFatPct);
          }
      }

    public bool  hasSatFat()
      {
        return flagHasSatFat;
      }

    public double  getSatFat()
      {
        Debug.Assert(flagHasSatFat);
        if (textStoreSatFat != "")
          {
            return Double.Parse(textStoreSatFat);
          }
        return storeSatFat;
      }

    public string  getSatFatAsText()
      {
        Debug.Assert(flagHasSatFat);
        if (textStoreSatFat == "")
          {
            return Convert.ToString(storeSatFat);
          }
        else
          {
            return (textStoreSatFat);
          }
      }

    public bool  hasSatFatPct()
      {
        return flagHasSatFatPct;
      }

    public double  getSatFatPct()
      {
        Debug.Assert(flagHasSatFatPct);
        if (textStoreSatFatPct != "")
          {
            return Double.Parse(textStoreSatFatPct);
          }
        return storeSatFatPct;
      }

    public string  getSatFatPctAsText()
      {
        Debug.Assert(flagHasSatFatPct);
        if (textStoreSatFatPct == "")
          {
            return Convert.ToString(storeSatFatPct);
          }
        else
          {
            return (textStoreSatFatPct);
          }
      }

    public bool  hasMonoFat()
      {
        return flagHasMonoFat;
      }

    public double  getMonoFat()
      {
        Debug.Assert(flagHasMonoFat);
        if (textStoreMonoFat != "")
          {
            return Double.Parse(textStoreMonoFat);
          }
        return storeMonoFat;
      }

    public string  getMonoFatAsText()
      {
        Debug.Assert(flagHasMonoFat);
        if (textStoreMonoFat == "")
          {
            return Convert.ToString(storeMonoFat);
          }
        else
          {
            return (textStoreMonoFat);
          }
      }

    public bool  hasPolyFat()
      {
        return flagHasPolyFat;
      }

    public double  getPolyFat()
      {
        Debug.Assert(flagHasPolyFat);
        if (textStorePolyFat != "")
          {
            return Double.Parse(textStorePolyFat);
          }
        return storePolyFat;
      }

    public string  getPolyFatAsText()
      {
        Debug.Assert(flagHasPolyFat);
        if (textStorePolyFat == "")
          {
            return Convert.ToString(storePolyFat);
          }
        else
          {
            return (textStorePolyFat);
          }
      }

    public bool  hasTransFat()
      {
        return flagHasTransFat;
      }

    public double  getTransFat()
      {
        Debug.Assert(flagHasTransFat);
        if (textStoreTransFat != "")
          {
            return Double.Parse(textStoreTransFat);
          }
        return storeTransFat;
      }

    public string  getTransFatAsText()
      {
        Debug.Assert(flagHasTransFat);
        if (textStoreTransFat == "")
          {
            return Convert.ToString(storeTransFat);
          }
        else
          {
            return (textStoreTransFat);
          }
      }

    public bool  hasCholesterol()
      {
        return flagHasCholesterol;
      }

    public double  getCholesterol()
      {
        Debug.Assert(flagHasCholesterol);
        if (textStoreCholesterol != "")
          {
            return Double.Parse(textStoreCholesterol);
          }
        return storeCholesterol;
      }

    public string  getCholesterolAsText()
      {
        Debug.Assert(flagHasCholesterol);
        if (textStoreCholesterol == "")
          {
            return Convert.ToString(storeCholesterol);
          }
        else
          {
            return (textStoreCholesterol);
          }
      }

    public bool  hasCholesterolPct()
      {
        return flagHasCholesterolPct;
      }

    public double  getCholesterolPct()
      {
        Debug.Assert(flagHasCholesterolPct);
        if (textStoreCholesterolPct != "")
          {
            return Double.Parse(textStoreCholesterolPct);
          }
        return storeCholesterolPct;
      }

    public string  getCholesterolPctAsText()
      {
        Debug.Assert(flagHasCholesterolPct);
        if (textStoreCholesterolPct == "")
          {
            return Convert.ToString(storeCholesterolPct);
          }
        else
          {
            return (textStoreCholesterolPct);
          }
      }

    public bool  hasSodium()
      {
        return flagHasSodium;
      }

    public double  getSodium()
      {
        Debug.Assert(flagHasSodium);
        if (textStoreSodium != "")
          {
            return Double.Parse(textStoreSodium);
          }
        return storeSodium;
      }

    public string  getSodiumAsText()
      {
        Debug.Assert(flagHasSodium);
        if (textStoreSodium == "")
          {
            return Convert.ToString(storeSodium);
          }
        else
          {
            return (textStoreSodium);
          }
      }

    public bool  hasSodiumPct()
      {
        return flagHasSodiumPct;
      }

    public double  getSodiumPct()
      {
        Debug.Assert(flagHasSodiumPct);
        if (textStoreSodiumPct != "")
          {
            return Double.Parse(textStoreSodiumPct);
          }
        return storeSodiumPct;
      }

    public string  getSodiumPctAsText()
      {
        Debug.Assert(flagHasSodiumPct);
        if (textStoreSodiumPct == "")
          {
            return Convert.ToString(storeSodiumPct);
          }
        else
          {
            return (textStoreSodiumPct);
          }
      }

    public bool  hasPotassium()
      {
        return flagHasPotassium;
      }

    public double  getPotassium()
      {
        Debug.Assert(flagHasPotassium);
        if (textStorePotassium != "")
          {
            return Double.Parse(textStorePotassium);
          }
        return storePotassium;
      }

    public string  getPotassiumAsText()
      {
        Debug.Assert(flagHasPotassium);
        if (textStorePotassium == "")
          {
            return Convert.ToString(storePotassium);
          }
        else
          {
            return (textStorePotassium);
          }
      }

    public bool  hasPotassiumPct()
      {
        return flagHasPotassiumPct;
      }

    public double  getPotassiumPct()
      {
        Debug.Assert(flagHasPotassiumPct);
        if (textStorePotassiumPct != "")
          {
            return Double.Parse(textStorePotassiumPct);
          }
        return storePotassiumPct;
      }

    public string  getPotassiumPctAsText()
      {
        Debug.Assert(flagHasPotassiumPct);
        if (textStorePotassiumPct == "")
          {
            return Convert.ToString(storePotassiumPct);
          }
        else
          {
            return (textStorePotassiumPct);
          }
      }

    public bool  hasTotalCarbs()
      {
        return flagHasTotalCarbs;
      }

    public double  getTotalCarbs()
      {
        Debug.Assert(flagHasTotalCarbs);
        if (textStoreTotalCarbs != "")
          {
            return Double.Parse(textStoreTotalCarbs);
          }
        return storeTotalCarbs;
      }

    public string  getTotalCarbsAsText()
      {
        Debug.Assert(flagHasTotalCarbs);
        if (textStoreTotalCarbs == "")
          {
            return Convert.ToString(storeTotalCarbs);
          }
        else
          {
            return (textStoreTotalCarbs);
          }
      }

    public bool  hasTotalCarbsPct()
      {
        return flagHasTotalCarbsPct;
      }

    public double  getTotalCarbsPct()
      {
        Debug.Assert(flagHasTotalCarbsPct);
        if (textStoreTotalCarbsPct != "")
          {
            return Double.Parse(textStoreTotalCarbsPct);
          }
        return storeTotalCarbsPct;
      }

    public string  getTotalCarbsPctAsText()
      {
        Debug.Assert(flagHasTotalCarbsPct);
        if (textStoreTotalCarbsPct == "")
          {
            return Convert.ToString(storeTotalCarbsPct);
          }
        else
          {
            return (textStoreTotalCarbsPct);
          }
      }

    public bool  hasDietaryFiber()
      {
        return flagHasDietaryFiber;
      }

    public double  getDietaryFiber()
      {
        Debug.Assert(flagHasDietaryFiber);
        if (textStoreDietaryFiber != "")
          {
            return Double.Parse(textStoreDietaryFiber);
          }
        return storeDietaryFiber;
      }

    public string  getDietaryFiberAsText()
      {
        Debug.Assert(flagHasDietaryFiber);
        if (textStoreDietaryFiber == "")
          {
            return Convert.ToString(storeDietaryFiber);
          }
        else
          {
            return (textStoreDietaryFiber);
          }
      }

    public bool  hasDietaryFiberPct()
      {
        return flagHasDietaryFiberPct;
      }

    public double  getDietaryFiberPct()
      {
        Debug.Assert(flagHasDietaryFiberPct);
        if (textStoreDietaryFiberPct != "")
          {
            return Double.Parse(textStoreDietaryFiberPct);
          }
        return storeDietaryFiberPct;
      }

    public string  getDietaryFiberPctAsText()
      {
        Debug.Assert(flagHasDietaryFiberPct);
        if (textStoreDietaryFiberPct == "")
          {
            return Convert.ToString(storeDietaryFiberPct);
          }
        else
          {
            return (textStoreDietaryFiberPct);
          }
      }

    public bool  hasSugar()
      {
        return flagHasSugar;
      }

    public double  getSugar()
      {
        Debug.Assert(flagHasSugar);
        if (textStoreSugar != "")
          {
            return Double.Parse(textStoreSugar);
          }
        return storeSugar;
      }

    public string  getSugarAsText()
      {
        Debug.Assert(flagHasSugar);
        if (textStoreSugar == "")
          {
            return Convert.ToString(storeSugar);
          }
        else
          {
            return (textStoreSugar);
          }
      }

    public bool  hasProtein()
      {
        return flagHasProtein;
      }

    public double  getProtein()
      {
        Debug.Assert(flagHasProtein);
        if (textStoreProtein != "")
          {
            return Double.Parse(textStoreProtein);
          }
        return storeProtein;
      }

    public string  getProteinAsText()
      {
        Debug.Assert(flagHasProtein);
        if (textStoreProtein == "")
          {
            return Convert.ToString(storeProtein);
          }
        else
          {
            return (textStoreProtein);
          }
      }

    public bool  hasProteinPct()
      {
        return flagHasProteinPct;
      }

    public double  getProteinPct()
      {
        Debug.Assert(flagHasProteinPct);
        if (textStoreProteinPct != "")
          {
            return Double.Parse(textStoreProteinPct);
          }
        return storeProteinPct;
      }

    public string  getProteinPctAsText()
      {
        Debug.Assert(flagHasProteinPct);
        if (textStoreProteinPct == "")
          {
            return Convert.ToString(storeProteinPct);
          }
        else
          {
            return (textStoreProteinPct);
          }
      }


    public virtual int extraRecipeNutritionInfoComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRecipeNutritionInfoComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRecipeNutritionInfoComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRecipeNutritionInfoLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSingularYieldUnit(string new_value)
      {
        flagHasSingularYieldUnit = true;
        storeSingularYieldUnit = new_value;
      }
    public void unsetSingularYieldUnit()
      {
        flagHasSingularYieldUnit = false;
      }
    public void setTotalCalories(BigInteger new_value)
      {
        flagHasTotalCalories = true;
        if (new_value < 0)
            throw new Exception("The value for field TotalCalories of RecipeNutritionInfoJSON is less than the lower bound (0) for that field.");
        storeTotalCalories = new_value;
      }
    public void unsetTotalCalories()
      {
        flagHasTotalCalories = false;
      }
    public void setTotalFat(double new_value)
      {
        flagHasTotalFat = true;
        storeTotalFat = new_value;
        textStoreTotalFat = "";
      }
    public void setTotalFatText(string new_value)
      {
        flagHasTotalFat = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TotalFat of RecipeNutritionInfoJSON is not a valid number.");
        textStoreTotalFat = new_value;
      }
    public void unsetTotalFat()
      {
        flagHasTotalFat = false;
      }
    public void setCaloriesFromFat(BigInteger new_value)
      {
        flagHasCaloriesFromFat = true;
        if (new_value < 0)
            throw new Exception("The value for field CaloriesFromFat of RecipeNutritionInfoJSON is less than the lower bound (0) for that field.");
        storeCaloriesFromFat = new_value;
      }
    public void unsetCaloriesFromFat()
      {
        flagHasCaloriesFromFat = false;
      }
    public void setTotalFatPct(double new_value)
      {
        flagHasTotalFatPct = true;
        storeTotalFatPct = new_value;
        textStoreTotalFatPct = "";
      }
    public void setTotalFatPctText(string new_value)
      {
        flagHasTotalFatPct = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TotalFatPct of RecipeNutritionInfoJSON is not a valid number.");
        textStoreTotalFatPct = new_value;
      }
    public void unsetTotalFatPct()
      {
        flagHasTotalFatPct = false;
      }
    public void setSatFat(double new_value)
      {
        flagHasSatFat = true;
        storeSatFat = new_value;
        textStoreSatFat = "";
      }
    public void setSatFatText(string new_value)
      {
        flagHasSatFat = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field SatFat of RecipeNutritionInfoJSON is not a valid number.");
        textStoreSatFat = new_value;
      }
    public void unsetSatFat()
      {
        flagHasSatFat = false;
      }
    public void setSatFatPct(double new_value)
      {
        flagHasSatFatPct = true;
        storeSatFatPct = new_value;
        textStoreSatFatPct = "";
      }
    public void setSatFatPctText(string new_value)
      {
        flagHasSatFatPct = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field SatFatPct of RecipeNutritionInfoJSON is not a valid number.");
        textStoreSatFatPct = new_value;
      }
    public void unsetSatFatPct()
      {
        flagHasSatFatPct = false;
      }
    public void setMonoFat(double new_value)
      {
        flagHasMonoFat = true;
        storeMonoFat = new_value;
        textStoreMonoFat = "";
      }
    public void setMonoFatText(string new_value)
      {
        flagHasMonoFat = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field MonoFat of RecipeNutritionInfoJSON is not a valid number.");
        textStoreMonoFat = new_value;
      }
    public void unsetMonoFat()
      {
        flagHasMonoFat = false;
      }
    public void setPolyFat(double new_value)
      {
        flagHasPolyFat = true;
        storePolyFat = new_value;
        textStorePolyFat = "";
      }
    public void setPolyFatText(string new_value)
      {
        flagHasPolyFat = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field PolyFat of RecipeNutritionInfoJSON is not a valid number.");
        textStorePolyFat = new_value;
      }
    public void unsetPolyFat()
      {
        flagHasPolyFat = false;
      }
    public void setTransFat(double new_value)
      {
        flagHasTransFat = true;
        storeTransFat = new_value;
        textStoreTransFat = "";
      }
    public void setTransFatText(string new_value)
      {
        flagHasTransFat = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TransFat of RecipeNutritionInfoJSON is not a valid number.");
        textStoreTransFat = new_value;
      }
    public void unsetTransFat()
      {
        flagHasTransFat = false;
      }
    public void setCholesterol(double new_value)
      {
        flagHasCholesterol = true;
        storeCholesterol = new_value;
        textStoreCholesterol = "";
      }
    public void setCholesterolText(string new_value)
      {
        flagHasCholesterol = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Cholesterol of RecipeNutritionInfoJSON is not a valid number.");
        textStoreCholesterol = new_value;
      }
    public void unsetCholesterol()
      {
        flagHasCholesterol = false;
      }
    public void setCholesterolPct(double new_value)
      {
        flagHasCholesterolPct = true;
        storeCholesterolPct = new_value;
        textStoreCholesterolPct = "";
      }
    public void setCholesterolPctText(string new_value)
      {
        flagHasCholesterolPct = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field CholesterolPct of RecipeNutritionInfoJSON is not a valid number.");
        textStoreCholesterolPct = new_value;
      }
    public void unsetCholesterolPct()
      {
        flagHasCholesterolPct = false;
      }
    public void setSodium(double new_value)
      {
        flagHasSodium = true;
        storeSodium = new_value;
        textStoreSodium = "";
      }
    public void setSodiumText(string new_value)
      {
        flagHasSodium = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Sodium of RecipeNutritionInfoJSON is not a valid number.");
        textStoreSodium = new_value;
      }
    public void unsetSodium()
      {
        flagHasSodium = false;
      }
    public void setSodiumPct(double new_value)
      {
        flagHasSodiumPct = true;
        storeSodiumPct = new_value;
        textStoreSodiumPct = "";
      }
    public void setSodiumPctText(string new_value)
      {
        flagHasSodiumPct = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field SodiumPct of RecipeNutritionInfoJSON is not a valid number.");
        textStoreSodiumPct = new_value;
      }
    public void unsetSodiumPct()
      {
        flagHasSodiumPct = false;
      }
    public void setPotassium(double new_value)
      {
        flagHasPotassium = true;
        storePotassium = new_value;
        textStorePotassium = "";
      }
    public void setPotassiumText(string new_value)
      {
        flagHasPotassium = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Potassium of RecipeNutritionInfoJSON is not a valid number.");
        textStorePotassium = new_value;
      }
    public void unsetPotassium()
      {
        flagHasPotassium = false;
      }
    public void setPotassiumPct(double new_value)
      {
        flagHasPotassiumPct = true;
        storePotassiumPct = new_value;
        textStorePotassiumPct = "";
      }
    public void setPotassiumPctText(string new_value)
      {
        flagHasPotassiumPct = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field PotassiumPct of RecipeNutritionInfoJSON is not a valid number.");
        textStorePotassiumPct = new_value;
      }
    public void unsetPotassiumPct()
      {
        flagHasPotassiumPct = false;
      }
    public void setTotalCarbs(double new_value)
      {
        flagHasTotalCarbs = true;
        storeTotalCarbs = new_value;
        textStoreTotalCarbs = "";
      }
    public void setTotalCarbsText(string new_value)
      {
        flagHasTotalCarbs = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TotalCarbs of RecipeNutritionInfoJSON is not a valid number.");
        textStoreTotalCarbs = new_value;
      }
    public void unsetTotalCarbs()
      {
        flagHasTotalCarbs = false;
      }
    public void setTotalCarbsPct(double new_value)
      {
        flagHasTotalCarbsPct = true;
        storeTotalCarbsPct = new_value;
        textStoreTotalCarbsPct = "";
      }
    public void setTotalCarbsPctText(string new_value)
      {
        flagHasTotalCarbsPct = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field TotalCarbsPct of RecipeNutritionInfoJSON is not a valid number.");
        textStoreTotalCarbsPct = new_value;
      }
    public void unsetTotalCarbsPct()
      {
        flagHasTotalCarbsPct = false;
      }
    public void setDietaryFiber(double new_value)
      {
        flagHasDietaryFiber = true;
        storeDietaryFiber = new_value;
        textStoreDietaryFiber = "";
      }
    public void setDietaryFiberText(string new_value)
      {
        flagHasDietaryFiber = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field DietaryFiber of RecipeNutritionInfoJSON is not a valid number.");
        textStoreDietaryFiber = new_value;
      }
    public void unsetDietaryFiber()
      {
        flagHasDietaryFiber = false;
      }
    public void setDietaryFiberPct(double new_value)
      {
        flagHasDietaryFiberPct = true;
        storeDietaryFiberPct = new_value;
        textStoreDietaryFiberPct = "";
      }
    public void setDietaryFiberPctText(string new_value)
      {
        flagHasDietaryFiberPct = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field DietaryFiberPct of RecipeNutritionInfoJSON is not a valid number.");
        textStoreDietaryFiberPct = new_value;
      }
    public void unsetDietaryFiberPct()
      {
        flagHasDietaryFiberPct = false;
      }
    public void setSugar(double new_value)
      {
        flagHasSugar = true;
        storeSugar = new_value;
        textStoreSugar = "";
      }
    public void setSugarText(string new_value)
      {
        flagHasSugar = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Sugar of RecipeNutritionInfoJSON is not a valid number.");
        textStoreSugar = new_value;
      }
    public void unsetSugar()
      {
        flagHasSugar = false;
      }
    public void setProtein(double new_value)
      {
        flagHasProtein = true;
        storeProtein = new_value;
        textStoreProtein = "";
      }
    public void setProteinText(string new_value)
      {
        flagHasProtein = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Protein of RecipeNutritionInfoJSON is not a valid number.");
        textStoreProtein = new_value;
      }
    public void unsetProtein()
      {
        flagHasProtein = false;
      }
    public void setProteinPct(double new_value)
      {
        flagHasProteinPct = true;
        storeProteinPct = new_value;
        textStoreProteinPct = "";
      }
    public void setProteinPctText(string new_value)
      {
        flagHasProteinPct = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field ProteinPct of RecipeNutritionInfoJSON is not a valid number.");
        textStoreProteinPct = new_value;
      }
    public void unsetProteinPct()
      {
        flagHasProteinPct = false;
      }

    public virtual void extraRecipeNutritionInfoAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRecipeNutritionInfoSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRecipeNutritionInfoLookup(key);
        if (old_field == null)
          {
            extraRecipeNutritionInfoAppendPair(key, new_component);
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
        if (flagHasSingularYieldUnit)
          {
            handler.start_pair("SingularYieldUnit");
            handler.string_value(storeSingularYieldUnit);
          }
        if (flagHasTotalCalories)
          {
            handler.start_pair("TotalCalories");
            handler.number_value(storeTotalCalories);
          }
        if (flagHasTotalFat)
          {
            handler.start_pair("TotalFat");
            if (textStoreTotalFat != "")
                handler.number_value(textStoreTotalFat);
            else if (((double)(long)storeTotalFat) == storeTotalFat)
                handler.number_value((long)storeTotalFat);
            else
                handler.number_value(storeTotalFat);
          }
        if (flagHasCaloriesFromFat)
          {
            handler.start_pair("CaloriesFromFat");
            handler.number_value(storeCaloriesFromFat);
          }
        if (flagHasTotalFatPct)
          {
            handler.start_pair("TotalFatPct");
            if (textStoreTotalFatPct != "")
                handler.number_value(textStoreTotalFatPct);
            else if (((double)(long)storeTotalFatPct) == storeTotalFatPct)
                handler.number_value((long)storeTotalFatPct);
            else
                handler.number_value(storeTotalFatPct);
          }
        if (flagHasSatFat)
          {
            handler.start_pair("SatFat");
            if (textStoreSatFat != "")
                handler.number_value(textStoreSatFat);
            else if (((double)(long)storeSatFat) == storeSatFat)
                handler.number_value((long)storeSatFat);
            else
                handler.number_value(storeSatFat);
          }
        if (flagHasSatFatPct)
          {
            handler.start_pair("SatFatPct");
            if (textStoreSatFatPct != "")
                handler.number_value(textStoreSatFatPct);
            else if (((double)(long)storeSatFatPct) == storeSatFatPct)
                handler.number_value((long)storeSatFatPct);
            else
                handler.number_value(storeSatFatPct);
          }
        if (flagHasMonoFat)
          {
            handler.start_pair("MonoFat");
            if (textStoreMonoFat != "")
                handler.number_value(textStoreMonoFat);
            else if (((double)(long)storeMonoFat) == storeMonoFat)
                handler.number_value((long)storeMonoFat);
            else
                handler.number_value(storeMonoFat);
          }
        if (flagHasPolyFat)
          {
            handler.start_pair("PolyFat");
            if (textStorePolyFat != "")
                handler.number_value(textStorePolyFat);
            else if (((double)(long)storePolyFat) == storePolyFat)
                handler.number_value((long)storePolyFat);
            else
                handler.number_value(storePolyFat);
          }
        if (flagHasTransFat)
          {
            handler.start_pair("TransFat");
            if (textStoreTransFat != "")
                handler.number_value(textStoreTransFat);
            else if (((double)(long)storeTransFat) == storeTransFat)
                handler.number_value((long)storeTransFat);
            else
                handler.number_value(storeTransFat);
          }
        if (flagHasCholesterol)
          {
            handler.start_pair("Cholesterol");
            if (textStoreCholesterol != "")
                handler.number_value(textStoreCholesterol);
            else if (((double)(long)storeCholesterol) == storeCholesterol)
                handler.number_value((long)storeCholesterol);
            else
                handler.number_value(storeCholesterol);
          }
        if (flagHasCholesterolPct)
          {
            handler.start_pair("CholesterolPct");
            if (textStoreCholesterolPct != "")
                handler.number_value(textStoreCholesterolPct);
            else if (((double)(long)storeCholesterolPct) == storeCholesterolPct)
                handler.number_value((long)storeCholesterolPct);
            else
                handler.number_value(storeCholesterolPct);
          }
        if (flagHasSodium)
          {
            handler.start_pair("Sodium");
            if (textStoreSodium != "")
                handler.number_value(textStoreSodium);
            else if (((double)(long)storeSodium) == storeSodium)
                handler.number_value((long)storeSodium);
            else
                handler.number_value(storeSodium);
          }
        if (flagHasSodiumPct)
          {
            handler.start_pair("SodiumPct");
            if (textStoreSodiumPct != "")
                handler.number_value(textStoreSodiumPct);
            else if (((double)(long)storeSodiumPct) == storeSodiumPct)
                handler.number_value((long)storeSodiumPct);
            else
                handler.number_value(storeSodiumPct);
          }
        if (flagHasPotassium)
          {
            handler.start_pair("Potassium");
            if (textStorePotassium != "")
                handler.number_value(textStorePotassium);
            else if (((double)(long)storePotassium) == storePotassium)
                handler.number_value((long)storePotassium);
            else
                handler.number_value(storePotassium);
          }
        if (flagHasPotassiumPct)
          {
            handler.start_pair("PotassiumPct");
            if (textStorePotassiumPct != "")
                handler.number_value(textStorePotassiumPct);
            else if (((double)(long)storePotassiumPct) == storePotassiumPct)
                handler.number_value((long)storePotassiumPct);
            else
                handler.number_value(storePotassiumPct);
          }
        if (flagHasTotalCarbs)
          {
            handler.start_pair("TotalCarbs");
            if (textStoreTotalCarbs != "")
                handler.number_value(textStoreTotalCarbs);
            else if (((double)(long)storeTotalCarbs) == storeTotalCarbs)
                handler.number_value((long)storeTotalCarbs);
            else
                handler.number_value(storeTotalCarbs);
          }
        if (flagHasTotalCarbsPct)
          {
            handler.start_pair("TotalCarbsPct");
            if (textStoreTotalCarbsPct != "")
                handler.number_value(textStoreTotalCarbsPct);
            else if (((double)(long)storeTotalCarbsPct) == storeTotalCarbsPct)
                handler.number_value((long)storeTotalCarbsPct);
            else
                handler.number_value(storeTotalCarbsPct);
          }
        if (flagHasDietaryFiber)
          {
            handler.start_pair("DietaryFiber");
            if (textStoreDietaryFiber != "")
                handler.number_value(textStoreDietaryFiber);
            else if (((double)(long)storeDietaryFiber) == storeDietaryFiber)
                handler.number_value((long)storeDietaryFiber);
            else
                handler.number_value(storeDietaryFiber);
          }
        if (flagHasDietaryFiberPct)
          {
            handler.start_pair("DietaryFiberPct");
            if (textStoreDietaryFiberPct != "")
                handler.number_value(textStoreDietaryFiberPct);
            else if (((double)(long)storeDietaryFiberPct) == storeDietaryFiberPct)
                handler.number_value((long)storeDietaryFiberPct);
            else
                handler.number_value(storeDietaryFiberPct);
          }
        if (flagHasSugar)
          {
            handler.start_pair("Sugar");
            if (textStoreSugar != "")
                handler.number_value(textStoreSugar);
            else if (((double)(long)storeSugar) == storeSugar)
                handler.number_value((long)storeSugar);
            else
                handler.number_value(storeSugar);
          }
        if (flagHasProtein)
          {
            handler.start_pair("Protein");
            if (textStoreProtein != "")
                handler.number_value(textStoreProtein);
            else if (((double)(long)storeProtein) == storeProtein)
                handler.number_value((long)storeProtein);
            else
                handler.number_value(storeProtein);
          }
        if (flagHasProteinPct)
          {
            handler.start_pair("ProteinPct");
            if (textStoreProteinPct != "")
                handler.number_value(textStoreProteinPct);
            else if (((double)(long)storeProteinPct) == storeProteinPct)
                handler.number_value((long)storeProteinPct);
            else
                handler.number_value(storeProteinPct);
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

    public static RecipeNutritionInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeNutritionInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeNutritionInfo", ignore_extras);
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
    public static RecipeNutritionInfoJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RecipeNutritionInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RecipeNutritionInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeNutritionInfo", ignore_extras);
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
    public static RecipeNutritionInfoJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RecipeNutritionInfoJSON from_text(string text, bool ignore_extras)
      {
        RecipeNutritionInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeNutritionInfo", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RecipeNutritionInfoJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RecipeNutritionInfoJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RecipeNutritionInfoJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RecipeNutritionInfo", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSingularYieldUnit;
    private class FieldHoldingGeneratorTotalCalories : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorTotalCalories(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorTotalCalories : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorTotalCalories(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorTotalCalories fieldGeneratorTotalCalories;
        private JSONHoldingNumberTextGenerator fieldGeneratorTotalFat;
    private class FieldHoldingGeneratorCaloriesFromFat : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorCaloriesFromFat(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorCaloriesFromFat : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorCaloriesFromFat(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorCaloriesFromFat fieldGeneratorCaloriesFromFat;
        private JSONHoldingNumberTextGenerator fieldGeneratorTotalFatPct;
        private JSONHoldingNumberTextGenerator fieldGeneratorSatFat;
        private JSONHoldingNumberTextGenerator fieldGeneratorSatFatPct;
        private JSONHoldingNumberTextGenerator fieldGeneratorMonoFat;
        private JSONHoldingNumberTextGenerator fieldGeneratorPolyFat;
        private JSONHoldingNumberTextGenerator fieldGeneratorTransFat;
        private JSONHoldingNumberTextGenerator fieldGeneratorCholesterol;
        private JSONHoldingNumberTextGenerator fieldGeneratorCholesterolPct;
        private JSONHoldingNumberTextGenerator fieldGeneratorSodium;
        private JSONHoldingNumberTextGenerator fieldGeneratorSodiumPct;
        private JSONHoldingNumberTextGenerator fieldGeneratorPotassium;
        private JSONHoldingNumberTextGenerator fieldGeneratorPotassiumPct;
        private JSONHoldingNumberTextGenerator fieldGeneratorTotalCarbs;
        private JSONHoldingNumberTextGenerator fieldGeneratorTotalCarbsPct;
        private JSONHoldingNumberTextGenerator fieldGeneratorDietaryFiber;
        private JSONHoldingNumberTextGenerator fieldGeneratorDietaryFiberPct;
        private JSONHoldingNumberTextGenerator fieldGeneratorSugar;
        private JSONHoldingNumberTextGenerator fieldGeneratorProtein;
        private JSONHoldingNumberTextGenerator fieldGeneratorProteinPct;
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
            RecipeNutritionInfoJSON result = new RecipeNutritionInfoJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRecipeNutritionInfoAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RecipeNutritionInfoJSON result)
          {
            if (fieldGeneratorSingularYieldUnit.have_value)
              {
                result.setSingularYieldUnit(fieldGeneratorSingularYieldUnit.value);
                fieldGeneratorSingularYieldUnit.have_value = false;
              }
            if (fieldGeneratorTotalCalories.have_value)
              {
                result.setTotalCalories(fieldGeneratorTotalCalories.value);
                fieldGeneratorTotalCalories.have_value = false;
              }
            if (fieldGeneratorTotalFat.have_value)
              {
                result.setTotalFatText(fieldGeneratorTotalFat.value);
                fieldGeneratorTotalFat.have_value = false;
              }
            if (fieldGeneratorCaloriesFromFat.have_value)
              {
                result.setCaloriesFromFat(fieldGeneratorCaloriesFromFat.value);
                fieldGeneratorCaloriesFromFat.have_value = false;
              }
            if (fieldGeneratorTotalFatPct.have_value)
              {
                result.setTotalFatPctText(fieldGeneratorTotalFatPct.value);
                fieldGeneratorTotalFatPct.have_value = false;
              }
            if (fieldGeneratorSatFat.have_value)
              {
                result.setSatFatText(fieldGeneratorSatFat.value);
                fieldGeneratorSatFat.have_value = false;
              }
            if (fieldGeneratorSatFatPct.have_value)
              {
                result.setSatFatPctText(fieldGeneratorSatFatPct.value);
                fieldGeneratorSatFatPct.have_value = false;
              }
            if (fieldGeneratorMonoFat.have_value)
              {
                result.setMonoFatText(fieldGeneratorMonoFat.value);
                fieldGeneratorMonoFat.have_value = false;
              }
            if (fieldGeneratorPolyFat.have_value)
              {
                result.setPolyFatText(fieldGeneratorPolyFat.value);
                fieldGeneratorPolyFat.have_value = false;
              }
            if (fieldGeneratorTransFat.have_value)
              {
                result.setTransFatText(fieldGeneratorTransFat.value);
                fieldGeneratorTransFat.have_value = false;
              }
            if (fieldGeneratorCholesterol.have_value)
              {
                result.setCholesterolText(fieldGeneratorCholesterol.value);
                fieldGeneratorCholesterol.have_value = false;
              }
            if (fieldGeneratorCholesterolPct.have_value)
              {
                result.setCholesterolPctText(fieldGeneratorCholesterolPct.value);
                fieldGeneratorCholesterolPct.have_value = false;
              }
            if (fieldGeneratorSodium.have_value)
              {
                result.setSodiumText(fieldGeneratorSodium.value);
                fieldGeneratorSodium.have_value = false;
              }
            if (fieldGeneratorSodiumPct.have_value)
              {
                result.setSodiumPctText(fieldGeneratorSodiumPct.value);
                fieldGeneratorSodiumPct.have_value = false;
              }
            if (fieldGeneratorPotassium.have_value)
              {
                result.setPotassiumText(fieldGeneratorPotassium.value);
                fieldGeneratorPotassium.have_value = false;
              }
            if (fieldGeneratorPotassiumPct.have_value)
              {
                result.setPotassiumPctText(fieldGeneratorPotassiumPct.value);
                fieldGeneratorPotassiumPct.have_value = false;
              }
            if (fieldGeneratorTotalCarbs.have_value)
              {
                result.setTotalCarbsText(fieldGeneratorTotalCarbs.value);
                fieldGeneratorTotalCarbs.have_value = false;
              }
            if (fieldGeneratorTotalCarbsPct.have_value)
              {
                result.setTotalCarbsPctText(fieldGeneratorTotalCarbsPct.value);
                fieldGeneratorTotalCarbsPct.have_value = false;
              }
            if (fieldGeneratorDietaryFiber.have_value)
              {
                result.setDietaryFiberText(fieldGeneratorDietaryFiber.value);
                fieldGeneratorDietaryFiber.have_value = false;
              }
            if (fieldGeneratorDietaryFiberPct.have_value)
              {
                result.setDietaryFiberPctText(fieldGeneratorDietaryFiberPct.value);
                fieldGeneratorDietaryFiberPct.have_value = false;
              }
            if (fieldGeneratorSugar.have_value)
              {
                result.setSugarText(fieldGeneratorSugar.value);
                fieldGeneratorSugar.have_value = false;
              }
            if (fieldGeneratorProtein.have_value)
              {
                result.setProteinText(fieldGeneratorProtein.value);
                fieldGeneratorProtein.have_value = false;
              }
            if (fieldGeneratorProteinPct.have_value)
              {
                result.setProteinPctText(fieldGeneratorProteinPct.value);
                fieldGeneratorProteinPct.have_value = false;
              }
          }
        protected abstract void handle_result(RecipeNutritionInfoJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "loriesFromFat", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorCaloriesFromFat;
                            break;
                        case 'h':
                            if (String.Compare(field_name, 2, "olesterol", 0, 9, false) == 0)
                              {
                                if (field_name.Length == 11)
                                  {
                                    return fieldGeneratorCholesterol;
                                  }
                                switch (field_name[11])
                                  {
                                    case 'P':
                                        if ((String.Compare(field_name, 12, "ct", 0, 2, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorCholesterolPct;
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
                case 'D':
                    if (String.Compare(field_name, 1, "ietaryFiber", 0, 11, false) == 0)
                      {
                        if (field_name.Length == 12)
                          {
                            return fieldGeneratorDietaryFiber;
                          }
                        switch (field_name[12])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 13, "ct", 0, 2, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorDietaryFiberPct;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "onoFat", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorMonoFat;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'o':
                            switch (field_name[2])
                              {
                                case 'l':
                                    if ((String.Compare(field_name, 3, "yFat", 0, 4, false) == 0) && (field_name.Length == 7))
                                        return fieldGeneratorPolyFat;
                                    break;
                                case 't':
                                    if (String.Compare(field_name, 3, "assium", 0, 6, false) == 0)
                                      {
                                        if (field_name.Length == 9)
                                          {
                                            return fieldGeneratorPotassium;
                                          }
                                        switch (field_name[9])
                                          {
                                            case 'P':
                                                if ((String.Compare(field_name, 10, "ct", 0, 2, false) == 0) && (field_name.Length == 12))
                                                    return fieldGeneratorPotassiumPct;
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
                        case 'r':
                            if (String.Compare(field_name, 2, "otein", 0, 5, false) == 0)
                              {
                                if (field_name.Length == 7)
                                  {
                                    return fieldGeneratorProtein;
                                  }
                                switch (field_name[7])
                                  {
                                    case 'P':
                                        if ((String.Compare(field_name, 8, "ct", 0, 2, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorProteinPct;
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
                case 'S':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "tFat", 0, 4, false) == 0)
                              {
                                if (field_name.Length == 6)
                                  {
                                    return fieldGeneratorSatFat;
                                  }
                                switch (field_name[6])
                                  {
                                    case 'P':
                                        if ((String.Compare(field_name, 7, "ct", 0, 2, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorSatFatPct;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "ngularYieldUnit", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorSingularYieldUnit;
                            break;
                        case 'o':
                            if (String.Compare(field_name, 2, "dium", 0, 4, false) == 0)
                              {
                                if (field_name.Length == 6)
                                  {
                                    return fieldGeneratorSodium;
                                  }
                                switch (field_name[6])
                                  {
                                    case 'P':
                                        if ((String.Compare(field_name, 7, "ct", 0, 2, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorSodiumPct;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'u':
                            if ((String.Compare(field_name, 2, "gar", 0, 3, false) == 0) && (field_name.Length == 5))
                                return fieldGeneratorSugar;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    switch (field_name[1])
                      {
                        case 'o':
                            if (String.Compare(field_name, 2, "tal", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'C':
                                        if (String.Compare(field_name, 6, "a", 0, 1, false) == 0)
                                          {
                                            switch (field_name[7])
                                              {
                                                case 'l':
                                                    if ((String.Compare(field_name, 8, "ories", 0, 5, false) == 0) && (field_name.Length == 13))
                                                        return fieldGeneratorTotalCalories;
                                                    break;
                                                case 'r':
                                                    if (String.Compare(field_name, 8, "bs", 0, 2, false) == 0)
                                                      {
                                                        if (field_name.Length == 10)
                                                          {
                                                            return fieldGeneratorTotalCarbs;
                                                          }
                                                        switch (field_name[10])
                                                          {
                                                            case 'P':
                                                                if ((String.Compare(field_name, 11, "ct", 0, 2, false) == 0) && (field_name.Length == 13))
                                                                    return fieldGeneratorTotalCarbsPct;
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
                                    case 'F':
                                        if (String.Compare(field_name, 6, "at", 0, 2, false) == 0)
                                          {
                                            if (field_name.Length == 8)
                                              {
                                                return fieldGeneratorTotalFat;
                                              }
                                            switch (field_name[8])
                                              {
                                                case 'P':
                                                    if ((String.Compare(field_name, 9, "ct", 0, 2, false) == 0) && (field_name.Length == 11))
                                                        return fieldGeneratorTotalFatPct;
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
                        case 'r':
                            if ((String.Compare(field_name, 2, "ansFat", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorTransFat;
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
            fieldGeneratorSingularYieldUnit = new JSONHoldingStringGenerator("field \"SingularYieldUnit\" of the RecipeNutritionInfo class");
            fieldGeneratorTotalCalories = new FieldHoldingGeneratorTotalCalories("field \"TotalCalories\" of the RecipeNutritionInfo class");
            fieldGeneratorTotalFat = new JSONHoldingNumberTextGenerator("field \"TotalFat\" of the RecipeNutritionInfo class");
            fieldGeneratorCaloriesFromFat = new FieldHoldingGeneratorCaloriesFromFat("field \"CaloriesFromFat\" of the RecipeNutritionInfo class");
            fieldGeneratorTotalFatPct = new JSONHoldingNumberTextGenerator("field \"TotalFatPct\" of the RecipeNutritionInfo class");
            fieldGeneratorSatFat = new JSONHoldingNumberTextGenerator("field \"SatFat\" of the RecipeNutritionInfo class");
            fieldGeneratorSatFatPct = new JSONHoldingNumberTextGenerator("field \"SatFatPct\" of the RecipeNutritionInfo class");
            fieldGeneratorMonoFat = new JSONHoldingNumberTextGenerator("field \"MonoFat\" of the RecipeNutritionInfo class");
            fieldGeneratorPolyFat = new JSONHoldingNumberTextGenerator("field \"PolyFat\" of the RecipeNutritionInfo class");
            fieldGeneratorTransFat = new JSONHoldingNumberTextGenerator("field \"TransFat\" of the RecipeNutritionInfo class");
            fieldGeneratorCholesterol = new JSONHoldingNumberTextGenerator("field \"Cholesterol\" of the RecipeNutritionInfo class");
            fieldGeneratorCholesterolPct = new JSONHoldingNumberTextGenerator("field \"CholesterolPct\" of the RecipeNutritionInfo class");
            fieldGeneratorSodium = new JSONHoldingNumberTextGenerator("field \"Sodium\" of the RecipeNutritionInfo class");
            fieldGeneratorSodiumPct = new JSONHoldingNumberTextGenerator("field \"SodiumPct\" of the RecipeNutritionInfo class");
            fieldGeneratorPotassium = new JSONHoldingNumberTextGenerator("field \"Potassium\" of the RecipeNutritionInfo class");
            fieldGeneratorPotassiumPct = new JSONHoldingNumberTextGenerator("field \"PotassiumPct\" of the RecipeNutritionInfo class");
            fieldGeneratorTotalCarbs = new JSONHoldingNumberTextGenerator("field \"TotalCarbs\" of the RecipeNutritionInfo class");
            fieldGeneratorTotalCarbsPct = new JSONHoldingNumberTextGenerator("field \"TotalCarbsPct\" of the RecipeNutritionInfo class");
            fieldGeneratorDietaryFiber = new JSONHoldingNumberTextGenerator("field \"DietaryFiber\" of the RecipeNutritionInfo class");
            fieldGeneratorDietaryFiberPct = new JSONHoldingNumberTextGenerator("field \"DietaryFiberPct\" of the RecipeNutritionInfo class");
            fieldGeneratorSugar = new JSONHoldingNumberTextGenerator("field \"Sugar\" of the RecipeNutritionInfo class");
            fieldGeneratorProtein = new JSONHoldingNumberTextGenerator("field \"Protein\" of the RecipeNutritionInfo class");
            fieldGeneratorProteinPct = new JSONHoldingNumberTextGenerator("field \"ProteinPct\" of the RecipeNutritionInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RecipeNutritionInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSingularYieldUnit = new JSONHoldingStringGenerator("field \"SingularYieldUnit\" of the RecipeNutritionInfo class");
            fieldGeneratorTotalCalories = new FieldHoldingGeneratorTotalCalories("field \"TotalCalories\" of the RecipeNutritionInfo class");
            fieldGeneratorTotalFat = new JSONHoldingNumberTextGenerator("field \"TotalFat\" of the RecipeNutritionInfo class");
            fieldGeneratorCaloriesFromFat = new FieldHoldingGeneratorCaloriesFromFat("field \"CaloriesFromFat\" of the RecipeNutritionInfo class");
            fieldGeneratorTotalFatPct = new JSONHoldingNumberTextGenerator("field \"TotalFatPct\" of the RecipeNutritionInfo class");
            fieldGeneratorSatFat = new JSONHoldingNumberTextGenerator("field \"SatFat\" of the RecipeNutritionInfo class");
            fieldGeneratorSatFatPct = new JSONHoldingNumberTextGenerator("field \"SatFatPct\" of the RecipeNutritionInfo class");
            fieldGeneratorMonoFat = new JSONHoldingNumberTextGenerator("field \"MonoFat\" of the RecipeNutritionInfo class");
            fieldGeneratorPolyFat = new JSONHoldingNumberTextGenerator("field \"PolyFat\" of the RecipeNutritionInfo class");
            fieldGeneratorTransFat = new JSONHoldingNumberTextGenerator("field \"TransFat\" of the RecipeNutritionInfo class");
            fieldGeneratorCholesterol = new JSONHoldingNumberTextGenerator("field \"Cholesterol\" of the RecipeNutritionInfo class");
            fieldGeneratorCholesterolPct = new JSONHoldingNumberTextGenerator("field \"CholesterolPct\" of the RecipeNutritionInfo class");
            fieldGeneratorSodium = new JSONHoldingNumberTextGenerator("field \"Sodium\" of the RecipeNutritionInfo class");
            fieldGeneratorSodiumPct = new JSONHoldingNumberTextGenerator("field \"SodiumPct\" of the RecipeNutritionInfo class");
            fieldGeneratorPotassium = new JSONHoldingNumberTextGenerator("field \"Potassium\" of the RecipeNutritionInfo class");
            fieldGeneratorPotassiumPct = new JSONHoldingNumberTextGenerator("field \"PotassiumPct\" of the RecipeNutritionInfo class");
            fieldGeneratorTotalCarbs = new JSONHoldingNumberTextGenerator("field \"TotalCarbs\" of the RecipeNutritionInfo class");
            fieldGeneratorTotalCarbsPct = new JSONHoldingNumberTextGenerator("field \"TotalCarbsPct\" of the RecipeNutritionInfo class");
            fieldGeneratorDietaryFiber = new JSONHoldingNumberTextGenerator("field \"DietaryFiber\" of the RecipeNutritionInfo class");
            fieldGeneratorDietaryFiberPct = new JSONHoldingNumberTextGenerator("field \"DietaryFiberPct\" of the RecipeNutritionInfo class");
            fieldGeneratorSugar = new JSONHoldingNumberTextGenerator("field \"Sugar\" of the RecipeNutritionInfo class");
            fieldGeneratorProtein = new JSONHoldingNumberTextGenerator("field \"Protein\" of the RecipeNutritionInfo class");
            fieldGeneratorProteinPct = new JSONHoldingNumberTextGenerator("field \"ProteinPct\" of the RecipeNutritionInfo class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RecipeNutritionInfo class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSingularYieldUnit.reset();
            fieldGeneratorTotalCalories.reset();
            fieldGeneratorTotalFat.reset();
            fieldGeneratorCaloriesFromFat.reset();
            fieldGeneratorTotalFatPct.reset();
            fieldGeneratorSatFat.reset();
            fieldGeneratorSatFatPct.reset();
            fieldGeneratorMonoFat.reset();
            fieldGeneratorPolyFat.reset();
            fieldGeneratorTransFat.reset();
            fieldGeneratorCholesterol.reset();
            fieldGeneratorCholesterolPct.reset();
            fieldGeneratorSodium.reset();
            fieldGeneratorSodiumPct.reset();
            fieldGeneratorPotassium.reset();
            fieldGeneratorPotassiumPct.reset();
            fieldGeneratorTotalCarbs.reset();
            fieldGeneratorTotalCarbsPct.reset();
            fieldGeneratorDietaryFiber.reset();
            fieldGeneratorDietaryFiberPct.reset();
            fieldGeneratorSugar.reset();
            fieldGeneratorProtein.reset();
            fieldGeneratorProteinPct.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RecipeNutritionInfoJSON  result)
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
        public RecipeNutritionInfoJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RecipeNutritionInfoJSON  result)
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
    protected virtual void handle_result(List<RecipeNutritionInfoJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RecipeNutritionInfoJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RecipeNutritionInfoJSON>();
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
    public List<RecipeNutritionInfoJSON> value;
  };
  };
