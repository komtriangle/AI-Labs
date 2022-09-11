/* file "MusicArtistJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicArtistJSON : MusicArtistBaseJSON
  {
    private bool flagHasAlbumsLabel;
    private string storeAlbumsLabel;
    private bool flagHasAlbums;
    private List< MusicAlbumBaseJSON  > storeAlbums;
    private bool flagHasTracksLabel;
    private string storeTracksLabel;
    private bool flagHasTracks;
    private List< MusicTrackBaseJSON  > storeTracks;


    private void  fromJSONAlbumsLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AlbumsLabel of MusicArtistJSON is not a string.");
        setAlbumsLabel(json_string.getData());
      }


    private void  fromJSONAlbums(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Albums of MusicArtistJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Albums of MusicArtistJSON has too few elements.");
        List< MusicAlbumBaseJSON  > vector_Albums1 = new List< MusicAlbumBaseJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicAlbumBaseJSON convert_classy = MusicAlbumBaseJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Albums1.Add(convert_classy);
          }
        Debug.Assert(vector_Albums1.Count >= 1);
        initAlbums();
        for (int num1 = 0; num1 < vector_Albums1.Count; ++num1)
            appendAlbums(vector_Albums1[num1]);
        for (int num1 = 0; num1 < vector_Albums1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTracksLabel(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TracksLabel of MusicArtistJSON is not a string.");
        setTracksLabel(json_string.getData());
      }


    private void  fromJSONTracks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Tracks of MusicArtistJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Tracks of MusicArtistJSON has too few elements.");
        List< MusicTrackBaseJSON  > vector_Tracks1 = new List< MusicTrackBaseJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicTrackBaseJSON convert_classy = MusicTrackBaseJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Tracks1.Add(convert_classy);
          }
        Debug.Assert(vector_Tracks1.Count >= 1);
        initTracks();
        for (int num2 = 0; num2 < vector_Tracks1.Count; ++num2)
            appendTracks(vector_Tracks1[num2]);
        for (int num1 = 0; num1 < vector_Tracks1.Count; ++num1)
          {
          }
      }


    public MusicArtistJSON()
      {
        flagHasAlbumsLabel = false;
        flagHasAlbums = false;
        flagHasTracksLabel = false;
        flagHasTracks = false;
        storeAlbums = new List< MusicAlbumBaseJSON  >();
        storeTracks = new List< MusicTrackBaseJSON  >();
      }

    public bool  hasAlbumsLabel()
      {
        return flagHasAlbumsLabel;
      }

    public string  getAlbumsLabel()
      {
        Debug.Assert(flagHasAlbumsLabel);
        return storeAlbumsLabel;
      }

    public bool  hasAlbums()
      {
        return flagHasAlbums;
      }

    public int  countOfAlbums()
      {
        Debug.Assert(flagHasAlbums);
        return storeAlbums.Count;
      }

    public MusicAlbumBaseJSON   elementOfAlbums(int element_num)
      {
        Debug.Assert(flagHasAlbums);
        return storeAlbums[element_num];
      }

    public List< MusicAlbumBaseJSON  >  getAlbums()
      {
        Debug.Assert(flagHasAlbums);
        return storeAlbums;
      }

    public bool  hasTracksLabel()
      {
        return flagHasTracksLabel;
      }

    public string  getTracksLabel()
      {
        Debug.Assert(flagHasTracksLabel);
        return storeTracksLabel;
      }

    public bool  hasTracks()
      {
        return flagHasTracks;
      }

    public int  countOfTracks()
      {
        Debug.Assert(flagHasTracks);
        return storeTracks.Count;
      }

    public MusicTrackBaseJSON   elementOfTracks(int element_num)
      {
        Debug.Assert(flagHasTracks);
        return storeTracks[element_num];
      }

    public List< MusicTrackBaseJSON  >  getTracks()
      {
        Debug.Assert(flagHasTracks);
        return storeTracks;
      }



    public void setAlbumsLabel(string new_value)
      {
        flagHasAlbumsLabel = true;
        storeAlbumsLabel = new_value;
      }
    public void unsetAlbumsLabel()
      {
        flagHasAlbumsLabel = false;
      }
    public void initAlbums()
      {
        if (flagHasAlbums)
          {
            for (int num1 = 0; num1 < storeAlbums.Count; ++num1)
              {
              }
          }
        flagHasAlbums = true;
        storeAlbums.Clear();
      }
    public void appendAlbums(MusicAlbumBaseJSON  to_append)
      {
        if (!flagHasAlbums)
          {
            flagHasAlbums = true;
            storeAlbums.Clear();
          }
        Debug.Assert(flagHasAlbums);
        storeAlbums.Add(to_append);
      }
    public void unsetAlbums()
      {
        if (flagHasAlbums)
          {
            for (int num2 = 0; num2 < storeAlbums.Count; ++num2)
              {
              }
          }
        flagHasAlbums = false;
        storeAlbums.Clear();
      }
    public void setTracksLabel(string new_value)
      {
        flagHasTracksLabel = true;
        storeTracksLabel = new_value;
      }
    public void unsetTracksLabel()
      {
        flagHasTracksLabel = false;
      }
    public void initTracks()
      {
        if (flagHasTracks)
          {
            for (int num3 = 0; num3 < storeTracks.Count; ++num3)
              {
              }
          }
        flagHasTracks = true;
        storeTracks.Clear();
      }
    public void appendTracks(MusicTrackBaseJSON  to_append)
      {
        if (!flagHasTracks)
          {
            flagHasTracks = true;
            storeTracks.Clear();
          }
        Debug.Assert(flagHasTracks);
        storeTracks.Add(to_append);
      }
    public void unsetTracks()
      {
        if (flagHasTracks)
          {
            for (int num4 = 0; num4 < storeTracks.Count; ++num4)
              {
              }
          }
        flagHasTracks = false;
        storeTracks.Clear();
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
        if (flagHasAlbumsLabel)
          {
            handler.start_pair("AlbumsLabel");
            handler.string_value(storeAlbumsLabel);
          }
        if (flagHasAlbums)
          {
            handler.start_pair("Albums");
            Debug.Assert(storeAlbums.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeAlbums.Count; ++num1)
              {
                if (partial_allowed)
                    storeAlbums[num1].write_partial_as_json(handler);
                else
                    storeAlbums[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasTracksLabel)
          {
            handler.start_pair("TracksLabel");
            handler.string_value(storeTracksLabel);
          }
        if (flagHasTracks)
          {
            handler.start_pair("Tracks");
            Debug.Assert(storeTracks.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeTracks.Count; ++num2)
              {
                if (partial_allowed)
                    storeTracks[num2].write_partial_as_json(handler);
                else
                    storeTracks[num2].write_as_json(handler);
              }
            handler.finish_array();
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

    public static new MusicArtistJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicArtistJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicArtist", ignore_extras);
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
    public static new MusicArtistJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicArtistJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicArtistJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicArtist", ignore_extras);
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
    public static new MusicArtistJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicArtistJSON from_text(string text, bool ignore_extras)
      {
        MusicArtistJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicArtist", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicArtistJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicArtistJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicArtistJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicArtist", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MusicArtistBaseJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorAlbumsLabel;
        private MusicAlbumBaseJSON.HoldingArrayGenerator fieldGeneratorAlbums;
        private JSONHoldingStringGenerator fieldGeneratorTracksLabel;
        private MusicTrackBaseJSON.HoldingArrayGenerator fieldGeneratorTracks;

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
            MusicArtistJSON result = new MusicArtistJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(MusicArtistBaseJSON new_result)
          {
            handle_result((MusicArtistJSON )new_result);
          }
        protected void finish(MusicArtistJSON result)
          {
            if (fieldGeneratorAlbumsLabel.have_value)
              {
                result.setAlbumsLabel(fieldGeneratorAlbumsLabel.value);
                fieldGeneratorAlbumsLabel.have_value = false;
              }
            if (fieldGeneratorAlbums.have_value)
              {
                result.initAlbums();
                int count = fieldGeneratorAlbums.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlbums(fieldGeneratorAlbums.value[num]);
                  }
                fieldGeneratorAlbums.value.Clear();
                fieldGeneratorAlbums.have_value = false;
              }
            if (fieldGeneratorTracksLabel.have_value)
              {
                result.setTracksLabel(fieldGeneratorTracksLabel.value);
                fieldGeneratorTracksLabel.have_value = false;
              }
            if (fieldGeneratorTracks.have_value)
              {
                result.initTracks();
                int count = fieldGeneratorTracks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTracks(fieldGeneratorTracks.value[num]);
                  }
                fieldGeneratorTracks.value.Clear();
                fieldGeneratorTracks.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MusicArtistJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "lbums", 0, 5, false) == 0)
                      {
                        if (field_name.Length == 6)
                          {
                            return fieldGeneratorAlbums;
                          }
                        switch (field_name[6])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 7, "abel", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorAlbumsLabel;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'T':
                    if (String.Compare(field_name, 1, "racks", 0, 5, false) == 0)
                      {
                        if (field_name.Length == 6)
                          {
                            return fieldGeneratorTracks;
                          }
                        switch (field_name[6])
                          {
                            case 'L':
                                if ((String.Compare(field_name, 7, "abel", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorTracksLabel;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorAlbumsLabel = new JSONHoldingStringGenerator("field \"AlbumsLabel\" of the MusicArtist class");
            fieldGeneratorAlbums = new MusicAlbumBaseJSON.HoldingArrayGenerator("field \"Albums\" of the MusicArtist class", ignore_extras);
            fieldGeneratorTracksLabel = new JSONHoldingStringGenerator("field \"TracksLabel\" of the MusicArtist class");
            fieldGeneratorTracks = new MusicTrackBaseJSON.HoldingArrayGenerator("field \"Tracks\" of the MusicArtist class", ignore_extras);
            set_what("the MusicArtist class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorAlbumsLabel = new JSONHoldingStringGenerator("field \"AlbumsLabel\" of the MusicArtist class");
            fieldGeneratorAlbums = new MusicAlbumBaseJSON.HoldingArrayGenerator("field \"Albums\" of the MusicArtist class", false);
            fieldGeneratorTracksLabel = new JSONHoldingStringGenerator("field \"TracksLabel\" of the MusicArtist class");
            fieldGeneratorTracks = new MusicTrackBaseJSON.HoldingArrayGenerator("field \"Tracks\" of the MusicArtist class", false);
            set_what("the MusicArtist class");
          }

        public override void reset()
          {
            fieldGeneratorAlbumsLabel.reset();
            fieldGeneratorAlbums.reset();
            fieldGeneratorTracksLabel.reset();
            fieldGeneratorTracks.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicArtistJSON  result)
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
        public MusicArtistJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicArtistJSON  result)
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
    protected virtual void handle_result(List<MusicArtistJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicArtistJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicArtistJSON>();
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
    public List<MusicArtistJSON> value;
  };
    public static MusicArtistJSON from_MusicArtistBaseJSON_json(MusicArtistBaseJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        MusicArtistJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type MusicArtist", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
