/* file "UberRequestsSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UberRequestsSpecJSON : UberSpecJSON
  {
    public enum TypeNewStates
      {
        NewStates_select_pick_up_location,
        NewStates_select_drop_off_location,
        NewStates_select_uber_product,
        NewStates_select_uber_product_id
      };

    public static TypeNewStates  stringToNewStates(string chars)
      {
        if (String.Compare(chars, 0, "select_", 0, 7, false) == 0)
          {
            switch (chars[7])
              {
                case 'd':
                    if ((String.Compare(chars, 8, "rop_off_location", 0, 16, false) == 0) && (chars.Length == 24))
                        return TypeNewStates.NewStates_select_drop_off_location;
                    break;
                case 'p':
                    if ((String.Compare(chars, 8, "ick_up_location", 0, 15, false) == 0) && (chars.Length == 23))
                        return TypeNewStates.NewStates_select_pick_up_location;
                    break;
                case 'u':
                    if (String.Compare(chars, 8, "ber_product", 0, 11, false) == 0)
                      {
                        if (chars.Length == 19)
                          {
                            return TypeNewStates.NewStates_select_uber_product;
                          }
                        switch (chars[19])
                          {
                            case '_':
                                if ((String.Compare(chars, 20, "id", 0, 2, false) == 0) && (chars.Length == 22))
                                    return TypeNewStates.NewStates_select_uber_product_id;
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
        throw new Exception("The value for field `NewStates' is not one of the legal values.");
      }

    public static string  stringFromNewStates(TypeNewStates the_enum)
      {
        switch (the_enum)
          {
            case TypeNewStates.NewStates_select_pick_up_location:
                return "select_pick_up_location";
            case TypeNewStates.NewStates_select_drop_off_location:
                return "select_drop_off_location";
            case TypeNewStates.NewStates_select_uber_product:
                return "select_uber_product";
            case TypeNewStates.NewStates_select_uber_product_id:
                return "select_uber_product_id";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasIsCancelled;
    private bool storeIsCancelled;
    private bool flagHasIsConfirmed;
    private bool storeIsConfirmed;
    private bool flagHasIsNotUnderstood;
    private bool storeIsNotUnderstood;
    private bool flagHasIsRedirectOnConfirmation;
    private bool storeIsRedirectOnConfirmation;
    private bool flagHasIsSurgeConfirmed;
    private bool storeIsSurgeConfirmed;
    private bool flagHasSurgeConfirmationId;
    private string storeSurgeConfirmationId;
    private bool flagHasPreferredProduct;
    private string storePreferredProduct;
    private bool flagHasUberProductId;
    private string storeUberProductId;
    private bool flagHasPickupLocation;
    private MapLocationJSON  storePickupLocation;
    private bool flagHasDropoffLocation;
    private MapLocationJSON  storeDropoffLocation;
    private bool flagHasPassengerCount;
    private BigInteger storePassengerCount;
    private bool flagHasNewStates;
    private List< TypeNewStates > storeNewStates;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraIsCancelledToJSON()
      {
        JSONValue generated_boolean_IsCancelled = (storeIsCancelled ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsCancelled;
      }

    private JSONValue  extraIsConfirmedToJSON()
      {
        JSONValue generated_boolean_IsConfirmed = (storeIsConfirmed ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsConfirmed;
      }

    private JSONValue  extraIsNotUnderstoodToJSON()
      {
        JSONValue generated_boolean_IsNotUnderstood = (storeIsNotUnderstood ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsNotUnderstood;
      }

    private JSONValue  extraIsRedirectOnConfirmationToJSON()
      {
        JSONValue generated_boolean_IsRedirectOnConfirmation = (storeIsRedirectOnConfirmation ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsRedirectOnConfirmation;
      }

    private JSONValue  extraIsSurgeConfirmedToJSON()
      {
        JSONValue generated_boolean_IsSurgeConfirmed = (storeIsSurgeConfirmed ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IsSurgeConfirmed;
      }

    private JSONValue  extraSurgeConfirmationIdToJSON()
      {
        JSONStringValue generated_string_SurgeConfirmationId = new JSONStringValue(storeSurgeConfirmationId);
        return generated_string_SurgeConfirmationId;
      }

    private JSONValue  extraPreferredProductToJSON()
      {
        JSONStringValue generated_string_PreferredProduct = new JSONStringValue(storePreferredProduct);
        return generated_string_PreferredProduct;
      }

    private JSONValue  extraUberProductIdToJSON()
      {
        JSONStringValue generated_string_UberProductId = new JSONStringValue(storeUberProductId);
        return generated_string_UberProductId;
      }

    private JSONValue  extraPickupLocationToJSON()
      {
        JSONValueHandler handler_PickupLocation = new JSONValueHandler();
        storePickupLocation.write_as_json(handler_PickupLocation);
        return handler_PickupLocation.result;
      }

    private JSONValue  extraDropoffLocationToJSON()
      {
        JSONValueHandler handler_DropoffLocation = new JSONValueHandler();
        storeDropoffLocation.write_as_json(handler_DropoffLocation);
        return handler_DropoffLocation.result;
      }

    private JSONValue  extraPassengerCountToJSON()
      {
        JSONIntegerValue generated_integer_PassengerCount = new JSONIntegerValue(storePassengerCount);
        return generated_integer_PassengerCount;
      }

    private JSONValue  extraNewStatesToJSON()
      {
        JSONArrayValue generated_array_1_NewStates = new JSONArrayValue();
        for (int num1 = 0; num1 < storeNewStates.Count; ++num1)
          {
            JSONStringValue generated_string_NewStates;
            switch (storeNewStates[num1])
              {
                case TypeNewStates.NewStates_select_pick_up_location:
                    generated_string_NewStates = new JSONStringValue("select_pick_up_location");
                    break;
                case TypeNewStates.NewStates_select_drop_off_location:
                    generated_string_NewStates = new JSONStringValue("select_drop_off_location");
                    break;
                case TypeNewStates.NewStates_select_uber_product:
                    generated_string_NewStates = new JSONStringValue("select_uber_product");
                    break;
                case TypeNewStates.NewStates_select_uber_product_id:
                    generated_string_NewStates = new JSONStringValue("select_uber_product_id");
                    break;
                default:
                    Debug.Assert(false);
                    generated_string_NewStates = null;
                    break;
              }
            generated_array_1_NewStates.appendComponent(generated_string_NewStates);
          }
        return generated_array_1_NewStates;
      }


    private void  fromJSONIsCancelled(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsCancelled of UberRequestsSpecJSON is not true for false.");
              }
          }
        setIsCancelled(the_bool);
      }


    private void  fromJSONIsConfirmed(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsConfirmed of UberRequestsSpecJSON is not true for false.");
              }
          }
        setIsConfirmed(the_bool);
      }


    private void  fromJSONIsNotUnderstood(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsNotUnderstood of UberRequestsSpecJSON is not true for false.");
              }
          }
        setIsNotUnderstood(the_bool);
      }


    private void  fromJSONIsRedirectOnConfirmation(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsRedirectOnConfirmation of UberRequestsSpecJSON is not true for false.");
              }
          }
        setIsRedirectOnConfirmation(the_bool);
      }


    private void  fromJSONIsSurgeConfirmed(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IsSurgeConfirmed of UberRequestsSpecJSON is not true for false.");
              }
          }
        setIsSurgeConfirmed(the_bool);
      }


    private void  fromJSONSurgeConfirmationId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SurgeConfirmationId of UberRequestsSpecJSON is not a string.");
        setSurgeConfirmationId(json_string.getData());
      }


    private void  fromJSONPreferredProduct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PreferredProduct of UberRequestsSpecJSON is not a string.");
        setPreferredProduct(json_string.getData());
      }


    private void  fromJSONUberProductId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UberProductId of UberRequestsSpecJSON is not a string.");
        setUberProductId(json_string.getData());
      }


    private void  fromJSONPickupLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setPickupLocation(convert_classy);
      }


    private void  fromJSONDropoffLocation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setDropoffLocation(convert_classy);
      }


    private void  fromJSONPassengerCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field PassengerCount of UberRequestsSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PassengerCount of UberRequestsSpecJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPassengerCount(extracted_integer);
      }


    private void  fromJSONNewStates(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field NewStates of UberRequestsSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TypeNewStates > vector_NewStates1 = new List< TypeNewStates >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field NewStates of UberRequestsSpecJSON is not a string.");
            TypeNewStates the_enum;
            if (String.Compare(json_string.getData(), 0, "select_", 0, 7, false) == 0)
              {
                switch (json_string.getData()[7])
                  {
                    case 'd':
                        if ((String.Compare(json_string.getData(), 8, "rop_off_location", 0, 16, false) == 0) && (json_string.getData().Length == 24))
                              {
                                the_enum = TypeNewStates.NewStates_select_drop_off_location;
                                goto enum_is_done;
                              }
                        break;
                    case 'p':
                        if ((String.Compare(json_string.getData(), 8, "ick_up_location", 0, 15, false) == 0) && (json_string.getData().Length == 23))
                              {
                                the_enum = TypeNewStates.NewStates_select_pick_up_location;
                                goto enum_is_done;
                              }
                        break;
                    case 'u':
                        if (String.Compare(json_string.getData(), 8, "ber_product", 0, 11, false) == 0)
                          {
                            if (json_string.getData().Length == 19)
                              {
                                  {
                                    the_enum = TypeNewStates.NewStates_select_uber_product;
                                    goto enum_is_done;
                                  }
                              }
                            switch (json_string.getData()[19])
                              {
                                case '_':
                                    if ((String.Compare(json_string.getData(), 20, "id", 0, 2, false) == 0) && (json_string.getData().Length == 22))
                                          {
                                            the_enum = TypeNewStates.NewStates_select_uber_product_id;
                                            goto enum_is_done;
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
              }
            throw new Exception("The value for an element of field NewStates of UberRequestsSpecJSON is not one of the legal strings.");
          enum_is_done:;
            vector_NewStates1.Add(the_enum);
          }
        initNewStates();
        for (int num1 = 0; num1 < vector_NewStates1.Count; ++num1)
            appendNewStates(vector_NewStates1[num1]);
        for (int num1 = 0; num1 < vector_NewStates1.Count; ++num1)
          {
          }
      }


    public UberRequestsSpecJSON()
      {
        flagHasIsCancelled = false;
        flagHasIsConfirmed = false;
        flagHasIsNotUnderstood = false;
        flagHasIsRedirectOnConfirmation = false;
        flagHasIsSurgeConfirmed = false;
        flagHasSurgeConfirmationId = false;
        flagHasPreferredProduct = false;
        flagHasUberProductId = false;
        flagHasPickupLocation = false;
        flagHasDropoffLocation = false;
        flagHasPassengerCount = false;
        flagHasNewStates = false;
        storeNewStates = new List< TypeNewStates >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUberSpecKind()
      {
        return "UberRequestsSpec";
      }

    public bool  hasIsCancelled()
      {
        return flagHasIsCancelled;
      }

    public bool  getIsCancelled()
      {
        Debug.Assert(flagHasIsCancelled);
        return storeIsCancelled;
      }

    public bool  hasIsConfirmed()
      {
        return flagHasIsConfirmed;
      }

    public bool  getIsConfirmed()
      {
        Debug.Assert(flagHasIsConfirmed);
        return storeIsConfirmed;
      }

    public bool  hasIsNotUnderstood()
      {
        return flagHasIsNotUnderstood;
      }

    public bool  getIsNotUnderstood()
      {
        Debug.Assert(flagHasIsNotUnderstood);
        return storeIsNotUnderstood;
      }

    public bool  hasIsRedirectOnConfirmation()
      {
        return flagHasIsRedirectOnConfirmation;
      }

    public bool  getIsRedirectOnConfirmation()
      {
        Debug.Assert(flagHasIsRedirectOnConfirmation);
        return storeIsRedirectOnConfirmation;
      }

    public bool  hasIsSurgeConfirmed()
      {
        return flagHasIsSurgeConfirmed;
      }

    public bool  getIsSurgeConfirmed()
      {
        Debug.Assert(flagHasIsSurgeConfirmed);
        return storeIsSurgeConfirmed;
      }

    public bool  hasSurgeConfirmationId()
      {
        return flagHasSurgeConfirmationId;
      }

    public string  getSurgeConfirmationId()
      {
        Debug.Assert(flagHasSurgeConfirmationId);
        return storeSurgeConfirmationId;
      }

    public bool  hasPreferredProduct()
      {
        return flagHasPreferredProduct;
      }

    public string  getPreferredProduct()
      {
        Debug.Assert(flagHasPreferredProduct);
        return storePreferredProduct;
      }

    public bool  hasUberProductId()
      {
        return flagHasUberProductId;
      }

    public string  getUberProductId()
      {
        Debug.Assert(flagHasUberProductId);
        return storeUberProductId;
      }

    public bool  hasPickupLocation()
      {
        return flagHasPickupLocation;
      }

    public MapLocationJSON   getPickupLocation()
      {
        Debug.Assert(flagHasPickupLocation);
        return storePickupLocation;
      }

    public bool  hasDropoffLocation()
      {
        return flagHasDropoffLocation;
      }

    public MapLocationJSON   getDropoffLocation()
      {
        Debug.Assert(flagHasDropoffLocation);
        return storeDropoffLocation;
      }

    public bool  hasPassengerCount()
      {
        return flagHasPassengerCount;
      }

    public BigInteger  getPassengerCount()
      {
        Debug.Assert(flagHasPassengerCount);
        return storePassengerCount;
      }

    public bool  hasNewStates()
      {
        return flagHasNewStates;
      }

    public int  countOfNewStates()
      {
        Debug.Assert(flagHasNewStates);
        return storeNewStates.Count;
      }

    public TypeNewStates  elementOfNewStates(int element_num)
      {
        Debug.Assert(flagHasNewStates);
        return storeNewStates[element_num];
      }

    public List< TypeNewStates >  getNewStates()
      {
        Debug.Assert(flagHasNewStates);
        return storeNewStates;
      }


    public virtual int extraUberRequestsSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberRequestsSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberRequestsSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberRequestsSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUberSpecComponentCount()
      {
        int result = 0;
        if (flagHasIsCancelled)
            ++result;
        if (flagHasIsConfirmed)
            ++result;
        if (flagHasIsNotUnderstood)
            ++result;
        if (flagHasIsRedirectOnConfirmation)
            ++result;
        if (flagHasIsSurgeConfirmed)
            ++result;
        if (flagHasSurgeConfirmationId)
            ++result;
        if (flagHasPreferredProduct)
            ++result;
        if (flagHasUberProductId)
            ++result;
        if (flagHasPickupLocation)
            ++result;
        if (flagHasDropoffLocation)
            ++result;
        if (flagHasPassengerCount)
            ++result;
        if (flagHasNewStates)
            ++result;
        result += extraUberRequestsSpecComponentCount();
        return result;
      }
    public override string extraUberSpecComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasIsCancelled)
          {
            if (remainder == 0)
                return "IsCancelled";
            --remainder;
          }
        if (flagHasIsConfirmed)
          {
            if (remainder == 0)
                return "IsConfirmed";
            --remainder;
          }
        if (flagHasIsNotUnderstood)
          {
            if (remainder == 0)
                return "IsNotUnderstood";
            --remainder;
          }
        if (flagHasIsRedirectOnConfirmation)
          {
            if (remainder == 0)
                return "IsRedirectOnConfirmation";
            --remainder;
          }
        if (flagHasIsSurgeConfirmed)
          {
            if (remainder == 0)
                return "IsSurgeConfirmed";
            --remainder;
          }
        if (flagHasSurgeConfirmationId)
          {
            if (remainder == 0)
                return "SurgeConfirmationId";
            --remainder;
          }
        if (flagHasPreferredProduct)
          {
            if (remainder == 0)
                return "PreferredProduct";
            --remainder;
          }
        if (flagHasUberProductId)
          {
            if (remainder == 0)
                return "UberProductId";
            --remainder;
          }
        if (flagHasPickupLocation)
          {
            if (remainder == 0)
                return "PickupLocation";
            --remainder;
          }
        if (flagHasDropoffLocation)
          {
            if (remainder == 0)
                return "DropoffLocation";
            --remainder;
          }
        if (flagHasPassengerCount)
          {
            if (remainder == 0)
                return "PassengerCount";
            --remainder;
          }
        if (flagHasNewStates)
          {
            if (remainder == 0)
                return "NewStates";
            --remainder;
          }
        return extraUberRequestsSpecComponentKey(remainder);
      }
    public override JSONValue extraUberSpecComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasIsCancelled)
          {
            if (remainder == 0)
                return extraIsCancelledToJSON();
            --remainder;
          }
        if (flagHasIsConfirmed)
          {
            if (remainder == 0)
                return extraIsConfirmedToJSON();
            --remainder;
          }
        if (flagHasIsNotUnderstood)
          {
            if (remainder == 0)
                return extraIsNotUnderstoodToJSON();
            --remainder;
          }
        if (flagHasIsRedirectOnConfirmation)
          {
            if (remainder == 0)
                return extraIsRedirectOnConfirmationToJSON();
            --remainder;
          }
        if (flagHasIsSurgeConfirmed)
          {
            if (remainder == 0)
                return extraIsSurgeConfirmedToJSON();
            --remainder;
          }
        if (flagHasSurgeConfirmationId)
          {
            if (remainder == 0)
                return extraSurgeConfirmationIdToJSON();
            --remainder;
          }
        if (flagHasPreferredProduct)
          {
            if (remainder == 0)
                return extraPreferredProductToJSON();
            --remainder;
          }
        if (flagHasUberProductId)
          {
            if (remainder == 0)
                return extraUberProductIdToJSON();
            --remainder;
          }
        if (flagHasPickupLocation)
          {
            if (remainder == 0)
                return extraPickupLocationToJSON();
            --remainder;
          }
        if (flagHasDropoffLocation)
          {
            if (remainder == 0)
                return extraDropoffLocationToJSON();
            --remainder;
          }
        if (flagHasPassengerCount)
          {
            if (remainder == 0)
                return extraPassengerCountToJSON();
            --remainder;
          }
        if (flagHasNewStates)
          {
            if (remainder == 0)
                return extraNewStatesToJSON();
            --remainder;
          }
        return extraUberRequestsSpecComponentValue(remainder);
      }
    public override JSONValue extraUberSpecLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "ropoffLocation", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasDropoffLocation ? extraDropoffLocationToJSON() : null);
                break;
            case 'I':
                if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                  {
                    switch (field_name[2])
                      {
                        case 'C':
                            switch (field_name[3])
                              {
                                case 'a':
                                    if ((String.Compare(field_name, 4, "ncelled", 0, 7, false) == 0) && (field_name.Length == 11))
                                        return (flagHasIsCancelled ? extraIsCancelledToJSON() : null);
                                    break;
                                case 'o':
                                    if ((String.Compare(field_name, 4, "nfirmed", 0, 7, false) == 0) && (field_name.Length == 11))
                                        return (flagHasIsConfirmed ? extraIsConfirmedToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'N':
                            if ((String.Compare(field_name, 3, "otUnderstood", 0, 12, false) == 0) && (field_name.Length == 15))
                                return (flagHasIsNotUnderstood ? extraIsNotUnderstoodToJSON() : null);
                            break;
                        case 'R':
                            if ((String.Compare(field_name, 3, "edirectOnConfirmation", 0, 21, false) == 0) && (field_name.Length == 24))
                                return (flagHasIsRedirectOnConfirmation ? extraIsRedirectOnConfirmationToJSON() : null);
                            break;
                        case 'S':
                            if ((String.Compare(field_name, 3, "urgeConfirmed", 0, 13, false) == 0) && (field_name.Length == 16))
                                return (flagHasIsSurgeConfirmed ? extraIsSurgeConfirmedToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ewStates", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasNewStates ? extraNewStatesToJSON() : null);
                break;
            case 'P':
                switch (field_name[1])
                  {
                    case 'a':
                        if ((String.Compare(field_name, 2, "ssengerCount", 0, 12, false) == 0) && (field_name.Length == 14))
                            return (flagHasPassengerCount ? extraPassengerCountToJSON() : null);
                        break;
                    case 'i':
                        if ((String.Compare(field_name, 2, "ckupLocation", 0, 12, false) == 0) && (field_name.Length == 14))
                            return (flagHasPickupLocation ? extraPickupLocationToJSON() : null);
                        break;
                    case 'r':
                        if ((String.Compare(field_name, 2, "eferredProduct", 0, 14, false) == 0) && (field_name.Length == 16))
                            return (flagHasPreferredProduct ? extraPreferredProductToJSON() : null);
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "urgeConfirmationId", 0, 18, false) == 0) && (field_name.Length == 19))
                    return (flagHasSurgeConfirmationId ? extraSurgeConfirmationIdToJSON() : null);
                break;
            case 'U':
                if ((String.Compare(field_name, 1, "berProductId", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasUberProductId ? extraUberProductIdToJSON() : null);
                break;
            default:
                break;
          }
        return extraUberRequestsSpecLookup(field_name);
      }

    public void setIsCancelled(bool new_value)
      {
        flagHasIsCancelled = true;
        storeIsCancelled = new_value;
      }
    public void unsetIsCancelled()
      {
        flagHasIsCancelled = false;
      }
    public void setIsConfirmed(bool new_value)
      {
        flagHasIsConfirmed = true;
        storeIsConfirmed = new_value;
      }
    public void unsetIsConfirmed()
      {
        flagHasIsConfirmed = false;
      }
    public void setIsNotUnderstood(bool new_value)
      {
        flagHasIsNotUnderstood = true;
        storeIsNotUnderstood = new_value;
      }
    public void unsetIsNotUnderstood()
      {
        flagHasIsNotUnderstood = false;
      }
    public void setIsRedirectOnConfirmation(bool new_value)
      {
        flagHasIsRedirectOnConfirmation = true;
        storeIsRedirectOnConfirmation = new_value;
      }
    public void unsetIsRedirectOnConfirmation()
      {
        flagHasIsRedirectOnConfirmation = false;
      }
    public void setIsSurgeConfirmed(bool new_value)
      {
        flagHasIsSurgeConfirmed = true;
        storeIsSurgeConfirmed = new_value;
      }
    public void unsetIsSurgeConfirmed()
      {
        flagHasIsSurgeConfirmed = false;
      }
    public void setSurgeConfirmationId(string new_value)
      {
        flagHasSurgeConfirmationId = true;
        storeSurgeConfirmationId = new_value;
      }
    public void unsetSurgeConfirmationId()
      {
        flagHasSurgeConfirmationId = false;
      }
    public void setPreferredProduct(string new_value)
      {
        flagHasPreferredProduct = true;
        storePreferredProduct = new_value;
      }
    public void unsetPreferredProduct()
      {
        flagHasPreferredProduct = false;
      }
    public void setUberProductId(string new_value)
      {
        flagHasUberProductId = true;
        storeUberProductId = new_value;
      }
    public void unsetUberProductId()
      {
        flagHasUberProductId = false;
      }
    public void setPickupLocation(MapLocationJSON  new_value)
      {
        if (flagHasPickupLocation)
          {
          }
        flagHasPickupLocation = true;
        storePickupLocation = new_value;
      }
    public void unsetPickupLocation()
      {
        if (flagHasPickupLocation)
          {
          }
        flagHasPickupLocation = false;
      }
    public void setDropoffLocation(MapLocationJSON  new_value)
      {
        if (flagHasDropoffLocation)
          {
          }
        flagHasDropoffLocation = true;
        storeDropoffLocation = new_value;
      }
    public void unsetDropoffLocation()
      {
        if (flagHasDropoffLocation)
          {
          }
        flagHasDropoffLocation = false;
      }
    public void setPassengerCount(BigInteger new_value)
      {
        flagHasPassengerCount = true;
        if (new_value < 0)
            throw new Exception("The value for field PassengerCount of UberRequestsSpecJSON is less than the lower bound (0) for that field.");
        storePassengerCount = new_value;
      }
    public void unsetPassengerCount()
      {
        flagHasPassengerCount = false;
      }
    public void initNewStates()
      {
        flagHasNewStates = true;
        storeNewStates.Clear();
      }
    public void appendNewStates(TypeNewStates to_append)
      {
        if (!flagHasNewStates)
          {
            flagHasNewStates = true;
            storeNewStates.Clear();
          }
        Debug.Assert(flagHasNewStates);
        storeNewStates.Add(to_append);
      }
    public void appendNewStates(string chars)
      {
        appendNewStates(stringToNewStates(chars));
      }
    public void unsetNewStates()
      {
        flagHasNewStates = false;
        storeNewStates.Clear();
      }

    public virtual void extraUberRequestsSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberRequestsSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberRequestsSpecLookup(key);
        if (old_field == null)
          {
            extraUberRequestsSpecAppendPair(key, new_component);
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
    public override void extraUberSpecAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ropoffLocation", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONDropoffLocation(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if (String.Compare(key, 1, "s", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'C':
                            switch (key[3])
                              {
                                case 'a':
                                    if ((String.Compare(key, 4, "ncelled", 0, 7, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONIsCancelled(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'o':
                                    if ((String.Compare(key, 4, "nfirmed", 0, 7, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONIsConfirmed(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'N':
                            if ((String.Compare(key, 3, "otUnderstood", 0, 12, false) == 0) && (key.Length == 15))
                                {
                                fromJSONIsNotUnderstood(new_component, false);
                                return;
                                }
                            break;
                        case 'R':
                            if ((String.Compare(key, 3, "edirectOnConfirmation", 0, 21, false) == 0) && (key.Length == 24))
                                {
                                fromJSONIsRedirectOnConfirmation(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 3, "urgeConfirmed", 0, 13, false) == 0) && (key.Length == 16))
                                {
                                fromJSONIsSurgeConfirmed(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ewStates", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONNewStates(new_component, false);
                    return;
                    }
                break;
            case 'P':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "ssengerCount", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONPassengerCount(new_component, false);
                            return;
                            }
                        break;
                    case 'i':
                        if ((String.Compare(key, 2, "ckupLocation", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONPickupLocation(new_component, false);
                            return;
                            }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "eferredProduct", 0, 14, false) == 0) && (key.Length == 16))
                            {
                            fromJSONPreferredProduct(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if ((String.Compare(key, 1, "urgeConfirmationId", 0, 18, false) == 0) && (key.Length == 19))
                    {
                    fromJSONSurgeConfirmationId(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "berProductId", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONUberProductId(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraUberRequestsSpecAppendPair(key, new_component);
      }
    public override void extraUberSpecSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "ropoffLocation", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONDropoffLocation(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if (String.Compare(key, 1, "s", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'C':
                            switch (key[3])
                              {
                                case 'a':
                                    if ((String.Compare(key, 4, "ncelled", 0, 7, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONIsCancelled(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'o':
                                    if ((String.Compare(key, 4, "nfirmed", 0, 7, false) == 0) && (key.Length == 11))
                                        {
                                        fromJSONIsConfirmed(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'N':
                            if ((String.Compare(key, 3, "otUnderstood", 0, 12, false) == 0) && (key.Length == 15))
                                {
                                fromJSONIsNotUnderstood(new_component, false);
                                return;
                                }
                            break;
                        case 'R':
                            if ((String.Compare(key, 3, "edirectOnConfirmation", 0, 21, false) == 0) && (key.Length == 24))
                                {
                                fromJSONIsRedirectOnConfirmation(new_component, false);
                                return;
                                }
                            break;
                        case 'S':
                            if ((String.Compare(key, 3, "urgeConfirmed", 0, 13, false) == 0) && (key.Length == 16))
                                {
                                fromJSONIsSurgeConfirmed(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ewStates", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONNewStates(new_component, false);
                    return;
                    }
                break;
            case 'P':
                switch (key[1])
                  {
                    case 'a':
                        if ((String.Compare(key, 2, "ssengerCount", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONPassengerCount(new_component, false);
                            return;
                            }
                        break;
                    case 'i':
                        if ((String.Compare(key, 2, "ckupLocation", 0, 12, false) == 0) && (key.Length == 14))
                            {
                            fromJSONPickupLocation(new_component, false);
                            return;
                            }
                        break;
                    case 'r':
                        if ((String.Compare(key, 2, "eferredProduct", 0, 14, false) == 0) && (key.Length == 16))
                            {
                            fromJSONPreferredProduct(new_component, false);
                            return;
                            }
                        break;
                    default:
                        break;
                  }
                break;
            case 'S':
                if ((String.Compare(key, 1, "urgeConfirmationId", 0, 18, false) == 0) && (key.Length == 19))
                    {
                    fromJSONSurgeConfirmationId(new_component, false);
                    return;
                    }
                break;
            case 'U':
                if ((String.Compare(key, 1, "berProductId", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONUberProductId(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraUberRequestsSpecSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        if (flagHasIsCancelled)
          {
            handler.start_pair("IsCancelled");
            handler.boolean_value(storeIsCancelled);
          }
        if (flagHasIsConfirmed)
          {
            handler.start_pair("IsConfirmed");
            handler.boolean_value(storeIsConfirmed);
          }
        if (flagHasIsNotUnderstood)
          {
            handler.start_pair("IsNotUnderstood");
            handler.boolean_value(storeIsNotUnderstood);
          }
        if (flagHasIsRedirectOnConfirmation)
          {
            handler.start_pair("IsRedirectOnConfirmation");
            handler.boolean_value(storeIsRedirectOnConfirmation);
          }
        if (flagHasIsSurgeConfirmed)
          {
            handler.start_pair("IsSurgeConfirmed");
            handler.boolean_value(storeIsSurgeConfirmed);
          }
        if (flagHasSurgeConfirmationId)
          {
            handler.start_pair("SurgeConfirmationId");
            handler.string_value(storeSurgeConfirmationId);
          }
        Debug.Assert(partial_allowed || flagHasPreferredProduct);
        if (flagHasPreferredProduct)
          {
            handler.start_pair("PreferredProduct");
            handler.string_value(storePreferredProduct);
          }
        if (flagHasUberProductId)
          {
            handler.start_pair("UberProductId");
            handler.string_value(storeUberProductId);
          }
        if (flagHasPickupLocation)
          {
            handler.start_pair("PickupLocation");
            if (partial_allowed)
                storePickupLocation.write_partial_as_json(handler);
            else
                storePickupLocation.write_as_json(handler);
          }
        if (flagHasDropoffLocation)
          {
            handler.start_pair("DropoffLocation");
            if (partial_allowed)
                storeDropoffLocation.write_partial_as_json(handler);
            else
                storeDropoffLocation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasPassengerCount);
        if (flagHasPassengerCount)
          {
            handler.start_pair("PassengerCount");
            handler.number_value(storePassengerCount);
          }
        Debug.Assert(partial_allowed || flagHasNewStates);
        if (flagHasNewStates)
          {
            handler.start_pair("NewStates");
            handler.start_array();
            for (int num1 = 0; num1 < storeNewStates.Count; ++num1)
              {
                switch (storeNewStates[num1])
                  {
                    case TypeNewStates.NewStates_select_pick_up_location:
                        handler.string_value("select_pick_up_location");
                        break;
                    case TypeNewStates.NewStates_select_drop_off_location:
                        handler.string_value("select_drop_off_location");
                        break;
                    case TypeNewStates.NewStates_select_uber_product:
                        handler.string_value("select_uber_product");
                        break;
                    case TypeNewStates.NewStates_select_uber_product_id:
                        handler.string_value("select_uber_product_id");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasPreferredProduct()))
          {
            return "When parsing the object for %what%, the \"PreferredProduct\" field was missing.";
          }
        if (!(hasPassengerCount()))
          {
            return "When parsing the object for %what%, the \"PassengerCount\" field was missing.";
          }
        if (!(hasNewStates()))
          {
            return "When parsing the object for %what%, the \"NewStates\" field was missing.";
          }
        return null;
      }

    public static new UberRequestsSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestsSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsSpec", ignore_extras);
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
    public static new UberRequestsSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberRequestsSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberRequestsSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsSpec", ignore_extras);
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
    public static new UberRequestsSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberRequestsSpecJSON from_text(string text, bool ignore_extras)
      {
        UberRequestsSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberRequestsSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UberRequestsSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberRequestsSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberRequestsSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UberSpecJSON.Generator
      {
        private JSONHoldingBooleanGenerator fieldGeneratorIsCancelled;
        private JSONHoldingBooleanGenerator fieldGeneratorIsConfirmed;
        private JSONHoldingBooleanGenerator fieldGeneratorIsNotUnderstood;
        private JSONHoldingBooleanGenerator fieldGeneratorIsRedirectOnConfirmation;
        private JSONHoldingBooleanGenerator fieldGeneratorIsSurgeConfirmed;
        private JSONHoldingStringGenerator fieldGeneratorSurgeConfirmationId;
        private JSONHoldingStringGenerator fieldGeneratorPreferredProduct;
        private JSONHoldingStringGenerator fieldGeneratorUberProductId;
        private MapLocationJSON.HoldingGenerator fieldGeneratorPickupLocation;
        private MapLocationJSON.HoldingGenerator fieldGeneratorDropoffLocation;
    private class FieldHoldingGeneratorPassengerCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorPassengerCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorPassengerCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorPassengerCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorPassengerCount fieldGeneratorPassengerCount;
    private abstract class FieldGeneratorNewStates : JSONStringGenerator
          {
            protected FieldGeneratorNewStates(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNewStates()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToNewStates(result));
              }
            protected abstract void handle_result(TypeNewStates result);
          };
    private class FieldHoldingGeneratorNewStates : FieldGeneratorNewStates
  {
    protected override void handle_result(TypeNewStates result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNewStates(String what)
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
    public TypeNewStates value;
  };
    private class FieldHoldingArrayGeneratorNewStates : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNewStates
      {
        private FieldHoldingArrayGeneratorNewStates top;

        protected override void handle_result(TypeNewStates result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNewStates init_top)
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
    protected virtual void handle_result(List<TypeNewStates> result)
      {
      }

    public FieldHoldingArrayGeneratorNewStates(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNewStates>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNewStates()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNewStates>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNewStates> value;
  };
        private FieldHoldingArrayGeneratorNewStates fieldGeneratorNewStates;
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
            if (!(getUberSpecJSONKey().Equals("UberRequestsSpec")))
                throw new Exception("The key field has a value other than `UberRequestsSpec'.");
            UberRequestsSpecJSON result = new UberRequestsSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberRequestsSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UberSpecJSON new_result)
          {
            handle_result((UberRequestsSpecJSON )new_result);
          }
        protected void finish(UberRequestsSpecJSON result)
          {
            if (fieldGeneratorIsCancelled.have_value)
              {
                result.setIsCancelled(fieldGeneratorIsCancelled.value);
                fieldGeneratorIsCancelled.have_value = false;
              }
            if (fieldGeneratorIsConfirmed.have_value)
              {
                result.setIsConfirmed(fieldGeneratorIsConfirmed.value);
                fieldGeneratorIsConfirmed.have_value = false;
              }
            if (fieldGeneratorIsNotUnderstood.have_value)
              {
                result.setIsNotUnderstood(fieldGeneratorIsNotUnderstood.value);
                fieldGeneratorIsNotUnderstood.have_value = false;
              }
            if (fieldGeneratorIsRedirectOnConfirmation.have_value)
              {
                result.setIsRedirectOnConfirmation(fieldGeneratorIsRedirectOnConfirmation.value);
                fieldGeneratorIsRedirectOnConfirmation.have_value = false;
              }
            if (fieldGeneratorIsSurgeConfirmed.have_value)
              {
                result.setIsSurgeConfirmed(fieldGeneratorIsSurgeConfirmed.value);
                fieldGeneratorIsSurgeConfirmed.have_value = false;
              }
            if (fieldGeneratorSurgeConfirmationId.have_value)
              {
                result.setSurgeConfirmationId(fieldGeneratorSurgeConfirmationId.value);
                fieldGeneratorSurgeConfirmationId.have_value = false;
              }
            if (fieldGeneratorPreferredProduct.have_value)
              {
                result.setPreferredProduct(fieldGeneratorPreferredProduct.value);
                fieldGeneratorPreferredProduct.have_value = false;
              }
            else if ((!(result.hasPreferredProduct())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PreferredProduct\" field was missing.");
              }
            if (fieldGeneratorUberProductId.have_value)
              {
                result.setUberProductId(fieldGeneratorUberProductId.value);
                fieldGeneratorUberProductId.have_value = false;
              }
            if (fieldGeneratorPickupLocation.have_value)
              {
                result.setPickupLocation(fieldGeneratorPickupLocation.value);
                fieldGeneratorPickupLocation.have_value = false;
              }
            if (fieldGeneratorDropoffLocation.have_value)
              {
                result.setDropoffLocation(fieldGeneratorDropoffLocation.value);
                fieldGeneratorDropoffLocation.have_value = false;
              }
            if (fieldGeneratorPassengerCount.have_value)
              {
                result.setPassengerCount(fieldGeneratorPassengerCount.value);
                fieldGeneratorPassengerCount.have_value = false;
              }
            else if ((!(result.hasPassengerCount())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PassengerCount\" field was missing.");
              }
            if (fieldGeneratorNewStates.have_value)
              {
                result.initNewStates();
                int count = fieldGeneratorNewStates.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendNewStates(fieldGeneratorNewStates.value[num]);
                  }
                fieldGeneratorNewStates.value.Clear();
                fieldGeneratorNewStates.have_value = false;
              }
            else if ((!(result.hasNewStates())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NewStates\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(UberRequestsSpecJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ropoffLocation", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorDropoffLocation;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "s", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'C':
                                switch (field_name[3])
                                  {
                                    case 'a':
                                        if ((String.Compare(field_name, 4, "ncelled", 0, 7, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorIsCancelled;
                                        break;
                                    case 'o':
                                        if ((String.Compare(field_name, 4, "nfirmed", 0, 7, false) == 0) && (field_name.Length == 11))
                                            return fieldGeneratorIsConfirmed;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 3, "otUnderstood", 0, 12, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorIsNotUnderstood;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 3, "edirectOnConfirmation", 0, 21, false) == 0) && (field_name.Length == 24))
                                    return fieldGeneratorIsRedirectOnConfirmation;
                                break;
                            case 'S':
                                if ((String.Compare(field_name, 3, "urgeConfirmed", 0, 13, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorIsSurgeConfirmed;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ewStates", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorNewStates;
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ssengerCount", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorPassengerCount;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "ckupLocation", 0, 12, false) == 0) && (field_name.Length == 14))
                                return fieldGeneratorPickupLocation;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "eferredProduct", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorPreferredProduct;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "urgeConfirmationId", 0, 18, false) == 0) && (field_name.Length == 19))
                        return fieldGeneratorSurgeConfirmationId;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "berProductId", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorUberProductId;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorIsCancelled = new JSONHoldingBooleanGenerator("field \"IsCancelled\" of the UberRequestsSpec class");
            fieldGeneratorIsConfirmed = new JSONHoldingBooleanGenerator("field \"IsConfirmed\" of the UberRequestsSpec class");
            fieldGeneratorIsNotUnderstood = new JSONHoldingBooleanGenerator("field \"IsNotUnderstood\" of the UberRequestsSpec class");
            fieldGeneratorIsRedirectOnConfirmation = new JSONHoldingBooleanGenerator("field \"IsRedirectOnConfirmation\" of the UberRequestsSpec class");
            fieldGeneratorIsSurgeConfirmed = new JSONHoldingBooleanGenerator("field \"IsSurgeConfirmed\" of the UberRequestsSpec class");
            fieldGeneratorSurgeConfirmationId = new JSONHoldingStringGenerator("field \"SurgeConfirmationId\" of the UberRequestsSpec class");
            fieldGeneratorPreferredProduct = new JSONHoldingStringGenerator("field \"PreferredProduct\" of the UberRequestsSpec class");
            fieldGeneratorUberProductId = new JSONHoldingStringGenerator("field \"UberProductId\" of the UberRequestsSpec class");
            fieldGeneratorPickupLocation = new MapLocationJSON.HoldingGenerator("field \"PickupLocation\" of the UberRequestsSpec class", ignore_extras);
            fieldGeneratorDropoffLocation = new MapLocationJSON.HoldingGenerator("field \"DropoffLocation\" of the UberRequestsSpec class", ignore_extras);
            fieldGeneratorPassengerCount = new FieldHoldingGeneratorPassengerCount("field \"PassengerCount\" of the UberRequestsSpec class");
            fieldGeneratorNewStates = new FieldHoldingArrayGeneratorNewStates("field \"NewStates\" of the UberRequestsSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberRequestsSpec class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorIsCancelled = new JSONHoldingBooleanGenerator("field \"IsCancelled\" of the UberRequestsSpec class");
            fieldGeneratorIsConfirmed = new JSONHoldingBooleanGenerator("field \"IsConfirmed\" of the UberRequestsSpec class");
            fieldGeneratorIsNotUnderstood = new JSONHoldingBooleanGenerator("field \"IsNotUnderstood\" of the UberRequestsSpec class");
            fieldGeneratorIsRedirectOnConfirmation = new JSONHoldingBooleanGenerator("field \"IsRedirectOnConfirmation\" of the UberRequestsSpec class");
            fieldGeneratorIsSurgeConfirmed = new JSONHoldingBooleanGenerator("field \"IsSurgeConfirmed\" of the UberRequestsSpec class");
            fieldGeneratorSurgeConfirmationId = new JSONHoldingStringGenerator("field \"SurgeConfirmationId\" of the UberRequestsSpec class");
            fieldGeneratorPreferredProduct = new JSONHoldingStringGenerator("field \"PreferredProduct\" of the UberRequestsSpec class");
            fieldGeneratorUberProductId = new JSONHoldingStringGenerator("field \"UberProductId\" of the UberRequestsSpec class");
            fieldGeneratorPickupLocation = new MapLocationJSON.HoldingGenerator("field \"PickupLocation\" of the UberRequestsSpec class", false);
            fieldGeneratorDropoffLocation = new MapLocationJSON.HoldingGenerator("field \"DropoffLocation\" of the UberRequestsSpec class", false);
            fieldGeneratorPassengerCount = new FieldHoldingGeneratorPassengerCount("field \"PassengerCount\" of the UberRequestsSpec class");
            fieldGeneratorNewStates = new FieldHoldingArrayGeneratorNewStates("field \"NewStates\" of the UberRequestsSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberRequestsSpec class");
          }

        public override void reset()
          {
            fieldGeneratorIsCancelled.reset();
            fieldGeneratorIsConfirmed.reset();
            fieldGeneratorIsNotUnderstood.reset();
            fieldGeneratorIsRedirectOnConfirmation.reset();
            fieldGeneratorIsSurgeConfirmed.reset();
            fieldGeneratorSurgeConfirmationId.reset();
            fieldGeneratorPreferredProduct.reset();
            fieldGeneratorUberProductId.reset();
            fieldGeneratorPickupLocation.reset();
            fieldGeneratorDropoffLocation.reset();
            fieldGeneratorPassengerCount.reset();
            fieldGeneratorNewStates.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UberRequestsSpecJSON  result)
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
        public UberRequestsSpecJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberRequestsSpecJSON  result)
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
    protected virtual void handle_result(List<UberRequestsSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberRequestsSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberRequestsSpecJSON>();
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
    public List<UberRequestsSpecJSON> value;
  };
  };
