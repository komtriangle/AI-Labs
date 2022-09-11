/* file "OAuth2ErrorDataJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class OAuth2ErrorDataJSON : CommandErrorJSON
  {
    public enum TypeOAuth2ErrorTypeKnownValues
      {
        OAuth2ErrorType_MissingClientID,
        OAuth2ErrorType_MissingClientSecret,
        OAuth2ErrorType_MissingAuthorizationCode,
        OAuth2ErrorType_MissingRedirectURI,
        OAuth2ErrorType_MissingRefreshToken,
        OAuth2ErrorType_MissingAccessToken,
        OAuth2ErrorType_MissingAccessTokenExpiration,
        OAuth2ErrorType_APIError,
        OAuth2ErrorType_UserNotConnected,
        OAuth2ErrorType_UnexpectedStatus,
        OAuth2ErrorType__none
      };
    public struct TypeOAuth2ErrorType
      {
        public bool in_known_list;
        public string string_value;
        public TypeOAuth2ErrorTypeKnownValues list_value;
      };

    public static TypeOAuth2ErrorTypeKnownValues  stringToOAuth2ErrorType(string chars)
      {
        switch (chars[0])
          {
            case 'A':
                if ((String.Compare(chars, 1, "PIError", 0, 7, false) == 0) && (chars.Length == 8))
                    return TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_APIError;
                break;
            case 'M':
                if (String.Compare(chars, 1, "issing", 0, 6, false) == 0)
                  {
                    switch (chars[7])
                      {
                        case 'A':
                            switch (chars[8])
                              {
                                case 'c':
                                    if (String.Compare(chars, 9, "cessToken", 0, 9, false) == 0)
                                      {
                                        if (chars.Length == 18)
                                          {
                                            return TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAccessToken;
                                          }
                                        switch (chars[18])
                                          {
                                            case 'E':
                                                if ((String.Compare(chars, 19, "xpiration", 0, 9, false) == 0) && (chars.Length == 28))
                                                    return TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAccessTokenExpiration;
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'u':
                                    if ((String.Compare(chars, 9, "thorizationCode", 0, 15, false) == 0) && (chars.Length == 24))
                                        return TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAuthorizationCode;
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'C':
                            if (String.Compare(chars, 8, "lient", 0, 5, false) == 0)
                              {
                                switch (chars[13])
                                  {
                                    case 'I':
                                        if ((String.Compare(chars, 14, "D", 0, 1, false) == 0) && (chars.Length == 15))
                                            return TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingClientID;
                                        break;
                                    case 'S':
                                        if ((String.Compare(chars, 14, "ecret", 0, 5, false) == 0) && (chars.Length == 19))
                                            return TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingClientSecret;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if (String.Compare(chars, 8, "e", 0, 1, false) == 0)
                              {
                                switch (chars[9])
                                  {
                                    case 'd':
                                        if ((String.Compare(chars, 10, "irectURI", 0, 8, false) == 0) && (chars.Length == 18))
                                            return TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingRedirectURI;
                                        break;
                                    case 'f':
                                        if ((String.Compare(chars, 10, "reshToken", 0, 9, false) == 0) && (chars.Length == 19))
                                            return TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingRefreshToken;
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
            case 'U':
                switch (chars[1])
                  {
                    case 'n':
                        if ((String.Compare(chars, 2, "expectedStatus", 0, 14, false) == 0) && (chars.Length == 16))
                            return TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_UnexpectedStatus;
                        break;
                    case 's':
                        if ((String.Compare(chars, 2, "erNotConnected", 0, 14, false) == 0) && (chars.Length == 16))
                            return TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_UserNotConnected;
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        return TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType__none;
      }

    public static string  stringFromOAuth2ErrorType(TypeOAuth2ErrorTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingClientID:
                return "MissingClientID";
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingClientSecret:
                return "MissingClientSecret";
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAuthorizationCode:
                return "MissingAuthorizationCode";
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingRedirectURI:
                return "MissingRedirectURI";
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingRefreshToken:
                return "MissingRefreshToken";
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAccessToken:
                return "MissingAccessToken";
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAccessTokenExpiration:
                return "MissingAccessTokenExpiration";
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_APIError:
                return "APIError";
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_UserNotConnected:
                return "UserNotConnected";
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_UnexpectedStatus:
                return "UnexpectedStatus";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasServiceType;
    private OAuth2ServiceTypeJSON  storeServiceType;
    private bool flagHasOAuth2ErrorType;
    private TypeOAuth2ErrorType storeOAuth2ErrorType;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraServiceTypeToJSON()
      {
        JSONValueHandler handler_ServiceType = new JSONValueHandler();
        storeServiceType.write_as_json(handler_ServiceType);
        return handler_ServiceType.result;
      }

    private JSONValue  extraOAuth2ErrorTypeToJSON()
      {
        JSONStringValue generated_string_OAuth2ErrorType;
        if (!(storeOAuth2ErrorType.in_known_list))
          {
        generated_string_OAuth2ErrorType = new JSONStringValue(storeOAuth2ErrorType.string_value);
          }
        else
          {
        switch (storeOAuth2ErrorType.list_value)
          {
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingClientID:
                generated_string_OAuth2ErrorType = new JSONStringValue("MissingClientID");
                break;
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingClientSecret:
                generated_string_OAuth2ErrorType = new JSONStringValue("MissingClientSecret");
                break;
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAuthorizationCode:
                generated_string_OAuth2ErrorType = new JSONStringValue("MissingAuthorizationCode");
                break;
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingRedirectURI:
                generated_string_OAuth2ErrorType = new JSONStringValue("MissingRedirectURI");
                break;
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingRefreshToken:
                generated_string_OAuth2ErrorType = new JSONStringValue("MissingRefreshToken");
                break;
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAccessToken:
                generated_string_OAuth2ErrorType = new JSONStringValue("MissingAccessToken");
                break;
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAccessTokenExpiration:
                generated_string_OAuth2ErrorType = new JSONStringValue("MissingAccessTokenExpiration");
                break;
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_APIError:
                generated_string_OAuth2ErrorType = new JSONStringValue("APIError");
                break;
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_UserNotConnected:
                generated_string_OAuth2ErrorType = new JSONStringValue("UserNotConnected");
                break;
            case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_UnexpectedStatus:
                generated_string_OAuth2ErrorType = new JSONStringValue("UnexpectedStatus");
                break;
            default:
                Debug.Assert(false);
                generated_string_OAuth2ErrorType = null;
                break;
          }
          }
        return generated_string_OAuth2ErrorType;
      }


    private void  fromJSONServiceType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        OAuth2ServiceTypeJSON convert_classy = OAuth2ServiceTypeJSON.from_json(json_value, ignore_extras, true);
        setServiceType(convert_classy);
      }


    private void  fromJSONOAuth2ErrorType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field OAuth2ErrorType of OAuth2ErrorDataJSON is not a string.");
        TypeOAuth2ErrorType the_open_enum = new TypeOAuth2ErrorType();
        switch (json_string.getData()[0])
          {
            case 'A':
                if ((String.Compare(json_string.getData(), 1, "PIError", 0, 7, false) == 0) && (json_string.getData().Length == 8))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_APIError;
                        goto open_enum_is_done;
                      }
                break;
            case 'M':
                if (String.Compare(json_string.getData(), 1, "issing", 0, 6, false) == 0)
                  {
                    switch (json_string.getData()[7])
                      {
                        case 'A':
                            switch (json_string.getData()[8])
                              {
                                case 'c':
                                    if (String.Compare(json_string.getData(), 9, "cessToken", 0, 9, false) == 0)
                                      {
                                        if (json_string.getData().Length == 18)
                                          {
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAccessToken;
                                                goto open_enum_is_done;
                                              }
                                          }
                                        switch (json_string.getData()[18])
                                          {
                                            case 'E':
                                                if ((String.Compare(json_string.getData(), 19, "xpiration", 0, 9, false) == 0) && (json_string.getData().Length == 28))
                                                      {
                                                        the_open_enum.in_known_list = true;
                                                        the_open_enum.list_value = TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAccessTokenExpiration;
                                                        goto open_enum_is_done;
                                                      }
                                                break;
                                            default:
                                                break;
                                          }
                                      }
                                    break;
                                case 'u':
                                    if ((String.Compare(json_string.getData(), 9, "thorizationCode", 0, 15, false) == 0) && (json_string.getData().Length == 24))
                                          {
                                            the_open_enum.in_known_list = true;
                                            the_open_enum.list_value = TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAuthorizationCode;
                                            goto open_enum_is_done;
                                          }
                                    break;
                                default:
                                    break;
                              }
                            break;
                        case 'C':
                            if (String.Compare(json_string.getData(), 8, "lient", 0, 5, false) == 0)
                              {
                                switch (json_string.getData()[13])
                                  {
                                    case 'I':
                                        if ((String.Compare(json_string.getData(), 14, "D", 0, 1, false) == 0) && (json_string.getData().Length == 15))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingClientID;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'S':
                                        if ((String.Compare(json_string.getData(), 14, "ecret", 0, 5, false) == 0) && (json_string.getData().Length == 19))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingClientSecret;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'R':
                            if (String.Compare(json_string.getData(), 8, "e", 0, 1, false) == 0)
                              {
                                switch (json_string.getData()[9])
                                  {
                                    case 'd':
                                        if ((String.Compare(json_string.getData(), 10, "irectURI", 0, 8, false) == 0) && (json_string.getData().Length == 18))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingRedirectURI;
                                                goto open_enum_is_done;
                                              }
                                        break;
                                    case 'f':
                                        if ((String.Compare(json_string.getData(), 10, "reshToken", 0, 9, false) == 0) && (json_string.getData().Length == 19))
                                              {
                                                the_open_enum.in_known_list = true;
                                                the_open_enum.list_value = TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingRefreshToken;
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
                  }
                break;
            case 'U':
                switch (json_string.getData()[1])
                  {
                    case 'n':
                        if ((String.Compare(json_string.getData(), 2, "expectedStatus", 0, 14, false) == 0) && (json_string.getData().Length == 16))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_UnexpectedStatus;
                                goto open_enum_is_done;
                              }
                        break;
                    case 's':
                        if ((String.Compare(json_string.getData(), 2, "erNotConnected", 0, 14, false) == 0) && (json_string.getData().Length == 16))
                              {
                                the_open_enum.in_known_list = true;
                                the_open_enum.list_value = TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_UserNotConnected;
                                goto open_enum_is_done;
                              }
                        break;
                    default:
                        break;
                  }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setOAuth2ErrorType(the_open_enum);
      }


    public OAuth2ErrorDataJSON()
      {
        flagHasServiceType = false;
        flagHasOAuth2ErrorType = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getErrorType()
      {
        return "OAuth2Error";
      }

    public bool  hasServiceType()
      {
        return flagHasServiceType;
      }

    public OAuth2ServiceTypeJSON   getServiceType()
      {
        Debug.Assert(flagHasServiceType);
        return storeServiceType;
      }

    public OAuth2ServiceTypeJSON.TypeValue  getServiceTypeValue()
      {
        return getServiceType().getValue();
      }

    public string  getServiceTypeAsString()
      {
        return getServiceType().getValueAsString();
      }

    public bool  hasOAuth2ErrorType()
      {
        return flagHasOAuth2ErrorType;
      }

    public TypeOAuth2ErrorType  getOAuth2ErrorType()
      {
        Debug.Assert(flagHasOAuth2ErrorType);
        return storeOAuth2ErrorType;
      }

    public string  getOAuth2ErrorTypeAsString()
      {
        TypeOAuth2ErrorType result = getOAuth2ErrorType();
        if (result.in_known_list)
            return stringFromOAuth2ErrorType(result.list_value);
        else
            return result.string_value;
      }


    public virtual int extraOAuth2ErrorDataComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOAuth2ErrorDataComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOAuth2ErrorDataComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOAuth2ErrorDataLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraCommandErrorComponentCount()
      {
        int result = 0;
        if (flagHasServiceType)
            ++result;
        if (flagHasOAuth2ErrorType)
            ++result;
        result += extraOAuth2ErrorDataComponentCount();
        return result;
      }
    public override string extraCommandErrorComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasServiceType)
          {
            if (remainder == 0)
                return "ServiceType";
            --remainder;
          }
        if (flagHasOAuth2ErrorType)
          {
            if (remainder == 0)
                return "OAuth2ErrorType";
            --remainder;
          }
        return extraOAuth2ErrorDataComponentKey(remainder);
      }
    public override JSONValue extraCommandErrorComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasServiceType)
          {
            if (remainder == 0)
                return extraServiceTypeToJSON();
            --remainder;
          }
        if (flagHasOAuth2ErrorType)
          {
            if (remainder == 0)
                return extraOAuth2ErrorTypeToJSON();
            --remainder;
          }
        return extraOAuth2ErrorDataComponentValue(remainder);
      }
    public override JSONValue extraCommandErrorLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'O':
                if ((String.Compare(field_name, 1, "Auth2ErrorType", 0, 14, false) == 0) && (field_name.Length == 15))
                    return (flagHasOAuth2ErrorType ? extraOAuth2ErrorTypeToJSON() : null);
                break;
            case 'S':
                if ((String.Compare(field_name, 1, "erviceType", 0, 10, false) == 0) && (field_name.Length == 11))
                    return (flagHasServiceType ? extraServiceTypeToJSON() : null);
                break;
            default:
                break;
          }
        return extraOAuth2ErrorDataLookup(field_name);
      }

    public void setServiceType(OAuth2ServiceTypeJSON  new_value)
      {
        if (flagHasServiceType)
          {
          }
        flagHasServiceType = true;
        storeServiceType = new_value;
      }
    public void setServiceType(OAuth2ServiceTypeJSON.TypeValue new_value)
      {
        setServiceType(new OAuth2ServiceTypeJSON(new_value));
      }
    public void setServiceType(string chars)
      {
        OAuth2ServiceTypeJSON.TypeValueKnownValues known = OAuth2ServiceTypeJSON.stringToValue(chars);
        OAuth2ServiceTypeJSON.TypeValue new_value = new OAuth2ServiceTypeJSON.TypeValue();
        if (known == OAuth2ServiceTypeJSON.TypeValueKnownValues.Value__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setServiceType(new_value);
      }
    public void unsetServiceType()
      {
        if (flagHasServiceType)
          {
          }
        flagHasServiceType = false;
      }
    public void setOAuth2ErrorType(TypeOAuth2ErrorType new_value)
      {
        flagHasOAuth2ErrorType = true;
        storeOAuth2ErrorType = new_value;
      }
    public void setOAuth2ErrorType(string chars)
      {
        TypeOAuth2ErrorTypeKnownValues known = stringToOAuth2ErrorType(chars);
        TypeOAuth2ErrorType new_value = new TypeOAuth2ErrorType();
        if (known == TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setOAuth2ErrorType(new_value);
      }
    public void setOAuth2ErrorType(TypeOAuth2ErrorTypeKnownValues new_value)
      {
        TypeOAuth2ErrorType new_full_value = new TypeOAuth2ErrorType();
        Debug.Assert(new_value != TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setOAuth2ErrorType(new_full_value);
      }
    public void unsetOAuth2ErrorType()
      {
        flagHasOAuth2ErrorType = false;
      }

    public virtual void extraOAuth2ErrorDataAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOAuth2ErrorDataSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOAuth2ErrorDataLookup(key);
        if (old_field == null)
          {
            extraOAuth2ErrorDataAppendPair(key, new_component);
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
    public override void extraCommandErrorAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'O':
                if ((String.Compare(key, 1, "Auth2ErrorType", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONOAuth2ErrorType(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "erviceType", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONServiceType(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraOAuth2ErrorDataAppendPair(key, new_component);
      }
    public override void extraCommandErrorSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'O':
                if ((String.Compare(key, 1, "Auth2ErrorType", 0, 14, false) == 0) && (key.Length == 15))
                    {
                    fromJSONOAuth2ErrorType(new_component, false);
                    return;
                    }
                break;
            case 'S':
                if ((String.Compare(key, 1, "erviceType", 0, 10, false) == 0) && (key.Length == 11))
                    {
                    fromJSONServiceType(new_component, false);
                    return;
                    }
                break;
            default:
                break;
          }
        extraOAuth2ErrorDataSetField(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasServiceType);
        if (flagHasServiceType)
          {
            handler.start_pair("ServiceType");
            if (partial_allowed)
                storeServiceType.write_partial_as_json(handler);
            else
                storeServiceType.write_as_json(handler);
          }
        if (flagHasOAuth2ErrorType)
          {
            handler.start_pair("OAuth2ErrorType");
            if (storeOAuth2ErrorType.in_known_list)
              {
                switch (storeOAuth2ErrorType.list_value)
                  {
                    case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingClientID:
                        handler.string_value("MissingClientID");
                        break;
                    case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingClientSecret:
                        handler.string_value("MissingClientSecret");
                        break;
                    case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAuthorizationCode:
                        handler.string_value("MissingAuthorizationCode");
                        break;
                    case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingRedirectURI:
                        handler.string_value("MissingRedirectURI");
                        break;
                    case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingRefreshToken:
                        handler.string_value("MissingRefreshToken");
                        break;
                    case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAccessToken:
                        handler.string_value("MissingAccessToken");
                        break;
                    case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_MissingAccessTokenExpiration:
                        handler.string_value("MissingAccessTokenExpiration");
                        break;
                    case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_APIError:
                        handler.string_value("APIError");
                        break;
                    case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_UserNotConnected:
                        handler.string_value("UserNotConnected");
                        break;
                    case TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType_UnexpectedStatus:
                        handler.string_value("UnexpectedStatus");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeOAuth2ErrorType.string_value);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        if (!(hasServiceType()))
          {
            return "When parsing the object for %what%, the \"ServiceType\" field was missing.";
          }
        return null;
      }

    public static new OAuth2ErrorDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OAuth2ErrorDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OAuth2ErrorData", ignore_extras);
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
    public static new OAuth2ErrorDataJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new OAuth2ErrorDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OAuth2ErrorDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OAuth2ErrorData", ignore_extras);
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
    public static new OAuth2ErrorDataJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new OAuth2ErrorDataJSON from_text(string text, bool ignore_extras)
      {
        OAuth2ErrorDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OAuth2ErrorData", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OAuth2ErrorDataJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new OAuth2ErrorDataJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OAuth2ErrorDataJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OAuth2ErrorData", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : CommandErrorJSON.Generator
      {
        private OAuth2ServiceTypeJSON.HoldingGenerator fieldGeneratorServiceType;
    private abstract class FieldGeneratorOAuth2ErrorType : JSONStringGenerator
          {
            protected FieldGeneratorOAuth2ErrorType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorOAuth2ErrorType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeOAuth2ErrorTypeKnownValues known = stringToOAuth2ErrorType(result);
                TypeOAuth2ErrorType new_value = new TypeOAuth2ErrorType();
                if (known == TypeOAuth2ErrorTypeKnownValues.OAuth2ErrorType__none)
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
            protected abstract void handle_result(TypeOAuth2ErrorType result);
          };
    private class FieldHoldingGeneratorOAuth2ErrorType : FieldGeneratorOAuth2ErrorType
  {
    protected override void handle_result(TypeOAuth2ErrorType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorOAuth2ErrorType(String what)
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
    public TypeOAuth2ErrorType value;
  };
    private class FieldHoldingArrayGeneratorOAuth2ErrorType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorOAuth2ErrorType
      {
        private FieldHoldingArrayGeneratorOAuth2ErrorType top;

        protected override void handle_result(TypeOAuth2ErrorType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorOAuth2ErrorType init_top)
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
    protected virtual void handle_result(List<TypeOAuth2ErrorType> result)
      {
      }

    public FieldHoldingArrayGeneratorOAuth2ErrorType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeOAuth2ErrorType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorOAuth2ErrorType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeOAuth2ErrorType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeOAuth2ErrorType> value;
  };
        private FieldHoldingGeneratorOAuth2ErrorType fieldGeneratorOAuth2ErrorType;
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
            if (!(getCommandErrorJSONKey().Equals("OAuth2Error")))
                throw new Exception("The key field has a value other than `OAuth2Error'.");
            OAuth2ErrorDataJSON result = new OAuth2ErrorDataJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOAuth2ErrorDataAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(CommandErrorJSON new_result)
          {
            handle_result((OAuth2ErrorDataJSON )new_result);
          }
        protected void finish(OAuth2ErrorDataJSON result)
          {
            if (fieldGeneratorServiceType.have_value)
              {
                result.setServiceType(fieldGeneratorServiceType.value);
                fieldGeneratorServiceType.have_value = false;
              }
            else if ((!(result.hasServiceType())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ServiceType\" field was missing.");
              }
            if (fieldGeneratorOAuth2ErrorType.have_value)
              {
                result.setOAuth2ErrorType(fieldGeneratorOAuth2ErrorType.value);
                fieldGeneratorOAuth2ErrorType.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(OAuth2ErrorDataJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'O':
                    if ((String.Compare(field_name, 1, "Auth2ErrorType", 0, 14, false) == 0) && (field_name.Length == 15))
                        return fieldGeneratorOAuth2ErrorType;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "erviceType", 0, 10, false) == 0) && (field_name.Length == 11))
                        return fieldGeneratorServiceType;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorServiceType = new OAuth2ServiceTypeJSON.HoldingGenerator("field \"ServiceType\" of the OAuth2ErrorData class", ignore_extras);
            fieldGeneratorOAuth2ErrorType = new FieldHoldingGeneratorOAuth2ErrorType("field \"OAuth2ErrorType\" of the OAuth2ErrorData class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OAuth2ErrorData class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorServiceType = new OAuth2ServiceTypeJSON.HoldingGenerator("field \"ServiceType\" of the OAuth2ErrorData class", false);
            fieldGeneratorOAuth2ErrorType = new FieldHoldingGeneratorOAuth2ErrorType("field \"OAuth2ErrorType\" of the OAuth2ErrorData class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OAuth2ErrorData class");
          }

        public override void reset()
          {
            fieldGeneratorServiceType.reset();
            fieldGeneratorOAuth2ErrorType.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(OAuth2ErrorDataJSON  result)
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
        public OAuth2ErrorDataJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OAuth2ErrorDataJSON  result)
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
    protected virtual void handle_result(List<OAuth2ErrorDataJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OAuth2ErrorDataJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OAuth2ErrorDataJSON>();
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
    public List<OAuth2ErrorDataJSON> value;
  };
  };
