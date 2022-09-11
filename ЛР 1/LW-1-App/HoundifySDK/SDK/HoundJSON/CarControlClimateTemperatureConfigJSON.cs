/* file "CarControlClimateTemperatureConfigJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarControlClimateTemperatureConfigJSON : JSONBase
  {
    public enum TypeUnit
      {
        Unit_C,
        Unit_F
      };

    public static TypeUnit  stringToUnit(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if (chars.Length == 1)
                    return TypeUnit.Unit_C;
                break;
            case 'F':
                if (chars.Length == 1)
                    return TypeUnit.Unit_F;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `Unit' is not one of the legal values.");
      }

    public static string  stringFromUnit(TypeUnit the_enum)
      {
        switch (the_enum)
          {
            case TypeUnit.Unit_C:
                return "C";
            case TypeUnit.Unit_F:
                return "F";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasUnit;
    private TypeUnit storeUnit;
    private bool flagHasIncrement;
    private double storeIncrement;
    private string textStoreIncrement;
    private bool flagHasIncrementSlightly;
    private double storeIncrementSlightly;
    private string textStoreIncrementSlightly;
    private bool flagHasIncrementStrongly;
    private double storeIncrementStrongly;
    private string textStoreIncrementStrongly;
    private bool flagHasColdest;
    private double storeColdest;
    private string textStoreColdest;
    private bool flagHasCold;
    private double storeCold;
    private string textStoreCold;
    private bool flagHasCool;
    private double storeCool;
    private string textStoreCool;
    private bool flagHasMedium;
    private double storeMedium;
    private string textStoreMedium;
    private bool flagHasWarm;
    private double storeWarm;
    private string textStoreWarm;
    private bool flagHasHot;
    private double storeHot;
    private string textStoreHot;
    private bool flagHasHottest;
    private double storeHottest;
    private string textStoreHottest;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONUnit(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Unit of CarControlClimateTemperatureConfigJSON is not a string.");
        TypeUnit the_enum;
        switch (json_string.getData()[0])
          {
            case 'C':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeUnit.Unit_C;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeUnit.Unit_F;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field Unit of CarControlClimateTemperatureConfigJSON is not one of the legal strings.");
      enum_is_done:;
        setUnit(the_enum);
      }


    private void  fromJSONIncrement(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Increment of CarControlClimateTemperatureConfigJSON is not a number.");
              }
          }
        setIncrementText(the_rational_text);
      }


    private void  fromJSONIncrementSlightly(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IncrementSlightly of CarControlClimateTemperatureConfigJSON is not a number.");
              }
          }
        setIncrementSlightlyText(the_rational_text);
      }


    private void  fromJSONIncrementStrongly(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IncrementStrongly of CarControlClimateTemperatureConfigJSON is not a number.");
              }
          }
        setIncrementStronglyText(the_rational_text);
      }


    private void  fromJSONColdest(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Coldest of CarControlClimateTemperatureConfigJSON is not a number.");
              }
          }
        setColdestText(the_rational_text);
      }


    private void  fromJSONCold(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Cold of CarControlClimateTemperatureConfigJSON is not a number.");
              }
          }
        setColdText(the_rational_text);
      }


    private void  fromJSONCool(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Cool of CarControlClimateTemperatureConfigJSON is not a number.");
              }
          }
        setCoolText(the_rational_text);
      }


    private void  fromJSONMedium(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Medium of CarControlClimateTemperatureConfigJSON is not a number.");
              }
          }
        setMediumText(the_rational_text);
      }


    private void  fromJSONWarm(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Warm of CarControlClimateTemperatureConfigJSON is not a number.");
              }
          }
        setWarmText(the_rational_text);
      }


    private void  fromJSONHot(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Hot of CarControlClimateTemperatureConfigJSON is not a number.");
              }
          }
        setHotText(the_rational_text);
      }


    private void  fromJSONHottest(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Hottest of CarControlClimateTemperatureConfigJSON is not a number.");
              }
          }
        setHottestText(the_rational_text);
      }


    public CarControlClimateTemperatureConfigJSON()
      {
        flagHasUnit = false;
        flagHasIncrement = false;
        flagHasIncrementSlightly = false;
        flagHasIncrementStrongly = false;
        flagHasColdest = false;
        flagHasCold = false;
        flagHasCool = false;
        flagHasMedium = false;
        flagHasWarm = false;
        flagHasHot = false;
        flagHasHottest = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasUnit()
      {
        return flagHasUnit;
      }

    public TypeUnit  getUnit()
      {
        Debug.Assert(flagHasUnit);
        return storeUnit;
      }

    public string  getUnitAsString()
      {
        return stringFromUnit(getUnit());
      }

    public bool  hasIncrement()
      {
        return flagHasIncrement;
      }

    public double  getIncrement()
      {
        Debug.Assert(flagHasIncrement);
        if (textStoreIncrement != "")
          {
            return Double.Parse(textStoreIncrement);
          }
        return storeIncrement;
      }

    public string  getIncrementAsText()
      {
        Debug.Assert(flagHasIncrement);
        if (textStoreIncrement == "")
          {
            return Convert.ToString(storeIncrement);
          }
        else
          {
            return (textStoreIncrement);
          }
      }

    public bool  hasIncrementSlightly()
      {
        return flagHasIncrementSlightly;
      }

    public double  getIncrementSlightly()
      {
        Debug.Assert(flagHasIncrementSlightly);
        if (textStoreIncrementSlightly != "")
          {
            return Double.Parse(textStoreIncrementSlightly);
          }
        return storeIncrementSlightly;
      }

    public string  getIncrementSlightlyAsText()
      {
        Debug.Assert(flagHasIncrementSlightly);
        if (textStoreIncrementSlightly == "")
          {
            return Convert.ToString(storeIncrementSlightly);
          }
        else
          {
            return (textStoreIncrementSlightly);
          }
      }

    public bool  hasIncrementStrongly()
      {
        return flagHasIncrementStrongly;
      }

    public double  getIncrementStrongly()
      {
        Debug.Assert(flagHasIncrementStrongly);
        if (textStoreIncrementStrongly != "")
          {
            return Double.Parse(textStoreIncrementStrongly);
          }
        return storeIncrementStrongly;
      }

    public string  getIncrementStronglyAsText()
      {
        Debug.Assert(flagHasIncrementStrongly);
        if (textStoreIncrementStrongly == "")
          {
            return Convert.ToString(storeIncrementStrongly);
          }
        else
          {
            return (textStoreIncrementStrongly);
          }
      }

    public bool  hasColdest()
      {
        return flagHasColdest;
      }

    public double  getColdest()
      {
        Debug.Assert(flagHasColdest);
        if (textStoreColdest != "")
          {
            return Double.Parse(textStoreColdest);
          }
        return storeColdest;
      }

    public string  getColdestAsText()
      {
        Debug.Assert(flagHasColdest);
        if (textStoreColdest == "")
          {
            return Convert.ToString(storeColdest);
          }
        else
          {
            return (textStoreColdest);
          }
      }

    public bool  hasCold()
      {
        return flagHasCold;
      }

    public double  getCold()
      {
        Debug.Assert(flagHasCold);
        if (textStoreCold != "")
          {
            return Double.Parse(textStoreCold);
          }
        return storeCold;
      }

    public string  getColdAsText()
      {
        Debug.Assert(flagHasCold);
        if (textStoreCold == "")
          {
            return Convert.ToString(storeCold);
          }
        else
          {
            return (textStoreCold);
          }
      }

    public bool  hasCool()
      {
        return flagHasCool;
      }

    public double  getCool()
      {
        Debug.Assert(flagHasCool);
        if (textStoreCool != "")
          {
            return Double.Parse(textStoreCool);
          }
        return storeCool;
      }

    public string  getCoolAsText()
      {
        Debug.Assert(flagHasCool);
        if (textStoreCool == "")
          {
            return Convert.ToString(storeCool);
          }
        else
          {
            return (textStoreCool);
          }
      }

    public bool  hasMedium()
      {
        return flagHasMedium;
      }

    public double  getMedium()
      {
        Debug.Assert(flagHasMedium);
        if (textStoreMedium != "")
          {
            return Double.Parse(textStoreMedium);
          }
        return storeMedium;
      }

    public string  getMediumAsText()
      {
        Debug.Assert(flagHasMedium);
        if (textStoreMedium == "")
          {
            return Convert.ToString(storeMedium);
          }
        else
          {
            return (textStoreMedium);
          }
      }

    public bool  hasWarm()
      {
        return flagHasWarm;
      }

    public double  getWarm()
      {
        Debug.Assert(flagHasWarm);
        if (textStoreWarm != "")
          {
            return Double.Parse(textStoreWarm);
          }
        return storeWarm;
      }

    public string  getWarmAsText()
      {
        Debug.Assert(flagHasWarm);
        if (textStoreWarm == "")
          {
            return Convert.ToString(storeWarm);
          }
        else
          {
            return (textStoreWarm);
          }
      }

    public bool  hasHot()
      {
        return flagHasHot;
      }

    public double  getHot()
      {
        Debug.Assert(flagHasHot);
        if (textStoreHot != "")
          {
            return Double.Parse(textStoreHot);
          }
        return storeHot;
      }

    public string  getHotAsText()
      {
        Debug.Assert(flagHasHot);
        if (textStoreHot == "")
          {
            return Convert.ToString(storeHot);
          }
        else
          {
            return (textStoreHot);
          }
      }

    public bool  hasHottest()
      {
        return flagHasHottest;
      }

    public double  getHottest()
      {
        Debug.Assert(flagHasHottest);
        if (textStoreHottest != "")
          {
            return Double.Parse(textStoreHottest);
          }
        return storeHottest;
      }

    public string  getHottestAsText()
      {
        Debug.Assert(flagHasHottest);
        if (textStoreHottest == "")
          {
            return Convert.ToString(storeHottest);
          }
        else
          {
            return (textStoreHottest);
          }
      }


    public virtual int extraCarControlClimateTemperatureConfigComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarControlClimateTemperatureConfigComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarControlClimateTemperatureConfigComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarControlClimateTemperatureConfigLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setUnit(TypeUnit new_value)
      {
        flagHasUnit = true;
        storeUnit = new_value;
      }
    public void setUnit(string chars)
      {
        setUnit(stringToUnit(chars));
      }
    public void unsetUnit()
      {
        flagHasUnit = false;
      }
    public void setIncrement(double new_value)
      {
        flagHasIncrement = true;
        storeIncrement = new_value;
        textStoreIncrement = "";
      }
    public void setIncrementText(string new_value)
      {
        flagHasIncrement = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Increment of CarControlClimateTemperatureConfigJSON is not a valid number.");
        textStoreIncrement = new_value;
      }
    public void unsetIncrement()
      {
        flagHasIncrement = false;
      }
    public void setIncrementSlightly(double new_value)
      {
        flagHasIncrementSlightly = true;
        storeIncrementSlightly = new_value;
        textStoreIncrementSlightly = "";
      }
    public void setIncrementSlightlyText(string new_value)
      {
        flagHasIncrementSlightly = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field IncrementSlightly of CarControlClimateTemperatureConfigJSON is not a valid number.");
        textStoreIncrementSlightly = new_value;
      }
    public void unsetIncrementSlightly()
      {
        flagHasIncrementSlightly = false;
      }
    public void setIncrementStrongly(double new_value)
      {
        flagHasIncrementStrongly = true;
        storeIncrementStrongly = new_value;
        textStoreIncrementStrongly = "";
      }
    public void setIncrementStronglyText(string new_value)
      {
        flagHasIncrementStrongly = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field IncrementStrongly of CarControlClimateTemperatureConfigJSON is not a valid number.");
        textStoreIncrementStrongly = new_value;
      }
    public void unsetIncrementStrongly()
      {
        flagHasIncrementStrongly = false;
      }
    public void setColdest(double new_value)
      {
        flagHasColdest = true;
        storeColdest = new_value;
        textStoreColdest = "";
      }
    public void setColdestText(string new_value)
      {
        flagHasColdest = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Coldest of CarControlClimateTemperatureConfigJSON is not a valid number.");
        textStoreColdest = new_value;
      }
    public void unsetColdest()
      {
        flagHasColdest = false;
      }
    public void setCold(double new_value)
      {
        flagHasCold = true;
        storeCold = new_value;
        textStoreCold = "";
      }
    public void setColdText(string new_value)
      {
        flagHasCold = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Cold of CarControlClimateTemperatureConfigJSON is not a valid number.");
        textStoreCold = new_value;
      }
    public void unsetCold()
      {
        flagHasCold = false;
      }
    public void setCool(double new_value)
      {
        flagHasCool = true;
        storeCool = new_value;
        textStoreCool = "";
      }
    public void setCoolText(string new_value)
      {
        flagHasCool = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Cool of CarControlClimateTemperatureConfigJSON is not a valid number.");
        textStoreCool = new_value;
      }
    public void unsetCool()
      {
        flagHasCool = false;
      }
    public void setMedium(double new_value)
      {
        flagHasMedium = true;
        storeMedium = new_value;
        textStoreMedium = "";
      }
    public void setMediumText(string new_value)
      {
        flagHasMedium = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Medium of CarControlClimateTemperatureConfigJSON is not a valid number.");
        textStoreMedium = new_value;
      }
    public void unsetMedium()
      {
        flagHasMedium = false;
      }
    public void setWarm(double new_value)
      {
        flagHasWarm = true;
        storeWarm = new_value;
        textStoreWarm = "";
      }
    public void setWarmText(string new_value)
      {
        flagHasWarm = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Warm of CarControlClimateTemperatureConfigJSON is not a valid number.");
        textStoreWarm = new_value;
      }
    public void unsetWarm()
      {
        flagHasWarm = false;
      }
    public void setHot(double new_value)
      {
        flagHasHot = true;
        storeHot = new_value;
        textStoreHot = "";
      }
    public void setHotText(string new_value)
      {
        flagHasHot = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Hot of CarControlClimateTemperatureConfigJSON is not a valid number.");
        textStoreHot = new_value;
      }
    public void unsetHot()
      {
        flagHasHot = false;
      }
    public void setHottest(double new_value)
      {
        flagHasHottest = true;
        storeHottest = new_value;
        textStoreHottest = "";
      }
    public void setHottestText(string new_value)
      {
        flagHasHottest = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field Hottest of CarControlClimateTemperatureConfigJSON is not a valid number.");
        textStoreHottest = new_value;
      }
    public void unsetHottest()
      {
        flagHasHottest = false;
      }

    public virtual void extraCarControlClimateTemperatureConfigAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarControlClimateTemperatureConfigSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarControlClimateTemperatureConfigLookup(key);
        if (old_field == null)
          {
            extraCarControlClimateTemperatureConfigAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasUnit);
        if (flagHasUnit)
          {
            handler.start_pair("Unit");
            switch (storeUnit)
              {
                case TypeUnit.Unit_C:
                    handler.string_value("C");
                    break;
                case TypeUnit.Unit_F:
                    handler.string_value("F");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasIncrement)
          {
            handler.start_pair("Increment");
            if (textStoreIncrement != "")
                handler.number_value(textStoreIncrement);
            else if (((double)(long)storeIncrement) == storeIncrement)
                handler.number_value((long)storeIncrement);
            else
                handler.number_value(storeIncrement);
          }
        if (flagHasIncrementSlightly)
          {
            handler.start_pair("IncrementSlightly");
            if (textStoreIncrementSlightly != "")
                handler.number_value(textStoreIncrementSlightly);
            else if (((double)(long)storeIncrementSlightly) == storeIncrementSlightly)
                handler.number_value((long)storeIncrementSlightly);
            else
                handler.number_value(storeIncrementSlightly);
          }
        if (flagHasIncrementStrongly)
          {
            handler.start_pair("IncrementStrongly");
            if (textStoreIncrementStrongly != "")
                handler.number_value(textStoreIncrementStrongly);
            else if (((double)(long)storeIncrementStrongly) == storeIncrementStrongly)
                handler.number_value((long)storeIncrementStrongly);
            else
                handler.number_value(storeIncrementStrongly);
          }
        if (flagHasColdest)
          {
            handler.start_pair("Coldest");
            if (textStoreColdest != "")
                handler.number_value(textStoreColdest);
            else if (((double)(long)storeColdest) == storeColdest)
                handler.number_value((long)storeColdest);
            else
                handler.number_value(storeColdest);
          }
        if (flagHasCold)
          {
            handler.start_pair("Cold");
            if (textStoreCold != "")
                handler.number_value(textStoreCold);
            else if (((double)(long)storeCold) == storeCold)
                handler.number_value((long)storeCold);
            else
                handler.number_value(storeCold);
          }
        if (flagHasCool)
          {
            handler.start_pair("Cool");
            if (textStoreCool != "")
                handler.number_value(textStoreCool);
            else if (((double)(long)storeCool) == storeCool)
                handler.number_value((long)storeCool);
            else
                handler.number_value(storeCool);
          }
        if (flagHasMedium)
          {
            handler.start_pair("Medium");
            if (textStoreMedium != "")
                handler.number_value(textStoreMedium);
            else if (((double)(long)storeMedium) == storeMedium)
                handler.number_value((long)storeMedium);
            else
                handler.number_value(storeMedium);
          }
        if (flagHasWarm)
          {
            handler.start_pair("Warm");
            if (textStoreWarm != "")
                handler.number_value(textStoreWarm);
            else if (((double)(long)storeWarm) == storeWarm)
                handler.number_value((long)storeWarm);
            else
                handler.number_value(storeWarm);
          }
        if (flagHasHot)
          {
            handler.start_pair("Hot");
            if (textStoreHot != "")
                handler.number_value(textStoreHot);
            else if (((double)(long)storeHot) == storeHot)
                handler.number_value((long)storeHot);
            else
                handler.number_value(storeHot);
          }
        if (flagHasHottest)
          {
            handler.start_pair("Hottest");
            if (textStoreHottest != "")
                handler.number_value(textStoreHottest);
            else if (((double)(long)storeHottest) == storeHottest)
                handler.number_value((long)storeHottest);
            else
                handler.number_value(storeHottest);
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
        if (!(hasUnit()))
          {
            return "When parsing the object for %what%, the \"Unit\" field was missing.";
          }
        return null;
      }

    public static CarControlClimateTemperatureConfigJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlClimateTemperatureConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlClimateTemperatureConfig", ignore_extras);
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
    public static CarControlClimateTemperatureConfigJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarControlClimateTemperatureConfigJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarControlClimateTemperatureConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlClimateTemperatureConfig", ignore_extras);
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
    public static CarControlClimateTemperatureConfigJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarControlClimateTemperatureConfigJSON from_text(string text, bool ignore_extras)
      {
        CarControlClimateTemperatureConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlClimateTemperatureConfig", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarControlClimateTemperatureConfigJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CarControlClimateTemperatureConfigJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarControlClimateTemperatureConfigJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarControlClimateTemperatureConfig", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private abstract class FieldGeneratorUnit : JSONStringGenerator
          {
            protected FieldGeneratorUnit(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorUnit()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToUnit(result));
              }
            protected abstract void handle_result(TypeUnit result);
          };
    private class FieldHoldingGeneratorUnit : FieldGeneratorUnit
  {
    protected override void handle_result(TypeUnit result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorUnit(String what)
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
    public TypeUnit value;
  };
    private class FieldHoldingArrayGeneratorUnit : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorUnit
      {
        private FieldHoldingArrayGeneratorUnit top;

        protected override void handle_result(TypeUnit result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorUnit init_top)
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
    protected virtual void handle_result(List<TypeUnit> result)
      {
      }

    public FieldHoldingArrayGeneratorUnit(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnit>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorUnit()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeUnit>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeUnit> value;
  };
        private FieldHoldingGeneratorUnit fieldGeneratorUnit;
        private JSONHoldingNumberTextGenerator fieldGeneratorIncrement;
        private JSONHoldingNumberTextGenerator fieldGeneratorIncrementSlightly;
        private JSONHoldingNumberTextGenerator fieldGeneratorIncrementStrongly;
        private JSONHoldingNumberTextGenerator fieldGeneratorColdest;
        private JSONHoldingNumberTextGenerator fieldGeneratorCold;
        private JSONHoldingNumberTextGenerator fieldGeneratorCool;
        private JSONHoldingNumberTextGenerator fieldGeneratorMedium;
        private JSONHoldingNumberTextGenerator fieldGeneratorWarm;
        private JSONHoldingNumberTextGenerator fieldGeneratorHot;
        private JSONHoldingNumberTextGenerator fieldGeneratorHottest;
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
            CarControlClimateTemperatureConfigJSON result = new CarControlClimateTemperatureConfigJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarControlClimateTemperatureConfigAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CarControlClimateTemperatureConfigJSON result)
          {
            if (fieldGeneratorUnit.have_value)
              {
                result.setUnit(fieldGeneratorUnit.value);
                fieldGeneratorUnit.have_value = false;
              }
            else if ((!(result.hasUnit())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Unit\" field was missing.");
              }
            if (fieldGeneratorIncrement.have_value)
              {
                result.setIncrementText(fieldGeneratorIncrement.value);
                fieldGeneratorIncrement.have_value = false;
              }
            if (fieldGeneratorIncrementSlightly.have_value)
              {
                result.setIncrementSlightlyText(fieldGeneratorIncrementSlightly.value);
                fieldGeneratorIncrementSlightly.have_value = false;
              }
            if (fieldGeneratorIncrementStrongly.have_value)
              {
                result.setIncrementStronglyText(fieldGeneratorIncrementStrongly.value);
                fieldGeneratorIncrementStrongly.have_value = false;
              }
            if (fieldGeneratorColdest.have_value)
              {
                result.setColdestText(fieldGeneratorColdest.value);
                fieldGeneratorColdest.have_value = false;
              }
            if (fieldGeneratorCold.have_value)
              {
                result.setColdText(fieldGeneratorCold.value);
                fieldGeneratorCold.have_value = false;
              }
            if (fieldGeneratorCool.have_value)
              {
                result.setCoolText(fieldGeneratorCool.value);
                fieldGeneratorCool.have_value = false;
              }
            if (fieldGeneratorMedium.have_value)
              {
                result.setMediumText(fieldGeneratorMedium.value);
                fieldGeneratorMedium.have_value = false;
              }
            if (fieldGeneratorWarm.have_value)
              {
                result.setWarmText(fieldGeneratorWarm.value);
                fieldGeneratorWarm.have_value = false;
              }
            if (fieldGeneratorHot.have_value)
              {
                result.setHotText(fieldGeneratorHot.value);
                fieldGeneratorHot.have_value = false;
              }
            if (fieldGeneratorHottest.have_value)
              {
                result.setHottestText(fieldGeneratorHottest.value);
                fieldGeneratorHottest.have_value = false;
              }
          }
        protected abstract void handle_result(CarControlClimateTemperatureConfigJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if (String.Compare(field_name, 1, "o", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'l':
                                if (String.Compare(field_name, 3, "d", 0, 1, false) == 0)
                                  {
                                    if (field_name.Length == 4)
                                      {
                                        return fieldGeneratorCold;
                                      }
                                    switch (field_name[4])
                                      {
                                        case 'e':
                                            if ((String.Compare(field_name, 5, "st", 0, 2, false) == 0) && (field_name.Length == 7))
                                                return fieldGeneratorColdest;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 3, "l", 0, 1, false) == 0) && (field_name.Length == 4))
                                    return fieldGeneratorCool;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'H':
                    if (String.Compare(field_name, 1, "ot", 0, 2, false) == 0)
                      {
                        if (field_name.Length == 3)
                          {
                            return fieldGeneratorHot;
                          }
                        switch (field_name[3])
                          {
                            case 't':
                                if ((String.Compare(field_name, 4, "est", 0, 3, false) == 0) && (field_name.Length == 7))
                                    return fieldGeneratorHottest;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "ncrement", 0, 8, false) == 0)
                      {
                        if (field_name.Length == 9)
                          {
                            return fieldGeneratorIncrement;
                          }
                        switch (field_name[9])
                          {
                            case 'S':
                                switch (field_name[10])
                                  {
                                    case 'l':
                                        if ((String.Compare(field_name, 11, "ightly", 0, 6, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorIncrementSlightly;
                                        break;
                                    case 't':
                                        if ((String.Compare(field_name, 11, "rongly", 0, 6, false) == 0) && (field_name.Length == 17))
                                            return fieldGeneratorIncrementStrongly;
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
                case 'M':
                    if ((String.Compare(field_name, 1, "edium", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorMedium;
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nit", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorUnit;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "arm", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorWarm;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorIncrement = new JSONHoldingNumberTextGenerator("field \"Increment\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorIncrementSlightly = new JSONHoldingNumberTextGenerator("field \"IncrementSlightly\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorIncrementStrongly = new JSONHoldingNumberTextGenerator("field \"IncrementStrongly\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorColdest = new JSONHoldingNumberTextGenerator("field \"Coldest\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorCold = new JSONHoldingNumberTextGenerator("field \"Cold\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorCool = new JSONHoldingNumberTextGenerator("field \"Cool\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorMedium = new JSONHoldingNumberTextGenerator("field \"Medium\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorWarm = new JSONHoldingNumberTextGenerator("field \"Warm\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorHot = new JSONHoldingNumberTextGenerator("field \"Hot\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorHottest = new JSONHoldingNumberTextGenerator("field \"Hottest\" of the CarControlClimateTemperatureConfig class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarControlClimateTemperatureConfig class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorUnit = new FieldHoldingGeneratorUnit("field \"Unit\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorIncrement = new JSONHoldingNumberTextGenerator("field \"Increment\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorIncrementSlightly = new JSONHoldingNumberTextGenerator("field \"IncrementSlightly\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorIncrementStrongly = new JSONHoldingNumberTextGenerator("field \"IncrementStrongly\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorColdest = new JSONHoldingNumberTextGenerator("field \"Coldest\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorCold = new JSONHoldingNumberTextGenerator("field \"Cold\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorCool = new JSONHoldingNumberTextGenerator("field \"Cool\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorMedium = new JSONHoldingNumberTextGenerator("field \"Medium\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorWarm = new JSONHoldingNumberTextGenerator("field \"Warm\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorHot = new JSONHoldingNumberTextGenerator("field \"Hot\" of the CarControlClimateTemperatureConfig class");
            fieldGeneratorHottest = new JSONHoldingNumberTextGenerator("field \"Hottest\" of the CarControlClimateTemperatureConfig class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarControlClimateTemperatureConfig class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorUnit.reset();
            fieldGeneratorIncrement.reset();
            fieldGeneratorIncrementSlightly.reset();
            fieldGeneratorIncrementStrongly.reset();
            fieldGeneratorColdest.reset();
            fieldGeneratorCold.reset();
            fieldGeneratorCool.reset();
            fieldGeneratorMedium.reset();
            fieldGeneratorWarm.reset();
            fieldGeneratorHot.reset();
            fieldGeneratorHottest.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(CarControlClimateTemperatureConfigJSON  result)
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
        public CarControlClimateTemperatureConfigJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarControlClimateTemperatureConfigJSON  result)
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
    protected virtual void handle_result(List<CarControlClimateTemperatureConfigJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarControlClimateTemperatureConfigJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarControlClimateTemperatureConfigJSON>();
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
    public List<CarControlClimateTemperatureConfigJSON> value;
  };
  };
