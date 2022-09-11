/* file "SportsShowResultsCommandJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class SportsShowResultsCommandJSON : SportsCommandJSON
  {
    public class TypeNativeDataJSON : JSONBase
      {
        public enum TypeResultsTypeKnownValues
          {
            ResultsType_Unknown,
            ResultsType_SameTeam,
            ResultsType_Generic,
            ResultsType_Series,
            ResultsType_PlayoffsComplete,
            ResultsType__none
          };
        public struct TypeResultsType
          {
            public bool in_known_list;
            public string string_value;
            public TypeResultsTypeKnownValues list_value;
          };

        public static TypeResultsTypeKnownValues  stringToResultsType(string chars)
          {
            switch (chars[0])
              {
                case 'G':
                    if ((String.Compare(chars, 1, "eneric", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeResultsTypeKnownValues.ResultsType_Generic;
                    break;
                case 'P':
                    if ((String.Compare(chars, 1, "layoffsComplete", 0, 15, false) == 0) && (chars.Length == 16))
                        return TypeResultsTypeKnownValues.ResultsType_PlayoffsComplete;
                    break;
                case 'S':
                    switch (chars[1])
                      {
                        case 'a':
                            if ((String.Compare(chars, 2, "meTeam", 0, 6, false) == 0) && (chars.Length == 8))
                                return TypeResultsTypeKnownValues.ResultsType_SameTeam;
                            break;
                        case 'e':
                            if ((String.Compare(chars, 2, "ries", 0, 4, false) == 0) && (chars.Length == 6))
                                return TypeResultsTypeKnownValues.ResultsType_Series;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if ((String.Compare(chars, 1, "nknown", 0, 6, false) == 0) && (chars.Length == 7))
                        return TypeResultsTypeKnownValues.ResultsType_Unknown;
                    break;
                default:
                    break;
              }
            return TypeResultsTypeKnownValues.ResultsType__none;
          }

        public static string  stringFromResultsType(TypeResultsTypeKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeResultsTypeKnownValues.ResultsType_Unknown:
                    return "Unknown";
                case TypeResultsTypeKnownValues.ResultsType_SameTeam:
                    return "SameTeam";
                case TypeResultsTypeKnownValues.ResultsType_Generic:
                    return "Generic";
                case TypeResultsTypeKnownValues.ResultsType_Series:
                    return "Series";
                case TypeResultsTypeKnownValues.ResultsType_PlayoffsComplete:
                    return "PlayoffsComplete";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        public enum TypeResultErrorKnownValues
          {
            ResultError_None,
            ResultError_ScoreNotFound,
            ResultError_NotSupported,
            ResultError_LocationUnavailable,
            ResultError__none
          };
        public struct TypeResultError
          {
            public bool in_known_list;
            public string string_value;
            public TypeResultErrorKnownValues list_value;
          };

        public static TypeResultErrorKnownValues  stringToResultError(string chars)
          {
            switch (chars[0])
              {
                case 'L':
                    if ((String.Compare(chars, 1, "ocationUnavailable", 0, 18, false) == 0) && (chars.Length == 19))
                        return TypeResultErrorKnownValues.ResultError_LocationUnavailable;
                    break;
                case 'N':
                    if (String.Compare(chars, 1, "o", 0, 1, false) == 0)
                      {
                        switch (chars[2])
                          {
                            case 'n':
                                if ((String.Compare(chars, 3, "e", 0, 1, false) == 0) && (chars.Length == 4))
                                    return TypeResultErrorKnownValues.ResultError_None;
                                break;
                            case 't':
                                if ((String.Compare(chars, 3, "Supported", 0, 9, false) == 0) && (chars.Length == 12))
                                    return TypeResultErrorKnownValues.ResultError_NotSupported;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(chars, 1, "coreNotFound", 0, 12, false) == 0) && (chars.Length == 13))
                        return TypeResultErrorKnownValues.ResultError_ScoreNotFound;
                    break;
                default:
                    break;
              }
            return TypeResultErrorKnownValues.ResultError__none;
          }

        public static string  stringFromResultError(TypeResultErrorKnownValues the_enum)
          {
            switch (the_enum)
              {
                case TypeResultErrorKnownValues.ResultError_None:
                    return "None";
                case TypeResultErrorKnownValues.ResultError_ScoreNotFound:
                    return "ScoreNotFound";
                case TypeResultErrorKnownValues.ResultError_NotSupported:
                    return "NotSupported";
                case TypeResultErrorKnownValues.ResultError_LocationUnavailable:
                    return "LocationUnavailable";
                default:
                    Debug.Assert(false);
                    return null;
              }
          }

        private bool flagHasSportsResultScore;
        private List< SportsResultScoreJSON  > storeSportsResultScore;
        private bool flagHasSeriesStatus;
        private SportsSeriesStatusJSON  storeSeriesStatus;
        private bool flagHasResultsType;
        private TypeResultsType storeResultsType;
        private bool flagHasResultError;
        private TypeResultError storeResultError;
        private bool flagHasSportsInputData;
        private SportsInputDataJSON  storeSportsInputData;
        private bool flagHasNow;
        private DateAndOrTimeJSON  storeNow;
        private bool flagHasLatitude;
        private double storeLatitude;
        private string textStoreLatitude;
        private bool flagHasLongitude;
        private double storeLongitude;
        private string textStoreLongitude;
        private bool flagHasDateLocationConstraintsDropped;
        private bool storeDateLocationConstraintsDropped;
        private bool flagHasWebCommandEnabled;
        private bool storeWebCommandEnabled;
        private List<string> extraKeys;
        private List<JSONValue > extraValues;
        private Dictionary<string, JSONValue > extraIndex;


        private void  fromJSONSportsResultScore(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONArrayValue json_array1 = json_value.array_value();
            if (json_array1 == null)
                throw new Exception("The value for field SportsResultScore of TypeNativeDataJSON is not an array.");
            int count1 = json_array1.componentCount();
            if (count1 < 1)
                throw new Exception("The value for field SportsResultScore of TypeNativeDataJSON has too few elements.");
            List< SportsResultScoreJSON  > vector_SportsResultScore1 = new List< SportsResultScoreJSON  >(count1);
            for (int num1 = 0; num1 < count1; ++num1)
              {
                SportsResultScoreJSON convert_classy = SportsResultScoreJSON.from_json(json_array1.component(num1), ignore_extras, true);
                vector_SportsResultScore1.Add(convert_classy);
              }
            Debug.Assert(vector_SportsResultScore1.Count >= 1);
            initSportsResultScore();
            for (int num1 = 0; num1 < vector_SportsResultScore1.Count; ++num1)
                appendSportsResultScore(vector_SportsResultScore1[num1]);
            for (int num1 = 0; num1 < vector_SportsResultScore1.Count; ++num1)
              {
              }
          }


        private void  fromJSONSeriesStatus(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsSeriesStatusJSON convert_classy = SportsSeriesStatusJSON.from_json(json_value, ignore_extras, true);
            setSeriesStatus(convert_classy);
          }


        private void  fromJSONResultsType(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ResultsType of TypeNativeDataJSON is not a string.");
            TypeResultsType the_open_enum = new TypeResultsType();
            switch (json_string.getData()[0])
              {
                case 'G':
                    if ((String.Compare(json_string.getData(), 1, "eneric", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeResultsTypeKnownValues.ResultsType_Generic;
                            goto open_enum_is_done;
                          }
                    break;
                case 'P':
                    if ((String.Compare(json_string.getData(), 1, "layoffsComplete", 0, 15, false) == 0) && (json_string.getData().Length == 16))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeResultsTypeKnownValues.ResultsType_PlayoffsComplete;
                            goto open_enum_is_done;
                          }
                    break;
                case 'S':
                    switch (json_string.getData()[1])
                      {
                        case 'a':
                            if ((String.Compare(json_string.getData(), 2, "meTeam", 0, 6, false) == 0) && (json_string.getData().Length == 8))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeResultsTypeKnownValues.ResultsType_SameTeam;
                                    goto open_enum_is_done;
                                  }
                            break;
                        case 'e':
                            if ((String.Compare(json_string.getData(), 2, "ries", 0, 4, false) == 0) && (json_string.getData().Length == 6))
                                  {
                                    the_open_enum.in_known_list = true;
                                    the_open_enum.list_value = TypeResultsTypeKnownValues.ResultsType_Series;
                                    goto open_enum_is_done;
                                  }
                            break;
                        default:
                            break;
                      }
                    break;
                case 'U':
                    if ((String.Compare(json_string.getData(), 1, "nknown", 0, 6, false) == 0) && (json_string.getData().Length == 7))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeResultsTypeKnownValues.ResultsType_Unknown;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setResultsType(the_open_enum);
          }


        private void  fromJSONResultError(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            JSONStringValue json_string = json_value.string_value();
            if (json_string == null)
                throw new Exception("The value for field ResultError of TypeNativeDataJSON is not a string.");
            TypeResultError the_open_enum = new TypeResultError();
            switch (json_string.getData()[0])
              {
                case 'L':
                    if ((String.Compare(json_string.getData(), 1, "ocationUnavailable", 0, 18, false) == 0) && (json_string.getData().Length == 19))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeResultErrorKnownValues.ResultError_LocationUnavailable;
                            goto open_enum_is_done;
                          }
                    break;
                case 'N':
                    if (String.Compare(json_string.getData(), 1, "o", 0, 1, false) == 0)
                      {
                        switch (json_string.getData()[2])
                          {
                            case 'n':
                                if ((String.Compare(json_string.getData(), 3, "e", 0, 1, false) == 0) && (json_string.getData().Length == 4))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeResultErrorKnownValues.ResultError_None;
                                        goto open_enum_is_done;
                                      }
                                break;
                            case 't':
                                if ((String.Compare(json_string.getData(), 3, "Supported", 0, 9, false) == 0) && (json_string.getData().Length == 12))
                                      {
                                        the_open_enum.in_known_list = true;
                                        the_open_enum.list_value = TypeResultErrorKnownValues.ResultError_NotSupported;
                                        goto open_enum_is_done;
                                      }
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if ((String.Compare(json_string.getData(), 1, "coreNotFound", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                          {
                            the_open_enum.in_known_list = true;
                            the_open_enum.list_value = TypeResultErrorKnownValues.ResultError_ScoreNotFound;
                            goto open_enum_is_done;
                          }
                    break;
                default:
                    break;
              }
            the_open_enum.in_known_list = false;
            the_open_enum.string_value = json_string.getData();
          open_enum_is_done:;
            setResultError(the_open_enum);
          }


        private void  fromJSONSportsInputData(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            SportsInputDataJSON convert_classy = SportsInputDataJSON.from_json(json_value, ignore_extras, true);
            setSportsInputData(convert_classy);
          }


        private void  fromJSONNow(JSONValue json_value, bool ignore_extras)
          {
            Debug.Assert(json_value != null);
            DateAndOrTimeJSON convert_classy = DateAndOrTimeJSON.from_json(json_value, ignore_extras, true);
            setNow(convert_classy);
          }


        private void  fromJSONLatitude(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Latitude of TypeNativeDataJSON is not a number.");
                  }
              }
            setLatitudeText(the_rational_text);
          }


        private void  fromJSONLongitude(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field Longitude of TypeNativeDataJSON is not a number.");
                  }
              }
            setLongitudeText(the_rational_text);
          }


        private void  fromJSONDateLocationConstraintsDropped(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field DateLocationConstraintsDropped of TypeNativeDataJSON is not true for false.");
                  }
              }
            setDateLocationConstraintsDropped(the_bool);
          }


        private void  fromJSONWebCommandEnabled(JSONValue json_value, bool ignore_extras)
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
                    throw new Exception("The value for field WebCommandEnabled of TypeNativeDataJSON is not true for false.");
                  }
              }
            setWebCommandEnabled(the_bool);
          }


        public TypeNativeDataJSON()
          {
            flagHasSportsResultScore = false;
            flagHasSeriesStatus = false;
            flagHasResultsType = false;
            flagHasResultError = false;
            flagHasSportsInputData = false;
            flagHasNow = false;
            flagHasLatitude = false;
            flagHasLongitude = false;
            flagHasDateLocationConstraintsDropped = false;
            flagHasWebCommandEnabled = false;
            storeSportsResultScore = new List< SportsResultScoreJSON  >();
            extraKeys = new List<string>();
        extraValues = new List<JSONValue >();
        extraIndex = new Dictionary<string, JSONValue >();
          }

        public bool  hasSportsResultScore()
          {
            return flagHasSportsResultScore;
          }

        public int  countOfSportsResultScore()
          {
            Debug.Assert(flagHasSportsResultScore);
            return storeSportsResultScore.Count;
          }

        public SportsResultScoreJSON   elementOfSportsResultScore(int element_num)
          {
            Debug.Assert(flagHasSportsResultScore);
            return storeSportsResultScore[element_num];
          }

        public List< SportsResultScoreJSON  >  getSportsResultScore()
          {
            Debug.Assert(flagHasSportsResultScore);
            return storeSportsResultScore;
          }

        public bool  hasSeriesStatus()
          {
            return flagHasSeriesStatus;
          }

        public SportsSeriesStatusJSON   getSeriesStatus()
          {
            Debug.Assert(flagHasSeriesStatus);
            return storeSeriesStatus;
          }

        public bool  hasResultsType()
          {
            return flagHasResultsType;
          }

        public TypeResultsType  getResultsType()
          {
            Debug.Assert(flagHasResultsType);
            return storeResultsType;
          }

        public string  getResultsTypeAsString()
          {
            TypeResultsType result = getResultsType();
            if (result.in_known_list)
                return stringFromResultsType(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasResultError()
          {
            return flagHasResultError;
          }

        public TypeResultError  getResultError()
          {
            Debug.Assert(flagHasResultError);
            return storeResultError;
          }

        public string  getResultErrorAsString()
          {
            TypeResultError result = getResultError();
            if (result.in_known_list)
                return stringFromResultError(result.list_value);
            else
                return result.string_value;
          }

        public bool  hasSportsInputData()
          {
            return flagHasSportsInputData;
          }

        public SportsInputDataJSON   getSportsInputData()
          {
            Debug.Assert(flagHasSportsInputData);
            return storeSportsInputData;
          }

        public bool  hasNow()
          {
            return flagHasNow;
          }

        public DateAndOrTimeJSON   getNow()
          {
            Debug.Assert(flagHasNow);
            return storeNow;
          }

        public bool  hasLatitude()
          {
            return flagHasLatitude;
          }

        public double  getLatitude()
          {
            Debug.Assert(flagHasLatitude);
            if (textStoreLatitude != "")
              {
                return Double.Parse(textStoreLatitude);
              }
            return storeLatitude;
          }

        public string  getLatitudeAsText()
          {
            Debug.Assert(flagHasLatitude);
            if (textStoreLatitude == "")
              {
                return Convert.ToString(storeLatitude);
              }
            else
              {
                return (textStoreLatitude);
              }
          }

        public bool  hasLongitude()
          {
            return flagHasLongitude;
          }

        public double  getLongitude()
          {
            Debug.Assert(flagHasLongitude);
            if (textStoreLongitude != "")
              {
                return Double.Parse(textStoreLongitude);
              }
            return storeLongitude;
          }

        public string  getLongitudeAsText()
          {
            Debug.Assert(flagHasLongitude);
            if (textStoreLongitude == "")
              {
                return Convert.ToString(storeLongitude);
              }
            else
              {
                return (textStoreLongitude);
              }
          }

        public bool  hasDateLocationConstraintsDropped()
          {
            return flagHasDateLocationConstraintsDropped;
          }

        public bool  getDateLocationConstraintsDropped()
          {
            Debug.Assert(flagHasDateLocationConstraintsDropped);
            return storeDateLocationConstraintsDropped;
          }

        public bool  hasWebCommandEnabled()
          {
            return flagHasWebCommandEnabled;
          }

        public bool  getWebCommandEnabled()
          {
            Debug.Assert(flagHasWebCommandEnabled);
            return storeWebCommandEnabled;
          }


        public virtual int extraTypeNativeDataComponentCount()
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            return extraKeys.Count;
          }
        public virtual string extraTypeNativeDataComponentKey(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraKeys[component_num];
          }
        public virtual JSONValue extraTypeNativeDataComponentValue(int component_num)
          {
            Debug.Assert(extraKeys.Count == extraValues.Count);
            Debug.Assert(component_num < extraValues.Count);
            return extraValues[component_num];
          }
        public virtual JSONValue extraTypeNativeDataLookup(string field_name)
          {
            JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
            return result;
          }

        public void initSportsResultScore()
          {
            if (flagHasSportsResultScore)
              {
                for (int num1 = 0; num1 < storeSportsResultScore.Count; ++num1)
                  {
                  }
              }
            flagHasSportsResultScore = true;
            storeSportsResultScore.Clear();
          }
        public void appendSportsResultScore(SportsResultScoreJSON  to_append)
          {
            if (!flagHasSportsResultScore)
              {
                flagHasSportsResultScore = true;
                storeSportsResultScore.Clear();
              }
            Debug.Assert(flagHasSportsResultScore);
            storeSportsResultScore.Add(to_append);
          }
        public void unsetSportsResultScore()
          {
            if (flagHasSportsResultScore)
              {
                for (int num2 = 0; num2 < storeSportsResultScore.Count; ++num2)
                  {
                  }
              }
            flagHasSportsResultScore = false;
            storeSportsResultScore.Clear();
          }
        public void setSeriesStatus(SportsSeriesStatusJSON  new_value)
          {
            if (flagHasSeriesStatus)
              {
              }
            flagHasSeriesStatus = true;
            storeSeriesStatus = new_value;
          }
        public void unsetSeriesStatus()
          {
            if (flagHasSeriesStatus)
              {
              }
            flagHasSeriesStatus = false;
          }
        public void setResultsType(TypeResultsType new_value)
          {
            flagHasResultsType = true;
            storeResultsType = new_value;
          }
        public void setResultsType(string chars)
          {
            TypeResultsTypeKnownValues known = stringToResultsType(chars);
            TypeResultsType new_value = new TypeResultsType();
            if (known == TypeResultsTypeKnownValues.ResultsType__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setResultsType(new_value);
          }
        public void setResultsType(TypeResultsTypeKnownValues new_value)
          {
            TypeResultsType new_full_value = new TypeResultsType();
            Debug.Assert(new_value != TypeResultsTypeKnownValues.ResultsType__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setResultsType(new_full_value);
          }
        public void unsetResultsType()
          {
            flagHasResultsType = false;
          }
        public void setResultError(TypeResultError new_value)
          {
            flagHasResultError = true;
            storeResultError = new_value;
          }
        public void setResultError(string chars)
          {
            TypeResultErrorKnownValues known = stringToResultError(chars);
            TypeResultError new_value = new TypeResultError();
            if (known == TypeResultErrorKnownValues.ResultError__none)
              {
                new_value.in_known_list = false;
                new_value.string_value = chars;
              }
            else
              {
                new_value.in_known_list = true;
                new_value.list_value = known;
              }
            setResultError(new_value);
          }
        public void setResultError(TypeResultErrorKnownValues new_value)
          {
            TypeResultError new_full_value = new TypeResultError();
            Debug.Assert(new_value != TypeResultErrorKnownValues.ResultError__none);
            new_full_value.in_known_list = true;
            new_full_value.list_value = new_value;
            setResultError(new_full_value);
          }
        public void unsetResultError()
          {
            flagHasResultError = false;
          }
        public void setSportsInputData(SportsInputDataJSON  new_value)
          {
            if (flagHasSportsInputData)
              {
              }
            flagHasSportsInputData = true;
            storeSportsInputData = new_value;
          }
        public void unsetSportsInputData()
          {
            if (flagHasSportsInputData)
              {
              }
            flagHasSportsInputData = false;
          }
        public void setNow(DateAndOrTimeJSON  new_value)
          {
            if (flagHasNow)
              {
              }
            flagHasNow = true;
            storeNow = new_value;
          }
        public void unsetNow()
          {
            if (flagHasNow)
              {
              }
            flagHasNow = false;
          }
        public void setLatitude(double new_value)
          {
            flagHasLatitude = true;
            if (new_value < -90)
                throw new Exception("The value for field Latitude of TypeNativeDataJSON is less than the lower bound (-90) for that field.");
            if (new_value > 90)
                throw new Exception("The value for field Latitude of TypeNativeDataJSON is greater than the upper bound (90) for that field.");
            storeLatitude = new_value;
            textStoreLatitude = "";
          }
        public void setLatitudeText(string new_value)
          {
            flagHasLatitude = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Latitude of TypeNativeDataJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "90", "", false, "2") < 0)
                throw new Exception("The value for field Latitude of TypeNativeDataJSON is less than the lower bound (-90) for that field.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "90", "", false, "2") > 0)
                throw new Exception("The value for field Latitude of TypeNativeDataJSON is greater than the upper bound (90) for that field.");
            textStoreLatitude = new_value;
          }
        public void unsetLatitude()
          {
            flagHasLatitude = false;
          }
        public void setLongitude(double new_value)
          {
            flagHasLongitude = true;
            if (new_value < -180)
                throw new Exception("The value for field Longitude of TypeNativeDataJSON is less than the lower bound (-180) for that field.");
            if (new_value > 180)
                throw new Exception("The value for field Longitude of TypeNativeDataJSON is greater than the upper bound (180) for that field.");
            storeLongitude = new_value;
            textStoreLongitude = "";
          }
        public void setLongitudeText(string new_value)
          {
            flagHasLongitude = true;
            if (!(JSONWriter.is_valid_number_format(new_value)))
                throw new Exception("The text value for field Longitude of TypeNativeDataJSON is not a valid number.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, true, "180", "", false, "3") < 0)
                throw new Exception("The value for field Longitude of TypeNativeDataJSON is less than the lower bound (-180) for that field.");
            if (JSONWriter.compare_number_text_to_repeating_fraction(new_value, false, "180", "", false, "3") > 0)
                throw new Exception("The value for field Longitude of TypeNativeDataJSON is greater than the upper bound (180) for that field.");
            textStoreLongitude = new_value;
          }
        public void unsetLongitude()
          {
            flagHasLongitude = false;
          }
        public void setDateLocationConstraintsDropped(bool new_value)
          {
            flagHasDateLocationConstraintsDropped = true;
            storeDateLocationConstraintsDropped = new_value;
          }
        public void unsetDateLocationConstraintsDropped()
          {
            flagHasDateLocationConstraintsDropped = false;
          }
        public void setWebCommandEnabled(bool new_value)
          {
            flagHasWebCommandEnabled = true;
            storeWebCommandEnabled = new_value;
          }
        public void unsetWebCommandEnabled()
          {
            flagHasWebCommandEnabled = false;
          }

        public virtual void extraTypeNativeDataAppendPair(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            Debug.Assert(extraKeys.Count == extraValues.Count);
            extraKeys.Add(key);
            extraValues.Add(new_component);
            extraIndex.Add(key, new_component);
          }
        public virtual void extraTypeNativeDataSetField(string key, JSONValue new_component)
          {
            Debug.Assert(key != null);
            Debug.Assert(new_component != null);

            JSONValue old_field = extraTypeNativeDataLookup(key);
            if (old_field == null)
              {
                extraTypeNativeDataAppendPair(key, new_component);
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
            if (flagHasSportsResultScore)
              {
                handler.start_pair("SportsResultScore");
                Debug.Assert(storeSportsResultScore.Count >= 1);
                handler.start_array();
                for (int num1 = 0; num1 < storeSportsResultScore.Count; ++num1)
                  {
                    if (partial_allowed)
                        storeSportsResultScore[num1].write_partial_as_json(handler);
                    else
                        storeSportsResultScore[num1].write_as_json(handler);
                  }
                handler.finish_array();
              }
            if (flagHasSeriesStatus)
              {
                handler.start_pair("SeriesStatus");
                if (partial_allowed)
                    storeSeriesStatus.write_partial_as_json(handler);
                else
                    storeSeriesStatus.write_as_json(handler);
              }
            if (flagHasResultsType)
              {
                handler.start_pair("ResultsType");
                if (storeResultsType.in_known_list)
                  {
                    switch (storeResultsType.list_value)
                      {
                        case TypeResultsTypeKnownValues.ResultsType_Unknown:
                            handler.string_value("Unknown");
                            break;
                        case TypeResultsTypeKnownValues.ResultsType_SameTeam:
                            handler.string_value("SameTeam");
                            break;
                        case TypeResultsTypeKnownValues.ResultsType_Generic:
                            handler.string_value("Generic");
                            break;
                        case TypeResultsTypeKnownValues.ResultsType_Series:
                            handler.string_value("Series");
                            break;
                        case TypeResultsTypeKnownValues.ResultsType_PlayoffsComplete:
                            handler.string_value("PlayoffsComplete");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeResultsType.string_value);
                  }
              }
            if (flagHasResultError)
              {
                handler.start_pair("ResultError");
                if (storeResultError.in_known_list)
                  {
                    switch (storeResultError.list_value)
                      {
                        case TypeResultErrorKnownValues.ResultError_None:
                            handler.string_value("None");
                            break;
                        case TypeResultErrorKnownValues.ResultError_ScoreNotFound:
                            handler.string_value("ScoreNotFound");
                            break;
                        case TypeResultErrorKnownValues.ResultError_NotSupported:
                            handler.string_value("NotSupported");
                            break;
                        case TypeResultErrorKnownValues.ResultError_LocationUnavailable:
                            handler.string_value("LocationUnavailable");
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                      }
                  }
                else
                  {
                            handler.string_value(storeResultError.string_value);
                  }
              }
            Debug.Assert(partial_allowed || flagHasSportsInputData);
            if (flagHasSportsInputData)
              {
                handler.start_pair("SportsInputData");
                if (partial_allowed)
                    storeSportsInputData.write_partial_as_json(handler);
                else
                    storeSportsInputData.write_as_json(handler);
              }
            Debug.Assert(partial_allowed || flagHasNow);
            if (flagHasNow)
              {
                handler.start_pair("Now");
                if (partial_allowed)
                    storeNow.write_partial_as_json(handler);
                else
                    storeNow.write_as_json(handler);
              }
            if (flagHasLatitude)
              {
                handler.start_pair("Latitude");
                if (textStoreLatitude != "")
                    handler.number_value(textStoreLatitude);
                else if (((double)(long)storeLatitude) == storeLatitude)
                    handler.number_value((long)storeLatitude);
                else
                    handler.number_value(storeLatitude);
              }
            if (flagHasLongitude)
              {
                handler.start_pair("Longitude");
                if (textStoreLongitude != "")
                    handler.number_value(textStoreLongitude);
                else if (((double)(long)storeLongitude) == storeLongitude)
                    handler.number_value((long)storeLongitude);
                else
                    handler.number_value(storeLongitude);
              }
            if (flagHasDateLocationConstraintsDropped)
              {
                handler.start_pair("DateLocationConstraintsDropped");
                handler.boolean_value(storeDateLocationConstraintsDropped);
              }
            if (flagHasWebCommandEnabled)
              {
                handler.start_pair("WebCommandEnabled");
                handler.boolean_value(storeWebCommandEnabled);
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
            if (!(hasSportsInputData()))
              {
                return "When parsing the object for %what%, the \"SportsInputData\" field was missing.";
              }
            if (!(hasNow()))
              {
                return "When parsing the object for %what%, the \"Now\" field was missing.";
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
            private SportsResultScoreJSON.HoldingArrayGenerator fieldGeneratorSportsResultScore;
            private SportsSeriesStatusJSON.HoldingGenerator fieldGeneratorSeriesStatus;
        private abstract class FieldGeneratorResultsType : JSONStringGenerator
              {
                protected FieldGeneratorResultsType(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorResultsType()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeResultsTypeKnownValues known = stringToResultsType(result);
                    TypeResultsType new_value = new TypeResultsType();
                    if (known == TypeResultsTypeKnownValues.ResultsType__none)
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
                protected abstract void handle_result(TypeResultsType result);
              };
        private class FieldHoldingGeneratorResultsType : FieldGeneratorResultsType
      {
        protected override void handle_result(TypeResultsType result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorResultsType(String what)
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
        public TypeResultsType value;
      };
        private class FieldHoldingArrayGeneratorResultsType : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorResultsType
          {
            private FieldHoldingArrayGeneratorResultsType top;

            protected override void handle_result(TypeResultsType result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorResultsType init_top)
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
        protected virtual void handle_result(List<TypeResultsType> result)
          {
          }

        public FieldHoldingArrayGeneratorResultsType(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeResultsType>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorResultsType()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeResultsType>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeResultsType> value;
      };
            private FieldHoldingGeneratorResultsType fieldGeneratorResultsType;
        private abstract class FieldGeneratorResultError : JSONStringGenerator
              {
                protected FieldGeneratorResultError(string what)
                  {
                    set_what(what);
                  }
                protected FieldGeneratorResultError()
                  {
                  }
                protected override void handle_result(string result)
                  {
                    TypeResultErrorKnownValues known = stringToResultError(result);
                    TypeResultError new_value = new TypeResultError();
                    if (known == TypeResultErrorKnownValues.ResultError__none)
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
                protected abstract void handle_result(TypeResultError result);
              };
        private class FieldHoldingGeneratorResultError : FieldGeneratorResultError
      {
        protected override void handle_result(TypeResultError result)
          {
    //@@@        Debug.Assert(!have_value);
            have_value = true;
            value = result;
          }

        public FieldHoldingGeneratorResultError(String what)
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
        public TypeResultError value;
      };
        private class FieldHoldingArrayGeneratorResultError : JSONArrayGenerator
      {
        protected class ElementHandler : FieldGeneratorResultError
          {
            private FieldHoldingArrayGeneratorResultError top;

            protected override void handle_result(TypeResultError result)
              {
                top.value.Add(result);
              }
            protected override string get_what()
              {
                return "element " + top.value.Count + " of " + top.get_what();
              }

            public ElementHandler(FieldHoldingArrayGeneratorResultError init_top)
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
        protected virtual void handle_result(List<TypeResultError> result)
          {
          }

        public FieldHoldingArrayGeneratorResultError(string what)
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeResultError>();
            base.set_what(what);
          }
        public FieldHoldingArrayGeneratorResultError()
          {
            element_handler = new ElementHandler(this);
            have_value = false;
            value = new List<TypeResultError>();
          }

        public override void reset()
          {
            element_handler.reset();
            have_value = false;
            value.Clear();
            base.reset();
          }

        public bool have_value;
        public List<TypeResultError> value;
      };
            private FieldHoldingGeneratorResultError fieldGeneratorResultError;
            private SportsInputDataJSON.HoldingGenerator fieldGeneratorSportsInputData;
            private DateAndOrTimeJSON.HoldingGenerator fieldGeneratorNow;
            private JSONHoldingNumberTextGenerator fieldGeneratorLatitude;
            private JSONHoldingNumberTextGenerator fieldGeneratorLongitude;
            private JSONHoldingBooleanGenerator fieldGeneratorDateLocationConstraintsDropped;
            private JSONHoldingBooleanGenerator fieldGeneratorWebCommandEnabled;
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
                TypeNativeDataJSON result = new TypeNativeDataJSON();
                Debug.Assert(result != null);
                finish(result);
                int extra_count = unknownFieldGenerator.field_names.Count;
                Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
                for (int extra_num = 0; extra_num < extra_count; ++extra_num)
                  {
                    result.extraTypeNativeDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
                  }
                unknownFieldGenerator.field_names.Clear();
                unknownFieldGenerator.field_values.Clear();
                unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
                handle_result(result);
              }
            protected void finish(TypeNativeDataJSON result)
              {
                if (fieldGeneratorSportsResultScore.have_value)
                  {
                    result.initSportsResultScore();
                    int count = fieldGeneratorSportsResultScore.value.Count;
                    for (int num = 0; num < count; ++num)
                      {
                        result.appendSportsResultScore(fieldGeneratorSportsResultScore.value[num]);
                      }
                    fieldGeneratorSportsResultScore.value.Clear();
                    fieldGeneratorSportsResultScore.have_value = false;
                  }
                if (fieldGeneratorSeriesStatus.have_value)
                  {
                    result.setSeriesStatus(fieldGeneratorSeriesStatus.value);
                    fieldGeneratorSeriesStatus.have_value = false;
                  }
                if (fieldGeneratorResultsType.have_value)
                  {
                    result.setResultsType(fieldGeneratorResultsType.value);
                    fieldGeneratorResultsType.have_value = false;
                  }
                if (fieldGeneratorResultError.have_value)
                  {
                    result.setResultError(fieldGeneratorResultError.value);
                    fieldGeneratorResultError.have_value = false;
                  }
                if (fieldGeneratorSportsInputData.have_value)
                  {
                    result.setSportsInputData(fieldGeneratorSportsInputData.value);
                    fieldGeneratorSportsInputData.have_value = false;
                  }
                else if ((!(result.hasSportsInputData())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"SportsInputData\" field was missing.");
                  }
                if (fieldGeneratorNow.have_value)
                  {
                    result.setNow(fieldGeneratorNow.value);
                    fieldGeneratorNow.have_value = false;
                  }
                else if ((!(result.hasNow())) && !allow_incomplete)
                  {
                    error("When parsing the object for %what%, the \"Now\" field was missing.");
                  }
                if (fieldGeneratorLatitude.have_value)
                  {
                    result.setLatitudeText(fieldGeneratorLatitude.value);
                    fieldGeneratorLatitude.have_value = false;
                  }
                if (fieldGeneratorLongitude.have_value)
                  {
                    result.setLongitudeText(fieldGeneratorLongitude.value);
                    fieldGeneratorLongitude.have_value = false;
                  }
                if (fieldGeneratorDateLocationConstraintsDropped.have_value)
                  {
                    result.setDateLocationConstraintsDropped(fieldGeneratorDateLocationConstraintsDropped.value);
                    fieldGeneratorDateLocationConstraintsDropped.have_value = false;
                  }
                if (fieldGeneratorWebCommandEnabled.have_value)
                  {
                    result.setWebCommandEnabled(fieldGeneratorWebCommandEnabled.value);
                    fieldGeneratorWebCommandEnabled.have_value = false;
                  }
              }
            protected abstract void handle_result(TypeNativeDataJSON new_result);
            protected virtual JSONHandler start_known_field(string field_name)
              {
                switch (field_name[0])
                  {
                    case 'D':
                        if ((String.Compare(field_name, 1, "ateLocationConstraintsDropped", 0, 29, false) == 0) && (field_name.Length == 30))
                            return fieldGeneratorDateLocationConstraintsDropped;
                        break;
                    case 'L':
                        switch (field_name[1])
                          {
                            case 'a':
                                if ((String.Compare(field_name, 2, "titude", 0, 6, false) == 0) && (field_name.Length == 8))
                                    return fieldGeneratorLatitude;
                                break;
                            case 'o':
                                if ((String.Compare(field_name, 2, "ngitude", 0, 7, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorLongitude;
                                break;
                            default:
                                break;
                          }
                        break;
                    case 'N':
                        if ((String.Compare(field_name, 1, "ow", 0, 2, false) == 0) && (field_name.Length == 3))
                            return fieldGeneratorNow;
                        break;
                    case 'R':
                        if (String.Compare(field_name, 1, "esult", 0, 5, false) == 0)
                          {
                            switch (field_name[6])
                              {
                                case 'E':
                                    if ((String.Compare(field_name, 7, "rror", 0, 4, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorResultError;
                                    break;
                                case 's':
                                    if ((String.Compare(field_name, 7, "Type", 0, 4, false) == 0) && (field_name.Length == 11))
                                        return fieldGeneratorResultsType;
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'S':
                        switch (field_name[1])
                          {
                            case 'e':
                                if ((String.Compare(field_name, 2, "riesStatus", 0, 10, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorSeriesStatus;
                                break;
                            case 'p':
                                if (String.Compare(field_name, 2, "orts", 0, 4, false) == 0)
                                  {
                                    switch (field_name[6])
                                      {
                                        case 'I':
                                            if ((String.Compare(field_name, 7, "nputData", 0, 8, false) == 0) && (field_name.Length == 15))
                                                return fieldGeneratorSportsInputData;
                                            break;
                                        case 'R':
                                            if ((String.Compare(field_name, 7, "esultScore", 0, 10, false) == 0) && (field_name.Length == 17))
                                                return fieldGeneratorSportsResultScore;
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
                    case 'W':
                        if ((String.Compare(field_name, 1, "ebCommandEnabled", 0, 16, false) == 0) && (field_name.Length == 17))
                            return fieldGeneratorWebCommandEnabled;
                        break;
                    default:
                        break;
                  }
                return null;
              }
            public Generator(bool ignore_extras)
              {
                fieldGeneratorSportsResultScore = new SportsResultScoreJSON.HoldingArrayGenerator("field \"SportsResultScore\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorSeriesStatus = new SportsSeriesStatusJSON.HoldingGenerator("field \"SeriesStatus\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorResultsType = new FieldHoldingGeneratorResultsType("field \"ResultsType\" of the TypeNativeData class");
                fieldGeneratorResultError = new FieldHoldingGeneratorResultError("field \"ResultError\" of the TypeNativeData class");
                fieldGeneratorSportsInputData = new SportsInputDataJSON.HoldingGenerator("field \"SportsInputData\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorNow = new DateAndOrTimeJSON.HoldingGenerator("field \"Now\" of the TypeNativeData class", ignore_extras);
                fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the TypeNativeData class");
                fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the TypeNativeData class");
                fieldGeneratorDateLocationConstraintsDropped = new JSONHoldingBooleanGenerator("field \"DateLocationConstraintsDropped\" of the TypeNativeData class");
                fieldGeneratorWebCommandEnabled = new JSONHoldingBooleanGenerator("field \"WebCommandEnabled\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }
            public Generator()
              {
                fieldGeneratorSportsResultScore = new SportsResultScoreJSON.HoldingArrayGenerator("field \"SportsResultScore\" of the TypeNativeData class", false);
                fieldGeneratorSeriesStatus = new SportsSeriesStatusJSON.HoldingGenerator("field \"SeriesStatus\" of the TypeNativeData class", false);
                fieldGeneratorResultsType = new FieldHoldingGeneratorResultsType("field \"ResultsType\" of the TypeNativeData class");
                fieldGeneratorResultError = new FieldHoldingGeneratorResultError("field \"ResultError\" of the TypeNativeData class");
                fieldGeneratorSportsInputData = new SportsInputDataJSON.HoldingGenerator("field \"SportsInputData\" of the TypeNativeData class", false);
                fieldGeneratorNow = new DateAndOrTimeJSON.HoldingGenerator("field \"Now\" of the TypeNativeData class", false);
                fieldGeneratorLatitude = new JSONHoldingNumberTextGenerator("field \"Latitude\" of the TypeNativeData class");
                fieldGeneratorLongitude = new JSONHoldingNumberTextGenerator("field \"Longitude\" of the TypeNativeData class");
                fieldGeneratorDateLocationConstraintsDropped = new JSONHoldingBooleanGenerator("field \"DateLocationConstraintsDropped\" of the TypeNativeData class");
                fieldGeneratorWebCommandEnabled = new JSONHoldingBooleanGenerator("field \"WebCommandEnabled\" of the TypeNativeData class");
                unknownFieldGenerator = new UnknownFieldGenerator(false);
                set_what("the TypeNativeData class");
                allow_incomplete = false;
                allow_unpolished = false;
              }

            public override void reset()
              {
                fieldGeneratorSportsResultScore.reset();
                fieldGeneratorSeriesStatus.reset();
                fieldGeneratorResultsType.reset();
                fieldGeneratorResultError.reset();
                fieldGeneratorSportsInputData.reset();
                fieldGeneratorNow.reset();
                fieldGeneratorLatitude.reset();
                fieldGeneratorLongitude.reset();
                fieldGeneratorDateLocationConstraintsDropped.reset();
                fieldGeneratorWebCommandEnabled.reset();
                base.reset();
                unknownFieldGenerator.reset();
              }
            public void set_allow_incomplete(bool new_allow_incomplete)
              {
                allow_incomplete = new_allow_incomplete;
                fieldGeneratorSportsResultScore.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorSeriesStatus.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorSportsInputData.set_allow_incomplete(new_allow_incomplete);
                fieldGeneratorNow.set_allow_incomplete(new_allow_incomplete);
              }
            public void set_allow_unpolished(bool new_allow_unpolished)
              {
                allow_unpolished = new_allow_unpolished;
                fieldGeneratorSportsResultScore.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorSeriesStatus.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorSportsInputData.set_allow_unpolished(new_allow_unpolished);
                fieldGeneratorNow.set_allow_unpolished(new_allow_unpolished);
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


    private JSONValue  extraNativeDataToJSON()
      {
        JSONValueHandler handler_NativeData = new JSONValueHandler();
        storeNativeData.write_as_json(handler_NativeData);
        return handler_NativeData.result;
      }


    private void  fromJSONNativeData(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        TypeNativeDataJSON convert_classy = TypeNativeDataJSON.from_json(json_value, ignore_extras, true);
        setNativeData(convert_classy);
      }


    public SportsShowResultsCommandJSON()
      {
        flagHasNativeData = false;
      }

    public override string  getSportsCommandKind()
      {
        return "SportsShowResultsCommand";
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


    public override int extraSportsCommandComponentCount()
      {
        int result = 0;
        if (flagHasNativeData)
            ++result;
        return result;
      }
    public override string extraSportsCommandComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return "NativeData";
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraSportsCommandComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasNativeData)
          {
            if (remainder == 0)
                return extraNativeDataToJSON();
            --remainder;
          }
        Debug.Assert(false);
        return null;
      }
    public override JSONValue extraSportsCommandLookup(string field_name)
      {
        if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
            return (flagHasNativeData ? extraNativeDataToJSON() : null);
        return null;
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

    public override void extraSportsCommandAppendPair(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
      }
    public override void extraSportsCommandSetField(string key, JSONValue new_component)
      {
        if ((String.Compare(key, 0, "NativeData", 0, 10, false) == 0) && (key.Length == 10))
            {
            fromJSONNativeData(new_component, false);
            return;
            }
      }

    public override void write_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler);
        handler.finish_object();
      }

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        if (flagHasNativeData)
          {
            handler.start_pair("NativeData");
            if (partial_allowed)
                storeNativeData.write_partial_as_json(handler);
            else
                storeNativeData.write_as_json(handler);
          }
      }
    public override void write_partial_as_json(JSONHandler handler)
      {
        handler.start_object();
        write_fields_as_json(handler, true);
        handler.finish_object();
      }
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new SportsShowResultsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsShowResultsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsShowResultsCommand", ignore_extras);
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
    public static new SportsShowResultsCommandJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsShowResultsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        SportsShowResultsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsShowResultsCommand", ignore_extras);
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
    public static new SportsShowResultsCommandJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new SportsShowResultsCommandJSON from_text(string text, bool ignore_extras)
      {
        SportsShowResultsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsShowResultsCommand", ignore_extras);
            JSONParse.parse_json_value(text, "Text for SportsShowResultsCommandJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new SportsShowResultsCommandJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        SportsShowResultsCommandJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type SportsShowResultsCommand", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : SportsCommandJSON.Generator
      {
        private TypeNativeDataJSON.HoldingGenerator fieldGeneratorNativeData;

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
            if (!(getSportsCommandJSONKey().Equals("SportsShowResultsCommand")))
                throw new Exception("The key field has a value other than `SportsShowResultsCommand'.");
            SportsShowResultsCommandJSON result = new SportsShowResultsCommandJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(SportsCommandJSON new_result)
          {
            handle_result((SportsShowResultsCommandJSON )new_result);
          }
        protected void finish(SportsShowResultsCommandJSON result)
          {
            if (fieldGeneratorNativeData.have_value)
              {
                result.setNativeData(fieldGeneratorNativeData.value);
                fieldGeneratorNativeData.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(SportsShowResultsCommandJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            if ((String.Compare(field_name, 0, "NativeData", 0, 10, false) == 0) && (field_name.Length == 10))
                return fieldGeneratorNativeData;
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the SportsShowResultsCommand class", ignore_extras);
            set_what("the SportsShowResultsCommand class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorNativeData = new TypeNativeDataJSON.HoldingGenerator("field \"NativeData\" of the SportsShowResultsCommand class", false);
            set_what("the SportsShowResultsCommand class");
          }

        public override void reset()
          {
            fieldGeneratorNativeData.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(SportsShowResultsCommandJSON  result)
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
        public SportsShowResultsCommandJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(SportsShowResultsCommandJSON  result)
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
    protected virtual void handle_result(List<SportsShowResultsCommandJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<SportsShowResultsCommandJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<SportsShowResultsCommandJSON>();
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
    public List<SportsShowResultsCommandJSON> value;
  };
  };
