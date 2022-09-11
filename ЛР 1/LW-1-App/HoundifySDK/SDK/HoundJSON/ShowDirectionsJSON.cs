/* file "ShowDirectionsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class ShowDirectionsJSON : MapCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
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
        private bool flagHasDistance;
        private double storeDistance;
        private string textStoreDistance;
        private bool flagHasUnitOfMeasureID;
        private string storeUnitOfMeasureID;
        private bool flagHasUnitOfLengthSingular;
        private string storeUnitOfLengthSingular;
        private bool flagHasUnitOfLengthPlural;
        private string storeUnitOfLengthPlural;
        private bool flagHasTravelTime;
        private double storeTravelTime;
        private string textStoreTravelTime;
        private bool flagHasCorrectionState;
        private TypeCorrectionState storeCorrectionState;


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
                    throw new Exception("The value for field ImplicitStart of TypeNativeDataJSON is not true for false.");
                  }
              }
            setImplicitStart(the_bool);
          }


        private void  fromJSONNavigationMethod(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field NavigationMethod of TypeNativeDataJSON is not a string.");
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
            throw new Exception("The value for field NavigationMethod of TypeNativeDataJSON is not one of the legal strings.");
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
                    throw new Exception("The value for field Navigate of TypeNativeDataJSON is not true for false.");
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
                    throw new Exception("The value for field AsksForDistance of TypeNativeDataJSON is not true for false.");
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
                    throw new Exception("The value for field AsksForTravelTime of TypeNativeDataJSON is not true for false.");
                  }
              }
            setAsksForTravelTime(the_bool);
          }


        private void  fromJSONDistance(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Distance of TypeNativeDataJSON is not a number.");
                  }
              }
            setDistanceText(the_rational_text);
          }


        private void  fromJSONUnitOfMeasureID(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field UnitOfMeasureID of TypeNativeDataJSON is not a string.");
            setUnitOfMeasureID(json_string.getData());
          }


        private void  fromJSONUnitOfLengthSingular(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field UnitOfLengthSingular of TypeNativeDataJSON is not a string.");
            setUnitOfLengthSingular(json_string.getData());
          }


        private void  fromJSONUnitOfLengthPlural(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field UnitOfLengthPlural of TypeNativeDataJSON is not a string.");
            setUnitOfLengthPlural(json_string.getData());
          }


        private void  fromJSONTravelTime(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field TravelTime of TypeNativeDataJSON is not a number.");
                  }
              }
            setTravelTimeText(the_rational_text);
          }


        private void  fromJSONCorrectionState(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field CorrectionState of TypeNativeDataJSON is not a string.");
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
            throw new Exception("The value for field CorrectionState of TypeNativeDataJSON is not one of the legal strings.");
          enum_is_done:;
            setCorrectionState(the_enum);
          }


        public TypeNativeDataJSON()
          {
            flagHasStartMapLocationSpec = false;
            flagHasDestinationMapLocationSpec = false;
            flagHasImplicitStart = false;
            flagHasNavigationMethod = false;
            flagHasNavigate = false;
            flagHasAsksForDistance = false;
            flagHasAsksForTravelTime = false;
            flagHasDistance = false;
            flagHasUnitOfMeasureID = false;
            flagHasUnitOfLengthSingular = false;
            flagHasUnitOfLengthPlural = false;
            flagHasTravelTime = false;
            flagHasCorrectionState = false;
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

        public bool  hasDistance()
          {
            return flagHasDistance;
          }

        public double  getDistance()
          {
            Debug.Assert(flagHasDistance);
            if (textStoreDistance != "")
              {
                return Double.Parse(textStoreDistance);
              }
            return storeDistance;
          }

        public string  getDistanceAsText()
          {
            Debug.Assert(flagHasDistance);
            if (textStoreDistance == "")
              {
                return Convert.ToString(storeDistance);
              }
            else
              {
                return (textStoreDistance);
              }
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

        public bool  hasUnitOfLengthSingular()
          {
            return flagHasUnitOfLengthSingular;
          }

        public string  getUnitOfLengthSingular()
          {
            Debug.Assert(flagHasUnitOfLengthSingular);
            return storeUnitOfLengthSingular;
          }

        public bool  hasUnitOfLengthPlural()
          {
            return flagHasUnitOfLengthPlural;
          }

        public string  getUnitOfLengthPlural()
          {
            Debug.Assert(flagHasUnitOfLengthPlural);
            return storeUnitOfLengthPlural;
          }

        public bool  hasTravelTime()
          {
            return flagHasTravelTime;
          }

        public double  getTravelTime()
          {
            Debug.Assert(flagHasTravelTime);
            if (textStoreTravelTime != "")
              {
                return Double.Parse(textStoreTravelTime);
              }
            return storeTravelTime;
          }

        public string  getTravelTimeAsText()
          {
            Debug.Assert(flagHasTravelTime);
            if (textStoreTravelTime == "")
              {
                return Convert.ToString(storeTravelTime);
              }
            else
              {
                return (textStoreTravelTime);
              }
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
        public void setDistance(double new_value)
          {
            flagHasDistance = true;
            if (new_value < -1)
                throw new Exception("The value for field Distance of TypeNativeDataJSON is less than the lower bound (-1) for that field.");
            storeDistance = new_value;
            textStoreDistance = "";
          }
        public void setDistanceText(string new_value)
          {
            flagHasDistance = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Distance of TypeNativeDataJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "1", "", false, "1") < 0)
                throw new Exception("The value for field Distance of TypeNativeDataJSON is less than the lower bound (-1) for that field.");
            textStoreDistance = new_value;
          }
        public void unsetDistance()
          {
            flagHasDistance = false;
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
        public void setUnitOfLengthSingular(string new_value)
          {
            flagHasUnitOfLengthSingular = true;
            storeUnitOfLengthSingular = new_value;
          }
        public void unsetUnitOfLengthSingular()
          {
            flagHasUnitOfLengthSingular = false;
          }
        public void setUnitOfLengthPlural(string new_value)
          {
            flagHasUnitOfLengthPlural = true;
            storeUnitOfLengthPlural = new_value;
          }
        public void unsetUnitOfLengthPlural()
          {
            flagHasUnitOfLengthPlural = false;
          }
        public void setTravelTime(double new_value)
          {
            flagHasTravelTime = true;
            if (new_value < -1)
                throw new Exception("The value for field TravelTime of TypeNativeDataJSON is less than the lower bound (-1) for that field.");
            storeTravelTime = new_value;
            textStoreTravelTime = "";
          }
        public void setTravelTimeText(string new_value)
          {
            flagHasTravelTime = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field TravelTime of TypeNativeDataJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "1", "", false, "1") < 0)
                throw new Exception("The value for field TravelTime of TypeNativeDataJSON is less than the lower bound (-1) for that field.");
            textStoreTravelTime = new_value;
          }
        public void unsetTravelTime()
          {
            flagHasTravelTime = false;
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


        public override void write_as_json(JSONHandler handler)
          {
            handler.start_object();
            write_fields_as_json(handler);
            handler.finish_object();
          }

        public virtual void write_fields_as_json(JSONHandler handler)
          {
            write_fields_as_json(handler, false);
          }

        public virtual void write_fields_as_json(JSONHandler handler, bool partial_allowed)
          {
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
            Debug.Assert(partial_allowed || flagHasDistance);
            if (flagHasDistance)
              {
                handler.start_pair("Distance");
                if (textStoreDistance != "")
                    handler.number_value(textStoreDistance);
                else if (((double)(long)storeDistance) == storeDistance)
                    handler.number_value((long)storeDistance);
                else
                    handler.number_value(storeDistance);
              }
            if (flagHasUnitOfMeasureID)
              {
                handler.start_pair("UnitOfMeasureID");
                handler.string_value(storeUnitOfMeasureID);
              }
            if (flagHasUnitOfLengthSingular)
              {
                handler.start_pair("UnitOfLengthSingular");
                handler.string_value(storeUnitOfLengthSingular);
              }
            if (flagHasUnitOfLengthPlural)
              {
                handler.start_pair("UnitOfLengthPlural");
                handler.string_value(storeUnitOfLengthPlural);
              }
            Debug.Assert(partial_allowed || flagHasTravelTime);
            if (flagHasTravelTime)
              {
                handler.start_pair("TravelTime");
                if (textStoreTravelTime != "")
                    handler.number_value(textStoreTravelTime);
                else if (((double)(long)storeTravelTime) == storeTravelTime)
                    handler.number_value((long)storeTravelTime);
                else
                    handler.number_value(storeTravelTime);
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
            handler.finish_object();
          }
        public virtual string missing_field_error(bool allow_unpolished)
          {
            if (!(hasDestinationMapLocationSpec()))
              {
                return "When parsing the object for %what%, the \"DestinationMapLocationSpec\" field was missing.";
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
            if (!(hasDistance()))
              {
                return "When parsing the object for %what%, the \"Distance\" field was missing.";
              }
            if (!(hasTravelTime()))
              {
                return "When parsing the object for %what%, the \"TravelTime\" field was missing.";
              }
            return null;
          }

        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
        public static TypeNativeDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
      {
        return from_json(json_value, ignore_extras, allow_incomplete, false);
      }
        public static TypeNativeDataJSON from_text(string text, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
                JSONParse.parse_json_value(text, "Text for TypeNativeDataJSON", generator);
                Debug.Assert(generator.have_value);
                result = generator.value;
              };
            return result;
          }
        public static TypeNativeDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
          {
            TypeNativeDataJSON result;
              {
                HoldingGenerator generator = new HoldingGenerator("Type TypeNativeData", ignore_extras);
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
            private JSONHoldingNumberTextGenerator fieldGeneratorDistance;
            private JSONHoldingStringGenerator fieldGeneratorUnitOfMeasureID;
            private JSONHoldingStringGenerator fieldGeneratorUnitOfLengthSingular;
            private JSONHoldingStringGenerator fieldGeneratorUnitOfLengthPlural;
            private JSONHoldingNumberTextGenerator fieldGeneratorTravelTime;
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
                string message = "";
                message = message + "Field \"" + field_name + "\" found for a type that doesn't allow extra fields.";
                throw new Exception(message);
              }
            protected override void finish_field(string field_name, JSONHandler field_handler)
              {
              }
            protected override void finish()
              {
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorStartMapLocationSpec.have_value)
                  {
                    result.setStartMapLocationSpec(fieldGeneratorStartMapLocationSpec.value);
                    fieldGeneratorStartMapLocationSpec.have_value = false;
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
                if (fieldGeneratorImplicitStart.have_value)
                  {
                    result.setImplicitStart(fieldGeneratorImplicitStart.value);
                    fieldGeneratorImplicitStart.have_value = false;
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
                if (fieldGeneratorDistance.have_value)
                  {
                    result.setDistanceText(fieldGeneratorDistance.value);
                    fieldGeneratorDistance.have_value = false;
                  }
                else if ((!(result.hasDistance())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Distance\" field was missing.");
                  }
                if (fieldGeneratorUnitOfMeasureID.have_value)
                  {
                    result.setUnitOfMeasureID(fieldGeneratorUnitOfMeasureID.value);
                    fieldGeneratorUnitOfMeasureID.have_value = false;
                  }
                if (fieldGeneratorUnitOfLengthSingular.have_value)
                  {
                    result.setUnitOfLengthSingular(fieldGeneratorUnitOfLengthSingular.value);
                    fieldGeneratorUnitOfLengthSingular.have_value = false;
                  }
                if (fieldGeneratorUnitOfLengthPlural.have_value)
                  {
                    result.setUnitOfLengthPlural(fieldGeneratorUnitOfLengthPlural.value);
                    fieldGeneratorUnitOfLengthPlural.have_value = false;
                  }
                if (fieldGeneratorTravelTime.have_value)
                  {
                    result.setTravelTimeText(fieldGeneratorTravelTime.value);
                    fieldGeneratorTravelTime.have_value = false;
                  }
                else if ((!(result.hasTravelTime())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"TravelTime\" field was missing.");
                  }
                if (fieldGeneratorCorrectionState.have_value)
                  {
                    result.setCorrectionState(fieldGeneratorCorrectionState.value);
                    fieldGeneratorCorrectionState.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
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
                        switch (field_name[1])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 2, "stinationMapLocationSpec", 0, 24, false) == 0) && (field_name.Length == 26))
                                    return fieldGeneratorDestinationMapLocationSpec;
                                break;
                            case 'i':
                                if ((String.Compare(field_name, 2, "stance", 0, 6, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorDistance;
                                break;
                            default:
                                break;
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
                        if ((String.Compare(field_name, 1, "tartMapLocationSpec", 0, 19, false) == 0) && (field_name.Length == 20))
                            return fieldGeneratorStartMapLocationSpec;
                        break;
                    case 'T':
                        if ((String.Compare(field_name, 1, "ravelTime", 0, 9, false) == 0) && (field_name.Length == 10))
                            return fieldGeneratorTravelTime;
                        break;
                    case 'U':
                        if (String.Compare(field_name, 1, "nitOf", 0, 5, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'L':
                                    if (String.Compare(field_name, 7, "ength", 0, 5, false) == 0)
                                      {
                                        switch (field_name[12])
                                          {
                                            case 'P':
                                                if ((String.Compare(field_name, 13, "lural", 0, 5, false) == 0) && (field_name.Length == 18))
                                                    return fieldGeneratorUnitOfLengthPlural;
                                                break;
                                            case 'S':
                                                if ((String.Compare(field_name, 13, "ingular", 0, 7, false) == 0) && (field_name.Length == 20))
                                                    return fieldGeneratorUnitOfLengthSingular;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'M':
                                    if ((String.Compare(field_name, 7, "easureID", 0, 8, false) == 0) && (field_name.Length == 15))
                                        return fieldGeneratorUnitOfMeasureID;
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
                fieldGeneratorStartMapLocationSpec = new MapLocationJSON.HoldingGenerator("field \"StartMapLocationSpec\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorDestinationMapLocationSpec = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocationSpec\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorImplicitStart = new JSONHoldingBooleanGenerator("field \"ImplicitStart\" of the TypeNativeData class");
                fieldGeneratorNavigationMethod = new FieldHoldingGeneratorNavigationMethod("field \"NavigationMethod\" of the TypeNativeData class");
                fieldGeneratorNavigate = new JSONHoldingBooleanGenerator("field \"Navigate\" of the TypeNativeData class");
                fieldGeneratorAsksForDistance = new JSONHoldingBooleanGenerator("field \"AsksForDistance\" of the TypeNativeData class");
                fieldGeneratorAsksForTravelTime = new JSONHoldingBooleanGenerator("field \"AsksForTravelTime\" of the TypeNativeData class");
                fieldGeneratorDistance = new JSONHoldingNumberTextGenerator("field \"Distance\" of the TypeNativeData class");
                fieldGeneratorUnitOfMeasureID = new JSONHoldingStringGenerator("field \"UnitOfMeasureID\" of the TypeNativeData class");
                fieldGeneratorUnitOfLengthSingular = new JSONHoldingStringGenerator("field \"UnitOfLengthSingular\" of the TypeNativeData class");
                fieldGeneratorUnitOfLengthPlural = new JSONHoldingStringGenerator("field \"UnitOfLengthPlural\" of the TypeNativeData class");
                fieldGeneratorTravelTime = new JSONHoldingNumberTextGenerator("field \"TravelTime\" of the TypeNativeData class");
                fieldGeneratorCorrectionState = new FieldHoldingGeneratorCorrectionState("field \"CorrectionState\" of the TypeNativeData class");
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorStartMapLocationSpec = new MapLocationJSON.HoldingGenerator("field \"StartMapLocationSpec\" of the TypeNativeData class", false);
                fieldGeneratorDestinationMapLocationSpec = new MapLocationJSON.HoldingGenerator("field \"DestinationMapLocationSpec\" of the TypeNativeData class", false);
                fieldGeneratorImplicitStart = new JSONHoldingBooleanGenerator("field \"ImplicitStart\" of the TypeNativeData class");
                fieldGeneratorNavigationMethod = new FieldHoldingGeneratorNavigationMethod("field \"NavigationMethod\" of the TypeNativeData class");
                fieldGeneratorNavigate = new JSONHoldingBooleanGenerator("field \"Navigate\" of the TypeNativeData class");
                fieldGeneratorAsksForDistance = new JSONHoldingBooleanGenerator("field \"AsksForDistance\" of the TypeNativeData class");
                fieldGeneratorAsksForTravelTime = new JSONHoldingBooleanGenerator("field \"AsksForTravelTime\" of the TypeNativeData class");
                fieldGeneratorDistance = new JSONHoldingNumberTextGenerator("field \"Distance\" of the TypeNativeData class");
                fieldGeneratorUnitOfMeasureID = new JSONHoldingStringGenerator("field \"UnitOfMeasureID\" of the TypeNativeData class");
                fieldGeneratorUnitOfLengthSingular = new JSONHoldingStringGenerator("field \"UnitOfLengthSingular\" of the TypeNativeData class");
                fieldGeneratorUnitOfLengthPlural = new JSONHoldingStringGenerator("field \"UnitOfLengthPlural\" of the TypeNativeData class");
                fieldGeneratorTravelTime = new JSONHoldingNumberTextGenerator("field \"TravelTime\" of the TypeNativeData class");
                fieldGeneratorCorrectionState = new FieldHoldingGeneratorCorrectionState("field \"CorrectionState\" of the TypeNativeData class");
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorStartMapLocationSpec.reset();
                fieldGeneratorDestinationMapLocationSpec.reset();
                fieldGeneratorImplicitStart.reset();
                fieldGeneratorNavigationMethod.reset();
                fieldGeneratorNavigate.reset();
                fieldGeneratorAsksForDistance.reset();
                fieldGeneratorAsksForTravelTime.reset();
                fieldGeneratorDistance.reset();
                fieldGeneratorUnitOfMeasureID.reset();
                fieldGeneratorUnitOfLengthSingular.reset();
                fieldGeneratorUnitOfLengthPlural.reset();
                fieldGeneratorTravelTime.reset();
                fieldGeneratorCorrectionState.reset();
                base.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorStartMapLocationSpec.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorDestinationMapLocationSpec.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorStartMapLocationSpec.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorDestinationMapLocationSpec.set_allow_unpolished(new_allow_unpolished);
              }
          };
        public class HoldingGenerator : Generator
          {
            protected override void handle_result(TypeNativeDataJSON  result)
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
            public TypeNativeDataJSON value;
          };
        public class HoldingArrayGenerator : JSONArrayGenerator
      {
        protected class ElementHandler : Generator
          {
            private HoldingArrayGenerator top;

            protected override void handle_result(TypeNativeDataJSON  result)
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
        protected virtual void handle_result(List<TypeNativeDataJSON> result)

          {
          }

        public HoldingArrayGenerator(string what, bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            have_value = false;
            value = new List<TypeNativeDataJSON>();
            base.set_what(what);
          }
        public HoldingArrayGenerator(bool ignore_extras)
          {
            element_handler = new ElementHandler(this, ignore_extras);
            value = new List<TypeNativeDataJSON>();
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
        public List<TypeNativeDataJSON> value;
      };
      };
    private bool flagHasNativeData;
    private TypeNativeDataJSON  storeNativeData;
    private bool flagHasIntermediateDestinationRequested;
    private bool storeIntermediateDestinationRequested;
    private bool flagHasIntermediateDestinationPositionFromStart;
    private BigInteger storeIntermediateDestinationPositionFromStart;
    private bool flagHasIntermediateDestinationPositionFromEnd;
    private BigInteger storeIntermediateDestinationPositionFromEnd;
    private bool flagHasStartLocationDerivation;
    private LocationDerivationJSON  storeStartLocationDerivation;
    private bool flagHasDestinationLocationDerivation;
    private LocationDerivationJSON  storeDestinationLocationDerivation;
    private bool flagHasWaypointActionDisambiguationResult;
    private DynamicResponseJSON  storeWaypointActionDisambiguationResult;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }

    private JSONValue  extraIntermediateDestinationRequestedToJSON()
      {
        JSONValue generated_boolean_IntermediateDestinationRequested = (storeIntermediateDestinationRequested ? (JSONValue )new JSONTrueValue() : (JSONValue )new JSONFalseValue());
        return generated_boolean_IntermediateDestinationRequested;
      }

    private JSONValue  extraIntermediateDestinationPositionFromStartToJSON()
      {
        JSONIntegerValue generated_integer_IntermediateDestinationPositionFromStart = new JSONIntegerValue(storeIntermediateDestinationPositionFromStart);
        return generated_integer_IntermediateDestinationPositionFromStart;
      }

    private JSONValue  extraIntermediateDestinationPositionFromEndToJSON()
      {
        JSONIntegerValue generated_integer_IntermediateDestinationPositionFromEnd = new JSONIntegerValue(storeIntermediateDestinationPositionFromEnd);
        return generated_integer_IntermediateDestinationPositionFromEnd;
      }

    private JSONValue  extraStartLocationDerivationToJSON()
      {
        JSONValueHandler handler_StartLocationDerivation = new JSONValueHandler();
        storeStartLocationDerivation.write_as_json(handler_StartLocationDerivation);
        return handler_StartLocationDerivation.result;
      }

    private JSONValue  extraDestinationLocationDerivationToJSON()
      {
        JSONValueHandler handler_DestinationLocationDerivation = new JSONValueHandler();
        storeDestinationLocationDerivation.write_as_json(handler_DestinationLocationDerivation);
        return handler_DestinationLocationDerivation.result;
      }

    private JSONValue  extraWaypointActionDisambiguationResultToJSON()
      {
        JSONValueHandler handler_WaypointActionDisambiguationResult = new JSONValueHandler();
        storeWaypointActionDisambiguationResult.write_as_json(handler_WaypointActionDisambiguationResult);
        return handler_WaypointActionDisambiguationResult.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    private void  fromJSONIntermediateDestinationRequested(JSONValue json_value, bool ignore_extras)
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
                throw new Exception("The value for field IntermediateDestinationRequested of ShowDirectionsJSON is not true for false.");
              }
          }
        setIntermediateDestinationRequested(the_bool);
      }


    private void  fromJSONIntermediateDestinationPositionFromStart(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field IntermediateDestinationPositionFromStart of ShowDirectionsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field IntermediateDestinationPositionFromStart of ShowDirectionsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setIntermediateDestinationPositionFromStart(extracted_integer);
      }


    private void  fromJSONIntermediateDestinationPositionFromEnd(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field IntermediateDestinationPositionFromEnd of ShowDirectionsJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field IntermediateDestinationPositionFromEnd of ShowDirectionsJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setIntermediateDestinationPositionFromEnd(extracted_integer);
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


    private void  fromJSONWaypointActionDisambiguationResult(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        DynamicResponseJSON convert_classy = DynamicResponseJSON.from_json(json_value, ignore_extras, true);
        setWaypointActionDisambiguationResult(convert_classy);
      }


    public ShowDirectionsJSON()
      {
        flagHasNativeData = false;
        flagHasIntermediateDestinationRequested = false;
        flagHasIntermediateDestinationPositionFromStart = false;
        flagHasIntermediateDestinationPositionFromEnd = false;
        flagHasStartLocationDerivation = false;
        flagHasDestinationLocationDerivation = false;
        flagHasWaypointActionDisambiguationResult = false;
        storeIntermediateDestinationRequested = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getMapCommandKind()
      {
        return "ShowDirections";
      }

    public bool  hasNativeData()
      {
        return flagHasNativeData;
      }

    public TypeNativeDataJSON   getNativeData()
      {
        Debug.Assert(flagHasNativeData);
        return storeNativeData;
      }

    public bool  hasIntermediateDestinationRequested()
      {
        return flagHasIntermediateDestinationRequested;
      }

    public bool  getIntermediateDestinationRequested()
      {
        return storeIntermediateDestinationRequested;
      }

    public bool  hasIntermediateDestinationPositionFromStart()
      {
        return flagHasIntermediateDestinationPositionFromStart;
      }

    public BigInteger  getIntermediateDestinationPositionFromStart()
      {
        Debug.Assert(flagHasIntermediateDestinationPositionFromStart);
        return storeIntermediateDestinationPositionFromStart;
      }

    public bool  hasIntermediateDestinationPositionFromEnd()
      {
        return flagHasIntermediateDestinationPositionFromEnd;
      }

    public BigInteger  getIntermediateDestinationPositionFromEnd()
      {
        Debug.Assert(flagHasIntermediateDestinationPositionFromEnd);
        return storeIntermediateDestinationPositionFromEnd;
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

    public bool  hasWaypointActionDisambiguationResult()
      {
        return flagHasWaypointActionDisambiguationResult;
      }

    public DynamicResponseJSON   getWaypointActionDisambiguationResult()
      {
        Debug.Assert(flagHasWaypointActionDisambiguationResult);
        return storeWaypointActionDisambiguationResult;
      }


    public virtual int extraShowDirectionsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraShowDirectionsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraShowDirectionsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraShowDirectionsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraMapCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        if (flagHasIntermediateDestinationRequested)
            ++result;
        if (flagHasIntermediateDestinationPositionFromStart)
            ++result;
        if (flagHasIntermediateDestinationPositionFromEnd)
            ++result;
        if (flagHasStartLocationDerivation)
            ++result;
        if (flagHasDestinationLocationDerivation)
            ++result;
        if (flagHasWaypointActionDisambiguationResult)
            ++result;
        result += extraShowDirectionsComponentCount();
        return result;
      }
    public override string extraMapCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        if (flagHasIntermediateDestinationRequested)
          {
            if (remainder == 0)
                return "IntermediateDestinationRequested";
            --remainder;
          }
        if (flagHasIntermediateDestinationPositionFromStart)
          {
            if (remainder == 0)
                return "IntermediateDestinationPositionFromStart";
            --remainder;
          }
        if (flagHasIntermediateDestinationPositionFromEnd)
          {
            if (remainder == 0)
                return "IntermediateDestinationPositionFromEnd";
            --remainder;
          }
        if (flagHasStartLocationDerivation)
          {
            if (remainder == 0)
                return "StartLocationDerivation";
            --remainder;
          }
        if (flagHasDestinationLocationDerivation)
          {
            if (remainder == 0)
                return "DestinationLocationDerivation";
            --remainder;
          }
        if (flagHasWaypointActionDisambiguationResult)
          {
            if (remainder == 0)
                return "WaypointActionDisambiguationResult";
            --remainder;
          }
        return extraShowDirectionsComponentKey(remainder);
      }
    public override JSONValue extraMapCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        if (flagHasIntermediateDestinationRequested)
          {
            if (remainder == 0)
                return extraIntermediateDestinationRequestedToJSON();
            --remainder;
          }
        if (flagHasIntermediateDestinationPositionFromStart)
          {
            if (remainder == 0)
                return extraIntermediateDestinationPositionFromStartToJSON();
            --remainder;
          }
        if (flagHasIntermediateDestinationPositionFromEnd)
          {
            if (remainder == 0)
                return extraIntermediateDestinationPositionFromEndToJSON();
            --remainder;
          }
        if (flagHasStartLocationDerivation)
          {
            if (remainder == 0)
                return extraStartLocationDerivationToJSON();
            --remainder;
          }
        if (flagHasDestinationLocationDerivation)
          {
            if (remainder == 0)
                return extraDestinationLocationDerivationToJSON();
            --remainder;
          }
        if (flagHasWaypointActionDisambiguationResult)
          {
            if (remainder == 0)
                return extraWaypointActionDisambiguationResultToJSON();
            --remainder;
          }
        return extraShowDirectionsComponentValue(remainder);
      }
    public override JSONValue extraMapCommandLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'D':
                if ((String.Compare(field_name, 1, "estinationLocationDerivation", 0, 28, false) == 0) && (field_name.Length == 29))
                    return (flagHasDestinationLocationDerivation ? extraDestinationLocationDerivationToJSON() : null);
                break;
            case 'I':
                if (String.Compare(field_name, 1, "ntermediateDestination", 0, 22, false) == 0)
                  {
                    switch (field_name[23])
                      {
                        case 'P':
                            if (String.Compare(field_name, 24, "ositionFrom", 0, 11, false) == 0)
                              {
                                switch (field_name[35])
                                  {
                                    case 'E':
                                        if ((String.Compare(field_name, 36, "nd", 0, 2, false) == 0) && (field_name.Length == 38))
                                            return (flagHasIntermediateDestinationPositionFromEnd ? extraIntermediateDestinationPositionFromEndToJSON() : null);
                                        break;
                                    case 'S':
                                        if ((String.Compare(field_name, 36, "tart", 0, 4, false) == 0) && (field_name.Length == 40))
                                            return (flagHasIntermediateDestinationPositionFromStart ? extraIntermediateDestinationPositionFromStartToJSON() : null);
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if ((String.Compare(field_name, 24, "equested", 0, 8, false) == 0) && (field_name.Length == 32))
                                return (flagHasIntermediateDestinationRequested ? extraIntermediateDestinationRequestedToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                    return (flagHasNativeData ? extraNativeDataToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "tartLocationDerivation", 0, 22, false) == 0) && (field_name.Length == 23))
                    return (flagHasStartLocationDerivation ? extraStartLocationDerivationToJSON() : null);
                break;
            case 'W':
                if ((String.Compare(field_name, 1, "aypointActionDisambiguationResult", 0, 33, false) == 0) && (field_name.Length == 34))
                    return (flagHasWaypointActionDisambiguationResult ? extraWaypointActionDisambiguationResultToJSON() : null);
                break;
            default:
                break;
          }
        return extraShowDirectionsLookup(field_name);
      }

    public void setNativeData(TypeNativeDataJSON  new_value)
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = true;
        storeNativeData = new_value;
      }
    public void unsetNativeData()
      {
        if (flagHasNativeData)
          {
          }
        flagHasNativeData = false;
      }
    public void setIntermediateDestinationRequested(bool new_value)
      {
        flagHasIntermediateDestinationRequested = true;
        storeIntermediateDestinationRequested = new_value;
      }
    public void unsetIntermediateDestinationRequested()
      {
        flagHasIntermediateDestinationRequested = false;
      }
    public void setIntermediateDestinationPositionFromStart(BigInteger new_value)
      {
        flagHasIntermediateDestinationPositionFromStart = true;
        if (new_value < 0)
            throw new Exception("The value for field IntermediateDestinationPositionFromStart of ShowDirectionsJSON is less than the lower bound (0) for that field.");
        storeIntermediateDestinationPositionFromStart = new_value;
      }
    public void unsetIntermediateDestinationPositionFromStart()
      {
        flagHasIntermediateDestinationPositionFromStart = false;
      }
    public void setIntermediateDestinationPositionFromEnd(BigInteger new_value)
      {
        flagHasIntermediateDestinationPositionFromEnd = true;
        if (new_value < 0)
            throw new Exception("The value for field IntermediateDestinationPositionFromEnd of ShowDirectionsJSON is less than the lower bound (0) for that field.");
        storeIntermediateDestinationPositionFromEnd = new_value;
      }
    public void unsetIntermediateDestinationPositionFromEnd()
      {
        flagHasIntermediateDestinationPositionFromEnd = false;
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
    public void setWaypointActionDisambiguationResult(DynamicResponseJSON  new_value)
      {
        if (flagHasWaypointActionDisambiguationResult)
          {
          }
        flagHasWaypointActionDisambiguationResult = true;
        storeWaypointActionDisambiguationResult = new_value;
      }
    public void unsetWaypointActionDisambiguationResult()
      {
        if (flagHasWaypointActionDisambiguationResult)
          {
          }
        flagHasWaypointActionDisambiguationResult = false;
      }

    public virtual void extraShowDirectionsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraShowDirectionsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraShowDirectionsLookup(key);
        if (old_field == null)
          {
            extraShowDirectionsAppendPair(key, new_component);
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
    public override void extraMapCommandAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "estinationLocationDerivation", 0, 28, false) == 0) && (key.Length == 29))
                    {
                    fromJSONDestinationLocationDerivation(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if (String.Compare(key, 1, "ntermediateDestination", 0, 22, false) == 0)
                  {
                    switch (key[23])
                      {
                        case 'P':
                            if (String.Compare(key, 24, "ositionFrom", 0, 11, false) == 0)
                              {
                                switch (key[35])
                                  {
                                    case 'E':
                                        if ((String.Compare(key, 36, "nd", 0, 2, false) == 0) && (key.Length == 38))
                                            {
                                            fromJSONIntermediateDestinationPositionFromEnd(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'S':
                                        if ((String.Compare(key, 36, "tart", 0, 4, false) == 0) && (key.Length == 40))
                                            {
                                            fromJSONIntermediateDestinationPositionFromStart(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if ((String.Compare(key, 24, "equested", 0, 8, false) == 0) && (key.Length == 32))
                                {
                                fromJSONIntermediateDestinationRequested(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartLocationDerivation", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONStartLocationDerivation(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "aypointActionDisambiguationResult", 0, 33, false) == 0) && (key.Length == 34))
                    {
                    fromJSONWaypointActionDisambiguationResult(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraShowDirectionsAppendPair(key, new_component);
      }
    public override void extraMapCommandSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'D':
                if ((String.Compare(key, 1, "estinationLocationDerivation", 0, 28, false) == 0) && (key.Length == 29))
                    {
                    fromJSONDestinationLocationDerivation(new_component, false);
                    return;
                    }
                break;
            case 'I':
                if (String.Compare(key, 1, "ntermediateDestination", 0, 22, false) == 0)
                  {
                    switch (key[23])
                      {
                        case 'P':
                            if (String.Compare(key, 24, "ositionFrom", 0, 11, false) == 0)
                              {
                                switch (key[35])
                                  {
                                    case 'E':
                                        if ((String.Compare(key, 36, "nd", 0, 2, false) == 0) && (key.Length == 38))
                                            {
                                            fromJSONIntermediateDestinationPositionFromEnd(new_component, false);
                                            return;
                                            }
                                        break;
                                    case 'S':
                                        if ((String.Compare(key, 36, "tart", 0, 4, false) == 0) && (key.Length == 40))
                                            {
                                            fromJSONIntermediateDestinationPositionFromStart(new_component, false);
                                            return;
                                            }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if ((String.Compare(key, 24, "equested", 0, 8, false) == 0) && (key.Length == 32))
                                {
                                fromJSONIntermediateDestinationRequested(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            case 'N':
                if ((String.Compare(key, 1, "ativeData", 0, 9, false) == 0) && (key.Length == 10))
                    {
                    fromJSONNativeData(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "tartLocationDerivation", 0, 22, false) == 0) && (key.Length == 23))
                    {
                    fromJSONStartLocationDerivation(new_component, false);
                    return;
                    }
                break;
            case 'W':
                if ((String.Compare(key, 1, "aypointActionDisambiguationResult", 0, 33, false) == 0) && (key.Length == 34))
                    {
                    fromJSONWaypointActionDisambiguationResult(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraShowDirectionsSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasNativeData);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
          }
        if (flagHasIntermediateDestinationRequested)
          {
            handler.start_pair("IntermediateDestinationRequested");
            handler.boolean_value(storeIntermediateDestinationRequested);
          }
        if (flagHasIntermediateDestinationPositionFromStart)
          {
            handler.start_pair("IntermediateDestinationPositionFromStart");
            handler.number_value(storeIntermediateDestinationPositionFromStart);
          }
        if (flagHasIntermediateDestinationPositionFromEnd)
          {
            handler.start_pair("IntermediateDestinationPositionFromEnd");
            handler.number_value(storeIntermediateDestinationPositionFromEnd);
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
        if (flagHasWaypointActionDisambiguationResult)
          {
            handler.start_pair("WaypointActionDisambiguationResult");
            if (partial_allowed)
                storeWaypointActionDisambiguationResult.write_partial_as_json(handler);
            else
                storeWaypointActionDisambiguationResult.write_as_json(handler);
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
        if (!(hasNativeData()))
          {
            return "When parsing the object for %what%, the \"NativeData\" field was missing.";
          }
        return null;
      }

    public static new ShowDirectionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowDirectionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowDirections", ignore_extras);
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
    public static new ShowDirectionsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowDirectionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        ShowDirectionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowDirections", ignore_extras);
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
    public static new ShowDirectionsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new ShowDirectionsJSON from_text(string text, bool ignore_extras)
      {
        ShowDirectionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowDirections", ignore_extras);
            JSONParse.parse_json_value(text, "Text for ShowDirectionsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new ShowDirectionsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        ShowDirectionsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type ShowDirections", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MapCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;
        private JSONHoldingBooleanGenerator fieldGeneratorIntermediateDestinationRequested;
    private class FieldHoldingGeneratorIntermediateDestinationPositionFromStart : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorIntermediateDestinationPositionFromStart(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorIntermediateDestinationPositionFromStart : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorIntermediateDestinationPositionFromStart(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorIntermediateDestinationPositionFromStart fieldGeneratorIntermediateDestinationPositionFromStart;
    private class FieldHoldingGeneratorIntermediateDestinationPositionFromEnd : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorIntermediateDestinationPositionFromEnd(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorIntermediateDestinationPositionFromEnd : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorIntermediateDestinationPositionFromEnd(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorIntermediateDestinationPositionFromEnd fieldGeneratorIntermediateDestinationPositionFromEnd;
        private LocationDerivationJSON.HoldingGenerator fieldGeneratorStartLocationDerivation;
        private LocationDerivationJSON.HoldingGenerator fieldGeneratorDestinationLocationDerivation;
        private DynamicResponseJSON.HoldingGenerator fieldGeneratorWaypointActionDisambiguationResult;
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
            if (!(getMapCommandJSONKey().Equals("ShowDirections")))
                throw new Exception("The key field has a value other than `ShowDirections'.");
            ShowDirectionsJSON result = new ShowDirectionsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraShowDirectionsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(MapCommandJSON new_result)
          {
            handle_result((ShowDirectionsJSON )new_result);
          }
        protected void finish(ShowDirectionsJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            else if ((!(result.hasNativeData())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"NativeData\" field was missing.");
              }
            if (fieldGeneratorIntermediateDestinationRequested.have_value)
              {
                result.setIntermediateDestinationRequested(fieldGeneratorIntermediateDestinationRequested.value);
                fieldGeneratorIntermediateDestinationRequested.have_value = false;
              }
            if (fieldGeneratorIntermediateDestinationPositionFromStart.have_value)
              {
                result.setIntermediateDestinationPositionFromStart(fieldGeneratorIntermediateDestinationPositionFromStart.value);
                fieldGeneratorIntermediateDestinationPositionFromStart.have_value = false;
              }
            if (fieldGeneratorIntermediateDestinationPositionFromEnd.have_value)
              {
                result.setIntermediateDestinationPositionFromEnd(fieldGeneratorIntermediateDestinationPositionFromEnd.value);
                fieldGeneratorIntermediateDestinationPositionFromEnd.have_value = false;
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
            if (fieldGeneratorWaypointActionDisambiguationResult.have_value)
              {
                result.setWaypointActionDisambiguationResult(fieldGeneratorWaypointActionDisambiguationResult.value);
                fieldGeneratorWaypointActionDisambiguationResult.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(ShowDirectionsJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'D':
                    if ((String.Compare(field_name, 1, "estinationLocationDerivation", 0, 28, false) == 0) && (field_name.Length == 29))
                        return fieldGeneratorDestinationLocationDerivation;
                    break;
                case 'I':
                    if (String.Compare(field_name, 1, "ntermediateDestination", 0, 22, false) == 0)
                      {
                        switch (field_name[23])
                          {
                            case 'P':
                                if (String.Compare(field_name, 24, "ositionFrom", 0, 11, false) == 0)
                                  {
                                    switch (field_name[35])
                                      {
                                        case 'E':
                                            if ((String.Compare(field_name, 36, "nd", 0, 2, false) == 0) && (field_name.Length == 38))
                                                return fieldGeneratorIntermediateDestinationPositionFromEnd;
                                            break;
                                        case 'S':
                                            if ((String.Compare(field_name, 36, "tart", 0, 4, false) == 0) && (field_name.Length == 40))
                                                return fieldGeneratorIntermediateDestinationPositionFromStart;
                                            break;
                                        default:
                                            break;
                                      }
                                  }
                                break;
                            case 'R':
                                if ((String.Compare(field_name, 24, "equested", 0, 8, false) == 0) && (field_name.Length == 32))
                                    return fieldGeneratorIntermediateDestinationRequested;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "ativeData", 0, 9, false) == 0) && (field_name.Length == 10))
                        return fieldGeneratorNativeData;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tartLocationDerivation", 0, 22, false) == 0) && (field_name.Length == 23))
                        return fieldGeneratorStartLocationDerivation;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "aypointActionDisambiguationResult", 0, 33, false) == 0) && (field_name.Length == 34))
                        return fieldGeneratorWaypointActionDisambiguationResult;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the ShowDirections class", ignore_extras);
            fieldGeneratorIntermediateDestinationRequested = new JSONHoldingBooleanGenerator("field \"IntermediateDestinationRequested\" of the ShowDirections class");
            fieldGeneratorIntermediateDestinationPositionFromStart = new FieldHoldingGeneratorIntermediateDestinationPositionFromStart("field \"IntermediateDestinationPositionFromStart\" of the ShowDirections class");
            fieldGeneratorIntermediateDestinationPositionFromEnd = new FieldHoldingGeneratorIntermediateDestinationPositionFromEnd("field \"IntermediateDestinationPositionFromEnd\" of the ShowDirections class");
            fieldGeneratorStartLocationDerivation = new LocationDerivationJSON.HoldingGenerator("field \"StartLocationDerivation\" of the ShowDirections class", ignore_extras);
            fieldGeneratorDestinationLocationDerivation = new LocationDerivationJSON.HoldingGenerator("field \"DestinationLocationDerivation\" of the ShowDirections class", ignore_extras);
            fieldGeneratorWaypointActionDisambiguationResult = new DynamicResponseJSON.HoldingGenerator("field \"WaypointActionDisambiguationResult\" of the ShowDirections class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the ShowDirections class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the ShowDirections class", false);
            fieldGeneratorIntermediateDestinationRequested = new JSONHoldingBooleanGenerator("field \"IntermediateDestinationRequested\" of the ShowDirections class");
            fieldGeneratorIntermediateDestinationPositionFromStart = new FieldHoldingGeneratorIntermediateDestinationPositionFromStart("field \"IntermediateDestinationPositionFromStart\" of the ShowDirections class");
            fieldGeneratorIntermediateDestinationPositionFromEnd = new FieldHoldingGeneratorIntermediateDestinationPositionFromEnd("field \"IntermediateDestinationPositionFromEnd\" of the ShowDirections class");
            fieldGeneratorStartLocationDerivation = new LocationDerivationJSON.HoldingGenerator("field \"StartLocationDerivation\" of the ShowDirections class", false);
            fieldGeneratorDestinationLocationDerivation = new LocationDerivationJSON.HoldingGenerator("field \"DestinationLocationDerivation\" of the ShowDirections class", false);
            fieldGeneratorWaypointActionDisambiguationResult = new DynamicResponseJSON.HoldingGenerator("field \"WaypointActionDisambiguationResult\" of the ShowDirections class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the ShowDirections class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            fieldGeneratorIntermediateDestinationRequested.reset();
            fieldGeneratorIntermediateDestinationPositionFromStart.reset();
            fieldGeneratorIntermediateDestinationPositionFromEnd.reset();
            fieldGeneratorStartLocationDerivation.reset();
            fieldGeneratorDestinationLocationDerivation.reset();
            fieldGeneratorWaypointActionDisambiguationResult.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(ShowDirectionsJSON  result)
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
        public ShowDirectionsJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(ShowDirectionsJSON  result)
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
    protected virtual void handle_result(List<ShowDirectionsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<ShowDirectionsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<ShowDirectionsJSON>();
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
    public List<ShowDirectionsJSON> value;
  };
  };
