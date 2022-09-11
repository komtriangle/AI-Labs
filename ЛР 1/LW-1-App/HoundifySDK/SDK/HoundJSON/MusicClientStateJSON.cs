/* file "MusicClientStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Numerics;


public class MusicClientStateJSON : JSONBase
  {
    private bool flagHasSoundHoundTrackId;
    private string storeSoundHoundTrackId;
    private bool flagHasSoundHoundArtistId;
    private string storeSoundHoundArtistId;
    private bool flagHasSoundHoundAlbumId;
    private string storeSoundHoundAlbumId;
    private bool flagHasSoundHoundTrackIdList;
    private List< string > storeSoundHoundTrackIdList;
    private bool flagHasSoundHoundArtistIdList;
    private List< string > storeSoundHoundArtistIdList;
    private bool flagHasSoundHoundAlbumIdList;
    private List< string > storeSoundHoundAlbumIdList;
    private bool flagHasTrackList;
    private MusicTrackResultJSON  storeTrackList;
    private bool flagHasTrackListPosition;
    private BigInteger storeTrackListPosition;
    private bool flagHasPlaylist;
    private PlaylistStateItemJSON  storePlaylist;
    private bool flagHasPlaylists;
    private List< PlaylistStateItemJSON  > storePlaylists;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONSoundHoundTrackId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SoundHoundTrackId of MusicClientStateJSON is not a string.");
        setSoundHoundTrackId(json_string.getData());
      }


    private void  fromJSONSoundHoundArtistId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SoundHoundArtistId of MusicClientStateJSON is not a string.");
        setSoundHoundArtistId(json_string.getData());
      }


    private void  fromJSONSoundHoundAlbumId(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field SoundHoundAlbumId of MusicClientStateJSON is not a string.");
        setSoundHoundAlbumId(json_string.getData());
      }


    private void  fromJSONSoundHoundTrackIdList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SoundHoundTrackIdList of MusicClientStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field SoundHoundTrackIdList of MusicClientStateJSON has too few elements.");
        List< string > vector_SoundHoundTrackIdList1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SoundHoundTrackIdList of MusicClientStateJSON is not a string.");
            vector_SoundHoundTrackIdList1.Add(json_string.getData());
          }
        Debug.Assert(vector_SoundHoundTrackIdList1.Count >= 1);
        initSoundHoundTrackIdList();
        for (int num1 = 0; num1 < vector_SoundHoundTrackIdList1.Count; ++num1)
            appendSoundHoundTrackIdList(vector_SoundHoundTrackIdList1[num1]);
        for (int num1 = 0; num1 < vector_SoundHoundTrackIdList1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSoundHoundArtistIdList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SoundHoundArtistIdList of MusicClientStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field SoundHoundArtistIdList of MusicClientStateJSON has too few elements.");
        List< string > vector_SoundHoundArtistIdList1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SoundHoundArtistIdList of MusicClientStateJSON is not a string.");
            vector_SoundHoundArtistIdList1.Add(json_string.getData());
          }
        Debug.Assert(vector_SoundHoundArtistIdList1.Count >= 1);
        initSoundHoundArtistIdList();
        for (int num2 = 0; num2 < vector_SoundHoundArtistIdList1.Count; ++num2)
            appendSoundHoundArtistIdList(vector_SoundHoundArtistIdList1[num2]);
        for (int num1 = 0; num1 < vector_SoundHoundArtistIdList1.Count; ++num1)
          {
          }
      }


    private void  fromJSONSoundHoundAlbumIdList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field SoundHoundAlbumIdList of MusicClientStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field SoundHoundAlbumIdList of MusicClientStateJSON has too few elements.");
        List< string > vector_SoundHoundAlbumIdList1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field SoundHoundAlbumIdList of MusicClientStateJSON is not a string.");
            vector_SoundHoundAlbumIdList1.Add(json_string.getData());
          }
        Debug.Assert(vector_SoundHoundAlbumIdList1.Count >= 1);
        initSoundHoundAlbumIdList();
        for (int num3 = 0; num3 < vector_SoundHoundAlbumIdList1.Count; ++num3)
            appendSoundHoundAlbumIdList(vector_SoundHoundAlbumIdList1[num3]);
        for (int num1 = 0; num1 < vector_SoundHoundAlbumIdList1.Count; ++num1)
          {
          }
      }


    private void  fromJSONTrackList(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicTrackResultJSON convert_classy = MusicTrackResultJSON.from_json(json_value, ignore_extras, true);
        setTrackList(convert_classy);
      }


    private void  fromJSONTrackListPosition(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        BigInteger extracted_integer;
        JSONIntegerValue json_integer = json_value.integer_value();
        if (json_integer == null)
          {
            JSONRationalValue json_rational = json_value.rational_value();
            if (json_rational == null)
              {
                throw new Exception("The value for field TrackListPosition of MusicClientStateJSON is not a number.");
              }
            if (!(json_rational.isInteger()))
              {
                throw new Exception("The value for field TrackListPosition of MusicClientStateJSON is not an integer.");
              }
            extracted_integer = json_rational.getInteger()        ;
          }
        else
          {
            extracted_integer = json_integer.getData()        ;
          }
        setTrackListPosition(extracted_integer);
      }


    private void  fromJSONPlaylist(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        PlaylistStateItemJSON convert_classy = PlaylistStateItemJSON.from_json(json_value, ignore_extras, true);
        setPlaylist(convert_classy);
      }


    private void  fromJSONPlaylists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Playlists of MusicClientStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< PlaylistStateItemJSON  > vector_Playlists1 = new List< PlaylistStateItemJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            PlaylistStateItemJSON convert_classy = PlaylistStateItemJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_Playlists1.Add(convert_classy);
          }
        initPlaylists();
        for (int num4 = 0; num4 < vector_Playlists1.Count; ++num4)
            appendPlaylists(vector_Playlists1[num4]);
        for (int num1 = 0; num1 < vector_Playlists1.Count; ++num1)
          {
          }
      }


    public MusicClientStateJSON()
      {
        flagHasSoundHoundTrackId = false;
        flagHasSoundHoundArtistId = false;
        flagHasSoundHoundAlbumId = false;
        flagHasSoundHoundTrackIdList = false;
        flagHasSoundHoundArtistIdList = false;
        flagHasSoundHoundAlbumIdList = false;
        flagHasTrackList = false;
        flagHasTrackListPosition = false;
        flagHasPlaylist = false;
        flagHasPlaylists = false;
        storeSoundHoundTrackIdList = new List< string >();
        storeSoundHoundArtistIdList = new List< string >();
        storeSoundHoundAlbumIdList = new List< string >();
        storePlaylists = new List< PlaylistStateItemJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasSoundHoundTrackId()
      {
        return flagHasSoundHoundTrackId;
      }

    public string  getSoundHoundTrackId()
      {
        Debug.Assert(flagHasSoundHoundTrackId);
        return storeSoundHoundTrackId;
      }

    public bool  hasSoundHoundArtistId()
      {
        return flagHasSoundHoundArtistId;
      }

    public string  getSoundHoundArtistId()
      {
        Debug.Assert(flagHasSoundHoundArtistId);
        return storeSoundHoundArtistId;
      }

    public bool  hasSoundHoundAlbumId()
      {
        return flagHasSoundHoundAlbumId;
      }

    public string  getSoundHoundAlbumId()
      {
        Debug.Assert(flagHasSoundHoundAlbumId);
        return storeSoundHoundAlbumId;
      }

    public bool  hasSoundHoundTrackIdList()
      {
        return flagHasSoundHoundTrackIdList;
      }

    public int  countOfSoundHoundTrackIdList()
      {
        Debug.Assert(flagHasSoundHoundTrackIdList);
        return storeSoundHoundTrackIdList.Count;
      }

    public string  elementOfSoundHoundTrackIdList(int element_num)
      {
        Debug.Assert(flagHasSoundHoundTrackIdList);
        return storeSoundHoundTrackIdList[element_num];
      }

    public List< string >  getSoundHoundTrackIdList()
      {
        Debug.Assert(flagHasSoundHoundTrackIdList);
        return storeSoundHoundTrackIdList;
      }

    public bool  hasSoundHoundArtistIdList()
      {
        return flagHasSoundHoundArtistIdList;
      }

    public int  countOfSoundHoundArtistIdList()
      {
        Debug.Assert(flagHasSoundHoundArtistIdList);
        return storeSoundHoundArtistIdList.Count;
      }

    public string  elementOfSoundHoundArtistIdList(int element_num)
      {
        Debug.Assert(flagHasSoundHoundArtistIdList);
        return storeSoundHoundArtistIdList[element_num];
      }

    public List< string >  getSoundHoundArtistIdList()
      {
        Debug.Assert(flagHasSoundHoundArtistIdList);
        return storeSoundHoundArtistIdList;
      }

    public bool  hasSoundHoundAlbumIdList()
      {
        return flagHasSoundHoundAlbumIdList;
      }

    public int  countOfSoundHoundAlbumIdList()
      {
        Debug.Assert(flagHasSoundHoundAlbumIdList);
        return storeSoundHoundAlbumIdList.Count;
      }

    public string  elementOfSoundHoundAlbumIdList(int element_num)
      {
        Debug.Assert(flagHasSoundHoundAlbumIdList);
        return storeSoundHoundAlbumIdList[element_num];
      }

    public List< string >  getSoundHoundAlbumIdList()
      {
        Debug.Assert(flagHasSoundHoundAlbumIdList);
        return storeSoundHoundAlbumIdList;
      }

    public bool  hasTrackList()
      {
        return flagHasTrackList;
      }

    public MusicTrackResultJSON   getTrackList()
      {
        Debug.Assert(flagHasTrackList);
        return storeTrackList;
      }

    public bool  hasTrackListPosition()
      {
        return flagHasTrackListPosition;
      }

    public BigInteger  getTrackListPosition()
      {
        Debug.Assert(flagHasTrackListPosition);
        return storeTrackListPosition;
      }

    public bool  hasPlaylist()
      {
        return flagHasPlaylist;
      }

    public PlaylistStateItemJSON   getPlaylist()
      {
        Debug.Assert(flagHasPlaylist);
        return storePlaylist;
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

    public PlaylistStateItemJSON   elementOfPlaylists(int element_num)
      {
        Debug.Assert(flagHasPlaylists);
        return storePlaylists[element_num];
      }

    public List< PlaylistStateItemJSON  >  getPlaylists()
      {
        Debug.Assert(flagHasPlaylists);
        return storePlaylists;
      }


    public virtual int extraMusicClientStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMusicClientStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMusicClientStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMusicClientStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void setSoundHoundTrackId(string new_value)
      {
        flagHasSoundHoundTrackId = true;
        storeSoundHoundTrackId = new_value;
      }
    public void unsetSoundHoundTrackId()
      {
        flagHasSoundHoundTrackId = false;
      }
    public void setSoundHoundArtistId(string new_value)
      {
        flagHasSoundHoundArtistId = true;
        storeSoundHoundArtistId = new_value;
      }
    public void unsetSoundHoundArtistId()
      {
        flagHasSoundHoundArtistId = false;
      }
    public void setSoundHoundAlbumId(string new_value)
      {
        flagHasSoundHoundAlbumId = true;
        storeSoundHoundAlbumId = new_value;
      }
    public void unsetSoundHoundAlbumId()
      {
        flagHasSoundHoundAlbumId = false;
      }
    public void initSoundHoundTrackIdList()
      {
        flagHasSoundHoundTrackIdList = true;
        storeSoundHoundTrackIdList.Clear();
      }
    public void appendSoundHoundTrackIdList(string to_append)
      {
        if (!flagHasSoundHoundTrackIdList)
          {
            flagHasSoundHoundTrackIdList = true;
            storeSoundHoundTrackIdList.Clear();
          }
        Debug.Assert(flagHasSoundHoundTrackIdList);
        storeSoundHoundTrackIdList.Add(to_append);
      }
    public void unsetSoundHoundTrackIdList()
      {
        flagHasSoundHoundTrackIdList = false;
        storeSoundHoundTrackIdList.Clear();
      }
    public void initSoundHoundArtistIdList()
      {
        flagHasSoundHoundArtistIdList = true;
        storeSoundHoundArtistIdList.Clear();
      }
    public void appendSoundHoundArtistIdList(string to_append)
      {
        if (!flagHasSoundHoundArtistIdList)
          {
            flagHasSoundHoundArtistIdList = true;
            storeSoundHoundArtistIdList.Clear();
          }
        Debug.Assert(flagHasSoundHoundArtistIdList);
        storeSoundHoundArtistIdList.Add(to_append);
      }
    public void unsetSoundHoundArtistIdList()
      {
        flagHasSoundHoundArtistIdList = false;
        storeSoundHoundArtistIdList.Clear();
      }
    public void initSoundHoundAlbumIdList()
      {
        flagHasSoundHoundAlbumIdList = true;
        storeSoundHoundAlbumIdList.Clear();
      }
    public void appendSoundHoundAlbumIdList(string to_append)
      {
        if (!flagHasSoundHoundAlbumIdList)
          {
            flagHasSoundHoundAlbumIdList = true;
            storeSoundHoundAlbumIdList.Clear();
          }
        Debug.Assert(flagHasSoundHoundAlbumIdList);
        storeSoundHoundAlbumIdList.Add(to_append);
      }
    public void unsetSoundHoundAlbumIdList()
      {
        flagHasSoundHoundAlbumIdList = false;
        storeSoundHoundAlbumIdList.Clear();
      }
    public void setTrackList(MusicTrackResultJSON  new_value)
      {
        if (flagHasTrackList)
          {
          }
        flagHasTrackList = true;
        storeTrackList = new_value;
      }
    public void unsetTrackList()
      {
        if (flagHasTrackList)
          {
          }
        flagHasTrackList = false;
      }
    public void setTrackListPosition(BigInteger new_value)
      {
        flagHasTrackListPosition = true;
        storeTrackListPosition = new_value;
      }
    public void unsetTrackListPosition()
      {
        flagHasTrackListPosition = false;
      }
    public void setPlaylist(PlaylistStateItemJSON  new_value)
      {
        if (flagHasPlaylist)
          {
          }
        flagHasPlaylist = true;
        storePlaylist = new_value;
      }
    public void unsetPlaylist()
      {
        if (flagHasPlaylist)
          {
          }
        flagHasPlaylist = false;
      }
    public void initPlaylists()
      {
        if (flagHasPlaylists)
          {
            for (int num1 = 0; num1 < storePlaylists.Count; ++num1)
              {
              }
          }
        flagHasPlaylists = true;
        storePlaylists.Clear();
      }
    public void appendPlaylists(PlaylistStateItemJSON  to_append)
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
            for (int num2 = 0; num2 < storePlaylists.Count; ++num2)
              {
              }
          }
        flagHasPlaylists = false;
        storePlaylists.Clear();
      }

    public virtual void extraMusicClientStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMusicClientStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMusicClientStateLookup(key);
        if (old_field == null)
          {
            extraMusicClientStateAppendPair(key, new_component);
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
        if (flagHasSoundHoundTrackId)
          {
            handler.start_pair("SoundHoundTrackId");
            handler.string_value(storeSoundHoundTrackId);
          }
        if (flagHasSoundHoundArtistId)
          {
            handler.start_pair("SoundHoundArtistId");
            handler.string_value(storeSoundHoundArtistId);
          }
        if (flagHasSoundHoundAlbumId)
          {
            handler.start_pair("SoundHoundAlbumId");
            handler.string_value(storeSoundHoundAlbumId);
          }
        if (flagHasSoundHoundTrackIdList)
          {
            handler.start_pair("SoundHoundTrackIdList");
            Debug.Assert(storeSoundHoundTrackIdList.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeSoundHoundTrackIdList.Count; ++num1)
              {
                handler.string_value(storeSoundHoundTrackIdList[num1]);
              }
            handler.finish_array();
          }
        if (flagHasSoundHoundArtistIdList)
          {
            handler.start_pair("SoundHoundArtistIdList");
            Debug.Assert(storeSoundHoundArtistIdList.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeSoundHoundArtistIdList.Count; ++num2)
              {
                handler.string_value(storeSoundHoundArtistIdList[num2]);
              }
            handler.finish_array();
          }
        if (flagHasSoundHoundAlbumIdList)
          {
            handler.start_pair("SoundHoundAlbumIdList");
            Debug.Assert(storeSoundHoundAlbumIdList.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeSoundHoundAlbumIdList.Count; ++num3)
              {
                handler.string_value(storeSoundHoundAlbumIdList[num3]);
              }
            handler.finish_array();
          }
        if (flagHasTrackList)
          {
            handler.start_pair("TrackList");
            if (partial_allowed)
                storeTrackList.write_partial_as_json(handler);
            else
                storeTrackList.write_as_json(handler);
          }
        if (flagHasTrackListPosition)
          {
            handler.start_pair("TrackListPosition");
            handler.number_value(storeTrackListPosition);
          }
        if (flagHasPlaylist)
          {
            handler.start_pair("Playlist");
            if (partial_allowed)
                storePlaylist.write_partial_as_json(handler);
            else
                storePlaylist.write_as_json(handler);
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

    public static MusicClientStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicClientState", ignore_extras);
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
    public static MusicClientStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicClientStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicClientState", ignore_extras);
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
    public static MusicClientStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicClientStateJSON from_text(string text, bool ignore_extras)
      {
        MusicClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicClientState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicClientStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicClientStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicClientStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicClientState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private JSONHoldingStringGenerator fieldGeneratorSoundHoundTrackId;
        private JSONHoldingStringGenerator fieldGeneratorSoundHoundArtistId;
        private JSONHoldingStringGenerator fieldGeneratorSoundHoundAlbumId;
        private JSONHoldingStringArrayGenerator fieldGeneratorSoundHoundTrackIdList;
        private JSONHoldingStringArrayGenerator fieldGeneratorSoundHoundArtistIdList;
        private JSONHoldingStringArrayGenerator fieldGeneratorSoundHoundAlbumIdList;
        private MusicTrackResultJSON.HoldingGenerator fieldGeneratorTrackList;
    private class FieldHoldingGeneratorTrackListPosition : JSONHoldingIntegerUnboundRangeGenerator
          {
            public FieldHoldingGeneratorTrackListPosition(String what) : base(what)
              {
              }
          };
    private class FieldHoldingArrayGeneratorTrackListPosition : JSONHoldingIntegerUnboundRangeArrayGenerator
          {
            public FieldHoldingArrayGeneratorTrackListPosition(String what) : base(what)
              {
              }
          };
        private FieldHoldingGeneratorTrackListPosition fieldGeneratorTrackListPosition;
        private PlaylistStateItemJSON.HoldingGenerator fieldGeneratorPlaylist;
        private PlaylistStateItemJSON.HoldingArrayGenerator fieldGeneratorPlaylists;
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
            MusicClientStateJSON result = new MusicClientStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicClientStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(MusicClientStateJSON result)
          {
            if (fieldGeneratorSoundHoundTrackId.have_value)
              {
                result.setSoundHoundTrackId(fieldGeneratorSoundHoundTrackId.value);
                fieldGeneratorSoundHoundTrackId.have_value = false;
              }
            if (fieldGeneratorSoundHoundArtistId.have_value)
              {
                result.setSoundHoundArtistId(fieldGeneratorSoundHoundArtistId.value);
                fieldGeneratorSoundHoundArtistId.have_value = false;
              }
            if (fieldGeneratorSoundHoundAlbumId.have_value)
              {
                result.setSoundHoundAlbumId(fieldGeneratorSoundHoundAlbumId.value);
                fieldGeneratorSoundHoundAlbumId.have_value = false;
              }
            if (fieldGeneratorSoundHoundTrackIdList.have_value)
              {
                result.initSoundHoundTrackIdList();
                int count = fieldGeneratorSoundHoundTrackIdList.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSoundHoundTrackIdList(fieldGeneratorSoundHoundTrackIdList.value[num]);
                  }
                fieldGeneratorSoundHoundTrackIdList.value.Clear();
                fieldGeneratorSoundHoundTrackIdList.have_value = false;
              }
            if (fieldGeneratorSoundHoundArtistIdList.have_value)
              {
                result.initSoundHoundArtistIdList();
                int count = fieldGeneratorSoundHoundArtistIdList.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSoundHoundArtistIdList(fieldGeneratorSoundHoundArtistIdList.value[num]);
                  }
                fieldGeneratorSoundHoundArtistIdList.value.Clear();
                fieldGeneratorSoundHoundArtistIdList.have_value = false;
              }
            if (fieldGeneratorSoundHoundAlbumIdList.have_value)
              {
                result.initSoundHoundAlbumIdList();
                int count = fieldGeneratorSoundHoundAlbumIdList.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendSoundHoundAlbumIdList(fieldGeneratorSoundHoundAlbumIdList.value[num]);
                  }
                fieldGeneratorSoundHoundAlbumIdList.value.Clear();
                fieldGeneratorSoundHoundAlbumIdList.have_value = false;
              }
            if (fieldGeneratorTrackList.have_value)
              {
                result.setTrackList(fieldGeneratorTrackList.value);
                fieldGeneratorTrackList.have_value = false;
              }
            if (fieldGeneratorTrackListPosition.have_value)
              {
                result.setTrackListPosition(fieldGeneratorTrackListPosition.value);
                fieldGeneratorTrackListPosition.have_value = false;
              }
            if (fieldGeneratorPlaylist.have_value)
              {
                result.setPlaylist(fieldGeneratorPlaylist.value);
                fieldGeneratorPlaylist.have_value = false;
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
          }
        protected abstract void handle_result(MusicClientStateJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'P':
                    if (String.Compare(field_name, 1, "laylist", 0, 7, false) == 0)
                      {
                        if (field_name.Length == 8)
                          {
                            return fieldGeneratorPlaylist;
                          }
                        switch (field_name[8])
                          {
                            case 's':
                                if (field_name.Length == 9)
                                    return fieldGeneratorPlaylists;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'S':
                    if (String.Compare(field_name, 1, "oundHound", 0, 9, false) == 0)
                      {
                        switch (field_name[10])
                          {
                            case 'A':
                                switch (field_name[11])
                                  {
                                    case 'l':
                                        if (String.Compare(field_name, 12, "bumId", 0, 5, false) == 0)
                                          {
                                            if (field_name.Length == 17)
                                              {
                                                return fieldGeneratorSoundHoundAlbumId;
                                              }
                                            switch (field_name[17])
                                              {
                                                case 'L':
                                                    if ((String.Compare(field_name, 18, "ist", 0, 3, false) == 0) && (field_name.Length == 21))
                                                        return fieldGeneratorSoundHoundAlbumIdList;
                                                    break;
                                                default:
                                                    break;
                                              }
                                          }
                                        break;
                                    case 'r':
                                        if (String.Compare(field_name, 12, "tistId", 0, 6, false) == 0)
                                          {
                                            if (field_name.Length == 18)
                                              {
                                                return fieldGeneratorSoundHoundArtistId;
                                              }
                                            switch (field_name[18])
                                              {
                                                case 'L':
                                                    if ((String.Compare(field_name, 19, "ist", 0, 3, false) == 0) && (field_name.Length == 22))
                                                        return fieldGeneratorSoundHoundArtistIdList;
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
                            case 'T':
                                if (String.Compare(field_name, 11, "rackId", 0, 6, false) == 0)
                                  {
                                    if (field_name.Length == 17)
                                      {
                                        return fieldGeneratorSoundHoundTrackId;
                                      }
                                    switch (field_name[17])
                                      {
                                        case 'L':
                                            if ((String.Compare(field_name, 18, "ist", 0, 3, false) == 0) && (field_name.Length == 21))
                                                return fieldGeneratorSoundHoundTrackIdList;
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
                case 'T':
                    if (String.Compare(field_name, 1, "rackList", 0, 8, false) == 0)
                      {
                        if (field_name.Length == 9)
                          {
                            return fieldGeneratorTrackList;
                          }
                        switch (field_name[9])
                          {
                            case 'P':
                                if ((String.Compare(field_name, 10, "osition", 0, 7, false) == 0) && (field_name.Length == 17))
                                    return fieldGeneratorTrackListPosition;
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
            fieldGeneratorSoundHoundTrackId = new JSONHoldingStringGenerator("field \"SoundHoundTrackId\" of the MusicClientState class");
            fieldGeneratorSoundHoundArtistId = new JSONHoldingStringGenerator("field \"SoundHoundArtistId\" of the MusicClientState class");
            fieldGeneratorSoundHoundAlbumId = new JSONHoldingStringGenerator("field \"SoundHoundAlbumId\" of the MusicClientState class");
            fieldGeneratorSoundHoundTrackIdList = new JSONHoldingStringArrayGenerator("field \"SoundHoundTrackIdList\" of the MusicClientState class");
            fieldGeneratorSoundHoundArtistIdList = new JSONHoldingStringArrayGenerator("field \"SoundHoundArtistIdList\" of the MusicClientState class");
            fieldGeneratorSoundHoundAlbumIdList = new JSONHoldingStringArrayGenerator("field \"SoundHoundAlbumIdList\" of the MusicClientState class");
            fieldGeneratorTrackList = new MusicTrackResultJSON.HoldingGenerator("field \"TrackList\" of the MusicClientState class", ignore_extras);
            fieldGeneratorTrackListPosition = new FieldHoldingGeneratorTrackListPosition("field \"TrackListPosition\" of the MusicClientState class");
            fieldGeneratorPlaylist = new PlaylistStateItemJSON.HoldingGenerator("field \"Playlist\" of the MusicClientState class", ignore_extras);
            fieldGeneratorPlaylists = new PlaylistStateItemJSON.HoldingArrayGenerator("field \"Playlists\" of the MusicClientState class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MusicClientState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorSoundHoundTrackId = new JSONHoldingStringGenerator("field \"SoundHoundTrackId\" of the MusicClientState class");
            fieldGeneratorSoundHoundArtistId = new JSONHoldingStringGenerator("field \"SoundHoundArtistId\" of the MusicClientState class");
            fieldGeneratorSoundHoundAlbumId = new JSONHoldingStringGenerator("field \"SoundHoundAlbumId\" of the MusicClientState class");
            fieldGeneratorSoundHoundTrackIdList = new JSONHoldingStringArrayGenerator("field \"SoundHoundTrackIdList\" of the MusicClientState class");
            fieldGeneratorSoundHoundArtistIdList = new JSONHoldingStringArrayGenerator("field \"SoundHoundArtistIdList\" of the MusicClientState class");
            fieldGeneratorSoundHoundAlbumIdList = new JSONHoldingStringArrayGenerator("field \"SoundHoundAlbumIdList\" of the MusicClientState class");
            fieldGeneratorTrackList = new MusicTrackResultJSON.HoldingGenerator("field \"TrackList\" of the MusicClientState class", false);
            fieldGeneratorTrackListPosition = new FieldHoldingGeneratorTrackListPosition("field \"TrackListPosition\" of the MusicClientState class");
            fieldGeneratorPlaylist = new PlaylistStateItemJSON.HoldingGenerator("field \"Playlist\" of the MusicClientState class", false);
            fieldGeneratorPlaylists = new PlaylistStateItemJSON.HoldingArrayGenerator("field \"Playlists\" of the MusicClientState class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MusicClientState class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorSoundHoundTrackId.reset();
            fieldGeneratorSoundHoundArtistId.reset();
            fieldGeneratorSoundHoundAlbumId.reset();
            fieldGeneratorSoundHoundTrackIdList.reset();
            fieldGeneratorSoundHoundArtistIdList.reset();
            fieldGeneratorSoundHoundAlbumIdList.reset();
            fieldGeneratorTrackList.reset();
            fieldGeneratorTrackListPosition.reset();
            fieldGeneratorPlaylist.reset();
            fieldGeneratorPlaylists.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorTrackList.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPlaylist.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorPlaylists.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorTrackList.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPlaylist.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorPlaylists.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicClientStateJSON  result)
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
        public MusicClientStateJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicClientStateJSON  result)
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
    protected virtual void handle_result(List<MusicClientStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicClientStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicClientStateJSON>();
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
    public List<MusicClientStateJSON> value;
  };
  };
