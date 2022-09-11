/* file "OAuth2TokensJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class OAuth2TokensJSON : JSONBase
  {
    private bool flagHasRefreshToken;
    private string storeRefreshToken;
    private bool flagHasAccessToken;
    private string storeAccessToken;
    private bool flagHasAccessTokenExpirationTimestamp;
    private BigInteger storeAccessTokenExpirationTimestamp;
    private bool flagHasRedirectURI;
    private string storeRedirectURI;
    private bool flagHasCode;
    private string storeCode;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONRefreshToken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RefreshToken of OAuth2TokensJSON is not a string.");
        setRefreshToken(json_string.getData());
      }


    private void  fromJSONAccessToken(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AccessToken of OAuth2TokensJSON is not a string.");
        setAccessToken(json_string.getData());
      }


    private void  fromJSONAccessTokenExpirationTimestamp(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field AccessTokenExpirationTimestamp of OAuth2TokensJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field AccessTokenExpirationTimestamp of OAuth2TokensJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setAccessTokenExpirationTimestamp(extracted_integer);
      }


    private void  fromJSONRedirectURI(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field RedirectURI of OAuth2TokensJSON is not a string.");
        setRedirectURI(json_string.getData());
      }


    private void  fromJSONCode(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Code of OAuth2TokensJSON is not a string.");
        setCode(json_string.getData());
      }


    public OAuth2TokensJSON()
      {
        flagHasRefreshToken = false;
        flagHasAccessToken = false;
        flagHasAccessTokenExpirationTimestamp = false;
        flagHasRedirectURI = false;
        flagHasCode = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasRefreshToken()
      {
        return flagHasRefreshToken;
      }

    public string  getRefreshToken()
      {
        Debug.Assert(flagHasRefreshToken);
        return storeRefreshToken;
      }

    public bool  hasAccessToken()
      {
        return flagHasAccessToken;
      }

    public string  getAccessToken()
      {
        Debug.Assert(flagHasAccessToken);
        return storeAccessToken;
      }

    public bool  hasAccessTokenExpirationTimestamp()
      {
        return flagHasAccessTokenExpirationTimestamp;
      }

    public BigInteger  getAccessTokenExpirationTimestamp()
      {
        Debug.Assert(flagHasAccessTokenExpirationTimestamp);
        return storeAccessTokenExpirationTimestamp;
      }

    public bool  hasRedirectURI()
      {
        return flagHasRedirectURI;
      }

    public string  getRedirectURI()
      {
        Debug.Assert(flagHasRedirectURI);
        return storeRedirectURI;
      }

    public bool  hasCode()
      {
        return flagHasCode;
      }

    public string  getCode()
      {
        Debug.Assert(flagHasCode);
        return storeCode;
      }


    public virtual int extraOAuth2TokensComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraOAuth2TokensComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraOAuth2TokensComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraOAuth2TokensLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setRefreshToken(string new_value)
      {
        flagHasRefreshToken = true;
        storeRefreshToken = new_value;
      }
    public void unsetRefreshToken()
      {
        flagHasRefreshToken = false;
      }
    public void setAccessToken(string new_value)
      {
        flagHasAccessToken = true;
        storeAccessToken = new_value;
      }
    public void unsetAccessToken()
      {
        flagHasAccessToken = false;
      }
    public void setAccessTokenExpirationTimestamp(BigInteger new_value)
      {
        flagHasAccessTokenExpirationTimestamp = true;
        if (new_value < 0)
            throw new Exception("The value for field AccessTokenExpirationTimestamp of OAuth2TokensJSON is less than the lower bound (0) for that field.");
        storeAccessTokenExpirationTimestamp = new_value;
      }
    public void unsetAccessTokenExpirationTimestamp()
      {
        flagHasAccessTokenExpirationTimestamp = false;
      }
    public void setRedirectURI(string new_value)
      {
        flagHasRedirectURI = true;
        storeRedirectURI = new_value;
      }
    public void unsetRedirectURI()
      {
        flagHasRedirectURI = false;
      }
    public void setCode(string new_value)
      {
        flagHasCode = true;
        storeCode = new_value;
      }
    public void unsetCode()
      {
        flagHasCode = false;
      }

    public virtual void extraOAuth2TokensAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraOAuth2TokensSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraOAuth2TokensLookup(key);
        if (old_field == null)
          {
            extraOAuth2TokensAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasRefreshToken);
        if (flagHasRefreshToken)
          {
            handler.start_pair("RefreshToken");
            handler.string_value(storeRefreshToken);
          }
        Debug.Assert(partial_allowed || flagHasAccessToken);
        if (flagHasAccessToken)
          {
            handler.start_pair("AccessToken");
            handler.string_value(storeAccessToken);
          }
        Debug.Assert(partial_allowed || flagHasAccessTokenExpirationTimestamp);
        if (flagHasAccessTokenExpirationTimestamp)
          {
            handler.start_pair("AccessTokenExpirationTimestamp");
            handler.number_value(storeAccessTokenExpirationTimestamp);
          }
        if (flagHasRedirectURI)
          {
            handler.start_pair("RedirectURI");
            handler.string_value(storeRedirectURI);
          }
        if (flagHasCode)
          {
            handler.start_pair("Code");
            handler.string_value(storeCode);
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
        if (!(hasRefreshToken()))
          {
            return "When parsing the object for %what%, the \"RefreshToken\" field was missing.";
          }
        if (!(hasAccessToken()))
          {
            return "When parsing the object for %what%, the \"AccessToken\" field was missing.";
          }
        if (!(hasAccessTokenExpirationTimestamp()))
          {
            return "When parsing the object for %what%, the \"AccessTokenExpirationTimestamp\" field was missing.";
          }
        return null;
      }

    public static OAuth2TokensJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OAuth2TokensJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OAuth2Tokens", ignore_extras);
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
    public static OAuth2TokensJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OAuth2TokensJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        OAuth2TokensJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OAuth2Tokens", ignore_extras);
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
    public static OAuth2TokensJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static OAuth2TokensJSON from_text(string text, bool ignore_extras)
      {
        OAuth2TokensJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OAuth2Tokens", ignore_extras);
            JSONParse.parse_json_value(text, "Text for OAuth2TokensJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static OAuth2TokensJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        OAuth2TokensJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type OAuth2Tokens", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorRefreshToken;
        private JSONHoldingStringGenerator fieldGeneratorAccessToken;
    private class FieldHoldingGeneratorAccessTokenExpirationTimestamp : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorAccessTokenExpirationTimestamp(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorAccessTokenExpirationTimestamp : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorAccessTokenExpirationTimestamp(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorAccessTokenExpirationTimestamp fieldGeneratorAccessTokenExpirationTimestamp;
        private JSONHoldingStringGenerator fieldGeneratorRedirectURI;
        private JSONHoldingStringGenerator fieldGeneratorCode;
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
            OAuth2TokensJSON result = new OAuth2TokensJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraOAuth2TokensAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(OAuth2TokensJSON result)
          {
            if (fieldGeneratorRefreshToken.have_value)
              {
                result.setRefreshToken(fieldGeneratorRefreshToken.value);
                fieldGeneratorRefreshToken.have_value = false;
              }
            else if ((!(result.hasRefreshToken())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"RefreshToken\" field was missing.");
              }
            if (fieldGeneratorAccessToken.have_value)
              {
                result.setAccessToken(fieldGeneratorAccessToken.value);
                fieldGeneratorAccessToken.have_value = false;
              }
            else if ((!(result.hasAccessToken())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AccessToken\" field was missing.");
              }
            if (fieldGeneratorAccessTokenExpirationTimestamp.have_value)
              {
                result.setAccessTokenExpirationTimestamp(fieldGeneratorAccessTokenExpirationTimestamp.value);
                fieldGeneratorAccessTokenExpirationTimestamp.have_value = false;
              }
            else if ((!(result.hasAccessTokenExpirationTimestamp())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"AccessTokenExpirationTimestamp\" field was missing.");
              }
            if (fieldGeneratorRedirectURI.have_value)
              {
                result.setRedirectURI(fieldGeneratorRedirectURI.value);
                fieldGeneratorRedirectURI.have_value = false;
              }
            if (fieldGeneratorCode.have_value)
              {
                result.setCode(fieldGeneratorCode.value);
                fieldGeneratorCode.have_value = false;
              }
          }
        protected abstract void handle_result(OAuth2TokensJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "ccessToken", 0, 10, false) == 0)
                      {
                        if (field_name.Length == 11)
                          {
                            return fieldGeneratorAccessToken;
                          }
                        switch (field_name[11])
                          {
                            case 'E':
                                if ((String.Compare(field_name, 12, "xpirationTimestamp", 0, 18, false) == 0) && (field_name.Length == 30))
                                    return fieldGeneratorAccessTokenExpirationTimestamp;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'C':
                    if ((String.Compare(field_name, 1, "ode", 0, 3, false) == 0) && (field_name.Length == 4))
                        return fieldGeneratorCode;
                    break;
                case 'R':
                    if (String.Compare(field_name, 1, "e", 0, 1, false) == 0)
                      {
                        switch (field_name[2])
                          {
                            case 'd':
                                if ((String.Compare(field_name, 3, "irectURI", 0, 8, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorRedirectURI;
                                break;
                            case 'f':
                                if ((String.Compare(field_name, 3, "reshToken", 0, 9, false) == 0) && (field_name.Length == 12))
                                    return fieldGeneratorRefreshToken;
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
            fieldGeneratorRefreshToken = new JSONHoldingStringGenerator("field \"RefreshToken\" of the OAuth2Tokens class");
            fieldGeneratorAccessToken = new JSONHoldingStringGenerator("field \"AccessToken\" of the OAuth2Tokens class");
            fieldGeneratorAccessTokenExpirationTimestamp = new FieldHoldingGeneratorAccessTokenExpirationTimestamp("field \"AccessTokenExpirationTimestamp\" of the OAuth2Tokens class");
            fieldGeneratorRedirectURI = new JSONHoldingStringGenerator("field \"RedirectURI\" of the OAuth2Tokens class");
            fieldGeneratorCode = new JSONHoldingStringGenerator("field \"Code\" of the OAuth2Tokens class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the OAuth2Tokens class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorRefreshToken = new JSONHoldingStringGenerator("field \"RefreshToken\" of the OAuth2Tokens class");
            fieldGeneratorAccessToken = new JSONHoldingStringGenerator("field \"AccessToken\" of the OAuth2Tokens class");
            fieldGeneratorAccessTokenExpirationTimestamp = new FieldHoldingGeneratorAccessTokenExpirationTimestamp("field \"AccessTokenExpirationTimestamp\" of the OAuth2Tokens class");
            fieldGeneratorRedirectURI = new JSONHoldingStringGenerator("field \"RedirectURI\" of the OAuth2Tokens class");
            fieldGeneratorCode = new JSONHoldingStringGenerator("field \"Code\" of the OAuth2Tokens class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the OAuth2Tokens class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorRefreshToken.reset();
            fieldGeneratorAccessToken.reset();
            fieldGeneratorAccessTokenExpirationTimestamp.reset();
            fieldGeneratorRedirectURI.reset();
            fieldGeneratorCode.reset();
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
        protected override void handle_result(OAuth2TokensJSON  result)
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
        public OAuth2TokensJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(OAuth2TokensJSON  result)
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
    protected virtual void handle_result(List<OAuth2TokensJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<OAuth2TokensJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<OAuth2TokensJSON>();
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
    public List<OAuth2TokensJSON> value;
  };
  };
