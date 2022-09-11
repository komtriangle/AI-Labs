/* file "IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON : JSONBase
  {
    private bool flagHascontentType;
    private string storecontentType;
    private bool flagHascontent;
    private IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON  storecontent;
    private bool flagHasstreamUrl;
    private string storestreamUrl;
    private bool flagHasreportPayload;
    private string storereportPayload;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONcontentType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field contentType of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON is not a string.");
        setcontentType(json_string.getData());
      }


    private void  fromJSONcontent(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON convert_classy = IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON.from_json(json_value, ignore_extras, true);
        setcontent(convert_classy);
      }


    private void  fromJSONstreamUrl(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field streamUrl of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON is not a string.");
        setstreamUrl(json_string.getData());
      }


    private void  fromJSONreportPayload(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field reportPayload of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON is not a string.");
        setreportPayload(json_string.getData());
      }


    public IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON()
      {
        flagHascontentType = false;
        flagHascontent = false;
        flagHasstreamUrl = false;
        flagHasreportPayload = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hascontentType()
      {
        return flagHascontentType;
      }

    public string  getcontentType()
      {
        Debug.Assert(flagHascontentType);
        return storecontentType;
      }

    public bool  hascontent()
      {
        return flagHascontent;
      }

    public IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON   getcontent()
      {
        Debug.Assert(flagHascontent);
        return storecontent;
      }

    public bool  hasstreamUrl()
      {
        return flagHasstreamUrl;
      }

    public string  getstreamUrl()
      {
        Debug.Assert(flagHasstreamUrl);
        return storestreamUrl;
      }

    public bool  hasreportPayload()
      {
        return flagHasreportPayload;
      }

    public string  getreportPayload()
      {
        Debug.Assert(flagHasreportPayload);
        return storereportPayload;
      }


    public virtual int extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setcontentType(string new_value)
      {
        flagHascontentType = true;
        storecontentType = new_value;
      }
    public void unsetcontentType()
      {
        flagHascontentType = false;
      }
    public void setcontent(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON  new_value)
      {
        if (flagHascontent)
          {
          }
        flagHascontent = true;
        storecontent = new_value;
      }
    public void unsetcontent()
      {
        if (flagHascontent)
          {
          }
        flagHascontent = false;
      }
    public void setstreamUrl(string new_value)
      {
        flagHasstreamUrl = true;
        storestreamUrl = new_value;
      }
    public void unsetstreamUrl()
      {
        flagHasstreamUrl = false;
      }
    public void setreportPayload(string new_value)
      {
        flagHasreportPayload = true;
        storereportPayload = new_value;
      }
    public void unsetreportPayload()
      {
        flagHasreportPayload = false;
      }

    public virtual void extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemAppendPair(key, new_component);
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
        if (flagHascontentType)
          {
            handler.start_pair("contentType");
            handler.string_value(storecontentType);
          }
        Debug.Assert(partial_allowed || flagHascontent);
        if (flagHascontent)
          {
            handler.start_pair("content");
            if (partial_allowed)
                storecontent.write_partial_as_json(handler);
            else
                storecontent.write_as_json(handler);
          }
        Debug.Assert(partial_allowed || flagHasstreamUrl);
        if (flagHasstreamUrl)
          {
            handler.start_pair("streamUrl");
            handler.string_value(storestreamUrl);
          }
        Debug.Assert(partial_allowed || flagHasreportPayload);
        if (flagHasreportPayload)
          {
            handler.start_pair("reportPayload");
            handler.string_value(storereportPayload);
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
        if (!(hascontent()))
          {
            return "When parsing the object for %what%, the \"content\" field was missing.";
          }
        if (!(hasstreamUrl()))
          {
            return "When parsing the object for %what%, the \"streamUrl\" field was missing.";
          }
        if (!(hasreportPayload()))
          {
            return "When parsing the object for %what%, the \"reportPayload\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem", ignore_extras);
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
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem", ignore_extras);
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
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorcontentType;
        private IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON.HoldingGenerator fieldGeneratorcontent;
        private JSONHoldingStringGenerator fieldGeneratorstreamUrl;
        private JSONHoldingStringGenerator fieldGeneratorreportPayload;
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
            IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON result = new IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON result)
          {
            if (fieldGeneratorcontentType.have_value)
              {
                result.setcontentType(fieldGeneratorcontentType.value);
                fieldGeneratorcontentType.have_value = false;
              }
            if (fieldGeneratorcontent.have_value)
              {
                result.setcontent(fieldGeneratorcontent.value);
                fieldGeneratorcontent.have_value = false;
              }
            else if ((!(result.hascontent())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"content\" field was missing.");
              }
            if (fieldGeneratorstreamUrl.have_value)
              {
                result.setstreamUrl(fieldGeneratorstreamUrl.value);
                fieldGeneratorstreamUrl.have_value = false;
              }
            else if ((!(result.hasstreamUrl())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"streamUrl\" field was missing.");
              }
            if (fieldGeneratorreportPayload.have_value)
              {
                result.setreportPayload(fieldGeneratorreportPayload.value);
                fieldGeneratorreportPayload.have_value = false;
              }
            else if ((!(result.hasreportPayload())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"reportPayload\" field was missing.");
              }
          }
        protected abstract void handle_result(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'c':
                    if (String.Compare(field_name, 1, "ontent", 0, 6, false) == 0)
                      {
                        if (field_name.Length == 7)
                          {
                            return fieldGeneratorcontent;
                          }
                        switch (field_name[7])
                          {
                            case 'T':
                                if ((String.Compare(field_name, 8, "ype", 0, 3, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorcontentType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'r':
                    if ((String.Compare(field_name, 1, "eportPayload", 0, 12, false) == 0) && (field_name.Length == 13))
                        return fieldGeneratorreportPayload;
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "treamUrl", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorstreamUrl;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorcontentType = new JSONHoldingStringGenerator("field \"contentType\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem class");
            fieldGeneratorcontent = new IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON.HoldingGenerator("field \"content\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem class", ignore_extras);
            fieldGeneratorstreamUrl = new JSONHoldingStringGenerator("field \"streamUrl\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem class");
            fieldGeneratorreportPayload = new JSONHoldingStringGenerator("field \"reportPayload\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorcontentType = new JSONHoldingStringGenerator("field \"contentType\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem class");
            fieldGeneratorcontent = new IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON.HoldingGenerator("field \"content\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem class", false);
            fieldGeneratorstreamUrl = new JSONHoldingStringGenerator("field \"streamUrl\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem class");
            fieldGeneratorreportPayload = new JSONHoldingStringGenerator("field \"reportPayload\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItem class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorcontentType.reset();
            fieldGeneratorcontent.reset();
            fieldGeneratorstreamUrl.reset();
            fieldGeneratorreportPayload.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorcontent.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorcontent.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON  result)
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
        public IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON>();
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
    public List<IHeartRadioArtistStationRequestCustomRadioStationAPIResponseItemJSON> value;
  };
  };
