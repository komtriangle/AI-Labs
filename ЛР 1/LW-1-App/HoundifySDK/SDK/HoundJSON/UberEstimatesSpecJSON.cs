/* file "UberEstimatesSpecJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class UberEstimatesSpecJSON : UberSpecJSON
  {
    public enum TypeEstimateTypes
      {
        EstimateTypes_cost,
        EstimateTypes_duration,
        EstimateTypes_distance,
        EstimateTypes_time
      };

    public static TypeEstimateTypes  stringToEstimateTypes(string chars)
      {
        switch (chars[0])
          {
            case 'c':
                if ((String.Compare(chars, 1, "ost", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeEstimateTypes.EstimateTypes_cost;
                break;
            case 'd':
                switch (chars[1])
                  {
                    case 'i':
                        if ((String.Compare(chars, 2, "stance", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeEstimateTypes.EstimateTypes_distance;
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "ration", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeEstimateTypes.EstimateTypes_duration;
                        break;
                    default:
                        break;
                  }
                break;
            case 't':
                if ((String.Compare(chars, 1, "ime", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeEstimateTypes.EstimateTypes_time;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `EstimateTypes' is not one of the legal values.");
      }

    public static string  stringFromEstimateTypes(TypeEstimateTypes the_enum)
      {
        switch (the_enum)
          {
            case TypeEstimateTypes.EstimateTypes_cost:
                return "cost";
            case TypeEstimateTypes.EstimateTypes_duration:
                return "duration";
            case TypeEstimateTypes.EstimateTypes_distance:
                return "distance";
            case TypeEstimateTypes.EstimateTypes_time:
                return "time";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasPreferredProduct;
    private string storePreferredProduct;
    private bool flagHasPickupLocation;
    private MapLocationJSON  storePickupLocation;
    private bool flagHasDropoffLocation;
    private MapLocationJSON  storeDropoffLocation;
    private bool flagHasPassengerCount;
    private BigInteger storePassengerCount;
    private bool flagHasEstimateTypes;
    private List< TypeEstimateTypes > storeEstimateTypes;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraPreferredProductToJSON()
      {
        JSONStringValue generated_string_PreferredProduct = new JSONStringValue(storePreferredProduct);
        return generated_string_PreferredProduct;
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

    private JSONValue  extraEstimateTypesToJSON()
      {
        JSONArrayValue generated_array_1_EstimateTypes = new JSONArrayValue();
        for (int num1 = 0; num1 < storeEstimateTypes.Count; ++num1)
          {
            JSONStringValue generated_string_EstimateTypes;
            switch (storeEstimateTypes[num1])
              {
                case TypeEstimateTypes.EstimateTypes_cost:
                    generated_string_EstimateTypes = new JSONStringValue("cost");
                    break;
                case TypeEstimateTypes.EstimateTypes_duration:
                    generated_string_EstimateTypes = new JSONStringValue("duration");
                    break;
                case TypeEstimateTypes.EstimateTypes_distance:
                    generated_string_EstimateTypes = new JSONStringValue("distance");
                    break;
                case TypeEstimateTypes.EstimateTypes_time:
                    generated_string_EstimateTypes = new JSONStringValue("time");
                    break;
                default:
                    Debug.Assert(false);
                    generated_string_EstimateTypes = null;
                    break;
              }
            generated_array_1_EstimateTypes.appendComponent(generated_string_EstimateTypes);
          }
        return generated_array_1_EstimateTypes;
      }


    private void  fromJSONPreferredProduct(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field PreferredProduct of UberEstimatesSpecJSON is not a string.");
        setPreferredProduct(json_string.getData());
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
                throw new Exception("The value for field PassengerCount of UberEstimatesSpecJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field PassengerCount of UberEstimatesSpecJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setPassengerCount(extracted_integer);
      }


    private void  fromJSONEstimateTypes(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field EstimateTypes of UberEstimatesSpecJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field EstimateTypes of UberEstimatesSpecJSON has too few elements.");
        List< TypeEstimateTypes > vector_EstimateTypes1 = new List< TypeEstimateTypes >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field EstimateTypes of UberEstimatesSpecJSON is not a string.");
            TypeEstimateTypes the_enum;
            switch (json_string.getData()[0])
              {
                case 'c':
                    if ((String.Compare(json_string.getData(), 1, "ost", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeEstimateTypes.EstimateTypes_cost;
                            goto enum_is_done;
                          }
                    break;
                case 'd':
                    switch (json_string.getData()[1])
                      {
                        case 'i':
                            if ((String.Compare(json_string.getData(), 2, "stance", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_enum = TypeEstimateTypes.EstimateTypes_distance;
                                    goto enum_is_done;
                                  }
                            break;
                        case 'u':
                            if ((String.Compare(json_string.getData(), 2, "ration", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_enum = TypeEstimateTypes.EstimateTypes_duration;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 't':
                    if ((String.Compare(json_string.getData(), 1, "ime", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                          {
                            the_enum = TypeEstimateTypes.EstimateTypes_time;
                            goto enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            throw new Exception("The value for an element of field EstimateTypes of UberEstimatesSpecJSON is not one of the legal strings.");
          enum_is_done:;
            vector_EstimateTypes1.Add(the_enum);
          }
        Debug.Assert(vector_EstimateTypes1.Count >= 1);
        initEstimateTypes();
        for (int num1 = 0; num1 < vector_EstimateTypes1.Count; ++num1)
            appendEstimateTypes(vector_EstimateTypes1[num1]);
        for (int num1 = 0; num1 < vector_EstimateTypes1.Count; ++num1)
          {
          }
      }


    public UberEstimatesSpecJSON()
      {
        flagHasPreferredProduct = false;
        flagHasPickupLocation = false;
        flagHasDropoffLocation = false;
        flagHasPassengerCount = false;
        flagHasEstimateTypes = false;
        storeEstimateTypes = new List< TypeEstimateTypes >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getUberSpecKind()
      {
        return "UberEstimatesSpec";
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

    public bool  hasEstimateTypes()
      {
        return flagHasEstimateTypes;
      }

    public int  countOfEstimateTypes()
      {
        Debug.Assert(flagHasEstimateTypes);
        return storeEstimateTypes.Count;
      }

    public TypeEstimateTypes  elementOfEstimateTypes(int element_num)
      {
        Debug.Assert(flagHasEstimateTypes);
        return storeEstimateTypes[element_num];
      }

    public List< TypeEstimateTypes >  getEstimateTypes()
      {
        Debug.Assert(flagHasEstimateTypes);
        return storeEstimateTypes;
      }


    public virtual int extraUberEstimatesSpecComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraUberEstimatesSpecComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraUberEstimatesSpecComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraUberEstimatesSpecLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraUberSpecComponentCount()
      {
        int result = 0;
        if (flagHasPreferredProduct)
            ++result;
        if (flagHasPickupLocation)
            ++result;
        if (flagHasDropoffLocation)
            ++result;
        if (flagHasPassengerCount)
            ++result;
        if (flagHasEstimateTypes)
            ++result;
        result += extraUberEstimatesSpecComponentCount();
        return result;
      }
    public override string extraUberSpecComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasPreferredProduct)
          {
            if (remainder == 0)
                return "PreferredProduct";
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
        if (flagHasEstimateTypes)
          {
            if (remainder == 0)
                return "EstimateTypes";
            --remainder;
          }
        return extraUberEstimatesSpecComponentKey(remainder);
      }
    public override JSONValue extraUberSpecComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasPreferredProduct)
          {
            if (remainder == 0)
                return extraPreferredProductToJSON();
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
        if (flagHasEstimateTypes)
          {
            if (remainder == 0)
                return extraEstimateTypesToJSON();
            --remainder;
          }
        return extraUberEstimatesSpecComponentValue(remainder);
      }
    public override JSONValue extraUberSpecLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "ropoffLocation", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasDropoffLocation ? extraDropoffLocationToJSON() : null);
                break;
            case 'E':
                if ((String.Compare(field_name, 1, "stimateTypes", 0, 12, false) == 0) && (field_name.Length == 13))
                    return (flagHasEstimateTypes ? extraEstimateTypesToJSON() : null);
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
            default:
                break;
          }
        return extraUberEstimatesSpecLookup(field_name);
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
            throw new Exception("The value for field PassengerCount of UberEstimatesSpecJSON is less than the lower bound (0) for that field.");
        storePassengerCount = new_value;
      }
    public void unsetPassengerCount()
      {
        flagHasPassengerCount = false;
      }
    public void initEstimateTypes()
      {
        flagHasEstimateTypes = true;
        storeEstimateTypes.Clear();
      }
    public void appendEstimateTypes(TypeEstimateTypes to_append)
      {
        if (!flagHasEstimateTypes)
          {
            flagHasEstimateTypes = true;
            storeEstimateTypes.Clear();
          }
        Debug.Assert(flagHasEstimateTypes);
        storeEstimateTypes.Add(to_append);
      }
    public void appendEstimateTypes(string chars)
      {
        appendEstimateTypes(stringToEstimateTypes(chars));
      }
    public void unsetEstimateTypes()
      {
        flagHasEstimateTypes = false;
        storeEstimateTypes.Clear();
      }

    public virtual void extraUberEstimatesSpecAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraUberEstimatesSpecSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraUberEstimatesSpecLookup(key);
        if (old_field == null)
          {
            extraUberEstimatesSpecAppendPair(key, new_component);
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
            case 'E':
                if ((String.Compare(key, 1, "stimateTypes", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONEstimateTypes(new_component, false);
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
            default:
                break;
          }
        extraUberEstimatesSpecAppendPair(key, new_component);
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
            case 'E':
                if ((String.Compare(key, 1, "stimateTypes", 0, 12, false) == 0) && (key.Length == 13))
                    {
                    fromJSONEstimateTypes(new_component, false);
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
            default:
                break;
          }
        extraUberEstimatesSpecSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasPreferredProduct);
        if (flagHasPreferredProduct)
          {
            handler.start_pair("PreferredProduct");
            handler.string_value(storePreferredProduct);
          }
        Debug.Assert(partial_allowed || flagHasPickupLocation);
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
        Debug.Assert(partial_allowed || flagHasEstimateTypes);
        if (flagHasEstimateTypes)
          {
            handler.start_pair("EstimateTypes");
            Debug.Assert(storeEstimateTypes.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeEstimateTypes.Count; ++num1)
              {
                switch (storeEstimateTypes[num1])
                  {
                    case TypeEstimateTypes.EstimateTypes_cost:
                        handler.string_value("cost");
                        break;
                    case TypeEstimateTypes.EstimateTypes_duration:
                        handler.string_value("duration");
                        break;
                    case TypeEstimateTypes.EstimateTypes_distance:
                        handler.string_value("distance");
                        break;
                    case TypeEstimateTypes.EstimateTypes_time:
                        handler.string_value("time");
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
        if (!(hasPickupLocation()))
          {
            return "When parsing the object for %what%, the \"PickupLocation\" field was missing.";
          }
        if (!(hasPassengerCount()))
          {
            return "When parsing the object for %what%, the \"PassengerCount\" field was missing.";
          }
        if (!(hasEstimateTypes()))
          {
            return "When parsing the object for %what%, the \"EstimateTypes\" field was missing.";
          }
        return null;
      }

    public static new UberEstimatesSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberEstimatesSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberEstimatesSpec", ignore_extras);
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
    public static new UberEstimatesSpecJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberEstimatesSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        UberEstimatesSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberEstimatesSpec", ignore_extras);
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
    public static new UberEstimatesSpecJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new UberEstimatesSpecJSON from_text(string text, bool ignore_extras)
      {
        UberEstimatesSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberEstimatesSpec", ignore_extras);
            JSONParse.parse_json_value(text, "Text for UberEstimatesSpecJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new UberEstimatesSpecJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        UberEstimatesSpecJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type UberEstimatesSpec", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : UberSpecJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorPreferredProduct;
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
    private abstract class FieldGeneratorEstimateTypes : JSONStringGenerator
          {
            protected FieldGeneratorEstimateTypes(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorEstimateTypes()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToEstimateTypes(result));
              }
            protected abstract void handle_result(TypeEstimateTypes result);
          };
    private class FieldHoldingGeneratorEstimateTypes : FieldGeneratorEstimateTypes
  {
    protected override void handle_result(TypeEstimateTypes result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorEstimateTypes(String what)
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
    public TypeEstimateTypes value;
  };
    private class FieldHoldingArrayGeneratorEstimateTypes : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorEstimateTypes
      {
        private FieldHoldingArrayGeneratorEstimateTypes top;

        protected override void handle_result(TypeEstimateTypes result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorEstimateTypes init_top)
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
    protected virtual void handle_result(List<TypeEstimateTypes> result)
      {
      }

    public FieldHoldingArrayGeneratorEstimateTypes(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEstimateTypes>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorEstimateTypes()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeEstimateTypes>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeEstimateTypes> value;
  };
        private FieldHoldingArrayGeneratorEstimateTypes fieldGeneratorEstimateTypes;
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
            if (!(getUberSpecJSONKey().Equals("UberEstimatesSpec")))
                throw new Exception("The key field has a value other than `UberEstimatesSpec'.");
            UberEstimatesSpecJSON result = new UberEstimatesSpecJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraUberEstimatesSpecAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(UberSpecJSON new_result)
          {
            handle_result((UberEstimatesSpecJSON )new_result);
          }
        protected void finish(UberEstimatesSpecJSON result)
          {
            if (fieldGeneratorPreferredProduct.have_value)
              {
                result.setPreferredProduct(fieldGeneratorPreferredProduct.value);
                fieldGeneratorPreferredProduct.have_value = false;
              }
            else if ((!(result.hasPreferredProduct())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PreferredProduct\" field was missing.");
              }
            if (fieldGeneratorPickupLocation.have_value)
              {
                result.setPickupLocation(fieldGeneratorPickupLocation.value);
                fieldGeneratorPickupLocation.have_value = false;
              }
            else if ((!(result.hasPickupLocation())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"PickupLocation\" field was missing.");
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
            if (fieldGeneratorEstimateTypes.have_value)
              {
                result.initEstimateTypes();
                int count = fieldGeneratorEstimateTypes.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendEstimateTypes(fieldGeneratorEstimateTypes.value[num]);
                  }
                fieldGeneratorEstimateTypes.value.Clear();
                fieldGeneratorEstimateTypes.have_value = false;
              }
            else if ((!(result.hasEstimateTypes())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"EstimateTypes\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(UberEstimatesSpecJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "ropoffLocation", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorDropoffLocation;
                    break;
                case 'E':
                    if ((String.Compare(field_name, 1, "stimateTypes", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorEstimateTypes;
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
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorPreferredProduct = new JSONHoldingStringGenerator("field \"PreferredProduct\" of the UberEstimatesSpec class");
            fieldGeneratorPickupLocation = new MapLocationJSON.HoldingGenerator("field \"PickupLocation\" of the UberEstimatesSpec class", ignore_extras);
            fieldGeneratorDropoffLocation = new MapLocationJSON.HoldingGenerator("field \"DropoffLocation\" of the UberEstimatesSpec class", ignore_extras);
            fieldGeneratorPassengerCount = new FieldHoldingGeneratorPassengerCount("field \"PassengerCount\" of the UberEstimatesSpec class");
            fieldGeneratorEstimateTypes = new FieldHoldingArrayGeneratorEstimateTypes("field \"EstimateTypes\" of the UberEstimatesSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the UberEstimatesSpec class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorPreferredProduct = new JSONHoldingStringGenerator("field \"PreferredProduct\" of the UberEstimatesSpec class");
            fieldGeneratorPickupLocation = new MapLocationJSON.HoldingGenerator("field \"PickupLocation\" of the UberEstimatesSpec class", false);
            fieldGeneratorDropoffLocation = new MapLocationJSON.HoldingGenerator("field \"DropoffLocation\" of the UberEstimatesSpec class", false);
            fieldGeneratorPassengerCount = new FieldHoldingGeneratorPassengerCount("field \"PassengerCount\" of the UberEstimatesSpec class");
            fieldGeneratorEstimateTypes = new FieldHoldingArrayGeneratorEstimateTypes("field \"EstimateTypes\" of the UberEstimatesSpec class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the UberEstimatesSpec class");
          }

        public override void reset()
          {
            fieldGeneratorPreferredProduct.reset();
            fieldGeneratorPickupLocation.reset();
            fieldGeneratorDropoffLocation.reset();
            fieldGeneratorPassengerCount.reset();
            fieldGeneratorEstimateTypes.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(UberEstimatesSpecJSON  result)
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
        public UberEstimatesSpecJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(UberEstimatesSpecJSON  result)
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
    protected virtual void handle_result(List<UberEstimatesSpecJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<UberEstimatesSpecJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<UberEstimatesSpecJSON>();
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
    public List<UberEstimatesSpecJSON> value;
  };
  };
