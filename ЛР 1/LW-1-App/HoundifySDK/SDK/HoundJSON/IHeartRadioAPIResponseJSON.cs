/* file "IHeartRadioAPIResponseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class IHeartRadioAPIResponseJSON : JSONBase
  {
    private bool flagHasLiveStationsAPIResponse;
    private IHeartRadioLiveStationsAPIResponseStationsJSON  storeLiveStationsAPIResponse;
    private bool flagHasCreateCustomRadioStationAPIResponse;
    private IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON  storeCreateCustomRadioStationAPIResponse;
    private bool flagHasRequestCustomRadioStationAPIResponse;
    private IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON  storeRequestCustomRadioStationAPIResponse;
    private bool flagHasSearchAllAPIResponse;
    private IHeartRadioSearchAllAPIResponseJSON  storeSearchAllAPIResponse;
    private bool flagHasMarketsAPIResponse;
    private IHeartRadioMarketsAPIResponseJSON  storeMarketsAPIResponse;
    private bool flagHasLoginOrCreateOAuthUserAPIResponse;
    private IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON  storeLoginOrCreateOAuthUserAPIResponse;
    private bool flagHasForYouAPIResponse;
    private IHeartRadioForYouAPIResponseJSON  storeForYouAPIResponse;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONLiveStationsAPIResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioLiveStationsAPIResponseStationsJSON convert_classy = IHeartRadioLiveStationsAPIResponseStationsJSON.from_json(json_value, ignore_extras, true);
        setLiveStationsAPIResponse(convert_classy);
      }


    private void  fromJSONCreateCustomRadioStationAPIResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON convert_classy = IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON.from_json(json_value, ignore_extras, true);
        setCreateCustomRadioStationAPIResponse(convert_classy);
      }


    private void  fromJSONRequestCustomRadioStationAPIResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON convert_classy = IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON.from_json(json_value, ignore_extras, true);
        setRequestCustomRadioStationAPIResponse(convert_classy);
      }


    private void  fromJSONSearchAllAPIResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioSearchAllAPIResponseJSON convert_classy = IHeartRadioSearchAllAPIResponseJSON.from_json(json_value, ignore_extras, true);
        setSearchAllAPIResponse(convert_classy);
      }


    private void  fromJSONMarketsAPIResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioMarketsAPIResponseJSON convert_classy = IHeartRadioMarketsAPIResponseJSON.from_json(json_value, ignore_extras, true);
        setMarketsAPIResponse(convert_classy);
      }


    private void  fromJSONLoginOrCreateOAuthUserAPIResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON convert_classy = IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON.from_json(json_value, ignore_extras, true);
        setLoginOrCreateOAuthUserAPIResponse(convert_classy);
      }


    private void  fromJSONForYouAPIResponse(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioForYouAPIResponseJSON convert_classy = IHeartRadioForYouAPIResponseJSON.from_json(json_value, ignore_extras, true);
        setForYouAPIResponse(convert_classy);
      }


    public IHeartRadioAPIResponseJSON()
      {
        flagHasLiveStationsAPIResponse = false;
        flagHasCreateCustomRadioStationAPIResponse = false;
        flagHasRequestCustomRadioStationAPIResponse = false;
        flagHasSearchAllAPIResponse = false;
        flagHasMarketsAPIResponse = false;
        flagHasLoginOrCreateOAuthUserAPIResponse = false;
        flagHasForYouAPIResponse = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasLiveStationsAPIResponse()
      {
        return flagHasLiveStationsAPIResponse;
      }

    public IHeartRadioLiveStationsAPIResponseStationsJSON   getLiveStationsAPIResponse()
      {
        Debug.Assert(flagHasLiveStationsAPIResponse);
        return storeLiveStationsAPIResponse;
      }

    public bool  hasCreateCustomRadioStationAPIResponse()
      {
        return flagHasCreateCustomRadioStationAPIResponse;
      }

    public IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON   getCreateCustomRadioStationAPIResponse()
      {
        Debug.Assert(flagHasCreateCustomRadioStationAPIResponse);
        return storeCreateCustomRadioStationAPIResponse;
      }

    public bool  hasRequestCustomRadioStationAPIResponse()
      {
        return flagHasRequestCustomRadioStationAPIResponse;
      }

    public IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON   getRequestCustomRadioStationAPIResponse()
      {
        Debug.Assert(flagHasRequestCustomRadioStationAPIResponse);
        return storeRequestCustomRadioStationAPIResponse;
      }

    public bool  hasSearchAllAPIResponse()
      {
        return flagHasSearchAllAPIResponse;
      }

    public IHeartRadioSearchAllAPIResponseJSON   getSearchAllAPIResponse()
      {
        Debug.Assert(flagHasSearchAllAPIResponse);
        return storeSearchAllAPIResponse;
      }

    public bool  hasMarketsAPIResponse()
      {
        return flagHasMarketsAPIResponse;
      }

    public IHeartRadioMarketsAPIResponseJSON   getMarketsAPIResponse()
      {
        Debug.Assert(flagHasMarketsAPIResponse);
        return storeMarketsAPIResponse;
      }

    public bool  hasLoginOrCreateOAuthUserAPIResponse()
      {
        return flagHasLoginOrCreateOAuthUserAPIResponse;
      }

    public IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON   getLoginOrCreateOAuthUserAPIResponse()
      {
        Debug.Assert(flagHasLoginOrCreateOAuthUserAPIResponse);
        return storeLoginOrCreateOAuthUserAPIResponse;
      }

    public bool  hasForYouAPIResponse()
      {
        return flagHasForYouAPIResponse;
      }

    public IHeartRadioForYouAPIResponseJSON   getForYouAPIResponse()
      {
        Debug.Assert(flagHasForYouAPIResponse);
        return storeForYouAPIResponse;
      }


    public virtual int extraIHeartRadioAPIResponseComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioAPIResponseComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioAPIResponseComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioAPIResponseLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setLiveStationsAPIResponse(IHeartRadioLiveStationsAPIResponseStationsJSON  new_value)
      {
        if (flagHasLiveStationsAPIResponse)
          {
          }
        flagHasLiveStationsAPIResponse = true;
        storeLiveStationsAPIResponse = new_value;
      }
    public void unsetLiveStationsAPIResponse()
      {
        if (flagHasLiveStationsAPIResponse)
          {
          }
        flagHasLiveStationsAPIResponse = false;
      }
    public void setCreateCustomRadioStationAPIResponse(IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON  new_value)
      {
        if (flagHasCreateCustomRadioStationAPIResponse)
          {
          }
        flagHasCreateCustomRadioStationAPIResponse = true;
        storeCreateCustomRadioStationAPIResponse = new_value;
      }
    public void unsetCreateCustomRadioStationAPIResponse()
      {
        if (flagHasCreateCustomRadioStationAPIResponse)
          {
          }
        flagHasCreateCustomRadioStationAPIResponse = false;
      }
    public void setRequestCustomRadioStationAPIResponse(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON  new_value)
      {
        if (flagHasRequestCustomRadioStationAPIResponse)
          {
          }
        flagHasRequestCustomRadioStationAPIResponse = true;
        storeRequestCustomRadioStationAPIResponse = new_value;
      }
    public void unsetRequestCustomRadioStationAPIResponse()
      {
        if (flagHasRequestCustomRadioStationAPIResponse)
          {
          }
        flagHasRequestCustomRadioStationAPIResponse = false;
      }
    public void setSearchAllAPIResponse(IHeartRadioSearchAllAPIResponseJSON  new_value)
      {
        if (flagHasSearchAllAPIResponse)
          {
          }
        flagHasSearchAllAPIResponse = true;
        storeSearchAllAPIResponse = new_value;
      }
    public void unsetSearchAllAPIResponse()
      {
        if (flagHasSearchAllAPIResponse)
          {
          }
        flagHasSearchAllAPIResponse = false;
      }
    public void setMarketsAPIResponse(IHeartRadioMarketsAPIResponseJSON  new_value)
      {
        if (flagHasMarketsAPIResponse)
          {
          }
        flagHasMarketsAPIResponse = true;
        storeMarketsAPIResponse = new_value;
      }
    public void unsetMarketsAPIResponse()
      {
        if (flagHasMarketsAPIResponse)
          {
          }
        flagHasMarketsAPIResponse = false;
      }
    public void setLoginOrCreateOAuthUserAPIResponse(IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON  new_value)
      {
        if (flagHasLoginOrCreateOAuthUserAPIResponse)
          {
          }
        flagHasLoginOrCreateOAuthUserAPIResponse = true;
        storeLoginOrCreateOAuthUserAPIResponse = new_value;
      }
    public void unsetLoginOrCreateOAuthUserAPIResponse()
      {
        if (flagHasLoginOrCreateOAuthUserAPIResponse)
          {
          }
        flagHasLoginOrCreateOAuthUserAPIResponse = false;
      }
    public void setForYouAPIResponse(IHeartRadioForYouAPIResponseJSON  new_value)
      {
        if (flagHasForYouAPIResponse)
          {
          }
        flagHasForYouAPIResponse = true;
        storeForYouAPIResponse = new_value;
      }
    public void unsetForYouAPIResponse()
      {
        if (flagHasForYouAPIResponse)
          {
          }
        flagHasForYouAPIResponse = false;
      }

    public virtual void extraIHeartRadioAPIResponseAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioAPIResponseSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioAPIResponseLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioAPIResponseAppendPair(key, new_component);
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
        if (flagHasLiveStationsAPIResponse)
          {
            handler.start_pair("LiveStationsAPIResponse");
            if (partial_allowed)
                storeLiveStationsAPIResponse.write_partial_as_json(handler);
            else
                storeLiveStationsAPIResponse.write_as_json(handler);
          }
        if (flagHasCreateCustomRadioStationAPIResponse)
          {
            handler.start_pair("CreateCustomRadioStationAPIResponse");
            if (partial_allowed)
                storeCreateCustomRadioStationAPIResponse.write_partial_as_json(handler);
            else
                storeCreateCustomRadioStationAPIResponse.write_as_json(handler);
          }
        if (flagHasRequestCustomRadioStationAPIResponse)
          {
            handler.start_pair("RequestCustomRadioStationAPIResponse");
            if (partial_allowed)
                storeRequestCustomRadioStationAPIResponse.write_partial_as_json(handler);
            else
                storeRequestCustomRadioStationAPIResponse.write_as_json(handler);
          }
        if (flagHasSearchAllAPIResponse)
          {
            handler.start_pair("SearchAllAPIResponse");
            if (partial_allowed)
                storeSearchAllAPIResponse.write_partial_as_json(handler);
            else
                storeSearchAllAPIResponse.write_as_json(handler);
          }
        if (flagHasMarketsAPIResponse)
          {
            handler.start_pair("MarketsAPIResponse");
            if (partial_allowed)
                storeMarketsAPIResponse.write_partial_as_json(handler);
            else
                storeMarketsAPIResponse.write_as_json(handler);
          }
        if (flagHasLoginOrCreateOAuthUserAPIResponse)
          {
            handler.start_pair("LoginOrCreateOAuthUserAPIResponse");
            if (partial_allowed)
                storeLoginOrCreateOAuthUserAPIResponse.write_partial_as_json(handler);
            else
                storeLoginOrCreateOAuthUserAPIResponse.write_as_json(handler);
          }
        if (flagHasForYouAPIResponse)
          {
            handler.start_pair("ForYouAPIResponse");
            if (partial_allowed)
                storeForYouAPIResponse.write_partial_as_json(handler);
            else
                storeForYouAPIResponse.write_as_json(handler);
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

    public static IHeartRadioAPIResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioAPIResponse", ignore_extras);
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
    public static IHeartRadioAPIResponseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioAPIResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioAPIResponse", ignore_extras);
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
    public static IHeartRadioAPIResponseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioAPIResponseJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioAPIResponse", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioAPIResponseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioAPIResponseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioAPIResponseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioAPIResponse", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private IHeartRadioLiveStationsAPIResponseStationsJSON.HoldingGenerator fieldGeneratorLiveStationsAPIResponse;
        private IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON.HoldingGenerator fieldGeneratorCreateCustomRadioStationAPIResponse;
        private IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON.HoldingGenerator fieldGeneratorRequestCustomRadioStationAPIResponse;
        private IHeartRadioSearchAllAPIResponseJSON.HoldingGenerator fieldGeneratorSearchAllAPIResponse;
        private IHeartRadioMarketsAPIResponseJSON.HoldingGenerator fieldGeneratorMarketsAPIResponse;
        private IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON.HoldingGenerator fieldGeneratorLoginOrCreateOAuthUserAPIResponse;
        private IHeartRadioForYouAPIResponseJSON.HoldingGenerator fieldGeneratorForYouAPIResponse;
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
            IHeartRadioAPIResponseJSON result = new IHeartRadioAPIResponseJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioAPIResponseAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioAPIResponseJSON result)
          {
            if (fieldGeneratorLiveStationsAPIResponse.have_value)
              {
                result.setLiveStationsAPIResponse(fieldGeneratorLiveStationsAPIResponse.value);
                fieldGeneratorLiveStationsAPIResponse.have_value = false;
              }
            if (fieldGeneratorCreateCustomRadioStationAPIResponse.have_value)
              {
                result.setCreateCustomRadioStationAPIResponse(fieldGeneratorCreateCustomRadioStationAPIResponse.value);
                fieldGeneratorCreateCustomRadioStationAPIResponse.have_value = false;
              }
            if (fieldGeneratorRequestCustomRadioStationAPIResponse.have_value)
              {
                result.setRequestCustomRadioStationAPIResponse(fieldGeneratorRequestCustomRadioStationAPIResponse.value);
                fieldGeneratorRequestCustomRadioStationAPIResponse.have_value = false;
              }
            if (fieldGeneratorSearchAllAPIResponse.have_value)
              {
                result.setSearchAllAPIResponse(fieldGeneratorSearchAllAPIResponse.value);
                fieldGeneratorSearchAllAPIResponse.have_value = false;
              }
            if (fieldGeneratorMarketsAPIResponse.have_value)
              {
                result.setMarketsAPIResponse(fieldGeneratorMarketsAPIResponse.value);
                fieldGeneratorMarketsAPIResponse.have_value = false;
              }
            if (fieldGeneratorLoginOrCreateOAuthUserAPIResponse.have_value)
              {
                result.setLoginOrCreateOAuthUserAPIResponse(fieldGeneratorLoginOrCreateOAuthUserAPIResponse.value);
                fieldGeneratorLoginOrCreateOAuthUserAPIResponse.have_value = false;
              }
            if (fieldGeneratorForYouAPIResponse.have_value)
              {
                result.setForYouAPIResponse(fieldGeneratorForYouAPIResponse.value);
                fieldGeneratorForYouAPIResponse.have_value = false;
              }
          }
        protected abstract void handle_result(IHeartRadioAPIResponseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'C':
                    if ((String.Compare(field_name, 1, "reateCustomRadioStationAPIResponse", 0, 34, false) == 0) && (field_name.Length == 35))
                        return fieldGeneratorCreateCustomRadioStationAPIResponse;
                    break;
                case 'F':
                    if ((String.Compare(field_name, 1, "orYouAPIResponse", 0, 16, false) == 0) && (field_name.Length == 17))
                        return fieldGeneratorForYouAPIResponse;
                    break;
                case 'L':
                    switch (field_name[1])
                      {
                        case 'i':
                            if ((String.Compare(field_name, 2, "veStationsAPIResponse", 0, 21, false) == 0) && (field_name.Length == 23))
                                return fieldGeneratorLiveStationsAPIResponse;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "ginOrCreateOAuthUserAPIResponse", 0, 31, false) == 0) && (field_name.Length == 33))
                                return fieldGeneratorLoginOrCreateOAuthUserAPIResponse;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "arketsAPIResponse", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorMarketsAPIResponse;
                    break;
                case 'R':
                    if ((String.Compare(field_name, 1, "equestCustomRadioStationAPIResponse", 0, 35, false) == 0) && (field_name.Length == 36))
                        return fieldGeneratorRequestCustomRadioStationAPIResponse;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "earchAllAPIResponse", 0, 19, false) == 0) && (field_name.Length == 20))
                        return fieldGeneratorSearchAllAPIResponse;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorLiveStationsAPIResponse = new IHeartRadioLiveStationsAPIResponseStationsJSON.HoldingGenerator("field \"LiveStationsAPIResponse\" of the IHeartRadioAPIResponse class", ignore_extras);
            fieldGeneratorCreateCustomRadioStationAPIResponse = new IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON.HoldingGenerator("field \"CreateCustomRadioStationAPIResponse\" of the IHeartRadioAPIResponse class", ignore_extras);
            fieldGeneratorRequestCustomRadioStationAPIResponse = new IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON.HoldingGenerator("field \"RequestCustomRadioStationAPIResponse\" of the IHeartRadioAPIResponse class", ignore_extras);
            fieldGeneratorSearchAllAPIResponse = new IHeartRadioSearchAllAPIResponseJSON.HoldingGenerator("field \"SearchAllAPIResponse\" of the IHeartRadioAPIResponse class", ignore_extras);
            fieldGeneratorMarketsAPIResponse = new IHeartRadioMarketsAPIResponseJSON.HoldingGenerator("field \"MarketsAPIResponse\" of the IHeartRadioAPIResponse class", ignore_extras);
            fieldGeneratorLoginOrCreateOAuthUserAPIResponse = new IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON.HoldingGenerator("field \"LoginOrCreateOAuthUserAPIResponse\" of the IHeartRadioAPIResponse class", ignore_extras);
            fieldGeneratorForYouAPIResponse = new IHeartRadioForYouAPIResponseJSON.HoldingGenerator("field \"ForYouAPIResponse\" of the IHeartRadioAPIResponse class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioAPIResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorLiveStationsAPIResponse = new IHeartRadioLiveStationsAPIResponseStationsJSON.HoldingGenerator("field \"LiveStationsAPIResponse\" of the IHeartRadioAPIResponse class", false);
            fieldGeneratorCreateCustomRadioStationAPIResponse = new IHeartRadioArtistStationCreateCustomRadioStationAPIResponseJSON.HoldingGenerator("field \"CreateCustomRadioStationAPIResponse\" of the IHeartRadioAPIResponse class", false);
            fieldGeneratorRequestCustomRadioStationAPIResponse = new IHeartRadioArtistStationRequestCustomRadioStationAPIResponseJSON.HoldingGenerator("field \"RequestCustomRadioStationAPIResponse\" of the IHeartRadioAPIResponse class", false);
            fieldGeneratorSearchAllAPIResponse = new IHeartRadioSearchAllAPIResponseJSON.HoldingGenerator("field \"SearchAllAPIResponse\" of the IHeartRadioAPIResponse class", false);
            fieldGeneratorMarketsAPIResponse = new IHeartRadioMarketsAPIResponseJSON.HoldingGenerator("field \"MarketsAPIResponse\" of the IHeartRadioAPIResponse class", false);
            fieldGeneratorLoginOrCreateOAuthUserAPIResponse = new IHeartMediaLoginOrCreateOAuthUserAPIResponseJSON.HoldingGenerator("field \"LoginOrCreateOAuthUserAPIResponse\" of the IHeartRadioAPIResponse class", false);
            fieldGeneratorForYouAPIResponse = new IHeartRadioForYouAPIResponseJSON.HoldingGenerator("field \"ForYouAPIResponse\" of the IHeartRadioAPIResponse class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioAPIResponse class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorLiveStationsAPIResponse.reset();
            fieldGeneratorCreateCustomRadioStationAPIResponse.reset();
            fieldGeneratorRequestCustomRadioStationAPIResponse.reset();
            fieldGeneratorSearchAllAPIResponse.reset();
            fieldGeneratorMarketsAPIResponse.reset();
            fieldGeneratorLoginOrCreateOAuthUserAPIResponse.reset();
            fieldGeneratorForYouAPIResponse.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorLiveStationsAPIResponse.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorCreateCustomRadioStationAPIResponse.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorRequestCustomRadioStationAPIResponse.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorSearchAllAPIResponse.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMarketsAPIResponse.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLoginOrCreateOAuthUserAPIResponse.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorForYouAPIResponse.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorLiveStationsAPIResponse.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorCreateCustomRadioStationAPIResponse.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorRequestCustomRadioStationAPIResponse.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorSearchAllAPIResponse.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMarketsAPIResponse.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLoginOrCreateOAuthUserAPIResponse.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorForYouAPIResponse.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioAPIResponseJSON  result)
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
        public IHeartRadioAPIResponseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioAPIResponseJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioAPIResponseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioAPIResponseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioAPIResponseJSON>();
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
    public List<IHeartRadioAPIResponseJSON> value;
  };
  };
