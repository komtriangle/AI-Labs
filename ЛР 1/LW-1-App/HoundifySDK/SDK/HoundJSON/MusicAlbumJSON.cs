/* file "MusicAlbumJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicAlbumJSON : MusicAlbumBaseJSON
  {
    private bool flagHasArtists;
    private List< MusicArtistBaseJSON  > storeArtists;
    private bool flagHasTracks;
    private List< MusicTrackBaseJSON  > storeTracks;


    private void  fromJSONArtists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Artists of MusicAlbumJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Artists of MusicAlbumJSON has too few elements.");
        List< MusicArtistBaseJSON  > vector_Artists1 = new List< MusicArtistBaseJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicArtistBaseJSON convert_classy = MusicArtistBaseJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Artists1.Add(convert_classy);
          }
        Debug.Assert(vector_Artists1.Count >= 1);
        initArtists();
        for (int num1 = 0; num1 < vector_Artists1.Count; ++num1)
            appendArtists(vector_Artists1[num1]);
        for (int num1 = 0; num1 < vector_Artists1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTracks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Tracks of MusicAlbumJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Tracks of MusicAlbumJSON has too few elements.");
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


    public MusicAlbumJSON()
      {
        flagHasArtists = false;
        flagHasTracks = false;
        storeArtists = new List< MusicArtistBaseJSON  >();
        storeTracks = new List< MusicTrackBaseJSON  >();
      }

    public bool  hasArtists()
      {
        return flagHasArtists;
      }

    public int  countOfArtists()
      {
        Debug.Assert(flagHasArtists);
        return storeArtists.Count;
      }

    public MusicArtistBaseJSON   elementOfArtists(int element_num)
      {
        Debug.Assert(flagHasArtists);
        return storeArtists[element_num];
      }

    public List< MusicArtistBaseJSON  >  getArtists()
      {
        Debug.Assert(flagHasArtists);
        return storeArtists;
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



    public void initArtists()
      {
        if (flagHasArtists)
          {
            for (int num1 = 0; num1 < storeArtists.Count; ++num1)
              {
              }
          }
        flagHasArtists = true;
        storeArtists.Clear();
      }
    public void appendArtists(MusicArtistBaseJSON  to_append)
      {
        if (!flagHasArtists)
          {
            flagHasArtists = true;
            storeArtists.Clear();
          }
        Debug.Assert(flagHasArtists);
        storeArtists.Add(to_append);
      }
    public void unsetArtists()
      {
        if (flagHasArtists)
          {
            for (int num2 = 0; num2 < storeArtists.Count; ++num2)
              {
              }
          }
        flagHasArtists = false;
        storeArtists.Clear();
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
        if (flagHasArtists)
          {
            handler.start_pair("Artists");
            Debug.Assert(storeArtists.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeArtists.Count; ++num1)
              {
                if (partial_allowed)
                    storeArtists[num1].write_partial_as_json(handler);
                else
                    storeArtists[num1].write_as_json(handler);
              }
            handler.finish_array();
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

    public static new MusicAlbumJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicAlbumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicAlbum", ignore_extras);
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
    public static new MusicAlbumJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicAlbumJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicAlbumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicAlbum", ignore_extras);
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
    public static new MusicAlbumJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicAlbumJSON from_text(string text, bool ignore_extras)
      {
        MusicAlbumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicAlbum", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicAlbumJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicAlbumJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicAlbumJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicAlbum", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : MusicAlbumBaseJSON.Generator
      {
        private MusicArtistBaseJSON.HoldingArrayGenerator fieldGeneratorArtists;
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
            MusicAlbumJSON result = new MusicAlbumJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected override void handle_result(MusicAlbumBaseJSON new_result)
          {
            handle_result((MusicAlbumJSON )new_result);
          }
        protected void finish(MusicAlbumJSON result)
          {
            if (fieldGeneratorArtists.have_value)
              {
                result.initArtists();
                int count = fieldGeneratorArtists.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendArtists(fieldGeneratorArtists.value[num]);
                  }
                fieldGeneratorArtists.value.Clear();
                fieldGeneratorArtists.have_value = false;
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
        protected abstract void handle_result(MusicAlbumJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if ((String.Compare(field_name, 1, "rtists", 0, 6, false) == 0) && (field_name.Length == 7))
                        return fieldGeneratorArtists;
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "racks", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorTracks;
                    break;
                default:
                    break;
              }
            return base.start_known_field(field_name);
          }
        public Generator(bool ignore_extras) : base(ignore_extras)
          {
            fieldGeneratorArtists = new MusicArtistBaseJSON.HoldingArrayGenerator("field \"Artists\" of the MusicAlbum class", ignore_extras);
            fieldGeneratorTracks = new MusicTrackBaseJSON.HoldingArrayGenerator("field \"Tracks\" of the MusicAlbum class", ignore_extras);
            set_what("the MusicAlbum class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorArtists = new MusicArtistBaseJSON.HoldingArrayGenerator("field \"Artists\" of the MusicAlbum class", false);
            fieldGeneratorTracks = new MusicTrackBaseJSON.HoldingArrayGenerator("field \"Tracks\" of the MusicAlbum class", false);
            set_what("the MusicAlbum class");
          }

        public override void reset()
          {
            fieldGeneratorArtists.reset();
            fieldGeneratorTracks.reset();
            base.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicAlbumJSON  result)
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
        public MusicAlbumJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicAlbumJSON  result)
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
    protected virtual void handle_result(List<MusicAlbumJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicAlbumJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicAlbumJSON>();
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
    public List<MusicAlbumJSON> value;
  };
    public static MusicAlbumJSON from_MusicAlbumBaseJSON_json(MusicAlbumBaseJSON  ancestor, bool ignore_extras)
      {
        Debug.Assert(ancestor != null);
        MusicAlbumJSON  result;
          {
            HoldingGenerator handler = new HoldingGenerator("Type MusicAlbum", ignore_extras);
            ancestor.write_as_json(handler);
            result = handler.value;
          }
        return result;
      }
  };
