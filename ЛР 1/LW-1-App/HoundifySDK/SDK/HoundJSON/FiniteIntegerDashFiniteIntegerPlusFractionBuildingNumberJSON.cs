/* file "FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON : BuildingNumberJSON
  {
    private bool flagHasFirst;
    private BigInteger storeFirst;
    private bool flagHasFirstDigitCount;
    private BigInteger storeFirstDigitCount;
    private bool flagHasSecond;
    private BigInteger storeSecond;
    private bool flagHasSecondDigitCount;
    private BigInteger storeSecondDigitCount;
    private bool flagHasFractionNumerator;
    private BigInteger storeFractionNumerator;
    private bool flagHasFractionDenominator;
    private BigInteger storeFractionDenominator;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraFirstToJSON()
      {
        JSONIntegerValue generated_integer_First = new JSONIntegerValue(storeFirst);
        return generated_integer_First;
      }

    private JSONValue  extraFirstDigitCountToJSON()
      {
        JSONIntegerValue generated_integer_FirstDigitCount = new JSONIntegerValue(storeFirstDigitCount);
        return generated_integer_FirstDigitCount;
      }

    private JSONValue  extraSecondToJSON()
      {
        JSONIntegerValue generated_integer_Second = new JSONIntegerValue(storeSecond);
        return generated_integer_Second;
      }

    private JSONValue  extraSecondDigitCountToJSON()
      {
        JSONIntegerValue generated_integer_SecondDigitCount = new JSONIntegerValue(storeSecondDigitCount);
        return generated_integer_SecondDigitCount;
      }

    private JSONValue  extraFractionNumeratorToJSON()
      {
        JSONIntegerValue generated_integer_FractionNumerator = new JSONIntegerValue(storeFractionNumerator);
        return generated_integer_FractionNumerator;
      }

    private JSONValue  extraFractionDenominatorToJSON()
      {
        JSONIntegerValue generated_integer_FractionDenominator = new JSONIntegerValue(storeFractionDenominator);
        return generated_integer_FractionDenominator;
      }


    private void  fromJSONFirst(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field First of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field First of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFirst(extracted_integer);
      }


    private void  fromJSONFirstDigitCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FirstDigitCount of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FirstDigitCount of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFirstDigitCount(extracted_integer);
      }


    private void  fromJSONSecond(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field Second of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field Second of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSecond(extracted_integer);
      }


    private void  fromJSONSecondDigitCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field SecondDigitCount of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field SecondDigitCount of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setSecondDigitCount(extracted_integer);
      }


    private void  fromJSONFractionNumerator(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FractionNumerator of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FractionNumerator of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFractionNumerator(extracted_integer);
      }


    private void  fromJSONFractionDenominator(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FractionDenominator of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FractionDenominator of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFractionDenominator(extracted_integer);
      }


    public FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON()
      {
        flagHasFirst = false;
        flagHasFirstDigitCount = false;
        flagHasSecond = false;
        flagHasSecondDigitCount = false;
        flagHasFractionNumerator = false;
        flagHasFractionDenominator = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getKind()
      {
        return "FiniteIntegerDashFiniteIntegerPlusFraction";
      }

    public bool  hasFirst()
      {
        return flagHasFirst;
      }

    public BigInteger  getFirst()
      {
        Debug.Assert(flagHasFirst);
        return storeFirst;
      }

    public bool  hasFirstDigitCount()
      {
        return flagHasFirstDigitCount;
      }

    public BigInteger  getFirstDigitCount()
      {
        Debug.Assert(flagHasFirstDigitCount);
        return storeFirstDigitCount;
      }

    public bool  hasSecond()
      {
        return flagHasSecond;
      }

    public BigInteger  getSecond()
      {
        Debug.Assert(flagHasSecond);
        return storeSecond;
      }

    public bool  hasSecondDigitCount()
      {
        return flagHasSecondDigitCount;
      }

    public BigInteger  getSecondDigitCount()
      {
        Debug.Assert(flagHasSecondDigitCount);
        return storeSecondDigitCount;
      }

    public bool  hasFractionNumerator()
      {
        return flagHasFractionNumerator;
      }

    public BigInteger  getFractionNumerator()
      {
        Debug.Assert(flagHasFractionNumerator);
        return storeFractionNumerator;
      }

    public bool  hasFractionDenominator()
      {
        return flagHasFractionDenominator;
      }

    public BigInteger  getFractionDenominator()
      {
        Debug.Assert(flagHasFractionDenominator);
        return storeFractionDenominator;
      }


    public virtual int extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraBuildingNumberComponentCount()
      {
        int result = 0;
        if (flagHasFirst)
            ++result;
        if (flagHasFirstDigitCount)
            ++result;
        if (flagHasSecond)
            ++result;
        if (flagHasSecondDigitCount)
            ++result;
        if (flagHasFractionNumerator)
            ++result;
        if (flagHasFractionDenominator)
            ++result;
        result += extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberComponentCount();
        return result;
      }
    public override string extraBuildingNumberComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasFirst)
          {
            if (remainder == 0)
                return "First";
            --remainder;
          }
        if (flagHasFirstDigitCount)
          {
            if (remainder == 0)
                return "FirstDigitCount";
            --remainder;
          }
        if (flagHasSecond)
          {
            if (remainder == 0)
                return "Second";
            --remainder;
          }
        if (flagHasSecondDigitCount)
          {
            if (remainder == 0)
                return "SecondDigitCount";
            --remainder;
          }
        if (flagHasFractionNumerator)
          {
            if (remainder == 0)
                return "FractionNumerator";
            --remainder;
          }
        if (flagHasFractionDenominator)
          {
            if (remainder == 0)
                return "FractionDenominator";
            --remainder;
          }
        return extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberComponentKey(remainder);
      }
    public override JSONValue extraBuildingNumberComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasFirst)
          {
            if (remainder == 0)
                return extraFirstToJSON();
            --remainder;
          }
        if (flagHasFirstDigitCount)
          {
            if (remainder == 0)
                return extraFirstDigitCountToJSON();
            --remainder;
          }
        if (flagHasSecond)
          {
            if (remainder == 0)
                return extraSecondToJSON();
            --remainder;
          }
        if (flagHasSecondDigitCount)
          {
            if (remainder == 0)
                return extraSecondDigitCountToJSON();
            --remainder;
          }
        if (flagHasFractionNumerator)
          {
            if (remainder == 0)
                return extraFractionNumeratorToJSON();
            --remainder;
          }
        if (flagHasFractionDenominator)
          {
            if (remainder == 0)
                return extraFractionDenominatorToJSON();
            --remainder;
          }
        return extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberComponentValue(remainder);
      }
    public override JSONValue extraBuildingNumberLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'F':
                switch (field_name[1])
                  {
                    case 'i':
                        if (String.Compare(field_name, 2, "rst", 0, 3, false) == 0)
                          {
                            if (field_name.Length == 5)
                              {
                                return (flagHasFirst ? extraFirstToJSON() : null);
                              }
                            switch (field_name[5])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 6, "igitCount", 0, 9, false) == 0) && (field_name.Length == 15))
                                        return (flagHasFirstDigitCount ? extraFirstDigitCountToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(field_name, 2, "action", 0, 6, false) == 0)
                          {
                            switch (field_name[8])
                              {
                                case 'D':
                                    if ((String.Compare(field_name, 9, "enominator", 0, 10, false) == 0) && (field_name.Length == 19))
                                        return (flagHasFractionDenominator ? extraFractionDenominatorToJSON() : null);
                                    break;
                                case 'N':
                                    if ((String.Compare(field_name, 9, "umerator", 0, 8, false) == 0) && (field_name.Length == 17))
                                        return (flagHasFractionNumerator ? extraFractionNumeratorToJSON() : null);
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
                if (String.Compare(field_name, 1, "econd", 0, 5, false) == 0)
                  {
                    if (field_name.Length == 6)
                      {
                        return (flagHasSecond ? extraSecondToJSON() : null);
                      }
                    switch (field_name[6])
                      {
                        case 'D':
                            if ((String.Compare(field_name, 7, "igitCount", 0, 9, false) == 0) && (field_name.Length == 16))
                                return (flagHasSecondDigitCount ? extraSecondDigitCountToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberLookup(field_name);
      }

    public void setFirst(BigInteger new_value)
      {
        flagHasFirst = true;
        storeFirst = new_value;
      }
    public void unsetFirst()
      {
        flagHasFirst = false;
      }
    public void setFirstDigitCount(BigInteger new_value)
      {
        flagHasFirstDigitCount = true;
        if (new_value < 1)
            throw new Exception("The value for field FirstDigitCount of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is less than the lower bound (1) for that field.");
        storeFirstDigitCount = new_value;
      }
    public void unsetFirstDigitCount()
      {
        flagHasFirstDigitCount = false;
      }
    public void setSecond(BigInteger new_value)
      {
        flagHasSecond = true;
        storeSecond = new_value;
      }
    public void unsetSecond()
      {
        flagHasSecond = false;
      }
    public void setSecondDigitCount(BigInteger new_value)
      {
        flagHasSecondDigitCount = true;
        if (new_value < 1)
            throw new Exception("The value for field SecondDigitCount of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is less than the lower bound (1) for that field.");
        storeSecondDigitCount = new_value;
      }
    public void unsetSecondDigitCount()
      {
        flagHasSecondDigitCount = false;
      }
    public void setFractionNumerator(BigInteger new_value)
      {
        flagHasFractionNumerator = true;
        storeFractionNumerator = new_value;
      }
    public void unsetFractionNumerator()
      {
        flagHasFractionNumerator = false;
      }
    public void setFractionDenominator(BigInteger new_value)
      {
        flagHasFractionDenominator = true;
        if (new_value < 1)
            throw new Exception("The value for field FractionDenominator of FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON is less than the lower bound (1) for that field.");
        storeFractionDenominator = new_value;
      }
    public void unsetFractionDenominator()
      {
        flagHasFractionDenominator = false;
      }

    public virtual void extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberLookup(key);
        if (old_field == null)
          {
            extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberAppendPair(key, new_component);
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
    public override void extraBuildingNumberAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'F':
                switch (key[1])
                  {
                    case 'i':
                        if (String.Compare(key, 2, "rst", 0, 3, false) == 0)
                          {
                            if (key.Length == 5)
                              {
                                {
                                fromJSONFirst(new_component, false);
                                return;
                                }
                              }
                            switch (key[5])
                              {
                                case 'D':
                                    if ((String.Compare(key, 6, "igitCount", 0, 9, false) == 0) && (key.Length == 15))
                                        {
                                        fromJSONFirstDigitCount(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(key, 2, "action", 0, 6, false) == 0)
                          {
                            switch (key[8])
                              {
                                case 'D':
                                    if ((String.Compare(key, 9, "enominator", 0, 10, false) == 0) && (key.Length == 19))
                                        {
                                        fromJSONFractionDenominator(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'N':
                                    if ((String.Compare(key, 9, "umerator", 0, 8, false) == 0) && (key.Length == 17))
                                        {
                                        fromJSONFractionNumerator(new_component, false);
                                        return;
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
            case 'S':
                if (String.Compare(key, 1, "econd", 0, 5, false) == 0)
                  {
                    if (key.Length == 6)
                      {
                        {
                        fromJSONSecond(new_component, false);
                        return;
                        }
                      }
                    switch (key[6])
                      {
                        case 'D':
                            if ((String.Compare(key, 7, "igitCount", 0, 9, false) == 0) && (key.Length == 16))
                                {
                                fromJSONSecondDigitCount(new_component, false);
                                return;
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
        extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberAppendPair(key, new_component);
      }
    public override void extraBuildingNumberSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'F':
                switch (key[1])
                  {
                    case 'i':
                        if (String.Compare(key, 2, "rst", 0, 3, false) == 0)
                          {
                            if (key.Length == 5)
                              {
                                {
                                fromJSONFirst(new_component, false);
                                return;
                                }
                              }
                            switch (key[5])
                              {
                                case 'D':
                                    if ((String.Compare(key, 6, "igitCount", 0, 9, false) == 0) && (key.Length == 15))
                                        {
                                        fromJSONFirstDigitCount(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(key, 2, "action", 0, 6, false) == 0)
                          {
                            switch (key[8])
                              {
                                case 'D':
                                    if ((String.Compare(key, 9, "enominator", 0, 10, false) == 0) && (key.Length == 19))
                                        {
                                        fromJSONFractionDenominator(new_component, false);
                                        return;
                                        }
                                    break;
                                case 'N':
                                    if ((String.Compare(key, 9, "umerator", 0, 8, false) == 0) && (key.Length == 17))
                                        {
                                        fromJSONFractionNumerator(new_component, false);
                                        return;
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
            case 'S':
                if (String.Compare(key, 1, "econd", 0, 5, false) == 0)
                  {
                    if (key.Length == 6)
                      {
                        {
                        fromJSONSecond(new_component, false);
                        return;
                        }
                      }
                    switch (key[6])
                      {
                        case 'D':
                            if ((String.Compare(key, 7, "igitCount", 0, 9, false) == 0) && (key.Length == 16))
                                {
                                fromJSONSecondDigitCount(new_component, false);
                                return;
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
        extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFirst);
        if (flagHasFirst)
          {
            handler.start_pair("First");
            handler.number_value(storeFirst);
          }
        if (flagHasFirstDigitCount)
          {
            handler.start_pair("FirstDigitCount");
            handler.number_value(storeFirstDigitCount);
          }
        Debug.Assert(partial_allowed || flagHasSecond);
        if (flagHasSecond)
          {
            handler.start_pair("Second");
            handler.number_value(storeSecond);
          }
        if (flagHasSecondDigitCount)
          {
            handler.start_pair("SecondDigitCount");
            handler.number_value(storeSecondDigitCount);
          }
        Debug.Assert(partial_allowed || flagHasFractionNumerator);
        if (flagHasFractionNumerator)
          {
            handler.start_pair("FractionNumerator");
            handler.number_value(storeFractionNumerator);
          }
        Debug.Assert(partial_allowed || flagHasFractionDenominator);
        if (flagHasFractionDenominator)
          {
            handler.start_pair("FractionDenominator");
            handler.number_value(storeFractionDenominator);
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
        if (!(hasFirst()))
          {
            return "When parsing the object for %what%, the \"First\" field was missing.";
          }
        if (!(hasSecond()))
          {
            return "When parsing the object for %what%, the \"Second\" field was missing.";
          }
        if (!(hasFractionNumerator()))
          {
            return "When parsing the object for %what%, the \"FractionNumerator\" field was missing.";
          }
        if (!(hasFractionDenominator()))
          {
            return "When parsing the object for %what%, the \"FractionDenominator\" field was missing.";
          }
        return null;
      }

    public static new FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber", ignore_extras);
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
    public static new FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber", ignore_extras);
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
    public static new FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON from_text(string text, bool ignore_extras)
      {
        FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : BuildingNumberJSON.Generator
      {
    private class FieldHoldingGeneratorFirst : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorFirst(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorFirst : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorFirst(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorFirst fieldGeneratorFirst;
    private class FieldHoldingGeneratorFirstDigitCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorFirstDigitCount(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorFirstDigitCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorFirstDigitCount(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorFirstDigitCount fieldGeneratorFirstDigitCount;
    private class FieldHoldingGeneratorSecond : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorSecond(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorSecond : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorSecond(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorSecond fieldGeneratorSecond;
    private class FieldHoldingGeneratorSecondDigitCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorSecondDigitCount(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorSecondDigitCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorSecondDigitCount(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorSecondDigitCount fieldGeneratorSecondDigitCount;
    private class FieldHoldingGeneratorFractionNumerator : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorFractionNumerator(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorFractionNumerator : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorFractionNumerator(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorFractionNumerator fieldGeneratorFractionNumerator;
    private class FieldHoldingGeneratorFractionDenominator : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorFractionDenominator(String what) : base(what, (BigInteger)(1))
              {
              }
          };
    private class FieldHoldingArrayGeneratorFractionDenominator : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorFractionDenominator(String what) : base(what, (BigInteger)(1))
              {
              }
          };
        private FieldHoldingGeneratorFractionDenominator fieldGeneratorFractionDenominator;
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
            if (!(getBuildingNumberJSONKey().Equals("FiniteIntegerDashFiniteIntegerPlusFraction")))
                throw new Exception("The key field has a value other than `FiniteIntegerDashFiniteIntegerPlusFraction'.");
            FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON result = new FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(BuildingNumberJSON new_result)
          {
            handle_result((FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON )new_result);
          }
        protected void finish(FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON result)
          {
            if (fieldGeneratorFirst.have_value)
              {
                result.setFirst(fieldGeneratorFirst.value);
                fieldGeneratorFirst.have_value = false;
              }
            else if ((!(result.hasFirst())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"First\" field was missing.");
              }
            if (fieldGeneratorFirstDigitCount.have_value)
              {
                result.setFirstDigitCount(fieldGeneratorFirstDigitCount.value);
                fieldGeneratorFirstDigitCount.have_value = false;
              }
            if (fieldGeneratorSecond.have_value)
              {
                result.setSecond(fieldGeneratorSecond.value);
                fieldGeneratorSecond.have_value = false;
              }
            else if ((!(result.hasSecond())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Second\" field was missing.");
              }
            if (fieldGeneratorSecondDigitCount.have_value)
              {
                result.setSecondDigitCount(fieldGeneratorSecondDigitCount.value);
                fieldGeneratorSecondDigitCount.have_value = false;
              }
            if (fieldGeneratorFractionNumerator.have_value)
              {
                result.setFractionNumerator(fieldGeneratorFractionNumerator.value);
                fieldGeneratorFractionNumerator.have_value = false;
              }
            else if ((!(result.hasFractionNumerator())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FractionNumerator\" field was missing.");
              }
            if (fieldGeneratorFractionDenominator.have_value)
              {
                result.setFractionDenominator(fieldGeneratorFractionDenominator.value);
                fieldGeneratorFractionDenominator.have_value = false;
              }
            else if ((!(result.hasFractionDenominator())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FractionDenominator\" field was missing.");
              }
            base.finish(result);
          }
        protected abstract void handle_result(FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'F':
                    switch (field_name[1])
                      {
                        case 'i':
                            if (String.Compare(field_name, 2, "rst", 0, 3, false) == 0)
                              {
                                if (field_name.Length == 5)
                                  {
                                    return fieldGeneratorFirst;
                                  }
                                switch (field_name[5])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 6, "igitCount", 0, 9, false) == 0) && (field_name.Length == 15))
                                            return fieldGeneratorFirstDigitCount;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "action", 0, 6, false) == 0)
                              {
                                switch (field_name[8])
                                  {
                                    case 'D':
                                        if ((String.Compare(field_name, 9, "enominator", 0, 10, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorFractionDenominator;
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 9, "umerator", 0, 8, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorFractionNumerator;
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
                    if (String.Compare(field_name, 1, "econd", 0, 5, false) == 0)
                      {
                        if (field_name.Length == 6)
                          {
                            return fieldGeneratorSecond;
                          }
                        switch (field_name[6])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 7, "igitCount", 0, 9, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorSecondDigitCount;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorFirst = new FieldHoldingGeneratorFirst("field \"First\" of the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorFirstDigitCount = new FieldHoldingGeneratorFirstDigitCount("field \"FirstDigitCount\" of the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorSecond = new FieldHoldingGeneratorSecond("field \"Second\" of the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorSecondDigitCount = new FieldHoldingGeneratorSecondDigitCount("field \"SecondDigitCount\" of the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorFractionNumerator = new FieldHoldingGeneratorFractionNumerator("field \"FractionNumerator\" of the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorFractionDenominator = new FieldHoldingGeneratorFractionDenominator("field \"FractionDenominator\" of the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorFirst = new FieldHoldingGeneratorFirst("field \"First\" of the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorFirstDigitCount = new FieldHoldingGeneratorFirstDigitCount("field \"FirstDigitCount\" of the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorSecond = new FieldHoldingGeneratorSecond("field \"Second\" of the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorSecondDigitCount = new FieldHoldingGeneratorSecondDigitCount("field \"SecondDigitCount\" of the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorFractionNumerator = new FieldHoldingGeneratorFractionNumerator("field \"FractionNumerator\" of the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
            fieldGeneratorFractionDenominator = new FieldHoldingGeneratorFractionDenominator("field \"FractionDenominator\" of the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumber class");
          }

        public override void reset()
          {
            fieldGeneratorFirst.reset();
            fieldGeneratorFirstDigitCount.reset();
            fieldGeneratorSecond.reset();
            fieldGeneratorSecondDigitCount.reset();
            fieldGeneratorFractionNumerator.reset();
            fieldGeneratorFractionDenominator.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON  result)
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
        public FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON  result)
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
    protected virtual void handle_result(List<FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON>();
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
    public List<FiniteIntegerDashFiniteIntegerPlusFractionBuildingNumberJSON> value;
  };
  };
