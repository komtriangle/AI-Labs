/* file "FlightStatusModeJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class FlightStatusModeJSON : JSONBase
  {
    public enum TypeLastUserResponse
      {
        LastUserResponse_InitiatedMode,
        LastUserResponse_Understood,
        LastUserResponse_NotUnderstood,
        LastUserResponse_DoesNotKnow,
        LastUserResponse_WantsToKnow,
        LastUserResponse_Cancel
      };

    public static TypeLastUserResponse  stringToLastUserResponse(string chars)
      {
        switch (chars[0])
          {
            case 'C':
                if ((String.Compare(chars, 1, "ancel", 0, 5, false) == 0) && (chars.Length == 6))
                    return TypeLastUserResponse.LastUserResponse_Cancel;
                break;
            case 'D':
                if ((String.Compare(chars, 1, "oesNotKnow", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeLastUserResponse.LastUserResponse_DoesNotKnow;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "nitiatedMode", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeLastUserResponse.LastUserResponse_InitiatedMode;
                break;
            case 'N':
                if ((String.Compare(chars, 1, "otUnderstood", 0, 12, false) == 0) && (chars.Length == 13))
                    return TypeLastUserResponse.LastUserResponse_NotUnderstood;
                break;
            case 'U':
                if ((String.Compare(chars, 1, "nderstood", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeLastUserResponse.LastUserResponse_Understood;
                break;
            case 'W':
                if ((String.Compare(chars, 1, "antsToKnow", 0, 10, false) == 0) && (chars.Length == 11))
                    return TypeLastUserResponse.LastUserResponse_WantsToKnow;
                break;
            default:
                break;
          }
        throw new Exception("The value for field `LastUserResponse' is not one of the legal values.");
      }

    public static string  stringFromLastUserResponse(TypeLastUserResponse the_enum)
      {
        switch (the_enum)
          {
            case TypeLastUserResponse.LastUserResponse_InitiatedMode:
                return "InitiatedMode";
            case TypeLastUserResponse.LastUserResponse_Understood:
                return "Understood";
            case TypeLastUserResponse.LastUserResponse_NotUnderstood:
                return "NotUnderstood";
            case TypeLastUserResponse.LastUserResponse_DoesNotKnow:
                return "DoesNotKnow";
            case TypeLastUserResponse.LastUserResponse_WantsToKnow:
                return "WantsToKnow";
            case TypeLastUserResponse.LastUserResponse_Cancel:
                return "Cancel";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasFlightSpecIndex;
    private BigInteger storeFlightSpecIndex;
    private bool flagHasAskingUserFor;
    private FlightStatusLookupParameterJSON  storeAskingUserFor;
    private bool flagHasAlreadyAskedUser;
    private List< FlightStatusLookupParameterJSON  > storeAlreadyAskedUser;
    private bool flagHasNotUnderstoodCount;
    private BigInteger storeNotUnderstoodCount;
    private bool flagHasTextForUser;
    private ResponseTypesJSON  storeTextForUser;
    private bool flagHasLastUserResponse;
    private TypeLastUserResponse storeLastUserResponse;
    private bool flagHasWrittenHints;
    private List< string > storeWrittenHints;
    private bool flagHasSpokenHints;
    private List< string > storeSpokenHints;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONFlightSpecIndex(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field FlightSpecIndex of FlightStatusModeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field FlightSpecIndex of FlightStatusModeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setFlightSpecIndex(extracted_integer);
      }


    private void  fromJSONAskingUserFor(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        FlightStatusLookupParameterJSON convert_classy = FlightStatusLookupParameterJSON.from_json(json_value, ignore_extras, true);
        setAskingUserFor(convert_classy);
      }


    private void  fromJSONAlreadyAskedUser(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AlreadyAskedUser of FlightStatusModeJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< FlightStatusLookupParameterJSON  > vector_AlreadyAskedUser1 = new List< FlightStatusLookupParameterJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            FlightStatusLookupParameterJSON convert_classy = FlightStatusLookupParameterJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_AlreadyAskedUser1.Add(convert_classy);
          }
        initAlreadyAskedUser();
        for (int num1 = 0; num1 < vector_AlreadyAskedUser1.Count; ++num1)
            appendAlreadyAskedUser(vector_AlreadyAskedUser1[num1]);
        for (int num1 = 0; num1 < vector_AlreadyAskedUser1.Count; ++num1)
          {
          }
      }


    private void  fromJSONNotUnderstoodCount(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field NotUnderstoodCount of FlightStatusModeJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field NotUnderstoodCount of FlightStatusModeJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setNotUnderstoodCount(extracted_integer);
      }


    private void  fromJSONTextForUser(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        ResponseTypesJSON convert_classy = ResponseTypesJSON.from_json(json_value, ignore_extras, true);
        setTextForUser(convert_classy);
      }


    private void  fromJSONLastUserResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field LastUserResponse of FlightStatusModeJSON is not a string.");
        TypeLastUserResponse the_enum;
        switch (json_string.getData()[0])
          {
            case 'C':
                if ((String.Compare(json_string.getData(), 1, "ancel", 0, 5, false) == 0) && (json_string.getData().Length == 6))
                      {
                        the_enum = TypeLastUserResponse.LastUserResponse_Cancel;
                        goto enum_is_done;
                      }
                break;
            case 'D':
                if ((String.Compare(json_string.getData(), 1, "oesNotKnow", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeLastUserResponse.LastUserResponse_DoesNotKnow;
                        goto enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "nitiatedMode", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_enum = TypeLastUserResponse.LastUserResponse_InitiatedMode;
                        goto enum_is_done;
                      }
                break;
            case 'N':
                if ((String.Compare(json_string.getData(), 1, "otUnderstood", 0, 12, false) == 0) && (json_string.getData().Length == 13))
                      {
                        the_enum = TypeLastUserResponse.LastUserResponse_NotUnderstood;
                        goto enum_is_done;
                      }
                break;
            case 'U':
                if ((String.Compare(json_string.getData(), 1, "nderstood", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_enum = TypeLastUserResponse.LastUserResponse_Understood;
                        goto enum_is_done;
                      }
                break;
            case 'W':
                if ((String.Compare(json_string.getData(), 1, "antsToKnow", 0, 10, false) == 0) && (json_string.getData().Length == 11))
                      {
                        the_enum = TypeLastUserResponse.LastUserResponse_WantsToKnow;
                        goto enum_is_done;
                      }
                break;
            default:
                break;
          }
        throw new Exception("The value for field LastUserResponse of FlightStatusModeJSON is not one of the legal strings.");
      enum_is_done:;
        setLastUserResponse(the_enum);
      }


    private void  fromJSONWrittenHints(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field WrittenHints of FlightStatusModeJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_WrittenHints1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field WrittenHints of FlightStatusModeJSON is not a string.");
            vector_WrittenHints1.Add(json_string.getData());
          }
        initWrittenHints();
        for (int num2 = 0; num2 < vector_WrittenHints1.Count; ++num2)
            appendWrittenHints(vector_WrittenHints1[num2]);
        for (int num1 = 0; num1 < vector_WrittenHints1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSpokenHints(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SpokenHints of FlightStatusModeJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_SpokenHints1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SpokenHints of FlightStatusModeJSON is not a string.");
            vector_SpokenHints1.Add(json_string.getData());
          }
        initSpokenHints();
        for (int num3 = 0; num3 < vector_SpokenHints1.Count; ++num3)
            appendSpokenHints(vector_SpokenHints1[num3]);
        for (int num1 = 0; num1 < vector_SpokenHints1.Count; ++num1)
          {
          }
      }


    public FlightStatusModeJSON()
      {
        flagHasFlightSpecIndex = false;
        flagHasAskingUserFor = false;
        flagHasAlreadyAskedUser = false;
        flagHasNotUnderstoodCount = false;
        flagHasTextForUser = false;
        flagHasLastUserResponse = false;
        flagHasWrittenHints = false;
        flagHasSpokenHints = false;
        storeAlreadyAskedUser = new List< FlightStatusLookupParameterJSON  >();
        storeWrittenHints = new List< string >();
        storeSpokenHints = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasFlightSpecIndex()
      {
        return flagHasFlightSpecIndex;
      }

    public BigInteger  getFlightSpecIndex()
      {
        Debug.Assert(flagHasFlightSpecIndex);
        return storeFlightSpecIndex;
      }

    public bool  hasAskingUserFor()
      {
        return flagHasAskingUserFor;
      }

    public FlightStatusLookupParameterJSON   getAskingUserFor()
      {
        Debug.Assert(flagHasAskingUserFor);
        return storeAskingUserFor;
      }

    public FlightStatusLookupParameterJSON.TypeValue  getAskingUserForValue()
      {
        return getAskingUserFor().getValue();
      }

    public string  getAskingUserForAsString()
      {
        return getAskingUserFor().getValueAsString();
      }

    public bool  hasAlreadyAskedUser()
      {
        return flagHasAlreadyAskedUser;
      }

    public int  countOfAlreadyAskedUser()
      {
        Debug.Assert(flagHasAlreadyAskedUser);
        return storeAlreadyAskedUser.Count;
      }

    public FlightStatusLookupParameterJSON   elementOfAlreadyAskedUser(int element_num)
      {
        Debug.Assert(flagHasAlreadyAskedUser);
        return storeAlreadyAskedUser[element_num];
      }

    public List< FlightStatusLookupParameterJSON  >  getAlreadyAskedUser()
      {
        Debug.Assert(flagHasAlreadyAskedUser);
        return storeAlreadyAskedUser;
      }

    public bool  hasNotUnderstoodCount()
      {
        return flagHasNotUnderstoodCount;
      }

    public BigInteger  getNotUnderstoodCount()
      {
        Debug.Assert(flagHasNotUnderstoodCount);
        return storeNotUnderstoodCount;
      }

    public bool  hasTextForUser()
      {
        return flagHasTextForUser;
      }

    public ResponseTypesJSON   getTextForUser()
      {
        Debug.Assert(flagHasTextForUser);
        return storeTextForUser;
      }

    public bool  hasLastUserResponse()
      {
        return flagHasLastUserResponse;
      }

    public TypeLastUserResponse  getLastUserResponse()
      {
        Debug.Assert(flagHasLastUserResponse);
        return storeLastUserResponse;
      }

    public string  getLastUserResponseAsString()
      {
        return stringFromLastUserResponse(getLastUserResponse());
      }

    public bool  hasWrittenHints()
      {
        return flagHasWrittenHints;
      }

    public int  countOfWrittenHints()
      {
        Debug.Assert(flagHasWrittenHints);
        return storeWrittenHints.Count;
      }

    public string  elementOfWrittenHints(int element_num)
      {
        Debug.Assert(flagHasWrittenHints);
        return storeWrittenHints[element_num];
      }

    public List< string >  getWrittenHints()
      {
        Debug.Assert(flagHasWrittenHints);
        return storeWrittenHints;
      }

    public bool  hasSpokenHints()
      {
        return flagHasSpokenHints;
      }

    public int  countOfSpokenHints()
      {
        Debug.Assert(flagHasSpokenHints);
        return storeSpokenHints.Count;
      }

    public string  elementOfSpokenHints(int element_num)
      {
        Debug.Assert(flagHasSpokenHints);
        return storeSpokenHints[element_num];
      }

    public List< string >  getSpokenHints()
      {
        Debug.Assert(flagHasSpokenHints);
        return storeSpokenHints;
      }


    public virtual int extraFlightStatusModeComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraFlightStatusModeComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraFlightStatusModeComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraFlightStatusModeLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setFlightSpecIndex(BigInteger new_value)
      {
        flagHasFlightSpecIndex = true;
        if (new_value < 0)
            throw new Exception("The value for field FlightSpecIndex of FlightStatusModeJSON is less than the lower bound (0) for that field.");
        storeFlightSpecIndex = new_value;
      }
    public void unsetFlightSpecIndex()
      {
        flagHasFlightSpecIndex = false;
      }
    public void setAskingUserFor(FlightStatusLookupParameterJSON  new_value)
      {
        if (flagHasAskingUserFor)
          {
          }
        flagHasAskingUserFor = true;
        storeAskingUserFor = new_value;
      }
    public void setAskingUserFor(FlightStatusLookupParameterJSON.TypeValue new_value)
      {
        setAskingUserFor(new FlightStatusLookupParameterJSON(new_value));
      }
    public void setAskingUserFor(string chars)
      {
        setAskingUserFor(new FlightStatusLookupParameterJSON(chars));
      }
    public void unsetAskingUserFor()
      {
        if (flagHasAskingUserFor)
          {
          }
        flagHasAskingUserFor = false;
      }
    public void initAlreadyAskedUser()
      {
        if (flagHasAlreadyAskedUser)
          {
            for (int num1 = 0; num1 < storeAlreadyAskedUser.Count; ++num1)
              {
              }
          }
        flagHasAlreadyAskedUser = true;
        storeAlreadyAskedUser.Clear();
      }
    public void appendAlreadyAskedUser(FlightStatusLookupParameterJSON  to_append)
      {
        if (!flagHasAlreadyAskedUser)
          {
            flagHasAlreadyAskedUser = true;
            storeAlreadyAskedUser.Clear();
          }
        Debug.Assert(flagHasAlreadyAskedUser);
        storeAlreadyAskedUser.Add(to_append);
      }
    public void appendAlreadyAskedUser(FlightStatusLookupParameterJSON.TypeValue new_value)
      {
        appendAlreadyAskedUser(new FlightStatusLookupParameterJSON(new_value));
      }
    public void appendAlreadyAskedUser(string chars)
      {
        appendAlreadyAskedUser(new FlightStatusLookupParameterJSON(chars));
      }
    public void unsetAlreadyAskedUser()
      {
        if (flagHasAlreadyAskedUser)
          {
            for (int num2 = 0; num2 < storeAlreadyAskedUser.Count; ++num2)
              {
              }
          }
        flagHasAlreadyAskedUser = false;
        storeAlreadyAskedUser.Clear();
      }
    public void setNotUnderstoodCount(BigInteger new_value)
      {
        flagHasNotUnderstoodCount = true;
        if (new_value < 0)
            throw new Exception("The value for field NotUnderstoodCount of FlightStatusModeJSON is less than the lower bound (0) for that field.");
        storeNotUnderstoodCount = new_value;
      }
    public void unsetNotUnderstoodCount()
      {
        flagHasNotUnderstoodCount = false;
      }
    public void setTextForUser(ResponseTypesJSON  new_value)
      {
        if (flagHasTextForUser)
          {
          }
        flagHasTextForUser = true;
        storeTextForUser = new_value;
      }
    public void unsetTextForUser()
      {
        if (flagHasTextForUser)
          {
          }
        flagHasTextForUser = false;
      }
    public void setLastUserResponse(TypeLastUserResponse new_value)
      {
        flagHasLastUserResponse = true;
        storeLastUserResponse = new_value;
      }
    public void setLastUserResponse(string chars)
      {
        setLastUserResponse(stringToLastUserResponse(chars));
      }
    public void unsetLastUserResponse()
      {
        flagHasLastUserResponse = false;
      }
    public void initWrittenHints()
      {
        flagHasWrittenHints = true;
        storeWrittenHints.Clear();
      }
    public void appendWrittenHints(string to_append)
      {
        if (!flagHasWrittenHints)
          {
            flagHasWrittenHints = true;
            storeWrittenHints.Clear();
          }
        Debug.Assert(flagHasWrittenHints);
        storeWrittenHints.Add(to_append);
      }
    public void unsetWrittenHints()
      {
        flagHasWrittenHints = false;
        storeWrittenHints.Clear();
      }
    public void initSpokenHints()
      {
        flagHasSpokenHints = true;
        storeSpokenHints.Clear();
      }
    public void appendSpokenHints(string to_append)
      {
        if (!flagHasSpokenHints)
          {
            flagHasSpokenHints = true;
            storeSpokenHints.Clear();
          }
        Debug.Assert(flagHasSpokenHints);
        storeSpokenHints.Add(to_append);
      }
    public void unsetSpokenHints()
      {
        flagHasSpokenHints = false;
        storeSpokenHints.Clear();
      }

    public virtual void extraFlightStatusModeAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraFlightStatusModeSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraFlightStatusModeLookup(key);
        if (old_field == null)
          {
            extraFlightStatusModeAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasFlightSpecIndex);
        if (flagHasFlightSpecIndex)
          {
            handler.start_pair("FlightSpecIndex");
            handler.number_value(storeFlightSpecIndex);
          }
        Debug.Assert(partial_allowed || flagHasAskingUserFor);
        if (flagHasAskingUserFor)
          {
            handler.start_pair("AskingUserFor");
            if (partial_allowed)
                storeAskingUserFor.write_partial_as_json(handler);
            else
                storeAskingUserFor.write_as_json(handler);
          }
        if (flagHasAlreadyAskedUser)
          {
            handler.start_pair("AlreadyAskedUser");
            handler.start_array();
            for (int num1 = 0; num1 < storeAlreadyAskedUser.Count; ++num1)
              {
                if (partial_allowed)
                    storeAlreadyAskedUser[num1].write_partial_as_json(handler);
                else
                    storeAlreadyAskedUser[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasNotUnderstoodCount)
          {
            handler.start_pair("NotUnderstoodCount");
            handler.number_value(storeNotUnderstoodCount);
          }
        if (flagHasTextForUser)
          {
            handler.start_pair("TextForUser");
            if (partial_allowed)
                storeTextForUser.write_partial_as_json(handler);
            else
                storeTextForUser.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasLastUserResponse);
        if (flagHasLastUserResponse)
          {
            handler.start_pair("LastUserResponse");
            switch (storeLastUserResponse)
              {
                case TypeLastUserResponse.LastUserResponse_InitiatedMode:
                    handler.string_value("InitiatedMode");
                    break;
                case TypeLastUserResponse.LastUserResponse_Understood:
                    handler.string_value("Understood");
                    break;
                case TypeLastUserResponse.LastUserResponse_NotUnderstood:
                    handler.string_value("NotUnderstood");
                    break;
                case TypeLastUserResponse.LastUserResponse_DoesNotKnow:
                    handler.string_value("DoesNotKnow");
                    break;
                case TypeLastUserResponse.LastUserResponse_WantsToKnow:
                    handler.string_value("WantsToKnow");
                    break;
                case TypeLastUserResponse.LastUserResponse_Cancel:
                    handler.string_value("Cancel");
                    break;
                default:
                    Debug.Assert(false);
                    break;
              }
          }
        if (flagHasWrittenHints)
          {
            handler.start_pair("WrittenHints");
            handler.start_array();
            for (int num2 = 0; num2 < storeWrittenHints.Count; ++num2)
              {
                handler.string_value(storeWrittenHints[num2]);
              }
            handler.finish_array();
          }
        if (flagHasSpokenHints)
          {
            handler.start_pair("SpokenHints");
            handler.start_array();
            for (int num3 = 0; num3 < storeSpokenHints.Count; ++num3)
              {
                handler.string_value(storeSpokenHints[num3]);
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
    public virtual string missing_field_error(bool allow_unpolished)
      {
        if (!(hasFlightSpecIndex()))
          {
            return "When parsing the object for %what%, the \"FlightSpecIndex\" field was missing.";
          }
        if (!(hasAskingUserFor()))
          {
            return "When parsing the object for %what%, the \"AskingUserFor\" field was missing.";
          }
        if (!(hasLastUserResponse()))
          {
            return "When parsing the object for %what%, the \"LastUserResponse\" field was missing.";
          }
        return null;
      }

    public static FlightStatusModeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusModeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusMode", ignore_extras);
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
    public static FlightStatusModeJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatusModeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        FlightStatusModeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusMode", ignore_extras);
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
    public static FlightStatusModeJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static FlightStatusModeJSON from_text(string text, bool ignore_extras)
      {
        FlightStatusModeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusMode", ignore_extras);
            JSONParse.parse_json_value(text, "Text for FlightStatusModeJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static FlightStatusModeJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        FlightStatusModeJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type FlightStatusMode", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorFlightSpecIndex : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorFlightSpecIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorFlightSpecIndex : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorFlightSpecIndex(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorFlightSpecIndex fieldGeneratorFlightSpecIndex;
        private FlightStatusLookupParameterJSON.HoldingGenerator fieldGeneratorAskingUserFor;
        private FlightStatusLookupParameterJSON.HoldingArrayGenerator fieldGeneratorAlreadyAskedUser;
    private class FieldHoldingGeneratorNotUnderstoodCount : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorNotUnderstoodCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorNotUnderstoodCount : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorNotUnderstoodCount(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorNotUnderstoodCount fieldGeneratorNotUnderstoodCount;
        private ResponseTypesJSON.HoldingGenerator fieldGeneratorTextForUser;
    private abstract class FieldGeneratorLastUserResponse : JSONStringGenerator
          {
            protected FieldGeneratorLastUserResponse(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorLastUserResponse()
              {
              }
            protected override void handle_result(string result)
              {
                handle_result(stringToLastUserResponse(result));
              }
            protected abstract void handle_result(TypeLastUserResponse result);
          };
    private class FieldHoldingGeneratorLastUserResponse : FieldGeneratorLastUserResponse
  {
    protected override void handle_result(TypeLastUserResponse result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorLastUserResponse(String what)
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
    public TypeLastUserResponse value;
  };
    private class FieldHoldingArrayGeneratorLastUserResponse : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorLastUserResponse
      {
        private FieldHoldingArrayGeneratorLastUserResponse top;

        protected override void handle_result(TypeLastUserResponse result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorLastUserResponse init_top)
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
    protected virtual void handle_result(List<TypeLastUserResponse> result)
      {
      }

    public FieldHoldingArrayGeneratorLastUserResponse(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLastUserResponse>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorLastUserResponse()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeLastUserResponse>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeLastUserResponse> value;
  };
        private FieldHoldingGeneratorLastUserResponse fieldGeneratorLastUserResponse;
        private JSONHoldingStringArrayGenerator fieldGeneratorWrittenHints;
        private JSONHoldingStringArrayGenerator fieldGeneratorSpokenHints;
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
            FlightStatusModeJSON result = new FlightStatusModeJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraFlightStatusModeAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(FlightStatusModeJSON result)
          {
            if (fieldGeneratorFlightSpecIndex.have_value)
              {
                result.setFlightSpecIndex(fieldGeneratorFlightSpecIndex.value);
                fieldGeneratorFlightSpecIndex.have_value = false;
              }
            else if ((!(result.hasFlightSpecIndex())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"FlightSpecIndex\" field was missing.");
              }
            if (fieldGeneratorAskingUserFor.have_value)
              {
                result.setAskingUserFor(fieldGeneratorAskingUserFor.value);
                fieldGeneratorAskingUserFor.have_value = false;
              }
            else if ((!(result.hasAskingUserFor())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AskingUserFor\" field was missing.");
              }
            if (fieldGeneratorAlreadyAskedUser.have_value)
              {
                result.initAlreadyAskedUser();
                int count = fieldGeneratorAlreadyAskedUser.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlreadyAskedUser(fieldGeneratorAlreadyAskedUser.value[num]);
                  }
                fieldGeneratorAlreadyAskedUser.value.Clear();
                fieldGeneratorAlreadyAskedUser.have_value = false;
              }
            if (fieldGeneratorNotUnderstoodCount.have_value)
              {
                result.setNotUnderstoodCount(fieldGeneratorNotUnderstoodCount.value);
                fieldGeneratorNotUnderstoodCount.have_value = false;
              }
            if (fieldGeneratorTextForUser.have_value)
              {
                result.setTextForUser(fieldGeneratorTextForUser.value);
                fieldGeneratorTextForUser.have_value = false;
              }
            if (fieldGeneratorLastUserResponse.have_value)
              {
                result.setLastUserResponse(fieldGeneratorLastUserResponse.value);
                fieldGeneratorLastUserResponse.have_value = false;
              }
            else if ((!(result.hasLastUserResponse())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"LastUserResponse\" field was missing.");
              }
            if (fieldGeneratorWrittenHints.have_value)
              {
                result.initWrittenHints();
                int count = fieldGeneratorWrittenHints.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendWrittenHints(fieldGeneratorWrittenHints.value[num]);
                  }
                fieldGeneratorWrittenHints.value.Clear();
                fieldGeneratorWrittenHints.have_value = false;
              }
            if (fieldGeneratorSpokenHints.have_value)
              {
                result.initSpokenHints();
                int count = fieldGeneratorSpokenHints.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSpokenHints(fieldGeneratorSpokenHints.value[num]);
                  }
                fieldGeneratorSpokenHints.value.Clear();
                fieldGeneratorSpokenHints.have_value = false;
              }
          }
        protected abstract void handle_result(FlightStatusModeJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "readyAskedUser", 0, 14, false) == 0) && (field_name.Length == 16))
                                return fieldGeneratorAlreadyAskedUser;
                            break;
                        case 's':
                            if ((String.Compare(field_name, 2, "kingUserFor", 0, 11, false) == 0) && (field_name.Length == 13))
                                return fieldGeneratorAskingUserFor;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "lightSpecIndex", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorFlightSpecIndex;
                    break;
                case 'L':
                    if ((String.Compare(field_name, 1, "astUserResponse", 0, 15, false) == 0) && (field_name.Length == 16))
                        return fieldGeneratorLastUserResponse;
                    break;
                case 'N':
                    if ((String.Compare(field_name, 1, "otUnderstoodCount", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorNotUnderstoodCount;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "pokenHints", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorSpokenHints;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "extForUser", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorTextForUser;
                    break;
                case 'W':
                    if ((String.Compare(field_name, 1, "rittenHints", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorWrittenHints;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorFlightSpecIndex = new FieldHoldingGeneratorFlightSpecIndex("field \"FlightSpecIndex\" of the FlightStatusMode class");
            fieldGeneratorAskingUserFor = new FlightStatusLookupParameterJSON.HoldingGenerator("field \"AskingUserFor\" of the FlightStatusMode class", ignore_extras);
            fieldGeneratorAlreadyAskedUser = new FlightStatusLookupParameterJSON.HoldingArrayGenerator("field \"AlreadyAskedUser\" of the FlightStatusMode class", ignore_extras);
            fieldGeneratorNotUnderstoodCount = new FieldHoldingGeneratorNotUnderstoodCount("field \"NotUnderstoodCount\" of the FlightStatusMode class");
            fieldGeneratorTextForUser = new ResponseTypesJSON.HoldingGenerator("field \"TextForUser\" of the FlightStatusMode class", ignore_extras);
            fieldGeneratorLastUserResponse = new FieldHoldingGeneratorLastUserResponse("field \"LastUserResponse\" of the FlightStatusMode class");
            fieldGeneratorWrittenHints = new JSONHoldingStringArrayGenerator("field \"WrittenHints\" of the FlightStatusMode class");
            fieldGeneratorSpokenHints = new JSONHoldingStringArrayGenerator("field \"SpokenHints\" of the FlightStatusMode class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the FlightStatusMode class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorFlightSpecIndex = new FieldHoldingGeneratorFlightSpecIndex("field \"FlightSpecIndex\" of the FlightStatusMode class");
            fieldGeneratorAskingUserFor = new FlightStatusLookupParameterJSON.HoldingGenerator("field \"AskingUserFor\" of the FlightStatusMode class", false);
            fieldGeneratorAlreadyAskedUser = new FlightStatusLookupParameterJSON.HoldingArrayGenerator("field \"AlreadyAskedUser\" of the FlightStatusMode class", false);
            fieldGeneratorNotUnderstoodCount = new FieldHoldingGeneratorNotUnderstoodCount("field \"NotUnderstoodCount\" of the FlightStatusMode class");
            fieldGeneratorTextForUser = new ResponseTypesJSON.HoldingGenerator("field \"TextForUser\" of the FlightStatusMode class", false);
            fieldGeneratorLastUserResponse = new FieldHoldingGeneratorLastUserResponse("field \"LastUserResponse\" of the FlightStatusMode class");
            fieldGeneratorWrittenHints = new JSONHoldingStringArrayGenerator("field \"WrittenHints\" of the FlightStatusMode class");
            fieldGeneratorSpokenHints = new JSONHoldingStringArrayGenerator("field \"SpokenHints\" of the FlightStatusMode class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the FlightStatusMode class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorFlightSpecIndex.reset();
            fieldGeneratorAskingUserFor.reset();
            fieldGeneratorAlreadyAskedUser.reset();
            fieldGeneratorNotUnderstoodCount.reset();
            fieldGeneratorTextForUser.reset();
            fieldGeneratorLastUserResponse.reset();
            fieldGeneratorWrittenHints.reset();
            fieldGeneratorSpokenHints.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorAskingUserFor.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAlreadyAskedUser.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorTextForUser.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorAskingUserFor.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAlreadyAskedUser.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorTextForUser.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(FlightStatusModeJSON  result)
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
        public FlightStatusModeJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(FlightStatusModeJSON  result)
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
    protected virtual void handle_result(List<FlightStatusModeJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<FlightStatusModeJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<FlightStatusModeJSON>();
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
    public List<FlightStatusModeJSON> value;
  };
  };
