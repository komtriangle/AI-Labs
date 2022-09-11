/* file "IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON : JSONBase
  {
    private bool flagHasid;
    private BigInteger storeid;
    private bool flagHastitle;
    private string storetitle;
    private bool flagHasduration;
    private BigInteger storeduration;
    private bool flagHasartistId;
    private BigInteger storeartistId;
    private bool flagHasartistName;
    private string storeartistName;
    private bool flagHasalbumId;
    private BigInteger storealbumId;
    private bool flagHasalbumName;
    private string storealbumName;
    private bool flagHasimagePath;
    private string storeimagePath;
    private bool flagHaslyricsId;
    private BigInteger storelyricsId;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONid(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field id of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field id of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setid(extracted_integer);
      }


    private void  fromJSONtitle(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field title of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not a string.");
        settitle(json_string.getData());
      }


    private void  fromJSONduration(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field duration of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field duration of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setduration(extracted_integer);
      }


    private void  fromJSONartistId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field artistId of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field artistId of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setartistId(extracted_integer);
      }


    private void  fromJSONartistName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field artistName of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not a string.");
        setartistName(json_string.getData());
      }


    private void  fromJSONalbumId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field albumId of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field albumId of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setalbumId(extracted_integer);
      }


    private void  fromJSONalbumName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field albumName of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not a string.");
        setalbumName(json_string.getData());
      }


    private void  fromJSONimagePath(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field imagePath of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not a string.");
        setimagePath(json_string.getData());
      }


    private void  fromJSONlyricsId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field lyricsId of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field lyricsId of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setlyricsId(extracted_integer);
      }


    public IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON()
      {
        flagHasid = false;
        flagHastitle = false;
        flagHasduration = false;
        flagHasartistId = false;
        flagHasartistName = false;
        flagHasalbumId = false;
        flagHasalbumName = false;
        flagHasimagePath = false;
        flagHaslyricsId = false;
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasid()
      {
        return flagHasid;
      }

    public BigInteger  getid()
      {
        Debug.Assert(flagHasid);
        return storeid;
      }

    public bool  hastitle()
      {
        return flagHastitle;
      }

    public string  gettitle()
      {
        Debug.Assert(flagHastitle);
        return storetitle;
      }

    public bool  hasduration()
      {
        return flagHasduration;
      }

    public BigInteger  getduration()
      {
        Debug.Assert(flagHasduration);
        return storeduration;
      }

    public bool  hasartistId()
      {
        return flagHasartistId;
      }

    public BigInteger  getartistId()
      {
        Debug.Assert(flagHasartistId);
        return storeartistId;
      }

    public bool  hasartistName()
      {
        return flagHasartistName;
      }

    public string  getartistName()
      {
        Debug.Assert(flagHasartistName);
        return storeartistName;
      }

    public bool  hasalbumId()
      {
        return flagHasalbumId;
      }

    public BigInteger  getalbumId()
      {
        Debug.Assert(flagHasalbumId);
        return storealbumId;
      }

    public bool  hasalbumName()
      {
        return flagHasalbumName;
      }

    public string  getalbumName()
      {
        Debug.Assert(flagHasalbumName);
        return storealbumName;
      }

    public bool  hasimagePath()
      {
        return flagHasimagePath;
      }

    public string  getimagePath()
      {
        Debug.Assert(flagHasimagePath);
        return storeimagePath;
      }

    public bool  haslyricsId()
      {
        return flagHaslyricsId;
      }

    public BigInteger  getlyricsId()
      {
        Debug.Assert(flagHaslyricsId);
        return storelyricsId;
      }


    public virtual int extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setid(BigInteger new_value)
      {
        flagHasid = true;
        if (new_value < 0)
            throw new Exception("The value for field id of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is less than the lower bound (0) for that field.");
        storeid = new_value;
      }
    public void unsetid()
      {
        flagHasid = false;
      }
    public void settitle(string new_value)
      {
        flagHastitle = true;
        storetitle = new_value;
      }
    public void unsettitle()
      {
        flagHastitle = false;
      }
    public void setduration(BigInteger new_value)
      {
        flagHasduration = true;
        if (new_value < 0)
            throw new Exception("The value for field duration of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is less than the lower bound (0) for that field.");
        storeduration = new_value;
      }
    public void unsetduration()
      {
        flagHasduration = false;
      }
    public void setartistId(BigInteger new_value)
      {
        flagHasartistId = true;
        if (new_value < 0)
            throw new Exception("The value for field artistId of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is less than the lower bound (0) for that field.");
        storeartistId = new_value;
      }
    public void unsetartistId()
      {
        flagHasartistId = false;
      }
    public void setartistName(string new_value)
      {
        flagHasartistName = true;
        storeartistName = new_value;
      }
    public void unsetartistName()
      {
        flagHasartistName = false;
      }
    public void setalbumId(BigInteger new_value)
      {
        flagHasalbumId = true;
        if (new_value < 0)
            throw new Exception("The value for field albumId of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is less than the lower bound (0) for that field.");
        storealbumId = new_value;
      }
    public void unsetalbumId()
      {
        flagHasalbumId = false;
      }
    public void setalbumName(string new_value)
      {
        flagHasalbumName = true;
        storealbumName = new_value;
      }
    public void unsetalbumName()
      {
        flagHasalbumName = false;
      }
    public void setimagePath(string new_value)
      {
        flagHasimagePath = true;
        storeimagePath = new_value;
      }
    public void unsetimagePath()
      {
        flagHasimagePath = false;
      }
    public void setlyricsId(BigInteger new_value)
      {
        flagHaslyricsId = true;
        if (new_value < 0)
            throw new Exception("The value for field lyricsId of IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON is less than the lower bound (0) for that field.");
        storelyricsId = new_value;
      }
    public void unsetlyricsId()
      {
        flagHaslyricsId = false;
      }

    public virtual void extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasid);
        if (flagHasid)
          {
            handler.start_pair("id");
            handler.number_value(storeid);
          }
        if (flagHastitle)
          {
            handler.start_pair("title");
            handler.string_value(storetitle);
          }
        if (flagHasduration)
          {
            handler.start_pair("duration");
            handler.number_value(storeduration);
          }
        if (flagHasartistId)
          {
            handler.start_pair("artistId");
            handler.number_value(storeartistId);
          }
        if (flagHasartistName)
          {
            handler.start_pair("artistName");
            handler.string_value(storeartistName);
          }
        if (flagHasalbumId)
          {
            handler.start_pair("albumId");
            handler.number_value(storealbumId);
          }
        if (flagHasalbumName)
          {
            handler.start_pair("albumName");
            handler.string_value(storealbumName);
          }
        if (flagHasimagePath)
          {
            handler.start_pair("imagePath");
            handler.string_value(storeimagePath);
          }
        if (flagHaslyricsId)
          {
            handler.start_pair("lyricsId");
            handler.number_value(storelyricsId);
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
        if (!(hasid()))
          {
            return "When parsing the object for %what%, the \"id\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent", ignore_extras);
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
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent", ignore_extras);
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
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
    private class FieldHoldingGeneratorid : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorid(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorid : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorid(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorid fieldGeneratorid;
        private JSONHoldingStringGenerator fieldGeneratortitle;
    private class FieldHoldingGeneratorduration : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorduration(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorduration : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorduration(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorduration fieldGeneratorduration;
    private class FieldHoldingGeneratorartistId : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorartistId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorartistId : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorartistId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorartistId fieldGeneratorartistId;
        private JSONHoldingStringGenerator fieldGeneratorartistName;
    private class FieldHoldingGeneratoralbumId : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratoralbumId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratoralbumId : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratoralbumId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratoralbumId fieldGeneratoralbumId;
        private JSONHoldingStringGenerator fieldGeneratoralbumName;
        private JSONHoldingStringGenerator fieldGeneratorimagePath;
    private class FieldHoldingGeneratorlyricsId : JSONHoldingIntegerLowerBoundOnlyGenerator
          {
            public FieldHoldingGeneratorlyricsId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
    private class FieldHoldingArrayGeneratorlyricsId : JSONHoldingIntegerLowerBoundOnlyArrayGenerator
          {
            public FieldHoldingArrayGeneratorlyricsId(String what) : base(what, (BigInteger)(0))
              {
              }
          };
        private FieldHoldingGeneratorlyricsId fieldGeneratorlyricsId;
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
            IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON result = new IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON result)
          {
            if (fieldGeneratorid.have_value)
              {
                result.setid(fieldGeneratorid.value);
                fieldGeneratorid.have_value = false;
              }
            else if ((!(result.hasid())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"id\" field was missing.");
              }
            if (fieldGeneratortitle.have_value)
              {
                result.settitle(fieldGeneratortitle.value);
                fieldGeneratortitle.have_value = false;
              }
            if (fieldGeneratorduration.have_value)
              {
                result.setduration(fieldGeneratorduration.value);
                fieldGeneratorduration.have_value = false;
              }
            if (fieldGeneratorartistId.have_value)
              {
                result.setartistId(fieldGeneratorartistId.value);
                fieldGeneratorartistId.have_value = false;
              }
            if (fieldGeneratorartistName.have_value)
              {
                result.setartistName(fieldGeneratorartistName.value);
                fieldGeneratorartistName.have_value = false;
              }
            if (fieldGeneratoralbumId.have_value)
              {
                result.setalbumId(fieldGeneratoralbumId.value);
                fieldGeneratoralbumId.have_value = false;
              }
            if (fieldGeneratoralbumName.have_value)
              {
                result.setalbumName(fieldGeneratoralbumName.value);
                fieldGeneratoralbumName.have_value = false;
              }
            if (fieldGeneratorimagePath.have_value)
              {
                result.setimagePath(fieldGeneratorimagePath.value);
                fieldGeneratorimagePath.have_value = false;
              }
            if (fieldGeneratorlyricsId.have_value)
              {
                result.setlyricsId(fieldGeneratorlyricsId.value);
                fieldGeneratorlyricsId.have_value = false;
              }
          }
        protected abstract void handle_result(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    switch (field_name[1])
                      {
                        case 'l':
                            if (String.Compare(field_name, 2, "bum", 0, 3, false) == 0)
                              {
                                switch (field_name[5])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 6, "d", 0, 1, false) == 0) && (field_name.Length == 7))
                                            return fieldGeneratoralbumId;
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 6, "ame", 0, 3, false) == 0) && (field_name.Length == 9))
                                            return fieldGeneratoralbumName;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "tist", 0, 4, false) == 0)
                              {
                                switch (field_name[6])
                                  {
                                    case 'I':
                                        if ((String.Compare(field_name, 7, "d", 0, 1, false) == 0) && (field_name.Length == 8))
                                            return fieldGeneratorartistId;
                                        break;
                                    case 'N':
                                        if ((String.Compare(field_name, 7, "ame", 0, 3, false) == 0) && (field_name.Length == 10))
                                            return fieldGeneratorartistName;
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
                case 'd':
                    if ((String.Compare(field_name, 1, "uration", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorduration;
                    break;
                case 'i':
                    switch (field_name[1])
                      {
                        case 'd':
                            if (field_name.Length == 2)
                                return fieldGeneratorid;
                            break;
                        case 'm':
                            if ((String.Compare(field_name, 2, "agePath", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorimagePath;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'l':
                    if ((String.Compare(field_name, 1, "yricsId", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorlyricsId;
                    break;
                case 't':
                    if ((String.Compare(field_name, 1, "itle", 0, 4, false) == 0) && (field_name.Length == 5))
                        return fieldGeneratortitle;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorid = new FieldHoldingGeneratorid("field \"id\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratortitle = new JSONHoldingStringGenerator("field \"title\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratorduration = new FieldHoldingGeneratorduration("field \"duration\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratorartistId = new FieldHoldingGeneratorartistId("field \"artistId\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratorartistName = new JSONHoldingStringGenerator("field \"artistName\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratoralbumId = new FieldHoldingGeneratoralbumId("field \"albumId\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratoralbumName = new JSONHoldingStringGenerator("field \"albumName\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratorimagePath = new JSONHoldingStringGenerator("field \"imagePath\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratorlyricsId = new FieldHoldingGeneratorlyricsId("field \"lyricsId\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorid = new FieldHoldingGeneratorid("field \"id\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratortitle = new JSONHoldingStringGenerator("field \"title\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratorduration = new FieldHoldingGeneratorduration("field \"duration\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratorartistId = new FieldHoldingGeneratorartistId("field \"artistId\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratorartistName = new JSONHoldingStringGenerator("field \"artistName\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratoralbumId = new FieldHoldingGeneratoralbumId("field \"albumId\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratoralbumName = new JSONHoldingStringGenerator("field \"albumName\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratorimagePath = new JSONHoldingStringGenerator("field \"imagePath\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            fieldGeneratorlyricsId = new FieldHoldingGeneratorlyricsId("field \"lyricsId\" of the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContent class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorid.reset();
            fieldGeneratortitle.reset();
            fieldGeneratorduration.reset();
            fieldGeneratorartistId.reset();
            fieldGeneratorartistName.reset();
            fieldGeneratoralbumId.reset();
            fieldGeneratoralbumName.reset();
            fieldGeneratorimagePath.reset();
            fieldGeneratorlyricsId.reset();
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
        protected override void handle_result(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON  result)
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
        public IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON>();
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
    public List<IHeartRadioArtistStationRequestCustomRadioStationAPIResponseContentJSON> value;
  };
  };
