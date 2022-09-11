/* file "LocalSearchFilterFlagsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class LocalSearchFilterFlagsJSON : JSONBase
  {
    private bool flagHasResultCount;
    private bool storeResultCount;
    private bool flagHasMapLocation;
    private bool storeMapLocation;
    private bool flagHasRadius;
    private bool storeRadius;
    private bool flagHasRadiusUnit;
    private bool storeRadiusUnit;
    private bool flagHasRadiusInferred;
    private bool storeRadiusInferred;
    private bool flagHasAlongTheRoute;
    private bool storeAlongTheRoute;
    private bool flagHasOpenHours;
    private OpenHoursFlagsJSON  storeOpenHours;
    private bool flagHasOpenHoursFilterOnHoliday;
    private bool storeOpenHoursFilterOnHoliday;
    private bool flagHasSortSpecification;
    private List< bool > storeSortSpecification;
    private bool flagHasExpensiveFlag;
    private bool storeExpensiveFlag;
    private bool flagHasInexpensiveFlag;
    private bool storeInexpensiveFlag;
    private bool flagHasStarRatingMin;
    private bool storeStarRatingMin;
    private bool flagHasStarRatingMax;
    private bool storeStarRatingMax;
    private bool flagHasStarRatingsInclude;
    private List< bool > storeStarRatingsInclude;
    private bool flagHasStarRatingsExclude;
    private List< bool > storeStarRatingsExclude;
    private bool flagHasReviewCountMin;
    private bool storeReviewCountMin;
    private bool flagHasReviewCountMax;
    private bool storeReviewCountMax;
    private bool flagHasDollarSignMin;
    private bool storeDollarSignMin;
    private bool flagHasDollarSignMax;
    private bool storeDollarSignMax;
    private bool flagHasDollarSignsInclude;
    private List< bool > storeDollarSignsInclude;
    private bool flagHasDollarSignsExclude;
    private List< bool > storeDollarSignsExclude;
    private bool flagHasCategoriesInclude;
    private List< bool > storeCategoriesInclude;
    private bool flagHasCategoriesExclude;
    private List< bool > storeCategoriesExclude;
    private bool flagHasChainsInclude;
    private List< bool > storeChainsInclude;
    private bool flagHasChainsExclude;
    private List< bool > storeChainsExclude;
    private bool flagHasProductsInclude;
    private List< bool > storeProductsInclude;
    private bool flagHasProductsExclude;
    private List< bool > storeProductsExclude;
    private bool flagHasPlacesInclude;
    private List< bool > storePlacesInclude;
    private bool flagHasPlacesExclude;
    private List< bool > storePlacesExclude;
    private bool flagHasAmenitiesInclude;
    private List< bool > storeAmenitiesInclude;
    private bool flagHasAmenitiesIncludeSupported;
    private List< bool > storeAmenitiesIncludeSupported;
    private bool flagHasAmenitiesIncludeNotSupported;
    private List< bool > storeAmenitiesIncludeNotSupported;
    private bool flagHasAmenitiesExclude;
    private List< bool > storeAmenitiesExclude;
    private bool flagHasAmenitiesExcludeSupported;
    private List< bool > storeAmenitiesExcludeSupported;
    private bool flagHasAmenitiesExcludeNotSupported;
    private List< bool > storeAmenitiesExcludeNotSupported;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONResultCount(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ResultCount of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setResultCount(the_bool);
      }


    private void  fromJSONMapLocation(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MapLocation of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setMapLocation(the_bool);
      }


    private void  fromJSONRadius(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Radius of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setRadius(the_bool);
      }


    private void  fromJSONRadiusUnit(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RadiusUnit of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setRadiusUnit(the_bool);
      }


    private void  fromJSONRadiusInferred(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field RadiusInferred of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setRadiusInferred(the_bool);
      }


    private void  fromJSONAlongTheRoute(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AlongTheRoute of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setAlongTheRoute(the_bool);
      }


    private void  fromJSONOpenHours(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OpenHoursFlagsJSON convert_classy = OpenHoursFlagsJSON.from_json(json_value, ignore_extras, true);
        setOpenHours(convert_classy);
      }


    private void  fromJSONOpenHoursFilterOnHoliday(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field OpenHoursFilterOnHoliday of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setOpenHoursFilterOnHoliday(the_bool);
      }


    private void  fromJSONSortSpecification(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SortSpecification of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_SortSpecification1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field SortSpecification of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_SortSpecification1.Add(the_bool);
          }
        initSortSpecification();
        for (int num1 = 0; num1 < vector_SortSpecification1.Count; ++num1)
            appendSortSpecification(vector_SortSpecification1[num1]);
        for (int num1 = 0; num1 < vector_SortSpecification1.Count; ++num1)
          {
          }
      }


    private void  fromJSONExpensiveFlag(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ExpensiveFlag of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setExpensiveFlag(the_bool);
      }


    private void  fromJSONInexpensiveFlag(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field InexpensiveFlag of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setInexpensiveFlag(the_bool);
      }


    private void  fromJSONStarRatingMin(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StarRatingMin of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setStarRatingMin(the_bool);
      }


    private void  fromJSONStarRatingMax(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StarRatingMax of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setStarRatingMax(the_bool);
      }


    private void  fromJSONStarRatingsInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StarRatingsInclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_StarRatingsInclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field StarRatingsInclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_StarRatingsInclude1.Add(the_bool);
          }
        initStarRatingsInclude();
        for (int num2 = 0; num2 < vector_StarRatingsInclude1.Count; ++num2)
            appendStarRatingsInclude(vector_StarRatingsInclude1[num2]);
        for (int num1 = 0; num1 < vector_StarRatingsInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONStarRatingsExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StarRatingsExclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_StarRatingsExclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field StarRatingsExclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_StarRatingsExclude1.Add(the_bool);
          }
        initStarRatingsExclude();
        for (int num3 = 0; num3 < vector_StarRatingsExclude1.Count; ++num3)
            appendStarRatingsExclude(vector_StarRatingsExclude1[num3]);
        for (int num1 = 0; num1 < vector_StarRatingsExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONReviewCountMin(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ReviewCountMin of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setReviewCountMin(the_bool);
      }


    private void  fromJSONReviewCountMax(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ReviewCountMax of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setReviewCountMax(the_bool);
      }


    private void  fromJSONDollarSignMin(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DollarSignMin of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setDollarSignMin(the_bool);
      }


    private void  fromJSONDollarSignMax(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DollarSignMax of LocalSearchFilterFlagsJSON is not true for false.");
              }
          }
        setDollarSignMax(the_bool);
      }


    private void  fromJSONDollarSignsInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DollarSignsInclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_DollarSignsInclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field DollarSignsInclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_DollarSignsInclude1.Add(the_bool);
          }
        initDollarSignsInclude();
        for (int num4 = 0; num4 < vector_DollarSignsInclude1.Count; ++num4)
            appendDollarSignsInclude(vector_DollarSignsInclude1[num4]);
        for (int num1 = 0; num1 < vector_DollarSignsInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDollarSignsExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DollarSignsExclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_DollarSignsExclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field DollarSignsExclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_DollarSignsExclude1.Add(the_bool);
          }
        initDollarSignsExclude();
        for (int num5 = 0; num5 < vector_DollarSignsExclude1.Count; ++num5)
            appendDollarSignsExclude(vector_DollarSignsExclude1[num5]);
        for (int num1 = 0; num1 < vector_DollarSignsExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCategoriesInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CategoriesInclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_CategoriesInclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field CategoriesInclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_CategoriesInclude1.Add(the_bool);
          }
        initCategoriesInclude();
        for (int num6 = 0; num6 < vector_CategoriesInclude1.Count; ++num6)
            appendCategoriesInclude(vector_CategoriesInclude1[num6]);
        for (int num1 = 0; num1 < vector_CategoriesInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCategoriesExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CategoriesExclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_CategoriesExclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field CategoriesExclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_CategoriesExclude1.Add(the_bool);
          }
        initCategoriesExclude();
        for (int num7 = 0; num7 < vector_CategoriesExclude1.Count; ++num7)
            appendCategoriesExclude(vector_CategoriesExclude1[num7]);
        for (int num1 = 0; num1 < vector_CategoriesExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONChainsInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ChainsInclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_ChainsInclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field ChainsInclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_ChainsInclude1.Add(the_bool);
          }
        initChainsInclude();
        for (int num8 = 0; num8 < vector_ChainsInclude1.Count; ++num8)
            appendChainsInclude(vector_ChainsInclude1[num8]);
        for (int num1 = 0; num1 < vector_ChainsInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONChainsExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ChainsExclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_ChainsExclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field ChainsExclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_ChainsExclude1.Add(the_bool);
          }
        initChainsExclude();
        for (int num9 = 0; num9 < vector_ChainsExclude1.Count; ++num9)
            appendChainsExclude(vector_ChainsExclude1[num9]);
        for (int num1 = 0; num1 < vector_ChainsExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONProductsInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ProductsInclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_ProductsInclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field ProductsInclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_ProductsInclude1.Add(the_bool);
          }
        initProductsInclude();
        for (int num10 = 0; num10 < vector_ProductsInclude1.Count; ++num10)
            appendProductsInclude(vector_ProductsInclude1[num10]);
        for (int num1 = 0; num1 < vector_ProductsInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONProductsExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ProductsExclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_ProductsExclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field ProductsExclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_ProductsExclude1.Add(the_bool);
          }
        initProductsExclude();
        for (int num11 = 0; num11 < vector_ProductsExclude1.Count; ++num11)
            appendProductsExclude(vector_ProductsExclude1[num11]);
        for (int num1 = 0; num1 < vector_ProductsExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPlacesInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PlacesInclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_PlacesInclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field PlacesInclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_PlacesInclude1.Add(the_bool);
          }
        initPlacesInclude();
        for (int num12 = 0; num12 < vector_PlacesInclude1.Count; ++num12)
            appendPlacesInclude(vector_PlacesInclude1[num12]);
        for (int num1 = 0; num1 < vector_PlacesInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPlacesExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PlacesExclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_PlacesExclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field PlacesExclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_PlacesExclude1.Add(the_bool);
          }
        initPlacesExclude();
        for (int num13 = 0; num13 < vector_PlacesExclude1.Count; ++num13)
            appendPlacesExclude(vector_PlacesExclude1[num13]);
        for (int num1 = 0; num1 < vector_PlacesExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesInclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_AmenitiesInclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field AmenitiesInclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_AmenitiesInclude1.Add(the_bool);
          }
        initAmenitiesInclude();
        for (int num14 = 0; num14 < vector_AmenitiesInclude1.Count; ++num14)
            appendAmenitiesInclude(vector_AmenitiesInclude1[num14]);
        for (int num1 = 0; num1 < vector_AmenitiesInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesIncludeSupported(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesIncludeSupported of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_AmenitiesIncludeSupported1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field AmenitiesIncludeSupported of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_AmenitiesIncludeSupported1.Add(the_bool);
          }
        initAmenitiesIncludeSupported();
        for (int num15 = 0; num15 < vector_AmenitiesIncludeSupported1.Count; ++num15)
            appendAmenitiesIncludeSupported(vector_AmenitiesIncludeSupported1[num15]);
        for (int num1 = 0; num1 < vector_AmenitiesIncludeSupported1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesIncludeNotSupported(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesIncludeNotSupported of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_AmenitiesIncludeNotSupported1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field AmenitiesIncludeNotSupported of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_AmenitiesIncludeNotSupported1.Add(the_bool);
          }
        initAmenitiesIncludeNotSupported();
        for (int num16 = 0; num16 < vector_AmenitiesIncludeNotSupported1.Count; ++num16)
            appendAmenitiesIncludeNotSupported(vector_AmenitiesIncludeNotSupported1[num16]);
        for (int num1 = 0; num1 < vector_AmenitiesIncludeNotSupported1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesExclude of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_AmenitiesExclude1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field AmenitiesExclude of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_AmenitiesExclude1.Add(the_bool);
          }
        initAmenitiesExclude();
        for (int num17 = 0; num17 < vector_AmenitiesExclude1.Count; ++num17)
            appendAmenitiesExclude(vector_AmenitiesExclude1[num17]);
        for (int num1 = 0; num1 < vector_AmenitiesExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesExcludeSupported(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesExcludeSupported of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_AmenitiesExcludeSupported1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field AmenitiesExcludeSupported of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_AmenitiesExcludeSupported1.Add(the_bool);
          }
        initAmenitiesExcludeSupported();
        for (int num18 = 0; num18 < vector_AmenitiesExcludeSupported1.Count; ++num18)
            appendAmenitiesExcludeSupported(vector_AmenitiesExcludeSupported1[num18]);
        for (int num1 = 0; num1 < vector_AmenitiesExcludeSupported1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesExcludeNotSupported(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesExcludeNotSupported of LocalSearchFilterFlagsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< bool > vector_AmenitiesExcludeNotSupported1 = new List< bool >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONTrueValue json_true = json_array1.component(num1).true_value();
            bool the_bool;
            if (json_true != null)
              {
                the_bool = true;
              }
            else
              {
                JSONFalseValue json_false = json_array1.component(num1).false_value();
                if (json_false != null)
                  {
                    the_bool = false;
                  }
                else
                  {
                    throw new Exception("The value for an element of field AmenitiesExcludeNotSupported of LocalSearchFilterFlagsJSON is not true for false.");
                  }
              }
            vector_AmenitiesExcludeNotSupported1.Add(the_bool);
          }
        initAmenitiesExcludeNotSupported();
        for (int num19 = 0; num19 < vector_AmenitiesExcludeNotSupported1.Count; ++num19)
            appendAmenitiesExcludeNotSupported(vector_AmenitiesExcludeNotSupported1[num19]);
        for (int num1 = 0; num1 < vector_AmenitiesExcludeNotSupported1.Count; ++num1)
          {
          }
      }


    public LocalSearchFilterFlagsJSON()
      {
        flagHasResultCount = false;
        flagHasMapLocation = false;
        flagHasRadius = false;
        flagHasRadiusUnit = false;
        flagHasRadiusInferred = false;
        flagHasAlongTheRoute = false;
        flagHasOpenHours = false;
        flagHasOpenHoursFilterOnHoliday = false;
        flagHasSortSpecification = false;
        flagHasExpensiveFlag = false;
        flagHasInexpensiveFlag = false;
        flagHasStarRatingMin = false;
        flagHasStarRatingMax = false;
        flagHasStarRatingsInclude = false;
        flagHasStarRatingsExclude = false;
        flagHasReviewCountMin = false;
        flagHasReviewCountMax = false;
        flagHasDollarSignMin = false;
        flagHasDollarSignMax = false;
        flagHasDollarSignsInclude = false;
        flagHasDollarSignsExclude = false;
        flagHasCategoriesInclude = false;
        flagHasCategoriesExclude = false;
        flagHasChainsInclude = false;
        flagHasChainsExclude = false;
        flagHasProductsInclude = false;
        flagHasProductsExclude = false;
        flagHasPlacesInclude = false;
        flagHasPlacesExclude = false;
        flagHasAmenitiesInclude = false;
        flagHasAmenitiesIncludeSupported = false;
        flagHasAmenitiesIncludeNotSupported = false;
        flagHasAmenitiesExclude = false;
        flagHasAmenitiesExcludeSupported = false;
        flagHasAmenitiesExcludeNotSupported = false;
        storeSortSpecification = new List< bool >();
        storeStarRatingsInclude = new List< bool >();
        storeStarRatingsExclude = new List< bool >();
        storeDollarSignsInclude = new List< bool >();
        storeDollarSignsExclude = new List< bool >();
        storeCategoriesInclude = new List< bool >();
        storeCategoriesExclude = new List< bool >();
        storeChainsInclude = new List< bool >();
        storeChainsExclude = new List< bool >();
        storeProductsInclude = new List< bool >();
        storeProductsExclude = new List< bool >();
        storePlacesInclude = new List< bool >();
        storePlacesExclude = new List< bool >();
        storeAmenitiesInclude = new List< bool >();
        storeAmenitiesIncludeSupported = new List< bool >();
        storeAmenitiesIncludeNotSupported = new List< bool >();
        storeAmenitiesExclude = new List< bool >();
        storeAmenitiesExcludeSupported = new List< bool >();
        storeAmenitiesExcludeNotSupported = new List< bool >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasResultCount()
      {
        return flagHasResultCount;
      }

    public bool  getResultCount()
      {
        Debug.Assert(flagHasResultCount);
        return storeResultCount;
      }

    public bool  hasMapLocation()
      {
        return flagHasMapLocation;
      }

    public bool  getMapLocation()
      {
        Debug.Assert(flagHasMapLocation);
        return storeMapLocation;
      }

    public bool  hasRadius()
      {
        return flagHasRadius;
      }

    public bool  getRadius()
      {
        Debug.Assert(flagHasRadius);
        return storeRadius;
      }

    public bool  hasRadiusUnit()
      {
        return flagHasRadiusUnit;
      }

    public bool  getRadiusUnit()
      {
        Debug.Assert(flagHasRadiusUnit);
        return storeRadiusUnit;
      }

    public bool  hasRadiusInferred()
      {
        return flagHasRadiusInferred;
      }

    public bool  getRadiusInferred()
      {
        Debug.Assert(flagHasRadiusInferred);
        return storeRadiusInferred;
      }

    public bool  hasAlongTheRoute()
      {
        return flagHasAlongTheRoute;
      }

    public bool  getAlongTheRoute()
      {
        Debug.Assert(flagHasAlongTheRoute);
        return storeAlongTheRoute;
      }

    public bool  hasOpenHours()
      {
        return flagHasOpenHours;
      }

    public OpenHoursFlagsJSON   getOpenHours()
      {
        Debug.Assert(flagHasOpenHours);
        return storeOpenHours;
      }

    public bool  hasOpenHoursFilterOnHoliday()
      {
        return flagHasOpenHoursFilterOnHoliday;
      }

    public bool  getOpenHoursFilterOnHoliday()
      {
        Debug.Assert(flagHasOpenHoursFilterOnHoliday);
        return storeOpenHoursFilterOnHoliday;
      }

    public bool  hasSortSpecification()
      {
        return flagHasSortSpecification;
      }

    public int  countOfSortSpecification()
      {
        Debug.Assert(flagHasSortSpecification);
        return storeSortSpecification.Count;
      }

    public bool  elementOfSortSpecification(int element_num)
      {
        Debug.Assert(flagHasSortSpecification);
        return storeSortSpecification[element_num];
      }

    public List< bool >  getSortSpecification()
      {
        Debug.Assert(flagHasSortSpecification);
        return storeSortSpecification;
      }

    public bool  hasExpensiveFlag()
      {
        return flagHasExpensiveFlag;
      }

    public bool  getExpensiveFlag()
      {
        Debug.Assert(flagHasExpensiveFlag);
        return storeExpensiveFlag;
      }

    public bool  hasInexpensiveFlag()
      {
        return flagHasInexpensiveFlag;
      }

    public bool  getInexpensiveFlag()
      {
        Debug.Assert(flagHasInexpensiveFlag);
        return storeInexpensiveFlag;
      }

    public bool  hasStarRatingMin()
      {
        return flagHasStarRatingMin;
      }

    public bool  getStarRatingMin()
      {
        Debug.Assert(flagHasStarRatingMin);
        return storeStarRatingMin;
      }

    public bool  hasStarRatingMax()
      {
        return flagHasStarRatingMax;
      }

    public bool  getStarRatingMax()
      {
        Debug.Assert(flagHasStarRatingMax);
        return storeStarRatingMax;
      }

    public bool  hasStarRatingsInclude()
      {
        return flagHasStarRatingsInclude;
      }

    public int  countOfStarRatingsInclude()
      {
        Debug.Assert(flagHasStarRatingsInclude);
        return storeStarRatingsInclude.Count;
      }

    public bool  elementOfStarRatingsInclude(int element_num)
      {
        Debug.Assert(flagHasStarRatingsInclude);
        return storeStarRatingsInclude[element_num];
      }

    public List< bool >  getStarRatingsInclude()
      {
        Debug.Assert(flagHasStarRatingsInclude);
        return storeStarRatingsInclude;
      }

    public bool  hasStarRatingsExclude()
      {
        return flagHasStarRatingsExclude;
      }

    public int  countOfStarRatingsExclude()
      {
        Debug.Assert(flagHasStarRatingsExclude);
        return storeStarRatingsExclude.Count;
      }

    public bool  elementOfStarRatingsExclude(int element_num)
      {
        Debug.Assert(flagHasStarRatingsExclude);
        return storeStarRatingsExclude[element_num];
      }

    public List< bool >  getStarRatingsExclude()
      {
        Debug.Assert(flagHasStarRatingsExclude);
        return storeStarRatingsExclude;
      }

    public bool  hasReviewCountMin()
      {
        return flagHasReviewCountMin;
      }

    public bool  getReviewCountMin()
      {
        Debug.Assert(flagHasReviewCountMin);
        return storeReviewCountMin;
      }

    public bool  hasReviewCountMax()
      {
        return flagHasReviewCountMax;
      }

    public bool  getReviewCountMax()
      {
        Debug.Assert(flagHasReviewCountMax);
        return storeReviewCountMax;
      }

    public bool  hasDollarSignMin()
      {
        return flagHasDollarSignMin;
      }

    public bool  getDollarSignMin()
      {
        Debug.Assert(flagHasDollarSignMin);
        return storeDollarSignMin;
      }

    public bool  hasDollarSignMax()
      {
        return flagHasDollarSignMax;
      }

    public bool  getDollarSignMax()
      {
        Debug.Assert(flagHasDollarSignMax);
        return storeDollarSignMax;
      }

    public bool  hasDollarSignsInclude()
      {
        return flagHasDollarSignsInclude;
      }

    public int  countOfDollarSignsInclude()
      {
        Debug.Assert(flagHasDollarSignsInclude);
        return storeDollarSignsInclude.Count;
      }

    public bool  elementOfDollarSignsInclude(int element_num)
      {
        Debug.Assert(flagHasDollarSignsInclude);
        return storeDollarSignsInclude[element_num];
      }

    public List< bool >  getDollarSignsInclude()
      {
        Debug.Assert(flagHasDollarSignsInclude);
        return storeDollarSignsInclude;
      }

    public bool  hasDollarSignsExclude()
      {
        return flagHasDollarSignsExclude;
      }

    public int  countOfDollarSignsExclude()
      {
        Debug.Assert(flagHasDollarSignsExclude);
        return storeDollarSignsExclude.Count;
      }

    public bool  elementOfDollarSignsExclude(int element_num)
      {
        Debug.Assert(flagHasDollarSignsExclude);
        return storeDollarSignsExclude[element_num];
      }

    public List< bool >  getDollarSignsExclude()
      {
        Debug.Assert(flagHasDollarSignsExclude);
        return storeDollarSignsExclude;
      }

    public bool  hasCategoriesInclude()
      {
        return flagHasCategoriesInclude;
      }

    public int  countOfCategoriesInclude()
      {
        Debug.Assert(flagHasCategoriesInclude);
        return storeCategoriesInclude.Count;
      }

    public bool  elementOfCategoriesInclude(int element_num)
      {
        Debug.Assert(flagHasCategoriesInclude);
        return storeCategoriesInclude[element_num];
      }

    public List< bool >  getCategoriesInclude()
      {
        Debug.Assert(flagHasCategoriesInclude);
        return storeCategoriesInclude;
      }

    public bool  hasCategoriesExclude()
      {
        return flagHasCategoriesExclude;
      }

    public int  countOfCategoriesExclude()
      {
        Debug.Assert(flagHasCategoriesExclude);
        return storeCategoriesExclude.Count;
      }

    public bool  elementOfCategoriesExclude(int element_num)
      {
        Debug.Assert(flagHasCategoriesExclude);
        return storeCategoriesExclude[element_num];
      }

    public List< bool >  getCategoriesExclude()
      {
        Debug.Assert(flagHasCategoriesExclude);
        return storeCategoriesExclude;
      }

    public bool  hasChainsInclude()
      {
        return flagHasChainsInclude;
      }

    public int  countOfChainsInclude()
      {
        Debug.Assert(flagHasChainsInclude);
        return storeChainsInclude.Count;
      }

    public bool  elementOfChainsInclude(int element_num)
      {
        Debug.Assert(flagHasChainsInclude);
        return storeChainsInclude[element_num];
      }

    public List< bool >  getChainsInclude()
      {
        Debug.Assert(flagHasChainsInclude);
        return storeChainsInclude;
      }

    public bool  hasChainsExclude()
      {
        return flagHasChainsExclude;
      }

    public int  countOfChainsExclude()
      {
        Debug.Assert(flagHasChainsExclude);
        return storeChainsExclude.Count;
      }

    public bool  elementOfChainsExclude(int element_num)
      {
        Debug.Assert(flagHasChainsExclude);
        return storeChainsExclude[element_num];
      }

    public List< bool >  getChainsExclude()
      {
        Debug.Assert(flagHasChainsExclude);
        return storeChainsExclude;
      }

    public bool  hasProductsInclude()
      {
        return flagHasProductsInclude;
      }

    public int  countOfProductsInclude()
      {
        Debug.Assert(flagHasProductsInclude);
        return storeProductsInclude.Count;
      }

    public bool  elementOfProductsInclude(int element_num)
      {
        Debug.Assert(flagHasProductsInclude);
        return storeProductsInclude[element_num];
      }

    public List< bool >  getProductsInclude()
      {
        Debug.Assert(flagHasProductsInclude);
        return storeProductsInclude;
      }

    public bool  hasProductsExclude()
      {
        return flagHasProductsExclude;
      }

    public int  countOfProductsExclude()
      {
        Debug.Assert(flagHasProductsExclude);
        return storeProductsExclude.Count;
      }

    public bool  elementOfProductsExclude(int element_num)
      {
        Debug.Assert(flagHasProductsExclude);
        return storeProductsExclude[element_num];
      }

    public List< bool >  getProductsExclude()
      {
        Debug.Assert(flagHasProductsExclude);
        return storeProductsExclude;
      }

    public bool  hasPlacesInclude()
      {
        return flagHasPlacesInclude;
      }

    public int  countOfPlacesInclude()
      {
        Debug.Assert(flagHasPlacesInclude);
        return storePlacesInclude.Count;
      }

    public bool  elementOfPlacesInclude(int element_num)
      {
        Debug.Assert(flagHasPlacesInclude);
        return storePlacesInclude[element_num];
      }

    public List< bool >  getPlacesInclude()
      {
        Debug.Assert(flagHasPlacesInclude);
        return storePlacesInclude;
      }

    public bool  hasPlacesExclude()
      {
        return flagHasPlacesExclude;
      }

    public int  countOfPlacesExclude()
      {
        Debug.Assert(flagHasPlacesExclude);
        return storePlacesExclude.Count;
      }

    public bool  elementOfPlacesExclude(int element_num)
      {
        Debug.Assert(flagHasPlacesExclude);
        return storePlacesExclude[element_num];
      }

    public List< bool >  getPlacesExclude()
      {
        Debug.Assert(flagHasPlacesExclude);
        return storePlacesExclude;
      }

    public bool  hasAmenitiesInclude()
      {
        return flagHasAmenitiesInclude;
      }

    public int  countOfAmenitiesInclude()
      {
        Debug.Assert(flagHasAmenitiesInclude);
        return storeAmenitiesInclude.Count;
      }

    public bool  elementOfAmenitiesInclude(int element_num)
      {
        Debug.Assert(flagHasAmenitiesInclude);
        return storeAmenitiesInclude[element_num];
      }

    public List< bool >  getAmenitiesInclude()
      {
        Debug.Assert(flagHasAmenitiesInclude);
        return storeAmenitiesInclude;
      }

    public bool  hasAmenitiesIncludeSupported()
      {
        return flagHasAmenitiesIncludeSupported;
      }

    public int  countOfAmenitiesIncludeSupported()
      {
        Debug.Assert(flagHasAmenitiesIncludeSupported);
        return storeAmenitiesIncludeSupported.Count;
      }

    public bool  elementOfAmenitiesIncludeSupported(int element_num)
      {
        Debug.Assert(flagHasAmenitiesIncludeSupported);
        return storeAmenitiesIncludeSupported[element_num];
      }

    public List< bool >  getAmenitiesIncludeSupported()
      {
        Debug.Assert(flagHasAmenitiesIncludeSupported);
        return storeAmenitiesIncludeSupported;
      }

    public bool  hasAmenitiesIncludeNotSupported()
      {
        return flagHasAmenitiesIncludeNotSupported;
      }

    public int  countOfAmenitiesIncludeNotSupported()
      {
        Debug.Assert(flagHasAmenitiesIncludeNotSupported);
        return storeAmenitiesIncludeNotSupported.Count;
      }

    public bool  elementOfAmenitiesIncludeNotSupported(int element_num)
      {
        Debug.Assert(flagHasAmenitiesIncludeNotSupported);
        return storeAmenitiesIncludeNotSupported[element_num];
      }

    public List< bool >  getAmenitiesIncludeNotSupported()
      {
        Debug.Assert(flagHasAmenitiesIncludeNotSupported);
        return storeAmenitiesIncludeNotSupported;
      }

    public bool  hasAmenitiesExclude()
      {
        return flagHasAmenitiesExclude;
      }

    public int  countOfAmenitiesExclude()
      {
        Debug.Assert(flagHasAmenitiesExclude);
        return storeAmenitiesExclude.Count;
      }

    public bool  elementOfAmenitiesExclude(int element_num)
      {
        Debug.Assert(flagHasAmenitiesExclude);
        return storeAmenitiesExclude[element_num];
      }

    public List< bool >  getAmenitiesExclude()
      {
        Debug.Assert(flagHasAmenitiesExclude);
        return storeAmenitiesExclude;
      }

    public bool  hasAmenitiesExcludeSupported()
      {
        return flagHasAmenitiesExcludeSupported;
      }

    public int  countOfAmenitiesExcludeSupported()
      {
        Debug.Assert(flagHasAmenitiesExcludeSupported);
        return storeAmenitiesExcludeSupported.Count;
      }

    public bool  elementOfAmenitiesExcludeSupported(int element_num)
      {
        Debug.Assert(flagHasAmenitiesExcludeSupported);
        return storeAmenitiesExcludeSupported[element_num];
      }

    public List< bool >  getAmenitiesExcludeSupported()
      {
        Debug.Assert(flagHasAmenitiesExcludeSupported);
        return storeAmenitiesExcludeSupported;
      }

    public bool  hasAmenitiesExcludeNotSupported()
      {
        return flagHasAmenitiesExcludeNotSupported;
      }

    public int  countOfAmenitiesExcludeNotSupported()
      {
        Debug.Assert(flagHasAmenitiesExcludeNotSupported);
        return storeAmenitiesExcludeNotSupported.Count;
      }

    public bool  elementOfAmenitiesExcludeNotSupported(int element_num)
      {
        Debug.Assert(flagHasAmenitiesExcludeNotSupported);
        return storeAmenitiesExcludeNotSupported[element_num];
      }

    public List< bool >  getAmenitiesExcludeNotSupported()
      {
        Debug.Assert(flagHasAmenitiesExcludeNotSupported);
        return storeAmenitiesExcludeNotSupported;
      }


    public virtual int extraLocalSearchFilterFlagsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraLocalSearchFilterFlagsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraLocalSearchFilterFlagsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraLocalSearchFilterFlagsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setResultCount(bool new_value)
      {
        flagHasResultCount = true;
        storeResultCount = new_value;
      }
    public void unsetResultCount()
      {
        flagHasResultCount = false;
      }
    public void setMapLocation(bool new_value)
      {
        flagHasMapLocation = true;
        storeMapLocation = new_value;
      }
    public void unsetMapLocation()
      {
        flagHasMapLocation = false;
      }
    public void setRadius(bool new_value)
      {
        flagHasRadius = true;
        storeRadius = new_value;
      }
    public void unsetRadius()
      {
        flagHasRadius = false;
      }
    public void setRadiusUnit(bool new_value)
      {
        flagHasRadiusUnit = true;
        storeRadiusUnit = new_value;
      }
    public void unsetRadiusUnit()
      {
        flagHasRadiusUnit = false;
      }
    public void setRadiusInferred(bool new_value)
      {
        flagHasRadiusInferred = true;
        storeRadiusInferred = new_value;
      }
    public void unsetRadiusInferred()
      {
        flagHasRadiusInferred = false;
      }
    public void setAlongTheRoute(bool new_value)
      {
        flagHasAlongTheRoute = true;
        storeAlongTheRoute = new_value;
      }
    public void unsetAlongTheRoute()
      {
        flagHasAlongTheRoute = false;
      }
    public void setOpenHours(OpenHoursFlagsJSON  new_value)
      {
        if (flagHasOpenHours)
          {
          }
        flagHasOpenHours = true;
        storeOpenHours = new_value;
      }
    public void unsetOpenHours()
      {
        if (flagHasOpenHours)
          {
          }
        flagHasOpenHours = false;
      }
    public void setOpenHoursFilterOnHoliday(bool new_value)
      {
        flagHasOpenHoursFilterOnHoliday = true;
        storeOpenHoursFilterOnHoliday = new_value;
      }
    public void unsetOpenHoursFilterOnHoliday()
      {
        flagHasOpenHoursFilterOnHoliday = false;
      }
    public void initSortSpecification()
      {
        flagHasSortSpecification = true;
        storeSortSpecification.Clear();
      }
    public void appendSortSpecification(bool to_append)
      {
        if (!flagHasSortSpecification)
          {
            flagHasSortSpecification = true;
            storeSortSpecification.Clear();
          }
        Debug.Assert(flagHasSortSpecification);
        storeSortSpecification.Add(to_append);
      }
    public void unsetSortSpecification()
      {
        flagHasSortSpecification = false;
        storeSortSpecification.Clear();
      }
    public void setExpensiveFlag(bool new_value)
      {
        flagHasExpensiveFlag = true;
        storeExpensiveFlag = new_value;
      }
    public void unsetExpensiveFlag()
      {
        flagHasExpensiveFlag = false;
      }
    public void setInexpensiveFlag(bool new_value)
      {
        flagHasInexpensiveFlag = true;
        storeInexpensiveFlag = new_value;
      }
    public void unsetInexpensiveFlag()
      {
        flagHasInexpensiveFlag = false;
      }
    public void setStarRatingMin(bool new_value)
      {
        flagHasStarRatingMin = true;
        storeStarRatingMin = new_value;
      }
    public void unsetStarRatingMin()
      {
        flagHasStarRatingMin = false;
      }
    public void setStarRatingMax(bool new_value)
      {
        flagHasStarRatingMax = true;
        storeStarRatingMax = new_value;
      }
    public void unsetStarRatingMax()
      {
        flagHasStarRatingMax = false;
      }
    public void initStarRatingsInclude()
      {
        flagHasStarRatingsInclude = true;
        storeStarRatingsInclude.Clear();
      }
    public void appendStarRatingsInclude(bool to_append)
      {
        if (!flagHasStarRatingsInclude)
          {
            flagHasStarRatingsInclude = true;
            storeStarRatingsInclude.Clear();
          }
        Debug.Assert(flagHasStarRatingsInclude);
        storeStarRatingsInclude.Add(to_append);
      }
    public void unsetStarRatingsInclude()
      {
        flagHasStarRatingsInclude = false;
        storeStarRatingsInclude.Clear();
      }
    public void initStarRatingsExclude()
      {
        flagHasStarRatingsExclude = true;
        storeStarRatingsExclude.Clear();
      }
    public void appendStarRatingsExclude(bool to_append)
      {
        if (!flagHasStarRatingsExclude)
          {
            flagHasStarRatingsExclude = true;
            storeStarRatingsExclude.Clear();
          }
        Debug.Assert(flagHasStarRatingsExclude);
        storeStarRatingsExclude.Add(to_append);
      }
    public void unsetStarRatingsExclude()
      {
        flagHasStarRatingsExclude = false;
        storeStarRatingsExclude.Clear();
      }
    public void setReviewCountMin(bool new_value)
      {
        flagHasReviewCountMin = true;
        storeReviewCountMin = new_value;
      }
    public void unsetReviewCountMin()
      {
        flagHasReviewCountMin = false;
      }
    public void setReviewCountMax(bool new_value)
      {
        flagHasReviewCountMax = true;
        storeReviewCountMax = new_value;
      }
    public void unsetReviewCountMax()
      {
        flagHasReviewCountMax = false;
      }
    public void setDollarSignMin(bool new_value)
      {
        flagHasDollarSignMin = true;
        storeDollarSignMin = new_value;
      }
    public void unsetDollarSignMin()
      {
        flagHasDollarSignMin = false;
      }
    public void setDollarSignMax(bool new_value)
      {
        flagHasDollarSignMax = true;
        storeDollarSignMax = new_value;
      }
    public void unsetDollarSignMax()
      {
        flagHasDollarSignMax = false;
      }
    public void initDollarSignsInclude()
      {
        flagHasDollarSignsInclude = true;
        storeDollarSignsInclude.Clear();
      }
    public void appendDollarSignsInclude(bool to_append)
      {
        if (!flagHasDollarSignsInclude)
          {
            flagHasDollarSignsInclude = true;
            storeDollarSignsInclude.Clear();
          }
        Debug.Assert(flagHasDollarSignsInclude);
        storeDollarSignsInclude.Add(to_append);
      }
    public void unsetDollarSignsInclude()
      {
        flagHasDollarSignsInclude = false;
        storeDollarSignsInclude.Clear();
      }
    public void initDollarSignsExclude()
      {
        flagHasDollarSignsExclude = true;
        storeDollarSignsExclude.Clear();
      }
    public void appendDollarSignsExclude(bool to_append)
      {
        if (!flagHasDollarSignsExclude)
          {
            flagHasDollarSignsExclude = true;
            storeDollarSignsExclude.Clear();
          }
        Debug.Assert(flagHasDollarSignsExclude);
        storeDollarSignsExclude.Add(to_append);
      }
    public void unsetDollarSignsExclude()
      {
        flagHasDollarSignsExclude = false;
        storeDollarSignsExclude.Clear();
      }
    public void initCategoriesInclude()
      {
        flagHasCategoriesInclude = true;
        storeCategoriesInclude.Clear();
      }
    public void appendCategoriesInclude(bool to_append)
      {
        if (!flagHasCategoriesInclude)
          {
            flagHasCategoriesInclude = true;
            storeCategoriesInclude.Clear();
          }
        Debug.Assert(flagHasCategoriesInclude);
        storeCategoriesInclude.Add(to_append);
      }
    public void unsetCategoriesInclude()
      {
        flagHasCategoriesInclude = false;
        storeCategoriesInclude.Clear();
      }
    public void initCategoriesExclude()
      {
        flagHasCategoriesExclude = true;
        storeCategoriesExclude.Clear();
      }
    public void appendCategoriesExclude(bool to_append)
      {
        if (!flagHasCategoriesExclude)
          {
            flagHasCategoriesExclude = true;
            storeCategoriesExclude.Clear();
          }
        Debug.Assert(flagHasCategoriesExclude);
        storeCategoriesExclude.Add(to_append);
      }
    public void unsetCategoriesExclude()
      {
        flagHasCategoriesExclude = false;
        storeCategoriesExclude.Clear();
      }
    public void initChainsInclude()
      {
        flagHasChainsInclude = true;
        storeChainsInclude.Clear();
      }
    public void appendChainsInclude(bool to_append)
      {
        if (!flagHasChainsInclude)
          {
            flagHasChainsInclude = true;
            storeChainsInclude.Clear();
          }
        Debug.Assert(flagHasChainsInclude);
        storeChainsInclude.Add(to_append);
      }
    public void unsetChainsInclude()
      {
        flagHasChainsInclude = false;
        storeChainsInclude.Clear();
      }
    public void initChainsExclude()
      {
        flagHasChainsExclude = true;
        storeChainsExclude.Clear();
      }
    public void appendChainsExclude(bool to_append)
      {
        if (!flagHasChainsExclude)
          {
            flagHasChainsExclude = true;
            storeChainsExclude.Clear();
          }
        Debug.Assert(flagHasChainsExclude);
        storeChainsExclude.Add(to_append);
      }
    public void unsetChainsExclude()
      {
        flagHasChainsExclude = false;
        storeChainsExclude.Clear();
      }
    public void initProductsInclude()
      {
        flagHasProductsInclude = true;
        storeProductsInclude.Clear();
      }
    public void appendProductsInclude(bool to_append)
      {
        if (!flagHasProductsInclude)
          {
            flagHasProductsInclude = true;
            storeProductsInclude.Clear();
          }
        Debug.Assert(flagHasProductsInclude);
        storeProductsInclude.Add(to_append);
      }
    public void unsetProductsInclude()
      {
        flagHasProductsInclude = false;
        storeProductsInclude.Clear();
      }
    public void initProductsExclude()
      {
        flagHasProductsExclude = true;
        storeProductsExclude.Clear();
      }
    public void appendProductsExclude(bool to_append)
      {
        if (!flagHasProductsExclude)
          {
            flagHasProductsExclude = true;
            storeProductsExclude.Clear();
          }
        Debug.Assert(flagHasProductsExclude);
        storeProductsExclude.Add(to_append);
      }
    public void unsetProductsExclude()
      {
        flagHasProductsExclude = false;
        storeProductsExclude.Clear();
      }
    public void initPlacesInclude()
      {
        flagHasPlacesInclude = true;
        storePlacesInclude.Clear();
      }
    public void appendPlacesInclude(bool to_append)
      {
        if (!flagHasPlacesInclude)
          {
            flagHasPlacesInclude = true;
            storePlacesInclude.Clear();
          }
        Debug.Assert(flagHasPlacesInclude);
        storePlacesInclude.Add(to_append);
      }
    public void unsetPlacesInclude()
      {
        flagHasPlacesInclude = false;
        storePlacesInclude.Clear();
      }
    public void initPlacesExclude()
      {
        flagHasPlacesExclude = true;
        storePlacesExclude.Clear();
      }
    public void appendPlacesExclude(bool to_append)
      {
        if (!flagHasPlacesExclude)
          {
            flagHasPlacesExclude = true;
            storePlacesExclude.Clear();
          }
        Debug.Assert(flagHasPlacesExclude);
        storePlacesExclude.Add(to_append);
      }
    public void unsetPlacesExclude()
      {
        flagHasPlacesExclude = false;
        storePlacesExclude.Clear();
      }
    public void initAmenitiesInclude()
      {
        flagHasAmenitiesInclude = true;
        storeAmenitiesInclude.Clear();
      }
    public void appendAmenitiesInclude(bool to_append)
      {
        if (!flagHasAmenitiesInclude)
          {
            flagHasAmenitiesInclude = true;
            storeAmenitiesInclude.Clear();
          }
        Debug.Assert(flagHasAmenitiesInclude);
        storeAmenitiesInclude.Add(to_append);
      }
    public void unsetAmenitiesInclude()
      {
        flagHasAmenitiesInclude = false;
        storeAmenitiesInclude.Clear();
      }
    public void initAmenitiesIncludeSupported()
      {
        flagHasAmenitiesIncludeSupported = true;
        storeAmenitiesIncludeSupported.Clear();
      }
    public void appendAmenitiesIncludeSupported(bool to_append)
      {
        if (!flagHasAmenitiesIncludeSupported)
          {
            flagHasAmenitiesIncludeSupported = true;
            storeAmenitiesIncludeSupported.Clear();
          }
        Debug.Assert(flagHasAmenitiesIncludeSupported);
        storeAmenitiesIncludeSupported.Add(to_append);
      }
    public void unsetAmenitiesIncludeSupported()
      {
        flagHasAmenitiesIncludeSupported = false;
        storeAmenitiesIncludeSupported.Clear();
      }
    public void initAmenitiesIncludeNotSupported()
      {
        flagHasAmenitiesIncludeNotSupported = true;
        storeAmenitiesIncludeNotSupported.Clear();
      }
    public void appendAmenitiesIncludeNotSupported(bool to_append)
      {
        if (!flagHasAmenitiesIncludeNotSupported)
          {
            flagHasAmenitiesIncludeNotSupported = true;
            storeAmenitiesIncludeNotSupported.Clear();
          }
        Debug.Assert(flagHasAmenitiesIncludeNotSupported);
        storeAmenitiesIncludeNotSupported.Add(to_append);
      }
    public void unsetAmenitiesIncludeNotSupported()
      {
        flagHasAmenitiesIncludeNotSupported = false;
        storeAmenitiesIncludeNotSupported.Clear();
      }
    public void initAmenitiesExclude()
      {
        flagHasAmenitiesExclude = true;
        storeAmenitiesExclude.Clear();
      }
    public void appendAmenitiesExclude(bool to_append)
      {
        if (!flagHasAmenitiesExclude)
          {
            flagHasAmenitiesExclude = true;
            storeAmenitiesExclude.Clear();
          }
        Debug.Assert(flagHasAmenitiesExclude);
        storeAmenitiesExclude.Add(to_append);
      }
    public void unsetAmenitiesExclude()
      {
        flagHasAmenitiesExclude = false;
        storeAmenitiesExclude.Clear();
      }
    public void initAmenitiesExcludeSupported()
      {
        flagHasAmenitiesExcludeSupported = true;
        storeAmenitiesExcludeSupported.Clear();
      }
    public void appendAmenitiesExcludeSupported(bool to_append)
      {
        if (!flagHasAmenitiesExcludeSupported)
          {
            flagHasAmenitiesExcludeSupported = true;
            storeAmenitiesExcludeSupported.Clear();
          }
        Debug.Assert(flagHasAmenitiesExcludeSupported);
        storeAmenitiesExcludeSupported.Add(to_append);
      }
    public void unsetAmenitiesExcludeSupported()
      {
        flagHasAmenitiesExcludeSupported = false;
        storeAmenitiesExcludeSupported.Clear();
      }
    public void initAmenitiesExcludeNotSupported()
      {
        flagHasAmenitiesExcludeNotSupported = true;
        storeAmenitiesExcludeNotSupported.Clear();
      }
    public void appendAmenitiesExcludeNotSupported(bool to_append)
      {
        if (!flagHasAmenitiesExcludeNotSupported)
          {
            flagHasAmenitiesExcludeNotSupported = true;
            storeAmenitiesExcludeNotSupported.Clear();
          }
        Debug.Assert(flagHasAmenitiesExcludeNotSupported);
        storeAmenitiesExcludeNotSupported.Add(to_append);
      }
    public void unsetAmenitiesExcludeNotSupported()
      {
        flagHasAmenitiesExcludeNotSupported = false;
        storeAmenitiesExcludeNotSupported.Clear();
      }

    public virtual void extraLocalSearchFilterFlagsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraLocalSearchFilterFlagsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraLocalSearchFilterFlagsLookup(key);
        if (old_field == null)
          {
            extraLocalSearchFilterFlagsAppendPair(key, new_component);
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
        if (flagHasResultCount)
          {
            handler.start_pair("ResultCount");
            handler.boolean_value(storeResultCount);
          }
        if (flagHasMapLocation)
          {
            handler.start_pair("MapLocation");
            handler.boolean_value(storeMapLocation);
          }
        if (flagHasRadius)
          {
            handler.start_pair("Radius");
            handler.boolean_value(storeRadius);
          }
        if (flagHasRadiusUnit)
          {
            handler.start_pair("RadiusUnit");
            handler.boolean_value(storeRadiusUnit);
          }
        if (flagHasRadiusInferred)
          {
            handler.start_pair("RadiusInferred");
            handler.boolean_value(storeRadiusInferred);
          }
        if (flagHasAlongTheRoute)
          {
            handler.start_pair("AlongTheRoute");
            handler.boolean_value(storeAlongTheRoute);
          }
        if (flagHasOpenHours)
          {
            handler.start_pair("OpenHours");
            if (partial_allowed)
                storeOpenHours.write_partial_as_json(handler);
            else
                storeOpenHours.write_as_json(handler);
          }
        if (flagHasOpenHoursFilterOnHoliday)
          {
            handler.start_pair("OpenHoursFilterOnHoliday");
            handler.boolean_value(storeOpenHoursFilterOnHoliday);
          }
        if (flagHasSortSpecification)
          {
            handler.start_pair("SortSpecification");
            handler.start_array();
            for (int num1 = 0; num1 < storeSortSpecification.Count; ++num1)
              {
                handler.boolean_value(storeSortSpecification[num1]);
              }
            handler.finish_array();
          }
        if (flagHasExpensiveFlag)
          {
            handler.start_pair("ExpensiveFlag");
            handler.boolean_value(storeExpensiveFlag);
          }
        if (flagHasInexpensiveFlag)
          {
            handler.start_pair("InexpensiveFlag");
            handler.boolean_value(storeInexpensiveFlag);
          }
        if (flagHasStarRatingMin)
          {
            handler.start_pair("StarRatingMin");
            handler.boolean_value(storeStarRatingMin);
          }
        if (flagHasStarRatingMax)
          {
            handler.start_pair("StarRatingMax");
            handler.boolean_value(storeStarRatingMax);
          }
        if (flagHasStarRatingsInclude)
          {
            handler.start_pair("StarRatingsInclude");
            handler.start_array();
            for (int num2 = 0; num2 < storeStarRatingsInclude.Count; ++num2)
              {
                handler.boolean_value(storeStarRatingsInclude[num2]);
              }
            handler.finish_array();
          }
        if (flagHasStarRatingsExclude)
          {
            handler.start_pair("StarRatingsExclude");
            handler.start_array();
            for (int num3 = 0; num3 < storeStarRatingsExclude.Count; ++num3)
              {
                handler.boolean_value(storeStarRatingsExclude[num3]);
              }
            handler.finish_array();
          }
        if (flagHasReviewCountMin)
          {
            handler.start_pair("ReviewCountMin");
            handler.boolean_value(storeReviewCountMin);
          }
        if (flagHasReviewCountMax)
          {
            handler.start_pair("ReviewCountMax");
            handler.boolean_value(storeReviewCountMax);
          }
        if (flagHasDollarSignMin)
          {
            handler.start_pair("DollarSignMin");
            handler.boolean_value(storeDollarSignMin);
          }
        if (flagHasDollarSignMax)
          {
            handler.start_pair("DollarSignMax");
            handler.boolean_value(storeDollarSignMax);
          }
        if (flagHasDollarSignsInclude)
          {
            handler.start_pair("DollarSignsInclude");
            handler.start_array();
            for (int num4 = 0; num4 < storeDollarSignsInclude.Count; ++num4)
              {
                handler.boolean_value(storeDollarSignsInclude[num4]);
              }
            handler.finish_array();
          }
        if (flagHasDollarSignsExclude)
          {
            handler.start_pair("DollarSignsExclude");
            handler.start_array();
            for (int num5 = 0; num5 < storeDollarSignsExclude.Count; ++num5)
              {
                handler.boolean_value(storeDollarSignsExclude[num5]);
              }
            handler.finish_array();
          }
        if (flagHasCategoriesInclude)
          {
            handler.start_pair("CategoriesInclude");
            handler.start_array();
            for (int num6 = 0; num6 < storeCategoriesInclude.Count; ++num6)
              {
                handler.boolean_value(storeCategoriesInclude[num6]);
              }
            handler.finish_array();
          }
        if (flagHasCategoriesExclude)
          {
            handler.start_pair("CategoriesExclude");
            handler.start_array();
            for (int num7 = 0; num7 < storeCategoriesExclude.Count; ++num7)
              {
                handler.boolean_value(storeCategoriesExclude[num7]);
              }
            handler.finish_array();
          }
        if (flagHasChainsInclude)
          {
            handler.start_pair("ChainsInclude");
            handler.start_array();
            for (int num8 = 0; num8 < storeChainsInclude.Count; ++num8)
              {
                handler.boolean_value(storeChainsInclude[num8]);
              }
            handler.finish_array();
          }
        if (flagHasChainsExclude)
          {
            handler.start_pair("ChainsExclude");
            handler.start_array();
            for (int num9 = 0; num9 < storeChainsExclude.Count; ++num9)
              {
                handler.boolean_value(storeChainsExclude[num9]);
              }
            handler.finish_array();
          }
        if (flagHasProductsInclude)
          {
            handler.start_pair("ProductsInclude");
            handler.start_array();
            for (int num10 = 0; num10 < storeProductsInclude.Count; ++num10)
              {
                handler.boolean_value(storeProductsInclude[num10]);
              }
            handler.finish_array();
          }
        if (flagHasProductsExclude)
          {
            handler.start_pair("ProductsExclude");
            handler.start_array();
            for (int num11 = 0; num11 < storeProductsExclude.Count; ++num11)
              {
                handler.boolean_value(storeProductsExclude[num11]);
              }
            handler.finish_array();
          }
        if (flagHasPlacesInclude)
          {
            handler.start_pair("PlacesInclude");
            handler.start_array();
            for (int num12 = 0; num12 < storePlacesInclude.Count; ++num12)
              {
                handler.boolean_value(storePlacesInclude[num12]);
              }
            handler.finish_array();
          }
        if (flagHasPlacesExclude)
          {
            handler.start_pair("PlacesExclude");
            handler.start_array();
            for (int num13 = 0; num13 < storePlacesExclude.Count; ++num13)
              {
                handler.boolean_value(storePlacesExclude[num13]);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesInclude)
          {
            handler.start_pair("AmenitiesInclude");
            handler.start_array();
            for (int num14 = 0; num14 < storeAmenitiesInclude.Count; ++num14)
              {
                handler.boolean_value(storeAmenitiesInclude[num14]);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesIncludeSupported)
          {
            handler.start_pair("AmenitiesIncludeSupported");
            handler.start_array();
            for (int num15 = 0; num15 < storeAmenitiesIncludeSupported.Count; ++num15)
              {
                handler.boolean_value(storeAmenitiesIncludeSupported[num15]);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesIncludeNotSupported)
          {
            handler.start_pair("AmenitiesIncludeNotSupported");
            handler.start_array();
            for (int num16 = 0; num16 < storeAmenitiesIncludeNotSupported.Count; ++num16)
              {
                handler.boolean_value(storeAmenitiesIncludeNotSupported[num16]);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesExclude)
          {
            handler.start_pair("AmenitiesExclude");
            handler.start_array();
            for (int num17 = 0; num17 < storeAmenitiesExclude.Count; ++num17)
              {
                handler.boolean_value(storeAmenitiesExclude[num17]);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesExcludeSupported)
          {
            handler.start_pair("AmenitiesExcludeSupported");
            handler.start_array();
            for (int num18 = 0; num18 < storeAmenitiesExcludeSupported.Count; ++num18)
              {
                handler.boolean_value(storeAmenitiesExcludeSupported[num18]);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesExcludeNotSupported)
          {
            handler.start_pair("AmenitiesExcludeNotSupported");
            handler.start_array();
            for (int num19 = 0; num19 < storeAmenitiesExcludeNotSupported.Count; ++num19)
              {
                handler.boolean_value(storeAmenitiesExcludeNotSupported[num19]);
              }
            handler.finish_array();
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

    public static LocalSearchFilterFlagsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalSearchFilterFlagsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchFilterFlags", ignore_extras);
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
    public static LocalSearchFilterFlagsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocalSearchFilterFlagsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalSearchFilterFlagsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchFilterFlags", ignore_extras);
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
    public static LocalSearchFilterFlagsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocalSearchFilterFlagsJSON from_text(string text, bool ignore_extras)
      {
        LocalSearchFilterFlagsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchFilterFlags", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LocalSearchFilterFlagsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static LocalSearchFilterFlagsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LocalSearchFilterFlagsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchFilterFlags", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorResultCount;
        private JSONHoldingBooleanGenerator fieldGeneratorMapLocation;
        private JSONHoldingBooleanGenerator fieldGeneratorRadius;
        private JSONHoldingBooleanGenerator fieldGeneratorRadiusUnit;
        private JSONHoldingBooleanGenerator fieldGeneratorRadiusInferred;
        private JSONHoldingBooleanGenerator fieldGeneratorAlongTheRoute;
        private OpenHoursFlagsJSON.HoldingGenerator fieldGeneratorOpenHours;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenHoursFilterOnHoliday;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorSortSpecification;
        private JSONHoldingBooleanGenerator fieldGeneratorExpensiveFlag;
        private JSONHoldingBooleanGenerator fieldGeneratorInexpensiveFlag;
        private JSONHoldingBooleanGenerator fieldGeneratorStarRatingMin;
        private JSONHoldingBooleanGenerator fieldGeneratorStarRatingMax;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorStarRatingsInclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorStarRatingsExclude;
        private JSONHoldingBooleanGenerator fieldGeneratorReviewCountMin;
        private JSONHoldingBooleanGenerator fieldGeneratorReviewCountMax;
        private JSONHoldingBooleanGenerator fieldGeneratorDollarSignMin;
        private JSONHoldingBooleanGenerator fieldGeneratorDollarSignMax;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorDollarSignsInclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorDollarSignsExclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorCategoriesInclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorCategoriesExclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorChainsInclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorChainsExclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorProductsInclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorProductsExclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorPlacesInclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorPlacesExclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorAmenitiesInclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorAmenitiesIncludeSupported;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorAmenitiesIncludeNotSupported;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorAmenitiesExclude;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorAmenitiesExcludeSupported;
        private JSONHoldingBooleanArrayGenerator fieldGeneratorAmenitiesExcludeNotSupported;
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
            LocalSearchFilterFlagsJSON result = new LocalSearchFilterFlagsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLocalSearchFilterFlagsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(LocalSearchFilterFlagsJSON result)
          {
            if (fieldGeneratorResultCount.have_value)
              {
                result.setResultCount(fieldGeneratorResultCount.value);
                fieldGeneratorResultCount.have_value = false;
              }
            if (fieldGeneratorMapLocation.have_value)
              {
                result.setMapLocation(fieldGeneratorMapLocation.value);
                fieldGeneratorMapLocation.have_value = false;
              }
            if (fieldGeneratorRadius.have_value)
              {
                result.setRadius(fieldGeneratorRadius.value);
                fieldGeneratorRadius.have_value = false;
              }
            if (fieldGeneratorRadiusUnit.have_value)
              {
                result.setRadiusUnit(fieldGeneratorRadiusUnit.value);
                fieldGeneratorRadiusUnit.have_value = false;
              }
            if (fieldGeneratorRadiusInferred.have_value)
              {
                result.setRadiusInferred(fieldGeneratorRadiusInferred.value);
                fieldGeneratorRadiusInferred.have_value = false;
              }
            if (fieldGeneratorAlongTheRoute.have_value)
              {
                result.setAlongTheRoute(fieldGeneratorAlongTheRoute.value);
                fieldGeneratorAlongTheRoute.have_value = false;
              }
            if (fieldGeneratorOpenHours.have_value)
              {
                result.setOpenHours(fieldGeneratorOpenHours.value);
                fieldGeneratorOpenHours.have_value = false;
              }
            if (fieldGeneratorOpenHoursFilterOnHoliday.have_value)
              {
                result.setOpenHoursFilterOnHoliday(fieldGeneratorOpenHoursFilterOnHoliday.value);
                fieldGeneratorOpenHoursFilterOnHoliday.have_value = false;
              }
            if (fieldGeneratorSortSpecification.have_value)
              {
                result.initSortSpecification();
                int count = fieldGeneratorSortSpecification.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSortSpecification(fieldGeneratorSortSpecification.value[num]);
                  }
                fieldGeneratorSortSpecification.value.Clear();
                fieldGeneratorSortSpecification.have_value = false;
              }
            if (fieldGeneratorExpensiveFlag.have_value)
              {
                result.setExpensiveFlag(fieldGeneratorExpensiveFlag.value);
                fieldGeneratorExpensiveFlag.have_value = false;
              }
            if (fieldGeneratorInexpensiveFlag.have_value)
              {
                result.setInexpensiveFlag(fieldGeneratorInexpensiveFlag.value);
                fieldGeneratorInexpensiveFlag.have_value = false;
              }
            if (fieldGeneratorStarRatingMin.have_value)
              {
                result.setStarRatingMin(fieldGeneratorStarRatingMin.value);
                fieldGeneratorStarRatingMin.have_value = false;
              }
            if (fieldGeneratorStarRatingMax.have_value)
              {
                result.setStarRatingMax(fieldGeneratorStarRatingMax.value);
                fieldGeneratorStarRatingMax.have_value = false;
              }
            if (fieldGeneratorStarRatingsInclude.have_value)
              {
                result.initStarRatingsInclude();
                int count = fieldGeneratorStarRatingsInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStarRatingsInclude(fieldGeneratorStarRatingsInclude.value[num]);
                  }
                fieldGeneratorStarRatingsInclude.value.Clear();
                fieldGeneratorStarRatingsInclude.have_value = false;
              }
            if (fieldGeneratorStarRatingsExclude.have_value)
              {
                result.initStarRatingsExclude();
                int count = fieldGeneratorStarRatingsExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStarRatingsExclude(fieldGeneratorStarRatingsExclude.value[num]);
                  }
                fieldGeneratorStarRatingsExclude.value.Clear();
                fieldGeneratorStarRatingsExclude.have_value = false;
              }
            if (fieldGeneratorReviewCountMin.have_value)
              {
                result.setReviewCountMin(fieldGeneratorReviewCountMin.value);
                fieldGeneratorReviewCountMin.have_value = false;
              }
            if (fieldGeneratorReviewCountMax.have_value)
              {
                result.setReviewCountMax(fieldGeneratorReviewCountMax.value);
                fieldGeneratorReviewCountMax.have_value = false;
              }
            if (fieldGeneratorDollarSignMin.have_value)
              {
                result.setDollarSignMin(fieldGeneratorDollarSignMin.value);
                fieldGeneratorDollarSignMin.have_value = false;
              }
            if (fieldGeneratorDollarSignMax.have_value)
              {
                result.setDollarSignMax(fieldGeneratorDollarSignMax.value);
                fieldGeneratorDollarSignMax.have_value = false;
              }
            if (fieldGeneratorDollarSignsInclude.have_value)
              {
                result.initDollarSignsInclude();
                int count = fieldGeneratorDollarSignsInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDollarSignsInclude(fieldGeneratorDollarSignsInclude.value[num]);
                  }
                fieldGeneratorDollarSignsInclude.value.Clear();
                fieldGeneratorDollarSignsInclude.have_value = false;
              }
            if (fieldGeneratorDollarSignsExclude.have_value)
              {
                result.initDollarSignsExclude();
                int count = fieldGeneratorDollarSignsExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDollarSignsExclude(fieldGeneratorDollarSignsExclude.value[num]);
                  }
                fieldGeneratorDollarSignsExclude.value.Clear();
                fieldGeneratorDollarSignsExclude.have_value = false;
              }
            if (fieldGeneratorCategoriesInclude.have_value)
              {
                result.initCategoriesInclude();
                int count = fieldGeneratorCategoriesInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCategoriesInclude(fieldGeneratorCategoriesInclude.value[num]);
                  }
                fieldGeneratorCategoriesInclude.value.Clear();
                fieldGeneratorCategoriesInclude.have_value = false;
              }
            if (fieldGeneratorCategoriesExclude.have_value)
              {
                result.initCategoriesExclude();
                int count = fieldGeneratorCategoriesExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendCategoriesExclude(fieldGeneratorCategoriesExclude.value[num]);
                  }
                fieldGeneratorCategoriesExclude.value.Clear();
                fieldGeneratorCategoriesExclude.have_value = false;
              }
            if (fieldGeneratorChainsInclude.have_value)
              {
                result.initChainsInclude();
                int count = fieldGeneratorChainsInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendChainsInclude(fieldGeneratorChainsInclude.value[num]);
                  }
                fieldGeneratorChainsInclude.value.Clear();
                fieldGeneratorChainsInclude.have_value = false;
              }
            if (fieldGeneratorChainsExclude.have_value)
              {
                result.initChainsExclude();
                int count = fieldGeneratorChainsExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendChainsExclude(fieldGeneratorChainsExclude.value[num]);
                  }
                fieldGeneratorChainsExclude.value.Clear();
                fieldGeneratorChainsExclude.have_value = false;
              }
            if (fieldGeneratorProductsInclude.have_value)
              {
                result.initProductsInclude();
                int count = fieldGeneratorProductsInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendProductsInclude(fieldGeneratorProductsInclude.value[num]);
                  }
                fieldGeneratorProductsInclude.value.Clear();
                fieldGeneratorProductsInclude.have_value = false;
              }
            if (fieldGeneratorProductsExclude.have_value)
              {
                result.initProductsExclude();
                int count = fieldGeneratorProductsExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendProductsExclude(fieldGeneratorProductsExclude.value[num]);
                  }
                fieldGeneratorProductsExclude.value.Clear();
                fieldGeneratorProductsExclude.have_value = false;
              }
            if (fieldGeneratorPlacesInclude.have_value)
              {
                result.initPlacesInclude();
                int count = fieldGeneratorPlacesInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPlacesInclude(fieldGeneratorPlacesInclude.value[num]);
                  }
                fieldGeneratorPlacesInclude.value.Clear();
                fieldGeneratorPlacesInclude.have_value = false;
              }
            if (fieldGeneratorPlacesExclude.have_value)
              {
                result.initPlacesExclude();
                int count = fieldGeneratorPlacesExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPlacesExclude(fieldGeneratorPlacesExclude.value[num]);
                  }
                fieldGeneratorPlacesExclude.value.Clear();
                fieldGeneratorPlacesExclude.have_value = false;
              }
            if (fieldGeneratorAmenitiesInclude.have_value)
              {
                result.initAmenitiesInclude();
                int count = fieldGeneratorAmenitiesInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAmenitiesInclude(fieldGeneratorAmenitiesInclude.value[num]);
                  }
                fieldGeneratorAmenitiesInclude.value.Clear();
                fieldGeneratorAmenitiesInclude.have_value = false;
              }
            if (fieldGeneratorAmenitiesIncludeSupported.have_value)
              {
                result.initAmenitiesIncludeSupported();
                int count = fieldGeneratorAmenitiesIncludeSupported.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAmenitiesIncludeSupported(fieldGeneratorAmenitiesIncludeSupported.value[num]);
                  }
                fieldGeneratorAmenitiesIncludeSupported.value.Clear();
                fieldGeneratorAmenitiesIncludeSupported.have_value = false;
              }
            if (fieldGeneratorAmenitiesIncludeNotSupported.have_value)
              {
                result.initAmenitiesIncludeNotSupported();
                int count = fieldGeneratorAmenitiesIncludeNotSupported.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAmenitiesIncludeNotSupported(fieldGeneratorAmenitiesIncludeNotSupported.value[num]);
                  }
                fieldGeneratorAmenitiesIncludeNotSupported.value.Clear();
                fieldGeneratorAmenitiesIncludeNotSupported.have_value = false;
              }
            if (fieldGeneratorAmenitiesExclude.have_value)
              {
                result.initAmenitiesExclude();
                int count = fieldGeneratorAmenitiesExclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAmenitiesExclude(fieldGeneratorAmenitiesExclude.value[num]);
                  }
                fieldGeneratorAmenitiesExclude.value.Clear();
                fieldGeneratorAmenitiesExclude.have_value = false;
              }
            if (fieldGeneratorAmenitiesExcludeSupported.have_value)
              {
                result.initAmenitiesExcludeSupported();
                int count = fieldGeneratorAmenitiesExcludeSupported.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAmenitiesExcludeSupported(fieldGeneratorAmenitiesExcludeSupported.value[num]);
                  }
                fieldGeneratorAmenitiesExcludeSupported.value.Clear();
                fieldGeneratorAmenitiesExcludeSupported.have_value = false;
              }
            if (fieldGeneratorAmenitiesExcludeNotSupported.have_value)
              {
                result.initAmenitiesExcludeNotSupported();
                int count = fieldGeneratorAmenitiesExcludeNotSupported.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAmenitiesExcludeNotSupported(fieldGeneratorAmenitiesExcludeNotSupported.value[num]);
                  }
                fieldGeneratorAmenitiesExcludeNotSupported.value.Clear();
                fieldGeneratorAmenitiesExcludeNotSupported.have_value = false;
              }
          }
        protected abstract void handle_result(LocalSearchFilterFlagsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "ongTheRoute", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorAlongTheRoute;
                            break;
                        case 'm':
                            if (String.Compare(field_name, 2, "enities", 0, 7, false) == 0)
                              {
                                switch (field_name[9])
                                  {
                                    case 'E':
                                        if (String.Compare(field_name, 10, "xclude", 0, 6, false) == 0)
                                          {
                                            if (field_name.Length == 16)
                                              {
                                                return fieldGeneratorAmenitiesExclude;
                                              }
                                            switch (field_name[16])
                                              {
                                                case 'N':
                                                    if ((String.Compare(field_name, 17, "otSupported", 0, 11, false) == 0) && (field_name.Length == 28))
                                                        return fieldGeneratorAmenitiesExcludeNotSupported;
                                                    break;
                                                case 'S':
                                                    if ((String.Compare(field_name, 17, "upported", 0, 8, false) == 0) && (field_name.Length == 25))
                                                        return fieldGeneratorAmenitiesExcludeSupported;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'I':
                                        if (String.Compare(field_name, 10, "nclude", 0, 6, false) == 0)
                                          {
                                            if (field_name.Length == 16)
                                              {
                                                return fieldGeneratorAmenitiesInclude;
                                              }
                                            switch (field_name[16])
                                              {
                                                case 'N':
                                                    if ((String.Compare(field_name, 17, "otSupported", 0, 11, false) == 0) && (field_name.Length == 28))
                                                        return fieldGeneratorAmenitiesIncludeNotSupported;
                                                    break;
                                                case 'S':
                                                    if ((String.Compare(field_name, 17, "upported", 0, 8, false) == 0) && (field_name.Length == 25))
                                                        return fieldGeneratorAmenitiesIncludeSupported;
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
                        default:
                            break;
                      }
                    break;
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "tegories", 0, 8, false) == 0)
                              {
                                switch (field_name[10])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 11, "xclude", 0, 6, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorCategoriesExclude;
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 11, "nclude", 0, 6, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorCategoriesInclude;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'h':
                            if (String.Compare(field_name, 2, "ains", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 7, "xclude", 0, 6, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorChainsExclude;
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 7, "nclude", 0, 6, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorChainsInclude;
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
                    if (String.Compare(field_name, 1, "ollarSign", 0, 9, false) == 0)
                      {
                        switch (field_name[10])
                          {
                            case 'M':
                                switch (field_name[11])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 12, "x", 0, 1, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorDollarSignMax;
                                        break;
                                    case 'i':
                                        if ((String.Compare(field_name, 12, "n", 0, 1, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorDollarSignMin;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 's':
                                switch (field_name[11])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 12, "xclude", 0, 6, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorDollarSignsExclude;
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 12, "nclude", 0, 6, false) == 0) && (field_name.Length == 18))
                                            return fieldGeneratorDollarSignsInclude;
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
                case 'E':
                    if ((String.Compare(field_name, 1, "xpensiveFlag", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorExpensiveFlag;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nexpensiveFlag", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorInexpensiveFlag;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "apLocation", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorMapLocation;
                    break;
                case 'O':
                    if (String.Compare(field_name, 1, "penHours", 0, 8, false) == 0)
                      {
                        if (field_name.Length == 9)
                          {
                            return fieldGeneratorOpenHours;
                          }
                        switch (field_name[9])
                          {
                            case 'F':
                                if ((String.Compare(field_name, 10, "ilterOnHoliday", 0, 14, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorOpenHoursFilterOnHoliday;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'l':
                            if (String.Compare(field_name, 2, "aces", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 7, "xclude", 0, 6, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorPlacesExclude;
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 7, "nclude", 0, 6, false) == 0) && (field_name.Length == 13))
                                            return fieldGeneratorPlacesInclude;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "oducts", 0, 6, false) == 0)
                              {
                                switch (field_name[8])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 9, "xclude", 0, 6, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorProductsExclude;
                                        break;
                                    case 'I':
                                        if ((String.Compare(field_name, 9, "nclude", 0, 6, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorProductsInclude;
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
                case 'R':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "dius", 0, 4, false) == 0)
                              {
                                if (field_name.Length == 6)
                                  {
                                    return fieldGeneratorRadius;
                                  }
                                switch (field_name[6])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 7, "nferred", 0, 7, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorRadiusInferred;
                                        break;
                                    case 'U':
                                        if ((String.Compare(field_name, 7, "nit", 0, 3, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorRadiusUnit;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'e':
                            switch (field_name[2])
                              {
                                case 's':
                                    if ((String.Compare(field_name, 3, "ultCount", 0, 8, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorResultCount;
                                    break;
                                case 'v':
                                    if (String.Compare(field_name, 3, "iewCountM", 0, 9, false) == 0)
                                      {
                                        switch (field_name[12])
                                          {
                                            case 'a':
                                                if ((String.Compare(field_name, 13, "x", 0, 1, false) == 0) && (field_name.Length == 14))
                                                    return fieldGeneratorReviewCountMax;
                                                break;
                                            case 'i':
                                                if ((String.Compare(field_name, 13, "n", 0, 1, false) == 0) && (field_name.Length == 14))
                                                    return fieldGeneratorReviewCountMin;
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
                        default:
                            break;
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'o':
                            if ((String.Compare(field_name, 2, "rtSpecification", 0, 15, false) == 0) && (field_name.Length == 17))
                                return fieldGeneratorSortSpecification;
                            break;
                        case 't':
                            if (String.Compare(field_name, 2, "arRating", 0, 8, false) == 0)
                              {
                                switch (field_name[10])
                                  {
                                    case 'M':
                                        switch (field_name[11])
                                          {
                                            case 'a':
                                                if ((String.Compare(field_name, 12, "x", 0, 1, false) == 0) && (field_name.Length == 13))
                                                    return fieldGeneratorStarRatingMax;
                                                break;
                                            case 'i':
                                                if ((String.Compare(field_name, 12, "n", 0, 1, false) == 0) && (field_name.Length == 13))
                                                    return fieldGeneratorStarRatingMin;
                                                break;
                                            default:
                                                break;
                                          }
                                        break;
                                    case 's':
                                        switch (field_name[11])
                                          {
                                            case 'E':
                                                if ((String.Compare(field_name, 12, "xclude", 0, 6, false) == 0) && (field_name.Length == 18))
                                                    return fieldGeneratorStarRatingsExclude;
                                                break;
                                            case 'I':
                                                if ((String.Compare(field_name, 12, "nclude", 0, 6, false) == 0) && (field_name.Length == 18))
                                                    return fieldGeneratorStarRatingsInclude;
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
            fieldGeneratorResultCount = new JSONHoldingBooleanGenerator("field \"ResultCount\" of the LocalSearchFilterFlags class");
            fieldGeneratorMapLocation = new JSONHoldingBooleanGenerator("field \"MapLocation\" of the LocalSearchFilterFlags class");
            fieldGeneratorRadius = new JSONHoldingBooleanGenerator("field \"Radius\" of the LocalSearchFilterFlags class");
            fieldGeneratorRadiusUnit = new JSONHoldingBooleanGenerator("field \"RadiusUnit\" of the LocalSearchFilterFlags class");
            fieldGeneratorRadiusInferred = new JSONHoldingBooleanGenerator("field \"RadiusInferred\" of the LocalSearchFilterFlags class");
            fieldGeneratorAlongTheRoute = new JSONHoldingBooleanGenerator("field \"AlongTheRoute\" of the LocalSearchFilterFlags class");
            fieldGeneratorOpenHours = new OpenHoursFlagsJSON.HoldingGenerator("field \"OpenHours\" of the LocalSearchFilterFlags class", ignore_extras);
            fieldGeneratorOpenHoursFilterOnHoliday = new JSONHoldingBooleanGenerator("field \"OpenHoursFilterOnHoliday\" of the LocalSearchFilterFlags class");
            fieldGeneratorSortSpecification = new JSONHoldingBooleanArrayGenerator("field \"SortSpecification\" of the LocalSearchFilterFlags class");
            fieldGeneratorExpensiveFlag = new JSONHoldingBooleanGenerator("field \"ExpensiveFlag\" of the LocalSearchFilterFlags class");
            fieldGeneratorInexpensiveFlag = new JSONHoldingBooleanGenerator("field \"InexpensiveFlag\" of the LocalSearchFilterFlags class");
            fieldGeneratorStarRatingMin = new JSONHoldingBooleanGenerator("field \"StarRatingMin\" of the LocalSearchFilterFlags class");
            fieldGeneratorStarRatingMax = new JSONHoldingBooleanGenerator("field \"StarRatingMax\" of the LocalSearchFilterFlags class");
            fieldGeneratorStarRatingsInclude = new JSONHoldingBooleanArrayGenerator("field \"StarRatingsInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorStarRatingsExclude = new JSONHoldingBooleanArrayGenerator("field \"StarRatingsExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorReviewCountMin = new JSONHoldingBooleanGenerator("field \"ReviewCountMin\" of the LocalSearchFilterFlags class");
            fieldGeneratorReviewCountMax = new JSONHoldingBooleanGenerator("field \"ReviewCountMax\" of the LocalSearchFilterFlags class");
            fieldGeneratorDollarSignMin = new JSONHoldingBooleanGenerator("field \"DollarSignMin\" of the LocalSearchFilterFlags class");
            fieldGeneratorDollarSignMax = new JSONHoldingBooleanGenerator("field \"DollarSignMax\" of the LocalSearchFilterFlags class");
            fieldGeneratorDollarSignsInclude = new JSONHoldingBooleanArrayGenerator("field \"DollarSignsInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorDollarSignsExclude = new JSONHoldingBooleanArrayGenerator("field \"DollarSignsExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorCategoriesInclude = new JSONHoldingBooleanArrayGenerator("field \"CategoriesInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorCategoriesExclude = new JSONHoldingBooleanArrayGenerator("field \"CategoriesExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorChainsInclude = new JSONHoldingBooleanArrayGenerator("field \"ChainsInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorChainsExclude = new JSONHoldingBooleanArrayGenerator("field \"ChainsExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorProductsInclude = new JSONHoldingBooleanArrayGenerator("field \"ProductsInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorProductsExclude = new JSONHoldingBooleanArrayGenerator("field \"ProductsExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorPlacesInclude = new JSONHoldingBooleanArrayGenerator("field \"PlacesInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorPlacesExclude = new JSONHoldingBooleanArrayGenerator("field \"PlacesExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorAmenitiesInclude = new JSONHoldingBooleanArrayGenerator("field \"AmenitiesInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorAmenitiesIncludeSupported = new JSONHoldingBooleanArrayGenerator("field \"AmenitiesIncludeSupported\" of the LocalSearchFilterFlags class");
            fieldGeneratorAmenitiesIncludeNotSupported = new JSONHoldingBooleanArrayGenerator("field \"AmenitiesIncludeNotSupported\" of the LocalSearchFilterFlags class");
            fieldGeneratorAmenitiesExclude = new JSONHoldingBooleanArrayGenerator("field \"AmenitiesExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorAmenitiesExcludeSupported = new JSONHoldingBooleanArrayGenerator("field \"AmenitiesExcludeSupported\" of the LocalSearchFilterFlags class");
            fieldGeneratorAmenitiesExcludeNotSupported = new JSONHoldingBooleanArrayGenerator("field \"AmenitiesExcludeNotSupported\" of the LocalSearchFilterFlags class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the LocalSearchFilterFlags class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorResultCount = new JSONHoldingBooleanGenerator("field \"ResultCount\" of the LocalSearchFilterFlags class");
            fieldGeneratorMapLocation = new JSONHoldingBooleanGenerator("field \"MapLocation\" of the LocalSearchFilterFlags class");
            fieldGeneratorRadius = new JSONHoldingBooleanGenerator("field \"Radius\" of the LocalSearchFilterFlags class");
            fieldGeneratorRadiusUnit = new JSONHoldingBooleanGenerator("field \"RadiusUnit\" of the LocalSearchFilterFlags class");
            fieldGeneratorRadiusInferred = new JSONHoldingBooleanGenerator("field \"RadiusInferred\" of the LocalSearchFilterFlags class");
            fieldGeneratorAlongTheRoute = new JSONHoldingBooleanGenerator("field \"AlongTheRoute\" of the LocalSearchFilterFlags class");
            fieldGeneratorOpenHours = new OpenHoursFlagsJSON.HoldingGenerator("field \"OpenHours\" of the LocalSearchFilterFlags class", false);
            fieldGeneratorOpenHoursFilterOnHoliday = new JSONHoldingBooleanGenerator("field \"OpenHoursFilterOnHoliday\" of the LocalSearchFilterFlags class");
            fieldGeneratorSortSpecification = new JSONHoldingBooleanArrayGenerator("field \"SortSpecification\" of the LocalSearchFilterFlags class");
            fieldGeneratorExpensiveFlag = new JSONHoldingBooleanGenerator("field \"ExpensiveFlag\" of the LocalSearchFilterFlags class");
            fieldGeneratorInexpensiveFlag = new JSONHoldingBooleanGenerator("field \"InexpensiveFlag\" of the LocalSearchFilterFlags class");
            fieldGeneratorStarRatingMin = new JSONHoldingBooleanGenerator("field \"StarRatingMin\" of the LocalSearchFilterFlags class");
            fieldGeneratorStarRatingMax = new JSONHoldingBooleanGenerator("field \"StarRatingMax\" of the LocalSearchFilterFlags class");
            fieldGeneratorStarRatingsInclude = new JSONHoldingBooleanArrayGenerator("field \"StarRatingsInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorStarRatingsExclude = new JSONHoldingBooleanArrayGenerator("field \"StarRatingsExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorReviewCountMin = new JSONHoldingBooleanGenerator("field \"ReviewCountMin\" of the LocalSearchFilterFlags class");
            fieldGeneratorReviewCountMax = new JSONHoldingBooleanGenerator("field \"ReviewCountMax\" of the LocalSearchFilterFlags class");
            fieldGeneratorDollarSignMin = new JSONHoldingBooleanGenerator("field \"DollarSignMin\" of the LocalSearchFilterFlags class");
            fieldGeneratorDollarSignMax = new JSONHoldingBooleanGenerator("field \"DollarSignMax\" of the LocalSearchFilterFlags class");
            fieldGeneratorDollarSignsInclude = new JSONHoldingBooleanArrayGenerator("field \"DollarSignsInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorDollarSignsExclude = new JSONHoldingBooleanArrayGenerator("field \"DollarSignsExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorCategoriesInclude = new JSONHoldingBooleanArrayGenerator("field \"CategoriesInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorCategoriesExclude = new JSONHoldingBooleanArrayGenerator("field \"CategoriesExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorChainsInclude = new JSONHoldingBooleanArrayGenerator("field \"ChainsInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorChainsExclude = new JSONHoldingBooleanArrayGenerator("field \"ChainsExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorProductsInclude = new JSONHoldingBooleanArrayGenerator("field \"ProductsInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorProductsExclude = new JSONHoldingBooleanArrayGenerator("field \"ProductsExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorPlacesInclude = new JSONHoldingBooleanArrayGenerator("field \"PlacesInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorPlacesExclude = new JSONHoldingBooleanArrayGenerator("field \"PlacesExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorAmenitiesInclude = new JSONHoldingBooleanArrayGenerator("field \"AmenitiesInclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorAmenitiesIncludeSupported = new JSONHoldingBooleanArrayGenerator("field \"AmenitiesIncludeSupported\" of the LocalSearchFilterFlags class");
            fieldGeneratorAmenitiesIncludeNotSupported = new JSONHoldingBooleanArrayGenerator("field \"AmenitiesIncludeNotSupported\" of the LocalSearchFilterFlags class");
            fieldGeneratorAmenitiesExclude = new JSONHoldingBooleanArrayGenerator("field \"AmenitiesExclude\" of the LocalSearchFilterFlags class");
            fieldGeneratorAmenitiesExcludeSupported = new JSONHoldingBooleanArrayGenerator("field \"AmenitiesExcludeSupported\" of the LocalSearchFilterFlags class");
            fieldGeneratorAmenitiesExcludeNotSupported = new JSONHoldingBooleanArrayGenerator("field \"AmenitiesExcludeNotSupported\" of the LocalSearchFilterFlags class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the LocalSearchFilterFlags class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorResultCount.reset();
            fieldGeneratorMapLocation.reset();
            fieldGeneratorRadius.reset();
            fieldGeneratorRadiusUnit.reset();
            fieldGeneratorRadiusInferred.reset();
            fieldGeneratorAlongTheRoute.reset();
            fieldGeneratorOpenHours.reset();
            fieldGeneratorOpenHoursFilterOnHoliday.reset();
            fieldGeneratorSortSpecification.reset();
            fieldGeneratorExpensiveFlag.reset();
            fieldGeneratorInexpensiveFlag.reset();
            fieldGeneratorStarRatingMin.reset();
            fieldGeneratorStarRatingMax.reset();
            fieldGeneratorStarRatingsInclude.reset();
            fieldGeneratorStarRatingsExclude.reset();
            fieldGeneratorReviewCountMin.reset();
            fieldGeneratorReviewCountMax.reset();
            fieldGeneratorDollarSignMin.reset();
            fieldGeneratorDollarSignMax.reset();
            fieldGeneratorDollarSignsInclude.reset();
            fieldGeneratorDollarSignsExclude.reset();
            fieldGeneratorCategoriesInclude.reset();
            fieldGeneratorCategoriesExclude.reset();
            fieldGeneratorChainsInclude.reset();
            fieldGeneratorChainsExclude.reset();
            fieldGeneratorProductsInclude.reset();
            fieldGeneratorProductsExclude.reset();
            fieldGeneratorPlacesInclude.reset();
            fieldGeneratorPlacesExclude.reset();
            fieldGeneratorAmenitiesInclude.reset();
            fieldGeneratorAmenitiesIncludeSupported.reset();
            fieldGeneratorAmenitiesIncludeNotSupported.reset();
            fieldGeneratorAmenitiesExclude.reset();
            fieldGeneratorAmenitiesExcludeSupported.reset();
            fieldGeneratorAmenitiesExcludeNotSupported.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorOpenHours.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorOpenHours.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(LocalSearchFilterFlagsJSON  result)
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
        public LocalSearchFilterFlagsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LocalSearchFilterFlagsJSON  result)
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
    protected virtual void handle_result(List<LocalSearchFilterFlagsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LocalSearchFilterFlagsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LocalSearchFilterFlagsJSON>();
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
    public List<LocalSearchFilterFlagsJSON> value;
  };
  };
