/* file "LocalSearchQuestionsSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class LocalSearchQuestionsSpecJSON : JSONBase
  {
    public enum TypeQuestionTypesKnownValues
      {
        QuestionTypes_Name,
        QuestionTypes_Information,
        QuestionTypes_IsItOpen,
        QuestionTypes_IsItClosed,
        QuestionTypes_HoursOfOperation,
        QuestionTypes_Phone,
        QuestionTypes_Fax,
        QuestionTypes_Address,
        QuestionTypes_Rating,
        QuestionTypes_Reviews,
        QuestionTypes_Price,
        QuestionTypes_Amenities,
        QuestionTypes_Cuisine,
        QuestionTypes_Category,
        QuestionTypes_Products,
        QuestionTypes_Distance,
        QuestionTypes__none
      };
    public struct TypeQuestionTypes
      {
        public bool in_known_list;
        public string string_value;
        public TypeQuestionTypesKnownValues list_value;
      };

    public static TypeQuestionTypesKnownValues  stringToQuestionTypes(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                switch (chars[1])
                  {
                    case 'd':
                        if ((String.Compare(chars, 2, "dress", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeQuestionTypesKnownValues.QuestionTypes_Address;
                        break;
                    case 'm':
                        if ((String.Compare(chars, 2, "enities", 0, 7, false) == 0) && (chars.Length == 9))
                            return TypeQuestionTypesKnownValues.QuestionTypes_Amenities;
                        break;
                    default:
                        break;
                  }
                break;
            case 'C':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "tegory", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeQuestionTypesKnownValues.QuestionTypes_Category;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "isine", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeQuestionTypesKnownValues.QuestionTypes_Cuisine;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if ((String.Compare(chars, 1, "istance", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeQuestionTypesKnownValues.QuestionTypes_Distance;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "ax", 0, 2, false) == 0) && (chars.Length == 3))
                    return TypeQuestionTypesKnownValues.QuestionTypes_Fax;
                break;
            case 'H':
                if ((String.Compare(chars, 1, "oursOfOperation", 0, 15, false) == 0) && (chars.Length == 16))
                    return TypeQuestionTypesKnownValues.QuestionTypes_HoursOfOperation;
                break;
            case 'I':
                switch (chars[1])
                  {
                    case 'n':
                        if ((String.Compare(chars, 2, "formation", 0, 9, false) == 0) && (chars.Length == 11))
                            return TypeQuestionTypesKnownValues.QuestionTypes_Information;
                        break;
                    case 's':
                        if (String.Compare(chars, 2, "It", 0, 2, false) == 0)
                          {
                            switch (chars[4])
                              {
                                case 'C':
                                    if ((String.Compare(chars, 5, "losed", 0, 5, false) == 0) && (chars.Length == 10))
                                        return TypeQuestionTypesKnownValues.QuestionTypes_IsItClosed;
                                    break;
                                case 'O':
                                    if ((String.Compare(chars, 5, "pen", 0, 3, false) == 0) && (chars.Length == 8))
                                        return TypeQuestionTypesKnownValues.QuestionTypes_IsItOpen;
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
            case 'N':
                if ((String.Compare(chars, 1, "ame", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeQuestionTypesKnownValues.QuestionTypes_Name;
                break;
            case 'P':
                switch (chars[1])
                  {
                    case 'h':
                        if ((String.Compare(chars, 2, "one", 0, 3, false) == 0) && (chars.Length == 5))
                            return TypeQuestionTypesKnownValues.QuestionTypes_Phone;
                        break;
                    case 'r':
                        switch (chars[2])
                          {
                            case 'i':
                                if ((String.Compare(chars, 3, "ce", 0, 2, false) == 0) && (chars.Length == 5))
                                    return TypeQuestionTypesKnownValues.QuestionTypes_Price;
                                break;
                            case 'o':
                                if ((String.Compare(chars, 3, "ducts", 0, 5, false) == 0) && (chars.Length == 8))
                                    return TypeQuestionTypesKnownValues.QuestionTypes_Products;
                                break;
                            default:
                                break;
                          }
                        break;
                    default:
                        break;
                  }
                break;
            case 'R':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "ting", 0, 4, false) == 0) && (chars.Length == 6))
                            return TypeQuestionTypesKnownValues.QuestionTypes_Rating;
                        break;
                    case 'e':
                        if ((String.Compare(chars, 2, "views", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeQuestionTypesKnownValues.QuestionTypes_Reviews;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return TypeQuestionTypesKnownValues.QuestionTypes__none;
      }

    public static string  stringFromQuestionTypes(TypeQuestionTypesKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeQuestionTypesKnownValues.QuestionTypes_Name:
                return "Name";
            case TypeQuestionTypesKnownValues.QuestionTypes_Information:
                return "Information";
            case TypeQuestionTypesKnownValues.QuestionTypes_IsItOpen:
                return "IsItOpen";
            case TypeQuestionTypesKnownValues.QuestionTypes_IsItClosed:
                return "IsItClosed";
            case TypeQuestionTypesKnownValues.QuestionTypes_HoursOfOperation:
                return "HoursOfOperation";
            case TypeQuestionTypesKnownValues.QuestionTypes_Phone:
                return "Phone";
            case TypeQuestionTypesKnownValues.QuestionTypes_Fax:
                return "Fax";
            case TypeQuestionTypesKnownValues.QuestionTypes_Address:
                return "Address";
            case TypeQuestionTypesKnownValues.QuestionTypes_Rating:
                return "Rating";
            case TypeQuestionTypesKnownValues.QuestionTypes_Reviews:
                return "Reviews";
            case TypeQuestionTypesKnownValues.QuestionTypes_Price:
                return "Price";
            case TypeQuestionTypesKnownValues.QuestionTypes_Amenities:
                return "Amenities";
            case TypeQuestionTypesKnownValues.QuestionTypes_Cuisine:
                return "Cuisine";
            case TypeQuestionTypesKnownValues.QuestionTypes_Category:
                return "Category";
            case TypeQuestionTypesKnownValues.QuestionTypes_Products:
                return "Products";
            case TypeQuestionTypesKnownValues.QuestionTypes_Distance:
                return "Distance";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasQuestionTypes;
    private List< TypeQuestionTypes > storeQuestionTypes;
    private bool flagHasOpenHours;
    private OpenHoursSpecJSON  storeOpenHours;
    private bool flagHasProductsInclude;
    private List< string > storeProductsInclude;
    private bool flagHasAmenitiesInclude;
    private List< AmenityGroupSpecJSON  > storeAmenitiesInclude;
    private bool flagHasAmenitiesIncludeSupported;
    private List< AmenityGroupSpecJSON  > storeAmenitiesIncludeSupported;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQuestionTypes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field QuestionTypes of LocalSearchQuestionsSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeQuestionTypes > vector_QuestionTypes1 = new List< TypeQuestionTypes >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field QuestionTypes of LocalSearchQuestionsSpecJSON is not a string.");
            TypeQuestionTypes the_open_enum = new TypeQuestionTypes();
            switch (json_string.getData()[0])
              {
                case 'A':
                    switch (json_string.getData()[1])
                      {
                        case 'd':
                            if ((String.Compare(json_string.getData(), 2, "dress", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Address;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'm':
                            if ((String.Compare(json_string.getData(), 2, "enities", 0, 7, false) == 0) && (json_string.getData().Length == 9))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Amenities;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'C':
                    switch (json_string.getData()[1])
                      {
                        case 'a':
                            if ((String.Compare(json_string.getData(), 2, "tegory", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Category;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'u':
                            if ((String.Compare(json_string.getData(), 2, "isine", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Cuisine;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if ((String.Compare(json_string.getData(), 1, "istance", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Distance;
                            goto open_enum_is_done;
                          }
                    break;
                case 'F':
                    if ((String.Compare(json_string.getData(), 1, "ax", 0, 2, false) == 0) && (json_string.getData().Length == 3))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Fax;
                            goto open_enum_is_done;
                          }
                    break;
                case 'H':
                    if ((String.Compare(json_string.getData(), 1, "oursOfOperation", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_HoursOfOperation;
                            goto open_enum_is_done;
                          }
                    break;
                case 'I':
                    switch (json_string.getData()[1])
                      {
                        case 'n':
                            if ((String.Compare(json_string.getData(), 2, "formation", 0, 9, false) == 0) && (json_string.getData().Length == 11))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Information;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 's':
                            if (String.Compare(json_string.getData(), 2, "It", 0, 2, false) == 0)
                              {
                                switch (json_string.getData()[4])
                                  {
                                    case 'C':
                                        if ((String.Compare(json_string.getData(), 5, "losed", 0, 5, false) == 0) && (json_string.getData().Length == 10))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_IsItClosed;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'O':
                                        if ((String.Compare(json_string.getData(), 5, "pen", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_IsItOpen;
                                                goto open_enum_is_done;
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
                case 'N':
                    if ((String.Compare(json_string.getData(), 1, "ame", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Name;
                            goto open_enum_is_done;
                          }
                    break;
                case 'P':
                    switch (json_string.getData()[1])
                      {
                        case 'h':
                            if ((String.Compare(json_string.getData(), 2, "one", 0, 3, false) == 0) && (json_string.getData().Length == 5))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Phone;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'r':
                            switch (json_string.getData()[2])
                              {
                                case 'i':
                                    if ((String.Compare(json_string.getData(), 3, "ce", 0, 2, false) == 0) && (json_string.getData().Length == 5))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Price;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                case 'o':
                                    if ((String.Compare(json_string.getData(), 3, "ducts", 0, 5, false) == 0) && (json_string.getData().Length == 8))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Products;
                                            goto open_enum_is_done;
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
                case 'R':
                    switch (json_string.getData()[1])
                      {
                        case 'a':
                            if ((String.Compare(json_string.getData(), 2, "ting", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Rating;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'e':
                            if ((String.Compare(json_string.getData(), 2, "views", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQuestionTypesKnownValues.QuestionTypes_Reviews;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            vector_QuestionTypes1.Add(the_open_enum);
          }
        initQuestionTypes();
        for (int num1 = 0; num1 < vector_QuestionTypes1.Count; ++num1)
            appendQuestionTypes(vector_QuestionTypes1[num1]);
        for (int num1 = 0; num1 < vector_QuestionTypes1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOpenHours(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OpenHoursSpecJSON convert_classy = OpenHoursSpecJSON.from_json(json_value, ignore_extras, true);
        setOpenHours(convert_classy);
      }


    private void  fromJSONProductsInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ProductsInclude of LocalSearchQuestionsSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ProductsInclude1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ProductsInclude of LocalSearchQuestionsSpecJSON is not a string.");
            vector_ProductsInclude1.Add(json_string.getData());
          }
        initProductsInclude();
        for (int num2 = 0; num2 < vector_ProductsInclude1.Count; ++num2)
            appendProductsInclude(vector_ProductsInclude1[num2]);
        for (int num1 = 0; num1 < vector_ProductsInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesInclude(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesInclude of LocalSearchQuestionsSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AmenityGroupSpecJSON  > vector_AmenitiesInclude1 = new List< AmenityGroupSpecJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AmenityGroupSpecJSON convert_classy = AmenityGroupSpecJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmenitiesInclude1.Add(convert_classy);
          }
        initAmenitiesInclude();
        for (int num3 = 0; num3 < vector_AmenitiesInclude1.Count; ++num3)
            appendAmenitiesInclude(vector_AmenitiesInclude1[num3]);
        for (int num1 = 0; num1 < vector_AmenitiesInclude1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAmenitiesIncludeSupported(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AmenitiesIncludeSupported of LocalSearchQuestionsSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AmenityGroupSpecJSON  > vector_AmenitiesIncludeSupported1 = new List< AmenityGroupSpecJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AmenityGroupSpecJSON convert_classy = AmenityGroupSpecJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AmenitiesIncludeSupported1.Add(convert_classy);
          }
        initAmenitiesIncludeSupported();
        for (int num4 = 0; num4 < vector_AmenitiesIncludeSupported1.Count; ++num4)
            appendAmenitiesIncludeSupported(vector_AmenitiesIncludeSupported1[num4]);
        for (int num1 = 0; num1 < vector_AmenitiesIncludeSupported1.Count; ++num1)
          {
          }
      }


    public LocalSearchQuestionsSpecJSON()
      {
        flagHasQuestionTypes = false;
        flagHasOpenHours = false;
        flagHasProductsInclude = false;
        flagHasAmenitiesInclude = false;
        flagHasAmenitiesIncludeSupported = false;
        storeQuestionTypes = new List< TypeQuestionTypes >();
        storeProductsInclude = new List< string >();
        storeAmenitiesInclude = new List< AmenityGroupSpecJSON  >();
        storeAmenitiesIncludeSupported = new List< AmenityGroupSpecJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasQuestionTypes()
      {
        return flagHasQuestionTypes;
      }

    public int  countOfQuestionTypes()
      {
        Debug.Assert(flagHasQuestionTypes);
        return storeQuestionTypes.Count;
      }

    public TypeQuestionTypes  elementOfQuestionTypes(int element_num)
      {
        Debug.Assert(flagHasQuestionTypes);
        return storeQuestionTypes[element_num];
      }

    public List< TypeQuestionTypes >  getQuestionTypes()
      {
        Debug.Assert(flagHasQuestionTypes);
        return storeQuestionTypes;
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


    public virtual int extraLocalSearchQuestionsSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraLocalSearchQuestionsSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraLocalSearchQuestionsSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraLocalSearchQuestionsSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initQuestionTypes()
      {
        flagHasQuestionTypes = true;
        storeQuestionTypes.Clear();
      }
    public void appendQuestionTypes(TypeQuestionTypes to_append)
      {
        if (!flagHasQuestionTypes)
          {
            flagHasQuestionTypes = true;
            storeQuestionTypes.Clear();
          }
        Debug.Assert(flagHasQuestionTypes);
        storeQuestionTypes.Add(to_append);
      }
    public void appendQuestionTypes(string chars)
      {
        TypeQuestionTypesKnownValues known = stringToQuestionTypes(chars);
        TypeQuestionTypes new_value = new TypeQuestionTypes();
        if (known == TypeQuestionTypesKnownValues.QuestionTypes__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        appendQuestionTypes(new_value);
      }
    public void appendQuestionTypes(TypeQuestionTypesKnownValues new_value)
      {
        TypeQuestionTypes new_full_value = new TypeQuestionTypes();
        Debug.Assert(new_value != TypeQuestionTypesKnownValues.QuestionTypes__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        appendQuestionTypes(new_full_value);
      }
    public void unsetQuestionTypes()
      {
        flagHasQuestionTypes = false;
        storeQuestionTypes.Clear();
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

    public virtual void extraLocalSearchQuestionsSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraLocalSearchQuestionsSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraLocalSearchQuestionsSpecLookup(key);
        if (old_field == null)
          {
            extraLocalSearchQuestionsSpecAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQuestionTypes);
        if (flagHasQuestionTypes)
          {
            handler.start_pair("QuestionTypes");
            handler.start_array();
            for (int num1 = 0; num1 < storeQuestionTypes.Count; ++num1)
              {
                if (storeQuestionTypes[num1].in_known_list)
                  {
                    switch (storeQuestionTypes[num1].list_value)
                      {
                        case TypeQuestionTypesKnownValues.QuestionTypes_Name:
                            handler.string_value("Name");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_Information:
                            handler.string_value("Information");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_IsItOpen:
                            handler.string_value("IsItOpen");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_IsItClosed:
                            handler.string_value("IsItClosed");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_HoursOfOperation:
                            handler.string_value("HoursOfOperation");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_Phone:
                            handler.string_value("Phone");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_Fax:
                            handler.string_value("Fax");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_Address:
                            handler.string_value("Address");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_Rating:
                            handler.string_value("Rating");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_Reviews:
                            handler.string_value("Reviews");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_Price:
                            handler.string_value("Price");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_Amenities:
                            handler.string_value("Amenities");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_Cuisine:
                            handler.string_value("Cuisine");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_Category:
                            handler.string_value("Category");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_Products:
                            handler.string_value("Products");
                            break;
                        case TypeQuestionTypesKnownValues.QuestionTypes_Distance:
                            handler.string_value("Distance");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeQuestionTypes[num1].string_value);
                  }
              }
            handler.finish_array();
          }
        if (flagHasOpenHours)
          {
            handler.start_pair("OpenHours");
            if (partial_allowed)
                storeOpenHours.write_partial_as_json(handler);
            else
                storeOpenHours.write_as_json(handler);
          }
        if (flagHasProductsInclude)
          {
            handler.start_pair("ProductsInclude");
            handler.start_array();
            for (int num2 = 0; num2 < storeProductsInclude.Count; ++num2)
              {
                handler.string_value(storeProductsInclude[num2]);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesInclude)
          {
            handler.start_pair("AmenitiesInclude");
            handler.start_array();
            for (int num3 = 0; num3 < storeAmenitiesInclude.Count; ++num3)
              {
                if (partial_allowed)
                    storeAmenitiesInclude[num3].write_partial_as_json(handler);
                else
                    storeAmenitiesInclude[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAmenitiesIncludeSupported)
          {
            handler.start_pair("AmenitiesIncludeSupported");
            handler.start_array();
            for (int num4 = 0; num4 < storeAmenitiesIncludeSupported.Count; ++num4)
              {
                if (partial_allowed)
                    storeAmenitiesIncludeSupported[num4].write_partial_as_json(handler);
                else
                    storeAmenitiesIncludeSupported[num4].write_as_json(handler);
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
        if (!(hasQuestionTypes()))
          {
            return "When parsing the object for %what%, the \"QuestionTypes\" field was missing.";
          }
        return null;
      }

    public static LocalSearchQuestionsSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalSearchQuestionsSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchQuestionsSpec", ignore_extras);
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
    public static LocalSearchQuestionsSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocalSearchQuestionsSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        LocalSearchQuestionsSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchQuestionsSpec", ignore_extras);
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
    public static LocalSearchQuestionsSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static LocalSearchQuestionsSpecJSON from_text(string text, bool ignore_extras)
      {
        LocalSearchQuestionsSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchQuestionsSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for LocalSearchQuestionsSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static LocalSearchQuestionsSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        LocalSearchQuestionsSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type LocalSearchQuestionsSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorQuestionTypes : JSONStringGenerator
          {
            protected FieldGeneratorQuestionTypes(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorQuestionTypes()
              {
              }
            protected override void handle_result(string result)
              {
                TypeQuestionTypesKnownValues known = stringToQuestionTypes(result);
                TypeQuestionTypes new_value = new TypeQuestionTypes();
                if (known == TypeQuestionTypesKnownValues.QuestionTypes__none)
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
            protected abstract void handle_result(TypeQuestionTypes result);
          };
    private class FieldHoldingGeneratorQuestionTypes : FieldGeneratorQuestionTypes
  {
    protected override void handle_result(TypeQuestionTypes result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorQuestionTypes(String what)
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
    public TypeQuestionTypes value;
  };
    private class FieldHoldingArrayGeneratorQuestionTypes : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorQuestionTypes
      {
        private FieldHoldingArrayGeneratorQuestionTypes top;

        protected override void handle_result(TypeQuestionTypes result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorQuestionTypes init_top)
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
    protected virtual void handle_result(List<TypeQuestionTypes> result)
      {
      }

    public FieldHoldingArrayGeneratorQuestionTypes(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQuestionTypes>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorQuestionTypes()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQuestionTypes>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeQuestionTypes> value;
  };
        private FieldHoldingArrayGeneratorQuestionTypes fieldGeneratorQuestionTypes;
        private OpenHoursSpecJSON.HoldingGenerator fieldGeneratorOpenHours;
        private JSONHoldingStringArrayGenerator fieldGeneratorProductsInclude;
        private AmenityGroupSpecJSON.HoldingArrayGenerator fieldGeneratorAmenitiesInclude;
        private AmenityGroupSpecJSON.HoldingArrayGenerator fieldGeneratorAmenitiesIncludeSupported;
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
            LocalSearchQuestionsSpecJSON result = new LocalSearchQuestionsSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraLocalSearchQuestionsSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(LocalSearchQuestionsSpecJSON result)
          {
            if (fieldGeneratorQuestionTypes.have_value)
              {
                result.initQuestionTypes();
                int count = fieldGeneratorQuestionTypes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendQuestionTypes(fieldGeneratorQuestionTypes.value[num]);
                  }
                fieldGeneratorQuestionTypes.value.Clear();
                fieldGeneratorQuestionTypes.have_value = false;
              }
            else if ((!(result.hasQuestionTypes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QuestionTypes\" field was missing.");
              }
            if (fieldGeneratorOpenHours.have_value)
              {
                result.setOpenHours(fieldGeneratorOpenHours.value);
                fieldGeneratorOpenHours.have_value = false;
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
          }
        protected abstract void handle_result(LocalSearchQuestionsSpecJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "menitiesInclude", 0, 15, false) == 0)
                      {
                        if (field_name.Length == 16)
                          {
                            return fieldGeneratorAmenitiesInclude;
                          }
                        switch (field_name[16])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 17, "upported", 0, 8, false) == 0) && (field_name.Length == 25))
                                    return fieldGeneratorAmenitiesIncludeSupported;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "penHours", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorOpenHours;
                    break;
                case 'P':
                    if ((String.Compare(field_name, 1, "roductsInclude", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorProductsInclude;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "uestionTypes", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorQuestionTypes;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQuestionTypes = new FieldHoldingArrayGeneratorQuestionTypes("field \"QuestionTypes\" of the LocalSearchQuestionsSpec class");
            fieldGeneratorOpenHours = new OpenHoursSpecJSON.HoldingGenerator("field \"OpenHours\" of the LocalSearchQuestionsSpec class", ignore_extras);
            fieldGeneratorProductsInclude = new JSONHoldingStringArrayGenerator("field \"ProductsInclude\" of the LocalSearchQuestionsSpec class");
            fieldGeneratorAmenitiesInclude = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesInclude\" of the LocalSearchQuestionsSpec class", ignore_extras);
            fieldGeneratorAmenitiesIncludeSupported = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesIncludeSupported\" of the LocalSearchQuestionsSpec class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the LocalSearchQuestionsSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQuestionTypes = new FieldHoldingArrayGeneratorQuestionTypes("field \"QuestionTypes\" of the LocalSearchQuestionsSpec class");
            fieldGeneratorOpenHours = new OpenHoursSpecJSON.HoldingGenerator("field \"OpenHours\" of the LocalSearchQuestionsSpec class", false);
            fieldGeneratorProductsInclude = new JSONHoldingStringArrayGenerator("field \"ProductsInclude\" of the LocalSearchQuestionsSpec class");
            fieldGeneratorAmenitiesInclude = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesInclude\" of the LocalSearchQuestionsSpec class", false);
            fieldGeneratorAmenitiesIncludeSupported = new AmenityGroupSpecJSON.HoldingArrayGenerator("field \"AmenitiesIncludeSupported\" of the LocalSearchQuestionsSpec class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the LocalSearchQuestionsSpec class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQuestionTypes.reset();
            fieldGeneratorOpenHours.reset();
            fieldGeneratorProductsInclude.reset();
            fieldGeneratorAmenitiesInclude.reset();
            fieldGeneratorAmenitiesIncludeSupported.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorOpenHours.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmenitiesInclude.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAmenitiesIncludeSupported.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorOpenHours.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmenitiesInclude.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAmenitiesIncludeSupported.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(LocalSearchQuestionsSpecJSON  result)
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
        public LocalSearchQuestionsSpecJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(LocalSearchQuestionsSpecJSON  result)
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
    protected virtual void handle_result(List<LocalSearchQuestionsSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<LocalSearchQuestionsSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<LocalSearchQuestionsSpecJSON>();
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
    public List<LocalSearchQuestionsSpecJSON> value;
  };
  };
