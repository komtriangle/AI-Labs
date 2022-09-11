/* file "RestaurantMenuMenuItemJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class RestaurantMenuMenuItemJSON : JSONBase
  {
    public class TypeComponentsJSON : JSONBase
      {
        public enum TypeSizingRestrictionsKnownValues
          {
            SizingRestrictions_NoUpsizing,
            SizingRestrictions_NoDownsizing,
            SizingRestrictions_NoResizing,
            SizingRestrictions_None,
            SizingRestrictions__none
          };
        public struct TypeSizingRestrictions
          {
            public bool in_known_list;
            public string string_value;
            public TypeSizingRestrictionsKnownValues list_value;
          };

        public static TypeSizingRestrictionsKnownValues  stringToSizingRestrictions(string chars)
          {
            if (String.Compare(chars, 0, "No", 0, 2, false) == 0)
              {
                switch (chars[2])
                  {
                    case 'D':
                        if ((String.Compare(chars, 3, "ownsizing", 0, 9, false) == 0) && (chars.Length == 12))
                            return TypeSizingRestrictionsKnownValues.SizingRestrictions_NoDownsizing;
                        break;
                    case 'R':
                        if ((String.Compare(chars, 3, "esizing", 0, 7, false) == 0) && (chars.Length == 10))
                            return TypeSizingRestrictionsKnownValues.SizingRestrictions_NoResizing;
                        break;
                    case 'U':
                        if ((String.Compare(chars, 3, "psizing", 0, 7, false) == 0) && (chars.Length == 10))
                            return TypeSizingRestrictionsKnownValues.SizingRestrictions_NoUpsizing;
                        break;
                    case 'n':
                        if ((String.Compare(chars, 3, "e", 0, 1, false) == 0) && (chars.Length == 4))
                            return TypeSizingRestrictionsKnownValues.SizingRestrictions_None;
                        break;
                    default:
                        break;
                  }
              }
            return TypeSizingRestrictionsKnownValues.SizingRestrictions__none;
          }

        public static string  stringFromSizingRestrictions(TypeSizingRestrictionsKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeSizingRestrictionsKnownValues.SizingRestrictions_NoUpsizing:
                    return "NoUpsizing";
                case TypeSizingRestrictionsKnownValues.SizingRestrictions_NoDownsizing:
                    return "NoDownsizing";
                case TypeSizingRestrictionsKnownValues.SizingRestrictions_NoResizing:
                    return "NoResizing";
                case TypeSizingRestrictionsKnownValues.SizingRestrictions_None:
                    return "None";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeDefaultSizeKnownValues
          {
            DefaultSize_Mini,
            DefaultSize_Small,
            DefaultSize_Medium,
            DefaultSize_Large,
            DefaultSize_ExtraLarge,
            DefaultSize__none
          };
        public struct TypeDefaultSize
          {
            public bool in_known_list;
            public string string_value;
            public TypeDefaultSizeKnownValues list_value;
          };

        public static TypeDefaultSizeKnownValues  stringToDefaultSize(string chars)
          {
            switch (chars[0])
              {
                case 'E':
                    if ((String.Compare(chars, 1, "xtraLarge", 0, 9, false) == 0) && (chars.Length == 10))
                        return TypeDefaultSizeKnownValues.DefaultSize_ExtraLarge;
                    break;
                case 'L':
                    if ((String.Compare(chars, 1, "arge", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeDefaultSizeKnownValues.DefaultSize_Large;
                    break;
                case 'M':
                    switch (chars[1])
                      {
                        case 'e':
                            if ((String.Compare(chars, 2, "dium", 0, 4, false) == 0) && (chars.Length == 6))
                                return TypeDefaultSizeKnownValues.DefaultSize_Medium;
                            break;
                        case 'i':
                            if ((String.Compare(chars, 2, "ni", 0, 2, false) == 0) && (chars.Length == 4))
                                return TypeDefaultSizeKnownValues.DefaultSize_Mini;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(chars, 1, "mall", 0, 4, false) == 0) && (chars.Length == 5))
                        return TypeDefaultSizeKnownValues.DefaultSize_Small;
                    break;
                default:
                    break;
              }
            return TypeDefaultSizeKnownValues.DefaultSize__none;
          }

        public static string  stringFromDefaultSize(TypeDefaultSizeKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeDefaultSizeKnownValues.DefaultSize_Mini:
                    return "Mini";
                case TypeDefaultSizeKnownValues.DefaultSize_Small:
                    return "Small";
                case TypeDefaultSizeKnownValues.DefaultSize_Medium:
                    return "Medium";
                case TypeDefaultSizeKnownValues.DefaultSize_Large:
                    return "Large";
                case TypeDefaultSizeKnownValues.DefaultSize_ExtraLarge:
                    return "ExtraLarge";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasSizingRestrictions;
        private TypeSizingRestrictions storeSizingRestrictions;
        private bool flagHasDefaultSize;
        private TypeDefaultSize storeDefaultSize;
        private bool flagHasProductOrCategoryId;
        private BigInteger storeProductOrCategoryId;
        private bool flagHasLegalItems;
        private List< BigInteger > storeLegalItems;
        private bool flagHasDefaultItem;
        private BigInteger storeDefaultItem;
        private bool flagHasType;
        private RestaurantMenuComboItemTypeJSON  storeType;
        private bool flagHasComponentTypeEnum;
        private RestaurantMenuComboItemTypeJSON  storeComponentTypeEnum;
        private bool flagHasMutualExclusiveType;
        private bool storeMutualExclusiveType;
        private bool flagHasFillAllOpenSlots;
        private bool storeFillAllOpenSlots;
        private bool flagHasHasComboLevelModifiers;
        private bool storeHasComboLevelModifiers;
        private bool flagHasStep;
        private BigInteger storeStep;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONSizingRestrictions(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field SizingRestrictions of TypeComponentsJSON is not a string.");
            TypeSizingRestrictions the_open_enum = new TypeSizingRestrictions();
            if (String.Compare(json_string.getData(), 0, "No", 0, 2, false) == 0)
              {
                switch (json_string.getData()[2])
                  {
                    case 'D':
                        if ((String.Compare(json_string.getData(), 3, "ownsizing", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSizingRestrictionsKnownValues.SizingRestrictions_NoDownsizing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'R':
                        if ((String.Compare(json_string.getData(), 3, "esizing", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSizingRestrictionsKnownValues.SizingRestrictions_NoResizing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'U':
                        if ((String.Compare(json_string.getData(), 3, "psizing", 0, 7, false) == 0) && (json_string.getData().Length == 10))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSizingRestrictionsKnownValues.SizingRestrictions_NoUpsizing;
                                goto open_enum_is_done;
                              }
                        break;
                    case 'n':
                        if ((String.Compare(json_string.getData(), 3, "e", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeSizingRestrictionsKnownValues.SizingRestrictions_None;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setSizingRestrictions(the_open_enum);
          }


        private void  fromJSONDefaultSize(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field DefaultSize of TypeComponentsJSON is not a string.");
            TypeDefaultSize the_open_enum = new TypeDefaultSize();
            switch (json_string.getData()[0])
              {
                case 'E':
                    if ((String.Compare(json_string.getData(), 1, "xtraLarge", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDefaultSizeKnownValues.DefaultSize_ExtraLarge;
                            goto open_enum_is_done;
                          }
                    break;
                case 'L':
                    if ((String.Compare(json_string.getData(), 1, "arge", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDefaultSizeKnownValues.DefaultSize_Large;
                            goto open_enum_is_done;
                          }
                    break;
                case 'M':
                    switch (json_string.getData()[1])
                      {
                        case 'e':
                            if ((String.Compare(json_string.getData(), 2, "dium", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeDefaultSizeKnownValues.DefaultSize_Medium;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'i':
                            if ((String.Compare(json_string.getData(), 2, "ni", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeDefaultSizeKnownValues.DefaultSize_Mini;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "mall", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeDefaultSizeKnownValues.DefaultSize_Small;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setDefaultSize(the_open_enum);
          }


        private void  fromJSONProductOrCategoryId(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field ProductOrCategoryId of TypeComponentsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field ProductOrCategoryId of TypeComponentsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setProductOrCategoryId(extracted_integer);
          }


        private void  fromJSONLegalItems(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field LegalItems of TypeComponentsJSON is not an array.");
            int count1 = json_array1.componentCount();
            List< BigInteger > vector_LegalItems1 = new List< BigInteger >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                BigInteger extracted_integer;
                JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
                if (json_integer == null)
                  {
                    JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                    if (json_rational == null)
                      {
                        throw new Exception("The value for an element of field LegalItems of TypeComponentsJSON is not a number.");
                      }
                    if (!(json_rational.isInteger()))
                      {
                        throw new Exception("The value for an element of field LegalItems of TypeComponentsJSON is not an integer.");
                      }
                    extracted_integer = json_rational.getInteger()                ;
                  }
                else
                  {
                    extracted_integer = json_integer.getData()                ;
                  }
                vector_LegalItems1.Add(extracted_integer);
              }
            initLegalItems();
            for (int num1 = 0; num1 < vector_LegalItems1.Count; ++num1)
                appendLegalItems(vector_LegalItems1[num1]);
            for (int num1 = 0; num1 < vector_LegalItems1.Count; ++num1)
              {
              }
          }


        private void  fromJSONDefaultItem(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field DefaultItem of TypeComponentsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field DefaultItem of TypeComponentsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setDefaultItem(extracted_integer);
          }


        private void  fromJSONType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            RestaurantMenuComboItemTypeJSON convert_classy = RestaurantMenuComboItemTypeJSON.from_json(json_value, ignore_extras, true);
            setType(convert_classy);
          }


        private void  fromJSONComponentTypeEnum(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            RestaurantMenuComboItemTypeJSON convert_classy = RestaurantMenuComboItemTypeJSON.from_json(json_value, ignore_extras, true);
            setComponentTypeEnum(convert_classy);
          }


        private void  fromJSONMutualExclusiveType(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field MutualExclusiveType of TypeComponentsJSON is not true for false.");
                  }
              }
            setMutualExclusiveType(the_bool);
          }


        private void  fromJSONFillAllOpenSlots(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field FillAllOpenSlots of TypeComponentsJSON is not true for false.");
                  }
              }
            setFillAllOpenSlots(the_bool);
          }


        private void  fromJSONHasComboLevelModifiers(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field HasComboLevelModifiers of TypeComponentsJSON is not true for false.");
                  }
              }
            setHasComboLevelModifiers(the_bool);
          }


        private void  fromJSONStep(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_value.integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_value.rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for field Step of TypeComponentsJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for field Step of TypeComponentsJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            setStep(extracted_integer);
          }


        public TypeComponentsJSON()
          {
            flagHasSizingRestrictions = false;
            flagHasDefaultSize = false;
            flagHasProductOrCategoryId = false;
            flagHasLegalItems = false;
            flagHasDefaultItem = false;
            flagHasType = false;
            flagHasComponentTypeEnum = false;
            flagHasMutualExclusiveType = false;
            flagHasFillAllOpenSlots = false;
            flagHasHasComboLevelModifiers = false;
            flagHasStep = false;
            storeLegalItems = new List< BigInteger >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasSizingRestrictions()
          {
            return flagHasSizingRestrictions;
          }

        public TypeSizingRestrictions  getSizingRestrictions()
          {
            Debug.Assert(flagHasSizingRestrictions);
            return storeSizingRestrictions;
          }

        public string  getSizingRestrictionsAsString()
          {
            TypeSizingRestrictions result = getSizingRestrictions();
            if (result.in_known_list)
                return stringFromSizingRestrictions(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasDefaultSize()
          {
            return flagHasDefaultSize;
          }

        public TypeDefaultSize  getDefaultSize()
          {
            Debug.Assert(flagHasDefaultSize);
            return storeDefaultSize;
          }

        public string  getDefaultSizeAsString()
          {
            TypeDefaultSize result = getDefaultSize();
            if (result.in_known_list)
                return stringFromDefaultSize(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasProductOrCategoryId()
          {
            return flagHasProductOrCategoryId;
          }

        public BigInteger  getProductOrCategoryId()
          {
            Debug.Assert(flagHasProductOrCategoryId);
            return storeProductOrCategoryId;
          }

        public bool  hasLegalItems()
          {
            return flagHasLegalItems;
          }

        public int  countOfLegalItems()
          {
            Debug.Assert(flagHasLegalItems);
            return storeLegalItems.Count;
          }

        public BigInteger  elementOfLegalItems(int element_num)
          {
            Debug.Assert(flagHasLegalItems);
            return storeLegalItems[element_num];
          }

        public List< BigInteger >  getLegalItems()
          {
            Debug.Assert(flagHasLegalItems);
            return storeLegalItems;
          }

        public bool  hasDefaultItem()
          {
            return flagHasDefaultItem;
          }

        public BigInteger  getDefaultItem()
          {
            Debug.Assert(flagHasDefaultItem);
            return storeDefaultItem;
          }

        public bool  hasType()
          {
            return flagHasType;
          }

        public RestaurantMenuComboItemTypeJSON   getType()
          {
            Debug.Assert(flagHasType);
            return storeType;
          }

        public RestaurantMenuComboItemTypeJSON.TypeValue  getTypeValue()
          {
            return getType().getValue();
          }

        public string  getTypeAsString()
          {
            return getType().getValueAsString();
          }

        public bool  hasComponentTypeEnum()
          {
            return flagHasComponentTypeEnum;
          }

        public RestaurantMenuComboItemTypeJSON   getComponentTypeEnum()
          {
            Debug.Assert(flagHasComponentTypeEnum);
            return storeComponentTypeEnum;
          }

        public RestaurantMenuComboItemTypeJSON.TypeValue  getComponentTypeEnumValue()
          {
            return getComponentTypeEnum().getValue();
          }

        public string  getComponentTypeEnumAsString()
          {
            return getComponentTypeEnum().getValueAsString();
          }

        public bool  hasMutualExclusiveType()
          {
            return flagHasMutualExclusiveType;
          }

        public bool  getMutualExclusiveType()
          {
            Debug.Assert(flagHasMutualExclusiveType);
            return storeMutualExclusiveType;
          }

        public bool  hasFillAllOpenSlots()
          {
            return flagHasFillAllOpenSlots;
          }

        public bool  getFillAllOpenSlots()
          {
            Debug.Assert(flagHasFillAllOpenSlots);
            return storeFillAllOpenSlots;
          }

        public bool  hasHasComboLevelModifiers()
          {
            return flagHasHasComboLevelModifiers;
          }

        public bool  getHasComboLevelModifiers()
          {
            Debug.Assert(flagHasHasComboLevelModifiers);
            return storeHasComboLevelModifiers;
          }

        public bool  hasStep()
          {
            return flagHasStep;
          }

        public BigInteger  getStep()
          {
            Debug.Assert(flagHasStep);
            return storeStep;
          }


        public virtual int extraTypeComponentsComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeComponentsComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeComponentsComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeComponentsLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void setSizingRestrictions(TypeSizingRestrictions new_value)
          {
            flagHasSizingRestrictions = true;
            storeSizingRestrictions = new_value;
          }
        public void setSizingRestrictions(string chars)
          {
            TypeSizingRestrictionsKnownValues known = stringToSizingRestrictions(chars);
            TypeSizingRestrictions new_value = new TypeSizingRestrictions();
            if (known == TypeSizingRestrictionsKnownValues.SizingRestrictions__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setSizingRestrictions(new_value);
          }
        public void setSizingRestrictions(TypeSizingRestrictionsKnownValues new_value)
          {
            TypeSizingRestrictions new_full_value = new TypeSizingRestrictions();
            Debug.Assert(new_value != TypeSizingRestrictionsKnownValues.SizingRestrictions__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setSizingRestrictions(new_full_value);
          }
        public void unsetSizingRestrictions()
          {
            flagHasSizingRestrictions = false;
          }
        public void setDefaultSize(TypeDefaultSize new_value)
          {
            flagHasDefaultSize = true;
            storeDefaultSize = new_value;
          }
        public void setDefaultSize(string chars)
          {
            TypeDefaultSizeKnownValues known = stringToDefaultSize(chars);
            TypeDefaultSize new_value = new TypeDefaultSize();
            if (known == TypeDefaultSizeKnownValues.DefaultSize__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setDefaultSize(new_value);
          }
        public void setDefaultSize(TypeDefaultSizeKnownValues new_value)
          {
            TypeDefaultSize new_full_value = new TypeDefaultSize();
            Debug.Assert(new_value != TypeDefaultSizeKnownValues.DefaultSize__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setDefaultSize(new_full_value);
          }
        public void unsetDefaultSize()
          {
            flagHasDefaultSize = false;
          }
        public void setProductOrCategoryId(BigInteger new_value)
          {
            flagHasProductOrCategoryId = true;
            storeProductOrCategoryId = new_value;
          }
        public void unsetProductOrCategoryId()
          {
            flagHasProductOrCategoryId = false;
          }
        public void initLegalItems()
          {
            flagHasLegalItems = true;
            storeLegalItems.Clear();
          }
        public void appendLegalItems(BigInteger to_append)
          {
            if (!flagHasLegalItems)
              {
                flagHasLegalItems = true;
                storeLegalItems.Clear();
              }
            Debug.Assert(flagHasLegalItems);
            storeLegalItems.Add(to_append);
          }
        public void unsetLegalItems()
          {
            flagHasLegalItems = false;
            storeLegalItems.Clear();
          }
        public void setDefaultItem(BigInteger new_value)
          {
            flagHasDefaultItem = true;
            storeDefaultItem = new_value;
          }
        public void unsetDefaultItem()
          {
            flagHasDefaultItem = false;
          }
        public void setType(RestaurantMenuComboItemTypeJSON  new_value)
          {
            if (flagHasType)
              {
              }
            flagHasType = true;
            storeType = new_value;
          }
        public void setType(RestaurantMenuComboItemTypeJSON.TypeValue new_value)
          {
            setType(new RestaurantMenuComboItemTypeJSON(new_value));
          }
        public void setType(string chars)
          {
            RestaurantMenuComboItemTypeJSON.TypeValueKnownValues known = RestaurantMenuComboItemTypeJSON.stringToValue(chars);
            RestaurantMenuComboItemTypeJSON.TypeValue new_value = new RestaurantMenuComboItemTypeJSON.TypeValue();
            if (known == RestaurantMenuComboItemTypeJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setType(new_value);
          }
        public void unsetType()
          {
            if (flagHasType)
              {
              }
            flagHasType = false;
          }
        public void setComponentTypeEnum(RestaurantMenuComboItemTypeJSON  new_value)
          {
            if (flagHasComponentTypeEnum)
              {
              }
            flagHasComponentTypeEnum = true;
            storeComponentTypeEnum = new_value;
          }
        public void setComponentTypeEnum(RestaurantMenuComboItemTypeJSON.TypeValue new_value)
          {
            setComponentTypeEnum(new RestaurantMenuComboItemTypeJSON(new_value));
          }
        public void setComponentTypeEnum(string chars)
          {
            RestaurantMenuComboItemTypeJSON.TypeValueKnownValues known = RestaurantMenuComboItemTypeJSON.stringToValue(chars);
            RestaurantMenuComboItemTypeJSON.TypeValue new_value = new RestaurantMenuComboItemTypeJSON.TypeValue();
            if (known == RestaurantMenuComboItemTypeJSON.TypeValueKnownValues.Value__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setComponentTypeEnum(new_value);
          }
        public void unsetComponentTypeEnum()
          {
            if (flagHasComponentTypeEnum)
              {
              }
            flagHasComponentTypeEnum = false;
          }
        public void setMutualExclusiveType(bool new_value)
          {
            flagHasMutualExclusiveType = true;
            storeMutualExclusiveType = new_value;
          }
        public void unsetMutualExclusiveType()
          {
            flagHasMutualExclusiveType = false;
          }
        public void setFillAllOpenSlots(bool new_value)
          {
            flagHasFillAllOpenSlots = true;
            storeFillAllOpenSlots = new_value;
          }
        public void unsetFillAllOpenSlots()
          {
            flagHasFillAllOpenSlots = false;
          }
        public void setHasComboLevelModifiers(bool new_value)
          {
            flagHasHasComboLevelModifiers = true;
            storeHasComboLevelModifiers = new_value;
          }
        public void unsetHasComboLevelModifiers()
          {
            flagHasHasComboLevelModifiers = false;
          }
        public void setStep(BigInteger new_value)
          {
            flagHasStep = true;
            storeStep = new_value;
          }
        public void unsetStep()
          {
            flagHasStep = false;
          }

        public virtual void extraTypeComponentsAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeComponentsSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeComponentsLookup(key);
            if (old_field == null)
              {
                extraTypeComponentsAppendPair(key, new_component);
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
            if (flagHasSizingRestrictions)
              {
                handler.start_pair("SizingRestrictions");
                if (storeSizingRestrictions.in_known_list)
                  {
                    switch (storeSizingRestrictions.list_value)
                      {
                        case TypeSizingRestrictionsKnownValues.SizingRestrictions_NoUpsizing:
                            handler.string_value("NoUpsizing");
                            break;
                        case TypeSizingRestrictionsKnownValues.SizingRestrictions_NoDownsizing:
                            handler.string_value("NoDownsizing");
                            break;
                        case TypeSizingRestrictionsKnownValues.SizingRestrictions_NoResizing:
                            handler.string_value("NoResizing");
                            break;
                        case TypeSizingRestrictionsKnownValues.SizingRestrictions_None:
                            handler.string_value("None");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeSizingRestrictions.string_value);
                  }
              }
            if (flagHasDefaultSize)
              {
                handler.start_pair("DefaultSize");
                if (storeDefaultSize.in_known_list)
                  {
                    switch (storeDefaultSize.list_value)
                      {
                        case TypeDefaultSizeKnownValues.DefaultSize_Mini:
                            handler.string_value("Mini");
                            break;
                        case TypeDefaultSizeKnownValues.DefaultSize_Small:
                            handler.string_value("Small");
                            break;
                        case TypeDefaultSizeKnownValues.DefaultSize_Medium:
                            handler.string_value("Medium");
                            break;
                        case TypeDefaultSizeKnownValues.DefaultSize_Large:
                            handler.string_value("Large");
                            break;
                        case TypeDefaultSizeKnownValues.DefaultSize_ExtraLarge:
                            handler.string_value("ExtraLarge");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeDefaultSize.string_value);
                  }
              }
            Debug.Assert(partial_allowed || flagHasProductOrCategoryId);
            if (flagHasProductOrCategoryId)
              {
                handler.start_pair("ProductOrCategoryId");
                handler.number_value(storeProductOrCategoryId);
              }
            if (flagHasLegalItems)
              {
                handler.start_pair("LegalItems");
                handler.start_array();
                for (int num1 = 0; num1 < storeLegalItems.Count; ++num1)
                  {
                    handler.number_value(storeLegalItems[num1]);
                  }
                handler.finish_array();
              }
            if (flagHasDefaultItem)
              {
                handler.start_pair("DefaultItem");
                handler.number_value(storeDefaultItem);
              }
            if (flagHasType)
              {
                handler.start_pair("Type");
                if (partial_allowed)
                    storeType.write_partial_as_json(handler);
                else
                    storeType.write_as_json(handler);
              }
            if (flagHasComponentTypeEnum)
              {
                handler.start_pair("ComponentTypeEnum");
                if (partial_allowed)
                    storeComponentTypeEnum.write_partial_as_json(handler);
                else
                    storeComponentTypeEnum.write_as_json(handler);
              }
            if (flagHasMutualExclusiveType)
              {
                handler.start_pair("MutualExclusiveType");
                handler.boolean_value(storeMutualExclusiveType);
              }
            if (flagHasFillAllOpenSlots)
              {
                handler.start_pair("FillAllOpenSlots");
                handler.boolean_value(storeFillAllOpenSlots);
              }
            if (flagHasHasComboLevelModifiers)
              {
                handler.start_pair("HasComboLevelModifiers");
                handler.boolean_value(storeHasComboLevelModifiers);
              }
            if (flagHasStep)
              {
                handler.start_pair("Step");
                handler.number_value(storeStep);
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
            if (!(hasProductOrCategoryId()))
              {
                return "When parsing the object for %what%, the \"ProductOrCategoryId\" field was missing.";
              }
            return null;
          }

        public static TypeComponentsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeComponentsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeComponents", ignore_extras);
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
        public static TypeComponentsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeComponentsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeComponentsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeComponents", ignore_extras);
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
        public static TypeComponentsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeComponentsJSON from_text(string text, bool ignore_extras)
          {
            TypeComponentsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeComponents", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeComponentsJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeComponentsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeComponentsJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeComponents", ignore_extras);
                JSONParse.parse_json_value(fp, file_name, generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public abstract class Generator : JSONObjectGenerator
          {
        private abstract class FieldGeneratorSizingRestrictions : JSONStringGenerator
              {
                protected FieldGeneratorSizingRestrictions(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorSizingRestrictions()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeSizingRestrictionsKnownValues known = stringToSizingRestrictions(result);
                    TypeSizingRestrictions new_value = new TypeSizingRestrictions();
                    if (known == TypeSizingRestrictionsKnownValues.SizingRestrictions__none)
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
                protected abstract void handle_result(TypeSizingRestrictions result);
              };
        private class FieldHoldingGeneratorSizingRestrictions : FieldGeneratorSizingRestrictions
      {
        protected override void handle_result(TypeSizingRestrictions result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorSizingRestrictions(String what)
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
        public TypeSizingRestrictions value;
      };
        private class FieldHoldingArrayGeneratorSizingRestrictions : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorSizingRestrictions
          {
            private FieldHoldingArrayGeneratorSizingRestrictions top;

            protected override void handle_result(TypeSizingRestrictions result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorSizingRestrictions init_top)
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
        protected virtual void handle_result(List<TypeSizingRestrictions> result)
          {
          }

        public FieldHoldingArrayGeneratorSizingRestrictions(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeSizingRestrictions>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorSizingRestrictions()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeSizingRestrictions>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeSizingRestrictions> value;
      };
            private FieldHoldingGeneratorSizingRestrictions fieldGeneratorSizingRestrictions;
        private abstract class FieldGeneratorDefaultSize : JSONStringGenerator
              {
                protected FieldGeneratorDefaultSize(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorDefaultSize()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeDefaultSizeKnownValues known = stringToDefaultSize(result);
                    TypeDefaultSize new_value = new TypeDefaultSize();
                    if (known == TypeDefaultSizeKnownValues.DefaultSize__none)
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
                protected abstract void handle_result(TypeDefaultSize result);
              };
        private class FieldHoldingGeneratorDefaultSize : FieldGeneratorDefaultSize
      {
        protected override void handle_result(TypeDefaultSize result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorDefaultSize(String what)
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
        public TypeDefaultSize value;
      };
        private class FieldHoldingArrayGeneratorDefaultSize : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorDefaultSize
          {
            private FieldHoldingArrayGeneratorDefaultSize top;

            protected override void handle_result(TypeDefaultSize result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorDefaultSize init_top)
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
        protected virtual void handle_result(List<TypeDefaultSize> result)
          {
          }

        public FieldHoldingArrayGeneratorDefaultSize(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeDefaultSize>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorDefaultSize()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeDefaultSize>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeDefaultSize> value;
      };
            private FieldHoldingGeneratorDefaultSize fieldGeneratorDefaultSize;
        private class FieldHoldingGeneratorProductOrCategoryId : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorProductOrCategoryId(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorProductOrCategoryId : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorProductOrCategoryId(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorProductOrCategoryId fieldGeneratorProductOrCategoryId;
        private class FieldHoldingGeneratorLegalItems : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorLegalItems(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorLegalItems : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorLegalItems(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingArrayGeneratorLegalItems fieldGeneratorLegalItems;
        private class FieldHoldingGeneratorDefaultItem : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorDefaultItem(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorDefaultItem : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorDefaultItem(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorDefaultItem fieldGeneratorDefaultItem;
            private RestaurantMenuComboItemTypeJSON.HoldingGenerator fieldGeneratorType;
            private RestaurantMenuComboItemTypeJSON.HoldingGenerator fieldGeneratorComponentTypeEnum;
            private JSONHoldingBooleanGenerator fieldGeneratorMutualExclusiveType;
            private JSONHoldingBooleanGenerator fieldGeneratorFillAllOpenSlots;
            private JSONHoldingBooleanGenerator fieldGeneratorHasComboLevelModifiers;
        private class FieldHoldingGeneratorStep : JSONHoldingIntegerUnboundRangeGenerator
              {
                public FieldHoldingGeneratorStep(String what) : base(what)
                  {
                  }
              };
        private class FieldHoldingArrayGeneratorStep : JSONHoldingIntegerUnboundRangeArrayGenerator
              {
                public FieldHoldingArrayGeneratorStep(String what) : base(what)
                  {
                  }
              };
            private FieldHoldingGeneratorStep fieldGeneratorStep;
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
                TypeComponentsJSON result = new TypeComponentsJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeComponentsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeComponentsJSON result)
              {
                if (fieldGeneratorSizingRestrictions.have_value)
                  {
                    result.setSizingRestrictions(fieldGeneratorSizingRestrictions.value);
                    fieldGeneratorSizingRestrictions.have_value = false;
                  }
                if (fieldGeneratorDefaultSize.have_value)
                  {
                    result.setDefaultSize(fieldGeneratorDefaultSize.value);
                    fieldGeneratorDefaultSize.have_value = false;
                  }
                if (fieldGeneratorProductOrCategoryId.have_value)
                  {
                    result.setProductOrCategoryId(fieldGeneratorProductOrCategoryId.value);
                    fieldGeneratorProductOrCategoryId.have_value = false;
                  }
                else if ((!(result.hasProductOrCategoryId())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"ProductOrCategoryId\" field was missing.");
                  }
                if (fieldGeneratorLegalItems.have_value)
                  {
                    result.initLegalItems();
                    int count = fieldGeneratorLegalItems.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendLegalItems(fieldGeneratorLegalItems.value[num]);
                      }
                    fieldGeneratorLegalItems.value.Clear();
                    fieldGeneratorLegalItems.have_value = false;
                  }
                if (fieldGeneratorDefaultItem.have_value)
                  {
                    result.setDefaultItem(fieldGeneratorDefaultItem.value);
                    fieldGeneratorDefaultItem.have_value = false;
                  }
                if (fieldGeneratorType.have_value)
                  {
                    result.setType(fieldGeneratorType.value);
                    fieldGeneratorType.have_value = false;
                  }
                if (fieldGeneratorComponentTypeEnum.have_value)
                  {
                    result.setComponentTypeEnum(fieldGeneratorComponentTypeEnum.value);
                    fieldGeneratorComponentTypeEnum.have_value = false;
                  }
                if (fieldGeneratorMutualExclusiveType.have_value)
                  {
                    result.setMutualExclusiveType(fieldGeneratorMutualExclusiveType.value);
                    fieldGeneratorMutualExclusiveType.have_value = false;
                  }
                if (fieldGeneratorFillAllOpenSlots.have_value)
                  {
                    result.setFillAllOpenSlots(fieldGeneratorFillAllOpenSlots.value);
                    fieldGeneratorFillAllOpenSlots.have_value = false;
                  }
                if (fieldGeneratorHasComboLevelModifiers.have_value)
                  {
                    result.setHasComboLevelModifiers(fieldGeneratorHasComboLevelModifiers.value);
                    fieldGeneratorHasComboLevelModifiers.have_value = false;
                  }
                if (fieldGeneratorStep.have_value)
                  {
                    result.setStep(fieldGeneratorStep.value);
                    fieldGeneratorStep.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeComponentsJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'C':
                        if ((String.Compare(field_name, 1, "omponentTypeEnum", 0, 16, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorComponentTypeEnum;
                        break;
                    case 'D':
                        if (String.Compare(field_name, 1, "efault", 0, 6, false) == 0)
                          {
                            switch (field_name[7])
                              {
                                case 'I':
                                    if ((String.Compare(field_name, 8, "tem", 0, 3, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorDefaultItem;
                                    break;
                                case 'S':
                                    if ((String.Compare(field_name, 8, "ize", 0, 3, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorDefaultSize;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'F':
                        if ((String.Compare(field_name, 1, "illAllOpenSlots", 0, 15, false) == 0) && (field_name.Length == 16))
                            return fieldGeneratorFillAllOpenSlots;
                        break;
                    case 'H':
                        if ((String.Compare(field_name, 1, "asComboLevelModifiers", 0, 21, false) == 0) && (field_name.Length == 22))
                            return fieldGeneratorHasComboLevelModifiers;
                        break;
                    case 'L':
                        if ((String.Compare(field_name, 1, "egalItems", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorLegalItems;
                        break;
                    case 'M':
                        if ((String.Compare(field_name, 1, "utualExclusiveType", 0, 18, false) == 0) && (field_name.Length == 19))
                            return fieldGeneratorMutualExclusiveType;
                        break;
                    case 'P':
                        if ((String.Compare(field_name, 1, "roductOrCategoryId", 0, 18, false) == 0) && (field_name.Length == 19))
                            return fieldGeneratorProductOrCategoryId;
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'i':
                                if ((String.Compare(field_name, 2, "zingRestrictions", 0, 16, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorSizingRestrictions;
                                break;
                            case 't':
                                if ((String.Compare(field_name, 2, "ep", 0, 2, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorStep;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "ype", 0, 3, false) == 0) && (field_name.Length == 4))
                            return fieldGeneratorType;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorSizingRestrictions = new FieldHoldingGeneratorSizingRestrictions("field \"SizingRestrictions\" of the TypeComponents class");
                fieldGeneratorDefaultSize = new FieldHoldingGeneratorDefaultSize("field \"DefaultSize\" of the TypeComponents class");
                fieldGeneratorProductOrCategoryId = new FieldHoldingGeneratorProductOrCategoryId("field \"ProductOrCategoryId\" of the TypeComponents class");
                fieldGeneratorLegalItems = new FieldHoldingArrayGeneratorLegalItems("field \"LegalItems\" of the TypeComponents class");
                fieldGeneratorDefaultItem = new FieldHoldingGeneratorDefaultItem("field \"DefaultItem\" of the TypeComponents class");
                fieldGeneratorType = new RestaurantMenuComboItemTypeJSON.HoldingGenerator("field \"Type\" of the TypeComponents class", ignore_extras);
                fieldGeneratorComponentTypeEnum = new RestaurantMenuComboItemTypeJSON.HoldingGenerator("field \"ComponentTypeEnum\" of the TypeComponents class", ignore_extras);
                fieldGeneratorMutualExclusiveType = new JSONHoldingBooleanGenerator("field \"MutualExclusiveType\" of the TypeComponents class");
                fieldGeneratorFillAllOpenSlots = new JSONHoldingBooleanGenerator("field \"FillAllOpenSlots\" of the TypeComponents class");
                fieldGeneratorHasComboLevelModifiers = new JSONHoldingBooleanGenerator("field \"HasComboLevelModifiers\" of the TypeComponents class");
                fieldGeneratorStep = new FieldHoldingGeneratorStep("field \"Step\" of the TypeComponents class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeComponents class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorSizingRestrictions = new FieldHoldingGeneratorSizingRestrictions("field \"SizingRestrictions\" of the TypeComponents class");
                fieldGeneratorDefaultSize = new FieldHoldingGeneratorDefaultSize("field \"DefaultSize\" of the TypeComponents class");
                fieldGeneratorProductOrCategoryId = new FieldHoldingGeneratorProductOrCategoryId("field \"ProductOrCategoryId\" of the TypeComponents class");
                fieldGeneratorLegalItems = new FieldHoldingArrayGeneratorLegalItems("field \"LegalItems\" of the TypeComponents class");
                fieldGeneratorDefaultItem = new FieldHoldingGeneratorDefaultItem("field \"DefaultItem\" of the TypeComponents class");
                fieldGeneratorType = new RestaurantMenuComboItemTypeJSON.HoldingGenerator("field \"Type\" of the TypeComponents class", false);
                fieldGeneratorComponentTypeEnum = new RestaurantMenuComboItemTypeJSON.HoldingGenerator("field \"ComponentTypeEnum\" of the TypeComponents class", false);
                fieldGeneratorMutualExclusiveType = new JSONHoldingBooleanGenerator("field \"MutualExclusiveType\" of the TypeComponents class");
                fieldGeneratorFillAllOpenSlots = new JSONHoldingBooleanGenerator("field \"FillAllOpenSlots\" of the TypeComponents class");
                fieldGeneratorHasComboLevelModifiers = new JSONHoldingBooleanGenerator("field \"HasComboLevelModifiers\" of the TypeComponents class");
                fieldGeneratorStep = new FieldHoldingGeneratorStep("field \"Step\" of the TypeComponents class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeComponents class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorSizingRestrictions.reset();
                fieldGeneratorDefaultSize.reset();
                fieldGeneratorProductOrCategoryId.reset();
                fieldGeneratorLegalItems.reset();
                fieldGeneratorDefaultItem.reset();
                fieldGeneratorType.reset();
                fieldGeneratorComponentTypeEnum.reset();
                fieldGeneratorMutualExclusiveType.reset();
                fieldGeneratorFillAllOpenSlots.reset();
                fieldGeneratorHasComboLevelModifiers.reset();
                fieldGeneratorStep.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorType.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorComponentTypeEnum.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorType.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorComponentTypeEnum.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeComponentsJSON  result)
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
            public TypeComponentsJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeComponentsJSON  result)
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
        protected virtual void handle_result(List<TypeComponentsJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeComponentsJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeComponentsJSON>();
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
        public List<TypeComponentsJSON> value;
      };
      };
    private bool flagHasHasComponents;
    private bool storeHasComponents;
    private bool flagHasProductId;
    private BigInteger storeProductId;
    private bool flagHasRestaurantId;
    private BigInteger storeRestaurantId;
    private bool flagHasParentItemId;
    private BigInteger storeParentItemId;
    private bool flagHasSynonyms;
    private List< string > storeSynonyms;
    private bool flagHasTerrierExpression;
    private string storeTerrierExpression;
    private bool flagHasTerrierExpressionPerfect;
    private string storeTerrierExpressionPerfect;
    private bool flagHasTerrierExpressionConfusion;
    private string storeTerrierExpressionConfusion;
    private bool flagHasFlexibleExpressionData;
    private List< RestaurantMenuFlexibleExpressionDataJSON  > storeFlexibleExpressionData;
    private bool flagHasComponents;
    private List< TypeComponentsJSON  > storeComponents;
    private bool flagHasItemImage;
    private string storeItemImage;
    private bool flagHasComponentOfCombos;
    private List< BigInteger > storeComponentOfCombos;
    private bool flagHasComponentOfComboTerrierExpression;
    private string storeComponentOfComboTerrierExpression;
    private bool flagHasItemName;
    private string storeItemName;
    private bool flagHasItemNameSpoken;
    private string storeItemNameSpoken;
    private bool flagHasDefaultItem;
    private BigInteger storeDefaultItem;
    private bool flagHasModifiers;
    private List< BigInteger > storeModifiers;
    private bool flagHasPreferredModifiers;
    private List< BigInteger > storePreferredModifiers;
    private bool flagHasCondiments;
    private List< BigInteger > storeCondiments;
    private bool flagHasSizedObjectTuples;
    private List< RestaurantMenuSizedObjectJSON  > storeSizedObjectTuples;
    private bool flagHasSizedObjects;
    private List< BigInteger > storeSizedObjects;
    private bool flagHasSizePrompt;
    private string storeSizePrompt;
    private bool flagHasSizePromptSpoken;
    private string storeSizePromptSpoken;
    private bool flagHasModifierSets;
    private List< RestaurantMenuModifierSetsJSON  > storeModifierSets;
    private bool flagHasOrderable;
    private bool storeOrderable;
    private bool flagHasPrice;
    private double storePrice;
    private string textStorePrice;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONHasComponents(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field HasComponents of RestaurantMenuMenuItemJSON is not true for false.");
              }
          }
        setHasComponents(the_bool);
      }


    private void  fromJSONProductId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ProductId of RestaurantMenuMenuItemJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ProductId of RestaurantMenuMenuItemJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setProductId(extracted_integer);
      }


    private void  fromJSONRestaurantId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field RestaurantId of RestaurantMenuMenuItemJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field RestaurantId of RestaurantMenuMenuItemJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setRestaurantId(extracted_integer);
      }


    private void  fromJSONParentItemId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field ParentItemId of RestaurantMenuMenuItemJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field ParentItemId of RestaurantMenuMenuItemJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setParentItemId(extracted_integer);
      }


    private void  fromJSONSynonyms(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Synonyms of RestaurantMenuMenuItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Synonyms of RestaurantMenuMenuItemJSON has too few elements.");
        List< string > vector_Synonyms1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Synonyms of RestaurantMenuMenuItemJSON is not a string.");
            vector_Synonyms1.Add(json_string.getData());
          }
        Debug.Assert(vector_Synonyms1.Count >= 1);
        initSynonyms();
        for (int num2 = 0; num2 < vector_Synonyms1.Count; ++num2)
            appendSynonyms(vector_Synonyms1[num2]);
        for (int num1 = 0; num1 < vector_Synonyms1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTerrierExpression(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TerrierExpression of RestaurantMenuMenuItemJSON is not a string.");
        setTerrierExpression(json_string.getData());
      }


    private void  fromJSONTerrierExpressionPerfect(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TerrierExpressionPerfect of RestaurantMenuMenuItemJSON is not a string.");
        setTerrierExpressionPerfect(json_string.getData());
      }


    private void  fromJSONTerrierExpressionConfusion(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TerrierExpressionConfusion of RestaurantMenuMenuItemJSON is not a string.");
        setTerrierExpressionConfusion(json_string.getData());
      }


    private void  fromJSONFlexibleExpressionData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field FlexibleExpressionData of RestaurantMenuMenuItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field FlexibleExpressionData of RestaurantMenuMenuItemJSON has too few elements.");
        List< RestaurantMenuFlexibleExpressionDataJSON  > vector_FlexibleExpressionData1 = new List< RestaurantMenuFlexibleExpressionDataJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantMenuFlexibleExpressionDataJSON convert_classy = RestaurantMenuFlexibleExpressionDataJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_FlexibleExpressionData1.Add(convert_classy);
          }
        Debug.Assert(vector_FlexibleExpressionData1.Count >= 1);
        initFlexibleExpressionData();
        for (int num3 = 0; num3 < vector_FlexibleExpressionData1.Count; ++num3)
            appendFlexibleExpressionData(vector_FlexibleExpressionData1[num3]);
        for (int num1 = 0; num1 < vector_FlexibleExpressionData1.Count; ++num1)
          {
          }
      }


    private void  fromJSONComponents(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Components of RestaurantMenuMenuItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeComponentsJSON  > vector_Components1 = new List< TypeComponentsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TypeComponentsJSON convert_classy = TypeComponentsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Components1.Add(convert_classy);
          }
        initComponents();
        for (int num4 = 0; num4 < vector_Components1.Count; ++num4)
            appendComponents(vector_Components1[num4]);
        for (int num1 = 0; num1 < vector_Components1.Count; ++num1)
          {
          }
      }


    private void  fromJSONItemImage(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ItemImage of RestaurantMenuMenuItemJSON is not a string.");
        setItemImage(json_string.getData());
      }


    private void  fromJSONComponentOfCombos(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ComponentOfCombos of RestaurantMenuMenuItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ComponentOfCombos of RestaurantMenuMenuItemJSON has too few elements.");
        List< BigInteger > vector_ComponentOfCombos1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field ComponentOfCombos of RestaurantMenuMenuItemJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field ComponentOfCombos of RestaurantMenuMenuItemJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_ComponentOfCombos1.Add(extracted_integer);
          }
        Debug.Assert(vector_ComponentOfCombos1.Count >= 1);
        initComponentOfCombos();
        for (int num5 = 0; num5 < vector_ComponentOfCombos1.Count; ++num5)
            appendComponentOfCombos(vector_ComponentOfCombos1[num5]);
        for (int num1 = 0; num1 < vector_ComponentOfCombos1.Count; ++num1)
          {
          }
      }


    private void  fromJSONComponentOfComboTerrierExpression(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ComponentOfComboTerrierExpression of RestaurantMenuMenuItemJSON is not a string.");
        setComponentOfComboTerrierExpression(json_string.getData());
      }


    private void  fromJSONItemName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ItemName of RestaurantMenuMenuItemJSON is not a string.");
        setItemName(json_string.getData());
      }


    private void  fromJSONItemNameSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ItemNameSpoken of RestaurantMenuMenuItemJSON is not a string.");
        setItemNameSpoken(json_string.getData());
      }


    private void  fromJSONDefaultItem(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field DefaultItem of RestaurantMenuMenuItemJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field DefaultItem of RestaurantMenuMenuItemJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setDefaultItem(extracted_integer);
      }


    private void  fromJSONModifiers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Modifiers of RestaurantMenuMenuItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_Modifiers1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field Modifiers of RestaurantMenuMenuItemJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field Modifiers of RestaurantMenuMenuItemJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_Modifiers1.Add(extracted_integer);
          }
        initModifiers();
        for (int num6 = 0; num6 < vector_Modifiers1.Count; ++num6)
            appendModifiers(vector_Modifiers1[num6]);
        for (int num1 = 0; num1 < vector_Modifiers1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPreferredModifiers(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field PreferredModifiers of RestaurantMenuMenuItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_PreferredModifiers1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field PreferredModifiers of RestaurantMenuMenuItemJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field PreferredModifiers of RestaurantMenuMenuItemJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_PreferredModifiers1.Add(extracted_integer);
          }
        initPreferredModifiers();
        for (int num7 = 0; num7 < vector_PreferredModifiers1.Count; ++num7)
            appendPreferredModifiers(vector_PreferredModifiers1[num7]);
        for (int num1 = 0; num1 < vector_PreferredModifiers1.Count; ++num1)
          {
          }
      }


    private void  fromJSONCondiments(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Condiments of RestaurantMenuMenuItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_Condiments1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field Condiments of RestaurantMenuMenuItemJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field Condiments of RestaurantMenuMenuItemJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_Condiments1.Add(extracted_integer);
          }
        initCondiments();
        for (int num8 = 0; num8 < vector_Condiments1.Count; ++num8)
            appendCondiments(vector_Condiments1[num8]);
        for (int num1 = 0; num1 < vector_Condiments1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSizedObjectTuples(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SizedObjectTuples of RestaurantMenuMenuItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field SizedObjectTuples of RestaurantMenuMenuItemJSON has too few elements.");
        List< RestaurantMenuSizedObjectJSON  > vector_SizedObjectTuples1 = new List< RestaurantMenuSizedObjectJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantMenuSizedObjectJSON convert_classy = RestaurantMenuSizedObjectJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_SizedObjectTuples1.Add(convert_classy);
          }
        Debug.Assert(vector_SizedObjectTuples1.Count >= 1);
        initSizedObjectTuples();
        for (int num9 = 0; num9 < vector_SizedObjectTuples1.Count; ++num9)
            appendSizedObjectTuples(vector_SizedObjectTuples1[num9]);
        for (int num1 = 0; num1 < vector_SizedObjectTuples1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSizedObjects(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SizedObjects of RestaurantMenuMenuItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_SizedObjects1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field SizedObjects of RestaurantMenuMenuItemJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field SizedObjects of RestaurantMenuMenuItemJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_SizedObjects1.Add(extracted_integer);
          }
        initSizedObjects();
        for (int num10 = 0; num10 < vector_SizedObjects1.Count; ++num10)
            appendSizedObjects(vector_SizedObjects1[num10]);
        for (int num1 = 0; num1 < vector_SizedObjects1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSizePrompt(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SizePrompt of RestaurantMenuMenuItemJSON is not a string.");
        setSizePrompt(json_string.getData());
      }


    private void  fromJSONSizePromptSpoken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SizePromptSpoken of RestaurantMenuMenuItemJSON is not a string.");
        setSizePromptSpoken(json_string.getData());
      }


    private void  fromJSONModifierSets(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ModifierSets of RestaurantMenuMenuItemJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< RestaurantMenuModifierSetsJSON  > vector_ModifierSets1 = new List< RestaurantMenuModifierSetsJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            RestaurantMenuModifierSetsJSON convert_classy = RestaurantMenuModifierSetsJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ModifierSets1.Add(convert_classy);
          }
        initModifierSets();
        for (int num11 = 0; num11 < vector_ModifierSets1.Count; ++num11)
            appendModifierSets(vector_ModifierSets1[num11]);
        for (int num1 = 0; num1 < vector_ModifierSets1.Count; ++num1)
          {
          }
      }


    private void  fromJSONOrderable(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Orderable of RestaurantMenuMenuItemJSON is not true for false.");
              }
          }
        setOrderable(the_bool);
      }


    private void  fromJSONPrice(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Price of RestaurantMenuMenuItemJSON is not a number.");
              }
          }
        setPriceText(the_rational_text);
      }


    public RestaurantMenuMenuItemJSON()
      {
        flagHasHasComponents = false;
        flagHasProductId = false;
        flagHasRestaurantId = false;
        flagHasParentItemId = false;
        flagHasSynonyms = false;
        flagHasTerrierExpression = false;
        flagHasTerrierExpressionPerfect = false;
        flagHasTerrierExpressionConfusion = false;
        flagHasFlexibleExpressionData = false;
        flagHasComponents = false;
        flagHasItemImage = false;
        flagHasComponentOfCombos = false;
        flagHasComponentOfComboTerrierExpression = false;
        flagHasItemName = false;
        flagHasItemNameSpoken = false;
        flagHasDefaultItem = false;
        flagHasModifiers = false;
        flagHasPreferredModifiers = false;
        flagHasCondiments = false;
        flagHasSizedObjectTuples = false;
        flagHasSizedObjects = false;
        flagHasSizePrompt = false;
        flagHasSizePromptSpoken = false;
        flagHasModifierSets = false;
        flagHasOrderable = false;
        flagHasPrice = false;
        storeSynonyms = new List< string >();
        storeFlexibleExpressionData = new List< RestaurantMenuFlexibleExpressionDataJSON  >();
        storeComponents = new List< TypeComponentsJSON  >();
        storeComponentOfCombos = new List< BigInteger >();
        storeModifiers = new List< BigInteger >();
        storePreferredModifiers = new List< BigInteger >();
        storeCondiments = new List< BigInteger >();
        storeSizedObjectTuples = new List< RestaurantMenuSizedObjectJSON  >();
        storeSizedObjects = new List< BigInteger >();
        storeModifierSets = new List< RestaurantMenuModifierSetsJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasHasComponents()
      {
        return flagHasHasComponents;
      }

    public bool  getHasComponents()
      {
        Debug.Assert(flagHasHasComponents);
        return storeHasComponents;
      }

    public bool  hasProductId()
      {
        return flagHasProductId;
      }

    public BigInteger  getProductId()
      {
        Debug.Assert(flagHasProductId);
        return storeProductId;
      }

    public bool  hasRestaurantId()
      {
        return flagHasRestaurantId;
      }

    public BigInteger  getRestaurantId()
      {
        Debug.Assert(flagHasRestaurantId);
        return storeRestaurantId;
      }

    public bool  hasParentItemId()
      {
        return flagHasParentItemId;
      }

    public BigInteger  getParentItemId()
      {
        Debug.Assert(flagHasParentItemId);
        return storeParentItemId;
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

    public bool  hasTerrierExpressionPerfect()
      {
        return flagHasTerrierExpressionPerfect;
      }

    public string  getTerrierExpressionPerfect()
      {
        Debug.Assert(flagHasTerrierExpressionPerfect);
        return storeTerrierExpressionPerfect;
      }

    public bool  hasTerrierExpressionConfusion()
      {
        return flagHasTerrierExpressionConfusion;
      }

    public string  getTerrierExpressionConfusion()
      {
        Debug.Assert(flagHasTerrierExpressionConfusion);
        return storeTerrierExpressionConfusion;
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

    public bool  hasComponents()
      {
        return flagHasComponents;
      }

    public int  countOfComponents()
      {
        Debug.Assert(flagHasComponents);
        return storeComponents.Count;
      }

    public TypeComponentsJSON   elementOfComponents(int element_num)
      {
        Debug.Assert(flagHasComponents);
        return storeComponents[element_num];
      }

    public List< TypeComponentsJSON  >  getComponents()
      {
        Debug.Assert(flagHasComponents);
        return storeComponents;
      }

    public bool  hasItemImage()
      {
        return flagHasItemImage;
      }

    public string  getItemImage()
      {
        Debug.Assert(flagHasItemImage);
        return storeItemImage;
      }

    public bool  hasComponentOfCombos()
      {
        return flagHasComponentOfCombos;
      }

    public int  countOfComponentOfCombos()
      {
        Debug.Assert(flagHasComponentOfCombos);
        return storeComponentOfCombos.Count;
      }

    public BigInteger  elementOfComponentOfCombos(int element_num)
      {
        Debug.Assert(flagHasComponentOfCombos);
        return storeComponentOfCombos[element_num];
      }

    public List< BigInteger >  getComponentOfCombos()
      {
        Debug.Assert(flagHasComponentOfCombos);
        return storeComponentOfCombos;
      }

    public bool  hasComponentOfComboTerrierExpression()
      {
        return flagHasComponentOfComboTerrierExpression;
      }

    public string  getComponentOfComboTerrierExpression()
      {
        Debug.Assert(flagHasComponentOfComboTerrierExpression);
        return storeComponentOfComboTerrierExpression;
      }

    public bool  hasItemName()
      {
        return flagHasItemName;
      }

    public string  getItemName()
      {
        Debug.Assert(flagHasItemName);
        return storeItemName;
      }

    public bool  hasItemNameSpoken()
      {
        return flagHasItemNameSpoken;
      }

    public string  getItemNameSpoken()
      {
        Debug.Assert(flagHasItemNameSpoken);
        return storeItemNameSpoken;
      }

    public bool  hasDefaultItem()
      {
        return flagHasDefaultItem;
      }

    public BigInteger  getDefaultItem()
      {
        Debug.Assert(flagHasDefaultItem);
        return storeDefaultItem;
      }

    public bool  hasModifiers()
      {
        return flagHasModifiers;
      }

    public int  countOfModifiers()
      {
        Debug.Assert(flagHasModifiers);
        return storeModifiers.Count;
      }

    public BigInteger  elementOfModifiers(int element_num)
      {
        Debug.Assert(flagHasModifiers);
        return storeModifiers[element_num];
      }

    public List< BigInteger >  getModifiers()
      {
        Debug.Assert(flagHasModifiers);
        return storeModifiers;
      }

    public bool  hasPreferredModifiers()
      {
        return flagHasPreferredModifiers;
      }

    public int  countOfPreferredModifiers()
      {
        Debug.Assert(flagHasPreferredModifiers);
        return storePreferredModifiers.Count;
      }

    public BigInteger  elementOfPreferredModifiers(int element_num)
      {
        Debug.Assert(flagHasPreferredModifiers);
        return storePreferredModifiers[element_num];
      }

    public List< BigInteger >  getPreferredModifiers()
      {
        Debug.Assert(flagHasPreferredModifiers);
        return storePreferredModifiers;
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

    public BigInteger  elementOfCondiments(int element_num)
      {
        Debug.Assert(flagHasCondiments);
        return storeCondiments[element_num];
      }

    public List< BigInteger >  getCondiments()
      {
        Debug.Assert(flagHasCondiments);
        return storeCondiments;
      }

    public bool  hasSizedObjectTuples()
      {
        return flagHasSizedObjectTuples;
      }

    public int  countOfSizedObjectTuples()
      {
        Debug.Assert(flagHasSizedObjectTuples);
        return storeSizedObjectTuples.Count;
      }

    public RestaurantMenuSizedObjectJSON   elementOfSizedObjectTuples(int element_num)
      {
        Debug.Assert(flagHasSizedObjectTuples);
        return storeSizedObjectTuples[element_num];
      }

    public List< RestaurantMenuSizedObjectJSON  >  getSizedObjectTuples()
      {
        Debug.Assert(flagHasSizedObjectTuples);
        return storeSizedObjectTuples;
      }

    public bool  hasSizedObjects()
      {
        return flagHasSizedObjects;
      }

    public int  countOfSizedObjects()
      {
        Debug.Assert(flagHasSizedObjects);
        return storeSizedObjects.Count;
      }

    public BigInteger  elementOfSizedObjects(int element_num)
      {
        Debug.Assert(flagHasSizedObjects);
        return storeSizedObjects[element_num];
      }

    public List< BigInteger >  getSizedObjects()
      {
        Debug.Assert(flagHasSizedObjects);
        return storeSizedObjects;
      }

    public bool  hasSizePrompt()
      {
        return flagHasSizePrompt;
      }

    public string  getSizePrompt()
      {
        Debug.Assert(flagHasSizePrompt);
        return storeSizePrompt;
      }

    public bool  hasSizePromptSpoken()
      {
        return flagHasSizePromptSpoken;
      }

    public string  getSizePromptSpoken()
      {
        Debug.Assert(flagHasSizePromptSpoken);
        return storeSizePromptSpoken;
      }

    public bool  hasModifierSets()
      {
        return flagHasModifierSets;
      }

    public int  countOfModifierSets()
      {
        Debug.Assert(flagHasModifierSets);
        return storeModifierSets.Count;
      }

    public RestaurantMenuModifierSetsJSON   elementOfModifierSets(int element_num)
      {
        Debug.Assert(flagHasModifierSets);
        return storeModifierSets[element_num];
      }

    public List< RestaurantMenuModifierSetsJSON  >  getModifierSets()
      {
        Debug.Assert(flagHasModifierSets);
        return storeModifierSets;
      }

    public bool  hasOrderable()
      {
        return flagHasOrderable;
      }

    public bool  getOrderable()
      {
        Debug.Assert(flagHasOrderable);
        return storeOrderable;
      }

    public bool  hasPrice()
      {
        return flagHasPrice;
      }

    public double  getPrice()
      {
        Debug.Assert(flagHasPrice);
        if (textStorePrice != "")
          {
            return Double.Parse(textStorePrice);
          }
        return storePrice;
      }

    public string  getPriceAsText()
      {
        Debug.Assert(flagHasPrice);
        if (textStorePrice == "")
          {
            return Convert.ToString(storePrice);
          }
        else
          {
            return (textStorePrice);
          }
      }


    public virtual int extraRestaurantMenuMenuItemComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRestaurantMenuMenuItemComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRestaurantMenuMenuItemComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRestaurantMenuMenuItemLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setHasComponents(bool new_value)
      {
        flagHasHasComponents = true;
        storeHasComponents = new_value;
      }
    public void unsetHasComponents()
      {
        flagHasHasComponents = false;
      }
    public void setProductId(BigInteger new_value)
      {
        flagHasProductId = true;
        storeProductId = new_value;
      }
    public void unsetProductId()
      {
        flagHasProductId = false;
      }
    public void setRestaurantId(BigInteger new_value)
      {
        flagHasRestaurantId = true;
        storeRestaurantId = new_value;
      }
    public void unsetRestaurantId()
      {
        flagHasRestaurantId = false;
      }
    public void setParentItemId(BigInteger new_value)
      {
        flagHasParentItemId = true;
        storeParentItemId = new_value;
      }
    public void unsetParentItemId()
      {
        flagHasParentItemId = false;
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
    public void setTerrierExpressionPerfect(string new_value)
      {
        flagHasTerrierExpressionPerfect = true;
        storeTerrierExpressionPerfect = new_value;
      }
    public void unsetTerrierExpressionPerfect()
      {
        flagHasTerrierExpressionPerfect = false;
      }
    public void setTerrierExpressionConfusion(string new_value)
      {
        flagHasTerrierExpressionConfusion = true;
        storeTerrierExpressionConfusion = new_value;
      }
    public void unsetTerrierExpressionConfusion()
      {
        flagHasTerrierExpressionConfusion = false;
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
    public void initComponents()
      {
        if (flagHasComponents)
          {
            for (int num3 = 0; num3 < storeComponents.Count; ++num3)
              {
              }
          }
        flagHasComponents = true;
        storeComponents.Clear();
      }
    public void appendComponents(TypeComponentsJSON  to_append)
      {
        if (!flagHasComponents)
          {
            flagHasComponents = true;
            storeComponents.Clear();
          }
        Debug.Assert(flagHasComponents);
        storeComponents.Add(to_append);
      }
    public void unsetComponents()
      {
        if (flagHasComponents)
          {
            for (int num4 = 0; num4 < storeComponents.Count; ++num4)
              {
              }
          }
        flagHasComponents = false;
        storeComponents.Clear();
      }
    public void setItemImage(string new_value)
      {
        flagHasItemImage = true;
        storeItemImage = new_value;
      }
    public void unsetItemImage()
      {
        flagHasItemImage = false;
      }
    public void initComponentOfCombos()
      {
        flagHasComponentOfCombos = true;
        storeComponentOfCombos.Clear();
      }
    public void appendComponentOfCombos(BigInteger to_append)
      {
        if (!flagHasComponentOfCombos)
          {
            flagHasComponentOfCombos = true;
            storeComponentOfCombos.Clear();
          }
        Debug.Assert(flagHasComponentOfCombos);
        storeComponentOfCombos.Add(to_append);
      }
    public void unsetComponentOfCombos()
      {
        flagHasComponentOfCombos = false;
        storeComponentOfCombos.Clear();
      }
    public void setComponentOfComboTerrierExpression(string new_value)
      {
        flagHasComponentOfComboTerrierExpression = true;
        storeComponentOfComboTerrierExpression = new_value;
      }
    public void unsetComponentOfComboTerrierExpression()
      {
        flagHasComponentOfComboTerrierExpression = false;
      }
    public void setItemName(string new_value)
      {
        flagHasItemName = true;
        storeItemName = new_value;
      }
    public void unsetItemName()
      {
        flagHasItemName = false;
      }
    public void setItemNameSpoken(string new_value)
      {
        flagHasItemNameSpoken = true;
        storeItemNameSpoken = new_value;
      }
    public void unsetItemNameSpoken()
      {
        flagHasItemNameSpoken = false;
      }
    public void setDefaultItem(BigInteger new_value)
      {
        flagHasDefaultItem = true;
        storeDefaultItem = new_value;
      }
    public void unsetDefaultItem()
      {
        flagHasDefaultItem = false;
      }
    public void initModifiers()
      {
        flagHasModifiers = true;
        storeModifiers.Clear();
      }
    public void appendModifiers(BigInteger to_append)
      {
        if (!flagHasModifiers)
          {
            flagHasModifiers = true;
            storeModifiers.Clear();
          }
        Debug.Assert(flagHasModifiers);
        storeModifiers.Add(to_append);
      }
    public void unsetModifiers()
      {
        flagHasModifiers = false;
        storeModifiers.Clear();
      }
    public void initPreferredModifiers()
      {
        flagHasPreferredModifiers = true;
        storePreferredModifiers.Clear();
      }
    public void appendPreferredModifiers(BigInteger to_append)
      {
        if (!flagHasPreferredModifiers)
          {
            flagHasPreferredModifiers = true;
            storePreferredModifiers.Clear();
          }
        Debug.Assert(flagHasPreferredModifiers);
        storePreferredModifiers.Add(to_append);
      }
    public void unsetPreferredModifiers()
      {
        flagHasPreferredModifiers = false;
        storePreferredModifiers.Clear();
      }
    public void initCondiments()
      {
        flagHasCondiments = true;
        storeCondiments.Clear();
      }
    public void appendCondiments(BigInteger to_append)
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
        flagHasCondiments = false;
        storeCondiments.Clear();
      }
    public void initSizedObjectTuples()
      {
        if (flagHasSizedObjectTuples)
          {
            for (int num5 = 0; num5 < storeSizedObjectTuples.Count; ++num5)
              {
              }
          }
        flagHasSizedObjectTuples = true;
        storeSizedObjectTuples.Clear();
      }
    public void appendSizedObjectTuples(RestaurantMenuSizedObjectJSON  to_append)
      {
        if (!flagHasSizedObjectTuples)
          {
            flagHasSizedObjectTuples = true;
            storeSizedObjectTuples.Clear();
          }
        Debug.Assert(flagHasSizedObjectTuples);
        storeSizedObjectTuples.Add(to_append);
      }
    public void unsetSizedObjectTuples()
      {
        if (flagHasSizedObjectTuples)
          {
            for (int num6 = 0; num6 < storeSizedObjectTuples.Count; ++num6)
              {
              }
          }
        flagHasSizedObjectTuples = false;
        storeSizedObjectTuples.Clear();
      }
    public void initSizedObjects()
      {
        flagHasSizedObjects = true;
        storeSizedObjects.Clear();
      }
    public void appendSizedObjects(BigInteger to_append)
      {
        if (!flagHasSizedObjects)
          {
            flagHasSizedObjects = true;
            storeSizedObjects.Clear();
          }
        Debug.Assert(flagHasSizedObjects);
        storeSizedObjects.Add(to_append);
      }
    public void unsetSizedObjects()
      {
        flagHasSizedObjects = false;
        storeSizedObjects.Clear();
      }
    public void setSizePrompt(string new_value)
      {
        flagHasSizePrompt = true;
        storeSizePrompt = new_value;
      }
    public void unsetSizePrompt()
      {
        flagHasSizePrompt = false;
      }
    public void setSizePromptSpoken(string new_value)
      {
        flagHasSizePromptSpoken = true;
        storeSizePromptSpoken = new_value;
      }
    public void unsetSizePromptSpoken()
      {
        flagHasSizePromptSpoken = false;
      }
    public void initModifierSets()
      {
        if (flagHasModifierSets)
          {
            for (int num7 = 0; num7 < storeModifierSets.Count; ++num7)
              {
              }
          }
        flagHasModifierSets = true;
        storeModifierSets.Clear();
      }
    public void appendModifierSets(RestaurantMenuModifierSetsJSON  to_append)
      {
        if (!flagHasModifierSets)
          {
            flagHasModifierSets = true;
            storeModifierSets.Clear();
          }
        Debug.Assert(flagHasModifierSets);
        storeModifierSets.Add(to_append);
      }
    public void unsetModifierSets()
      {
        if (flagHasModifierSets)
          {
            for (int num8 = 0; num8 < storeModifierSets.Count; ++num8)
              {
              }
          }
        flagHasModifierSets = false;
        storeModifierSets.Clear();
      }
    public void setOrderable(bool new_value)
      {
        flagHasOrderable = true;
        storeOrderable = new_value;
      }
    public void unsetOrderable()
      {
        flagHasOrderable = false;
      }
    public void setPrice(double new_value)
      {
        flagHasPrice = true;
        storePrice = new_value;
        textStorePrice = "";
      }
    public void setPriceText(string new_value)
      {
        flagHasPrice = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Price of RestaurantMenuMenuItemJSON is not a valid number.");
        textStorePrice = new_value;
      }
    public void unsetPrice()
      {
        flagHasPrice = false;
      }

    public virtual void extraRestaurantMenuMenuItemAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRestaurantMenuMenuItemSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRestaurantMenuMenuItemLookup(key);
        if (old_field == null)
          {
            extraRestaurantMenuMenuItemAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasHasComponents);
        if (flagHasHasComponents)
          {
            handler.start_pair("HasComponents");
            handler.boolean_value(storeHasComponents);
          }
        Debug.Assert(partial_allowed || flagHasProductId);
        if (flagHasProductId)
          {
            handler.start_pair("ProductId");
            handler.number_value(storeProductId);
          }
        Debug.Assert(partial_allowed || flagHasRestaurantId);
        if (flagHasRestaurantId)
          {
            handler.start_pair("RestaurantId");
            handler.number_value(storeRestaurantId);
          }
        if (flagHasParentItemId)
          {
            handler.start_pair("ParentItemId");
            handler.number_value(storeParentItemId);
          }
        if (flagHasSynonyms)
          {
            handler.start_pair("Synonyms");
            Debug.Assert(storeSynonyms.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeSynonyms.Count; ++num1)
              {
                handler.string_value(storeSynonyms[num1]);
              }
            handler.finish_array();
          }
        if (flagHasTerrierExpression)
          {
            handler.start_pair("TerrierExpression");
            handler.string_value(storeTerrierExpression);
          }
        if (flagHasTerrierExpressionPerfect)
          {
            handler.start_pair("TerrierExpressionPerfect");
            handler.string_value(storeTerrierExpressionPerfect);
          }
        if (flagHasTerrierExpressionConfusion)
          {
            handler.start_pair("TerrierExpressionConfusion");
            handler.string_value(storeTerrierExpressionConfusion);
          }
        if (flagHasFlexibleExpressionData)
          {
            handler.start_pair("FlexibleExpressionData");
            Debug.Assert(storeFlexibleExpressionData.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeFlexibleExpressionData.Count; ++num2)
              {
                if (partial_allowed)
                    storeFlexibleExpressionData[num2].write_partial_as_json(handler);
                else
                    storeFlexibleExpressionData[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasComponents)
          {
            handler.start_pair("Components");
            handler.start_array();
            for (int num3 = 0; num3 < storeComponents.Count; ++num3)
              {
                if (partial_allowed)
                    storeComponents[num3].write_partial_as_json(handler);
                else
                    storeComponents[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasItemImage);
        if (flagHasItemImage)
          {
            handler.start_pair("ItemImage");
            handler.string_value(storeItemImage);
          }
        if (flagHasComponentOfCombos)
          {
            handler.start_pair("ComponentOfCombos");
            Debug.Assert(storeComponentOfCombos.Count >= 1);
            handler.start_array();
            for (int num4 = 0; num4 < storeComponentOfCombos.Count; ++num4)
              {
                handler.number_value(storeComponentOfCombos[num4]);
              }
            handler.finish_array();
          }
        if (flagHasComponentOfComboTerrierExpression)
          {
            handler.start_pair("ComponentOfComboTerrierExpression");
            handler.string_value(storeComponentOfComboTerrierExpression);
          }
        Debug.Assert(partial_allowed || flagHasItemName);
        if (flagHasItemName)
          {
            handler.start_pair("ItemName");
            handler.string_value(storeItemName);
          }
        if (flagHasItemNameSpoken)
          {
            handler.start_pair("ItemNameSpoken");
            handler.string_value(storeItemNameSpoken);
          }
        if (flagHasDefaultItem)
          {
            handler.start_pair("DefaultItem");
            handler.number_value(storeDefaultItem);
          }
        if (flagHasModifiers)
          {
            handler.start_pair("Modifiers");
            handler.start_array();
            for (int num5 = 0; num5 < storeModifiers.Count; ++num5)
              {
                handler.number_value(storeModifiers[num5]);
              }
            handler.finish_array();
          }
        if (flagHasPreferredModifiers)
          {
            handler.start_pair("PreferredModifiers");
            handler.start_array();
            for (int num6 = 0; num6 < storePreferredModifiers.Count; ++num6)
              {
                handler.number_value(storePreferredModifiers[num6]);
              }
            handler.finish_array();
          }
        if (flagHasCondiments)
          {
            handler.start_pair("Condiments");
            handler.start_array();
            for (int num7 = 0; num7 < storeCondiments.Count; ++num7)
              {
                handler.number_value(storeCondiments[num7]);
              }
            handler.finish_array();
          }
        if (flagHasSizedObjectTuples)
          {
            handler.start_pair("SizedObjectTuples");
            Debug.Assert(storeSizedObjectTuples.Count >= 1);
            handler.start_array();
            for (int num8 = 0; num8 < storeSizedObjectTuples.Count; ++num8)
              {
                if (partial_allowed)
                    storeSizedObjectTuples[num8].write_partial_as_json(handler);
                else
                    storeSizedObjectTuples[num8].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasSizedObjects)
          {
            handler.start_pair("SizedObjects");
            handler.start_array();
            for (int num9 = 0; num9 < storeSizedObjects.Count; ++num9)
              {
                handler.number_value(storeSizedObjects[num9]);
              }
            handler.finish_array();
          }
        if (flagHasSizePrompt)
          {
            handler.start_pair("SizePrompt");
            handler.string_value(storeSizePrompt);
          }
        if (flagHasSizePromptSpoken)
          {
            handler.start_pair("SizePromptSpoken");
            handler.string_value(storeSizePromptSpoken);
          }
        if (flagHasModifierSets)
          {
            handler.start_pair("ModifierSets");
            handler.start_array();
            for (int num10 = 0; num10 < storeModifierSets.Count; ++num10)
              {
                if (partial_allowed)
                    storeModifierSets[num10].write_partial_as_json(handler);
                else
                    storeModifierSets[num10].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasOrderable)
          {
            handler.start_pair("Orderable");
            handler.boolean_value(storeOrderable);
          }
        if (flagHasPrice)
          {
            handler.start_pair("Price");
            if (textStorePrice != "")
                handler.number_value(textStorePrice);
            else if (((double)(long)storePrice) == storePrice)
                handler.number_value((long)storePrice);
            else
                handler.number_value(storePrice);
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
        if (!(hasHasComponents()))
          {
            return "When parsing the object for %what%, the \"HasComponents\" field was missing.";
          }
        if (!(hasProductId()))
          {
            return "When parsing the object for %what%, the \"ProductId\" field was missing.";
          }
        if (!(hasRestaurantId()))
          {
            return "When parsing the object for %what%, the \"RestaurantId\" field was missing.";
          }
        if (!(hasItemImage()))
          {
            return "When parsing the object for %what%, the \"ItemImage\" field was missing.";
          }
        if (!(hasItemName()))
          {
            return "When parsing the object for %what%, the \"ItemName\" field was missing.";
          }
        return null;
      }

    public static RestaurantMenuMenuItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuMenuItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuMenuItem", ignore_extras);
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
    public static RestaurantMenuMenuItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuMenuItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RestaurantMenuMenuItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuMenuItem", ignore_extras);
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
    public static RestaurantMenuMenuItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RestaurantMenuMenuItemJSON from_text(string text, bool ignore_extras)
      {
        RestaurantMenuMenuItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuMenuItem", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RestaurantMenuMenuItemJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RestaurantMenuMenuItemJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RestaurantMenuMenuItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RestaurantMenuMenuItem", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorHasComponents;
    private class FieldHoldingGeneratorProductId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorProductId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorProductId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorProductId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorProductId fieldGeneratorProductId;
    private class FieldHoldingGeneratorRestaurantId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorRestaurantId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorRestaurantId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorRestaurantId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorRestaurantId fieldGeneratorRestaurantId;
    private class FieldHoldingGeneratorParentItemId : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorParentItemId(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorParentItemId : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorParentItemId(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorParentItemId fieldGeneratorParentItemId;
        private JSONHoldingStringArrayGenerator fieldGeneratorSynonyms;
        private JSONHoldingStringGenerator fieldGeneratorTerrierExpression;
        private JSONHoldingStringGenerator fieldGeneratorTerrierExpressionPerfect;
        private JSONHoldingStringGenerator fieldGeneratorTerrierExpressionConfusion;
        private RestaurantMenuFlexibleExpressionDataJSON.HoldingArrayGenerator fieldGeneratorFlexibleExpressionData;
        private TypeComponentsJSON.HoldingArrayGenerator fieldGeneratorComponents;
        private JSONHoldingStringGenerator fieldGeneratorItemImage;
    private class FieldHoldingGeneratorComponentOfCombos : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorComponentOfCombos(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorComponentOfCombos : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorComponentOfCombos(String what) : base(what)
              {
              }
          };
        private FieldHoldingArrayGeneratorComponentOfCombos fieldGeneratorComponentOfCombos;
        private JSONHoldingStringGenerator fieldGeneratorComponentOfComboTerrierExpression;
        private JSONHoldingStringGenerator fieldGeneratorItemName;
        private JSONHoldingStringGenerator fieldGeneratorItemNameSpoken;
    private class FieldHoldingGeneratorDefaultItem : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorDefaultItem(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorDefaultItem : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorDefaultItem(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorDefaultItem fieldGeneratorDefaultItem;
    private class FieldHoldingGeneratorModifiers : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorModifiers(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorModifiers : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorModifiers(String what) : base(what)
              {
              }
          };
        private FieldHoldingArrayGeneratorModifiers fieldGeneratorModifiers;
    private class FieldHoldingGeneratorPreferredModifiers : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorPreferredModifiers(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorPreferredModifiers : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorPreferredModifiers(String what) : base(what)
              {
              }
          };
        private FieldHoldingArrayGeneratorPreferredModifiers fieldGeneratorPreferredModifiers;
    private class FieldHoldingGeneratorCondiments : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorCondiments(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorCondiments : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorCondiments(String what) : base(what)
              {
              }
          };
        private FieldHoldingArrayGeneratorCondiments fieldGeneratorCondiments;
        private RestaurantMenuSizedObjectJSON.HoldingArrayGenerator fieldGeneratorSizedObjectTuples;
    private class FieldHoldingGeneratorSizedObjects : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorSizedObjects(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorSizedObjects : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorSizedObjects(String what) : base(what)
              {
              }
          };
        private FieldHoldingArrayGeneratorSizedObjects fieldGeneratorSizedObjects;
        private JSONHoldingStringGenerator fieldGeneratorSizePrompt;
        private JSONHoldingStringGenerator fieldGeneratorSizePromptSpoken;
        private RestaurantMenuModifierSetsJSON.HoldingArrayGenerator fieldGeneratorModifierSets;
        private JSONHoldingBooleanGenerator fieldGeneratorOrderable;
        private JSONHoldingNumberTextGenerator fieldGeneratorPrice;
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
            RestaurantMenuMenuItemJSON result = new RestaurantMenuMenuItemJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRestaurantMenuMenuItemAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RestaurantMenuMenuItemJSON result)
          {
            if (fieldGeneratorHasComponents.have_value)
              {
                result.setHasComponents(fieldGeneratorHasComponents.value);
                fieldGeneratorHasComponents.have_value = false;
              }
            else if ((!(result.hasHasComponents())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"HasComponents\" field was missing.");
              }
            if (fieldGeneratorProductId.have_value)
              {
                result.setProductId(fieldGeneratorProductId.value);
                fieldGeneratorProductId.have_value = false;
              }
            else if ((!(result.hasProductId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ProductId\" field was missing.");
              }
            if (fieldGeneratorRestaurantId.have_value)
              {
                result.setRestaurantId(fieldGeneratorRestaurantId.value);
                fieldGeneratorRestaurantId.have_value = false;
              }
            else if ((!(result.hasRestaurantId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RestaurantId\" field was missing.");
              }
            if (fieldGeneratorParentItemId.have_value)
              {
                result.setParentItemId(fieldGeneratorParentItemId.value);
                fieldGeneratorParentItemId.have_value = false;
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
            if (fieldGeneratorTerrierExpressionPerfect.have_value)
              {
                result.setTerrierExpressionPerfect(fieldGeneratorTerrierExpressionPerfect.value);
                fieldGeneratorTerrierExpressionPerfect.have_value = false;
              }
            if (fieldGeneratorTerrierExpressionConfusion.have_value)
              {
                result.setTerrierExpressionConfusion(fieldGeneratorTerrierExpressionConfusion.value);
                fieldGeneratorTerrierExpressionConfusion.have_value = false;
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
            if (fieldGeneratorComponents.have_value)
              {
                result.initComponents();
                int count = fieldGeneratorComponents.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendComponents(fieldGeneratorComponents.value[num]);
                  }
                fieldGeneratorComponents.value.Clear();
                fieldGeneratorComponents.have_value = false;
              }
            if (fieldGeneratorItemImage.have_value)
              {
                result.setItemImage(fieldGeneratorItemImage.value);
                fieldGeneratorItemImage.have_value = false;
              }
            else if ((!(result.hasItemImage())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ItemImage\" field was missing.");
              }
            if (fieldGeneratorComponentOfCombos.have_value)
              {
                result.initComponentOfCombos();
                int count = fieldGeneratorComponentOfCombos.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendComponentOfCombos(fieldGeneratorComponentOfCombos.value[num]);
                  }
                fieldGeneratorComponentOfCombos.value.Clear();
                fieldGeneratorComponentOfCombos.have_value = false;
              }
            if (fieldGeneratorComponentOfComboTerrierExpression.have_value)
              {
                result.setComponentOfComboTerrierExpression(fieldGeneratorComponentOfComboTerrierExpression.value);
                fieldGeneratorComponentOfComboTerrierExpression.have_value = false;
              }
            if (fieldGeneratorItemName.have_value)
              {
                result.setItemName(fieldGeneratorItemName.value);
                fieldGeneratorItemName.have_value = false;
              }
            else if ((!(result.hasItemName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ItemName\" field was missing.");
              }
            if (fieldGeneratorItemNameSpoken.have_value)
              {
                result.setItemNameSpoken(fieldGeneratorItemNameSpoken.value);
                fieldGeneratorItemNameSpoken.have_value = false;
              }
            if (fieldGeneratorDefaultItem.have_value)
              {
                result.setDefaultItem(fieldGeneratorDefaultItem.value);
                fieldGeneratorDefaultItem.have_value = false;
              }
            if (fieldGeneratorModifiers.have_value)
              {
                result.initModifiers();
                int count = fieldGeneratorModifiers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendModifiers(fieldGeneratorModifiers.value[num]);
                  }
                fieldGeneratorModifiers.value.Clear();
                fieldGeneratorModifiers.have_value = false;
              }
            if (fieldGeneratorPreferredModifiers.have_value)
              {
                result.initPreferredModifiers();
                int count = fieldGeneratorPreferredModifiers.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPreferredModifiers(fieldGeneratorPreferredModifiers.value[num]);
                  }
                fieldGeneratorPreferredModifiers.value.Clear();
                fieldGeneratorPreferredModifiers.have_value = false;
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
            if (fieldGeneratorSizedObjectTuples.have_value)
              {
                result.initSizedObjectTuples();
                int count = fieldGeneratorSizedObjectTuples.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSizedObjectTuples(fieldGeneratorSizedObjectTuples.value[num]);
                  }
                fieldGeneratorSizedObjectTuples.value.Clear();
                fieldGeneratorSizedObjectTuples.have_value = false;
              }
            if (fieldGeneratorSizedObjects.have_value)
              {
                result.initSizedObjects();
                int count = fieldGeneratorSizedObjects.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSizedObjects(fieldGeneratorSizedObjects.value[num]);
                  }
                fieldGeneratorSizedObjects.value.Clear();
                fieldGeneratorSizedObjects.have_value = false;
              }
            if (fieldGeneratorSizePrompt.have_value)
              {
                result.setSizePrompt(fieldGeneratorSizePrompt.value);
                fieldGeneratorSizePrompt.have_value = false;
              }
            if (fieldGeneratorSizePromptSpoken.have_value)
              {
                result.setSizePromptSpoken(fieldGeneratorSizePromptSpoken.value);
                fieldGeneratorSizePromptSpoken.have_value = false;
              }
            if (fieldGeneratorModifierSets.have_value)
              {
                result.initModifierSets();
                int count = fieldGeneratorModifierSets.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendModifierSets(fieldGeneratorModifierSets.value[num]);
                  }
                fieldGeneratorModifierSets.value.Clear();
                fieldGeneratorModifierSets.have_value = false;
              }
            if (fieldGeneratorOrderable.have_value)
              {
                result.setOrderable(fieldGeneratorOrderable.value);
                fieldGeneratorOrderable.have_value = false;
              }
            if (fieldGeneratorPrice.have_value)
              {
                result.setPriceText(fieldGeneratorPrice.value);
                fieldGeneratorPrice.have_value = false;
              }
          }
        protected abstract void handle_result(RestaurantMenuMenuItemJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "o", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'm':
                                if (String.Compare(field_name, 3, "ponent", 0, 6, false) == 0)
                                  {
                                    switch (field_name[9])
                                      {
                                        case 'O':
                                            if (String.Compare(field_name, 10, "fCombo", 0, 6, false) == 0)
                                              {
                                                switch (field_name[16])
                                                  {
                                                    case 'T':
                                                        if ((String.Compare(field_name, 17, "errierExpression", 0, 16, false) == 0) && (field_name.Length == 33))
                                                            return fieldGeneratorComponentOfComboTerrierExpression;
                                                        break;
                                                    case 's':
                                                        if (field_name.Length == 17)
                                                            return fieldGeneratorComponentOfCombos;
                                                        break;
                                                    default:
                                                        break;
                                                  }
                                              }
                                            break;
                                        case 's':
                                            if (field_name.Length == 10)
                                                return fieldGeneratorComponents;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'n':
                                if ((String.Compare(field_name, 3, "diments", 0, 7, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorCondiments;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "efaultItem", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorDefaultItem;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "lexibleExpressionData", 0, 21, false) == 0) && (field_name.Length == 22))
                        return fieldGeneratorFlexibleExpressionData;
                    break;
                case 'H':
                    if ((String.Compare(field_name, 1, "asComponents", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorHasComponents;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "tem", 0, 3, false) == 0)
                      {
                        switch (field_name[4])
                          {
                            case 'I':
                                if ((String.Compare(field_name, 5, "mage", 0, 4, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorItemImage;
                                break;
                            case 'N':
                                if (String.Compare(field_name, 5, "ame", 0, 3, false) == 0)
                                  {
                                    if (field_name.Length == 8)
                                      {
                                        return fieldGeneratorItemName;
                                      }
                                    switch (field_name[8])
                                      {
                                        case 'S':
                                            if ((String.Compare(field_name, 9, "poken", 0, 5, false) == 0) && (field_name.Length == 14))
                                                return fieldGeneratorItemNameSpoken;
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
                case 'M':
                    if (String.Compare(field_name, 1, "odifier", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 9, "ets", 0, 3, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorModifierSets;
                                break;
                            case 's':
                                if (field_name.Length == 9)
                                    return fieldGeneratorModifiers;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'O':
                    if ((String.Compare(field_name, 1, "rderable", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorOrderable;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "rentItemId", 0, 10, false) == 0) && (field_name.Length == 12))
                                return fieldGeneratorParentItemId;
                            break;
                        case 'r':
                            switch (field_name[2])
                              {
                                case 'e':
                                    if ((String.Compare(field_name, 3, "ferredModifiers", 0, 15, false) == 0) && (field_name.Length == 18))
                                        return fieldGeneratorPreferredModifiers;
                                    break;
                                case 'i':
                                    if ((String.Compare(field_name, 3, "ce", 0, 2, false) == 0) && (field_name.Length == 5))
                                        return fieldGeneratorPrice;
                                    break;
                                case 'o':
                                    if ((String.Compare(field_name, 3, "ductId", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorProductId;
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
                    if ((String.Compare(field_name, 1, "estaurantId", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorRestaurantId;
                    break;
                case 'S':
                    switch (field_name[1])
                      {
                        case 'i':
                            if (String.Compare(field_name, 2, "ze", 0, 2, false) == 0)
                              {
                                switch (field_name[4])
                                  {
                                    case 'P':
                                        if (String.Compare(field_name, 5, "rompt", 0, 5, false) == 0)
                                          {
                                            if (field_name.Length == 10)
                                              {
                                                return fieldGeneratorSizePrompt;
                                              }
                                            switch (field_name[10])
                                              {
                                                case 'S':
                                                    if ((String.Compare(field_name, 11, "poken", 0, 5, false) == 0) && (field_name.Length == 16))
                                                        return fieldGeneratorSizePromptSpoken;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'd':
                                        if (String.Compare(field_name, 5, "Object", 0, 6, false) == 0)
                                          {
                                            switch (field_name[11])
                                              {
                                                case 'T':
                                                    if ((String.Compare(field_name, 12, "uples", 0, 5, false) == 0) && (field_name.Length == 17))
                                                        return fieldGeneratorSizedObjectTuples;
                                                    break;
                                                case 's':
                                                    if (field_name.Length == 12)
                                                        return fieldGeneratorSizedObjects;
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
                        case 'y':
                            if ((String.Compare(field_name, 2, "nonyms", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorSynonyms;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "errierExpression", 0, 16, false) == 0)
                      {
                        if (field_name.Length == 17)
                          {
                            return fieldGeneratorTerrierExpression;
                          }
                        switch (field_name[17])
                          {
                            case 'C':
                                if ((String.Compare(field_name, 18, "onfusion", 0, 8, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorTerrierExpressionConfusion;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 18, "erfect", 0, 6, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorTerrierExpressionPerfect;
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
            fieldGeneratorHasComponents = new JSONHoldingBooleanGenerator("field \"HasComponents\" of the RestaurantMenuMenuItem class");
            fieldGeneratorProductId = new FieldHoldingGeneratorProductId("field \"ProductId\" of the RestaurantMenuMenuItem class");
            fieldGeneratorRestaurantId = new FieldHoldingGeneratorRestaurantId("field \"RestaurantId\" of the RestaurantMenuMenuItem class");
            fieldGeneratorParentItemId = new FieldHoldingGeneratorParentItemId("field \"ParentItemId\" of the RestaurantMenuMenuItem class");
            fieldGeneratorSynonyms = new JSONHoldingStringArrayGenerator("field \"Synonyms\" of the RestaurantMenuMenuItem class");
            fieldGeneratorTerrierExpression = new JSONHoldingStringGenerator("field \"TerrierExpression\" of the RestaurantMenuMenuItem class");
            fieldGeneratorTerrierExpressionPerfect = new JSONHoldingStringGenerator("field \"TerrierExpressionPerfect\" of the RestaurantMenuMenuItem class");
            fieldGeneratorTerrierExpressionConfusion = new JSONHoldingStringGenerator("field \"TerrierExpressionConfusion\" of the RestaurantMenuMenuItem class");
            fieldGeneratorFlexibleExpressionData = new RestaurantMenuFlexibleExpressionDataJSON.HoldingArrayGenerator("field \"FlexibleExpressionData\" of the RestaurantMenuMenuItem class", ignore_extras);
            fieldGeneratorComponents = new TypeComponentsJSON.HoldingArrayGenerator("field \"Components\" of the RestaurantMenuMenuItem class", ignore_extras);
            fieldGeneratorItemImage = new JSONHoldingStringGenerator("field \"ItemImage\" of the RestaurantMenuMenuItem class");
            fieldGeneratorComponentOfCombos = new FieldHoldingArrayGeneratorComponentOfCombos("field \"ComponentOfCombos\" of the RestaurantMenuMenuItem class");
            fieldGeneratorComponentOfComboTerrierExpression = new JSONHoldingStringGenerator("field \"ComponentOfComboTerrierExpression\" of the RestaurantMenuMenuItem class");
            fieldGeneratorItemName = new JSONHoldingStringGenerator("field \"ItemName\" of the RestaurantMenuMenuItem class");
            fieldGeneratorItemNameSpoken = new JSONHoldingStringGenerator("field \"ItemNameSpoken\" of the RestaurantMenuMenuItem class");
            fieldGeneratorDefaultItem = new FieldHoldingGeneratorDefaultItem("field \"DefaultItem\" of the RestaurantMenuMenuItem class");
            fieldGeneratorModifiers = new FieldHoldingArrayGeneratorModifiers("field \"Modifiers\" of the RestaurantMenuMenuItem class");
            fieldGeneratorPreferredModifiers = new FieldHoldingArrayGeneratorPreferredModifiers("field \"PreferredModifiers\" of the RestaurantMenuMenuItem class");
            fieldGeneratorCondiments = new FieldHoldingArrayGeneratorCondiments("field \"Condiments\" of the RestaurantMenuMenuItem class");
            fieldGeneratorSizedObjectTuples = new RestaurantMenuSizedObjectJSON.HoldingArrayGenerator("field \"SizedObjectTuples\" of the RestaurantMenuMenuItem class", ignore_extras);
            fieldGeneratorSizedObjects = new FieldHoldingArrayGeneratorSizedObjects("field \"SizedObjects\" of the RestaurantMenuMenuItem class");
            fieldGeneratorSizePrompt = new JSONHoldingStringGenerator("field \"SizePrompt\" of the RestaurantMenuMenuItem class");
            fieldGeneratorSizePromptSpoken = new JSONHoldingStringGenerator("field \"SizePromptSpoken\" of the RestaurantMenuMenuItem class");
            fieldGeneratorModifierSets = new RestaurantMenuModifierSetsJSON.HoldingArrayGenerator("field \"ModifierSets\" of the RestaurantMenuMenuItem class", ignore_extras);
            fieldGeneratorOrderable = new JSONHoldingBooleanGenerator("field \"Orderable\" of the RestaurantMenuMenuItem class");
            fieldGeneratorPrice = new JSONHoldingNumberTextGenerator("field \"Price\" of the RestaurantMenuMenuItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RestaurantMenuMenuItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorHasComponents = new JSONHoldingBooleanGenerator("field \"HasComponents\" of the RestaurantMenuMenuItem class");
            fieldGeneratorProductId = new FieldHoldingGeneratorProductId("field \"ProductId\" of the RestaurantMenuMenuItem class");
            fieldGeneratorRestaurantId = new FieldHoldingGeneratorRestaurantId("field \"RestaurantId\" of the RestaurantMenuMenuItem class");
            fieldGeneratorParentItemId = new FieldHoldingGeneratorParentItemId("field \"ParentItemId\" of the RestaurantMenuMenuItem class");
            fieldGeneratorSynonyms = new JSONHoldingStringArrayGenerator("field \"Synonyms\" of the RestaurantMenuMenuItem class");
            fieldGeneratorTerrierExpression = new JSONHoldingStringGenerator("field \"TerrierExpression\" of the RestaurantMenuMenuItem class");
            fieldGeneratorTerrierExpressionPerfect = new JSONHoldingStringGenerator("field \"TerrierExpressionPerfect\" of the RestaurantMenuMenuItem class");
            fieldGeneratorTerrierExpressionConfusion = new JSONHoldingStringGenerator("field \"TerrierExpressionConfusion\" of the RestaurantMenuMenuItem class");
            fieldGeneratorFlexibleExpressionData = new RestaurantMenuFlexibleExpressionDataJSON.HoldingArrayGenerator("field \"FlexibleExpressionData\" of the RestaurantMenuMenuItem class", false);
            fieldGeneratorComponents = new TypeComponentsJSON.HoldingArrayGenerator("field \"Components\" of the RestaurantMenuMenuItem class", false);
            fieldGeneratorItemImage = new JSONHoldingStringGenerator("field \"ItemImage\" of the RestaurantMenuMenuItem class");
            fieldGeneratorComponentOfCombos = new FieldHoldingArrayGeneratorComponentOfCombos("field \"ComponentOfCombos\" of the RestaurantMenuMenuItem class");
            fieldGeneratorComponentOfComboTerrierExpression = new JSONHoldingStringGenerator("field \"ComponentOfComboTerrierExpression\" of the RestaurantMenuMenuItem class");
            fieldGeneratorItemName = new JSONHoldingStringGenerator("field \"ItemName\" of the RestaurantMenuMenuItem class");
            fieldGeneratorItemNameSpoken = new JSONHoldingStringGenerator("field \"ItemNameSpoken\" of the RestaurantMenuMenuItem class");
            fieldGeneratorDefaultItem = new FieldHoldingGeneratorDefaultItem("field \"DefaultItem\" of the RestaurantMenuMenuItem class");
            fieldGeneratorModifiers = new FieldHoldingArrayGeneratorModifiers("field \"Modifiers\" of the RestaurantMenuMenuItem class");
            fieldGeneratorPreferredModifiers = new FieldHoldingArrayGeneratorPreferredModifiers("field \"PreferredModifiers\" of the RestaurantMenuMenuItem class");
            fieldGeneratorCondiments = new FieldHoldingArrayGeneratorCondiments("field \"Condiments\" of the RestaurantMenuMenuItem class");
            fieldGeneratorSizedObjectTuples = new RestaurantMenuSizedObjectJSON.HoldingArrayGenerator("field \"SizedObjectTuples\" of the RestaurantMenuMenuItem class", false);
            fieldGeneratorSizedObjects = new FieldHoldingArrayGeneratorSizedObjects("field \"SizedObjects\" of the RestaurantMenuMenuItem class");
            fieldGeneratorSizePrompt = new JSONHoldingStringGenerator("field \"SizePrompt\" of the RestaurantMenuMenuItem class");
            fieldGeneratorSizePromptSpoken = new JSONHoldingStringGenerator("field \"SizePromptSpoken\" of the RestaurantMenuMenuItem class");
            fieldGeneratorModifierSets = new RestaurantMenuModifierSetsJSON.HoldingArrayGenerator("field \"ModifierSets\" of the RestaurantMenuMenuItem class", false);
            fieldGeneratorOrderable = new JSONHoldingBooleanGenerator("field \"Orderable\" of the RestaurantMenuMenuItem class");
            fieldGeneratorPrice = new JSONHoldingNumberTextGenerator("field \"Price\" of the RestaurantMenuMenuItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RestaurantMenuMenuItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorHasComponents.reset();
            fieldGeneratorProductId.reset();
            fieldGeneratorRestaurantId.reset();
            fieldGeneratorParentItemId.reset();
            fieldGeneratorSynonyms.reset();
            fieldGeneratorTerrierExpression.reset();
            fieldGeneratorTerrierExpressionPerfect.reset();
            fieldGeneratorTerrierExpressionConfusion.reset();
            fieldGeneratorFlexibleExpressionData.reset();
            fieldGeneratorComponents.reset();
            fieldGeneratorItemImage.reset();
            fieldGeneratorComponentOfCombos.reset();
            fieldGeneratorComponentOfComboTerrierExpression.reset();
            fieldGeneratorItemName.reset();
            fieldGeneratorItemNameSpoken.reset();
            fieldGeneratorDefaultItem.reset();
            fieldGeneratorModifiers.reset();
            fieldGeneratorPreferredModifiers.reset();
            fieldGeneratorCondiments.reset();
            fieldGeneratorSizedObjectTuples.reset();
            fieldGeneratorSizedObjects.reset();
            fieldGeneratorSizePrompt.reset();
            fieldGeneratorSizePromptSpoken.reset();
            fieldGeneratorModifierSets.reset();
            fieldGeneratorOrderable.reset();
            fieldGeneratorPrice.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorFlexibleExpressionData.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorComponents.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSizedObjectTuples.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorModifierSets.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorFlexibleExpressionData.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorComponents.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSizedObjectTuples.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorModifierSets.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RestaurantMenuMenuItemJSON  result)
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
        public RestaurantMenuMenuItemJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RestaurantMenuMenuItemJSON  result)
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
    protected virtual void handle_result(List<RestaurantMenuMenuItemJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RestaurantMenuMenuItemJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RestaurantMenuMenuItemJSON>();
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
    public List<RestaurantMenuMenuItemJSON> value;
  };
  };
