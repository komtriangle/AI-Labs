/* file "LocalSearchFilterSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class LocalSearchFilterSpecJSON : JSONBase
  {
    public enum TypeQueryTypeKnownValues
      {
        QueryType_Search,
        QueryType_Question,
        QueryType_ActionsCall,
        QueryType__none
      };
    public struct TypeQueryType
      {
        public bool in_known_list;
        public string string_value;
        public TypeQueryTypeKnownValues list_value;
      };

    public static TypeQueryTypeKnownValues  stringToQueryType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "ctionsCall", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeQueryTypeKnownValues.QueryType_ActionsCall;
                break;
            case 'Q':
                if ((String.Compare(chars, 1, "uestion", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeQueryTypeKnownValues.QueryType_Question;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "earch", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeQueryTypeKnownValues.QueryType_Search;
                break;
            default:
                break;
          }
        return TypeQueryTypeKnownValues.QueryType__none;
      }

    public static string  stringFromQueryType(TypeQueryTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeQueryTypeKnownValues.QueryType_Search:
                return "Search";
            case TypeQueryTypeKnownValues.QueryType_Question:
                return "Question";
            case TypeQueryTypeKnownValues.QueryType_ActionsCall:
                return "ActionsCall";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeRadiusUnit
      {
        RadiusUnit_Kilometers,
        RadiusUnit_Miles
      };

    public static TypeRadiusUnit  stringToRadiusUnit(string chars)
      {
        switch (chars[0])
          {
            case 'K':
                if ((String.Compare(chars, 1, "ilometers", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeRadiusUnit.RadiusUnit_Kilometers;
                break;
            case 'M':
                if ((String.Compare(chars, 1, "iles", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeRadiusUnit.RadiusUnit_Miles;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `RadiusUnit' is not one of the legal values.");
      }

    public static string  stringFromRadiusUnit(TypeRadiusUnit the_enum)
      {
        switch (the_enum)
          {
            case TypeRadiusUnit.RadiusUnit_Kilometers:
                return "Kilometers";
            case TypeRadiusUnit.RadiusUnit_Miles:
                return "Miles";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeSortCriteria
      {
        SortCriteria_Distance,
        SortCriteria_Price,
        SortCriteria_StarRating,
        SortCriteria_ReviewCount
      };

    public static TypeSortCriteria  stringToSortCriteria(string chars)
      {
        switch (chars[0])
          {
            case 'D':
                if ((String.Compare(chars, 1, "istance", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeSortCriteria.SortCriteria_Distance;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "rice", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeSortCriteria.SortCriteria_Price;
                break;
            case 'R':
                if ((String.Compare(chars, 1, "eviewCount", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeSortCriteria.SortCriteria_ReviewCount;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "tarRating", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeSortCriteria.SortCriteria_StarRating;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `SortCriteria' is not one of the legal values.");
      }

    public static string  stringFromSortCriteria(TypeSortCriteria the_enum)
      {
        switch (the_enum)
          {
            case TypeSortCriteria.SortCriteria_Distance:
                return "Distance";
            case TypeSortCriteria.SortCriteria_Price:
                return "Price";
            case TypeSortCriteria.SortCriteria_StarRating:
                return "StarRating";
            case TypeSortCriteria.SortCriteria_ReviewCount:
                return "ReviewCount";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeSortOrder
      {
        SortOrder_Ascending,
        SortOrder_Descending
      };

    public static TypeSortOrder  stringToSortOrder(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "scending", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeSortOrder.SortOrder_Ascending;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "escending", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeSortOrder.SortOrder_Descending;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `SortOrder' is not one of the legal values.");
      }

    public static string  stringFromSortOrder(TypeSortOrder the_enum)
      {
        switch (the_enum)
          {
            case TypeSortOrder.SortOrder_Ascending:
                return "Ascending";
            case TypeSortOrder.SortOrder_Descending:
                return "Descending";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasQueryType;
    private TypeQueryType storeQueryType;
    private bool flagHasResultCount;
    private sbyte storeResultCount;
    private bool flagHasMapLocation;
    private MapLocationJSON  storeMapLocation;
    private bool flagHasRadius;
    private double storeRadius;
    private string textStoreRadius;
    private bool flagHasRadiusUnit;
    private TypeRadiusUnit storeRadiusUnit;
    private bool flagHasRadiusInferred;
    private bool storeRadiusInferred;
    private bool flagHasAlongTheRoute;
    private bool storeAlongTheRoute;
    private bool flagHasRoutePoints;
    private RoutePointsJSON  storeRoutePoints;
    private bool flagHasLocalSearchQuestions;
    private LocalSearchQuestionsSpecJSON  storeLocalSearchQuestions;
    private bool flagHasOpenHours;
    private OpenHoursSpecJSON  storeOpenHours;
    private bool flagHasOpenHoursSpokenResponse;
    private string storeOpenHoursSpokenResponse;
    private bool flagHasOpenHoursWrittenResponse;
    private string storeOpenHoursWrittenResponse;
    private bool flagHasOpenHoursFilterOnHoliday;
    private bool storeOpenHoursFilterOnHoliday;
    private bool flagHasSortCriteria;
    private List< TypeSortCriteria > storeSortCriteria;
    private bool flagHasSortOrder;
    private List< TypeSortOrder > storeSortOrder;
    private bool flagHasExpensiveFlag;
    private bool storeExpensiveFlag;
    private bool flagHasInexpensiveFlag;
    private bool storeInexpensiveFlag;
    private bool flagHasConversationMode;
    private bool storeConversationMode;
    private bool flagHasStarRatingMin;
    private double storeStarRatingMin;
    private string textStoreStarRatingMin;
    private bool flagHasStarRatingMax;
    private double storeStarRatingMax;
    private string textStoreStarRatingMax;
    private bool flagHasStarRatingsInclude;
    private List< Double > storeStarRatingsInclude;
    private bool flagHasStarRatingsExclude;
    private List< Double > storeStarRatingsExclude;
    private bool flagHasReviewCountMin;
    private BigInteger storeReviewCountMin;
    private bool flagHasReviewCountMax;
    private BigInteger storeReviewCountMax;
    private bool flagHasDollarSignMin;
    private double storeDollarSignMin;
    private string textStoreDollarSignMin;
    private bool flagHasDollarSignMax;
    private double storeDollarSignMax;
    private string textStoreDollarSignMax;
    private bool flagHasDollarSignsInclude;
    private List< Double > storeDollarSignsInclude;
    private bool flagHasDollarSignsExclude;
    private List< Double > storeDollarSignsExclude;
    private bool flagHasCategoriesInclude;
    private List< string > storeCategoriesInclude;
    private bool flagHasCategoriesExclude;
    private List< string > storeCategoriesExclude;
    private bool flagHasChainsInclude;
    private List< string > storeChainsInclude;
    private bool flagHasChainsExclude;
    private List< string > storeChainsExclude;
    private bool flagHasProductsInclude;
    private List< string > storeProductsInclude;
    private bool flagHasProductsExclude;
    private List< string > storeProductsExclude;
    private bool flagHasResultIDsReferenced;
    private List< string > storeResultIDsReferenced;
    private bool flagHasResultIDsIndex;
    private sbyte storeResultIDsIndex;
    private bool flagHasResultIDsIndexRepeated;
    private bool storeResultIDsIndexRepeated;
    private bool flagHasPlacesInclude;
    private List< string > storePlacesInclude;
    private bool flagHasPlacesExclude;
    private List< string > storePlacesExclude;
    private bool flagHasExcludedPlacesSpoken;
    private string storeExcludedPlacesSpoken;
    private bool flagHasExcludedPlacesWritten;
    private string storeExcludedPlacesWritten;
    private bool flagHasHistoryInclude;
    private SetOfTimeJSON  storeHistoryInclude;
    private bool flagHasHistoryExclude;
    private SetOfTimeJSON  storeHistoryExclude;
    private bool flagHasAmenitiesInclude;
    private List< AmenityGroupSpecJSON  > storeAmenitiesInclude;
    private bool flagHasAmenitiesIncludeSupported;
    private List< AmenityGroupSpecJSON  > storeAmenitiesIncludeSupported;
    private bool flagHasAmenitiesIncludeNotSupported;
    private List< AmenityGroupSpecJSON  > storeAmenitiesIncludeNotSupported;
    private bool flagHasAmenitiesExclude;
    private List< AmenityGroupSpecJSON  > storeAmenitiesExclude;
    private bool flagHasAmenitiesExcludeSupported;
    private List< AmenityGroupSpecJSON  > storeAmenitiesExcludeSupported;
    private bool flagHasAmenitiesExcludeNotSupported;
    private List< AmenityGroupSpecJSON  > storeAmenitiesExcludeNotSupported;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryType of LocalSearchFilterSpecJSON is not a string.");
        TypeQueryType the_open_enum = new TypeQueryType();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "ctionsCall", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_ActionsCall;
                        goto open_enum_is_done;
                      }
                break;
            case 'Q':
                if ((String.Compare(json_string.getData(), 1, "uestion", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_Question;
                        goto open_enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "earch", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_Search;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setQueryType(the_open_enum);
      }


    private void  fromJSONResultCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ResultCount of LocalSearchFilterSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ResultCount of LocalSearchFilterSpecJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setResultCount(extracted_integer);
      }


    private void  fromJSONMapLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setMapLocation(convert_classy);
      }


    private void  fromJSONRadius(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Radius of LocalSearchFilterSpecJSON is not a number.");
              }
          }
        setRadiusText(the_rational_text);
      }


    private void  fromJSONRadiusUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RadiusUnit of LocalSearchFilterSpecJSON is not a string.");
        TypeRadiusUnit the_enum;
        switch (json_string.getData()[0])
          {
            case 'K':
                if ((String.Compare(json_string.getData(), 1, "ilometers", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeRadiusUnit.RadiusUnit_Kilometers;
                        goto enum_is_done;
                      }
                break;
            case 'M':
                if ((String.Compare(json_string.getData(), 1, "iles", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeRadiusUnit.RadiusUnit_Miles;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field RadiusUnit of LocalSearchFilterSpecJSON is not one of the legal strings.");
      enum_is_done:;
        setRadiusUnit(the_enum);
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
                throw new Exception("The value for field RadiusInferred of LocalSearchFilterSpecJSON is not true for false.");
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
                throw new Exception("The value for field AlongTheRoute of LocalSearchFilterSpecJSON is not true for false.");
              }
          }
        setAlongTheRoute(the_bool);
      }


    private void  fromJSONRoutePoints(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        RoutePointsJSON convert_classy = RoutePointsJSON.from_json(json_value, ignore_extras, true);
        setRoutePoints(convert_classy);
      }


    private void  fromJSONLocalSearchQuestions(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        LocalSearchQuestionsSpecJSON convert_classy = LocalSearchQuestionsSpecJSON.from_json(json_value, ignore_extras, true);
        setLocalSearchQuestions(convert_classy);
      }


    private void  fromJSONOpenHours(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OpenHoursSpecJSON convert_classy = OpenHoursSpecJSON.from_json(json_value, ignore_extras, true);
        setOpenHours(convert_classy);
      }


    private void  fromJSONOpenHoursSpokenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OpenHoursSpokenResponse of LocalSearchFilterSpecJSON is not a string.");
        setOpenHoursSpokenResponse(json_string.getData());
      }


    private void  fromJSONOpenHoursWrittenResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OpenHoursWrittenResponse of LocalSearchFilterSpecJSON is not a string.");
        setOpenHoursWrittenResponse(json_string.getData());
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
                throw new Exception("The value for field OpenHoursFilterOnHoliday of LocalSearchFilterSpecJSON is not true for false.");
              }
          }
        setOpenHoursFilterOnHoliday(the_bool);
      }


    private void  fromJSONSortCriteria(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SortCriteria of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeSortCriteria > vector_SortCriteria1 = new List< TypeSortCriteria >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SortCriteria of LocalSearchFilterSpecJSON is not a string.");
            TypeSortCriteria the_enum;
            switch (json_string.getData()[0])
              {
                case 'D':
                    if ((String.Compare(json_string.getData(), 1, "istance", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_enum = TypeSortCriteria.SortCriteria_Distance;
                            goto enum_is_done;
                          }
                    break;
                case 'P':
                    if ((String.Compare(json_string.getData(), 1, "rice", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_enum = TypeSortCriteria.SortCriteria_Price;
                            goto enum_is_done;
                          }
                    break;
                case 'R':
                    if ((String.Compare(json_string.getData(), 1, "eviewCount", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                          {
                            the_enum = TypeSortCriteria.SortCriteria_ReviewCount;
                            goto enum_is_done;
                          }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "tarRating", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                          {
                            the_enum = TypeSortCriteria.SortCriteria_StarRating;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for an element of field SortCriteria of LocalSearchFilterSpecJSON is not one of the legal strings.");
          enum_is_done:;
            vector_SortCriteria1.Add(the_enum);
          }
        initSortCriteria();
        for (int num1 = 0; num1 < vector_SortCriteria1.Count; ++num1)
            appendSortCriteria(vector_SortCriteria1[num1]);
        for (int num1 = 0; num1 < vector_SortCriteria1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSortOrder(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SortOrder of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeSortOrder > vector_SortOrder1 = new List< TypeSortOrder >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SortOrder of LocalSearchFilterSpecJSON is not a string.");
            TypeSortOrder the_enum;
            switch (json_string.getData()[0])
              {
                case 'A':
                    if ((String.Compare(json_string.getData(), 1, "scending", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                          {
                            the_enum = TypeSortOrder.SortOrder_Ascending;
                            goto enum_is_done;
                          }
                    break;
                case 'D':
                    if ((String.Compare(json_string.getData(), 1, "escending", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                          {
                            the_enum = TypeSortOrder.SortOrder_Descending;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for an element of field SortOrder of LocalSearchFilterSpecJSON is not one of the legal strings.");
          enum_is_done:;
            vector_SortOrder1.Add(the_enum);
          }
        initSortOrder();
        for (int num2 = 0; num2 < vector_SortOrder1.Count; ++num2)
            appendSortOrder(vector_SortOrder1[num2]);
        for (int num1 = 0; num1 < vector_SortOrder1.Count; ++num1)
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
                throw new Exception("The value for field ExpensiveFlag of LocalSearchFilterSpecJSON is not true for false.");
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
                throw new Exception("The value for field InexpensiveFlag of LocalSearchFilterSpecJSON is not true for false.");
              }
          }
        setInexpensiveFlag(the_bool);
      }


    private void  fromJSONConversationMode(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ConversationMode of LocalSearchFilterSpecJSON is not true for false.");
              }
          }
        setConversationMode(the_bool);
      }


    private void  fromJSONStarRatingMin(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StarRatingMin of LocalSearchFilterSpecJSON is not a number.");
              }
          }
        setStarRatingMinText(the_rational_text);
      }


    private void  fromJSONStarRatingMax(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field StarRatingMax of LocalSearchFilterSpecJSON is not a number.");
              }
          }
        setStarRatingMaxText(the_rational_text);
      }


    private void  fromJSONStarRatingsInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StarRatingsInclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Double > vector_StarRatingsInclude1 = new List< Double >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONRationalValue json_rational = json_array1.component(num1).rational_value();
            double the_double;
            if (json_rational != null)
              {
                the_double = json_rational.getDouble();
              }
            else
              {
                JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                if (json_integer != null)
                  {
                    the_double = json_integer.getLongInt();
                  }
                else
                  {
                    throw new Exception("The value for an element of field StarRatingsInclude of LocalSearchFilterSpecJSON is not a number.");
                  }
              }
            vector_StarRatingsInclude1.Add(the_double);
          }
        initStarRatingsInclude();
        for (int num3 = 0; num3 < vector_StarRatingsInclude1.Count; ++num3)
            appendStarRatingsInclude(vector_StarRatingsInclude1[num3]);
        for (int num1 = 0; num1 < vector_StarRatingsInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONStarRatingsExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field StarRatingsExclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Double > vector_StarRatingsExclude1 = new List< Double >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONRationalValue json_rational = json_array1.component(num1).rational_value();
            double the_double;
            if (json_rational != null)
              {
                the_double = json_rational.getDouble();
              }
            else
              {
                JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                if (json_integer != null)
                  {
                    the_double = json_integer.getLongInt();
                  }
                else
                  {
                    throw new Exception("The value for an element of field StarRatingsExclude of LocalSearchFilterSpecJSON is not a number.");
                  }
              }
            vector_StarRatingsExclude1.Add(the_double);
          }
        initStarRatingsExclude();
        for (int num4 = 0; num4 < vector_StarRatingsExclude1.Count; ++num4)
            appendStarRatingsExclude(vector_StarRatingsExclude1[num4]);
        for (int num1 = 0; num1 < vector_StarRatingsExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONReviewCountMin(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ReviewCountMin of LocalSearchFilterSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ReviewCountMin of LocalSearchFilterSpecJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setReviewCountMin(extracted_integer);
      }


    private void  fromJSONReviewCountMax(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ReviewCountMax of LocalSearchFilterSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ReviewCountMax of LocalSearchFilterSpecJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setReviewCountMax(extracted_integer);
      }


    private void  fromJSONDollarSignMin(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DollarSignMin of LocalSearchFilterSpecJSON is not a number.");
              }
          }
        setDollarSignMinText(the_rational_text);
      }


    private void  fromJSONDollarSignMax(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DollarSignMax of LocalSearchFilterSpecJSON is not a number.");
              }
          }
        setDollarSignMaxText(the_rational_text);
      }


    private void  fromJSONDollarSignsInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DollarSignsInclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Double > vector_DollarSignsInclude1 = new List< Double >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONRationalValue json_rational = json_array1.component(num1).rational_value();
            double the_double;
            if (json_rational != null)
              {
                the_double = json_rational.getDouble();
              }
            else
              {
                JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                if (json_integer != null)
                  {
                    the_double = json_integer.getLongInt();
                  }
                else
                  {
                    throw new Exception("The value for an element of field DollarSignsInclude of LocalSearchFilterSpecJSON is not a number.");
                  }
              }
            vector_DollarSignsInclude1.Add(the_double);
          }
        initDollarSignsInclude();
        for (int num5 = 0; num5 < vector_DollarSignsInclude1.Count; ++num5)
            appendDollarSignsInclude(vector_DollarSignsInclude1[num5]);
        for (int num1 = 0; num1 < vector_DollarSignsInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONDollarSignsExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field DollarSignsExclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< Double > vector_DollarSignsExclude1 = new List< Double >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONRationalValue json_rational = json_array1.component(num1).rational_value();
            double the_double;
            if (json_rational != null)
              {
                the_double = json_rational.getDouble();
              }
            else
              {
                JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                if (json_integer != null)
                  {
                    the_double = json_integer.getLongInt();
                  }
                else
                  {
                    throw new Exception("The value for an element of field DollarSignsExclude of LocalSearchFilterSpecJSON is not a number.");
                  }
              }
            vector_DollarSignsExclude1.Add(the_double);
          }
        initDollarSignsExclude();
        for (int num6 = 0; num6 < vector_DollarSignsExclude1.Count; ++num6)
            appendDollarSignsExclude(vector_DollarSignsExclude1[num6]);
        for (int num1 = 0; num1 < vector_DollarSignsExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCategoriesInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CategoriesInclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_CategoriesInclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field CategoriesInclude of LocalSearchFilterSpecJSON is not a string.");
            vector_CategoriesInclude1.Add(json_string.getData());
          }
        initCategoriesInclude();
        for (int num7 = 0; num7 < vector_CategoriesInclude1.Count; ++num7)
            appendCategoriesInclude(vector_CategoriesInclude1[num7]);
        for (int num1 = 0; num1 < vector_CategoriesInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCategoriesExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field CategoriesExclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_CategoriesExclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field CategoriesExclude of LocalSearchFilterSpecJSON is not a string.");
            vector_CategoriesExclude1.Add(json_string.getData());
          }
        initCategoriesExclude();
        for (int num8 = 0; num8 < vector_CategoriesExclude1.Count; ++num8)
            appendCategoriesExclude(vector_CategoriesExclude1[num8]);
        for (int num1 = 0; num1 < vector_CategoriesExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONChainsInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ChainsInclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ChainsInclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ChainsInclude of LocalSearchFilterSpecJSON is not a string.");
            vector_ChainsInclude1.Add(json_string.getData());
          }
        initChainsInclude();
        for (int num9 = 0; num9 < vector_ChainsInclude1.Count; ++num9)
            appendChainsInclude(vector_ChainsInclude1[num9]);
        for (int num1 = 0; num1 < vector_ChainsInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONChainsExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ChainsExclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ChainsExclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ChainsExclude of LocalSearchFilterSpecJSON is not a string.");
            vector_ChainsExclude1.Add(json_string.getData());
          }
        initChainsExclude();
        for (int num10 = 0; num10 < vector_ChainsExclude1.Count; ++num10)
            appendChainsExclude(vector_ChainsExclude1[num10]);
        for (int num1 = 0; num1 < vector_ChainsExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONProductsInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ProductsInclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ProductsInclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ProductsInclude of LocalSearchFilterSpecJSON is not a string.");
            vector_ProductsInclude1.Add(json_string.getData());
          }
        initProductsInclude();
        for (int num11 = 0; num11 < vector_ProductsInclude1.Count; ++num11)
            appendProductsInclude(vector_ProductsInclude1[num11]);
        for (int num1 = 0; num1 < vector_ProductsInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONProductsExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ProductsExclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ProductsExclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ProductsExclude of LocalSearchFilterSpecJSON is not a string.");
            vector_ProductsExclude1.Add(json_string.getData());
          }
        initProductsExclude();
        for (int num12 = 0; num12 < vector_ProductsExclude1.Count; ++num12)
            appendProductsExclude(vector_ProductsExclude1[num12]);
        for (int num1 = 0; num1 < vector_ProductsExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONResultIDsReferenced(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ResultIDsReferenced of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ResultIDsReferenced1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ResultIDsReferenced of LocalSearchFilterSpecJSON is not a string.");
            vector_ResultIDsReferenced1.Add(json_string.getData());
          }
        initResultIDsReferenced();
        for (int num13 = 0; num13 < vector_ResultIDsReferenced1.Count; ++num13)
            appendResultIDsReferenced(vector_ResultIDsReferenced1[num13]);
        for (int num1 = 0; num1 < vector_ResultIDsReferenced1.Count; ++num1)
          {
          }
      }


    private void  fromJSONResultIDsIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        sbyte extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ResultIDsIndex of LocalSearchFilterSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ResultIDsIndex of LocalSearchFilterSpecJSON is not an integer.");
              }
            extracted_integer = (sbyte)(json_rational.getLongInt())        ;
          }
        else
          {
            extracted_integer = (sbyte)(json_integer.getLongInt())        ;
          }
        setResultIDsIndex(extracted_integer);
      }


    private void  fromJSONResultIDsIndexRepeated(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ResultIDsIndexRepeated of LocalSearchFilterSpecJSON is not true for false.");
              }
          }
        setResultIDsIndexRepeated(the_bool);
      }


    private void  fromJSONPlacesInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PlacesInclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_PlacesInclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field PlacesInclude of LocalSearchFilterSpecJSON is not a string.");
            vector_PlacesInclude1.Add(json_string.getData());
          }
        initPlacesInclude();
        for (int num14 = 0; num14 < vector_PlacesInclude1.Count; ++num14)
            appendPlacesInclude(vector_PlacesInclude1[num14]);
        for (int num1 = 0; num1 < vector_PlacesInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPlacesExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PlacesExclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_PlacesExclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field PlacesExclude of LocalSearchFilterSpecJSON is not a string.");
            vector_PlacesExclude1.Add(json_string.getData());
          }
        initPlacesExclude();
        for (int num15 = 0; num15 < vector_PlacesExclude1.Count; ++num15)
            appendPlacesExclude(vector_PlacesExclude1[num15]);
        for (int num1 = 0; num1 < vector_PlacesExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONExcludedPlacesSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExcludedPlacesSpoken of LocalSearchFilterSpecJSON is not a string.");
        setExcludedPlacesSpoken(json_string.getData());
      }


    private void  fromJSONExcludedPlacesWritten(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ExcludedPlacesWritten of LocalSearchFilterSpecJSON is not a string.");
        setExcludedPlacesWritten(json_string.getData());
      }


    private void  fromJSONHistoryInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SetOfTimeJSON convert_classy = SetOfTimeJSON.from_json(json_value, ignore_extras, true);
        setHistoryInclude(convert_classy);
      }


    private void  fromJSONHistoryExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SetOfTimeJSON convert_classy = SetOfTimeJSON.from_json(json_value, ignore_extras, true);
        setHistoryExclude(convert_classy);
      }


    private void  fromJSONAmenitiesInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesInclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AmenityGroupSpecJSON  > vector_AmenitiesInclude1 = new List< AmenityGroupSpecJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AmenityGroupSpecJSON convert_classy = AmenityGroupSpecJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmenitiesInclude1.Add(convert_classy);
          }
        initAmenitiesInclude();
        for (int num16 = 0; num16 < vector_AmenitiesInclude1.Count; ++num16)
            appendAmenitiesInclude(vector_AmenitiesInclude1[num16]);
        for (int num1 = 0; num1 < vector_AmenitiesInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesIncludeSupported(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesIncludeSupported of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AmenityGroupSpecJSON  > vector_AmenitiesIncludeSupported1 = new List< AmenityGroupSpecJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AmenityGroupSpecJSON convert_classy = AmenityGroupSpecJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmenitiesIncludeSupported1.Add(convert_classy);
          }
        initAmenitiesIncludeSupported();
        for (int num17 = 0; num17 < vector_AmenitiesIncludeSupported1.Count; ++num17)
            appendAmenitiesIncludeSupported(vector_AmenitiesIncludeSupported1[num17]);
        for (int num1 = 0; num1 < vector_AmenitiesIncludeSupported1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesIncludeNotSupported(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesIncludeNotSupported of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AmenityGroupSpecJSON  > vector_AmenitiesIncludeNotSupported1 = new List< AmenityGroupSpecJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AmenityGroupSpecJSON convert_classy = AmenityGroupSpecJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmenitiesIncludeNotSupported1.Add(convert_classy);
          }
        initAmenitiesIncludeNotSupported();
        for (int num18 = 0; num18 < vector_AmenitiesIncludeNotSupported1.Count; ++num18)
            appendAmenitiesIncludeNotSupported(vector_AmenitiesIncludeNotSupported1[num18]);
        for (int num1 = 0; num1 < vector_AmenitiesIncludeNotSupported1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesExclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesExclude of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AmenityGroupSpecJSON  > vector_AmenitiesExclude1 = new List< AmenityGroupSpecJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AmenityGroupSpecJSON convert_classy = AmenityGroupSpecJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmenitiesExclude1.Add(convert_classy);
          }
        initAmenitiesExclude();
        for (int num19 = 0; num19 < vector_AmenitiesExclude1.Count; ++num19)
            appendAmenitiesExclude(vector_AmenitiesExclude1[num19]);
        for (int num1 = 0; num1 < vector_AmenitiesExclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesExcludeSupported(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesExcludeSupported of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AmenityGroupSpecJSON  > vector_AmenitiesExcludeSupported1 = new List< AmenityGroupSpecJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AmenityGroupSpecJSON convert_classy = AmenityGroupSpecJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmenitiesExcludeSupported1.Add(convert_classy);
          }
        initAmenitiesExcludeSupported();
        for (int num20 = 0; num20 < vector_AmenitiesExcludeSupported1.Count; ++num20)
            appendAmenitiesExcludeSupported(vector_AmenitiesExcludeSupported1[num20]);
        for (int num1 = 0; num1 < vector_AmenitiesExcludeSupported1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesExcludeNotSupported(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesExcludeNotSupported of LocalSearchFilterSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AmenityGroupSpecJSON  > vector_AmenitiesExcludeNotSupported1 = new List< AmenityGroupSpecJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AmenityGroupSpecJSON convert_classy = AmenityGroupSpecJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmenitiesExcludeNotSupported1.Add(convert_classy);
          }
        initAmenitiesExcludeNotSupported();
        for (int num21 = 0; num21 < vector_AmenitiesExcludeNotSupported1.Count; ++num21)
            appendAmenitiesExcludeNotSupported(vector_AmenitiesExcludeNotSupported1[num21]);
        for (int num1 = 0; num1 < vector_AmenitiesExcludeNotSupported1.Count; ++num1)
          {
          }
      }


    public LocalSearchFilterSpecJSON()
      {
        flagHasQueryType = false;
        flagHasResultCount = false;
        flagHasMapLocation = false;
        flagHasRadius = false;
        flagHasRadiusUnit = false;
        flagHasRadiusInferred = false;
        flagHasAlongTheRoute = false;
        flagHasRoutePoints = false;
        flagHasLocalSearchQuestions = false;
        flagHasOpenHours = false;
        flagHasOpenHoursSpokenResponse = false;
        flagHasOpenHoursWrittenResponse = false;
        flagHasOpenHoursFilterOnHoliday = false;
        flagHasSortCriteria = false;
        flagHasSortOrder = false;
        flagHasExpensiveFlag = false;
        flagHasInexpensiveFlag = false;
        flagHasConversationMode = false;
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
        flagHasResultIDsReferenced = false;
        flagHasResultIDsIndex = false;
        flagHasResultIDsIndexRepeated = false;
        flagHasPlacesInclude = false;
        flagHasPlacesExclude = false;
        flagHasExcludedPlacesSpoken = false;
        flagHasExcludedPlacesWritten = false;
        flagHasHistoryInclude = false;
        flagHasHistoryExclude = false;
        flagHasAmenitiesInclude = false;
        flagHasAmenitiesIncludeSupported = false;
        flagHasAmenitiesIncludeNotSupported = false;
        flagHasAmenitiesExclude = false;
        flagHasAmenitiesExcludeSupported = false;
        flagHasAmenitiesExcludeNotSupported = false;
        storeSortCriteria = new List< TypeSortCriteria >();
        storeSortOrder = new List< TypeSortOrder >();
        storeStarRatingsInclude = new List< Double >();
        storeStarRatingsExclude = new List< Double >();
        storeDollarSignsInclude = new List< Double >();
        storeDollarSignsExclude = new List< Double >();
        storeCategoriesInclude = new List< string >();
        storeCategoriesExclude = new List< string >();
        storeChainsInclude = new List< string >();
        storeChainsExclude = new List< string >();
        storeProductsInclude = new List< string >();
        storeProductsExclude = new List< string >();
        storeResultIDsReferenced = new List< string >();
        storePlacesInclude = new List< string >();
        storePlacesExclude = new List< string >();
        storeAmenitiesInclude = new List< AmenityGroupSpecJSON  >();
        storeAmenitiesIncludeSupported = new List< AmenityGroupSpecJSON  >();
        storeAmenitiesIncludeNotSupported = new List< AmenityGroupSpecJSON  >();
        storeAmenitiesExclude = new List< AmenityGroupSpecJSON  >();
        storeAmenitiesExcludeSupported = new List< AmenityGroupSpecJSON  >();
        storeAmenitiesExcludeNotSupported = new List< AmenityGroupSpecJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQueryType()
      {
        return flagHasQueryType;
      }

    public TypeQueryType  getQueryType()
      {
        Debug.Assert(flagHasQueryType);
        return storeQueryType;
      }

    public string  getQueryTypeAsString()
      {
        TypeQueryType result = getQueryType();
        if (result.in_known_list)
            return stringFromQueryType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasResultCount()
      {
        return flagHasResultCount;
      }

    public sbyte  getResultCount()
      {
        Debug.Assert(flagHasResultCount);
        return storeResultCount;
      }

    public bool  hasMapLocation()
      {
        return flagHasMapLocation;
      }

    public MapLocationJSON   getMapLocation()
      {
        Debug.Assert(flagHasMapLocation);
        return storeMapLocation;
      }

    public bool  hasRadius()
      {
        return flagHasRadius;
      }

    public double  getRadius()
      {
        Debug.Assert(flagHasRadius);
        if (textStoreRadius != "")
          {
            return Double.Parse(textStoreRadius);
          }
        return storeRadius;
      }

    public string  getRadiusAsText()
      {
        Debug.Assert(flagHasRadius);
        if (textStoreRadius == "")
          {
            return Convert.ToString(storeRadius);
          }
        else
          {
            return (textStoreRadius);
          }
      }

    public bool  hasRadiusUnit()
      {
        return flagHasRadiusUnit;
      }

    public TypeRadiusUnit  getRadiusUnit()
      {
        Debug.Assert(flagHasRadiusUnit);
        return storeRadiusUnit;
      }

    public string  getRadiusUnitAsString()
      {
        return stringFromRadiusUnit(getRadiusUnit());
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

    public bool  hasRoutePoints()
      {
        return flagHasRoutePoints;
      }

    public RoutePointsJSON   getRoutePoints()
      {
        Debug.Assert(flagHasRoutePoints);
        return storeRoutePoints;
      }

    public bool  hasLocalSearchQuestions()
      {
        return flagHasLocalSearchQuestions;
      }

    public LocalSearchQuestionsSpecJSON   getLocalSearchQuestions()
      {
        Debug.Assert(flagHasLocalSearchQuestions);
        return storeLocalSearchQuestions;
      }

    public bool  hasOpenHours()
      {
        return flagHasOpenHours;
      }

    public OpenHoursSpecJSON   getOpenHours()
      {
        Debug.Assert(flagHasOpenHours);
        return storeOpenHours;
      }

    public bool  hasOpenHoursSpokenResponse()
      {
        return flagHasOpenHoursSpokenResponse;
      }

    public string  getOpenHoursSpokenResponse()
      {
        Debug.Assert(flagHasOpenHoursSpokenResponse);
        return storeOpenHoursSpokenResponse;
      }

    public bool  hasOpenHoursWrittenResponse()
      {
        return flagHasOpenHoursWrittenResponse;
      }

    public string  getOpenHoursWrittenResponse()
      {
        Debug.Assert(flagHasOpenHoursWrittenResponse);
        return storeOpenHoursWrittenResponse;
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

    public bool  hasSortCriteria()
      {
        return flagHasSortCriteria;
      }

    public int  countOfSortCriteria()
      {
        Debug.Assert(flagHasSortCriteria);
        return storeSortCriteria.Count;
      }

    public TypeSortCriteria  elementOfSortCriteria(int element_num)
      {
        Debug.Assert(flagHasSortCriteria);
        return storeSortCriteria[element_num];
      }

    public List< TypeSortCriteria >  getSortCriteria()
      {
        Debug.Assert(flagHasSortCriteria);
        return storeSortCriteria;
      }

    public bool  hasSortOrder()
      {
        return flagHasSortOrder;
      }

    public int  countOfSortOrder()
      {
        Debug.Assert(flagHasSortOrder);
        return storeSortOrder.Count;
      }

    public TypeSortOrder  elementOfSortOrder(int element_num)
      {
        Debug.Assert(flagHasSortOrder);
        return storeSortOrder[element_num];
      }

    public List< TypeSortOrder >  getSortOrder()
      {
        Debug.Assert(flagHasSortOrder);
        return storeSortOrder;
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

    public bool  hasConversationMode()
      {
        return flagHasConversationMode;
      }

    public bool  getConversationMode()
      {
        Debug.Assert(flagHasConversationMode);
        return storeConversationMode;
      }

    public bool  hasStarRatingMin()
      {
        return flagHasStarRatingMin;
      }

    public double  getStarRatingMin()
      {
        Debug.Assert(flagHasStarRatingMin);
        if (textStoreStarRatingMin != "")
          {
            return Double.Parse(textStoreStarRatingMin);
          }
        return storeStarRatingMin;
      }

    public string  getStarRatingMinAsText()
      {
        Debug.Assert(flagHasStarRatingMin);
        if (textStoreStarRatingMin == "")
          {
            return Convert.ToString(storeStarRatingMin);
          }
        else
          {
            return (textStoreStarRatingMin);
          }
      }

    public bool  hasStarRatingMax()
      {
        return flagHasStarRatingMax;
      }

    public double  getStarRatingMax()
      {
        Debug.Assert(flagHasStarRatingMax);
        if (textStoreStarRatingMax != "")
          {
            return Double.Parse(textStoreStarRatingMax);
          }
        return storeStarRatingMax;
      }

    public string  getStarRatingMaxAsText()
      {
        Debug.Assert(flagHasStarRatingMax);
        if (textStoreStarRatingMax == "")
          {
            return Convert.ToString(storeStarRatingMax);
          }
        else
          {
            return (textStoreStarRatingMax);
          }
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

    public double  elementOfStarRatingsInclude(int element_num)
      {
        Debug.Assert(flagHasStarRatingsInclude);
        return storeStarRatingsInclude[element_num];
      }

    public List< Double >  getStarRatingsInclude()
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

    public double  elementOfStarRatingsExclude(int element_num)
      {
        Debug.Assert(flagHasStarRatingsExclude);
        return storeStarRatingsExclude[element_num];
      }

    public List< Double >  getStarRatingsExclude()
      {
        Debug.Assert(flagHasStarRatingsExclude);
        return storeStarRatingsExclude;
      }

    public bool  hasReviewCountMin()
      {
        return flagHasReviewCountMin;
      }

    public BigInteger  getReviewCountMin()
      {
        Debug.Assert(flagHasReviewCountMin);
        return storeReviewCountMin;
      }

    public bool  hasReviewCountMax()
      {
        return flagHasReviewCountMax;
      }

    public BigInteger  getReviewCountMax()
      {
        Debug.Assert(flagHasReviewCountMax);
        return storeReviewCountMax;
      }

    public bool  hasDollarSignMin()
      {
        return flagHasDollarSignMin;
      }

    public double  getDollarSignMin()
      {
        Debug.Assert(flagHasDollarSignMin);
        if (textStoreDollarSignMin != "")
          {
            return Double.Parse(textStoreDollarSignMin);
          }
        return storeDollarSignMin;
      }

    public string  getDollarSignMinAsText()
      {
        Debug.Assert(flagHasDollarSignMin);
        if (textStoreDollarSignMin == "")
          {
            return Convert.ToString(storeDollarSignMin);
          }
        else
          {
            return (textStoreDollarSignMin);
          }
      }

    public bool  hasDollarSignMax()
      {
        return flagHasDollarSignMax;
      }

    public double  getDollarSignMax()
      {
        Debug.Assert(flagHasDollarSignMax);
        if (textStoreDollarSignMax != "")
          {
            return Double.Parse(textStoreDollarSignMax);
          }
        return storeDollarSignMax;
      }

    public string  getDollarSignMaxAsText()
      {
        Debug.Assert(flagHasDollarSignMax);
        if (textStoreDollarSignMax == "")
          {
            return Convert.ToString(storeDollarSignMax);
          }
        else
          {
            return (textStoreDollarSignMax);
          }
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

    public double  elementOfDollarSignsInclude(int element_num)
      {
        Debug.Assert(flagHasDollarSignsInclude);
        return storeDollarSignsInclude[element_num];
      }

    public List< Double >  getDollarSignsInclude()
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

    public double  elementOfDollarSignsExclude(int element_num)
      {
        Debug.Assert(flagHasDollarSignsExclude);
        return storeDollarSignsExclude[element_num];
      }

    public List< Double >  getDollarSignsExclude()
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

    public string  elementOfCategoriesInclude(int element_num)
      {
        Debug.Assert(flagHasCategoriesInclude);
        return storeCategoriesInclude[element_num];
      }

    public List< string >  getCategoriesInclude()
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

    public string  elementOfCategoriesExclude(int element_num)
      {
        Debug.Assert(flagHasCategoriesExclude);
        return storeCategoriesExclude[element_num];
      }

    public List< string >  getCategoriesExclude()
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

    public string  elementOfChainsInclude(int element_num)
      {
        Debug.Assert(flagHasChainsInclude);
        return storeChainsInclude[element_num];
      }

    public List< string >  getChainsInclude()
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

    public string  elementOfChainsExclude(int element_num)
      {
        Debug.Assert(flagHasChainsExclude);
        return storeChainsExclude[element_num];
      }

    public List< string >  getChainsExclude()
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

    public string  elementOfProductsInclude(int element_num)
      {
        Debug.Assert(flagHasProductsInclude);
        return storeProductsInclude[element_num];
      }

    public List< string >  getProductsInclude()
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

    public string  elementOfProductsExclude(int element_num)
      {
        Debug.Assert(flagHasProductsExclude);
        return storeProductsExclude[element_num];
      }

    public List< string >  getProductsExclude()
      {
        Debug.Assert(flagHasProductsExclude);
        return storeProductsExclude;
      }

    public bool  hasResultIDsReferenced()
      {
        return flagHasResultIDsReferenced;
      }

    public int  countOfResultIDsReferenced()
      {
        Debug.Assert(flagHasResultIDsReferenced);
        return storeResultIDsReferenced.Count;
      }

    public string  elementOfResultIDsReferenced(int element_num)
      {
        Debug.Assert(flagHasResultIDsReferenced);
        return storeResultIDsReferenced[element_num];
      }

    public List< string >  getResultIDsReferenced()
      {
        Debug.Assert(flagHasResultIDsReferenced);
        return storeResultIDsReferenced;
      }

    public bool  hasResultIDsIndex()
      {
        return flagHasResultIDsIndex;
      }

    public sbyte  getResultIDsIndex()
      {
        Debug.Assert(flagHasResultIDsIndex);
        return storeResultIDsIndex;
      }

    public bool  hasResultIDsIndexRepeated()
      {
        return flagHasResultIDsIndexRepeated;
      }

    public bool  getResultIDsIndexRepeated()
      {
        Debug.Assert(flagHasResultIDsIndexRepeated);
        return storeResultIDsIndexRepeated;
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

    public string  elementOfPlacesInclude(int element_num)
      {
        Debug.Assert(flagHasPlacesInclude);
        return storePlacesInclude[element_num];
      }

    public List< string >  getPlacesInclude()
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

    public string  elementOfPlacesExclude(int element_num)
      {
        Debug.Assert(flagHasPlacesExclude);
        return storePlacesExclude[element_num];
      }

    public List< string >  getPlacesExclude()
      {
        Debug.Assert(flagHasPlacesExclude);
        return storePlacesExclude;
      }

    public bool  hasExcludedPlacesSpoken()
      {
        return flagHasExcludedPlacesSpoken;
      }

    public string  getExcludedPlacesSpoken()
      {
        Debug.Assert(flagHasExcludedPlacesSpoken);
        return storeExcludedPlacesSpoken;
      }

    public bool  hasExcludedPlacesWritten()
      {
        return flagHasExcludedPlacesWritten;
      }

    public string  getExcludedPlacesWritten()
      {
        Debug.Assert(flagHasExcludedPlacesWritten);
        return storeExcludedPlacesWritten;
      }

    public bool  hasHistoryInclude()
      {
        return flagHasHistoryInclude;
      }

    public SetOfTimeJSON   getHistoryInclude()
      {
        Debug.Assert(flagHasHistoryInclude);
        return storeHistoryInclude;
      }

    public bool  hasHistoryExclude()
      {
        return flagHasHistoryExclude;
      }

    public SetOfTimeJSON   getHistoryExclude()
      {
        Debug.Assert(flagHasHistoryExclude);
        return storeHistoryExclude;
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

    public AmenityGroupSpecJSON   elementOfAmenitiesInclude(int element_num)
      {
        Debug.Assert(flagHasAmenitiesInclude);
        return storeAmenitiesInclude[element_num];
      }

    public List< AmenityGroupSpecJSON  >  getAmenitiesInclude()
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

    public AmenityGroupSpecJSON   elementOfAmenitiesIncludeSupported(int element_num)
      {
        Debug.Assert(flagHasAmenitiesIncludeSupported);
        return storeAmenitiesIncludeSupported[element_num];
      }

    public List< AmenityGroupSpecJSON  >  getAmenitiesIncludeSupported()
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

    public AmenityGroupSpecJSON   elementOfAmenitiesIncludeNotSupported(int element_num)
      {
        Debug.Assert(flagHasAmenitiesIncludeNotSupported);
        return storeAmenitiesIncludeNotSupported[element_num];
      }

    public List< AmenityGroupSpecJSON  >  getAmenitiesIncludeNotSupported()
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

    public AmenityGroupSpecJSON   elementOfAmenitiesExclude(int element_num)
      {
        Debug.Assert(flagHasAmenitiesExclude);
        return storeAmenitiesExclude[element_num];
      }

    public List< AmenityGroupSpecJSON  >  getAmenitiesExclude()
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

    public AmenityGroupSpecJSON   elementOfAmenitiesExcludeSupported(int element_num)
      {
        Debug.Assert(flagHasAmenitiesExcludeSupported);
        return storeAmenitiesExcludeSupported[element_num];
      }

    public List< AmenityGroupSpecJSON  >  getAmenitiesExcludeSupported()
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

    public AmenityGroupSpecJSON   elementOfAmenitiesExcludeNotSupported(int element_num)
      {
        Debug.Assert(flagHasAmenitiesExcludeNotSupported);
        return storeAmenitiesExcludeNotSupported[element_num];
      }

    public List< AmenityGroupSpecJSON  >  getAmenitiesExcludeNotSupported()
      {
        Debug.Assert(flagHasAmenitiesExcludeNotSupported);
        return storeAmenitiesExcludeNotSupported;
      }


    public virtual int extraLocalSearchFilterSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraLocalSearchFilterSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraLocalSearchFilterSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraLocalSearchFilterSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setQueryType(TypeQueryType new_value)
      {
        flagHasQueryType = true;
        storeQueryType = new_value;
      }
    public void setQueryType(string chars)
      {
        TypeQueryTypeKnownValues known = stringToQueryType(chars);
        TypeQueryType new_value = new TypeQueryType();
        if (known == TypeQueryTypeKnownValues.QueryType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setQueryType(new_value);
      }
    public void setQueryType(TypeQueryTypeKnownValues new_value)
      {
        TypeQueryType new_full_value = new TypeQueryType();
        Debug.Assert(new_value != TypeQueryTypeKnownValues.QueryType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setQueryType(new_full_value);
      }
    public void unsetQueryType()
      {
        flagHasQueryType = false;
      }
    public void setResultCount(sbyte new_value)
      {
        flagHasResultCount = true;
        if (new_value < 0)
            throw new Exception("The value for field ResultCount of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 30)
            throw new Exception("The value for field ResultCount of LocalSearchFilterSpecJSON is greater than the upper bound (30) for that field.");
        storeResultCount = new_value;
      }
    public void unsetResultCount()
      {
        flagHasResultCount = false;
      }
    public void setMapLocation(MapLocationJSON  new_value)
      {
        if (flagHasMapLocation)
          {
          }
        flagHasMapLocation = true;
        storeMapLocation = new_value;
      }
    public void unsetMapLocation()
      {
        if (flagHasMapLocation)
          {
          }
        flagHasMapLocation = false;
      }
    public void setRadius(double new_value)
      {
        flagHasRadius = true;
        if (new_value < 0)
            throw new Exception("The value for field Radius of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        storeRadius = new_value;
        textStoreRadius = "";
      }
    public void setRadiusText(string new_value)
      {
        flagHasRadius = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Radius of LocalSearchFilterSpecJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field Radius of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        textStoreRadius = new_value;
      }
    public void unsetRadius()
      {
        flagHasRadius = false;
      }
    public void setRadiusUnit(TypeRadiusUnit new_value)
      {
        flagHasRadiusUnit = true;
        storeRadiusUnit = new_value;
      }
    public void setRadiusUnit(string chars)
      {
        setRadiusUnit(stringToRadiusUnit(chars));
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
    public void setRoutePoints(RoutePointsJSON  new_value)
      {
        if (flagHasRoutePoints)
          {
          }
        flagHasRoutePoints = true;
        storeRoutePoints = new_value;
      }
    public void unsetRoutePoints()
      {
        if (flagHasRoutePoints)
          {
          }
        flagHasRoutePoints = false;
      }
    public void setLocalSearchQuestions(LocalSearchQuestionsSpecJSON  new_value)
      {
        if (flagHasLocalSearchQuestions)
          {
          }
        flagHasLocalSearchQuestions = true;
        storeLocalSearchQuestions = new_value;
      }
    public void unsetLocalSearchQuestions()
      {
        if (flagHasLocalSearchQuestions)
          {
          }
        flagHasLocalSearchQuestions = false;
      }
    public void setOpenHours(OpenHoursSpecJSON  new_value)
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
    public void setOpenHoursSpokenResponse(string new_value)
      {
        flagHasOpenHoursSpokenResponse = true;
        storeOpenHoursSpokenResponse = new_value;
      }
    public void unsetOpenHoursSpokenResponse()
      {
        flagHasOpenHoursSpokenResponse = false;
      }
    public void setOpenHoursWrittenResponse(string new_value)
      {
        flagHasOpenHoursWrittenResponse = true;
        storeOpenHoursWrittenResponse = new_value;
      }
    public void unsetOpenHoursWrittenResponse()
      {
        flagHasOpenHoursWrittenResponse = false;
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
    public void initSortCriteria()
      {
        flagHasSortCriteria = true;
        storeSortCriteria.Clear();
      }
    public void appendSortCriteria(TypeSortCriteria to_append)
      {
        if (!flagHasSortCriteria)
          {
            flagHasSortCriteria = true;
            storeSortCriteria.Clear();
          }
        Debug.Assert(flagHasSortCriteria);
        storeSortCriteria.Add(to_append);
      }
    public void appendSortCriteria(string chars)
      {
        appendSortCriteria(stringToSortCriteria(chars));
      }
    public void unsetSortCriteria()
      {
        flagHasSortCriteria = false;
        storeSortCriteria.Clear();
      }
    public void initSortOrder()
      {
        flagHasSortOrder = true;
        storeSortOrder.Clear();
      }
    public void appendSortOrder(TypeSortOrder to_append)
      {
        if (!flagHasSortOrder)
          {
            flagHasSortOrder = true;
            storeSortOrder.Clear();
          }
        Debug.Assert(flagHasSortOrder);
        storeSortOrder.Add(to_append);
      }
    public void appendSortOrder(string chars)
      {
        appendSortOrder(stringToSortOrder(chars));
      }
    public void unsetSortOrder()
      {
        flagHasSortOrder = false;
        storeSortOrder.Clear();
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
    public void setConversationMode(bool new_value)
      {
        flagHasConversationMode = true;
        storeConversationMode = new_value;
      }
    public void unsetConversationMode()
      {
        flagHasConversationMode = false;
      }
    public void setStarRatingMin(double new_value)
      {
        flagHasStarRatingMin = true;
        if (new_value < 0)
            throw new Exception("The value for field StarRatingMin of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 6)
            throw new Exception("The value for field StarRatingMin of LocalSearchFilterSpecJSON is greater than the upper bound (6) for that field.");
        storeStarRatingMin = new_value;
        textStoreStarRatingMin = "";
      }
    public void setStarRatingMinText(string new_value)
      {
        flagHasStarRatingMin = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field StarRatingMin of LocalSearchFilterSpecJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field StarRatingMin of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "6", "", false, "1") > 0)
            throw new Exception("The value for field StarRatingMin of LocalSearchFilterSpecJSON is greater than the upper bound (6) for that field.");
        textStoreStarRatingMin = new_value;
      }
    public void unsetStarRatingMin()
      {
        flagHasStarRatingMin = false;
      }
    public void setStarRatingMax(double new_value)
      {
        flagHasStarRatingMax = true;
        if (new_value < 0)
            throw new Exception("The value for field StarRatingMax of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 6)
            throw new Exception("The value for field StarRatingMax of LocalSearchFilterSpecJSON is greater than the upper bound (6) for that field.");
        storeStarRatingMax = new_value;
        textStoreStarRatingMax = "";
      }
    public void setStarRatingMaxText(string new_value)
      {
        flagHasStarRatingMax = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field StarRatingMax of LocalSearchFilterSpecJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field StarRatingMax of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "6", "", false, "1") > 0)
            throw new Exception("The value for field StarRatingMax of LocalSearchFilterSpecJSON is greater than the upper bound (6) for that field.");
        textStoreStarRatingMax = new_value;
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
    public void appendStarRatingsInclude(double to_append)
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
    public void appendStarRatingsExclude(double to_append)
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
    public void setReviewCountMin(BigInteger new_value)
      {
        flagHasReviewCountMin = true;
        if (new_value < 0)
            throw new Exception("The value for field ReviewCountMin of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        storeReviewCountMin = new_value;
      }
    public void unsetReviewCountMin()
      {
        flagHasReviewCountMin = false;
      }
    public void setReviewCountMax(BigInteger new_value)
      {
        flagHasReviewCountMax = true;
        if (new_value < 0)
            throw new Exception("The value for field ReviewCountMax of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        storeReviewCountMax = new_value;
      }
    public void unsetReviewCountMax()
      {
        flagHasReviewCountMax = false;
      }
    public void setDollarSignMin(double new_value)
      {
        flagHasDollarSignMin = true;
        if (new_value < 0)
            throw new Exception("The value for field DollarSignMin of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 6)
            throw new Exception("The value for field DollarSignMin of LocalSearchFilterSpecJSON is greater than the upper bound (6) for that field.");
        storeDollarSignMin = new_value;
        textStoreDollarSignMin = "";
      }
    public void setDollarSignMinText(string new_value)
      {
        flagHasDollarSignMin = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field DollarSignMin of LocalSearchFilterSpecJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field DollarSignMin of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "6", "", false, "1") > 0)
            throw new Exception("The value for field DollarSignMin of LocalSearchFilterSpecJSON is greater than the upper bound (6) for that field.");
        textStoreDollarSignMin = new_value;
      }
    public void unsetDollarSignMin()
      {
        flagHasDollarSignMin = false;
      }
    public void setDollarSignMax(double new_value)
      {
        flagHasDollarSignMax = true;
        if (new_value < 0)
            throw new Exception("The value for field DollarSignMax of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 6)
            throw new Exception("The value for field DollarSignMax of LocalSearchFilterSpecJSON is greater than the upper bound (6) for that field.");
        storeDollarSignMax = new_value;
        textStoreDollarSignMax = "";
      }
    public void setDollarSignMaxText(string new_value)
      {
        flagHasDollarSignMax = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field DollarSignMax of LocalSearchFilterSpecJSON is not a valid number.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "", "", false, "") < 0)
            throw new Exception("The value for field DollarSignMax of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "6", "", false, "1") > 0)
            throw new Exception("The value for field DollarSignMax of LocalSearchFilterSpecJSON is greater than the upper bound (6) for that field.");
        textStoreDollarSignMax = new_value;
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
    public void appendDollarSignsInclude(double to_append)
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
    public void appendDollarSignsExclude(double to_append)
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
    public void appendCategoriesInclude(string to_append)
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
    public void appendCategoriesExclude(string to_append)
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
    public void appendChainsInclude(string to_append)
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
    public void appendChainsExclude(string to_append)
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
    public void appendProductsInclude(string to_append)
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
    public void appendProductsExclude(string to_append)
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
    public void initResultIDsReferenced()
      {
        flagHasResultIDsReferenced = true;
        storeResultIDsReferenced.Clear();
      }
    public void appendResultIDsReferenced(string to_append)
      {
        if (!flagHasResultIDsReferenced)
          {
            flagHasResultIDsReferenced = true;
            storeResultIDsReferenced.Clear();
          }
        Debug.Assert(flagHasResultIDsReferenced);
        storeResultIDsReferenced.Add(to_append);
      }
    public void unsetResultIDsReferenced()
      {
        flagHasResultIDsReferenced = false;
        storeResultIDsReferenced.Clear();
      }
    public void setResultIDsIndex(sbyte new_value)
      {
        flagHasResultIDsIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field ResultIDsIndex of LocalSearchFilterSpecJSON is less than the lower bound (0) for that field.");
        if (new_value > 100)
            throw new Exception("The value for field ResultIDsIndex of LocalSearchFilterSpecJSON is greater than the upper bound (100) for that field.");
        storeResultIDsIndex = new_value;
      }
    public void unsetResultIDsIndex()
      {
        flagHasResultIDsIndex = false;
      }
    public void setResultIDsIndexRepeated(bool new_value)
      {
        flagHasResultIDsIndexRepeated = true;
        storeResultIDsIndexRepeated = new_value;
      }
    public void unsetResultIDsIndexRepeated()
      {
        flagHasResultIDsIndexRepeated = false;
      }
    public void initPlacesInclude()
      {
        flagHasPlacesInclude = true;
        storePlacesInclude.Clear();
      }
    public void appendPlacesInclude(string to_append)
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
    public void appendPlacesExclude(string to_append)
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
    public void setExcludedPlacesSpoken(string new_value)
      {
        flagHasExcludedPlacesSpoken = true;
        storeExcludedPlacesSpoken = new_value;
      }
    public void unsetExcludedPlacesSpoken()
      {
        flagHasExcludedPlacesSpoken = false;
      }
    public void setExcludedPlacesWritten(string new_value)
      {
        flagHasExcludedPlacesWritten = true;
        storeExcludedPlacesWritten = new_value;
      }
    public void unsetExcludedPlacesWritten()
      {
        flagHasExcludedPlacesWritten = false;
      }
    public void setHistoryInclude(SetOfTimeJSON  new_value)
      {
        if (flagHasHistoryInclude)
          {
          }
        flagHasHistoryInclude = true;
        storeHistoryInclude = new_value;
      }
    public void unsetHistoryInclude()
      {
        if (flagHasHistoryInclude)
          {
          }
        flagHasHistoryInclude = false;
      }
    public void setHistoryExclude(SetOfTimeJSON  new_value)
      {
        if (flagHasHistoryExclude)
          {
          }
        flagHasHistoryExclude = true;
        storeHistoryExclude = new_value;
      }
    public void unsetHistoryExclude()
      {
        if (flagHasHistoryExclude)
          {
          }
        flagHasHistoryExclude = false;
      }
    public void initAmenitiesInclude()
      {
        if (flagHasAmenitiesInclude)
          {
            for (int num1 = 0; num1 < storeAmenitiesInclude.Count; ++num1)
              {
              }
          }
        flagHasAmenitiesInclude = true;
        storeAmenitiesInclude.Clear();
      }
    public void appendAmenitiesInclude(AmenityGroupSpecJSON  to_append)
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
        if (flagHasAmenitiesInclude)
          {
            for (int num2 = 0; num2 < storeAmenitiesInclude.Count; ++num2)
              {
              }
          }
        flagHasAmenitiesInclude = false;
        storeAmenitiesInclude.Clear();
      }
    public void initAmenitiesIncludeSupported()
      {
        if (flagHasAmenitiesIncludeSupported)
          {
            for (int num3 = 0; num3 < storeAmenitiesIncludeSupported.Count; ++num3)
              {
              }
          }
        flagHasAmenitiesIncludeSupported = true;
        storeAmenitiesIncludeSupported.Clear();
      }
    public void appendAmenitiesIncludeSupported(AmenityGroupSpecJSON  to_append)
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
        if (flagHasAmenitiesIncludeSupported)
          {
            for (int num4 = 0; num4 < storeAmenitiesIncludeSupported.Count; ++num4)
              {
              }
          }
        flagHasAmenitiesIncludeSupported = false;
        storeAmenitiesIncludeSupported.Clear();
      }
    public void initAmenitiesIncludeNotSupported()
      {
        if (flagHasAmenitiesIncludeNotSupported)
          {
            for (int num5 = 0; num5 < storeAmenitiesIncludeNotSupported.Count; ++num5)
              {
              }
          }
        flagHasAmenitiesIncludeNotSupported = true;
        storeAmenitiesIncludeNotSupported.Clear();
      }
    public void appendAmenitiesIncludeNotSupported(AmenityGroupSpecJSON  to_append)
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
        if (flagHasAmenitiesIncludeNotSupported)
          {
            for (int num6 = 0; num6 < storeAmenitiesIncludeNotSupported.Count; ++num6)
              {
              }
          }
        flagHasAmenitiesIncludeNotSupported = false;
        storeAmenitiesIncludeNotSupported.Clear();
      }
    public void initAmenitiesExclude()
      {
        if (flagHasAmenitiesExclude)
          {
            for (int num7 = 0; num7 < storeAmenitiesExclude.Count; ++num7)
              {
              }
          }
        flagHasAmenitiesExclude = true;
        storeAmenitiesExclude.Clear();
      }
    public void appendAmenitiesExclude(AmenityGroupSpecJSON  to_append)
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
        if (flagHasAmenitiesExclude)
          {
            for (int num8 = 0; num8 < storeAmenitiesExclude.Count; ++num8)
              {
              }
          }
        flagHasAmenitiesExclude = false;
        storeAmenitiesExclude.Clear();
      }
    public void initAmenitiesExcludeSupported()
      {
        if (flagHasAmenitiesExcludeSupported)
          {
            for (int num9 = 0; num9 < storeAmenitiesExcludeSupported.Count; ++num9)
              {
              }
          }
        flagHasAmenitiesExcludeSupported = true;
        storeAmenitiesExcludeSupported.Clear();
      }
    public void appendAmenitiesExcludeSupported(AmenityGroupSpecJSON  to_append)
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
        if (flagHasAmenitiesExcludeSupported)
          {
            for (int num10 = 0; num10 < storeAmenitiesExcludeSupported.Count; ++num10)
              {
              }
          }
        flagHasAmenitiesExcludeSupported = false;
        storeAmenitiesExcludeSupported.Clear();
      }
    public void initAmenitiesExcludeNotSupported()
      {
        if (flagHasAmenitiesExcludeNotSupported)
          {
            for (int num11 = 0; num11 < storeAmenitiesExcludeNotSupported.Count; ++num11)
              {
              }
          }
        flagHasAmenitiesExcludeNotSupported = true;
        storeAmenitiesExcludeNotSupported.Clear();
      }
    public void appendAmenitiesExcludeNotSupported(AmenityGroupSpecJSON  to_append)
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
        if (flagHasAmenitiesExcludeNotSupported)
          {
            for (int num12 = 0; num12 < storeAmenitiesExcludeNotSupported.Count; ++num12)
              {
              }
          }
        flagHasAmenitiesExcludeNotSupported = false;
        storeAmenitiesExcludeNotSupported.Clear();
      }

    public virtual void extraLocalSearchFilterSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraLocalSearchFilterSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraLocalSearchFilterSpecLookup(key);
        if (old_field == null)
          {
            extraLocalSearchFilterSpecAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryType);
        if (flagHasQueryType)
          {
            handler.start_pair("QueryType");
            if (storeQueryType.in_known_list)
              {
                switch (storeQueryType.list_value)
                  {
                    case TypeQueryTypeKnownValues.QueryType_Search:
                        handler.string_value("Search");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_Question:
                        handler.string_value("Question");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_ActionsCall:
                        handler.string_value("ActionsCall");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeQueryType.string_value);
              }
          }
        if (flagHasResultCount)
          {
            handler.start_pair("ResultCount");
            handler.number_value(storeResultCount);
          }
        if (flagHasMapLocation)
          {
            handler.start_pair("MapLocation");
            if (partial_allowed)
                storeMapLocation.write_partial_as_json(handler);
            else
                storeMapLocation.write_as_json(handler);
          }
        if (flagHasRadius)
          {
            handler.start_pair("Radius");
            if (textStoreRadius != "")
                handler.number_value(textStoreRadius);
            else if (((double)(long)storeRadius) == storeRadius)
                handler.number_value((long)storeRadius);
            else
                handler.number_value(storeRadius);
          }
        if (flagHasRadiusUnit)
          {
            handler.start_pair("RadiusUnit");
            switch (storeRadiusUnit)
              {
                case TypeRadiusUnit.RadiusUnit_Kilometers:
                    handler.string_value("Kilometers");
                    break;
                case TypeRadiusUnit.RadiusUnit_Miles:
                    handler.string_value("Miles");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        if (flagHasRoutePoints)
          {
            handler.start_pair("RoutePoints");
            if (partial_allowed)
                storeRoutePoints.write_partial_as_json(handler);
            else
                storeRoutePoints.write_as_json(handler);
          }
        if (flagHasLocalSearchQuestions)
          {
            handler.start_pair("LocalSearchQuestions");
            if (partial_allowed)
                storeLocalSearchQuestions.write_partial_as_json(handler);
            else
                storeLocalSearchQuestions.write_as_json(handler);
          }
        if (flagHasOpenHours)
          {
            handler.start_pair("OpenHours");
            if (partial_allowed)
                storeOpenHours.write_partial_as_json(handler);
            else
                storeOpenHours.write_as_json(handler);
          }
        if (flagHasOpenHoursSpokenResponse)
          {
            handler.start_pair("OpenHoursSpokenResponse");
            handler.string_value(storeOpenHoursSpokenResponse);
          }
        if (flagHasOpenHoursWrittenResponse)
          {
            handler.start_pair("OpenHoursWrittenResponse");
            handler.string_value(storeOpenHoursWrittenResponse);
          }
        if (flagHasOpenHoursFilterOnHoliday)
          {
            handler.start_pair("OpenHoursFilterOnHoliday");
            handler.boolean_value(storeOpenHoursFilterOnHoliday);
          }
        if (flagHasSortCriteria)
          {
            handler.start_pair("SortCriteria");
            handler.start_array();
            for (int num1 = 0; num1 < storeSortCriteria.Count; ++num1)
              {
                switch (storeSortCriteria[num1])
                  {
                    case TypeSortCriteria.SortCriteria_Distance:
                        handler.string_value("Distance");
                        break;
                    case TypeSortCriteria.SortCriteria_Price:
                        handler.string_value("Price");
                        break;
                    case TypeSortCriteria.SortCriteria_StarRating:
                        handler.string_value("StarRating");
                        break;
                    case TypeSortCriteria.SortCriteria_ReviewCount:
                        handler.string_value("ReviewCount");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            handler.finish_array();
          }
        if (flagHasSortOrder)
          {
            handler.start_pair("SortOrder");
            handler.start_array();
            for (int num2 = 0; num2 < storeSortOrder.Count; ++num2)
              {
                switch (storeSortOrder[num2])
                  {
                    case TypeSortOrder.SortOrder_Ascending:
                        handler.string_value("Ascending");
                        break;
                    case TypeSortOrder.SortOrder_Descending:
                        handler.string_value("Descending");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
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
        if (flagHasConversationMode)
          {
            handler.start_pair("ConversationMode");
            handler.boolean_value(storeConversationMode);
          }
        if (flagHasStarRatingMin)
          {
            handler.start_pair("StarRatingMin");
            if (textStoreStarRatingMin != "")
                handler.number_value(textStoreStarRatingMin);
            else if (((double)(long)storeStarRatingMin) == storeStarRatingMin)
                handler.number_value((long)storeStarRatingMin);
            else
                handler.number_value(storeStarRatingMin);
          }
        if (flagHasStarRatingMax)
          {
            handler.start_pair("StarRatingMax");
            if (textStoreStarRatingMax != "")
                handler.number_value(textStoreStarRatingMax);
            else if (((double)(long)storeStarRatingMax) == storeStarRatingMax)
                handler.number_value((long)storeStarRatingMax);
            else
                handler.number_value(storeStarRatingMax);
          }
        if (flagHasStarRatingsInclude)
          {
            handler.start_pair("StarRatingsInclude");
            handler.start_array();
            for (int num3 = 0; num3 < storeStarRatingsInclude.Count; ++num3)
              {
                if (((double)(long)storeStarRatingsInclude[num3]) == storeStarRatingsInclude[num3])
                    handler.number_value((long)storeStarRatingsInclude[num3]);
                else
                    handler.number_value(storeStarRatingsInclude[num3]);
              }
            handler.finish_array();
          }
        if (flagHasStarRatingsExclude)
          {
            handler.start_pair("StarRatingsExclude");
            handler.start_array();
            for (int num4 = 0; num4 < storeStarRatingsExclude.Count; ++num4)
              {
                if (((double)(long)storeStarRatingsExclude[num4]) == storeStarRatingsExclude[num4])
                    handler.number_value((long)storeStarRatingsExclude[num4]);
                else
                    handler.number_value(storeStarRatingsExclude[num4]);
              }
            handler.finish_array();
          }
        if (flagHasReviewCountMin)
          {
            handler.start_pair("ReviewCountMin");
            handler.number_value(storeReviewCountMin);
          }
        if (flagHasReviewCountMax)
          {
            handler.start_pair("ReviewCountMax");
            handler.number_value(storeReviewCountMax);
          }
        if (flagHasDollarSignMin)
          {
            handler.start_pair("DollarSignMin");
            if (textStoreDollarSignMin != "")
                handler.number_value(textStoreDollarSignMin);
            else if (((double)(long)storeDollarSignMin) == storeDollarSignMin)
                handler.number_value((long)storeDollarSignMin);
            else
                handler.number_value(storeDollarSignMin);
          }
        if (flagHasDollarSignMax)
          {
            handler.start_pair("DollarSignMax");
            if (textStoreDollarSignMax != "")
                handler.number_value(textStoreDollarSignMax);
            else if (((double)(long)storeDollarSignMax) == storeDollarSignMax)
                handler.number_value((long)storeDollarSignMax);
            else
                handler.number_value(storeDollarSignMax);
          }
        if (flagHasDollarSignsInclude)
          {
            handler.start_pair("DollarSignsInclude");
            handler.start_array();
            for (int num5 = 0; num5 < storeDollarSignsInclude.Count; ++num5)
              {
                if (((double)(long)storeDollarSignsInclude[num5]) == storeDollarSignsInclude[num5])
                    handler.number_value((long)storeDollarSignsInclude[num5]);
                else
                    handler.number_value(storeDollarSignsInclude[num5]);
              }
            handler.finish_array();
          }
        if (flagHasDollarSignsExclude)
          {
            handler.start_pair("DollarSignsExclude");
            handler.start_array();
            for (int num6 = 0; num6 < storeDollarSignsExclude.Count; ++num6)
              {
                if (((double)(long)storeDollarSignsExclude[num6]) == storeDollarSignsExclude[num6])
                    handler.number_value((long)storeDollarSignsExclude[num6]);
                else
                    handler.number_value(storeDollarSignsExclude[num6]);
              }
            handler.finish_array();
          }
        if (flagHasCategoriesInclude)
          {
            handler.start_pair("CategoriesInclude");
            handler.start_array();
            for (int num7 = 0; num7 < storeCategoriesInclude.Count; ++num7)
              {
                handler.string_value(storeCategoriesInclude[num7]);
              }
            handler.finish_array();
          }
        if (flagHasCategoriesExclude)
          {
            handler.start_pair("CategoriesExclude");
            handler.start_array();
            for (int num8 = 0; num8 < storeCategoriesExclude.Count; ++num8)
              {
                handler.string_value(storeCategoriesExclude[num8]);
              }
            handler.finish_array();
          }
        if (flagHasChainsInclude)
          {
            handler.start_pair("ChainsInclude");
            handler.start_array();
            for (int num9 = 0; num9 < storeChainsInclude.Count; ++num9)
              {
                handler.string_value(storeChainsInclude[num9]);
              }
            handler.finish_array();
          }
        if (flagHasChainsExclude)
          {
            handler.start_pair("ChainsExclude");
            handler.start_array();
            for (int num10 = 0; num10 < storeChainsExclude.Count; ++num10)
              {
                handler.string_value(storeChainsExclude[num10]);
              }
            handler.finish_array();
          }
        if (flagHasProductsInclude)
          {
            handler.start_pair("ProductsInclude");
            handler.start_array();
            for (int num11 = 0; num11 < storeProductsInclude.Count; ++num11)
              {
                handler.string_value(storeProductsInclude[num11]);
              }
            handler.finish_array();
          }
        if (flagHasProductsExclude)
          {
            handler.start_pair("ProductsExclude");
            handler.start_array();
            for (int num12 = 0; num12 < storeProductsExclude.Count; ++num12)
              {
                handler.string_value(storeProductsExclude[num12]);
              }
            handler.finish_array();
          }
        if (flagHasResultIDsReferenced)
          {
            handler.start_pair("ResultIDsReferenced");
            handler.start_array();
            for (int num13 = 0; num13 < storeResultIDsReferenced.Count; ++num13)
              {
                handler.string_value(storeResultIDsReferenced[num13]);
              }
            handler.finish_array();
          }
        if (flagHasResultIDsIndex)
          {
            handler.start_pair("ResultIDsIndex");
            handler.number_value(storeResultIDsIndex);
          }
        if (flagHasResultIDsIndexRepeated)
          {
            handler.start_pair("ResultIDsIndexRepeated");
            handler.boolean_value(storeResultIDsIndexRepeated);
          }
        if (flagHasPlacesInclude)
          {
            handler.start_pair("PlacesInclude");
            handler.start_array();
            for (int num14 = 0; num14 < storePlacesInclude.Count; ++num14)
              {
                handler.string_value(storePlacesInclude[num14]);
              }
            handler.finish_array();
          }
        if (flagHasPlacesExclude)
          {
            handler.start_pair("PlacesExclude");
            handler.start_array();
            for (int num15 = 0; num15 < storePlacesExclude.Count; ++num15)
              {
                handler.string_value(storePlacesExclude[num15]);
              }
            handler.finish_array();
          }
        if (flagHasExcludedPlacesSpoken)
          {
            handler.start_pair("ExcludedPlacesSpoken");
            handler.string_value(storeExcludedPlacesSpoken);
          }
        if (flagHasExcludedPlacesWritten)
          {
            handler.start_pair("ExcludedPlacesWritten");
            handler.string_value(storeExcludedPlacesWritten);
          }
        if (flagHasHistoryInclude)
          {
            handler.start_pair("HistoryInclude");
            if (partial_allowed)
                storeHistoryInclude.write_partial_as_json(handler);
            else
                storeHistoryInclude.write_as_json(handler);
          }
        if (flagHasHistoryExclude)
          {
            handler.start_pair("HistoryExclude");
            if (partial_allowed)
                storeHistoryExclude.write_partial_as_json(handler);
            else
                storeHistoryExclude.write_as_json(handler);
          }
        if (flagHasAmenitiesInclude)
          {
            handler.start_pair("AmenitiesInclude");
            handler.start_array();
            for (int num16 = 0; num16 < storeAmenitiesInclude.Count; ++num16)
              {
                if (partial_allowed)
                    storeAmenitiesInclude[num16].write_partial_as_json(handler);
                else
                    storeAmenitiesInclude[num16].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesIncludeSupported)
          {
            handler.start_pair("AmenitiesIncludeSupported");
            handler.start_array();
            for (int num17 = 0; num17 < storeAmenitiesIncludeSupported.Count; ++num17)
              {
                if (partial_allowed)
                    storeAmenitiesIncludeSupported[num17].write_partial_as_json(handler);
                else
                    storeAmenitiesIncludeSupported[num17].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesIncludeNotSupported)
          {
            handler.start_pair("AmenitiesIncludeNotSupported");
            handler.start_array();
            for (int num18 = 0; num18 < storeAmenitiesIncludeNotSupported.Count; ++num18)
              {
                if (partial_allowed)
                    storeAmenitiesIncludeNotSupported[num18].write_partial_as_json(handler);
                else
                    storeAmenitiesIncludeNotSupported[num18].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesExclude)
          {
            handler.start_pair("AmenitiesExclude");
            handler.start_array();
            for (int num19 = 0; num19 < storeAmenitiesExclude.Count; ++num19)
              {
                if (partial_allowed)
                    storeAmenitiesExclude[num19].write_partial_as_json(handler);
                else
                    storeAmenitiesExclude[num19].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesExcludeSupported)
          {
            handler.start_pair("AmenitiesExcludeSupported");
            handler.start_array();
            for (int num20 = 0; num20 < storeAmenitiesExcludeSupported.Count; ++num20)
              {
                if (partial_allowed)
                    storeAmenitiesExcludeSupported[num20].write_partial_as_json(handler);
                else
                    storeAmenitiesExcludeSupported[num20].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesExcludeNotSupported)
          {
            handler.start_pair("AmenitiesExcludeNotSupported");
            handler.start_array();
            for (int num21 = 0; num21 < storeAmenitiesExcludeNotSupported.Count; ++num21)
              {
                if (partial_allowed)
                    storeAmenitiesExcludeNotSupported[num21].write_partial_as_json(handler);
                else
                    storeAmenitiesExcludeNotSupported[num21].write_as_json(handler);
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
        if (!(hasQueryType()))
          {
            return "When parsing the object for %what%, the \"QueryType\" field was missing.";
          }
        return null;
      }

    public static LocalSearchFilterSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalSearchFilterSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchFilterSpec", ignore_extras);
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
    public static LocalSearchFilterSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocalSearchFilterSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalSearchFilterSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchFilterSpec", ignore_extras);
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
    public static LocalSearchFilterSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocalSearchFilterSpecJSON from_text(string text, bool ignore_extras)
      {
        LocalSearchFilterSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchFilterSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LocalSearchFilterSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static LocalSearchFilterSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LocalSearchFilterSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchFilterSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorQueryType : JSONStringGenerator
          {
            protected FieldGeneratorQueryType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorQueryType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeQueryTypeKnownValues known = stringToQueryType(result);
                TypeQueryType new_value = new TypeQueryType();
                if (known == TypeQueryTypeKnownValues.QueryType__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeQueryType result);
          };
    private class FieldHoldingGeneratorQueryType : FieldGeneratorQueryType
  {
    protected override void handle_result(TypeQueryType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorQueryType(String what)
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
    public TypeQueryType value;
  };
    private class FieldHoldingArrayGeneratorQueryType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorQueryType
      {
        private FieldHoldingArrayGeneratorQueryType top;

        protected override void handle_result(TypeQueryType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorQueryType init_top)
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
    protected virtual void handle_result(List<TypeQueryType> result)
      {
      }

    public FieldHoldingArrayGeneratorQueryType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorQueryType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeQueryType> value;
  };
        private FieldHoldingGeneratorQueryType fieldGeneratorQueryType;
    private class FieldHoldingGeneratorResultCount : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorResultCount(String what) : base(what, 0, 30)
              {
              }
          };
    private class FieldHoldingArrayGeneratorResultCount : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorResultCount(String what) : base(what, 0, 30)
              {
              }
          };
        private FieldHoldingGeneratorResultCount fieldGeneratorResultCount;
        private MapLocationJSON.HoldingGenerator fieldGeneratorMapLocation;
        private JSONHoldingNumberTextGenerator fieldGeneratorRadius;
    private abstract class FieldGeneratorRadiusUnit : JSONStringGenerator
          {
            protected FieldGeneratorRadiusUnit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorRadiusUnit()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToRadiusUnit(result));
              }
            protected abstract void handle_result(TypeRadiusUnit result);
          };
    private class FieldHoldingGeneratorRadiusUnit : FieldGeneratorRadiusUnit
  {
    protected override void handle_result(TypeRadiusUnit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorRadiusUnit(String what)
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
    public TypeRadiusUnit value;
  };
    private class FieldHoldingArrayGeneratorRadiusUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorRadiusUnit
      {
        private FieldHoldingArrayGeneratorRadiusUnit top;

        protected override void handle_result(TypeRadiusUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorRadiusUnit init_top)
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
    protected virtual void handle_result(List<TypeRadiusUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorRadiusUnit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRadiusUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorRadiusUnit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeRadiusUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeRadiusUnit> value;
  };
        private FieldHoldingGeneratorRadiusUnit fieldGeneratorRadiusUnit;
        private JSONHoldingBooleanGenerator fieldGeneratorRadiusInferred;
        private JSONHoldingBooleanGenerator fieldGeneratorAlongTheRoute;
        private RoutePointsJSON.HoldingGenerator fieldGeneratorRoutePoints;
        private LocalSearchQuestionsSpecJSON.HoldingGenerator fieldGeneratorLocalSearchQuestions;
        private OpenHoursSpecJSON.HoldingGenerator fieldGeneratorOpenHours;
        private JSONHoldingStringGenerator fieldGeneratorOpenHoursSpokenResponse;
        private JSONHoldingStringGenerator fieldGeneratorOpenHoursWrittenResponse;
        private JSONHoldingBooleanGenerator fieldGeneratorOpenHoursFilterOnHoliday;
    private abstract class FieldGeneratorSortCriteria : JSONStringGenerator
          {
            protected FieldGeneratorSortCriteria(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSortCriteria()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSortCriteria(result));
              }
            protected abstract void handle_result(TypeSortCriteria result);
          };
    private class FieldHoldingGeneratorSortCriteria : FieldGeneratorSortCriteria
  {
    protected override void handle_result(TypeSortCriteria result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSortCriteria(String what)
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
    public TypeSortCriteria value;
  };
    private class FieldHoldingArrayGeneratorSortCriteria : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSortCriteria
      {
        private FieldHoldingArrayGeneratorSortCriteria top;

        protected override void handle_result(TypeSortCriteria result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSortCriteria init_top)
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
    protected virtual void handle_result(List<TypeSortCriteria> result)
      {
      }

    public FieldHoldingArrayGeneratorSortCriteria(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSortCriteria>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSortCriteria()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSortCriteria>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSortCriteria> value;
  };
        private FieldHoldingArrayGeneratorSortCriteria fieldGeneratorSortCriteria;
    private abstract class FieldGeneratorSortOrder : JSONStringGenerator
          {
            protected FieldGeneratorSortOrder(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorSortOrder()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToSortOrder(result));
              }
            protected abstract void handle_result(TypeSortOrder result);
          };
    private class FieldHoldingGeneratorSortOrder : FieldGeneratorSortOrder
  {
    protected override void handle_result(TypeSortOrder result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorSortOrder(String what)
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
    public TypeSortOrder value;
  };
    private class FieldHoldingArrayGeneratorSortOrder : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorSortOrder
      {
        private FieldHoldingArrayGeneratorSortOrder top;

        protected override void handle_result(TypeSortOrder result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorSortOrder init_top)
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
    protected virtual void handle_result(List<TypeSortOrder> result)
      {
      }

    public FieldHoldingArrayGeneratorSortOrder(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSortOrder>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorSortOrder()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeSortOrder>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeSortOrder> value;
  };
        private FieldHoldingArrayGeneratorSortOrder fieldGeneratorSortOrder;
        private JSONHoldingBooleanGenerator fieldGeneratorExpensiveFlag;
        private JSONHoldingBooleanGenerator fieldGeneratorInexpensiveFlag;
        private JSONHoldingBooleanGenerator fieldGeneratorConversationMode;
        private JSONHoldingNumberTextGenerator fieldGeneratorStarRatingMin;
        private JSONHoldingNumberTextGenerator fieldGeneratorStarRatingMax;
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorStarRatingsInclude;
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorStarRatingsExclude;
    private class FieldHoldingGeneratorReviewCountMin : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorReviewCountMin(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorReviewCountMin : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorReviewCountMin(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorReviewCountMin fieldGeneratorReviewCountMin;
    private class FieldHoldingGeneratorReviewCountMax : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorReviewCountMax(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorReviewCountMax : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorReviewCountMax(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorReviewCountMax fieldGeneratorReviewCountMax;
        private JSONHoldingNumberTextGenerator fieldGeneratorDollarSignMin;
        private JSONHoldingNumberTextGenerator fieldGeneratorDollarSignMax;
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorDollarSignsInclude;
        private JSONHoldingNumberTextArrayGenerator fieldGeneratorDollarSignsExclude;
        private JSONHoldingStringArrayGenerator fieldGeneratorCategoriesInclude;
        private JSONHoldingStringArrayGenerator fieldGeneratorCategoriesExclude;
        private JSONHoldingStringArrayGenerator fieldGeneratorChainsInclude;
        private JSONHoldingStringArrayGenerator fieldGeneratorChainsExclude;
        private JSONHoldingStringArrayGenerator fieldGeneratorProductsInclude;
        private JSONHoldingStringArrayGenerator fieldGeneratorProductsExclude;
        private JSONHoldingStringArrayGenerator fieldGeneratorResultIDsReferenced;
    private class FieldHoldingGeneratorResultIDsIndex : JSONHoldingIntegerRangeGenerator
          {
            public FieldHoldingGeneratorResultIDsIndex(String what) : base(what, 0, 100)
              {
              }
          };
    private class FieldHoldingArrayGeneratorResultIDsIndex : JSONHoldingIntegerRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorResultIDsIndex(String what) : base(what, 0, 100)
              {
              }
          };
        private FieldHoldingGeneratorResultIDsIndex fieldGeneratorResultIDsIndex;
        private JSONHoldingBooleanGenerator fieldGeneratorResultIDsIndexRepeated;
        private JSONHoldingStringArrayGenerator fieldGeneratorPlacesInclude;
        private JSONHoldingStringArrayGenerator fieldGeneratorPlacesExclude;
        private JSONHoldingStringGenerator fieldGeneratorExcludedPlacesSpoken;
        private JSONHoldingStringGenerator fieldGeneratorExcludedPlacesWritten;
        private SetOfTimeJSON.HoldingGenerator fieldGeneratorHistoryInclude;
        private SetOfTimeJSON.HoldingGenerator fieldGeneratorHistoryExclude;
        private AmenityGroupSpecJSON.HoldingArrayGenerator fieldGeneratorAmenitiesInclude;
        private AmenityGroupSpecJSON.HoldingArrayGenerator fieldGeneratorAmenitiesIncludeSupported;
        private AmenityGroupSpecJSON.HoldingArrayGenerator fieldGeneratorAmenitiesIncludeNotSupported;
        private AmenityGroupSpecJSON.HoldingArrayGenerator fieldGeneratorAmenitiesExclude;
        private AmenityGroupSpecJSON.HoldingArrayGenerator fieldGeneratorAmenitiesExcludeSupported;
        private AmenityGroupSpecJSON.HoldingArrayGenerator fieldGeneratorAmenitiesExcludeNotSupported;
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
            LocalSearchFilterSpecJSON result = new LocalSearchFilterSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLocalSearchFilterSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(LocalSearchFilterSpecJSON result)
          {
            if (fieldGeneratorQueryType.have_value)
              {
                result.setQueryType(fieldGeneratorQueryType.value);
                fieldGeneratorQueryType.have_value = false;
              }
            else if ((!(result.hasQueryType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryType\" field was missing.");
              }
            if (fieldGeneratorResultCount.have_value)
              {
                result.setResultCount((sbyte)(fieldGeneratorResultCount.value));
                fieldGeneratorResultCount.have_value = false;
              }
            if (fieldGeneratorMapLocation.have_value)
              {
                result.setMapLocation(fieldGeneratorMapLocation.value);
                fieldGeneratorMapLocation.have_value = false;
              }
            if (fieldGeneratorRadius.have_value)
              {
                result.setRadiusText(fieldGeneratorRadius.value);
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
            if (fieldGeneratorRoutePoints.have_value)
              {
                result.setRoutePoints(fieldGeneratorRoutePoints.value);
                fieldGeneratorRoutePoints.have_value = false;
              }
            if (fieldGeneratorLocalSearchQuestions.have_value)
              {
                result.setLocalSearchQuestions(fieldGeneratorLocalSearchQuestions.value);
                fieldGeneratorLocalSearchQuestions.have_value = false;
              }
            if (fieldGeneratorOpenHours.have_value)
              {
                result.setOpenHours(fieldGeneratorOpenHours.value);
                fieldGeneratorOpenHours.have_value = false;
              }
            if (fieldGeneratorOpenHoursSpokenResponse.have_value)
              {
                result.setOpenHoursSpokenResponse(fieldGeneratorOpenHoursSpokenResponse.value);
                fieldGeneratorOpenHoursSpokenResponse.have_value = false;
              }
            if (fieldGeneratorOpenHoursWrittenResponse.have_value)
              {
                result.setOpenHoursWrittenResponse(fieldGeneratorOpenHoursWrittenResponse.value);
                fieldGeneratorOpenHoursWrittenResponse.have_value = false;
              }
            if (fieldGeneratorOpenHoursFilterOnHoliday.have_value)
              {
                result.setOpenHoursFilterOnHoliday(fieldGeneratorOpenHoursFilterOnHoliday.value);
                fieldGeneratorOpenHoursFilterOnHoliday.have_value = false;
              }
            if (fieldGeneratorSortCriteria.have_value)
              {
                result.initSortCriteria();
                int count = fieldGeneratorSortCriteria.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSortCriteria(fieldGeneratorSortCriteria.value[num]);
                  }
                fieldGeneratorSortCriteria.value.Clear();
                fieldGeneratorSortCriteria.have_value = false;
              }
            if (fieldGeneratorSortOrder.have_value)
              {
                result.initSortOrder();
                int count = fieldGeneratorSortOrder.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSortOrder(fieldGeneratorSortOrder.value[num]);
                  }
                fieldGeneratorSortOrder.value.Clear();
                fieldGeneratorSortOrder.have_value = false;
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
            if (fieldGeneratorConversationMode.have_value)
              {
                result.setConversationMode(fieldGeneratorConversationMode.value);
                fieldGeneratorConversationMode.have_value = false;
              }
            if (fieldGeneratorStarRatingMin.have_value)
              {
                result.setStarRatingMinText(fieldGeneratorStarRatingMin.value);
                fieldGeneratorStarRatingMin.have_value = false;
              }
            if (fieldGeneratorStarRatingMax.have_value)
              {
                result.setStarRatingMaxText(fieldGeneratorStarRatingMax.value);
                fieldGeneratorStarRatingMax.have_value = false;
              }
            if (fieldGeneratorStarRatingsInclude.have_value)
              {
                result.initStarRatingsInclude();
                int count = fieldGeneratorStarRatingsInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStarRatingsInclude(Double.Parse(fieldGeneratorStarRatingsInclude.value[num]));
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
                    result.appendStarRatingsExclude(Double.Parse(fieldGeneratorStarRatingsExclude.value[num]));
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
                result.setDollarSignMinText(fieldGeneratorDollarSignMin.value);
                fieldGeneratorDollarSignMin.have_value = false;
              }
            if (fieldGeneratorDollarSignMax.have_value)
              {
                result.setDollarSignMaxText(fieldGeneratorDollarSignMax.value);
                fieldGeneratorDollarSignMax.have_value = false;
              }
            if (fieldGeneratorDollarSignsInclude.have_value)
              {
                result.initDollarSignsInclude();
                int count = fieldGeneratorDollarSignsInclude.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendDollarSignsInclude(Double.Parse(fieldGeneratorDollarSignsInclude.value[num]));
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
                    result.appendDollarSignsExclude(Double.Parse(fieldGeneratorDollarSignsExclude.value[num]));
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
            if (fieldGeneratorResultIDsReferenced.have_value)
              {
                result.initResultIDsReferenced();
                int count = fieldGeneratorResultIDsReferenced.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendResultIDsReferenced(fieldGeneratorResultIDsReferenced.value[num]);
                  }
                fieldGeneratorResultIDsReferenced.value.Clear();
                fieldGeneratorResultIDsReferenced.have_value = false;
              }
            if (fieldGeneratorResultIDsIndex.have_value)
              {
                result.setResultIDsIndex((sbyte)(fieldGeneratorResultIDsIndex.value));
                fieldGeneratorResultIDsIndex.have_value = false;
              }
            if (fieldGeneratorResultIDsIndexRepeated.have_value)
              {
                result.setResultIDsIndexRepeated(fieldGeneratorResultIDsIndexRepeated.value);
                fieldGeneratorResultIDsIndexRepeated.have_value = false;
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
            if (fieldGeneratorExcludedPlacesSpoken.have_value)
              {
                result.setExcludedPlacesSpoken(fieldGeneratorExcludedPlacesSpoken.value);
                fieldGeneratorExcludedPlacesSpoken.have_value = false;
              }
            if (fieldGeneratorExcludedPlacesWritten.have_value)
              {
                result.setExcludedPlacesWritten(fieldGeneratorExcludedPlacesWritten.value);
                fieldGeneratorExcludedPlacesWritten.have_value = false;
              }
            if (fieldGeneratorHistoryInclude.have_value)
              {
                result.setHistoryInclude(fieldGeneratorHistoryInclude.value);
                fieldGeneratorHistoryInclude.have_value = false;
              }
            if (fieldGeneratorHistoryExclude.have_value)
              {
                result.setHistoryExclude(fieldGeneratorHistoryExclude.value);
                fieldGeneratorHistoryExclude.have_value = false;
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
        protected abstract void handle_result(LocalSearchFilterSpecJSON new_result);
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
                        case 'o':
                            if ((String.Compare(field_name, 2, "nversationMode", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorConversationMode;
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
                    if (String.Compare(field_name, 1, "x", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'c':
                                if (String.Compare(field_name, 3, "ludedPlaces", 0, 11, false) == 0)
                                  {
                                    switch (field_name[14])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 15, "poken", 0, 5, false) == 0) && (field_name.Length == 20))
                                                return fieldGeneratorExcludedPlacesSpoken;
                                            break;
                                        case 'W':
                                            if ((String.Compare(field_name, 15, "ritten", 0, 6, false) == 0) && (field_name.Length == 21))
                                                return fieldGeneratorExcludedPlacesWritten;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'p':
                                if ((String.Compare(field_name, 3, "ensiveFlag", 0, 10, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorExpensiveFlag;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if (String.Compare(field_name, 1, "istory", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 8, "xclude", 0, 6, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorHistoryExclude;
                                break;
                            case 'I':
                                if ((String.Compare(field_name, 8, "nclude", 0, 6, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorHistoryInclude;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "nexpensiveFlag", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorInexpensiveFlag;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "ocalSearchQuestions", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorLocalSearchQuestions;
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
                            case 'S':
                                if ((String.Compare(field_name, 10, "pokenResponse", 0, 13, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorOpenHoursSpokenResponse;
                                break;
                            case 'W':
                                if ((String.Compare(field_name, 10, "rittenResponse", 0, 14, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorOpenHoursWrittenResponse;
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
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQueryType;
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
                                    if (String.Compare(field_name, 3, "ult", 0, 3, false) == 0)
                                      {
                                        switch (field_name[6])
                                          {
                                            case 'C':
                                                if ((String.Compare(field_name, 7, "ount", 0, 4, false) == 0) && (field_name.Length == 11))
                                                    return fieldGeneratorResultCount;
                                                break;
                                            case 'I':
                                                if (String.Compare(field_name, 7, "Ds", 0, 2, false) == 0)
                                                  {
                                                    switch (field_name[9])
                                                      {
                                                        case 'I':
                                                            if (String.Compare(field_name, 10, "ndex", 0, 4, false) == 0)
                                                              {
                                                                if (field_name.Length == 14)
                                                                  {
                                                                    return fieldGeneratorResultIDsIndex;
                                                                  }
                                                                switch (field_name[14])
                                                                  {
                                                                    case 'R':
                                                                        if ((String.Compare(field_name, 15, "epeated", 0, 7, false) == 0) && (field_name.Length == 22))
                                                                            return fieldGeneratorResultIDsIndexRepeated;
                                                                        break;
                                                                    default:
                                                                        break;
                                                                  }
                                                              }
                                                            break;
                                                        case 'R':
                                                            if ((String.Compare(field_name, 10, "eferenced", 0, 9, false) == 0) && (field_name.Length == 19))
                                                                return fieldGeneratorResultIDsReferenced;
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
                        case 'o':
                            if ((String.Compare(field_name, 2, "utePoints", 0, 9, false) == 0) && (field_name.Length == 11))
                                return fieldGeneratorRoutePoints;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'o':
                            if (String.Compare(field_name, 2, "rt", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'C':
                                        if ((String.Compare(field_name, 5, "riteria", 0, 7, false) == 0) && (field_name.Length == 12))
                                            return fieldGeneratorSortCriteria;
                                        break;
                                    case 'O':
                                        if ((String.Compare(field_name, 5, "rder", 0, 4, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratorSortOrder;
                                        break;
                                    default:
                                        break;
                                  }
                              }
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
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the LocalSearchFilterSpec class");
            fieldGeneratorResultCount = new FieldHoldingGeneratorResultCount("field \"ResultCount\" of the LocalSearchFilterSpec class");
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the LocalSearchFilterSpec class", ignore_extras);
            fieldGeneratorRadius = new JSONHoldingNumberTextGenerator("field \"Radius\" of the LocalSearchFilterSpec class");
            fieldGeneratorRadiusUnit = new FieldHoldingGeneratorRadiusUnit("field \"RadiusUnit\" of the LocalSearchFilterSpec class");
            fieldGeneratorRadiusInferred = new JSONHoldingBooleanGenerator("field \"RadiusInferred\" of the LocalSearchFilterSpec class");
            fieldGeneratorAlongTheRoute = new JSONHoldingBooleanGenerator("field \"AlongTheRoute\" of the LocalSearchFilterSpec class");
            fieldGeneratorRoutePoints = new RoutePointsJSON.HoldingGenerator("field \"RoutePoints\" of the LocalSearchFilterSpec class", ignore_extras);
            fieldGeneratorLocalSearchQuestions = new LocalSearchQuestionsSpecJSON.HoldingGenerator("field \"LocalSearchQuestions\" of the LocalSearchFilterSpec class", ignore_extras);
            fieldGeneratorOpenHours = new OpenHoursSpecJSON.HoldingGenerator("field \"OpenHours\" of the LocalSearchFilterSpec class", ignore_extras);
            fieldGeneratorOpenHoursSpokenResponse = new JSONHoldingStringGenerator("field \"OpenHoursSpokenResponse\" of the LocalSearchFilterSpec class");
            fieldGeneratorOpenHoursWrittenResponse = new JSONHoldingStringGenerator("field \"OpenHoursWrittenResponse\" of the LocalSearchFilterSpec class");
            fieldGeneratorOpenHoursFilterOnHoliday = new JSONHoldingBooleanGenerator("field \"OpenHoursFilterOnHoliday\" of the LocalSearchFilterSpec class");
            fieldGeneratorSortCriteria = new FieldHoldingArrayGeneratorSortCriteria("field \"SortCriteria\" of the LocalSearchFilterSpec class");
            fieldGeneratorSortOrder = new FieldHoldingArrayGeneratorSortOrder("field \"SortOrder\" of the LocalSearchFilterSpec class");
            fieldGeneratorExpensiveFlag = new JSONHoldingBooleanGenerator("field \"ExpensiveFlag\" of the LocalSearchFilterSpec class");
            fieldGeneratorInexpensiveFlag = new JSONHoldingBooleanGenerator("field \"InexpensiveFlag\" of the LocalSearchFilterSpec class");
            fieldGeneratorConversationMode = new JSONHoldingBooleanGenerator("field \"ConversationMode\" of the LocalSearchFilterSpec class");
            fieldGeneratorStarRatingMin = new JSONHoldingNumberTextGenerator("field \"StarRatingMin\" of the LocalSearchFilterSpec class");
            fieldGeneratorStarRatingMax = new JSONHoldingNumberTextGenerator("field \"StarRatingMax\" of the LocalSearchFilterSpec class");
            fieldGeneratorStarRatingsInclude = new JSONHoldingNumberTextArrayGenerator("field \"StarRatingsInclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorStarRatingsExclude = new JSONHoldingNumberTextArrayGenerator("field \"StarRatingsExclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorReviewCountMin = new FieldHoldingGeneratorReviewCountMin("field \"ReviewCountMin\" of the LocalSearchFilterSpec class");
            fieldGeneratorReviewCountMax = new FieldHoldingGeneratorReviewCountMax("field \"ReviewCountMax\" of the LocalSearchFilterSpec class");
            fieldGeneratorDollarSignMin = new JSONHoldingNumberTextGenerator("field \"DollarSignMin\" of the LocalSearchFilterSpec class");
            fieldGeneratorDollarSignMax = new JSONHoldingNumberTextGenerator("field \"DollarSignMax\" of the LocalSearchFilterSpec class");
            fieldGeneratorDollarSignsInclude = new JSONHoldingNumberTextArrayGenerator("field \"DollarSignsInclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorDollarSignsExclude = new JSONHoldingNumberTextArrayGenerator("field \"DollarSignsExclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorCategoriesInclude = new JSONHoldingStringArrayGenerator("field \"CategoriesInclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorCategoriesExclude = new JSONHoldingStringArrayGenerator("field \"CategoriesExclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorChainsInclude = new JSONHoldingStringArrayGenerator("field \"ChainsInclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorChainsExclude = new JSONHoldingStringArrayGenerator("field \"ChainsExclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorProductsInclude = new JSONHoldingStringArrayGenerator("field \"ProductsInclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorProductsExclude = new JSONHoldingStringArrayGenerator("field \"ProductsExclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorResultIDsReferenced = new JSONHoldingStringArrayGenerator("field \"ResultIDsReferenced\" of the LocalSearchFilterSpec class");
            fieldGeneratorResultIDsIndex = new FieldHoldingGeneratorResultIDsIndex("field \"ResultIDsIndex\" of the LocalSearchFilterSpec class");
            fieldGeneratorResultIDsIndexRepeated = new JSONHoldingBooleanGenerator("field \"ResultIDsIndexRepeated\" of the LocalSearchFilterSpec class");
            fieldGeneratorPlacesInclude = new JSONHoldingStringArrayGenerator("field \"PlacesInclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorPlacesExclude = new JSONHoldingStringArrayGenerator("field \"PlacesExclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorExcludedPlacesSpoken = new JSONHoldingStringGenerator("field \"ExcludedPlacesSpoken\" of the LocalSearchFilterSpec class");
            fieldGeneratorExcludedPlacesWritten = new JSONHoldingStringGenerator("field \"ExcludedPlacesWritten\" of the LocalSearchFilterSpec class");
            fieldGeneratorHistoryInclude = new SetOfTimeJSON.HoldingGenerator("field \"HistoryInclude\" of the LocalSearchFilterSpec class", ignore_extras);
            fieldGeneratorHistoryExclude = new SetOfTimeJSON.HoldingGenerator("field \"HistoryExclude\" of the LocalSearchFilterSpec class", ignore_extras);
            fieldGeneratorAmenitiesInclude = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesInclude\" of the LocalSearchFilterSpec class", ignore_extras);
            fieldGeneratorAmenitiesIncludeSupported = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesIncludeSupported\" of the LocalSearchFilterSpec class", ignore_extras);
            fieldGeneratorAmenitiesIncludeNotSupported = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesIncludeNotSupported\" of the LocalSearchFilterSpec class", ignore_extras);
            fieldGeneratorAmenitiesExclude = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesExclude\" of the LocalSearchFilterSpec class", ignore_extras);
            fieldGeneratorAmenitiesExcludeSupported = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesExcludeSupported\" of the LocalSearchFilterSpec class", ignore_extras);
            fieldGeneratorAmenitiesExcludeNotSupported = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesExcludeNotSupported\" of the LocalSearchFilterSpec class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the LocalSearchFilterSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the LocalSearchFilterSpec class");
            fieldGeneratorResultCount = new FieldHoldingGeneratorResultCount("field \"ResultCount\" of the LocalSearchFilterSpec class");
            fieldGeneratorMapLocation = new MapLocationJSON.HoldingGenerator("field \"MapLocation\" of the LocalSearchFilterSpec class", false);
            fieldGeneratorRadius = new JSONHoldingNumberTextGenerator("field \"Radius\" of the LocalSearchFilterSpec class");
            fieldGeneratorRadiusUnit = new FieldHoldingGeneratorRadiusUnit("field \"RadiusUnit\" of the LocalSearchFilterSpec class");
            fieldGeneratorRadiusInferred = new JSONHoldingBooleanGenerator("field \"RadiusInferred\" of the LocalSearchFilterSpec class");
            fieldGeneratorAlongTheRoute = new JSONHoldingBooleanGenerator("field \"AlongTheRoute\" of the LocalSearchFilterSpec class");
            fieldGeneratorRoutePoints = new RoutePointsJSON.HoldingGenerator("field \"RoutePoints\" of the LocalSearchFilterSpec class", false);
            fieldGeneratorLocalSearchQuestions = new LocalSearchQuestionsSpecJSON.HoldingGenerator("field \"LocalSearchQuestions\" of the LocalSearchFilterSpec class", false);
            fieldGeneratorOpenHours = new OpenHoursSpecJSON.HoldingGenerator("field \"OpenHours\" of the LocalSearchFilterSpec class", false);
            fieldGeneratorOpenHoursSpokenResponse = new JSONHoldingStringGenerator("field \"OpenHoursSpokenResponse\" of the LocalSearchFilterSpec class");
            fieldGeneratorOpenHoursWrittenResponse = new JSONHoldingStringGenerator("field \"OpenHoursWrittenResponse\" of the LocalSearchFilterSpec class");
            fieldGeneratorOpenHoursFilterOnHoliday = new JSONHoldingBooleanGenerator("field \"OpenHoursFilterOnHoliday\" of the LocalSearchFilterSpec class");
            fieldGeneratorSortCriteria = new FieldHoldingArrayGeneratorSortCriteria("field \"SortCriteria\" of the LocalSearchFilterSpec class");
            fieldGeneratorSortOrder = new FieldHoldingArrayGeneratorSortOrder("field \"SortOrder\" of the LocalSearchFilterSpec class");
            fieldGeneratorExpensiveFlag = new JSONHoldingBooleanGenerator("field \"ExpensiveFlag\" of the LocalSearchFilterSpec class");
            fieldGeneratorInexpensiveFlag = new JSONHoldingBooleanGenerator("field \"InexpensiveFlag\" of the LocalSearchFilterSpec class");
            fieldGeneratorConversationMode = new JSONHoldingBooleanGenerator("field \"ConversationMode\" of the LocalSearchFilterSpec class");
            fieldGeneratorStarRatingMin = new JSONHoldingNumberTextGenerator("field \"StarRatingMin\" of the LocalSearchFilterSpec class");
            fieldGeneratorStarRatingMax = new JSONHoldingNumberTextGenerator("field \"StarRatingMax\" of the LocalSearchFilterSpec class");
            fieldGeneratorStarRatingsInclude = new JSONHoldingNumberTextArrayGenerator("field \"StarRatingsInclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorStarRatingsExclude = new JSONHoldingNumberTextArrayGenerator("field \"StarRatingsExclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorReviewCountMin = new FieldHoldingGeneratorReviewCountMin("field \"ReviewCountMin\" of the LocalSearchFilterSpec class");
            fieldGeneratorReviewCountMax = new FieldHoldingGeneratorReviewCountMax("field \"ReviewCountMax\" of the LocalSearchFilterSpec class");
            fieldGeneratorDollarSignMin = new JSONHoldingNumberTextGenerator("field \"DollarSignMin\" of the LocalSearchFilterSpec class");
            fieldGeneratorDollarSignMax = new JSONHoldingNumberTextGenerator("field \"DollarSignMax\" of the LocalSearchFilterSpec class");
            fieldGeneratorDollarSignsInclude = new JSONHoldingNumberTextArrayGenerator("field \"DollarSignsInclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorDollarSignsExclude = new JSONHoldingNumberTextArrayGenerator("field \"DollarSignsExclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorCategoriesInclude = new JSONHoldingStringArrayGenerator("field \"CategoriesInclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorCategoriesExclude = new JSONHoldingStringArrayGenerator("field \"CategoriesExclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorChainsInclude = new JSONHoldingStringArrayGenerator("field \"ChainsInclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorChainsExclude = new JSONHoldingStringArrayGenerator("field \"ChainsExclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorProductsInclude = new JSONHoldingStringArrayGenerator("field \"ProductsInclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorProductsExclude = new JSONHoldingStringArrayGenerator("field \"ProductsExclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorResultIDsReferenced = new JSONHoldingStringArrayGenerator("field \"ResultIDsReferenced\" of the LocalSearchFilterSpec class");
            fieldGeneratorResultIDsIndex = new FieldHoldingGeneratorResultIDsIndex("field \"ResultIDsIndex\" of the LocalSearchFilterSpec class");
            fieldGeneratorResultIDsIndexRepeated = new JSONHoldingBooleanGenerator("field \"ResultIDsIndexRepeated\" of the LocalSearchFilterSpec class");
            fieldGeneratorPlacesInclude = new JSONHoldingStringArrayGenerator("field \"PlacesInclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorPlacesExclude = new JSONHoldingStringArrayGenerator("field \"PlacesExclude\" of the LocalSearchFilterSpec class");
            fieldGeneratorExcludedPlacesSpoken = new JSONHoldingStringGenerator("field \"ExcludedPlacesSpoken\" of the LocalSearchFilterSpec class");
            fieldGeneratorExcludedPlacesWritten = new JSONHoldingStringGenerator("field \"ExcludedPlacesWritten\" of the LocalSearchFilterSpec class");
            fieldGeneratorHistoryInclude = new SetOfTimeJSON.HoldingGenerator("field \"HistoryInclude\" of the LocalSearchFilterSpec class", false);
            fieldGeneratorHistoryExclude = new SetOfTimeJSON.HoldingGenerator("field \"HistoryExclude\" of the LocalSearchFilterSpec class", false);
            fieldGeneratorAmenitiesInclude = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesInclude\" of the LocalSearchFilterSpec class", false);
            fieldGeneratorAmenitiesIncludeSupported = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesIncludeSupported\" of the LocalSearchFilterSpec class", false);
            fieldGeneratorAmenitiesIncludeNotSupported = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesIncludeNotSupported\" of the LocalSearchFilterSpec class", false);
            fieldGeneratorAmenitiesExclude = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesExclude\" of the LocalSearchFilterSpec class", false);
            fieldGeneratorAmenitiesExcludeSupported = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesExcludeSupported\" of the LocalSearchFilterSpec class", false);
            fieldGeneratorAmenitiesExcludeNotSupported = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesExcludeNotSupported\" of the LocalSearchFilterSpec class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the LocalSearchFilterSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQueryType.reset();
            fieldGeneratorResultCount.reset();
            fieldGeneratorMapLocation.reset();
            fieldGeneratorRadius.reset();
            fieldGeneratorRadiusUnit.reset();
            fieldGeneratorRadiusInferred.reset();
            fieldGeneratorAlongTheRoute.reset();
            fieldGeneratorRoutePoints.reset();
            fieldGeneratorLocalSearchQuestions.reset();
            fieldGeneratorOpenHours.reset();
            fieldGeneratorOpenHoursSpokenResponse.reset();
            fieldGeneratorOpenHoursWrittenResponse.reset();
            fieldGeneratorOpenHoursFilterOnHoliday.reset();
            fieldGeneratorSortCriteria.reset();
            fieldGeneratorSortOrder.reset();
            fieldGeneratorExpensiveFlag.reset();
            fieldGeneratorInexpensiveFlag.reset();
            fieldGeneratorConversationMode.reset();
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
            fieldGeneratorResultIDsReferenced.reset();
            fieldGeneratorResultIDsIndex.reset();
            fieldGeneratorResultIDsIndexRepeated.reset();
            fieldGeneratorPlacesInclude.reset();
            fieldGeneratorPlacesExclude.reset();
            fieldGeneratorExcludedPlacesSpoken.reset();
            fieldGeneratorExcludedPlacesWritten.reset();
            fieldGeneratorHistoryInclude.reset();
            fieldGeneratorHistoryExclude.reset();
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
            fieldGeneratorMapLocation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRoutePoints.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLocalSearchQuestions.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorOpenHours.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHistoryInclude.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorHistoryExclude.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmenitiesInclude.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmenitiesIncludeSupported.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmenitiesIncludeNotSupported.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmenitiesExclude.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmenitiesExcludeSupported.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmenitiesExcludeNotSupported.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorMapLocation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRoutePoints.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLocalSearchQuestions.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorOpenHours.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHistoryInclude.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorHistoryExclude.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmenitiesInclude.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmenitiesIncludeSupported.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmenitiesIncludeNotSupported.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmenitiesExclude.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmenitiesExcludeSupported.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmenitiesExcludeNotSupported.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(LocalSearchFilterSpecJSON  result)
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
        public LocalSearchFilterSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LocalSearchFilterSpecJSON  result)
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
    protected virtual void handle_result(List<LocalSearchFilterSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LocalSearchFilterSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LocalSearchFilterSpecJSON>();
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
    public List<LocalSearchFilterSpecJSON> value;
  };
  };
