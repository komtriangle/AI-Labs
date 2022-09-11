/* file "GeometryShapePropertyQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class GeometryShapePropertyQueryStateJSON : JSONBase
  {
    public enum TypeQueryTypeKnownValues
      {
        QueryType_WhatIs,
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
            case TypeQueryTypeKnownValues.QueryType_WhatIsFormula:
                return "WhatIsFormula";
            case TypeQueryTypeKnownValues.QueryType_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeQueryStatusKnownValues
      {
        QueryStatus_Valid,
        QueryStatus_ErrorUndefinedShape,
        QueryStatus_ErrorIllegalRequestedProperty,
        QueryStatus_ErrorIllegalGivenProperty,
        QueryStatus_ErrorMissingProperty,
        QueryStatus_ErrorAbstractShape,
        QueryStatus_ErrorConflictingProperties,
        QueryStatus_Unknown,
        QueryStatus__none
      };
    public struct TypeQueryStatus
      {
        public bool in_known_list;
        public string string_value;
        public TypeQueryStatusKnownValues list_value;
      };

    public static TypeQueryStatusKnownValues  stringToQueryStatus(string chars)
      {
        switch (chars[0])
          {
            case 'E':
                if (String.Compare(chars, 1, "rror", 0, 4, false) == 0)
                  {
                    switch (chars[5])
                      {
                        case 'A':
                            if ((String.Compare(chars, 6, "bstractShape", 0, 12, false) == 0) && (chars.Length == 18))
                                return TypeQueryStatusKnownValues.QueryStatus_ErrorAbstractShape;
                            break;
                        case 'C':
                            if ((String.Compare(chars, 6, "onflictingProperties", 0, 20, false) == 0) && (chars.Length == 26))
                                return TypeQueryStatusKnownValues.QueryStatus_ErrorConflictingProperties;
                            break;
                        case 'I':
                            if (String.Compare(chars, 6, "llegal", 0, 6, false) == 0)
                              {
                                switch (chars[12])
                                  {
                                    case 'G':
                                        if ((String.Compare(chars, 13, "ivenProperty", 0, 12, false) == 0) && (chars.Length == 25))
                                            return TypeQueryStatusKnownValues.QueryStatus_ErrorIllegalGivenProperty;
                                        break;
                                    case 'R':
                                        if ((String.Compare(chars, 13, "equestedProperty", 0, 16, false) == 0) && (chars.Length == 29))
                                            return TypeQueryStatusKnownValues.QueryStatus_ErrorIllegalRequestedProperty;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'M':
                            if ((String.Compare(chars, 6, "issingProperty", 0, 14, false) == 0) && (chars.Length == 20))
                                return TypeQueryStatusKnownValues.QueryStatus_ErrorMissingProperty;
                            break;
                        case 'U':
                            if ((String.Compare(chars, 6, "ndefinedShape", 0, 13, false) == 0) && (chars.Length == 19))
                                return TypeQueryStatusKnownValues.QueryStatus_ErrorUndefinedShape;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeQueryStatusKnownValues.QueryStatus_Unknown;
                break;
            case 'V':
                if ((String.Compare(chars, 1, "alid", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeQueryStatusKnownValues.QueryStatus_Valid;
                break;
            default:
                break;
          }
        return TypeQueryStatusKnownValues.QueryStatus__none;
      }

    public static string  stringFromQueryStatus(TypeQueryStatusKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeQueryStatusKnownValues.QueryStatus_Valid:
                return "Valid";
            case TypeQueryStatusKnownValues.QueryStatus_ErrorUndefinedShape:
                return "ErrorUndefinedShape";
            case TypeQueryStatusKnownValues.QueryStatus_ErrorIllegalRequestedProperty:
                return "ErrorIllegalRequestedProperty";
            case TypeQueryStatusKnownValues.QueryStatus_ErrorIllegalGivenProperty:
                return "ErrorIllegalGivenProperty";
            case TypeQueryStatusKnownValues.QueryStatus_ErrorMissingProperty:
                return "ErrorMissingProperty";
            case TypeQueryStatusKnownValues.QueryStatus_ErrorAbstractShape:
                return "ErrorAbstractShape";
            case TypeQueryStatusKnownValues.QueryStatus_ErrorConflictingProperties:
                return "ErrorConflictingProperties";
            case TypeQueryStatusKnownValues.QueryStatus_Unknown:
                return "Unknown";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasQueryType;
    private TypeQueryType storeQueryType;
    private bool flagHasQueryStatus;
    private TypeQueryStatus storeQueryStatus;
    private bool flagHasShapeName;
    private string storeShapeName;
    private bool flagHasGivenProperties;
    private List< GeometryShapePropertyJSON  > storeGivenProperties;
    private bool flagHasRequestedProperty;
    private GeometryShapePropertyJSON  storeRequestedProperty;
    private bool flagHasIllegalProperty;
    private GeometryShapePropertyJSON  storeIllegalProperty;
    private bool flagHasMissingProperty;
    private GeometryShapePropertyJSON  storeMissingProperty;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONQueryType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryType of GeometryShapePropertyQueryStateJSON is not a string.");
        TypeQueryType the_open_enum = new TypeQueryType();
        switch (json_string.getData()[0])
          {
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


    private void  fromJSONQueryStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field QueryStatus of GeometryShapePropertyQueryStateJSON is not a string.");
        TypeQueryStatus the_open_enum = new TypeQueryStatus();
        switch (json_string.getData()[0])
          {
            case 'E':
                if (String.Compare(json_string.getData(), 1, "rror", 0, 4, false) == 0)
                  {
                    switch (json_string.getData()[5])
                      {
                        case 'A':
                            if ((String.Compare(json_string.getData(), 6, "bstractShape", 0, 12, false) == 0) && (json_string.getData().Length == 18))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQueryStatusKnownValues.QueryStatus_ErrorAbstractShape;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'C':
                            if ((String.Compare(json_string.getData(), 6, "onflictingProperties", 0, 20, false) == 0) && (json_string.getData().Length == 26))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQueryStatusKnownValues.QueryStatus_ErrorConflictingProperties;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'I':
                            if (String.Compare(json_string.getData(), 6, "llegal", 0, 6, false) == 0)
                              {
                                switch (json_string.getData()[12])
                                  {
                                    case 'G':
                                        if ((String.Compare(json_string.getData(), 13, "ivenProperty", 0, 12, false) == 0) && (json_string.getData().Length == 25))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeQueryStatusKnownValues.QueryStatus_ErrorIllegalGivenProperty;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'R':
                                        if ((String.Compare(json_string.getData(), 13, "equestedProperty", 0, 16, false) == 0) && (json_string.getData().Length == 29))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeQueryStatusKnownValues.QueryStatus_ErrorIllegalRequestedProperty;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'M':
                            if ((String.Compare(json_string.getData(), 6, "issingProperty", 0, 14, false) == 0) && (json_string.getData().Length == 20))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQueryStatusKnownValues.QueryStatus_ErrorMissingProperty;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'U':
                            if ((String.Compare(json_string.getData(), 6, "ndefinedShape", 0, 13, false) == 0) && (json_string.getData().Length == 19))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeQueryStatusKnownValues.QueryStatus_ErrorUndefinedShape;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryStatusKnownValues.QueryStatus_Unknown;
                        goto open_enum_is_done;
                      }
                break;
            case 'V':
                if ((String.Compare(json_string.getData(), 1, "alid", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeQueryStatusKnownValues.QueryStatus_Valid;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setQueryStatus(the_open_enum);
      }


    private void  fromJSONShapeName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ShapeName of GeometryShapePropertyQueryStateJSON is not a string.");
        setShapeName(json_string.getData());
      }


    private void  fromJSONGivenProperties(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field GivenProperties of GeometryShapePropertyQueryStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field GivenProperties of GeometryShapePropertyQueryStateJSON has too few elements.");
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


    private void  fromJSONMissingProperty(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        GeometryShapePropertyJSON convert_classy = GeometryShapePropertyJSON.from_json(json_value, ignore_extras, true);
        setMissingProperty(convert_classy);
      }


    public GeometryShapePropertyQueryStateJSON()
      {
        flagHasQueryType = false;
        flagHasQueryStatus = false;
        flagHasShapeName = false;
        flagHasGivenProperties = false;
        flagHasRequestedProperty = false;
        flagHasIllegalProperty = false;
        flagHasMissingProperty = false;
        storeGivenProperties = new List< GeometryShapePropertyJSON  >();
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

    public bool  hasQueryStatus()
      {
        return flagHasQueryStatus;
      }

    public TypeQueryStatus  getQueryStatus()
      {
        Debug.Assert(flagHasQueryStatus);
        return storeQueryStatus;
      }

    public string  getQueryStatusAsString()
      {
        TypeQueryStatus result = getQueryStatus();
        if (result.in_known_list)
            return stringFromQueryStatus(result.list_value);
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

    public bool  hasMissingProperty()
      {
        return flagHasMissingProperty;
      }

    public GeometryShapePropertyJSON   getMissingProperty()
      {
        Debug.Assert(flagHasMissingProperty);
        return storeMissingProperty;
      }


    public virtual int extraGeometryShapePropertyQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGeometryShapePropertyQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGeometryShapePropertyQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGeometryShapePropertyQueryStateLookup(string field_name)
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
    public void setQueryStatus(TypeQueryStatus new_value)
      {
        flagHasQueryStatus = true;
        storeQueryStatus = new_value;
      }
    public void setQueryStatus(string chars)
      {
        TypeQueryStatusKnownValues known = stringToQueryStatus(chars);
        TypeQueryStatus new_value = new TypeQueryStatus();
        if (known == TypeQueryStatusKnownValues.QueryStatus__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setQueryStatus(new_value);
      }
    public void setQueryStatus(TypeQueryStatusKnownValues new_value)
      {
        TypeQueryStatus new_full_value = new TypeQueryStatus();
        Debug.Assert(new_value != TypeQueryStatusKnownValues.QueryStatus__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setQueryStatus(new_full_value);
      }
    public void unsetQueryStatus()
      {
        flagHasQueryStatus = false;
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
    public void setMissingProperty(GeometryShapePropertyJSON  new_value)
      {
        if (flagHasMissingProperty)
          {
          }
        flagHasMissingProperty = true;
        storeMissingProperty = new_value;
      }
    public void unsetMissingProperty()
      {
        if (flagHasMissingProperty)
          {
          }
        flagHasMissingProperty = false;
      }

    public virtual void extraGeometryShapePropertyQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGeometryShapePropertyQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGeometryShapePropertyQueryStateLookup(key);
        if (old_field == null)
          {
            extraGeometryShapePropertyQueryStateAppendPair(key, new_component);
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
                    case TypeQueryTypeKnownValues.QueryType_WhatIs:
                        handler.string_value("WhatIs");
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
        Debug.Assert(partial_allowed || flagHasQueryStatus);
        if (flagHasQueryStatus)
          {
            handler.start_pair("QueryStatus");
            if (storeQueryStatus.in_known_list)
              {
                switch (storeQueryStatus.list_value)
                  {
                    case TypeQueryStatusKnownValues.QueryStatus_Valid:
                        handler.string_value("Valid");
                        break;
                    case TypeQueryStatusKnownValues.QueryStatus_ErrorUndefinedShape:
                        handler.string_value("ErrorUndefinedShape");
                        break;
                    case TypeQueryStatusKnownValues.QueryStatus_ErrorIllegalRequestedProperty:
                        handler.string_value("ErrorIllegalRequestedProperty");
                        break;
                    case TypeQueryStatusKnownValues.QueryStatus_ErrorIllegalGivenProperty:
                        handler.string_value("ErrorIllegalGivenProperty");
                        break;
                    case TypeQueryStatusKnownValues.QueryStatus_ErrorMissingProperty:
                        handler.string_value("ErrorMissingProperty");
                        break;
                    case TypeQueryStatusKnownValues.QueryStatus_ErrorAbstractShape:
                        handler.string_value("ErrorAbstractShape");
                        break;
                    case TypeQueryStatusKnownValues.QueryStatus_ErrorConflictingProperties:
                        handler.string_value("ErrorConflictingProperties");
                        break;
                    case TypeQueryStatusKnownValues.QueryStatus_Unknown:
                        handler.string_value("Unknown");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeQueryStatus.string_value);
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
        if (flagHasMissingProperty)
          {
            handler.start_pair("MissingProperty");
            if (partial_allowed)
                storeMissingProperty.write_partial_as_json(handler);
            else
                storeMissingProperty.write_as_json(handler);
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
        if (!(hasQueryStatus()))
          {
            return "When parsing the object for %what%, the \"QueryStatus\" field was missing.";
          }
        if (!(hasShapeName()))
          {
            return "When parsing the object for %what%, the \"ShapeName\" field was missing.";
          }
        return null;
      }

    public static GeometryShapePropertyQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeometryShapePropertyQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryShapePropertyQueryState", ignore_extras);
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
    public static GeometryShapePropertyQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeometryShapePropertyQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeometryShapePropertyQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryShapePropertyQueryState", ignore_extras);
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
    public static GeometryShapePropertyQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeometryShapePropertyQueryStateJSON from_text(string text, bool ignore_extras)
      {
        GeometryShapePropertyQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryShapePropertyQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeometryShapePropertyQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static GeometryShapePropertyQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeometryShapePropertyQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeometryShapePropertyQueryState", ignore_extras);
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
    private abstract class FieldGeneratorQueryStatus : JSONStringGenerator
          {
            protected FieldGeneratorQueryStatus(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorQueryStatus()
              {
              }
            protected override void handle_result(string result)
              {
                TypeQueryStatusKnownValues known = stringToQueryStatus(result);
                TypeQueryStatus new_value = new TypeQueryStatus();
                if (known == TypeQueryStatusKnownValues.QueryStatus__none)
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
            protected abstract void handle_result(TypeQueryStatus result);
          };
    private class FieldHoldingGeneratorQueryStatus : FieldGeneratorQueryStatus
  {
    protected override void handle_result(TypeQueryStatus result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorQueryStatus(String what)
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
    public TypeQueryStatus value;
  };
    private class FieldHoldingArrayGeneratorQueryStatus : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorQueryStatus
      {
        private FieldHoldingArrayGeneratorQueryStatus top;

        protected override void handle_result(TypeQueryStatus result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorQueryStatus init_top)
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
    protected virtual void handle_result(List<TypeQueryStatus> result)
      {
      }

    public FieldHoldingArrayGeneratorQueryStatus(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryStatus>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorQueryStatus()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeQueryStatus>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeQueryStatus> value;
  };
        private FieldHoldingGeneratorQueryStatus fieldGeneratorQueryStatus;
        private JSONHoldingStringGenerator fieldGeneratorShapeName;
        private GeometryShapePropertyJSON.HoldingArrayGenerator fieldGeneratorGivenProperties;
        private GeometryShapePropertyJSON.HoldingGenerator fieldGeneratorRequestedProperty;
        private GeometryShapePropertyJSON.HoldingGenerator fieldGeneratorIllegalProperty;
        private GeometryShapePropertyJSON.HoldingGenerator fieldGeneratorMissingProperty;
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
            GeometryShapePropertyQueryStateJSON result = new GeometryShapePropertyQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGeometryShapePropertyQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(GeometryShapePropertyQueryStateJSON result)
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
            if (fieldGeneratorQueryStatus.have_value)
              {
                result.setQueryStatus(fieldGeneratorQueryStatus.value);
                fieldGeneratorQueryStatus.have_value = false;
              }
            else if ((!(result.hasQueryStatus())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"QueryStatus\" field was missing.");
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
            if (fieldGeneratorMissingProperty.have_value)
              {
                result.setMissingProperty(fieldGeneratorMissingProperty.value);
                fieldGeneratorMissingProperty.have_value = false;
              }
          }
        protected abstract void handle_result(GeometryShapePropertyQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'G':
                    if ((String.Compare(field_name, 1, "ivenProperties", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorGivenProperties;
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "llegalProperty", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorIllegalProperty;
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "issingProperty", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorMissingProperty;
                    break;
                case 'Q':
                    if (String.Compare(field_name, 1, "uery", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'S':
                                if ((String.Compare(field_name, 6, "tatus", 0, 5, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorQueryStatus;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 6, "ype", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorQueryType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestedProperty", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorRequestedProperty;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "hapeName", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorShapeName;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the GeometryShapePropertyQueryState class");
            fieldGeneratorQueryStatus = new FieldHoldingGeneratorQueryStatus("field \"QueryStatus\" of the GeometryShapePropertyQueryState class");
            fieldGeneratorShapeName = new JSONHoldingStringGenerator("field \"ShapeName\" of the GeometryShapePropertyQueryState class");
            fieldGeneratorGivenProperties = new GeometryShapePropertyJSON.HoldingArrayGenerator("field \"GivenProperties\" of the GeometryShapePropertyQueryState class", ignore_extras);
            fieldGeneratorRequestedProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"RequestedProperty\" of the GeometryShapePropertyQueryState class", ignore_extras);
            fieldGeneratorIllegalProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"IllegalProperty\" of the GeometryShapePropertyQueryState class", ignore_extras);
            fieldGeneratorMissingProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"MissingProperty\" of the GeometryShapePropertyQueryState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GeometryShapePropertyQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorQueryType = new FieldHoldingGeneratorQueryType("field \"QueryType\" of the GeometryShapePropertyQueryState class");
            fieldGeneratorQueryStatus = new FieldHoldingGeneratorQueryStatus("field \"QueryStatus\" of the GeometryShapePropertyQueryState class");
            fieldGeneratorShapeName = new JSONHoldingStringGenerator("field \"ShapeName\" of the GeometryShapePropertyQueryState class");
            fieldGeneratorGivenProperties = new GeometryShapePropertyJSON.HoldingArrayGenerator("field \"GivenProperties\" of the GeometryShapePropertyQueryState class", false);
            fieldGeneratorRequestedProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"RequestedProperty\" of the GeometryShapePropertyQueryState class", false);
            fieldGeneratorIllegalProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"IllegalProperty\" of the GeometryShapePropertyQueryState class", false);
            fieldGeneratorMissingProperty = new GeometryShapePropertyJSON.HoldingGenerator("field \"MissingProperty\" of the GeometryShapePropertyQueryState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GeometryShapePropertyQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorQueryType.reset();
            fieldGeneratorQueryStatus.reset();
            fieldGeneratorShapeName.reset();
            fieldGeneratorGivenProperties.reset();
            fieldGeneratorRequestedProperty.reset();
            fieldGeneratorIllegalProperty.reset();
            fieldGeneratorMissingProperty.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorGivenProperties.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestedProperty.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorIllegalProperty.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMissingProperty.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorGivenProperties.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestedProperty.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorIllegalProperty.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMissingProperty.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(GeometryShapePropertyQueryStateJSON  result)
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
        public GeometryShapePropertyQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeometryShapePropertyQueryStateJSON  result)
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
    protected virtual void handle_result(List<GeometryShapePropertyQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeometryShapePropertyQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeometryShapePropertyQueryStateJSON>();
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
    public List<GeometryShapePropertyQueryStateJSON> value;
  };
  };
