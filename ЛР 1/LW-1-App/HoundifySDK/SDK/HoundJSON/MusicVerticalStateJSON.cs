/* file "MusicVerticalStateJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicVerticalStateJSON : ClientVerticalStateJSON
  {
    private bool flagHasTrackID;
    private string storeTrackID;
    private bool flagHasArtistID;
    private string storeArtistID;
    private bool flagHasAlbumID;
    private string storeAlbumID;
    private bool flagHasTrackIDs;
    private List< string > storeTrackIDs;
    private bool flagHasArtistIDs;
    private List< string > storeArtistIDs;
    private bool flagHasAlbumIDs;
    private List< string > storeAlbumIDs;
    private List<string> extraKeys;
    private List<JSONValue > extraValues;
    private Dictionary<string, JSONValue > extraIndex;


    private JSONValue  extraTrackIDToJSON()
      {
        JSONStringValue generated_string_TrackID = new JSONStringValue(storeTrackID);
        return generated_string_TrackID;
      }

    private JSONValue  extraArtistIDToJSON()
      {
        JSONStringValue generated_string_ArtistID = new JSONStringValue(storeArtistID);
        return generated_string_ArtistID;
      }

    private JSONValue  extraAlbumIDToJSON()
      {
        JSONStringValue generated_string_AlbumID = new JSONStringValue(storeAlbumID);
        return generated_string_AlbumID;
      }

    private JSONValue  extraTrackIDsToJSON()
      {
        JSONArrayValue generated_array_1_TrackIDs = new JSONArrayValue();
        for (int num1 = 0; num1 < storeTrackIDs.Count; ++num1)
          {
            JSONStringValue generated_string_TrackIDs = new JSONStringValue(storeTrackIDs[num1]);
            generated_array_1_TrackIDs.appendComponent(generated_string_TrackIDs);
          }
        return generated_array_1_TrackIDs;
      }

    private JSONValue  extraArtistIDsToJSON()
      {
        JSONArrayValue generated_array_2_ArtistIDs = new JSONArrayValue();
        for (int num2 = 0; num2 < storeArtistIDs.Count; ++num2)
          {
            JSONStringValue generated_string_ArtistIDs = new JSONStringValue(storeArtistIDs[num2]);
            generated_array_2_ArtistIDs.appendComponent(generated_string_ArtistIDs);
          }
        return generated_array_2_ArtistIDs;
      }

    private JSONValue  extraAlbumIDsToJSON()
      {
        JSONArrayValue generated_array_3_AlbumIDs = new JSONArrayValue();
        for (int num3 = 0; num3 < storeAlbumIDs.Count; ++num3)
          {
            JSONStringValue generated_string_AlbumIDs = new JSONStringValue(storeAlbumIDs[num3]);
            generated_array_3_AlbumIDs.appendComponent(generated_string_AlbumIDs);
          }
        return generated_array_3_AlbumIDs;
      }


    private void  fromJSONTrackID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field TrackID of MusicVerticalStateJSON is not a string.");
        setTrackID(json_string.getData());
      }


    private void  fromJSONArtistID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ArtistID of MusicVerticalStateJSON is not a string.");
        setArtistID(json_string.getData());
      }


    private void  fromJSONAlbumID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field AlbumID of MusicVerticalStateJSON is not a string.");
        setAlbumID(json_string.getData());
      }


    private void  fromJSONTrackIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field TrackIDs of MusicVerticalStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_TrackIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field TrackIDs of MusicVerticalStateJSON is not a string.");
            vector_TrackIDs1.Add(json_string.getData());
          }
        initTrackIDs();
        for (int num1 = 0; num1 < vector_TrackIDs1.Count; ++num1)
            appendTrackIDs(vector_TrackIDs1[num1]);
        for (int num1 = 0; num1 < vector_TrackIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONArtistIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field ArtistIDs of MusicVerticalStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_ArtistIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field ArtistIDs of MusicVerticalStateJSON is not a string.");
            vector_ArtistIDs1.Add(json_string.getData());
          }
        initArtistIDs();
        for (int num2 = 0; num2 < vector_ArtistIDs1.Count; ++num2)
            appendArtistIDs(vector_ArtistIDs1[num2]);
        for (int num1 = 0; num1 < vector_ArtistIDs1.Count; ++num1)
          {
          }
      }


    private void  fromJSONAlbumIDs(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field AlbumIDs of MusicVerticalStateJSON is not an array.");
        int count1 = json_array1.componentCount();
        List< string > vector_AlbumIDs1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field AlbumIDs of MusicVerticalStateJSON is not a string.");
            vector_AlbumIDs1.Add(json_string.getData());
          }
        initAlbumIDs();
        for (int num3 = 0; num3 < vector_AlbumIDs1.Count; ++num3)
            appendAlbumIDs(vector_AlbumIDs1[num3]);
        for (int num1 = 0; num1 < vector_AlbumIDs1.Count; ++num1)
          {
          }
      }


    public MusicVerticalStateJSON()
      {
        flagHasTrackID = false;
        flagHasArtistID = false;
        flagHasAlbumID = false;
        flagHasTrackIDs = false;
        flagHasArtistIDs = false;
        flagHasAlbumIDs = false;
        storeTrackIDs = new List< string >();
        storeArtistIDs = new List< string >();
        storeAlbumIDs = new List< string >();
        extraKeys = new List<string>();
    extraValues = new List<JSONValue >();
    extraIndex = new Dictionary<string, JSONValue >();
      }

    public override string  getClientVerticalStateKind()
      {
        return "MusicVerticalState";
      }

    public bool  hasTrackID()
      {
        return flagHasTrackID;
      }

    public string  getTrackID()
      {
        Debug.Assert(flagHasTrackID);
        return storeTrackID;
      }

    public bool  hasArtistID()
      {
        return flagHasArtistID;
      }

    public string  getArtistID()
      {
        Debug.Assert(flagHasArtistID);
        return storeArtistID;
      }

    public bool  hasAlbumID()
      {
        return flagHasAlbumID;
      }

    public string  getAlbumID()
      {
        Debug.Assert(flagHasAlbumID);
        return storeAlbumID;
      }

    public bool  hasTrackIDs()
      {
        return flagHasTrackIDs;
      }

    public int  countOfTrackIDs()
      {
        Debug.Assert(flagHasTrackIDs);
        return storeTrackIDs.Count;
      }

    public string  elementOfTrackIDs(int element_num)
      {
        Debug.Assert(flagHasTrackIDs);
        return storeTrackIDs[element_num];
      }

    public List< string >  getTrackIDs()
      {
        Debug.Assert(flagHasTrackIDs);
        return storeTrackIDs;
      }

    public bool  hasArtistIDs()
      {
        return flagHasArtistIDs;
      }

    public int  countOfArtistIDs()
      {
        Debug.Assert(flagHasArtistIDs);
        return storeArtistIDs.Count;
      }

    public string  elementOfArtistIDs(int element_num)
      {
        Debug.Assert(flagHasArtistIDs);
        return storeArtistIDs[element_num];
      }

    public List< string >  getArtistIDs()
      {
        Debug.Assert(flagHasArtistIDs);
        return storeArtistIDs;
      }

    public bool  hasAlbumIDs()
      {
        return flagHasAlbumIDs;
      }

    public int  countOfAlbumIDs()
      {
        Debug.Assert(flagHasAlbumIDs);
        return storeAlbumIDs.Count;
      }

    public string  elementOfAlbumIDs(int element_num)
      {
        Debug.Assert(flagHasAlbumIDs);
        return storeAlbumIDs[element_num];
      }

    public List< string >  getAlbumIDs()
      {
        Debug.Assert(flagHasAlbumIDs);
        return storeAlbumIDs;
      }


    public virtual int extraMusicVerticalStateComponentCount()
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        return extraKeys.Count;
      }
    public virtual string extraMusicVerticalStateComponentKey(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraKeys[component_num];
      }
    public virtual JSONValue extraMusicVerticalStateComponentValue(int component_num)
      {
        Debug.Assert(extraKeys.Count == extraValues.Count);
        Debug.Assert(component_num < extraValues.Count);
        return extraValues[component_num];
      }
    public virtual JSONValue extraMusicVerticalStateLookup(string field_name)
      {
        JSONValue result = (extraIndex.ContainsKey(field_name) ? extraIndex[field_name] : null);
        return result;
      }
    public override int extraClientVerticalStateComponentCount()
      {
        int result = 0;
        if (flagHasTrackID)
            ++result;
        if (flagHasArtistID)
            ++result;
        if (flagHasAlbumID)
            ++result;
        if (flagHasTrackIDs)
            ++result;
        if (flagHasArtistIDs)
            ++result;
        if (flagHasAlbumIDs)
            ++result;
        result += extraMusicVerticalStateComponentCount();
        return result;
      }
    public override string extraClientVerticalStateComponentKey(int component_num)
      {
        int remainder = component_num;
        if (flagHasTrackID)
          {
            if (remainder == 0)
                return "TrackID";
            --remainder;
          }
        if (flagHasArtistID)
          {
            if (remainder == 0)
                return "ArtistID";
            --remainder;
          }
        if (flagHasAlbumID)
          {
            if (remainder == 0)
                return "AlbumID";
            --remainder;
          }
        if (flagHasTrackIDs)
          {
            if (remainder == 0)
                return "TrackIDs";
            --remainder;
          }
        if (flagHasArtistIDs)
          {
            if (remainder == 0)
                return "ArtistIDs";
            --remainder;
          }
        if (flagHasAlbumIDs)
          {
            if (remainder == 0)
                return "AlbumIDs";
            --remainder;
          }
        return extraMusicVerticalStateComponentKey(remainder);
      }
    public override JSONValue extraClientVerticalStateComponentValue(int component_num)
      {
        int remainder = component_num;
        if (flagHasTrackID)
          {
            if (remainder == 0)
                return extraTrackIDToJSON();
            --remainder;
          }
        if (flagHasArtistID)
          {
            if (remainder == 0)
                return extraArtistIDToJSON();
            --remainder;
          }
        if (flagHasAlbumID)
          {
            if (remainder == 0)
                return extraAlbumIDToJSON();
            --remainder;
          }
        if (flagHasTrackIDs)
          {
            if (remainder == 0)
                return extraTrackIDsToJSON();
            --remainder;
          }
        if (flagHasArtistIDs)
          {
            if (remainder == 0)
                return extraArtistIDsToJSON();
            --remainder;
          }
        if (flagHasAlbumIDs)
          {
            if (remainder == 0)
                return extraAlbumIDsToJSON();
            --remainder;
          }
        return extraMusicVerticalStateComponentValue(remainder);
      }
    public override JSONValue extraClientVerticalStateLookup(string field_name)
      {
        switch (field_name[0])
          {
            case 'A':
                switch (field_name[1])
                  {
                    case 'l':
                        if (String.Compare(field_name, 2, "bumID", 0, 5, false) == 0)
                          {
                            if (field_name.Length == 7)
                              {
                                return (flagHasAlbumID ? extraAlbumIDToJSON() : null);
                              }
                            switch (field_name[7])
                              {
                                case 's':
                                    if (field_name.Length == 8)
                                        return (flagHasAlbumIDs ? extraAlbumIDsToJSON() : null);
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(field_name, 2, "tistID", 0, 6, false) == 0)
                          {
                            if (field_name.Length == 8)
                              {
                                return (flagHasArtistID ? extraArtistIDToJSON() : null);
                              }
                            switch (field_name[8])
                              {
                                case 's':
                                    if (field_name.Length == 9)
                                        return (flagHasArtistIDs ? extraArtistIDsToJSON() : null);
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
                if (String.Compare(field_name, 1, "rackID", 0, 6, false) == 0)
                  {
                    if (field_name.Length == 7)
                      {
                        return (flagHasTrackID ? extraTrackIDToJSON() : null);
                      }
                    switch (field_name[7])
                      {
                        case 's':
                            if (field_name.Length == 8)
                                return (flagHasTrackIDs ? extraTrackIDsToJSON() : null);
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        return extraMusicVerticalStateLookup(field_name);
      }

    public void setTrackID(string new_value)
      {
        flagHasTrackID = true;
        storeTrackID = new_value;
      }
    public void unsetTrackID()
      {
        flagHasTrackID = false;
      }
    public void setArtistID(string new_value)
      {
        flagHasArtistID = true;
        storeArtistID = new_value;
      }
    public void unsetArtistID()
      {
        flagHasArtistID = false;
      }
    public void setAlbumID(string new_value)
      {
        flagHasAlbumID = true;
        storeAlbumID = new_value;
      }
    public void unsetAlbumID()
      {
        flagHasAlbumID = false;
      }
    public void initTrackIDs()
      {
        flagHasTrackIDs = true;
        storeTrackIDs.Clear();
      }
    public void appendTrackIDs(string to_append)
      {
        if (!flagHasTrackIDs)
          {
            flagHasTrackIDs = true;
            storeTrackIDs.Clear();
          }
        Debug.Assert(flagHasTrackIDs);
        storeTrackIDs.Add(to_append);
      }
    public void unsetTrackIDs()
      {
        flagHasTrackIDs = false;
        storeTrackIDs.Clear();
      }
    public void initArtistIDs()
      {
        flagHasArtistIDs = true;
        storeArtistIDs.Clear();
      }
    public void appendArtistIDs(string to_append)
      {
        if (!flagHasArtistIDs)
          {
            flagHasArtistIDs = true;
            storeArtistIDs.Clear();
          }
        Debug.Assert(flagHasArtistIDs);
        storeArtistIDs.Add(to_append);
      }
    public void unsetArtistIDs()
      {
        flagHasArtistIDs = false;
        storeArtistIDs.Clear();
      }
    public void initAlbumIDs()
      {
        flagHasAlbumIDs = true;
        storeAlbumIDs.Clear();
      }
    public void appendAlbumIDs(string to_append)
      {
        if (!flagHasAlbumIDs)
          {
            flagHasAlbumIDs = true;
            storeAlbumIDs.Clear();
          }
        Debug.Assert(flagHasAlbumIDs);
        storeAlbumIDs.Add(to_append);
      }
    public void unsetAlbumIDs()
      {
        flagHasAlbumIDs = false;
        storeAlbumIDs.Clear();
      }

    public virtual void extraMusicVerticalStateAppendPair(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        Debug.Assert(extraKeys.Count == extraValues.Count);
        extraKeys.Add(key);
        extraValues.Add(new_component);
        extraIndex.Add(key, new_component);
      }
    public virtual void extraMusicVerticalStateSetField(string key, JSONValue new_component)
      {
        Debug.Assert(key != null);
        Debug.Assert(new_component != null);

        JSONValue old_field = extraMusicVerticalStateLookup(key);
        if (old_field == null)
          {
            extraMusicVerticalStateAppendPair(key, new_component);
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
    public override void extraClientVerticalStateAppendPair(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        if (String.Compare(key, 2, "bumID", 0, 5, false) == 0)
                          {
                            if (key.Length == 7)
                              {
                                {
                                fromJSONAlbumID(new_component, false);
                                return;
                                }
                              }
                            switch (key[7])
                              {
                                case 's':
                                    if (key.Length == 8)
                                        {
                                        fromJSONAlbumIDs(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(key, 2, "tistID", 0, 6, false) == 0)
                          {
                            if (key.Length == 8)
                              {
                                {
                                fromJSONArtistID(new_component, false);
                                return;
                                }
                              }
                            switch (key[8])
                              {
                                case 's':
                                    if (key.Length == 9)
                                        {
                                        fromJSONArtistIDs(new_component, false);
                                        return;
                                        }
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
                if (String.Compare(key, 1, "rackID", 0, 6, false) == 0)
                  {
                    if (key.Length == 7)
                      {
                        {
                        fromJSONTrackID(new_component, false);
                        return;
                        }
                      }
                    switch (key[7])
                      {
                        case 's':
                            if (key.Length == 8)
                                {
                                fromJSONTrackIDs(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraMusicVerticalStateAppendPair(key, new_component);
      }
    public override void extraClientVerticalStateSetField(string key, JSONValue new_component)
      {
        switch (key[0])
          {
            case 'A':
                switch (key[1])
                  {
                    case 'l':
                        if (String.Compare(key, 2, "bumID", 0, 5, false) == 0)
                          {
                            if (key.Length == 7)
                              {
                                {
                                fromJSONAlbumID(new_component, false);
                                return;
                                }
                              }
                            switch (key[7])
                              {
                                case 's':
                                    if (key.Length == 8)
                                        {
                                        fromJSONAlbumIDs(new_component, false);
                                        return;
                                        }
                                    break;
                                default:
                                    break;
                              }
                          }
                        break;
                    case 'r':
                        if (String.Compare(key, 2, "tistID", 0, 6, false) == 0)
                          {
                            if (key.Length == 8)
                              {
                                {
                                fromJSONArtistID(new_component, false);
                                return;
                                }
                              }
                            switch (key[8])
                              {
                                case 's':
                                    if (key.Length == 9)
                                        {
                                        fromJSONArtistIDs(new_component, false);
                                        return;
                                        }
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
                if (String.Compare(key, 1, "rackID", 0, 6, false) == 0)
                  {
                    if (key.Length == 7)
                      {
                        {
                        fromJSONTrackID(new_component, false);
                        return;
                        }
                      }
                    switch (key[7])
                      {
                        case 's':
                            if (key.Length == 8)
                                {
                                fromJSONTrackIDs(new_component, false);
                                return;
                                }
                            break;
                        default:
                            break;
                      }
                  }
                break;
            default:
                break;
          }
        extraMusicVerticalStateSetField(key, new_component);
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

    public override void write_fields_as_json(JSONHandler handler)
      {
        write_fields_as_json(handler, false);
      }

    public override void write_fields_as_json(JSONHandler handler, bool partial_allowed)
      {
        base.write_fields_as_json(handler, partial_allowed);
        if (flagHasTrackID)
          {
            handler.start_pair("TrackID");
            handler.string_value(storeTrackID);
          }
        if (flagHasArtistID)
          {
            handler.start_pair("ArtistID");
            handler.string_value(storeArtistID);
          }
        if (flagHasAlbumID)
          {
            handler.start_pair("AlbumID");
            handler.string_value(storeAlbumID);
          }
        if (flagHasTrackIDs)
          {
            handler.start_pair("TrackIDs");
            handler.start_array();
            for (int num1 = 0; num1 < storeTrackIDs.Count; ++num1)
              {
                handler.string_value(storeTrackIDs[num1]);
              }
            handler.finish_array();
          }
        if (flagHasArtistIDs)
          {
            handler.start_pair("ArtistIDs");
            handler.start_array();
            for (int num2 = 0; num2 < storeArtistIDs.Count; ++num2)
              {
                handler.string_value(storeArtistIDs[num2]);
              }
            handler.finish_array();
          }
        if (flagHasAlbumIDs)
          {
            handler.start_pair("AlbumIDs");
            handler.start_array();
            for (int num3 = 0; num3 < storeAlbumIDs.Count; ++num3)
              {
                handler.string_value(storeAlbumIDs[num3]);
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
    public override string missing_field_error(bool allow_unpolished)
      {
        return null;
      }

    public static new MusicVerticalStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicVerticalStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicVerticalState", ignore_extras);
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
    public static new MusicVerticalStateJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicVerticalStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicVerticalStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicVerticalState", ignore_extras);
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
    public static new MusicVerticalStateJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static new MusicVerticalStateJSON from_text(string text, bool ignore_extras)
      {
        MusicVerticalStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicVerticalState", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicVerticalStateJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static new MusicVerticalStateJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicVerticalStateJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicVerticalState", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public new abstract class Generator : ClientVerticalStateJSON.Generator
      {
        private JSONHoldingStringGenerator fieldGeneratorTrackID;
        private JSONHoldingStringGenerator fieldGeneratorArtistID;
        private JSONHoldingStringGenerator fieldGeneratorAlbumID;
        private JSONHoldingStringArrayGenerator fieldGeneratorTrackIDs;
        private JSONHoldingStringArrayGenerator fieldGeneratorArtistIDs;
        private JSONHoldingStringArrayGenerator fieldGeneratorAlbumIDs;
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
            if (!(getClientVerticalStateJSONKey().Equals("MusicVerticalState")))
                throw new Exception("The key field has a value other than `MusicVerticalState'.");
            MusicVerticalStateJSON result = new MusicVerticalStateJSON();
            Debug.Assert(result != null);
            finish(result);
            int extra_count = unknownFieldGenerator.field_names.Count;
            Debug.Assert(extra_count == unknownFieldGenerator.field_values.Count);
            for (int extra_num = 0; extra_num < extra_count; ++extra_num)
              {
                result.extraMusicVerticalStateAppendPair(unknownFieldGenerator.field_names[extra_num], unknownFieldGenerator.field_values[extra_num]);
              }
            unknownFieldGenerator.field_names.Clear();
            unknownFieldGenerator.field_values.Clear();
            unknownFieldGenerator.index = new Dictionary<string, JSONValue >();
            handle_result(result);
          }
        protected override void handle_result(ClientVerticalStateJSON new_result)
          {
            handle_result((MusicVerticalStateJSON )new_result);
          }
        protected void finish(MusicVerticalStateJSON result)
          {
            if (fieldGeneratorTrackID.have_value)
              {
                result.setTrackID(fieldGeneratorTrackID.value);
                fieldGeneratorTrackID.have_value = false;
              }
            if (fieldGeneratorArtistID.have_value)
              {
                result.setArtistID(fieldGeneratorArtistID.value);
                fieldGeneratorArtistID.have_value = false;
              }
            if (fieldGeneratorAlbumID.have_value)
              {
                result.setAlbumID(fieldGeneratorAlbumID.value);
                fieldGeneratorAlbumID.have_value = false;
              }
            if (fieldGeneratorTrackIDs.have_value)
              {
                result.initTrackIDs();
                int count = fieldGeneratorTrackIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendTrackIDs(fieldGeneratorTrackIDs.value[num]);
                  }
                fieldGeneratorTrackIDs.value.Clear();
                fieldGeneratorTrackIDs.have_value = false;
              }
            if (fieldGeneratorArtistIDs.have_value)
              {
                result.initArtistIDs();
                int count = fieldGeneratorArtistIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendArtistIDs(fieldGeneratorArtistIDs.value[num]);
                  }
                fieldGeneratorArtistIDs.value.Clear();
                fieldGeneratorArtistIDs.have_value = false;
              }
            if (fieldGeneratorAlbumIDs.have_value)
              {
                result.initAlbumIDs();
                int count = fieldGeneratorAlbumIDs.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendAlbumIDs(fieldGeneratorAlbumIDs.value[num]);
                  }
                fieldGeneratorAlbumIDs.value.Clear();
                fieldGeneratorAlbumIDs.have_value = false;
              }
            base.finish(result);
          }
        protected abstract void handle_result(MusicVerticalStateJSON new_result);
        protected override JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    switch (field_name[1])
                      {
                        case 'l':
                            if (String.Compare(field_name, 2, "bumID", 0, 5, false) == 0)
                              {
                                if (field_name.Length == 7)
                                  {
                                    return fieldGeneratorAlbumID;
                                  }
                                switch (field_name[7])
                                  {
                                    case 's':
                                        if (field_name.Length == 8)
                                            return fieldGeneratorAlbumIDs;
                                        break;
                                    default:
                                        break;
                                  }
                              }
                            break;
                        case 'r':
                            if (String.Compare(field_name, 2, "tistID", 0, 6, false) == 0)
                              {
                                if (field_name.Length == 8)
                                  {
                                    return fieldGeneratorArtistID;
                                  }
                                switch (field_name[8])
                                  {
                                    case 's':
                                        if (field_name.Length == 9)
                                            return fieldGeneratorArtistIDs;
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
                    if (String.Compare(field_name, 1, "rackID", 0, 6, false) == 0)
                      {
                        if (field_name.Length == 7)
                          {
                            return fieldGeneratorTrackID;
                          }
                        switch (field_name[7])
                          {
                            case 's':
                                if (field_name.Length == 8)
                                    return fieldGeneratorTrackIDs;
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
            fieldGeneratorTrackID = new JSONHoldingStringGenerator("field \"TrackID\" of the MusicVerticalState class");
            fieldGeneratorArtistID = new JSONHoldingStringGenerator("field \"ArtistID\" of the MusicVerticalState class");
            fieldGeneratorAlbumID = new JSONHoldingStringGenerator("field \"AlbumID\" of the MusicVerticalState class");
            fieldGeneratorTrackIDs = new JSONHoldingStringArrayGenerator("field \"TrackIDs\" of the MusicVerticalState class");
            fieldGeneratorArtistIDs = new JSONHoldingStringArrayGenerator("field \"ArtistIDs\" of the MusicVerticalState class");
            fieldGeneratorAlbumIDs = new JSONHoldingStringArrayGenerator("field \"AlbumIDs\" of the MusicVerticalState class");
            unknownFieldGenerator = new UnknownFieldGenerator(ignore_extras);
            set_what("the MusicVerticalState class");
          }
        public Generator() : base(false)
          {
            fieldGeneratorTrackID = new JSONHoldingStringGenerator("field \"TrackID\" of the MusicVerticalState class");
            fieldGeneratorArtistID = new JSONHoldingStringGenerator("field \"ArtistID\" of the MusicVerticalState class");
            fieldGeneratorAlbumID = new JSONHoldingStringGenerator("field \"AlbumID\" of the MusicVerticalState class");
            fieldGeneratorTrackIDs = new JSONHoldingStringArrayGenerator("field \"TrackIDs\" of the MusicVerticalState class");
            fieldGeneratorArtistIDs = new JSONHoldingStringArrayGenerator("field \"ArtistIDs\" of the MusicVerticalState class");
            fieldGeneratorAlbumIDs = new JSONHoldingStringArrayGenerator("field \"AlbumIDs\" of the MusicVerticalState class");
            unknownFieldGenerator = new UnknownFieldGenerator(false);
            set_what("the MusicVerticalState class");
          }

        public override void reset()
          {
            fieldGeneratorTrackID.reset();
            fieldGeneratorArtistID.reset();
            fieldGeneratorAlbumID.reset();
            fieldGeneratorTrackIDs.reset();
            fieldGeneratorArtistIDs.reset();
            fieldGeneratorAlbumIDs.reset();
            base.reset();
            unknownFieldGenerator.reset();
          }
      };
    public new class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicVerticalStateJSON  result)
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
        public MusicVerticalStateJSON value;
      };
    public new class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicVerticalStateJSON  result)
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
    protected virtual void handle_result(List<MusicVerticalStateJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicVerticalStateJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicVerticalStateJSON>();
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
    public List<MusicVerticalStateJSON> value;
  };
  };
