/* file "MusicArtistBaseJSON.cs" */

/* Generated automatically by Classy JSON. */


using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;


public class MusicArtistBaseJSON : JSONBase
  {
    public enum TypeArtistTypeKnownValues
      {
        ArtistType_Individual,
        ArtistType_Group,
        ArtistType__none
      };
    public struct TypeArtistType
      {
        public bool in_known_list;
        public string string_value;
        public TypeArtistTypeKnownValues list_value;
      };

    public static TypeArtistTypeKnownValues  stringToArtistType(string chars)
      {
        switch (chars[0])
          {
            case 'G':
                if ((String.Compare(chars, 1, "roup", 0, 4, false) == 0) && (chars.Length == 5))
                    return TypeArtistTypeKnownValues.ArtistType_Group;
                break;
            case 'I':
                if ((String.Compare(chars, 1, "ndividual", 0, 9, false) == 0) && (chars.Length == 10))
                    return TypeArtistTypeKnownValues.ArtistType_Individual;
                break;
            default:
                break;
          }
        return TypeArtistTypeKnownValues.ArtistType__none;
      }

    public static string  stringFromArtistType(TypeArtistTypeKnownValues the_enum)
      {
        switch (the_enum)
          {
            case TypeArtistTypeKnownValues.ArtistType_Individual:
                return "Individual";
            case TypeArtistTypeKnownValues.ArtistType_Group:
                return "Group";
            default:
                Debug.Assert(false);
                return null;
          }
      }

    private bool flagHasArtistID;
    private SoundHoundArtistIDJSON  storeArtistID;
    private bool flagHasArtistName;
    private string storeArtistName;
    private bool flagHasArtistImageURL;
    private string storeArtistImageURL;
    private bool flagHasBiography;
    private string storeBiography;
    private bool flagHasBirthPlace;
    private string storeBirthPlace;
    private bool flagHasBirthDate;
    private string storeBirthDate;
    private bool flagHasDeathPlace;
    private string storeDeathPlace;
    private bool flagHasDeathDate;
    private string storeDeathDate;
    private bool flagHasArtistType;
    private TypeArtistType storeArtistType;
    private bool flagHasBuyLinks;
    private List< MusicBuyLinkJSON  > storeBuyLinks;
    private bool flagHasMusicThirdPartyIds;
    private List< MusicThirdPartyIdListJSON  > storeMusicThirdPartyIds;
    private bool flagHasStyles;
    private List< string > storeStyles;
    private bool flagHasEarliestTrack;
    private MusicTrackBaseJSON  storeEarliestTrack;
    private bool flagHasLatestTrack;
    private MusicTrackBaseJSON  storeLatestTrack;
    private bool flagHasEarliestAlbum;
    private MusicAlbumBaseJSON  storeEarliestAlbum;
    private bool flagHasLatestAlbum;
    private MusicAlbumBaseJSON  storeLatestAlbum;


    private void  fromJSONArtistID(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        SoundHoundArtistIDJSON convert_classy = SoundHoundArtistIDJSON.from_json(json_value, ignore_extras, true);
        setArtistID(convert_classy);
      }


    private void  fromJSONArtistName(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ArtistName of MusicArtistBaseJSON is not a string.");
        setArtistName(json_string.getData());
      }


    private void  fromJSONArtistImageURL(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ArtistImageURL of MusicArtistBaseJSON is not a string.");
        setArtistImageURL(json_string.getData());
      }


    private void  fromJSONBiography(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field Biography of MusicArtistBaseJSON is not a string.");
        setBiography(json_string.getData());
      }


    private void  fromJSONBirthPlace(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BirthPlace of MusicArtistBaseJSON is not a string.");
        setBirthPlace(json_string.getData());
      }


    private void  fromJSONBirthDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field BirthDate of MusicArtistBaseJSON is not a string.");
        setBirthDate(json_string.getData());
      }


    private void  fromJSONDeathPlace(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DeathPlace of MusicArtistBaseJSON is not a string.");
        setDeathPlace(json_string.getData());
      }


    private void  fromJSONDeathDate(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field DeathDate of MusicArtistBaseJSON is not a string.");
        setDeathDate(json_string.getData());
      }


    private void  fromJSONArtistType(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONStringValue json_string = json_value.string_value();
        if (json_string == null)
            throw new Exception("The value for field ArtistType of MusicArtistBaseJSON is not a string.");
        TypeArtistType the_open_enum = new TypeArtistType();
        switch (json_string.getData()[0])
          {
            case 'G':
                if ((String.Compare(json_string.getData(), 1, "roup", 0, 4, false) == 0) && (json_string.getData().Length == 5))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeArtistTypeKnownValues.ArtistType_Group;
                        goto open_enum_is_done;
                      }
                break;
            case 'I':
                if ((String.Compare(json_string.getData(), 1, "ndividual", 0, 9, false) == 0) && (json_string.getData().Length == 10))
                      {
                        the_open_enum.in_known_list = true;
                        the_open_enum.list_value = TypeArtistTypeKnownValues.ArtistType_Individual;
                        goto open_enum_is_done;
                      }
                break;
            default:
                break;
          }
        the_open_enum.in_known_list = false;
        the_open_enum.string_value = json_string.getData();
      open_enum_is_done:;
        setArtistType(the_open_enum);
      }


    private void  fromJSONBuyLinks(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field BuyLinks of MusicArtistBaseJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field BuyLinks of MusicArtistBaseJSON has too few elements.");
        List< MusicBuyLinkJSON  > vector_BuyLinks1 = new List< MusicBuyLinkJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicBuyLinkJSON convert_classy = MusicBuyLinkJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_BuyLinks1.Add(convert_classy);
          }
        Debug.Assert(vector_BuyLinks1.Count >= 1);
        initBuyLinks();
        for (int num1 = 0; num1 < vector_BuyLinks1.Count; ++num1)
            appendBuyLinks(vector_BuyLinks1[num1]);
        for (int num1 = 0; num1 < vector_BuyLinks1.Count; ++num1)
          {
          }
      }


    private void  fromJSONMusicThirdPartyIds(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field MusicThirdPartyIds of MusicArtistBaseJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field MusicThirdPartyIds of MusicArtistBaseJSON has too few elements.");
        List< MusicThirdPartyIdListJSON  > vector_MusicThirdPartyIds1 = new List< MusicThirdPartyIdListJSON  >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            MusicThirdPartyIdListJSON convert_classy = MusicThirdPartyIdListJSON.from_json(json_array1.component(num1), ignore_extras, true);
            vector_MusicThirdPartyIds1.Add(convert_classy);
          }
        Debug.Assert(vector_MusicThirdPartyIds1.Count >= 1);
        initMusicThirdPartyIds();
        for (int num2 = 0; num2 < vector_MusicThirdPartyIds1.Count; ++num2)
            appendMusicThirdPartyIds(vector_MusicThirdPartyIds1[num2]);
        for (int num1 = 0; num1 < vector_MusicThirdPartyIds1.Count; ++num1)
          {
          }
      }


    private void  fromJSONStyles(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        JSONArrayValue json_array1 = json_value.array_value();
        if (json_array1 == null)
            throw new Exception("The value for field Styles of MusicArtistBaseJSON is not an array.");
        int count1 = json_array1.componentCount();
        if (count1 < 1)
            throw new Exception("The value for field Styles of MusicArtistBaseJSON has too few elements.");
        List< string > vector_Styles1 = new List< string >(count1);
        for (int num1 = 0; num1 < count1; ++num1)
          {
            JSONStringValue json_string = json_array1.component(num1).string_value();
            if (json_string == null)
                throw new Exception("The value for an element of field Styles of MusicArtistBaseJSON is not a string.");
            vector_Styles1.Add(json_string.getData());
          }
        Debug.Assert(vector_Styles1.Count >= 1);
        initStyles();
        for (int num3 = 0; num3 < vector_Styles1.Count; ++num3)
            appendStyles(vector_Styles1[num3]);
        for (int num1 = 0; num1 < vector_Styles1.Count; ++num1)
          {
          }
      }


    private void  fromJSONEarliestTrack(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicTrackBaseJSON convert_classy = MusicTrackBaseJSON.from_json(json_value, ignore_extras, true);
        setEarliestTrack(convert_classy);
      }


    private void  fromJSONLatestTrack(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicTrackBaseJSON convert_classy = MusicTrackBaseJSON.from_json(json_value, ignore_extras, true);
        setLatestTrack(convert_classy);
      }


    private void  fromJSONEarliestAlbum(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicAlbumBaseJSON convert_classy = MusicAlbumBaseJSON.from_json(json_value, ignore_extras, true);
        setEarliestAlbum(convert_classy);
      }


    private void  fromJSONLatestAlbum(JSONValue json_value, bool ignore_extras)
      {
        Debug.Assert(json_value != null);
        MusicAlbumBaseJSON convert_classy = MusicAlbumBaseJSON.from_json(json_value, ignore_extras, true);
        setLatestAlbum(convert_classy);
      }


    public MusicArtistBaseJSON()
      {
        flagHasArtistID = false;
        flagHasArtistName = false;
        flagHasArtistImageURL = false;
        flagHasBiography = false;
        flagHasBirthPlace = false;
        flagHasBirthDate = false;
        flagHasDeathPlace = false;
        flagHasDeathDate = false;
        flagHasArtistType = false;
        flagHasBuyLinks = false;
        flagHasMusicThirdPartyIds = false;
        flagHasStyles = false;
        flagHasEarliestTrack = false;
        flagHasLatestTrack = false;
        flagHasEarliestAlbum = false;
        flagHasLatestAlbum = false;
        storeBuyLinks = new List< MusicBuyLinkJSON  >();
        storeMusicThirdPartyIds = new List< MusicThirdPartyIdListJSON  >();
        storeStyles = new List< string >();
      }

    public bool  hasArtistID()
      {
        return flagHasArtistID;
      }

    public SoundHoundArtistIDJSON   getArtistID()
      {
        Debug.Assert(flagHasArtistID);
        return storeArtistID;
      }

    public long  getArtistIDValue()
      {
        return getArtistID().getValue();
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

    public bool  hasArtistImageURL()
      {
        return flagHasArtistImageURL;
      }

    public string  getArtistImageURL()
      {
        Debug.Assert(flagHasArtistImageURL);
        return storeArtistImageURL;
      }

    public bool  hasBiography()
      {
        return flagHasBiography;
      }

    public string  getBiography()
      {
        Debug.Assert(flagHasBiography);
        return storeBiography;
      }

    public bool  hasBirthPlace()
      {
        return flagHasBirthPlace;
      }

    public string  getBirthPlace()
      {
        Debug.Assert(flagHasBirthPlace);
        return storeBirthPlace;
      }

    public bool  hasBirthDate()
      {
        return flagHasBirthDate;
      }

    public string  getBirthDate()
      {
        Debug.Assert(flagHasBirthDate);
        return storeBirthDate;
      }

    public bool  hasDeathPlace()
      {
        return flagHasDeathPlace;
      }

    public string  getDeathPlace()
      {
        Debug.Assert(flagHasDeathPlace);
        return storeDeathPlace;
      }

    public bool  hasDeathDate()
      {
        return flagHasDeathDate;
      }

    public string  getDeathDate()
      {
        Debug.Assert(flagHasDeathDate);
        return storeDeathDate;
      }

    public bool  hasArtistType()
      {
        return flagHasArtistType;
      }

    public TypeArtistType  getArtistType()
      {
        Debug.Assert(flagHasArtistType);
        return storeArtistType;
      }

    public string  getArtistTypeAsString()
      {
        TypeArtistType result = getArtistType();
        if (result.in_known_list)
            return stringFromArtistType(result.list_value);
        else
            return result.string_value;
      }

    public bool  hasBuyLinks()
      {
        return flagHasBuyLinks;
      }

    public int  countOfBuyLinks()
      {
        Debug.Assert(flagHasBuyLinks);
        return storeBuyLinks.Count;
      }

    public MusicBuyLinkJSON   elementOfBuyLinks(int element_num)
      {
        Debug.Assert(flagHasBuyLinks);
        return storeBuyLinks[element_num];
      }

    public List< MusicBuyLinkJSON  >  getBuyLinks()
      {
        Debug.Assert(flagHasBuyLinks);
        return storeBuyLinks;
      }

    public bool  hasMusicThirdPartyIds()
      {
        return flagHasMusicThirdPartyIds;
      }

    public int  countOfMusicThirdPartyIds()
      {
        Debug.Assert(flagHasMusicThirdPartyIds);
        return storeMusicThirdPartyIds.Count;
      }

    public MusicThirdPartyIdListJSON   elementOfMusicThirdPartyIds(int element_num)
      {
        Debug.Assert(flagHasMusicThirdPartyIds);
        return storeMusicThirdPartyIds[element_num];
      }

    public List< MusicThirdPartyIdListJSON  >  getMusicThirdPartyIds()
      {
        Debug.Assert(flagHasMusicThirdPartyIds);
        return storeMusicThirdPartyIds;
      }

    public bool  hasStyles()
      {
        return flagHasStyles;
      }

    public int  countOfStyles()
      {
        Debug.Assert(flagHasStyles);
        return storeStyles.Count;
      }

    public string  elementOfStyles(int element_num)
      {
        Debug.Assert(flagHasStyles);
        return storeStyles[element_num];
      }

    public List< string >  getStyles()
      {
        Debug.Assert(flagHasStyles);
        return storeStyles;
      }

    public bool  hasEarliestTrack()
      {
        return flagHasEarliestTrack;
      }

    public MusicTrackBaseJSON   getEarliestTrack()
      {
        Debug.Assert(flagHasEarliestTrack);
        return storeEarliestTrack;
      }

    public bool  hasLatestTrack()
      {
        return flagHasLatestTrack;
      }

    public MusicTrackBaseJSON   getLatestTrack()
      {
        Debug.Assert(flagHasLatestTrack);
        return storeLatestTrack;
      }

    public bool  hasEarliestAlbum()
      {
        return flagHasEarliestAlbum;
      }

    public MusicAlbumBaseJSON   getEarliestAlbum()
      {
        Debug.Assert(flagHasEarliestAlbum);
        return storeEarliestAlbum;
      }

    public bool  hasLatestAlbum()
      {
        return flagHasLatestAlbum;
      }

    public MusicAlbumBaseJSON   getLatestAlbum()
      {
        Debug.Assert(flagHasLatestAlbum);
        return storeLatestAlbum;
      }



    public void setArtistID(SoundHoundArtistIDJSON  new_value)
      {
        if (flagHasArtistID)
          {
          }
        flagHasArtistID = true;
        storeArtistID = new_value;
      }
    public void setArtistID(long new_value)
      {
        setArtistID(new SoundHoundArtistIDJSON(new_value));
      }
    public void unsetArtistID()
      {
        if (flagHasArtistID)
          {
          }
        flagHasArtistID = false;
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
    public void setArtistImageURL(string new_value)
      {
        flagHasArtistImageURL = true;
        storeArtistImageURL = new_value;
      }
    public void unsetArtistImageURL()
      {
        flagHasArtistImageURL = false;
      }
    public void setBiography(string new_value)
      {
        flagHasBiography = true;
        storeBiography = new_value;
      }
    public void unsetBiography()
      {
        flagHasBiography = false;
      }
    public void setBirthPlace(string new_value)
      {
        flagHasBirthPlace = true;
        storeBirthPlace = new_value;
      }
    public void unsetBirthPlace()
      {
        flagHasBirthPlace = false;
      }
    public void setBirthDate(string new_value)
      {
        flagHasBirthDate = true;
        storeBirthDate = new_value;
      }
    public void unsetBirthDate()
      {
        flagHasBirthDate = false;
      }
    public void setDeathPlace(string new_value)
      {
        flagHasDeathPlace = true;
        storeDeathPlace = new_value;
      }
    public void unsetDeathPlace()
      {
        flagHasDeathPlace = false;
      }
    public void setDeathDate(string new_value)
      {
        flagHasDeathDate = true;
        storeDeathDate = new_value;
      }
    public void unsetDeathDate()
      {
        flagHasDeathDate = false;
      }
    public void setArtistType(TypeArtistType new_value)
      {
        flagHasArtistType = true;
        storeArtistType = new_value;
      }
    public void setArtistType(string chars)
      {
        TypeArtistTypeKnownValues known = stringToArtistType(chars);
        TypeArtistType new_value = new TypeArtistType();
        if (known == TypeArtistTypeKnownValues.ArtistType__none)
          {
            new_value.in_known_list = false;
            new_value.string_value = chars;
          }
        else
          {
            new_value.in_known_list = true;
            new_value.list_value = known;
          }
        setArtistType(new_value);
      }
    public void setArtistType(TypeArtistTypeKnownValues new_value)
      {
        TypeArtistType new_full_value = new TypeArtistType();
        Debug.Assert(new_value != TypeArtistTypeKnownValues.ArtistType__none);
        new_full_value.in_known_list = true;
        new_full_value.list_value = new_value;
        setArtistType(new_full_value);
      }
    public void unsetArtistType()
      {
        flagHasArtistType = false;
      }
    public void initBuyLinks()
      {
        if (flagHasBuyLinks)
          {
            for (int num1 = 0; num1 < storeBuyLinks.Count; ++num1)
              {
              }
          }
        flagHasBuyLinks = true;
        storeBuyLinks.Clear();
      }
    public void appendBuyLinks(MusicBuyLinkJSON  to_append)
      {
        if (!flagHasBuyLinks)
          {
            flagHasBuyLinks = true;
            storeBuyLinks.Clear();
          }
        Debug.Assert(flagHasBuyLinks);
        storeBuyLinks.Add(to_append);
      }
    public void unsetBuyLinks()
      {
        if (flagHasBuyLinks)
          {
            for (int num2 = 0; num2 < storeBuyLinks.Count; ++num2)
              {
              }
          }
        flagHasBuyLinks = false;
        storeBuyLinks.Clear();
      }
    public void initMusicThirdPartyIds()
      {
        if (flagHasMusicThirdPartyIds)
          {
            for (int num3 = 0; num3 < storeMusicThirdPartyIds.Count; ++num3)
              {
              }
          }
        flagHasMusicThirdPartyIds = true;
        storeMusicThirdPartyIds.Clear();
      }
    public void appendMusicThirdPartyIds(MusicThirdPartyIdListJSON  to_append)
      {
        if (!flagHasMusicThirdPartyIds)
          {
            flagHasMusicThirdPartyIds = true;
            storeMusicThirdPartyIds.Clear();
          }
        Debug.Assert(flagHasMusicThirdPartyIds);
        storeMusicThirdPartyIds.Add(to_append);
      }
    public void unsetMusicThirdPartyIds()
      {
        if (flagHasMusicThirdPartyIds)
          {
            for (int num4 = 0; num4 < storeMusicThirdPartyIds.Count; ++num4)
              {
              }
          }
        flagHasMusicThirdPartyIds = false;
        storeMusicThirdPartyIds.Clear();
      }
    public void initStyles()
      {
        flagHasStyles = true;
        storeStyles.Clear();
      }
    public void appendStyles(string to_append)
      {
        if (!flagHasStyles)
          {
            flagHasStyles = true;
            storeStyles.Clear();
          }
        Debug.Assert(flagHasStyles);
        storeStyles.Add(to_append);
      }
    public void unsetStyles()
      {
        flagHasStyles = false;
        storeStyles.Clear();
      }
    public void setEarliestTrack(MusicTrackBaseJSON  new_value)
      {
        if (flagHasEarliestTrack)
          {
          }
        flagHasEarliestTrack = true;
        storeEarliestTrack = new_value;
      }
    public void unsetEarliestTrack()
      {
        if (flagHasEarliestTrack)
          {
          }
        flagHasEarliestTrack = false;
      }
    public void setLatestTrack(MusicTrackBaseJSON  new_value)
      {
        if (flagHasLatestTrack)
          {
          }
        flagHasLatestTrack = true;
        storeLatestTrack = new_value;
      }
    public void unsetLatestTrack()
      {
        if (flagHasLatestTrack)
          {
          }
        flagHasLatestTrack = false;
      }
    public void setEarliestAlbum(MusicAlbumBaseJSON  new_value)
      {
        if (flagHasEarliestAlbum)
          {
          }
        flagHasEarliestAlbum = true;
        storeEarliestAlbum = new_value;
      }
    public void unsetEarliestAlbum()
      {
        if (flagHasEarliestAlbum)
          {
          }
        flagHasEarliestAlbum = false;
      }
    public void setLatestAlbum(MusicAlbumBaseJSON  new_value)
      {
        if (flagHasLatestAlbum)
          {
          }
        flagHasLatestAlbum = true;
        storeLatestAlbum = new_value;
      }
    public void unsetLatestAlbum()
      {
        if (flagHasLatestAlbum)
          {
          }
        flagHasLatestAlbum = false;
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
        if (flagHasArtistID)
          {
            handler.start_pair("ArtistID");
            if (partial_allowed)
                storeArtistID.write_partial_as_json(handler);
            else
                storeArtistID.write_as_json(handler);
          }
        if (flagHasArtistName)
          {
            handler.start_pair("ArtistName");
            handler.string_value(storeArtistName);
          }
        if (flagHasArtistImageURL)
          {
            handler.start_pair("ArtistImageURL");
            handler.string_value(storeArtistImageURL);
          }
        if (flagHasBiography)
          {
            handler.start_pair("Biography");
            handler.string_value(storeBiography);
          }
        if (flagHasBirthPlace)
          {
            handler.start_pair("BirthPlace");
            handler.string_value(storeBirthPlace);
          }
        if (flagHasBirthDate)
          {
            handler.start_pair("BirthDate");
            handler.string_value(storeBirthDate);
          }
        if (flagHasDeathPlace)
          {
            handler.start_pair("DeathPlace");
            handler.string_value(storeDeathPlace);
          }
        if (flagHasDeathDate)
          {
            handler.start_pair("DeathDate");
            handler.string_value(storeDeathDate);
          }
        if (flagHasArtistType)
          {
            handler.start_pair("ArtistType");
            if (storeArtistType.in_known_list)
              {
                switch (storeArtistType.list_value)
                  {
                    case TypeArtistTypeKnownValues.ArtistType_Individual:
                        handler.string_value("Individual");
                        break;
                    case TypeArtistTypeKnownValues.ArtistType_Group:
                        handler.string_value("Group");
                        break;
                    default:
                        Debug.Assert(false);
                        break;
                  }
              }
            else
              {
                        handler.string_value(storeArtistType.string_value);
              }
          }
        if (flagHasBuyLinks)
          {
            handler.start_pair("BuyLinks");
            Debug.Assert(storeBuyLinks.Count >= 1);
            handler.start_array();
            for (int num1 = 0; num1 < storeBuyLinks.Count; ++num1)
              {
                if (partial_allowed)
                    storeBuyLinks[num1].write_partial_as_json(handler);
                else
                    storeBuyLinks[num1].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasMusicThirdPartyIds)
          {
            handler.start_pair("MusicThirdPartyIds");
            Debug.Assert(storeMusicThirdPartyIds.Count >= 1);
            handler.start_array();
            for (int num2 = 0; num2 < storeMusicThirdPartyIds.Count; ++num2)
              {
                if (partial_allowed)
                    storeMusicThirdPartyIds[num2].write_partial_as_json(handler);
                else
                    storeMusicThirdPartyIds[num2].write_as_json(handler);
              }
            handler.finish_array();
          }
        if (flagHasStyles)
          {
            handler.start_pair("Styles");
            Debug.Assert(storeStyles.Count >= 1);
            handler.start_array();
            for (int num3 = 0; num3 < storeStyles.Count; ++num3)
              {
                handler.string_value(storeStyles[num3]);
              }
            handler.finish_array();
          }
        if (flagHasEarliestTrack)
          {
            handler.start_pair("EarliestTrack");
            if (partial_allowed)
                storeEarliestTrack.write_partial_as_json(handler);
            else
                storeEarliestTrack.write_as_json(handler);
          }
        if (flagHasLatestTrack)
          {
            handler.start_pair("LatestTrack");
            if (partial_allowed)
                storeLatestTrack.write_partial_as_json(handler);
            else
                storeLatestTrack.write_as_json(handler);
          }
        if (flagHasEarliestAlbum)
          {
            handler.start_pair("EarliestAlbum");
            if (partial_allowed)
                storeEarliestAlbum.write_partial_as_json(handler);
            else
                storeEarliestAlbum.write_as_json(handler);
          }
        if (flagHasLatestAlbum)
          {
            handler.start_pair("LatestAlbum");
            if (partial_allowed)
                storeLatestAlbum.write_partial_as_json(handler);
            else
                storeLatestAlbum.write_as_json(handler);
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
        return null;
      }

    public static MusicArtistBaseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicArtistBaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicArtistBase", ignore_extras);
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
    public static MusicArtistBaseJSON from_json(JSONValue json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicArtistBaseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete, bool allow_unpolished)
      {
        MusicArtistBaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicArtistBase", ignore_extras);
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
    public static MusicArtistBaseJSON from_json(JSONBase json_value, bool ignore_extras, bool allow_incomplete)
  {
    return from_json(json_value, ignore_extras, allow_incomplete, false);
  }
    public static MusicArtistBaseJSON from_text(string text, bool ignore_extras)
      {
        MusicArtistBaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicArtistBase", ignore_extras);
            JSONParse.parse_json_value(text, "Text for MusicArtistBaseJSON", generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public static MusicArtistBaseJSON from_file(TextReader fp, string file_name, bool ignore_extras)
      {
        MusicArtistBaseJSON result;
          {
            HoldingGenerator generator = new HoldingGenerator("Type MusicArtistBase", ignore_extras);
            JSONParse.parse_json_value(fp, file_name, generator);
            Debug.Assert(generator.have_value);
            result = generator.value;
          };
        return result;
      }
    public abstract class Generator : JSONObjectGenerator
      {
        private SoundHoundArtistIDJSON.HoldingGenerator fieldGeneratorArtistID;
        private JSONHoldingStringGenerator fieldGeneratorArtistName;
        private JSONHoldingStringGenerator fieldGeneratorArtistImageURL;
        private JSONHoldingStringGenerator fieldGeneratorBiography;
        private JSONHoldingStringGenerator fieldGeneratorBirthPlace;
        private JSONHoldingStringGenerator fieldGeneratorBirthDate;
        private JSONHoldingStringGenerator fieldGeneratorDeathPlace;
        private JSONHoldingStringGenerator fieldGeneratorDeathDate;
    private abstract class FieldGeneratorArtistType : JSONStringGenerator
          {
            protected FieldGeneratorArtistType(string what)
              {
                set_what(what);
              }
            protected FieldGeneratorArtistType()
              {
              }
            protected override void handle_result(string result)
              {
                TypeArtistTypeKnownValues known = stringToArtistType(result);
                TypeArtistType new_value = new TypeArtistType();
                if (known == TypeArtistTypeKnownValues.ArtistType__none)
                  {
                    new_value.in_known_list = false;
                    new_value.string_value = result;
                  }
                else
                  {
                    new_value.in_known_list = true;
                    new_value.list_value = known;
                  }
                handle_result(new_value);
              }
            protected abstract void handle_result(TypeArtistType result);
          };
    private class FieldHoldingGeneratorArtistType : FieldGeneratorArtistType
  {
    protected override void handle_result(TypeArtistType result)
      {
//@@@        Debug.Assert(!have_value);
        have_value = true;
        value = result;
      }

    public FieldHoldingGeneratorArtistType(String what)
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
    public TypeArtistType value;
  };
    private class FieldHoldingArrayGeneratorArtistType : JSONArrayGenerator
  {
    protected class ElementHandler : FieldGeneratorArtistType
      {
        private FieldHoldingArrayGeneratorArtistType top;

        protected override void handle_result(TypeArtistType result)
          {
            top.value.Add(result);
          }
        protected override string get_what()
          {
            return "element " + top.value.Count + " of " + top.get_what();
          }

        public ElementHandler(FieldHoldingArrayGeneratorArtistType init_top)
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
    protected virtual void handle_result(List<TypeArtistType> result)
      {
      }

    public FieldHoldingArrayGeneratorArtistType(string what)
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeArtistType>();
        base.set_what(what);
      }
    public FieldHoldingArrayGeneratorArtistType()
      {
        element_handler = new ElementHandler(this);
        have_value = false;
        value = new List<TypeArtistType>();
      }

    public override void reset()
      {
        element_handler.reset();
        have_value = false;
        value.Clear();
        base.reset();
      }

    public bool have_value;
    public List<TypeArtistType> value;
  };
        private FieldHoldingGeneratorArtistType fieldGeneratorArtistType;
        private MusicBuyLinkJSON.HoldingArrayGenerator fieldGeneratorBuyLinks;
        private MusicThirdPartyIdListJSON.HoldingArrayGenerator fieldGeneratorMusicThirdPartyIds;
        private JSONHoldingStringArrayGenerator fieldGeneratorStyles;
        private MusicTrackBaseJSON.HoldingGenerator fieldGeneratorEarliestTrack;
        private MusicTrackBaseJSON.HoldingGenerator fieldGeneratorLatestTrack;
        private MusicAlbumBaseJSON.HoldingGenerator fieldGeneratorEarliestAlbum;
        private MusicAlbumBaseJSON.HoldingGenerator fieldGeneratorLatestAlbum;

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
            MusicArtistBaseJSON result = new MusicArtistBaseJSON();
            Debug.Assert(result != null);
            finish(result);
            handle_result(result);
          }
        protected void finish(MusicArtistBaseJSON result)
          {
            if (fieldGeneratorArtistID.have_value)
              {
                result.setArtistID(fieldGeneratorArtistID.value);
                fieldGeneratorArtistID.have_value = false;
              }
            if (fieldGeneratorArtistName.have_value)
              {
                result.setArtistName(fieldGeneratorArtistName.value);
                fieldGeneratorArtistName.have_value = false;
              }
            if (fieldGeneratorArtistImageURL.have_value)
              {
                result.setArtistImageURL(fieldGeneratorArtistImageURL.value);
                fieldGeneratorArtistImageURL.have_value = false;
              }
            if (fieldGeneratorBiography.have_value)
              {
                result.setBiography(fieldGeneratorBiography.value);
                fieldGeneratorBiography.have_value = false;
              }
            if (fieldGeneratorBirthPlace.have_value)
              {
                result.setBirthPlace(fieldGeneratorBirthPlace.value);
                fieldGeneratorBirthPlace.have_value = false;
              }
            if (fieldGeneratorBirthDate.have_value)
              {
                result.setBirthDate(fieldGeneratorBirthDate.value);
                fieldGeneratorBirthDate.have_value = false;
              }
            if (fieldGeneratorDeathPlace.have_value)
              {
                result.setDeathPlace(fieldGeneratorDeathPlace.value);
                fieldGeneratorDeathPlace.have_value = false;
              }
            if (fieldGeneratorDeathDate.have_value)
              {
                result.setDeathDate(fieldGeneratorDeathDate.value);
                fieldGeneratorDeathDate.have_value = false;
              }
            if (fieldGeneratorArtistType.have_value)
              {
                result.setArtistType(fieldGeneratorArtistType.value);
                fieldGeneratorArtistType.have_value = false;
              }
            if (fieldGeneratorBuyLinks.have_value)
              {
                result.initBuyLinks();
                int count = fieldGeneratorBuyLinks.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendBuyLinks(fieldGeneratorBuyLinks.value[num]);
                  }
                fieldGeneratorBuyLinks.value.Clear();
                fieldGeneratorBuyLinks.have_value = false;
              }
            if (fieldGeneratorMusicThirdPartyIds.have_value)
              {
                result.initMusicThirdPartyIds();
                int count = fieldGeneratorMusicThirdPartyIds.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendMusicThirdPartyIds(fieldGeneratorMusicThirdPartyIds.value[num]);
                  }
                fieldGeneratorMusicThirdPartyIds.value.Clear();
                fieldGeneratorMusicThirdPartyIds.have_value = false;
              }
            if (fieldGeneratorStyles.have_value)
              {
                result.initStyles();
                int count = fieldGeneratorStyles.value.Count;
                for (int num = 0; num < count; ++num)
                  {
                    result.appendStyles(fieldGeneratorStyles.value[num]);
                  }
                fieldGeneratorStyles.value.Clear();
                fieldGeneratorStyles.have_value = false;
              }
            if (fieldGeneratorEarliestTrack.have_value)
              {
                result.setEarliestTrack(fieldGeneratorEarliestTrack.value);
                fieldGeneratorEarliestTrack.have_value = false;
              }
            if (fieldGeneratorLatestTrack.have_value)
              {
                result.setLatestTrack(fieldGeneratorLatestTrack.value);
                fieldGeneratorLatestTrack.have_value = false;
              }
            if (fieldGeneratorEarliestAlbum.have_value)
              {
                result.setEarliestAlbum(fieldGeneratorEarliestAlbum.value);
                fieldGeneratorEarliestAlbum.have_value = false;
              }
            if (fieldGeneratorLatestAlbum.have_value)
              {
                result.setLatestAlbum(fieldGeneratorLatestAlbum.value);
                fieldGeneratorLatestAlbum.have_value = false;
              }
          }
        protected abstract void handle_result(MusicArtistBaseJSON new_result);
        protected virtual JSONHandler start_known_field(string field_name)
          {
            switch (field_name[0])
              {
                case 'A':
                    if (String.Compare(field_name, 1, "rtist", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'I':
                                switch (field_name[7])
                                  {
                                    case 'D':
                                        if (field_name.Length == 8)
                                            return fieldGeneratorArtistID;
                                        break;
                                    case 'm':
                                        if ((String.Compare(field_name, 8, "ageURL", 0, 6, false) == 0) && (field_name.Length == 14))
                                            return fieldGeneratorArtistImageURL;
                                        break;
                                    default:
                                        break;
                                  }
                                break;
                            case 'N':
                                if ((String.Compare(field_name, 7, "ame", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorArtistName;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 7, "ype", 0, 3, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorArtistType;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'B':
                    switch (field_name[1])
                      {
                        case 'i':
                            switch (field_name[2])
                              {
                                case 'o':
                                    if ((String.Compare(field_name, 3, "graphy", 0, 6, false) == 0) && (field_name.Length == 9))
                                        return fieldGeneratorBiography;
                                    break;
                                case 'r':
                                    if (String.Compare(field_name, 3, "th", 0, 2, false) == 0)
                                      {
                                        switch (field_name[5])
                                          {
                                            case 'D':
                                                if ((String.Compare(field_name, 6, "ate", 0, 3, false) == 0) && (field_name.Length == 9))
                                                    return fieldGeneratorBirthDate;
                                                break;
                                            case 'P':
                                                if ((String.Compare(field_name, 6, "lace", 0, 4, false) == 0) && (field_name.Length == 10))
                                                    return fieldGeneratorBirthPlace;
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
                        case 'u':
                            if ((String.Compare(field_name, 2, "yLinks", 0, 6, false) == 0) && (field_name.Length == 8))
                                return fieldGeneratorBuyLinks;
                            break;
                        default:
                            break;
                      }
                    break;
                case 'D':
                    if (String.Compare(field_name, 1, "eath", 0, 4, false) == 0)
                      {
                        switch (field_name[5])
                          {
                            case 'D':
                                if ((String.Compare(field_name, 6, "ate", 0, 3, false) == 0) && (field_name.Length == 9))
                                    return fieldGeneratorDeathDate;
                                break;
                            case 'P':
                                if ((String.Compare(field_name, 6, "lace", 0, 4, false) == 0) && (field_name.Length == 10))
                                    return fieldGeneratorDeathPlace;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'E':
                    if (String.Compare(field_name, 1, "arliest", 0, 7, false) == 0)
                      {
                        switch (field_name[8])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 9, "lbum", 0, 4, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorEarliestAlbum;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 9, "rack", 0, 4, false) == 0) && (field_name.Length == 13))
                                    return fieldGeneratorEarliestTrack;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'L':
                    if (String.Compare(field_name, 1, "atest", 0, 5, false) == 0)
                      {
                        switch (field_name[6])
                          {
                            case 'A':
                                if ((String.Compare(field_name, 7, "lbum", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorLatestAlbum;
                                break;
                            case 'T':
                                if ((String.Compare(field_name, 7, "rack", 0, 4, false) == 0) && (field_name.Length == 11))
                                    return fieldGeneratorLatestTrack;
                                break;
                            default:
                                break;
                          }
                      }
                    break;
                case 'M':
                    if ((String.Compare(field_name, 1, "usicThirdPartyIds", 0, 17, false) == 0) && (field_name.Length == 18))
                        return fieldGeneratorMusicThirdPartyIds;
                    break;
                case 'S':
                    if ((String.Compare(field_name, 1, "tyles", 0, 5, false) == 0) && (field_name.Length == 6))
                        return fieldGeneratorStyles;
                    break;
                default:
                    break;
              }
            return null;
          }
        public Generator(bool ignore_extras)
          {
            fieldGeneratorArtistID = new SoundHoundArtistIDJSON.HoldingGenerator("field \"ArtistID\" of the MusicArtistBase class", ignore_extras);
            fieldGeneratorArtistName = new JSONHoldingStringGenerator("field \"ArtistName\" of the MusicArtistBase class");
            fieldGeneratorArtistImageURL = new JSONHoldingStringGenerator("field \"ArtistImageURL\" of the MusicArtistBase class");
            fieldGeneratorBiography = new JSONHoldingStringGenerator("field \"Biography\" of the MusicArtistBase class");
            fieldGeneratorBirthPlace = new JSONHoldingStringGenerator("field \"BirthPlace\" of the MusicArtistBase class");
            fieldGeneratorBirthDate = new JSONHoldingStringGenerator("field \"BirthDate\" of the MusicArtistBase class");
            fieldGeneratorDeathPlace = new JSONHoldingStringGenerator("field \"DeathPlace\" of the MusicArtistBase class");
            fieldGeneratorDeathDate = new JSONHoldingStringGenerator("field \"DeathDate\" of the MusicArtistBase class");
            fieldGeneratorArtistType = new FieldHoldingGeneratorArtistType("field \"ArtistType\" of the MusicArtistBase class");
            fieldGeneratorBuyLinks = new MusicBuyLinkJSON.HoldingArrayGenerator("field \"BuyLinks\" of the MusicArtistBase class", ignore_extras);
            fieldGeneratorMusicThirdPartyIds = new MusicThirdPartyIdListJSON.HoldingArrayGenerator("field \"MusicThirdPartyIds\" of the MusicArtistBase class", ignore_extras);
            fieldGeneratorStyles = new JSONHoldingStringArrayGenerator("field \"Styles\" of the MusicArtistBase class");
            fieldGeneratorEarliestTrack = new MusicTrackBaseJSON.HoldingGenerator("field \"EarliestTrack\" of the MusicArtistBase class", ignore_extras);
            fieldGeneratorLatestTrack = new MusicTrackBaseJSON.HoldingGenerator("field \"LatestTrack\" of the MusicArtistBase class", ignore_extras);
            fieldGeneratorEarliestAlbum = new MusicAlbumBaseJSON.HoldingGenerator("field \"EarliestAlbum\" of the MusicArtistBase class", ignore_extras);
            fieldGeneratorLatestAlbum = new MusicAlbumBaseJSON.HoldingGenerator("field \"LatestAlbum\" of the MusicArtistBase class", ignore_extras);
            set_what("the MusicArtistBase class");
            allow_incomplete = false;
            allow_unpolished = false;
          }
        public Generator()
          {
            fieldGeneratorArtistID = new SoundHoundArtistIDJSON.HoldingGenerator("field \"ArtistID\" of the MusicArtistBase class", false);
            fieldGeneratorArtistName = new JSONHoldingStringGenerator("field \"ArtistName\" of the MusicArtistBase class");
            fieldGeneratorArtistImageURL = new JSONHoldingStringGenerator("field \"ArtistImageURL\" of the MusicArtistBase class");
            fieldGeneratorBiography = new JSONHoldingStringGenerator("field \"Biography\" of the MusicArtistBase class");
            fieldGeneratorBirthPlace = new JSONHoldingStringGenerator("field \"BirthPlace\" of the MusicArtistBase class");
            fieldGeneratorBirthDate = new JSONHoldingStringGenerator("field \"BirthDate\" of the MusicArtistBase class");
            fieldGeneratorDeathPlace = new JSONHoldingStringGenerator("field \"DeathPlace\" of the MusicArtistBase class");
            fieldGeneratorDeathDate = new JSONHoldingStringGenerator("field \"DeathDate\" of the MusicArtistBase class");
            fieldGeneratorArtistType = new FieldHoldingGeneratorArtistType("field \"ArtistType\" of the MusicArtistBase class");
            fieldGeneratorBuyLinks = new MusicBuyLinkJSON.HoldingArrayGenerator("field \"BuyLinks\" of the MusicArtistBase class", false);
            fieldGeneratorMusicThirdPartyIds = new MusicThirdPartyIdListJSON.HoldingArrayGenerator("field \"MusicThirdPartyIds\" of the MusicArtistBase class", false);
            fieldGeneratorStyles = new JSONHoldingStringArrayGenerator("field \"Styles\" of the MusicArtistBase class");
            fieldGeneratorEarliestTrack = new MusicTrackBaseJSON.HoldingGenerator("field \"EarliestTrack\" of the MusicArtistBase class", false);
            fieldGeneratorLatestTrack = new MusicTrackBaseJSON.HoldingGenerator("field \"LatestTrack\" of the MusicArtistBase class", false);
            fieldGeneratorEarliestAlbum = new MusicAlbumBaseJSON.HoldingGenerator("field \"EarliestAlbum\" of the MusicArtistBase class", false);
            fieldGeneratorLatestAlbum = new MusicAlbumBaseJSON.HoldingGenerator("field \"LatestAlbum\" of the MusicArtistBase class", false);
            set_what("the MusicArtistBase class");
            allow_incomplete = false;
            allow_unpolished = false;
          }

        public override void reset()
          {
            fieldGeneratorArtistID.reset();
            fieldGeneratorArtistName.reset();
            fieldGeneratorArtistImageURL.reset();
            fieldGeneratorBiography.reset();
            fieldGeneratorBirthPlace.reset();
            fieldGeneratorBirthDate.reset();
            fieldGeneratorDeathPlace.reset();
            fieldGeneratorDeathDate.reset();
            fieldGeneratorArtistType.reset();
            fieldGeneratorBuyLinks.reset();
            fieldGeneratorMusicThirdPartyIds.reset();
            fieldGeneratorStyles.reset();
            fieldGeneratorEarliestTrack.reset();
            fieldGeneratorLatestTrack.reset();
            fieldGeneratorEarliestAlbum.reset();
            fieldGeneratorLatestAlbum.reset();
            base.reset();
          }
        public void set_allow_incomplete(bool new_allow_incomplete)
          {
            allow_incomplete = new_allow_incomplete;
            fieldGeneratorArtistID.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorBuyLinks.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorMusicThirdPartyIds.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEarliestTrack.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLatestTrack.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorEarliestAlbum.set_allow_incomplete(new_allow_incomplete);
            fieldGeneratorLatestAlbum.set_allow_incomplete(new_allow_incomplete);
          }
        public void set_allow_unpolished(bool new_allow_unpolished)
          {
            allow_unpolished = new_allow_unpolished;
            fieldGeneratorArtistID.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorBuyLinks.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorMusicThirdPartyIds.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEarliestTrack.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLatestTrack.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorEarliestAlbum.set_allow_unpolished(new_allow_unpolished);
            fieldGeneratorLatestAlbum.set_allow_unpolished(new_allow_unpolished);
          }
      };
    public class HoldingGenerator : Generator
      {
        protected override void handle_result(MusicArtistBaseJSON  result)
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
        public MusicArtistBaseJSON value;
      };
    public class HoldingArrayGenerator : JSONArrayGenerator
  {
    protected class ElementHandler : Generator
      {
        private HoldingArrayGenerator top;

        protected override void handle_result(MusicArtistBaseJSON  result)
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
    protected virtual void handle_result(List<MusicArtistBaseJSON> result)

      {
      }

    public HoldingArrayGenerator(string what, bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        have_value = false;
        value = new List<MusicArtistBaseJSON>();
        base.set_what(what);
      }
    public HoldingArrayGenerator(bool ignore_extras)
      {
        element_handler = new ElementHandler(this, ignore_extras);
        value = new List<MusicArtistBaseJSON>();
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
    public List<MusicArtistBaseJSON> value;
  };
  };
