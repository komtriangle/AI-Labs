/* file "RapidIngestionDataPandoraCustomRequestInfoFieldJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class RapidIngestionDataPandoraCustomRequestInfoFieldJSON : JSONBase
  {
    private bool flagHasTracks;
    private List< TrackPandoraEntityJSON  > storeTracks;
    private bool flagHasAlbums;
    private List< AlbumPandoraEntityJSON  > storeAlbums;
    private bool flagHasArtists;
    private List< ArtistPandoraEntityJSON  > storeArtists;
    private bool flagHasPlaylists;
    private List< PlaylistPandoraEntityJSON  > storePlaylists;
    private bool flagHasPodcasts;
    private List< PodcastPandoraEntityJSON  > storePodcasts;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONTracks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Tracks of RapidIngestionDataPandoraCustomRequestInfoFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< TrackPandoraEntityJSON  > vector_Tracks1 = new List< TrackPandoraEntityJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            TrackPandoraEntityJSON convert_classy = TrackPandoraEntityJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Tracks1.Add(convert_classy);
          }
        initTracks();
        for (int num1 = 0; num1 < vector_Tracks1.Count; ++num1)
            appendTracks(vector_Tracks1[num1]);
        for (int num1 = 0; num1 < vector_Tracks1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAlbums(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Albums of RapidIngestionDataPandoraCustomRequestInfoFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< AlbumPandoraEntityJSON  > vector_Albums1 = new List< AlbumPandoraEntityJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            AlbumPandoraEntityJSON convert_classy = AlbumPandoraEntityJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Albums1.Add(convert_classy);
          }
        initAlbums();
        for (int num2 = 0; num2 < vector_Albums1.Count; ++num2)
            appendAlbums(vector_Albums1[num2]);
        for (int num1 = 0; num1 < vector_Albums1.Count; ++num1)
          {
          }
      }


    private void  fromJSONArtists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Artists of RapidIngestionDataPandoraCustomRequestInfoFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< ArtistPandoraEntityJSON  > vector_Artists1 = new List< ArtistPandoraEntityJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            ArtistPandoraEntityJSON convert_classy = ArtistPandoraEntityJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Artists1.Add(convert_classy);
          }
        initArtists();
        for (int num3 = 0; num3 < vector_Artists1.Count; ++num3)
            appendArtists(vector_Artists1[num3]);
        for (int num1 = 0; num1 < vector_Artists1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPlaylists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Playlists of RapidIngestionDataPandoraCustomRequestInfoFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< PlaylistPandoraEntityJSON  > vector_Playlists1 = new List< PlaylistPandoraEntityJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            PlaylistPandoraEntityJSON convert_classy = PlaylistPandoraEntityJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Playlists1.Add(convert_classy);
          }
        initPlaylists();
        for (int num4 = 0; num4 < vector_Playlists1.Count; ++num4)
            appendPlaylists(vector_Playlists1[num4]);
        for (int num1 = 0; num1 < vector_Playlists1.Count; ++num1)
          {
          }
      }


    private void  fromJSONPodcasts(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Podcasts of RapidIngestionDataPandoraCustomRequestInfoFieldJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< PodcastPandoraEntityJSON  > vector_Podcasts1 = new List< PodcastPandoraEntityJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            PodcastPandoraEntityJSON convert_classy = PodcastPandoraEntityJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Podcasts1.Add(convert_classy);
          }
        initPodcasts();
        for (int num5 = 0; num5 < vector_Podcasts1.Count; ++num5)
            appendPodcasts(vector_Podcasts1[num5]);
        for (int num1 = 0; num1 < vector_Podcasts1.Count; ++num1)
          {
          }
      }


    public RapidIngestionDataPandoraCustomRequestInfoFieldJSON()
      {
        flagHasTracks = false;
        flagHasAlbums = false;
        flagHasArtists = false;
        flagHasPlaylists = false;
        flagHasPodcasts = false;
        storeTracks = new List< TrackPandoraEntityJSON  >();
        storeAlbums = new List< AlbumPandoraEntityJSON  >();
        storeArtists = new List< ArtistPandoraEntityJSON  >();
        storePlaylists = new List< PlaylistPandoraEntityJSON  >();
        storePodcasts = new List< PodcastPandoraEntityJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
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

    public TrackPandoraEntityJSON   elementOfTracks(int element_num)
      {
        Debug.Assert(flagHasTracks);
        return storeTracks[element_num];
      }

    public List< TrackPandoraEntityJSON  >  getTracks()
      {
        Debug.Assert(flagHasTracks);
        return storeTracks;
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

    public AlbumPandoraEntityJSON   elementOfAlbums(int element_num)
      {
        Debug.Assert(flagHasAlbums);
        return storeAlbums[element_num];
      }

    public List< AlbumPandoraEntityJSON  >  getAlbums()
      {
        Debug.Assert(flagHasAlbums);
        return storeAlbums;
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

    public ArtistPandoraEntityJSON   elementOfArtists(int element_num)
      {
        Debug.Assert(flagHasArtists);
        return storeArtists[element_num];
      }

    public List< ArtistPandoraEntityJSON  >  getArtists()
      {
        Debug.Assert(flagHasArtists);
        return storeArtists;
      }

    public bool  hasPlaylists()
      {
        return flagHasPlaylists;
      }

    public int  countOfPlaylists()
      {
        Debug.Assert(flagHasPlaylists);
        return storePlaylists.Count;
      }

    public PlaylistPandoraEntityJSON   elementOfPlaylists(int element_num)
      {
        Debug.Assert(flagHasPlaylists);
        return storePlaylists[element_num];
      }

    public List< PlaylistPandoraEntityJSON  >  getPlaylists()
      {
        Debug.Assert(flagHasPlaylists);
        return storePlaylists;
      }

    public bool  hasPodcasts()
      {
        return flagHasPodcasts;
      }

    public int  countOfPodcasts()
      {
        Debug.Assert(flagHasPodcasts);
        return storePodcasts.Count;
      }

    public PodcastPandoraEntityJSON   elementOfPodcasts(int element_num)
      {
        Debug.Assert(flagHasPodcasts);
        return storePodcasts[element_num];
      }

    public List< PodcastPandoraEntityJSON  >  getPodcasts()
      {
        Debug.Assert(flagHasPodcasts);
        return storePodcasts;
      }


    public virtual int extraRapidIngestionDataPandoraCustomRequestInfoFieldComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraRapidIngestionDataPandoraCustomRequestInfoFieldComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraRapidIngestionDataPandoraCustomRequestInfoFieldComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraRapidIngestionDataPandoraCustomRequestInfoFieldLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initTracks()
      {
        if (flagHasTracks)
          {
            for (int num1 = 0; num1 < storeTracks.Count; ++num1)
              {
              }
          }
        flagHasTracks = true;
        storeTracks.Clear();
      }
    public void appendTracks(TrackPandoraEntityJSON  to_append)
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
            for (int num2 = 0; num2 < storeTracks.Count; ++num2)
              {
              }
          }
        flagHasTracks = false;
        storeTracks.Clear();
      }
    public void initAlbums()
      {
        if (flagHasAlbums)
          {
            for (int num3 = 0; num3 < storeAlbums.Count; ++num3)
              {
              }
          }
        flagHasAlbums = true;
        storeAlbums.Clear();
      }
    public void appendAlbums(AlbumPandoraEntityJSON  to_append)
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
            for (int num4 = 0; num4 < storeAlbums.Count; ++num4)
              {
              }
          }
        flagHasAlbums = false;
        storeAlbums.Clear();
      }
    public void initArtists()
      {
        if (flagHasArtists)
          {
            for (int num5 = 0; num5 < storeArtists.Count; ++num5)
              {
              }
          }
        flagHasArtists = true;
        storeArtists.Clear();
      }
    public void appendArtists(ArtistPandoraEntityJSON  to_append)
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
            for (int num6 = 0; num6 < storeArtists.Count; ++num6)
              {
              }
          }
        flagHasArtists = false;
        storeArtists.Clear();
      }
    public void initPlaylists()
      {
        if (flagHasPlaylists)
          {
            for (int num7 = 0; num7 < storePlaylists.Count; ++num7)
              {
              }
          }
        flagHasPlaylists = true;
        storePlaylists.Clear();
      }
    public void appendPlaylists(PlaylistPandoraEntityJSON  to_append)
      {
        if (!flagHasPlaylists)
          {
            flagHasPlaylists = true;
            storePlaylists.Clear();
          }
        Debug.Assert(flagHasPlaylists);
        storePlaylists.Add(to_append);
      }
    public void unsetPlaylists()
      {
        if (flagHasPlaylists)
          {
            for (int num8 = 0; num8 < storePlaylists.Count; ++num8)
              {
              }
          }
        flagHasPlaylists = false;
        storePlaylists.Clear();
      }
    public void initPodcasts()
      {
        if (flagHasPodcasts)
          {
            for (int num9 = 0; num9 < storePodcasts.Count; ++num9)
              {
              }
          }
        flagHasPodcasts = true;
        storePodcasts.Clear();
      }
    public void appendPodcasts(PodcastPandoraEntityJSON  to_append)
      {
        if (!flagHasPodcasts)
          {
            flagHasPodcasts = true;
            storePodcasts.Clear();
          }
        Debug.Assert(flagHasPodcasts);
        storePodcasts.Add(to_append);
      }
    public void unsetPodcasts()
      {
        if (flagHasPodcasts)
          {
            for (int num10 = 0; num10 < storePodcasts.Count; ++num10)
              {
              }
          }
        flagHasPodcasts = false;
        storePodcasts.Clear();
      }

    public virtual void extraRapidIngestionDataPandoraCustomRequestInfoFieldAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraRapidIngestionDataPandoraCustomRequestInfoFieldSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraRapidIngestionDataPandoraCustomRequestInfoFieldLookup(key);
        if (old_field == null)
          {
            extraRapidIngestionDataPandoraCustomRequestInfoFieldAppendPair(key, new_component);
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
        if (flagHasTracks)
          {
            handler.start_pair("Tracks");
            handler.start_array();
            for (int num1 = 0; num1 < storeTracks.Count; ++num1)
              {
                if (partial_allowed)
                    storeTracks[num1].write_partial_as_json(handler);
                else
                    storeTracks[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasAlbums)
          {
            handler.start_pair("Albums");
            handler.start_array();
            for (int num2 = 0; num2 < storeAlbums.Count; ++num2)
              {
                if (partial_allowed)
                    storeAlbums[num2].write_partial_as_json(handler);
                else
                    storeAlbums[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasArtists)
          {
            handler.start_pair("Artists");
            handler.start_array();
            for (int num3 = 0; num3 < storeArtists.Count; ++num3)
              {
                if (partial_allowed)
                    storeArtists[num3].write_partial_as_json(handler);
                else
                    storeArtists[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasPlaylists)
          {
            handler.start_pair("Playlists");
            handler.start_array();
            for (int num4 = 0; num4 < storePlaylists.Count; ++num4)
              {
                if (partial_allowed)
                    storePlaylists[num4].write_partial_as_json(handler);
                else
                    storePlaylists[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasPodcasts)
          {
            handler.start_pair("Podcasts");
            handler.start_array();
            for (int num5 = 0; num5 < storePodcasts.Count; ++num5)
              {
                if (partial_allowed)
                    storePodcasts[num5].write_partial_as_json(handler);
                else
                    storePodcasts[num5].write_as_json(handler);
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
        return null;
      }

    public static RapidIngestionDataPandoraCustomRequestInfoFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RapidIngestionDataPandoraCustomRequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RapidIngestionDataPandoraCustomRequestInfoField", ignore_extras);
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
    public static RapidIngestionDataPandoraCustomRequestInfoFieldJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RapidIngestionDataPandoraCustomRequestInfoFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        RapidIngestionDataPandoraCustomRequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RapidIngestionDataPandoraCustomRequestInfoField", ignore_extras);
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
    public static RapidIngestionDataPandoraCustomRequestInfoFieldJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static RapidIngestionDataPandoraCustomRequestInfoFieldJSON from_text(string text, bool ignore_extras)
      {
        RapidIngestionDataPandoraCustomRequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RapidIngestionDataPandoraCustomRequestInfoField", ignore_extras);
            JSONParse.parse_json_value(text, "Text for RapidIngestionDataPandoraCustomRequestInfoFieldJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static RapidIngestionDataPandoraCustomRequestInfoFieldJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        RapidIngestionDataPandoraCustomRequestInfoFieldJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type RapidIngestionDataPandoraCustomRequestInfoField", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private TrackPandoraEntityJSON.HoldingArrayGenerator fieldGeneratorTracks;
        private AlbumPandoraEntityJSON.HoldingArrayGenerator fieldGeneratorAlbums;
        private ArtistPandoraEntityJSON.HoldingArrayGenerator fieldGeneratorArtists;
        private PlaylistPandoraEntityJSON.HoldingArrayGenerator fieldGeneratorPlaylists;
        private PodcastPandoraEntityJSON.HoldingArrayGenerator fieldGeneratorPodcasts;
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
            RapidIngestionDataPandoraCustomRequestInfoFieldJSON result = new RapidIngestionDataPandoraCustomRequestInfoFieldJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraRapidIngestionDataPandoraCustomRequestInfoFieldAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(RapidIngestionDataPandoraCustomRequestInfoFieldJSON result)
          {
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
            if (fieldGeneratorPlaylists.have_value)
              {
                result.initPlaylists();
                int count = fieldGeneratorPlaylists.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPlaylists(fieldGeneratorPlaylists.value[num]);
                  }
                fieldGeneratorPlaylists.value.Clear();
                fieldGeneratorPlaylists.have_value = false;
              }
            if (fieldGeneratorPodcasts.have_value)
              {
                result.initPodcasts();
                int count = fieldGeneratorPodcasts.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendPodcasts(fieldGeneratorPodcasts.value[num]);
                  }
                fieldGeneratorPodcasts.value.Clear();
                fieldGeneratorPodcasts.have_value = false;
              }
          }
        protected abstract void handle_result(RapidIngestionDataPandoraCustomRequestInfoFieldJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "bums", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratorAlbums;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "tists", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorArtists;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'P':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "aylists", 0, 7, false) == 0) && (field_name.Length == 9))
                                return fieldGeneratorPlaylists;
                            break;
                        case 'o':
                            if ((String.Compare(field_name, 2, "dcasts", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorPodcasts;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'T':
                    if ((String.Compare(field_name, 1, "racks", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorTracks;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorTracks = new TrackPandoraEntityJSON.HoldingArrayGenerator("field \"Tracks\" of the RapidIngestionDataPandoraCustomRequestInfoField class", ignore_extras);
            fieldGeneratorAlbums = new AlbumPandoraEntityJSON.HoldingArrayGenerator("field \"Albums\" of the RapidIngestionDataPandoraCustomRequestInfoField class", ignore_extras);
            fieldGeneratorArtists = new ArtistPandoraEntityJSON.HoldingArrayGenerator("field \"Artists\" of the RapidIngestionDataPandoraCustomRequestInfoField class", ignore_extras);
            fieldGeneratorPlaylists = new PlaylistPandoraEntityJSON.HoldingArrayGenerator("field \"Playlists\" of the RapidIngestionDataPandoraCustomRequestInfoField class", ignore_extras);
            fieldGeneratorPodcasts = new PodcastPandoraEntityJSON.HoldingArrayGenerator("field \"Podcasts\" of the RapidIngestionDataPandoraCustomRequestInfoField class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the RapidIngestionDataPandoraCustomRequestInfoField class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorTracks = new TrackPandoraEntityJSON.HoldingArrayGenerator("field \"Tracks\" of the RapidIngestionDataPandoraCustomRequestInfoField class", false);
            fieldGeneratorAlbums = new AlbumPandoraEntityJSON.HoldingArrayGenerator("field \"Albums\" of the RapidIngestionDataPandoraCustomRequestInfoField class", false);
            fieldGeneratorArtists = new ArtistPandoraEntityJSON.HoldingArrayGenerator("field \"Artists\" of the RapidIngestionDataPandoraCustomRequestInfoField class", false);
            fieldGeneratorPlaylists = new PlaylistPandoraEntityJSON.HoldingArrayGenerator("field \"Playlists\" of the RapidIngestionDataPandoraCustomRequestInfoField class", false);
            fieldGeneratorPodcasts = new PodcastPandoraEntityJSON.HoldingArrayGenerator("field \"Podcasts\" of the RapidIngestionDataPandoraCustomRequestInfoField class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the RapidIngestionDataPandoraCustomRequestInfoField class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorTracks.reset();
            fieldGeneratorAlbums.reset();
            fieldGeneratorArtists.reset();
            fieldGeneratorPlaylists.reset();
            fieldGeneratorPodcasts.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTracks.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorAlbums.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorArtists.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPlaylists.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPodcasts.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTracks.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorAlbums.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorArtists.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPlaylists.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPodcasts.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(RapidIngestionDataPandoraCustomRequestInfoFieldJSON  result)
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
        public RapidIngestionDataPandoraCustomRequestInfoFieldJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(RapidIngestionDataPandoraCustomRequestInfoFieldJSON  result)
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
    protected virtual void handle_result(List<RapidIngestionDataPandoraCustomRequestInfoFieldJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<RapidIngestionDataPandoraCustomRequestInfoFieldJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<RapidIngestionDataPandoraCustomRequestInfoFieldJSON>();
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
    public List<RapidIngestionDataPandoraCustomRequestInfoFieldJSON> value;
  };
  };
