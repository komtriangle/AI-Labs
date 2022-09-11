/* file "ShowDirectionsQueryStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class ShowDirectionsQueryStateJSON : JSONBase
  {
    public enum TypeNavigationMethod
      {
        NavigationMethod_Walk,
        NavigationMethod_Transit,
        NavigationMethod_Bike,
        NavigationMethod_Drive
      };

    public static TypeNavigationMethod  stringToNavigationMethod(string chars)
      {
        switch (chars[0])
          {
            case 'B':
                if ((String.Compare(chars, 1, "ike", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeNavigationMethod.NavigationMethod_Bike;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "rive", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeNavigationMethod.NavigationMethod_Drive;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "ransit", 0, 6, false) == 0) && (chars.Length == 7))
                    return TypeNavigationMethod.NavigationMethod_Transit;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "alk", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeNavigationMethod.NavigationMethod_Walk;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `NavigationMethod' is not one of the legal values.");
      }

    public static string  stringFromNavigationMethod(TypeNavigationMethod the_enum)
      {
        switch (the_enum)
          {
            case TypeNavigationMethod.NavigationMethod_Walk:
                return "Walk";
            case TypeNavigationMethod.NavigationMethod_Transit:
                return "Transit";
            case TypeNavigationMethod.NavigationMethod_Bike:
                return "Bike";
            case TypeNavigationMethod.NavigationMethod_Drive:
                return "Drive";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    public enum TypeCorrectionState
      {
        CorrectionState_None,
        CorrectionState_TryNewLocation,
        CorrectionState_Fail
      };

    public static TypeCorrectionState  stringToCorrectionState(string chars)
      {
        switch (chars[0])
          {
            case 'F':
                if ((String.Compare(chars, 1, "ail", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeCorrectionState.CorrectionState_Fail;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "one", 0, 3, false) == 0) && (chars.Length == 4))
                    return TypeCorrectionState.CorrectionState_None;
                break;
            case 'T':
                if ((String.Compare(chars, 1, "ryNewLocation", 0, 13, false) == 0) && (chars.Length == 14))
                    return TypeCorrectionState.CorrectionState_TryNewLocation;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `CorrectionState' is not one of the legal values.");
      }

    public static string  stringFromCorrectionState(TypeCorrectionState the_enum)
      {
        switch (the_enum)
          {
            case TypeCorrectionState.CorrectionState_None:
                return "None";
            case TypeCorrectionState.CorrectionState_TryNewLocation:
                return "TryNewLocation";
            case TypeCorrectionState.CorrectionState_Fail:
                return "Fail";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasStartMapLocationSpec;
    private MapLocationJSON  storeStartMapLocationSpec;
    private bool flagHasDestinationMapLocationSpec;
    private MapLocationJSON  storeDestinationMapLocationSpec;
    private bool flagHasStartLocationDerivation;
    private LocationDerivationJSON  storeStartLocationDerivation;
    private bool flagHasDestinationLocationDerivation;
    private LocationDerivationJSON  storeDestinationLocationDerivation;
    private bool flagHasImplicitStart;
    private bool storeImplicitStart;
    private bool flagHasNavigationMethod;
    private TypeNavigationMethod storeNavigationMethod;
    private bool flagHasNavigate;
    private bool storeNavigate;
    private bool flagHasAsksForDistance;
    private bool storeAsksForDistance;
    private bool flagHasAsksForTravelTime;
    private bool storeAsksForTravelTime;
    private bool flagHasUnitOfMeasureID;
    private string storeUnitOfMeasureID;
    private bool flagHasCorrectionState;
    private TypeCorrectionState storeCorrectionState;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONStartMapLocationSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setStartMapLocationSpec(convert_classy);
      }


    private void  fromJSONDestinationMapLocationSpec(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MapLocationJSON convert_classy = MapLocationJSON.from_json(json_value, ignore_extras, true);
        setDestinationMapLocationSpec(convert_classy);
      }


    private void  fromJSONStartLocationDerivation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        LocationDerivationJSON convert_classy = LocationDerivationJSON.from_json(json_value, ignore_extras, true);
        setStartLocationDerivation(convert_classy);
      }


    private void  fromJSONDestinationLocationDerivation(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        LocationDerivationJSON convert_classy = LocationDerivationJSON.from_json(json_value, ignore_extras, true);
        setDestinationLocationDerivation(convert_classy);
      }


    private void  fromJSONImplicitStart(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field ImplicitStart of ShowDirectionsQueryStateJSON is not true for false.");
              }
          }
        setImplicitStart(the_bool);
      }


    private void  fromJSONNavigationMethod(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field NavigationMethod of ShowDirectionsQueryStateJSON is not a string.");
        TypeNavigationMethod the_enum;
        switch (json_string.getData()[0])
          {
            case 'B':
                if ((String.Compare(json_string.getData(), 1, "ike", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeNavigationMethod.NavigationMethod_Bike;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "rive", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_enum = TypeNavigationMethod.NavigationMethod_Drive;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "ransit", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                      {
                        the_enum = TypeNavigationMethod.NavigationMethod_Transit;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "alk", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeNavigationMethod.NavigationMethod_Walk;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field NavigationMethod of ShowDirectionsQueryStateJSON is not one of the legal strings.");
      enum_is_done:;
        setNavigationMethod(the_enum);
      }


    private void  fromJSONNavigate(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field Navigate of ShowDirectionsQueryStateJSON is not true for false.");
              }
          }
        setNavigate(the_bool);
      }


    private void  fromJSONAsksForDistance(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AsksForDistance of ShowDirectionsQueryStateJSON is not true for false.");
              }
          }
        setAsksForDistance(the_bool);
      }


    private void  fromJSONAsksForTravelTime(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field AsksForTravelTime of ShowDirectionsQueryStateJSON is not true for false.");
              }
          }
        setAsksForTravelTime(the_bool);
      }


    private void  fromJSONUnitOfMeasureID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field UnitOfMeasureID of ShowDirectionsQueryStateJSON is not a string.");
        setUnitOfMeasureID(json_string.getData());
      }


    private void  fromJSONCorrectionState(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field CorrectionState of ShowDirectionsQueryStateJSON is not a string.");
        TypeCorrectionState the_enum;
        switch (json_string.getData()[0])
          {
            case 'F':
                if ((String.Compare(json_string.getData(), 1, "ail", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeCorrectionState.CorrectionState_Fail;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "one", 0, 3, false) == 0) && (json_string.getData().Length == 4))
                      {
                        the_enum = TypeCorrectionState.CorrectionState_None;
                        goto enum_is_done;
                      }
                break;
            case 'T':
                if ((String.Compare(json_string.getData(), 1, "ryNewLocation", 0, 13, false) == 0) && (json_string.getData().Length == 14))
                      {
                        the_enum = TypeCorrectionState.CorrectionState_TryNewLocation;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field CorrectionState of ShowDirectionsQueryStateJSON is not one of the legal strings.");
      enum_is_done:;
        setCorrectionState(the_enum);
      }


    public ShowDirectionsQueryStateJSON()
      {
        flagHasStartMapLocationSpec = false;
        flagHasDestinationMapLocationSpec = false;
        flagHasStartLocationDerivation = false;
        flagHasDestinationLocationDerivation = false;
        flagHasImplicitStart = false;
        flagHasNavigationMethod = false;
        flagHasNavigate = false;
        flagHasAsksForDistance = false;
        flagHasAsksForTravelTime = false;
        flagHasUnitOfMeasureID = false;
        flagHasCorrectionState = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasStartMapLocationSpec()
      {
        return flagHasStartMapLocationSpec;
      }

    public MapLocationJSON   getStartMapLocationSpec()
      {
        Debug.Assert(flagHasStartMapLocationSpec);
        return storeStartMapLocationSpec;
      }

    public bool  hasDestinationMapLocationSpec()
      {
        return flagHasDestinationMapLocationSpec;
      }

    public MapLocationJSON   getDestinationMapLocationSpec()
      {
        Debug.Assert(flagHasDestinationMapLocationSpec);
        return storeDestinationMapLocationSpec;
      }

    public bool  hasStartLocationDerivation()
      {
        return flagHasStartLocationDerivation;
      }

    public LocationDerivationJSON   getStartLocationDerivation()
      {
        Debug.Assert(flagHasStartLocationDerivation);
        return storeStartLocationDerivation;
      }

    public bool  hasDestinationLocationDerivation()
      {
        return flagHasDestinationLocationDerivation;
      }

    public LocationDerivationJSON   getDestinationLocationDerivation()
      {
        Debug.Assert(flagHasDestinationLocationDerivation);
        return storeDestinationLocationDerivation;
      }

    public bool  hasImplicitStart()
      {
        return flagHasImplicitStart;
      }

    public bool  getImplicitStart()
      {
        Debug.Assert(flagHasImplicitStart);
        return storeImplicitStart;
      }

    public bool  hasNavigationMethod()
      {
        return flagHasNavigationMethod;
      }

    public TypeNavigationMethod  getNavigationMethod()
      {
        Debug.Assert(flagHasNavigationMethod);
        return storeNavigationMethod;
      }

    public string  getNavigationMethodAsString()
      {
        return stringFromNavigationMethod(getNavigationMethod());
      }

    public bool  hasNavigate()
      {
        return flagHasNavigate;
      }

    public bool  getNavigate()
      {
        Debug.Assert(flagHasNavigate);
        return storeNavigate;
      }

    public bool  hasAsksForDistance()
      {
        return flagHasAsksForDistance;
      }

    public bool  getAsksForDistance()
      {
        Debug.Assert(flagHasAsksForDistance);
        return storeAsksForDistance;
      }

    public bool  hasAsksForTravelTime()
      {
        return flagHasAsksForTravelTime;
      }

    public bool  getAsksForTravelTime()
      {
        Debug.Assert(flagHasAsksForTravelTime);
        return storeAsksForTravelTime;
      }

    public bool  hasUnitOfMeasureID()
      {
        return flagHasUnitOfMeasureID;
      }

    public string  getUnitOfMeasureID()
      {
        Debug.Assert(flagHasUnitOfMeasureID);
        return storeUnitOfMeasureID;
      }

    public bool  hasCorrectionState()
      {
        return flagHasCorrectionState;
      }

    public TypeCorrectionState  getCorrectionState()
      {
        Debug.Assert(flagHasCorrectionState);
        return storeCorrectionState;
      }

    public string  getCorrectionStateAsString()
      {
        return stringFromCorrectionState(getCorrectionState());
      }


    public virtual int extraShowDirectionsQueryStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraShowDirectionsQueryStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraShowDirectionsQueryStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraShowDirectionsQueryStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setStartMapLocationSpec(MapLocationJSON  new_value)
      {
        if (flagHasStartMapLocationSpec)
          {
          }
        flagHasStartMapLocationSpec = true;
        storeStartMapLocationSpec = new_value;
      }
    public void unsetStartMapLocationSpec()
      {
        if (flagHasStartMapLocationSpec)
          {
          }
        flagHasStartMapLocationSpec = false;
      }
    public void setDestinationMapLocationSpec(MapLocationJSON  new_value)
      {
        if (flagHasDestinationMapLocationSpec)
          {
          }
        flagHasDestinationMapLocationSpec = true;
        storeDestinationMapLocationSpec = new_value;
      }
    public void unsetDestinationMapLocationSpec()
      {
        if (flagHasDestinationMapLocationSpec)
          {
          }
        flagHasDestinationMapLocationSpec = false;
      }
    public void setStartLocationDerivation(LocationDerivationJSON  new_value)
      {
        if (flagHasStartLocationDerivation)
          {
          }
        flagHasStartLocationDerivation = true;
        storeStartLocationDerivation = new_value;
      }
    public void unsetStartLocationDerivation()
      {
        if (flagHasStartLocationDerivation)
          {
          }
        flagHasStartLocationDerivation = false;
      }
    public void setDestinationLocationDerivation(LocationDerivationJSON  new_value)
      {
        if (flagHasDestinationLocationDerivation)
          {
          }
        flagHasDestinationLocationDerivation = true;
        storeDestinationLocationDerivation = new_value;
      }
    public void unsetDestinationLocationDerivation()
      {
        if (flagHasDestinationLocationDerivation)
          {
          }
        flagHasDestinationLocationDerivation = false;
      }
    public void setImplicitStart(bool new_value)
      {
        flagHasImplicitStart = true;
        storeImplicitStart = new_value;
      }
    public void unsetImplicitStart()
      {
        flagHasImplicitStart = false;
      }
    public void setNavigationMethod(TypeNavigationMethod new_value)
      {
        flagHasNavigationMethod = true;
        storeNavigationMethod = new_value;
      }
    public void setNavigationMethod(string chars)
      {
        setNavigationMethod(stringToNavigationMethod(chars));
      }
    public void unsetNavigationMethod()
      {
        flagHasNavigationMethod = false;
      }
    public void setNavigate(bool new_value)
      {
        flagHasNavigate = true;
        storeNavigate = new_value;
      }
    public void unsetNavigate()
      {
        flagHasNavigate = false;
      }
    public void setAsksForDistance(bool new_value)
      {
        flagHasAsksForDistance = true;
        storeAsksForDistance = new_value;
      }
    public void unsetAsksForDistance()
      {
        flagHasAsksForDistance = false;
      }
    public void setAsksForTravelTime(bool new_value)
      {
        flagHasAsksForTravelTime = true;
        storeAsksForTravelTime = new_value;
      }
    public void unsetAsksForTravelTime()
      {
        flagHasAsksForTravelTime = false;
      }
    public void setUnitOfMeasureID(string new_value)
      {
        flagHasUnitOfMeasureID = true;
        storeUnitOfMeasureID = new_value;
      }
    public void unsetUnitOfMeasureID()
      {
        flagHasUnitOfMeasureID = false;
      }
    public void setCorrectionState(TypeCorrectionState new_value)
      {
        flagHasCorrectionState = true;
        storeCorrectionState = new_value;
      }
    public void setCorrectionState(string chars)
      {
        setCorrectionState(stringToCorrectionState(chars));
      }
    public void unsetCorrectionState()
      {
        flagHasCorrectionState = false;
      }

    public virtual void extraShowDirectionsQueryStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraShowDirectionsQueryStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraShowDirectionsQueryStateLookup(key);
        if (old_field == null)
          {
            extraShowDirectionsQueryStateAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasStartMapLocationSpec);
        if (flagHasStartMapLocationSpec)
          {
            handler.start_pair("StartMapLocationSpec");
            if (partial_allowed)
                storeStartMapLocationSpec.write_partial_as_json(handler);
            else
                storeStartMapLocationSpec.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasDestinationMapLocationSpec);
        if (flagHasDestinationMapLocationSpec)
          {
            handler.start_pair("DestinationMapLocationSpec");
            if (partial_allowed)
                storeDestinationMapLocationSpec.write_partial_as_json(handler);
            else
                storeDestinationMapLocationSpec.write_as_json(handler);
          }
        if (flagHasStartLocationDerivation)
          {
            handler.start_pair("StartLocationDerivation");
            if (partial_allowed)
                storeStartLocationDerivation.write_partial_as_json(handler);
            else
                storeStartLocationDerivation.write_as_json(handler);
          }
        if (flagHasDestinationLocationDerivation)
          {
            handler.start_pair("DestinationLocationDerivation");
            if (partial_allowed)
                storeDestinationLocationDerivation.write_partial_as_json(handler);
            else
                storeDestinationLocationDerivation.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasImplicitStart);
        if (flagHasImplicitStart)
          {
            handler.start_pair("ImplicitStart");
            handler.boolean_value(storeImplicitStart);
          }
        Debug.Assert(partial_allowed || flagHasNavigationMethod);
        if (flagHasNavigationMethod)
          {
            handler.start_pair("NavigationMethod");
            switch (storeNavigationMethod)
              {
                case TypeNavigationMethod.NavigationMethod_Walk:
                    handler.string_value("Walk");
                    break;
                case TypeNavigationMethod.NavigationMethod_Transit:
                    handler.string_value("Transit");
                    break;
                case TypeNavigationMethod.NavigationMethod_Bike:
                    handler.string_value("Bike");
                    break;
                case TypeNavigationMethod.NavigationMethod_Drive:
                    handler.string_value("Drive");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        Debug.Assert(partial_allowed || flagHasNavigate);
        if (flagHasNavigate)
          {
            handler.start_pair("Navigate");
            handler.boolean_value(storeNavigate);
          }
        Debug.Assert(partial_allowed || flagHasAsksForDistance);
        if (flagHasAsksForDistance)
          {
            handler.start_pair("AsksForDistance");
            handler.boolean_value(storeAsksForDistance);
          }
        Debug.Assert(partial_allowed || flagHasAsksForTravelTime);
        if (flagHasAsksForTravelTime)
          {
            handler.start_pair("AsksForTravelTime");
            handler.boolean_value(storeAsksForTravelTime);
          }
        if (flagHasUnitOfMeasureID)
          {
            handler.start_pair("UnitOfMeasureID");
            handler.string_value(storeUnitOfMeasureID);
          }
        if (flagHasCorrectionState)
          {
            handler.start_pair("CorrectionState");
            switch (storeCorrectionState)
              {
                case TypeCorrectionState.CorrectionState_None:
                    handler.string_value("None");
                    break;
                case TypeCorrectionState.CorrectionState_TryNewLocation:
                    handler.string_value("TryNewLocation");
                    break;
                case TypeCorrectionState.CorrectionState_Fail:
                    handler.string_value("Fail");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
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
        if (!(hasStartMapLocationSpec()))
          {
            return "When parsing the object for %what%, the \"StartMapLocationSpec\" field was missing.";
          }
        if (!(hasDestinationMapLocationSpec()))
          {
            return "When parsing the object for %what%, the \"DestinationMapLocationSpec\" field was missing.";
          }
        if (!(hasImplicitStart()))
          {
            return "When parsing the object for %what%, the \"ImplicitStart\" field was missing.";
          }
        if (!(hasNavigationMethod()))
          {
            return "When parsing the object for %what%, the \"NavigationMethod\" field was missing.";
          }
        if (!(hasNavigate()))
          {
            return "When parsing the object for %what%, the \"Navigate\" field was missing.";
          }
        if (!(hasAsksForDistance()))
          {
            return "When parsing the object for %what%, the \"AsksForDistance\" field was missing.";
          }
        if (!(hasAsksForTravelTime()))
          {
            return "When parsing the object for %what%, the \"AsksForTravelTime\" field was missing.";
          }
        return null;
      }

    public static ShowDirectionsQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowDirectionsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowDirectionsQueryState", ignore_extras);
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
    public static ShowDirectionsQueryStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ShowDirectionsQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowDirectionsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowDirectionsQueryState", ignore_extras);
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
    public static ShowDirectionsQueryStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static ShowDirectionsQueryStateJSON from_text(string text, bool ignore_extras)
      {
        ShowDirectionsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowDirectionsQueryState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ShowDirectionsQueryStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static ShowDirectionsQueryStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ShowDirectionsQueryStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowDirectionsQueryState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private MapLocationJSON.HoldingGenerator fieldGeneratorStartMapLocationSpec;
        private MapLocationJSON.HoldingGenerator fieldGeneratorDestinationMapLocationSpec;
        private LocationDerivationJSON.HoldingGenerator fieldGeneratorStartLocationDerivation;
        private LocationDerivationJSON.HoldingGenerator fieldGeneratorDestinationLocationDerivation;
        private JSONHoldingBooleanGenerator fieldGeneratorImplicitStart;
    private abstract class FieldGeneratorNavigationMethod : JSONStringGenerator
          {
            protected FieldGeneratorNavigationMethod(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorNavigationMethod()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToNavigationMethod(result));
              }
            protected abstract void handle_result(TypeNavigationMethod result);
          };
    private class FieldHoldingGeneratorNavigationMethod : FieldGeneratorNavigationMethod
  {
    protected override void handle_result(TypeNavigationMethod result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorNavigationMethod(String what)
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
    public TypeNavigationMethod value;
  };
    private class FieldHoldingArrayGeneratorNavigationMethod : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorNavigationMethod
      {
        private FieldHoldingArrayGeneratorNavigationMethod top;

        protected override void handle_result(TypeNavigationMethod result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorNavigationMethod init_top)
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
    protected virtual void handle_result(List<TypeNavigationMethod> result)
      {
      }

    public FieldHoldingArrayGeneratorNavigationMethod(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNavigationMethod>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorNavigationMethod()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeNavigationMethod>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeNavigationMethod> value;
  };
        private FieldHoldingGeneratorNavigationMethod fieldGeneratorNavigationMethod;
        private JSONHoldingBooleanGenerator fieldGeneratorNavigate;
        private JSONHoldingBooleanGenerator fieldGeneratorAsksForDistance;
        private JSONHoldingBooleanGenerator fieldGeneratorAsksForTravelTime;
        private JSONHoldingStringGenerator fieldGeneratorUnitOfMeasureID;
    private abstract class FieldGeneratorCorrectionState : JSONStringGenerator
          {
            protected FieldGeneratorCorrectionState(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorCorrectionState()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToCorrectionState(result));
              }
            protected abstract void handle_result(TypeCorrectionState result);
          };
    private class FieldHoldingGeneratorCorrectionState : FieldGeneratorCorrectionState
  {
    protected override void handle_result(TypeCorrectionState result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorCorrectionState(String what)
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
    public TypeCorrectionState value;
  };
    private class FieldHoldingArrayGeneratorCorrectionState : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorCorrectionState
      {
        private FieldHoldingArrayGeneratorCorrectionState top;

        protected override void handle_result(TypeCorrectionState result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorCorrectionState init_top)
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
    protected virtual void handle_result(List<TypeCorrectionState> result)
      {
      }

    public FieldHoldingArrayGeneratorCorrectionState(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCorrectionState>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorCorrectionState()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeCorrectionState>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeCorrectionState> value;
  };
        private FieldHoldingGeneratorCorrectionState fieldGeneratorCorrectionState;
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
            ShowDirectionsQueryStateJSON result = new ShowDirectionsQueryStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraShowDirectionsQueryStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(ShowDirectionsQueryStateJSON result)
          {
            if (fieldGeneratorStartMapLocationSpec.have_value)
              {
                result.setStartMapLocationSpec(fieldGeneratorStartMapLocationSpec.value);
                fieldGeneratorStartMapLocationSpec.have_value = false;
              }
            else if ((!(result.hasStartMapLocationSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"StartMapLocationSpec\" field was missing.");
              }
            if (fieldGeneratorDestinationMapLocationSpec.have_value)
              {
                result.setDestinationMapLocationSpec(fieldGeneratorDestinationMapLocationSpec.value);
                fieldGeneratorDestinationMapLocationSpec.have_value = false;
              }
            else if ((!(result.hasDestinationMapLocationSpec())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"DestinationMapLocationSpec\" field was missing.");
              }
            if (fieldGeneratorStartLocationDerivation.have_value)
              {
                result.setStartLocationDerivation(fieldGeneratorStartLocationDerivation.value);
                fieldGeneratorStartLocationDerivation.have_value = false;
              }
            if (fieldGeneratorDestinationLocationDerivation.have_value)
              {
                result.setDestinationLocationDerivation(fieldGeneratorDestinationLocationDerivation.value);
                fieldGeneratorDestinationLocationDerivation.have_value = false;
              }
            if (fieldGeneratorImplicitStart.have_value)
              {
                result.setImplicitStart(fieldGeneratorImplicitStart.value);
                fieldGeneratorImplicitStart.have_value = false;
              }
            else if ((!(result.hasImplicitStart())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ImplicitStart\" field was missing.");
              }
            if (fieldGeneratorNavigationMethod.have_value)
              {
                result.setNavigationMethod(fieldGeneratorNavigationMethod.value);
                fieldGeneratorNavigationMethod.have_value = false;
              }
            else if ((!(result.hasNavigationMethod())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NavigationMethod\" field was missing.");
              }
            if (fieldGeneratorNavigate.have_value)
              {
                result.setNavigate(fieldGeneratorNavigate.value);
                fieldGeneratorNavigate.have_value = false;
              }
            else if ((!(result.hasNavigate())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"Navigate\" field was missing.");
              }
            if (fieldGeneratorAsksForDistance.have_value)
              {
                result.setAsksForDistance(fieldGeneratorAsksForDistance.value);
                fieldGeneratorAsksForDistance.have_value = false;
              }
            else if ((!(result.hasAsksForDistance())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AsksForDistance\" field was missing.");
              }
            if (fieldGeneratorAsksForTravelTime.have_value)
              {
                result.setAsksForTravelTime(fieldGeneratorAsksForTravelTime.value);
                fieldGeneratorAsksForTravelTime.have_value = false;
              }
            else if ((!(result.hasAsksForTravelTime())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AsksForTravelTime\" field was missing.");
              }
            if (fieldGeneratorUnitOfMeasureID.have_value)
              {
                result.setUnitOfMeasureID(fieldGeneratorUnitOfMeasureID.value);
                fieldGeneratorUnitOfMeasureID.have_value = false;
              }
            if (fieldGeneratorCorrectionState.have_value)
              {
                result.setCorrectionState(fieldGeneratorCorrectionState.value);
                fieldGeneratorCorrectionState.have_value = false;
              }
          }
        protected abstract void handle_result(ShowDirectionsQueryStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "sksFor", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 8, "istance", 0, 7, false) == 0) && (field_name.Length == 15))
                                    return fieldGeneratorAsksForDistance;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 8, "ravelTime", 0, 9, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorAsksForTravelTime;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "orrectionState", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorCorrectionState;
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "estination", 0, 10, false) == 0)
                      {
                        switch (field_name[11])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 12, "ocationDerivation", 0, 17, false) == 0) && (field_name.Length == 29))
                                    return fieldGeneratorDestinationLocationDerivation;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 12, "apLocationSpec", 0, 14, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorDestinationMapLocationSpec;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'I':
                    if ((String.Compare(field_name, 1, "mplicitStart", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorImplicitStart;
                    break;
                case 'N':
                    if (String.Compare(field_name, 1, "avigat", 0, 6, false) == 0)
                      {
                        switch (field_name[7])
                          {
                            case 'e':
                                if (field_name.Length == 8)
                                    return fieldGeneratorNavigate;
                                break;
                            case 'i':
                                if ((String.Compare(field_name, 8, "onMethod", 0, 8, false) == 0) && (field_name.Length == 16))
                                    return fieldGeneratorNavigationMethod;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "tart", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 6, "ocationDerivation", 0, 17, false) == 0) && (field_name.Length == 23))
                                    return fieldGeneratorStartLocationDerivation;
                                break;
                            case 'M':
                                if ((String.Compare(field_name, 6, "apLocationSpec", 0, 14, false) == 0) && (field_name.Length == 20))
                                    return fieldGeneratorStartMapLocationSpec;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'U':
                    if ((String.Compare(field_name, 1, "nitOfMeasureID", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorUnitOfMeasureID;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorStartMapLocationSpec = new MapLocationJSON.HoldingGenerator("field \"StartMapLocationSpec\" of the ShowDirectionsQueryState class", ignore_extras);
            fieldGeneratorDestinationMapLocationSpec = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocationSpec\" of the ShowDirectionsQueryState class", ignore_extras);
            fieldGeneratorStartLocationDerivation = new LocationDerivationJSON.HoldingGenerator("field \"StartLocationDerivation\" of the ShowDirectionsQueryState class", ignore_extras);
            fieldGeneratorDestinationLocationDerivation = new LocationDerivationJSON.HoldingGenerator("field \"DestinationLocationDerivation\" of the ShowDirectionsQueryState class", ignore_extras);
            fieldGeneratorImplicitStart = new JSONHoldingBooleanGenerator("field \"ImplicitStart\" of the ShowDirectionsQueryState class");
            fieldGeneratorNavigationMethod = new FieldHoldingGeneratorNavigationMethod("field \"NavigationMethod\" of the ShowDirectionsQueryState class");
            fieldGeneratorNavigate = new JSONHoldingBooleanGenerator("field \"Navigate\" of the ShowDirectionsQueryState class");
            fieldGeneratorAsksForDistance = new JSONHoldingBooleanGenerator("field \"AsksForDistance\" of the ShowDirectionsQueryState class");
            fieldGeneratorAsksForTravelTime = new JSONHoldingBooleanGenerator("field \"AsksForTravelTime\" of the ShowDirectionsQueryState class");
            fieldGeneratorUnitOfMeasureID = new JSONHoldingStringGenerator("field \"UnitOfMeasureID\" of the ShowDirectionsQueryState class");
            fieldGeneratorCorrectionState = new FieldHoldingGeneratorCorrectionState("field \"CorrectionState\" of the ShowDirectionsQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ShowDirectionsQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorStartMapLocationSpec = new MapLocationJSON.HoldingGenerator("field \"StartMapLocationSpec\" of the ShowDirectionsQueryState class", false);
            fieldGeneratorDestinationMapLocationSpec = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocationSpec\" of the ShowDirectionsQueryState class", false);
            fieldGeneratorStartLocationDerivation = new LocationDerivationJSON.HoldingGenerator("field \"StartLocationDerivation\" of the ShowDirectionsQueryState class", false);
            fieldGeneratorDestinationLocationDerivation = new LocationDerivationJSON.HoldingGenerator("field \"DestinationLocationDerivation\" of the ShowDirectionsQueryState class", false);
            fieldGeneratorImplicitStart = new JSONHoldingBooleanGenerator("field \"ImplicitStart\" of the ShowDirectionsQueryState class");
            fieldGeneratorNavigationMethod = new FieldHoldingGeneratorNavigationMethod("field \"NavigationMethod\" of the ShowDirectionsQueryState class");
            fieldGeneratorNavigate = new JSONHoldingBooleanGenerator("field \"Navigate\" of the ShowDirectionsQueryState class");
            fieldGeneratorAsksForDistance = new JSONHoldingBooleanGenerator("field \"AsksForDistance\" of the ShowDirectionsQueryState class");
            fieldGeneratorAsksForTravelTime = new JSONHoldingBooleanGenerator("field \"AsksForTravelTime\" of the ShowDirectionsQueryState class");
            fieldGeneratorUnitOfMeasureID = new JSONHoldingStringGenerator("field \"UnitOfMeasureID\" of the ShowDirectionsQueryState class");
            fieldGeneratorCorrectionState = new FieldHoldingGeneratorCorrectionState("field \"CorrectionState\" of the ShowDirectionsQueryState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ShowDirectionsQueryState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorStartMapLocationSpec.reset();
            fieldGeneratorDestinationMapLocationSpec.reset();
            fieldGeneratorStartLocationDerivation.reset();
            fieldGeneratorDestinationLocationDerivation.reset();
            fieldGeneratorImplicitStart.reset();
            fieldGeneratorNavigationMethod.reset();
            fieldGeneratorNavigate.reset();
            fieldGeneratorAsksForDistance.reset();
            fieldGeneratorAsksForTravelTime.reset();
            fieldGeneratorUnitOfMeasureID.reset();
            fieldGeneratorCorrectionState.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorStartMapLocationSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDestinationMapLocationSpec.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorStartLocationDerivation.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorDestinationLocationDerivation.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorStartMapLocationSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDestinationMapLocationSpec.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorStartLocationDerivation.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorDestinationLocationDerivation.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(ShowDirectionsQueryStateJSON  result)
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
        public ShowDirectionsQueryStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ShowDirectionsQueryStateJSON  result)
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
    protected virtual void handle_result(List<ShowDirectionsQueryStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ShowDirectionsQueryStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ShowDirectionsQueryStateJSON>();
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
    public List<ShowDirectionsQueryStateJSON> value;
  };
  };
