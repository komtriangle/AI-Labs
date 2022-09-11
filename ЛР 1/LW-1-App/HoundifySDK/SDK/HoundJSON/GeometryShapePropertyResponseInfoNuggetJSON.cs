/* file "GeometryShapePropertyResponseInfoNuggetJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class GeometryShapePropertyResponseInfoNuggetJSON : GeometryInfoNuggetJSON
  {
    public enum TypeQueryTypeKnownValues
      {
        QueryType_WhatIs,
        QueryType_HowTo,
        QueryType_WhatIsFormula,
        QueryType_Unknown,
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
            case 'H':
                if ((String.Compare(chars, 1, "owTo", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeQueryTypeKnownValues.QueryType_HowTo;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeQueryTypeKnownValues.QueryType_Unknown;
                break;
            case 'W':
                if (String.Compare(chars, 1, "hatIs", 0, 5, false) == 0)
                  {
                    if (chars.Length == 6)
                      {
                        return TypeQueryTypeKnownValues.QueryType_WhatIs;
                      }
                    switch (chars[6])
                      {
                        case 'F':
                            if ((String.Compare(chars, 7, "ormula", 0, 6, false) == 0) && (chars.Length == 13))
                                return TypeQueryTypeKnownValues.QueryType_WhatIsFormula;
                            break;
                        default:
                            break;
                      }
                  }
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
            case TypeQueryTypeKnownValues.QueryType_WhatIs:
                return "WhatIs";
            case TypeQueryTypeKnownValues.QueryType_HowTo:
                return "HowTo";
            case TypeQueryTypeKnownValues.QueryType_WhatIsFormula:
                return "WhatIsFormula";
            case TypeQueryTypeKnownValues.QueryType_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeResponseStatusKnownValues
      {
        ResponseStatus_Successful,
        ResponseStatus_ErrorUndefinedShape,
        ResponseStatus_ErrorIllegalProperty,
        ResponseStatus_ErrorConflictingProperties,
        ResponseStatus_ErrorFailedCalculation,
        ResponseStatus_Unknown,
        ResponseStatus__none
      };
    public struct TypeResponseStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeResponseStatusKnownValues list_value;
      };

    public static TypeResponseStatusKnownValues  stringToResponseStatus(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if (String.Compare(chars, 1, "rror", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'C':
                            if ((String.Compare(chars, 6, "onflictingProperties", 0, 20, false) == 0) && (chars.Length == 26))
                                return TypeResponseStatusKnownValues.ResponseStatus_ErrorConflictingProperties;
                            break;
                        case 'F':
                            if ((String.Compare(chars, 6, "ailedCalculation", 0, 16, false) == 0) && (chars.Length == 22))
                                return TypeResponseStatusKnownValues.ResponseStatus_ErrorFailedCalculation;
                            break;
                        case 'I':
                            if ((String.Compare(chars, 6, "llegalProperty", 0, 14, false) == 0) && (chars.Length == 20))
                                return TypeResponseStatusKnownValues.ResponseStatus_ErrorIllegalProperty;
                            break;
                        case 'U':
                            if ((String.Compare(chars, 6, "ndefinedShape", 0, 13, false) == 0) && (chars.Length == 19))
                                return TypeResponseStatusKnownValues.ResponseStatus_ErrorUndefinedShape;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(chars, 1, "uccessful", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeResponseStatusKnownValues.ResponseStatus_Successful;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeResponseStatusKnownValues.ResponseStatus_Unknown;
                break;
            default:
                break;
          }
        return TypeResponseStatusKnownValues.ResponseStatus__none;
      }

    public static string  stringFromResponseStatus(TypeResponseStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeResponseStatusKnownValues.ResponseStatus_Successful:
                return "Successful";
            case TypeResponseStatusKnownValues.ResponseStatus_ErrorUndefinedShape:
                return "ErrorUndefinedShape";
            case TypeResponseStatusKnownValues.ResponseStatus_ErrorIllegalProperty:
                return "ErrorIllegalProperty";
            case TypeResponseStatusKnownValues.ResponseStatus_ErrorConflictingProperties:
                return "ErrorConflictingProperties";
            case TypeResponseStatusKnownValues.ResponseStatus_ErrorFailedCalculation:
                return "ErrorFailedCalculation";
            case TypeResponseStatusKnownValues.ResponseStatus_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasQueryType;
    private TypeQueryType storeQueryType;
    private bool flagHasResponseStatus;
    private TypeResponseStatus storeResponseStatus;
    private bool flagHasShapeName;
    private string storeShapeName;
    private bool flagHasGivenProperties;
    private List< GeometryShapePropertyJSON  > storeGivenProperties;
    private bool flagHasRequestedProperty;
    private GeometryShapePropertyJSON  storeRequestedProperty;
    private bool flagHasIllegalProperty;
    private GeometryShapePropertyJSON  storeIllegalProperty;
    private bool flagHasExpressionTrees;
    private List< GeometryExpressionTreeJSON  > storeExpressionTrees;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraQueryTypeToJSON()
      {
        JSONStringValue generated_string_QueryType;
        if (!(storeQueryType.in_known_list))
          {
        generated_string_QueryType = new JSONStringValue(storeQueryType.string_value);
          }
        else
          {
        switch (storeQueryType.list_value)
          {
            case TypeQueryTypeKnownValues.QueryType_WhatIs:
                generated_string_QueryType = new JSONStringValue("WhatIs");
                break;
            case TypeQueryTypeKnownValues.QueryType_HowTo:
                generated_string_QueryType = new JSONStringValue("HowTo");
                break;
            case TypeQueryTypeKnownValues.QueryType_WhatIsFormula:
                generated_string_QueryType = new JSONStringValue("WhatIsFormula");
                break;
            case TypeQueryTypeKnownValues.QueryType_Unknown:
                generated_string_QueryType = new JSONStringValue("Unknown");
                break;
            default:
                Debug.Assert(false);
                generated_string_QueryType = null;
                break;
          }
          }
        return generated_string_QueryType;
      }

    private JSONValue  extraResponseStatusToJSON()
      {
        JSONStringValue generated_string_ResponseStatus;
        if (!(storeResponseStatus.in_known_list))
          {
        generated_string_ResponseStatus = new JSONStringValue(storeResponseStatus.string_value);
          }
        else
          {
        switch (storeResponseStatus.list_value)
          {
            case TypeResponseStatusKnownValues.ResponseStatus_Successful:
                generated_string_ResponseStatus = new JSONStringValue("Successful");
                break;
            case TypeResponseStatusKnownValues.ResponseStatus_ErrorUndefinedShape:
                generated_string_ResponseStatus = new JSONStringValue("ErrorUndefinedShape");
                break;
            case TypeResponseStatusKnownValues.ResponseStatus_ErrorIllegalProperty:
                generated_string_ResponseStatus = new JSONStringValue("ErrorIllegalProperty");
                break;
            case TypeResponseStatusKnownValues.ResponseStatus_ErrorConflictingProperties:
                generated_string_ResponseStatus = new JSONStringValue("ErrorConflictingProperties");
                break;
            case TypeResponseStatusKnownValues.ResponseStatus_ErrorFailedCalculation:
                generated_string_ResponseStatus = new JSONStringValue("ErrorFailedCalculation");
                break;
            case TypeResponseStatusKnownValues.ResponseStatus_Unknown:
                generated_string_ResponseStatus = new JSONStringValue("Unknown");
                break;
            default:
                Debug.Assert(false);
                generated_string_ResponseStatus = null;
                break;
          }
          }
        return generated_string_ResponseStatus;
      }

    private JSONValue  extraShapeNameToJSON()
      {
        JSONStringValue generated_string_ShapeName = new JSONStringValue(storeShapeName);
        return generated_string_ShapeName;
      }

    private JSONValue  extraGivenPropertiesToJSON()
      {
        JSONArrayValue generated_array_1_GivenProperties = new JSONArrayValue();
        for (int num1 = 0; num1 < storeGivenProperties.Count; ++num1)
          {
            JSONValueHandler handler_GivenProperties = new JSONValueHandler();
            storeGivenProperties[num1].write_as_json(handler_GivenProperties);
            generated_array_1_GivenProperties.appendComponent(handler_GivenProperties.result);
          }
        return generated_array_1_GivenProperties;
      }

    private JSONValue  extraRequestedPropertyToJSON()
      {
        JSONValueHandler handler_RequestedProperty = new JSONValueHandler();
        storeRequestedProperty.write_as_json(handler_RequestedProperty);
        return handler_RequestedProperty.result;
      }

    private JSONValue  extraIllegalPropertyToJSON()
      {
        JSONValueHandler handler_IllegalProperty = new JSONValueHandler();
        storeIllegalProperty.write_as_json(handler_IllegalProperty);
        return handler_IllegalProperty.result;
      }

    private JSONValue  extraExpressionTreesToJSON()
      {
        JSONArrayValue generated_array_2_ExpressionTrees = new JSONArrayValue();
        for (int num2 = 0; num2 < storeExpressionTrees.Count; ++num2)
          {
            JSONValueHandler handler_ExpressionTrees = new JSONValueHandler();
            storeExpressionTrees[num2].write_as_json(handler_ExpressionTrees);
            generated_array_2_ExpressionTrees.appendComponent(handler_ExpressionTrees.result);
          }
        return generated_array_2_ExpressionTrees;
      }


    private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryType of GeometryShapePropertyResponseInfoNuggetJSON is not a string.");
        TypeQueryType the_open_enum = new TypeQueryType();
        switch (json_string.getData()[0])
          {
            case 'H':
                if ((String.Compare(json_string.getData(), 1, "owTo", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_HowTo;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_Unknown;
                        goto open_enum_is_done;
                      }
                break;
            case 'W':
                if (String.Compare(json_string.getData(), 1, "hatIs", 0, 5, false) == 0)
                  {
                    if (json_string.getData().Length == 6)
                      {
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_WhatIs;
                            goto open_enum_is_done;
                          }
                      }
                    switch (json_string.getData()[6])
                      {
                        case 'F':
                            if ((String.Compare(json_string.getData(), 7, "ormula", 0, 6, false) == 0) && (json_string.getData().Length == 13))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQueryTypeKnownValues.QueryType_WhatIsFormula;
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
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setQueryType(the_open_enum);
      }


    private void  fromJSONResponseStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ResponseStatus of GeometryShapePropertyResponseInfoNuggetJSON is not a string.");
        TypeResponseStatus the_open_enum = new TypeResponseStatus();
        switch (json_string.getData()[0])
          {
            case 'E':
                if (String.Compare(json_string.getData(), 1, "rror", 0, 4, false) == 0)
                  {
                    switch (json_string.getData()[5])
                      {
                        case 'C':
                            if ((String.Compare(json_string.getData(), 6, "onflictingProperties", 0, 20, false) == 0) && (json_string.getData().Length == 26))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeResponseStatusKnownValues.ResponseStatus_ErrorConflictingProperties;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'F':
                            if ((String.Compare(json_string.getData(), 6, "ailedCalculation", 0, 16, false) == 0) && (json_string.getData().Length == 22))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeResponseStatusKnownValues.ResponseStatus_ErrorFailedCalculation;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            if ((String.Compare(json_string.getData(), 6, "llegalProperty", 0, 14, false) == 0) && (json_string.getData().Length == 20))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeResponseStatusKnownValues.ResponseStatus_ErrorIllegalProperty;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'U':
                            if ((String.Compare(json_string.getData(), 6, "ndefinedShape", 0, 13, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeResponseStatusKnownValues.ResponseStatus_ErrorUndefinedShape;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "uccessful", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeResponseStatusKnownValues.ResponseStatus_Successful;
                        goto open_enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeResponseStatusKnownValues.ResponseStatus_Unknown;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setResponseStatus(the_open_enum);
      }


    private void  fromJSONShapeName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ShapeName of GeometryShapePropertyResponseInfoNuggetJSON is not a string.");
        setShapeName(json_string.getData());
      }


    private void  fromJSONGivenProperties(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GivenProperties of GeometryShapePropertyResponseInfoNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field GivenProperties of GeometryShapePropertyResponseInfoNuggetJSON has too few elements.");
        List< GeometryShapePropertyJSON  > vector_GivenProperties1 = new List< GeometryShapePropertyJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            GeometryShapePropertyJSON convert_classy = GeometryShapePropertyJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_GivenProperties1.Add(convert_classy);
          }
        Debug.Assert(vector_GivenProperties1.Count >= 1);
        initGivenProperties();
        for (int num1 = 0; num1 < vector_GivenProperties1.Count; ++num1)
            appendGivenProperties(vector_GivenProperties1[num1]);
        for (int num1 = 0; num1 < vector_GivenProperties1.Count; ++num1)
          {
          }
      }


    private void  fromJSONRequestedProperty(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        GeometryShapePropertyJSON convert_classy = GeometryShapePropertyJSON.from_json(json_value, ignore_extras, true);
        setRequestedProperty(convert_classy);
      }


    private void  fromJSONIllegalProperty(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        GeometryShapePropertyJSON convert_classy = GeometryShapePropertyJSON.from_json(json_value, ignore_extras, true);
        setIllegalProperty(convert_classy);
      }


    private void  fromJSONExpressionTrees(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ExpressionTrees of GeometryShapePropertyResponseInfoNuggetJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field ExpressionTrees of GeometryShapePropertyResponseInfoNuggetJSON has too few elements.");
        List< GeometryExpressionTreeJSON  > vector_ExpressionTrees1 = new List< GeometryExpressionTreeJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            GeometryExpressionTreeJSON convert_classy = GeometryExpressionTreeJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_ExpressionTrees1.Add(convert_classy);
          }
        Debug.Assert(vector_ExpressionTrees1.Count >= 1);
        initExpressionTrees();
        for (int num2 = 0; num2 < vector_ExpressionTrees1.Count; ++num2)
            appendExpressionTrees(vector_ExpressionTrees1[num2]);
        for (int num1 = 0; num1 < vector_ExpressionTrees1.Count; ++num1)
          {
          }
      }


    public GeometryShapePropertyResponseInfoNuggetJSON()
      {
        flagHasQueryType = false;
        flagHasResponseStatus = false;
        flagHasShapeName = false;
        flagHasGivenProperties = false;
        flagHasRequestedProperty = false;
        flagHasIllegalProperty = false;
        flagHasExpressionTrees = false;
        storeGivenProperties = new List< GeometryShapePropertyJSON  >();
        storeExpressionTrees = new List< GeometryExpressionTreeJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getGeometryInfoNuggetKind()
      {
        return "GeometryShapePropertyResponseInfoNugget";
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

    public bool  hasResponseStatus()
      {
        return flagHasResponseStatus;
      }

    public TypeResponseStatus  getResponseStatus()
      {
        Debug.Assert(flagHasResponseStatus);
        return storeResponseStatus;
      }

    public string  getResponseStatusAsString()
      {
        TypeResponseStatus result = getResponseStatus();
        if (result.in_known_list)
            return stringFromResponseStatus(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasShapeName()
      {
        return flagHasShapeName;
      }

    public string  getShapeName()
      {
        Debug.Assert(flagHasShapeName);
        return storeShapeName;
      }

    public bool  hasGivenProperties()
      {
        return flagHasGivenProperties;
      }

    public int  countOfGivenProperties()
      {
        Debug.Assert(flagHasGivenProperties);
        return storeGivenProperties.Count;
      }

    public GeometryShapePropertyJSON   elementOfGivenProperties(int element_num)
      {
        Debug.Assert(flagHasGivenProperties);
        return storeGivenProperties[element_num];
      }

    public List< GeometryShapePropertyJSON  >  getGivenProperties()
      {
        Debug.Assert(flagHasGivenProperties);
        return storeGivenProperties;
      }

    public bool  hasRequestedProperty()
      {
        return flagHasRequestedProperty;
      }

    public GeometryShapePropertyJSON   getRequestedProperty()
      {
        Debug.Assert(flagHasRequestedProperty);
        return storeRequestedProperty;
      }

    public bool  hasIllegalProperty()
      {
        return flagHasIllegalProperty;
      }

    public GeometryShapePropertyJSON   getIllegalProperty()
      {
        Debug.Assert(flagHasIllegalProperty);
        return storeIllegalProperty;
      }

    public bool  hasExpressionTrees()
      {
        return flagHasExpressionTrees;
      }

    public int  countOfExpressionTrees()
      {
        Debug.Assert(flagHasExpressionTrees);
        return storeExpressionTrees.Count;
      }

    public GeometryExpressionTreeJSON   elementOfExpressionTrees(int element_num)
      {
        Debug.Assert(flagHasExpressionTrees);
        return storeExpressionTrees[element_num];
      }

    public List< GeometryExpressionTreeJSON  >  getExpressionTrees()
      {
        Debug.Assert(flagHasExpressionTrees);
        return storeExpressionTrees;
      }


    public virtual int extraGeometryShapePropertyResponseInfoNuggetComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGeometryShapePropertyResponseInfoNuggetComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGeometryShapePropertyResponseInfoNuggetComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGeometryShapePropertyResponseInfoNuggetLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraGeometryInfoNuggetComponentCount()
      {
        int result = 0;
        if (flagHasQueryType)
            ++result;
        if (flagHasResponseStatus)
            ++result;
        if (flagHasShapeName)
            ++result;
        if (flagHasGivenProperties)
            ++result;
        if (flagHasRequestedProperty)
            ++result;
        if (flagHasIllegalProperty)
            ++result;
        if (flagHasExpressionTrees)
            ++result;
        result += extraGeometryShapePropertyResponseInfoNuggetComponentCount();
        return result;
      }
    public override string extraGeometryInfoNuggetComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryType)
          {
            if (remainder == 0)
                return "QueryType";
            --remainder;
          }
        if (flagHasResponseStatus)
          {
            if (remainder == 0)
                return "ResponseStatus";
            --remainder;
          }
        if (flagHasShapeName)
          {
            if (remainder == 0)
                return "ShapeName";
            --remainder;
          }
        if (flagHasGivenProperties)
          {
            if (remainder == 0)
                return "GivenProperties";
            --remainder;
          }
        if (flagHasRequestedProperty)
          {
            if (remainder == 0)
                return "RequestedProperty";
            --remainder;
          }
        if (flagHasIllegalProperty)
          {
            if (remainder == 0)
                return "IllegalProperty";
            --remainder;
          }
        if (flagHasExpressionTrees)
          {
            if (remainder == 0)
                return "ExpressionTrees";
            --remainder;
          }
        return extraGeometryShapePropertyResponseInfoNuggetComponentKey(remainder);
      }
    public override JSONValue extraGeometryInfoNuggetComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasQueryType)
          {
            if (remainder == 0)
                return extraQueryTypeToJSON();
            --remainder;
          }
        if (flagHasResponseStatus)
          {
            if (remainder == 0)
                return extraResponseStatusToJSON();
            --remainder;
          }
        if (flagHasShapeName)
          {
            if (remainder == 0)
                return extraShapeNameToJSON();
            --remainder;
          }
        if (flagHasGivenProperties)
          {
            if (remainder == 0)
                return extraGivenPropertiesToJSON();
            --remainder;
          }
        if (flagHasRequestedProperty)
          {
            if (remainder == 0)
                return extraRequestedPropertyToJSON();
            --remainder;
          }
        if (flagHasIllegalProperty)
          {
            if (remainder == 0)
                return extraIllegalPropertyToJSON();
            --remainder;
          }
        if (flagHasExpressionTrees)
          {
            if (remainder == 0)
                return extraExpressionTreesToJSON();
            --remainder;
          }
        return extraGeometryShapePropertyResponseInfoNuggetComponentValue(remainder);
      }
    public override JSONValue extraGeometryInfoNuggetLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'E':
                if ((String.Compare(field_name, 1, "xpressionTrees", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasExpressionTrees ? extraExpressionTreesToJSON() : null);
                break;
            case 'G':
                if ((String.Compare(field_name, 1, "ivenProperties", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasGivenProperties ? extraGivenPropertiesToJSON() : null);
                break;
            case 'I':
                if ((String.Compare(field_name, 1, "llegalProperty", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasIllegalProperty ? extraIllegalPropertyToJSON() : null);
                break;
            case 'Q':
                if ((String.Compare(field_name, 1, "ueryType", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasQueryType ? extraQueryTypeToJSON() : null);
                break;
            case 'R':
                if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                  {
                    switch (field_name[2])
                      {
                        case 'q':
                            if ((String.Compare(field_name, 3, "uestedProperty", 0, 14, false) == 0) && (field_name.Length == 17))
                                return (flagHasRequestedProperty ? extraRequestedPropertyToJSON() : null);
                            break;
                        case 's':
                            if ((String.Compare(field_name, 3, "ponseStatus", 0, 11, false) == 0) && (field_name.Length == 14))
                                return (flagHasResponseStatus ? extraResponseStatusToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "hapeName", 0, 8, false) == 0) && (field_name.Length == 9))
                    return (flagHasShapeName ? extraShapeNameToJSON() : null);
                break;
            default:
                break;
          }
        return extraGeometryShapePropertyResponseInfoNuggetLookup(field_name);
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
    public void setResponseStatus(TypeResponseStatus new_value)
      {
        flagHasResponseStatus = true;
        storeResponseStatus = new_value;
      }
    public void setResponseStatus(string chars)
      {
        TypeResponseStatusKnownValues known = stringToResponseStatus(chars);
        TypeResponseStatus new_value = new TypeResponseStatus();
        if (known == TypeResponseStatusKnownValues.ResponseStatus__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setResponseStatus(new_value);
      }
    public void setResponseStatus(TypeResponseStatusKnownValues new_value)
      {
        TypeResponseStatus new_full_value = new TypeResponseStatus();
        Debug.Assert(new_value != TypeResponseStatusKnownValues.ResponseStatus__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setResponseStatus(new_full_value);
      }
    public void unsetResponseStatus()
      {
        flagHasResponseStatus = false;
      }
    public void setShapeName(string new_value)
      {
        flagHasShapeName = true;
        storeShapeName = new_value;
      }
    public void unsetShapeName()
      {
        flagHasShapeName = false;
      }
    public void initGivenProperties()
      {
        if (flagHasGivenProperties)
          {
            for (int num1 = 0; num1 < storeGivenProperties.Count; ++num1)
              {
              }
          }
        flagHasGivenProperties = true;
        storeGivenProperties.Clear();
      }
    public void appendGivenProperties(GeometryShapePropertyJSON  to_append)
      {
        if (!flagHasGivenProperties)
          {
            flagHasGivenProperties = true;
            storeGivenProperties.Clear();
          }
        Debug.Assert(flagHasGivenProperties);
        storeGivenProperties.Add(to_append);
      }
    public void unsetGivenProperties()
      {
        if (flagHasGivenProperties)
          {
            for (int num2 = 0; num2 < storeGivenProperties.Count; ++num2)
              {
              }
          }
        flagHasGivenProperties = false;
        storeGivenProperties.Clear();
      }
    public void setRequestedProperty(GeometryShapePropertyJSON  new_value)
      {
        if (flagHasRequestedProperty)
          {
          }
        flagHasRequestedProperty = true;
        storeRequestedProperty = new_value;
      }
    public void unsetRequestedProperty()
      {
        if (flagHasRequestedProperty)
          {
          }
        flagHasRequestedProperty = false;
      }
    public void setIllegalProperty(GeometryShapePropertyJSON  new_value)
      {
        if (flagHasIllegalProperty)
          {
          }
        flagHasIllegalProperty = true;
        storeIllegalProperty = new_value;
      }
    public void unsetIllegalProperty()
      {
        if (flagHasIllegalProperty)
          {
          }
        flagHasIllegalProperty = false;
      }
    public void initExpressionTrees()
      {
        if (flagHasExpressionTrees)
          {
            for (int num3 = 0; num3 < storeExpressionTrees.Count; ++num3)
              {
              }
          }
        flagHasExpressionTrees = true;
        storeExpressionTrees.Clear();
      }
    public void appendExpressionTrees(GeometryExpressionTreeJSON  to_append)
      {
        if (!flagHasExpressionTrees)
          {
            flagHasExpressionTrees = true;
            storeExpressionTrees.Clear();
          }
        Debug.Assert(flagHasExpressionTrees);
        storeExpressionTrees.Add(to_append);
      }
    public void unsetExpressionTrees()
      {
        if (flagHasExpressionTrees)
          {
            for (int num4 = 0; num4 < storeExpressionTrees.Count; ++num4)
              {
              }
          }
        flagHasExpressionTrees = false;
        storeExpressionTrees.Clear();
      }

    public virtual void extraGeometryShapePropertyResponseInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGeometryShapePropertyResponseInfoNuggetSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGeometryShapePropertyResponseInfoNuggetLookup(key);
        if (old_field == null)
          {
            extraGeometryShapePropertyResponseInfoNuggetAppendPair(key, new_component);
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
    public override void extraGeometryInfoNuggetAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "xpressionTrees", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONExpressionTrees(new_component, false);
                    return;
                    }
                break;
            case 'G':
                if ((String.Compare(key, 1, "ivenProperties", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONGivenProperties(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "llegalProperty", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONIllegalProperty(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryType", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONQueryType(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if (String.Compare(key, 1, "e", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'q':
                            if ((String.Compare(key, 3, "uestedProperty", 0, 14, false) == 0) && (key.Length == 17))
                                {
                                fromJSONRequestedProperty(new_component, false);
                                return;
                                }
                            break;
                        case 's':
                            if ((String.Compare(key, 3, "ponseStatus", 0, 11, false) == 0) && (key.Length == 14))
                                {
                                fromJSONResponseStatus(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(key, 1, "hapeName", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONShapeName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGeometryShapePropertyResponseInfoNuggetAppendPair(key, new_component);
      }
    public override void extraGeometryInfoNuggetSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'E':
                if ((String.Compare(key, 1, "xpressionTrees", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONExpressionTrees(new_component, false);
                    return;
                    }
                break;
            case 'G':
                if ((String.Compare(key, 1, "ivenProperties", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONGivenProperties(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if ((String.Compare(key, 1, "llegalProperty", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONIllegalProperty(new_component, false);
                    return;
                    }
                break;
            case 'Q':
                if ((String.Compare(key, 1, "ueryType", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONQueryType(new_component, false);
                    return;
                    }
                break;
            case 'R':
                if (String.Compare(key, 1, "e", 0, 1, false) == 0)
                  {
                    switch (key[2])
                      {
                        case 'q':
                            if ((String.Compare(key, 3, "uestedProperty", 0, 14, false) == 0) && (key.Length == 17))
                                {
                                fromJSONRequestedProperty(new_component, false);
                                return;
                                }
                            break;
                        case 's':
                            if ((String.Compare(key, 3, "ponseStatus", 0, 11, false) == 0) && (key.Length == 14))
                                {
                                fromJSONResponseStatus(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'S':
                if ((String.Compare(key, 1, "hapeName", 0, 8, false) == 0) && (key.Length == 9))
                    {
                    fromJSONShapeName(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraGeometryShapePropertyResponseInfoNuggetSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasQueryType);
        if (flagHasQueryType)
          {
            handler.start_pair("QueryType");
            if (storeQueryType.in_known_list)
              {
                switch (storeQueryType.list_value)
                  {
                    case TypeQueryTypeKnownValues.QueryType_WhatIs:
                        handler.string_value("WhatIs");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_HowTo:
                        handler.string_value("HowTo");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_WhatIsFormula:
                        handler.string_value("WhatIsFormula");
                        break;
                    case TypeQueryTypeKnownValues.QueryType_Unknown:
                        handler.string_value("Unknown");
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
        Debug.Assert(partial_allowed || flagHasResponseStatus);
        if (flagHasResponseStatus)
          {
            handler.start_pair("ResponseStatus");
            if (storeResponseStatus.in_known_list)
              {
                switch (storeResponseStatus.list_value)
                  {
                    case TypeResponseStatusKnownValues.ResponseStatus_Successful:
                        handler.string_value("Successful");
                        break;
                    case TypeResponseStatusKnownValues.ResponseStatus_ErrorUndefinedShape:
                        handler.string_value("ErrorUndefinedShape");
                        break;
                    case TypeResponseStatusKnownValues.ResponseStatus_ErrorIllegalProperty:
                        handler.string_value("ErrorIllegalProperty");
                        break;
                    case TypeResponseStatusKnownValues.ResponseStatus_ErrorConflictingProperties:
                        handler.string_value("ErrorConflictingProperties");
                        break;
                    case TypeResponseStatusKnownValues.ResponseStatus_ErrorFailedCalculation:
                        handler.string_value("ErrorFailedCalculation");
                        break;
                    case TypeResponseStatusKnownValues.ResponseStatus_Unknown:
                        handler.string_value("Unknown");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeResponseStatus.string_value);
              }
          }
        Debug.Assert(partial_allowed || flagHasShapeName);
        if (flagHasShapeName)
          {
            handler.start_pair("ShapeName");
            handler.string_value(storeShapeName);
          }
        if (flagHasGivenProperties)
          {
            handler.start_pair("GivenProperties");
            Debug.Assert(storeGivenProperties.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeGivenProperties.Count; ++num1)
              {
                if (partial_allowed)
                    storeGivenProperties[num1].write_partial_as_json(handler);
                else
                    storeGivenProperties[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasRequestedProperty)
          {
            handler.start_pair("RequestedProperty");
            if (partial_allowed)
                storeRequestedProperty.write_partial_as_json(handler);
            else
                storeRequestedProperty.write_as_json(handler);
          }
        if (flagHasIllegalProperty)
          {
            handler.start_pair("IllegalProperty");
            if (partial_allowed)
                storeIllegalProperty.write_partial_as_json(handler);
            else
                storeIllegalProperty.write_as_json(handler);
          }
        if (flagHasExpressionTrees)
          {
            handler.start_pair("ExpressionTrees");
            Debug.Assert(storeExpressionTrees.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeExpressionTrees.Count; ++num2)
              {
                if (partial_allowed)
                    storeExpressionTrees[num2].write_partial_as_json(handler);
                else
                    storeExpressionTrees[num2].write_as_json(handler);
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
        if (!(hasQueryType()))
          {
            return "When parsing the object for %what%, the \"QueryType\" field was missing.";
          }
        if (!(hasResponseStatus()))
          {
            return "When parsing the object for %what%, the \"ResponseStatus\" field was missing.";
          }
        if (!(hasShapeName()))
          {
            return "When parsing the object for %what%, the \"ShapeName\" field was missing.";
          }
        return null;
      }

    public static new GeometryShapePropertyResponseInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeometryShapePropertyResponseInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryShapePropertyResponseInfoNugget", ignore_extras);
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
    public static new GeometryShapePropertyResponseInfoNuggetJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GeometryShapePropertyResponseInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeometryShapePropertyResponseInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryShapePropertyResponseInfoNugget", ignore_extras);
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
    public static new GeometryShapePropertyResponseInfoNuggetJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new GeometryShapePropertyResponseInfoNuggetJSON from_text(string text, bool ignore_extras)
      {
        GeometryShapePropertyResponseInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryShapePropertyResponseInfoNugget", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeometryShapePropertyResponseInfoNuggetJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new GeometryShapePropertyResponseInfoNuggetJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeometryShapePropertyResponseInfoNuggetJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryShapePropertyResponseInfoNugget", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : GeometryInfoNuggetJSON.Generator
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
    private abstract class FieldGeneratorResponseStatus : JSONStringGenerator
          {
            protected FieldGeneratorResponseStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorResponseStatus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeResponseStatusKnownValues known = stringToResponseStatus(result);
                TypeResponseStatus new_value = new TypeResponseStatus();
                if (known == TypeResponseStatusKnownValues.ResponseStatus__none)
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
            protected abstract void handle_result(TypeResponseStatus result);
          };
    private class FieldHoldingGeneratorResponseStatus : FieldGeneratorResponseStatus
  {
    protected override void handle_result(TypeResponseStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorResponseStatus(String what)
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
    public TypeResponseStatus value;
  };
    private class FieldHoldingArrayGeneratorResponseStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorResponseStatus
      {
        private FieldHoldingArrayGeneratorResponseStatus top;

        protected override void handle_result(TypeResponseStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorResponseStatus init_top)
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
    protected virtual void handle_result(List<TypeResponseStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorResponseStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeResponseStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorResponseStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeResponseStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeResponseStatus> value;
  };
        private FieldHoldingGeneratorResponseStatus fieldGeneratorResponseStatus;
        private JSONHoldingStringGenerator fieldGeneratorShapeName;
        private GeometryShapePropertyJSON.HoldingArrayGenerator fieldGeneratorGivenProperties;
        private GeometryShapePropertyJSON.HoldingGenerator fieldGeneratorRequestedProperty;
        private GeometryShapePropertyJSON.HoldingGenerator fieldGeneratorIllegalProperty;
        private GeometryExpressionTreeJSON.HoldingArrayGenerator fieldGeneratorExpressionTrees;
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
            if (!(getGeometryInfoNuggetJSONKey().Equals("GeometryShapePropertyResponseInfoNugget")))
                throw new Exception("The key field has a value other than `GeometryShapePropertyResponseInfoNugget'.");
            GeometryShapePropertyResponseInfoNuggetJSON result = new GeometryShapePropertyResponseInfoNuggetJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGeometryShapePropertyResponseInfoNuggetAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(GeometryInfoNuggetJSON new_result)
          {
            handle_result((GeometryShapePropertyResponseInfoNuggetJSON )new_result);
          }
        protected void finish(GeometryShapePropertyResponseInfoNuggetJSON result)
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
            if (fieldGeneratorResponseStatus.have_value)
              {
                result.setResponseStatus(fieldGeneratorResponseStatus.value);
                fieldGeneratorResponseStatus.have_value = false;
              }
            else if ((!(result.hasResponseStatus())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ResponseStatus\" field was missing.");
              }
            if (fieldGeneratorShapeName.have_value)
              {
                result.setShapeName(fieldGeneratorShapeName.value);
                fieldGeneratorShapeName.have_value = false;
              }
            else if ((!(result.hasShapeName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ShapeName\" field was missing.");
              }
            if (fieldGeneratorGivenProperties.have_value)
              {
                result.initGivenProperties();
                int count = fieldGeneratorGivenProperties.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendGivenProperties(fieldGeneratorGivenProperties.value[num]);
                  }
                fieldGeneratorGivenProperties.value.Clear();
                fieldGeneratorGivenProperties.have_value = false;
              }
            if (fieldGeneratorRequestedProperty.have_value)
              {
                result.setRequestedProperty(fieldGeneratorRequestedProperty.value);
                fieldGeneratorRequestedProperty.have_value = false;
              }
            if (fieldGeneratorIllegalProperty.have_value)
              {
                result.setIllegalProperty(fieldGeneratorIllegalProperty.value);
                fieldGeneratorIllegalProperty.have_value = false;
              }
            if (fieldGeneratorExpressionTrees.have_value)
              {
                result.initExpressionTrees();
                int count = fieldGeneratorExpressionTrees.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendExpressionTrees(fieldGeneratorExpressionTrees.value[num]);
                  }
                fieldGeneratorExpressionTrees.value.Clear();
                fieldGeneratorExpressionTrees.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(GeometryShapePropertyResponseInfoNuggetJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'E':
                    if ((String.Compare(field_name, 1, "xpressionTrees", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorExpressionTrees;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "ivenProperties", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorGivenProperties;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "llegalProperty", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorIllegalProperty;
                    break;
                case 'Q':
                    if ((String.Compare(field_name, 1, "ueryType", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorQueryType;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'q':
                                if ((String.Compare(field_name, 3, "uestedProperty", 0, 14, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorRequestedProperty;
                                break;
                            case 's':
                                if ((String.Compare(field_name, 3, "ponseStatus", 0, 11, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorResponseStatus;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "hapeName", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorShapeName;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the GeometryShapePropertyResponseInfoNugget class");
            fieldGeneratorResponseStatus = new FieldHoldingGeneratorResponseStatus("field \"ResponseStatus\" of the GeometryShapePropertyResponseInfoNugget class");
            fieldGeneratorShapeName = new JSONHoldingStringGenerator("field \"ShapeName\" of the GeometryShapePropertyResponseInfoNugget class");
            fieldGeneratorGivenProperties = new GeometryShapePropertyJSON.HoldingArrayGenerator("field \"GivenProperties\" of the GeometryShapePropertyResponseInfoNugget class", ignore_extras);
            fieldGeneratorRequestedProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"RequestedProperty\" of the GeometryShapePropertyResponseInfoNugget class", ignore_extras);
            fieldGeneratorIllegalProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"IllegalProperty\" of the GeometryShapePropertyResponseInfoNugget class", ignore_extras);
            fieldGeneratorExpressionTrees = new GeometryExpressionTreeJSON.HoldingArrayGenerator("field \"ExpressionTrees\" of the GeometryShapePropertyResponseInfoNugget class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GeometryShapePropertyResponseInfoNugget class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the GeometryShapePropertyResponseInfoNugget class");
            fieldGeneratorResponseStatus = new FieldHoldingGeneratorResponseStatus("field \"ResponseStatus\" of the GeometryShapePropertyResponseInfoNugget class");
            fieldGeneratorShapeName = new JSONHoldingStringGenerator("field \"ShapeName\" of the GeometryShapePropertyResponseInfoNugget class");
            fieldGeneratorGivenProperties = new GeometryShapePropertyJSON.HoldingArrayGenerator("field \"GivenProperties\" of the GeometryShapePropertyResponseInfoNugget class", false);
            fieldGeneratorRequestedProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"RequestedProperty\" of the GeometryShapePropertyResponseInfoNugget class", false);
            fieldGeneratorIllegalProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"IllegalProperty\" of the GeometryShapePropertyResponseInfoNugget class", false);
            fieldGeneratorExpressionTrees = new GeometryExpressionTreeJSON.HoldingArrayGenerator("field \"ExpressionTrees\" of the GeometryShapePropertyResponseInfoNugget class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GeometryShapePropertyResponseInfoNugget class");
          }

        public override void reset()
          {
            fieldGeneratorQueryType.reset();
            fieldGeneratorResponseStatus.reset();
            fieldGeneratorShapeName.reset();
            fieldGeneratorGivenProperties.reset();
            fieldGeneratorRequestedProperty.reset();
            fieldGeneratorIllegalProperty.reset();
            fieldGeneratorExpressionTrees.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(GeometryShapePropertyResponseInfoNuggetJSON  result)
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
        public GeometryShapePropertyResponseInfoNuggetJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeometryShapePropertyResponseInfoNuggetJSON  result)
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
    protected virtual void handle_result(List<GeometryShapePropertyResponseInfoNuggetJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeometryShapePropertyResponseInfoNuggetJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeometryShapePropertyResponseInfoNuggetJSON>();
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
    public List<GeometryShapePropertyResponseInfoNuggetJSON> value;
  };
  };
