/* file "MusicTrackResultJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicTrackResultJSON : JSONBase
  {
    private bool flagHasTrackName;
    private string storeTrackName;
    private bool flagHasArtistName;
    private string storeArtistName;
    private bool flagHasAlbumName;
    private string storeAlbumName;
    private bool flagHasSoundHoundId;
    private SoundHoundTrackIDJSON  storeSoundHoundId;


    private void  fromJSONTrackName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TrackName of MusicTrackResultJSON is not a string.");
        setTrackName(json_string.getData());
      }


    private void  fromJSONArtistName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ArtistName of MusicTrackResultJSON is not a string.");
        setArtistName(json_string.getData());
      }


    private void  fromJSONAlbumName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AlbumName of MusicTrackResultJSON is not a string.");
        setAlbumName(json_string.getData());
      }


    private void  fromJSONSoundHoundId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SoundHoundTrackIDJSON convert_classy = SoundHoundTrackIDJSON.from_json(json_value, ignore_extras, true);
        setSoundHoundId(convert_classy);
      }


    public MusicTrackResultJSON()
      {
        flagHasTrackName = false;
        flagHasArtistName = false;
        flagHasAlbumName = false;
        flagHasSoundHoundId = false;
      }

    public bool  hasTrackName()
      {
        return flagHasTrackName;
      }

    public string  getTrackName()
      {
        Debug.Assert(flagHasTrackName);
        return storeTrackName;
      }

    public bool  hasArtistName()
      {
        return flagHasArtistName;
      }

    public string  getArtistName()
      {
        Debug.Assert(flagHasArtistName);
        return storeArtistName;
      }

    public bool  hasAlbumName()
      {
        return flagHasAlbumName;
      }

    public string  getAlbumName()
      {
        Debug.Assert(flagHasAlbumName);
        return storeAlbumName;
      }

    public bool  hasSoundHoundId()
      {
        return flagHasSoundHoundId;
      }

    public SoundHoundTrackIDJSON   getSoundHoundId()
      {
        Debug.Assert(flagHasSoundHoundId);
        return storeSoundHoundId;
      }

    public long  getSoundHoundIdValue()
      {
        return getSoundHoundId().getValue();
      }



    public void setTrackName(string new_value)
      {
        flagHasTrackName = true;
        storeTrackName = new_value;
      }
    public void unsetTrackName()
      {
        flagHasTrackName = false;
      }
    public void setArtistName(string new_value)
      {
        flagHasArtistName = true;
        storeArtistName = new_value;
      }
    public void unsetArtistName()
      {
        flagHasArtistName = false;
      }
    public void setAlbumName(string new_value)
      {
        flagHasAlbumName = true;
        storeAlbumName = new_value;
      }
    public void unsetAlbumName()
      {
        flagHasAlbumName = false;
      }
    public void setSoundHoundId(SoundHoundTrackIDJSON  new_value)
      {
        if (flagHasSoundHoundId)
          {
          }
        flagHasSoundHoundId = true;
        storeSoundHoundId = new_value;
      }
    public void setSoundHoundId(long new_value)
      {
        setSoundHoundId(new SoundHoundTrackIDJSON(new_value));
      }
    public void unsetSoundHoundId()
      {
        if (flagHasSoundHoundId)
          {
          }
        flagHasSoundHoundId = false;
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
        Debug.Assert(partial_allowed || flagHasTrackName);
        if (flagHasTrackName)
          {
            handler.start_pair("TrackName");
            handler.string_value(storeTrackName);
          }
        Debug.Assert(partial_allowed || flagHasArtistName);
        if (flagHasArtistName)
          {
            handler.start_pair("ArtistName");
            handler.string_value(storeArtistName);
          }
        if (flagHasAlbumName)
          {
            handler.start_pair("AlbumName");
            handler.string_value(storeAlbumName);
          }
        Debug.Assert(partial_allowed || flagHasSoundHoundId);
        if (flagHasSoundHoundId)
          {
            handler.start_pair("SoundHoundId");
            if (partial_allowed)
                storeSoundHoundId.write_partial_as_json(handler);
            else
                storeSoundHoundId.write_as_json(handler);
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
        if (!(hasTrackName()))
          {
            return "When parsing the object for %what%, the \"TrackName\" field was missing.";
          }
        if (!(hasArtistName()))
          {
            return "When parsing the object for %what%, the \"ArtistName\" field was missing.";
          }
        if (!(hasSoundHoundId()))
          {
            return "When parsing the object for %what%, the \"SoundHoundId\" field was missing.";
          }
        return null;
      }

    public static MusicTrackResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTrackResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTrackResult", ignore_extras);
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
    public static MusicTrackResultJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicTrackResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicTrackResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTrackResult", ignore_extras);
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
    public static MusicTrackResultJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicTrackResultJSON from_text(string text, bool ignore_extras)
      {
        MusicTrackResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTrackResult", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicTrackResultJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicTrackResultJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicTrackResultJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicTrackResult", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorTrackName;
        private JSONHoldingStringGenerator fieldGeneratorArtistName;
        private JSONHoldingStringGenerator fieldGeneratorAlbumName;
        private SoundHoundTrackIDJSON.HoldingGenerator fieldGeneratorSoundHoundId;

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
            MusicTrackResultJSON result = new MusicTrackResultJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicTrackResultJSON result)
          {
            if (fieldGeneratorTrackName.have_value)
              {
                result.setTrackName(fieldGeneratorTrackName.value);
                fieldGeneratorTrackName.have_value = false;
              }
            else if ((!(result.hasTrackName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"TrackName\" field was missing.");
              }
            if (fieldGeneratorArtistName.have_value)
              {
                result.setArtistName(fieldGeneratorArtistName.value);
                fieldGeneratorArtistName.have_value = false;
              }
            else if ((!(result.hasArtistName())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"ArtistName\" field was missing.");
              }
            if (fieldGeneratorAlbumName.have_value)
              {
                result.setAlbumName(fieldGeneratorAlbumName.value);
                fieldGeneratorAlbumName.have_value = false;
              }
            if (fieldGeneratorSoundHoundId.have_value)
              {
                result.setSoundHoundId(fieldGeneratorSoundHoundId.value);
                fieldGeneratorSoundHoundId.have_value = false;
              }
            else if ((!(result.hasSoundHoundId())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"SoundHoundId\" field was missing.");
              }
          }
        protected abstract void handle_result(MusicTrackResultJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "bumName", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorAlbumName;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "tistName", 0, 8, false) == 0) && (field_name.Length == 10))
                                return fieldGeneratorArtistName;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "oundHoundId", 0, 11, false) == 0) && (field_name.Length == 12))
                        return fieldGeneratorSoundHoundId;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "rackName", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorTrackName;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTrackName = new JSONHoldingStringGenerator("field \"TrackName\" of the MusicTrackResult class");
            fieldGeneratorArtistName = new JSONHoldingStringGenerator("field \"ArtistName\" of the MusicTrackResult class");
            fieldGeneratorAlbumName = new JSONHoldingStringGenerator("field \"AlbumName\" of the MusicTrackResult class");
            fieldGeneratorSoundHoundId = new SoundHoundTrackIDJSON.HoldingGenerator("field \"SoundHoundId\" of the MusicTrackResult class", ignore_extras);
            set_what("the MusicTrackResult class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTrackName = new JSONHoldingStringGenerator("field \"TrackName\" of the MusicTrackResult class");
            fieldGeneratorArtistName = new JSONHoldingStringGenerator("field \"ArtistName\" of the MusicTrackResult class");
            fieldGeneratorAlbumName = new JSONHoldingStringGenerator("field \"AlbumName\" of the MusicTrackResult class");
            fieldGeneratorSoundHoundId = new SoundHoundTrackIDJSON.HoldingGenerator("field \"SoundHoundId\" of the MusicTrackResult class", false);
            set_what("the MusicTrackResult class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTrackName.reset();
            fieldGeneratorArtistName.reset();
            fieldGeneratorAlbumName.reset();
            fieldGeneratorSoundHoundId.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorSoundHoundId.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorSoundHoundId.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicTrackResultJSON  result)
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
        public MusicTrackResultJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicTrackResultJSON  result)
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
    protected virtual void handle_result(List<MusicTrackResultJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicTrackResultJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicTrackResultJSON>();
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
    public List<MusicTrackResultJSON> value;
  };
  };
