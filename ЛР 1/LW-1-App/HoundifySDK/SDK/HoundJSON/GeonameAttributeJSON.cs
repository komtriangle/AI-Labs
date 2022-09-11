/* file "GeonameAttributeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class GeonameAttributeJSON : JSONBase
  {
    public enum TypeAttribute
      {
        Attribute_Population,
        Attribute_Area,
        Attribute_Country,
        Attribute_Code,
        Attribute_Capital,
        Attribute_Continent,
        Attribute_Demonym,
        Attribute_Currency,
        Attribute_TimeZone,
        Attribute_AreaCode,
        Attribute_TLD,
        Attribute_Languages,
        Attribute_Neighbors,
        Attribute_Elevation,
        Attribute_FirstAdministrativeDivision,
        Attribute_SecondAdministrativeDivision,
        Attribute_City
      };

    public static TypeAttribute  stringToAttribute(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if (String.Compare(chars, 1, "rea", 0, 3, false) == 0)
                  {
                    if (chars.Length == 4)
                      {
                        return TypeAttribute.Attribute_Area;
                      }
                    switch (chars[4])
                      {
                        case 'C':
                            if ((String.Compare(chars, 5, "ode", 0, 3, false) == 0) && (chars.Length == 8))
                                return TypeAttribute.Attribute_AreaCode;
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                switch (chars[1])
                  {
                    case 'a':
                        if ((String.Compare(chars, 2, "pital", 0, 5, false) == 0) && (chars.Length == 7))
                            return TypeAttribute.Attribute_Capital;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "ty", 0, 2, false) == 0) && (chars.Length == 4))
                            return TypeAttribute.Attribute_City;
                        break;
                    case 'o':
                        switch (chars[2])
                          {
                            case 'd':
                                if ((String.Compare(chars, 3, "e", 0, 1, false) == 0) && (chars.Length == 4))
                                    return TypeAttribute.Attribute_Code;
                                break;
                            case 'n':
                                if ((String.Compare(chars, 3, "tinent", 0, 6, false) == 0) && (chars.Length == 9))
                                    return TypeAttribute.Attribute_Continent;
                                break;
                            case 'u':
                                if ((String.Compare(chars, 3, "ntry", 0, 4, false) == 0) && (chars.Length == 7))
                                    return TypeAttribute.Attribute_Country;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'u':
                        if ((String.Compare(chars, 2, "rrency", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeAttribute.Attribute_Currency;
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if ((String.Compare(chars, 1, "emonym", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeAttribute.Attribute_Demonym;
                break;
            case 'E':
                if ((String.Compare(chars, 1, "levation", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeAttribute.Attribute_Elevation;
                break;
            case 'F':
                if ((String.Compare(chars, 1, "irstAdministrativeDivision", 0, 26, false) == 0) && (chars.Length == 27))
                    return TypeAttribute.Attribute_FirstAdministrativeDivision;
                break;
            case 'L':
                if ((String.Compare(chars, 1, "anguages", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeAttribute.Attribute_Languages;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "eighbors", 0, 8, false) == 0) && (chars.Length == 9))
                    return TypeAttribute.Attribute_Neighbors;
                break;
            case 'P':
                if ((String.Compare(chars, 1, "opulation", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeAttribute.Attribute_Population;
                break;
            case 'S':
                if ((String.Compare(chars, 1, "econdAdministrativeDivision", 0, 27, false) == 0) && (chars.Length == 28))
                    return TypeAttribute.Attribute_SecondAdministrativeDivision;
                break;
            case 'T':
                switch (chars[1])
                  {
                    case 'L':
                        if ((String.Compare(chars, 2, "D", 0, 1, false) == 0) && (chars.Length == 3))
                            return TypeAttribute.Attribute_TLD;
                        break;
                    case 'i':
                        if ((String.Compare(chars, 2, "meZone", 0, 6, false) == 0) && (chars.Length == 8))
                            return TypeAttribute.Attribute_TimeZone;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Attribute' is not one of the legal values.");
      }

    public static string  stringFromAttribute(TypeAttribute the_enum)
      {
        switch (the_enum)
          {
            case TypeAttribute.Attribute_Population:
                return "Population";
            case TypeAttribute.Attribute_Area:
                return "Area";
            case TypeAttribute.Attribute_Country:
                return "Country";
            case TypeAttribute.Attribute_Code:
                return "Code";
            case TypeAttribute.Attribute_Capital:
                return "Capital";
            case TypeAttribute.Attribute_Continent:
                return "Continent";
            case TypeAttribute.Attribute_Demonym:
                return "Demonym";
            case TypeAttribute.Attribute_Currency:
                return "Currency";
            case TypeAttribute.Attribute_TimeZone:
                return "TimeZone";
            case TypeAttribute.Attribute_AreaCode:
                return "AreaCode";
            case TypeAttribute.Attribute_TLD:
                return "TLD";
            case TypeAttribute.Attribute_Languages:
                return "Languages";
            case TypeAttribute.Attribute_Neighbors:
                return "Neighbors";
            case TypeAttribute.Attribute_Elevation:
                return "Elevation";
            case TypeAttribute.Attribute_FirstAdministrativeDivision:
                return "FirstAdministrativeDivision";
            case TypeAttribute.Attribute_SecondAdministrativeDivision:
                return "SecondAdministrativeDivision";
            case TypeAttribute.Attribute_City:
                return "City";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasGeonameAuxID;
    private BigInteger storeGeonameAuxID;
    private bool flagHasAttributeRequested;
    private bool storeAttributeRequested;
    private bool flagHasAttribute;
    private TypeAttribute storeAttribute;
    private bool flagHasAttributeAuxID;
    private List< BigInteger > storeAttributeAuxID;
    private bool flagHasAttributeValueSpokenForm;
    private string storeAttributeValueSpokenForm;
    private bool flagHasAttributeValueWrittenForm;
    private string storeAttributeValueWrittenForm;
    private bool flagHasAttributeValueRaw;
    private BigInteger storeAttributeValueRaw;
    private bool flagHasCoreUnitsUnit;
    private CoreUnitsUnitJSON  storeCoreUnitsUnit;
    private bool flagHasCoreUnitsProperty;
    private CoreUnitsPropertyJSON  storeCoreUnitsProperty;
    private bool flagHasAttributeValueIsLong;
    private bool storeAttributeValueIsLong;
    private bool flagHasDateAndOrTime;
    private DateAndOrTimeJSON  storeDateAndOrTime;
    private bool flagHasAttributeDataOutOfDate;
    private bool storeAttributeDataOutOfDate;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONGeonameAuxID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field GeonameAuxID of GeonameAttributeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field GeonameAuxID of GeonameAttributeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setGeonameAuxID(extracted_integer);
      }


    private void  fromJSONAttributeRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AttributeRequested of GeonameAttributeJSON is not true for false.");
              }
          }
        setAttributeRequested(the_bool);
      }


    private void  fromJSONAttribute(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Attribute of GeonameAttributeJSON is not a string.");
        TypeAttribute the_enum;
        switch (json_string.getData()[0])
          {
            case 'A':
                if (String.Compare(json_string.getData(), 1, "rea", 0, 3, false) == 0)
                  {
                    if (json_string.getData().Length == 4)
                      {
                          {
                            the_enum = TypeAttribute.Attribute_Area;
                            goto enum_is_done;
                          }
                      }
                    switch (json_string.getData()[4])
                      {
                        case 'C':
                            if ((String.Compare(json_string.getData(), 5, "ode", 0, 3, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_enum = TypeAttribute.Attribute_AreaCode;
                                    goto enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'C':
                switch (json_string.getData()[1])
                  {
                    case 'a':
                        if ((String.Compare(json_string.getData(), 2, "pital", 0, 5, false) == 0) && (json_string.getData().Length == 7))
                              {
                                the_enum = TypeAttribute.Attribute_Capital;
                                goto enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "ty", 0, 2, false) == 0) && (json_string.getData().Length == 4))
                              {
                                the_enum = TypeAttribute.Attribute_City;
                                goto enum_is_done;
                              }
                        break;
                    case 'o':
                        switch (json_string.getData()[2])
                          {
                            case 'd':
                                if ((String.Compare(json_string.getData(), 3, "e", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                      {
                                        the_enum = TypeAttribute.Attribute_Code;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "tinent", 0, 6, false) == 0) && (json_string.getData().Length == 9))
                                      {
                                        the_enum = TypeAttribute.Attribute_Continent;
                                        goto enum_is_done;
                                      }
                                break;
                            case 'u':
                                if ((String.Compare(json_string.getData(), 3, "ntry", 0, 4, false) == 0) && (json_string.getData().Length == 7))
                                      {
                                        the_enum = TypeAttribute.Attribute_Country;
                                        goto enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'u':
                        if ((String.Compare(json_string.getData(), 2, "rrency", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_enum = TypeAttribute.Attribute_Currency;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "emonym", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeAttribute.Attribute_Demonym;
                        goto enum_is_done;
                      }
                break;
            case 'E':
                if ((String.Compare(json_string.getData(), 1, "levation", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeAttribute.Attribute_Elevation;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "irstAdministrativeDivision", 0, 26, false) == 0) && (json_string.getData().Length == 27))
                      {
                        the_enum = TypeAttribute.Attribute_FirstAdministrativeDivision;
                        goto enum_is_done;
                      }
                break;
            case 'L':
                if ((String.Compare(json_string.getData(), 1, "anguages", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeAttribute.Attribute_Languages;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "eighbors", 0, 8, false) == 0) && (json_string.getData().Length == 9))
                      {
                        the_enum = TypeAttribute.Attribute_Neighbors;
                        goto enum_is_done;
                      }
                break;
            case 'P':
                if ((String.Compare(json_string.getData(), 1, "opulation", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeAttribute.Attribute_Population;
                        goto enum_is_done;
                      }
                break;
            case 'S':
                if ((String.Compare(json_string.getData(), 1, "econdAdministrativeDivision", 0, 27, false) == 0) && (json_string.getData().Length == 28))
                      {
                        the_enum = TypeAttribute.Attribute_SecondAdministrativeDivision;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                switch (json_string.getData()[1])
                  {
                    case 'L':
                        if ((String.Compare(json_string.getData(), 2, "D", 0, 1, false) == 0) && (json_string.getData().Length == 3))
                              {
                                the_enum = TypeAttribute.Attribute_TLD;
                                goto enum_is_done;
                              }
                        break;
                    case 'i':
                        if ((String.Compare(json_string.getData(), 2, "meZone", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                              {
                                the_enum = TypeAttribute.Attribute_TimeZone;
                                goto enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Attribute of GeonameAttributeJSON is not one of the legal strings.");
      enum_is_done:;
        setAttribute(the_enum);
      }


    private void  fromJSONAttributeAuxID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AttributeAuxID of GeonameAttributeJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< BigInteger > vector_AttributeAuxID1 = new List< BigInteger >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            BigInteger extracted_integer;
            JSONIntegerValue json_integer = json_array1.component(num1).integer_value();
            if (json_integer == null)
              {
                JSONRationalValue json_rational = json_array1.component(num1).rational_value();
                if (json_rational == null)
                  {
                    throw new Exception("The value for an element of field AttributeAuxID of GeonameAttributeJSON is not a number.");
                  }
                if (!(json_rational.isInteger()))
                  {
                    throw new Exception("The value for an element of field AttributeAuxID of GeonameAttributeJSON is not an integer.");
                  }
                extracted_integer = json_rational.getInteger()            ;
              }
            else
              {
                extracted_integer = json_integer.getData()            ;
              }
            vector_AttributeAuxID1.Add(extracted_integer);
          }
        initAttributeAuxID();
        for (int num1 = 0; num1 < vector_AttributeAuxID1.Count; ++num1)
            appendAttributeAuxID(vector_AttributeAuxID1[num1]);
        for (int num1 = 0; num1 < vector_AttributeAuxID1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAttributeValueSpokenForm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AttributeValueSpokenForm of GeonameAttributeJSON is not a string.");
        setAttributeValueSpokenForm(json_string.getData());
      }


    private void  fromJSONAttributeValueWrittenForm(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AttributeValueWrittenForm of GeonameAttributeJSON is not a string.");
        setAttributeValueWrittenForm(json_string.getData());
      }


    private void  fromJSONAttributeValueRaw(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AttributeValueRaw of GeonameAttributeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AttributeValueRaw of GeonameAttributeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAttributeValueRaw(extracted_integer);
      }


    private void  fromJSONCoreUnitsUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CoreUnitsUnitJSON convert_classy = CoreUnitsUnitJSON.from_json(json_value, ignore_extras, true);
        setCoreUnitsUnit(convert_classy);
      }


    private void  fromJSONCoreUnitsProperty(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        CoreUnitsPropertyJSON convert_classy = CoreUnitsPropertyJSON.from_json(json_value, ignore_extras, true);
        setCoreUnitsProperty(convert_classy);
      }


    private void  fromJSONAttributeValueIsLong(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AttributeValueIsLong of GeonameAttributeJSON is not true for false.");
              }
          }
        setAttributeValueIsLong(the_bool);
      }


    private void  fromJSONDateAndOrTime(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
        setDateAndOrTime(convert_classy);
      }


    private void  fromJSONAttributeDataOutOfDate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AttributeDataOutOfDate of GeonameAttributeJSON is not true for false.");
              }
          }
        setAttributeDataOutOfDate(the_bool);
      }


    public GeonameAttributeJSON()
      {
        flagHasGeonameAuxID = false;
        flagHasAttributeRequested = false;
        flagHasAttribute = false;
        flagHasAttributeAuxID = false;
        flagHasAttributeValueSpokenForm = false;
        flagHasAttributeValueWrittenForm = false;
        flagHasAttributeValueRaw = false;
        flagHasCoreUnitsUnit = false;
        flagHasCoreUnitsProperty = false;
        flagHasAttributeValueIsLong = false;
        flagHasDateAndOrTime = false;
        flagHasAttributeDataOutOfDate = false;
        storeAttributeAuxID = new List< BigInteger >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasGeonameAuxID()
      {
        return flagHasGeonameAuxID;
      }

    public BigInteger  getGeonameAuxID()
      {
        Debug.Assert(flagHasGeonameAuxID);
        return storeGeonameAuxID;
      }

    public bool  hasAttributeRequested()
      {
        return flagHasAttributeRequested;
      }

    public bool  getAttributeRequested()
      {
        Debug.Assert(flagHasAttributeRequested);
        return storeAttributeRequested;
      }

    public bool  hasAttribute()
      {
        return flagHasAttribute;
      }

    public TypeAttribute  getAttribute()
      {
        Debug.Assert(flagHasAttribute);
        return storeAttribute;
      }

    public string  getAttributeAsString()
      {
        return stringFromAttribute(getAttribute());
      }

    public bool  hasAttributeAuxID()
      {
        return flagHasAttributeAuxID;
      }

    public int  countOfAttributeAuxID()
      {
        Debug.Assert(flagHasAttributeAuxID);
        return storeAttributeAuxID.Count;
      }

    public BigInteger  elementOfAttributeAuxID(int element_num)
      {
        Debug.Assert(flagHasAttributeAuxID);
        return storeAttributeAuxID[element_num];
      }

    public List< BigInteger >  getAttributeAuxID()
      {
        Debug.Assert(flagHasAttributeAuxID);
        return storeAttributeAuxID;
      }

    public bool  hasAttributeValueSpokenForm()
      {
        return flagHasAttributeValueSpokenForm;
      }

    public string  getAttributeValueSpokenForm()
      {
        Debug.Assert(flagHasAttributeValueSpokenForm);
        return storeAttributeValueSpokenForm;
      }

    public bool  hasAttributeValueWrittenForm()
      {
        return flagHasAttributeValueWrittenForm;
      }

    public string  getAttributeValueWrittenForm()
      {
        Debug.Assert(flagHasAttributeValueWrittenForm);
        return storeAttributeValueWrittenForm;
      }

    public bool  hasAttributeValueRaw()
      {
        return flagHasAttributeValueRaw;
      }

    public BigInteger  getAttributeValueRaw()
      {
        Debug.Assert(flagHasAttributeValueRaw);
        return storeAttributeValueRaw;
      }

    public bool  hasCoreUnitsUnit()
      {
        return flagHasCoreUnitsUnit;
      }

    public CoreUnitsUnitJSON   getCoreUnitsUnit()
      {
        Debug.Assert(flagHasCoreUnitsUnit);
        return storeCoreUnitsUnit;
      }

    public bool  hasCoreUnitsProperty()
      {
        return flagHasCoreUnitsProperty;
      }

    public CoreUnitsPropertyJSON   getCoreUnitsProperty()
      {
        Debug.Assert(flagHasCoreUnitsProperty);
        return storeCoreUnitsProperty;
      }

    public bool  hasAttributeValueIsLong()
      {
        return flagHasAttributeValueIsLong;
      }

    public bool  getAttributeValueIsLong()
      {
        Debug.Assert(flagHasAttributeValueIsLong);
        return storeAttributeValueIsLong;
      }

    public bool  hasDateAndOrTime()
      {
        return flagHasDateAndOrTime;
      }

    public DateAndOrTimeJSON   getDateAndOrTime()
      {
        Debug.Assert(flagHasDateAndOrTime);
        return storeDateAndOrTime;
      }

    public bool  hasAttributeDataOutOfDate()
      {
        return flagHasAttributeDataOutOfDate;
      }

    public bool  getAttributeDataOutOfDate()
      {
        Debug.Assert(flagHasAttributeDataOutOfDate);
        return storeAttributeDataOutOfDate;
      }


    public virtual int extraGeonameAttributeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraGeonameAttributeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraGeonameAttributeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraGeonameAttributeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setGeonameAuxID(BigInteger new_value)
      {
        flagHasGeonameAuxID = true;
        if (new_value < 0)
            throw new Exception("The value for field GeonameAuxID of GeonameAttributeJSON is less than the lower bound (0) for that field.");
        storeGeonameAuxID = new_value;
      }
    public void unsetGeonameAuxID()
      {
        flagHasGeonameAuxID = false;
      }
    public void setAttributeRequested(bool new_value)
      {
        flagHasAttributeRequested = true;
        storeAttributeRequested = new_value;
      }
    public void unsetAttributeRequested()
      {
        flagHasAttributeRequested = false;
      }
    public void setAttribute(TypeAttribute new_value)
      {
        flagHasAttribute = true;
        storeAttribute = new_value;
      }
    public void setAttribute(string chars)
      {
        setAttribute(stringToAttribute(chars));
      }
    public void unsetAttribute()
      {
        flagHasAttribute = false;
      }
    public void initAttributeAuxID()
      {
        flagHasAttributeAuxID = true;
        storeAttributeAuxID.Clear();
      }
    public void appendAttributeAuxID(BigInteger to_append)
      {
        if (!flagHasAttributeAuxID)
          {
            flagHasAttributeAuxID = true;
            storeAttributeAuxID.Clear();
          }
        Debug.Assert(flagHasAttributeAuxID);
        storeAttributeAuxID.Add(to_append);
      }
    public void unsetAttributeAuxID()
      {
        flagHasAttributeAuxID = false;
        storeAttributeAuxID.Clear();
      }
    public void setAttributeValueSpokenForm(string new_value)
      {
        flagHasAttributeValueSpokenForm = true;
        storeAttributeValueSpokenForm = new_value;
      }
    public void unsetAttributeValueSpokenForm()
      {
        flagHasAttributeValueSpokenForm = false;
      }
    public void setAttributeValueWrittenForm(string new_value)
      {
        flagHasAttributeValueWrittenForm = true;
        storeAttributeValueWrittenForm = new_value;
      }
    public void unsetAttributeValueWrittenForm()
      {
        flagHasAttributeValueWrittenForm = false;
      }
    public void setAttributeValueRaw(BigInteger new_value)
      {
        flagHasAttributeValueRaw = true;
        storeAttributeValueRaw = new_value;
      }
    public void unsetAttributeValueRaw()
      {
        flagHasAttributeValueRaw = false;
      }
    public void setCoreUnitsUnit(CoreUnitsUnitJSON  new_value)
      {
        if (flagHasCoreUnitsUnit)
          {
          }
        flagHasCoreUnitsUnit = true;
        storeCoreUnitsUnit = new_value;
      }
    public void unsetCoreUnitsUnit()
      {
        if (flagHasCoreUnitsUnit)
          {
          }
        flagHasCoreUnitsUnit = false;
      }
    public void setCoreUnitsProperty(CoreUnitsPropertyJSON  new_value)
      {
        if (flagHasCoreUnitsProperty)
          {
          }
        flagHasCoreUnitsProperty = true;
        storeCoreUnitsProperty = new_value;
      }
    public void unsetCoreUnitsProperty()
      {
        if (flagHasCoreUnitsProperty)
          {
          }
        flagHasCoreUnitsProperty = false;
      }
    public void setAttributeValueIsLong(bool new_value)
      {
        flagHasAttributeValueIsLong = true;
        storeAttributeValueIsLong = new_value;
      }
    public void unsetAttributeValueIsLong()
      {
        flagHasAttributeValueIsLong = false;
      }
    public void setDateAndOrTime(DateAndOrTimeJSON  new_value)
      {
        if (flagHasDateAndOrTime)
          {
          }
        flagHasDateAndOrTime = true;
        storeDateAndOrTime = new_value;
      }
    public void unsetDateAndOrTime()
      {
        if (flagHasDateAndOrTime)
          {
          }
        flagHasDateAndOrTime = false;
      }
    public void setAttributeDataOutOfDate(bool new_value)
      {
        flagHasAttributeDataOutOfDate = true;
        storeAttributeDataOutOfDate = new_value;
      }
    public void unsetAttributeDataOutOfDate()
      {
        flagHasAttributeDataOutOfDate = false;
      }

    public virtual void extraGeonameAttributeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraGeonameAttributeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraGeonameAttributeLookup(key);
        if (old_field == null)
          {
            extraGeonameAttributeAppendPair(key, new_component);
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
        if (flagHasGeonameAuxID)
          {
            handler.start_pair("GeonameAuxID");
            handler.number_value(storeGeonameAuxID);
          }
        if (flagHasAttributeRequested)
          {
            handler.start_pair("AttributeRequested");
            handler.boolean_value(storeAttributeRequested);
          }
        if (flagHasAttribute)
          {
            handler.start_pair("Attribute");
            switch (storeAttribute)
              {
                case TypeAttribute.Attribute_Population:
                    handler.string_value("Population");
                    break;
                case TypeAttribute.Attribute_Area:
                    handler.string_value("Area");
                    break;
                case TypeAttribute.Attribute_Country:
                    handler.string_value("Country");
                    break;
                case TypeAttribute.Attribute_Code:
                    handler.string_value("Code");
                    break;
                case TypeAttribute.Attribute_Capital:
                    handler.string_value("Capital");
                    break;
                case TypeAttribute.Attribute_Continent:
                    handler.string_value("Continent");
                    break;
                case TypeAttribute.Attribute_Demonym:
                    handler.string_value("Demonym");
                    break;
                case TypeAttribute.Attribute_Currency:
                    handler.string_value("Currency");
                    break;
                case TypeAttribute.Attribute_TimeZone:
                    handler.string_value("TimeZone");
                    break;
                case TypeAttribute.Attribute_AreaCode:
                    handler.string_value("AreaCode");
                    break;
                case TypeAttribute.Attribute_TLD:
                    handler.string_value("TLD");
                    break;
                case TypeAttribute.Attribute_Languages:
                    handler.string_value("Languages");
                    break;
                case TypeAttribute.Attribute_Neighbors:
                    handler.string_value("Neighbors");
                    break;
                case TypeAttribute.Attribute_Elevation:
                    handler.string_value("Elevation");
                    break;
                case TypeAttribute.Attribute_FirstAdministrativeDivision:
                    handler.string_value("FirstAdministrativeDivision");
                    break;
                case TypeAttribute.Attribute_SecondAdministrativeDivision:
                    handler.string_value("SecondAdministrativeDivision");
                    break;
                case TypeAttribute.Attribute_City:
                    handler.string_value("City");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasAttributeAuxID)
          {
            handler.start_pair("AttributeAuxID");
            handler.start_array();
            for (int num1 = 0; num1 < storeAttributeAuxID.Count; ++num1)
              {
                handler.number_value(storeAttributeAuxID[num1]);
              }
            handler.finish_array();
          }
        if (flagHasAttributeValueSpokenForm)
          {
            handler.start_pair("AttributeValueSpokenForm");
            handler.string_value(storeAttributeValueSpokenForm);
          }
        if (flagHasAttributeValueWrittenForm)
          {
            handler.start_pair("AttributeValueWrittenForm");
            handler.string_value(storeAttributeValueWrittenForm);
          }
        if (flagHasAttributeValueRaw)
          {
            handler.start_pair("AttributeValueRaw");
            handler.number_value(storeAttributeValueRaw);
          }
        if (flagHasCoreUnitsUnit)
          {
            handler.start_pair("CoreUnitsUnit");
            if (partial_allowed)
                storeCoreUnitsUnit.write_partial_as_json(handler);
            else
                storeCoreUnitsUnit.write_as_json(handler);
          }
        if (flagHasCoreUnitsProperty)
          {
            handler.start_pair("CoreUnitsProperty");
            if (partial_allowed)
                storeCoreUnitsProperty.write_partial_as_json(handler);
            else
                storeCoreUnitsProperty.write_as_json(handler);
          }
        if (flagHasAttributeValueIsLong)
          {
            handler.start_pair("AttributeValueIsLong");
            handler.boolean_value(storeAttributeValueIsLong);
          }
        if (flagHasDateAndOrTime)
          {
            handler.start_pair("DateAndOrTime");
            if (partial_allowed)
                storeDateAndOrTime.write_partial_as_json(handler);
            else
                storeDateAndOrTime.write_as_json(handler);
          }
        if (flagHasAttributeDataOutOfDate)
          {
            handler.start_pair("AttributeDataOutOfDate");
            handler.boolean_value(storeAttributeDataOutOfDate);
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

    public static GeonameAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeonameAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameAttribute", ignore_extras);
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
    public static GeonameAttributeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeonameAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        GeonameAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameAttribute", ignore_extras);
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
    public static GeonameAttributeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static GeonameAttributeJSON from_text(string text, bool ignore_extras)
      {
        GeonameAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameAttribute", ignore_extras);
            JSONParse.parse_json_value(text, "Text for GeonameAttributeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static GeonameAttributeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        GeonameAttributeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type GeonameAttribute", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorGeonameAuxID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorGeonameAuxID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorGeonameAuxID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorGeonameAuxID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorGeonameAuxID fieldGeneratorGeonameAuxID;
        private JSONHoldingBooleanGenerator fieldGeneratorAttributeRequested;
    private abstract class FieldGeneratorAttribute : JSONStringGenerator
          {
            protected FieldGeneratorAttribute(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorAttribute()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToAttribute(result));
              }
            protected abstract void handle_result(TypeAttribute result);
          };
    private class FieldHoldingGeneratorAttribute : FieldGeneratorAttribute
  {
    protected override void handle_result(TypeAttribute result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorAttribute(String what)
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
    public TypeAttribute value;
  };
    private class FieldHoldingArrayGeneratorAttribute : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorAttribute
      {
        private FieldHoldingArrayGeneratorAttribute top;

        protected override void handle_result(TypeAttribute result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorAttribute init_top)
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
    protected virtual void handle_result(List<TypeAttribute> result)
      {
      }

    public FieldHoldingArrayGeneratorAttribute(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAttribute>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorAttribute()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeAttribute>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeAttribute> value;
  };
        private FieldHoldingGeneratorAttribute fieldGeneratorAttribute;
    private class FieldHoldingGeneratorAttributeAuxID : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorAttributeAuxID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorAttributeAuxID : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorAttributeAuxID(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingArrayGeneratorAttributeAuxID fieldGeneratorAttributeAuxID;
        private JSONHoldingStringGenerator fieldGeneratorAttributeValueSpokenForm;
        private JSONHoldingStringGenerator fieldGeneratorAttributeValueWrittenForm;
    private class FieldHoldingGeneratorAttributeValueRaw : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorAttributeValueRaw(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorAttributeValueRaw : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorAttributeValueRaw(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorAttributeValueRaw fieldGeneratorAttributeValueRaw;
        private CoreUnitsUnitJSON.HoldingGenerator fieldGeneratorCoreUnitsUnit;
        private CoreUnitsPropertyJSON.HoldingGenerator fieldGeneratorCoreUnitsProperty;
        private JSONHoldingBooleanGenerator fieldGeneratorAttributeValueIsLong;
        private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorDateAndOrTime;
        private JSONHoldingBooleanGenerator fieldGeneratorAttributeDataOutOfDate;
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
            GeonameAttributeJSON result = new GeonameAttributeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraGeonameAttributeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(GeonameAttributeJSON result)
          {
            if (fieldGeneratorGeonameAuxID.have_value)
              {
                result.setGeonameAuxID(fieldGeneratorGeonameAuxID.value);
                fieldGeneratorGeonameAuxID.have_value = false;
              }
            if (fieldGeneratorAttributeRequested.have_value)
              {
                result.setAttributeRequested(fieldGeneratorAttributeRequested.value);
                fieldGeneratorAttributeRequested.have_value = false;
              }
            if (fieldGeneratorAttribute.have_value)
              {
                result.setAttribute(fieldGeneratorAttribute.value);
                fieldGeneratorAttribute.have_value = false;
              }
            if (fieldGeneratorAttributeAuxID.have_value)
              {
                result.initAttributeAuxID();
                int count = fieldGeneratorAttributeAuxID.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAttributeAuxID(fieldGeneratorAttributeAuxID.value[num]);
                  }
                fieldGeneratorAttributeAuxID.value.Clear();
                fieldGeneratorAttributeAuxID.have_value = false;
              }
            if (fieldGeneratorAttributeValueSpokenForm.have_value)
              {
                result.setAttributeValueSpokenForm(fieldGeneratorAttributeValueSpokenForm.value);
                fieldGeneratorAttributeValueSpokenForm.have_value = false;
              }
            if (fieldGeneratorAttributeValueWrittenForm.have_value)
              {
                result.setAttributeValueWrittenForm(fieldGeneratorAttributeValueWrittenForm.value);
                fieldGeneratorAttributeValueWrittenForm.have_value = false;
              }
            if (fieldGeneratorAttributeValueRaw.have_value)
              {
                result.setAttributeValueRaw(fieldGeneratorAttributeValueRaw.value);
                fieldGeneratorAttributeValueRaw.have_value = false;
              }
            if (fieldGeneratorCoreUnitsUnit.have_value)
              {
                result.setCoreUnitsUnit(fieldGeneratorCoreUnitsUnit.value);
                fieldGeneratorCoreUnitsUnit.have_value = false;
              }
            if (fieldGeneratorCoreUnitsProperty.have_value)
              {
                result.setCoreUnitsProperty(fieldGeneratorCoreUnitsProperty.value);
                fieldGeneratorCoreUnitsProperty.have_value = false;
              }
            if (fieldGeneratorAttributeValueIsLong.have_value)
              {
                result.setAttributeValueIsLong(fieldGeneratorAttributeValueIsLong.value);
                fieldGeneratorAttributeValueIsLong.have_value = false;
              }
            if (fieldGeneratorDateAndOrTime.have_value)
              {
                result.setDateAndOrTime(fieldGeneratorDateAndOrTime.value);
                fieldGeneratorDateAndOrTime.have_value = false;
              }
            if (fieldGeneratorAttributeDataOutOfDate.have_value)
              {
                result.setAttributeDataOutOfDate(fieldGeneratorAttributeDataOutOfDate.value);
                fieldGeneratorAttributeDataOutOfDate.have_value = false;
              }
          }
        protected abstract void handle_result(GeonameAttributeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "ttribute", 0, 8, false) == 0)
                      {
                        if (field_name.Length == 9)
                          {
                            return fieldGeneratorAttribute;
                          }
                        switch (field_name[9])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 10, "uxID", 0, 4, false) == 0) && (field_name.Length == 14))
                                    return fieldGeneratorAttributeAuxID;
                                break;
                            case 'D':
                                if ((String.Compare(field_name, 10, "ataOutOfDate", 0, 12, false) == 0) && (field_name.Length == 22))
                                    return fieldGeneratorAttributeDataOutOfDate;
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 10, "equested", 0, 8, false) == 0) && (field_name.Length == 18))
                                    return fieldGeneratorAttributeRequested;
                                break;
                            case 'V':
                                if (String.Compare(field_name, 10, "alue", 0, 4, false) == 0)
                                  {
                                    switch (field_name[14])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 15, "sLong", 0, 5, false) == 0) && (field_name.Length == 20))
                                                return fieldGeneratorAttributeValueIsLong;
                                            break;
                                        case 'R':
                                            if ((String.Compare(field_name, 15, "aw", 0, 2, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorAttributeValueRaw;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 15, "pokenForm", 0, 9, false) == 0) && (field_name.Length == 24))
                                                return fieldGeneratorAttributeValueSpokenForm;
                                            break;
                                        case 'W':
                                            if ((String.Compare(field_name, 15, "rittenForm", 0, 10, false) == 0) && (field_name.Length == 25))
                                                return fieldGeneratorAttributeValueWrittenForm;
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
                case 'C':
                    if (String.Compare(field_name, 1, "oreUnits", 0, 8, false) == 0)
                      {
                        switch (field_name[9])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 10, "roperty", 0, 7, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorCoreUnitsProperty;
                                break;
                            case 'U':
                                if ((String.Compare(field_name, 10, "nit", 0, 3, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorCoreUnitsUnit;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'D':
                    if ((String.Compare(field_name, 1, "ateAndOrTime", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorDateAndOrTime;
                    break;
                case 'G':
                    if ((String.Compare(field_name, 1, "eonameAuxID", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorGeonameAuxID;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorGeonameAuxID = new FieldHoldingGeneratorGeonameAuxID("field \"GeonameAuxID\" of the GeonameAttribute class");
            fieldGeneratorAttributeRequested = new JSONHoldingBooleanGenerator("field \"AttributeRequested\" of the GeonameAttribute class");
            fieldGeneratorAttribute = new FieldHoldingGeneratorAttribute("field \"Attribute\" of the GeonameAttribute class");
            fieldGeneratorAttributeAuxID = new FieldHoldingArrayGeneratorAttributeAuxID("field \"AttributeAuxID\" of the GeonameAttribute class");
            fieldGeneratorAttributeValueSpokenForm = new JSONHoldingStringGenerator("field \"AttributeValueSpokenForm\" of the GeonameAttribute class");
            fieldGeneratorAttributeValueWrittenForm = new JSONHoldingStringGenerator("field \"AttributeValueWrittenForm\" of the GeonameAttribute class");
            fieldGeneratorAttributeValueRaw = new FieldHoldingGeneratorAttributeValueRaw("field \"AttributeValueRaw\" of the GeonameAttribute class");
            fieldGeneratorCoreUnitsUnit = new CoreUnitsUnitJSON.HoldingGenerator("field \"CoreUnitsUnit\" of the GeonameAttribute class", ignore_extras);
            fieldGeneratorCoreUnitsProperty = new CoreUnitsPropertyJSON.HoldingGenerator("field \"CoreUnitsProperty\" of the GeonameAttribute class", ignore_extras);
            fieldGeneratorAttributeValueIsLong = new JSONHoldingBooleanGenerator("field \"AttributeValueIsLong\" of the GeonameAttribute class");
            fieldGeneratorDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndOrTime\" of the GeonameAttribute class", ignore_extras);
            fieldGeneratorAttributeDataOutOfDate = new JSONHoldingBooleanGenerator("field \"AttributeDataOutOfDate\" of the GeonameAttribute class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the GeonameAttribute class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorGeonameAuxID = new FieldHoldingGeneratorGeonameAuxID("field \"GeonameAuxID\" of the GeonameAttribute class");
            fieldGeneratorAttributeRequested = new JSONHoldingBooleanGenerator("field \"AttributeRequested\" of the GeonameAttribute class");
            fieldGeneratorAttribute = new FieldHoldingGeneratorAttribute("field \"Attribute\" of the GeonameAttribute class");
            fieldGeneratorAttributeAuxID = new FieldHoldingArrayGeneratorAttributeAuxID("field \"AttributeAuxID\" of the GeonameAttribute class");
            fieldGeneratorAttributeValueSpokenForm = new JSONHoldingStringGenerator("field \"AttributeValueSpokenForm\" of the GeonameAttribute class");
            fieldGeneratorAttributeValueWrittenForm = new JSONHoldingStringGenerator("field \"AttributeValueWrittenForm\" of the GeonameAttribute class");
            fieldGeneratorAttributeValueRaw = new FieldHoldingGeneratorAttributeValueRaw("field \"AttributeValueRaw\" of the GeonameAttribute class");
            fieldGeneratorCoreUnitsUnit = new CoreUnitsUnitJSON.HoldingGenerator("field \"CoreUnitsUnit\" of the GeonameAttribute class", false);
            fieldGeneratorCoreUnitsProperty = new CoreUnitsPropertyJSON.HoldingGenerator("field \"CoreUnitsProperty\" of the GeonameAttribute class", false);
            fieldGeneratorAttributeValueIsLong = new JSONHoldingBooleanGenerator("field \"AttributeValueIsLong\" of the GeonameAttribute class");
            fieldGeneratorDateAndOrTime = new DateAndOrTimeJSON.HoldingGenerator("field \"DateAndOrTime\" of the GeonameAttribute class", false);
            fieldGeneratorAttributeDataOutOfDate = new JSONHoldingBooleanGenerator("field \"AttributeDataOutOfDate\" of the GeonameAttribute class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the GeonameAttribute class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorGeonameAuxID.reset();
            fieldGeneratorAttributeRequested.reset();
            fieldGeneratorAttribute.reset();
            fieldGeneratorAttributeAuxID.reset();
            fieldGeneratorAttributeValueSpokenForm.reset();
            fieldGeneratorAttributeValueWrittenForm.reset();
            fieldGeneratorAttributeValueRaw.reset();
            fieldGeneratorCoreUnitsUnit.reset();
            fieldGeneratorCoreUnitsProperty.reset();
            fieldGeneratorAttributeValueIsLong.reset();
            fieldGeneratorDateAndOrTime.reset();
            fieldGeneratorAttributeDataOutOfDate.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorCoreUnitsUnit.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCoreUnitsProperty.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDateAndOrTime.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorCoreUnitsUnit.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCoreUnitsProperty.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDateAndOrTime.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(GeonameAttributeJSON  result)
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
        public GeonameAttributeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(GeonameAttributeJSON  result)
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
    protected virtual void handle_result(List<GeonameAttributeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<GeonameAttributeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<GeonameAttributeJSON>();
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
    public List<GeonameAttributeJSON> value;
  };
  };
