/* file "CarStatusJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class CarStatusJSON : JSONBase
  {
    public enum TypeCurrentTemperatureUnits
      {
        CurrentTemperatureUnits_C,
        CurrentTemperatureUnits_F
      };

    public static TypeCurrentTemperatureUnits  stringToCurrentTemperatureUnits(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if (chars.Length == 1)
                    return TypeCurrentTemperatureUnits.CurrentTemperatureUnits_C;
                break;
            case 'F':
                if (chars.Length == 1)
                    return TypeCurrentTemperatureUnits.CurrentTemperatureUnits_F;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `CurrentTemperatureUnits' is not one of the legal values.");
      }

    public static string  stringFromCurrentTemperatureUnits(TypeCurrentTemperatureUnits the_enum)
      {
        switch (the_enum)
          {
            case TypeCurrentTemperatureUnits.CurrentTemperatureUnits_C:
                return "C";
            case TypeCurrentTemperatureUnits.CurrentTemperatureUnits_F:
                return "F";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasCurrentTemperature;
    private double storeCurrentTemperature;
    private string textStoreCurrentTemperature;
    private bool flagHasCurrentTemperatureUnits;
    private TypeCurrentTemperatureUnits storeCurrentTemperatureUnits;
    private bool flagHasMaximumHVACTemperature;
    private double storeMaximumHVACTemperature;
    private string textStoreMaximumHVACTemperature;
    private bool flagHasMinimumHVACTemperature;
    private double storeMinimumHVACTemperature;
    private string textStoreMinimumHVACTemperature;
    private bool flagHasDrivingRange;
    private double storeDrivingRange;
    private string textStoreDrivingRange;
    private bool flagHasNavMilesLeft;
    private double storeNavMilesLeft;
    private string textStoreNavMilesLeft;
    private bool flagHasEngineStatus;
    private string storeEngineStatus;
    private bool flagHasCriticalWarning;
    private bool storeCriticalWarning;
    private bool flagHasWarningReason;
    private string storeWarningReason;
    private bool flagHasCarStopped;
    private bool storeCarStopped;
    private bool flagHasCarIsRightHandDrive;
    private bool storeCarIsRightHandDrive;
    private bool flagHasEnableExtendedVentSpecification;
    private bool storeEnableExtendedVentSpecification;
    private bool flagHasEnableDegreeTypeInference;
    private bool storeEnableDegreeTypeInference;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONCurrentTemperature(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CurrentTemperature of CarStatusJSON is not a number.");
              }
          }
        setCurrentTemperatureText(the_rational_text);
      }


    private void  fromJSONCurrentTemperatureUnits(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CurrentTemperatureUnits of CarStatusJSON is not a string.");
        TypeCurrentTemperatureUnits the_enum;
        switch (json_string.getData()[0])
          {
            case 'C':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeCurrentTemperatureUnits.CurrentTemperatureUnits_C;
                        goto enum_is_done;
                      }
                break;
            case 'F':
                if (json_string.getData().Length == 1)
                      {
                        the_enum = TypeCurrentTemperatureUnits.CurrentTemperatureUnits_F;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field CurrentTemperatureUnits of CarStatusJSON is not one of the legal strings.");
      enum_is_done:;
        setCurrentTemperatureUnits(the_enum);
      }


    private void  fromJSONMaximumHVACTemperature(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MaximumHVACTemperature of CarStatusJSON is not a number.");
              }
          }
        setMaximumHVACTemperatureText(the_rational_text);
      }


    private void  fromJSONMinimumHVACTemperature(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field MinimumHVACTemperature of CarStatusJSON is not a number.");
              }
          }
        setMinimumHVACTemperatureText(the_rational_text);
      }


    private void  fromJSONDrivingRange(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field DrivingRange of CarStatusJSON is not a number.");
              }
          }
        setDrivingRangeText(the_rational_text);
      }


    private void  fromJSONNavMilesLeft(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field NavMilesLeft of CarStatusJSON is not a number.");
              }
          }
        setNavMilesLeftText(the_rational_text);
      }


    private void  fromJSONEngineStatus(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field EngineStatus of CarStatusJSON is not a string.");
        setEngineStatus(json_string.getData());
      }


    private void  fromJSONCriticalWarning(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CriticalWarning of CarStatusJSON is not true for false.");
              }
          }
        setCriticalWarning(the_bool);
      }


    private void  fromJSONWarningReason(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field WarningReason of CarStatusJSON is not a string.");
        setWarningReason(json_string.getData());
      }


    private void  fromJSONCarStopped(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CarStopped of CarStatusJSON is not true for false.");
              }
          }
        setCarStopped(the_bool);
      }


    private void  fromJSONCarIsRightHandDrive(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field CarIsRightHandDrive of CarStatusJSON is not true for false.");
              }
          }
        setCarIsRightHandDrive(the_bool);
      }


    private void  fromJSONEnableExtendedVentSpecification(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field EnableExtendedVentSpecification of CarStatusJSON is not true for false.");
              }
          }
        setEnableExtendedVentSpecification(the_bool);
      }


    private void  fromJSONEnableDegreeTypeInference(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field EnableDegreeTypeInference of CarStatusJSON is not true for false.");
              }
          }
        setEnableDegreeTypeInference(the_bool);
      }


    public CarStatusJSON()
      {
        flagHasCurrentTemperature = false;
        flagHasCurrentTemperatureUnits = false;
        flagHasMaximumHVACTemperature = false;
        flagHasMinimumHVACTemperature = false;
        flagHasDrivingRange = false;
        flagHasNavMilesLeft = false;
        flagHasEngineStatus = false;
        flagHasCriticalWarning = false;
        flagHasWarningReason = false;
        flagHasCarStopped = false;
        flagHasCarIsRightHandDrive = false;
        flagHasEnableExtendedVentSpecification = false;
        flagHasEnableDegreeTypeInference = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasCurrentTemperature()
      {
        return flagHasCurrentTemperature;
      }

    public double  getCurrentTemperature()
      {
        Debug.Assert(flagHasCurrentTemperature);
        if (textStoreCurrentTemperature != "")
          {
            return Double.Parse(textStoreCurrentTemperature);
          }
        return storeCurrentTemperature;
      }

    public string  getCurrentTemperatureAsText()
      {
        Debug.Assert(flagHasCurrentTemperature);
        if (textStoreCurrentTemperature == "")
          {
            return Convert.ToString(storeCurrentTemperature);
          }
        else
          {
            return (textStoreCurrentTemperature);
          }
      }

    public bool  hasCurrentTemperatureUnits()
      {
        return flagHasCurrentTemperatureUnits;
      }

    public TypeCurrentTemperatureUnits  getCurrentTemperatureUnits()
      {
        Debug.Assert(flagHasCurrentTemperatureUnits);
        return storeCurrentTemperatureUnits;
      }

    public string  getCurrentTemperatureUnitsAsString()
      {
        return stringFromCurrentTemperatureUnits(getCurrentTemperatureUnits());
      }

    public bool  hasMaximumHVACTemperature()
      {
        return flagHasMaximumHVACTemperature;
      }

    public double  getMaximumHVACTemperature()
      {
        Debug.Assert(flagHasMaximumHVACTemperature);
        if (textStoreMaximumHVACTemperature != "")
          {
            return Double.Parse(textStoreMaximumHVACTemperature);
          }
        return storeMaximumHVACTemperature;
      }

    public string  getMaximumHVACTemperatureAsText()
      {
        Debug.Assert(flagHasMaximumHVACTemperature);
        if (textStoreMaximumHVACTemperature == "")
          {
            return Convert.ToString(storeMaximumHVACTemperature);
          }
        else
          {
            return (textStoreMaximumHVACTemperature);
          }
      }

    public bool  hasMinimumHVACTemperature()
      {
        return flagHasMinimumHVACTemperature;
      }

    public double  getMinimumHVACTemperature()
      {
        Debug.Assert(flagHasMinimumHVACTemperature);
        if (textStoreMinimumHVACTemperature != "")
          {
            return Double.Parse(textStoreMinimumHVACTemperature);
          }
        return storeMinimumHVACTemperature;
      }

    public string  getMinimumHVACTemperatureAsText()
      {
        Debug.Assert(flagHasMinimumHVACTemperature);
        if (textStoreMinimumHVACTemperature == "")
          {
            return Convert.ToString(storeMinimumHVACTemperature);
          }
        else
          {
            return (textStoreMinimumHVACTemperature);
          }
      }

    public bool  hasDrivingRange()
      {
        return flagHasDrivingRange;
      }

    public double  getDrivingRange()
      {
        Debug.Assert(flagHasDrivingRange);
        if (textStoreDrivingRange != "")
          {
            return Double.Parse(textStoreDrivingRange);
          }
        return storeDrivingRange;
      }

    public string  getDrivingRangeAsText()
      {
        Debug.Assert(flagHasDrivingRange);
        if (textStoreDrivingRange == "")
          {
            return Convert.ToString(storeDrivingRange);
          }
        else
          {
            return (textStoreDrivingRange);
          }
      }

    public bool  hasNavMilesLeft()
      {
        return flagHasNavMilesLeft;
      }

    public double  getNavMilesLeft()
      {
        Debug.Assert(flagHasNavMilesLeft);
        if (textStoreNavMilesLeft != "")
          {
            return Double.Parse(textStoreNavMilesLeft);
          }
        return storeNavMilesLeft;
      }

    public string  getNavMilesLeftAsText()
      {
        Debug.Assert(flagHasNavMilesLeft);
        if (textStoreNavMilesLeft == "")
          {
            return Convert.ToString(storeNavMilesLeft);
          }
        else
          {
            return (textStoreNavMilesLeft);
          }
      }

    public bool  hasEngineStatus()
      {
        return flagHasEngineStatus;
      }

    public string  getEngineStatus()
      {
        Debug.Assert(flagHasEngineStatus);
        return storeEngineStatus;
      }

    public bool  hasCriticalWarning()
      {
        return flagHasCriticalWarning;
      }

    public bool  getCriticalWarning()
      {
        Debug.Assert(flagHasCriticalWarning);
        return storeCriticalWarning;
      }

    public bool  hasWarningReason()
      {
        return flagHasWarningReason;
      }

    public string  getWarningReason()
      {
        Debug.Assert(flagHasWarningReason);
        return storeWarningReason;
      }

    public bool  hasCarStopped()
      {
        return flagHasCarStopped;
      }

    public bool  getCarStopped()
      {
        Debug.Assert(flagHasCarStopped);
        return storeCarStopped;
      }

    public bool  hasCarIsRightHandDrive()
      {
        return flagHasCarIsRightHandDrive;
      }

    public bool  getCarIsRightHandDrive()
      {
        Debug.Assert(flagHasCarIsRightHandDrive);
        return storeCarIsRightHandDrive;
      }

    public bool  hasEnableExtendedVentSpecification()
      {
        return flagHasEnableExtendedVentSpecification;
      }

    public bool  getEnableExtendedVentSpecification()
      {
        Debug.Assert(flagHasEnableExtendedVentSpecification);
        return storeEnableExtendedVentSpecification;
      }

    public bool  hasEnableDegreeTypeInference()
      {
        return flagHasEnableDegreeTypeInference;
      }

    public bool  getEnableDegreeTypeInference()
      {
        Debug.Assert(flagHasEnableDegreeTypeInference);
        return storeEnableDegreeTypeInference;
      }


    public virtual int extraCarStatusComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraCarStatusComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraCarStatusComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraCarStatusLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setCurrentTemperature(double new_value)
      {
        flagHasCurrentTemperature = true;
        storeCurrentTemperature = new_value;
        textStoreCurrentTemperature = "";
      }
    public void setCurrentTemperatureText(string new_value)
      {
        flagHasCurrentTemperature = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field CurrentTemperature of CarStatusJSON is not a valid number.");
        textStoreCurrentTemperature = new_value;
      }
    public void unsetCurrentTemperature()
      {
        flagHasCurrentTemperature = false;
      }
    public void setCurrentTemperatureUnits(TypeCurrentTemperatureUnits new_value)
      {
        flagHasCurrentTemperatureUnits = true;
        storeCurrentTemperatureUnits = new_value;
      }
    public void setCurrentTemperatureUnits(string chars)
      {
        setCurrentTemperatureUnits(stringToCurrentTemperatureUnits(chars));
      }
    public void unsetCurrentTemperatureUnits()
      {
        flagHasCurrentTemperatureUnits = false;
      }
    public void setMaximumHVACTemperature(double new_value)
      {
        flagHasMaximumHVACTemperature = true;
        storeMaximumHVACTemperature = new_value;
        textStoreMaximumHVACTemperature = "";
      }
    public void setMaximumHVACTemperatureText(string new_value)
      {
        flagHasMaximumHVACTemperature = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field MaximumHVACTemperature of CarStatusJSON is not a valid number.");
        textStoreMaximumHVACTemperature = new_value;
      }
    public void unsetMaximumHVACTemperature()
      {
        flagHasMaximumHVACTemperature = false;
      }
    public void setMinimumHVACTemperature(double new_value)
      {
        flagHasMinimumHVACTemperature = true;
        storeMinimumHVACTemperature = new_value;
        textStoreMinimumHVACTemperature = "";
      }
    public void setMinimumHVACTemperatureText(string new_value)
      {
        flagHasMinimumHVACTemperature = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field MinimumHVACTemperature of CarStatusJSON is not a valid number.");
        textStoreMinimumHVACTemperature = new_value;
      }
    public void unsetMinimumHVACTemperature()
      {
        flagHasMinimumHVACTemperature = false;
      }
    public void setDrivingRange(double new_value)
      {
        flagHasDrivingRange = true;
        storeDrivingRange = new_value;
        textStoreDrivingRange = "";
      }
    public void setDrivingRangeText(string new_value)
      {
        flagHasDrivingRange = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field DrivingRange of CarStatusJSON is not a valid number.");
        textStoreDrivingRange = new_value;
      }
    public void unsetDrivingRange()
      {
        flagHasDrivingRange = false;
      }
    public void setNavMilesLeft(double new_value)
      {
        flagHasNavMilesLeft = true;
        storeNavMilesLeft = new_value;
        textStoreNavMilesLeft = "";
      }
    public void setNavMilesLeftText(string new_value)
      {
        flagHasNavMilesLeft = true;
        if (!(JSONWriter.is_valid_number_format(new_value)))
            throw new Exception("The text value for field NavMilesLeft of CarStatusJSON is not a valid number.");
        textStoreNavMilesLeft = new_value;
      }
    public void unsetNavMilesLeft()
      {
        flagHasNavMilesLeft = false;
      }
    public void setEngineStatus(string new_value)
      {
        flagHasEngineStatus = true;
        storeEngineStatus = new_value;
      }
    public void unsetEngineStatus()
      {
        flagHasEngineStatus = false;
      }
    public void setCriticalWarning(bool new_value)
      {
        flagHasCriticalWarning = true;
        storeCriticalWarning = new_value;
      }
    public void unsetCriticalWarning()
      {
        flagHasCriticalWarning = false;
      }
    public void setWarningReason(string new_value)
      {
        flagHasWarningReason = true;
        storeWarningReason = new_value;
      }
    public void unsetWarningReason()
      {
        flagHasWarningReason = false;
      }
    public void setCarStopped(bool new_value)
      {
        flagHasCarStopped = true;
        storeCarStopped = new_value;
      }
    public void unsetCarStopped()
      {
        flagHasCarStopped = false;
      }
    public void setCarIsRightHandDrive(bool new_value)
      {
        flagHasCarIsRightHandDrive = true;
        storeCarIsRightHandDrive = new_value;
      }
    public void unsetCarIsRightHandDrive()
      {
        flagHasCarIsRightHandDrive = false;
      }
    public void setEnableExtendedVentSpecification(bool new_value)
      {
        flagHasEnableExtendedVentSpecification = true;
        storeEnableExtendedVentSpecification = new_value;
      }
    public void unsetEnableExtendedVentSpecification()
      {
        flagHasEnableExtendedVentSpecification = false;
      }
    public void setEnableDegreeTypeInference(bool new_value)
      {
        flagHasEnableDegreeTypeInference = true;
        storeEnableDegreeTypeInference = new_value;
      }
    public void unsetEnableDegreeTypeInference()
      {
        flagHasEnableDegreeTypeInference = false;
      }

    public virtual void extraCarStatusAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraCarStatusSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraCarStatusLookup(key);
        if (old_field == null)
          {
            extraCarStatusAppendPair(key, new_component);
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
        if (flagHasCurrentTemperature)
          {
            handler.start_pair("CurrentTemperature");
            if (textStoreCurrentTemperature != "")
                handler.number_value(textStoreCurrentTemperature);
            else if (((double)(long)storeCurrentTemperature) == storeCurrentTemperature)
                handler.number_value((long)storeCurrentTemperature);
            else
                handler.number_value(storeCurrentTemperature);
          }
        if (flagHasCurrentTemperatureUnits)
          {
            handler.start_pair("CurrentTemperatureUnits");
            switch (storeCurrentTemperatureUnits)
              {
                case TypeCurrentTemperatureUnits.CurrentTemperatureUnits_C:
                    handler.string_value("C");
                    break;
                case TypeCurrentTemperatureUnits.CurrentTemperatureUnits_F:
                    handler.string_value("F");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasMaximumHVACTemperature)
          {
            handler.start_pair("MaximumHVACTemperature");
            if (textStoreMaximumHVACTemperature != "")
                handler.number_value(textStoreMaximumHVACTemperature);
            else if (((double)(long)storeMaximumHVACTemperature) == storeMaximumHVACTemperature)
                handler.number_value((long)storeMaximumHVACTemperature);
            else
                handler.number_value(storeMaximumHVACTemperature);
          }
        if (flagHasMinimumHVACTemperature)
          {
            handler.start_pair("MinimumHVACTemperature");
            if (textStoreMinimumHVACTemperature != "")
                handler.number_value(textStoreMinimumHVACTemperature);
            else if (((double)(long)storeMinimumHVACTemperature) == storeMinimumHVACTemperature)
                handler.number_value((long)storeMinimumHVACTemperature);
            else
                handler.number_value(storeMinimumHVACTemperature);
          }
        if (flagHasDrivingRange)
          {
            handler.start_pair("DrivingRange");
            if (textStoreDrivingRange != "")
                handler.number_value(textStoreDrivingRange);
            else if (((double)(long)storeDrivingRange) == storeDrivingRange)
                handler.number_value((long)storeDrivingRange);
            else
                handler.number_value(storeDrivingRange);
          }
        if (flagHasNavMilesLeft)
          {
            handler.start_pair("NavMilesLeft");
            if (textStoreNavMilesLeft != "")
                handler.number_value(textStoreNavMilesLeft);
            else if (((double)(long)storeNavMilesLeft) == storeNavMilesLeft)
                handler.number_value((long)storeNavMilesLeft);
            else
                handler.number_value(storeNavMilesLeft);
          }
        if (flagHasEngineStatus)
          {
            handler.start_pair("EngineStatus");
            handler.string_value(storeEngineStatus);
          }
        if (flagHasCriticalWarning)
          {
            handler.start_pair("CriticalWarning");
            handler.boolean_value(storeCriticalWarning);
          }
        if (flagHasWarningReason)
          {
            handler.start_pair("WarningReason");
            handler.string_value(storeWarningReason);
          }
        if (flagHasCarStopped)
          {
            handler.start_pair("CarStopped");
            handler.boolean_value(storeCarStopped);
          }
        if (flagHasCarIsRightHandDrive)
          {
            handler.start_pair("CarIsRightHandDrive");
            handler.boolean_value(storeCarIsRightHandDrive);
          }
        if (flagHasEnableExtendedVentSpecification)
          {
            handler.start_pair("EnableExtendedVentSpecification");
            handler.boolean_value(storeEnableExtendedVentSpecification);
          }
        if (flagHasEnableDegreeTypeInference)
          {
            handler.start_pair("EnableDegreeTypeInference");
            handler.boolean_value(storeEnableDegreeTypeInference);
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

    public static CarStatusJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarStatus", ignore_extras);
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
    public static CarStatusJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarStatusJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        CarStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarStatus", ignore_extras);
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
    public static CarStatusJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static CarStatusJSON from_text(string text, bool ignore_extras)
      {
        CarStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarStatus", ignore_extras);
            JSONParse.parse_json_value(text, "Text for CarStatusJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static CarStatusJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        CarStatusJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type CarStatus", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingNumberTextGenerator fieldGeneratorCurrentTemperature;
    private abstract class FieldGeneratorCurrentTemperatureUnits : JSONStringGenerator
          {
            protected FieldGeneratorCurrentTemperatureUnits(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCurrentTemperatureUnits()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCurrentTemperatureUnits(result));
              }
            protected abstract void handle_result(TypeCurrentTemperatureUnits result);
          };
    private class FieldHoldingGeneratorCurrentTemperatureUnits : FieldGeneratorCurrentTemperatureUnits
  {
    protected override void handle_result(TypeCurrentTemperatureUnits result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCurrentTemperatureUnits(String what)
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
    public TypeCurrentTemperatureUnits value;
  };
    private class FieldHoldingArrayGeneratorCurrentTemperatureUnits : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCurrentTemperatureUnits
      {
        private FieldHoldingArrayGeneratorCurrentTemperatureUnits top;

        protected override void handle_result(TypeCurrentTemperatureUnits result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCurrentTemperatureUnits init_top)
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
    protected virtual void handle_result(List<TypeCurrentTemperatureUnits> result)
      {
      }

    public FieldHoldingArrayGeneratorCurrentTemperatureUnits(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCurrentTemperatureUnits>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCurrentTemperatureUnits()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCurrentTemperatureUnits>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCurrentTemperatureUnits> value;
  };
        private FieldHoldingGeneratorCurrentTemperatureUnits fieldGeneratorCurrentTemperatureUnits;
        private JSONHoldingNumberTextGenerator fieldGeneratorMaximumHVACTemperature;
        private JSONHoldingNumberTextGenerator fieldGeneratorMinimumHVACTemperature;
        private JSONHoldingNumberTextGenerator fieldGeneratorDrivingRange;
        private JSONHoldingNumberTextGenerator fieldGeneratorNavMilesLeft;
        private JSONHoldingStringGenerator fieldGeneratorEngineStatus;
        private JSONHoldingBooleanGenerator fieldGeneratorCriticalWarning;
        private JSONHoldingStringGenerator fieldGeneratorWarningReason;
        private JSONHoldingBooleanGenerator fieldGeneratorCarStopped;
        private JSONHoldingBooleanGenerator fieldGeneratorCarIsRightHandDrive;
        private JSONHoldingBooleanGenerator fieldGeneratorEnableExtendedVentSpecification;
        private JSONHoldingBooleanGenerator fieldGeneratorEnableDegreeTypeInference;
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
            CarStatusJSON result = new CarStatusJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraCarStatusAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(CarStatusJSON result)
          {
            if (fieldGeneratorCurrentTemperature.have_value)
              {
                result.setCurrentTemperatureText(fieldGeneratorCurrentTemperature.value);
                fieldGeneratorCurrentTemperature.have_value = false;
              }
            if (fieldGeneratorCurrentTemperatureUnits.have_value)
              {
                result.setCurrentTemperatureUnits(fieldGeneratorCurrentTemperatureUnits.value);
                fieldGeneratorCurrentTemperatureUnits.have_value = false;
              }
            if (fieldGeneratorMaximumHVACTemperature.have_value)
              {
                result.setMaximumHVACTemperatureText(fieldGeneratorMaximumHVACTemperature.value);
                fieldGeneratorMaximumHVACTemperature.have_value = false;
              }
            if (fieldGeneratorMinimumHVACTemperature.have_value)
              {
                result.setMinimumHVACTemperatureText(fieldGeneratorMinimumHVACTemperature.value);
                fieldGeneratorMinimumHVACTemperature.have_value = false;
              }
            if (fieldGeneratorDrivingRange.have_value)
              {
                result.setDrivingRangeText(fieldGeneratorDrivingRange.value);
                fieldGeneratorDrivingRange.have_value = false;
              }
            if (fieldGeneratorNavMilesLeft.have_value)
              {
                result.setNavMilesLeftText(fieldGeneratorNavMilesLeft.value);
                fieldGeneratorNavMilesLeft.have_value = false;
              }
            if (fieldGeneratorEngineStatus.have_value)
              {
                result.setEngineStatus(fieldGeneratorEngineStatus.value);
                fieldGeneratorEngineStatus.have_value = false;
              }
            if (fieldGeneratorCriticalWarning.have_value)
              {
                result.setCriticalWarning(fieldGeneratorCriticalWarning.value);
                fieldGeneratorCriticalWarning.have_value = false;
              }
            if (fieldGeneratorWarningReason.have_value)
              {
                result.setWarningReason(fieldGeneratorWarningReason.value);
                fieldGeneratorWarningReason.have_value = false;
              }
            if (fieldGeneratorCarStopped.have_value)
              {
                result.setCarStopped(fieldGeneratorCarStopped.value);
                fieldGeneratorCarStopped.have_value = false;
              }
            if (fieldGeneratorCarIsRightHandDrive.have_value)
              {
                result.setCarIsRightHandDrive(fieldGeneratorCarIsRightHandDrive.value);
                fieldGeneratorCarIsRightHandDrive.have_value = false;
              }
            if (fieldGeneratorEnableExtendedVentSpecification.have_value)
              {
                result.setEnableExtendedVentSpecification(fieldGeneratorEnableExtendedVentSpecification.value);
                fieldGeneratorEnableExtendedVentSpecification.have_value = false;
              }
            if (fieldGeneratorEnableDegreeTypeInference.have_value)
              {
                result.setEnableDegreeTypeInference(fieldGeneratorEnableDegreeTypeInference.value);
                fieldGeneratorEnableDegreeTypeInference.have_value = false;
              }
          }
        protected abstract void handle_result(CarStatusJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    switch (field_name[1])
                      {
                        case 'a':
                            if (String.Compare(field_name, 2, "r", 0, 1, false) == 0)
                              {
                                switch (field_name[3])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 4, "sRightHandDrive", 0, 15, false) == 0) && (field_name.Length == 19))
                                            return fieldGeneratorCarIsRightHandDrive;
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 4, "topped", 0, 6, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorCarStopped;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "iticalWarning", 0, 13, false) == 0) && (field_name.Length == 15))
                                return fieldGeneratorCriticalWarning;
                            break;
                        case 'u':
                            if (String.Compare(field_name, 2, "rrentTemperature", 0, 16, false) == 0)
                              {
                                if (field_name.Length == 18)
                                  {
                                    return fieldGeneratorCurrentTemperature;
                                  }
                                switch (field_name[18])
                                  {
                                    case 'U':
                                        if ((String.Compare(field_name, 19, "nits", 0, 4, false) == 0) && (field_name.Length == 23))
                                            return fieldGeneratorCurrentTemperatureUnits;
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
                case 'D':
                    if ((String.Compare(field_name, 1, "rivingRange", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorDrivingRange;
                    break;
                case 'E':
                    if (String.Compare(field_name, 1, "n", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'a':
                                if (String.Compare(field_name, 3, "ble", 0, 3, false) == 0)
                                  {
                                    switch (field_name[6])
                                      {
                                        case 'D':
                                            if ((String.Compare(field_name, 7, "egreeTypeInference", 0, 18, false) == 0) && (field_name.Length == 25))
                                                return fieldGeneratorEnableDegreeTypeInference;
                                            break;
                                        case 'E':
                                            if ((String.Compare(field_name, 7, "xtendedVentSpecification", 0, 24, false) == 0) && (field_name.Length == 31))
                                                return fieldGeneratorEnableExtendedVentSpecification;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'g':
                                if ((String.Compare(field_name, 3, "ineStatus", 0, 9, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorEngineStatus;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    switch (field_name[1])
                      {
                        case 'a':
                            if ((String.Compare(field_name, 2, "ximumHVACTemperature", 0, 20, false) == 0) && (field_name.Length == 22))
                                return fieldGeneratorMaximumHVACTemperature;
                            break;
                        case 'i':
                            if ((String.Compare(field_name, 2, "nimumHVACTemperature", 0, 20, false) == 0) && (field_name.Length == 22))
                                return fieldGeneratorMinimumHVACTemperature;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "avMilesLeft", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorNavMilesLeft;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "arningReason", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorWarningReason;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorCurrentTemperature = new JSONHoldingNumberTextGenerator("field \"CurrentTemperature\" of the CarStatus class");
            fieldGeneratorCurrentTemperatureUnits = new FieldHoldingGeneratorCurrentTemperatureUnits("field \"CurrentTemperatureUnits\" of the CarStatus class");
            fieldGeneratorMaximumHVACTemperature = new JSONHoldingNumberTextGenerator("field \"MaximumHVACTemperature\" of the CarStatus class");
            fieldGeneratorMinimumHVACTemperature = new JSONHoldingNumberTextGenerator("field \"MinimumHVACTemperature\" of the CarStatus class");
            fieldGeneratorDrivingRange = new JSONHoldingNumberTextGenerator("field \"DrivingRange\" of the CarStatus class");
            fieldGeneratorNavMilesLeft = new JSONHoldingNumberTextGenerator("field \"NavMilesLeft\" of the CarStatus class");
            fieldGeneratorEngineStatus = new JSONHoldingStringGenerator("field \"EngineStatus\" of the CarStatus class");
            fieldGeneratorCriticalWarning = new JSONHoldingBooleanGenerator("field \"CriticalWarning\" of the CarStatus class");
            fieldGeneratorWarningReason = new JSONHoldingStringGenerator("field \"WarningReason\" of the CarStatus class");
            fieldGeneratorCarStopped = new JSONHoldingBooleanGenerator("field \"CarStopped\" of the CarStatus class");
            fieldGeneratorCarIsRightHandDrive = new JSONHoldingBooleanGenerator("field \"CarIsRightHandDrive\" of the CarStatus class");
            fieldGeneratorEnableExtendedVentSpecification = new JSONHoldingBooleanGenerator("field \"EnableExtendedVentSpecification\" of the CarStatus class");
            fieldGeneratorEnableDegreeTypeInference = new JSONHoldingBooleanGenerator("field \"EnableDegreeTypeInference\" of the CarStatus class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the CarStatus class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorCurrentTemperature = new JSONHoldingNumberTextGenerator("field \"CurrentTemperature\" of the CarStatus class");
            fieldGeneratorCurrentTemperatureUnits = new FieldHoldingGeneratorCurrentTemperatureUnits("field \"CurrentTemperatureUnits\" of the CarStatus class");
            fieldGeneratorMaximumHVACTemperature = new JSONHoldingNumberTextGenerator("field \"MaximumHVACTemperature\" of the CarStatus class");
            fieldGeneratorMinimumHVACTemperature = new JSONHoldingNumberTextGenerator("field \"MinimumHVACTemperature\" of the CarStatus class");
            fieldGeneratorDrivingRange = new JSONHoldingNumberTextGenerator("field \"DrivingRange\" of the CarStatus class");
            fieldGeneratorNavMilesLeft = new JSONHoldingNumberTextGenerator("field \"NavMilesLeft\" of the CarStatus class");
            fieldGeneratorEngineStatus = new JSONHoldingStringGenerator("field \"EngineStatus\" of the CarStatus class");
            fieldGeneratorCriticalWarning = new JSONHoldingBooleanGenerator("field \"CriticalWarning\" of the CarStatus class");
            fieldGeneratorWarningReason = new JSONHoldingStringGenerator("field \"WarningReason\" of the CarStatus class");
            fieldGeneratorCarStopped = new JSONHoldingBooleanGenerator("field \"CarStopped\" of the CarStatus class");
            fieldGeneratorCarIsRightHandDrive = new JSONHoldingBooleanGenerator("field \"CarIsRightHandDrive\" of the CarStatus class");
            fieldGeneratorEnableExtendedVentSpecification = new JSONHoldingBooleanGenerator("field \"EnableExtendedVentSpecification\" of the CarStatus class");
            fieldGeneratorEnableDegreeTypeInference = new JSONHoldingBooleanGenerator("field \"EnableDegreeTypeInference\" of the CarStatus class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the CarStatus class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorCurrentTemperature.reset();
            fieldGeneratorCurrentTemperatureUnits.reset();
            fieldGeneratorMaximumHVACTemperature.reset();
            fieldGeneratorMinimumHVACTemperature.reset();
            fieldGeneratorDrivingRange.reset();
            fieldGeneratorNavMilesLeft.reset();
            fieldGeneratorEngineStatus.reset();
            fieldGeneratorCriticalWarning.reset();
            fieldGeneratorWarningReason.reset();
            fieldGeneratorCarStopped.reset();
            fieldGeneratorCarIsRightHandDrive.reset();
            fieldGeneratorEnableExtendedVentSpecification.reset();
            fieldGeneratorEnableDegreeTypeInference.reset();
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
        protected override void handle_result(CarStatusJSON  result)
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
        public CarStatusJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(CarStatusJSON  result)
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
    protected virtual void handle_result(List<CarStatusJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<CarStatusJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<CarStatusJSON>();
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
    public List<CarStatusJSON> value;
  };
  };
