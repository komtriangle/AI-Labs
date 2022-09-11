/* file "IHeartRadioSearchAllAPIResponseResultsJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class IHeartRadioSearchAllAPIResponseResultsJSON : JSONBase
  {
    private bool flagHasstations;
    private List< IHeartRadioSearchAllAPIResponseStationJSON  > storestations;
    private bool flagHasalbums;
    private List< IHeartRadioSearchAllAPIResponseAlbumJSON  > storealbums;
    private bool flagHasartists;
    private List< IHeartRadioSearchAllAPIResponseArtistJSON  > storeartists;
    private bool flagHasplaylists;
    private List< IHeartRadioSearchAllAPIResponsePlaylistJSON  > storeplaylists;
    private bool flagHastracks;
    private List< IHeartRadioSearchAllAPIResponseTrackJSON  > storetracks;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private void  fromJSONstations(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field stations of IHeartRadioSearchAllAPIResponseResultsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< IHeartRadioSearchAllAPIResponseStationJSON  > vector_stations1 = new List< IHeartRadioSearchAllAPIResponseStationJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            IHeartRadioSearchAllAPIResponseStationJSON convert_classy = IHeartRadioSearchAllAPIResponseStationJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_stations1.Add(convert_classy);
          }
        initstations();
        for (int num1 = 0; num1 < vector_stations1.Count; ++num1)
            appendstations(vector_stations1[num1]);
        for (int num1 = 0; num1 < vector_stations1.Count; ++num1)
          {
          }
      }


    private void  fromJSONalbums(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field albums of IHeartRadioSearchAllAPIResponseResultsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< IHeartRadioSearchAllAPIResponseAlbumJSON  > vector_albums1 = new List< IHeartRadioSearchAllAPIResponseAlbumJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            IHeartRadioSearchAllAPIResponseAlbumJSON convert_classy = IHeartRadioSearchAllAPIResponseAlbumJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_albums1.Add(convert_classy);
          }
        initalbums();
        for (int num2 = 0; num2 < vector_albums1.Count; ++num2)
            appendalbums(vector_albums1[num2]);
        for (int num1 = 0; num1 < vector_albums1.Count; ++num1)
          {
          }
      }


    private void  fromJSONartists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field artists of IHeartRadioSearchAllAPIResponseResultsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< IHeartRadioSearchAllAPIResponseArtistJSON  > vector_artists1 = new List< IHeartRadioSearchAllAPIResponseArtistJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            IHeartRadioSearchAllAPIResponseArtistJSON convert_classy = IHeartRadioSearchAllAPIResponseArtistJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_artists1.Add(convert_classy);
          }
        initartists();
        for (int num3 = 0; num3 < vector_artists1.Count; ++num3)
            appendartists(vector_artists1[num3]);
        for (int num1 = 0; num1 < vector_artists1.Count; ++num1)
          {
          }
      }


    private void  fromJSONplaylists(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field playlists of IHeartRadioSearchAllAPIResponseResultsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< IHeartRadioSearchAllAPIResponsePlaylistJSON  > vector_playlists1 = new List< IHeartRadioSearchAllAPIResponsePlaylistJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            IHeartRadioSearchAllAPIResponsePlaylistJSON convert_classy = IHeartRadioSearchAllAPIResponsePlaylistJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_playlists1.Add(convert_classy);
          }
        initplaylists();
        for (int num4 = 0; num4 < vector_playlists1.Count; ++num4)
            appendplaylists(vector_playlists1[num4]);
        for (int num1 = 0; num1 < vector_playlists1.Count; ++num1)
          {
          }
      }


    private void  fromJSONtracks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field tracks of IHeartRadioSearchAllAPIResponseResultsJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< IHeartRadioSearchAllAPIResponseTrackJSON  > vector_tracks1 = new List< IHeartRadioSearchAllAPIResponseTrackJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            IHeartRadioSearchAllAPIResponseTrackJSON convert_classy = IHeartRadioSearchAllAPIResponseTrackJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_tracks1.Add(convert_classy);
          }
        inittracks();
        for (int num5 = 0; num5 < vector_tracks1.Count; ++num5)
            appendtracks(vector_tracks1[num5]);
        for (int num1 = 0; num1 < vector_tracks1.Count; ++num1)
          {
          }
      }


    public IHeartRadioSearchAllAPIResponseResultsJSON()
      {
        flagHasstations = false;
        flagHasalbums = false;
        flagHasartists = false;
        flagHasplaylists = false;
        flagHastracks = false;
        storestations = new List< IHeartRadioSearchAllAPIResponseStationJSON  >();
        storealbums = new List< IHeartRadioSearchAllAPIResponseAlbumJSON  >();
        storeartists = new List< IHeartRadioSearchAllAPIResponseArtistJSON  >();
        storeplaylists = new List< IHeartRadioSearchAllAPIResponsePlaylistJSON  >();
        storetracks = new List< IHeartRadioSearchAllAPIResponseTrackJSON  >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public bool  hasstations()
      {
        return flagHasstations;
      }

    public int  countOfstations()
      {
        Debug.Assert(flagHasstations);
        return storestations.Count;
      }

    public IHeartRadioSearchAllAPIResponseStationJSON   elementOfstations(int element_num)
      {
        Debug.Assert(flagHasstations);
        return storestations[element_num];
      }

    public List< IHeartRadioSearchAllAPIResponseStationJSON  >  getstations()
      {
        Debug.Assert(flagHasstations);
        return storestations;
      }

    public bool  hasalbums()
      {
        return flagHasalbums;
      }

    public int  countOfalbums()
      {
        Debug.Assert(flagHasalbums);
        return storealbums.Count;
      }

    public IHeartRadioSearchAllAPIResponseAlbumJSON   elementOfalbums(int element_num)
      {
        Debug.Assert(flagHasalbums);
        return storealbums[element_num];
      }

    public List< IHeartRadioSearchAllAPIResponseAlbumJSON  >  getalbums()
      {
        Debug.Assert(flagHasalbums);
        return storealbums;
      }

    public bool  hasartists()
      {
        return flagHasartists;
      }

    public int  countOfartists()
      {
        Debug.Assert(flagHasartists);
        return storeartists.Count;
      }

    public IHeartRadioSearchAllAPIResponseArtistJSON   elementOfartists(int element_num)
      {
        Debug.Assert(flagHasartists);
        return storeartists[element_num];
      }

    public List< IHeartRadioSearchAllAPIResponseArtistJSON  >  getartists()
      {
        Debug.Assert(flagHasartists);
        return storeartists;
      }

    public bool  hasplaylists()
      {
        return flagHasplaylists;
      }

    public int  countOfplaylists()
      {
        Debug.Assert(flagHasplaylists);
        return storeplaylists.Count;
      }

    public IHeartRadioSearchAllAPIResponsePlaylistJSON   elementOfplaylists(int element_num)
      {
        Debug.Assert(flagHasplaylists);
        return storeplaylists[element_num];
      }

    public List< IHeartRadioSearchAllAPIResponsePlaylistJSON  >  getplaylists()
      {
        Debug.Assert(flagHasplaylists);
        return storeplaylists;
      }

    public bool  hastracks()
      {
        return flagHastracks;
      }

    public int  countOftracks()
      {
        Debug.Assert(flagHastracks);
        return storetracks.Count;
      }

    public IHeartRadioSearchAllAPIResponseTrackJSON   elementOftracks(int element_num)
      {
        Debug.Assert(flagHastracks);
        return storetracks[element_num];
      }

    public List< IHeartRadioSearchAllAPIResponseTrackJSON  >  gettracks()
      {
        Debug.Assert(flagHastracks);
        return storetracks;
      }


    public virtual int extraIHeartRadioSearchAllAPIResponseResultsComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraIHeartRadioSearchAllAPIResponseResultsComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraIHeartRadioSearchAllAPIResponseResultsComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraIHeartRadioSearchAllAPIResponseResultsLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }

    public void initstations()
      {
        if (flagHasstations)
          {
            for (int num1 = 0; num1 < storestations.Count; ++num1)
              {
              }
          }
        flagHasstations = true;
        storestations.Clear();
      }
    public void appendstations(IHeartRadioSearchAllAPIResponseStationJSON  to_append)
      {
        if (!flagHasstations)
          {
            flagHasstations = true;
            storestations.Clear();
          }
        Debug.Assert(flagHasstations);
        storestations.Add(to_append);
      }
    public void unsetstations()
      {
        if (flagHasstations)
          {
            for (int num2 = 0; num2 < storestations.Count; ++num2)
              {
              }
          }
        flagHasstations = false;
        storestations.Clear();
      }
    public void initalbums()
      {
        if (flagHasalbums)
          {
            for (int num3 = 0; num3 < storealbums.Count; ++num3)
              {
              }
          }
        flagHasalbums = true;
        storealbums.Clear();
      }
    public void appendalbums(IHeartRadioSearchAllAPIResponseAlbumJSON  to_append)
      {
        if (!flagHasalbums)
          {
            flagHasalbums = true;
            storealbums.Clear();
          }
        Debug.Assert(flagHasalbums);
        storealbums.Add(to_append);
      }
    public void unsetalbums()
      {
        if (flagHasalbums)
          {
            for (int num4 = 0; num4 < storealbums.Count; ++num4)
              {
              }
          }
        flagHasalbums = false;
        storealbums.Clear();
      }
    public void initartists()
      {
        if (flagHasartists)
          {
            for (int num5 = 0; num5 < storeartists.Count; ++num5)
              {
              }
          }
        flagHasartists = true;
        storeartists.Clear();
      }
    public void appendartists(IHeartRadioSearchAllAPIResponseArtistJSON  to_append)
      {
        if (!flagHasartists)
          {
            flagHasartists = true;
            storeartists.Clear();
          }
        Debug.Assert(flagHasartists);
        storeartists.Add(to_append);
      }
    public void unsetartists()
      {
        if (flagHasartists)
          {
            for (int num6 = 0; num6 < storeartists.Count; ++num6)
              {
              }
          }
        flagHasartists = false;
        storeartists.Clear();
      }
    public void initplaylists()
      {
        if (flagHasplaylists)
          {
            for (int num7 = 0; num7 < storeplaylists.Count; ++num7)
              {
              }
          }
        flagHasplaylists = true;
        storeplaylists.Clear();
      }
    public void appendplaylists(IHeartRadioSearchAllAPIResponsePlaylistJSON  to_append)
      {
        if (!flagHasplaylists)
          {
            flagHasplaylists = true;
            storeplaylists.Clear();
          }
        Debug.Assert(flagHasplaylists);
        storeplaylists.Add(to_append);
      }
    public void unsetplaylists()
      {
        if (flagHasplaylists)
          {
            for (int num8 = 0; num8 < storeplaylists.Count; ++num8)
              {
              }
          }
        flagHasplaylists = false;
        storeplaylists.Clear();
      }
    public void inittracks()
      {
        if (flagHastracks)
          {
            for (int num9 = 0; num9 < storetracks.Count; ++num9)
              {
              }
          }
        flagHastracks = true;
        storetracks.Clear();
      }
    public void appendtracks(IHeartRadioSearchAllAPIResponseTrackJSON  to_append)
      {
        if (!flagHastracks)
          {
            flagHastracks = true;
            storetracks.Clear();
          }
        Debug.Assert(flagHastracks);
        storetracks.Add(to_append);
      }
    public void unsettracks()
      {
        if (flagHastracks)
          {
            for (int num10 = 0; num10 < storetracks.Count; ++num10)
              {
              }
          }
        flagHastracks = false;
        storetracks.Clear();
      }

    public virtual void extraIHeartRadioSearchAllAPIResponseResultsAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraIHeartRadioSearchAllAPIResponseResultsSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraIHeartRadioSearchAllAPIResponseResultsLookup(key);
        if (old_field == null)
          {
            extraIHeartRadioSearchAllAPIResponseResultsAppendPair(key, new_component);
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
        Debug.Assert(partial_allowed || flagHasstations);
        if (flagHasstations)
          {
            handler.start_pair("stations");
            handler.start_array();
            for (int num1 = 0; num1 < storestations.Count; ++num1)
              {
                if (partial_allowed)
                    storestations[num1].write_partial_as_json(handler);
                else
                    storestations[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasalbums);
        if (flagHasalbums)
          {
            handler.start_pair("albums");
            handler.start_array();
            for (int num2 = 0; num2 < storealbums.Count; ++num2)
              {
                if (partial_allowed)
                    storealbums[num2].write_partial_as_json(handler);
                else
                    storealbums[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasartists);
        if (flagHasartists)
          {
            handler.start_pair("artists");
            handler.start_array();
            for (int num3 = 0; num3 < storeartists.Count; ++num3)
              {
                if (partial_allowed)
                    storeartists[num3].write_partial_as_json(handler);
                else
                    storeartists[num3].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHasplaylists);
        if (flagHasplaylists)
          {
            handler.start_pair("playlists");
            handler.start_array();
            for (int num4 = 0; num4 < storeplaylists.Count; ++num4)
              {
                if (partial_allowed)
                    storeplaylists[num4].write_partial_as_json(handler);
                else
                    storeplaylists[num4].write_as_json(handler);
              }
            handler.finish_array();
          }
        Debug.Assert(partial_allowed || flagHastracks);
        if (flagHastracks)
          {
            handler.start_pair("tracks");
            handler.start_array();
            for (int num5 = 0; num5 < storetracks.Count; ++num5)
              {
                if (partial_allowed)
                    storetracks[num5].write_partial_as_json(handler);
                else
                    storetracks[num5].write_as_json(handler);
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
        if (!(hasstations()))
          {
            return "When parsing the object for %what%, the \"stations\" field was missing.";
          }
        if (!(hasalbums()))
          {
            return "When parsing the object for %what%, the \"albums\" field was missing.";
          }
        if (!(hasartists()))
          {
            return "When parsing the object for %what%, the \"artists\" field was missing.";
          }
        if (!(hasplaylists()))
          {
            return "When parsing the object for %what%, the \"playlists\" field was missing.";
          }
        if (!(hastracks()))
          {
            return "When parsing the object for %what%, the \"tracks\" field was missing.";
          }
        return null;
      }

    public static IHeartRadioSearchAllAPIResponseResultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioSearchAllAPIResponseResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseResults", ignore_extras);
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
    public static IHeartRadioSearchAllAPIResponseResultsJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioSearchAllAPIResponseResultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        IHeartRadioSearchAllAPIResponseResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseResults", ignore_extras);
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
    public static IHeartRadioSearchAllAPIResponseResultsJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static IHeartRadioSearchAllAPIResponseResultsJSON from_text(string text, bool ignore_extras)
      {
        IHeartRadioSearchAllAPIResponseResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseResults", ignore_extras);
            JSONParse.parse_json_value(text, "Text for IHeartRadioSearchAllAPIResponseResultsJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static IHeartRadioSearchAllAPIResponseResultsJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        IHeartRadioSearchAllAPIResponseResultsJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type IHeartRadioSearchAllAPIResponseResults", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private IHeartRadioSearchAllAPIResponseStationJSON.HoldingArrayGenerator fieldGeneratorstations;
        private IHeartRadioSearchAllAPIResponseAlbumJSON.HoldingArrayGenerator fieldGeneratoralbums;
        private IHeartRadioSearchAllAPIResponseArtistJSON.HoldingArrayGenerator fieldGeneratorartists;
        private IHeartRadioSearchAllAPIResponsePlaylistJSON.HoldingArrayGenerator fieldGeneratorplaylists;
        private IHeartRadioSearchAllAPIResponseTrackJSON.HoldingArrayGenerator fieldGeneratortracks;
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
            IHeartRadioSearchAllAPIResponseResultsJSON result = new IHeartRadioSearchAllAPIResponseResultsJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraIHeartRadioSearchAllAPIResponseResultsAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected void finish(IHeartRadioSearchAllAPIResponseResultsJSON result)
          {
            if (fieldGeneratorstations.have_value)
              {
                result.initstations();
                int count = fieldGeneratorstations.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendstations(fieldGeneratorstations.value[num]);
                  }
                fieldGeneratorstations.value.Clear();
                fieldGeneratorstations.have_value = false;
              }
            else if ((!(result.hasstations())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"stations\" field was missing.");
              }
            if (fieldGeneratoralbums.have_value)
              {
                result.initalbums();
                int count = fieldGeneratoralbums.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendalbums(fieldGeneratoralbums.value[num]);
                  }
                fieldGeneratoralbums.value.Clear();
                fieldGeneratoralbums.have_value = false;
              }
            else if ((!(result.hasalbums())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"albums\" field was missing.");
              }
            if (fieldGeneratorartists.have_value)
              {
                result.initartists();
                int count = fieldGeneratorartists.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendartists(fieldGeneratorartists.value[num]);
                  }
                fieldGeneratorartists.value.Clear();
                fieldGeneratorartists.have_value = false;
              }
            else if ((!(result.hasartists())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"artists\" field was missing.");
              }
            if (fieldGeneratorplaylists.have_value)
              {
                result.initplaylists();
                int count = fieldGeneratorplaylists.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendplaylists(fieldGeneratorplaylists.value[num]);
                  }
                fieldGeneratorplaylists.value.Clear();
                fieldGeneratorplaylists.have_value = false;
              }
            else if ((!(result.hasplaylists())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"playlists\" field was missing.");
              }
            if (fieldGeneratortracks.have_value)
              {
                result.inittracks();
                int count = fieldGeneratortracks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendtracks(fieldGeneratortracks.value[num]);
                  }
                fieldGeneratortracks.value.Clear();
                fieldGeneratortracks.have_value = false;
              }
            else if ((!(result.hastracks())) && !allow_incomplete)
              {
                error("When parsing the object for %what%, the \"tracks\" field was missing.");
              }
          }
        protected abstract void handle_result(IHeartRadioSearchAllAPIResponseResultsJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'a':
                    switch (field_name[1])
                      {
                        case 'l':
                            if ((String.Compare(field_name, 2, "bums", 0, 4, false) == 0) && (field_name.Length == 6))
                                return fieldGeneratoralbums;
                            break;
                        case 'r':
                            if ((String.Compare(field_name, 2, "tists", 0, 5, false) == 0) && (field_name.Length == 7))
                                return fieldGeneratorartists;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'p':
                    if ((String.Compare(field_name, 1, "laylists", 0, 8, false) == 0) && (field_name.Length == 9))
                        return fieldGeneratorplaylists;
                    break;
                case 's':
                    if ((String.Compare(field_name, 1, "tations", 0, 7, false) == 0) && (field_name.Length == 8))
                        return fieldGeneratorstations;
                    break;
                case 't':
                    if ((String.Compare(field_name, 1, "racks", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratortracks;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorstations = new IHeartRadioSearchAllAPIResponseStationJSON.HoldingArrayGenerator("field \"stations\" of the IHeartRadioSearchAllAPIResponseResults class", ignore_extras);
            fieldGeneratoralbums = new IHeartRadioSearchAllAPIResponseAlbumJSON.HoldingArrayGenerator("field \"albums\" of the IHeartRadioSearchAllAPIResponseResults class", ignore_extras);
            fieldGeneratorartists = new IHeartRadioSearchAllAPIResponseArtistJSON.HoldingArrayGenerator("field \"artists\" of the IHeartRadioSearchAllAPIResponseResults class", ignore_extras);
            fieldGeneratorplaylists = new IHeartRadioSearchAllAPIResponsePlaylistJSON.HoldingArrayGenerator("field \"playlists\" of the IHeartRadioSearchAllAPIResponseResults class", ignore_extras);
            fieldGeneratortracks = new IHeartRadioSearchAllAPIResponseTrackJSON.HoldingArrayGenerator("field \"tracks\" of the IHeartRadioSearchAllAPIResponseResults class", ignore_extras);
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the IHeartRadioSearchAllAPIResponseResults class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorstations = new IHeartRadioSearchAllAPIResponseStationJSON.HoldingArrayGenerator("field \"stations\" of the IHeartRadioSearchAllAPIResponseResults class", false);
            fieldGeneratoralbums = new IHeartRadioSearchAllAPIResponseAlbumJSON.HoldingArrayGenerator("field \"albums\" of the IHeartRadioSearchAllAPIResponseResults class", false);
            fieldGeneratorartists = new IHeartRadioSearchAllAPIResponseArtistJSON.HoldingArrayGenerator("field \"artists\" of the IHeartRadioSearchAllAPIResponseResults class", false);
            fieldGeneratorplaylists = new IHeartRadioSearchAllAPIResponsePlaylistJSON.HoldingArrayGenerator("field \"playlists\" of the IHeartRadioSearchAllAPIResponseResults class", false);
            fieldGeneratortracks = new IHeartRadioSearchAllAPIResponseTrackJSON.HoldingArrayGenerator("field \"tracks\" of the IHeartRadioSearchAllAPIResponseResults class", false);
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the IHeartRadioSearchAllAPIResponseResults class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorstations.reset();
            fieldGeneratoralbums.reset();
            fieldGeneratorartists.reset();
            fieldGeneratorplaylists.reset();
            fieldGeneratortracks.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorstations.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratoralbums.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorartists.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorplaylists.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratortracks.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorstations.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratoralbums.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorartists.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorplaylists.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratortracks.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(IHeartRadioSearchAllAPIResponseResultsJSON  result)
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
        public IHeartRadioSearchAllAPIResponseResultsJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(IHeartRadioSearchAllAPIResponseResultsJSON  result)
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
    protected virtual void handle_result(List<IHeartRadioSearchAllAPIResponseResultsJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<IHeartRadioSearchAllAPIResponseResultsJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<IHeartRadioSearchAllAPIResponseResultsJSON>();
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
    public List<IHeartRadioSearchAllAPIResponseResultsJSON> value;
  };
  };
